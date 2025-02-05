Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class AccountReports

    Private Sub frmAccReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
    End Sub

    Private Sub frmAccReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()

        Try
            SqlDataSet.Clear()
            'Set Connection Information for run the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase

            Dim CommandText As String = String.Empty

            If gblReportOption = "ADJTBALANCE" Then CommandText = "Select * from ACCOUNTS ORDER BY ACC_NO" : gblTableName = "ACCOUNTS"

            If gblReportOption = "INCOME STATEMENT" Then CommandText = "Select * from ACCOUNTS WHERE (ACC_HEAD = 'EXPENSES' OR ACC_HEAD = 'REVENUE') ORDER BY ACC_NAME" : gblTableName = "ACCOUNTS"

            If gblReportOption = "BALANCESHEET" Then CommandText = "Select * from ACCOUNTS WHERE (ACC_HEAD <> 'EXPENSES' AND ACC_HEAD <> 'REVENUE') ORDER BY ACC_NAME" : gblTableName = "ACCOUNTS"

            If gblReportOption = "LEDGERS" Or gblReportOption = "QTRSTAT" Then CommandText = "SELECT * FROM LEDGERS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(fromDate), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(toDate), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Val(gblFind) & ") ORDER BY LEDG_DATE, LEDG_TRAN_ID" : gblTableName = "LEDGERS"

            If gblReportOption = "QTRSTAT" Then CommandText = "SELECT * FROM LEDGERS" : gblTableName = "LEDGERS"

            If gblReportOption = "TRIALBALANCE" Then CommandText = "SELECT * FROM LEDGERS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(fromDate), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(toDate), "yyyy-MM-dd") & " 00:00:00', 102) ORDER BY LEDG_ACC_ID" : gblTableName = "LEDGERS"

            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, gblTableName, Connection)
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
            objReport.SetDatabaseLogon(ServerID, ServerPwd)

            'Set the Datasource for reports
            If gblReportOption <> "BALANCESHEET" Then _
                objReport.SetDataSource(SqlDataSet.Tables(gblTableName))

            With objReport
                If gblReportOption.ToUpper = "LEDGERS" Or gblReportOption.ToUpper = "CLOSED_LEDGERS" Or gblReportOption.ToUpper = "GENERAL" Then
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
                End If

                If gblReportOption.ToUpper = "QTRSTAT" Then
                    crParameterDiscreteValue.Value = Format(DateTime.Parse(toDate.ToString), "yyyy-M-d")
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("End Date")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

                If gblReportOption.ToUpper = "CLOSED_LEDGERS" Then
                    crParameterDiscreteValue.Value = intOpnDr
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("OpnDrBal")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                    crParameterDiscreteValue.Value = intOpnCr
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("OpnCrBal")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

                If gblReportOption.ToUpper = "LEDGERS" Then
                    crParameterDiscreteValue.Value = intOpnDr
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("OpnDrBal")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                    crParameterDiscreteValue.Value = intOpnCr
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("OpnCrBal")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

                ' IF REPORT BELONGS TO BILL STATEMENT
                If gblReportOption.ToUpper = "ADJTBALANCE" Or gblReportOption.ToUpper = "TRIALBALANCE" Then
                    crParameterDiscreteValue.Value = Format(DateTime.Parse(toDate.ToString), "MMM,dd/yyyy")
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("EndDate")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If
            End With

            CrystalReportViewer.ShowCloseButton = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

End Class