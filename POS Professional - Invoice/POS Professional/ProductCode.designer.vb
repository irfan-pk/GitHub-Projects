<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductCode))
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'comboBox1
        '
        Me.comboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.ForeColor = System.Drawing.Color.White
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(0, 0)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(533, 524)
        Me.comboBox1.TabIndex = 2
        '
        'ProductCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.comboBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ProductCode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Code List"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox

End Class
