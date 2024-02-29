Imports System.Data.SqlClient

Public Class ReportRemarksList
    Dim AddMode, EditMode As Boolean
    Dim Pos As Integer
    Dim EditString, UpdtQuery, DelStr1, DelStr2 As String

    Private Sub ReportRemarksList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Dim ConnectTable As String = "select * from RPT_REMARKS order by TESTNAME"
        ExecuteSqlQuery(SqlDataAdapter, RmkDataSet, ConnectTable, "RPT_REMARKS", Connection)
        SqlDataAdapter.Fill(Me.RmkDataSet)
        Me.RmkBindingSource.DataSource = Me.RmkDataSet
        Me.RmkBindingSource.DataMember = "RPT_REMARKS"
        Me.RmkDataGrid.DataSource = RmkBindingSource
        Me.txtCode.DataBindings.Add("TEXT", Me.RmkBindingSource, "RMKCODE")
        Me.txtDescription.DataBindings.Add("TEXT", Me.RmkBindingSource, "DESCRIPTION")
        Me.cmbCategory.DataBindings.Add("TEXT", Me.RmkBindingSource, "CATEGORY")
        Me.txtTestName.DataBindings.Add("TEXT", Me.RmkBindingSource, "TESTNAME")
        Dim FillCombo As String = "select TCATG from tests group by TCATG"
        Execute_DatabaseTable_Query(SqlDataAdapter, FillCombo, Connection)
        Dim CategoryReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If CategoryReader.HasRows Then
            While CategoryReader.Read
                cmbCategory.Items.Add(CategoryReader.Item("tcatg").ToString)
            End While
        End If
        If CategoryReader Is Nothing Then CategoryReader.Close()
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        AddMode = True
        EditMode = False
        Me.RmkBindingSource.AddNew()
        Me.CloseToolStripMenuItem.Text = "&Cancel"
        Me.SaveToolStripMenuItem.Enabled = True
        Me.SplitContainer.Panel2.Enabled = True
        Me.txtCode.Focus()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Dim FindString As String
        FindString = Microsoft.VisualBasic.InputBox("Please enter remark code to find report remakrs.", "Find Remark")
        If Len(FindString) < 3 Then MsgBox("Please give valid string.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Pos = Me.RmkBindingSource.Find("RMKCODE", FindString.Trim)
        If Not Pos = -1 Then
            EditString = FindString
            Me.RmkBindingSource.Position = Pos
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If CloseToolStripMenuItem.Text = "&Close" Then
            Me.RmkBindingSource.Dispose()
            Me.RmkDataSet.Dispose()
            Me.RmkDataGrid.Dispose()
            Me.Close()
        Else
            Me.SplitContainer.Panel2.Enabled = False
            Me.CloseToolStripMenuItem.Text = "&Close"
            RefreshData()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If AddMode = True And EditMode = False Then
            UpdtQuery = "insert into rpt_remarks values('" & txtCode.Text.Trim & "','" & txtDescription.Text.Trim & "','" & cmbCategory.Text.Trim & "','" & txtTestName.Text.Trim & "')"
        End If
        If EditMode = True And AddMode = False Then
            UpdtQuery = "update rpt_remarks set rmkcode = '" & txtCode.Text.Trim.ToUpper & "'," & _
                                              " description = '" & txtDescription.Text.Trim.ToUpper & "'," & _
                                              " category = '" & cmbCategory.Text.Trim & "'," & _
                                              " testname = '" & txtTestName.Text.Trim & "'" & _
                                              " where rmkcode = '" & EditString.Trim & "'"
        End If
        Execute_DatabaseTable_Query(SqlDataAdapter, UpdtQuery, Connection)
        Me.SplitContainer.Panel2.Enabled = False
        Me.CloseToolStripMenuItem.Text = "&Close"
        Me.SaveToolStripMenuItem.Enabled = False
        Call RefreshData()
    End Sub

    Private Sub RefreshData()
        Try
            Me.RmkDataSet.Clear()
            SqlDataAdapter.Dispose()
            Me.RmkDataGrid.Refresh()
            Dim QueryText As String = "SELECT * FROM RPT_REMARKS ORDER BY TESTNAME"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "RPT_REMARKS", Connection)
            SqlDataAdapter.Fill(Me.RmkDataSet, "RPT_REMARKS")
            Me.RmkBindingSource.DataSource = Me.RmkDataSet
            Me.RmkBindingSource.DataMember = "RPT_REMARKS"
            Me.RmkDataGrid.DataSource = Me.RmkBindingSource
            Me.RmkDataGrid.RefreshEdit()
            Me.RmkDataGrid.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        AddMode = False
        EditMode = True
        Me.CloseToolStripMenuItem.Text = "&Cancel"
        Me.SplitContainer.Panel2.Enabled = True
        Me.SaveToolStripMenuItem.Enabled = True
        EditString = txtCode.Text.Trim
        Me.txtCode.Focus()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgBox("Are you sure to delete remarks ?" & Space(5) & "(" & Trim(DelStr1) & ") (" & DelStr2 & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM RPT_REMARKS WHERE RMKCODE = N'" & DelStr1.Trim & "' AND DESCRIPTION = N'" & DelStr2 & "'"
            Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
            Me.RmkDataGrid.Update()
            Me.RmkBindingSource.ResetBindings(True)
            Me.RmkDataGrid.Refresh()
            Call RefreshData()
        End If
    End Sub

    Private Sub RmkDataGrid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles RmkDataGrid.CellMouseClick
        DelStr1 = RmkDataGrid.Rows(RmkDataGrid.CurrentRow.Index).Cells(0).Value
        DelStr2 = RmkDataGrid.Rows(RmkDataGrid.CurrentRow.Index).Cells(1).Value
    End Sub
End Class