Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class Purchases
    Dim Max_ID, Supplr_ID As Integer
    Dim drag, newrec, updatable, editmode, DataFinalize, GridEdit As Boolean
    Dim OldPurchPrice, OldSalePrice, OldQuantity, QtyPerUnit, Tran_ID, NewPurchPrice As Double
    Dim mousex, mousey As Integer
    Dim SubCategory As String = String.Empty

#Region "TextBox Events"
    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then cmbSupplier.Focus()
    End Sub

    Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
        'Call RefreshGridView()
    End Sub

    Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
        'Call RefreshGridView()
        'cmbSupplier.Focus()
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        Call RefreshGridView()
    End Sub

    Private Sub cmbCompany_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSupplier.GotFocus
        Call Get_Property_GotFocus(cmbSupplier)
        Call RefreshGridView()
    End Sub

    Private Sub cmbCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then txtCode.Focus()
    End Sub

    Private Sub cmbCompany_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSupplier.LostFocus
        Call Get_Property_LostFocus(cmbSupplier)
    End Sub

    Private Sub txtIvoice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoice.GotFocus
        Call Get_Property_GotFocus(txtInvoice)
    End Sub

    Private Sub txtInvoice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvoice.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtCode)
    End Sub

    Private Sub txtInvoice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoice.LostFocus
        Call Get_Property_LostFocus(txtInvoice)
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        Call Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        ValidateAlphaNumOnly(sender, e)
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            'ProductCode.ShowDialog(Me)
            If Len(gblItemCode) > 0 Then txtCode.Text = gblItemCode.ToUpper
            Call txtCode_KeyDown(sender, e)
        End If
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Call Get_Property_LostFocus(txtCode)
    End Sub

    Private Sub txtDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.GotFocus
        Call Get_Property_GotFocus(txtDesc)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        'Alpha Numeric input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Or (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 46 Then
            ' Go Through
            ' uncommit following routine when need only First Letter capitalized of text
            'If e.KeyChar <> ChrW(Keys.Back) Then
            '    If txtDesc.Text = "" Then
            '        e.KeyChar = UCase(e.KeyChar)
            '    End If
            'End If
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtDesc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.LostFocus
        Call Get_Property_LostFocus(txtDesc)
        txtDesc.Text = StrConv(txtDesc.Text.Trim, VbStrConv.ProperCase)
    End Sub

    Private Sub txtDepartment_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepartment.GotFocus
        Call Get_Property_GotFocus(txtDepartment)
    End Sub

    Private Sub txtDepartment_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDepartment.LostFocus
        Call Get_Property_LostFocus(txtDepartment)
    End Sub

    Private Sub txtCategory_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCategory.GotFocus
        Call Get_Property_GotFocus(txtDepartment)
    End Sub

    Private Sub txtCategory_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCategory.LostFocus
        Call Get_Property_LostFocus(txtDepartment)
    End Sub

    Private Sub txtPacking_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPacking.GotFocus
        Call Get_Property_GotFocus(txtPacking)
    End Sub

    Private Sub txtPacking_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPacking.LostFocus
        Call Get_Property_LostFocus(txtPacking)
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPPrice.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Call ValidateNumbersOnly(sender, e, txtQty)
        BindingNavigatorSave.Enabled = True
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        Call Get_Property_LostFocus(txtQty)
    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        Call Get_Property_GotFocus(txtQty)
    End Sub

    Private Sub txtPPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPPrice.GotFocus
        Call Get_Property_GotFocus(txtPPrice)
    End Sub

    Private Sub txtPPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindingNavigatorSave.Enabled = True
        End If
    End Sub

    Private Sub txtPPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPPrice.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtPPrice)
    End Sub

    Private Sub txtPPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPPrice.LostFocus
        Call Get_Property_LostFocus(txtPPrice)
    End Sub

#End Region

