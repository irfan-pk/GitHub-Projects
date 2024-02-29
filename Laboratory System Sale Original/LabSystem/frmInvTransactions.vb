Imports System
Imports System.Data.SqlTypes
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmInvTransactions
    Dim ReturnRmk As String
    Dim Retail_Price, Purchase_Price As Double

    Private Sub frmInvTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyReader As SqlDataReader
        Call GetConnectionString()
        'Procedure for Filling Data in combo boxes
        Dim CodeQuery As String = "SELECT INV_CODE FROM INVENTORY ORDER BY INV_CODE"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CodeQuery, "INVENTORY", Connection)
        MyReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While MyReader.Read
            cmbCode.Items.Add(MyReader.Item("INV_CODE"))
        End While

        Dim RetailerQuery As String = "SELECT CP_NAME FROM COMPANY ORDER BY CP_NAME"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, RetailerQuery, "COMPANY", Connection)
        MyReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While MyReader.Read
            cmbRetailer.Items.Add(MyReader.Item("CP_NAME"))
            RComboBox.Items.Add(MyReader.Item("CP_NAME"))
        End While
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        ReturnRmk = ""

    End Sub

    Private Sub cmbCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCode.SelectedIndexChanged

        If cmbCode.Text.Trim.ToUpper = "" Then
            MsgBox("Please select correct code.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName)
            Exit Sub
        End If

        Call Refresh_Record("SELECT")
        Call Refresh_Record("UPDATED")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SqlDataAdapt.Dispose()
        SqlDataSet.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdUpdateRcv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateRcv.Click

        If cmbRetailer.Text = "" Or txtInvoice.Text = "" Or txtRcvQty.Text = "" Then MsgBox("Please give Required Data for Update.", MsgBoxStyle.Information) : Exit Sub

        SqlDataSet.Clear()
        Dim ChemicalInfo As String = "Select * from INV_TRANSACTIONS where TRS_CODE = '" & cmbCode.Text.Trim.ToUpper & "'" & _
                                     " AND (TRS_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) AND" & _
                                     " TRS_STATUS = 'ADD'"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, ChemicalInfo, "INV_TRANSACTIONS", Connection)
        Dim objDataTable As New Data.DataTable("INV_TRANSACTIONS")
        SqlDataAdapt.Fill(objDataTable)

        If objDataTable.Rows.Count > 0 Then
            Call DisplayMessage("Transaction already made for this category.")
            Exit Sub
        End If

        If Val(txtRetail.Text.Trim) = 0 Then
            Retail_Price = Val(txtInvRetail.Text.Trim)
        Else
            Retail_Price = Val(txtInvRetail.Text.Trim)
        End If

        If Val(txtPurchase.Text.Trim) = 0 Then
            Purchase_Price = Val(txtInvRetail.Text.Trim)
        Else
            Purchase_Price = Val(txtInvPurchase.Text.Trim)
        End If

        Dim Updt_Query As String

        If txtType.Text = "V" Or txtType.Text = "S" Then
            Dim Qty_R1 As String
            Qty_R1 = Val(txtPack.Text.Trim) * Val(txtRcvQty.Text.Trim)

            'Try

            Dim UpdtCommandText As String = "INSERT INTO INV_TRANSACTIONS VALUES ('" & _
                                                Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','" & _
                                                txtInvoice.Text.Trim & "','" & _
                                                cmbCode.Text.Trim & "','" & _
                                                cmbRetailer.Text.Trim & "','Chemical Purchases from " & _
                                                cmbRetailer.Text.Trim & "','" & _
                                                txtType.Text.Trim & "'," & _
                                                Val(txtRcvQty.Text.Trim) & ",'" & _
                                                txtPack.Text.Trim & "','" & _
                                                txtP1.Text.Trim & "',0,0," & _
                                                Retail_Price & ",'" & _
                                                Purchase_Price & "','" & _
                                                Format(DateTime.Parse(DateTime.Now), "MM/dd/yyyy") & "'," & _
                                                Val(txtQty.Text.Trim) & "," & _
                                                Val(txtR1.Text.Trim) & "," & _
                                                Val(txtR2.Text.Trim) & ",0,0,0,'ADD')"

            Execute_DatabaseTable_Query(SqlDataAdapt, UpdtCommandText, Connection)

            '// Execute Qeury to update record in database
            Updt_Query = "UPDATE INVENTORY SET INV_HAND_Q1 = (INV_HAND_Q1 + " & Qty_R1 & ")," & _
                         " INV_PCK_PRICE = " & Retail_Price & "," & _
                         " INV_PCH_PRICE = " & Purchase_Price & "," & _
                         " INV_UPD_DT = '" & Format(DateTime.Parse(InvDate.Text), "MM/dd/yyyy") & "'" & _
                         " WHERE INV_CODE = '" & cmbCode.Text.Trim & "'"

            Execute_DatabaseTable_Query(SqlDataAdapt, Updt_Query, Connection)
            Call Refresh_Record("SELECT")
            Call Refresh_Record("UPDATED")
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            'End Try
        End If

        If txtType.Text = "R" Then
            Dim Qty_R1, Qty_R2 As String
            Qty_R1 = Val(txtPack.Text.Trim) * Val(txtRcvQty.Text.Trim)
            Qty_R2 = Val(txtRPack.Text.Trim) * Val(txtRcvQty.Text.Trim)

            Try

                Dim UpdtCommandText As String = "INSERT INTO INV_TRANSACTIONS VALUES ('" & _
                                                    Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','" & _
                                                    txtInvoice.Text.Trim & "','" & _
                                                    cmbCode.Text.Trim & "','" & _
                                                    cmbRetailer.Text.Trim & "','Chemical Purchases from " & _
                                                    cmbRetailer.Text.Trim & "','" & _
                                                    txtType.Text.Trim & "'," & _
                                                    Val(txtRcvQty.Text.Trim) & ",'" & _
                                                    txtPack.Text.Trim & "x" & txtRPack.Text.Trim & "','" & _
                                                    txtP1.Text.Trim & "'," & _
                                                    Qty_R1 & "," & _
                                                    Qty_R2 & "," & _
                                                    Retail_Price & ",'" & _
                                                    Purchase_Price & "','" & _
                                                    Format(DateTime.Parse(DateTime.Now), "MM/dd/yyyy") & "'," & _
                                                    Val(txtQty.Text.Trim) & "," & _
                                                    Val(txtR1.Text.Trim) & "," & _
                                                    Val(txtR2.Text.Trim) & ",0,0,0,'ADD')"

                Execute_DatabaseTable_Query(SqlDataAdapt, UpdtCommandText, Connection)

                '// Execute Qeury to update record in database
                Updt_Query = "UPDATE INVENTORY SET INV_HAND_R1 = (INV_HAND_R1 + " & Qty_R1 & ")," & _
                             " INV_HAND_R2 = (INV_HAND_R2 + " & Qty_R2 & ")," & _
                             " INV_PCK_PRICE = " & Retail_Price & "," & _
                             " INV_PCH_PRICE = " & Purchase_Price & "," & _
                             " INV_UPD_DT = '" & Format(DateTime.Parse(InvDate.Text), "MM/dd/yyyy") & "'" & _
                             " WHERE INV_CODE = '" & cmbCode.Text.Trim & "'"

                Execute_DatabaseTable_Query(SqlDataAdapt, Updt_Query, Connection)
                Call Refresh_Record("SELECT")
                Call Refresh_Record("UPDATED")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End If

        txtInvoice.Clear()
        txtRcvQty.Clear()
        txtRetail.Clear()
        txtPurchase.Clear()

    End Sub

    Private Sub Refresh_Record(ByVal strChoice As String)

        Select Case strChoice

            Case "SELECT"

                SqlDataSet.Clear()
                Dim ChemicalInfo As String = "Select * from Inventory where INV_CODE = '" & cmbCode.Text.Trim.ToUpper & "' order by INV_CODE"
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, ChemicalInfo, "INVENTORY", Connection)
                Dim objDataTable As New Data.DataTable("INVENTORY")
                Dim objDataRow As DataRow
                SqlDataAdapt.Fill(objDataTable)

                If objDataTable.Rows.Count > 0 Then
                    For Each objDataRow In objDataTable.Rows
                        Me.txtDesc.Text = Trim(objDataRow.Item("INV_DESCRIPTION"))
                        Me.txtType.Text = Trim(objDataRow.Item("INV_QTY_TYPE"))
                        If txtType.Text.Trim = "R" Then
                            Me.txtPack.Text = Mid(Trim(objDataRow.Item("INV_PPACK_R")), 1, 3)
                            Me.txtRPack.Text = Mid(Trim(objDataRow.Item("INV_PPACK_R")), 5, 3)
                        Else
                            Me.txtPack.Text = Trim(objDataRow.Item("INV_PER_PACK"))
                            Me.txtRPack.Text = "-"
                        End If
                        Me.txtQty.Text = Trim(objDataRow.Item("INV_HAND_Q1"))
                        Me.txtP1.Text = Trim(objDataRow.Item("INV_PACK"))
                        Me.txtR1.Text = Trim(objDataRow.Item("INV_HAND_R1"))
                        Me.txtR2.Text = Trim(objDataRow.Item("INV_HAND_R2"))
                        Me.txtInvRetail.Text = Trim(objDataRow.Item("INV_PCK_PRICE"))
                        Me.txtInvPurchase.Text = Trim(objDataRow.Item("INV_PCH_PRICE"))
                    Next
                    GroupBox2.Enabled = True
                    GroupBox1.Enabled = True
                Else
                    Call DisplayMessage("Invalid code for selection.")
                End If

            Case "UPDATED"
                InvTranDataSet.Clear()
                Dim Transaction_Record As String = "Select * from INV_TRANSACTIONS WHERE (TRS_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102))"
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Transaction_Record, "INV_TRANSACTIONS", Connection)
                SqlDataAdapt.Fill(InvTranDataSet, "INV_TRANSACTIONS")
                InvTranBindingSource.DataSource = InvTranDataSet
                InvTranBindingSource.DataMember = "INV_TRANSACTIONS"
                RcvDataGridView.Update()
                RcvDataGridView.RefreshEdit()
                txtRcvQty.Clear()
                txtIssuQty.Clear()
                txtIssuR1.Clear()
                txtIssuR2.Clear()

        End Select

    End Sub

    Private Sub cmdUpdateIssu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateIssu.Click

        SqlDataSet.Clear()
        Dim ChemicalInfo As String = "Select * from INV_TRANSACTIONS where TRS_CODE = '" & cmbCode.Text.Trim.ToUpper & "'" & _
                                     " AND (TRS_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) AND" & _
                                     " TRS_STATUS = 'ISSUE'"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, ChemicalInfo, "INV_TRANSACTIONS", Connection)
        Dim objDataTable As New Data.DataTable("INV_TRANSACTIONS")
        SqlDataAdapt.Fill(objDataTable)

        If objDataTable.Rows.Count > 0 Then
            Call DisplayMessage("Transaction already made for this category.")
            Exit Sub
        End If

        Dim Updt_Query As String

        If txtType.Text = "V" Or txtType.Text = "S" Then
            If txtIssuQty.Text.Trim = "" Then MsgBox("Please give Quantity for Update.", MsgBoxStyle.Information) : Exit Sub
            'Try
            Dim UpdtCommandText As String = "INSERT INTO INV_TRANSACTIONS VALUES ('" & _
                                                Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','','" & _
                                                cmbCode.Text.Trim & "','" & _
                                                "x','" & _
                                                "Chemical issued to Chemistry Section.','" & _
                                                txtType.Text.Trim & "',0,'" & _
                                                txtPack.Text.Trim & "','" & _
                                                txtP1.Text.Trim & "',0,0,0,0,'" & _
                                                Format(DateTime.Parse(DateTime.Now), "MM/dd/yyyy") & "'," & _
                                                Val(txtQty.Text.Trim) & "," & _
                                                Val(txtR1.Text.Trim) & "," & _
                                                Val(txtR2.Text.Trim) & "," & Val(txtIssuQty.Text.Trim) & ",0,0,'ISSUE')"

            Execute_DatabaseTable_Query(SqlDataAdapt, UpdtCommandText, Connection)

            '// Execute Qeury to update record in database
            Updt_Query = "UPDATE INVENTORY SET INV_HAND_Q1 = (INV_HAND_Q1 - " & Val(txtIssuQty.Text.Trim) & ")," & _
                         " INV_UPD_DT = '" & Format(DateTime.Parse(InvDate.Text), "MM/dd/yyyy") & "'" & _
                         " WHERE INV_CODE = '" & cmbCode.Text.Trim & "'"

            Execute_DatabaseTable_Query(SqlDataAdapt, Updt_Query, Connection)
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            'End Try
        End If

        If txtType.Text = "R" Then
            If txtIssuR1.Text.Trim = "" Or txtIssuR2.Text.Trim = "" Then MsgBox("Please give Quantity for Update.", MsgBoxStyle.Information) : Exit Sub
            Dim Qty_R1, Qty_R2 As String
            Qty_R1 = Val(txtPack.Text.Trim) * Val(txtRcvQty.Text.Trim)
            Qty_R2 = Val(txtRPack.Text.Trim) * Val(txtRcvQty.Text.Trim)

            Try
                Dim UpdtCommandText As String = "INSERT INTO INV_TRANSACTIONS VALUES ('" & _
                                                Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','','" & _
                                                cmbCode.Text.Trim & "','" & _
                                                "x','" & _
                                                "Chemical issued to Chemistry Section.','" & _
                                                txtType.Text.Trim & "',0,'" & _
                                                txtPack.Text.Trim & "x" & txtRPack.Text.Trim & "','" & _
                                                txtP1.Text.Trim & "',0,0,0,0,'" & _
                                                Format(DateTime.Parse(DateTime.Now), "MM/dd/yyyy") & "'," & _
                                                Val(txtQty.Text.Trim) & "," & _
                                                Val(txtR1.Text.Trim) & "," & _
                                                Val(txtR2.Text.Trim) & ",0," & Val(txtIssuR1.Text.Trim) & "," & Val(txtIssuR2.Text.Trim) & ",'ISSUE')"

                Execute_DatabaseTable_Query(SqlDataAdapt, UpdtCommandText, Connection)

                '// Execute Qeury to update record in database
                Updt_Query = "UPDATE INVENTORY SET INV_HAND_R1 = (INV_HAND_R1 - " & Val(txtIssuR1.Text.Trim) & ")," & _
                             "INV_HAND_R2 = (INV_HAND_R2 - " & Val(txtIssuR2.Text.Trim) & ")," & _
                             " INV_UPD_DT = '" & Format(DateTime.Parse(InvDate.Text), "MM/dd/yyyy") & "'" & _
                             " WHERE INV_CODE = '" & cmbCode.Text.Trim & "'"

                Execute_DatabaseTable_Query(SqlDataAdapt, Updt_Query, Connection)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End If

        Call Refresh_Record("SELECT")
        Call Refresh_Record("UPDATED")
        txtIssuQty.Clear()
        txtIssuR1.Clear()
        txtIssuR2.Clear()

    End Sub

    Private Sub cmdReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.Click


        SqlDataSet.Clear()
        Dim ChemicalInfo As String = "Select * from INV_TRANSACTIONS where TRS_CODE = '" & cmbCode.Text.Trim.ToUpper & "'" & _
                                     " AND (TRS_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) AND" & _
                                     " TRS_STATUS = '" & ReturnRmk & "'"

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, ChemicalInfo, "INV_TRANSACTIONS", Connection)
        Dim objDataTable As New Data.DataTable("INV_TRANSACTIONS")
        SqlDataAdapt.Fill(objDataTable)

        If objDataTable.Rows.Count > 0 Then
            Call DisplayMessage("Transaction already made for this category.")
            Exit Sub
        End If

        Dim Updt_Query, Remarks As String
        Remarks = ""
        If RadioButton1.Checked = True Then Remarks = "Chemical Return to Stock."
        If RadioButton2.Checked = True Then Remarks = StrConv("Chemical Return to " & RComboBox.Text.Trim, VbStrConv.ProperCase)

        If txtType.Text = "V" Or txtType.Text = "S" Then
            If RetQty.Text.Trim = "" Then MsgBox("Please give Required Data for Update.", MsgBoxStyle.Information) : Exit Sub
            'Try
            Dim UpdtCommandText As String = "INSERT INTO INV_TRANSACTIONS VALUES ('" & _
                                                Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','','" & _
                                                cmbCode.Text.Trim & "','" & _
                                                "x','" & _
                                                Remarks & "','" & _
                                                txtType.Text.Trim & "',0,'" & _
                                                txtPack.Text.Trim & "','" & _
                                                txtP1.Text.Trim & "',0,0,0,0,'" & _
                                                Format(DateTime.Parse(DateTime.Now), "MM/dd/yyyy") & "'," & _
                                                Val(txtQty.Text.Trim) & "," & _
                                                Val(txtR1.Text.Trim) & "," & _
                                                Val(txtR2.Text.Trim) & "," & (Val(RetQty.Text.Trim) * -1) & ",0,0,'" & ReturnRmk & "')"

            Execute_DatabaseTable_Query(SqlDataAdapt, UpdtCommandText, Connection)

            '// Execute Qeury to update record in database
            Updt_Query = "UPDATE INVENTORY SET INV_HAND_Q1 = (INV_HAND_Q1 + " & Val(RetQty.Text.Trim) & ")," & _
                         " INV_UPD_DT = '" & Format(DateTime.Parse(InvDate.Text), "MM/dd/yyyy") & "'" & _
                         " WHERE INV_CODE = '" & cmbCode.Text.Trim & "'"

            Execute_DatabaseTable_Query(SqlDataAdapt, Updt_Query, Connection)
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            'End Try
        End If

        If txtType.Text = "R" Then
            If RetR1.Text.Trim = "" Or RetR2.Text.Trim Then MsgBox("Please give Required Data for Update.", MsgBoxStyle.Information) : Exit Sub
            Dim Qty_R1, Qty_R2 As String
            Qty_R1 = Val(RetR1.Text.Trim)
            Qty_R2 = Val(RetR2.Text.Trim)

            Try
                Dim UpdtCommandText As String = "INSERT INTO INV_TRANSACTIONS VALUES ('" & _
                                                Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','','" & _
                                                cmbCode.Text.Trim & "','" & _
                                                "x','" & _
                                                Remarks & "','" & _
                                                txtType.Text.Trim & "',0,'" & _
                                                txtPack.Text.Trim & "x" & txtRPack.Text.Trim & "','" & _
                                                txtP1.Text.Trim & "',0,0,0,0,'" & _
                                                Format(DateTime.Parse(DateTime.Now), "MM/dd/yyyy") & "'," & _
                                                Val(txtQty.Text.Trim) & "," & _
                                                Val(txtR1.Text.Trim) & "," & _
                                                Val(txtR2.Text.Trim) & ",0," & (Val(RetR1.Text.Trim) * -1) & "," & (Val(RetR2.Text.Trim) * -1) & ",'" & ReturnRmk & "')"

                Execute_DatabaseTable_Query(SqlDataAdapt, UpdtCommandText, Connection)

                '// Execute Qeury to update record in database
                Updt_Query = "UPDATE INVENTORY SET INV_HAND_R1 = (INV_HAND_R1 + " & Val(RetR1.Text.Trim) & ")," & _
                             "INV_HAND_R2 = (INV_HAND_R2 + " & Val(RetR2.Text.Trim) & ")," & _
                             " INV_UPD_DT = '" & Format(DateTime.Parse(InvDate.Text), "MM/dd/yyyy") & "'" & _
                             " WHERE INV_CODE = '" & cmbCode.Text.Trim & "'"

                Execute_DatabaseTable_Query(SqlDataAdapt, Updt_Query, Connection)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End If

        Call Refresh_Record("SELECT")
        Call Refresh_Record("UPDATED")
        RetQty.Clear()
        RetR1.Clear()
        RetR2.Clear()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then RComboBox.Enabled = True
        ReturnRmk = "CANCEL"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then RComboBox.Enabled = False
        ReturnRmk = "RETURN"
    End Sub
End Class