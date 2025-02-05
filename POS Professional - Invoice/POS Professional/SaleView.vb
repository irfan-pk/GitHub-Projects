Imports System.IO
Imports System.Data.SqlClient

Public Class SaleView
    Dim MasterDetail As MasterControl
    Dim SaleMasterAdapter As New SqlDataAdapter()
    Dim SaleDetailAdapter As New SqlDataAdapter()
    Dim currentpath As String = Directory.GetCurrentDirectory()
    Dim FindbyQuery As Boolean
    Dim Total, Paid, Discount, Credit, Final As Double
    Dim MasterQuery, ChildQuery As String
    Dim DetailsDataAdapter As SqlDataAdapter
    Dim MasterDataAdapter As SqlDataAdapter
    Dim Choice, Cust_ID, Description As String

    Private Sub SaleView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        DotNetBarTabcontrol.SelectTab(0)
        Panel1.Controls.Add(MasterDetail)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab1)
    End Sub

    Private Sub Popup_SaleData(ByVal TabChoice As String, ByVal TabDate As DateTimePicker)
        'For Sale Master Table
        If TabChoice = "CashSale" Then MasterQuery = "SELECT SaleID, SaleType, CustomerID, CustomerName, SaleGross, SaleDiscount, SaleTotal, SalePaid, SaleCredit, SaleRecovery, SaleReturn, DrawerName  FROM SALE_MASTER WHERE SaleCredit = 0 AND SaleReturn = 0 AND DateCompleted = N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY LEFT(SALEID,3), CONVERT(INT, RIGHT(SALEID, LEN(SALEID)-3))"
        If TabChoice = "CreditSale" Then MasterQuery = "SELECT SaleID, SaleType, CustomerID, CustomerName, SaleGross, SaleDiscount, SaleTotal, SalePaid, SaleCredit, SaleRecovery, SaleReturn, DrawerName FROM SALE_MASTER WHERE SaleCredit > 0 AND DateCompleted = N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY LEFT(SALEID,3), CONVERT(INT, RIGHT(SALEID, LEN(SALEID)-3))"
        If TabChoice = "SaleRecovery" Then MasterQuery = "SELECT SaleID, SaleType, CustomerID, CustomerName, SaleGross, SaleDiscount, SaleTotal, SalePaid, SaleCredit, SaleRecovery, SaleReturn, DrawerName FROM SALE_MASTER WHERE SaleRecovery > 0 AND DateRecovery = N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY LEFT(SALEID,3), CONVERT(INT, RIGHT(SALEID, LEN(SALEID)-3))"
        If TabChoice = "ReturnSale" Then MasterQuery = "SELECT SaleID, SaleType, CustomerID, CustomerName, SaleGross, SaleDiscount, SaleTotal, SalePaid, SaleCredit, SaleRecovery, SaleReturn, DrawerName FROM SALE_MASTER WHERE SaleStatus = 'RETURN' AND DateCompleted = N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY LEFT(SALEID,3), CONVERT(INT, RIGHT(SALEID, LEN(SALEID)-3))"

        'For Items Detail
        ChildQuery = "SELECT * FROM sale_detail where DetailDate = N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY DetailID"

        MasterChildDataSet.Clear()
        ExecuteAdapterQuery(SaleMasterAdapter, MasterQuery, Connection)
        SaleMasterAdapter.Fill(MasterChildDataSet, "sale_master")
        ExecuteAdapterQuery(SaleDetailAdapter, ChildQuery, Connection)
        SaleDetailAdapter.Fill(MasterChildDataSet, "sale_detail")
        Call CreateMasterChildView()

    End Sub

    Sub CreateMasterChildView()
        MasterDetail = New MasterControl(MasterChildDataSet)
        MasterDetail.setParentSource(MasterChildDataSet.Tables("sale_master").TableName, "SaleID")
        MasterDetail.childView.Add(MasterChildDataSet.Tables("sale_detail").TableName, "Items Detail")
    End Sub

    Private Sub cmdViewTab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewTab1.Click
        DotNetBarTabcontrol.SelectTab(0)
        Panel1.Controls.Add(MasterDetail)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab1)
    End Sub

    Private Sub cmdViewTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewTab2.Click
        DotNetBarTabcontrol.SelectTab(1)
        Panel2.Controls.Add(MasterDetail)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab2)
    End Sub

    Private Sub DotNetBarTabcontrol_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DotNetBarTabcontrol.SelectedIndexChanged
        'Selected Tabpage one
        If DotNetBarTabcontrol.SelectedIndex = 0 Then Call cmdViewTab1_Click(sender, e)
        'Selected Tabpage two
        If DotNetBarTabcontrol.SelectedIndex = 1 Then Call cmdViewTab2_Click(sender, e)
        'Selected Tabpage three
        If DotNetBarTabcontrol.SelectedIndex = 2 Then Call cmdViewTab3_Click(sender, e)
        'Selected Tabpage four
        If DotNetBarTabcontrol.SelectedIndex = 3 Then Call cmdViewTab4_Click(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub cmdViewTab3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewTab3.Click
        DotNetBarTabcontrol.SelectTab(2)
        Panel3.Controls.Add(MasterDetail)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub cmdViewTab4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewTab4.Click
        DotNetBarTabcontrol.SelectTab(3)
        Panel4.Controls.Add(MasterDetail)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab4)
    End Sub

    Private Sub dgMasterInfo1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'write down amount received procedure for concerned record
    End Sub

    Private Sub cmdFindTab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindTab1.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to find", "Find Sale Invoice")
        If IsNumeric(SaleInvoice) Or SaleInvoice.Trim = String.Empty Then Exit Sub
        If Len(SaleInvoice.Trim) > 0 Then
            FindbyQuery = True
            gblFind = SaleInvoice.Trim
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab1)
        End If
    End Sub

    Private Sub cmdFindTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindTab2.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to find", "Find Sale Invoice")
        If IsNumeric(SaleInvoice) Or SaleInvoice.Trim = String.Empty Then Exit Sub
        If Len(SaleInvoice.Trim) > 0 Then
            FindbyQuery = True
            gblFind = SaleInvoice.Trim
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab2)
        End If
    End Sub

    Private Sub cmdFindTab3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindTab3.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to find", "Find Sale Invoice")
        If IsNumeric(SaleInvoice) Or SaleInvoice.Trim = String.Empty Then Exit Sub
        If Len(SaleInvoice.Trim) > 0 Then
            FindbyQuery = True
            gblFind = SaleInvoice.Trim
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab3)
        End If
    End Sub

    Private Sub cmdFindTab4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindTab4.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to find", "Find Sale Invoice")
        If IsNumeric(SaleInvoice) Or SaleInvoice.Trim = String.Empty Then Exit Sub
        If Len(SaleInvoice.Trim) > 0 Then
            FindbyQuery = True
            gblFind = SaleInvoice.Trim
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, dtDateTab4)
        End If
    End Sub

    Private Function CheckRecordExists(ByVal strFind As String, ByVal tblName As String, ByVal strField As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & "; User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("SELECT * FROM " & tblName.Trim & " WHERE (" & strField.Trim & " = N'" & strFind.Trim & "')")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using
        Return bRet
    End Function

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        gblReportOption = "STATEMENT"
        FromDate = dtFromDate.Value
        ToDate = dtToDate.Value
        If rdDaily.Checked = True Then gblReportFilter = "CASH" : gblReportName = currentpath & "\" & "Reports\CashSummary.rpt"
        If rdCredit.Checked = True Then gblReportFilter = "CREDIT" : gblReportName = currentpath & "\" & "Reports\CreditSummary.rpt"
        If rdRecovery.Checked = True Then gblReportFilter = "RECOVERY" : gblReportName = currentpath & "\" & "Reports\RecoverySummary.rpt"
        If rdReturn.Checked = True Then gblReportFilter = "RETURN" : gblReportName = currentpath & "\" & "Reports\SaleReturnSummary.rpt"
        If rdCreditList.Checked = True Then gblReportFilter = "CRLIST" : gblReportName = currentpath & "\" & "Reports\CreditDetail.rpt"
        SummaryReports.MdiParent = Main
        SummaryReports.Show()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

End Class