Imports System.Data.SqlClient
Imports System.IO

Public Class BackupData
    Dim BackupSet As String
    Dim filedate As System.IO.FileInfo

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            ListView.Items.Clear()

            Dim targetDirectory As String = TextBox1.Text
            Dim fileEntries As String() = System.IO.Directory.GetFiles(targetDirectory, "*.bak")
            Dim fileName As String
            For Each fileName In fileEntries
                filedate = My.Computer.FileSystem.GetFileInfo(fileName)
                Dim TestItem As New ListViewItem
                TestItem.Text = fileName.ToString
                TestItem.SubItems.Add(Format(filedate.LastWriteTime, "MMMM dd,yyyy (dddd)"))
                ListView.Items.Add(TestItem)
            Next fileName
        End If

    End Sub

    Private Sub cmdRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestore.Click
        ' Procedure for Restore First Blank Database backup with default values
        If BackupSet = "" Then
            MsgBox("Please Select backup file before restore")
            Exit Sub
        End If

        Try
            GroupBox1.Visible = False
            Timer1.Enabled = True
            ProgressBar1.Visible = True
            'Drop the connection to the DB by setting the connection to your session only (single user), any current transaction on the DB => it will be rolledback immediatelly
            Dim SetDB1 As String = "ALTER DATABASE POS set SINGLE_USER WITH ROLLBACK IMMEDIATE"
            'Return the connection to the DB to be multi users
            Dim SetDB2 As String = "ALTER DATABASE POS SET MULTI_USER"

            Dim RestoreDatabase As String = "RESTORE DATABASE POS FROM DISK = '" & BackupSet & "' WITH REPLACE"
            Dim RstconStr As String = "Server=" & ServerName & ";Database=master;Trusted_Connection=yes"
            Dim RstobjCon As New SqlConnection(RstconStr)
            Dim Rstobj As New SqlCommand
            Rstobj = RstobjCon.CreateCommand()
            ' Execute Command
            Rstobj.CommandText = SetDB1
            Rstobj.Connection.Open()
            Rstobj.ExecuteNonQuery()

            Rstobj.CommandText = RestoreDatabase
            Rstobj.ExecuteNonQuery()

            Rstobj.CommandText = SetDB2
            Rstobj.ExecuteNonQuery()

            Rstobj.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub ListView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView.Click

        Dim si As Integer = ListView.SelectedIndices(0)
        BackupSet = ListView.Items(si).SubItems(0).Text.Trim()

    End Sub

    Private Sub cmdBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackup.Click

        SaveFileDialog1.FileName = "POS_" & Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "ddmmyyyy")
        SaveFileDialog1.Filter = "Bak files (*.BAK)|*.BAK|All files (*.*)|*.*"
        If (SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            GroupBox1.Visible = False
            Timer1.Enabled = True
            ProgressBar1.Visible = True
            Dim SaveSet As String
            SaveSet = SaveFileDialog1.FileName
            ' Procedure for Restore First Blank Database backup with default values
            Try
                'Drop the connection to the DB by setting the connection to your session only (single user), any current transaction on the DB => it will be rolledback immediatelly
                Dim SetDB1 As String = "ALTER DATABASE POS set SINGLE_USER WITH ROLLBACK IMMEDIATE"
                'Return the connection to the DB to be multi users
                Dim SetDB2 As String = "ALTER DATABASE POS SET MULTI_USER"

                Dim BackupDatabase As String = "BACKUP DATABASE POS TO DISK = '" & SaveSet & "'"
                Dim RstconStr As String = "Server=" & ServerName & ";Database=master;Trusted_Connection=yes"
                Dim RstobjCon As New SqlConnection(RstconStr)
                Dim Rstobj As New SqlCommand
                Rstobj = RstobjCon.CreateCommand()
                ' Execute Command
                Rstobj.CommandText = SetDB1
                Rstobj.Connection.Open()
                Rstobj.ExecuteNonQuery()

                Rstobj.CommandText = BackupDatabase
                Rstobj.ExecuteNonQuery()

                Rstobj.CommandText = SetDB2
                Rstobj.ExecuteNonQuery()

                Rstobj.Connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
            End Try
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            GroupBox1.Visible = True
            MsgBox("Successfully Done")
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub

End Class