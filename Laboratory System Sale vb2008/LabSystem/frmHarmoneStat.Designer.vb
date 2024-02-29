<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHarmoneStat
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
        Me.TestListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.fromDatePicker = New System.Windows.Forms.DateTimePicker
        Me.ToDatePicker = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TestListView
        '
        Me.TestListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TestListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.TestListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestListView.FullRowSelect = True
        Me.TestListView.GridLines = True
        Me.TestListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.TestListView.HideSelection = False
        Me.TestListView.Location = New System.Drawing.Point(5, 39)
        Me.TestListView.Name = "TestListView"
        Me.TestListView.Size = New System.Drawing.Size(602, 367)
        Me.TestListView.TabIndex = 5
        Me.TestListView.UseCompatibleStateImageBehavior = False
        Me.TestListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Test Name"
        Me.ColumnHeader1.Width = 501
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No of Test"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(456, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total "
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(504, 416)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(103, 27)
        Me.lblCount.TabIndex = 7
        Me.lblCount.Text = "00"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Date From"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fromDatePicker
        '
        Me.fromDatePicker.Location = New System.Drawing.Point(82, 9)
        Me.fromDatePicker.Name = "fromDatePicker"
        Me.fromDatePicker.Size = New System.Drawing.Size(193, 20)
        Me.fromDatePicker.TabIndex = 10
        '
        'ToDatePicker
        '
        Me.ToDatePicker.Location = New System.Drawing.Point(365, 9)
        Me.ToDatePicker.Name = "ToDatePicker"
        Me.ToDatePicker.Size = New System.Drawing.Size(193, 20)
        Me.ToDatePicker.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Date To"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(568, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 20)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmHarmoneStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 452)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToDatePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fromDatePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.TestListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmHarmoneStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harmones Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fromDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
