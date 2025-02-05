<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WholesalerReports
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
        Me.gbRptype = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.cmbCustName = New System.Windows.Forms.ComboBox
        Me.rdSelSaler = New System.Windows.Forms.RadioButton
        Me.rdAllSaler = New System.Windows.Forms.RadioButton
        Me.rdWLedger = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdWDetail = New System.Windows.Forms.RadioButton
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.gbRptype.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRptype
        '
        Me.gbRptype.Controls.Add(Me.Label1)
        Me.gbRptype.Controls.Add(Me.DateFrom)
        Me.gbRptype.Controls.Add(Me.cmbCustName)
        Me.gbRptype.Controls.Add(Me.rdSelSaler)
        Me.gbRptype.Controls.Add(Me.rdAllSaler)
        Me.gbRptype.Location = New System.Drawing.Point(12, 44)
        Me.gbRptype.Name = "gbRptype"
        Me.gbRptype.Size = New System.Drawing.Size(260, 163)
        Me.gbRptype.TabIndex = 11
        Me.gbRptype.TabStop = False
        Me.gbRptype.Text = "Selec Report for"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'DateFrom
        '
        Me.DateFrom.Location = New System.Drawing.Point(18, 126)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(227, 20)
        Me.DateFrom.TabIndex = 7
        '
        'cmbCustName
        '
        Me.cmbCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustName.Enabled = False
        Me.cmbCustName.FormattingEnabled = True
        Me.cmbCustName.Location = New System.Drawing.Point(18, 79)
        Me.cmbCustName.Name = "cmbCustName"
        Me.cmbCustName.Size = New System.Drawing.Size(227, 21)
        Me.cmbCustName.TabIndex = 6
        '
        'rdSelSaler
        '
        Me.rdSelSaler.AutoSize = True
        Me.rdSelSaler.Location = New System.Drawing.Point(18, 56)
        Me.rdSelSaler.Name = "rdSelSaler"
        Me.rdSelSaler.Size = New System.Drawing.Size(111, 17)
        Me.rdSelSaler.TabIndex = 5
        Me.rdSelSaler.Text = "Select Wholesaler"
        Me.rdSelSaler.UseVisualStyleBackColor = True
        '
        'rdAllSaler
        '
        Me.rdAllSaler.AutoSize = True
        Me.rdAllSaler.Checked = True
        Me.rdAllSaler.Location = New System.Drawing.Point(18, 31)
        Me.rdAllSaler.Name = "rdAllSaler"
        Me.rdAllSaler.Size = New System.Drawing.Size(97, 17)
        Me.rdAllSaler.TabIndex = 4
        Me.rdAllSaler.TabStop = True
        Me.rdAllSaler.Text = "All Wholesalers"
        Me.rdAllSaler.UseVisualStyleBackColor = True
        '
        'rdWLedger
        '
        Me.rdWLedger.AutoSize = True
        Me.rdWLedger.Location = New System.Drawing.Point(141, 11)
        Me.rdWLedger.Name = "rdWLedger"
        Me.rdWLedger.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdWLedger.Size = New System.Drawing.Size(114, 17)
        Me.rdWLedger.TabIndex = 2
        Me.rdWLedger.Text = "Wholesaler Ledger"
        Me.rdWLedger.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdWLedger)
        Me.GroupBox1.Controls.Add(Me.rdWDetail)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 33)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'rdWDetail
        '
        Me.rdWDetail.AutoSize = True
        Me.rdWDetail.Checked = True
        Me.rdWDetail.Location = New System.Drawing.Point(19, 11)
        Me.rdWDetail.Name = "rdWDetail"
        Me.rdWDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdWDetail.Size = New System.Drawing.Size(102, 17)
        Me.rdWDetail.TabIndex = 1
        Me.rdWDetail.TabStop = True
        Me.rdWDetail.Text = "Wholsaler Detail"
        Me.rdWDetail.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(196, 222)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 29)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Location = New System.Drawing.Point(114, 222)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(76, 29)
        Me.cmdPreview.TabIndex = 12
        Me.cmdPreview.Text = "Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'frmWholesalerReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 263)
        Me.Controls.Add(Me.gbRptype)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWholesalerReports"
        Me.Opacity = 0.8
        Me.Text = "Reports"
        Me.gbRptype.ResumeLayout(False)
        Me.gbRptype.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRptype As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCustName As System.Windows.Forms.ComboBox
    Friend WithEvents rdSelSaler As System.Windows.Forms.RadioButton
    Friend WithEvents rdAllSaler As System.Windows.Forms.RadioButton
    Friend WithEvents rdWLedger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdWDetail As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
End Class
