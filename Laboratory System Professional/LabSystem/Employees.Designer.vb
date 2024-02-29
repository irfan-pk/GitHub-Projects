<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employees))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.EmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpDataSet = New System.Data.DataSet
        Me.EmpTabControl = New System.Windows.Forms.TabControl
        Me.GeneralTab = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbShift = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtArear = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmbDept = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbDesignation = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpHire = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtEmpId = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtLandLine = New System.Windows.Forms.MaskedTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.MaskedTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAddrs = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbMarital = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbGender = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCNIC = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.WagesTab = New System.Windows.Forms.TabPage
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.dgvSalary = New System.Windows.Forms.DataGridView
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPosition = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalaryDataSet = New System.Data.DataSet
        Me.Salary_Info = New System.Data.DataTable
        Me.AdvanceTab = New System.Windows.Forms.TabPage
        Me.dgvAdvances = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEmpName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMonth = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAdv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colApproved = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdvDataSet = New System.Data.DataSet
        Me.Salary_Advances = New System.Data.DataTable
        Me.cmdAdvPrint = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cmbApprove = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtAdvance = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.dtpAdvDate = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.SalaryTab = New System.Windows.Forms.TabPage
        Me.cmdSalPrint = New System.Windows.Forms.Button
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker
        Me.Label29 = New System.Windows.Forms.Label
        Me.btnReverse = New System.Windows.Forms.Button
        Me.btnFinalize = New System.Windows.Forms.Button
        Me.btnCreate = New System.Windows.Forms.Button
        Me.dgvFinalSalary = New System.Windows.Forms.DataGridView
        Me.PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayDataSet = New System.Data.DataSet
        Me.EmpBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripEditButton = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripCloseButton = New System.Windows.Forms.ToolStripButton
        Me.dgvEmpList = New System.Windows.Forms.DataGridView
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.colPayMonth = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFpayID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFPayName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFPay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBonus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colArears = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPayAdv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDeduction = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNetSalary = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCloBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpTabControl.SuspendLayout()
        Me.GeneralTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.WagesTab.SuspendLayout()
        CType(Me.dgvSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salary_Info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdvanceTab.SuspendLayout()
        CType(Me.dgvAdvances, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salary_Advances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalaryTab.SuspendLayout()
        CType(Me.dgvFinalSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpBindingNavigator.SuspendLayout()
        CType(Me.dgvEmpList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpBindingSource
        '
        Me.EmpBindingSource.DataSource = Me.EmpDataSet
        Me.EmpBindingSource.Position = 0
        '
        'EmpDataSet
        '
        Me.EmpDataSet.DataSetName = "EmpDataSet"
        '
        'EmpTabControl
        '
        Me.EmpTabControl.Controls.Add(Me.GeneralTab)
        Me.EmpTabControl.Controls.Add(Me.WagesTab)
        Me.EmpTabControl.Controls.Add(Me.AdvanceTab)
        Me.EmpTabControl.Controls.Add(Me.SalaryTab)
        Me.EmpTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpTabControl.Location = New System.Drawing.Point(221, 65)
        Me.EmpTabControl.Name = "EmpTabControl"
        Me.EmpTabControl.SelectedIndex = 0
        Me.EmpTabControl.Size = New System.Drawing.Size(776, 572)
        Me.EmpTabControl.TabIndex = 2
        '
        'GeneralTab
        '
        Me.GeneralTab.BackColor = System.Drawing.Color.Transparent
        Me.GeneralTab.Controls.Add(Me.Panel1)
        Me.GeneralTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralTab.Location = New System.Drawing.Point(4, 24)
        Me.GeneralTab.Name = "GeneralTab"
        Me.GeneralTab.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralTab.Size = New System.Drawing.Size(768, 544)
        Me.GeneralTab.TabIndex = 0
        Me.GeneralTab.Text = "General"
        Me.GeneralTab.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbShift)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtArear)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.txtSalary)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.dtpEndDate)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.cmbDept)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.cmbDesignation)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.dtpHire)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtEmpId)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.cmbStatus)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtLandLine)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtMobile)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtAddrs)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmbMarital)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmbGender)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCNIC)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtpDOB)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtLName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbTitle)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(11, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 403)
        Me.Panel1.TabIndex = 41
        '
        'cmbShift
        '
        Me.cmbShift.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbShift.FormattingEnabled = True
        Me.cmbShift.Items.AddRange(New Object() {"First", "Second", "Full Day"})
        Me.cmbShift.Location = New System.Drawing.Point(552, 75)
        Me.cmbShift.Name = "cmbShift"
        Me.cmbShift.Size = New System.Drawing.Size(106, 21)
        Me.cmbShift.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(549, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 13)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Shift"
        '
        'txtArear
        '
        Me.txtArear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtArear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArear.Location = New System.Drawing.Point(552, 267)
        Me.txtArear.Name = "txtArear"
        Me.txtArear.Size = New System.Drawing.Size(106, 20)
        Me.txtArear.TabIndex = 23
        Me.txtArear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(549, 253)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Arrear"
        '
        'txtSalary
        '
        Me.txtSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalary.Location = New System.Drawing.Point(430, 267)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(106, 20)
        Me.txtSalary.TabIndex = 22
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(427, 253)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Salary"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = ""
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(430, 222)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(116, 20)
        Me.dtpEndDate.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(427, 205)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Resign"
        '
        'cmbDept
        '
        Me.cmbDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Items.AddRange(New Object() {"Accounts", "Chemistry", "Computer", "Hematology", "Histopathology", "Hormones", "Management", "Microscopic", "Reception"})
        Me.cmbDept.Location = New System.Drawing.Point(430, 172)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(228, 21)
        Me.cmbDept.Sorted = True
        Me.cmbDept.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(430, 157)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Department"
        '
        'cmbDesignation
        '
        Me.cmbDesignation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbDesignation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDesignation.FormattingEnabled = True
        Me.cmbDesignation.Items.AddRange(New Object() {"Accountant", "Computer Operator", "Hematologist", "Manager", "Pathologist", "Philebotomist", "Receptionist", "Sweeper", "Technician", "Technician Helper"})
        Me.cmbDesignation.Location = New System.Drawing.Point(430, 124)
        Me.cmbDesignation.Name = "cmbDesignation"
        Me.cmbDesignation.Size = New System.Drawing.Size(228, 21)
        Me.cmbDesignation.Sorted = True
        Me.cmbDesignation.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(430, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Position"
        '
        'dtpHire
        '
        Me.dtpHire.CustomFormat = ""
        Me.dtpHire.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHire.Location = New System.Drawing.Point(430, 75)
        Me.dtpHire.Name = "dtpHire"
        Me.dtpHire.Size = New System.Drawing.Size(116, 20)
        Me.dtpHire.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(427, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Hire Date"
        '
        'txtEmpId
        '
        Me.txtEmpId.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpId.Location = New System.Drawing.Point(552, 33)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.ReadOnly = True
        Me.txtEmpId.Size = New System.Drawing.Size(106, 20)
        Me.txtEmpId.TabIndex = 16
        Me.txtEmpId.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(549, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Employee ID"
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive", "Terminated"})
        Me.cmbStatus.Location = New System.Drawing.Point(430, 32)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(116, 21)
        Me.cmbStatus.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(427, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Status"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(77, 358)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(281, 20)
        Me.txtEmail.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(74, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "E-mail Address"
        '
        'txtLandLine
        '
        Me.txtLandLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLandLine.Location = New System.Drawing.Point(223, 315)
        Me.txtLandLine.Mask = "00000000000"
        Me.txtLandLine.Name = "txtLandLine"
        Me.txtLandLine.Size = New System.Drawing.Size(136, 20)
        Me.txtLandLine.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(220, 299)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Home Phone"
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Location = New System.Drawing.Point(77, 315)
        Me.txtMobile.Mask = "00000000000"
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(136, 20)
        Me.txtMobile.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Cell Phone"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(77, 267)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(138, 20)
        Me.txtCity.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(74, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "City"
        '
        'txtAddrs
        '
        Me.txtAddrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddrs.Location = New System.Drawing.Point(77, 222)
        Me.txtAddrs.Name = "txtAddrs"
        Me.txtAddrs.Size = New System.Drawing.Size(281, 20)
        Me.txtAddrs.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(77, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Address"
        '
        'cmbMarital
        '
        Me.cmbMarital.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMarital.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMarital.FormattingEnabled = True
        Me.cmbMarital.Items.AddRange(New Object() {"Single", "Married", "Exempt"})
        Me.cmbMarital.Location = New System.Drawing.Point(223, 172)
        Me.cmbMarital.Name = "cmbMarital"
        Me.cmbMarital.Size = New System.Drawing.Size(137, 21)
        Me.cmbMarital.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Marital Status"
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.SystemColors.Window
        Me.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(77, 172)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(137, 21)
        Me.cmbGender.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Gender"
        '
        'txtCNIC
        '
        Me.txtCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNIC.Location = New System.Drawing.Point(223, 125)
        Me.txtCNIC.Mask = "00000-0000000-0"
        Me.txtCNIC.Name = "txtCNIC"
        Me.txtCNIC.Size = New System.Drawing.Size(136, 20)
        Me.txtCNIC.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(218, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "CNIC #"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = ""
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(77, 125)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(137, 20)
        Me.dtpDOB.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Birth Date"
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Location = New System.Drawing.Point(223, 76)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(138, 20)
        Me.txtLName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Name"
        '
        'txtFName
        '
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Location = New System.Drawing.Point(77, 76)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(138, 20)
        Me.txtFName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "First Name"
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr.", "Ms.", "Mrs."})
        Me.cmbTitle.Location = New System.Drawing.Point(77, 32)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(78, 21)
        Me.cmbTitle.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Title"
        '
        'WagesTab
        '
        Me.WagesTab.Controls.Add(Me.cmdEdit)
        Me.WagesTab.Controls.Add(Me.cmdDelete)
        Me.WagesTab.Controls.Add(Me.cmdAdd)
        Me.WagesTab.Controls.Add(Me.dgvSalary)
        Me.WagesTab.Location = New System.Drawing.Point(4, 24)
        Me.WagesTab.Name = "WagesTab"
        Me.WagesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.WagesTab.Size = New System.Drawing.Size(768, 544)
        Me.WagesTab.TabIndex = 1
        Me.WagesTab.Text = "Wages"
        Me.WagesTab.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Image = Global.Business_Solutions.My.Resources.Resources.CutHS2
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(603, 509)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(76, 23)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Text = "Ed&it"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.database_remove1
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(685, 509)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(76, 23)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "De&lete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Image = Global.Business_Solutions.My.Resources.Resources.NewDocumentHS2
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(521, 509)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(76, 23)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "A&dd"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'dgvSalary
        '
        Me.dgvSalary.AllowUserToAddRows = False
        Me.dgvSalary.AllowUserToDeleteRows = False
        Me.dgvSalary.AutoGenerateColumns = False
        Me.dgvSalary.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colPosition, Me.colNote, Me.colRate, Me.colType})
        Me.dgvSalary.DataSource = Me.SalaryBindingSource
        Me.dgvSalary.Location = New System.Drawing.Point(8, 10)
        Me.dgvSalary.MultiSelect = False
        Me.dgvSalary.Name = "dgvSalary"
        Me.dgvSalary.ReadOnly = True
        Me.dgvSalary.RowHeadersVisible = False
        Me.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalary.Size = New System.Drawing.Size(754, 487)
        Me.dgvSalary.TabIndex = 0
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "IncreaseOn"
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colPosition
        '
        Me.colPosition.DataPropertyName = "Position"
        Me.colPosition.HeaderText = "Position"
        Me.colPosition.Name = "colPosition"
        Me.colPosition.ReadOnly = True
        Me.colPosition.Width = 130
        '
        'colNote
        '
        Me.colNote.DataPropertyName = "note"
        Me.colNote.HeaderText = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.ReadOnly = True
        Me.colNote.Width = 210
        '
        'colRate
        '
        Me.colRate.DataPropertyName = "rate"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colRate.DefaultCellStyle = DataGridViewCellStyle1
        Me.colRate.HeaderText = "Rate"
        Me.colRate.Name = "colRate"
        Me.colRate.ReadOnly = True
        '
        'colType
        '
        Me.colType.DataPropertyName = "type"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colType.DefaultCellStyle = DataGridViewCellStyle2
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 70
        '
        'SalaryBindingSource
        '
        Me.SalaryBindingSource.DataSource = Me.SalaryDataSet
        Me.SalaryBindingSource.Position = 0
        '
        'SalaryDataSet
        '
        Me.SalaryDataSet.DataSetName = "SalaryDataSet"
        Me.SalaryDataSet.Tables.AddRange(New System.Data.DataTable() {Me.Salary_Info})
        '
        'Salary_Info
        '
        Me.Salary_Info.TableName = "Salary_Info"
        '
        'AdvanceTab
        '
        Me.AdvanceTab.Controls.Add(Me.dgvAdvances)
        Me.AdvanceTab.Controls.Add(Me.cmdAdvPrint)
        Me.AdvanceTab.Controls.Add(Me.txtName)
        Me.AdvanceTab.Controls.Add(Me.Label28)
        Me.AdvanceTab.Controls.Add(Me.txtID)
        Me.AdvanceTab.Controls.Add(Me.Label25)
        Me.AdvanceTab.Controls.Add(Me.cmbApprove)
        Me.AdvanceTab.Controls.Add(Me.Label27)
        Me.AdvanceTab.Controls.Add(Me.txtAdvance)
        Me.AdvanceTab.Controls.Add(Me.Label26)
        Me.AdvanceTab.Controls.Add(Me.dtpAdvDate)
        Me.AdvanceTab.Controls.Add(Me.Label24)
        Me.AdvanceTab.Controls.Add(Me.btnDelete)
        Me.AdvanceTab.Controls.Add(Me.btnSave)
        Me.AdvanceTab.Location = New System.Drawing.Point(4, 24)
        Me.AdvanceTab.Name = "AdvanceTab"
        Me.AdvanceTab.Size = New System.Drawing.Size(768, 544)
        Me.AdvanceTab.TabIndex = 2
        Me.AdvanceTab.Text = "Advance"
        Me.AdvanceTab.UseVisualStyleBackColor = True
        '
        'dgvAdvances
        '
        Me.dgvAdvances.AllowUserToAddRows = False
        Me.dgvAdvances.AllowUserToDeleteRows = False
        Me.dgvAdvances.AutoGenerateColumns = False
        Me.dgvAdvances.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdvances.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAdvances.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAdvances.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAdvances.ColumnHeadersHeight = 30
        Me.dgvAdvances.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colEmpName, Me.colMonth, Me.colEDate, Me.colAdv, Me.colApproved})
        Me.dgvAdvances.DataSource = Me.AdvBindingSource
        Me.dgvAdvances.EnableHeadersVisualStyles = False
        Me.dgvAdvances.Location = New System.Drawing.Point(17, 63)
        Me.dgvAdvances.Name = "dgvAdvances"
        Me.dgvAdvances.ReadOnly = True
        Me.dgvAdvances.RowHeadersVisible = False
        Me.dgvAdvances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdvances.Size = New System.Drawing.Size(611, 464)
        Me.dgvAdvances.TabIndex = 44
        '
        'colID
        '
        Me.colID.DataPropertyName = "EmployeeID"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colID.DefaultCellStyle = DataGridViewCellStyle4
        Me.colID.HeaderText = "ID #"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 60
        '
        'colEmpName
        '
        Me.colEmpName.DataPropertyName = "Name"
        Me.colEmpName.HeaderText = "Employee"
        Me.colEmpName.Name = "colEmpName"
        Me.colEmpName.ReadOnly = True
        Me.colEmpName.Width = 130
        '
        'colMonth
        '
        Me.colMonth.DataPropertyName = "Month"
        Me.colMonth.HeaderText = "Month"
        Me.colMonth.Name = "colMonth"
        Me.colMonth.ReadOnly = True
        '
        'colEDate
        '
        Me.colEDate.DataPropertyName = "AdvDate"
        Me.colEDate.HeaderText = "Date"
        Me.colEDate.Name = "colEDate"
        Me.colEDate.ReadOnly = True
        '
        'colAdv
        '
        Me.colAdv.DataPropertyName = "Amount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colAdv.DefaultCellStyle = DataGridViewCellStyle5
        Me.colAdv.HeaderText = "Advance"
        Me.colAdv.Name = "colAdv"
        Me.colAdv.ReadOnly = True
        '
        'colApproved
        '
        Me.colApproved.DataPropertyName = "ApprovedBy"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colApproved.DefaultCellStyle = DataGridViewCellStyle6
        Me.colApproved.HeaderText = "Approved"
        Me.colApproved.Name = "colApproved"
        Me.colApproved.ReadOnly = True
        '
        'AdvBindingSource
        '
        Me.AdvBindingSource.DataSource = Me.AdvDataSet
        Me.AdvBindingSource.Position = 0
        '
        'AdvDataSet
        '
        Me.AdvDataSet.DataSetName = "AdvDataSet"
        Me.AdvDataSet.Tables.AddRange(New System.Data.DataTable() {Me.Salary_Advances})
        '
        'Salary_Advances
        '
        Me.Salary_Advances.TableName = "Salary_Advances"
        '
        'cmdAdvPrint
        '
        Me.cmdAdvPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdvPrint.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS1
        Me.cmdAdvPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdvPrint.Location = New System.Drawing.Point(666, 92)
        Me.cmdAdvPrint.Name = "cmdAdvPrint"
        Me.cmdAdvPrint.Size = New System.Drawing.Size(83, 25)
        Me.cmdAdvPrint.TabIndex = 10
        Me.cmdAdvPrint.Text = "&Preview"
        Me.cmdAdvPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAdvPrint.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(237, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(119, 21)
        Me.txtName.TabIndex = 3
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(234, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(41, 15)
        Me.Label28.TabIndex = 43
        Me.Label28.Text = "Name"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(17, 32)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(89, 21)
        Me.txtID.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(14, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 15)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Employee ID"
        '
        'cmbApprove
        '
        Me.cmbApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbApprove.FormattingEnabled = True
        Me.cmbApprove.Items.AddRange(New Object() {"General Manager", "Manager", "Accountant", "Supervisor"})
        Me.cmbApprove.Location = New System.Drawing.Point(484, 31)
        Me.cmbApprove.Name = "cmbApprove"
        Me.cmbApprove.Size = New System.Drawing.Size(145, 23)
        Me.cmbApprove.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(481, 15)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 13)
        Me.Label27.TabIndex = 36
        Me.Label27.Text = "Approved By"
        '
        'txtAdvance
        '
        Me.txtAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdvance.Location = New System.Drawing.Point(362, 32)
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(116, 21)
        Me.txtAdvance.TabIndex = 4
        Me.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(357, 14)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 15)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Advance"
        '
        'dtpAdvDate
        '
        Me.dtpAdvDate.CustomFormat = "MMM, dd - yyyy"
        Me.dtpAdvDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAdvDate.Location = New System.Drawing.Point(112, 32)
        Me.dtpAdvDate.Name = "dtpAdvDate"
        Me.dtpAdvDate.Size = New System.Drawing.Size(119, 21)
        Me.dtpAdvDate.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(109, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 15)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Select Date"
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Image = Global.Business_Solutions.My.Resources.Resources.database_remove
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(666, 61)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 25)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "De&lete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(666, 30)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 25)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "S&ave"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SalaryTab
        '
        Me.SalaryTab.Controls.Add(Me.cmdSalPrint)
        Me.SalaryTab.Controls.Add(Me.dtpMonth)
        Me.SalaryTab.Controls.Add(Me.Label29)
        Me.SalaryTab.Controls.Add(Me.btnReverse)
        Me.SalaryTab.Controls.Add(Me.btnFinalize)
        Me.SalaryTab.Controls.Add(Me.btnCreate)
        Me.SalaryTab.Controls.Add(Me.dgvFinalSalary)
        Me.SalaryTab.Location = New System.Drawing.Point(4, 24)
        Me.SalaryTab.Name = "SalaryTab"
        Me.SalaryTab.Size = New System.Drawing.Size(768, 544)
        Me.SalaryTab.TabIndex = 3
        Me.SalaryTab.Text = "Salary Sheet"
        Me.SalaryTab.UseVisualStyleBackColor = True
        '
        'cmdSalPrint
        '
        Me.cmdSalPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalPrint.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.cmdSalPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalPrint.Location = New System.Drawing.Point(678, 6)
        Me.cmdSalPrint.Name = "cmdSalPrint"
        Me.cmdSalPrint.Size = New System.Drawing.Size(86, 27)
        Me.cmdSalPrint.TabIndex = 9
        Me.cmdSalPrint.Text = "&Preview"
        Me.cmdSalPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalPrint.UseVisualStyleBackColor = True
        '
        'dtpMonth
        '
        Me.dtpMonth.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpMonth.CustomFormat = "MMM, yyyy"
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(90, 10)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(100, 21)
        Me.dtpMonth.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 14)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 13)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "Salary Month"
        '
        'btnReverse
        '
        Me.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReverse.Image = Global.Business_Solutions.My.Resources.Resources.application_remove11
        Me.btnReverse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReverse.Location = New System.Drawing.Point(589, 6)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(86, 27)
        Me.btnReverse.TabIndex = 8
        Me.btnReverse.Text = "Roll &Back"
        Me.btnReverse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnFinalize
        '
        Me.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinalize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalize.Image = Global.Business_Solutions.My.Resources.Resources.page_process11
        Me.btnFinalize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinalize.Location = New System.Drawing.Point(500, 6)
        Me.btnFinalize.Name = "btnFinalize"
        Me.btnFinalize.Size = New System.Drawing.Size(86, 27)
        Me.btnFinalize.TabIndex = 7
        Me.btnFinalize.Text = "&Finalize"
        Me.btnFinalize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFinalize.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Image = Global.Business_Solutions.My.Resources.Resources.Book_openHS1
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.Location = New System.Drawing.Point(411, 6)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(86, 27)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "&Get Data"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'dgvFinalSalary
        '
        Me.dgvFinalSalary.AllowUserToAddRows = False
        Me.dgvFinalSalary.AllowUserToDeleteRows = False
        Me.dgvFinalSalary.AutoGenerateColumns = False
        Me.dgvFinalSalary.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.dgvFinalSalary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFinalSalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalSalary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFinalSalary.ColumnHeadersHeight = 30
        Me.dgvFinalSalary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPayMonth, Me.colFpayID, Me.colFPayName, Me.colFPay, Me.colBonus, Me.colArears, Me.colPayAdv, Me.colTotal, Me.colDeduction, Me.colNetSalary, Me.colCloBal, Me.colStatus})
        Me.dgvFinalSalary.DataSource = Me.PayBindingSource
        Me.dgvFinalSalary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvFinalSalary.EnableHeadersVisualStyles = False
        Me.dgvFinalSalary.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvFinalSalary.Location = New System.Drawing.Point(0, 39)
        Me.dgvFinalSalary.Name = "dgvFinalSalary"
        Me.dgvFinalSalary.RowHeadersVisible = False
        Me.dgvFinalSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFinalSalary.Size = New System.Drawing.Size(768, 505)
        Me.dgvFinalSalary.TabIndex = 1
        '
        'PayBindingSource
        '
        Me.PayBindingSource.DataSource = Me.PayDataSet
        Me.PayBindingSource.Position = 0
        '
        'PayDataSet
        '
        Me.PayDataSet.DataSetName = "PayDataSet"
        '
        'EmpBindingNavigator
        '
        Me.EmpBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpBindingNavigator.BindingSource = Me.EmpBindingSource
        Me.EmpBindingNavigator.CountItem = Nothing
        Me.EmpBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpBindingNavigator.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EmpBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator1, Me.ToolStripEditButton, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.BindingNavigatorSave, Me.ToolStripSeparator2, Me.ToolStripCloseButton})
        Me.EmpBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpBindingNavigator.MoveFirstItem = Nothing
        Me.EmpBindingNavigator.MoveLastItem = Nothing
        Me.EmpBindingNavigator.MoveNextItem = Nothing
        Me.EmpBindingNavigator.MovePreviousItem = Nothing
        Me.EmpBindingNavigator.Name = "EmpBindingNavigator"
        Me.EmpBindingNavigator.PositionItem = Nothing
        Me.EmpBindingNavigator.Size = New System.Drawing.Size(1001, 25)
        Me.EmpBindingNavigator.TabIndex = 0
        Me.EmpBindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(79, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add New"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(64, 22)
        Me.BindingNavigatorDeleteItem.Text = "&Delete"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripEditButton
        '
        Me.ToolStripEditButton.Image = Global.Business_Solutions.My.Resources.Resources.CutHS
        Me.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEditButton.Name = "ToolStripEditButton"
        Me.ToolStripEditButton.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripEditButton.Text = "&Edit"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSave
        '
        Me.BindingNavigatorSave.Enabled = False
        Me.BindingNavigatorSave.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.BindingNavigatorSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSave.Name = "BindingNavigatorSave"
        Me.BindingNavigatorSave.Size = New System.Drawing.Size(56, 22)
        Me.BindingNavigatorSave.Text = "&Save"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripCloseButton.Text = "&Close"
        '
        'dgvEmpList
        '
        Me.dgvEmpList.AllowUserToAddRows = False
        Me.dgvEmpList.AllowUserToDeleteRows = False
        Me.dgvEmpList.AutoGenerateColumns = False
        Me.dgvEmpList.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmpList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmpList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmpList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvEmpList.ColumnHeadersHeight = 30
        Me.dgvEmpList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colLastName})
        Me.dgvEmpList.DataSource = Me.EmpBindingSource
        Me.dgvEmpList.EnableHeadersVisualStyles = False
        Me.dgvEmpList.Location = New System.Drawing.Point(5, 66)
        Me.dgvEmpList.Name = "dgvEmpList"
        Me.dgvEmpList.ReadOnly = True
        Me.dgvEmpList.RowHeadersVisible = False
        Me.dgvEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpList.Size = New System.Drawing.Size(212, 571)
        Me.dgvEmpList.TabIndex = 1
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colName.DataPropertyName = "FirstName"
        Me.colName.HeaderText = "First Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 91
        '
        'colLastName
        '
        Me.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colLastName.DataPropertyName = "LastName"
        Me.colLastName.HeaderText = "Last Name"
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(221, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(772, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "General Information"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(5, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employees"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'colPayMonth
        '
        Me.colPayMonth.DataPropertyName = "salarymonth"
        Me.colPayMonth.HeaderText = "Month"
        Me.colPayMonth.Name = "colPayMonth"
        Me.colPayMonth.ReadOnly = True
        '
        'colFpayID
        '
        Me.colFpayID.DataPropertyName = "empid"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFpayID.DefaultCellStyle = DataGridViewCellStyle8
        Me.colFpayID.HeaderText = "Employee ID"
        Me.colFpayID.Name = "colFpayID"
        Me.colFpayID.ReadOnly = True
        '
        'colFPayName
        '
        Me.colFPayName.DataPropertyName = "empname"
        Me.colFPayName.HeaderText = "Name"
        Me.colFPayName.Name = "colFPayName"
        Me.colFPayName.ReadOnly = True
        '
        'colFPay
        '
        Me.colFPay.DataPropertyName = "empsalary"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colFPay.DefaultCellStyle = DataGridViewCellStyle9
        Me.colFPay.HeaderText = "Salary"
        Me.colFPay.Name = "colFPay"
        Me.colFPay.ReadOnly = True
        '
        'colBonus
        '
        Me.colBonus.DataPropertyName = "empbonus"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.NullValue = "0"
        Me.colBonus.DefaultCellStyle = DataGridViewCellStyle10
        Me.colBonus.HeaderText = "Bonus"
        Me.colBonus.Name = "colBonus"
        Me.colBonus.ReadOnly = True
        '
        'colArears
        '
        Me.colArears.DataPropertyName = "emparears"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.NullValue = "0"
        Me.colArears.DefaultCellStyle = DataGridViewCellStyle11
        Me.colArears.HeaderText = "Arears"
        Me.colArears.Name = "colArears"
        Me.colArears.ReadOnly = True
        '
        'colPayAdv
        '
        Me.colPayAdv.DataPropertyName = "empadvance"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.NullValue = "0"
        Me.colPayAdv.DefaultCellStyle = DataGridViewCellStyle12
        Me.colPayAdv.HeaderText = "Monthly Adv."
        Me.colPayAdv.Name = "colPayAdv"
        Me.colPayAdv.ReadOnly = True
        '
        'colTotal
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.NullValue = "0"
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle13
        Me.colTotal.HeaderText = "Total Arears"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'colDeduction
        '
        Me.colDeduction.DataPropertyName = "empdeduction"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.NullValue = "0"
        Me.colDeduction.DefaultCellStyle = DataGridViewCellStyle14
        Me.colDeduction.HeaderText = "Deduction"
        Me.colDeduction.Name = "colDeduction"
        '
        'colNetSalary
        '
        Me.colNetSalary.DataPropertyName = "empnetsalary"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.NullValue = "0"
        Me.colNetSalary.DefaultCellStyle = DataGridViewCellStyle15
        Me.colNetSalary.HeaderText = "Net Salary"
        Me.colNetSalary.Name = "colNetSalary"
        Me.colNetSalary.ReadOnly = True
        '
        'colCloBal
        '
        Me.colCloBal.DataPropertyName = "empclosbal"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.NullValue = "0"
        Me.colCloBal.DefaultCellStyle = DataGridViewCellStyle16
        Me.colCloBal.HeaderText = "Clos. B/L"
        Me.colCloBal.Name = "colCloBal"
        Me.colCloBal.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.DataPropertyName = "status"
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = False
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 644)
        Me.Controls.Add(Me.dgvEmpList)
        Me.Controls.Add(Me.EmpBindingNavigator)
        Me.Controls.Add(Me.EmpTabControl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Manager"
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpTabControl.ResumeLayout(False)
        Me.GeneralTab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.WagesTab.ResumeLayout(False)
        CType(Me.dgvSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salary_Info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdvanceTab.ResumeLayout(False)
        Me.AdvanceTab.PerformLayout()
        CType(Me.dgvAdvances, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salary_Advances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalaryTab.ResumeLayout(False)
        Me.SalaryTab.PerformLayout()
        CType(Me.dgvFinalSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpBindingNavigator.ResumeLayout(False)
        Me.EmpBindingNavigator.PerformLayout()
        CType(Me.dgvEmpList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EmpTabControl As System.Windows.Forms.TabControl
    Friend WithEvents GeneralTab As System.Windows.Forms.TabPage
    Friend WithEvents WagesTab As System.Windows.Forms.TabPage
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCNIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbMarital As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAddrs As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLandLine As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents EmpBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripEditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpHire As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbDesignation As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents EmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpDataSet As System.Data.DataSet
    Friend WithEvents txtArear As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents AdvanceTab As System.Windows.Forms.TabPage
    Friend WithEvents cmbShift As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dgvSalary As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents SalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalaryDataSet As System.Data.DataSet
    Friend WithEvents Salary_Info As System.Data.DataTable
    Friend WithEvents AdvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdvDataSet As System.Data.DataSet
    Friend WithEvents Salary_Advances As System.Data.DataTable
    Friend WithEvents dtpAdvDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmbApprove As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dgvEmpList As System.Windows.Forms.DataGridView
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPosition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryTab As System.Windows.Forms.TabPage
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dgvFinalSalary As System.Windows.Forms.DataGridView
    Friend WithEvents PayDataSet As System.Data.DataSet
    Friend WithEvents PayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents btnFinalize As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdAdvPrint As System.Windows.Forms.Button
    Friend WithEvents cmdSalPrint As System.Windows.Forms.Button
    Friend WithEvents dgvAdvances As System.Windows.Forms.DataGridView
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmpName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAdv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApproved As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayMonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFpayID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFPayName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFPay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBonus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colArears As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayAdv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDeduction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNetSalary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCloBal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
