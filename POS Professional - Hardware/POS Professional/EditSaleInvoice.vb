Imports System.Data.SqlClient

Public Class EditSaleInvoice
    Dim FoundItem As Boolean
    Dim TotalQty, SortID As Integer
    Dim Items, ItemUpdate, SaleType As String
    Dim CodeList As New List(Of String)()
    Dim ItemQty As New List(Of Integer)()
    Dim DebitAmount, CreditAmount, ProdPrice, FinalAmount, wGross, wTotal, wDiscount, wPaid, wDues As Double

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If Len(txtSearch.Text.Trim) = 0 Or txtSearch.Text.Trim = String.Empty Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            ExecuteAdapterQuery(SqlDataAdapter, "select * from sale_master where saleid = '" & txtSearch.Text.Trim & "'", Connection)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    txtCustID.Text = Reader.Item("customerid").ToString
                    txtName.Text = Reader.Item("customername").ToString
                    txtType.Text = Reader.Item("saletype").ToString
                    txtGross.Text = Reader.Item("salegross").ToString
                    txtTotal.Text = Reader.Item("saletotal").ToString
                    txtPayment.Text = Reader.Item("salepaid").ToString
                    txtDiscount.Text = Reader.Item("salediscount").ToString
                    txtDues.Text = Reader.Item("salecredit").ToString
                    'Shift SaleInvoice for Edit
                    Dim GetHoldInfo As String = "SELECT * from POS.dbo.SALE_DETAIL WHERE SaleID = N'" & txtSearch.Text.Trim & "' order by sortitem"
                    ExecuteAdapterQuery(SqlDataAdapter, GetHoldInfo, Connection)
                    Dim HoldInfoReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                    If HoldInfoReader.HasRows = True Then
                        If Me.SaleDataGrid.Rows.Count > -1 Then
                            For i As Integer = Me.SaleDataGrid.Rows.Count - 1 To 0 Step -1
                                Me.SaleDataGrid.Rows.RemoveAt(i)
                            Next
                        End If
                        'Fill the datagrid
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
                            ItemRow.Cells(10).Value = HoldInfoReader.Item("itemdues").ToString
                        End While
                        If HoldInfoReader Is Nothing Then HoldInfoReader.Close()
                    End If
                End While
                If Reader Is Nothing Then Reader.Close()
                btnUpdate.Enabled = True
                txtSearch.Enabled = False
                SaleDataGrid.Enabled = True
                txtItemCode.Enabled = True
                txtItemCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        Call ValidateAlphaNumOnly(sender, e)
    End Sub

    Private Sub EditSaleInvoice_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSearch.Focus()
    End Sub

    Private Sub EditSaleInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        DebitAmount = 0
        CreditAmount = 0
        FoundItem = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SaleDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SaleDataGrid.CellContentClick
        If e.ColumnIndex = 6 Then
            CodeList.Add(SaleDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString)
            ItemQty.Add(Val(SaleDataGrid.Rows(e.RowIndex).Cells(4).Value.ToString))
            SaleDataGrid.Rows.RemoveAt(e.RowIndex)
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            FoundItem = False
            'Update item quantity if same item enter again in product code textbox
            If SaleDataGrid.RowCount > 0 Then
                For Each row As DataGridViewRow In SaleDataGrid.Rows
                    If row.Cells(0).Value.ToString.ToUpper.Trim = txtItemCode.Text.Trim Then
                        SaleDataGrid.Rows(row.Index).Selected = True
                        SaleDataGrid.Rows(row.Index).Cells(4).Value = Val(SaleDataGrid.Rows(row.Index).Cells(4).Value.ToString) + 1
                        SaleDataGrid.Rows(row.Index).Cells(5).Value = Val(SaleDataGrid.Rows(row.Index).Cells(3).Value.ToString) * Val(SaleDataGrid.Rows(row.Index).Cells(4).Value.ToString)
                        FoundItem = True
                    End If
                Next
            End If
            Dim TempDetailSale As String = ""
            Dim StockInfo As String = "select * from products where PROD_CODE = N'" & txtItemCode.Text.Trim & "'"
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
                        ItemRow.Cells(0).Value = GetStockInfo.Item("prod_code").ToString.Trim
                        ItemRow.Cells(1).Value = GetStockInfo.Item("prod_desc").ToString.Trim
                        ItemRow.Cells(2).Value = GetStockInfo.Item("prod_packing").ToString.Trim
                        ItemRow.Cells(3).Value = ProdPrice
                        ItemRow.Cells(4).Value = 1
                        ItemRow.Cells(5).Value = ProdPrice * Val(1)
                        ItemRow.Cells(6).Value = "X"
                        ItemRow.Cells(7).Value = GetStockInfo.Item("prod_head").ToString.Trim
                        ItemRow.Cells(8).Value = GetStockInfo.Item("prod_catg").ToString.Trim
                        ItemRow.Cells(9).Value = GetStockInfo.Item("prod_sub_catg").ToString.Trim
                    End If
                    txtItemCode.Focus()
                    txtItemCode.Clear()
                    btnUpdate.Enabled = True
                End While
                If GetStockInfo Is Nothing Then GetStockInfo.Close()
            Else
                gblMessage = "Prodcut not available, Please check Stock."
                MsgStatus.ShowDialog(Me)
                txtItemCode.Clear()
                txtItemCode.Focus()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtItemCode.Clear()
        txtSearch.Clear()
        txtSearch.Enabled = True
        txtCustID.Text = String.Empty
        txtName.Text = String.Empty
        txtType.Text = String.Empty
        txtGross.Text = String.Empty
        txtTotal.Text = String.Empty
        txtPayment.Text = String.Empty
        txtDiscount.Text = String.Empty
        txtDues.Text = String.Empty
        If Me.SaleDataGrid.Rows.Count > -1 Then
            For i As Integer = Me.SaleDataGrid.Rows.Count - 1 To 0 Step -1
                Me.SaleDataGrid.Rows.RemoveAt(i)
            Next
        End If
        txtSearch.Enabled = True
        txtItemCode.Enabled = False
        SaleDataGrid.Enabled = False
        btnUpdate.Enabled = False
        txtSearch.Focus()
    End Sub

    Private Sub rbRetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRetail.Click
        txtItemCode.Focus()
    End Sub

    Private Sub rbWholeSale_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbWholeSale.Click
        txtItemCode.Focus()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If SaleDataGrid.RowCount = 0 Then
            MsgBox("Invoice cannot be updated without items.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        End If
        Dim CashPay As String = String.Empty
        wGross = 0
        wDiscount = 0
        wTotal = 0
        wPaid = 0
        wDues = 0
        If SaleDataGrid.RowCount > -1 Then
            Dim TotalAmount As Double = 0.0
            For Each row As DataGridViewRow In SaleDataGrid.Rows
                TotalAmount += Format(Val(row.Cells(5).Value.ToString.Trim), "0.00")
            Next
            FinalAmount = Format(TotalAmount, "0.00")
        End If
        gblNet = FinalAmount
        EditPayment.ShowDialog(Me)
        If gblNet = 0 Then Exit Sub
        wGross = FinalAmount
        wDiscount = gblDiscount
        wTotal = FinalAmount - wDiscount
        wPaid = gblPayment
        wDues = gblDues
        If gblNet > 0 Then
            If txtType.Text <> "ACCOUNT" Then SaleType = "CASH" Else SaleType = "ACCOUNT"
            SortID = 0
            ProcessTransaction("update sale_master set salegross=" & wGross & ", salediscount=" & wDiscount & ", saletotal=" & wTotal & ", salepaid=" & wPaid & ", salecredit=" & wDues & " where saleid=N'" & txtSearch.Text.Trim & "'")
            If SaleDataGrid.RowCount > -1 Then
                Dim DelProductAdapter As New SqlDataAdapter
                ExecuteAdapterQuery(DelProductAdapter, "select * from sale_detail where saleid = N'" & txtSearch.Text.Trim & "'", Connection)
                Dim DelProductReader As SqlDataReader = DelProductAdapter.SelectCommand.ExecuteReader
                If DelProductReader.HasRows Then
                    While DelProductReader.Read
                        ProcessTransaction("update products set prod_stock = prod_stock + " & Val(DelProductReader.Item("qty").ToString) & " where prod_code = N'" & DelProductReader.Item("stockid").ToString & "'")
                    End While
                    If DelProductReader Is Nothing Then DelProductReader.Close()
                End If
                ProcessTransaction("delete from sale_detail where saleid = N'" & txtSearch.Text.Trim & "'")
                TotalQty = 0
                Items = String.Empty
                For Each OutRow As DataGridViewRow In SaleDataGrid.Rows
                    ExecuteAdapterQuery(SqlDataAdapter, "select * from sale_detail where saleid = N'" & txtSearch.Text.Trim & "' and stockid = '" & OutRow.Cells(0).Value.ToString & "'", Connection)
                    Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                    If Checker.HasRows = True Then
                        ItemUpdate = "UPDATE SALE_DETAIL SET " & _
                                     "DETAILID = '" & txtSearch.Text.Trim & Format(Date.Parse(Now.Date), "MMddyyyy") & "', " & _
                                     "DETAILDATE = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "', " & _
                                     "CUSTOMERID = " & Val(txtCustID.Text.Trim) & ", " & _
                                     "CUSTOMERNAME = '" & txtName.Text.Trim & "', " & _
                                     "UNITCOST = " & OutRow.Cells(3).Value.ToString & ", " & _
                                     "QTY = " & Val(OutRow.Cells(4).Value.ToString) & ", " & _
                                     "PRICE = " & Val(OutRow.Cells(5).Value.ToString) & ", " & _
                                     "DRAWERID = " & gblPrliviges & " WHERE SALEID = N'" & txtSearch.Text.Trim & "' AND STOCKID = '" & OutRow.Cells(0).Value.ToString & "'"
                    Else
                        ItemUpdate = "INSERT INTO SALE_DETAIL VALUES ('" & _
                                     txtSearch.Text.Trim & Format(Date.Parse(Now.Date), "MMddyyyy") & "','" & _
                                     Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "','" & _
                                     txtSearch.Text.Trim & "','" & _
                                     txtType.Text.Trim & "'," & _
                                     Val(txtCustID.Text.Trim) & ",'" & _
                                     txtName.Text.Trim & "','" & _
                                     OutRow.Cells(0).Value.ToString & "','" & _
                                     OutRow.Cells(1).Value.ToString & "','" & _
                                     OutRow.Cells(2).Value.ToString & "'," & _
                                     OutRow.Cells(3).Value.ToString & "," & Val(OutRow.Cells(4).Value.ToString) & "," & _
                                     Val(OutRow.Cells(5).Value.ToString) & ",'" & SaleType & "','" & _
                                     gblPrliviges & "',0,0,'" & OutRow.Cells(7).Value.ToString & "','" & OutRow.Cells(8).Value.ToString & "',0,'x'," & SortID & ",'" & OutRow.Cells(9).Value.ToString & "'," & Val(OutRow.Cells(5).Value.ToString) & ")"

                    End If
                    If Checker Is Nothing Then Checker.Close()
                    ProcessTransaction(ItemUpdate)
                    ProcessTransaction("update products set prod_stock = prod_stock - " & Val(OutRow.Cells(4).Value.ToString) & " where prod_code = N'" & OutRow.Cells(0).Value.ToString & "'")
                    SortID += 1
                    TotalQty = TotalQty + Val(OutRow.Cells(4).Value.ToString)
                    Items = OutRow.Cells(1).Value.ToString & ","
                Next OutRow
            End If
            Call btnRefresh_Click(sender, e)
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub SaleDataGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SaleDataGrid.CellDoubleClick
        If e.ColumnIndex = 4 Then
            If SaleDataGrid.RowCount > 0 Then
                Dim SaleQty As String = InputBox("Enter quantity to update", "Quantity Update", "0")
                If SaleQty.Trim = "" Then txtItemCode.Focus() : Exit Sub
                If IsNumeric(SaleQty.Trim) And Val(SaleQty.Trim) > 0 Then
                    SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(4).Value = Val(SaleQty)
                    SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(5).Value = Val(SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(3).Value.ToString) * Val(SaleDataGrid.Rows(SaleDataGrid.CurrentRow.Index).Cells(4).Value.ToString)
                End If
                txtItemCode.Focus()
            End If
        End If
        If e.ColumnIndex = 1 Then
            With SaleDataGrid
                ExtendDescription.ShowDialog()
                If gblExtDesc <> String.Empty Then .Rows(.CurrentRow.Index).Cells(1).Value = .Rows(.CurrentRow.Index).Cells(1).Value.ToString & Space(1) & gblExtDesc
                If Val(gblExtPrice) > 0 Then
                    .Rows(.CurrentRow.Index).Cells(3).Value = Val(.Rows(.CurrentRow.Index).Cells(3).Value.ToString) + Val(gblExtPrice)
                    .Rows(.CurrentRow.Index).Cells(5).Value = Val(.Rows(.CurrentRow.Index).Cells(4).Value.ToString) * Val(gblExtPrice)
                End If
            End With
        End If
    End Sub

    Private Sub txtItemCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            ProductCode.ShowDialog()
            If Len(gblItemCode) > 0 Then txtItemCode.Text = gblItemCode.ToUpper Else txtItemCode.Clear()
            txtItemCode.Focus()
        End If
    End Sub

    Private Sub txtCustID_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustID.DoubleClick
        CustomerCode.ShowDialog(Me)
        If gblCP_ID = String.Empty Then Exit Sub
        txtCustID.Text = gblCP_ID.Trim
        txtName.Text = gblCP.Trim
    End Sub
End Class