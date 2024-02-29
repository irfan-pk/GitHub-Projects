Imports System.IO
Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class CultureReportViewer
    Dim CurrentPath As String = Directory.GetCurrentDirectory()
    Dim ReportQuery As String = String.Empty
    Dim TableName As String = String.Empty

    Private Sub ReportPreviewForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ReportPreviewForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        CrystalReportViewer.ReportSource = Nothing
        Try
            SqlDataSet.Clear()
            'Set Connection Information to view the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase
            ReportQuery = "select * from patient where p_num = " & gblPrintLabId
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, ReportQuery, "patient", Connection)
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
            objReport.SetDataSource(SqlDataSet.Tables("patient"))
            With objReport
                crParameterDiscreteValue.Value = gblRptRmkDetail.Trim
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("Remarks")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            End With
            CrystalReportViewer.ShowCloseButton = False
            CrystalReportViewer.ShowGroupTreeButton = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub
End Class