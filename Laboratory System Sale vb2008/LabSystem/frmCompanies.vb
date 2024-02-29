Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmCompanies
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean
    Private Sub frmCompanies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.CompanyDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM COMPANY ORDER BY CP_ID"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "COMPANY", Connection)
            SqlDataAdapt.Fill(Me.CompanyDataSet, "COMPANY")
            Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
            Me.CompanyBindingSource.DataMember = "COMPANY"
            Me.txtID.DataBindings.Add("TEXT", CompanyBindingSource, "CP_ID")
            Me.txtCpName.DataBindings.Add("TEXT", CompanyBindingSource, "CP_NAME")
            Me.txtName.DataBindings.Add("TEXT", CompanyBindingSource, "CP_INCHARGE")
            Me.txtAddress.DataBindings.Add("TEXT", CompanyBindingSource, "CP_ADDRESS")
            Me.txtCity.DataBindings.Add("TEXT", CompanyBindingSource, "CP_CITY")
            Me.txtPhone.DataBindings.Add("TEXT", CompanyBindingSource, "CP_TEL")
            Me.txtMob.DataBindings.Add("TEXT", CompanyBindingSource, "CP_MOB")
            Addition = False
            Editing = False
            ToolStripSaveButton.Enabled = False
            Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            CompanyDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If ToolStripCloseButton.Text = "&Close" Then
            Connection.Close()
            Me.CompanyBindingSource.Dispose()
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
        If Addition = True And Editing = False Then
            Dim IDSql As String = "Select Max(CP_ID) AS MAX_ID from COMPANY"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, IDSql, "COMPANY", Connection)
            Dim IDReader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader()
            While IDReader.Read
                txtID.Text = Val(Convert.ToString(IDReader.Item("MAX_ID"))) + 1
            End While
            If Not IDReader Is Nothing Then IDReader.Close()
        End If
        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE COMPANY SET" & _
                                                           " CP_NAME = '" & StrConv(txtCpName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_INCHARGE = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_ADDRESS = '" & StrConv(txtAddress.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_CITY = '" & StrConv(txtCity.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_TEL = '" & txtPhone.Text.Trim & "'," & _
                                                           " CP_MOB = '" & txtMob.Text.Trim & "'," & _
                                                           " WHERE CP_ID = " & Val(EditString))

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO COMPANY VALUES(" & Val(txtID.Text.Trim) & ",'" & _
                                                           StrConv(txtCpName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtAddress.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtCity.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           txtPhone.Text.Trim & "','" & txtMob.Text.Trim & "')")

        Call RefreshDB()
        ToolStripSaveButton.Enabled = False
        Panel1.Enabled = False
        Editing = False
        Addition = False
        ToolStripEditButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Close"

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        Panel1.Enabled = True
        txtCpName.Focus()
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
        Panel1.Enabled = True
        ToolStripSaveButton.Enabled = True
        ToolStripCloseButton.Text = "&Cancel"
        EditString = txtID.Text.Trim
        txtCpName.Focus()

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtCpName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM COMPANY WHERE CP_ID = " & Val(txtID.Text.Trim)
            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
            Me.CompanyDataGridView.Update()
        Else
            'skip
            Call RefreshDB()
        End If

    End Sub
    Private Sub RefreshDB()

        Try
            Me.CompanyDataSet.Clear()
            SqlDataAdapt.Dispose()
            Dim QueryText As String = "SELECT * FROM COMPANY ORDER BY CP_ID"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QueryText, "COMPANY", Connection)
            SqlDataAdapt.Fill(Me.CompanyDataSet, "COMPANY")
            Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
            Me.CompanyBindingSource.DataMember = "COMPANY"
            Me.CompanyDataGridView.Update()
            Me.CompanyDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

End Class