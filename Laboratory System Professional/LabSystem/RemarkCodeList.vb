Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class RemarkCodeList

    Dim Pos As Integer

    Private Sub RemarkCodeList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            gblRptRmkCode = String.Empty
            gblRptRmkDetail = String.Empty
            Me.Close()
        End If
    End Sub

    Private Sub RemarkCodeList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        gblRptRmkCode = String.Empty
        gblRptRmkDetail = String.Empty
        Dim LoadRemarks As String = "select * from rpt_remarks where category = '" & gblRmkCategory.Trim & "' order by rmkcode"
        ExecuteSqlQuery(SqlDataAdapter, Me.RmkDataSet, LoadRemarks, "RPT_REMARKS", Connection)
        SqlDataAdapter.Fill(Me.RmkDataSet)
        Me.RmkBindingSource.DataSource = Me.RmkDataSet
        Me.RmkBindingSource.DataMember = "RPT_REMARKS"
    End Sub

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        Dim FindString As String
        FindString = Microsoft.VisualBasic.InputBox("Please enter code to find report remakrs.", "Find Remark")
        If Len(FindString) < 2 Then MsgBox("Please give valid string.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Pos = Me.RmkBindingSource.Find("RMKCODE", FindString.Trim)
        If Not Pos = -1 Then
            Me.RmkBindingSource.Position = Pos
        End If
    End Sub

    Private Sub RmkDataGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles RmkDataGrid.CellMouseDoubleClick
        If RmkDataGrid.Rows(RmkDataGrid.CurrentRow.Index).Cells(0).Value Is Nothing Then
            gblRptRmkCode = String.Empty
            gblRptRmkDetail = String.Empty
            Exit Sub
            Me.Close()
        End If
        gblRptRmkCode = RmkDataGrid.Rows(e.RowIndex).Cells(1).Value.ToString
        gblRptRmkDetail = RmkDataGrid.Rows(e.RowIndex).Cells(2).Value.ToString
        Me.Close()
    End Sub

    Private Sub RmkDataGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RmkDataGrid.KeyDown
        If e.KeyCode = Keys.Enter Then
            If RmkDataGrid.Rows(RmkDataGrid.CurrentRow.Index).Cells(0).Value Is Nothing Then
                gblRptRmkCode = String.Empty
                gblRptRmkDetail = String.Empty
                Exit Sub
                Me.Close()
            End If
            gblRptRmkCode = RmkDataGrid.Rows(Me.RmkDataGrid.CurrentRow.Index).Cells(0).Value.ToString
            gblRptRmkDetail = RmkDataGrid.Rows(Me.RmkDataGrid.CurrentRow.Index).Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
End Class
