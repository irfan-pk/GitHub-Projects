Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class ShopInfo
    Dim UpdtString As String

    Private Sub frmLabInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, "SELECT * FROM INFO", "INFO", Connection)
        Dim LabInformation As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While LabInformation.Read
            txtLabName.Text = Convert.ToString(LabInformation.Item("REG_NAME")).ToUpper.Trim
            txtAddress.Text = Convert.ToString(LabInformation.Item("REG_ADDRESS")).ToUpper.Trim
            txtTel1.Text = Convert.ToString(LabInformation.Item("TEL1")).ToUpper.Trim
            txtTel2.Text = Convert.ToString(LabInformation.Item("TEL2")).ToUpper.Trim
            txtMob1.Text = Convert.ToString(LabInformation.Item("MOBILE1")).ToUpper.Trim
            txtMob2.Text = Convert.ToString(LabInformation.Item("MOBILE2")).ToUpper.Trim
        End While
        If Not LabInformation Is Nothing Then LabInformation.Close()
        SqlDataAdapter.Dispose()
        SqlDataSet.Clear()
        Connection.Close()
        UpdtString = txtLabName.Text.Trim.ToUpper
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click



        Dim UpdateQuery As String = ""
        If CheckRecordExist("info") = False Then
            UpdateQuery = "INSERT INTO INFO VALUES ('" & txtLabName.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtAddress.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtTel1.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtTel2.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtMob1.Text.Trim.ToUpper & "'," & _
                                                           " '" & txtMob2.Text.Trim.ToUpper & "')"
        Else
            UpdateQuery = "UPDATE INFO SET REG_NAME = '" & txtLabName.Text.Trim.ToUpper & "'," & _
                                                           " REG_ADDRESS = '" & txtAddress.Text.Trim.ToUpper & "'," & _
                                                           " TEL1 = '" & txtTel1.Text.Trim.ToUpper & "'," & _
                                                           " TEL2 = '" & txtTel2.Text.Trim.ToUpper & "'," & _
                                                           " MOBILE1 = '" & txtMob1.Text.Trim.ToUpper & "'," & _
                                                           " MOBILE2 = '" & txtMob2.Text.Trim.ToUpper & "'" & _
                                                           " WHERE REG_NAME = '" & UpdtString & "'"
        End If
        ExecuteAdapterQuery(SqlDataAdapter, UpdateQuery, Connection)
        SqlDataAdapter.Dispose()
        Connection.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class