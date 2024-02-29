Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmCategoryWiseStat

    Dim Filler As SqlDataReader

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        SqlDataSet.Clear()
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click

        Dim FormReportChoice As Integer = 0
        Dim currentpath As String = Directory.GetCurrentDirectory()

        If rdXrayStat.Checked = True Then
            gblReportOption = "XRAY"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\XrayWiseStatement.rpt"

        End If

        If rdSonoStat.Checked = True Then
            gblReportOption = "SONOGRAPHY"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\SonographyWiseStatement.rpt"

        End If

        If rdECGStat.Checked = True Then
            gblReportOption = "ECG"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\ECGWiseStatement.rpt"
        End If

        frmCategoryReports.MdiParent = frmMain
        frmCategoryReports.Show()

    End Sub

    Private Sub frmDailyStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        fromDate = Now()
        toDate = Now()

    End Sub

End Class