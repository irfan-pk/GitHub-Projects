<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PettyLedgers
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PettyLedgers))
        Me.cmdReorder = New System.Windows.Forms.Button
        Me.cmdGetTrans = New System.Windows.Forms.Button
        Me.MyDataSet = New System.Data.DataSet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAccount = New System.Windows.Forms.TextBox
        Me.txtAcc_Id = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.lblOpnCredit = New System.Windows.Forms.Label
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.lblOpnCr = New System.Windows.Forms.Label
        Me.lblClosing = New System.Windows.Forms.Label
        Me.lblOpnDebit = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.MyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCloCr = New System.Windows.Forms.Label
        Me.txtCloDr = New System.Windows.Forms.Label
        Me.lblCredit = New System.Windows.Forms.Label
        Me.lblDebit = New System.Windows.Forms.Label
        Me.lblAccTitle = New System.Windows.Forms.Label
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.LedgerGrid = New Business_Solutions.GroupDataGridView
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubAcc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBal = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LedgerGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdReorder
        '
        Me.cmdReorder.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.Edit_48
        Me.cmdReorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdReorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReorder.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdReorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdReorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdReorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReorder.Location = New System.Drawing.Point(106, 591)
        Me.cmdReorder.Name = "cmdReorder"
        Me.cmdReorder.Size = New System.Drawing.Size(43, 42)
        Me.cmdReorder.TabIndex = 65
        Me.cmdReorder.UseVisualStyleBackColor = True
        '
        'cmdGetTrans
        '
        Me.cmdGetTrans.BackColor = System.Drawing.Color.Gray
        Me.cmdGetTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGetTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetTrans.ForeColor = System.Drawing.Color.White
        Me.cmdGetTrans.Image = Global.Business_Solutions.My.Resources.Resources.search1
        Me.cmdGetTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGetTrans.Location = New System.Drawing.Point(958, 14)
        Me.cmdGetTrans.Name = "cmdGetTrans"
        Me.cmdGetTrans.Size = New System.Drawing.Size(116, 25)
        Me.cmdGetTrans.TabIndex = 50
        Me.cmdGetTrans.Text = "&Show Ledger"
        Me.cmdGetTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGetTrans.UseVisualStyleBackColor = False
        '
        'MyDataSet
        '
        Me.MyDataSet.DataSetName = "NewDataSet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(652, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 15)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "To"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(396, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "From"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAccount
        '
        Me.txtAccount.BackColor = System.Drawing.Color.White
        Me.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount.Location = New System.Drawing.Point(196, 16)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.ReadOnly = True
        Me.txtAccount.Size = New System.Drawing.Size(148, 21)
        Me.txtAccount.TabIndex = 46
        '
        'txtAcc_Id
        '
        Me.txtAcc_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcc_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcc_Id.Location = New System.Drawing.Point(121, 16)
        Me.txtAcc_Id.Name = "txtAcc_Id"
        Me.txtAcc_Id.Size = New System.Drawing.Size(73, 21)
        Me.txtAcc_Id.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Account Head"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Location = New System.Drawing.Point(679, 16)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(197, 20)
        Me.dtpTo.TabIndex = 48
        '
        'lblOpnCredit
        '
        Me.lblOpnCredit.BackColor = System.Drawing.Color.Gainsboro
        Me.lblOpnCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOpnCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpnCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOpnCredit.Location = New System.Drawing.Point(885, 61)
        Me.lblOpnCredit.Name = "lblOpnCredit"
        Me.lblOpnCredit.Size = New System.Drawing.Size(90, 23)
        Me.lblOpnCredit.TabIndex = 60
        Me.lblOpnCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpnCredit.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.Printer_64
        Me.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Location = New System.Drawing.Point(57, 591)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(43, 42)
        Me.cmdPrint.TabIndex = 61
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'lblOpnCr
        '
        Me.lblOpnCr.AutoSize = True
        Me.lblOpnCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpnCr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblOpnCr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpnCr.Location = New System.Drawing.Point(599, 64)
        Me.lblOpnCr.Name = "lblOpnCr"
        Me.lblOpnCr.Size = New System.Drawing.Size(182, 16)
        Me.lblOpnCr.TabIndex = 59
        Me.lblOpnCr.Text = "Balance Brought Forward"
        Me.lblOpnCr.Visible = False
        '
        'lblClosing
        '
        Me.lblClosing.AutoSize = True
        Me.lblClosing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblClosing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblClosing.Location = New System.Drawing.Point(671, 619)
        Me.lblClosing.Name = "lblClosing"
        Me.lblClosing.Size = New System.Drawing.Size(121, 16)
        Me.lblClosing.TabIndex = 58
        Me.lblClosing.Text = "Closing Balance"
        Me.lblClosing.Visible = False
        '
        'lblOpnDebit
        '
        Me.lblOpnDebit.BackColor = System.Drawing.Color.Gainsboro
        Me.lblOpnDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOpnDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpnDebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOpnDebit.Location = New System.Drawing.Point(794, 61)
        Me.lblOpnDebit.Name = "lblOpnDebit"
        Me.lblOpnDebit.Size = New System.Drawing.Size(90, 23)
        Me.lblOpnDebit.TabIndex = 57
        Me.lblOpnDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOpnDebit.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = Global.Business_Solutions.My.Resources.Resources.exit_64
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Location = New System.Drawing.Point(8, 591)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(43, 42)
        Me.cmdClose.TabIndex = 49
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Location = New System.Drawing.Point(445, 16)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(196, 20)
        Me.dtpFrom.TabIndex = 47
        '
        'MyBindingSource
        '
        Me.MyBindingSource.DataSource = Me.MyDataSet
        Me.MyBindingSource.Position = 0
        '
        'txtCloCr
        '
        Me.txtCloCr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCloCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloCr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCloCr.Location = New System.Drawing.Point(889, 616)
        Me.txtCloCr.Name = "txtCloCr"
        Me.txtCloCr.Size = New System.Drawing.Size(90, 23)
        Me.txtCloCr.TabIndex = 56
        Me.txtCloCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCloCr.Visible = False
        '
        'txtCloDr
        '
        Me.txtCloDr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCloDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloDr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCloDr.Location = New System.Drawing.Point(798, 616)
        Me.txtCloDr.Name = "txtCloDr"
        Me.txtCloDr.Size = New System.Drawing.Size(90, 23)
        Me.txtCloDr.TabIndex = 55
        Me.txtCloDr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCloDr.Visible = False
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCredit.Location = New System.Drawing.Point(889, 577)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(90, 23)
        Me.lblCredit.TabIndex = 54
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDebit
        '
        Me.lblDebit.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDebit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDebit.Location = New System.Drawing.Point(798, 577)
        Me.lblDebit.Name = "lblDebit"
        Me.lblDebit.Size = New System.Drawing.Size(90, 23)
        Me.lblDebit.TabIndex = 53
        Me.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccTitle
        '
        Me.lblAccTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAccTitle.Location = New System.Drawing.Point(15, 61)
        Me.lblAccTitle.Name = "lblAccTitle"
        Me.lblAccTitle.Size = New System.Drawing.Size(334, 24)
        Me.lblAccTitle.TabIndex = 52
        Me.lblAccTitle.Text = "ACCOUNT TITLE"
        Me.lblAccTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 1
        Me.LineShape3.X2 = 1093
        Me.LineShape3.Y1 = 565
        Me.LineShape3.Y2 = 565
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 797
        Me.LineShape4.X2 = 979
        Me.LineShape4.Y1 = 608
        Me.LineShape4.Y2 = 608
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 18
        Me.LineShape1.X2 = 1076
        Me.LineShape1.Y1 = 54
        Me.LineShape1.Y2 = 54
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape1, Me.RectangleShape2, Me.LineShape1, Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1094, 651)
        Me.ShapeContainer1.TabIndex = 66
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.White
        Me.RectangleShape3.CornerRadius = 3
        Me.RectangleShape3.Location = New System.Drawing.Point(675, 10)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(204, 30)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.Location = New System.Drawing.Point(441, 10)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(204, 30)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.CornerRadius = 3
        Me.RectangleShape2.Location = New System.Drawing.Point(117, 11)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(230, 30)
        '
        'LedgerGrid
        '
        Me.LedgerGrid.AllowUserToAddRows = False
        Me.LedgerGrid.AllowUserToDeleteRows = False
        Me.LedgerGrid.AllowUserToResizeColumns = False
        Me.LedgerGrid.AllowUserToResizeRows = False
        Me.LedgerGrid.AutoGenerateColumns = False
        Me.LedgerGrid.BackgroundColor = System.Drawing.Color.Gray
        Me.LedgerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LedgerGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.LedgerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LedgerGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colTran, Me.colAccId, Me.colVoucher, Me.colSubAcc, Me.colDesc, Me.colDebit, Me.colCredit, Me.colBal})
        Me.LedgerGrid.DataSource = Me.MyDataSet
        Me.LedgerGrid.Location = New System.Drawing.Point(17, 91)
        Me.LedgerGrid.Name = "LedgerGrid"
        Me.LedgerGrid.ReadOnly = True
        Me.LedgerGrid.RowHeadersVisible = False
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LedgerGrid.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.LedgerGrid.Size = New System.Drawing.Size(1074, 464)
        Me.LedgerGrid.TabIndex = 51
        Me.LedgerGrid.TabStop = False
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "LEDG_DATE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.colDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.Width = 73
        '
        'colTran
        '
        Me.colTran.DataPropertyName = "LEDG_TRAN_ID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.colTran.DefaultCellStyle = DataGridViewCellStyle3
        Me.colTran.HeaderText = "Trans #"
        Me.colTran.Name = "colTran"
        Me.colTran.ReadOnly = True
        Me.colTran.Width = 70
        '
        'colAccId
        '
        Me.colAccId.DataPropertyName = "LEDG_ACC_ID"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colAccId.DefaultCellStyle = DataGridViewCellStyle4
        Me.colAccId.HeaderText = "Acc. ID"
        Me.colAccId.Name = "colAccId"
        Me.colAccId.ReadOnly = True
        Me.colAccId.Width = 63
        '
        'colVoucher
        '
        Me.colVoucher.DataPropertyName = "LEDG_VOUCHER_NO"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.colVoucher.DefaultCellStyle = DataGridViewCellStyle5
        Me.colVoucher.HeaderText = "Doc #"
        Me.colVoucher.Name = "colVoucher"
        Me.colVoucher.ReadOnly = True
        Me.colVoucher.Width = 80
        '
        'colSubAcc
        '
        Me.colSubAcc.DataPropertyName = "LEDG_SUB_ACC"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colSubAcc.DefaultCellStyle = DataGridViewCellStyle6
        Me.colSubAcc.HeaderText = "Head"
        Me.colSubAcc.Name = "colSubAcc"
        Me.colSubAcc.ReadOnly = True
        Me.colSubAcc.Width = 150
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "LEDG_NARRATION"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDesc.DefaultCellStyle = DataGridViewCellStyle7
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 340
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "LEDG_DEBIT"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle8
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.ReadOnly = True
        Me.colDebit.Width = 91
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "LEDG_CREDIT"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle9
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        Me.colCredit.Width = 90
        '
        'colBal
        '
        Me.colBal.DataPropertyName = "LEDG_BALANCE"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colBal.DefaultCellStyle = DataGridViewCellStyle10
        Me.colBal.HeaderText = "Balance"
        Me.colBal.Name = "colBal"
        Me.colBal.ReadOnly = True
        '
        'PettyLedgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1094, 651)
        Me.Controls.Add(Me.cmdReorder)
        Me.Controls.Add(Me.cmdGetTrans)
        Me.Controls.Add(Me.LedgerGrid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.txtAcc_Id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.lblOpnCredit)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.lblOpnCr)
        Me.Controls.Add(Me.lblClosing)
        Me.Controls.Add(Me.lblOpnDebit)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.txtCloCr)
        Me.Controls.Add(Me.txtCloDr)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblDebit)
        Me.Controls.Add(Me.lblAccTitle)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1100, 680)
        Me.MinimumSize = New System.Drawing.Size(1100, 680)
        Me.Name = "PettyLedgers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Petty Ledgers"
        CType(Me.MyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LedgerGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdReorder As System.Windows.Forms.Button
    Friend WithEvents cmdGetTrans As System.Windows.Forms.Button
    Friend WithEvents LedgerGrid As Business_Solutions.GroupDataGridView
    Friend WithEvents MyDataSet As System.Data.DataSet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtAcc_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblOpnCredit As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents lblOpnCr As System.Windows.Forms.Label
    Friend WithEvents lblClosing As System.Windows.Forms.Label
    Friend WithEvents lblOpnDebit As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents MyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtCloCr As System.Windows.Forms.Label
    Friend WithEvents txtCloDr As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblDebit As System.Windows.Forms.Label
    Friend WithEvents lblAccTitle As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubAcc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
