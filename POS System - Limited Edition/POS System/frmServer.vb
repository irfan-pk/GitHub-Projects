Imports System
Imports System.Net

Public Class frmServer

    Private Sub frmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ServerName = System.Net.Dns.GetHostName()
        ServerID = "sa"
        ServerDatabase = "POS"
        txtSrvrName.Text = ServerName.ToString.ToUpper
        txtSrvrUser.Text = ServerID.ToString.ToLower
        Me.TopMost = True

    End Sub

    Private Sub txtSrvrPwd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSrvrPwd.KeyDown

        If e.KeyCode = Keys.Enter Then
            ServerPwd = txtSrvrPwd.Text.Trim.ToLower
            ServerName = txtSrvrName.Text.ToUpper.Trim
            Call GetServerFileSettings("WRITE")
            SaveServerSettings = True
            Me.Close()
        End If
    End Sub

End Class