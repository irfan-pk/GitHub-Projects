<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocCases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocCases))
        Me.frmBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripComboBox = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripShowButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stTotal = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stPaid = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stDiscount = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stDues = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stCases = New System.Windows.Forms.ToolStripStatusLabel
        Me.frmDataGrid = New System.Windows.Forms.DataGridView
        Me.P_NUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_SEX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_REF_BY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_CP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_DATE_SAMPLE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_PAID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_DISCOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_DUES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_OPERATOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_DUE_RCV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_DUE_RCV_OPERATOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_DELETE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.P_COMPLIMENT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.frmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.frmDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.txtToDate = New System.Windows.Forms.DateTimePicker
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        CType(Me.frmBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmBindingNavigator.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.frmDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmBindingNavigator
        '
        Me.frmBindingNavigator.AddNewItem = Nothing
        Me.frmBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.frmBindingNavigator.DeleteItem = Nothing
        Me.frmBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.frmBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel5, Me.ToolStripSeparator3, Me.ToolStripComboBox, Me.ToolStripShowButton, Me.ToolStripSeparator5, Me.ToolStripLabel4, Me.ToolStripSeparator6})
        Me.frmBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.frmBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.frmBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.frmBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.frmBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.frmBindingNavigator.Name = "frmBindingNavigator"
        Me.frmBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.frmBindingNavigator.Size = New System.Drawing.Size(1086, 25)
        Me.frmBindingNavigator.TabIndex = 10
        Me.frmBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Text = "0"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel5.Text = "Doctor Code"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripComboBox
        '
        Me.ToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripComboBox.Name = "ToolStripComboBox"
        Me.ToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripShowButton
        '
        Me.ToolStripShowButton.Image = Global.Business_Solutions.My.Resources.Resources.PrintPreviewHS
        Me.ToolStripShowButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripShowButton.Name = "ToolStripShowButton"
        Me.ToolStripShowButton.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel4.Text = "View From"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stTotal, Me.ToolStripStatusLabel3, Me.stPaid, Me.ToolStripStatusLabel5, Me.stDiscount, Me.ToolStripStatusLabel7, Me.stDues, Me.ToolStripStatusLabel2, Me.stCases})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(1008, 25)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(78, 477)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel1.Text = "TOTAL"
        '
        'stTotal
        '
        Me.stTotal.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.stTotal.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stTotal.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.stTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stTotal.Name = "stTotal"
        Me.stTotal.Size = New System.Drawing.Size(73, 18)
        Me.stTotal.Text = "00"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel3.Text = "PAID"
        '
        'stPaid
        '
        Me.stPaid.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.stPaid.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stPaid.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.stPaid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stPaid.Name = "stPaid"
        Me.stPaid.Size = New System.Drawing.Size(73, 18)
        Me.stPaid.Text = "00"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel5.Text = "DISCOUNT"
        '
        'stDiscount
        '
        Me.stDiscount.BackColor = System.Drawing.Color.LemonChiffon
        Me.stDiscount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stDiscount.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.stDiscount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stDiscount.Name = "stDiscount"
        Me.stDiscount.Size = New System.Drawing.Size(73, 18)
        Me.stDiscount.Text = "00"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel7.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel7.Text = "DUES"
        '
        'stDues
        '
        Me.stDues.BackColor = System.Drawing.Color.PaleVioletRed
        Me.stDues.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stDues.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.stDues.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stDues.Name = "stDues"
        Me.stDues.Size = New System.Drawing.Size(73, 18)
        Me.stDues.Text = "00"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel2.Text = "Total Cases"
        '
        'stCases
        '
        Me.stCases.BackColor = System.Drawing.Color.WhiteSmoke
        Me.stCases.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stCases.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.stCases.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stCases.Name = "stCases"
        Me.stCases.Size = New System.Drawing.Size(73, 18)
        Me.stCases.Text = "00"
        '
        'frmDataGrid
        '
        Me.frmDataGrid.AllowUserToAddRows = False
        Me.frmDataGrid.AllowUserToDeleteRows = False
        Me.frmDataGrid.AutoGenerateColumns = False
        Me.frmDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.frmDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.frmDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.frmDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.P_NUM, Me.P_NAME, Me.P_SEX, Me.P_REF_BY, Me.P_CP, Me.P_DATE_SAMPLE, Me.P_TOTAL, Me.P_PAID, Me.P_DISCOUNT, Me.P_DUES, Me.P_OPERATOR, Me.P_DUE_RCV, Me.P_DUE_RCV_OPERATOR, Me.P_DELETE, Me.P_COMPLIMENT})
        Me.frmDataGrid.DataSource = Me.frmBindingSource
        Me.frmDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.frmDataGrid.Location = New System.Drawing.Point(0, 25)
        Me.frmDataGrid.MultiSelect = False
        Me.frmDataGrid.Name = "frmDataGrid"
        Me.frmDataGrid.ReadOnly = True
        Me.frmDataGrid.RowHeadersVisible = False
        Me.frmDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.frmDataGrid.Size = New System.Drawing.Size(1008, 477)
        Me.frmDataGrid.TabIndex = 12
        '
        'P_NUM
        '
        Me.P_NUM.DataPropertyName = "P_NUM"
        Me.P_NUM.HeaderText = "PATIENT ID"
        Me.P_NUM.Name = "P_NUM"
        Me.P_NUM.ReadOnly = True
        Me.P_NUM.Width = 85
        '
        'P_NAME
        '
        Me.P_NAME.DataPropertyName = "P_NAME"
        Me.P_NAME.HeaderText = "PATIENT NAME"
        Me.P_NAME.Name = "P_NAME"
        Me.P_NAME.ReadOnly = True
        Me.P_NAME.Width = 103
        '
        'P_SEX
        '
        Me.P_SEX.DataPropertyName = "P_SEX"
        Me.P_SEX.HeaderText = "GENDER"
        Me.P_SEX.Name = "P_SEX"
        Me.P_SEX.ReadOnly = True
        Me.P_SEX.Width = 78
        '
        'P_REF_BY
        '
        Me.P_REF_BY.DataPropertyName = "P_REF_BY"
        Me.P_REF_BY.HeaderText = "REFER BY"
        Me.P_REF_BY.Name = "P_REF_BY"
        Me.P_REF_BY.ReadOnly = True
        Me.P_REF_BY.Width = 79
        '
        'P_CP
        '
        Me.P_CP.DataPropertyName = "P_CP"
        Me.P_CP.HeaderText = "COLLECTION BY"
        Me.P_CP.Name = "P_CP"
        Me.P_CP.ReadOnly = True
        Me.P_CP.Width = 106
        '
        'P_DATE_SAMPLE
        '
        Me.P_DATE_SAMPLE.DataPropertyName = "P_DATE_SAMPLE"
        Me.P_DATE_SAMPLE.HeaderText = "SAMPLE DATE"
        Me.P_DATE_SAMPLE.Name = "P_DATE_SAMPLE"
        Me.P_DATE_SAMPLE.ReadOnly = True
        Me.P_DATE_SAMPLE.Width = 98
        '
        'P_TOTAL
        '
        Me.P_TOTAL.DataPropertyName = "P_TOTAL"
        Me.P_TOTAL.HeaderText = "TOTAL"
        Me.P_TOTAL.Name = "P_TOTAL"
        Me.P_TOTAL.ReadOnly = True
        Me.P_TOTAL.Width = 67
        '
        'P_PAID
        '
        Me.P_PAID.DataPropertyName = "P_PAID"
        Me.P_PAID.HeaderText = "PAID"
        Me.P_PAID.Name = "P_PAID"
        Me.P_PAID.ReadOnly = True
        Me.P_PAID.Width = 57
        '
        'P_DISCOUNT
        '
        Me.P_DISCOUNT.DataPropertyName = "P_DISCOUNT"
        Me.P_DISCOUNT.HeaderText = "DISCOUNT"
        Me.P_DISCOUNT.Name = "P_DISCOUNT"
        Me.P_DISCOUNT.ReadOnly = True
        Me.P_DISCOUNT.Width = 88
        '
        'P_DUES
        '
        Me.P_DUES.DataPropertyName = "P_DUES"
        Me.P_DUES.HeaderText = "DUES"
        Me.P_DUES.Name = "P_DUES"
        Me.P_DUES.ReadOnly = True
        Me.P_DUES.Width = 62
        '
        'P_OPERATOR
        '
        Me.P_OPERATOR.DataPropertyName = "P_OPERATOR"
        Me.P_OPERATOR.HeaderText = "OPERATOR"
        Me.P_OPERATOR.Name = "P_OPERATOR"
        Me.P_OPERATOR.ReadOnly = True
        Me.P_OPERATOR.Width = 92
        '
        'P_DUE_RCV
        '
        Me.P_DUE_RCV.DataPropertyName = "P_DUE_RCV"
        Me.P_DUE_RCV.HeaderText = "DUES RECEIVED"
        Me.P_DUE_RCV.Name = "P_DUE_RCV"
        Me.P_DUE_RCV.ReadOnly = True
        Me.P_DUE_RCV.Width = 109
        '
        'P_DUE_RCV_OPERATOR
        '
        Me.P_DUE_RCV_OPERATOR.DataPropertyName = "P_DUE_RCV_OPERATOR"
        Me.P_DUE_RCV_OPERATOR.HeaderText = "OPERATOR"
        Me.P_DUE_RCV_OPERATOR.Name = "P_DUE_RCV_OPERATOR"
        Me.P_DUE_RCV_OPERATOR.ReadOnly = True
        Me.P_DUE_RCV_OPERATOR.Width = 92
        '
        'P_DELETE
        '
        Me.P_DELETE.DataPropertyName = "P_DELETE"
        Me.P_DELETE.HeaderText = "DELETE"
        Me.P_DELETE.Name = "P_DELETE"
        Me.P_DELETE.ReadOnly = True
        Me.P_DELETE.Width = 74
        '
        'P_COMPLIMENT
        '
        Me.P_COMPLIMENT.DataPropertyName = "P_COMPLIMENT"
        Me.P_COMPLIMENT.HeaderText = "COMPLIMENT"
        Me.P_COMPLIMENT.Name = "P_COMPLIMENT"
        Me.P_COMPLIMENT.ReadOnly = True
        Me.P_COMPLIMENT.Width = 103
        '
        'frmBindingSource
        '
        Me.frmBindingSource.DataSource = Me.frmDataSet
        Me.frmBindingSource.Position = 0
        '
        'frmDataSet
        '
        Me.frmDataSet.DataSetName = "frmDataSet"
        Me.frmDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "Patient"
        '
        'txtToDate
        '
        Me.txtToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtToDate.Location = New System.Drawing.Point(619, 2)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Size = New System.Drawing.Size(118, 20)
        Me.txtToDate.TabIndex = 14
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = ""
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate.Location = New System.Drawing.Point(496, 2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(117, 20)
        Me.txtDate.TabIndex = 13
        '
        'frmDocCases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 502)
        Me.Controls.Add(Me.txtToDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.frmDataGrid)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.frmBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDocCases"
        Me.Text = "Doctor Cases Statement"
        CType(Me.frmBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmBindingNavigator.ResumeLayout(False)
        Me.frmBindingNavigator.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.frmDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frmBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripShowButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stPaid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stDiscount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stDues As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents frmDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents P_NUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_SEX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_REF_BY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_CP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_DATE_SAMPLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_PAID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_DISCOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_DUES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_OPERATOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_DUE_RCV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_DUE_RCV_OPERATOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_DELETE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P_COMPLIMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents frmDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents txtToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stCases As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripComboBox As System.Windows.Forms.ToolStripComboBox
End Class
