Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DoctorsRegistration
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub CollectionPoint_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtID.Focus()
    End Sub

    Private Sub DoctorsRegistration_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F11 Then
            ClearText()
            enableTextBoxes(True)
            GetLastSequence()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            txtID.Focus()
        End If
    End Sub

    Private Sub frmCollectionPoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized to add/change any data.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        GetLastSequence()
    End Sub

    Private Sub GetLastSequence()
        Dim Max As String = "select max(cp_id) as MaxID from collectionpoint"
        Dim MaxAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(MaxAdapter, Max, Connection)
        Dim reader As SqlDataReader = MaxAdapter.SelectCommand.ExecuteReader
        While reader.Read
            lblSeq.Text = Val(reader.Item("MaxID").ToString) + 0
        End While
        If reader Is Nothing Then reader.Close()
        txtID.Text = GenerateMax_ID("collectionpoint", "cp_id")
    End Sub

    Private Sub ClearText()
        txtCpName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtMob.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub enableTextBoxes(ByVal State As Boolean)
        txtCity.Enabled = State
        txtCpName.Enabled = State
        txtAddress.Enabled = State
        txtMob.Enabled = State
        txtPhone.Enabled = State
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtCpName.Text = String.Empty Or _
           txtAddress.Text = String.Empty Or _
           txtMob.Text = String.Empty Or _
           txtCity.Text = String.Empty Then
            MessageBox.Show("All Fields are mandatory.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE COLLECTIONPOINT SET" & _
                                                           " CP_ID = '" & txtID.Text.Trim & "'," & _
                                                           " CP_NAME = '" & StrConv(txtCpName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_ADDRESS = '" & StrConv(txtAddress.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CP_CITY = '" & StrConv(txtCity.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                                           " CP_TEL = '" & txtPhone.Text.Trim & "'," & _
                                                           " CP_MOB = '" & txtMob.Text.Trim & "'" & _
                                                           " WHERE CP_NAME = '" & EditString.Trim & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO COLLECTIONPOINT VALUES('" & txtID.Text.Trim.ToUpper & "','" & _
                                                           StrConv(txtCpName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtAddress.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtCity.Text.Trim, VbStrConv.Uppercase) & "','" & _
                                                           txtPhone.Text.Trim & "','" & txtMob.Text.Trim & "')")

        Editing = False
        Addition = False
        ClearText()
        GetLastSequence()
        enableTextBoxes(True)
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txtID.Focus()
    End Sub

    Private Sub txtID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtID.GotFocus
        Get_Property_GotFocus(txtID)
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        ValidateNumbersOnly(sender, e, txtID)
    End Sub

    Private Sub txtID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtID.Text) > 0 Then
                ExecuteAdapterQuery(SqlDataAdapter, "select * from collectionpoint where cp_id = " & Val(txtID.Text), Connection)
                Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Reader.HasRows Then
                    While Reader.Read
                        txtCpName.Text = Reader.Item("cp_name").ToString
                        txtCity.Text = Reader.Item("cp_city").ToString
                        txtPhone.Text = Reader.Item("cp_tel").ToString
                        txtMob.Text = Reader.Item("cp_mob").ToString
                        txtAddress.Text = Reader.Item("cp_address").ToString
                        btnEdit.Enabled = True
                        btnDelete.Enabled = True
                        txtCpName.Focus()
                    End While
                    If Reader Is Nothing Then Reader.Close()
                Else
                    ClearText()
                    enableTextBoxes(True)
                    txtCpName.Focus()
                    Addition = True
                    Editing = False
                End If
            Else
                HelpTable = "collectionpoint"
                HelpF1 = "cp_name"
                HelpF2 = "cp_id"
                CodesHelp.ShowDialog(Me)
                txtID.Text = gblCP_ID
            End If
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearText()
        enableTextBoxes(True)
        Editing = False
        Addition = True
        btnSave.Enabled = False
        txtID.Text = GenerateMax_ID("collectionpoint", "cp_id")
        txtCpName.Focus()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        enableTextBoxes(True)
        Editing = True
        Addition = False
        EditString = txtID.Text
        txtCpName.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtCpName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ProcessTransaction("DELETE FROM COLLECTIONPOINT WHERE CP_NAME = '" & txtCpName.Text.Trim & "'")
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            GetLastSequence()
            ClearText()
            enableTextBoxes(True)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCpName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCpName.GotFocus
        Get_Property_GotFocus(txtCpName)
    End Sub

    Private Sub txtCpName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCpName.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtCpName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCpName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddress.Focus()
        End If
    End Sub

    Private Sub txtAddress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.GotFocus
        Get_Property_GotFocus(txtAddress)
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPhone.Focus()
        End If
    End Sub

    Private Sub txtPhone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.GotFocus
        Get_Property_GotFocus(txtPhone)
    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtPhone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMob.Focus()
        End If
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        ValidateNumbersOnly(sender, e, txtPhone)
    End Sub

    Private Sub txtMob_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMob.GotFocus
        Get_Property_GotFocus(txtMob)
    End Sub

    Private Sub txtMob_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMob.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtMob_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMob.KeyPress
        ValidateNumbersOnly(sender, e, txtMob)
    End Sub

    Private Sub txtMob_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMob.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCity.Focus()
        End If
    End Sub

    Private Sub txtCity_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCity.GotFocus
        Get_Property_GotFocus(txtCity)
    End Sub

    Private Sub txtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCity.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtCity_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtCity.Text) = 0 Then
                HelpTable = "city"
                HelpF1 = "city_name"
                HelpF2 = "city_id"
                CodesHelp.ShowDialog(Me)
                txtCity.Text = gblCP.Trim
            End If
            btnSave.Focus()
        End If
    End Sub

    Private Sub txtAddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.LostFocus
        Get_Property_LostFocus(txtAddress)
    End Sub

    Private Sub txtCity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCity.LostFocus
        Get_Property_LostFocus(txtCity)
    End Sub

    Private Sub txtCpName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCpName.LostFocus
        Get_Property_LostFocus(txtCpName)
    End Sub

    Private Sub txtMob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMob.LostFocus
        Get_Property_LostFocus(txtMob)
    End Sub

    Private Sub txtPhone_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPhone.LostFocus
        Get_Property_LostFocus(txtPhone)
    End Sub

    Private Sub txtID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtID.LostFocus
        Get_Property_LostFocus(txtID)
    End Sub
End Class