<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Journal
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
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdMin = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTran = New System.Windows.Forms.TextBox
        Me.TranDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCredit = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtDebit = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.PaymentDataGridView = New System.Windows.Forms.DataGridView
        Me.colTranID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOpnBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentDataSet = New System.Data.DataSet
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmdMin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 49)
        Me.Panel1.TabIndex = 0
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
        Me.cmdMin.Location = New System.Drawing.Point(908, 7)
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
        Me.Label5.Size = New System.Drawing.Size(374, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Wholesaler General Journal"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmdClose)
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
        Me.Panel2.Size = New System.Drawing.Size(942, 126)
        Me.Panel2.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(143, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Transaction Date"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Image = Global.POS_System.My.Resources.Resources._1480382931_Log_Out2
        Me.cmdClose.Location = New System.Drawing.Point(815, 26)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 71)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(374, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Transaction #"
        '
        'txtTran
        '
        Me.txtTran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTran.Location = New System.Drawing.Point(377, 30)
        Me.txtTran.Name = "txtTran"
        Me.txtTran.ReadOnly = True
        Me.txtTran.Size = New System.Drawing.Size(115, 20)
        Me.txtTran.TabIndex = 2
        Me.txtTran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TranDate
        '
        Me.TranDate.Location = New System.Drawing.Point(146, 30)
        Me.TranDate.Name = "TranDate"
        Me.TranDate.Size = New System.Drawing.Size(215, 20)
        Me.TranDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(640, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Credit Amount"
        '
        'txtCredit
        '
        Me.txtCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredit.Location = New System.Drawing.Point(643, 77)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(125, 20)
        Me.txtCredit.TabIndex = 6
        Me.txtCredit.Text = "00"
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(13, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(16, 77)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(476, 20)
        Me.txtDescription.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Wholesaler ID"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(16, 30)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(85, 20)
        Me.txtID.TabIndex = 0
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Yellow
        Me.lblPhone.Location = New System.Drawing.Point(509, 61)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(83, 13)
        Me.lblPhone.TabIndex = 27
        Me.lblPhone.Text = "Debit Amount"
        '
        'txtDebit
        '
        Me.txtDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDebit.Location = New System.Drawing.Point(512, 77)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(125, 20)
        Me.txtDebit.TabIndex = 5
        Me.txtDebit.Text = "00"
        Me.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Yellow
        Me.lblName.Location = New System.Drawing.Point(509, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 13)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "Wholesaler Name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(512, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(256, 20)
        Me.txtName.TabIndex = 3
        '
        'PaymentDataGridView
        '
        Me.PaymentDataGridView.AllowUserToAddRows = False
        Me.PaymentDataGridView.AllowUserToDeleteRows = False
        Me.PaymentDataGridView.AllowUserToResizeColumns = False
        Me.PaymentDataGridView.AllowUserToResizeRows = False
        Me.PaymentDataGridView.AutoGenerateColumns = False
        Me.PaymentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PaymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PaymentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle45
        Me.PaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTranID, Me.colDate, Me.colID, Me.colDesc, Me.colOpnBal, Me.colDebit, Me.colCredit, Me.colBalance})
        Me.PaymentDataGridView.DataSource = Me.PayBindingSource
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentDataGridView.DefaultCellStyle = DataGridViewCellStyle53
        Me.PaymentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaymentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.PaymentDataGridView.Location = New System.Drawing.Point(0, 175)
        Me.PaymentDataGridView.MultiSelect = False
        Me.PaymentDataGridView.Name = "PaymentDataGridView"
        Me.PaymentDataGridView.ReadOnly = True
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle54.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle54
        Me.PaymentDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PaymentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle55
        Me.PaymentDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.PaymentDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.PaymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PaymentDataGridView.Size = New System.Drawing.Size(942, 296)
        Me.PaymentDataGridView.TabIndex = 14
        Me.PaymentDataGridView.TabStop = False
        '
        'colTranID
        '
        Me.colTranID.DataPropertyName = "SUPL_TR_ID"
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTranID.DefaultCellStyle = DataGridViewCellStyle46
        Me.colTranID.HeaderText = "Trans #"
        Me.colTranID.Name = "colTranID"
        Me.colTranID.ReadOnly = True
        Me.colTranID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTranID.Width = 80
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "SUPL_TR_DT"
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle47
        Me.colDate.HeaderText = "Trans Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDate.Width = 80
        '
        'colID
        '
        Me.colID.DataPropertyName = "SUPL_CODE"
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colID.DefaultCellStyle = DataGridViewCellStyle48
        Me.colID.HeaderText = "Supplier ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colID.Width = 80
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "Supl_DESC"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDesc.Width = 288
        '
        'colOpnBal
        '
        Me.colOpnBal.DataPropertyName = "Supl_opn_bal"
        DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colOpnBal.DefaultCellStyle = DataGridViewCellStyle49
        Me.colOpnBal.HeaderText = "Opening B/L"
        Me.colOpnBal.Name = "colOpnBal"
        Me.colOpnBal.ReadOnly = True
        Me.colOpnBal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "Supl_debit"
        DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle50
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        Me.colDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "Supl_Credit"
        DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle51
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        Me.colCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colBalance
        '
        Me.colBalance.DataPropertyName = "Supl_Balance"
        DataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colBalance.DefaultCellStyle = DataGridViewCellStyle52
        Me.colBalance.HeaderText = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.ReadOnly = True
        Me.colBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POS_System.My.Resources.Resources.search18
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(103, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 20)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 471)
        Me.Controls.Add(Me.PaymentDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmJournal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Journal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtDebit As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents PaymentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PaymentDataSet As System.Data.DataSet
    Friend WithEvents PayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTran As System.Windows.Forms.TextBox
    Friend WithEvents TranDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents colTranID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOpnBal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
