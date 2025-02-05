<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountStatment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountStatment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdAdjTrialBal = New System.Windows.Forms.RadioButton
        Me.rdQtrStatement = New System.Windows.Forms.RadioButton
        Me.rdBalSheet = New System.Windows.Forms.RadioButton
        Me.rdIncStatYr = New System.Windows.Forms.RadioButton
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
        Me.GroupBox1.Size = New System.Drawing.Size(299, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdAdjTrialBal)
        Me.GroupBox2.Controls.Add(Me.rdQtrStatement)
        Me.GroupBox2.Controls.Add(Me.rdBalSheet)
        Me.GroupBox2.Controls.Add(Me.rdIncStatYr)
        Me.GroupBox2.Controls.Add(Me.rdTrialBalance)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 127)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Statement"
        '
        'rdAdjTrialBal
        '
        Me.rdAdjTrialBal.AutoSize = True
        Me.rdAdjTrialBal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdAdjTrialBal.Location = New System.Drawing.Point(13, 58)
        Me.rdAdjTrialBal.Name = "rdAdjTrialBal"
        Me.rdAdjTrialBal.Size = New System.Drawing.Size(130, 17)
        Me.rdAdjTrialBal.TabIndex = 14
        Me.rdAdjTrialBal.Text = "Adjusted Trial Balance"
        Me.rdAdjTrialBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdAdjTrialBal.UseVisualStyleBackColor = True
        '
        'rdQtrStatement
        '
        Me.rdQtrStatement.AutoSize = True
        Me.rdQtrStatement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdQtrStatement.Location = New System.Drawing.Point(13, 81)
        Me.rdQtrStatement.Name = "rdQtrStatement"
        Me.rdQtrStatement.Size = New System.Drawing.Size(130, 17)
        Me.rdQtrStatement.TabIndex = 10
        Me.rdQtrStatement.Text = "Qtr. Income Statement"
        Me.rdQtrStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdQtrStatement.UseVisualStyleBackColor = True
        '
        'rdBalSheet
        '
        Me.rdBalSheet.AutoSize = True
        Me.rdBalSheet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdBalSheet.Location = New System.Drawing.Point(145, 58)
        Me.rdBalSheet.Name = "rdBalSheet"
        Me.rdBalSheet.Size = New System.Drawing.Size(94, 17)
        Me.rdBalSheet.TabIndex = 13
        Me.rdBalSheet.Text = "Balance Sheet"
        Me.rdBalSheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdBalSheet.UseVisualStyleBackColor = True
        '
        'rdIncStatYr
        '
        Me.rdIncStatYr.AutoSize = True
        Me.rdIncStatYr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdIncStatYr.Location = New System.Drawing.Point(145, 35)
        Me.rdIncStatYr.Name = "rdIncStatYr"
        Me.rdIncStatYr.Size = New System.Drawing.Size(110, 17)
        Me.rdIncStatYr.TabIndex = 12
        Me.rdIncStatYr.Text = "Income Statement"
        Me.rdIncStatYr.UseVisualStyleBackColor = True
        '
        'rdTrialBalance
        '
        Me.rdTrialBalance.AutoSize = True
        Me.rdTrialBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdTrialBalance.Location = New System.Drawing.Point(13, 35)
        Me.rdTrialBalance.Name = "rdTrialBalance"
        Me.rdTrialBalance.Size = New System.Drawing.Size(86, 17)
        Me.rdTrialBalance.TabIndex = 9
        Me.rdTrialBalance.Text = "Trial Balance"
        Me.rdTrialBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdTrialBalance.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(148, 270)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 28)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Location = New System.Drawing.Point(62, 270)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(80, 28)
        Me.cmdPreview.TabIndex = 14
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'toDatePick
        '
        Me.toDatePick.Location = New System.Drawing.Point(40, 80)
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
        Me.fromDatePick.Location = New System.Drawing.Point(40, 34)
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
        'AccountStatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 330)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AccountStatment"
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
    Friend WithEvents rdBalSheet As System.Windows.Forms.RadioButton
    Friend WithEvents rdQtrStatement As System.Windows.Forms.RadioButton
    Friend WithEvents rdAdjTrialBal As System.Windows.Forms.RadioButton
End Class
