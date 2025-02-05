Imports System.Data.SqlClient

Public Class AccountRegistration
    Dim cmd As SqlCommand = Nothing
    Dim Pos, NewAccID, SortID, AccID, cTranID As Integer
    Dim OpeningBal As Double
    Dim EditString, AccLink As String
    Dim strDate As Date
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim AccountSet As New DataSet()
    Dim AccountSource As New BindingSource()
    Dim AccountAdapter As New SqlDataAdapter()
    Dim SelectAccAdapter As New SqlDataAdapter()
    Dim Addition, Editing, RollBack As Boolean
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False

    Private Sub AccountRegistration_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtAccID.Focus()
    End Sub

    Private Sub AccountHeads_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F2 Then
            AccDataGridView.Focus()
        End If
        If e.KeyCode = Keys.F11 Then
            ClearText()
            enableTextBoxes(False)
            GetLastSequence()
            btnEdit.Enabled = False
            btnSave.Enabled = False
            btnDelete.Enabled = False
            txtAccID.Focus()
        End If
    End Sub

    Private Sub frmNewAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, Access Denied.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        AccDataGridView.DefaultCellStyle.SelectionBackColor = Color.White
        AccDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black
        LoadDB()
        GetLastSequence()
        Addition = False
        Editing = False
    End Sub

    Private Sub LoadDB()
        Try
            AccountSet.Clear()
            Dim CommandText As String = "SELECT ACC_NO, ACC_NAME FROM ACCOUNTS ORDER BY ACC_NO"
            ExecuteAdapterQuery(AccountAdapter, CommandText, Connection)
            AccountAdapter.Fill(AccountSet, "ACCOUNTS")
            AccountSource.DataSource = AccountSet
            AccDataGridView.DataSource = AccountSource
            AccDataGridView.DataMember = "ACCOUNTS"
            AccDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub GetLastSequence()
        Dim Max As String = "select max(acc_no) as MaxID from accounts"
        Dim MaxAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(MaxAdapter, Max, Connection)
        Dim reader As SqlDataReader = MaxAdapter.SelectCommand.ExecuteReader
        While reader.Read
            lblSeq.Text = reader.Item("MaxID").ToString
        End While
        If reader Is Nothing Then reader.Close()
        txtAccID.Text = GenerateMax_ID("accounts", "acc_no")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtDrCr.Text = "DR" Then _
            OpeningBal = Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) - Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim))
        If txtDrCr.Text = "CR" Then _
            OpeningBal = Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) - Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim))

        If txtAccName.Text = String.Empty Or _
        cmbAccHead.Text = String.Empty Or _
        cbAccReg.Text = String.Empty Or _
        txtCrDays.Text = String.Empty Or _
        txtCrLimit.Text = String.Empty Or _
        txtBankName.Text = String.Empty Or _
        txtBankAcc.Text = String.Empty Then
            MessageBox.Show("All Fields are mandatory.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call ProcessTransaction("UPDATE ACCOUNTS SET ACC_NAME = '" & StrConv(txtAccName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " ACC_REG_TYPE = '" & cbAccReg.Text.ToUpper & "'," & _
                                                           " ACC_TYPE = '" & txtDrCr.Text.ToUpper.Trim & "'," & _
                                                           " ACC_BALANCE = " & Convert.ToDecimal(OpeningBal) & "," & _
                                                           " ACC_REG_ON = '" & Format(Date.Parse(dtpRegOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                                                           " ACC_DEBIT = " & Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) & "," & _
                                                           " ACC_CREDIT = " & Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) & "," & _
                                                           " ACC_ADDRESS = '" & txtAddress.Text.Trim.ToUpper & "'," & _
                                                           " ACC_PHONE = '" & txtPhone.Text.Trim & "'," & _
                                                           " ACC_MOBILE = '" & txtMobile.Text.Trim & "'," & _
                                                           " ACC_AREA = '" & txtArea.Text.ToUpper & "'," & _
                                                           " ACC_BANKNAME = '" & txtBankName.Text.ToUpper & "'," & _
                                                           " ACC_BANKACCNO = '" & txtBankAcc.Text.ToUpper & "'," & _
                                                           " ACC_CRDAYS = " & Convert.ToDecimal(Val(txtCrDays.Text.Trim)) & "," & _
                                                           " ACC_CRLIMIT = " & Convert.ToDecimal(Val(txtCrLimit.Text.Trim)) & "," & _
                                                           " ACC_HEAD = '" & cmbAccHead.Text.ToUpper.Trim & "' WHERE ACC_NO = " & Val(EditString) & " AND ACC_NO > 7")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call ProcessTransaction("INSERT INTO ACCOUNTS VALUES(" & Val(txtAccID.Text) & ",'" & _
                                                           cmbAccHead.Text.ToUpper.Trim & "','" & _
                                                           cbAccReg.Text.ToUpper.Trim & "','" & _
                                                           StrConv(txtAccName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           txtDrCr.Text.ToUpper.Trim & "'," & _
                                                           Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) & "," & _
                                                           Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) & "," & _
                                                           Convert.ToDecimal(Val(txtOpnBal.Text.Trim)) & ",'" & _
                                                           Format(Date.Parse(dtpRegOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','" & _
                                                           txtAddress.Text.Trim.ToUpper & "','" & _
                                                           txtArea.Text.ToUpper & "','" & _
                                                           txtBankName.Text.ToUpper & "','" & _
                                                           txtBankAcc.Text.ToUpper & "','" & _
                                                           txtPhone.Text.ToUpper & "','" & _
                                                           txtMobile.Text.ToUpper & "'," & _
                                                           Val(txtCrDays.Text.Trim) & "," & _
                                                           Convert.ToDecimal(Val(txtCrLimit.Text.Trim)) & ")")

        
        LoadDB()
        ClearText()
        enableTextBoxes(False)
        Editing = False
        Addition = False
        strCurrency = String.Empty
        GetLastSequence()
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txtAccID.Focus()
    End Sub

    Private Sub cmbDrCr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDrCr.SelectedIndexChanged
        If cmbDrCr.Text.Trim = "Debit" Then txtDrCr.Text = "DR"
        If cmbDrCr.Text.Trim = "Credit" Then txtDrCr.Text = "CR"
    End Sub

    Private Sub txtOpnDrBal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOpnDrBal.GotFocus
        Get_Property_LostFocus(txtOpnDrBal)
    End Sub

    Private Sub txtOpnDrBal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpnDrBal.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
        If e.KeyCode = Keys.Enter Then
            txtOpnCrBal.Focus()
        End If
    End Sub

    Private Sub txtOpnDrBal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpnDrBal.KeyPress
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                txtOpnDrBal.Text = ""
            ElseIf strCurrency.Length = 1 Then
                txtOpnDrBal.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                txtOpnDrBal.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                txtOpnDrBal.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            txtOpnDrBal.Select(txtOpnDrBal.Text.Length, 0)
        End If
        e.Handled = True
    End Sub

    Private Sub txtOpnCrBal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOpnCrBal.GotFocus
        Get_Property_GotFocus(txtOpnCrBal)
    End Sub

    Private Sub txtOpnCrBal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpnCrBal.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
        If e.KeyCode = Keys.Enter Then
            txtCrDays.Focus()
        End If
    End Sub

    Private Sub txtOpnCrBal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpnCrBal.KeyPress
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                txtOpnCrBal.Text = ""
            ElseIf strCurrency.Length = 1 Then
                txtOpnCrBal.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                txtOpnCrBal.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                txtOpnCrBal.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            txtOpnCrBal.Select(txtOpnCrBal.Text.Length, 0)
        End If
        e.Handled = True
    End Sub

    Private Sub BindingNavigatorRefreshItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Temporary Skip
        Call UpdateAccountsBalances()
    End Sub

    Private Sub UpdateAccountsBalances()
        Cursor = Cursors.WaitCursor
        Dim statusForm As New Status()
        statusForm.Show("Please wait updating balances...")
        Call FinalizeLedgersBalances()
        Dim UpdateBalance As Decimal = 0.0
        Dim UpdateAccID As Integer = 0
        ExecuteAdapterQuery(SqlDataAdapter, "Select * from accounts order by acc_no", Connection)
        Dim AccReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If AccReader.HasRows Then
            While AccReader.Read
                UpdateAccID = Convert.ToInt32(AccReader.Item("acc_no").ToString)
                If Convert.ToDecimal(AccReader.Item("acc_debit").ToString) <> 0 And Convert.ToDecimal(AccReader.Item("acc_credit").ToString) <> 0 Then
                    If AccReader.Item("ACC_TYPE").ToString = "DR" Then UpdateBalance = Convert.ToDecimal(AccReader.Item("acc_debit").ToString) - Convert.ToDecimal(AccReader.Item("acc_credit").ToString)
                    If AccReader.Item("ACC_TYPE").ToString = "CR" Then UpdateBalance = Convert.ToDecimal(AccReader.Item("acc_credit").ToString) - Convert.ToDecimal(AccReader.Item("acc_debit").ToString)
                    Call ProcessTransaction("update accounts set acc_balance = " & UpdateBalance & " where acc_no = " & UpdateAccID)
                Else
                    'Do nothing
                End If
            End While
        End If
        statusForm.Close()
        Cursor = Cursors.Default
    End Sub

    Private Sub cmbAccHead_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAccHead.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbAccReg.Focus()
        End If
    End Sub

    Private Sub cmbAccHead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccHead.SelectedIndexChanged
        btnSave.Enabled = True
    End Sub

    Private Sub cbAccReg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAccReg.SelectedIndexChanged
        btnSave.Enabled = True
    End Sub

    Private Sub cbAccReg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbAccReg.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAccName.Focus()
        End If
    End Sub

    Private Sub txtAccName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccName.GotFocus
        Get_Property_GotFocus(txtAccName)
    End Sub

    Private Sub txtAccName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccName.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtAccName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddress.Focus()
        End If
    End Sub

    Private Sub txtAddress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.GotFocus
        Get_Property_GotFocus(txtAddress)
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtArea.Focus()
        End If
    End Sub

    Private Sub txtArea_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArea.GotFocus
        Get_Property_GotFocus(txtArea)
    End Sub

    Private Sub txtArea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtArea_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtArea.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBankName.Focus()
        End If
    End Sub

    Private Sub txtBankName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBankName.GotFocus
        Get_Property_GotFocus(txtBankName)
    End Sub

    Private Sub txtBankName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankName.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtBankName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBankName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBankAcc.Focus()
        End If
    End Sub

    Private Sub txtBankAcc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBankAcc.GotFocus
        Get_Property_GotFocus(txtBankAcc)
    End Sub

    Private Sub txtBankAcc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBankAcc.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtBankAcc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBankAcc.KeyPress
        ValidateAlphaNumOnly(sender, e)
    End Sub

    Private Sub txtBankAcc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBankAcc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPhone.Focus()
        End If
    End Sub

    Private Sub txtPhone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.GotFocus
        Get_Property_GotFocus(txtPhone)
    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        ValidateNumbersOnly(sender, e, txtPhone)
    End Sub

    Private Sub txtPhone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMobile.Focus()
        End If
    End Sub

    Private Sub txtMobile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.GotFocus
        Get_Property_GotFocus(txtMobile)
    End Sub

    Private Sub txtMobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobile.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtMobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        ValidateNumericKeyPress(sender, e, txtMobile)
    End Sub

    Private Sub txtMobile_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbDrCr.Focus()
        End If
    End Sub

    Private Sub cmbDrCr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDrCr.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtOpnDrBal.Focus()
        End If
    End Sub

    Private Sub txtOpnCrBal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOpnCrBal.LostFocus
        Get_Property_LostFocus(txtOpnCrBal)
    End Sub

    Private Sub txtOpnCrBal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpnCrBal.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtOpnDrBal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpnDrBal.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtCrDays_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrDays.GotFocus
        Get_Property_GotFocus(txtCrDays)
    End Sub

    Private Sub txtCrDays_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrDays.KeyPress
        ValidateNumbersOnly(sender, e, txtCrDays)
    End Sub

    Private Sub txtCrDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrDays.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtCrDays_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCrDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCrLimit.Focus()
        End If
    End Sub

    Private Sub txtCrLimit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrLimit.GotFocus
        Get_Property_GotFocus(txtCrLimit)
    End Sub

    Private Sub txtCrLimit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCrLimit.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpRegOn.Focus()
        End If
    End Sub

    Private Sub txtCrLimit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCrLimit.KeyPress
        ValidateNumbersOnly(sender, e, txtCrLimit)
    End Sub

    Private Sub txtCrLimit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrLimit.LostFocus
        Get_Property_LostFocus(txtCrLimit)
    End Sub

    Private Sub txtCrLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCrLimit.TextChanged
        btnNew.Enabled = True
    End Sub

    Private Sub dtpRegOn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpRegOn.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnNew.Enabled = True
        End If
    End Sub

    Private Sub txtAccID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccID.GotFocus
        Get_Property_GotFocus(txtAccID)
    End Sub

    Private Sub txtAccID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtAccID.Text) > 0 Then
                ExecuteAdapterQuery(SelectAccAdapter, "select * from accounts where acc_no = " & Val(txtAccID.Text) & " order by acc_no", Connection)
                Dim SelectReader As SqlDataReader = SelectAccAdapter.SelectCommand.ExecuteReader
                If SelectReader.HasRows Then
                    While SelectReader.Read
                        cmbAccHead.Text = SelectReader.Item("acc_head").ToString()
                        cbAccReg.Text = SelectReader.Item("acc_reg_type").ToString()
                        txtAccName.Text = SelectReader.Item("acc_name").ToString()
                        txtAddress.Text = SelectReader.Item("acc_address").ToString()
                        txtArea.Text = SelectReader.Item("acc_area").ToString()
                        txtBankName.Text = SelectReader.Item("acc_bankname").ToString()
                        txtBankAcc.Text = SelectReader.Item("acc_bankaccno").ToString()
                        txtPhone.Text = SelectReader.Item("acc_phone").ToString()
                        txtMobile.Text = SelectReader.Item("acc_mobile").ToString()
                        txtDrCr.Text = SelectReader.Item("acc_type").ToString()
                        txtOpnDrBal.Text = SelectReader.Item("acc_debit").ToString()
                        txtOpnCrBal.Text = SelectReader.Item("acc_credit").ToString()
                        txtOpnBal.Text = SelectReader.Item("acc_balance").ToString()
                        txtCrDays.Text = SelectReader.Item("acc_crdays").ToString()
                        txtCrLimit.Text = SelectReader.Item("acc_crlimit").ToString()
                        dtpRegOn.Value = SelectReader.Item("acc_reg_on")
                        btnEdit.Enabled = True
                        btnDelete.Enabled = True
                        btnEdit.Focus()
                    End While
                Else
                    ClearText()
                    enableTextBoxes(True)
                    cmbAccHead.Focus()
                    txtOpnBal.Text = 0
                    Addition = True
                End If
            Else
                HelpTable = "accounts"
                HelpF1 = "acc_name"
                HelpF2 = "acc_no"
                CodesHelp.ShowDialog(Me)
                txtAccID.Text = gblCP_ID.Trim
            End If
        End If
    End Sub

    Private Sub ClearText()
        txtAccName.Clear()
        cmbAccHead.Text = String.Empty
        cbAccReg.Text = String.Empty
        txtAddress.Clear()
        txtBankAcc.Clear()
        txtBankName.Clear()
        txtArea.Clear()
        txtOpnBal.Clear()
        txtOpnCrBal.Clear()
        txtOpnDrBal.Clear()
        txtPhone.Clear()
        txtMobile.Clear()
        txtCrDays.Clear()
        txtCrLimit.Clear()
        txtDrCr.Clear()
        dtpRegOn.Text = Now.Date
        cmbDrCr.Text = String.Empty
    End Sub

    Private Sub enableTextBoxes(ByVal State As Boolean)
        txtAccName.Enabled = State
        cmbAccHead.Enabled = State
        cbAccReg.Enabled = State
        txtAddress.Enabled = State
        txtArea.Enabled = State
        txtPhone.Enabled = State
        txtMobile.Enabled = State
        txtBankName.Enabled = State
        txtBankAcc.Enabled = State
        cmbDrCr.Enabled = State
        txtOpnBal.Enabled = State
        txtOpnCrBal.Enabled = State
        txtOpnDrBal.Enabled = State
        txtCrDays.Enabled = State
        txtCrLimit.Enabled = State
        dtpRegOn.Enabled = State
    End Sub

    Private Sub txtAccID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccID.KeyPress
        ValidateNumbersOnly(sender, e, txtAccID)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearText()
        Editing = False
        Addition = True
        btnSave.Enabled = False
        txtAccID.Text = GenerateMax_ID("accounts", "acc_no")
        enableTextBoxes(True)
        ClearText()
        cmbAccHead.Focus()
    End Sub

    Private Sub AccDataGridView_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AccDataGridView.GotFocus
        AccDataGridView.DefaultCellStyle.SelectionBackColor = Color.Black
        AccDataGridView.DefaultCellStyle.SelectionForeColor = Color.LimeGreen
    End Sub

    Private Sub AccDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AccDataGridView.KeyDown
        If e.KeyCode = Keys.Escape Then
            txtAccID.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AccDataGridView_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AccDataGridView.LostFocus
        AccDataGridView.DefaultCellStyle.SelectionBackColor = Color.White
        AccDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        enableTextBoxes(True)
        Editing = True
        Addition = False
        EditString = txtAccID.Text
        cmbAccHead.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtAccName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dr = Windows.Forms.DialogResult.Yes Then
                ProcessTransaction("DELETE FROM PRODUCTS WHERE PROD_DESC = '" & txtAccName.Text.Trim & "'")
                btnSave.Enabled = False
                btnEdit.Enabled = False
                btnDelete.Enabled = False
            End If
        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtAccName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccName.LostFocus
        Get_Property_LostFocus(txtAccName)
    End Sub

    Private Sub txtAccID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAccID.LostFocus
        Get_Property_LostFocus(txtAccID)
    End Sub

    Private Sub txtAddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.LostFocus
        Get_Property_LostFocus(txtAddress)
    End Sub

    Private Sub txtArea_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArea.LostFocus
        Get_Property_LostFocus(txtArea)
    End Sub

    Private Sub txtBankAcc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBankAcc.LostFocus
        Get_Property_LostFocus(txtBankAcc)
    End Sub

    Private Sub txtBankName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBankName.LostFocus
        Get_Property_LostFocus(txtBankName)
    End Sub

    Private Sub txtCrDays_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrDays.LostFocus
        Get_Property_LostFocus(txtCrDays)
    End Sub

    Private Sub txtMobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.LostFocus
        Get_Property_LostFocus(txtMobile)
    End Sub

    Private Sub txtPhone_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.LostFocus
        Get_Property_LostFocus(txtPhone)
    End Sub
End Class