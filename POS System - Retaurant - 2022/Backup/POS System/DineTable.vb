Imports System.Data.SqlClient

Public Class DineTable
    Private inputStatus, BillPaid As Boolean
    Private hasDecimal, hasTable, hasOrder, hasWaiter As Boolean
    Private CustName, Status, TableNo As String
    Dim MyBindingSource As New BindingSource
    Private TableChange, Addition, EditMode As Boolean
    Dim ItemName, ItemQty, ItemCode, FirstMenu(100), OldTableNo As String
    Dim SortID As Integer
    Dim InsertCustomer, EditCustomer, CustomerID As String
    Dim clearDisplay As Boolean = False

#Region "Forms Event"
    Private Sub frmDineTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'First time check if any unpaid bill is in pending
        Status = String.Empty
        Call GetConnectionString()
        TableChange = False
        hasWaiter = False
        hasOrder = False
        BillPaid = False
        Call AddButtons()
        Call CheckTableReservation()
        Call CheckTableLock()
        cmdSelect.Text = "&Select" & vbCrLf & "Customer"
        cmdEdit.Text = "&Edit" & vbCrLf & "Customer"
        cmdNew.Text = "&New" & vbCrLf & "Customer"
        Me.BackColor = Color.White
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If TableChange = True Then
            TabDine.SelectTab(1)
            TableChange = False
            Exit Sub
        End If
        Me.Close()
    End Sub

#End Region

