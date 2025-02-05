<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashBook
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashBook))
        Me.Label1 = New System.Windows.Forms.Label
        Me.panel2 = New System.Windows.Forms.Panel
        Me.label6 = New System.Windows.Forms.Label
        Me.lblCashInHand = New System.Windows.Forms.Label
        Me.panel4 = New System.Windows.Forms.Panel
        Me.lblCredit = New System.Windows.Forms.Label
        Me.lblDebit = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DgvDebit = New System.Windows.Forms.DataGridView
        Me.D1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DgvCredit = New System.Windows.Forms.DataGridView
        Me.dataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.label8 = New System.Windows.Forms.Label
        Me.lblOpening = New System.Windows.Forms.Label
        Me.dateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.panel2.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.DgvDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1248, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CASH BOOK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.label6)
        Me.panel2.Controls.Add(Me.lblCashInHand)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 671)
        Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1248, 43)
        Me.panel2.TabIndex = 2
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(340, 10)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(107, 20)
        Me.label6.TabIndex = 132
        Me.label6.Text = "Cash In Hand"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCashInHand
        '
        Me.lblCashInHand.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblCashInHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashInHand.ForeColor = System.Drawing.Color.White
        Me.lblCashInHand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCashInHand.Location = New System.Drawing.Point(484, 6)
        Me.lblCashInHand.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCashInHand.Name = "lblCashInHand"
        Me.lblCashInHand.Size = New System.Drawing.Size(135, 29)
        Me.lblCashInHand.TabIndex = 4
        Me.lblCashInHand.Text = "0"
        Me.lblCashInHand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.lblCredit)
        Me.panel4.Controls.Add(Me.lblDebit)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel4.Location = New System.Drawing.Point(0, 627)
        Me.panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(1248, 44)
        Me.panel4.TabIndex = 4
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.ForeColor = System.Drawing.Color.White
        Me.lblCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCredit.Location = New System.Drawing.Point(1110, 8)
        Me.lblCredit.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(135, 29)
        Me.lblCredit.TabIndex = 3
        Me.lblCredit.Text = "0"
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDebit
        '
        Me.lblDebit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebit.ForeColor = System.Drawing.Color.White
        Me.lblDebit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDebit.Location = New System.Drawing.Point(486, 8)
        Me.lblDebit.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDebit.Name = "lblDebit"
        Me.lblDebit.Size = New System.Drawing.Size(135, 29)
        Me.lblDebit.TabIndex = 2
        Me.lblDebit.Text = "0"
        Me.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.label3)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 40)
        Me.Panel1.TabIndex = 5
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(622, 0)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(626, 40)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Credit"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(0, 0)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(624, 40)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Debit"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 91)
        Me.splitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.DgvDebit)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.DgvCredit)
        Me.splitContainer1.Size = New System.Drawing.Size(1248, 536)
        Me.splitContainer1.SplitterDistance = 621
        Me.splitContainer1.SplitterWidth = 1
        Me.splitContainer1.TabIndex = 6
        '
        'DgvDebit
        '
        Me.DgvDebit.AllowUserToAddRows = False
        Me.DgvDebit.AllowUserToDeleteRows = False
        Me.DgvDebit.AllowUserToResizeColumns = False
        Me.DgvDebit.AllowUserToResizeRows = False
        Me.DgvDebit.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvDebit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDebit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDebit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDebit.ColumnHeadersHeight = 40
        Me.DgvDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D1, Me.D2, Me.D3, Me.D4})
        Me.DgvDebit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDebit.EnableHeadersVisualStyles = False
        Me.DgvDebit.Location = New System.Drawing.Point(0, 0)
        Me.DgvDebit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvDebit.MultiSelect = False
        Me.DgvDebit.Name = "DgvDebit"
        Me.DgvDebit.ReadOnly = True
        Me.DgvDebit.RowHeadersVisible = False
        Me.DgvDebit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDebit.Size = New System.Drawing.Size(621, 536)
        Me.DgvDebit.TabIndex = 12
        Me.DgvDebit.TabStop = False
        '
        'D1
        '
        Me.D1.DataPropertyName = "ledg_date"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.D1.DefaultCellStyle = DataGridViewCellStyle2
        Me.D1.HeaderText = "Date"
        Me.D1.Name = "D1"
        Me.D1.ReadOnly = True
        '
        'D2
        '
        Me.D2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.D2.DataPropertyName = "ledg_narration"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.D2.DefaultCellStyle = DataGridViewCellStyle3
        Me.D2.HeaderText = "Particular"
        Me.D2.Name = "D2"
        Me.D2.ReadOnly = True
        '
        'D3
        '
        Me.D3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.D3.DataPropertyName = "ledg_voucher_no"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.D3.DefaultCellStyle = DataGridViewCellStyle4
        Me.D3.HeaderText = "VNo."
        Me.D3.Name = "D3"
        Me.D3.ReadOnly = True
        Me.D3.Width = 62
        '
        'D4
        '
        Me.D4.DataPropertyName = "ledg_debit"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.D4.DefaultCellStyle = DataGridViewCellStyle5
        Me.D4.HeaderText = "Amount (Rs.)"
        Me.D4.Name = "D4"
        Me.D4.ReadOnly = True
        '
        'DgvCredit
        '
        Me.DgvCredit.AllowUserToAddRows = False
        Me.DgvCredit.AllowUserToDeleteRows = False
        Me.DgvCredit.AllowUserToResizeColumns = False
        Me.DgvCredit.AllowUserToResizeRows = False
        Me.DgvCredit.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvCredit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCredit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCredit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvCredit.ColumnHeadersHeight = 40
        Me.DgvCredit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataGridViewTextBoxColumn1, Me.dataGridViewTextBoxColumn2, Me.dataGridViewTextBoxColumn3, Me.dataGridViewTextBoxColumn4})
        Me.DgvCredit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCredit.EnableHeadersVisualStyles = False
        Me.DgvCredit.Location = New System.Drawing.Point(0, 0)
        Me.DgvCredit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvCredit.MultiSelect = False
        Me.DgvCredit.Name = "DgvCredit"
        Me.DgvCredit.ReadOnly = True
        Me.DgvCredit.RowHeadersVisible = False
        Me.DgvCredit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCredit.Size = New System.Drawing.Size(626, 536)
        Me.DgvCredit.TabIndex = 12
        Me.DgvCredit.TabStop = False
        '
        'dataGridViewTextBoxColumn1
        '
        Me.dataGridViewTextBoxColumn1.DataPropertyName = "ledg_date"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.dataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1"
        Me.dataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dataGridViewTextBoxColumn2
        '
        Me.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dataGridViewTextBoxColumn2.DataPropertyName = "ledg_narration"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.dataGridViewTextBoxColumn2.HeaderText = "Particular"
        Me.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2"
        Me.dataGridViewTextBoxColumn2.ReadOnly = True
        '
        'dataGridViewTextBoxColumn3
        '
        Me.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataGridViewTextBoxColumn3.DataPropertyName = "ledg_voucher_no"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.dataGridViewTextBoxColumn3.HeaderText = "VNo."
        Me.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3"
        Me.dataGridViewTextBoxColumn3.ReadOnly = True
        Me.dataGridViewTextBoxColumn3.Width = 62
        '
        'dataGridViewTextBoxColumn4
        '
        Me.dataGridViewTextBoxColumn4.DataPropertyName = "ledg_credit"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.dataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.dataGridViewTextBoxColumn4.HeaderText = "Amount (Rs.)"
        Me.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4"
        Me.dataGridViewTextBoxColumn4.ReadOnly = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(12, 16)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(98, 18)
        Me.label8.TabIndex = 136
        Me.label8.Text = "Balance B/d"
        '
        'lblOpening
        '
        Me.lblOpening.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblOpening.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpening.ForeColor = System.Drawing.Color.White
        Me.lblOpening.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpening.Location = New System.Drawing.Point(114, 11)
        Me.lblOpening.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOpening.Name = "lblOpening"
        Me.lblOpening.Size = New System.Drawing.Size(188, 29)
        Me.lblOpening.TabIndex = 135
        Me.lblOpening.Text = "0"
        Me.lblOpening.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dateTimePicker
        '
        Me.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePicker.Location = New System.Drawing.Point(978, 13)
        Me.dateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.Size = New System.Drawing.Size(259, 24)
        Me.dateTimePicker.TabIndex = 1
        '
        'CashBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 714)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.lblOpening)
        Me.Controls.Add(Me.dateTimePicker)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel4)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "CashBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashBook"
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.DgvDebit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCredit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents lblCashInHand As System.Windows.Forms.Label
    Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents lblCredit As System.Windows.Forms.Label
    Private WithEvents lblDebit As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents lblOpening As System.Windows.Forms.Label
    Private WithEvents dateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents DgvDebit As System.Windows.Forms.DataGridView
    Private WithEvents D1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents D2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents D3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents D4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents DgvCredit As System.Windows.Forms.DataGridView
    Private WithEvents dataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
