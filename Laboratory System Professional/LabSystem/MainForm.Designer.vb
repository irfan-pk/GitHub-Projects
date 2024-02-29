<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.menuMAIN = New System.Windows.Forms.MenuStrip
        Me.ReceptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SummariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DailyCashSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewDailyCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.CpCasesSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PathologyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewFiscalPeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEditAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.PettyCashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountHeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PettyJournalViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.GeneralJournalEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneralJournalViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LedgersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.AccountStatementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEditTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CpTaxDuesAdjustmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BillingOfCollectionPointsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.EditPatientRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.ManageCollectionPointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportFormatEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TestStatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LabInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintDuplicateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrinterSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MainStatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.menuMAIN.SuspendLayout()
        Me.MainStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'menuMAIN
        '
        Me.menuMAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceptionToolStripMenuItem, Me.SummariesToolStripMenuItem, Me.PathologyReportsToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.QuitToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menuMAIN.Location = New System.Drawing.Point(0, 0)
        Me.menuMAIN.Name = "menuMAIN"
        Me.menuMAIN.Size = New System.Drawing.Size(969, 24)
        Me.menuMAIN.TabIndex = 9
        Me.menuMAIN.Text = "MenuStrip1"
        '
        'ReceptionToolStripMenuItem
        '
        Me.ReceptionToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.HomeHS
        Me.ReceptionToolStripMenuItem.Name = "ReceptionToolStripMenuItem"
        Me.ReceptionToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ReceptionToolStripMenuItem.Text = "&Reception"
        '
        'SummariesToolStripMenuItem
        '
        Me.SummariesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyCashSummaryToolStripMenuItem, Me.ToolStripMenuItem4, Me.ViewDailyCasesToolStripMenuItem, Me.ToolStripMenuItem7, Me.CpCasesSummaryToolStripMenuItem})
        Me.SummariesToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_angleHS
        Me.SummariesToolStripMenuItem.Name = "SummariesToolStripMenuItem"
        Me.SummariesToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.SummariesToolStripMenuItem.Text = "&Summaries"
        '
        'DailyCashSummaryToolStripMenuItem
        '
        Me.DailyCashSummaryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_openHS
        Me.DailyCashSummaryToolStripMenuItem.Name = "DailyCashSummaryToolStripMenuItem"
        Me.DailyCashSummaryToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DailyCashSummaryToolStripMenuItem.Size = New System.Drawing.Size(388, 22)
        Me.DailyCashSummaryToolStripMenuItem.Text = "&Daily Cash / Cp Dues / Cp Payment Summary"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(385, 6)
        '
        'ViewDailyCasesToolStripMenuItem
        '
        Me.ViewDailyCasesToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS
        Me.ViewDailyCasesToolStripMenuItem.Name = "ViewDailyCasesToolStripMenuItem"
        Me.ViewDailyCasesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewDailyCasesToolStripMenuItem.Size = New System.Drawing.Size(388, 22)
        Me.ViewDailyCasesToolStripMenuItem.Text = "&View Cases Summary"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(385, 6)
        '
        'CpCasesSummaryToolStripMenuItem
        '
        Me.CpCasesSummaryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS
        Me.CpCasesSummaryToolStripMenuItem.Name = "CpCasesSummaryToolStripMenuItem"
        Me.CpCasesSummaryToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.F10), System.Windows.Forms.Keys)
        Me.CpCasesSummaryToolStripMenuItem.Size = New System.Drawing.Size(388, 22)
        Me.CpCasesSummaryToolStripMenuItem.Text = "Doctor Cases &Summary"
        '
        'PathologyReportsToolStripMenuItem
        '
        Me.PathologyReportsToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Report_64
        Me.PathologyReportsToolStripMenuItem.Name = "PathologyReportsToolStripMenuItem"
        Me.PathologyReportsToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.PathologyReportsToolStripMenuItem.Text = "Pathology Reports"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFiscalPeriodToolStripMenuItem, Me.AddEditAccountToolStripMenuItem, Me.ToolStripSeparator3, Me.PettyCashToolStripMenuItem, Me.ToolStripMenuItem8, Me.GeneralJournalEntriesToolStripMenuItem, Me.GeneralJournalViewToolStripMenuItem, Me.LedgersToolStripMenuItem, Me.ToolStripMenuItem9, Me.AccountStatementsToolStripMenuItem})
        Me.AccountsToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_openHS
        Me.AccountsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
        Me.AccountsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewFiscalPeriodToolStripMenuItem
        '
        Me.NewFiscalPeriodToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.NewDocumentHS
        Me.NewFiscalPeriodToolStripMenuItem.Name = "NewFiscalPeriodToolStripMenuItem"
        Me.NewFiscalPeriodToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.NewFiscalPeriodToolStripMenuItem.Text = "New / Close Fiscal Period"
        '
        'AddEditAccountToolStripMenuItem
        '
        Me.AddEditAccountToolStripMenuItem.Image = CType(resources.GetObject("AddEditAccountToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddEditAccountToolStripMenuItem.Name = "AddEditAccountToolStripMenuItem"
        Me.AddEditAccountToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.AddEditAccountToolStripMenuItem.Text = "Add / Edit Head Accounts"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(222, 6)
        '
        'PettyCashToolStripMenuItem
        '
        Me.PettyCashToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountHeadToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.PettyJournalViewToolStripMenuItem})
        Me.PettyCashToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS
        Me.PettyCashToolStripMenuItem.Name = "PettyCashToolStripMenuItem"
        Me.PettyCashToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.PettyCashToolStripMenuItem.Text = "Petty Cash"
        '
        'AccountHeadToolStripMenuItem
        '
        Me.AccountHeadToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_openHS
        Me.AccountHeadToolStripMenuItem.Name = "AccountHeadToolStripMenuItem"
        Me.AccountHeadToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AccountHeadToolStripMenuItem.Text = "Petty Accounts"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.book_addressHS
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RegisterToolStripMenuItem.Text = "Petty Journal"
        '
        'PettyJournalViewToolStripMenuItem
        '
        Me.PettyJournalViewToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.book_reportHS
        Me.PettyJournalViewToolStripMenuItem.Name = "PettyJournalViewToolStripMenuItem"
        Me.PettyJournalViewToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PettyJournalViewToolStripMenuItem.Text = "Petty Journal View"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(222, 6)
        '
        'GeneralJournalEntriesToolStripMenuItem
        '
        Me.GeneralJournalEntriesToolStripMenuItem.Image = CType(resources.GetObject("GeneralJournalEntriesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GeneralJournalEntriesToolStripMenuItem.Name = "GeneralJournalEntriesToolStripMenuItem"
        Me.GeneralJournalEntriesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.GeneralJournalEntriesToolStripMenuItem.Text = "General Journal Book"
        '
        'GeneralJournalViewToolStripMenuItem
        '
        Me.GeneralJournalViewToolStripMenuItem.Image = CType(resources.GetObject("GeneralJournalViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GeneralJournalViewToolStripMenuItem.Name = "GeneralJournalViewToolStripMenuItem"
        Me.GeneralJournalViewToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.GeneralJournalViewToolStripMenuItem.Text = "Review General Journal Book"
        '
        'LedgersToolStripMenuItem
        '
        Me.LedgersToolStripMenuItem.Image = CType(resources.GetObject("LedgersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LedgersToolStripMenuItem.Name = "LedgersToolStripMenuItem"
        Me.LedgersToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.LedgersToolStripMenuItem.Text = "Account Ledgers"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(222, 6)
        '
        'AccountStatementsToolStripMenuItem
        '
        Me.AccountStatementsToolStripMenuItem.Image = CType(resources.GetObject("AccountStatementsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AccountStatementsToolStripMenuItem.Name = "AccountStatementsToolStripMenuItem"
        Me.AccountStatementsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.AccountStatementsToolStripMenuItem.Text = "Account Statements"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Money_241
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.users
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.StaffToolStripMenuItem.Text = "Staff Manager"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEditToolStripMenuItem, Me.AddEditTestToolStripMenuItem, Me.CpTaxDuesAdjustmentToolStripMenuItem, Me.BillingOfCollectionPointsToolStripMenuItem, Me.ToolStripMenuItem5, Me.EditPatientRecordToolStripMenuItem, Me.ToolStripMenuItem6, Me.ManageCollectionPointToolStripMenuItem, Me.ToolStripMenuItem10, Me.DashboardToolStripMenuItem, Me.ReportFormatEditorToolStripMenuItem, Me.TestStatisticsToolStripMenuItem, Me.LabInformationToolStripMenuItem, Me.ToolStripMenuItem11, Me.ToolStripSeparator1, Me.PrintDuplicateReportToolStripMenuItem, Me.PrinterSettingsToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.SaveFormDesignHS
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'AddEditToolStripMenuItem
        '
        Me.AddEditToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.data_add
        Me.AddEditToolStripMenuItem.Name = "AddEditToolStripMenuItem"
        Me.AddEditToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.AddEditToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.AddEditToolStripMenuItem.Text = "&Add / Edit User"
        '
        'AddEditTestToolStripMenuItem
        '
        Me.AddEditTestToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.data_add
        Me.AddEditTestToolStripMenuItem.Name = "AddEditTestToolStripMenuItem"
        Me.AddEditTestToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AddEditTestToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.AddEditTestToolStripMenuItem.Text = "Add / Edit &Test"
        '
        'CpTaxDuesAdjustmentToolStripMenuItem
        '
        Me.CpTaxDuesAdjustmentToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.if_edit_find_replace2
        Me.CpTaxDuesAdjustmentToolStripMenuItem.Name = "CpTaxDuesAdjustmentToolStripMenuItem"
        Me.CpTaxDuesAdjustmentToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.CpTaxDuesAdjustmentToolStripMenuItem.Text = "Cp Tax / Dues Adjustment"
        '
        'BillingOfCollectionPointsToolStripMenuItem
        '
        Me.BillingOfCollectionPointsToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.book_addressHS
        Me.BillingOfCollectionPointsToolStripMenuItem.Name = "BillingOfCollectionPointsToolStripMenuItem"
        Me.BillingOfCollectionPointsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.BillingOfCollectionPointsToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.BillingOfCollectionPointsToolStripMenuItem.Text = "&Collection Point Billing"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(275, 6)
        '
        'EditPatientRecordToolStripMenuItem
        '
        Me.EditPatientRecordToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.data_edit
        Me.EditPatientRecordToolStripMenuItem.Name = "EditPatientRecordToolStripMenuItem"
        Me.EditPatientRecordToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditPatientRecordToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.EditPatientRecordToolStripMenuItem.Text = "&Edit Patient Record"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(275, 6)
        '
        'ManageCollectionPointToolStripMenuItem
        '
        Me.ManageCollectionPointToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS1
        Me.ManageCollectionPointToolStripMenuItem.Name = "ManageCollectionPointToolStripMenuItem"
        Me.ManageCollectionPointToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ManageCollectionPointToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ManageCollectionPointToolStripMenuItem.Text = "&Manage Collection Point"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(275, 6)
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Content_Reorder_24
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.DashboardToolStripMenuItem.Text = "Patinet Reports Dashboard"
        '
        'ReportFormatEditorToolStripMenuItem
        '
        Me.ReportFormatEditorToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Content_Reorder_64
        Me.ReportFormatEditorToolStripMenuItem.Name = "ReportFormatEditorToolStripMenuItem"
        Me.ReportFormatEditorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ReportFormatEditorToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ReportFormatEditorToolStripMenuItem.Text = "Report Format Editor"
        '
        'TestStatisticsToolStripMenuItem
        '
        Me.TestStatisticsToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.book_addressHS
        Me.TestStatisticsToolStripMenuItem.Name = "TestStatisticsToolStripMenuItem"
        Me.TestStatisticsToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.TestStatisticsToolStripMenuItem.Text = "Test Statistics"
        '
        'LabInformationToolStripMenuItem
        '
        Me.LabInformationToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.if_edit_find_replace1
        Me.LabInformationToolStripMenuItem.Name = "LabInformationToolStripMenuItem"
        Me.LabInformationToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LabInformationToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.LabInformationToolStripMenuItem.Text = "Lab Information"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Image = Global.Business_Solutions.My.Resources.Resources.Database_64
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(278, 22)
        Me.ToolStripMenuItem11.Text = "Database Backup / Restore"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(275, 6)
        '
        'PrintDuplicateReportToolStripMenuItem
        '
        Me.PrintDuplicateReportToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.PrintDuplicateReportToolStripMenuItem.Name = "PrintDuplicateReportToolStripMenuItem"
        Me.PrintDuplicateReportToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.PrintDuplicateReportToolStripMenuItem.Text = "Print / Delete / View Report"
        '
        'PrinterSettingsToolStripMenuItem
        '
        Me.PrinterSettingsToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.PrinterSettingsToolStripMenuItem.Name = "PrinterSettingsToolStripMenuItem"
        Me.PrinterSettingsToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.PrinterSettingsToolStripMenuItem.Text = "Printer Settings"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Actions_application_exit_icon
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Medical_invoice_information_64
        Me.AboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainStatusStrip
        '
        Me.MainStatusStrip.BackColor = System.Drawing.Color.LightGray
        Me.MainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6})
        Me.MainStatusStrip.Location = New System.Drawing.Point(0, 685)
        Me.MainStatusStrip.Name = "MainStatusStrip"
        Me.MainStatusStrip.Size = New System.Drawing.Size(969, 24)
        Me.MainStatusStrip.TabIndex = 10
        Me.MainStatusStrip.Text = "MainStatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(95, 19)
        Me.ToolStripStatusLabel1.Text = "System Operator"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(69, 19)
        Me.ToolStripStatusLabel2.Text = "User Name"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(39, 19)
        Me.ToolStripStatusLabel3.Text = "Status"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(65, 19)
        Me.ToolStripStatusLabel4.Text = "Logged Off"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(57, 19)
        Me.ToolStripStatusLabel5.Text = "User Type"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(40, 19)
        Me.ToolStripStatusLabel6.Text = "None"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Business_Solutions.My.Resources.Resources._71_1thermo_lab_6753_w
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(969, 709)
        Me.Controls.Add(Me.menuMAIN)
        Me.Controls.Add(Me.MainStatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuMAIN
        Me.Name = "MainForm"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuMAIN.ResumeLayout(False)
        Me.menuMAIN.PerformLayout()
        Me.MainStatusStrip.ResumeLayout(False)
        Me.MainStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents menuMAIN As System.Windows.Forms.MenuStrip
    Friend WithEvents SummariesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyCashSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewDailyCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditPatientRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ManageCollectionPointToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CpCasesSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingOfCollectionPointsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GeneralJournalEntriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralJournalViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LedgersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AccountStatementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportFormatEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PettyCashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountHeadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PathologyReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PettyJournalViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDuplicateReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CpTaxDuesAdjustmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrinterSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestStatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFiscalPeriodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
