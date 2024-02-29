Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public NotInheritable Class SplashScreen
    Dim SqlEnumerator As System.Data.Sql.SqlDataSourceEnumerator


    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        Copyright.Text = My.Application.Info.Copyright
        Dim I As Integer
        For I = 0 To 8000
            For J = 0 To 3000
            Next
        Next

        Dim path As String = Directory.GetCurrentDirectory()

        If File.Exists(".\" & "syslib.cfg") Then
            Call GetServerFileSettings("READ")
        Else
            frmServer.Show()
        End If

        ' Procedure for Creation Database if does'nt exist in sql server

        Try
            If CheckDatabaseExists(ServerName, "XLAB") = False Then
                ' EXECUTE SCRIPT
                Dim conStr As String = "Server=" & ServerName & ";Database=;Integrated Security=SSPI"
                Dim objCon As New SqlConnection(conStr)
                Dim strSQL As String
                strSQL = "CREATE DATABASE XLAB"
                Dim obj As New SqlCommand(strSQL, objCon)
                ' Execute Command
                objCon.Open()
                obj.ExecuteNonQuery()
                objCon.Close()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try

        ' Procedure for Creation Tables if does'nt exist in sql database

        If CheckTableExists() = False Then
            Call Execute_Tables_Script()
        End If

        ' LOAD LOGIN FORM
        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub Execute_Tables_Script()

        '    Holds the script for creating tables in database.
        Dim tableText As String

        '   Path of table creation script in the project folder.
        Dim tableFileName As String = My.Application.Info.DirectoryPath & "\Data\Create_Database_Tables.sql"

        Dim srvMgmtServer As Server = New Server()
        Dim srvConn As New ServerConnection
        Dim objDB As Database = srvMgmtServer.Databases("XLAB")

        srvConn = srvMgmtServer.ConnectionContext
        'srvConn.ServerInstance = ServerName
        'srvConn.LoginSecure = False

        If srvConn.LoginSecure = False Then
            srvConn.Login = ServerID
            srvConn.Password = ServerPwd
        End If

        Using FileReader As New  _
                        Microsoft.VisualBasic.FileIO.TextFieldParser(tableFileName)
            tableText = FileReader.ReadToEnd
        End Using
        Try
            If tableText <> "" Then

                objDB.ExecuteNonQuery(tableText)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try
    End Sub

End Class
