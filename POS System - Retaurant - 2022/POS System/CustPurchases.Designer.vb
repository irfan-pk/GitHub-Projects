<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustPurchases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustPurchases))
        Me.SaleDataGrid = New System.Windows.Forms.DataGridView
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorFind = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorClose = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToDateTime = New System.Windows.Forms.DateTimePicker
        Me.FromDateTime = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.colSaleID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCustID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSequence = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPack = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.SaleDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSaleID, Me.colCustID, Me.colSequence, Me.colName, Me.colDescription, Me.colPack, Me.colPrice, Me.colQuantity, Me.colSubTotal})
        Me.SaleDataGrid.DataSource = Me.CustomerBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SaleDataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaleDataGrid.Location = New System.Drawing.Point(0, 67)
        Me.SaleDataGrid.Name = "SaleDataGrid"
        Me.SaleDataGrid.ReadOnly = True
        Me.SaleDataGrid.RowHeadersVisible = False
        Me.SaleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SaleDataGrid.Size = New System.Drawing.Size(937, 529)
        Me.SaleDataGrid.TabIndex = 3
        Me.SaleDataGrid.TabStop = False
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet
        Me.CustomerBindingSource.Position = 0
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.TableName = "PRODUCTS"
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Nothing
        Me.CustomerBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Nothing
        Me.CustomerBindingNavigator.DeleteItem = Nothing
        Me.CustomerBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorTextBox, Me.BindingNavigatorSeparator4, Me.BindingNavigatorFind, Me.BindingNavigatorSeparator3, Me.BindingNavigatorClose, Me.BindingNavigatorSeparator5})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Nothing
        Me.CustomerBindingNavigator.MoveLastItem = Nothing
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Nothing
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(937, 25)
        Me.CustomerBindingNavigator.TabIndex = 23
        Me.CustomerBindingNavigator.Text = "BindingNavigator"
        Me.CustomerBindingNavigator.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.BackColor = System.Drawing.SystemColors.Control
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
        Me.BindingNavigatorMoveNextItem.BackColor = System.Drawing.SystemColors.Control
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(51, 22)
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
        Me.BindingNavigatorTextBox.ToolTipText = "Enter Product Code to Find or Press F2 to get list"
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
        Me.BindingNavigatorFind.Size = New System.Drawing.Size(134, 22)
        Me.BindingNavigatorFind.Text = "&Find Customer Sales"
        Me.BindingNavigatorFind.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorFind.ToolTipText = "Click to Find Customer Sale"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorClose
        '
        Me.BindingNavigatorClose.Image = Global.POS_System.My.Resources.Resources.remove2
        Me.BindingNavigatorClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorClose.Name = "BindingNavigatorClose"
        Me.BindingNavigatorClose.Size = New System.Drawing.Size(56, 22)
        Me.BindingNavigatorClose.Text = "&Close"
        Me.BindingNavigatorClose.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorClose.ToolTipText = "Quit from window"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmdPreview)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ToDateTime)
        Me.Panel2.Controls.Add(Me.FromDateTime)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(937, 42)
        Me.Panel2.TabIndex = 29
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Image = Global.POS_System.My.Resources.Resources.Book_openHS
        Me.cmdPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPreview.Location = New System.Drawing.Point(530, 4)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(72, 29)
        Me.cmdPreview.TabIndex = 31
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(286, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "To"
        '
        'ToDateTime
        '
        Me.ToDateTime.Location = New System.Drawing.Point(317, 9)
        Me.ToDateTime.Name = "ToDateTime"
        Me.ToDateTime.Size = New System.Drawing.Size(204, 20)
        Me.ToDateTime.TabIndex = 1
        '
        'FromDateTime
        '
        Me.FromDateTime.Location = New System.Drawing.Point(74, 9)
        Me.FromDateTime.Name = "FromDateTime"
        Me.FromDateTime.Size = New System.Drawing.Size(204, 20)
        Me.FromDateTime.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "View From"
        '
        'colSaleID
        '
        Me.colSaleID.DataPropertyName = "SaleID"
        Me.colSaleID.HeaderText = "Invoice #"
        Me.colSaleID.Name = "colSaleID"
        Me.colSaleID.ReadOnly = True
        Me.colSaleID.Width = 75
        '
        'colCustID
        '
        Me.colCustID.DataPropertyName = "CustomerID"
        Me.colCustID.HeaderText = "Customer ID"
        Me.colCustID.Name = "colCustID"
        Me.colCustID.ReadOnly = True
        Me.colCustID.Width = 75
        '
        'colSequence
        '
        Me.colSequence.DataPropertyName = "SequenceID"
        Me.colSequence.HeaderText = "Sequence #"
        Me.colSequence.Name = "colSequence"
        Me.colSequence.ReadOnly = True
        '
        'colName
        '
        Me.colName.DataPropertyName = "CustomerName"
        Me.colName.HeaderText = "Customer Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 140
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "STOCKDESC"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 185
        '
        'colPack
        '
        Me.colPack.DataPropertyName = "SalePack"
        Me.colPack.HeaderText = "Pack"
        Me.colPack.Name = "colPack"
        Me.colPack.ReadOnly = True
        '
        'colPrice
        '
        Me.colPrice.DataPropertyName = "UnitCost"
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
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
        '
        'frmCustPurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 596)
        Me.Controls.Add(Me.SaleDataGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmCustPurchases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Customer Purchases"
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaleDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerDataSet As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colSaleID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSequence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPack As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
