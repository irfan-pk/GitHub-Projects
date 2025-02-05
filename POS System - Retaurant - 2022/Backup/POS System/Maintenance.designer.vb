<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance
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
        Me.cmdBackup = New System.Windows.Forms.Button
        Me.cmdWaiters = New System.Windows.Forms.Button
        Me.cmdUsers = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdBackup
        '
        Me.cmdBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBackup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBackup.ForeColor = System.Drawing.Color.Yellow
        Me.cmdBackup.Image = Global.POS_System.My.Resources.Resources.Misc_New_Database_icon
        Me.cmdBackup.Location = New System.Drawing.Point(298, 14)
        Me.cmdBackup.Name = "cmdBackup"
        Me.cmdBackup.Size = New System.Drawing.Size(111, 110)
        Me.cmdBackup.TabIndex = 3
        Me.cmdBackup.Text = "&Backup"
        Me.cmdBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBackup.UseVisualStyleBackColor = False
        '
        'cmdWaiters
        '
        Me.cmdWaiters.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdWaiters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdWaiters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdWaiters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdWaiters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdWaiters.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWaiters.ForeColor = System.Drawing.Color.Yellow
        Me.cmdWaiters.Image = Global.POS_System.My.Resources.Resources.User_Files_icon
        Me.cmdWaiters.Location = New System.Drawing.Point(158, 14)
        Me.cmdWaiters.Name = "cmdWaiters"
        Me.cmdWaiters.Size = New System.Drawing.Size(111, 110)
        Me.cmdWaiters.TabIndex = 2
        Me.cmdWaiters.Text = "&Waiters"
        Me.cmdWaiters.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdWaiters.UseVisualStyleBackColor = False
        '
        'cmdUsers
        '
        Me.cmdUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUsers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUsers.ForeColor = System.Drawing.Color.Yellow
        Me.cmdUsers.Image = Global.POS_System.My.Resources.Resources.Admin_icon
        Me.cmdUsers.Location = New System.Drawing.Point(16, 14)
        Me.cmdUsers.Name = "cmdUsers"
        Me.cmdUsers.Size = New System.Drawing.Size(111, 110)
        Me.cmdUsers.TabIndex = 1
        Me.cmdUsers.Text = "&Users"
        Me.cmdUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdUsers.UseVisualStyleBackColor = False
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(427, 146)
        Me.Controls.Add(Me.cmdWaiters)
        Me.Controls.Add(Me.cmdBackup)
        Me.Controls.Add(Me.cmdUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Maintenance"
        Me.Text = "Maintenance"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdUsers As System.Windows.Forms.Button
    Friend WithEvents cmdWaiters As System.Windows.Forms.Button
    Friend WithEvents cmdBackup As System.Windows.Forms.Button
End Class
