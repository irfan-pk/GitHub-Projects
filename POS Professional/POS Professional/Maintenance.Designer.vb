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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maintenance))
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdCompany = New System.Windows.Forms.Button
        Me.cmdBackup = New System.Windows.Forms.Button
        Me.cmdUsers = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Image = Global.POS_Professional.My.Resources.Resources._1487899091_ordering
        Me.Button1.Location = New System.Drawing.Point(156, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 110)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Edit Invoice"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdCompany
        '
        Me.cmdCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCompany.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCompany.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompany.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompany.ForeColor = System.Drawing.Color.Yellow
        Me.cmdCompany.Image = Global.POS_Professional.My.Resources.Resources.Billboard_641
        Me.cmdCompany.Location = New System.Drawing.Point(295, 18)
        Me.cmdCompany.Name = "cmdCompany"
        Me.cmdCompany.Size = New System.Drawing.Size(111, 110)
        Me.cmdCompany.TabIndex = 3
        Me.cmdCompany.Text = "Company Info."
        Me.cmdCompany.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCompany.UseVisualStyleBackColor = False
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
        Me.cmdBackup.Image = Global.POS_Professional.My.Resources.Resources.Misc_New_Database_icon
        Me.cmdBackup.Location = New System.Drawing.Point(435, 18)
        Me.cmdBackup.Name = "cmdBackup"
        Me.cmdBackup.Size = New System.Drawing.Size(111, 110)
        Me.cmdBackup.TabIndex = 4
        Me.cmdBackup.Text = "&Backup"
        Me.cmdBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdBackup.UseVisualStyleBackColor = False
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
        Me.cmdUsers.Image = Global.POS_Professional.My.Resources.Resources.Admin_icon_72
        Me.cmdUsers.Location = New System.Drawing.Point(17, 18)
        Me.cmdUsers.Name = "cmdUsers"
        Me.cmdUsers.Size = New System.Drawing.Size(111, 110)
        Me.cmdUsers.TabIndex = 0
        Me.cmdUsers.Text = "&Users"
        Me.cmdUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUsers.UseVisualStyleBackColor = False
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(562, 146)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdCompany)
        Me.Controls.Add(Me.cmdBackup)
        Me.Controls.Add(Me.cmdUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Maintenance"
        Me.Text = "Maintenance"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdUsers As System.Windows.Forms.Button
    Friend WithEvents cmdCompany As System.Windows.Forms.Button
    Friend WithEvents cmdBackup As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
