Imports System.Data.SqlClient
Public Class frmPrintRateList
    Dim path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        SqlDataSet.Clear()
        Me.Cursor = Cursors.AppStarting
        Try
            Call GetConnectionString()
            'Set Connection Information for run the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "LAB"

            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "SELECT * FROM TESTS ORDER BY TNAME", "TESTS", Connection)
            'Set report source
            CrystalReportViewer1.ReportSource = objReport
            ' Load Report in memory for View
            Try
                objReport.Load(path & "\Reports\Rate List.rpt")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try
            'Set logon information to reports for view
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next
            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables("TESTS"))
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub frmPrintRateList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SqlDataSet.Clear()
        Connection.Close()
        CrystalReportViewer1.ReportSource = Nothing
    End Sub
End Class