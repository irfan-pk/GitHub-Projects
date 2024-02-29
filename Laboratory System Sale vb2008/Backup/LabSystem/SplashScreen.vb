'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
'Imports System.Runtime.InteropServices
'Imports System.Data
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
        frmLogin.Show()
        Me.Close()

    End Sub

End Class
