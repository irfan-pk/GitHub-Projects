Imports System.Data
Imports System.Data.SqlClient

Public Class ProductSearch

    Private Sub ProductSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtDesc.Focus()
    End Sub

    Private Sub ProductSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then gblItemCode = String.Empty : Me.Close()
    End Sub

    Private Sub ProductSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        ProductDataGridView.DataSource = Nothing
        ExecuteDatasetQuery(SqlDataAdapter, Me.DataSet1, "select * from products order by prod_desc", "products", Connection)
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.DataMember = "products"
        ProductDataGridView.DataSource = Me.BindingSource1
        txtDesc.Focus()
    End Sub

    Private Sub txtBrand_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrand.KeyPress
        Me.BindingSource1.Filter = "prod_brand Like '" & txtBrand.Text & "%'"
        'Call FilterRows()
    End Sub

    Private Sub txtSubCatg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBrand.TextChanged
        Me.BindingSource1.Filter = "prod_brand Like '" & txtBrand.Text & "%'"
        'Call FilterRows()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        Me.BindingSource1.Filter = "prod_code Like '" & txtCode.Text & "%'"
        'Call FilterRows()
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        Me.BindingSource1.Filter = "prod_code Like '" & txtCode.Text & "%'"
        'Call FilterRows()
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        Me.BindingSource1.Filter = "prod_desc Like '" & txtDesc.Text & "%'"
        'Call FilterRows()
    End Sub

    Private Sub txtDesc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.TextChanged
        Me.BindingSource1.Filter = "prod_desc Like '" & txtDesc.Text & "%'"
        'Call FilterRows()
    End Sub

    Private Sub txtCatg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCatg.KeyPress
        Me.BindingSource1.Filter = "prod_catg Like '" & txtCatg.Text & "%'"
        'Call FilterRows()
    End Sub

    Private Sub txtCatg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCatg.TextChanged
        Me.BindingSource1.Filter = "prod_catg Like '" & txtCatg.Text & "%'"
        'Call FilterRows()
    End Sub

    Private Sub ProductDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductDataGridView.CellDoubleClick
        If ProductDataGridView.RowCount > 0 Then
            gblItemCode = ProductDataGridView.Rows(ProductDataGridView.CurrentRow.Index).Cells(0).Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub ProductDataGridView_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ProductDataGridView.CellMouseDoubleClick
        If ProductDataGridView.RowCount > 0 Then
            gblItemCode = ProductDataGridView.Rows(ProductDataGridView.CurrentRow.Index).Cells(0).Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub txtSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSize.KeyPress
        Me.BindingSource1.Filter = "prod_size Like '" & txtSize.Text & "%'"
    End Sub

    Private Sub txtSize_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSize.TextChanged
        Me.BindingSource1.Filter = "prod_size Like '" & txtSize.Text & "%'"
    End Sub
End Class