Imports System.Data.SqlClient

Public Class SysUser
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
            Dim CommandText As String = "SELECT * FROM USERS ORDER BY USERID"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "USERS", Connection)
            SqlDataAdapter.Fill(Me.UserDataSet, "USERS")
            Me.UserbindingSource.DataSource = Me.UserDataSet
            Me.UserbindingSource.DataMember = "USERS"
            Me.txtUserID.DataBindings.Add("TEXT", UserbindingSource, "USERID")
            Me.txtUserName.DataBindings.Add("TEXT", Me.UserbindingSource, "USERNAME")
            Me.txtName.DataBindings.Add("TEXT", Me.UserbindingSource, "NAME")
            Me.cmbUserType.DataBindings.Add("TEXT", UserbindingSource, "USERROLE")
            Me.txtLevel.DataBindings.Add("TEXT", UserbindingSource, "SECURITYLEVEL")
            Me.txtPwd.DataBindings.Add("TEXT", UserbindingSource, "PASSWORD")
            Me.txtCNIC.DataBindings.Add("TEXT", Me.UserbindingSource, "CARDNUMBER")
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
        Me.txtUserName.Focus()
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click

        EditString = txtUserID.Text.Trim.ToUpper
        Editing = True
        Addition = False
        Panel1.Enabled = True
        Me.ToolStripSaveButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        EditString = Me.txtUserID.Text.Trim
        Me.txtUserName.Focus()

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
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "USERS", Connection)
            SqlDataAdapter.Fill(Me.UserDataSet, "USERS")
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
        If MsgBox("Are you sure to delete ('" & txtUserName.Text.Trim.ToUpper & "') ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, My.Application.Info.ProductName) = MsgBoxResult.Ok Then
            DeleteQuery = "DELETE FROM USERS WHERE USERNAME = '" & txtUserName.Text.Trim & "'"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, DeleteQuery, "USERS", Connection)
        Else
            Me.UsersDataGridView.RefreshEdit()
            Me.UserBindingNavigator.Refresh()
            Call ToolStripCloseButton_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSaveButton.Click
        Dim MaxID As String = GenerateMax_ID("USERS", "USERID")
        Dim Edit_Update_Query As String = ""
        If Editing = True And Addition = False Then Edit_Update_Query = "UPDATE USERS SET USERNAME = '" & txtUserName.Text.Trim.ToLower & "', PASSWORD = '" & txtPwd.Text.Trim & "', USERROLE = '" & StrConv(cmbUserType.Text.Trim, VbStrConv.ProperCase) & "', SECURITYLEVEL = '" & txtLevel.Text.Trim & "', NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'  WHERE USERID = '" & Val(EditString) & "'"
        If Addition = True And Editing = False Then Edit_Update_Query = "INSERT INTO USERS VALUES('" & MaxID & "','" & txtUserName.Text.Trim.ToLower & "','" & txtPwd.Text.Trim & "','" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','" & StrConv(cmbUserType.Text.Trim, VbStrConv.ProperCase) & "','" & Val(txtLevel.Text.Trim.ToUpper) & "',0,'" & txtCNIC.Text.Trim & "')"
        ExecuteAdapterQuery(SqlDataAdapter, Edit_Update_Query, Connection)
        Call RefreshDB()
        ToolStripSaveButton.Enabled = False
        Panel1.Enabled = False
        Me.ToolStripCloseButton.Text = "&Close"
        Connection.Close()
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Call ValidateAlphaKeyPress(sender, e, txtName)
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If e.KeyChar = Chr(8) Then e.Handled = False
    End Sub

    Private Sub txtPwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPwd.KeyPress
        If e.KeyChar = Chr(8) Then e.Handled = False
    End Sub

    Private Sub cmbUserType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUserType.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUserType.SelectedIndexChanged

        If cmbUserType.Text = "Admin" Then
            txtLevel.Text = 1
        ElseIf cmbUserType.Text = "Super User" Then
            txtLevel.Text = 2
        ElseIf cmbUserType.Text = "User" Then
            txtLevel.Text = 3
        End If

    End Sub

End Class