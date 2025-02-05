Imports System.Data.SqlClient

Public Class SalesReturn
    Dim ReturnSale As Boolean
    Dim SortID, AccID As Integer
    Dim SaleType, ReturnInvoiceNo, UpdateAccount As String
    Dim SaleGross, SaleDiscount, SaleNet, SalePaid, SaleReturn, SaleCredit, ClosBalance As Double

    Private Sub SalesReturn_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtInvoiceNo.Focus()
    End Sub

    Private Sub SalesReturn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then Me.Close()
        If e.KeyCode = Keys.F2 Then SaleInvoiceReturn()
    End Sub

    Private Sub SaleInvoiceReturn()
        Dim dr As DialogResult = MessageBox.Show("Are you sure to return invoice. (Yes/No)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ReturnInvoiceNo = txtInvoiceNo.Text
            ExecuteAdapterQuery(SqlDataAdapter, "select * from sale_master where saleid = '" & ReturnInvoiceNo & "'", Connection)
            Dim Finder As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Finder.HasRows Then
                While Finder.Read
                    SaleGross = Val(Finder.Item("salegross").ToString())
                    SaleDiscount = Val(Finder.Item("salediscount").ToString())
                    SaleNet = Val(Finder.Item("saletotal").ToString())
                    SalePaid = Val(Finder.Item("salepaid").ToString())
                    SaleCredit = Val(Finder.Item("salecredit").ToString())
                    SaleReturn = Val(Finder.Item("salereturn").ToString())
                    SaleType = Finder.Item("status").ToString()
                    AccID = Finder.Item("customerid").ToString()
                End While
                ReturnSale = True
            Else
                MsgBox("Invalid Invoice No. Please use valid invoice ID.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                txtInvoiceNo.Clear()
                txtInvoiceNo.Focus()
            End If

            If ReturnSale = True Then
                UpdateStockQuantity(ReturnInvoiceNo)
                If SaleType = "PAID" Then
                    'Ledger Transactions for cash invoice
                    If SaleGross > 0 Then LedgerDrTransaction(2, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "DR", SaleGross)
                    If SaleNet > 0 Then LedgerCrTransaction(AccID, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "CR", SalePaid)
                    If SaleDiscount > 0 Then LedgerCrTransaction(3, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "CR", SaleDiscount)
                    ProcessTransaction("update sale_master set status = 'RETURN', salereturn = " & SaleNet & ", salerecovery = 0, salechange = 0, daterecovery = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "' where saleid = '" & ReturnInvoiceNo & "'")
                End If

                If SaleType = "CREDIT" Then
                    'Ledger Transactions for credit invoice
                    If SaleGross > 0 Then LedgerDrTransaction(2, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "DR", SaleGross)
                    If SaleCredit > 0 Then LedgerCrTransaction(AccID, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "CR", SaleCredit)
                    If SaleDiscount > 0 Then LedgerCrTransaction(3, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "CR", SaleDiscount)
                    ProcessTransaction("update sale_master set status = 'RETURN', salegross = 0, salediscount = 0, saletotal = 0, salepaid = 0, salecredit = 0, salereturn = 0, salerecovery = 0, salechange = 0, daterecovery = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "' where saleid = '" & ReturnInvoiceNo & "'")
                End If

                If SaleType = "PARTIAL" Then
                    'Ledger Transactions for credit invoice with partial payment
                    If SaleGross > 0 Then LedgerDrTransaction(2, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "DR", SaleGross)
                    If SalePaid > 0 Then LedgerCrTransaction(1, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "CR", SalePaid)
                    If SaleDiscount > 0 Then LedgerCrTransaction(3, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "CR", SaleDiscount)
                    If SaleCredit > 0 Then LedgerCrTransaction(AccID, "SR-" & ReturnInvoiceNo.ToUpper, "RETURN SALE", "CR", SaleCredit)
                    ProcessTransaction("update sale_master set status = 'RETURN', salereturn = " & SaleNet & ", salepaid = 0, salecredit = 0, salerecovery = 0, salechange = 0, daterecovery = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "' where saleid = '" & ReturnInvoiceNo & "'")
                End If

                If SaleType = "BILLED" Then
                    'Ledger Transactions for pending invoice
                    Dim query As String = "update sale_master set status = 'RETURN', salegross = 0, salediscount = 0, saletotal = 0, salepaid = 0, salecredit = 0, salereturn = 0, salerecovery = 0, salechange = 0, daterecovery = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "' where saleid = '" & ReturnInvoiceNo & "'"
                    ProcessTransaction(query)
                End If
                ProcessTransaction("update sale_detail set saletype = 'RETURN' where saleid = '" & ReturnInvoiceNo & "'")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub SalesReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetConnectionString()
    End Sub

    Private Sub UpdateStockQuantity(ByVal InvoiceNo As String)
        Dim SelectQty As String = "SELECT * FROM SALE_DETAIL WHERE SaleID = '" & InvoiceNo & "'"
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                ProcessTransaction("update products set prod_stock = prod_stock + " & Val(Updater.Item("qty")) & " where prod_code = N'" & Updater.Item("StockID").ToString & "'")
            End While
            If Updater Is Nothing Then Updater.Close()
        End If
    End Sub

    Private Sub LedgerDrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)
        SortID += 1
        ClosBalance = 0
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
        ClosBalance = 0
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
End Class