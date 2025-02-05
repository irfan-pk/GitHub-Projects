Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class WholeSalers
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim EditString As String
    Dim Max_ID As Integer = 0
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub WholeSalers_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        WholesalersMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmCompanies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub BindingNavigatorQuery(ByVal Query As String)
        Try
            ExecuteAdapterQuery(SqlDataAdapter, Query, Connection)
            Connection.Close()
            SqlDataAdapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub LoadDB()

        Try
            Me.CompanyDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM SUPPLIERS ORDER BY SUPL_CODE"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "SUPPLIERS", Connection)
            SqlDataAdapter.Fill(Me.CompanyDataSet, "SUPPLIERS")
            Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
            Me.CompanyBindingSource.DataMember = "SUPPLIERS"
            Me.txtID.DataBindings.Add("TEXT", CompanyBindingSource, "SUPL_CODE")
            Me.txtName.DataBindings.Add("TEXT", CompanyBindingSource, "SUPL_NAME")
            Me.txtAddress.DataBindings.Add("TEXT", CompanyBindingSource, "SUPL_ADDRESS")
            Me.txtCity.DataBindings.Add("TEXT", CompanyBindingSource, "SUPL_CITY")
            Me.txtPhone.DataBindings.Add("TEXT", CompanyBindingSource, "SUPL_TEL")
            Me.txtMob.DataBindings.Add("TEXT", CompanyBindingSource, "SUPL_MOB")
            Me.txtBalance.DataBindings.Add("TEXT", CompanyBindingSource, "SUPL_BALANCE")
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
            WholesalersMenu.WindowState = FormWindowState.Normal
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
            Max_ID = GenerateMax_ID("SUPPLIERS", "SUPL_CODE")
            If Max_ID = 1 Then Max_ID = Max_ID + 1000
            txtID.Text = Max_ID
        End If
        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE SUPPLIERS SET" & _
                                                           " SUPL_NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " SUPL_ADDRESS = '" & StrConv(txtAddress.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " SUPL_CITY = '" & StrConv(txtCity.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " SUPL_TEL = '" & txtPhone.Text.Trim & "'," & _
                                                           " SUPL_MOB = '" & txtMob.Text.Trim & "' " & _
                                                           " WHERE SUPL_CODE = " & Val(EditString))

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO SUPPLIERS VALUES(" & Val(txtID.Text.Trim) & ",'" & _
                                                           StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtAddress.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtCity.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           txtPhone.Text.Trim & "','" & _
                                                           txtMob.Text.Trim & "','0','" & Format(Date.Parse(Date.Now().ToString), "MM/dd/yyyy") & "')")

        Call RefreshDB()
        ToolStripSaveButton.Enabled = False
        Panel1.Enabled = False
        Editing = False
        Addition = False
        txtBalance.ReadOnly = True
        ToolStripEditButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Close"

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        Panel1.Enabled = True
        txtName.Focus()
        Addition = True
        RollBack = True
        Editing = False
        txtBalance.ReadOnly = False
        txtBalance.Text = "0.00"
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
        txtName.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM SUPPLIERS WHERE SUPL_CODE = " & Val(txtID.Text.Trim)
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            Me.CompanyDataGridView.Update()
        Else
            'skip
            Call RefreshDB()
        End If
    End Sub

    Private Sub RefreshDB()
        Try
            Me.CompanyDataSet.Clear()
            SqlDataAdapter.Dispose()
            Dim QueryText As String = "SELECT * FROM SUPPLIERS ORDER BY SUPL_CODE"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, QueryText, "SUPPLIERS", Connection)
            SqlDataAdapter.Fill(Me.CompanyDataSet, "SUPPLIERS")
            Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
            Me.CompanyBindingSource.DataMember = "SUPPLIERS"
            Me.CompanyDataGridView.Update()
            Me.CompanyDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub ToolStripCloseButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripCloseButton.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub ToolStripCloseButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripCloseButton.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub ToolStripCloseButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripCloseButton.MouseUp
        drag = False
    End Sub

    Private Sub ToolStripRefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripRefreshButton.Click
        Call RefreshDB()
    End Sub
End Class