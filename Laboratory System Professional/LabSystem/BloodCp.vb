Imports System.Data.SqlClient

Public Class BloodCp
    Dim Invalid, Edit, UnderAge As Boolean
    Dim Uage, Lage As Integer

    Private Sub txtPatientID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPatientID.KeyDown
        If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
            FindPatient(txtPatientID.Text.Trim, sender, e)
            If Invalid = False Then
                Report_Data("RPT_PARAM")
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub FindPatient(ByVal FindString As String, ByVal sender As Object, ByVal e As System.EventArgs)
        Dim patient_info As String = "select * from patient where p_num = " & Val(FindString.Trim)
        Execute_DatabaseTable_Query(SqlDataAdapter, patient_info, Connection)
        Dim patinet_reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If patinet_reader.HasRows Then
            While patinet_reader.Read
                gblSelectRpt = Select_BloodCp_Report(FindString)
                If Edit = True Then GoTo Edit_Report

                If CheckReportType(txtPatientID.Text, "HEMATOLOGY", 1) = False Then
                    MsgBox("Invalid Report Selection.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    RefreshReportForm()
                    Invalid = True
                    Exit Sub
                End If
                If CheckReportExist(txtPatientID.Text.Trim, gblSelectRpt) = True Then
                    MsgBox("Report Already Exist in Record.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
                    RefreshReportForm()
                    Invalid = True
                    Exit Sub
                End If
                If gblSelectRpt = "CPMALE" Or gblSelectRpt = "CPFEMALE" Then
                    If Mid(gblSelectRpt, 3).Trim <> patinet_reader.Item("p_sex").ToString.ToUpper Then
                        gblMessage = "Please choose valid report."
                        RefreshReportForm()
                        Invalid = True
                        Exit Sub
                    End If
                End If
Edit_Report:
                txtName.Text = patinet_reader.Item("p_name").ToString
                txtAge.Text = patinet_reader.Item("p_age").ToString
                txtGender.Text = patinet_reader.Item("p_sex").ToString
                txtCp.Text = patinet_reader.Item("p_cp").ToString
                txtConsultant.Text = patinet_reader.Item("p_ref_by").ToString
                txtHospital.Text = patinet_reader.Item("p_refer_2").ToString
                txtDate.Text = Format(Now, "dd/MMM/yyyy")
                Invalid = False
                Edit = False
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
            Dim FetchReportData As String = "select * from " & TableName & " where RPTCODE = N'" & gblSelectRpt.Trim & "' ORDER BY SORT_ORDER"
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
            Me.ReportDataGrid.ClearSelection()
            Me.cmdRemark.Enabled = True
            Me.cmdEdit.Enabled = False
            Me.txtPatientID.ReadOnly = True
            Me.ReportDataGrid.Focus()
            Me.ReportDataGrid.BeginEdit(True)
            Me.ReportDataGrid.CurrentCell = Me.ReportDataGrid(1, 0)
            gblRmkCategory = Me.ReportDataGrid.Rows(0).Cells(6).Value.ToString
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

    Private Sub cmdRemark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemark.Click
        RemarkCodeList.ShowDialog(Me)
        If Len(gblRptRmkCode.Trim) < 2 Or gblRptRmkCode = "" Then Exit Sub
        cmdRemark.BackColor = Color.LightGreen
        txtRmkDetail.Enabled = True
        txtRmkDetail.Text = gblRptRmkDetail.Trim
        txtRmkDetail.Focus()
        cmdSave.Enabled = True
    End Sub

    Private Sub ReportDataGrid_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles ReportDataGrid.EditingControlShowing
        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Me.ReportDataGrid_KeyPress
    End Sub

    Private Sub ReportDataGrid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ReportDataGrid.KeyPress
        If ("0123456789\b.".IndexOf(e.KeyChar) = -1) Then
            If e.KeyChar <> Convert.ToChar(Keys.Back) Then
                e.Handled = True
            End If
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
        Me.ReportDataGrid.EndEdit()
        Me.ReportDataGrid.Refresh()
        Me.txtRmkDetail.Clear()
        Me.txtRmkDetail.Enabled = False
        Me.cmdSave.Enabled = False
        Me.cmdEdit.Enabled = True
        Me.cmdPrintReport.Enabled = False
        Me.cmdRemark.BackColor = DefaultBackColor
        Me.cmdRemark.Enabled = False
        Me.txtPatientID.Enabled = True
        Me.txtPatientID.ReadOnly = False
        Me.txtPatientID.Focus()
        Me.ReportDataGrid.DataSource = Nothing
        UnderAge = False
        Edit = False
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        RefreshReportForm()
        txtPatientID.Focus()
    End Sub

    Private Sub BloodCp_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPatientID.Focus()
    End Sub

    Private Sub BloodCp_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F8 Then
            Dim RemarkCode As String = Microsoft.VisualBasic.InputBox("Please write code to select Remarks.", "Cp Remarks", "Give the Remark Code")
            If RemarkCode = String.Empty Then Exit Sub
            Execute_DatabaseTable_Query(SqlDataAdapter, "select * from rpt_remarks where category = 'HEMATOLOGY' and RMKCODE = '" & RemarkCode & "'", Connection)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    gblRptRmkCode = RemarkCode
                    gblRptRmkDetail = Reader.Item("description")
                    txtRmkDetail.Text = gblRptRmkDetail
                End While
            Else
                gblRptRmkCode = String.Empty
                gblRptRmkDetail = String.Empty
            End If
            If Len(gblRptRmkCode.Trim) < 1 Or gblRptRmkCode = String.Empty Then Exit Sub
            cmdRemark.BackColor = Color.LightGreen
            txtRmkDetail.Enabled = True
            txtRmkDetail.Text = gblRptRmkDetail.Trim
            txtRmkDetail.Focus()
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub BloodCp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetConnectionString()
        txtPatientID.Focus()
        Invalid = False
        Edit = False
        UnderAge = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim a As Integer = 0
        For x = 8 To 12
            a += Val(Me.ReportDataGrid.Rows(x).Cells(1).Value.ToString())
        Next
        If a <> 100 Then
            MessageBox.Show("D.L.C count is greater/less than 100%", "Count Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim i, k As Integer
        k = 0
        For i = 0 To Me.ReportDataGrid.Rows.Count - 1
            If Me.ReportDataGrid.Rows(i).Cells(1).Value.ToString() = String.Empty Then k = k + 1
        Next
        If k > 0 Then MsgBox("Please fill all result fields.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        gblRptRmkDetail = txtRmkDetail.Text.Trim.ToUpper
        FinalizeReport(Me.ReportDataGrid, Val(Me.txtPatientID.Text), txtName.Text.Trim)
        Me.cmdSave.Enabled = False
        Me.cmdPrintReport.Enabled = True
        Me.cmdRemark.BackColor = DefaultBackColor
        Me.cmdRemark.Enabled = False
    End Sub

    Private Sub cmdPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click
        gblReportOption = "HEMATOLOGY"
        gblPrintLabId = Val(txtPatientID.Text.Trim)
        'To sent report directly to printer
        gblReportQuery = "select * from rpt_result where LABNO = " & Val(gblPrintLabId) & " AND RPTCODE = '" & gblPrintReportCode & "' order by sort_order"
        gblTableName = "RPT_RESULT"
        gblSelectFormula = "{rpt_result.labno} = " & Val(gblPrintLabId)
        Try
            If gblSection <> "ADMIN" Then
                'Sent report to printer
                Print_Reports()
                Update_Print_Copies(gblTableName, gblPrintLabId, gblPrintReportCode)
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
        gblSelectRpt = Select_BloodCp_Report(FindReport)
        If CheckReportExist(FindReport, gblSelectRpt) = False Then
            MsgBox("Report does'nt exist, Please give correct Patient ID.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        Else
            Edit = True
            FindPatient(FindReport, sender, e)
            Edit_Report_Data("RPT_RESULT", FindReport.Trim)
        End If
    End Sub

    Private Sub Edit_Report_Data(ByVal TableName As String, ByVal PatiendId As String)
        Try
            Dim FetchReportData As String = "select * from " & TableName & " where LABNO = " & Val(PatiendId.Trim) & " AND RPTCODE = N'" & gblSelectRpt.Trim & "' ORDER BY SORT_ORDER"
            ExecuteSqlQuery(SqlDataAdapter, Me.ReportDataSet, FetchReportData, TableName, Connection)
            SqlDataAdapter.Fill(Me.ReportDataSet)
            Dim eReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If eReader.HasRows Then
                While eReader.Read
                    gblPrnReport = eReader.Item("FILECODE").ToString.Trim
                    gblRmkCategory = eReader.Item("category").ToString.Trim
                End While
            End If
            Me.ReportSource.DataSource = Me.ReportDataSet
            Me.ReportSource.DataMember = (TableName)
            Me.ReportDataGrid.Columns(1).DataPropertyName = "RESULT"
            Me.ReportDataGrid.DataSource = Me.ReportSource
            Me.ReportDataGrid.ClearSelection()
            Me.ReportDataGrid.BeginEdit(True)
            Me.cmdRemark.Enabled = True
            Me.cmdEdit.Enabled = False
            Me.ReportDataGrid.Focus()
            Me.ReportDataGrid.CurrentCell = Me.ReportDataGrid(1, 0)
            Me.txtPatientID.Enabled = False
            Me.txtPatientID.Text = PatiendId.Trim
            Me.cmdSave.Enabled = True
            Me.txtRmkDetail.Enabled = True
            Dim GetRemarks As String = "select * from lab_pro.dbo.rpt_result_remarks where labid=" & PatiendId.Trim & " and rptcode='" & gblSelectRpt.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapter, GetRemarks, Connection)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    txtRmkDetail.Text = Reader.Item("rmks").ToString.Trim
                    gblRptRmkCode = Reader.Item("rmkcd").ToString.Trim
                    gblRptRmkDetail = Reader.Item("rmks").ToString.Trim
                    txtRmkDetail.Enabled = True
                    If Len(txtRmkDetail.Text) > 0 Then cmdRemark.BackColor = Color.LightGreen
                End While
            End If
        Catch Ex As Exception
            MsgBox("Please check report exist in record ?", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub Report_Selection(ByVal PatientID As String)
        Dim patient_info As String = "select * from patient where p_num = " & Val(PatientID.Trim)
        Execute_DatabaseTable_Query(SqlDataAdapter, patient_info, Connection)
        Dim patinet_reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If patinet_reader.HasRows Then
            While patinet_reader.Read
                Dim CheckAge As Integer = Convert.ToInt32(Mid(patinet_reader.Item("p_age").ToString, 15, 2))
                If CheckAge >= 1 And CheckAge <= 30 Then
                    gblSelectRpt = "CPNEONATE"
                    UnderAge = True
                End If

                If CheckAge > 31 Then
                    gblSelectRpt = "CPINFANT"
                    UnderAge = True
                End If

                CheckAge = Convert.ToInt32(Mid(patinet_reader.Item("p_age").ToString, 8, 2))
                If CheckAge >= 1 And CheckAge <= 12 Then
                    gblSelectRpt = "CPINFANT"
                    UnderAge = True
                End If

                If UnderAge = True Then
                    UnderAge = False
                    Exit Sub
                End If

                'For Future
                Select Case Convert.ToInt32(Mid(patinet_reader.Item("p_age").ToString, 1, 2))
                    Case 0
                        gblSelectRpt = "CPINFANT"
                    Case 1 To 5
                        gblSelectRpt = "CP01-05"
                    Case 6 To 10
                        gblSelectRpt = "CP06-10"
                    Case 11 To 15
                        gblSelectRpt = "CP11-15"
                    Case Is >= 16
                        If patinet_reader.Item("p_sex").ToString.ToUpper = "MALE" Then gblSelectRpt = "CPMALE"
                        If patinet_reader.Item("p_sex").ToString.ToUpper = "FEMALE" Then gblSelectRpt = "CPFEMALE"
                End Select
            End While
        End If
    End Sub

    Private Sub ReportDataGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ReportDataGrid.KeyUp
        BloodCp_KeyUp(sender, e)
    End Sub

    Private Function Select_BloodCp_Report(ByVal PatientID As String) As String
        Dim ReportName As String = String.Empty
        Dim days As Integer = 0
        Dim mnth As Integer = 0
        Dim year As Integer = 0
        Dim patient_info As String = "select * from patient where p_num = " & Val(PatientID.Trim)
        Execute_DatabaseTable_Query(SqlDataAdapter, patient_info, Connection)
        Dim patinet_reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If patinet_reader.HasRows Then
            While patinet_reader.Read
                days = Convert.ToInt32(Mid(patinet_reader.Item("p_age").ToString, 15, 2))
                mnth = Convert.ToInt32(Mid(patinet_reader.Item("p_age").ToString, 8, 2))
                year = Convert.ToInt32(Mid(patinet_reader.Item("p_age").ToString, 1, 2))

                If days = 0 And mnth = 0 And year = 0 Then
                    MessageBox.Show("Invalid Age in Patient Record", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ReportName = String.Empty
                    Return ReportName
                End If

                If days >= 1 And days <= 30 And mnth = 0 And year = 0 Then _
                    ReportName = "CPNEONATE"

                If days > 31 And mnth = 0 And year = 0 Then _
                    ReportName = "CPINFANT"

                If mnth >= 1 And mnth < 12 And days >= 1 And days <= 31 Then _
                    ReportName = "CPINFANT"

                If mnth >= 1 And mnth <= 12 And days = 0 And year = 0 Then _
                    ReportName = "CPINFANT"

                If mnth > 11 And days > 0 And year = 0 Then _
                    year = 1

                'For Future
                Select Case year
                    Case 1 To 5
                        ReportName = "CP01-05"
                    Case 6 To 10
                        ReportName = "CP06-10"
                    Case 11 To 15
                        ReportName = "CP11-15"
                    Case Is >= 16
                        If patinet_reader.Item("p_sex").ToString.ToUpper = "MALE" Then ReportName = "CPMALE"
                        If patinet_reader.Item("p_sex").ToString.ToUpper = "FEMALE" Then ReportName = "CPFEMALE"
                End Select
            End While
        End If
        Return ReportName
    End Function

End Class