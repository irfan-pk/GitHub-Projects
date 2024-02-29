<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxPercentAdj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaxPercentAdj))
        Me.cmdCalculate = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdAdj = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblRecords = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPercent = New System.Windows.Forms.TextBox
        Me.toDatePick = New System.Windows.Forms.DateTimePicker
        Me.fromDatePick = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCP = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCalculate
        '
        Me.cmdCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCalculate.Location = New System.Drawing.Point(70, 283)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(69, 24)
        Me.cmdCalculate.TabIndex = 5
        Me.cmdCalculate.Text = "&Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(295, 283)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(69, 24)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdate.Location = New System.Drawing.Point(220, 283)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(69, 24)
        Me.cmdUpdate.TabIndex = 7
        Me.cmdUpdate.Text = "&Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdAdj
        '
        Me.cmdAdj.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdj.Location = New System.Drawing.Point(145, 283)
        Me.cmdAdj.Name = "cmdAdj"
        Me.cmdAdj.Size = New System.Drawing.Size(69, 24)
        Me.cmdAdj.TabIndex = 6
        Me.cmdAdj.Text = "&Adjust"
        Me.cmdAdj.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblAmount)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.lblRecords)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 114)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(119, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total Amount Payable"
        '
        'lblAmount
        '
        Me.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAmount.Location = New System.Drawing.Point(243, 76)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(92, 20)
        Me.lblAmount.TabIndex = 15
        Me.lblAmount.Text = "00"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Status"
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus.Location = New System.Drawing.Point(243, 46)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(92, 20)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "NIL"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecords
        '
        Me.lblRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRecords.Location = New System.Drawing.Point(243, 19)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(92, 20)
        Me.lblRecords.TabIndex = 12
        Me.lblRecords.Text = "00"
        Me.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Selected Records"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPercent)
        Me.GroupBox1.Controls.Add(Me.toDatePick)
        Me.GroupBox1.Controls.Add(Me.fromDatePick)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbCP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 138)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Select "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dues Adjustment (%)"
        '
        'txtPercent
        '
        Me.txtPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPercent.Location = New System.Drawing.Point(243, 101)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(92, 20)
        Me.txtPercent.TabIndex = 4
        Me.txtPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'toDatePick
        '
        Me.toDatePick.Location = New System.Drawing.Point(97, 74)
        Me.toDatePick.Name = "toDatePick"
        Me.toDatePick.Size = New System.Drawing.Size(238, 20)
        Me.toDatePick.TabIndex = 3
        '
        'fromDatePick
        '
        Me.fromDatePick.Location = New System.Drawing.Point(98, 46)
        Me.fromDatePick.Name = "fromDatePick"
        Me.fromDatePick.Size = New System.Drawing.Size(237, 20)
        Me.fromDatePick.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "From"
        '
        'cmbCP
        '
        Me.cmbCP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCP.FormattingEnabled = True
        Me.cmbCP.Location = New System.Drawing.Point(98, 17)
        Me.cmbCP.Name = "cmbCP"
        Me.cmbCP.Size = New System.Drawing.Size(237, 21)
        Me.cmbCP.Sorted = True
        Me.cmbCP.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Collection Point"
        '
        'TaxPercentAdj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(374, 319)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdAdj)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TaxPercentAdj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dues / Tax Adjustment"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdAdj As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents toDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents fromDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCP As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPercent As System.Windows.Forms.TextBox
End Class
