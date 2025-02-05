<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerMenu))
        Me.cmdMin = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.cmdReports = New System.Windows.Forms.Button
        Me.cmdPayments = New System.Windows.Forms.Button
        Me.cmdCustomer = New System.Windows.Forms.Button
        Me.cmdTransactions = New System.Windows.Forms.Button
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
        Me.cmdMin.Location = New System.Drawing.Point(327, 4)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(29, 34)
        Me.cmdMin.TabIndex = 14
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
        Me.cmdClose.Location = New System.Drawing.Point(358, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(29, 34)
        Me.cmdClose.TabIndex = 13
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
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(-1, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Customer Data"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(577, 194)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 561
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Black
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 561
        Me.LineShape2.Y1 = 43
        Me.LineShape2.Y2 = 43
        '
        'cmdReports
        '
        Me.cmdReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReports.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReports.ForeColor = System.Drawing.Color.Yellow
        Me.cmdReports.Image = Global.POS_System.My.Resources.Resources._1487123143_ordering1
        Me.cmdReports.Location = New System.Drawing.Point(439, 55)
        Me.cmdReports.Name = "cmdReports"
        Me.cmdReports.Size = New System.Drawing.Size(111, 110)
        Me.cmdReports.TabIndex = 19
        Me.cmdReports.Text = "Re&ports"
        Me.cmdReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdReports.UseVisualStyleBackColor = False
        '
        'cmdPayments
        '
        Me.cmdPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPayments.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPayments.ForeColor = System.Drawing.Color.Yellow
        Me.cmdPayments.Image = CType(resources.GetObject("cmdPayments.Image"), System.Drawing.Image)
        Me.cmdPayments.Location = New System.Drawing.Point(161, 55)
        Me.cmdPayments.Name = "cmdPayments"
        Me.cmdPayments.Size = New System.Drawing.Size(111, 110)
        Me.cmdPayments.TabIndex = 1
        Me.cmdPayments.Text = "&Payments"
        Me.cmdPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPayments.UseVisualStyleBackColor = False
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustomer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.Color.Yellow
        Me.cmdCustomer.Image = Global.POS_System.My.Resources.Resources._1487899031_Add_Male_User
        Me.cmdCustomer.Location = New System.Drawing.Point(19, 55)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(111, 110)
        Me.cmdCustomer.TabIndex = 0
        Me.cmdCustomer.Text = "&Add Customer"
        Me.cmdCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'cmdTransactions
        '
        Me.cmdTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.cmdTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTransactions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTransactions.ForeColor = System.Drawing.Color.Yellow
        Me.cmdTransactions.Image = Global.POS_System.My.Resources.Resources.basket_full_icon1
        Me.cmdTransactions.Location = New System.Drawing.Point(301, 55)
        Me.cmdTransactions.Name = "cmdTransactions"
        Me.cmdTransactions.Size = New System.Drawing.Size(111, 110)
        Me.cmdTransactions.TabIndex = 2
        Me.cmdTransactions.Text = "P&urchases"
        Me.cmdTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTransactions.UseVisualStyleBackColor = False
        '
        'frmCustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(577, 194)
        Me.Controls.Add(Me.cmdReports)
        Me.Controls.Add(Me.cmdPayments)
        Me.Controls.Add(Me.cmdCustomer)
        Me.Controls.Add(Me.cmdTransactions)
        Me.Controls.Add(Me.cmdMin)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmCustomerMenu"
        Me.Text = "Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPayments As System.Windows.Forms.Button
    Friend WithEvents cmdCustomer As System.Windows.Forms.Button
    Friend WithEvents cmdTransactions As System.Windows.Forms.Button
    Friend WithEvents cmdMin As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdReports As System.Windows.Forms.Button
End Class
