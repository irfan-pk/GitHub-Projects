Imports System.Data.SqlClient
Imports System.IO

Public Class CustomerReports
    Dim currentpath As String = Directory.GetCurrentDirectory()

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click

        If rdAllCust.Checked = True Then
            RptUser = "ALL"
        End If
        If rdSelCust.Checked = True Then
            If cmbCustName.Text = String.Empty Then gblMessage = "Invalid customer selection." : MsgStatus.ShowDialog(Me) : Exit Sub
            RptUser = Mid(cmbCustName.Text.Trim, 1, 4)
        End If
        FromDate = DateFrom.Value
        If rdDetail.Checked = True Then gblReportOption = "DETAIL" : gblReportName = currentpath & "\" & "Reports\CustomerDetail.rpt"
        If rdLedger.Checked = True Then gblReportOption = "LEDGER" : gblReportName = currentpath & "\" & "Reports\CustomerLedger.rpt"
        Reports.MdiParent = Main
        Reports.Show()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        SqlDataSet.Clear()
        Me.Close()
    End Sub

    Private Sub frmCustomerReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        rdAllCust.Checked = True
        rdDetail.Checked = True
        Dim FillCombo As String = "SELECT * FROM CUSTOMERS ORDER BY CUST_CODE"
        ExecuteAdapterQuery(SqlDataAdapter, FillCombo, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                cmbCustName.Items.Add(Reader.Item("CUST_CODE").ToString & "-" & Reader.Item("CUST_NAME").ToString)
            End While
        End If
    End Sub

    Private Sub rdSelCust_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rdSelCust.MouseClick
        If rdSelCust.Checked = True Then
            cmbCustName.Enabled = True
        Else
            cmbCustName.Enabled = False
        End If
    End Sub

    Private Sub rdAllCust_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rdAllCust.MouseClick
        If rdAllCust.Checked = True Then
            cmbCustName.Enabled = False
        Else
            cmbCustName.Enabled = True
        End If
    End Sub
End Class