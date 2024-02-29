<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPatient))
        Me.GridBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSRefer = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.cmbVisitor = New System.Windows.Forms.ComboBox
        Me.cmbCollPoint = New System.Windows.Forms.ComboBox
        Me.txtCollPoint = New System.Windows.Forms.TextBox
        Me.cmbDoctors = New System.Windows.Forms.ComboBox
        Me.txtRefer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtCNIC = New System.Windows.Forms.MaskedTextBox
        Me.lblSequence = New System.Windows.Forms.Label
        Me.txtSNo = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtHospital = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPanel = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSlip = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtDay = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMth = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtYrs = New System.Windows.Forms.TextBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblSex = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRecNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblDues = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPaid = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.lblOper = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtCompli = New System.Windows.Forms.TextBox
        Me.txtPAmount = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TestListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.cmdPaid = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdComp = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        CType(Me.GridBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridBinding
        '
        Me.GridBinding.DataSource = Me.GridDataSet
        Me.GridBinding.Position = 0
        '
        'GridDataSet
        '
        Me.GridDataSet.DataSetName = "GridDataSet"
        Me.GridDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "RECEIPT"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSRefer)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Controls.Add(Me.cmbVisitor)
        Me.Panel1.Controls.Add(Me.cmbCollPoint)
        Me.Panel1.Controls.Add(Me.txtCollPoint)
        Me.Panel1.Controls.Add(Me.cmbDoctors)
        Me.Panel1.Controls.Add(Me.txtRefer)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtCNIC)
        Me.Panel1.Controls.Add(Me.lblSequence)
        Me.Panel1.Controls.Add(Me.txtSNo)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.txtHospital)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtPanel)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtSlip)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtDay)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtMth)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtYrs)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblSex)
        Me.Panel1.Controls.Add(Me.cmbTitle)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRecNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Location = New System.Drawing.Point(13, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 272)
        Me.Panel1.TabIndex = 99
        '
        'txtSRefer
        '
        Me.txtSRefer.BackColor = System.Drawing.SystemColors.Control
        Me.txtSRefer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSRefer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRefer.ForeColor = System.Drawing.Color.Black
        Me.txtSRefer.Location = New System.Drawing.Point(494, 205)
        Me.txtSRefer.Name = "txtSRefer"
        Me.txtSRefer.Size = New System.Drawing.Size(239, 24)
        Me.txtSRefer.TabIndex = 20
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(405, 211)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 13)
        Me.Label26.TabIndex = 203
        Me.Label26.Text = "Special Refer"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(410, 243)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(79, 13)
        Me.Label43.TabIndex = 201
        Me.Label43.Text = "Phlebotomist"
        '
        'cmbVisitor
        '
        Me.cmbVisitor.BackColor = System.Drawing.SystemColors.Control
        Me.cmbVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVisitor.ForeColor = System.Drawing.Color.Black
        Me.cmbVisitor.FormattingEnabled = True
        Me.cmbVisitor.Items.AddRange(New Object() {"LAB", "NIL", "OUTSIDE"})
        Me.cmbVisitor.Location = New System.Drawing.Point(494, 237)
        Me.cmbVisitor.Name = "cmbVisitor"
        Me.cmbVisitor.Size = New System.Drawing.Size(240, 24)
        Me.cmbVisitor.Sorted = True
        Me.cmbVisitor.TabIndex = 22
        '
        'cmbCollPoint
        '
        Me.cmbCollPoint.BackColor = System.Drawing.SystemColors.Control
        Me.cmbCollPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCollPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCollPoint.ForeColor = System.Drawing.Color.Black
        Me.cmbCollPoint.FormattingEnabled = True
        Me.cmbCollPoint.Items.AddRange(New Object() {"LAB"})
        Me.cmbCollPoint.Location = New System.Drawing.Point(106, 174)
        Me.cmbCollPoint.Name = "cmbCollPoint"
        Me.cmbCollPoint.Size = New System.Drawing.Size(293, 24)
        Me.cmbCollPoint.Sorted = True
        Me.cmbCollPoint.TabIndex = 17
        Me.cmbCollPoint.Text = "Select Referenced Collection Point"
        '
        'txtCollPoint
        '
        Me.txtCollPoint.BackColor = System.Drawing.SystemColors.Control
        Me.txtCollPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollPoint.ForeColor = System.Drawing.Color.Black
        Me.txtCollPoint.Location = New System.Drawing.Point(405, 173)
        Me.txtCollPoint.Name = "txtCollPoint"
        Me.txtCollPoint.Size = New System.Drawing.Size(328, 24)
        Me.txtCollPoint.TabIndex = 18
        '
        'cmbDoctors
        '
        Me.cmbDoctors.BackColor = System.Drawing.SystemColors.Control
        Me.cmbDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctors.ForeColor = System.Drawing.Color.Black
        Me.cmbDoctors.FormattingEnabled = True
        Me.cmbDoctors.Items.AddRange(New Object() {"SELF"})
        Me.cmbDoctors.Location = New System.Drawing.Point(106, 140)
        Me.cmbDoctors.Name = "cmbDoctors"
        Me.cmbDoctors.Size = New System.Drawing.Size(293, 24)
        Me.cmbDoctors.Sorted = True
        Me.cmbDoctors.TabIndex = 15
        Me.cmbDoctors.Text = "Select Referenced Doctor"
        '
        'txtRefer
        '
        Me.txtRefer.BackColor = System.Drawing.SystemColors.Control
        Me.txtRefer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefer.ForeColor = System.Drawing.Color.Black
        Me.txtRefer.Location = New System.Drawing.Point(405, 140)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(328, 24)
        Me.txtRefer.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(25, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 199
        Me.Label9.Text = "Collection at"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(34, 146)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 198
        Me.Label21.Text = "Refered by"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(52, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "CNIC #"
        '
        'txtCNIC
        '
        Me.txtCNIC.BackColor = System.Drawing.SystemColors.Control
        Me.txtCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNIC.Location = New System.Drawing.Point(106, 108)
        Me.txtCNIC.Mask = "99999-9999999-9"
        Me.txtCNIC.Name = "txtCNIC"
        Me.txtCNIC.Size = New System.Drawing.Size(134, 24)
        Me.txtCNIC.TabIndex = 12
        '
        'lblSequence
        '
        Me.lblSequence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequence.ForeColor = System.Drawing.Color.Green
        Me.lblSequence.Location = New System.Drawing.Point(308, 18)
        Me.lblSequence.Name = "lblSequence"
        Me.lblSequence.Size = New System.Drawing.Size(128, 22)
        Me.lblSequence.TabIndex = 2
        Me.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSNo
        '
        Me.txtSNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSNo.Location = New System.Drawing.Point(106, 19)
        Me.txtSNo.Name = "txtSNo"
        Me.txtSNo.ReadOnly = True
        Me.txtSNo.Size = New System.Drawing.Size(64, 22)
        Me.txtSNo.TabIndex = 0
        Me.txtSNo.TabStop = False
        Me.txtSNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(213, 243)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 13)
        Me.Label22.TabIndex = 172
        Me.Label22.Text = "Press F1 to get Tests List"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(38, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 171
        Me.Label14.Text = "Test Code"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(106, 237)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 24)
        Me.txtCode.TabIndex = 21
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHospital
        '
        Me.txtHospital.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospital.ForeColor = System.Drawing.Color.Blue
        Me.txtHospital.Location = New System.Drawing.Point(106, 207)
        Me.txtHospital.Name = "txtHospital"
        Me.txtHospital.Size = New System.Drawing.Size(293, 22)
        Me.txtHospital.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 169
        Me.Label10.Text = "Hospital"
        '
        'txtPanel
        '
        Me.txtPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanel.ForeColor = System.Drawing.Color.Blue
        Me.txtPanel.Location = New System.Drawing.Point(570, 108)
        Me.txtPanel.Name = "txtPanel"
        Me.txtPanel.Size = New System.Drawing.Size(163, 22)
        Me.txtPanel.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(479, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 164
        Me.Label8.Text = "Pannel EMP #"
        '
        'txtSlip
        '
        Me.txtSlip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlip.ForeColor = System.Drawing.Color.Blue
        Me.txtSlip.Location = New System.Drawing.Point(341, 109)
        Me.txtSlip.Name = "txtSlip"
        Me.txtSlip.Size = New System.Drawing.Size(131, 22)
        Me.txtSlip.TabIndex = 13
        Me.txtSlip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(246, 114)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 13)
        Me.Label19.TabIndex = 162
        Me.Label19.Text = "Mannual Slip #"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(329, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 160
        Me.Label18.Text = "Day"
        '
        'txtDay
        '
        Me.txtDay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.ForeColor = System.Drawing.Color.Blue
        Me.txtDay.Location = New System.Drawing.Point(277, 78)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(46, 22)
        Me.txtDay.TabIndex = 10
        Me.txtDay.Text = "00"
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(243, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 158
        Me.Label17.Text = "Mth"
        '
        'txtMth
        '
        Me.txtMth.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMth.ForeColor = System.Drawing.Color.Blue
        Me.txtMth.Location = New System.Drawing.Point(191, 78)
        Me.txtMth.Name = "txtMth"
        Me.txtMth.Size = New System.Drawing.Size(46, 22)
        Me.txtMth.TabIndex = 9
        Me.txtMth.Text = "00"
        Me.txtMth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(160, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 157
        Me.Label16.Text = "Yrs"
        '
        'txtYrs
        '
        Me.txtYrs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtYrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrs.ForeColor = System.Drawing.Color.Blue
        Me.txtYrs.Location = New System.Drawing.Point(106, 78)
        Me.txtYrs.Name = "txtYrs"
        Me.txtYrs.Size = New System.Drawing.Size(47, 22)
        Me.txtYrs.TabIndex = 8
        Me.txtYrs.Text = "00"
        Me.txtYrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.Blue
        Me.txtContact.Location = New System.Drawing.Point(570, 78)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(163, 22)
        Me.txtContact.TabIndex = 11
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(504, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Contact #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Patient Age"
        '
        'lblSex
        '
        Me.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Blue
        Me.lblSex.Location = New System.Drawing.Point(637, 48)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(96, 22)
        Me.lblSex.TabIndex = 7
        Me.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.ForeColor = System.Drawing.Color.Blue
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"B/O", "Baby", "D/O", "F/O", "M/O", "Master", "Miss.", "Mr.", "Mrs.", "Ms.", "S/O", "Sis/O", "W/O", "Wid/O"})
        Me.cmbTitle.Location = New System.Drawing.Point(106, 48)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(111, 23)
        Me.cmbTitle.Sorted = True
        Me.cmbTitle.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(587, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Gender"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Blue
        Me.txtName.Location = New System.Drawing.Point(227, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(348, 22)
        Me.txtName.TabIndex = 6
        Me.txtName.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Patient Name"
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTime.Location = New System.Drawing.Point(636, 18)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(97, 22)
        Me.txtTime.TabIndex = 4
        Me.txtTime.TabStop = False
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Time"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDate.Location = New System.Drawing.Point(475, 18)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 3
        Me.txtDate.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(438, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Date"
        '
        'txtRecNo
        '
        Me.txtRecNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRecNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtRecNo.Location = New System.Drawing.Point(191, 18)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.ReadOnly = True
        Me.txtRecNo.Size = New System.Drawing.Size(111, 22)
        Me.txtRecNo.TabIndex = 1
        Me.txtRecNo.TabStop = False
        Me.txtRecNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Patient ID #"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(172, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 25)
        Me.Label23.TabIndex = 178
        Me.Label23.Text = "/"
        '
        'lblDues
        '
        Me.lblDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDues.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDues.Location = New System.Drawing.Point(884, 76)
        Me.lblDues.Name = "lblDues"
        Me.lblDues.Size = New System.Drawing.Size(91, 19)
        Me.lblDues.TabIndex = 24
        Me.lblDues.Text = "00"
        Me.lblDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(806, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "Amount Due"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(804, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 139
        Me.Label12.Text = "Amount Paid"
        '
        'txtPaid
        '
        Me.txtPaid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtPaid.Location = New System.Drawing.Point(884, 102)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(91, 22)
        Me.txtPaid.TabIndex = 25
        Me.txtPaid.Text = "00"
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(800, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "Total Amount"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(810, 50)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 13)
        Me.Label24.TabIndex = 143
        Me.Label24.Text = "Concession"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtDiscount.Location = New System.Drawing.Point(884, 46)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(91, 22)
        Me.txtDiscount.TabIndex = 23
        Me.txtDiscount.Text = "00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(884, 18)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(91, 22)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.Text = "00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOper
        '
        Me.lblOper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOper.Location = New System.Drawing.Point(792, 194)
        Me.lblOper.Name = "lblOper"
        Me.lblOper.Size = New System.Drawing.Size(183, 25)
        Me.lblOper.TabIndex = 149
        Me.lblOper.Text = "operator"
        Me.lblOper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStatus
        '
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(792, 228)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(183, 25)
        Me.txtStatus.TabIndex = 150
        Me.txtStatus.Text = "NORMAL"
        Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(794, 137)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 13)
        Me.Label25.TabIndex = 151
        Me.Label25.Text = "Complimentary"
        '
        'txtCompli
        '
        Me.txtCompli.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCompli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompli.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtCompli.Location = New System.Drawing.Point(884, 131)
        Me.txtCompli.Name = "txtCompli"
        Me.txtCompli.Size = New System.Drawing.Size(91, 22)
        Me.txtCompli.TabIndex = 26
        Me.txtCompli.Text = "00"
        Me.txtCompli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPAmount
        '
        Me.txtPAmount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAmount.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtPAmount.Location = New System.Drawing.Point(884, 161)
        Me.txtPAmount.Name = "txtPAmount"
        Me.txtPAmount.Size = New System.Drawing.Size(91, 22)
        Me.txtPAmount.TabIndex = 27
        Me.txtPAmount.Text = "00"
        Me.txtPAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(836, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 153
        Me.Label15.Text = "Pannel"
        '
        'TestListView
        '
        Me.TestListView.BackColor = System.Drawing.Color.DarkGray
        Me.TestListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.TestListView.ForeColor = System.Drawing.Color.Maroon
        Me.TestListView.FullRowSelect = True
        Me.TestListView.GridLines = True
        Me.TestListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.TestListView.Location = New System.Drawing.Point(13, 303)
        Me.TestListView.MultiSelect = False
        Me.TestListView.Name = "TestListView"
        Me.TestListView.Size = New System.Drawing.Size(755, 214)
        Me.TestListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.TestListView.TabIndex = 154
        Me.TestListView.TabStop = False
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
        Me.ColumnHeader4.Text = "REPORT DATE"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MODE"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 68
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "RATE"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 84
        '
        'cmdPaid
        '
        Me.cmdPaid.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPaid.Image = Global.Business_Solutions.My.Resources.Resources.if_edit_1730021
        Me.cmdPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPaid.Location = New System.Drawing.Point(789, 318)
        Me.cmdPaid.Name = "cmdPaid"
        Me.cmdPaid.Size = New System.Drawing.Size(189, 28)
        Me.cmdPaid.TabIndex = 29
        Me.cmdPaid.Text = "&Made Payment"
        Me.cmdPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPaid.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = Global.Business_Solutions.My.Resources.Resources.remove
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(790, 352)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(189, 28)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "&Cancel Case"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdComp
        '
        Me.cmdComp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdComp.Enabled = False
        Me.cmdComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComp.Image = Global.Business_Solutions.My.Resources.Resources.if_icon_edit_314724
        Me.cmdComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdComp.Location = New System.Drawing.Point(789, 386)
        Me.cmdComp.Name = "cmdComp"
        Me.cmdComp.Size = New System.Drawing.Size(189, 28)
        Me.cmdComp.TabIndex = 31
        Me.cmdComp.Text = "&Complimentary"
        Me.cmdComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdComp.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.application_remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(791, 489)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(189, 28)
        Me.cmdClose.TabIndex = 34
        Me.cmdClose.Text = "&Close Edit"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(791, 454)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(189, 28)
        Me.cmdSave.TabIndex = 33
        Me.cmdSave.Text = "&Update Record"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = Global.Business_Solutions.My.Resources.Resources.search1
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFind.Location = New System.Drawing.Point(790, 284)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(189, 28)
        Me.cmdFind.TabIndex = 28
        Me.cmdFind.Text = "&Find Record"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFind.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(790, 420)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(189, 28)
        Me.cmdDelete.TabIndex = 32
        Me.cmdDelete.Text = "&Delete Test Parameter"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'EditPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(996, 537)
        Me.Controls.Add(Me.cmdPaid)
        Me.Controls.Add(Me.TestListView)
        Me.Controls.Add(Me.txtPAmount)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCompli)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdComp)
        Me.Controls.Add(Me.lblOper)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblDues)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdDelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1002, 565)
        Me.Name = "EditPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Record"
        CType(Me.GridBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridBinding As System.Windows.Forms.BindingSource
    Friend WithEvents GridDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtHospital As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPanel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSlip As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMth As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtYrs As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRecNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDues As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblOper As System.Windows.Forms.Label
    Friend WithEvents cmdComp As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtStatus As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCompli As System.Windows.Forms.TextBox
    Friend WithEvents txtSNo As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtPAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblSequence As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCNIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbCollPoint As System.Windows.Forms.ComboBox
    Friend WithEvents txtCollPoint As System.Windows.Forms.TextBox
    Friend WithEvents cmbDoctors As System.Windows.Forms.ComboBox
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cmbVisitor As System.Windows.Forms.ComboBox
    Friend WithEvents TestListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSRefer As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmdPaid As System.Windows.Forms.Button
End Class
