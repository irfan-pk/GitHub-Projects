Imports System.Data.SqlClient
Public Class frmNewAcc
    Dim Pos, NewAccID As Integer
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub frmNewAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.AccDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM ACCOUNTS ORDER BY ACC_NO"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "ACCOUNTS", Connection)
            SqlDataAdapt.Fill(Me.AccDataSet, "ACCOUNTS")
            Me.AccBindingSource.DataSource = Me.AccDataSet
            Me.AccBindingSource.DataMember = "ACCOUNTS"
            Me.txtAccID.DataBindings.Add("TEXT", AccBindingSource, "ACC_NO")
            Me.txtAccName.DataBindings.Add("TEXT", AccBindingSource, "ACC_NAME")
            Me.txtDrCr.DataBindings.Add("TEXT", AccBindingSource, "ACC_TYPE")
            Me.txtOpnBal.DataBindings.Add("TEXT", AccBindingSource, "ACC_BALANCE")
            Me.dtpUpdOn.DataBindings.Add("TEXT", AccBindingSource, "ACC_UPDATE")
            Me.dtpOpenOn.DataBindings.Add("TEXT", AccBindingSource, "ACC_OPN_DATE")
            Me.txtLink.DataBindings.Add("TEXT", AccBindingSource, "ACC_LINK_CODE")
            Me.cmbCategory.DataBindings.Add("TEXT", AccBindingSource, "ACC_LINK")
            Addition = False
            Editing = False
            Me.BindingNavigatorSaveItem.Enabled = False
            Me.Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            AccDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        Dim strCode As String
        strCode = Microsoft.VisualBasic.InputBox("Please Enter Acc Code To Find.", "Find")
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.AccBindingSource.Find("ACC_NO", Val(strCode.Trim))
        If Not Pos = -1 Then
            EditString = strCode
            Me.AccBindingSource.Position = Pos
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Panel1.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        NewAccID = GenerateMax_ID("ACCOUNTS", "ACC_NO")
        txtAccID.Text = NewAccID
        txtAccName.Focus()
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
        If MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM ACCOUNTS WHERE ACC_NO = " & Val(txtAccID.Text.ToUpper.Trim)
            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
        End If
        If Me.BindingNavigatorCloseItem.Text = "&Cancel" Then Me.BindingNavigatorCloseItem.Text = "&Close"
        Call RefreshDB()

    End Sub

    Private Sub BindingNavigatorCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCloseItem.Click
        If Me.BindingNavigatorCloseItem.Text = "&Close" Then
            Connection.Close()
            Me.AccBindingSource.Dispose()
            Me.Close()
        Else
            Me.BindingNavigatorCloseItem.Text = "&Close"
            Me.BindingNavigatorSaveItem.Enabled = False
            Panel1.Enabled = False
            Call RefreshDB()
            Addition = False
            Editing = False
        End If
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

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click

        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE ACCOUNTS SET ACC_NAME = '" & StrConv(txtAccName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " ACC_TYPE = '" & txtDrCr.Text.ToUpper.Trim & "'," & _
                                                           " ACC_BALANCE = " & Val(txtOpnBal.Text.Trim) & "," & _
                                                           " ACC_LINK_CODE = " & Val(txtLink.Text.Trim) & "," & _
                                                           " ACC_LINK = '" & cmbCategory.Text.ToUpper.Trim & "' WHERE ACC_NO = '" & EditString & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO ACCOUNTS VALUES('" & NewAccID & "','" & _
                                                           StrConv(txtAccName.Text.ToUpper.Trim, VbStrConv.ProperCase) & "','" & _
                                                           txtDrCr.Text.ToUpper.Trim & "'," & _
                                                           Val(txtOpnBal.Text.Trim) & ",'" & _
                                                           Format(DateTime.Parse(dtpUpdOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "','" & _
                                                           Format(DateTime.Parse(dtpOpenOn.Value.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                                                           Val(txtLink.Text.Trim) & ",'" & _
                                                           cmbCategory.Text.ToUpper.Trim & "',0.00,0.00)")

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
            Me.AccDataSet.Clear()
            SqlDataAdapt.Dispose()
            Me.AccDataGrid.Refresh()
            Dim QueryText As String = "SELECT * FROM ACCOUNTS ORDER BY ACC_NO"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QueryText, "ACCOUNTS", Connection)
            SqlDataAdapt.Fill(Me.AccDataSet, "ACCOUNTS")
            Me.AccBindingSource.DataSource = Me.AccDataSet
            Me.AccBindingSource.DataMember = "ACCOUNTS"
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

End Class