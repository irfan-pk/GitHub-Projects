Imports System.IO
Imports System.Data.SqlClient

Public Class TabViewSale
    Dim currentpath As String = Directory.GetCurrentDirectory()
    Dim FindbyQuery As Boolean
    Dim Total, Paid, Discount, Credit, Final As Double
    Dim MasterQuery, ChildQuery As String
    Dim DetailsDataAdapter As SqlDataAdapter
    Dim MasterDataAdapter As SqlDataAdapter
    Dim Choice, Cust_ID, Description As String

    Private Sub frmTabViewSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        DotNetBarTabcontrol.SelectTab(0)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab1)
    End Sub

    Private Sub Popup_SaleData(ByVal TabChoice As String, ByVal MasterObject As BindingSource, ByVal ChildObject As BindingSource, ByVal TabDate As DateTimePicker)

        If TabChoice = "CashSale" Then
            MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit = 0 AND SaleReturn = 0 AND DateCompleted >= N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY SaleID"
            ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit = 0 And SaleReturn = 0 And DateCompleted >= N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY sale_master.SaleID"
            If FindbyQuery = True Then
                MasterQuery = Nothing
                ChildQuery = Nothing
                MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit = 0 AND SaleReturn = 0 AND SaleID = " & Val(gblFind.Trim) & " ORDER BY SaleID"
                ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit = 0 And SaleReturn = 0 And SALE_MASTER.SaleID = " & Val(gblFind.Trim) & " ORDER BY sale_master.SaleID"
            End If
        End If

        If TabChoice = "CreditSale" Then
            MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit > 0 AND DateCompleted >= N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY SaleID"
            ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit > 0 And DateCompleted >= N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY sale_master.SaleID"
            If FindbyQuery = True Then
                MasterQuery = Nothing
                ChildQuery = Nothing
                MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit > 0 AND SaleID = " & Val(gblFind.Trim) & " ORDER BY SaleID"
                ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit > 0 AND SALE_MASTER.SaleID = " & Val(gblFind.Trim) & " ORDER BY sale_master.SaleID"
            End If
        End If

        If TabChoice = "SaleRecovery" Then
            MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleRecovery > 0 AND DateRecovery >= N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY SaleID"
            ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleRecovery > 0 And DateRecovery >= N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY sale_master.SaleID"
            If FindbyQuery = True Then
                MasterQuery = Nothing
                ChildQuery = Nothing
                MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleRecovery > 0 AND SaleID = " & Val(gblFind.Trim) & " ORDER BY SaleID"
                ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleRecovery > 0 AND SALE_MASTER.SaleID = " & Val(gblFind.Trim) & " ORDER BY sale_master.SaleID"
            End If
        End If

        If TabChoice = "ReturnSale" Then
            MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleReturn > 0 AND DateCompleted >= N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY SaleID"
            ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleReturn > 0 And DateCompleted >= N'" & Format(Date.Parse(TabDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY sale_master.SaleID"
            If FindbyQuery = True Then
                MasterQuery = Nothing
                ChildQuery = Nothing
                MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleReturn > 0 AND SaleID = " & Val(gblFind.Trim) & " ORDER BY SaleID"
                ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleReturn > 0 AND SALE_MASTER.SaleID = " & Val(gblFind.Trim) & " ORDER BY sale_master.SaleID"
            End If
        End If

        'Clear dataset before refill with data relation
        gblRecordDataSet.Clear()
        If gblRelation = True Then gblRecordDataSet.Relations.Remove("MasterDetail")

        ' Add data from the sale master table to the DataSet.
        MasterDataAdapter = _
            New SqlDataAdapter(MasterQuery, Connection)
        MasterDataAdapter.Fill(gblRecordDataSet, "SALE_MASTER")

        ' Add data from the sale detail table to the DataSet.
        DetailsDataAdapter = _
            New SqlDataAdapter(ChildQuery, Connection)
        DetailsDataAdapter.Fill(gblRecordDataSet, "SALE_DETAIL")

        ' Establish a relationship between the master and detail tables.
        Dim Relation As New DataRelation("MasterDetail", _
            gblRecordDataSet.Tables("SALE_MASTER").Columns("SaleID"), _
            gblRecordDataSet.Tables("SALE_DETAIL").Columns("SaleID"))
        gblRecordDataSet.Relations.Add(Relation)
        gblRelation = True

        ' Bind the hold master data connector to the hold detail table.
        MasterObject.DataSource = gblRecordDataSet
        MasterObject.DataMember = "SALE_MASTER"

        ' Bind the details data connector to the master data connector,
        ' using the DataRelation name to filter the information in the 
        ' details table based on the current row in the master table. 
        ChildObject.DataSource = MasterBindingSource
        ChildObject.DataMember = "MasterDetail"
        FindbyQuery = False
    End Sub

    Private Sub cmdViewTab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewTab1.Click
        DotNetBarTabcontrol.SelectTab(0)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab1)
    End Sub

    Private Sub cmdViewTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewTab2.Click
        DotNetBarTabcontrol.SelectTab(1)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab2)
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
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub cmdViewTab4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewTab4.Click
        DotNetBarTabcontrol.SelectTab(3)
        Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab4)
    End Sub

    Private Sub dgMasterInfo1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMasterInfo1.CellContentClick
        'write down amount received procedure for concerned record
    End Sub

    Private Sub cmdFindTab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindTab1.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to find", "Find Sale Invoice", "only digit")
        If SaleInvoice.Trim = "" Then Exit Sub
        If IsNumeric(SaleInvoice.Trim) And Val(SaleInvoice.Trim) > 0 Then
            FindbyQuery = True
            gblFind = SaleInvoice.Trim
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab1)
        End If
    End Sub

    Private Sub cmdFindTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindTab2.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to find", "Find Sale Invoice", "only digit")
        If SaleInvoice.Trim = "" Then Exit Sub
        If IsNumeric(SaleInvoice.Trim) And Val(SaleInvoice.Trim) > 0 Then
            FindbyQuery = True
            gblFind = SaleInvoice.Trim
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab2)
        End If
    End Sub

    Private Sub cmdFindTab3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindTab3.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to find", "Find Sale Invoice", "only digit")
        If SaleInvoice.Trim = "" Then Exit Sub
        If IsNumeric(SaleInvoice.Trim) And Val(SaleInvoice.Trim) > 0 Then
            FindbyQuery = True
            gblFind = SaleInvoice.Trim
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab3)
        End If
    End Sub

    Private Sub cmdFindTab4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindTab4.Click
        Dim SaleInvoice As String = InputBox("Enter Sale Invoice # to find", "Find Sale Invoice", "only digit")
        If SaleInvoice.Trim = "" Then Exit Sub
        If IsNumeric(SaleInvoice.Trim) And Val(SaleInvoice.Trim) > 0 Then
            FindbyQuery = True
            gblFind = SaleInvoice.Trim
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, Me.MasterBindingSource, Me.DetailBindingSource, dtDateTab4)
        End If
    End Sub

    Private Sub cmdPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayment.Click
        'check and get values from datagrid highlighted row
        If dgMasterInfo1.RowCount > 0 Then
            If Val((dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(0).Value.ToString())) > 0 Then
                gblCP_ID = Val(dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(0).Value.ToString())
                gblCP = (dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(1).Value.ToString())
                Total = Val(dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(3).Value.ToString())
                Paid = Val(dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(4).Value.ToString())
                Discount = Val(dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(5).Value.ToString())
                Credit = Val(dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(6).Value.ToString())
                Cust_ID = (dgChildInfo1.Rows(dgChildInfo1.CurrentRow.Index).Cells(1).Value.ToString())
                Description = "Payment Received from " & (dgChildInfo1.Rows(dgChildInfo1.CurrentRow.Index).Cells(2).Value.ToString())

                Dim Detail As String = (dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(0).Value.ToString()) & " on " & (dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(1).Value.ToString()) & " of date " & Format(Date.Parse(dgMasterInfo1.Rows(dgMasterInfo1.CurrentRow.Index).Cells(2).Value.ToString()), "MM/dd/yyyy")
                Dim SalePayment As String = InputBox("Enter amount received against selected " & vbCrLf & "Invoice # " & Detail, "Payment", Credit)
                If SalePayment.Trim = "" Then Exit Sub
                If IsNumeric(SalePayment.Trim) And Val(SalePayment.Trim) > 0 Then
                    If Val(SalePayment.Trim) > Credit Then gblMessage = "Payment Invalid" : MsgStatus.ShowDialog(Me) : Exit Sub
                    Discount = Credit - Val(SalePayment.Trim)
                    Credit = Total - (Paid + Val(SalePayment.Trim)) - Discount
                    'query to update payment agains sale invoice
                    Dim UpdateQuery As String = "UPDATE SALE_MASTER SET SaleStatus = 0, SalePaid = SalePaid + " & Val(SalePayment.Trim) & ", SaleDiscount = SaleDiscount + " & Discount & ", SaleCredit = " & Credit & ", SaleRecovery = " & Val(SalePayment.Trim) & ", DateRecovery = N'" & Format(Date.Parse(Now.Date.ToString), "MM/dd/yyyy") & "' WHERE SaleID = " & Val(gblCP_ID.Trim)
                    Try
                        ExecuteAdapterQuery(SqlDataAdapter, UpdateQuery, Connection)
                        Call cmdViewTab2_Click(sender, e)
                    Catch Msg As Exception
                        gblMessage = Msg.Message
                        MsgStatus.ShowDialog(Me)
                    End Try
                    ' To update journal transactions if credit customer info given
                    If Val(Cust_ID.Trim) > 0 Then
                        If Discount > 0 Then
                            Description = Description & " & Got discount on payment Rs." & Discount
                        End If
                        Call Updt_General_Journal((Val(SalePayment.Trim) + Discount), Val(Cust_ID.Trim), Now.Date, Description, gblCP_ID)
                        If CheckRecordExists(Val(Cust_ID.Trim), "CUSTOMERS", "CUST_CODE") = True Then
                            Dim Clos_Balance As String = "UPDATE CUSTOMERS SET " & _
                                                         "CUST_BALANCE = CUST_BALANCE - " & (Val(SalePayment.Trim) + Discount) & ", " & _
                                                         "CUST_UPD_DT = N'" & Format(Date.Parse(Now.Date.ToString), "MM/dd/yyyy") & "' " & _
                                                         "WHERE CUST_CODE = N'" & Val(Cust_ID.Trim) & "'"
                            ExecuteAdapterQuery(SqlDataAdapter, Clos_Balance, Connection)
                        End If
                    End If
                End If
            Else
                gblMessage = "There is no selected sale invoice to update."
                MsgStatus.ShowDialog(Me)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Updt_General_Journal(ByVal strPrice As Double, ByVal Cust_Code As Integer, ByVal strDate As Date, ByVal strDesc As String, ByVal strInvoice As String)
        Dim cmdText As String = ""
        ' To made general journal transaction for concerned suppliers while update products
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POS;")
        Dim Trans_ID, Opn_Bal, Clo_Bal As Double
        Dim Customer_Name As String = ""
        Trans_ID = 0
        Opn_Bal = 0
        Clo_Bal = 0

        Dim Max_Tr As Double = GenerateMax_ID("CUSTOMERS_PAYM", "CUST_TR_ID")

        Dim Get_Supplier As String = "select * from customers where cust_code = " & Cust_Code
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Customer_Name = SuppliersReader.Item("CUST_NAME").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("CUST_BALANCE").ToString.Trim)
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        Else
            Opn_Bal = 0
        End If

        Trans_ID = GenerateMax_ID("CUSTOMERS_PAYM", "CUST_TR_ID")
        Clo_Bal = Opn_Bal - strPrice

        cmdText = _
           ("INSERT INTO CUSTOMERS_PAYM VALUES ('" & Cust_Code & "','" & Format(Date.Parse(strDate), "MM/dd/yyyy") & "','" & Trans_ID & "','" & Customer_Name & "','" & strDesc.Trim & " Invoice # " & strInvoice.Trim & "'," & Opn_Bal & "," & strPrice & ",0," & Clo_Bal & ",'" & Format(Date.Parse(strDate.ToString), "MM/dd/yyyy") & "')")

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Try
                    sqlCmd.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                End Try
            End Using
        End Using

    End Sub

    Private Function CheckRecordExists(ByVal strFind As String, ByVal tblName As String, ByVal strField As String) As Boolean
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POS;")
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
        SummaryReports.MdiParent = Main
        SummaryReports.Show()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class