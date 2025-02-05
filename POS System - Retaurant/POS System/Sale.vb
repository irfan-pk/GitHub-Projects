Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient

Public Class Sale
    Dim ProductID As String = String.Empty
    Dim ProductQty, FinalQty As Integer
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim Items, Clos_Balance As String
    Dim Payment, FinalPayment, TotalQty, Dues As Double
    Dim SaleMode, ReturnMode, DiscountAllow, SaleReturn, SaleCredit As Boolean
    Dim SortID, NewQty, LastSaleID, Max_ID, Q1, Q2, Q3, Q4 As Integer

    Private Sub frmSale_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F12 Then
            txtCustomerName.Visible = True
            txtCustomerName.Clear()
            txtCustomerName.Focus()
        End If
        If e.KeyCode = Keys.F3 Then cmdSuspend_Click(sender, e)
        If e.KeyCode = Keys.F5 Then cmdPrint_Click(sender, e)
        If e.KeyCode = Keys.F6 Then cmdReturn_Click(sender, e)
        If e.KeyCode = Keys.F7 Then cmdDelete_Click(sender, e)
        If e.KeyCode = Keys.F8 Then txtPaid.Focus()
        If e.KeyCode = Keys.F9 Then lblHold_DoubleClick(sender, e)
        If e.KeyCode = Keys.F10 Then cmdSaleReturn_Click(sender, e)
        If e.KeyCode = Keys.F11 Then cmdNew_Click(sender, e)
        If e.KeyCode = Keys.F12 Then cmdSave_Click(sender, e)
    End Sub

    Private Sub frmSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Delete Previous hold data
        Dim DeleteMaster = "DELETE FROM SALE_MASTER_HOLD"
        ExecuteAdapterQuery(SqlDataAdapter, DeleteMaster, Connection)
        Dim DeleteDetail = "DELETE FROM SALE_DETAIL_HOLD"
        ExecuteAdapterQuery(SqlDataAdapter, DeleteDetail, Connection)
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
        lblUserRole.Text = UserStatus
        Call GetConnectionString()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Call cmdNew_Click(sender, e)
        txtCode.Focus()
    End Sub

    Private Sub cmdViewSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewSale.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to print", "Print Sale Invoice", "only digit")
        If SaleInvoice.Trim = String.Empty Then Exit Sub
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
        lblQty.Text = "1"
        lblMode.Text = "Sale"
        lblNum2Word.Text = String.Empty
        lblCustID.Text = "00"
        lblCustName.Text = String.Empty
        txtPaid.Text = "00"
        lblRefund.Text = "00"
        lblSaleType.Text = "Cash Sale"
        lblCustomer.Text = "No Customer Selected"
        txtCustomerName.Visible = False
        lblInvoice.Text = GetMax_ID(lblInvoice.Text)
        lblSequence.Text = Format(Now.Date, "MMddyyyy") & Format(Val(GetDetail_ID(lblSequence.Text.Trim)), "0000")
        Call Popup_DataGrid()
        Call Get_Total("SALE_DETAIL_TEMP")
        SaleMode = False
        SaleReturn = True
        DiscountAllow = False
        cmdSaleReturn.Enabled = True
        Call CountHoldSale()
        txtCode.Focus()
    End Sub

    Private Sub cmdReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.Click
        If SaleMode = True Then lblMode.Text = "Return"
        txtCode.Focus()
    End Sub

    Private Sub cmdCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WaiterCode.ShowDialog(Me)
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
            If gblDiscount.ToString = String.Empty Then gblDiscount = 0 : Exit Sub
            If IsNumeric(gblDiscount) And Val(gblDiscount) > 0 Then
                DiscountAllow = True
                lblDiscHdr.Visible = True
                lblDiscount.Visible = True
                If Val(txtPaid.Text) > 0 Then txtPaid.Text = Val(lblOrgPrice.Text.Trim) - gblDiscount
                lblDiscount.Text = Format(gblDiscount, "0.00")
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

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If SaleMode = True And lblMode.Text <> "Delete" Then lblMode.Text = "Delete"
        txtCode.Focus()
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
            If txtQty.Text = String.Empty Or Val(txtQty.Text.Trim) = 0 Then lblQty.Text = 1 Else lblQty.Text = txtQty.Text.Trim
            txtQty.Visible = False
            txtCode.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtQty, txtQty)
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        If txtQty.Text = String.Empty Or Val(txtQty.Text.Trim) = 0 Then lblQty.Text = 1 Else lblQty.Text = txtQty.Text.Trim
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

    Private Sub lblTotalPrice_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lblTotalPrice.Validating
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

    Private Sub lblTotalPrice_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTotalPrice.Validated
        'Display the value as local currency.
        Me.lblTotalPrice.Text = Decimal.Parse(Me.lblTotalPrice.Text).ToString("c")
    End Sub

    Private Sub ValidateDiscount(ByVal sender As Object, ByVal e As System.EventArgs)
        If DiscountAllow = True Then
            lblTotalPrice.Text = Val(lblOrgPrice.Text.Trim) - gblDiscount
            Call lblTotalPrice_Validated(sender, e)
        End If
    End Sub

    Private Sub txtPaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            Payment = Val(lblOrgPrice.Text.Trim) - gblDiscount
            'If Val(txtPaid.Text.Trim) < Payment Then gblMessage = "Payment Less than Total Price." : frmMsgStatus.ShowDialog(Me) : Exit Sub
            'If Val(txtPaid.Text.Trim) > Payment Then lblRefund.Text = Val(txtPaid.Text.Trim) - Payment
            lblRefund.Text = Val(txtPaid.Text.Trim) - Payment
            'cmdSave.Enabled = True
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
    End Sub

    Private Sub frmSale_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmSale_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmSale_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

