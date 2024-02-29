Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmExpenseList
    Dim EditString As String
    Dim Pos As Integer
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        txtName.Enabled = True
        txtCategory.Enabled = True
        txtName.Focus()
        Addition = True
        RollBack = True
        Editing = False
        Me.BindingNavigatorSave.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim DeleteQuery As String = ""
        MsgBox("Are you sure to delete ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, My.Application.Info.ProductName)
        If MsgBoxResult.Ok Then DeleteQuery = "DELETE FROM DAILY_EXPENSE_ACC WHERE EXP_NAME = '" & txtName.Text.ToUpper & "'"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, DeleteQuery, "DAILY_EXPENSE_ACC", Connection)
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click
        Editing = True
        Addition = False
        txtName.Enabled = True
        txtCategory.Enabled = True
        BindingNavigatorSave.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        EditString = txtName.Text.Trim
        txtName.Focus()
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        Dim Edit_Update_Query As String = ""
        If Editing = True And Addition = False Then Edit_Update_Query = "UPDATE DAILY_EXPENSE_ACC SET EXP_NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "', EXP_CATG = '" & txtCategory.Text.Trim & "' WHERE EXP_NAME = '" & EditString & "'"
        If Addition = True And Editing = False Then Edit_Update_Query = "INSERT INTO DAILY_EXPENSE_ACC VALUES('" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','" & txtCategory.Text.Trim & "')"
        Execute_DatabaseTable_Query(SqlDataAdapt, Edit_Update_Query, Connection)
        Call RefreshDB()
        BindingNavigatorSave.Enabled = False
        Me.ToolStripCloseButton.Text = "&Close"
        SqlDataAdapt.Dispose()
        Connection.Close()
    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If ToolStripCloseButton.Text = "&Close" Then
            Connection.Close()
            Me.Close()
        Else
            ToolStripCloseButton.Text = "&Close"
            Addition = False
            Editing = False
            BindingNavigatorSave.Enabled = False
            txtName.Enabled = False
            txtCategory.Enabled = False
            Call RefreshDB()
        End If
    End Sub
    Private Sub LoadDB()
        Try
            Dim LoadQuery As String = "SELECT * FROM DAILY_EXPENSE_ACC ORDER BY DOC_NAME"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, LoadQuery, "DAILY_EXPENSE_ACC", Connection)
            SqlDataAdapt.Fill(Me.ExpDataSet, "DAILY_EXPENSE_ACC")
            Me.ExpBindingSource.DataSource = Me.ExpDataSet
            Me.ExpBindingSource.DataMember = "DAILY_EXPENSE_ACC"
            Me.txtName.DataBindings.Add("TEXT", ExpBindingSource, "EXP_NAME")
            Me.txtCategory.DataBindings.Add("TEXT", ExpBindingSource, "EXP_CATG")
            Addition = False
            Editing = False
            BindingNavigatorSave.Enabled = False
            txtName.Enabled = False
            txtCategory.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            DocDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub
    Private Sub RefreshDB()
        Try
            Me.ExpDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM DAILY_EXPENSE_ACC ORDER BY EXP_NAME"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "DAILY_EXPENSE_ACC", Connection)
            SqlDataAdapt.Fill(Me.ExpDataSet, "DAILY_EXPENSE_ACC")
            Me.ExpBindingSource.DataSource = Me.ExpDataSet
            Me.ExpBindingSource.DataMember = "DAILY_EXPENSE_ACC"
            Me.DocDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub frmExpenseList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Filler As SqlDataReader
            Dim commandtext As String = "SELECT DISTINCT ACC_NAME FROM ACCOUNTS ORDER BY ACC_NAME"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, commandtext, "ACCOUNTS", Connection)
            Filler = SqlDataAdapt.SelectCommand.ExecuteReader
            While Filler.Read
                Me.txtCategory.Items.Add(Filler.Item("ACC_NAME").ToString.Trim)
            End While
            If Not Filler Is Nothing Then Filler.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub
End Class