Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ITEMTYPES
    Dim EditString As String
    Dim Pos, MaxID As Integer
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub ITEMTYPES_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.BindingSource.Dispose()
        Connection.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ITEMTYPES_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        Call LoadDB()
        'If DeptDataGridView.RowCount = 0 Then
        '    Call BindingNavigatorAddNewItem_Click(sender, e)
        'End If
    End Sub

    Private Sub LoadDB()
        Try
            Dim LoadQuery As String = "SELECT * FROM itemtypes ORDER BY category"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, LoadQuery, "itemtypes", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "itemtypes")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "itemtypes"
            Me.txtName.DataBindings.Add("TEXT", BindingSource, "category")
            Addition = False
            Editing = False
            BindingNavigatorSave.Enabled = False
            txtName.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub RefreshDB()
        Try
            Me.DataSet.Clear()
            Dim CommandText As String = "SELECT * FROM itemtypes ORDER BY category"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "itemtypes", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "itemtypes")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "itemtypes"
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
        EditString = txtName.Text.Trim
        txtName.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim DeleteQuery As String = ""
        MsgBox("Are you sure to delete ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, My.Application.Info.ProductName)
        If MsgBoxResult.Ok Then DeleteQuery = "DELETE FROM itemtypes WHERE category = '" & txtName.Text.ToUpper & "'"
        ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, DeleteQuery, "itemtypes", Connection)
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        Dim Edit_Update_Query As String = ""
        If Editing = True Then ProcessTransaction("UPDATE itemtypes SET CATEGORY = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "' WHERE category = '" & EditString & "'")
        If Addition = True Then ProcessTransaction("INSERT INTO itemtypes VALUES('" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "')")
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