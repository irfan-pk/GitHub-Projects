<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrossMatch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdLSlip = New System.Windows.Forms.Button
        Me.TestListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.lblPSex = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtYrs = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtMth = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtDay = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtRefer = New System.Windows.Forms.TextBox
        Me.cmbCP = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtDName = New System.Windows.Forms.TextBox
        Me.cmbDTitle = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDYrs = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDSex = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbVisitor = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPaid = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDues = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCompli = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRecNo = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DonorDataGrid = New System.Windows.Forms.DataGridView
        Me.DONOR_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DONOR_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.application_remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(658, 516)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(106, 28)
        Me.cmdClose.TabIndex = 30
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(542, 516)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 28)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "&Save Record"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = Global.Business_Solutions.My.Resources.Resources.search1
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFind.Location = New System.Drawing.Point(117, 516)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(106, 28)
        Me.cmdFind.TabIndex = 23
        Me.cmdFind.Text = "&Find Record"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFind.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = Global.Business_Solutions.My.Resources.Resources.NewDocumentHS
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(12, 516)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(100, 28)
        Me.cmdNew.TabIndex = 24
        Me.cmdNew.Text = "&New Entry"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdLSlip
        '
        Me.cmdLSlip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLSlip.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLSlip.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.cmdLSlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLSlip.Location = New System.Drawing.Point(437, 516)
        Me.cmdLSlip.Name = "cmdLSlip"
        Me.cmdLSlip.Size = New System.Drawing.Size(100, 28)
        Me.cmdLSlip.TabIndex = 20
        Me.cmdLSlip.Text = "&Lab Slip"
        Me.cmdLSlip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLSlip.UseVisualStyleBackColor = False
        '
        'TestListView
        '
        Me.TestListView.BackColor = System.Drawing.Color.Gainsboro
        Me.TestListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TestListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.TestListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TestListView.FullRowSelect = True
        Me.TestListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.TestListView.Location = New System.Drawing.Point(12, 272)
        Me.TestListView.Name = "TestListView"
        Me.TestListView.Size = New System.Drawing.Size(752, 111)
        Me.TestListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.TestListView.TabIndex = 142
        Me.TestListView.UseCompatibleStateImageBehavior = False
        Me.TestListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CODE"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TEST NAME"
        Me.ColumnHeader2.Width = 290
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CATEGORY"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MODE"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "LEVEL"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PRICE"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "Patient Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtName.Location = New System.Drawing.Point(255, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(259, 26)
        Me.txtName.TabIndex = 1
        Me.txtName.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(466, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "Gender"
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"B/O", "Baby", "D/O", "F/O", "M/O", "Master", "Miss.", "Mr.", "Mrs.", "Ms.", "S/O", "Sis/O", "W/O", "Wid/O"})
        Me.cmbTitle.Location = New System.Drawing.Point(138, 19)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(111, 24)
        Me.cmbTitle.Sorted = True
        Me.cmbTitle.TabIndex = 0
        '
        'lblPSex
        '
        Me.lblPSex.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPSex.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPSex.Location = New System.Drawing.Point(520, 49)
        Me.lblPSex.Name = "lblPSex"
        Me.lblPSex.Size = New System.Drawing.Size(96, 22)
        Me.lblPSex.TabIndex = 5
        Me.lblPSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Patient Age"
        '
        'txtYrs
        '
        Me.txtYrs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtYrs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrs.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtYrs.Location = New System.Drawing.Point(138, 51)
        Me.txtYrs.Name = "txtYrs"
        Me.txtYrs.Size = New System.Drawing.Size(47, 19)
        Me.txtYrs.TabIndex = 2
        Me.txtYrs.Text = "00"
        Me.txtYrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(193, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 203
        Me.Label16.Text = "Yrs"
        '
        'txtMth
        '
        Me.txtMth.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMth.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtMth.Location = New System.Drawing.Point(224, 51)
        Me.txtMth.Name = "txtMth"
        Me.txtMth.Size = New System.Drawing.Size(46, 19)
        Me.txtMth.TabIndex = 3
        Me.txtMth.Text = "00"
        Me.txtMth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(276, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 204
        Me.Label17.Text = "Mth"
        '
        'txtDay
        '
        Me.txtDay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDay.Location = New System.Drawing.Point(310, 51)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(46, 19)
        Me.txtDay.TabIndex = 4
        Me.txtDay.Text = "00"
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(362, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 205
        Me.Label18.Text = "Day"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 206
        Me.Label9.Text = "Sample Collected at"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 207
        Me.Label10.Text = "Reffered by"
        '
        'txtRefer
        '
        Me.txtRefer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefer.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtRefer.Location = New System.Drawing.Point(138, 170)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.ReadOnly = True
        Me.txtRefer.Size = New System.Drawing.Size(477, 26)
        Me.txtRefer.TabIndex = 11
        '
        'cmbCP
        '
        Me.cmbCP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCP.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmbCP.FormattingEnabled = True
        Me.cmbCP.Location = New System.Drawing.Point(138, 138)
        Me.cmbCP.Name = "cmbCP"
        Me.cmbCP.Size = New System.Drawing.Size(478, 24)
        Me.cmbCP.Sorted = True
        Me.cmbCP.TabIndex = 10
        Me.cmbCP.Text = "Select Reference Code"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(9, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 13)
        Me.Label20.TabIndex = 210
        Me.Label20.Text = "Donor Name"
        '
        'txtDName
        '
        Me.txtDName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDName.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDName.Location = New System.Drawing.Point(255, 77)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.Size = New System.Drawing.Size(360, 26)
        Me.txtDName.TabIndex = 7
        '
        'cmbDTitle
        '
        Me.cmbDTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmbDTitle.FormattingEnabled = True
        Me.cmbDTitle.Items.AddRange(New Object() {"B/O", "Baby", "D/O", "F/O", "M/O", "Master", "Miss.", "Mr.", "Mrs.", "Ms.", "S/O", "Sis/O", "W/O", "Wid/O"})
        Me.cmbDTitle.Location = New System.Drawing.Point(138, 78)
        Me.cmbDTitle.Name = "cmbDTitle"
        Me.cmbDTitle.Size = New System.Drawing.Size(111, 24)
        Me.cmbDTitle.Sorted = True
        Me.cmbDTitle.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Donor Age"
        '
        'txtDYrs
        '
        Me.txtDYrs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDYrs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDYrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDYrs.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDYrs.Location = New System.Drawing.Point(138, 112)
        Me.txtDYrs.Name = "txtDYrs"
        Me.txtDYrs.Size = New System.Drawing.Size(47, 19)
        Me.txtDYrs.TabIndex = 8
        Me.txtDYrs.Text = "00"
        Me.txtDYrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(255, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 213
        Me.Label3.Text = "Gender"
        '
        'lblDSex
        '
        Me.lblDSex.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSex.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDSex.Location = New System.Drawing.Point(309, 110)
        Me.lblDSex.Name = "lblDSex"
        Me.lblDSex.Size = New System.Drawing.Size(96, 22)
        Me.lblDSex.TabIndex = 9
        Me.lblDSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(193, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "Yrs"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtCode.Location = New System.Drawing.Point(138, 205)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 26)
        Me.txtCode.TabIndex = 13
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 209)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 13)
        Me.Label14.TabIndex = 218
        Me.Label14.Text = "Select C. M. Code"
        '
        'cmbVisitor
        '
        Me.cmbVisitor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbVisitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVisitor.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmbVisitor.FormattingEnabled = True
        Me.cmbVisitor.Items.AddRange(New Object() {"NIL", "OUTSIDE"})
        Me.cmbVisitor.Location = New System.Drawing.Point(396, 204)
        Me.cmbVisitor.Name = "cmbVisitor"
        Me.cmbVisitor.Size = New System.Drawing.Size(220, 24)
        Me.cmbVisitor.Sorted = True
        Me.cmbVisitor.TabIndex = 14
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(286, 209)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(105, 13)
        Me.Label43.TabIndex = 219
        Me.Label43.Text = "Sample Drawn by"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(635, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Paid"
        '
        'txtPaid
        '
        Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.ForeColor = System.Drawing.Color.Red
        Me.txtPaid.Location = New System.Drawing.Point(638, 67)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(93, 21)
        Me.txtPaid.TabIndex = 16
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(635, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 222
        Me.Label8.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Red
        Me.txtDiscount.Location = New System.Drawing.Point(638, 113)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(93, 21)
        Me.txtDiscount.TabIndex = 17
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(638, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 224
        Me.Label11.Text = "Dues"
        '
        'txtDues
        '
        Me.txtDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDues.ForeColor = System.Drawing.Color.Red
        Me.txtDues.Location = New System.Drawing.Point(638, 206)
        Me.txtDues.Name = "txtDues"
        Me.txtDues.Size = New System.Drawing.Size(93, 21)
        Me.txtDues.TabIndex = 19
        Me.txtDues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(635, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 226
        Me.Label12.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Location = New System.Drawing.Point(638, 22)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(93, 21)
        Me.txtTotal.TabIndex = 15
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDate.Location = New System.Drawing.Point(425, 113)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(190, 17)
        Me.txtDate.TabIndex = 228
        Me.txtDate.TabStop = False
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(635, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 230
        Me.Label13.Text = "Complimentary"
        '
        'txtCompli
        '
        Me.txtCompli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompli.ForeColor = System.Drawing.Color.Red
        Me.txtCompli.Location = New System.Drawing.Point(638, 162)
        Me.txtCompli.Name = "txtCompli"
        Me.txtCompli.Size = New System.Drawing.Size(93, 21)
        Me.txtCompli.TabIndex = 18
        Me.txtCompli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRecNo)
        Me.GroupBox1.Controls.Add(Me.txtCompli)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtDues)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDiscount)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPaid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.cmbVisitor)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblDSex)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDYrs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDTitle)
        Me.GroupBox1.Controls.Add(Me.txtDName)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cmbCP)
        Me.GroupBox1.Controls.Add(Me.txtRefer)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtDay)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtMth)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtYrs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPSex)
        Me.GroupBox1.Controls.Add(Me.cmbTitle)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 251)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtRecNo
        '
        Me.txtRecNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRecNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNo.Location = New System.Drawing.Point(521, 19)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.Size = New System.Drawing.Size(95, 22)
        Me.txtRecNo.TabIndex = 143
        Me.txtRecNo.Text = "Label15"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'DonorDataGrid
        '
        Me.DonorDataGrid.AllowUserToAddRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DonorDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DonorDataGrid.AutoGenerateColumns = False
        Me.DonorDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DonorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DonorDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DonorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DonorDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DONOR_ID, Me.DONOR_NAME})
        Me.DonorDataGrid.DataSource = Me.BindingSource1
        Me.DonorDataGrid.GridColor = System.Drawing.Color.Gray
        Me.DonorDataGrid.Location = New System.Drawing.Point(12, 382)
        Me.DonorDataGrid.Name = "DonorDataGrid"
        Me.DonorDataGrid.ReadOnly = True
        Me.DonorDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DonorDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DonorDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.DonorDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DonorDataGrid.Size = New System.Drawing.Size(752, 124)
        Me.DonorDataGrid.TabIndex = 148
        Me.DonorDataGrid.TabStop = False
        '
        'DONOR_ID
        '
        Me.DONOR_ID.DataPropertyName = "DONOR_PID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DONOR_ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.DONOR_ID.HeaderText = "DONOR ID"
        Me.DONOR_ID.Name = "DONOR_ID"
        Me.DONOR_ID.ReadOnly = True
        Me.DONOR_ID.Width = 113
        '
        'DONOR_NAME
        '
        Me.DONOR_NAME.DataPropertyName = "DONOR_NAME"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DONOR_NAME.DefaultCellStyle = DataGridViewCellStyle3
        Me.DONOR_NAME.HeaderText = "DONOR NAME"
        Me.DONOR_NAME.Name = "DONOR_NAME"
        Me.DONOR_NAME.ReadOnly = True
        Me.DONOR_NAME.Width = 580
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(227, 516)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(100, 28)
        Me.cmdDelete.TabIndex = 22
        Me.cmdDelete.Text = "&Delete Test"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = False
        Me.cmdDelete.Visible = False
        '
        'frmCrossMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.DonorDataGrid)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.TestListView)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdLSlip)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCrossMatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cross Match Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdLSlip As System.Windows.Forms.Button
    Friend WithEvents TestListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblPSex As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYrs As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMth As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents cmbCP As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents cmbDTitle As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDYrs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDSex As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbVisitor As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDues As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCompli As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRecNo As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DonorDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents DONOR_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DONOR_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
