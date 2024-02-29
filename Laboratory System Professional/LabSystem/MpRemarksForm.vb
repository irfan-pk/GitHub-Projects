Imports System.Data.SqlClient

Public Class MpRemarksForm
    Dim AddMode, EditMode As Boolean
    Dim Pos As Integer
    Dim EditString, UpdtQuery As String

    Private Sub MpRemarksForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Dim ConnectTable As String = "select * from RPT_MP_REMARKS order by MP_CODE"
        ExecuteSqlQuery(SqlDataAdapter, RmkDataSet, ConnectTable, "RPT_MP_REMARKS", Connection)
        SqlDataAdapter.Fill(Me.RmkDataSet)
        Me.RmkBindingSource.DataSource = Me.RmkDataSet
        Me.RmkBindingSource.DataMember = "RPT_MP_REMARKS"
        Me.RmkDataGrid.DataSource = RmkBindingSource
        Me.txtCode.DataBindings.Add("TEXT", Me.RmkBindingSource, "MP_CODE")
        Me.txtDescription.DataBindings.Add("TEXT", Me.RmkBindingSource, "MP_RESULT")
        Me.cmbCategory.DataBindings.Add("TEXT", Me.RmkBindingSource, "MP_STATUS")
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
        Pos = Me.RmkBindingSource.Find("MP_CODE", FindString.Trim)
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
            UpdtQuery = "insert into rpt_mp_remarks values('" & txtCode.Text.Trim & "','" & txtDescription.Text.Trim & "','" & cmbCategory.Text.Trim & "')"
        End If
        If EditMode = True And AddMode = False Then
            UpdtQuery = "update rpt_mp_remarks set mp_code = '" & txtCode.Text.Trim.ToUpper & "'," & _
                                              " mp_result = '" & txtDescription.Text.Trim.ToUpper & "'," & _
                                              " mp_status = '" & cmbCategory.Text.Trim & "'" & _
                                              " where mp_code = '" & EditString.Trim & "'"
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
            Dim QueryText As String = "SELECT * FROM RPT_MP_REMARKS ORDER BY MP_CODE"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "RPT_MP_REMARKS", Connection)
            SqlDataAdapter.Fill(Me.RmkDataSet, "RPT_MP_REMARKS")
            Me.RmkBindingSource.DataSource = Me.RmkDataSet
            Me.RmkBindingSource.DataMember = "RPT_MP_REMARKS"
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
End Class