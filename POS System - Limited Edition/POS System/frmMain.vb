Imports System
Imports System.Threading
Imports System.Globalization
Imports System.Windows.Forms

Public Class frmMain
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Thread.CurrentThread.CurrentCulture = New CultureInfo("ur-PK", True)
        ServerDatabase = ServerDatabase
        ServerName = ServerName
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Label1.Left = Me.Width - (Label1.Width + 15)
        Me.Label4.Left = Me.Width - (Label4.Width + 15)
        Me.LineShape1.X1 = Me.Width - 310
        Me.LineShape2.X1 = Me.Width - 310
        Me.LineShape1.X2 = Me.Width - 10
        Me.LineShape2.X2 = Me.Width - 10
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 5)
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + cmdClose.Width + 5)
        gblRelation = False
    End Sub

    Private Sub cmdProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProduct.Click
        Call ShowForm(frmProducts)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub

    Public Sub ShowForm(ByVal ChildForm As Form)
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub cmdSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSale.Click
        'Call ShowForm(frmSaleMenu)
        Call ShowForm(frmSale)
    End Sub

    Private Sub cmdUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsers.Click
        Call ShowForm(frmSysUser)
    End Sub

    Private Sub cmdViewSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewSale.Click
        Call ShowForm(frmTabViewSale)
    End Sub

End Class
