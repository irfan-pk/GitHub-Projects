<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblRecovery = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTotalDisc = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblTotalCredit = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTotalPrice = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvDashBoard = New System.Windows.Forms.DataGridView
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDashBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvDashBoard)
        Me.SplitContainer1.Size = New System.Drawing.Size(1217, 576)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel4.Controls.Add(Me.lblRecovery)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(3, 180)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(304, 57)
        Me.Panel4.TabIndex = 61
        '
        'lblRecovery
        '
        Me.lblRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecovery.ForeColor = System.Drawing.Color.White
        Me.lblRecovery.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRecovery.Location = New System.Drawing.Point(140, 5)
        Me.lblRecovery.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRecovery.Name = "lblRecovery"
        Me.lblRecovery.Size = New System.Drawing.Size(158, 46)
        Me.lblRecovery.TabIndex = 130
        Me.lblRecovery.Text = "0"
        Me.lblRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 35)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Recovery"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel3.Controls.Add(Me.lblTotalDisc)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(3, 121)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(304, 57)
        Me.Panel3.TabIndex = 60
        '
        'lblTotalDisc
        '
        Me.lblTotalDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDisc.ForeColor = System.Drawing.Color.White
        Me.lblTotalDisc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalDisc.Location = New System.Drawing.Point(140, 5)
        Me.lblTotalDisc.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalDisc.Name = "lblTotalDisc"
        Me.lblTotalDisc.Size = New System.Drawing.Size(158, 46)
        Me.lblTotalDisc.TabIndex = 130
        Me.lblTotalDisc.Text = "0"
        Me.lblTotalDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 35)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Discount"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.lblTotalCredit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 57)
        Me.Panel1.TabIndex = 59
        '
        'lblTotalCredit
        '
        Me.lblTotalCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCredit.ForeColor = System.Drawing.Color.White
        Me.lblTotalCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalCredit.Location = New System.Drawing.Point(140, 5)
        Me.lblTotalCredit.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalCredit.Name = "lblTotalCredit"
        Me.lblTotalCredit.Size = New System.Drawing.Size(158, 46)
        Me.lblTotalCredit.TabIndex = 130
        Me.lblTotalCredit.Text = "0"
        Me.lblTotalCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 35)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Credit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Controls.Add(Me.lblTotalPrice)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 57)
        Me.Panel2.TabIndex = 58
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.White
        Me.lblTotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalPrice.Location = New System.Drawing.Point(140, 10)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(158, 34)
        Me.lblTotalPrice.TabIndex = 130
        Me.lblTotalPrice.Text = "0"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 35)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Cash"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDashBoard
        '
        Me.dgvDashBoard.AllowUserToAddRows = False
        Me.dgvDashBoard.AllowUserToDeleteRows = False
        Me.dgvDashBoard.AutoGenerateColumns = False
        Me.dgvDashBoard.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dgvDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDashBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDashBoard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDashBoard.ColumnHeadersHeight = 48
        Me.dgvDashBoard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvDashBoard.DataSource = Me.BindingSource1
        Me.dgvDashBoard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDashBoard.EnableHeadersVisualStyles = False
        Me.dgvDashBoard.Location = New System.Drawing.Point(0, 0)
        Me.dgvDashBoard.MultiSelect = False
        Me.dgvDashBoard.Name = "dgvDashBoard"
        Me.dgvDashBoard.ReadOnly = True
        Me.dgvDashBoard.RowHeadersVisible = False
        Me.dgvDashBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDashBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDashBoard.Size = New System.Drawing.Size(902, 574)
        Me.dgvDashBoard.TabIndex = 0
        '
        'Timer1
        '
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "saleid"
        Me.Column1.HeaderText = "Invoice #"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "salestatus"
        Me.Column2.HeaderText = "Type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "customername"
        Me.Column3.HeaderText = "Customer"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "salegross"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "salediscount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Discount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "saletotal"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "Net"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "salepaid"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "Paid"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "salecredit"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column8.HeaderText = "Credit"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "status"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column9.HeaderText = "Status"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 576)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvDashBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalCredit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalDisc As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblRecovery As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvDashBoard As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
