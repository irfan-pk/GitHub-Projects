Imports System.Data.SqlClient
Imports System.IO

Public Class BIOPSY
    Dim Choice, Invalid, bRet As Boolean
    Dim Row As String()
    Dim ReportCode, FileCode, FormName, TestName, eSource, eOrganism, eCount As String
    Dim Sort_No As Integer
    Dim gRows As Integer = 0
    Dim CheckQuery As String = String.Empty

    Private Sub txtPatientID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPatientID.KeyDown
        If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
            If e.KeyCode = Keys.Enter And txtPatientID.Text <> String.Empty Then
                Call GetConnectionString()
                'Check if report exist of given patient
                If CheckReport("lab_pro.dbo.rpt_biopsy") = True Then
                    MsgBox("Report already exist of this patient.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    Call RefreshReportForm()
                    Exit Sub
                End If
                'Check report belong to the patient
                Dim Check As String = String.Empty
                Check = "select * from lab_pro.dbo.receipt where tcaseno = " & Val(txtPatientID.Text.Trim) & " and (tname like '%BIOPS%')"
                Execute_DatabaseTable_Query(SqlDataAdapter, Check, Connection)
                Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Checker.HasRows Then
                    Call FindPatient(txtPatientID.Text.Trim, sender, e)
                Else
                    MsgBox("Invalid Report Selection for Patient.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    Exit Sub
                End If
                If Invalid = False Then
                    Me.txtPatientID.ReadOnly = True
                    Me.txtBiopsyNo.Focus()
                    Me.cmdCopy.Enabled = True
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
                txtBiopsyNo.Focus()
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
        Me.Close()
    End Sub

    Private Sub RefreshReportForm()
        Me.txtPatientID.Clear()
        Me.txtGender.Clear()
        Me.txtName.Clear()
        Me.txtHospital.Clear()
        Me.txtCp.Clear()
        Me.txtAge.Clear()
        Me.txtDate.Clear()
        Me.txtConsultant.Clear()
        Me.txtBiopsyNo.Clear()
        Me.txtClinicalHist.Clear()
        Me.txtMicroscope.Clear()
        Me.txtDiagnosis.Clear()
        Me.txtGross.Clear()
        Me.txtTissue.Clear()
        Me.cmdSave.Enabled = False
        Me.cmdEdit.Enabled = True
        Me.cmdPrintReport.Enabled = False
        Me.txtPatientID.Enabled = True
        Me.txtPatientID.ReadOnly = False
        Me.txtPatientID.Focus()
        Me.txtBiopsyNo.ReadOnly = False
        Me.txtClinicalHist.ReadOnly = False
        Me.txtDiagnosis.ReadOnly = False
        Me.txtMicroscope.ReadOnly = False
        Me.txtTissue.ReadOnly = False
        Me.txtGross.ReadOnly = False
        gblRptRmkCode = String.Empty
        gblRptRmkDetail = String.Empty
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call RefreshReportForm()
        txtPatientID.Focus()
    End Sub

    Private Sub BIOPSY_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtPatientID.Focus()
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
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim ParameterQuery As String = String.Empty
        Dim SaveData As String = "select * from lab_pro.dbo.rpt_biopsy where labno=" & Val(txtPatientID.Text.Trim) & " and rptcode = 'BIOPSY'"
        Execute_DatabaseTable_Query(SqlDataAdapter, SaveData, Connection)
        Dim DataReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If DataReader.HasRows Then
            ParameterQuery = "update lab_pro.dbo.rpt_biopsy set " & _
                             "LABNO = @PatientID," & _
                             "BIOPSY_ID = @BiopsyNo," & _
                             "BIOPSY_HISTORY = @ClinicalHist," & _
                             "BIOPSY_GROSS = @Gross," & _
                             "BIOPSY_MICROSCOPE = @Microscope," & _
                             "BIOPSY_TISSUE = @Tissue," & _
                             "BIOPSY_CONCLUSION = @Diagnosis," & _
                             "RPT_DATE = @NowDate," & _
                             "RPTCODE = @RptCode, FILECODE = @FileName, PSTATUS = @PStatus, NAME = @PatientName WHERE LABNO = @UpdateId and RPTCODE = @UpdateRptCode"
            Call QueryWithParameter(ParameterQuery, "UPDATE")
        Else
            ParameterQuery = "insert into lab_pro.dbo.rpt_biopsy values(" & _
                             "@PatientID," & _
                             "@BiopsyNo," & _
                             "@ClinicalHist," & _
                             "@Gross," & _
                             "@Microscope," & _
                             "@Tissue," & _
                             "@Diagnosis," & _
                             "@NowDate," & _
                             "@RptCode,@FileName,@PStatus,@PatientName)"
            QueryWithParameter(ParameterQuery, "INSERT")
        End If
        Me.cmdSave.Enabled = False
        Me.txtBiopsyNo.ReadOnly = True
        Me.txtClinicalHist.ReadOnly = True
        Me.txtDiagnosis.ReadOnly = True
        Me.txtMicroscope.ReadOnly = True
        Me.txtTissue.ReadOnly = True
        Me.txtGross.ReadOnly = True
        Me.cmdPrintReport.Enabled = True
        Me.cmdCopy.Enabled = False
    End Sub

    Private Sub cmdPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintReport.Click
        Dim CurrentPath As String = Directory.GetCurrentDirectory()
        gblPrintLabId = Val(txtPatientID.Text.Trim)
        gblPrintReportCode = "BIOPSY"
        gblPrintFileName = CurrentPath & "\Pathology\" & "BIOPSY.rpt"
        gblRptRmkDetail = String.Empty
        gblRptRmkCode = String.Empty
        'To sent report directly to printer
        gblReportQuery = "select * from lab_pro.dbo.rpt_biopsy where labno = " & Val(gblPrintLabId) & " and rptcode='" & gblPrintReportCode & "'"
        gblTableName = "rpt_biopsy"
        gblSelectFormula = "{rpt_biopsy.labno} = " & Val(gblPrintLabId)
        Try
            Call Print_Reports()
            'To view report in viewer window
            'HistopathologyReport.Show()
            Call Update_Print_Copies(gblTableName, gblPrintLabId, gblPrintReportCode)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim FindReport As String = Microsoft.VisualBasic.InputBox("Please Enter Patient ID to Find and Edit Report.", My.Application.Info.ProductName)
        If FindReport = String.Empty Then Exit Sub
        If CultureReportExist(FindReport, gblSelectRpt) = False Then
            MsgBox("Report does'nt exist, Please give correct Patient Id.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        Else
            Call FindPatient(FindReport, sender, e)
            Call Edit_Report_Data("RPT_BIOPSY", FindReport.Trim)
            Me.txtPatientID.ReadOnly = True
            Me.txtBiopsyNo.ReadOnly = False
            Me.txtClinicalHist.ReadOnly = False
            Me.txtDiagnosis.ReadOnly = False
            Me.txtMicroscope.ReadOnly = False
            Me.txtTissue.ReadOnly = False
            Me.txtGross.ReadOnly = False
            Me.cmdCopy.Enabled = True
        End If
    End Sub

    Private Sub Edit_Report_Data(ByVal TableName As String, ByVal PatiendId As String)
        Try
            Call GetConnectionString()
            CheckQuery = "Select * from lab_pro.dbo.rpt_biopsy where labno = " & Val(PatiendId.Trim) & " and rptcode = 'BIOPSY' order by labno"
            Execute_DatabaseTable_Query(SqlDataAdapter, CheckQuery, Connection)
            Dim GridData As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GridData.HasRows Then
                While GridData.Read
                    txtBiopsyNo.Text = GridData.Item("biopsy_id").ToString.Trim
                    txtClinicalHist.Text = GridData.Item("biopsy_history").ToString
                    txtGross.Text = GridData.Item("biopsy_gross").ToString
                    txtMicroscope.Text = GridData.Item("biopsy_microscope").ToString
                    txtTissue.Text = GridData.Item("biopsy_tissue").ToString
                    txtDiagnosis.Text = GridData.Item("biopsy_conclusion").ToString
                End While
            End If
            Me.txtPatientID.Enabled = False
            Me.txtPatientID.Text = PatiendId.Trim
            Me.txtPatientID.Enabled = True
            Me.txtPatientID.ReadOnly = False
            Me.txtBiopsyNo.ReadOnly = False
            Me.txtClinicalHist.ReadOnly = False
            Me.txtDiagnosis.ReadOnly = False
            Me.txtMicroscope.ReadOnly = False
            Me.txtTissue.ReadOnly = False
            Me.txtGross.ReadOnly = False
            Me.cmdSave.Enabled = True
        Catch SqlExp As SqlException
            MsgBox(SqlExp, MsgBoxStyle.Information, My.Application.Info.ProductName)
        Catch Ex As Exception
            MsgBox("Patient Report not found in table ?", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Function CheckReport(ByVal TableName As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from " & TableName & " where labno=" & Val(txtPatientID.Text.Trim) & " and rptcode = 'BIOPSY'")
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

    Private Sub txtBiopsyNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBiopsyNo.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Function CultureReportExist(ByVal PatientID As String, ByVal ReportCode As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from lab_pro.dbo.rpt_biopsy where labno=" & Val(PatientID.Trim) & " and rptcode = 'BIOPSY'")

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

    Private Sub txtDiagnosis_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiagnosis.TextChanged
        Me.cmdSave.Enabled = True
    End Sub

    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
        CopyBiopsy.ShowDialog(MainReports)
        If gblGross = String.Empty And gblMicroscope = String.Empty Then Exit Sub
        txtGross.Text = gblGross
        txtMicroscope.Text = gblMicroscope
        txtTissue.Text = gblTissue
        txtDiagnosis.Text = gblConclusion
    End Sub

    Private Sub QueryWithParameter(ByVal QueryCommand As String, ByVal Mode As String)
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = QueryCommand
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                sqlCmd.Parameters.Add(New SqlParameter("@PatientID", Val(txtPatientID.Text.Trim)))
                sqlCmd.Parameters.Add(New SqlParameter("@BiopsyNo", txtBiopsyNo.Text.Trim))
                sqlCmd.Parameters.Add(New SqlParameter("@ClinicalHist", txtClinicalHist.Text.Trim))
                sqlCmd.Parameters.Add(New SqlParameter("@Gross", txtGross.Text.Trim))
                sqlCmd.Parameters.Add(New SqlParameter("@Microscope", txtMicroscope.Text.Trim))
                sqlCmd.Parameters.Add(New SqlParameter("@Tissue", txtTissue.Text.Trim))
                sqlCmd.Parameters.Add(New SqlParameter("@Diagnosis", txtDiagnosis.Text.Trim))
                sqlCmd.Parameters.Add(New SqlParameter("@NowDate", Format(Now.Date, "MM/dd/yyyy")))
                sqlCmd.Parameters.Add(New SqlParameter("@RptCode", "BIOPSY"))
                sqlCmd.Parameters.Add(New SqlParameter("@FileName", "BIOPSY.rpt"))
                sqlCmd.Parameters.Add(New SqlParameter("@PStatus", 0))
                sqlCmd.Parameters.Add(New SqlParameter("@PatientName", txtName.Text.Trim))
                If Mode = "UPDATE" Then
                    sqlCmd.Parameters.Add(New SqlParameter("@UpdateId", Val(txtPatientID.Text.Trim)))
                    sqlCmd.Parameters.Add(New SqlParameter("@UpdateRptCode", "BIOPSY"))
                End If
                sqlCmd.ExecuteNonQuery()
                sqlConnection.Close()
                sqlConnection.Dispose()
            End Using
        End Using
    End Sub
End Class