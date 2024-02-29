<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultipleStone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultipleStone))
        Me.txtStones = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtStones
        '
        Me.txtStones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStones.Location = New System.Drawing.Point(0, 0)
        Me.txtStones.Multiline = True
        Me.txtStones.Name = "txtStones"
        Me.txtStones.Size = New System.Drawing.Size(262, 142)
        Me.txtStones.TabIndex = 0
        '
        'MultipleStone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 142)
        Me.Controls.Add(Me.txtStones)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MultipleStone"
        Me.Text = "MultipleStone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStones As System.Windows.Forms.TextBox
End Class
