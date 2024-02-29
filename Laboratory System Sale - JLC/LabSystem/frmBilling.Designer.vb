<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBilling))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbCP = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbOper = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.fromDatePick = New System.Windows.Forms.DateTimePicker
        Me.toDatePick = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblRecords = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdBill = New System.Windows.Forms.Button
        Me.cmdPaid = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdCalculate = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Collection Point"
        '
        'cmbCP
        '
        Me.cmbCP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCP.FormattingEnabled = True
        Me.cmbCP.Location = New System.Drawing.Point(98, 27)
        Me.cmbCP.Name = "cmbCP"
        Me.cmbCP.Size = New System.Drawing.Size(237, 21)
        Me.cmbCP.Sorted = True
        Me.cmbCP.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Operator Name"
        '
        'cmbOper
        '
        Me.cmbOper.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOper.FormattingEnabled = True
        Me.cmbOper.Location = New System.Drawing.Point(98, 58)
        Me.cmbOper.Name = "cmbOper"
        Me.cmbOper.Size = New System.Drawing.Size(237, 21)
        Me.cmbOper.Sorted = True
        Me.cmbOper.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "To"
        '
        'fromDatePick
        '
        Me.fromDatePick.Location = New System.Drawing.Point(98, 89)
        Me.fromDatePick.Name = "fromDatePick"
        Me.fromDatePick.Size = New System.Drawing.Size(237, 20)
        Me.fromDatePick.TabIndex = 2
        '
        'toDatePick
        '
        Me.toDatePick.Location = New System.Drawing.Point(97, 117)
        Me.toDatePick.Name = "toDatePick"
        Me.toDatePick.Size = New System.Drawing.Size(238, 20)
        Me.toDatePick.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.toDatePick)
        Me.GroupBox1.Controls.Add(Me.fromDatePick)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbOper)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 162)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Select "
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Status"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(119, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total Amount Payable"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblAmount)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.lblRecords)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 114)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'cmdBill
        '
        Me.cmdBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBill.Location = New System.Drawing.Point(145, 305)
        Me.cmdBill.Name = "cmdBill"
        Me.cmdBill.Size = New System.Drawing.Size(69, 24)
        Me.cmdBill.TabIndex = 5
        Me.cmdBill.Text = "&BIlling"
        Me.cmdBill.UseVisualStyleBackColor = True
        '
        'cmdPaid
        '
        Me.cmdPaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPaid.Location = New System.Drawing.Point(220, 305)
        Me.cmdPaid.Name = "cmdPaid"
        Me.cmdPaid.Size = New System.Drawing.Size(69, 24)
        Me.cmdPaid.TabIndex = 6
        Me.cmdPaid.Text = "&Paid"
        Me.cmdPaid.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(295, 305)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(69, 24)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdCalculate
        '
        Me.cmdCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCalculate.Location = New System.Drawing.Point(70, 305)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(69, 24)
        Me.cmdCalculate.TabIndex = 4
        Me.cmdCalculate.Text = "&Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'frmBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(376, 338)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPaid)
        Me.Controls.Add(Me.cmdBill)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection Point Billing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCP As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOper As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fromDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents toDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBill As System.Windows.Forms.Button
    Friend WithEvents cmdPaid As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
End Class
