Public Class ExtendDescription

    Private Sub ExtendDescription_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtDesc.Focus()
    End Sub

    Private Sub ExtendDescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gblExtDesc = String.Empty
        gblExtPrice = 0
        txtDesc.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub txtPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOk.Focus()
        End If
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        ValidateNumbersOnly(sender, e, txtPrice)
    End Sub

    Private Sub txtDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrice.Focus()
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        gblExtDesc = txtDesc.Text.ToUpper.Trim
        gblExtPrice = txtPrice.Text.Trim
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gblExtDesc = String.Empty
        gblExtPrice = String.Empty
        Me.Close()
    End Sub
End Class