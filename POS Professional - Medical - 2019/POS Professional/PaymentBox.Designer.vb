<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentBox))
        Me.txtCash = New System.Windows.Forms.TextBox
        Me.txtDues = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPay = New System.Windows.Forms.Button
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.lblCash = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblRefund = New System.Windows.Forms.Label
        Me.txtNetTotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtGross = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtCash
        '
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCash.Location = New System.Drawing.Point(192, 140)
        Me.txtCash.MaxLength = 6
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(174, 44)
        Me.txtCash.TabIndex = 2
        Me.txtCash.Text = "0"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDues
        '
        Me.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDues.Enabled = False
        Me.txtDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDues.ForeColor = System.Drawing.Color.Red
        Me.txtDues.Location = New System.Drawing.Point(192, 184)
        Me.txtDues.Name = "txtDues"
        Me.txtDues.Size = New System.Drawing.Size(174, 44)
        Me.txtDues.TabIndex = 3
        Me.txtDues.Text = "0"
        Me.txtDues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(192, 239)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(174, 59)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Back (F10)"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPay
        '
        Me.cmdPay.Enabled = False
        Me.cmdPay.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPay.Location = New System.Drawing.Point(12, 239)
        Me.cmdPay.Name = "cmdPay"
        Me.cmdPay.Size = New System.Drawing.Size(174, 59)
        Me.cmdPay.TabIndex = 4
        Me.cmdPay.Text = "&Paid (F9)"
        Me.cmdPay.UseVisualStyleBackColor = True
        '
        'txtDiscount
        '
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDiscount.Location = New System.Drawing.Point(192, 52)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(174, 44)
        Me.txtDiscount.TabIndex = 1
        Me.txtDiscount.TabStop = False
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCash.Location = New System.Drawing.Point(6, 105)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(112, 29)
        Me.lblCash.TabIndex = 5
        Me.lblCash.Text = "Net Total"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(6, 61)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(106, 29)
        Me.lblDiscount.TabIndex = 6
        Me.lblDiscount.Text = "Discount"
        '
        'lblRefund
        '
        Me.lblRefund.AutoSize = True
        Me.lblRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefund.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRefund.Location = New System.Drawing.Point(6, 193)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(160, 29)
        Me.lblRefund.TabIndex = 7
        Me.lblRefund.Text = "Receiveables"
        '
        'txtNetTotal
        '
        Me.txtNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetTotal.Enabled = False
        Me.txtNetTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNetTotal.Location = New System.Drawing.Point(192, 96)
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.Size = New System.Drawing.Size(174, 44)
        Me.txtNetTotal.TabIndex = 0
        Me.txtNetTotal.TabStop = False
        Me.txtNetTotal.Text = "0"
        Me.txtNetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Payment"
        '
        'txtGross
        '
        Me.txtGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGross.Enabled = False
        Me.txtGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGross.Location = New System.Drawing.Point(192, 8)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(174, 44)
        Me.txtGross.TabIndex = 0
        Me.txtGross.TabStop = False
        Me.txtGross.Text = "0"
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sale Total"
        '
        'PaymentBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(377, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNetTotal)
        Me.Controls.Add(Me.lblRefund)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.cmdPay)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtDues)
        Me.Controls.Add(Me.txtCash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "PaymentBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtDues As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPay As System.Windows.Forms.Button
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblRefund As System.Windows.Forms.Label
    Friend WithEvents txtNetTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
