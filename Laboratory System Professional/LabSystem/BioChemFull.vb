Imports System.Data.SqlClient
Imports System.Data
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class BioChemFull
    Dim Choice, Invalid, bRet, SkipCheck As Boolean
    Dim Row As String()
    Dim ReportCode, FileCode, FormName, TestName As String
    Dim i, Sort_No As Integer

    Private Sub txtPatientID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPatientID.KeyDown
        If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
            If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
                GetConnectionString()
                'Check if report exist of given patient
                If CheckReportExist(txtPatientID.Text, gblSelectRpt) = True Then
                    MsgBox("Report already exist for this patient.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    RefreshReportForm()
                    Exit Sub
                End If
                'Select TstCode and Subcode from report parameters
                Dim SelectReport As String = "select * from lab_pro.dbo.rpt_param where rptcode = N'" & gblSelectRpt & "' order by sort_order"
                Execute_DatabaseTable_Query(SqlDataAdapter, SelectReport, Connection)
                Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Reader.HasRows Then
                    While Reader.Read
                        gblRptTstCode = Reader.Item("tstcode").ToString.Trim
                        gblRptSubCode = Reader.Item("subcode").ToString.Trim
                        gblPrnReport = Reader.Item("filecode").ToString.Trim
                        gblCategory = Reader.Item("category").ToString.Trim
                        CheckReportRelation(sender, e)
                        If SkipCheck = True Then Exit While
                    End While
                Else
                    MsgBox("Invalid report selected, plz check report.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    RefreshReportForm()
                    Exit Sub
                End If
               
                If Invalid = False Then
                    GetPatientReport()
                    ReportDataGrid.Focus()
                    If ReportDataGrid.Rows.Count > 0 Then Me.ReportDataGrid.CurrentCell = Me.ReportDataGrid(1, 0) Else MsgBox("Invalid Report.", MsgBoxStyle.Information, My.Application.Info.ProductName) : RefreshReportForm()
                Else
                    MsgBox("Invalid Report.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    RefreshReportForm()
                    Invalid = False
                End If
            End If
        End If
    End Sub

    Private Sub CheckReportRelation(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Check report belong to the patient
        SkipCheck = False
        Dim Check As String = String.Empty
        If gblSelectRpt = "FLUID" Or gblSelectRpt = "fluid" Then
            gblRptTstCode = "FLUID" : gblRptSubCode = "FLUID"
            Check = "select * from receipt where tcaseno = " & Val(txtPatientID.Text.Trim) & " and (tcatg like '%" & gblCategory & "')"
        Else
            Check = "select * from receipt where tcaseno = " & Val(txtPatientID.Text.Trim) & " and tcatg like '%" & gblCategory & _
                    "%' and (tcode = '" & gblRptTstCode & "' or tcode = '" & gblRptSubCode & "')"
        End If
        Execute_DatabaseTable_Query(SqlDataAdapter, Check, Connection)
        Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Checker.HasRows Then
            FindPatient(txtPatientID.Text.Trim, sender, e)
            SkipCheck = True
            'Else
            '    MsgBox("Invalid Report.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            '    Exit Sub
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
            End While
            If patinet_reader Is Nothing Then patinet_reader.Close()
        Else
            MsgBox("Invalid Patient ID, Please recheck.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Invalid = True
            RefreshReportForm()
            txtPatientID.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Report_Data(ByVal TableName As String)
        Try
            Dim FetchReportData As String = "select * from " & TableName & " where TSTCODE = N'" & gblRptTstCode.Trim & "' AND RPTCODE = '" & gblSelectRpt & "' ORDER BY SORT_ORDER"
            ExecuteSqlQuery(SqlDataAdapter, Me.ReportDataSet, FetchReportData, TableName, Connection)
            SqlDataAdapter.Fill(Me.ReportDataSet)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    gblPrnReport = Reader.Item("FILECODE").ToString.Trim
                End While
            End If
            Me.ReportSource.DataSource = Me.ReportDataSet
            Me.ReportSource.DataMember = (TableName)
            Me.ReportDataGrid.DataSource = Me.ReportSource
            Me.ReportDataGrid.CurrentCell = Me.ReportDataGrid(1, ReportDataGrid.CurrentRow.Index)
            Me.txtPatientID.ReadOnly = True
        Catch Ex As Exception
            MsgBox("Please check report format exist in database ?", MsgBoxStyle.Information, My.Application.Info.ProductName)
            RefreshReportForm()
        End Try
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
        With ReportDataGrid
            If TestName.IndexOf("CLEARANCE") > -1 Then
                If ReportDataGrid.Rows(.CurrentRow.Index).Cells(0).Value.ToString.Trim = "URINE CREATININE" Then
                    Dim ClearanceValue As Double = 0
                    If .RowCount > 2 Then
                        ClearanceValue = (Val(.Rows(.CurrentRow.Index - 2).Cells(1).Value.ToString) * Val(.Rows(.CurrentRow.Index - 1).Cells(1).Value.ToString) / Val(.Rows(.CurrentRow.Index).Cells(1).Value.ToString)) / 1440
                        .Rows(.CurrentRow.Index + 1).Cells(1).Value = Format(ClearanceValue, "0.000")
                    End If
                End If
            End If
            If TestName.IndexOf("THROMBIN") > -1 Then
                If .RowCount > 4 Then
                    If ReportDataGrid.Rows(.CurrentRow.Index).Cells(0).Value.ToString = "PATIENT" Then
                        .Rows(.CurrentRow.Index + 2).Cells(1).Value = Format(Val(.Rows(.CurrentRow.Index).Cells(1).Value.ToString) / Val(.Rows(.CurrentRow.Index + 1).Cells(1).Value.ToString), "0.00")
                        .Rows(.CurrentRow.Index + 3).Cells(1).Value = Format(Val(.Rows(.CurrentRow.Index + 2).Cells(1).Value.ToString) * 1.13, "0.00")
                        .Rows(.CurrentRow.Index + 4).Cells(1).Value = Format(Val(.Rows(.CurrentRow.Index + 1).Cells(1).Value.ToString) / Val(.Rows(.CurrentRow.Index).Cells(1).Value.ToString) * 100, "00")
                    End If
                End If
            End If
            If ReportDataGrid.Rows(.CurrentRow.Index).Cells(0).Value.IndexOf("ALBUMIN") > -1 Then
                If .RowCount > 3 Then
                    .Rows(.CurrentRow.Index + 1).Cells(1).Value = Format(Val(.Rows(.CurrentRow.Index - 1).Cells(1).Value.ToString) - Val(.Rows(.CurrentRow.Index).Cells(1).Value.ToString), "0.0")
                    .Rows(.CurrentRow.Index + 2).Cells(1).Value = Format(Val(.Rows(.CurrentRow.Index).Cells(1).Value.ToString) / Val(.Rows(.CurrentRow.Index + 1).Cells(1).Value.ToString), "0.0") & ":1"
                End If
            End If
            If ReportDataGrid.Rows(.CurrentRow.Index).Cells(0).Value.IndexOf("BILIRUBIN DIRECT") > -1 Or ReportDataGrid.Rows(.CurrentRow.Index).Cells(0).Value.IndexOf("DIRECT BILIRUBIN") > -1 Then
                If .RowCount > 2 Then
                    .Rows(.CurrentRow.Index + 1).Cells(1).Value = Format(Val(.Rows(.CurrentRow.Index - 1).Cells(1).Value.ToString) - Val(.Rows(.CurrentRow.Index).Cells(1).Value.ToString), "0.0")
                End If
            End If
        End With
        cmdSave.Enabled = True
    End Sub

    Private Sub ReportDataGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ReportDataGrid.CellMouseDoubleClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure to delete test parameter (" & ReportDataGrid.Rows(ReportDataGrid.CurrentRow.Index).Cells(0).Value.ToString & ")", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, My.Application.Info.ProductName) = MsgBoxResult.Yes Then
                ReportDataGrid.Rows.RemoveAt(e.RowIndex)
                ReportDataGrid.Refresh()
                cmdOtherTests.Enabled = True
            End If
        End If

        If e.ColumnIndex = 2 Then
            Dim OptionalUnit As String = String.Empty
            OptionalUnit = Microsoft.VisualBasic.InputBox("Write down to change Unit", My.Application.Info.ProductName, "")
            If OptionalUnit = String.Empty Then Exit Sub
            ReportDataGrid.Rows(ReportDataGrid.CurrentRow.Index).Cells(2).Value = StrConv(OptionalUnit.Trim, VbStrConv.Lowercase)
        End If

    End Sub

    Private Sub ReportDataGrid_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles ReportDataGrid.EditingControlShowing
        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Me.ReportDataGrid_KeyPress
    End Sub

    Private Sub ReportDataGrid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ReportDataGrid.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = "." Or e.KeyChar = ":" Or e.KeyChar = "-" Or e.KeyChar = "+" Or e.KeyChar = ">" Or e.KeyChar = "<" Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub RefreshReportForm()
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
        Me.txtRmkDetail.Clear()
        Me.ReportDataGrid.EndEdit()
        Me.ReportDataGrid.Refresh()
        Me.cmdSave.Enabled = False
        Me.cmdEdit.Enabled = True
        Me.cmdPrintReport.Enabled = False
        Me.cmdOtherTests.BackColor = DefaultBackColor
        Me.cmdOtherTests.Enabled = False
        Me.txtPatientID.Enabled = True
        Me.txtPatientID.ReadOnly = False
        Me.txtPatientID.Focus()
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
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        RefreshReportForm()
        txtPatientID.Focus()
    End Sub

    Private Sub BioChemFull_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPatientID.Focus()
    End Sub

    Private Sub BioChemFull_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        ReportDataGrid_KeyUp(sender, e)
        If e.KeyCode = Keys.F9 Then
            gblRmkCategory = "BIOCHEMISTRY"
            RemarkCodeList.ShowDialog()
            txtRmkDetail.Text = txtRmkDetail.Text & gblRptRmkDetail
        End If
    End Sub

    Private Sub BioChemFull_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetConnectionString()
        txtPatientID.Focus()
        Invalid = False
        Choice = False
        gblRptRmkCode = String.Empty
        gblRptRmkDetail = String.Empty
        i = 0
        Sort_No = 1
        Me.Text = gblSelectRpt & " REPORT"
        Me.txtPatientID.Focus()
        TestName = String.Empty
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i, k As Integer
        k = 0
        For i = 0 To Me.ReportDataGrid.Rows.Count - 1
            If Me.ReportDataGrid.Rows(i).Cells(1).Value.ToString() = String.Empty Then k = k + 1
        Next
        If k > 0 Then MsgBox("Please fill all result fields.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        gblRptRmkDetail = Me.txtRmkDetail.Text.ToUpper
        FinalizeReport(Me.ReportDataGrid, Val(Me.txtPatientID.Text), txtName.Text.Trim)
        Me.cmdSave.Enabled = False
        Me.cmdPrintReport.Enabled = True
        Me.cmdOtherTests.BackColor = DefaultBackColor
        Me.cmdOtherTests.Enabled = False
    End Sub

    Private Sub cmdPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click
        gblReportOption = "BIOCHEMISTRY"
        gblPrintLabId = Val(txtPatientID.Text.Trim)
        'To sent report directly to printer
        gblReportQuery = "select * from rpt_result where LABNO = " & Val(gblPrintLabId) & " AND RPTCODE = '" & gblPrintReportCode & "' order by sort_order"
        gblTableName = "RPT_RESULT"
        gblSelectFormula = "{rpt_result.labno} = " & Val(gblPrintLabId)
        Try
            If gblSection <> "ADMIN" Then
                Call Print_Reports()
                Call Update_Print_Copies(gblTableName, gblPrintLabId, gblPrintReportCode)
            Else
                'To view report in viewer window
                ReportPreviewForm.Show()
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
        If CheckReportExist(FindReport, gblSelectRpt) = False Then
            MsgBox("Report does'nt exist, Please give correct Patient ID.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        Else
            FindPatient(FindReport, sender, e)
            Edit_Report_Data("RPT_RESULT", FindReport.Trim)
        End If
    End Sub

    Private Sub Edit_Report_Data(ByVal TableName As String, ByVal PatiendId As String)
        Try
            ReportDataGrid.DataMember = Nothing
            ReportDataGrid.DataSource = Nothing
            'Select data from report parameters for datagridview
            Dim FetchReportData As String = "select * from " & TableName & " where LABNO = " & Val(PatiendId.Trim) & " AND RPTCODE = N'" & gblSelectRpt.Trim & "' ORDER BY SORT_ORDER"
            Execute_DatabaseTable_Query(SqlDataAdapter, FetchReportData, Connection)
            Dim GridData As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GridData.HasRows Then
                While GridData.Read
                    'Add row with data in the datagrid
                    Row = New String() {GridData.Item("parameters").ToString, GridData.Item("result").ToString, GridData.Item("units").ToString, _
                                        GridData.Item("norm_Val").ToString, GridData.Item("filecode").ToString, GridData.Item("rptcode").ToString, _
                                        GridData.Item("category").ToString, GridData.Item("group_param").ToString, GridData.Item("tstcode").ToString, _
                                        GridData.Item("subcode").ToString, GridData.Item("sort_order").ToString, GridData.Item("formname").ToString, _
                                        GridData.Item("type").ToString}
                    ReportDataGrid.Rows.Add(Row)
                    ReportCode = GridData.Item("rptcode").ToString
                    FileCode = GridData.Item("filecode").ToString
                    gblPrnReport = GridData.Item("filecode").ToString
                    FormName = GridData.Item("formname").ToString
                    Sort_No = GridData.Item("sort_order").ToString
                End While
            End If
            TestName = ReportCode
            Me.ReportDataGrid.ClearSelection()
            Me.cmdEdit.Enabled = False
            Me.ReportDataGrid.CurrentCell = Me.ReportDataGrid(1, 0)
            Me.txtPatientID.Enabled = False
            Me.txtPatientID.Text = PatiendId.Trim
            Me.cmdSave.Enabled = True
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
            If Len(gblRptRmkCode) > 0 Then
                cbRemarks.Checked = True
            End If
        Catch SqlExp As SqlException
            MsgBox(SqlExp, MsgBoxStyle.Information, My.Application.Info.ProductName)
        Catch Ex As Exception
            MsgBox("Patient Report not found in table ?", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdOtherTests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOtherTests.Click
        ReportCodeList.ShowDialog(Me)
        If gblTestCode = String.Empty Then Exit Sub
        'Check parameter if already in DataGrid
        Dim i As Integer
        For i = 0 To Me.ReportDataGrid.Rows.Count - 1
            If Me.ReportDataGrid.Rows(i).Cells(8).Value.ToString = gblTestCode Or _
               Me.ReportDataGrid.Rows(i).Cells(9).Value.ToString = gblTestCode Then
                MsgBox("Parameter already enlisted.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                Exit Sub
            End If
        Next
        'Check test parameter before add in row
        Dim TestExist As String = "select * from lab_pro.dbo.receipt where tcaseno=" & Val(txtPatientID.Text.Trim) & " and tcode='" & gblTestCode.Trim & "'"
        Execute_DatabaseTable_Query(SqlDataAdapter, TestExist, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            'Add test parameter in datagrid row
            Dim FillRows As String = "select * from lab_pro.dbo.rpt_param where subcode = '" & gblTestCode.Trim & "' order by sort_order"
            Execute_DatabaseTable_Query(SqlDataAdapter, FillRows, Connection)
            Dim GridData As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GridData.HasRows Then
                ReportDataGrid.DataSource = Nothing
                While GridData.Read
                    'Add row with data in the datagrid
                    Row = New String() {GridData.Item("parameters").ToString, GridData.Item("def_val").ToString, GridData.Item("units").ToString, _
                                    GridData.Item("norm_Val").ToString, FileCode, ReportCode, _
                                    GridData.Item("category").ToString, GridData.Item("group_parm").ToString, GridData.Item("tstcode").ToString, _
                                    GridData.Item("subcode").ToString, GridData.Item("sort_order").ToString, FormName, _
                                    GridData.Item("type").ToString}
                    ReportDataGrid.Rows.Add(Row)
                End While
                Choice = True
            End If
        Else
            MsgBox("This test is not belong to patient.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub ReportDataGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ReportDataGrid.KeyUp
        If e.KeyCode = Keys.F8 Then
            If Len(gblRptRmkCode) = 0 Then
                gblRptRmkCode = "CHKD"
                gblRptRmkDetail = "The above results are rechecked."
                txtRmkDetail.Text = gblRptRmkDetail
                txtRmkDetail.Enabled = True
                txtRmkDetail.Focus()
                cmdSave.Enabled = True
                cbRemarks.Checked = True
            Else
                cbRemarks.Checked = False
                gblRptRmkCode = String.Empty
                gblRptRmkDetail = String.Empty
                txtRmkDetail.Clear()
            End If
        End If
    End Sub

    Private Sub GetPatientReport()
        'Check whether report belong to patient before next step
        Dim CheckQuery As String = String.Empty
        If gblSelectRpt = "FLUID" Or gblSelectRpt = "fluid" Then
            gblRptTstCode = "FLUID"
            CheckQuery = "Select * from lab_pro.dbo.receipt where tcaseno = " & Val(txtPatientID.Text.Trim)
        Else
            CheckQuery = "Select * from lab_pro.dbo.receipt where tcaseno = " & Val(txtPatientID.Text.Trim) & " and (tcode ='" & gblRptTstCode & "')"
        End If
        Execute_DatabaseTable_Query(SqlDataAdapter, CheckQuery, Connection)
        Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Checker.HasRows Then
            While Checker.Read
                TestName = Checker.Item("tname").ToString.Trim
            End While
            gblRptTstCode = gblRptTstCode
            Report_Data("RPT_PARAM")
            Me.cmdEdit.Enabled = False
            Me.ReportDataGrid.CurrentCell = Me.ReportDataGrid(1, ReportDataGrid.CurrentRow.Index)
            bRet = True
            Exit Sub
        Else
            bRet = False
        End If
        If bRet = False Then
            ReportDataGrid.DataSource = Nothing
            AutoAddParameter()
            Me.cmdEdit.Enabled = False
            Me.ReportDataGrid.CurrentCell = Me.ReportDataGrid(1, 0)
            bRet = True
        End If
    End Sub

    Private Sub AutoAddParameter()
        Dim TestExist As String = "select * from lab_pro.dbo.receipt where tcaseno=" & Val(txtPatientID.Text.Trim) & " and tcatg like '%" & gblCategory & "%'"
        Execute_DatabaseTable_Query(TransDataAdapter, TestExist, Connection)
        Dim ParamReader As SqlDataReader = TransDataAdapter.SelectCommand.ExecuteReader
        If ParamReader.HasRows = True Then
            While ParamReader.Read
                'Add test parameter in datagrid row
                Dim FillRow As String = "select * from lab_pro.dbo.rpt_param where subcode = '" & ParamReader.Item("tcode").ToString & "' and rptcode = N'" & gblSelectRpt & "' order by sort_order"
                Execute_DatabaseTable_Query(EntryDataAdapter, FillRow, Connection)
                Dim GridData As SqlDataReader = EntryDataAdapter.SelectCommand.ExecuteReader
                If GridData.HasRows Then
                    While GridData.Read
                        'Check parameter if already in DataGrid
                        If Me.ReportDataGrid.Rows.Count > 0 Then
                            Dim i As Integer
                            For i = 0 To Me.ReportDataGrid.Rows.Count - 1
                                If Me.ReportDataGrid.Rows(i).Cells(0).Value.ToString.Trim = GridData.Item("parameters").ToString.Trim Then
                                    'Skip
                                    GoTo Skip_Parameter
                                End If
                            Next
                        End If
                        'Add row with data in the datagrid
                        Sort_No += 1
                        Row = New String() {GridData.Item("parameters").ToString, GridData.Item("def_val").ToString, GridData.Item("units").ToString, _
                                            GridData.Item("norm_Val").ToString, GridData.Item("filecode").ToString, GridData.Item("rptcode").ToString, _
                                            GridData.Item("category").ToString, GridData.Item("group_parm").ToString, GridData.Item("tstcode").ToString, _
                                            GridData.Item("subcode").ToString, GridData.Item("sort_order").ToString, GridData.Item("formname").ToString, _
                                            GridData.Item("type").ToString}
                        ReportDataGrid.Rows.Add(Row)
                        gblPrnReport = GridData.Item("FILECODE").ToString.Trim
Skip_Parameter:
                    End While
                    Choice = True
                End If
            End While
        End If
    End Sub
End Class