#Region "Runtime Functions and Event Handlers" '/CLICK TO EXPAND AND HIDE OR UNHIDE

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Escape Then txtPaid.Focus()
        If e.KeyCode = Keys.Enter Then
            Dim TempDetailSale As String = String.Empty
            Dim StockInfo As String = "select * from products where prod_cd = N'" & txtCode.Text.Trim & "'"
            ExecuteAdapterQuery(SaleDataAdapter, StockInfo, Connection)
            Dim GetStockInfo As SqlDataReader = SaleDataAdapter.SelectCommand.ExecuteReader
            If GetStockInfo.HasRows Then
                While GetStockInfo.Read
                    If CheckItemExist("SALE_DETAIL_TEMP") = False Then
                        TempDetailSale = "INSERT INTO SALE_DETAIL_TEMP VALUES (" & _
                                                 Val(Mid(lblSequence.Text.Trim, 9, 4)) & ",'" & _
                                                 Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                                 Val(lblInvoice.Text.Trim) & ",'" & _
                                                 lblSaleType.Text.Trim & "'," & _
                                                 Val(lblCustID.Text.Trim) & ",'" & _
                                                 lblCustName.Text.Trim & "','" & _
                                                 txtCode.Text.Trim & "','" & _
                                                 GetStockInfo.Item("PROD_DESC").ToString.Trim & "','" & _
                                                 "PARCEL" & "'," & _
                                                 GetStockInfo.Item("PROD_SPRICE") & "," & Val(lblQty.Text) & "," & _
                                                 GetStockInfo.Item("PROD_SPRICE") * Val(lblQty.Text) & ",'ADDED'," & _
                                                 lblUserID.Text.Trim & ",0,0,0,0,0,'x'," & SortID & ")"
                        SaleMode = True
                        SortID += 1
                    Else
                        If SaleMode = True Then
                            TempDetailSale = "UPDATE SALE_DETAIL_TEMP SET QTY = QTY + " & Val(lblQty.Text) & ", PRICE = PRICE + " & GetStockInfo.Item("PROD_SPRICE") * Val(lblQty.Text) & " WHERE SALEID = N'" & Val(lblInvoice.Text.Trim) & "' AND STOCKID = N'" & txtCode.Text.Trim & "'"
                            If lblMode.Text = "Delete" Then TempDetailSale = "DELETE FROM SALE_DETAIL_TEMP WHERE SALEID = N'" & Val(lblInvoice.Text.Trim) & "' AND STOCKID = N'" & txtCode.Text.Trim & "'"
                            If lblMode.Text = "Return" Then TempDetailSale = "UPDATE SALE_DETAIL_TEMP SET QTY = QTY - " & Val(lblQty.Text) & ", PRICE = PRICE - " & GetStockInfo.Item("PROD_SPRICE") * Val(lblQty.Text) & " WHERE SALEID = N'" & Val(lblInvoice.Text.Trim) & "' AND STOCKID = N'" & txtCode.Text.Trim & "'"
                        End If
                    End If
                    ExecuteAdapterQuery(SqlDataAdapter, TempDetailSale, Connection)
                    lblQty.Text = "1"
                    txtQty.Text = "1"
                    lblMode.Text = "Sale"
                    Call Popup_DataGrid()
                    Call Get_Total("SALE_DETAIL_TEMP")
                    Call lblTotalPrice_Validated(sender, e)
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

        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")

        Dim cmdText As String = _
           ("SELECT * FROM " & tblName.Trim & " WHERE (SALEID = N'" & Val(lblInvoice.Text.Trim) & "' AND STOCKID = N'" & txtCode.Text.Trim & "' AND SALESTATUS != N'HOLD')")

        Dim bRet As Boolean = False

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                    'While reader.Read
                    '    NewQty = Val(reader.Item("QTY").ToString.Trim) + 1
                    'End While
                End Using
            End Using
        End Using

        Return bRet

    End Function

    Private Sub Popup_DataGrid()
        Try
            Me.RecordDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM SALE_DETAIL_TEMP WHERE SaleStatus != N'HOLD' AND SALEID = N'" & Val(lblInvoice.Text.Trim) & "' ORDER BY SORTITEM"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "SALE_DETAIL_TEMP", Connection)
            SqlDataAdapter.Fill(Me.RecordDataSet, "SALE_DETAIL_TEMP")
            Me.SaleBindingSource.DataSource = Me.RecordDataSet
            Me.SaleBindingSource.DataMember = "SALE_DETAIL_TEMP"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub Get_Total(ByVal tblName As String)
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim cmdText As String = _
           ("SELECT SUM(QTY) AS TOTAL_QTY, SUM(PRICE) AS TOTAL_PRICE FROM " & tblName.Trim & " WHERE (SALEID = N'" & Val(lblInvoice.Text.Trim) & "') AND (SaleStatus != N'HOLD')")
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    While reader.Read
                        lblOrgPrice.Text = Format(Val(reader.Item("TOTAL_PRICE").ToString.Trim), "0.00")
                        lblTotalPrice.Text = Format(Val(reader.Item("TOTAL_PRICE").ToString.Trim), "0.00")
                        lblTax.Text = Val(lblOrgPrice.Text.Trim) * 0.14
                        TotalQty = Val(reader.Item("TOTAL_QTY").ToString)
                        If Val(lblOrgPrice.Text) > 0 Then lblNum2Word.Text = NumToWord(Convert.ToDouble(lblOrgPrice.Text)) & " Only"
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cmdSuspend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuspend.Click
        If SaleMode = True Then
            Dim HoldQuery As String = String.Empty
            Dim HoldStatus As String = "INSERT INTO POS.dbo.SALE_DETAIL_HOLD(DetailID,DetailDate,SaleID,SaleType,CustomerID,CustomerName,StockID,StockDesc,SalePack,UnitCost,Qty,Price,SaleStatus,DrawerID,TaxPercentage,PriceInc,TotalPriceExcl,TotalPriceInc,DiscountDetailID,AOptions,SortItem) " & _
                                       "SELECT DetailID,DetailDate,SaleID,SaleType,CustomerID,CustomerName,StockID,StockDesc,SalePack,UnitCost,Qty,Price,SaleStatus,DrawerID,TaxPercentage,PriceInc,TotalPriceExcl,TotalPriceInc,DiscountDetailID,AOptions,SortItem FROM POS.dbo.SALE_DETAIL_TEMP " & _
                                       "WHERE SaleID = N'" & Val(lblInvoice.Text.Trim) & "'"
            ExecuteAdapterQuery(SqlDataAdapter, HoldStatus, Connection)

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
                                                     "1,0,0,0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "',0)"
            Else
                HoldQuery = "UPDATE SALE_MASTER_HOLD SET " & _
                                                     "DrawerID = N'" & Val(lblUserID.Text.Trim) & "'," & _
                                                     "DrawerName = N'" & lblUserName.Text.Trim & "'," & _
                                                     "DateCompleted = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "','" & _
                                                     "SaleType = N'" & lblSaleType.Text.Trim & " '," & _
                                                     "CustomerID = N'" & Val(lblCustID.Text.Trim) & "'," & _
                                                     "CustomerName = N'" & lblCustName.Text.Trim & "'," & _
                                                     "SaleTotal = N'" & Val(lblOrgPrice.Text.Trim) & "'," & _
                                                     "SalePaid = N'" & Val(txtPaid.Text.Trim) & "'," & _
                                                     "SaleDiscount = N'" & Val(lblDiscount.Text.Trim) & "'," & _
                                                     "SaleChange = N'" & Val(lblRefund.Text.Trim) & "'," & _
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
        Payment = Val(lblOrgPrice.Text.Trim) - gblDiscount
        If Val(txtPaid.Text.Trim) < Payment Then gblMessage = "Payment Less than Total Amount." : MsgStatus.ShowDialog(Me) : txtPaid.Focus() : Exit Sub
        Dim SaveQuery As String = String.Empty
        If SaleMode = True And Val(lblOrgPrice.Text.Trim) - gblDiscount = Val(txtPaid.Text.Trim) - Val(lblRefund.Text.Trim) Then
            Call Get_Total("SALE_DETAIL_TEMP")
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
                                                 "0,0,0,0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "',0)"

            Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
                Dim Cmd As New SqlCommand(SaveQuery, Conn)
                Try
                    Conn.Open()
                    Cmd.ExecuteNonQuery()
                Catch EX As Exception
                    MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                End Try
            End Using
            Dim SaleDetail As String = "INSERT INTO SALE_DETAIL SELECT * FROM SALE_DETAIL_TEMP WHERE SaleStatus != N'HOLD' and DetailID = N'" & Val(DetailID) & "' and SaleID = N'" & Val(lblInvoice.Text.Trim) & "' and DetailDate = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'"
            ExecuteAdapterQuery(SqlDataAdapter, SaleDetail, Connection)
            LastSaleID = Val(lblInvoice.Text.Trim)
            'Call UpdateStockQuantity() // Available in Pro Version
            'Delete Hold Entries when saved
            Dim DeleteHold As String = "DELETE FROM SALE_MASTER_HOLD WHERE SALEID = N'" & LastSaleID & "'"
            ExecuteAdapterQuery(SqlDataAdapter, DeleteHold, Connection)
            DeleteHold = "DELETE FROM SALE_DETAIL_HOLD WHERE SALEID = N'" & LastSaleID & "'"
            ExecuteAdapterQuery(SqlDataAdapter, DeleteHold, Connection)
            'cmdSave.Enabled = False
            SaleReturn = True
            Call cmdPrint_Click(sender, e)
            cmdNew_Click(sender, e)
        End If
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
    End Sub

    Private Sub lblHold_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblHold.DoubleClick
        If Val(lblHold.Text) = 0 Then Exit Sub
        gblCP_ID = 0
        HoldSale.ShowDialog(Me)
        If Val(gblCP_ID.Trim) = 0 Then Exit Sub

        'Shift Hold Sale to Main Window
        Dim ChangeStatus As String = "INSERT INTO POS.dbo.SALE_DETAIL_TEMP(DetailID,DetailDate,SaleID,SaleType,CustomerID,CustomerName,StockID,StockDesc,SalePack,UnitCost,Qty,Price,SaleStatus,DrawerID,TaxPercentage,PriceInc,TotalPriceExcl,TotalPriceInc,DiscountDetailID,AOptions,SortItem) " & _
                                     "SELECT DetailID,DetailDate,SaleID,SaleType,CustomerID,CustomerName,StockID,StockDesc,SalePack,UnitCost,Qty,Price,SaleStatus,DrawerID,TaxPercentage,PriceInc,TotalPriceExcl,TotalPriceInc,DiscountDetailID,AOptions,SortItem FROM POS.dbo.SALE_DETAIL_HOLD " & _
                                     "WHERE SaleID = N'" & Val(gblCP_ID) & "'"
        ExecuteAdapterQuery(SqlDataAdapter, ChangeStatus, Connection)
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
        Call Popup_DataGrid()
        Call Get_Total("SALE_DETAIL_TEMP")
        Call lblTotalPrice_Validated(sender, e)
        txtPaid.Enabled = True
        SaleMode = True
        cmdSaleReturn.Enabled = False
        txtCode.Clear()
        txtCode.Focus()
    End Sub

    Private Function CheckHoldExist(ByVal tblName As String, ByVal strFind As String) As Boolean

        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")

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
        Dim ReturnQuery As String = String.Empty
        If SaleMode = True Then
            Call Get_Total("SALE_DETAIL_TEMP")
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
                          "2,0," & Val(lblOrgPrice.Text.Trim) & ",0,'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "',0)"

            Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
                Dim Cmd As New SqlCommand(ReturnQuery, Conn)
                'Try
                Conn.Open()
                Cmd.ExecuteNonQuery()
                'Catch EX As Exception
                '    MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                'End Try
            End Using
            'save detail to sale detail table
            Dim SaleDetail As String = "INSERT INTO SALE_DETAIL SELECT * FROM SALE_DETAIL_TEMP WHERE SaleStatus != N'HOLD' and DetailID = N'" & Val(DetailID) & "' and SaleID = N'" & Val(lblInvoice.Text.Trim) & "' and DetailDate = N'" & Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'"
            ExecuteAdapterQuery(SqlDataAdapter, SaleDetail, Connection)
            LastSaleID = Val(lblInvoice.Text.Trim)
            'To give minus sign to retrun product
            Dim UpdateMinusSign As String = "update sale_detail set QTY = QTY * -1, PRICE = PRICE * -1 WHERE SaleID = N'" & Val(lblInvoice.Text.Trim) & "'"
            ExecuteAdapterQuery(SaleDataAdapter, UpdateMinusSign, Connection)
            ' To update journal transactions if credit customer info given // only for pro version
            cmdNew_Click(sender, e)
        Else
            gblMessage = "Please first add product to return."
            MsgStatus.ShowDialog(Me)
        End If
    End Sub

    Private Sub UpdateStockQuantity()
        Items = String.Empty
        Dim SelectQty As String = "SELECT StockID,StockDesc,SUM(QTY) AS StockQty FROM SALE_DETAIL WHERE SaleID = N'" & LastSaleID & "' GROUP BY StockID, StockDesc"
        ExecuteAdapterQuery(EntryDataAdpter, SelectQty, Connection)
        Dim Updater As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If Updater.HasRows Then
            While Updater.Read
                Items = Items.Trim & Updater.Item("StockDesc").ToString & ", "
                ProductQty = Val(Updater.Item("StockQty").ToString)
                ProductID = Updater.Item("StockID").ToString
                'Get quantity balances with scheme if are available
                Dim PrevQuantity As String = "SELECT PROD_ONHAND, PROD_SCH1_ONHAND, PROD_SCH2_ONHAND, PROD_SCH3_ONHAND FROM PRODUCTS WHERE PROD_CD = N'" & ProductID.Trim & "'"
                ExecuteAdapterQuery(ProductAdapter, PrevQuantity, Connection)
                Dim QtyAdjuster As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
                If QtyAdjuster.HasRows = True Then
                    QtyAdjuster.Read()
                    Q4 = Val(QtyAdjuster.Item("PROD_SCH3_ONHAND").ToString)
                    Q3 = Val(QtyAdjuster.Item("PROD_SCH2_ONHAND").ToString)
                    Q2 = Val(QtyAdjuster.Item("PROD_SCH1_ONHAND").ToString)
                    Q1 = Val(QtyAdjuster.Item("PROD_ONHAND").ToString)
                    'If Scheme3 has value
                    If ProductQty > 0 Then
                        If Q4 <= ProductQty Then ProductQty = ProductQty - Q4 _
                                                  : Q4 = ProductQty _
                                                  : Call ExecuteUpdateQuery("PROD_SCH3_ONHAND", "0", ProductID)

                        If Q4 > ProductQty Then ProductQty = Q4 - ProductQty _
                                                : Q4 = ProductQty _
                                                : Call ExecuteUpdateQuery("PROD_SCH3_ONHAND", ProductQty, ProductID)
                    End If
                    'If Scheme2 has value
                    If ProductQty > 0 Then
                        If Q3 <= ProductQty Then ProductQty = ProductQty - Q3 _
                                                  : Q3 = ProductQty _
                                                  : Call ExecuteUpdateQuery("PROD_SCH2_ONHAND", "0", ProductID)

                        If Q3 > ProductQty Then ProductQty = Q3 - ProductQty _
                                                : Q3 = ProductQty _
                                                : Call ExecuteUpdateQuery("PROD_SCH2_ONHAND", ProductQty, ProductID)
                    End If
                    'If Scheme1 has value
                    If ProductQty > 0 Then
                        If Q2 <= ProductQty Then ProductQty = ProductQty - Q2 _
                                                  : Q2 = ProductQty _
                                                  : Call ExecuteUpdateQuery("PROD_SCH1_ONHAND", "0", ProductID)

                        If Q2 > ProductQty Then ProductQty = Q2 - ProductQty _
                                                : Q2 = ProductQty _
                                                : Call ExecuteUpdateQuery("PROD_SCH1_ONHAND", ProductQty, ProductID)
                    End If

                    'Update main stock
                    If ProductQty > 0 Then
                        ProductQty = Q1 - ProductQty
                        Call ExecuteUpdateQuery("PROD_ONHAND", ProductQty, ProductID)
                    End If
                    QtyAdjuster.Close()
                End If
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
                Dim PrevQuantity As String = "SELECT PROD_ONHAND, PROD_SCH1_ONHAND, PROD_SCH2_ONHAND, PROD_SCH3_ONHAND FROM PRODUCTS WHERE PROD_CD = N'" & ProductID.Trim & "'"
                ExecuteAdapterQuery(ProductAdapter, PrevQuantity, Connection)
                Dim QtyAdjuster As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
                If QtyAdjuster.HasRows = True Then
                    QtyAdjuster.Read()
                    Q1 = Val(QtyAdjuster.Item("PROD_ONHAND").ToString)
                    FinalQty = Q1 + ProductQty
                    Call ExecuteUpdateQuery("PROD_ONHAND", FinalQty, ProductID)
                    QtyAdjuster.Close()
                End If
            End While
            If Updater Is Nothing Then Updater.Close()
        End If
    End Sub

    Private Sub ExecuteUpdateQuery(ByVal TableField As String, ByVal FieldQty As String, ByVal StockID As String)
        'Passes values to update table fields
        Dim UpdateQty As String = "UPDATE PRODUCTS SET " & TableField.Trim & " = " & Val(FieldQty.Trim) & " WHERE PROD_CD = N'" & StockID.ToString.Trim & "'"
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
        Dim cmdText As String = String.Empty
        ' To made general journal transaction for concerned suppliers while update products
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim Trans_ID, Opn_Bal, Clo_Bal As Double
        Dim Customer_Name As String = String.Empty
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

