<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RateInquiry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RateInquiry))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.RateListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lblRate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter Test Code"
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(160, 18)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(113, 20)
        Me.txtCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Press F2 for View Tests List"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(505, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Clear List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RateListView
        '
        Me.RateListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RateListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.RateListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RateListView.FullRowSelect = True
        Me.RateListView.GridLines = True
        Me.RateListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.RateListView.HideSelection = False
        Me.RateListView.Location = New System.Drawing.Point(6, 52)
        Me.RateListView.Name = "RateListView"
        Me.RateListView.Size = New System.Drawing.Size(602, 359)
        Me.RateListView.TabIndex = 4
        Me.RateListView.UseCompatibleStateImageBehavior = False
        Me.RateListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Test Name"
        Me.ColumnHeader1.Width = 501
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Rate"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'lblRate
        '
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(505, 419)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(103, 27)
        Me.lblRate.TabIndex = 5
        Me.lblRate.Text = "00"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(420, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Grand Total"
        '
        'RateInquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 454)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.RateListView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RateInquiry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test Rate Inquiry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RateListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
