<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsList
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsList))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel
        Me.PathologyReporsList = New System.Windows.Forms.ListView
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PathologyReporsList)
        Me.SplitContainer1.Size = New System.Drawing.Size(932, 475)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.TabIndex = 0
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(932, 109)
        Me.FlowLayoutPanel.TabIndex = 0
        '
        'PathologyReporsList
        '
        Me.PathologyReporsList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PathologyReporsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PathologyReporsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PathologyReporsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.PathologyReporsList.LargeImageList = Me.ImageList
        Me.PathologyReporsList.Location = New System.Drawing.Point(0, 0)
        Me.PathologyReporsList.Name = "PathologyReporsList"
        Me.PathologyReporsList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PathologyReporsList.Size = New System.Drawing.Size(932, 362)
        Me.PathologyReporsList.SmallImageList = Me.ImageList
        Me.PathologyReporsList.StateImageList = Me.ImageList
        Me.PathologyReporsList.TabIndex = 0
        Me.PathologyReporsList.TileSize = New System.Drawing.Size(400, 200)
        Me.PathologyReporsList.UseCompatibleStateImageBehavior = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "Edit-64.png")
        Me.ImageList.Images.SetKeyName(1, "PatientFile.png")
        '
        'frmReportsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 475)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReportsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pathology Reports"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents PathologyReporsList As System.Windows.Forms.ListView
    Friend WithEvents FlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
