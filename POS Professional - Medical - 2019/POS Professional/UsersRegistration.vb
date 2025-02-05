Imports System.Data.SqlClient

Public Class UsersRegistration
    Dim FindAdapter As New SqlDataAdapter()
    Dim CheckAdapter As New SqlDataAdapter()
    Dim FindDataSet As New DataSet()
    Dim Pos As Integer
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub SystemUsers_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSeq.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, illegal operation.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        GetLastSequence()
    End Sub

    Private Sub GetLastSequence()
        Dim Max As String = "select max(usersequence) as MaxID from users"
        Dim MaxAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(MaxAdapter, Max, Connection)
        Dim reader As SqlDataReader = MaxAdapter.SelectCommand.ExecuteReader
        While reader.Read
            lblSeq.Text = reader.Item("MaxID").ToString
        End While
        'txtSeq.Text = GenerateMax_ID("users", "usersequence")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
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
                                                                                            "USERSEQUENCE = " & Val(txtSeq.Text) & ", " & _
                                                                                            "COUNTERID = '" & txtCtrID.Text.Trim.ToUpper & "' " & _
                                                                                            "WHERE USERID = '" & EditString & "'")

            If Addition = True And Editing = False Then ProcessTransaction("INSERT INTO USERS VALUES(" & Val(txtSeq.Text) & ",'" & StrConv(txtUserName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                                                            txtUserID.Text.Trim.ToLower & "','" & _
                                                                                            txtPwd.Text.Trim & "','" & _
                                                                                            StrConv(cmbUserRole.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                                                            Val(txtLevel.Text.Trim) & "'," & _
                                                                                            "1,'" & txtCNIC.Text.Trim & "','" & txtCtrID.Text.ToUpper.Trim & "')")

            btnSave.Enabled = False
            ClearText()
            txtSeq.Clear()
            txtSeq.Focus()
        End If
    End Sub

    Private Sub cmbUserRole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUserRole.SelectedIndexChanged
        If cmbUserRole.Text = "Administrator" Then
            txtLevel.Text = 1
        ElseIf cmbUserRole.Text = "Super User" Then
            txtLevel.Text = 2
        ElseIf cmbUserRole.Text = "User" Then
            txtLevel.Text = 3
        End If
        btnSave.Enabled = True
    End Sub

    Private Sub ClearText()
        txtCNIC.Clear()
        txtLevel.Clear()
        txtUserID.Clear()
        txtUserName.Clear()
        txtPwd.Clear()
        cmbUserRole.Text = String.Empty
    End Sub

    Private Sub Check_ID()
        Call GetConnectionString()
        If Addition = True Then _
            ExecuteAdapterQuery(CheckAdapter, "select * from users where userid = N'" & txtUserID.Text.Trim & "' or counterid = N'" & txtCtrID.Text.Trim & "'", Connection)
        If Editing = True Then _
            ExecuteAdapterQuery(CheckAdapter, "select * from users where userid <> N'" & EditString & "' and counterid = N'" & txtCtrID.Text.Trim & "'", Connection)
        Dim Reader As SqlDataReader = CheckAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            MsgBox("Userid / Counter ID already taken.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            RollBack = True
        Else
            RollBack = False
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSeq_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeq.KeyDown
        If Len(txtSeq.Text) > 0 Then
            Dim FindQuery As String = "select * from users where usersequence = " & Val(txtSeq.Text)
            ExecuteDatasetQuery(FindAdapter, FindDataSet, FindQuery, "users", Connection)
            Dim FindReader As SqlDataReader = FindAdapter.SelectCommand.ExecuteReader
            If FindReader.HasRows = True Then
                While FindReader.Read
                    txtSeq.Text = FindReader.Item("usersequence").ToString
                    txtUserName.Text = FindReader.Item("username").ToString
                    txtUserID.Text = FindReader.Item("userid").ToString
                    cmbUserRole.Text = FindReader.Item("userrole").ToString
                    txtPwd.Text = FindReader.Item("password").ToString
                    txtCNIC.Text = FindReader.Item("cardnumber").ToString
                    txtLevel.Text = FindReader.Item("securitylevel").ToString
                    txtCtrID.Text = FindReader.Item("counterid").ToString
                    btnNew.Focus()
                End While
            Else
                enableTextBoxes(False)
                ClearText()
                txtUserName.Focus()
                Addition = True
            End If
        End If
    End Sub

    Private Sub enableTextBoxes(ByVal State As Boolean)
        txtUserName.ReadOnly = State
        txtUserID.ReadOnly = State
        txtPwd.ReadOnly = State
        txtCtrID.ReadOnly = State
        txtCNIC.ReadOnly = State
    End Sub

    Private Sub txtSeq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeq.KeyPress
        ValidateNumbersOnly(sender, e, txtSeq)
    End Sub

    Private Sub txtUserName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUserID.Focus()
        End If
    End Sub

    Private Sub txtUserID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserID.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPwd.Focus()
        End If
    End Sub

    Private Sub txtPwd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbUserRole.Focus()
        End If
    End Sub

    Private Sub cmbUserRole_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbUserRole.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCtrID.Focus()
        End If
    End Sub

    Private Sub txtCtrID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCtrID.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCNIC.Focus()
        End If
    End Sub

    Private Sub txtCNIC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNIC.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnNew.Focus()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        enableTextBoxes(False)
        Editing = True
        Addition = False
        EditString = txtSeq.Text
        txtUserName.Focus()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearText()
        Editing = False
        Addition = True
        btnSave.Enabled = False
        txtSeq.Text = GenerateMax_ID("users", "usersequence")
        txtUserName.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtUserName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ProcessTransaction("DELETE FROM USERS WHERE USERNAME = '" & txtUserName.Text.Trim & "'")
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtUserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserID.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtPwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPwd.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtCtrID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCtrID.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtCNIC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCNIC.TextChanged
        btnSave.Enabled = True
    End Sub
End Class