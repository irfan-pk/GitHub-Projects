Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Expenses
    Dim UpdateAccount As String = String.Empty
    Dim SortId As Integer = 0
    Dim ClosBalance As Double

    Public Sub LedgerDrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)
        SortId += 1
        ClosBalance = 0
        Call Get_Account_Parameters(AccID)
        If gblAccType = "DR" Then ClosBalance = gblLedgBal + Amount
        If gblAccType = "CR" Then ClosBalance = gblLedgBal - Amount
        Dim strDate As DateTime = DateTime.Now
        strDate = lblTranDate.Text.ToString
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
                         ClosBalance & "," & _
                         SortId & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing

        If gblAccType = "DR" Then _
            UpdateAccount = "update accounts set acc_debit = acc_debit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID

        If gblAccType = "CR" Then _
            UpdateAccount = "update accounts set acc_debit = acc_debit + " & Amount & ", acc_balance = acc_balance - " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub

    Public Sub LedgerCrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)
        SortId += 1
        ClosBalance = 0
        Call Get_Account_Parameters(AccID)
        If gblAccType = "CR" Then ClosBalance = gblLedgBal + Amount
        If gblAccType = "DR" Then ClosBalance = gblLedgBal - Amount
        Dim strDate As DateTime = DateTime.Now
        strDate = lblTranDate.Text.ToString
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
                         ClosBalance & "," & _
                         SortId & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        If gblAccType = "CR" Then _
                UpdateAccount = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID
        If gblAccType = "DR" Then _
                UpdateAccount = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance - " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub


    Private Sub Expenses_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then
            Connection.Close()
            Me.Close()
        End If
        If e.KeyCode = Keys.F2 Then MadeExpenseEntry()
    End Sub

    Private Sub MadeExpenseEntry()
        If Val(txtPaidCash.Text) > 0 And Val(txtPaidCheque) < 1 Then
            Dim Narration As String = String.Empty
            If txtParticulars.Text = String.Empty Then Narration = "Cash paid for " & lblExpAccount.Text Else Narration = txtParticulars.Text.Trim
            LedgerDrTransaction(Val(txtExpCode.Text), lblTranNo.Text & "-" & lblTranDate.Text, Narration, "DR", Val(txtPaidCash.Text))
            LedgerCrTransaction(1, lblTranNo.Text & "-" & lblTranDate.Text, Narration, "CR", Val(txtPaidCash.Text))
        End If
        If Val(txtPaidCash.Text) > 0 And Val(txtPaidCheque) > 0 Then
            If txtBnkCode.Text = String.Empty Or txtChequeNo.Text = String.Empty Or txtChqDate.Text = String.Empty Then
                MessageBox.Show("Field should'nt be blank.", "Fields Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim Narration As String = String.Empty
                If txtParticulars.Text = String.Empty Then Narration = "Cash paid for " & lblExpAccount.Text Else Narration = txtParticulars.Text.Trim
                LedgerDrTransaction(Val(txtExpCode.Text), lblTranNo.Text & "-" & lblTranDate.Text, Narration, "DR", Val(txtPaidCheque.Text))
                LedgerCrTransaction(Val(lblBankAccount.Text), lblTranNo.Text & "-" & lblTranDate.Text, Narration, "CR", Val(txtPaidCheque.Text))
            End If
        End If
    End Sub

    Private Sub Expenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 100
        Me.Left = 100
        GetConnectionString()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        e.Graphics.DrawLine(Pens.DarkGray, 10, 110, Panel1.Width - 15, 110)
        e.Graphics.DrawLine(Pens.DarkGray, 10, 230, Panel1.Width - 15, 230)
    End Sub

    Private Sub txtExpCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExpCode.GotFocus
        Get_Property_GotFocus(txtExpCode)
    End Sub

    Private Sub txtExpCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExpCode.KeyPress
        ValidateNumbersOnly(sender, e, txtExpCode)
    End Sub

    Private Sub txtPaidCash_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaidCash.GotFocus
        Get_Property_GotFocus(txtPaidCash)
    End Sub

    Private Sub txtPaidCash_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaidCash.KeyPress
        ValidateNumbersOnly(sender, e, txtPaidCash)
    End Sub

    Private Sub txtPaidCheque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaidCheque.KeyPress
        ValidateNumbersOnly(sender, e, txtPaidCheque)
    End Sub

    Private Sub txtBnkCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBnkCode.GotFocus
        Get_Property_GotFocus(txtBnkCode)
    End Sub

    Private Sub txtBnkCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBnkCode.KeyPress
        ValidateNumbersOnly(sender, e, txtBnkCode)
    End Sub

    Private Sub txtChequeNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequeNo.GotFocus
        Get_Property_GotFocus(txtChequeNo)
    End Sub

    Private Sub txtChequeNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChequeNo.KeyPress
        ValidateNumbersOnly(sender, e, txtChequeNo)
    End Sub

    Private Sub txtExpCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExpCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtExpCode.Text) > 0 Then
                txtPaidCash.Focus()
            Else
                gblQuery = "select * from accounts order by acc_no"
                AccCodesHelp.ShowDialog(Me)
                If Len(gblCP_ID) > 0 Then txtExpCode.Text = gblCP_ID : lblExpAccount.Text = gblCP : txtPaidCash.Focus() Else txtExpCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtExpCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExpCode.LostFocus
        Get_Property_LostFocus(txtExpCode)
    End Sub

    Private Sub txtBnkCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBnkCode.LostFocus
        Get_Property_LostFocus(txtBnkCode)
    End Sub

    Private Sub txtChequeNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequeNo.LostFocus
        Get_Property_LostFocus(txtChequeNo)
    End Sub

    Private Sub txtChqDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChqDate.GotFocus
        Get_Property_GotFocus(txtChqDate)
    End Sub

    Private Sub txtChqDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChqDate.LostFocus
        Get_Property_LostFocus(txtChqDate)
    End Sub

    Private Sub txtPaidCash_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaidCash.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPaidCheque.Focus()
        End If
    End Sub

    Private Sub txtPaidCheque_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaidCheque.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBnkCode.Focus()
        End If
    End Sub

    Private Sub txtBnkCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBnkCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtChqDate.Focus()
        End If
    End Sub

    Private Sub txtChqDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChqDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtChequeNo.Focus()
        End If
    End Sub

    Private Sub txtChequeNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChequeNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtParticulars.Focus()
        End If
    End Sub
End Class