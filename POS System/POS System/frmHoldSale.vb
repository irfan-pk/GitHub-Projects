Imports System.Data.SqlClient

Public Class frmHoldSale
    Dim FindID As String

    Private Sub frmHoldSale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.Enter Then
            gblCP_ID = (dgHoldInfo.Rows(dgHoldInfo.CurrentRow.Index).Cells(0).Value.ToString())
            gblCP = (dgHoldInfo.Rows(dgHoldInfo.CurrentRow.Index).Cells(1).Value.ToString())
            Connection.Close()
            'MsgBox(gblCP_ID & " " & gblCP)
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
        If gblRelation = True Then HoldDataSet.Relations.Remove("HoldMasterDetail")
        ' Add data from the sale master table to the DataSet.
        Dim MasterDataAdapter As _
            New SqlDataAdapter("select * from SALE_MASTER_HOLD", Connection)
        MasterDataAdapter.Fill(Me.HoldDataSet, "SALE_MASTER_HOLD")

        ' Add data from the sale detail table to the DataSet.
        Dim DetailsDataAdapter As _
            New SqlDataAdapter("select * from SALE_DETAIL_HOLD", Connection)
        DetailsDataAdapter.Fill(Me.HoldDataSet, "SALE_DETAIL_HOLD")

        ' Establish a relationship between the master and detail tables.
        Dim Relation As New DataRelation("HoldMasterDetail", _
            HoldDataSet.Tables("SALE_MASTER_HOLD").Columns("SaleID"), _
            HoldDataSet.Tables("SALE_DETAIL_HOLD").Columns("SaleID"))
        HoldDataSet.Relations.Add(Relation)
        gblRelation = True
        ' Bind the hold master data connector to the hold detail table.
        HoldBindingSource.DataSource = Me.HoldDataSet
        HoldBindingSource.DataMember = "SALE_MASTER_HOLD"

        ' Bind the details data connector to the master data connector,
        ' using the DataRelation name to filter the information in the 
        ' details table based on the current row in the master table. 
        SaleBindingSource.DataSource = HoldBindingSource
        SaleBindingSource.DataMember = "HoldMasterDetail"
    End Sub
End Class