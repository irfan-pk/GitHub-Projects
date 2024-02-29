Imports System.Data.SqlClient

Public Class AccountHeads
    Dim cmd As SqlCommand = Nothing
    Dim Pos, NewAccID, SortID, AccID, cTranID As Integer
    Dim OpeningBal As Double
    Dim EditString, AccLink As String
    Dim strDate As Date
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False

    Private Sub frmNewAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, Access Denied.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetFinancialYear()
        Call GetConnectionString()
        'Call UpdateAccountsBalances()
        Call LoadDB()
    End Sub

    Private Sub LoadDB()
        Try
            Me.AccDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM ACCOUNTS ORDER BY ACC_NO"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "ACCOUNTS", Connection)
            SqlDataAdapter.Fill(Me.AccDataSet, "ACCOUNTS")
            Me.AccBindingSource.DataSource = Me.AccDataSet
            Me.AccBindingSource.DataMember = "ACCOUNTS"
            Me.txtAccID.DataBindings.Add("TEXT", AccBindingSource, "ACC_NO")
            Me.txtAccName.DataBindings.Add("TEXT", AccBindingSource, "ACC_NAME")
            Me.txtDrCr.DataBindings.Add("TEXT", AccBindingSource, "ACC_TYPE")
            Me.txtOpnBal.DataBindings.Add("TEXT", AccBindingSource, "ACC_BALANCE")
            Me.dtpUpdOn.DataBindings.Add("TEXT", AccBindingSource, "ACC_UPDATE")
            Me.dtpOpenOn.DataBindings.Add("TEXT", AccBindingSource, "ACC_OPN_DATE")
            Me.cmbAccHead.DataBindings.Add("TEXT", AccBindingSource, "ACC_HEAD")
            Me.txtOpnDrBal.DataBindings.Add("TEXT", AccBindingSource, "ACC_DEBIT")
            Me.txtOpnCrBal.DataBindings.Add("TEXT", AccBindingSource, "ACC_CREDIT")
            Addition = False
            Editing = False
            Me.BindingNavigatorSaveItem.Enabled = False
            Me.Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            cmbAccHead.Focus()
            AccDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        Dim strCode As String
        strCode = Microsoft.VisualBasic.InputBox("Please Enter Acc Code To Find.", "Find")
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.AccBindingSource.Find("ACC_NO", Val(strCode.Trim))
        If Not Pos = -1 Then
            EditString = strCode
            Me.AccBindingSource.Position = Pos
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Panel1.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        NewAccID = GenerateMax_ID("ACCOUNTS", "ACC_NO")
        txtAccID.Text = NewAccID
        cmbAccHead.Focus()
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click
        Editing = True
        Addition = False
        Panel1.Enabled = True
        EditString = txtAccID.Text.Trim
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        EditString = txtAccID.Text.Trim
        txtAccName.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtAccName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record")
        If Me.BindingNavigatorCloseItem.Text = "&Cancel" Then Me.BindingNavigatorCloseItem.Text = "E&xit"
        If MsgBoxResult.Ok Then
            Try
                Dim CommandText As String = "DELETE FROM ACCOUNTS WHERE ACC_NO = " & Val(txtAccID.Text.ToUpper.Trim)
                ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "ACCOUNTS", Connection)
            Catch Ex As SqlException
                Me.AccDataGrid.RefreshEdit()
                Me.AccBindingNavigator.Refresh()
            End Try
        End If
        Me.AccDataGrid.RefreshEdit()
        Me.AccBindingNavigator.Refresh()
        Call RefreshDB()
    End Sub

    Private Sub BindingNavigatorCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCloseItem.Click
        If Me.BindingNavigatorCloseItem.Text = "E&xit" Then
            Connection.Close()
            Me.AccBindingSource.Dispose()
            Me.Close()
        Else
            Me.BindingNavigatorCloseItem.Text = "&Cancel"
            Me.BindingNavigatorSaveItem.Enabled = False
            Panel1.Enabled = False
            Me.BindingNavigatorCloseItem.Text = "E&xit"
            Call RefreshDB()
            Addition = False
            Editing = False
        End If
    End Sub
    Private Sub BindingNavigatorQuery(ByVal Query As String)
        Try
            Execute_DatabaseTable_Query(SqlDataAdapter, Query, Connection)
            Connection.Close()
            SqlDataAdapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        If txtDrCr.Text = "DR" Then _
            OpeningBal = Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) - Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim))
        If txtDrCr.Text = "CR" Then _
            OpeningBal = Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) - Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim))

        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE ACCOUNTS SET ACC_NAME = '" & StrConv(txtAccName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " ACC_TYPE = '" & txtDrCr.Text.ToUpper.Trim & "'," & _
                                                           " ACC_OPN_DATE = '" & Format(DateTime.Parse(dtpOpenOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                                                           " ACC_BALANCE = " & Convert.ToDecimal(OpeningBal) & "," & _
                                                           " ACC_UPDATE = '" & Format(DateTime.Parse(dtpUpdOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                                                           " ACC_DEBIT = " & Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) & "," & _
                                                           " ACC_CREDIT = " & Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) & "," & _
                                                           " ACC_F_YEAR = '" & FinancialYear & "'," & _
                                                           " ACC_HEAD = '" & cmbAccHead.Text.ToUpper.Trim & "' WHERE ACC_NO = '" & EditString & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO ACCOUNTS VALUES('" & NewAccID & "','" & _
                                                           cmbAccHead.Text.ToUpper.Trim & "','" & _
                                                           Format(DateTime.Parse(dtpOpenOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','" & _
                                                           StrConv(txtAccName.Text.ToUpper.Trim, VbStrConv.ProperCase) & "','" & _
                                                           txtDrCr.Text.ToUpper.Trim & "'," & _
                                                           Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) & ",'" & _
                                                           Format(DateTime.Parse(dtpUpdOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) & "," & Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) & ",'" & FinancialYear & "')")

        Call RefreshDB()
        Me.BindingNavigatorSaveItem.Enabled = False
        Panel1.Enabled = False
        Editing = False
        Addition = False
        Me.BindingNavigatorEditItem.Enabled = True
        Me.BindingNavigatorCloseItem.Text = "&Close"
        strCurrency = String.Empty
    End Sub

    Private Sub RefreshDB()
        Try
            Me.AccDataSet.Clear()
            SqlDataAdapter.Dispose()
            Me.AccDataGrid.Refresh()
            Dim QueryText As String = "SELECT * FROM ACCOUNTS ORDER BY ACC_NO"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "ACCOUNTS", Connection)
            SqlDataAdapter.Fill(Me.AccDataSet, "ACCOUNTS")
            Me.AccBindingSource.DataSource = Me.AccDataSet
            Me.AccBindingSource.DataMember = "ACCOUNTS"
            Me.AccDataGrid.RefreshEdit()
            Me.AccDataGrid.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub cmbDrCr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDrCr.SelectedIndexChanged
        If cmbDrCr.Text.Trim = "Debit" Then txtDrCr.Text = "DR"
        If cmbDrCr.Text.Trim = "Credit" Then txtDrCr.Text = "CR"
    End Sub

    Private Sub txtOpnDrBal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpnDrBal.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
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

    Private Sub txtOpnCrBal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpnCrBal.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
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

    Private Sub BindingNavigatorRefreshItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorRefreshItem.Click
        'Temporary Skip
        'Call AccountLedgers.Update_Balances()
        Call UpdateAccountsBalances()
        Call RefreshDB()
    End Sub

    Private Sub UpdateAccountsBalances()
        Cursor = Cursors.WaitCursor
        Dim statusForm As New Status()
        statusForm.Show("Please wait updating balances...")
        Call FinalizeLedgersBalances()
        Dim UpdateBalance As Decimal = 0.0
        Dim UpdateAccID As Integer = 0
        Execute_DatabaseTable_Query(SqlDataAdapter, "Select * from accounts order by acc_no", Connection)
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

    Private Sub BindingNavigatorPeriodItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorPeriodItem.Click
        ''Check if fiscal_year opened more than one
        'Execute_DatabaseTable_Query(SqlDataAdapter, "select count(fiscal_year_status) as counter from fiscal_year", Connection)
        'Dim counter As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        'Dim cPeriod As Integer = 0
        'If counter.HasRows Then
        '    While counter.Read
        '        cPeriod = Convert.ToInt32(counter.Item("counter").ToString)
        '    End While
        'End If
        'If cPeriod > 1 Then
        '    MessageBox.Show(Me, "Too many fiscal periods are opened, plz check fiscal period.", "Accounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        'Dim CheckDate As String = "select * from fiscal_year where fiscal_year_period = '" & FinancialYear & "' and fiscal_year_status = 'OPENED' and fiscal_year_end < CONVERT(DATETIME,'" & Format(DateTime.Parse(Now.Date.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)"
        'Execute_DatabaseTable_Query(SqlDataAdapter, CheckDate, Connection)
        'Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        'If Checker.HasRows Then
        '    'Skip
        'Else
        '    MessageBox.Show("Fiscal period cannot be close before end date.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        'Dim dr As DialogResult = MessageBox.Show("This will close current fiscal period and balance brought forward for next fiscal period," & vbCrLf & "this process cannot be undone. (Yes/No)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If dr = System.Windows.Forms.DialogResult.Yes Then
        '    'Procedure for Make changes
        '    SortID = 0
        '    Call Finalize_Fiscal_Period()
        'Else
        '    Exit Sub
        'End If
    End Sub

    'Private Sub Finalize_Fiscal_Period()
    '    Dim SelectAccounts As String = "select * from accounts order by acc_no"
    '    Dim AccountsAdapter As New SqlDataAdapter
    '    Execute_DatabaseTable_Query(AccountsAdapter, SelectAccounts, Connection)
    '    Dim AccountsReader As SqlDataReader = AccountsAdapter.SelectCommand.ExecuteReader
    '    If AccountsReader.HasRows Then
    '        While AccountsReader.Read
    '            If AccountsReader.Item("acc_type").ToString = "DR" Then
    '                Call DebitTransaction(Val(AccountsReader.Item("acc_no").ToString), AccountsReader.Item("acc_type").ToString, AccountsReader.Item("acc_balance").ToString, "B/l brought forward for netxt period", "B/F - 001")
    '            Else
    '                Call CreditTransaction(Val(AccountsReader.Item("acc_no").ToString), AccountsReader.Item("acc_type").ToString, AccountsReader.Item("acc_balance").ToString, "B/l brought forward for netxt period", "B/F - 001")
    '            End If
    '        End While
    '    End If
    'End Sub

    'Private Sub DebitTransaction(ByVal Trans_Acc_Name As String, ByVal TransType As String, ByVal Trans_Amount As Double, ByVal TransDesc As String, ByVal DocNo As String)

    '    SortID += 1
    '    AccID = Get_Account_ID(Trans_Acc_Name.Trim.ToString)
    '    cTranID = GenerateMax_ID("GENERAL_JOURNAL", "GEN_TRAN_ID")
    '    TransDesc = Trans_Acc_Name & Space(1) & TransDesc.Trim

    '    '// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
    '    Dim NewTransaction As String

    '    NewTransaction = "INSERT INTO GEN_TEMP VALUES ('" & _
    '                     Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
    '                     cTranID & "," & _
    '                     Val(AccID) & ",'" & _
    '                     DocNo.Trim & "','" & _
    '                     StrConv(gblAccHead.Trim, VbStrConv.ProperCase) & "','" & _
    '                     StrConv(Trans_Acc_Name.Trim, VbStrConv.ProperCase) & "','" & _
    '                     TransDesc.Trim.ToString & "'," & _
    '                     "0,'" & _
    '                     TransType & "'," & _
    '                     Trans_Amount & ",0.00," & _
    '                     Val(SortID) & ",'" & _
    '                     FinancialYear & "',0)"

    '    ProcessTransaction(NewTransaction)
    '    NewTransaction = Nothing
    'End Sub

    'Private Sub CreditTransaction(ByVal Trans_Acc_Name As String, ByVal TransType As String, ByVal Trans_Amount As Double, ByVal TransDesc As String, ByVal DocNo As String)

    '    SortID += 1
    '    AccID = Get_Account_ID(Trans_Acc_Name.Trim.ToString)
    '    cTranID = GenerateMax_ID("GENERAL_JOURNAL", "GEN_TRAN_ID")
    '    TransDesc = Trans_Acc_Name & Space(1) & TransDesc.Trim

    '    '// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
    '    Dim NewTransaction As String

    '    NewTransaction = "INSERT INTO GEN_TEMP VALUES ('" & _
    '                     Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
    '                     cTranID & "," & _
    '                     Val(AccID) & ",'" & _
    '                     DocNo.Trim & "','" & _
    '                     StrConv(gblAccHead.Trim, VbStrConv.ProperCase) & "','" & _
    '                     StrConv(Trans_Acc_Name.Trim, VbStrConv.ProperCase) & "','" & _
    '                     TransDesc.Trim.ToString & "'," & _
    '                     "0,'" & _
    '                     TransType & "',0.00," & _
    '                     Trans_Amount & "," & _
    '                     Val(SortID) & ",'" & _
    '                     FinancialYear & "',0)"

    '    ProcessTransaction(NewTransaction)
    '    NewTransaction = Nothing
    'End Sub

End Class