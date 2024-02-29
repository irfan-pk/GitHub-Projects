<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelTrans
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFromTrans = New System.Windows.Forms.TextBox
        Me.txtToTrans = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Transaction Date"
        '
        'dtpTransDate
        '
        Me.dtpTransDate.Location = New System.Drawing.Point(147, 11)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.Size = New System.Drawing.Size(188, 20)
        Me.dtpTransDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From Transaction #"
        '
        'txtFromTrans
        '
        Me.txtFromTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFromTrans.Location = New System.Drawing.Point(147, 40)
        Me.txtFromTrans.Name = "txtFromTrans"
        Me.txtFromTrans.Size = New System.Drawing.Size(94, 20)
        Me.txtFromTrans.TabIndex = 3
        Me.txtFromTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtToTrans
        '
        Me.txtToTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtToTrans.Location = New System.Drawing.Point(147, 70)
        Me.txtToTrans.Name = "txtToTrans"
        Me.txtToTrans.Size = New System.Drawing.Size(94, 20)
        Me.txtToTrans.TabIndex = 5
        Me.txtToTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To Transaction #"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtToTrans)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtFromTrans)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpTransDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 107)
        Me.Panel1.TabIndex = 6
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Location = New System.Drawing.Point(209, 117)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(80, 23)
        Me.cmdDelete.TabIndex = 7
        Me.cmdDelete.Text = "&Roll Back"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(295, 117)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(76, 23)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmDelTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(374, 145)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDelTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDelTrans"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTransDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFromTrans As System.Windows.Forms.TextBox
    Friend WithEvents txtToTrans As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
