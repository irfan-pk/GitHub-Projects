Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class ReportFormat
    Dim QryReader As SqlDataReader
    Dim RecStatus, Editing, Addition, Bind As Boolean
    Dim FileCode, FixedLabel, FixedReportID As String
    Dim MyQuery, Choice, EdtRptCode, EdtFileCode, EdtTstCode, EdtSubCode, EdtCategory, EdtParameter As String
    Dim EdtFrmName, EdtType, EdtDefVal, EdtNorVal, EdtUnits, EdtGroup As String
    Dim Sort_ID, i, j, Pos As Integer

    Private Sub RptFormat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        Me.ParameterBindingSource.Dispose()
    End Sub

    Private Sub RptFormat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetConnectionString()
        Dim QryString As String = "SELECT DISTINCT TCATG FROM TESTS"
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QryString, "TESTS", Connection)
        SqlDataAdapter.Fill(SqlDataSet, "TESTS")
        QryReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While QryReader.Read
            cmbCategory.Items.Add(QryReader.Item("TCATG").ToString.ToUpper.Trim)
        End While
        If Not QryReader Is Nothing Then QryReader.Close()
        gblFileCode = String.Empty
        FileCode = String.Empty
        FixedLabel = String.Empty
        FixedReportID = String.Empty
        Addition = False
        Editing = False
        Show_Parameters()
        'Me.lblFileCode.DataBindings.Add("TEXT", ParameterBindingSource, "FILECODE").ToString.Trim()
        'Me.txtReportID.DataBindings.Add("TEXT", ParameterBindingSource, "RPTCODE").ToString.Trim()
        Me.txtTstCode.DataBindings.Add("TEXT", ParameterBindingSource, "TSTCODE").ToString.Trim()
        Me.cmbCategory.DataBindings.Add("TEXT", ParameterBindingSource, "CATEGORY").ToString.Trim()
        Me.txtGroup.DataBindings.Add("TEXT", ParameterBindingSource, "GROUP_PARM").ToString.Trim()
        Me.txtParameter.DataBindings.Add("TEXT", ParameterBindingSource, "PARAMETERS").ToString.Trim()
        Me.txtSubCode.DataBindings.Add("TEXT", ParameterBindingSource, "SUBCODE").ToString.Trim()
        Me.txtDef_Val.DataBindings.Add("TEXT", ParameterBindingSource, "DEF_VAL").ToString.Trim()
        Me.txtUnit.DataBindings.Add("TEXT", ParameterBindingSource, "UNITS").ToString.Trim()
        Me.txtNorRange.DataBindings.Add("TEXT", ParameterBindingSource, "NORM_VAL").ToString.Trim()
        Me.cmbFormName.DataBindings.Add("TEXT", ParameterBindingSource, "FORMNAME").ToString.Trim()
        Me.cmbType.DataBindings.Add("TEXT", ParameterBindingSource, "TYPE").ToString.Trim()
    End Sub

    Private Sub txtReportID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReportID.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Tab Then
            If txtReportID.Text = String.Empty Then MsgBox("Please enter valid report Id.", MsgBoxStyle.Information) : Exit Sub
            Show_Parameters()
            Enable_Disable_Control(True)
            BindingNavigatorSaveItem.Enabled = True
            cmbCategory.Focus()
        End If
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click
        Editing = True
        RecStatus = False
        Addition = False
        Me.ToolStripCloseButton.Text = "&Cancel"
        Me.SplitContainer1.Panel1.Enabled = True
        Me.BindingNavigatorSaveItem.Enabled = True
        GetParameters()
    End Sub

    Private Sub Clear_TextBoxes()
        ParameterDataSet.Clear()
        ParameterBindingSource.ResetBindings(True)
        lblFileCode.Text = String.Empty
        txtDef_Val.Clear()
        txtGroup.Clear()
        txtReportID.Clear()
        txtNorRange.Clear()
        txtParameter.Clear()
        txtUnit.Clear()
        txtTstCode.Clear()
        txtSubCode.Clear()
        cmbCategory.Text = "x"
        cmbFormName.Text = "x"
        cmbType.Text = "x"
    End Sub

    Private Sub txtNorRange_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNorRange.KeyDown
        If txtNorRange.Enabled = True Then
            If e.KeyCode = Keys.U And (e.Control And Not e.Shift And Not e.Alt) Then
                Update_Rpt_Format()
            End If
        End If
    End Sub

    Private Function GetSort_ID(ByVal strquery As String) As Integer
        Dim MaxID_Text As String = strquery
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    GetSort_ID = 1
                Else
                    GetSort_ID = Convert.ToDecimal(Cmd.ExecuteScalar()) + 1
                End If
            Catch EX As SqlException
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return GetSort_ID
        End Using

    End Function

    Private Sub Update_Rpt_Format()
        '// If changes made in selected record then execute update record query
        If Editing = True Then MyQuery = "UPDATE RPT_PARAM SET FILECODE = '" & lblFileCode.Text.ToString & "'," & _
                                                              " RPTCODE = '" & txtReportID.Text.ToUpper.Trim & "'," & _
                                                              " CATEGORY = '" & cmbCategory.Text.ToUpper.Trim & "'," & _
                                                              " GROUP_PARM = '" & txtGroup.Text.ToUpper.Trim & "'," & _
                                                              " TSTCODE = '" & txtTstCode.Text.ToUpper.Trim & "'," & _
                                                              " SUBCODE = '" & txtSubCode.Text.ToUpper.Trim & "'," & _
                                                              " PARAMETERS = '" & txtParameter.Text.ToUpper.Trim & "'," & _
                                                              " DEF_VAL = '" & txtDef_Val.Text.ToUpper.Trim & "'," & _
                                                              " UNITS = '" & txtUnit.Text.Trim & "'," & _
                                                              " NORM_VAL = '" & txtNorRange.Text.Trim & "'," & _
                                                              " FORMNAME = '" & cmbFormName.Text.Trim & "'," & _
                                                              " TYPE = '" & cmbType.Text.Trim & "'" & _
                                                              " WHERE (RPTCODE = '" & EdtRptCode & "')" & _
                                                              " AND (FILECODE = '" & EdtFileCode & "')" & _
                                                              " AND (CATEGORY = '" & EdtCategory & "')" & _
                                                              " AND (TSTCODE = '" & EdtTstCode & "')" & _
                                                              " AND (SUBCODE = '" & EdtSubCode & "')" & _
                                                              " AND (PARAMETERS = '" & EdtParameter & "')"

        '// if entered new values in text boxes then execute add record query
        Sort_ID = GetSort_ID("SELECT MAX(SORT_ORDER) FROM RPT_PARAM WHERE RPTCODE = '" & txtReportID.Text.Trim & "'")
        If Editing = False Then MyQuery = "INSERT INTO RPT_PARAM VALUES('" & lblFileCode.Text.ToString.Trim & "','" & _
                                                              txtReportID.Text.ToUpper.Trim & "','" & _
                                                              cmbCategory.Text.ToUpper.Trim & "','" & _
                                                              txtGroup.Text.ToUpper.Trim & "','" & _
                                                              txtTstCode.Text.ToUpper.Trim & "','" & _
                                                              txtSubCode.Text.ToUpper.Trim & "','" & _
                                                              txtParameter.Text.ToUpper.Trim & "','" & _
                                                              txtDef_Val.Text.ToUpper.Trim & "','" & _
                                                              txtUnit.Text.Trim & "','" & _
                                                              txtNorRange.Text.Trim & "','" & _
                                                              Sort_ID & "','" & _
                                                              cmbFormName.Text.Trim & "','" & _
                                                              cmbType.Text.Trim & "')"
        Execute_DatabaseTable_Query(SqlDataAdapter, MyQuery, Connection)
        If Addition = True Then Me.ParameterBindingSource.AddNew()
        If Addition = True Then
            FixedLabel = lblFileCode.Text.Trim
            FixedReportID = txtReportID.Text.Trim
        End If
        EdtFileCode = String.Empty
        EdtRptCode = String.Empty
        EdtGroup = String.Empty
        EdtParameter = String.Empty
        EdtTstCode = String.Empty
        EdtSubCode = String.Empty
        gblFileCode = txtReportID.Text.Trim
        Show_Parameters()
        FocusLastRow()
    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If Me.ToolStripCloseButton.Text = "&Cancel" Then
            Me.ParameterDataSet.Clear()
            Me.ReportDataGrid.DataSource = Nothing
            Me.ToolStripCloseButton.Text = "&Close"
            Me.SplitContainer1.Panel1.Enabled = False
            Me.SplitContainer1.Panel2.Enabled = True
            Me.BindingNavigatorEditItem.Enabled = False
            Me.BindingNavigatorSaveItem.Enabled = False
            Me.ToolStripNewReportButton.Enabled = True
            Me.lblFileCode.Text = String.Empty
            Me.txtReportID.Text = String.Empty
            Editing = False
            Addition = False
            Me.ToolStripButtonAddNew.Enabled = False
        Else
            Me.ParameterDataSet.Clear()
            Me.ReportDataGrid.DataSource = Nothing
            Me.Close()
        End If
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        FileList.ShowDialog(Me)
        If Len(gblFileCode) > 0 Then lblFileCode.Text = gblFileCode.Trim
        txtReportID.Focus()
    End Sub

    Private Sub Show_Parameters()
        Me.txtReportID.Text = txtReportID.Text.ToUpper
        Dim MyString As String = "SELECT * FROM RPT_PARAM WHERE RPTCODE = '" & gblFileCode.ToUpper.Trim & "' ORDER BY SORT_ORDER"
        Me.ParameterDataSet.Clear()
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, MyString, "RPT_PARAM", Connection)
        SqlDataAdapter.Fill(ParameterDataSet, "RPT_PARAM")
        Dim GetFileName As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GetFileName.HasRows Then
            While GetFileName.Read
                lblFileCode.Text = GetFileName.Item("FILECODE").ToString
                txtReportID.Text = GetFileName.Item("RPTCODE").ToString
                FixedLabel = lblFileCode.Text.Trim
                FixedReportID = txtReportID.Text.Trim
            End While
            If GetFileName Is Nothing Then GetFileName.Close()
        End If
        Me.ParameterBindingSource.DataSource = ParameterDataSet
        Me.ParameterBindingSource.DataMember = "RPT_PARAM"
        Me.ReportDataGrid.DataSource = Me.ParameterBindingSource
    End Sub

    Private Sub txtGroup_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGroup.GotFocus
        txtGroup.SelectAll()
    End Sub

    Private Sub Enable_Disable_Control(ByVal State As String)
        cmbCategory.Enabled = State
        txtGroup.Enabled = State
        txtParameter.Enabled = State
        txtDef_Val.Enabled = State
        txtUnit.Enabled = State
        txtNorRange.Enabled = State
        BindingNavigatorEditItem.Enabled = State
    End Sub

    Private Sub txtTstCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTstCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            TestCodeList.ShowDialog(Me)
            If Len(gblTestCode) > 0 Then
                txtTstCode.Text = gblTestCode.ToUpper
                txtParameter.Text = gblTestName.Trim
            End If
            txtSubCode.Focus()
        End If
    End Sub

    Private Sub cmdTstCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTstCode.Click
        TestCodeList.ShowDialog(Me)
        If Len(gblTestCode) > 0 Then
            txtTstCode.Text = gblTestCode.ToUpper
            txtParameter.Text = gblTestName.Trim
        End If
        txtSubCode.Focus()
    End Sub

    Private Sub cmdSubCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubCode.Click
        TestCodeList.ShowDialog(Me)
        If Len(gblTestCode) > 0 Then
            txtSubCode.Text = gblTestCode.ToUpper
            txtParameter.Text = gblTestName.Trim
        End If
        txtParameter.Focus()
    End Sub

    Private Sub txtSubCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            TestCodeList.ShowDialog(Me)
            If Len(gblTestCode) > 0 Then
                txtSubCode.Text = gblTestCode.ToUpper
                txtParameter.Text = gblTestName.Trim
            End If
            txtParameter.Focus()
        End If
    End Sub

    Private Sub FocusLastRow()
        Dim strCode As String = txtSubCode.Text.Trim
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.ParameterBindingSource.Find("SUBCODE", strCode.Trim)
        If Not Pos = -1 Then
            Me.ParameterBindingSource.Position = Pos
        End If
    End Sub

    Private Sub txtReportID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReportID.KeyUp
        If e.KeyCode = Keys.F2 Then
            ReportFile.ShowDialog(Me)
            If gblReportName <> String.Empty Then txtReportID.Text = gblReportName.Trim
        End If
    End Sub

    Private Sub GetParameters()
        EdtCategory = cmbCategory.Text.Trim
        EdtFileCode = lblFileCode.Text.Trim
        EdtParameter = txtParameter.Text.Trim
        EdtRptCode = txtReportID.Text.Trim
        EdtSubCode = txtSubCode.Text.Trim
        EdtTstCode = txtTstCode.Text.Trim
        EdtDefVal = txtDef_Val.Text.Trim
        EdtFrmName = cmbFormName.Text.Trim
        EdtType = cmbType.Text.Trim
        EdtGroup = txtGroup.Text.Trim
        EdtNorVal = txtNorRange.Text.Trim
        EdtUnits = txtUnit.Text.Trim
    End Sub

    Private Sub ReportDataGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReportDataGrid.CellClick
        GetParameters()
    End Sub

    Private Sub ReportDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReportDataGrid.CellContentClick
        GetParameters()
    End Sub

    Private Sub ReportDataGrid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ReportDataGrid.CellMouseClick
        GetParameters()
    End Sub

    Private Sub ReportDataGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ReportDataGrid.CellMouseDoubleClick
        GetParameters()
    End Sub

    Private Sub ToolStripButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSearchButton.Click
        ReportFile.ShowDialog(Me)
        gblFileCode = gblReportName.Trim
        If gblFileCode = String.Empty Then
            Exit Sub
        Else
            Call Show_Parameters()
            BindingNavigatorEditItem.Enabled = True
            ToolStripButtonAddNew.Enabled = True
            ToolStripCloseButton.Text = "&Cancel"
            ToolStripNewReportButton.Enabled = False
        End If
    End Sub

    Private Sub ToolStripNewReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripNewReportButton.Click
        gblFileCode = String.Empty
        Show_Parameters()
        Me.SplitContainer1.Panel1.Enabled = True
        Me.BindingNavigatorSaveItem.Enabled = True
        Addition = False
        txtReportID.Focus()
        ToolStripCloseButton.Text = "&Cancel"
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        Update_Rpt_Format()
        ReportDataGrid.Refresh()
        ParameterBindingNavigator.Refresh()
        ParameterBindingSource.ResetCurrentItem()
        ToolStripCloseButton_Click(sender, e)
    End Sub

    Private Sub ToolStripButtonAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAddNew.Click
        Addition = True
        Editing = False
        Me.SplitContainer1.Panel1.Enabled = True
        Me.SplitContainer1.Panel2.Enabled = False
        Me.BindingNavigatorSaveItem.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        Me.ParameterBindingSource.AddNew()
        Me.lblFileCode.Text = FixedLabel
        Me.txtReportID.Text = FixedReportID
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        GetParameters()
        If MessageBox.Show("Are you sure you want to delete this parameter.", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Try
                Dim DeleteQuery As String = "delete from rpt_param where (FILECODE = '" & EdtFileCode & "' AND " & _
                                                                         "RPTCODE = '" & EdtRptCode & "' AND " & _
                                                                         "PARAMETERS = '" & EdtParameter & "' AND " & _
                                                                         "CATEGORY = '" & EdtCategory & "' AND " & _
                                                                         "TSTCODE = '" & EdtTstCode & "' AND " & _
                                                                         "SUBCODE = '" & EdtSubCode & "')"
                Execute_DatabaseTable_Query(SqlDataAdapter, DeleteQuery, Connection)
                Me.ToolStripCloseButton.Text = "&Close"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        Else
            Me.ParameterBindingSource.CancelEdit()
        End If
    End Sub
End Class