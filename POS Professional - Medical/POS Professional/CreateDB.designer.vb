Partial Public Class CreateDB
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateDB))
        Me.lblStep2 = New System.Windows.Forms.Label
        Me.btnCreateTable = New System.Windows.Forms.Button
        Me.lblArrow1 = New System.Windows.Forms.Label
        Me.lblStep1 = New System.Windows.Forms.Label
        Me.btnCreateDB = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStep2
        '
        Me.lblStep2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblStep2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStep2.Location = New System.Drawing.Point(179, 81)
        Me.lblStep2.Margin = New System.Windows.Forms.Padding(0, 3, 2, 3)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(16, 23)
        Me.lblStep2.TabIndex = 43
        Me.lblStep2.Text = "2."
        '
        'btnCreateTable
        '
        Me.btnCreateTable.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnCreateTable.ForeColor = System.Drawing.Color.White
        Me.btnCreateTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCreateTable.Location = New System.Drawing.Point(199, 73)
        Me.btnCreateTable.Margin = New System.Windows.Forms.Padding(2, 3, 3, 3)
        Me.btnCreateTable.Name = "btnCreateTable"
        Me.btnCreateTable.Size = New System.Drawing.Size(104, 23)
        Me.btnCreateTable.TabIndex = 42
        Me.btnCreateTable.Text = "Create &Table"
        Me.btnCreateTable.UseVisualStyleBackColor = False
        '
        'lblArrow1
        '
        Me.lblArrow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblArrow1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArrow1.Location = New System.Drawing.Point(147, 77)
        Me.lblArrow1.Margin = New System.Windows.Forms.Padding(3, 3, 1, 3)
        Me.lblArrow1.Name = "lblArrow1"
        Me.lblArrow1.Size = New System.Drawing.Size(31, 23)
        Me.lblArrow1.TabIndex = 41
        Me.lblArrow1.Text = ">>"
        '
        'lblStep1
        '
        Me.lblStep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblStep1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStep1.Location = New System.Drawing.Point(16, 80)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(16, 23)
        Me.lblStep1.TabIndex = 40
        Me.lblStep1.Text = "1."
        '
        'btnCreateDB
        '
        Me.btnCreateDB.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnCreateDB.ForeColor = System.Drawing.Color.White
        Me.btnCreateDB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCreateDB.Location = New System.Drawing.Point(36, 73)
        Me.btnCreateDB.Name = "btnCreateDB"
        Me.btnCreateDB.Size = New System.Drawing.Size(104, 23)
        Me.btnCreateDB.TabIndex = 39
        Me.btnCreateDB.Text = "Create &Database"
        Me.btnCreateDB.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Database Initializing Wait ....."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'CreateDB
        '
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(330, 132)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblStep2)
        Me.Controls.Add(Me.btnCreateTable)
        Me.Controls.Add(Me.lblArrow1)
        Me.Controls.Add(Me.lblStep1)
        Me.Controls.Add(Me.btnCreateDB)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initializing..."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend Shared ReadOnly Property GetInstance() As CreateDB
        Get
            If m_DefaultInstance Is Nothing OrElse m_DefaultInstance.IsDisposed() Then
                SyncLock m_SyncObject
                    If m_DefaultInstance Is Nothing OrElse m_DefaultInstance.IsDisposed() Then
                        m_DefaultInstance = New CreateDB
                    End If
                End SyncLock
            End If
            Return m_DefaultInstance
        End Get
    End Property

    Private Shared m_DefaultInstance As CreateDB
    Private Shared m_SyncObject As New Object
    Friend WithEvents lblStep2 As System.Windows.Forms.Label
    Friend WithEvents btnCreateTable As System.Windows.Forms.Button
    Friend WithEvents lblArrow1 As System.Windows.Forms.Label
    Friend WithEvents lblStep1 As System.Windows.Forms.Label
    Friend WithEvents btnCreateDB As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
