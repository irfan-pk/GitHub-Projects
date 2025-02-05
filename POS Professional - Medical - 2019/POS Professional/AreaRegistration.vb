Imports System.Data.SqlClient

Public Class AreaRegistration
    Dim FindAdapter As New SqlDataAdapter()
    Dim CheckAdapter As New SqlDataAdapter()
    Dim FindDataSet As New DataSet()
    Dim Pos, City_Code As Integer
    Dim EditString As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean

    Private Sub AreaCodes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSeq.Focus()
    End Sub

    Private Sub AreaCodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim Max As String = "select max(area_id) as MaxID from area"
        Dim MaxAdapter As New SqlDataAdapter
        ExecuteAdapterQuery(MaxAdapter, Max, Connection)
        Dim reader As SqlDataReader = MaxAdapter.SelectCommand.ExecuteReader
        While reader.Read
            lblSeq.Text = reader.Item("MaxID").ToString
        End While
        If reader Is Nothing Then reader.Close()
        ExecuteAdapterQuery(SqlDataAdapter, "select city_name from city order by city_id", Connection)
        Dim cityreader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While cityreader.Read
            cmbCity.Items.Add(cityreader.Item("city_name").ToString)
        End While
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Edit_Update_Query As String = String.Empty
        If RollBack = False Then
            If Editing = True And Addition = False Then ProcessTransaction("UPDATE AREA SET AREA_NAME = '" & txtAreaName.Text.ToUpper & "', " & _
                                                                                            "AREA_ID = " & Val(txtSeq.Text) & ", " & _
                                                                                            "AREA_CITY = " & City_Code & ", " & _
                                                                                            "AREA_SNAME = '" & txtAreaSN.Text.ToUpper & "' " & _
                                                                                            "WHERE USERID = '" & EditString & "'")

            If Addition = True And Editing = False Then ProcessTransaction("INSERT INTO AREA VALUES(" & Val(txtSeq.Text) & ",'" & txtAreaName.Text.ToUpper & "'," & _
                                                                                            City_Code & ",'" & _
                                                                                            txtAreaSN.Text.ToUpper & "')")

            btnSave.Enabled = False
            ClearText()
            txtSeq.Clear()
            txtSeq.Focus()
        End If
    End Sub

    Private Sub ClearText()
        txtAreaSN.Clear()
        txtAreaName.Clear()
        cmbCity.Text = String.Empty
    End Sub

    Private Sub txtSeq_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeq.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtSeq.Text) > 0 Then
                Dim FindQuery As String = "select * from area where area_id = " & Val(txtSeq.Text)
                ExecuteDatasetQuery(FindAdapter, FindDataSet, FindQuery, "area", Connection)
                Dim FindReader As SqlDataReader = FindAdapter.SelectCommand.ExecuteReader
                If FindReader.HasRows = True Then
                    While FindReader.Read
                        txtSeq.Text = FindReader.Item("area_id").ToString
                        txtAreaName.Text = FindReader.Item("area_name").ToString
                        City_Code = FindReader.Item("area_city")
                        txtAreaSN.Text = FindReader.Item("area_sname").ToString
                        btnNew.Focus()
                    End While
                Else
                    enableTextBoxes(False)
                    ClearText()
                    txtAreaName.Focus()
                    Addition = True
                End If
            End If

            If City_Code > 0 Then
                ExecuteAdapterQuery(SqlDataAdapter, "select city_name from city where city_id = " & City_Code, Connection)
                Dim cityreader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                While cityreader.Read
                    cmbCity.Text = cityreader.Item("city_name").ToString
                End While
            End If
        End If
    End Sub

    Private Sub txtSeq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeq.KeyPress
        ValidateNumbersOnly(sender, e, txtSeq)
    End Sub

    Private Sub enableTextBoxes(ByVal State As Boolean)
        txtAreaName.ReadOnly = State
        txtAreaSN.ReadOnly = State
    End Sub

    Private Sub txtAreaName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAreaName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAreaSN.Focus()
        End If
    End Sub

    Private Sub txtAreaSN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAreaSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbCity.Focus()
        End If
    End Sub

    Private Sub cmbCity_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnNew.Focus()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearText()
        Editing = False
        Addition = True
        btnSave.Enabled = False
        txtSeq.Text = GenerateMax_ID("area", "area_id")
        txtAreaName.Focus()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        enableTextBoxes(False)
        Editing = True
        Addition = False
        EditString = txtSeq.Text
        txtAreaName.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dr As DialogResult = MessageBox.Show("Are you sure to delete ('" & txtAreaName.Text.Trim.ToUpper & "') ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            ProcessTransaction("DELETE FROM AREA WHERE AREA_NAME = '" & txtAreaName.Text.Trim & "'")
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAreaName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAreaName.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub txtAreaSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAreaSN.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCity.SelectedIndexChanged
        btnSave.Enabled = True
    End Sub
End Class