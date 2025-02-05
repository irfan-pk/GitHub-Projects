<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewSale))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RecordDataSet = New System.Data.DataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.HoldBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.CashSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreditSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.dtDate = New System.Windows.Forms.DateTimePicker
        Me.dgMasterInfo = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCustID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgChildInfo = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HoldBindingNavigator.SuspendLayout()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMasterInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgChildInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecordDataSet
        '
        Me.RecordDataSet.DataSetName = "RecordDataSet"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 30)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
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
        'HoldBindingNavigator
        '
        Me.HoldBindingNavigator.AddNewItem = Nothing
        Me.HoldBindingNavigator.AutoSize = False
        Me.HoldBindingNavigator.BindingSource = Me.MasterBindingSource
        Me.HoldBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HoldBindingNavigator.DeleteItem = Nothing
        Me.HoldBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HoldBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripSplitButton1, Me.ToolStripSeparator2})
        Me.HoldBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HoldBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HoldBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HoldBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HoldBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HoldBindingNavigator.Name = "HoldBindingNavigator"
        Me.HoldBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HoldBindingNavigator.Size = New System.Drawing.Size(1029, 33)
        Me.HoldBindingNavigator.TabIndex = 0
        Me.HoldBindingNavigator.Text = "BindingNavigator"
        '
        'MasterBindingSource
        '
        Me.MasterBindingSource.DataSource = Me.RecordDataSet
        Me.MasterBindingSource.Position = 0
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 30)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 30)
        Me.ToolStripButton1.Text = "&Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashSaleToolStripMenuItem, Me.CreditSaleToolStripMenuItem, Me.CustomerSaleToolStripMenuItem, Me.RecoveryToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.POS_System.My.Resources.Resources.Filter2HS
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(88, 30)
        Me.ToolStripSplitButton1.Text = "Sale Type"
        '
        'CashSaleToolStripMenuItem
        '
        Me.CashSaleToolStripMenuItem.Name = "CashSaleToolStripMenuItem"
        Me.CashSaleToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CashSaleToolStripMenuItem.Text = "Cash Sale"
        '
        'CreditSaleToolStripMenuItem
        '
        Me.CreditSaleToolStripMenuItem.Name = "CreditSaleToolStripMenuItem"
        Me.CreditSaleToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CreditSaleToolStripMenuItem.Text = "Credit Sale"
        '
        'CustomerSaleToolStripMenuItem
        '
        Me.CustomerSaleToolStripMenuItem.Name = "CustomerSaleToolStripMenuItem"
        Me.CustomerSaleToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CustomerSaleToolStripMenuItem.Text = "Customer Sale"
        '
        'RecoveryToolStripMenuItem
        '
        Me.RecoveryToolStripMenuItem.Name = "RecoveryToolStripMenuItem"
        Me.RecoveryToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RecoveryToolStripMenuItem.Text = "Recovery"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(260, 7)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(227, 20)
        Me.dtDate.TabIndex = 1
        '
        'dgMasterInfo
        '
        Me.dgMasterInfo.AllowUserToAddRows = False
        Me.dgMasterInfo.AllowUserToDeleteRows = False
        Me.dgMasterInfo.AutoGenerateColumns = False
        Me.dgMasterInfo.BackgroundColor = System.Drawing.Color.Gray
        Me.dgMasterInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgMasterInfo.ColumnHeadersHeight = 22
        Me.dgMasterInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMasterInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.colCustID, Me.colDate, Me.colTotal, Me.colPaid, Me.colDiscount, Me.colUser})
        Me.dgMasterInfo.DataSource = Me.MasterBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMasterInfo.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgMasterInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMasterInfo.Location = New System.Drawing.Point(0, 33)
        Me.dgMasterInfo.Name = "dgMasterInfo"
        Me.dgMasterInfo.ReadOnly = True
        Me.dgMasterInfo.RowHeadersVisible = False
        Me.dgMasterInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMasterInfo.Size = New System.Drawing.Size(1029, 350)
        Me.dgMasterInfo.TabIndex = 2
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SaleID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Invoice #"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SaleType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'colCustID
        '
        Me.colCustID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCustID.DataPropertyName = "CustomerID"
        Me.colCustID.HeaderText = "Cust. ID"
        Me.colCustID.Name = "colCustID"
        Me.colCustID.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "DateCompleted"
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colTotal
        '
        Me.colTotal.DataPropertyName = "SaleTotal"
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.Width = 88
        '
        'colPaid
        '
        Me.colPaid.DataPropertyName = "SalePaid"
        Me.colPaid.HeaderText = "Payment"
        Me.colPaid.Name = "colPaid"
        Me.colPaid.ReadOnly = True
        Me.colPaid.Width = 87
        '
        'colDiscount
        '
        Me.colDiscount.DataPropertyName = "SaleDiscount"
        Me.colDiscount.HeaderText = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.ReadOnly = True
        Me.colDiscount.Width = 85
        '
        'colUser
        '
        Me.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colUser.DataPropertyName = "DrawerName"
        Me.colUser.HeaderText = "User Name"
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        '
        'dgChildInfo
        '
        Me.dgChildInfo.AllowUserToAddRows = False
        Me.dgChildInfo.AllowUserToDeleteRows = False
        Me.dgChildInfo.AutoGenerateColumns = False
        Me.dgChildInfo.BackgroundColor = System.Drawing.Color.Gray
        Me.dgChildInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgChildInfo.ColumnHeadersHeight = 22
        Me.dgChildInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgChildInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.dgChildInfo.DataSource = Me.DetailBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgChildInfo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgChildInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgChildInfo.Location = New System.Drawing.Point(0, 383)
        Me.dgChildInfo.Name = "dgChildInfo"
        Me.dgChildInfo.ReadOnly = True
        Me.dgChildInfo.RowHeadersVisible = False
        Me.dgChildInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgChildInfo.Size = New System.Drawing.Size(1029, 275)
        Me.dgChildInfo.TabIndex = 3
        Me.dgChildInfo.TabStop = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SaleID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Invoice #"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CustomerName"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "STOCKDESC"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "UnitCost"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "QTY"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PRICE"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Sub Total"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DetailBindingSource
        '
        Me.DetailBindingSource.DataSource = Me.RecordDataSet
        Me.DetailBindingSource.Position = 0
        '
        'frmViewSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 658)
        Me.Controls.Add(Me.dgMasterInfo)
        Me.Controls.Add(Me.dgChildInfo)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.HoldBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmViewSale"
        Me.Text = "View Sales"
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HoldBindingNavigator.ResumeLayout(False)
        Me.HoldBindingNavigator.PerformLayout()
        CType(Me.MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMasterInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgChildInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RecordDataSet As System.Data.DataSet
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents HoldBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents dgMasterInfo As System.Windows.Forms.DataGridView
    Friend WithEvents dgChildInfo As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CashSaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditSaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerSaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecoveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDiscount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