#Region "Form Events and Procedures"

    Private Sub Purchases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        newrec = False
        updatable = False
        Dim SupplierSqlAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(SupplierSqlAdapter, "select * from suppliers", Connection)
        Dim SupReader As SqlDataReader = SupplierSqlAdapter.SelectCommand.ExecuteReader
        If SupReader.HasRows Then
            While SupReader.Read
                cmbSupplier.Items.Add(SupReader.Item("supl_name").ToString)
            End While
            If SupReader Is Nothing Then SupReader.Close()
        End If
        'Retrieve Records for datagrid view from purchase table
        Call RefreshGridView()
        DataFinalize = False
        txtTranID.Text = GenerateMax_ID("purchase", "prch_tr_id")
    End Sub

    Private Sub Purchases_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F3 Then Call Get_Text_Values() : editmode = True
    End Sub

    Private Sub Purchases_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim bHandled As Boolean = False
        Select Case e.Modifiers
            Case Keys.Control
                If e.KeyCode = Keys.S Then
                    e.Handled = True
                    'execute save Procedure
                    Call SaveCurrentChanges()
                End If
        End Select
    End Sub

    Private Sub Purchases_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Purchases_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Purchases_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        If Val(txtQty.Text) > 0 Then Call SaveCurrentChanges()
    End Sub

    Private Sub RefreshGridView()
        Try
            'Retrieve Records for datagrid view from purchase table
            Me.PurchaseDataSet.Clear()
            Dim PurchasesQuery As String = "SELECT * FROM PURCHASE WHERE (prch_date = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102))"
            ExecuteAdapterQuery(PurchaseAdapter, PurchasesQuery, Connection)
            PurchaseAdapter.Fill(Me.PurchaseDataSet, "PURCHASE")
            Dim reader1 As SqlDataReader = PurchaseAdapter.SelectCommand.ExecuteReader
            If reader1.HasRows Then
                Me.BindingNavigatorFinalize.Enabled = True
                Me.BindingNavigatorRefreshItem.Enabled = True
                Me.PurchaseBindingSource.DataSource = Me.PurchaseDataSet
                Me.PurchaseBindingSource.DataMember = "PURCHASE"
                Me.PurchaseDataGridView.Enabled = True
                Me.PurchaseDataGridView.Refresh()
            Else
                Me.PurchaseDataGridView.Enabled = False
            End If
            'Retrieve Records for datagrid view from product table
            Me.ProductDataSet.Clear()
            ProductAdapter.Dispose()
            Dim ProductQuery As String = "SELECT * FROM PRODUCTS WHERE PROD_UPD_ON = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
            ExecuteAdapterQuery(ProductAdapter, ProductQuery, Connection)
            ProductAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            Dim reader2 As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
            If reader2.HasRows Then
                Me.ProductBindingSource.DataSource = Me.ProductDataSet
                Me.ProductBindingSource.DataMember = "PRODUCTS"
                Me.ProductDataGridView.Enabled = True
                Me.ProductDataGridView.Refresh()
            Else
                Me.ProductDataGridView.Enabled = False
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            'First Check Item in Product Table and get information
            Dim ProdInfo As SqlDataReader
            ExecuteAdapterQuery(SqlDataAdapter, "SELECT * FROM PRODUCTS WHERE PROD_CODE = N'" & txtCode.Text.ToString.ToString.Trim & "'", Connection)
            ProdInfo = SqlDataAdapter.SelectCommand.ExecuteReader
            If ProdInfo.HasRows Then
                While ProdInfo.Read
                    txtDesc.Text = ProdInfo.Item("PROD_DESC").ToString.Trim
                    txtDepartment.Text = ProdInfo.Item("PROD_HEAD").ToString.Trim
                    txtCategory.Text = ProdInfo.Item("PROD_CATG").ToString.Trim
                    txtPacking.Text = ProdInfo.Item("prod_packing").ToString.Trim
                    OldQuantity = Val(ProdInfo.Item("PROD_STOCK").ToString.Trim)
                    QtyPerUnit = Val(ProdInfo.Item("PROD_QTY_PER_UNIT").ToString.Trim)
                    txtOldPrice.Text = Val(ProdInfo.Item("prod_purch_price").ToString.Trim)
                    SubCategory = ProdInfo.Item("prod_sub_catg").ToString.Trim
                End While
                If ProdInfo Is Nothing Then ProdInfo.Close()
                updatable = True
                newrec = False
                txtQty.Focus()
                Exit Sub
            Else
                MsgBox("Invalid product solution", MsgBoxStyle.Information, My.Application.Info.ProductName)
            End If
            If ProdInfo Is Nothing Then ProdInfo.Close()
        End If
    End Sub

    Private Sub SaveCurrentChanges()
        If txtInvoice.Text > "0" Then
            ExecuteAdapterQuery(SqlDataAdapter, "select * from purchase where prch_prod_cd = N'" & txtCode.Text & "'and prch_supplier = N'" & StrConv(cmbSupplier.Text.Trim, VbStrConv.ProperCase) & "' and prch_invoice = " & Val(txtInvoice.Text.Trim) & "  and prch_date = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) and PRCH_STATUS = 'STOCKED'", Connection)
            Dim TransCheck As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If TransCheck.HasRows = False Then
                If ValidateFieldsData(Me.SplitContainer1.Panel1.Controls) = False Then
                    If txtCode.Text = "" Or txtDesc.Text = "" Then _
                        gblMessage = ("Please give valid product code.") _
                                                  : MsgStatus.ShowDialog(Me) _
                                                  : Exit Sub
                    If Val(txtPPrice.Text.Trim) > 0 Then NewPurchPrice = Val(txtPPrice.Text.Trim) Else NewPurchPrice = Val(txtOldPrice.Text.Trim)
                    Dim CheckQuery As String = "SELECT * FROM PURCHASE WHERE prch_tr_id = " & Val(txtTranID.Text.Trim)
                    ExecuteAdapterQuery(SqlDataAdapter, CheckQuery, Connection)
                    Dim Finder As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                    If Finder.HasRows Then
                        If editmode = True Then
                            Dim EditRecord As String = "UPDATE PURCHASE SET " & _
                                                       "PRCH_INVOICE = '" & Val(txtInvoice.Text.Trim) & "', " & _
                                                       "PRCH_DATE = '" & Format(DateTime.Parse(txtDate.Text.Trim.ToString.Trim), "MM/dd/yyyy") & "', " & _
                                                       "PRCH_PROD_CD = '" & txtCode.Text.Trim.ToUpper & "', " & _
                                                       "PRCH_DESC = '" & txtDesc.Text.Trim.ToUpper & "', " & _
                                                       "PRCH_SUPPLIER = '" & StrConv(cmbSupplier.Text.Trim, VbStrConv.ProperCase) & "', " & _
                                                       "PRCH_PACK = '" & txtPacking.Text.Trim.ToUpper & "', " & _
                                                       "PRCH_QTY = " & Val(txtQty.Text.Trim) & ", " & _
                                                       "PRCH_OLD_QTY = " & OldQuantity & ", " & _
                                                       "PRCH_PRICE = " & NewPurchPrice & ", " & _
                                                       "PRCH_STATUS ='PURCHASE' " & _
                                                       "WHERE (PRCH_TR_ID = " & gblFind & ")"
                            ExecuteAdapterQuery(SqlDataAdapter, EditRecord, Connection)
                        End If
                    Else
                        Dim InsertRecord As String = "INSERT INTO PURCHASE " & _
                                                     "VALUES (" & Val(txtTranID.Text.Trim) & ",'" & _
                                                     Val(txtInvoice.Text.Trim) & "','" & _
                                                     Format(DateTime.Parse(txtDate.Text.Trim.ToString.Trim), "MM/dd/yyyy") & "','" & _
                                                     txtCode.Text.Trim.ToUpper & "','" & _
                                                     txtDesc.Text.Trim.ToUpper & "','" & _
                                                     cmbSupplier.Text.Trim.ToUpper & "','" & _
                                                     txtDepartment.Text.Trim & "','" & _
                                                     txtCategory.Text.Trim.ToUpper & "','" & _
                                                     txtPacking.Text.Trim.ToUpper & "'," & _
                                                     Val(txtQty.Text.Trim) & "," & _
                                                     OldQuantity & "," & _
                                                     NewPurchPrice & "," & _
                                                     "'PURCHASE'," & QtyPerUnit & "," & Val(txtOldPrice.Text.Trim) & ")"
                        ExecuteAdapterQuery(SqlDataAdapter, InsertRecord, Connection)
                        BindingNavigatorFinalize.Enabled = True
                        BindingNavigatorRefreshItem.Enabled = True
                        SubCategory = String.Empty
                    End If
                Else
                    Exit Sub
                End If
            Else
                MsgBox("Purchases already recorded.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            End If
        Else
            MsgBox("Invoice # should'nt be blank.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
        Call RefreshGridView()
        Call RefreshInputControls()
    End Sub

    Private Sub Get_Text_Values()
        If PurchaseDataGridView.RowCount = 0 Then gblMessage = "No data for edit or data may be updated." : MsgStatus.ShowDialog(Me) : Exit Sub
        'EDIT PROCEDURE WHILE UPDATE PURCHASES
        If PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(15).Value.ToString.Trim = "PURCHASE" Then
            txtTranID.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(0).Value.ToString.Trim
            txtInvoice.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(1).Value.ToString.Trim
            txtDate.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(2).Value.ToString
            txtCode.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(3).Value.ToString.Trim
            gblFind = Val(txtTranID.Text.Trim)
            txtDesc.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(4).Value.ToString.Trim
            cmbSupplier.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(5).Value.ToString.Trim
            txtDepartment.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(6).Value.ToString
            txtCategory.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(7).Value.ToString
            'SubCategory = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(8).Value.ToString
            txtPacking.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(9).Value.ToString
            OldQuantity = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(11).Value.ToString
            txtQty.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(12).Value.ToString
            txtPPrice.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(14).Value.ToString
            txtOldPrice.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(13).Value.ToString
            editmode = True
            txtCode.ReadOnly = True
            txtDesc.ReadOnly = True
            txtCode.Focus()
        Else
            editmode = False
        End If
    End Sub

    Private Sub BindingNavigatorFlinalize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFinalize.Click
        Dim UpdtRecQuery As String = ""
        Dim Clos_Balance As String = ""
        'Final Procedure to update the products from purchases by date and invoice
        Dim TransferQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_STATUS = N'PURCHASE' ORDER BY PRCH_TR_ID"
        ExecuteAdapterQuery(TransferAdapter, TransferQuery, Connection)
        Dim TransferReader As SqlDataReader = TransferAdapter.SelectCommand.ExecuteReader
        If TransferReader.HasRows Then
            While TransferReader.Read
                UpdtRecQuery = String.Empty
                If Val(TransferReader.Item("PRCH_PRICE").ToString) > 0 Then
                    UpdtRecQuery = "UPDATE PRODUCTS SET " & _
                                   "PROD_STOCK = PROD_STOCK + " & (Val(TransferReader.Item("PRCH_QTY").ToString) * Val(TransferReader.Item("PRCH_QTY_PER_UNIT").ToString)) & ", " & _
                                   "PROD_PURCH_PRICE = " & Val(TransferReader.Item("PRCH_PRICE").ToString) & ", " & _
                                   "PROD_UPD_ON = '" & Format(Date.Parse(txtDate.Text.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                   "WHERE (PROD_CODE = N'" & TransferReader.Item("PRCH_PROD_CD").ToString & "')"
                Else
                    UpdtRecQuery = "UPDATE PRODUCTS SET " & _
                                   "PROD_STOCK = PROD_STOCK + " & (Val(TransferReader.Item("PRCH_QTY").ToString) * Val(TransferReader.Item("PRCH_QTY_PER_UNIT").ToString)) & ", " & _
                                   "PROD_UPD_ON = '" & Format(Date.Parse(txtDate.Text.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                   "WHERE (PROD_CODE = N'" & TransferReader.Item("PRCH_PROD_CD").ToString & "')"
                End If
                ProcessTransaction(UpdtRecQuery)

                ' To update suppliers balances
                Dim Total_Amount As Double = Val(TransferReader.Item("PRCH_PRICE").ToString) * (Val(TransferReader.Item("PRCH_QTY").ToString) * Val(TransferReader.Item("PRCH_QTY_PER_UNIT").ToString))
                Dim Total_Quantity As Double = Val(TransferReader.Item("PRCH_QTY").ToString)

                'To update journal transactions
                If Total_Amount > 0 Then
                    'Call Updt_General_Journal(Total_Amount, Total_Quantity, TransferReader.Item("PRCH_SUPPLIER").ToString, TransferReader.Item("PRCH_DATE").ToString, TransferReader.Item("PRCH_DESC").ToString)
                    Clos_Balance = "UPDATE SUPPLIERS SET " & _
                                                    "SUPL_BALANCE = SUPL_BALANCE + " & _
                                                    Total_Amount & ", SUPL_UPD_DT = N'" & Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "' " & _
                                                    "WHERE SUPL_NAME = N'" & TransferReader.Item("PRCH_SUPPLIER").ToString & "'"
                    'ProcessTransaction(Clos_Balance)
                End If
                Total_Amount = 0
            End While
            If TransferReader Is Nothing Then TransferReader.Close()
            ProcessTransaction("update purchase set prch_status = 'STOCKED' where prch_date = '" & Format(Date.Parse(txtDate.Text.ToString.Trim), "MM/dd/yyyy") & "'")
            BindingNavigatorFinalize.Enabled = False
            DataFinalize = True
        Else
            MsgBox("There is no transaction for update or already stocked in the database.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If
        GridEdit = False
        Call RefreshGridView()
    End Sub

    Private Sub Updt_General_Journal(ByVal TotalAmount As Double, ByVal Total_Qty As Double, ByVal strSupplier As String, ByVal strDate As String, ByVal strDesc As String)
        ' To made general journal transaction for concerned suppliers while update products
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim Trans_ID, Opn_Bal, Clo_Bal As Double
        Dim Supplier_Name As String = String.Empty
        Trans_ID = 0
        Opn_Bal = 0
        Clo_Bal = 0
        Dim Suppl_ID As Integer = 0
        Dim Max_Tr As Double = GenerateMax_ID("SUPPLIERS_JOURNAL", "SUPL_TR_ID")

        Dim Get_Supplier As String = "select * from suppliers where supl_name = N'" & strSupplier.Trim & "'"
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Suppl_ID = SuppliersReader.Item("SUPL_CODE").ToString.Trim
                Supplier_Name = SuppliersReader.Item("SUPL_NAME").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("SUPL_BALANCE").ToString.Trim)
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        Else
            Opn_Bal = 0
        End If

        Trans_ID = GenerateMax_ID("SUPPLIERS_JOURNAL", "SUPL_TR_ID")
        Clo_Bal = Opn_Bal + TotalAmount

        Dim cmdText As String = _
           ("INSERT INTO SUPPLIERS_JOURNAL VALUES ('" & Suppl_ID & "','" & Format(Date.Parse(txtDate.Text.ToString), "MM/dd/yyyy") & "','" & Trans_ID & "','" & Supplier_Name.ToString.Trim & "','" & "Purchases (" & strDesc.Trim & ") Qty. (" & Total_Qty & ")'," & Opn_Bal & ",0," & TotalAmount & "," & Clo_Bal & ",'" & Format(Date.Parse(strDate.ToString), "MM/dd/yyyy") & "')")

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

    Private Sub BindingNavigatorRefreshItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorRefreshItem.Click
        Call RefreshGridView()
        Call RefreshInputControls()
        editmode = False
    End Sub

    Private Sub PurchaseDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PurchaseDataGridView.CellClick
        'Call BindingNavigatorRefreshItem_Click(sender, e)
    End Sub

    Private Sub PurchaseDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PurchaseDataGridView.KeyUp
        If e.KeyCode = Keys.F8 Then
            'Move values from datagrid to variables for deletion
            If PurchaseDataGridView.RowCount = 0 Then gblMessage = "No data to delete" : MsgStatus.ShowDialog(Me) : Exit Sub
            If PurchaseDataGridView.CurrentRow.Cells(12).Value.ToString = "PURCHASE" Then
                Dim DeleteID As String = PurchaseDataGridView.CurrentRow.Cells(0).Value.ToString
                Dim DeleteString As String = PurchaseDataGridView.CurrentRow.Cells(3).Value.ToString
                Dim DeleteDate As String = PurchaseDataGridView.CurrentRow.Cells(2).Value.ToString
                'Validate deletion if true then show the message on screen.
                Dim mResult As String = MsgBox("Are you sure ot delete " & DeleteString, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Entry")
                If mResult = MsgBoxResult.Yes Then
                    ExecuteAdapterQuery(SqlDataAdapter, "DELETE FROM PURCHASE WHERE PRCH_TR_ID = " & DeleteID, Connection)
                    Call BindingNavigatorRefreshItem_Click(sender, e)
                    Call RefreshGridView()
                End If
            Else
                gblMessage = ("Product updated, Changes cannot be made, you must use purchase return option.")
                MsgStatus.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub SetReadOnly(ByVal State As String)
        For Each Obj As Object In Me.SplitContainer1.Panel1.Controls
            If Obj.GetType Is GetType(TextBox) Then
                DirectCast(Obj, TextBox).ReadOnly = State
            End If
        Next
    End Sub

    Private Sub RefreshInputControls()
        For Each Obj As Object In Me.SplitContainer1.Panel1.Controls
            If Obj.GetType Is GetType(TextBox) Then
                DirectCast(Obj, TextBox).Clear()
            End If
        Next
        Me.cmbSupplier.Text = String.Empty
        Me.txtTranID.Text = GenerateMax_ID("purchase", "prch_tr_id")
        Me.txtPPrice.Text = "0"
        Me.txtQty.Text = "0"
        Me.BindingNavigatorSave.Enabled = False
        Me.txtDate.Focus()
    End Sub

    Private Sub ToolStripLabelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Get_Text_Values() : editmode = True
    End Sub

    Private Sub ToolStripButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonEdit.Click
        Call Get_Text_Values()
    End Sub

    Private Sub ToolStripButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonDelete.Click
        If PurchaseDataGridView.RowCount = 0 Then gblMessage = "No data to delete" : MsgStatus.ShowDialog(Me) : Exit Sub
        If PurchaseDataGridView.CurrentRow.Cells(15).Value.ToString = "PURCHASE" Then
            Dim DeleteID As String = PurchaseDataGridView.CurrentRow.Cells(0).Value.ToString
            Dim DeleteString As String = PurchaseDataGridView.CurrentRow.Cells(3).Value.ToString
            Dim DeleteDate As String = PurchaseDataGridView.CurrentRow.Cells(2).Value.ToString
            'Validate deletion if true then show the message on screen.
            Dim mResult As String = MsgBox("Are you sure ot delete " & DeleteString, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Entry")
            If mResult = MsgBoxResult.Yes Then
                ExecuteAdapterQuery(SqlDataAdapter, "DELETE FROM PURCHASE WHERE PRCH_TR_ID = " & DeleteID, Connection)
                Call BindingNavigatorRefreshItem_Click(sender, e)
                Call RefreshGridView()
            End If
        Else
            gblMessage = ("Product updated, Changes cannot be made, you must use purchase return option.")
            MsgStatus.ShowDialog(Me)
        End If
    End Sub

#End Region
End Class
