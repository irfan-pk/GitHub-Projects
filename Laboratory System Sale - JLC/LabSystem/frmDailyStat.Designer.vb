<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyStat))
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdDailyCases = New System.Windows.Forms.RadioButton
        Me.rdWeekMonth = New System.Windows.Forms.RadioButton
        Me.rdPayInvoice = New System.Windows.Forms.RadioButton
        Me.rdCpPayment = New System.Windows.Forms.RadioButton
        Me.rdDueInvoice = New System.Windows.Forms.RadioButton
        Me.rdCpDues = New System.Windows.Forms.RadioButton
        Me.rdDaily = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbCpName = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.toDatePick = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.fromDatePick = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbOper = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPreview
        '
        Me.cmdPreview.Location = New System.Drawing.Point(196, 296)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(80, 24)
        Me.cmdPreview.TabIndex = 7
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(282, 296)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 24)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdDailyCases)
        Me.GroupBox1.Controls.Add(Me.rdWeekMonth)
        Me.GroupBox1.Controls.Add(Me.rdPayInvoice)
        Me.GroupBox1.Controls.Add(Me.rdCpPayment)
        Me.GroupBox1.Controls.Add(Me.rdDueInvoice)
        Me.GroupBox1.Controls.Add(Me.rdCpDues)
        Me.GroupBox1.Controls.Add(Me.rdDaily)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(14, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 126)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Statement"
        '
        'rdDailyCases
        '
        Me.rdDailyCases.AutoSize = True
        Me.rdDailyCases.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdDailyCases.Location = New System.Drawing.Point(204, 26)
        Me.rdDailyCases.Name = "rdDailyCases"
        Me.rdDailyCases.Size = New System.Drawing.Size(109, 17)
        Me.rdDailyCases.TabIndex = 8
        Me.rdDailyCases.Text = "Daily Cases Detail"
        Me.rdDailyCases.UseVisualStyleBackColor = True
        '
        'rdWeekMonth
        '
        Me.rdWeekMonth.AutoSize = True
        Me.rdWeekMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdWeekMonth.Location = New System.Drawing.Point(19, 95)
        Me.rdWeekMonth.Name = "rdWeekMonth"
        Me.rdWeekMonth.Size = New System.Drawing.Size(153, 17)
        Me.rdWeekMonth.TabIndex = 7
        Me.rdWeekMonth.Text = "Weekly/Monthly Statement"
        Me.rdWeekMonth.UseVisualStyleBackColor = True
        '
        'rdPayInvoice
        '
        Me.rdPayInvoice.AutoSize = True
        Me.rdPayInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdPayInvoice.Location = New System.Drawing.Point(204, 72)
        Me.rdPayInvoice.Name = "rdPayInvoice"
        Me.rdPayInvoice.Size = New System.Drawing.Size(103, 17)
        Me.rdPayInvoice.TabIndex = 6
        Me.rdPayInvoice.Text = "Payment Invoice"
        Me.rdPayInvoice.UseVisualStyleBackColor = True
        '
        'rdCpPayment
        '
        Me.rdCpPayment.AutoSize = True
        Me.rdCpPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdCpPayment.Location = New System.Drawing.Point(19, 72)
        Me.rdCpPayment.Name = "rdCpPayment"
        Me.rdCpPayment.Size = New System.Drawing.Size(166, 17)
        Me.rdCpPayment.TabIndex = 6
        Me.rdCpPayment.Text = "Doc Wise Payment Statement"
        Me.rdCpPayment.UseVisualStyleBackColor = True
        '
        'rdDueInvoice
        '
        Me.rdDueInvoice.AutoSize = True
        Me.rdDueInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdDueInvoice.Location = New System.Drawing.Point(204, 49)
        Me.rdDueInvoice.Name = "rdDueInvoice"
        Me.rdDueInvoice.Size = New System.Drawing.Size(87, 17)
        Me.rdDueInvoice.TabIndex = 5
        Me.rdDueInvoice.Text = "Dues Invoice"
        Me.rdDueInvoice.UseVisualStyleBackColor = True
        '
        'rdCpDues
        '
        Me.rdCpDues.AutoSize = True
        Me.rdCpDues.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdCpDues.Location = New System.Drawing.Point(19, 49)
        Me.rdCpDues.Name = "rdCpDues"
        Me.rdCpDues.Size = New System.Drawing.Size(100, 17)
        Me.rdCpDues.TabIndex = 5
        Me.rdCpDues.Text = "Dues Statement"
        Me.rdCpDues.UseVisualStyleBackColor = True
        '
        'rdDaily
        '
        Me.rdDaily.AutoSize = True
        Me.rdDaily.Checked = True
        Me.rdDaily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdDaily.Location = New System.Drawing.Point(19, 27)
        Me.rdDaily.Name = "rdDaily"
        Me.rdDaily.Size = New System.Drawing.Size(142, 17)
        Me.rdDaily.TabIndex = 4
        Me.rdDaily.TabStop = True
        Me.rdDaily.Text = "Daily Collection Summary"
        Me.rdDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdDaily.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCpName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.toDatePick)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.fromDatePick)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbOper)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 146)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'cmbCpName
        '
        Me.cmbCpName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCpName.FormattingEnabled = True
        Me.cmbCpName.Items.AddRange(New Object() {"ALL"})
        Me.cmbCpName.Location = New System.Drawing.Point(92, 49)
        Me.cmbCpName.Name = "cmbCpName"
        Me.cmbCpName.Size = New System.Drawing.Size(235, 21)
        Me.cmbCpName.TabIndex = 13
        Me.cmbCpName.Text = "ALL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Collection"
        '
        'toDatePick
        '
        Me.toDatePick.Location = New System.Drawing.Point(92, 119)
        Me.toDatePick.Name = "toDatePick"
        Me.toDatePick.Size = New System.Drawing.Size(235, 20)
        Me.toDatePick.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "To Date"
        '
        'fromDatePick
        '
        Me.fromDatePick.Location = New System.Drawing.Point(92, 84)
        Me.fromDatePick.Name = "fromDatePick"
        Me.fromDatePick.Size = New System.Drawing.Size(235, 20)
        Me.fromDatePick.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "From Date"
        '
        'cmbOper
        '
        Me.cmbOper.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOper.FormattingEnabled = True
        Me.cmbOper.Items.AddRange(New Object() {"ALL"})
        Me.cmbOper.Location = New System.Drawing.Point(92, 14)
        Me.cmbOper.Name = "cmbOper"
        Me.cmbOper.Size = New System.Drawing.Size(235, 21)
        Me.cmbOper.TabIndex = 11
        Me.cmbOper.Text = "ALL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Operator"
        '
        'frmDailyStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(376, 334)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDailyStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Statements"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCpPayment As System.Windows.Forms.RadioButton
    Friend WithEvents rdCpDues As System.Windows.Forms.RadioButton
    Friend WithEvents rdDaily As System.Windows.Forms.RadioButton
    Friend WithEvents rdPayInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents rdDueInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents rdWeekMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rdDailyCases As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCpName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents toDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fromDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOper As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
