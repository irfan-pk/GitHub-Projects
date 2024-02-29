'Imports CrystalDecisions.Shared
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Data
'Imports System.Data.Sql
'Imports System.Data.SqlClient

Public Class frmBillReport

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
            'Set Connection Information for PREVIEW the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerPwd
            ConnInfo.ConnectionInfo.DatabaseName = "XLAB"

            Dim CommandText As String = ""

            If gblReportOption.ToUpper = "STOCK" Then
                CommandText = "Select * from INV_TRANS WHERE TRS_DATE >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MMM-dd") & " 00:00:00',102) AND TRS_DATE <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MMM-dd") & " 00:00:00',102)"
            End If

            If gblReportOption.ToUpper = "DUESSTAT" Then
                If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MMM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MMM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "') AND (P_DUES > 0)"
                If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MMM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MMM-dd") & " 00:00:00',102) AND (P_DUES > 0)"
            End If

            If gblReportOption.ToUpper = "PAYSTAT" Then
                If gblCpName.Trim <> "ALL" Or gblCpName.Trim <> "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MMM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MMM-dd") & " 00:00:00',102) AND P_CP = '" & StrConv(gblCpName.Trim, VbStrConv.ProperCase) & "' AND (P_PAID > 0)"
                If gblCpName.Trim = "ALL" Or gblCpName.Trim = "all" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MMM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MMM-dd") & " 00:00:00',102) AND (P_PAID > 0)"
            End If

            If gblReportOption.ToUpper = "SPCPAYSTAT" Then
                CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MMM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MMM-dd") & " 00:00:00',102) AND (P_PAID > 0) AND (P_REF_BY LIKE '%" & StrConv(gblCpName.Trim, VbStrConv.Uppercase) & "%')"
            End If

            If gblReportOption.ToUpper = "WEEKLY" Then

                ' SELECT SUM OF FIELDS FROM PATIENT AND INSERT INTO STATEMENT TABLE
                CommandText = "INSERT into STATEMENT (CASES,CPNAME,GROSS,DISC,CRETURN,DUES,COMPL,NET,DUERCV,OTHERCASH)" & _
                              "Select COUNT(P_NUM) EXPR1, P_CP AS EXPR2, SUM(P_TOTAL) AS EXPR3, SUM(P_DISCOUNT) AS EXPR4, SUM(P_DELETE) AS EXPR5, SUM(P_DUES) AS EXPR6, " & _
                              "SUM(P_COMPLIMENT) AS EXPR7, SUM(P_PAID) AS EXPR8, SUM(P_DUE_RCV) AS EXPR9, SUM(P_OTHER) AS EXPR10 " & _
                              "from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) " & _
                              "GROUP BY P_CP ORDER BY P_CP"
                Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                Connection.Close()

                ' SUM DUES RECEIVED AND UPDATE IN STATMENT TABLE BY COLLECTION POINT
                CommandText = "UPDATE STATEMENT SET DUESADJUSTMENT = (Select SUM(P_DUE_RCV) " & _
                              "from PATIENT WHERE (P_DUE_RCV_DATE >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV_DATE <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)) " & _
                              "AND PATIENT.P_CP = STATEMENT.CPNAME GROUP BY PATIENT.P_CP)"
                Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                Connection.Close()

                ' FOR VIEW THE REPORT
                CommandText = "SELECT * FROM STATEMENT ORDER BY CPNAME"

            End If
            If gblReportOption = "STOCK" Then
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "INV_TRANS", Connection)
            Else
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT", Connection)
            End If
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

            'objReport.SetDatabaseLogon(ServerID, ServerPwd)

            'Set the Datasource for reports

            If gblReportOption = "STOCK" Then
                objReport.SetDataSource(SqlDataSet.Tables("INV_TRANS"))
            Else
                objReport.SetDataSource(SqlDataSet.Tables("patient"))
            End If
            With objReport
                If gblReportOption.ToUpper = "WEEKLY" Then
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

                ' IF REPORT BELONGS TO BILL STATEMENT
                If gblReportOption.ToUpper = "DUESSTAT" Or gblReportOption = "PAYSTAT" Or gblReportOption = "SPCPAYSTAT" Then
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