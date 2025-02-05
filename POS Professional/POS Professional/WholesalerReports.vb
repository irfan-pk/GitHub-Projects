Imports System.IO
Imports System.Data.SqlClient

Public Class WholesalerReports

    Dim currentpath As String = Directory.GetCurrentDirectory()

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click

        If rdAllSaler.Checked = True Then
            RptUser = "ALL"
        End If
        If rdSelSaler.Checked = True Then
            If cmbCustName.Text = "" Then gblMessage = "Invalid wholesaler selection." : MsgStatus.ShowDialog(Me) : Exit Sub
            RptUser = Mid(cmbCustName.Text.Trim, 1, 4)
        End If
        FromDate = DateFrom.Value
        If rdWDetail.Checked = True Then gblReportOption = "WDETAIL" : gblReportName = currentpath & "\" & "Reports\WholesalerDetail.rpt"
        If rdWLedger.Checked = True Then gblReportOption = "WLEDGER" : gblReportName = currentpath & "\" & "Reports\WholesalerLedger.rpt"
        Reports.MdiParent = Main
        Reports.Show()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        SqlDataSet.Clear()
        Me.Close()
        WholesalersMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub WholesalerReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub WholsalerReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        rdAllSaler.Checked = True
        rdWDetail.Checked = True
        Dim FillCombo As String = "SELECT * FROM SUPPLIERS ORDER BY SUPL_CODE"
        ExecuteAdapterQuery(SqlDataAdapter, FillCombo, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                cmbCustName.Items.Add(Reader.Item("SUPL_CODE").ToString & "-" & Reader.Item("SUPL_NAME").ToString)
            End While
            If Not Reader Is Nothing Then Reader.Close()
        End If
    End Sub

    Private Sub rdSelSaler_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdSelSaler.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rdSelSaler.Checked = True Then
                cmbCustName.Enabled = True
            Else
                cmbCustName.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdSelSaler_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rdSelSaler.MouseClick
        If rdSelSaler.Checked = True Then
            cmbCustName.Enabled = True
        Else
            cmbCustName.Enabled = False
        End If
    End Sub

    Private Sub rdAllSaler_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdAllSaler.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rdAllSaler.Checked = True Then
                cmbCustName.Enabled = False
            Else
                cmbCustName.Enabled = True
            End If
        End If
    End Sub

    Private Sub rdAllSaler_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rdAllSaler.MouseClick
        If rdAllSaler.Checked = True Then
            cmbCustName.Enabled = False
        Else
            cmbCustName.Enabled = True
        End If
    End Sub
End Class