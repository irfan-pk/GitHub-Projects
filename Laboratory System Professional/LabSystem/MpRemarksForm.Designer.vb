<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MpRemarksForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.RmkDataGrid = New System.Windows.Forms.DataGridView
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RmkMenuStrip = New System.Windows.Forms.MenuStrip
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.DataTable1 = New System.Data.DataTable
        Me.SplitContainer = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.RmkDataSet = New System.Data.DataSet
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RmkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colRmkCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.RmkDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RmkMenuStrip.SuspendLayout()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.RmkDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Remark Status"
        '
        'RmkDataGrid
        '
        Me.RmkDataGrid.AllowUserToAddRows = False
        Me.RmkDataGrid.AllowUserToDeleteRows = False
        Me.RmkDataGrid.AllowUserToResizeColumns = False
        Me.RmkDataGrid.AllowUserToResizeRows = False
        Me.RmkDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.RmkDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RmkDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.RmkDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RmkDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRmkCode, Me.colDescription, Me.colCategory})
        Me.RmkDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RmkDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.RmkDataGrid.Name = "RmkDataGrid"
        Me.RmkDataGrid.ReadOnly = True
        Me.RmkDataGrid.RowHeadersVisible = False
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RmkDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.RmkDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RmkDataGrid.Size = New System.Drawing.Size(711, 306)
        Me.RmkDataGrid.TabIndex = 0
        Me.RmkDataGrid.TabStop = False
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.search
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.FindToolStripMenuItem.Text = "&Find"
        Me.FindToolStripMenuItem.ToolTipText = "Find remark for edit or view"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Add_record1
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(90, 21)
        Me.AddNewToolStripMenuItem.Text = "&Add New"
        Me.AddNewToolStripMenuItem.ToolTipText = "Add new remark in the list"
        '
        'RmkMenuStrip
        '
        Me.RmkMenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RmkMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem, Me.AddNewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.RmkMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.RmkMenuStrip.Name = "RmkMenuStrip"
        Me.RmkMenuStrip.Size = New System.Drawing.Size(713, 25)
        Me.RmkMenuStrip.TabIndex = 100
        Me.RmkMenuStrip.Text = "MenuStrip"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.data_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.ToolTipText = "Changes in the remark"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        Me.DeleteToolStripMenuItem.ToolTipText = "Delete remark from the list"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Save
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.SaveToolStripMenuItem.Text = "&Save"
        Me.SaveToolStripMenuItem.ToolTipText = "Save the remark"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.Business_Solutions.My.Resources.Resources.Gnome_Application_Exit_64
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.CloseToolStripMenuItem.Text = "&Close"
        Me.CloseToolStripMenuItem.ToolTipText = "Close remark window"
        '
        'cmbCategory
        '
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"NEGATIVE", "POSITIVE"})
        Me.cmbCategory.Location = New System.Drawing.Point(487, 14)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(209, 23)
        Me.cmbCategory.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(102, 50)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(595, 71)
        Me.txtDescription.TabIndex = 3
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "RPT_REMARKS"
        '
        'SplitContainer
        '
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.RmkDataGrid)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer.Panel2.Controls.Add(Me.cmbCategory)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtDescription)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel2.Controls.Add(Me.txtCode)
        Me.SplitContainer.Panel2.Enabled = False
        Me.SplitContainer.Size = New System.Drawing.Size(713, 450)
        Me.SplitContainer.SplitterDistance = 308
        Me.SplitContainer.TabIndex = 101
        Me.SplitContainer.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MP Code"
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(102, 15)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(131, 21)
        Me.txtCode.TabIndex = 1
        '
        'RmkDataSet
        '
        Me.RmkDataSet.DataSetName = "NewDataSet"
        Me.RmkDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Tip"
        '
        'colRmkCode
        '
        Me.colRmkCode.DataPropertyName = "MP_CODE"
        Me.colRmkCode.HeaderText = "Mp Code"
        Me.colRmkCode.Name = "colRmkCode"
        Me.colRmkCode.ReadOnly = True
        Me.colRmkCode.Width = 125
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "MP_RESULT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 430
        '
        'colCategory
        '
        Me.colCategory.DataPropertyName = "MP_STATUS"
        Me.colCategory.HeaderText = "Status"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.ReadOnly = True
        Me.colCategory.Width = 155
        '
        'MpRemarksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 475)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.RmkMenuStrip)
        Me.MaximumSize = New System.Drawing.Size(729, 514)
        Me.MinimumSize = New System.Drawing.Size(729, 514)
        Me.Name = "MpRemarksForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MP Remarks List"
        CType(Me.RmkDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RmkMenuStrip.ResumeLayout(False)
        Me.RmkMenuStrip.PerformLayout()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.RmkDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RmkDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RmkMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents RmkDataSet As System.Data.DataSet
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents RmkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colRmkCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCategory As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
