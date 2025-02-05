<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorsRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorsRegistration))
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMob = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtCpName = New System.Windows.Forms.TextBox
        Me.lblSeq = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(155, 30)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(86, 22)
        Me.txtID.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 140)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Mobile #"
        '
        'txtMob
        '
        Me.txtMob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMob.Enabled = False
        Me.txtMob.Location = New System.Drawing.Point(155, 134)
        Me.txtMob.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMob.Name = "txtMob"
        Me.txtMob.Size = New System.Drawing.Size(126, 22)
        Me.txtMob.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 165)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "City Name"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCity.Enabled = False
        Me.txtCity.Location = New System.Drawing.Point(155, 160)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(171, 22)
        Me.txtCity.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(155, 82)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(402, 22)
        Me.txtAddress.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Reference ID"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(31, 112)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(84, 16)
        Me.lblPhone.TabIndex = 47
        Me.lblPhone.Text = "Telephone #"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Enabled = False
        Me.txtPhone.Location = New System.Drawing.Point(155, 108)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(126, 22)
        Me.txtPhone.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(31, 61)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(111, 16)
        Me.lblName.TabIndex = 46
        Me.lblName.Text = "Reference Name"
        '
        'txtCpName
        '
        Me.txtCpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCpName.Enabled = False
        Me.txtCpName.Location = New System.Drawing.Point(155, 56)
        Me.txtCpName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCpName.Name = "txtCpName"
        Me.txtCpName.Size = New System.Drawing.Size(402, 22)
        Me.txtCpName.TabIndex = 1
        '
        'lblSeq
        '
        Me.lblSeq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeq.Location = New System.Drawing.Point(480, 29)
        Me.lblSeq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeq.Name = "lblSeq"
        Me.lblSeq.Size = New System.Drawing.Size(77, 22)
        Me.lblSeq.TabIndex = 133
        Me.lblSeq.Text = "0"
        Me.lblSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Last Code :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 207)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(540, 66)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(426, 17)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 38)
        Me.btnExit.TabIndex = 10
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
        Me.btnSave.TabIndex = 9
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
        Me.btnDelete.TabIndex = 8
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
        'DoctorsRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(588, 293)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSeq)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMob)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtCpName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "DoctorsRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reference Table"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMob As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtCpName As System.Windows.Forms.TextBox
    Friend WithEvents lblSeq As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
