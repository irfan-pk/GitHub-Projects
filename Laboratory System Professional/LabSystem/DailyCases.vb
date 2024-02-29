Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DailyCases
    Public StrFilter, CaseString, TestID, RcpFilter As String
    Dim MasterDetail As MasterControl
    Dim PatientAdapter As New SqlDataAdapter()
    Dim ReceiptAdapter As New SqlDataAdapter()
    Dim GridColor As Color
    Dim Tot, Disc, Paid, Due, Rcv, Comp, Dele As Double
    Dim DailyReader, SumReader As SqlDataReader
    Dim objCellStyle As New DataGridViewCellStyle()

    Private Sub frmDailyCases_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        Me.frmBindingSource.Dispose()
    End Sub

    Private Sub DailyCases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        txtToDate.Value = Date.Now
        txtDate.Value = Date.Now
        Dim strSql As String = "SELECT * from USERS ORDER BY USERNAME"

        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, strSql, "USERS", Connection)
        SqlDataAdapter.Fill(SqlDataSet, "USERS")
        DailyReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While DailyReader.Read
            Me.ToolStripComboBox.Items.Add(DailyReader.Item("USERNAME").ToString.Trim)
        End While
        If Not DailyReader Is Nothing Then DailyReader.Close()

        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "Select CP_ID, CP_NAME from CollectionPoint WHERE CP_NAME LIKE '%CP%' order by CP_ID", "CollectionPoint", Connection)
        SqlDataAdapter.Fill(SqlDataSet, "COLLECTIONPOINT")
        DailyReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While DailyReader.Read
            Me.cmbCollPoint.Items.Add(DailyReader.Item("CP_NAME").ToString.Trim)
        End While
        If Not DailyReader Is Nothing Then DailyReader.Close()

        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "Select visitor_name from visitor_table order by visitor_name", "visitor_table", Connection)
        SqlDataAdapter.Fill(SqlDataSet, "VISITOR_TABLE")
        DailyReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While DailyReader.Read
            Me.cmbVisitor.Items.Add(DailyReader.Item("VISITOR_NAME").ToString.Trim)
        End While
        If Not DailyReader Is Nothing Then DailyReader.Close()

        Connection.Close()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub LoadByFilter(ByVal FilterCriteria As String)

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
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, FilterCriteria, "PATIENT", Connection)
            SqlDataAdapter.Fill(Me.frmDataSet, "PATIENT")
            SumReader = SqlDataAdapter.SelectCommand.ExecuteReader
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
            Call ClearFields()
            LabDataSet.Clear()
            Execute_DatabaseTable_Query(PatientAdapter, FilterCriteria, Connection)
            PatientAdapter.Fill(LabDataSet, "PATIENT")
            Execute_DatabaseTable_Query(ReceiptAdapter, RcpFilter, Connection)
            ReceiptAdapter.Fill(LabDataSet, "RECEIPT")
            Call CreateMasterChildView()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Sub CreateMasterChildView()
        MasterDetail = New MasterControl(LabDataSet)
        Panel.Controls.Add(MasterDetail)
        MasterDetail.setParentSource(LabDataSet.Tables("PATIENT").TableName, "p_num")
        MasterDetail.childView.Add(LabDataSet.Tables("RECEIPT").TableName, "Test Detail")
    End Sub

    Sub ClearFields()
        Panel.Controls.Clear()
        MasterDetail = Nothing
        Refresh()
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
                If Me.ToolStripComboBox.Text.ToUpper = "ALL" Then StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102))"
                If Me.ToolStripComboBox.Text.ToUpper <> "ALL" Then StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_OPERATOR = '" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "')"

            Case "DUES"
                If Me.ToolStripComboBox.Text.ToUpper = "ALL" Then StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUES > 0)"
                If Me.ToolStripComboBox.Text.ToUpper <> "ALL" Then StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUES > 0) AND (P_OPERATOR = '" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "')"

            Case "CLEARED"
                If Me.ToolStripComboBox.Text.Trim = "ALL" Then StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUES = 0)"
                If Me.ToolStripComboBox.Text.Trim <> "ALL" Then StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUES = 0) AND (P_OPERATOR = '" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "')"
                GridColor = Color.PaleGreen
            Case "DELETED"
                StrFilter = "SELECT * FROM PATIENT WHERE (P_DELETE_ON >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DELETE_ON <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DELETE > 0)"

            Case "COMPLIMENTARY"
                StrFilter = "SELECT * FROM PATIENT WHERE (P_COMP_ON >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_COMP_ON <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_COMPLIMENT > 0)"

            Case "RECEIVED"
                If Me.ToolStripComboBox.Text.ToUpper = "ALL" Then StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DUE_RCV_DATE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV_DATE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV > 0)"
                If Me.ToolStripComboBox.Text.ToUpper <> "ALL" Then StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DUE_RCV_DATE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV_DATE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DUE_RCV > 0) AND (P_DUE_RCV_OPERATOR = '" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "')"
                GridColor = Color.GreenYellow
            Case "VISITOR"
                StrFilter = "SELECT P_NUM, P_SNO, P_NAME, P_AGE, P_SEX, P_CP, P_TOTAL, P_PAID, P_DISCOUNT, P_DUES, P_COMPLIMENT, P_DATE_SAMPLE FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (P_VISITOR = '" & StrConv(Me.cmbVisitor.Text.Trim, VbStrConv.Uppercase) & "')"

        End Select
        RcpFilter = "SELECT DISTINCT TCASENO, TCODE, TNAME, TCATG FROM RECEIPT WHERE (TDATE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "yyyy-MM-dd") & " 00:00:00',102)) AND (TDATE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "yyyy-MM-dd") & " 00:00:00',102))"
        Call LoadByFilter(StrFilter)
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
        Call LoadByFilter(StrFilter)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim findName As String = Microsoft.VisualBasic.InputBox("Please write patient name to find.", "Find Patient", "")
        If Len(findName) = 0 Then Exit Sub
        StrFilter = "SELECT * FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "MM/dd/yyyy") & " 00:00:00',102)) AND (p_name LIKE '%" & findName.Trim.ToString & "%')"
        RcpFilter = "SELECT * FROM RECEIPT WHERE (TDATE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "MM/dd/yyyy") & " 00:00:00',102))"
        Call LoadByFilter(StrFilter)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim findName As String = Microsoft.VisualBasic.InputBox("Please write refer name to find.", "Find Patient", "")
        If Len(findName) = 0 Then Exit Sub
        StrFilter = "SELECT * FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "MM/dd/yyyy") & " 00:00:00',102)) AND ((p_ref_by LIKE '%" & findName.Trim.ToString & "%') OR (p_refer_2 LIKE '%" & findName.Trim.ToString & "%'))"
        RcpFilter = "SELECT * FROM RECEIPT WHERE (TDATE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "MM/dd/yyyy") & " 00:00:00',102))"
        Call LoadByFilter(StrFilter)
    End Sub

    Private Sub ByPhilebotomistsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByPhilebotomistsToolStripMenuItem.Click
        CaseString = "VISITOR"
        Call Query_Decision()
    End Sub
End Class