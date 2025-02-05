Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient

Public Class SaleEntry
    Dim ProductID As String = ""
    Dim ProductQty, FinalQty As Integer
    Dim drag, FoundItem As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim Items, Clos_Balance As String
    Dim Payment, FinalPayment, TotalQty, Dues As Double
    Dim SaleMode, ReturnMode, DiscountAllow, SaleReturn, SaleCredit As Boolean
    Dim SortID, NewQty, LastSaleID, Max_ID, Q1, Q2, Q3, Q4 As Integer

    Private Sub SaleEntry_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCode.Focus()
    End Sub

    Private Sub SaleEntry_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.ControlKey + Keys.F12 Then
            txtCustomerName.Visible = True
            txtCustomerName.Clear()
            txtCustomerName.Focus()
        End If
        If e.KeyCode = Keys.F3 Then cmdCustomer_Click(sender, e)
        If e.KeyCode = Keys.F4 Then cmdDiscount_Click(sender, e)
        If e.KeyCode = Keys.F5 Then cmdSuspend_Click(sender, e)
        If e.KeyCode = Keys.F6 Then cmdCreditSale_Click(sender, e)
        If e.KeyCode = Keys.F7 Then cmdSaleReturn_Click(sender, e)
        If e.KeyCode = Keys.F8 Then cmdSave_Click(sender, e)
        If e.KeyCode = Keys.F9 Then cmdPrint_Click(sender, e)
        If e.KeyCode = Keys.F10 Then lblHold_DoubleClick(sender, e)
        If e.KeyCode = Keys.F11 Then cmdNew_Click(sender, e)
        If e.KeyCode = Keys.F12 Then txtPaid.Focus()
    End Sub

    Private Sub SaleEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'To Clone Currency Format
        Dim newCulture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CurrentUICulture.Clone()
        newCulture.NumberFormat.CurrencySymbol = "Rs. "
        newCulture.NumberFormat.CurrencyDecimalDigits = 2
        newCulture.NumberFormat.CurrencyGroupSeparator = String.Empty
        newCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = newCulture
        System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture
        lblUserID.Text = UserID
        lblUserName.Text = SysOperator
        ProcessTransaction("delete from sale_master_hold")
        ProcessTransaction("delete from sale_detail_hold")
        ProcessTransaction("delete from sale_master_temp")
        ProcessTransaction("delete from sale_detail_temp")
        Call GetConnectionString()
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Call cmdNew_Click(sender, e)
        gblRelation = False
        txtCode.Focus()
        txtCode.Focus()

    End Sub

    Private Sub cmdViewSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewSale.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to print", "Print Sale Invoice", "only digit")
        If SaleInvoice.Trim = "" Then Exit Sub
        If IsNumeric(SaleInvoice.Trim) And Val(SaleInvoice.Trim) > 0 Then
            gblFind = SaleInvoice.Trim
            gblReportOption = "RECEIPT"
            gblReportName = Application.StartupPath & "\Reports\CashReceipt.rpt"
            Call Print_Slips_Manually()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'Write Here to delete all holded entries when quit
        Me.Close()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        ValidateAlphaNumOnly(sender, e)
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            ProductCode.ShowDialog(Me)
            If Len(gblItemCode) > 0 Then txtCode.Text = gblItemCode.ToUpper
            txtCode.Focus()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        ProductCode.ShowDialog(Me)
        If Len(gblItemCode) > 0 Then txtCode.Text = gblItemCode.ToUpper
        txtCode.Focus()
    End Sub

    Private Sub GroupBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseDoubleClick
        Call lblHold_DoubleClick(sender, e)
    End Sub

    Private Sub lblHold_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHold.MouseDoubleClick
        Call lblHold_DoubleClick(sender, e)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If Me.SaleDataGrid.Rows.Count > -1 Then
            For i As Integer = Me.SaleDataGrid.Rows.Count - 1 To 0 Step -1
                Me.SaleDataGrid.Rows.RemoveAt(i)
            Next
        End If
        Dim RefreshData As String = "Delete from sale_detail_temp where SaleStatus != N'HOLD'"
        ExecuteAdapterQuery(SqlDataAdapter, RefreshData, Connection)
        Dim RefreshSaleData As String = "Delete from sale_master_temp"
        ExecuteAdapterQuery(SqlDataAdapter, RefreshSaleData, Connection)
        lblDate.Text = Format(Now.Date, "MMMM, dd - yyyy")
        txtCode.Clear()
        SortID = 1
        gblDiscount = 0
        LastSaleID = 0
        gblDiscount = 0
        txtCustomerName.Clear()
        lblDiscount.Text = 0
        lblDiscount.Visible = False
        lblDiscHdr.Visible = False
        lblShowDiscount.Text = 0
        lblQty.Text = "1"
        lblMode.Text = "Sale"
        lblCustID.Text = "00"
        lblCustName.Text = ""
        txtPaid.Text = "00"
        lblRefund.Text = "00"
        lblSaleType.Text = "Cash Sale"
        lblCustomer.Text = "No Customer Selected"
        txtCustomerName.Visible = False
        lblInvoice.Text = GetMax_ID(lblInvoice.Text)
        lblSequence.Text = Format(Now.Date, "MMddyyyy") & Val(lblInvoice.Text.Trim)
        Call Get_Total()
        SaleMode = False
        SaleReturn = True
        DiscountAllow = False
        cmdSaleReturn.Enabled = True
        Call CountHoldSale()
        txtCode.Focus()
        txtCode.Focus()
    End Sub

    Private Sub cmdCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomer.Click
        CustomerCodes.ShowDialog(Me)
        If Len(gblCP_ID) > 0 Then
            lblCustomer.Text = gblCP
            lblSaleType.Text = "Account Sale"
            lblCustID.Text = gblCP_ID
            lblCustName.Text = gblCP
        End If
        txtCode.Focus()
    End Sub

    Private Sub txtCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomerName.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
            If Len(txtCustomerName.Text.Trim) > 0 Then lblSaleType.Text = "Customer Sale" Else lblSaleType.Text = "Cash Sale"
            lblCustName.Text = StrConv(txtCustomerName.Text.Trim, VbStrConv.ProperCase) : txtCustomerName.Visible = False : txtCode.Focus()
        End If
    End Sub

    Private Sub txtCustomerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerName.KeyPress
        Call ValidateAlphaKeyPress(sender, e, txtCustomerName)
    End Sub

    Private Sub txtCustomerName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.LostFocus
        If Len(txtCustomerName.Text.Trim) > 0 Then lblSaleType.Text = "Customer Sale" Else lblSaleType.Text = "Cash Sale"
        lblCustName.Text = StrConv(txtCustomerName.Text.Trim, VbStrConv.ProperCase) : txtCustomerName.Visible = False : txtCode.Focus()
    End Sub

    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click
        If SaleMode = True Then
            gblDiscount = Microsoft.VisualBasic.InputBox("Please Enter Allowed Discount.", My.Application.Info.ProductName, "only digit")
            If gblDiscount.ToString = "" Then gblDiscount = 0 : Exit Sub
            If IsNumeric(gblDiscount) And Val(gblDiscount) > 0 Then
                DiscountAllow = True
                'lblDiscHdr.Visible = True
                'lblDiscount.Visible = True
                If Val(txtPaid.Text) > 0 Then txtPaid.Text = Val(lblOrgPrice.Text.Trim) - gblDiscount
                lblDiscount.Text = Format(gblDiscount, "0.00")
                lblShowDiscount.Text = gblDiscount
                Call ValidateDiscount(sender, e)
            End If
        Else
            gblMessage = "There is no item for discount."
            MsgStatus.ShowDialog(Me)
        End If
        txtCode.Focus()
    End Sub

    Private Sub lblQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblQty.Click
        If lblMode.Text <> "Delete" Then
            txtQty.Visible = True
            txtQty.Focus()
            txtQty.SelectAll()
        End If
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
            If txtQty.Text = "" Or Val(txtQty.Text.Trim) = 0 Then lblQty.Text = 1 Else lblQty.Text = txtQty.Text.Trim
            txtQty.Visible = False
            txtCode.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Call ValidateNumbersOnly(sender, e, txtQty)
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        If txtQty.Text = "" Or Val(txtQty.Text.Trim) = 0 Then lblQty.Text = 1 Else lblQty.Text = txtQty.Text.Trim
        txtQty.Visible = False
        txtCode.Focus()
    End Sub

    Private Sub lblSaleType_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblSaleType.MouseClick
        txtCustomerName.Visible = True
        txtCustomerName.Focus()
    End Sub

    Private Sub txtPaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaid.GotFocus
        Me.txtPaid.Text = Val(lblOrgPrice.Text.Trim) - gblDiscount
        Me.txtPaid.SelectAll()
    End Sub

    Private Sub lblTotalPrice_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.lblTotalPrice.Text, _
                                Globalization.NumberStyles.Currency, _
                                Nothing, _
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With Me.lblTotalPrice
                '.HideSelection = False
                '.SelectAll()

                MessageBox.Show("Please enter a valid currency amount.", _
                                "Invalid Value", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)

                '.HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub lblTotalPrice_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        'Display the value as local currency.
        Me.lblTotalPrice.Text = Decimal.Parse(Me.lblTotalPrice.Text).ToString("c")
    End Sub

    Private Sub ValidateDiscount(ByVal sender As Object, ByVal e As System.EventArgs)
        If DiscountAllow = True Then
            lblTotalPrice.Text = Val(lblOrgPrice.Text.Trim) - gblDiscount
            Call lblTotalPrice_Validated(sender, e)
            Call lblShowDiscount_Validated(sender, e)
        End If
    End Sub

    Private Sub txtPaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            Payment = Val(lblOrgPrice.Text.Trim) - gblDiscount
            lblRefund.Text = Val(txtPaid.Text.Trim) - Payment
            cmdSave.Focus()
        End If
    End Sub

    Private Sub txtPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaid.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtCode, txtCode)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gblFind = LastSaleID
        gblReportOption = "RECEIPT"
        gblReportName = Application.StartupPath & "\Reports\CashReceipt.rpt"
        Call Print_Slips_Manually()
        txtCode.Focus()
    End Sub

    Private Sub SaleEntry_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub SaleEntry_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub SaleEntry_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

