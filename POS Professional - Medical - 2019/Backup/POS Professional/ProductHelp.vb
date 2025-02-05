Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class ProductHelp
    Dim FirstLoad As Boolean = True

    Private Sub ProduHelp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then gblCP_ID = String.Empty : Me.Close()
        If e.KeyCode = Keys.Enter Then
            Try
                Dim CommandText As String = "SELECT PROD_DESC, PROD_CODE, PROD_DISC_ALLOW, PROD_PURCH_PRICE, PROD_WSALE_PRICE, PROD_SALE_PRICE FROM PRODUCTS WHERE PROD_DESC = N'" & Trim(ComboBox1.Text.Trim) & "'"
                ExecuteDatasetQuery(ProductCodeAdapter, ProductCodeDataset, CommandText, "PRODUCTS", Connection)
                gblCP_ID = Val(ProductCodeDataset.Tables("PRODUCTS").Rows(0).Item("PROD_CODE").ToString.Trim)
                gblCP = ProductCodeDataset.Tables("PRODUCTS").Rows(0).Item("PROD_DESC").ToString.Trim
                Connection.Close()
            Catch EXCP As Exception
                MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox1.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(ComboBox1.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim Name As String = drv("Name").ToString()
        Dim ID As String = drv("ID").ToString()
        Dim TP As String = drv("TP").ToString()
        Dim RP As String = drv("RP").ToString()
        Dim SP As String = drv("SP").ToString()

        ' Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width / 4

        ' Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(Name, e.Font, sb, r1)
        End Using

        ' Get the bounds for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width / 3
        r2.Width = r2.Width / 4

        ' Draw the text on the second column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(ID, e.Font, sb, r2)
        End Using

        ' Get the bounds for the third column
        Dim r3 As Rectangle = e.Bounds
        r3.X = e.Bounds.Width / 2.2
        r3.Width = r2.Width / 4

        ' Draw the text on the third column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(TP, e.Font, sb, r3)
        End Using

        ' Get the bounds for the fourth column
        Dim r4 As Rectangle = e.Bounds
        r4.X = e.Bounds.Width / 1.6
        r4.Width = r4.Width / 4

        ' Draw the text on the fourth column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(RP, e.Font, sb, r4)
        End Using

        ' Get the bounds for the fifth column
        Dim r5 As Rectangle = e.Bounds
        r5.X = e.Bounds.Width / 1.2
        r5.Width = r5.Width / 4

        ' Draw the text on the fourth column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(SP, e.Font, sb, r5)
        End Using

        ' Draw a line to isolate the columns 
        Using p As Pen = New Pen(Color.LimeGreen)
            e.Graphics.DrawLine(p, r1.Right + 30, 0, r1.Right + 30, r1.Bottom)
            e.Graphics.DrawLine(p, r1.Right + 110, 0, r1.Right + 110, r2.Bottom)
            e.Graphics.DrawLine(p, r1.Right + 240, 0, r1.Right + 240, r2.Bottom)
            e.Graphics.DrawLine(p, r1.Right + 390, 0, r1.Right + 390, r2.Bottom)
        End Using

        FirstLoad = False
    End Sub

    Private Sub ProductHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Dim CommandText As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CODE"
        ExecuteAdapterQuery(ProductCodeAdapter, CommandText, Connection)
        Dim Reader As SqlDataReader = ProductCodeAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows = False Then
            gblMessage = "Please add custoemrs in the account table."
            MsgStatus.ShowDialog(Me)
            Me.Close()
            Exit Sub
        End If
        Dim dtTest As DataTable = New DataTable()
        dtTest.Columns.Add("Name", GetType(String))
        dtTest.Columns.Add("Id", GetType(String))
        dtTest.Columns.Add("Disc", GetType(String))
        dtTest.Columns.Add("TP", GetType(String))
        dtTest.Columns.Add("RP", GetType(String))
        dtTest.Columns.Add("SP", GetType(String))

        While Reader.Read
            dtTest.Rows.Add(Reader.Item("prod_desc".ToString.Trim), Reader.Item("prod_code").ToString.Trim, Reader.Item("prod_disc_allow").ToString.Trim, Reader.Item("prod_purch_price").ToString.Trim, Reader.Item("prod_wsale_price").ToString.Trim, Reader.Item("prod_sale_price").ToString.Trim)
        End While
        If Reader Is Nothing Then Reader.Close()
        ' Bind the ComboBox to the DataTable
        Me.ComboBox1.DataSource = dtTest
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.ValueMember = "ID"

        ' Enable the owner draw on the ComboBox.
        Me.ComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        ' Handle the DrawItem event to draw the items.
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'For Mouse Click
        'If FirstLoad = False Then
        '    Try
        '        Dim CommandText As String = "SELECT PROD_DESC, PROD_CODE, PROD_DISC_ALLOW, PROD_PURCH_PRICE, PROD_WSALE_PRICE, PROD_SALE_PRICE FROM PRODUCTS WHERE PROD_NAME = N'" & Trim(ComboBox1.Text.Trim) & "'"
        '        ExecuteDatasetQuery(ProductCodeAdapter, ProductCodeDataset, CommandText, "PRODUCTS", Connection)
        '        gblCP_ID = Val(ProductCodeDataset.Tables("PRODUCTS").Rows(0).Item("PROD_CODE").ToString.Trim)
        '        gblCP = ProductCodeDataset.Tables("PRODUCTS").Rows(0).Item("PROD_DESC").ToString.Trim
        '        Connection.Close()
        '    Catch EXCP As Exception
        '        MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        '    End Try
        'End If
    End Sub
End Class