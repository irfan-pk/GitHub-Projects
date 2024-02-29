Public Class PrintDialog
    Private Sub PrintDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Timer1.Start()
        Timer1.Stop()
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub
End Class