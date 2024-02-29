<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectionPoint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CollectionPoint))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollectionDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.CollectionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripSaveButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripCloseButton = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCond = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSpecial = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMob = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOrdinary = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtCpName = New System.Windows.Forms.TextBox
        Me.CollectionDataGridView = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CP_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cp_Incharge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cp_Tel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cp_Mob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOrdinary = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSpecial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colConditional = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.CollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollectionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollectionBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CollectionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CollectionBindingSource
        '
        Me.CollectionBindingSource.DataSource = Me.CollectionDataSet
        Me.CollectionBindingSource.Position = 0
        '
        'CollectionDataSet
        '
        Me.CollectionDataSet.DataSetName = "CollectionDataSet"
        Me.CollectionDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "CollectionPoint"
        '
        'CollectionBindingNavigator
        '
        Me.CollectionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CollectionBindingNavigator.BindingSource = Me.CollectionBindingSource
        Me.CollectionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CollectionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CollectionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripEditButton, Me.BindingNavigatorDeleteItem, Me.ToolStripSaveButton, Me.ToolStripCloseButton})
        Me.CollectionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CollectionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CollectionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CollectionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CollectionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CollectionBindingNavigator.Name = "CollectionBindingNavigator"
        Me.CollectionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CollectionBindingNavigator.Size = New System.Drawing.Size(791, 25)
        Me.CollectionBindingNavigator.TabIndex = 1
        Me.CollectionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(76, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add New"
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
        'ToolStripEditButton
        '
        Me.ToolStripEditButton.Image = Global.Business_Solutions.My.Resources.Resources.CutHS
        Me.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEditButton.Name = "ToolStripEditButton"
        Me.ToolStripEditButton.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripEditButton.Text = "&Edit"
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
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripCloseButton.Text = "&Close"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCond)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSpecial)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtMob)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtOrdinary)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblPhone)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.txtCpName)
        Me.Panel1.Location = New System.Drawing.Point(0, 423)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 126)
        Me.Panel1.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(30, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(49, 20)
        Me.txtID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(672, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Conditional %"
        '
        'txtCond
        '
        Me.txtCond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCond.Location = New System.Drawing.Point(675, 82)
        Me.txtCond.Name = "txtCond"
        Me.txtCond.Size = New System.Drawing.Size(88, 20)
        Me.txtCond.TabIndex = 10
        Me.txtCond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(578, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Special %"
        '
        'txtSpecial
        '
        Me.txtSpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSpecial.Location = New System.Drawing.Point(581, 82)
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.Size = New System.Drawing.Size(88, 20)
        Me.txtSpecial.TabIndex = 9
        Me.txtSpecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(672, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Mobile #"
        '
        'txtMob
        '
        Me.txtMob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMob.Location = New System.Drawing.Point(675, 36)
        Me.txtMob.Name = "txtMob"
        Me.txtMob.Size = New System.Drawing.Size(88, 20)
        Me.txtMob.TabIndex = 5
        Me.txtMob.Text = "00"
        Me.txtMob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(486, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Ordinary %"
        '
        'txtOrdinary
        '
        Me.txtOrdinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrdinary.Location = New System.Drawing.Point(489, 82)
        Me.txtOrdinary.Name = "txtOrdinary"
        Me.txtOrdinary.Size = New System.Drawing.Size(86, 20)
        Me.txtOrdinary.TabIndex = 8
        Me.txtOrdinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(351, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "State"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(354, 82)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(129, 20)
        Me.txtCity.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(30, 82)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(318, 20)
        Me.txtAddress.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Incharge Name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(393, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(182, 20)
        Me.txtName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cp ID"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(578, 20)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(79, 13)
        Me.lblPhone.TabIndex = 27
        Me.lblPhone.Text = "Telephone #"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(581, 36)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(88, 20)
        Me.txtPhone.TabIndex = 4
        Me.txtPhone.Text = "00"
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(82, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(132, 13)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "Collection Point Name"
        '
        'txtCpName
        '
        Me.txtCpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCpName.Location = New System.Drawing.Point(85, 36)
        Me.txtCpName.Name = "txtCpName"
        Me.txtCpName.Size = New System.Drawing.Size(302, 20)
        Me.txtCpName.TabIndex = 2
        '
        'CollectionDataGridView
        '
        Me.CollectionDataGridView.AllowUserToAddRows = False
        Me.CollectionDataGridView.AllowUserToDeleteRows = False
        Me.CollectionDataGridView.AutoGenerateColumns = False
        Me.CollectionDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.CollectionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CollectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CollectionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.CP_NAME, Me.Cp_Incharge, Me.Cp_Tel, Me.Cp_Mob, Me.colAddress, Me.colCity, Me.colOrdinary, Me.colSpecial, Me.colConditional})
        Me.CollectionDataGridView.DataSource = Me.CollectionBindingSource
        Me.CollectionDataGridView.Location = New System.Drawing.Point(0, 26)
        Me.CollectionDataGridView.MultiSelect = False
        Me.CollectionDataGridView.Name = "CollectionDataGridView"
        Me.CollectionDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CollectionDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CollectionDataGridView.RowHeadersVisible = False
        Me.CollectionDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.CollectionDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.CollectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CollectionDataGridView.Size = New System.Drawing.Size(791, 391)
        Me.CollectionDataGridView.TabIndex = 11
        Me.CollectionDataGridView.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "CP_ID"
        Me.colID.HeaderText = "CP ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'CP_NAME
        '
        Me.CP_NAME.DataPropertyName = "Cp_Name"
        Me.CP_NAME.HeaderText = "Collection Point Name"
        Me.CP_NAME.Name = "CP_NAME"
        Me.CP_NAME.ReadOnly = True
        Me.CP_NAME.Width = 300
        '
        'Cp_Incharge
        '
        Me.Cp_Incharge.DataPropertyName = "CP_INCHARGE"
        Me.Cp_Incharge.HeaderText = "Incharge Name"
        Me.Cp_Incharge.Name = "Cp_Incharge"
        Me.Cp_Incharge.ReadOnly = True
        Me.Cp_Incharge.Width = 200
        '
        'Cp_Tel
        '
        Me.Cp_Tel.DataPropertyName = "Cp_Tel"
        Me.Cp_Tel.HeaderText = "Telephone"
        Me.Cp_Tel.Name = "Cp_Tel"
        Me.Cp_Tel.ReadOnly = True
        '
        'Cp_Mob
        '
        Me.Cp_Mob.DataPropertyName = "Cp_Mob"
        Me.Cp_Mob.HeaderText = "Mobile"
        Me.Cp_Mob.Name = "Cp_Mob"
        Me.Cp_Mob.ReadOnly = True
        Me.Cp_Mob.Width = 146
        '
        'colAddress
        '
        Me.colAddress.DataPropertyName = "CP_ADDRESS"
        Me.colAddress.HeaderText = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        '
        'colCity
        '
        Me.colCity.DataPropertyName = "CP_CITY"
        Me.colCity.HeaderText = "City"
        Me.colCity.Name = "colCity"
        Me.colCity.ReadOnly = True
        '
        'colOrdinary
        '
        Me.colOrdinary.DataPropertyName = "CP_ORDINARY"
        Me.colOrdinary.HeaderText = "Ordinary"
        Me.colOrdinary.Name = "colOrdinary"
        Me.colOrdinary.ReadOnly = True
        '
        'colSpecial
        '
        Me.colSpecial.DataPropertyName = "CP_SPECIAL"
        Me.colSpecial.HeaderText = "Special"
        Me.colSpecial.Name = "colSpecial"
        Me.colSpecial.ReadOnly = True
        '
        'colConditional
        '
        Me.colConditional.DataPropertyName = "CP_CONDITIONAL"
        Me.colConditional.HeaderText = "Conditional"
        Me.colConditional.Name = "colConditional"
        Me.colConditional.ReadOnly = True
        '
        'CollectionPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(791, 550)
        Me.Controls.Add(Me.CollectionDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CollectionBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CollectionPoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection Point"
        CType(Me.CollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollectionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CollectionBindingNavigator.ResumeLayout(False)
        Me.CollectionBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CollectionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CollectionBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ToolStripSaveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripEditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSpecial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMob As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOrdinary As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtCpName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCond As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents CollectionDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents CollectionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cp_Incharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cp_Tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cp_Mob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOrdinary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSpecial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colConditional As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
