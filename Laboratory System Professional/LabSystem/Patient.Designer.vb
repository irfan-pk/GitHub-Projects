<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient))
        Me.GridBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridDataSet = New System.Data.DataSet
        Me.TestListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtPAmount = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtCompli = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblDues = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPaid = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtSRefer = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblSequence = New System.Windows.Forms.Label
        Me.txtHospital = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCNIC = New System.Windows.Forms.MaskedTextBox
        Me.cmbCollPoint = New System.Windows.Forms.ComboBox
        Me.txtCollPoint = New System.Windows.Forms.TextBox
        Me.txtSNo = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.cmbVisitor = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
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
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtRefer = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblOperator = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDeliver = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdLSlip = New System.Windows.Forms.Button
        Me.cmdPSlip = New System.Windows.Forms.Button
        CType(Me.GridBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        '
        'TestListView
        '
        Me.TestListView.BackColor = System.Drawing.Color.Silver
        Me.TestListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.TestListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestListView.ForeColor = System.Drawing.Color.Maroon
        Me.TestListView.FullRowSelect = True
        Me.TestListView.GridLines = True
        Me.TestListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.TestListView.Location = New System.Drawing.Point(7, 314)
        Me.TestListView.MultiSelect = False
        Me.TestListView.Name = "TestListView"
        Me.TestListView.Size = New System.Drawing.Size(752, 177)
        Me.TestListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.TestListView.TabIndex = 140
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
        Me.ColumnHeader4.Text = "REPORT DAY"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ETA"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 68
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "RATE"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 80
        '
        'lblRemarks
        '
        Me.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.ForeColor = System.Drawing.Color.DimGray
        Me.lblRemarks.Location = New System.Drawing.Point(7, 504)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(752, 29)
        Me.lblRemarks.TabIndex = 140
        Me.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label45)
        Me.Panel4.Controls.Add(Me.txtPAmount)
        Me.Panel4.Controls.Add(Me.Label46)
        Me.Panel4.Controls.Add(Me.txtCompli)
        Me.Panel4.Controls.Add(Me.txtDiscount)
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Controls.Add(Me.lblTotal)
        Me.Panel4.Controls.Add(Me.lblDues)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.txtPaid)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(767, 315)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(218, 218)
        Me.Panel4.TabIndex = 16
        Me.Panel4.TabStop = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(18, 187)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(92, 13)
        Me.Label45.TabIndex = 153
        Me.Label45.Text = "Pannel Amount"
        '
        'txtPAmount
        '
        Me.txtPAmount.BackColor = System.Drawing.SystemColors.Control
        Me.txtPAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAmount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPAmount.Location = New System.Drawing.Point(112, 180)
        Me.txtPAmount.Name = "txtPAmount"
        Me.txtPAmount.Size = New System.Drawing.Size(92, 26)
        Me.txtPAmount.TabIndex = 21
        Me.txtPAmount.Text = "00"
        Me.txtPAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(22, 118)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(88, 13)
        Me.Label46.TabIndex = 151
        Me.Label46.Text = "Complimentary"
        '
        'txtCompli
        '
        Me.txtCompli.BackColor = System.Drawing.SystemColors.Control
        Me.txtCompli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompli.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.txtCompli.Location = New System.Drawing.Point(112, 111)
        Me.txtCompli.Name = "txtCompli"
        Me.txtCompli.Size = New System.Drawing.Size(92, 26)
        Me.txtCompli.TabIndex = 19
        Me.txtCompli.Text = "00"
        Me.txtCompli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDiscount.Location = New System.Drawing.Point(112, 45)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(92, 26)
        Me.txtDiscount.TabIndex = 17
        Me.txtDiscount.Text = "00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(38, 52)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(72, 13)
        Me.Label44.TabIndex = 150
        Me.Label44.Text = "Concession"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotal.Location = New System.Drawing.Point(112, 12)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(92, 26)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDues
        '
        Me.lblDues.BackColor = System.Drawing.SystemColors.Control
        Me.lblDues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDues.ForeColor = System.Drawing.Color.Red
        Me.lblDues.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDues.Location = New System.Drawing.Point(112, 145)
        Me.lblDues.Name = "lblDues"
        Me.lblDues.Size = New System.Drawing.Size(92, 27)
        Me.lblDues.TabIndex = 20
        Me.lblDues.Text = "00"
        Me.lblDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(34, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "Amount Due"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(32, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "Amount Paid"
        '
        'txtPaid
        '
        Me.txtPaid.BackColor = System.Drawing.SystemColors.Control
        Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPaid.Location = New System.Drawing.Point(112, 77)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(92, 26)
        Me.txtPaid.TabIndex = 18
        Me.txtPaid.Text = "00"
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(28, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Total Amount"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtSRefer)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.lblSequence)
        Me.Panel1.Controls.Add(Me.txtHospital)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtCNIC)
        Me.Panel1.Controls.Add(Me.cmbCollPoint)
        Me.Panel1.Controls.Add(Me.txtCollPoint)
        Me.Panel1.Controls.Add(Me.txtSNo)
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Controls.Add(Me.cmbVisitor)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
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
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtRefer)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(5, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 292)
        Me.Panel1.TabIndex = 142
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.search1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(704, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox1.TabIndex = 193
        Me.PictureBox1.TabStop = False
        '
        'txtSRefer
        '
        Me.txtSRefer.BackColor = System.Drawing.SystemColors.Control
        Me.txtSRefer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSRefer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRefer.ForeColor = System.Drawing.Color.Black
        Me.txtSRefer.Location = New System.Drawing.Point(498, 219)
        Me.txtSRefer.Name = "txtSRefer"
        Me.txtSRefer.Size = New System.Drawing.Size(238, 24)
        Me.txtSRefer.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(408, 225)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 192
        Me.Label23.Text = "Special Refer"
        '
        'lblSequence
        '
        Me.lblSequence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequence.ForeColor = System.Drawing.Color.Blue
        Me.lblSequence.Location = New System.Drawing.Point(281, 9)
        Me.lblSequence.Name = "lblSequence"
        Me.lblSequence.Size = New System.Drawing.Size(148, 25)
        Me.lblSequence.TabIndex = 190
        Me.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHospital
        '
        Me.txtHospital.BackColor = System.Drawing.SystemColors.Control
        Me.txtHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHospital.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospital.ForeColor = System.Drawing.Color.Black
        Me.txtHospital.Location = New System.Drawing.Point(95, 219)
        Me.txtHospital.Name = "txtHospital"
        Me.txtHospital.Size = New System.Drawing.Size(307, 24)
        Me.txtHospital.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(35, 225)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 13)
        Me.Label21.TabIndex = 189
        Me.Label21.Text = "Hospital"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(40, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 187
        Me.Label15.Text = "CNIC #"
        '
        'txtCNIC
        '
        Me.txtCNIC.BackColor = System.Drawing.SystemColors.Control
        Me.txtCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNIC.Location = New System.Drawing.Point(94, 114)
        Me.txtCNIC.Mask = "99999-9999999-9"
        Me.txtCNIC.Name = "txtCNIC"
        Me.txtCNIC.Size = New System.Drawing.Size(133, 24)
        Me.txtCNIC.TabIndex = 6
        '
        'cmbCollPoint
        '
        Me.cmbCollPoint.BackColor = System.Drawing.SystemColors.Control
        Me.cmbCollPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCollPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCollPoint.ForeColor = System.Drawing.Color.Black
        Me.cmbCollPoint.FormattingEnabled = True
        Me.cmbCollPoint.Items.AddRange(New Object() {"LAB"})
        Me.cmbCollPoint.Location = New System.Drawing.Point(95, 185)
        Me.cmbCollPoint.Name = "cmbCollPoint"
        Me.cmbCollPoint.Size = New System.Drawing.Size(308, 24)
        Me.cmbCollPoint.Sorted = True
        Me.cmbCollPoint.TabIndex = 11
        Me.cmbCollPoint.Text = "Select Referenced Collecton Point"
        '
        'txtCollPoint
        '
        Me.txtCollPoint.BackColor = System.Drawing.SystemColors.Control
        Me.txtCollPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollPoint.ForeColor = System.Drawing.Color.Black
        Me.txtCollPoint.Location = New System.Drawing.Point(409, 185)
        Me.txtCollPoint.Name = "txtCollPoint"
        Me.txtCollPoint.ReadOnly = True
        Me.txtCollPoint.Size = New System.Drawing.Size(327, 24)
        Me.txtCollPoint.TabIndex = 12
        Me.txtCollPoint.Text = "LAB"
        '
        'txtSNo
        '
        Me.txtSNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtSNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSNo.Location = New System.Drawing.Point(94, 9)
        Me.txtSNo.Name = "txtSNo"
        Me.txtSNo.ReadOnly = True
        Me.txtSNo.Size = New System.Drawing.Size(48, 24)
        Me.txtSNo.TabIndex = 176
        Me.txtSNo.TabStop = False
        Me.txtSNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(413, 258)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(79, 13)
        Me.Label43.TabIndex = 175
        Me.Label43.Text = "Phlebotomist"
        '
        'cmbVisitor
        '
        Me.cmbVisitor.BackColor = System.Drawing.SystemColors.Control
        Me.cmbVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVisitor.ForeColor = System.Drawing.Color.Black
        Me.cmbVisitor.FormattingEnabled = True
        Me.cmbVisitor.Items.AddRange(New Object() {"LAB", "NIL", "OUTSIDE"})
        Me.cmbVisitor.Location = New System.Drawing.Point(498, 252)
        Me.cmbVisitor.Name = "cmbVisitor"
        Me.cmbVisitor.Size = New System.Drawing.Size(238, 24)
        Me.cmbVisitor.Sorted = True
        Me.cmbVisitor.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(199, 258)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 13)
        Me.Label22.TabIndex = 172
        Me.Label22.Text = "Press F2 to Get Tests List"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(23, 258)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 171
        Me.Label14.Text = "Test Code"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.SystemColors.Control
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(95, 252)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 24)
        Me.txtCode.TabIndex = 15
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 169
        Me.Label10.Text = "Collection By"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(33, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Refer by"
        '
        'txtPanel
        '
        Me.txtPanel.BackColor = System.Drawing.SystemColors.Control
        Me.txtPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanel.ForeColor = System.Drawing.Color.Black
        Me.txtPanel.Location = New System.Drawing.Point(593, 112)
        Me.txtPanel.Name = "txtPanel"
        Me.txtPanel.Size = New System.Drawing.Size(143, 24)
        Me.txtPanel.TabIndex = 8
        Me.txtPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(498, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 164
        Me.Label8.Text = "Pannel EMP #"
        '
        'txtSlip
        '
        Me.txtSlip.BackColor = System.Drawing.SystemColors.Control
        Me.txtSlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlip.ForeColor = System.Drawing.Color.Black
        Me.txtSlip.Location = New System.Drawing.Point(327, 114)
        Me.txtSlip.Name = "txtSlip"
        Me.txtSlip.Size = New System.Drawing.Size(76, 24)
        Me.txtSlip.TabIndex = 7
        Me.txtSlip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(252, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 13)
        Me.Label19.TabIndex = 162
        Me.Label19.Text = "Mannual ID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(319, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 160
        Me.Label18.Text = "Day"
        '
        'txtDay
        '
        Me.txtDay.BackColor = System.Drawing.SystemColors.Control
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.ForeColor = System.Drawing.Color.Black
        Me.txtDay.Location = New System.Drawing.Point(267, 79)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(46, 24)
        Me.txtDay.TabIndex = 4
        Me.txtDay.Text = "00"
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(233, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 158
        Me.Label17.Text = "Mth"
        '
        'txtMth
        '
        Me.txtMth.BackColor = System.Drawing.SystemColors.Control
        Me.txtMth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMth.ForeColor = System.Drawing.Color.Black
        Me.txtMth.Location = New System.Drawing.Point(181, 79)
        Me.txtMth.Name = "txtMth"
        Me.txtMth.Size = New System.Drawing.Size(46, 24)
        Me.txtMth.TabIndex = 3
        Me.txtMth.Text = "00"
        Me.txtMth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(150, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 157
        Me.Label16.Text = "Yrs"
        '
        'txtYrs
        '
        Me.txtYrs.BackColor = System.Drawing.SystemColors.Control
        Me.txtYrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrs.ForeColor = System.Drawing.Color.Black
        Me.txtYrs.Location = New System.Drawing.Point(95, 79)
        Me.txtYrs.Name = "txtYrs"
        Me.txtYrs.Size = New System.Drawing.Size(47, 24)
        Me.txtYrs.TabIndex = 2
        Me.txtYrs.Text = "00"
        Me.txtYrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.SystemColors.Control
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(592, 77)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(144, 24)
        Me.txtContact.TabIndex = 5
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(523, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Contact #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Patient Age"
        '
        'lblSex
        '
        Me.lblSex.BackColor = System.Drawing.SystemColors.Control
        Me.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Black
        Me.lblSex.Location = New System.Drawing.Point(640, 43)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(96, 22)
        Me.lblSex.TabIndex = 146
        Me.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.SystemColors.Control
        Me.cmbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.ForeColor = System.Drawing.Color.Black
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"B/O", "Baby", "D/O", "F/O", "M/O", "Master", "Miss.", "Mr.", "Mrs.", "Ms.", "S/O", "Sis/O", "W/O", "Wid/O"})
        Me.cmbTitle.Location = New System.Drawing.Point(95, 43)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(111, 24)
        Me.cmbTitle.Sorted = True
        Me.cmbTitle.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(587, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Gender"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(212, 43)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(361, 24)
        Me.txtName.TabIndex = 1
        Me.txtName.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Patient Name"
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.Control
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.Black
        Me.txtTime.Location = New System.Drawing.Point(639, 8)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(97, 24)
        Me.txtTime.TabIndex = 142
        Me.txtTime.TabStop = False
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(601, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Time"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.Black
        Me.txtDate.Location = New System.Drawing.Point(473, 8)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 24)
        Me.txtDate.TabIndex = 140
        Me.txtDate.TabStop = False
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(435, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Date"
        '
        'txtRecNo
        '
        Me.txtRecNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtRecNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNo.ForeColor = System.Drawing.Color.Blue
        Me.txtRecNo.Location = New System.Drawing.Point(164, 9)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.ReadOnly = True
        Me.txtRecNo.Size = New System.Drawing.Size(111, 24)
        Me.txtRecNo.TabIndex = 138
        Me.txtRecNo.TabStop = False
        Me.txtRecNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Patient ID #"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(145, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 25)
        Me.Label20.TabIndex = 177
        Me.Label20.Text = "/"
        '
        'txtRefer
        '
        Me.txtRefer.BackColor = System.Drawing.SystemColors.Control
        Me.txtRefer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefer.ForeColor = System.Drawing.Color.Black
        Me.txtRefer.Location = New System.Drawing.Point(95, 149)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(610, 24)
        Me.txtRefer.TabIndex = 10
        Me.txtRefer.Text = "SELF"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.PatientData
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblOperator)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(765, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 292)
        Me.Panel2.TabIndex = 27
        '
        'lblOperator
        '
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.ForeColor = System.Drawing.Color.DimGray
        Me.lblOperator.Location = New System.Drawing.Point(20, 250)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(184, 29)
        Me.lblOperator.TabIndex = 139
        Me.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.application_remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(880, 548)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(106, 28)
        Me.cmdClose.TabIndex = 29
        Me.cmdClose.Text = "&Close Entry"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdSave.Enabled = False
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(760, 548)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 28)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "&Save Record"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdDeliver
        '
        Me.cmdDeliver.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdDeliver.Enabled = False
        Me.cmdDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeliver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeliver.Image = Global.Business_Solutions.My.Resources.Resources.page_process1
        Me.cmdDeliver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDeliver.Location = New System.Drawing.Point(636, 548)
        Me.cmdDeliver.Name = "cmdDeliver"
        Me.cmdDeliver.Size = New System.Drawing.Size(117, 28)
        Me.cmdDeliver.TabIndex = 28
        Me.cmdDeliver.Text = "D&eliver Report"
        Me.cmdDeliver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDeliver.UseVisualStyleBackColor = False
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = Global.Business_Solutions.My.Resources.Resources.search1
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFind.Location = New System.Drawing.Point(521, 548)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(106, 28)
        Me.cmdFind.TabIndex = 27
        Me.cmdFind.Text = "&Find Record"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFind.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = Global.Business_Solutions.My.Resources.Resources.NewDocumentHS
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(412, 548)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(100, 28)
        Me.cmdNew.TabIndex = 23
        Me.cmdNew.Text = "&New Entry"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(224, 548)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(100, 28)
        Me.cmdDelete.TabIndex = 26
        Me.cmdDelete.Text = "&Delete Test"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdLSlip
        '
        Me.cmdLSlip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLSlip.Enabled = False
        Me.cmdLSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLSlip.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.cmdLSlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLSlip.Location = New System.Drawing.Point(115, 548)
        Me.cmdLSlip.Name = "cmdLSlip"
        Me.cmdLSlip.Size = New System.Drawing.Size(100, 28)
        Me.cmdLSlip.TabIndex = 25
        Me.cmdLSlip.Text = "&Lab Slip"
        Me.cmdLSlip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLSlip.UseVisualStyleBackColor = False
        '
        'cmdPSlip
        '
        Me.cmdPSlip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdPSlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPSlip.Enabled = False
        Me.cmdPSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPSlip.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.cmdPSlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPSlip.Location = New System.Drawing.Point(6, 548)
        Me.cmdPSlip.Name = "cmdPSlip"
        Me.cmdPSlip.Size = New System.Drawing.Size(100, 28)
        Me.cmdPSlip.TabIndex = 24
        Me.cmdPSlip.Text = "&Patient Slip"
        Me.cmdPSlip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPSlip.UseVisualStyleBackColor = False
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(992, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.TestListView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDeliver)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdLSlip)
        Me.Controls.Add(Me.cmdPSlip)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(785, 485)
        Me.Name = "Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Entry"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CType(Me.GridBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdDeliver As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdLSlip As System.Windows.Forms.Button
    Friend WithEvents cmdPSlip As System.Windows.Forms.Button
    Friend WithEvents TestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TprivateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GridBinding As System.Windows.Forms.BindingSource
    Friend WithEvents GridDataSet As System.Data.DataSet
    Friend WithEvents lblOperator As System.Windows.Forms.Label
    Friend WithEvents TestListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtCompli As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDues As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtPAmount As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSequence As System.Windows.Forms.Label
    Friend WithEvents txtHospital As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCNIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbCollPoint As System.Windows.Forms.ComboBox
    Friend WithEvents txtCollPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtSNo As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cmbVisitor As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSRefer As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
