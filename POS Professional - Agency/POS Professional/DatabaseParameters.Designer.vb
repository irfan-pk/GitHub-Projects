<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseParameters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseParameters))
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdCreate = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPath = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Location = New System.Drawing.Point(173, 90)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(67, 22)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdCreate
        '
        Me.cmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCreate.Location = New System.Drawing.Point(100, 90)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(67, 22)
        Me.cmdCreate.TabIndex = 2
        Me.cmdCreate.Text = "&Create"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 76)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'txtPath
        '
        Me.txtPath.FormattingEnabled = True
        Me.txtPath.Location = New System.Drawing.Point(13, 36)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(205, 21)
        Me.txtPath.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Drive"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DatabaseParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 123)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.cmdExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatabaseParameters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.ComboBox
End Class
