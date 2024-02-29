Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmCpDues
    'Dim intCounter As Integer
    Dim ConnInfo As New CrystalDecisions.Shared.TableLogOnInfo
    Dim crParameterFieldDefinitions As ParameterFieldDefinitions
    Dim crParameterFieldDefinition As ParameterFieldDefinition
    Dim crParameterValues As New ParameterValues
    Dim crParameterDiscreteValue As New ParameterDiscreteValue

    Private Sub frmReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
    End Sub

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlDataSet.Clear()
            'Set Connection Information for run the report
            ConnInfo.ConnectionInfo.UserID = "sa"
            ConnInfo.ConnectionInfo.Password = "afrsim"
            ConnInfo.ConnectionInfo.ServerName = "ALD"
            ConnInfo.ConnectionInfo.DatabaseName = "ALD"

            Dim CommandText As String = ""

            If gblReportOption.ToUpper = "DUESSTAT" Then
                If RptUser.Trim <> "LAB" Or RptUser.Trim <> "lab" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "MM/dd/yyyy") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "MM/dd/yyyy") & " 00:00:00',102) AND P_OPERATOR = '" & StrConv(RptUser.Trim, VbStrConv.Uppercase) & "' AND P_DUES > 0"
                If RptUser.Trim = "LAB" Or RptUser.Trim = "lab" Then CommandText = "Select * from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "MM/dd/yyyy") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "MM/dd/yyyy") & " 00:00:00',102) AND P_DUES > 0"
            End If

            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT")
            'Set report source
            CrystalReportViewer.ReportSource = objReport
            Try
                objReport.Load(gblReportName.Trim)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
                Exit Sub
            End Try
            'Set logon information to reports for view
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next
            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables("patient"))

            With objReport
                crParameterDiscreteValue.Value = Format(fromDate, "MM/dd/yyyy")
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("OnDate")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                crParameterDiscreteValue.Value = Format(toDate, "MM/dd/yyyy")
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("ToDate")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                ' IF REPORT BELONGS TO CP DUES STATEMENT
                If gblReportOption.ToUpper = "DUESSTAT" Then
                    crParameterDiscreteValue.Value = StrConv(RptUser.Trim, VbStrConv.Uppercase)
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
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

End Class