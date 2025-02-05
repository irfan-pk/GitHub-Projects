Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class frmCustCode
    Private Sub frmCustCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.Enter Then
            Try
                Dim CommandText As String = "SELECT * FROM CUSTOMERS WHERE CUST_NAME = N'" & Trim(ListBox1.Text.Trim) & "'"
                ExecuteDatasetQuery(ProductCodeAdapter, ProductCodeDataset, CommandText, "CUSTOMERS", Connection)
                gblCP_ID = ProductCodeDataset.Tables("CUSTOMERS").Rows(0).Item("CUST_CODE").ToString.Trim
                gblCP = ProductCodeDataset.Tables("CUSTOMERS").Rows(0).Item("CUST_NAME").ToString.Trim
                Connection.Close()
                'Me.Close()
            Catch EXCP As Exception
                MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Me.Close()
        End If

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Call GetConnectionString()
        'Query to select customers from table
        Dim CommandText As String = "SELECT * FROM CUSTOMERS ORDER BY CUST_CODE"
        ExecuteAdapterQuery(ProductCodeAdapter, CommandText, Connection)
        Dim Reader As SqlDataReader = ProductCodeAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows = False Then
            gblMessage = "Please add customer first in the table."
            frmMsgStatus.ShowDialog(Me)
            Me.Close()
            Exit Sub
        End If
        'if table has rows
        Dim dtTest As DataTable = New DataTable()
        dtTest.Columns.Add("Name", GetType(String))
        dtTest.Columns.Add("ID", GetType(String))
        While Reader.Read
            dtTest.Rows.Add(Reader.Item("cust_code".ToString.Trim), Reader.Item("cust_name").ToString.Trim)
        End While
        If Reader Is Nothing Then Reader.Close()
        ' Bind the ComboBox to the DataTable
        Me.ListBox1.DataSource = dtTest
        Me.ListBox1.DisplayMember = "ID"
        Me.ListBox1.ValueMember = "Name"

        ' Enable the owner draw on the ComboBox.
        Me.ListBox1.DrawMode = DrawMode.OwnerDrawFixed
        ' Handle the DrawItem event to draw the items.

    End Sub

    Private Sub ListBox1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(ListBox1.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim id As String = drv("ID").ToString()
        Dim name As String = drv("Name").ToString()

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
    End Sub

End Class