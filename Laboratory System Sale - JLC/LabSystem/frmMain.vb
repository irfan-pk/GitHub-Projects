Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmMain

    'Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
    '    If menuMAIN.Items(2).Enabled = False Then MsgBox("Please Logon as Administrator.", MsgBoxStyle.Information, My.Application.Info.ProductName)
    'End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Application.Info.ProductName
        Me.ToolStripStatusLabel2.Text = SysOperator.Trim
        Me.ToolStripStatusLabel6.Text = UserStatus.Trim
        If LoginStatus = True Then
            Me.ToolStripStatusLabel4.Text = "Logged On"
        End If

        If gblPrliviges > 2 Then Me.MaintenanceToolStripMenuItem.Enabled = False : Me.AccountsToolStripMenuItem.Enabled = False Else Me.MaintenanceToolStripMenuItem.Enabled = True : Me.AccountsToolStripMenuItem.Enabled = True
        Call Record_Count()
        Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Connection.Dispose()
            SqlDataAdapt.Dispose()
            SqlDataSet.Dispose()
            Application.Exit()
        End Try
        'frmLogin.MdiParent = Me

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
        Connection.Dispose()
        SqlDataAdapt.Dispose()
        SqlDataSet.Dispose()
        Application.Exit()
    End Sub

    Private Sub ManageCollectionPointToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageCollectionPointToolStripMenuItem.Click
        Call Administrator_MenuForms(frmCollectionPoint)
    End Sub

    Private Sub AddEditTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditTestToolStripMenuItem.Click
        Call Administrator_MenuForms(frmTests)
    End Sub

    Private Sub AddEditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditToolStripMenuItem.Click
        Call Administrator_MenuForms(frmSysUser)
    End Sub

    Private Sub DailyCashSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCashSummaryToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmDailyStat)
    End Sub

    Private Sub PrintPatientSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPatientSlipToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmPrintSlip)
    End Sub

    Private Sub ViewDailyCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDailyCasesToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmDailyCases)
    End Sub

    Private Sub EditPatientRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditPatientRecordToolStripMenuItem.Click
        Call Administrator_MenuForms(frmEdit)
    End Sub

    Private Sub RateListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateListToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmRates)
    End Sub

    Private Sub CurrentSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentSummaryToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmCurrentStat)
    End Sub

    Private Sub NewPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPatientToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmPatient)
    End Sub

    Private Sub Administrator_MenuForms(ByVal FormName As Form)
        If menuMAIN.Items(2).Enabled = True Then
            FormName.MdiParent = Me
            If LoginStatus = True Then FormName.TopMost = True : FormName.Show() Else MsgBox("Please Log on.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        Else
            MsgBox("You are in operating mode, Please Logon as Administrator.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub Operators_Menu_Forms(ByVal FormName As Form)
        Me.Cursor = Cursors.AppStarting
        FormName.MdiParent = Me
        If LoginStatus = True Then FormName.TopMost = True : FormName.Show() Else MsgBox("Please Log on.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GeneralJournalEntriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralJournalEntriesToolStripMenuItem.Click
        Call Administrator_MenuForms(frmJournal)
    End Sub

    Private Sub GeneralJournalViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralJournalViewToolStripMenuItem.Click
        Call Administrator_MenuForms(frmViewTransactions)
    End Sub

    Private Sub LedgersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgersToolStripMenuItem.Click
        Call Administrator_MenuForms(frmLedgers)
    End Sub

    Private Sub AccountStatementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountStatementsToolStripMenuItem.Click
        'Call(Administrator_MenuForms(frmAccStatment))
        Dim currentpath As String = Directory.GetCurrentDirectory()

        If gblPrliviges > 1 Then
            MsgBox("You are not authorized to view Trial Balance", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If

        gblReportOption = "TRIAL BALANCE"
        toDate = DateTime.Parse(Now.Date.ToShortDateString)
        gblReportName = currentpath & "\" & "Reports\TRIALBALANCE.rpt"
        frmAccReports.MdiParent = Me
        frmAccReports.Show()

    End Sub

    Private Sub AddEditAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditAccountToolStripMenuItem.Click
        Call Administrator_MenuForms(frmNewAcc)
    End Sub

    Private Sub RateInquiryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateInquiryToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmRateInquiry)
    End Sub

    Private Sub PrintRateListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintRateListToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmPrintRateList)
    End Sub

    Private Sub PatientNameCorrectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientNameCorrectionToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmNameCorrection)
    End Sub

    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Connection.Dispose()
        SqlDataAdapt.Dispose()
        SqlDataSet.Dispose()
        Application.Exit()
    End Sub

    Private Sub LabInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabInformationToolStripMenuItem.Click
        Call Administrator_MenuForms(frmLabInfo)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.MdiParent = Me
        AboutBox.Show()
    End Sub

    Private Sub RecordShiftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordShiftToolStripMenuItem.Click
        Call Administrator_MenuForms(frmCopyRecord)
    End Sub

    Private Sub NewPatientPCRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPatientPCRToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmPatient_PCR)
    End Sub

    Private Sub NewSpTestPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSpTestPatientToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmPatient_ST)
    End Sub

    Private Sub ViewPCRCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPCRCasesToolStripMenuItem.Click
        Call Administrator_MenuForms(frmPCRDailyCases)
    End Sub

    Private Sub ViewSpecialCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSpecialCasesToolStripMenuItem.Click
        Call Administrator_MenuForms(frmSTDailyCases)
    End Sub

    Private Sub EditPCRRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditPCRRecordToolStripMenuItem.Click
        Call Administrator_MenuForms(frmPCREdit)
    End Sub

    Private Sub EditSpecialTestRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSpecialTestRecordToolStripMenuItem.Click
        Call Administrator_MenuForms(frmSTEdit)
    End Sub

    Private Sub PrintDailyPCRSpecialSummariesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDailyPCRSpecialSummariesToolStripMenuItem.Click
        Call Administrator_MenuForms(frmDailyStatSpc)
    End Sub

    Private Sub ManagePhilebotomistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagePhilebotomistToolStripMenuItem.Click
        Call Administrator_MenuForms(frmVisitors)
    End Sub

    Private Sub NewPatientGenExpertPCRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPatientGenExpertPCRToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmPatient_GX)
    End Sub

    Private Sub ViewGXPCRCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewGXPCRCasesToolStripMenuItem.Click
        Call Administrator_MenuForms(frmGXDailyCases)
    End Sub

    Private Sub EditGXPCRRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditGXPCRRecordToolStripMenuItem.Click
        Call Administrator_MenuForms(frmGXEdit)
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmViewOldCases)
    End Sub

    Private Sub PCRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCRToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmViewPCRCases)
    End Sub

    Private Sub SpecialCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialCasesToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmViewSTCases)
    End Sub

    Private Sub GXPCRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GXPCRToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmViewGXCases)
    End Sub

    Private Sub DatabaseBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseBackupToolStripMenuItem.Click
        Call Administrator_MenuForms(frmBackupData)
    End Sub

    Private Sub NationalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NationalToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmPatient_National)
    End Sub

    Private Sub ViewNationalCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewNationalCasesToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmNationalDailyCases)
    End Sub

    Private Sub EditNationalRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditNationalRecordToolStripMenuItem.Click
        Call Operators_Menu_Forms(frmNationalEdit)
    End Sub
End Class
