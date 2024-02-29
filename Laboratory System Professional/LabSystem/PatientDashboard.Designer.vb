<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientDashboard))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgvP_Statistics = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvPendingRpt = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WeeklyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblPending = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblComplete = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.DataSet = New System.Data.DataSet
        Me.QueryTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WeeklyDataSet = New System.Data.DataSet
        Me.UpdateProcessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvP_Statistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPendingRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeeklyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeeklyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvP_Statistics)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(839, 493)
        Me.SplitContainer1.SplitterDistance = 365
        Me.SplitContainer1.TabIndex = 0
        '
        'dgvP_Statistics
        '
        Me.dgvP_Statistics.AllowUserToDeleteRows = False
        Me.dgvP_Statistics.AutoGenerateColumns = False
        Me.dgvP_Statistics.BackgroundColor = System.Drawing.Color.White
        Me.dgvP_Statistics.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvP_Statistics.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvP_Statistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvP_Statistics.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colPName, Me.colStatus})
        Me.dgvP_Statistics.DataSource = Me.BindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvP_Statistics.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvP_Statistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvP_Statistics.GridColor = System.Drawing.Color.Gray
        Me.dgvP_Statistics.Location = New System.Drawing.Point(0, 22)
        Me.dgvP_Statistics.Name = "dgvP_Statistics"
        Me.dgvP_Statistics.ReadOnly = True
        Me.dgvP_Statistics.RowHeadersVisible = False
        Me.dgvP_Statistics.Size = New System.Drawing.Size(363, 469)
        Me.dgvP_Statistics.TabIndex = 4
        '
        'colID
        '
        Me.colID.DataPropertyName = "p_num"
        Me.colID.HeaderText = "Patient ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colPName
        '
        Me.colPName.DataPropertyName = "p_name"
        Me.colPName.HeaderText = "Patient Name"
        Me.colPName.Name = "colPName"
        Me.colPName.ReadOnly = True
        Me.colPName.Width = 160
        '
        'colStatus
        '
        Me.colStatus.DataPropertyName = "p_status"
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(363, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Statistics"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPendingRpt)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 289)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pending Reports > Week"
        '
        'dgvPendingRpt
        '
        Me.dgvPendingRpt.AllowUserToDeleteRows = False
        Me.dgvPendingRpt.AutoGenerateColumns = False
        Me.dgvPendingRpt.BackgroundColor = System.Drawing.Color.White
        Me.dgvPendingRpt.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPendingRpt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPendingRpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendingRpt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.colDate})
        Me.dgvPendingRpt.DataSource = Me.WeeklyBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPendingRpt.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPendingRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPendingRpt.GridColor = System.Drawing.Color.Gray
        Me.dgvPendingRpt.Location = New System.Drawing.Point(3, 16)
        Me.dgvPendingRpt.Name = "dgvPendingRpt"
        Me.dgvPendingRpt.ReadOnly = True
        Me.dgvPendingRpt.RowHeadersVisible = False
        Me.dgvPendingRpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPendingRpt.Size = New System.Drawing.Size(430, 270)
        Me.dgvPendingRpt.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "p_num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "p_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Patient Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 229
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "p_date_sample"
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblPending)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(242, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 59)
        Me.Panel2.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(60, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pending Reports"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPending
        '
        Me.lblPending.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.ForeColor = System.Drawing.Color.White
        Me.lblPending.Location = New System.Drawing.Point(71, 7)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(130, 27)
        Me.lblPending.TabIndex = 7
        Me.lblPending.Text = "00"
        Me.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblComplete)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(242, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 59)
        Me.Panel1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Complete Reports"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblComplete
        '
        Me.lblComplete.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplete.ForeColor = System.Drawing.Color.White
        Me.lblComplete.Location = New System.Drawing.Point(71, 7)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(130, 27)
        Me.lblComplete.TabIndex = 7
        Me.lblComplete.Text = "00"
        Me.lblComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.IndianRed
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblTotal)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(16, 22)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 59)
        Me.Panel4.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(91, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Patients"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(71, 7)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(130, 27)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(468, 491)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 18
        Me.LineShape1.X2 = 451
        Me.LineShape1.Y1 = 175
        Me.LineShape1.Y2 = 175
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "NewDataSet"
        '
        'QueryTimer
        '
        '
        'WeeklyDataSet
        '
        Me.WeeklyDataSet.DataSetName = "NewDataSet"
        '
        'UpdateProcessTimer
        '
        Me.UpdateProcessTimer.Interval = 9000
        '
        'PatientDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 493)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PatientDashboard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Reports Dashboard"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvP_Statistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPendingRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeeklyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeeklyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvP_Statistics As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As System.Data.DataSet
    Friend WithEvents QueryTimer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblComplete As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPending As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPendingRpt As System.Windows.Forms.DataGridView
    Friend WithEvents WeeklyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WeeklyDataSet As System.Data.DataSet
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdateProcessTimer As System.Windows.Forms.Timer
End Class
