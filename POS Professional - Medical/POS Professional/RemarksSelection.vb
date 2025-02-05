
Public Class RemarksSelection

    Private Sub rmkComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rmkComboBox.KeyDown
        If e.KeyCode = Keys.Escape Then gblCP_ID = String.Empty : Me.Close()
        If e.KeyCode = Keys.Enter Then
            gblInput = rmkComboBox.Text.ToUpper.ToString.Trim
            Me.Close()
        End If
    End Sub
End Class