<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelComp
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtSex = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdFind = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.GridBinding = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridDataSet = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.Label8 = New System.Windows.Forms.Label
        Me.RecordPanel = New System.Windows.Forms.Panel
        Me.txtDues = New System.Windows.Forms.Label
        Me.txtDisc = New System.Windows.Forms.Label
        Me.txtPaid = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtRefer = New System.Windows.Forms.Label
        Me.txtCp = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.Label
        Me.txtSlip = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.Label
        Me.txtDelDate = New System.Windows.Forms.Label
        Me.txtDelTime = New System.Windows.Forms.Label
        Me.txtTime = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.Label
        Me.txtRecNo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdComp = New System.Windows.Forms.Button
        Me.txtOper = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.Label
        Me.TstDataGrid = New System.Windows.Forms.DataGridView
        Me.tcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trate = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.GridBinding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordPanel.SuspendLayout()
        CType(Me.TstDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSex
        '
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSex.Location = New System.Drawing.Point(659, 39)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(96, 23)
        Me.txtSex.TabIndex = 38
        Me.txtSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Reffered by"
        '
        'cmdFind
        '
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Location = New System.Drawing.Point(415, 418)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(85, 28)
        Me.cmdFind.TabIndex = 122
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Collected by"
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(687, 418)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 28)
        Me.cmdClose.TabIndex = 125
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'GridBinding
        '
        Me.GridBinding.DataSource = Me.GridDataSet
        Me.GridBinding.Position = 0
        '
        'GridDataSet
        '
        Me.GridDataSet.DataSetName = "GridDataSet"
        Me.GridDataSet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "RECEIPT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(563, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Mannual Slip #"
        '
        'RecordPanel
        '
        Me.RecordPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RecordPanel.Controls.Add(Me.txtDues)
        Me.RecordPanel.Controls.Add(Me.txtDisc)
        Me.RecordPanel.Controls.Add(Me.txtPaid)
        Me.RecordPanel.Controls.Add(Me.txtTotal)
        Me.RecordPanel.Controls.Add(Me.Label15)
        Me.RecordPanel.Controls.Add(Me.Label12)
        Me.RecordPanel.Controls.Add(Me.Label13)
        Me.RecordPanel.Controls.Add(Me.Label11)
        Me.RecordPanel.Controls.Add(Me.txtRefer)
        Me.RecordPanel.Controls.Add(Me.txtCp)
        Me.RecordPanel.Controls.Add(Me.txtAge)
        Me.RecordPanel.Controls.Add(Me.txtContact)
        Me.RecordPanel.Controls.Add(Me.txtSlip)
        Me.RecordPanel.Controls.Add(Me.txtName)
        Me.RecordPanel.Controls.Add(Me.txtDelDate)
        Me.RecordPanel.Controls.Add(Me.txtDelTime)
        Me.RecordPanel.Controls.Add(Me.txtTime)
        Me.RecordPanel.Controls.Add(Me.txtDate)
        Me.RecordPanel.Controls.Add(Me.txtRecNo)
        Me.RecordPanel.Controls.Add(Me.txtSex)
        Me.RecordPanel.Controls.Add(Me.Label10)
        Me.RecordPanel.Controls.Add(Me.Label9)
        Me.RecordPanel.Controls.Add(Me.Label8)
        Me.RecordPanel.Controls.Add(Me.Label7)
        Me.RecordPanel.Controls.Add(Me.Label6)
        Me.RecordPanel.Controls.Add(Me.Label5)
        Me.RecordPanel.Controls.Add(Me.Label4)
        Me.RecordPanel.Controls.Add(Me.Label3)
        Me.RecordPanel.Controls.Add(Me.Label2)
        Me.RecordPanel.Controls.Add(Me.Label1)
        Me.RecordPanel.Location = New System.Drawing.Point(5, 8)
        Me.RecordPanel.Name = "RecordPanel"
        Me.RecordPanel.Size = New System.Drawing.Size(767, 167)
        Me.RecordPanel.TabIndex = 126
        '
        'txtDues
        '
        Me.txtDues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDues.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDues.Location = New System.Drawing.Point(679, 132)
        Me.txtDues.Name = "txtDues"
        Me.txtDues.Size = New System.Drawing.Size(76, 23)
        Me.txtDues.TabIndex = 149
        Me.txtDues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDisc
        '
        Me.txtDisc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDisc.Location = New System.Drawing.Point(542, 132)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(76, 23)
        Me.txtDisc.TabIndex = 148
        Me.txtDisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPaid
        '
        Me.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPaid.Location = New System.Drawing.Point(398, 132)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(76, 23)
        Me.txtPaid.TabIndex = 147
        Me.txtPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTotal.Location = New System.Drawing.Point(98, 132)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(119, 23)
        Me.txtTotal.TabIndex = 145
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(479, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 146
        Me.Label15.Text = "Discount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(338, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "Payment"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(624, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "Balance"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "Total Amount"
        '
        'txtRefer
        '
        Me.txtRefer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefer.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtRefer.Location = New System.Drawing.Point(397, 100)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(358, 23)
        Me.txtRefer.TabIndex = 54
        Me.txtRefer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCp
        '
        Me.txtCp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCp.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCp.Location = New System.Drawing.Point(98, 100)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(199, 23)
        Me.txtCp.TabIndex = 53
        Me.txtCp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtAge.Location = New System.Drawing.Point(98, 70)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(199, 23)
        Me.txtAge.TabIndex = 52
        Me.txtAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtContact.Location = New System.Drawing.Point(397, 69)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(132, 23)
        Me.txtContact.TabIndex = 51
        Me.txtContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSlip
        '
        Me.txtSlip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlip.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSlip.Location = New System.Drawing.Point(659, 70)
        Me.txtSlip.Name = "txtSlip"
        Me.txtSlip.Size = New System.Drawing.Size(96, 23)
        Me.txtSlip.TabIndex = 50
        Me.txtSlip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtName.Location = New System.Drawing.Point(98, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(431, 23)
        Me.txtName.TabIndex = 49
        Me.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDelDate
        '
        Me.txtDelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDelDate.Location = New System.Drawing.Point(559, 8)
        Me.txtDelDate.Name = "txtDelDate"
        Me.txtDelDate.Size = New System.Drawing.Size(96, 23)
        Me.txtDelDate.TabIndex = 48
        Me.txtDelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDelTime
        '
        Me.txtDelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelTime.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDelTime.Location = New System.Drawing.Point(659, 8)
        Me.txtDelTime.Name = "txtDelTime"
        Me.txtDelTime.Size = New System.Drawing.Size(96, 23)
        Me.txtDelTime.TabIndex = 47
        Me.txtDelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTime
        '
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTime.Location = New System.Drawing.Point(433, 8)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(96, 23)
        Me.txtTime.TabIndex = 46
        Me.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDate.Location = New System.Drawing.Point(293, 8)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(96, 23)
        Me.txtDate.TabIndex = 45
        Me.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRecNo
        '
        Me.txtRecNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRecNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecNo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtRecNo.Location = New System.Drawing.Point(98, 8)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.Size = New System.Drawing.Size(96, 23)
        Me.txtRecNo.TabIndex = 44
        Me.txtRecNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Contact #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Patient Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(607, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Patient Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Sample Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Lab ID #"
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(506, 418)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 28)
        Me.cmdDelete.TabIndex = 135
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdComp
        '
        Me.cmdComp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComp.Location = New System.Drawing.Point(596, 418)
        Me.cmdComp.Name = "cmdComp"
        Me.cmdComp.Size = New System.Drawing.Size(85, 28)
        Me.cmdComp.TabIndex = 136
        Me.cmdComp.Text = "Co&mpliment"
        Me.cmdComp.UseVisualStyleBackColor = True
        '
        'txtOper
        '
        Me.txtOper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtOper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtOper.Location = New System.Drawing.Point(63, 421)
        Me.txtOper.Name = "txtOper"
        Me.txtOper.Size = New System.Drawing.Size(138, 23)
        Me.txtOper.TabIndex = 153
        Me.txtOper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 425)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 13)
        Me.Label30.TabIndex = 152
        Me.Label30.Text = "Operator"
        '
        'txtStatus
        '
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtStatus.Location = New System.Drawing.Point(207, 421)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(138, 23)
        Me.txtStatus.TabIndex = 155
        Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TstDataGrid
        '
        Me.TstDataGrid.AllowUserToAddRows = False
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.TstDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.TstDataGrid.AutoGenerateColumns = False
        Me.TstDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.TstDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TstDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TstDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tcode, Me.tname, Me.trate})
        Me.TstDataGrid.DataSource = Me.GridBinding
        Me.TstDataGrid.Enabled = False
        Me.TstDataGrid.GridColor = System.Drawing.Color.Gray
        Me.TstDataGrid.Location = New System.Drawing.Point(5, 181)
        Me.TstDataGrid.Name = "TstDataGrid"
        Me.TstDataGrid.ReadOnly = True
        Me.TstDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TstDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.TstDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.TstDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.TstDataGrid.Size = New System.Drawing.Size(767, 222)
        Me.TstDataGrid.TabIndex = 156
        Me.TstDataGrid.TabStop = False
        '
        'tcode
        '
        Me.tcode.DataPropertyName = "tcode"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.tcode.DefaultCellStyle = DataGridViewCellStyle8
        Me.tcode.HeaderText = "TEST CODE"
        Me.tcode.Name = "tcode"
        Me.tcode.ReadOnly = True
        Me.tcode.Width = 114
        '
        'tname
        '
        Me.tname.DataPropertyName = "tname"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.tname.DefaultCellStyle = DataGridViewCellStyle9
        Me.tname.HeaderText = "TEST NAME"
        Me.tname.Name = "tname"
        Me.tname.ReadOnly = True
        Me.tname.Width = 500
        '
        'trate
        '
        Me.trate.DataPropertyName = "trate"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.trate.DefaultCellStyle = DataGridViewCellStyle10
        Me.trate.HeaderText = "RATE"
        Me.trate.Name = "trate"
        Me.trate.ReadOnly = True
        Me.trate.Width = 110
        '
        'frmDelComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(779, 455)
        Me.Controls.Add(Me.TstDataGrid)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtOper)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cmdComp)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.RecordPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(795, 495)
        Me.MinimumSize = New System.Drawing.Size(785, 485)
        Me.Name = "frmDelComp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete / Complimentary Record"
        CType(Me.GridBinding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordPanel.ResumeLayout(False)
        Me.RecordPanel.PerformLayout()
        CType(Me.TstDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSex As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents GridBinding As System.Windows.Forms.BindingSource
    Friend WithEvents GridDataSet As System.Data.DataSet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RecordPanel As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdComp As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents txtRecNo As System.Windows.Forms.Label
    Friend WithEvents txtRefer As System.Windows.Forms.Label
    Friend WithEvents txtCp As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.Label
    Friend WithEvents txtSlip As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents txtDelDate As System.Windows.Forms.Label
    Friend WithEvents txtDelTime As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.Label
    Friend WithEvents txtDues As System.Windows.Forms.Label
    Friend WithEvents txtDisc As System.Windows.Forms.Label
    Friend WithEvents txtPaid As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOper As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents txtStatus As System.Windows.Forms.Label
    Friend WithEvents TstDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents tcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
