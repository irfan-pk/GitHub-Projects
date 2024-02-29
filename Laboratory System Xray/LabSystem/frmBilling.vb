Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBilling
    Dim Filler As SqlDataReader
    Dim strCollSql As String = "SELECT * from COLLECTIONPOINT ORDER BY CP_NAME"
    Dim strUserSql As String = "SELECT * from USERS ORDER BY USERNAME"

    Private Sub frmBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strUserSql, "USERNAME", Connection)
        SqlDataAdapt.Fill(SqlDataSet, "USERS")
        Filler = SqlDataAdapt.SelectCommand.ExecuteReader()
        While Filler.Read
            Me.cmbOper.Items.Add(Filler.Item("USERNAME").ToString.Trim)
        End While
        If Not Filler Is Nothing Then Filler.Close()
        Connection.Close()
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strCollSql, "COLLECTIONPOINT", Connection)
        SqlDataAdapt.Fill(SqlDataSet, "COLLECTIONPOINT")
        Filler = SqlDataAdapt.SelectCommand.ExecuteReader()
        While Filler.Read
            Me.cmbCP.Items.Add(Filler.Item("CP_NAME").ToString.Trim)
        End While
        If Not Filler Is Nothing Then Filler.Close()
        cmdBill.Enabled = False
        cmdPaid.Enabled = False
        Connection.Close()
        cmbCP.Focus()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If cmdClose.Text = "&Close" Then Me.Close() : Exit Sub
        Dim CommandText As String = "UPDATE PATIENT SET P_DEL_OK = 'x' WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "MM/dd/yyyy") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "MM/dd/yyyy") & " 00:00:00',102) AND (P_CP = '" & StrConv(cmbCP.Text.Trim, VbStrConv.Uppercase) & "') AND (P_DUES > 0) AND (P_DEL_OK = 'BILLED')"
        Try
            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
            lblAmount.Text = "00"
            lblRecords.Text = "00"
            lblStatus.Text = "NIL"
            cmdPaid.Enabled = False
            cmdBill.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message + MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        cmdClose.Text = "&Close"
    End Sub

    Private Sub cmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculate.Click

        If cmbCP.Text.Trim = "" Or Len(cmbCP.Text.Trim) = 0 Then MsgBox("Please Select Collection Point.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        fromDate = fromDatePick.Value
        toDate = toDatePick.Value
        Dim Total_Records, Total_Dues As Double
        Total_Dues = 0
        Total_Records = 0
        If lblStatus.Text.Trim <> "SELECTED" Then
            Dim CommandText As String = "Select COUNT(P_NUM) AS TOT_CONS, SUM(P_DUES) AS TOT_DUES from PATIENT WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "MM/dd/yyyy") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "MM/dd/yyyy") & " 00:00:00',102) AND (P_CP = '" & StrConv(cmbCP.Text.Trim, VbStrConv.Uppercase) & "') AND (P_DUES > 0) AND (P_DEL_OK = 'No' OR P_DEL_OK = 'x')"
            Try
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT", Connection)
                Filler = SqlDataAdapt.SelectCommand.ExecuteReader
                While Filler.Read
                    Total_Dues += Val(Filler.Item("TOT_DUES"))
                    Total_Records += Val(Filler.Item("TOT_CONS"))
                End While
                If Not Filler Is Nothing Then Filler.Close()
                lblRecords.Text = Total_Records.ToString
                lblAmount.Text = Total_Dues.ToString
                lblStatus.Text = "SELECTED"
                cmdBill.Enabled = True
                cmdClose.Text = "&Cancel"
            Catch ex As Exception
                MsgBox("There is no Record for Billing. Check Status / Date Range.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        Else
            MsgBox("Records already selected for billing.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub cmdBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBill.Click
        If lblStatus.Text = "SELECTED" Then
            If MsgBox("Are You ready for Billing of selected records ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, My.Application.Info.ProductName) = MsgBoxResult.Yes Then
                Dim CommandText As String = "UPDATE PATIENT SET P_DEL_OK = 'BILLED' WHERE p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102) AND (P_CP = '" & StrConv(cmbCP.Text.Trim, VbStrConv.ProperCase) & "') AND (P_DUES > 0) AND (P_DEL_OK = 'No' or P_DEL_OK = 'x')"
                Try
                    Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                    lblStatus.Text = "BILLED"
                    cmdBill.Enabled = False
                    cmdPaid.Enabled = True
                Catch ex As Exception
                    MsgBox(ex.Message + MsgBoxStyle.Information, My.Application.Info.ProductName)
                End Try
            End If
        Else
            MsgBox("please select records before billing.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub cmdPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaid.Click
        If cmbCP.Text.Trim = "" Or cmbOper.Text.Trim = "" Then MsgBox("Please Select Operator Name.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Dim LABID As String = 0
        fromDate = fromDatePick.Value
        toDate = toDatePick.Value
        If lblStatus.Text.Trim = "BILLED" Then
            Dim CommandText As String = "UPDATE PATIENT SET P_DEL_OK = 'Yes',p_paid = p_dues, p_due_rcv = p_dues, p_dues = 0, p_due_rcv_operator = '" & cmbOper.Text.ToUpper.Trim & "'," & _
                                        " p_due_rcv_date = '" & Format(Now, "MM/dd/yyyy") & "', p_del_date = '" & Format(Now, "MM/dd/yyyy") & "', p_del_time = '" & Format(DateTime.Parse(TimeOfDay.ToShortTimeString), "hh:mm tt") & "', p_del_operator = '" & cmbOper.Text.ToUpper.Trim & "'" & _
                                        " WHERE (p_date_sample >= CONVERT(DATETIME,'" & Format(fromDate, "yyyy-MM-dd") & _
                                        " 00:00:00',102) AND p_date_sample <= CONVERT(DATETIME,'" & Format(toDate, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_CP = '" & _
                                        StrConv(cmbCP.Text.Trim, VbStrConv.ProperCase) & "') AND (P_DUES > 0) AND (P_DEL_OK = 'BILLED')"
            Try
                Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                cmdPaid.Enabled = False
            Catch EX As Exception
                MsgBox(EX.Message + MsgBoxStyle.Information, My.Application.Info.ProductName)
            Finally
                Connection.Close()
                Call cmdClose_Click(sender, e)
            End Try
        End If
    End Sub
End Class