Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D
Public Class frmJournal
#Region "GLOBAL VARIABLES"
    Dim gGross, gNet, gCompl, gDisc, gDues, gDueRcv, gDelAdj, gDueAdj, gNarration, CrNarration, wGross, wNet, wCompl, wDisc, wDues, wDueRcv, wDelAdj, wDueAdj, CHK_STRING As String
    Dim gDelNet As Double = 0, gDelDisc As Double = 0, gDelPaid As Double = 0, gDelDues As Double = 0, gComNet As Double = 0, gComDisc As Double = 0, gComPaid As Double = 0, gComDues As Double = 0
    Dim TransActive, TransRetrieve As Boolean
    Dim SortID, AccID, AccLinkCode As Integer
    Dim TransDate As Date = DateTime.Now
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Execute_Trans_Reader As SqlDataReader
#End Region
#Region "FORM DESIGN"
    Private Sub HdrPicBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles HdrPicBox.Paint

        Dim g As Graphics = e.Graphics
        Dim rect As Rectangle
        rect = HdrPicBox.ClientRectangle()
        Dim fnt = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        Dim lgb As New LinearGradientBrush(rect, Color.CornflowerBlue, Color.AliceBlue, LinearGradientMode.Vertical)
        g.FillRectangle(lgb, 0, 0, HdrPicBox.Width, HdrPicBox.Height)
        g.DrawString("General Journal Entries", fnt, Brushes.AliceBlue, 8, 8)

    End Sub

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
        Execute_DatabaseTable_Query(SqlDataAdapt, "DELETE FROM GEN_TEMP", Connection)
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
        Dim G As Graphics
        Dim rect As Rectangle
        G = GetGraphicsObject()
        rect = New Rectangle(0, 0, Me.Width - 3, Me.Height - 3)
        Dim grdForm As New LinearGradientBrush(rect, Color.WhiteSmoke, Color.LightGray, LinearGradientMode.Vertical)
        G.FillRectangle(grdForm, 0, 0, Me.Width - 3, Me.Height - 3)

        dtpTransaction.Value = DateAdd(DateInterval.Day, -1, Date.Now)
        TransDate = dtpTransaction.Value
        Execute_DatabaseTable_Query(SqlDataAdapt, "DELETE FROM GEN_TEMP", Connection)

        Dim Filler As SqlDataReader
        Dim commandtext As String = "SELECT DISTINCT ACC_NAME FROM ACCOUNTS ORDER BY ACC_NAME"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, commandtext, "ACCOUNTS", Connection)
        Filler = SqlDataAdapt.SelectCommand.ExecuteReader
        While Filler.Read
            Me.cmbAccHead.Items.Add(Filler.Item("ACC_NAME").ToString.Trim)
        End While
        If Not Filler Is Nothing Then Filler.Close()
        Connection.Close()
        txtTranID.Text = GenerateMax_ID("LEDGER_TRANSACTIONS", "LEDG_TRAN_ID")
        Connection.Close()
        SortID = 0
        TransActive = False
        TransRetrieve = False

    End Sub
#End Region

    Private Sub txtDebit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDebit.KeyDown
        If e.KeyCode = Keys.Enter Then
            gNarration = StrConv(txtDescription.Text.Trim & " ( " & cmbAccHead.Text & " )", VbStrConv.ProperCase)
            Call DebitTransaction(cmbAccHead.Text.Trim, "DR", Val(txtDebit.Text.Trim), gNarration.Trim)
        End If
    End Sub

    Private Sub txtCredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            'gNarration = StrConv(txtDescription.Text.Trim, VbStrConv.ProperCase)
            Call CreditTransaction(cmbAccHead.Text.Trim, "CR", Val(txtCredit.Text.Trim), gNarration)
        End If
    End Sub

