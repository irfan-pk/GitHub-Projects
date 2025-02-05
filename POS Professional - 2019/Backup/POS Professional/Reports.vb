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
        Try
            SqlDataSet.Clear()
            'Set Connection Information for PREVIEW the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase

            Dim CommandText As String = ""

            If gblReportOption.ToUpper = "RECEIPT" Then
                TableName = "SALE_MASTER"
                CommandText = "SELECT * FROM SALE_MASTER where saleId = N'" & gblFind.Trim & "'"
            End If

            If gblReportOption.ToUpper = "DETAIL" Then
                TableName = "CUSTOMERS"
                If RptUser.ToUpper = "ALL" Then CommandText = "SELECT * FROM CUSTOMERS  ORDER BY CUST_CODE"
                If RptUser.ToUpper <> "ALL" Then CommandText = "SELECT * FROM CUSTOMERS WHERE CUST_CODE = " & Val(RptUser.Trim) & "ORDER BY CUST_CODE"
            End If

            If gblReportOption.ToUpper = "LEDGER" Then
                TableName = "CUSTOMERS_PAYM"
                If RptUser.ToUpper = "ALL" Then CommandText = "SELECT * FROM CUSTOMERS_PAYM WHERE CUST_TR_DT >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY CUST_CODE, CUST_TR_DT"
                If RptUser.ToUpper <> "ALL" Then CommandText = "SELECT * FROM CUSTOMERS_PAYM WHERE CUST_CODE = " & Val(RptUser.Trim) & " AND CUST_TR_DT >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY CUST_CODE, CUST_TR_DT"
            End If

            If gblReportOption.ToUpper = "WDETAIL" Then
                TableName = "SUPPLIERS"
                If RptUser.ToUpper = "ALL" Then CommandText = "SELECT * FROM SUPPLIERS  ORDER BY SUPL_CODE"
                If RptUser.ToUpper <> "ALL" Then CommandText = "SELECT * FROM SUPPLIERS WHERE SUPL_CODE = " & Val(RptUser.Trim) & "ORDER BY SUPL_CODE"
            End If

            If gblReportOption.ToUpper = "WLEDGER" Then
                TableName = "SUPPLIERS_JOURNAL"
                If RptUser.ToUpper = "ALL" Then CommandText = "SELECT * FROM SUPPLIERS_JOURNAL WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY SUPL_CODE, SUPL_TR_DT"
                If RptUser.ToUpper <> "ALL" Then CommandText = "SELECT * FROM SUPPLIERS_JOURNAL WHERE SUPL_CODE = " & Val(RptUser.Trim) & " AND SUPL_TR_DT >= CONVERT(DATETIME,'" & Format(FromDate, "yyyy-MM-dd") & " 00:00:00',102) ORDER BY SUPL_CODE, SUPL_TR_DT"
            End If

            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, TableName, Connection)

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

            'Set report source
            CrystalReportViewer.ReportSource = objReport

            CrystalReportViewer.ShowCloseButton = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

End Class