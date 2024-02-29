Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmDailyStat
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

        If rdDaily.Checked = True Then
            RptUser = Me.cmbOper.Text.Trim
            gblReportOption = "STATEMENT"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\DailyStatement.rpt"
            FormReportChoice = 1
        End If

        If rdDailyCases.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "PATIENTSTAT"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\DailyPatientStatement.rpt"
            FormReportChoice = 1
        End If

        If rdCpDues.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "DUESSTAT"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\CpDuesStatement.rpt"
            FormReportChoice = 1
        End If

        If rdCpPayment.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            gblReportOption = "PAYSTAT"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\CpPayStatement.rpt"
            FormReportChoice = 1
        End If

        If rdDueInvoice.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportOption = "INVDUESSTAT"
            gblReportName = currentpath & "\" & "Reports\CpDuesInvoice.rpt"
            FormReportChoice = 1
        End If

        If rdPeriodStat.Checked = True Then
            gblCpName = cmbCpName.Text.Trim
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportOption = "DAILY"
            gblReportName = currentpath & "\" & "Reports\PeriodicallyTestStat.rpt"
            FormReportChoice = 1
        End If

        If rdWeekMonth.Checked = True Then
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            Call Generate_Week_Month_Statement()
            gblReportOption = "WEEKLY"
            gblReportName = currentpath & "\" & "Reports\MonthlyStatement.rpt"
            FormReportChoice = 2
        End If

        If rdDailyTest.Checked = True Then
            gblReportOption = "DAILY"
            gblReportName = currentpath & "\" & "Reports\DailyTestStat.rpt"
            FormReportChoice = 1
        End If

        If FormReportChoice = 1 Then frmReports.MdiParent = frmMain : frmReports.Show()
        If FormReportChoice = 2 Then frmBillReport.MdiParent = frmMain : frmBillReport.Show()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub frmDailyStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
    Private Sub Generate_Week_Month_Statement()

        Dim StatementAdapter As New SqlDataAdapter()
        Dim TransferAdapter As New SqlDataAdapter()

        ' Delete all records for preparing fresh statement
        Dim DelQuery As String = "DELETE FROM STATEMENT"
        Execute_DatabaseTable_Query(SqlDataAdapt, DelQuery, Connection)
        Connection.Close()

    End Sub

End Class