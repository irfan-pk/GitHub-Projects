
Public Class MsgStatus

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub MsgStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Label1.Text = gblMessage
    End Sub

End Class