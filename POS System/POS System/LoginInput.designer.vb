<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginInput))
        Me.cmdLogin = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Copyright = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtPassword = New POS_System.WaterMarkTextBox
        Me.txtUserName = New POS_System.WaterMarkTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdLogin
        '
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.ForeColor = System.Drawing.Color.White
        Me.cmdLogin.Location = New System.Drawing.Point(284, 127)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(72, 26)
        Me.cmdLogin.TabIndex = 4
        Me.cmdLogin.Text = "&Login"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(362, 127)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(72, 26)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Copyright
        '
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Copyright.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.Cyan
        Me.Copyright.Location = New System.Drawing.Point(0, 177)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(478, 25)
        Me.Copyright.TabIndex = 99
        Me.Copyright.Text = "Copyright"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(140, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(151, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POS_System.My.Resources.Resources.Keys_64
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(31, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 91)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(233, 80)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(201, 24)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.Silver
        Me.txtPassword.WaterMarkText = "Enter Password"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(233, 39)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(201, 24)
        Me.txtUserName.TabIndex = 0
        Me.txtUserName.WaterMarkColor = System.Drawing.Color.Silver
        Me.txtUserName.WaterMarkText = "Enter Username"
        '
        'LoginInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(478, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents txtUserName As POS_System.WaterMarkTextBox
    Friend WithEvents txtPassword As POS_System.WaterMarkTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
