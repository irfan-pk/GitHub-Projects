Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class AccountLists

    Private Sub frmAccList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then gblAccID = "" : Me.Close()
        If e.KeyCode = Keys.Enter Then
            Try
                Dim CommandText As String = "SELECT * FROM ACCOUNTS WHERE ACC_NAME = N'" & Trim(comboBox1.Text.Trim) & "'"
                ExecuteSqlQuery(AccAdapter, AccDataSet, CommandText, "ACCOUNTS", Connection)
                gblAccHead = AccDataSet.Tables("ACCOUNTS").Rows(0).Item("ACC_HEAD").ToString.Trim
                gblAccName = AccDataSet.Tables("ACCOUNTS").Rows(0).Item("ACC_NAME").ToString.Trim
                gblAccID = AccDataSet.Tables("ACCOUNTS").Rows(0).Item("ACC_NO").ToString.Trim
                Connection.Close()
            Catch EXCP As Exception
                MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Me.Close()
        End If

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Call GetConnectionString()
        Dim CommandText As String = "SELECT * FROM ACCOUNTS ORDER BY ACC_NO"
        Execute_DatabaseTable_Query(AccAdapter, CommandText, Connection)
        Dim Reader As SqlDataReader = AccAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows = False Then
            MsgBox("Please add account first in the table.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Dim dtTest As DataTable = New DataTable()
        dtTest.Columns.Add("Acc_Name", GetType(String))
        dtTest.Columns.Add("Acc_No", GetType(String))
        While Reader.Read
            dtTest.Rows.Add(Reader.Item("Acc_No".ToString.Trim), Reader.Item("Acc_Name").ToString.Trim)
        End While
        If Reader Is Nothing Then Reader.Close()
        ' Bind the ComboBox to the DataTable
        Me.comboBox1.DataSource = dtTest
        Me.comboBox1.DisplayMember = "Acc_No"
        Me.comboBox1.ValueMember = "Acc_Name"

        ' Enable the owner draw on the ComboBox.
        Me.comboBox1.DrawMode = DrawMode.OwnerDrawFixed
        ' Handle the DrawItem event to draw the items.
    End Sub

    Private Sub comboBox1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles comboBox1.DrawItem
        ' Draw the default background
        e.DrawBackground()

        ' The ComboBox is bound to a DataTable,
        ' so the items are DataRowView objects.
        Dim drv As DataRowView = CType(comboBox1.Items(e.Index), DataRowView)

        ' Retrieve the value of each column.
        Dim id As String = drv("Acc_No").ToString()
        Dim name As String = drv("Acc_Name").ToString()

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
