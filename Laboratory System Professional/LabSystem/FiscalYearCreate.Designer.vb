<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiscalYearCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FiscalYearCreate))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblFiscal = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.colSeq = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStart = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEnd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FiscalDataSet = New System.Data.DataSet
        Me.FiscalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEditItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorCloseCycleItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorCloseItem = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiscalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiscalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FiscalBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblFiscal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(336, 95)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(93, 28)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFiscal
        '
        Me.lblFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiscal.Location = New System.Drawing.Point(198, 95)
        Me.lblFiscal.Name = "lblFiscal"
        Me.lblFiscal.Size = New System.Drawing.Size(132, 28)
        Me.lblFiscal.TabIndex = 4
        Me.lblFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fiscal Year"
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(198, 58)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(231, 22)
        Me.dtpEnd.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fiscal Period End"
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(198, 23)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(231, 22)
        Me.dtpStart.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fiscal Period Start"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeq, Me.colPeriod, Me.colStart, Me.colEnd, Me.colStatus})
        Me.DataGridView.DataSource = Me.FiscalBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(12, 49)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.Size = New System.Drawing.Size(511, 139)
        Me.DataGridView.TabIndex = 0
        '
        'colSeq
        '
        Me.colSeq.DataPropertyName = "FISCAL_YEAR_SEQ"
        Me.colSeq.HeaderText = "Seq #"
        Me.colSeq.Name = "colSeq"
        Me.colSeq.ReadOnly = True
        Me.colSeq.Width = 50
        '
        'colPeriod
        '
        Me.colPeriod.DataPropertyName = "FISCAL_YEAR_PERIOD"
        Me.colPeriod.HeaderText = "Period"
        Me.colPeriod.Name = "colPeriod"
        Me.colPeriod.ReadOnly = True
        '
        'colStart
        '
        Me.colStart.DataPropertyName = "FISCAL_YEAR_START"
        Me.colStart.HeaderText = "Start Date"
        Me.colStart.Name = "colStart"
        Me.colStart.ReadOnly = True
        '
        'colEnd
        '
        Me.colEnd.DataPropertyName = "FISCAL_YEAR_END"
        Me.colEnd.HeaderText = "End Data"
        Me.colEnd.Name = "colEnd"
        Me.colEnd.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.DataPropertyName = "FISCAL_YEAR_STATUS"
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'FiscalBindingSource
        '
        Me.FiscalBindingSource.DataSource = Me.FiscalDataSet
        Me.FiscalBindingSource.Position = 0
        '
        'FiscalDataSet
        '
        Me.FiscalDataSet.DataSetName = "FiscalDataSet"
        '
        'FiscalBindingNavigator
        '
        Me.FiscalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FiscalBindingNavigator.BindingSource = Me.FiscalBindingSource
        Me.FiscalBindingNavigator.CountItem = Nothing
        Me.FiscalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FiscalBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FiscalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.ToolStripSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorEditItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator3, Me.BindingNavigatorCloseCycleItem, Me.ToolStripSeparator4, Me.BindingNavigatorSaveItem, Me.ToolStripSeparator2, Me.BindingNavigatorCloseItem})
        Me.FiscalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FiscalBindingNavigator.MoveFirstItem = Nothing
        Me.FiscalBindingNavigator.MoveLastItem = Nothing
        Me.FiscalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FiscalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FiscalBindingNavigator.Name = "FiscalBindingNavigator"
        Me.FiscalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FiscalBindingNavigator.Size = New System.Drawing.Size(535, 25)
        Me.FiscalBindingNavigator.TabIndex = 4
        Me.FiscalBindingNavigator.Text = "BindingNavigator"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(76, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add New"
        Me.BindingNavigatorAddNewItem.ToolTipText = "Add New Financial Period"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "&Delete"
        Me.BindingNavigatorDeleteItem.ToolTipText = "Delete wrong Financial Period"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorEditItem
        '
        Me.BindingNavigatorEditItem.Image = Global.Business_Solutions.My.Resources.Resources.data_edit
        Me.BindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEditItem.Name = "BindingNavigatorEditItem"
        Me.BindingNavigatorEditItem.Size = New System.Drawing.Size(47, 22)
        Me.BindingNavigatorEditItem.Text = "&Edit"
        Me.BindingNavigatorEditItem.ToolTipText = "Edit Open Financial Period"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorCloseCycleItem
        '
        Me.BindingNavigatorCloseCycleItem.Image = Global.Business_Solutions.My.Resources.Resources.remove_field
        Me.BindingNavigatorCloseCycleItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorCloseCycleItem.Name = "BindingNavigatorCloseCycleItem"
        Me.BindingNavigatorCloseCycleItem.Size = New System.Drawing.Size(93, 22)
        Me.BindingNavigatorCloseCycleItem.Text = "Close &Period"
        Me.BindingNavigatorCloseCycleItem.ToolTipText = "Close Financial Period"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Enabled = False
        Me.BindingNavigatorSaveItem.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(51, 22)
        Me.BindingNavigatorSaveItem.Text = "&Save"
        Me.BindingNavigatorSaveItem.ToolTipText = "Save current changes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorCloseItem
        '
        Me.BindingNavigatorCloseItem.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.BindingNavigatorCloseItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorCloseItem.Name = "BindingNavigatorCloseItem"
        Me.BindingNavigatorCloseItem.Size = New System.Drawing.Size(56, 22)
        Me.BindingNavigatorCloseItem.Text = "&Close"
        Me.BindingNavigatorCloseItem.ToolTipText = "Close Window"
        '
        'FiscalYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 350)
        Me.Controls.Add(Me.FiscalBindingNavigator)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FiscalYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiscal Year"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiscalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiscalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FiscalBindingNavigator.ResumeLayout(False)
        Me.FiscalBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFiscal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents FiscalBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorCloseItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FiscalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FiscalDataSet As System.Data.DataSet
    Friend WithEvents colSeq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPeriod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigatorCloseCycleItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
