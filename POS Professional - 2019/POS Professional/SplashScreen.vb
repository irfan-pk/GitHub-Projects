Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports Microsoft.VisualBasic

Public NotInheritable Class SplashScreen

    Dim ApplicationRun As Boolean = False

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  
        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Copyright.Text = My.Application.Info.Copyright
        Dim MyHostName As String = ServerName
        Call GetConnectionString()
        Try
            LoginInput.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try
    End Sub

End Class
