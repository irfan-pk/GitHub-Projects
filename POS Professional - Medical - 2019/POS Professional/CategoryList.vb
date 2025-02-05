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
        ExecuteAdapterQuery(DepartmentSqlAdapter, "select * from departments order by head_category", Connection)
        Dim DeptReader As SqlDataReader = DepartmentSqlAdapter.SelectCommand.ExecuteReader
        If DeptReader.HasRows Then
            While DeptReader.Read
                cmbDept.Items.Add(DeptReader.Item("head_category").ToString)
            End While
            If DeptReader Is Nothing Then DeptReader.Close()
        End If
        Call Popup_ComboBox()
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        cmbCategory.Enabled = True
        cmbDept.Enabled = True
        txtsubcatg.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        Me.BindingNavigatorSave.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        cmbCategory.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtsubcatg.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            ProcessTransaction("DELETE FROM category WHERE SUB_CATEGORY = '" & txtsubcatg.Text.ToUpper & "' AND CATEGORY = '" & cmbCategory.Text.Trim & "' and department = '" & cmbDept.Text.Trim & "'")
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
        txtsubcatg.Enabled = True
        EditString = txtsubcatg.Text.Trim
        Me.ToolStripCloseButton.Text = "&Cancel"
        BindingNavigatorSave.Enabled = True
        cmbCategory.Focus()
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        If Editing = True Then ProcessTransaction("update CATEGORY set category = '" & StrConv(cmbCategory.Text.Trim, VbStrConv.ProperCase) & "', department = '" & cmbDept.Text.Trim & "', sub_category = '" & txtsubcatg.Text.Trim & "' where department = '" & cmbDept.Text.Trim & "' and category = '" & cmbCategory.Text.Trim & "' and sub_category = '" & EditString & "'")
        If Addition = True Then ProcessTransaction("INSERT INTO CATEGORY VALUES('" & StrConv(cmbCategory.Text.Trim, VbStrConv.ProperCase) & "','" & cmbDept.Text.Trim & "','" & txtsubcatg.Text.Trim & "')")
        Call RefreshDB()
        BindingNavigatorSave.Enabled = False
        Me.ToolStripCloseButton.Text = "&Close"
        Call Popup_ComboBox()
        SqlDataAdapter.Dispose()
        Connection.Close()
        cmbCategory.Enabled = False
        cmbDept.Enabled = False
        txtsubcatg.Enabled = False
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
            txtsubcatg.Enabled = False
            Call RefreshDB()
        End If
    End Sub
    Private Sub LoadDB()
        Try
            Dim LoadQuery As String = "SELECT * FROM CATEGORY ORDER BY CATEGORY"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, LoadQuery, "CATEGORY", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "CATEGORY")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "CATEGORY"
            Me.cmbCategory.DataBindings.Add("TEXT", BindingSource, "CATEGORY")
            Me.cmbDept.DataBindings.Add("TEXT", BindingSource, "DEPARTMENT")
            Me.txtsubcatg.DataBindings.Add("TEXT", BindingSource, "sub_category")
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
            Dim CommandText As String = "SELECT * FROM CATEGORY ORDER BY CATEGORY"
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

    Private Sub Popup_ComboBox()
        cmbCategory.Items.Clear()
        Dim DepartmentSqlAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(DepartmentSqlAdapter, "select distinct category from itemtypes order by category", Connection)
        Dim DeptReader As SqlDataReader = DepartmentSqlAdapter.SelectCommand.ExecuteReader
        If DeptReader.HasRows Then
            While DeptReader.Read
                cmbCategory.Items.Add(DeptReader.Item("category").ToString)
            End While
            If DeptReader Is Nothing Then DeptReader.Close()
        End If
    End Sub
End Class