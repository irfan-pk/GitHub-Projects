Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D

Public Class frmClosLedgers
#Region "GLOBAL VARIABLES"
    Dim Acc_ID As Integer = 0
    Dim TransDate As Date = DateTime.Now
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Execute_Trans_Reader As SqlDataReader
    Dim OpnCr, OpnDr As Double
    Dim MyTable As String
#End Region

#Region "FORM EVENTS"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmClosLedgers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MyTable = Microsoft.VisualBasic.InputBox("Please give required Closing Date >>", My.Application.Info.ProductName)
        MyTable = "Closed_Transactions_" & MyTable
        If Len(MyTable) = 0 Or MyTable = "" Then MsgBox("Table Name not given.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly) : Exit Sub

        Call GetConnectionString()
        Me.Text = My.Application.Info.ProductName
        Dim Filler As SqlDataReader
        Dim commandtext As String = "SELECT DISTINCT ACC_NAME FROM ACCOUNTS ORDER BY ACC_NAME"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, commandtext, "ACCOUNTS", Connection)
        Filler = SqlDataAdapt.SelectCommand.ExecuteReader
        While Filler.Read
            Me.ToolStripComboBox.Items.Add(Filler.Item("ACC_NAME").ToString.Trim)
        End While
        If Not Filler Is Nothing Then Filler.Close()
        Connection.Close()
        dtpFrom.Value = DateAdd(DateInterval.Day, -1, Date.Now)
        dtpTo.Value = Date.Now

        TransDate = dtpFrom.Value
        toDate = dtpTo.Value
        fromDate = Now
        toDate = Now
        Connection.Close()

        Me.ToolStripComboBox.Text = "Cash"
        Call Me.ToolStripButton_Click(sender, e)

    End Sub
#End Region

#Region "JOURNAL ENTRIES PROCEDURES"

    Private Sub Show_Journal_Transactions()
        OpnDr = 0
        OpnCr = 0
        lblCredit.Text = 0
        lblDebit.Text = 0

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "SELECT * FROM " & Trim(MyTable) & " WHERE LEDG_DATE < CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") ORDER BY LEDG_DATE, LEDG_TRAN_ID", MyTable, Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            OpnDr = OpnDr + Convert.ToDouble(Execute_Trans_Reader.Item("LEDG_DEBIT"))
            OpnCr = OpnCr + Convert.ToDouble(Execute_Trans_Reader.Item("LEDG_CREDIT"))
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        If OpnDr > OpnCr Then
            lblOpnDr.Visible = True
            lblOpnDebit.Visible = True
            lblOpnDebit.Text = Val(OpnDr) - Val(OpnCr)
            lblDebit.Text = Val(lblDebit.Text) + Val(lblOpnDebit.Text)
            lblOpnCr.Visible = False
            lblOpnCredit.Visible = False
        Else
            lblOpnCr.Visible = True
            lblOpnCredit.Visible = True
            lblOpnCredit.Text = Val(OpnCr) - Val(OpnDr)
            lblCredit.Text = Val(lblCredit.Text) + Val(lblOpnCredit.Text)
            lblOpnDr.Visible = False
            lblOpnDebit.Visible = False
        End If

        Me.DrDataSet.Clear()
        dgDebit.DataSource = Nothing
        ExecuteSqlQuery(SqlDataAdapt, Me.DrDataSet, "SELECT * FROM " & Trim(MyTable) & " WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTo.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") AND (LEDG_DEBIT > 0) ORDER BY LEDG_DATE, LEDG_TRAN_ID", Trim(MyTable), Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            lblDebit.Text = Val(lblDebit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("LEDG_DEBIT"))
        End While
        dgDebit.DataSource = Me.DrDataSet
        dgDebit.DataMember = Trim(MyTable)
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        Me.CrDataSet.Clear()
        ExecuteSqlQuery(SqlDataAdapt, Me.CrDataSet, "SELECT * FROM " & Trim(MyTable) & " WHERE LEDG_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpFrom.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND LEDG_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTo.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & Acc_ID & ") AND (LEDG_CREDIT > 0) ORDER BY LEDG_DATE, LEDG_TRAN_ID", Trim(MyTable), Connection)
        Execute_Trans_Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            lblCredit.Text = Val(lblCredit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("LEDG_CREDIT"))
        End While
        dgCredit.DataSource = Me.CrDataSet
        dgCredit.DataMember = Trim(MyTable)
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()

        txtCloCr.Text = 0
        txtCloDr.Text = 0

        If Val(lblDebit.Text) > Val(lblCredit.Text) Then
            lblCloCr.Visible = True
            txtCloCr.Visible = True
            lblCloDr.Visible = False
            txtCloDr.Visible = False
            txtCloCr.Text = Val(lblDebit.Text) - Val(lblCredit.Text)
        Else
            lblCloDr.Visible = True
            txtCloDr.Visible = True
            lblCloCr.Visible = False
            txtCloCr.Visible = False
            txtCloDr.Text = Val(lblCredit.Text) - Val(lblDebit.Text)
        End If

    End Sub

    Private Sub ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton.Click
        If Len(Me.ToolStripComboBox.Text) > 0 Then
            Acc_ID = Get_Account_ID(Me.ToolStripComboBox.Text.Trim)
            Call Show_Journal_Transactions()
            lblAccTitle.Text = Me.ToolStripComboBox.Text.Trim & " Ledger"
        Else
            lblOpnCr.Visible = False
            lblOpnCredit.Visible = False
            lblOpnDr.Visible = False
            lblOpnDebit.Visible = False
            txtCloCr.Visible = False
            txtCloDr.Visible = False
            lblCloCr.Visible = False
            lblCloDr.Visible = False
            MsgBox("Please Select Account Head for View Ledger.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If
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

    Private Sub frmClosLedgers_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Text = "T - Closed Ledgers"
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gblReportOption = "CLOSED_LEDGERS"
        fromDate = DateTime.Parse(dtpFrom.Value.ToShortDateString)
        toDate = DateTime.Parse(dtpTo.Value.ToShortDateString)
        gblReportName = ".\" & "Reports\Ledger.rpt"
        If lblOpnDebit.Visible = True Then intOpnDr = Val(lblOpnDebit.Text) Else intOpnDr = 0
        If lblOpnCredit.Visible = True Then intOpnCr = Val(lblOpnCredit.Text) Else intOpnCr = 0
        gblFind = Acc_ID
        frmAccReports.MdiParent = frmMain
        frmAccReports.Show()
    End Sub
End Class