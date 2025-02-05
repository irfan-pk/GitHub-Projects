Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class StockReportViewer

    Private Sub StockReportViewer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReportViewer.ReportSource = Nothing
    End Sub

    Private Sub StockReportViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, gblQueryText, "PRODUCTS", Connection)

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
            objReport.SetDataSource(SqlDataSet.Tables("PRODUCTS"))

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