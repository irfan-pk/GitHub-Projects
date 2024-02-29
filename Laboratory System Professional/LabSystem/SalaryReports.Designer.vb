<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalaryReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalaryReports))
        Me.crvSalaryReports = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvSalaryReports
        '
        Me.crvSalaryReports.ActiveViewIndex = -1
        Me.crvSalaryReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvSalaryReports.DisplayGroupTree = False
        Me.crvSalaryReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvSalaryReports.Location = New System.Drawing.Point(0, 0)
        Me.crvSalaryReports.Name = "crvSalaryReports"
        Me.crvSalaryReports.SelectionFormula = ""
        Me.crvSalaryReports.ShowGroupTreeButton = False
        Me.crvSalaryReports.Size = New System.Drawing.Size(1095, 520)
        Me.crvSalaryReports.TabIndex = 0
        Me.crvSalaryReports.ViewTimeSelectionFormula = ""
        '
        'SalaryReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 520)
        Me.Controls.Add(Me.crvSalaryReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SalaryReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalaryReports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvSalaryReports As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
