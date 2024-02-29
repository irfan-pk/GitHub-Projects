<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNationalEdit
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNationalEdit))
        Me.GridBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.TstDataGrid = New System.Windows.Forms.DataGridView
        Me.tcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblDSex = New System.Windows.Forms.Label
        Me.cmbDTitle = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.txtDName = New System.Windows.Forms.TextBox
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtDAge = New System.Windows.Forms.TextBox
        Me.lblTotal = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button
        Me.lblvisitor = New System.Windows.Forms.Label
        Me.txtDelDate = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtRefer = New System.Windows.Forms.TextBox
        Me.txtPaid = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbCP = New System.Windows.Forms.ComboBox
        Me.lblOper = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPanel = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtSlip = New System.Windows.Forms.TextBox
        Me.txtStatus = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmdComp = New System.Windows.Forms.Button
        Me.txtDay = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMth = New System.Windows.Forms.TextBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtYrs = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbTitle = New System.Windows.Forms.ComboBox
        Me.lblDues = New System.Windows.Forms.Label
        Me.lblSex = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDelTime = New System.Windows.Forms.TextBox
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRecNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCompli = New System.Windows.Forms.TextBox
        CType(Me.GridBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TstDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TstDataGrid
        '
        Me.TstDataGrid.AllowUserToAddRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.TstDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TstDataGrid.AutoGenerateColumns = False
        Me.TstDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.TstDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TstDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TstDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TstDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tcode, Me.tname, Me.trate})
        Me.TstDataGrid.DataSource = Me.GridBinding
        Me.TstDataGrid.Enabled = False
        Me.TstDataGrid.GridColor = System.Drawing.Color.Gray
        Me.TstDataGrid.Location = New System.Drawing.Point(10, 307)
        Me.TstDataGrid.Name = "TstDataGrid"
        Me.TstDataGrid.ReadOnly = True
        Me.TstDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TstDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TstDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.TstDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.TstDataGrid.Size = New System.Drawing.Size(754, 208)
        Me.TstDataGrid.TabIndex = 167
        Me.TstDataGrid.TabStop = False
        '
        'tcode
        '
        Me.tcode.DataPropertyName = "tcode"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.tcode.DefaultCellStyle = DataGridViewCellStyle2
        Me.tcode.HeaderText = "TEST CODE"
        Me.tcode.Name = "tcode"
        Me.tcode.ReadOnly = True
        Me.tcode.Width = 113
        '
        'tname
        '
        Me.tname.DataPropertyName = "tname"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.tname.DefaultCellStyle = DataGridViewCellStyle3
        Me.tname.HeaderText = "TEST NAME"
        Me.tname.Name = "tname"
        Me.tname.ReadOnly = True
        Me.tname.Width = 468
        '
        'trate
        '
        Me.trate.DataPropertyName = "trate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.trate.DefaultCellStyle = DataGridViewCellStyle4
        Me.trate.HeaderText = "RATE"
        Me.trate.Name = "trate"
        Me.trate.ReadOnly = True
        Me.trate.Width = 110
        '
        'lblDSex
        '
        Me.lblDSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSex.ForeColor = System.Drawing.Color.Blue
        Me.lblDSex.Location = New System.Drawing.Point(637, 135)
        Me.lblDSex.Name = "lblDSex"
        Me.lblDSex.Size = New System.Drawing.Size(96, 22)
        Me.lblDSex.TabIndex = 186
        Me.lblDSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbDTitle
        '
        Me.cmbDTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDTitle.ForeColor = System.Drawing.Color.Blue
        Me.cmbDTitle.FormattingEnabled = True
        Me.cmbDTitle.Items.AddRange(New Object() {"B/O", "Baby", "D/O", "F/O", "M/O", "Master", "Miss.", "Mr.", "Mrs.", "Ms.", "S/O", "Sis/O", "W/O", "Wid/O"})
        Me.cmbDTitle.Location = New System.Drawing.Point(105, 133)
        Me.cmbDTitle.Name = "cmbDTitle"
        Me.cmbDTitle.Size = New System.Drawing.Size(111, 23)
        Me.cmbDTitle.Sorted = True
        Me.cmbDTitle.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(580, 140)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 13)
        Me.Label29.TabIndex = 185
        Me.Label29.Text = "Gender"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtDiscount.Location = New System.Drawing.Point(881, 44)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(91, 22)
        Me.txtDiscount.TabIndex = 153
        Me.txtDiscount.Text = "00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.application_remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(788, 487)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(189, 28)
        Me.cmdClose.TabIndex = 160
        Me.cmdClose.Text = "&Close Edit"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'txtDName
        '
        Me.txtDName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDName.ForeColor = System.Drawing.Color.Blue
        Me.txtDName.Location = New System.Drawing.Point(226, 135)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.Size = New System.Drawing.Size(349, 22)
        Me.txtDName.TabIndex = 7
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = Global.Business_Solutions.My.Resources.Resources.search1
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFind.Location = New System.Drawing.Point(787, 317)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(189, 28)
        Me.cmdFind.TabIndex = 155
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
        Me.cmdDelete.Location = New System.Drawing.Point(787, 419)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(189, 28)
        Me.cmdDelete.TabIndex = 159
        Me.cmdDelete.Text = "&Delete Test from List"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 139)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 13)
        Me.Label20.TabIndex = 184
        Me.Label20.Text = "Donor Name"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(160, 168)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 13)
        Me.Label26.TabIndex = 181
        Me.Label26.Text = "Yrs"
        '
        'txtDAge
        '
        Me.txtDAge.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDAge.ForeColor = System.Drawing.Color.Blue
        Me.txtDAge.Location = New System.Drawing.Point(106, 163)
        Me.txtDAge.Name = "txtDAge"
        Me.txtDAge.Size = New System.Drawing.Size(47, 22)
        Me.txtDAge.TabIndex = 8
        Me.txtDAge.Text = "00"
        Me.txtDAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(881, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(91, 22)
        Me.lblTotal.TabIndex = 168
        Me.lblTotal.Text = "00"
        Me.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 168)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 13)
        Me.Label27.TabIndex = 180
        Me.Label27.Text = "Donor Age"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(788, 453)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(189, 28)
        Me.cmdSave.TabIndex = 156
        Me.cmdSave.Text = "&Update Record"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lblvisitor
        '
        Me.lblvisitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblvisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvisitor.Location = New System.Drawing.Point(566, 256)
        Me.lblvisitor.Name = "lblvisitor"
        Me.lblvisitor.Size = New System.Drawing.Size(167, 18)
        Me.lblvisitor.TabIndex = 150
        Me.lblvisitor.Text = "visitor"
        Me.lblvisitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDelDate
        '
        Me.txtDelDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDelDate.Location = New System.Drawing.Point(428, 47)
        Me.txtDelDate.Name = "txtDelDate"
        Me.txtDelDate.ReadOnly = True
        Me.txtDelDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDelDate.TabIndex = 173
        Me.txtDelDate.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(213, 259)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 13)
        Me.Label22.TabIndex = 172
        Me.Label22.Text = "Press F1 to get Tests List"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 259)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 171
        Me.Label14.Text = "Test Code"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(786, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 13)
        Me.Label24.TabIndex = 166
        Me.Label24.Text = "Concession"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(106, 253)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 24)
        Me.txtCode.TabIndex = 12
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(786, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 162
        Me.Label11.Text = "Total Amount"
        '
        'txtRefer
        '
        Me.txtRefer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRefer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefer.ForeColor = System.Drawing.Color.Blue
        Me.txtRefer.Location = New System.Drawing.Point(106, 223)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(628, 22)
        Me.txtRefer.TabIndex = 11
        '
        'txtPaid
        '
        Me.txtPaid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtPaid.Location = New System.Drawing.Point(881, 103)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(91, 22)
        Me.txtPaid.TabIndex = 154
        Me.txtPaid.Text = "00"
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 169
        Me.Label10.Text = "Reffered by"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(554, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(76, 13)
        Me.Label21.TabIndex = 167
        Me.Label21.Text = "Report Time"
        '
        'cmbCP
        '
        Me.cmbCP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCP.ForeColor = System.Drawing.Color.Blue
        Me.cmbCP.FormattingEnabled = True
        Me.cmbCP.Location = New System.Drawing.Point(106, 192)
        Me.cmbCP.Name = "cmbCP"
        Me.cmbCP.Size = New System.Drawing.Size(436, 23)
        Me.cmbCP.Sorted = True
        Me.cmbCP.TabIndex = 10
        '
        'lblOper
        '
        Me.lblOper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOper.Location = New System.Drawing.Point(789, 225)
        Me.lblOper.Name = "lblOper"
        Me.lblOper.Size = New System.Drawing.Size(183, 25)
        Me.lblOper.TabIndex = 169
        Me.lblOper.Text = "operator"
        Me.lblOper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Sample Source"
        '
        'txtPanel
        '
        Me.txtPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanel.ForeColor = System.Drawing.Color.Blue
        Me.txtPanel.Location = New System.Drawing.Point(570, 164)
        Me.txtPanel.Name = "txtPanel"
        Me.txtPanel.Size = New System.Drawing.Size(164, 22)
        Me.txtPanel.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(476, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 164
        Me.Label8.Text = "Pannel EMP #"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(213, 168)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 13)
        Me.Label19.TabIndex = 162
        Me.Label19.Text = "Mannual Slip #"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(787, 137)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 13)
        Me.Label25.TabIndex = 171
        Me.Label25.Text = "Complimentary"
        '
        'txtSlip
        '
        Me.txtSlip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlip.ForeColor = System.Drawing.Color.Blue
        Me.txtSlip.Location = New System.Drawing.Point(309, 163)
        Me.txtSlip.Name = "txtSlip"
        Me.txtSlip.Size = New System.Drawing.Size(161, 22)
        Me.txtSlip.TabIndex = 9
        Me.txtSlip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStatus
        '
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(789, 259)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(183, 25)
        Me.txtStatus.TabIndex = 170
        Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = Global.Business_Solutions.My.Resources.Resources.remove
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(787, 351)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(189, 28)
        Me.cmdCancel.TabIndex = 157
        Me.cmdCancel.Text = "&Cancel Case"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(329, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 160
        Me.Label18.Text = "Day"
        '
        'cmdComp
        '
        Me.cmdComp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdComp.Enabled = False
        Me.cmdComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComp.Image = Global.Business_Solutions.My.Resources.Resources.remove
        Me.cmdComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdComp.Location = New System.Drawing.Point(786, 385)
        Me.cmdComp.Name = "cmdComp"
        Me.cmdComp.Size = New System.Drawing.Size(189, 28)
        Me.cmdComp.TabIndex = 158
        Me.cmdComp.Text = "&Complimentary"
        Me.cmdComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdComp.UseVisualStyleBackColor = False
        '
        'txtDay
        '
        Me.txtDay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.ForeColor = System.Drawing.Color.Blue
        Me.txtDay.Location = New System.Drawing.Point(277, 105)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(46, 22)
        Me.txtDay.TabIndex = 4
        Me.txtDay.Text = "00"
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(243, 110)
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
        Me.txtMth.Location = New System.Drawing.Point(191, 105)
        Me.txtMth.Name = "txtMth"
        Me.txtMth.Size = New System.Drawing.Size(46, 22)
        Me.txtMth.TabIndex = 3
        Me.txtMth.Text = "00"
        Me.txtMth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.Blue
        Me.txtContact.Location = New System.Drawing.Point(570, 105)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(163, 22)
        Me.txtContact.TabIndex = 5
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(501, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Contact #"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(786, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 163
        Me.Label12.Text = "Amount Paid"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(160, 110)
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
        Me.txtYrs.Location = New System.Drawing.Point(106, 105)
        Me.txtYrs.Name = "txtYrs"
        Me.txtYrs.Size = New System.Drawing.Size(47, 22)
        Me.txtYrs.TabIndex = 2
        Me.txtYrs.Text = "00"
        Me.txtYrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(786, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "Amount Due"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Patient Age"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(348, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "Report Date"
        '
        'cmbTitle
        '
        Me.cmbTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.ForeColor = System.Drawing.Color.Blue
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"B/O", "Baby", "D/O", "F/O", "M/O", "Master", "Miss.", "Mr.", "Mrs.", "Ms.", "S/O", "Sis/O", "W/O", "Wid/O"})
        Me.cmbTitle.Location = New System.Drawing.Point(106, 74)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(111, 23)
        Me.cmbTitle.Sorted = True
        Me.cmbTitle.TabIndex = 0
        '
        'lblDues
        '
        Me.lblDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDues.Location = New System.Drawing.Point(875, 71)
        Me.lblDues.Name = "lblDues"
        Me.lblDues.Size = New System.Drawing.Size(101, 19)
        Me.lblDues.TabIndex = 165
        Me.lblDues.Text = "00"
        Me.lblDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSex
        '
        Me.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Blue
        Me.lblSex.Location = New System.Drawing.Point(638, 74)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(96, 22)
        Me.lblSex.TabIndex = 146
        Me.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(581, 79)
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
        Me.txtName.Location = New System.Drawing.Point(227, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(348, 22)
        Me.txtName.TabIndex = 1
        Me.txtName.WordWrap = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblDSex)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.cmbDTitle)
        Me.Panel1.Controls.Add(Me.txtDName)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.txtDAge)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.lblvisitor)
        Me.Panel1.Controls.Add(Me.txtDelDate)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.txtRefer)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.cmbCP)
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
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblSex)
        Me.Panel1.Controls.Add(Me.cmbTitle)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDelTime)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRecNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 292)
        Me.Panel1.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Patient Name"
        '
        'txtDelTime
        '
        Me.txtDelTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDelTime.Location = New System.Drawing.Point(637, 46)
        Me.txtDelTime.Name = "txtDelTime"
        Me.txtDelTime.ReadOnly = True
        Me.txtDelTime.Size = New System.Drawing.Size(97, 22)
        Me.txtDelTime.TabIndex = 143
        Me.txtDelTime.TabStop = False
        Me.txtDelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTime.Location = New System.Drawing.Point(637, 18)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(97, 22)
        Me.txtTime.TabIndex = 142
        Me.txtTime.TabStop = False
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(550, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Sample Time"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDate.Location = New System.Drawing.Point(428, 18)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 140
        Me.txtDate.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Sample Date"
        '
        'txtRecNo
        '
        Me.txtRecNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRecNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtRecNo.Location = New System.Drawing.Point(105, 19)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.ReadOnly = True
        Me.txtRecNo.Size = New System.Drawing.Size(111, 22)
        Me.txtRecNo.TabIndex = 138
        Me.txtRecNo.TabStop = False
        Me.txtRecNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Patient ID #"
        '
        'txtCompli
        '
        Me.txtCompli.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCompli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompli.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtCompli.Location = New System.Drawing.Point(881, 131)
        Me.txtCompli.Name = "txtCompli"
        Me.txtCompli.Size = New System.Drawing.Size(91, 22)
        Me.txtCompli.TabIndex = 172
        Me.txtCompli.Text = "00"
        Me.txtCompli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmNationalEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(986, 527)
        Me.Controls.Add(Me.TstDataGrid)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.lblOper)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdComp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblDues)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCompli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1002, 566)
        Me.Name = "frmNationalEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Patient Data"
        CType(Me.GridBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TstDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridBinding As System.Windows.Forms.BindingSource
    Friend WithEvents GridDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents TstDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents tcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDSex As System.Windows.Forms.Label
    Friend WithEvents cmbDTitle As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtDName As System.Windows.Forms.TextBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDAge As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lblvisitor As System.Windows.Forms.Label
    Friend WithEvents txtDelDate As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbCP As System.Windows.Forms.ComboBox
    Friend WithEvents lblOper As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPanel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSlip As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdComp As System.Windows.Forms.Button
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMth As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtYrs As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblDues As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDelTime As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRecNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCompli As System.Windows.Forms.TextBox
End Class
