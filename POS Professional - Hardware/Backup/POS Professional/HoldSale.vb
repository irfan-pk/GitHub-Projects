Imports System.Data.SqlClient

Public Class HoldSale
    Dim FindID As String

    Private Sub frmHoldSale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then gblCP_ID = String.Empty : gblCP = String.Empty : Me.Close()
        If e.KeyCode = Keys.Enter Then
            gblCP_ID = (dgHoldInfo.Rows(dgHoldInfo.CurrentRow.Index).Cells(0).Value.ToString())
            gblCP = (dgHoldInfo.Rows(dgHoldInfo.CurrentRow.Index).Cells(1).Value.ToString())
            Connection.Close()
            HoldDataSet.Clear()
            RecordDataSet.Clear()
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub frmHoldSale_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        Call Popup_SaleData()
    End Sub

    Private Sub Popup_SaleData()
        HoldDataSet.Clear()
        ' Add data from the sale master table to the DataSet.
        Dim MasterDataAdapter As _
            New SqlDataAdapter("select * from SALE_MASTER_HOLD where saleid like '%" & gblInvPrefix & "%'", Connection)
        MasterDataAdapter.Fill(Me.HoldDataSet, "SALE_MASTER_HOLD")
        ' Bind the hold master data connector to the hold detail table.
        HoldBindingSource.DataSource = Me.HoldDataSet
        HoldBindingSource.DataMember = "SALE_MASTER_HOLD"
    End Sub
End Class