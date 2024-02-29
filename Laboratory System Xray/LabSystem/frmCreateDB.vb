' Copyright (c) Microsoft Corporation. All rights reserved.
Imports System.IO
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Imports System.Data.SqlClient
Imports System.Data

Public Class frmCreateDB

    ' Initialize constants for connecting to the database
    ' and displaying a connection error to the user.
    Protected Const SqlConnectionString As String = _
        "Server=(local);" & _
        "DataBase=;" & _
        "Integrated Security=SSPI"

    Protected Const ConnectionErrorMessage As String = _
        "To run this sample, you must have SQL " & _
        "installed.  For " & _
        "instructions on installing SQL, view the documentation file."

    Protected didPreviouslyConnect As Boolean = False
    Protected didCreateTable As Boolean = False
    Protected connectionString As String = SqlConnectionString

#Region "Create database"
    ' Handles the click event for the Create Database button.
    Private Sub btnCreateDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateDB.Click

        ' If the "Create Table" button is enabled this means the user is trying to
        ' recreate the database again in the same application run. Warn the user of
        ' how this will affect things, and if they want to proceed, reset the UI to
        ' the initial state so that errors are not induced if currently enabled 
        ' buttons are clicked out of order.
        If btnCreateTable.Enabled Then
            Dim dr As DialogResult = MessageBox.Show("Recreating the database " & _
                "will undo the other database object creation steps you have " & _
                "made so far. Do you wish to proceed?", "Database Re-creation " & _
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If dr = System.Windows.Forms.DialogResult.Yes Then
                ResetUI()
                CreateDatabase()
            End If
        Else
            CreateDatabase()
        End If

    End Sub


    ' This routine executes a SQL statement that deletes the database (if it exists) 
    ' and then creates it. 
    Private Sub CreateDatabase()
        Dim sqlStatement As String = _
            "IF NOT EXISTS (" & _
            "SELECT * " & _
            "FROM master..sysdatabases " & _
            "WHERE Name = 'XLAB')" & vbCrLf & _
            "CREATE DATABASE XLAB"

        ' Display a status message saying that we're attempting to connect.
        ' This only needs to be done the very first time a connection is
        ' attempted.  After we've determined that MSDE or SQL Server is
        ' installed, this message no longer needs to be displayed.
        Dim statusForm As New Status()
        If Not didPreviouslyConnect Then
            statusForm.Show("Connecting to SQL Server")
        End If

        ' Attempt to connect to the SQL server instance.  
        Try
            ' The SqlConnection class allows you to communicate with SQL Server.
            ' The constructor accepts a connection string as an argument.  This
            ' connection string uses Integrated Security, which means that you 
            ' must have a login in SQL Server, or be part of the Administrators
            ' group for this to work.
            Dim connection As New SqlConnection(connectionString)

            ' A SqlCommand object is used to execute the SQL commands.
            Dim cmd As New SqlCommand(sqlStatement, connection)

            ' Open the connection, execute the command, and close the 
            ' connection. It is more efficient to ExecuteNonQuery when data is 
            ' not being returned.
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()

            ' Data has been successfully submitted.
            didPreviouslyConnect = True
            didCreateTable = True
            statusForm.Close()

            ' Show the controls for the next step.
            lblArrow1.Visible = True
            lblStep2.Enabled = True
            btnCreateTable.Enabled = True

            'MsgBox("Database 'FBR' successfully created.", MsgBoxStyle.OkOnly, "Database Creation Status")
        Catch sqlExc As SqlException
            MsgBox(sqlExc.Message, MsgBoxStyle.OKOnly, "SQL Exception Error")
        Catch exc As Exception
            ' Unable to connect to SQL Server or MSDE
            statusForm.Close()
            MsgBox(exc.Message, MsgBoxStyle.OKOnly, "Connection failed.")
        End Try
    End Sub
#End Region

#Region "Reset UI"
    ' Sets up the user interface so that the user proceeds in proper order
    ' through the steps.
    Private Sub ResetUI()
        lblArrow1.Visible = False
        lblStep2.Enabled = False
        btnCreateTable.Enabled = False
    End Sub
#End Region

#Region "Create table"
    ' Handles the click event for the Create Table button.
    Private Sub btnCreateTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateTable.Click

        If CheckTableExists("PATIENT") = False Then
            Try
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
            Catch sqlExc As SqlException
                MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", _
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        ' On Succes close the form to next form
        exitToolStripMenuItem_Click(sender, e)

    End Sub
#End Region

#Region "Form load"
    ' Handles the Form load event.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ResetUI()
        btnCreateDB_Click(sender, e)
        btnCreateTable_Click(sender, e)
    End Sub
#End Region

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
