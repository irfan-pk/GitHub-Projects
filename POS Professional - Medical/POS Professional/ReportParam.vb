Public Class ReportParam

    Private Sub ReportParam_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        mtbStartDate.Focus()
    End Sub

    Private Sub ReportParam_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then Me.Close()
        If e.KeyCode = Keys.F10 Then

        End If
    End Sub
End Class