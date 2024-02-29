<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrentStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurrentStat))
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNet = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDues = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDueRcv = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.myDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(305, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total Gross Cash"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(324, 51)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(84, 24)
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscount
        '
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(324, 83)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(84, 24)
        Me.txtDiscount.TabIndex = 6
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightGreen
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(305, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Total Discount"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNet
        '
        Me.txtNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNet.Location = New System.Drawing.Point(324, 115)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.Size = New System.Drawing.Size(84, 24)
        Me.txtNet.TabIndex = 8
        Me.txtNet.Text = "0"
        Me.txtNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(305, 24)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Net Cash"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDues
        '
        Me.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDues.Location = New System.Drawing.Point(324, 147)
        Me.txtDues.Name = "txtDues"
        Me.txtDues.Size = New System.Drawing.Size(84, 24)
        Me.txtDues.TabIndex = 10
        Me.txtDues.Text = "0"
        Me.txtDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Crimson
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(305, 24)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Total Dues"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDueRcv
        '
        Me.txtDueRcv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDueRcv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueRcv.Location = New System.Drawing.Point(324, 180)
        Me.txtDueRcv.Name = "txtDueRcv"
        Me.txtDueRcv.Size = New System.Drawing.Size(84, 24)
        Me.txtDueRcv.TabIndex = 12
        Me.txtDueRcv.Text = "0"
        Me.txtDueRcv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(305, 24)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Total Dues Received"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdView
        '
        Me.cmdView.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdView.Location = New System.Drawing.Point(235, 213)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(83, 23)
        Me.cmdView.TabIndex = 17
        Me.cmdView.Text = "&View"
        Me.cmdView.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(324, 213)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(83, 23)
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'myDate
        '
        Me.myDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myDate.Location = New System.Drawing.Point(171, 17)
        Me.myDate.Name = "myDate"
        Me.myDate.Size = New System.Drawing.Size(237, 20)
        Me.myDate.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Select Transaction Date"
        '
        'frmCurrentStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(420, 249)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.myDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDueRcv)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtDues)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNet)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCurrentStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Cash Statement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNet As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDues As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDueRcv As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents myDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
