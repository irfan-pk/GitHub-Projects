<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockMenu))
        Me.Label1 = New System.Windows.Forms.Label
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdItemType = New System.Windows.Forms.Button
        Me.cmdStockReports = New System.Windows.Forms.Button
        Me.cmdDepart = New System.Windows.Forms.Button
        Me.cmdCatg = New System.Windows.Forms.Button
        Me.cmdViewPrch = New System.Windows.Forms.Button
        Me.cmdProd = New System.Windows.Forms.Button
        Me.cmdReturn = New System.Windows.Forms.Button
        Me.cmdQty = New System.Windows.Forms.Button
        Me.cmdPurchase = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Menu"
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Black
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 9
        Me.LineShape2.X2 = 570
        Me.LineShape2.Y1 = 43
        Me.LineShape2.Y2 = 43
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 9
        Me.LineShape1.X2 = 570
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(578, 450)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1000
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'cmdItemType
        '
        Me.cmdItemType.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdItemType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdItemType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdItemType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdItemType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdItemType.ForeColor = System.Drawing.Color.Yellow
        Me.cmdItemType.Image = Global.POS_Professional.My.Resources.Resources.Categories
        Me.cmdItemType.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdItemType.Location = New System.Drawing.Point(167, 65)
        Me.cmdItemType.Name = "cmdItemType"
        Me.cmdItemType.Size = New System.Drawing.Size(111, 110)
        Me.cmdItemType.TabIndex = 8
        Me.cmdItemType.Text = "Category"
        Me.cmdItemType.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdItemType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdItemType, "Add / Update Categories")
        Me.cmdItemType.UseVisualStyleBackColor = False
        '
        'cmdStockReports
        '
        Me.cmdStockReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdStockReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdStockReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdStockReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdStockReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStockReports.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStockReports.ForeColor = System.Drawing.Color.Yellow
        Me.cmdStockReports.Image = Global.POS_Professional.My.Resources.Resources.Medical_invoice_information_64
        Me.cmdStockReports.Location = New System.Drawing.Point(31, 323)
        Me.cmdStockReports.Name = "cmdStockReports"
        Me.cmdStockReports.Size = New System.Drawing.Size(111, 110)
        Me.cmdStockReports.TabIndex = 7
        Me.cmdStockReports.Text = "&Stock Reports"
        Me.cmdStockReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdStockReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdStockReports, "Check Current Stock Position")
        Me.cmdStockReports.UseVisualStyleBackColor = False
        '
        'cmdDepart
        '
        Me.cmdDepart.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDepart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDepart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDepart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDepart.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDepart.ForeColor = System.Drawing.Color.Yellow
        Me.cmdDepart.Image = Global.POS_Professional.My.Resources.Resources._1489263950_handle4
        Me.cmdDepart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDepart.Location = New System.Drawing.Point(31, 65)
        Me.cmdDepart.Name = "cmdDepart"
        Me.cmdDepart.Size = New System.Drawing.Size(111, 110)
        Me.cmdDepart.TabIndex = 0
        Me.cmdDepart.Text = "Product Head"
        Me.cmdDepart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDepart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdDepart, "Add / Update Department")
        Me.cmdDepart.UseVisualStyleBackColor = False
        '
        'cmdCatg
        '
        Me.cmdCatg.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCatg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCatg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCatg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdCatg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCatg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCatg.ForeColor = System.Drawing.Color.Yellow
        Me.cmdCatg.Image = Global.POS_Professional.My.Resources.Resources._1480380686_benchmarking
        Me.cmdCatg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCatg.Location = New System.Drawing.Point(303, 65)
        Me.cmdCatg.Name = "cmdCatg"
        Me.cmdCatg.Size = New System.Drawing.Size(111, 110)
        Me.cmdCatg.TabIndex = 1
        Me.cmdCatg.Text = "&Product Group"
        Me.cmdCatg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCatg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdCatg, "Add / Update Product Type")
        Me.cmdCatg.UseVisualStyleBackColor = False
        '
        'cmdViewPrch
        '
        Me.cmdViewPrch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdViewPrch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdViewPrch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdViewPrch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdViewPrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewPrch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewPrch.ForeColor = System.Drawing.Color.Yellow
        Me.cmdViewPrch.Image = Global.POS_Professional.My.Resources.Resources.Billboard_64
        Me.cmdViewPrch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdViewPrch.Location = New System.Drawing.Point(303, 198)
        Me.cmdViewPrch.Name = "cmdViewPrch"
        Me.cmdViewPrch.Size = New System.Drawing.Size(111, 110)
        Me.cmdViewPrch.TabIndex = 5
        Me.cmdViewPrch.Text = "&View Purchases"
        Me.cmdViewPrch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdViewPrch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdViewPrch, "View Purchases from Supplier")
        Me.cmdViewPrch.UseVisualStyleBackColor = False
        '
        'cmdProd
        '
        Me.cmdProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProd.ForeColor = System.Drawing.Color.Yellow
        Me.cmdProd.Image = Global.POS_Professional.My.Resources.Resources._1480380241_palet02
        Me.cmdProd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdProd.Location = New System.Drawing.Point(440, 65)
        Me.cmdProd.Name = "cmdProd"
        Me.cmdProd.Size = New System.Drawing.Size(111, 110)
        Me.cmdProd.TabIndex = 2
        Me.cmdProd.Text = "Register Pro&duct"
        Me.cmdProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdProd, "Add / Update Products")
        Me.cmdProd.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReturn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.Color.Yellow
        Me.cmdReturn.Image = Global.POS_Professional.My.Resources.Resources.basket_icon
        Me.cmdReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReturn.Location = New System.Drawing.Point(167, 198)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(111, 110)
        Me.cmdReturn.TabIndex = 4
        Me.cmdReturn.Text = "Purchase &Return"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdReturn, "Purchases Return to Supplier")
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'cmdQty
        '
        Me.cmdQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdQty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdQty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdQty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQty.ForeColor = System.Drawing.Color.Yellow
        Me.cmdQty.Image = Global.POS_Professional.My.Resources.Resources._1480381704_column_chart
        Me.cmdQty.Location = New System.Drawing.Point(440, 198)
        Me.cmdQty.Name = "cmdQty"
        Me.cmdQty.Size = New System.Drawing.Size(111, 110)
        Me.cmdQty.TabIndex = 6
        Me.cmdQty.Text = "&Stock Position"
        Me.cmdQty.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdQty, "Check Current Stock Position")
        Me.cmdQty.UseVisualStyleBackColor = False
        '
        'cmdPurchase
        '
        Me.cmdPurchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPurchase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPurchase.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPurchase.ForeColor = System.Drawing.Color.Yellow
        Me.cmdPurchase.Image = Global.POS_Professional.My.Resources.Resources.shopping_cart_full_icon
        Me.cmdPurchase.Location = New System.Drawing.Point(31, 198)
        Me.cmdPurchase.Name = "cmdPurchase"
        Me.cmdPurchase.Size = New System.Drawing.Size(111, 110)
        Me.cmdPurchase.TabIndex = 3
        Me.cmdPurchase.Text = "&Purchases"
        Me.cmdPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdPurchase, "Purchases from Supplier")
        Me.cmdPurchase.UseVisualStyleBackColor = False
        '
        'StockMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(578, 450)
        Me.Controls.Add(Me.cmdItemType)
        Me.Controls.Add(Me.cmdStockReports)
        Me.Controls.Add(Me.cmdDepart)
        Me.Controls.Add(Me.cmdCatg)
        Me.Controls.Add(Me.cmdViewPrch)
        Me.Controls.Add(Me.cmdProd)
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.cmdQty)
        Me.Controls.Add(Me.cmdPurchase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StockMenu"
        Me.Text = "Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents cmdPurchase As System.Windows.Forms.Button
    Friend WithEvents cmdQty As System.Windows.Forms.Button
    Friend WithEvents cmdReturn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdProd As System.Windows.Forms.Button
    Friend WithEvents cmdViewPrch As System.Windows.Forms.Button
    Friend WithEvents cmdCatg As System.Windows.Forms.Button
    Friend WithEvents cmdDepart As System.Windows.Forms.Button
    Friend WithEvents cmdStockReports As System.Windows.Forms.Button
    Friend WithEvents cmdItemType As System.Windows.Forms.Button
End Class
