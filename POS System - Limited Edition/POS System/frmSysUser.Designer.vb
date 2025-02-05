<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysUser))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.UserDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.UserBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.UserbindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCNIC = New System.Windows.Forms.MaskedTextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLevel = New System.Windows.Forms.TextBox
        Me.cmbUserType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripEditButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSaveButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripCloseButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.UserId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNIC = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserBindingNavigator.SuspendLayout()
        CType(Me.UserbindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "USERS"
        '
        'UserBindingNavigator
        '
        Me.UserBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserBindingNavigator.BackColor = System.Drawing.Color.PaleGreen
        Me.UserBindingNavigator.BindingSource = Me.UserbindingSource
        Me.UserBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator3, Me.ToolStripEditButton, Me.ToolStripSeparator1, Me.ToolStripSaveButton, Me.ToolStripSeparator4, Me.ToolStripCloseButton, Me.ToolStripSeparator5})
        Me.UserBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserBindingNavigator.Name = "UserBindingNavigator"
        Me.UserBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserBindingNavigator.Size = New System.Drawing.Size(724, 25)
        Me.UserBindingNavigator.TabIndex = 0
        Me.UserBindingNavigator.Text = "BindingNavigator1"
        '
        'UserbindingSource
        '
        Me.UserbindingSource.DataSource = Me.UserDataSet
        Me.UserbindingSource.Position = 0
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UsersDataGridView
        '
        Me.UsersDataGridView.AllowUserToAddRows = False
        Me.UsersDataGridView.AutoGenerateColumns = False
        Me.UsersDataGridView.BackgroundColor = System.Drawing.Color.OldLace
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserId, Me.UserName, Me.colName, Me.UserType, Me.UserStatus, Me.colNIC})
        Me.UsersDataGridView.DataSource = Me.UserbindingSource
        Me.UsersDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.ReadOnly = True
        Me.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersDataGridView.Size = New System.Drawing.Size(723, 346)
        Me.UsersDataGridView.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtCNIC)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtLevel)
        Me.Panel1.Controls.Add(Me.cmbUserType)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPwd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtUserName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtUserID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(0, 378)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 67)
        Me.Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(416, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CNIC"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCNIC
        '
        Me.txtCNIC.Location = New System.Drawing.Point(462, 36)
        Me.txtCNIC.Mask = "00000-0000000-0"
        Me.txtCNIC.Name = "txtCNIC"
        Me.txtCNIC.Size = New System.Drawing.Size(94, 20)
        Me.txtCNIC.TabIndex = 5
        Me.txtCNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(461, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(253, 20)
        Me.txtName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLevel
        '
        Me.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLevel.Enabled = False
        Me.txtLevel.Location = New System.Drawing.Point(663, 36)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(51, 20)
        Me.txtLevel.TabIndex = 6
        Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbUserType
        '
        Me.cmbUserType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Administrator", "Super User", "User"})
        Me.cmbUserType.Location = New System.Drawing.Point(80, 36)
        Me.cmbUserType.MaxDropDownItems = 4
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(131, 21)
        Me.cmbUserType.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(583, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Security Lvl"
        '
        'txtPwd
        '
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Location = New System.Drawing.Point(304, 35)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(95, 20)
        Me.txtPwd.TabIndex = 4
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Type"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Location = New System.Drawing.Point(231, 9)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(168, 20)
        Me.txtUserName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUserID
        '
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.Enabled = False
        Me.txtUserID.Location = New System.Drawing.Point(80, 9)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(70, 20)
        Me.txtUserID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add new"
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
        'ToolStripEditButton
        '
        Me.ToolStripEditButton.Image = Global.POS_System.My.Resources.Resources.data_edit2
        Me.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEditButton.Name = "ToolStripEditButton"
        Me.ToolStripEditButton.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripEditButton.Text = "&Edit"
        '
        'ToolStripSaveButton
        '
        Me.ToolStripSaveButton.Enabled = False
        Me.ToolStripSaveButton.Image = Global.POS_System.My.Resources.Resources.saveHS2
        Me.ToolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSaveButton.Name = "ToolStripSaveButton"
        Me.ToolStripSaveButton.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripSaveButton.Text = "&Save"
        '
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Image = Global.POS_System.My.Resources.Resources.remove1
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripCloseButton.Text = "&Close"
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'UserId
        '
        Me.UserId.DataPropertyName = "UserId"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UserId.DefaultCellStyle = DataGridViewCellStyle1
        Me.UserId.HeaderText = "User Id"
        Me.UserId.Name = "UserId"
        Me.UserId.ReadOnly = True
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "User Name"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'colName
        '
        Me.colName.DataPropertyName = "Name"
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 150
        '
        'UserType
        '
        Me.UserType.DataPropertyName = "UserRole"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UserType.DefaultCellStyle = DataGridViewCellStyle2
        Me.UserType.HeaderText = "User Type"
        Me.UserType.Name = "UserType"
        Me.UserType.ReadOnly = True
        Me.UserType.Width = 120
        '
        'UserStatus
        '
        Me.UserStatus.DataPropertyName = "Active"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UserStatus.DefaultCellStyle = DataGridViewCellStyle3
        Me.UserStatus.HeaderText = "Active"
        Me.UserStatus.Name = "UserStatus"
        Me.UserStatus.ReadOnly = True
        Me.UserStatus.Width = 110
        '
        'colNIC
        '
        Me.colNIC.DataPropertyName = "CardNumber"
        Me.colNIC.HeaderText = "CNIC #"
        Me.colNIC.Name = "colNIC"
        Me.colNIC.ReadOnly = True
        '
        'frmSysUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 443)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UsersDataGridView)
        Me.Controls.Add(Me.UserBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(730, 472)
        Me.MinimumSize = New System.Drawing.Size(730, 472)
        Me.Name = "frmSysUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add / Edit System User"
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserBindingNavigator.ResumeLayout(False)
        Me.UserBindingNavigator.PerformLayout()
        CType(Me.UserbindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserDataSet As System.Data.DataSet
    Friend WithEvents UserBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UserbindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripEditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSaveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents txtLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCNIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNIC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
