<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExtendDescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExtendDescription))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Description"
        '
        'txtDesc
        '
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(140, 16)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(270, 22)
        Me.txtDesc.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(140, 55)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(112, 22)
        Me.txtPrice.TabIndex = 3
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Price"
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(429, 15)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 31)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(429, 52)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 30)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ExtendDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 95)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExtendDescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extend Description"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
