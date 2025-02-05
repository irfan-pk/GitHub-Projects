Imports System.Data.SqlClient

Public Class Dashboard

    Dim InvoiceAdapter As New SqlDataAdapter()
    Dim SummaryAdapter As New SqlDataAdapter()
    Dim CrSumryAdapter As New SqlDataAdapter()
    Dim SummaryDataset As New DataSet()
    Dim SortID As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Start()
        Me.DataSet1.Clear()
        Dim InvoiceQuery As String = "select * from sale_master where status = 'BILLED' and datecompleted = '" & Format(DateTime.Parse(Now.Date), "MM/dd/yyyy") & "' order by saleid"
        ExecuteAdapterQuery(InvoiceAdapter, InvoiceQuery, Connection)
        InvoiceAdapter.Fill(Me.DataSet1, "sale_master")
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.DataMember = "sale_master"
        Me.dgvDashBoard.Refresh()

        'Summaries
        Dim SummaryQuery As String = "select sum(salepaid) as cash, sum(salediscount) as disc, sum(salerecovery) as recovery from sale_master where datecompleted = '" & Format(DateTime.Parse(Now.Date), "MM/dd/yyyy") & "' and status = 'PAID'"
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
        Dim CreditQuery As String = "select sum(salecredit) as Total from sale_master where datecompleted = '" & Format(DateTime.Parse(Now.Date), "MM/dd/yyyy") & "' and salecredit > 0"
        ExecuteDatasetQuery(CrSumryAdapter, SummaryDataset, CreditQuery, "sale_master", Connection)
        If SummaryDataset.Tables("sale_master").Rows.Count > 0 Then
            Dim CrReader As SqlDataReader = CrSumryAdapter.SelectCommand.ExecuteReader
            While CrReader.Read
                If IsDBNull(CrReader.Item("Total")) = False Then Me.lblTotalCredit.Text = Decimal.Parse(CrReader.Item("Total")).ToString("c")
            End While
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
        Timer1.Interval = 5200
        Timer1.Start()
    End Sub

    Private Sub dgvDashBoard_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDashBoard.CellDoubleClick
        gblNet = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(5).Value.ToString)
        gblDiscount = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(4).Value.ToString)
        Dim InvoiceNo As String = dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(0).Value.ToString
        Dim GrossVal As Double = Val(dgvDashBoard.Rows(dgvDashBoard.CurrentRow.Index).Cells(3).Value.ToString)
        PaymentBox.ShowDialog()
        If gblPayment > 0 Then
            Call LedgerDrTransaction(1, "SI-" & InvoiceNo, "CASH SALE", "DR", Val(gblPayment))
            If Val(gblDiscount) > 0 Then Call LedgerDrTransaction(3, "SI-" & InvoiceNo, "SALE DISCOUNT", "DR", Val(gblDiscount))
            Call LedgerCrTransaction(2, "SI-" & InvoiceNo, "CASH SALE", "CR", GrossVal)
            Dim Updt_Status As String = "update sale_master set status = 'PAID' where saleid = '" & InvoiceNo & "'"
            ProcessTransaction(Updt_Status)
        End If
    End Sub

    Private Sub LedgerDrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)

        SortID += 1
        Call Get_Account_Parameters(AccID)
        'Call Get_Ledger_Parameters(AccID)
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
                         "0.00" & "," & _
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        Dim UpdateAccount As String = "update accounts set acc_debit = acc_debit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub

    Private Sub LedgerCrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)

        SortID += 1
        Call Get_Account_Parameters(AccID)
        'Call Get_Ledger_Parameters(AccID)
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
                         "0.00" & "," & _
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        Dim UpdateAccount As String = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub

End Class