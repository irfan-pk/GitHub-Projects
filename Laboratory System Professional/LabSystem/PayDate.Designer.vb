<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayDate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDueAmount = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Payment Date"
        '
        'dtpPayDate
        '
        Me.dtpPayDate.Location = New System.Drawing.Point(138, 48)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(213, 20)
        Me.dtpPayDate.TabIndex = 1
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(203, 83)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(71, 26)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(280, 83)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(71, 26)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Due Amount"
        '
        'txtDueAmount
        '
        Me.txtDueAmount.Location = New System.Drawing.Point(138, 16)
        Me.txtDueAmount.Name = "txtDueAmount"
        Me.txtDueAmount.Size = New System.Drawing.Size(213, 20)
        Me.txtDueAmount.TabIndex = 0
        '
        'PayDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 121)
        Me.Controls.Add(Me.txtDueAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.dtpPayDate)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PayDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDueAmount As System.Windows.Forms.TextBox
End Class
