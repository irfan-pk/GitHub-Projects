Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Products
    Dim drag, EditMode, UpdtMode As Boolean
    Dim PPrice As Double
    Dim mousex, mousey, Pos As Integer

    Private Sub frmProducts_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmProducts_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmProducs_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 8)
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + cmdClose.Width + 8)
        Call SetReadOnly("True")
        Call GetConnectionString()
        Call LoadData()
    End Sub

    Private Sub LoadData()
        Try
            'Retrieve Records for datagrid view from product table
            Me.ProductDataSet.Clear()
            cmbCatg.Items.Clear()
            cmbSubCatg.Items.Clear()

            Dim DepartmentSqlAdapter As New SqlDataAdapter
            ExecuteAdapterQuery(DepartmentSqlAdapter, "select * from departments order by head_category", Connection)
            Dim DeptReader As SqlDataReader = DepartmentSqlAdapter.SelectCommand.ExecuteReader
            If DeptReader.HasRows Then
                While DeptReader.Read
                    cmbDepartment.Items.Add(DeptReader.Item("head_category").ToString)
                End While
                If DeptReader Is Nothing Then DeptReader.Close()
            End If

            Dim CategorySqlAdapter As New SqlDataAdapter
            ExecuteAdapterQuery(CategorySqlAdapter, "select distinct category from category order by category", Connection)
            Dim Reader As SqlDataReader = CategorySqlAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    cmbCatg.Items.Add(Reader.Item("category").ToString)
                End While
                If Reader Is Nothing Then Reader.Close()
            End If

            Dim SubCategorySqlAdapter As New SqlDataAdapter
            ExecuteAdapterQuery(SubCategorySqlAdapter, "select distinct sub_category from category order by sub_category", Connection)
            Dim SubReader As SqlDataReader = SubCategorySqlAdapter.SelectCommand.ExecuteReader
            If SubReader.HasRows Then
                While SubReader.Read
                    cmbSubCatg.Items.Add(SubReader.Item("sub_category").ToString)
                End While
                If SubReader Is Nothing Then SubReader.Close()
            End If

            Dim ProductQuery As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CODE"
            ExecuteDatasetQuery(ProductAdapter, Me.ProductDataSet, ProductQuery, "PRODUCTS", Connection)
            ProductBindingSource.DataSource = Me.ProductDataSet
            ProductBindingSource.DataMember = "PRODUCTS"
            txtProdID.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_CODE")
            txtDesc.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_DESC")
            cmbDepartment.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_HEAD")
            cmbCatg.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_CATG")
            cmbSubCatg.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_SUB_CATG")
            cmbPackage.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_PACKING")
            txtUnitPack.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_QTY_PER_UNIT")
            txtPackQty.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_UNITS")
            txtStock.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_STOCK")
            txtMinBal.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_BAL_MIN")
            txtPurchPrice.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_PURCH_PRICE")
            txtSalePrice.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_SALE_PRICE")
            txtWholeSale.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_WSALE_PRICE")
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub RefreshDB()
        Try
            Me.ProductDataSet.Clear()
            SqlDataAdapter.Dispose()
            Dim QueryText As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CODE"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, QueryText, "PRODUCTS", Connection)
            SqlDataAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            Me.ProductBindingSource.DataSource = Me.ProductDataSet
            Me.ProductBindingSource.DataMember = "PRODUCTS"
            Me.ProductDataGridView.Update()
            Me.ProductDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub BindingNavigatorEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEdit.Click
        If ProductDataGridView.Rows.Count > 0 Then
            If BindingNavigatorEdit.Text = "&Edit" Then
                EditMode = True
                gblFind = ProductDataGridView.CurrentRow.Cells(0).Value.ToString
                Call SetReadOnly("False")
                Call Enable_Disable_Controls("False")
                BindingNavigatorEdit.Text = "&Cancel"
                BindingNavigatorUpdate.Enabled = True
                ProductDataGridView.Enabled = False
                EditMode = True
                UpdtMode = False
                txtProdID.Focus()
            Else
                EditMode = False
                Call SetReadOnly("True")
                Call Enable_Disable_Controls("True")
                BindingNavigatorEdit.Text = "&Edit"
                BindingNavigatorUpdate.Enabled = False
                ProductDataGridView.Enabled = True
                ProductBindingSource.CancelEdit()
                Call RefreshDB()
            End If
        End If
    End Sub

    Private Sub Enable_Disable_Controls(ByVal State As String)
        BindingNavigatorMoveNextItem.Enabled = State
        BindingNavigatorMovePreviousItem.Enabled = State
        BindingNavigatorTextBox.Enabled = State
        BindingNavigatorFind.Enabled = State
        ProductDataGridView.Enabled = State
    End Sub

    Private Sub BindingNavigatorFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFind.Click
        If BindingNavigatorTextBox.Text = "" Then MsgBox("Please give valid product code.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName) : Exit Sub
        Dim strCode As String
        strCode = BindingNavigatorTextBox.Text.Trim
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.ProductBindingSource.Find("PROD_CODE", strCode.Trim)
        If Not Pos = -1 Then
            Me.ProductBindingSource.Position = Pos
        End If
        If BindingNavigatorTextBox.Text <> "" Then
            gblFind = BindingNavigatorFind.Text.Trim
        Else
            gblFind = ProductDataGridView.CurrentRow.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub BindingNavigatorTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub

    Private Sub txtProdID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdID.GotFocus
        Call Get_Property_GotFocus(txtProdID)
    End Sub

    Private Sub txtProdID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProdID.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtProdID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdID.LostFocus
        Call Get_Property_LostFocus(txtProdID)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        If Not (e.KeyChar = "-" Or e.KeyChar = "/" Or e.KeyChar = "." Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.GotFocus
        Call Get_Property_GotFocus(txtDesc)
    End Sub

    Private Sub txtDesc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.LostFocus
        Call Get_Property_LostFocus(txtDesc)
        txtDesc.Text = StrConv(txtDesc.Text.Trim, VbStrConv.ProperCase)
    End Sub

    Private Sub cmbCatg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCatg.GotFocus
        Call Get_Property_GotFocus(cmbCatg)
    End Sub

    Private Sub cmbCatg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCatg.LostFocus
        Call Get_Property_LostFocus(cmbCatg)
    End Sub

    Private Sub cmbSubCatg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubCatg.GotFocus
        Call Get_Property_GotFocus(cmbSubCatg)
    End Sub

    Private Sub cmbSubCatg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubCatg.LostFocus
        Call Get_Property_LostFocus(cmbSubCatg)
    End Sub

    Private Sub cmbPackage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPackage.GotFocus
        Call Get_Property_GotFocus(cmbPackage)
    End Sub

    Private Sub cmbPackage_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPackage.LostFocus
        Call Get_Property_LostFocus(cmbPackage)
    End Sub

    Private Sub txtUnitPack_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnitPack.GotFocus
        Call Get_Property_GotFocus(txtUnitPack)
    End Sub

    Private Sub txtUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnitPack.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtUnit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnitPack.LostFocus
        Call Get_Property_LostFocus(txtUnitPack)
    End Sub

    Private Sub txtPackQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPackQty.GotFocus
        Call Get_Property_GotFocus(txtPackQty)
    End Sub

    Private Sub txtPackQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackQty.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtPackQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPackQty.LostFocus
        Call Get_Property_LostFocus(txtPackQty)
        txtStock.Text = Val(txtUnitPack.Text.Trim) * Val(txtPackQty.Text.Trim)
    End Sub

    Private Sub txtMinBal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinBal.GotFocus
        Call Get_Property_GotFocus(txtMinBal)
    End Sub

    Private Sub txtMinBal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinBal.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtMinBal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinBal.LostFocus
        Call Get_Property_LostFocus(txtMinBal)
    End Sub

    Private Sub txtPurchPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPurchPrice.GotFocus
        Call Get_Property_GotFocus(txtPurchPrice)
        txtStock.Text = Val(txtUnitPack.Text.Trim) * Val(txtPackQty.Text.Trim)
    End Sub

    Private Sub txtPurchPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurchPrice.KeyPress
        ValidateNumericKeyPress(sender, e, txtPurchPrice, txtSalePrice)
    End Sub

    Private Sub txtPurchPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPurchPrice.LostFocus
        Call Get_Property_LostFocus(txtPurchPrice)
    End Sub

    Private Sub txtSalePrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalePrice.KeyPress
        ValidateNumericKeyPress(sender, e, txtSalePrice, txtSalePrice)
    End Sub

    Private Sub txtSalePrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.GotFocus
        Call Get_Property_GotFocus(txtSalePrice)
    End Sub

    Private Sub txtSalePrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.LostFocus
        Call Get_Property_LostFocus(txtSalePrice)
    End Sub

    Private Sub txtWholeSale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWholeSale.KeyPress
        ValidateNumericKeyPress(sender, e, txtWholeSale, txtWholeSale)
    End Sub

    Private Sub txtWholeSale_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWholeSale.GotFocus
        Call Get_Property_GotFocus(txtWholeSale)
    End Sub

    Private Sub txtWholeSale_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWholeSale.LostFocus
        Call Get_Property_LostFocus(txtWholeSale)
    End Sub

    Private Sub BindingNavigatorUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorUpdate.Click
        If txtPurchPrice.Text.Trim = String.Empty Then txtPurchPrice.Text = "0"
        If txtSalePrice.Text.Trim = String.Empty Then txtSalePrice.Text = "0"
        If txtWholeSale.Text.Trim = String.Empty Then txtWholeSale.Text = "0"
        If ValidateFieldsData(SplitContainer1.Panel1.Controls) = False Then
            Dim UpdateQuery As String = String.Empty
            If UpdtMode = True Then
                If CheckProductExist(txtDesc.Text.Trim) = True Then MsgBox("Product already in the table.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
                UpdateQuery = "INSERT INTO PRODUCTS VALUES('" & _
                                txtProdID.Text.Trim & "'," & _
                                "'','" & _
                                txtDesc.Text.Trim.ToUpper & "','" & _
                                cmbDepartment.Text.Trim.ToUpper & "','" & _
                                cmbCatg.Text.Trim.ToUpper & "','" & _
                                cmbSubCatg.Text.Trim.ToUpper & "','" & _
                                "x" & "','" & _
                                cmbPackage.Text.Trim.ToUpper & "'," & _
                                Val(txtPackQty.Text.Trim) & "," & _
                                Val(txtUnitPack.Text.Trim) & "," & _
                                Val(txtStock.Text.Trim) & "," & _
                                Val(txtMinBal.Text.Trim) & "," & _
                                Val(txtPurchPrice.Text.Trim) & "," & _
                                Val(txtWholeSale.Text.Trim) & "," & _
                                Val(txtSalePrice.Text.Trim) & ",'" & _
                                Format(Date.Parse(Now.Date.ToString.Trim), "MM/dd/yyyy") & "'," & _
                                "1)"
            End If
            If EditMode = True Then
                UpdateQuery = "UPDATE PRODUCTS SET " & _
                                 "PROD_CODE = '" & txtProdID.Text.Trim.ToUpper & "', " & _
                                 "PROD_BAR_CODE = '" & String.Empty & "', " & _
                                 "PROD_DESC = '" & txtDesc.Text.Trim.ToUpper & "', " & _
                                 "PROD_HEAD = '" & cmbDepartment.Text.Trim.ToUpper & "', " & _
                                 "PROD_CATG = '" & cmbCatg.Text.Trim.ToUpper & "', " & _
                                 "PROD_SUB_CATG = '" & cmbSubCatg.Text.Trim.ToUpper & "', " & _
                                 "PROD_PACKING = '" & cmbPackage.Text.Trim.ToUpper & "', " & _
                                 "PROD_UNITS = " & Val(txtPackQty.Text.Trim) & ", " & _
                                 "PROD_QTY_PER_UNIT = " & Val(txtUnitPack.Text.Trim) & ", " & _
                                 "PROD_STOCK = " & Val(txtStock.Text.Trim) & ", " & _
                                 "PROD_BAL_MIN = " & Val(txtMinBal.Text.Trim) & ", " & _
                                 "PROD_PURCH_PRICE = " & Val(txtPurchPrice.Text.Trim) & ", " & _
                                 "PROD_WSALE_PRICE = " & Val(txtWholeSale.Text.Trim) & ", " & _
                                 "PROD_SALE_PRICE = " & Val(txtSalePrice.Text.Trim) & ", " & _
                                 "PROD_UPD_ON = '" & Format(Date.Parse(Now.Date.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                 "WHERE (PROD_CODE = N'" & gblFind & "')"
            End If
            ExecuteAdapterQuery(SqlDataAdapter, UpdateQuery, Connection)
        End If
        Call Enable_Disable_Controls("True")
        ProductBindingSource.ResetBindings(True)
        UpdtMode = False
        EditMode = False
        BindingNavigatorUpdate.Enabled = False
        BindingNavigatorEdit.Text = "&Edit"
        BindingNavigatorAdd.Text = "&Add"
        BindingNavigatorEdit.Enabled = True
        Call SetReadOnly("True")
        Call RefreshDB()
    End Sub

    Private Sub BindingNavigatorTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyUp
        If e.KeyCode = Keys.F2 Then
            ProductCode.ShowDialog(Me)
            If Len(gblItemCode) > 0 Then BindingNavigatorTextBox.Text = gblItemCode.ToUpper Else Exit Sub
        End If
    End Sub

    Private Sub BindingNavigatorAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAdd.Click
        If BindingNavigatorAdd.Text = "&Add" Then
            Call SetReadOnly("False")
            BindingNavigatorEdit.Enabled = False
            BindingNavigatorUpdate.Enabled = True
            txtProdID.Focus()
            BindingNavigatorAdd.Text = "&Cancel"
            UpdtMode = True
            EditMode = False
            ProductDataGridView.Enabled = False
            ProductBindingSource.AddNew()
            txtProdID.Focus()
        Else
            Call SetReadOnly("True")
            BindingNavigatorUpdate.Enabled = False
            BindingNavigatorEdit.Enabled = True
            BindingNavigatorAdd.Text = "&Add"
            UpdtMode = False
            EditMode = False
            ProductDataGridView.Enabled = True
            Call RefreshDB()
        End If
    End Sub

    Public Function CheckProductExist(ByVal ProductDesc As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = ("select * from products where prod_desc =N'" & ProductDesc.Trim & "'")
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

    Private Sub SetReadOnly(ByVal State As String)
        For Each Obj As Object In Me.SplitContainer1.Panel1.Controls
            If Obj.GetType Is GetType(TextBox) Then
                DirectCast(Obj, TextBox).ReadOnly = State
            End If
        Next
    End Sub

    Private Sub SetComboBoxStyle(ByVal Style As Integer)
        For Each Obj As Object In Me.SplitContainer1.Panel1.Controls
            If Obj.GetType Is GetType(ComboBox) Then
                DirectCast(Obj, ComboBox).DropDownStyle = Style
            End If
        Next
    End Sub

    Private Sub txtStock_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStock.GotFocus
        Call Get_Property_GotFocus(txtStock)
    End Sub

    Private Sub txtStock_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStock.LostFocus
        Call Get_Property_LostFocus(txtStock)
    End Sub

    Private Sub BindingNavigatorDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDelete.Click
        If EditMode = False And UpdtMode = False Then
            If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtDesc.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
                Dim CommandText As String = "DELETE FROM PRODUCTS WHERE PROD_CODE = '" & txtProdID.Text.Trim & "' AND PROD_DESC = '" & txtDesc.Text.Trim & "'"
                ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
                ProductDataGridView.Refresh()
                ProductDataGridView.RefreshEdit()
                Call RefreshDB()
            End If
        End If
    End Sub
End Class