Imports System.Data.SqlClient
Public Class frmTests
    Dim Pos As Integer
    Dim EditString As String
    Dim strCode As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub frmTests_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.TestDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM TESTS ORDER BY TCODE"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "TESTS", Connection)
            SqlDataAdapt.Fill(Me.TestDataSet, "TESTS")
            Me.TestBindingSource.DataSource = Me.TestDataSet
            Me.TestBindingSource.DataMember = "TESTS"
            Me.txtCode.DataBindings.Add("TEXT", TestBindingSource, "TCODE")
            Me.txtName.DataBindings.Add("TEXT", TestBindingSource, "TNAME")
            Me.txtCatg.DataBindings.Add("TEXT", TestBindingSource, "TCATG")
            Me.txtRate.DataBindings.Add("TEXT", TestBindingSource, "TRATE")
            Me.txtSpecimen.DataBindings.Add("TEXT", TestBindingSource, "TSAMPLE")
            Me.txtReport.DataBindings.Add("TEXT", TestBindingSource, "TREPORT")
            Me.txtLvl.DataBindings.Add("TEXT", TestBindingSource, "TRPTLVL")
            Me.txtDiscMode.DataBindings.Add("TEXT", TestBindingSource, "TDISCMODE")
            Addition = False
            Editing = False
            Me.BindingNavigatorSaveItem.Enabled = False
            Me.Panel1.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            TestDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        strCode = Microsoft.VisualBasic.InputBox("Please Enter Test Code To Find.", "Find")
        If Len(strCode) = 0 Then Exit Sub
        Call FindTest()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Panel1.Enabled = True
        Addition = True
        RollBack = True
        Editing = False
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        txtCode.Focus()
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click
        Editing = True
        Addition = False
        Panel1.Enabled = True
        EditString = txtCode.Text.Trim
        BindingNavigatorSaveItem.Enabled = True
        BindingNavigatorCloseItem.Text = "&Cancel"
        EditString = txtCode.Text.Trim
        txtName.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(txtName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record")
        If MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM TESTS WHERE TCODE = '" & txtCode.Text.ToUpper.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
        End If
        If Me.BindingNavigatorCloseItem.Text = "&Cancel" Then Me.BindingNavigatorCloseItem.Text = "&Close"
        Call RefreshDB()

    End Sub

    Private Sub BindingNavigatorCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCloseItem.Click
        If Me.BindingNavigatorCloseItem.Text = "&Close" Then
            Connection.Close()
            Me.TestBindingSource.Dispose()
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
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("UPDATE TESTS SET TCODE = '" & txtCode.Text.ToUpper.Trim & "'," & _
                                                           " TNAME = '" & txtName.Text.ToUpper.Trim & "'," & _
                                                           " TCATG = '" & txtCatg.Text.ToUpper.Trim & "'," & _
                                                           " TRATE = " & Val(txtRate.Text.Trim) & "," & _
                                                           " TSAMPLE = '" & txtSpecimen.Text.ToUpper.Trim & "'," & _
                                                           " TREPORT = '" & txtReport.Text.ToUpper.Trim & "'," & _
                                                           " TRPTLVL = " & Val(txtLvl.Text.Trim) & "," & _
                                                           " TDISCMODE = '" & txtDiscMode.Text.ToUpper.Trim & "' WHERE TCODE = '" & EditString & "'")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO TESTS VALUES('" & txtCode.Text.ToUpper.Trim & "','" & _
                                                           txtName.Text.ToUpper.Trim & "','" & _
                                                           txtCatg.Text.ToUpper.Trim & "'," & _
                                                           Val(txtRate.Text.Trim) & ",'" & _
                                                           txtSpecimen.Text.ToUpper.Trim & "','" & _
                                                           txtReport.Text.ToUpper.Trim & "'," & _
                                                           txtLvl.Text.Trim & ",'" & _
                                                           txtDiscMode.Text.ToUpper.Trim & "',0,0,'" & txtCode.Text.ToUpper.Trim & "')")

        Call RefreshDB()
        Me.BindingNavigatorSaveItem.Enabled = False
        Panel1.Enabled = False
        Editing = False
        Addition = False
        Me.BindingNavigatorEditItem.Enabled = True
        Me.BindingNavigatorCloseItem.Text = "&Close"
        Call FindTest()
    End Sub

    Private Sub RefreshDB()

        Try
            Me.TestDataSet.Clear()
            SqlDataAdapt.Dispose()
            Me.TestDataGrid.Refresh()
            Dim QueryText As String = "SELECT * FROM TESTS ORDER BY TCODE"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QueryText, "TESTS", Connection)
            SqlDataAdapt.Fill(Me.TestDataSet, "TESTS")
            Me.TestBindingSource.DataSource = Me.TestDataSet
            Me.TestBindingSource.DataMember = "TESTS"
            Me.TestDataGrid.RefreshEdit()
            Me.TestDataGrid.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub FindTest()
        Pos = Me.TestBindingSource.Find("TCODE", strCode.Trim)
        If Not Pos = -1 Then
            EditString = strCode
            Me.TestBindingSource.Position = Pos
        End If
    End Sub
    
End Class