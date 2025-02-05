Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Imports System.IO

Public Class SaleScreen
    Dim currentpath As String = Directory.GetCurrentDirectory()
    Dim ProductID As String = String.Empty
    Dim CreditBal, DebitBal As Double
    Dim ProductQty, FinalQty As Integer
    Dim drag, FoundItem, EditInvoiceMode, HoldReturn As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim EditBindingSource As New BindingSource
    Dim EditDataSet As New DataSet
    Dim Items, Clos_Balance, LastSaleID, HoldSaleInvoice As String
    Dim Payment, FinalPayment, TotalQty, Dues, ProdPrice As Double
    Dim SaleMode, ReturnMode, DiscountAllow, SaleReturn, SaleCredit, EditSale As Boolean
    Dim SortID, NewQty, Max_ID, Q1, Q2 As Integer
    Dim ItemCodes As New List(Of String)()

    Private Sub SaleScreen_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCode.Focus()
    End Sub

    Private Sub SaleScreen_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F3 Then cmdCustomer_Click(sender, e)
        If e.KeyCode = Keys.F4 Then cmdDiscount_Click(sender, e)
        If e.KeyCode = Keys.F6 Then cmdCreditSale_Click(sender, e)
        If e.KeyCode = Keys.F7 Then cmdSaleReturn_Click(sender, e)
        If e.KeyCode = Keys.F8 Then cmdSave_Click(sender, e)
        If e.KeyCode = Keys.F9 Then cmdPrint_Click(sender, e)
        If e.KeyCode = Keys.F10 Then lblHold_DoubleClick(sender, e)
        If e.KeyCode = Keys.F11 Then cmdNew_Click(sender, e)
        If e.KeyCode = Keys.F12 Then cmdSuspend_Click(sender, e)
        If e.KeyCode = Keys.E AndAlso e.Modifiers = Keys.Control Then Get_Quantity_on_DblClick(sender, e)
        If e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control Then Call SearchProduct()
        If e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control Then Call cmdFind_Click(sender, e)
    End Sub

    Private Sub SaleScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Call GetConnectionString()
        Call cmdNew_Click(sender, e)
        txtCode.Focus()
        txtCode.Focus()
        gblCashReceived = False
        EditInvoiceMode = False
        HoldReturn = False
        CreditBal = 0
        DebitBal = 0
        lblUserID.Text = gblPrliviges
    End Sub

    Private Sub cmdSelectBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectBill.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to print", "Print Sale Invoice")
        If SaleInvoice.Trim = String.Empty Then Exit Sub
        If Len(SaleInvoice.Trim) > 0 Then
            gblFind = SaleInvoice.Trim.ToUpper
            gblReportOption = "RECEIPT"
            gblReportName = currentpath & "\Reports\CashReceipt.rpt"
            gblReportFilter = "RECEIPT"
            Call Print_Slips_Manually()
        End If
        txtCode.Focus()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        ValidateAlphaNumOnly(sender, e)
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            ProductCode.ShowDialog(Me)
            If Len(gblItemCode) > 0 Then txtCode.Text = gblItemCode.ToUpper Else txtCode.Clear()
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
        'Call lblHold_DoubleClick(sender, e)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If Me.SaleDataGrid.Rows.Count > -1 Then
            For i As Integer = Me.SaleDataGrid.Rows.Count - 1 To 0 Step -1
                Me.SaleDataGrid.Rows.RemoveAt(i)
            Next
        End If
        If HoldReturn = True Then
            Dim response As DialogResult = MessageBox.Show("Delete Hold Invoice # " & HoldSaleInvoice & " from list.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = Windows.Forms.DialogResult.Yes Then
                ProcessTransaction("delete from sale_master_hold where saleid = N'" & HoldSaleInvoice & "'")
                ProcessTransaction("delete from sale_detail_hold where saleid = N'" & HoldSaleInvoice & "'")
            End If
        End If
        lblDate.Text = Format(Now.Date, "MMMM, dd - yyyy")
        txtCode.Clear()
        SortID = 1
        gblDiscount = "0"
        txtCustomerName.Clear()
        lblDiscount.Text = "0"
        lblShowDiscount.Text = "0"
        lblTotItems.Text = "0"
        lblQty.Text = "1"
        lblMode.Text = "Sale"
        lblCustID.Text = "00"
        lblCustName.Text = String.Empty
        lblNetDues.Text = "00"
        lblSaleType.Text = "Walkin Customer"
        lblCustomer.Text = "No Customer Selected"
        txtCustomerName.Visible = False
        lblInvoice.Text = gblInvPrefix & GetMax_ID(lblInvoice.Text)
        lblSequence.Text = lblInvoice.Text.Trim & Format(Now.Date, "MMddyyyy")
        Call Get_Total()
        Call CountHoldSale()
        Call Set_Enable_Disable(False)
        txtCode.Focus()
        txtCode.Focus()
        SaleMode = False
        rbRetail.Checked = True
        rbWholeSale.Checked = False
        cmdFind.Enabled = True
        btnPaid.Enabled = True
        EditInvoiceMode = False
        HoldReturn = False
        HoldSaleInvoice = String.Empty
    End Sub

    Private Sub cmdCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomer.Click
        CustomerCode.ShowDialog(Me)
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
            If Len(txtCustomerName.Text.Trim) > 0 Then lblSaleType.Text = "Walkin Customer"
            lblCustName.Text = StrConv(txtCustomerName.Text.Trim, VbStrConv.ProperCase) : txtCustomerName.Visible = False : txtCode.Focus()
        End If
    End Sub

    Private Sub txtCustomerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerName.KeyPress
        Call ValidateAlphaKeyPress(sender, e, txtCustomerName)
    End Sub

    Private Sub txtCustomerName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.LostFocus
        If Len(txtCustomerName.Text.Trim) > 0 Then lblSaleType.Text = "Walkin Customer"
        lblCustName.Text = StrConv(txtCustomerName.Text.Trim, VbStrConv.ProperCase) : txtCustomerName.Visible = False : txtCode.Focus()
    End Sub

    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click
        If SaleMode = True Then
            Dim Data As String = String.Empty
            Data = Microsoft.VisualBasic.InputBox("Please Enter Allowed Discount (must be numeric).", My.Application.Info.ProductName, "0")
            If IsNumeric(Data) = True Then
                DiscountAllow = True
                gblDiscount = Val(Data)
                lblNetDues.Text = Val(lblOrgPrice.Text.Trim) - gblDiscount
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
        txtQty.Visible = True
        txtQty.Focus()
        txtQty.SelectAll()
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
            lblTotalPrice.Text = Val(lblOrgPrice.Text.Trim)
            Call lblTotalPrice_Validated(sender, e)
            Call lblShowDiscount_Validated(sender, e)
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gblMessage = "Please wait, Receipt is Printing."
        MsgStatus.ShowDialog(Me)
        gblFind = LastSaleID
        gblReportOption = "RECEIPT"
        gblReportName = currentpath & "\Reports\CashReceipt.rpt"
        Call Print_Slips_Manually()
        txtCode.Focus()
    End Sub

    Private Sub SaleScreen_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub SaleScreen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub SaleScreen_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

#Region "Runtime Functons and Procedures for Sale Form" '/CLICK TO HIDE OR UNHIDE

    Private Sub cmdCreditSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreditSale.Click
        If SaleMode = True Then
            Dim Data As String = String.Empty
            Data = Microsoft.VisualBasic.InputBox("Please Enter Down Payment.", My.Application.Info.ProductName, "0")
            If IsNumeric(Data) = False Then txtCode.Focus() : Exit Sub
            gblPayment = Val(Data)
            lblNetDues.Text = Val(lblOrgPrice.Text.Trim) - gblDiscount - gblPayment
            If SaleMode = True Then
                Dim MasterQuery As String = String.Empty
                'Update Master Table
                MasterQuery = "INSERT INTO SALE_MASTER VALUES ('" & _
                            lblInvoice.Text.Trim.ToUpper & "'," & _
                            Val(lblUserID.Text.Trim) & ",'" & _
                            lblUserName.Text.Trim & "','" & _
                            Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                            lblSaleType.Text.Trim & "','" & _
                            lblSequence.Text.Trim & "','" & _
                            Val(lblCustID.Text.Trim) & "','" & _
                            lblCustName.Text.Trim & "'," & _
                            Val(lblOrgPrice.Text.Trim) & "," & _
                            Val(lblDiscount.Text.Trim) & "," & _
                            Val(lblOrgPrice.Text.Trim) - Val(lblDiscount.Text.Trim) & "," & _
                            gblPayment & "," & _
                            "0" & "," & _
                            "'ACCOUNT'," & Val(lblNetDues.Text.Trim) & ",0,0,'" & _
                            Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "',0)"
                ProcessTransaction(MasterQuery)
                'Update child table
                Dim HoldQuery As String = ""
                If SaleDataGrid.RowCount > -1 Then
                    ProcessTransaction("delete from sale_detail where detailid = '" & lblInvoice.Text.Trim & "'")
                    SortID = 1
                    TotalQty = 0
                    Items = String.Empty
                    For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                        HoldQuery = "INSERT INTO SALE_DETAIL VALUES ('" & _
                                                             lblSequence.Text.Trim & "','" & _
                                                             Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                             lblInvoice.Text.Trim & "','" & _
                                                             lblSaleType.Text.Trim & "'," & _
                                                             Val(lblCustID.Text.Trim) & ",'" & _
                                                             lblCustName.Text.Trim & "','" & _
                                                             OutRow.Cells(0).Value.ToString & "','" & _
                                                             OutRow.Cells(1).Value.ToString & "','" & _
                                                             OutRow.Cells(2).Value.ToString & "'," & _
                                                             OutRow.Cells(3).Value.ToString & "," & _
                                                             Val(OutRow.Cells(4).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(5).Value.ToString) & ",'ACCOUNT','" & _
                                                             lblUserID.Text.Trim & "',0,0,'" & _
                                                             OutRow.Cells(7).Value.ToString & "','" & _
                                                             OutRow.Cells(8).Value.ToString & "',0,'x'," & SortID & ",'" & _
                                                             OutRow.Cells(9).Value.ToString & "'," & _
                                                             Val(OutRow.Cells(5).Value.ToString) & ",'" & _
                                                             OutRow.Cells(10).Value.ToString.ToUpper & "')"
                        ProcessTransaction(HoldQuery)
                        SortID += 1
                        TotalQty = TotalQty + Val(OutRow.Cells(4).Value.ToString)
                        Items = OutRow.Cells(1).Value.ToString & ","
                    Next OutRow
                End If
                LastSaleID = lblInvoice.Text.Trim
                Call UpdateStockQuantity()
                'Delete Hold Entries when saved
                ProcessTransaction("DELETE FROM SALE_MASTER_HOLD WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_DETAIL_HOLD WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_MASTER_TEMP WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_DETAIL_TEMP WHERE SALEID = N'" & LastSaleID & "'")
                SaleReturn = True
                cmdNew_Click(sender, e)
                TotalQty = 0
                Items = String.Empty
                txtCode.Focus()
            End If
        Else
            gblMessage = "Sale cannot be recorded as Credit Sale." : MsgStatus.ShowDialog(Me)
            lblNetDues.Text = Val(lblOrgPrice.Text.Trim) - gblDiscount
        End If
        'End If
        txtCode.Focus()
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            FoundItem = False
            'Update item quantity if same item enter again in product code textbox
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
                        If rbRetail.Checked = True Then ProdPrice = Val(GetStockInfo.Item("prod_sale_price").ToString)
                        If rbWholeSale.Checked = True Then ProdPrice = Val(GetStockInfo.Item("prod_wsale_price").ToString)
                        ItemRow.Cells(0).Value = GetStockInfo.Item("prod_code").ToString.ToUpper
                        ItemRow.Cells(1).Value = GetStockInfo.Item("prod_desc").ToString.ToUpper
                        ItemRow.Cells(2).Value = GetStockInfo.Item("prod_packing").ToString.ToUpper
                        ItemRow.Cells(3).Value = ProdPrice
                        ItemRow.Cells(4).Value = txtQty.Text.ToString
                        ItemRow.Cells(5).Value = ProdPrice * Val(txtQty.Text.Trim)
                        ItemRow.Cells(6).Value = "X"
                        ItemRow.Cells(7).Value = GetStockInfo.Item("prod_head").ToString.ToUpper
                        ItemRow.Cells(8).Value = GetStockInfo.Item("prod_catg").ToString.ToUpper
                        ItemRow.Cells(9).Value = GetStockInfo.Item("prod_brand").ToString.ToUpper
                        ItemRow.Cells(10).Value = GetStockInfo.Item("prod_size").ToString.ToUpper
                        SaleMode = True
                    End If
                    lblQty.Text = "1"
                    txtQty.Text = "1"
                    lblMode.Text = "Sale"
                    Call Get_Total()
                    Call lblTotalPrice_Validated(sender, e)
                    Call lblShowDiscount_Validated(sender, e)
                    SaleReturn = False
                    SaleMode = True
                    txtCode.Clear()
                    txtCode.Focus()
                    Call Set_Enable_Disable(True)
                    cmdFind.Enabled = False
                    'cmdPrint.Enabled = True
                    btnPaid.Enabled = False
                    If EditInvoiceMode = True Then CreditBal += ProdPrice
                    'lblTotItems.Text = Val(lblTotItems.Text) + 1
                End While
                If GetStockInfo Is Nothing Then GetStockInfo.Close()
            Else
                gblMessage = "Prodcut not available, Please check Stock."
                MsgStatus.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Function CheckItemExist(ByVal tblName As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("SELECT * FROM " & tblName.Trim & " WHERE (SALEID = N'" & lblInvoice.Text.Trim & "' AND STOCKID = N'" & txtCode.Text.Trim & "' AND SALESTATUS != N'HOLD')")
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
            Dim TotalAmount As Double = 0.0
            lblTotItems.Text = 0
            For Each row As DataGridViewRow In SaleDataGrid.Rows
                TotalAmount += Format(Val(row.Cells(5).Value.ToString.Trim), "0.00")
                lblTotItems.Text = Val(lblTotItems.Text) + 1
            Next
            lblShowDiscount.Text = Format(Val(lblDiscount.Text.ToString), "0.00")
            lblOrgPrice.Text = TotalAmount
            lblTotalPrice.Text = TotalAmount
            lblNetDues.Text = Format(TotalAmount - gblDiscount, "0.00")
        End If
    End Sub

    Private Sub cmdSuspend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuspend.Click
        If SaleMode = True Then
            Dim HoldQuery As String = ""
            If SaleDataGrid.RowCount > -1 Then
                ProcessTransaction("delete from sale_detail_hold where detailid = '" & lblSequence.Text.Trim & "'")
                SortID = 1
                For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                    HoldQuery = "INSERT INTO SALE_DETAIL_HOLD VALUES ('" & _
                                                         lblSequence.Text.Trim & "','" & _
                                                         Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                         lblInvoice.Text.Trim & "','" & _
                                                         lblSaleType.Text.Trim & "'," & _
                                                         Val(lblCustID.Text.Trim) & ",'" & _
                                                         lblCustName.Text.Trim & "','" & _
                                                         OutRow.Cells(0).Value.ToString & "','" & _
                                                         OutRow.Cells(1).Value.ToString & "','" & _
                                                         OutRow.Cells(2).Value.ToString & "'," & _
                                                         OutRow.Cells(3).Value.ToString & "," & _
                                                         Val(OutRow.Cells(4).Value.ToString) & "," & _
                                                         Val(OutRow.Cells(5).Value.ToString) & ",'HOLD','" & _
                                                         lblUserID.Text.Trim & "',0,0,'" & _
                                                         OutRow.Cells(7).Value.ToString & "','" & _
                                                         OutRow.Cells(8).Value.ToString & "',0,'x'," & SortID & ",'" & _
                                                         OutRow.Cells(9).Value.ToString & "','" & _
                                                         OutRow.Cells(10).Value.ToString & "')"
                    ProcessTransaction(HoldQuery)
                    SortID += 1
                Next OutRow

                If CheckSaleExist("SALE_MASTER_HOLD", lblInvoice.Text.Trim) = False Then
                    HoldQuery = "INSERT INTO SALE_MASTER_HOLD VALUES ('" & _
                                                         lblInvoice.Text.Trim & "'," & _
                                                         Val(lblUserID.Text.Trim) & ",'" & _
                                                         lblUserName.Text.Trim & "','" & _
                                                         Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                         lblSaleType.Text.Trim & "','" & _
                                                         lblSequence.Text.Trim & "','" & _
                                                         Val(lblCustID.Text.Trim) & "','" & _
                                                         lblCustName.Text.Trim & "'," & _
                                                         Val(lblOrgPrice.Text.Trim) & "," & _
                                                         Val(lblDiscount.Text.Trim) & "," & _
                                                         Val(lblNetDues.Text.Trim) & "," & _
                                                         gblPayment & "," & _
                                                         gblRefund & "," & _
                                                         "'HOLD',0,0,0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "',0)"
                Else
                    HoldQuery = "UPDATE SALE_MASTER_HOLD SET " & _
                                                         "DrawerID = " & Val(lblUserID.Text.Trim) & "," & _
                                                         "DrawerName = N'" & lblUserName.Text.Trim & "'," & _
                                                         "DateCompleted = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                                         "SaleType = N'" & lblSaleType.Text.Trim & "'," & _
                                                         "CustomerID = " & Val(lblCustID.Text.Trim) & "," & _
                                                         "CustomerName = N'" & lblCustName.Text.Trim & "'," & _
                                                         "SaleTotal = " & Val(lblOrgPrice.Text.Trim) & "," & _
                                                         "SalePaid = " & Val(lblNetDues.Text.Trim) & "," & _
                                                         "SaleDiscount = " & Val(lblDiscount.Text.Trim) & "," & _
                                                         "SaleChange = " & Val("0") & "," & _
                                                         "SaleStatus = 'HOLD' " & _
                                                         "WHERE SaleID = '" & lblInvoice.Text.Trim & "'"
                End If

                Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
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
                                   "SELECT MAX(CONVERT(INT, RIGHT(SALEID, LEN(SALEID)-3))) as MaxID " & _
                                   "FROM SALE_MASTER where LEFT(SALEID, 3) = N'" & gblInvPrefix & "' " & _
                                   "GROUP BY SALEID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(CONVERT(INT, RIGHT(SALEID, LEN(SALEID)-3))) as MaxID " & _
                                   "FROM SALE_DETAIL_TEMP where LEFT(SALEID, 3) = N'" & gblInvPrefix & "' " & _
                                   "GROUP BY SaleID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(CONVERT(INT, RIGHT(SALEID, LEN(SALEID)-3))) as MaxID " & _
                                   "FROM SALE_DETAIL_HOLD where LEFT(SALEID, 3) = N'" & gblInvPrefix & "' " & _
                                   "GROUP BY SaleID " & _
                                   ") as subQuery"


        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
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
                                   "SELECT MAX(CONVERT(INT, RIGHT(DETAILID, LEN(DETAILID)-3))) as MaxID " & _
                                   "FROM SALE_DETAIL WHERE DETAILDATE = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "' AND LEFT(DETAILID, 3) = N'" & gblInvPrefix & "' " & _
                                   "GROUP BY DetailID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(CONVERT(INT, RIGHT(DETAILID, LEN(DETAILID)-3))) as MaxID " & _
                                   "FROM SALE_DETAIL_TEMP WHERE DETAILDATE = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "' AND LEFT(DETAILID, 3) = N'" & gblInvPrefix & "' " & _
                                   "GROUP BY DetailID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(CONVERT(INT, RIGHT(DETAILID, LEN(DETAILID)-3))) as MaxID " & _
                                   "FROM SALE_DETAIL_HOLD WHERE DETAILDATE = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "' AND LEFT(DETAILID, 3) = N'" & gblInvPrefix & "' " & _
                                   "GROUP BY DetailID " & _
                                   ") as subQuery"

        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
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
        gblNet = Val(lblNetDues.Text.Trim)
        gblDiscount = Val(lblDiscount.Text.Trim)
        PaymentBox.ShowDialog()
        If gblPayment > -1 Then
            Call CashSale(sender, e)
        End If
        txtCode.Focus()
    End Sub

    Private Sub CountHoldSale()
        Dim Count As String = "Select count(distinct SaleID) from SALE_DETAIL_HOLD"
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
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
        If Val(lblHold.Text) = 0 Then txtCode.Focus() : Exit Sub
        gblCP_ID = 0
        HoldSale.ShowDialog(Me)
        If Len(gblCP_ID.Trim) = 0 Then txtCode.Focus() : Exit Sub
        'Shift Hold Sale to Main Window
        Dim GetHoldInfo As String = "SELECT * from POS.dbo.SALE_DETAIL_HOLD WHERE SaleID = N'" & gblCP_ID.Trim & "' order by sortitem"
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
                ItemRow.Cells(8).Value = HoldInfoReader.Item("category").ToString
                ItemRow.Cells(9).Value = HoldInfoReader.Item("subcategory").ToString
                ItemRow.Cells(10).Value = HoldInfoReader.Item("itemsize").ToString
            End While
            If HoldInfoReader Is Nothing Then HoldInfoReader.Close()
        End If
        Dim ReleaseSale As String = "SELECT * FROM SALE_MASTER_HOLD WHERE SALEID = N'" & gblCP_ID.Trim & "' ORDER BY SALEID"
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
            If ReleaseRec Is Nothing Then ReleaseRec.Close()
            lblHold.Text = Val(lblHold.Text.Trim) - 1
        End If
        Call Get_Total()
        Call lblTotalPrice_Validated(sender, e)
        Call lblShowDiscount_Validated(sender, e)
        SaleMode = True
        Call Set_Enable_Disable(True)
        txtCode.Focus()
        HoldReturn = True
        HoldSaleInvoice = lblInvoice.Text.Trim
    End Sub

    Private Function CheckSaleExist(ByVal tblName As String, ByVal strFind As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("SELECT * FROM " & tblName.Trim & " WHERE (SALEID = N'" & strFind & "')")
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
        gblNet = Val(lblNetDues.Text.Trim)
        ReturnPayment.ShowDialog()
        If gblPayment = 0 And ReturnItem = False Then txtCode.Focus() : Exit Sub
        If gblPayment < gblNet - gblDiscount And ReturnItem = False Then txtCode.Focus() : Exit Sub
        Dim ReturnQuery As String = String.Empty
        If SaleMode = True Then
            Call Get_Total()
            If ReturnItem = True Then
                lblOrgPrice.Text = 0
                gblDiscount = 0
                gblNet = 0
                gblPayment = 0
                lblShowDiscount.Text = 0
                lblNetDues.Text = 0
            End If
            Dim DetailID As String = lblSequence.Text
            ReturnQuery = "INSERT INTO SALE_MASTER VALUES ('" & _
                          lblInvoice.Text.Trim & "'," & _
                          Val(lblUserID.Text.Trim) & ",'" & _
                          lblUserName.Text.Trim & "','" & _
                          Format(Date.Parse(lblDate.Text.Trim.ToString), "MM/dd/yyyy") & "','" & _
                          lblSaleType.Text.Trim & "','" & _
                          lblSequence.Text.Trim & "','" & _
                          Val(lblCustID.Text) & "','" & _
                          lblCustName.Text.Trim & "'," & _
                          Val(lblOrgPrice.Text.Trim) & "," & _
                          gblDiscount & "," & _
                          "0" & "," & _
                          "0" & "," & _
                          "0" & "," & _
                          "'RETURN',0," & gblPayment & ",0,'" & Format(Date.Parse(lblDate.Text.Trim.ToString), "MM/dd/yyyy") & "',0)"
            ProcessTransaction(ReturnQuery)
            'save detail to sale detail table
            If SaleDataGrid.RowCount > -1 Then
                ProcessTransaction("delete from sale_detail_hold where detailid = " & Val(lblSequence.Text.Trim))
                SortID = 1
                TotalQty = 0
                Items = String.Empty
                For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                    Dim ReturnPrice, ReturnTotal As Double
                    If ReturnItem = True Then
                        ReturnPrice = 0
                        ReturnTotal = 0
                    Else
                        ReturnPrice = Val(OutRow.Cells(3).Value.ToString)
                        ReturnTotal = Val(OutRow.Cells(5).Value.ToString)
                    End If
                    Dim ReturnItemQuery = "INSERT INTO SALE_DETAIL VALUES ('" & _
                                                         lblSequence.Text.Trim & "','" & _
                                                         Format(Date.Parse(lblDate.Text.Trim.ToString), "MM/dd/yyyy") & "','" & _
                                                         lblInvoice.Text.Trim & "','" & _
                                                         lblSaleType.Text.Trim & "'," & _
                                                         Val(lblCustID.Text.Trim) & ",'" & _
                                                         lblCustName.Text.Trim & "','" & _
                                                         OutRow.Cells(0).Value.ToString & "','" & _
                                                         OutRow.Cells(1).Value.ToString & "','" & _
                                                         OutRow.Cells(2).Value.ToString & "'," & _
                                                         ReturnPrice & "," & Val(OutRow.Cells(4).Value.ToString) * -1 & "," & _
                                                         ReturnTotal & ",'RETURN','" & _
                                                         lblUserID.Text.Trim & "',0,0,'" & OutRow.Cells(7).Value.ToString & "','" & _
                                                         OutRow.Cells(8).Value.ToString & "',0,'x'," & SortID & ",'" & _
                                                         OutRow.Cells(9).Value.ToString & "',0,'" & _
                                                         OutRow.Cells(10).Value.ToString & "')"
                    ProcessTransaction(ReturnItemQuery)
                    SortID += 1
                    TotalQty = TotalQty + Val(OutRow.Cells(4).Value.ToString)
                    Items = OutRow.Cells(1).Value.ToString & ","
                Next OutRow
            End If
            LastSaleID = lblInvoice.Text.Trim
            ' Update Return Stock
            Call UpdateReturnQuantity()
            ' To update journal transactions if credit customer info given
            If Val(lblCustID.Text.Trim) > 0 And ReturnItem = False Then
                Call Update_Customer_Ledger(Val(lblNetDues.Text), Val(lblCustID.Text.Trim), Format(Date.Parse(lblDate.Text.Trim.ToString), "MM/dd/yyyy"), "Return (" & Items.Trim & ")", "CR")
            End If
            cmdNew_Click(sender, e)
            TotalQty = 0
            Items = String.Empty
            txtCode.Focus()
            ReturnItem = False
        Else
            gblMessage = "Please first add item to return."
            MsgStatus.ShowDialog(Me)
        End If
        txtCode.Focus()
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

    Private Sub UpdateReturnQuantity()
        Items = String.Empty
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
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(UpdateQty, Conn)
            Try
                Conn.Open()
                Cmd.ExecuteNonQuery()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End Using

    End Sub

    Private Function CheckRecordExists(ByVal strFind As String, ByVal tblName As String, ByVal strField As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
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
            txtCode.Focus()
        End If
    End Sub

    Private Sub SaleDataGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SaleDataGrid.CellDoubleClick
        If e.ColumnIndex = 4 Then
            Call Get_Quantity_on_DblClick(sender, e)
        End If
        If e.ColumnIndex = 1 Then
            With SaleDataGrid
                ExtendDescription.ShowDialog()
                If gblExtDesc <> String.Empty Then .Rows(.CurrentRow.Index).Cells(1).Value = .Rows(.CurrentRow.Index).Cells(1).Value.ToString & Space(1) & gblExtDesc
                If Val(gblExtPrice) > 0 Then
                    .Rows(.CurrentRow.Index).Cells(3).Value = Val(.Rows(.CurrentRow.Index).Cells(3).Value.ToString) + Val(gblExtPrice)
                    .Rows(.CurrentRow.Index).Cells(5).Value = Val(.Rows(.CurrentRow.Index).Cells(4).Value.ToString) * Val(gblExtPrice)
                End If
                Call Get_Total()
                Call lblTotalPrice_Validated(sender, e)
                Call lblShowDiscount_Validated(sender, e)
            End With
        End If
    End Sub

    Private Sub Get_Quantity_on_DblClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If SaleDataGrid.RowCount > 0 Then
            Dim SaleQty As String = InputBox("Enter quantity to update", "Quantity Update", "only digit")
            If SaleQty.Trim = "" Then txtCode.Focus() : Exit Sub
            If IsNumeric(SaleQty.Trim) And Val(SaleQty.Trim) > 0 Then
                SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(4).Value = Val(SaleQty)
                SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(5).Value = Val(SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(3).Value.ToString) * Val(SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(4).Value.ToString)
            End If
            Call Get_Total()
            Call lblTotalPrice_Validated(sender, e)
            Call lblShowDiscount_Validated(sender, e)
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

    Private Sub Set_Enable_Disable(ByVal Status As Boolean)
        SaleMode = Status
        SaleReturn = Status
        DiscountAllow = Status
        cmdDiscount.Enabled = Status
        cmdSaleReturn.Enabled = Status
        cmdSave.Enabled = Status
        cmdSuspend.Enabled = Status
        cmdCreditSale.Enabled = Status
        cmdCustomer.Enabled = Status
    End Sub

    Private Sub CashSale(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim SaveQuery As String = String.Empty
        Call Get_Total()
        Dim DetailID As String = lblSequence.Text
        SaveQuery = "INSERT INTO SALE_MASTER VALUES ('" & _
                                             lblInvoice.Text.Trim & "'," & _
                                             Val(lblUserID.Text.Trim) & ",'" & _
                                             lblUserName.Text.Trim & "','" & _
                                             Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                             lblSaleType.Text.Trim & "','" & _
                                             lblSequence.Text.Trim & "','" & _
                                             Val(lblCustID.Text) & "','" & _
                                             lblCustName.Text.Trim & "'," & _
                                             Val(lblOrgPrice.Text.Trim) & "," & _
                                             Val(lblDiscount.Text.Trim) & "," & _
                                             Val(lblNetDues.Text.Trim) & "," & _
                                             gblPayment & "," & _
                                             gblRefund & "," & _
                                             "'CASH',0,0,0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "',0)"
        ProcessTransaction(SaveQuery)

        If SaleDataGrid.RowCount > -1 Then
            ProcessTransaction("delete from sale_detail_hold where detailid = '" & lblSequence.Text.Trim & "'")
            SortID = 1
            For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                Dim SaveItemQuery As String = "INSERT INTO SALE_DETAIL VALUES ('" & _
                                                     lblSequence.Text.Trim & "','" & _
                                                     Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                     lblInvoice.Text.Trim & "','" & _
                                                     lblSaleType.Text.Trim & "'," & _
                                                     Val(lblCustID.Text.Trim) & ",'" & _
                                                     lblCustName.Text.Trim & "','" & _
                                                     OutRow.Cells(0).Value.ToString & "','" & _
                                                     OutRow.Cells(1).Value.ToString & "','" & _
                                                     OutRow.Cells(2).Value.ToString & "'," & _
                                                     OutRow.Cells(3).Value.ToString & "," & _
                                                     Val(OutRow.Cells(4).Value.ToString) & "," & _
                                                     Val(OutRow.Cells(5).Value.ToString) & ",'CASH','" & _
                                                     lblUserID.Text.Trim & "',0,0,'" & _
                                                     OutRow.Cells(7).Value.ToString & "','" & _
                                                     OutRow.Cells(8).Value.ToString & "',0,'x'," & SortID & ",'" & _
                                                     OutRow.Cells(9).Value.ToString & "',0,'" & _
                                                     OutRow.Cells(10).Value.ToString & "')"
                ProcessTransaction(SaveItemQuery)
                SortID += 1
            Next OutRow
        End If
        LastSaleID = lblInvoice.Text.Trim
        Call UpdateStockQuantity()
        'Delete Hold Entries when saved
        ProcessTransaction("DELETE FROM SALE_MASTER_HOLD WHERE SALEID = N'" & LastSaleID & "'")
        ProcessTransaction("DELETE FROM SALE_DETAIL_HOLD WHERE SALEID = N'" & LastSaleID & "'")
        ProcessTransaction("DELETE FROM SALE_MASTER_TEMP WHERE SALEID = N'" & LastSaleID & "'")
        ProcessTransaction("DELETE FROM SALE_DETAIL_TEMP WHERE SALEID = N'" & LastSaleID & "'")
        SaleReturn = True
        cmdNew_Click(sender, e)
        txtCode.Focus()
    End Sub

    Private Sub SearchProduct()
        ProductSearch.ShowDialog()
        txtCode.Text = gblItemCode
        txtCode.Focus()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        ProductSearch.ShowDialog()
    End Sub

    Private Sub btnPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaid.Click
        BillPayment.ShowDialog()
        txtCode.Focus()
    End Sub

    Private Sub rbRetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRetail.Click
        txtCode.Focus()
    End Sub

    Private Sub rbWholeSale_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbWholeSale.Click
        txtCode.Focus()
    End Sub
#End Region
End Class