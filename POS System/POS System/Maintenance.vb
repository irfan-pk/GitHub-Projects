Public Class Maintenance
    Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsers.Click
        frmSysUser.MdiParent = frmMain.Parent
        frmSysUser.ShowDialog(Me)
    End Sub

    Private Sub cmdBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackup.Click
        frmBackupData.MdiParent = frmMain.Parent
        frmBackupData.ShowDialog(Me)
    End Sub
End Class