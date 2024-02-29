Imports System.Data.SqlClient

Public Class PettyAccounts
    Dim cmd As SqlCommand = Nothing
    Dim Pos, NewAccID As Integer
    Dim OpeningBal As Double
    Dim EditString, AccLink As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False

    Private Sub frmNewAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, Access Denied.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub LoadDB()
        Try
            Me.PettyAccDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM PETTY_ACCOUNTS ORDER BY P_ACC_NO"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "PETTY_ACCOUNTS", Connection)
            SqlDataAdapter.Fill(Me.PettyAccDataSet, "PETTY_ACCOUNTS")
            Me.PettyAccBindingSource.DataSource = Me.PettyAccDataSet
            Me.PettyAccBindingSource.DataMember = "PETTY_ACCOUNTS"
            Me.txtAccID.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_NO")
            Me.txtAccName.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_NAME")
            Me.txtDrCr.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_TYPE")
            Me.txtOpnBal.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_BALANCE")
            Me.txtLimit.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_LIMIT")
            Me.dtpOpenOn.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_OPN_DATE")
            Me.cmbAccHead.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_HEAD")
            Me.txtOpnDrBal.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_DEBIT")
            Me.txtOpnCrBal.DataBindings.Add("TEXT", PettyAccBindingSource, "P_ACC_CREDIT")
            Addition = False
            Editing = False
            Me.BindingNavigatorSaveItem.Enabled = False
            Me.Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            cmbAccHead.Focus()
            AccDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        Dim strCode As String
        strCode = Microsoft.VisualBasic.InputBox("Please Enter Petty Account Code To Find.", "Find")
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.PettyAccBindingSource.Find("P_ACC_NO", Val(strCode.Trim))
        If Not Pos = -1 Then
            EditString = strCode
            Me.PettyAccBindingSource.Position = Pos
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Panel1.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        NewAccID = GenerateMax_ID("PETTY_ACCOUNTS", "P_ACC_NO")
        txtAccID.Text = NewAccID
        cmbAccHead.Focus()
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click
        Editing = True
        Addition = False
        Panel1.Enabled = True
        EditString = txtAccID.Text.Trim
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        EditString = txtAccID.Text.Trim
        txtAccName.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtAccName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record")
        If Me.BindingNavigatorCloseItem.Text = "&Cancel" Then Me.BindingNavigatorCloseItem.Text = "&Close"
        If MsgBoxResult.Ok Then
            Try
                Dim CommandText As String = "DELETE FROM PETTY_ACCOUNTS WHERE P_ACC_NO = " & Val(txtAccID.Text.ToUpper.Trim)
                ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "PETTY_ACCOUNTS", Connection)
            Catch Ex As SqlException
                Me.AccDataGrid.RefreshEdit()
                Me.PettyAccBindingNavigator.Refresh()
            End Try
        End If
        Me.AccDataGrid.RefreshEdit()
        Me.PettyAccBindingNavigator.Refresh()
        Call RefreshDB()
    End Sub

    Private Sub BindingNavigatorCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCloseItem.Click
        If Me.BindingNavigatorCloseItem.Text = "&Close" Then
            Connection.Close()
            Me.PettyAccBindingSource.Dispose()
            Me.Close()
        Else
            Me.BindingNavigatorCloseItem.Text = "&Cancel"
            Me.BindingNavigatorSaveItem.Enabled = False
            Panel1.Enabled = False
            Me.BindingNavigatorCloseItem.Text = "&Close"
            Call RefreshDB()
            Addition = False
            Editing = False
        End If
    End Sub
    Private Sub BindingNavigatorQuery(ByVal Query As String)
        Try
            Execute_DatabaseTable_Query(SqlDataAdapter, Query, Connection)
            Connection.Close()
            SqlDataAdapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click

        If txtDrCr.Text = "DR" Then _
            OpeningBal = Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) - Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim))
        If txtDrCr.Text = "CR" Then _
            OpeningBal = Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) - Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim))

        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE PETTY_ACCOUNTS SET P_ACC_NAME = '" & StrConv(txtAccName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " P_ACC_TYPE = '" & txtDrCr.Text.ToUpper.Trim & "'," & _
                                                           " P_ACC_OPN_DATE = '" & Format(DateTime.Parse(dtpOpenOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                                                           " P_ACC_BALANCE = " & Convert.ToDecimal(OpeningBal) & "," & _
                                                           " P_ACC_UPDATE = '" & Format(DateTime.Parse(Now.Date.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                                                           " P_ACC_DEBIT = " & Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) & "," & _
                                                           " P_ACC_CREDIT = " & Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) & "," & _
                                                           " P_ACC_LIMIT = " & Convert.ToDecimal(Val(txtLimit.Text.Trim)) & "," & _
                                                           " P_ACC_HEAD = '" & cmbAccHead.Text.ToUpper.Trim & "' WHERE P_ACC_NO = '" & EditString & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO PETTY_ACCOUNTS VALUES('" & NewAccID & "','" & _
                                                           cmbAccHead.Text.ToUpper.Trim & "','" & _
                                                           Format(DateTime.Parse(dtpOpenOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','" & _
                                                           StrConv(txtAccName.Text.ToUpper.Trim, VbStrConv.ProperCase) & "','" & _
                                                           txtDrCr.Text.ToUpper.Trim & "'," & _
                                                           Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) & ",'" & _
                                                           Format(DateTime.Parse(Now.Date.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & Convert.ToDecimal(Val(txtOpnDrBal.Text.Trim)) & "," & Convert.ToDecimal(Val(txtOpnCrBal.Text.Trim)) & "," & Val(txtLimit.Text.Trim) & ")")

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
            Me.PettyAccDataSet.Clear()
            SqlDataAdapter.Dispose()
            Me.AccDataGrid.Refresh()
            Dim QueryText As String = "SELECT * FROM PETTY_ACCOUNTS ORDER BY P_ACC_NO"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "PETTY_ACCOUNTS", Connection)
            SqlDataAdapter.Fill(Me.PettyAccDataSet, "PETTY_ACCOUNTS")
            Me.PettyAccBindingSource.DataSource = Me.PettyAccDataSet
            Me.PettyAccBindingSource.DataMember = "PETTY_ACCOUNTS"
            Me.AccDataGrid.RefreshEdit()
            Me.AccDataGrid.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub cmbDrCr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDrCr.SelectedIndexChanged
        If cmbDrCr.Text.Trim = "Debit" Then txtDrCr.Text = "DR"
        If cmbDrCr.Text.Trim = "Credit" Then txtDrCr.Text = "CR"
    End Sub

    Private Sub txtOpnDrBal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpnDrBal.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub txtOpnDrBal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpnDrBal.KeyPress
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                txtOpnDrBal.Text = ""
            ElseIf strCurrency.Length = 1 Then
                txtOpnDrBal.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                txtOpnDrBal.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                txtOpnDrBal.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            txtOpnDrBal.Select(txtOpnDrBal.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub txtOpnCrBal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpnCrBal.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub txtOpnCrBal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpnCrBal.KeyPress
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If
            If strCurrency.Length = 0 Then
                txtOpnCrBal.Text = ""
            ElseIf strCurrency.Length = 1 Then
                txtOpnCrBal.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                txtOpnCrBal.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                txtOpnCrBal.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            txtOpnCrBal.Select(txtOpnCrBal.Text.Length, 0)
        End If
        e.Handled = True
    End Sub

    Private Sub txtLimit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLimit.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub txtLimit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLimit.KeyPress
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If
            If strCurrency.Length = 0 Then
                txtLimit.Text = ""
            ElseIf strCurrency.Length = 1 Then
                txtLimit.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                txtLimit.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                txtLimit.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            txtLimit.Select(txtLimit.Text.Length, 0)
        End If
        e.Handled = True
    End Sub
End Class