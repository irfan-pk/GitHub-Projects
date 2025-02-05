Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class Purchases
    Dim Max_ID, Supplr_ID As Integer
    Dim drag, newrec, updatable, editmode, DataFinalize, GridEdit As Boolean
    Dim OldPPrie, OldSalePrice, OldQuantity, OldSchR1, OldSchR2, OldSchR3, OldSchQ1, OldSchQ2, OldSchQ3, NewPPrice, NewQuantity, NewSchR1, NewSchR2, NewSchR3, NewSchQ1, NewSchQ2, NewSchQ3 As Double
    Dim mousex, mousey As Integer

#Region "Forms and TextBoxes Events"

    Private Sub frmPurchases_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim bHandled As Boolean = False
        Select Case e.Modifiers
            Case Keys.Control
                If e.KeyCode = Keys.S Then
                    e.Handled = True
                    'Write down saving Procedure
                    Call SaveCurrentChanges()
                End If
        End Select

    End Sub

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then cmbCompany.Focus()
    End Sub

    Private Sub frmPurchases_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmPurchases_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmPurchases_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Stock.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        Call Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        ' Alpha Numeric input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Or (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Then 'Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 46
            ' Go Through
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            ProductCode.ShowDialog(Me)
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
        Call ValidateNumericKeyPress(sender, e, txtMargin, txtSalePrice)
    End Sub

    Private Sub txtMargin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargin.LostFocus
        Call Get_Property_LostFocus(txtMargin)
    End Sub

    Private Sub txtEDuty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEDuty.GotFocus
        Call Get_Property_GotFocus(txtEDuty)
    End Sub

    Private Sub txtEDuty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEDuty.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtEDuty, txtMargin)
    End Sub

    Private Sub txtEDuty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEDuty.LostFocus
        Call Get_Property_LostFocus(txtEDuty)
    End Sub

    Private Sub txtITax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtITax.GotFocus
        Call Get_Property_GotFocus(txtITax)
    End Sub

    Private Sub txtITax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtITax.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtITax, txtEDuty)
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

    Private Sub txtPPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPPrice.GotFocus
        Call Get_Property_GotFocus(txtPPrice)
    End Sub

    Private Sub txtPPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPPrice.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtPPrice, txtQty)
    End Sub

    Private Sub txtPPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPPrice.LostFocus
        Call Get_Property_LostFocus(txtPPrice)
    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        Call Get_Property_GotFocus(txtQty)
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMargin.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        Call Get_Property_LostFocus(txtQty)
    End Sub

    Private Sub txtSalePrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.GotFocus
        Call Get_Property_GotFocus(txtSalePrice)
        txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtVAT.Text.Trim) + Val(txtITax.Text.Trim) + Val(txtEDuty.Text.Trim) + Val(txtMargin.Text.Trim)
    End Sub

    Private Sub txtSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalePrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtPPrice.Text) < 1 Then gblMessage = "Purchase Price invalid ?" : MsgStatus.ShowDialog(Me) : Exit Sub
            txtMargin.Text = Val(txtSalePrice.Text) - Val(txtPPrice.Text) - Val(txtVAT.Text.Trim) - Val(txtITax.Text.Trim) - Val(txtEDuty.Text.Trim)
            txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtVAT.Text.Trim) + Val(txtITax.Text.Trim) + Val(txtEDuty.Text.Trim) + Val(txtMargin.Text.Trim)
            txtDiscount.Text = Val(txtSalePrice.Text) * (0.01)
            txtDiscount.Focus()
            BindingNavigatorSave.Enabled = True
        End If
    End Sub

    Private Sub txtSalePrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalePrice.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSalePrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.LostFocus
        Call Get_Property_LostFocus(txtSalePrice)
        If Val(txtSalePrice.Text) < 1 Then gblMessage = "Purchase Price invalid ?" : MsgStatus.ShowDialog(Me) : txtSalePrice.Text = 0 : Exit Sub
        txtMargin.Text = Val(txtSalePrice.Text) - Val(txtPPrice.Text) - Val(txtVAT.Text.Trim) - Val(txtITax.Text.Trim) - Val(txtEDuty.Text.Trim)
        txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtVAT.Text.Trim) + Val(txtITax.Text.Trim) + Val(txtEDuty.Text.Trim) + Val(txtMargin.Text.Trim)
        txtDiscount.Text = Val(txtSalePrice.Text) * (0.01)
        txtDiscount.Focus()
        BindingNavigatorSave.Enabled = True
    End Sub

    Private Sub txtSch1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSch1.GotFocus
        Call Get_Property_GotFocus(txtSch1)
    End Sub

    Private Sub txtSch1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSch1.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSch1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSch1.LostFocus
        Call Get_Property_LostFocus(txtSch1)
    End Sub

    Private Sub txtSch2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSch2.GotFocus
        Call Get_Property_GotFocus(txtSch2)
    End Sub

    Private Sub txtSch2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSch2.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSch2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSch2.LostFocus
        Call Get_Property_LostFocus(txtSch2)
    End Sub

    Private Sub txtSQty1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty1.GotFocus
        Call Get_Property_GotFocus(txtSQty1)
    End Sub

    Private Sub txtSQty1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSQty1.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSQty1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty1.LostFocus
        Call Get_Property_LostFocus(txtSQty1)
    End Sub

    Private Sub txtSQty3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty3.GotFocus
        Call Get_Property_GotFocus(txtSQty3)
    End Sub

    Private Sub txtSQty3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSQty3.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSQty3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty3.LostFocus
        Call Get_Property_LostFocus(txtSQty3)
    End Sub

    Private Sub txtVAT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVAT.GotFocus
        Call Get_Property_GotFocus(txtVAT)
    End Sub

    Private Sub txtVAT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVAT.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtVAT, txtITax)
    End Sub

    Private Sub txtVAT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVAT.LostFocus
        Call Get_Property_LostFocus(txtVAT)
    End Sub

    Private Sub txtSch3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSch3.GotFocus
        Call Get_Property_GotFocus(txtSch3)
    End Sub

    Private Sub txtSch3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSch3.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSch3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSch3.LostFocus
        Call Get_Property_LostFocus(txtSch3)
    End Sub

    Private Sub txtSQty2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty2.GotFocus
        Call Get_Property_GotFocus(txtSQty2)
    End Sub

    Private Sub txtSQty2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSQty2.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSQty2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty2.LostFocus
        Call Get_Property_LostFocus(txtSQty2)
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

    Private Sub cmbCompany_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompany.GotFocus
        Call Get_Property_GotFocus(cmbCompany)
        Call RefreshGridView()
    End Sub

    Private Sub cmbCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCompany.KeyDown
        If e.KeyCode = Keys.Enter Then txtCode.Focus()
    End Sub

    Private Sub cmbCompany_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompany.LostFocus
        Call Get_Property_LostFocus(cmbCompany)
    End Sub

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        Call Get_Property_GotFocus(txtDiscount)
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.LostFocus
        Call Get_Property_LostFocus(txtDiscount)
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        If Val(txtSalePrice.Text) > 0 Then Call SaveCurrentChanges()
    End Sub

    Private Sub Get_Text_Values()

        If PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(0).Value.ToString.Trim Is Nothing Then gblMessage = "There is no product to edit." : MsgStatus.ShowDialog(Me) : Exit Sub
        'EDIT PROCEDURE WHILE UPDATE PURCHASES
        If PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(23).Value.ToString.Trim = "ADDED" Then
            txtCode.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(1).Value.ToString.Trim
            gblFind = txtCode.Text.Trim
            txtDesc.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(2).Value.ToString.Trim
            cmbCatg.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(3).Value.ToString
            cmbCompany.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(4).Value.ToString.Trim
            txtDate.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(5).Value.ToString
            txtPck.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(6).Value.ToString
            txtPPrice.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(7).Value.ToString
            txtQty.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(8).Value.ToString
            txtMin.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(10).Value.ToString
            txtSch1.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(11).Value.ToString
            txtSQty1.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(12).Value.ToString
            txtSch2.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(13).Value.ToString
            txtSQty2.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(14).Value.ToString
            txtSch3.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(15).Value.ToString
            txtSQty3.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(16).Value.ToString
            txtVAT.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(17).Value.ToString
            txtITax.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(18).Value.ToString
            txtEDuty.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(19).Value.ToString
            txtDiscount.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(20).Value.ToString
            txtMargin.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(21).Value.ToString
            txtSalePrice.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(22).Value.ToString
            editmode = True
            txtCode.ReadOnly = True
            txtDesc.ReadOnly = True
            Lock_TextBoxes("False")
            txtQty.Focus()
        Else
            'gblMessage = "Changes cannot be made, product updated."
            'frmStatus.ShowDialog(Me)
            editmode = False
        End If
    End Sub

