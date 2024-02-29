<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewTransactions
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewTransactions))
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpTransaction = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotCredit = New System.Windows.Forms.TextBox
        Me.JournalGrid = New System.Windows.Forms.DataGridView
        Me.colTrans = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransactionDataSet = New System.Data.DataSet
        Me.Label7 = New System.Windows.Forms.Label
        Me.TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotDebit = New System.Windows.Forms.TextBox
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.HdrPicBox = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HdrPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpToDate
        '
        Me.dtpToDate.Location = New System.Drawing.Point(737, 8)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpToDate.TabIndex = 51
        Me.dtpToDate.Value = New Date(2010, 12, 19, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
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
        Me.Label3.Location = New System.Drawing.Point(674, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "To Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTransaction
        '
        Me.dtpTransaction.Location = New System.Drawing.Point(468, 8)
        Me.dtpTransaction.Name = "dtpTransaction"
        Me.dtpTransaction.Size = New System.Drawing.Size(200, 20)
        Me.dtpTransaction.TabIndex = 30
        Me.dtpTransaction.Value = New Date(2010, 12, 19, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Transaction Date"
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
        'JournalGrid
        '
        Me.JournalGrid.AllowUserToAddRows = False
        Me.JournalGrid.AllowUserToDeleteRows = False
        Me.JournalGrid.AutoGenerateColumns = False
        Me.JournalGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.JournalGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JournalGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.JournalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.JournalGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTrans, Me.colAccount, Me.colDesc, Me.colLP, Me.colDebit, Me.colCredit})
        Me.JournalGrid.DataSource = Me.TransactionDataSet
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.NullValue = Nothing
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.JournalGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.JournalGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.JournalGrid.Location = New System.Drawing.Point(0, 88)
        Me.JournalGrid.Name = "JournalGrid"
        Me.JournalGrid.ReadOnly = True
        Me.JournalGrid.RowHeadersVisible = False
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.JournalGrid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.JournalGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.JournalGrid.ShowCellToolTips = False
        Me.JournalGrid.Size = New System.Drawing.Size(946, 482)
        Me.JournalGrid.TabIndex = 56
        Me.JournalGrid.TabStop = False
        '
        'colTrans
        '
        Me.colTrans.DataPropertyName = "LEDG_TRAN_ID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTrans.DefaultCellStyle = DataGridViewCellStyle2
        Me.colTrans.HeaderText = "Trans #"
        Me.colTrans.Name = "colTrans"
        Me.colTrans.ReadOnly = True
        Me.colTrans.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTrans.Width = 51
        '
        'colAccount
        '
        Me.colAccount.DataPropertyName = "LEDG_DESCRIPTION"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        Me.colAccount.DefaultCellStyle = DataGridViewCellStyle3
        Me.colAccount.HeaderText = "Account Description"
        Me.colAccount.Name = "colAccount"
        Me.colAccount.ReadOnly = True
        Me.colAccount.Width = 210
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "LEDG_NARRATION"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 443
        '
        'colLP
        '
        Me.colLP.DataPropertyName = "LEDG_LP"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLP.DefaultCellStyle = DataGridViewCellStyle4
        Me.colLP.HeaderText = "LP"
        Me.colLP.Name = "colLP"
        Me.colLP.ReadOnly = True
        Me.colLP.Width = 30
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "LEDG_DEBIT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        Me.colDebit.Width = 93
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "LEDG_CREDIT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle6.NullValue = Nothing
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle6
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        Me.colCredit.Width = 93
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
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdView.Image = Global.Business_Solutions.My.Resources.Resources.PrintPreviewHS
        Me.cmdView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdView.Location = New System.Drawing.Point(647, 15)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(92, 25)
        Me.cmdView.TabIndex = 62
        Me.cmdView.Text = "&View"
        Me.cmdView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.AutoSize = True
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.application_remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(843, 15)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 25)
        Me.cmdClose.TabIndex = 58
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.database_remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(745, 15)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(92, 25)
        Me.cmdDelete.TabIndex = 57
        Me.cmdDelete.Text = "&Roll Back"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'HdrPicBox
        '
        Me.HdrPicBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.HdrPicBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.HdrPicBox.Location = New System.Drawing.Point(0, 0)
        Me.HdrPicBox.Name = "HdrPicBox"
        Me.HdrPicBox.Size = New System.Drawing.Size(947, 50)
        Me.HdrPicBox.TabIndex = 55
        Me.HdrPicBox.TabStop = False
        '
        'frmViewTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(947, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.txtTotCredit)
        Me.Controls.Add(Me.JournalGrid)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.HdrPicBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotDebit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmViewTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HdrPicBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents JournalGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TransactionDataSet As System.Data.DataSet
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents HdrPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtTotDebit As System.Windows.Forms.TextBox
    Friend WithEvents colTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
