<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileList))
        Me.lboxFileName = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lboxFileName
        '
        Me.lboxFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lboxFileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lboxFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxFileName.FormattingEnabled = True
        Me.lboxFileName.ItemHeight = 16
        Me.lboxFileName.Location = New System.Drawing.Point(0, 0)
        Me.lboxFileName.Margin = New System.Windows.Forms.Padding(4)
        Me.lboxFileName.Name = "lboxFileName"
        Me.lboxFileName.Size = New System.Drawing.Size(356, 434)
        Me.lboxFileName.TabIndex = 0
        '
        'FileList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 436)
        Me.Controls.Add(Me.lboxFileName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FileList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports File Name"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lboxFileName As System.Windows.Forms.ListBox
End Class
