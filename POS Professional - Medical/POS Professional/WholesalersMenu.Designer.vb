<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WholesalersMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WholesalersMenu))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdReports = New System.Windows.Forms.Button
        Me.cmdPayments = New System.Windows.Forms.Button
        Me.cmdTransactions = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Vendors"
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
        Me.cmdReports.Location = New System.Drawing.Point(300, 63)
        Me.cmdReports.Name = "cmdReports"
        Me.cmdReports.Size = New System.Drawing.Size(111, 110)
        Me.cmdReports.TabIndex = 7
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
        Me.cmdPayments.Location = New System.Drawing.Point(20, 63)
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
        Me.cmdTransactions.Image = Global.POS_Professional.My.Resources.Resources._1487123129_Sales_by_Payment_Method_rep
        Me.cmdTransactions.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTransactions.Location = New System.Drawing.Point(160, 63)
        Me.cmdTransactions.Name = "cmdTransactions"
        Me.cmdTransactions.Size = New System.Drawing.Size(111, 110)
        Me.cmdTransactions.TabIndex = 2
        Me.cmdTransactions.Text = "&Transactions"
        Me.cmdTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTransactions.UseVisualStyleBackColor = False
        '
        'WholesalersMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 207)
        Me.Controls.Add(Me.cmdReports)
        Me.Controls.Add(Me.cmdPayments)
        Me.Controls.Add(Me.cmdTransactions)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WholesalersMenu"
        Me.Text = "Vendors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPayments As System.Windows.Forms.Button
    Friend WithEvents cmdTransactions As System.Windows.Forms.Button
    Friend WithEvents cmdReports As System.Windows.Forms.Button
End Class
