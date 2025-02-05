<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoodMenu))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupFlowPanel = New System.Windows.Forms.FlowLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdOrder = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.ItemFlowPanel = New System.Windows.Forms.FlowLayoutPanel
        Me.lvOrderList = New System.Windows.Forms.ListView
        Me.ColOrder = New System.Windows.Forms.ColumnHeader
        Me.ColQty = New System.Windows.Forms.ColumnHeader
        Me.ColCode = New System.Windows.Forms.ColumnHeader
        Me.Num1 = New System.Windows.Forms.Button
        Me.Num2 = New System.Windows.Forms.Button
        Me.Num3 = New System.Windows.Forms.Button
        Me.Num4 = New System.Windows.Forms.Button
        Me.Num5 = New System.Windows.Forms.Button
        Me.Num6 = New System.Windows.Forms.Button
        Me.Num7 = New System.Windows.Forms.Button
        Me.Num8 = New System.Windows.Forms.Button
        Me.Num9 = New System.Windows.Forms.Button
        Me.NumFriction = New System.Windows.Forms.Button
        Me.Num0 = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        Me.lblDisplay = New System.Windows.Forms.Label
        Me.cmdClear = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupFlowPanel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdRefresh)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOrder)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ItemFlowPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(760, 491)
        Me.SplitContainer1.SplitterDistance = 260
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MAIN MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupFlowPanel
        '
        Me.GroupFlowPanel.Location = New System.Drawing.Point(5, 56)
        Me.GroupFlowPanel.Name = "GroupFlowPanel"
        Me.GroupFlowPanel.Size = New System.Drawing.Size(248, 428)
        Me.GroupFlowPanel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 41)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ITEMS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmdRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRefresh.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Location = New System.Drawing.Point(195, 10)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(93, 39)
        Me.cmdRefresh.TabIndex = 3
        Me.cmdRefresh.Text = "&Refresh"
        Me.ToolTip1.SetToolTip(Me.cmdRefresh, "Click to refresh the Items")
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'cmdOrder
        '
        Me.cmdOrder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrder.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.Location = New System.Drawing.Point(294, 10)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(93, 39)
        Me.cmdOrder.TabIndex = 2
        Me.cmdOrder.Text = "&Settle"
        Me.ToolTip1.SetToolTip(Me.cmdOrder, "Click to Place the Order List")
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Red
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.Location = New System.Drawing.Point(393, 10)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(93, 39)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Close"
        Me.ToolTip1.SetToolTip(Me.cmdClose, "Close without order list")
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'ItemFlowPanel
        '
        Me.ItemFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemFlowPanel.Location = New System.Drawing.Point(8, 56)
        Me.ItemFlowPanel.Name = "ItemFlowPanel"
        Me.ItemFlowPanel.Size = New System.Drawing.Size(478, 427)
        Me.ItemFlowPanel.TabIndex = 0
        '
        'lvOrderList
        '
        Me.lvOrderList.AutoArrange = False
        Me.lvOrderList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvOrderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColOrder, Me.ColQty, Me.ColCode})
        Me.lvOrderList.FullRowSelect = True
        Me.lvOrderList.GridLines = True
        Me.lvOrderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvOrderList.Location = New System.Drawing.Point(776, 12)
        Me.lvOrderList.MultiSelect = False
        Me.lvOrderList.Name = "lvOrderList"
        Me.lvOrderList.Size = New System.Drawing.Size(221, 300)
        Me.lvOrderList.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lvOrderList, "Items Order List")
        Me.lvOrderList.UseCompatibleStateImageBehavior = False
        Me.lvOrderList.View = System.Windows.Forms.View.Details
        '
        'ColOrder
        '
        Me.ColOrder.Text = "Item"
        Me.ColOrder.Width = 140
        '
        'ColQty
        '
        Me.ColQty.Text = "Qty"
        Me.ColQty.Width = 40
        '
        'ColCode
        '
        Me.ColCode.Text = "Code"
        Me.ColCode.Width = 39
        '
        'Num1
        '
        Me.Num1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.Location = New System.Drawing.Point(776, 349)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(70, 34)
        Me.Num1.TabIndex = 3
        Me.Num1.Text = "1"
        Me.Num1.UseVisualStyleBackColor = False
        '
        'Num2
        '
        Me.Num2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2.Location = New System.Drawing.Point(852, 349)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(70, 34)
        Me.Num2.TabIndex = 4
        Me.Num2.Text = "2"
        Me.Num2.UseVisualStyleBackColor = False
        '
        'Num3
        '
        Me.Num3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num3.Location = New System.Drawing.Point(927, 349)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(70, 34)
        Me.Num3.TabIndex = 5
        Me.Num3.Text = "3"
        Me.Num3.UseVisualStyleBackColor = False
        '
        'Num4
        '
        Me.Num4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num4.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num4.Location = New System.Drawing.Point(776, 389)
        Me.Num4.Name = "Num4"
        Me.Num4.Size = New System.Drawing.Size(70, 34)
        Me.Num4.TabIndex = 6
        Me.Num4.Text = "4"
        Me.Num4.UseVisualStyleBackColor = False
        '
        'Num5
        '
        Me.Num5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num5.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num5.Location = New System.Drawing.Point(852, 389)
        Me.Num5.Name = "Num5"
        Me.Num5.Size = New System.Drawing.Size(70, 34)
        Me.Num5.TabIndex = 7
        Me.Num5.Text = "5"
        Me.Num5.UseVisualStyleBackColor = False
        '
        'Num6
        '
        Me.Num6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num6.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num6.Location = New System.Drawing.Point(927, 389)
        Me.Num6.Name = "Num6"
        Me.Num6.Size = New System.Drawing.Size(70, 34)
        Me.Num6.TabIndex = 8
        Me.Num6.Text = "6"
        Me.Num6.UseVisualStyleBackColor = False
        '
        'Num7
        '
        Me.Num7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num7.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num7.Location = New System.Drawing.Point(776, 429)
        Me.Num7.Name = "Num7"
        Me.Num7.Size = New System.Drawing.Size(70, 34)
        Me.Num7.TabIndex = 9
        Me.Num7.Text = "7"
        Me.Num7.UseVisualStyleBackColor = False
        '
        'Num8
        '
        Me.Num8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num8.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num8.Location = New System.Drawing.Point(852, 429)
        Me.Num8.Name = "Num8"
        Me.Num8.Size = New System.Drawing.Size(70, 34)
        Me.Num8.TabIndex = 10
        Me.Num8.Text = "8"
        Me.Num8.UseVisualStyleBackColor = False
        '
        'Num9
        '
        Me.Num9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num9.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num9.Location = New System.Drawing.Point(928, 429)
        Me.Num9.Name = "Num9"
        Me.Num9.Size = New System.Drawing.Size(70, 34)
        Me.Num9.TabIndex = 11
        Me.Num9.Text = "9"
        Me.Num9.UseVisualStyleBackColor = False
        '
        'NumFriction
        '
        Me.NumFriction.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NumFriction.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.NumFriction.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.NumFriction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.NumFriction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.NumFriction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NumFriction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumFriction.Location = New System.Drawing.Point(776, 469)
        Me.NumFriction.Name = "NumFriction"
        Me.NumFriction.Size = New System.Drawing.Size(70, 34)
        Me.NumFriction.TabIndex = 12
        Me.NumFriction.Text = "."
        Me.NumFriction.UseVisualStyleBackColor = False
        '
        'Num0
        '
        Me.Num0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Num0.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Num0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.Num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Num0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num0.Location = New System.Drawing.Point(852, 469)
        Me.Num0.Name = "Num0"
        Me.Num0.Size = New System.Drawing.Size(70, 34)
        Me.Num0.TabIndex = 13
        Me.Num0.Text = "0"
        Me.Num0.UseVisualStyleBackColor = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.cmdBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmdBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBack.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(928, 469)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(70, 34)
        Me.cmdBack.TabIndex = 14
        Me.cmdBack.Text = ""
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.Red
        Me.lblDisplay.Location = New System.Drawing.Point(776, 318)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(146, 26)
        Me.lblDisplay.TabIndex = 15
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.cmdClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.cmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(927, 318)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(70, 26)
        Me.cmdClear.TabIndex = 16
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipTitle = "Tip"
        '
        'FoodMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 515)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.Num0)
        Me.Controls.Add(Me.NumFriction)
        Me.Controls.Add(Me.Num9)
        Me.Controls.Add(Me.Num8)
        Me.Controls.Add(Me.Num7)
        Me.Controls.Add(Me.Num6)
        Me.Controls.Add(Me.Num5)
        Me.Controls.Add(Me.Num4)
        Me.Controls.Add(Me.Num3)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.lvOrderList)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FoodMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items Selection Menu"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lvOrderList As System.Windows.Forms.ListView
    Friend WithEvents ColQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColOrder As System.Windows.Forms.ColumnHeader
    Friend WithEvents Num1 As System.Windows.Forms.Button
    Friend WithEvents Num2 As System.Windows.Forms.Button
    Friend WithEvents Num3 As System.Windows.Forms.Button
    Friend WithEvents Num4 As System.Windows.Forms.Button
    Friend WithEvents Num5 As System.Windows.Forms.Button
    Friend WithEvents Num6 As System.Windows.Forms.Button
    Friend WithEvents Num7 As System.Windows.Forms.Button
    Friend WithEvents Num8 As System.Windows.Forms.Button
    Friend WithEvents Num9 As System.Windows.Forms.Button
    Friend WithEvents NumFriction As System.Windows.Forms.Button
    Friend WithEvents Num0 As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents GroupFlowPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ItemFlowPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ColCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOrder As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
