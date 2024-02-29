<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillReport
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
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.DisplayGroupTree = False
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.ShowGroupTreeButton = False
        Me.CrystalReportViewer.Size = New System.Drawing.Size(689, 465)
        Me.CrystalReportViewer.TabIndex = 0
        Me.CrystalReportViewer.ViewTimeSelectionFormula = ""
        '
        'frmBillReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 465)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Name = "frmBillReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Statement"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
