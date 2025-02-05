<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.cmdMin = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtPPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtSalePrice = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtMargin = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtEDuty = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtITax = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtVAT = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPck = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCatg = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorFind = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAdd = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEdit = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorDelete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorUpdate = New System.Windows.Forms.ToolStripButton
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Products"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = Me.ProductDataSet
        Me.ProductBindingSource.Position = 0
        '
        'ProductDataSet
        '
        Me.ProductDataSet.DataSetName = "ProductDataSet"
        Me.ProductDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.TableName = "PRODUCTS"
        '
        'cmdMin
        '
        Me.cmdMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMin.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdMin.Location = New System.Drawing.Point(915, 5)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(29, 34)
        Me.cmdMin.TabIndex = 16
        Me.cmdMin.TabStop = False
        Me.cmdMin.Text = "----"
        Me.cmdMin.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1000
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdClose.Location = New System.Drawing.Point(946, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(31, 34)
        Me.cmdClose.TabIndex = 14
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 44)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPPrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDiscount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSalePrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMargin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEDuty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtITax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVAT)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPck)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCatg)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDesc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Enabled = False
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProductDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(975, 574)
        Me.SplitContainer1.SplitterDistance = 139
        Me.SplitContainer1.TabIndex = 18
        Me.SplitContainer1.TabStop = False
        '
        'txtPPrice
        '
        Me.txtPPrice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtPPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPPrice.Enabled = False
        Me.txtPPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPrice.ForeColor = System.Drawing.Color.White
        Me.txtPPrice.Location = New System.Drawing.Point(681, 94)
        Me.txtPPrice.Name = "txtPPrice"
        Me.txtPPrice.ReadOnly = True
        Me.txtPPrice.Size = New System.Drawing.Size(66, 20)
        Me.txtPPrice.TabIndex = 94
        Me.txtPPrice.TabStop = False
        Me.txtPPrice.Text = "0"
        Me.txtPPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(621, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "P. Price"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.White
        Me.txtDiscount.Location = New System.Drawing.Point(435, 94)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(63, 20)
        Me.txtDiscount.TabIndex = 9
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Yellow
        Me.Label22.Location = New System.Drawing.Point(373, 96)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 16)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "Discount"
        '
        'txtSalePrice
        '
        Me.txtSalePrice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalePrice.ForeColor = System.Drawing.Color.White
        Me.txtSalePrice.Location = New System.Drawing.Point(291, 94)
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Size = New System.Drawing.Size(63, 20)
        Me.txtSalePrice.TabIndex = 8
        Me.txtSalePrice.Text = "0"
        Me.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(218, 96)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 16)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "Sale Price"
        '
        'txtMargin
        '
        Me.txtMargin.BackColor = System.Drawing.Color.SteelBlue
        Me.txtMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMargin.ForeColor = System.Drawing.Color.White
        Me.txtMargin.Location = New System.Drawing.Point(120, 94)
        Me.txtMargin.Name = "txtMargin"
        Me.txtMargin.Size = New System.Drawing.Size(72, 20)
        Me.txtMargin.TabIndex = 7
        Me.txtMargin.Text = "0"
        Me.txtMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(69, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 16)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Margin"
        '
        'txtEDuty
        '
        Me.txtEDuty.BackColor = System.Drawing.Color.SteelBlue
        Me.txtEDuty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEDuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEDuty.ForeColor = System.Drawing.Color.White
        Me.txtEDuty.Location = New System.Drawing.Point(681, 57)
        Me.txtEDuty.Name = "txtEDuty"
        Me.txtEDuty.Size = New System.Drawing.Size(66, 20)
        Me.txtEDuty.TabIndex = 5
        Me.txtEDuty.Text = "0"
        Me.txtEDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(597, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 16)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Excise Duty"
        '
        'txtITax
        '
        Me.txtITax.BackColor = System.Drawing.Color.SteelBlue
        Me.txtITax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtITax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtITax.ForeColor = System.Drawing.Color.White
        Me.txtITax.Location = New System.Drawing.Point(435, 57)
        Me.txtITax.Name = "txtITax"
        Me.txtITax.Size = New System.Drawing.Size(63, 20)
        Me.txtITax.TabIndex = 4
        Me.txtITax.Text = "0"
        Me.txtITax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(393, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "I.Tax."
        '
        'txtVAT
        '
        Me.txtVAT.BackColor = System.Drawing.Color.SteelBlue
        Me.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.ForeColor = System.Drawing.Color.White
        Me.txtVAT.Location = New System.Drawing.Point(291, 57)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(63, 20)
        Me.txtVAT.TabIndex = 3
        Me.txtVAT.Text = "0"
        Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(247, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 16)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "V.A.T"
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.SteelBlue
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.ForeColor = System.Drawing.Color.White
        Me.txtMin.Location = New System.Drawing.Point(831, 57)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(65, 20)
        Me.txtMin.TabIndex = 6
        Me.txtMin.Text = "0"
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(769, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Min. Bal."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPck
        '
        Me.txtPck.BackColor = System.Drawing.Color.SteelBlue
        Me.txtPck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPck.ForeColor = System.Drawing.Color.White
        Me.txtPck.Location = New System.Drawing.Point(120, 57)
        Me.txtPck.Name = "txtPck"
        Me.txtPck.Size = New System.Drawing.Size(72, 20)
        Me.txtPck.TabIndex = 2
        Me.txtPck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(61, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Packing"
        '
        'cmbCatg
        '
        Me.cmbCatg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.cmbCatg.BackColor = System.Drawing.Color.SteelBlue
        Me.cmbCatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCatg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCatg.ForeColor = System.Drawing.Color.White
        Me.cmbCatg.FormattingEnabled = True
        Me.cmbCatg.Items.AddRange(New Object() {"Mother Board", "Hard Disk", "RAM", "Tower Casing", "Desktop Casing", "Personal Computer", "DVD Rom", "Processor", "USB", "Power Cables", "Network Cable"})
        Me.cmbCatg.Location = New System.Drawing.Point(681, 17)
        Me.cmbCatg.Name = "cmbCatg"
        Me.cmbCatg.Size = New System.Drawing.Size(215, 21)
        Me.cmbCatg.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(612, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Category"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.White
        Me.txtDesc.Location = New System.Drawing.Point(120, 17)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(435, 20)
        Me.txtDesc.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(38, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Description"
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.AllowUserToOrderColumns = True
        Me.ProductDataGridView.AllowUserToResizeColumns = False
        Me.ProductDataGridView.AllowUserToResizeRows = False
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn5})
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGridView.GridColor = System.Drawing.Color.Gray
        Me.ProductDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProductDataGridView.MultiSelect = False
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(975, 431)
        Me.ProductDataGridView.TabIndex = 11
        Me.ProductDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_CD"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PROD_DESC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PROD_CATG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PROD_PACK"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Packing"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PROD_PPRICE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "P. Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PROD_SPRICE"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Sale Price"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PROD_PROFIT"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Profit Margin"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PROD_BAL_MIN"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Min Bal."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "PROD_DISC_MRG"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PROD_VAT"
        Me.DataGridViewTextBoxColumn17.HeaderText = "V.A.T"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PROD_ITAX"
        Me.DataGridViewTextBoxColumn18.HeaderText = "I.Tax"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PROD_EX_DUTY"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Excise Duty"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROD_DATE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Update On"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Nothing
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Nothing
        Me.ProductBindingNavigator.DeleteItem = Nothing
        Me.ProductBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ProductBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorTextBox, Me.BindingNavigatorSeparator4, Me.BindingNavigatorFind, Me.ToolStripSeparator1, Me.BindingNavigatorAdd, Me.BindingNavigatorSeparator3, Me.BindingNavigatorEdit, Me.BindingNavigatorSeparator5, Me.BindingNavigatorDelete, Me.ToolStripSeparator2, Me.BindingNavigatorUpdate})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(183, 9)
        Me.ProductBindingNavigator.MoveFirstItem = Nothing
        Me.ProductBindingNavigator.MoveLastItem = Nothing
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Nothing
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(665, 25)
        Me.ProductBindingNavigator.TabIndex = 22
        Me.ProductBindingNavigator.Text = "BindingNavigator"
        Me.ProductBindingNavigator.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(50, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "&Prev"
        Me.BindingNavigatorMovePreviousItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "Move Previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(52, 22)
        Me.BindingNavigatorMoveNextItem.Text = "&Next"
        Me.BindingNavigatorMoveNextItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorTextBox
        '
        Me.BindingNavigatorTextBox.Name = "BindingNavigatorTextBox"
        Me.BindingNavigatorTextBox.Size = New System.Drawing.Size(200, 25)
        Me.BindingNavigatorTextBox.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        Me.BindingNavigatorTextBox.ToolTipText = "Enter Product Code to Find"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorFind
        '
        Me.BindingNavigatorFind.Image = Global.POS_System.My.Resources.Resources.search1
        Me.BindingNavigatorFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorFind.Name = "BindingNavigatorFind"
        Me.BindingNavigatorFind.Size = New System.Drawing.Size(95, 22)
        Me.BindingNavigatorFind.Text = "&Find Product"
        Me.BindingNavigatorFind.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorFind.ToolTipText = "Click to Find Product"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorAdd
        '
        Me.BindingNavigatorAdd.Image = Global.POS_System.My.Resources.Resources.NewDocumentHS
        Me.BindingNavigatorAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorAdd.Name = "BindingNavigatorAdd"
        Me.BindingNavigatorAdd.Size = New System.Drawing.Size(49, 22)
        Me.BindingNavigatorAdd.Text = "&Add"
        Me.BindingNavigatorAdd.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorAdd.ToolTipText = "Add new product information"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorEdit
        '
        Me.BindingNavigatorEdit.Image = Global.POS_System.My.Resources.Resources.data_edit
        Me.BindingNavigatorEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEdit.Name = "BindingNavigatorEdit"
        Me.BindingNavigatorEdit.Size = New System.Drawing.Size(47, 22)
        Me.BindingNavigatorEdit.Text = "&Edit"
        Me.BindingNavigatorEdit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorEdit.ToolTipText = "Edit current Product"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorDelete
        '
        Me.BindingNavigatorDelete.Image = Global.POS_System.My.Resources.Resources.database_remove
        Me.BindingNavigatorDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorDelete.Name = "BindingNavigatorDelete"
        Me.BindingNavigatorDelete.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDelete.Text = "&Delete"
        Me.BindingNavigatorDelete.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorDelete.ToolTipText = "Delete current product"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorUpdate
        '
        Me.BindingNavigatorUpdate.Image = Global.POS_System.My.Resources.Resources.data_add
        Me.BindingNavigatorUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorUpdate.Name = "BindingNavigatorUpdate"
        Me.BindingNavigatorUpdate.Size = New System.Drawing.Size(65, 22)
        Me.BindingNavigatorUpdate.Text = "&Update"
        Me.BindingNavigatorUpdate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorUpdate.ToolTipText = "Update current changes"
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 621)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDataSet As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ProductBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMargin As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEDuty As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtITax As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPck As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCatg As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
