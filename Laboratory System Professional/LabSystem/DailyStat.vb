Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DailyStat
    Dim Filler As SqlDataReader
    Dim strCollSql As String = "SELECT * from COLLECTIONPOINT ORDER BY CP_NAME"
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
            gblReportOption = "STATEMENT"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\DailyStatement.rpt"
            FormReportChoice = 1
        End If

        If rdDailyCases.Checked = True Then
            gblReportOption = "PSTAT"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\DailyPatientStatement.rpt"
            FormReportChoice = 2
        End If

        If rdCpDues.Checked = True Then
            gblReportOption = "DUESSTAT"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\CpDuesStatement.rpt"
            FormReportChoice = 1
        End If

        If rdCpPayment.Checked = True Then
            gblReportOption = "PAYSTAT"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\CpPayStatement.rpt"
            FormReportChoice = 1
        End If

        If rdDueInvoice.Checked = True Then
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportOption = "INVDUESSTAT"
            gblReportName = currentpath & "\" & "Reports\CpDuesInvoice.rpt"
            FormReportChoice = 1
        End If

        If rdPayInvoice.Checked = True Then
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportOption = "INVPAYSTAT"
            gblReportName = currentpath & "\" & "Reports\CpPaymentInvoice.rpt"
            FormReportChoice = 1
        End If

        RptUser = Me.cmbOper.Text.Trim.ToUpper
        gblCpName = cmbCpName.Text.Trim
        If FormReportChoice = 1 Then StatReports.ShowDialog()
        If FormReportChoice = 2 Then BillReport.ShowDialog()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub frmDailyStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, strUserSql, "USERNAME", Connection)
        SqlDataAdapter.Fill(SqlDataSet, "USERS")
        Filler = SqlDataAdapter.SelectCommand.ExecuteReader()
        While Filler.Read
            Me.cmbOper.Items.Add(Filler.Item("USERNAME").ToString.Trim)
        End While
        If Not Filler Is Nothing Then Filler.Close()
        Connection.Close()
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, strCollSql, "COLLECTIONPOINT", Connection)
        SqlDataAdapter.Fill(SqlDataSet, "COLLECTIONPOINT")
        Filler = SqlDataAdapter.SelectCommand.ExecuteReader()
        While Filler.Read
            Me.cmbCpName.Items.Add(Filler.Item("CP_NAME").ToString.Trim)
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
        Execute_DatabaseTable_Query(SqlDataAdapter, DelQuery, Connection)
        Connection.Close()

    End Sub

End Class