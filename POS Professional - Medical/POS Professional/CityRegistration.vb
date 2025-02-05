Imports System.Data.SqlClient

Public Class CityRegistration
    Dim FindAdapter As New SqlDataAdapter()
    Dim CheckAdapter As New SqlDataAdapter()
    Dim FindDataSet As New DataSet()
    Dim Pos, City_Code As Integer
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub CityCodes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSeq.Focus()
    End Sub

    Private Sub CityRegistration_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F11 Then
            ClearText()
            enableTextBoxes(True)
            GetLastSequence()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            txtSeq.Focus()
        End If
    End Sub

    Private Sub CityCodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim Max As String = "select max(city_id) as MaxID from city"
        Dim MaxAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(MaxAdapter, Max, Connection)
        Dim reader As SqlDataReader = MaxAdapter.SelectCommand.ExecuteReader
        While reader.Read
            lblSeq.Text = reader.Item("MaxID").ToString
        End While
        If reader Is Nothing Then reader.Close()
        txtSeq.Text = GenerateMax_ID("city", "city_id")
    End Sub

    Private Sub ClearText()
        txtCitySN.Clear()
        txtCityName.Clear()
        txtPostal.Clear()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearText()
        Editing = False
        Addition = True
        btnSave.Enabled = False
        txtSeq.Text = GenerateMax_ID("city", "city_id")
        txtCityName.Focus()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        enableTextBoxes(False)
        Editing = True
        Addition = False
        EditString = txtSeq.Text
        txtCityName.Focus()
    End Sub

    Private Sub enableTextBoxes(ByVal State As Boolean)
        txtCityName.ReadOnly = State
        txtCitySN.ReadOnly = State
        txtPostal.ReadOnly = State
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtCityName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ProcessTransaction("DELETE FROM CITY WHERE CITY_NAME = '" & txtCityName.Text.Trim & "'")
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            GetLastSequence()
            ClearText()
            enableTextBoxes(True)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Edit_Update_Query As String = String.Empty
        If RollBack = False Then
            If Editing = True And Addition = False Then ProcessTransaction("UPDATE CITY SET CITY_NAME = '" & txtCityName.Text.ToUpper & "', " & _
                                                                                            "CITY_ID = " & Val(txtSeq.Text) & ", " & _
                                                                                            "CITY_PIN = " & Val(txtPostal.Text) & ", " & _
                                                                                            "CITY_SNAME = '" & txtCitySN.Text.ToUpper & "' " & _
                                                                                            "WHERE CITY_ID = '" & EditString & "'")

            If Addition = True And Editing = False Then ProcessTransaction("INSERT INTO AREA VALUES(" & Val(txtSeq.Text) & "," & Val(txtPostal.Text) & ",'" & _
                                                                                            txtCityName.Text.ToUpper & "','" & _
                                                                                            txtCitySN.Text.ToUpper & "')")


            ClearText()
            txtSeq.Clear()
            enableTextBoxes(True)
            GetLastSequence()
            txtSeq.Focus()
            btnSave.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub txtSeq_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeq.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtSeq.Text) > 0 Then
                Dim FindQuery As String = "select * from city where city_id = " & Val(txtSeq.Text)
                ExecuteDatasetQuery(FindAdapter, FindDataSet, FindQuery, "city", Connection)
                Dim FindReader As SqlDataReader = FindAdapter.SelectCommand.ExecuteReader
                If FindReader.HasRows = True Then
                    While FindReader.Read
                        txtSeq.Text = FindReader.Item("city_id").ToString
                        txtCityName.Text = FindReader.Item("city_name").ToString
                        txtPostal.Text = FindReader.Item("city_pin")
                        txtCitySN.Text = FindReader.Item("city_sname").ToString
                        btnDelete.Enabled = True
                        btnEdit.Enabled = True
                        btnEdit.Focus()
                    End While
                Else
                    enableTextBoxes(False)
                    ClearText()
                    txtCityName.Focus()
                    Addition = True
                End If
            End If
        End If
    End Sub

    Private Sub txtCityName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCityName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCitySN.Focus()
        End If
    End Sub

    Private Sub txtCitySN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCitySN.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPostal.Focus()
        End If
    End Sub

    Private Sub txtPostal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPostal.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnNew.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCityName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCityName.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtCitySN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCitySN.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtPostal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostal.TextChanged
        btnSave.Enabled = True
    End Sub
End Class