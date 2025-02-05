<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsOld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsOld))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.cmdMin = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtCatg = New System.Windows.Forms.ComboBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSalePrice = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtMargin = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtPck = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorFindItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEditItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCatg)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPPrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSalePrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMargin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPck)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDesc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Enabled = False
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ProductDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(975, 574)
        Me.SplitContainer1.SplitterDistance = 95
        Me.SplitContainer1.TabIndex = 18
        Me.SplitContainer1.TabStop = False
        '
        'txtCatg
        '
        Me.txtCatg.BackColor = System.Drawing.Color.SteelBlue
        Me.txtCatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCatg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtCatg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatg.ForeColor = System.Drawing.Color.White
        Me.txtCatg.FormattingEnabled = True
        Me.txtCatg.Items.AddRange(New Object() {"Appetizer", "Beef", "Beverages", "Chicken", "Deserts", "Fast Food", "Fish", "Mutton", "Salads", "Sea Food", "Wraps"})
        Me.txtCatg.Location = New System.Drawing.Point(120, 56)
        Me.txtCatg.Name = "txtCatg"
        Me.txtCatg.Size = New System.Drawing.Size(190, 23)
        Me.txtCatg.Sorted = True
        Me.txtCatg.TabIndex = 3
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.SteelBlue
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.White
        Me.txtCode.Location = New System.Drawing.Point(120, 20)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(190, 21)
        Me.txtCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(45, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Item Code"
        '
        'txtPPrice
        '
        Me.txtPPrice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtPPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPrice.ForeColor = System.Drawing.Color.White
        Me.txtPPrice.Location = New System.Drawing.Point(548, 56)
        Me.txtPPrice.Name = "txtPPrice"
        Me.txtPPrice.Size = New System.Drawing.Size(66, 20)
        Me.txtPPrice.TabIndex = 5
        Me.txtPPrice.Text = "0"
        Me.txtPPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(491, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "P. Price"
        '
        'txtSalePrice
        '
        Me.txtSalePrice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalePrice.ForeColor = System.Drawing.Color.White
        Me.txtSalePrice.Location = New System.Drawing.Point(833, 56)
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Size = New System.Drawing.Size(63, 20)
        Me.txtSalePrice.TabIndex = 7
        Me.txtSalePrice.Text = "0"
        Me.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(760, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 16)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "Sale Price"
        '
        'txtMargin
        '
        Me.txtMargin.BackColor = System.Drawing.Color.SteelBlue
        Me.txtMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMargin.Enabled = False
        Me.txtMargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMargin.ForeColor = System.Drawing.Color.White
        Me.txtMargin.Location = New System.Drawing.Point(678, 56)
        Me.txtMargin.Name = "txtMargin"
        Me.txtMargin.Size = New System.Drawing.Size(72, 20)
        Me.txtMargin.TabIndex = 6
        Me.txtMargin.Text = "0"
        Me.txtMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Enabled = False
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(627, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 16)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Margin"
        '
        'txtPck
        '
        Me.txtPck.BackColor = System.Drawing.Color.SteelBlue
        Me.txtPck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPck.ForeColor = System.Drawing.Color.White
        Me.txtPck.Location = New System.Drawing.Point(407, 56)
        Me.txtPck.Name = "txtPck"
        Me.txtPck.Size = New System.Drawing.Size(72, 21)
        Me.txtPck.TabIndex = 4
        Me.txtPck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(373, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(51, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Category"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.White
        Me.txtDesc.Location = New System.Drawing.Point(407, 20)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(489, 21)
        Me.txtDesc.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(328, 22)
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
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn5})
        Me.ProductDataGridView.DataMember = "PRODUCTS"
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
        Me.ProductDataGridView.Size = New System.Drawing.Size(975, 475)
        Me.ProductDataGridView.TabIndex = 11
        Me.ProductDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_CD"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PROD_DESC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PROD_CATG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PROD_PACK"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Packing"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PROD_PPRICE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "P. Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PROD_PROFIT"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Profit Margin"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PROD_SPRICE"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Sale Price"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROD_DATE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Update On"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.ProductBindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorFindItem, Me.ToolStripSeparator4, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.BindingNavigatorEditItem, Me.ToolStripSeparator3, Me.BindingNavigatorSaveItem})
        Me.BindingNavigator.Location = New System.Drawing.Point(285, 10)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(607, 25)
        Me.BindingNavigator.TabIndex = 19
        Me.BindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = Global.POS_System.My.Resources.Resources.data_add
        Me.BindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(76, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add New"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "&Delete"
        Me.BindingNavigatorDeleteItem.ToolTipText = "Delete product"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "1"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorFindItem
        '
        Me.BindingNavigatorFindItem.Image = Global.POS_System.My.Resources.Resources.search1
        Me.BindingNavigatorFindItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorFindItem.Name = "BindingNavigatorFindItem"
        Me.BindingNavigatorFindItem.Size = New System.Drawing.Size(95, 22)
        Me.BindingNavigatorFindItem.Text = "&Find Product"
        Me.BindingNavigatorFindItem.ToolTipText = "Find product by code"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorEditItem
        '
        Me.BindingNavigatorEditItem.Image = Global.POS_System.My.Resources.Resources.data_edit
        Me.BindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEditItem.Name = "BindingNavigatorEditItem"
        Me.BindingNavigatorEditItem.Size = New System.Drawing.Size(92, 22)
        Me.BindingNavigatorEditItem.Text = "&Edit Product"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Image = Global.POS_System.My.Resources.Resources.saveHS
        Me.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(51, 22)
        Me.BindingNavigatorSaveItem.Text = "&Save"
        Me.BindingNavigatorSaveItem.ToolTipText = "Save product changes"
        '
        'frmProductsOld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 621)
        Me.Controls.Add(Me.BindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProductsOld"
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
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
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
    Friend WithEvents ProductDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMargin As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPck As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorFindItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCatg As System.Windows.Forms.ComboBox
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
End Class
