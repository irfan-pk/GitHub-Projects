<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReferenceList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReferenceList))
        Me.ListBoxRefer = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'ListBoxRefer
        '
        Me.ListBoxRefer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBoxRefer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBoxRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxRefer.ForeColor = System.Drawing.Color.PaleGreen
        Me.ListBoxRefer.FormattingEnabled = True
        Me.ListBoxRefer.ItemHeight = 18
        Me.ListBoxRefer.Location = New System.Drawing.Point(10, 11)
        Me.ListBoxRefer.Name = "ListBoxRefer"
        Me.ListBoxRefer.Size = New System.Drawing.Size(418, 470)
        Me.ListBoxRefer.TabIndex = 1
        '
        'ReferenceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(438, 488)
        Me.Controls.Add(Me.ListBoxRefer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(444, 517)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(444, 517)
        Me.Name = "ReferenceList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "References List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxRefer As System.Windows.Forms.ListBox
End Class
