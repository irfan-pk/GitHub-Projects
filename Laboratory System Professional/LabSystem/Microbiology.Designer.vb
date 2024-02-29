<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Microbiology
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Microbiology))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdPrintReport = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.ReportSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPatientID = New System.Windows.Forms.TextBox
        Me.txtCp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtHospital = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtConsultant = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGender = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtRmkDetail = New System.Windows.Forms.TextBox
        Me.txtCount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtOrganism = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSource = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ReportDataGrid = New System.Windows.Forms.DataGridView
        Me.colParam = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colResult = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSort1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colParam2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colResult2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSort2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.ReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ReportDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRefresh)
        Me.GroupBox1.Controls.Add(Me.cmdPrintReport)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 542)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 59)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Image = Global.Business_Solutions.My.Resources.Resources.Content_Reorder_24
        Me.cmdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(440, 15)
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
        Me.cmdPrintReport.Location = New System.Drawing.Point(738, 15)
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
        Me.cmdExit.Location = New System.Drawing.Point(837, 15)
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
        Me.cmdEdit.Location = New System.Drawing.Point(639, 15)
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
        Me.cmdSave.Location = New System.Drawing.Point(539, 15)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(93, 36)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = True
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
        'ReportBindingSource
        '
        Me.ReportBindingSource.DataMember = "RPT_PARAM"
        Me.ReportBindingSource.DataSource = Me.ReportSource
        '
        'txtPatientID
        '
        Me.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(138, 11)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(157, 22)
        Me.txtPatientID.TabIndex = 0
        '
        'txtCp
        '
        Me.txtCp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCp.Location = New System.Drawing.Point(700, 40)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.ReadOnly = True
        Me.txtCp.Size = New System.Drawing.Size(191, 22)
        Me.txtCp.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Patient ID #"
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(535, 40)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(159, 22)
        Me.txtDate.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(447, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Report Date"
        '
        'txtHospital
        '
        Me.txtHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHospital.Location = New System.Drawing.Point(535, 69)
        Me.txtHospital.Name = "txtHospital"
        Me.txtHospital.ReadOnly = True
        Me.txtHospital.Size = New System.Drawing.Size(356, 22)
        Me.txtHospital.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(471, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Hospital"
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(937, 542)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 101
        Me.SplitContainer1.TabStop = False
        '
        'txtConsultant
        '
        Me.txtConsultant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsultant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsultant.Location = New System.Drawing.Point(138, 69)
        Me.txtConsultant.Name = "txtConsultant"
        Me.txtConsultant.ReadOnly = True
        Me.txtConsultant.Size = New System.Drawing.Size(284, 22)
        Me.txtConsultant.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Consultant"
        '
        'txtGender
        '
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(769, 11)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(122, 22)
        Me.txtGender.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(711, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(535, 11)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(159, 22)
        Me.txtAge.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(451, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Patient Age"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(138, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(284, 22)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Patient Name"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtRmkDetail)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtCount)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtOrganism)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtSource)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label8)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ReportDataGrid)
        Me.SplitContainer2.Size = New System.Drawing.Size(937, 434)
        Me.SplitContainer2.SplitterDistance = 312
        Me.SplitContainer2.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 362)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "REMARKS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRmkDetail
        '
        Me.txtRmkDetail.BackColor = System.Drawing.Color.White
        Me.txtRmkDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtRmkDetail.Enabled = False
        Me.txtRmkDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRmkDetail.Location = New System.Drawing.Point(0, 381)
        Me.txtRmkDetail.Multiline = True
        Me.txtRmkDetail.Name = "txtRmkDetail"
        Me.txtRmkDetail.Size = New System.Drawing.Size(310, 51)
        Me.txtRmkDetail.TabIndex = 104
        '
        'txtCount
        '
        Me.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount.Location = New System.Drawing.Point(24, 175)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(194, 22)
        Me.txtCount.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 146)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 16)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "VIABLE BACTRIAL COUNT"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrganism
        '
        Me.txtOrganism.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrganism.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrganism.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrganism.Location = New System.Drawing.Point(24, 104)
        Me.txtOrganism.Name = "txtOrganism"
        Me.txtOrganism.Size = New System.Drawing.Size(263, 22)
        Me.txtOrganism.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 81)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 16)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "ORGANISM ISOLATED"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSource
        '
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSource.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSource.Location = New System.Drawing.Point(24, 42)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(263, 22)
        Me.txtSource.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 19)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "SOURCE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReportDataGrid
        '
        Me.ReportDataGrid.AllowUserToAddRows = False
        Me.ReportDataGrid.AllowUserToDeleteRows = False
        Me.ReportDataGrid.AllowUserToResizeColumns = False
        Me.ReportDataGrid.AllowUserToResizeRows = False
        Me.ReportDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ReportDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colParam, Me.colResult, Me.colSort1, Me.colParam2, Me.colResult2, Me.colSort2})
        Me.ReportDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.ReportDataGrid.Name = "ReportDataGrid"
        Me.ReportDataGrid.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ReportDataGrid.Size = New System.Drawing.Size(619, 432)
        Me.ReportDataGrid.TabIndex = 17
        '
        'colParam
        '
        Me.colParam.HeaderText = "Parameter"
        Me.colParam.Name = "colParam"
        Me.colParam.ReadOnly = True
        Me.colParam.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colParam.Width = 208
        '
        'colResult
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.colResult.DefaultCellStyle = DataGridViewCellStyle2
        Me.colResult.HeaderText = "Result"
        Me.colResult.Name = "colResult"
        Me.colResult.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colSort1
        '
        Me.colSort1.HeaderText = "Sort_1"
        Me.colSort1.Name = "colSort1"
        Me.colSort1.Visible = False
        '
        'colParam2
        '
        Me.colParam2.HeaderText = "Parameter"
        Me.colParam2.Name = "colParam2"
        Me.colParam2.ReadOnly = True
        Me.colParam2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colParam2.Width = 209
        '
        'colResult2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SpringGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.colResult2.DefaultCellStyle = DataGridViewCellStyle3
        Me.colResult2.HeaderText = "Result"
        Me.colResult2.Name = "colResult2"
        Me.colResult2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colSort2
        '
        Me.colSort2.HeaderText = "Sort_2"
        Me.colSort2.Name = "colSort2"
        Me.colSort2.Visible = False
        '
        'Microbiology
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 601)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Microbiology"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Culture & Sensitivity"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ReportDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdPrintReport As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents ReportSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents txtCp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHospital As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtConsultant As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtOrganism As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ReportDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents colParam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResult As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSort1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colParam2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResult2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSort2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRmkDetail As System.Windows.Forms.TextBox
End Class
