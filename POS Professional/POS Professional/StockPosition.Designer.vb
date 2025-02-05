<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockPosition
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockPosition))
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.cmdMin = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDept = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUnit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorFind = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSummary = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSummaryGroup = New System.Windows.Forms.ToolStripButton
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Stock Position"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 45)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProductDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(965, 572)
        Me.SplitContainer1.SplitterDistance = 543
        Me.SplitContainer1.TabIndex = 18
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.AllowUserToResizeColumns = False
        Me.ProductDataGridView.AllowUserToResizeRows = False
        Me.ProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.colDept, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.colUnit, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn22})
        Me.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGridView.GridColor = System.Drawing.Color.Gray
        Me.ProductDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProductDataGridView.MultiSelect = False
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.RowHeadersVisible = False
        Me.ProductDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(965, 543)
        Me.ProductDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROD_UPD_ON"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.HeaderText = "Update On"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_CODE"
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
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'colDept
        '
        Me.colDept.DataPropertyName = "PROD_HEAD"
        Me.colDept.HeaderText = "Department"
        Me.colDept.Name = "colDept"
        Me.colDept.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PROD_CATG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 74
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PROD_PACKING"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Packing"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 90
        '
        'colUnit
        '
        Me.colUnit.DataPropertyName = "PROD_UNITS"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colUnit.DefaultCellStyle = DataGridViewCellStyle10
        Me.colUnit.HeaderText = "Units"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.ReadOnly = True
        Me.colUnit.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PROD_STOCK"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn8.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PROD_PURCH_PRICE"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn7.HeaderText = "Prch. Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PROD_SALE_PRICE"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn22.HeaderText = "Sale Price"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 80
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Nothing
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Nothing
        Me.ProductBindingNavigator.DeleteItem = Nothing
        Me.ProductBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorTextBox, Me.BindingNavigatorSeparator4, Me.BindingNavigatorFind, Me.BindingNavigatorSeparator3, Me.BindingNavigatorSummary, Me.BindingNavigatorSeparator5, Me.BindingNavigatorSummaryGroup})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(220, 10)
        Me.ProductBindingNavigator.MoveFirstItem = Nothing
        Me.ProductBindingNavigator.MoveLastItem = Nothing
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Nothing
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(664, 25)
        Me.ProductBindingNavigator.TabIndex = 17
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
        'BindingNavigatorTextBox
        '
        Me.BindingNavigatorTextBox.Name = "BindingNavigatorTextBox"
        Me.BindingNavigatorTextBox.Size = New System.Drawing.Size(200, 25)
        Me.BindingNavigatorTextBox.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorFind
        '
        Me.BindingNavigatorFind.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.BindingNavigatorFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorFind.Name = "BindingNavigatorFind"
        Me.BindingNavigatorFind.Size = New System.Drawing.Size(95, 22)
        Me.BindingNavigatorFind.Text = "&Find Product"
        Me.BindingNavigatorFind.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorFind.ToolTipText = "Click to Find Product"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorSummary
        '
        Me.BindingNavigatorSummary.Image = CType(resources.GetObject("BindingNavigatorSummary.Image"), System.Drawing.Image)
        Me.BindingNavigatorSummary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSummary.Name = "BindingNavigatorSummary"
        Me.BindingNavigatorSummary.Size = New System.Drawing.Size(78, 22)
        Me.BindingNavigatorSummary.Text = "&Summary"
        Me.BindingNavigatorSummary.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorSummaryGroup
        '
        Me.BindingNavigatorSummaryGroup.Image = Global.POS_Professional.My.Resources.Resources.PatientFile2
        Me.BindingNavigatorSummaryGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSummaryGroup.Name = "BindingNavigatorSummaryGroup"
        Me.BindingNavigatorSummaryGroup.Size = New System.Drawing.Size(145, 22)
        Me.BindingNavigatorSummaryGroup.Text = "Su&mmary by Category"
        Me.BindingNavigatorSummaryGroup.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'StockPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 621)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StockPosition"
        Me.Opacity = 0.8
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockPosition"
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDataSet As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ProductDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSummary As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSummaryGroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
