using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{
    static class mdlGeneral
    {
        public static string Title, Address, Contact, TableName;
        public static TableLogOnInfo ConnInfo = new();
        public static ParameterFieldDefinitions crParameterFieldDefinitions;
        public static ParameterFieldDefinition crParameterFieldDefinition;
        public static ParameterValues crParameterValues = [];
        public static ParameterDiscreteValue crParameterDiscreteValue = new();
        public static bool SaveServerSettings, LoginStatus, gblRelation, gblOrder, gblBook;
        public static string ServerName, ServerID, ServerPwd, ServerDatabase, gblItemCode, gblFind, gblSaleType, gblCP, gblCP_ID, gblReportName, gblReportOption, gblReportFilter, gblBillReport, gblBillRptName, gblMessage, gblQueryText, strTCode, strTname, strCatg, strTrate, strRptLvl;
        public static ReportDocument objReport = new();
        public static SubreportObject objSubReport;
        public static long gblDiscount;
        public static DateTime FromDate, ToDate;
        public static string ConnString, SqlConnString, UserStatus, UserName, UserPassword, UserID, SysOperator, DiscountBy, RptUser, gblAccType, gblInput, gblCustName;
        public static string[] gbl_IName = new string[100], gbl_IQty = new string[100], gbl_ICode = new string[100];
        public static string[,] gblDataArray = new string[51, 3];
        public static SqlDataAdapter EntryDataAdpter = new(), ProductCodeAdapter = new();
        public static DataSet EntryDataSet = new(), ProductCodeDataset = new();
        public static DataSet myDataSet = new();
        public static SqlConnection Connection = new();
        public static double intTotal, intPaid, intDues, intOpnCr, intOpnDr, intD_Paid, intD_Dues, intD_Disc, intD_Recv;
        public static DataSet svDataSet = new();
        public static DataSet ReportDataSet = new();
        public static SqlDataAdapter PwdDataAdapter = new(), PurchaseAdapter = new(), ProductAdapter = new(), Suppliers = new(), Gen_Tran_Adapter = new(), SaleDataAdapter = new();
        public static SqlDataAdapter SqlDataAdapter = new();
        public static SqlDataAdapter TransferAdapter = new();
        public static DataSet TransferDataSet = new(), Gen_Tran_DataSet = new(), SuppliersDataSet = new(), SaleDataSet = new();
        public static DataSet SqlDataSet = new(), gblRecordDataSet = new();
        public static int gblPrliviges, gblAccLink, gblArrayCount, gblCustId;
        public static Boolean gblReservation;

        public static void ExecuteDatasetQuery(SqlDataAdapter Obj, DataSet ObjDataSet, string MyQuery, string TableName, SqlConnection SqlConn)
        {
            // // OLD CONNECTION STRING ('SqlConn = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=LAB;NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
            GetConnectionString();
            try
            {
                Obj.SelectCommand = new SqlCommand();
                Obj.SelectCommand.Connection = Connection;
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
                ObjDataSet.Clear();
                Connection.Open();
                Obj.SelectCommand.CommandText = MyQuery;
                Obj.SelectCommand.CommandType = CommandType.Text;
                Obj.Fill(ObjDataSet, TableName.Trim());
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }

        public static void ExecuteAdapterQuery(SqlDataAdapter Obj, string UpdateQuery, SqlConnection SqlConn)
        {
            GetConnectionString();
            try
            {
                Obj.SelectCommand = new SqlCommand();
                Obj.SelectCommand.Connection = Connection;
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
                Obj.SelectCommand.CommandText = UpdateQuery;
                Obj.SelectCommand.CommandType = CommandType.Text;
                Connection.Open();
                Obj.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message ,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error  );
            }
        }

        [Serializable()]
        public struct SoftwareSettings
        {
            public string ProgramName;
            public string ServerName;
            public string ServerUserId;
            public string ServerPassword;
            public string DataBaseName;
        }

        public static void Get_Property_GotFocus(Control  MyObject)
        {
            MyObject.BackColor = Color.LightGray;
            MyObject.ForeColor = Color.Black;
        }

        public static void Get_Property_LostFocus(Control MyObject)
        {
            MyObject.BackColor = Color.SteelBlue;
            MyObject.ForeColor = Color.White;
        }

        public static void GetServerFileSettings(string RWOption)
        {

            var StartApplication = new SoftwareSettings();
            var BF = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var MS = new MemoryStream();

            string path = Directory.GetCurrentDirectory();

            try
            {
                if (RWOption == "READ")
                {
                    byte[] bytes = File.ReadAllBytes(path + @"\" + "poslib.cfg");
                    StartApplication = (SoftwareSettings)BF.Deserialize(new MemoryStream(bytes));
                    ServerDatabase = Strings.StrConv(StartApplication.DataBaseName.Trim(), VbStrConv.Uppercase);
                    ServerName = Strings.StrConv(StartApplication.ServerName.Trim(), VbStrConv.Uppercase);
                    ServerID = Strings.StrConv(StartApplication.ServerUserId.Trim(), VbStrConv.Lowercase);
                    ServerPwd = Strings.StrConv(StartApplication.ServerPassword.Trim(), VbStrConv.Lowercase);

                }

                if (RWOption == "WRITE")
                {
                    StartApplication.DataBaseName = ServerDatabase.ToUpper().Trim();
                    StartApplication.ProgramName = "VISUAL BASIC 2008";
                    StartApplication.ServerName = ServerName.Trim().ToUpper();
                    StartApplication.ServerUserId = ServerID.Trim().ToLower();
                    StartApplication.ServerPassword = ServerPwd.ToLower().Trim();
                    BF.Serialize(MS, StartApplication);
                    My.MyProject.Computer.FileSystem.WriteAllBytes(path + @"\" + "poslib.cfg", MS.GetBuffer(), false);

                }
            }
            catch (Exception e)
            {
                Interaction.MsgBox(e.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
            }

        }

        public static int GenerateMax_ID(string tblName, string strField)
        {
            int GenerateMax_IDRet = default;

            string MaxID_Text = "SELECT MAX(" + strField + ") FROM " + tblName;

            using (var Conn = new SqlConnection("Data Source=" + ServerName + ";Initial Catalog=" + ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
            {
                var Cmd = new SqlCommand(MaxID_Text, Conn);
                try
                {
                    Conn.Open();
                    if (Cmd.ExecuteScalar() is DBNull)
                    {
                        GenerateMax_IDRet = 1;
                    }
                    else
                    {
                        GenerateMax_IDRet = (int)Math.Round(Convert.ToDecimal(Cmd.ExecuteScalar()) + 1m);
                    }
                }
                catch (Exception EX)
                {
                    Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
                return GenerateMax_IDRet;
            }

        }

        public static void Print_Slips_Manually()
        {

            GetConnectionString();
            string CommandText = string.Empty;
            SqlDataSet.Clear();

            ConnInfo.ConnectionInfo.UserID = ServerID;
            ConnInfo.ConnectionInfo.Password = ServerPwd;
            ConnInfo.ConnectionInfo.ServerName = ServerName;
            ConnInfo.ConnectionInfo.DatabaseName = "POSR";

            string GetTitle = "Select * from info";
            ExecuteAdapterQuery(SqlDataAdapter, GetTitle, Connection);
            var GetData = SqlDataAdapter.SelectCommand.ExecuteReader();
            if (GetData.HasRows)
            {
                while (GetData.Read())
                {
                    Title = GetData["REG_NAME"].ToString();
                    Address = GetData["REG_ADDRESS"].ToString();
                    Contact = GetData["TEL1"].ToString();
                }
            }

            if (gblReportOption.ToUpper() == "RECEIPT")
            {
                TableName = "SALE_MASTER";
                CommandText = "Select * from SALE_MASTER WHERE SaleID = " + Conversion.Val(gblFind.Trim());
            }

            if (gblReportOption.ToUpper() == "DUE_RECEIPT")
            {
                TableName = "TABLE_MASTER";
                CommandText = "Select * from TABLE_MASTER WHERE SaleID = " + Conversion.Val(gblFind.Trim());
            }

            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, TableName, Connection);

            // Load Report in memory for View
            try
            {
                objReport.Load(gblReportName.Trim());
                Interaction.MsgBox(gblReportName);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                return;
            }

            // Set logon information to reports for view
            for (int intCounter = 0, loopTo = objReport.Database.Tables.Count - 1; intCounter <= loopTo; intCounter++)
                objReport.Database.Tables[intCounter].ApplyLogOnInfo(ConnInfo);
            // Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables[TableName]);

            {
                ref var withBlock = ref objReport;
                crParameterDiscreteValue.Value = Title.Trim();
                crParameterFieldDefinitions = withBlock.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["CompanyTitle"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crParameterDiscreteValue.Value = Address.Trim();
                crParameterFieldDefinitions = withBlock.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["Address"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crParameterDiscreteValue.Value = Contact.Trim();
                crParameterFieldDefinitions = withBlock.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["Telphone"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
                // IF REPORT BELONGS TO RECEIPT
                if (gblReportOption.ToUpper() == "RECEIPT")
                    withBlock.RecordSelectionFormula = "{sale_master.saleid}=" + Conversion.Val(gblFind);
                if (gblReportOption.ToUpper() == "DUE_RECEIPT")
                    withBlock.RecordSelectionFormula = "{table_master.saleid}=" + Conversion.Val(gblFind);
                // ' For sent Report directly to Printer
                // objReport.PrintToPrinter(1, False, 0, 0)
                // // For export report in pdf format if required uncommit the line
                int c;
                var doctoprint = new System.Drawing.Printing.PrintDocument();
                doctoprint.PrinterSettings.PrinterName = "EPSON L1300 Series";
                var rawKind = default(int);
                var loopTo1 = doctoprint.PrinterSettings.PaperSizes.Count - 1;
                for (c = 0; c <= loopTo1; c++)
                {
                    if (doctoprint.PrinterSettings.PaperSizes[c].PaperName == "Receipt")
                    {
                        rawKind = Conversions.ToInteger(doctoprint.PrinterSettings.PaperSizes[c].GetType().GetField("kind", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes[c]));
                        break;
                    }
                }
                objReport.PrintOptions.PaperSize = (PaperSize)rawKind;
                objReport.ExportToDisk(ExportFormatType.PortableDocFormat, @"d:\CashReceipt-" + gblFind.Trim() + ".pdf");
            }
            objReport.Close();

        }

        public static void DisplayMessage(string Msg)
        {
            Interaction.MsgBox(Msg, (MsgBoxStyle)((int)MsgBoxStyle.OkOnly + (int)MsgBoxStyle.Information), My.MyProject.Application.Info.ProductName);
            return;
        }

        public static void GetConnectionString()
        {
            Connection = new SqlConnection("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + ServerPwd + ";Data Source=" + ServerName + ";DATABASE=POSR;");
        }

        public static bool CheckDatabaseExists(string server, string database)
        {

            string connString = "Data Source=" + server + ";Initial Catalog=master;Integrated Security=True;";
            // Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";Initial Catalog=master;")

            string cmdText = "select * from master.dbo.sysdatabases where name='" + database + "'";
            bool bRet = false;
            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        bRet = reader.HasRows;
                    }
                }
            }
            return bRet;

        }

        public static bool CheckTableExists(string tblname)
        {

            var conn = new SqlConnection("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + ServerPwd + ";Data Source=" + ServerName + ";DATABASE=POSR;");  // Creates a new connection object
            var cmd = new SqlCommand();      // Creates a new command object

            byte exists = 0;           // Creates a byte variable that will store the cmd return value

            cmd.CommandText = "SELECT COUNT(*) " + "FROM sys.objects " + "WHERE object_id = OBJECT_ID(N'[dbo].[" + tblname + "]') " + "AND type in (N'U')";


            try
            {
                conn.Open();                             // Opens the connection
                cmd.Connection = conn;                   // Instructs the cmd object to use conn as its connection when executing
                exists = Conversions.ToByte(cmd.ExecuteScalar());     // Use ExecuteScalar to return a single value, the count, and assign it to the exists variable
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);             // Catch any SqlException and display it in a MessageBox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);             // Catch any ApplicationException and display it in a MessageBox
            }
            return Conversions.ToBoolean(exists);                               // Convert the exists variable to a boolean to determine whether the button should be enabled.

            // Note that by assigning the exists variable a value of 0 earlier, if there is an error in connecting to the database, the value will
            // remain 0, and the button will be disabled by default.  

        }

        public static void ValidateNumericKeyPress(object sender, KeyPressEventArgs e, TextBox txt, TextBox nexttxt)
        {
            // 48 - 57  = Ascii codes for numbers
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\b')
                e.Handled = false; // allow Backspace
            if (Conversions.ToString(e.KeyChar) == "." & txt.Text.IndexOf(".") == -1)
                e.Handled = false; // allow single decimal point
                                   // If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
                                   // If e.KeyChar = Chr(13) Then nexttxt.Focus() 'Enter key moves to next control
                                   // If e.KeyChar = Chr(13) Then GetNextControl(nexttxt, True).Focus() 'Enter key moves to next control
        }

        public static void ValidateNumbersOnly(object sender, KeyPressEventArgs e, TextBox txt)
        {
            // 48 - 57  = Ascii codes for numbers
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\b')
                e.Handled = false; // allow Backspace
        }

        public static string strReplicate(string str, int intD)
        {
            string strReplicateRet = default;
            // This fucntion padded "0" after the number to evaluate hundred, thousand and on....
            // using this function you can replicate any Charactor with given string.
            int i;
            strReplicateRet = string.Empty;
            var loopTo = intD;
            for (i = 1; i <= loopTo; i++)
                strReplicateRet = strReplicateRet + str;
            return strReplicateRet;
        }

        public static string AmtInWord(decimal Num)
        {
            string AmtInWordRet = default;
            // I have created this function for converting amount in indian rupees (INR). 
            // You can manipulate as you wish like decimal setting, Doller (any currency) Prefix.

            string strNum;
            string strNumDec;
            string StrWord;
            strNum = Num.ToString();
            if (Strings.InStr(1, strNum, ".") != 0)
            {
                strNumDec = Strings.Mid(strNum, Strings.InStr(1, strNum, ".") + 1);

                if (Strings.Len(strNumDec) == 1)
                {
                    strNumDec = strNumDec + "0";
                }
                if (Strings.Len(strNumDec) > 2)
                {
                    strNumDec = Strings.Mid(strNumDec, 1, 2);
                }

                strNum = Strings.Mid(strNum, 1, Strings.InStr(1, strNum, ".") - 1);
                StrWord = Conversions.ToString(Operators.AddObject(Operators.AddObject(Interaction.IIf(Conversions.ToDouble(strNum) == 1d, "Rupee ", "Rupees "), NumToWord((decimal)Conversions.ToDouble(strNum))), Interaction.IIf(Conversions.ToDouble(strNumDec) > 0d, " and Paise" + cWord3((decimal)Conversions.ToDouble(strNumDec)), string.Empty)));
            }
            else
            {
                StrWord = Conversions.ToString(Operators.AddObject(Interaction.IIf(Conversions.ToDouble(strNum) == 1d, "Rupee ", "Rupees "), NumToWord((decimal)Conversions.ToDouble(strNum))));
            }
            AmtInWordRet = StrWord + " Only";
            return AmtInWordRet;

        }

        public static string NumToWord(decimal Num)
        {
            string NumToWordRet = default;
            // I divided this function in two part.
            // 1. Three or less digit number.
            // 2. more than three digit number.
            string strNum;
            string StrWord;
            strNum = Num.ToString();

            if (Strings.Len(strNum) <= 3)
            {
                StrWord = cWord3((decimal)Conversions.ToDouble(strNum));
            }
            else
            {
                StrWord = cWordG3((decimal)Conversions.ToDouble(Strings.Mid(strNum, 1, Strings.Len(strNum) - 3))) + " " + cWord3((decimal)Conversions.ToDouble(Strings.Mid(strNum, Strings.Len(strNum) - 2)));
            }
            NumToWordRet = StrWord;
            return NumToWordRet;
        }

        public static string cWordG3(decimal Num)
        {
            string cWordG3Ret = default;
            // 2. more than three digit number.
            string strNum = string.Empty;
            string StrWord = string.Empty;
            string readNum = string.Empty;
            strNum = Num.ToString();
            if (Strings.Len(strNum) % 2 != 0)
            {
                readNum = Conversions.ToDouble(Strings.Mid(strNum, 1, 1)).ToString();
                if (readNum != "0")
                {
                    StrWord = retWord(Conversions.ToDecimal(readNum));
                    readNum = Conversions.ToDouble("1" + strReplicate("0", Strings.Len(strNum) - 1) + "000").ToString();
                    StrWord = StrWord + " " + retWord(Conversions.ToDecimal(readNum));
                }
                strNum = Strings.Mid(strNum, 2);
            }
            while (!(Strings.Len(strNum) == 0))
            {
                readNum = Conversions.ToDouble(Strings.Mid(strNum, 1, 2)).ToString();
                if (readNum != "0")
                {
                    StrWord = StrWord + " " + cWord3(Conversions.ToDecimal(readNum));
                    readNum = Conversions.ToDouble("1" + strReplicate("0", Strings.Len(strNum) - 2) + "000").ToString();
                    StrWord = StrWord + " " + retWord(Conversions.ToDecimal(readNum));
                }
                strNum = Strings.Mid(strNum, 3);
            }
            cWordG3Ret = StrWord;
            return cWordG3Ret;
        }

        public static string cWord3(decimal Num)
        {
            string cWord3Ret = default;
            // 1. Three or less digit number.
            string strNum = string.Empty;
            string StrWord = string.Empty;
            string readNum = string.Empty;
            if (Num < 0m)
                Num = Num * -1;
            strNum = Num.ToString();

            if (Strings.Len(strNum) == 3)
            {
                readNum = Conversions.ToDouble(Strings.Mid(strNum, 1, 1)).ToString();
                StrWord = retWord(Conversions.ToDecimal(readNum)) + " Hundred";
                strNum = Strings.Mid(strNum, 2, Strings.Len(strNum));
            }

            if (Strings.Len(strNum) <= 2)
            {
                if (Conversions.ToDouble(strNum) >= 0d & Conversions.ToDouble(strNum) <= 20d)
                {
                    StrWord = StrWord + " " + retWord((decimal)Conversions.ToDouble(strNum));
                }
                else
                {
                    StrWord = StrWord + " " + retWord((decimal)Conversions.ToDouble(Strings.Mid(strNum, 1, 1) + "0")) + " " + retWord((decimal)Conversions.ToDouble(Strings.Mid(strNum, 2, 1)));
                }
            }

            strNum = Num.ToString();
            cWord3Ret = StrWord;
            return cWord3Ret;
        }

        public static string retWord(decimal Num)
        {
            string retWordRet = default;
            // This two dimensional array store the primary word convertion of number.
            retWordRet = string.Empty;
            object[,] ArrWordList = new object[,] { { 0, string.Empty }, { 1, "One" }, { 2, "Two" }, { 3, "Three" }, { 4, "Four" }, { 5, "Five" }, { 6, "Six" }, { 7, "Seven" }, { 8, "Eight" }, { 9, "Nine" }, { 10, "Ten" }, { 11, "Eleven" }, { 12, "Twelve" }, { 13, "Thirteen" }, { 14, "Fourteen" }, { 15, "Fifteen" }, { 16, "Sixteen" }, { 17, "Seventeen" }, { 18, "Eighteen" }, { 19, "Nineteen" }, { 20, "Twenty" }, { 30, "Thirty" }, { 40, "Forty" }, { 50, "Fifty" }, { 60, "Sixty" }, { 70, "Seventy" }, { 80, "Eighty" }, { 90, "Ninety" }, { 100, "Hundred" }, { 1000, "Thousand" }, { 100000, "Lakh" }, { 10000000, "Crore" } };






            int i;
            var loopTo = Information.UBound(ArrWordList);
            for (i = 0; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(Num, ArrWordList[i, 0], false)))
                {
                    retWordRet = Conversions.ToString(ArrWordList[i, 1]);
                    break;
                }
            }
            return retWordRet;
        }

        public static void ValidateAlphaKeyPress(object sender, KeyPressEventArgs e, TextBox txt)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true; // allow letters
            if (e.KeyChar == '\b' | e.KeyChar == ' ')
                e.Handled = false; // allow Backspace and space
        }

        public static void ValidateAlphaNumOnly(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) > 64 & Strings.Asc(e.KeyChar) < 91 | Strings.Asc(e.KeyChar) > 96 & Strings.Asc(e.KeyChar) < 123 | Strings.Asc(e.KeyChar) > 47 & Strings.Asc(e.KeyChar) < 58 | Strings.Asc(e.KeyChar) == 8) // Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 46
            {
            }
            // Go Through
            else
            {
                e.KeyChar = default;
            }
        }

        public static bool CheckCellValue(DataGridView DataGrid)
        {
            bool CheckCellValueRet = default;
            bool FirstValue = false;
            foreach (DataGridViewCell cell in DataGrid.SelectedCells)
            {
                if (!FirstValue)
                {
                    CheckCellValueRet = true;
                }
                else
                {
                    CheckCellValueRet = false;
                }
            }
            return CheckCellValueRet;
        }

        public static bool CheckRecordExists(string strFind, string tblName, string strField)
        {
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + ServerPwd + ";Data Source=" + ServerName + ";DATABASE=POSR;";
            string cmdText = "SELECT * FROM " + tblName.Trim() + " WHERE (" + strField.Trim() + " = N'" + strFind.Trim() + "')";
            bool bRet = false;
            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        bRet = reader.HasRows;
                    }
                }
            }
            return bRet;
        }

    }
}