Imports System.IO
Imports System.Data.SqlClient

Public Class PurchaseInvoice
    Dim currentpath As String = Directory.GetCurrentDirectory()
    Dim ProductID As String = String.Empty
    Dim CreditBal, DebitBal As Double
    Dim ProductQty, FinalQty As Integer
    Dim drag, FoundItem, EditInvoiceMode, HoldReturn, AddRow As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim EditBindingSource As New BindingSource
    Dim EditDataSet As New DataSet
    Dim InfoDataAdapter As New SqlDataAdapter
    Dim Items, Clos_Balance, LastPrchID, HoldPurchInvoice, PurchaseType, PurchaseStatus As String
    Public Payment, FinalPayment, TotalQty, Dues, ProdPrice, Discount, NetTotal, NetAmount As Double
    Public PrchMode, ReturnMode, DiscountAllow, PrchReturn, PrchCredit, EditPurchase, PrintInvoice, generateInvoice As Boolean
    Dim SortID, NewQty, Max_ID, Q1, Q2 As Integer
    Dim ItemCodes As New List(Of String)()

    Private Sub PurchaseInvoice_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSuplCode.Focus()
    End Sub

    Private Sub PurchaseInvoice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then Me.Close()
        If e.KeyCode = Keys.F2 Then If SaleDataGrid.Rows.Count > -1 Then SaleDataGrid.Focus()
        If e.KeyCode = Keys.PageUp AndAlso e.Modifiers = Keys.Control Then DeleteItem()
        If e.KeyCode = Keys.F4 Then ShowLastRate()
        If e.KeyCode = Keys.PageDown AndAlso e.Modifiers = Keys.Control Then ItemRegistration.MdiParent = Main : ItemRegistration.Show()
        If e.KeyCode = Keys.End AndAlso e.Modifiers = Keys.Control Then SaveInvoice()
        If e.KeyCode = Keys.F5 Then txtDiscount.Focus()
    End Sub

    Private Sub ShowLastRate()
        ExecuteAdapterQuery(SqlDataAdapter, "select prod_purch_price, prod_wsale_price, prod_sale_price from products where prod_code = " & Val(txtCode.Text), Connection)
        Dim StringTP, StringWP, StringSP As String
        Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                StringTP = reader.Item("prod_purch_price").ToString()
                StringWP = reader.Item("prod_wsale_price").ToString()
                StringSP = reader.Item("prod_sale_price").ToString()
            End While
            MsgBox("Last Rate of Product" & vbNewLine & StrDup(50, "-") & vbCrLf & _
                   "Trade Price  : " & StringTP & vbCrLf & _
                   "Retail Price  : " & StringWP & vbCrLf & _
                   "Sale Price     : " & StringSP, MsgBoxStyle.Information, "Item Rate")
        End If
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
            If txtCashPaid.Text <> String.Empty Then
                'For Purchase Invoice
                Dim SaveQuery As String = String.Empty
                Dim DetailID As String = lblInvoice.Text & lblInvoiceDate.Text
                If SaleDataGrid.RowCount > -1 Then
                    SaveQuery = "INSERT INTO purchase_master VALUES ('" & _
                                                         lblInvoice.Text.Trim & "'," & _
                                                         gblPrliviges & ",'" & _
                                                         SysOperator.Trim & "','" & _
                                                         Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                         PurchaseType.Trim & "','" & _
                                                         DetailID.Trim & "','" & _
                                                         Val(txtSuplCode.Text) & "','" & _
                                                         lblSuplrName.Text.Trim & "'," & _
                                                         Format(Val(lblInvoiceTotal.Text.Trim), "0.00") & "," & _
                                                         gblDiscount & "," & _
                                                         gblNet & "," & _
                                                         gblPayment & "," & _
                                                         "',0,'ORDER')"
                    ProcessTransaction(SaveQuery)
                    SortID = 1
                    For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                        Dim SaveItemQuery As String = "INSERT INTO purchase_detail VALUES ('" & _
                                                             DetailID.Trim & "','" & _
                                                             Format(Date.Parse(lblInvoiceDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                             lblInvoice.Text.Trim & "','" & _
                                                             PurchaseType.Trim & "'," & _
                                                             Val(txtSuplCode.Text.Trim) & ",'" & _
                                                             lblSuplrName.Text.Trim & "'," & _
                                                             Val(OutRow.Cells(0).Value.ToString) & ",'" & _
                                                             OutRow.Cells(1).Value.ToString & "','" & _
                                                             OutRow.Cells(2).Value.ToString & "','" & _
                                                             Val(OutRow.Cells(3).Value.ToString) & "'," & _
                                                             Val(OutRow.Cells(4).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(5).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(6).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(7).Value.ToString) & "," & _
                                                             Val(OutRow.Cells(8).Value.ToString) & ",'" & _
                                                             PurchaseType & "','" & _
                                                             SysOperator.Trim & "'," & _
                                                             "'x','" & _
                                                             SortID & "')"
                        ProcessTransaction(SaveItemQuery)
                        SortID += 1
                    Next OutRow
                End If
                LastPrchID = lblInvoice.Text.Trim
                Call UpdateStockQuantity()
                SortID = 0
                PrchReturn = True
            End If
            RefreshFields()
        Else
        MessageBox.Show("Invoice cannot be saved and print.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
        End If
    End Sub

    Private Sub RefreshFields()
        If Me.SaleDataGrid.Rows.Count > -1 Then
            For i As Integer = Me.SaleDataGrid.Rows.Count - 1 To 0 Step -1
                Me.SaleDataGrid.Rows.RemoveAt(i)
            Next
        End If
        lblInvoiceDate.Text = Format(Now.Date, "MM/dd/yyyy")
        txtCode.Clear()
        SortID = 1
        gblDiscount = 0
        gblPayment = 0
        gblNet = 0
        lblSuplrName.Text = String.Empty
        lblTotItems.Text = "0"
        txtQty.Text = "1"
        gblPayment = 0
        gblDiscount = 0
        gblDues = 0
        gblNet = 0
        gblDiff = 0
        lblInvoice.Text = GenerateMax_ID("purchase_master", "prchid")
        txtCode.Focus()
        txtCode.Focus()
        PrchMode = False
        EditInvoiceMode = False
        PrintInvoice = False
    End Sub

    Private Sub PurchaseInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        GetConnectionString()
        lblInvoice.Text = GenerateMax_ID("PURCHASE", "PRCH_TR_ID")
        lblInvoiceDate.Text = Format(Now.Date, "MM/dd/yyyy")
        lblDarawer.Text = SysOperator
        AddRow = False
        NetTotal = 0
        SaleDataGrid.DefaultCellStyle.SelectionBackColor = Color.Gray
        SaleDataGrid.DefaultCellStyle.SelectionForeColor = Color.White
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub txtSuplCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuplCode.GotFocus
        Get_Property_GotFocus(txtSuplCode)
    End Sub

    Private Sub txtSuplCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSuplCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtSuplCode.Text) = 0 Then
                gblQueryText = "COMPANY"
                gblQuery = "select acc_no, acc_name from accounts where acc_reg_type = 'COMPANY' order by acc_no"
                AccCodesHelp.ShowDialog(Me)
                If Len(gblCP_ID) > 0 Then txtSuplCode.Text = gblCP_ID
            End If
            ExecuteAdapterQuery(SqlDataAdapter, "select * from accounts where acc_no = " & Val(txtSuplCode.Text), Connection)
            Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    lblSuplrName.Text = reader.Item("acc_name").ToString()
                    lblPrevBal.Text = reader.Item("acc_balance").ToString()
                End While
                Panel2.Enabled = True
            End If
            If reader Is Nothing Then reader.Close()
            ExecuteAdapterQuery(InfoDataAdapter, "select max(prch_invoice) as lastInvoice from purchase where prch_suppl_id = " & Val(txtSuplCode.Text), Connection)
            Dim InvoiceReader As SqlDataReader = InfoDataAdapter.SelectCommand.ExecuteReader
            If InvoiceReader.HasRows Then
                While InvoiceReader.Read
                    lblLastBill.Text = InvoiceReader.Item("lastinvoice").ToString()
                End While
                Panel2.Enabled = True
            End If
            If InvoiceReader Is Nothing Then InvoiceReader.Close()
            txtCode.Focus()
        End If
    End Sub

    Private Sub txtSuplCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuplCode.LostFocus
        Get_Property_LostFocus(txtSuplCode)
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Get_Property_LostFocus(txtCode)
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

    Private Sub txtSuplCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSuplCode.KeyPress
        ValidateNumbersOnly(sender, e, txtSuplCode)
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        ValidateNumbersOnly(sender, e, txtCode)
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        ValidateNumbersOnly(sender, e, txtQty)
    End Sub

    Private Sub txtDisc1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisc1.KeyPress
        ValidateNumbersOnly(sender, e, txtDisc1)
    End Sub

    Private Sub txtDisc2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDisc2.KeyPress
        ValidateNumbersOnly(sender, e, txtDisc2)
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtQty.Text) > 0 Then
                AddItemRow(sender, e)
            Else
                MsgBox("Please give valid quantity.")
                txtQty.Focus()
            End If
        End If
    End Sub

    Private Sub AddItemRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            AddRow = True
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
                                ProdPrice = Val(SaleDataGrid.Rows(row.Index).Cells(5).Value.ToString)
                                SaleDataGrid.Rows(row.Index).Cells(3).Value = Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString) + Val(txtQty.Text.Trim)
                                NetAmount = (ProdPrice * Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString))
                                SaleDataGrid.Rows(row.Index).Cells(6).Value = NetAmount
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
                                ProdPrice = Val(GetStockInfo.Item("prod_purch_price").ToString)
                                ItemRow.Cells(0).Value = GetStockInfo.Item("prod_code").ToString.ToUpper
                                ItemRow.Cells(1).Value = GetStockInfo.Item("prod_desc").ToString.ToUpper
                                ItemRow.Cells(2).Value = GetStockInfo.Item("prod_packing").ToString.ToUpper
                                ItemRow.Cells(3).Value = txtQty.Text.Trim.ToString()
                                ItemRow.Cells(4).Value = txtDisc1.Text.Trim.ToString()
                                NetAmount = (ProdPrice * Val(txtQty.Text.Trim))
                                ItemRow.Cells(5).Value = ProdPrice
                                ItemRow.Cells(6).Value = NetAmount
                                ItemRow.Cells(7).Value = "X"
                                PrchMode = True
                            End If
                            'lblMode.Text = "Sale"
                            Call Get_Total()
                            'Call lblTotalPrice_Validated(sender, e)
                            'Call lblShowDiscount_Validated(sender, e)
                            PrchReturn = False
                            PrchMode = True
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
                TotalAmount += Format(Val(row.Cells(6).Value.ToString.Trim), "0.00")
                'gblNet += Format(Val(row.Cells(6).Value.ToString.Trim), "0.00")
                lblTotItems.Text = Val(lblTotItems.Text) + 1
            Next
            lblInvoiceTotal.Text = Format(TotalAmount, "0.00")
            'lblNetTotal.Text = Format(TotalAmount + Val(lblOldBalance.Text.Trim), "0.00")
            gblNet = TotalAmount
            'lblNetBalance.Text = Format(Val(lblNetTotal.Text) - gblPayment, "0.00")
        End If
    End Sub

    Private Sub SaleDataGrid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaleDataGrid.GotFocus
        SaleDataGrid.DefaultCellStyle.SelectionBackColor = Color.IndianRed
        SaleDataGrid.DefaultCellStyle.SelectionForeColor = Color.Yellow
    End Sub

    Private Sub SaleDataGrid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaleDataGrid.LostFocus
        SaleDataGrid.DefaultCellStyle.SelectionBackColor = Color.Gray
        SaleDataGrid.DefaultCellStyle.SelectionForeColor = Color.White
    End Sub

    Private Sub UpdateStockQuantity()
        Dim SelectQty As String = "SELECT * FROM PURCHASE_DETAIL WHERE PrchID = '" & LastPrchID & "'"
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
        Dim SelectQty As String = "SELECT StockID,StockDesc,SUM(QTY) AS StockQty FROM SALE_DETAIL WHERE SaleID = N'" & LastPrchID & "' GROUP BY StockID, StockDesc"
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

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        Get_Property_GotFocus(txtDiscount)
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        ValidateNumbersOnly(sender, e, txtDiscount)
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            gblDiscount = Val(lblInvoiceTotal.Text) * Val(txtDiscount.Text) / 100
            txtCashPaid.Focus()
        End If
    End Sub

    Private Sub txtDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.LostFocus
        Get_Property_LostFocus(txtDiscount)
    End Sub

    Private Sub txtCashPaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashPaid.GotFocus
        Get_Property_GotFocus(txtCashPaid)
    End Sub

    Private Sub txtCashPaid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashPaid.KeyPress
        ValidateNumbersOnly(sender, e, txtCashPaid)
    End Sub

    Private Sub txtCashPaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashPaid.LostFocus
        Get_Property_LostFocus(txtCashPaid)
    End Sub

    Private Sub txtCashPaid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCashPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Code Here
        End If
    End Sub

    Private Sub txtCashPaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashPaid.TextChanged
        lblSave.Enabled = True
    End Sub
End Class