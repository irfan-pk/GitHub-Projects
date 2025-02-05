<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillPayment))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSaleID = New System.Windows.Forms.TextBox
        Me.lblRefund = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.lblCash = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.txtPayment = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDues = New System.Windows.Forms.TextBox
        Me.cmdPaid = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Discount"
        '
        'txtSaleID
        '
        Me.txtSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSaleID.Location = New System.Drawing.Point(238, 12)
        Me.txtSaleID.Multiline = True
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.Size = New System.Drawing.Size(153, 38)
        Me.txtSaleID.TabIndex = 0
        Me.txtSaleID.TabStop = False
        Me.txtSaleID.Text = "0"
        Me.txtSaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRefund
        '
        Me.lblRefund.AutoSize = True
        Me.lblRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefund.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRefund.Location = New System.Drawing.Point(6, 149)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(176, 29)
        Me.lblRefund.TabIndex = 18
        Me.lblRefund.Text = "Cash Received"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(6, 61)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(112, 29)
        Me.lblDiscount.TabIndex = 17
        Me.lblDiscount.Text = "Net Total"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCash.Location = New System.Drawing.Point(6, 17)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(226, 29)
        Me.lblCash.TabIndex = 16
        Me.lblCash.Text = "Enter Sale Invoice #"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(238, 56)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(153, 38)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(217, 241)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(174, 59)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "&Back (F10)"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtPayment
        '
        Me.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.ForeColor = System.Drawing.Color.Red
        Me.txtPayment.Location = New System.Drawing.Point(238, 144)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(153, 38)
        Me.txtPayment.TabIndex = 4
        Me.txtPayment.Text = "0"
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDiscount.Location = New System.Drawing.Point(238, 100)
        Me.txtDiscount.MaxLength = 6
        Me.txtDiscount.Multiline = True
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(153, 38)
        Me.txtDiscount.TabIndex = 2
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Due Amount"
        '
        'txtDues
        '
        Me.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDues.Enabled = False
        Me.txtDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDues.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDues.Location = New System.Drawing.Point(238, 188)
        Me.txtDues.MaxLength = 6
        Me.txtDues.Multiline = True
        Me.txtDues.Name = "txtDues"
        Me.txtDues.ReadOnly = True
        Me.txtDues.Size = New System.Drawing.Size(153, 38)
        Me.txtDues.TabIndex = 3
        Me.txtDues.Text = "0"
        Me.txtDues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdPaid
        '
        Me.cmdPaid.Enabled = False
        Me.cmdPaid.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPaid.Location = New System.Drawing.Point(12, 241)
        Me.cmdPaid.Name = "cmdPaid"
        Me.cmdPaid.Size = New System.Drawing.Size(174, 59)
        Me.cmdPaid.TabIndex = 5
        Me.cmdPaid.Text = "&Paid (F9)"
        Me.cmdPaid.UseVisualStyleBackColor = True
        '
        'BillPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(404, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdPaid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDues)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSaleID)
        Me.Controls.Add(Me.lblRefund)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtDiscount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "BillPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Due Bill Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSaleID As System.Windows.Forms.TextBox
    Friend WithEvents lblRefund As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDues As System.Windows.Forms.TextBox
    Friend WithEvents cmdPaid As System.Windows.Forms.Button
End Class
