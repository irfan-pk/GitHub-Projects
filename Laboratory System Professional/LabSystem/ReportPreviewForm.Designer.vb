<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPreviewForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewForm))
        Me.LabReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'LabReportViewer
        '
        Me.LabReportViewer.ActiveViewIndex = -1
        Me.LabReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabReportViewer.DisplayGroupTree = False
        Me.LabReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.LabReportViewer.Name = "LabReportViewer"
        Me.LabReportViewer.SelectionFormula = ""
        Me.LabReportViewer.ShowGroupTreeButton = False
        Me.LabReportViewer.ShowRefreshButton = False
        Me.LabReportViewer.Size = New System.Drawing.Size(1011, 576)
        Me.LabReportViewer.TabIndex = 0
        Me.LabReportViewer.ViewTimeSelectionFormula = ""
        '
        'ReportPreviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 576)
        Me.Controls.Add(Me.LabReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportPreviewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pathology Report Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
