<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleScreen
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleScreen))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblUserID = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTotalPrice = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblMode = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnPaid = New System.Windows.Forms.Button
        Me.cmdDiscount = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.lblShowDiscount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdSaleReturn = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblNetDues = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblHold = New System.Windows.Forms.Label
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
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblDiscHdr = New System.Windows.Forms.Label
        Me.lblOrgPrice = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbWholeSale = New System.Windows.Forms.RadioButton
        Me.rbRetail = New System.Windows.Forms.RadioButton
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdSelectBill = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblTotItems = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(608, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 119)
        Me.Panel1.TabIndex = 198
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(176, 85)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(89, 22)
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
        Me.Panel2.Location = New System.Drawing.Point(271, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 113)
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
        Me.lblUserName.Location = New System.Drawing.Point(10, 85)
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
        Me.lblMode.Location = New System.Drawing.Point(10, 61)
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
        Me.lblCustomer.Location = New System.Drawing.Point(10, 35)
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
        Me.lblDate.Location = New System.Drawing.Point(10, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(160, 22)
        Me.lblDate.TabIndex = 107
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnPaid)
        Me.Panel3.Controls.Add(Me.cmdDiscount)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cmdSearch)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtCode)
        Me.Panel3.Controls.Add(Me.lblShowDiscount)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cmdSaleReturn)
        Me.Panel3.Controls.Add(Me.cmdSave)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.lblNetDues)
        Me.Panel3.Controls.Add(Me.Label8)
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
        Me.Panel3.Location = New System.Drawing.Point(608, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(579, 453)
        Me.Panel3.TabIndex = 199
        '
        'btnPaid
        '
        Me.btnPaid.BackColor = System.Drawing.Color.DimGray
        Me.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaid.ForeColor = System.Drawing.Color.White
        Me.btnPaid.Location = New System.Drawing.Point(428, 383)
        Me.btnPaid.Name = "btnPaid"
        Me.btnPaid.Size = New System.Drawing.Size(138, 42)
        Me.btnPaid.TabIndex = 19
        Me.btnPaid.Text = "D&ues Payment"
        Me.btnPaid.UseVisualStyleBackColor = False
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.Color.DimGray
        Me.cmdDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.ForeColor = System.Drawing.Color.White
        Me.cmdDiscount.Location = New System.Drawing.Point(428, 89)
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
        Me.Label7.Location = New System.Drawing.Point(207, 15)
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
        Me.cmdSearch.Location = New System.Drawing.Point(334, 40)
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
        Me.Label6.Location = New System.Drawing.Point(45, 15)
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
        Me.txtCode.Location = New System.Drawing.Point(48, 40)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(284, 35)
        Me.txtCode.TabIndex = 1
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblShowDiscount
        '
        Me.lblShowDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowDiscount.ForeColor = System.Drawing.Color.Yellow
        Me.lblShowDiscount.Location = New System.Drawing.Point(211, 319)
        Me.lblShowDiscount.Name = "lblShowDiscount"
        Me.lblShowDiscount.Size = New System.Drawing.Size(160, 35)
        Me.lblShowDiscount.TabIndex = 60
        Me.lblShowDiscount.Text = "00"
        Me.lblShowDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(209, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 22)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Discount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSaleReturn
        '
        Me.cmdSaleReturn.BackColor = System.Drawing.Color.DimGray
        Me.cmdSaleReturn.Enabled = False
        Me.cmdSaleReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaleReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaleReturn.ForeColor = System.Drawing.Color.White
        Me.cmdSaleReturn.Location = New System.Drawing.Point(428, 235)
        Me.cmdSaleReturn.Name = "cmdSaleReturn"
        Me.cmdSaleReturn.Size = New System.Drawing.Size(138, 42)
        Me.cmdSaleReturn.TabIndex = 16
        Me.cmdSaleReturn.Text = "Sa&le Return (F7)"
        Me.cmdSaleReturn.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.DimGray
        Me.cmdSave.Enabled = False
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(428, 284)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(138, 42)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "Cash &Sale (F8)"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(45, 294)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 22)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Qty."
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNetDues
        '
        Me.lblNetDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetDues.ForeColor = System.Drawing.Color.Yellow
        Me.lblNetDues.Location = New System.Drawing.Point(212, 390)
        Me.lblNetDues.Name = "lblNetDues"
        Me.lblNetDues.Size = New System.Drawing.Size(159, 35)
        Me.lblNetDues.TabIndex = 129
        Me.lblNetDues.Text = "00"
        Me.lblNetDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(48, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 35)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Net Dues"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(45, 219)
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
        Me.lblCustID.ForeColor = System.Drawing.Color.Lime
        Me.lblCustID.Location = New System.Drawing.Point(284, 177)
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
        Me.Label15.Location = New System.Drawing.Point(281, 154)
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
        Me.lblSequence.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.lblSequence.Location = New System.Drawing.Point(180, 113)
        Me.lblSequence.Name = "lblSequence"
        Me.lblSequence.Size = New System.Drawing.Size(189, 30)
        Me.lblSequence.TabIndex = 123
        Me.lblSequence.Text = "00"
        Me.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(180, 91)
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
        Me.lblInvoice.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.lblInvoice.Location = New System.Drawing.Point(48, 113)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(133, 30)
        Me.lblInvoice.TabIndex = 122
        Me.lblInvoice.Text = "00"
        Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(45, 91)
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
        Me.lblSaleType.ForeColor = System.Drawing.Color.Lime
        Me.lblSaleType.Location = New System.Drawing.Point(48, 177)
        Me.lblSaleType.Name = "lblSaleType"
        Me.lblSaleType.Size = New System.Drawing.Size(237, 30)
        Me.lblSaleType.TabIndex = 124
        Me.lblSaleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(45, 154)
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
        Me.cmdPrint.Location = New System.Drawing.Point(428, 333)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(138, 42)
        Me.cmdPrint.TabIndex = 18
        Me.cmdPrint.Text = "&Print Bill (F9)"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdCreditSale
        '
        Me.cmdCreditSale.BackColor = System.Drawing.Color.DimGray
        Me.cmdCreditSale.Enabled = False
        Me.cmdCreditSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCreditSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreditSale.ForeColor = System.Drawing.Color.White
        Me.cmdCreditSale.Location = New System.Drawing.Point(428, 186)
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
        Me.cmdCustomer.Location = New System.Drawing.Point(428, 40)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(138, 42)
        Me.cmdCustomer.TabIndex = 13
        Me.cmdCustomer.Text = "&Customer (F3)"
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'cmdSuspend
        '
        Me.cmdSuspend.BackColor = System.Drawing.Color.DimGray
        Me.cmdSuspend.Enabled = False
        Me.cmdSuspend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSuspend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuspend.ForeColor = System.Drawing.Color.White
        Me.cmdSuspend.Location = New System.Drawing.Point(428, 138)
        Me.cmdSuspend.Name = "cmdSuspend"
        Me.cmdSuspend.Size = New System.Drawing.Size(138, 42)
        Me.cmdSuspend.TabIndex = 14
        Me.cmdSuspend.Text = "&Hold Sale (F12)"
        Me.cmdSuspend.UseVisualStyleBackColor = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(48, 241)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(323, 35)
        Me.txtCustomerName.TabIndex = 2
        Me.txtCustomerName.Visible = False
        '
        'lblCustName
        '
        Me.lblCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.Color.Lime
        Me.lblCustName.Location = New System.Drawing.Point(48, 241)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(321, 35)
        Me.lblCustName.TabIndex = 105
        Me.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(48, 319)
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
        Me.lblQty.Location = New System.Drawing.Point(50, 319)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(155, 35)
        Me.lblQty.TabIndex = 53
        Me.lblQty.Text = "1"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHold)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.GroupBox1.Location = New System.Drawing.Point(1037, 593)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 57)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pending (F10)"
        '
        'lblHold
        '
        Me.lblHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.ForeColor = System.Drawing.Color.White
        Me.lblHold.Location = New System.Drawing.Point(33, 19)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(76, 30)
        Me.lblHold.TabIndex = 55
        Me.lblHold.Text = "00"
        Me.lblHold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.SaleDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCode, Me.colDescription, Me.colPack, Me.colPrice, Me.colQuantity, Me.colSubTotal, Me.colDel, Me.colDept, Me.colCatg, Me.colsbcatg})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SaleDataGrid.DefaultCellStyle = DataGridViewCellStyle10
        Me.SaleDataGrid.Location = New System.Drawing.Point(8, 130)
        Me.SaleDataGrid.MinimumSize = New System.Drawing.Size(592, 453)
        Me.SaleDataGrid.MultiSelect = False
        Me.SaleDataGrid.Name = "SaleDataGrid"
        Me.SaleDataGrid.ReadOnly = True
        Me.SaleDataGrid.RowHeadersVisible = False
        Me.SaleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SaleDataGrid.Size = New System.Drawing.Size(592, 453)
        Me.SaleDataGrid.StandardTab = True
        Me.SaleDataGrid.TabIndex = 0
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle6
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 80
        '
        'colQuantity
        '
        Me.colQuantity.DataPropertyName = "QTY"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colQuantity.DefaultCellStyle = DataGridViewCellStyle7
        Me.colQuantity.HeaderText = "Qty"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.ReadOnly = True
        Me.colQuantity.Width = 70
        '
        'colSubTotal
        '
        Me.colSubTotal.DataPropertyName = "PRICE"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSubTotal.DefaultCellStyle = DataGridViewCellStyle8
        Me.colSubTotal.HeaderText = "Sub Total"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.ReadOnly = True
        Me.colSubTotal.Width = 90
        '
        'colDel
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDel.DefaultCellStyle = DataGridViewCellStyle9
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
        Me.colCatg.DataPropertyName = "Category"
        Me.colCatg.HeaderText = "Category"
        Me.colCatg.Name = "colCatg"
        Me.colCatg.ReadOnly = True
        Me.colCatg.Visible = False
        '
        'colsbcatg
        '
        Me.colsbcatg.DataPropertyName = "SubCategory"
        Me.colsbcatg.HeaderText = "Sub Category"
        Me.colsbcatg.Name = "colsbcatg"
        Me.colsbcatg.ReadOnly = True
        Me.colsbcatg.Visible = False
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(446, 538)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(74, 22)
        Me.lblDiscount.TabIndex = 1006
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDiscount.Visible = False
        '
        'lblDiscHdr
        '
        Me.lblDiscHdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscHdr.ForeColor = System.Drawing.Color.White
        Me.lblDiscHdr.Location = New System.Drawing.Point(446, 513)
        Me.lblDiscHdr.Name = "lblDiscHdr"
        Me.lblDiscHdr.Size = New System.Drawing.Size(74, 22)
        Me.lblDiscHdr.TabIndex = 1005
        Me.lblDiscHdr.Text = "Discount."
        Me.lblDiscHdr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDiscHdr.Visible = False
        '
        'lblOrgPrice
        '
        Me.lblOrgPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrgPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblOrgPrice.Location = New System.Drawing.Point(531, 538)
        Me.lblOrgPrice.Name = "lblOrgPrice"
        Me.lblOrgPrice.Size = New System.Drawing.Size(43, 22)
        Me.lblOrgPrice.TabIndex = 1004
        Me.lblOrgPrice.Text = "0.00"
        Me.lblOrgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOrgPrice.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(152, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 66)
        Me.Label2.TabIndex = 1008
        Me.Label2.Text = "Last Hope POS Solutions"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbWholeSale)
        Me.GroupBox2.Controls.Add(Me.rbRetail)
        Me.GroupBox2.Location = New System.Drawing.Point(608, 592)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(173, 57)
        Me.GroupBox2.TabIndex = 1009
        Me.GroupBox2.TabStop = False
        '
        'rbWholeSale
        '
        Me.rbWholeSale.AutoSize = True
        Me.rbWholeSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWholeSale.ForeColor = System.Drawing.Color.PaleGreen
        Me.rbWholeSale.Location = New System.Drawing.Point(9, 32)
        Me.rbWholeSale.Name = "rbWholeSale"
        Me.rbWholeSale.Size = New System.Drawing.Size(121, 17)
        Me.rbWholeSale.TabIndex = 1101
        Me.rbWholeSale.Text = "WholeSale Mode"
        Me.rbWholeSale.UseVisualStyleBackColor = True
        '
        'rbRetail
        '
        Me.rbRetail.AutoSize = True
        Me.rbRetail.Checked = True
        Me.rbRetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRetail.ForeColor = System.Drawing.Color.PaleGreen
        Me.rbRetail.Location = New System.Drawing.Point(9, 14)
        Me.rbRetail.Name = "rbRetail"
        Me.rbRetail.Size = New System.Drawing.Size(93, 17)
        Me.rbRetail.TabIndex = 1100
        Me.rbRetail.TabStop = True
        Me.rbRetail.Text = "Retail Mode"
        Me.rbRetail.UseVisualStyleBackColor = True
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.DimGray
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdFind.Image = Global.POS_Professional.My.Resources.Resources.search
        Me.cmdFind.Location = New System.Drawing.Point(461, 597)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(139, 52)
        Me.cmdFind.TabIndex = 20
        Me.cmdFind.Text = "Ite&m Price"
        Me.cmdFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdFind.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.DimGray
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdNew.Image = Global.POS_Professional.My.Resources.Resources._1485917175_view_refresh
        Me.cmdNew.Location = New System.Drawing.Point(310, 597)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(139, 52)
        Me.cmdNew.TabIndex = 21
        Me.cmdNew.Text = "&New (F11)"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdSelectBill
        '
        Me.cmdSelectBill.BackColor = System.Drawing.Color.DimGray
        Me.cmdSelectBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSelectBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectBill.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdSelectBill.Image = CType(resources.GetObject("cmdSelectBill.Image"), System.Drawing.Image)
        Me.cmdSelectBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSelectBill.Location = New System.Drawing.Point(159, 597)
        Me.cmdSelectBill.Name = "cmdSelectBill"
        Me.cmdSelectBill.Size = New System.Drawing.Size(139, 52)
        Me.cmdSelectBill.TabIndex = 22
        Me.cmdSelectBill.Text = "Selec&t Bill"
        Me.cmdSelectBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSelectBill.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.DimGray
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.DarkKhaki
        Me.cmdExit.Image = Global.POS_Professional.My.Resources.Resources.Log_Out
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(7, 597)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(139, 52)
        Me.cmdExit.TabIndex = 23
        Me.cmdExit.Text = "&Back"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POS_Professional.My.Resources.Resources.cashbox_128
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 94)
        Me.PictureBox1.TabIndex = 1007
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotItems)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(842, 592)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(137, 57)
        Me.GroupBox3.TabIndex = 1010
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Items"
        '
        'lblTotItems
        '
        Me.lblTotItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotItems.ForeColor = System.Drawing.Color.Purple
        Me.lblTotItems.Location = New System.Drawing.Point(30, 22)
        Me.lblTotItems.Name = "lblTotItems"
        Me.lblTotItems.Size = New System.Drawing.Size(76, 27)
        Me.lblTotItems.TabIndex = 56
        Me.lblTotItems.Text = "00"
        Me.lblTotItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1197, 663)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdSelectBill)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.SaleDataGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblDiscHdr)
        Me.Controls.Add(Me.lblOrgPrice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "SaleScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sale Screen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SaleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdDiscount As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblShowDiscount As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHold As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdSaleReturn As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblNetDues As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblCustID As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblSequence As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblInvoice As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSaleType As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdCreditSale As System.Windows.Forms.Button
    Friend WithEvents cmdCustomer As System.Windows.Forms.Button
    Friend WithEvents cmdSuspend As System.Windows.Forms.Button
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents SaleDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents lblDiscHdr As System.Windows.Forms.Label
    Friend WithEvents lblOrgPrice As System.Windows.Forms.Label
    Friend WithEvents cmdSelectBill As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbWholeSale As System.Windows.Forms.RadioButton
    Friend WithEvents rbRetail As System.Windows.Forms.RadioButton
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents btnPaid As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotItems As System.Windows.Forms.Label
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
End Class
