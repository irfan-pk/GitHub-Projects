Public Class MultipleStone

    Private Sub MultipleStone_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            gblStoneSize = txtStones.Text.Trim
            Me.Close()
        End If
    End Sub

    Private Sub txtStones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStones.KeyDown
        If e.KeyCode = Keys.Escape Then
            gblStoneSize = txtStones.Text.Trim
            Me.Close()
        End If
    End Sub

    Private Sub txtStones_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStones.KeyUp
        If e.KeyCode = Keys.Escape Then
            gblStoneSize = txtStones.Text.Trim
            Me.Close()
        End If
    End Sub
End Class