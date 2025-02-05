Imports System.Data.SqlClient

Public Class Product
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
            Dim CommandText As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CD"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "PRODUCTS", Connection)
            SqlDataAdapter.Fill(Me.UserDataSet, "PRODUCTS")
            Me.UserbindingSource.DataSource = Me.UserDataSet
            Me.UserbindingSource.DataMember = "PRODUCTS"
            Me.txtCode.DataBindings.Add("TEXT", UserbindingSource, "PROD_CD")
            Me.txtDesc.DataBindings.Add("TEXT", Me.UserbindingSource, "PROD_DESC")
            Me.txtCatg.DataBindings.Add("TEXT", Me.UserbindingSource, "PROD_CATG")
            Me.txtPPrice.DataBindings.Add("TEXT", UserbindingSource, "PROD_PPRICE")
            Me.txtMargin.DataBindings.Add("TEXT", UserbindingSource, "PROD_PROFIT")
            Me.txtPck.DataBindings.Add("TEXT", UserbindingSource, "PROD_PACK")
            Me.txtSalePrice.DataBindings.Add("TEXT", Me.UserbindingSource, "PROD_SPRICE")
            Addition = False
            Editing = False
            Me.ToolStripSaveButton.Enabled = False
            'Me.Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            Me.UsersDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub ActivateTextBoxes(ByVal Status As String)
        txtCode.ReadOnly = Status
        txtDesc.ReadOnly = Status
        txtPPrice.ReadOnly = Status
        txtMargin.ReadOnly = Status
        txtSalePrice.ReadOnly = Status
        txtMargin.ReadOnly = Status
    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        ActivateTextBoxes("False")
        Addition = True
        RollBack = True
        Editing = False
        Me.ToolStripSaveButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        Me.txtCode.Focus()
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click
        txtCode.Text = txtCode.Text.Trim
        EditString = txtCode.Text.Trim.ToUpper
        Editing = True
        Addition = False
        ActivateTextBoxes("False")
        Me.ToolStripSaveButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        EditString = Me.txtCode.Text.Trim
        Me.txtCode.Focus()

    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If Me.ToolStripCloseButton.Text = "&Close" Then
            'myConn.Close()
            Me.UserbindingSource.Dispose()
            Me.Close()
        Else
            Me.ToolStripCloseButton.Text = "&Close"
            Me.ToolStripSaveButton.Enabled = False
            ActivateTextBoxes("True")
            Call RefreshDB()
            Addition = False
            Editing = False
        End If
    End Sub

    Private Sub RefreshDB()
        Try
            Me.UserDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CD"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "PRODUCTS", Connection)
            SqlDataAdapter.Fill(Me.UserDataSet, "PRODUCTS")
            Me.UserbindingSource.DataSource = Me.UserDataSet
            Me.UserbindingSource.DataMember = "PRODUCTS"
            Me.UsersDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        Dim DeleteQuery As String = String.Empty
        If Me.ToolStripCloseButton.Text = "&Cancel" Then Me.ToolStripCloseButton.Text = "&Close"
        If MsgBox("Are you sure to delete ('" & txtDesc.Text.Trim.ToUpper & "') ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, My.Application.Info.ProductName) = MsgBoxResult.Ok Then
            DeleteQuery = "DELETE FROM PRODUCTS WHERE PROD_CD = '" & txtCode.Text.Trim & "'"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, DeleteQuery, "PRODUCTS", Connection)
        Else
            Me.UsersDataGridView.RefreshEdit()
            Me.UserBindingNavigator.Refresh()
            Call ToolStripCloseButton_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSaveButton.Click
        Dim MaxID As String = GenerateMax_ID("USERS", "USERID")
        Dim Add_Edit_Query As String = String.Empty
        If txtCode.Text = "" Or txtCatg.Text = "" Or txtDesc.Text = "" Or txtPPrice.Text = "" Or txtSalePrice.Text = "" Then gblMessage = "All Fields are mandatory." : MsgStatus.ShowDialog(Me) : Exit Sub
        '// If changes made in selected record then execute update data into table
        If Editing = True And Addition = False Then Add_Edit_Query = "UPDATE PRODUCTS SET " & _
                                                                               "PROD_CD = '" & txtCode.Text.Trim & "', " & _
                                                                               "PROD_DESC = '" & txtDesc.Text.Trim & "', " & _
                                                                               "PROD_CATG = '" & txtCatg.Text.Trim & "', " & _
                                                                               "PROD_PPRICE = " & Val(txtPPrice.Text.Trim) & ", " & _
                                                                               "PROD_PROFIT = " & Val(txtMargin.Text.Trim) & ", " & _
                                                                               "PROD_SPRICE = " & Val(txtSalePrice.Text.Trim) & ", " & _
                                                                               "PROD_UPD_ON = '" & Format(Date.Parse(Now.Date.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                                                               "WHERE (PROD_CD = N'" & EditString.Trim & "')" _
                                                                             : ExecuteAdapterQuery(SqlDataAdapter, Add_Edit_Query, Connection)
        '// if entered new values in text boxes then execute add data into table
        If Addition = True And Editing = False Then

            If Len(txtCode.Text.Trim) > 0 And _
                   Len(txtDesc.Text.Trim) > 0 And _
                   Len(txtPck.Text.Trim) > 0 And _
                   Len(txtCatg.Text.Trim) > 0 And _
                   Len(txtPPrice.Text.Trim) > 0 And _
                   Len(txtSalePrice.Text.Trim) > 0 Then
                Add_Edit_Query = "INSERT INTO PRODUCTS VALUES ('" & _
                                                                                               txtCode.Text.Trim & "','" & _
                                                                                               txtDesc.Text.Trim & "','" & _
                                                                                               txtCatg.Text.Trim & "','" & _
                                                                                               txtPck.Text.Trim & "'," & _
                                                                                               Val(txtPPrice.Text.Trim) & "," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               "0," & _
                                                                                               Val(txtMargin.Text.Trim) & "," & _
                                                                                               "0," & _
                                                                                               Val(txtSalePrice.Text.Trim) & ",'" & _
                                                                                               Format(Date.Parse(Now.Date.ToString), "MM/dd/yyyy") & "','" & _
                                                                                               Format(Date.Parse(Now.Date.ToString), "MM/dd/yyyy") & "')"
                ExecuteAdapterQuery(SqlDataAdapter, Add_Edit_Query, Connection)
            Else
                gblMessage = "Please fill all fields for insert new product."
                MsgStatus.ShowDialog(Me)
            End If
        End If
        Call RefreshDB()
        ToolStripSaveButton.Enabled = False
        ActivateTextBoxes("True")
        Me.ToolStripCloseButton.Text = "&Close"
        Connection.Close()
    End Sub

    Private Sub txtSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalePrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtSalePrice.Text) < 1 Then gblMessage = "Product Sale Price invalid ?" : MsgStatus.ShowDialog(Me) : Exit Sub
            txtMargin.Text = Val(txtSalePrice.Text) - Val(txtPPrice.Text)
            txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtMargin.Text.Trim)
        End If
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        Call Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        ValidateAlphaNumOnly(sender, e)
    End Sub

    Private Sub txtSalePrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalePrice.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSalePrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.GotFocus
        Call Get_Property_GotFocus(txtSalePrice)
        txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtMargin.Text.Trim)
    End Sub

    Private Sub txtDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.GotFocus
        Call Get_Property_GotFocus(txtDesc)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        ' Alpha Numeric input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Or (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 46 Then
            ' Go Through
            ' uncommit following routine when need only First Letter capitalized of text
            'If e.KeyChar <> ChrW(Keys.Back) Then
            '    If txtDesc.Text = "" Then
            '        e.KeyChar = UCase(e.KeyChar)
            '    End If
            'End If
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtDesc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.LostFocus
        Call Get_Property_LostFocus(txtDesc)
        txtDesc.Text = StrConv(txtDesc.Text.Trim, VbStrConv.ProperCase)

    End Sub

    Private Sub txtMargin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargin.GotFocus
        Call Get_Property_GotFocus(txtMargin)
    End Sub

    Private Sub txtMargin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMargin.KeyPress
        Call ValidateKeyPress(sender, e, txtMargin, txtSalePrice)
    End Sub

    Private Sub txtMargin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargin.LostFocus
        Call Get_Property_LostFocus(txtMargin)
    End Sub

    Private Sub txtPck_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPck.GotFocus
        Call Get_Property_GotFocus(txtPck)
    End Sub

    Private Sub txtPck_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPck.KeyPress
        ' Alpha input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
            ' Go Through
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtPck_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPck.LostFocus
        Call Get_Property_LostFocus(txtPck)
    End Sub

    Private Sub txtCatg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Call Get_Property_GotFocus(txtCatg)
    End Sub

    Private Sub txtCatg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Alpha input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
            ' Go Through
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCatg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Call Get_Property_LostFocus(txtCatg)
    End Sub

    Private Sub ValidateKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal txt As TextBox, ByVal nexttxt As TextBox)
        '48 - 57  = Ascii codes for numbers
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
    End Sub

    Private Sub txtPPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPPrice.GotFocus
        Call Get_Property_GotFocus(txtPPrice)
    End Sub

    Private Sub txtPPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPPrice.LostFocus
        Call Get_Property_LostFocus(txtPPrice)
    End Sub

    Private Sub txtSalePrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.LostFocus
        Call Get_Property_LostFocus(txtSalePrice)
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Call Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub ToolStripFindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripFindButton.Click
        Dim strCode As String
        strCode = Microsoft.VisualBasic.InputBox("Please Enter Product Code To Find.", "Find")
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.UserbindingSource.Find("prod_cd", strCode.Trim)
        If Not Pos = -1 Then
            EditString = strCode
            Me.UserbindingSource.Position = Pos
        End If
    End Sub
End Class