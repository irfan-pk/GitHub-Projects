Imports System.IO

Public Class MainForm
    Private CurrentCulture As System.Globalization.CultureInfo

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Admin - " + My.Application.Info.ProductName
        Me.ToolStripStatusLabel2.Text = SysOperator.Trim
        Me.ToolStripStatusLabel6.Text = UserStatus.Trim
        If LoginStatus = True Then
            Me.ToolStripStatusLabel4.Text = "Logged On"
        End If
        Record_Count()
        Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Connection.Dispose()
            SqlDataAdapter.Dispose()
            SqlDataSet.Dispose()
            Application.Exit()
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Connection.Dispose()
        SqlDataAdapter.Dispose()
        SqlDataSet.Dispose()
        Application.Exit()
    End Sub

    Private Sub ManageCollectionPointToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageCollectionPointToolStripMenuItem.Click
        Call Load_MyForm(Me, CollectionPoint)
    End Sub

    Private Sub AddEditTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditTestToolStripMenuItem.Click
        Call Load_MyForm(Me, Tests)
    End Sub

    Private Sub AddEditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditToolStripMenuItem.Click
        Call Load_MyForm(Me, SystemUser)
    End Sub

    Private Sub DailyCashSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCashSummaryToolStripMenuItem.Click
        Call Load_MyForm(Me, DailyStat)
    End Sub

    Private Sub PrintPatientSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, PrintSlip)
    End Sub

    Private Sub ViewDailyCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDailyCasesToolStripMenuItem.Click
        Call Load_MyForm(Me, DailyCases)
    End Sub

    Private Sub EditPatientRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditPatientRecordToolStripMenuItem.Click
        Call Load_MyForm(Me, EditPatient)
    End Sub

    Private Sub RateListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, TestsRates)
    End Sub

    Private Sub NewPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, Patient)
    End Sub

    Private Sub CpCasesSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CpCasesSummaryToolStripMenuItem.Click
        Call Load_MyForm(Me, DocCases)
    End Sub

    Private Sub GeneralJournalEntriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralJournalEntriesToolStripMenuItem.Click
        Call GetFinancialYear()
        If String.IsNullOrEmpty(FinancialYear.Trim) Then
            MessageBox.Show(Me, "Financial Period not defined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Call Load_MyForm(Me, AccountJournalBook)
    End Sub

    Private Sub GeneralJournalViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralJournalViewToolStripMenuItem.Click
        Call Load_MyForm(Me, AccountJournalView)
    End Sub

    Private Sub LedgersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgersToolStripMenuItem.Click
        Call GetFinancialYear()
        If String.IsNullOrEmpty(FinancialYear.Trim) Then
            MessageBox.Show(Me, "Financial Period not defined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Call Load_MyForm(Me, AccountLedgers)
    End Sub

    Private Sub AccountStatementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountStatementsToolStripMenuItem.Click
        Load_MyForm(Me, AccountStatment)
    End Sub

    Private Sub AddEditAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditAccountToolStripMenuItem.Click
        Call Load_MyForm(Me, AccountHeads)
    End Sub

    Private Sub RateInquiryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, RateInquiry)
    End Sub

    Private Sub PrintRateListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, PrintRateList)
    End Sub

    Private Sub PatientNameCorrectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, NameCorrection)
    End Sub

    Private Sub CrossMatchEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, CrossMatch)
    End Sub

    Private Sub LabInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabInformationToolStripMenuItem.Click
        Call Load_MyForm(Me, LabInfo)
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'frmDashBoard.Left = Me.Width - (frmDashBoard.Width + 50)
        'frmDashBoard.Top = Me.Height - (frmDashBoard.Height + 125)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Record_Count()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.MdiParent = Me
        AboutBox.Show()
    End Sub

    Private Sub DonorProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, DonorProfile)
    End Sub

    Private Sub StockToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Load_MyForm(Me, Inventory)
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        BackupData.ShowDialog()
    End Sub

    Private Sub ReportFormatEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFormatEditorToolStripMenuItem.Click
        Call Load_MyForm(Me, ReportFormat)
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_MyForm(Me, ReportsList)
    End Sub

    Private Sub BillingOfCollectionPointsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingOfCollectionPointsToolStripMenuItem.Click
        Load_MyForm(Me, CpBilling)
    End Sub

    Private Sub PathologyReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PathologyReportsToolStripMenuItem.Click
        MainReports.Show()
    End Sub

    Private Sub ManagePhilebotomistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_MyForm(Me, Visitors)
    End Sub

    Private Sub ManageCompaniesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_MyForm(Me, Companies)
    End Sub

    Private Sub AddReferenceDoctorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_MyForm(Me, DocList)
    End Sub

    Private Sub AccountHeadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountHeadToolStripMenuItem.Click
        Load_MyForm(Me, PettyAccounts)
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        Load_MyForm(Me, PettyJournal)
    End Sub

    Private Sub PettyJournalViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PettyJournalViewToolStripMenuItem.Click
        Load_MyForm(Me, PettyJournalView)
    End Sub

    Private Sub ReceptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceptionToolStripMenuItem.Click
        MainReception.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Connection.Close()
        Application.Exit()
    End Sub

    Private Sub PrintDuplicateReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDuplicateReportToolStripMenuItem.Click
        Load_MyForm(Me, PrintReport)
    End Sub

    Private Sub CpTaxDuesAdjustmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CpTaxDuesAdjustmentToolStripMenuItem.Click
        Load_MyForm(Me, TaxPercentAdj)
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardToolStripMenuItem.Click
        Load_MyForm(Me, PatientDashboard)
    End Sub

    Private Sub PrinterSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrinterSettingsToolStripMenuItem.Click
        If gblPrliviges > 1 Then MsgBox("You are not allowed to change printer settings.", MsgBoxStyle.Critical, My.Application.Info.ProductName) : Exit Sub
        Load_MyForm(Me, SystemPrinter)
    End Sub

    Private Sub TestStatisticsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestStatisticsToolStripMenuItem.Click
        Load_MyForm(Me, TestStatistics)
    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        Load_MyForm(Me, Payroll)
    End Sub

    Private Sub NewFiscalPeriodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFiscalPeriodToolStripMenuItem.Click
        Load_MyForm(Me, FiscalYearCreate)
        'Fyear_Date = Format(Date.Parse(Now.Date), "dd/MMM/yyyy")
        'If (Month(Fyear_Date) < 7) Then
        '    FinancialYear = ("FY - " & Year(Fyear_Date))
        'Else
        '    FinancialYear = ("FY - " & Year(Fyear_Date) + 1)
        'End If
        'Dim dr As DialogResult = MessageBox.Show("Do you want brought forward accounts b/l for new Fiscal Period ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If dr = System.Windows.Forms.DialogResult.Yes Then
        '    Dim Query As String = "select * from accounts"
        '    Execute_DatabaseTable_Query(SqlDataAdapter, Query, Connection)
        '    Dim Updater As SqlClient.SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        '    If Updater.HasRows Then
        '        While Updater.Read

        '        End While
        '    End If
        'End If
    End Sub
End Class
