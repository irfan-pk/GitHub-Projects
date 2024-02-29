Imports System.Data.SqlClient

Public Class ReportFile

    Private Sub ReportFile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            gblReportName = String.Empty
            Me.Close()
        End If
    End Sub

    Private Sub ReportFile_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        gblReportName = String.Empty
        cmbRptCode.Items.Clear()
        Dim Filler As String = "select distinct rptcode from lab_pro.dbo.rpt_param order by rptcode"
        Execute_DatabaseTable_Query(SqlDataAdapter, Filler, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                cmbRptCode.Items.Add(Reader.Item("rptcode").ToString.Trim)
            End While
        End If
    End Sub

    Private Sub cmbRptCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRptCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            gblReportName = cmbRptCode.Text.Trim
            Me.Close()
        End If
        If e.KeyCode = Keys.Escape Then
            gblReportName = String.Empty
            Me.Close()
        End If
    End Sub
End Class