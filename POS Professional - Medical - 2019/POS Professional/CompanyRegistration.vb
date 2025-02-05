Imports System.Data.SqlClient

Public Class CompanyRegistration
    Dim FindAdapter As New SqlDataAdapter()
    Dim CheckAdapter As New SqlDataAdapter()
    Dim FindDataSet As New DataSet()
    Dim Pos, City_Code As Integer
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub CompanyCodes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSeq.Focus()
    End Sub

    Private Sub CompanyCodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, illegal operation.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        Me.Top = Me.Top + 100
        Me.Left = Me.Left + 100
        Call GetConnectionString()
        GetLastSequence()
    End Sub

    Private Sub GetLastSequence()
        Dim Max As String = "select max(companycode) as MaxID from company"
        Dim MaxAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(MaxAdapter, Max, Connection)
        Dim reader As SqlDataReader = MaxAdapter.SelectCommand.ExecuteReader
        While reader.Read
            lblSeq.Text = reader.Item("MaxID").ToString
        End While
        If reader Is Nothing Then reader.Close()
    End Sub

    Private Sub ClearText()
        txtCoName.Clear()
        txtAreaName.Clear()
        txtAreaName.Clear()
    End Sub

    Private Sub enableTextBoxes(ByVal State As Boolean)
        txtAreaName.ReadOnly = State
        txtAreaCode.ReadOnly = State
        txtAreaName.ReadOnly = State
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearText()
        Editing = False
        Addition = True
        btnSave.Enabled = False
        txtSeq.Text = GenerateMax_ID("company", "companycode")
        txtCoName.Focus()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        enableTextBoxes(False)
        Editing = True
        Addition = False
        EditString = txtSeq.Text
        txtCoName.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtCoName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ProcessTransaction("DELETE FROM COMPANY WHERE COMPANYNAME = '" & txtCoName.Text.Trim & "'")
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Edit_Update_Query As String = String.Empty
        If RollBack = False Then
            If Editing = True And Addition = False Then ProcessTransaction("UPDATE COMPANY SET COMPANYNAME = '" & txtAreaName.Text.ToUpper & "', " & _
                                                                                            "COMPANYCODE = " & Val(txtSeq.Text) & ", " & _
                                                                                            "COMPANYAREACODE = " & Val(txtAreaCode.Text) & ", " & _
                                                                                            "COMPANYAREA = '" & txtAreaName.Text.ToUpper & "' " & _
                                                                                            "WHERE COMPANYCODE = '" & EditString & "'")

            If Addition = True And Editing = False Then ProcessTransaction("INSERT INTO COMPANY VALUES(" & Val(txtSeq.Text) & ",'" & txtCoName.Text.ToUpper & "'," & _
                                                                                            Val(txtAreaCode.Text) & ",'" & _
                                                                                            txtAreaName.Text.ToUpper & "')")

            btnSave.Enabled = False
            ClearText()
            txtSeq.Clear()
            txtSeq.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSeq_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeq.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtSeq.Text) > 0 Then
                Dim FindQuery As String = "select * from company where companycode = " & Val(txtSeq.Text)
                ExecuteDatasetQuery(FindAdapter, FindDataSet, FindQuery, "company", Connection)
                Dim FindReader As SqlDataReader = FindAdapter.SelectCommand.ExecuteReader
                If FindReader.HasRows = True Then
                    While FindReader.Read
                        txtSeq.Text = FindReader.Item("companycode").ToString
                        txtCoName.Text = FindReader.Item("companyname").ToString
                        txtAreaCode = FindReader.Item("companyareacode")
                        txtAreaName.Text = FindReader.Item("companyarea").ToString
                        btnNew.Focus()
                    End While
                Else
                    enableTextBoxes(False)
                    ClearText()
                    txtCoName.Focus()
                    Addition = True
                End If
            End If
        End If
    End Sub

    Private Sub txtCoName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCoName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAreaCode.Focus()
        End If
    End Sub

    Private Sub txtAreaCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAreaCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ExecuteAdapterQuery(SqlDataAdapter, "select city_name from city where city_id = " & Val(txtAreaCode.Text.Trim), Connection)
            Dim Areader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            While Areader.Read
                txtAreaName.Text = Areader.Item("city_name").ToString
            End While
        End If
    End Sub

    Private Sub txtAreaName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAreaName.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub txtCoName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCoName.TextChanged
        btnSave.Focus()
    End Sub

    Private Sub txtAreaCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAreaCode.TextChanged
        btnSave.Focus()
    End Sub

    Private Sub txtAreaName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAreaName.TextChanged
        btnSave.Focus()
    End Sub
End Class