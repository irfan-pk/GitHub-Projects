<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockReports))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbDepartment = New System.Windows.Forms.ComboBox
        Me.rdStockRate = New System.Windows.Forms.RadioButton
        Me.rdStock = New System.Windows.Forms.RadioButton
        Me.rdStockList = New System.Windows.Forms.RadioButton
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCategory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDepartment)
        Me.GroupBox1.Controls.Add(Me.rdStockRate)
        Me.GroupBox1.Controls.Add(Me.rdStock)
        Me.GroupBox1.Controls.Add(Me.rdStockList)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 192)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.Enabled = False
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(19, 151)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(227, 21)
        Me.cmbCategory.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select Department"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Enabled = False
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(19, 103)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(227, 21)
        Me.cmbDepartment.TabIndex = 4
        '
        'rdStockRate
        '
        Me.rdStockRate.AutoSize = True
        Me.rdStockRate.Location = New System.Drawing.Point(19, 52)
        Me.rdStockRate.Name = "rdStockRate"
        Me.rdStockRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdStockRate.Size = New System.Drawing.Size(98, 17)
        Me.rdStockRate.TabIndex = 3
        Me.rdStockRate.Text = "Stock Rate List"
        Me.rdStockRate.UseVisualStyleBackColor = True
        '
        'rdStock
        '
        Me.rdStock.AutoSize = True
        Me.rdStock.Location = New System.Drawing.Point(141, 22)
        Me.rdStock.Name = "rdStock"
        Me.rdStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdStock.Size = New System.Drawing.Size(93, 17)
        Me.rdStock.TabIndex = 2
        Me.rdStock.Text = "Stock Position"
        Me.rdStock.UseVisualStyleBackColor = True
        '
        'rdStockList
        '
        Me.rdStockList.AutoSize = True
        Me.rdStockList.Checked = True
        Me.rdStockList.Location = New System.Drawing.Point(19, 23)
        Me.rdStockList.Name = "rdStockList"
        Me.rdStockList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdStockList.Size = New System.Drawing.Size(100, 17)
        Me.rdStockList.TabIndex = 1
        Me.rdStockList.TabStop = True
        Me.rdStockList.Text = "Stock Code List"
        Me.rdStockList.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(196, 214)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 29)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Location = New System.Drawing.Point(114, 214)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(76, 29)
        Me.cmdPreview.TabIndex = 16
        Me.cmdPreview.Text = "Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'StockReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 258)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StockReports"
        Me.Text = "Stock Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdStock As System.Windows.Forms.RadioButton
    Friend WithEvents rdStockList As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents rdStockRate As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
End Class
