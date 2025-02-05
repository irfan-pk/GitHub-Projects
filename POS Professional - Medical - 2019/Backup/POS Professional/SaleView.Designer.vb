<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleView))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MyToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtDateTab1 = New System.Windows.Forms.DateTimePicker
        Me.dtDateTab2 = New System.Windows.Forms.DateTimePicker
        Me.dtDateTab3 = New System.Windows.Forms.DateTimePicker
        Me.dtDateTab4 = New System.Windows.Forms.DateTimePicker
        Me.cmdFindTab1 = New System.Windows.Forms.Button
        Me.cmdViewTab1 = New System.Windows.Forms.Button
        Me.cmdPayment = New System.Windows.Forms.Button
        Me.cmdFindTab2 = New System.Windows.Forms.Button
        Me.cmdViewTab2 = New System.Windows.Forms.Button
        Me.cmdFindTab3 = New System.Windows.Forms.Button
        Me.cmdViewTab3 = New System.Windows.Forms.Button
        Me.cmdFindTab4 = New System.Windows.Forms.Button
        Me.cmdViewTab4 = New System.Windows.Forms.Button
        Me.MasterChildDataSet = New System.Data.DataSet
        Me.DotNetBarTabcontrol = New POS_Professional.DotNetBarTabcontrol
        Me.CashSale = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CreditSale = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SaleRecovery = New System.Windows.Forms.TabPage
        Me.Button3 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ReturnSale = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TabReport = New System.Windows.Forms.TabPage
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtToDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtFromDate = New System.Windows.Forms.DateTimePicker
        Me.gbSelectReport = New System.Windows.Forms.GroupBox
        Me.rdCreditList = New System.Windows.Forms.RadioButton
        Me.rdReturn = New System.Windows.Forms.RadioButton
        Me.rdRecovery = New System.Windows.Forms.RadioButton
        Me.rdCredit = New System.Windows.Forms.RadioButton
        Me.rdDaily = New System.Windows.Forms.RadioButton
        Me.cmdPreview = New System.Windows.Forms.Button
        CType(Me.MasterChildDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DotNetBarTabcontrol.SuspendLayout()
        Me.CashSale.SuspendLayout()
        Me.CreditSale.SuspendLayout()
        Me.SaleRecovery.SuspendLayout()
        Me.ReturnSale.SuspendLayout()
        Me.TabReport.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbSelectReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1480381704_column_chart.png")
        Me.ImageList1.Images.SetKeyName(1, "Purse_64.png")
        Me.ImageList1.Images.SetKeyName(2, "Money-64x64.png")
        Me.ImageList1.Images.SetKeyName(3, "Medical-invoice-information-64.png")
        Me.ImageList1.Images.SetKeyName(4, "Analysis-64.png")
        Me.ImageList1.Images.SetKeyName(5, "PKR_Rs_1000_3.jpg")
        '
        'MyToolTip
        '
        Me.MyToolTip.IsBalloon = True
        Me.MyToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.MyToolTip.ToolTipTitle = "Tip"
        '
        'dtDateTab1
        '
        Me.dtDateTab1.CalendarTrailingForeColor = System.Drawing.Color.Gray
        Me.dtDateTab1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTab1.Location = New System.Drawing.Point(507, 7)
        Me.dtDateTab1.Name = "dtDateTab1"
        Me.dtDateTab1.Size = New System.Drawing.Size(238, 23)
        Me.dtDateTab1.TabIndex = 1
        Me.MyToolTip.SetToolTip(Me.dtDateTab1, "Select date for view")
        '
        'dtDateTab2
        '
        Me.dtDateTab2.CalendarTrailingForeColor = System.Drawing.Color.Gray
        Me.dtDateTab2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTab2.Location = New System.Drawing.Point(507, 7)
        Me.dtDateTab2.Name = "dtDateTab2"
        Me.dtDateTab2.Size = New System.Drawing.Size(238, 23)
        Me.dtDateTab2.TabIndex = 0
        Me.MyToolTip.SetToolTip(Me.dtDateTab2, "Select date for view")
        '
        'dtDateTab3
        '
        Me.dtDateTab3.CalendarTrailingForeColor = System.Drawing.Color.Gray
        Me.dtDateTab3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTab3.Location = New System.Drawing.Point(507, 7)
        Me.dtDateTab3.Name = "dtDateTab3"
        Me.dtDateTab3.Size = New System.Drawing.Size(238, 23)
        Me.dtDateTab3.TabIndex = 3
        Me.MyToolTip.SetToolTip(Me.dtDateTab3, "Select date for view")
        '
        'dtDateTab4
        '
        Me.dtDateTab4.CalendarTrailingForeColor = System.Drawing.Color.Gray
        Me.dtDateTab4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTab4.Location = New System.Drawing.Point(507, 7)
        Me.dtDateTab4.Name = "dtDateTab4"
        Me.dtDateTab4.Size = New System.Drawing.Size(238, 23)
        Me.dtDateTab4.TabIndex = 3
        Me.MyToolTip.SetToolTip(Me.dtDateTab4, "Select date for view")
        '
        'cmdFindTab1
        '
        Me.cmdFindTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFindTab1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFindTab1.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.cmdFindTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFindTab1.Location = New System.Drawing.Point(445, 5)
        Me.cmdFindTab1.Name = "cmdFindTab1"
        Me.cmdFindTab1.Size = New System.Drawing.Size(57, 26)
        Me.cmdFindTab1.TabIndex = 4
        Me.cmdFindTab1.Text = "&Find"
        Me.cmdFindTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdFindTab1, "Find sale invoice")
        Me.cmdFindTab1.UseVisualStyleBackColor = True
        '
        'cmdViewTab1
        '
        Me.cmdViewTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdViewTab1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdViewTab1.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.cmdViewTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdViewTab1.Location = New System.Drawing.Point(751, 5)
        Me.cmdViewTab1.Name = "cmdViewTab1"
        Me.cmdViewTab1.Size = New System.Drawing.Size(61, 26)
        Me.cmdViewTab1.TabIndex = 2
        Me.cmdViewTab1.Text = "&View"
        Me.cmdViewTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdViewTab1, "Select date and view all sales invoices")
        Me.cmdViewTab1.UseVisualStyleBackColor = True
        '
        'cmdPayment
        '
        Me.cmdPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPayment.Image = Global.POS_Professional.My.Resources.Resources.PKR_Rs_1000_3
        Me.cmdPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPayment.Location = New System.Drawing.Point(337, 5)
        Me.cmdPayment.Name = "cmdPayment"
        Me.cmdPayment.Size = New System.Drawing.Size(103, 26)
        Me.cmdPayment.TabIndex = 6
        Me.cmdPayment.Text = "&Payment"
        Me.cmdPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdPayment, "Click to received payment")
        Me.cmdPayment.UseVisualStyleBackColor = True
        Me.cmdPayment.Visible = False
        '
        'cmdFindTab2
        '
        Me.cmdFindTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFindTab2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFindTab2.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.cmdFindTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFindTab2.Location = New System.Drawing.Point(445, 5)
        Me.cmdFindTab2.Name = "cmdFindTab2"
        Me.cmdFindTab2.Size = New System.Drawing.Size(57, 26)
        Me.cmdFindTab2.TabIndex = 5
        Me.cmdFindTab2.Text = "&Find"
        Me.cmdFindTab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdFindTab2, "Find credit sale invoice")
        Me.cmdFindTab2.UseVisualStyleBackColor = True
        '
        'cmdViewTab2
        '
        Me.cmdViewTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdViewTab2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdViewTab2.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.cmdViewTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdViewTab2.Location = New System.Drawing.Point(751, 5)
        Me.cmdViewTab2.Name = "cmdViewTab2"
        Me.cmdViewTab2.Size = New System.Drawing.Size(61, 26)
        Me.cmdViewTab2.TabIndex = 1
        Me.cmdViewTab2.Text = "&View"
        Me.cmdViewTab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdViewTab2, "Select date and view all sales invoices")
        Me.cmdViewTab2.UseVisualStyleBackColor = True
        '
        'cmdFindTab3
        '
        Me.cmdFindTab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFindTab3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFindTab3.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.cmdFindTab3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFindTab3.Location = New System.Drawing.Point(445, 5)
        Me.cmdFindTab3.Name = "cmdFindTab3"
        Me.cmdFindTab3.Size = New System.Drawing.Size(57, 26)
        Me.cmdFindTab3.TabIndex = 7
        Me.cmdFindTab3.Text = "&Find"
        Me.cmdFindTab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdFindTab3, "Find recovery sale invoice")
        Me.cmdFindTab3.UseVisualStyleBackColor = True
        '
        'cmdViewTab3
        '
        Me.cmdViewTab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdViewTab3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdViewTab3.Image = Global.POS_Professional.My.Resources.Resources.search18
        Me.cmdViewTab3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdViewTab3.Location = New System.Drawing.Point(751, 5)
        Me.cmdViewTab3.Name = "cmdViewTab3"
        Me.cmdViewTab3.Size = New System.Drawing.Size(61, 26)
        Me.cmdViewTab3.TabIndex = 5
        Me.cmdViewTab3.Text = "&View"
        Me.cmdViewTab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdViewTab3, "Select date and view all recovery sales invoices")
        Me.cmdViewTab3.UseVisualStyleBackColor = True
        '
        'cmdFindTab4
        '
        Me.cmdFindTab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFindTab4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFindTab4.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.cmdFindTab4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFindTab4.Location = New System.Drawing.Point(445, 5)
        Me.cmdFindTab4.Name = "cmdFindTab4"
        Me.cmdFindTab4.Size = New System.Drawing.Size(57, 26)
        Me.cmdFindTab4.TabIndex = 8
        Me.cmdFindTab4.Text = "&Find"
        Me.cmdFindTab4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdFindTab4, "Find return sale invoice")
        Me.cmdFindTab4.UseVisualStyleBackColor = True
        '
        'cmdViewTab4
        '
        Me.cmdViewTab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdViewTab4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdViewTab4.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.cmdViewTab4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdViewTab4.Location = New System.Drawing.Point(751, 5)
        Me.cmdViewTab4.Name = "cmdViewTab4"
        Me.cmdViewTab4.Size = New System.Drawing.Size(61, 26)
        Me.cmdViewTab4.TabIndex = 5
        Me.cmdViewTab4.Text = "&View"
        Me.cmdViewTab4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MyToolTip.SetToolTip(Me.cmdViewTab4, "Select date and view all return sales invoices")
        Me.cmdViewTab4.UseVisualStyleBackColor = True
        '
        'MasterChildDataSet
        '
        Me.MasterChildDataSet.DataSetName = "NewDataSet"
        '
        'DotNetBarTabcontrol
        '
        Me.DotNetBarTabcontrol.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DotNetBarTabcontrol.Controls.Add(Me.CashSale)
        Me.DotNetBarTabcontrol.Controls.Add(Me.CreditSale)
        Me.DotNetBarTabcontrol.Controls.Add(Me.SaleRecovery)
        Me.DotNetBarTabcontrol.Controls.Add(Me.ReturnSale)
        Me.DotNetBarTabcontrol.Controls.Add(Me.TabReport)
        Me.DotNetBarTabcontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DotNetBarTabcontrol.ImageList = Me.ImageList1
        Me.DotNetBarTabcontrol.ItemSize = New System.Drawing.Size(44, 136)
        Me.DotNetBarTabcontrol.Location = New System.Drawing.Point(0, 0)
        Me.DotNetBarTabcontrol.Multiline = True
        Me.DotNetBarTabcontrol.Name = "DotNetBarTabcontrol"
        Me.DotNetBarTabcontrol.SelectedIndex = 0
        Me.DotNetBarTabcontrol.Size = New System.Drawing.Size(1019, 648)
        Me.DotNetBarTabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.DotNetBarTabcontrol.TabIndex = 0
        '
        'CashSale
        '
        Me.CashSale.BackColor = System.Drawing.Color.White
        Me.CashSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CashSale.Controls.Add(Me.cmdFindTab1)
        Me.CashSale.Controls.Add(Me.Button2)
        Me.CashSale.Controls.Add(Me.cmdViewTab1)
        Me.CashSale.Controls.Add(Me.dtDateTab1)
        Me.CashSale.Controls.Add(Me.Panel1)
        Me.CashSale.ImageIndex = 0
        Me.CashSale.Location = New System.Drawing.Point(140, 4)
        Me.CashSale.Name = "CashSale"
        Me.CashSale.Padding = New System.Windows.Forms.Padding(3)
        Me.CashSale.Size = New System.Drawing.Size(875, 640)
        Me.CashSale.TabIndex = 0
        Me.CashSale.Text = "Cash Sale"
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = Global.POS_Professional.My.Resources.Resources.remove1
        Me.Button2.Location = New System.Drawing.Point(817, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 26)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(6, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 585)
        Me.Panel1.TabIndex = 0
        '
        'CreditSale
        '
        Me.CreditSale.BackColor = System.Drawing.Color.White
        Me.CreditSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CreditSale.Controls.Add(Me.cmdPayment)
        Me.CreditSale.Controls.Add(Me.cmdFindTab2)
        Me.CreditSale.Controls.Add(Me.Button1)
        Me.CreditSale.Controls.Add(Me.cmdViewTab2)
        Me.CreditSale.Controls.Add(Me.dtDateTab2)
        Me.CreditSale.Controls.Add(Me.Panel2)
        Me.CreditSale.ImageIndex = 3
        Me.CreditSale.Location = New System.Drawing.Point(140, 4)
        Me.CreditSale.Name = "CreditSale"
        Me.CreditSale.Padding = New System.Windows.Forms.Padding(3)
        Me.CreditSale.Size = New System.Drawing.Size(875, 640)
        Me.CreditSale.TabIndex = 1
        Me.CreditSale.Text = "Credit Sale"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.POS_Professional.My.Resources.Resources.remove1
        Me.Button1.Location = New System.Drawing.Point(817, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(6, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(850, 585)
        Me.Panel2.TabIndex = 1
        '
        'SaleRecovery
        '
        Me.SaleRecovery.BackColor = System.Drawing.Color.White
        Me.SaleRecovery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SaleRecovery.Controls.Add(Me.cmdFindTab3)
        Me.SaleRecovery.Controls.Add(Me.Button3)
        Me.SaleRecovery.Controls.Add(Me.dtDateTab3)
        Me.SaleRecovery.Controls.Add(Me.Panel3)
        Me.SaleRecovery.Controls.Add(Me.cmdViewTab3)
        Me.SaleRecovery.ImageIndex = 2
        Me.SaleRecovery.Location = New System.Drawing.Point(140, 4)
        Me.SaleRecovery.Name = "SaleRecovery"
        Me.SaleRecovery.Padding = New System.Windows.Forms.Padding(3)
        Me.SaleRecovery.Size = New System.Drawing.Size(875, 640)
        Me.SaleRecovery.TabIndex = 3
        Me.SaleRecovery.Text = "Sale Recovery"
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = Global.POS_Professional.My.Resources.Resources.remove1
        Me.Button3.Location = New System.Drawing.Point(817, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 26)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(6, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(850, 585)
        Me.Panel3.TabIndex = 4
        '
        'ReturnSale
        '
        Me.ReturnSale.BackColor = System.Drawing.Color.White
        Me.ReturnSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReturnSale.Controls.Add(Me.cmdFindTab4)
        Me.ReturnSale.Controls.Add(Me.Button4)
        Me.ReturnSale.Controls.Add(Me.cmdViewTab4)
        Me.ReturnSale.Controls.Add(Me.dtDateTab4)
        Me.ReturnSale.Controls.Add(Me.Panel4)
        Me.ReturnSale.ImageIndex = 4
        Me.ReturnSale.Location = New System.Drawing.Point(140, 4)
        Me.ReturnSale.Name = "ReturnSale"
        Me.ReturnSale.Padding = New System.Windows.Forms.Padding(3)
        Me.ReturnSale.Size = New System.Drawing.Size(875, 640)
        Me.ReturnSale.TabIndex = 4
        Me.ReturnSale.Text = "Sales Return"
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Image = Global.POS_Professional.My.Resources.Resources.remove1
        Me.Button4.Location = New System.Drawing.Point(817, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 26)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(6, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(850, 585)
        Me.Panel4.TabIndex = 4
        '
        'TabReport
        '
        Me.TabReport.BackColor = System.Drawing.Color.White
        Me.TabReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabReport.Controls.Add(Me.cmdClose)
        Me.TabReport.Controls.Add(Me.GroupBox1)
        Me.TabReport.Controls.Add(Me.gbSelectReport)
        Me.TabReport.Controls.Add(Me.cmdPreview)
        Me.TabReport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabReport.ImageIndex = 3
        Me.TabReport.Location = New System.Drawing.Point(140, 4)
        Me.TabReport.Name = "TabReport"
        Me.TabReport.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReport.Size = New System.Drawing.Size(875, 640)
        Me.TabReport.TabIndex = 5
        Me.TabReport.Text = "Daily Reports"
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = Global.POS_Professional.My.Resources.Resources.remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(657, 348)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 28)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtToDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtFromDate)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 94)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Date Range"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To"
        '
        'dtToDate
        '
        Me.dtToDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToDate.Location = New System.Drawing.Point(355, 44)
        Me.dtToDate.Name = "dtToDate"
        Me.dtToDate.Size = New System.Drawing.Size(246, 23)
        Me.dtToDate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From"
        '
        'dtFromDate
        '
        Me.dtFromDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFromDate.Location = New System.Drawing.Point(73, 44)
        Me.dtFromDate.Name = "dtFromDate"
        Me.dtFromDate.Size = New System.Drawing.Size(246, 23)
        Me.dtFromDate.TabIndex = 6
        '
        'gbSelectReport
        '
        Me.gbSelectReport.BackColor = System.Drawing.Color.White
        Me.gbSelectReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.gbSelectReport.Controls.Add(Me.rdCreditList)
        Me.gbSelectReport.Controls.Add(Me.rdReturn)
        Me.gbSelectReport.Controls.Add(Me.rdRecovery)
        Me.gbSelectReport.Controls.Add(Me.rdCredit)
        Me.gbSelectReport.Controls.Add(Me.rdDaily)
        Me.gbSelectReport.Location = New System.Drawing.Point(123, 43)
        Me.gbSelectReport.Name = "gbSelectReport"
        Me.gbSelectReport.Size = New System.Drawing.Size(626, 189)
        Me.gbSelectReport.TabIndex = 0
        Me.gbSelectReport.TabStop = False
        Me.gbSelectReport.Text = "Select Report"
        '
        'rdCreditList
        '
        Me.rdCreditList.AutoSize = True
        Me.rdCreditList.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCreditList.Location = New System.Drawing.Point(88, 132)
        Me.rdCreditList.Name = "rdCreditList"
        Me.rdCreditList.Size = New System.Drawing.Size(127, 23)
        Me.rdCreditList.TabIndex = 5
        Me.rdCreditList.TabStop = True
        Me.rdCreditList.Text = "Credit Sale List"
        Me.rdCreditList.UseVisualStyleBackColor = True
        '
        'rdReturn
        '
        Me.rdReturn.AutoSize = True
        Me.rdReturn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdReturn.Location = New System.Drawing.Point(394, 84)
        Me.rdReturn.Name = "rdReturn"
        Me.rdReturn.Size = New System.Drawing.Size(109, 23)
        Me.rdReturn.TabIndex = 4
        Me.rdReturn.TabStop = True
        Me.rdReturn.Text = "Cash Return"
        Me.rdReturn.UseVisualStyleBackColor = True
        '
        'rdRecovery
        '
        Me.rdRecovery.AutoSize = True
        Me.rdRecovery.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdRecovery.Location = New System.Drawing.Point(88, 84)
        Me.rdRecovery.Name = "rdRecovery"
        Me.rdRecovery.Size = New System.Drawing.Size(125, 23)
        Me.rdRecovery.TabIndex = 3
        Me.rdRecovery.TabStop = True
        Me.rdRecovery.Text = "Cash Recovery"
        Me.rdRecovery.UseVisualStyleBackColor = True
        '
        'rdCredit
        '
        Me.rdCredit.AutoSize = True
        Me.rdCredit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCredit.Location = New System.Drawing.Point(394, 40)
        Me.rdCredit.Name = "rdCredit"
        Me.rdCredit.Size = New System.Drawing.Size(120, 23)
        Me.rdCredit.TabIndex = 2
        Me.rdCredit.TabStop = True
        Me.rdCredit.Text = "Cash Credited"
        Me.rdCredit.UseVisualStyleBackColor = True
        '
        'rdDaily
        '
        Me.rdDaily.AutoSize = True
        Me.rdDaily.Checked = True
        Me.rdDaily.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDaily.Location = New System.Drawing.Point(88, 40)
        Me.rdDaily.Name = "rdDaily"
        Me.rdDaily.Size = New System.Drawing.Size(129, 23)
        Me.rdDaily.TabIndex = 1
        Me.rdDaily.TabStop = True
        Me.rdDaily.Text = "Cash Collection"
        Me.rdDaily.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreview.Image = Global.POS_Professional.My.Resources.Resources.PrintHS
        Me.cmdPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPreview.Location = New System.Drawing.Point(559, 348)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(92, 28)
        Me.cmdPreview.TabIndex = 6
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'SaleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 648)
        Me.Controls.Add(Me.DotNetBarTabcontrol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaleView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Sale"
        CType(Me.MasterChildDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DotNetBarTabcontrol.ResumeLayout(False)
        Me.CashSale.ResumeLayout(False)
        Me.CreditSale.ResumeLayout(False)
        Me.SaleRecovery.ResumeLayout(False)
        Me.ReturnSale.ResumeLayout(False)
        Me.TabReport.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbSelectReport.ResumeLayout(False)
        Me.gbSelectReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DotNetBarTabcontrol As POS_Professional.DotNetBarTabcontrol
    Friend WithEvents CashSale As System.Windows.Forms.TabPage
    Friend WithEvents CreditSale As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtDateTab1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdViewTab1 As System.Windows.Forms.Button
    Friend WithEvents cmdViewTab2 As System.Windows.Forms.Button
    Friend WithEvents dtDateTab2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SaleRecovery As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReturnSale As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmdViewTab3 As System.Windows.Forms.Button
    Friend WithEvents dtDateTab3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmdViewTab4 As System.Windows.Forms.Button
    Friend WithEvents dtDateTab4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmdFindTab1 As System.Windows.Forms.Button
    Friend WithEvents MyToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents cmdFindTab2 As System.Windows.Forms.Button
    Friend WithEvents cmdFindTab3 As System.Windows.Forms.Button
    Friend WithEvents cmdFindTab4 As System.Windows.Forms.Button
    Friend WithEvents cmdPayment As System.Windows.Forms.Button
    Friend WithEvents TabReport As System.Windows.Forms.TabPage
    Friend WithEvents gbSelectReport As System.Windows.Forms.GroupBox
    Friend WithEvents rdDaily As System.Windows.Forms.RadioButton
    Friend WithEvents rdReturn As System.Windows.Forms.RadioButton
    Friend WithEvents rdRecovery As System.Windows.Forms.RadioButton
    Friend WithEvents rdCredit As System.Windows.Forms.RadioButton
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents rdCreditList As System.Windows.Forms.RadioButton
    Friend WithEvents MasterChildDataSet As System.Data.DataSet
End Class
