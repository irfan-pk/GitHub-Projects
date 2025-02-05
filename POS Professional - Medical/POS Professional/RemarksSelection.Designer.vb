<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemarksSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemarksSelection))
        Me.rmkComboBox = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'rmkComboBox
        '
        Me.rmkComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rmkComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rmkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.rmkComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rmkComboBox.ForeColor = System.Drawing.Color.White
        Me.rmkComboBox.FormattingEnabled = True
        Me.rmkComboBox.Items.AddRange(New Object() {"Bank Expenses", "Cheque Issued", "Cheque Received", "Deposit Cash into Bank", "Draft Issued", "Draft Received", "Online Transfer", "Payment Paid", "Withdraw Cash from Bank"})
        Me.rmkComboBox.Location = New System.Drawing.Point(0, 0)
        Me.rmkComboBox.Margin = New System.Windows.Forms.Padding(5)
        Me.rmkComboBox.Name = "rmkComboBox"
        Me.rmkComboBox.Size = New System.Drawing.Size(423, 236)
        Me.rmkComboBox.Sorted = True
        Me.rmkComboBox.TabIndex = 3
        '
        'RemarksSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 236)
        Me.Controls.Add(Me.rmkComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "RemarksSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remarks Selection"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rmkComboBox As System.Windows.Forms.ComboBox
End Class
