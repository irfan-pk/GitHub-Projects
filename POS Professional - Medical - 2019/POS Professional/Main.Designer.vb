<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdViewSale = New System.Windows.Forms.Button
        Me.cmdSystem = New System.Windows.Forms.Button
        Me.cmdCompany = New System.Windows.Forms.Button
        Me.cmdCustomer = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdProduct = New System.Windows.Forms.Button
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsersCodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AreaCodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CityCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompaniesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ItemCodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.PurchaseInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.LedgersTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.DummyInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CorrectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaleInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseInvoiceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.LedgersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmdViewSale)
        Me.Panel1.Controls.Add(Me.cmdSystem)
        Me.Panel1.Controls.Add(Me.cmdCompany)
        Me.Panel1.Controls.Add(Me.cmdCustomer)
        Me.Panel1.Controls.Add(Me.cmdExit)
        Me.Panel1.Controls.Add(Me.cmdProduct)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(949, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 484)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Visible = False
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
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.CorrectionToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(1104, 32)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.TabStop = True
        Me.MenuStrip.Text = "MenuStrip"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StripStatusLabel1, Me.StripStatusLabel2, Me.StripStatusLabel3, Me.StripStatusLabel4, Me.StripStatusLabel5, Me.StripStatusLabel6, Me.StripStatusLabel7})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 490)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(949, 26)
        Me.StatusStrip1.TabIndex = 99
        '
        'StripStatusLabel1
        '
        Me.StripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StripStatusLabel1.Name = "StripStatusLabel1"
        Me.StripStatusLabel1.Size = New System.Drawing.Size(84, 21)
        Me.StripStatusLabel1.Text = "System User"
        '
        'StripStatusLabel2
        '
        Me.StripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StripStatusLabel2.Name = "StripStatusLabel2"
        Me.StripStatusLabel2.Size = New System.Drawing.Size(18, 21)
        Me.StripStatusLabel2.Text = "x"
        '
        'StripStatusLabel3
        '
        Me.StripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StripStatusLabel3.Name = "StripStatusLabel3"
        Me.StripStatusLabel3.Size = New System.Drawing.Size(57, 21)
        Me.StripStatusLabel3.Text = "Logged"
        '
        'StripStatusLabel4
        '
        Me.StripStatusLabel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StripStatusLabel4.Name = "StripStatusLabel4"
        Me.StripStatusLabel4.Size = New System.Drawing.Size(18, 21)
        Me.StripStatusLabel4.Text = "x"
        '
        'StripStatusLabel5
        '
        Me.StripStatusLabel5.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StripStatusLabel5.Name = "StripStatusLabel5"
        Me.StripStatusLabel5.Size = New System.Drawing.Size(39, 21)
        Me.StripStatusLabel5.Text = "Date"
        '
        'StripStatusLabel6
        '
        Me.StripStatusLabel6.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StripStatusLabel6.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StripStatusLabel6.Name = "StripStatusLabel6"
        Me.StripStatusLabel6.Size = New System.Drawing.Size(18, 21)
        Me.StripStatusLabel6.Text = "x"
        '
        'StripStatusLabel7
        '
        Me.StripStatusLabel7.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StripStatusLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StripStatusLabel7.Name = "StripStatusLabel7"
        Me.StripStatusLabel7.Size = New System.Drawing.Size(4, 21)
        '
        'Timer1
        '
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
        Me.cmdViewSale.Image = Global.POS_Professional.My.Resources.Resources.Money_Bag_64
        Me.cmdViewSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdViewSale.Location = New System.Drawing.Point(9, 138)
        Me.cmdViewSale.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdViewSale.Name = "cmdViewSale"
        Me.cmdViewSale.Size = New System.Drawing.Size(132, 114)
        Me.cmdViewSale.TabIndex = 1
        Me.cmdViewSale.TabStop = False
        Me.cmdViewSale.Text = "V&iew Sale"
        Me.cmdViewSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdViewSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdViewSale.UseVisualStyleBackColor = False
        '
        'cmdSystem
        '
        Me.cmdSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSystem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSystem.ForeColor = System.Drawing.Color.Yellow
        Me.cmdSystem.Image = Global.POS_Professional.My.Resources.Resources.maintenance_icon
        Me.cmdSystem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSystem.Location = New System.Drawing.Point(9, 651)
        Me.cmdSystem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSystem.Name = "cmdSystem"
        Me.cmdSystem.Size = New System.Drawing.Size(132, 114)
        Me.cmdSystem.TabIndex = 5
        Me.cmdSystem.TabStop = False
        Me.cmdSystem.Text = "&Admin"
        Me.cmdSystem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSystem.UseVisualStyleBackColor = False
        '
        'cmdCompany
        '
        Me.cmdCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCompany.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCompany.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompany.ForeColor = System.Drawing.Color.Yellow
        Me.cmdCompany.Image = Global.POS_Professional.My.Resources.Resources.delivery_truck1
        Me.cmdCompany.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCompany.Location = New System.Drawing.Point(9, 523)
        Me.cmdCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCompany.Name = "cmdCompany"
        Me.cmdCompany.Size = New System.Drawing.Size(132, 114)
        Me.cmdCompany.TabIndex = 4
        Me.cmdCompany.TabStop = False
        Me.cmdCompany.Text = "&Vendors"
        Me.cmdCompany.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCompany.UseVisualStyleBackColor = False
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.Color.Yellow
        Me.cmdCustomer.Image = Global.POS_Professional.My.Resources.Resources.People_64
        Me.cmdCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCustomer.Location = New System.Drawing.Point(9, 394)
        Me.cmdCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(132, 114)
        Me.cmdCustomer.TabIndex = 3
        Me.cmdCustomer.TabStop = False
        Me.cmdCustomer.Text = "Custo&mers"
        Me.cmdCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Yellow
        Me.cmdExit.Image = Global.POS_Professional.My.Resources.Resources._1480381921_exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdExit.Location = New System.Drawing.Point(9, 778)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(132, 114)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.TabStop = False
        Me.cmdExit.Text = "&Quit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = False
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
        Me.cmdProduct.Image = Global.POS_Professional.My.Resources.Resources._1480382641_palet04
        Me.cmdProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdProduct.Location = New System.Drawing.Point(9, 266)
        Me.cmdProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdProduct.Name = "cmdProduct"
        Me.cmdProduct.Size = New System.Drawing.Size(132, 114)
        Me.cmdProduct.TabIndex = 2
        Me.cmdProduct.TabStop = False
        Me.cmdProduct.Text = "&Inventory"
        Me.cmdProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdProduct.UseVisualStyleBackColor = False
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersCodesToolStripMenuItem, Me.AreaCodesToolStripMenuItem, Me.CityCodeToolStripMenuItem, Me.CompaniesToolStripMenuItem, Me.ReferenceToolStripMenuItem, Me.ToolStripSeparator1, Me.ItemCodesToolStripMenuItem, Me.ToolStripSeparator2, Me.AccountsToolStripMenuItem, Me.ToolStripSeparator3, Me.QuitToolStripMenuItem})
        Me.RegistrationToolStripMenuItem.Image = Global.POS_Professional.My.Resources.Resources._1487123143_ordering
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.RegistrationToolStripMenuItem.Text = "[ &REGISTRATION ]"
        '
        'UsersCodesToolStripMenuItem
        '
        Me.UsersCodesToolStripMenuItem.Name = "UsersCodesToolStripMenuItem"
        Me.UsersCodesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UsersCodesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.UsersCodesToolStripMenuItem.Text = "Users Codes"
        '
        'AreaCodesToolStripMenuItem
        '
        Me.AreaCodesToolStripMenuItem.Name = "AreaCodesToolStripMenuItem"
        Me.AreaCodesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AreaCodesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AreaCodesToolStripMenuItem.Text = "Area Codes"
        '
        'CityCodeToolStripMenuItem
        '
        Me.CityCodeToolStripMenuItem.Name = "CityCodeToolStripMenuItem"
        Me.CityCodeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CityCodeToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CityCodeToolStripMenuItem.Text = "City Code"
        '
        'CompaniesToolStripMenuItem
        '
        Me.CompaniesToolStripMenuItem.Name = "CompaniesToolStripMenuItem"
        Me.CompaniesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.CompaniesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CompaniesToolStripMenuItem.Text = "Company"
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ReferenceToolStripMenuItem.Text = "Reference List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'ItemCodesToolStripMenuItem
        '
        Me.ItemCodesToolStripMenuItem.Name = "ItemCodesToolStripMenuItem"
        Me.ItemCodesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ItemCodesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ItemCodesToolStripMenuItem.Text = "Item Codes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(210, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesInvoiceToolStripMenuItem, Me.SalesReturnToolStripMenuItem, Me.ToolStripSeparator4, Me.PurchaseInvoiceToolStripMenuItem, Me.PurchaseReturnToolStripMenuItem, Me.ToolStripSeparator5, Me.LedgersTransactionsToolStripMenuItem, Me.ToolStripSeparator6, Me.DummyInvoiceToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Image = Global.POS_Professional.My.Resources.Resources.Invoice_64
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(159, 28)
        Me.TransactionsToolStripMenuItem.Text = "[ &TRANSACTIONS ]"
        '
        'SalesInvoiceToolStripMenuItem
        '
        Me.SalesInvoiceToolStripMenuItem.Name = "SalesInvoiceToolStripMenuItem"
        Me.SalesInvoiceToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SalesInvoiceToolStripMenuItem.Text = "Sales Invoice"
        '
        'SalesReturnToolStripMenuItem
        '
        Me.SalesReturnToolStripMenuItem.Name = "SalesReturnToolStripMenuItem"
        Me.SalesReturnToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SalesReturnToolStripMenuItem.Text = "Sales Return"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(202, 6)
        '
        'PurchaseInvoiceToolStripMenuItem
        '
        Me.PurchaseInvoiceToolStripMenuItem.Name = "PurchaseInvoiceToolStripMenuItem"
        Me.PurchaseInvoiceToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.PurchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice"
        '
        'PurchaseReturnToolStripMenuItem
        '
        Me.PurchaseReturnToolStripMenuItem.Name = "PurchaseReturnToolStripMenuItem"
        Me.PurchaseReturnToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.PurchaseReturnToolStripMenuItem.Text = "Purchase Return"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(202, 6)
        '
        'LedgersTransactionsToolStripMenuItem
        '
        Me.LedgersTransactionsToolStripMenuItem.Name = "LedgersTransactionsToolStripMenuItem"
        Me.LedgersTransactionsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.LedgersTransactionsToolStripMenuItem.Text = "Journal Transactions"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(202, 6)
        '
        'DummyInvoiceToolStripMenuItem
        '
        Me.DummyInvoiceToolStripMenuItem.Name = "DummyInvoiceToolStripMenuItem"
        Me.DummyInvoiceToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DummyInvoiceToolStripMenuItem.Text = "Dummy Invoice"
        '
        'CorrectionToolStripMenuItem
        '
        Me.CorrectionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CorrectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleInvoiceToolStripMenuItem, Me.PurchaseInvoiceToolStripMenuItem1, Me.ToolStripSeparator7, Me.LedgersToolStripMenuItem})
        Me.CorrectionToolStripMenuItem.Image = Global.POS_Professional.My.Resources.Resources.data_edit
        Me.CorrectionToolStripMenuItem.Name = "CorrectionToolStripMenuItem"
        Me.CorrectionToolStripMenuItem.Size = New System.Drawing.Size(143, 28)
        Me.CorrectionToolStripMenuItem.Text = "[ &CORRECTION ]"
        '
        'SaleInvoiceToolStripMenuItem
        '
        Me.SaleInvoiceToolStripMenuItem.Name = "SaleInvoiceToolStripMenuItem"
        Me.SaleInvoiceToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SaleInvoiceToolStripMenuItem.Text = "Sale Invoice"
        '
        'PurchaseInvoiceToolStripMenuItem1
        '
        Me.PurchaseInvoiceToolStripMenuItem1.Name = "PurchaseInvoiceToolStripMenuItem1"
        Me.PurchaseInvoiceToolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
        Me.PurchaseInvoiceToolStripMenuItem1.Text = "Purchase Invoice"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(207, 6)
        '
        'LedgersToolStripMenuItem
        '
        Me.LedgersToolStripMenuItem.Name = "LedgersToolStripMenuItem"
        Me.LedgersToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.LedgersToolStripMenuItem.Text = "Ledgers Transactions"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ReportsToolStripMenuItem.Image = Global.POS_Professional.My.Resources.Resources.Sales_report_icon
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(115, 28)
        Me.ReportsToolStripMenuItem.Text = "[ &REPORTS ]"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1104, 516)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "POS System Pro ( Last Hope POS Solutions )"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdProduct As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdCustomer As System.Windows.Forms.Button
    Friend WithEvents cmdCompany As System.Windows.Forms.Button
    Friend WithEvents cmdSystem As System.Windows.Forms.Button
    Friend WithEvents cmdViewSale As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersCodesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemCodesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaCodesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompaniesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CityCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReferenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorrectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SalesReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaleInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseInvoiceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DummyInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LedgersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LedgersTransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
