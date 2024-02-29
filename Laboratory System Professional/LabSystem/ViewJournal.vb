Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D

Public Class ViewJournal
#Region "GLOBAL VARIABLES"
    Dim TransDate As Date = DateTime.Now
    Dim ToDate As Date = DateTime.Now
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Execute_Trans_Reader As SqlDataReader
#End Region
#Region "FORM DESIGN"
    Private Sub HdrPicBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles HdrPicBox.Paint

        'Dim g As Graphics = e.Graphics
        'Dim rect As Rectangle
        'rect = HdrPicBox.ClientRectangle()
        'Dim fnt = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        'Dim lgb As New LinearGradientBrush(rect, Color.CornflowerBlue, Color.AliceBlue, LinearGradientMode.Vertical)
        'g.FillRectangle(lgb, 0, 0, HdrPicBox.Width, HdrPicBox.Height)
        'g.DrawString("Journal Transactions", fnt, Brushes.AliceBlue, 8, 8)

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
        Me.Close()
    End Sub

    Private Sub frmViewTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        Me.Text = My.Application.Info.ProductName
        'Dim G As Graphics
        'Dim rect As Rectangle
        'G = GetGraphicsObject()
        'rect = New Rectangle(0, 0, Me.Width - 3, Me.Height - 3)
        'Dim grdForm As New LinearGradientBrush(rect, Color.WhiteSmoke, Color.LightGray, LinearGradientMode.Vertical)
        'G.FillRectangle(grdForm, 0, 0, Me.Width - 3, Me.Height - 3)

        dtpToDate.Value = DateAdd(DateInterval.Day, -1, Date.Now)
        dtpTransaction.Value = Date.Now

        TransDate = dtpTransaction.Value
        ToDate = dtpToDate.Value
        Connection.Close()

    End Sub
#End Region

#Region "JOURNAL ENTRIES PROCEDURES"

    Private Sub Show_Journal_Transactions()

        Me.TransactionDataSet.Clear()
        JournalGrid.DataSource = Nothing
        ExecuteSqlQuery(SqlDataAdapter, Me.TransactionDataSet, "SELECT * FROM GENERAL_JOURNAL WHERE GEN_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransaction.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) AND GEN_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpToDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102) ORDER BY GEN_DATE, GEN_TRAN_ID, GEN_ACC_TYPE DESC", "GENERAL_JOURNAL", Connection)
        Execute_Trans_Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Execute_Trans_Reader.Read
            txtTotCredit.Text = Val(txtTotCredit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("GEN_CREDIT"))
            txtTotDebit.Text = Val(txtTotDebit.Text) + Convert.ToDouble(Execute_Trans_Reader.Item("GEN_DEBIT"))
        End While
        If Not Execute_Trans_Reader Is Nothing Then Execute_Trans_Reader.Close()
        JournalGrid.DataSource = Me.TransactionDataSet
        JournalGrid.DataMember = "GENERAL_JOURNAL"

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
        If Me.WindowState = FormWindowState.Minimized Then Me.Text = "View General Journal" Else Me.Text = My.Application.Info.ProductName
    End Sub

End Class