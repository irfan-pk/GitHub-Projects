Imports System.Data.SqlClient

Public Class Expenses

    Dim SortId As Integer = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tbAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(tbAmount.Text) > 0 Then tbDesc.Focus()
        End If
    End Sub

    Private Sub tbDesc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(tbDesc.Text) > 4 Then btnSave.Enabled = True : btnSave.Focus()
        End If
    End Sub

    Private Sub tbAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAmount.KeyPress
        Call ValidateNumbersOnly(sender, e, tbAmount)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Val(tbAmount.Text) > 0 And Len(tbDesc.Text) > 4 Then
            Call LedgerDrTransaction(7, "EXP-" & Format(Now.Date, "ddMMyyyy"), tbDesc.Text.Trim, "DR", Val(tbAmount.Text))
            Call LedgerCrTransaction(1, "EXP-" & Format(Now.Date, "ddMMyyyy"), tbDesc.Text.Trim, "CR", Val(tbAmount.Text))
            SortId = 0
            btnSave.Enabled = False
        Else
            MessageBox.Show("All fields are manadatory.", "Fields Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LedgerDrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)

        SortID += 1
        Call Get_Account_Parameters(AccID)
        'Call Get_Ledger_Parameters(AccID)
        Dim strDate As DateTime = DateTime.Now
        'strDate = lblDate.Text.ToString
        Dim TranID As Decimal = GenerateMax_ID("LEDGERS", "LEDG_TRAN_ID")
        ''// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String = String.Empty
        NewTransaction = "INSERT INTO LEDGERS VALUES ('" & _
                         Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                         TranID & "," & _
                         AccID & ",'" & _
                         DocNo.Trim & "','" & _
                         StrConv(gblAccHead.Trim, VbStrConv.Uppercase) & "','" & _
                         StrConv(gblAccName.Trim, VbStrConv.Uppercase) & "','" & _
                         LedgDesc.Trim.ToString & "','" & _
                         TransType & "'," & _
                         Amount & ",0.00," & _
                         "0.00" & "," & _
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        Dim UpdateAccount As String = String.Empty
        UpdateAccount = "update accounts set acc_debit = acc_debit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub

    Private Sub LedgerCrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)

        SortID += 1
        Call Get_Account_Parameters(AccID)
        'Call Get_Ledger_Parameters(AccID)
        Dim strDate As DateTime = DateTime.Now
        'strDate = lblDate.Text.ToString
        Dim TranID As Decimal = GenerateMax_ID("LEDGERS", "LEDG_TRAN_ID")
        ''// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String = String.Empty
        NewTransaction = "INSERT INTO LEDGERS VALUES ('" & _
                         Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                         TranID & "," & _
                         AccID & ",'" & _
                         DocNo.Trim & "','" & _
                         StrConv(gblAccHead.Trim, VbStrConv.Uppercase) & "','" & _
                         StrConv(gblAccName.Trim, VbStrConv.Uppercase) & "','" & _
                         LedgDesc.Trim.ToString & "','" & _
                         TransType & "'," & _
                         "0.00," & Amount & "," & _
                         "0.00" & "," & _
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        Dim UpdateAccount As String = String.Empty
        UpdateAccount = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance - " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub
End Class