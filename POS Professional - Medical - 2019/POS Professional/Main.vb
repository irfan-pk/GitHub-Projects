Imports System
Imports System.Threading
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Main
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Main_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If gblPrliviges < 3 Then _
        If e.KeyCode = Keys.F10 AndAlso e.Modifiers = Keys.Control Then EditSaleInvoice.Show(Me)
    End Sub

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

    Private Sub cmdProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProduct.Click
        Call ShowForm(StockMenu)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
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

    Public Sub ShowForm(ByVal ChildForm As Form)
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub cmdCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompany.Click
        If gblPrliviges < 2 Then
            Call ShowForm(WholesalersMenu)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub cmdCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomer.Click
        If gblPrliviges < 2 Then
            Call ShowForm(CustomerMenu)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub cmdSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call ShowForm(SaleScreen)
    End Sub

    Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSystem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(Maintenance)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub cmdViewSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewSale.Click
        Call ShowForm(SaleView)
    End Sub

    Private Sub UsersCodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersCodesToolStripMenuItem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(UsersRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub AreaCodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaCodesToolStripMenuItem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(AreaRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub CompaniesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompaniesToolStripMenuItem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(CompanyRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub CityCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityCodeToolStripMenuItem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(CityRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub ItemCodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemCodesToolStripMenuItem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(ItemRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Connection.Close()
        Application.Exit()
    End Sub

    Private Sub SalesInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesInvoiceToolStripMenuItem.Click
        SaleInvoice.MdiParent = Me
        SaleInvoice.Show()
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsToolStripMenuItem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(AccountRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub ReferenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferenceToolStripMenuItem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(DoctorsRegistration)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub PurchaseInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseInvoiceToolStripMenuItem.Click
        PurchaseInvoice.MdiParent = Me
        PurchaseInvoice.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StripStatusLabel7.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub LedgersTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgersTransactionsToolStripMenuItem.Click
        If gblPrliviges < 2 Then
            Call ShowForm(JournalTransaction)
        Else
            MsgBox("You are not authorized.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub
End Class
