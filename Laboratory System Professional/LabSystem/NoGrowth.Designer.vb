<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoGrowth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoGrowth))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdResult = New System.Windows.Forms.Button
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdPrintReport = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtCp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPatientID = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtHospital = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGender = New System.Windows.Forms.TextBox
        Me.txtConsultant = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ReportSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSource = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdResult)
        Me.GroupBox1.Controls.Add(Me.cmdRefresh)
        Me.GroupBox1.Controls.Add(Me.cmdPrintReport)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 337)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(875, 59)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        '
        'cmdResult
        '
        Me.cmdResult.Enabled = False
        Me.cmdResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResult.Image = Global.Business_Solutions.My.Resources.Resources.if_edit_173002
        Me.cmdResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdResult.Location = New System.Drawing.Point(12, 15)
        Me.cmdResult.Name = "cmdResult"
        Me.cmdResult.Size = New System.Drawing.Size(94, 36)
        Me.cmdResult.TabIndex = 11
        Me.cmdResult.Text = "&Result"
        Me.cmdResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdResult.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Image = Global.Business_Solutions.My.Resources.Resources.Content_Reorder_24
        Me.cmdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(369, 15)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(93, 36)
        Me.cmdRefresh.TabIndex = 17
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdPrintReport
        '
        Me.cmdPrintReport.Enabled = False
        Me.cmdPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrintReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintReport.Image = Global.Business_Solutions.My.Resources.Resources.print_icon
        Me.cmdPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrintReport.Location = New System.Drawing.Point(667, 15)
        Me.cmdPrintReport.Name = "cmdPrintReport"
        Me.cmdPrintReport.Size = New System.Drawing.Size(93, 36)
        Me.cmdPrintReport.TabIndex = 20
        Me.cmdPrintReport.Text = "&Print"
        Me.cmdPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrintReport.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.Business_Solutions.My.Resources.Resources.Actions_application_exit_icon
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(767, 15)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(93, 36)
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = Global.Business_Solutions.My.Resources.Resources.if_edit_find_replace
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(568, 15)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(93, 36)
        Me.cmdEdit.TabIndex = 19
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = Global.Business_Solutions.My.Resources.Resources.Save
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(468, 15)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(93, 36)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtCp
        '
        Me.txtCp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCp.Location = New System.Drawing.Point(668, 40)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.ReadOnly = True
        Me.txtCp.Size = New System.Drawing.Size(191, 22)
        Me.txtCp.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Patient ID #"
        '
        'txtPatientID
        '
        Me.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(112, 11)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(157, 22)
        Me.txtPatientID.TabIndex = 0
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(503, 40)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(159, 22)
        Me.txtDate.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(415, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Report Date"
        '
        'txtHospital
        '
        Me.txtHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospital.Location = New System.Drawing.Point(503, 69)
        Me.txtHospital.Name = "txtHospital"
        Me.txtHospital.ReadOnly = True
        Me.txtHospital.Size = New System.Drawing.Size(356, 22)
        Me.txtHospital.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(439, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Hospital"
        '
        'txtGender
        '
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(737, 11)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(122, 22)
        Me.txtGender.TabIndex = 3
        '
        'txtConsultant
        '
        Me.txtConsultant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsultant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsultant.Location = New System.Drawing.Point(112, 69)
        Me.txtConsultant.Name = "txtConsultant"
        Me.txtConsultant.ReadOnly = True
        Me.txtConsultant.Size = New System.Drawing.Size(284, 22)
        Me.txtConsultant.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Consultant"
        '
        'ReportSource
        '
        Me.ReportSource.DataSource = Me.ReportDataSet
        Me.ReportSource.Position = 0
        '
        'ReportDataSet
        '
        Me.ReportDataSet.DataSetName = "NewDataSet"
        Me.ReportDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "RPT_PARAM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(679, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(503, 11)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(159, 22)
        Me.txtAge.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(419, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Patient Age"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPatientID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHospital)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtConsultant)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtGender)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAge)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSource)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtResult)
        Me.SplitContainer1.Size = New System.Drawing.Size(875, 337)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 103
        Me.SplitContainer1.TabStop = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(112, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(284, 22)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Patient Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "RESULT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSource
        '
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSource.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSource.Location = New System.Drawing.Point(14, 32)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(160, 22)
        Me.txtSource.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 13)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "SOURCE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtResult
        '
        Me.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResult.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(14, 99)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(845, 114)
        Me.txtResult.TabIndex = 10
        '
        'ReportBindingSource
        '
        Me.ReportBindingSource.DataMember = "RPT_PARAM"
        Me.ReportBindingSource.DataSource = Me.ReportSource
        '
        'NoGrowth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 396)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NoGrowth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "No Growth Report"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdPrintReport As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtCp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHospital As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultant As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ReportSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdResult As System.Windows.Forms.Button
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
