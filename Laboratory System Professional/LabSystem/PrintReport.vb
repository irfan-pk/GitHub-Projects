Imports System.Data.SqlClient
Imports System.IO

Public Class PrintReport
    Dim Row As String()
    Dim AddRow As Boolean = False
    Dim CurrentPath As String = Directory.GetCurrentDirectory()

    Private Sub txtPatientID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPatientID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.DataGridView.Rows.Count > 0 Then
                For i As Integer = Me.DataGridView.Rows.Count - 1 To 0 Step -1
                    Me.DataGridView.Rows.RemoveAt(i)
                Next
            End If
            Dim SelectReports As String = String.Empty
            SelectReports = "select distinct FILECODE,RPTCODE,PSTATUS,LABNO,NAME,RPT_DATE FROM Rpt_Result where (LABNO = " & Val(txtPatientID.Text.Trim) & " OR NAME LIKE '%" & txtPatientID.Text.Trim & "%') GROUP BY FILECODE,RPTCODE,LABNO,NAME,RPT_DATE,PSTATUS ORDER BY RPT_DATE DESC"
            Call AddRowsToDataGridView(SelectReports, "rpt_result")
            SelectReports = "select distinct FILECODE,RPTCODE,PSTATUS,LABNO,NAME,RPT_DATE FROM Rpt_biopsy where (LABNO = " & Val(txtPatientID.Text.Trim) & " OR NAME LIKE '%" & txtPatientID.Text.Trim & "%') GROUP BY FILECODE,RPTCODE,LABNO,NAME,RPT_DATE,PSTATUS ORDER BY RPT_DATE DESC"
            Call AddRowsToDataGridView(SelectReports, "rpt_biopsy")
            SelectReports = "select distinct FILECODE,RPTCODE,PSTATUS,LABNO,NAME,RPT_DATE FROM Rpt_culture where (LABNO = " & Val(txtPatientID.Text.Trim) & " OR NAME LIKE '%" & txtPatientID.Text.Trim & "%') GROUP BY FILECODE,RPTCODE,LABNO,NAME,RPT_DATE,PSTATUS ORDER BY RPT_DATE DESC"
            Call AddRowsToDataGridView(SelectReports, "rpt_culture")
            SelectReports = "select distinct FILECODE,RPTCODE,PSTATUS,LABNO,NAME,RPT_DATE FROM Rpt_nogrowth where (LABNO = " & Val(txtPatientID.Text.Trim) & " OR NAME LIKE '%" & txtPatientID.Text.Trim & "%') GROUP BY FILECODE,RPTCODE,LABNO,NAME,RPT_DATE,PSTATUS ORDER BY RPT_DATE DESC"
            Call AddRowsToDataGridView(SelectReports, "rpt_nogrowth")
        End If
    End Sub

    Private Sub txtPatientID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatientID.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PrintReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        'If gblSection = "ADMIN" Then cmdDelete.Enabled = True
    End Sub

    Private Sub AddRowsToDataGridView(ByVal Query As String, ByVal TableName As String)
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, Query, TableName, Connection)
        Dim ReportReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If ReportReader.HasRows Then
            While ReportReader.Read
                'Add row with data in the datagrid
                Row = New String() {ReportReader.Item("LABNO").ToString, ReportReader.Item("NAME").ToString, ReportReader.Item("RPT_DATE").ToString, ReportReader.Item("RPTCODE").ToString, ReportReader.Item("FILECODE").ToString, ReportReader.Item("PSTATUS").ToString, TableName}
                Me.DataGridView.Rows.Add(Row)
            End While
        End If
    End Sub

    Private Sub DataGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseClick
        Call GetParameters()
        cmdPrint.Enabled = True
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            'For Sent Report to Printer
            Call Print_Reports()
            If gblTableName.Trim = "rpt_result" Then _
                    Call Update_Print_Copies(gblTableName, gblPrintLabId, gblPrintReportCode)
            If gblTableName.Trim = "rpt_biopsy" Then _
                    Call Update_Print_Copies("rpt_biopsy", gblPrintLabId, gblPrintReportCode)
            If gblTableName.Trim = "rpt_culture" Then _
                    Call Update_Print_Copies("rpt_culture", gblPrintLabId, gblPrintReportCode)
            If gblTableName.Trim = "rpt_nogrowth" Then _
                    Call Update_Print_Copies("rpt_nogrowth", gblPrintLabId, gblPrintReportCode)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If gblPrintReportCode = String.Empty Then
            MsgBox("Please Select Report to Delete.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
        Try
            gblReportQuery = "delete from " & gblTableName.Trim & " where LABNO = " & Val(gblPrintLabId) & " AND RPTCODE = '" & gblPrintReportCode.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapter, gblReportQuery, Connection)
            Dim DeleteRemarks As String = "delete from rpt_result_remarks where LABID = " & Val(gblPrintLabId) & " AND RPTCODE = '" & gblPrintReportCode.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapter, DeleteRemarks, Connection)
            MsgBox("Report (" & gblPrintLabId & ") is delete successfully", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
            Call txtPatientID_KeyDown(Nothing, New KeyEventArgs(Keys.Enter))
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub GetParameters()
        gblPrintLabId = Me.DataGridView.Rows(DataGridView.CurrentRow.Index).Cells(0).Value.ToString
        gblPrintReportCode = Me.DataGridView.Rows(DataGridView.CurrentRow.Index).Cells(3).Value.ToString
        gblPrintFileName = CurrentPath & "\Pathology\" & Me.DataGridView.Rows(DataGridView.CurrentRow.Index).Cells(4).Value.ToString
        gblTableName = Me.DataGridView.Rows(DataGridView.CurrentRow.Index).Cells(6).Value.ToString
        Dim GetRemarks As String = "select * from lab_pro.dbo.rpt_result_remarks where labid=" & gblPrintLabId.Trim & " and rptcode='" & gblPrintReportCode.Trim & "'"
        Execute_DatabaseTable_Query(SqlDataAdapter, GetRemarks, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                gblRptRmkCode = Reader.Item("rmkcd").ToString.Trim
                gblRptRmkDetail = Reader.Item("rmks").ToString.Trim
            End While
        Else
            gblRptRmkCode = String.Empty
            gblRptRmkDetail = String.Empty
        End If
        If gblTableName.Trim = "rpt_result" Then
            gblReportQuery = "select * from " & gblTableName.Trim & " where LABNO = " & Val(gblPrintLabId) & " AND RPTCODE = '" & gblPrintReportCode.Trim & "' order by sort_order"
            gblSelectFormula = "{" & gblTableName.Trim & ".labno} = " & Val(gblPrintLabId)
        End If

        If gblTableName.Trim = "rpt_biopsy" Then
            gblReportQuery = "select * from " & gblTableName.Trim & " where LABNO = " & Val(gblPrintLabId) & " AND RPTCODE = '" & gblPrintReportCode.Trim & "'"
            gblSelectFormula = "{" & gblTableName.Trim & ".labno} = " & Val(gblPrintLabId)
        End If

        If gblTableName.Trim = "rpt_culture" Or gblTableName.Trim = "rpt_nogrowth" Then
            gblReportQuery = "select * from patient where p_num = " & Val(gblPrintLabId)
            gblSelectFormula = "{patient.p_num} = " & Val(gblPrintLabId)
        End If
    End Sub

    Private Sub DataGridView_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseDoubleClick
        Try
            Call GetParameters()
            If gblTableName.Trim = "rpt_result" Then ReportPreviewForm.Show()
            If gblTableName.Trim = "rpt_biopsy" Then HistopathologyReport.Show()
            If gblTableName.Trim = "rpt_culture" Or gblTableName.Trim = "rpt_nogrowth" Then CultureReportViewer.Show()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class