<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdjustPayment))
        Me.cmdPaid = New System.Windows.Forms.Button
        Me.txtCustomerID = New System.Windows.Forms.TextBox
        Me.lblRefund = New System.Windows.Forms.Label
        Me.lblCash = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.txtPayment = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAdjAmount = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdPaid
        '
        Me.cmdPaid.Enabled = False
        Me.cmdPaid.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPaid.Location = New System.Drawing.Point(13, 200)
        Me.cmdPaid.Name = "cmdPaid"
        Me.cmdPaid.Size = New System.Drawing.Size(174, 59)
        Me.cmdPaid.TabIndex = 2
        Me.cmdPaid.Text = "&Paid (F9)"
        Me.cmdPaid.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.ForeColor = System.Drawing.Color.Green
        Me.txtCustomerID.Location = New System.Drawing.Point(252, 12)
        Me.txtCustomerID.Multiline = True
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(139, 38)
        Me.txtCustomerID.TabIndex = 0
        Me.txtCustomerID.TabStop = False
        Me.txtCustomerID.Text = "0"
        Me.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRefund
        '
        Me.lblRefund.AutoSize = True
        Me.lblRefund.BackColor = System.Drawing.Color.Gray
        Me.lblRefund.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefund.ForeColor = System.Drawing.Color.White
        Me.lblRefund.Location = New System.Drawing.Point(12, 107)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(176, 29)
        Me.lblRefund.TabIndex = 31
        Me.lblRefund.Text = "Cash Received"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.BackColor = System.Drawing.Color.Gray
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.ForeColor = System.Drawing.Color.White
        Me.lblCash.Location = New System.Drawing.Point(12, 17)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(228, 29)
        Me.lblCash.TabIndex = 29
        Me.lblCash.Text = "Enter Customer ID #"
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(218, 200)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(174, 59)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "&Back (F10)"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtPayment
        '
        Me.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPayment.Enabled = False
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.ForeColor = System.Drawing.Color.Red
        Me.txtPayment.Location = New System.Drawing.Point(252, 102)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(139, 38)
        Me.txtPayment.TabIndex = 1
        Me.txtPayment.Text = "0"
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Amount Adjusted"
        '
        'lblAdjAmount
        '
        Me.lblAdjAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdjAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjAmount.Location = New System.Drawing.Point(253, 148)
        Me.lblAdjAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAdjAmount.Name = "lblAdjAmount"
        Me.lblAdjAmount.Size = New System.Drawing.Size(139, 38)
        Me.lblAdjAmount.TabIndex = 33
        Me.lblAdjAmount.Text = "0"
        Me.lblAdjAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(252, 57)
        Me.lblName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(139, 38)
        Me.lblName.TabIndex = 35
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Customer Name"
        '
        'AdjustPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(404, 272)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAdjAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdPaid)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lblRefund)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtPayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdjustPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjust Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPaid As System.Windows.Forms.Button
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblRefund As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAdjAmount As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