#End Region

#Region "Settle MenuOrder List"

    Private Sub cmdMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMenu.Click, txtCode.Click
        FoodMenu.ShowDialog(Me)
        If gblOrder = True Then
            'Loop for add items picked from menu for bill
            For I As Integer = 0 To gblArrayCount - 1
                For J As Integer = 0 To 2
                    Dim S1 As String = gblDataArray(I, J)
                    If J > 0 And J < 2 Then lblQty.Text = S1.Trim
                    If J > 1 And J < 3 Then txtCode.Text = S1.Trim : Call Handles_SettleCommand(sender, e)
                Next J
            Next I
            gblOrder = False
            Erase gblDataArray
        End If
    End Sub

    Private Sub Handles_SettleCommand(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TempDetailSale As String = String.Empty
        Dim StockInfo As String = "select * from products where prod_cd = N'" & txtCode.Text.Trim & "'"
        ExecuteAdapterQuery(SaleDataAdapter, StockInfo, Connection)
        Dim GetStockInfo As SqlDataReader = SaleDataAdapter.SelectCommand.ExecuteReader
        If GetStockInfo.HasRows Then
            While GetStockInfo.Read
                If CheckItemExist("SALE_DETAIL_TEMP") = False Then
                    TempDetailSale = "INSERT INTO SALE_DETAIL_TEMP VALUES (" & _
                                             Val(Mid(lblSequence.Text.Trim, 9, 4)) & ",'" & _
                                             Format(Date.Parse(lblDate.Text.Trim), "MM/dd/yyyy") & "'," & _
                                             Val(lblInvoice.Text.Trim) & ",'" & _
                                             lblSaleType.Text.Trim & "'," & _
                                             Val(lblCustID.Text.Trim) & ",'" & _
                                             lblCustName.Text.Trim & "','" & _
                                             txtCode.Text.Trim & "','" & _
                                             GetStockInfo.Item("PROD_DESC").ToString.Trim & "','" & _
                                             "PARCEL" & "'," & _
                                             GetStockInfo.Item("PROD_SPRICE") & "," & Val(lblQty.Text) & "," & _
                                             GetStockInfo.Item("PROD_SPRICE") * Val(lblQty.Text) & ",'ADDED'," & _
                                             lblUserID.Text.Trim & ",0,0,0,0,0,'x'," & SortID & ")"
                    SaleMode = True
                    SortID += 1
                Else
                    If SaleMode = True Then
                        TempDetailSale = "UPDATE SALE_DETAIL_TEMP SET QTY = QTY + " & Val(lblQty.Text) & ", PRICE = PRICE + " & GetStockInfo.Item("PROD_SPRICE") * Val(lblQty.Text) & " WHERE SALEID = N'" & Val(lblInvoice.Text.Trim) & "' AND STOCKID = N'" & txtCode.Text.Trim & "'"
                        If lblMode.Text = "Delete" Then TempDetailSale = "DELETE FROM SALE_DETAIL_TEMP WHERE SALEID = N'" & Val(lblInvoice.Text.Trim) & "' AND STOCKID = N'" & txtCode.Text.Trim & "'"
                        If lblMode.Text = "Return" Then TempDetailSale = "UPDATE SALE_DETAIL_TEMP SET QTY = QTY - " & Val(lblQty.Text) & ", PRICE = PRICE - " & GetStockInfo.Item("PROD_SPRICE") * Val(lblQty.Text) & " WHERE SALEID = N'" & Val(lblInvoice.Text.Trim) & "' AND STOCKID = N'" & txtCode.Text.Trim & "'"
                    End If
                End If
                ExecuteAdapterQuery(SqlDataAdapter, TempDetailSale, Connection)
                lblQty.Text = "1"
                txtQty.Text = "1"
                lblMode.Text = "Sale"
                Call Popup_DataGrid()
                Call Get_Total("SALE_DETAIL_TEMP")
                Call lblTotalPrice_Validated(sender, e)
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
    End Sub

#End Region

End Class