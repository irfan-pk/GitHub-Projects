<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNameCorrection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNameCorrection))
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtYrs = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMth = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDay = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRefer = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbSex = New System.Windows.Forms.ComboBox
        Me.cmdFind = New System.Windows.Forms.Button
        Me.cmdUpdt = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtVisitor = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbCollection = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblName.Location = New System.Drawing.Point(25, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(95, 19)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Patient Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(126, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(377, 22)
        Me.txtName.TabIndex = 1
        '
        'txtYrs
        '
        Me.txtYrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrs.Location = New System.Drawing.Point(126, 48)
        Me.txtYrs.Name = "txtYrs"
        Me.txtYrs.Size = New System.Drawing.Size(46, 22)
        Me.txtYrs.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(35, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patient Age"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMth
        '
        Me.txtMth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMth.Location = New System.Drawing.Point(211, 48)
        Me.txtMth.Name = "txtMth"
        Me.txtMth.Size = New System.Drawing.Size(46, 22)
        Me.txtMth.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Yrs"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDay
        '
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.Location = New System.Drawing.Point(299, 48)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(46, 22)
        Me.txtDay.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mth"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(351, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Day"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRefer
        '
        Me.txtRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefer.Location = New System.Drawing.Point(126, 167)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(377, 22)
        Me.txtRefer.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(35, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Referred By"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(35, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Gender"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSex
        '
        Me.cmbSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Femal"})
        Me.cmbSex.Location = New System.Drawing.Point(126, 79)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(132, 23)
        Me.cmbSex.TabIndex = 5
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(528, 20)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(97, 27)
        Me.cmdFind.TabIndex = 11
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'cmdUpdt
        '
        Me.cmdUpdt.Enabled = False
        Me.cmdUpdt.Location = New System.Drawing.Point(528, 53)
        Me.cmdUpdt.Name = "cmdUpdt"
        Me.cmdUpdt.Size = New System.Drawing.Size(97, 27)
        Me.cmdUpdt.TabIndex = 12
        Me.cmdUpdt.Text = "&Update"
        Me.cmdUpdt.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(528, 87)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(97, 27)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(126, 109)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(219, 22)
        Me.txtContact.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(35, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Contact #"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVisitor
        '
        Me.txtVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitor.Location = New System.Drawing.Point(126, 195)
        Me.txtVisitor.Name = "txtVisitor"
        Me.txtVisitor.Size = New System.Drawing.Size(377, 22)
        Me.txtVisitor.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(35, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sample By"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCollection
        '
        Me.cmbCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCollection.FormattingEnabled = True
        Me.cmbCollection.Location = New System.Drawing.Point(126, 138)
        Me.cmbCollection.Name = "cmbCollection"
        Me.cmbCollection.Size = New System.Drawing.Size(377, 23)
        Me.cmbCollection.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(35, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Coll. Point"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmNameCorrection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(646, 237)
        Me.Controls.Add(Me.cmbCollection)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVisitor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdUpdt)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmbSex)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRefer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtYrs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNameCorrection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Name Correction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtYrs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMth As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbSex As System.Windows.Forms.ComboBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdUpdt As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVisitor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCollection As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
