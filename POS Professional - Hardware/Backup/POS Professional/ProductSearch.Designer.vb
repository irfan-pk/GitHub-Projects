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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductSearch))
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.txtCatg = New System.Windows.Forms.TextBox
        Me.txtBrand = New System.Windows.Forms.TextBox
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubCatg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSize = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRates = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductDataGridView.ColumnHeadersHeight = 40
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.colSubCatg, Me.colSize, Me.colRates, Me.colWPrice, Me.colRetail})
        Me.ProductDataGridView.DataSource = Me.BindingSource1
        Me.ProductDataGridView.EnableHeadersVisualStyles = False
        Me.ProductDataGridView.GridColor = System.Drawing.Color.Gray
        Me.ProductDataGridView.Location = New System.Drawing.Point(3, 26)
        Me.ProductDataGridView.MultiSelect = False
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(1061, 396)
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
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.PaleGreen
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(3, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 13
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.PaleGreen
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.Black
        Me.txtDesc.Location = New System.Drawing.Point(103, 3)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(250, 20)
        Me.txtDesc.TabIndex = 14
        '
        'txtCatg
        '
        Me.txtCatg.BackColor = System.Drawing.Color.PaleGreen
        Me.txtCatg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatg.ForeColor = System.Drawing.Color.Black
        Me.txtCatg.Location = New System.Drawing.Point(353, 3)
        Me.txtCatg.Name = "txtCatg"
        Me.txtCatg.Size = New System.Drawing.Size(201, 20)
        Me.txtCatg.TabIndex = 15
        '
        'txtBrand
        '
        Me.txtBrand.BackColor = System.Drawing.Color.PaleGreen
        Me.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.ForeColor = System.Drawing.Color.Black
        Me.txtBrand.Location = New System.Drawing.Point(554, 3)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(150, 20)
        Me.txtBrand.TabIndex = 16
        '
        'txtSize
        '
        Me.txtSize.BackColor = System.Drawing.Color.PaleGreen
        Me.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.ForeColor = System.Drawing.Color.Black
        Me.txtSize.Location = New System.Drawing.Point(704, 3)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 20)
        Me.txtSize.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(809, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "<= Filters"
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
        Me.DataGridViewTextBoxColumn2.Width = 250
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
        Me.colSubCatg.DataPropertyName = "prod_brand"
        Me.colSubCatg.HeaderText = "Brand"
        Me.colSubCatg.Name = "colSubCatg"
        Me.colSubCatg.ReadOnly = True
        Me.colSubCatg.Width = 150
        '
        'colSize
        '
        Me.colSize.DataPropertyName = "prod_size"
        Me.colSize.HeaderText = "Size / Capacity"
        Me.colSize.Name = "colSize"
        Me.colSize.ReadOnly = True
        '
        'colRates
        '
        Me.colRates.DataPropertyName = "prod_purch_price"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colRates.DefaultCellStyle = DataGridViewCellStyle2
        Me.colRates.HeaderText = "Purch. Price"
        Me.colRates.Name = "colRates"
        Me.colRates.ReadOnly = True
        Me.colRates.Width = 80
        '
        'colWPrice
        '
        Me.colWPrice.DataPropertyName = "prod_wsale_price"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colWPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.colWPrice.HeaderText = "Whole Sale"
        Me.colWPrice.Name = "colWPrice"
        Me.colWPrice.ReadOnly = True
        Me.colWPrice.Width = 80
        '
        'colRetail
        '
        Me.colRetail.DataPropertyName = "prod_retail_price"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colRetail.DefaultCellStyle = DataGridViewCellStyle4
        Me.colRetail.HeaderText = "Retail Price"
        Me.colRetail.Name = "colRetail"
        Me.colRetail.ReadOnly = True
        Me.colRetail.Width = 80
        '
        'ProductSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtBrand)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCatg As System.Windows.Forms.TextBox
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubCatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSize As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRates As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRetail As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
