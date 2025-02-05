<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSaleInvoice
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSaleInvoice))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCustID = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.Label
        Me.txtType = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.Label
        Me.txtPayment = New System.Windows.Forms.Label
        Me.txtDues = New System.Windows.Forms.Label
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
        Me.colsbcatg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colItemDues = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbWholeSale = New System.Windows.Forms.RadioButton
        Me.rbRetail = New System.Windows.Forms.RadioButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.txtGross = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 1002
        Me.Label1.Text = "Sale Invoice #"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(273, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(152, 22)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtSearch, "Enter Sale Invoice # to Find")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 1004
        Me.Label2.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 1008
        Me.Label3.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 1006
        Me.Label4.Text = "Customer Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 1016
        Me.Label5.Text = "Due Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 1014
        Me.Label6.Text = "Payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 1012
        Me.Label7.Text = "Discount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 1010
        Me.Label8.Text = "Total"
        '
        'txtCustID
        '
        Me.txtCustID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtCustID.Location = New System.Drawing.Point(17, 48)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(139, 25)
        Me.txtCustID.TabIndex = 1017
        Me.txtCustID.Text = "0"
        Me.txtCustID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtName.Location = New System.Drawing.Point(17, 98)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(139, 25)
        Me.txtName.TabIndex = 1018
        Me.txtName.Text = "0"
        Me.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtType
        '
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtType.Location = New System.Drawing.Point(17, 148)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(139, 25)
        Me.txtType.TabIndex = 1019
        Me.txtType.Text = "0"
        Me.txtType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtTotal.Location = New System.Drawing.Point(17, 296)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(139, 25)
        Me.txtTotal.TabIndex = 1020
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscount
        '
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDiscount.Location = New System.Drawing.Point(17, 248)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(139, 25)
        Me.txtDiscount.TabIndex = 1021
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPayment
        '
        Me.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtPayment.Location = New System.Drawing.Point(17, 344)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(139, 25)
        Me.txtPayment.TabIndex = 1022
        Me.txtPayment.Text = "0"
        Me.txtPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDues
        '
        Me.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDues.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDues.Location = New System.Drawing.Point(17, 394)
        Me.txtDues.Name = "txtDues"
        Me.txtDues.Size = New System.Drawing.Size(139, 25)
        Me.txtDues.TabIndex = 1023
        Me.txtDues.Text = "0"
        Me.txtDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SaleDataGrid
        '
        Me.SaleDataGrid.AllowUserToAddRows = False
        Me.SaleDataGrid.AllowUserToDeleteRows = False
        Me.SaleDataGrid.AllowUserToResizeColumns = False
        Me.SaleDataGrid.AllowUserToResizeRows = False
        Me.SaleDataGrid.BackgroundColor = System.Drawing.Color.DarkGray
        Me.SaleDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SaleDataGrid.ColumnHeadersHeight = 22
        Me.SaleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SaleDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCode, Me.colDescription, Me.colPack, Me.colPrice, Me.colQuantity, Me.colSubTotal, Me.colDel, Me.colDept, Me.colCatg, Me.colsbcatg, Me.colItemDues})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SaleDataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.SaleDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SaleDataGrid.Location = New System.Drawing.Point(173, 48)
        Me.SaleDataGrid.MultiSelect = False
        Me.SaleDataGrid.Name = "SaleDataGrid"
        Me.SaleDataGrid.RowHeadersVisible = False
        Me.SaleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SaleDataGrid.Size = New System.Drawing.Size(591, 323)
        Me.SaleDataGrid.TabIndex = 1001
        '
        'colCode
        '
        Me.colCode.DataPropertyName = "StockID"
        Me.colCode.HeaderText = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCode.Width = 80
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "STOCKDESC"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Width = 185
        '
        'colPack
        '
        Me.colPack.DataPropertyName = "salepack"
        Me.colPack.HeaderText = "Pack"
        Me.colPack.Name = "colPack"
        Me.colPack.Width = 60
        '
        'colPrice
        '
        Me.colPrice.DataPropertyName = "UnitCost"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Width = 80
        '
        'colQuantity
        '
        Me.colQuantity.DataPropertyName = "QTY"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colQuantity.DefaultCellStyle = DataGridViewCellStyle2
        Me.colQuantity.HeaderText = "Qty"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Width = 70
        '
        'colSubTotal
        '
        Me.colSubTotal.DataPropertyName = "PRICE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSubTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSubTotal.HeaderText = "Sub Total"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Width = 90
        '
        'colDel
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDel.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colDel.HeaderText = ""
        Me.colDel.Name = "colDel"
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
        Me.colDept.Visible = False
        '
        'colCatg
        '
        Me.colCatg.DataPropertyName = "Category"
        Me.colCatg.HeaderText = "Category"
        Me.colCatg.Name = "colCatg"
        Me.colCatg.Visible = False
        '
        'colsbcatg
        '
        Me.colsbcatg.DataPropertyName = "SubCategory"
        Me.colsbcatg.HeaderText = "Sub Category"
        Me.colsbcatg.Name = "colsbcatg"
        Me.colsbcatg.Visible = False
        '
        'colItemDues
        '
        Me.colItemDues.DataPropertyName = "ItemDues"
        Me.colItemDues.HeaderText = "Item Dues"
        Me.colItemDues.Name = "colItemDues"
        Me.colItemDues.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(539, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 1026
        Me.Label9.Text = "( Press F2 ? )"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(462, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 1027
        Me.Label10.Text = "Stock Code"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtItemCode
        '
        Me.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(612, 14)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.ShortcutsEnabled = False
        Me.txtItemCode.Size = New System.Drawing.Size(152, 22)
        Me.txtItemCode.TabIndex = 1
        Me.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtItemCode, "Enter Product Code to Add Item")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbWholeSale)
        Me.GroupBox2.Controls.Add(Me.rbRetail)
        Me.GroupBox2.Location = New System.Drawing.Point(173, 381)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 40)
        Me.GroupBox2.TabIndex = 1028
        Me.GroupBox2.TabStop = False
        '
        'rbWholeSale
        '
        Me.rbWholeSale.AutoSize = True
        Me.rbWholeSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWholeSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbWholeSale.Location = New System.Drawing.Point(121, 15)
        Me.rbWholeSale.Name = "rbWholeSale"
        Me.rbWholeSale.Size = New System.Drawing.Size(121, 17)
        Me.rbWholeSale.TabIndex = 3
        Me.rbWholeSale.Text = "WholeSale Mode"
        Me.rbWholeSale.UseVisualStyleBackColor = True
        '
        'rbRetail
        '
        Me.rbRetail.AutoSize = True
        Me.rbRetail.Checked = True
        Me.rbRetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbRetail.Location = New System.Drawing.Point(7, 16)
        Me.rbRetail.Name = "rbRetail"
        Me.rbRetail.Size = New System.Drawing.Size(93, 17)
        Me.rbRetail.TabIndex = 2
        Me.rbRetail.TabStop = True
        Me.rbRetail.Text = "Retail Mode"
        Me.rbRetail.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.POS_Professional.My.Resources.Resources.remove1
        Me.btnClose.Location = New System.Drawing.Point(659, 387)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 35)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.POS_Professional.My.Resources.Resources.saveHS
        Me.btnUpdate.Location = New System.Drawing.Point(437, 387)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 35)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.POS_Professional.My.Resources.Resources.Book_openHS2
        Me.btnRefresh.Location = New System.Drawing.Point(548, 387)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 35)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtGross
        '
        Me.txtGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtGross.Location = New System.Drawing.Point(17, 197)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(139, 25)
        Me.txtGross.TabIndex = 1030
        Me.txtGross.Text = "0"
        Me.txtGross.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 1029
        Me.Label12.Text = "Gross"
        '
        'EditSaleInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(778, 434)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtDues)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaleDataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditSaleInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Sale Invoice"
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCustID As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.Label
    Friend WithEvents txtDues As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents SaleDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPack As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsbcatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemDues As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbWholeSale As System.Windows.Forms.RadioButton
    Friend WithEvents rbRetail As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtGross As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
