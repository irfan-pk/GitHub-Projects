<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoustomerLedger
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoustomerLedger))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdMin = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTran = New System.Windows.Forms.TextBox
        Me.TranDate = New System.Windows.Forms.DateTimePicker
        Me.PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentDataSet = New System.Data.DataSet
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCredit = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PaymentDataGridView = New System.Windows.Forms.DataGridView
        Me.colTranID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOpnBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtVoucher = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtDebit = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmdMin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 49)
        Me.Panel1.TabIndex = 15
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
        Me.cmdMin.Location = New System.Drawing.Point(914, 6)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(29, 34)
        Me.cmdMin.TabIndex = 99
        Me.cmdMin.TabStop = False
        Me.cmdMin.Text = "----"
        Me.cmdMin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(355, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Customer General Journal"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.POS_Professional.My.Resources.Resources.database_accept_24
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(707, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 36)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&Get B/L"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = Global.POS_Professional.My.Resources.Resources.exit_24
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(810, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(97, 36)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "&Back"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(163, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Transaction Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(394, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Transaction #"
        '
        'txtTran
        '
        Me.txtTran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTran.Location = New System.Drawing.Point(397, 29)
        Me.txtTran.Name = "txtTran"
        Me.txtTran.ReadOnly = True
        Me.txtTran.Size = New System.Drawing.Size(115, 22)
        Me.txtTran.TabIndex = 2
        Me.txtTran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TranDate
        '
        Me.TranDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TranDate.Location = New System.Drawing.Point(166, 30)
        Me.TranDate.Name = "TranDate"
        Me.TranDate.Size = New System.Drawing.Size(215, 21)
        Me.TranDate.TabIndex = 1
        '
        'PayBindingSource
        '
        Me.PayBindingSource.DataSource = Me.PaymentDataSet
        Me.PayBindingSource.Position = 0
        '
        'PaymentDataSet
        '
        Me.PaymentDataSet.DataSetName = "PayDataSet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(812, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Credit Amount"
        '
        'txtCredit
        '
        Me.txtCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.Location = New System.Drawing.Point(815, 77)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(115, 22)
        Me.txtCredit.TabIndex = 8
        Me.txtCredit.Text = "0"
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(163, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(166, 77)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(491, 22)
        Me.txtDescription.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(20, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Customer ID"
        '
        'PaymentDataGridView
        '
        Me.PaymentDataGridView.AllowUserToAddRows = False
        Me.PaymentDataGridView.AllowUserToDeleteRows = False
        Me.PaymentDataGridView.AutoGenerateColumns = False
        Me.PaymentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PaymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PaymentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTranID, Me.colDate, Me.colID, Me.colDesc, Me.colOpnBal, Me.colDebit, Me.colCredit, Me.colBalance})
        Me.PaymentDataGridView.DataSource = Me.PayBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentDataGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.PaymentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaymentDataGridView.Location = New System.Drawing.Point(0, 175)
        Me.PaymentDataGridView.MultiSelect = False
        Me.PaymentDataGridView.Name = "PaymentDataGridView"
        Me.PaymentDataGridView.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.PaymentDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PaymentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.PaymentDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.PaymentDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.PaymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PaymentDataGridView.Size = New System.Drawing.Size(951, 296)
        Me.PaymentDataGridView.TabIndex = 17
        Me.PaymentDataGridView.TabStop = False
        '
        'colTranID
        '
        Me.colTranID.DataPropertyName = "CUST_TR_ID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTranID.DefaultCellStyle = DataGridViewCellStyle2
        Me.colTranID.HeaderText = "Trans #"
        Me.colTranID.Name = "colTranID"
        Me.colTranID.ReadOnly = True
        Me.colTranID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTranID.Width = 80
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "CUST_TR_DT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDate.HeaderText = "Trans Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDate.Width = 80
        '
        'colID
        '
        Me.colID.DataPropertyName = "CUST_CODE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colID.DefaultCellStyle = DataGridViewCellStyle4
        Me.colID.HeaderText = "Supplier ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colID.Width = 80
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "CUST_DESC"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDesc.Width = 288
        '
        'colOpnBal
        '
        Me.colOpnBal.DataPropertyName = "Cust_opn_bal"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colOpnBal.DefaultCellStyle = DataGridViewCellStyle5
        Me.colOpnBal.HeaderText = "Opening B/L"
        Me.colOpnBal.Name = "colOpnBal"
        Me.colOpnBal.ReadOnly = True
        Me.colOpnBal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "Cust_debit"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle6
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        Me.colDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "Cust_Credit"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle7
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        Me.colCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colBalance
        '
        Me.colBalance.DataPropertyName = "Cust_Balance"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colBalance.DefaultCellStyle = DataGridViewCellStyle8
        Me.colBalance.HeaderText = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.ReadOnly = True
        Me.colBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtVoucher)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtTran)
        Me.Panel2.Controls.Add(Me.TranDate)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCredit)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtDescription)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.lblPhone)
        Me.Panel2.Controls.Add(Me.txtDebit)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(951, 126)
        Me.Panel2.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(671, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(20, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Doc #"
        '
        'txtVoucher
        '
        Me.txtVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucher.Location = New System.Drawing.Point(20, 77)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(131, 22)
        Me.txtVoucher.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(674, 29)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(256, 22)
        Me.txtAddress.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POS_Professional.My.Resources.Resources.search18
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(123, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 20)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(20, 29)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(101, 22)
        Me.txtID.TabIndex = 0
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Yellow
        Me.lblPhone.Location = New System.Drawing.Point(671, 61)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(83, 13)
        Me.lblPhone.TabIndex = 27
        Me.lblPhone.Text = "Debit Amount"
        '
        'txtDebit
        '
        Me.txtDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebit.Location = New System.Drawing.Point(674, 77)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(126, 22)
        Me.txtDebit.TabIndex = 7
        Me.txtDebit.Text = "0"
        Me.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Yellow
        Me.lblName.Location = New System.Drawing.Point(529, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(95, 13)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "Customer Name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(532, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(125, 22)
        Me.txtName.TabIndex = 3
        '
        'CoustomerLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 471)
        Me.Controls.Add(Me.PaymentDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "CoustomerLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Journal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTran As System.Windows.Forms.TextBox
    Friend WithEvents TranDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentDataSet As System.Data.DataSet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PaymentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtDebit As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents colTranID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOpnBal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVoucher As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
