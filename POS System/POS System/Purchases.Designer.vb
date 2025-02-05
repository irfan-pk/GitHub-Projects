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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.PurchaseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabelEdit = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabelDelete = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorRefreshItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSave = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtInvoice = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtSalePrice = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtMargin = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtEDuty = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtITax = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtVAT = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPck = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCatg = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.PurchaseDataGridView = New System.Windows.Forms.DataGridView
        Me.colTranID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colProdID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCatg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colInvoice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPck = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrvStock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSch1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPSch1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSch2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPSch2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSch3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPSch3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colITax = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colExcise = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMargn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colProfit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRmks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdMin = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrchDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PurchaseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PurchaseBindingNavigator.SuspendLayout()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LineShape2.X1 = 5
        Me.LineShape2.X2 = 977
        Me.LineShape2.Y1 = 43
        Me.LineShape2.Y2 = 43
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 5
        Me.LineShape1.X2 = 977
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
        Me.PurchaseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabelEdit, Me.ToolStripSeparator1, Me.ToolStripLabelDelete, Me.ToolStripSeparator2, Me.BindingNavigatorRefreshItem, Me.BindingNavigatorSeparator4, Me.BindingNavigatorSave, Me.BindingNavigatorSeparator6, Me.BindingNavigatorSaveItem})
        Me.PurchaseBindingNavigator.Location = New System.Drawing.Point(300, 10)
        Me.PurchaseBindingNavigator.MoveFirstItem = Nothing
        Me.PurchaseBindingNavigator.MoveLastItem = Nothing
        Me.PurchaseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PurchaseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PurchaseBindingNavigator.Name = "PurchaseBindingNavigator"
        Me.PurchaseBindingNavigator.PositionItem = Nothing
        Me.PurchaseBindingNavigator.Size = New System.Drawing.Size(571, 25)
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
        Me.PurchaseDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "PURCHASE"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(50, 22)
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(52, 22)
        Me.BindingNavigatorMoveNextItem.Text = "&Next"
        Me.BindingNavigatorMoveNextItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripLabelEdit
        '
        Me.ToolStripLabelEdit.Image = Global.POS_System.My.Resources.Resources.data_edit
        Me.ToolStripLabelEdit.Name = "ToolStripLabelEdit"
        Me.ToolStripLabelEdit.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabelEdit.Text = "Edit (F3)"
        Me.ToolStripLabelEdit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripLabelDelete
        '
        Me.ToolStripLabelDelete.Image = Global.POS_System.My.Resources.Resources.database_remove
        Me.ToolStripLabelDelete.Name = "ToolStripLabelDelete"
        Me.ToolStripLabelDelete.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripLabelDelete.Text = "Delete (F8)"
        Me.ToolStripLabelDelete.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
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
        Me.BindingNavigatorRefreshItem.Size = New System.Drawing.Size(66, 22)
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
        Me.BindingNavigatorSave.Size = New System.Drawing.Size(95, 22)
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
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Enabled = False
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(115, 22)
        Me.BindingNavigatorSaveItem.Text = "&Update Products"
        Me.BindingNavigatorSaveItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorSaveItem.ToolTipText = "Update Products Changes"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtInvoice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDiscount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label21)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSalePrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMargin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEDuty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtITax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVAT)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtQty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPPrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPck)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCatg)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(966, 562)
        Me.SplitContainer1.SplitterDistance = 161
        Me.SplitContainer1.TabIndex = 13
        '
        'txtInvoice
        '
        Me.txtInvoice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoice.ForeColor = System.Drawing.Color.White
        Me.txtInvoice.Location = New System.Drawing.Point(776, 16)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(162, 20)
        Me.txtInvoice.TabIndex = 2
        Me.txtInvoice.Text = "0"
        Me.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Yellow
        Me.Label23.Location = New System.Drawing.Point(709, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 16)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Invoice #"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.White
        Me.txtDiscount.Location = New System.Drawing.Point(883, 125)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(55, 20)
        Me.txtDiscount.TabIndex = 21
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Yellow
        Me.Label22.Location = New System.Drawing.Point(821, 127)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 16)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Discount"
        '
        'cmbCompany
        '
        Me.cmbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.cmbCompany.BackColor = System.Drawing.Color.SteelBlue
        Me.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCompany.ForeColor = System.Drawing.Color.White
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Items.AddRange(New Object() {"Opening Stock"})
        Me.cmbCompany.Location = New System.Drawing.Point(411, 15)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(292, 21)
        Me.cmbCompany.Sorted = True
        Me.cmbCompany.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbCompany, "Select wholesaler name")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(339, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 16)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Company"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(4, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 16)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Perchase Date"
        '
        'txtSalePrice
        '
        Me.txtSalePrice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalePrice.ForeColor = System.Drawing.Color.White
        Me.txtSalePrice.Location = New System.Drawing.Point(739, 125)
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Size = New System.Drawing.Size(63, 20)
        Me.txtSalePrice.TabIndex = 20
        Me.txtSalePrice.Text = "0"
        Me.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(663, 127)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 16)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Sale Price"
        '
        'txtMargin
        '
        Me.txtMargin.BackColor = System.Drawing.Color.SteelBlue
        Me.txtMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMargin.ForeColor = System.Drawing.Color.White
        Me.txtMargin.Location = New System.Drawing.Point(594, 125)
        Me.txtMargin.Name = "txtMargin"
        Me.txtMargin.Size = New System.Drawing.Size(55, 20)
        Me.txtMargin.TabIndex = 19
        Me.txtMargin.Text = "0"
        Me.txtMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(537, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 16)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Margin"
        '
        'txtEDuty
        '
        Me.txtEDuty.BackColor = System.Drawing.Color.SteelBlue
        Me.txtEDuty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEDuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEDuty.ForeColor = System.Drawing.Color.White
        Me.txtEDuty.Location = New System.Drawing.Point(883, 89)
        Me.txtEDuty.Name = "txtEDuty"
        Me.txtEDuty.Size = New System.Drawing.Size(55, 20)
        Me.txtEDuty.TabIndex = 9
        Me.txtEDuty.Text = "0"
        Me.txtEDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(803, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 16)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Excise Duty"
        '
        'txtITax
        '
        Me.txtITax.BackColor = System.Drawing.Color.SteelBlue
        Me.txtITax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtITax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtITax.ForeColor = System.Drawing.Color.White
        Me.txtITax.Location = New System.Drawing.Point(739, 89)
        Me.txtITax.Name = "txtITax"
        Me.txtITax.Size = New System.Drawing.Size(63, 20)
        Me.txtITax.TabIndex = 8
        Me.txtITax.Text = "0"
        Me.txtITax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(693, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "I.Tax."
        '
        'txtVAT
        '
        Me.txtVAT.BackColor = System.Drawing.Color.SteelBlue
        Me.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.ForeColor = System.Drawing.Color.White
        Me.txtVAT.Location = New System.Drawing.Point(594, 87)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(55, 20)
        Me.txtVAT.TabIndex = 7
        Me.txtVAT.Text = "0"
        Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(545, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 16)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "V.A.T"
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.SteelBlue
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.ForeColor = System.Drawing.Color.White
        Me.txtMin.Location = New System.Drawing.Point(411, 125)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(72, 20)
        Me.txtMin.TabIndex = 18
        Me.txtMin.Text = "1"
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(347, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Min. Bal."
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.SteelBlue
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.White
        Me.txtQty.Location = New System.Drawing.Point(246, 125)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(53, 20)
        Me.txtQty.TabIndex = 17
        Me.txtQty.Text = "0"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(193, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Quantity"
        '
        'txtPPrice
        '
        Me.txtPPrice.BackColor = System.Drawing.Color.SteelBlue
        Me.txtPPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPrice.ForeColor = System.Drawing.Color.White
        Me.txtPPrice.Location = New System.Drawing.Point(108, 125)
        Me.txtPPrice.Name = "txtPPrice"
        Me.txtPPrice.Size = New System.Drawing.Size(72, 20)
        Me.txtPPrice.TabIndex = 16
        Me.txtPPrice.Text = "0"
        Me.txtPPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(48, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "P. Price"
        '
        'txtPck
        '
        Me.txtPck.BackColor = System.Drawing.Color.SteelBlue
        Me.txtPck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPck.ForeColor = System.Drawing.Color.White
        Me.txtPck.Location = New System.Drawing.Point(411, 87)
        Me.txtPck.Name = "txtPck"
        Me.txtPck.Size = New System.Drawing.Size(72, 20)
        Me.txtPck.TabIndex = 6
        Me.txtPck.Text = "PCS"
        Me.txtPck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(348, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Packing"
        '
        'cmbCatg
        '
        Me.cmbCatg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.cmbCatg.BackColor = System.Drawing.Color.SteelBlue
        Me.cmbCatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCatg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCatg.ForeColor = System.Drawing.Color.White
        Me.cmbCatg.FormattingEnabled = True
        Me.cmbCatg.Items.AddRange(New Object() {"Desktop Casing", "DVD Rom", "Hard Disk", "Mother Board", "Network Cable", "Personal Computer", "Power Cables", "Processor", "RAM", "Tower Casing", "USB"})
        Me.cmbCatg.Location = New System.Drawing.Point(108, 87)
        Me.cmbCatg.Name = "cmbCatg"
        Me.cmbCatg.Size = New System.Drawing.Size(192, 21)
        Me.cmbCatg.Sorted = True
        Me.cmbCatg.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(39, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Category"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.SteelBlue
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.White
        Me.txtDesc.Location = New System.Drawing.Point(411, 52)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(527, 20)
        Me.txtDesc.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(329, 54)
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
        Me.txtCode.Location = New System.Drawing.Point(108, 52)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(192, 20)
        Me.txtCode.TabIndex = 3
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Product Code"
        '
        'txtDate
        '
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDate.Location = New System.Drawing.Point(108, 15)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(191, 20)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(966, 397)
        Me.SplitContainer2.SplitterDistance = 196
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
        Me.PurchaseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PurchaseDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTranID, Me.colProdID, Me.colDesc, Me.colCatg, Me.colInvoice, Me.colSupplier, Me.colDate, Me.colPck, Me.colPPrice, Me.colQty, Me.colPrvStock, Me.colMin, Me.colSch1, Me.colPSch1, Me.colSch2, Me.colPSch2, Me.colSch3, Me.colPSch3, Me.colVAT, Me.colITax, Me.colExcise, Me.colMargn, Me.colProfit, Me.colPrice, Me.colRmks})
        Me.PurchaseDataGridView.DataSource = Me.PurchaseBindingSource
        Me.PurchaseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PurchaseDataGridView.GridColor = System.Drawing.Color.Gray
        Me.PurchaseDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PurchaseDataGridView.MultiSelect = False
        Me.PurchaseDataGridView.Name = "PurchaseDataGridView"
        Me.PurchaseDataGridView.ReadOnly = True
        Me.PurchaseDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PurchaseDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PurchaseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PurchaseDataGridView.Size = New System.Drawing.Size(966, 196)
        Me.PurchaseDataGridView.TabIndex = 19
        '
        'colTranID
        '
        Me.colTranID.DataPropertyName = "PRCH_TR_ID"
        Me.colTranID.HeaderText = "Tran #"
        Me.colTranID.Name = "colTranID"
        Me.colTranID.ReadOnly = True
        '
        'colProdID
        '
        Me.colProdID.DataPropertyName = "PRCH_CD"
        Me.colProdID.HeaderText = "Product Code"
        Me.colProdID.Name = "colProdID"
        Me.colProdID.ReadOnly = True
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "PRCH_DESC"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        '
        'colCatg
        '
        Me.colCatg.DataPropertyName = "PRCH_CATG"
        Me.colCatg.HeaderText = "Category"
        Me.colCatg.Name = "colCatg"
        Me.colCatg.ReadOnly = True
        '
        'colInvoice
        '
        Me.colInvoice.DataPropertyName = "PRCH_INVOICE"
        Me.colInvoice.HeaderText = "Invoice #"
        Me.colInvoice.Name = "colInvoice"
        Me.colInvoice.ReadOnly = True
        '
        'colSupplier
        '
        Me.colSupplier.DataPropertyName = "PRCH_SUPPLIER"
        Me.colSupplier.HeaderText = "Supplier"
        Me.colSupplier.Name = "colSupplier"
        Me.colSupplier.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "PRCH_DATE"
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colPck
        '
        Me.colPck.DataPropertyName = "PRCH_PACK"
        Me.colPck.HeaderText = "Packing"
        Me.colPck.Name = "colPck"
        Me.colPck.ReadOnly = True
        '
        'colPPrice
        '
        Me.colPPrice.DataPropertyName = "PRCH_PRICE"
        Me.colPPrice.HeaderText = "P. Price"
        Me.colPPrice.Name = "colPPrice"
        Me.colPPrice.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.DataPropertyName = "PRCH_QTY"
        Me.colQty.HeaderText = "Stock"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colPrvStock
        '
        Me.colPrvStock.DataPropertyName = "PRCH_OLD_QTY"
        Me.colPrvStock.HeaderText = "Prev. Stock"
        Me.colPrvStock.Name = "colPrvStock"
        Me.colPrvStock.ReadOnly = True
        '
        'colMin
        '
        Me.colMin.DataPropertyName = "PRCH_BAL_MIN"
        Me.colMin.HeaderText = "Min Bal."
        Me.colMin.Name = "colMin"
        Me.colMin.ReadOnly = True
        '
        'colSch1
        '
        Me.colSch1.DataPropertyName = "PRCH_SCH1_PRICE"
        Me.colSch1.HeaderText = "Scheme 1"
        Me.colSch1.Name = "colSch1"
        Me.colSch1.ReadOnly = True
        '
        'colPSch1
        '
        Me.colPSch1.DataPropertyName = "PRCH_SCH1_ONHAND"
        Me.colPSch1.HeaderText = "Sch1 Qty"
        Me.colPSch1.Name = "colPSch1"
        Me.colPSch1.ReadOnly = True
        '
        'colSch2
        '
        Me.colSch2.DataPropertyName = "PRCH_SCH2_PRICE"
        Me.colSch2.HeaderText = "Scheme 2"
        Me.colSch2.Name = "colSch2"
        Me.colSch2.ReadOnly = True
        '
        'colPSch2
        '
        Me.colPSch2.DataPropertyName = "PRCH_SCH2_ONHAND"
        Me.colPSch2.HeaderText = "Sch2 Qty"
        Me.colPSch2.Name = "colPSch2"
        Me.colPSch2.ReadOnly = True
        '
        'colSch3
        '
        Me.colSch3.DataPropertyName = "PRCH_SCH3_PRICE"
        Me.colSch3.HeaderText = "Scheme 3"
        Me.colSch3.Name = "colSch3"
        Me.colSch3.ReadOnly = True
        '
        'colPSch3
        '
        Me.colPSch3.DataPropertyName = "PRCH_SCH3_ONHAND"
        Me.colPSch3.HeaderText = "Sch3 Qty"
        Me.colPSch3.Name = "colPSch3"
        Me.colPSch3.ReadOnly = True
        '
        'colVAT
        '
        Me.colVAT.DataPropertyName = "PRCH_VAT"
        Me.colVAT.HeaderText = "V.A.T"
        Me.colVAT.Name = "colVAT"
        Me.colVAT.ReadOnly = True
        '
        'colITax
        '
        Me.colITax.DataPropertyName = "PRCH_ITAX"
        Me.colITax.HeaderText = "I.Tax"
        Me.colITax.Name = "colITax"
        Me.colITax.ReadOnly = True
        '
        'colExcise
        '
        Me.colExcise.DataPropertyName = "PRCH_EX_DUTY"
        Me.colExcise.HeaderText = "Excise Duty"
        Me.colExcise.Name = "colExcise"
        Me.colExcise.ReadOnly = True
        '
        'colMargn
        '
        Me.colMargn.DataPropertyName = "PRCH_DISC_MRG"
        Me.colMargn.HeaderText = "Discount"
        Me.colMargn.Name = "colMargn"
        Me.colMargn.ReadOnly = True
        '
        'colProfit
        '
        Me.colProfit.DataPropertyName = "PRCH_PROFIT"
        Me.colProfit.HeaderText = "Profit Margin"
        Me.colProfit.Name = "colProfit"
        Me.colProfit.ReadOnly = True
        '
        'colPrice
        '
        Me.colPrice.DataPropertyName = "PRCH_SPRICE"
        Me.colPrice.HeaderText = "Sale Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        '
        'colRmks
        '
        Me.colRmks.DataPropertyName = "PRCH_STATUS"
        Me.colRmks.HeaderText = "REMARKS"
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
        Me.ProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.colPrchDate, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGridView.GridColor = System.Drawing.Color.Gray
        Me.ProductDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProductDataGridView.MultiSelect = False
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(966, 197)
        Me.ProductDataGridView.TabIndex = 20
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
        Me.cmdClose.Location = New System.Drawing.Point(947, 5)
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
        Me.cmdMin.Location = New System.Drawing.Point(916, 5)
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_CD"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PROD_DESC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PROD_CATG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROD_UPD_ON"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Update On"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'colPrchDate
        '
        Me.colPrchDate.DataPropertyName = "PROD_DATE"
        Me.colPrchDate.HeaderText = "Purchase On"
        Me.colPrchDate.Name = "colPrchDate"
        Me.colPrchDate.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PROD_PACK"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Packing"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PROD_PPRICE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "P. Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PROD_ONHAND"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PROD_BAL_MIN"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Min Bal."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PROD_VAT"
        Me.DataGridViewTextBoxColumn17.HeaderText = "V.A.T"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PROD_ITAX"
        Me.DataGridViewTextBoxColumn18.HeaderText = "I.Tax"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PROD_EX_DUTY"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Excise Duty"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "PROD_DISC_MRG"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PROD_PROFIT"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Profit Margin"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PROD_SPRICE"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Sale Price"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'Purchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 631)
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
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPck As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCatg As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtITax As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEDuty As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMargin As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDataSet As System.Data.DataSet
    Friend WithEvents BindingNavigatorRefreshItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PurchaseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PurchaseDataSet As System.Data.DataSet
    Friend WithEvents PurchaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ProductDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents colTranID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProdID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrvStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSch1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPSch1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSch2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPSch2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSch3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPSch3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colITax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colExcise As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMargn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProfit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRmks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabelEdit As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabelDelete As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrchDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
