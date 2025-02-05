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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockPosition))
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet = New System.Data.DataSet
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
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
        Me.StockListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 45)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.StockListView)
        Me.SplitContainer1.Size = New System.Drawing.Size(966, 572)
        Me.SplitContainer1.SplitterDistance = 543
        Me.SplitContainer1.TabIndex = 18
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
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(225, 11)
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
        Me.BindingNavigatorSummary.Image = Global.POS_Professional.My.Resources.Resources.PatientFile2
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
        'StockListView
        '
        Me.StockListView.AutoArrange = False
        Me.StockListView.BackColor = System.Drawing.Color.DimGray
        Me.StockListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.StockListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockListView.ForeColor = System.Drawing.Color.White
        Me.StockListView.FullRowSelect = True
        Me.StockListView.GridLines = True
        Me.StockListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.StockListView.HideSelection = False
        Me.StockListView.Location = New System.Drawing.Point(0, 0)
        Me.StockListView.MultiSelect = False
        Me.StockListView.Name = "StockListView"
        Me.StockListView.ShowGroups = False
        Me.StockListView.Size = New System.Drawing.Size(966, 543)
        Me.StockListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.StockListView.TabIndex = 1
        Me.StockListView.UseCompatibleStateImageBehavior = False
        Me.StockListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Prod. Code"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 163
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Packing"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Units"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "On Hand"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Prch. Price"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sale Price"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total Amount"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Update On"
        Me.ColumnHeader10.Width = 89
        '
        'StockPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(975, 621)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StockPosition"
        Me.Opacity = 0.8
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStockPosition"
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDataSet As System.Data.DataSet
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
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
    Friend WithEvents StockListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
End Class
