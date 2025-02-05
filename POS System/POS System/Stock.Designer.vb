<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Me.cmdMin = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdViewPrch = New System.Windows.Forms.Button
        Me.cmdProd = New System.Windows.Forms.Button
        Me.cmdReturn = New System.Windows.Forms.Button
        Me.cmdQty = New System.Windows.Forms.Button
        Me.cmdPurchase = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdMin
        '
        Me.cmdMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMin.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdMin.Location = New System.Drawing.Point(511, 4)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(29, 34)
        Me.cmdMin.TabIndex = 3
        Me.cmdMin.TabStop = False
        Me.cmdMin.Text = "----"
        Me.cmdMin.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdClose.Location = New System.Drawing.Point(542, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(31, 34)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.UseVisualStyleBackColor = False
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(583, 336)
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
        'cmdViewPrch
        '
        Me.cmdViewPrch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdViewPrch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdViewPrch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdViewPrch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdViewPrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewPrch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewPrch.ForeColor = System.Drawing.Color.Yellow
        Me.cmdViewPrch.Image = Global.POS_System.My.Resources.Resources.Billboard_64
        Me.cmdViewPrch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdViewPrch.Location = New System.Drawing.Point(158, 199)
        Me.cmdViewPrch.Name = "cmdViewPrch"
        Me.cmdViewPrch.Size = New System.Drawing.Size(111, 110)
        Me.cmdViewPrch.TabIndex = 5
        Me.cmdViewPrch.Text = "&View Purchases"
        Me.cmdViewPrch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.cmdProd.Image = Global.POS_System.My.Resources.Resources._1480381800_palet02
        Me.cmdProd.Location = New System.Drawing.Point(294, 61)
        Me.cmdProd.Name = "cmdProd"
        Me.cmdProd.Size = New System.Drawing.Size(111, 110)
        Me.cmdProd.TabIndex = 2
        Me.cmdProd.Text = "Edit &Pro&ducts"
        Me.cmdProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdProd, "Update Product Data")
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
        Me.cmdReturn.Image = Global.POS_System.My.Resources.Resources.basket_icon
        Me.cmdReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReturn.Location = New System.Drawing.Point(24, 199)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(111, 110)
        Me.cmdReturn.TabIndex = 4
        Me.cmdReturn.Text = "Purchase &Return"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.cmdQty.Image = Global.POS_System.My.Resources.Resources._1480380353_self21
        Me.cmdQty.Location = New System.Drawing.Point(24, 61)
        Me.cmdQty.Name = "cmdQty"
        Me.cmdQty.Size = New System.Drawing.Size(111, 110)
        Me.cmdQty.TabIndex = 0
        Me.cmdQty.Text = "&Stock Position"
        Me.cmdQty.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.cmdPurchase.Image = Global.POS_System.My.Resources.Resources.shopping_cart_full_icon
        Me.cmdPurchase.Location = New System.Drawing.Point(429, 61)
        Me.cmdPurchase.Name = "cmdPurchase"
        Me.cmdPurchase.Size = New System.Drawing.Size(111, 110)
        Me.cmdPurchase.TabIndex = 3
        Me.cmdPurchase.Text = "&Purchases"
        Me.cmdPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdPurchase, "Purchases from Supplier")
        Me.cmdPurchase.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Image = Global.POS_System.My.Resources.Resources._1480380353_self21
        Me.Button1.Location = New System.Drawing.Point(158, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 110)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Stock Position"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Check Current Stock Position")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(583, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdViewPrch)
        Me.Controls.Add(Me.cmdProd)
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.cmdQty)
        Me.Controls.Add(Me.cmdPurchase)
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Stock"
        Me.Text = "Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
