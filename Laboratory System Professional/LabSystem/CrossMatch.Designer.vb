<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrossMatch
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrossMatch))
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.lblPSex = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtYrs = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtDName = New System.Windows.Forms.TextBox
        Me.cmbDTitle = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDYrs = New System.Windows.Forms.TextBox
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
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtDay = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMth = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCNIC = New System.Windows.Forms.MaskedTextBox
        Me.cmbCollPoint = New System.Windows.Forms.ComboBox
        Me.txtCollPoint = New System.Windows.Forms.TextBox
        Me.txtRefer = New System.Windows.Forms.TextBox
        Me.lblSno = New System.Windows.Forms.Label
        Me.txtRecNo = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DonorDataGrid = New System.Windows.Forms.DataGridView
        Me.DONOR_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DONOR_PID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DONOR_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdLSlip = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.TestListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(47, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "Patient Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtName.Location = New System.Drawing.Point(255, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(259, 26)
        Me.txtName.TabIndex = 1
        Me.txtName.WordWrap = False
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.SystemColors.Control
        Me.cmbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"B/O", "Baby", "D/O", "F/O", "M/O", "Master", "Miss.", "Mr.", "Mrs.", "Ms.", "S/O", "Sis/O", "W/O", "Wid/O"})
        Me.cmbTitle.Location = New System.Drawing.Point(138, 29)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(111, 24)
        Me.cmbTitle.Sorted = True
        Me.cmbTitle.TabIndex = 0
        '
        'lblPSex
        '
        Me.lblPSex.BackColor = System.Drawing.SystemColors.Control
        Me.lblPSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPSex.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPSex.Location = New System.Drawing.Point(380, 59)
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
        Me.Label6.Location = New System.Drawing.Point(57, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Patient Age"
        '
        'txtYrs
        '
        Me.txtYrs.BackColor = System.Drawing.SystemColors.Control
        Me.txtYrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrs.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtYrs.Location = New System.Drawing.Point(138, 59)
        Me.txtYrs.Name = "txtYrs"
        Me.txtYrs.Size = New System.Drawing.Size(32, 24)
        Me.txtYrs.TabIndex = 2
        Me.txtYrs.Text = "00"
        Me.txtYrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(173, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 13)
        Me.Label16.TabIndex = 203
        Me.Label16.Text = "Y."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 189)
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
        Me.Label10.Location = New System.Drawing.Point(57, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 207
        Me.Label10.Text = "Reffered by"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(53, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 13)
        Me.Label20.TabIndex = 210
        Me.Label20.Text = "Donor Name"
        '
        'txtDName
        '
        Me.txtDName.BackColor = System.Drawing.SystemColors.Control
        Me.txtDName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDName.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDName.Location = New System.Drawing.Point(255, 87)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.Size = New System.Drawing.Size(258, 26)
        Me.txtDName.TabIndex = 8
        '
        'cmbDTitle
        '
        Me.cmbDTitle.BackColor = System.Drawing.SystemColors.Control
        Me.cmbDTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmbDTitle.FormattingEnabled = True
        Me.cmbDTitle.Items.AddRange(New Object() {"B/O", "Baby", "D/O", "F/O", "M/O", "Master", "Miss.", "Mr.", "Mrs.", "Ms.", "S/O", "Sis/O", "W/O", "Wid/O"})
        Me.cmbDTitle.Location = New System.Drawing.Point(138, 88)
        Me.cmbDTitle.Name = "cmbDTitle"
        Me.cmbDTitle.Size = New System.Drawing.Size(111, 24)
        Me.cmbDTitle.Sorted = True
        Me.cmbDTitle.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(63, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Donor Age"
        '
        'txtDYrs
        '
        Me.txtDYrs.BackColor = System.Drawing.SystemColors.Control
        Me.txtDYrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDYrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDYrs.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDYrs.Location = New System.Drawing.Point(138, 119)
        Me.txtDYrs.Name = "txtDYrs"
        Me.txtDYrs.Size = New System.Drawing.Size(47, 24)
        Me.txtDYrs.TabIndex = 9
        Me.txtDYrs.Text = "00"
        Me.txtDYrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDSex
        '
        Me.lblDSex.BackColor = System.Drawing.SystemColors.Control
        Me.lblDSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSex.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDSex.Location = New System.Drawing.Point(519, 89)
        Me.lblDSex.Name = "lblDSex"
        Me.lblDSex.Size = New System.Drawing.Size(96, 22)
        Me.lblDSex.TabIndex = 241
        Me.lblDSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(193, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "Yrs"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.SystemColors.Control
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtCode.Location = New System.Drawing.Point(138, 215)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 26)
        Me.txtCode.TabIndex = 17
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(20, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 13)
        Me.Label14.TabIndex = 218
        Me.Label14.Text = "Select C. M. Code"
        '
        'cmbVisitor
        '
        Me.cmbVisitor.BackColor = System.Drawing.SystemColors.Control
        Me.cmbVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVisitor.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmbVisitor.FormattingEnabled = True
        Me.cmbVisitor.Items.AddRange(New Object() {"NIL", "OUTSIDE"})
        Me.cmbVisitor.Location = New System.Drawing.Point(443, 214)
        Me.cmbVisitor.Name = "cmbVisitor"
        Me.cmbVisitor.Size = New System.Drawing.Size(173, 24)
        Me.cmbVisitor.Sorted = True
        Me.cmbVisitor.TabIndex = 18
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(360, 220)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(79, 13)
        Me.Label43.TabIndex = 219
        Me.Label43.Text = "Phlebotomist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(635, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Paid"
        '
        'txtPaid
        '
        Me.txtPaid.BackColor = System.Drawing.SystemColors.Control
        Me.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.ForeColor = System.Drawing.Color.Red
        Me.txtPaid.Location = New System.Drawing.Point(638, 77)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(93, 21)
        Me.txtPaid.TabIndex = 20
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(635, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 222
        Me.Label8.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Red
        Me.txtDiscount.Location = New System.Drawing.Point(638, 123)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(93, 21)
        Me.txtDiscount.TabIndex = 21
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(638, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 224
        Me.Label11.Text = "Dues"
        '
        'txtDues
        '
        Me.txtDues.BackColor = System.Drawing.SystemColors.Control
        Me.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDues.ForeColor = System.Drawing.Color.Red
        Me.txtDues.Location = New System.Drawing.Point(638, 216)
        Me.txtDues.Name = "txtDues"
        Me.txtDues.Size = New System.Drawing.Size(93, 21)
        Me.txtDues.TabIndex = 23
        Me.txtDues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(635, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 226
        Me.Label12.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Location = New System.Drawing.Point(638, 32)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(93, 21)
        Me.txtTotal.TabIndex = 19
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDate.Location = New System.Drawing.Point(482, 58)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(133, 24)
        Me.txtDate.TabIndex = 6
        Me.txtDate.TabStop = False
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(635, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 230
        Me.Label13.Text = "Complimentary"
        '
        'txtCompli
        '
        Me.txtCompli.BackColor = System.Drawing.SystemColors.Control
        Me.txtCompli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompli.ForeColor = System.Drawing.Color.Red
        Me.txtCompli.Location = New System.Drawing.Point(638, 172)
        Me.txtCompli.Name = "txtCompli"
        Me.txtCompli.Size = New System.Drawing.Size(93, 21)
        Me.txtCompli.TabIndex = 22
        Me.txtCompli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtDay)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtMth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCNIC)
        Me.GroupBox1.Controls.Add(Me.cmbCollPoint)
        Me.GroupBox1.Controls.Add(Me.txtCollPoint)
        Me.GroupBox1.Controls.Add(Me.txtRefer)
        Me.GroupBox1.Controls.Add(Me.lblSno)
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
        Me.GroupBox1.Controls.Add(Me.txtDYrs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDTitle)
        Me.GroupBox1.Controls.Add(Me.txtDName)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtYrs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPSex)
        Me.GroupBox1.Controls.Add(Me.cmbTitle)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 254)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(291, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 245
        Me.Label18.Text = "Day"
        '
        'txtDay
        '
        Me.txtDay.BackColor = System.Drawing.SystemColors.Control
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDay.Location = New System.Drawing.Point(255, 59)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(32, 24)
        Me.txtDay.TabIndex = 4
        Me.txtDay.Text = "00"
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(230, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 13)
        Me.Label17.TabIndex = 244
        Me.Label17.Text = "M"
        '
        'txtMth
        '
        Me.txtMth.BackColor = System.Drawing.SystemColors.Control
        Me.txtMth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMth.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtMth.Location = New System.Drawing.Point(196, 60)
        Me.txtMth.Name = "txtMth"
        Me.txtMth.Size = New System.Drawing.Size(32, 24)
        Me.txtMth.TabIndex = 3
        Me.txtMth.Text = "00"
        Me.txtMth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(241, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "Mob. #"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.SystemColors.Control
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtContact.Location = New System.Drawing.Point(295, 119)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(133, 24)
        Me.txtContact.TabIndex = 10
        Me.txtContact.TabStop = False
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.search1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(583, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox1.TabIndex = 238
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(428, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 237
        Me.Label15.Text = "CNIC #"
        '
        'txtCNIC
        '
        Me.txtCNIC.BackColor = System.Drawing.SystemColors.Control
        Me.txtCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNIC.Location = New System.Drawing.Point(482, 119)
        Me.txtCNIC.Mask = "99999-9999999-9"
        Me.txtCNIC.Name = "txtCNIC"
        Me.txtCNIC.Size = New System.Drawing.Size(133, 24)
        Me.txtCNIC.TabIndex = 11
        '
        'cmbCollPoint
        '
        Me.cmbCollPoint.BackColor = System.Drawing.SystemColors.Control
        Me.cmbCollPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCollPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCollPoint.ForeColor = System.Drawing.Color.Black
        Me.cmbCollPoint.FormattingEnabled = True
        Me.cmbCollPoint.Items.AddRange(New Object() {"LAB"})
        Me.cmbCollPoint.Location = New System.Drawing.Point(138, 184)
        Me.cmbCollPoint.Name = "cmbCollPoint"
        Me.cmbCollPoint.Size = New System.Drawing.Size(231, 24)
        Me.cmbCollPoint.Sorted = True
        Me.cmbCollPoint.TabIndex = 14
        Me.cmbCollPoint.Text = "Select Collection Point"
        '
        'txtCollPoint
        '
        Me.txtCollPoint.BackColor = System.Drawing.SystemColors.Control
        Me.txtCollPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollPoint.ForeColor = System.Drawing.Color.Black
        Me.txtCollPoint.Location = New System.Drawing.Point(375, 184)
        Me.txtCollPoint.Name = "txtCollPoint"
        Me.txtCollPoint.ReadOnly = True
        Me.txtCollPoint.Size = New System.Drawing.Size(240, 24)
        Me.txtCollPoint.TabIndex = 16
        Me.txtCollPoint.Text = "LAB"
        '
        'txtRefer
        '
        Me.txtRefer.BackColor = System.Drawing.SystemColors.Control
        Me.txtRefer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefer.ForeColor = System.Drawing.Color.Black
        Me.txtRefer.Location = New System.Drawing.Point(138, 151)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(446, 24)
        Me.txtRefer.TabIndex = 15
        Me.txtRefer.Text = "SELF"
        '
        'lblSno
        '
        Me.lblSno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSno.Location = New System.Drawing.Point(587, 29)
        Me.lblSno.Name = "lblSno"
        Me.lblSno.Size = New System.Drawing.Size(29, 22)
        Me.lblSno.TabIndex = 231
        Me.lblSno.Text = "00"
        Me.lblSno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRecNo
        '
        Me.txtRecNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRecNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRecNo.Location = New System.Drawing.Point(521, 29)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.Size = New System.Drawing.Size(60, 22)
        Me.txtRecNo.TabIndex = 143
        Me.txtRecNo.Text = "00000"
        Me.txtRecNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "DONOR_TABLE"
        '
        'DonorDataGrid
        '
        Me.DonorDataGrid.AllowUserToAddRows = False
        Me.DonorDataGrid.AllowUserToDeleteRows = False
        Me.DonorDataGrid.AllowUserToResizeColumns = False
        Me.DonorDataGrid.AllowUserToResizeRows = False
        Me.DonorDataGrid.AutoGenerateColumns = False
        Me.DonorDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DonorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DonorDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DonorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DonorDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DONOR_ID, Me.DONOR_PID, Me.DONOR_NAME})
        Me.DonorDataGrid.DataMember = "donor_table"
        Me.DonorDataGrid.DataSource = Me.BindingSource1
        Me.DonorDataGrid.GridColor = System.Drawing.Color.Gray
        Me.DonorDataGrid.Location = New System.Drawing.Point(12, 401)
        Me.DonorDataGrid.Name = "DonorDataGrid"
        Me.DonorDataGrid.ReadOnly = True
        Me.DonorDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DonorDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DonorDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DonorDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DonorDataGrid.Size = New System.Drawing.Size(752, 105)
        Me.DonorDataGrid.TabIndex = 24
        '
        'DONOR_ID
        '
        Me.DONOR_ID.DataPropertyName = "DONOR_ID"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DONOR_ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.DONOR_ID.HeaderText = "DONOR ID"
        Me.DONOR_ID.Name = "DONOR_ID"
        Me.DONOR_ID.ReadOnly = True
        Me.DONOR_ID.Width = 127
        '
        'DONOR_PID
        '
        Me.DONOR_PID.DataPropertyName = "DONOR_PID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DONOR_PID.DefaultCellStyle = DataGridViewCellStyle2
        Me.DONOR_PID.HeaderText = "DONOR PID"
        Me.DONOR_PID.Name = "DONOR_PID"
        Me.DONOR_PID.ReadOnly = True
        '
        'DONOR_NAME
        '
        Me.DONOR_NAME.DataPropertyName = "DONOR_NAME"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DONOR_NAME.DefaultCellStyle = DataGridViewCellStyle3
        Me.DONOR_NAME.HeaderText = "DONOR NAME"
        Me.DONOR_NAME.Name = "DONOR_NAME"
        Me.DONOR_NAME.ReadOnly = True
        Me.DONOR_NAME.Width = 482
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(220, 516)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(100, 28)
        Me.cmdDelete.TabIndex = 27
        Me.cmdDelete.Text = "&Delete Test"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = False
        Me.cmdDelete.Visible = False
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
        Me.cmdSave.Enabled = False
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(548, 516)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(106, 28)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdLSlip
        '
        Me.cmdLSlip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdLSlip.Enabled = False
        Me.cmdLSlip.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLSlip.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.cmdLSlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLSlip.Location = New System.Drawing.Point(437, 516)
        Me.cmdLSlip.Name = "cmdLSlip"
        Me.cmdLSlip.Size = New System.Drawing.Size(106, 28)
        Me.cmdLSlip.TabIndex = 28
        Me.cmdLSlip.Text = "&Lab Slip"
        Me.cmdLSlip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLSlip.UseVisualStyleBackColor = False
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = Global.Business_Solutions.My.Resources.Resources.search1
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFind.Location = New System.Drawing.Point(116, 516)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(100, 28)
        Me.cmdFind.TabIndex = 26
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
        Me.cmdNew.TabIndex = 25
        Me.cmdNew.Text = "&New Entry"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'TestListView
        '
        Me.TestListView.BackColor = System.Drawing.Color.Silver
        Me.TestListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TestListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.TestListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestListView.ForeColor = System.Drawing.Color.Maroon
        Me.TestListView.FullRowSelect = True
        Me.TestListView.GridLines = True
        Me.TestListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.TestListView.Location = New System.Drawing.Point(12, 267)
        Me.TestListView.MultiSelect = False
        Me.TestListView.Name = "TestListView"
        Me.TestListView.Size = New System.Drawing.Size(752, 128)
        Me.TestListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.TestListView.TabIndex = 141
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
        Me.ColumnHeader6.Width = 83
        '
        'CrossMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.TestListView)
        Me.Controls.Add(Me.DonorDataGrid)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdLSlip)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CrossMatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cross Match Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdLSlip As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblPSex As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYrs As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents cmbDTitle As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDYrs As System.Windows.Forms.TextBox
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
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DonorDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents lblSno As System.Windows.Forms.Label
    Friend WithEvents cmbCollPoint As System.Windows.Forms.ComboBox
    Friend WithEvents txtCollPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCNIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TestListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DONOR_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DONOR_PID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DONOR_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMth As System.Windows.Forms.TextBox
End Class
