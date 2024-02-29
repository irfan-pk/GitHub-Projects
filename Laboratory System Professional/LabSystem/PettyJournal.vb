Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D

Public Class PettyJournal

#Region "GLOBAL VARIABLES"
    Dim gGross, gNet, gCompl, gDisc, gDues, gDueRcv, gDelAdj, gDueAdj, gNarration, CrNarration, wGross, wNet, wCompl, wDisc, wDues, wDueRcv, wDelAdj, wDueAdj, CHK_STRING, F_Year As String
    Dim gDelNet As Double = 0, gDelDisc As Double = 0, gDelPaid As Double = 0, gDelDues As Double = 0, gComNet As Double = 0, gComDisc As Double = 0, gComPaid As Double = 0, gComDues As Double = 0, gblBalance As Double = 0
    Dim TransActive, TransRetrieve As Boolean
    Dim SortID, AccID, AccLinkCode As Integer
    Dim TransDate As Date = DateTime.Now
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Execute_Trans_Reader As SqlDataReader

#End Region
#Region "FORM DESIGN"
    Function GetGraphicsObject() As Graphics
        Dim bmp As Bitmap
        bmp = New Bitmap(Me.Width, Me.Height)
        Dim G As Graphics
        Me.BackgroundImage = bmp
        G = Graphics.FromImage(bmp)
        Return G
    End Function
#End Region
#Region "FORM EVENTS"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Execute_DatabaseTable_Query(SqlDataAdapter, "DELETE FROM PETTY_TEMP", Connection)
        Me.Close()
    End Sub

    Private Sub frmJournal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        ' If user pressed the Enter key
        If e.KeyCode = Keys.Enter And Not (e.Alt Or e.Control) Then
            e.SuppressKeyPress = True
            ' Make sure that the active control is a TextBox control
            ' Do not use the Enter key as tab when a button has the focus!
            If Me.ActiveControl.GetType Is GetType(TextBox) Or _
                    Me.ActiveControl.GetType Is GetType(ComboBox) Or _
                    Me.ActiveControl.GetType Is GetType(DateTimePicker) Then
                ' Use Shift + Enter to move backwords through the tab order
                If e.Shift Then
                    Me.ProcessTabKey(False)
                Else
                    Me.ProcessTabKey(True)
                End If
            End If
        End If
    End Sub

    Private Sub frmJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        Me.Text = My.Application.Info.ProductName
        Execute_DatabaseTable_Query(SqlDataAdapter, "select max(p_tran_date) as MaxDate from petty_journal", Connection)
        Dim GetMaxDate As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GetMaxDate.HasRows Then
            While GetMaxDate.Read
                dtpTransaction.Value = CDate(GetMaxDate.Item("maxdate").ToString)
            End While
        End If
        dtpTransaction.Value = DateAdd(DateInterval.Day, 1, dtpTransaction.Value)
        TransDate = dtpTransaction.Value
        Execute_DatabaseTable_Query(SqlDataAdapter, "DELETE FROM PETTY_TEMP", Connection)
        Connection.Close()
        txtTranID.Text = GenerateMax_ID("PETTY_JOURNAL", "P_TRAN_ID")
        Connection.Close()
        SortID = 0
        TransActive = False
        TransRetrieve = False
        Call Get_Balance(1)
    End Sub
#End Region

    Private Sub txtDebit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDebit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDebit.Text = "" Or Val(txtDebit.Text.Trim) = 0 Then Me.ProcessTabKey(False) : Exit Sub
            gNarration = StrConv(txtDescription.Text.Trim, VbStrConv.ProperCase)
            Call DebitTransaction(txtAccount.Text.Trim, "DR", Val(txtDebit.Text.Trim), gNarration.Trim, txtVoucher.Text.Trim.ToUpper)
        End If
    End Sub

    Private Sub txtCredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCredit.Text = "" Or Val(txtCredit.Text.Trim) = 0 Then Me.ProcessTabKey(False) : Exit Sub
            If Val(lblCashInHand.Text.Trim) > 0 Then _
            If Val(txtCredit.Text.Trim) > Val(lblCashInHand.Text.Trim) Then MsgBox("Amount is greater than cash in hand.", MsgBoxStyle.Critical, My.Application.Info.ProductName) : Me.ProcessTabKey(False) : Exit Sub
            gNarration = StrConv(txtDescription.Text.Trim, VbStrConv.ProperCase)
            Call CreditTransaction(txtAccount.Text.Trim, "CR", Val(txtCredit.Text.Trim), gNarration.Trim, txtVoucher.Text.Trim.ToUpper)
        End If
    End Sub

