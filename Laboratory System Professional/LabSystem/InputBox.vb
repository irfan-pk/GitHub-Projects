Public Class InputBox

    Private Sub frmInputBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtInput.Focus()
        txtInput.SelectAll()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        gblInput = txtInput.Text.Trim.ToUpper
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        gblInput = "0"
        Me.Close()
    End Sub

    Private Sub txtInput_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInput.GotFocus
        txtInput.SelectAll()
    End Sub

    Private Sub txtInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            gblInput = txtInput.Text.Trim.ToUpper
            Me.Close()
        End If
    End Sub

End Class