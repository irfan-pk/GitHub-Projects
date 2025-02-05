<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersRegistration))
        Me.UserDataSet = New System.Data.DataSet
        Me.UserbindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbUserRole = New System.Windows.Forms.ComboBox
        Me.txtLevel = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.txtCNIC = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCtrID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSeq = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.txtSeq = New System.Windows.Forms.TextBox
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserbindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        '
        'UserbindingSource
        '
        Me.UserbindingSource.DataSource = Me.UserDataSet
        Me.UserbindingSource.Position = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "User Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Location = New System.Drawing.Point(151, 58)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(231, 22)
        Me.txtUserName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "User Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Password"
        '
        'txtPwd
        '
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Location = New System.Drawing.Point(151, 114)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.ReadOnly = True
        Me.txtPwd.Size = New System.Drawing.Size(231, 22)
        Me.txtPwd.TabIndex = 3
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Counter ID"
        '
        'cmbUserRole
        '
        Me.cmbUserRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbUserRole.FormattingEnabled = True
        Me.cmbUserRole.Items.AddRange(New Object() {"Administrator", "Super User", "User"})
        Me.cmbUserRole.Location = New System.Drawing.Point(151, 143)
        Me.cmbUserRole.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUserRole.MaxDropDownItems = 3
        Me.cmbUserRole.Name = "cmbUserRole"
        Me.cmbUserRole.Size = New System.Drawing.Size(231, 24)
        Me.cmbUserRole.TabIndex = 4
        '
        'txtLevel
        '
        Me.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLevel.Enabled = False
        Me.txtLevel.Location = New System.Drawing.Point(287, 174)
        Me.txtLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(95, 22)
        Me.txtLevel.TabIndex = 6
        Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 89)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "User ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUserID
        '
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.Location = New System.Drawing.Point(151, 86)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(231, 22)
        Me.txtUserID.TabIndex = 3
        '
        'txtCNIC
        '
        Me.txtCNIC.Location = New System.Drawing.Point(151, 202)
        Me.txtCNIC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCNIC.Mask = "00000-0000000-0"
        Me.txtCNIC.Name = "txtCNIC"
        Me.txtCNIC.ReadOnly = True
        Me.txtCNIC.Size = New System.Drawing.Size(231, 22)
        Me.txtCNIC.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(107, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "CNIC"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtrID
        '
        Me.txtCtrID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtrID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCtrID.Location = New System.Drawing.Point(151, 174)
        Me.txtCtrID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCtrID.MaxLength = 3
        Me.txtCtrID.Name = "txtCtrID"
        Me.txtCtrID.ReadOnly = True
        Me.txtCtrID.Size = New System.Drawing.Size(127, 22)
        Me.txtCtrID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Last Seq #"
        '
        'lblSeq
        '
        Me.lblSeq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeq.Location = New System.Drawing.Point(316, 30)
        Me.lblSeq.Name = "lblSeq"
        Me.lblSeq.Size = New System.Drawing.Size(66, 22)
        Me.lblSeq.TabIndex = 28
        Me.lblSeq.Text = "0"
        Me.lblSeq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 33)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "User Seq #"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 57)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(365, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 33)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "< E&xit >"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(276, 15)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 33)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "< &Save >"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(187, 15)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 33)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "< &Delete >"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(98, 15)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 33)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "< &Edit >"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Location = New System.Drawing.Point(9, 15)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(89, 33)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "< &New >"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtSeq
        '
        Me.txtSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeq.Location = New System.Drawing.Point(151, 30)
        Me.txtSeq.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeq.Name = "txtSeq"
        Me.txtSeq.Size = New System.Drawing.Size(81, 22)
        Me.txtSeq.TabIndex = 1
        Me.txtSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SystemUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 318)
        Me.Controls.Add(Me.txtSeq)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSeq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCtrID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCNIC)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.cmbUserRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(971, 574)
        Me.Name = "SystemUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Users"
        Me.TopMost = True
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserbindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserDataSet As System.Data.DataSet
    Friend WithEvents UserbindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbUserRole As System.Windows.Forms.ComboBox
    Friend WithEvents txtLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtCNIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCtrID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSeq As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtSeq As System.Windows.Forms.TextBox
End Class
