<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CityRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CityRegistration))
        Me.txtSeq = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblSeq = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCitySN = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCityName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPostal = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSeq
        '
        Me.txtSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeq.Location = New System.Drawing.Point(174, 18)
        Me.txtSeq.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSeq.Name = "txtSeq"
        Me.txtSeq.Size = New System.Drawing.Size(73, 22)
        Me.txtSeq.TabIndex = 1
        Me.txtSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(540, 66)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(426, 17)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 38)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "< E&xit >"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(322, 17)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 38)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "< &Save >"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(218, 17)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 38)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "< &Delete >"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(114, 17)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(104, 38)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "< &Edit >"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Location = New System.Drawing.Point(10, 17)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(104, 38)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "< &New >"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(101, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "City Seq #"
        '
        'lblSeq
        '
        Me.lblSeq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeq.Location = New System.Drawing.Point(366, 17)
        Me.lblSeq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeq.Name = "lblSeq"
        Me.lblSeq.Size = New System.Drawing.Size(77, 25)
        Me.lblSeq.TabIndex = 127
        Me.lblSeq.Text = "0"
        Me.lblSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Last Seq #"
        '
        'txtCitySN
        '
        Me.txtCitySN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCitySN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCitySN.Location = New System.Drawing.Point(174, 83)
        Me.txtCitySN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCitySN.Name = "txtCitySN"
        Me.txtCitySN.ReadOnly = True
        Me.txtCitySN.Size = New System.Drawing.Size(73, 22)
        Me.txtCitySN.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "City Short Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCityName
        '
        Me.txtCityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCityName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCityName.Location = New System.Drawing.Point(174, 51)
        Me.txtCityName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCityName.Name = "txtCityName"
        Me.txtCityName.ReadOnly = True
        Me.txtCityName.Size = New System.Drawing.Size(269, 22)
        Me.txtCityName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "City Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPostal
        '
        Me.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPostal.Location = New System.Drawing.Point(349, 83)
        Me.txtPostal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPostal.Name = "txtPostal"
        Me.txtPostal.ReadOnly = True
        Me.txtPostal.Size = New System.Drawing.Size(94, 22)
        Me.txtPostal.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Postal Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CityRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 215)
        Me.Controls.Add(Me.txtPostal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSeq)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSeq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCitySN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCityName)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "CityRegistration"
        Me.Text = "City Codes"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSeq As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSeq As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCitySN As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCityName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
