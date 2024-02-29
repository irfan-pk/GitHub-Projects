<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JournalBook
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TransactionDataSet = New System.Data.DataSet
        Me.TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTranID = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCredit = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDebit = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtTotCredit = New System.Windows.Forms.TextBox
        Me.txtTotDebit = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.txtAccount = New System.Windows.Forms.TextBox
        Me.txtAcc_Id = New System.Windows.Forms.TextBox
        Me.dtpTransaction = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtVoucher = New System.Windows.Forms.TextBox
        Me.lblAccHead = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdPost = New System.Windows.Forms.Button
        Me.cmdGetTrans = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.HdrPicBox = New System.Windows.Forms.PictureBox
        Me.JournalGrid = New Business_Solutions.GroupDataGridView
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAccId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubAcc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.TransactionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HdrPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transaction Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Account Head"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(375, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Trans #"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TransactionDataSet
        '
        Me.TransactionDataSet.DataSetName = "NewDataSet"
        '
        'TransBindingSource
        '
        Me.TransBindingSource.DataSource = Me.TransactionDataSet
        Me.TransBindingSource.Position = 0
        '
        'txtTranID
        '
        Me.txtTranID.BackColor = System.Drawing.Color.DarkGray
        Me.txtTranID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranID.ForeColor = System.Drawing.Color.Yellow
        Me.txtTranID.Location = New System.Drawing.Point(442, 67)
        Me.txtTranID.Name = "txtTranID"
        Me.txtTranID.Size = New System.Drawing.Size(94, 21)
        Me.txtTranID.TabIndex = 1
        Me.txtTranID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(333, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Amount Credit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCredit
        '
        Me.txtCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.ForeColor = System.Drawing.Color.Maroon
        Me.txtCredit.Location = New System.Drawing.Point(442, 181)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(121, 21)
        Me.txtCredit.TabIndex = 8
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Amount Debit"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDebit
        '
        Me.txtDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebit.ForeColor = System.Drawing.Color.Maroon
        Me.txtDebit.Location = New System.Drawing.Point(137, 181)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(121, 21)
        Me.txtDebit.TabIndex = 7
        Me.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(49, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Description"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Blue
        Me.txtDescription.Location = New System.Drawing.Point(136, 143)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(528, 21)
        Me.txtDescription.TabIndex = 6
        '
        'txtTotCredit
        '
        Me.txtTotCredit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotCredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotCredit.Location = New System.Drawing.Point(921, 569)
        Me.txtTotCredit.Name = "txtTotCredit"
        Me.txtTotCredit.ReadOnly = True
        Me.txtTotCredit.Size = New System.Drawing.Size(93, 20)
        Me.txtTotCredit.TabIndex = 27
        Me.txtTotCredit.TabStop = False
        Me.txtTotCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotDebit
        '
        Me.txtTotDebit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotDebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotDebit.Location = New System.Drawing.Point(828, 569)
        Me.txtTotDebit.Name = "txtTotDebit"
        Me.txtTotDebit.ReadOnly = True
        Me.txtTotDebit.Size = New System.Drawing.Size(93, 20)
        Me.txtTotDebit.TabIndex = 28
        Me.txtTotDebit.TabStop = False
        Me.txtTotDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(755, 571)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Totals"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1035, 606)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.White
        Me.RectangleShape9.CornerRadius = 3
        Me.RectangleShape9.FillColor = System.Drawing.Color.Black
        Me.RectangleShape9.Location = New System.Drawing.Point(824, 563)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(193, 30)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.White
        Me.RectangleShape8.CornerRadius = 3
        Me.RectangleShape8.Location = New System.Drawing.Point(545, 62)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(123, 30)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.White
        Me.RectangleShape7.CornerRadius = 3
        Me.RectangleShape7.Location = New System.Drawing.Point(437, 176)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(129, 30)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.White
        Me.RectangleShape6.CornerRadius = 3
        Me.RectangleShape6.Location = New System.Drawing.Point(133, 176)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(129, 30)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.White
        Me.RectangleShape5.CornerRadius = 3
        Me.RectangleShape5.Location = New System.Drawing.Point(132, 138)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(536, 30)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.White
        Me.RectangleShape4.CornerRadius = 3
        Me.RectangleShape4.Location = New System.Drawing.Point(437, 100)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(231, 30)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.White
        Me.RectangleShape3.CornerRadius = 3
        Me.RectangleShape3.Location = New System.Drawing.Point(437, 62)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(103, 30)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.CornerRadius = 3
        Me.RectangleShape2.Location = New System.Drawing.Point(132, 99)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(231, 30)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.Location = New System.Drawing.Point(132, 61)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(231, 30)
        '
        'txtAccount
        '
        Me.txtAccount.BackColor = System.Drawing.Color.White
        Me.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount.Location = New System.Drawing.Point(211, 104)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.ReadOnly = True
        Me.txtAccount.Size = New System.Drawing.Size(149, 21)
        Me.txtAccount.TabIndex = 4
        '
        'txtAcc_Id
        '
        Me.txtAcc_Id.BackColor = System.Drawing.Color.White
        Me.txtAcc_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcc_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcc_Id.Location = New System.Drawing.Point(136, 104)
        Me.txtAcc_Id.Name = "txtAcc_Id"
        Me.txtAcc_Id.ReadOnly = True
        Me.txtAcc_Id.Size = New System.Drawing.Size(73, 21)
        Me.txtAcc_Id.TabIndex = 3
        '
        'dtpTransaction
        '
        Me.dtpTransaction.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransaction.Location = New System.Drawing.Point(136, 66)
        Me.dtpTransaction.Name = "dtpTransaction"
        Me.dtpTransaction.Size = New System.Drawing.Size(224, 21)
        Me.dtpTransaction.TabIndex = 0
        Me.dtpTransaction.Value = New Date(2010, 12, 19, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(386, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Doc #"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoucher
        '
        Me.txtVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucher.Location = New System.Drawing.Point(441, 105)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(223, 21)
        Me.txtVoucher.TabIndex = 5
        '
        'lblAccHead
        '
        Me.lblAccHead.BackColor = System.Drawing.Color.DarkGray
        Me.lblAccHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccHead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccHead.Location = New System.Drawing.Point(550, 67)
        Me.lblAccHead.Name = "lblAccHead"
        Me.lblAccHead.Size = New System.Drawing.Size(114, 21)
        Me.lblAccHead.TabIndex = 2
        Me.lblAccHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(304, 31)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "General Journanl Entries"
        '
        'cmdClose
        '
        Me.cmdClose.AutoSize = True
        Me.cmdClose.BackColor = System.Drawing.Color.Gray
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.Business_Solutions.My.Resources.Resources.application_remove1
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(915, 13)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 25)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "&Close Entry"
        Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdPost
        '
        Me.cmdPost.BackColor = System.Drawing.Color.Gray
        Me.cmdPost.Enabled = False
        Me.cmdPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPost.ForeColor = System.Drawing.Color.White
        Me.cmdPost.Image = Global.Business_Solutions.My.Resources.Resources.saveHS
        Me.cmdPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPost.Location = New System.Drawing.Point(809, 13)
        Me.cmdPost.Name = "cmdPost"
        Me.cmdPost.Size = New System.Drawing.Size(103, 25)
        Me.cmdPost.TabIndex = 11
        Me.cmdPost.Text = "&Post Entries"
        Me.cmdPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPost.UseVisualStyleBackColor = False
        '
        'cmdGetTrans
        '
        Me.cmdGetTrans.BackColor = System.Drawing.Color.Gray
        Me.cmdGetTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGetTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetTrans.ForeColor = System.Drawing.Color.White
        Me.cmdGetTrans.Image = Global.Business_Solutions.My.Resources.Resources.folder_add1
        Me.cmdGetTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGetTrans.Location = New System.Drawing.Point(703, 13)
        Me.cmdGetTrans.Name = "cmdGetTrans"
        Me.cmdGetTrans.Size = New System.Drawing.Size(103, 25)
        Me.cmdGetTrans.TabIndex = 10
        Me.cmdGetTrans.Text = "&Get Entries"
        Me.cmdGetTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGetTrans.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.Gray
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Image = Global.Business_Solutions.My.Resources.Resources.database_remove
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(597, 13)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(103, 25)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Delete Entry"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'HdrPicBox
        '
        Me.HdrPicBox.BackColor = System.Drawing.Color.Gray
        Me.HdrPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HdrPicBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.HdrPicBox.Location = New System.Drawing.Point(0, 0)
        Me.HdrPicBox.Name = "HdrPicBox"
        Me.HdrPicBox.Size = New System.Drawing.Size(1035, 50)
        Me.HdrPicBox.TabIndex = 0
        Me.HdrPicBox.TabStop = False
        '
        'JournalGrid
        '
        Me.JournalGrid.AllowUserToAddRows = False
        Me.JournalGrid.AllowUserToDeleteRows = False
        Me.JournalGrid.AllowUserToResizeColumns = False
        Me.JournalGrid.AllowUserToResizeRows = False
        Me.JournalGrid.AutoGenerateColumns = False
        Me.JournalGrid.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.JournalGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.JournalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JournalGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colTran, Me.colAccId, Me.colVoucher, Me.colSubAcc, Me.colDesc, Me.colDebit, Me.colCredit})
        Me.JournalGrid.DataSource = Me.TransactionDataSet
        Me.JournalGrid.Location = New System.Drawing.Point(16, 218)
        Me.JournalGrid.Name = "JournalGrid"
        Me.JournalGrid.ReadOnly = True
        Me.JournalGrid.RowHeadersVisible = False
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JournalGrid.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.JournalGrid.Size = New System.Drawing.Size(1003, 334)
        Me.JournalGrid.TabIndex = 37
        Me.JournalGrid.TabStop = False
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "GEN_DATE"
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
        Me.colTran.DataPropertyName = "GEN_TRAN_ID"
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
        Me.colAccId.DataPropertyName = "GEN_ACC_ID"
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
        Me.colVoucher.DataPropertyName = "GEN_VOUCHER_NO"
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
        Me.colSubAcc.DataPropertyName = "GEN_SUB_ACC"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colSubAcc.DefaultCellStyle = DataGridViewCellStyle6
        Me.colSubAcc.HeaderText = "Head"
        Me.colSubAcc.Name = "colSubAcc"
        Me.colSubAcc.ReadOnly = True
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "GEN_NARRATION"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDesc.DefaultCellStyle = DataGridViewCellStyle7
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 413
        '
        'colDebit
        '
        Me.colDebit.DataPropertyName = "GEN_DEBIT"
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
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "GEN_CREDIT"
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
        '
        'frmJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1035, 606)
        Me.Controls.Add(Me.JournalGrid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblAccHead)
        Me.Controls.Add(Me.txtVoucher)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.txtAcc_Id)
        Me.Controls.Add(Me.dtpTransaction)
        Me.Controls.Add(Me.txtTotDebit)
        Me.Controls.Add(Me.txtTotCredit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtTranID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPost)
        Me.Controls.Add(Me.cmdGetTrans)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.HdrPicBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmJournal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TransactionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HdrPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HdrPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdGetTrans As System.Windows.Forms.Button
    Friend WithEvents cmdPost As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTranID As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDebit As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtTotCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtTotDebit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionDataSet As System.Data.DataSet
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtAcc_Id As System.Windows.Forms.TextBox
    Friend WithEvents dtpTransaction As System.Windows.Forms.DateTimePicker
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVoucher As System.Windows.Forms.TextBox
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblAccHead As System.Windows.Forms.Label
    Friend WithEvents RectangleShape9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents JournalGrid As Business_Solutions.GroupDataGridView
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubAcc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
