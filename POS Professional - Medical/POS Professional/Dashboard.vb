Imports System.Data.SqlClient

Public Class Dashboard

    Dim InvoiceAdapter As New SqlDataAdapter()
    Dim SummaryAdapter As New SqlDataAdapter()
    Dim CrSumryAdapter As New SqlDataAdapter()
    Dim PendingAdapter As New SqlDataAdapter()
    Dim SummaryDataset As New DataSet()
    Dim SortID As Integer
    Dim UpdateAccount, LastSaleID As String
    Public gblDiffDisc, gblDiffPayment, CurrentDiscount As Double

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Start()
        'DisplayDashboardData()
    End Sub

    Private Sub DisplayDashboardData()
        Me.DataSet1.Clear()
        Dim InvoiceQuery As String = "select * from sale_master where (status = 'BILLED' or status = 'PARTIAL' or status = 'CREDIT') order by saleid"
        ExecuteAdapterQuery(InvoiceAdapter, InvoiceQuery, Connection)
        InvoiceAdapter.Fill(Me.DataSet1, "sale_master")
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.DataMember = "sale_master"
        Me.dgvDashBoard.Refresh()

        'Summaries
        Dim SummaryQuery As String = "select sum(salepaid) as cash, sum(salediscount) as disc, sum(salerecovery) as recovery from sale_master where datecompleted = '" & Format(DateTime.Parse(Now.Date), "MM/dd/yyyy") & "' and (status = 'PAID' OR status = 'PARTIAL')"
        ExecuteDatasetQuery(SummaryAdapter, SummaryDataset, SummaryQuery, "sale_master", Connection)
        If SummaryDataset.Tables("sale_master").Rows.Count > 0 Then
            Dim SumReader As SqlDataReader = SummaryAdapter.SelectCommand.ExecuteReader
            While SumReader.Read
                If IsDBNull(SumReader.Item("cash")) = False Then Me.lblTotalPrice.Text = Decimal.Parse(SumReader.Item("cash")).ToString("c")
                If IsDBNull(SumReader.Item("disc")) = False Then Me.lblTotalDisc.Text = Decimal.Parse(SumReader.Item("disc")).ToString("c")
                If IsDBNull(SumReader.Item("recovery")) = False Then Me.lblRecovery.Text = Decimal.Parse(SumReader.Item("recovery")).ToString("c")
            End While
        End If
        SummaryDataset.Clear()
        Dim CreditQuery As String = "select sum(salecredit) as Total from sale_master where salecredit > 0"
        ExecuteDatasetQuery(CrSumryAdapter, SummaryDataset, CreditQuery, "sale_master", Connection)
        If SummaryDataset.Tables("sale_master").Rows.Count > 0 Then
            Dim CrReader As SqlDataReader = CrSumryAdapter.SelectCommand.ExecuteReader
            While CrReader.Read
                If IsDBNull(CrReader.Item("Total")) = False Then Me.lblTotalCredit.Text = Decimal.Parse(CrReader.Item("Total")).ToString("c")
            End While
            If CrReader Is Nothing Then CrReader.Close()
        End If
        'Pending cash
        SummaryDataset.Clear()
        Dim PendingQuery As String = "select sum(salepaid) as Total from sale_master where status = 'BILLED'"
        ExecuteDatasetQuery(PendingAdapter, SummaryDataset, PendingQuery, "sale_master", Connection)
        If SummaryDataset.Tables("sale_master").Rows.Count > 0 Then
            Dim PendingReader As SqlDataReader = PendingAdapter.SelectCommand.ExecuteReader
            While PendingReader.Read
                If IsDBNull(PendingReader.Item("Total")) = False Then Me.lblPendingCash.Text = Decimal.Parse(PendingReader.Item("Total")).ToString("c")
            End While
            If PendingReader Is Nothing Then PendingReader.Close()
        End If
    End Sub

    Private Sub Dashboard_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then Me.Close()
        If e.KeyCode = Keys.F2 Then PaidCashInvoice() : DisplayDashboardData()
        If e.KeyCode = Keys.F3 Then PaidCreditInvoice() : DisplayDashboardData()
        If e.KeyCode = Keys.F4 Then DisplayDashboardData()
    End Sub

    Private Sub PaidCashInvoice()
        gblDiffDisc = 0
        gblDiffPayment = 0
        Dim InvoiceNo As String = dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(1).Value.ToString
        Dim AccID As Integer = Convert.ToInt32(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(3).Value.ToString)
        gblGross = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(5).Value.ToString)
        gblDiscount = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(6).Value.ToString)
        gblNet = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(7).Value.ToString)
        gblInvoiceStatus = dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(10).Value.ToString.ToUpper
        CurrentDiscount = gblDiscount
        If gblInvoiceStatus.ToUpper = "BILLED" Then
            PaymentBox.ShowDialog()
            If gblPayment > 0 Then
                If gblDiscount <> CurrentDiscount Then
                    Dim UpdtInvoiceData As String = "update sale_master set saletotal = " & gblNet & "," & _
                                                    "salediscount = " & gblDiscount & "," & _
                                                    "salepaid = " & gblPayment & " where saleid = '" & InvoiceNo & "'"
                    ProcessTransaction(UpdtInvoiceData)
                End If
                LedgerDrTransaction(1, "SI-" & InvoiceNo, "CASH SALE", "DR", Val(gblPayment))
                If Val(gblDiscount) > 0 Then LedgerDrTransaction(3, "SI-" & InvoiceNo, "SALE DISCOUNT", "DR", Val(gblDiscount))
                LedgerCrTransaction(2, "SI-" & InvoiceNo, "CASH SALE", "CR", gblGross)
                Dim Updt_Status As String = "update sale_master set status = 'PAID', ledgerpost = 1 where saleid = '" & InvoiceNo & "'"
                ProcessTransaction(Updt_Status)
                LastSaleID = InvoiceNo
                UpdateStockQuantity()
            End If
        Else
            MessageBox.Show("Credit Invoice cannot be paid against cash invoice", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PaidCreditInvoice()
        gblDiffDisc = 0
        gblDiffPayment = 0
        Dim InvoiceNo As String = dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(1).Value.ToString
        Dim AccID As Integer = Convert.ToInt32(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(3).Value.ToString)
        gblGross = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(5).Value.ToString)
        gblDiscount = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(6).Value.ToString)
        gblNet = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(7).Value.ToString)
        gblInvoiceStatus = dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(10).Value.ToString.ToUpper
        CurrentDiscount = gblDiscount
        If gblInvoiceStatus.ToUpper = "BILLED" Then MessageBox.Show("Cash Invoice cannot be paid to against credit invoice.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        PaymentBox.ShowDialog()
        If gblPayment > 0 Then
            If gblDiscount <> CurrentDiscount Then
                Dim UpdtInvoiceData As String = "update sale_master set saletotal = " & gblNet & "," & _
                                                "salediscount = " & gblDiscount & " " & _
                                                "where saleid '= " & InvoiceNo & "'"
                ProcessTransaction(UpdtInvoiceData)
            End If
            Dim CashRecovery As String = "update sale_master set salepaid = salepaid + " & gblPayment & ", salerecovery = " & gblPayment & ", daterecovery = '" & Format(DateTime.Parse(Now.Date), "MM/dd/yyyy") & "' where saleid = '" & InvoiceNo & "'"
            ProcessTransaction(CashRecovery)
            'if give more discount at the time of payment
            If gblDiscount > CurrentDiscount Then
                LedgerDrTransaction(3, "SI-" & InvoiceNo, "MORE DISCOUNT ON INVOICE # " & InvoiceNo, "DR", Val(gblDiff))
                LedgerCrTransaction(AccID, "SI-" & InvoiceNo, "MORE DISCOUNT ON INVOICE # " & InvoiceNo, "CR", Val(gblDiff))
            End If
            'if less the discount at the time of payment
            If gblDiscount < CurrentDiscount Then
                LedgerDrTransaction(AccID, "SI-" & InvoiceNo, "LESS DISCOUNT ON INVOICE # " & InvoiceNo, "DR", Val(gblDiff))
                LedgerCrTransaction(3, "SI-" & InvoiceNo, "LESS DISCOUNT ON INVOICE # " & InvoiceNo, "CR", Val(gblDiff))
            End If
            LedgerDrTransaction(1, "SI-" & InvoiceNo, "CASH RECEIVED FROM CREDIT INVOICE # " & InvoiceNo, "DR", Val(gblPayment))
            LedgerCrTransaction(AccID, "SI-" & InvoiceNo, "CASH RECEIVED FROM CREDIT INVOICE # " & InvoiceNo, "CR", Val(gblPayment))
            Dim Updt_Status As String = "update sale_master set status = 'PAID', ledgerpost = 1 where saleid = '" & InvoiceNo & "'"
            ProcessTransaction(Updt_Status)
        End If
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim newCulture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CurrentUICulture.Clone()
        newCulture.NumberFormat.CurrencySymbol = "Rs. "
        newCulture.NumberFormat.CurrencyDecimalDigits = 2
        newCulture.NumberFormat.CurrencyGroupSeparator = String.Empty
        newCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = newCulture
        System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture
        Call GetConnectionString()
        Timer1.Interval = 9000
        Timer1.Start()
        DisplayDashboardData()
    End Sub

    Private Sub dgvDashBoard_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDashBoard.CellDoubleClick
        'gblNet = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(6).Value.ToString)
        'gblDiscount = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(5).Value.ToString)
        'Dim InvoiceNo As String = dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(1).Value.ToString
        'Dim GrossVal As Double = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(4).Value.ToString)
        'PaymentBox.ShowDialog()
        'If gblPayment > 0 Then
        '    Call LedgerDrTransaction(1, "SI-" & InvoiceNo, "CASH SALE", "DR", Val(gblPayment))
        '    If Val(gblDiscount) > 0 Then Call LedgerDrTransaction(3, "SI-" & InvoiceNo, "SALE DISCOUNT", "DR", Val(gblDiscount))
        '    Call LedgerCrTransaction(2, "SI-" & InvoiceNo, "CASH SALE", "CR", GrossVal)
        '    Dim Updt_Status As String = "update sale_master set status = 'PAID' where saleid = '" & InvoiceNo & "'"
        '    ProcessTransaction(Updt_Status)
        'End If
    End Sub

    Private Sub LedgerDrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)

        SortID += 1
        Dim ClosBalance As Double = 0
        Call Get_Account_Parameters(AccID)
        If gblAccType = "DR" Then ClosBalance = gblLedgBal + Amount
        If gblAccType = "CR" Then ClosBalance = gblLedgBal - Amount
        Dim strDate As DateTime = DateTime.Now
        'strDate = lblDate.Text.ToString
        Dim TranID As Decimal = GenerateMax_ID("LEDGERS", "LEDG_TRAN_ID")
        ''// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String = String.Empty
        NewTransaction = "INSERT INTO LEDGERS VALUES ('" & _
                         Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                         TranID & "," & _
                         AccID & ",'" & _
                         DocNo.Trim & "','" & _
                         StrConv(gblAccHead.Trim, VbStrConv.Uppercase) & "','" & _
                         StrConv(gblAccName.Trim, VbStrConv.Uppercase) & "','" & _
                         LedgDesc.Trim.ToString & "','" & _
                         TransType & "'," & _
                         Amount & ",0.00," & _
                         ClosBalance & "," & _
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        If gblAccType = "DR" Then _
            UpdateAccount = "update accounts set acc_debit = acc_debit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID

        If gblAccType = "CR" Then _
            UpdateAccount = "update accounts set acc_debit = acc_debit + " & Amount & ", acc_balance = acc_balance - " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub

    Private Sub LedgerCrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)

        SortID += 1
        Dim ClosBalance As Double = 0
        Call Get_Account_Parameters(AccID)
        If gblAccType = "CR" Then ClosBalance = gblLedgBal + Amount
        If gblAccType = "DR" Then ClosBalance = gblLedgBal - Amount
        Dim strDate As DateTime = DateTime.Now
        'strDate = lblDate.Text.ToString
        Dim TranID As Decimal = GenerateMax_ID("LEDGERS", "LEDG_TRAN_ID")
        ''// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String = String.Empty
        NewTransaction = "INSERT INTO LEDGERS VALUES ('" & _
                         Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                         TranID & "," & _
                         AccID & ",'" & _
                         DocNo.Trim & "','" & _
                         StrConv(gblAccHead.Trim, VbStrConv.Uppercase) & "','" & _
                         StrConv(gblAccName.Trim, VbStrConv.Uppercase) & "','" & _
                         LedgDesc.Trim.ToString & "','" & _
                         TransType & "'," & _
                         "0.00," & Amount & "," & _
                         ClosBalance & "," & _
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        If gblAccType = "CR" Then _
                UpdateAccount = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID
        If gblAccType = "DR" Then _
                UpdateAccount = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance - " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)
    End Sub

    Private Sub UpdateStockQuantity()
        Dim SelectQty As String = "SELECT * FROM SALE_DETAIL WHERE SaleID = '" & LastSaleID & "'"
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                ProcessTransaction("update products set prod_stock = prod_stock - " & Val(Updater.Item("qty")) & " where prod_code = N'" & Updater.Item("StockID").ToString & "'")
            End While
            If Updater Is Nothing Then Updater.Close()
        End If
    End Sub
End Class