<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccStatment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccStatment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdIncStatYr = New System.Windows.Forms.RadioButton
        Me.rdIncStatPrd = New System.Windows.Forms.RadioButton
        Me.rdTrialBalance = New System.Windows.Forms.RadioButton
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.toDatePick = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.fromDatePick = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.cmdPreview)
        Me.GroupBox1.Controls.Add(Me.toDatePick)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.fromDatePick)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 284)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdIncStatYr)
        Me.GroupBox2.Controls.Add(Me.rdIncStatPrd)
        Me.GroupBox2.Controls.Add(Me.rdTrialBalance)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 120)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Statement"
        '
        'rdIncStatYr
        '
        Me.rdIncStatYr.AutoSize = True
        Me.rdIncStatYr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdIncStatYr.Location = New System.Drawing.Point(41, 67)
        Me.rdIncStatYr.Name = "rdIncStatYr"
        Me.rdIncStatYr.Size = New System.Drawing.Size(110, 17)
        Me.rdIncStatYr.TabIndex = 6
        Me.rdIncStatYr.Text = "Income Statement"
        Me.rdIncStatYr.UseVisualStyleBackColor = True
        '
        'rdIncStatPrd
        '
        Me.rdIncStatPrd.AutoSize = True
        Me.rdIncStatPrd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdIncStatPrd.Location = New System.Drawing.Point(41, 44)
        Me.rdIncStatPrd.Name = "rdIncStatPrd"
        Me.rdIncStatPrd.Size = New System.Drawing.Size(147, 17)
        Me.rdIncStatPrd.TabIndex = 5
        Me.rdIncStatPrd.Text = "Income / Expenses Sheet"
        Me.rdIncStatPrd.UseVisualStyleBackColor = True
        '
        'rdTrialBalance
        '
        Me.rdTrialBalance.AutoSize = True
        Me.rdTrialBalance.Checked = True
        Me.rdTrialBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdTrialBalance.Location = New System.Drawing.Point(41, 21)
        Me.rdTrialBalance.Name = "rdTrialBalance"
        Me.rdTrialBalance.Size = New System.Drawing.Size(86, 17)
        Me.rdTrialBalance.TabIndex = 4
        Me.rdTrialBalance.TabStop = True
        Me.rdTrialBalance.Text = "Trial Balance"
        Me.rdTrialBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdTrialBalance.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(130, 245)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 28)
        Me.cmdClose.TabIndex = 32
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Location = New System.Drawing.Point(44, 245)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(80, 28)
        Me.cmdPreview.TabIndex = 31
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'toDatePick
        '
        Me.toDatePick.Location = New System.Drawing.Point(15, 80)
        Me.toDatePick.Name = "toDatePick"
        Me.toDatePick.Size = New System.Drawing.Size(228, 20)
        Me.toDatePick.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Statement To"
        '
        'fromDatePick
        '
        Me.fromDatePick.Location = New System.Drawing.Point(15, 34)
        Me.fromDatePick.Name = "fromDatePick"
        Me.fromDatePick.Size = New System.Drawing.Size(228, 20)
        Me.fromDatePick.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Statement From"
        '
        'frmAccStatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 298)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAccStatment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Statments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdIncStatYr As System.Windows.Forms.RadioButton
    Friend WithEvents rdTrialBalance As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents toDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fromDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdIncStatPrd As System.Windows.Forms.RadioButton
End Class
