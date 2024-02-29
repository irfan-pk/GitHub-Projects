<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAcc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewAcc))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.AccBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.AccBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccDataSet = New System.Data.DataSet
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtpUpdOn = New System.Windows.Forms.DateTimePicker
        Me.dtpOpenOn = New System.Windows.Forms.DateTimePicker
        Me.txtDrCr = New System.Windows.Forms.TextBox
        Me.cmbDrCr = New System.Windows.Forms.ComboBox
        Me.txtLink = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtOpnBal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAccName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAccID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AccDataGrid = New System.Windows.Forms.DataGridView
        Me.colAccNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colACCNAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colACCTYPE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colACCBAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccUpdated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOpnOn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccLinkCd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccLink = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.AccBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccBindingNavigator.SuspendLayout()
        CType(Me.AccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.AccDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCategory
        '
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"ASSESTS", "EQUITY", "LIABILITY", "REVENUE", "EXPENSES"})
        Me.cmbCategory.Location = New System.Drawing.Point(656, 62)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(184, 21)
        Me.cmbCategory.TabIndex = 13
        '
        'AccBindingNavigator
        '
        Me.AccBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AccBindingNavigator.BindingSource = Me.AccBindingSource
        Me.AccBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AccBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AccBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorFindItem, Me.ToolStripSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorEditItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem, Me.ToolStripSeparator2, Me.BindingNavigatorCloseItem})
        Me.AccBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AccBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AccBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AccBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AccBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AccBindingNavigator.Name = "AccBindingNavigator"
        Me.AccBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AccBindingNavigator.Size = New System.Drawing.Size(868, 25)
        Me.AccBindingNavigator.TabIndex = 3
        Me.AccBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add new"
        '
        'AccBindingSource
        '
        Me.AccBindingSource.DataSource = Me.AccDataSet
        Me.AccBindingSource.Position = 0
        '
        'AccDataSet
        '
        Me.AccDataSet.DataSetName = "AccDataSet"
        Me.AccDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(558, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "A/C Category"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtpUpdOn)
        Me.Panel1.Controls.Add(Me.dtpOpenOn)
        Me.Panel1.Controls.Add(Me.txtDrCr)
        Me.Panel1.Controls.Add(Me.cmbDrCr)
        Me.Panel1.Controls.Add(Me.cmbCategory)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtLink)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtOpnBal)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAccName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAccID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 96)
        Me.Panel1.TabIndex = 5
        '
        'dtpUpdOn
        '
        Me.dtpUpdOn.Location = New System.Drawing.Point(625, 36)
        Me.dtpUpdOn.Name = "dtpUpdOn"
        Me.dtpUpdOn.Size = New System.Drawing.Size(215, 20)
        Me.dtpUpdOn.TabIndex = 17
        '
        'dtpOpenOn
        '
        Me.dtpOpenOn.Location = New System.Drawing.Point(83, 63)
        Me.dtpOpenOn.Name = "dtpOpenOn"
        Me.dtpOpenOn.Size = New System.Drawing.Size(215, 20)
        Me.dtpOpenOn.TabIndex = 16
        '
        'txtDrCr
        '
        Me.txtDrCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrCr.Location = New System.Drawing.Point(186, 36)
        Me.txtDrCr.Name = "txtDrCr"
        Me.txtDrCr.Size = New System.Drawing.Size(112, 20)
        Me.txtDrCr.TabIndex = 15
        '
        'cmbDrCr
        '
        Me.cmbDrCr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDrCr.FormattingEnabled = True
        Me.cmbDrCr.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.cmbDrCr.Location = New System.Drawing.Point(83, 35)
        Me.cmbDrCr.Name = "cmbDrCr"
        Me.cmbDrCr.Size = New System.Drawing.Size(97, 21)
        Me.cmbDrCr.TabIndex = 14
        '
        'txtLink
        '
        Me.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLink.Enabled = False
        Me.txtLink.Location = New System.Drawing.Point(404, 63)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.ReadOnly = True
        Me.txtLink.Size = New System.Drawing.Size(97, 20)
        Me.txtLink.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(334, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Link Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Open On"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(544, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Updated On"
        '
        'txtOpnBal
        '
        Me.txtOpnBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpnBal.Location = New System.Drawing.Point(404, 36)
        Me.txtOpnBal.Name = "txtOpnBal"
        Me.txtOpnBal.Size = New System.Drawing.Size(132, 20)
        Me.txtOpnBal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(319, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Opening B/L"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Acc Type"
        '
        'txtAccName
        '
        Me.txtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccName.Location = New System.Drawing.Point(404, 10)
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.Size = New System.Drawing.Size(436, 20)
        Me.txtAccName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAccID
        '
        Me.txtAccID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccID.Location = New System.Drawing.Point(83, 10)
        Me.txtAccID.Name = "txtAccID"
        Me.txtAccID.Size = New System.Drawing.Size(97, 20)
        Me.txtAccID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Acc Code"
        '
        'AccDataGrid
        '
        Me.AccDataGrid.AllowUserToAddRows = False
        Me.AccDataGrid.AllowUserToDeleteRows = False
        Me.AccDataGrid.AllowUserToResizeRows = False
        Me.AccDataGrid.AutoGenerateColumns = False
        Me.AccDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AccDataGrid.ColumnHeadersHeight = 35
        Me.AccDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AccDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAccNo, Me.colACCNAME, Me.colACCTYPE, Me.colACCBAL, Me.colAccUpdated, Me.colOpnOn, Me.colAccLinkCd, Me.colAccLink})
        Me.AccDataGrid.DataSource = Me.AccBindingSource
        Me.AccDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.AccDataGrid.Location = New System.Drawing.Point(3, 33)
        Me.AccDataGrid.MultiSelect = False
        Me.AccDataGrid.Name = "AccDataGrid"
        Me.AccDataGrid.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.AccDataGrid.RowHeadersVisible = False
        Me.AccDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AccDataGrid.Size = New System.Drawing.Size(860, 376)
        Me.AccDataGrid.TabIndex = 6
        Me.AccDataGrid.TabStop = False
        '
        'colAccNo
        '
        Me.colAccNo.DataPropertyName = "acc_no"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "000"
        Me.colAccNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.colAccNo.HeaderText = "Acc ID"
        Me.colAccNo.Name = "colAccNo"
        Me.colAccNo.ReadOnly = True
        Me.colAccNo.Width = 80
        '
        'colACCNAME
        '
        Me.colACCNAME.DataPropertyName = "acc_name"
        Me.colACCNAME.HeaderText = "Account Name"
        Me.colACCNAME.Name = "colACCNAME"
        Me.colACCNAME.ReadOnly = True
        Me.colACCNAME.Width = 260
        '
        'colACCTYPE
        '
        Me.colACCTYPE.DataPropertyName = "acc_type"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colACCTYPE.DefaultCellStyle = DataGridViewCellStyle3
        Me.colACCTYPE.HeaderText = "Acc Type"
        Me.colACCTYPE.Name = "colACCTYPE"
        Me.colACCTYPE.ReadOnly = True
        Me.colACCTYPE.Width = 50
        '
        'colACCBAL
        '
        Me.colACCBAL.DataPropertyName = "acc_balance"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colACCBAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.colACCBAL.HeaderText = "Acc Balance"
        Me.colACCBAL.Name = "colACCBAL"
        Me.colACCBAL.ReadOnly = True
        '
        'colAccUpdated
        '
        Me.colAccUpdated.DataPropertyName = "acc_update"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colAccUpdated.DefaultCellStyle = DataGridViewCellStyle5
        Me.colAccUpdated.HeaderText = "Acc Updated"
        Me.colAccUpdated.Name = "colAccUpdated"
        Me.colAccUpdated.ReadOnly = True
        '
        'colOpnOn
        '
        Me.colOpnOn.DataPropertyName = "acc_opn_date"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colOpnOn.DefaultCellStyle = DataGridViewCellStyle6
        Me.colOpnOn.HeaderText = "Acc Open On"
        Me.colOpnOn.Name = "colOpnOn"
        Me.colOpnOn.ReadOnly = True
        '
        'colAccLinkCd
        '
        Me.colAccLinkCd.DataPropertyName = "acc_link_code"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colAccLinkCd.DefaultCellStyle = DataGridViewCellStyle7
        Me.colAccLinkCd.HeaderText = "Acc Link"
        Me.colAccLinkCd.Name = "colAccLinkCd"
        Me.colAccLinkCd.ReadOnly = True
        Me.colAccLinkCd.Width = 50
        '
        'colAccLink
        '
        Me.colAccLink.DataPropertyName = "acc_link"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colAccLink.DefaultCellStyle = DataGridViewCellStyle8
        Me.colAccLink.HeaderText = "Acc Category"
        Me.colAccLink.Name = "colAccLink"
        Me.colAccLink.ReadOnly = True
        '
        'frmNewAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(868, 516)
        Me.Controls.Add(Me.AccDataGrid)
        Me.Controls.Add(Me.AccBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNewAcc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Account"
        CType(Me.AccBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccBindingNavigator.ResumeLayout(False)
        Me.AccBindingNavigator.PerformLayout()
        CType(Me.AccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AccDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents AccBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpOpenOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDrCr As System.Windows.Forms.TextBox
    Friend WithEvents cmbDrCr As System.Windows.Forms.ComboBox
    Friend WithEvents txtLink As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOpnBal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAccID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpUpdOn As System.Windows.Forms.DateTimePicker
    Friend WithEvents AccDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents colAccNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACCNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACCTYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colACCBAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccUpdated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOpnOn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccLinkCd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccLink As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
