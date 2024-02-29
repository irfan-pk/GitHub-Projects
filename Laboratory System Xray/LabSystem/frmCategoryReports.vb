Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmCategoryReports

    Private Sub frmCategoryReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
    End Sub

    Private Sub frmCategoryReports_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call GetConnectionString()
        CrystalReportViewer.ReportSource = Nothing
        Try
            SqlDataSet.Clear()
            'Set Connection Information for PREVIEW the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "XLAB"

            Dim CommandText As String = ""

            If gblReportOption = "XRAY" Then CommandText = "Select * from RECEIPT WHERE TDATE >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND TDATE <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND TCATG = 'RADIOLOGY'"

            If gblReportOption = "SONOGRAPHY" Then CommandText = "Select * from RECEIPT WHERE TDATE >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND TDATE <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND TCATG = 'SONOGRAPHY'"

            If gblReportOption = "ECG" Then CommandText = "Select * from RECEIPT WHERE TDATE >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND TDATE <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND TCATG = 'CORDIOLOGY'"

            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "RECEIPT", Connection)

            'Set report source
            CrystalReportViewer.ReportSource = objReport
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

            'Set the Datasource for reports

            objReport.SetDataSource(SqlDataSet.Tables("RECEIPT"))

            With objReport
                crParameterDiscreteValue.Value = Format(DateTime.Parse(fromDate.ToString), "MM/dd/yyyy")
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("OnDate")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                crParameterDiscreteValue.Value = Format(DateTime.Parse(toDate.ToString), "MM/dd/yyyy")
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("ToDate")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            End With

            'CrystalReportViewer.ShowCloseButton = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

End Class