#Region "Runtime Functons and Procedures for Sale Form" '/CLICK TO HIDE OR UNHIDE

    Private Sub cmdCreditSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreditSale.Click
        If CheckRecordExists(lblCustName.Text.Trim, "customers", "cust_name") = True Then
            If SaleMode = True Then
                If lblCustName.Text.Trim = "" Or Len(lblCustName.Text.Trim) = 0 Or Val(lblCustID.Text.Trim) = 0 Then
                    gblMessage = "Credit not allowed to cash customer."
                    MsgStatus.ShowDialog(Me)
                    Exit Sub
                End If
                Dim MasterQuery As String = ""
                'Update Master Table
                MasterQuery = "INSERT INTO SALE_MASTER VALUES (" & _
                            Val(lblInvoice.Text.Trim) & "," & _
                            Val(lblUserID.Text.Trim) & ",'" & _
                            lblUserName.Text.Trim & "','" & _
                            Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                            lblSaleType.Text.Trim & "','" & _
                            lblSequence.Text.Trim & "','" & _
                            Val(lblCustID.Text.Trim) & "','" & _
                            lblCustName.Text.Trim & "'," & _
                            Val(lblOrgPrice.Text) & "," & _
                            Val(txtPaid.Text.Trim) & "," & _
                            Val(lblDiscount.Text.Trim) & "," & _
                            "0" & "," & _
                            "1," & Val(lblOrgPrice.Text.Trim) - Val(txtPaid.Text.Trim) - gblDiscount & ",0,0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "')"
                ProcessTransaction(MasterQuery)

                'Update child table
                Dim HoldQuery As String = ""
                If SaleDataGrid.RowCount > -1 Then
                    ProcessTransaction("delete from sale_detail where detailid = " & Val(lblInvoice.Text.Trim))
                    SortID = 1
                    For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                        HoldQuery = "INSERT INTO SALE_DETAIL VALUES (" & _
                                                             Val(lblSequence.Text.Trim) & ",'" & _
                                                             Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                                             Val(lblInvoice.Text.Trim) & ",'" & _
                                                             lblSaleType.Text.Trim & "'," & _
                                                             Val(lblCustID.Text.Trim) & ",'" & _
                                                             lblCustName.Text.Trim & "','" & _
                                                             OutRow.Cells(0).Value.ToString & "','" & _
                                                             OutRow.Cells(1).Value.ToString & "','" & _
                                                             OutRow.Cells(2).Value.ToString & "'," & _
                                                             OutRow.Cells(3).Value.ToString & "," & Val(OutRow.Cells(4).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(5).Value.ToString) & ",'CREDIT','" & _
                                                             lblUserID.Text.Trim & "',0,0,'" & OutRow.Cells(7).Value.ToString & "','" & OutRow.Cells(8).Value.ToString & "',0,'x'," & SortID & ")"
                        ProcessTransaction(HoldQuery)
                        SortID += 1
                    Next OutRow
                End If
                LastSaleID = Val(lblInvoice.Text.Trim)
                Call UpdateStockQuantity()
                ' To update journal transactions if credit customer info given
                If Val(lblCustID.Text.Trim) > 0 Then
                    Call Updt_General_Journal(Val(lblOrgPrice.Text) - Val(txtPaid.Text.Trim) - gblDiscount, TotalQty, Val(lblCustID.Text.Trim), lblDate.Text, Items.Trim, "CR")
                    If CheckRecordExists(lblCustID.Text.Trim, "CUSTOMERS", "CUST_CODE") = True Then
                        Clos_Balance = "UPDATE CUSTOMERS SET " & _
                                       "CUST_BALANCE = CUST_BALANCE + " & (Val(lblOrgPrice.Text.Trim) - Val(txtPaid.Text.Trim)) - gblDiscount & ", " & _
                                       "CUST_UPD_DT = N'" & _
                                       Format(Date.Parse(lblDate.Text), "MM/dd/yyyy") & "' " & _
                                       "WHERE CUST_CODE = N'" & lblCustID.Text.Trim & "'"
                    End If
                    ExecuteAdapterQuery(SqlDataAdapter, Clos_Balance, Connection)
                End If
                'Delete Hold Entries when saved
                ProcessTransaction("DELETE FROM SALE_MASTER_HOLD WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_DETAIL_HOLD WHERE SALEID = N'" & LastSaleID & "'")
                SaleReturn = True
                LastSaleID = lblInvoice.Text.Trim
                Call cmdPrint_Click(sender, e)
                cmdNew_Click(sender, e)
            End If
        Else
            gblMessage = "Sale cannot be recorded as Credit Sale." : MsgStatus.ShowDialog(Me)
        End If
        txtCode.Focus()
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Escape Then txtPaid.Focus()
        If e.KeyCode = Keys.Enter Then
            FoundItem = False
            If SaleDataGrid.RowCount > 0 Then
                For Each row As DataGridViewRow In SaleDataGrid.Rows
                    If row.Cells(0).Value.ToString.ToUpper = txtCode.Text.Trim Then
                        SaleDataGrid.Rows(row.Index).Selected = True
                        SaleDataGrid.Rows(row.Index).Cells(4).Value = Val(SaleDataGrid.Rows(row.Index).Cells(4).Value.ToString) + Val(lblQty.Text.Trim)
                        SaleDataGrid.Rows(row.Index).Cells(5).Value = Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString) * Val(SaleDataGrid.Rows(row.Index).Cells(4).Value.ToString)
                        FoundItem = True
                    End If
                Next
            End If
            Dim TempDetailSale As String = ""
            Dim StockInfo As String = "select * from products where PROD_CODE = N'" & txtCode.Text.Trim & "'"
            ExecuteAdapterQuery(SaleDataAdapter, StockInfo, Connection)
            Dim GetStockInfo As SqlDataReader = SaleDataAdapter.SelectCommand.ExecuteReader
            If GetStockInfo.HasRows Then
                While GetStockInfo.Read
                    'Add Item into SalaDataGrid
                    If FoundItem = False Then
                        Dim RowIndex As Integer = SaleDataGrid.Rows.Add()
                        Dim ItemRow As DataGridViewRow = SaleDataGrid.Rows(RowIndex)
                        ItemRow.Cells(0).Value = GetStockInfo.Item("prod_code").ToString
                        ItemRow.Cells(1).Value = GetStockInfo.Item("prod_desc").ToString
                        ItemRow.Cells(2).Value = GetStockInfo.Item("prod_packing").ToString
                        ItemRow.Cells(3).Value = GetStockInfo.Item("prod_sale_price").ToString
                        ItemRow.Cells(4).Value = txtQty.Text.ToString
                        ItemRow.Cells(5).Value = Val(GetStockInfo.Item("prod_sale_price").ToString) * Val(txtQty.Text.Trim)
                        ItemRow.Cells(6).Value = "X"
                        ItemRow.Cells(7).Value = GetStockInfo.Item("prod_head").ToString
                        ItemRow.Cells(7).Value = GetStockInfo.Item("prod_catg").ToString
                        SaleMode = True
                    End If
                    lblQty.Text = "1"
                    txtQty.Text = "1"
                    lblMode.Text = "Sale"
                    Call Get_Total()
                    Call lblTotalPrice_Validated(sender, e)
                    Call lblShowDiscount_Validated(sender, e)
                    Call lblRefund_Validated(sender, e)
                    txtPaid.Enabled = True
                    SaleReturn = False
                    txtCode.Clear()
                    txtCode.Focus()
                End While
            Else
                gblMessage = "Prodcut not available, Please check Stock."
                MsgStatus.ShowDialog(Me)
                txtCode.Clear()
                txtCode.Focus()
            End If
        End If
    End Sub

    Private Function CheckItemExist(ByVal tblName As String) As Boolean

        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POS;")

        Dim cmdText As String = _
           ("SELECT * FROM " & tblName.Trim & " WHERE (SALEID = N'" & Val(lblInvoice.Text.Trim) & "' AND STOCKID = N'" & txtCode.Text.Trim & "' AND SALESTATUS != N'HOLD')")

        Dim bRet As Boolean = False

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using

        Return bRet

    End Function

    Private Sub Get_Total()
        If SaleDataGrid.RowCount > -1 Then
            Dim TotalAmount As Double = 0
            For Each row As DataGridViewRow In SaleDataGrid.Rows
                TotalAmount += Format(Val(row.Cells(5).Value.ToString.Trim), "0.00")
            Next
            lblShowDiscount.Text = Format(Val(lblDiscount.Text.ToString), "0.00")
            lblRefund.Text = "0.00"
            lblOrgPrice.Text = TotalAmount - Val(lblDiscount.Text.Trim)
            lblTotalPrice.Text = TotalAmount - Val(lblDiscount.Text.Trim)
            'TotalQty = Val(row.Cells(4).Value.ToString.Trim)
        End If
    End Sub

    Private Sub cmdSuspend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuspend.Click
        If SaleMode = True Then
            Dim HoldQuery As String = ""
            If SaleDataGrid.RowCount > -1 Then
                ProcessTransaction("delete from sale_detail_hold where detailid = " & Val(lblSequence.Text.Trim))
                SortID = 1
                For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                    HoldQuery = "INSERT INTO SALE_DETAIL_HOLD VALUES (" & _
                                                         Val(lblSequence.Text.Trim) & ",'" & _
                                                         Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                                         Val(lblInvoice.Text.Trim) & ",'" & _
                                                         lblSaleType.Text.Trim & "'," & _
                                                         Val(lblCustID.Text.Trim) & ",'" & _
                                                         lblCustName.Text.Trim & "','" & _
                                                         OutRow.Cells(0).Value.ToString & "','" & _
                                                         OutRow.Cells(1).Value.ToString & "','" & _
                                                         OutRow.Cells(2).Value.ToString & "'," & _
                                                         OutRow.Cells(3).Value.ToString & "," & Val(OutRow.Cells(4).Value.ToString) & "," & _
                                                         Val(OutRow.Cells(5).Value.ToString) & ",'HOLD','" & _
                                                         lblUserID.Text.Trim & "',0,0,'" & OutRow.Cells(7).Value.ToString & "','" & OutRow.Cells(8).Value.ToString & "',0,'x'," & SortID & ")"
                    ProcessTransaction(HoldQuery)
                    SortID += 1
                Next OutRow

                If CheckHoldExist("SALE_MASTER_HOLD", lblInvoice.Text.Trim) = False Then
                    HoldQuery = "INSERT INTO SALE_MASTER_HOLD VALUES (" & _
                                                         Val(lblInvoice.Text.Trim) & "," & _
                                                         Val(lblUserID.Text.Trim) & ",'" & _
                                                         lblUserName.Text.Trim & "','" & _
                                                         Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                         lblSaleType.Text.Trim & "','" & _
                                                         lblSequence.Text.Trim & "','" & _
                                                         Val(lblCustID.Text.Trim) & "','" & _
                                                         lblCustName.Text.Trim & "'," & _
                                                         Val(lblOrgPrice.Text.Trim) & "," & _
                                                         Val(txtPaid.Text.Trim) & "," & _
                                                         Val(lblDiscount.Text.Trim) & "," & _
                                                         Val(lblRefund.Text.Trim) & "," & _
                                                         "1,0,0,0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "')"
                Else
                    HoldQuery = "UPDATE SALE_MASTER_HOLD SET " & _
                                                         "DrawerID = " & Val(lblUserID.Text.Trim) & "," & _
                                                         "DrawerName = N'" & lblUserName.Text.Trim & "'," & _
                                                         "DateCompleted = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                                         "SaleType = N'" & lblSaleType.Text.Trim & "'," & _
                                                         "CustomerID = " & Val(lblCustID.Text.Trim) & "," & _
                                                         "CustomerName = N'" & lblCustName.Text.Trim & "'," & _
                                                         "SaleTotal = " & Val(lblOrgPrice.Text.Trim) & "," & _
                                                         "SalePaid = " & Val(txtPaid.Text.Trim) & "," & _
                                                         "SaleDiscount = " & Val(lblDiscount.Text.Trim) & "," & _
                                                         "SaleChange = " & Val(lblRefund.Text.Trim) & "," & _
                                                         "SaleStatus = 1 " & _
                                                         "WHERE SaleID = " & Val(lblInvoice.Text.Trim)
                End If

                Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
                    Dim Cmd As New SqlCommand(HoldQuery, Conn)
                    Try
                        Conn.Open()
                        Cmd.ExecuteNonQuery()
                        lblHold.Text = Val(lblHold.Text.Trim) + 1
                        cmdNew_Click(sender, e)
                    Catch EX As Exception
                        MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                    End Try
                End Using
            End If
        Else
            gblMessage = "There is no item to hold."
            MsgStatus.ShowDialog()
        End If
        txtCode.Focus()
    End Sub

    Public Function GetMax_ID(ByVal StringID As String) As Integer

        Dim MaxID_Text As String = "SELECT MAX(MaxID) as MaxSerial FROM " & _
                                   "( " & _
                                   "SELECT MAX(SALEID) as MaxID " & _
                                   "FROM SALE_MASTER " & _
                                   "GROUP BY SALEID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(SALEID) as MaxID " & _
                                   "FROM SALE_DETAIL_TEMP " & _
                                   "GROUP BY SaleID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(SALEID) as MaxID " & _
                                   "FROM SALE_DETAIL_HOLD " & _
                                   "GROUP BY SaleID " & _
                                   ") as subQuery"


        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    GetMax_ID = 1
                Else
                    GetMax_ID = Convert.ToDecimal(Cmd.ExecuteScalar()) + 1
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return GetMax_ID
        End Using

    End Function

    Public Function GetDetail_ID(ByVal StringID As String) As Integer

        Dim MaxID_Text As String = "SELECT MAX(MaxID) as MaxSerial FROM " & _
                                   "( " & _
                                   "SELECT MAX(DETAILID) as MaxID " & _
                                   "FROM SALE_DETAIL WHERE DETAILDATE = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "' " & _
                                   "GROUP BY DetailID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(DETAILID) as MaxID " & _
                                   "FROM SALE_DETAIL_TEMP WHERE DETAILDATE = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "' " & _
                                   "GROUP BY DetailID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(DETAILID) as MaxID " & _
                                   "FROM SALE_DETAIL_HOLD WHERE DETAILDATE = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "' " & _
                                   "GROUP BY DetailID " & _
                                   ") as subQuery"

        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    GetDetail_ID = 1
                Else
                    GetDetail_ID = Convert.ToDecimal(Cmd.ExecuteScalar()) + 1
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return GetDetail_ID
        End Using

    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Val(txtPaid.Text.Trim) = 0 Then MsgBox("Amount to be paid before sale.", MsgBoxStyle.Critical, My.Application.Info.ProductName) : txtCode.Focus() : Exit Sub
        Payment = Val(lblOrgPrice.Text.Trim) - gblDiscount
        If Val(txtPaid.Text.Trim) < Payment Then gblMessage = "Payment Less than Total Amount." : MsgStatus.ShowDialog(Me) : txtPaid.Focus() : Exit Sub
        Dim SaveQuery As String = ""
        If SaleMode = True And Val(lblOrgPrice.Text.Trim) - gblDiscount = Val(txtPaid.Text.Trim) - Val(lblRefund.Text.Trim) Then
            Call Get_Total()
            Dim DetailID As String = Mid(lblSequence.Text, 9, 4)
            SaveQuery = "INSERT INTO SALE_MASTER VALUES (" & _
                                                 Val(lblInvoice.Text.Trim) & "," & _
                                                 Val(lblUserID.Text.Trim) & ",'" & _
                                                 lblUserName.Text.Trim & "','" & _
                                                 Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                 lblSaleType.Text.Trim & "','" & _
                                                 lblSequence.Text.Trim & "','" & _
                                                 Val(lblCustID.Text) & "','" & _
                                                 lblCustName.Text.Trim & "'," & _
                                                 Val(lblOrgPrice.Text.Trim) & "," & _
                                                 Val(txtPaid.Text.Trim) & "," & _
                                                 Val(lblDiscount.Text.Trim) & "," & _
                                                 Val(lblRefund.Text.Trim) & "," & _
                                                 "0,0,0,0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "')"
            ProcessTransaction(SaveQuery)

            If SaleDataGrid.RowCount > -1 Then
                ProcessTransaction("delete from sale_detail_hold where detailid = " & Val(lblSequence.Text.Trim))
                SortID = 1
                For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                    Dim SaveItemQuery As String = "INSERT INTO SALE_DETAIL_HOLD VALUES (" & _
                                                         Val(lblSequence.Text.Trim) & ",'" & _
                                                         Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                                         Val(lblInvoice.Text.Trim) & ",'" & _
                                                         lblSaleType.Text.Trim & "'," & _
                                                         Val(lblCustID.Text.Trim) & ",'" & _
                                                         lblCustName.Text.Trim & "','" & _
                                                         OutRow.Cells(0).Value.ToString & "','" & _
                                                         OutRow.Cells(1).Value.ToString & "','" & _
                                                         OutRow.Cells(2).Value.ToString & "'," & _
                                                         OutRow.Cells(3).Value.ToString & "," & Val(OutRow.Cells(4).Value.ToString) & "," & _
                                                         Val(OutRow.Cells(5).Value.ToString) & ",'SALE','" & _
                                                         lblUserID.Text.Trim & "',0,0,'" & OutRow.Cells(7).Value.ToString & "','" & OutRow.Cells(8).Value.ToString & "'df,0,'x'," & SortID & ")"
                    ProcessTransaction(SaveItemQuery)
                    SortID += 1
                Next OutRow
            End If
            LastSaleID = Val(lblInvoice.Text.Trim)
            Call UpdateStockQuantity()
            'Delete Hold Entries when saved
            ProcessTransaction("DELETE FROM SALE_MASTER_HOLD WHERE SALEID = N'" & LastSaleID & "'")
            ProcessTransaction("DELETE FROM SALE_DETAIL_HOLD WHERE SALEID = N'" & LastSaleID & "'")
            ProcessTransaction("DELETE FROM SALE_MASTER_TEMP WHERE SALEID = N'" & LastSaleID & "'")
            ProcessTransaction("DELETE FROM SALE_DETAIL_TEMP WHERE SALEID = N'" & LastSaleID & "'")
            SaleReturn = True
            cmdNew_Click(sender, e)
            txtCode.Focus()
        End If
        txtCode.Focus()
    End Sub

    Private Sub CountHoldSale()
        Dim Count As String = "Select count(distinct SaleID) from SALE_DETAIL_HOLD"
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(Count, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    lblHold.Text = 0
                Else
                    lblHold.Text = Convert.ToDecimal(Cmd.ExecuteScalar())
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End Using
        txtCode.Focus()
    End Sub

    Private Sub lblHold_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblHold.DoubleClick
        If Val(lblHold.Text) = 0 Then Exit Sub
        gblCP_ID = 0
        HoldSale.ShowDialog(Me)
        If Val(gblCP_ID.Trim) = 0 Then Exit Sub
        'Shift Hold Sale to Main Window
        Dim GetHoldInfo As String = "SELECT * from POS.dbo.SALE_DETAIL_HOLD WHERE SaleID = N'" & Val(gblCP_ID) & "' order by sortitem"
        ExecuteAdapterQuery(SqlDataAdapter, GetHoldInfo, Connection)
        Dim HoldInfoReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If HoldInfoReader.HasRows = True Then
            If Me.SaleDataGrid.Rows.Count > -1 Then
                For i As Integer = Me.SaleDataGrid.Rows.Count - 1 To 0 Step -1
                    Me.SaleDataGrid.Rows.RemoveAt(i)
                Next
            End If
            While HoldInfoReader.Read
                Dim RowIndex As Integer = SaleDataGrid.Rows.Add()
                Dim ItemRow As DataGridViewRow = SaleDataGrid.Rows(RowIndex)
                ItemRow.Cells(0).Value = HoldInfoReader.Item("stockid").ToString
                ItemRow.Cells(1).Value = HoldInfoReader.Item("stockdesc").ToString
                ItemRow.Cells(2).Value = HoldInfoReader.Item("salepack").ToString
                ItemRow.Cells(3).Value = HoldInfoReader.Item("unitcost").ToString
                ItemRow.Cells(4).Value = HoldInfoReader.Item("qty").ToString
                ItemRow.Cells(5).Value = HoldInfoReader.Item("price").ToString
                ItemRow.Cells(6).Value = "X"
                ItemRow.Cells(7).Value = HoldInfoReader.Item("headcategory").ToString
                ItemRow.Cells(8).Value = HoldInfoReader.Item("subcategory").ToString
            End While
        End If
        Dim ReleaseSale As String = "SELECT * FROM SALE_MASTER_HOLD WHERE SALEID = N'" & Val(gblCP_ID) & "' ORDER BY SALEID"
        ExecuteAdapterQuery(TransferAdapter, ReleaseSale, Connection)
        Dim ReleaseRec As SqlDataReader = TransferAdapter.SelectCommand.ExecuteReader
        If IsDBNull(ReleaseRec) = False Then
            While ReleaseRec.Read
                lblInvoice.Text = ReleaseRec.Item("SALEID").ToString
                lblSaleType.Text = ReleaseRec.Item("SALETYPE").ToString
                lblSequence.Text = ReleaseRec.Item("OFFLINEID").ToString
                lblCustID.Text = ReleaseRec.Item("CUSTOMERID").ToString
                lblCustName.Text = ReleaseRec.Item("CUSTOMERNAME").ToString
                lblOrgPrice.Text = ReleaseRec.Item("SALETOTAL").ToString
            End While
        End If
        Call Get_Total()
        Call lblTotalPrice_Validated(sender, e)
        Call lblShowDiscount_Validated(sender, e)
        Call lblRefund_Validated(sender, e)
        txtPaid.Enabled = True
        SaleMode = True
        cmdSaleReturn.Enabled = False
        txtCode.Clear()
        txtCode.Focus()
    End Sub

    Private Function CheckHoldExist(ByVal tblName As String, ByVal strFind As String) As Boolean

        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POS;")

        Dim cmdText As String = _
           ("SELECT * FROM " & tblName.Trim & " WHERE (SALEID = N'" & Val(strFind) & "')")

        Dim bRet As Boolean = False

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using

        Return bRet

    End Function

    Private Sub cmdSaleReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaleReturn.Click
        Dim ReturnQuery As String = ""
        If SaleMode = True Then
            Call Get_Total()
            Dim DetailID As String = Mid(lblSequence.Text, 9, 4)
            ReturnQuery = "INSERT INTO SALE_MASTER VALUES (" & _
                          Val(lblInvoice.Text.Trim) & "," & _
                          Val(lblUserID.Text.Trim) & ",'" & _
                          lblUserName.Text.Trim & "','" & _
                          Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                          "Sale Return" & "','" & _
                          lblSequence.Text.Trim & "','" & _
                          Val(lblCustID.Text.Trim) & "','" & _
                          lblCustName.Text.Trim & "'," & _
                          "0" & "," & _
                          "0" & "," & _
                          "0" & "," & _
                          "0" & "," & _
                          "2,0," & Val(lblOrgPrice.Text.Trim) & ",0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "')"
            ProcessTransaction(ReturnQuery)
            'save detail to sale detail table
            If SaleDataGrid.RowCount > -1 Then
                ProcessTransaction("delete from sale_detail_hold where detailid = " & Val(lblSequence.Text.Trim))
                SortID = 1
                For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                    Dim ReturnItemQuery = "INSERT INTO SALE_DETAIL VALUES (" & _
                                                         Val(lblSequence.Text.Trim) & ",'" & _
                                                         Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                                         Val(lblInvoice.Text.Trim) & ",'" & _
                                                         lblSaleType.Text.Trim & "'," & _
                                                         Val(lblCustID.Text.Trim) & ",'" & _
                                                         lblCustName.Text.Trim & "','" & _
                                                         OutRow.Cells(0).Value.ToString & "','" & _
                                                         OutRow.Cells(1).Value.ToString & "','" & _
                                                         OutRow.Cells(2).Value.ToString & "'," & _
                                                         OutRow.Cells(3).Value.ToString & "," & Val(OutRow.Cells(4).Value.ToString) * -1 & "," & _
                                                         Val(OutRow.Cells(5).Value.ToString) & ",'RETURN','" & _
                                                         lblUserID.Text.Trim & "',0,0,'" & OutRow.Cells(7).Value.ToString & "','" & OutRow.Cells(7).Value.ToString & "',0,'x'," & SortID & ")"
                    ProcessTransaction(ReturnItemQuery)
                    SortID += 1
                Next OutRow
            End If
            LastSaleID = Val(lblInvoice.Text.Trim)
            'update product stock
            Call UpdateStockQuantity()
            ' To update journal transactions if credit customer info given
            If Val(lblCustID.Text.Trim) > 0 Then
                Call Updt_General_Journal(Val(lblOrgPrice.Text), TotalQty, Val(lblCustID.Text.Trim), lblDate.Text, Items.Trim, "DR")
                If CheckRecordExists(lblCustID.Text.Trim, "CUSTOMERS", "CUST_CODE") = True Then
                    Clos_Balance = "UPDATE CUSTOMERS SET " & _
                                   "CUST_BALANCE = CUST_BALANCE - " & Val(lblOrgPrice.Text.Trim) & ", " & _
                                   "CUST_UPD_DT = N'" & Format(Date.Parse(lblDate.Text), "MM/dd/yyyy") & "' " & _
                                   "WHERE CUST_CODE = N'" & lblCustID.Text.Trim & "'"
                    ProcessTransaction(Clos_Balance)
                End If
            End If
            cmdNew_Click(sender, e)
        Else
            gblMessage = "Please first add item to return."
            MsgStatus.ShowDialog(Me)
        End If
        txtCode.Focus()
    End Sub

    Private Sub UpdateStockQuantity()
        Dim SelectQty As String = "SELECT * FROM SALE_DETAIL WHERE SaleID = " & LastSaleID
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                ProcessTransaction("update products set prod_stock = prod_stock + " & Val(Updater.Item("qty")) & " where prod_code = N'" & Updater.Item("StockID").ToString & "'")
            End While
            If Updater Is Nothing Then Updater.Close()
        End If
    End Sub

    Private Sub UpdateReturnQuantity()
        Items = ""
        FinalQty = 0
        Dim SelectQty As String = "SELECT StockID,StockDesc,SUM(QTY) AS StockQty FROM SALE_DETAIL WHERE SaleID = N'" & LastSaleID & "' GROUP BY StockID, StockDesc"
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                Items = Items.Trim & Updater.Item("StockDesc").ToString & ", "
                ProductQty = Val(Updater.Item("StockQty").ToString)
                ProductID = Updater.Item("StockID").ToString
                'Get quantity balance for return products
                Dim PrevQuantity As String = "SELECT PROD_STOCK FROM PRODUCTS WHERE PROD_CODE = N'" & ProductID.Trim & "'"
                ExecuteAdapterQuery(ProductAdapter, PrevQuantity, Connection)
                Dim QtyAdjuster As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
                If QtyAdjuster.HasRows = True Then
                    QtyAdjuster.Read()
                    Q1 = Val(QtyAdjuster.Item("PROD_STOCK").ToString)
                    FinalQty = Q1 + ProductQty
                    Call ExecuteUpdateQuery("PROD_STOCK", FinalQty, ProductID)
                    QtyAdjuster.Close()
                End If
            End While
            If Updater Is Nothing Then Updater.Close()
        End If
    End Sub

    Private Sub ExecuteUpdateQuery(ByVal TableField As String, ByVal FieldQty As String, ByVal StockID As String)
        'Passes values to update table fields
        Dim UpdateQty As String = "UPDATE PRODUCTS SET " & TableField.Trim & " = " & Val(FieldQty.Trim) & " WHERE PROD_CODE = N'" & StockID.ToString.Trim & "'"
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(UpdateQty, Conn)
            Try
                Conn.Open()
                Cmd.ExecuteNonQuery()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End Using

    End Sub

    Private Sub Updt_General_Journal(ByVal strPrice As Double, ByVal Total_Qty As Double, ByVal Cust_Code As Integer, ByVal strDate As String, ByVal strDesc As String, ByVal strType As String)
        Dim cmdText As String = ""
        ' To made general journal transaction for concerned suppliers while update products
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POS;")
        Dim Trans_ID, Opn_Bal, Clo_Bal As Double
        Dim Customer_Name As String = ""
        Trans_ID = 0
        Opn_Bal = 0
        Clo_Bal = 0

        Dim Max_Tr As Double = GenerateMax_ID("CUSTOMERS_PAYM", "CUST_TR_ID")

        Dim Get_Supplier As String = "select * from customers where cust_code = " & Cust_Code
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Customer_Name = SuppliersReader.Item("CUST_NAME").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("CUST_BALANCE").ToString.Trim)
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        Else
            Opn_Bal = 0
        End If

        Trans_ID = GenerateMax_ID("CUSTOMERS_PAYM", "CUST_TR_ID")
        If strType.Trim = "CR" Then Clo_Bal = Opn_Bal + strPrice Else Clo_Bal = Opn_Bal - strPrice

        If strType.Trim = "CR" Then
            cmdText = _
               ("INSERT INTO CUSTOMERS_PAYM VALUES ('" & Cust_Code & "','" & Format(Date.Parse(lblDate.Text.ToString), "MM/dd/yyyy") & "','" & Trans_ID & "','" & Customer_Name & "','" & "Purchases (" & strDesc.Trim & ") Qty. (" & Total_Qty & ") Invoice # " & lblInvoice.Text.Trim & "'," & Opn_Bal & "," & Val(txtPaid.Text.Trim) & "," & strPrice & "," & Clo_Bal & ",'" & Format(Date.Parse(strDate.ToString), "MM/dd/yyyy") & "')")
        Else
            cmdText = _
               ("INSERT INTO CUSTOMERS_PAYM VALUES ('" & Cust_Code & "','" & Format(Date.Parse(lblDate.Text.ToString), "MM/dd/yyyy") & "','" & Trans_ID & "','" & Customer_Name & "','" & "Purchases Return (" & strDesc.Trim & ") Qty. (" & Total_Qty & ") Invoice # " & lblInvoice.Text.Trim & "'," & Opn_Bal & "," & strPrice & ",0," & Clo_Bal & ",'" & Format(Date.Parse(strDate.ToString), "MM/dd/yyyy") & "')")
        End If

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Try
                    sqlCmd.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                End Try
            End Using
        End Using

    End Sub

    Private Function CheckRecordExists(ByVal strFind As String, ByVal tblName As String, ByVal strField As String) As Boolean
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POS;")
        Dim cmdText As String = _
           ("SELECT * FROM " & tblName.Trim & " WHERE (" & strField.Trim & " = N'" & strFind.Trim & "')")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using
        Return bRet
    End Function

    Private Sub SaleDataGrid_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SaleDataGrid.CellContentClick
        If e.ColumnIndex = 6 Then
            SaleDataGrid.Rows.RemoveAt(e.RowIndex)
            Call Get_Total()
            Call lblTotalPrice_Validated(sender, e)
            Call lblShowDiscount_Validated(sender, e)
            Call lblRefund_Validated(sender, e)
            txtCode.Focus()
        End If
    End Sub

    Private Sub SaleDataGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SaleDataGrid.CellDoubleClick
        If SaleDataGrid.RowCount > 0 Then
            Dim SaleQty As String = InputBox("Enter quantity to update", "Quantity Update", "only digit")
            If SaleQty.Trim = "" Then Exit Sub
            If IsNumeric(SaleQty.Trim) And Val(SaleQty.Trim) > 0 Then
                SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(4).Value = Val(SaleQty)
                SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(5).Value = Val(SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(3).Value.ToString) * Val(SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(4).Value.ToString)
            End If
            Call Get_Total()
            Call lblTotalPrice_Validated(sender, e)
            Call lblShowDiscount_Validated(sender, e)
            Call lblRefund_Validated(sender, e)
            txtCode.Focus()
        End If
    End Sub

    Private Sub lblShowDiscount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblShowDiscount.Validated
        'Display the value as local currency.
        Me.lblShowDiscount.Text = Decimal.Parse(Me.lblShowDiscount.Text).ToString("c")
    End Sub

    Private Sub lblShowDiscount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lblShowDiscount.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.lblShowDiscount.Text, _
                                Globalization.NumberStyles.Currency, _
                                Nothing, _
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With Me.lblShowDiscount
                '.HideSelection = False
                '.SelectAll()

                MessageBox.Show("Please enter a valid currency amount.", _
                                "Invalid Value", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)

                '.HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub lblRefund_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRefund.Validated
        'Display the value as local currency.
        Me.lblRefund.Text = Decimal.Parse(Me.lblRefund.Text).ToString("c")
    End Sub

    Private Sub lblRefund_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lblRefund.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.lblRefund.Text, _
                                Globalization.NumberStyles.Currency, _
                                Nothing, _
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With Me.lblRefund
                '.HideSelection = False
                '.SelectAll()

                MessageBox.Show("Please enter a valid currency amount.", _
                                "Invalid Value", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)

                '.HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

#End Region
End Class