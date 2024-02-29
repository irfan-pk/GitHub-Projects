<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyCases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailyCases))
        Me.frmDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataTable3 = New System.Data.DataTable
        Me.frmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stTotal = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stPaid = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stDiscount = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stDues = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.stComp = New System.Windows.Forms.ToolStripStatusLabel
        Me.AllCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearedCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.DuesCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DuesReceivedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.DeletedCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComplimentaryCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.frmBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewByToolButton = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItemAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemNonDues = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItemDues = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemDuesReceived = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItemDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemComplimentary = New System.Windows.Forms.ToolStripMenuItem
        Me.ByPhilebotomistsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripComboBox = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmbCollPoint = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripShowButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.txtToDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.RcptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RcptDataSet = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbVisitor = New System.Windows.Forms.ComboBox
        Me.Panel = New System.Windows.Forms.Panel
        Me.LabDataSet = New System.Data.DataSet
        Me.PATIENT = New System.Data.DataTable
        Me.RECEIPT = New System.Data.DataTable
        CType(Me.frmDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.frmBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmBindingNavigator.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.RcptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RcptDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECEIPT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmDataSet
        '
        Me.frmDataSet.DataSetName = "frmDataSet"
        Me.frmDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable3})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "PATIENT"
        '
        'DataTable3
        '
        Me.DataTable3.TableName = "RECEIPT"
        '
        'frmBindingSource
        '
        Me.frmBindingSource.DataSource = Me.frmDataSet
        Me.frmBindingSource.Position = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel1.Text = "Operator"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(30, 22)
        Me.ToolStripLabel2.Text = "Date"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripLabel3.Text = "ToolStripLabel3"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(95, 17)
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
        Me.stTotal.Size = New System.Drawing.Size(95, 18)
        Me.stTotal.Text = "00"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(95, 17)
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
        Me.stPaid.Size = New System.Drawing.Size(95, 18)
        Me.stPaid.Text = "00"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(95, 17)
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
        Me.stDiscount.Size = New System.Drawing.Size(95, 18)
        Me.stDiscount.Text = "00"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel7.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(95, 17)
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
        Me.stDues.Size = New System.Drawing.Size(95, 18)
        Me.stDues.Text = "00"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.stTotal, Me.ToolStripStatusLabel3, Me.stPaid, Me.ToolStripStatusLabel5, Me.stDiscount, Me.ToolStripStatusLabel7, Me.stDues, Me.ToolStripStatusLabel2, Me.stComp})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(1016, 25)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(100, 528)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(95, 17)
        Me.ToolStripStatusLabel2.Text = "Complimentary"
        '
        'stComp
        '
        Me.stComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.stComp.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.stComp.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.stComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stComp.Name = "stComp"
        Me.stComp.Size = New System.Drawing.Size(95, 18)
        Me.stComp.Text = "00"
        '
        'AllCasesToolStripMenuItem
        '
        Me.AllCasesToolStripMenuItem.Name = "AllCasesToolStripMenuItem"
        Me.AllCasesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AllCasesToolStripMenuItem.Text = "All Cases"
        '
        'ClearedCasesToolStripMenuItem
        '
        Me.ClearedCasesToolStripMenuItem.Name = "ClearedCasesToolStripMenuItem"
        Me.ClearedCasesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ClearedCasesToolStripMenuItem.Text = "Non Dues Cases"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(185, 6)
        '
        'DuesCasesToolStripMenuItem
        '
        Me.DuesCasesToolStripMenuItem.Name = "DuesCasesToolStripMenuItem"
        Me.DuesCasesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DuesCasesToolStripMenuItem.Text = "Dues Cases"
        '
        'DuesReceivedToolStripMenuItem
        '
        Me.DuesReceivedToolStripMenuItem.Name = "DuesReceivedToolStripMenuItem"
        Me.DuesReceivedToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DuesReceivedToolStripMenuItem.Text = "Dues Received"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(185, 6)
        '
        'DeletedCasesToolStripMenuItem
        '
        Me.DeletedCasesToolStripMenuItem.Name = "DeletedCasesToolStripMenuItem"
        Me.DeletedCasesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DeletedCasesToolStripMenuItem.Text = "Deleted Cases"
        '
        'ComplimentaryCasesToolStripMenuItem
        '
        Me.ComplimentaryCasesToolStripMenuItem.Name = "ComplimentaryCasesToolStripMenuItem"
        Me.ComplimentaryCasesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ComplimentaryCasesToolStripMenuItem.Text = "Complimentary Cases"
        '
        'frmBindingNavigator
        '
        Me.frmBindingNavigator.AddNewItem = Nothing
        Me.frmBindingNavigator.BindingSource = Me.frmBindingSource
        Me.frmBindingNavigator.CountItem = Nothing
        Me.frmBindingNavigator.DeleteItem = Nothing
        Me.frmBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.frmBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator7, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.ViewByToolButton, Me.ToolStripSeparator3, Me.ToolStripLabel5, Me.ToolStripComboBox, Me.ToolStripSeparator8, Me.ToolStripLabel6, Me.ToolStripSeparator4, Me.cmbCollPoint, Me.ToolStripShowButton})
        Me.frmBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.frmBindingNavigator.MoveFirstItem = Nothing
        Me.frmBindingNavigator.MoveLastItem = Nothing
        Me.frmBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.frmBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.frmBindingNavigator.Name = "frmBindingNavigator"
        Me.frmBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.frmBindingNavigator.Size = New System.Drawing.Size(1116, 25)
        Me.frmBindingNavigator.TabIndex = 9
        Me.frmBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripButton1.Image = Global.Business_Solutions.My.Resources.Resources.FindHS
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripButton1.Text = "&Find By Name"
        Me.ToolStripButton1.ToolTipText = "Find Patient by Name"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Business_Solutions.My.Resources.Resources.FindHS
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripButton2.Text = "Find by &Refer"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ViewByToolButton
        '
        Me.ViewByToolButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ViewByToolButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAll, Me.ToolStripMenuItemNonDues, Me.ToolStripSeparator1, Me.ToolStripMenuItemDues, Me.ToolStripMenuItemDuesReceived, Me.ToolStripSeparator2, Me.ToolStripMenuItemDelete, Me.ToolStripMenuItemComplimentary, Me.ByPhilebotomistsToolStripMenuItem})
        Me.ViewByToolButton.Image = Global.Business_Solutions.My.Resources.Resources.Filter2HS
        Me.ViewByToolButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewByToolButton.Name = "ViewByToolButton"
        Me.ViewByToolButton.Size = New System.Drawing.Size(110, 22)
        Me.ViewByToolButton.Text = "Fi&lter Records"
        Me.ViewByToolButton.ToolTipText = "Filter Records"
        '
        'ToolStripMenuItemAll
        '
        Me.ToolStripMenuItemAll.Name = "ToolStripMenuItemAll"
        Me.ToolStripMenuItemAll.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItemAll.Text = "All Cases"
        '
        'ToolStripMenuItemNonDues
        '
        Me.ToolStripMenuItemNonDues.Name = "ToolStripMenuItemNonDues"
        Me.ToolStripMenuItemNonDues.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItemNonDues.Text = "Non Dues Cases"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'ToolStripMenuItemDues
        '
        Me.ToolStripMenuItemDues.Name = "ToolStripMenuItemDues"
        Me.ToolStripMenuItemDues.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItemDues.Text = "Dues Cases"
        '
        'ToolStripMenuItemDuesReceived
        '
        Me.ToolStripMenuItemDuesReceived.Name = "ToolStripMenuItemDuesReceived"
        Me.ToolStripMenuItemDuesReceived.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItemDuesReceived.Text = "Dues Received"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        'ToolStripMenuItemDelete
        '
        Me.ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete"
        Me.ToolStripMenuItemDelete.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItemDelete.Text = "Deleted Cases"
        '
        'ToolStripMenuItemComplimentary
        '
        Me.ToolStripMenuItemComplimentary.Name = "ToolStripMenuItemComplimentary"
        Me.ToolStripMenuItemComplimentary.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItemComplimentary.Text = "Complimentary Cases"
        '
        'ByPhilebotomistsToolStripMenuItem
        '
        Me.ByPhilebotomistsToolStripMenuItem.Name = "ByPhilebotomistsToolStripMenuItem"
        Me.ByPhilebotomistsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ByPhilebotomistsToolStripMenuItem.Text = "By Philibotomists"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel5.Text = "Operator"
        '
        'ToolStripComboBox
        '
        Me.ToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolStripComboBox.MaxDropDownItems = 10
        Me.ToolStripComboBox.Name = "ToolStripComboBox"
        Me.ToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        Me.ToolStripComboBox.Sorted = True
        Me.ToolStripComboBox.Text = "ALL"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripLabel6.Text = "Collection Point"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'cmbCollPoint
        '
        Me.cmbCollPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCollPoint.Items.AddRange(New Object() {"ALL"})
        Me.cmbCollPoint.MaxDropDownItems = 20
        Me.cmbCollPoint.Name = "cmbCollPoint"
        Me.cmbCollPoint.Size = New System.Drawing.Size(180, 25)
        Me.cmbCollPoint.Text = "ALL"
        '
        'ToolStripShowButton
        '
        Me.ToolStripShowButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripShowButton.Image = Global.Business_Solutions.My.Resources.Resources.PrintPreviewHS
        Me.ToolStripShowButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripShowButton.Name = "ToolStripShowButton"
        Me.ToolStripShowButton.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripShowButton.Text = "&Preview"
        Me.ToolStripShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel7, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel7.Text = "View From"
        Me.ToolStripLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'txtDate
        '
        Me.txtDate.CustomFormat = ""
        Me.txtDate.Location = New System.Drawing.Point(73, 28)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(184, 20)
        Me.txtDate.TabIndex = 11
        '
        'txtToDate
        '
        Me.txtToDate.Location = New System.Drawing.Point(317, 28)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Size = New System.Drawing.Size(184, 20)
        Me.txtToDate.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "View To"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RcptBindingSource
        '
        Me.RcptBindingSource.DataSource = Me.RcptDataSet
        Me.RcptBindingSource.Position = 0
        '
        'RcptDataSet
        '
        Me.RcptDataSet.DataSetName = "frmDataSet"
        Me.RcptDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.TableName = "Receipt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(543, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Visitor"
        '
        'cmbVisitor
        '
        Me.cmbVisitor.FormattingEnabled = True
        Me.cmbVisitor.Location = New System.Drawing.Point(588, 27)
        Me.cmbVisitor.Name = "cmbVisitor"
        Me.cmbVisitor.Size = New System.Drawing.Size(238, 21)
        Me.cmbVisitor.TabIndex = 18
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 50)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1016, 503)
        Me.Panel.TabIndex = 19
        '
        'LabDataSet
        '
        Me.LabDataSet.DataSetName = "NewDataSet"
        Me.LabDataSet.Tables.AddRange(New System.Data.DataTable() {Me.PATIENT, Me.RECEIPT})
        '
        'PATIENT
        '
        Me.PATIENT.TableName = "PATIENT"
        '
        'RECEIPT
        '
        Me.RECEIPT.TableName = "RECEIPT"
        '
        'DailyCases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1116, 553)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.cmbVisitor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtToDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.frmBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "DailyCases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Daily Cases"
        CType(Me.frmDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.frmBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmBindingNavigator.ResumeLayout(False)
        Me.frmBindingNavigator.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.RcptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RcptDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECEIPT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frmDataSet As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents frmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stPaid As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stDiscount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stDues As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents AllCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearedCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DuesCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DuesReceivedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeletedCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplimentaryCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents frmBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewByToolButton As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripMenuItemAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemNonDues As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemDues As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDuesReceived As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemComplimentary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripShowButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbCollPoint As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RcptDataSet As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents RcptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stComp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ByPhilebotomistsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbVisitor As System.Windows.Forms.ComboBox
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents LabDataSet As System.Data.DataSet
    Friend WithEvents PATIENT As System.Data.DataTable
    Friend WithEvents RECEIPT As System.Data.DataTable
End Class