#Region "JOURNAL ENTRIES PROCEDURES"

    Private Sub DebitTransaction(ByVal Trans_Acc_Name As String, ByVal TransType As String, ByVal Trans_Amount As Double, ByVal TransDesc As String)

        SortID += 1
        AccID = Get_Account_ID(Trans_Acc_Name.Trim.ToString)

        If CType(AccID.ToString, Integer) = 0 Then _
            MsgBox("Account Name not Registered.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub

        Dim strDate As DateTime = DateTime.Now
        strDate = dtpTransaction.Value.ToShortDateString.ToString

        '// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String

        NewTransaction = "INSERT INTO GEN_TEMP(GEN_DATE,GEN_TRAN_ID,GEN_ACC_ID,GEN_DESCRIPTION,GEN_LP," & _
                         "GEN_ACC_TYPE,GEN_DEBIT,GEN_CREDIT,GEN_NARRATION,GEN_SORT,GEN_LINK_CODE,GEN_LINK,GEN_AMOUNT) VALUES ('" & _
                        Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                        Val(txtTranID.Text.Trim) & "," & _
                        Val(AccID) & ",'" & _
                        StrConv(Trans_Acc_Name.Trim, VbStrConv.ProperCase) & "'," & _
                        Val(AccID) & ",'" & _
                        TransType & "'," & _
                        Trans_Amount & ",0,'" & _
                        TransDesc.Trim.ToString & "'," & _
                        Val(SortID) & "," & _
                        Val(gblAccLink) & ",'" & _
                        gblStatLink.Trim & "'," & _
                        Trans_Amount & ")"

        Execute_DatabaseTable_Query(SqlDataAdapt, NewTransaction, Connection)
        NewTransaction = Nothing

        txtTotDebit.Text = Val(txtTotDebit.Text.Trim) + Trans_Amount
        Call Show_Journal_Transactions()
        txtDebit.Clear()
        cmbAccHead.Focus()

    End Sub

    Private Sub CreditTransaction(ByVal Trans_Acc_Name As String, ByVal TransType As String, ByVal Trans_Amount As Double, ByVal TransDesc As String)

        SortID += 1
        AccID = Get_Account_ID(Trans_Acc_Name.Trim.ToString)
        If CType(AccID.ToString, Integer) = 0 Then _
            MsgBox("Account Name not Registered.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub

        Dim strDate As DateTime = DateTime.Now
        strDate = dtpTransaction.Value.ToShortDateString

        '// ASSIGN FIELD DATA VALUES FOR NEW TRANSACTION
        Dim NewTransaction As String

        NewTransaction = "INSERT INTO GEN_TEMP(GEN_DATE,GEN_TRAN_ID,GEN_ACC_ID,GEN_DESCRIPTION,GEN_LP," & _
                         "GEN_ACC_TYPE,GEN_DEBIT,GEN_CREDIT,GEN_NARRATION,GEN_SORT,GEN_LINK_CODE,GEN_LINK,GEN_AMOUNT) VALUES ('" & _
                        Format(DateTime.Parse(strDate), "MM/dd/yyyy") & "'," & _
                        Val(txtTranID.Text.Trim) & "," & _
                        Val(AccID) & ",'" & _
                        StrConv(Trans_Acc_Name.Trim, VbStrConv.ProperCase) & "'," & _
                        Val(AccID) & ",'" & _
                        TransType & "',0," & _
                        Trans_Amount & ",'" & _
                        TransDesc.Trim.ToString & "'," & _
                        Val(SortID) & "," & _
                        Val(gblAccLink) & ",'" & _
                        gblStatLink.Trim & "'," & _
                        Trans_Amount & ")"

        Execute_DatabaseTable_Query(SqlDataAdapt, NewTransaction, Connection)
        NewTransaction = Nothing

        txtTotCredit.Text = Val(txtTotCredit.Text.Trim) + Trans_Amount
        Call Show_Journal_Transactions()
        txtCredit.Clear()
        cmbAccHead.Focus()
        If Val(txtTotDebit.Text) = Val(txtTotCredit.Text) Then
            txtTranID.Text = GenerateMax_ID("GEN_TEMP", "GEN_TRAN_ID")
            txtDescription.Text = ""
            cmbAccHead.Refresh()
            cmdGetTrans.Text = "D&elete All"
        End If
        cmdPost.Enabled = True

    End Sub

    Private Sub Show_Journal_Transactions()

        Me.TransactionDataSet.Clear()
        JournalGrid.DataSource = Nothing
        ExecuteSqlQuery(SqlDataAdapt, Me.TransactionDataSet, "SELECT * FROM GEN_TEMP ORDER BY GEN_TRAN_ID, GEN_SORT", "GEN_TEMP", Connection)
        JournalGrid.DataSource = Me.TransactionDataSet
        JournalGrid.DataMember = "GEN_TEMP"

    End Sub

    Private Sub cmdGetTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetTrans.Click
        ' PROCEDURE FOR GENERAL JOURNAL TRANSACTIONS ( DEBIT AND CREDIT )
        If cmdGetTrans.Text = "D&elete All" Then
            Execute_DatabaseTable_Query(SqlDataAdapt, "DELETE FROM GEN_TEMP", Connection)
            Connection.Close()
            cmdGetTrans.Text = "&Get Entries"
            txtTranID.Text = GenerateMax_ID("LEDGER_TRANSACTIONS", "LEDG_TRAN_ID")
            Call Show_Journal_Transactions()
            txtTotCredit.Clear()
            txtTotDebit.Clear()
            Exit Sub
        End If

        Dim Check_Trans_Date As String = ""
        Check_Trans_Date = "SELECT * FROM LEDGER_TRANSACTIONS WHERE (LEDG_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) AND (LEDG_DESCRIPTION = 'LAB GROSS RECEIPTS')"
        Execute_DatabaseTable_Query(SqlDataAdapt, Check_Trans_Date, Connection)
        Dim CHECK_TRANS As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While CHECK_TRANS.Read
            CHK_STRING = CHECK_TRANS.Item("LEDG_DESCRIPTION").ToString.Trim.ToUpper.Trim
        End While
        If Not CHECK_TRANS Is Nothing Then CHECK_TRANS.Close()

        If CHK_STRING Is Nothing Or CHK_STRING = "" Then TransRetrieve = False Else TransRetrieve = True

        If TransRetrieve = True Then
            MsgBox("Transaction already transferred", MsgBoxStyle.Information, My.Application.Info.ProductName)
            TransRetrieve = False
            CHK_STRING = ""
            Exit Sub
        End If

        Dim strCp As String = ""
        TransActive = False
        gDelAdj = 0
        gGross = 0
        gDueAdj = 0
        gCompl = 0
        gNet = 0
        gDisc = 0
        wGross = 0
        wNet = 0
        wDisc = 0
        wDues = 0
        wCompl = 0
        wDelAdj = 0
        wDueAdj = 0

        Dim Transaction_Check_Text As String = "SELECT * FROM PATIENT WHERE P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Transaction_Check_Text, "PATIENT", Connection)
        If SqlDataSet.Tables("PATIENT").Rows.Count = 0 Then MsgBox("Check Transaction Date for Journal Entris", MsgBoxStyle.Information, My.Application.Info.ProductName) : Me.Cursor = Cursors.Default : Exit Sub
        Connection.Close()
        Me.Cursor = Cursors.WaitCursor

        '// DAILY TRANSACTION PROCEDURE
        Dim Daily_Transaction_Query As String = "SELECT P_CP AS CP_EXPR, SUM(P_TOTAL) AS GROS_EXP, SUM(P_PAID) AS PAID_EXP, SUM(P_DISCOUNT) AS DISC_EXP, SUM(P_DUES) AS DUES_EXP, " & _
                                                "SUM(P_COMPLIMENT) AS COMP_EXP, SUM(P_DELETE) AS DELE_EXP, SUM(P_DUE_RCV) AS DUE_RCV_EXP FROM PATIENT GROUP BY P_CP,P_DATE_SAMPLE " & _
                                                "HAVING (P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) ORDER BY P_CP"

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Daily_Transaction_Query, "PATIENT", Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader

        While Execute_Trans_Reader.Read

            If Val(Execute_Trans_Reader.Item("GROS_EXP")) = 0 Then gGross = 0 Else gGross = Val(Execute_Trans_Reader.Item("GROS_EXP"))
            If Val(Execute_Trans_Reader.Item("PAID_EXP")) = 0 Then gNet = 0 Else gNet = Val(Execute_Trans_Reader.Item("PAID_EXP"))
            If Val(Execute_Trans_Reader.Item("DISC_EXP")) = 0 Then gDisc = 0 Else gDisc = Val(Execute_Trans_Reader.Item("DISC_EXP"))
            If Val(Execute_Trans_Reader.Item("DUES_EXP")) = 0 Then gDues = 0 Else gDues = Val(Execute_Trans_Reader.Item("DUES_EXP"))
            If Val(Execute_Trans_Reader.Item("COMP_EXP")) = 0 Then gCompl = 0 Else gCompl = Val(Execute_Trans_Reader.Item("COMP_EXP"))
            If Val(Execute_Trans_Reader.Item("DELE_EXP")) = 0 Then gDelAdj = 0 Else gDelAdj = Val(Execute_Trans_Reader.Item("DELE_EXP"))
            If Val(Execute_Trans_Reader.Item("DUE_RCV_EXP")) = 0 Then gDueAdj = 0 Else gDueAdj = Val(Execute_Trans_Reader.Item("DUE_RCV_EXP"))

            gDues = Val(gDues) + Val(gDueAdj)
            gNet = Val(gNet) - Val(gDueAdj)

            wGross = Val(wGross) + Val(gGross)
            wNet = Val(wNet) + Val(gNet)
            wDisc = Val(wDisc) + Val(gDisc)
            wDues = Val(wDues) + Val(gDues)
            wCompl = Val(wCompl) + Val(gCompl)
            wDelAdj = Val(wDelAdj) + Val(gDelAdj)
            wDueAdj = Val(wDueAdj) + Val(gDueAdj)

            strCp = strCp & ", " & Execute_Trans_Reader.Item("CP_EXPR").ToString.Trim

        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        gNarration = StrConv("Daily Transaction for Collection from", VbStrConv.ProperCase) & strCp.ToUpper

        If Val(wNet) > 0 Then Call DebitTransaction("Cash", "DR", wNet, gNarration.Trim)
        If Val(wDisc) > 0 Then Call DebitTransaction("Lab Discount", "DR", wDisc, gNarration.Trim)
        If Val(wDues) > 0 Then Call DebitTransaction("Lab Dues", "DR", wDues, gNarration.Trim)
        If Val(wCompl) > 0 Then Call DebitTransaction("Complimentary", "DR", wCompl, gNarration.Trim)
        If Val(wDelAdj) > 0 Then Call DebitTransaction("Delete / Cancelled Cases", "DR", wDelAdj, gNarration.Trim)
        If Val(wGross) > 0 Then Call CreditTransaction("Lab Gross Receipts", "CR", wGross, gNarration.Trim)


        '// DUES RECEIVED TRANSACTIONS PROCEDURE
        wNet = 0
        strCp = ""
        Transaction_Check_Text = "SELECT SUM(P_DUE_RCV) AS EXPR1,P_DUE_RCV_DATE,P_CP from PATIENT GROUP BY p_due_rcv_date,p_cp " & _
                                 "HAVING (p_due_rcv_date = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) " & _
                                 "AND (SUM(P_DUE_RCV) > 0) ORDER BY P_CP"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Transaction_Check_Text, "PATIENT", Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            If Val(Execute_Trans_Reader.Item("EXPR1")) > 0 Then
                strCp = strCp & ", " & Execute_Trans_Reader.Item("P_CP").ToString.Trim.ToUpper
                wNet = wNet + Val(Execute_Trans_Reader.Item("EXPR1"))
            End If
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        If wNet > 0 Then
            DebitTransaction("Cash", "DR", wNet, "Dues Received from " & strCp.Trim)
            CreditTransaction("Lab Dues", "CR", wNet, "Dues Received from " & strCp.Trim)
        End If

        '// PROCEDURE FOR DELETED CASES AFTER DATE
        wNet = 0
        wDisc = 0
        wDues = 0
        wDelAdj = 0
        strCp = ""
        Transaction_Check_Text = "SELECT * from patient WHERE (p_delete_on = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102))"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Transaction_Check_Text, "PATIENT", Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        gNarration = "Cancelled Cases today ID #"
        While Execute_Trans_Reader.Read
            gNarration = gNarration & " (" & Execute_Trans_Reader.Item("P_NUM").ToString & "),"
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()
        'gNarration = gNarration & " by " & SysOperator

        Transaction_Check_Text = "SELECT SUM(p_del_paid) AS Expr1, SUM(p_del_dues) AS Expr2, SUM(p_del_disc) AS Expr3, SUM(p_delete) AS Expr4, p_delete_on, p_cp " & _
                                 "FROM Patient GROUP BY p_delete_on, p_cp HAVING " & _
                                 "(p_delete_on = CONVERT(DATETIME, '" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) ORDER BY p_cp"

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Transaction_Check_Text, "PATIENT", Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            strCp = Execute_Trans_Reader.Item("P_CP").ToString.Trim
            If Val(Execute_Trans_Reader.Item("EXPR4")) = 0 Then gDelNet = 0 Else gDelNet = Val(Execute_Trans_Reader.Item("EXPR4"))
            If Val(Execute_Trans_Reader.Item("EXPR3")) = 0 Then gDelDisc = 0 Else gDelDisc = Val(Execute_Trans_Reader.Item("EXPR3"))
            If Val(Execute_Trans_Reader.Item("EXPR2")) = 0 Then gDelDues = 0 Else gDelDues = Val(Execute_Trans_Reader.Item("EXPR2"))
            If Val(Execute_Trans_Reader.Item("EXPR1")) = 0 Then gDelPaid = 0 Else gDelPaid = Val(Execute_Trans_Reader.Item("EXPR1"))
            gDelNet = gDelPaid + gDelDisc + gDelDues

            'strCp = strCp & ", " & Execute_Trans_Reader.Item("P_CP").ToString.Trim.ToUpper
            wNet = wNet + Val(gDelNet)
            wDisc = wDisc + Val(gDelDisc)
            wDues = wDues + Val(gDelDues)
            wDelAdj = wDelAdj + Val(gDelPaid)

        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()
        'gNarration = gNarration & strCp.ToUpper
        If wNet > 0 Then DebitTransaction("Delete / Cancelled Cases", "DR", wNet, gNarration)
        If wDisc > 0 Then CreditTransaction("Lab Discount", "CR", wDisc, gNarration)
        If wDues > 0 Then CreditTransaction("Lab Dues", "CR", wDues, gNarration)
        If wDelAdj > 0 Then CreditTransaction("Cash", "CR", wDelAdj, gNarration)

        '// PROCEDURE FOR COMPLIMENTARY CASES AFTER DATE
        wNet = 0
        wDisc = 0
        wDues = 0
        wDelAdj = 0
        strCp = ""
        Transaction_Check_Text = "SELECT * from patient WHERE (p_comp_on = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102))"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Transaction_Check_Text, "PATIENT", Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        gNarration = "Complimentary Cases today ID #"
        While Execute_Trans_Reader.Read
            gNarration = gNarration & " (" & Execute_Trans_Reader.Item("P_NUM").ToString & "),"
        End While
        'gNarration = "Case # " & gNarration
        'If Len(gNarration) > 300 Then gNarration = "Complimentary Cases on today for "
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        Transaction_Check_Text = "SELECT SUM(p_com_paid) AS COM_PAID, SUM(p_com_dues) AS COM_DUES, SUM(p_com_disc) AS COM_DISC, SUM(p_compliment) AS COM_COMP, p_comp_on, p_cp " & _
                                 "FROM Patient GROUP BY p_comp_on, p_cp HAVING " & _
                                 "(p_comp_on = CONVERT(DATETIME, '" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) ORDER BY p_cp"

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Transaction_Check_Text, "PATIENT", Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            strCp = Execute_Trans_Reader.Item("P_CP").ToString.Trim
            If Val(Execute_Trans_Reader.Item("COM_COMP")) = 0 Then gComNet = 0 Else gComNet = Val(Execute_Trans_Reader.Item("COM_COMP"))
            If Val(Execute_Trans_Reader.Item("COM_DISC")) = 0 Then gComDisc = 0 Else gComDisc = Val(Execute_Trans_Reader.Item("COM_DISC"))
            If Val(Execute_Trans_Reader.Item("COM_DUES")) = 0 Then gComDues = 0 Else gComDues = Val(Execute_Trans_Reader.Item("COM_DUES"))
            If Val(Execute_Trans_Reader.Item("COM_PAID")) = 0 Then gComPaid = 0 Else gComPaid = Val(Execute_Trans_Reader.Item("COM_PAID"))
            gComNet = gComPaid + gComDisc + gComDues

            'strCp = strCp & ", " & Execute_Trans_Reader.Item("P_CP").ToString.Trim.ToUpper
            wNet = wNet + Val(gComNet)
            wDisc = wDisc + Val(gComDisc)
            wDues = wDues + Val(gComDues)
            wDelAdj = wDelAdj + Val(gComPaid)

        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()
        'gNarration = gNarration & strCp.ToUpper
        If wNet > 0 Then DebitTransaction("Complimentary", "DR", wNet, gNarration)
        If wDisc > 0 Then CreditTransaction("Lab Discount", "CR", wDisc, gNarration)
        If wDues > 0 Then CreditTransaction("Lab Dues", "CR", wDues, gNarration)
        If wDelAdj > 0 Then CreditTransaction("Cash", "CR", wDelAdj, gNarration)

        cmdGetTrans.Text = "D&elete All"
        cmdPost.Enabled = True
        cmbAccHead.Focus()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPost.Click

        If Val(txtTotDebit.Text) = 0 And Val(txtTotCredit.Text) = 0 Then MsgBox("There is no transactions to post.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub

        If Val(txtTotDebit.Text) = Val(txtTotCredit.Text) Then
            Me.Cursor = Cursors.WaitCursor
            Dim Post_Transactions As String = "INSERT INTO LEDGER_TRANSACTIONS(LEDG_DATE,LEDG_TRAN_ID,LEDG_ACC_ID,LEDG_DESCRIPTION,LEDG_LP,LEDG_ACC_TYPE,LEDG_DEBIT,LEDG_CREDIT,LEDG_NARRATION,LEDG_LINK_CODE,LEDG_LINK,LEDG_AMOUNT) " & _
                                              "SELECT GEN_DATE,GEN_TRAN_ID,GEN_ACC_ID,GEN_DESCRIPTION,GEN_LP,GEN_ACC_TYPE,GEN_DEBIT,GEN_CREDIT,GEN_NARRATION,GEN_LINK_CODE,GEN_LINK,GEN_AMOUNT from GEN_TEMP"
            Execute_DatabaseTable_Query(SqlDataAdapt, Post_Transactions, Connection)
            Execute_DatabaseTable_Query(SqlDataAdapt, "DELETE FROM GEN_TEMP", Connection)
            txtTranID.Text = GenerateMax_ID("LEDGER_TRANSACTIONS", "LEDG_TRAN_ID")
            Call Show_Journal_Transactions()
            txtTotDebit.Clear()
            txtTotCredit.Clear()
            cmdPost.Enabled = False
            gNarration = ""
            cmdGetTrans.Text = "&Get Entries"
            cmbAccHead.Focus()
        Else
            MsgBox("Transactions cannot be posted with difference. please check transactions.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If
        Me.Cursor = Cursors.Default

    End Sub

#End Region
#Region "GRID FORMATTING PROCEDURE"
    Private Sub JournalGrid_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles JournalGrid.CellFormatting
        If JournalGrid.Columns(e.ColumnIndex).Name = "colCredit" Then
            If e.Value = 0 Then e.CellStyle.ForeColor = Color.LightBlue
            'If e.Value > 0 Then e.CellStyle.BackColor = Color.LimeGreen Else e.CellStyle.ForeColor = Color.White
        End If
        If JournalGrid.Columns(e.ColumnIndex).Name = "colDebit" Then
            If e.Value = 0 Then e.CellStyle.ForeColor = Color.LightBlue
            'If e.Value > 0 Then e.CellStyle.BackColor = Color.LimeGreen Else e.CellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub JournalGrid_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles JournalGrid.CellPainting
        '// this procedure used to show columns as merged
        If e.ColumnIndex = 0 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.JournalGrid.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell  
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)  
                    'If next row cell has different content, only draw bottom border line of current cell  
                    If e.RowIndex < JournalGrid.Rows.Count - 2 AndAlso JournalGrid.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell  
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells  
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso JournalGrid.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If

        If e.ColumnIndex = 1 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.JournalGrid.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell  
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)  
                    'If next row cell has different content, only draw bottom border line of current cell  
                    If e.RowIndex < JournalGrid.Rows.Count - 2 AndAlso JournalGrid.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell  
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells  
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso JournalGrid.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If

        If e.ColumnIndex = 3 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.JournalGrid.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell  
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)  
                    'If next row cell has different content, only draw bottom border line of current cell  
                    If e.RowIndex < JournalGrid.Rows.Count - 2 AndAlso JournalGrid.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell  
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells  
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso JournalGrid.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If

    End Sub
