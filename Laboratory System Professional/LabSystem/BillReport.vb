Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class BillReport

    Private Sub frmReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
    End Sub

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        Try
            SqlDataSet.Clear()
            'Set Connection Information for run the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerPwd
            ConnInfo.ConnectionInfo.DatabaseName = "LAB_PRO"

            Dim CommandText As String = ""

            If gblReportOption.ToUpper = "DUESSTAT" Then
                If RptUser.Trim = "ALL" Then
                    If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "') AND (P_DUES > 0)"
                    If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUES > 0)"
                Else
                    If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "') AND (P_DUES > 0) AND (P_OPERATOR = '" & RptUser.Trim & "')"
                    If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_DUES > 0) AND (P_OPERATOR = '" & RptUser.Trim & "')"
                End If
            End If
            If gblReportOption.ToUpper = "PAYSTAT" Then
                If RptUser.Trim = "ALL" Then
                    If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "') AND (P_PAID > 0)"
                    If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_PAID > 0)"
                Else
                    If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "') AND (P_PAID > 0) AND (P_OPERATOR = '" & RptUser.Trim & "')"
                    If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_PAID > 0) AND (P_OPERATOR = '" & RptUser.Trim & "')"
                End If
            End If

            If gblReportOption.ToUpper = "SPCPAYSTAT" Then
                CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_PAID > 0) AND (P_REF_BY LIKE '%" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "%')"
            End If

            If gblReportOption.ToUpper = "PSTAT" Then
                If RptUser.Trim = "ALL" Then
                    If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "')"
                    If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)"
                Else
                    If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "' OR P_REF_BY = '" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "') AND (P_OPERATOR = '" & RptUser.Trim & "')"
                    If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_OPERATOR = '" & RptUser.Trim & "')"
                End If
            End If

            gblTableName = "PATIENT"

            If gblReportOption.ToUpper = "TESTSTAT" Then
                CommandText = "SELECT tname, count(tname) as test FROM Receipt where tdate >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND tdate <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) group by tname order by tname"
                gblTableName = "RECEIPT"
            End If

            If gblReportOption.ToUpper = "WEEKLY" Then
                ' SELECT SUM OF FIELDS FROM PATIENT AND INSERT INTO STATEMENT TABLE
                CommandText = "INSERT into STATEMENT (CASES,CPNAME,GROSS,DISC,CRETURN,DUES,COMPL,NET,DUERCV,OTHERCASH)" & _
                              "Select COUNT(P_NUM) EXPR1, P_REF_BY AS EXPR2, SUM(P_TOTAL) AS EXPR3, SUM(P_DISCOUNT) AS EXPR4, SUM(P_DELETE) AS EXPR5, SUM(P_DUES) AS EXPR6, " & _
                              "SUM(P_COMPLIMENT) AS EXPR7, SUM(P_PAID) AS EXPR8, SUM(P_DUE_RCV) AS EXPR9, SUM(P_OTHER) AS EXPR10 " & _
                              "from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) " & _
                              "GROUP BY P_CP ORDER BY P_CP"
                Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                Connection.Close()

                ' SUM DUES RECEIVED AND UPDATE IN STATMENT TABLE BY COLLECTION POINT
                CommandText = "UPDATE STATEMENT SET DUESADJUSTMENT = (Select SUM(P_DUE_RCV) " & _
                              "from PATIENT WHERE (P_DUE_RCV_DATE >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV_DATE <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)) " & _
                              "AND PATIENT.P_CP = STATEMENT.CPNAME GROUP BY PATIENT.P_CP)"
                Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                Connection.Close()

                ' FOR VIEW THE REPORT
                CommandText = "SELECT * FROM STATEMENT ORDER BY CPNAME"
                gblTableName = "STATEMENT"
            End If

            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, gblTableName, Connection)

            'Set report source
            CrystalReportViewer.ReportSource = objReport
            ' Load Report in memory for View
            Try
                objReport.Load(gblReportName.Trim)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try
            'Set logon information to reports for view
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next

            objReport.SetDatabaseLogon(ServerID, ServerPwd)

            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables(gblTableName))

            With objReport
                If gblReportOption.ToUpper = "WEEKLY" Or gblReportOption.ToUpper = "PSTAT" Or gblReportOption.ToUpper = "TESTSTAT" Then
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

                ' IF REPORT BELONGS TO BILL STATEMENT
                If gblReportOption.ToUpper = "DUESSTAT" Or gblReportOption = "PSTAT" Or gblReportOption = "PAYSTAT" Or gblReportOption = "SPCPAYSTAT" Then
                    crParameterDiscreteValue.Value = StrConv(gblCpName.Trim, VbStrConv.Uppercase)
                    crParameterFieldDefinitions = .DataDefinition.ParameterFields
                    crParameterFieldDefinition = crParameterFieldDefinitions.Item("CollectionPoint")
                    crParameterValues = crParameterFieldDefinition.CurrentValues
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
End Class