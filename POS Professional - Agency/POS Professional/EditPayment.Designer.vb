<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPayment))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNetTotal = New System.Windows.Forms.TextBox
        Me.lblRefund = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblCash = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.cmdPay = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.txtDueAmount = New System.Windows.Forms.TextBox
        Me.txtCash = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Payment"
        '
        'txtNetTotal
        '
        Me.txtNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNetTotal.Location = New System.Drawing.Point(192, 13)
        Me.txtNetTotal.Multiline = True
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.ReadOnly = True
        Me.txtNetTotal.Size = New System.Drawing.Size(174, 38)
        Me.txtNetTotal.TabIndex = 0
        Me.txtNetTotal.Text = "0"
        Me.txtNetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRefund
        '
        Me.lblRefund.AutoSize = True
        Me.lblRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefund.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRefund.Location = New System.Drawing.Point(6, 150)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(144, 29)
        Me.lblRefund.TabIndex = 18
        Me.lblRefund.Text = "Due Amount"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(6, 62)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(106, 29)
        Me.lblDiscount.TabIndex = 17
        Me.lblDiscount.Text = "Discount"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCash.Location = New System.Drawing.Point(6, 18)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(112, 29)
        Me.lblCash.TabIndex = 16
        Me.lblCash.Text = "Net Total"
        '
        'txtDiscount
        '
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDiscount.Location = New System.Drawing.Point(192, 57)
        Me.txtDiscount.Multiline = True
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(174, 38)
        Me.txtDiscount.TabIndex = 1
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdPay
        '
        Me.cmdPay.Enabled = False
        Me.cmdPay.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPay.Location = New System.Drawing.Point(12, 191)
        Me.cmdPay.Name = "cmdPay"
        Me.cmdPay.Size = New System.Drawing.Size(174, 59)
        Me.cmdPay.TabIndex = 4
        Me.cmdPay.Text = "&Save (F9)"
        Me.cmdPay.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(192, 191)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(174, 59)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Back (F10)"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtDueAmount
        '
        Me.txtDueAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDueAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueAmount.ForeColor = System.Drawing.Color.Red
        Me.txtDueAmount.Location = New System.Drawing.Point(192, 145)
        Me.txtDueAmount.Multiline = True
        Me.txtDueAmount.Name = "txtDueAmount"
        Me.txtDueAmount.ReadOnly = True
        Me.txtDueAmount.Size = New System.Drawing.Size(174, 38)
        Me.txtDueAmount.TabIndex = 3
        Me.txtDueAmount.TabStop = False
        Me.txtDueAmount.Text = "0"
        Me.txtDueAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCash
        '
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCash.Location = New System.Drawing.Point(192, 101)
        Me.txtCash.MaxLength = 6
        Me.txtCash.Multiline = True
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(174, 38)
        Me.txtCash.TabIndex = 2
        Me.txtCash.Text = "0"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EditPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(377, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNetTotal)
        Me.Controls.Add(Me.lblRefund)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.cmdPay)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtDueAmount)
        Me.Controls.Add(Me.txtCash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNetTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblRefund As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents cmdPay As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtDueAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
End Class
