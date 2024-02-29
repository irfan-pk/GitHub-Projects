' Copyright (c) Microsoft Corporation. All rights reserved.
Imports System.IO
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Imports System.Data.SqlClient
Imports System.Data

Public Class CreateDB

    Private cmd As SqlCommand = Nothing
    Private sql As String = Nothing

    ' Initialize constants for connecting to the database
    ' and displaying a connection error to the user.
    Protected Const SqlConnectionString As String = _
        "Server=(local);" & _
        "DataBase=;" & _
        "Integrated Security=SSPI"

    Protected Const ConnectionErrorMessage As String = _
        "To run this, you must have SQL " & _
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
        'Dim sqlStatement As String = _
        '    "IF NOT EXISTS (" & _
        '    "SELECT * " & _
        '    "FROM master..sysdatabases " & _
        '    "WHERE Name = 'LAB_PRO')" & vbCrLf & _
        '    "CREATE DATABASE LAB_PRO"

        Dim sqlStatement As String = _
            "CREATE DATABASE LAB_PRO " & _
            "ON PRIMARY ( NAME = LAB_PRO,FILENAME = '" & gblDatabasePath & "\LAB_PRO.mdf',SIZE = 10,MAXSIZE = UNLIMITED,FILEGROWTH = 1024KB) " & _
            "LOG ON ( NAME = LAB_PRO_log,FILENAME = '" & gblDatabasePath & "\LAB_PRO_log.ldf',SIZE = 5MB,MAXSIZE = UNLIMITED,FILEGROWTH = 10% )"

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

            'MsgBox("Database successfully created.", MsgBoxStyle.OkOnly, "Database Creation Status")
        Catch sqlExc As SqlException
            MsgBox(sqlExc.Message, MsgBoxStyle.OkOnly, "SQL Exception Error")
            Application.Exit()
        Catch exc As Exception
            ' Unable to connect to SQL Server or MSDE
            statusForm.Close()
            MsgBox(exc.Message, MsgBoxStyle.OkOnly, "Connection failed.")
            Application.Exit()
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

#Region "Create tables"
    ' Handles the click event for the Create Table button.
    Private Sub btnCreateTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateTable.Click
        Dim connString As String = ("Data Source=" & ServerName & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim conn As New SqlClient.SqlConnection(connString)
        Dim cmd As New SqlClient.SqlCommand
        Dim objReader As System.IO.StreamReader
        If CheckTableExists("Patient") = False Then
            Try
                conn.Open()
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                objReader = New System.IO.StreamReader(My.Application.Info.DirectoryPath & "\Dlls\Create_Database_Tables.sql")
                cmd.CommandText = objReader.ReadToEnd
                cmd.CommandText = cmd.CommandText.Replace("GO", ";")
                cmd.CommandText.Split(";")
                cmd.ExecuteNonQuery()
                objReader.Close()
                conn.Close()
                conn = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
            End Try
        End If

        Try
            Call GetConnectionString()
            Connection.Open()
            sql = "INSERT into ACCOUNTS VALUES(01,'REVENUE','" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "','Lab Receipts','CR',0.00,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "',0.00,0.00)"
            cmd = New SqlCommand(sql, Connection)
            cmd.ExecuteNonQuery()
            sql = "INSERT into ACCOUNTS VALUES(02,'ASSETS','" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "','Lab Dues','DR',0.00,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "',0.00,0.00)"
            cmd = New SqlCommand(sql, Connection)
            cmd.ExecuteNonQuery()
            sql = "INSERT into ACCOUNTS VALUES(03,'EXPENSES','" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "','Lab Discount','DR',0.00,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "',0.00,0.00)"
            cmd = New SqlCommand(sql, Connection)
            cmd.ExecuteNonQuery()
            sql = "INSERT into ACCOUNTS VALUES(04,'EXPENSES','" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "','Complimentary','DR',0.00,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "',0.00,0.00)"
            cmd = New SqlCommand(sql, Connection)
            cmd.ExecuteNonQuery()
            sql = "INSERT into ACCOUNTS VALUES(05,'EXPENSES','" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "','Cancelled Cases','DR',0.00,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "',0.00,0.00)"
            cmd = New SqlCommand(sql, Connection)
            cmd.ExecuteNonQuery()
            sql = "INSERT into ACCOUNTS VALUES(06,'ASSETS','" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "','Cash','DR',0.00,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & "',0.00,0.00)"
            cmd = New SqlCommand(sql, Connection)
            cmd.ExecuteNonQuery()
            Connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "SQL Exception Error")
        End Try

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
