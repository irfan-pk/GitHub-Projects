<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportFile))
        Me.cmbRptCode = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmbRptCode
        '
        Me.cmbRptCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbRptCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbRptCode.FormattingEnabled = True
        Me.cmbRptCode.Location = New System.Drawing.Point(0, 0)
        Me.cmbRptCode.Name = "cmbRptCode"
        Me.cmbRptCode.Size = New System.Drawing.Size(340, 376)
        Me.cmbRptCode.TabIndex = 0
        '
        'ReportFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 376)
        Me.Controls.Add(Me.cmbRptCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ReportFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report File Name"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbRptCode As System.Windows.Forms.ComboBox
End Class
