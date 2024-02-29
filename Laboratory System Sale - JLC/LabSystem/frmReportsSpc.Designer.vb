<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsSpc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportsSpc))
        Me.CrystalReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReport
        '
        Me.CrystalReport.ActiveViewIndex = -1
        Me.CrystalReport.AutoScroll = True
        Me.CrystalReport.AutoSize = True
        Me.CrystalReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CrystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReport.DisplayGroupTree = False
        Me.CrystalReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReport.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReport.Name = "CrystalReport"
        Me.CrystalReport.SelectionFormula = ""
        Me.CrystalReport.ShowGroupTreeButton = False
        Me.CrystalReport.ShowRefreshButton = False
        Me.CrystalReport.ShowTextSearchButton = False
        Me.CrystalReport.Size = New System.Drawing.Size(770, 493)
        Me.CrystalReport.TabIndex = 0
        Me.CrystalReport.TabStop = False
        Me.CrystalReport.ViewTimeSelectionFormula = ""
        '
        'frmReportsSpc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 493)
        Me.Controls.Add(Me.CrystalReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportsSpc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
