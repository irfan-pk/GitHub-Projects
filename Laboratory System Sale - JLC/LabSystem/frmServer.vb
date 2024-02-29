'Imports System.IO
Imports System
Imports System.Net

Public Class frmServer

    Private Sub Server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ServerName = System.Net.Dns.GetHostName()
        ServerID = "sa"
        ServerDatabase = "JLC"
        txtSrvrName.Text = ServerName.ToString.ToUpper
        txtSrvrUser.Text = ServerID.ToString.ToLower

    End Sub

    Private Sub txtSrvrPwd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSrvrPwd.KeyDown

        If e.KeyCode = Keys.Enter Then
            'If txtSrvrPwd.Text.Trim = "" Or Len(txtSrvrPwd.Text.Trim) < 6 Then
            '    MsgBox("Server Password cannot be blank or less than six characters.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            '    Exit Sub
            'End If
            ServerPwd = txtSrvrPwd.Text.Trim.ToLower
            ServerName = txtSrvrName.Text.ToUpper.Trim
            Call GetServerFileSettings("WRITE")
            SaveServerSettings = True
            Me.Close()
        End If
    End Sub

End Class