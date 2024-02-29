Imports System.Data.SqlClient
Imports System.IO

Public Class TestStatistics
    Dim Row As String()
    Dim currentpath As String = Directory.GetCurrentDirectory()

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        fromDate = dtpFrom.Value.ToShortDateString
        toDate = dtpTo.Value.ToShortDateString
        Dim TestCount As String = "select count(tname) as Count_Expression, tname from receipt where tdate >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) and tdate <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) group by tname"
        Execute_DatabaseTable_Query(SqlDataAdapter, TestCount, Connection)
        Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                'Add row with data in the datagrid
                Row = New String() {reader.Item("tname"), reader.Item("Count_Expression")}
                DataGridView.Rows.Add(Row)
            End While
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        fromDate = DateTime.Parse(dtpFrom.Value.ToShortDateString)
        toDate = DateTime.Parse(dtpTo.Value.ToShortDateString)
        gblReportOption = "TESTSTAT"
        gblReportName = currentpath & "\" & "Reports\TestCount.rpt"
        BillReport.ShowDialog()
    End Sub
End Class