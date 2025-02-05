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
        "To run this application, you must have SQL server 2008" & _
        "installed.  For " & _
        "instructions on installing SQL, contact the microsoft online."

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
            "WHERE Name = 'POS')" & vbCrLf & _
            "CREATE DATABASE POS"

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
        GetConnectionString()
        Dim SqlCommand(18) As String
        If CheckTableExists("PRODUCTS") = False Then
            Try
                SqlCommand(0) = "CREATE TABLE Users(UserId int NULL," & _
                                "UserName varchar(50) NULL," & _
                                "Password varchar(200) NULL," & _
                                "Name varchar(100) NULL," & _
                                "UserRole varchar(50) NULL," & _
                                "SecurityLevel int NULL," & _
                                "Active bit NULL, " & _
                                "CardNumber varchar(200) NULL)"

                SqlCommand(1) = "CREATE TABLE TABLE_MASTER(" & _
                                "SaleID decimal(18, 0) NULL," & _
                                "DrawerID int NULL," & _
                                "DrawerName varchar(50) NULL," & _
                                "DateCompleted date NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "OfflineID varchar(100) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "SaleTotal float NULL," & _
                                "SalePaid float NULL," & _
                                "SaleDiscount float NULL," & _
                                "SaleChange float NULL," & _
                                "SaleStatus int NULL," & _
                                "SaleCredit float NULL," & _
                                "SaleReturn float NULL," & _
                                "SaleRecovery float NULL," & _
                                "DateRecovery date NULL)"

                SqlCommand(2) = "CREATE TABLE TABLE_DETAIL(" & _
                                "DetailID decimal(18, 0) NULL," & _
                                "DetailDate date NULL," & _
                                "SaleID decimal(18, 0) NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "StockID char(50) NULL," & _
                                "StockDesc varchar(100) NULL," & _
                                "SaleTable varchar(10) NULL," & _
                                "UnitCost float NULL," & _
                                "Qty float NULL," & _
                                "Price float NULL," & _
                                "TableStatus varchar(10) NULL," & _
                                "DrawerID int NULL," & _
                                "TaxPercentage float NULL," & _
                                "PriceInc float NULL," & _
                                "TotalPriceExcl float NULL," & _
                                "TotalPriceInc float NULL," & _
                                "DiscountDetailID int NULL," & _
                                "AOptions varchar(200) NULL," & _
                                "SortItem int NULL)"

                SqlCommand(3) = "CREATE TABLE SUPPLIERS_PAYM(" & _
                                "Supl_Code int NULL," & _
                                "Supl_Tr_Dt date NULL," & _
                                "Supl_Tr_ID decimal(18, 0) NULL," & _
                                "Supl_Name char(50) NULL," & _
                                "Supl_Desc char(200) NULL," & _
                                "Supl_Opn_Bal decimal(18, 2) NULL," & _
                                "Supl_Debit decimal(18, 2) NULL," & _
                                "Supl_Credit decimal(18, 2) NULL," & _
                                "Supl_Balance decimal(18, 2) NULL," & _
                                "Supl_Upt_dt date NULL)"

                SqlCommand(4) = "CREATE TABLE SUPPLIERS(" & _
                                "Supl_Code int NULL," & _
                                "Supl_Name char(50) NULL," & _
                                "Supl_Address char(150) NULL," & _
                                "Supl_City char(10) NULL," & _
                                "Supl_Tel char(15) NULL," & _
                                "Supl_Mob char(11) NULL," & _
                                "Supl_Balance decimal(18, 2) NULL," & _
                                "Supl_Upd_dt date NULL)"

                SqlCommand(5) = "CREATE TABLE SALE_MASTER_TEMP(" & _
                                "SaleID decimal(18, 0) NULL," & _
                                "DrawerID int NULL," & _
                                "DrawerName varchar(50) NULL," & _
                                "DateCompleted date NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "OfflineID varchar(100) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "SaleTotal float NULL," & _
                                "SalePaid float NULL," & _
                                "SaleDiscount float NULL," & _
                                "SaleChange float NULL," & _
                                "SaleStatus int NULL," & _
                                "SaleCredit float NULL," & _
                                "SaleReturn float NULL," & _
                                "SaleRecovery float NULL," & _
                                "DateRecovery date NULL)"

                SqlCommand(6) = "CREATE TABLE SALE_MASTER_HOLD(" & _
                                "SaleID decimal(18, 0) NULL," & _
                                "DrawerID int NULL," & _
                                "DrawerName varchar(50) NULL," & _
                                "DateCompleted date NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "OfflineID varchar(100) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "SaleTotal float NULL," & _
                                "SalePaid float NULL," & _
                                "SaleDiscount int NULL," & _
                                "SaleChange float NULL," & _
                                "SaleStatus int NULL," & _
                                "SaleCredit float NULL," & _
                                "SaleReturn float NULL," & _
                                "SaleRecovery float NULL," & _
                                "DateRecovery date NULL)"

                SqlCommand(7) = "CREATE TABLE SALE_MASTER(" & _
                                "SaleID decimal(18, 0) NULL," & _
                                "DrawerID int NULL," & _
                                "DrawerName varchar(50) NULL," & _
                                "DateCompleted date NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "OfflineID varchar(100) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "SaleTotal float NULL," & _
                                "SalePaid float NULL," & _
                                "SaleDiscount float NULL," & _
                                "SaleChange float NULL," & _
                                "SaleStatus int NULL," & _
                                "SaleCredit float NULL," & _
                                "SaleReturn float NULL," & _
                                "SaleRecovery float NULL," & _
                                "DateRecovery date NULL)"

                SqlCommand(8) = "CREATE TABLE SALE_DETAIL_TEMP(" & _
                                "DetailID decimal(18, 0) NULL," & _
                                "DetailDate date NULL," & _
                                "SaleID decimal(18, 0) NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "StockID char(50) NULL," & _
                                "StockDesc varchar(100) NULL," & _
                                "SalePack varchar(10) NULL," & _
                                "UnitCost float NULL," & _
                                "Qty float NULL," & _
                                "Price float NULL," & _
                                "SaleStatus varchar(10) NULL," & _
                                "DrawerID int NULL," & _
                                "TaxPercentage float NULL," & _
                                "PriceInc float NULL," & _
                                "TotalPriceExcl float NULL," & _
                                "TotalPriceInc float NULL," & _
                                "DiscountDetailID int NULL," & _
                                "AOptions varchar(200) NULL," & _
                                "SortItem int NULL)"

                SqlCommand(9) = "CREATE TABLE SALE_DETAIL_HOLD(" & _
                                "DetailID decimal(18, 0) NULL," & _
                                "DetailDate date NULL," & _
                                "SaleID decimal(18, 0) NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "StockID char(50) NULL," & _
                                "StockDesc varchar(100) NULL," & _
                                "SalePack varchar(10) NULL," & _
                                "UnitCost float NULL," & _
                                "Qty float NULL," & _
                                "Price float NULL," & _
                                "SaleStatus varchar(10) NULL," & _
                                "DrawerID int NULL," & _
                                "TaxPercentage float NULL," & _
                                "PriceInc float NULL," & _
                                "TotalPriceExcl float NULL," & _
                                "TotalPriceInc float NULL," & _
                                "DiscountDetailID int NULL," & _
                                "AOptions varchar(200) NULL," & _
                                "SortItem int NULL)"

                SqlCommand(10) = "CREATE TABLE SALE_DETAIL(" & _
                                 "DetailID decimal(18, 0) NULL," & _
                                 "DetailDate date NULL," & _
                                 "SaleID decimal(18, 0) NULL," & _
                                 "SaleType varchar(50) NULL," & _
                                 "CustomerID int NULL," & _
                                 "CustomerName varchar(100) NULL," & _
                                 "StockID char(50) NULL," & _
                                 "StockDesc varchar(100) NULL," & _
                                 "SalePack varchar(10) NULL," & _
                                 "UnitCost float NULL," & _
                                 "Qty float NULL," & _
                                 "Price float NULL," & _
                                 "SaleStatus varchar(10) NULL," & _
                                 "DrawerID int NULL," & _
                                 "TaxPercentage float NULL," & _
                                 "PriceInc float NULL," & _
                                 "TotalPriceExcl float NULL," & _
                                 "TotalPriceInc float NULL," & _
                                 "DiscountDetailID int NULL," & _
                                 "AOptions varchar(200) NULL," & _
                                 "SortItem int NULL)"

                SqlCommand(11) = "CREATE TABLE PURCHASE(" & _
                                 "PRCH_TR_ID decimal(18, 0) NULL," & _
                                 "PRCH_CD char(50) NULL," & _
                                 "PRCH_DESC char(200) NULL," & _
                                 "PRCH_CATG char(50) NULL," & _
                                 "PRCH_PACK char(10) NULL," & _
                                 "PRCH_PRICE float NULL," & _
                                 "PRCH_QTY int NULL," & _
                                 "PRCH_OLD_QTY int NULL," & _
                                 "PRCH_BAL_MIN int NULL," & _
                                 "PRCH_SCH1_PRICE float NULL," & _
                                 "PRCH_SCH1_ONHAND int NULL," & _
                                 "PRCH_SCH2_PRICE float NULL," & _
                                 "PRCH_SCH2_ONHAND int NULL," & _
                                 "PRCH_SCH3_PRICE float NULL," & _
                                 "PRCH_SCH3_ONHAND int NULL," & _
                                 "PRCH_VAT float NULL," & _
                                 "PRCH_ITAX float NULL," & _
                                 "PRCH_EX_DUTY float NULL," & _
                                 "PRCH_PROFIT float NULL," & _
                                 "PRCH_DISC_MRG float NULL," & _
                                 "PRCH_SPRICE float NULL," & _
                                 "PRCH_DATE date NULL," & _
                                 "PRCH_SUPPLIER char(200) NULL," & _
                                 "PRCH_STATUS char(10) NULL," & _
                                 "PRCH_INVOICE decimal(18, 0) NULL)"

                SqlCommand(12) = "CREATE TABLE PRODUCTS(" & _
                                 "PROD_CD char(50) NULL," & _
                                 "PROD_DESC char(200) NULL," & _
                                 "PROD_CATG char(50) NULL," & _
                                 "PROD_PACK char(10) NULL," & _
                                 "PROD_PPRICE float NULL," & _
                                 "PROD_ONHAND int NULL," & _
                                 "PROD_BAL_MIN int NULL," & _
                                 "PROD_SCH1_PRICE float NULL," & _
                                 "PROD_SCH1_ONHAND int NULL," & _
                                 "PROD_SCH2_PRICE float NULL," & _
                                 "PROD_SCH2_ONHAND int NULL," & _
                                 "PROD_SCH3_PRICE float NULL," & _
                                 "PROD_SCH3_ONHAND int NULL," & _
                                 "PROD_VAT float NULL," & _
                                 "PROD_ITAX float NULL," & _
                                 "PROD_EX_DUTY float NULL," & _
                                 "PROD_PROFIT float NULL," & _
                                 "PROD_DISC_MRG float NULL," & _
                                 "PROD_SPRICE float NULL," & _
                                 "PROD_DATE date NULL," & _
                                 "PROD_UPD_ON date NULL)"

                SqlCommand(13) = "CREATE TABLE ITEMS(" & _
                                 "ITEM_CODE char(50) NULL," & _
                                 "ITEM_NAME char(200) NULL," & _
                                 "ITEM_CATG char(50) NULL," & _
                                 "ITEM_PCKG char(10) NULL," & _
                                 "ITEM_PRICE float NULL," & _
                                 "ITEM_CATG_CD char(5) NULL)"

                SqlCommand(14) = "CREATE TABLE INFO(" & _
                                 "REG_NAME char(400) NULL," & _
                                 "REG_ADDRESS char(400) NULL," & _
                                 "TEL1 char(11) NULL," & _
                                 "TEL2 char(11) NULL," & _
                                 "MOBILE1 char(11) NULL," & _
                                 "MOBILE2 char(11) NULL)"

                SqlCommand(15) = "CREATE TABLE CUSTOMERS_PAYM(" & _
                                 "Cust_Code int NULL," & _
                                 "Cust_Tr_Dt date NULL," & _
                                 "Cust_Tr_ID decimal(18, 0) NULL," & _
                                 "Cust_Name char(50) NULL," & _
                                 "Cust_Desc char(200) NULL," & _
                                 "Cust_Opn_Bal decimal(18, 2) NULL," & _
                                 "Cust_Debit decimal(18, 2) NULL," & _
                                 "Cust_Credit decimal(18, 2) NULL," & _
                                 "Cust_Balance decimal(18, 2) NULL," & _
                                 "Cust_Upt_dt date NULL)"

                SqlCommand(16) = "CREATE TABLE CUSTOMERS(" & _
                                 "Cust_Code int NULL," & _
                                 "Cust_Name char(50) NULL," & _
                                 "Cust_Address char(150) NULL," & _
                                 "Cust_City char(10) NULL," & _
                                 "Cust_Tel char(15) NULL," & _
                                 "Cust_Mob char(11) NULL," & _
                                 "Cust_Balance decimal(18, 2) NULL," & _
                                 "Cust_Upd_dt date NULL)"

                SqlCommand(17) = "CREATE TABLE CUST_PURCHASES(" & _
                                 "PRCH_TR_ID decimal(18, 0) NULL," & _
                                 "PRCH_CD char(50) NULL," & _
                                 "PRCH_DESC char(200) NULL," & _
                                 "PRCH_CATG char(50) NULL," & _
                                 "PRCH_PACK char(10) NULL," & _
                                 "PRCH_PRICE float NULL," & _
                                 "PRCH_QTY int NULL," & _
                                 "PRCH_OLD_QTY int NULL," & _
                                 "PRCH_BAL_MIN int NULL," & _
                                 "PRCH_SCH1_PRICE float NULL," & _
                                 "PRCH_SCH1_ONHAND int NULL," & _
                                 "PRCH_SCH2_PRICE float NULL," & _
                                 "PRCH_SCH2_ONHAND int NULL," & _
                                 "PRCH_SCH3_PRICE float NULL," & _
                                 "PRCH_SCH3_ONHAND int NULL," & _
                                 "PRCH_VAT float NULL," & _
                                 "PRCH_ITAX float NULL," & _
                                 "PRCH_EX_DUTY float NULL," & _
                                 "PRCH_PROFIT float NULL," & _
                                 "PRCH_DISC_MRG float NULL," & _
                                 "PRCH_SPRICE float NULL," & _
                                 "PRCH_DATE date NULL," & _
                                 "PRCH_SUPPLIER char(200) NULL," & _
                                 "PRCH_STATUS char(10) NULL)"

                SqlCommand(18) = "CREATE TABLE UsersRoles(" & _
                                 "RoleID int NULL," & _
                                 "RoleName char(50) NULL," & _
                                 "Decription char(250) NULL," & _
                                 "SecurityLevel int NULL)"


                ''    Holds the script for creating tables in database. // for professional developers
                'Dim tableText As String

                ''   Path of table creation script in the project folder.
                'Dim tableFileName As String = My.Application.Info.DirectoryPath & "\data\CreateBlankDatabase.sql"

                'Dim srvMgmtServer As Server = New Server()
                'Dim srvConn As New ServerConnection
                'Dim objDB As Database = srvMgmtServer.Databases("POS")

                'srvConn = srvMgmtServer.ConnectionContext
                ''srvConn.ServerInstance = ServerName
                ''srvConn.LoginSecure = False

                'If srvConn.LoginSecure = False Then
                '    srvConn.Login = ServerID
                '    srvConn.Password = ServerPwd
                'End If

                'Using FileReader As New  _
                '                Microsoft.VisualBasic.FileIO.TextFieldParser(tableFileName)
                '    tableText = FileReader.ReadToEnd
                'End Using
                For I = 0 To 17
                    Try
                        '    If tableText <> "" Then
                        '        objDB.ExecuteNonQuery(tableText)
                        '    End If
                        ExecuteAdapterQuery(SqlDataAdapter, SqlCommand(I), Connection)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
                    End Try
                Next I
                Dim CreateLogin As String = "INSERT INTO USERS VALUES (1,'admin','admin','System','Admin',1,0,'00000-0000000-0')"
                If CheckTableExists("USERS") = True Then ExecuteAdapterQuery(SqlDataAdapter, CreateLogin, Connection)
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
