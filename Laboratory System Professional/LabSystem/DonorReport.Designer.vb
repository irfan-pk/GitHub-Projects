<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonorReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DonorReport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DonorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TextBoxFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripEditButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSaveButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripCloseButton = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DonorDataGrid = New System.Windows.Forms.DataGridView
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDonorID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHIV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHCV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVDRL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DonorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonorDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.cmbVDRL = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbHCV = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbHIV = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbHBS = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbDGroup = New System.Windows.Forms.ComboBox
        Me.cmbPGroup = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DonorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DonorBindingNavigator.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DonorDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DonorBindingNavigator
        '
        Me.DonorBindingNavigator.AddNewItem = Nothing
        Me.DonorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DonorBindingNavigator.DeleteItem = Nothing
        Me.DonorBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DonorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.BindingNavigatorSeparator2, Me.TextBoxFind, Me.ToolStripSeparator1, Me.ToolStripEditButton, Me.ToolStripSeparator3, Me.ToolStripSaveButton, Me.ToolStripSeparator5, Me.ToolStripButtonPrint, Me.ToolStripSeparator6, Me.ToolStripCloseButton})
        Me.DonorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DonorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DonorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DonorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DonorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DonorBindingNavigator.Name = "DonorBindingNavigator"
        Me.DonorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DonorBindingNavigator.Size = New System.Drawing.Size(923, 25)
        Me.DonorBindingNavigator.TabIndex = 42
        Me.DonorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = Global.Business_Solutions.My.Resources.Resources.search2
        Me.ToolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel1.Text = "&Find"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TextBoxFind
        '
        Me.TextBoxFind.Name = "TextBoxFind"
        Me.TextBoxFind.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripEditButton
        '
        Me.ToolStripEditButton.Image = Global.Business_Solutions.My.Resources.Resources.CutHS
        Me.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEditButton.Name = "ToolStripEditButton"
        Me.ToolStripEditButton.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripEditButton.Text = "&Edit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSaveButton
        '
        Me.ToolStripSaveButton.Enabled = False
        Me.ToolStripSaveButton.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.ToolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSaveButton.Name = "ToolStripSaveButton"
        Me.ToolStripSaveButton.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripSaveButton.Text = "&Save"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonPrint
        '
        Me.ToolStripButtonPrint.Enabled = False
        Me.ToolStripButtonPrint.Image = Global.Business_Solutions.My.Resources.Resources.PrintHS
        Me.ToolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
        Me.ToolStripButtonPrint.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButtonPrint.Text = "&Print"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripCloseButton.Text = "&Close"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DonorDataGrid)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtWeight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbVDRL)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbHCV)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbHIV)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbHBS)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbDGroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbPGroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(923, 398)
        Me.SplitContainer1.SplitterDistance = 295
        Me.SplitContainer1.TabIndex = 45
        '
        'DonorDataGrid
        '
        Me.DonorDataGrid.AllowUserToAddRows = False
        Me.DonorDataGrid.AllowUserToDeleteRows = False
        Me.DonorDataGrid.AutoGenerateColumns = False
        Me.DonorDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DonorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DonorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DonorDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colDonorID, Me.colPID, Me.colDName, Me.colAge, Me.colSex, Me.colWT, Me.colHBS, Me.colHIV, Me.colHCV, Me.colVDRL, Me.colGroup, Me.colPGroup})
        Me.DonorDataGrid.DataSource = Me.DonorBindingSource
        Me.DonorDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DonorDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.DonorDataGrid.MultiSelect = False
        Me.DonorDataGrid.Name = "DonorDataGrid"
        Me.DonorDataGrid.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DonorDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DonorDataGrid.RowHeadersVisible = False
        Me.DonorDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.DonorDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.DonorDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DonorDataGrid.Size = New System.Drawing.Size(919, 291)
        Me.DonorDataGrid.TabIndex = 12
        Me.DonorDataGrid.TabStop = False
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "DONOR_DATE"
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colDonorID
        '
        Me.colDonorID.DataPropertyName = "DONOR_ID"
        Me.colDonorID.HeaderText = "Donor ID"
        Me.colDonorID.Name = "colDonorID"
        Me.colDonorID.ReadOnly = True
        '
        'colPID
        '
        Me.colPID.DataPropertyName = "DONOR_PID"
        Me.colPID.HeaderText = "Donor PID"
        Me.colPID.Name = "colPID"
        Me.colPID.ReadOnly = True
        '
        'colDName
        '
        Me.colDName.DataPropertyName = "DONOR_NAME"
        Me.colDName.HeaderText = "Donor Name"
        Me.colDName.Name = "colDName"
        Me.colDName.ReadOnly = True
        Me.colDName.Width = 300
        '
        'colAge
        '
        Me.colAge.DataPropertyName = "DONOR_AGE"
        Me.colAge.HeaderText = "Donor Age"
        Me.colAge.Name = "colAge"
        Me.colAge.ReadOnly = True
        '
        'colSex
        '
        Me.colSex.DataPropertyName = "DONOR_GENDER"
        Me.colSex.HeaderText = "Gender"
        Me.colSex.Name = "colSex"
        Me.colSex.ReadOnly = True
        '
        'colWT
        '
        Me.colWT.DataPropertyName = "DONOR_WT"
        Me.colWT.HeaderText = "Weight"
        Me.colWT.Name = "colWT"
        Me.colWT.ReadOnly = True
        '
        'colHBS
        '
        Me.colHBS.DataPropertyName = "DONOR_HBS"
        Me.colHBS.HeaderText = "HBS Result"
        Me.colHBS.Name = "colHBS"
        Me.colHBS.ReadOnly = True
        '
        'colHIV
        '
        Me.colHIV.DataPropertyName = "DONOR_HIV"
        Me.colHIV.HeaderText = "HIV Result"
        Me.colHIV.Name = "colHIV"
        Me.colHIV.ReadOnly = True
        '
        'colHCV
        '
        Me.colHCV.DataPropertyName = "DONOR_HCV"
        Me.colHCV.HeaderText = "HCV Result"
        Me.colHCV.Name = "colHCV"
        Me.colHCV.ReadOnly = True
        '
        'colVDRL
        '
        Me.colVDRL.DataPropertyName = "DONOR_VDRL"
        Me.colVDRL.HeaderText = "VDRL Result"
        Me.colVDRL.Name = "colVDRL"
        Me.colVDRL.ReadOnly = True
        '
        'colGroup
        '
        Me.colGroup.DataPropertyName = "DONOR_GROUP"
        Me.colGroup.HeaderText = "Donor Group"
        Me.colGroup.Name = "colGroup"
        Me.colGroup.ReadOnly = True
        '
        'colPGroup
        '
        Me.colPGroup.DataPropertyName = "PATIENT_GRP"
        Me.colPGroup.HeaderText = "Patient Group"
        Me.colPGroup.Name = "colPGroup"
        Me.colPGroup.ReadOnly = True
        '
        'DonorBindingSource
        '
        Me.DonorBindingSource.DataSource = Me.DonorDataSet
        Me.DonorBindingSource.Position = 0
        '
        'DonorDataSet
        '
        Me.DonorDataSet.DataSetName = "DonorDataSet"
        Me.DonorDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "DONOR_TABLE"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(80, 24)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(82, 20)
        Me.txtWeight.TabIndex = 0
        '
        'cmbVDRL
        '
        Me.cmbVDRL.FormattingEnabled = True
        Me.cmbVDRL.Items.AddRange(New Object() {"NEGATIVE", "POSITIVE"})
        Me.cmbVDRL.Location = New System.Drawing.Point(757, 59)
        Me.cmbVDRL.Name = "cmbVDRL"
        Me.cmbVDRL.Size = New System.Drawing.Size(151, 21)
        Me.cmbVDRL.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(679, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "VDRL Result"
        '
        'cmbHCV
        '
        Me.cmbHCV.FormattingEnabled = True
        Me.cmbHCV.Items.AddRange(New Object() {"NEGATIVE", "POSITIVE"})
        Me.cmbHCV.Location = New System.Drawing.Point(757, 24)
        Me.cmbHCV.Name = "cmbHCV"
        Me.cmbHCV.Size = New System.Drawing.Size(151, 21)
        Me.cmbHCV.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(679, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "HCV Result"
        '
        'cmbHIV
        '
        Me.cmbHIV.FormattingEnabled = True
        Me.cmbHIV.Items.AddRange(New Object() {"NEGATIVE", "POSITIVE"})
        Me.cmbHIV.Location = New System.Drawing.Point(512, 59)
        Me.cmbHIV.Name = "cmbHIV"
        Me.cmbHIV.Size = New System.Drawing.Size(151, 21)
        Me.cmbHIV.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(434, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "HIV Result"
        '
        'cmbHBS
        '
        Me.cmbHBS.FormattingEnabled = True
        Me.cmbHBS.Items.AddRange(New Object() {"NEGATIVE", "POSITIVE"})
        Me.cmbHBS.Location = New System.Drawing.Point(512, 24)
        Me.cmbHBS.Name = "cmbHBS"
        Me.cmbHBS.Size = New System.Drawing.Size(151, 21)
        Me.cmbHBS.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "HBS Result"
        '
        'cmbDGroup
        '
        Me.cmbDGroup.FormattingEnabled = True
        Me.cmbDGroup.Items.AddRange(New Object() {"A Positive  (A +ve)", "B Positive  (B +ve)", "AB Positive  (AB +ve)", "A Negative  (A -ve)", "B Negative  (B -ve)", "AB Negative  (AB -ve)", "O Positive  (O +ve)", "O Negative  (O -ve)"})
        Me.cmbDGroup.Location = New System.Drawing.Point(248, 59)
        Me.cmbDGroup.Name = "cmbDGroup"
        Me.cmbDGroup.Size = New System.Drawing.Size(165, 21)
        Me.cmbDGroup.TabIndex = 2
        '
        'cmbPGroup
        '
        Me.cmbPGroup.FormattingEnabled = True
        Me.cmbPGroup.Items.AddRange(New Object() {"A Positive  (A +ve)", "B Positive  (B +ve)", "AB Positive  (AB +ve)", "A Negative  (A -ve)", "B Negative  (B -ve)", "AB Negative  (AB -ve)", "O Positive  (O +ve)", "O Negative  (O -ve)"})
        Me.cmbPGroup.Location = New System.Drawing.Point(248, 24)
        Me.cmbPGroup.Name = "cmbPGroup"
        Me.cmbPGroup.Size = New System.Drawing.Size(165, 21)
        Me.cmbPGroup.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Dnr. Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Pt. Group"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Weight"
        '
        'DonorReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 423)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.DonorBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(939, 504)
        Me.Name = "DonorReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donor Report"
        CType(Me.DonorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DonorBindingNavigator.ResumeLayout(False)
        Me.DonorBindingNavigator.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DonorDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DonorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripEditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSaveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DonorDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDonorID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHIV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHCV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVDRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents cmbVDRL As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbHCV As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbHIV As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbHBS As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbDGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextBoxFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DonorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DonorDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
End Class
