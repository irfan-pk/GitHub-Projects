<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITEMTYPES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ITEMTYPES))
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripEditButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripCloseButton = New System.Windows.Forms.ToolStripButton
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.DeptDataGridView = New System.Windows.Forms.DataGridView
        Me.colHead = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataSet = New System.Data.DataSet
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.BindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.ToolStripEditButton, Me.ToolStripSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator3, Me.BindingNavigatorSave, Me.ToolStripSeparator4, Me.ToolStripCloseButton})
        Me.BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(540, 25)
        Me.BindingNavigator.TabIndex = 2
        Me.BindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(76, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add New"
        '
        'BindingSource
        '
        Me.BindingSource.AllowNew = True
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripEditButton
        '
        Me.ToolStripEditButton.Image = Global.POS_Professional.My.Resources.Resources.data_edit
        Me.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEditButton.Name = "ToolStripEditButton"
        Me.ToolStripEditButton.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripEditButton.Text = "&Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSave
        '
        Me.BindingNavigatorSave.Enabled = False
        Me.BindingNavigatorSave.Image = Global.POS_Professional.My.Resources.Resources.saveHS
        Me.BindingNavigatorSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSave.Name = "BindingNavigatorSave"
        Me.BindingNavigatorSave.Size = New System.Drawing.Size(51, 22)
        Me.BindingNavigatorSave.Text = "&Save"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Image = Global.POS_Professional.My.Resources.Resources.remove1
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripCloseButton.Text = "&Close"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(19, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(105, 13)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Product Category"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(130, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(270, 20)
        Me.txtName.TabIndex = 8
        '
        'DeptDataGridView
        '
        Me.DeptDataGridView.AllowUserToAddRows = False
        Me.DeptDataGridView.AllowUserToDeleteRows = False
        Me.DeptDataGridView.AutoGenerateColumns = False
        Me.DeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeptDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHead})
        Me.DeptDataGridView.DataSource = Me.BindingSource
        Me.DeptDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DeptDataGridView.Location = New System.Drawing.Point(0, 79)
        Me.DeptDataGridView.MultiSelect = False
        Me.DeptDataGridView.Name = "DeptDataGridView"
        Me.DeptDataGridView.ReadOnly = True
        Me.DeptDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DeptDataGridView.Size = New System.Drawing.Size(540, 447)
        Me.DeptDataGridView.TabIndex = 10
        '
        'colHead
        '
        Me.colHead.DataPropertyName = "CATEGORY"
        Me.colHead.HeaderText = "CATEGORIES"
        Me.colHead.Name = "colHead"
        Me.colHead.ReadOnly = True
        Me.colHead.Width = 507
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        '
        'ITEMTYPES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(540, 526)
        Me.Controls.Add(Me.DeptDataGridView)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.BindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ITEMTYPES"
        Me.Text = "Product Category"
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripEditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripCloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents DeptDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As System.Data.DataSet
    Friend WithEvents colHead As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
