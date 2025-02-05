Imports System.Data.SqlClient

Public Class JournalTransaction

    Private Sub txtDrAccount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDrAccount.KeyPress
        ValidateNumbersOnly(sender, e, txtDrAccount)
    End Sub

    Private Sub txtDrAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDrAmount.KeyPress
        ValidateNumbersOnly(sender, e, txtDrAmount)
    End Sub

    Private Sub txtCrAccount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrAccount.KeyPress
        ValidateNumbersOnly(sender, e, txtCrAccount)
    End Sub

    Private Sub txtCrAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrAmount.KeyPress
        ValidateNumbersOnly(sender, e, txtCrAmount)
    End Sub
End Class