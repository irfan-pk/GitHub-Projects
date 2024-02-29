Imports System
Imports System.IO

Public Class frmStockReport
    Dim FormReportChoice As Integer = 0
    Dim currentpath As String = Directory.GetCurrentDirectory()

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        gblReportOption = "STOCK"
        fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
        toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
        gblReportName = currentpath & "\" & "Reports\DailyStockReport.rpt"
        frmBillReport.MdiParent = frmMain
        frmBillReport.Show()
    End Sub

End Class