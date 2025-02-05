
Public Class StockMenu
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub OpenForm(ByVal Myform As Form)
        Me.WindowState = FormWindowState.Minimized
        Myform.MdiParent = Main
        Myform.Show()
    End Sub

    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LineShape1.X2 = Me.Width - 10
        Me.LineShape2.X2 = Me.Width - 10
        Me.Left = 10
        Me.Top = 10
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cmdPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPurchase.Click
        Call OpenForm(Purchases)
    End Sub

    Private Sub frmStock_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmStock_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmStock_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQty.Click
        Call OpenForm(StockPosition)
    End Sub

    Private Sub cmdProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProd.Click
        Call OpenForm(Products)
    End Sub

    Private Sub cmdReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.Click
        Call OpenForm(PurchasesReturn)
    End Sub

    Private Sub cmdViewPrch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewPrch.Click
        Call OpenForm(PurchasesView)
    End Sub

    Private Sub cmdDepart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDepart.Click
        Call OpenForm(ItemHeads)
    End Sub

    Private Sub cmdStockReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStockReports.Click
        Call OpenForm(StockReports)
    End Sub

    Private Sub cmdItemType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdItemType.Click
        Call OpenForm(CategoryList)
    End Sub
End Class