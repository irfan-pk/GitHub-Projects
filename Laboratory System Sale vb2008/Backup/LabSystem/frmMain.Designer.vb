<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.menuMAIN = New System.Windows.Forms.MenuStrip
        Me.CounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PatientNameCorrectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManagePhilebotomistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintPatientSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintRateListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.RateInquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RateListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SummariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CurrentSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DailyCashSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewDailyCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.CpCasesSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEditTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.EditPatientRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.ManageCollectionPointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.LabInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEditAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.GeneralJournalEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneralJournalViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.LedgersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountStatementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MainStatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
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
        Me.menuMAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CounterToolStripMenuItem, Me.SummariesToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menuMAIN.Location = New System.Drawing.Point(0, 0)
        Me.menuMAIN.Name = "menuMAIN"
        Me.menuMAIN.Size = New System.Drawing.Size(1156, 25)
        Me.menuMAIN.TabIndex = 9
        Me.menuMAIN.Text = "MenuStrip1"
        '
        'CounterToolStripMenuItem
        '
        Me.CounterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPatientToolStripMenuItem, Me.ToolStripSeparator1, Me.PatientNameCorrectionToolStripMenuItem, Me.ManagePhilebotomistToolStripMenuItem, Me.ToolStripMenuItem1, Me.PrintPatientSlipToolStripMenuItem, Me.PrintRateListToolStripMenuItem, Me.ToolStripMenuItem2, Me.RateInquiryToolStripMenuItem, Me.RateListToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem})
        Me.CounterToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.DocumentHS
        Me.CounterToolStripMenuItem.Name = "CounterToolStripMenuItem"
        Me.CounterToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.CounterToolStripMenuItem.Text = "&Data"
        '
        'NewPatientToolStripMenuItem
        '
        Me.NewPatientToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.NewDocumentHS
        Me.NewPatientToolStripMenuItem.Name = "NewPatientToolStripMenuItem"
        Me.NewPatientToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewPatientToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.NewPatientToolStripMenuItem.Text = "&New Patient"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'PatientNameCorrectionToolStripMenuItem
        '
        Me.PatientNameCorrectionToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PatientData
        Me.PatientNameCorrectionToolStripMenuItem.Name = "PatientNameCorrectionToolStripMenuItem"
        Me.PatientNameCorrectionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.PatientNameCorrectionToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.PatientNameCorrectionToolStripMenuItem.Text = "Patient Name Correction"
        '
        'ManagePhilebotomistToolStripMenuItem
        '
        Me.ManagePhilebotomistToolStripMenuItem.Name = "ManagePhilebotomistToolStripMenuItem"
        Me.ManagePhilebotomistToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ManagePhilebotomistToolStripMenuItem.Text = "Manage Philebotomist"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(237, 6)
        '
        'PrintPatientSlipToolStripMenuItem
        '
        Me.PrintPatientSlipToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.PrintPatientSlipToolStripMenuItem.Name = "PrintPatientSlipToolStripMenuItem"
        Me.PrintPatientSlipToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintPatientSlipToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.PrintPatientSlipToolStripMenuItem.Text = "&Print Receipt"
        '
        'PrintRateListToolStripMenuItem
        '
        Me.PrintRateListToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.PrintRateListToolStripMenuItem.Name = "PrintRateListToolStripMenuItem"
        Me.PrintRateListToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.PrintRateListToolStripMenuItem.Text = "Print Rate List"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(237, 6)
        '
        'RateInquiryToolStripMenuItem
        '
        Me.RateInquiryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Report_64
        Me.RateInquiryToolStripMenuItem.Name = "RateInquiryToolStripMenuItem"
        Me.RateInquiryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.RateInquiryToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.RateInquiryToolStripMenuItem.Text = "Rate Inquiry"
        '
        'RateListToolStripMenuItem
        '
        Me.RateListToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.book_addressHS
        Me.RateListToolStripMenuItem.Name = "RateListToolStripMenuItem"
        Me.RateListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RateListToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.RateListToolStripMenuItem.Text = "&Tests Rates"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(237, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ExitToolStripMenuItem.Text = "&Quit"
        '
        'SummariesToolStripMenuItem
        '
        Me.SummariesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentSummaryToolStripMenuItem, Me.DailyCashSummaryToolStripMenuItem, Me.ToolStripMenuItem4, Me.ViewDailyCasesToolStripMenuItem, Me.ToolStripMenuItem7, Me.CpCasesSummaryToolStripMenuItem})
        Me.SummariesToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_angleHS
        Me.SummariesToolStripMenuItem.Name = "SummariesToolStripMenuItem"
        Me.SummariesToolStripMenuItem.Size = New System.Drawing.Size(100, 21)
        Me.SummariesToolStripMenuItem.Text = "&Summaries"
        '
        'CurrentSummaryToolStripMenuItem
        '
        Me.CurrentSummaryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.CalculatorHS
        Me.CurrentSummaryToolStripMenuItem.Name = "CurrentSummaryToolStripMenuItem"
        Me.CurrentSummaryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.CurrentSummaryToolStripMenuItem.Size = New System.Drawing.Size(374, 22)
        Me.CurrentSummaryToolStripMenuItem.Text = "&Current Summary"
        '
        'DailyCashSummaryToolStripMenuItem
        '
        Me.DailyCashSummaryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_openHS
        Me.DailyCashSummaryToolStripMenuItem.Name = "DailyCashSummaryToolStripMenuItem"
        Me.DailyCashSummaryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DailyCashSummaryToolStripMenuItem.Size = New System.Drawing.Size(374, 22)
        Me.DailyCashSummaryToolStripMenuItem.Text = "Print &Daily Cash / Dues / Payment Summary"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(371, 6)
        '
        'ViewDailyCasesToolStripMenuItem
        '
        Me.ViewDailyCasesToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS
        Me.ViewDailyCasesToolStripMenuItem.Name = "ViewDailyCasesToolStripMenuItem"
        Me.ViewDailyCasesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewDailyCasesToolStripMenuItem.Size = New System.Drawing.Size(374, 22)
        Me.ViewDailyCasesToolStripMenuItem.Text = "&View Cases Summary"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(371, 6)
        '
        'CpCasesSummaryToolStripMenuItem
        '
        Me.CpCasesSummaryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS
        Me.CpCasesSummaryToolStripMenuItem.Name = "CpCasesSummaryToolStripMenuItem"
        Me.CpCasesSummaryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.CpCasesSummaryToolStripMenuItem.Size = New System.Drawing.Size(374, 22)
        Me.CpCasesSummaryToolStripMenuItem.Text = "Doctor Cases &Summary"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEditToolStripMenuItem, Me.AddEditTestToolStripMenuItem, Me.ToolStripMenuItem5, Me.EditPatientRecordToolStripMenuItem, Me.ToolStripMenuItem6, Me.ManageCollectionPointToolStripMenuItem, Me.ToolStripMenuItem10, Me.LabInformationToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.SaveFormDesignHS
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.MaintenanceToolStripMenuItem.Text = "&Admin"
        '
        'AddEditToolStripMenuItem
        '
        Me.AddEditToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.data_add
        Me.AddEditToolStripMenuItem.Name = "AddEditToolStripMenuItem"
        Me.AddEditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddEditToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.AddEditToolStripMenuItem.Text = "&Add / Edit User"
        '
        'AddEditTestToolStripMenuItem
        '
        Me.AddEditTestToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.data_add
        Me.AddEditTestToolStripMenuItem.Name = "AddEditTestToolStripMenuItem"
        Me.AddEditTestToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AddEditTestToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.AddEditTestToolStripMenuItem.Text = "Add / Edit &Test"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(264, 6)
        '
        'EditPatientRecordToolStripMenuItem
        '
        Me.EditPatientRecordToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.data_edit
        Me.EditPatientRecordToolStripMenuItem.Name = "EditPatientRecordToolStripMenuItem"
        Me.EditPatientRecordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditPatientRecordToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.EditPatientRecordToolStripMenuItem.Text = "&Edit Patient Record"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(264, 6)
        '
        'ManageCollectionPointToolStripMenuItem
        '
        Me.ManageCollectionPointToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS1
        Me.ManageCollectionPointToolStripMenuItem.Name = "ManageCollectionPointToolStripMenuItem"
        Me.ManageCollectionPointToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ManageCollectionPointToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ManageCollectionPointToolStripMenuItem.Text = "&Manage Collection Point"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(264, 6)
        '
        'LabInformationToolStripMenuItem
        '
        Me.LabInformationToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Medical_invoice_information_64
        Me.LabInformationToolStripMenuItem.Name = "LabInformationToolStripMenuItem"
        Me.LabInformationToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.LabInformationToolStripMenuItem.Text = "Lab Information"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEditAccountToolStripMenuItem, Me.ToolStripMenuItem8, Me.GeneralJournalEntriesToolStripMenuItem, Me.GeneralJournalViewToolStripMenuItem, Me.ToolStripMenuItem9, Me.LedgersToolStripMenuItem, Me.AccountStatementsToolStripMenuItem})
        Me.AccountsToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_openHS
        Me.AccountsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(88, 21)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
        Me.AccountsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddEditAccountToolStripMenuItem
        '
        Me.AddEditAccountToolStripMenuItem.Image = CType(resources.GetObject("AddEditAccountToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddEditAccountToolStripMenuItem.Name = "AddEditAccountToolStripMenuItem"
        Me.AddEditAccountToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.AddEditAccountToolStripMenuItem.Text = "Add / Edit Account"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(271, 6)
        '
        'GeneralJournalEntriesToolStripMenuItem
        '
        Me.GeneralJournalEntriesToolStripMenuItem.Image = CType(resources.GetObject("GeneralJournalEntriesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GeneralJournalEntriesToolStripMenuItem.Name = "GeneralJournalEntriesToolStripMenuItem"
        Me.GeneralJournalEntriesToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.GeneralJournalEntriesToolStripMenuItem.Text = "General Journal Book Keeping"
        '
        'GeneralJournalViewToolStripMenuItem
        '
        Me.GeneralJournalViewToolStripMenuItem.Image = CType(resources.GetObject("GeneralJournalViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GeneralJournalViewToolStripMenuItem.Name = "GeneralJournalViewToolStripMenuItem"
        Me.GeneralJournalViewToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.GeneralJournalViewToolStripMenuItem.Text = "View General Journal Transactions"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(271, 6)
        '
        'LedgersToolStripMenuItem
        '
        Me.LedgersToolStripMenuItem.Image = CType(resources.GetObject("LedgersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LedgersToolStripMenuItem.Name = "LedgersToolStripMenuItem"
        Me.LedgersToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.LedgersToolStripMenuItem.Text = "Ledgers"
        '
        'AccountStatementsToolStripMenuItem
        '
        Me.AccountStatementsToolStripMenuItem.Image = CType(resources.GetObject("AccountStatementsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AccountStatementsToolStripMenuItem.Name = "AccountStatementsToolStripMenuItem"
        Me.AccountStatementsToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.AccountStatementsToolStripMenuItem.Text = "Tiral Balance"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Medical_invoice_information_64
        Me.AboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(71, 21)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainStatusStrip
        '
        Me.MainStatusStrip.BackColor = System.Drawing.Color.LightGray
        Me.MainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8})
        Me.MainStatusStrip.Location = New System.Drawing.Point(0, 629)
        Me.MainStatusStrip.Name = "MainStatusStrip"
        Me.MainStatusStrip.Size = New System.Drawing.Size(1156, 26)
        Me.MainStatusStrip.TabIndex = 10
        Me.MainStatusStrip.Text = "MainStatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(107, 21)
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
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(78, 21)
        Me.ToolStripStatusLabel2.Text = "User Name"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(43, 21)
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
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(65, 21)
        Me.ToolStripStatusLabel4.Text = "Logged Off"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(66, 21)
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
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripStatusLabel6.Text = "None"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(79, 21)
        Me.ToolStripStatusLabel7.Text = "Total Patient"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(19, 21)
        Me.ToolStripStatusLabel8.Text = "0"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Business_Solutions.My.Resources.Resources._71_1thermo_lab_6753_w
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1156, 655)
        Me.Controls.Add(Me.MainStatusStrip)
        Me.Controls.Add(Me.menuMAIN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuMAIN
        Me.Name = "frmMain"
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
    Friend WithEvents CounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPatientSlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RateListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummariesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents AddEditAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GeneralJournalEntriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralJournalViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LedgersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AccountStatementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RateInquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRateListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientNameCorrectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagePhilebotomistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
