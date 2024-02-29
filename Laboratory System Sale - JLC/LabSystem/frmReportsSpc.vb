Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmReportsSpc

    Private Sub frmReportsSpc_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReport.ReportSource = Nothing
    End Sub

    Private Sub frmReportsSpc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        CrystalReport.ReportSource = Nothing
        Try
            SqlDataSet.Clear()
            'Set Connection Information for run the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "JLC"

            If gblReportOption.ToUpper = "PCRSTATEMENT1" Then Call GenerateDuesReport("PATIENT_PCR")
            If gblReportOption.ToUpper = "STSTATEMENT1" Then Call GenerateDuesReport("PATIENT_ST")
            If gblReportOption.ToUpper = "GXSTATEMENT1" Then Call GenerateDuesReport("PATIENT_GX")
            If gblReportOption.ToUpper = "NPSTATEMENT1" Then Call GenerateDuesReport("PATIENT_NATIONAL")

            Dim CommandText As String = ""

            If gblReportOption.ToUpper = "PCRSTATEMENT1" Then
                If RptUser.Trim <> "ALL" Or RptUser.Trim <> "all" Then CommandText = "Select * from PATIENT_PCR WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_OPERATOR = '" & StrConv(RptUser.Trim, VbStrConv.Uppercase) & "')"
                If RptUser.Trim = "ALL" Or RptUser.Trim = "all" Then CommandText = "Select * from PATIENT_PCR WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "PCRSTATEMENT2" Then
                If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT_PCR WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "')"
                If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT_PCR WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "STSTATEMENT1" Then
                If RptUser.Trim <> "ALL" Or RptUser.Trim <> "all" Then CommandText = "Select * from PATIENT_ST WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_OPERATOR = '" & StrConv(RptUser.Trim, VbStrConv.Uppercase) & "')"
                If RptUser.Trim = "ALL" Or RptUser.Trim = "all" Then CommandText = "Select * from PATIENT_ST WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "STSTATEMENT2" Then
                If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT_ST WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "')"
                If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT_ST WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "GXSTATEMENT1" Then
                If RptUser.Trim <> "ALL" Or RptUser.Trim <> "all" Then CommandText = "Select * from PATIENT_GX WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_OPERATOR = '" & StrConv(RptUser.Trim, VbStrConv.Uppercase) & "')"
                If RptUser.Trim = "ALL" Or RptUser.Trim = "all" Then CommandText = "Select * from PATIENT_GX WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "GXSTATEMENT2" Then
                If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT_GX WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "')"
                If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT_GX WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "NPSTATEMENT1" Then
                If RptUser.Trim <> "ALL" Or RptUser.Trim <> "all" Then CommandText = "Select * from PATIENT_NATIONAL WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_OPERATOR = '" & StrConv(RptUser.Trim, VbStrConv.Uppercase) & "')"
                If RptUser.Trim = "ALL" Or RptUser.Trim = "all" Then CommandText = "Select * from PATIENT_NATIONAL WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "NPSTATEMENT2" Then
                If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT_NATIONAL WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "')"
                If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT_NATIONAL WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "PCRSTATEMENT1" Or gblReportOption.ToUpper = "PCRSTATEMENT2" Then ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT_PCR", Connection)
            If gblReportOption.ToUpper = "STSTATEMENT1" Or gblReportOption.ToUpper = "STSTATEMENT2" Then ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT_ST", Connection)
            If gblReportOption.ToUpper = "GXSTATEMENT1" Or gblReportOption.ToUpper = "GXSTATEMENT2" Then ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT_GX", Connection)
            If gblReportOption.ToUpper = "NPSTATEMENT1" Or gblReportOption.ToUpper = "NPSTATEMENT2" Then ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT_NATIONAL", Connection)

            'Set report source
            CrystalReport.ReportSource = objReport
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
            If gblReportOption = "PCRSTATEMENT1" Or gblReportOption = "PCRSTATEMENT2" Then objReport.SetDataSource(SqlDataSet.Tables("patient_pcr"))
            If gblReportOption = "STSTATEMENT1" Or gblReportOption = "STSTATEMENT2" Then objReport.SetDataSource(SqlDataSet.Tables("patient_st"))
            If gblReportOption = "GXSTATEMENT1" Or gblReportOption = "GXSTATEMENT2" Then objReport.SetDataSource(SqlDataSet.Tables("patient_gx"))
            If gblReportOption = "NPSTATEMENT1" Or gblReportOption = "NPSTATEMENT2" Then objReport.SetDataSource(SqlDataSet.Tables("patient_national"))

            With objReport
                If gblReportOption = "PCRSTATEMENT1" Or gblReportOption = "STSTATEMENT1" Or gblReportOption = "GXSTATEMENT1" Or gblReportOption = "NPSTATEMENT1" Or gblReportOption = "PCRSTATEMENT2" Or gblReportOption = "STSTATEMENT2" Or gblReportOption = "GXSTATEMENT2" Or gblReportOption = "NPSTATEMENT2" Then

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
                If gblReportOption = "PCRSTATEMENT1" Or gblReportOption = "STSTATEMENT1" Or gblReportOption = "GXSTATEMENT1" Or gblReportOption = "NPSTATEMENT1" Then
                    crParameterDiscreteValue.Value = StrConv(RptUser.Trim, VbStrConv.Uppercase)
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("Operator")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

                ' IF REPORT BELONGS TO CP DUES STATEMENT
                If gblReportOption = "PCRSTATEMENT2" Or gblReportOption = "STSTATEMENT2" Or gblReportOption = "GXSTATEMENT2" Or gblReportOption = "NPSTATEMENT2" Then
                    crParameterDiscreteValue.Value = StrConv(gblCpName.Trim, VbStrConv.Uppercase)
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("CollectionPoint")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

            End With

            CrystalReport.ShowCloseButton = False
            CrystalReport.ShowGroupTreeButton = False
            Me.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub GenerateDuesReport(ByVal tblName As String)
        Try
            Dim CommandText As String = "DELETE FROM DUES_TEMP"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "DUES_TEMP", Connection)
            Connection.Close()

            If RptUser.Trim = "ALL" Then CommandText = "INSERT INTO DUES_TEMP (P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR) SELECT P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR FROM " & tblName & " WHERE p_due_rcv_date >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_due_rcv_date <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUE_RCV > 0)ORDER BY p_num"
            If RptUser.Trim <> "ALL" Then CommandText = "INSERT INTO DUES_TEMP (P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR) SELECT P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR FROM " & tblName & " WHERE p_due_rcv_date >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_due_rcv_date <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUE_RCV > 0) AND P_DUE_RCV_OPERATOR = '" & RptUser.ToUpper & "' ORDER BY p_num"

            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "DUES_TEMP", Connection)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub
End Class