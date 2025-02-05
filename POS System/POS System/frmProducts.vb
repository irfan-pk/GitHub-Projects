Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmProducts
    Dim drag, EditMode As Boolean
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
        frmStock.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 5)
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + cmdClose.Width + 5)
        Call GetConnectionString()
        Try
            'Retrieve Records for datagrid view from product table
            Me.ProductDataSet.Clear()
            ProductAdapter.Dispose()
            Dim ProductQuery As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CD"
            ExecuteAdapterQuery(ProductAdapter, ProductQuery, Connection)
            ProductAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            Dim reader2 As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
            If reader2.HasRows Then
                ProductBindingSource.DataSource = Me.ProductDataSet
                ProductBindingSource.DataMember = "PRODUCTS"
                ProductDataGridView.Refresh()
                txtDesc.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_DESC")
                cmbCatg.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_CATG")
                txtPck.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_PACK")
                txtVAT.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_VAT")
                txtITax.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_ITAX")
                txtEDuty.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_EX_DUTY")
                txtMargin.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_PROFIT")
                txtMin.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_BAL_MIN")
                txtSalePrice.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_SPRICE")
                txtDiscount.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_DISC_MRG")
                txtPPrice.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_PPRICE")
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub BindingNavigatorEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEdit.Click
        If BindingNavigatorEdit.Text = "&Edit Product" Then
            EditMode = True
            If BindingNavigatorTextBox.Text <> "" Then
                gblFind = BindingNavigatorFind.Text.Trim
            Else
                gblFind = ProductDataGridView.CurrentRow.Cells(0).Value.ToString
            End If
            txtDesc.Text = txtDesc.Text.Trim
            SplitContainer1.Panel1.Enabled = True
            Call Enable_Disable_Controls("False")
            BindingNavigatorEdit.Text = "&Cancel"
        Else
            EditMode = False
            SplitContainer1.Panel1.Enabled = False
            Call Enable_Disable_Controls("True")
            BindingNavigatorEdit.Text = "&Edit Product"
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
        Pos = Me.ProductBindingSource.Find("PROD_CD", strCode.Trim)
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

    Private Sub txtSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalePrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtSalePrice.Text) < 1 Then gblMessage = "Product Sale Price invalid ?" : frmMsgStatus.ShowDialog(Me) : Exit Sub
            txtMargin.Text = Val(txtSalePrice.Text) - Val(txtPPrice.Text) - Val(txtVAT.Text.Trim) - Val(txtITax.Text.Trim) - Val(txtEDuty.Text.Trim)
            txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtVAT.Text.Trim) + Val(txtITax.Text.Trim) + Val(txtEDuty.Text.Trim) + Val(txtMargin.Text.Trim)
            txtDiscount.Text = Val(txtSalePrice.Text) * (0.01)
            txtDiscount.Focus()
        End If
    End Sub

    Private Sub txtSalePrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalePrice.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSalePrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.GotFocus
        Call Get_Property_GotFocus(txtSalePrice)
        txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtVAT.Text.Trim) + Val(txtITax.Text.Trim) + Val(txtEDuty.Text.Trim) + Val(txtMargin.Text.Trim)
    End Sub

    Private Sub txtDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.GotFocus
        Call Get_Property_GotFocus(txtDesc)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        ' Alpha Numeric input allowed only
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

    Private Sub txtMargin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargin.GotFocus
        Call Get_Property_GotFocus(txtMargin)
    End Sub

    Private Sub txtMargin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMargin.KeyPress
        Call ValidateKeyPress(sender, e, txtMargin, txtSalePrice)
    End Sub

    Private Sub txtMargin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargin.LostFocus
        Call Get_Property_LostFocus(txtMargin)
    End Sub

    Private Sub txtEDuty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEDuty.GotFocus
        Call Get_Property_GotFocus(txtEDuty)
    End Sub

    Private Sub txtEDuty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEDuty.KeyPress
        Call ValidateKeyPress(sender, e, txtEDuty, txtMargin)
    End Sub

    Private Sub txtEDuty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEDuty.LostFocus
        Call Get_Property_LostFocus(txtEDuty)
    End Sub

    Private Sub txtITax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtITax.GotFocus
        Call Get_Property_GotFocus(txtITax)
    End Sub

    Private Sub txtITax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtITax.KeyPress
        Call ValidateKeyPress(sender, e, txtITax, txtEDuty)
    End Sub

    Private Sub txtITax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtITax.LostFocus
        Call Get_Property_LostFocus(txtITax)
    End Sub

    Private Sub txtMin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMin.GotFocus
        Call Get_Property_GotFocus(txtMin)
    End Sub

    Private Sub txtMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMin.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtMin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMin.LostFocus
        Call Get_Property_LostFocus(txtMin)
    End Sub

    Private Sub txtPck_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPck.GotFocus
        Call Get_Property_GotFocus(txtPck)
    End Sub

    Private Sub txtPck_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPck.KeyPress
        ' Alpha input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
            ' Go Through
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtPck_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPck.LostFocus
        Call Get_Property_LostFocus(txtPck)
    End Sub

    Private Sub cmbCatg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCatg.GotFocus
        Call Get_Property_GotFocus(cmbCatg)
    End Sub

    Private Sub cmbCatg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCatg.KeyPress
        ' Alpha input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
            ' Go Through
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub cmbCatg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCatg.LostFocus
        Call Get_Property_LostFocus(cmbCatg)
    End Sub

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        Call Get_Property_GotFocus(txtDiscount)
    End Sub

    Private Sub txtDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.LostFocus
        Call Get_Property_LostFocus(txtDiscount)
    End Sub

    Private Sub txtVAT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVAT.GotFocus
        Call Get_Property_GotFocus(txtVAT)
    End Sub

    Private Sub txtVAT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVAT.KeyPress
        Call ValidateKeyPress(sender, e, txtVAT, txtITax)
    End Sub

    Private Sub txtVAT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVAT.LostFocus
        Call Get_Property_LostFocus(txtVAT)
    End Sub

    Private Sub ValidateKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal txt As TextBox, ByVal nexttxt As TextBox)
        '48 - 57  = Ascii codes for numbers
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
        If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
        'If e.KeyChar = Chr(13) Then nexttxt.Focus() 'Enter key moves to next control
        'If e.KeyChar = Chr(13) Then GetNextControl(nexttxt, True).Focus() 'Enter key moves to next control
    End Sub

    Private Sub BindingNavigatorUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorUpdate.Click
        If EditMode = True Then
            txtMargin.Text = Val(txtSalePrice.Text) - Val(txtPPrice.Text) - Val(txtVAT.Text.Trim) - Val(txtITax.Text.Trim) - Val(txtEDuty.Text.Trim)
            txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtVAT.Text.Trim) + Val(txtITax.Text.Trim) + Val(txtEDuty.Text.Trim) + Val(txtMargin.Text.Trim)
            txtDiscount.Text = Val(txtSalePrice.Text) * (0.01)
            Dim UpdtRecQuery As String = "UPDATE PRODUCTS SET " & _
                                         "PROD_DESC = '" & txtDesc.Text.Trim & "', " & _
                                         "PROD_CATG = '" & cmbCatg.Text.Trim & "', " & _
                                         "PROD_VAT = " & Val(txtVAT.Text.Trim) & ", " & _
                                         "PROD_ITAX = " & Val(txtITax.Text.Trim) & ", " & _
                                         "PROD_PROFIT = " & Val(txtMargin.Text.Trim) & ", " & _
                                         "PROD_DISC_MRG = " & Val(txtDiscount.Text.Trim) & ", " & _
                                         "PROD_EX_DUTY = " & Val(txtEDuty.Text.Trim) & ", " & _
                                         "PROD_SPRICE = " & Val(txtSalePrice.Text.Trim) & ", " & _
                                         "PROD_UPD_ON = '" & Format(Date.Parse(Now.Date.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                         "WHERE (PROD_CD = N'" & gblFind & "')"
            ExecuteAdapterQuery(SqlDataAdapter, UpdtRecQuery, Connection)
            Call Enable_Disable_Controls("True")
            ProductBindingSource.ResetBindings(True)
            Pos = Me.ProductBindingSource.Find("PROD_CD", gblFind.Trim)
            If Not Pos = -1 Then
                Me.ProductBindingSource.Position = Pos
            End If
        End If
    End Sub

    Private Sub BindingNavigatorTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyUp
        If e.KeyCode = Keys.F2 Then
            frmProductCode.ShowDialog(Me)
            If Len(gblItemCode) > 0 Then BindingNavigatorTextBox.Text = gblItemCode.ToUpper Else Exit Sub
            Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub

End Class