<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyStatSpc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyStatSpc))
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdNDetail = New System.Windows.Forms.RadioButton
        Me.rdNSummary = New System.Windows.Forms.RadioButton
        Me.rdGXDetail = New System.Windows.Forms.RadioButton
        Me.rdGXDaily = New System.Windows.Forms.RadioButton
        Me.rdSTDetail = New System.Windows.Forms.RadioButton
        Me.rdSTDaily = New System.Windows.Forms.RadioButton
        Me.rdPCRDetail = New System.Windows.Forms.RadioButton
        Me.rdPCRDaily = New System.Windows.Forms.RadioButton
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
        Me.cmdPreview.Location = New System.Drawing.Point(196, 309)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(80, 24)
        Me.cmdPreview.TabIndex = 7
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(282, 309)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 24)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdNDetail)
        Me.GroupBox1.Controls.Add(Me.rdNSummary)
        Me.GroupBox1.Controls.Add(Me.rdGXDetail)
        Me.GroupBox1.Controls.Add(Me.rdGXDaily)
        Me.GroupBox1.Controls.Add(Me.rdSTDetail)
        Me.GroupBox1.Controls.Add(Me.rdSTDaily)
        Me.GroupBox1.Controls.Add(Me.rdPCRDetail)
        Me.GroupBox1.Controls.Add(Me.rdPCRDaily)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(14, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 138)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Statement"
        '
        'rdNDetail
        '
        Me.rdNDetail.AutoSize = True
        Me.rdNDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdNDetail.Location = New System.Drawing.Point(207, 100)
        Me.rdNDetail.Name = "rdNDetail"
        Me.rdNDetail.Size = New System.Drawing.Size(119, 17)
        Me.rdNDetail.TabIndex = 16
        Me.rdNDetail.Text = "Daily National Detail"
        Me.rdNDetail.UseVisualStyleBackColor = True
        '
        'rdNSummary
        '
        Me.rdNSummary.AutoSize = True
        Me.rdNSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdNSummary.Location = New System.Drawing.Point(22, 101)
        Me.rdNSummary.Name = "rdNSummary"
        Me.rdNSummary.Size = New System.Drawing.Size(135, 17)
        Me.rdNSummary.TabIndex = 15
        Me.rdNSummary.Text = "Daily National Summary"
        Me.rdNSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdNSummary.UseVisualStyleBackColor = True
        '
        'rdGXDetail
        '
        Me.rdGXDetail.AutoSize = True
        Me.rdGXDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdGXDetail.Location = New System.Drawing.Point(207, 77)
        Me.rdGXDetail.Name = "rdGXDetail"
        Me.rdGXDetail.Size = New System.Drawing.Size(111, 17)
        Me.rdGXDetail.TabIndex = 14
        Me.rdGXDetail.Text = "Daily Jinnah Detail"
        Me.rdGXDetail.UseVisualStyleBackColor = True
        '
        'rdGXDaily
        '
        Me.rdGXDaily.AutoSize = True
        Me.rdGXDaily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdGXDaily.Location = New System.Drawing.Point(22, 78)
        Me.rdGXDaily.Name = "rdGXDaily"
        Me.rdGXDaily.Size = New System.Drawing.Size(127, 17)
        Me.rdGXDaily.TabIndex = 13
        Me.rdGXDaily.Text = "Daily Jinnah Summary"
        Me.rdGXDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdGXDaily.UseVisualStyleBackColor = True
        '
        'rdSTDetail
        '
        Me.rdSTDetail.AutoSize = True
        Me.rdSTDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdSTDetail.Location = New System.Drawing.Point(208, 54)
        Me.rdSTDetail.Name = "rdSTDetail"
        Me.rdSTDetail.Size = New System.Drawing.Size(120, 17)
        Me.rdSTDetail.TabIndex = 12
        Me.rdSTDetail.Text = "Daily Sp. Test Detail"
        Me.rdSTDetail.UseVisualStyleBackColor = True
        '
        'rdSTDaily
        '
        Me.rdSTDaily.AutoSize = True
        Me.rdSTDaily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdSTDaily.Location = New System.Drawing.Point(23, 55)
        Me.rdSTDaily.Name = "rdSTDaily"
        Me.rdSTDaily.Size = New System.Drawing.Size(136, 17)
        Me.rdSTDaily.TabIndex = 11
        Me.rdSTDaily.Text = "Daily Sp. Test Summary"
        Me.rdSTDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdSTDaily.UseVisualStyleBackColor = True
        '
        'rdPCRDetail
        '
        Me.rdPCRDetail.AutoSize = True
        Me.rdPCRDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdPCRDetail.Location = New System.Drawing.Point(208, 31)
        Me.rdPCRDetail.Name = "rdPCRDetail"
        Me.rdPCRDetail.Size = New System.Drawing.Size(102, 17)
        Me.rdPCRDetail.TabIndex = 10
        Me.rdPCRDetail.Text = "Daily PCR Detail"
        Me.rdPCRDetail.UseVisualStyleBackColor = True
        '
        'rdPCRDaily
        '
        Me.rdPCRDaily.AutoSize = True
        Me.rdPCRDaily.Checked = True
        Me.rdPCRDaily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdPCRDaily.Location = New System.Drawing.Point(23, 32)
        Me.rdPCRDaily.Name = "rdPCRDaily"
        Me.rdPCRDaily.Size = New System.Drawing.Size(118, 17)
        Me.rdPCRDaily.TabIndex = 9
        Me.rdPCRDaily.TabStop = True
        Me.rdPCRDaily.Text = "Daily PCR Summary"
        Me.rdPCRDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdPCRDaily.UseVisualStyleBackColor = True
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
        'frmDailyStatSpc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(376, 346)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDailyStatSpc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Special Statements"
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCpName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents toDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fromDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOper As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdSTDetail As System.Windows.Forms.RadioButton
    Friend WithEvents rdSTDaily As System.Windows.Forms.RadioButton
    Friend WithEvents rdPCRDetail As System.Windows.Forms.RadioButton
    Friend WithEvents rdPCRDaily As System.Windows.Forms.RadioButton
    Friend WithEvents rdGXDetail As System.Windows.Forms.RadioButton
    Friend WithEvents rdGXDaily As System.Windows.Forms.RadioButton
    Friend WithEvents rdNDetail As System.Windows.Forms.RadioButton
    Friend WithEvents rdNSummary As System.Windows.Forms.RadioButton
End Class
