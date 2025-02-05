<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleEntry
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblUserID = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTotalPrice = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblMode = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SaleDataGrid = New System.Windows.Forms.DataGridView
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPack = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDel = New System.Windows.Forms.DataGridViewButtonColumn
        Me.colDept = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCatg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdDiscount = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.lblShowDiscount = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblHold = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdSaleReturn = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblRefund = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPaid = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblCustID = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblSequence = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblInvoice = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblSaleType = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdCreditSale = New System.Windows.Forms.Button
        Me.cmdCustomer = New System.Windows.Forms.Button
        Me.cmdSuspend = New System.Windows.Forms.Button
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.lblCustName = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.lblQty = New System.Windows.Forms.Label
        Me.SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordDataSet = New System.Data.DataSet
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.cmdNew = New System.Windows.Forms.Button
        Me.lblDiscHdr = New System.Windows.Forms.Label
        Me.lblOrgPrice = New System.Windows.Forms.Label
        Me.cmdViewSale = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblUserID)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblUserName)
        Me.Panel1.Controls.Add(Me.lblMode)
        Me.Panel1.Controls.Add(Me.lblCustomer)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Location = New System.Drawing.Point(611, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 119)
        Me.Panel1.TabIndex = 197
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(176, 88)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(115, 22)
        Me.lblUserID.TabIndex = 131
        Me.lblUserID.Text = "User ID"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblTotalPrice)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(297, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 112)
        Me.Panel2.TabIndex = 57
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblTotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalPrice.Location = New System.Drawing.Point(7, 56)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(288, 46)
        Me.lblTotalPrice.TabIndex = 130
        Me.lblTotalPrice.Text = "0"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(90, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 35)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Sale Total"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(10, 88)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(160, 22)
        Me.lblUserName.TabIndex = 133
        Me.lblUserName.Text = "User Name"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMode
        '
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.White
        Me.lblMode.Location = New System.Drawing.Point(10, 64)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(160, 22)
        Me.lblMode.TabIndex = 56
        Me.lblMode.Text = "Sale"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustomer
        '
        Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.ForeColor = System.Drawing.Color.White
        Me.lblCustomer.Location = New System.Drawing.Point(10, 38)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(160, 22)
        Me.lblCustomer.TabIndex = 9
        Me.lblCustomer.Text = "No Customer Selected"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(10, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(160, 22)
        Me.lblDate.TabIndex = 107
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 18)
        Me.SplitContainer1.MinimumSize = New System.Drawing.Size(1204, 571)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SaleDataGrid)
        Me.SplitContainer1.Panel1MinSize = 592
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2MinSize = 607
        Me.SplitContainer1.Size = New System.Drawing.Size(1204, 571)
        Me.SplitContainer1.SplitterDistance = 592
        Me.SplitContainer1.TabIndex = 998
        Me.SplitContainer1.TabStop = False
        '
        'SaleDataGrid
        '
        Me.SaleDataGrid.AllowUserToAddRows = False
        Me.SaleDataGrid.AllowUserToDeleteRows = False
        Me.SaleDataGrid.AllowUserToResizeColumns = False
        Me.SaleDataGrid.AllowUserToResizeRows = False
        Me.SaleDataGrid.BackgroundColor = System.Drawing.Color.DarkGray
        Me.SaleDataGrid.ColumnHeadersHeight = 22
        Me.SaleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SaleDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCode, Me.colDescription, Me.colPack, Me.colPrice, Me.colQuantity, Me.colSubTotal, Me.colDel, Me.colDept, Me.colCatg})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SaleDataGrid.DefaultCellStyle = DataGridViewCellStyle15
        Me.SaleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaleDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.SaleDataGrid.MinimumSize = New System.Drawing.Size(592, 571)
        Me.SaleDataGrid.MultiSelect = False
        Me.SaleDataGrid.Name = "SaleDataGrid"
        Me.SaleDataGrid.ReadOnly = True
        Me.SaleDataGrid.RowHeadersVisible = False
        Me.SaleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SaleDataGrid.Size = New System.Drawing.Size(592, 571)
        Me.SaleDataGrid.TabIndex = 999
        '
        'colCode
        '
        Me.colCode.DataPropertyName = "StockID"
        Me.colCode.HeaderText = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True
        Me.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCode.Width = 80
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "STOCKDESC"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 185
        '
        'colPack
        '
        Me.colPack.DataPropertyName = "salepack"
        Me.colPack.HeaderText = "Pack"
        Me.colPack.Name = "colPack"
        Me.colPack.ReadOnly = True
        Me.colPack.Width = 60
        '
        'colPrice
        '
        Me.colPrice.DataPropertyName = "UnitCost"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle11
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 80
        '
        'colQuantity
        '
        Me.colQuantity.DataPropertyName = "QTY"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colQuantity.DefaultCellStyle = DataGridViewCellStyle12
        Me.colQuantity.HeaderText = "Qty"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.ReadOnly = True
        Me.colQuantity.Width = 70
        '
        'colSubTotal
        '
        Me.colSubTotal.DataPropertyName = "PRICE"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSubTotal.DefaultCellStyle = DataGridViewCellStyle13
        Me.colSubTotal.HeaderText = "Sub Total"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.ReadOnly = True
        Me.colSubTotal.Width = 90
        '
        'colDel
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDel.DefaultCellStyle = DataGridViewCellStyle14
        Me.colDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colDel.HeaderText = ""
        Me.colDel.Name = "colDel"
        Me.colDel.ReadOnly = True
        Me.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDel.Text = "X"
        Me.colDel.Width = 24
        '
        'colDept
        '
        Me.colDept.DataPropertyName = "HeadCategory"
        Me.colDept.HeaderText = "Department"
        Me.colDept.Name = "colDept"
        Me.colDept.ReadOnly = True
        Me.colDept.Visible = False
        '
        'colCatg
        '
        Me.colCatg.DataPropertyName = "SubCategory"
        Me.colCatg.HeaderText = "Category"
        Me.colCatg.Name = "colCatg"
        Me.colCatg.ReadOnly = True
        Me.colCatg.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cmdDiscount)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cmdSearch)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtCode)
        Me.Panel3.Controls.Add(Me.lblShowDiscount)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cmdSaleReturn)
        Me.Panel3.Controls.Add(Me.cmdSave)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.lblRefund)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtPaid)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.lblCustID)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.lblSequence)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.lblInvoice)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lblSaleType)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cmdPrint)
        Me.Panel3.Controls.Add(Me.cmdCreditSale)
        Me.Panel3.Controls.Add(Me.cmdCustomer)
        Me.Panel3.Controls.Add(Me.cmdSuspend)
        Me.Panel3.Controls.Add(Me.txtCustomerName)
        Me.Panel3.Controls.Add(Me.lblCustName)
        Me.Panel3.Controls.Add(Me.txtQty)
        Me.Panel3.Controls.Add(Me.lblQty)
        Me.Panel3.Location = New System.Drawing.Point(3, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(605, 570)
        Me.Panel3.TabIndex = 198
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.Color.DimGray
        Me.cmdDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.ForeColor = System.Drawing.Color.White
        Me.cmdDiscount.Location = New System.Drawing.Point(426, 209)
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(138, 42)
        Me.cmdDiscount.TabIndex = 106
        Me.cmdDiscount.Text = "&Discount (F4)"
        Me.cmdDiscount.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(205, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 22)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "( Press F2 for Items List )"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Gray
        Me.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.Color.Yellow
        Me.cmdSearch.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.cmdSearch.Location = New System.Drawing.Point(332, 161)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(37, 35)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.TabStop = False
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 22)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Barcode / Stock Code"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(46, 161)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(280, 35)
        Me.txtCode.TabIndex = 992
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblShowDiscount
        '
        Me.lblShowDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowDiscount.ForeColor = System.Drawing.Color.Yellow
        Me.lblShowDiscount.Location = New System.Drawing.Point(209, 436)
        Me.lblShowDiscount.Name = "lblShowDiscount"
        Me.lblShowDiscount.Size = New System.Drawing.Size(160, 35)
        Me.lblShowDiscount.TabIndex = 60
        Me.lblShowDiscount.Text = "00"
        Me.lblShowDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHold)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.GroupBox1.Location = New System.Drawing.Point(426, 503)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 43)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pending (F10)"
        '
        'lblHold
        '
        Me.lblHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.ForeColor = System.Drawing.Color.White
        Me.lblHold.Location = New System.Drawing.Point(33, 19)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(76, 16)
        Me.lblHold.TabIndex = 55
        Me.lblHold.Text = "00"
        Me.lblHold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(207, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 22)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Discount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSaleReturn
        '
        Me.cmdSaleReturn.BackColor = System.Drawing.Color.DimGray
        Me.cmdSaleReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaleReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaleReturn.ForeColor = System.Drawing.Color.White
        Me.cmdSaleReturn.Location = New System.Drawing.Point(426, 353)
        Me.cmdSaleReturn.Name = "cmdSaleReturn"
        Me.cmdSaleReturn.Size = New System.Drawing.Size(138, 42)
        Me.cmdSaleReturn.TabIndex = 16
        Me.cmdSaleReturn.Text = "Sa&le Return (F7)"
        Me.cmdSaleReturn.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.DimGray
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(426, 401)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(138, 42)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "&Save Sale (F8)"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(43, 411)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 22)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Qty."
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRefund
        '
        Me.lblRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefund.ForeColor = System.Drawing.Color.Yellow
        Me.lblRefund.Location = New System.Drawing.Point(209, 511)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(160, 35)
        Me.lblRefund.TabIndex = 129
        Me.lblRefund.Text = "00"
        Me.lblRefund.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(209, 486)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 22)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Refund"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(43, 486)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 22)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Payment"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPaid
        '
        Me.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaid.Enabled = False
        Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.Location = New System.Drawing.Point(46, 511)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(157, 35)
        Me.txtPaid.TabIndex = 4
        Me.txtPaid.Text = "00"
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(43, 340)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 22)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Customer Name"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustID
        '
        Me.lblCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCustID.Location = New System.Drawing.Point(282, 298)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(85, 30)
        Me.lblCustID.TabIndex = 103
        Me.lblCustID.Text = "00"
        Me.lblCustID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(279, 275)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 22)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Cust: ID"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSequence
        '
        Me.lblSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequence.ForeColor = System.Drawing.Color.Maroon
        Me.lblSequence.Location = New System.Drawing.Point(178, 234)
        Me.lblSequence.Name = "lblSequence"
        Me.lblSequence.Size = New System.Drawing.Size(189, 30)
        Me.lblSequence.TabIndex = 123
        Me.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(178, 212)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 22)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Sequence #"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvoice
        '
        Me.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.ForeColor = System.Drawing.Color.Maroon
        Me.lblInvoice.Location = New System.Drawing.Point(46, 234)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(133, 30)
        Me.lblInvoice.TabIndex = 122
        Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(43, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 22)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Sale Invoice #"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSaleType
        '
        Me.lblSaleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaleType.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblSaleType.Location = New System.Drawing.Point(46, 298)
        Me.lblSaleType.Name = "lblSaleType"
        Me.lblSaleType.Size = New System.Drawing.Size(237, 30)
        Me.lblSaleType.TabIndex = 124
        Me.lblSaleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(43, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 22)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Sale Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.DimGray
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(426, 449)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(138, 42)
        Me.cmdPrint.TabIndex = 18
        Me.cmdPrint.Text = "&Print Bill (F9)"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdCreditSale
        '
        Me.cmdCreditSale.BackColor = System.Drawing.Color.DimGray
        Me.cmdCreditSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreditSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreditSale.ForeColor = System.Drawing.Color.White
        Me.cmdCreditSale.Location = New System.Drawing.Point(426, 305)
        Me.cmdCreditSale.Name = "cmdCreditSale"
        Me.cmdCreditSale.Size = New System.Drawing.Size(138, 42)
        Me.cmdCreditSale.TabIndex = 15
        Me.cmdCreditSale.Text = "Cr&edit Sale (F6)"
        Me.cmdCreditSale.UseVisualStyleBackColor = False
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.Color.DimGray
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.Color.White
        Me.cmdCustomer.Location = New System.Drawing.Point(426, 161)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(138, 42)
        Me.cmdCustomer.TabIndex = 13
        Me.cmdCustomer.Text = "&Customer (F3)"
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'cmdSuspend
        '
        Me.cmdSuspend.BackColor = System.Drawing.Color.DimGray
        Me.cmdSuspend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSuspend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuspend.ForeColor = System.Drawing.Color.White
        Me.cmdSuspend.Location = New System.Drawing.Point(426, 257)
        Me.cmdSuspend.Name = "cmdSuspend"
        Me.cmdSuspend.Size = New System.Drawing.Size(138, 42)
        Me.cmdSuspend.TabIndex = 14
        Me.cmdSuspend.Text = "&Hold Sale(F5)"
        Me.cmdSuspend.UseVisualStyleBackColor = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(46, 362)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(323, 35)
        Me.txtCustomerName.TabIndex = 2
        Me.txtCustomerName.Visible = False
        '
        'lblCustName
        '
        Me.lblCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCustName.Location = New System.Drawing.Point(46, 362)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(321, 35)
        Me.lblCustName.TabIndex = 105
        Me.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(46, 436)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(157, 35)
        Me.txtQty.TabIndex = 3
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtQty.Visible = False
        '
        'lblQty
        '
        Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblQty.Location = New System.Drawing.Point(48, 436)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(155, 35)
        Me.lblQty.TabIndex = 53
        Me.lblQty.Text = "1"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaleBindingSource
        '
        Me.SaleBindingSource.DataSource = Me.RecordDataSet
        Me.SaleBindingSource.Position = 0
        '
        'RecordDataSet
        '
        Me.RecordDataSet.DataSetName = "RecordDataSet"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 595)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblDiscount)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmdNew)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblDiscHdr)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblOrgPrice)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmdViewSale)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmdExit)
        Me.SplitContainer2.Size = New System.Drawing.Size(1228, 74)
        Me.SplitContainer2.SplitterDistance = 604
        Me.SplitContainer2.TabIndex = 159
        Me.SplitContainer2.TabStop = False
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(465, 38)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(74, 22)
        Me.lblDiscount.TabIndex = 54
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDiscount.Visible = False
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.DimGray
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdNew.Location = New System.Drawing.Point(291, 9)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(133, 52)
        Me.cmdNew.TabIndex = 21
        Me.cmdNew.Text = "Re&fresh (F11)"
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'lblDiscHdr
        '
        Me.lblDiscHdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscHdr.ForeColor = System.Drawing.Color.White
        Me.lblDiscHdr.Location = New System.Drawing.Point(465, 13)
        Me.lblDiscHdr.Name = "lblDiscHdr"
        Me.lblDiscHdr.Size = New System.Drawing.Size(74, 22)
        Me.lblDiscHdr.TabIndex = 53
        Me.lblDiscHdr.Text = "Discount."
        Me.lblDiscHdr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDiscHdr.Visible = False
        '
        'lblOrgPrice
        '
        Me.lblOrgPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrgPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblOrgPrice.Location = New System.Drawing.Point(550, 38)
        Me.lblOrgPrice.Name = "lblOrgPrice"
        Me.lblOrgPrice.Size = New System.Drawing.Size(43, 22)
        Me.lblOrgPrice.TabIndex = 52
        Me.lblOrgPrice.Text = "0.00"
        Me.lblOrgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOrgPrice.Visible = False
        '
        'cmdViewSale
        '
        Me.cmdViewSale.BackColor = System.Drawing.Color.DimGray
        Me.cmdViewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewSale.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdViewSale.Image = Global.POS_Professional.My.Resources.Resources.PrintHS
        Me.cmdViewSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdViewSale.Location = New System.Drawing.Point(152, 9)
        Me.cmdViewSale.Name = "cmdViewSale"
        Me.cmdViewSale.Size = New System.Drawing.Size(133, 52)
        Me.cmdViewSale.TabIndex = 22
        Me.cmdViewSale.TabStop = False
        Me.cmdViewSale.Text = "&Request Slip"
        Me.cmdViewSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdViewSale.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.DimGray
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdExit.Image = Global.POS_Professional.My.Resources.Resources.remove1
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(12, 9)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(133, 52)
        Me.cmdExit.TabIndex = 23
        Me.cmdExit.Text = "Cl&ose"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'SaleEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1228, 669)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.SplitContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "SaleEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Screen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SaleDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblSequence As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblInvoice As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSaleType As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdCustomer As System.Windows.Forms.Button
    Friend WithEvents cmdSuspend As System.Windows.Forms.Button
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdViewSale As System.Windows.Forms.Button
    Friend WithEvents lblOrgPrice As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblRefund As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents cmdCreditSale As System.Windows.Forms.Button
    Friend WithEvents RecordDataSet As System.Data.DataSet
    Friend WithEvents SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHold As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSaleReturn As System.Windows.Forms.Button
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblShowDiscount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPack As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblDiscHdr As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents cmdDiscount As System.Windows.Forms.Button
End Class
