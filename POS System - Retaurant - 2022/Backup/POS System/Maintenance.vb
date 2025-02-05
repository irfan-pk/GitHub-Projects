Public Class Maintenance
    Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsers.Click
        SysUser.MdiParent = Main.Parent
        SysUser.ShowDialog(Me)
    End Sub

    Private Sub cmdBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackup.Click
        BackupData.MdiParent = Main.Parent
        BackupData.ShowDialog(Me)
    End Sub

    Private Sub cmdUserRole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWaiters.Click
        Waiters.MdiParent = Main.Parent
        Waiters.ShowDialog(Me)
    End Sub
End Class