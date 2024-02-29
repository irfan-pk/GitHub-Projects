Imports System.Data.SqlClient
Public Class frmNameCorrection
    Dim strCpName As String
    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Try
            '// Find and delivered Report Status / dues Received by operator
            Dim RecStatus As String
            gblFind = Microsoft.VisualBasic.InputBox("Please Enter Patient Lab ID # to find.", "Find Record")
            If Len(gblFind) = 0 Then Exit Sub

            Dim strSql As String = "Select * from PATIENT WHERE P_NUM = " & Val(gblFind.Trim)
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "PATIENT", Connection)

            Dim objDataTable As New Data.DataTable("PATIENT")
            Dim objDataRow As DataRow

            SqlDataAdapt.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                For Each objDataRow In objDataTable.Rows
                    RecStatus = objDataRow.Item("P_DEL_OK").ToString
                    '// IF STATUS IS DELIVERED
                    If RecStatus.Trim = "YES" Or RecStatus.Trim = "Yes" Then
                        MsgBox("Report Delivered on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)
                        '// IF STATUS IS CANCELLED
                    ElseIf RecStatus.Trim = "CANCELLED" Or RecStatus.Trim = "Cancelled" Or RecStatus.Trim = "COMPLIMENTARY" Or RecStatus.Trim = "Complimentary" Then
                        MsgBox("Report " & RecStatus.Trim & " on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)

                    End If
                    '// IF STATUS IS NORMAL
                    txtName.Text = objDataRow.Item("P_NAME").ToString.Trim
                    txtYrs.Text = Mid(objDataRow.Item("P_AGE"), 1, 2).Trim
                    txtMth.Text = Mid(objDataRow.Item("P_AGE"), 8, 2).Trim
                    txtDay.Text = Mid(objDataRow.Item("P_AGE"), 15, 2).Trim
                    txtContact.Text = objDataRow.Item("P_PHONE").ToString.Trim
                    cmbCollection.Text = objDataRow.Item("P_CP").ToString.Trim
                    cmbSex.Text = objDataRow.Item("P_SEX").ToString.Trim
                    txtRefer.Text = objDataRow.Item("P_REF_BY").ToString.Trim
                    txtVisitor.Text = objDataRow.Item("P_VISITOR").ToString.Trim
                Next
                cmdUpdt.Enabled = True
                Connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdUpdt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdt.Click

        Dim myAge = "", mySql As String = ""

        myAge = txtYrs.Text.Trim & Space(1) & "Yrs" & Space(1) & txtMth.Text.Trim & Space(1) & "Mth" & Space(1) & txtDay.Text & Space(1) & "Day"

        Try
            mySql = "UPDATE PATIENT SET P_NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_AGE = '" & myAge & "'," & _
                    " P_SEX = '" & cmbSex.Text.Trim & "'," & _
                    " P_PHONE = '" & txtContact.Text.Trim & "'," & _
                    " P_CP = '" & StrConv(cmbCollection.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_REF_BY = '" & StrConv(txtRefer.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_VISITOR = '" & StrConv(txtVisitor.Text.Trim, VbStrConv.Uppercase) & "'" & _
                    " WHERE P_NUM = " & Val(gblFind)

            Execute_DatabaseTable_Query(SqlDataAdapt, mySql, Connection)
            cmdUpdt.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        SqlDataAdapt.Dispose()
        Connection.Close()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub frmNameCorrection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cpReader As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select cp_ID from CollectionPoint order by cp_ID", "CollectionPoint", Connection)
            cpReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While cpReader.Read
                Me.cmbCollection.Items.Add(cpReader.Item("CP_ID"))
            End While
            If Not cpReader Is Nothing Then cpReader.Close()

        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
        Me.Focus()
    End Sub

    Private Sub cmbCollection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCollection.SelectedIndexChanged
        Call Get_CpRefer()
        If strCpName = "" Then MsgBox("Please Select Valid Reference.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        txtRefer.Text = StrConv(strCpName.Trim, VbStrConv.ProperCase)
    End Sub

    Private Sub Get_CpRefer()

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "Select * from CollectionPoint where CP_ID = '" & Trim(cmbCollection.Text.ToUpper) & "'", "CollectionPoint", Connection)
        If SqlDataSet.Tables("CollectionPoint").Rows.Count > 0 Then
            Dim DiscReader As SqlDataReader
            DiscReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While DiscReader.Read
                strCpName = Convert.ToString(DiscReader.Item("CP_NAME"))
            End While
            If Not DiscReader Is Nothing Then DiscReader.Close()
        End If

    End Sub

End Class