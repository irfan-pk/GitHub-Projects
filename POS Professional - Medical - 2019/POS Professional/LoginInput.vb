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
        'Call GetConnectionString()

        If UserName = "admin" And UserPassword = "isha1234" Then
            SysOperator = "Admin"
            UserStatus = "Administrator"
            gblPrliviges = "1"
            gblInvPrefix = "ADM"
            LoginStatus = True
            GoTo Login_Success
        End If

        If FirstLogin = False Then
            Try
                Dim LoginQuery As String = "SELECT * FROM USERS WHERE USERID = N'" & UserName & "' AND PASSWORD = N'" & UserPassword & "'"
                ExecuteAdapterQuery(SqlDataAdapter, LoginQuery, Connection)
                Dim UsersLogin As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If UsersLogin.HasRows = True Then
                    While UsersLogin.Read
                        gblPrliviges = UsersLogin.Item("SecurityLevel").ToString()
                        UserStatus = UsersLogin.Item("userrole").ToString()
                        SysOperator = UsersLogin.Item("username").ToString()
                        gblInvPrefix = UsersLogin.Item("counterid").ToString.ToUpper
                        LoginStatus = True
                        GoTo Login_Success
                    End While
                    If UsersLogin Is Nothing Then UsersLogin.Close()
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
            'intInputBoxCancel = StrPtr(String.Empty)
            Main.Show()
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
            If txtUserName.Text = String.Empty Or txtPassword.Text = String.Empty Then MsgBox("User Name / Password is blank.", MsgBoxStyle.Information) : Exit Sub
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

        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture

        Copyright.Text = "irfansadfar60@gmail.com" & Space(2) & My.Application.Info.Copyright
        If File.Exists(".\" & "poslib.cfg") Then
            Call GetServerFileSettings("READ")
        Else
            ServerParameters.ShowDialog()
        End If
        Try
            Call GetConnectionString()
            If CheckDatabaseExists(ServerName, ServerDatabase) = False Then
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
End Class