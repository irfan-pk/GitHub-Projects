Public Class Maintenance
    Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsers.Click
        UsersRegistration.MdiParent = Main
        UsersRegistration.Show()
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

    Private Sub cmdRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefer.Click
        DoctorsRegistration.MdiParent = Main
        DoctorsRegistration.Show()
    End Sub

    Private Sub cmdAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccounts.Click
        AccountRegistration.MdiParent = Main
        AccountRegistration.Show()
    End Sub

    Private Sub cmdStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStatus.Click
        Dashboard.MdiParent = Main
        Dashboard.Show()
    End Sub

    Private Sub cmdCashBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashBook.Click
        CashFlow.MdiParent = Main
        CashFlow.Show()
    End Sub

    Private Sub btnExpenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpenses.Click
        Expenses.MdiParent = Main
        Expenses.Show()
    End Sub

    Private Sub btnCashLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashLedger.Click
        CashBook.MdiParent = Main
        CashBook.Show()
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        AccountStatment.MdiParent = Main
        AccountStatment.Show()
    End Sub
End Class