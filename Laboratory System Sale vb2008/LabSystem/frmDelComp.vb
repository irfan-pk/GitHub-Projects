Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmDelComp
    Dim Rmk As String
    Private Sub frmPatient_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        ' If user pressed the Enter key
        If e.KeyCode = Keys.Enter And Not (e.Alt Or e.Control) Then
            e.SuppressKeyPress = True
            ' Make sure that the active control is a TextBox control
            ' Do not use the Enter key as tab when a button has the focus!
            If Me.ActiveControl.GetType Is GetType(TextBox) Or _
                    Me.ActiveControl.GetType Is GetType(Button) Then
                ' Use Shift + Enter to move backwords through the tab order
                If e.Shift Then
                    Me.ProcessTabKey(False)
                Else
                    Me.ProcessTabKey(True)
                End If
            End If
        End If
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If cmdClose.Text = "&Close" Then Me.Close()
    End Sub

    Private Sub ShowGridData(ByVal SQLStatment As String, ByVal tblName As String, ByVal strSearch As String)

        Dim QueryString As String = ""
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        If Len(strSearch) > 0 Then
            QueryString = SQLStatment & " WHERE TCASENO = " & Val(strSearch.Trim)
        Else
            QueryString = SQLStatment
        End If
        ExecuteSqlQuery(SqlDataAdapt, GridDataSet, QueryString, "TESTS", Connection)
        SqlDataAdapt.Fill(GridDataSet, tblName.Trim)
        Connection.Close()
        TstDataGrid.DataSource = GridDataSet
        TstDataGrid.DataMember = tblName.Trim
        objAlternatingCellStyle.BackColor = Color.Aqua
        Me.TstDataGrid.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle

    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Try
            'Find and delivered Report Status / dues Received by operator
            Dim RecStatus As String
            TstDataGrid.DataSource = Nothing
            gblFind = Microsoft.VisualBasic.InputBox("Please Enter Patient Lab ID # to find.", "Find Record")
            If Len(gblFind) = 0 Then Exit Sub

            Dim strSql As String = "Select * from PATIENT WHERE P_NUM = " & Val(gblFind.Trim)
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "PATIENT", Connection)
            Dim objDataTable As New Data.DataTable("PATIENT")
            Dim objDataRow As DataRow
            SqlDataAdapt.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                For Each objDataRow In objDataTable.Rows
                    RecStatus = objDataRow.Item("P_DEL_OK")
                    ' IF STATUS IS DELIVERED
                    If RecStatus.Trim = "YES" Or RecStatus.Trim = "Yes" Then
                        MsgBox("Report Delivered on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)
                        ' IF STATUS IS CANCELLED
                    ElseIf RecStatus.Trim = "CANCELLED" Or RecStatus.Trim = "Cancelled" Or RecStatus.Trim = "COMPLIMENTARY" Or RecStatus.Trim = "Complimentary" Then
                        MsgBox("Report " & RecStatus.Trim & " on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)

                    Else
                        'IF STATUS IS NORMAL
                        txtRecNo.Text = objDataRow.Item("P_NUM")
                        txtName.Text = objDataRow.Item("P_NAME")
                        txtAge.Text = objDataRow.Item("P_AGE")
                        txtContact.Text = objDataRow.Item("P_PHONE")
                        txtSlip.Text = objDataRow.Item("P_SLIP_NUM")
                        txtSex.Text = objDataRow.Item("P_SEX")
                        txtRefer.Text = objDataRow.Item("P_REF_BY")
                        txtCp.Text = objDataRow.Item("P_CP")
                        txtTotal.Text = objDataRow.Item("P_TOTAL")
                        txtPaid.Text = objDataRow.Item("P_PAID")
                        txtDisc.Text = objDataRow.Item("P_DISCOUNT")
                        txtDues.Text = objDataRow.Item("P_DUES")
                        txtDate.Text = objDataRow.Item("P_DATE_SAMPLE")
                        txtTime.Text = objDataRow.Item("P_TIME_SAMPLE")
                        txtDelDate.Text = objDataRow.Item("P_RPT_DATE")
                        txtDelTime.Text = objDataRow.Item("P_RPT_TIME")
                        txtOper.Text = objDataRow.Item("P_OPERATOR")
                        Call ShowGridData("SELECT * FROM RECEIPT", "RECEIPT", txtRecNo.Text.Trim)
                    End If
                Next
                Connection.Close()
                txtStatus.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        Dim SqlString = "", Reason As String = ""
        If txtStatus.Text.ToUpper = "CANCELLED" Or txtStatus.Text.ToUpper = "COMPLIMENTARY" Then MsgBox("Patient Record already " & txtStatus.Text.Trim, MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Reason = InputBox("Please write remarks for modification.", "Remarks")
        If Len(Reason) = 0 Then Exit Sub
        Rmk = "Cancelled"
        Dim strDate As Date = CDate(txtDate.Text)
        Dim strDiff As String = DateDiff(DateInterval.Day, Date.Today, strDate)
        If Val(strDiff) <> 0 And Val(txtTotal.Text) > 0 Then
            SqlString = "UPDATE PATIENT SET p_delete = " & Val(txtTotal.Text) & ", p_del_paid = " & Val(txtPaid.Text) & ", p_del_dues = " & Val(txtDues.Text) & ", p_del_disc = " & Val(txtDisc.Text) & "," & _
                                            " p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Cancelled', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_delete_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason ='" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        If Val(strDiff) = 0 And Val(txtTotal.Text) > 0 Or Val(strDiff) = 0 Then
            SqlString = "UPDATE PATIENT SET p_delete = 0, p_total = 0, p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Cancelled', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_delete_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason = '" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        Execute_DatabaseTable_Query(SqlDataAdapt, SqlString, Connection)
        txtStatus.Text = Rmk.Trim.ToUpper
        '// Delete Selected Record
        Dim CommandText As String = "DELETE FROM RECEIPT WHERE TCASENO = " & Val(txtRecNo.Text)
        SqlDataAdapt.Dispose()
        SqlDataSet.Clear()
        Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
        Connection.Close()

    End Sub

    Private Sub cmdComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComp.Click

        Dim SqlString = "", Reason As String = ""
        If txtStatus.Text.ToUpper = "COMPLIMENTARY" Or txtStatus.Text.ToUpper = "CANCELLED" Then MsgBox("Patient Record already " & txtStatus.Text.Trim, MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Reason = InputBox("Please write remarks for modification.", "Remarks")
        If Len(Reason) = 0 Then Exit Sub
        Rmk = "Complimentary"
        Dim strDate As Date = CDate(txtDate.Text)
        Dim strDiff As String = DateDiff(DateInterval.Day, Date.Today, strDate)
        'If Format(Now(), "M/d/yyyy") <> Format(txtDate.Text, "M/d/yyyy") And Val(txtDues.Text) > 0 Then
        If Val(strDiff) <> 0 And Val(txtTotal.Text) > 0 Then
            SqlString = "UPDATE PATIENT SET p_compliment = " & Val(txtTotal.Text) & ", p_com_paid = " & Val(txtPaid.Text) & ", p_com_dues = " & Val(txtDues.Text) & ", p_com_disc = " & Val(txtDisc.Text) & "," & _
                                            " p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Complimentary', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_comp_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_comp_by = '" & SysOperator.Trim & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason ='" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        If Val(strDiff) = 0 And Val(txtTotal.Text) > 0 Or Val(strDiff) = 0 Then
            SqlString = "UPDATE PATIENT SET p_compliment = " & Val(txtTotal.Text) & ", p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Complimentary', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_comp_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_comp_by = '" & SysOperator.Trim & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason = '" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        Execute_DatabaseTable_Query(SqlDataAdapt, SqlString, Connection)
        txtStatus.Text = Rmk.Trim.ToUpper
        Connection.Close()
    End Sub

    Private Sub frmDelComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
    End Sub
End Class