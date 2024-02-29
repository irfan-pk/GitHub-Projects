Imports System.Data.SqlClient
Imports System.IO

Public Class Microbiology
    Dim Choice, Invalid, bRet, EditMode As Boolean
    Dim Row As String()
    Dim ReportCode, FileCode, FormName, TestName, eSource, eOrganism, eCount As String
    Dim Sort_No As Integer
    Dim gRows As Integer = 0
    Dim CheckQuery As String = String.Empty

    Private Sub txtPatientID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPatientID.KeyDown
        If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
            If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
                Call GetConnectionString()
                'Check report belong to the patient
                Dim Check As String = String.Empty
                Check = "select * from lab_pro.dbo.receipt where tcaseno = " & Val(txtPatientID.Text.Trim) & " and (tname like '%C/S%' or tname like '%CULTURE%')"
                Execute_DatabaseTable_Query(SqlDataAdapter, Check, Connection)
                Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Checker.HasRows Then
                    Call FindPatient(txtPatientID.Text.Trim, sender, e)
                Else
                    MsgBox("Invalid Report Selection for Patient.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    Exit Sub
                End If
                If Invalid = False Then
                    Call GetReportParameter()
                    Me.txtPatientID.ReadOnly = True
                    Me.txtSource.Focus()
                Else
                    Call RefreshReportForm()
                    Invalid = False
                End If
            End If
        End If
    End Sub

    Private Sub FindPatient(ByVal FindString As String, ByVal sender As Object, ByVal e As System.EventArgs)
        Dim patient_info As String = "select * from patient where p_num = " & Val(FindString.Trim)
        Execute_DatabaseTable_Query(SqlDataAdapter, patient_info, Connection)
        Dim patinet_reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If patinet_reader.HasRows Then
            While patinet_reader.Read
                txtName.Text = patinet_reader.Item("p_name").ToString
                txtAge.Text = patinet_reader.Item("p_age").ToString
                txtGender.Text = patinet_reader.Item("p_sex").ToString
                txtCp.Text = patinet_reader.Item("p_cp").ToString
                txtConsultant.Text = patinet_reader.Item("p_ref_by").ToString
                txtHospital.Text = patinet_reader.Item("p_refer_2").ToString
                txtDate.Text = Format(Now, "dd/MMM/yyyy")
                Invalid = False
                txtSource.Focus()
            End While
            If patinet_reader Is Nothing Then patinet_reader.Close()
        Else
            MsgBox("Invalid Patient ID, Please recheck.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Invalid = True
            txtPatientID.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.ReportDataSet.Dispose()
        Me.ReportSource.Dispose()
        Me.ReportDataGrid.DataSource = Nothing
        Me.Close()
    End Sub

    Private Sub ReportDataGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReportDataGrid.CellClick
        Me.ReportDataGrid.BeginEdit(True)
    End Sub

    Private Sub ReportDataGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReportDataGrid.CellEndEdit
        cmdSave.Enabled = True
    End Sub

    Private Sub ReportDataGrid_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles ReportDataGrid.EditingControlShowing
        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Me.ReportDataGrid_KeyPress
    End Sub

    Private Sub ReportDataGrid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ReportDataGrid.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "irs"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RefreshReportForm()
        Me.txtPatientID.ReadOnly = False
        Me.ReportDataSet.Clear()
        Me.ReportSource.ResetBindings(True)
        Me.ReportDataGrid.Refresh()
        Me.txtPatientID.Clear()
        Me.txtGender.Clear()
        Me.txtName.Clear()
        Me.txtHospital.Clear()
        Me.txtCp.Clear()
        Me.txtAge.Clear()
        Me.txtDate.Clear()
        Me.txtConsultant.Clear()
        Me.ReportDataGrid.EndEdit()
        Me.ReportDataGrid.Refresh()
        Me.txtSource.Clear()
        Me.txtOrganism.Clear()
        Me.txtCount.Clear()
        Me.cmdSave.Enabled = False
        Me.cmdEdit.Enabled = True
        Me.cmdPrintReport.Enabled = False
        Me.txtPatientID.Enabled = True
        Me.txtPatientID.ReadOnly = False
        Me.txtSource.ReadOnly = False
        Me.txtOrganism.ReadOnly = False
        Me.txtCount.ReadOnly = False
        Me.ReportDataGrid.ReadOnly = False
        Me.txtPatientID.Focus()
        Me.txtRmkDetail.Clear()
        Me.ReportDataGrid.DataSource = Nothing
        If Me.ReportDataGrid.DataSource Is Nothing Then
            If Me.ReportDataGrid.Rows.Count > 0 Then
                For i As Integer = Me.ReportDataGrid.Rows.Count - 1 To 0 Step -1
                    Me.ReportDataGrid.Rows.RemoveAt(i)
                Next
            End If
        End If
        gblRptRmkCode = String.Empty
        gblRptRmkDetail = String.Empty
        EditMode = False
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call RefreshReportForm()
        txtPatientID.Focus()
    End Sub

    Private Sub Microbiology_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Call ReportDataGrid_KeyUp(sender, e)
    End Sub

    Private Sub Microbiology_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        txtPatientID.Focus()
        Invalid = False
        Choice = False
        gblRptRmkCode = String.Empty
        gblRptRmkDetail = String.Empty
        Sort_No = 1
        Me.Text = gblSelectRpt & " REPORT"
        Me.txtPatientID.Focus()
        TestName = String.Empty
        EditMode = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'Check if report exist of given patient
        If EditMode = False Then
            If CheckPatientReport("lab_pro.dbo.rpt_culture") = True Then
                MsgBox("Report already exist of this patient.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                Call RefreshReportForm()
                Exit Sub
            End If
        End If
        gblRptRmkDetail = Me.txtRmkDetail.Text.ToUpper
        Call FinalizeCultureReport(Me.ReportDataGrid, Val(Me.txtPatientID.Text))
        Me.cmdSave.Enabled = False
        Me.txtSource.ReadOnly = True
        Me.txtOrganism.ReadOnly = True
        Me.txtCount.ReadOnly = True
        Me.ReportDataGrid.ReadOnly = True
        Me.cmdPrintReport.Enabled = True
    End Sub

    Private Sub cmdPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click
        Dim CurrentPath As String = Directory.GetCurrentDirectory()
        gblPrintLabId = Val(txtPatientID.Text.Trim)
        gblPrintFileName = CurrentPath & "\Pathology\" & "CULTURE.rpt"
        gblPrintReportCode = "CULTURE"
        'To sent report directly to printer
        gblReportQuery = "select * from patient where p_num = " & Val(gblPrintLabId)
        gblTableName = "patient"
        gblSelectFormula = "{patient.p_num} = " & Val(gblPrintLabId)
        Try
            If gblSection <> "ADMIN" Then
                Call Print_Reports()
                Call Update_Print_Copies("RPT_CULTURE", gblPrintLabId, gblPrintReportCode)
            Else
                'To view report in viewer window
                CultureReportViewer.Show()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub txtPatientID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatientID.KeyPress
        If ("0123456789\b".IndexOf(e.KeyChar) = -1) Then
            If e.KeyChar <> Convert.ToChar(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim FindReport As String = Microsoft.VisualBasic.InputBox("Please Enter Patient ID to Find and Edit Report.", My.Application.Info.ProductName)
        If FindReport = String.Empty Then Exit Sub
        If CultureReportExist(FindReport, gblSelectRpt) = False Then
            MsgBox("Report does'nt exist, Please give correct Patient ID.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        Else
            Call FindPatient(FindReport, sender, e)
            Call Edit_Report_Data("RPT_RESULT", FindReport.Trim)
            Me.txtSource.ReadOnly = False
            Me.txtOrganism.ReadOnly = False
            Me.txtCount.ReadOnly = False
            Me.ReportDataGrid.ReadOnly = False
            EditMode = True
        End If
    End Sub

    Private Sub Edit_Report_Data(ByVal TableName As String, ByVal PatiendId As String)
        Try
            ReportDataGrid.DataMember = Nothing
            ReportDataGrid.DataSource = Nothing
            'Get Culture Parameters into GridView
            Dim I As Integer = 0
            Dim J As Integer = 0
            Call GetConnectionString()
            Try
                Dim strCount As String = "SELECT COUNT(RPTCODE) AS ROWS_COUNT FROM RPT_CULTURE WHERE RPTCODE = N'CULTURE' AND LABNO = " & Val(PatiendId.Trim)
                Execute_DatabaseTable_Query(SqlDataAdapter, strCount, Connection)
                Dim CountRdr As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                While CountRdr.Read
                    gRows = Convert.ToInt32(CountRdr.Item("ROWS_COUNT").ToString)
                End While
                If Not CountRdr Is Nothing Then CountRdr.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                Exit Sub
            End Try
            gRows = Math.Round((gRows + 1) / 2)
            ReportDataGrid.Rows.Add(gRows)
            CheckQuery = "Select * from lab_pro.dbo.rpt_culture where rptcode = N'CULTURE' and labno = " & Val(PatiendId.Trim) & " order by SORT_ORDER"
            Execute_DatabaseTable_Query(SqlDataAdapter, CheckQuery, Connection)
            Dim GridData As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GridData.HasRows Then
                While GridData.Read
                    'Add parameters into datagrid view
                    If I < gRows Then
                        Me.ReportDataGrid.Rows(I).Cells(0).Value = GridData.Item("parameters").ToString
                        Me.ReportDataGrid.Rows(I).Cells(1).Value = GridData.Item("result").ToString
                        Me.ReportDataGrid.Rows(I).Cells(2).Value = GridData.Item("sort_order").ToString
                        I += 1
                    Else
                        Me.ReportDataGrid.Rows(J).Cells(3).Value = GridData.Item("parameters").ToString
                        Me.ReportDataGrid.Rows(J).Cells(4).Value = GridData.Item("result").ToString
                        Me.ReportDataGrid.Rows(J).Cells(5).Value = GridData.Item("sort_order").ToString
                        J += 1
                    End If
                    eSource = GridData.Item("source").ToString
                    eOrganism = GridData.Item("organism").ToString
                    eCount = GridData.Item("viacount").ToString
                End While
            End If
            Dim GetRemarks As String = "select * from lab_pro.dbo.rpt_result_remarks where labid=" & PatiendId.Trim & " and rptcode='" & gblSelectRpt.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapter, GetRemarks, Connection)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    txtRmkDetail.Text = Reader.Item("rmks").ToString.Trim
                    gblRptRmkCode = Reader.Item("rmkcd").ToString.Trim
                    gblRptRmkDetail = Reader.Item("rmks").ToString.Trim
                    txtRmkDetail.Enabled = True
                End While
            End If
            Me.txtSource.Text = eSource
            Me.txtOrganism.Text = eOrganism
            Me.txtCount.Text = eCount
            Me.cmdEdit.Enabled = False
            Me.txtSource.Focus()
            Me.txtPatientID.Enabled = False
            Me.txtPatientID.Text = PatiendId.Trim
            Me.cmdSave.Enabled = True
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub GetReportParameter()
        'Get Culture Parameters into GridView
        Dim I As Integer = 0
        Dim J As Integer = 0
        Call GetConnectionString()
        Try
            Dim strCount As String = "SELECT COUNT(RPTCODE) AS ROWS_COUNT FROM RPT_PARAM WHERE RPTCODE = N'CULTURE'"
            Execute_DatabaseTable_Query(SqlDataAdapter, strCount, Connection)
            Dim CountRdr As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            While CountRdr.Read
                gRows = Convert.ToInt32(CountRdr.Item("ROWS_COUNT").ToString) + 1
            End While
            If Not CountRdr Is Nothing Then CountRdr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
            Exit Sub
        End Try
        gRows = Math.Round((gRows + 1) / 2)
        ReportDataGrid.Rows.Add(gRows)
        CheckQuery = "Select * from lab_pro.dbo.rpt_param where rptcode = N'CULTURE' order by SORT_ORDER"
        Execute_DatabaseTable_Query(SqlDataAdapter, CheckQuery, Connection)
        Dim GridData As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GridData.HasRows Then
            While GridData.Read
                'Add parameters into datagrid view
                If I < gRows Then
                    Me.ReportDataGrid.Rows(I).Cells(0).Value = GridData.Item("parameters").ToString
                    Me.ReportDataGrid.Rows(I).Cells(1).Value = GridData.Item("def_val").ToString
                    Me.ReportDataGrid.Rows(I).Cells(2).Value = GridData.Item("sort_order").ToString
                    I += 1
                Else
                    Me.ReportDataGrid.Rows(J).Cells(3).Value = GridData.Item("parameters").ToString
                    Me.ReportDataGrid.Rows(J).Cells(4).Value = GridData.Item("def_val").ToString
                    Me.ReportDataGrid.Rows(J).Cells(5).Value = GridData.Item("sort_order").ToString
                    J += 1
                End If
            End While
            Me.cmdEdit.Enabled = False
            Me.ReportDataGrid.CurrentCell = Me.ReportDataGrid(1, 0)
            bRet = True
            Exit Sub
        Else
            bRet = False
        End If
    End Sub

    Private Function CheckPatientReport(ByVal TableName As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from " & TableName & " where labno=" & Val(txtPatientID.Text.Trim) & " and rptcode='CULTURE' and source='" & txtSource.Text.Trim & "'")

        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using
        Return bRet
    End Function

    Public Sub FinalizeCultureReport(ByRef MyGridData As DataGridView, ByVal PatientID As Integer)
        Dim CheckRecord As String = String.Empty
        Dim CheckReport As String = String.Empty
        Call GetConnectionString()
        Dim a, k As Integer
        MyGridData.EndEdit()
        'To Update Left side of DataGrid 
        MyGridData.Rows(0).Cells(0).Selected = True
        For a = 0 To MyGridData.RowCount - 1
            If MyGridData.Rows(k).Cells(3).Value <> String.Empty Then
                CheckReport = "select * from rpt_culture where LABNO = " & PatientID & " AND PARAMETERS = '" & MyGridData.Rows(a).Cells(0).Value.ToString & "' AND RPTCODE = N'CULTURE' ORDER BY SORT_ORDER"
                Execute_DatabaseTable_Query(SqlDataAdapter, CheckReport, Connection)
                Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Checker.HasRows = True Then
                    Dim UpdtQuery1 As String = "UPDATE RPT_CULTURE SET SOURCE = '" & txtSource.Text.ToUpper & "', ORGANISM = '" & txtOrganism.Text.Trim & "', VIACOUNT = '" & txtCount.Text.Trim & "', RESULT = '" & StrConv(MyGridData.Rows(a).Cells(1).Value.ToString, VbStrConv.Uppercase) & "', PSTATUS = 0, NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "' " & _
                                               "WHERE LABNO = " & PatientID & " AND PARAMETERS = '" & MyGridData.Rows(a).Cells(0).Value.ToString & "' AND RPTCODE = 'CULTURE'"
                    ExecuteSqlQuery(TransDataAdapter, SqlDataSet, UpdtQuery1, "RPT_CULTURE", Connection)
                Else
                    Dim UpdtQuery As String = "INSERT INTO RPT_CULTURE (LABNO, SOURCE, ORGANISM, VIACOUNT, PARAMETERS, RESULT, FILECODE, RPTCODE, CATEGORY, GROUP_PARAM, TSTCODE, SORT_ORDER, FORMNAME, TYPE, GCODE, RPT_DATE, PSTATUS, NAME) " & _
                                              "VALUES ('" & PatientID & "','" & txtSource.Text.Trim & "','" & txtOrganism.Text.Trim & "','" & txtCount.Text.Trim & "','" & MyGridData.Rows(a).Cells(0).Value.ToString & "','" & _
                                              StrConv(MyGridData.Rows(a).Cells(1).Value.ToString, VbStrConv.Uppercase) & "','CULTURE.rpt','CULTURE','MICROBIOLOGY','','C/S','" & MyGridData.Rows(a).Cells(2).Value.ToString & "'," & _
                                              "'MICROBIOLOGY','LOCKED','Y','" & Format(Now.Date, "MM/dd/yyyy") & "','0','" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "')"
                    Execute_DatabaseTable_Query(ReportAdapter, UpdtQuery, Connection)
                End If
            End If
        Next

        'To Update Right side of DataGrid
        MyGridData.Rows(0).Cells(0).Selected = True
        For k = 0 To MyGridData.RowCount - 1
            If MyGridData.Rows(k).Cells(3).Value <> String.Empty Then
                CheckReport = "select * from rpt_culture where LABNO = " & PatientID & " AND PARAMETERS = '" & MyGridData.Rows(k).Cells(3).Value.ToString & "' AND RPTCODE = N'CULTURE' ORDER BY SORT_ORDER"
                Execute_DatabaseTable_Query(SqlDataAdapter, CheckReport, Connection)
                Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Checker.HasRows = True Then
                    Dim UpdtQuery2 As String = "UPDATE RPT_CULTURE SET SOURCE = '" & txtSource.Text.ToUpper & "', ORGANISM = '" & txtOrganism.Text.Trim & "', VIACOUNT = '" & txtCount.Text.Trim & "', RESULT = '" & StrConv(MyGridData.Rows(k).Cells(4).Value.ToString, VbStrConv.Uppercase) & "', PSTATUS = 0, NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "' " & _
                                               "WHERE LABNO = " & PatientID & " AND PARAMETERS = '" & MyGridData.Rows(k).Cells(3).Value.ToString & "' AND RPTCODE = 'CULTURE'"
                    ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, UpdtQuery2, "RPT_CULTURE", Connection)
                Else
                    Dim UpdtQuery As String = "INSERT INTO RPT_CULTURE (LABNO, SOURCE, ORGANISM, VIACOUNT, PARAMETERS, RESULT, FILECODE, RPTCODE, CATEGORY, GROUP_PARAM, TSTCODE, SORT_ORDER, FORMNAME, TYPE, GCODE, RPT_DATE, PSTATUS, NAME) " & _
                                              "VALUES ('" & PatientID & "','" & txtSource.Text.Trim & "','" & txtOrganism.Text.Trim & "'," & Val(txtCount.Text.Trim) & ",'" & MyGridData.Rows(k).Cells(3).Value.ToString & "','" & _
                                              StrConv(MyGridData.Rows(k).Cells(4).Value.ToString, VbStrConv.Uppercase) & "','CULTURE.rpt','CULTURE','MICROBIOLOGY','','C/S','" & MyGridData.Rows(k).Cells(5).Value.ToString & "'," & _
                                              "'MICROBIOLOGY','LOCKED','Y','" & Format(Now.Date, "MM/dd/yyyy") & "','0','" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "')"

                    Execute_DatabaseTable_Query(ReportAdapter, UpdtQuery, Connection)
                End If
            End If
        Next
        'For Report Remarks
        If Len(gblRptRmkDetail) = 0 Then
            Dim DelRemarks As String = "delete from rpt_result_remarks WHERE (LABID = " & PatientID & " AND RPTCODE = 'CULTURE')"
            ProcessTransaction(DelRemarks)
        End If
        If Len(gblRptRmkDetail) > 0 Then
            CheckRecord = "select * from rpt_result_remarks where (labid = " & PatientID & ") and (rptcode = 'CULTURE')"
            Execute_DatabaseTable_Query(SqlDataAdapter, CheckRecord, Connection)
            Dim MyReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If MyReader.HasRows = True Then
                Dim AddRemarks As String = "update rpt_result_remarks set LABID = " & PatientID & ", RPTCODE = 'CULTURE', RMKCD = '" & gblRptRmkCode & "', RMKS = '" & gblRptRmkDetail & "', CATEGORY = '" & gblRmkCategory & "' WHERE (LABID = " & PatientID & " AND RPTCODE = '" & MyGridData.Rows(0).Cells(5).Value.ToString & "')"
                ProcessTransaction(AddRemarks)
            Else
                Dim AddRemarks As String = "insert into rpt_result_remarks values(" & PatientID & ",'CULTURE','" & gblRptRmkCode & "','" & gblRptRmkDetail & "','MICROBIOLOGY'"
                ProcessTransaction(AddRemarks)
            End If
        End If
        'For Report Viewer
        Dim CurrentPath As String = Directory.GetCurrentDirectory()
        gblPrintLabId = PatientID
        gblPrintFileName = CurrentPath & "\Pathology\" & "CULTURE.rpt"
        gblPrintReportCode = "CULTURE"
        gblRptRmkDetail = String.Empty
        gblRptRmkCode = String.Empty
    End Sub

    Private Sub txtSource_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSource.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtOrganism_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrganism.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCount.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Function CultureReportExist(ByVal PatientID As String, ByVal ReportCode As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from lab_pro.dbo.rpt_culture where labno=" & Val(PatientID.Trim) & " and rptcode='" & (ReportCode.Trim) + "'")

        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using
        Return bRet
    End Function

    Private Sub ReportDataGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ReportDataGrid.KeyUp
        If e.KeyCode = Keys.F8 Then
            If Len(gblRptRmkCode) = 0 Then
                gblRptRmkCode = "CHKD"
                gblRptRmkDetail = "The above results are rechecked."
                txtRmkDetail.Text = gblRptRmkDetail
                txtRmkDetail.Enabled = True
                txtRmkDetail.Focus()
                cmdSave.Enabled = True
            Else
                gblRptRmkCode = String.Empty
                gblRptRmkDetail = String.Empty
                txtRmkDetail.Clear()
            End If
        End If
    End Sub
End Class