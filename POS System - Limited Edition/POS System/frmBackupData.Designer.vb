<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupData
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdRestore = New System.Windows.Forms.Button
        Me.cmdBackup = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.cmdBrowse = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(691, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Specify  to which drive you want to Backup / Restore your database"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdRestore
        '
        Me.cmdRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRestore.Location = New System.Drawing.Point(513, 282)
        Me.cmdRestore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(89, 27)
        Me.cmdRestore.TabIndex = 4
        Me.cmdRestore.Text = "&Restore"
        Me.cmdRestore.UseVisualStyleBackColor = True
        '
        'cmdBackup
        '
        Me.cmdBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBackup.Location = New System.Drawing.Point(610, 282)
        Me.cmdBackup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBackup.Name = "cmdBackup"
        Me.cmdBackup.Size = New System.Drawing.Size(89, 27)
        Me.cmdBackup.TabIndex = 5
        Me.cmdBackup.Text = "&Backup"
        Me.cmdBackup.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 57)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(590, 24)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "C:\"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowse.Location = New System.Drawing.Point(610, 56)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(89, 27)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Br&owse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 311)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(687, 82)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Note"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(451, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2. Check data before backing up."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(451, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1. Please  make sure no one using the system right now."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 366)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(557, 26)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView.Location = New System.Drawing.Point(12, 92)
        Me.ListView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(687, 179)
        Me.ListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView.TabIndex = 3
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Back-Up File"
        Me.ColumnHeader1.Width = 490
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Back-Up File Date"
        Me.ColumnHeader2.Width = 193
        '
        'Timer1
        '
        '
        'frmBackupData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 404)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdBackup)
        Me.Controls.Add(Me.cmdRestore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBackupData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Database Backup / Restore"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdRestore As System.Windows.Forms.Button
    Friend WithEvents cmdBackup As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
