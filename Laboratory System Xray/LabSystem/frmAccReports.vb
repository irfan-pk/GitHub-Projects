Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmAccReports

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
            ConnInfo.ConnectionInfo.DatabaseName = "XLAB"

            Dim CommandText As String = ""

            If gblReportOption = "TRIAL BALANCE" Then CommandText = "Select * from LEDGER_TRANSACTIONS ORDER BY LEDG_ACC_TYPE"

            If gblReportOption = "EXPREVENUE" Then CommandText = "Select * from LEDGER_TRANSACTIONS WHERE (LEDG_LINK = 'EXPENSES' OR LEDG_LINK = 'REVENUE') AND LEDG_DATE >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY LEDG_ACC_TYPE"

            If gblReportOption = "LEDGERS" Then CommandText = "SELECT * FROM LEDGER_TRANSACTIONS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(fromDate), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(toDate), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Val(gblFind) & ") ORDER BY LEDG_DATE, LEDG_TRAN_ID"

            If gblReportOption = "CLOSED_LEDGERS" Then CommandText = "SELECT * FROM COMPLETE_TRANSACTIONS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(fromDate), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(toDate), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Val(gblFind) & ") ORDER BY LEDG_DATE, LEDG_TRAN_ID"

            'If gblReportOption.ToUpper = "TRIAL BALANCE" Then CommandText = "SELECT * FROM LEDGER_TRANSACTIONS"

            If gblReportOption.ToUpper <> "TRIAL BALANCE" Then ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "LEDGER_TRANSACTIONS", Connection)

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
            objReport.SetDataSource(SqlDataSet.Tables("LEDGER_TRANSACTIONS"))

            With objReport
                If gblReportOption.ToUpper = "EXPREVENUE" Or gblReportOption.ToUpper = "LEDGERS" Or gblReportOption.ToUpper = "CLOSED_LEDGERS" Then
                    crParameterDiscreteValue.Value = Format(DateTime.Parse(fromDate.ToString), "M/d/yyyy")
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("OnDate")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                    crParameterDiscreteValue.Value = Format(DateTime.Parse(toDate.ToString), "M/d/yyyy")
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("ToDate")
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
                If gblReportOption.ToUpper = "INCOME STATEMENT" Or gblReportOption.ToUpper = "TRIAL BALANCE" Then
                    crParameterDiscreteValue.Value = Format(DateTime.Parse(toDate.ToString), "M/d/yyyy")
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