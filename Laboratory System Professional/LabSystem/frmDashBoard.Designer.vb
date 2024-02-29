<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashBoard
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
        Me.DashBoardPanel = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblPaid = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblDuesRcv = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblDues = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DashBoardPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DashBoardPanel
        '
        Me.DashBoardPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DashBoardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DashBoardPanel.Controls.Add(Me.Panel2)
        Me.DashBoardPanel.Controls.Add(Me.Panel6)
        Me.DashBoardPanel.Controls.Add(Me.Panel5)
        Me.DashBoardPanel.Controls.Add(Me.Panel4)
        Me.DashBoardPanel.Controls.Add(Me.Panel3)
        Me.DashBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashBoardPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashBoardPanel.Name = "DashBoardPanel"
        Me.DashBoardPanel.Size = New System.Drawing.Size(483, 234)
        Me.DashBoardPanel.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblPaid)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(18, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 59)
        Me.Panel2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(92, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Counter Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaid
        '
        Me.lblPaid.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.ForeColor = System.Drawing.Color.White
        Me.lblPaid.Location = New System.Drawing.Point(105, 6)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(98, 27)
        Me.lblPaid.TabIndex = 5
        Me.lblPaid.Text = "00"
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel6.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.Money_Bag_64
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Controls.Add(Me.lblTotal)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(248, 149)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(210, 59)
        Me.Panel6.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(71, 6)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(130, 27)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(92, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total Cash"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lblDuesRcv)
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(248, 84)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 59)
        Me.Panel5.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(92, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Dues Received"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDuesRcv
        '
        Me.lblDuesRcv.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuesRcv.ForeColor = System.Drawing.Color.White
        Me.lblDuesRcv.Location = New System.Drawing.Point(72, 6)
        Me.lblDuesRcv.Name = "lblDuesRcv"
        Me.lblDuesRcv.Size = New System.Drawing.Size(130, 27)
        Me.lblDuesRcv.TabIndex = 8
        Me.lblDuesRcv.Text = "00"
        Me.lblDuesRcv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.IndianRed
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblDues)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(18, 84)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 59)
        Me.Panel4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(91, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Receiveables"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDues
        '
        Me.lblDues.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDues.ForeColor = System.Drawing.Color.White
        Me.lblDues.Location = New System.Drawing.Point(71, 7)
        Me.lblDues.Name = "lblDues"
        Me.lblDues.Size = New System.Drawing.Size(130, 27)
        Me.lblDues.TabIndex = 7
        Me.lblDues.Text = "00"
        Me.lblDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel3.Controls.Add(Me.lblDiscount)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(248, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 59)
        Me.Panel3.TabIndex = 9
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.White
        Me.lblDiscount.Location = New System.Drawing.Point(77, 6)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(130, 27)
        Me.lblDiscount.TabIndex = 6
        Me.lblDiscount.Text = "00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(112, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Discount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'frmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.DashBoardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDashBoard"
        Me.ShowInTaskbar = False
        Me.DashBoardPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DashBoardPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDuesRcv As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDues As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
