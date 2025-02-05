<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoldSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoldSale))
        Me.SaleDataGrid = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordDataSet = New System.Data.DataSet
        Me.dgHoldInfo = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HoldBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoldDataSet = New System.Data.DataSet
        Me.HoldBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgHoldInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HoldBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaleDataGrid
        '
        Me.SaleDataGrid.AllowUserToAddRows = False
        Me.SaleDataGrid.AllowUserToDeleteRows = False
        Me.SaleDataGrid.AutoGenerateColumns = False
        Me.SaleDataGrid.BackgroundColor = System.Drawing.Color.Gray
        Me.SaleDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.SaleDataGrid.ColumnHeadersHeight = 22
        Me.SaleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SaleDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colDescription, Me.colPrice, Me.colQuantity, Me.colSubTotal})
        Me.SaleDataGrid.DataSource = Me.SaleBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SaleDataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaleDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SaleDataGrid.Location = New System.Drawing.Point(0, 139)
        Me.SaleDataGrid.Name = "SaleDataGrid"
        Me.SaleDataGrid.ReadOnly = True
        Me.SaleDataGrid.RowHeadersVisible = False
        Me.SaleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SaleDataGrid.Size = New System.Drawing.Size(550, 274)
        Me.SaleDataGrid.TabIndex = 2
        Me.SaleDataGrid.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "SaleID"
        Me.colID.HeaderText = "Invoice #"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "STOCKDESC"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 247
        '
        'colPrice
        '
        Me.colPrice.DataPropertyName = "UnitCost"
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 75
        '
        'colQuantity
        '
        Me.colQuantity.DataPropertyName = "QTY"
        Me.colQuantity.HeaderText = "Qty"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.ReadOnly = True
        Me.colQuantity.Width = 50
        '
        'colSubTotal
        '
        Me.colSubTotal.DataPropertyName = "PRICE"
        Me.colSubTotal.HeaderText = "Sub Total"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.ReadOnly = True
        Me.colSubTotal.Width = 75
        '
        'SaleBindingSource
        '
        Me.SaleBindingSource.DataSource = Me.RecordDataSet
        Me.SaleBindingSource.Position = 0
        '
        'RecordDataSet
        '
        Me.RecordDataSet.DataSetName = "RecordDataSet"
        '
        'dgHoldInfo
        '
        Me.dgHoldInfo.AllowUserToAddRows = False
        Me.dgHoldInfo.AllowUserToDeleteRows = False
        Me.dgHoldInfo.AutoGenerateColumns = False
        Me.dgHoldInfo.BackgroundColor = System.Drawing.Color.Gray
        Me.dgHoldInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgHoldInfo.ColumnHeadersHeight = 22
        Me.dgHoldInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgHoldInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1})
        Me.dgHoldInfo.DataSource = Me.HoldBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgHoldInfo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgHoldInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgHoldInfo.Location = New System.Drawing.Point(0, 0)
        Me.dgHoldInfo.Name = "dgHoldInfo"
        Me.dgHoldInfo.ReadOnly = True
        Me.dgHoldInfo.RowHeadersVisible = False
        Me.dgHoldInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgHoldInfo.Size = New System.Drawing.Size(550, 139)
        Me.dgHoldInfo.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SaleID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Invoice #"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 183
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SaleType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 365
        '
        'HoldBindingSource
        '
        Me.HoldBindingSource.DataSource = Me.HoldDataSet
        Me.HoldBindingSource.Position = 0
        '
        'HoldDataSet
        '
        Me.HoldDataSet.DataSetName = "HoldDataSet"
        '
        'HoldBindingNavigator
        '
        Me.HoldBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HoldBindingNavigator.BindingSource = Me.HoldBindingSource
        Me.HoldBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HoldBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HoldBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.HoldBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HoldBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HoldBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HoldBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HoldBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HoldBindingNavigator.Name = "HoldBindingNavigator"
        Me.HoldBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HoldBindingNavigator.Size = New System.Drawing.Size(550, 25)
        Me.HoldBindingNavigator.TabIndex = 2
        Me.HoldBindingNavigator.Text = "BindingNavigator"
        Me.HoldBindingNavigator.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'frmHoldSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgHoldInfo)
        Me.Controls.Add(Me.SaleDataGrid)
        Me.Controls.Add(Me.HoldBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmHoldSale"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holded Sale"
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgHoldInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HoldBindingNavigator.ResumeLayout(False)
        Me.HoldBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaleDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecordDataSet As System.Data.DataSet
    Friend WithEvents dgHoldInfo As System.Windows.Forms.DataGridView
    Friend WithEvents HoldBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HoldDataSet As System.Data.DataSet
    Friend WithEvents HoldBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
