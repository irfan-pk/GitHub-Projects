<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvTransactions
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbCode = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtRetailer = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.InvDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdUpdateRcv = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtInvoice = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtRcvQty = New System.Windows.Forms.TextBox
        Me.InvTranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvTranDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RcvDataGridView = New System.Windows.Forms.DataGridView
        Me.IssuedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colInvoice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRetailer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOldQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQtyIssu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQtyUpd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPchPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.InvTranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvTranDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RcvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssuedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Code"
        '
        'cmbCode
        '
        Me.cmbCode.FormattingEnabled = True
        Me.cmbCode.Location = New System.Drawing.Point(97, 21)
        Me.cmbCode.Name = "cmbCode"
        Me.cmbCode.Size = New System.Drawing.Size(123, 24)
        Me.cmbCode.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRetailer)
        Me.GroupBox2.Controls.Add(Me.cmdClose)
        Me.GroupBox2.Controls.Add(Me.InvDate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbCode)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtBalance)
        Me.GroupBox2.Controls.Add(Me.txtDesc)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmdUpdateRcv)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtInvoice)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtRcvQty)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(820, 154)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'txtRetailer
        '
        Me.txtRetailer.Location = New System.Drawing.Point(344, 86)
        Me.txtRetailer.Name = "txtRetailer"
        Me.txtRetailer.Size = New System.Drawing.Size(331, 22)
        Me.txtRetailer.TabIndex = 5
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(726, 117)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(78, 21)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'InvDate
        '
        Me.InvDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvDate.Location = New System.Drawing.Point(585, 21)
        Me.InvDate.Name = "InvDate"
        Me.InvDate.Size = New System.Drawing.Size(219, 21)
        Me.InvDate.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(614, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Balance"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(442, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Select Transaction Date"
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(679, 52)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(125, 21)
        Me.txtBalance.TabIndex = 3
        Me.txtBalance.TabStop = False
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(97, 55)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(297, 21)
        Me.txtDesc.TabIndex = 2
        Me.txtDesc.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Retailer Name"
        '
        'cmdUpdateRcv
        '
        Me.cmdUpdateRcv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdateRcv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateRcv.Location = New System.Drawing.Point(642, 117)
        Me.cmdUpdateRcv.Name = "cmdUpdateRcv"
        Me.cmdUpdateRcv.Size = New System.Drawing.Size(78, 21)
        Me.cmdUpdateRcv.TabIndex = 8
        Me.cmdUpdateRcv.Text = "&Update"
        Me.cmdUpdateRcv.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Invoice #"
        '
        'txtInvoice
        '
        Me.txtInvoice.Location = New System.Drawing.Point(97, 86)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(138, 22)
        Me.txtInvoice.TabIndex = 4
        Me.txtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(695, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Qty."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRcvQty
        '
        Me.txtRcvQty.Location = New System.Drawing.Point(727, 86)
        Me.txtRcvQty.MaxLength = 3
        Me.txtRcvQty.Name = "txtRcvQty"
        Me.txtRcvQty.Size = New System.Drawing.Size(77, 22)
        Me.txtRcvQty.TabIndex = 6
        Me.txtRcvQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InvTranBindingSource
        '
        Me.InvTranBindingSource.DataSource = Me.InvTranDataSet
        Me.InvTranBindingSource.Position = 0
        '
        'InvTranDataSet
        '
        Me.InvTranDataSet.DataSetName = "InvTranDataSet"
        Me.InvTranDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "INVENTORY"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RcvDataGridView)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 228)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'RcvDataGridView
        '
        Me.RcvDataGridView.AllowUserToAddRows = False
        Me.RcvDataGridView.AllowUserToDeleteRows = False
        Me.RcvDataGridView.AutoGenerateColumns = False
        Me.RcvDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RcvDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RcvDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RcvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RcvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colInvoice, Me.colCode, Me.colDescription, Me.colRetailer, Me.colOldQty, Me.colQty, Me.colQtyIssu, Me.colQtyUpd, Me.colPchPrice, Me.colStatus})
        Me.RcvDataGridView.DataSource = Me.InvTranBindingSource
        Me.RcvDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RcvDataGridView.Location = New System.Drawing.Point(3, 18)
        Me.RcvDataGridView.Name = "RcvDataGridView"
        Me.RcvDataGridView.ReadOnly = True
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RcvDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.RcvDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RcvDataGridView.Size = New System.Drawing.Size(814, 207)
        Me.RcvDataGridView.TabIndex = 10
        Me.RcvDataGridView.TabStop = False
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "TRS_DATE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colInvoice
        '
        Me.colInvoice.DataPropertyName = "TRS_INVOICE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colInvoice.DefaultCellStyle = DataGridViewCellStyle3
        Me.colInvoice.HeaderText = "Invocie #"
        Me.colInvoice.Name = "colInvoice"
        Me.colInvoice.ReadOnly = True
        '
        'colCode
        '
        Me.colCode.DataPropertyName = "TRS_CODE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCode.DefaultCellStyle = DataGridViewCellStyle4
        Me.colCode.HeaderText = "Inventory Code"
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "TRS_DESCRIPTION"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 300
        '
        'colRetailer
        '
        Me.colRetailer.DataPropertyName = "TRS_RETAILER"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colRetailer.DefaultCellStyle = DataGridViewCellStyle6
        Me.colRetailer.HeaderText = "Retailer"
        Me.colRetailer.Name = "colRetailer"
        Me.colRetailer.ReadOnly = True
        '
        'colOldQty
        '
        Me.colOldQty.DataPropertyName = "TRS_QTY_BF"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colOldQty.DefaultCellStyle = DataGridViewCellStyle7
        Me.colOldQty.HeaderText = "Prev. Quantity"
        Me.colOldQty.Name = "colOldQty"
        Me.colOldQty.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.DataPropertyName = "TRS_QTY_RCV"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colQty.DefaultCellStyle = DataGridViewCellStyle8
        Me.colQty.HeaderText = "Qty Received"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colQtyIssu
        '
        Me.colQtyIssu.DataPropertyName = "TRS_QTY_ISSU"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colQtyIssu.DefaultCellStyle = DataGridViewCellStyle9
        Me.colQtyIssu.HeaderText = "Qty Issued"
        Me.colQtyIssu.Name = "colQtyIssu"
        Me.colQtyIssu.ReadOnly = True
        '
        'colQtyUpd
        '
        Me.colQtyUpd.DataPropertyName = "TRS_QTY_UPD"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colQtyUpd.DefaultCellStyle = DataGridViewCellStyle10
        Me.colQtyUpd.HeaderText = "Upd. Quantity"
        Me.colQtyUpd.Name = "colQtyUpd"
        Me.colQtyUpd.ReadOnly = True
        '
        'colPchPrice
        '
        Me.colPchPrice.DataPropertyName = "TRS_PCH_PRICE"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.colPchPrice.DefaultCellStyle = DataGridViewCellStyle11
        Me.colPchPrice.HeaderText = "Purchase Price"
        Me.colPchPrice.Name = "colPchPrice"
        Me.colPchPrice.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.DataPropertyName = "TRS_STATUS"
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colStatus.DefaultCellStyle = DataGridViewCellStyle12
        Me.colStatus.HeaderText = "Remarks"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'frmInvTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 483)
        Me.Name = "frmInvTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Transactions"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.InvTranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvTranDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.RcvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssuedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCode As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InvDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InvTranBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvTranDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtRcvQty As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUpdateRcv As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IssuedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RcvDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtRetailer As System.Windows.Forms.TextBox
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRetailer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOldQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQtyIssu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQtyUpd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPchPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
