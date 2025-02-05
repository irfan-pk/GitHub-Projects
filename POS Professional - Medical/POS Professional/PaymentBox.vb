Imports System.Data

Public Class PaymentBox

    Private Sub txtCash_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCash.GotFocus
        Get_Property_GotFocus(txtCash)
    End Sub

    Private Sub txtCash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDues.Text = Val(txtNetTotal.Text) - Val(txtCash.Text)
            gblPayment = Val(txtCash.Text)
            gblDues = Val(txtDues.Text)
            cmdPay.Enabled = True
            cmdPay.Focus()
        End If
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        Call ValidateNumbersOnly(sender, e, txtCash)
    End Sub

    Private Sub PaymentBox_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtDiscount.Focus()
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
        gblDiff = 0
        txtCash.Clear()
        txtDues.Clear()
        txtCash.Focus()
    End Sub

    Private Sub cmdPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay.Click
        gblPayment = Val(txtCash.Text.Trim)
        gblDues = Val(txtDues.Text.Trim)
        gblGross = Val(txtGross.Text.Trim)
        If gblPayment > 0 Then gblCashReceived = True
        cmdPay.Enabled = False
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        gblPayment = 0
        gblRefund = 0
        gblDues = 0
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

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        Get_Property_GotFocus(txtDiscount)
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtDiscount.Text) > gblDiscount Then
                Dim response As DialogResult = MessageBox.Show("Do you want give more discount ? (Y/N)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = Windows.Forms.DialogResult.Yes Then
                    gblDiff = Format(Val(txtDiscount.Text) - gblDiscount, "0.00")
                    gblDiscount += gblDiff
                End If
            End If
            If Val(txtDiscount.Text) < gblDiscount Then
                Dim response As DialogResult = MessageBox.Show("Do you want give less discount ? (Y/N)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = Windows.Forms.DialogResult.Yes Then
                    gblDiff = Format(Val(txtDiscount.Text) - gblDiscount, "0.00")
                    gblDiscount -= gblDiff
                End If
            End If
            txtNetTotal.Text = Val(txtGross.Text) - gblDiscount
            txtCash.Text = Val(txtNetTotal.Text)
            txtCash.Focus()
        End If
    End Sub

    Private Sub txtDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.LostFocus
        Get_Property_LostFocus(txtDiscount)
    End Sub

    Private Sub txtCash_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCash.LostFocus
        Get_Property_LostFocus(txtCash)
    End Sub
End Class