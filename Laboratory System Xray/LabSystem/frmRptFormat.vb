Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class frmRptFormat
    Dim QryReader As SqlDataReader
    Dim Addition, Editing As Boolean
    Dim FileCode As String = ""
    Dim Sort_ID, i, j As Integer

    Private Sub frmRptFormat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Connection.Close()
        Me.ParameterBindingSource.Dispose()

    End Sub

    Private Sub frmRptFormat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call GetConnectionString()
        Dim QryString As String = "SELECT DISTINCT TCATG FROM TESTS"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QryString, "TESTS", Connection)
        SqlDataAdapt.Fill(SqlDataSet, "TESTS")
        QryReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While QryReader.Read
            cmbCatgory.Items.Add(QryReader.Item("TCATG").ToString.ToUpper.Trim)
        End While
        If Not QryReader Is Nothing Then QryReader.Close()
        Addition = False
        Editing = False
        Dim MyString As String = "SELECT * FROM RPT_PARAM WHERE RPTCODE = 'CPMALE' ORDER BY SORT_ORDER"
        Me.ParameterDataSet.Clear()
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, MyString, "RPT_PARAM", Connection)
        SqlDataAdapt.Fill(ParameterDataSet, "RPT_PARAM")
        Me.ParameterBindingSource.DataSource = ParameterDataSet
        Me.ParameterBindingSource.DataMember = "RPT_PARAM"
        Me.RptFormatGrid.DataSource = Me.ParameterBindingSource
        Me.BindingNavigatorCloseItem.Text = "&Cancel"
        RptFormatGrid.Enabled = False

    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        ParameterDataSet.Clear()
        Me.RptFormatGrid.DataSource = Nothing
        Call Clear_TextBoxes()
        Me.BindingNavigatorCloseItem.Text = "&Cancel"

    End Sub

    Private Sub cmbReportID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbReportID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cmbReportID.Text = cmbReportID.Text.ToUpper
            Dim MyString As String = "SELECT * FROM RPT_PARAM WHERE RPTCODE = '" & cmbReportID.Text.Trim.ToUpper & "' ORDER BY SORT_ORDER"
            Me.ParameterDataSet.Clear()
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, MyString, "RPT_PARAM", Connection)
            SqlDataAdapt.Fill(ParameterDataSet, "RPT_PARAM")
            Me.ParameterBindingSource.DataSource = ParameterDataSet
            Me.ParameterBindingSource.DataMember = "RPT_PARAM"
            Me.RptFormatGrid.DataSource = Me.ParameterBindingSource
            Me.BindingNavigatorCloseItem.Text = "&Cancel"
            cmbCatgory.Focus()
        End If
    End Sub

    Private Sub BindingNavigatorCloseItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorCloseItem.Click
        If Me.BindingNavigatorCloseItem.Text = "&Cancel" Then
            ParameterDataSet.Clear()
            RptFormatGrid.DataSource = Nothing
            Me.RptFormatGrid.Enabled = Nothing
            Call Clear_TextBoxes()
            Me.BindingNavigatorCloseItem.Text = "E&xit Editor"
        Else
            Me.ParameterDataSet.Clear()
            Me.ParameterBindingSource.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click

        Editing = True
        Addition = False
        RptFormatGrid.Enabled = True
        Me.BindingNavigatorCloseItem.Text = "&Cancel"
        Me.txtFileID.DataBindings.Add("TEXT", ParameterBindingSource, "FILECODE")
        Me.cmbCatgory.DataBindings.Add("TEXT", ParameterBindingSource, "CATEGORY")
        Me.txtGroup.DataBindings.Add("TEXT", ParameterBindingSource, "GROUP_PARM")
        Me.txtParameter.DataBindings.Add("TEXT", ParameterBindingSource, "PARAMETERS")
        Me.txtDef_Val.DataBindings.Add("TEXT", ParameterBindingSource, "DEF_VAL")
        Me.txtUnit.DataBindings.Add("TEXT", ParameterBindingSource, "UNITS")
        Me.txtNorRange.DataBindings.Add("TEXT", ParameterBindingSource, "NORM_VAL")

    End Sub

    Private Sub Clear_TextBoxes()
        txtFileID.Clear()
        txtDef_Val.Clear()
        txtGroup.Clear()
        cmbReportID.Text = ""
        txtNorRange.Clear()
        txtParameter.Clear()
        txtUnit.Clear()
    End Sub

    Private Sub txtNorRange_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNorRange.KeyDown
        If e.Control And e.KeyCode = Keys.U Then Call Update_Rpt_Format()
    End Sub

    Private Function GetSort_ID(ByVal strquery As String) As Integer

        Dim MaxID_Text As String = strquery

        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=LAB;NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    GetSort_ID = 1
                Else
                    GetSort_ID = Convert.ToDecimal(Cmd.ExecuteScalar()) + 1
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return GetSort_ID
        End Using

    End Function

    Private Sub Update_Rpt_Format()

        Dim MyQuery As String = ""

        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then MyQuery = "UPDATE TESTS SET FILECODE = '" & txtFileID.Text.ToUpper.Trim & "'," & _
                                                              " RPTCODE = '" & cmbReportID.Text.ToUpper.Trim & "'," & _
                                                              " TSTCODE = '" & txtFileID.Text.ToUpper.Trim & "'," & _
                                                              " CATEGORY = '" & cmbCatgory.Text.ToUpper.Trim & "'," & _
                                                              " GROUP_PARM = '" & txtGroup.Text.ToUpper.Trim & "'," & _
                                                              " PARAMETERS = '" & txtParameter.Text.ToUpper.Trim & "'," & _
                                                              " DEF_VAL = '" & txtDef_Val.Text.ToUpper.Trim & "'," & _
                                                              " UNITS = '" & txtUnit.Text.ToUpper.Trim & "'," & _
                                                              " NORM_VAL = '" & StrConv(txtNorRange.Text, VbStrConv.ProperCase) & "'," & _
                                                              " SORT_ORDER = " & Sort_ID & _
                                                              " WHERE (FILECODE = '" & txtFileID.Text.ToUpper.Trim & "') AND (RPTCODE = '" & cmbReportID.Text.ToUpper.Trim & "') AND (PARAMETER = '" & txtParameter.Text.ToUpper.Trim & "')"

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then MyQuery = "INSERT INTO TESTS VALUES('" & txtFileID.Text.ToUpper.Trim & "','" & _
                                                              cmbReportID.Text.ToUpper.Trim & "','" & _
                                                              txtFileID.Text.ToUpper.Trim & "','" & _
                                                              cmbCatgory.Text.ToUpper.Trim & "','" & _
                                                              txtGroup.Text.ToUpper.Trim & "','" & _
                                                              txtParameter.Text.ToUpper.Trim & "','" & _
                                                              txtDef_Val.Text.ToUpper.Trim & "','" & _
                                                              txtUnit.Text.ToUpper.Trim & "','" & _
                                                              StrConv(txtNorRange.Text, VbStrConv.ProperCase) & "'," & Sort_ID & ")"



    End Sub

    Private Sub RptFormatGrid_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles RptFormatGrid.CellBeginEdit

    End Sub

    Private Sub RptFormatGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RptFormatGrid.CellEndEdit

    End Sub

    Private Sub RptFormatGrid_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RptFormatGrid.CellValueChanged
        'FOR UPDATE RECORD THROUGH CELL EDITING IN DATAGRID WHEN EDIT MODE
    End Sub

    Private Sub txtFileID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFileID.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Len(txtFileID.Text) = 0 Then MsgBox("Please Enter Valid File ID", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
            Call GetConnectionString()
            Dim QryString As String = "SELECT DISTINCT RPTCODE FROM RPT_PARAM WHERE TSTCODE = '" & Trim(txtFileID.Text.ToUpper) & "'"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QryString, "RPT_PARAM", Connection)
            Dim READER = SqlDataAdapt.SelectCommand.ExecuteReader
            While READER.Read
                cmbReportID.Items.Add(READER.Item("RPTCODE").ToString.ToUpper.Trim)
            End While
            If Not READER Is Nothing Then READER.Close()
            cmbReportID.Focus()
        End If

    End Sub

End Class