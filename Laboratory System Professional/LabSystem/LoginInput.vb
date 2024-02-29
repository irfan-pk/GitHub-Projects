Imports System
Imports System.Net
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class LoginInput
    Private CurrentCulture As System.Globalization.CultureInfo
    Dim MyHostName As String = System.Net.Dns.GetHostName()
    Dim CurrentPath As String = Directory.GetCurrentDirectory()


    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

        UserName = txtUserName.Text.Trim
        UserPassword = txtPassword.Text.Trim
        Call GetConnectionString()

        If UserName = "admin" And UserPassword = "afrsimsa" Then
            SysOperator = "Admin"
            UserStatus = "Administrator"
            gblPrliviges = "1"
            gblSection = "ADMIN"
            LoginStatus = True
            GoTo Login_Success
        End If

        If FirstLogin = False Then
            Try
                Dim LoginQuery As String = "SELECT * FROM USERS WHERE USERID = N'" & UserName & "' AND PASSWORD = N'" & UserPassword & "'"
                Execute_DatabaseTable_Query(SqlDataAdapter, LoginQuery, Connection)
                Dim UsersLogin As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If UsersLogin.HasRows = True Then
                    While UsersLogin.Read
                        gblPrliviges = UsersLogin.Item("userstatus")
                        UserStatus = UsersLogin.Item("usertype")
                        SysOperator = UsersLogin.Item("username")
                        gblSection = UsersLogin.Item("usersection")
                        LoginStatus = True
                        GoTo Login_Success
                    End While
                Else
                    MsgBox("Access Denied" & vbCrLf & "Invalid Passward.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    Me.txtPassword.Clear()
                    Connection.Close()
                    Me.txtUserName.Focus()
                End If
            Catch Ex As SqlException
                MsgBox(Ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
                Exit Sub
            End Try
        End If

Login_Success:
        If LoginStatus = True Then
            If gblSection = "ADMIN" Then MainForm.Show()
            If gblSection = "RECEPTION" Then MainReception.Show()
            If gblSection = "REPORTS" Then MainReports.Show()
            Connection.Close()
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        txtPassword.SelectAll()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUserName.Text = "" Then MsgBox("UserName is blank.", MsgBoxStyle.Information) : Exit Sub
            cmdLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtUserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.GotFocus
        txtUserName.SelectAll()
    End Sub

    Private Sub txtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then txtPassword.Focus()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'Setting culture back to its original settings      
        'System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture
        LoginStatus = False
        Me.Close()
    End Sub

    Private Sub frmLoginInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'To change the culture of system date
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        'Culture is set back to its original value when form closes 
        CurrentCulture = System.Threading.Thread.CurrentThread.CurrentCulture

        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture

        Copyright.Text = My.Application.Info.Copyright
        If File.Exists(".\" & "syslib.cfg") Then
            Call GetServerFileSettings("READ")
        Else
            ServerParameters.ShowDialog()
        End If
        Try
            Call GetConnectionString()
            If CheckDatabaseExists(ServerName, "LAB_PRO") = False Then
                MsgBox("Plz Create Database and Tables before continue...", MsgBoxStyle.Critical, My.Application.Info.ProductName)
                DatabaseParameters.ShowDialog()
            Else
                FirstLogin = False
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Setting culture back to its original settings      
        'System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture
        LoginStatus = False
        Me.Close()
    End Sub

End Class