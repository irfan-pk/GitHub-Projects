<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpense))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ExpDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.ExpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocDataGridView = New System.Windows.Forms.DataGridView
        Me.EXPENSE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXP_CATG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Exp_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.ToolStripViewButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripCloseButton = New System.Windows.Forms.ToolStripButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.ExpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Expense Item"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(93, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'ExpDataSet
        '
        Me.ExpDataSet.DataSetName = "ExpDataSet"
        Me.ExpDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "DAILY_EXPENSES"
        '
        'ExpBindingSource
        '
        Me.ExpBindingSource.AllowNew = True
        Me.ExpBindingSource.DataSource = Me.ExpDataSet
        Me.ExpBindingSource.Position = 0
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
        Me.DocDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EXPENSE_NAME, Me.EXP_CATG, Me.Exp_amount})
        Me.DocDataGridView.DataSource = Me.ExpBindingSource
        Me.DocDataGridView.Location = New System.Drawing.Point(0, 42)
        Me.DocDataGridView.MultiSelect = False
        Me.DocDataGridView.Name = "DocDataGridView"
        Me.DocDataGridView.ReadOnly = True
        Me.DocDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent
        Me.DocDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DocDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DocDataGridView.Size = New System.Drawing.Size(772, 372)
        Me.DocDataGridView.TabIndex = 8
        '
        'EXPENSE_NAME
        '
        Me.EXPENSE_NAME.DataPropertyName = "EXP_NAME"
        Me.EXPENSE_NAME.HeaderText = "EXPENSE ACCOUNT NAME"
        Me.EXPENSE_NAME.Name = "EXPENSE_NAME"
        Me.EXPENSE_NAME.ReadOnly = True
        Me.EXPENSE_NAME.Width = 300
        '
        'EXP_CATG
        '
        Me.EXP_CATG.DataPropertyName = "EXP_CATG"
        Me.EXP_CATG.HeaderText = "EXPENSE CATEGORY"
        Me.EXP_CATG.Name = "EXP_CATG"
        Me.EXP_CATG.ReadOnly = True
        Me.EXP_CATG.Width = 205
        '
        'Exp_amount
        '
        Me.Exp_amount.DataPropertyName = "EXP_AMOUNT"
        Me.Exp_amount.HeaderText = "EXPENSE AMOUNT"
        Me.Exp_amount.Name = "Exp_amount"
        Me.Exp_amount.ReadOnly = True
        Me.Exp_amount.Width = 150
        '
        'ExpBindingNavigator
        '
        Me.ExpBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ExpBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ExpBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ExpBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExpBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripEditButton, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSave, Me.ToolStripViewButton, Me.ToolStripCloseButton})
        Me.ExpBindingNavigator.Location = New System.Drawing.Point(0, 415)
        Me.ExpBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ExpBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ExpBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ExpBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ExpBindingNavigator.Name = "ExpBindingNavigator"
        Me.ExpBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ExpBindingNavigator.Size = New System.Drawing.Size(772, 25)
        Me.ExpBindingNavigator.TabIndex = 11
        Me.ExpBindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(121, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add Expense Item"
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
        'ToolStripViewButton
        '
        Me.ToolStripViewButton.Image = Global.Business_Solutions.My.Resources.Resources.book_addressHS
        Me.ToolStripViewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripViewButton.Name = "ToolStripViewButton"
        Me.ToolStripViewButton.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripViewButton.Text = "&View Sheet"
        '
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripCloseButton.Text = "&Close"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(547, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 21)
        Me.TextBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(441, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Expense Amount"
        '
        'frmExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 440)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ExpBindingNavigator)
        Me.Controls.Add(Me.DocDataGridView)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExpense"
        CType(Me.ExpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpBindingNavigator.ResumeLayout(False)
        Me.ExpBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ExpDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ExpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EXPENSE_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXP_CATG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exp_amount As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ToolStripViewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
