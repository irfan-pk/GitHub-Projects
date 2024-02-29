Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class StatReports

    Private Sub StatReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
    End Sub

    Private Sub StatReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        CrystalReportViewer.ReportSource = Nothing

        Try
            SqlDataSet.Clear()
            'Set Connection Information for run the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "LAB_PRO"

            If gblReportOption.ToUpper = "STATEMENT" Then Call GenerateDuesReport()

            Dim CommandText As String = ""

            If gblReportOption.ToUpper = "STATEMENT" Or gblReportOption.ToUpper = "HRSTATEMENT" Then
                If gblCpName.Trim = "ALL" Then
                    If RptUser.Trim <> "ALL" Or RptUser.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_OPERATOR = '" & StrConv(RptUser.Trim, VbStrConv.Uppercase) & "')"
                    If RptUser.Trim = "ALL" Or RptUser.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
                Else
                    If RptUser.Trim <> "ALL" Or RptUser.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_OPERATOR = '" & StrConv(RptUser.Trim, VbStrConv.Uppercase) & "') AND (P_CP = '" & gblCpName.Trim & "')"
                    If RptUser.Trim = "ALL" Or RptUser.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & gblCpName.Trim & "')"
                End If
            End If

            If gblReportOption.ToUpper = "DUESSTAT" Or gblReportOption = "INVDUESSTAT" Then
                If RptUser.Trim = "ALL" Then
                    If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "') AND (P_DUES > 0)"
                    If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUES > 0)"
                Else
                    If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "') AND (P_DUES > 0) AND (P_OPERATOR = '" & RptUser.Trim & "')"
                    If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUES > 0) AND (P_OPERATOR = '" & RptUser.Trim & "')"
                End If
            End If

            If gblReportOption.ToUpper = "DISCSTATEMENT" Then
                If RptUser.Trim <> "ALL" Or RptUser.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_OPERATOR = '" & StrConv(RptUser.Trim, VbStrConv.Uppercase) & "') AND (P_DUES > 0)"
                If RptUser.Trim = "ALL" Or RptUser.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUES > 0)"
            End If

            If gblReportOption.ToUpper = "PAYSTAT" Or gblReportOption = "INVPAYSTAT" Then
                If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "') AND (P_PAID > 0)"
                If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND P_PAID > 0"
            End If

            If gblReportOption.ToUpper = "PATIENTSTAT" Then
                If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "')"
                If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "SPCPAYSTAT" Then
                CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_PAID > 0) AND (P_REF_BY LIKE '%" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "%')"
                'If gblCpName.Trim = "LAB" Or gblCpName.Trim = "lab" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND P_PAID > 0"
            End If

            If gblReportOption.ToUpper = "LABRECEIPT" Then CommandText = "select * from patient where p_num = " & gblFind.Trim

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
                    crParameterValues.Clear()
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                    crParameterDiscreteValue.Value = Format(DateTime.Parse(toDate.ToString), "M/d/yyyy")
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("ToDate")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Clear()
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

                ' IF REPORT BELONGS TO DAILY CASH STATEMENT
                'If gblReportOption.ToUpper = "LABRECEIPT" Then
                '    crParameterDiscreteValue.Value = TotalTestNames
                '    crParameterFieldDefinitions = objReport.DataDefinition.ParameterFields
                '    crParameterFieldDefinition = crParameterFieldDefinitions.Item("TotalRpt")
                '    crParameterValues = crParameterFieldDefinition.CurrentValues
                '    crParameterValues.Clear()
                '    crParameterValues.Add(crParameterDiscreteValue)
                '    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                'End If

                If gblReportOption.ToUpper = "STATEMENT" Then
                    crParameterDiscreteValue.Value = StrConv(RptUser.Trim, VbStrConv.Uppercase)
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("Operator")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Clear()
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

                If gblReportOption.ToUpper = "DISCSTATEMENT" Then
                    crParameterDiscreteValue.Value = Format(DateTime.Parse(fromDate.ToString), "M/d/yyyy")
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("DiscDate")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

                'IF REPORT BELONGS TO CP STATEMENT
                If gblReportOption = "DUESSTAT" Or gblReportOption = "PAYSTAT" Or gblReportOption = "SPCPAYSTAT" Or gblReportOption = "INVDUESSTAT" Or _
                gblReportOption = "INVPAYSTAT" Or gblReportOption = "PATIENTSTAT" Then
                    crParameterDiscreteValue.Value = StrConv(gblCpName.Trim, VbStrConv.Uppercase)
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("CollectionPoint")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
                    crParameterValues.Clear()
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                End If

            End With

            CrystalReportViewer.ShowCloseButton = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub GenerateDuesReport()
        Try
            Dim CommandText As String = "DELETE FROM DUES_TEMP"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "DUES_TEMP", Connection)
            Connection.Close()

            If RptUser.Trim = "ALL" Then CommandText = "INSERT INTO DUES_TEMP (P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR) SELECT P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR FROM PATIENT WHERE p_due_rcv_date >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_due_rcv_date <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUE_RCV > 0)ORDER BY p_num"
            If RptUser.Trim <> "ALL" Then CommandText = "INSERT INTO DUES_TEMP (P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR) SELECT P_NUM,P_CP,P_DUE_RCV,P_DUE_RCV_DATE,P_DUE_RCV_OPERATOR FROM PATIENT WHERE p_due_rcv_date >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_due_rcv_date <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUE_RCV > 0) AND P_DUE_RCV_OPERATOR = '" & RptUser.ToUpper & "' ORDER BY p_num"

            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "DUES_TEMP", Connection)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

End Class