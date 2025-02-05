Public Class Maintenance
    Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsers.Click
        SystemUsers.MdiParent = Main
        SystemUsers.Show()
    End Sub

    Private Sub cmdBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackup.Click
        BackupData.MdiParent = Main
        BackupData.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EditSaleInvoice.MdiParent = Main
        EditSaleInvoice.Show()
    End Sub

    Private Sub cmdCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompany.Click
        ShopInfo.MdiParent = Main
        ShopInfo.Show()
    End Sub
End Class