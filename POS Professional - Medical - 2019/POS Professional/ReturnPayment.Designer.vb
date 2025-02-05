<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnPayment))
        Me.txtNetTotal = New System.Windows.Forms.TextBox
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblCash = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.cmdPay = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCash = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtNetTotal
        '
        Me.txtNetTotal.Enabled = False
        Me.txtNetTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNetTotal.Location = New System.Drawing.Point(189, 3)
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.Size = New System.Drawing.Size(174, 44)
        Me.txtNetTotal.TabIndex = 10
        Me.txtNetTotal.TabStop = False
        Me.txtNetTotal.Text = "0"
        Me.txtNetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(3, 56)
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
        Me.lblCash.Location = New System.Drawing.Point(3, 12)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(112, 29)
        Me.lblCash.TabIndex = 16
        Me.lblCash.Text = "Net Total"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Green
        Me.txtDiscount.Location = New System.Drawing.Point(189, 47)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(174, 44)
        Me.txtDiscount.TabIndex = 11
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
        Me.cmdPay.Location = New System.Drawing.Point(9, 147)
        Me.cmdPay.Name = "cmdPay"
        Me.cmdPay.Size = New System.Drawing.Size(174, 59)
        Me.cmdPay.TabIndex = 14
        Me.cmdPay.Text = "&Save (F9)"
        Me.cmdPay.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(189, 147)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(174, 59)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "&Back (F10)"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Return Payment"
        '
        'txtCash
        '
        Me.txtCash.Enabled = False
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCash.Location = New System.Drawing.Point(189, 91)
        Me.txtCash.MaxLength = 9
        Me.txtCash.Name = "txtCash"
        Me.txtCash.ReadOnly = True
        Me.txtCash.Size = New System.Drawing.Size(174, 44)
        Me.txtCash.TabIndex = 12
        Me.txtCash.Text = "0"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ReturnPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(370, 214)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNetTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.cmdPay)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtCash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ReturnPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReturnPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNetTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents cmdPay As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
End Class
