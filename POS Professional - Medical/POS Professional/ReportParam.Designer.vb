<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportParam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportParam))
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtbStartDate = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.mtbEndDate = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Date"
        '
        'mtbStartDate
        '
        Me.mtbStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbStartDate.Location = New System.Drawing.Point(178, 32)
        Me.mtbStartDate.Mask = "00/00/0000"
        Me.mtbStartDate.Name = "mtbStartDate"
        Me.mtbStartDate.Size = New System.Drawing.Size(128, 24)
        Me.mtbStartDate.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.mtbStartDate, "Date Format as ( mm/dd/yyyy )")
        Me.mtbStartDate.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "End Date"
        '
        'mtbEndDate
        '
        Me.mtbEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbEndDate.Location = New System.Drawing.Point(178, 81)
        Me.mtbEndDate.Mask = "00/00/0000"
        Me.mtbEndDate.Name = "mtbEndDate"
        Me.mtbEndDate.Size = New System.Drawing.Size(128, 24)
        Me.mtbEndDate.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.mtbEndDate, "Date Format as ( mm/dd/yyyy )")
        Me.mtbEndDate.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "[ F1 ] EXIT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "[ F10 ] PREVIEW"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Date Format"
        '
        'ReportParam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(379, 216)
        Me.Controls.Add(Me.mtbEndDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtbStartDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ReportParam"
        Me.Text = "Date Range"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtbStartDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtbEndDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
