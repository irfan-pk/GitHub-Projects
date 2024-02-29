Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SalaryReports

    Private Sub crvSalaryReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvSalaryReports.Load
        Call GetConnectionString()

        Try
            SqlDataSet.Clear()
            'Set Connection Information for run the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase

            Dim CommandText As String = ""

            If gblReportOption = "Advance" Then
                CommandText = "Select * from salary_advances where month = N'" & gblPayrolMonth.Trim & "' order by employeeid, advdate"
                gblTableName = "salary_advances"
            End If

            If gblReportOption = "Salary" Then
                CommandText = "Select * from salary_sheet where salarymonth = N'" & gblPayrolMonth.Trim & "' order by empid"
                gblTableName = "salary_sheet"
            End If

            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, gblTableName, Connection)
            'Set report source
            crvSalaryReports.ReportSource = objReport
            ' Load Report in memory for View
            Try
                objReport.Load(gblReportName.Trim)
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
            objReport.SetDataSource(SqlDataSet.Tables(gblTableName))

            crvSalaryReports.ShowCloseButton = True
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

End Class