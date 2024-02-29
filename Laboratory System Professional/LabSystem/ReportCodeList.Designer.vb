<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportCodeList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportCodeList))
        Me.cmbTestName = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmbTestName
        '
        Me.cmbTestName.BackColor = System.Drawing.Color.White
        Me.cmbTestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTestName.ForeColor = System.Drawing.Color.Blue
        Me.cmbTestName.FormattingEnabled = True
        Me.cmbTestName.Location = New System.Drawing.Point(-1, -1)
        Me.cmbTestName.Name = "cmbTestName"
        Me.cmbTestName.Size = New System.Drawing.Size(438, 441)
        Me.cmbTestName.Sorted = True
        Me.cmbTestName.TabIndex = 1
        '
        'ReportCodeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 438)
        Me.Controls.Add(Me.cmbTestName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ReportCodeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportCodeList"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbTestName As System.Windows.Forms.ComboBox
End Class