#Region "Main Procedures"
    Private Sub TableButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B01.Click, B02.Click, B03.Click, B04.Click, B05.Click, B06.Click, B07.Click, B08.Click, B09.Click, B10.Click, B11.Click, B12.Click, _
                                                                                                     B13.Click, B14.Click, B15.Click, B16.Click, B17.Click, B18.Click, P1.Click, P2.Click, P3.Click, P4.Click, P5.Click, P6.Click, _
                                                                                                     P7.Click, P8.Click, P9.Click, P10.Click, P11.Click, P12.Click, H1.Click, H2.Click, H3.Click, H4.Click, H5.Click
        Dim ClickBtn As Button = sender
        TableNo = ClickBtn.Text
        If TableChange = True Then
            Dim LockCheck As String = "SELECT * FROM TABLE_DETAIL WHERE SaleTable = N'" & TableNo.Trim & "' AND TableStatus = N'LOCKED'"
            ExecuteAdapterQuery(SqlDataAdapter, LockCheck, Connection)
            Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Checker.HasRows Then
                gblMessage = OldTableNo.Trim & " cannot be changed to " & TableNo.Trim & ". Please select another table."
                MsgStatus.ShowDialog(Me)
                Exit Sub
            End If
            Dim ChangeTable As String = "Update TABLE_DETAIL SET SaleTable = N'" & TableNo.Trim & "' , CustomerID = N'" & Val(Mid(TableNo.Trim, 2, 2)) & "' WHERE SaleID = " & Val(gblCP_ID.Trim) & " AND SaleTable = N'" & OldTableNo.Trim & "'"
            Try
                Call ExecuteAdapterQuery(SqlDataAdapter, ChangeTable, Connection)
                'From MSDN Forum
                For Each Obj As Object In tabReservation.Controls
                    If Obj.GetType Is GetType(Button) Then
                        DirectCast(Obj, Button).BackColor = System.Drawing.Color.White
                    End If
                Next
                CustomerID = TableNo.Trim
                CheckTableReservation()
                UpdateMasterTable()
                TableChange = False
            Catch ex As Exception
                gblMessage = ex.Message
                MsgStatus.ShowDialog(Me)
                Exit Sub
            End Try
        End If
        TabDine.SelectTab(1)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If lblStatus.Text = "New" Then
            Dim TableLock As String = "UPDATE TABLE_DETAIL SET TableStatus = N'Unpaid' WHERE SaleID = N'" & Val(OrderNo.Text.Trim) & "' AND SaleTable = N'" & lblTable.Text.Trim & "' AND TableStatus != N'LOCKED'"
            ExecuteAdapterQuery(SqlDataAdapter, TableLock, Connection)
        End If
        If hasWaiter = True Then
            If lblWaiter.Text = "" Or lblWaiter.Text = "x" Then gblMessage = "Please add table waiter name."
            MsgStatus.ShowDialog(Me)
            Exit Sub
        End If
        CheckTableReservation()
        CheckTableLock()
        TabDine.SelectTab(0)
    End Sub

    Private Sub cmdSettle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettle.Click
        If hasOrder = True Then
            TabDine.SelectTab(3)
            lblFinalCustomer.Text = lblCustomer.Text
            lblFinalTable.Text = lblTable.Text
            lblFinalWaiter.Text = lblWaiter.Text
            lblFinalSequence.Text = SequenceNo.Text
            lblFinalStatus.Text = lblStatus.Text
            lblFinalOrderNo.Text = OrderNo.Text.Trim
            Call Popup_FinalDataGrid()
            Call Get_Total("TABLE_DETAIL")
        End If
    End Sub

    Private Sub TabDine_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabDine.SelectedIndexChanged
        'Procedures for Selected Tabpages
        If TabDine.SelectedIndex = 1 Then
            ExecuteAdapterQuery(SqlDataAdapter, "SELECT DISTINCT DetailID, DetailDate, SaleID, SaleTable, AOptions, TableStatus FROM TABLE_DETAIL WHERE SaleTable = N'" & TableNo.Trim & "'", Connection)
            Dim CheckTable As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If CheckTable.HasRows Then
                While CheckTable.Read
                    lblStatus.Text = CheckTable.Item("TableStatus").ToString
                    SequenceNo.Text = Format(DateTime.Parse(CheckTable.Item("DetailDate").ToString), "MMddyyyy") & Format(Val(CheckTable.Item("DetailID")), "0000")
                    OrderNo.Text = CheckTable.Item("SaleID").ToString
                    lblWaiter.Text = CheckTable.Item("AOptions").ToString
                End While
                If Label5.Visible = False Then Label5.Visible = True : lblOrgPrice.Visible = True : Label9.Visible = True : lblTaxes.Visible = True
                hasOrder = True
            Else
                OrderNo.Text = GetMax_ID(OrderNo.Text.Trim)
                SequenceNo.Text = Format(Now.Date, "MMddyyyy") & Format(Val(GetDetail_ID(SequenceNo.Text.Trim)), "0000")
                lblStatus.Text = "New"
                lblWaiter.Text = ""
                SortID = 1
                hasOrder = False
                Popup_DataGrid()
                Get_Total("TABLE_DETAIL")
            End If
            lblTable.Text = TableNo
            If Label5.Visible = False Then Label5.Visible = True : lblOrgPrice.Visible = True : Label9.Visible = True : lblTaxes.Visible = True
            If lblStatus.Text.Trim = "LOCKED" Then
                cmdChange.Enabled = False : cmdCustomer.Enabled = False : cmdPrint.Enabled = False
            Else
                cmdChange.Enabled = True : cmdCustomer.Enabled = True : cmdPrint.Enabled = True : cmdWaiter.Enabled = True
            End If
            Call Popup_DataGrid()
            Call Get_Total("TABLE_DETAIL")
            Dim MyControl As New Button
            Dim MyEvent As New System.EventArgs
            MyControl.Text = FirstMenu(0)
            Call ClickButton(MyControl, MyEvent)
        End If

        If TabDine.SelectedIndex = 3 Then
            cmdClose.Focus()
        End If

    End Sub

    Private Sub AddButtons()
        Dim I As Integer = 0
        Dim MenuGroupQuery As String = "Select distinct PROD_CATG from PRODUCTS order by PROD_CATG"
        ExecuteAdapterQuery(SqlDataAdapter, MenuGroupQuery, Connection)
        Dim GroupReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GroupReader.HasRows Then
            While GroupReader.Read
                Dim MenuGroup As New Button
                With MenuGroup
                    .Text = GroupReader.Item("PROD_CATG").ToString.ToUpper.Trim
                    .Size = New System.Drawing.Size(170, 45)
                    .Font = New Font("Tahoma", 10.0)
                    .Font = New Font(.Font, FontStyle.Bold)
                    .BackColor = Color.DeepSkyBlue
                    .ForeColor = Color.White
                    .TextAlign = ContentAlignment.MiddleCenter
                    .FlatStyle = FlatStyle.Flat
                    .FlatAppearance.BorderColor = Color.WhiteSmoke
                    .FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
                    .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
                    GroupFlowPanel.Controls.Add(MenuGroup)
                    FirstMenu(I) = .Text.Trim
                    I += 1
                    AddHandler MenuGroup.Click, AddressOf ClickButton
                End With
            End While
        End If
    End Sub

    ' Result of (Click Button) event, get the text of button
    Public Sub ClickButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim btn As Button = sender
        'Populate Submenu Items and create menu buttons in flowpanel
        Dim SubItemsQuery As String = "SELECT distinct PROD_CATG, PROD_DESC from products where PROD_CATG = N'" & btn.Text.Trim & "' ORDER BY PROD_DESC"
        ExecuteAdapterQuery(TransferAdapter, SubItemsQuery, Connection)
        Dim ItemReader As SqlDataReader = TransferAdapter.SelectCommand.ExecuteReader
        If ItemReader.HasRows Then
            'To remove all items before add new
            For i = Me.ItemFlowPanel.Controls.Count - 1 To 0 Step -1
                Me.ItemFlowPanel.Controls.RemoveAt(i)   'Here you actually provide the index!
            Next
            While ItemReader.Read
                Dim MenuItems As New Button
                With MenuItems
                    .Text = ItemReader.Item("PROD_DESC").ToString.ToUpper.Trim
                    .Size = New System.Drawing.Size(120, 30)
                    .Font = New Font("Tahoma", 8.25)
                    .BackColor = Color.DarkGreen
                    .Font = New Font(.Font, FontStyle.Bold)
                    .ForeColor = Color.White
                    .FlatStyle = FlatStyle.Flat
                    .TextAlign = ContentAlignment.MiddleCenter
                    .FlatAppearance.BorderColor = Color.Silver
                    .FlatAppearance.MouseDownBackColor = Color.Silver
                    .ForeColor = Color.WhiteSmoke
                    ItemFlowPanel.Controls.Add(MenuItems)
                    AddHandler MenuItems.Click, AddressOf ItemButton
                End With
            End While
        End If

    End Sub

    ' Result of (Click Button) event, get the text of button
    Public Sub ItemButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim ItemBtn As Button = sender
        'Populate Items and add into order list
        If lblDisplay.Text = String.Empty Or lblDisplay.Text = "0" Or lblDisplay.Text = "0." Then
            ItemQty = 1
        Else
            ItemQty = Val(lblDisplay.Text.Trim)
        End If
        Dim TempDetailSale As String = String.Empty
        Dim StockInfo As String = "select * from products where prod_desc = N'" & ItemBtn.Text.Trim & "'"
        ExecuteAdapterQuery(SaleDataAdapter, StockInfo, Connection)
        Dim GetStockInfo As SqlDataReader = SaleDataAdapter.SelectCommand.ExecuteReader
        If GetStockInfo.HasRows Then
            While GetStockInfo.Read
                If CheckItemExist(ItemBtn.Text.Trim, "TABLE_DETAIL", "StockDesc", TableNo) = False Then
                    TempDetailSale = "INSERT INTO TABLE_DETAIL VALUES (" & _
                                             Val(Mid(SequenceNo.Text.Trim, 9, 4)) & ",'" & _
                                             Format(Date.Parse(Now.Date.ToString), "MM/dd/yyyy") & "'," & _
                                             Val(OrderNo.Text.Trim) & ",'" & _
                                             "TABLE" & "'," & _
                                             Val(Mid(SequenceNo.Text.Trim, 9, 4)) & ",'" & _
                                             lblCustomer.Text.Trim & "','" & _
                                             GetStockInfo.Item("PROD_CD").ToString.Trim & "','" & _
                                             GetStockInfo.Item("PROD_DESC").ToString.Trim & "','" & _
                                             TableNo.Trim.ToUpper & "'," & _
                                             GetStockInfo.Item("PROD_SPRICE") & "," & Val(ItemQty.Trim) & "," & _
                                             GetStockInfo.Item("PROD_SPRICE") * Val(ItemQty.Trim) & ",'" & lblStatus.Text.Trim & "'," & _
                                             UserID.Trim & ",0,0,0,0,0,'x'," & SortID & ")"
                    SortID += 1
                    hasOrder = True
                    hasWaiter = True
                Else
                    'To double the quantity of subitem in gridview
                    TempDetailSale = "UPDATE TABLE_DETAIL SET QTY = QTY + " & Val(ItemQty.Trim) & ", PRICE = PRICE + " & GetStockInfo.Item("PROD_SPRICE") * Val(ItemQty.Trim) & " WHERE SALEID = N'" & Val(OrderNo.Text.Trim) & "' AND StockDesc = N'" & ItemBtn.Text.Trim & "' AND SaleTable = N'" & lblTable.Text.Trim & "'"
                    hasOrder = True
                    hasWaiter = True
                End If
                ExecuteAdapterQuery(SqlDataAdapter, TempDetailSale, Connection)
                Call Popup_DataGrid()
                Call Get_Total("TABLE_DETAIL")
                CustomerID = lblTable.Text.Trim
                UpdateMasterTable()
                lblDisplay.Text = String.Empty
            End While
        End If
    End Sub

    Private Sub Popup_DataGrid()
        Try
            Me.RecordDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM TABLE_DETAIL WHERE SaleTable = N'" & lblTable.Text.Trim & "' ORDER BY SORTITEM"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "TABLE_DETAIL", Connection)
            SqlDataAdapter.Fill(Me.RecordDataSet, "TABLE_DETAIL")
            Me.SaleBindingSource.DataSource = Me.RecordDataSet
            Me.SaleBindingSource.DataMember = "TABLE_DETAIL"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub Popup_FinalDataGrid()
        Try
            Me.FinalDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM TABLE_DETAIL WHERE SaleTable = N'" & lblFinalTable.Text.Trim & "' ORDER BY SORTITEM"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "TABLE_DETAIL", Connection)
            SqlDataAdapter.Fill(Me.FinalDataSet, "TABLE_DETAIL")
            Me.FinalBindingSource.DataSource = Me.FinalDataSet
            Me.FinalBindingSource.DataMember = "TABLE_DETAIL"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub Get_Total(ByVal tblName As String)
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim cmdText As String = _
           ("SELECT SUM(QTY) AS TOTAL_QTY, SUM(PRICE) AS TOTAL_PRICE FROM " & tblName.Trim & " WHERE (SALEID = N'" & Val(OrderNo.Text.Trim) & "') AND (TableStatus != N'PAID')")
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    While reader.Read
                        lblTaxes.Text = Format(Val(reader.Item("TOTAL_PRICE").ToString.Trim) * 0.07, "0.00")
                        lblFinalCharges.Text = Format(Val(reader.Item("TOTAL_PRICE").ToString.Trim) * 0.07, "0.00")
                        lblOrgPrice.Text = Format(Val(reader.Item("TOTAL_PRICE").ToString.Trim) + Val(lblTaxes.Text.Trim), "0.00")
                        lblFinalBill.Text = Format(Val(reader.Item("TOTAL_PRICE").ToString.Trim), "0.00")
                        lblDue.Text = Format(Val(lblFinalBill.Text.Trim) + Val(lblFinalDiscount.Text.Trim) + Val(lblFinalCharges.Text), "0.00")
                        lblTotalBill.Text = Format(Val(lblDue.Text.Trim), "0.00")
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Function GetMax_ID(ByVal StringID As String) As Integer

        Dim MaxID_Text As String = "SELECT MAX(MaxID) as MaxSerial FROM " & _
                                   "( " & _
                                   "SELECT MAX(SALEID) as MaxID " & _
                                   "FROM SALE_MASTER " & _
                                   "GROUP BY SALEID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(SALEID) as MaxID " & _
                                   "FROM SALE_DETAIL_TEMP " & _
                                   "GROUP BY SaleID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(SALEID) as MaxID " & _
                                   "FROM TABLE_DETAIL " & _
                                   "GROUP BY SaleID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(SALEID) as MaxID " & _
                                   "FROM SALE_DETAIL_HOLD " & _
                                   "GROUP BY SaleID " & _
                                   ") as subQuery"


        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    GetMax_ID = 1
                Else
                    GetMax_ID = Convert.ToDecimal(Cmd.ExecuteScalar()) + 1
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return GetMax_ID
        End Using

    End Function

    Public Function GetDetail_ID(ByVal StringID As String) As Integer

        Dim MaxID_Text As String = "SELECT MAX(MaxID) as MaxSerial FROM " & _
                                   "( " & _
                                   "SELECT MAX(DETAILID) as MaxID " & _
                                   "FROM SALE_DETAIL " & _
                                   "GROUP BY DetailID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(DETAILID) as MaxID " & _
                                   "FROM SALE_DETAIL_TEMP " & _
                                   "GROUP BY DetailID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(DETAILID) as MaxID " & _
                                   "FROM TABLE_DETAIL " & _
                                   "GROUP BY DetailID " & _
                                   "UNION ALL " & _
                                   "SELECT MAX(DETAILID) as MaxID " & _
                                   "FROM SALE_DETAIL_HOLD " & _
                                   "GROUP BY DetailID " & _
                                   ") as subQuery"


        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    GetDetail_ID = 1
                Else
                    GetDetail_ID = Convert.ToDecimal(Cmd.ExecuteScalar()) + 1
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return GetDetail_ID
        End Using
    End Function

    Private Function CheckItemExist(ByVal strFind As String, ByVal tblName As String, ByVal strField As String, ByVal TableNum As String) As Boolean
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim cmdText As String = _
           ("SELECT * FROM " & tblName.Trim & " WHERE (" & strField.Trim & " = N'" & strFind.Trim & "') AND (SaleTable = N'" & TableNum.Trim & "')")
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

    Private Sub CheckTableReservation()
        ExecuteAdapterQuery(SqlDataAdapter, "SELECT SaleTable, TableStatus FROM TABLE_DETAIL WHERE TableStatus != N'LOCKED' GROUP BY SaleTable, TableStatus", Connection)
        Dim OnTable As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If OnTable.HasRows Then
            While OnTable.Read
                Call ChangeBackgroundColor(tabReservation, OnTable.Item("SaleTable").ToString)
            End While
            hasTable = True
        End If
    End Sub

    Private Sub CheckTableLock()
        ExecuteAdapterQuery(SqlDataAdapter, "SELECT SaleTable, TableStatus FROM TABLE_DETAIL WHERE TableStatus = N'LOCKED' GROUP BY SaleTable, TableStatus", Connection)
        Dim OnTable As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If OnTable.HasRows Then
            While OnTable.Read
                CheckTablesPrintBill(tabReservation, OnTable.Item("SaleTable").ToString)
            End While
            hasTable = True
        End If
    End Sub

    Private Sub ChangeBackgroundColor(ByRef parentControl As System.Windows.Forms.Control, ByVal BtnText As String)
        ' Loop through each control inside the given parent
        For Each control As System.Windows.Forms.Control In parentControl.Controls
            ' Recursively update the color of the controls inside this control
            ChangeBackgroundColor(control, BtnText)
            ' If the contol is a button change the background color
            If (TypeOf control Is System.Windows.Forms.Button) Then
                If control.Text = BtnText Then _
                    control.BackColor = System.Drawing.Color.Goldenrod
            End If
        Next
    End Sub

    Private Sub CheckTablesPrintBill(ByRef parentControl As System.Windows.Forms.Control, ByVal BtnText As String)
        ' Loop through each control inside the given parent
        For Each control As System.Windows.Forms.Control In parentControl.Controls
            ' Recursively update the color of the controls inside this control
            ChangeBackgroundColor(control, BtnText)
            ' If the contol is a button change the background color
            If (TypeOf control Is System.Windows.Forms.Button) Then
                If control.Text = BtnText Then
                    control.BackColor = System.Drawing.Color.Maroon
                    control.ForeColor = System.Drawing.Color.White
                End If
            End If
        Next
    End Sub

    Private Sub ResetAllControlsBackColor(ByVal control As Control)
        'This code taken from MSDN
        'control.BackColor = Color.White
        'control.ForeColor = Color.Black
        'If control.HasChildren Then
        '    ' Recursively call this method for each child control.
        '    Dim childControl As Control
        '    For Each childControl In control.Controls
        '        ResetAllControlsBackColor(childControl)
        '    Next childControl
        'End If
    End Sub

    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        TableChange = True
        OldTableNo = lblTable.Text.Trim
        gblCP_ID = OrderNo.Text.Trim
        TabDine.SelectTab(0)
    End Sub

    Private Sub cmdCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomer.Click
        TabDine.SelectTab(2)
        search_popup(txtSearch.Text)
    End Sub

    Private Sub SpecialButtons1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCustomer.MouseEnter, cmdVoid.MouseEnter, cmdWaiter.MouseEnter, cmdPrint.MouseEnter, cmdChange.MouseEnter, D0.MouseEnter, D1.MouseEnter, _
                                                                                             D2.MouseEnter, D3.MouseEnter, D4.MouseEnter, D5.MouseEnter, D6.MouseEnter, D7.MouseEnter, D8.MouseEnter, D9.MouseEnter, cmdBackSpace.MouseEnter, cmdClearDisplay.MouseEnter
        Dim ButtonHandle As Button = sender
        ButtonHandle.ForeColor = Color.White
    End Sub

    Private Sub SpecialButtons2(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCustomer.MouseLeave, cmdVoid.MouseLeave, cmdWaiter.MouseLeave, cmdPrint.MouseLeave, cmdChange.MouseLeave
        Dim ButtonHandle As Button = sender
        ButtonHandle.ForeColor = Color.Black
    End Sub

    Private Sub cmdVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVoid.Click
        TableChange = False
        Dim VoidOrder As String = "DELETE FROM TABLE_DETAIL WHERE SaleID = N'" & Val(OrderNo.Text.Trim) & "' AND SaleTable = N'" & lblTable.Text.Trim & "' AND TableStatus != N'LOCKED'"
        ExecuteAdapterQuery(SqlDataAdapter, VoidOrder, Connection)
        Dim VoidCustomer As String = "DELETE FROM TABLE_MASTER WHERE SaleID = N'" & Val(OrderNo.Text.Trim) & "' AND CustomerID = N'" & Val(Mid(lblTable.Text.Trim, 2, 2)) & "'"
        ExecuteAdapterQuery(SqlDataAdapter, VoidCustomer, Connection)
        lblCustomer.Text = ""
        lblOrgPrice.Text = "0.00"
        lblOrgPrice.Visible = False
        Label5.Visible = False
        Label9.Visible = False
        lblTaxes.Visible = False
        lblStatus.Text = ""
        lblWaiter.Text = ""
        lblTable.Text = ""
        'From MSDN Forum
        For Each Obj As Object In tabReservation.Controls
            If Obj.GetType Is GetType(Button) Then
                DirectCast(Obj, Button).BackColor = System.Drawing.Color.White
            End If
        Next
        CheckTableReservation()
        CheckTableLock()
        TabDine.SelectTab(0)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If hasOrder = True Then
            Dim TableLock As String = "UPDATE TABLE_DETAIL SET TableStatus = N'LOCKED' WHERE SaleID = N'" & Val(OrderNo.Text.Trim) & "' AND SaleTable = N'" & lblTable.Text.Trim & "' AND TableStatus != N'LOCKED'"
            ExecuteAdapterQuery(SqlDataAdapter, TableLock, Connection)
            cmdChange.Enabled = False
            cmdCustomer.Enabled = False
            cmdPrint.Enabled = False
            gblFind = OrderNo.Text.Trim
            gblReportOption = "DUE_RECEIPT"
            CheckTablesPrintBill(tabReservation, lblTable.Text.Trim)
            gblReportName = Application.StartupPath & "\Reports\CashReceipt.rpt"
            Call Print_Slips_Manually()
            hasOrder = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmdWaiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWaiter.Click
        WaiterCode.ShowDialog(Me)
        If Len(gblCP) > 0 Then
            lblWaiter.Text = gblCP.Trim.ToUpper : hasWaiter = False
            Dim WaiterUpdate As String = "Update TABLE_DETAIL SET AOptions = N'" & lblWaiter.Text.Trim & "' WHERE SaleTable = N'" & lblTable.Text.Trim & "'"
            ExecuteAdapterQuery(TransferAdapter, WaiterUpdate, Connection)
        End If
    End Sub
#End Region

#Region "Num Pad Functions"
    Private Sub DigitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num1.Click, Num2.Click, Num3.Click, Num4.Click, Num5.Click, Num6.Click, Num7.Click, Num8.Click, Num9.Click
        If clearDisplay Then
            lblDisplay.Text = String.Empty
            clearDisplay = False
        End If
        lblDisplay.Text = lblDisplay.Text + sender.text
    End Sub


    Private Sub NumFriction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumFriction.Click
        If lblDisplay.Text.IndexOf(".") >= 0 Then
            Exit Sub
        Else
            If Len(lblDisplay.Text) = 0 Then
                lblDisplay.Text = "0."
            Else
                lblDisplay.Text = lblDisplay.Text & "."
            End If
        End If
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Dim str As String
        Dim loc As Integer
        If lblDisplay.Text.Length > 0 Then
            str = lblDisplay.Text.Chars(lblDisplay.Text.Length - 1)
            If str = "." Then
                hasDecimal = False
            End If
            loc = lblDisplay.Text.Length
            lblDisplay.Text = lblDisplay.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        lblDisplay.Text = String.Empty
        hasDecimal = False
    End Sub

    Private Sub Num0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num0.Click
        If Len(lblDisplay.Text) = 0 Or lblDisplay.Text = "0" Then
            Exit Sub
        Else
            lblDisplay.Text = lblDisplay.Text + sender.text
        End If
    End Sub

    Private Sub FinalDigitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1.Click, D2.Click, D3.Click, D4.Click, D5.Click, D6.Click, D7.Click, D8.Click, D9.Click
        If BillPaid = False Then
            If clearDisplay Then
                txtPaid.Text = String.Empty
                clearDisplay = False
            End If
            txtPaid.Text = txtPaid.Text + sender.text
        End If
    End Sub

    Private Sub D0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D0.Click
        If BillPaid = False Then
            If Len(txtPaid.Text) = 0 Or txtPaid.Text = "0" Then
                Exit Sub
            Else
                txtPaid.Text = txtPaid.Text + sender.text
            End If
        End If
    End Sub

    Private Sub cmdClearDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearDisplay.Click
        If BillPaid = False Then
            txtPaid.Text = String.Empty
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdBackSapce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackSpace.Click
        If BillPaid = False Then
            Dim str As String
            Dim loc As Integer
            If txtPaid.Text.Length > 0 Then
                str = txtPaid.Text.Chars(txtPaid.Text.Length - 1)
                If str = "." Then
                    hasDecimal = False
                End If
                loc = txtPaid.Text.Length
                txtPaid.Text = txtPaid.Text.Remove(loc - 1, 1)
            End If
        End If
    End Sub

#End Region

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        TabDine.SelectTab(1)
        ButtonHandle()
        Addition = False
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        ValidateAlphaKeyPress(sender, e, txtName)
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        ValidateAlphaKeyPress(sender, e, txtSearch)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If Len(txtSearch.Text) > 0 Then
            search_popup(txtSearch.Text.Trim)
        Else

        End If
    End Sub

    Private Sub search_popup(ByVal FindString As String)
        Me.FinalDataSet.Clear()
        Dim cmdText As String = _
           ("SELECT * FROM CUSTOMERS WHERE CUST_NAME LIKE '%" & txtSearch.Text & "%'")
        ExecuteAdapterQuery(SqlDataAdapter, cmdText, Connection)
        SqlDataAdapter.Fill(Me.FinalDataSet, "CUSTOMERS")
        Me.FinalBindingSource.DataSource = Me.FinalDataSet
        Me.FinalBindingSource.DataMember = "CUSTOMERS"
        Me.FinalBindingSource.Filter = "CUST_NAME LIKE '%" & txtSearch.Text & "%'"
        Me.dgvCustomer.DataSource = Me.FinalBindingSource
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If cmdNew.Text = "&Save" Then
            If Addition = True Then InsertCustomer = "INSERT INTO CUSTOMERS VALUES (0,'" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','x','x','" & txtPhone.Text.Trim & "','0','0','2017-01-01'"
            If EditMode = True Then InsertCustomer = "UPDATE CUSTOMERS SET CUST_NAME = N'" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "', CUST_TEL = N'" & txtPhone.Text.Trim & "' WHERE CUST_NAME = N'" & EditCustomer.Trim & "'"
            ExecuteAdapterQuery(SqlDataAdapter, InsertCustomer, Connection)
            ButtonHandle()
            txtSearch.Clear()
            txtSearch.Focus()
            search_popup(txtSearch.Text.Trim)
            dgvCustomer.Refresh()
            Exit Sub
        End If
        Addition = True
        Label8.Text = "Name"
        cmdNew.Text = "&Save"
        cmdNew.Enabled = False
        cmdSelect.Enabled = False
        cmdEdit.Enabled = False
        Label10.Visible = True
        txtName.Visible = True
        txtPhone.Visible = True
        txtSearch.Visible = False
        dgvCustomer.Visible = False
        cmdDelete.Text = "&Cancel"
        txtName.Clear()
        txtPhone.Clear()
        If txtName.Visible = True Then txtName.Focus()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If cmdDelete.Text = "&Cancel" Then
            ButtonHandle()
            txtSearch.Clear()
            txtSearch.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ButtonHandle()
        Label8.Text = "Search"
        cmdNew.Text = "&New" & vbCrLf & "Customer"
        cmdNew.Enabled = True
        cmdSelect.Enabled = True
        cmdEdit.Enabled = True
        Label10.Visible = False
        txtName.Visible = False
        txtPhone.Visible = False
        txtSearch.Visible = True
        dgvCustomer.Visible = True
        cmdDelete.Text = "&Delete"
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        If Len(txtName.Text.Trim) > 0 Then cmdNew.Enabled = True Else cmdNew.Enabled = False
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        ValidateNumbersOnly(sender, e, txtPhone)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckCellValue(dgvCustomer) = True Then '// return false if cells have no values
            Label8.Text = "Name"
            cmdNew.Text = "&Save"
            cmdNew.Enabled = False
            cmdSelect.Enabled = False
            cmdEdit.Enabled = False
            Label10.Visible = True
            txtName.Visible = True
            txtPhone.Visible = True
            txtSearch.Visible = False
            dgvCustomer.Visible = False
            EditMode = True
            cmdDelete.Text = "&Cancel"
            txtName.Text = dgvCustomer.CurrentRow.Cells(1).Value.ToString.Trim
            txtPhone.Text = dgvCustomer.CurrentRow.Cells(4).Value.ToString.Trim
            EditCustomer = dgvCustomer.CurrentRow.Cells(1).Value.ToString.Trim
            If txtName.Visible = True Then txtName.Focus()
        End If
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        If dgvCustomer.Visible = True Then
            If dgvCustomer.RowCount > 0 Then
                lblCustomer.Text = dgvCustomer.CurrentRow.Cells(1).Value.ToString.Trim
                TabDine.SelectTab(1)
                UpdateMasterTable()
            End If
        End If
    End Sub

    Private Sub cmdCloseBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseBack.Click
        If BillPaid = True Then
            BillPaid = False
            hasOrder = False
            hasTable = False
            TableChange = False
            TabDine.SelectTab(0)
        Else
            TabDine.SelectTab(1)
        End If
    End Sub

    Private Sub ButtonMouseOver(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDiscount.MouseEnter, cmdDiscPaid.MouseEnter, D0.MouseEnter, D1.MouseEnter, _
                                                                                             D2.MouseEnter, D3.MouseEnter, D4.MouseEnter, D5.MouseEnter, D6.MouseEnter, D7.MouseEnter, D8.MouseEnter, D9.MouseEnter, cmdBackSpace.MouseEnter, cmdClearDisplay.MouseEnter, _
                                                                                             cmdSelect.MouseEnter, cmdCancel.MouseEnter, cmdEdit.MouseEnter, cmdNew.MouseEnter, cmdDelete.MouseEnter
        Dim ButtonHandle As Button = sender
        ButtonHandle.ForeColor = Color.White
    End Sub

    Private Sub ButtonMouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDiscount.MouseLeave, cmdDiscPaid.MouseLeave, D0.MouseLeave, D1.MouseLeave, _
                                                                                             D2.MouseLeave, D3.MouseLeave, D4.MouseLeave, D5.MouseLeave, D6.MouseLeave, D7.MouseLeave, D8.MouseLeave, D9.MouseLeave, cmdBackSpace.MouseLeave, cmdClearDisplay.MouseLeave, _
                                                                                             cmdSelect.MouseLeave, cmdCancel.MouseLeave, cmdEdit.MouseLeave, cmdNew.MouseLeave, cmdDelete.MouseLeave
        Dim ButtonHandle As Button = sender
        ButtonHandle.ForeColor = Color.Black
    End Sub

    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click
        If BillPaid = False Then
            If Len(txtPaid.Text) > 0 Then
                If Val(txtPaid.Text.Trim) > 100 Then gblMessage = "Discount cannot be greater than total bill amount." : MsgStatus.ShowDialog(Me) : Exit Sub
                lblFinalDiscount.Text = Format(Val(lblTotalBill.Text.Trim) * (Val(txtPaid.Text.Trim) / 100), "0.00")
                lblDue.Text = Format(Val(lblFinalBill.Text.Trim) + Val(lblFinalCharges.Text.Trim) - Val(lblFinalDiscount.Text.Trim), "0.00")
                lblTotalBill.Text = Format(Val(lblDue.Text.Trim), "0.00")
                Label13.Text = Label13.Text.Trim & " " & txtPaid.Text & "%"
                txtPaid.Clear()
            End If
        End If
    End Sub

    Private Sub cmdRefreshBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshBill.Click
        If BillPaid = False Then
            If lblFinalStatus.Text.Trim = "Paid" Then gblMessage = "Paid bill cannot be refreshed, plz contact administrator." : MsgStatus.ShowDialog(Me) : Exit Sub
            lblFinalDiscount.Text = "0.00"
            Get_Total("TABLE_DETAIL")
            Label13.Text = "Discount :"
        End If
    End Sub

    Private Sub UpdateMasterTable()
        If hasOrder = True Or TableChange = True Then
            Dim CustomerInfo As String = String.Empty
            If CheckRecordExists(OrderNo.Text.Trim, "TABLE_MASTER", "SaleID") = False Then
                CustomerInfo = "INSERT INTO TABLE_MASTER VALUES (" & _
                                                     Val(OrderNo.Text.Trim) & "," & _
                                                     Val(UserID.Trim) & ",'" & _
                                                     UserName.Trim & "','" & _
                                                     Format(Date.Parse(Now.ToString), "MM/dd/yyyy") & "','" & _
                                                     "TABLE" & "','" & _
                                                     SequenceNo.Text.Trim & "','" & _
                                                     Val(Mid(CustomerID.Trim, 2, 2)) & "','" & _
                                                     lblCustomer.Text.Trim & "'," & _
                                                     Val(lblOrgPrice.Text.Trim) & "," & _
                                                     "0" & "," & _
                                                     "0" & "," & _
                                                     "0" & "," & _
                                                     "0,0,0,0,'" & Format(Date.Parse(Now.ToString), "MM/dd/yyyy") & "'," & Val(lblTaxes.Text.Trim) & ")"
            Else
                CustomerInfo = "UPDATE TABLE_MASTER SET " & _
                                                     "DrawerID = N'" & Val(UserID.Trim) & "', " & _
                                                     "DrawerName = N'" & UserName.Trim & "', " & _
                                                     "DateCompleted = N'" & Format(Date.Parse(Now.ToString.Trim), "MM/dd/yyyy") & "', " & _
                                                     "SaleType = N'" & "TABLE" & "', " & _
                                                     "CustomerID = N'" & Val(Mid(CustomerID.Trim, 2, 2)) & "', " & _
                                                     "CustomerName = N'" & lblCustomer.Text.Trim & "', " & _
                                                     "SaleTotal = N'" & Val(lblOrgPrice.Text.Trim) & "', " & _
                                                     "SalePaid = N'" & "0" & "', " & _
                                                     "SaleDiscount = N'" & "0" & "', " & _
                                                     "SaleChange = N'" & "0" & "', " & _
                                                     "SaleStatus = 1 " & ", " & _
                                                     "ServiceChrg =  " & Val(lblTaxes.Text.Trim) & " " & _
                                                     "WHERE SaleID = " & Val(OrderNo.Text.Trim)
            End If
            ExecuteAdapterQuery(SqlDataAdapter, CustomerInfo, Connection)
        End If
    End Sub

    Private Sub cmdDiscPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscPaid.Click
        If BillPaid = False Then
            If Len(txtPaid.Text) > 0 Then
                If Val(txtPaid.Text.Trim) > Val(lblTotalBill.Text.Trim) Then gblMessage = "Discount cannot be greater than total bill amount." : MsgStatus.ShowDialog(Me) : Exit Sub
                lblFinalDiscount.Text = Format(Val(txtPaid.Text.Trim), "0.00")
                lblDue.Text = Format(Val(lblFinalBill.Text.Trim) + Val(lblFinalCharges.Text.Trim) - Val(lblFinalDiscount.Text.Trim), "0.00")
                lblTotalBill.Text = Format(Val(lblDue.Text.Trim), "0.00")
                Label13.Text = Label13.Text.Trim & " in Amount"
                txtPaid.Clear()
            End If
        End If
    End Sub

    Private Sub cmdPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaid.Click
        If BillPaid = False Then
            Dim CustomerInfo As String = "UPDATE TABLE_MASTER SET " & _
                                                     "DrawerID = N'" & Val(UserID.Trim) & "', " & _
                                                     "DrawerName = N'" & UserName.Trim & "', " & _
                                                     "DateCompleted = N'" & Format(Date.Parse(Now.ToString.Trim), "MM/dd/yyyy") & "', " & _
                                                     "SaleType = N'" & "TABLE" & "', " & _
                                                     "CustomerID = N'" & Val(Mid(lblFinalTable.Text.Trim, 2, 2)) & "', " & _
                                                     "CustomerName = N'" & lblFinalCustomer.Text.Trim & "', " & _
                                                     "SaleTotal = N'" & Val(lblTotalBill.Text.Trim) & "', " & _
                                                     "SalePaid = N'" & Val(txtPaid.Text.Trim) & "', " & _
                                                     "SaleDiscount = N'" & Val(lblFinalDiscount) & "', " & _
                                                     "SaleChange = N'" & Val(lblRefund.Text.Trim) & "', " & _
                                                     "SaleStatus = 0 " & ", " & _
                                                     "ServiceChrg =  " & Val(lblFinalCharges.Text.Trim) & " " & _
                                                     "WHERE SaleID = " & Val(lblFinalOrderNo.Text.Trim)

            Dim PaidBill As String = "Update TABLE_DETAIL SET TableStatus = N'PAID' , CustomerID = N'" & Val(Mid(lblFinalTable.Text.Trim, 2, 2)) & "' WHERE SaleID = " & Val(lblFinalOrderNo.Text.Trim) & " AND SaleTable = N'" & lblFinalTable.Text & "'"
            Try
                Call ExecuteAdapterQuery(SqlDataAdapter, CustomerInfo, Connection)
                Call ExecuteAdapterQuery(SqlDataAdapter, PaidBill, Connection)
                'From MSDN Forum
                For Each Obj As Object In tabReservation.Controls
                    If Obj.GetType Is GetType(Button) Then
                        DirectCast(Obj, Button).BackColor = System.Drawing.Color.White
                    End If
                Next
                CheckTableReservation()
                CheckTableLock()
            Catch ex As Exception
                gblMessage = ex.Message
                MsgStatus.ShowDialog(Me)
                Exit Sub
            End Try
            BillPaid = True
        End If
    End Sub

    Private Sub txtPaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtPaid.Text.Trim) < Val(lblTotalBill.Text.Trim) Then gblMessage = "payment less than total amount." : MsgStatus.ShowDialog(Me) : Exit Sub
            If Val(txtPaid.Text.Trim) > Val(lblTotalBill.Text.Trim) Then
                lblRefund.Visible = True
                Label17.Visible = True
                lblRefund.Text = Val(txtPaid.Text.Trim) - Val(lblTotalBill.Text.Trim)
            End If
        End If
    End Sub

    Private Sub txtPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaid.KeyPress
        ValidateNumericKeyPress(sender, e, txtPaid, txtPaid)
    End Sub
End Class