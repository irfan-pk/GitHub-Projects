<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Waiters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Waiters))
        Me.CompanyDataGridView = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CP_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cp_Incharge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cp_Mob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New System.Data.DataSet
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCNIC = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.CompanyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        CType(Me.CompanyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CompanyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompanyBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompanyDataGridView
        '
        Me.CompanyDataGridView.AllowUserToAddRows = False
        Me.CompanyDataGridView.AllowUserToDeleteRows = False
        Me.CompanyDataGridView.AutoGenerateColumns = False
        Me.CompanyDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CompanyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompanyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.CP_NAME, Me.Cp_Incharge, Me.Cp_Mob, Me.colAddress})
        Me.CompanyDataGridView.DataSource = Me.CompanyBindingSource
        Me.CompanyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompanyDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.CompanyDataGridView.MultiSelect = False
        Me.CompanyDataGridView.Name = "CompanyDataGridView"
        Me.CompanyDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CompanyDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CompanyDataGridView.RowHeadersVisible = False
        Me.CompanyDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.CompanyDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.CompanyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompanyDataGridView.Size = New System.Drawing.Size(942, 320)
        Me.CompanyDataGridView.TabIndex = 11
        Me.CompanyDataGridView.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "WAITER_ID"
        Me.colID.HeaderText = "Waiter ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'CP_NAME
        '
        Me.CP_NAME.DataPropertyName = "waiter_name"
        Me.CP_NAME.HeaderText = "Waiter Name"
        Me.CP_NAME.Name = "CP_NAME"
        Me.CP_NAME.ReadOnly = True
        Me.CP_NAME.Width = 180
        '
        'Cp_Incharge
        '
        Me.Cp_Incharge.DataPropertyName = "waiter_Address"
        Me.Cp_Incharge.HeaderText = "Address"
        Me.Cp_Incharge.Name = "Cp_Incharge"
        Me.Cp_Incharge.ReadOnly = True
        Me.Cp_Incharge.Width = 310
        '
        'Cp_Mob
        '
        Me.Cp_Mob.DataPropertyName = "waiter_contact"
        Me.Cp_Mob.HeaderText = "Mobile"
        Me.Cp_Mob.Name = "Cp_Mob"
        Me.Cp_Mob.ReadOnly = True
        Me.Cp_Mob.Width = 148
        '
        'colAddress
        '
        Me.colAddress.DataPropertyName = "waiter_nic"
        Me.colAddress.HeaderText = "CNIC #"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Width = 200
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
        Me.CompanyBindingSource.Position = 0
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCNIC)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.lblPhone)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 345)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 126)
        Me.Panel1.TabIndex = 12
        '
        'txtCNIC
        '
        Me.txtCNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNIC.Location = New System.Drawing.Point(562, 77)
        Me.txtCNIC.Mask = "00000-0000000-0"
        Me.txtCNIC.Name = "txtCNIC"
        Me.txtCNIC.Size = New System.Drawing.Size(173, 22)
        Me.txtCNIC.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(559, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "CNIC #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(69, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(72, 77)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(426, 22)
        Me.txtAddress.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(67, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Waiter ID"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(70, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(115, 22)
        Me.txtID.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Yellow
        Me.lblPhone.Location = New System.Drawing.Point(559, 20)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(63, 13)
        Me.lblPhone.TabIndex = 27
        Me.lblPhone.Text = "Contact #"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(562, 36)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(173, 22)
        Me.txtPhone.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Yellow
        Me.lblName.Location = New System.Drawing.Point(193, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(80, 13)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "Waiter Name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(196, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(302, 22)
        Me.txtName.TabIndex = 2
        '
        'CompanyBindingNavigator
        '
        Me.CompanyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CompanyBindingNavigator.BackColor = System.Drawing.Color.LightSeaGreen
        Me.CompanyBindingNavigator.BindingSource = Me.CompanyBindingSource
        Me.CompanyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CompanyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CompanyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripEditButton, Me.BindingNavigatorDeleteItem, Me.ToolStripSaveButton, Me.ToolStripCloseButton})
        Me.CompanyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CompanyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CompanyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CompanyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CompanyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CompanyBindingNavigator.Name = "CompanyBindingNavigator"
        Me.CompanyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CompanyBindingNavigator.Size = New System.Drawing.Size(942, 25)
        Me.CompanyBindingNavigator.TabIndex = 41
        Me.CompanyBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.Yellow
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(82, 22)
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
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.Yellow
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(65, 22)
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
        Me.ToolStripEditButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripEditButton.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripEditButton.Image = Global.POS_System.My.Resources.Resources.data_edit1
        Me.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEditButton.Name = "ToolStripEditButton"
        Me.ToolStripEditButton.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripEditButton.Text = "&Edit"
        '
        'ToolStripSaveButton
        '
        Me.ToolStripSaveButton.Enabled = False
        Me.ToolStripSaveButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripSaveButton.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripSaveButton.Image = Global.POS_System.My.Resources.Resources.saveHS
        Me.ToolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSaveButton.Name = "ToolStripSaveButton"
        Me.ToolStripSaveButton.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripSaveButton.Text = "&Save"
        '
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripCloseButton.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripCloseButton.Image = Global.POS_System.My.Resources.Resources._1480383006_xfce_system_exit2
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripCloseButton.Text = "&Close"
        '
        'Waiters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 471)
        Me.Controls.Add(Me.CompanyDataGridView)
        Me.Controls.Add(Me.CompanyBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Waiters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Companies List"
        CType(Me.CompanyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CompanyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompanyBindingNavigator.ResumeLayout(False)
        Me.CompanyBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompanyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents CompanyDataSet As System.Data.DataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ToolStripSaveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cp_Incharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cp_Mob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCNIC As System.Windows.Forms.MaskedTextBox
End Class
