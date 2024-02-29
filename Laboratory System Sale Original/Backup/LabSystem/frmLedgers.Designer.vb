<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLedgers
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblOpnCredit = New System.Windows.Forms.Label
        Me.dgCredit = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrDataSet = New System.Data.DataSet
        Me.lblOpnCr = New System.Windows.Forms.Label
        Me.lblOpnDr = New System.Windows.Forms.Label
        Me.lblCloDr = New System.Windows.Forms.Label
        Me.lblOpnDebit = New System.Windows.Forms.Label
        Me.CrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrDataSet = New System.Data.DataSet
        Me.dgDebit = New System.Windows.Forms.DataGridView
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTranID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.Button
        Me.ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripComboBox = New System.Windows.Forms.ToolStripComboBox
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.ToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ButtonToolStrip = New System.Windows.Forms.ToolStrip
        Me.lblCloCr = New System.Windows.Forms.Label
        Me.txtCloCr = New System.Windows.Forms.Label
        Me.txtCloDr = New System.Windows.Forms.Label
        Me.lblCredit = New System.Windows.Forms.Label
        Me.lblDebit = New System.Windows.Forms.Label
        Me.lblAccTitle = New System.Windows.Forms.Label
        Me.DrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.cmdPrint = New System.Windows.Forms.Button
        CType(Me.dgCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonToolStrip.SuspendLayout()
        CType(Me.DrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOpnCredit
        '
        Me.lblOpnCredit.BackColor = System.Drawing.Color.Gainsboro
        Me.lblOpnCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOpnCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpnCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOpnCredit.Location = New System.Drawing.Point(985, 82)
        Me.lblOpnCredit.Name = "lblOpnCredit"
        Me.lblOpnCredit.Size = New System.Drawing.Size(90, 23)
        Me.lblOpnCredit.TabIndex = 37
        Me.lblOpnCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpnCredit.Visible = False
        '
        'dgCredit
        '
        Me.dgCredit.AllowUserToAddRows = False
        Me.dgCredit.AllowUserToDeleteRows = False
        Me.dgCredit.AutoGenerateColumns = False
        Me.dgCredit.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCredit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCredit.ColumnHeadersVisible = False
        Me.dgCredit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.dgCredit.DataSource = Me.CrDataSet
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCredit.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgCredit.Location = New System.Drawing.Point(556, 113)
        Me.dgCredit.Name = "dgCredit"
        Me.dgCredit.ReadOnly = True
        Me.dgCredit.RowHeadersVisible = False
        Me.dgCredit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCredit.Size = New System.Drawing.Size(535, 439)
        Me.dgCredit.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LEDG_DATE"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LEDG_TRAN_ID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "TranID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LEDG_NARRATION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 340
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LEDG_CREDIT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Credit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 57
        '
        'CrDataSet
        '
        Me.CrDataSet.DataSetName = "NewDataSet"
        '
        'lblOpnCr
        '
        Me.lblOpnCr.AutoSize = True
        Me.lblOpnCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpnCr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpnCr.Location = New System.Drawing.Point(797, 85)
        Me.lblOpnCr.Name = "lblOpnCr"
        Me.lblOpnCr.Size = New System.Drawing.Size(182, 16)
        Me.lblOpnCr.TabIndex = 36
        Me.lblOpnCr.Text = "Balance Brought Forward"
        Me.lblOpnCr.Visible = False
        '
        'lblOpnDr
        '
        Me.lblOpnDr.AutoSize = True
        Me.lblOpnDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpnDr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpnDr.Location = New System.Drawing.Point(245, 85)
        Me.lblOpnDr.Name = "lblOpnDr"
        Me.lblOpnDr.Size = New System.Drawing.Size(182, 16)
        Me.lblOpnDr.TabIndex = 35
        Me.lblOpnDr.Text = "Balance Brought Forward"
        Me.lblOpnDr.Visible = False
        '
        'lblCloDr
        '
        Me.lblCloDr.AutoSize = True
        Me.lblCloDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloDr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCloDr.Location = New System.Drawing.Point(306, 624)
        Me.lblCloDr.Name = "lblCloDr"
        Me.lblCloDr.Size = New System.Drawing.Size(121, 16)
        Me.lblCloDr.TabIndex = 34
        Me.lblCloDr.Text = "Closing Balance"
        Me.lblCloDr.Visible = False
        '
        'lblOpnDebit
        '
        Me.lblOpnDebit.BackColor = System.Drawing.Color.Gainsboro
        Me.lblOpnDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOpnDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpnDebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOpnDebit.Location = New System.Drawing.Point(433, 82)
        Me.lblOpnDebit.Name = "lblOpnDebit"
        Me.lblOpnDebit.Size = New System.Drawing.Size(90, 23)
        Me.lblOpnDebit.TabIndex = 33
        Me.lblOpnDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpnDebit.Visible = False
        '
        'CrBindingSource
        '
        Me.CrBindingSource.DataSource = Me.DrDataSet
        Me.CrBindingSource.Position = 0
        '
        'DrDataSet
        '
        Me.DrDataSet.DataSetName = "NewDataSet"
        '
        'dgDebit
        '
        Me.dgDebit.AllowUserToAddRows = False
        Me.dgDebit.AllowUserToDeleteRows = False
        Me.dgDebit.AutoGenerateColumns = False
        Me.dgDebit.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDebit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDebit.ColumnHeadersVisible = False
        Me.dgDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colTranID, Me.colDesc, Me.colDebit})
        Me.dgDebit.DataSource = Me.DrDataSet
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDebit.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgDebit.Location = New System.Drawing.Point(3, 113)
        Me.dgDebit.Name = "dgDebit"
        Me.dgDebit.ReadOnly = True
        Me.dgDebit.RowHeadersVisible = False
        Me.dgDebit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDebit.Size = New System.Drawing.Size(535, 439)
        Me.dgDebit.TabIndex = 0
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "LEDG_DATE"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.Width = 70
        '
        'colTranID
        '
        Me.colTranID.DataPropertyName = "LEDG_TRAN_ID"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTranID.DefaultCellStyle = DataGridViewCellStyle6
        Me.colTranID.HeaderText = "TranID"
        Me.colTranID.Name = "colTranID"
        Me.colTranID.ReadOnly = True
        Me.colTranID.Width = 50
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "LEDG_NARRATION"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 340
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "LEDG_DEBIT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle7
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        Me.colDebit.Width = 57
        '
        'ToolStripButton
        '
        Me.ToolStripButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton.Image = Global.Business_Solutions.My.Resources.Resources.PrintPreviewHS
        Me.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton.Name = "ToolStripButton"
        Me.ToolStripButton.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButton.Text = "&View Entries"
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.exit_64
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Location = New System.Drawing.Point(12, 593)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(43, 42)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'ToolStripSeparator
        '
        Me.ToolStripSeparator.Name = "ToolStripSeparator"
        Me.ToolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripComboBox
        '
        Me.ToolStripComboBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripComboBox.Name = "ToolStripComboBox"
        Me.ToolStripComboBox.Size = New System.Drawing.Size(270, 25)
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Location = New System.Drawing.Point(516, 2)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(184, 20)
        Me.dtpFrom.TabIndex = 3
        '
        'ToolStripLabel
        '
        Me.ToolStripLabel.BackColor = System.Drawing.SystemColors.Menu
        Me.ToolStripLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel.Name = "ToolStripLabel"
        Me.ToolStripLabel.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripLabel.Text = "Select Account"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel1.Text = "From"
        '
        'ButtonToolStrip
        '
        Me.ButtonToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel, Me.ToolStripComboBox, Me.ToolStripSeparator, Me.ToolStripButton, Me.ToolStripSeparator1, Me.ToolStripLabel1})
        Me.ButtonToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ButtonToolStrip.Name = "ButtonToolStrip"
        Me.ButtonToolStrip.Size = New System.Drawing.Size(1094, 25)
        Me.ButtonToolStrip.TabIndex = 21
        Me.ButtonToolStrip.Text = "ToolStrip1"
        '
        'lblCloCr
        '
        Me.lblCloCr.AutoSize = True
        Me.lblCloCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloCr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCloCr.Location = New System.Drawing.Point(858, 624)
        Me.lblCloCr.Name = "lblCloCr"
        Me.lblCloCr.Size = New System.Drawing.Size(121, 16)
        Me.lblCloCr.TabIndex = 29
        Me.lblCloCr.Text = "Closing Balance"
        Me.lblCloCr.Visible = False
        '
        'txtCloCr
        '
        Me.txtCloCr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCloCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloCr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCloCr.Location = New System.Drawing.Point(985, 621)
        Me.txtCloCr.Name = "txtCloCr"
        Me.txtCloCr.Size = New System.Drawing.Size(90, 23)
        Me.txtCloCr.TabIndex = 28
        Me.txtCloCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCloCr.Visible = False
        '
        'txtCloDr
        '
        Me.txtCloDr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCloDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloDr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCloDr.Location = New System.Drawing.Point(433, 621)
        Me.txtCloDr.Name = "txtCloDr"
        Me.txtCloDr.Size = New System.Drawing.Size(90, 23)
        Me.txtCloDr.TabIndex = 27
        Me.txtCloDr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCloDr.Visible = False
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCredit.Location = New System.Drawing.Point(985, 582)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(90, 23)
        Me.lblCredit.TabIndex = 26
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDebit
        '
        Me.lblDebit.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDebit.Location = New System.Drawing.Point(433, 582)
        Me.lblDebit.Name = "lblDebit"
        Me.lblDebit.Size = New System.Drawing.Size(90, 23)
        Me.lblDebit.TabIndex = 25
        Me.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccTitle
        '
        Me.lblAccTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccTitle.Location = New System.Drawing.Point(295, 39)
        Me.lblAccTitle.Name = "lblAccTitle"
        Me.lblAccTitle.Size = New System.Drawing.Size(504, 24)
        Me.lblAccTitle.TabIndex = 24
        Me.lblAccTitle.Text = "ACCOUNT TITLE"
        Me.lblAccTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DrBindingSource
        '
        Me.DrBindingSource.DataSource = Me.DrDataSet
        Me.DrBindingSource.Position = 0
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Location = New System.Drawing.Point(706, 2)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(184, 20)
        Me.dtpTo.TabIndex = 4
        '
        'cmdPrint
        '
        Me.cmdPrint.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.Printer_64
        Me.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Location = New System.Drawing.Point(61, 593)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(43, 42)
        Me.cmdPrint.TabIndex = 38
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'frmLedgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1094, 651)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.lblOpnCredit)
        Me.Controls.Add(Me.dgCredit)
        Me.Controls.Add(Me.lblOpnCr)
        Me.Controls.Add(Me.lblOpnDr)
        Me.Controls.Add(Me.lblCloDr)
        Me.Controls.Add(Me.lblOpnDebit)
        Me.Controls.Add(Me.dgDebit)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.ButtonToolStrip)
        Me.Controls.Add(Me.lblCloCr)
        Me.Controls.Add(Me.txtCloCr)
        Me.Controls.Add(Me.txtCloDr)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblDebit)
        Me.Controls.Add(Me.lblAccTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLedgers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "T Ledgers"
        CType(Me.dgCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonToolStrip.ResumeLayout(False)
        Me.ButtonToolStrip.PerformLayout()
        CType(Me.DrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOpnCredit As System.Windows.Forms.Label
    Friend WithEvents dgCredit As System.Windows.Forms.DataGridView
    Friend WithEvents CrDataSet As System.Data.DataSet
    Friend WithEvents lblOpnCr As System.Windows.Forms.Label
    Friend WithEvents lblOpnDr As System.Windows.Forms.Label
    Friend WithEvents lblCloDr As System.Windows.Forms.Label
    Friend WithEvents lblOpnDebit As System.Windows.Forms.Label
    Friend WithEvents CrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DrDataSet As System.Data.DataSet
    Friend WithEvents dgDebit As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ButtonToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents lblCloCr As System.Windows.Forms.Label
    Friend WithEvents txtCloCr As System.Windows.Forms.Label
    Friend WithEvents txtCloDr As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblDebit As System.Windows.Forms.Label
    Friend WithEvents lblAccTitle As System.Windows.Forms.Label
    Friend WithEvents DrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTranID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
End Class
