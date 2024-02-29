Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmSTDailyCases
    Public StrFilter, CaseString, TestID As String
    Dim GridColor As Color
    Dim Tot, Disc, Paid, Due, Rcv, Comp, Dele As Double
    Dim DailyReader, SumReader As SqlDataReader
    Dim objCellStyle As New DataGridViewCellStyle()

    Private Sub frmSTDailyCases_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        Me.frmBindingSource.Dispose()
    End Sub

    Private Sub frmDailyCases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        txtToDate.Value = Date.Now
        txtDate.Value = Date.Now
        Dim strSql As String = "SELECT * from USERS ORDER BY USERNAME"

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "USERS", Connection)
        SqlDataAdapt.Fill(SqlDataSet, "USERS")
        DailyReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While DailyReader.Read
            Me.ToolStripComboBox.Items.Add(DailyReader.Item("USERNAME").ToString.Trim)
        End While
        If Not DailyReader Is Nothing Then DailyReader.Close()

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "SELECT * FROM COLLECTIONPOINT ORDER BY CP_ID", "COLLECTIONPOINT", Connection)
        SqlDataAdapt.Fill(SqlDataSet, "COLLECTIONPOINT")
        DailyReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While DailyReader.Read
            Me.cmbCollPoint.Items.Add(DailyReader.Item("CP_ID").ToString.Trim)
        End While
        If Not DailyReader Is Nothing Then DailyReader.Close()

        Connection.Close()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub LoadByFilter(ByVal FilterCriteria As String, ByVal RowColor As Color)

        If FilterCriteria Is Nothing Then MsgBox("No query Selected for Records.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Try
            Tot = 0
            Paid = 0
            Disc = 0
            Due = 0
            Comp = 0
            SqlDataSet.Clear()
            Me.frmDataSet.Clear()
            If Me.cmbCollPoint.Text.Trim = "ALL" Then
                FilterCriteria = FilterCriteria & " ORDER BY P_NUM"
            Else
                FilterCriteria = FilterCriteria & " AND (P_CP = '" & cmbCollPoint.Text.Trim & "') ORDER BY P_NUM"
            End If
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, FilterCriteria, "PATIENT_ST", Connection)
            SqlDataAdapt.Fill(Me.frmDataSet, "PATIENT_ST")
            SumReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While SumReader.Read
                Tot = Tot + Val(SumReader.Item("P_TOTAL"))
                Paid = Paid + Val(SumReader.Item("P_PAID"))
                Disc = Disc + Val(SumReader.Item("P_DISCOUNT"))
                Due = Due + Val(SumReader.Item("P_DUES"))
                Comp = Comp + Val(SumReader.Item("P_COMPLIMENT"))
            End While
            If Not SumReader Is Nothing Then SumReader.Close()
            Me.stTotal.Text = Tot.ToString
            Me.stPaid.Text = Paid.ToString
            Me.stDiscount.Text = Disc.ToString
            Me.stDues.Text = Due.ToString
            Me.stComp.Text = Comp.ToString
            Me.frmBindingSource.DataSource = Me.frmDataSet
            Me.frmBindingSource.DataMember = "PATIENT_ST"
            Me.frmDataGrid.RefreshEdit()
            objCellStyle.BackColor = RowColor
            Me.frmDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub DuesCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuesCasesToolStripMenuItem.Click
        CaseString = "DUES"
        Call Query_Decision()
    End Sub

    Private Sub DuesReceivedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuesReceivedToolStripMenuItem.Click
        CaseString = "RECEIVED"
        Call Query_Decision()
    End Sub

    Private Sub ClearedCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearedCasesToolStripMenuItem.Click
        CaseString = "CLEARED"
        Call Query_Decision()
    End Sub

    Private Sub DeletedCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletedCasesToolStripMenuItem.Click
        CaseString = "DELETED"
        Call Query_Decision()
    End Sub

    Private Sub ComplimentaryCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplimentaryCasesToolStripMenuItem.Click
        CaseString = "COMPLIMENTARY"
        Call Query_Decision()
    End Sub

    Private Sub AllCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCasesToolStripMenuItem.Click
        CaseString = "ALL"
        Call Query_Decision()
    End Sub

    Private Sub Query_Decision()
        Select Case CaseString
            Case "ALL"
                If Me.ToolStripComboBox.Text.ToUpper = "ALL" Then StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102))"
                If Me.ToolStripComboBox.Text.ToUpper <> "ALL" Then StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_OPERATOR = '" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "')"
                GridColor = Color.WhiteSmoke
            Case "DUES"
                If Me.ToolStripComboBox.Text.ToUpper = "ALL" Then StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUES > 0)"
                If Me.ToolStripComboBox.Text.ToUpper <> "ALL" Then StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUES > 0) AND (P_OPERATOR = '" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "')"
                GridColor = Color.MistyRose
            Case "CLEARED"
                If Me.ToolStripComboBox.Text.Trim = "ALL" Then StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUES = 0)"
                If Me.ToolStripComboBox.Text.Trim <> "ALL" Then StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUES = 0) AND (P_OPERATOR = '" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "')"
                GridColor = Color.PaleGreen
            Case "DELETED"
                StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DELETE_ON >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DELETE_ON <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DELETE > 0)"
                GridColor = Color.MistyRose
            Case "COMPLIMENTARY"
                StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_COMP_ON >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_COMP_ON <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_COMPLIMENT > 0)"
                GridColor = Color.Wheat
            Case "RECEIVED"
                If Me.ToolStripComboBox.Text.ToUpper = "ALL" Then StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DUE_RCV_DATE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV_DATE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV > 0)"
                If Me.ToolStripComboBox.Text.ToUpper <> "ALL" Then StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DUE_RCV_DATE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV_DATE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV > 0) AND (P_DUE_RCV_OPERATOR = '" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "')"
                GridColor = Color.GreenYellow
        End Select
        Call LoadByFilter(StrFilter, GridColor)
    End Sub

    Private Sub ToolStripMenuItemAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemAll.Click
        Call AllCasesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItemNonDues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemNonDues.Click
        Call ClearedCasesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItemDues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemDues.Click
        Call DuesCasesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItemDuesReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemDuesReceived.Click
        Call DuesReceivedToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemDelete.Click
        Call DeletedCasesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItemComplimentary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemComplimentary.Click
        Call ComplimentaryCasesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripShowButton.Click
        If CaseString = "" Then CaseString = "ALL"
        Call Query_Decision()
        Call LoadByFilter(StrFilter, GridColor)
        Call Sub_Details()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim findName As String = InputBox("Please write patient name to find.", "Find Patient", "")
        If Len(findName) = 0 Then Exit Sub
        StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "MM/dd/yyyy") & " 00:00:00',102)) AND (p_name LIKE '%" & findName.Trim.ToString & "%')"
        Call LoadByFilter(StrFilter, Color.WhiteSmoke)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim findName As String = InputBox("Please write patient name to find.", "Find Patient", "")
        If Len(findName) = 0 Then Exit Sub
        StrFilter = "SELECT * FROM PATIENT_ST WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "MM/dd/yyyy") & " 00:00:00',102)) AND ((p_ref_by LIKE '%" & findName.Trim.ToString & "%') OR (p_refer_2 LIKE '%" & findName.Trim.ToString & "%'))"
        Call LoadByFilter(StrFilter, Color.WhiteSmoke)
    End Sub

    Private Sub Sub_Details()

        If frmDataGrid.RowCount = 0 Then RcptDataSet.Clear() : Exit Sub
        If frmDataGrid.Rows(frmDataGrid.CurrentRow.Index).Cells(0).Value Is Nothing Then RcptDataSet.Clear() : Exit Sub
        TestID = DirectCast(Me.frmBindingSource.Current, DataRowView).Item("P_NUM").ToString
        Execute_DatabaseTable_Query(SqlDataAdapt, "SELECT * FROM RECEIPT_ST WHERE TCASENO = " & Val(TestID), Connection)
        RcptDataSet.Clear()
        SqlDataAdapt.Fill(RcptDataSet, "RECEIPT_ST")
        RcptBindingSource.DataSource = RcptDataSet
        RcptBindingSource.DataMember = "RECEIPT_ST"
        Connection.Close()

    End Sub

    Private Sub frmDataGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then Call Sub_Details()
    End Sub

    Private Sub frmDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles frmDataGrid.CellContentClick
        Call Sub_Details()
    End Sub

    Private Sub frmDataGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmDataGrid.Click
        Call Sub_Details()
    End Sub

    Private Sub frmDataGrid_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles frmDataGrid.KeyDown
        If e.KeyCode = Keys.Down Then Call Sub_Details()
    End Sub

    Private Sub frmDataGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles frmDataGrid.KeyUp
        If e.KeyCode = Keys.Up Then Call Sub_Details()
    End Sub

End Class