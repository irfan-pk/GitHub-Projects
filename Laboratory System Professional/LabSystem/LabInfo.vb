Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class LabInfo
    Dim UpdtString As String

    Private Sub frmLabInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "SELECT * FROM LAB_INFO", "LAB_INFO", Connection)
        Dim LabInformation As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While LabInformation.Read
            txtLabName.Text = Convert.ToString(LabInformation.Item("LAB_NAME")).ToUpper.Trim
            txtAddress.Text = Convert.ToString(LabInformation.Item("LAB_ADDRESS")).ToUpper.Trim
            txtPathologist.Text = Convert.ToString(LabInformation.Item("LAB_PATHOLOGIST")).ToUpper.Trim
            txtTel1.Text = Convert.ToString(LabInformation.Item("LAB_TEL1")).ToUpper.Trim
            txtTel2.Text = Convert.ToString(LabInformation.Item("LAB_TEL2")).ToUpper.Trim
            txtMob1.Text = Convert.ToString(LabInformation.Item("LAB_MOB1")).ToUpper.Trim
            txtMob2.Text = Convert.ToString(LabInformation.Item("LAB_MOB2")).ToUpper.Trim
        End While
        If Not LabInformation Is Nothing Then LabInformation.Close()
        SqlDataAdapter.Dispose()
        SqlDataSet.Clear()
        Connection.Close()
        UpdtString = txtLabName.Text.Trim.ToUpper
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click



        Dim UpdateQuery As String = ""
        If CheckRecordExist("lab_info") = False Then
            UpdateQuery = "INSERT INTO LAB_INFO VALUES ('" & txtLabName.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtAddress.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtPathologist.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtTel1.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtTel2.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtMob1.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtMob2.Text.Trim.ToUpper & "')"
        Else
            UpdateQuery = "UPDATE LAB_INFO SET LAB_NAME = '" & txtLabName.Text.Trim.ToUpper & "'," & _
                                                           " LAB_ADDRESS = '" & txtAddress.Text.Trim.ToUpper & "'," & _
                                                           " LAB_PATHOLOGIST = '" & txtPathologist.Text.Trim.ToUpper & "'," & _
                                                           " LAB_TEL1 = '" & txtTel1.Text.Trim.ToUpper & "'," & _
                                                           " LAB_TEL2 = '" & txtTel2.Text.Trim.ToUpper & "'," & _
                                                           " LAB_MOB1 = '" & txtMob1.Text.Trim.ToUpper & "'," & _
                                                           " LAB_MOB2 = '" & txtMob2.Text.Trim.ToUpper & "'" & _
                                                           " WHERE LAB_NAME = '" & UpdtString & "'"
        End If
        Execute_DatabaseTable_Query(SqlDataAdapter, UpdateQuery, Connection)
        SqlDataAdapter.Dispose()
        Connection.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class