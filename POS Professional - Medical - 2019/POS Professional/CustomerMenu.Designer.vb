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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdReports = New System.Windows.Forms.Button
        Me.cmdPayments = New System.Windows.Forms.Button
        Me.cmdTransactions = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Customer Data"
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
        Me.cmdReports.Image = Global.POS_Professional.My.Resources.Resources._1487123143_ordering
        Me.cmdReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdReports.Location = New System.Drawing.Point(299, 54)
        Me.cmdReports.Name = "cmdReports"
        Me.cmdReports.Size = New System.Drawing.Size(111, 110)
        Me.cmdReports.TabIndex = 3
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
        Me.cmdPayments.Image = Global.POS_Professional.My.Resources.Resources.icons8_general_ledger_80
        Me.cmdPayments.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPayments.Location = New System.Drawing.Point(22, 54)
        Me.cmdPayments.Name = "cmdPayments"
        Me.cmdPayments.Size = New System.Drawing.Size(111, 110)
        Me.cmdPayments.TabIndex = 1
        Me.cmdPayments.Text = "&Ledgers"
        Me.cmdPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPayments.UseVisualStyleBackColor = False
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
        Me.cmdTransactions.Image = Global.POS_Professional.My.Resources.Resources.basket_full_icon1
        Me.cmdTransactions.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTransactions.Location = New System.Drawing.Point(160, 54)
        Me.cmdTransactions.Name = "cmdTransactions"
        Me.cmdTransactions.Size = New System.Drawing.Size(111, 110)
        Me.cmdTransactions.TabIndex = 2
        Me.cmdTransactions.Text = "P&urchases"
        Me.cmdTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTransactions.UseVisualStyleBackColor = False
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
        Me.Button1.Image = Global.POS_Professional.My.Resources.Resources.Money_641
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(437, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 110)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Payment"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(573, 199)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdReports)
        Me.Controls.Add(Me.cmdPayments)
        Me.Controls.Add(Me.cmdTransactions)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CustomerMenu"
        Me.Text = "Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPayments As System.Windows.Forms.Button
    Friend WithEvents cmdTransactions As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdReports As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
