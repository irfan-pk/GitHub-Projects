Imports System.Data.SqlClient

Public Class FiscalYearCreate
    Dim cmd As SqlCommand = Nothing
    Dim FiscalSqlAdapter As New SqlDataAdapter()
    Dim Pos, NewSeq, SortId, AccId, cTranId As Integer
    Dim strDate, CloseDate As Date
    Dim OpeningBal As Double
    Dim EditString, AccLink As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub FiscalYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("Access Denied. You are not authorize.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub LoadDB()
        Try
            FiscalDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM FISCAL_YEAR ORDER BY FISCAL_YEAR_SEQ"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "FISCAL_YEAR", Connection)
            SqlDataAdapter.Fill(FiscalDataSet, "FISCAL_YEAR")
            FiscalBindingSource.DataSource = FiscalDataSet
            FiscalBindingSource.DataMember = "FISCAL_YEAR"
            dtpStart.DataBindings.Add("TEXT", FiscalBindingSource, "FISCAL_YEAR_START")
            dtpEnd.DataBindings.Add("TEXT", FiscalBindingSource, "FISCAL_YEAR_END")
            lblFiscal.DataBindings.Add("TEXT", FiscalBindingSource, "FISCAL_YEAR_PERIOD")
            lblStatus.DataBindings.Add("TEXT", FiscalBindingSource, "FISCAL_YEAR_STATUS")
            Addition = False
            Editing = False
            BindingNavigatorSaveItem.Enabled = False
            GroupBox1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            DataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click
        Editing = True
        Addition = False
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        EditString = DataGridView.Rows(DataGridView.CurrentRow.Index).Cells(0).Value.ToString
        GroupBox1.Enabled = True
        dtpStart.Focus()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        GroupBox1.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        dtpStart.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Are you sure to delete ? " & Space(2) & "(" & Trim(DataGridView.Rows(DataGridView.CurrentRow.Index).Cells(1).Value.ToString) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM FISCAL_YEAR WHERE FISCAL_YEAR_PERIOD = '" & Trim(DataGridView.Rows(DataGridView.CurrentRow.Index).Cells(1).Value.ToString) & "' AND FISCAL_YEAR_STATUS <> 'CLOSED'"
            Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
            DataGridView.Update()
        Else
            'skip
            DataGridView.RefreshEdit()
            Call RefreshDB()
        End If
    End Sub

    Private Sub RefreshDB()
        Try
            FiscalDataSet.Clear()
            SqlDataAdapter.Dispose()
            DataGridView.Refresh()
            Dim QueryText As String = "SELECT * FROM FISCAL_YEAR ORDER BY FISCAL_YEAR_SEQ"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "FISCAL_YEAR", Connection)
            SqlDataAdapter.Fill(FiscalDataSet, "FISCAL_YEAR")
            FiscalBindingSource.DataSource = FiscalDataSet
            FiscalBindingSource.DataMember = "FISCAL_YEAR"
            DataGridView.RefreshEdit()
            DataGridView.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        NewSeq = GenerateMax_ID("FISCAL_YEAR", "FISCAL_YEAR_SEQ")
        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call ProcessTransaction("UPDATE FISCAL_YEAR SET FISCAL_YEAR_START = '" & Format(DateTime.Parse(dtpStart.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                                                           " FISCAL_YEAR_END = '" & Format(DateTime.Parse(dtpEnd.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                                                           " FISCAL_YEAR_PERIOD = '" & lblFiscal.Text.Trim.ToUpper & "'" & _
                                                           " WHERE FISCAL_YEAR_SEQ = '" & Val(EditString) & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call ProcessTransaction("INSERT INTO FISCAL_YEAR VALUES (" & NewSeq & ",'" & _
                                                           lblFiscal.Text.ToUpper.Trim & "','" & _
                                                           Format(DateTime.Parse(dtpStart.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','" & _
                                                           Format(DateTime.Parse(dtpEnd.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','OPENED')")


        BindingNavigatorSaveItem.Enabled = False
        GroupBox1.Enabled = False
        Editing = False
        Addition = False
        BindingNavigatorEditItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Close"
        Call RefreshDB()
    End Sub

    Private Sub BindingNavigatorCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCloseItem.Click
        If BindingNavigatorCloseItem.Text = "&Close" Then
            Connection.Close()
            FiscalBindingSource.Dispose()
            Me.Close()
        Else
            BindingNavigatorCloseItem.Text = "&Cancel"
            BindingNavigatorSaveItem.Enabled = False
            GroupBox1.Enabled = False
            BindingNavigatorCloseItem.Text = "&Close"
            Call RefreshDB()
            Addition = False
            Editing = False
        End If
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        Fyear_Date = Format(Date.Parse(dtpStart.Value.ToString), "dd/MMM/yyyy")
        If (Month(Fyear_Date) < 7) Then
            lblFiscal.Text = ("FY - " & Year(Fyear_Date))
        Else
            lblFiscal.Text = ("FY - " & Year(Fyear_Date) + 1)
        End If
    End Sub

    Private Sub BindingNavigatorCloseCycleItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCloseCycleItem.Click
        Execute_DatabaseTable_Query(FiscalSqlAdapter, "select count(fiscal_year_status) as F_Opened from fiscal_year where fiscal_year_status = 'OPENED'", Connection)
        Dim cCheck As Integer = 0
        Dim Reader As SqlDataReader = FiscalSqlAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                cCheck = Convert.ToInt32(Reader.Item("f_opened").ToString)
            End While
        End If
        If cCheck >= 2 Then
            FiscalPeriodSelect.ShowDialog(Me)
        Else
            MessageBox.Show("At least Two opened periods required, contact administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If fClose = String.Empty Or fOpen = String.Empty Then
            Exit Sub
        End If

        If Val(Mid(fClose.Trim, 6, 4)) > Val(Mid(fOpen.Trim, 6, 4)) Then
            MessageBox.Show("Invalid Selection of Fiscal Period.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim CheckDate As String = "select * from fiscal_year where fiscal_year_period = '" & fClose.Trim & "' and fiscal_year_status = 'OPENED' and fiscal_year_end < CONVERT(DATETIME,'" & Format(DateTime.Parse(Now.Date.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)"
        Execute_DatabaseTable_Query(SqlDataAdapter, CheckDate, Connection)
        Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Checker.HasRows Then
            While Checker.Read
                CloseDate = Checker.Item("fiscal_year_end").ToString
            End While
        Else
            MessageBox.Show("Fiscal period cannot be close before date," & vbCrLf & "or already closed, contact administrator.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("This will close current fiscal period and balance brought forward for next fiscal period," & vbCrLf & "this process cannot be undone. (Yes/No)", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = System.Windows.Forms.DialogResult.Yes Then
            'Procedure for Make changes
            Me.Cursor = Cursors.WaitCursor
            SortId = 0
            Call Finalize_Fiscal_Period()
            ProcessTransaction("update fiscal_year set fiscal_year_status = 'CLOSED' where fiscal_year_period = '" & fClose & "'")
            ProcessTransaction("update accounts set acc_f_year = '" & FinancialYear.Trim & "'")
            Me.Cursor = Cursors.Default
            MessageBox.Show(Me, "Fiscal year close and balances broght forward successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            Exit Sub
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Finalize_Fiscal_Period()
        Try
            ProcessTransaction("select * into lab_pro.dbo.Accounts_Close_" & Format(DateTime.Parse(CloseDate), "ddMMyyyy") & " from LAB_PRO.dbo.Accounts")
            Execute_DatabaseTable_Query(SqlDataAdapter, "select * from fiscal_year where fiscal_year_period = '" & fOpen.Trim & "'", Connection)
            Dim GetDate As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GetDate.HasRows Then
                While GetDate.Read
                    strDate = GetDate.Item("fiscal_year_start").ToString
                    FinancialYear = GetDate.Item("fiscal_year_period").ToString
                End While
            Else
                Exit Sub
            End If
            Dim SelectAccounts As String = "select * from accounts order by acc_no"
            Dim AccountsAdapter As New SqlDataAdapter
            Execute_DatabaseTable_Query(AccountsAdapter, SelectAccounts, Connection)
            Dim AccountsReader As SqlDataReader = AccountsAdapter.SelectCommand.ExecuteReader
            If AccountsReader.HasRows Then
                While AccountsReader.Read
                    If Val(AccountsReader.Item("acc_balance").ToString) > 0 Then
                        If AccountsReader.Item("acc_type").ToString = "DR" Then
                            Call DebitTransaction(AccountsReader.Item("acc_name").ToString, AccountsReader.Item("acc_type").ToString, AccountsReader.Item("acc_balance").ToString, "bal brought forward, ", "B/F - 001")
                        Else
                            Call CreditTransaction(AccountsReader.Item("acc_name").ToString, AccountsReader.Item("acc_type").ToString, AccountsReader.Item("acc_balance").ToString, "bal brought forward, ", "B/F - 001")
                        End If
                        ProcessTransaction("update accounts set acc_debit = 0, acc_credit = 0, acc_balance = 0 " & "where acc_name = '" & AccountsReader.Item("acc_name").ToString & "'")
                    End If
                End While
                ProcessTransaction("update accounts set acc_debit = 0, acc_credit = 0, acc_balance = 0")
            End If
            'Update Ledger Entries
            AccountLedgers.Update_Balances()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DebitTransaction(ByVal Trans_Acc_Name As String, ByVal TransType As String, ByVal Trans_Amount As Double, ByVal TransDesc As String, ByVal DocNo As String)
        SortId += 1
        AccId = Get_Account_ID(Trans_Acc_Name.Trim.ToString)
        cTranId = GenerateMax_ID("GENERAL_JOURNAL", "GEN_TRAN_ID")
        TransDesc = Trans_Acc_Name & Space(1) & TransDesc.Trim
        '// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String
        NewTransaction = "INSERT INTO GENERAL_JOURNAL VALUES ('" & _
                         Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                         cTranId & "," & _
                         Val(AccId) & ",'" & _
                         DocNo.Trim & "','" & _
                         StrConv(gblAccHead.Trim, VbStrConv.ProperCase) & "','" & _
                         StrConv(Trans_Acc_Name.Trim, VbStrConv.ProperCase) & "','" & _
                         TransDesc.Trim.ToString & "'," & _
                         "0,'" & _
                         TransType & "'," & _
                         Trans_Amount & ",0.00," & _
                         Val(SortId) & ",'" & _
                         FinancialYear & "',0)"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
    End Sub

    Private Sub CreditTransaction(ByVal Trans_Acc_Name As String, ByVal TransType As String, ByVal Trans_Amount As Double, ByVal TransDesc As String, ByVal DocNo As String)
        SortId += 1
        AccId = Get_Account_ID(Trans_Acc_Name.Trim.ToString)
        cTranId = GenerateMax_ID("GENERAL_JOURNAL", "GEN_TRAN_ID")
        TransDesc = Trans_Acc_Name & Space(1) & TransDesc.Trim
        '// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String
        NewTransaction = "INSERT INTO GENERAL_JOURNAL VALUES ('" & _
                         Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                         cTranId & "," & _
                         Val(AccId) & ",'" & _
                         DocNo.Trim & "','" & _
                         StrConv(gblAccHead.Trim, VbStrConv.ProperCase) & "','" & _
                         StrConv(Trans_Acc_Name.Trim, VbStrConv.ProperCase) & "','" & _
                         TransDesc.Trim.ToString & "'," & _
                         "0,'" & _
                         TransType & "',0.00," & _
                         Trans_Amount & "," & _
                         Val(SortId) & ",'" & _
                         FinancialYear & "',0)"
        ProcessTransaction(NewTransaction)
        NewTransaction = Nothing
    End Sub
End Class