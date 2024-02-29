<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintSlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintSlip))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRecNo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdEnvelope = New System.Windows.Forms.RadioButton
        Me.rdLSlip = New System.Windows.Forms.RadioButton
        Me.rdPSlip = New System.Windows.Forms.RadioButton
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter Lab ID # to print receipt"
        '
        'txtRecNo
        '
        Me.txtRecNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNo.Location = New System.Drawing.Point(266, 25)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.Size = New System.Drawing.Size(138, 22)
        Me.txtRecNo.TabIndex = 1
        Me.txtRecNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdEnvelope)
        Me.GroupBox1.Controls.Add(Me.rdLSlip)
        Me.GroupBox1.Controls.Add(Me.rdPSlip)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 49)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'rdEnvelope
        '
        Me.rdEnvelope.AutoSize = True
        Me.rdEnvelope.Location = New System.Drawing.Point(279, 19)
        Me.rdEnvelope.Name = "rdEnvelope"
        Me.rdEnvelope.Size = New System.Drawing.Size(70, 17)
        Me.rdEnvelope.TabIndex = 5
        Me.rdEnvelope.Text = "Envelope"
        Me.rdEnvelope.UseVisualStyleBackColor = True
        '
        'rdLSlip
        '
        Me.rdLSlip.AutoSize = True
        Me.rdLSlip.Location = New System.Drawing.Point(158, 19)
        Me.rdLSlip.Name = "rdLSlip"
        Me.rdLSlip.Size = New System.Drawing.Size(83, 17)
        Me.rdLSlip.TabIndex = 4
        Me.rdLSlip.Text = "Lab Receipt"
        Me.rdLSlip.UseVisualStyleBackColor = True
        '
        'rdPSlip
        '
        Me.rdPSlip.AutoSize = True
        Me.rdPSlip.Checked = True
        Me.rdPSlip.Location = New System.Drawing.Point(26, 19)
        Me.rdPSlip.Name = "rdPSlip"
        Me.rdPSlip.Size = New System.Drawing.Size(98, 17)
        Me.rdPSlip.TabIndex = 3
        Me.rdPSlip.TabStop = True
        Me.rdPSlip.Text = "Patient Receipt"
        Me.rdPSlip.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Location = New System.Drawing.Point(288, 121)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(55, 27)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(349, 121)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(55, 27)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'PrintSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 160)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRecNo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PrintSlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Receipt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRecNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLSlip As System.Windows.Forms.RadioButton
    Friend WithEvents rdPSlip As System.Windows.Forms.RadioButton
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents rdEnvelope As System.Windows.Forms.RadioButton
End Class
