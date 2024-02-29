Imports System.Data.SqlClient
Imports System.IO

Public Class NoGrowth
    Dim Choice, Invalid, bRet, EditMode As Boolean
    Dim Row As String()
    Dim ReportCode, FileCode, FormName, TestName, eSource, eOrganism, eCount As String
    Dim Sort_No As Integer
    Dim gRows As Integer = 0
    Dim CheckQuery As String = String.Empty
    Dim CurrentPath As String = Directory.GetCurrentDirectory()

    Private Sub txtPatientID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPatientID.KeyDown
        If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
            If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
                Call GetConnectionString()
                'Check if report exist of given patient
                'If CheckPatientReport("lab_pro.dbo.rpt_nogrowth") = True Then
                '    MsgBox("Report already exist of this patient.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                '    Call RefreshReportForm()
                '    Exit Sub
                'End If
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
                    Me.txtSource.Focus()
                    Me.txtPatientID.ReadOnly = True
                    Me.cmdEdit.Enabled = False
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
                Me.cmdResult.Enabled = True
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
        Me.Close()
    End Sub

    Private Sub RefreshReportForm()
        Me.txtPatientID.ReadOnly = False
        Me.txtSource.ReadOnly = False
        Me.txtResult.ReadOnly = False
        Me.ReportDataSet.Clear()
        Me.ReportSource.ResetBindings(True)
        Me.txtPatientID.Clear()
        Me.txtGender.Clear()
        Me.txtName.Clear()
        Me.txtHospital.Clear()
        Me.txtCp.Clear()
        Me.txtAge.Clear()
        Me.txtDate.Clear()
        Me.txtConsultant.Clear()
        Me.txtSource.Clear()
        Me.txtResult.Clear()
        Me.cmdResult.Enabled = False
        Me.cmdSave.Enabled = False
        Me.cmdEdit.Enabled = True
        Me.cmdPrintReport.Enabled = False
        Me.txtPatientID.Enabled = True
        Me.txtPatientID.ReadOnly = False
        Me.txtPatientID.Focus()
        gblRptRmkCode = String.Empty
        gblRptRmkDetail = String.Empty
        EditMode = False
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call RefreshReportForm()
        txtPatientID.Focus()
    End Sub

    Private Sub NoGrowth_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            If CheckPatientReport("lab_pro.dbo.rpt_nogrowth") = True Then
                MsgBox("Report already exist of this patient.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                Call RefreshReportForm()
                Exit Sub
            End If
        End If

        Dim strQuery As String = String.Empty
        If CheckPatientReport("rpt_nogrowth") = False Then
            strQuery = "insert into lab_pro.dbo.rpt_nogrowth (LABNO, SOURCE, RESULT, FILECODE, RPTCODE, CATEGORY, TSTCODE, FORMNAME, RPT_DATE, PSTATUS, NAME) " & _
                                     "values (" & Val(txtPatientID.Text.Trim) & ",'" & txtSource.Text.Trim & "','" & txtResult.Text.Trim & "','NOGROWTH.rpt','CULTURE','MICROBIOLOGY','C/S','MICROBIOLOGY','" & Format(Now.Date, "MM/dd/yyyy") & "',0,'" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "')"
        Else
            strQuery = "update lab_pro.dbo.rpt_nogrowth set SOURCE = '" & txtSource.Text.Trim & "', RESULT = '" & txtResult.Text.Trim & "', PSTATUS = 0, NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "' where labno = " & Val(txtPatientID.Text.Trim)
        End If
        Execute_DatabaseTable_Query(SqlDataAdapter, strQuery, Connection)
        Me.cmdSave.Enabled = False
        Me.cmdResult.Enabled = False
        Me.txtSource.ReadOnly = True
        Me.txtResult.ReadOnly = True
        Me.cmdPrintReport.Enabled = True
    End Sub

    Private Sub cmdPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click
        gblPrintLabId = Val(txtPatientID.Text.Trim)
        gblPrintFileName = CurrentPath & "\Pathology\" & "NOGROWTH.rpt"
        gblPrintReportCode = "CULTURE"
        'To sent report directly to printer
        gblReportQuery = "select * from patient where p_num = " & Val(gblPrintLabId)
        gblTableName = "patient"
        gblSelectFormula = "{patient.p_num} = " & Val(gblPrintLabId)
        Try
            Call Print_Reports()
            'To view report in viewer window
            'CultureReportViewer.Show()
            Call Update_Print_Copies("RPT_NOGROWTH", gblPrintLabId, gblPrintReportCode)
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
            Me.cmdResult.Enabled = True
            Me.txtSource.ReadOnly = False
            Me.txtResult.ReadOnly = False
            EditMode = True
        End If
    End Sub

    Private Sub Edit_Report_Data(ByVal TableName As String, ByVal PatiendId As String)
        Dim FindReport As String = "select * from lab_pro.dbo.rpt_nogrowth where labno = " & Val(PatiendId.Trim) & " and rptcode = N'CULTURE'"
        Execute_DatabaseTable_Query(SqlDataAdapter, FindReport, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                txtPatientID.Text = Reader.Item("labno").ToString.Trim
                txtSource.Text = Reader.Item("source").ToString.Trim
                txtResult.Text = Reader.Item("result").ToString.Trim
            End While
            cmdSave.Enabled = True
            cmdEdit.Enabled = False
            txtSource.Focus()
        End If
    End Sub

    Private Function CheckPatientReport(ByVal TableName As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from " & TableName & " where labno=" & Val(txtPatientID.Text.Trim) & " and rptcode='CULTURE' and source ='" & txtSource.Text.Trim & "'")

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

    Private Function CultureReportExist(ByVal PatientID As String, ByVal ReportCode As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from lab_pro.dbo.rpt_nogrowth where labno=" & Val(PatientID.Trim) & " and rptcode='" & (ReportCode.Trim) + "'")

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

    Private Sub cmdResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResult.Click
        gblRmkCategory = "MICROBIOLOGY"
        RemarkCodeList.ShowDialog(Me)
        If Len(gblRptRmkDetail) = 0 Then Exit Sub
        Me.txtResult.Text = gblRptRmkDetail.Trim
        Me.txtResult.Focus()
        Me.cmdSave.Enabled = True
    End Sub
End Class