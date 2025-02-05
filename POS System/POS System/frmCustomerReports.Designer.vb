<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerReports))
        Me.gbRptype = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.cmbCustName = New System.Windows.Forms.ComboBox
        Me.rdSelCust = New System.Windows.Forms.RadioButton
        Me.rdAllCust = New System.Windows.Forms.RadioButton
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdLedger = New System.Windows.Forms.RadioButton
        Me.rdDetail = New System.Windows.Forms.RadioButton
        Me.gbRptype.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRptype
        '
        Me.gbRptype.Controls.Add(Me.Label1)
        Me.gbRptype.Controls.Add(Me.DateFrom)
        Me.gbRptype.Controls.Add(Me.cmbCustName)
        Me.gbRptype.Controls.Add(Me.rdSelCust)
        Me.gbRptype.Controls.Add(Me.rdAllCust)
        Me.gbRptype.Location = New System.Drawing.Point(12, 44)
        Me.gbRptype.Name = "gbRptype"
        Me.gbRptype.Size = New System.Drawing.Size(260, 163)
        Me.gbRptype.TabIndex = 3
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
        'rdSelCust
        '
        Me.rdSelCust.AutoSize = True
        Me.rdSelCust.Location = New System.Drawing.Point(18, 56)
        Me.rdSelCust.Name = "rdSelCust"
        Me.rdSelCust.Size = New System.Drawing.Size(102, 17)
        Me.rdSelCust.TabIndex = 5
        Me.rdSelCust.Text = "Select Customer"
        Me.rdSelCust.UseVisualStyleBackColor = True
        '
        'rdAllCust
        '
        Me.rdAllCust.AutoSize = True
        Me.rdAllCust.Checked = True
        Me.rdAllCust.Location = New System.Drawing.Point(18, 31)
        Me.rdAllCust.Name = "rdAllCust"
        Me.rdAllCust.Size = New System.Drawing.Size(88, 17)
        Me.rdAllCust.TabIndex = 4
        Me.rdAllCust.TabStop = True
        Me.rdAllCust.Text = "All Customers"
        Me.rdAllCust.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Location = New System.Drawing.Point(114, 222)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(76, 29)
        Me.cmdPreview.TabIndex = 8
        Me.cmdPreview.Text = "Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(196, 222)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 29)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdLedger)
        Me.GroupBox1.Controls.Add(Me.rdDetail)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 33)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rdLedger
        '
        Me.rdLedger.AutoSize = True
        Me.rdLedger.Location = New System.Drawing.Point(141, 11)
        Me.rdLedger.Name = "rdLedger"
        Me.rdLedger.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdLedger.Size = New System.Drawing.Size(105, 17)
        Me.rdLedger.TabIndex = 2
        Me.rdLedger.Text = "Customer Ledger"
        Me.rdLedger.UseVisualStyleBackColor = True
        '
        'rdDetail
        '
        Me.rdDetail.AutoSize = True
        Me.rdDetail.Checked = True
        Me.rdDetail.Location = New System.Drawing.Point(19, 11)
        Me.rdDetail.Name = "rdDetail"
        Me.rdDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdDetail.Size = New System.Drawing.Size(99, 17)
        Me.rdDetail.TabIndex = 1
        Me.rdDetail.TabStop = True
        Me.rdDetail.Text = "Customer Detail"
        Me.rdDetail.UseVisualStyleBackColor = True
        '
        'frmCustomerReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 263)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPreview)
        Me.Controls.Add(Me.gbRptype)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerReports"
        Me.Opacity = 0.8
        Me.Text = "Reports"
        Me.gbRptype.ResumeLayout(False)
        Me.gbRptype.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRptype As System.Windows.Forms.GroupBox
    Friend WithEvents rdSelCust As System.Windows.Forms.RadioButton
    Friend WithEvents rdAllCust As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCustName As System.Windows.Forms.ComboBox
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLedger As System.Windows.Forms.RadioButton
    Friend WithEvents rdDetail As System.Windows.Forms.RadioButton
End Class
