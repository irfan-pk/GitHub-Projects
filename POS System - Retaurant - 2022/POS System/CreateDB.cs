using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class CreateDB
    {

        // Initialize constants for connecting to the database
        // and displaying a connection error to the user.
        protected const string SqlConnectionString = "Server=(local);" + "DataBase=;" + "Integrated Security=SSPI";



        protected const string ConnectionErrorMessage = "To run this application, you must have SQL server 2008" + "installed.  For " + "instructions on installing SQL, contact the microsoft online.";



        protected bool didPreviouslyConnect = false;
        protected bool didCreateTable = false;
        protected string connectionString = SqlConnectionString;

        #region Create database
        // Handles the click event for the Create Database button.
        private void btnCreateDB_Click(object sender, EventArgs e)
        {

            // If the "Create Table" button is enabled this means the user is trying to
            // recreate the database again in the same application run. Warn the user of
            // how this will affect things, and if they want to proceed, reset the UI to
            // the initial state so that errors are not induced if currently enabled 
            // buttons are clicked out of order.
            if (btnCreateTable.Enabled)
            {
                var dr = MessageBox.Show("Recreating the database " + "will undo the other database object creation steps you have " + "made so far. Do you wish to proceed?", "Database Re-creation " + "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                if (dr == DialogResult.Yes)
                {
                    ResetUI();
                    CreateDatabase();
                }
            }
            else
            {
                CreateDatabase();
            }

        }


        // This routine executes a SQL statement that deletes the database (if it exists) 
        // and then creates it. 
        private void CreateDatabase()
        {
            string sqlStatement = "IF NOT EXISTS (" + "SELECT * " + "FROM master..sysdatabases " + "WHERE Name = 'POSR')" + Constants.vbCrLf + "CREATE DATABASE POSR";





            // Display a status message saying that we're attempting to connect.
            // This only needs to be done the very first time a connection is
            // attempted.  After we've determined that MSDE or SQL Server is
            // installed, this message no longer needs to be displayed.
            var statusForm = new Status();
            if (!didPreviouslyConnect)
            {
                statusForm.Show("Connecting to SQL Server");
            }

            // Attempt to connect to the SQL server instance.  
            try
            {
                // The SqlConnection class allows you to communicate with SQL Server.
                // The constructor accepts a connection string as an argument.  This
                // connection string uses Integrated Security, which means that you 
                // must have a login in SQL Server, or be part of the Administrators
                // group for this to work.
                var connection = new SqlConnection(connectionString);

                // A SqlCommand object is used to execute the SQL commands.
                var cmd = new SqlCommand(sqlStatement, connection);

                // Open the connection, execute the command, and close the 
                // connection. It is more efficient to ExecuteNonQuery when data is 
                // not being returned.
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                // Data has been successfully submitted.
                didPreviouslyConnect = true;
                didCreateTable = true;
                statusForm.Close();

                // Show the controls for the next step.
                lblArrow1.Visible = true;
                lblStep2.Enabled = true;
                btnCreateTable.Enabled = true;
            }

            // MsgBox("Database 'FBR' successfully created.", MsgBoxStyle.OkOnly, "Database Creation Status")
            catch (SqlException sqlExc)
            {
                Interaction.MsgBox(sqlExc.Message, MsgBoxStyle.OkOnly, "SQL Exception Error");
            }
            catch (Exception exc)
            {
                // Unable to connect to SQL Server or MSDE
                statusForm.Close();
                Interaction.MsgBox(exc.Message, MsgBoxStyle.OkOnly, "Connection failed.");
            }
        }
        #endregion

        #region Reset UI
        // Sets up the user interface so that the user proceeds in proper order
        // through the steps.
        private void ResetUI()
        {
            lblArrow1.Visible = false;
            lblStep2.Enabled = false;
            btnCreateTable.Enabled = false;
        }
        #endregion

        #region Create table
        // Handles the click event for the Create Table button.
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            mdlGeneral.GetConnectionString();
            var SqlCommand = new string[20];
            if (mdlGeneral.CheckTableExists("PRODUCTS") == false)
            {
                try
                {
                    SqlCommand[0] = "CREATE TABLE Users(UserId int NULL," + "UserName varchar(50) NULL," + "Password varchar(200) NULL," + "Name varchar(100) NULL," + "UserRole varchar(50) NULL," + "SecurityLevel int NULL," + "Active bit NULL, " + "CardNumber varchar(200) NULL)";







                    SqlCommand[1] = "CREATE TABLE TABLE_MASTER(" + "SaleID decimal(18, 0) NULL," + "DrawerID int NULL," + "DrawerName varchar(50) NULL," + "DateCompleted date NULL," + "SaleType varchar(50) NULL," + "OfflineID varchar(100) NULL," + "CustomerID int NULL," + "CustomerName varchar(100) NULL," + "SaleTotal decimal(18, 0) NULL," + "SalePaid decimal(18, 0) NULL," + "SaleDiscount decimal(18, 0) NULL," + "SaleChange decimal(18, 0) NULL," + "SaleStatus int NULL," + "SaleCredit decimal(18, 0) NULL," + "SaleReturn decimal(18, 0) NULL," + "SaleRecovery decimal(18, 0) NULL," + "DateRecovery date NULL," + "ServiceChrg decimal(18, 0) NULL)";


















                    SqlCommand[2] = "CREATE TABLE TABLE_DETAIL(" + "DetailID decimal(18, 0) NULL," + "DetailDate date NULL," + "SaleID decimal(18, 0) NULL," + "SaleType varchar(50) NULL," + "CustomerID int NULL," + "CustomerName varchar(100) NULL," + "StockID char(50) NULL," + "StockDesc varchar(100) NULL," + "SaleTable varchar(10) NULL," + "UnitCost float NULL," + "Qty float NULL," + "Price float NULL," + "TableStatus varchar(10) NULL," + "DrawerID int NULL," + "TaxPercentage float NULL," + "PriceInc float NULL," + "TotalPriceExcl float NULL," + "TotalPriceInc float NULL," + "DiscountDetailID int NULL," + "AOptions varchar(200) NULL," + "SortItem int NULL)";





















                    SqlCommand[3] = "CREATE TABLE SUPPLIERS_PAYM(" + "Supl_Code int NULL," + "Supl_Tr_Dt date NULL," + "Supl_Tr_ID decimal(18, 0) NULL," + "Supl_Name char(50) NULL," + "Supl_Desc char(200) NULL," + "Supl_Opn_Bal decimal(18, 2) NULL," + "Supl_Debit decimal(18, 2) NULL," + "Supl_Credit decimal(18, 2) NULL," + "Supl_Balance decimal(18, 2) NULL," + "Supl_Upt_dt date NULL)";










                    SqlCommand[4] = "CREATE TABLE SUPPLIERS(" + "Supl_Code int NULL," + "Supl_Name char(50) NULL," + "Supl_Address char(150) NULL," + "Supl_City char(10) NULL," + "Supl_Tel char(15) NULL," + "Supl_Mob char(11) NULL," + "Supl_Balance decimal(18, 2) NULL," + "Supl_Upd_dt date NULL)";








                    SqlCommand[5] = "CREATE TABLE SALE_MASTER_TEMP(" + "SaleID decimal(18, 0) NULL," + "DrawerID int NULL," + "DrawerName varchar(50) NULL," + "DateCompleted date NULL," + "SaleType varchar(50) NULL," + "OfflineID varchar(100) NULL," + "CustomerID int NULL," + "CustomerName varchar(100) NULL," + "SaleTotal decimal(18, 0) NULL," + "SalePaid decimal(18, 0) NULL," + "SaleDiscount decimal(18, 0) NULL," + "SaleChange decimal(18, 0) NULL," + "SaleStatus int NULL," + "SaleCredit decimal(18, 0) NULL," + "SaleReturn decimal(18, 0) NULL," + "SaleRecovery decimal(18, 0) NULL," + "DateRecovery date NULL," + "ServiceChrg decimal(18, 0) NULL)";


















                    SqlCommand[6] = "CREATE TABLE SALE_MASTER_HOLD(" + "SaleID decimal(18, 0) NULL," + "DrawerID int NULL," + "DrawerName varchar(50) NULL," + "DateCompleted date NULL," + "SaleType varchar(50) NULL," + "OfflineID varchar(100) NULL," + "CustomerID int NULL," + "CustomerName varchar(100) NULL," + "SaleTotal decimal(18, 0) NULL," + "SalePaid decimal(18, 0) NULL," + "SaleDiscount int NULL," + "SaleChange decimal(18, 0) NULL," + "SaleStatus int NULL," + "SaleCredit decimal(18, 0) NULL," + "SaleReturn decimal(18, 0) NULL," + "SaleRecovery decimal(18, 0) NULL," + "DateRecovery date NULL," + "ServiceChrg decimal(18, 0) NULL)";


















                    SqlCommand[7] = "CREATE TABLE SALE_MASTER(" + "SaleID decimal(18, 0) NULL," + "DrawerID int NULL," + "DrawerName varchar(50) NULL," + "DateCompleted date NULL," + "SaleType varchar(50) NULL," + "OfflineID varchar(100) NULL," + "CustomerID int NULL," + "CustomerName varchar(100) NULL," + "SaleTotal decimal(18, 0) NULL," + "SalePaid decimal(18, 0) NULL," + "SaleDiscount decimal(18, 0) NULL," + "SaleChange decimal(18, 0) NULL," + "SaleStatus int NULL," + "SaleCredit decimal(18, 0) NULL," + "SaleReturn decimal(18, 0) NULL," + "SaleRecovery decimal(18, 0) NULL," + "DateRecovery date NULL," + "ServiceChrg decimal(18, 0) NULL)";


















                    SqlCommand[8] = "CREATE TABLE SALE_DETAIL_TEMP(" + "DetailID decimal(18, 0) NULL," + "DetailDate date NULL," + "SaleID decimal(18, 0) NULL," + "SaleType varchar(50) NULL," + "CustomerID int NULL," + "CustomerName varchar(100) NULL," + "StockID char(50) NULL," + "StockDesc varchar(100) NULL," + "SalePack varchar(10) NULL," + "UnitCost float NULL," + "Qty float NULL," + "Price float NULL," + "SaleStatus varchar(10) NULL," + "DrawerID int NULL," + "TaxPercentage float NULL," + "PriceInc float NULL," + "TotalPriceExcl float NULL," + "TotalPriceInc float NULL," + "DiscountDetailID int NULL," + "AOptions varchar(200) NULL," + "SortItem int NULL)";





















                    SqlCommand[9] = "CREATE TABLE SALE_DETAIL_HOLD(" + "DetailID decimal(18, 0) NULL," + "DetailDate date NULL," + "SaleID decimal(18, 0) NULL," + "SaleType varchar(50) NULL," + "CustomerID int NULL," + "CustomerName varchar(100) NULL," + "StockID char(50) NULL," + "StockDesc varchar(100) NULL," + "SalePack varchar(10) NULL," + "UnitCost float NULL," + "Qty float NULL," + "Price float NULL," + "SaleStatus varchar(10) NULL," + "DrawerID int NULL," + "TaxPercentage float NULL," + "PriceInc float NULL," + "TotalPriceExcl float NULL," + "TotalPriceInc float NULL," + "DiscountDetailID int NULL," + "AOptions varchar(200) NULL," + "SortItem int NULL)";





















                    SqlCommand[10] = "CREATE TABLE SALE_DETAIL(" + "DetailID decimal(18, 0) NULL," + "DetailDate date NULL," + "SaleID decimal(18, 0) NULL," + "SaleType varchar(50) NULL," + "CustomerID int NULL," + "CustomerName varchar(100) NULL," + "StockID char(50) NULL," + "StockDesc varchar(100) NULL," + "SalePack varchar(10) NULL," + "UnitCost float NULL," + "Qty float NULL," + "Price float NULL," + "SaleStatus varchar(10) NULL," + "DrawerID int NULL," + "TaxPercentage float NULL," + "PriceInc float NULL," + "TotalPriceExcl float NULL," + "TotalPriceInc float NULL," + "DiscountDetailID int NULL," + "AOptions varchar(200) NULL," + "SortItem int NULL)";





















                    SqlCommand[11] = "CREATE TABLE PURCHASE(" + "PRCH_TR_ID decimal(18, 0) NULL," + "PRCH_CD char(50) NULL," + "PRCH_DESC char(200) NULL," + "PRCH_CATG char(50) NULL," + "PRCH_PACK char(10) NULL," + "PRCH_PRICE float NULL," + "PRCH_QTY int NULL," + "PRCH_OLD_QTY int NULL," + "PRCH_BAL_MIN int NULL," + "PRCH_SCH1_PRICE float NULL," + "PRCH_SCH1_ONHAND int NULL," + "PRCH_SCH2_PRICE float NULL," + "PRCH_SCH2_ONHAND int NULL," + "PRCH_SCH3_PRICE float NULL," + "PRCH_SCH3_ONHAND int NULL," + "PRCH_VAT float NULL," + "PRCH_ITAX float NULL," + "PRCH_EX_DUTY float NULL," + "PRCH_PROFIT float NULL," + "PRCH_DISC_MRG float NULL," + "PRCH_SPRICE float NULL," + "PRCH_DATE date NULL," + "PRCH_SUPPLIER char(200) NULL," + "PRCH_STATUS char(10) NULL," + "PRCH_INVOICE decimal(18, 0) NULL)";

























                    SqlCommand[12] = "CREATE TABLE PRODUCTS(" + "PROD_CD char(50) NULL," + "PROD_DESC char(200) NULL," + "PROD_CATG char(50) NULL," + "PROD_PACK char(10) NULL," + "PROD_PPRICE float NULL," + "PROD_ONHAND int NULL," + "PROD_BAL_MIN int NULL," + "PROD_SCH1_PRICE float NULL," + "PROD_SCH1_ONHAND int NULL," + "PROD_SCH2_PRICE float NULL," + "PROD_SCH2_ONHAND int NULL," + "PROD_SCH3_PRICE float NULL," + "PROD_SCH3_ONHAND int NULL," + "PROD_VAT float NULL," + "PROD_ITAX float NULL," + "PROD_EX_DUTY float NULL," + "PROD_PROFIT float NULL," + "PROD_DISC_MRG float NULL," + "PROD_SPRICE float NULL," + "PROD_DATE date NULL," + "PROD_UPD_ON date NULL)";





















                    SqlCommand[13] = "CREATE TABLE ITEMS(" + "ITEM_CODE char(50) NULL," + "ITEM_NAME char(200) NULL," + "ITEM_CATG char(50) NULL," + "ITEM_PCKG char(10) NULL," + "ITEM_PRICE float NULL," + "ITEM_CATG_CD char(5) NULL)";






                    SqlCommand[14] = "CREATE TABLE INFO(" + "REG_NAME char(400) NULL," + "REG_ADDRESS char(400) NULL," + "TEL1 char(11) NULL," + "TEL2 char(11) NULL," + "MOBILE1 char(11) NULL," + "MOBILE2 char(11) NULL)";






                    SqlCommand[15] = "CREATE TABLE CUSTOMERS_PAYM(" + "Cust_Code int NULL," + "Cust_Tr_Dt date NULL," + "Cust_Tr_ID decimal(18, 0) NULL," + "Cust_Name char(50) NULL," + "Cust_Desc char(200) NULL," + "Cust_Opn_Bal decimal(18, 2) NULL," + "Cust_Debit decimal(18, 2) NULL," + "Cust_Credit decimal(18, 2) NULL," + "Cust_Balance decimal(18, 2) NULL," + "Cust_Upt_dt date NULL)";










                    SqlCommand[16] = "CREATE TABLE CUSTOMERS(" + "Cust_Code int NULL," + "Cust_Name char(50) NULL," + "Cust_Address char(150) NULL," + "Cust_City char(10) NULL," + "Cust_Tel char(15) NULL," + "Cust_Mob char(11) NULL," + "Cust_Balance decimal(18, 2) NULL," + "Cust_Upd_dt date NULL)";








                    SqlCommand[17] = "CREATE TABLE CUST_PURCHASES(" + "PRCH_TR_ID decimal(18, 0) NULL," + "PRCH_CD char(50) NULL," + "PRCH_DESC char(200) NULL," + "PRCH_CATG char(50) NULL," + "PRCH_PACK char(10) NULL," + "PRCH_PRICE float NULL," + "PRCH_QTY int NULL," + "PRCH_OLD_QTY int NULL," + "PRCH_BAL_MIN int NULL," + "PRCH_SCH1_PRICE float NULL," + "PRCH_SCH1_ONHAND int NULL," + "PRCH_SCH2_PRICE float NULL," + "PRCH_SCH2_ONHAND int NULL," + "PRCH_SCH3_PRICE float NULL," + "PRCH_SCH3_ONHAND int NULL," + "PRCH_VAT float NULL," + "PRCH_ITAX float NULL," + "PRCH_EX_DUTY float NULL," + "PRCH_PROFIT float NULL," + "PRCH_DISC_MRG float NULL," + "PRCH_SPRICE float NULL," + "PRCH_DATE date NULL," + "PRCH_SUPPLIER char(200) NULL," + "PRCH_STATUS char(10) NULL)";
























                    SqlCommand[18] = "CREATE TABLE UsersRoles(" + "RoleID int NULL," + "RoleName char(50) NULL," + "Decription char(250) NULL," + "SecurityLevel int NULL)";




                    SqlCommand[19] = "CREATE TABLE WAITERS(" + "WAITER_ID int NULL," + "WAITER_NAME varchar(100) NULL," + "WAITER_ADDRESS varchar(200) NULL," + "WAITER_CONTACT varchar(11) NULL," + "WAITER_NIC varchar(18) NULL)";





                    // '    Holds the script for creating tables in database. // for professional developers
                    // Dim tableText As String

                    // '   Path of table creation script in the project folder.
                    // Dim tableFileName As String = My.Application.Info.DirectoryPath & "\data\CreateBlankDatabase.sql"

                    // Dim srvMgmtServer As Server = New Server()
                    // Dim srvConn As New ServerConnection
                    // Dim objDB As Database = srvMgmtServer.Databases("POSR")

                    // srvConn = srvMgmtServer.ConnectionContext
                    // 'srvConn.ServerInstance = ServerName
                    // 'srvConn.LoginSecure = False

                    // If srvConn.LoginSecure = False Then
                    // srvConn.Login = ServerID
                    // srvConn.Password = ServerPwd
                    // End If

                    // Using FileReader As New  _
                    // Microsoft.VisualBasic.FileIO.TextFieldParser(tableFileName)
                    // tableText = FileReader.ReadToEnd
                    // End Using
                    for (int I = 0; I <= 19; I++)
                    {
                        try
                        {
                            // If tableText <> "" Then
                            // objDB.ExecuteNonQuery(tableText)
                            // End If
                            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, SqlCommand[I], mdlGeneral.Connection);
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, My.MyProject.Application.Info.ProductName);
                        }
                    }
                    string CreateLogin = "INSERT INTO USERS VALUES (1,'admin','admin','System','Admin',1,0,'00000-0000000-0')";
                    if (mdlGeneral.CheckTableExists("USERS") == true)
                        mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CreateLogin, mdlGeneral.Connection);
                }
                catch (SqlException sqlExc)
                {
                    MessageBox.Show(sqlExc.ToString(), "SQL Exception Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // On Succes close the form to next form
            exitToolStripMenuItem_Click(sender, e);

        }
        #endregion

        #region Form load
        // Handles the Form load event.
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetUI();
            btnCreateDB_Click(sender, e);
            btnCreateTable_Click(sender, e);
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}