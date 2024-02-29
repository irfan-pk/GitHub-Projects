Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DonorProfile
    Dim EditString, EditString2 As String
    Dim objCellStyle As New DataGridViewCellStyle()

    Private Sub frmDonorProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub BindingNavigatorQuery(ByVal Query As String)
        Try
            Execute_DatabaseTable_Query(SqlDataAdapter, Query, Connection)
            Connection.Close()
            SqlDataAdapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub LoadDB()

        Try
            Me.DonorDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM DONOR_TABLE WHERE (DONOR_DATE >= CONVERT(DATETIME,'" & Format(FromDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (DONOR_DATE <= CONVERT(DATETIME,'" & Format(ToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) ORDER BY DONOR_ID, DONOR_PID"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "DONOR_TABLE", Connection)
            SqlDataAdapter.Fill(Me.DonorDataSet, "DONOR_TABLE")
            Me.DonorBindingSource.DataSource = Me.DonorDataSet
            Me.DonorBindingSource.DataMember = "DONOR_TABLE"
            Me.txtWeight.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_WT")
            Me.cmbPGroup.DataBindings.Add("TEXT", DonorBindingSource, "PATIENT_GRP")
            Me.cmbDGroup.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_GROUP")
            Me.cmbHBS.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_HBS")
            Me.cmbHCV.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_HCV")
            Me.cmbHIV.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_HIV")
            Me.cmbVDRL.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_VDRL")
            ToolStripSaveButton.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            DonorDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If ToolStripCloseButton.Text = "&Close" Then
            Connection.Close()
            Me.DonorBindingSource.Dispose()
            Me.Close()
        Else
            ToolStripCloseButton.Text = "&Close"
            ToolStripSaveButton.Enabled = False
            ToolStripEditButton.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
            Call RefreshDB()
        End If
    End Sub

    Private Sub ToolStripSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSaveButton.Click

        EditString = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value.ToString.Trim
        EditString2 = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(3).Value.ToString.Trim

        '// If changes made in selected record then execute update record query
        Call BindingNavigatorQuery("UPDATE DONOR_TABLE SET" & _
                                   " DONOR_WT = '" & StrConv(txtWeight.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                   " PATIENT_GRP = '" & StrConv(cmbPGroup.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                   " DONOR_GROUP = '" & StrConv(cmbDGroup.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                   " DONOR_HBS = '" & StrConv(cmbHBS.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                   " DONOR_HCV = '" & StrConv(cmbHCV.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                   " DONOR_HIV = '" & StrConv(cmbHIV.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                   " DONOR_VDRL = '" & StrConv(cmbVDRL.Text.Trim, VbStrConv.Uppercase) & "'" & _
                                   " WHERE (DONOR_ID = " & Val(EditString) & ") AND (DONOR_NAME LIKE '%" & EditString2 & "%')")

        Call RefreshDB()
        ToolStripSaveButton.Enabled = False
        ToolStripEditButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Close"

    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click

        ToolStripSaveButton.Enabled = True
        ToolStripCloseButton.Text = "&Cancel"
        EditString = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value.ToString.Trim
        EditString2 = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(3).Value.ToString.Trim
        txtWeight.Focus()

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        EditString = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value.ToString.Trim
        EditString2 = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(3).Value.ToString.Trim

        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(EditString) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM DONOR_TABLE WHERE (DONOR_ID = " & Val(EditString) & ") AND (DONOR_NAME = '" & EditString2.Trim & "')"
            Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
            Me.DonorDataGrid.Update()
        Else
            'skip
            Call RefreshDB()
        End If

    End Sub

    Private Sub RefreshDB()

        Try
            Me.DonorDataSet.Clear()
            SqlDataAdapter.Dispose()
            Dim QueryText As String = "SELECT * FROM DONOR_TABLE WHERE (DONOR_DATE >= CONVERT(DATETIME,'" & Format(FromDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (DONOR_DATE <= CONVERT(DATETIME,'" & Format(ToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) ORDER BY DONOR_ID, DONOR_PID"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "DONOR_TABLE", Connection)
            SqlDataAdapter.Fill(Me.DonorDataSet, "DONOR_TABLE")
            Me.DonorBindingSource.DataSource = Me.DonorDataSet
            Me.DonorBindingSource.DataMember = "DONOR_TABLE"
            Me.DonorDataGrid.Update()
            Me.DonorDataGrid.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Call RefreshDB()
    End Sub

End Class