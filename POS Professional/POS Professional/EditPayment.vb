Imports System.Data.SqlClient

Public Class EditPayment

    Private Sub EditPayment_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtDiscount.Focus()
    End Sub

    Private Sub EditPayment_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtCash.Text = 0
        txtDiscount.Text = 0
        txtNetTotal.Text = 0
        txtDueAmount.Text = 0
    End Sub

    Private Sub EditPayment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNetTotal.Text = gblNet
    End Sub

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        txtDiscount.SelectAll()
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then txtCash.Focus()
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        Call ValidateNumbersOnly(sender, e, txtDiscount)
    End Sub

    Private Sub txtCash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDueAmount.Text = Val(txtNetTotal.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCash.Text.Trim)
            cmdPay.Enabled = True
            cmdPay.Focus()
        End If
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        Call ValidateNumbersOnly(sender, e, txtCash)
    End Sub

    Private Sub txtDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.LostFocus
        txtDueAmount.Text = Val(txtNetTotal.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCash.Text.Trim)
    End Sub

    Private Sub cmdPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay.Click
        gblPayment = Val(txtCash.Text)
        gblDiscount = Val(txtDiscount.Text)
        gblPayment = Val(txtCash.Text)
        gblDues = Val(txtDueAmount.Text)
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        gblNet = 0
    End Sub

    Private Sub cmdPay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPay.GotFocus
        cmdPay.BackColor = Color.FromArgb(192, 192, 255)
    End Sub

    Private Sub cmdPay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPay.LostFocus
        cmdPay.BackColor = Color.Gray
    End Sub

    Private Sub cmdClose_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.GotFocus
        cmdClose.BackColor = Color.FromArgb(192, 192, 255)
    End Sub

    Private Sub cmdClose_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.LostFocus
        cmdClose.BackColor = Color.Gray
    End Sub
End Class