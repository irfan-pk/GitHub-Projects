Imports System
Imports System.Data.SqlTypes
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmInvTransactions
    Dim MyReader As SqlDataReader
    Dim ReturnRmk As String
    Dim Retail_Price, Purchase_Price As Double

    Private Sub frmInvTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        Dim CodeQuery As String = "SELECT INV_CODE FROM INVENTORY ORDER BY INV_CODE"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CodeQuery, "INVENTORY", Connection)
        MyReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While MyReader.Read
            cmbCode.Items.Add(MyReader.Item("INV_CODE"))
        End While
        If MyReader Is Nothing Then MyReader.Close()
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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        SqlDataAdapt.Dispose()
        SqlDataSet.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdUpdateRcv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateRcv.Click

        SqlDataSet.Clear()
        Dim ChemicalInfo As String = "Select * from INV_TRANS where TRS_CODE = '" & cmbCode.Text.Trim.ToUpper & "'" & _
                                     " AND (TRS_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)) AND" & _
                                     " TRS_STATUS = 'ADD'"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, ChemicalInfo, "INV_TRANS", Connection)
        Dim objDataTable As New Data.DataTable("INV_TRANS")
        SqlDataAdapt.Fill(objDataTable)

        If objDataTable.Rows.Count > 0 Then
            Call DisplayMessage("Transaction already made for this category.")
            Exit Sub
        End If

        Dim Updt_Query As String
        'Try

        Dim NewRecCommand As String = "INSERT INTO INV_TRANS VALUES ('" & _
                                            Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','" & _
                                            txtInvoice.Text.Trim & "','" & _
                                            cmbCode.Text.Trim & "','" & _
                                            txtDesc.Text.Trim & "','" & _
                                            txtRetailer.Text.Trim & " )'," & _
                                            Val(txtRcvQty.Text.Trim) & "," & _
                                            "0," & _
                                            Val(txtBalance.Text.Trim) & "," & _
                                            "'ADD')"
        Execute_DatabaseTable_Query(SqlDataAdapt, NewRecCommand, Connection)

        '// Execute Qeury to update record in database
        Updt_Query = "UPDATE INVENTORY SET INV_IN_HAND = (INV_IN_HAND + " & Val(txtRcvQty.Text.Trim) & ")," & _
                     " INV_PCK_PRICE = " & Retail_Price & "," & _
                     " INV_UPD_DT = '" & Format(DateTime.Parse(InvDate.Text), "MM/dd/yyyy") & "'" & _
                     " WHERE INV_CODE = '" & cmbCode.Text.Trim & "'"

        Execute_DatabaseTable_Query(SqlDataAdapt, Updt_Query, Connection)
        Call Refresh_Record("SELECT")
        Call Refresh_Record("UPDATED")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try

        txtInvoice.Clear()
        txtRcvQty.Clear()
        txtRetailer.Clear()

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
                        Me.txtBalance.Text = Trim(objDataRow.Item("INV_IN_HAND"))
                    Next
                    GroupBox2.Enabled = True
                    GroupBox1.Enabled = True
                Else
                    Call DisplayMessage("Invalid code for selection.")
                End If

            Case "UPDATED"

                InvTranDataSet.Clear()
                Dim Transaction_Record As String = "Select * from INV_TRANS WHERE (TRS_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(InvDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102))" '// AND TRS_CODE ='" & cmbCode.Text.Trim & "'"
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, Transaction_Record, "INV_TRANS", Connection)
                SqlDataAdapt.Fill(InvTranDataSet, "INV_TRANS")
                InvTranBindingSource.DataSource = InvTranDataSet
                InvTranBindingSource.DataMember = "INV_TRANS"
                RcvDataGridView.Update()
                RcvDataGridView.RefreshEdit()
                txtRcvQty.Clear()

        End Select

    End Sub

End Class