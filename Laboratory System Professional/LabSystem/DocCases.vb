Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DocCases
    Public StrFilter, CaseString As String
    Dim GridColor As Color
    Dim TotCases, Tot, Disc, Paid, Due, Rcv, Comp, Dele As Double
    Dim DailyReader, SumReader As SqlDataReader
    Dim objCellStyle As New DataGridViewCellStyle()

    Private Sub frmDocCases_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        Me.frmBindingSource.Dispose()
    End Sub

    Private Sub frmDocCases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        Dim DocNameText As String = "Select * from CollectionPoint"
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, DocNameText, "CollectionPoint", Connection)
        SqlDataAdapter.Fill(SqlDataSet, "CollectionPoint")
        SumReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While SumReader.Read
            ToolStripComboBox.Items.Add(SumReader.Item("CP_NAME"))
        End While
        txtDate.Value = Now
        txtToDate.Value = Now
        Me.WindowState = FormWindowState.Maximized
        Me.ToolStripComboBox.Focus()

    End Sub
    Private Sub LoadByFilter()
        Try
            Tot = 0
            Paid = 0
            Disc = 0
            Due = 0
            TotCases = 0
            SqlDataSet.Clear()
            Me.frmDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(txtDate.Value, "MM/dd/yyyy") & " 00:00:00',102)) AND (P_DATE_SAMPLE <= CONVERT(DATETIME,'" & Format(txtToDate.Value, "MM/dd/yyyy") & " 00:00:00',102)) AND (P_CP LIKE '%" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "%' or P_REF_BY LIKE '%" & StrConv(Me.ToolStripComboBox.Text.Trim, VbStrConv.Uppercase) & "%')"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "PATIENT", Connection)
            SqlDataAdapter.Fill(Me.frmDataSet, "PATIENT")
            SumReader = SqlDataAdapter.SelectCommand.ExecuteReader
            While SumReader.Read
                TotCases = TotCases + 1
                Tot = Tot + Val(SumReader.Item("P_TOTAL"))
                Paid = Paid + Val(SumReader.Item("P_PAID"))
                Disc = Disc + Val(SumReader.Item("P_DISCOUNT"))
                Due = Due + Val(SumReader.Item("P_DUES"))
            End While
            If Not SumReader Is Nothing Then SumReader.Close()
            Me.stTotal.Text = Tot.ToString
            Me.stPaid.Text = Paid.ToString
            Me.stDiscount.Text = Disc.ToString
            Me.stDues.Text = Due.ToString
            Me.stCases.Text = TotCases.ToString
            Me.frmBindingSource.DataSource = Me.frmDataSet
            Me.frmBindingSource.DataMember = "PATIENT"
            Me.frmDataGrid.RefreshEdit()
            objCellStyle.BackColor = Color.LightSkyBlue
            Me.frmDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub txtDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.ValueChanged
        'txtToDate.Value = txtDate.Value
    End Sub

    Private Sub ToolStripTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then Call LoadByFilter()
    End Sub

    Private Sub ToolStripShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripShowButton.Click
        Call LoadByFilter()
    End Sub
End Class