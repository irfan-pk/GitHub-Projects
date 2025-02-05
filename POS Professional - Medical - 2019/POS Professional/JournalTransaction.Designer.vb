<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JournalTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JournalTransaction))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblDrAccount = New System.Windows.Forms.Label
        Me.txtDrAccount = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblInvoiceDate = New System.Windows.Forms.Label
        Me.lblInvoice = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDrAmount = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCrAccount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblCrAccount = New System.Windows.Forms.Label
        Me.txtCrAmount = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(994, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GENERAL TRANSACTION ENTRY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTime.Location = New System.Drawing.Point(13, 9)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(52, 16)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "00 : 00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtCrAmount)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblCrAccount)
        Me.GroupBox1.Controls.Add(Me.txtCrAccount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtDrAmount)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblDrAccount)
        Me.GroupBox1.Controls.Add(Me.txtDrAccount)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lblInvoiceDate)
        Me.GroupBox1.Controls.Add(Me.lblInvoice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 433)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Location = New System.Drawing.Point(136, 110)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(542, 22)
        Me.txtDescription.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(120, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 16)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(41, 113)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 177
        Me.Label6.Text = "Description"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDrAccount
        '
        Me.lblDrAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDrAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDrAccount.Location = New System.Drawing.Point(282, 85)
        Me.lblDrAccount.Name = "lblDrAccount"
        Me.lblDrAccount.Size = New System.Drawing.Size(396, 21)
        Me.lblDrAccount.TabIndex = 175
        Me.lblDrAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDrAccount
        '
        Me.txtDrAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrAccount.Location = New System.Drawing.Point(136, 84)
        Me.txtDrAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDrAccount.Name = "txtDrAccount"
        Me.txtDrAccount.Size = New System.Drawing.Size(142, 22)
        Me.txtDrAccount.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(120, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(12, 16)
        Me.Label17.TabIndex = 174
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(41, 87)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 16)
        Me.Label18.TabIndex = 173
        Me.Label18.Text = "Dr. Account"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceDate.ForeColor = System.Drawing.Color.Black
        Me.lblInvoiceDate.Location = New System.Drawing.Point(136, 59)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(142, 21)
        Me.lblInvoiceDate.TabIndex = 170
        Me.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInvoice
        '
        Me.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.ForeColor = System.Drawing.Color.Black
        Me.lblInvoice.Location = New System.Drawing.Point(136, 34)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(142, 21)
        Me.lblInvoice.TabIndex = 171
        Me.lblInvoice.Text = "0"
        Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(118, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(118, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 16)
        Me.Label11.TabIndex = 168
        Me.Label11.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Voucher Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(49, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Voucher #"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDrAmount
        '
        Me.txtDrAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrAmount.Location = New System.Drawing.Point(136, 136)
        Me.txtDrAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDrAmount.Name = "txtDrAmount"
        Me.txtDrAmount.Size = New System.Drawing.Size(142, 22)
        Me.txtDrAmount.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(120, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 16)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(29, 139)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Debit Amount"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCrAccount
        '
        Me.txtCrAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCrAccount.Location = New System.Drawing.Point(136, 162)
        Me.txtCrAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCrAccount.Name = "txtCrAccount"
        Me.txtCrAccount.Size = New System.Drawing.Size(142, 22)
        Me.txtCrAccount.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(120, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 16)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(42, 165)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 183
        Me.Label10.Text = "Cr. Account"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCrAccount
        '
        Me.lblCrAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCrAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCrAccount.Location = New System.Drawing.Point(282, 163)
        Me.lblCrAccount.Name = "lblCrAccount"
        Me.lblCrAccount.Size = New System.Drawing.Size(396, 21)
        Me.lblCrAccount.TabIndex = 185
        Me.lblCrAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCrAmount
        '
        Me.txtCrAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCrAmount.Location = New System.Drawing.Point(136, 188)
        Me.txtCrAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCrAmount.Name = "txtCrAmount"
        Me.txtCrAmount.Size = New System.Drawing.Size(142, 22)
        Me.txtCrAmount.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(120, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 16)
        Me.Label13.TabIndex = 188
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(29, 191)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 16)
        Me.Label14.TabIndex = 187
        Me.Label14.Text = "Credit Amount"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(940, 184)
        Me.DataGridView1.TabIndex = 189
        '
        'JournalTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(994, 495)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "JournalTransaction"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Transaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDrAccount As System.Windows.Forms.Label
    Friend WithEvents txtDrAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceDate As System.Windows.Forms.Label
    Friend WithEvents lblInvoice As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDrAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCrAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblCrAccount As System.Windows.Forms.Label
    Friend WithEvents txtCrAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
