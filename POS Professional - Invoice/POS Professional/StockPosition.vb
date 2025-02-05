Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class StockPosition
    Dim drag As Boolean
    Dim Total As Decimal
    Dim mousex, mousey, Pos As Integer

    Private Sub frmStockPosition_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmStockPosition_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmStockPosition_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmStockPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 10)
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + cmdClose.Width + 10)
        Call GetConnectionString()
        Try
            'Retrieve Records for datagrid view from product table
            Me.ProductDataSet.Clear()
            ProductAdapter.Dispose()
            Dim ProductQuery As String = "SELECT prod_code,prod_upd_on,prod_head,prod_stock,prod_purch_price,prod_desc,prod_catg,prod_packing,prod_units = (convert(int,prod_stock) / convert(int,prod_qty_per_unit)),prod_stock * prod_purch_price as Total_Amount,prod_sale_price FROM PRODUCTS ORDER BY PROD_CODE"
            ExecuteAdapterQuery(ProductAdapter, ProductQuery, Connection)
            ProductAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            ProductBindingSource.DataSource = Me.ProductDataSet
            ProductBindingSource.DataMember = "PRODUCTS"
            ProductDataGridView.DataSource = ProductBindingSource
            ProductDataGridView.Refresh()
            ProductDataGridView.Columns("Total_Amount").HeaderText = "Total"
            ProductDataGridView.Columns("Total_Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub BindingNavigatorFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFind.Click
        If BindingNavigatorTextBox.Text = "" Then MsgBox("Please give valid product code.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName) : Exit Sub
        Dim strCode As String
        strCode = BindingNavigatorTextBox.Text.Trim
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.ProductBindingSource.Find("PROD_CODE", strCode.Trim)
        If Not Pos = -1 Then
            Me.ProductBindingSource.Position = Pos
        End If
    End Sub

    Private Sub BindingNavigatorTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub

    Private Sub BindingNavigatorTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyUp
        If e.KeyCode = Keys.F2 Then
            ProductCode.ShowDialog(Me)
            If Len(gblItemCode) > 0 Then BindingNavigatorTextBox.Text = gblItemCode.ToUpper Else Exit Sub
        End If
    End Sub

    Private Sub CalculateTotals()
        With ProductDataGridView
            For i = 0 To ProductDataGridView.RowCount - 1
                .Rows(i).Cells(8).Value = CDbl(.Rows(i).Cells(4).Value) * CInt(.Rows(i).Cells(6).Value)
            Next
        End With
    End Sub
End Class