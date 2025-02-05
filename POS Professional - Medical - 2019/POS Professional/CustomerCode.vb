Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class CustomerCode
    Dim FirstLoad As Boolean = True

    Private Sub CustomerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then gblCP_ID = String.Empty : Me.Close()
        If e.KeyCode = Keys.Enter Then
            Try
                Dim CommandText As String = "SELECT ACC_NAME, ACC_NO FROM ACCOUNTS WHERE ACC_NAME = N'" & Trim(ComboBox1.Text.Trim) & "'"
                ExecuteDatasetQuery(ProductCodeAdapter, ProductCodeDataset, CommandText, "ACCOUNTS", Connection)
                gblCP_ID = Val(ProductCodeDataset.Tables("ACCOUNTS").Rows(0).Item("ACC_NO").ToString.Trim)
                gblCP = ProductCodeDataset.Tables("ACCOUNTS").Rows(0).Item("ACC_NAME").ToString.Trim
                Connection.Close()
            Catch EXCP As Exception
                MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub CustomerCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Dim CommandText As String = "SELECT ACC_NAME, ACC_NO FROM ACCOUNTS WHERE ACC_REG_TYPE = 'CUSTOMER' ORDER BY ACC_NO"
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
        While Reader.Read
            dtTest.Rows.Add(Reader.Item("acc_name".ToString.Trim), Reader.Item("acc_no").ToString.Trim)
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

    Private Sub ComboBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox1.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(ComboBox1.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim id As String = drv("Name").ToString()
        Dim name As String = drv("ID").ToString()

        ' Get the bounds for the first column
        Dim r1 As Rectangle = e.Bounds
        r1.Width = r1.Width / 2

        ' Draw the text on the first column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(id, e.Font, sb, r1)
        End Using

        ' Draw a line to isolate the columns 
        Using p As Pen = New Pen(Color.Black)
            e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom)
        End Using

        ' Get the bounds for the second column
        Dim r2 As Rectangle = e.Bounds
        r2.X = e.Bounds.Width / 2
        r2.Width = r2.Width / 2

        ' Draw the text on the second column
        Using sb As SolidBrush = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(name, e.Font, sb, r2)
        End Using
        FirstLoad = False
    End Sub

    Private Sub ComboBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox1.MouseClick
        If FirstLoad = False Then _
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If FirstLoad = False Then
            Try
                Dim CommandText As String = "SELECT ACC_NAME, ACC_NO FROM ACCOUNTS WHERE ACC_NAME = N'" & Trim(ComboBox1.Text.Trim) & "'"
                ExecuteDatasetQuery(ProductCodeAdapter, ProductCodeDataset, CommandText, "ACCOUNTS", Connection)
                gblCP_ID = Val(ProductCodeDataset.Tables("ACCOUNTS").Rows(0).Item("ACC_NO").ToString.Trim)
                gblCP = ProductCodeDataset.Tables("ACCOUNTS").Rows(0).Item("ACC_NAME").ToString.Trim
                Connection.Close()
            Catch EXCP As Exception
                MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End If
    End Sub
End Class