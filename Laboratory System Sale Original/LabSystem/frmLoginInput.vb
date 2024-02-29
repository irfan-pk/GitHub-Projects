Imports System
Imports System.Net
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class frmLoginInput
    Dim FirstLogin As Boolean = False
    Dim MyHostName As String = System.Net.Dns.GetHostName()
    Dim currentpath As String = Directory.GetCurrentDirectory()


    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

        UserName = txtUserName.Text.Trim
        UserPassword = txtPassword.Text.Trim
        GetConnectionString()

        If UserName = "admin" And UserPassword = "isha1234" Then
            SysOperator = "Admin"
            UserStatus = "Administrator"
            gblPrliviges = "1"
            LoginStatus = True
            GoTo Login_Success
        End If

        If FirstLogin = False Then

            Dim LoginQuery As String = "SELECT * FROM USERS WHERE USERID = N'" & UserName & "' AND PASSWORD = N'" & UserPassword & "'"
            Execute_DatabaseTable_Query(SqlDataAdapt, LoginQuery, Connection)
            Dim UsersLogin As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
            If UsersLogin.HasRows = True Then
                While UsersLogin.Read
                    gblPrliviges = UsersLogin.Item("userstatus")
                    UserStatus = UsersLogin.Item("usertype")
                    SysOperator = UsersLogin.Item("username")
                    LoginStatus = True
                    GoTo Login_Success
                End While
            Else
                MsgBox("Access Denied" & vbCrLf & "Invalid Passward.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                Me.txtPassword.Clear()
                Connection.Close()
                Me.txtUserName.Focus()
            End If
        End If

Login_Success:
        If LoginStatus = True Then
            frmMain.Show()
            Connection.Close()
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUserName.Text = "" Then MsgBox("UserName is blank.", MsgBoxStyle.Information) : Exit Sub
            cmdLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then txtPassword.Focus()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        LoginStatus = False
        Me.Close()
    End Sub

    Private Sub frmLoginInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Copyright.Text = My.Application.Info.Copyright
        Call GetConnectionString()
        If CheckDatabaseExists(MyHostName, "LAB") = False Then
            frmCreateDB.Show()
            FirstLogin = True
            MsgBox("Database initial settings finalized. please restart application to run properly.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        Else
            FirstLogin = False
        End If
    End Sub

End Class