Imports System.IO
Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class HistopathologyReport
    Dim CurrentPath As String = Directory.GetCurrentDirectory()
    Dim ReportQuery As String = String.Empty
    Dim TableName As String = String.Empty

    Private Sub HistopathologyReport_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub HistopathologyReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        CrystalReportViewer.ReportSource = Nothing
        Try
            SqlDataSet.Clear()
            'Set Connection Information to view the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "LAB_PRO"
            ReportQuery = "select * from lab_pro.dbo.rpt_biopsy where patient_id = " & gblPrintLabId & " and biopsy_filecode='" & gblPrintReportCode & "'"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, ReportQuery, "rpt_biopsy", Connection)
            'Set report source
            CrystalReportViewer.ReportSource = objReport
            ' Load Report in memory for View
            Try
                objReport.Load(gblPrintFileName.Trim)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try
            'Set server and logon information to reports for preview
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next
            objReport.SetDatabaseLogon(ServerID, ServerPwd)
            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables("rpt_biopsy"))
            CrystalReportViewer.ShowCloseButton = False
            CrystalReportViewer.ShowGroupTreeButton = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub
End Class