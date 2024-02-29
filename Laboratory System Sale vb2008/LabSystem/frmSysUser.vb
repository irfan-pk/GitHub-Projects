Imports System.Data.SqlClient
Public Class frmSysUser
    Dim Pos As Integer
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub frmSysUser_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        ' If user pressed the Enter key
        If e.KeyCode = Keys.Enter And Not (e.Alt Or e.Control) Then
            e.SuppressKeyPress = True
            ' Make sure that the active control is a TextBox control
            ' Do not use the Enter key as tab when a button has the focus!
            If Me.ActiveControl.GetType Is GetType(TextBox) Or _
                    Me.ActiveControl.GetType Is GetType(ComboBox) Or _
                    Me.ActiveControl.GetType Is GetType(DateTimePicker) Then
                ' Use Shift + Enter to move backwords through the tab order
                If e.Shift Then
                    Me.ProcessTabKey(False)
                Else
                    Me.ProcessTabKey(True)
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, illegal operating.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        Call LoadDB()

    End Sub

    Private Sub LoadDB()
        Try
            Dim CommandText As String = "SELECT * FROM USERS ORDER BY USERNAME"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "USERS", Connection)
            SqlDataAdapt.Fill(Me.UserDataSet, "USERS")
            Me.UserbindingSource.DataSource = Me.UserDataSet
            Me.UserbindingSource.DataMember = "USERS"
            Me.txtUserID.DataBindings.Add("TEXT", UserbindingSource, "USERID")
            Me.txtName.DataBindings.Add("TEXT", Me.UserbindingSource, "USERNAME")
            Me.cmbUserType.DataBindings.Add("TEXT", UserbindingSource, "USERTYPE")
            Me.txtStatus.DataBindings.Add("TEXT", UserbindingSource, "USERSTATUS")
            Me.txtPwd.DataBindings.Add("TEXT", UserbindingSource, "PASSWORD")
            Addition = False
            Editing = False
            Me.ToolStripSaveButton.Enabled = False
            Me.Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            Me.UsersDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Panel1.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        Me.ToolStripSaveButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        Me.txtUserID.Focus()
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click

        EditString = txtUserID.Text.Trim.ToUpper
        Editing = True
        Addition = False
        Panel1.Enabled = True
        Me.ToolStripSaveButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        EditString = Me.txtUserID.Text.Trim
        Me.txtName.Focus()

    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If Me.ToolStripCloseButton.Text = "&Close" Then
            'myConn.Close()
            Me.UserbindingSource.Dispose()
            Me.Close()
        Else
            Me.ToolStripCloseButton.Text = "&Close"
            Me.ToolStripSaveButton.Enabled = False
            Panel1.Enabled = False
            Call RefreshDB()
            Addition = False
            Editing = False
        End If
    End Sub

    Private Sub RefreshDB()
        Try
            Me.UserDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM USERS ORDER BY USERID"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "USERS", Connection)
            SqlDataAdapt.Fill(Me.UserDataSet, "USERS")
            Me.UserbindingSource.DataSource = Me.UserDataSet
            Me.UserbindingSource.DataMember = "USERS"
            Me.UsersDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        Dim DeleteQuery As String = ""
        If Me.ToolStripCloseButton.Text = "&Cancel" Then Me.ToolStripCloseButton.Text = "&Close"
        If MsgBox("Are you sure to delete ('" & txtName.Text.Trim.ToUpper & "') ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, My.Application.Info.ProductName) = MsgBoxResult.Ok Then
            DeleteQuery = "DELETE FROM USERS WHERE USERNAME = '" & txtName.Text.Trim & "'"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, DeleteQuery, "USERS", Connection)
        Else
            Me.UsersDataGridView.RefreshEdit()
            Me.UserBindingNavigator.Refresh()
            Call ToolStripCloseButton_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSaveButton.Click

        Dim Edit_Update_Query As String = ""
        If Editing = True And Addition = False Then Edit_Update_Query = "UPDATE USERS SET USERID = '" & txtUserID.Text.Trim.ToUpper & "', USERNAME = '" & txtName.Text.Trim.ToUpper & "', PASSWORD = '" & txtPwd.Text.Trim & "', USERTYPE = '" & cmbUserType.Text.Trim.ToUpper & "', USERSTATUS = '" & txtStatus.Text.Trim.ToUpper & "' WHERE USERID = '" & EditString & "'"
        If Addition = True And Editing = False Then Edit_Update_Query = "INSERT INTO USERS VALUES('" & txtUserID.Text.Trim.ToUpper & "','" & txtName.Text.Trim.ToUpper & "','" & txtPwd.Text.Trim.ToUpper & "','" & cmbUserType.Text.Trim.ToUpper & "','" & txtStatus.Text.Trim.ToUpper & "')"
        Execute_DatabaseTable_Query(SqlDataAdapt, Edit_Update_Query, Connection)
        Call RefreshDB()
        ToolStripSaveButton.Enabled = False
        Panel1.Enabled = False
        Me.ToolStripCloseButton.Text = "&Close"
        Connection.Close()

    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtPwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPwd.KeyPress
        If Not (Char.IsLetterOrDigit(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStatus.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmbUserType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUserType.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUserType.SelectedIndexChanged

        If cmbUserType.Text = "ADMINISTRATOR" Then
            txtStatus.Text = 1
        ElseIf cmbUserType.Text = "SUPERVISOR" Then
            txtStatus.Text = 2
        ElseIf cmbUserType.Text = "OPERATOR" Then
            txtStatus.Text = 3
        End If

    End Sub

End Class