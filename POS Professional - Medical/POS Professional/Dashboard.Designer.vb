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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDashBoard = New System.Windows.Forms.DataGridView
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
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblPendingCash = New System.Windows.Forms.Label
        Me.lblPurchase = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDashBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
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
        Me.dgvDashBoard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column1, Me.Column2, Me.Column11, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvDashBoard.DataSource = Me.BindingSource1
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDashBoard.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDashBoard.EnableHeadersVisualStyles = False
        Me.dgvDashBoard.Location = New System.Drawing.Point(325, 2)
        Me.dgvDashBoard.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDashBoard.MultiSelect = False
        Me.dgvDashBoard.Name = "dgvDashBoard"
        Me.dgvDashBoard.ReadOnly = True
        Me.dgvDashBoard.RowHeadersVisible = False
        Me.dgvDashBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDashBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDashBoard.Size = New System.Drawing.Size(1002, 571)
        Me.dgvDashBoard.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel4.Controls.Add(Me.lblRecovery)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(1, 179)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(322, 56)
        Me.Panel4.TabIndex = 65
        '
        'lblRecovery
        '
        Me.lblRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecovery.ForeColor = System.Drawing.Color.White
        Me.lblRecovery.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRecovery.Location = New System.Drawing.Point(165, 7)
        Me.lblRecovery.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRecovery.Name = "lblRecovery"
        Me.lblRecovery.Size = New System.Drawing.Size(155, 43)
        Me.lblRecovery.TabIndex = 130
        Me.lblRecovery.Text = "Rs. 0"
        Me.lblRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 43)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Recovery"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel3.Controls.Add(Me.lblTotalDisc)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(1, 120)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 56)
        Me.Panel3.TabIndex = 64
        '
        'lblTotalDisc
        '
        Me.lblTotalDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDisc.ForeColor = System.Drawing.Color.White
        Me.lblTotalDisc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalDisc.Location = New System.Drawing.Point(165, 7)
        Me.lblTotalDisc.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalDisc.Name = "lblTotalDisc"
        Me.lblTotalDisc.Size = New System.Drawing.Size(155, 43)
        Me.lblTotalDisc.TabIndex = 130
        Me.lblTotalDisc.Text = "Rs. 0"
        Me.lblTotalDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 43)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Discount"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.lblTotalCredit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(1, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 56)
        Me.Panel1.TabIndex = 63
        '
        'lblTotalCredit
        '
        Me.lblTotalCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCredit.ForeColor = System.Drawing.Color.White
        Me.lblTotalCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalCredit.Location = New System.Drawing.Point(165, 7)
        Me.lblTotalCredit.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalCredit.Name = "lblTotalCredit"
        Me.lblTotalCredit.Size = New System.Drawing.Size(155, 43)
        Me.lblTotalCredit.TabIndex = 131
        Me.lblTotalCredit.Text = "Rs. 0"
        Me.lblTotalCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 43)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Credit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Controls.Add(Me.lblTotalPrice)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(322, 56)
        Me.Panel2.TabIndex = 62
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.White
        Me.lblTotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalPrice.Location = New System.Drawing.Point(165, 6)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(155, 43)
        Me.lblTotalPrice.TabIndex = 130
        Me.lblTotalPrice.Text = "Rs. 0"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 43)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Cash"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.lblPendingCash)
        Me.Panel5.Location = New System.Drawing.Point(1, 238)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(322, 56)
        Me.Panel5.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 43)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Pending Cash"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPendingCash
        '
        Me.lblPendingCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingCash.ForeColor = System.Drawing.Color.White
        Me.lblPendingCash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPendingCash.Location = New System.Drawing.Point(165, 7)
        Me.lblPendingCash.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPendingCash.Name = "lblPendingCash"
        Me.lblPendingCash.Size = New System.Drawing.Size(155, 43)
        Me.lblPendingCash.TabIndex = 130
        Me.lblPendingCash.Text = "Rs. 0"
        Me.lblPendingCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPurchase
        '
        Me.lblPurchase.AutoSize = True
        Me.lblPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchase.ForeColor = System.Drawing.Color.Maroon
        Me.lblPurchase.Location = New System.Drawing.Point(13, 449)
        Me.lblPurchase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(172, 20)
        Me.lblPurchase.TabIndex = 154
        Me.lblPurchase.Text = "[ F1 ] EXIT TO MAIN"
        Me.lblPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(13, 479)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 20)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "[ F2 ] CASH INVOICE PAID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(13, 509)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 20)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "[ F3 ] CREDIT INVOICE PAID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(13, 539)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 20)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "[ F4 ] REFRESH DATA"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.DataPropertyName = "datecompleted"
        Me.Column10.HeaderText = "Date"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "saleid"
        Me.Column1.HeaderText = "Invoice #"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "salestatus"
        Me.Column2.HeaderText = "Type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column11.DataPropertyName = "customerid"
        Me.Column11.HeaderText = "Acc ID"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column3.DataPropertyName = "customername"
        Me.Column3.HeaderText = "Customer"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 89
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "salegross"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.DataPropertyName = "salediscount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Discount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.DataPropertyName = "saletotal"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "Net"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.DataPropertyName = "salepaid"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "Paid"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.DataPropertyName = "salecredit"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column8.HeaderText = "Credit"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.DataPropertyName = "status"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column9.HeaderText = "Status"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 574)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPurchase)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvDashBoard)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDashBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents dgvDashBoard As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblRecovery As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalDisc As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalCredit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPendingCash As System.Windows.Forms.Label
    Friend WithEvents lblPurchase As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
