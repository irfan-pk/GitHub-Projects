<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WholeSalerPayments
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WholeSalerPayments))
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOpnBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentDataSet = New System.Data.DataSet
        Me.PaymentDataGridView = New System.Windows.Forms.DataGridView
        Me.colTranID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FromDate = New System.Windows.Forms.DateTimePicker
        Me.cmdMin = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToDate = New System.Windows.Forms.DateTimePicker
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PayBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorFind = New System.Windows.Forms.ToolStripButton
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PayBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PayBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'colID
        '
        Me.colID.DataPropertyName = "SUPL_CODE"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colID.DefaultCellStyle = DataGridViewCellStyle1
        Me.colID.HeaderText = "Supplier ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colID.Width = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(6, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Transaction Date From"
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "Supl_Credit"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle2
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        Me.colCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "Supl_debit"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        Me.colDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colOpnBal
        '
        Me.colOpnBal.DataPropertyName = "Supl_opn_bal"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colOpnBal.DefaultCellStyle = DataGridViewCellStyle4
        Me.colOpnBal.HeaderText = "Opening B/L"
        Me.colOpnBal.Name = "colOpnBal"
        Me.colOpnBal.ReadOnly = True
        Me.colOpnBal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'PaymentDataSet
        '
        Me.PaymentDataSet.DataSetName = "PayDataSet"
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
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
        Me.PaymentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.PaymentDataGridView.Location = New System.Drawing.Point(0, 92)
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
        Me.PaymentDataGridView.Size = New System.Drawing.Size(942, 379)
        Me.PaymentDataGridView.TabIndex = 17
        Me.PaymentDataGridView.TabStop = False
        '
        'colTranID
        '
        Me.colTranID.DataPropertyName = "SUPL_TR_ID"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTranID.DefaultCellStyle = DataGridViewCellStyle6
        Me.colTranID.HeaderText = "Trans #"
        Me.colTranID.Name = "colTranID"
        Me.colTranID.ReadOnly = True
        Me.colTranID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTranID.Width = 80
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "SUPL_TR_DT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle7
        Me.colDate.HeaderText = "Trans Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDate.Width = 80
        '
        'colBalance
        '
        Me.colBalance.DataPropertyName = "Supl_Balance"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colBalance.DefaultCellStyle = DataGridViewCellStyle8
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
        'FromDate
        '
        Me.FromDate.Location = New System.Drawing.Point(148, 11)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(215, 20)
        Me.FromDate.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmdClose)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ToDate)
        Me.Panel2.Controls.Add(Me.cmdPreview)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.FromDate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(942, 43)
        Me.Panel2.TabIndex = 16
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Image = Global.POS_Professional.My.Resources.Resources.application_remove
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(809, 6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(72, 29)
        Me.cmdClose.TabIndex = 42
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(367, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "ToDate"
        '
        'ToDate
        '
        Me.ToDate.Location = New System.Drawing.Point(419, 11)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(215, 20)
        Me.ToDate.TabIndex = 40
        '
        'cmdPreview
        '
        Me.cmdPreview.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Image = Global.POS_Professional.My.Resources.Resources.Book_openHS1
        Me.cmdPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPreview.Location = New System.Drawing.Point(731, 6)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(72, 29)
        Me.cmdPreview.TabIndex = 39
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPreview.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "General Ledger"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PayBindingNavigator)
        Me.Panel1.Controls.Add(Me.cmdMin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 49)
        Me.Panel1.TabIndex = 15
        '
        'PayBindingNavigator
        '
        Me.PayBindingNavigator.AddNewItem = Nothing
        Me.PayBindingNavigator.BackColor = System.Drawing.SystemColors.Control
        Me.PayBindingNavigator.BindingSource = Me.PayBindingSource
        Me.PayBindingNavigator.CountItem = Nothing
        Me.PayBindingNavigator.DeleteItem = Nothing
        Me.PayBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PayBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorTextBox, Me.BindingNavigatorSeparator4, Me.BindingNavigatorFind})
        Me.PayBindingNavigator.Location = New System.Drawing.Point(419, 11)
        Me.PayBindingNavigator.MoveFirstItem = Nothing
        Me.PayBindingNavigator.MoveLastItem = Nothing
        Me.PayBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PayBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PayBindingNavigator.Name = "PayBindingNavigator"
        Me.PayBindingNavigator.PositionItem = Nothing
        Me.PayBindingNavigator.Size = New System.Drawing.Size(440, 25)
        Me.PayBindingNavigator.TabIndex = 100
        Me.PayBindingNavigator.Text = "BindingNavigator"
        Me.PayBindingNavigator.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.BackColor = System.Drawing.Color.PowderBlue
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
        Me.BindingNavigatorMoveNextItem.BackColor = System.Drawing.Color.PowderBlue
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
        'BindingNavigatorTextBox
        '
        Me.BindingNavigatorTextBox.Name = "BindingNavigatorTextBox"
        Me.BindingNavigatorTextBox.Size = New System.Drawing.Size(200, 25)
        Me.BindingNavigatorTextBox.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        Me.BindingNavigatorTextBox.ToolTipText = "Enter WholeSaler ID to Find"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'BindingNavigatorFind
        '
        Me.BindingNavigatorFind.BackColor = System.Drawing.Color.PowderBlue
        Me.BindingNavigatorFind.Image = Global.POS_Professional.My.Resources.Resources.search1
        Me.BindingNavigatorFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorFind.Name = "BindingNavigatorFind"
        Me.BindingNavigatorFind.Size = New System.Drawing.Size(106, 22)
        Me.BindingNavigatorFind.Text = "&Wholesaler List"
        Me.BindingNavigatorFind.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BindingNavigatorFind.ToolTipText = "Click to Find Product"
        '
        'WholeSalerPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 471)
        Me.Controls.Add(Me.PaymentDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WholeSalerPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Ledgers"
        CType(Me.PaymentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PayBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PayBindingNavigator.ResumeLayout(False)
        Me.PayBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOpnBal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataSet As System.Data.DataSet
    Friend WithEvents PaymentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents colTranID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PayBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
