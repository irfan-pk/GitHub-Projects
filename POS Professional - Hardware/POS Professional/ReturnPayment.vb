Imports System.Data

Public Class ReturnPayment
    Private Sub txtCash_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCash.GotFocus
        txtCash.SelectAll()
    End Sub

    Private Sub txtCash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtCash.Text.Trim) > Val(txtNetTotal.Text) Then gblMessage = "Return Amount more than Total." : MsgStatus.ShowDialog() : Exit Sub
            cmdPay.Enabled = True
            cmdPay.Focus()
        End If
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        ValidateNumbersOnly(sender, e, txtCash)
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
        txtCash.Text = 0
        txtCash.Clear()
        txtCash.Focus()
        ReturnItem = False
    End Sub

    Private Sub cmdPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPay.Click
        If Val(txtCash.Text.Trim) = 0 Or txtCash.Text = String.Empty Then
            Dim dr As DialogResult = MessageBox.Show("Item return without cash back.", My.Application.Info.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dr = Windows.Forms.DialogResult.Yes Then
                ReturnItem = True
            Else
                cmdClose_Click(sender, e)
                Exit Sub
            End If
        End If
        gblPayment = Val(txtCash.Text.Trim)
        gblDiscount = Val(txtDiscount.Text.Trim)
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

    Private Sub cmdClose_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.GotFocus
        cmdClose.BackColor = Color.FromArgb(192, 192, 255)
    End Sub

    Private Sub cmdPay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPay.GotFocus
        cmdPay.BackColor = Color.FromArgb(192, 192, 255)
    End Sub

    Private Sub cmdPay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPay.LostFocus
        cmdPay.BackColor = Color.Gray
    End Sub

    Private Sub cmdClose_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.LostFocus
        cmdClose.BackColor = Color.Gray
    End Sub

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        txtDiscount.SelectAll()
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCash.Text = Val(txtNetTotal.Text.Trim) - Val(txtDiscount.Text.Trim)
            cmdPay.Enabled = True
            cmdPay.Focus()
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        ValidateNumbersOnly(sender, e, txtDiscount)
    End Sub
End Class