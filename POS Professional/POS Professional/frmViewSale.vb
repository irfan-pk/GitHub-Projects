Imports System.Data.SqlClient

Public Class frmViewSale
    Dim MasterQuery, ChildQuery As String
    Dim DetailsDataAdapter As SqlDataAdapter
    Dim MasterDataAdapter As SqlDataAdapter
    Dim Choice As String

    Private Sub frmViewSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Call GetConnectionString()
        Call Popup_SaleData("CashSale")
        dgMasterInfo.Focus()
    End Sub

    Private Sub Popup_SaleData(ByVal TabChoice As String)

        If TabChoice = "CashSale" Then
            MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit = 0 AND SaleReturn = 0 AND SaleRecovery = 0 AND DateCompleted >= N'" & Format(Date.Parse(dtDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY SaleID"
            ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit = 0 And SaleReturn = 0 And SaleRecovery = 0 And DateCompleted >= N'" & Format(Date.Parse(dtDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY sale_master.SaleID"
        End If

        'If TabChoice = "TabCreditSale" Then SelectionQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit > 0 AND SaleReturn = 0 AND SaleRecovery = 0 AND DateCompleted >= N'" & Format(Date.Parse(dtDate.Value.ToString), "MM/dd/yyyy") & "'"
        Me.RecordDataSet.Clear()
        If gblRelation = True Then RecordDataSet.Relations.Remove("MasterDetail")
        ' Add data from the sale master table to the DataSet.
        MasterDataAdapter = _
            New SqlDataAdapter(MasterQuery, Connection)
        MasterDataAdapter.Fill(Me.RecordDataSet, "SALE_MASTER")

        ' Add data from the sale detail table to the DataSet.
        DetailsDataAdapter = _
            New SqlDataAdapter(ChildQuery, Connection)
        DetailsDataAdapter.Fill(Me.RecordDataSet, "SALE_DETAIL")

        ' Establish a relationship between the master and detail tables.
        Dim Relation As New DataRelation("MasterDetail", _
            Me.RecordDataSet.Tables("SALE_MASTER").Columns("SaleID"), _
            Me.RecordDataSet.Tables("SALE_DETAIL").Columns("SaleID"))
        Me.RecordDataSet.Relations.Add(Relation)
        gblRelation = True

        ' Bind the hold master data connector to the hold detail table.
        Me.MasterBindingSource.DataSource = Me.RecordDataSet
        Me.MasterBindingSource.DataMember = "SALE_MASTER"

        ' Bind the details data connector to the master data connector,
        ' using the DataRelation name to filter the information in the 
        ' details table based on the current row in the master table. 
        Me.DetailBindingSource.DataSource = MasterBindingSource
        Me.DetailBindingSource.DataMember = "MasterDetail"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub dtDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtDate.ValueChanged
        Call Popup_SaleData("CashSale")
    End Sub

End Class