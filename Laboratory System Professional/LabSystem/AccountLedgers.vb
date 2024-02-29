Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D

Public Class AccountLedgers

#Region "GLOBAL VARIABLES"
    Dim Acc_ID, SortID, TranID As Integer
    Dim TransDate As Date = DateTime.Now
    Dim Ledg_Balance, DrCr_Type As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Execute_Trans_Reader As SqlDataReader
    Dim OpnCr, OpnDr, Ledg_BF, New_Balance, Final_Cr, Final_Dr, wAcc_ID As Decimal
    Dim LedgerAccAdp As New SqlDataAdapter()
    Dim ReodrderAdapter As New SqlDataAdapter()
    Dim StatusAdapter As New SqlDataAdapter()
    Dim OpnBalAdapter As New SqlDataAdapter()
    Dim CloBalAdapter As New SqlDataAdapter()
    Dim AccInfoAdapter As New SqlDataAdapter()
    Dim DataGridAdapter As New SqlDataAdapter()
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
        cmdPrint.Enabled = False
        cmdDelete.Enabled = False
        cmdReorder.Enabled = False
    End Sub
#End Region

#Region "VIEW LEDGERS BALANCES"

    Private Sub Show_Journal_Transactions()
        OpnDr = 0
        OpnCr = 0
        lblCredit.Text = 0
        lblDebit.Text = 0
        Dim FinalCloBal As Double = 0
        lblOpnDebit.Text = "0.00"
        lblOpnCredit.Text = "0.00"
        
        ExecuteSqlQuery(OpnBalAdapter, SqlDataSet, "SELECT * FROM LEDGERS WHERE LEDG_DATE < CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") AND LEDG_F_YEAR ='" & FinancialYear & "' ORDER BY LEDG_DATE, LEDG_TRAN_ID", "LEDGERS", Connection)
        Execute_Trans_Reader = OpnBalAdapter.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            lblOpnDebit.Text = Format(Val(lblOpnDebit.Text), "0.00") + Convert.ToDecimal(Execute_Trans_Reader.Item("LEDG_DEBIT")) + "0.00"
            lblOpnCredit.Text = Format(Val(lblOpnCredit.Text), "0.00") + Convert.ToDecimal(Execute_Trans_Reader.Item("LEDG_CREDIT")) + "0.00"
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        lblDebit.Text = Format(Val(lblDebit.Text), "0.00")
        lblCredit.Text = Format(Val(lblCredit.Text), "0.00")
        
        If Val(lblOpnDebit.Text) > Val(lblOpnCredit.Text) Then
            lblOpnDebit.Visible = True
            lblOpnDebit.Text = Format(Val(lblOpnDebit.Text) - Val(lblOpnCredit.Text), "0.00")
            lblOpnBal.Visible = True
            lblOpnCredit.Visible = False
        Else
            lblOpnBal.Visible = True
            lblOpnCredit.Visible = True
            lblOpnCredit.Text = Format(Val(lblOpnCredit.Text) - Val(lblOpnDebit.Text), "0.00")
            lblOpnDebit.Visible = False
        End If
        Me.MyDataSet.Clear()
        Me.LedgerGrid.DataSource = Nothing
        Execute_DatabaseTable_Query(CloBalAdapter, "SELECT * FROM LEDGERS WHERE LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTo.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_F_YEAR = '" & FinancialYear & "') AND (LEDG_ACC_ID = " & Acc_ID & ") ORDER BY LEDG_DATE, LEDG_TRAN_ID", Connection)
        Execute_Trans_Reader = CloBalAdapter.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            lblDebit.Text = Format(Val(lblDebit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("LEDG_DEBIT")), "0.00")
            lblCredit.Text = Format(Val(lblCredit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("LEDG_CREDIT")), "0.00")
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        ExecuteSqlQuery(DataGridAdapter, Me.MyDataSet, "SELECT * FROM LEDGERS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTo.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") ORDER BY LEDG_DATE, LEDG_TRAN_ID", "LEDGERS", Connection)
        Me.LedgerGrid.DataSource = Me.MyDataSet
        Me.LedgerGrid.DataMember = "LEDGERS"

        txtCloCr.Text = "0.00"
        txtCloDr.Text = "0.00"

        If Val(lblDebit.Text) > Val(lblCredit.Text) Then
            txtCloCr.Visible = True
            lblClosing.Visible = True
            txtCloDr.Visible = False
            txtCloCr.Text = Format(Val(lblDebit.Text) - Val(lblCredit.Text), "0.00")
        End If
        If Val(lblCredit.Text) > Val(lblDebit.Text) Then
            lblClosing.Visible = True
            txtCloDr.Visible = True
            txtCloCr.Visible = False
            txtCloDr.Text = Format(Val(lblCredit.Text) - Val(lblDebit.Text), "0.00")
        End If

    End Sub

    Private Sub cmdShowLedgers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowLedgers.Click
        Dim statusForm As New Status()
        If Len(Me.txtAccount.Text) > 0 Then
            Acc_ID = Get_Account_ID(Me.txtAccount.Text.Trim)
            lblAccTitle.Text = Me.txtAccount.Text.Trim & " Ledger"
            cmdPrint.Enabled = True
            cmdReorder.Enabled = True
            cmdDelete.Enabled = True
            Me.Cursor = Cursors.WaitCursor
            statusForm.Show("Please wait updating balances...")
        Else
            lblOpnBal.Visible = False
            lblOpnCredit.Visible = False
            lblOpnDebit.Visible = False
            txtCloCr.Visible = False
            txtCloDr.Visible = False
            lblClosing.Visible = False
            MsgBox("Please Select Account Head for View Ledger.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
        cmdReorder_Click(sender, e)
        Me.Cursor = Cursors.Default
        Call Show_Journal_Transactions()
        statusForm.Close()
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

    Public Sub Update_Balances()
        SortID = GenerateMax_ID("LEDGERS", "LEDG_SORT")
        TranID = GenerateMax_ID("LEDGERS", "LEDG_TRAN_ID")

        Dim SelectQuery As String = "SELECT * FROM GENERAL_JOURNAL WHERE GEN_STATUS = 0 AND GEN_F_YEAR = '" & FinancialYear & "' ORDER BY GEN_DATE, GEN_TRAN_ID, GEN_SORT"

        Execute_DatabaseTable_Query(TransDataAdapter, SelectQuery, Connection)
        Dim DataReader As SqlDataReader = TransDataAdapter.SelectCommand.ExecuteReader
        If DataReader.HasRows Then
            Dim statusForm As New Status()
            statusForm.Show("Please wait updating ledger balances...")
            While DataReader.Read
                TranID = GenerateMax_ID("LEDGERS", "LEDG_TRAN_ID")
                'Pick balance from account head for ledger balance
                Call GetAccountInfo(DataReader.Item("Gen_Acc_Id").ToString.Trim)
                'Transfer balance into ledger bal field after update
                If DrCr_Type = "DR" Then New_Balance = Ledg_BF + Val(DataReader.Item("GEN_DEBIT")) - Val(DataReader.Item("GEN_CREDIT"))
                If DrCr_Type = "CR" Then New_Balance = Ledg_BF + Val(DataReader.Item("GEN_CREDIT")) - Val(DataReader.Item("GEN_DEBIT"))

                'Things to do here for update ledger postings
                Dim LedgerTrans As String = "INSERT INTO LEDGERS VALUES('" & _
                                            DataReader.Item("Gen_Date") & "'," & _
                                            TranID & "," & _
                                            DataReader.Item("Gen_Acc_Id") & ",'" & _
                                            DataReader.Item("Gen_Voucher_No").ToString.Trim & "','" & _
                                            DataReader.Item("Gen_Acc_Head").ToString.Trim & "','" & _
                                            DataReader.Item("Gen_Sub_Acc").ToString.Trim & "','" & _
                                            DataReader.Item("Gen_Narration").ToString.Trim & Space(1) & ", Gen. Ref # " & DataReader.Item("Gen_Tran_Id").ToString.Trim & "','" & _
                                            DataReader.Item("Gen_Acc_Type").ToString.Trim & "'," & _
                                            DataReader.Item("Gen_Debit") & "," & _
                                            DataReader.Item("Gen_Credit") & "," & _
                                            New_Balance & "," & _
                                            SortID & ",'" & _
                                            DataReader.Item("Gen_F_Year").ToString.Trim & "')"

                ProcessTransaction(LedgerTrans)

                'Update Balances of concerned account in accounts table but wrong balance calculating
                Ledg_Balance = "UPDATE ACCOUNTS SET ACC_BALANCE = " & New_Balance & "," & _
                               "ACC_DEBIT = ACC_DEBIT + " & DataReader.Item("GEN_DEBIT") & "," & _
                               "ACC_CREDIT = ACC_CREDIT + " & DataReader.Item("GEN_CREDIT") & "," & _
                               "ACC_UPDATE = '" & DataReader.Item("GEN_DATE") & "' " & _
                               "WHERE ACC_NO = " & DataReader.Item("GEN_ACC_ID")

                Call FinalTransactionStatus(Ledg_Balance)
                'To update ledger posting reference
                Dim LP_Update As String = "UPDATE GENERAL_JOURNAL SET GEN_LP = '" & TranID & "' WHERE GEN_ACC_ID = " & DataReader.Item("Gen_Acc_Id") & " AND GEN_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(DataReader.Item("GEN_DATE").ToString), "yyyy-MM-dd") & " 00:00:00', 102)"
                Call FinalTransactionStatus(LP_Update)
                New_Balance = 0
                Ledg_BF = 0
                SortID += 1
            End While
            If Not DataReader Is Nothing Then DataReader.Close()
            statusForm.Close()
            'To update general transaction status
            Dim Finalize_Entries As String = "UPDATE GENERAL_JOURNAL SET GEN_STATUS = 1 WHERE GEN_STATUS = 0"
            Call FinalTransactionStatus(Finalize_Entries)
            Call Show_Journal_Transactions()
        End If
    End Sub

#End Region

    Private Sub txtAcc_Id_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcc_Id.KeyDown
        If e.KeyCode = Keys.Enter Then
            wAcc_ID = Val(txtAcc_Id.Text)
            If wAcc_ID = 0 Or wAcc_ID.ToString = String.Empty Then Exit Sub
            Call Get_Account_Parameters(wAcc_ID)
            txtAccount.Text = gblAccName
            If wAcc_ID <> gblAccID Then
                cmdPrint.Enabled = False
                cmdReorder.Enabled = False
                cmdDelete.Enabled = False
            End If
            cmdShowLedgers.Focus()
        End If
    End Sub

    Private Sub txtAcc_Id_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcc_Id.KeyUp
        If e.KeyCode = Keys.F2 Then
            wAcc_ID = Val(txtAcc_Id.Text)
            AccountLists.ShowDialog(Me)
            If Len(gblAccID.Trim) > 0 Then
                txtAcc_Id.Text = gblAccID
                txtAccount.Text = gblAccName
                If wAcc_ID <> gblAccID Then
                    cmdPrint.Enabled = False
                    cmdReorder.Enabled = False
                    cmdDelete.Enabled = False
                End If
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtAccount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccount.KeyUp
        If e.KeyCode = Keys.F2 Then
            AccountLists.ShowDialog(Me)
            If Len(gblAccID.Trim) > 0 Then
                txtAcc_Id.Text = gblAccID
                txtAccount.Text = gblAccName
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub

    Public Sub cmdReorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReorder.Click
        If txtAcc_Id.Text = String.Empty Or Val(txtAcc_Id.Text.Trim) = 0 Then
            MsgBox("Plz select account head before update.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
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
        Me.Cursor = Cursors.WaitCursor
        Dim UpdateBal As Double = 0
        Final_Dr = 0
        Final_Cr = 0
        
        Dim UpdateRuningBalance As String = String.Empty

        'ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "SELECT * FROM LEDGERS WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") AND LEDG_F_YEAR ='" & FinancialYear & "' ORDER BY LEDG_DATE, LEDG_TRAN_ID", "LEDGERS", Connection)
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "SELECT * FROM LEDGERS WHERE (LEDG_ACC_ID = " & Acc_ID & ") AND (LEDG_F_YEAR ='" & FinancialYear & "') ORDER BY LEDG_DATE, LEDG_TRAN_ID", "LEDGERS", Connection)
        Dim Trans_Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Trans_Reader.HasRows Then
            While Trans_Reader.Read
                If DrCr_Type = "DR" Then UpdateBal = UpdateBal + Convert.ToDecimal(Trans_Reader.Item("ledg_debit")) - Convert.ToDecimal(Trans_Reader.Item("ledg_credit"))
                If DrCr_Type = "CR" Then UpdateBal = UpdateBal + Convert.ToDecimal(Trans_Reader.Item("ledg_credit")) - Convert.ToDecimal(Trans_Reader.Item("ledg_debit"))

                Dim MyQuery As String = "update ledgers set ledg_balance = " & UpdateBal & _
                                        " where LEDG_DATE = CONVERT(DATETIME,'" & Trans_Reader.Item("ledg_date") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Trans_Reader.Item("ledg_acc_id") & ")" & _
                                        " AND (LEDG_TRAN_ID = " & Trans_Reader.Item("ledg_tran_id") & ") AND (LEDG_F_YEAR ='" & FinancialYear & "')"
                Call FinalTransactionStatus(MyQuery)

                Final_Dr = Final_Dr + Trans_Reader.Item("LEDG_DEBIT")
                Final_Cr = Final_Cr + Trans_Reader.Item("LEDG_CREDIT")

                Dim Final_Balance As String = "UPDATE ACCOUNTS SET ACC_BALANCE = " & UpdateBal & "," & _
                                              "ACC_UPDATE = '" & Trans_Reader.Item("LEDG_DATE") & "', " & _
                                              "ACC_DEBIT = " & Final_Dr & "," & _
                                              "ACC_CREDIT = " & Final_Cr & " " & _
                                              "WHERE ACC_NO = " & Trans_Reader.Item("LEDG_ACC_ID")
                Call ProcessTransaction(Final_Balance)
            End While
            Final_Cr = 0
            Final_Dr = 0
            UpdateBal = 0
            If Not Trans_Reader Is Nothing Then Trans_Reader.Close()
            Call Show_Journal_Transactions()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim delTranID As String = ""
        delTranID = Microsoft.VisualBasic.InputBox("Please Enter Transaction ID for deletion.", My.Application.Info.ProductName)
        If Len(delTranID) = 0 Or Val(delTranID) = 0 Then Exit Sub
        Execute_DatabaseTable_Query(SqlDataAdapter, "DELETE FROM LEDGERS WHERE LEDG_TRAN_ID =" & Val(delTranID), Connection)
        Call Show_Journal_Transactions()
    End Sub

    Private Sub GetAccountInfo(ByVal AccountID As String)
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from ACCOUNTS where ACC_NO = " & Val(AccountID.Trim))
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            If sqlConnection.State = ConnectionState.Broken Or sqlConnection.State = ConnectionState.Open Then sqlConnection.Close()
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    If reader.HasRows Then
                        While reader.Read
                            Ledg_BF = Val(reader.Item("Acc_Balance").ToString)
                            DrCr_Type = reader.Item("Acc_Type").ToString.Trim
                        End While
                    End If
                End Using
            End Using
            sqlConnection.Close()
        End Using
    End Sub

    Public Sub FinalTransactionStatus(ByVal UpdateQuery As String)
        Dim CommandText As String = UpdateQuery
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(CommandText, Conn)
            Try
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                Cmd.ExecuteNonQuery()
                Conn.Close()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End Using
    End Sub

End Class