<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoryWiseStat
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.toDatePick = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.fromDatePick = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdECGStat = New System.Windows.Forms.RadioButton
        Me.rdSonoStat = New System.Windows.Forms.RadioButton
        Me.rdXrayStat = New System.Windows.Forms.RadioButton
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.toDatePick)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.fromDatePick)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 94)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'toDatePick
        '
        Me.toDatePick.Location = New System.Drawing.Point(82, 54)
        Me.toDatePick.Name = "toDatePick"
        Me.toDatePick.Size = New System.Drawing.Size(192, 20)
        Me.toDatePick.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "To Date"
        '
        'fromDatePick
        '
        Me.fromDatePick.Location = New System.Drawing.Point(82, 19)
        Me.fromDatePick.Name = "fromDatePick"
        Me.fromDatePick.Size = New System.Drawing.Size(192, 20)
        Me.fromDatePick.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "From Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdECGStat)
        Me.GroupBox1.Controls.Add(Me.rdSonoStat)
        Me.GroupBox1.Controls.Add(Me.rdXrayStat)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 109)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Statement"
        '
        'rdECGStat
        '
        Me.rdECGStat.AutoSize = True
        Me.rdECGStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdECGStat.Location = New System.Drawing.Point(19, 72)
        Me.rdECGStat.Name = "rdECGStat"
        Me.rdECGStat.Size = New System.Drawing.Size(153, 17)
        Me.rdECGStat.TabIndex = 6
        Me.rdECGStat.Text = "Periodically ECG Statement"
        Me.rdECGStat.UseVisualStyleBackColor = True
        '
        'rdSonoStat
        '
        Me.rdSonoStat.AutoSize = True
        Me.rdSonoStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdSonoStat.Location = New System.Drawing.Point(19, 49)
        Me.rdSonoStat.Name = "rdSonoStat"
        Me.rdSonoStat.Size = New System.Drawing.Size(188, 17)
        Me.rdSonoStat.TabIndex = 5
        Me.rdSonoStat.Text = "Periodically Sonography Statement"
        Me.rdSonoStat.UseVisualStyleBackColor = True
        '
        'rdXrayStat
        '
        Me.rdXrayStat.AutoSize = True
        Me.rdXrayStat.Checked = True
        Me.rdXrayStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdXrayStat.Location = New System.Drawing.Point(19, 27)
        Me.rdXrayStat.Name = "rdXrayStat"
        Me.rdXrayStat.Size = New System.Drawing.Size(152, 17)
        Me.rdXrayStat.TabIndex = 4
        Me.rdXrayStat.TabStop = True
        Me.rdXrayStat.Text = "Periodically Xray Statement"
        Me.rdXrayStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdXrayStat.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(221, 230)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 24)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Location = New System.Drawing.Point(135, 230)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(80, 24)
        Me.cmdPreview.TabIndex = 16
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'frmCategoryWiseStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 267)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPreview)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCategoryWiseStat"
        Me.Text = "Category Wise Reports"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents toDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fromDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdECGStat As System.Windows.Forms.RadioButton
    Friend WithEvents rdSonoStat As System.Windows.Forms.RadioButton
    Friend WithEvents rdXrayStat As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
End Class
