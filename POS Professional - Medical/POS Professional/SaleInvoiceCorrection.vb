Imports System.Data.SqlClient
Imports System.IO

Public Class SaleInvoiceCorrection
    Dim currentpath As String = Directory.GetCurrentDirectory()
    Dim ProductID As String = String.Empty
    Dim CreditBal, DebitBal, ClosBalance As Double
    Dim ProductQty, FinalQty, TotItems As Integer
    Dim FoundItem, EditInvoiceMode, HoldReturn, AddRow As Boolean
    Dim EditBindingSource As New BindingSource
    Dim EditDataSet As New DataSet()
    Dim HoldDataAdapter As New SqlDataAdapter()
    Dim SearchAdapter As New SqlDataAdapter()
    Dim SearchDataSet As New DataSet()
    Dim Items, Clos_Balance, LastSaleID, HoldSaleInvoice, SaleType, SaleStatus, BillMode, AccountMode, CustomerName, UpdateAccount As String
    Public Payment, FinalPayment, TotalQty, Dues, ProdPrice, Discount, NetTotal, NetAmount, SaleChange, OldBalance, wGross, wDiscount, wTotal, wPaid, wAccID As Double
    Public SaleMode, ReturnMode, DiscountAllow, SaleReturn, SaleCredit, EditSale, PrintInvoice, generateInvoice As Boolean
    Dim SortID, NewQty, Max_ID, Q1, Q2 As Integer

    Private Sub SaleInvoiceCorrection_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCustID.Focus()
    End Sub

    Private Sub SaleInvoiceCorrection_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then Me.Close()
        If e.KeyCode = Keys.F2 Then If SaleDataGrid.Rows.Count > -1 Then SaleDataGrid.Focus()
        If e.KeyCode = Keys.F5 Then If lblNet.Enabled = True Then CalculateFinalNet()
        If e.KeyCode = Keys.F6 Then SearchInvoiceHelp()
        If e.KeyCode = Keys.F11 Then RefreshFields()
        If e.KeyCode = Keys.Delete Then If lblDelete.Enabled = True Then DeleteItem()
        If e.KeyCode = Keys.End AndAlso e.Modifiers = Keys.Control Then If lblSave.Enabled = True Then SaveInvoice()
    End Sub

    Private Sub SearchInvoiceHelp()
        gblQuery = "select saleid, salepaid from sale_master where drawerid = " & DrawerID & " and status = 'PAID' order by saleid"
        SearchInvoice.ShowDialog(Me)
        If lblInvoice.Text <> gblCP_ID Then RefreshFields() : ShowSaleInvoice() Else MessageBox.Show("Invoice already displayed.", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowSaleInvoice()
        'Invoice Basic
        TotItems = 0
        wGross = 0
        wTotal = 0
        wDiscount = 0
        wPaid = 0
        'If lblInvoice.Text = gblCP_ID Then MessageBox.Show("Invoice already searched.", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        ExecuteAdapterQuery(SqlDataAdapter, "select * from sale_master where saleid = '" & gblCP_ID & "'", Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                'Code Here
                lblInvoice.Text = Reader.Item("saleid").ToString()
                lblInvoiceDate.Text = Reader.Item("datecompleted").ToString()
                txtCustomerName.Text = Reader.Item("customername").ToString()
                txtCustID.Text = Reader.Item("customerid").ToString()
                lblCustomer.Text = Reader.Item("customername").ToString()
                lblRefer.Text = Reader.Item("refer").ToString()
                'Old Values if case of change
                wGross = Val(Reader.Item("salegross").ToString())
                wDiscount = Val(Reader.Item("salediscount").ToString())
                wTotal = Val(Reader.Item("saletotal").ToString())
                wPaid = Val(Reader.Item("salepaid").ToString())
                wAccID = Val(Reader.Item("customerid").ToString())
            End While
            Panel1.Enabled = True
            If Reader Is Nothing Then Reader.Close()
        Else
            MsgBox("Invoice not found, Try again.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Panel1.Enabled = False
            Exit Sub
        End If
        'Invoice Details
        ExecuteAdapterQuery(SearchAdapter, "select * from sale_detail where saleid = '" & gblCP_ID & "'", Connection)
        Dim DetailReader As SqlDataReader = SearchAdapter.SelectCommand.ExecuteReader
        If DetailReader.HasRows Then
            While DetailReader.Read
                Dim RowIndex As Integer = SaleDataGrid.Rows.Add()
                Dim ItemRow As DataGridViewRow = SaleDataGrid.Rows(RowIndex)
                ItemRow.Cells(0).Value = DetailReader.Item(6).ToString()
                ItemRow.Cells(1).Value = DetailReader.Item(7).ToString()
                ItemRow.Cells(2).Value = DetailReader.Item(8).ToString()
                ItemRow.Cells(3).Value = DetailReader.Item(9).ToString()
                ItemRow.Cells(4).Value = DetailReader.Item(10).ToString()
                ItemRow.Cells(5).Value = DetailReader.Item(11).ToString()
                ItemRow.Cells(6).Value = DetailReader.Item(12).ToString()
                ItemRow.Cells(7).Value = DetailReader.Item(13).ToString()
                ItemRow.Cells(8).Value = DetailReader.Item(14).ToString()
                ItemRow.Cells(9).Value = "X"
                txtRefer.Text = DetailReader.Item("referid").ToString()
                SaleMode = True
                TotItems += 1
            End While
            If DetailReader Is Nothing Then DetailReader.Close()
        End If
        Get_Total()
        lblTotItems.Text = TotItems
        SaleReturn = False
        SaleMode = True
        lblDelete.Enabled = True
        SaleDataGrid.Enabled = True
        lblNet.Enabled = True
        gblCP = String.Empty
        gblCP_ID = 0
        txtCustID.Focus()
    End Sub

    Private Sub ShowLastPurchase()
        'Code Here
    End Sub

    Private Sub DeleteItem()
        'Code Here
        If SaleDataGrid.Rows.Count > -1 Then
            Dim rowIndex As Integer = SaleDataGrid.CurrentRow.Index
            SaleDataGrid.Rows.RemoveAt(rowIndex)
            lblTotItems.Text = Val(lblTotItems.Text) - 1
            Get_Total()
        End If
    End Sub

    Private Sub SaveInvoice()
        If AccountMode = "CUSTOMER" Or Val(txtCustID.Text) = 1 Then generateInvoice = True Else generateInvoice = False
        If gblDues > 0 And Val(txtCustID.Text) = 1 Then MsgBox("credit cannot be save to cash account.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Message") : Exit Sub
        If gblDues > 0 And gblPrliviges = 1 Then
            Dim dr As DialogResult = MessageBox.Show("Save with credit amount. (Yes/No)", "Save Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dr = Windows.Forms.DialogResult.Yes Then
                If gblPayment > 0 Then BillMode = "PARTIAL" Else BillMode = "CREDIT"
                generateInvoice = True
            Else
                generateInvoice = False
            End If
        End If
        SaveCustomerInvoice()
    End Sub

    'Invoice Procedure
    Private Sub SaveCustomerInvoice()
        If generateInvoice = True Then
            If SaleDataGrid.Rows.Count > -1 Then
                Dim Dr As DialogResult = MessageBox.Show("Save the Invoice with Print. (Yes / No)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If CustomerName.ToUpper.IndexOf("X") > -1 Or CustomerName = String.Empty Then CustomerName = lblCustomer.Text
                If Dr = Windows.Forms.DialogResult.Yes Then PrintInvoice = True Else PrintInvoice = False
                If lblRefer.Text = String.Empty Then lblRefer.Text = "Self"
                If AccountMode = "CUSTOMER" Then SaleType = "CASH SALE" : SaleStatus = "ACCOUNT" Else SaleType = "WALKIN CUSTOMER" : SaleStatus = "CASH"
                If gblDues > 0 Then SaleType = "CREDIT SALE"
                Dim SaveQuery As String = String.Empty
                Dim DetailID As String = lblInvoice.Text & Format(DateTime.Parse(lblInvoiceDate.Text), "ddMMyyyy")
                UpdateReturnStockQuantity(lblInvoice.Text)
                'For deletion of previous stock
                UpdateReturnStockQuantity(lblInvoice.Text)
                ProcessTransaction("delete from sale_detail where saleid = '" & lblInvoice.Text & "'")
                'Save changes
                If SaleDataGrid.RowCount > -1 Then
                    SaveQuery = "UPDATE SALE_MASTER SET " & _
                                "drawerid = " & DrawerID & "," & _
                                "drawername = '" & SysOperator.Trim & "'," & _
                                "datecompleted = '" & Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                "saletype = '" & SaleType.Trim & "'," & _
                                "offlineid = '" & DetailID.Trim & "'," & _
                                "customerid = " & Val(txtCustID.Text) & "," & _
                                "customername = '" & CustomerName.ToUpper & "'," & _
                                "salegross = " & Format(Val(lblInvoiceTotal.Text.Trim) + gblDiscount, "0.00") & "," & _
                                "salediscount = " & gblDiscount & "," & _
                                "saletotal = " & gblNet & "," & _
                                "salepaid = " & gblPayment & "," & _
                                "salechange = 0" & "," & _
                                "salestatus = '" & SaleStatus & "'," & _
                                "salecredit = " & gblDues & "," & _
                                "salereturn = 0," & _
                                "salerecovery = 0," & _
                                "daterecovery = '" & Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                "refer = '" & lblRefer.Text & "'," & _
                                "areaid = 0," & _
                                "areaname = 'X' where saleid = '" & lblInvoice.Text & "'"
                    ProcessTransaction(SaveQuery)
                    ProcessTransaction("delete from sale_detail_hold where saleid = '" & lblInvoice.Text & "'")
                    ProcessTransaction("delete from sale_detail where saleid = '" & lblInvoice.Text & "'")
                    SortID = 1
                    For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                        Dim SaveItemQuery As String = "INSERT INTO SALE_DETAIL VALUES ('" & _
                                                             DetailID.Trim & "','" & _
                                                             Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                             lblInvoice.Text.Trim & "','" & _
                                                             SaleType.Trim & "'," & _
                                                             Val(txtCustID.Text.Trim) & ",'" & _
                                                             CustomerName.ToUpper & "'," & _
                                                             Val(OutRow.Cells(0).Value.ToString) & ",'" & _
                                                             OutRow.Cells(1).Value.ToString & "','" & _
                                                             OutRow.Cells(2).Value.ToString & "','" & _
                                                             Val(OutRow.Cells(3).Value.ToString) & "'," & _
                                                             Val(OutRow.Cells(4).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(5).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(6).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(7).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(8).Value.ToString) & ",'" & _
                                                             SaleStatus & "','" & _
                                                             SysOperator.Trim & "'," & _
                                                             "0" & "," & _
                                                             "'X','" & _
                                                             SortID & "','" & _
                                                             lblRefer.Text & "'," & _
                                                             Val(txtRefer.Text) & ")"
                        ProcessTransaction(SaveItemQuery)
                        SortID += 1
                    Next OutRow
                End If
                SortID = 0
                SaleReturn = True
                LastSaleID = lblInvoice.Text.Trim
                UpdateStockQuantity(lblInvoice.Text)
                'Ledger Entries
                'if invoice on cash basis
                If wGross > Val(lblInvoiceTotal.Text) Then LedgerDrTransaction(2, "SI-" & lblInvoice.Text, "CORRECTION IN SALE", "DR", wGross - Val(lblInvoiceTotal.Text.Trim))
                If wDiscount > Val(gblDiscount) Then LedgerCrTransaction(3, "SI-" & lblInvoice.Text, "CORRECTION IN DISCOUNT", "CR", wDiscount - gblDiscount)
                If wPaid > gblPayment And wAccID = Val(txtCustID.Text) Then LedgerCrTransaction(Val(txtCustID.Text), "SI-" & lblInvoice.Text, "CORRECTION IN PAYMENT", "CR", wPaid - gblPayment)

                If wGross < Val(lblInvoiceTotal.Text) Then LedgerCrTransaction(2, "SI-" & lblInvoice.Text, "CORRECTION IN SALE", "CR", Val(lblInvoiceTotal.Text.Trim) - wGross)
                If wDiscount < Val(gblDiscount) Then LedgerDrTransaction(3, "SI-" & lblInvoice.Text, "CORRECTION IN DISCOUNT", "DR", gblDiscount - wDiscount)
                If wPaid < gblPayment Then LedgerDrTransaction(Val(txtCustID.Text), "SI-" & lblInvoice.Text, "CORRECTION IN PAYMENT", "DR", gblPayment - wPaid)

                'Delete Hold Entries when saved
                ProcessTransaction("DELETE FROM SALE_MASTER_HOLD WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_DETAIL_HOLD WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_MASTER_TEMP WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_DETAIL_TEMP WHERE SALEID = N'" & LastSaleID & "'")
                RefreshFields()
                Panel1.Enabled = False
            End If
        Else
            MessageBox.Show("Invoice cannot be saved and print.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub CalculateFinalNet()
        gblPayment = 0
        OldBalance = Convert.ToDecimal(lblOldBalance.Text)
        PaymentBox.ShowDialog(Me)
        If gblPayment > 0 Or gblDues > 0 Then lblNetBalance.Text = Format(Val(lblNetTotal.Text) - gblPayment - gblDiff, "0.00") : lblSave.Enabled = True
        lblNetTotal.Text = Format(Val(lblInvoiceTotal.Text) - gblDiscount, "0.00")
    End Sub

    Private Sub SaleInvoiceCorrection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Enabled = False
        Timer1.Start()
        GetConnectionString()
        AddRow = False
        NetTotal = 0
        SaleDataGrid.DefaultCellStyle.SelectionBackColor = Color.Gray
        SaleDataGrid.DefaultCellStyle.SelectionForeColor = Color.White
        CustomerName = String.Empty
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub txtCustomerName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.GotFocus
        Get_Property_GotFocus(txtCustomerName)
    End Sub

    Private Sub txtCustID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustID.GotFocus
        Get_Property_GotFocus(txtCustID)
    End Sub

    Private Sub txtCustID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustID.KeyPress
        ValidateNumbersOnly(sender, e, txtCustID)
    End Sub

    Private Sub txtRefer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefer.GotFocus
        Get_Property_GotFocus(txtRefer)
    End Sub

    Private Sub txtRefer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefer.KeyPress
        ValidateNumbersOnly(sender, e, txtRefer)
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        ValidateNumbersOnly(sender, e, txtCode)
    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        Get_Property_GotFocus(txtQty)
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        ValidateNumbersOnly(sender, e, txtQty)
    End Sub

    Private Sub txtDisc1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc1.GotFocus
        Get_Property_GotFocus(txtDisc1)
    End Sub

    Private Sub txtDisc1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisc1.KeyPress
        ValidateNumbersOnly(sender, e, txtDisc1)
    End Sub

    Private Sub txtDisc2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc2.GotFocus
        Get_Property_GotFocus(txtDisc2)
    End Sub

    Private Sub txtDisc2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisc2.KeyPress
        ValidateNumbersOnly(sender, e, txtDisc2)
    End Sub

    Private Sub txtCustmerName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomerName.KeyDown
        If e.KeyCode = Keys.Enter Then
            CustomerName = txtCustomerName.Text
            txtRefer.Focus()
        End If
    End Sub

    Public Function FieldInfo(ByVal Query As String) As String
        Dim Info As String = String.Empty
        ExecuteAdapterQuery(SqlDataAdapter, Query, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                Info = Reader.Item(0).ToString()
            End While
        End If
        If Reader Is Nothing Then Reader.Close()
        Return Info
    End Function

    Private Sub txtCustID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtCustID.Text) < 8 And Val(txtCustID.Text) > 1 Then
                MessageBox.Show("Invalid customer id.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Len(txtCustID.Text) = 0 Then
                HelpTable = "accounts"
                HelpF1 = "acc_name"
                HelpF2 = "acc_no"
                gblCP = String.Empty
                gblCP_ID = 0
                CodesHelp.ShowDialog(Me)
                txtCustID.Text = gblCP_ID
            End If
            ExecuteAdapterQuery(SqlDataAdapter, "select * from accounts where acc_no = " & Val(txtCustID.Text), Connection)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    If IsDBNull(Reader.Item("acc_crlimit")) = False Then lblCrlimit.Text = Reader.Item("acc_crlimit") Else lblCrlimit.Text = 0
                    If Val(txtCustID.Text) > 1 Then
                        If IsDBNull(Reader.Item("acc_balance")) = False Then lblOldBalance.Text = Reader.Item("acc_balance") Else lblOldBalance.Text = 0
                    End If
                    If IsDBNull(Reader.Item("acc_name")) = False Then lblCustomer.Text = Reader.Item("acc_name") Else lblCustomer.Text = "CASH"
                    If IsDBNull(Reader.Item("acc_crdays")) = False Then lblCrDays.Text = Reader.Item("acc_crdays") Else lblCrDays.Text = 0
                    If IsDBNull(Reader.Item("acc_phone")) = False Then lblPhone.Text = Reader.Item("acc_phone") Else lblPhone.Text = "X"
                    If IsDBNull(Reader.Item("acc_mobile")) = False Then lblMobile.Text = Reader.Item("acc_mobile") Else lblMobile.Text = "X"
                    AccountMode = Reader.Item("acc_reg_type").ToString()
                End While
            End If
            If Reader Is Nothing Then Reader.Close()
            txtCustomerName.Focus()
        End If
    End Sub

    Private Sub txtRefer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtRefer.Text) > 0 Then
                Try
                    lblRefer.Text = FieldInfo("select cp_name from collectionpoint where cp_id = " & Val(txtRefer.Text.Trim))
                Catch ex As Exception
                    MessageBox.Show("Check data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
            Else
                HelpTable = "collectionpoint"
                HelpF1 = "cp_name"
                HelpF2 = "cp_id"
                gblCP = String.Empty
                gblCP_ID = 0
                CodesHelp.ShowDialog(Me)
                If Val(gblCP_ID) > 0 Then
                    txtRefer.Text = gblCP_ID.Trim
                    lblRefer.Text = gblCP.Trim
                Else
                    lblRefer.Text = "Self"
                End If
            End If
            If Len(lblRefer.Text) > 0 Then
                Panel2.Enabled = True
                txtCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtCode.Text) = 0 Then
                gblCP = String.Empty
                gblCP_ID = 0
                ProductHelp.ShowDialog(Me)
                If Len(gblCP_ID) > 0 Then txtCode.Text = gblCP_ID.Trim
            End If
            ExecuteAdapterQuery(SqlDataAdapter, "select * from products where prod_code = " & Val(txtCode.Text), Connection)
            Dim ProductReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If ProductReader.HasRows Then
                While ProductReader.Read
                    lblItemName.Text = ProductReader.Item("prod_desc").ToString()
                    txtDisc1.Text = ProductReader.Item("prod_disc_allow").ToString()
                    lblTradePrice.Text = ProductReader.Item("prod_purch_price").ToString()
                    lblRetail.Text = ProductReader.Item("prod_wsale_price").ToString()
                    lblCompany.Text = ProductReader.Item("prod_company").ToString()
                    lblStock.Text = ProductReader.Item("prod_stock").ToString()
                End While
                txtQty.Focus()
            End If
            If ProductReader Is Nothing Then ProductReader.Close()
        End If
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtQty.Text) > 0 Then
                txtDisc2.Focus()
            Else
                MsgBox("Please give valid quantity.")
                txtQty.Focus()
            End If
        End If
    End Sub

    Private Sub txtDisc2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDisc2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim PackSize As Integer = 0
            If Val(txtDisc2.Text) > Val(txtDisc1.Text) Then
                Dim response As DialogResult = MessageBox.Show("You are selling product with loss. continue (y/n)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = Windows.Forms.DialogResult.Yes Then
                    AddRow = True
                Else
                    AddRow = False
                End If
            End If
            If Val(txtDisc2.Text) <= Val(txtDisc1.Text) Then
                AddRow = True
            End If
            If Len(txtDisc2.Text) = 0 Or txtDisc2.Text = String.Empty Then txtDisc2.Text = "0"
            If AddRow = True Then
                'After Confirmation of Message
                If txtQty.Text = String.Empty Or Val(txtQty.Text.Trim) = 0 Then txtQty.Text = 1 Else txtQty.Text = txtQty.Text.Trim
                If e.KeyCode = Keys.Enter Then
                    FoundItem = False
                    'Update item quantity if same item enter again in product code textbox
                    If SaleDataGrid.RowCount > -1 Then
                        For Each row As DataGridViewRow In SaleDataGrid.Rows
                            If row.Cells(0).Value.ToString.ToUpper = txtCode.Text.Trim Then
                                SaleDataGrid.Rows(row.Index).Selected = True
                                ProdPrice = Val(SaleDataGrid.Rows(row.Index).Cells(6).Value.ToString)
                                SaleDataGrid.Rows(row.Index).Cells(3).Value = Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString) + Val(txtQty.Text.Trim)
                                If Val(txtDisc2.Text) > Val(txtDisc1.Text) Then Discount = Format(((ProdPrice * Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString)) * Val(txtDisc2.Text)) / 100, "0.00")
                                If Val(txtDisc2.Text) < Val(txtDisc1.Text) Then Discount = Format(((ProdPrice * Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString)) * Val(txtDisc1.Text)) / 100, "0.00")
                                NetAmount = (ProdPrice * Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString)) - Discount
                                SaleDataGrid.Rows(row.Index).Cells(7).Value = Discount
                                SaleDataGrid.Rows(row.Index).Cells(8).Value = NetAmount
                                gblDiscount += Discount
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
                            'Add Item into SaleDataGrid
                            If FoundItem = False Then
                                Dim RowIndex As Integer = SaleDataGrid.Rows.Add()
                                Dim ItemRow As DataGridViewRow = SaleDataGrid.Rows(RowIndex)
                                'If rbRetail.Checked = True Then ProdPrice = Val(GetStockInfo.Item("prod_sale_price").ToString)
                                'If rbWholeSale.Checked = True Then ProdPrice = Val(GetStockInfo.Item("prod_wsale_price").ToString)
                                PackSize = Val(GetStockInfo.Item("prod_pack_conversion").ToString)
                                ProdPrice = Format(Val(GetStockInfo.Item("prod_sale_price").ToString) / PackSize, "0.00")
                                ItemRow.Cells(0).Value = GetStockInfo.Item("prod_code").ToString.ToUpper
                                ItemRow.Cells(1).Value = GetStockInfo.Item("prod_desc").ToString.ToUpper
                                ItemRow.Cells(2).Value = GetStockInfo.Item("prod_packing").ToString.ToUpper
                                ItemRow.Cells(3).Value = txtQty.Text.Trim.ToString()
                                ItemRow.Cells(4).Value = txtDisc1.Text.Trim.ToString()
                                ItemRow.Cells(5).Value = txtDisc2.Text.Trim.ToString()
                                If Val(txtDisc2.Text) > Val(txtDisc1.Text) Then Discount = Format(((ProdPrice * Val(txtQty.Text.Trim)) * Val(txtDisc2.Text)) / 100, "0.00")
                                If Val(txtDisc2.Text) < Val(txtDisc1.Text) Then Discount = Format(((ProdPrice * Val(txtQty.Text.Trim)) * Val(txtDisc1.Text)) / 100, "0.00")
                                NetAmount = (ProdPrice * Val(txtQty.Text.Trim)) - Discount
                                gblDiscount += Discount
                                ItemRow.Cells(6).Value = ProdPrice
                                ItemRow.Cells(7).Value = Discount
                                ItemRow.Cells(8).Value = NetAmount
                                ItemRow.Cells(9).Value = "X"
                                SaleMode = True
                            End If
                            'lblMode.Text = "Sale"
                            Call Get_Total()
                            'Call lblTotalPrice_Validated(sender, e)
                            'Call lblShowDiscount_Validated(sender, e)
                            SaleReturn = False
                            SaleMode = True
                            lblDelete.Enabled = True
                            SaleDataGrid.Enabled = True
                            lblNet.Enabled = True
                            'Call Set_Enable_Disable(True)
                            'cmdFind.Enabled = False
                            'btnPaid.Enabled = False
                            If EditInvoiceMode = True Then CreditBal += ProdPrice
                        End While
                        If GetStockInfo Is Nothing Then GetStockInfo.Close()
                        txtDisc1.Clear()
                        txtDisc2.Clear()
                        txtCode.Clear()
                        txtCode.Focus()
                        txtQty.Text = "1"
                    Else
                        gblMessage = "Prodcut not available, Please check Stock."
                        MsgStatus.ShowDialog(Me)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Get_Total()
        If SaleDataGrid.RowCount > -1 Then
            Dim TotalAmount As Double = 0.0
            lblTotItems.Text = 0
            For Each row As DataGridViewRow In SaleDataGrid.Rows
                TotalAmount += Format(Val(row.Cells(8).Value.ToString.Trim), "0.00")
                'gblNet += Format(Val(row.Cells(6).Value.ToString.Trim), "0.00")
                lblTotItems.Text = Val(lblTotItems.Text) + 1
            Next
            lblInvoiceTotal.Text = Format(TotalAmount, "0.00")
            lblNetTotal.Text = Format(TotalAmount + Val(lblOldBalance.Text.Trim), "0.00")
            gblNet = TotalAmount
            lblNetBalance.Text = Format(Val(lblNetTotal.Text) - gblPayment, "0.00")
        End If
    End Sub

    Private Sub txtCustomerName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerName.LostFocus
        CustomerName = txtCustomerName.Text
        Get_Property_LostFocus(txtCustomerName)
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Get_Property_LostFocus(txtCode)
    End Sub

    Private Sub txtCustID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustID.LostFocus
        Get_Property_LostFocus(txtCustID)
    End Sub

    Private Sub txtDisc1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc1.LostFocus
        Get_Property_LostFocus(txtDisc1)
    End Sub

    Private Sub txtDisc2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDisc2.LostFocus
        Get_Property_LostFocus(txtDisc2)
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        Get_Property_LostFocus(txtQty)
    End Sub

    Private Sub txtRefer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefer.LostFocus
        Get_Property_LostFocus(txtRefer)
    End Sub

    Private Sub SaleDataGrid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaleDataGrid.GotFocus
        SaleDataGrid.DefaultCellStyle.SelectionBackColor = Color.IndianRed
        SaleDataGrid.DefaultCellStyle.SelectionForeColor = Color.Yellow
    End Sub

    Private Sub SaleDataGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SaleDataGrid.KeyUp
        If e.KeyCode = Keys.Escape Then
            Panel2.Enabled = True
            Panel1.Enabled = True
            txtCode.Focus()
        End If
    End Sub

    Private Sub SaleDataGrid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaleDataGrid.LostFocus
        SaleDataGrid.DefaultCellStyle.SelectionBackColor = Color.Gray
        SaleDataGrid.DefaultCellStyle.SelectionForeColor = Color.White
    End Sub

    Private Sub UpdateReturnStockQuantity(ByVal InvoiceNo As String)
        Dim SelectQty As String = "SELECT * FROM SALE_DETAIL WHERE SaleID = '" & LastSaleID & "'"
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                ProcessTransaction("update products set prod_stock = prod_stock + " & Val(Updater.Item("qty")) & " where prod_code = N'" & Updater.Item("StockID").ToString & "'")
            End While
            If Updater Is Nothing Then Updater.Close()
        End If
    End Sub

    Private Sub UpdateStockQuantity(ByVal InvoiceNo As String)
        Dim SelectQty As String = "SELECT * FROM SALE_DETAIL WHERE SaleID = '" & InvoiceNo & "'"
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                ProcessTransaction("update products set prod_stock = prod_stock - " & Val(Updater.Item("qty")) & " where prod_code = N'" & Updater.Item("StockID").ToString & "'")
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

    Private Sub RefreshFields()
        If Me.SaleDataGrid.Rows.Count > -1 Then
            For i As Integer = Me.SaleDataGrid.Rows.Count - 1 To 0 Step -1
                Me.SaleDataGrid.Rows.RemoveAt(i)
            Next
        End If
        txtCode.Clear()
        SortID = 0
        gblDiscount = 0
        gblPayment = 0
        gblNet = 0
        txtQty.Text = "1"
        gblPayment = 0
        gblDiscount = 0
        gblDues = 0
        gblNet = 0
        gblDiff = 0
        lblCustomer.Text = String.Empty
        txtCode.Focus()
        txtCode.Focus()
        SaleMode = False
        EditInvoiceMode = False
        txtCustID.Text = 1
        lblCrlimit.Text = 0
        lblCrDays.Text = 0
        txtRefer.Text = String.Empty
        lblTotItems.Text = String.Empty
        lblItemName.Text = String.Empty
        lblPhone.Text = String.Empty
        lblMobile.Text = String.Empty
        PrintInvoice = False
        lblCompany.Text = String.Empty
        lblStock.Text = 0
        lblTradePrice.Text = 0
        lblRetail.Text = 0
        lblInvoiceTotal.Text = 0
        lblOldBalance.Text = 0
        lblNetTotal.Text = 0
        lblNetBalance.Text = 0
        lblSave.Enabled = False
        lblDelete.Enabled = False
        lblNet.Enabled = False
        txtCustomerName.Clear()
        lblInvoice.Text = String.Empty
        Panel1.Enabled = False
        lblItemName.Text = String.Empty
        lblCompany.Text = String.Empty
        lblTradePrice.Text = String.Empty
        lblStock.Text = String.Empty
        lblInvoiceDate.Text = String.Empty
        lblRefer.Text = String.Empty
        lblRetail.Text = String.Empty
    End Sub

    Private Sub txtCustID_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustID.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtRefer.Focus()
        End If
    End Sub

    Public Sub LedgerDrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)
        SortID += 1
        ClosBalance = 0
        Call Get_Account_Parameters(AccID)
        If gblAccType = "DR" Then ClosBalance = gblLedgBal + Amount
        If gblAccType = "CR" Then ClosBalance = gblLedgBal - Amount
        Dim strDate As DateTime = DateTime.Now
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

    Public Sub LedgerCrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)
        SortID += 1
        ClosBalance = 0
        Call Get_Account_Parameters(AccID)
        If gblAccType = "CR" Then ClosBalance = gblLedgBal + Amount
        If gblAccType = "DR" Then ClosBalance = gblLedgBal - Amount
        Dim strDate As DateTime = DateTime.Now
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

    Private Sub SaleDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SaleDataGrid.CellContentClick
        If SaleDataGrid.Enabled = True Then
            SaleDataGrid.Rows.RemoveAt(e.RowIndex)
            Get_Total()
        End If
    End Sub

End Class