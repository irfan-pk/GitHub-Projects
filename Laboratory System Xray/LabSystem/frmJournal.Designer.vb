<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournal
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTransaction = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbAccHead = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.JournalGrid = New System.Windows.Forms.DataGridView
        Me.TransactionDataSet = New System.Data.DataSet
        Me.TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPost = New System.Windows.Forms.Button
        Me.cmdGetTrans = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.HdrPicBox = New System.Windows.Forms.PictureBox
        Me.txtTranID = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCredit = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDebit = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtTotCredit = New System.Windows.Forms.TextBox
        Me.txtTotDebit = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.colGEN_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTrans = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HdrPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transaction Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTransaction
        '
        Me.dtpTransaction.Location = New System.Drawing.Point(129, 62)
        Me.dtpTransaction.Name = "dtpTransaction"
        Me.dtpTransaction.Size = New System.Drawing.Size(200, 20)
        Me.dtpTransaction.TabIndex = 0
        Me.dtpTransaction.Value = New Date(2010, 12, 19, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Account Head"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbAccHead
        '
        Me.cmbAccHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbAccHead.FormattingEnabled = True
        Me.cmbAccHead.Location = New System.Drawing.Point(129, 92)
        Me.cmbAccHead.Name = "cmbAccHead"
        Me.cmbAccHead.Size = New System.Drawing.Size(269, 21)
        Me.cmbAccHead.TabIndex = 1
        Me.cmbAccHead.Text = "Select Account Head"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(414, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Trans #"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.JournalGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colGEN_DATE, Me.colTrans, Me.colAccount, Me.colDesc, Me.colLP, Me.colDebit, Me.colCredit})
        Me.JournalGrid.DataSource = Me.TransactionDataSet
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.NullValue = Nothing
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.JournalGrid.DefaultCellStyle = DataGridViewCellStyle9
        Me.JournalGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.JournalGrid.Location = New System.Drawing.Point(15, 197)
        Me.JournalGrid.Name = "JournalGrid"
        Me.JournalGrid.ReadOnly = True
        Me.JournalGrid.RowHeadersVisible = False
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.JournalGrid.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.JournalGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.JournalGrid.ShowCellToolTips = False
        Me.JournalGrid.Size = New System.Drawing.Size(1000, 364)
        Me.JournalGrid.TabIndex = 6
        Me.JournalGrid.TabStop = False
        '
        'TransactionDataSet
        '
        Me.TransactionDataSet.DataSetName = "NewDataSet"
        '
        'TransBindingSource
        '
        Me.TransBindingSource.DataSource = Me.TransactionDataSet
        Me.TransBindingSource.Position = 0
        '
        'cmdClose
        '
        Me.cmdClose.AutoSize = True
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.application_remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(927, 13)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 25)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "&Close Entry"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPost
        '
        Me.cmdPost.Enabled = False
        Me.cmdPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPost.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.cmdPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPost.Location = New System.Drawing.Point(829, 13)
        Me.cmdPost.Name = "cmdPost"
        Me.cmdPost.Size = New System.Drawing.Size(92, 25)
        Me.cmdPost.TabIndex = 9
        Me.cmdPost.Text = "&Post Entries"
        Me.cmdPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPost.UseVisualStyleBackColor = True
        '
        'cmdGetTrans
        '
        Me.cmdGetTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGetTrans.Image = Global.Business_Solutions.My.Resources.Resources.folder_add1
        Me.cmdGetTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGetTrans.Location = New System.Drawing.Point(731, 13)
        Me.cmdGetTrans.Name = "cmdGetTrans"
        Me.cmdGetTrans.Size = New System.Drawing.Size(92, 25)
        Me.cmdGetTrans.TabIndex = 8
        Me.cmdGetTrans.Text = "&Get Entries"
        Me.cmdGetTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGetTrans.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.database_remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(633, 13)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(92, 25)
        Me.cmdDelete.TabIndex = 7
        Me.cmdDelete.Text = "&Delete Entry"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'HdrPicBox
        '
        Me.HdrPicBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.HdrPicBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.HdrPicBox.Location = New System.Drawing.Point(0, 0)
        Me.HdrPicBox.Name = "HdrPicBox"
        Me.HdrPicBox.Size = New System.Drawing.Size(1037, 50)
        Me.HdrPicBox.TabIndex = 0
        Me.HdrPicBox.TabStop = False
        '
        'txtTranID
        '
        Me.txtTranID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTranID.Location = New System.Drawing.Point(473, 92)
        Me.txtTranID.Name = "txtTranID"
        Me.txtTranID.Size = New System.Drawing.Size(73, 21)
        Me.txtTranID.TabIndex = 2
        Me.txtTranID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(871, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Credit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCredit
        '
        Me.txtCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.ForeColor = System.Drawing.Color.Maroon
        Me.txtCredit.Location = New System.Drawing.Point(873, 158)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(121, 21)
        Me.txtCredit.TabIndex = 5
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(746, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Debit"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDebit
        '
        Me.txtDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebit.ForeColor = System.Drawing.Color.Maroon
        Me.txtDebit.Location = New System.Drawing.Point(748, 158)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(121, 21)
        Me.txtDebit.TabIndex = 4
        Me.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Description"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Blue
        Me.txtDescription.Location = New System.Drawing.Point(16, 158)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(726, 21)
        Me.txtDescription.TabIndex = 3
        '
        'txtTotCredit
        '
        Me.txtTotCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotCredit.Location = New System.Drawing.Point(902, 562)
        Me.txtTotCredit.Name = "txtTotCredit"
        Me.txtTotCredit.Size = New System.Drawing.Size(93, 20)
        Me.txtTotCredit.TabIndex = 27
        Me.txtTotCredit.TabStop = False
        Me.txtTotCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotDebit
        '
        Me.txtTotDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotDebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotDebit.Location = New System.Drawing.Point(809, 562)
        Me.txtTotDebit.Name = "txtTotDebit"
        Me.txtTotDebit.Size = New System.Drawing.Size(93, 20)
        Me.txtTotDebit.TabIndex = 28
        Me.txtTotDebit.TabStop = False
        Me.txtTotDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(757, 564)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Totals"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colGEN_DATE
        '
        Me.colGEN_DATE.DataPropertyName = "GEN_DATE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colGEN_DATE.DefaultCellStyle = DataGridViewCellStyle2
        Me.colGEN_DATE.HeaderText = "Date"
        Me.colGEN_DATE.Name = "colGEN_DATE"
        Me.colGEN_DATE.ReadOnly = True
        Me.colGEN_DATE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colGEN_DATE.Width = 80
        '
        'colTrans
        '
        Me.colTrans.DataPropertyName = "GEN_TRAN_ID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTrans.DefaultCellStyle = DataGridViewCellStyle3
        Me.colTrans.HeaderText = "Trans #"
        Me.colTrans.Name = "colTrans"
        Me.colTrans.ReadOnly = True
        Me.colTrans.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTrans.Width = 51
        '
        'colAccount
        '
        Me.colAccount.DataPropertyName = "GEN_DESCRIPTION"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender
        Me.colAccount.DefaultCellStyle = DataGridViewCellStyle4
        Me.colAccount.HeaderText = "Account Description"
        Me.colAccount.Name = "colAccount"
        Me.colAccount.ReadOnly = True
        Me.colAccount.Width = 210
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "GEN_NARRATION"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDesc.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDesc.Width = 422
        '
        'colLP
        '
        Me.colLP.DataPropertyName = "GEN_LP"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLP.DefaultCellStyle = DataGridViewCellStyle6
        Me.colLP.HeaderText = "LP"
        Me.colLP.Name = "colLP"
        Me.colLP.ReadOnly = True
        Me.colLP.Width = 30
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "GEN_DEBIT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightBlue
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle7
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        Me.colDebit.Width = 93
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "GEN_CREDIT"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle8.NullValue = Nothing
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle8
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        Me.colCredit.Width = 93
        '
        'frmJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1037, 606)
        Me.Controls.Add(Me.txtTotDebit)
        Me.Controls.Add(Me.txtTotCredit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtTranID)
        Me.Controls.Add(Me.JournalGrid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbAccHead)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTransaction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPost)
        Me.Controls.Add(Me.cmdGetTrans)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.HdrPicBox)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmJournal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HdrPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HdrPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdGetTrans As System.Windows.Forms.Button
    Friend WithEvents cmdPost As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTransaction As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAccHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents JournalGrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtTranID As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDebit As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtTotCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtTotDebit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionDataSet As System.Data.DataSet
    Friend WithEvents colGEN_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
