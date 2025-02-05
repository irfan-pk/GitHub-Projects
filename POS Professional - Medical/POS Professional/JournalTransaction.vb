Imports System.Data.SqlClient

Public Class JournalTransaction
    Dim SortID As Integer = 0
    Dim ClosBalance As Double
    Dim UpdateAccount As String = String.Empty

    Private Sub txtDrAccount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrAccount.GotFocus
        Get_Property_GotFocus(txtDrAccount)
    End Sub

    Private Sub txtDrAccount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDrAccount.KeyPress
        ValidateNumbersOnly(sender, e, txtDrAccount)
    End Sub

    Private Sub txtDrAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrAmount.GotFocus
        Get_Property_GotFocus(txtDrAmount)
    End Sub

    Private Sub txtDrAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDrAmount.KeyPress
        ValidateNumbersOnly(sender, e, txtDrAmount)
    End Sub

    Private Sub txtCrAccount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrAccount.GotFocus
        Get_Property_GotFocus(txtCrAccount)
    End Sub

    Private Sub txtCrAccount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrAccount.KeyPress
        ValidateNumbersOnly(sender, e, txtCrAccount)
    End Sub

    Private Sub txtCrAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrAmount.GotFocus
        Get_Property_GotFocus(txtCrAmount)
    End Sub

    Private Sub txtCrAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrAmount.KeyPress
        ValidateNumbersOnly(sender, e, txtCrAmount)
    End Sub

    Private Sub txtDrAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDrAccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtDrAccount.Text) > 0 Then
                Try
                    lblDrAccount.Text = SaleInvoice.FieldInfo("select acc_name from accounts where acc_no = " & Val(txtDrAccount.Text))
                    txtDrAmount.Focus()
                Catch ex As Exception
                    MessageBox.Show("Check data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
            Else
                gblQuery = "select * from accounts where acc_reg_type <> 'CUSTOMER'"
                AccCodesHelp.ShowDialog(Me)
                txtDrAccount.Text = gblCP_ID
                lblDrAccount.Text = gblCP
                If Val(gblCP_ID) > 0 Then txtDrAmount.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescription_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.GotFocus
        Get_Property_GotFocus(txtDescription)
    End Sub

    Private Sub txtDescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtDescription.Text) > 0 Then
                txtDrAccount.Focus()
            End If
        End If
    End Sub

    Private Sub JournalTransaction_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtDescription.Focus()
    End Sub

    Private Sub JournalTransaction_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then Me.Close()
        If e.KeyCode = Keys.F2 Then RemarksHelp()
        If e.KeyCode = Keys.F8 Then MadeLedgerEntry()
    End Sub

    Private Sub MadeLedgerEntry()
        LedgerDrTransaction(Val(txtDrAccount.Text), "Voucher # " & Val(lblTranNo), txtDescription.Text, "DR", Val(txtDrAmount.Text))
        LedgerDrTransaction(Val(txtCrAccount.Text), "Voucher # " & Val(lblTranNo), txtDescription.Text, "CR", Val(txtCrAmount.Text))
    End Sub

    Private Sub RemarksHelp()
        RemarksSelection.ShowDialog(Me)
        If Len(gblInput) > 0 Then txtDescription.Text = gblInput
    End Sub

    Private Sub JournalTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        GetConnectionString()
        lblTranNo.Text = GenerateMax_ID("ledgers", "ledg_tran_id")
        lblTranDate.Text = Format(Now.Date, "MM/dd/yyyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub txtDrAmount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDrAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDrAmount.Text = String.Empty Then MsgBox("Please enter valid amount.", MsgBoxStyle.Critical) : Exit Sub
            txtCrAccount.Focus()
        End If
    End Sub

    Private Sub txtCrAccount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCrAccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtCrAccount.Text) = 0 Then
                gblQuery = "select * from accounts where acc_reg_type <> 'CUSTOMER'"
                AccCodesHelp.ShowDialog(Me)
                txtCrAccount.Text = gblCP_ID
                lblCrAccount.Text = gblCP
                If Val(gblCP_ID) > 0 Then txtCrAmount.Focus()
            Else
                ExecuteAdapterQuery(SqlDataAdapter, "select acc_name from accounts where acc_no = " & txtCrAccount.Text, Connection)
                Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If reader.HasRows Then
                    While reader.Read
                        lblCrAccount.Text = reader.Item("acc_name").ToString()
                    End While
                End If
                txtCrAmount.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescription_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.LostFocus
        Get_Property_LostFocus(txtDescription)
    End Sub

    Private Sub txtDrAccount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrAccount.LostFocus
        Get_Property_LostFocus(txtDrAccount)
    End Sub

    Private Sub txtDrAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDrAmount.LostFocus
        Get_Property_LostFocus(txtDrAmount)
    End Sub

    Private Sub txtCrAccount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrAccount.LostFocus
        Get_Property_LostFocus(txtCrAccount)
    End Sub

    Private Sub txtCrAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrAmount.LostFocus
        Get_Property_LostFocus(txtCrAmount)
    End Sub

    Public Sub LedgerDrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)
        SortID += 1
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
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing

        If gblAccType = "DR" Then _
            UpdateAccount = "update accounts set acc_debit = acc_debit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID

        If gblAccType = "CR" Then _
            UpdateAccount = "update accounts set acc_debit = acc_debit + " & Amount & ", acc_balance = acc_balance - " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub

    Public Sub LedgerCrTransaction(ByVal AccID As Integer, ByVal DocNo As String, ByVal LedgDesc As String, ByVal TransType As String, ByVal Amount As Double)
        SortID += 1
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
                         SortID & ")"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
        If gblAccType = "CR" Then _
                UpdateAccount = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance + " & Amount & " where acc_no = " & AccID
        If gblAccType = "DR" Then _
                UpdateAccount = "update accounts set acc_credit = acc_credit + " & Amount & ", acc_balance = acc_balance - " & Amount & " where acc_no = " & AccID
        ProcessTransaction(UpdateAccount)

    End Sub
End Class