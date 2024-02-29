Imports System.IO
Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ReportPreviewForm
    Dim CurrentPath As String = Directory.GetCurrentDirectory()
    Dim ReportQuery As String = String.Empty
    Dim TableName As String = String.Empty

    Private Sub ReportPreviewForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        LabReportViewer.ReportSource = Nothing
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ReportPreviewForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        LabReportViewer.ReportSource = Nothing
        'Try
        SqlDataSet.Clear()
        'Set Connection Information to view the report
        ConnInfo.ConnectionInfo.UserID = ServerID
        ConnInfo.ConnectionInfo.Password = ServerPwd
        ConnInfo.ConnectionInfo.ServerName = ServerName
        ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase

        ReportQuery = "select * from rpt_result where LABNO = " & gblPrintLabId & " AND RPTCODE = '" & gblPrintReportCode & "' order by sort_order"
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, ReportQuery, "rpt_result", Connection)

        'Set report source
        LabReportViewer.ReportSource = objReport
        ' Load Report in memory for View
        'Try
        objReport.Load(gblPrintFileName.Trim)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        '    Exit Sub
        'End Try
        'Set server and logon information to reports for preview
        For intCounter = 0 To objReport.Database.Tables.Count - 1
            objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
        Next
        objReport.SetDatabaseLogon(ServerID, ServerPwd)
        'Set the Datasource for reports
        objReport.SetDataSource(SqlDataSet.Tables("rpt_result"))
        'Pass the value to crystal report parameter
        With objReport
            crParameterDiscreteValue.Value = gblRptRmkDetail.Trim
            crParameterFieldDefinitions = .DataDefinition.ParameterFields
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("Remarks")
            crParameterValues = crParameterFieldDefinition.CurrentValues
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
        End With
        LabReportViewer.ShowCloseButton = False
        LabReportViewer.ShowGroupTreeButton = False

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try
    End Sub
End Class