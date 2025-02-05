Imports System.Data.SqlClient
Imports System.IO

Public Class SaleInvoice
    Dim currentpath As String = Directory.GetCurrentDirectory()
    Dim ProductID As String = String.Empty
    Dim CreditBal, DebitBal As Double
    Dim ProductQty, FinalQty As Integer
    Dim drag, FoundItem, EditInvoiceMode, HoldReturn, AddRow As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim EditBindingSource As New BindingSource
    Dim EditDataSet As New DataSet
    Dim HoldDataAdapter As New SqlDataAdapter
    Dim Items, Clos_Balance, LastSaleID, HoldSaleInvoice, SaleType, SaleStatus As String
    Public Payment, FinalPayment, TotalQty, Dues, ProdPrice, Discount, NetTotal, NetAmount As Double
    Public SaleMode, ReturnMode, DiscountAllow, SaleReturn, SaleCredit, EditSale, PrintInvoice, generateInvoice As Boolean
    Dim SortID, NewQty, Max_ID, Q1, Q2 As Integer
    Dim ItemCodes As New List(Of String)()

    Private Sub SaleInvoice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then Me.Close()
        If e.KeyCode = Keys.F2 Then If SaleDataGrid.Rows.Count > -1 Then SaleDataGrid.Focus()
        If e.KeyCode = Keys.F4 Then ShowLastPurchase()
        If e.KeyCode = Keys.PageUp AndAlso e.Modifiers = Keys.Control Then DeleteItem()
        If e.KeyCode = Keys.End AndAlso e.Modifiers = Keys.Control Then SaveInvoice()
        If e.KeyCode = Keys.F5 Then CalculateFinalNet()
    End Sub

    Private Sub ShowLastPurchase()
        'Code Here
    End Sub

    Private Sub DeleteItem()
        'Code Here
        If SaleDataGrid.Rows.Count > -1 Then
            Dim rowIndex As Integer = SaleDataGrid.CurrentRow.Index
            SaleDataGrid.Rows.RemoveAt(rowIndex)
            Get_Total()
        End If
    End Sub

    Private Sub SaveInvoice()
        'Code Here
        If SaleDataGrid.Rows.Count > -1 Then
            If gblCashReceived = True Then
                Dim Dr As DialogResult = MessageBox.Show("Are you save the Invoice with Print. (Yes/No)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Dr = Windows.Forms.DialogResult.Yes Then PrintInvoice = True Else PrintInvoice = False
                If gblDues = 0 Then
                    'For Cash Invoice
                    If lblAreaName.Text = String.Empty Or lblRefer.Text = String.Empty Then MsgBox("Feilds should'nt be blank", MsgBoxStyle.Critical, "Message") : Exit Sub
                    If Val(txtCustID.Text) > 0 Then SaleType = "Cash Sale" : SaleStatus = "ACCOUNT" Else SaleType = "Walkin Customer" : SaleStatus = "CASH"
                    Dim SaveQuery As String = String.Empty
                    Dim DetailID As String = lblInvoice.Text & lblInvoiceDate.Text
                    If SaleDataGrid.RowCount > -1 Then
                        SaveQuery = "INSERT INTO SALE_MASTER VALUES ('" & _
                                                             lblInvoice.Text.Trim & "'," & _
                                                             gblPrliviges & ",'" & _
                                                             SysOperator.Trim & "','" & _
                                                             Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                             SaleType.Trim & "','" & _
                                                             DetailID.Trim & "','" & _
                                                             Val(txtCustID.Text) & "','" & _
                                                             lblCustomer.Text.Trim & "'," & _
                                                             Format(Val(lblInvoiceTotal.Text.Trim), "0.00") & "," & _
                                                             gblDiscount & "," & _
                                                             gblDues & "," & _
                                                             gblPayment & "," & _
                                                             gblRefund & ",'" & _
                                                             SaleStatus & "',0,0,0,'" & _
                                                             Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & _
                                                             "',0,'BILLED','" & _
                                                             lblRefer.Text & "')"
                        ProcessTransaction(SaveQuery)
                        ProcessTransaction("delete from sale_detail_hold where detailid = '" & DetailID & "'")
                        SortID = 1
                        For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                            Dim SaveItemQuery As String = "INSERT INTO SALE_DETAIL VALUES ('" & _
                                                                 DetailID.Trim & "','" & _
                                                                 Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                                 lblInvoice.Text.Trim & "','" & _
                                                                 SaleType.Trim & "'," & _
                                                                 Val(txtCustID.Text.Trim) & ",'" & _
                                                                 lblCustomer.Text.Trim & "'," & _
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
                                                                 "'x','" & _
                                                                 SortID & "','" & _
                                                                 lblRefer.Text & "')"
                            ProcessTransaction(SaveItemQuery)
                            SortID += 1
                        Next OutRow
                    End If
                    LastSaleID = lblInvoice.Text.Trim
                    Call UpdateStockQuantity()
                    SortID = 0
                    SaleReturn = True
                End If
                If gblDues > 0 Then
                    'For Credit Invoice
                    If lblAreaName.Text = String.Empty Or lblCustomer.Text = String.Empty Or lblRefer.Text = String.Empty Then MsgBox("Feilds should'nt be blank", MsgBoxStyle.Critical, "Message") : Exit Sub
                    If Val(txtCustID.Text) > 0 Then SaleType = "Cash Sale" : SaleStatus = "ACCOUNT" Else SaleType = "Walkin Customer" : SaleStatus = "CASH"
                    Dim SaveQuery As String = String.Empty
                    Dim DetailID As String = lblInvoice.Text & lblInvoiceDate.Text
                    If SaleDataGrid.RowCount > -1 Then
                        SaveQuery = "INSERT INTO SALE_MASTER VALUES ('" & _
                                                             lblInvoice.Text.Trim & "'," & _
                                                             gblPrliviges & ",'" & _
                                                             SysOperator.Trim & "','" & _
                                                             Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                             SaleType.Trim & "','" & _
                                                             DetailID.Trim & "','" & _
                                                             Val(txtCustID.Text) & "','" & _
                                                             lblCustomer.Text.Trim & "'," & _
                                                             Format(Val(lblInvoiceTotal.Text.Trim), "0.00") & "," & _
                                                             gblDiscount & "," & _
                                                             gblDues & "," & _
                                                             gblPayment & "," & _
                                                             gblRefund & ",'" & _
                                                             SaleStatus & "',0,0,0,'" & _
                                                             Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & _
                                                             "',0,'BILLED','" & _
                                                             lblRefer.Text & "')"
                        ProcessTransaction(SaveQuery)


                        ProcessTransaction("delete from sale_detail_hold where detailid = '" & DetailID & "'")
                        SortID = 1
                        For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                            Dim SaveItemQuery As String = "INSERT INTO SALE_DETAIL VALUES ('" & _
                                                                 DetailID.Trim & "','" & _
                                                                 Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                                 lblInvoice.Text.Trim & "','" & _
                                                                 SaleType.Trim & "'," & _
                                                                 Val(txtCustID.Text.Trim) & ",'" & _
                                                                 lblCustomer.Text.Trim & "'," & _
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
                                                                 "'x','" & _
                                                                 SortID & "','" & _
                                                                 lblRefer.Text & "')"
                            ProcessTransaction(SaveItemQuery)
                            SortID += 1
                        Next OutRow
                    End If
                    LastSaleID = lblInvoice.Text.Trim
                    If Val(gblPayment) > 0 Then Call LedgerDrTransaction(1, "SI-" & lblInvoice.Text, "PARTIAL PAYMENT", "DR", Val(gblPayment))
                    Call LedgerDrTransaction(Val(txtCustID.Text), "SI-" & lblInvoice.Text, "CREDIT SALE", "DR", gblDues)
                    If Val(gblDiscount) > 0 Then Call LedgerDrTransaction(3, "SI-" & lblInvoice.Text, "SALE DISCOUNT", "DR", Val(gblDiscount))
                    Call LedgerCrTransaction(2, "SI-" & lblInvoice.Text, "CREDIT SALE ( Acc #" & txtCustID.Text & " - " & lblCustomer.Text & ")", "CR", gblNet)
                    Call UpdateStockQuantity()
                    SortID = 0
                    SaleReturn = True
                End If
                'Delete Hold Entries when saved
                ProcessTransaction("DELETE FROM SALE_MASTER_HOLD WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_DETAIL_HOLD WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_MASTER_TEMP WHERE SALEID = N'" & LastSaleID & "'")
                ProcessTransaction("DELETE FROM SALE_DETAIL_TEMP WHERE SALEID = N'" & LastSaleID & "'")
                RefreshFields()
            End If
        Else
            MessageBox.Show("Invoice cannot be saved and print.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub CalculateFinalNet()
        gblPayment = 0
        PaymentBox.ShowDialog(Me)
        lblSave.Enabled = True
        If gblPayment > 0 Then lblNetBalance.Text = Val(lblNetTotal.Text) - gblPayment - gblDiff
    End Sub

    Private Sub SaleInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        GetConnectionString()
        lblInvoice.Text = gblInvPrefix & GetMax_ID(lblInvoice.Text)
        lblInvoiceDate.Text = Format(Now.Date, "MM/dd/yyyy")
        lblDarawer.Text = SysOperator
        AddRow = False
        NetTotal = 0
        SaleDataGrid.DefaultCellStyle.SelectionBackColor = Color.Gray
        SaleDataGrid.DefaultCellStyle.SelectionForeColor = Color.White
        lblRefer.Text = "Self"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub txtArea_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArea.GotFocus
        Get_Property_GotFocus(txtArea)
    End Sub

    Private Sub txtArea_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArea.KeyPress
        ValidateNumbersOnly(sender, e, txtArea)
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

    Private Sub txtArea_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtArea.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtArea.Text) > 0 Then
                Try
                    lblAreaName.Text = FieldInfo("select area_name from area where area_id = " & Val(txtArea.Text.Trim))
                    txtCustID.Focus()
                Catch ex As Exception
                    MessageBox.Show("Check data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
            Else
                HelpTable = "area"
                HelpF1 = "area_name"
                HelpF2 = "area_id"
                CodesHelp.ShowDialog(Me)
                txtArea.Text = gblCP_ID.Trim
                lblAreaName.Text = gblCP.Trim
                txtCustID.Focus()
            End If
        End If
    End Sub

    Private Function FieldInfo(ByVal Query As String) As String
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

    Private Function GetMax_ID(ByVal StringID As String) As Integer

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

    Private Sub txtCustID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtCustID.Text) < 8 And Val(txtCustID.Text) > 0 Then
                MessageBox.Show("Invalid customer id.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Len(txtCustID.Text) = 0 Then
                HelpTable = "accounts"
                HelpF1 = "acc_name"
                HelpF2 = "acc_no"
                CodesHelp.ShowDialog(Me)
                txtCustID.Text = gblCP_ID
            End If
            ExecuteAdapterQuery(SqlDataAdapter, "select * from accounts where acc_no = " & Val(txtCustID.Text), Connection)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    If IsDBNull(Reader.Item("acc_crlimit")) = False Then lblCrlimit.Text = Reader.Item("acc_crlimit")
                    If IsDBNull(Reader.Item("acc_name")) = False Then lblCustomer.Text = Reader.Item("acc_name")
                    If IsDBNull(Reader.Item("acc_crdays")) = False Then lblCrDays.Text = Reader.Item("acc_crdays")
                    If IsDBNull(Reader.Item("acc_phone")) = False Then lblPhone.Text = Reader.Item("acc_phone")
                    If IsDBNull(Reader.Item("acc_mobile")) = False Then lblMobile.Text = Reader.Item("acc_mobile")
                End While
            End If
            If Reader Is Nothing Then Reader.Close()
            txtRefer.Focus()
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
                CodesHelp.ShowDialog(Me)
                txtRefer.Text = gblCP_ID.Trim
                lblRefer.Text = gblCP.Trim
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
                    lblCompany.Text = ProductReader.Item("prod_supplr").ToString()
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
                txtDisc1.Focus()
            Else
                MsgBox("Please give valid quantity.")
                txtQty.Focus()
            End If
        End If
    End Sub

    Private Sub txtDisc2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDisc2.KeyDown
        If e.KeyCode = Keys.Enter Then
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
                                If Val(txtDisc2.Text) > Val(txtDisc1.Text) Then Discount = ((ProdPrice * Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString)) * Val(txtDisc2.Text)) / 100
                                If Val(txtDisc2.Text) < Val(txtDisc1.Text) Then Discount = ((ProdPrice * Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString)) * Val(txtDisc1.Text)) / 100
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
                                ProdPrice = Val(GetStockInfo.Item("prod_sale_price").ToString)
                                ItemRow.Cells(0).Value = GetStockInfo.Item("prod_code").ToString.ToUpper
                                ItemRow.Cells(1).Value = GetStockInfo.Item("prod_desc").ToString.ToUpper
                                ItemRow.Cells(2).Value = GetStockInfo.Item("prod_packing").ToString.ToUpper
                                ItemRow.Cells(3).Value = txtQty.Text.Trim.ToString()
                                ItemRow.Cells(4).Value = txtDisc1.Text.Trim.ToString()
                                ItemRow.Cells(5).Value = txtDisc2.Text.Trim.ToString()
                                If Val(txtDisc2.Text) > Val(txtDisc1.Text) Then Discount = ((ProdPrice * Val(txtQty.Text.Trim)) * Val(txtDisc2.Text)) / 100
                                If Val(txtDisc2.Text) < Val(txtDisc1.Text) Then Discount = ((ProdPrice * Val(txtQty.Text.Trim)) * Val(txtDisc1.Text)) / 100
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

    Private Sub txtArea_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArea.LostFocus
        Get_Property_LostFocus(txtArea)
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
            txtCode.Focus()
        End If
    End Sub

    Private Sub SaleDataGrid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaleDataGrid.LostFocus
        SaleDataGrid.DefaultCellStyle.SelectionBackColor = Color.Gray
        SaleDataGrid.DefaultCellStyle.SelectionForeColor = Color.White
    End Sub

    Private Sub UpdateStockQuantity()
        Dim SelectQty As String = "SELECT * FROM SALE_DETAIL WHERE SaleID = '" & LastSaleID & "'"
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                ProcessTransaction("update products set prod_stock = prod_stock - " & Val(Updater.Item("qty")) & " where prod_code = N'" & Updater.Item("StockID").ToString & "'")
                ProcessTransaction("update products set prod_units = prod_stock / prod_qty_per_unit where prod_code = N'" & Updater.Item("StockID").ToString & "'")
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
                    ProcessTransaction("update products set prod_units = prod_stock / prod_qty_per_unit where prod_code = N'" & Updater.Item("StockID").ToString & "'")
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

    Private Sub RefreshFields()
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
        lblInvoiceDate.Text = Format(Now.Date, "MM/dd/yyyy")
        txtCode.Clear()
        SortID = 1
        gblDiscount = 0
        gblPayment = 0
        gblNet = 0
        lblCustomer.Text = String.Empty
        lblTotItems.Text = "0"
        txtQty.Text = "1"
        gblPayment = 0
        gblDiscount = 0
        gblDues = 0
        gblNet = 0
        gblDiff = 0
        SaleType = "Walkin Customer"
        lblCustomer.Text = "No Customer Selected"
        lblInvoice.Text = gblInvPrefix & GetMax_ID(lblInvoice.Text)
        'Call Get_Total()
        'Call CountHoldSale()
        'Call Set_Enable_Disable(False)
        txtCode.Focus()
        txtCode.Focus()
        SaleMode = False
        'rbRetail.Checked = True
        'rbWholeSale.Checked = False
        EditInvoiceMode = False
        HoldReturn = False
        HoldSaleInvoice = String.Empty
        lblRefer.Text = "Self"
        PrintInvoice = False
    End Sub

    Private Sub txtCustID_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustID.KeyUp
        If e.KeyCode = Keys.Escape Then
            txtRefer.Focus()
        End If
    End Sub

    Private Sub LedgerDrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)

        SortID += 1
        Call Get_Account_Parameters(AccID)
        'Call Get_Ledger_Parameters(AccID)
        Dim strDate As DateTime = DateTime.Now
        strDate = lblInvoiceDate.Text.ToString
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
                         Amount + LedgBal & "," & _
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
        strDate = lblInvoiceDate.Text.ToString
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
                         Amount + LedgBal & "," & _
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        Dim UpdateAccount As String = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub

    Private Sub SaleDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SaleDataGrid.CellContentClick
        If SaleDataGrid.Enabled = True Then
            SaleDataGrid.Rows.RemoveAt(e.RowIndex)
            Get_Total()
            txtCode.Focus()
        End If
    End Sub
End Class