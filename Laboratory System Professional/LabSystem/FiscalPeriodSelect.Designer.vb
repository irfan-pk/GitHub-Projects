<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiscalPeriodSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FiscalPeriodSelect))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbFiscalStart = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbFiscalClose = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbFiscalStart)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbFiscalClose)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select Fiscal Period to be Start"
        '
        'cbFiscalStart
        '
        Me.cbFiscalStart.FormattingEnabled = True
        Me.cbFiscalStart.Location = New System.Drawing.Point(202, 53)
        Me.cbFiscalStart.Name = "cbFiscalStart"
        Me.cbFiscalStart.Size = New System.Drawing.Size(122, 21)
        Me.cbFiscalStart.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Fiscal Period to be Close"
        '
        'cbFiscalClose
        '
        Me.cbFiscalClose.FormattingEnabled = True
        Me.cbFiscalClose.Location = New System.Drawing.Point(202, 18)
        Me.cbFiscalClose.Name = "cbFiscalClose"
        Me.cbFiscalClose.Size = New System.Drawing.Size(122, 21)
        Me.cbFiscalClose.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Image = Global.Business_Solutions.My.Resources.Resources.database_remove
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(294, 104)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(63, 28)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Image = Global.Business_Solutions.My.Resources.Resources.folder_add1
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(225, 104)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(63, 28)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&Ok"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'FiscalPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 138)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FiscalPeriod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FiscalPeriod"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbFiscalStart As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFiscalClose As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
