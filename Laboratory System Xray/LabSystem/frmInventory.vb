Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmInventory
    Dim Pos As Integer
    Dim EditString, PerPack As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Call LoadDB_Values()
    End Sub

    Private Sub LoadDB_Values()
        'Try
        Me.InvDataSet.Clear()
        Dim CommandText As String = "SELECT * FROM INVENTORY ORDER BY INV_CODE"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "INVENTORY", Connection)
        SqlDataAdapt.Fill(Me.InvDataSet, "INVENTORY")
        Me.InvBindingSource.DataSource = Me.InvDataSet
        Me.InvBindingSource.DataMember = "INVENTORY"
        Me.txtInvID.DataBindings.Add("TEXT", InvBindingSource, "INV_CODE")
        Me.txtInvName.DataBindings.Add("TEXT", InvBindingSource, "INV_DESCRIPTION")
        Me.txtQty.DataBindings.Add("TEXT", InvBindingSource, "INV_IN_HAND")
        Me.txtRetail.DataBindings.Add("TEXT", InvBindingSource, "INV_PCK_PRICE")
        Me.dtpUpdateOn.DataBindings.Add("TEXT", InvBindingSource, "INV_UPD_DT")
        Addition = False
        Editing = False
        Me.BindingNavigatorSaveItem.Enabled = False
        Me.Panel1.Enabled = False
        objCellStyle.BackColor = Color.WhiteSmoke
        InvDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        '    Me.Close()
        'End Try
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
        Me.BindingNavigatorCloseItem.Text = "&Cancel"
        EditString = ""
        Me.txtInvID.Focus()
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click
        Editing = True
        Addition = False
        EditString = txtInvID.Text.Trim
        BindingNavigatorSaveItem.Enabled = True
        Panel1.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        EditString = txtInvID.Text.Trim
        txtInvID.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtInvName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM INVENTORY WHERE INV_CODE = '" & txtInvID.Text.ToUpper.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
            Me.InvDataGrid.Update()
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
            Call RefreshDB()
            Addition = False
            Editing = False
        End If

    End Sub

    Private Sub BindingNavigatorQuery(ByVal Query As String)
        Try
            Execute_DatabaseTable_Query(SqlDataAdapt, Query, Connection)
            Connection.Close()
            SqlDataAdapt.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click

        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE INVENTORY SET INV_DESCRIPTION = '" & StrConv(txtInvName.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                                           " INV_CODE = '" & txtInvID.Text.ToUpper.Trim & "'," & _
                                                           " INV_IN_HAND = " & Val(txtQty.Text.Trim) & "," & _
                                                           " INV_PCK_PRICE = " & Val(txtRetail.Text.Trim) & "," & _
                                                           " INV_UPD_DT = '" & Format(DateTime.Parse(dtpUpdateOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'" & _
                                                           " WHERE INV_CODE = '" & EditString & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO INVENTORY VALUES('" & txtInvID.Text.ToUpper.Trim & "','" & _
                                                           StrConv(txtInvName.Text.ToUpper.Trim, VbStrConv.Uppercase) & "'," & _
                                                           Val(txtQty.Text.Trim) & "," & _
                                                           Val(txtRetail.Text.Trim) & ",'" & _
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
            SqlDataAdapt.Dispose()
            Me.InvDataGrid.Refresh()
            Dim QueryText As String = "SELECT * FROM INVENTORY ORDER BY INV_CODE"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QueryText, "INVENTORY", Connection)
            SqlDataAdapt.Fill(Me.InvDataSet, "INVENTORY")
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

    Private Sub clear_text_boxes()
        Me.txtInvID.Text = ""
        Me.txtInvName.Text = ""
        Me.txtQty.Text = ""
        Me.txtRetail.Text = ""
    End Sub

End Class