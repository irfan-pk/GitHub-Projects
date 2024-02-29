Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmCollectionPoint
    Dim Pos As Integer
    Dim EditString, StrCode As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean
    Private Sub frmCollectionPoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, illegal operating.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        Call LoadDB()
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

    Private Sub LoadDB()

        Try
            Me.CollectionDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM COLLECTIONPOINT ORDER BY CP_ID"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "COLLECTIONPOINT", Connection)
            SqlDataAdapt.Fill(Me.CollectionDataSet, "COLLECTIONPOINT")
            Me.CollectionBindingSource.DataSource = Me.CollectionDataSet
            Me.CollectionBindingSource.DataMember = "COLLECTIONPOINT"
            Me.txtID.DataBindings.Add("TEXT", CollectionBindingSource, "CP_ID")
            Me.txtCpName.DataBindings.Add("TEXT", CollectionBindingSource, "CP_NAME")
            Me.txtName.DataBindings.Add("TEXT", CollectionBindingSource, "CP_INCHARGE")
            Me.txtAddress.DataBindings.Add("TEXT", CollectionBindingSource, "CP_ADDRESS")
            Me.txtCity.DataBindings.Add("TEXT", CollectionBindingSource, "CP_CITY")
            Me.txtPhone.DataBindings.Add("TEXT", CollectionBindingSource, "CP_TEL")
            Me.txtMob.DataBindings.Add("TEXT", CollectionBindingSource, "CP_MOB")
            Me.txtOrdinary.DataBindings.Add("TEXT", CollectionBindingSource, "CP_PER_ORDINARY")
            Me.txtSpecial.DataBindings.Add("TEXT", CollectionBindingSource, "CP_PER_SPECIAL")
            Me.txtCond.DataBindings.Add("TEXT", CollectionBindingSource, "CP_CONDITIONAL")
            Addition = False
            Editing = False
            ToolStripSaveButton.Enabled = False
            Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            CollectionDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If ToolStripCloseButton.Text = "&Close" Then
            Connection.Close()
            Me.CollectionBindingSource.Dispose()
            Me.Close()
        Else
            ToolStripCloseButton.Text = "&Close"
            Addition = False
            Editing = False
            ToolStripSaveButton.Enabled = False
            Panel1.Enabled = False
            ToolStripEditButton.Enabled = True
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
            Call RefreshDB()
        End If
    End Sub

    Private Sub ToolStripSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSaveButton.Click

        'EditString = ""
        'If Addition = True And Editing = False Then
        '    Dim IDSql As String = "Select Max(CP_ID) AS MAX_ID from COLLECTIONPOINT"
        '    ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, IDSql, "COLLECTIONPOINT", Connection)
        '    Dim IDReader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader()
        '    While IDReader.Read
        '        txtID.Text = Val(Convert.ToString(IDReader.Item("MAX_ID"))) + 1
        '    End While
        '    If Not IDReader Is Nothing Then IDReader.Close()
        'End If
        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE COLLECTIONPOINT SET" & _
                                                           " CP_ID = '" & txtID.Text.Trim & "'," & _
                                                           " CP_NAME = '" & StrConv(txtCpName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_INCHARGE = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_ADDRESS = '" & StrConv(txtAddress.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_CITY = '" & StrConv(txtCity.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_TEL = '" & txtPhone.Text.Trim & "'," & _
                                                           " CP_MOB = '" & txtMob.Text.Trim & "'," & _
                                                           " CP_PER_ORDINARY = " & Val(txtOrdinary.Text.Trim) & "," & _
                                                           " CP_PER_SPECIAL = " & Val(txtSpecial.Text.Trim) & "," & _
                                                           " CP_Conditional = " & Val(txtCond.Text.Trim) & " WHERE CP_ID = '" & EditString.Trim.ToUpper & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO COLLECTIONPOINT VALUES('" & txtID.Text.Trim.ToUpper & "','" & _
                                                           StrConv(txtCpName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtAddress.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtCity.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           Val(txtOrdinary.Text.Trim) & "," & Val(txtSpecial.Text.Trim) & ",'" & _
                                                           txtPhone.Text.Trim & "','" & txtMob.Text.Trim & "'," & Val(txtCond.Text) & ")")

        Call RefreshDB()
        ToolStripSaveButton.Enabled = False
        Panel1.Enabled = False
        Editing = False
        Addition = False
        ToolStripEditButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Close"
        Call FindCollectionPoint()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        Panel1.Enabled = True
        txtID.Focus()
        Addition = True
        RollBack = True
        Editing = False
        EditString = ""
        ToolStripSaveButton.Enabled = True
        ToolStripCloseButton.Text = "&Cancel"

    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click
        Editing = True
        Addition = False
        EditString = txtID.Text.Trim.ToUpper
        Panel1.Enabled = True
        ToolStripSaveButton.Enabled = True
        ToolStripCloseButton.Text = "&Cancel"
        EditString = txtID.Text.Trim
        txtID.Focus()

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtCpName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM COLLECTIONPOINT WHERE CP_ID = '" & txtID.Text.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
            Me.CollectionDataGridView.Update()
        Else
            'skip
            Call RefreshDB()
        End If

    End Sub
    Private Sub RefreshDB()

        Try
            Me.CollectionDataSet.Clear()
            SqlDataAdapt.Dispose()
            Dim QueryText As String = "SELECT * FROM COLLECTIONPOINT ORDER BY CP_ID"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QueryText, "COLLECTIONPOINT", Connection)
            SqlDataAdapt.Fill(Me.CollectionDataSet, "COLLECTIONPOINT")
            Me.CollectionBindingSource.DataSource = Me.CollectionDataSet
            Me.CollectionBindingSource.DataMember = "COLLECTIONPOINT"
            Me.CollectionDataGridView.Update()
            Me.CollectionDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub FindCollectionPoint()
        Pos = Me.CollectionBindingSource.Find("CP_ID", StrCode.Trim)
        If Not Pos = -1 Then
            EditString = StrCode
            Me.CollectionBindingSource.Position = Pos
        End If
    End Sub

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        StrCode = Microsoft.VisualBasic.InputBox("Please Enter C.P. Code To Find.", "Find")
        If Len(StrCode) = 0 Then Exit Sub
        Call FindCollectionPoint()
    End Sub
End Class