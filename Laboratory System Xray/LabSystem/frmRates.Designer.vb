<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRates
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
        Me.txtTestName = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSpecimen = New System.Windows.Forms.Label
        Me.lblReport = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblRate = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtTestName
        '
        Me.txtTestName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.txtTestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestName.ForeColor = System.Drawing.Color.Teal
        Me.txtTestName.FormattingEnabled = True
        Me.txtTestName.Location = New System.Drawing.Point(6, 10)
        Me.txtTestName.MinimumSize = New System.Drawing.Size(505, 0)
        Me.txtTestName.Name = "txtTestName"
        Me.txtTestName.Size = New System.Drawing.Size(505, 297)
        Me.txtTestName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SPECIMEN"
        '
        'lblSpecimen
        '
        Me.lblSpecimen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpecimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecimen.ForeColor = System.Drawing.Color.Maroon
        Me.lblSpecimen.Location = New System.Drawing.Point(6, 340)
        Me.lblSpecimen.Name = "lblSpecimen"
        Me.lblSpecimen.Size = New System.Drawing.Size(505, 26)
        Me.lblSpecimen.TabIndex = 2
        Me.lblSpecimen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReport
        '
        Me.lblReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.ForeColor = System.Drawing.Color.Maroon
        Me.lblReport.Location = New System.Drawing.Point(6, 393)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(505, 26)
        Me.lblReport.TabIndex = 4
        Me.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "REPORT ON"
        '
        'lblRate
        '
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRate.Location = New System.Drawing.Point(6, 447)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(505, 26)
        Me.lblRate.TabIndex = 6
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TEST PRICE"
        '
        'frmRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(518, 482)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSpecimen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTestName)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(526, 509)
        Me.MinimumSize = New System.Drawing.Size(526, 509)
        Me.Name = "frmRates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test Rates Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTestName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSpecimen As System.Windows.Forms.Label
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
