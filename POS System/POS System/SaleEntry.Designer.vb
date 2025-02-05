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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMode = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblUserID = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblDiscHdr = New System.Windows.Forms.Label
        Me.lblTotalPrice = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SaleDataGrid = New System.Windows.Forms.DataGridView
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordDataSet = New System.Data.DataSet
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdSaleReturn = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.lblRefund = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPaid = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmdReturn = New System.Windows.Forms.Button
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
        Me.cmdDiscount = New System.Windows.Forms.Button
        Me.cmdSuspend = New System.Windows.Forms.Button
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.lblCustName = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.lblQty = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmdNew = New System.Windows.Forms.Button
        Me.lblOrgPrice = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmdViewSale = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.lblUserRole = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblHold = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.lblMode)
        Me.Panel1.Controls.Add(Me.lblCustomer)
        Me.Panel1.Controls.Add(Me.lblUserID)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblUserName)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(616, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 137)
        Me.Panel1.TabIndex = 0
        '
        'lblMode
        '
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.White
        Me.lblMode.Location = New System.Drawing.Point(10, 107)
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
        Me.lblCustomer.Location = New System.Drawing.Point(10, 82)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(160, 22)
        Me.lblCustomer.TabIndex = 9
        Me.lblCustomer.Text = "No Customer Selected"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(10, 58)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(160, 22)
        Me.lblUserID.TabIndex = 8
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(10, 34)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(160, 22)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(10, 10)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(160, 22)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblDiscount)
        Me.Panel2.Controls.Add(Me.lblDiscHdr)
        Me.Panel2.Controls.Add(Me.lblTotalPrice)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(179, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 104)
        Me.Panel2.TabIndex = 1
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(81, 13)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(103, 22)
        Me.lblDiscount.TabIndex = 54
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDiscount.Visible = False
        '
        'lblDiscHdr
        '
        Me.lblDiscHdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscHdr.ForeColor = System.Drawing.Color.White
        Me.lblDiscHdr.Location = New System.Drawing.Point(7, 12)
        Me.lblDiscHdr.Name = "lblDiscHdr"
        Me.lblDiscHdr.Size = New System.Drawing.Size(75, 22)
        Me.lblDiscHdr.TabIndex = 53
        Me.lblDiscHdr.Text = "Discount."
        Me.lblDiscHdr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDiscHdr.Visible = False
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblTotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalPrice.Location = New System.Drawing.Point(103, 37)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(329, 63)
        Me.lblTotalPrice.TabIndex = 1
        Me.lblTotalPrice.Text = "0"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(260, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale Total"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(22, 18)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SaleDataGrid)
        Me.SplitContainer1.Panel1.Enabled = False
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1242, 571)
        Me.SplitContainer1.SplitterDistance = 590
        Me.SplitContainer1.TabIndex = 998
        Me.SplitContainer1.TabStop = False
        '
        'SaleDataGrid
        '
        Me.SaleDataGrid.AutoGenerateColumns = False
        Me.SaleDataGrid.BackgroundColor = System.Drawing.Color.DarkGray
        Me.SaleDataGrid.ColumnHeadersHeight = 22
        Me.SaleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SaleDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCode, Me.colDescription, Me.colPrice, Me.colQuantity, Me.colSubTotal})
        Me.SaleDataGrid.DataSource = Me.SaleBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SaleDataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaleDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.SaleDataGrid.Name = "SaleDataGrid"
        Me.SaleDataGrid.ReadOnly = True
        Me.SaleDataGrid.RowHeadersVisible = False
        Me.SaleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SaleDataGrid.Size = New System.Drawing.Size(590, 571)
        Me.SaleDataGrid.TabIndex = 999
        Me.SaleDataGrid.TabStop = False
        '
        'colCode
        '
        Me.colCode.DataPropertyName = "StockID"
        Me.colCode.HeaderText = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "STOCKDESC"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 237
        '
        'colPrice
        '
        Me.colPrice.DataPropertyName = "UnitCost"
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 109
        '
        'colQuantity
        '
        Me.colQuantity.DataPropertyName = "QTY"
        Me.colQuantity.HeaderText = "Qty"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.ReadOnly = True
        Me.colQuantity.Width = 60
        '
        'colSubTotal
        '
        Me.colSubTotal.DataPropertyName = "PRICE"
        Me.colSubTotal.HeaderText = "Sub Total"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.ReadOnly = True
        Me.colSubTotal.Width = 80
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdSaleReturn)
        Me.Panel3.Controls.Add(Me.cmdSave)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cmdSearch)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtCode)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.cmdDelete)
        Me.Panel3.Controls.Add(Me.lblRefund)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtPaid)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.cmdReturn)
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
        Me.Panel3.Controls.Add(Me.cmdDiscount)
        Me.Panel3.Controls.Add(Me.cmdSuspend)
        Me.Panel3.Controls.Add(Me.txtCustomerName)
        Me.Panel3.Controls.Add(Me.lblCustName)
        Me.Panel3.Controls.Add(Me.txtQty)
        Me.Panel3.Controls.Add(Me.lblQty)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(648, 571)
        Me.Panel3.TabIndex = 0
        '
        'cmdSaleReturn
        '
        Me.cmdSaleReturn.BackColor = System.Drawing.Color.DimGray
        Me.cmdSaleReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaleReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaleReturn.ForeColor = System.Drawing.Color.White
        Me.cmdSaleReturn.Location = New System.Drawing.Point(477, 470)
        Me.cmdSaleReturn.Name = "cmdSaleReturn"
        Me.cmdSaleReturn.Size = New System.Drawing.Size(138, 42)
        Me.cmdSaleReturn.TabIndex = 19
        Me.cmdSaleReturn.Text = "Sa&le Return (F10)"
        Me.cmdSaleReturn.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.DimGray
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(478, 518)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(138, 42)
        Me.cmdSave.TabIndex = 20
        Me.cmdSave.Text = "&Save Sale (F12)"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(229, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 22)
        Me.Label7.TabIndex = 58
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
        Me.cmdSearch.Image = Global.POS_System.My.Resources.Resources.search13
        Me.cmdSearch.Location = New System.Drawing.Point(373, 425)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(37, 35)
        Me.cmdSearch.TabIndex = 57
        Me.cmdSearch.TabStop = False
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 22)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Barcode / Stock Code"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(46, 425)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(321, 35)
        Me.txtCode.TabIndex = 0
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(291, 209)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 22)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Qty."
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.DimGray
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Location = New System.Drawing.Point(477, 422)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(138, 42)
        Me.cmdDelete.TabIndex = 18
        Me.cmdDelete.Text = "Re&move Item (F7)"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'lblRefund
        '
        Me.lblRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefund.ForeColor = System.Drawing.Color.Yellow
        Me.lblRefund.Location = New System.Drawing.Point(211, 496)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(156, 35)
        Me.lblRefund.TabIndex = 9
        Me.lblRefund.Text = "00"
        Me.lblRefund.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(209, 471)
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
        Me.Label8.Location = New System.Drawing.Point(43, 471)
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
        Me.txtPaid.Location = New System.Drawing.Point(46, 496)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(157, 35)
        Me.txtPaid.TabIndex = 2
        Me.txtPaid.Text = "00"
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(43, 337)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(169, 22)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Customer Name"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.Color.DimGray
        Me.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.Color.White
        Me.cmdReturn.Location = New System.Drawing.Point(477, 374)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(138, 42)
        Me.cmdReturn.TabIndex = 17
        Me.cmdReturn.Text = "Ret&urn Item (F6)"
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'lblCustID
        '
        Me.lblCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCustID.Location = New System.Drawing.Point(46, 294)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(321, 30)
        Me.lblCustID.TabIndex = 5
        Me.lblCustID.Text = "00"
        Me.lblCustID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(43, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(169, 22)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Customer ID"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSequence
        '
        Me.lblSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequence.ForeColor = System.Drawing.Color.Maroon
        Me.lblSequence.Location = New System.Drawing.Point(211, 168)
        Me.lblSequence.Name = "lblSequence"
        Me.lblSequence.Size = New System.Drawing.Size(156, 30)
        Me.lblSequence.TabIndex = 3
        Me.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(212, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 22)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Sequence #"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvoice
        '
        Me.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.ForeColor = System.Drawing.Color.Maroon
        Me.lblInvoice.Location = New System.Drawing.Point(46, 168)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(166, 30)
        Me.lblInvoice.TabIndex = 2
        Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(43, 146)
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
        Me.lblSaleType.Location = New System.Drawing.Point(46, 231)
        Me.lblSaleType.Name = "lblSaleType"
        Me.lblSaleType.Size = New System.Drawing.Size(246, 30)
        Me.lblSaleType.TabIndex = 4
        Me.lblSaleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(43, 209)
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
        Me.cmdPrint.Location = New System.Drawing.Point(477, 326)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(138, 42)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.Text = "&Print (F5)"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdCreditSale
        '
        Me.cmdCreditSale.BackColor = System.Drawing.Color.DimGray
        Me.cmdCreditSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreditSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreditSale.ForeColor = System.Drawing.Color.White
        Me.cmdCreditSale.Location = New System.Drawing.Point(477, 277)
        Me.cmdCreditSale.Name = "cmdCreditSale"
        Me.cmdCreditSale.Size = New System.Drawing.Size(138, 42)
        Me.cmdCreditSale.TabIndex = 15
        Me.cmdCreditSale.Text = "Cr&edit (F4)"
        Me.cmdCreditSale.UseVisualStyleBackColor = False
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.Color.DimGray
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.Color.White
        Me.cmdCustomer.Location = New System.Drawing.Point(477, 133)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(138, 42)
        Me.cmdCustomer.TabIndex = 10
        Me.cmdCustomer.Text = "&Customer"
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.Color.DimGray
        Me.cmdDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.ForeColor = System.Drawing.Color.White
        Me.cmdDiscount.Location = New System.Drawing.Point(477, 181)
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(138, 42)
        Me.cmdDiscount.TabIndex = 11
        Me.cmdDiscount.Text = "&Discount"
        Me.cmdDiscount.UseVisualStyleBackColor = False
        '
        'cmdSuspend
        '
        Me.cmdSuspend.BackColor = System.Drawing.Color.DimGray
        Me.cmdSuspend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSuspend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuspend.ForeColor = System.Drawing.Color.White
        Me.cmdSuspend.Location = New System.Drawing.Point(477, 229)
        Me.cmdSuspend.Name = "cmdSuspend"
        Me.cmdSuspend.Size = New System.Drawing.Size(138, 42)
        Me.cmdSuspend.TabIndex = 14
        Me.cmdSuspend.Text = "&Hold (F3)"
        Me.cmdSuspend.UseVisualStyleBackColor = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(46, 359)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(321, 29)
        Me.txtCustomerName.TabIndex = 7
        Me.txtCustomerName.Visible = False
        '
        'lblCustName
        '
        Me.lblCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCustName.Location = New System.Drawing.Point(46, 359)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(321, 30)
        Me.lblCustName.TabIndex = 6
        Me.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(289, 231)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(78, 29)
        Me.txtQty.TabIndex = 55
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtQty.Visible = False
        '
        'lblQty
        '
        Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblQty.Location = New System.Drawing.Point(291, 231)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(76, 30)
        Me.lblQty.TabIndex = 53
        Me.lblQty.Text = "1"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 595)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label22)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmdNew)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblOrgPrice)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label21)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblTax)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmdViewSale)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmdExit)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblUserRole)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1264, 74)
        Me.SplitContainer2.SplitterDistance = 613
        Me.SplitContainer2.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkRed
        Me.Label22.Location = New System.Drawing.Point(582, 41)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(22, 22)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "/="
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkRed
        Me.Label18.Location = New System.Drawing.Point(582, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 22)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "/="
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.DimGray
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdNew.Location = New System.Drawing.Point(254, 22)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(133, 33)
        Me.cmdNew.TabIndex = 21
        Me.cmdNew.Text = "Re&fresh (F11)"
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'lblOrgPrice
        '
        Me.lblOrgPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrgPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblOrgPrice.Location = New System.Drawing.Point(493, 41)
        Me.lblOrgPrice.Name = "lblOrgPrice"
        Me.lblOrgPrice.Size = New System.Drawing.Size(94, 22)
        Me.lblOrgPrice.TabIndex = 52
        Me.lblOrgPrice.Text = "0.00"
        Me.lblOrgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(412, 41)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 22)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Total:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTax.Location = New System.Drawing.Point(490, 19)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(97, 22)
        Me.lblTax.TabIndex = 50
        Me.lblTax.Text = "0.00"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(412, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 22)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Tax:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdViewSale
        '
        Me.cmdViewSale.BackColor = System.Drawing.Color.DimGray
        Me.cmdViewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewSale.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdViewSale.Image = Global.POS_System.My.Resources.Resources.PrintHS
        Me.cmdViewSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdViewSale.Location = New System.Drawing.Point(115, 22)
        Me.cmdViewSale.Name = "cmdViewSale"
        Me.cmdViewSale.Size = New System.Drawing.Size(133, 33)
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
        Me.cmdExit.Image = Global.POS_System.My.Resources.Resources.remove3
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(22, 22)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(87, 33)
        Me.cmdExit.TabIndex = 23
        Me.cmdExit.Text = "Cl&ose"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'lblUserRole
        '
        Me.lblUserRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRole.ForeColor = System.Drawing.Color.White
        Me.lblUserRole.Location = New System.Drawing.Point(13, 12)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(174, 22)
        Me.lblUserRole.TabIndex = 57
        Me.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUserRole.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHold)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Location = New System.Drawing.Point(480, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 43)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Hold (F9)"
        '
        'lblHold
        '
        Me.lblHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.ForeColor = System.Drawing.Color.White
        Me.lblHold.Location = New System.Drawing.Point(32, 19)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(76, 16)
        Me.lblHold.TabIndex = 55
        Me.lblHold.Text = "00"
        Me.lblHold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1264, 669)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.SplitContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Invoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
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
    Friend WithEvents cmdDiscount As System.Windows.Forms.Button
    Friend WithEvents cmdSuspend As System.Windows.Forms.Button
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdViewSale As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblOrgPrice As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
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
    Friend WithEvents cmdReturn As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblDiscHdr As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHold As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSaleReturn As System.Windows.Forms.Button
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserRole As System.Windows.Forms.Label
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
