<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseReturn))
        Me.lblReturn = New System.Windows.Forms.Label
        Me.lblExit = New System.Windows.Forms.Label
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblReturn
        '
        Me.lblReturn.AutoSize = True
        Me.lblReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturn.ForeColor = System.Drawing.Color.Maroon
        Me.lblReturn.Location = New System.Drawing.Point(211, 83)
        Me.lblReturn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(198, 16)
        Me.lblReturn.TabIndex = 159
        Me.lblReturn.Text = "[ F2 ] PURCHASE RETURN"
        Me.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.Maroon
        Me.lblExit.Location = New System.Drawing.Point(35, 83)
        Me.lblExit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(146, 16)
        Me.lblExit.TabIndex = 160
        Me.lblExit.Text = "[ F1 ] EXIT TO MAIN"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoiceNo.Location = New System.Drawing.Point(214, 23)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(181, 22)
        Me.txtInvoiceNo.TabIndex = 156
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(192, 26)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(12, 16)
        Me.Label17.TabIndex = 158
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(35, 26)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(151, 16)
        Me.Label18.TabIndex = 157
        Me.Label18.Text = "Enter Invoice # to Return"
        '
        'PurchaseReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(430, 123)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(436, 151)
        Me.Name = "PurchaseReturn"
        Me.Text = "Purchase Return"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReturn As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
