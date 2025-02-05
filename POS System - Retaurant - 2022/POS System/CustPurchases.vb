Imports System.Data.SqlClient

Public Class CustPurchases

    Private Sub BindingNavigatorClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorClose.Click
        Me.Close()
        CustomerMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BindingNavigatorFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFind.Click
        If BindingNavigatorTextBox.Text = String.Empty Or Val(BindingNavigatorTextBox.Text.Trim) = 0 Then gblMessage = "Please valid customer ID to Search ?" : MsgStatus.ShowDialog(Me) : Exit Sub
        Popup_SaleData()
    End Sub

    Private Sub Popup_SaleData()
        Me.CustomerDataSet.Clear()
        Dim SaleDetail As String = "SELECT SaleID,CustomerID,CustomerName,StockDesc,SalePack,UnitCost,Qty,Price,(convert(varchar(8),detaildate,112))+RIGHT('0000'+convert(varchar(4),detailID),4) as SequenceID FROM SALE_DETAIL " & _
                                   "WHERE CustomerID = N'" & Val(BindingNavigatorTextBox.Text.Trim) & "' AND (DetailDate >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                   "DetailDate <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)) ORDER BY SALEID"
        ExecuteAdapterQuery(SqlDataAdapter, SaleDetail, Connection)
        SqlDataAdapter.Fill(Me.CustomerDataSet, "SALE_DETAIL")
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet
        Me.CustomerBindingSource.DataMember = "SALE_DETAIL"
    End Sub

    Private Sub BindingNavigatorTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyUp
        If e.KeyCode = Keys.F2 Then
            WaiterCode.ShowDialog(Me)
            If Len(gblCP_ID) > 0 Then BindingNavigatorTextBox.Text = gblCP_ID.ToString.ToUpper Else Exit Sub
            'Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub

    Private Sub frmCustPurchases_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'If e.KeyCode = Keys.F2 Then
        '    frmCustCode.ShowDialog(Me)
        '    If Len(gblCP_ID) > 0 Then BindingNavigatorTextBox.Text = gblCP_ID.ToString.ToUpper Else Exit Sub
        '    'Call BindingNavigatorFind_Click(sender, e)
        'End If
    End Sub

    Private Sub frmCustPurchases_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gblCP_ID = String.Empty
        Call GetConnectionString()
        'Call Popup_SaleData()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub BindingNavigatorTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        Popup_SaleData()
    End Sub
End Class