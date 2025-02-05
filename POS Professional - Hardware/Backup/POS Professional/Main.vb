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
        If e.KeyCode = Keys.F11 AndAlso e.Modifiers = Keys.Control Then ProductSearch.Show(Me)
    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ServerDatabase = ServerDatabase
        ServerName = ServerName
        gblRelation = False
        ProcessTransaction("DELETE FROM SALE_MASTER_TEMP")
        ProcessTransaction("DELETE FROM SALE_DETAIL_TEMP")
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

    Private Sub cmdSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSale.Click
        Call ShowForm(SaleScreen)
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
End Class
