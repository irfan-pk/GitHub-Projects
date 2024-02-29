<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainReception
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainReception))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainStatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.menuMAIN = New System.Windows.Forms.MenuStrip
        Me.CounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CrossMatchEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DonorProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.PatientNameCorrectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManagePhilebotomistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPatientSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintRateListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintDuplicateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.RateInquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RateListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SummariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DailyCashSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewDailyCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.CpCasesSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainStatusStrip.SuspendLayout()
        Me.menuMAIN.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'MainStatusStrip
        '
        Me.MainStatusStrip.BackColor = System.Drawing.Color.LightGray
        Me.MainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8})
        Me.MainStatusStrip.Location = New System.Drawing.Point(0, 691)
        Me.MainStatusStrip.Name = "MainStatusStrip"
        Me.MainStatusStrip.Size = New System.Drawing.Size(1000, 22)
        Me.MainStatusStrip.TabIndex = 15
        Me.MainStatusStrip.Text = "MainStatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(89, 17)
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
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(63, 17)
        Me.ToolStripStatusLabel2.Text = "User Name"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(38, 17)
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
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel4.Text = "Logged Off"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(56, 17)
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
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel6.Text = "None"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(68, 17)
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
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(17, 17)
        Me.ToolStripStatusLabel8.Text = "0"
        '
        'menuMAIN
        '
        Me.menuMAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CounterToolStripMenuItem, Me.SummariesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menuMAIN.Location = New System.Drawing.Point(0, 0)
        Me.menuMAIN.Name = "menuMAIN"
        Me.menuMAIN.Size = New System.Drawing.Size(1000, 24)
        Me.menuMAIN.TabIndex = 14
        Me.menuMAIN.Text = "MenuStrip1"
        '
        'CounterToolStripMenuItem
        '
        Me.CounterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPatientToolStripMenuItem, Me.CrossMatchEntryToolStripMenuItem, Me.DonorProfileToolStripMenuItem, Me.ToolStripMenuItem1, Me.PatientNameCorrectionToolStripMenuItem, Me.AddReferenceToolStripMenuItem, Me.ManagePhilebotomistToolStripMenuItem, Me.PrintPatientSlipToolStripMenuItem, Me.PrintRateListToolStripMenuItem, Me.PrintDuplicateReportToolStripMenuItem, Me.ToolStripMenuItem2, Me.RateInquiryToolStripMenuItem, Me.RateListToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem})
        Me.CounterToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.DocumentHS
        Me.CounterToolStripMenuItem.Name = "CounterToolStripMenuItem"
        Me.CounterToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.CounterToolStripMenuItem.Text = "&Data"
        '
        'NewPatientToolStripMenuItem
        '
        Me.NewPatientToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.NewDocumentHS
        Me.NewPatientToolStripMenuItem.Name = "NewPatientToolStripMenuItem"
        Me.NewPatientToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewPatientToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.NewPatientToolStripMenuItem.Text = "&New Patient"
        '
        'CrossMatchEntryToolStripMenuItem
        '
        Me.CrossMatchEntryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PatientFile1
        Me.CrossMatchEntryToolStripMenuItem.Name = "CrossMatchEntryToolStripMenuItem"
        Me.CrossMatchEntryToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.CrossMatchEntryToolStripMenuItem.Text = "Cross Match Entry"
        '
        'DonorProfileToolStripMenuItem
        '
        Me.DonorProfileToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PatientFile1
        Me.DonorProfileToolStripMenuItem.Name = "DonorProfileToolStripMenuItem"
        Me.DonorProfileToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.DonorProfileToolStripMenuItem.Text = "Donor Profile"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(218, 6)
        '
        'PatientNameCorrectionToolStripMenuItem
        '
        Me.PatientNameCorrectionToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PatientData
        Me.PatientNameCorrectionToolStripMenuItem.Name = "PatientNameCorrectionToolStripMenuItem"
        Me.PatientNameCorrectionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.PatientNameCorrectionToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PatientNameCorrectionToolStripMenuItem.Text = "Patient Name Correction"
        '
        'AddReferenceToolStripMenuItem
        '
        Me.AddReferenceToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.data_add
        Me.AddReferenceToolStripMenuItem.Name = "AddReferenceToolStripMenuItem"
        Me.AddReferenceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.AddReferenceToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.AddReferenceToolStripMenuItem.Text = "Add Reference Doctor"
        '
        'ManagePhilebotomistToolStripMenuItem
        '
        Me.ManagePhilebotomistToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PatientFile1
        Me.ManagePhilebotomistToolStripMenuItem.Name = "ManagePhilebotomistToolStripMenuItem"
        Me.ManagePhilebotomistToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ManagePhilebotomistToolStripMenuItem.Text = "Manage Philebotomist"
        '
        'PrintPatientSlipToolStripMenuItem
        '
        Me.PrintPatientSlipToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.PrintPatientSlipToolStripMenuItem.Name = "PrintPatientSlipToolStripMenuItem"
        Me.PrintPatientSlipToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintPatientSlipToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PrintPatientSlipToolStripMenuItem.Text = "&Print Receipt"
        '
        'PrintRateListToolStripMenuItem
        '
        Me.PrintRateListToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.PrintRateListToolStripMenuItem.Name = "PrintRateListToolStripMenuItem"
        Me.PrintRateListToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PrintRateListToolStripMenuItem.Text = "Print Rate List"
        '
        'PrintDuplicateReportToolStripMenuItem
        '
        Me.PrintDuplicateReportToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.PrintDuplicateReportToolStripMenuItem.Name = "PrintDuplicateReportToolStripMenuItem"
        Me.PrintDuplicateReportToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PrintDuplicateReportToolStripMenuItem.Text = "Print Duplicate Report"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(218, 6)
        '
        'RateInquiryToolStripMenuItem
        '
        Me.RateInquiryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Report_64
        Me.RateInquiryToolStripMenuItem.Name = "RateInquiryToolStripMenuItem"
        Me.RateInquiryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.RateInquiryToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.RateInquiryToolStripMenuItem.Text = "Rate Inquiry"
        '
        'RateListToolStripMenuItem
        '
        Me.RateListToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.book_addressHS
        Me.RateListToolStripMenuItem.Name = "RateListToolStripMenuItem"
        Me.RateListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RateListToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.RateListToolStripMenuItem.Text = "&Tests Rates"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(218, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ExitToolStripMenuItem.Text = "&Quit"
        '
        'SummariesToolStripMenuItem
        '
        Me.SummariesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyCashSummaryToolStripMenuItem, Me.ToolStripMenuItem4, Me.ViewDailyCasesToolStripMenuItem, Me.ToolStripMenuItem7, Me.CpCasesSummaryToolStripMenuItem, Me.DashboardToolStripMenuItem})
        Me.SummariesToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_angleHS
        Me.SummariesToolStripMenuItem.Name = "SummariesToolStripMenuItem"
        Me.SummariesToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.SummariesToolStripMenuItem.Text = "&Summaries"
        '
        'DailyCashSummaryToolStripMenuItem
        '
        Me.DailyCashSummaryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Book_openHS
        Me.DailyCashSummaryToolStripMenuItem.Name = "DailyCashSummaryToolStripMenuItem"
        Me.DailyCashSummaryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DailyCashSummaryToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.DailyCashSummaryToolStripMenuItem.Text = "&Daily Cash / Cp Dues / Cp Payment Summary"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(336, 6)
        '
        'ViewDailyCasesToolStripMenuItem
        '
        Me.ViewDailyCasesToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS
        Me.ViewDailyCasesToolStripMenuItem.Name = "ViewDailyCasesToolStripMenuItem"
        Me.ViewDailyCasesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewDailyCasesToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.ViewDailyCasesToolStripMenuItem.Text = "&View Cases Summary"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(336, 6)
        '
        'CpCasesSummaryToolStripMenuItem
        '
        Me.CpCasesSummaryToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.OrganizerHS
        Me.CpCasesSummaryToolStripMenuItem.Name = "CpCasesSummaryToolStripMenuItem"
        Me.CpCasesSummaryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.CpCasesSummaryToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.CpCasesSummaryToolStripMenuItem.Text = "Doctor Cases &Summary"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Report_64
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Medical_invoice_information_64
        Me.AboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Timer1
        '
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 54000
        '
        'MainReception
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Business_Solutions.My.Resources.Resources._71_1thermo_lab_6753_w
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 713)
        Me.Controls.Add(Me.MainStatusStrip)
        Me.Controls.Add(Me.menuMAIN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainReception"
        Me.Text = "Reception"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainStatusStrip.ResumeLayout(False)
        Me.MainStatusStrip.PerformLayout()
        Me.menuMAIN.ResumeLayout(False)
        Me.menuMAIN.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MainStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menuMAIN As System.Windows.Forms.MenuStrip
    Friend WithEvents CounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrossMatchEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonorProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PatientNameCorrectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagePhilebotomistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPatientSlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRateListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RateInquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RateListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummariesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyCashSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewDailyCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CpCasesSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddReferenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PrintDuplicateReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateTimer As System.Windows.Forms.Timer

End Class
