<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchases))
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.PurchaseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseDataSet = New System.Data.DataSet
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonDelete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorRefreshItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSave = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorFinalize = New System.Windows.Forms.ToolStripButton
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtOldPrice = New System.Windows.Forms.TextBox
        Me.txtPacking = New System.Windows.Forms.TextBox
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTranID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtInvoice = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.PurchaseDataGridView = New System.Windows.Forms.DataGridView
        Me.colTranID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colInvoice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colProdID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHead = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCatg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colScatg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPerUnitQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrvStock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOldPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRmks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.coldept = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colscatgs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWSale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdMin = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PurchaseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PurchaseBindingNavigator.SuspendLayout()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PurchaseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchases"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(992, 631)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Black
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 10
        Me.LineShape2.X2 = 982
        Me.LineShape2.Y1 = 43
        Me.LineShape2.Y2 = 43
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 982
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'PurchaseBindingNavigator
        '
        Me.PurchaseBindingNavigator.AddNewItem = Nothing
        Me.PurchaseBindingNavigator.BindingSource = Me.PurchaseBindingSource
        Me.PurchaseBindingNavigator.CountItem = Nothing
        Me.PurchaseBindingNavigator.DeleteItem = Nothing
        Me.PurchaseBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PurchaseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.ToolStripButtonEdit, Me.ToolStripSeparator1, Me.ToolStripButtonDelete, Me.ToolStripSeparator2, Me.BindingNavigatorRefreshItem, Me.BindingNavigatorSeparator4, Me.BindingNavigatorSave, Me.BindingNavigatorSeparator6, Me.BindingNavigatorFinalize})
        Me.PurchaseBindingNavigator.Location = New System.Drawing.Point(229, 10)
        Me.PurchaseBindingNavigator.MoveFirstItem = Nothing
        Me.PurchaseBindingNavigator.MoveLastItem = Nothing
        Me.PurchaseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PurchaseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PurchaseBindingNavigator.Name = "PurchaseBindingNavigator"
        Me.PurchaseBindingNavigator.PositionItem = Nothing
        Me.PurchaseBindingNavigator.Size = New System.Drawing.Size(628, 25)
        Me.PurchaseBindingNavigator.TabIndex = 12
        Me.PurchaseBindingNavigator.Text = "BindingNavigator"
        Me.PurchaseBindingNavigator.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'PurchaseBindingSource
        '
        Me.PurchaseBindingSource.DataSource = Me.PurchaseDataSet
        Me.PurchaseBindingSource.Position = 0
        '
        'PurchaseDataSet
        '
        Me.PurchaseDataSet.DataSetName = "PurchaseDataSet"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(53, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "&Prev"
        Me.BindingNavigatorMovePreviousItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "Move Previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(55, 22)
        Me.BindingNavigatorMoveNextItem.Text = "&Next"
        Me.BindingNavigatorMoveNextItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripButtonEdit
        '
        Me.ToolStripButtonEdit.Image = Global.POS_Professional.My.Resources.Resources.data_edit
        Me.ToolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEdit.Name = "ToolStripButtonEdit"
        Me.ToolStripButtonEdit.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButtonEdit.Text = "&Edit (F3)"
        Me.ToolStripButtonEdit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.ToolStripButtonEdit.ToolTipText = "Edit Purchase Transaction"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripButtonDelete
        '
        Me.ToolStripButtonDelete.Image = Global.POS_Professional.My.Resources.Resources.database_remove
        Me.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDelete.Name = "ToolStripButtonDelete"
        Me.ToolStripButtonDelete.Size = New System.Drawing.Size(90, 22)
        Me.ToolStripButtonDelete.Text = "Delete (F8)"
        Me.ToolStripButtonDelete.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorRefreshItem
        '
        Me.BindingNavigatorRefreshItem.Enabled = False
        Me.BindingNavigatorRefreshItem.Image = CType(resources.GetObject("BindingNavigatorRefreshItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorRefreshItem.Name = "BindingNavigatorRefreshItem"
        Me.BindingNavigatorRefreshItem.Size = New System.Drawing.Size(72, 22)
        Me.BindingNavigatorRefreshItem.Text = "&Refresh"
        Me.BindingNavigatorRefreshItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorRefreshItem.ToolTipText = "Refresh Data"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorSave
        '
        Me.BindingNavigatorSave.Enabled = False
        Me.BindingNavigatorSave.Image = CType(resources.GetObject("BindingNavigatorSave.Image"), System.Drawing.Image)
        Me.BindingNavigatorSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSave.Name = "BindingNavigatorSave"
        Me.BindingNavigatorSave.Size = New System.Drawing.Size(103, 22)
        Me.BindingNavigatorSave.Text = "&Save (Ctrl+S)"
        Me.BindingNavigatorSave.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorSave.ToolTipText = "Save Current Changes"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator6.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorFinalize
        '
        Me.BindingNavigatorFinalize.Enabled = False
        Me.BindingNavigatorFinalize.Image = CType(resources.GetObject("BindingNavigatorFinalize.Image"), System.Drawing.Image)
        Me.BindingNavigatorFinalize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorFinalize.Name = "BindingNavigatorFinalize"
        Me.BindingNavigatorFinalize.Size = New System.Drawing.Size(132, 22)
        Me.BindingNavigatorFinalize.Text = "&Finalize Purchases"
        Me.BindingNavigatorFinalize.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorFinalize.ToolTipText = "Finalize Products Changes"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = Me.ProductDataSet
        Me.ProductBindingSource.Position = 0
        '
        'ProductDataSet
        '
        Me.ProductDataSet.DataSetName = "ProductDataSet"
        Me.ProductDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.TableName = "PRODUCTS"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 54)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCategory)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtOldPrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPacking)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDepartment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTranID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtInvoice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtQty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPPrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDesc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDate)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(968, 562)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 13
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.SteelBlue
        Me.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.ForeColor = System.Drawing.Color.White
        Me.txtCategory.Location = New System.Drawing.Point(119, 88)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(187, 20)
        Me.txtCategory.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(53, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Category"
        '
        'txtOldPrice
        '
        Me.txtOldPrice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtOldPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPrice.ForeColor = System.Drawing.Color.White
        Me.txtOldPrice.Location = New System.Drawing.Point(855, 88)
        Me.txtOldPrice.Name = "txtOldPrice"
        Me.txtOldPrice.ReadOnly = True
        Me.txtOldPrice.Size = New System.Drawing.Size(94, 20)
        Me.txtOldPrice.TabIndex = 11
        Me.txtOldPrice.TabStop = False
        Me.txtOldPrice.Text = "0"
        Me.txtOldPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPacking
        '
        Me.txtPacking.BackColor = System.Drawing.Color.SteelBlue
        Me.txtPacking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPacking.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPacking.ForeColor = System.Drawing.Color.White
        Me.txtPacking.Location = New System.Drawing.Point(398, 88)
        Me.txtPacking.Name = "txtPacking"
        Me.txtPacking.ReadOnly = True
        Me.txtPacking.Size = New System.Drawing.Size(109, 20)
        Me.txtPacking.TabIndex = 8
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.ForeColor = System.Drawing.Color.White
        Me.txtDepartment.Location = New System.Drawing.Point(737, 52)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(212, 20)
        Me.txtDepartment.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(255, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 16)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "F2 ?"
        '
        'txtTranID
        '
        Me.txtTranID.BackColor = System.Drawing.Color.SteelBlue
        Me.txtTranID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTranID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranID.ForeColor = System.Drawing.Color.White
        Me.txtTranID.Location = New System.Drawing.Point(567, 17)
        Me.txtTranID.Name = "txtTranID"
        Me.txtTranID.ReadOnly = True
        Me.txtTranID.Size = New System.Drawing.Size(75, 20)
        Me.txtTranID.TabIndex = 3
        Me.txtTranID.TabStop = False
        Me.txtTranID.Text = "0"
        Me.txtTranID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(515, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Trans #"
        '
        'txtInvoice
        '
        Me.txtInvoice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoice.ForeColor = System.Drawing.Color.White
        Me.txtInvoice.Location = New System.Drawing.Point(398, 17)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(79, 20)
        Me.txtInvoice.TabIndex = 2
        Me.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Yellow
        Me.Label23.Location = New System.Drawing.Point(334, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 16)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Invoice #"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(17, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 16)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Perchase Date"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.SteelBlue
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.White
        Me.txtQty.Location = New System.Drawing.Point(548, 88)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(94, 20)
        Me.txtQty.TabIndex = 9
        Me.txtQty.Text = "0"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(513, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Qty."
        '
        'txtPPrice
        '
        Me.txtPPrice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtPPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPrice.ForeColor = System.Drawing.Color.White
        Me.txtPPrice.Location = New System.Drawing.Point(737, 88)
        Me.txtPPrice.Name = "txtPPrice"
        Me.txtPPrice.Size = New System.Drawing.Size(94, 20)
        Me.txtPPrice.TabIndex = 10
        Me.txtPPrice.Text = "0"
        Me.txtPPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(680, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "P. Price"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(337, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Packing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(682, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Depart."
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.White
        Me.txtDesc.Location = New System.Drawing.Point(398, 52)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(244, 20)
        Me.txtDesc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(319, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Description"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.SteelBlue
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.White
        Me.txtCode.Location = New System.Drawing.Point(119, 52)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(133, 20)
        Me.txtCode.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(25, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Product Code"
        '
        'txtDate
        '
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDate.CustomFormat = ""
        Me.txtDate.Location = New System.Drawing.Point(119, 16)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(187, 20)
        Me.txtDate.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PurchaseDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ProductDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(968, 429)
        Me.SplitContainer2.SplitterDistance = 240
        Me.SplitContainer2.TabIndex = 0
        '
        'PurchaseDataGridView
        '
        Me.PurchaseDataGridView.AllowUserToAddRows = False
        Me.PurchaseDataGridView.AllowUserToDeleteRows = False
        Me.PurchaseDataGridView.AllowUserToOrderColumns = True
        Me.PurchaseDataGridView.AllowUserToResizeColumns = False
        Me.PurchaseDataGridView.AllowUserToResizeRows = False
        Me.PurchaseDataGridView.AutoGenerateColumns = False
        Me.PurchaseDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PurchaseDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTranID, Me.colInvoice, Me.colDate, Me.colProdID, Me.colDesc, Me.colSupplier, Me.colHead, Me.colCatg, Me.colScatg, Me.colPck, Me.colPerUnitQty, Me.colPrvStock, Me.colQty, Me.colOldPrice, Me.colPPrice, Me.colRmks})
        Me.PurchaseDataGridView.DataSource = Me.PurchaseBindingSource
        Me.PurchaseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PurchaseDataGridView.GridColor = System.Drawing.Color.Gray
        Me.PurchaseDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PurchaseDataGridView.MultiSelect = False
        Me.PurchaseDataGridView.Name = "PurchaseDataGridView"
        Me.PurchaseDataGridView.ReadOnly = True
        Me.PurchaseDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PurchaseDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.PurchaseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PurchaseDataGridView.Size = New System.Drawing.Size(968, 240)
        Me.PurchaseDataGridView.TabIndex = 19
        '
        'colTranID
        '
        Me.colTranID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colTranID.DataPropertyName = "PRCH_TR_ID"
        Me.colTranID.HeaderText = "Tran #"
        Me.colTranID.Name = "colTranID"
        Me.colTranID.ReadOnly = True
        Me.colTranID.Width = 64
        '
        'colInvoice
        '
        Me.colInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colInvoice.DataPropertyName = "PRCH_INVOICE"
        Me.colInvoice.HeaderText = "Invoice #"
        Me.colInvoice.Name = "colInvoice"
        Me.colInvoice.ReadOnly = True
        Me.colInvoice.Width = 77
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "PRCH_DATE"
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colProdID
        '
        Me.colProdID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colProdID.DataPropertyName = "PRCH_PROD_CD"
        Me.colProdID.HeaderText = "Product Code"
        Me.colProdID.Name = "colProdID"
        Me.colProdID.ReadOnly = True
        Me.colProdID.Width = 97
        '
        'colDesc
        '
        Me.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colDesc.DataPropertyName = "PRCH_DESC"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 85
        '
        'colSupplier
        '
        Me.colSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colSupplier.DataPropertyName = "PRCH_SUPPLIER"
        Me.colSupplier.HeaderText = "Supplier"
        Me.colSupplier.Name = "colSupplier"
        Me.colSupplier.ReadOnly = True
        Me.colSupplier.Width = 70
        '
        'colHead
        '
        Me.colHead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colHead.DataPropertyName = "prch_head"
        Me.colHead.HeaderText = "Department"
        Me.colHead.Name = "colHead"
        Me.colHead.ReadOnly = True
        Me.colHead.Width = 87
        '
        'colCatg
        '
        Me.colCatg.DataPropertyName = "PRCH_CATG"
        Me.colCatg.HeaderText = "Category"
        Me.colCatg.Name = "colCatg"
        Me.colCatg.ReadOnly = True
        '
        'colScatg
        '
        Me.colScatg.DataPropertyName = "prch_sub_catg"
        Me.colScatg.HeaderText = "Sub Category"
        Me.colScatg.Name = "colScatg"
        Me.colScatg.ReadOnly = True
        '
        'colPck
        '
        Me.colPck.DataPropertyName = "PRCH_PACK"
        Me.colPck.HeaderText = "Packing"
        Me.colPck.Name = "colPck"
        Me.colPck.ReadOnly = True
        '
        'colPerUnitQty
        '
        Me.colPerUnitQty.DataPropertyName = "PRCH_QTY_PER_UNIT"
        Me.colPerUnitQty.HeaderText = "Qty / Unit"
        Me.colPerUnitQty.Name = "colPerUnitQty"
        Me.colPerUnitQty.ReadOnly = True
        '
        'colPrvStock
        '
        Me.colPrvStock.DataPropertyName = "PRCH_OLD_QTY"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrvStock.DefaultCellStyle = DataGridViewCellStyle26
        Me.colPrvStock.HeaderText = "Prev. Stock"
        Me.colPrvStock.Name = "colPrvStock"
        Me.colPrvStock.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.DataPropertyName = "PRCH_QTY"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colQty.DefaultCellStyle = DataGridViewCellStyle27
        Me.colQty.HeaderText = "Purch. Stock"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colOldPrice
        '
        Me.colOldPrice.DataPropertyName = "prch_old_price"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colOldPrice.DefaultCellStyle = DataGridViewCellStyle28
        Me.colOldPrice.HeaderText = "Old Price"
        Me.colOldPrice.Name = "colOldPrice"
        Me.colOldPrice.ReadOnly = True
        '
        'colPPrice
        '
        Me.colPPrice.DataPropertyName = "PRCH_PRICE"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPPrice.DefaultCellStyle = DataGridViewCellStyle29
        Me.colPPrice.HeaderText = "P. Price"
        Me.colPPrice.Name = "colPPrice"
        Me.colPPrice.ReadOnly = True
        '
        'colRmks
        '
        Me.colRmks.DataPropertyName = "PRCH_STATUS"
        Me.colRmks.HeaderText = "Remarks"
        Me.colRmks.Name = "colRmks"
        Me.colRmks.ReadOnly = True
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.AllowUserToOrderColumns = True
        Me.ProductDataGridView.AllowUserToResizeColumns = False
        Me.ProductDataGridView.AllowUserToResizeRows = False
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.coldept, Me.DataGridViewTextBoxColumn3, Me.colscatgs, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.colWSale, Me.DataGridViewTextBoxColumn22})
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGridView.GridColor = System.Drawing.Color.Gray
        Me.ProductDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProductDataGridView.MultiSelect = False
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle32
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(968, 185)
        Me.ProductDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_CODE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 97
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PROD_DESC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 85
        '
        'coldept
        '
        Me.coldept.DataPropertyName = "prod_head"
        Me.coldept.HeaderText = "Department"
        Me.coldept.Name = "coldept"
        Me.coldept.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PROD_CATG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'colscatgs
        '
        Me.colscatgs.DataPropertyName = "prod_sub_catg"
        Me.colscatgs.HeaderText = "Sub Category"
        Me.colscatgs.Name = "colscatgs"
        Me.colscatgs.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROD_UPD_ON"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Update On"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PROD_PACKING"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Packing"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PROD_STOCK"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PROD_PURCH_PRICE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "P. Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'colWSale
        '
        Me.colWSale.DataPropertyName = "PROD_WSALE_PRICE"
        Me.colWSale.HeaderText = "WholeSale"
        Me.colWSale.Name = "colWSale"
        Me.colWSale.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PROD_SALE_PRICE"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Sale Price"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdClose.Location = New System.Drawing.Point(955, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(31, 34)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdMin
        '
        Me.cmdMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMin.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdMin.Location = New System.Drawing.Point(924, 5)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(29, 34)
        Me.cmdMin.TabIndex = 0
        Me.cmdMin.TabStop = False
        Me.cmdMin.Text = "----"
        Me.cmdMin.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1000
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Tip"
        '
        'Purchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 631)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PurchaseBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Purchases"
        Me.Opacity = 0.8
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        CType(Me.PurchaseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PurchaseBindingNavigator.ResumeLayout(False)
        Me.PurchaseBindingNavigator.PerformLayout()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PurchaseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PurchaseBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtPPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorFinalize As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDataSet As System.Data.DataSet
    Friend WithEvents BindingNavigatorRefreshItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PurchaseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PurchaseDataSet As System.Data.DataSet
    Friend WithEvents PurchaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProductDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtTranID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents txtPacking As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButtonEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtOldPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents colTranID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProdID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHead As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colScatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPerUnitQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrvStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOldPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRmks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colscatgs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
