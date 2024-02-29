Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmCpDuesStat
    Dim strSql As String = "SELECT * from COLLECTIONPOINT ORDER BY cp_name"
    
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Connection.Close()
        SqlDataSet.Clear()
        Me.Close()
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        RptUser = Me.cmbCpName.Text.Trim
        gblReportOption = "DUESSTAT"
        fromDate = DateTime.Parse(fromDatePick.Value)
        toDate = DateTime.Parse(toDatePick.Value)
        gblReportName = ".\" & "CpDuesStatement.rpt"
        Me.Close()
        frmReports.MdiParent = frmMain
        frmReports.Show()
    End Sub

    Private Sub frmDailyStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Dues Statement Summary"
        Dim DueReader As SqlDataReader
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "COLLECTIONPOINT")
        SqlDataAdapt.Fill(SqlDataSet, "COLLECTIONPOINT")
        DueReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While DueReader.Read
            Me.cmbCpName.Items.Add(DueReader.Item("CP_NAME").ToString.Trim)
        End While
        Connection.Close()
        fromDate = Now()
        toDate = Now()
    End Sub
End Class