<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReception
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReception))
        Me.lblPatient = New System.Windows.Forms.Label
        Me.lblStatements = New System.Windows.Forms.Label
        Me.lblRate = New System.Windows.Forms.Label
        Me.lblPrint = New System.Windows.Forms.Label
        Me.lblLog = New System.Windows.Forms.Label
        Me.lblExit = New System.Windows.Forms.Label
        Me.pbExit = New System.Windows.Forms.PictureBox
        Me.pbLogon = New System.Windows.Forms.PictureBox
        Me.pbPrint = New System.Windows.Forms.PictureBox
        Me.pbRates = New System.Windows.Forms.PictureBox
        Me.pbStatements = New System.Windows.Forms.PictureBox
        Me.pbPatientFile = New System.Windows.Forms.PictureBox
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStatements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPatientFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPatient
        '
        Me.lblPatient.BackColor = System.Drawing.Color.Transparent
        Me.lblPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient.Location = New System.Drawing.Point(104, 193)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(90, 34)
        Me.lblPatient.TabIndex = 0
        Me.lblPatient.Text = "Patient Entry"
        Me.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatements
        '
        Me.lblStatements.BackColor = System.Drawing.Color.Transparent
        Me.lblStatements.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatements.Location = New System.Drawing.Point(237, 193)
        Me.lblStatements.Name = "lblStatements"
        Me.lblStatements.Size = New System.Drawing.Size(90, 34)
        Me.lblStatements.TabIndex = 1
        Me.lblStatements.Text = "Statements"
        Me.lblStatements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRate
        '
        Me.lblRate.BackColor = System.Drawing.Color.Transparent
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(500, 193)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(90, 34)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Rate Information"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrint
        '
        Me.lblPrint.BackColor = System.Drawing.Color.Transparent
        Me.lblPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrint.Location = New System.Drawing.Point(371, 193)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(90, 34)
        Me.lblPrint.TabIndex = 2
        Me.lblPrint.Text = "Print Receipt"
        Me.lblPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLog
        '
        Me.lblLog.BackColor = System.Drawing.Color.Transparent
        Me.lblLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.Location = New System.Drawing.Point(237, 340)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(90, 26)
        Me.lblLog.TabIndex = 4
        Me.lblLog.Text = "Log On / Off"
        Me.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(371, 340)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(90, 26)
        Me.lblExit.TabIndex = 5
        Me.lblExit.Text = "Exit"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbExit
        '
        Me.pbExit.BackColor = System.Drawing.Color.Transparent
        Me.pbExit.Image = Global.Business_Solutions.My.Resources.Resources.Gnome_Application_Exit_64
        Me.pbExit.Location = New System.Drawing.Point(371, 257)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(90, 84)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbExit.TabIndex = 10
        Me.pbExit.TabStop = False
        '
        'pbLogon
        '
        Me.pbLogon.BackColor = System.Drawing.Color.Transparent
        Me.pbLogon.Image = CType(resources.GetObject("pbLogon.Image"), System.Drawing.Image)
        Me.pbLogon.Location = New System.Drawing.Point(237, 257)
        Me.pbLogon.Name = "pbLogon"
        Me.pbLogon.Size = New System.Drawing.Size(90, 84)
        Me.pbLogon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLogon.TabIndex = 8
        Me.pbLogon.TabStop = False
        '
        'pbPrint
        '
        Me.pbPrint.BackColor = System.Drawing.Color.Transparent
        Me.pbPrint.Image = CType(resources.GetObject("pbPrint.Image"), System.Drawing.Image)
        Me.pbPrint.Location = New System.Drawing.Point(371, 110)
        Me.pbPrint.Name = "pbPrint"
        Me.pbPrint.Size = New System.Drawing.Size(90, 84)
        Me.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbPrint.TabIndex = 6
        Me.pbPrint.TabStop = False
        '
        'pbRates
        '
        Me.pbRates.BackColor = System.Drawing.Color.Transparent
        Me.pbRates.Image = CType(resources.GetObject("pbRates.Image"), System.Drawing.Image)
        Me.pbRates.Location = New System.Drawing.Point(500, 110)
        Me.pbRates.Name = "pbRates"
        Me.pbRates.Size = New System.Drawing.Size(90, 84)
        Me.pbRates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRates.TabIndex = 4
        Me.pbRates.TabStop = False
        '
        'pbStatements
        '
        Me.pbStatements.BackColor = System.Drawing.Color.Transparent
        Me.pbStatements.Image = CType(resources.GetObject("pbStatements.Image"), System.Drawing.Image)
        Me.pbStatements.Location = New System.Drawing.Point(237, 110)
        Me.pbStatements.Name = "pbStatements"
        Me.pbStatements.Size = New System.Drawing.Size(90, 84)
        Me.pbStatements.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbStatements.TabIndex = 2
        Me.pbStatements.TabStop = False
        '
        'pbPatientFile
        '
        Me.pbPatientFile.BackColor = System.Drawing.Color.Transparent
        Me.pbPatientFile.Image = CType(resources.GetObject("pbPatientFile.Image"), System.Drawing.Image)
        Me.pbPatientFile.Location = New System.Drawing.Point(104, 110)
        Me.pbPatientFile.Name = "pbPatientFile"
        Me.pbPatientFile.Size = New System.Drawing.Size(90, 84)
        Me.pbPatientFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPatientFile.TabIndex = 0
        Me.pbPatientFile.TabStop = False
        '
        'frmReception
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(697, 392)
        Me.Controls.Add(Me.pbExit)
        Me.Controls.Add(Me.pbLogon)
        Me.Controls.Add(Me.pbPrint)
        Me.Controls.Add(Me.pbRates)
        Me.Controls.Add(Me.pbStatements)
        Me.Controls.Add(Me.pbPatientFile)
        Me.Controls.Add(Me.lblPatient)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.lblPrint)
        Me.Controls.Add(Me.lblStatements)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReception"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.PowderBlue
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStatements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPatientFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbPatientFile As System.Windows.Forms.PictureBox
    Friend WithEvents lblPatient As System.Windows.Forms.Label
    Friend WithEvents lblStatements As System.Windows.Forms.Label
    Friend WithEvents pbStatements As System.Windows.Forms.PictureBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents pbRates As System.Windows.Forms.PictureBox
    Friend WithEvents lblPrint As System.Windows.Forms.Label
    Friend WithEvents pbPrint As System.Windows.Forms.PictureBox
    Friend WithEvents lblLog As System.Windows.Forms.Label
    Friend WithEvents pbLogon As System.Windows.Forms.PictureBox
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents pbExit As System.Windows.Forms.PictureBox
End Class
