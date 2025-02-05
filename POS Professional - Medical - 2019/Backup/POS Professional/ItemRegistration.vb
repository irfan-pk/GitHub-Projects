Imports System.Data.SqlClient

Public Class ItemRegistration
    Dim FindAdapter As New SqlDataAdapter()
    Dim CheckAdapter As New SqlDataAdapter()
    Dim FindDataSet As New DataSet()
    Dim Pos, City_Code As Integer
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub ProductsInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, illegal operation.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        lblDate.Text = Format(Now.Date, "dd/MMM/yyyy")
        GetLastSequence()
    End Sub

    Private Sub GetLastSequence()
        Dim Max As String = "select max(prod_code) as MaxID from products"
        Dim MaxAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(MaxAdapter, Max, Connection)
        Dim reader As SqlDataReader = MaxAdapter.SelectCommand.ExecuteReader
        While reader.Read
            lblSeq.Text = reader.Item("MaxID").ToString
        End While
        If reader Is Nothing Then reader.Close()
    End Sub

    Private Sub ClearText()
        txtProdName.Clear()
        txtCompCode.Clear()
        txtQty.Text = String.Empty
        txtPackSize.Clear()
        txtTradePrice.Clear()
        txtSalePrice.Clear()
        txtRetailPrice.Clear()
        txtSaleTax.Clear()
        txtMinQty.Clear()
    End Sub

    Private Sub txtCompCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCompCode.GotFocus
        Get_Property_GotFocus(txtCompCode)
    End Sub

    Private Sub txtCompCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompCode.KeyPress
        ValidateNumbersOnly(sender, e, txtCompCode)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearText()
        Editing = False
        Addition = True
        btnSave.Enabled = False
        txtSeq.Text = GenerateMax_ID("products", "prod_code")
        enableTextBoxes(True)
        txtProdName.Focus()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        enableTextBoxes(True)
        Editing = True
        Addition = False
        EditString = txtSeq.Text
        txtProdName.Focus()
    End Sub

    Private Sub enableTextBoxes(ByVal State As Boolean)
        txtProdName.Enabled = State
        txtCompCode.Enabled = State
        txtPackSize.Enabled = State
        txtTradePrice.Enabled = State
        txtSalePrice.Enabled = State
        txtRetailPrice.Enabled = State
        txtSaleTax.Enabled = State
        txtDiscount.Enabled = State
        txtMinQty.Enabled = State
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtProdName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ProcessTransaction("DELETE FROM PRODUCTS WHERE PROD_DESC = '" & txtProdName.Text.Trim & "'")
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Edit_Update_Query As String = String.Empty
        If RollBack = False Then
            If Editing = True And Addition = False Then ProcessTransaction("UPDATE PRODUCTS SET PROD_CODE = '" & txtProdName.Text.ToUpper & "', " & _
                                                                                               "PROD_BAR_CODE = 'X', " & _
                                                                                               "PROD_DESC = " & City_Code & ", " & _
                                                                                               "PROD_SUPPLR = '" & txtCompCode.Text.Trim.ToUpper & "', " & _
                                                                                               "PROD_PACKING =  '" & txtPackSize.Text.ToUpper & "', " & _
                                                                                               "PROD_UNITS = 0, " & _
                                                                                               "PROD_QTY_PER_UNIT = 0, " & _
                                                                                               "PROD_PURCH_PRICE = " & Val(txtTradePrice.Text.Trim) & ", " & _
                                                                                               "PROD_WSALE_PRICE = " & Val(txtSalePrice.Text.Trim) & ", " & _
                                                                                               "PROD_SALE_PRICE = " & Val(txtRetailPrice.Text.Trim) & ", " & _
                                                                                               "PROD_FOR_SALE = 1, " & _
                                                                                               "PROD_DISC_ALLOW = " & Val(txtDiscount.Text.Trim) & ", " & _
                                                                                               "WHERE PROD_CODE = '" & EditString & "'")

            If Addition = True And Editing = False Then ProcessTransaction("INSERT INTO PRODUCTS VALUES(" & Val(txtSeq.Text.Trim) & "'," & _
                                                                                               "'X','" & _
                                                                                               City_Code & "'," & _
                                                                                               "'PHARMACY'," & _
                                                                                               "'MEDICINE'," & _
                                                                                               "'RETAILER','" & _
                                                                                               txtCompCode.Text.Trim.ToUpper & "','" & _
                                                                                               txtPackSize.Text.ToUpper & "'," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               Val(txtTradePrice.Text.Trim) & "," & _
                                                                                               Val(txtSalePrice.Text.Trim) & "," & _
                                                                                               Val(txtRetailPrice.Text.Trim) & ",'" & _
                                                                                               Format(Date.Parse(Now.Date.ToString), "MM/dd/yyyy") & "'," & _
                                                                                               "1," & _
                                                                                               Val(txtDiscount.Text.Trim) & ")")

            btnSave.Enabled = False
            ClearText()
            txtSeq.Clear()
            txtSeq.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSeq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeq.GotFocus
        Get_Property_GotFocus(txtSeq)
    End Sub

    Private Sub txtSeq_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSeq.LostFocus
        Get_Property_LostFocus(txtSeq)
    End Sub

    Private Sub txtSeq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeq.KeyPress
        ValidateNumbersOnly(sender, e, txtSeq)
    End Sub

    Private Sub txtSeq_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeq.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtSeq.Text) > 0 Then
                Dim FindQuery As String = "select * from products where prod_code = " & Val(txtSeq.Text)
                ExecuteDatasetQuery(FindAdapter, FindDataSet, FindQuery, "products", Connection)
                Dim FindReader As SqlDataReader = FindAdapter.SelectCommand.ExecuteReader
                If FindReader.HasRows = True Then
                    While FindReader.Read
                        txtProdName.Text = FindReader.Item("prod_desc").ToString
                        txtCompCode.Text = FindReader.Item("prod_supplr").ToString
                        txtQty.Text = FindReader.Item("prod_stock").ToString
                        txtPackSize.Text = FindReader.Item("prod_packing").ToString
                        txtMinQty.Text = FindReader.Item("prod_bal_min").ToString
                        txtTradePrice.Text = FindReader.Item("prod_purch_price").ToString
                        txtRetailPrice.Text = FindReader.Item("prod_wsale_price").ToString
                        txtSalePrice.Text = FindReader.Item("prod_sale_price").ToString
                        txtDiscount.Text = FindReader.Item("prod_disc_allow").ToString
                        txtSaleTax.Text = FindReader.Item("prod_sale_tax").ToString
                        enableTextBoxes(False)
                        btnNew.Focus()
                    End While
                Else
                    enableTextBoxes(True)
                    ClearText()
                    txtProdName.Focus()
                    Addition = True
                End If
            End If
        End If
    End Sub

    Private Sub txtProdName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdName.GotFocus
        Get_Property_GotFocus(txtProdName)
    End Sub

    Private Sub txtProdName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCompCode.Focus()
        End If
    End Sub

    Private Sub txtProdName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdName.LostFocus
        Get_Property_LostFocus(txtProdName)
    End Sub

    Private Sub txtProdName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdName.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtCompCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCompCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtCompCode.Text) > 0 Then
                txtPackSize.Focus()
            End If
            If Len(txtCompCode.Text) = 0 Or IsDBNull(txtCompCode.Text) = True Then
                HelpTable = "company"
                HelpF1 = "companyname"
                HelpF2 = "companycode"
                CodesHelp.ShowDialog(Me)
                txtCompCode.Text = gblCP_ID.Trim
            End If
        End If
    End Sub

    Private Sub txtPackSize_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPackSize.GotFocus
        Get_Property_GotFocus(txtPackSize)
    End Sub

    Private Sub txtPackSize_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPackSize.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMinQty.Focus()
        End If
    End Sub

    Private Sub txtPackSize_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPackSize.LostFocus
        Get_Property_LostFocus(txtPackSize)
    End Sub

    Private Sub txtPackSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPackSize.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtMinQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinQty.GotFocus
        Get_Property_GotFocus(txtMinQty)
    End Sub

    Private Sub txtMinQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinQty.KeyPress
        ValidateNumbersOnly(sender, e, txtMinQty)
    End Sub

    Private Sub txtMinQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinQty.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtMinQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMinQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTradePrice.Focus()
        End If
    End Sub

    Private Sub txtTradePrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTradePrice.GotFocus
        Get_Property_GotFocus(txtTradePrice)
    End Sub

    Private Sub txtTradePrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTradePrice.KeyPress
        ValidateNumericKeyPress(sender, e, txtTradePrice)
    End Sub

    Private Sub txtTradePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTradePrice.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtTradePrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTradePrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSalePrice.Focus()
        End If
    End Sub

    Private Sub txtSalePrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.GotFocus
        Get_Property_GotFocus(txtSalePrice)
    End Sub

    Private Sub txtSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalePrice.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtSalePrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalePrice.KeyPress
        ValidateNumericKeyPress(sender, e, txtSalePrice)
        'If InStr(txtSalePrice.Text, ".") Then e.Handled = True
    End Sub

    Private Sub txtSalePrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalePrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRetailPrice.Focus()
        End If
    End Sub

    Private Sub txtRetailPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetailPrice.GotFocus
        Get_Property_GotFocus(txtRetailPrice)
    End Sub

    Private Sub txtRetailPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetailPrice.KeyPress
        ValidateNumericKeyPress(sender, e, txtRetailPrice)
    End Sub

    Private Sub txtRetailPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRetailPrice.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtRetailPrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRetailPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSaleTax.Focus()
        End If
    End Sub

    Private Sub txtSaleTax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSaleTax.GotFocus
        Get_Property_GotFocus(txtSaleTax)
    End Sub

    Private Sub txtSaleTax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaleTax.KeyPress
        ValidateNumericKeyPress(sender, e, txtSaleTax)
    End Sub

    Private Sub txtSaleTax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSaleTax.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDiscount.Focus()
        End If
    End Sub

    Private Sub txtSaleTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaleTax.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        Get_Property_GotFocus(txtDiscount)
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        ValidateNumericKeyPress(sender, e, txtDiscount)
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnNew.Focus()
        End If
    End Sub

    Private Sub txtCompCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCompCode.LostFocus
        Get_Property_LostFocus(txtCompCode)
    End Sub

    Private Sub txtDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.LostFocus
        Get_Property_LostFocus(txtDiscount)
    End Sub

    Private Sub txtMinQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinQty.LostFocus
        Get_Property_LostFocus(txtMinQty)
    End Sub

    Private Sub txtRetailPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetailPrice.LostFocus
        Get_Property_LostFocus(txtRetailPrice)
    End Sub

    Private Sub txtSalePrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.LostFocus
        Get_Property_LostFocus(txtSalePrice)
    End Sub

    Private Sub txtSaleTax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSaleTax.LostFocus
        Get_Property_LostFocus(txtSaleTax)
    End Sub

    Private Sub txtTradePrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTradePrice.LostFocus
        Get_Property_LostFocus(txtTradePrice)
    End Sub
End Class