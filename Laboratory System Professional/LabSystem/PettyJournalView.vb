Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D

Public Class PettyJournalView

#Region "GLOBAL VARIABLES"
    Dim TransDate As Date = DateTime.Now
    Dim ToDate As Date = DateTime.Now
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
        Me.Close()
    End Sub

    Private Sub frmViewTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Me.Text = My.Application.Info.ProductName
        dtpToDate.Value = Date.Now
        dtpTransaction.Value = Date.Now
        TransDate = dtpTransaction.Value
        ToDate = dtpToDate.Value
        Connection.Close()
    End Sub
#End Region

#Region "JOURNAL ENTRIES PROCEDURES"

    Private Sub Show_Journal_Transactions()

        Me.TransactionDataSet.Clear()
        Me.txtTotCredit.Clear()
        Me.txtTotDebit.Clear()
        JournalGrid.DataSource = Nothing
        ExecuteSqlQuery(SqlDataAdapter, Me.TransactionDataSet, "SELECT * FROM PETTY_JOURNAL WHERE P_TRAN_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND P_TRAN_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpToDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) ORDER BY P_TRAN_DATE, P_TRAN_ID, P_ACC_TYPE DESC", "PETTY_JOURNAL", Connection)
        Execute_Trans_Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            txtTotCredit.Text = Val(txtTotCredit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("P_CREDIT"))
            txtTotDebit.Text = Val(txtTotDebit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("P_DEBIT"))
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()
        JournalGrid.DataSource = Me.TransactionDataSet
        JournalGrid.DataMember = "PETTY_JOURNAL"

    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Call Show_Journal_Transactions()
    End Sub

    Private Sub cmdView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmdView.KeyDown
        If e.KeyCode = Keys.Enter Then Call Show_Journal_Transactions()
    End Sub

#End Region

#Region "GRID FORMATTING PROCEDURE"

    Private Sub JournalGrid_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If JournalGrid.Columns(e.ColumnIndex).Name = "colCredit" Then
            If e.Value = 0 Then e.CellStyle.ForeColor = Color.LightBlue
            'If e.Value > 0 Then e.CellStyle.BackColor = Color.LimeGreen Else e.CellStyle.ForeColor = Color.White
        End If
        If JournalGrid.Columns(e.ColumnIndex).Name = "colDebit" Then
            If e.Value = 0 Then e.CellStyle.ForeColor = Color.LightBlue
            'If e.Value > 0 Then e.CellStyle.BackColor = Color.LimeGreen Else e.CellStyle.ForeColor = Color.White
        End If
    End Sub

#End Region

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Len(gblQueryText) = 0 Then Exit Sub
        Execute_DatabaseTable_Query(SqlDataAdapter, gblQueryText, Connection)
        Call Show_Journal_Transactions()
    End Sub

    Private Sub frmViewTransactions_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then Me.Text = "View Petty Journal" Else Me.Text = My.Application.Info.ProductName
    End Sub
End Class