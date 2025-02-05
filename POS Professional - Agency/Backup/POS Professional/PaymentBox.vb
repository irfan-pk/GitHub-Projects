Imports System.Data

Public Class PaymentBox

    Private Sub txtPaidBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtCash.Text.Trim) <> Val(txtNetTotal.Text) Then gblMessage = "Cash Amount less / more than Total." : MsgStatus.ShowDialog() : Exit Sub
            txtRefund.Text = Val(txtCash.Text) - Val(txtNetTotal.Text)
            cmdPay.Enabled = True
            cmdPay.Focus()
        End If
    End Sub

    Private Sub txtPaidBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        Call ValidateNumbersOnly(sender, e, txtCash)
    End Sub

    Private Sub PaymentBox_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCash.Focus()
    End Sub

    Private Sub PaymentBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            gblPayment = 0
            cmdPay.Enabled = False
            Me.Close()
        End If
        If e.KeyCode = Keys.F10 Then Call cmdClose_Click(sender, e)
        If e.KeyCode = Keys.F9 Then If cmdPay.Enabled = True Then Call cmdPay_Click(sender, e)
    End Sub

    Private Sub PaymentBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNetTotal.Text = gblNet
        txtDiscount.Text = gblDiscount
        txtGross.Text = gblNet + gblDiscount
        txtCash.Clear()
        txtRefund.Clear()
        txtCash.Focus()
    End Sub

    Private Sub cmdPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay.Click
        gblPayment = Val(txtCash.Text.Trim)
        gblRefund = Val(txtRefund.Text.Trim)
        gblCashReceived = True
        cmdPay.Enabled = False
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        gblPayment = 0
        gblRefund = 0
        cmdPay.Enabled = False
        Me.Close()
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