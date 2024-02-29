<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptFormat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptFormat))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ParameterDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.ParameterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.cmbReportID = New System.Windows.Forms.ComboBox
        Me.txtFileID = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNorRange = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbCatgory = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDef_Val = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtParameter = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGroup = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.ParameterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.BindingNavigatorEditItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorCloseItem = New System.Windows.Forms.ToolStripButton
        Me.SORT_ORDER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORM_VAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UNITS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PARAMETERS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TSTCODE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RptFormatGrid = New System.Windows.Forms.DataGridView
        CType(Me.ParameterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParameterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ParameterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParameterBindingNavigator.SuspendLayout()
        CType(Me.RptFormatGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbReportID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFileID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtUnit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNorRange)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCatgory)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDef_Val)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtParameter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtGroup)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShapeContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RptFormatGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(1030, 504)
        Me.SplitContainer1.SplitterDistance = 389
        Me.SplitContainer1.TabIndex = 1
        '
        'cmbReportID
        '
        Me.cmbReportID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbReportID.FormattingEnabled = True
        Me.cmbReportID.Location = New System.Drawing.Point(129, 127)
        Me.cmbReportID.Name = "cmbReportID"
        Me.cmbReportID.Size = New System.Drawing.Size(247, 21)
        Me.cmbReportID.TabIndex = 2
        Me.cmbReportID.Text = "-- Select --"
        '
        'txtFileID
        '
        Me.txtFileID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileID.Location = New System.Drawing.Point(130, 83)
        Me.txtFileID.Name = "txtFileID"
        Me.txtFileID.Size = New System.Drawing.Size(249, 22)
        Me.txtFileID.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "File Name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(129, 330)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(249, 22)
        Me.txtUnit.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 331)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Result Unit"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNorRange
        '
        Me.txtNorRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNorRange.Location = New System.Drawing.Point(129, 370)
        Me.txtNorRange.Multiline = True
        Me.txtNorRange.Name = "txtNorRange"
        Me.txtNorRange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNorRange.Size = New System.Drawing.Size(249, 122)
        Me.txtNorRange.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Normal Range"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCatgory
        '
        Me.cmbCatgory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCatgory.FormattingEnabled = True
        Me.cmbCatgory.Location = New System.Drawing.Point(129, 167)
        Me.cmbCatgory.Name = "cmbCatgory"
        Me.cmbCatgory.Size = New System.Drawing.Size(247, 21)
        Me.cmbCatgory.TabIndex = 3
        Me.cmbCatgory.Text = "-- Select --"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Category"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDef_Val
        '
        Me.txtDef_Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDef_Val.Location = New System.Drawing.Point(129, 288)
        Me.txtDef_Val.Name = "txtDef_Val"
        Me.txtDef_Val.Size = New System.Drawing.Size(249, 22)
        Me.txtDef_Val.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Default Value"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParameter
        '
        Me.txtParameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParameter.Location = New System.Drawing.Point(129, 248)
        Me.txtParameter.Name = "txtParameter"
        Me.txtParameter.Size = New System.Drawing.Size(249, 22)
        Me.txtParameter.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Parameter"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGroup
        '
        Me.txtGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup.Location = New System.Drawing.Point(129, 206)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(249, 22)
        Me.txtGroup.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Group Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Report ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REPORT PARAMETERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape10, Me.RectangleShape9, Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(389, 504)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape10.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape10.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape10.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape10.Location = New System.Drawing.Point(6, 76)
        Me.RectangleShape10.Name = "RectangleShape10"
        Me.RectangleShape10.Size = New System.Drawing.Size(381, 36)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape9.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape9.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape9.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape9.Location = New System.Drawing.Point(5, 158)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(381, 36)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape7.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape7.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape7.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape7.Location = New System.Drawing.Point(5, 199)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(381, 36)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape6.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape6.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape6.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape6.Location = New System.Drawing.Point(5, 240)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(381, 36)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape5.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape5.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape5.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(5, 363)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(381, 138)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape4.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape4.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape4.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape4.Location = New System.Drawing.Point(5, 322)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(381, 36)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape3.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(5, 281)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(381, 36)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape2.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(5, 118)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(381, 36)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape1.FillColor = System.Drawing.Color.SteelBlue
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.AliceBlue
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(5, 9)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(381, 61)
        '
        'ParameterBindingNavigator
        '
        Me.ParameterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ParameterBindingNavigator.BindingSource = Me.ParameterBindingSource
        Me.ParameterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ParameterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ParameterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorEditItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem, Me.ToolStripSeparator2, Me.BindingNavigatorCloseItem})
        Me.ParameterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ParameterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ParameterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ParameterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ParameterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ParameterBindingNavigator.Name = "ParameterBindingNavigator"
        Me.ParameterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ParameterBindingNavigator.Size = New System.Drawing.Size(1030, 25)
        Me.ParameterBindingNavigator.TabIndex = 2
        Me.ParameterBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(70, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add New"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 22)
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
        'BindingNavigatorEditItem
        '
        Me.BindingNavigatorEditItem.Image = Global.Business_Solutions.My.Resources.Resources.data_edit
        Me.BindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorEditItem.Name = "BindingNavigatorEditItem"
        Me.BindingNavigatorEditItem.Size = New System.Drawing.Size(45, 22)
        Me.BindingNavigatorEditItem.Text = "&Edit"
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(51, 22)
        Me.BindingNavigatorSaveItem.Text = "&Save"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorCloseItem
        '
        Me.BindingNavigatorCloseItem.Image = Global.Business_Solutions.My.Resources.Resources.StopHS
        Me.BindingNavigatorCloseItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorCloseItem.Name = "BindingNavigatorCloseItem"
        Me.BindingNavigatorCloseItem.Size = New System.Drawing.Size(76, 22)
        Me.BindingNavigatorCloseItem.Text = "E&xit Editor"
        '
        'SORT_ORDER
        '
        Me.SORT_ORDER.DataPropertyName = "SORT_ORDER"
        Me.SORT_ORDER.HeaderText = "SORT_ID"
        Me.SORT_ORDER.Name = "SORT_ORDER"
        '
        'NORM_VAL
        '
        Me.NORM_VAL.DataPropertyName = "NORM_VAL"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NORM_VAL.DefaultCellStyle = DataGridViewCellStyle1
        Me.NORM_VAL.HeaderText = "NORMAL RANGES"
        Me.NORM_VAL.Name = "NORM_VAL"
        Me.NORM_VAL.Width = 200
        '
        'UNITS
        '
        Me.UNITS.DataPropertyName = "UNITS"
        Me.UNITS.HeaderText = "UNITS"
        Me.UNITS.Name = "UNITS"
        '
        'PARAMETERS
        '
        Me.PARAMETERS.DataPropertyName = "PARAMETERS"
        Me.PARAMETERS.HeaderText = "TEST PARAMETERS"
        Me.PARAMETERS.Name = "PARAMETERS"
        Me.PARAMETERS.Width = 200
        '
        'TSTCODE
        '
        Me.TSTCODE.DataPropertyName = "TSTCODE"
        Me.TSTCODE.HeaderText = "TEST CODE"
        Me.TSTCODE.Name = "TSTCODE"
        '
        'RptFormatGrid
        '
        Me.RptFormatGrid.AllowUserToAddRows = False
        Me.RptFormatGrid.AllowUserToDeleteRows = False
        Me.RptFormatGrid.AutoGenerateColumns = False
        Me.RptFormatGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RptFormatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RptFormatGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TSTCODE, Me.PARAMETERS, Me.UNITS, Me.NORM_VAL, Me.SORT_ORDER})
        Me.RptFormatGrid.DataSource = Me.ParameterBindingSource
        Me.RptFormatGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptFormatGrid.Location = New System.Drawing.Point(0, 0)
        Me.RptFormatGrid.Name = "RptFormatGrid"
        Me.RptFormatGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RptFormatGrid.Size = New System.Drawing.Size(637, 504)
        Me.RptFormatGrid.TabIndex = 0
        '
        'frmRptFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 529)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ParameterBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmRptFormat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT FORMAT EDITOR"
        CType(Me.ParameterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParameterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ParameterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParameterBindingNavigator.ResumeLayout(False)
        Me.ParameterBindingNavigator.PerformLayout()
        CType(Me.RptFormatGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ParameterDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ParameterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNorRange As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCatgory As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDef_Val As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtParameter As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ParameterBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorEditItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorCloseItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RectangleShape10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtFileID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbReportID As System.Windows.Forms.ComboBox
    Friend WithEvents RptFormatGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TSTCODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PARAMETERS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNITS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORM_VAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SORT_ORDER As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
