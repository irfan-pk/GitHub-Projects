Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class CategoryList
    Dim EditString As String
    Dim Pos, MaxID As Integer
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub frmDocList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.BindingSource.Dispose()
        Connection.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CategoryList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DepartmentSqlAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(DepartmentSqlAdapter, "select * from heads order by head_id", Connection)
        Dim DeptReader As SqlDataReader = DepartmentSqlAdapter.SelectCommand.ExecuteReader
        If DeptReader.HasRows Then
            While DeptReader.Read
                cmbDept.Items.Add(DeptReader.Item("head_name").ToString)
            End While
            If DeptReader Is Nothing Then DeptReader.Close()
        End If
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        cmbCategory.Enabled = True
        cmbDept.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        Me.BindingNavigatorSave.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        cmbCategory.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(cmbCategory.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            ProcessTransaction("DELETE FROM category WHERE CATEGORY_ID = '" & txtID.Text.ToUpper & "' AND CATEGORY = '" & cmbCategory.Text.Trim & "' and HEAD = '" & cmbDept.Text.Trim & "'")
            DocDataGridView.Update()
        Else
            DocDataGridView.CancelEdit()
            Call RefreshDB()
        End If
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click
        Editing = True
        Addition = False
        cmbCategory.Enabled = True
        cmbDept.Enabled = True
        EditString = txtID.Text.Trim
        Me.ToolStripCloseButton.Text = "&Cancel"
        BindingNavigatorSave.Enabled = True
        cmbDept.Focus()
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        If Addition = True Then txtID.Text = GenerateMax_ID("category", "category_id")
        If Editing = True Then ProcessTransaction("update CATEGORY set category = '" & StrConv(cmbCategory.Text.Trim, VbStrConv.Uppercase) & "', HEAD = '" & cmbDept.Text.Trim.ToUpper & "' where CATEGORY_ID = " & Val(EditString))
        If Addition = True Then ProcessTransaction("INSERT INTO CATEGORY VALUES(" & Val(txtID.Text.ToString) & ",'" & cmbDept.Text.Trim.ToUpper & "','" & cmbCategory.Text.Trim.ToUpper & "')")
        Call RefreshDB()
        BindingNavigatorSave.Enabled = False
        Me.ToolStripCloseButton.Text = "&Close"
        SqlDataAdapter.Dispose()
        Connection.Close()
        cmbCategory.Enabled = False
        cmbDept.Enabled = False
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
            cmbCategory.Enabled = False
            cmbDept.Enabled = False
            Call RefreshDB()
        End If
    End Sub

    Private Sub LoadDB()
        Try
            Dim LoadQuery As String = "SELECT * FROM CATEGORY ORDER BY CATEGORY_ID"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, LoadQuery, "CATEGORY", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "CATEGORY")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "CATEGORY"
            Me.cmbCategory.DataBindings.Add("TEXT", BindingSource, "CATEGORY")
            Me.cmbDept.DataBindings.Add("TEXT", BindingSource, "HEAD")
            Me.txtID.DataBindings.Add("TEXT", BindingSource, "CATEGORY_ID")
            Addition = False
            Editing = False
            BindingNavigatorSave.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub RefreshDB()
        Try
            Me.DataSet.Clear()
            Dim CommandText As String = "SELECT * FROM CATEGORY ORDER BY CATEGORY_ID"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "CATEGORY", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "CATEGORY")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "CATEGORY"
            Me.DocDataGridView.Update()
            Me.DocDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub
End Class