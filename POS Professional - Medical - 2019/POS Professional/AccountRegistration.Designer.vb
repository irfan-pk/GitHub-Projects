<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountRegistration))
        Me.cmbAccHead = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblSeq = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtCrDays = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtOpnCrBal = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtBankAcc = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtBankName = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtArea = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.AccDataGridView = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.cbAccReg = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtOpnBal = New System.Windows.Forms.TextBox
        Me.txtCrLimit = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpRegOn = New System.Windows.Forms.DateTimePicker
        Me.txtDrCr = New System.Windows.Forms.TextBox
        Me.cmbDrCr = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOpnDrBal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAccName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAccID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.AccDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbAccHead
        '
        Me.cmbAccHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccHead.Enabled = False
        Me.cmbAccHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAccHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccHead.FormattingEnabled = True
        Me.cmbAccHead.Items.AddRange(New Object() {"ASSETS", "EQUITY", "LIABILITIES", "REVENUE", "EXPENSES", "INCOME SUMMARY"})
        Me.cmbAccHead.Location = New System.Drawing.Point(121, 65)
        Me.cmbAccHead.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAccHead.Name = "cmbAccHead"
        Me.cmbAccHead.Size = New System.Drawing.Size(285, 23)
        Me.cmbAccHead.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(42, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Group Head"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lblSeq)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtCrDays)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtOpnCrBal)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtMobile)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtBankAcc)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtBankName)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtArea)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.AccDataGridView)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cbAccReg)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtOpnBal)
        Me.Panel1.Controls.Add(Me.txtCrLimit)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtpRegOn)
        Me.Panel1.Controls.Add(Me.txtDrCr)
        Me.Panel1.Controls.Add(Me.cmbDrCr)
        Me.Panel1.Controls.Add(Me.cmbAccHead)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtOpnDrBal)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAccName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAccID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 503)
        Me.Panel1.TabIndex = 99
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(32, 438)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 16)
        Me.Label19.TabIndex = 149
        Me.Label19.Text = "[ Press F2 to Scroll Accounts ]"
        '
        'lblSeq
        '
        Me.lblSeq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeq.ForeColor = System.Drawing.Color.White
        Me.lblSeq.Location = New System.Drawing.Point(332, 39)
        Me.lblSeq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeq.Name = "lblSeq"
        Me.lblSeq.Size = New System.Drawing.Size(74, 22)
        Me.lblSeq.TabIndex = 148
        Me.lblSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(254, 44)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 147
        Me.Label18.Text = "Last Acc ID"
        '
        'txtCrDays
        '
        Me.txtCrDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCrDays.Enabled = False
        Me.txtCrDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrDays.Location = New System.Drawing.Point(451, 303)
        Me.txtCrDays.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrDays.Name = "txtCrDays"
        Me.txtCrDays.Size = New System.Drawing.Size(141, 22)
        Me.txtCrDays.TabIndex = 15
        Me.txtCrDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(375, 307)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 146
        Me.Label17.Text = "Credit Days"
        '
        'txtOpnCrBal
        '
        Me.txtOpnCrBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpnCrBal.Enabled = False
        Me.txtOpnCrBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpnCrBal.Location = New System.Drawing.Point(451, 277)
        Me.txtOpnCrBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOpnCrBal.Name = "txtOpnCrBal"
        Me.txtOpnCrBal.Size = New System.Drawing.Size(141, 22)
        Me.txtOpnCrBal.TabIndex = 13
        Me.txtOpnCrBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(407, 281)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 144
        Me.Label16.Text = "Credit"
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Enabled = False
        Me.txtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(451, 225)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(141, 22)
        Me.txtMobile.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(391, 229)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "Mobile #"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Enabled = False
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(121, 225)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(141, 22)
        Me.txtPhone.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(62, 229)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 140
        Me.Label14.Text = "Phone #"
        '
        'txtBankAcc
        '
        Me.txtBankAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankAcc.Enabled = False
        Me.txtBankAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankAcc.Location = New System.Drawing.Point(451, 199)
        Me.txtBankAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBankAcc.Name = "txtBankAcc"
        Me.txtBankAcc.Size = New System.Drawing.Size(220, 22)
        Me.txtBankAcc.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(362, 204)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Bank A/c No."
        '
        'txtBankName
        '
        Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankName.Enabled = False
        Me.txtBankName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(121, 199)
        Me.txtBankName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(214, 22)
        Me.txtBankName.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(45, 204)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "Bank Name"
        '
        'txtArea
        '
        Me.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArea.Enabled = False
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(121, 173)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(141, 22)
        Me.txtArea.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(84, 178)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Area"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(121, 147)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(550, 22)
        Me.txtAddress.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(65, 152)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Address"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AccDataGridView
        '
        Me.AccDataGridView.AllowUserToAddRows = False
        Me.AccDataGridView.AllowUserToDeleteRows = False
        Me.AccDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.AccDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.AccDataGridView.Location = New System.Drawing.Point(705, 40)
        Me.AccDataGridView.MultiSelect = False
        Me.AccDataGridView.Name = "AccDataGridView"
        Me.AccDataGridView.ReadOnly = True
        Me.AccDataGridView.RowHeadersVisible = False
        Me.AccDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AccDataGridView.Size = New System.Drawing.Size(240, 311)
        Me.AccDataGridView.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.DataPropertyName = "acc_no"
        Me.Column1.HeaderText = "Acc No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "acc_name"
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Location = New System.Drawing.Point(404, 410)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(541, 66)
        Me.GroupBox1.TabIndex = 130
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(426, 17)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 38)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "< E&xit >"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(322, 17)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 38)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "< &Save >"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(218, 17)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 38)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "< &Delete >"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(114, 17)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(104, 38)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "< &Edit >"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNew.Location = New System.Drawing.Point(10, 17)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(104, 38)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "< &New >"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'cbAccReg
        '
        Me.cbAccReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAccReg.Enabled = False
        Me.cbAccReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAccReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccReg.FormattingEnabled = True
        Me.cbAccReg.Items.AddRange(New Object() {"ACCOUNT", "CUSTOMER", "COMPANY"})
        Me.cbAccReg.Location = New System.Drawing.Point(121, 93)
        Me.cbAccReg.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAccReg.Name = "cbAccReg"
        Me.cbAccReg.Size = New System.Drawing.Size(285, 23)
        Me.cbAccReg.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Acc. Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(64, 307)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Balance"
        '
        'txtOpnBal
        '
        Me.txtOpnBal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtOpnBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpnBal.Enabled = False
        Me.txtOpnBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpnBal.Location = New System.Drawing.Point(121, 304)
        Me.txtOpnBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOpnBal.Name = "txtOpnBal"
        Me.txtOpnBal.ReadOnly = True
        Me.txtOpnBal.Size = New System.Drawing.Size(141, 22)
        Me.txtOpnBal.TabIndex = 14
        Me.txtOpnBal.TabStop = False
        Me.txtOpnBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCrLimit
        '
        Me.txtCrLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCrLimit.Enabled = False
        Me.txtCrLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrLimit.Location = New System.Drawing.Point(121, 329)
        Me.txtCrLimit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrLimit.Name = "txtCrLimit"
        Me.txtCrLimit.Size = New System.Drawing.Size(141, 22)
        Me.txtCrLimit.TabIndex = 16
        Me.txtCrLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(47, 334)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Credit Limit"
        '
        'dtpRegOn
        '
        Me.dtpRegOn.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegOn.Enabled = False
        Me.dtpRegOn.Location = New System.Drawing.Point(451, 330)
        Me.dtpRegOn.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpRegOn.Name = "dtpRegOn"
        Me.dtpRegOn.Size = New System.Drawing.Size(220, 22)
        Me.dtpRegOn.TabIndex = 17
        '
        'txtDrCr
        '
        Me.txtDrCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrCr.Enabled = False
        Me.txtDrCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrCr.Location = New System.Drawing.Point(451, 251)
        Me.txtDrCr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDrCr.Name = "txtDrCr"
        Me.txtDrCr.ReadOnly = True
        Me.txtDrCr.Size = New System.Drawing.Size(141, 22)
        Me.txtDrCr.TabIndex = 11
        Me.txtDrCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbDrCr
        '
        Me.cmbDrCr.Enabled = False
        Me.cmbDrCr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDrCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDrCr.FormattingEnabled = True
        Me.cmbDrCr.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.cmbDrCr.Location = New System.Drawing.Point(121, 252)
        Me.cmbDrCr.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDrCr.Name = "cmbDrCr"
        Me.cmbDrCr.Size = New System.Drawing.Size(141, 21)
        Me.cmbDrCr.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(373, 334)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Register On"
        '
        'txtOpnDrBal
        '
        Me.txtOpnDrBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpnDrBal.Enabled = False
        Me.txtOpnDrBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpnDrBal.Location = New System.Drawing.Point(121, 278)
        Me.txtOpnDrBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOpnDrBal.Name = "txtOpnDrBal"
        Me.txtOpnDrBal.Size = New System.Drawing.Size(141, 22)
        Me.txtOpnDrBal.TabIndex = 12
        Me.txtOpnDrBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(80, 282)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Debit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 255)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Trans. Type"
        '
        'txtAccName
        '
        Me.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccName.Enabled = False
        Me.txtAccName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccName.Location = New System.Drawing.Point(121, 121)
        Me.txtAccName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.Size = New System.Drawing.Size(285, 22)
        Me.txtAccName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAccID
        '
        Me.txtAccID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccID.Location = New System.Drawing.Point(121, 39)
        Me.txtAccID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccID.Name = "txtAccID"
        Me.txtAccID.Size = New System.Drawing.Size(68, 22)
        Me.txtAccID.TabIndex = 0
        Me.txtAccID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account No"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(213, 438)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(139, 16)
        Me.Label20.TabIndex = 150
        Me.Label20.Text = "[ Press F3 to Refresh ]"
        '
        'AccountHeads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(965, 503)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "AccountHeads"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AccDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbAccHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDrCr As System.Windows.Forms.TextBox
    Friend WithEvents cmbDrCr As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAccID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpRegOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOpnDrBal As System.Windows.Forms.TextBox
    Friend WithEvents txtCrLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOpnBal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbAccReg As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents AccDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBankAcc As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCrDays As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtOpnCrBal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblSeq As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
