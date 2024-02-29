<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewJournal
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpTransaction = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotCredit = New System.Windows.Forms.TextBox
        Me.TransactionDataSet = New System.Data.DataSet
        Me.Label7 = New System.Windows.Forms.Label
        Me.TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotDebit = New System.Windows.Forms.TextBox
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.HdrPicBox = New System.Windows.Forms.PictureBox
        Me.JournalGrid = New Business_Solutions.GroupDataGridView
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubAcc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.TransactionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HdrPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpToDate
        '
        Me.dtpToDate.Location = New System.Drawing.Point(737, 8)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpToDate.TabIndex = 1
        Me.dtpToDate.Value = New Date(2010, 12, 19, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.dtpToDate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpTransaction)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 34)
        Me.Panel1.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(677, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "To Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTransaction
        '
        Me.dtpTransaction.Location = New System.Drawing.Point(468, 8)
        Me.dtpTransaction.Name = "dtpTransaction"
        Me.dtpTransaction.Size = New System.Drawing.Size(200, 20)
        Me.dtpTransaction.TabIndex = 0
        Me.dtpTransaction.Value = New Date(2010, 12, 19, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Transaction From"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotCredit
        '
        Me.txtTotCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotCredit.Location = New System.Drawing.Point(828, 579)
        Me.txtTotCredit.Name = "txtTotCredit"
        Me.txtTotCredit.Size = New System.Drawing.Size(93, 20)
        Me.txtTotCredit.TabIndex = 59
        Me.txtTotCredit.TabStop = False
        Me.txtTotCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TransactionDataSet
        '
        Me.TransactionDataSet.DataSetName = "NewDataSet"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(676, 581)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Totals"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TransBindingSource
        '
        Me.TransBindingSource.DataSource = Me.TransactionDataSet
        Me.TransBindingSource.Position = 0
        '
        'txtTotDebit
        '
        Me.txtTotDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotDebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotDebit.Location = New System.Drawing.Point(736, 579)
        Me.txtTotDebit.Name = "txtTotDebit"
        Me.txtTotDebit.Size = New System.Drawing.Size(93, 20)
        Me.txtTotDebit.TabIndex = 60
        Me.txtTotDebit.TabStop = False
        Me.txtTotDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdView
        '
        Me.cmdView.BackColor = System.Drawing.Color.Silver
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.ForeColor = System.Drawing.Color.White
        Me.cmdView.Image = Global.Business_Solutions.My.Resources.Resources.PrintPreviewHS
        Me.cmdView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdView.Location = New System.Drawing.Point(627, 12)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(103, 25)
        Me.cmdView.TabIndex = 2
        Me.cmdView.Text = "&View"
        Me.cmdView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.cmdView, "View General Journal Book Entries")
        Me.cmdView.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.AutoSize = True
        Me.cmdClose.BackColor = System.Drawing.Color.Silver
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.application_remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(839, 12)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 25)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.cmdClose, "Close current window")
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.Silver
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.database_remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(733, 12)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(103, 25)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "&Roll Back"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.cmdDelete, "Roll Back General Journal Entries")
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'HdrPicBox
        '
        Me.HdrPicBox.BackColor = System.Drawing.Color.Silver
        Me.HdrPicBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.HdrPicBox.Location = New System.Drawing.Point(0, 0)
        Me.HdrPicBox.Name = "HdrPicBox"
        Me.HdrPicBox.Size = New System.Drawing.Size(947, 50)
        Me.HdrPicBox.TabIndex = 55
        Me.HdrPicBox.TabStop = False
        '
        'JournalGrid
        '
        Me.JournalGrid.AllowUserToAddRows = False
        Me.JournalGrid.AllowUserToDeleteRows = False
        Me.JournalGrid.AllowUserToResizeColumns = False
        Me.JournalGrid.AllowUserToResizeRows = False
        Me.JournalGrid.AutoGenerateColumns = False
        Me.JournalGrid.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.JournalGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.JournalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JournalGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colTran, Me.colAccId, Me.colVoucher, Me.colSubAcc, Me.colDesc, Me.colLP, Me.colDebit, Me.colCredit})
        Me.JournalGrid.DataSource = Me.TransactionDataSet
        Me.JournalGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JournalGrid.Location = New System.Drawing.Point(0, 84)
        Me.JournalGrid.Name = "JournalGrid"
        Me.JournalGrid.ReadOnly = True
        Me.JournalGrid.RowHeadersVisible = False
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JournalGrid.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.JournalGrid.Size = New System.Drawing.Size(947, 520)
        Me.JournalGrid.TabIndex = 6
        Me.JournalGrid.TabStop = False
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "GEN_DATE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.Width = 73
        '
        'colTran
        '
        Me.colTran.DataPropertyName = "GEN_TRAN_ID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.colTran.DefaultCellStyle = DataGridViewCellStyle3
        Me.colTran.HeaderText = "Trans #"
        Me.colTran.Name = "colTran"
        Me.colTran.ReadOnly = True
        Me.colTran.Width = 70
        '
        'colAccId
        '
        Me.colAccId.DataPropertyName = "GEN_ACC_ID"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colAccId.DefaultCellStyle = DataGridViewCellStyle4
        Me.colAccId.HeaderText = "Acc. ID"
        Me.colAccId.Name = "colAccId"
        Me.colAccId.ReadOnly = True
        Me.colAccId.Width = 63
        '
        'colVoucher
        '
        Me.colVoucher.DataPropertyName = "GEN_VOUCHER_NO"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.colVoucher.DefaultCellStyle = DataGridViewCellStyle5
        Me.colVoucher.HeaderText = "Doc #"
        Me.colVoucher.Name = "colVoucher"
        Me.colVoucher.ReadOnly = True
        Me.colVoucher.Width = 80
        '
        'colSubAcc
        '
        Me.colSubAcc.DataPropertyName = "GEN_SUB_ACC"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colSubAcc.DefaultCellStyle = DataGridViewCellStyle6
        Me.colSubAcc.HeaderText = "Head"
        Me.colSubAcc.Name = "colSubAcc"
        Me.colSubAcc.ReadOnly = True
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "GEN_NARRATION"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDesc.DefaultCellStyle = DataGridViewCellStyle7
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 307
        '
        'colLP
        '
        Me.colLP.DataPropertyName = "GEN_LP"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.colLP.DefaultCellStyle = DataGridViewCellStyle8
        Me.colLP.HeaderText = "LP"
        Me.colLP.Name = "colLP"
        Me.colLP.ReadOnly = True
        Me.colLP.Width = 50
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "GEN_DEBIT"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle9
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "GEN_CREDIT"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle10
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DarkGray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(7, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 31)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "General Journanl"
        '
        'frmViewJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(947, 604)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.JournalGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.txtTotCredit)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.HdrPicBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotDebit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmViewJournal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TransactionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HdrPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTransaction As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents txtTotCredit As System.Windows.Forms.TextBox
    Friend WithEvents TransactionDataSet As System.Data.DataSet
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents HdrPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtTotDebit As System.Windows.Forms.TextBox
    Friend WithEvents JournalGrid As Business_Solutions.GroupDataGridView
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubAcc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
