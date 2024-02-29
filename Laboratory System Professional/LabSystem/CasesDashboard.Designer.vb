<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CasesDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CasesDashboard))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.colParameter = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.CrystalReportViewer)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdPrint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(884, 661)
        Me.SplitContainer1.SplitterDistance = 471
        Me.SplitContainer1.TabIndex = 0
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.AutoScroll = True
        Me.CrystalReportViewer.AutoSize = True
        Me.CrystalReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.DisplayGroupTree = False
        Me.CrystalReportViewer.DisplayStatusBar = False
        Me.CrystalReportViewer.DisplayToolbar = False
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.Size = New System.Drawing.Size(884, 471)
        Me.CrystalReportViewer.TabIndex = 0
        Me.CrystalReportViewer.ViewTimeSelectionFormula = ""
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.Delete
        Me.cmdClose.Location = New System.Drawing.Point(776, 138)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 36)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = Global.Business_Solutions.My.Resources.Resources.print_icon
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(776, 96)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(96, 36)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeColumns = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colParameter, Me.colCount})
        Me.DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(669, 180)
        Me.DataGridView.TabIndex = 0
        '
        'colParameter
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen
        Me.colParameter.DefaultCellStyle = DataGridViewCellStyle2
        Me.colParameter.HeaderText = "Parameter"
        Me.colParameter.Name = "colParameter"
        Me.colParameter.ReadOnly = True
        Me.colParameter.Width = 400
        '
        'colCount
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.colCount.DefaultCellStyle = DataGridViewCellStyle3
        Me.colCount.HeaderText = "Total Cases"
        Me.colCount.Name = "colCount"
        Me.colCount.ReadOnly = True
        Me.colCount.Width = 225
        '
        'CasesDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "CasesDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cases Dashboard"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents colParameter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
