Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmDailyStatSpc
    Dim Filler As SqlDataReader
    Dim strCollSql As String = "SELECT * from COLLECTIONPOINT ORDER BY CP_ID"
    Dim strUserSql As String = "SELECT * from USERS ORDER BY USERNAME"

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        SqlDataSet.Clear()
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click

        Me.Cursor = Cursors.WaitCursor
        Dim FormReportChoice As Integer = 0
        Dim currentpath As String = Directory.GetCurrentDirectory()

        RptUser = cmbOper.Text.Trim.ToUpper

        'For PCR Reports
        If rdPCRDaily.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "PCRSTATEMENT1"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\PCRDailyStatement.rpt"
        End If

        If rdPCRDetail.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "PCRSTATEMENT2"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\DailyPCRPatientStat.rpt"
        End If

        'For SPECIAL Cases Reports
        If rdSTDaily.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "STSTATEMENT1"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\STDailyStatement.rpt"
        End If

        If rdSTDetail.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "STSTATEMENT2"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\DailySTPatientStat.rpt"
        End If

        'For GX PCR Reports
        If rdGXDaily.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "GXSTATEMENT1"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\GXDailyStatement.rpt"
        End If

        If rdGXDetail.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "GXSTATEMENT2"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\DailyGXPatientStat.rpt"
        End If

        'For National Reports
        If rdNSummary.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "NPSTATEMENT1"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\NationalDailyStatement.rpt"
        End If

        If rdNDetail.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "NPSTATEMENT2"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\DailyNationalPatientStat.rpt"
        End If

        frmReportsSpc.MdiParent = frmMain : frmReportsSpc.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub frmDailyStatSpc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strUserSql, "USERNAME", Connection)
        SqlDataAdapt.Fill(SqlDataSet, "USERS")
        Filler = SqlDataAdapt.SelectCommand.ExecuteReader()
        While Filler.Read
            Me.cmbOper.Items.Add(Filler.Item("USERNAME").ToString.Trim)
        End While
        If Not Filler Is Nothing Then Filler.Close()
        Connection.Close()
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strCollSql, "COLLECTIONPOINT", Connection)
        SqlDataAdapt.Fill(SqlDataSet, "COLLECTIONPOINT")
        Filler = SqlDataAdapt.SelectCommand.ExecuteReader()
        While Filler.Read
            Me.cmbCpName.Items.Add(Filler.Item("CP_ID").ToString.Trim)
        End While
        If Not Filler Is Nothing Then Filler.Close()
        Connection.Close()
        fromDate = Now()
        toDate = Now()

    End Sub

End Class