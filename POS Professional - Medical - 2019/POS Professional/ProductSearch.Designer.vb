<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductSearch))
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.txtCatg = New System.Windows.Forms.TextBox
        Me.txtSubCatg = New System.Windows.Forms.TextBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubCatg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRates = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.AllowUserToResizeColumns = False
        Me.ProductDataGridView.AllowUserToResizeRows = False
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.colSubCatg, Me.colRates})
        Me.ProductDataGridView.DataSource = Me.BindingSource1
        Me.ProductDataGridView.GridColor = System.Drawing.Color.Gray
        Me.ProductDataGridView.Location = New System.Drawing.Point(3, 26)
        Me.ProductDataGridView.MultiSelect = False
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(902, 396)
        Me.ProductDataGridView.TabIndex = 4
        Me.ProductDataGridView.TabStop = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "PRODUCTS"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "prod_code"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "prod_desc"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "category"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "prod_sub_category"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(3, 4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(101, 20)
        Me.txtCode.TabIndex = 13
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.LightGreen
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.Black
        Me.txtDesc.Location = New System.Drawing.Point(103, 4)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(301, 20)
        Me.txtDesc.TabIndex = 14
        '
        'txtCatg
        '
        Me.txtCatg.BackColor = System.Drawing.Color.LightGreen
        Me.txtCatg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatg.ForeColor = System.Drawing.Color.Black
        Me.txtCatg.Location = New System.Drawing.Point(403, 4)
        Me.txtCatg.Name = "txtCatg"
        Me.txtCatg.Size = New System.Drawing.Size(201, 20)
        Me.txtCatg.TabIndex = 15
        '
        'txtSubCatg
        '
        Me.txtSubCatg.BackColor = System.Drawing.Color.LightGreen
        Me.txtSubCatg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubCatg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCatg.ForeColor = System.Drawing.Color.Black
        Me.txtSubCatg.Location = New System.Drawing.Point(603, 4)
        Me.txtSubCatg.Name = "txtSubCatg"
        Me.txtSubCatg.Size = New System.Drawing.Size(302, 20)
        Me.txtSubCatg.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROD_CODE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PROD_DESC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PROD_CATG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'colSubCatg
        '
        Me.colSubCatg.DataPropertyName = "prod_sub_catg"
        Me.colSubCatg.HeaderText = "Brand"
        Me.colSubCatg.Name = "colSubCatg"
        Me.colSubCatg.ReadOnly = True
        Me.colSubCatg.Width = 200
        '
        'colRates
        '
        Me.colRates.DataPropertyName = "prod_sale_price"
        Me.colRates.HeaderText = "Price"
        Me.colRates.Name = "colRates"
        Me.colRates.ReadOnly = True
        '
        'ProductSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSubCatg)
        Me.Controls.Add(Me.txtCatg)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.ProductDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ProductSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Product"
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCatg As System.Windows.Forms.TextBox
    Friend WithEvents txtSubCatg As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubCatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRates As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
