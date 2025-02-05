Imports System.Data.SqlClient

Public Class SystemUsers
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
            MsgBox("You are not authorized, illegal operation.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub LoadDB()
        Try
            Me.UserDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM USERS ORDER BY USERID"
            ExecuteDatasetQuery(SqlDataAdapter, UserDataSet, CommandText, "USERS", Connection)
            Me.UserbindingSource.DataSource = Me.UserDataSet
            Me.UserbindingSource.DataMember = "USERS"
            Me.UsersDataGridView.DataSource = UserbindingSource
            Me.txtUserID.DataBindings.Add("TEXT", UserbindingSource, "USERID")
            Me.txtUserName.DataBindings.Add("TEXT", Me.UserbindingSource, "USERNAME")
            Me.txtCtrID.DataBindings.Add("TEXT", UserbindingSource, "COUNTERID")
            Me.txtLevel.DataBindings.Add("TEXT", UserbindingSource, "SECURITYLEVEL")
            Me.txtPwd.DataBindings.Add("TEXT", UserbindingSource, "PASSWORD")
            Me.txtCNIC.DataBindings.Add("TEXT", Me.UserbindingSource, "CARDNUMBER")
            Me.cmbUserRole.DataBindings.Add("TEXT", Me.UserbindingSource, "USERROLE")
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
            Call ClearDataBindings()
            Connection.Close()
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
            SqlDataAdapter.Dispose()
            Me.UsersDataGridView.Refresh()
            Dim CommandText As String = "SELECT * FROM USERS ORDER BY USERID"
            ExecuteDatasetQuery(SqlDataAdapter, UserDataSet, CommandText, "USERS", Connection)
            Me.UserbindingSource.DataSource = Me.UserDataSet
            Me.UserbindingSource.DataMember = "USERS"
            Me.UsersDataGridView.DataSource = UserbindingSource
            Me.UsersDataGridView.RefreshEdit()
            Me.UsersDataGridView.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ToolStripCloseButton.Text = "&Cancel" Then Me.ToolStripCloseButton.Text = "&Close"
        Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtUserName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ProcessTransaction("DELETE FROM USERS WHERE USERNAME = '" & txtUserName.Text.Trim & "'")
        Else
            UserbindingSource.ResumeBinding()
            Call RefreshDB()
        End If
    End Sub

    Private Sub ToolStripSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSaveButton.Click
        Dim Edit_Update_Query As String = String.Empty
        If Len(txtCtrID.Text.Trim) <> 3 Then MsgBox("Counter ID must be contains three characters.", MsgBoxStyle.Critical, My.Application.Info.ProductName) : Exit Sub
        Call Check_ID()
        If RollBack = False Then
            If Editing = True And Addition = False Then ProcessTransaction("UPDATE USERS SET USERNAME = '" & StrConv(txtUserName.Text.Trim, VbStrConv.ProperCase) & "', " & _
                                                                                            "USERID = '" & txtUserID.Text.Trim.ToLower & "', " & _
                                                                                            "PASSWORD = '" & txtPwd.Text.Trim & "', " & _
                                                                                            "USERROLE = '" & StrConv(cmbUserRole.Text.Trim, VbStrConv.ProperCase) & "', " & _
                                                                                            "SECURITYLEVEL = '" & Val(txtLevel.Text.Trim) & "', " & _
                                                                                            "CARDNUMBER = '" & txtCNIC.Text.Trim & "', " & _
                                                                                            "COUNTERID = '" & txtCtrID.Text.Trim.ToUpper & "' " & _
                                                                                            "WHERE USERID = '" & EditString & "'")

            If Addition = True And Editing = False Then ProcessTransaction("INSERT INTO USERS VALUES('" & StrConv(txtUserName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                                                            txtUserID.Text.Trim.ToLower & "','" & _
                                                                                            txtPwd.Text.Trim & "','" & _
                                                                                            StrConv(cmbUserRole.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                                                            Val(txtLevel.Text.Trim) & "'," & _
                                                                                            "0,'" & txtCNIC.Text.Trim & "','" & txtCtrID.Text.ToUpper.Trim & "')")

            RefreshDB()
            ToolStripSaveButton.Enabled = False
            Panel1.Enabled = False
            Me.ToolStripCloseButton.Text = "&Close"
        End If
        Connection.Close()
    End Sub

    Private Sub cmbUserRole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUserRole.SelectedIndexChanged
        If cmbUserRole.Text = "Administrator" Then
            txtLevel.Text = 1
        ElseIf cmbUserRole.Text = "Super User" Then
            txtLevel.Text = 2
        ElseIf cmbUserRole.Text = "User" Then
            txtLevel.Text = 3
        End If
    End Sub

    Private Sub ClearDataBindings()
        txtCNIC.DataBindings.Clear()
        txtLevel.DataBindings.Clear()
        txtUserID.DataBindings.Clear()
        txtUserName.DataBindings.Clear()
        txtPwd.DataBindings.Clear()
    End Sub

    Private Sub Check_ID()
        If Addition = True Then _
            ExecuteAdapterQuery(SqlDataAdapter, "select * from users where userid = N'" & txtUserID.Text.Trim & "' or counterid = N'" & txtCtrID.Text.Trim & "'", Connection)
        If Editing = True Then _
            ExecuteAdapterQuery(SqlDataAdapter, "select * from users where userid <> N'" & EditString & "' and counterid = N'" & txtCtrID.Text.Trim & "'", Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            MsgBox("Userid / Counter ID already taken.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            RollBack = True
        Else
            RollBack = False
        End If
    End Sub

    Private Sub ToolStripDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDeleteButton.Click
        If Me.ToolStripCloseButton.Text = "&Cancel" Then Me.ToolStripCloseButton.Text = "&Close"
        Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtUserName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ProcessTransaction("DELETE FROM USERS WHERE USERNAME = '" & txtUserName.Text.Trim & "'")
        Else
            UserbindingSource.ResumeBinding()
            Call RefreshDB()
        End If
    End Sub
End Class