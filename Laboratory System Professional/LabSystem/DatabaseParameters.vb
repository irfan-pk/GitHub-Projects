Imports System.IO

Public Class DatabaseParameters

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        If txtPath.Text.Trim = "" Then MsgBox("Please Select Drive Letter for Database File.", MsgBoxStyle.Critical, My.Application.Info.ProductName) : Exit Sub
        Try
            gblDatabasePath = txtPath.Text.Trim & "Database"
            If Not Directory.Exists(gblDatabasePath) Then
                Directory.CreateDirectory(gblDatabasePath)
            End If
            CreateDB.Show()
            MainForm.menuMAIN.Visible = True
            Me.Close()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        MainForm.menuMAIN.Visible = True
        Me.Close()
    End Sub

    Private Sub DatabaseParameters_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainForm.menuMAIN.Visible = True
        Me.Close()
    End Sub

    Private Sub DatabaseParameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each Drive In Environment.GetLogicalDrives
            Dim DriveLetter As DriveInfo = New DriveInfo(Drive)
            If DriveLetter.DriveType = DriveType.Fixed Then
                txtPath.Items.Add(Drive)
            End If
        Next
    End Sub
End Class