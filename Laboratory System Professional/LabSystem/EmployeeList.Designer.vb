<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeList))
        Me.cmbEmpLst = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmbEmpLst
        '
        Me.cmbEmpLst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbEmpLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbEmpLst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbEmpLst.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEmpLst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpLst.ForeColor = System.Drawing.Color.White
        Me.cmbEmpLst.FormattingEnabled = True
        Me.cmbEmpLst.Location = New System.Drawing.Point(0, 0)
        Me.cmbEmpLst.Name = "cmbEmpLst"
        Me.cmbEmpLst.Size = New System.Drawing.Size(322, 366)
        Me.cmbEmpLst.TabIndex = 3
        '
        'EmployeeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 366)
        Me.Controls.Add(Me.cmbEmpLst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmployeeList"
        Me.Text = "EmployeeList"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmbEmpLst As System.Windows.Forms.ComboBox
End Class
