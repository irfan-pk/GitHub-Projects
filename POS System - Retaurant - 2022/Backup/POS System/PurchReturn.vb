Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class PurchReturn
    Dim Max_ID, Supplr_ID As Integer
    Dim drag, newrec, updatable, editmode, DataFinalize, GridEdit As Boolean
    Dim OldPPrie, OldSalePrice, OldQuantity, OldSchR1, OldSchR2, OldSchR3, OldSchQ1, OldSchQ2, OldSchQ3, NewPPrice, NewQuantity, NewSchR1, NewSchR2, NewSchR3, NewSchQ1, NewSchQ2, NewSchQ3 As Double
    Dim mousex, mousey As Integer

    Private Sub frmPurchReturn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F10 Then _
            Call BindingNavigatorSave_Click(sender, e)

        If e.KeyCode = Keys.F3 Then Call Get_Text_Values()

        If e.KeyCode = Keys.F8 Then Call Delete_DataRow()
    End Sub

    Private Sub frmPurchReturn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmPurchReturn_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmPurchReturn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Stock.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmPurchReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 5)
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + cmdClose.Width + 5)
        Call GetConnectionString()

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Popup the Company Data Combo
        Dim Popup_Reader As SqlDataReader
        ExecuteAdapterQuery(SqlDataAdapter, "SELECT DISTINCT SUPL_CODE, SUPL_NAME FROM SUPPLIERS ORDER BY SUPL_NAME", Connection)
        Popup_Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Popup_Reader.HasRows Then
            While Popup_Reader.Read
                cmbCompany.Items.Add(Popup_Reader.Item("SUPL_NAME") & " - " & Popup_Reader.Item("SUPL_NAME"))
            End While
        Else
            ' Go through
        End If
        'Retrieve Records for datagrid view from purchase table
        Call RefreshGridView()
        editmode = False
    End Sub

    Private Sub RefreshGridView()
        Try
            'Retrieve Records for datagrid view from purchase table
            Me.PurchaseDataSet.Clear()
            PurchaseAdapter.Dispose()
            'Dim PurchasesQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
            Dim PurchasesQuery As String = "SELECT * FROM PURCHASE WHERE (PRCH_STATUS = N'RETURN')"
            ExecuteAdapterQuery(PurchaseAdapter, PurchasesQuery, Connection)
            PurchaseAdapter.Fill(Me.PurchaseDataSet, "PURCHASE")
            Dim reader1 As SqlDataReader = PurchaseAdapter.SelectCommand.ExecuteReader
            If reader1.HasRows Then
                BindingNavigatorRefreshItem.Enabled = True
                Me.PurchaseBindingSource.DataSource = Me.PurchaseDataSet
                Me.PurchaseBindingSource.DataMember = "PURCHASE"
                Me.PurchaseDataGridView.Refresh()
                Me.BindingNavigatorSaveItem.Enabled = True
            End If
            'Retrieve Records for datagrid view from product table
            Me.ProductDataSet.Clear()
            ProductAdapter.Dispose()
            Dim ProductQuery As String = "SELECT * FROM PRODUCTS WHERE PROD_UPD_ON = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
            ExecuteAdapterQuery(ProductAdapter, ProductQuery, Connection)
            ProductAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            Dim reader2 As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
            If reader2.HasRows Then
                ProductBindingSource.DataSource = Me.ProductDataSet
                ProductBindingSource.DataMember = "PRODUCTS"
                ProductDataGridView.Refresh()
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        Call Get_Property_GotFocus(txtQty)
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then txtSQty1.Focus()
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        ValidateNumericKeyPress(sender, e, txtQty, txtSQty1)
    End Sub

    Private Sub txtQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.LostFocus
        Call Get_Property_LostFocus(txtQty)
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        updatable = True
        BindingNavigatorSave.Enabled = True
    End Sub

    Private Sub txtSQty1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty1.GotFocus
        Call Get_Property_GotFocus(txtSQty1)
    End Sub

    Private Sub txtSQty1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSQty1.KeyDown
        If e.KeyCode = Keys.Enter Then txtSQty2.Focus()
    End Sub

    Private Sub txtSQty1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSQty1.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtSQty1, txtSQty2)
    End Sub

    Private Sub txtSQty1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty1.LostFocus
        Call Get_Property_LostFocus(txtSQty1)
    End Sub

    Private Sub txtSQty1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSQty1.TextChanged
        updatable = True
        BindingNavigatorSave.Enabled = True
    End Sub

    Private Sub txtSQty2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty2.GotFocus
        Call Get_Property_GotFocus(txtSQty2)
    End Sub

    Private Sub txtSQty2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSQty2.KeyDown
        If e.KeyCode = Keys.Enter Then txtSQty3.Focus()
    End Sub

    Private Sub txtSQty2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSQty2.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtSQty2, txtSQty3)
    End Sub

    Private Sub txtSQty2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty2.LostFocus
        Call Get_Property_LostFocus(txtSQty2)
    End Sub

    Private Sub txtSQty2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSQty2.TextChanged
        updatable = True
        BindingNavigatorSave.Enabled = True
    End Sub

    Private Sub txtSQty3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty3.GotFocus
        Call Get_Property_GotFocus(txtSQty3)
    End Sub

    Private Sub txtSQty3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSQty3.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtSQty3, txtSQty3)
    End Sub

    Private Sub txtSQty3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSQty3.LostFocus
        Call Get_Property_LostFocus(txtSQty3)
    End Sub

    Private Sub txtSQty3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSQty3.TextChanged
        updatable = True
        BindingNavigatorSave.Enabled = True
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        If CheckRecordExists(Mid(cmbCompany.Text.Trim, 1, 4), "SUPPLIERS", "SUPL_CODE") = True Then
            ' To skip if no quantity given by user
            If Val(txtQty.Text.Trim) = 0 And _
               Val(txtQty.Text.Trim) = 0 And _
               Val(txtQty.Text.Trim) = 0 And _
               Val(txtQty.Text.Trim) = 0 Then
                gblMessage = ("There is no quantity to return purchases. please give quantity to return.")
                MsgStatus.ShowDialog(Me)
                Exit Sub
            End If
            ' If quantity given then next step
            If updatable = True Then
                Dim Max_Tr_ID As Decimal = 0

                'Check if already in Purchases Table
                If txtCode.Text = String.Empty Or txtDesc.Text = String.Empty Then _
                    gblMessage = ("Please give valid product code.") _
                                                  : MsgStatus.ShowDialog(Me) _
                                                  : Exit Sub

                Max_Tr_ID = GenerateMax_ID("PURCHASE", "PRCH_TR_ID")

                If Val(txtQty.Text) > 0 Then NewQuantity = Val(txtQty.Text) * (-1) : NewPPrice = Val(txtPPrice.Text.Trim) Else NewPPrice = 0 : NewQuantity = 0
                If Val(txtSQty1.Text) > 0 Then NewSchQ1 = Val(txtSQty1.Text) * (-1) : NewSchR1 = Val(txtSch1.Text) Else NewSchR1 = 0 : NewSchQ1 = 0
                If Val(txtSQty2.Text) > 0 Then NewSchQ2 = Val(txtSQty2.Text) * (-1) : NewSchR2 = Val(txtSch2.Text) Else NewSchR2 = 0 : NewSchQ2 = 0
                If Val(txtSQty3.Text) > 0 Then NewSchQ3 = Val(txtSQty3.Text) * (-1) : NewSchR3 = Val(txtSch3.Text) Else NewSchR3 = 0 : NewSchQ3 = 0

                Dim CheckQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_CD = N'" & txtCode.Text.Trim & "' AND PRCH_SUPPLIER = N'" & cmbCompany.Text.Trim & "' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
                ExecuteAdapterQuery(SqlDataAdapter, CheckQuery, Connection)
                Dim Finder As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Finder.HasRows Then
                    If editmode = True Then
                        Dim InsertRecord As String = "UPDATE PURCHASE SET " & _
                                                     "PRCH_PRICE = " & NewPPrice & ", " & _
                                                     "PRCH_QTY = " & NewQuantity & ", " & _
                                                     "PRCH_SCH1_PRICE = " & NewSchR1 & ", " & _
                                                     "PRCH_SCH1_ONHAND = " & NewSchQ1 & ", " & _
                                                     "PRCH_SCH2_PRICE = " & NewSchR2 & ", " & _
                                                     "PRCH_SCH2_ONHAND = " & NewSchQ2 & ", " & _
                                                     "PRCH_SCH3_PRICE = " & NewSchR3 & ", " & _
                                                     "PRCH_SCH3_ONHAND = " & NewSchQ3 & ", " & _
                                                     "PRCH_DATE = '" & Format(DateTime.Parse(txtDate.Text.Trim.ToString.Trim), "MM/dd/yyyy") & "', " & _
                                                     "PRCH_SUPPLIER = '" & cmbCompany.Text.Trim & "', PRCH_STATUS ='RETURN' " & _
                                                     "WHERE (PRCH_CD = N'" & gblFind & "' AND PRCH_STATUS = N'ADDED' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102))"
                        ExecuteAdapterQuery(SqlDataAdapter, InsertRecord, Connection)
                        editmode = False
                        Call RefreshGridView()
                        Me.txtCode.Clear()
                        Me.txtCode.Focus()
                        editmode = False
                    Else
                        'Message Box
                        gblMessage = ("Item already enlisted in the queue.")
                        MsgStatus.ShowDialog(Me)
                    End If
                Else
                    Dim InsertRecord As String = "INSERT INTO PURCHASE (PRCH_TR_ID,PRCH_CD,PRCH_DESC,PRCH_CATG,PRCH_PACK,PRCH_PRICE,PRCH_QTY,PRCH_OLD_QTY,PRCH_BAL_MIN,PRCH_SCH1_PRICE,PRCH_SCH1_ONHAND,PRCH_SCH2_PRICE,PRCH_SCH2_ONHAND,PRCH_SCH3_PRICE,PRCH_SCH3_ONHAND,PRCH_VAT,PRCH_ITAX,PRCH_EX_DUTY,PRCH_PROFIT,PRCH_DISC_MRG,PRCH_SPRICE,PRCH_DATE,PRCH_SUPPLIER,PRCH_STATUS) " & _
                                                 "VALUES (" & Max_Tr_ID & ",'" & _
                                                 txtCode.Text.Trim & "','" & _
                                                 txtDesc.Text.Trim & "','" & _
                                                 "x','" & _
                                                 "x'," & _
                                                 NewPPrice & "," & _
                                                 NewQuantity & "," & _
                                                 OldQuantity & "," & _
                                                 "0," & _
                                                 NewSchR1 & "," & _
                                                 NewSchQ1 & "," & _
                                                 NewSchR2 & "," & _
                                                 NewSchQ2 & "," & _
                                                 NewSchR3 & "," & _
                                                 NewSchQ3 & "," & _
                                                 "0," & _
                                                 "0," & _
                                                 "0," & _
                                                 "0," & _
                                                 "0," & _
                                                 "0,'" & _
                                                 Format(DateTime.Parse(txtDate.Text.Trim.ToString.Trim), "MM/dd/yyyy") & "','" & _
                                                 cmbCompany.Text.Trim & "','RETURN')"
                    ExecuteAdapterQuery(SqlDataAdapter, InsertRecord, Connection)
                    BindingNavigatorSaveItem.Enabled = True
                    BindingNavigatorRefreshItem.Enabled = True
                    Call RefreshGridView()
                    Call RefreshTextBoxes()
                    txtCode.Clear()
                    txtCode.Focus()
                End If
            End If
        Else
            gblMessage = "Please select valid wholesaler."
            MsgStatus.ShowDialog(Me)
        End If
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        Call Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' First Check Item in Product Table and get information
            Dim DataCheck As SqlDataReader
            ExecuteAdapterQuery(SqlDataAdapter, "SELECT * FROM PRODUCTS WHERE PROD_CD = N'" & txtCode.Text.ToString.ToString.Trim & "'", Connection)
            DataCheck = SqlDataAdapter.SelectCommand.ExecuteReader
            If DataCheck.HasRows Then
                While DataCheck.Read
                    txtDesc.Text = DataCheck.Item("PROD_DESC").ToString.Trim
                    txtPPrice.Text = DataCheck.Item("PROD_PPRICE").ToString.Trim
                    txtSch1.Text = DataCheck.Item("PROD_SCH1_PRICE").ToString.Trim
                    txtSch2.Text = DataCheck.Item("PROD_SCH2_PRICE").ToString.Trim
                    txtSch3.Text = DataCheck.Item("PROD_SCH3_PRICE").ToString.Trim
                    OldQuantity = Val(DataCheck.Item("PROD_ONHAND").ToString.Trim)
                    OldSchQ1 = Val(DataCheck.Item("PROD_SCH1_ONHAND").ToString.Trim)
                    OldSchQ2 = Val(DataCheck.Item("PROD_SCH2_ONHAND").ToString.Trim)
                    OldSchQ3 = Val(DataCheck.Item("PROD_SCH3_ONHAND").ToString.Trim)
                End While
                If DataCheck Is Nothing Then DataCheck.Close()
                txtQty.Focus()
            Else
                gblMessage = "Invalid Product code ? Please use valid code."
                MsgStatus.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            ProductCode.ShowDialog(Me)
            If Len(gblItemCode) > 0 Then txtCode.Text = gblItemCode.ToUpper
            Call txtCode_KeyDown(sender, e)
        End If
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Call Get_Property_LostFocus(txtCode)
    End Sub

    Private Sub cmbCompany_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompany.GotFocus
        Call Get_Property_GotFocus(cmbCompany)
    End Sub

    Private Sub cmbCompany_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompany.LostFocus
        Call Get_Property_LostFocus(cmbCompany)
    End Sub

    Private Sub txtDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.GotFocus
        Call Get_Property_GotFocus(txtDesc)
    End Sub

    Private Sub txtDesc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.LostFocus
        Call Get_Property_LostFocus(txtDesc)
    End Sub

    Private Sub BindingNavigatorRefreshItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorRefreshItem.Click
        Call RefreshTextBoxes()
        Me.txtCode.Clear()
        editmode = False
        txtCode.ReadOnly = False
        Me.txtCode.Focus()
    End Sub

    Private Sub RefreshTextBoxes()
        'REFRESH FIELDS FOR NEW RECORD
        Me.txtDesc.Clear()
        Me.txtPPrice.Text = "0"
        Me.txtSch1.Text = "0"
        Me.txtSQty1.Text = "0"
        Me.txtSch2.Text = "0"
        Me.txtSQty2.Text = "0"
        Me.txtSch3.Text = "0"
        Me.txtSQty3.Text = "0"
        Me.txtQty.Text = "0"
    End Sub

    Private Sub Get_Text_Values()

        'EDIT PROCEDURE WHILE UPDATE PURCHASES
        If PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(0).Value.ToString.Trim Is Nothing Then gblMessage = "There is no product to delete." : MsgStatus.ShowDialog(Me) : Exit Sub
        If PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(15).Value.ToString.Trim = "RETURN" Then
            txtCode.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(2).Value.ToString.Trim
            gblFind = txtCode.Text.Trim
            txtDesc.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(3).Value.ToString.Trim
            cmbCompany.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(4).Value.ToString.Trim
            txtDate.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(1).Value.ToString
            txtPPrice.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(6).Value.ToString
            txtQty.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(7).Value.ToString * -1
            txtSch1.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(9).Value.ToString
            txtSQty1.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(10).Value.ToString * -1
            txtSch2.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(11).Value.ToString
            txtSQty2.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(12).Value.ToString * -1
            txtSch3.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(13).Value.ToString
            txtSQty3.Text = PurchaseDataGridView.Rows(PurchaseDataGridView.CurrentRow.Index).Cells(14).Value.ToString * -1
            editmode = True
            txtCode.ReadOnly = True
            txtQty.Focus()
        Else
            'gblMessage = "Changes cannot be made, product updated."
            'frmStatus.ShowDialog(Me)
            editmode = False
        End If
    End Sub

    Private Sub Delete_DataRow()
        'Move values from datagrid to variables for deletion
        If editmode = False Then
            Dim DeleteID As String = PurchaseDataGridView.CurrentRow.Cells(0).Value.ToString
            Dim DeleteString As String = PurchaseDataGridView.CurrentRow.Cells(2).Value.ToString
            Dim DeleteDate As String = PurchaseDataGridView.CurrentRow.Cells(1).Value.ToString

            If PurchaseDataGridView.CurrentRow.Cells(0).Value Is Nothing Then Exit Sub
            'Validate deletion if true then show the message on screen.
            If ValidateDelete(DeleteString, DeleteDate) = False Then
                Dim mResult As String = MsgBox("Are you sure ot delete " & DeleteString, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Delete Entry")
                If mResult = MsgBoxResult.Yes Then
                    ExecuteAdapterQuery(SqlDataAdapter, "DELETE FROM PURCHASE WHERE PRCH_TR_ID = N'" & DeleteID & "' AND PRCH_STATUS != N'UPDATED' AND PRCH_CD = N'" & DeleteString.Trim & "' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(DeleteDate), "yyyy-MM-dd") & " 00:00:00',102)", Connection)
                    Call RefreshTextBoxes()
                    Call RefreshGridView()
                    txtCode.Clear()
                    txtCode.Focus()
                End If
            Else
                gblMessage = ("Product updated, Changes cannot be made now, you must be use purchase return option.")
                MsgStatus.ShowDialog(Me)
            End If
        Else
            gblMessage = "You are in edit mode. click refresh to disable."
            MsgStatus.ShowDialog(Me)
        End If

    End Sub

    Private Function ValidateDelete(ByVal strFind As String, ByVal strDate As String) As Boolean
        'Function to check status of purchases transactions
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim cmdText As String = _
           ("SELECT * FROM PURCHASE WHERE (PRCH_CD = N'" & strFind.Trim & "' AND PRCH_STATUS = N'UPDATED' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(strDate.Trim), "yyyy-MM-dd") & " 00:00:00',102))")

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

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        'If CheckRecordExists(Mid(cmbCompany.Text.Trim, 1, 4), "SUPPLIERS", "SUPL_CODE") = True Then
        Dim UpdtRecQuery As String = String.Empty
        Dim Clos_Balance As String = String.Empty
        Max_ID = 0

        'Final Routine to update the products from purchases by date
        Dim TransferQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_STATUS = N'RETURN' ORDER BY PRCH_TR_ID"
        ExecuteAdapterQuery(TransferAdapter, TransferQuery, Connection)
        Dim TransferReader As SqlDataReader = TransferAdapter.SelectCommand.ExecuteReader

        If TransferReader.HasRows Then
            While TransferReader.Read
                If ValidateDelete(TransferReader.Item("PRCH_CD").ToString, TransferReader.Item("PRCH_DATE").ToString) = False Then
                    UpdtRecQuery = String.Empty
                    If CheckRecordExists(TransferReader.Item("PRCH_CD").ToString, "PRODUCTS", "PROD_CD") = True Then
                        'UPDATE RECORD INTO PRODUCT TABLE
                        UpdtRecQuery = "UPDATE PRODUCTS SET " & _
                                                    "PROD_ONHAND = PROD_ONHAND + " & Val(TransferReader.Item("PRCH_QTY").ToString) & ", " & _
                                                    "PROD_SCH1_PRICE = PROD_SCH1_PRICE + " & Val(TransferReader.Item("PRCH_SCH1_PRICE").ToString) & ", " & _
                                                    "PROD_SCH1_ONHAND = PROD_SCH1_ONHAND + " & Val(TransferReader.Item("PRCH_SCH1_ONHAND").ToString) & ", " & _
                                                    "PROD_SCH2_PRICE = PROD_SCH2_PRICE + " & Val(TransferReader.Item("PRCH_SCH2_PRICE").ToString) & ", " & _
                                                    "PROD_SCH2_ONHAND = PROD_SCH2_ONHAND + " & Val(TransferReader.Item("PRCH_SCH2_ONHAND").ToString) & ", " & _
                                                    "PROD_SCH3_PRICE = PROD_SCH3_PRICE + " & Val(TransferReader.Item("PRCH_SCH3_PRICE").ToString) & ", " & _
                                                    "PROD_SCH3_ONHAND = PROD_SCH3_ONHAND + " & Val(TransferReader.Item("PRCH_SCH3_ONHAND").ToString) & ", " & _
                                                    "PROD_DATE = '" & Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "', " & _
                                                    "PROD_UPD_ON = '" & Format(Date.Parse(txtDate.Text.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                                    "WHERE (PROD_CD = N'" & TransferReader.Item("PRCH_CD").ToString & "')"
                    End If
                    ExecuteAdapterQuery(TransferAdapter, UpdtRecQuery, Connection)

                    ' To update suppliers balances
                    Max_ID = GenerateMax_ID("SUPPLIERS", "SUPL_CODE")
                    If Max_ID = 1 Then Max_ID = Max_ID + 1000

                    Dim Total_Amount As Double = (Val(TransferReader.Item("PRCH_PRICE").ToString) * Val(TransferReader.Item("PRCH_QTY").ToString) + _
                                                    Val(TransferReader.Item("PRCH_SCH1_PRICE").ToString) * Val(TransferReader.Item("PRCH_SCH1_ONHAND").ToString) + _
                                                    Val(TransferReader.Item("PRCH_SCH2_PRICE").ToString) * Val(TransferReader.Item("PRCH_SCH2_ONHAND").ToString) + _
                                                    Val(TransferReader.Item("PRCH_SCH3_PRICE").ToString) * Val(TransferReader.Item("PRCH_SCH3_ONHAND").ToString))

                    Dim Total_Quantity As Double = Val(TransferReader.Item("PRCH_QTY").ToString) + _
                                                   Val(TransferReader.Item("PRCH_SCH1_ONHAND").ToString) + _
                                                   Val(TransferReader.Item("PRCH_SCH2_ONHAND").ToString) + _
                                                   Val(TransferReader.Item("PRCH_SCH3_ONHAND").ToString)

                    ' To update journal transactions
                    If Total_Amount < 0 Then
                        Supplr_ID = Supplier_ID(Mid(TransferReader.Item("PRCH_SUPPLIER").ToString, 8, 42))
                        Call Updt_General_Journal(Total_Amount, Total_Quantity, Supplr_ID, TransferReader.Item("PRCH_DATE").ToString, TransferReader.Item("PRCH_DESC").ToString)
                        If CheckRecordExists(Mid(TransferReader.Item("PRCH_SUPPLIER").ToString, 1, 4), "SUPPLIERS", "SUPL_CODE") = True Then
                            '    Clos_Balance = "INSERT INTO SUPPLIERS VALUES (" & _
                            '                                Max_ID & ",'" & _
                            '                                TransferReader.Item("PRCH_SUPPLIER").ToString.Trim & "','" & _
                            '                                "x','" & _
                            '                                "x','" & _
                            '                                "x','" & _
                            '                                "x'," & _
                            '                                Total_Amount & ",'" & _
                            '                                Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "')"
                            'Else
                            Clos_Balance = "UPDATE SUPPLIERS SET " & _
                                                        "SUPL_BALANCE = SUPL_BALANCE + " & _
                                                        Total_Amount & ", SUPL_UPD_DT = N'" & _
                                                        Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "' " & _
                                                        "WHERE SUPL_CODE = N'" & Supplr_ID & "'"
                        End If
                        ExecuteAdapterQuery(SqlDataAdapter, Clos_Balance, Connection)
                    End If
                    'To upddate status of purchases to avoid duplication
                    Call ValidatePurchases(TransferReader.Item("PRCH_CD").ToString, TransferReader.Item("PRCH_DATE").ToString)
                    Total_Amount = Nothing
                Else
                    'Skip Check
                End If
            End While
            If TransferReader Is Nothing Then TransferReader.Close()
            BindingNavigatorSaveItem.Enabled = False
            DataFinalize = True
        End If
        GridEdit = False
        Call RefreshGridView()
        'Else
        'gblMessage = "Please select valid wholesaler for purchase return."
        'frmMsgStatus.ShowDialog(Me)
        'End If
    End Sub

    Private Sub ValidatePurchases(ByVal strFind As String, ByVal strDate As String)
        'Procedure to update status of purchases to avoid duplication
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim cmdText As String = _
           ("UPDATE PURCHASE SET PRCH_STATUS = N'UPDATED' WHERE (PRCH_CD = N'" & strFind.Trim & "' AND PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(strDate.Trim), "yyyy-MM-dd") & " 00:00:00',102))")

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader

                End Using
            End Using
        End Using

    End Sub

    Private Function CheckRecordExists(ByVal strFind As String, ByVal tblName As String, ByVal strField As String) As Boolean

        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")

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

    Private Sub Updt_General_Journal(ByVal TotalAmount As Double, ByVal Total_Qty As Double, ByVal strSupplierID As Integer, ByVal strDate As String, ByVal strDesc As String)
        'Function to add item if does not exist in item table.
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POSR;")
        Dim Trans_ID, Opn_Bal, Clo_Bal As Double
        Dim Supplier_Name As String = String.Empty
        Trans_ID = 0
        Opn_Bal = 0
        Clo_Bal = 0
        ' To made general journal transaction for concerned suppliers while update products
        Dim Max_Tr As Double = GenerateMax_ID("SUPPLIERS_PAYM", "SUPL_TR_ID")

        Dim Get_Supplier As String = "select * from suppliers where supl_code = " & strSupplierID
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Supplier_Name = SuppliersReader.Item("SUPL_NAME").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("SUPL_BALANCE").ToString.Trim)
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        Else
            Opn_Bal = 0
        End If

        Trans_ID = GenerateMax_ID("SUPPLIERS_PAYM", "SUPL_TR_ID")
        TotalAmount = TotalAmount * (-1)
        Clo_Bal = Opn_Bal - TotalAmount

        'If CheckRecordExists(strCode.ToString, "ITEMS", "ITEM_CODE") = False Then
        Dim cmdText As String = _
           ("INSERT INTO SUPPLIERS_PAYM VALUES ('" & strSupplierID & "','" & Format(Date.Parse(txtDate.Text.ToString), "MM/dd/yyyy") & "','" & Trans_ID & "','" & Supplier_Name & "','" & "Purchases (" & strDesc.Trim & ") returns (" & Total_Qty & ")'," & Opn_Bal & "," & TotalAmount & ",0," & Clo_Bal & ",'" & Format(Date.Parse(strDate.ToString), "MM/dd/yyyy") & "')")

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

    Public Function Supplier_ID(ByVal strName As String) As Integer
        Dim ID_Text As String = "SELECT SUPL_CODE FROM SUPPLIERS WHERE SUPL_NAME = N'" & strName.Trim & "'"
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(ID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    Supplier_ID = 0
                Else
                    Supplier_ID = Convert.ToDecimal(Cmd.ExecuteScalar())
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return Supplier_ID
        End Using
    End Function

    Private Sub txtDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then cmbCompany.Focus()
    End Sub

End Class