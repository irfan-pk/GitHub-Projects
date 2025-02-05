<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Expenses))
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbAmount = New System.Windows.Forms.TextBox
        Me.tbDesc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Expense Amount"
        '
        'tbAmount
        '
        Me.tbAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAmount.Location = New System.Drawing.Point(174, 23)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(184, 29)
        Me.tbAmount.TabIndex = 2
        Me.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbDesc
        '
        Me.tbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDesc.Location = New System.Drawing.Point(174, 65)
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.Size = New System.Drawing.Size(402, 29)
        Me.tbDesc.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Description"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.POS_Professional.My.Resources.Resources.exit_24
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(489, 116)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 39)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.POS_Professional.My.Resources.Resources.save_24px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(398, 116)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 39)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Expenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 183)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbDesc)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Expenses"
        Me.Text = "Daily Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
