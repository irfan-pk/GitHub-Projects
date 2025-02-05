Imports System.IO
Imports System.Data.SqlClient
Imports System.Data

Public Class CreateDB
    Protected Const SqlConnectionString As String = _
        "Server=(local);" & _
        "DataBase=;" & _
        "Integrated Security=SSPI"

    Protected Const ConnectionErrorMessage As String = _
        "To run this application, you must have SQL server" & _
        "installed.  For " & _
        "instructions on installing SQL, contact the microsoft online."

    Protected didPreviouslyConnect As Boolean = False
    Protected didCreateTable As Boolean = False
    Protected connectionString As String = SqlConnectionString

#Region "Create database"
    ' Handles the click event for the Create Database button.
    Private Sub btnCreateDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateDB.Click

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

    Private Sub CreateDatabase()
        Dim sqlStatement As String = _
            "CREATE DATABASE POS_MED " & _
            "ON PRIMARY ( NAME = POS_MED,FILENAME = '" & gblDatabasePath & "\POS_MED.mdf',SIZE = 10,MAXSIZE = UNLIMITED,FILEGROWTH = 1024KB) " & _
            "LOG ON ( NAME = POS_MED__log,FILENAME = '" & gblDatabasePath & "\POS_MED_log.ldf',SIZE = 5MB,MAXSIZE = UNLIMITED,FILEGROWTH = 10% )"

        Dim statusForm As New Status()
        If Not didPreviouslyConnect Then
            statusForm.Show("Connecting to SQL Server")
        End If

        ' Attempt to connect to the SQL server instance.  
        Try
            Dim connection As New SqlConnection(connectionString)
            ' A SqlCommand object is used to execute the SQL commands.
            Dim cmd As New SqlCommand(sqlStatement, connection)
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
        Catch sqlExc As SqlException
            MsgBox(sqlExc.Message, MsgBoxStyle.OkOnly, "SQL Exception Error")
        Catch exc As Exception
            ' Unable to connect to SQL Server or MSDE
            statusForm.Close()
            MsgBox(exc.Message, MsgBoxStyle.OkOnly, "Connection failed.")
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
                SqlCommand(0) = "CREATE TABLE Users(" & _
                                "UserName varchar(255) NULL," & _
                                "UserId varchar(255) NULL," & _
                                "Password varchar(255) NULL," & _
                                "UserRole varchar(255) NULL," & _
                                "SecurityLevel int NULL," & _
                                "Active bit NULL, " & _
                                "CardNumber varchar(15) NULL, " & _
                                "CounterID varchar(5) NULL)"

                SqlCommand(2) = "CREATE TABLE SUPPLIERS(" & _
                                "Supl_Code int NULL," & _
                                "Supl_Name varchar(50) NULL," & _
                                "Supl_Address varchar(150) NULL," & _
                                "Supl_City varchar(50) NULL," & _
                                "Supl_Tel varchar(15) NULL," & _
                                "Supl_Mob varchar(11) NULL," & _
                                "Supl_Balance decimal(18, 2) NULL," & _
                                "Supl_Upd_dt date NULL)"

                SqlCommand(3) = "CREATE TABLE SALE_MASTER_TEMP(" & _
                                "SaleID decimal(18, 0) NULL," & _
                                "DrawerID int NULL," & _
                                "DrawerName varchar(50) NULL," & _
                                "DateCompleted date NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "OfflineID varchar(100) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "SaleGross float NULL," & _
                                "SaleDiscount float NULL," & _
                                "SaleTotal float NULL," & _
                                "SalePaid float NULL," & _
                                "SaleChange float NULL," & _
                                "SaleStatus varchar(50) NULL," & _
                                "SaleCredit float NULL," & _
                                "SaleReturn float NULL," & _
                                "SaleRecovery float NULL," & _
                                "DateRecovery date NULL," & _
                                "LedgerPost tinyint NULL)"

                SqlCommand(4) = "CREATE TABLE SALE_MASTER_HOLD(" & _
                                "SaleID decimal(18, 0) NULL," & _
                                "DrawerID int NULL," & _
                                "DrawerName varchar(50) NULL," & _
                                "DateCompleted date NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "OfflineID varchar(100) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "SaleGross float NULL," & _
                                "SaleDiscount int NULL," & _
                                "SaleTotal float NULL," & _
                                "SalePaid float NULL," & _
                                "SaleChange float NULL," & _
                                "SaleStatus varchar(50) NULL," & _
                                "SaleCredit float NULL," & _
                                "SaleReturn float NULL," & _
                                "SaleRecovery float NULL," & _
                                "DateRecovery date NULL," & _
                                "LedgerPost tinyint NULL)"

                SqlCommand(5) = "CREATE TABLE SALE_MASTER(" & _
                                "SaleID decimal(18, 0) NULL," & _
                                "DrawerID int NULL," & _
                                "DrawerName varchar(50) NULL," & _
                                "DateCompleted date NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "OfflineID varchar(100) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "SaleGross float NULL," & _
                                "SaleDiscount float NULL," & _
                                "SaleTotal float NULL," & _
                                "SalePaid float NULL," & _
                                "SaleChange float NULL," & _
                                "SaleStatus varchar(50) NULL," & _
                                "SaleCredit float NULL," & _
                                "SaleReturn float NULL," & _
                                "SaleRecovery float NULL," & _
                                "DateRecovery date NULL," & _
                                "LedgerPost tinyint NULL)"

                SqlCommand(6) = "CREATE TABLE SALE_DETAIL_TEMP(" & _
                                "DetailID decimal(18, 0) NULL," & _
                                "DetailDate date NULL," & _
                                "SaleID decimal(18, 0) NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "StockID varchar(50) NULL," & _
                                "StockDesc varchar(100) NULL," & _
                                "SalePack varchar(10) NULL," & _
                                "UnitCost float NULL," & _
                                "Qty float NULL," & _
                                "Price float NULL," & _
                                "SaleStatus varchar(50) NULL," & _
                                "DrawerID int NULL," & _
                                "TaxPercentage float NULL," & _
                                "PriceInc float NULL," & _
                                "HeadCategory varchar(255) NULL," & _
                                "Category varchar(255) NULL," & _
                                "DiscountDetailID int NULL," & _
                                "AOptions varchar(200) NULL," & _
                                "SortItem int NULL," & _
                                "SubCategory varchar(255) NULL)"

                SqlCommand(7) = "CREATE TABLE SALE_DETAIL_HOLD(" & _
                                "DetailID decimal(18, 0) NULL," & _
                                "DetailDate date NULL," & _
                                "SaleID decimal(18, 0) NULL," & _
                                "SaleType varchar(50) NULL," & _
                                "CustomerID int NULL," & _
                                "CustomerName varchar(100) NULL," & _
                                "StockID varchar(50) NULL," & _
                                "StockDesc varchar(100) NULL," & _
                                "SalePack varchar(10) NULL," & _
                                "UnitCost float NULL," & _
                                "Qty float NULL," & _
                                "Price float NULL," & _
                                "SaleStatus varchar(50) NULL," & _
                                "DrawerID int NULL," & _
                                "TaxPercentage float NULL," & _
                                "PriceInc float NULL," & _
                                "HeadCategory varchar(255) NULL," & _
                                "Category varchar(255) NULL," & _
                                "DiscountDetailID int NULL," & _
                                "AOptions varchar(200) NULL," & _
                                "SortItem int NULL," & _
                                "SubCategory varchar(255) NULL)"

                SqlCommand(8) = "CREATE TABLE SALE_DETAIL(" & _
                                 "DetailID decimal(18, 0) NULL," & _
                                 "DetailDate date NULL," & _
                                 "SaleID decimal(18, 0) NULL," & _
                                 "SaleType varchar(50) NULL," & _
                                 "CustomerID int NULL," & _
                                 "CustomerName varchar(100) NULL," & _
                                 "StockID varchar(50) NULL," & _
                                 "StockDesc varchar(100) NULL," & _
                                 "SalePack varchar(10) NULL," & _
                                 "UnitCost float NULL," & _
                                 "Qty float NULL," & _
                                 "Price float NULL," & _
                                 "SaleStatus varchar(50) NULL," & _
                                 "DrawerID int NULL," & _
                                 "TaxPercentage float NULL," & _
                                 "PriceInc float NULL," & _
                                 "HeadCategory varchar(255) NULL," & _
                                 "Category varchar(255) NULL," & _
                                 "DiscountDetailID int NULL," & _
                                 "AOptions varchar(200) NULL," & _
                                 "SortItem int NULL," & _
                                 "SubCategory varchar(255) NULL," & _
                                 "ItemDues float NULL)"

                SqlCommand(9) = "CREATE TABLE [dbo].[PURCHASE](" & _
                                "[PRCH_TR_ID] [decimal](8, 0) NULL," & _
                                "[PRCH_INVOICE] [int] NULL," & _
                                "[PRCH_DATE] [date] NULL," & _
                                "[PRCH_PROD_CD] [varchar](50) NULL," & _
                                "[PRCH_DESC] [varchar](255) NULL," & _
                                "[PRCH_SUPPLIER] [varchar](255) NULL," & _
                                "[PRCH_HEAD] [varchar](255) NULL," & _
                                "[PRCH_CATG] [varchar](100) NULL," & _
                                "[PRCH_PACK] [varchar](50) NULL," & _
                                "[PRCH_QTY] [int] NULL," & _
                                "[PRCH_OLD_QTY] [int] NULL," & _
                                "[PRCH_PRICE] [decimal](8, 2) NULL," & _
                                "[PRCH_STATUS] [varchar](20) NULL," & _
                                "[PRCH_QTY_PER_UNIT] [int] NULL," & _
                                "[PRCH_OLD_PRICE] [decimal](8, 2) NULL" & _
                                ") ON [PRIMARY]"

                SqlCommand(10) = "CREATE TABLE [dbo].[PRODUCTS](" & _
                                "[PROD_CODE] [varchar](50) NULL," & _
                                "[PROD_BAR_CODE] [varchar](255) NULL," & _
                                "[PROD_DESC] [varchar](255) NULL," & _
                                "[PROD_HEAD] [varchar](255) NULL," & _
                                "[PROD_CATG] [varchar](255) NULL," & _
                                "[PROD_SUB_CATG] [varchar](255) NULL," & _
                                "[PROD_SUPPLR] [varchar](100) NULL," & _
                                "[PROD_PACKING] [varchar](20) NULL," & _
                                "[PROD_UNITS] [int] NULL," & _
                                "[PROD_QTY_PER_UNIT] [int] NULL," & _
                                "[PROD_STOCK] [decimal](8, 0) NULL," & _
                                "[PROD_BAL_MIN] [int] NULL," & _
                                "[PROD_PURCH_PRICE] [decimal](8, 2) NULL," & _
                                "[PROD_WSALE_PRICE] [decimal](8, 2) NULL," & _
                                "[PROD_SALE_PRICE] [decimal](8, 2) NULL," & _
                                "[PROD_UPD_ON] [date] NULL," & _
                                "[PROD_FOR_SALE] [bit] NULL" & _
                                ") ON [PRIMARY]"

                SqlCommand(11) = "CREATE TABLE ITEMTYPES(" & _
                                 "CATEGORY varchar(255) NULL)"

                SqlCommand(12) = "CREATE TABLE INFO(" & _
                                 "REG_NAME varchar(400) NULL," & _
                                 "REG_ADDRESS varchar(400) NULL," & _
                                 "TEL1 varchar(11) NULL," & _
                                 "TEL2 varchar(11) NULL," & _
                                 "MOBILE1 varchar(11) NULL," & _
                                 "MOBILE2 varchar(11) NULL)"

                SqlCommand(14) = "CREATE TABLE CUSTOMERS(" & _
                                 "Cust_Code int NULL," & _
                                 "Cust_Name varchar(50) NULL," & _
                                 "Cust_Address varchar(150) NULL," & _
                                 "Cust_City varchar(20) NULL," & _
                                 "Cust_Tel varchar(15) NULL," & _
                                 "Cust_Mob varchar(11) NULL," & _
                                 "Cust_Balance decimal(18, 2) NULL," & _
                                 "Cust_Upd_dt date NULL)"

                SqlCommand(15) = "CREATE TABLE UsersRoles(" & _
                                 "RoleID int NULL," & _
                                 "RoleName char(50) NULL," & _
                                 "Decription char(250) NULL," & _
                                 "SecurityLevel int NULL)"

                SqlCommand(16) = "CREATE TABLE [dbo].[CATEGORY](" & _
                                "[CATEGORY] [varchar](255) NULL," & _
                                "[DEPARTMENT] [varchar](255) NULL," & _
                                "[SUB_CATEGORY] [varchar](255) NULL" & _
                                ") ON [PRIMARY]"

                SqlCommand(17) = "CREATE TABLE [dbo].[DEPARTMENTS](" & _
                                "[Head_Category] [varchar](255) NULL" & _
                                ") ON [PRIMARY]"

                For I = 0 To 17
                    Try
                        ExecuteAdapterQuery(SqlDataAdapter, SqlCommand(I), Connection)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
                    End Try
                Next I
                Dim CreateLogin As String = "INSERT INTO USERS VALUES ('administrator','admin','admin','Administrator',1,0,'45402-0886531-3','ADM')"
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
