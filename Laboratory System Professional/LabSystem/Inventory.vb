Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Inventory
    Dim Pos As Integer
    Dim EditString, PerPack As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Call LoadDB_Values()
    End Sub

    Private Sub LoadDB_Values()
        Try
            Me.InvDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM INVENTORY ORDER BY INV_CODE"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "INVENTORY", Connection)
            SqlDataAdapter.Fill(Me.InvDataSet, "INVENTORY")
            Me.InvBindingSource.DataSource = Me.InvDataSet
            Me.InvBindingSource.DataMember = "INVENTORY"
            Me.txtInvID.DataBindings.Add("TEXT", InvBindingSource, "INV_CODE")
            Me.txtInvName.DataBindings.Add("TEXT", InvBindingSource, "INV_DESCRIPTION")
            Me.cmbType.DataBindings.Add("TEXT", InvBindingSource, "INV_QTY_TYPE")
            Me.txtPerPack.DataBindings.Add("TEXT", InvBindingSource, "INV_PER_PACK")
            Me.txtRPack.DataBindings.Add("TEXT", InvBindingSource, "INV_PPACK_R")
            Me.txtQty.DataBindings.Add("TEXT", InvBindingSource, "INV_HAND_Q1")
            Me.txtPacking.DataBindings.Add("TEXT", InvBindingSource, "INV_PACK")
            Me.txtR1.DataBindings.Add("TEXT", InvBindingSource, "INV_HAND_R1")
            Me.txtR2.DataBindings.Add("TEXT", InvBindingSource, "INV_HAND_R2")
            Me.txtRetail.DataBindings.Add("TEXT", InvBindingSource, "INV_PCK_PRICE")
            Me.txtPrice.DataBindings.Add("TEXT", InvBindingSource, "INV_PCH_PRICE")
            Me.dtpUpdateOn.DataBindings.Add("TEXT", InvBindingSource, "INV_UPD_DT")
            Addition = False
            Editing = False
            Me.BindingNavigatorSaveItem.Enabled = False
            Me.Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            InvDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        Dim strCode As String
        strCode = Microsoft.VisualBasic.InputBox("Please Enter Inventory Code To Find.", "Find")
        If Len(strCode) = 0 Or "" Then Exit Sub
        Pos = Me.InvBindingSource.Find("INV_CODE", Val(strCode.Trim))
        If Not Pos = -1 Then
            EditString = strCode
            Me.InvBindingSource.Position = Pos
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Panel1.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        Me.BindingNavigatorSaveItem.Enabled = True
        Me.txtRPack.Visible = False
        Me.BindingNavigatorCloseItem.Text = "&Cancel"
        Me.txtInvID.Focus()
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click
        Editing = True
        Addition = False
        EditString = txtInvID.Text.Trim
        BindingNavigatorSaveItem.Enabled = True
        Panel1.Enabled = True
        If cmbType.Text = "R" Then
            Me.txtRPack1.Text = Format(Val(Mid(txtRPack.Text.Trim, 1, 3)), "000")
            Me.txtRPack2.Text = Format(Val(Mid(txtRPack.Text.Trim, 5, 3)), "000")
        Else
            txtRPack1.Clear()
            txtRPack2.Clear()
        End If
        Me.txtRPack.Visible = False
        BindingNavigatorCloseItem.Text = "&Cancel"
        EditString = txtInvID.Text.Trim
        txtInvID.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtInvName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM INVENTORY WHERE INV_CODE = '" & txtInvID.Text.ToUpper.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
            Me.InvDataGrid.Update()
            'Call clear_text_boxes()
        Else
            Call RefreshDB()
        End If
        If Me.BindingNavigatorCloseItem.Text = "&Cancel" Then Me.BindingNavigatorCloseItem.Text = "&Close"
    End Sub

    Private Sub BindingNavigatorCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCloseItem.Click
        If Me.BindingNavigatorCloseItem.Text = "&Close" Then
            Connection.Close()
            Me.InvBindingSource.Dispose()
            Me.Close()
        Else
            Me.BindingNavigatorCloseItem.Text = "&Close"
            Me.BindingNavigatorSaveItem.Enabled = False
            Panel1.Enabled = False
            Me.txtRPack.Visible = True
            Call RefreshDB()
            Addition = False
            Editing = False
        End If
    End Sub

    Private Sub BindingNavigatorQuery(ByVal Query As String)
        'Try
        Execute_DatabaseTable_Query(SqlDataAdapter, Query, Connection)
        Connection.Close()
        SqlDataAdapter.Dispose()
        'Catch ex As Exception
        'MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click

        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE INVENTORY SET INV_DESCRIPTION = '" & StrConv(txtInvName.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                                           " INV_CODE = '" & txtInvID.Text.ToUpper.Trim & "'," & _
                                                           " INV_QTY_TYPE = '" & Mid(cmbType.Text.ToUpper.Trim, 1, 1) & "'," & _
                                                           " INV_PER_PACK = '" & txtPerPack.Text.Trim & "'," & _
                                                           " INV_PPACK_R = '" & txtRPack1.Text.Trim & "x" & txtRPack2.Text.Trim & "'," & _
                                                           " INV_HAND_Q1 = " & Val(txtQty.Text.Trim) & "," & _
                                                           " INV_PACK = '" & txtPacking.Text.Trim & "'," & _
                                                           " INV_HAND_R1 = " & Val(txtR1.Text.Trim) & "," & _
                                                           " INV_HAND_R2 = " & Val(txtR2.Text.Trim) & "," & _
                                                           " INV_PCK_PRICE = " & Val(txtRetail.Text.Trim) & "," & _
                                                           " INV_PCH_PRICE = " & Val(txtPrice.Text.Trim) & "," & _
                                                           " INV_UPD_DT = '" & Format(DateTime.Parse(dtpUpdateOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'" & _
                                                           " WHERE INV_CODE = '" & EditString & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO INVENTORY VALUES('" & txtInvID.Text.ToUpper.Trim & "','" & _
                                                           StrConv(txtInvName.Text.ToUpper.Trim, VbStrConv.Uppercase) & "','" & _
                                                           Mid(cmbType.Text.ToUpper.Trim, 1, 1) & "','" & _
                                                           txtPerPack.Text.Trim & "'," & _
                                                           Val(txtQty.Text.Trim) & ",'" & _
                                                           txtRPack1.Text.Trim & "x" & txtRPack2.Text.Trim & "'," & _
                                                           Val(txtR1.Text.Trim) & "," & _
                                                           Val(txtR2.Text.Trim) & "," & _
                                                           txtPacking.Text.Trim & " ML'," & _
                                                           Val(txtRetail.Text.Trim) & "," & _
                                                           Val(txtPrice.Text.Trim) & ",'" & _
                                                           Format(DateTime.Parse(dtpUpdateOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "')")

        Call RefreshDB()
        Me.BindingNavigatorSaveItem.Enabled = False
        Panel1.Enabled = False
        Editing = False
        Addition = False
        Me.BindingNavigatorEditItem.Enabled = True
        Me.BindingNavigatorCloseItem.Text = "&Close"

    End Sub

    Private Sub RefreshDB()
        Try
            Me.InvDataSet.Clear()
            SqlDataAdapter.Dispose()
            Me.InvDataGrid.Refresh()
            Dim QueryText As String = "SELECT * FROM INVENTORY ORDER BY INV_CODE"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "INVENTORY", Connection)
            SqlDataAdapter.Fill(Me.InvDataSet, "INVENTORY")
            Me.InvBindingSource.DataSource = Me.InvDataSet
            Me.InvBindingSource.DataMember = "INVENTORY"
            Me.InvDataGrid.RefreshEdit()
            Me.InvDataGrid.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub cmbType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbType.KeyDown
        If e.KeyCode = Keys.Enter Then Call cmbType_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.LostFocus
        If cmbType.Text.Trim = "" Then
            MsgBox("Please select correct reagent type.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName)
            Exit Sub
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        txtPerPack.Focus()
    End Sub

    Private Sub clear_text_boxes()
        Me.txtInvID.Text = ""
        Me.txtInvName.Text = ""
        Me.cmbType.Text = ""
        Me.txtPerPack.Text = ""
        Me.txtQty.Text = ""
        Me.txtPacking.Text = ""
        Me.txtRPack1.Text = ""
        Me.txtRPack2.Text = ""
        Me.txtR1.Text = ""
        Me.txtR2.Text = ""
        Me.txtRetail.Text = ""
        Me.txtPrice.Text = ""
    End Sub

End Class