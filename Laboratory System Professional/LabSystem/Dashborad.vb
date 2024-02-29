Imports System
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared

Public Class Dashborad
    Dim Row As String()
    Dim CurrentPath As String = Directory.GetCurrentDirectory()

    Private Sub Dashborad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Application.Info.ProductName & Space(2) & "(" & Me.Text & ")"
        RptUser = "ALL"
        gblReportOption = "STATEMENT"
        fromDate = DateTime.Parse(Now.ToShortDateString)
        toDate = DateTime.Parse(Now.ToShortDateString)
        gblReportName = CurrentPath & "\" & "Reports\DailyStatement.rpt"

        Call GetConnectionString()
        CrystalReportViewer.ReportSource = Nothing

        Try
            SqlDataSet.Clear()
            'Set Connection Information for run the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "LAB_PRO"

            Call GenerateDuesReport()
            Dim CommandText As String = ""
            CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "PATIENT", Connection)

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
            objReport.SetDataSource(SqlDataSet.Tables("patient"))

            With objReport
                If gblReportOption = "STATEMENT" Or gblReportOption = "DUESSTAT" Or _
                    gblReportOption = "PAYSTAT" Or gblReportOption = "SPCPAYSTAT" Or _
                    gblReportOption = "HRSTATEMENT" Or gblReportOption = "PATIENTSTAT" Then

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
                ' IF REPORT BELONGS TO DAILY CASH STATEMENT
                If gblReportOption.ToUpper = "STATEMENT" Then
                    crParameterDiscreteValue.Value = StrConv(RptUser.Trim, VbStrConv.Uppercase)
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("Operator")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If
            End With
            CrystalReportViewer.ShowCloseButton = False
            CrystalReportViewer.ShowGroupTreeButton = False

            Dim TestCount As String = "select count(tcatg) as Count_Expression, tcatg from receipt where tdate = '" & Format(fromDate, "MM/dd/yyyy") & "' group by tcatg"
            Execute_DatabaseTable_Query(SqlDataAdapter, TestCount, Connection)
            Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    'Add row with data in the datagrid
                    Row = New String() {reader.Item("tcatg"), reader.Item("Count_Expression")}
                    DataGridView.Rows.Add(Row)
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub GenerateDuesReport()
        Try
            Dim CommandText As String = "DELETE FROM DUES_TEMP"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "DUES_TEMP", Connection)
            Connection.Close()
            CommandText = "INSERT INTO DUES_TEMP (P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR) SELECT P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR FROM PATIENT WHERE p_due_rcv_date >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_due_rcv_date <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUE_RCV > 0)ORDER BY p_num"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "DUES_TEMP", Connection)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        CrystalReportViewer.PrintReport()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Connection.Close()
        Me.Close()
    End Sub
End Class