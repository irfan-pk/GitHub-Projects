Imports System.IO
Imports System.Data.SqlClient

Public Class StockReports
    Dim currentpath As String = Directory.GetCurrentDirectory()

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        SqlDataSet.Clear()
        Me.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub StockReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Dim FillCombo As String = "SELECT * FROM DEPARTMENTS ORDER BY HEAD_CATEGORY"
        ExecuteAdapterQuery(SqlDataAdapter, FillCombo, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                cmbDepartment.Items.Add(Reader.Item("HEAD_CATEGORY").ToString)
            End While
            If Reader Is Nothing Then Reader.Close()
        End If
        Dim FillCombo2 As String = "SELECT DISTINCT CATEGORY FROM CATEGORY ORDER BY CATEGORY"
        ExecuteAdapterQuery(SqlDataAdapter, FillCombo2, Connection)
        Dim Reader2 As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader2.HasRows Then
            While Reader2.Read
                cmbCategory.Items.Add(Reader2.Item("CATEGORY").ToString)
            End While
            If Reader2 Is Nothing Then Reader2.Close()
        End If
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        If rdStockList.Checked = True Then
            gblQueryText = "select * from products order by prod_head, prod_sub_catg, prod_catg"
            gblReportName = currentpath & "\" & "Reports\StockList.rpt"
        End If

        If rdStock.Checked = True Then
            gblQueryText = "select * from products order by prod_head, prod_sub_catg, prod_catg"
            gblReportName = currentpath & "\" & "Reports\StockPosition.rpt"
        End If

        If rdStockRate.Checked = True Then
            gblQueryText = "select * from products order by prod_head, prod_sub_catg, prod_catg"
            gblReportName = currentpath & "\" & "Reports\StockRate.rpt"
        End If

        If cmbDepartment.Enabled = True And cmbDepartment.Text <> String.Empty Then
            gblQueryText = "select * from products where prod_head = N'" & cmbDepartment.Text.Trim & "' order by prod_head, prod_sub_catg, prod_catg"
        End If

        If cmbCategory.Enabled = True And cmbCategory.Text <> String.Empty Then
            gblQueryText = "select * from products where prod_catg = N'" & cmbCategory.Text.Trim & "' order by prod_head, prod_sub_catg, prod_catg"
        End If

        StockReportViewer.Show()
        cmbCategory.ResetText()
        cmbDepartment.ResetText()
    End Sub

    Private Sub rdStock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdStock.Click
        cmbDepartment.Enabled = True
        cmbCategory.Enabled = True
    End Sub

    Private Sub rdStockList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdStockList.Click
        cmbDepartment.Enabled = False
        cmbCategory.Enabled = False
    End Sub

    Private Sub rdStockRate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdStockRate.Click
        cmbDepartment.Enabled = False
        cmbCategory.Enabled = False
    End Sub
End Class