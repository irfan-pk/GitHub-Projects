<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintSlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintSlip))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRecNo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdNRno = New System.Windows.Forms.RadioButton
        Me.rdNPnum = New System.Windows.Forms.RadioButton
        Me.rdSPCLSlip = New System.Windows.Forms.RadioButton
        Me.rdSPCSlip = New System.Windows.Forms.RadioButton
        Me.rdPCRLSlip = New System.Windows.Forms.RadioButton
        Me.rdPCRSlip = New System.Windows.Forms.RadioButton
        Me.rdGXRNo = New System.Windows.Forms.RadioButton
        Me.rdGXPNum = New System.Windows.Forms.RadioButton
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
        Me.GroupBox1.Controls.Add(Me.rdNRno)
        Me.GroupBox1.Controls.Add(Me.rdNPnum)
        Me.GroupBox1.Controls.Add(Me.rdSPCLSlip)
        Me.GroupBox1.Controls.Add(Me.rdSPCSlip)
        Me.GroupBox1.Controls.Add(Me.rdPCRLSlip)
        Me.GroupBox1.Controls.Add(Me.rdPCRSlip)
        Me.GroupBox1.Controls.Add(Me.rdGXRNo)
        Me.GroupBox1.Controls.Add(Me.rdGXPNum)
        Me.GroupBox1.Controls.Add(Me.rdEnvelope)
        Me.GroupBox1.Controls.Add(Me.rdLSlip)
        Me.GroupBox1.Controls.Add(Me.rdPSlip)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 146)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current"
        '
        'rdNRno
        '
        Me.rdNRno.AutoSize = True
        Me.rdNRno.Location = New System.Drawing.Point(170, 111)
        Me.rdNRno.Name = "rdNRno"
        Me.rdNRno.Size = New System.Drawing.Size(137, 17)
        Me.rdNRno.TabIndex = 14
        Me.rdNRno.Text = "Lab Receipt ( National )"
        Me.rdNRno.UseVisualStyleBackColor = True
        '
        'rdNPnum
        '
        Me.rdNPnum.AutoSize = True
        Me.rdNPnum.Location = New System.Drawing.Point(26, 111)
        Me.rdNPnum.Name = "rdNPnum"
        Me.rdNPnum.Size = New System.Drawing.Size(112, 17)
        Me.rdNPnum.TabIndex = 13
        Me.rdNPnum.Text = "Patient ( National )"
        Me.rdNPnum.UseVisualStyleBackColor = True
        '
        'rdSPCLSlip
        '
        Me.rdSPCLSlip.AutoSize = True
        Me.rdSPCLSlip.Location = New System.Drawing.Point(170, 65)
        Me.rdSPCLSlip.Name = "rdSPCLSlip"
        Me.rdSPCLSlip.Size = New System.Drawing.Size(111, 17)
        Me.rdSPCLSlip.TabIndex = 12
        Me.rdSPCLSlip.Text = "Lab Receipt (Spc)"
        Me.rdSPCLSlip.UseVisualStyleBackColor = True
        '
        'rdSPCSlip
        '
        Me.rdSPCSlip.AutoSize = True
        Me.rdSPCSlip.Location = New System.Drawing.Point(26, 65)
        Me.rdSPCSlip.Name = "rdSPCSlip"
        Me.rdSPCSlip.Size = New System.Drawing.Size(126, 17)
        Me.rdSPCSlip.TabIndex = 11
        Me.rdSPCSlip.Text = "Patient Receipt (Spc)"
        Me.rdSPCSlip.UseVisualStyleBackColor = True
        '
        'rdPCRLSlip
        '
        Me.rdPCRLSlip.AutoSize = True
        Me.rdPCRLSlip.Location = New System.Drawing.Point(170, 42)
        Me.rdPCRLSlip.Name = "rdPCRLSlip"
        Me.rdPCRLSlip.Size = New System.Drawing.Size(114, 17)
        Me.rdPCRLSlip.TabIndex = 10
        Me.rdPCRLSlip.Text = "Lab Receipt (PCR)"
        Me.rdPCRLSlip.UseVisualStyleBackColor = True
        '
        'rdPCRSlip
        '
        Me.rdPCRSlip.AutoSize = True
        Me.rdPCRSlip.Location = New System.Drawing.Point(26, 42)
        Me.rdPCRSlip.Name = "rdPCRSlip"
        Me.rdPCRSlip.Size = New System.Drawing.Size(129, 17)
        Me.rdPCRSlip.TabIndex = 9
        Me.rdPCRSlip.Text = "Patient Receipt (PCR)"
        Me.rdPCRSlip.UseVisualStyleBackColor = True
        '
        'rdGXRNo
        '
        Me.rdGXRNo.AutoSize = True
        Me.rdGXRNo.Location = New System.Drawing.Point(170, 88)
        Me.rdGXRNo.Name = "rdGXRNo"
        Me.rdGXRNo.Size = New System.Drawing.Size(123, 17)
        Me.rdGXRNo.TabIndex = 7
        Me.rdGXRNo.Text = "Lab Receipt (Jinnah)"
        Me.rdGXRNo.UseVisualStyleBackColor = True
        '
        'rdGXPNum
        '
        Me.rdGXPNum.AutoSize = True
        Me.rdGXPNum.Location = New System.Drawing.Point(26, 88)
        Me.rdGXPNum.Name = "rdGXPNum"
        Me.rdGXPNum.Size = New System.Drawing.Size(138, 17)
        Me.rdGXPNum.TabIndex = 6
        Me.rdGXPNum.Text = "Patient Receipt (Jinnah)"
        Me.rdGXPNum.UseVisualStyleBackColor = True
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
        Me.rdLSlip.Location = New System.Drawing.Point(170, 19)
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
        Me.cmdPrint.Location = New System.Drawing.Point(288, 214)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(55, 27)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(349, 214)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(55, 27)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmPrintSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 259)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRecNo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrintSlip"
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
    Friend WithEvents rdGXRNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdGXPNum As System.Windows.Forms.RadioButton
    Friend WithEvents rdSPCSlip As System.Windows.Forms.RadioButton
    Friend WithEvents rdPCRLSlip As System.Windows.Forms.RadioButton
    Friend WithEvents rdPCRSlip As System.Windows.Forms.RadioButton
    Friend WithEvents rdSPCLSlip As System.Windows.Forms.RadioButton
    Friend WithEvents rdNRno As System.Windows.Forms.RadioButton
    Friend WithEvents rdNPnum As System.Windows.Forms.RadioButton
End Class
