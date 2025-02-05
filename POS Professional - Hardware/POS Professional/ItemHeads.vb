Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ItemHeads
    Dim EditString As String
    Dim Pos, MaxID As Integer
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub DepartmentList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.BindingSource.Dispose()
        Connection.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub DepartmentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub LoadDB()
        Try
            Dim LoadQuery As String = "SELECT * FROM HEADS ORDER BY head_id"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, LoadQuery, "HEADS", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "HEADS")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "HEADS"
            Me.txtName.DataBindings.Add("TEXT", BindingSource, "head_name")
            Me.txtID.DataBindings.Add("TEXT", BindingSource, "HEAD_ID")
            Addition = False
            Editing = False
            BindingNavigatorSave.Enabled = False
            txtName.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Application.Exit()
        End Try
    End Sub

    Private Sub RefreshDB()
        Try
            Me.DataSet.Clear()
            Dim CommandText As String = "SELECT * FROM HEADS ORDER BY head_id"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "HEADS", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "HEADS")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "HEADS"
            Me.DeptDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        txtName.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        Me.BindingNavigatorSave.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        txtName.Focus()
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click
        Editing = True
        Addition = False
        txtName.Enabled = True
        BindingNavigatorSave.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        EditString = txtID.Text.Trim
        txtName.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim DeleteQuery As String = ""
        MsgBox("Are you sure to delete ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, My.Application.Info.ProductName)
        If MsgBoxResult.Ok Then DeleteQuery = "DELETE FROM HEADS WHERE head_name = '" & txtName.Text.ToUpper & "'"
        ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, DeleteQuery, "heads", Connection)
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        Dim Edit_Update_Query As String = String.Empty
        If Addition = True Then txtID.Text = GenerateMax_ID("heads", "head_id")
        If Editing = True Then ProcessTransaction("UPDATE HEADS SET head_name = '" & StrConv(txtName.Text.Trim, VbStrConv.Uppercase) & "' WHERE head_id = " & Val(EditString))
        If Addition = True Then ProcessTransaction("INSERT INTO HEADS VALUES('" & StrConv(txtName.Text.Trim, VbStrConv.Uppercase) & "'," & Val(txtID.Text) & ")")
        Call RefreshDB()
        BindingNavigatorSave.Enabled = False
        Me.ToolStripCloseButton.Text = "&Close"
        SqlDataAdapter.Dispose()
        Connection.Close()
        txtName.Enabled = False
    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If ToolStripCloseButton.Text = "&Close" Then
            Connection.Close()
            Me.Close()
            StockMenu.WindowState = FormWindowState.Normal
        Else
            ToolStripCloseButton.Text = "&Close"
            Addition = False
            Editing = False
            BindingNavigatorSave.Enabled = False
            txtName.Enabled = False
            Call RefreshDB()
        End If
    End Sub
End Class