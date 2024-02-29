<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTests
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTests))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEditItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorCloseItem = New System.Windows.Forms.ToolStripButton
        Me.TestDataGrid = New System.Windows.Forms.DataGridView
        Me.TCODE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCATG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TSAMPLE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TREPORT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRPTLVL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDISCMODE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtDiscMode = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtLvl = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtReport = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSpecimen = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCatg = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.TestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TestBindingNavigator.SuspendLayout()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TestBindingNavigator
        '
        Me.TestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TestBindingNavigator.BindingSource = Me.TestBindingSource
        Me.TestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorFindItem, Me.ToolStripSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorEditItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem, Me.ToolStripSeparator2, Me.BindingNavigatorCloseItem})
        Me.TestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TestBindingNavigator.Name = "TestBindingNavigator"
        Me.TestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TestBindingNavigator.Size = New System.Drawing.Size(870, 25)
        Me.TestBindingNavigator.TabIndex = 0
        Me.TestBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add new"
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataSource = Me.TestDataSet
        Me.TestBindingSource.Position = 0
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "TestDataSet"
        Me.TestDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "TESTS"
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
        Me.BindingNavigatorFindItem.Image = Global.Business_Solutions.My.Resources.Resources.FindHS
        Me.BindingNavigatorFindItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorFindItem.Name = "BindingNavigatorFindItem"
        Me.BindingNavigatorFindItem.Size = New System.Drawing.Size(50, 22)
        Me.BindingNavigatorFindItem.Text = "&Find"
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
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Enabled = False
        Me.BindingNavigatorSaveItem.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(51, 22)
        Me.BindingNavigatorSaveItem.Text = "&Save"
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
        '
        'TestDataGrid
        '
        Me.TestDataGrid.AllowUserToAddRows = False
        Me.TestDataGrid.AllowUserToResizeRows = False
        Me.TestDataGrid.AutoGenerateColumns = False
        Me.TestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TestDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCODE, Me.TNAME, Me.TCATG, Me.TRATE, Me.TSAMPLE, Me.TREPORT, Me.TRPTLVL, Me.TDISCMODE})
        Me.TestDataGrid.DataSource = Me.TestBindingSource
        Me.TestDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TestDataGrid.Location = New System.Drawing.Point(5, 34)
        Me.TestDataGrid.MultiSelect = False
        Me.TestDataGrid.Name = "TestDataGrid"
        Me.TestDataGrid.ReadOnly = True
        Me.TestDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TestDataGrid.Size = New System.Drawing.Size(860, 376)
        Me.TestDataGrid.TabIndex = 1
        Me.TestDataGrid.TabStop = False
        '
        'TCODE
        '
        Me.TCODE.DataPropertyName = "tcode"
        Me.TCODE.HeaderText = "Test Code"
        Me.TCODE.Name = "TCODE"
        Me.TCODE.ReadOnly = True
        '
        'TNAME
        '
        Me.TNAME.DataPropertyName = "tname"
        Me.TNAME.HeaderText = "Test Name"
        Me.TNAME.Name = "TNAME"
        Me.TNAME.ReadOnly = True
        '
        'TCATG
        '
        Me.TCATG.DataPropertyName = "tcatg"
        Me.TCATG.HeaderText = "Test Category"
        Me.TCATG.Name = "TCATG"
        Me.TCATG.ReadOnly = True
        '
        'TRATE
        '
        Me.TRATE.DataPropertyName = "TRATE"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.TRATE.DefaultCellStyle = DataGridViewCellStyle1
        Me.TRATE.HeaderText = "Test Price"
        Me.TRATE.Name = "TRATE"
        Me.TRATE.ReadOnly = True
        '
        'TSAMPLE
        '
        Me.TSAMPLE.DataPropertyName = "tsample"
        Me.TSAMPLE.HeaderText = "Specimen"
        Me.TSAMPLE.Name = "TSAMPLE"
        Me.TSAMPLE.ReadOnly = True
        '
        'TREPORT
        '
        Me.TREPORT.DataPropertyName = "treport"
        Me.TREPORT.HeaderText = "Report Time"
        Me.TREPORT.Name = "TREPORT"
        Me.TREPORT.ReadOnly = True
        '
        'TRPTLVL
        '
        Me.TRPTLVL.DataPropertyName = "trptlvl"
        Me.TRPTLVL.HeaderText = "Report Level"
        Me.TRPTLVL.Name = "TRPTLVL"
        Me.TRPTLVL.ReadOnly = True
        '
        'TDISCMODE
        '
        Me.TDISCMODE.DataPropertyName = "tdiscmode"
        Me.TDISCMODE.HeaderText = "Discount Mode"
        Me.TDISCMODE.Name = "TDISCMODE"
        Me.TDISCMODE.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtDiscMode)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtLvl)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtReport)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtSpecimen)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCatg)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 96)
        Me.Panel1.TabIndex = 2
        '
        'txtDiscMode
        '
        Me.txtDiscMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtDiscMode.FormattingEnabled = True
        Me.txtDiscMode.Items.AddRange(New Object() {"NORMAL", "SPECIAL", "LIMITED", "CONDITIONAL"})
        Me.txtDiscMode.Location = New System.Drawing.Point(592, 63)
        Me.txtDiscMode.Name = "txtDiscMode"
        Me.txtDiscMode.Size = New System.Drawing.Size(184, 21)
        Me.txtDiscMode.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(493, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Discount Mode"
        '
        'txtLvl
        '
        Me.txtLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLvl.Location = New System.Drawing.Point(382, 63)
        Me.txtLvl.Name = "txtLvl"
        Me.txtLvl.Size = New System.Drawing.Size(97, 20)
        Me.txtLvl.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(338, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Level"
        '
        'txtReport
        '
        Me.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReport.Location = New System.Drawing.Point(83, 63)
        Me.txtReport.Name = "txtReport"
        Me.txtReport.Size = New System.Drawing.Size(215, 20)
        Me.txtReport.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Report On"
        '
        'txtSpecimen
        '
        Me.txtSpecimen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSpecimen.Location = New System.Drawing.Point(591, 36)
        Me.txtSpecimen.Name = "txtSpecimen"
        Me.txtSpecimen.Size = New System.Drawing.Size(249, 20)
        Me.txtSpecimen.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(493, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Specimen"
        '
        'txtRate
        '
        Me.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRate.Location = New System.Drawing.Point(382, 36)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(97, 20)
        Me.txtRate.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(319, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Test Rate"
        '
        'txtCatg
        '
        Me.txtCatg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatg.Location = New System.Drawing.Point(83, 36)
        Me.txtCatg.Name = "txtCatg"
        Me.txtCatg.Size = New System.Drawing.Size(215, 20)
        Me.txtCatg.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(382, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(458, 20)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Test Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(83, 10)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(97, 20)
        Me.txtCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test Code"
        '
        'frmTests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(870, 514)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TestDataGrid)
        Me.Controls.Add(Me.TestBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(876, 543)
        Me.MinimumSize = New System.Drawing.Size(876, 543)
        Me.Name = "frmTests"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tests List Maintenance"
        CType(Me.TestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TestBindingNavigator.ResumeLayout(False)
        Me.TestBindingNavigator.PerformLayout()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TestDataSet As System.Data.DataSet
    Friend WithEvents TestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigatorEditItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCloseItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCatg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSpecimen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLvl As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigatorFindItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtDiscMode As System.Windows.Forms.ComboBox
    Friend WithEvents TCODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCATG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TSAMPLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TREPORT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRPTLVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDISCMODE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
