Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D

Public Class PettyLedgers

#Region "GLOBAL VARIABLES"
    Dim Acc_ID, SortID, TranID As Integer
    Dim TransDate As Date = DateTime.Now
    Dim Ledg_Balance, DrCr_Type As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Execute_Trans_Reader As SqlDataReader
    Dim OpnCr, OpnDr, Ledg_BF, New_Balance As Double
    Dim LedgerAccAdp As New SqlDataAdapter()
    Dim LedgerAccSet As New DataSet()
#End Region

#Region "FORM EVENTS"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmLedgers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        Me.Text = My.Application.Info.ProductName
        dtpFrom.Value = DateAdd(DateInterval.Day, -1, Date.Now)
        dtpTo.Value = Date.Now
        TransDate = dtpFrom.Value
        toDate = dtpTo.Value
        fromDate = Now
        toDate = Now
        Connection.Close()

    End Sub
#End Region

#Region "VIEW LEDGERS BALANCES"

    Private Sub Show_Journal_Transactions()
        OpnDr = 0
        OpnCr = 0
        lblCredit.Text = 0
        lblDebit.Text = 0

        Fyear_Date = Format(Date.Parse(dtpFrom.Value.ToString.Trim), "dd/MMM/yyyy")
        If (Month(Fyear_Date) < 7) Then
            FinancialYear = ("FY - " & Year(Fyear_Date))
        Else
            FinancialYear = ("FY - " & Year(Fyear_Date) + 1)
        End If

        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "SELECT * FROM PETTY_LEDGERS WHERE LEDG_DATE < CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") AND LEDG_F_YEAR ='" & FinancialYear & "' ORDER BY LEDG_DATE, LEDG_TRAN_ID", "LEDGERS", Connection)
        Execute_Trans_Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            OpnDr = OpnDr + Convert.ToDecimal(Execute_Trans_Reader.Item("LEDG_DEBIT")) + "0.00"
            OpnCr = OpnCr + Convert.ToDecimal(Execute_Trans_Reader.Item("LEDG_CREDIT")) + "0.00"
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        If OpnDr = 0 Then OpnDr = "0.00"
        If OpnCr = 0 Then OpnCr = "0.00"

        lblDebit.Text = Format(Val(lblDebit.Text), "0.00")
        lblCredit.Text = Format(Val(lblCredit.Text), "0.00")

        If OpnDr > OpnCr Then
            lblOpnDebit.Visible = True
            lblOpnDebit.Text = Format(Val(OpnDr) - Val(OpnCr), "0.00")
            lblDebit.Text = Format(Val(lblDebit.Text) + Val(lblOpnDebit.Text), "0.00")
            lblOpnCr.Visible = False
            lblOpnCredit.Visible = False
        Else
            lblOpnCr.Visible = True
            lblOpnCredit.Visible = True
            lblOpnCredit.Text = Format(Val(OpnCr) - Val(OpnDr), "0.00")
            lblCredit.Text = Format(Val(lblCredit.Text) + Val(lblOpnCredit.Text), "0.00")
            lblOpnDebit.Visible = False
        End If
        Me.MyDataSet.Clear()
        Me.LedgerGrid.DataSource = Nothing
        Execute_DatabaseTable_Query(SqlDataAdapter, "SELECT * FROM PETTY_LEDGERS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTo.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") AND (LEDG_DEBIT > 0) ORDER BY LEDG_DATE, LEDG_TRAN_ID", Connection)
        Execute_Trans_Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            lblDebit.Text = Val(lblDebit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("LEDG_DEBIT"))
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        Execute_DatabaseTable_Query(SqlDataAdapter, "SELECT * FROM PETTY_LEDGERS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTo.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") AND (LEDG_CREDIT > 0) ORDER BY LEDG_DATE, LEDG_TRAN_ID", Connection)
        Execute_Trans_Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            lblCredit.Text = Val(lblCredit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("LEDG_CREDIT"))
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        ExecuteSqlQuery(SqlDataAdapter, Me.MyDataSet, "SELECT * FROM PETTY_LEDGERS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTo.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") ORDER BY LEDG_DATE, LEDG_TRAN_ID", "PETTY_LEDGERS", Connection)
        Me.LedgerGrid.DataSource = Me.MyDataSet
        Me.LedgerGrid.DataMember = "PETTY_LEDGERS"

        txtCloCr.Text = 0
        txtCloDr.Text = 0

        If Val(lblDebit.Text) > Val(lblCredit.Text) Then
            txtCloCr.Visible = True
            lblClosing.Visible = True
            txtCloDr.Visible = False
            txtCloCr.Text = Format(Val(lblDebit.Text) - Val(lblCredit.Text), "0.00")
        Else
            lblClosing.Visible = True
            txtCloDr.Visible = True
            txtCloCr.Visible = False
            txtCloDr.Text = Format(Val(lblCredit.Text) - Val(lblDebit.Text), "0.00")
        End If

    End Sub

    Private Sub cmdGetTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetTrans.Click
        If Len(Me.txtAccount.Text) > 0 Then
            Acc_ID = Get_P_Account_ID(Me.txtAccount.Text.Trim)
            Call Update_Balances()
            lblAccTitle.Text = Me.txtAccount.Text.Trim & " Ledger"
        Else
            lblOpnCr.Visible = False
            lblOpnCredit.Visible = False
            lblOpnDebit.Visible = False
            txtCloCr.Visible = False
            txtCloDr.Visible = False
            lblClosing.Visible = False
            MsgBox("Please Select Account Head for View Ledger.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
        Call Show_Journal_Transactions()
    End Sub

#End Region

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged
        If dtpFrom.Value > DateAdd(DateInterval.Day, -1, Date.Now) Then
            MsgBox("From Date should be less than current date.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            dtpFrom.Value = DateAdd(DateInterval.Day, -1, Date.Now)
        End If
    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged
        If dtpTo.Value < dtpFrom.Value Then
            MsgBox("End Date should be greater than ('" & dtpFrom.Value.ToShortDateString & "')", MsgBoxStyle.Information, My.Application.Info.ProductName)
            dtpTo.Value = Date.Now
        End If
    End Sub

    Private Sub frmLedgers_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then Me.Text = "Account Ledger" Else Me.Text = My.Application.Info.ProductName
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gblReportOption = "LEDGERS"
        fromDate = DateTime.Parse(dtpFrom.Value.ToShortDateString)
        toDate = DateTime.Parse(dtpTo.Value.ToShortDateString)
        gblReportName = ".\" & "Reports\Ledger.rpt"
        If lblOpnDebit.Visible = True Then intOpnDr = Val(lblOpnDebit.Text) Else intOpnDr = 0
        If lblOpnCredit.Visible = True Then intOpnCr = Val(lblOpnCredit.Text) Else intOpnCr = 0
        gblFind = Acc_ID
        AccountReports.MdiParent = MainForm
        AccountReports.Show()
    End Sub

#Region "Update_Ledger"

    Private Sub Update_Balances()
        Fyear_Date = Format(Date.Parse(dtpFrom.Value.ToString.Trim), "dd/MMM/yyyy")
        If (Month(Fyear_Date) < 7) Then
            FinancialYear = ("FY - " & Year(Fyear_Date))
        Else
            FinancialYear = ("FY - " & Year(Fyear_Date) + 1)
        End If
        SortID = GenerateMax_ID("PETTY_LEDGERS", "LEDG_SORT")
        TranID = GenerateMax_ID("PETTY_LEDGERS", "LEDG_TRAN_ID")

        Dim SelectQuery As String = "SELECT * FROM PETTY_JOURNAL WHERE P_STATUS = 0 AND P_YEAR = '" & FinancialYear & "' ORDER BY P_TRAN_DATE, P_TRAN_ID, P_ACC_TYPE DESC"
        'Dim SelectQuery As String = "SELECT * FROM GENERAL_JOURNAL WHERE GEN_STATUS = 0 ORDER BY GEN_DATE, GEN_TRAN_ID, GEN_ACC_TYPE DESC"
        Execute_DatabaseTable_Query(TransDataAdapter, SelectQuery, Connection)
        Dim DataReader As SqlDataReader = TransDataAdapter.SelectCommand.ExecuteReader
        If DataReader.HasRows Then
            Dim statusForm As New Status()
            statusForm.Show("Please wait updating ledger balances...")
            While DataReader.Read
                TranID = GenerateMax_ID("PETTY_LEDGERS", "LEDG_TRAN_ID")
                'Pick balance from account head for ledger balance
                Dim Get_Balance As String = "Select * from Petty_Accounts where P_ACC_NAME = '" & DataReader.Item("P_Sub_Acc").ToString.Trim & "'"
                Execute_DatabaseTable_Query(SqlDataAdapter, Get_Balance, Connection)
                Dim Bal_Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Bal_Reader.HasRows Then
                    While Bal_Reader.Read
                        Ledg_BF = Val(Bal_Reader.Item("P_Acc_Balance").ToString)
                        DrCr_Type = Bal_Reader.Item("P_Acc_Type").ToString.Trim
                    End While
                Else
                    MsgBox("Plz check account head.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName)
                    Exit Sub
                End If

                'Transfer balance into ledger bal field after update
                If DrCr_Type = "DR" Then New_Balance = Ledg_BF + Val(DataReader.Item("P_DEBIT")) - Val(DataReader.Item("P_CREDIT"))
                If DrCr_Type = "CR" Then New_Balance = Ledg_BF + Val(DataReader.Item("P_CREDIT")) - Val(DataReader.Item("P_DEBIT"))

                'Things to do here for update ledger postings
                Dim LedgerTrans As String = "INSERT INTO PETTY_LEDGERS VALUES('" & _
                                            DataReader.Item("P_Tran_Date") & "'," & _
                                            TranID & "," & _
                                            DataReader.Item("P_Acc_Id") & ",'" & _
                                            DataReader.Item("P_Voucher_No").ToString.Trim & "','" & _
                                            DataReader.Item("P_Acc_Head").ToString.Trim & "','" & _
                                            DataReader.Item("P_Sub_Acc").ToString.Trim & "','" & _
                                            DataReader.Item("P_Narration").ToString.Trim & Space(1) & ", Ref # " & DataReader.Item("P_Tran_Id").ToString.Trim & "','" & _
                                            DataReader.Item("P_Acc_Type").ToString.Trim & "'," & _
                                            DataReader.Item("P_Debit") & "," & _
                                            DataReader.Item("P_Credit") & "," & _
                                            New_Balance & "," & _
                                            SortID & ",'" & _
                                            DataReader.Item("P_Year").ToString.Trim & "')"

                Execute_DatabaseTable_Query(LedgerDataAdapter, LedgerTrans, Connection)

                'Update Balances of concerned account in accounts table but wrong balance calculating
                Ledg_Balance = "UPDATE PETTY_ACCOUNTS SET P_ACC_BALANCE = " & New_Balance & "," & _
                               "P_ACC_DEBIT = P_ACC_DEBIT + " & DataReader.Item("P_DEBIT") & "," & _
                               "P_ACC_CREDIT = P_ACC_CREDIT + " & DataReader.Item("P_CREDIT") & " WHERE P_ACC_NO = " & DataReader.Item("P_ACC_ID")
                Execute_DatabaseTable_Query(SqlDataAdapter, Ledg_Balance, Connection)
                Dim LP_Update As String = "UPDATE PETTY_JOURNAL SET P_LP = '" & TranID & "' WHERE P_ACC_ID = " & DataReader.Item("P_Acc_Id") & " AND P_TRAN_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(DataReader.Item("P_TRAN_DATE").ToString), "yyyy-MM-dd") & " 00:00:00', 102)"
                Execute_DatabaseTable_Query(SqlDataAdapter, LP_Update, Connection)
                New_Balance = 0
                Ledg_BF = 0
                SortID += 1
            End While
            If Not DataReader Is Nothing Then DataReader.Close()
            statusForm.Close()
            Dim Finalize_Entries As String = "UPDATE PETTY_JOURNAL SET P_STATUS = 1 WHERE P_STATUS = 0"
            Execute_DatabaseTable_Query(SqlDataAdapter, Finalize_Entries, Connection)
            'Else
            '    MsgBox("There is no any Transaction for posting, please check General Journal.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, My.Application.Info.ProductName)
        End If
    End Sub

#End Region

    Private Sub txtAcc_Id_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcc_Id.KeyUp
        If e.KeyCode = Keys.F2 Then
            PettyAccountList.ShowDialog(Me)
            If Len(gblAccID.Trim) > 0 Then
                txtAcc_Id.Text = gblAccID
                txtAccount.Text = gblAccName
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtAccount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccount.KeyUp
        If e.KeyCode = Keys.F2 Then
            PettyAccountList.ShowDialog(Me)
            If Len(gblAccID.Trim) > 0 Then
                txtAcc_Id.Text = gblAccID
                txtAccount.Text = gblAccName
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdReorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReorder.Click
        If txtAcc_Id.Text = String.Empty Or Val(txtAcc_Id.Text.Trim) = 0 Then
            MsgBox("Plz select account title before update.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        End If
        Dim SelectAccount As String = "select * from lab_pro.dbo.accounts where acc_no = " & Val(txtAcc_Id.Text.Trim)
        Execute_DatabaseTable_Query(SqlDataAdapter, SelectAccount, Connection)
        Dim Selecter As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Selecter.HasRows Then
            While Selecter.Read
                DrCr_Type = Selecter.Item("ACC_TYPE").ToString.Trim
            End While
            If Selecter Is Nothing Then Selecter.Close()
        Else
            MsgBox("there is no data for update.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        End If
        Dim UpdateBal As Double = 0
        If DrCr_Type = "DR" Then UpdateBal = OpnDr
        If DrCr_Type = "CR" Then UpdateBal = OpnCr
        Dim UpdateRuningBalance As String = String.Empty
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "SELECT * FROM PETTY_LEDGERS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") AND LEDG_F_YEAR ='" & FinancialYear & "' ORDER BY LEDG_DATE, LEDG_TRAN_ID", "PETTY_LEDGERS", Connection)
        Dim Trans_Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Trans_Reader.HasRows Then
            While Trans_Reader.Read
                If DrCr_Type = "DR" Then UpdateBal = UpdateBal + Convert.ToInt32(Trans_Reader.Item("ledg_debit")) - Convert.ToInt32(Trans_Reader.Item("ledg_credit"))
                If DrCr_Type = "CR" Then UpdateBal = UpdateBal + Convert.ToInt32(Trans_Reader.Item("ledg_credit")) - Convert.ToInt32(Trans_Reader.Item("ledg_debit"))
                Dim MyQuery As String = "update petty_ledgers set ledg_balance = " & UpdateBal & _
                                        " where LEDG_DATE = CONVERT(DATETIME,'" & Trans_Reader.Item("ledg_date") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Trans_Reader.Item("ledg_acc_id") & ")" & _
                                        " AND (LEDG_TRAN_ID = " & Trans_Reader.Item("ledg_tran_id") & ") AND (LEDG_F_YEAR ='" & FinancialYear & "')"
                Execute_DatabaseTable_Query(SqlDataAdapter, MyQuery, Connection)
            End While
            If Not Trans_Reader Is Nothing Then Trans_Reader.Close()
            Call Show_Journal_Transactions()
        End If
    End Sub
End Class