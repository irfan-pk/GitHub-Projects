Imports System.Data.SqlClient

Public Class NameCorrection
    Dim strCpName As String

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Try
            '// Find and delivered Report Status / dues Received by operator
            Dim RecStatus As String
            gblFind = Microsoft.VisualBasic.InputBox("Please Enter Patient Lab ID # to find.", "Find Record")
            If Len(gblFind) = 0 Then Exit Sub

            Dim strSql As String = "Select * from PATIENT WHERE P_NUM = " & Val(gblFind.Trim)
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, strSql, "PATIENT", Connection)

            Dim objDataTable As New Data.DataTable("PATIENT")
            Dim objDataRow As DataRow

            SqlDataAdapter.Fill(objDataTable)
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
                    txtCNIC.Text = objDataRow.Item("P_CNIC").ToString.Trim
                    txtMannual.Text = objDataRow.Item("P_SLIP_NUM").ToString.Trim
                    txtContact.Text = objDataRow.Item("P_PHONE").ToString.Trim
                    txtPannel.Text = objDataRow.Item("P_PANNEL").ToString.Trim
                    txtHospital.Text = objDataRow.Item("P_REFER_2").ToString.Trim
                    cmbCollPoint.Text = objDataRow.Item("P_CP").ToString.Trim
                    cmbSex.Text = objDataRow.Item("P_SEX").ToString.Trim
                    cmbDoctors.Text = objDataRow.Item("P_REF_BY").ToString.Trim
                    cmbVisitor.Text = objDataRow.Item("P_VISITOR").ToString.Trim
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
                    " P_SLIP_NUM = " & txtMannual.Text.Trim & "," & _
                    " P_PANNEL = '" & txtPannel.Text.Trim & "'," & _
                    " P_CNIC = '" & txtCNIC.Text.Trim & "'," & _
                    " P_CP = '" & StrConv(cmbCollPoint.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_REF_BY = '" & StrConv(cmbDoctors.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_REFER_2 = '" & StrConv(txtHospital.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_SPC_REFER = '" & StrConv(txtHospital.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_VISITOR = '" & StrConv(cmbVisitor.Text.Trim, VbStrConv.Uppercase) & "'" & _
                    " WHERE P_NUM = " & Val(gblFind)

            Execute_DatabaseTable_Query(SqlDataAdapter, mySql, Connection)
            cmdUpdt.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        SqlDataAdapter.Dispose()
        Connection.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub frmNameCorrection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        Dim cpReader As SqlDataReader
        ExecuteSqlQuery(SqlDataAdapter, myDataSet, "Select CP_ID, CP_NAME from CollectionPoint order by CP_ID", "CollectionPoint", Connection)
        cpReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If cpReader.HasRows Then
            While cpReader.Read
                If Mid(cpReader.Item("CP_NAME"), 1, 2) <> "CP" Then _
                Me.cmbDoctors.Items.Add(cpReader.Item("CP_NAME"))
            End While
        End If
        If Not cpReader Is Nothing Then cpReader.Close()
        Dim cpReader2 As SqlDataReader
        ExecuteSqlQuery(SqlDataAdapter, myDataSet, "Select CP_ID, CP_NAME from CollectionPoint WHERE CP_NAME LIKE '%CP%' order by CP_ID", "CollectionPoint", Connection)
        cpReader2 = SqlDataAdapter.SelectCommand.ExecuteReader
        If cpReader2.HasRows Then
            While cpReader2.Read
                Me.cmbCollPoint.Items.Add(cpReader2.Item("CP_NAME"))
            End While
        End If
        If Not cpReader2 Is Nothing Then cpReader2.Close()
        ExecuteSqlQuery(SqlDataAdapter, myDataSet, "Select visitor_name from visitor_table order by visitor_name", "visitor_table", Connection)
        cpReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If cpReader.HasRows Then
            While cpReader.Read
                Me.cmbVisitor.Items.Add(cpReader.Item("VISITOR_NAME"))
            End While
        End If
        If Not cpReader Is Nothing Then cpReader.Close()

        'Catch EX As Exception
        '    MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        '    Me.Close()
        'End Try
        Connection.Close()
        Me.Focus()
    End Sub

End Class