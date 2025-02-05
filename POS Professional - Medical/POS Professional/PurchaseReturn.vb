Imports System.Data.SqlClient

Public Class PurchaseReturn
    Dim ReturnPurchase As Boolean
    Dim SortID, ReturnInvoiceNo, AccID As Integer
    Dim PrchType, UpdateAccount As String
    Dim PrchGross, PrchDiscount, PrchNet, PrchPaid, PrchReturn, PrchCredit, ClosBalance As Double

    Private Sub PurchaseReturn_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtInvoiceNo.Focus()
    End Sub

    Private Sub PurchaseReturn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then Me.Close()
        If e.KeyCode = Keys.F2 Then SaleInvoiceReturn()
    End Sub

    Private Sub PurchaseReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetConnectionString()
    End Sub

    Private Sub SaleInvoiceReturn()
        Dim dr As DialogResult = MessageBox.Show("Are you sure to return invoice. (Yes/No)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ReturnInvoiceNo = Val(txtInvoiceNo.Text)
            ExecuteAdapterQuery(SqlDataAdapter, "select * from purchase_master where prchid = " & ReturnInvoiceNo, Connection)
            Dim Finder As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Finder.HasRows Then
                While Finder.Read
                    PrchGross = Val(Finder.Item("prchgross").ToString())
                    PrchDiscount = Val(Finder.Item("prchdiscount").ToString()) * PrchGross / 100
                    PrchNet = Val(Finder.Item("prchtotal").ToString())
                    PrchPaid = Val(Finder.Item("prchpaid").ToString())
                    PrchCredit = Val(Finder.Item("prchcredit").ToString())
                    PrchType = Finder.Item("status").ToString()
                    AccID = Finder.Item("supplrid").ToString()
                End While
                ReturnPurchase = True
            Else
                MsgBox("Invalid invoice selection.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                txtInvoiceNo.Focus()
                txtInvoiceNo.SelectAll()
            End If

            If ReturnPurchase = True Then
                UpdateStockQuantity(ReturnInvoiceNo)
                If PrchType = "CASH" Then
                    'Ledger Transactions for cash invoice
                    If PrchGross > 0 Then LedgerCrTransaction(4, "SR-" & ReturnInvoiceNo, "RETURN PURCHASE", "CR", PrchGross)
                    If PrchNet > 0 Then LedgerDrTransaction(1, "SR-" & ReturnInvoiceNo, "RETURN PURCHASE", "DR", PrchNet)
                    If PrchDiscount > 0 Then LedgerDrTransaction(5, "SR-" & ReturnInvoiceNo, "RETURN PURCHASE", "DR", PrchDiscount)
                    ProcessTransaction("update purchase_master prchreturn = " & PrchNet & ", prchreturndate = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "' where prchid = '" & ReturnInvoiceNo & "'")
                End If

                If PrchType = "CREDIT" Then
                    'Ledger Transactions for credit invoice
                    If PrchGross > 0 Then LedgerCrTransaction(4, "SR-" & ReturnInvoiceNo, "RETURN PURCHASE", "CR", PrchGross)
                    If PrchCredit > 0 Then LedgerDrTransaction(AccID, "SR-" & ReturnInvoiceNo, "RETURN PURCHASE", "DR", PrchCredit)
                    If PrchDiscount > 0 Then LedgerDrTransaction(5, "SR-" & ReturnInvoiceNo, "RETURN PURCHASE", "DR", PrchDiscount)
                    ProcessTransaction("update purchase_master set prchcredit = 0, prchreturndate = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "' where prchid = '" & ReturnInvoiceNo & "'")
                End If
                ProcessTransaction("update purchase_master set status = 'RETURN' where prchid = " & ReturnInvoiceNo)
                ProcessTransaction("update purchase_detail set prchtype = 'RETURN' where prchid = " & ReturnInvoiceNo)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub UpdateStockQuantity(ByVal InvoiceNo As String)
        Dim SelectQty As String = "SELECT * FROM PURCHASE_DETAIL WHERE PrchID = " & InvoiceNo
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                ProcessTransaction("update products set prod_stock = prod_stock + (" & Val(Updater.Item("qty")) & " * prod_pack_conversion) where prod_code = N'" & Updater.Item("StockID").ToString & "'")
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

    Private Sub txtInvoiceNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvoiceNo.KeyPress
        ValidateNumbersOnly(sender, e, txtInvoiceNo)
    End Sub
End Class