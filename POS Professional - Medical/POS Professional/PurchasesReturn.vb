Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class PurchasesReturn
    Dim SearchPrchQuery, SearchProdQuery, gblQuery As String
    Dim Max_ID, Supplr_ID As Integer
    Dim drag, newrec, updatable, editmode, DataFinalize, GridEdit, Databind As Boolean
    Dim OldPPrie, OldSalePrice, OldQuantity, NewQuantity As Double
    Dim mousex, mousey As Integer

    Private Sub frmPurchReturn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F10 Then Call BindingNavigatorSaveItem_Click(sender, e)
        If e.KeyCode = Keys.F8 Then Call Delete_DataRow()
    End Sub

    Private Sub frmPurchReturn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmPurchReturn_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmPurchReturn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PurchReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 8)
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + cmdClose.Width + 8)
        Call GetConnectionString()
        editmode = False
        Databind = False
        ProcessTransaction("delete from purchase where prch_status = 'PURCHASE'")
    End Sub

    Private Sub RefreshGridView()
        'Retrieve Records for datagrid view from purchase table
        PurchaseDataSet.Clear()
        'Dim PurchasesQuery As String = "SELECT * FROM PURCHASE WHERE (PRCH_STATUS = N'RETURN')"
        Dim PurchasesQuery As String = gblQuery & " and prch_status = 'STOCKED'"
        ExecuteAdapterQuery(PurchaseAdapter, PurchasesQuery, Connection)
        PurchaseAdapter.Fill(Me.PurchaseDataSet, "PURCHASE")
        BindingNavigatorRefreshItem.Enabled = True
        Me.PurchaseBindingSource.DataSource = Me.PurchaseDataSet
        Me.PurchaseBindingSource.DataMember = "PURCHASE"
        Me.PurchaseDataGridView.Refresh()
        Me.BindingNavigatorSaveItem.Enabled = True

        If Databind = False Then
            txtCode.DataBindings.Add("text", PurchaseBindingSource, "prch_prod_cd")
            txtInvoice.DataBindings.Add("text", PurchaseBindingSource, "prch_invoice")
            txtPPrice.DataBindings.Add("text", PurchaseBindingSource, "prch_price")
            'txtQty.DataBindings.Add("text", PurchaseBindingSource, "prch_qty")
            txtDesc.DataBindings.Add("text", PurchaseBindingSource, "prch_desc")
            txtSupplier.DataBindings.Add("text", PurchaseBindingSource, "prch_supplier")
            Databind = True
        End If

        'Retrieve Records for datagrid view from product table
        ReturnDataSet.Clear()
        Dim ReturnQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_STATUS = 'RETURNED'"
        ExecuteAdapterQuery(ProductAdapter, ReturnQuery, Connection)
        ProductAdapter.Fill(Me.ReturnDataSet, "PURCHASE")
        Me.ReturnBindingSource.DataSource = Me.ReturnDataSet
        Me.ReturnBindingSource.DataMember = "PURCHASE"
        Me.dgvPrchReturn.Refresh()
    End Sub

    Private Sub txtIvoice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoice.GotFocus
        Call Get_Property_GotFocus(txtInvoice)
    End Sub

    Private Sub txtInvoice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvoice.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtInvoice)
    End Sub

    Private Sub txtInvoice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoice.LostFocus
        Call Get_Property_LostFocus(txtInvoice)
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        Call Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            gblQuery = "SELECT * FROM PURCHASE WHERE prch_prod_cd = N'" & txtCode.Text.Trim & "'"
            Call RefreshGridView()
        End If
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

    Private Sub txtSupplier_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplier.GotFocus
        Call Get_Property_GotFocus(txtSupplier)
    End Sub

    Private Sub txtSuppiler_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSupplier.LostFocus
        Call Get_Property_LostFocus(txtSupplier)
    End Sub

    Private Sub txtDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.GotFocus
        Call Get_Property_GotFocus(txtDesc)
    End Sub

    Private Sub txtDesc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.LostFocus
        Call Get_Property_LostFocus(txtDesc)
    End Sub

    Private Sub BindingNavigatorRefreshItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorRefreshItem.Click
        Call RefreshTextBoxes()
        Me.txtCode.Clear()
        editmode = False
        txtCode.ReadOnly = False
        Me.txtCode.Focus()
    End Sub

    Private Sub RefreshTextBoxes()
        'REFRESH FIELDS FOR NEW RECORD
        Me.txtDate.Value = Now
        Me.dtpReturn.Value = Now
        Me.txtSupplier.Clear()
        Me.txtDesc.Clear()
        Me.txtCode.Clear()
        Me.txtInvoice.Clear()
        Me.txtPPrice.Text = "0"
        Me.txtQty.Text = "0"
    End Sub

    Private Sub Delete_DataRow()
        'Move values from datagrid to variables for deletion
        If editmode = False Then
            If PurchaseDataGridView.RowCount = 0 Then gblMessage = "No data to delete" : MsgStatus.ShowDialog(Me) : Exit Sub
            Dim DeleteID As String = PurchaseDataGridView.CurrentRow.Cells(0).Value.ToString
            Dim DeleteString As String = PurchaseDataGridView.CurrentRow.Cells(2).Value.ToString
            Dim DeleteDate As String = PurchaseDataGridView.CurrentRow.Cells(1).Value.ToString

            If PurchaseDataGridView.CurrentRow.Cells(0).Value Is Nothing Then Exit Sub
            'Validate deletion if true then show the message on screen.
            If ValidateDelete(DeleteString, DeleteDate) = False Then
                Dim mResult As String = MsgBox("Are you sure ot delete " & DeleteString, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Entry")
                If mResult = MsgBoxResult.Yes Then
                    ExecuteAdapterQuery(SqlDataAdapter, "DELETE FROM PURCHASE WHERE PRCH_TR_ID = N'" & DeleteID & "' AND PRCH_STATUS != N'PURCHASE' AND PRCH_PROD_CD = N'" & DeleteString.Trim & "' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(DeleteDate), "yyyy-MM-dd") & " 00:00:00',102)", Connection)
                    Call RefreshTextBoxes()
                    Call RefreshGridView()
                    txtCode.Clear()
                    txtCode.Focus()
                End If
            Else
                gblMessage = ("Product updated, Changes cannot be made now, you must be use purchase return option.")
                MsgStatus.ShowDialog(Me)
            End If
        Else
            gblMessage = "You are in edit mode. click refresh to disable."
            MsgStatus.ShowDialog(Me)
        End If

    End Sub

    Private Function ValidateDelete(ByVal strFind As String, ByVal strDate As String) As Boolean
        'Function to check status of purchases transactions
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("SELECT * FROM PURCHASE WHERE (PRCH_PROD_CD = N'" & strFind.Trim & "' AND PRCH_STATUS = N'UPDATED' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(strDate.Trim), "yyyy-MM-dd") & " 00:00:00',102))")

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

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        Dim UpdtRecQuery As String = String.Empty
        Dim Clos_Balance As String = String.Empty
        Max_ID = 0
        If PurchaseDataGridView.CurrentRow.Cells(10).Value.ToString = "STOCKED" And Val(txtQty.Text.Trim) <= Val(PurchaseDataGridView.CurrentRow.Cells(8).Value.ToString) Then
            'Final Routine to update the products from purchases by date
            Dim TransferQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_STATUS = N'STOCKED' AND PRCH_PROD_CD = '" & txtCode.Text.Trim & "' AND PRCH_INVOICE = " & Val(txtInvoice.Text.Trim) & " ORDER BY PRCH_TR_ID"
            ExecuteAdapterQuery(TransferAdapter, TransferQuery, Connection)
            Dim TransferReader As SqlDataReader = TransferAdapter.SelectCommand.ExecuteReader
            If TransferReader.HasRows Then
                While TransferReader.Read
                    UpdtRecQuery = String.Empty
                    If CheckRecordExists(TransferReader.Item("PRCH_PROD_CD").ToString, "PRODUCTS", "PROD_CODE") = True Then
                        'UPDATE RECORD INTO PRODUCT TABLE
                        UpdtRecQuery = "UPDATE PRODUCTS SET " & _
                                                    "PROD_STOCK = PROD_STOCK - " & (Val(txtQty.Text.Trim) * Val(TransferReader.Item("PRCH_QTY_PER_UNIT").ToString)) & ", " & _
                                                    "PROD_UPD_ON = '" & Format(Date.Parse(dtpReturn.Text.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                                    "WHERE (PROD_CODE = N'" & TransferReader.Item("PRCH_PROD_CD").ToString & "')"
                    End If
                    ExecuteAdapterQuery(TransferAdapter, UpdtRecQuery, Connection)
                    'Get Total Return quantity and amount
                    Dim Total_Amount As Double = Val(TransferReader.Item("PRCH_PRICE").ToString) * (Val(txtQty.Text.Trim) * Val(TransferReader.Item("PRCH_QTY_PER_UNIT").ToString))
                    Dim Total_Quantity As Double = Val(txtQty.Text.Trim) * -1
                    ' To update journal transactions for update balance
                    'Call Updt_General_Journal(Total_Amount, Total_Quantity, TransferReader.Item("prch_supplier").ToString.Trim, TransferReader.Item("PRCH_DATE").ToString, TransferReader.Item("PRCH_DESC").ToString)
                    If CheckRecordExists(TransferReader.Item("PRCH_SUPPLIER").ToString, "SUPPLIERS", "SUPL_NAME") = True Then
                        Clos_Balance = "UPDATE suppliers SET " & _
                                                    "supl_balance = supl_balance - " & Total_Amount & ", " & _
                                                    "supl_UPD_dt = '" & Format(Date.Parse(dtpReturn.Text.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                                    "WHERE (supl_name = N'" & TransferReader.Item("PRCH_SUPPLIER").ToString.Trim & "')"
                        'ExecuteAdapterQuery(SqlDataAdapter, Clos_Balance, Connection)
                    End If
                    'Update purchase table with return transaction
                    Call GetProductStock()
                    Max_ID = GenerateMax_ID("purchase", "prch_tr_id")
                    ProcessTransaction("insert into purchase (PRCH_TR_ID,PRCH_INVOICE,PRCH_DATE,PRCH_PROD_CD,PRCH_DESC,PRCH_SUPPLIER,PRCH_HEAD,PRCH_CATG,PRCH_SUB_CATG,PRCH_PACK,PRCH_QTY,PRCH_OLD_QTY,PRCH_PRICE,PRCH_STATUS,PRCH_QTY_PER_UNIT,PRCH_OLD_PRICE) " & _
                                       "select " & Val(Max_ID) & ",PRCH_INVOICE,'" & Format(Date.Parse(dtpReturn.Text.ToString.Trim), "MM/dd/yyyy") & "','" & txtCode.Text.Trim.ToUpper & "','" & txtDesc.Text.ToUpper.ToUpper & "',PRCH_SUPPLIER,PRCH_HEAD,PRCH_CATG,PRCH_SUB_CATG,PRCH_PACK," & Total_Quantity & "," & OldQuantity & "," & Total_Amount & ",'RETURNED',PRCH_QTY_PER_UNIT,PRCH_OLD_PRICE from purchase " & _
                                       "where PRCH_STATUS = N'STOCKED' AND PRCH_PROD_CD = '" & txtCode.Text.Trim & "' AND PRCH_INVOICE = " & Val(txtInvoice.Text.Trim))
                    Total_Amount = Nothing
                End While
                If TransferReader Is Nothing Then TransferReader.Close()
                BindingNavigatorSaveItem.Enabled = False
                DataFinalize = True
            End If
            GridEdit = False
            Call RefreshGridView()
        Else
            MsgBox("No Product selected for return /" & vbCrLf & "Quantity is more than purchased.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub Updt_General_Journal(ByVal TotalAmount As Double, ByVal Total_Qty As Double, ByVal strSupplier As String, ByVal strDate As String, ByVal strDesc As String)
        'Function to add item if does not exist in item table.
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim Trans_ID, Opn_Bal, Clo_Bal As Double
        Dim Supplier_Name As String = ""
        Trans_ID = 0
        Opn_Bal = 0
        Clo_Bal = 0
        ' To made general journal transaction for concerned suppliers while update products
        Dim Max_Tr As Double = GenerateMax_ID("SUPPLIERS_JOURNAL", "SUPL_TR_ID")

        Dim Get_Supplier As String = "select * from suppliers where supl_name = '" & strSupplier & "'"
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Supplier_Name = SuppliersReader.Item("SUPL_NAME").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("SUPL_BALANCE").ToString.Trim)
                Supplr_ID = SuppliersReader.Item("supl_code").ToString.Trim
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        Else
            Opn_Bal = 0
        End If

        Trans_ID = GenerateMax_ID("SUPPLIERS_JOURNAL", "SUPL_TR_ID")
        Clo_Bal = Opn_Bal - TotalAmount

        Dim cmdText As String = _
           ("INSERT INTO SUPPLIERS_JOURNAL VALUES ('" & Supplr_ID & "','" & Format(Date.Parse(txtDate.Text.ToString), "MM/dd/yyyy") & "','" & Trans_ID & "','" & Supplier_Name & "','" & "Purchases (" & strDesc.Trim & ") returns (" & Total_Qty & ")'," & Opn_Bal & "," & TotalAmount & ",0," & Clo_Bal & ",'" & Format(Date.Parse(strDate.ToString), "MM/dd/yyyy") & "')")

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                'Try
                sqlCmd.ExecuteScalar()
                'Catch ex As Exception
                '    MsgBox(ex.Message, MsgBoxStyle.Information)
                'End Try
            End Using
        End Using
    End Sub

    Private Sub ValidatePurchases(ByVal strFind As String, ByVal strDate As String)
        'Procedure to update status of purchases to avoid duplication
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("UPDATE PURCHASE SET PRCH_STATUS = N'UPDATED' WHERE (PRCH_PROD_CD = N'" & strFind.Trim & "' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(strDate.Trim), "yyyy-MM-dd") & " 00:00:00',102))")

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader

                End Using
            End Using
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

    Public Function Supplier_ID(ByVal strName As String) As Integer
        Dim ID_Text As String = "SELECT SUPL_CODE FROM SUPPLIERS WHERE SUPL_NAME = N'" & strName.Trim & "'"
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(ID_Text, Conn)
            'Try
            Conn.Open()
            If IsDBNull(Cmd.ExecuteScalar()) Then
                Supplier_ID = 0
            Else
                Supplier_ID = Convert.ToDecimal(Cmd.ExecuteScalar())
            End If
            'Catch EX As Exception
            '    MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            'End Try
            Return Supplier_ID
        End Using
    End Function

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then txtSupplier.Focus()
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        'Search Record by Date
        gblQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
        'Call GetProductInfo("SELECT * FROM PURCHASE WHERE PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)")
        Call RefreshGridView()
    End Sub

    Private Sub cmdFindByCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Search Record by Product Code
        If txtCode.Text = "" Or Len(txtCode.Text.Trim) = 0 Then MsgBox("Please enter valid product.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        'Call GetProductInfo("SELECT * FROM PURCHASE WHERE prch_prod_cd = N'" & txtCode.Text.Trim & "'")
        gblQuery = "SELECT * FROM PURCHASE WHERE prch_prod_cd = N'" & txtCode.Text.Trim & "'"
        Call RefreshGridView()
    End Sub

    Private Sub GetProductInfo(ByVal SearchQuery As String)
        ExecuteAdapterQuery(SqlDataAdapter, SearchQuery, Connection)
        Dim SearchReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If SearchReader.HasRows Then
            While SearchReader.Read
                txtCode.Text = SearchReader.Item("prch_prod_cd").ToString
                txtInvoice.Text = SearchReader.Item("prch_invoice").ToString
                txtSupplier.Text = SearchReader.Item("prch_supplier").ToString
                txtDate.Value = SearchReader.Item("prch_date").ToString
            End While
            If SearchReader Is Nothing Then SearchReader.Close()
        End If
    End Sub

    Private Sub cmdFindByInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindByInvoice.Click
        If txtInvoice.Text.Trim = "" Or Len(txtInvoice.Text.Trim) = 0 Then MsgBox("Please enter valid product.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        gblQuery = "SELECT * FROM PURCHASE WHERE prch_invoice = N'" & txtInvoice.Text.Trim & "'"
        Call RefreshGridView()
    End Sub

    Private Sub GetProductStock()
        ExecuteAdapterQuery(SqlDataAdapter, "select * from products where prod_code = '" & txtCode.Text.Trim & "'", Connection)
        Dim SearchReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If SearchReader.HasRows Then
            While SearchReader.Read
                OldQuantity = Val(SearchReader.Item("prod_stock").ToString)
            End While
            If SearchReader Is Nothing Then SearchReader.Close()
        End If
    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        Call Get_Property_GotFocus(txtQty)
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        Call Get_Property_LostFocus(txtQty)
    End Sub
End Class