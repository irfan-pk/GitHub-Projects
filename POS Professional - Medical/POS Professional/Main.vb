Imports System
Imports System.Threading
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Main
    
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
        ServerDatabase = ServerDatabase
        ServerName = ServerName
        gblRelation = False
        ProcessTransaction("DELETE FROM SALE_MASTER_TEMP")
        ProcessTransaction("DELETE FROM SALE_DETAIL_TEMP")
        StripStatusLabel2.Text = SysOperator
        StripStatusLabel4.Text = "On"
        StripStatusLabel6.Text = Format(Now.Date, "dd/MMM/yyyy")
    End Sub

    Public Sub ShowForm(ByVal ChildForm As Form)
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub UsersCodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersCodesToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(UsersRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub AreaCodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaCodesToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(AreaRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub CompaniesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompaniesToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(CompanyRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub CityCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityCodeToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(CityRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub ItemCodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemCodesToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(ItemRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        ExecuteAdapterQuery(SqlDataAdapter, "select * from sale_master_hold where saleid like '%" & gblInvPrefix.Trim & "%'", Connection)
        Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If reader.HasRows Then
            Dim response As DialogResult = MessageBox.Show("There is pending invoice, delete before quit. (Yes/No)", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = Windows.Forms.DialogResult.Yes Then
                ProcessTransaction("delete from sale_master_hold where saleid like '%" & gblInvPrefix.Trim & "%'")
                ProcessTransaction("delete from sale_detail_hold where saleid like '%" & gblInvPrefix.Trim & "%'")
            End If
        End If
        Connection.Close()
        Application.Exit()
    End Sub

    Private Sub SalesInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesInvoiceToolStripMenuItem.Click
        SaleInvoice.MdiParent = Me
        SaleInvoice.Show()
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(AccountRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub ReferenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferenceToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(DoctorsRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub PurchaseInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseInvoiceToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(PurchaseInvoice)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StripStatusLabel7.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub LedgersTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgersTransactionsToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(JournalTransaction)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub EpensesEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EpensesEntryToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(Expenses)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub SaleInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleInvoiceToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(SaleInvoiceCorrection)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub PurchaseInvoiceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseInvoiceToolStripMenuItem1.Click
        If gblPrliviges < 3 Then
            ShowForm(PurchaseInvoiceCorrection)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(Dashboard)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub CashFlowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashFlowToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(CashFlow)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub CashBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashBookToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(CashBook)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub SalesReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReturnToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(SalesReturn)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub SalesInvoicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesInvoicesToolStripMenuItem.Click
        gblReportName = String.Empty
        ShowForm(ReportParam)
    End Sub

    Private Sub PurchaseReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnToolStripMenuItem.Click
        If gblPrliviges < 3 Then
            ShowForm(PurchaseReturn)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub
End Class
