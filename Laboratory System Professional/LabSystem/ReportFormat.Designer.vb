<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFormat
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportFormat))
        Me.ParameterDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.ParameterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdSubCode = New System.Windows.Forms.Button
        Me.cmdTstCode = New System.Windows.Forms.Button
        Me.cmbFormName = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtSubCode = New System.Windows.Forms.TextBox
        Me.SubCode = New System.Windows.Forms.Label
        Me.txtTstCode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdSelect = New System.Windows.Forms.Button
        Me.lblFileCode = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtReportID = New System.Windows.Forms.TextBox
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNorRange = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDef_Val = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtParameter = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGroup = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ReportDataGrid = New Business_Solutions.GroupDataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDefVal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ParameterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSearchButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripNewReportButton = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonAddNew = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorEditItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripCloseButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.ParameterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParameterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ReportDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParameterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParameterBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ParameterDataSet
        '
        Me.ParameterDataSet.DataSetName = "ParameterDataSet"
        Me.ParameterDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "RPT_PARAM"
        '
        'ParameterBindingSource
        '
        Me.ParameterBindingSource.DataSource = Me.ParameterDataSet
        Me.ParameterBindingSource.Position = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdSubCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdTstCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbFormName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSubCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SubCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTstCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdSelect)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFileCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtReportID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtUnit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNorRange)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCategory)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDef_Val)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtParameter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtGroup)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Enabled = False
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportDataGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(1256, 693)
        Me.SplitContainer1.SplitterDistance = 415
        Me.SplitContainer1.TabIndex = 1
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"BASIC", "ENHANCED", "LOCKED"})
        Me.cmbType.Location = New System.Drawing.Point(130, 367)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(249, 24)
        Me.cmbType.Sorted = True
        Me.cmbType.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 369)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 21)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Type"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdSubCode
        '
        Me.cmdSubCode.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdSubCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSubCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubCode.Image = Global.Business_Solutions.My.Resources.Resources.PrintPreviewHS
        Me.cmdSubCode.Location = New System.Drawing.Point(351, 216)
        Me.cmdSubCode.Name = "cmdSubCode"
        Me.cmdSubCode.Size = New System.Drawing.Size(29, 21)
        Me.cmdSubCode.TabIndex = 9
        Me.cmdSubCode.UseVisualStyleBackColor = True
        '
        'cmdTstCode
        '
        Me.cmdTstCode.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdTstCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTstCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTstCode.Image = Global.Business_Solutions.My.Resources.Resources.PrintPreviewHS1
        Me.cmdTstCode.Location = New System.Drawing.Point(351, 186)
        Me.cmdTstCode.Name = "cmdTstCode"
        Me.cmdTstCode.Size = New System.Drawing.Size(29, 21)
        Me.cmdTstCode.TabIndex = 7
        Me.cmdTstCode.UseVisualStyleBackColor = True
        '
        'cmbFormName
        '
        Me.cmbFormName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormName.FormattingEnabled = True
        Me.cmbFormName.Items.AddRange(New Object() {"BioChemFull", "BioChemistry", "BloodCp", "Fluid", "General", "Histopathology", "Hormones", "Microbiology", "Microscopic", "Miscellaneous", "Urine"})
        Me.cmbFormName.Location = New System.Drawing.Point(131, 334)
        Me.cmbFormName.Name = "cmbFormName"
        Me.cmbFormName.Size = New System.Drawing.Size(249, 24)
        Me.cmbFormName.Sorted = True
        Me.cmbFormName.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 21)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Form Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubCode
        '
        Me.txtSubCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCode.Location = New System.Drawing.Point(131, 216)
        Me.txtSubCode.Name = "txtSubCode"
        Me.txtSubCode.Size = New System.Drawing.Size(214, 22)
        Me.txtSubCode.TabIndex = 8
        '
        'SubCode
        '
        Me.SubCode.BackColor = System.Drawing.Color.Transparent
        Me.SubCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubCode.Location = New System.Drawing.Point(15, 216)
        Me.SubCode.Name = "SubCode"
        Me.SubCode.Size = New System.Drawing.Size(112, 21)
        Me.SubCode.TabIndex = 23
        Me.SubCode.Text = "Sub Code"
        Me.SubCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTstCode
        '
        Me.txtTstCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTstCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTstCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTstCode.Location = New System.Drawing.Point(131, 186)
        Me.txtTstCode.Name = "txtTstCode"
        Me.txtTstCode.Size = New System.Drawing.Size(214, 22)
        Me.txtTstCode.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 21)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Test Code"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdSelect
        '
        Me.cmdSelect.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSelect.Image = Global.Business_Solutions.My.Resources.Resources.PrintPreviewHS
        Me.cmdSelect.Location = New System.Drawing.Point(351, 65)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(29, 21)
        Me.cmdSelect.TabIndex = 1
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'lblFileCode
        '
        Me.lblFileCode.BackColor = System.Drawing.Color.Transparent
        Me.lblFileCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFileCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileCode.Location = New System.Drawing.Point(130, 65)
        Me.lblFileCode.Name = "lblFileCode"
        Me.lblFileCode.Size = New System.Drawing.Size(215, 21)
        Me.lblFileCode.TabIndex = 0
        Me.lblFileCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "File ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReportID
        '
        Me.txtReportID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportID.Location = New System.Drawing.Point(130, 93)
        Me.txtReportID.MaxLength = 50
        Me.txtReportID.Name = "txtReportID"
        Me.txtReportID.Size = New System.Drawing.Size(250, 22)
        Me.txtReportID.TabIndex = 2
        '
        'txtUnit
        '
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(130, 304)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(249, 22)
        Me.txtUnit.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Result Unit"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNorRange
        '
        Me.txtNorRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNorRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNorRange.Location = New System.Drawing.Point(130, 401)
        Me.txtNorRange.Multiline = True
        Me.txtNorRange.Name = "txtNorRange"
        Me.txtNorRange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNorRange.Size = New System.Drawing.Size(267, 89)
        Me.txtNorRange.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 402)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Normal Range"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(130, 123)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(250, 24)
        Me.cmbCategory.Sorted = True
        Me.cmbCategory.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Category"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDef_Val
        '
        Me.txtDef_Val.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDef_Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDef_Val.Location = New System.Drawing.Point(130, 275)
        Me.txtDef_Val.Name = "txtDef_Val"
        Me.txtDef_Val.Size = New System.Drawing.Size(249, 22)
        Me.txtDef_Val.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Default Value"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtParameter
        '
        Me.txtParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParameter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParameter.Location = New System.Drawing.Point(131, 246)
        Me.txtParameter.Name = "txtParameter"
        Me.txtParameter.Size = New System.Drawing.Size(249, 22)
        Me.txtParameter.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Parameter"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup
        '
        Me.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup.Location = New System.Drawing.Point(131, 156)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(249, 22)
        Me.txtGroup.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Group Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Report ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REPORT PARAMETERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportDataGrid
        '
        Me.ReportDataGrid.AllowUserToAddRows = False
        Me.ReportDataGrid.AllowUserToDeleteRows = False
        Me.ReportDataGrid.AutoGenerateColumns = False
        Me.ReportDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ReportDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.colTest, Me.colSubCode, Me.Column5, Me.Column6, Me.Column8, Me.colDefVal, Me.Column9, Me.Column10})
        Me.ReportDataGrid.DataSource = Me.ParameterBindingSource
        Me.ReportDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportDataGrid.GridColor = System.Drawing.Color.DimGray
        Me.ReportDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.ReportDataGrid.Name = "ReportDataGrid"
        Me.ReportDataGrid.ReadOnly = True
        Me.ReportDataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ReportDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ReportDataGrid.Size = New System.Drawing.Size(835, 691)
        Me.ReportDataGrid.TabIndex = 99
        Me.ReportDataGrid.TabStop = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.DataPropertyName = "RPTCODE"
        Me.Column1.HeaderText = "RPT CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.DataPropertyName = "CATEGORY"
        Me.Column4.HeaderText = "CATEGORY"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 91
        '
        'colTest
        '
        Me.colTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colTest.DataPropertyName = "TSTCODE"
        Me.colTest.HeaderText = "TST CODE"
        Me.colTest.Name = "colTest"
        Me.colTest.ReadOnly = True
        Me.colTest.Width = 79
        '
        'colSubCode
        '
        Me.colSubCode.DataPropertyName = "SUBCODE"
        Me.colSubCode.HeaderText = "SUBCODE"
        Me.colSubCode.Name = "colSubCode"
        Me.colSubCode.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.DataPropertyName = "GROUP_PARM"
        Me.Column5.HeaderText = "GROUP PARAM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 103
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column6.DataPropertyName = "PARAMETERS"
        Me.Column6.HeaderText = "PARAMETERS"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 106
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.DataPropertyName = "UNITS"
        Me.Column8.HeaderText = "UNITS"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 65
        '
        'colDefVal
        '
        Me.colDefVal.DataPropertyName = "DEF_VAL"
        Me.colDefVal.HeaderText = "DEFAULT VAL"
        Me.colDefVal.Name = "colDefVal"
        Me.colDefVal.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column9.DataPropertyName = "NORM_VAL"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column9.HeaderText = "NORM VALUE"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 95
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column10.DataPropertyName = "SORT_ORDER"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column10.HeaderText = "SORT"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 62
        '
        'ParameterBindingNavigator
        '
        Me.ParameterBindingNavigator.AddNewItem = Nothing
        Me.ParameterBindingNavigator.BindingSource = Me.ParameterBindingSource
        Me.ParameterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ParameterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ParameterBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParameterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1, Me.ToolStripSearchButton, Me.ToolStripSeparator2, Me.ToolStripNewReportButton, Me.BindingNavigatorSeparator2, Me.ToolStripButtonAddNew, Me.ToolStripSeparator3, Me.BindingNavigatorEditItem, Me.ToolStripSeparator4, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator5, Me.BindingNavigatorSaveItem, Me.ToolStripSeparator6, Me.ToolStripCloseButton, Me.ToolStripSeparator7})
        Me.ParameterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParameterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ParameterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ParameterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ParameterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ParameterBindingNavigator.Name = "ParameterBindingNavigator"
        Me.ParameterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ParameterBindingNavigator.Size = New System.Drawing.Size(1256, 25)
        Me.ParameterBindingNavigator.TabIndex = 2
        Me.ParameterBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(39, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(65, 22)
        Me.BindingNavigatorDeleteItem.Text = "&Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "1"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSearchButton
        '
        Me.ToolStripSearchButton.Image = Global.Business_Solutions.My.Resources.Resources.search1
        Me.ToolStripSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSearchButton.Name = "ToolStripSearchButton"
        Me.ToolStripSearchButton.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripSearchButton.Text = "&Search Report"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripNewReportButton
        '
        Me.ToolStripNewReportButton.Image = Global.Business_Solutions.My.Resources.Resources.NewDocumentHS1
        Me.ToolStripNewReportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripNewReportButton.Name = "ToolStripNewReportButton"
        Me.ToolStripNewReportButton.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripNewReportButton.Text = "&New Report"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonAddNew
        '
        Me.ToolStripButtonAddNew.Enabled = False
        Me.ToolStripButtonAddNew.Image = Global.Business_Solutions.My.Resources.Resources.data_add1
        Me.ToolStripButtonAddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAddNew.Name = "ToolStripButtonAddNew"
        Me.ToolStripButtonAddNew.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripButtonAddNew.Text = "&Add Parameter"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorEditItem
        '
        Me.BindingNavigatorEditItem.Enabled = False
        Me.BindingNavigatorEditItem.Image = Global.Business_Solutions.My.Resources.Resources.CutHS
        Me.BindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEditItem.Name = "BindingNavigatorEditItem"
        Me.BindingNavigatorEditItem.Size = New System.Drawing.Size(50, 22)
        Me.BindingNavigatorEditItem.Text = "&Edit"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Enabled = False
        Me.BindingNavigatorSaveItem.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(55, 22)
        Me.BindingNavigatorSaveItem.Text = "&Save"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripCloseButton
        '
        Me.ToolStripCloseButton.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseButton.Name = "ToolStripCloseButton"
        Me.ToolStripCloseButton.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripCloseButton.Text = "&Close"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ReportFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 718)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ParameterBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ReportFormat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT FORMAT EDITOR"
        CType(Me.ParameterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParameterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ReportDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParameterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParameterBindingNavigator.ResumeLayout(False)
        Me.ParameterBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ParameterDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ParameterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNorRange As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDef_Val As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtParameter As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReportID As System.Windows.Forms.TextBox
    Friend WithEvents cmdSelect As System.Windows.Forms.Button
    Friend WithEvents lblFileCode As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReportDataGrid As Business_Solutions.GroupDataGridView
    Friend WithEvents txtTstCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSubCode As System.Windows.Forms.TextBox
    Friend WithEvents SubCode As System.Windows.Forms.Label
    Friend WithEvents cmbFormName As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdSubCode As System.Windows.Forms.Button
    Friend WithEvents cmdTstCode As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDefVal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParameterBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSearchButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripNewReportButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAddNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
End Class
