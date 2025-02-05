<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPurchases
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewPurchases))
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdMin = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PurchaseDataGridView = New System.Windows.Forms.DataGridView
        Me.colTranID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colProdID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCatg = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToDateTime = New System.Windows.Forms.DateTimePicker
        Me.FromDateTime = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.PurchaseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorFind = New System.Windows.Forms.ToolStripButton
        Me.Panel1.SuspendLayout()
        CType(Me.PurchaseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PurchaseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PurchaseBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 5
        Me.LineShape1.X2 = 977
        Me.LineShape1.Y1 = 48
        Me.LineShape1.Y2 = 48
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Black
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 5
        Me.LineShape2.X2 = 977
        Me.LineShape2.Y1 = 47
        Me.LineShape2.Y2 = 47
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(982, 621)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Purchases Register"
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
        Me.cmdMin.Location = New System.Drawing.Point(912, 7)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(29, 34)
        Me.cmdMin.TabIndex = 20
        Me.cmdMin.TabStop = False
        Me.cmdMin.Text = "----"
        Me.cmdMin.UseVisualStyleBackColor = False
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
        Me.cmdClose.Location = New System.Drawing.Point(943, 7)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(31, 34)
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PurchaseDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 515)
        Me.Panel1.TabIndex = 22
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
        Me.PurchaseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTranID, Me.colProdID, Me.colDesc, Me.colCatg, Me.colSupplier, Me.colDate, Me.colPck, Me.colPPrice, Me.colQty, Me.colPrvStock, Me.colMin, Me.colSch1, Me.colPSch1, Me.colSch2, Me.colPSch2, Me.colSch3, Me.colPSch3, Me.colVAT, Me.colITax, Me.colExcise, Me.colMargn, Me.colProfit, Me.colPrice, Me.colRmks})
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
        Me.PurchaseDataGridView.Size = New System.Drawing.Size(982, 515)
        Me.PurchaseDataGridView.TabIndex = 24
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
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1000
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cmdPreview)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ToDateTime)
        Me.Panel2.Controls.Add(Me.FromDateTime)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 42)
        Me.Panel2.TabIndex = 28
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Image = Global.POS_System.My.Resources.Resources.Book_openHS
        Me.cmdPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPreview.Location = New System.Drawing.Point(530, 4)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(72, 29)
        Me.cmdPreview.TabIndex = 31
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "To"
        '
        'ToDateTime
        '
        Me.ToDateTime.Location = New System.Drawing.Point(317, 9)
        Me.ToDateTime.Name = "ToDateTime"
        Me.ToDateTime.Size = New System.Drawing.Size(204, 20)
        Me.ToDateTime.TabIndex = 1
        '
        'FromDateTime
        '
        Me.FromDateTime.Location = New System.Drawing.Point(74, 9)
        Me.FromDateTime.Name = "FromDateTime"
        Me.FromDateTime.Size = New System.Drawing.Size(204, 20)
        Me.FromDateTime.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "View From"
        '
        'PurchaseBindingNavigator
        '
        Me.PurchaseBindingNavigator.AddNewItem = Nothing
        Me.PurchaseBindingNavigator.BindingSource = Me.PurchaseBindingSource
        Me.PurchaseBindingNavigator.CountItem = Nothing
        Me.PurchaseBindingNavigator.DeleteItem = Nothing
        Me.PurchaseBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PurchaseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorTextBox, Me.BindingNavigatorSeparator4, Me.BindingNavigatorFind})
        Me.PurchaseBindingNavigator.Location = New System.Drawing.Point(444, 12)
        Me.PurchaseBindingNavigator.MoveFirstItem = Nothing
        Me.PurchaseBindingNavigator.MoveLastItem = Nothing
        Me.PurchaseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PurchaseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PurchaseBindingNavigator.Name = "PurchaseBindingNavigator"
        Me.PurchaseBindingNavigator.PositionItem = Nothing
        Me.PurchaseBindingNavigator.Size = New System.Drawing.Size(446, 25)
        Me.PurchaseBindingNavigator.TabIndex = 31
        Me.PurchaseBindingNavigator.Text = "BindingNavigator"
        Me.PurchaseBindingNavigator.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(51, 22)
        Me.BindingNavigatorMoveNextItem.Text = "&Next"
        Me.BindingNavigatorMoveNextItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorTextBox
        '
        Me.BindingNavigatorTextBox.Name = "BindingNavigatorTextBox"
        Me.BindingNavigatorTextBox.Size = New System.Drawing.Size(200, 25)
        Me.BindingNavigatorTextBox.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        Me.BindingNavigatorTextBox.ToolTipText = "Enter Product Code to Find"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorFind
        '
        Me.BindingNavigatorFind.Image = Global.POS_System.My.Resources.Resources.search1
        Me.BindingNavigatorFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorFind.Name = "BindingNavigatorFind"
        Me.BindingNavigatorFind.Size = New System.Drawing.Size(113, 22)
        Me.BindingNavigatorFind.Text = "&View by Product"
        Me.BindingNavigatorFind.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorFind.ToolTipText = "Click to Find Product"
        '
        'frmViewPurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 621)
        Me.Controls.Add(Me.PurchaseBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmViewPurchases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Purchases"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PurchaseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PurchaseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PurchaseBindingNavigator.ResumeLayout(False)
        Me.PurchaseBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PurchaseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents colTranID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProdID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatg As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents PurchaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PurchaseBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
End Class
