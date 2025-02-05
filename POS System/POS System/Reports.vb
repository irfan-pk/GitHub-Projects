Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Reports
    Dim TableName As String
    Private Sub frmReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
    End Sub

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Call GetConnectionString()
        CrystalReportViewer.ReportSource = Nothing
        'Try
        SqlDataSet.Clear()
        'Set Connection Information for PREVIEW the report
        ConnInfo.ConnectionInfo.UserID = ServerID
        ConnInfo.ConnectionInfo.Password = ServerPwd
        ConnInfo.ConnectionInfo.ServerName = ServerName
        ConnInfo.ConnectionInfo.DatabaseName = "POS"

        Dim CommandText As String = ""

        If gblReportOption.ToUpper = "DETAIL" Then
            TableName = "CUSTOMERS"
            If RptUser.ToUpper = "ALL" Then CommandText = "SELECT * FROM CUSTOMERS  ORDER BY CUST_CODE"
            If RptUser.ToUpper <> "ALL" Then CommandText = "SELECT * FROM CUSTOMERS WHERE CUST_CODE = " & Val(RptUser.Trim) & "ORDER BY CUST_CODE"
        End If

        If gblReportOption.ToUpper = "LEDGER" Then
            TableName = "CUSTOMERS_PAYM"
            If RptUser.ToUpper = "ALL" Then CommandText = "SELECT * FROM CUSTOMERS_PAYM WHERE CUST_TR_DT >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY CUST_CODE"
            If RptUser.ToUpper <> "ALL" Then CommandText = "SELECT * FROM CUSTOMERS_PAYM WHERE CUST_CODE = " & Val(RptUser.Trim) & " AND CUST_TR_DT >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY CUST_CODE"
        End If

        If gblReportOption.ToUpper = "WDETAIL" Then
            TableName = "SUPPLIERS"
            If RptUser.ToUpper = "ALL" Then CommandText = "SELECT * FROM SUPPLIERS  ORDER BY SUPL_CODE"
            If RptUser.ToUpper <> "ALL" Then CommandText = "SELECT * FROM SUPPLIERS WHERE SUPL_CODE = " & Val(RptUser.Trim) & "ORDER BY SUPL_CODE"
        End If

        If gblReportOption.ToUpper = "WLEDGER" Then
            TableName = "SUPPLIERS_PAYM"
            If RptUser.ToUpper = "ALL" Then CommandText = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY SUPL_CODE"
            If RptUser.ToUpper <> "ALL" Then CommandText = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_CODE = " & Val(RptUser.Trim) & " AND SUPL_TR_DT >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY SUPL_CODE"
        End If

        ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, TableName, Connection)

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
        objReport.SetDataSource(SqlDataSet.Tables(TableName))

        'With objReport
        '    If gblReportOption = "SUMMARY" Or gblReportOption = "WHTSUMRY" Then

        '        Dim FromPeriod, ToPeriod As String
        '        ToPeriod = toDate
        '        If (Month(fromDate) < 7) Then
        '            FromPeriod = "01-07-" & Year(fromDate) - 1
        '        Else
        '            FromPeriod = "01-07-" & Year(fromDate)
        '        End If

        '        crParameterDiscreteValue.Value = Format(DateTime.Parse(FromPeriod.ToString), "MM-dd-yyyy")
        '        'crParameterDiscreteValue.Value = FromPeriod
        '        crParameterFieldDefinitions = .DataDefinition.ParameterFields
        '        crParameterFieldDefinition = crParameterFieldDefinitions.Item("FromDate")
        '        crParameterValues = crParameterFieldDefinition.CurrentValues
        '        crParameterValues.Add(crParameterDiscreteValue)
        '        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        '        crParameterDiscreteValue.Value = Format(DateTime.Parse(ToPeriod.ToString), "MM-dd-yyyy")
        '        'crParameterDiscreteValue.Value = ToPeriod
        '        crParameterFieldDefinitions = .DataDefinition.ParameterFields
        '        crParameterFieldDefinition = crParameterFieldDefinitions.Item("ToDate")
        '        crParameterValues = crParameterFieldDefinition.CurrentValues
        '        crParameterValues.Add(crParameterDiscreteValue)
        '        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        '        If gblEndTranDt.Trim = "" Then gblEndTranDt = "01/01/1999"

        '        crParameterDiscreteValue.Value = Format(DateTime.Parse(gblEndTranDt.ToString), "dd-MMM-yyyy")
        '        'crParameterDiscreteValue.Value = ToPeriod
        '        crParameterFieldDefinitions = .DataDefinition.ParameterFields
        '        crParameterFieldDefinition = crParameterFieldDefinitions.Item("LastDate")
        '        crParameterValues = crParameterFieldDefinition.CurrentValues
        '        crParameterValues.Add(crParameterDiscreteValue)
        '        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        '    End If

        'End With

        CrystalReportViewer.ShowCloseButton = True
        CrystalReportViewer.ShowGroupTreeButton = False
        Me.WindowState = FormWindowState.Maximized

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try

    End Sub

End Class