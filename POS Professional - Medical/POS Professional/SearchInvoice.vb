Imports System.Data.SqlClient

Public Class SearchInvoice
    Dim SearchAdapter As New SqlDataAdapter()
    Dim SearchDataSet As New DataSet()
    Dim SearchBinding As New BindingSource()

    Private Sub SearchInvoice_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dgvSearch.Focus()
    End Sub

    Private Sub SearchInvoice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then gblCP = String.Empty : gblCP_ID = 0 : Me.Close()
        'If e.KeyCode = Keys.Enter Then gblCP_ID = dgvSearch.Rows(dgvSearch.CurrentRow.Index).Cells(0).Value : Me.Close()
    End Sub

    Private Sub SearchInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetConnectionString()
        SearchDataSet.Clear()
        ExecuteAdapterQuery(SearchAdapter, gblQuery, Connection)
        SearchAdapter.Fill(SearchDataSet, "sale_master")
        SearchBinding.DataSource = SearchDataSet
        dgvSearch.DataSource = SearchBinding
        dgvSearch.DataMember = "sale_master"
    End Sub

    Private Sub dgvSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            gblCP_ID = dgvSearch.Rows(dgvSearch.CurrentRow.Index).Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class