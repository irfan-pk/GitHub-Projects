<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.Copyright = New System.Windows.Forms.Label
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tmrAnimation
        '
        Me.tmrAnimation.Enabled = True
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Enabled = False
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(7, 190)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(397, 25)
        Me.Copyright.TabIndex = 0
        Me.Copyright.Text = "Copyright"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.White
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(232, 100)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(141, 22)
        Me.PasswordTextBox.TabIndex = 1
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'cmdOk
        '
        Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOk.Location = New System.Drawing.Point(344, 191)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(29, 20)
        Me.cmdOk.TabIndex = 12
        Me.cmdOk.Text = "ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.Location = New System.Drawing.Point(379, 191)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(21, 23)
        Me.cmdClose.TabIndex = 14
        Me.cmdClose.Text = "X"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.login_img
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(412, 219)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrAnimation As System.Windows.Forms.Timer
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button

End Class
