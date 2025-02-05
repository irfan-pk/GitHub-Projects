<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreaRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AreaRegistration))
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
        Me.txtAreaSN = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAreaName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCity = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSeq
        '
        Me.txtSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeq.Location = New System.Drawing.Point(199, 25)
        Me.txtSeq.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSeq.Name = "txtSeq"
        Me.txtSeq.Size = New System.Drawing.Size(73, 21)
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 139)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(540, 66)
        Me.GroupBox1.TabIndex = 117
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
        Me.Label10.Location = New System.Drawing.Point(107, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Area Seq #"
        '
        'lblSeq
        '
        Me.lblSeq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeq.Location = New System.Drawing.Point(392, 24)
        Me.lblSeq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeq.Name = "lblSeq"
        Me.lblSeq.Size = New System.Drawing.Size(77, 25)
        Me.lblSeq.TabIndex = 115
        Me.lblSeq.Text = "0"
        Me.lblSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Last Seq #"
        '
        'txtAreaSN
        '
        Me.txtAreaSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAreaSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAreaSN.Location = New System.Drawing.Point(199, 90)
        Me.txtAreaSN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAreaSN.Name = "txtAreaSN"
        Me.txtAreaSN.ReadOnly = True
        Me.txtAreaSN.Size = New System.Drawing.Size(73, 21)
        Me.txtAreaSN.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Area Short Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAreaName
        '
        Me.txtAreaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAreaName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAreaName.Location = New System.Drawing.Point(199, 58)
        Me.txtAreaName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAreaName.Name = "txtAreaName"
        Me.txtAreaName.ReadOnly = True
        Me.txtAreaName.Size = New System.Drawing.Size(269, 21)
        Me.txtAreaName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Area Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 16)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "City"
        '
        'cmbCity
        '
        Me.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Items.AddRange(New Object() {"Administrator", "Super User", "User"})
        Me.cmbCity.Location = New System.Drawing.Point(332, 90)
        Me.cmbCity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCity.MaxDropDownItems = 5
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(136, 23)
        Me.cmbCity.TabIndex = 4
        '
        'AreaCodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 215)
        Me.Controls.Add(Me.cmbCity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSeq)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSeq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAreaSN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAreaName)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "AreaCodes"
        Me.Text = "Area Codes"
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
    Friend WithEvents txtAreaSN As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAreaName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
End Class
