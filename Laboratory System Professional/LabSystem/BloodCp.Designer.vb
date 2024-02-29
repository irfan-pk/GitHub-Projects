<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BloodCp
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BloodCp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdRemark = New System.Windows.Forms.Button
        Me.cmdPrintReport = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtPatientID = New System.Windows.Forms.TextBox
        Me.txtCp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtHospital = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtConsultant = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGender = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ReportDataGrid = New System.Windows.Forms.DataGridView
        Me.colParam = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colResult = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUnit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRanges = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFileCd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRptCd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCatg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubCd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSort = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFormName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReportSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRmkDetail = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ReportDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRefresh)
        Me.GroupBox1.Controls.Add(Me.cmdRemark)
        Me.GroupBox1.Controls.Add(Me.cmdPrintReport)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 554)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Image = Global.Business_Solutions.My.Resources.Resources.Content_Reorder_24
        Me.cmdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(444, 15)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(93, 36)
        Me.cmdRefresh.TabIndex = 11
        Me.cmdRefresh.Text = "&New"
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdRemark
        '
        Me.cmdRemark.Enabled = False
        Me.cmdRemark.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemark.Image = Global.Business_Solutions.My.Resources.Resources.if_edit_173002
        Me.cmdRemark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRemark.Location = New System.Drawing.Point(8, 15)
        Me.cmdRemark.Name = "cmdRemark"
        Me.cmdRemark.Size = New System.Drawing.Size(93, 36)
        Me.cmdRemark.TabIndex = 10
        Me.cmdRemark.Text = "&Remark"
        Me.cmdRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRemark.UseVisualStyleBackColor = True
        '
        'cmdPrintReport
        '
        Me.cmdPrintReport.Enabled = False
        Me.cmdPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrintReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintReport.Image = Global.Business_Solutions.My.Resources.Resources.print_icon
        Me.cmdPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrintReport.Location = New System.Drawing.Point(742, 15)
        Me.cmdPrintReport.Name = "cmdPrintReport"
        Me.cmdPrintReport.Size = New System.Drawing.Size(93, 36)
        Me.cmdPrintReport.TabIndex = 14
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
        Me.cmdExit.Location = New System.Drawing.Point(841, 15)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(93, 36)
        Me.cmdExit.TabIndex = 15
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
        Me.cmdEdit.Location = New System.Drawing.Point(643, 15)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(93, 36)
        Me.cmdEdit.TabIndex = 13
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
        Me.cmdSave.Location = New System.Drawing.Point(543, 15)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(93, 36)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportDataGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(945, 471)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 99
        Me.SplitContainer1.TabStop = False
        '
        'txtPatientID
        '
        Me.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(138, 11)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(157, 22)
        Me.txtPatientID.TabIndex = 1
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
        'ReportDataGrid
        '
        Me.ReportDataGrid.AllowUserToAddRows = False
        Me.ReportDataGrid.AllowUserToDeleteRows = False
        Me.ReportDataGrid.AutoGenerateColumns = False
        Me.ReportDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ReportDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colParam, Me.colResult, Me.colUnit, Me.colRanges, Me.colFileCd, Me.colRptCd, Me.colCatg, Me.colGroup, Me.colTCode, Me.colSubCd, Me.colSort, Me.colFormName, Me.colType})
        Me.ReportDataGrid.DataMember = "RPT_PARAM"
        Me.ReportDataGrid.DataSource = Me.ReportSource
        Me.ReportDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.ReportDataGrid.Name = "ReportDataGrid"
        Me.ReportDataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ReportDataGrid.Size = New System.Drawing.Size(945, 363)
        Me.ReportDataGrid.TabIndex = 9
        '
        'colParam
        '
        Me.colParam.DataPropertyName = "PARAMETERS"
        Me.colParam.HeaderText = "Parameter"
        Me.colParam.Name = "colParam"
        Me.colParam.ReadOnly = True
        Me.colParam.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colParam.Width = 350
        '
        'colResult
        '
        Me.colResult.DataPropertyName = "def_val"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.colResult.DefaultCellStyle = DataGridViewCellStyle2
        Me.colResult.HeaderText = "Result"
        Me.colResult.Name = "colResult"
        Me.colResult.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colResult.Width = 150
        '
        'colUnit
        '
        Me.colUnit.DataPropertyName = "UNITS"
        Me.colUnit.HeaderText = "Unit"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.ReadOnly = True
        Me.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colUnit.Width = 150
        '
        'colRanges
        '
        Me.colRanges.DataPropertyName = "NORM_VAL"
        Me.colRanges.HeaderText = "Normal Range"
        Me.colRanges.Name = "colRanges"
        Me.colRanges.ReadOnly = True
        Me.colRanges.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colRanges.Width = 285
        '
        'colFileCd
        '
        Me.colFileCd.DataPropertyName = "FILECODE"
        Me.colFileCd.HeaderText = "File Code"
        Me.colFileCd.Name = "colFileCd"
        Me.colFileCd.Visible = False
        '
        'colRptCd
        '
        Me.colRptCd.DataPropertyName = "RPTCODE"
        Me.colRptCd.HeaderText = "Rpt Code"
        Me.colRptCd.Name = "colRptCd"
        Me.colRptCd.Visible = False
        '
        'colCatg
        '
        Me.colCatg.DataPropertyName = "CATEGORY"
        Me.colCatg.HeaderText = "Category"
        Me.colCatg.Name = "colCatg"
        Me.colCatg.Visible = False
        '
        'colGroup
        '
        Me.colGroup.DataPropertyName = "GROUP_PARM"
        Me.colGroup.HeaderText = "Group By"
        Me.colGroup.Name = "colGroup"
        Me.colGroup.Visible = False
        '
        'colTCode
        '
        Me.colTCode.DataPropertyName = "TSTCODE"
        Me.colTCode.HeaderText = "Test Code"
        Me.colTCode.Name = "colTCode"
        Me.colTCode.Visible = False
        '
        'colSubCd
        '
        Me.colSubCd.DataPropertyName = "SUBCODE"
        Me.colSubCd.HeaderText = "Sub Code"
        Me.colSubCd.Name = "colSubCd"
        Me.colSubCd.Visible = False
        '
        'colSort
        '
        Me.colSort.DataPropertyName = "SORT_ORDER"
        Me.colSort.HeaderText = "Sort ID"
        Me.colSort.Name = "colSort"
        Me.colSort.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSort.Visible = False
        '
        'colFormName
        '
        Me.colFormName.DataPropertyName = "FormName"
        Me.colFormName.HeaderText = "FormName"
        Me.colFormName.Name = "colFormName"
        Me.colFormName.Visible = False
        '
        'colType
        '
        Me.colType.DataPropertyName = "type"
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = False
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
        'txtRmkDetail
        '
        Me.txtRmkDetail.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRmkDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRmkDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtRmkDetail.Enabled = False
        Me.txtRmkDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRmkDetail.ForeColor = System.Drawing.Color.Red
        Me.txtRmkDetail.Location = New System.Drawing.Point(0, 477)
        Me.txtRmkDetail.Multiline = True
        Me.txtRmkDetail.Name = "txtRmkDetail"
        Me.txtRmkDetail.Size = New System.Drawing.Size(945, 77)
        Me.txtRmkDetail.TabIndex = 10
        '
        'BloodCp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 613)
        Me.Controls.Add(Me.txtRmkDetail)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(953, 640)
        Me.Name = "BloodCp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pathology Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ReportDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrintReport As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHospital As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConsultant As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtCp As System.Windows.Forms.TextBox
    Friend WithEvents ReportSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdRemark As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents txtRmkDetail As System.Windows.Forms.TextBox
    Friend WithEvents colParam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colResult As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRanges As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFileCd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRptCd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubCd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFormName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