#Region "JOURNAL ENTRIES PROCEDURES"

    Private Sub DebitTransaction(ByVal Trans_Acc_Name As String, ByVal TransType As String, ByVal Trans_Amount As Double, ByVal TransDesc As String, ByVal DocNo As String)
        SortID += 1
        AccID = Get_P_Account_ID(Trans_Acc_Name.Trim.ToString)

        Fyear_Date = Format(Date.Parse(dtpTransaction.Value.ToString.Trim), "dd/MMM/yyyy")
        If (Month(Fyear_Date) < 7) Then
            FinancialYear = ("FY - " & Year(Fyear_Date))
        Else
            FinancialYear = ("FY - " & Year(Fyear_Date) + 1)
        End If

        Dim strDate As DateTime = DateTime.Now
        strDate = dtpTransaction.Value.ToShortDateString.ToString

        '// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String

        NewTransaction = "INSERT INTO PETTY_TEMP VALUES ('" & _
                         Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                         Val(txtTranID.Text.Trim) & "," & _
                         Val(AccID) & ",'" & _
                         DocNo.Trim & "','" & _
                         StrConv(gblAccHead.Trim, VbStrConv.ProperCase) & "','" & _
                         StrConv(Trans_Acc_Name.Trim, VbStrConv.ProperCase) & "','" & _
                         TransDesc.Trim.ToString & "','" & _
                         TransType & "'," & _
                         Val(lblCashInHand.Text.Trim) & "," & _
                         Trans_Amount & ",0.00," & _
                         Val(lblCashInHand.Text.Trim) + Trans_Amount & "," & _
                         Val(SortID) & ",'" & _
                         FinancialYear & "',0)"

        Execute_DatabaseTable_Query(SqlDataAdapter, NewTransaction, Connection)
        NewTransaction = Nothing
        lblCashInHand.Text = Val(lblCashInHand.Text.Trim) + Trans_Amount
        txtTotDebit.Text = Val(txtTotDebit.Text.Trim) + Trans_Amount
        Call Show_Journal_Transactions()
        Call ClearTextBoxes()
        txtDebit.Clear()
        ProcessTabKey(False)
        txtAcc_Id.Focus()
        cmdPost.Enabled = True
    End Sub

    Private Sub CreditTransaction(ByVal Trans_Acc_Name As String, ByVal TransType As String, ByVal Trans_Amount As Double, ByVal TransDesc As String, ByVal DocNo As String)
        SortID += 1
        AccID = Get_P_Account_ID(Trans_Acc_Name.Trim.ToString)

        Fyear_Date = Format(Date.Parse(dtpTransaction.Value.ToString.Trim), "dd/MMM/yyyy")
        If (Month(Fyear_Date) < 7) Then
            FinancialYear = ("FY - " & Year(Fyear_Date))
        Else
            FinancialYear = ("FY - " & Year(Fyear_Date) + 1)
        End If

        Dim strDate As DateTime = DateTime.Now
        strDate = dtpTransaction.Value.ToShortDateString

        '// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String

        NewTransaction = "INSERT INTO PETTY_TEMP VALUES ('" & _
                         Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                         Val(txtTranID.Text.Trim) & "," & _
                         Val(AccID) & ",'" & _
                         DocNo.Trim & "','" & _
                         StrConv(gblAccHead.Trim, VbStrConv.ProperCase) & "','" & _
                         StrConv(Trans_Acc_Name.Trim, VbStrConv.ProperCase) & "','" & _
                         TransDesc.Trim.ToString & "','" & _
                         TransType & "'," & _
                         Val(lblCashInHand.Text.Trim) & ",0.00," & _
                         Trans_Amount & "," & _
                         Val(lblCashInHand.Text.Trim) - Trans_Amount & "," & _
                         Val(SortID) & ",'" & _
                         FinancialYear & "',0)"

        Execute_DatabaseTable_Query(SqlDataAdapter, NewTransaction, Connection)
        NewTransaction = Nothing
        lblCashInHand.Text = Val(lblCashInHand.Text.Trim) - Trans_Amount
        txtTotCredit.Text = Val(txtTotCredit.Text.Trim) + Trans_Amount
        Call Show_Journal_Transactions()
        txtCredit.Clear()
        ProcessTabKey(False)
        txtAcc_Id.Focus()
        txtTranID.Text = GenerateMax_ID("PETTY_TEMP", "P_TRAN_ID")
        Call ClearTextBoxes()
        cmdDelete.Text = "D&elete All"
        cmdPost.Enabled = True
    End Sub

    Private Sub Show_Journal_Transactions()
        Me.TransactionDataSet.Clear()
        JournalGrid.DataSource = Nothing
        ExecuteSqlQuery(SqlDataAdapter, Me.TransactionDataSet, "SELECT * FROM PETTY_TEMP ORDER BY P_TRAN_ID, P_SORT", "PETTY_TEMP", Connection)
        JournalGrid.DataSource = Me.TransactionDataSet
        JournalGrid.DataMember = "PETTY_TEMP"
    End Sub

    Private Sub cmdPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPost.Click
        'To update balances of petty cash and sub accounts
        Dim UpdateBalance As String = String.Empty
        Dim PostTrans As String = "select * from petty_temp WHERE P_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)"
        Execute_DatabaseTable_Query(SqlDataAdapter, PostTrans, Connection)
        Dim TransferTrans As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If TransferTrans.HasRows Then
            While TransferTrans.Read
                If TransferTrans.Item("p_debit").ToString > 0 Then
                    UpdateBalance = "UPDATE PETTY_ACCOUNTS SET P_ACC_BALANCE = P_ACC_BALANCE + " & TransferTrans.Item("p_debit") & "," & _
                                    "P_ACC_DEBIT = P_ACC_DEBIT + " & TransferTrans.Item("P_DEBIT") & "," & _
                                    "P_ACC_CREDIT = P_ACC_CREDIT + " & TransferTrans.Item("P_CREDIT") & " WHERE P_ACC_NO = 1"
                End If
                If TransferTrans.Item("p_credit").ToString > 0 Then
                    UpdateBalance = "UPDATE PETTY_ACCOUNTS SET P_ACC_BALANCE = P_ACC_BALANCE - " & TransferTrans.Item("p_credit") & "," & _
                                    "P_ACC_DEBIT = P_ACC_DEBIT + " & TransferTrans.Item("P_DEBIT") & "," & _
                                    "P_ACC_CREDIT = P_ACC_CREDIT + " & TransferTrans.Item("P_CREDIT") & " WHERE P_ACC_NO = 1"
                End If
                Execute_DatabaseTable_Query(SqlDataAdapter, UpdateBalance, Connection)

                UpdateBalance = "UPDATE PETTY_ACCOUNTS SET P_ACC_DEBIT = P_ACC_DEBIT + " & TransferTrans.Item("P_DEBIT") & "," & _
                                "P_ACC_CREDIT = P_ACC_CREDIT + " & TransferTrans.Item("P_CREDIT") & " WHERE P_ACC_NO = " & TransferTrans.Item("P_ACC_ID")
                Execute_DatabaseTable_Query(TransDataAdapter, UpdateBalance, Connection)
            End While
        Else
            MsgBox("There is no transactions to post.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim Post_Transactions As String = "INSERT INTO PETTY_JOURNAL " & _
                                          "SELECT  *  from PETTY_TEMP " & _
                                          "WHERE P_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)"
        Execute_DatabaseTable_Query(SqlDataAdapter, Post_Transactions, Connection)
        Execute_DatabaseTable_Query(SqlDataAdapter, "DELETE FROM PETTY_TEMP", Connection)
        txtTranID.Text = GenerateMax_ID("PETTY_JOURNAL", "P_TRAN_ID")
        Call Get_Balance(1)
        Call Show_Journal_Transactions()
        txtTotDebit.Clear()
        txtTotCredit.Clear()
        cmdPost.Enabled = False
        gNarration = ""
        cmdDelete.Text = "&Delete Entry"
        ProcessTabKey(False)
        txtAcc_Id.Focus()
        Me.Cursor = Cursors.Default
    End Sub

#End Region

    Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString.Equals(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) Then e.Handled = True
    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString.Equals(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) Then e.Handled = True
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If cmdDelete.Text = "D&elete All" Then
            Execute_DatabaseTable_Query(SqlDataAdapter, "DELETE FROM PETTY_TEMP", Connection)
            Connection.Close()
            cmdDelete.Text = "&Delete Entry"
            txtTranID.Text = GenerateMax_ID("Petty_Journal", "P_TRAN_ID")
            Call Get_Balance(1)
            Call Show_Journal_Transactions()
            txtTotCredit.Clear()
            txtTotDebit.Clear()
            Exit Sub
        End If
        Dim delTranID As String = ""
        delTranID = Microsoft.VisualBasic.InputBox("Please Enter Transaction ID for deletion.", My.Application.Info.ProductName)
        If Len(delTranID) = 0 Or delTranID = 0 Then Exit Sub
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "SELECT * FROM PETTY_TEMP WHERE P_TRAN_ID =" & Val(delTranID), "PETTY_TEMP", Connection)
        Dim DelReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While DelReader.Read
            txtTotCredit.Text = Val(txtTotCredit.Text.Trim) - Val(DelReader.Item("P_CREDIT"))
            txtTotDebit.Text = Val(txtTotDebit.Text.Trim) - Val(DelReader.Item("P_DEBIT"))
        End While
        txtDescription.Text = ""
        If Not DelReader Is Nothing Then DelReader.Close()
        Execute_DatabaseTable_Query(SqlDataAdapter, "DELETE FROM PETTY_TEMP WHERE P_TRAN_ID =" & Val(delTranID), Connection)
        Call Get_Balance(1)
        Call Show_Journal_Transactions()
    End Sub

    Private Sub frmJournal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then Me.Text = "Petty Journal Transactions" Else Me.Text = My.Application.Info.ProductName
    End Sub

    Private Sub txtAcc_Id_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcc_Id.DoubleClick
        PettyAccountList.ShowDialog(Me)
        If Len(gblAccID.Trim) > 0 Then
            txtAcc_Id.Text = gblAccID
            lblAccHead.Text = gblAccHead
            txtAccount.Text = gblAccName
            txtVoucher.Text = "PCD-" & txtTranID.Text.Trim
            Exit Sub
        End If
    End Sub

    Private Sub txtAcc_Id_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcc_Id.KeyUp
        If e.KeyCode = Keys.F2 Then
            PettyAccountList.ShowDialog(Me)
            If Len(gblAccID.Trim) > 0 Then
                txtAcc_Id.Text = gblAccID
                lblAccHead.Text = gblAccHead
                txtAccount.Text = gblAccName
                txtVoucher.Text = "PCD-" & txtTranID.Text.Trim
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
                lblAccHead.Text = gblAccHead
                txtAccount.Text = gblAccName
                txtVoucher.Text = "PCD-" & txtTranID.Text.Trim
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ClearTextBoxes()
        lblAccHead.Text = String.Empty
        txtVoucher.Clear()
        txtDescription.Clear()
        txtAcc_Id.Clear()
        txtAccount.Clear()
        txtDebit.Clear()
        txtCredit.Clear()
    End Sub

    Private Sub Get_Balance(ByVal AccountID As Integer)
        Dim GetBalance As String = "select p_acc_balance from lab_pro.dbo.petty_accounts where p_acc_no = " & AccountID
        Execute_DatabaseTable_Query(SqlDataAdapter, GetBalance, Connection)
        Dim BalReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If BalReader.HasRows Then
            While BalReader.Read
                gblBalance = BalReader.Item("p_acc_balance")
            End While
            lblOpnBal.Text = gblBalance
            lblCashInHand.Text = gblBalance
        End If
        If BalReader Is Nothing Then BalReader.Close()
    End Sub

End Class