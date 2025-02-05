Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SummaryReports
    Dim TableName As String

    Private Sub frmSummaryReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmSummaryReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Call GetConnectionString()
        CrystalReportViewer.ReportSource = Nothing
        'Try
        SqlDataSet.Clear()
        'Set Connection Information for view the report
        ConnInfo.ConnectionInfo.UserID = ServerID
        ConnInfo.ConnectionInfo.Password = ServerPwd
        ConnInfo.ConnectionInfo.ServerName = ServerName
        ConnInfo.ConnectionInfo.DatabaseName = "POSR"
        'Call to shift cash recovery records to temp table
        If gblReportOption.ToUpper = "STATEMENT" Then Call ShiftRec_for_SubReport()

        Dim CommandText As String = String.Empty
        'Filter sql database queries to view required report
        If gblReportFilter = "CASH" Then _
            CommandText = "Select * from SALE_MASTER WHERE DateCompleted >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) AND DateCompleted <= CONVERT(DATETIME,'" & Format(ToDate, "yyyy-MM-dd") & " 00:00:00',102)" 'AND (SaleTotal > 0) AND (SalePaid > 0) OR (SaleReturn > 0)"

        If gblReportFilter = "CREDIT" Then _
            CommandText = "Select * from SALE_MASTER WHERE DateCompleted >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) AND DateCompleted <= CONVERT(DATETIME,'" & Format(ToDate, "yyyy-MM-dd") & " 00:00:00',102) AND (SaleTotal > 0)" 'AND (SaleCredit > 0)"

        If gblReportFilter = "RECOVERY" Then _
            CommandText = "Select * from SALE_MASTER WHERE DateRecovery >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) AND DateRecovery <= CONVERT(DATETIME,'" & Format(ToDate, "yyyy-MM-dd") & " 00:00:00',102) AND (SaleTotal > 0) AND (SaleRecovery > 0)"

        If gblReportFilter = "RETURN" Then _
            CommandText = "Select * from SALE_MASTER WHERE DateCompleted >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) AND DateCompleted <= CONVERT(DATETIME,'" & Format(ToDate, "yyyy-MM-dd") & " 00:00:00',102) AND (SaleReturn > 0)"

        ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "SALE_MASTER", Connection)

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
        objReport.SetDataSource(SqlDataSet.Tables("SALE_MASTER"))

        With objReport
            If gblReportOption = "STATEMENT" Then

                crParameterDiscreteValue.Value = Format(DateTime.Parse(FromDate), "dd/MM/yyyy")
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("OnDate")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                crParameterDiscreteValue.Value = Format(DateTime.Parse(ToDate), "dd/MM/yyyy")
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("ToDate")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            End If
        End With

        CrystalReportViewer.ShowCloseButton = False
        CrystalReportViewer.ShowGroupTreeButton = False
        Me.WindowState = FormWindowState.Maximized

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try

    End Sub

    Private Sub ShiftRec_for_SubReport()
        Try
            Dim CommandText As String = "DELETE FROM SALE_MASTER_TEMP"
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            Connection.Close()
            CommandText = "INSERT INTO SALE_MASTER_TEMP SELECT * FROM SALE_MASTER WHERE SALE_MASTER.DateRecovery >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) AND SALE_MASTER.DateRecovery <= CONVERT(DATETIME,'" & Format(ToDate, "yyyy-MM-dd") & " 00:00:00',102) AND (SaleRecovery > 0)"
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

End Class