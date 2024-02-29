<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenseList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpenseList))
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.DocDataGridView = New System.Windows.Forms.DataGridView
        Me.EXPENSE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXP_CATG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.ExpBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripEditButton = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripCloseButton = New System.Windows.Forms.ToolStripButton
        Me.txtCategory = New System.Windows.Forms.ComboBox
        CType(Me.DocDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(293, 514)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(57, 13)
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "Category"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(1, 514)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 13)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Expense Item"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(90, 511)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(193, 20)
        Me.txtName.TabIndex = 8
        '
        'DocDataGridView
        '
        Me.DocDataGridView.AllowUserToAddRows = False
        Me.DocDataGridView.AllowUserToDeleteRows = False
        Me.DocDataGridView.AllowUserToResizeColumns = False
        Me.DocDataGridView.AllowUserToResizeRows = False
        Me.DocDataGridView.AutoGenerateColumns = False
        Me.DocDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EXPENSE_NAME, Me.EXP_CATG})
        Me.DocDataGridView.DataSource = Me.ExpBindingSource
        Me.DocDataGridView.Location = New System.Drawing.Point(0, 33)
        Me.DocDataGridView.MultiSelect = False
        Me.DocDataGridView.Name = "DocDataGridView"
        Me.DocDataGridView.ReadOnly = True
        Me.DocDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent
        Me.DocDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DocDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DocDataGridView.Size = New System.Drawing.Size(518, 469)
        Me.DocDataGridView.TabIndex = 7
        '
        'EXPENSE_NAME
        '
        Me.EXPENSE_NAME.DataPropertyName = "EXP_NAME"
        Me.EXPENSE_NAME.HeaderText = "EXPENSE ACCOUNT NAME"
        Me.EXPENSE_NAME.Name = "EXPENSE_NAME"
        Me.EXPENSE_NAME.ReadOnly = True
        Me.EXPENSE_NAME.Width = 250
        '
        'EXP_CATG
        '
        Me.EXP_CATG.DataPropertyName = "EXP_CATG"
        Me.EXP_CATG.HeaderText = "EXPENSE CATEGORY"
        Me.EXP_CATG.Name = "EXP_CATG"
        Me.EXP_CATG.ReadOnly = True
        Me.EXP_CATG.Width = 205
        '
        'ExpBindingSource
        '
        Me.ExpBindingSource.AllowNew = True
        Me.ExpBindingSource.DataSource = Me.ExpDataSet
        Me.ExpBindingSource.Position = 0
        '
        'ExpDataSet
        '
        Me.ExpDataSet.DataSetName = "ExpDataSet"
        Me.ExpDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "DAILY_EXPENSE_ACC"
        '
        'ExpBindingNavigator
        '
        Me.ExpBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ExpBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ExpBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ExpBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripEditButton, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSave, Me.ToolStripCloseButton})
        Me.ExpBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ExpBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ExpBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ExpBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ExpBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ExpBindingNavigator.Name = "ExpBindingNavigator"
        Me.ExpBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ExpBindingNavigator.Size = New System.Drawing.Size(520, 25)
        Me.ExpBindingNavigator.TabIndex = 6
        Me.ExpBindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add new"
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
        'ToolStripEditButton
        '
        Me.ToolStripEditButton.Image = Global.Business_Solutions.My.Resources.Resources.CutHS
        Me.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEditButton.Name = "ToolStripEditButton"
        Me.ToolStripEditButton.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripEditButton.Text = "&Edit"
        '
        'BindingNavigatorSave
        '
        Me.BindingNavigatorSave.Enabled = False
        Me.BindingNavigatorSave.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.BindingNavigatorSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSave.Name = "BindingNavigatorSave"
        Me.BindingNavigatorSave.Size = New System.Drawing.Size(51, 22)
        Me.BindingNavigatorSave.Text = "&Save"
        '
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripCloseButton.Text = "&Close"
        '
        'txtCategory
        '
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Location = New System.Drawing.Point(350, 512)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(167, 21)
        Me.txtCategory.TabIndex = 12
        '
        'frmExpenseList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 537)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.DocDataGridView)
        Me.Controls.Add(Me.ExpBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmExpenseList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExpenseList"
        CType(Me.DocDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpBindingNavigator.ResumeLayout(False)
        Me.ExpBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents DocDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ExpBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ToolStripEditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExpDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ExpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EXPENSE_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXP_CATG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCategory As System.Windows.Forms.ComboBox
End Class
