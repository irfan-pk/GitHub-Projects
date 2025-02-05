<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdViewSale = New System.Windows.Forms.Button
        Me.cmdUsers = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdSale = New System.Windows.Forms.Button
        Me.cmdProduct = New System.Windows.Forms.Button
        Me.cmdMin = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmdViewSale)
        Me.Panel1.Controls.Add(Me.cmdUsers)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.cmdExit)
        Me.Panel1.Controls.Add(Me.cmdSale)
        Me.Panel1.Controls.Add(Me.cmdProduct)
        Me.Panel1.Controls.Add(Me.cmdMin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1274, 111)
        Me.Panel1.TabIndex = 1
        '
        'cmdViewSale
        '
        Me.cmdViewSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdViewSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdViewSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdViewSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdViewSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdViewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewSale.ForeColor = System.Drawing.Color.Yellow
        Me.cmdViewSale.Image = Global.POS_System.My.Resources.Resources.Money_Bag_642
        Me.cmdViewSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdViewSale.Location = New System.Drawing.Point(110, 9)
        Me.cmdViewSale.Name = "cmdViewSale"
        Me.cmdViewSale.Size = New System.Drawing.Size(99, 93)
        Me.cmdViewSale.TabIndex = 1
        Me.cmdViewSale.TabStop = False
        Me.cmdViewSale.Text = "V&iew Sale"
        Me.cmdViewSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdViewSale.UseVisualStyleBackColor = False
        '
        'cmdUsers
        '
        Me.cmdUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUsers.ForeColor = System.Drawing.Color.Yellow
        Me.cmdUsers.Image = Global.POS_System.My.Resources.Resources.Admin_icon
        Me.cmdUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdUsers.Location = New System.Drawing.Point(316, 9)
        Me.cmdUsers.Name = "cmdUsers"
        Me.cmdUsers.Size = New System.Drawing.Size(99, 93)
        Me.cmdUsers.TabIndex = 5
        Me.cmdUsers.TabStop = False
        Me.cmdUsers.Text = "&Users"
        Me.cmdUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdUsers.UseVisualStyleBackColor = False
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
        Me.cmdClose.Location = New System.Drawing.Point(1237, 8)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(31, 34)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Yellow
        Me.cmdExit.Image = Global.POS_System.My.Resources.Resources._1480381921_exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdExit.Location = New System.Drawing.Point(419, 9)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(99, 93)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.TabStop = False
        Me.cmdExit.Text = "&Quit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdSale
        '
        Me.cmdSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSale.ForeColor = System.Drawing.Color.Yellow
        Me.cmdSale.Image = Global.POS_System.My.Resources.Resources.Cash_register_72px_510913_easyicon
        Me.cmdSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSale.Location = New System.Drawing.Point(7, 9)
        Me.cmdSale.Name = "cmdSale"
        Me.cmdSale.Size = New System.Drawing.Size(99, 93)
        Me.cmdSale.TabIndex = 0
        Me.cmdSale.TabStop = False
        Me.cmdSale.Text = "&Sale"
        Me.cmdSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSale.UseVisualStyleBackColor = False
        '
        'cmdProduct
        '
        Me.cmdProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProduct.ForeColor = System.Drawing.Color.Yellow
        Me.cmdProduct.Image = Global.POS_System.My.Resources.Resources._1480382641_palet04
        Me.cmdProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdProduct.Location = New System.Drawing.Point(213, 9)
        Me.cmdProduct.Name = "cmdProduct"
        Me.cmdProduct.Size = New System.Drawing.Size(99, 93)
        Me.cmdProduct.TabIndex = 2
        Me.cmdProduct.TabStop = False
        Me.cmdProduct.Text = "S&tock"
        Me.cmdProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdProduct.UseVisualStyleBackColor = False
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
        Me.cmdMin.Location = New System.Drawing.Point(1204, 9)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(29, 34)
        Me.cmdMin.TabIndex = 17
        Me.cmdMin.TabStop = False
        Me.cmdMin.Text = "----"
        Me.cmdMin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(962, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Point of Sales System"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1270, 107)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 970
        Me.LineShape1.X2 = 1270
        Me.LineShape1.Y1 = 45
        Me.LineShape1.Y2 = 45
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Black
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 971
        Me.LineShape2.X2 = 1269
        Me.LineShape2.Y1 = 44
        Me.LineShape2.Y2 = 44
        '
        'ToolTip2
        '
        Me.ToolTip2.AutomaticDelay = 1000
        Me.ToolTip2.AutoPopDelay = 10000
        Me.ToolTip2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolTip2.InitialDelay = 500
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ReshowDelay = 100
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 627)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1274, 52)
        Me.Panel2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Label3.Location = New System.Drawing.Point(5, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "irfansafdar60@gmail.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Label2.Location = New System.Drawing.Point(2, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Last Hope Micro Systems"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1200, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Limited"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1274, 679)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.Text = "POS System Pro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdProduct As System.Windows.Forms.Button
    Friend WithEvents cmdSale As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdUsers As System.Windows.Forms.Button
    Friend WithEvents cmdViewSale As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
