<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.InvDataGrid = New System.Windows.Forms.DataGridView
        Me.InvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.dtpUpdateOn = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtInvName = New System.Windows.Forms.TextBox
        Me.InvBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BindingNavigatorFindItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEditItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorCloseItem = New System.Windows.Forms.ToolStripButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtInvID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtRPack = New System.Windows.Forms.TextBox
        Me.txtRPack2 = New System.Windows.Forms.MaskedTextBox
        Me.txtRPack1 = New System.Windows.Forms.MaskedTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPacking = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPerPack = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtRetail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtR2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtR1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.col_inv_code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inv_per_pck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.INV_PPACK_R = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_qty_r1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_qty_r2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_pck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_pck_price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_pch_price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_inv_upd_dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.InvDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InvDataGrid
        '
        Me.InvDataGrid.AllowUserToAddRows = False
        Me.InvDataGrid.AllowUserToDeleteRows = False
        Me.InvDataGrid.AllowUserToResizeRows = False
        Me.InvDataGrid.AutoGenerateColumns = False
        Me.InvDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.InvDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InvDataGrid.ColumnHeadersHeight = 35
        Me.InvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.InvDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_inv_code, Me.col_inv_desc, Me.col_inv_type, Me.inv_per_pck, Me.col_inv_qty, Me.INV_PPACK_R, Me.col_inv_qty_r1, Me.col_inv_qty_r2, Me.col_inv_pck, Me.col_inv_pck_price, Me.col_inv_pch_price, Me.col_inv_upd_dt})
        Me.InvDataGrid.DataSource = Me.InvBindingSource
        Me.InvDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InvDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.InvDataGrid.Location = New System.Drawing.Point(0, 25)
        Me.InvDataGrid.MultiSelect = False
        Me.InvDataGrid.Name = "InvDataGrid"
        Me.InvDataGrid.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.InvDataGrid.RowHeadersVisible = False
        Me.InvDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InvDataGrid.Size = New System.Drawing.Size(986, 385)
        Me.InvDataGrid.TabIndex = 100
        Me.InvDataGrid.TabStop = False
        '
        'InvBindingSource
        '
        Me.InvBindingSource.DataSource = Me.InvDataSet
        Me.InvBindingSource.Position = 0
        '
        'InvDataSet
        '
        Me.InvDataSet.DataSetName = "InvDataSet"
        Me.InvDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "INVENTORY"
        '
        'dtpUpdateOn
        '
        Me.dtpUpdateOn.Location = New System.Drawing.Point(114, 64)
        Me.dtpUpdateOn.Name = "dtpUpdateOn"
        Me.dtpUpdateOn.Size = New System.Drawing.Size(235, 20)
        Me.dtpUpdateOn.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Updated On"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Inv. Qty"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(744, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Purchase Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInvName
        '
        Me.txtInvName.Location = New System.Drawing.Point(292, 10)
        Me.txtInvName.Name = "txtInvName"
        Me.txtInvName.Size = New System.Drawing.Size(445, 20)
        Me.txtInvName.TabIndex = 1
        '
        'InvBindingNavigator
        '
        Me.InvBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InvBindingNavigator.BindingSource = Me.InvBindingSource
        Me.InvBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InvBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InvBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorFindItem, Me.ToolStripSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorEditItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem, Me.ToolStripSeparator2, Me.BindingNavigatorCloseItem})
        Me.InvBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InvBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InvBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InvBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InvBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InvBindingNavigator.Name = "InvBindingNavigator"
        Me.InvBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InvBindingNavigator.Size = New System.Drawing.Size(986, 25)
        Me.InvBindingNavigator.TabIndex = 7
        Me.InvBindingNavigator.Text = "BindingNavigator1"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inventory Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInvID
        '
        Me.txtInvID.Location = New System.Drawing.Point(114, 10)
        Me.txtInvID.Name = "txtInvID"
        Me.txtInvID.Size = New System.Drawing.Size(69, 20)
        Me.txtInvID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory Code"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtRPack)
        Me.Panel1.Controls.Add(Me.txtRPack2)
        Me.Panel1.Controls.Add(Me.txtRPack1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtPacking)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPerPack)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cmbType)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtRetail)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.txtR2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtR1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtQty)
        Me.Panel1.Controls.Add(Me.dtpUpdateOn)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtInvName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtInvID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 410)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 96)
        Me.Panel1.TabIndex = 8
        '
        'txtRPack
        '
        Me.txtRPack.Location = New System.Drawing.Point(435, 37)
        Me.txtRPack.Name = "txtRPack"
        Me.txtRPack.Size = New System.Drawing.Size(117, 20)
        Me.txtRPack.TabIndex = 34
        Me.txtRPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRPack2
        '
        Me.txtRPack2.Location = New System.Drawing.Point(505, 37)
        Me.txtRPack2.Mask = "###"
        Me.txtRPack2.Name = "txtRPack2"
        Me.txtRPack2.Size = New System.Drawing.Size(47, 20)
        Me.txtRPack2.TabIndex = 6
        Me.txtRPack2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRPack1
        '
        Me.txtRPack1.Location = New System.Drawing.Point(435, 37)
        Me.txtRPack1.Mask = "###"
        Me.txtRPack1.Name = "txtRPack1"
        Me.txtRPack1.Size = New System.Drawing.Size(47, 20)
        Me.txtRPack1.TabIndex = 5
        Me.txtRPack1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(486, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "X"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(373, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "R / Pack"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPacking
        '
        Me.txtPacking.Location = New System.Drawing.Point(849, 38)
        Me.txtPacking.Name = "txtPacking"
        Me.txtPacking.Size = New System.Drawing.Size(123, 20)
        Me.txtPacking.TabIndex = 9
        Me.txtPacking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(792, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Packing"
        '
        'txtPerPack
        '
        Me.txtPerPack.Location = New System.Drawing.Point(114, 37)
        Me.txtPerPack.Name = "txtPerPack"
        Me.txtPerPack.Size = New System.Drawing.Size(69, 20)
        Me.txtPerPack.TabIndex = 3
        Me.txtPerPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Per Pack"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"R - Double Vyle Base", "V - Single Vyle Base", "Q - Quantity Base"})
        Me.cmbType.Location = New System.Drawing.Point(849, 11)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(123, 21)
        Me.cmbType.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(754, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Inventory Type"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRetail
        '
        Me.txtRetail.Location = New System.Drawing.Point(625, 63)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(112, 20)
        Me.txtRetail.TabIndex = 11
        Me.txtRetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(549, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Retail Price"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(849, 64)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(123, 20)
        Me.txtPrice.TabIndex = 12
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtR2
        '
        Me.txtR2.Location = New System.Drawing.Point(690, 37)
        Me.txtR2.MaxLength = 2
        Me.txtR2.Name = "txtR2"
        Me.txtR2.Size = New System.Drawing.Size(47, 20)
        Me.txtR2.TabIndex = 8
        Me.txtR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(666, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "R2"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtR1
        '
        Me.txtR1.Location = New System.Drawing.Point(616, 37)
        Me.txtR1.MaxLength = 2
        Me.txtR1.Name = "txtR1"
        Me.txtR1.Size = New System.Drawing.Size(47, 20)
        Me.txtR1.TabIndex = 7
        Me.txtR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(564, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Inv. R1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(292, 37)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(57, 20)
        Me.txtQty.TabIndex = 4
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'col_inv_code
        '
        Me.col_inv_code.DataPropertyName = "inv_code"
        Me.col_inv_code.HeaderText = "Product Code"
        Me.col_inv_code.Name = "col_inv_code"
        Me.col_inv_code.ReadOnly = True
        Me.col_inv_code.Width = 75
        '
        'col_inv_desc
        '
        Me.col_inv_desc.DataPropertyName = "inv_description"
        Me.col_inv_desc.HeaderText = "Description"
        Me.col_inv_desc.Name = "col_inv_desc"
        Me.col_inv_desc.ReadOnly = True
        Me.col_inv_desc.Width = 230
        '
        'col_inv_type
        '
        Me.col_inv_type.DataPropertyName = "INV_QTY_TYPE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_inv_type.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_inv_type.HeaderText = "Type"
        Me.col_inv_type.Name = "col_inv_type"
        Me.col_inv_type.ReadOnly = True
        Me.col_inv_type.Width = 50
        '
        'inv_per_pck
        '
        Me.inv_per_pck.DataPropertyName = "inv_per_pack"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.inv_per_pck.DefaultCellStyle = DataGridViewCellStyle3
        Me.inv_per_pck.HeaderText = "Per Pack"
        Me.inv_per_pck.Name = "inv_per_pck"
        Me.inv_per_pck.ReadOnly = True
        Me.inv_per_pck.Width = 60
        '
        'col_inv_qty
        '
        Me.col_inv_qty.DataPropertyName = "inv_hand_Q1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_inv_qty.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_inv_qty.HeaderText = "Qty"
        Me.col_inv_qty.Name = "col_inv_qty"
        Me.col_inv_qty.ReadOnly = True
        Me.col_inv_qty.Width = 70
        '
        'INV_PPACK_R
        '
        Me.INV_PPACK_R.DataPropertyName = "INV_PPACK_R"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.INV_PPACK_R.DefaultCellStyle = DataGridViewCellStyle5
        Me.INV_PPACK_R.HeaderText = "Reagent / Pack"
        Me.INV_PPACK_R.Name = "INV_PPACK_R"
        Me.INV_PPACK_R.ReadOnly = True
        '
        'col_inv_qty_r1
        '
        Me.col_inv_qty_r1.DataPropertyName = "inv_hand_r1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_inv_qty_r1.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_inv_qty_r1.HeaderText = "R1"
        Me.col_inv_qty_r1.Name = "col_inv_qty_r1"
        Me.col_inv_qty_r1.ReadOnly = True
        Me.col_inv_qty_r1.Width = 60
        '
        'col_inv_qty_r2
        '
        Me.col_inv_qty_r2.DataPropertyName = "inv_hand_r2"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_inv_qty_r2.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_inv_qty_r2.HeaderText = "R2"
        Me.col_inv_qty_r2.Name = "col_inv_qty_r2"
        Me.col_inv_qty_r2.ReadOnly = True
        Me.col_inv_qty_r2.Width = 60
        '
        'col_inv_pck
        '
        Me.col_inv_pck.DataPropertyName = "inv_pack"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_inv_pck.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_inv_pck.HeaderText = "Packing"
        Me.col_inv_pck.Name = "col_inv_pck"
        Me.col_inv_pck.ReadOnly = True
        '
        'col_inv_pck_price
        '
        Me.col_inv_pck_price.DataPropertyName = "inv_pck_price"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0.00"
        Me.col_inv_pck_price.DefaultCellStyle = DataGridViewCellStyle9
        Me.col_inv_pck_price.HeaderText = "Retail Price"
        Me.col_inv_pck_price.Name = "col_inv_pck_price"
        Me.col_inv_pck_price.ReadOnly = True
        Me.col_inv_pck_price.Width = 80
        '
        'col_inv_pch_price
        '
        Me.col_inv_pch_price.DataPropertyName = "inv_pch_price"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0.00"
        Me.col_inv_pch_price.DefaultCellStyle = DataGridViewCellStyle10
        Me.col_inv_pch_price.HeaderText = "Purchase Price"
        Me.col_inv_pch_price.Name = "col_inv_pch_price"
        Me.col_inv_pch_price.ReadOnly = True
        '
        'col_inv_upd_dt
        '
        Me.col_inv_upd_dt.DataPropertyName = "inv_upd_dt"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_inv_upd_dt.DefaultCellStyle = DataGridViewCellStyle11
        Me.col_inv_upd_dt.HeaderText = "Updated On"
        Me.col_inv_upd_dt.Name = "col_inv_upd_dt"
        Me.col_inv_upd_dt.ReadOnly = True
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 506)
        Me.Controls.Add(Me.InvDataGrid)
        Me.Controls.Add(Me.InvBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Register"
        CType(Me.InvDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvBindingNavigator.ResumeLayout(False)
        Me.InvBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InvDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents InvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents dtpUpdateOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInvName As System.Windows.Forms.TextBox
    Friend WithEvents InvBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BindingNavigatorFindItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorCloseItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInvID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtR1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtR2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtRetail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPerPack As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPacking As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRPack1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRPack2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRPack As System.Windows.Forms.TextBox
    Friend WithEvents col_inv_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_per_pck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INV_PPACK_R As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_qty_r1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_qty_r2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_pck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_pck_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_pch_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_inv_upd_dt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
