<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchInvoice
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchInvoice))
        Me.dgvSearch = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRates = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.AllowUserToResizeColumns = False
        Me.dgvSearch.AllowUserToResizeRows = False
        Me.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearch.ColumnHeadersHeight = 30
        Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colRates})
        Me.dgvSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSearch.GridColor = System.Drawing.Color.Gray
        Me.dgvSearch.Location = New System.Drawing.Point(0, 0)
        Me.dgvSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSearch.MultiSelect = False
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.RowHeadersVisible = False
        Me.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvSearch.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearch.Size = New System.Drawing.Size(256, 321)
        Me.dgvSearch.TabIndex = 0
        Me.dgvSearch.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "saleid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Invoice #"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'colRates
        '
        Me.colRates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colRates.DataPropertyName = "salepaid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colRates.DefaultCellStyle = DataGridViewCellStyle2
        Me.colRates.HeaderText = "Amount"
        Me.colRates.Name = "colRates"
        Me.colRates.ReadOnly = True
        '
        'SearchInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 321)
        Me.Controls.Add(Me.dgvSearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SearchInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Invoice"
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRates As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
