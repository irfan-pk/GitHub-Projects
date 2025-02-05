Imports System.Data.SqlClient
Imports System.IO

Public Class BackupData
    Dim con As SqlConnection
    Dim cmd As SqlCommand
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
                TestItem.SubItems.Add(Format(filedate.LastWriteTime, "MMM dd,yyyy (ddd)"))
                ListView.Items.Add(TestItem)
            Next fileName
        End If
    End Sub

    Private Sub cmdRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestore.Click
        ' Procedure for Restore First Blank Database backup with default values
        If BackupSet = String.Empty Then
            MsgBox("Please Select backup file before restore")
            Exit Sub
        End If
        Dim dr As DialogResult = MessageBox.Show("Restoring the Database will disconnect all server / clients connections with " & _
                                                 "sql server, after restoring database rerun application. Do you wish to proceed ?", "Database " & _
                                                 "Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dr = System.Windows.Forms.DialogResult.Yes Then
            Connection.Close()
            Connection.Dispose()
            Call KillSqlConnections()
            Try
                GroupBox1.Visible = False
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                Dim RestoreDatabase As String = "RESTORE DATABASE " & ServerDatabase & " FROM DISK = '" & BackupSet & "' WITH REPLACE"
                cmd = New SqlCommand(RestoreDatabase, con)
                cmd.ExecuteNonQuery()
                Application.Exit()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
            End Try
        Else
            cmdRestore.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub ListView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView.Click
        Dim si As Integer = ListView.SelectedIndices(0)
        BackupSet = ListView.Items(si).SubItems(0).Text.Trim()
        cmdRestore.Enabled = True
    End Sub

    Private Sub cmdBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackup.Click
        SaveFileDialog1.FileName = ServerDatabase & "-" & Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "ddmmyyyy")
        SaveFileDialog1.Filter = "Bak files (*.BAK)|*.BAK|All files (*.*)|*.*"
        If (SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            GroupBox1.Visible = False
            Timer1.Enabled = True
            ProgressBar1.Visible = True
            Dim SaveSet As String
            SaveSet = SaveFileDialog1.FileName
            Try
                Dim BackupDatabase As String = "BACKUP DATABASE " & ServerDatabase & " TO DISK = '" & SaveSet & "'"
                cmd = New SqlCommand(BackupDatabase, con)
                cmd.ExecuteNonQuery()
                Call GetBackupFiles()
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

    Private Sub BackupData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=" & Trim(ServerName) & ";Database=Master;integrated security=SSPI;")
        con.Open()
        'TextBox1.Text = "D:\"
    End Sub

    Private Sub KillSqlConnections()
        Dim connString As String = ("Data Source=" & ServerName & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=master;")
        Dim conn As New SqlClient.SqlConnection(connString)
        Dim cmd As New SqlClient.SqlCommand
        Dim objReader As System.IO.StreamReader
        Try
            conn.Open()
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            objReader = New System.IO.StreamReader(My.Application.Info.DirectoryPath & "\Dlls\KillDatabaseConnection.sql")
            cmd.CommandText = objReader.ReadToEnd
            cmd.Parameters.Add(New SqlParameter("@DBNAME", ServerDatabase))
            cmd.ExecuteNonQuery()
            objReader.Close()
            conn.Close()
            conn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try
        'Reserved for stored procedure
        'Dim connString As String = ("Data Source=" & Trim(ServerName) & ";Database=master;integrated security=SSPI;")
        'Dim cmdText As String = ""
        'Using sqlConnection As SqlConnection = New SqlConnection(connString)
        '    sqlConnection.Open()
        '    Dim sqlCmd As New SqlCommand
        '    sqlCmd.Connection = sqlConnection
        '    sqlCmd.CommandText = "sp_Kill"
        '    sqlCmd.CommandType = CommandType.StoredProcedure
        '    sqlCmd.Parameters.Add(New SqlParameter("@DBNAME", ServerDatabase))
        '    sqlCmd.ExecuteNonQuery()
        '    sqlConnection.Close()
        '    sqlConnection.Dispose()
        'End Using
    End Sub

    Private Sub GetBackupFiles()
        Dim targetDirectory As String = TextBox1.Text
        Dim fileEntries As String() = System.IO.Directory.GetFiles(targetDirectory, "*.bak")
        Dim fileName As String
        For Each fileName In fileEntries
            filedate = My.Computer.FileSystem.GetFileInfo(fileName)
            Dim TestItem As New ListViewItem
            TestItem.Text = fileName.ToString
            TestItem.SubItems.Add(Format(filedate.LastWriteTime, "MMM dd,yyyy (ddd)"))
            ListView.Items.Add(TestItem)
        Next fileName
    End Sub

End Class