<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabInfo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLabName = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPathologist = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTel1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTel2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMob2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMob1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laboratory Name"
        '
        'txtLabName
        '
        Me.txtLabName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabName.Location = New System.Drawing.Point(159, 30)
        Me.txtLabName.Name = "txtLabName"
        Me.txtLabName.Size = New System.Drawing.Size(506, 21)
        Me.txtLabName.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(159, 66)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(506, 21)
        Me.txtAddress.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Laboratory Address"
        '
        'txtPathologist
        '
        Me.txtPathologist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPathologist.Location = New System.Drawing.Point(159, 101)
        Me.txtPathologist.Name = "txtPathologist"
        Me.txtPathologist.Size = New System.Drawing.Size(506, 21)
        Me.txtPathologist.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pathologist Name"
        '
        'txtTel1
        '
        Me.txtTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel1.Location = New System.Drawing.Point(159, 135)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(150, 21)
        Me.txtTel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Primary Tel #"
        '
        'txtTel2
        '
        Me.txtTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel2.Location = New System.Drawing.Point(159, 169)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(150, 21)
        Me.txtTel2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Secondary Tel #"
        '
        'txtMob2
        '
        Me.txtMob2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMob2.Location = New System.Drawing.Point(159, 237)
        Me.txtMob2.Name = "txtMob2"
        Me.txtMob2.Size = New System.Drawing.Size(150, 21)
        Me.txtMob2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Secondary Cell #"
        '
        'txtMob1
        '
        Me.txtMob1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMob1.Location = New System.Drawing.Point(159, 202)
        Me.txtMob1.Name = "txtMob1"
        Me.txtMob1.Size = New System.Drawing.Size(150, 21)
        Me.txtMob1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Primary Cell #"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdate.Image = Global.Business_Solutions.My.Resources.Resources.data_add
        Me.cmdUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUpdate.Location = New System.Drawing.Point(570, 169)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(94, 39)
        Me.cmdUpdate.TabIndex = 8
        Me.cmdUpdate.Text = "&Update"
        Me.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.Gnome_Application_Exit_64
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(570, 219)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(94, 39)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "&Exit"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmLabInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 286)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtMob2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMob1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPathologist)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLabName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLabInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt Heading Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLabName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPathologist As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTel1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTel2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMob2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMob1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