#End Region

    Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString.Equals(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) Then e.Handled = True
    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString.Equals(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) Then e.Handled = True
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim delTranID As String = ""
        delTranID = InputBox("Please Enter Transaction ID for deletion.", My.Application.Info.ProductName)
        If Len(delTranID) = 0 Or delTranID = 0 Then Exit Sub
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "SELECT * FROM GEN_TEMP WHERE GEN_TRAN_ID =" & Val(delTranID), "GEN_TEMP", Connection)
        Dim DelReader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While DelReader.Read
            txtTotCredit.Text = Val(txtTotCredit.Text.Trim) - Val(DelReader.Item("GEN_CREDIT"))
            txtTotDebit.Text = Val(txtTotDebit.Text.Trim) - Val(DelReader.Item("GEN_DEBIT"))
        End While
        txtDescription.Text = ""
        If Not DelReader Is Nothing Then DelReader.Close()
        Execute_DatabaseTable_Query(SqlDataAdapt, "DELETE FROM GEN_TEMP WHERE GEN_TRAN_ID =" & Val(delTranID), Connection)
        Call Show_Journal_Transactions()
    End Sub

    Private Sub frmJournal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then Me.Text = "Journal Transactions" Else Me.Text = My.Application.Info.ProductName
    End Sub
End Class