#End Region

#Region "Form Coding Area"

    Private Sub frmPurchases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        newrec = False
        updatable = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Popup the Company Data Combo
        Dim Popup_Reader As SqlDataReader
        ExecuteAdapterQuery(SqlDataAdapter, "SELECT DISTINCT SUPL_CODE, SUPL_NAME FROM SUPPLIERS ORDER BY SUPL_NAME", Connection)
        Popup_Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Popup_Reader.HasRows Then
            While Popup_Reader.Read
                cmbCompany.Items.Add(Popup_Reader.Item("SUPL_CODE").ToString.Trim & " - " & Popup_Reader.Item("SUPL_NAME").ToString.Trim)
            End While
        Else
            ' Go through
        End If
        'Retrieve Records for datagrid view from purchase table
        Call RefreshGridView()
        DataFinalize = False

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            ' First Check Item in Product Table and get information
            Dim DataCheck As SqlDataReader
            ExecuteAdapterQuery(SqlDataAdapter, "SELECT * FROM PRODUCTS WHERE PROD_CD = N'" & txtCode.Text.ToString.ToString.Trim & "'", Connection)
            DataCheck = SqlDataAdapter.SelectCommand.ExecuteReader
            If DataCheck.HasRows Then
                While DataCheck.Read
                    txtDesc.Text = DataCheck.Item("PROD_DESC").ToString.Trim
                    cmbCatg.Text = DataCheck.Item("PROD_CATG").ToString.Trim
                    txtPck.Text = DataCheck.Item("PROD_PACK").ToString.Trim
                    OldQuantity = Val(DataCheck.Item("PROD_ONHAND").ToString.Trim)
                    txtPPrice.Text = DataCheck.Item("PROD_PPRICE").ToString.Trim
                    OldPPrie = Val(DataCheck.Item("PROD_PPRICE").ToString.Trim)
                    txtMin.Text = DataCheck.Item("PROD_BAL_MIN").ToString.Trim
                    txtSch1.Text = DataCheck.Item("PROD_SCH1_PRICE").ToString.Trim
                    OldSchR1 = Val(DataCheck.Item("PROD_SCH1_PRICE").ToString.Trim)
                    txtSQty1.Text = DataCheck.Item("PROD_SCH1_ONHAND").ToString.Trim
                    OldSchQ1 = Val(DataCheck.Item("PROD_SCH1_ONHAND").ToString.Trim)
                    txtSch2.Text = DataCheck.Item("PROD_SCH2_PRICE").ToString.Trim
                    OldSchR2 = Val(DataCheck.Item("PROD_SCH2_PRICE").ToString.Trim)
                    txtSQty2.Text = DataCheck.Item("PROD_SCH2_ONHAND").ToString.Trim
                    OldSchQ2 = Val(DataCheck.Item("PROD_SCH2_ONHAND").ToString.Trim)
                    txtSch3.Text = DataCheck.Item("PROD_SCH3_PRICE").ToString.Trim
                    OldSchR3 = Val(DataCheck.Item("PROD_SCH3_PRICE").ToString.Trim)
                    txtSQty3.Text = DataCheck.Item("PROD_SCH3_ONHAND").ToString.Trim
                    OldSchQ3 = Val(DataCheck.Item("PROD_SCH3_ONHAND").ToString.Trim)
                    txtVAT.Text = DataCheck.Item("PROD_VAT").ToString.Trim
                    txtITax.Text = DataCheck.Item("PROD_ITAX").ToString.Trim
                    txtEDuty.Text = DataCheck.Item("PROD_EX_DUTY").ToString.Trim
                    txtMargin.Text = DataCheck.Item("PROD_PROFIT").ToString.Trim
                    txtSalePrice.Text = DataCheck.Item("PROD_SPRICE").ToString.Trim
                    OldSalePrice = Val(DataCheck.Item("PROD_SPRICE").ToString.Trim)
                End While
                If DataCheck Is Nothing Then DataCheck.Close()
                updatable = True
                newrec = False
                If Val(txtSch1.Text) > 0 Then txtSch1.ReadOnly = True : txtSQty1.ReadOnly = True
                If Val(txtSch2.Text) > 0 Then txtSch2.ReadOnly = True : txtSQty2.ReadOnly = True
                If Val(txtSch3.Text) > 0 Then txtSch3.ReadOnly = True : txtSQty3.ReadOnly = True
                txtPPrice.Focus()
                Exit Sub
            End If
            If DataCheck Is Nothing Then DataCheck.Close()

            ' Second if not found any product in firt step then go to add new stock mode
            Dim GetNewItem As SqlDataReader
            Dim FindItem As String = "SELECT * FROM POS.dbo.ITEMS WHERE ITEM_CODE = N'" & txtCode.Text.ToString.Trim & "'"
            ExecuteAdapterQuery(SqlDataAdapter, FindItem, Connection)
            GetNewItem = SqlDataAdapter.SelectCommand.ExecuteReader
            If GetNewItem.HasRows Then
                Call RefreshTextBoxes()
                While GetNewItem.Read
                    txtDesc.Text = GetNewItem.Item("ITEM_NAME").ToString.Trim
                    cmbCatg.Text = GetNewItem.Item("ITEM_CATG").ToString.Trim
                    txtPck.Text = GetNewItem.Item("ITEM_PCKG").ToString.Trim
                    'txtPPrice.Text = GetNewItem.Item("ITEM_PRICE").ToString.Trim
                End While
                If GetNewItem Is Nothing Then GetNewItem.Close()
                OldQuantity = 0
                OldPPrie = 0
                OldSalePrice = 0
                OldSchQ1 = 0
                OldSchQ2 = 0
                OldSchQ3 = 0
                OldSchR1 = 0
                OldSchR2 = 0
                OldSchR3 = 0
                txtSch1.Enabled = True : txtSQty1.Enabled = True
                txtSch2.Enabled = True : txtSQty2.Enabled = True
                txtSch3.Enabled = True : txtSQty3.Enabled = True
                Lock_TextBoxes("False")
                txtVAT.Focus()
                newrec = True
                updatable = False
            End If

        End If
    End Sub

    Private Sub RefreshTextBoxes()

        'REFRESH FIELDS FOR NEW RECORD
        'Me.txtCode.Clear()
        Me.txtPck.Text = "PCS"
        Me.txtDesc.Clear()
        Me.cmbCatg.Text = String.Empty
        Me.txtPPrice.Text = "0"
        Me.txtSch1.Text = "0"
        Me.txtSQty1.Text = "0"
        Me.txtSch2.Text = "0"
        Me.txtSQty2.Text = "0"
        Me.txtSch3.Text = "0"
        Me.txtSQty3.Text = "0"
        Me.txtMin.Text = "1"
        Me.txtQty.Text = "0"
        Me.txtITax.Text = "0"
        Me.txtVAT.Text = "0"
        Me.txtEDuty.Text = "0"
        Me.txtSalePrice.Text = "0"
        Me.txtMargin.Text = "0"
        Me.txtDiscount.Text = "0"

    End Sub

    Private Sub Lock_TextBoxes(ByVal Stat As String)

        txtMin.ReadOnly = Stat
        txtPck.ReadOnly = Stat
        txtVAT.ReadOnly = Stat
        txtITax.ReadOnly = Stat
        txtEDuty.ReadOnly = Stat
        txtMargin.ReadOnly = Stat
        txtSalePrice.ReadOnly = Stat
        txtDiscount.ReadOnly = Stat

    End Sub

    Private Sub RefreshGridView()
        Try
            'Retrieve Records for datagrid view from purchase table
            Me.PurchaseDataSet.Clear()
            PurchaseAdapter.Dispose()
            'Dim PurchasesQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
            Dim PurchasesQuery As String = "SELECT * FROM PURCHASE WHERE (PRCH_STATUS = N'ADDED')"
            ExecuteAdapterQuery(PurchaseAdapter, PurchasesQuery, Connection)
            PurchaseAdapter.Fill(Me.PurchaseDataSet, "PURCHASE")
            Dim reader1 As SqlDataReader = PurchaseAdapter.SelectCommand.ExecuteReader
            If reader1.HasRows Then
                BindingNavigatorSaveItem.Enabled = True
                BindingNavigatorRefreshItem.Enabled = True
                Me.PurchaseBindingSource.DataSource = Me.PurchaseDataSet
                Me.PurchaseBindingSource.DataMember = "PURCHASE"
                Me.PurchaseDataGridView.Refresh()
            End If
            'Retrieve Records for datagrid view from product table
            Me.ProductDataSet.Clear()
            ProductAdapter.Dispose()
            Dim ProductQuery As String = "SELECT * FROM PRODUCTS WHERE PROD_UPD_ON = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
            ExecuteAdapterQuery(ProductAdapter, ProductQuery, Connection)
            ProductAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            Dim reader2 As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
            If reader2.HasRows Then
                ProductBindingSource.DataSource = Me.ProductDataSet
                ProductBindingSource.DataMember = "PRODUCTS"
                ProductDataGridView.Refresh()
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub SaveCurrentChanges()
        If CheckRecordExists(Mid(cmbCompany.Text.Trim, 1, 4), "SUPPLIERS", "SUPL_CODE") = True Then
            Dim Max_Tr_ID As Decimal = 0

            'Check if already in Purchases Table
            If txtCode.Text = String.Empty Or txtDesc.Text = String.Empty Then _
                gblMessage = ("Please give valid product code.") _
                                              : MsgStatus.ShowDialog(Me) _
                                              : Exit Sub

            Max_Tr_ID = GenerateMax_ID("PURCHASE", "PRCH_TR_ID")

            If newrec = False Then
                If OldSchR1 <> Val(txtSch1.Text) Then NewSchR1 = Val(txtSch1.Text) Else NewSchR1 = 0
                If OldSchR2 <> Val(txtSch2.Text) Then NewSchR2 = Val(txtSch2.Text) Else NewSchR2 = 0
                If OldSchR3 <> Val(txtSch3.Text) Then NewSchR3 = Val(txtSch3.Text) Else NewSchR3 = 0
                If OldSchQ1 <> Val(txtSQty1.Text) Then NewSchQ1 = Val(txtSQty1.Text) + OldSchQ1 Else NewSchQ1 = 0
                If OldSchQ2 <> Val(txtSQty2.Text) Then NewSchQ2 = Val(txtSQty2.Text) + OldSchQ2 Else NewSchQ2 = 0
                If OldSchQ3 <> Val(txtSQty3.Text) Then NewSchQ3 = Val(txtSQty3.Text) + OldSchQ3 Else NewSchQ3 = 0
                'If Val(txtQty.Text.Trim) = 0 Then NewPPrice = 0 : NewQuantity = 0
            Else
                NewSchR1 = Val(txtSch1.Text)
                NewSchR2 = Val(txtSch2.Text)
                NewSchR3 = Val(txtSch3.Text)
                NewSchQ1 = Val(txtSQty1.Text)
                NewSchQ2 = Val(txtSQty2.Text)
                NewSchQ3 = Val(txtSQty3.Text)
            End If

            Dim CheckQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_CD = N'" & txtCode.Text.Trim & "' AND PRCH_SUPPLIER = N'" & cmbCompany.Text.Trim & "' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
            ExecuteAdapterQuery(SqlDataAdapter, CheckQuery, Connection)
            Dim Finder As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Finder.HasRows Then
                Call Lock_TextBoxes("True")
                If editmode = True Then
                    txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtVAT.Text.Trim) + Val(txtITax.Text.Trim) + Val(txtEDuty.Text.Trim) + Val(txtMargin.Text.Trim)
                    txtMargin.Text = Val(txtSalePrice.Text) - Val(txtPPrice.Text) - Val(txtVAT.Text.Trim) - Val(txtITax.Text.Trim) - Val(txtEDuty.Text.Trim)
                    txtDiscount.Text = Val(txtSalePrice.Text) * (0.01)
                    Dim InsertRecord As String = "UPDATE PURCHASE SET " & _
                                                 "PRCH_CATG = '" & cmbCatg.Text.Trim & "', " & _
                                                 "PRCH_PACK = '" & txtPck.Text.Trim & "', " & _
                                                 "PRCH_PRICE = " & Val(txtPPrice.Text.Trim) & ", " & _
                                                 "PRCH_QTY = " & Val(txtQty.Text.Trim) & ", " & _
                                                 "PRCH_BAL_MIN = " & Val(txtMin.Text.Trim) & ", " & _
                                                 "PRCH_SCH1_PRICE = " & NewSchR1 & ", " & _
                                                 "PRCH_SCH1_ONHAND = " & NewSchQ1 & ", " & _
                                                 "PRCH_SCH2_PRICE = " & NewSchR2 & ", " & _
                                                 "PRCH_SCH2_ONHAND = " & NewSchQ2 & ", " & _
                                                 "PRCH_SCH3_PRICE = " & NewSchR3 & ", " & _
                                                 "PRCH_SCH3_ONHAND = " & NewSchQ3 & ", " & _
                                                 "PRCH_VAT = " & Val(txtVAT.Text.Trim) & ", " & _
                                                 "PRCH_ITAX = " & Val(txtITax.Text.Trim) & ", " & _
                                                 "PRCH_EX_DUTY = " & Val(txtEDuty.Text.Trim) & ", " & _
                                                 "PRCH_PROFIT = " & Val(txtMargin.Text.Trim) & ", " & _
                                                 "PRCH_DISC_MRG = " & Val(txtMargin.Text.Trim) * (0.01) & ", " & _
                                                 "PRCH_SPRICE = " & Val(txtSalePrice.Text.Trim) & ", " & _
                                                 "PRCH_DATE = '" & Format(DateTime.Parse(txtDate.Text.Trim.ToString.Trim), "MM/dd/yyyy") & "', " & _
                                                 "PRCH_SUPPLIER = '" & cmbCompany.Text.Trim & "', PRCH_STATUS ='ADDED' " & _
                                                 "WHERE (PRCH_CD = N'" & gblFind & "' AND PRCH_STATUS = N'ADDED' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102))"
                    ExecuteAdapterQuery(SqlDataAdapter, InsertRecord, Connection)
                    editmode = False
                    Call RefreshGridView()
                    Call RefreshTextBoxes()
                    Me.txtCode.Clear()
                    editmode = False
                    txtCode.ReadOnly = False
                    txtDesc.ReadOnly = False
                Else
                    'Message Box
                    gblMessage = ("Item already enlisted in the queue.")
                    MsgStatus.ShowDialog(Me)
                End If
            Else
                Call Lock_TextBoxes("False")
                txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtVAT.Text.Trim) + Val(txtITax.Text.Trim) + Val(txtEDuty.Text.Trim) + Val(txtMargin.Text.Trim)
                txtMargin.Text = Val(txtSalePrice.Text) - Val(txtPPrice.Text) - Val(txtVAT.Text.Trim) - Val(txtITax.Text.Trim) - Val(txtEDuty.Text.Trim)
                txtDiscount.Text = Val(txtSalePrice.Text) * (0.01)
                Dim InsertRecord As String = "INSERT INTO PURCHASE (PRCH_TR_ID,PRCH_CD,PRCH_DESC,PRCH_CATG,PRCH_PACK,PRCH_PRICE,PRCH_QTY,PRCH_OLD_QTY,PRCH_BAL_MIN,PRCH_SCH1_PRICE,PRCH_SCH1_ONHAND,PRCH_SCH2_PRICE,PRCH_SCH2_ONHAND,PRCH_SCH3_PRICE,PRCH_SCH3_ONHAND,PRCH_VAT,PRCH_ITAX,PRCH_EX_DUTY,PRCH_PROFIT,PRCH_DISC_MRG,PRCH_SPRICE,PRCH_DATE,PRCH_SUPPLIER,PRCH_STATUS) " & _
                                             "VALUES (" & Max_Tr_ID & ",'" & _
                                             txtCode.Text.Trim & "','" & _
                                             txtDesc.Text.Trim & "','" & _
                                             cmbCatg.Text.Trim & "','" & _
                                             txtPck.Text.Trim & "'," & _
                                             Val(txtPPrice.Text.Trim) & "," & _
                                             Val(txtQty.Text.Trim) & "," & _
                                             OldQuantity & "," & _
                                             Val(txtMin.Text.Trim) & "," & _
                                             NewSchR1 & "," & _
                                             NewSchQ1 & "," & _
                                             NewSchR2 & "," & _
                                             NewSchQ2 & "," & _
                                             NewSchR3 & "," & _
                                             NewSchQ3 & "," & _
                                             Val(txtVAT.Text.Trim) & "," & _
                                             Val(txtITax.Text.Trim) & "," & _
                                             Val(txtEDuty.Text.Trim) & "," & _
                                             Val(txtMargin.Text.Trim) & "," & _
                                             Val(txtDiscount.Text) & "," & _
                                             Val(txtSalePrice.Text.Trim) & ",'" & _
                                             Format(DateTime.Parse(txtDate.Text.Trim.ToString.Trim), "MM/dd/yyyy") & "','" & _
                                             cmbCompany.Text.Trim & "','ADDED')"
                ExecuteAdapterQuery(SqlDataAdapter, InsertRecord, Connection)
                BindingNavigatorSaveItem.Enabled = True
                BindingNavigatorRefreshItem.Enabled = True
                Call RefreshTextBoxes()
                Call RefreshGridView()
                txtCode.Clear()
                txtCode.Focus()
            End If
        Else
            gblMessage = "Please select valid wholesaler."
            MsgStatus.ShowDialog(Me)
        End If
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        'If CheckRecordExists(Mid(cmbCompany.Text.Trim, 1, 4), "SUPPLIERS", "SUPL_CODE") = True Then
        Dim UpdtRecQuery As String = String.Empty
        Dim Clos_Balance As String = String.Empty
        Max_ID = 0

        'Final Routine to update the products from purchases by date
        Dim TransferQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_STATUS = N'ADDED' ORDER BY PRCH_TR_ID"
        ExecuteAdapterQuery(TransferAdapter, TransferQuery, Connection)
        Dim TransferReader As SqlDataReader = TransferAdapter.SelectCommand.ExecuteReader

        If TransferReader.HasRows Then
            While TransferReader.Read
                If ValidateDelete(TransferReader.Item("PRCH_CD").ToString, TransferReader.Item("PRCH_DATE").ToString) = False Then
                    UpdtRecQuery = String.Empty
                    If CheckRecordExists(TransferReader.Item("PRCH_CD").ToString, "PRODUCTS", "PROD_CD") = False Then
                        'ADD NEW RECORD INTO PRODUCT TABLE
                        UpdtRecQuery = "INSERT INTO PRODUCTS VALUES ('" & _
                                                    TransferReader.Item("PRCH_CD").ToString & "','" & _
                                                    TransferReader.Item("PRCH_DESC").ToString.Trim & "','" & _
                                                    TransferReader.Item("PRCH_CATG").ToString.Trim & "','" & _
                                                    TransferReader.Item("PRCH_PACK").ToString.Trim & "'," & _
                                                    Val(TransferReader.Item("PRCH_PRICE").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_QTY").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_BAL_MIN").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_SCH1_PRICE").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_SCH1_ONHAND").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_SCH2_PRICE").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_SCH2_ONHAND").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_SCH3_PRICE").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_SCH3_ONHAND").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_VAT").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_ITAX").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_EX_DUTY").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_PROFIT").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_DISC_MRG").ToString) & "," & _
                                                    Val(TransferReader.Item("PRCH_SPRICE").ToString) & ",'" & _
                                                    Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "','" & _
                                                    Format(Date.Parse(txtDate.Text.ToString.Trim), "MM/dd/yyyy") & "')"

                        'ADD ITEM INFORMATION INTO ITEM TABLE
                        Call AddNewItem(TransferReader.Item("PRCH_CD").ToString, _
                                        TransferReader.Item("PRCH_DESC").ToString, _
                                        TransferReader.Item("PRCH_CATG").ToString, _
                                        TransferReader.Item("PRCH_PACK").ToString, _
                                        TransferReader.Item("PRCH_PRICE").ToString)
                    Else
                        'UPDATE RECORD INTO PRODUCT TABLE
                        UpdtRecQuery = "UPDATE PRODUCTS SET " & _
                                                    "PROD_PPRICE = " & Val(TransferReader.Item("PRCH_PRICE").ToString) & ", " & _
                                                    "PROD_ONHAND = PROD_ONHAND + " & Val(TransferReader.Item("PRCH_QTY").ToString) & ", " & _
                                                    "PROD_SCH1_PRICE = PROD_SCH1_PRICE + " & Val(TransferReader.Item("PRCH_SCH1_PRICE").ToString) & ", " & _
                                                    "PROD_SCH1_ONHAND = PROD_SCH1_ONHAND + " & Val(TransferReader.Item("PRCH_SCH1_ONHAND").ToString) & ", " & _
                                                    "PROD_SCH2_PRICE = PROD_SCH2_PRICE + " & Val(TransferReader.Item("PRCH_SCH2_PRICE").ToString) & ", " & _
                                                    "PROD_SCH2_ONHAND = PROD_SCH2_ONHAND + " & Val(TransferReader.Item("PRCH_SCH2_ONHAND").ToString) & ", " & _
                                                    "PROD_SCH3_PRICE = PROD_SCH3_PRICE + " & Val(TransferReader.Item("PRCH_SCH3_PRICE").ToString) & ", " & _
                                                    "PROD_SCH3_ONHAND = PROD_SCH3_ONHAND + " & Val(TransferReader.Item("PRCH_SCH3_ONHAND").ToString) & ", " & _
                                                    "PROD_DATE = '" & Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "', " & _
                                                    "PROD_UPD_ON = '" & Format(Date.Parse(txtDate.Text.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                                    "WHERE (PROD_CD = N'" & TransferReader.Item("PRCH_CD").ToString & "')"
                    End If
                    ExecuteAdapterQuery(TransferAdapter, UpdtRecQuery, Connection)

                    ' To update suppliers balances
                    Max_ID = GenerateMax_ID("SUPPLIERS", "SUPL_CODE")
                    If Max_ID = 1 Then Max_ID = Max_ID + 1000

                    Dim Total_Amount As Double = (Val(TransferReader.Item("PRCH_PRICE").ToString) * Val(TransferReader.Item("PRCH_QTY").ToString) + _
                                                  Val(TransferReader.Item("PRCH_SCH1_PRICE").ToString) * Val(TransferReader.Item("PRCH_SCH1_ONHAND").ToString) + _
                                                  Val(TransferReader.Item("PRCH_SCH2_PRICE").ToString) * Val(TransferReader.Item("PRCH_SCH2_ONHAND").ToString) + _
                                                  Val(TransferReader.Item("PRCH_SCH3_PRICE").ToString) * Val(TransferReader.Item("PRCH_SCH3_ONHAND").ToString))


                    Dim Total_Quantity As Double = Val(TransferReader.Item("PRCH_QTY").ToString) + _
                                                   Val(TransferReader.Item("PRCH_SCH1_ONHAND").ToString) + _
                                                   Val(TransferReader.Item("PRCH_SCH2_ONHAND").ToString) + _
                                                   Val(TransferReader.Item("PRCH_SCH3_ONHAND").ToString)

                    ' To update journal transactions
                    If Total_Amount > 0 Then
                        'MsgBox(Mid(TransferReader.Item("PRCH_SUPPLIER").ToString, 8, 42))
                        'Dim SupplierName As String = Mid(TransferReader.Item("PRCH_SUPPLIER").ToString, 8, 42)
                        Supplr_ID = Supplier_ID(Mid(TransferReader.Item("PRCH_SUPPLIER").ToString, 8, 42))

                        Call Updt_General_Journal(Total_Amount, Total_Quantity, Supplr_ID, TransferReader.Item("PRCH_DATE").ToString, TransferReader.Item("PRCH_DESC").ToString)
                        If CheckRecordExists(Mid(TransferReader.Item("PRCH_SUPPLIER").ToString, 1, 4), "SUPPLIERS", "SUPL_CODE") = True Then
                            'TEMPORARILY SKIP
                            'Clos_Balance = "INSERT INTO SUPPLIERS VALUES (" & _
                            '                            Max_ID & ",'" & _
                            '                            TransferReader.Item("PRCH_SUPPLIER").ToString.Trim & "','" & _
                            '                            "x','" & _
                            '                            "x','" & _
                            '                            "x','" & _
                            '                            "x'," & _
                            '                            Total_Amount & ",'" & _
                            '                            Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "')"
                            'Else
                            Clos_Balance = "UPDATE SUPPLIERS SET " & _
                                                        "SUPL_BALANCE = SUPL_BALANCE + " & _
                                                        Total_Amount & ", SUPL_UPD_DT = N'" & _
                                                        Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "' " & _
                                                        "WHERE SUPL_CODE = N'" & Supplr_ID & "'"
                        End If
                        ExecuteAdapterQuery(SqlDataAdapter, Clos_Balance, Connection)
                    End If
                    'To upddate status of purchases to avoid duplication
                    Call ValidatePurchases(TransferReader.Item("PRCH_CD").ToString, TransferReader.Item("PRCH_DATE").ToString)
                    Total_Amount = Nothing
                Else
                    'Skip Check
                End If
            End While
            If TransferReader Is Nothing Then TransferReader.Close()
            BindingNavigatorSaveItem.Enabled = False
            DataFinalize = True
        End If
        GridEdit = False
        Call RefreshGridView()
        'Else
        'gblMessage = "Please select valid wholesaler for purchases."
        'frmMsgStatus.ShowDialog(Me)
        'End If
    End Sub

    Private Function CheckRecordExists(ByVal strFind As String, ByVal tblName As String, ByVal strField As String) As Boolean

        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")

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

    Private Sub AddNewItem(ByVal strCode As String, ByVal strName As String, ByVal strCatg As String, ByVal strPack As String, ByVal strPrice As String)
        'Function to add item if does not exist in item table.
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        If CheckRecordExists(strCode.ToString, "ITEMS", "ITEM_CODE") = False Then
            Dim cmdText As String = _
               ("INSERT INTO ITEMS VALUES ('" & strCode.Trim & "','" & strName.Trim & "','" & strCatg.Trim & "','" & strPack.Trim & "'," & Val(strPrice) & ")")

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
        End If
    End Sub

    Private Function ValidateDelete(ByVal strFind As String, ByVal strDate As String) As Boolean
        'Function to check status of purchases transactions
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim cmdText As String = _
           ("SELECT * FROM PURCHASE WHERE (PRCH_CD = N'" & strFind.Trim & "' AND PRCH_STATUS = N'UPDATED' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(strDate.Trim), "yyyy-MM-dd") & " 00:00:00',102))")

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

    Private Sub ValidatePurchases(ByVal strFind As String, ByVal strDate As String)
        'Procedure to update status of purchases to avoid duplication
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim cmdText As String = _
           ("UPDATE PURCHASE SET PRCH_STATUS = N'UPDATED' WHERE (PRCH_CD = N'" & strFind.Trim & "' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(strDate.Trim), "yyyy-MM-dd") & " 00:00:00',102))")

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader

                End Using
            End Using
        End Using

    End Sub

    Private Sub Updt_General_Journal(ByVal strPrice As Double, ByVal Total_Qty As Double, ByVal strSupplierID As Integer, ByVal strDate As String, ByVal strDesc As String)
        ' To made general journal transaction for concerned suppliers while update products
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim Trans_ID, Opn_Bal, Clo_Bal As Double
        Dim Supplier_Name As String = String.Empty
        Trans_ID = 0
        Opn_Bal = 0
        Clo_Bal = 0

        Dim Max_Tr As Double = GenerateMax_ID("SUPPLIERS_PAYM", "SUPL_TR_ID")

        Dim Get_Supplier As String = "select * from suppliers where supl_code = " & strSupplierID
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Supplier_Name = SuppliersReader.Item("SUPL_NAME").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("SUPL_BALANCE").ToString.Trim)
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        Else
            Opn_Bal = 0
        End If

        Trans_ID = GenerateMax_ID("SUPPLIERS_PAYM", "SUPL_TR_ID")
        Clo_Bal = Opn_Bal + strPrice

        Dim cmdText As String = _
           ("INSERT INTO SUPPLIERS_PAYM VALUES ('" & strSupplierID & "','" & Format(Date.Parse(txtDate.Text.ToString), "MM/dd/yyyy") & "','" & Trans_ID & "','" & Supplier_Name.ToString.Trim & "','" & "Purchases (" & strDesc.Trim & ") Qty. (" & Total_Qty & ")'," & Opn_Bal & ",0," & strPrice & "," & Clo_Bal & ",'" & Format(Date.Parse(strDate.ToString), "MM/dd/yyyy") & "')")

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

    Private Sub UpdateProduct(ByVal strFind As String, ByVal strField As String, ByVal strFieldData As String)
        'Procedure to update status of purchases to avoid duplication
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim cmdText As String = _
           ("UPDATE products SET " & strField & " = " & strFieldData & " WHERE (PROD_CD = N'" & strFind.Trim & "'")

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader

                End Using
            End Using
        End Using

    End Sub

#End Region

    Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
        Call RefreshGridView()
    End Sub

    Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
        Call RefreshGridView()
    End Sub

    Private Sub BindingNavigatorRefreshItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorRefreshItem.Click
        Call RefreshTextBoxes()
        Me.txtCode.Clear()
        editmode = False
        txtCode.ReadOnly = False
        txtDesc.ReadOnly = False
        Me.txtCode.Focus()
    End Sub

    Private Sub frmPurchases_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F3 Then Call Get_Text_Values() : editmode = True
        If e.KeyCode = Keys.F8 Then Call PurchaseDataGridView_KeyUp(sender, e)
    End Sub

    Private Sub PurchaseDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PurchaseDataGridView.CellClick
        Call BindingNavigatorRefreshItem_Click(sender, e)
    End Sub

    Private Sub PurchaseDataGridView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PurchaseDataGridView.KeyUp

        If e.KeyCode = Keys.F8 Then
            'Move values from datagrid to variables for deletion
            Dim DeleteID As String = PurchaseDataGridView.CurrentRow.Cells(0).Value.ToString
            Dim DeleteString As String = PurchaseDataGridView.CurrentRow.Cells(1).Value.ToString
            Dim DeleteDate As String = PurchaseDataGridView.CurrentRow.Cells(5).Value.ToString

            If PurchaseDataGridView.CurrentRow.Cells(0).Value Is Nothing Then Exit Sub
            'Validate deletion if true then show the message on screen.
            If ValidateDelete(DeleteString, DeleteDate) = False Then
                Dim mResult As String = MsgBox("Are you sure ot delete " & DeleteString, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Entry")
                If mResult = MsgBoxResult.Yes Then
                    ExecuteAdapterQuery(SqlDataAdapter, "DELETE FROM PURCHASE WHERE PRCH_TR_ID = N'" & DeleteID & "' AND PRCH_STATUS != N'UPDATED' AND PRCH_CD = N'" & DeleteString.Trim & "' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(DeleteDate), "yyyy-MM-dd") & " 00:00:00',102)", Connection)
                    Call BindingNavigatorRefreshItem_Click(sender, e)
                    Call RefreshGridView()
                End If
            Else
                gblMessage = ("Product updated, Changes cannot be made now, you must be use purchase return option.")
                MsgStatus.ShowDialog(Me)
            End If

        End If
    End Sub

    Public Function Supplier_ID(ByVal strName As String) As Integer
        Dim ID_Text As String = "SELECT SUPL_CODE FROM SUPPLIERS WHERE SUPL_NAME = N'" & strName.Trim & "'"
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(ID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    Supplier_ID = 0
                Else
                    Supplier_ID = Convert.ToDecimal(Cmd.ExecuteScalar())
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return Supplier_ID
        End Using
    End Function

End Class
