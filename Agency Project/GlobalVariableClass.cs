using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace WholeSaleApplication
{
    class GlobalVariableClass
    {
        public static int v_gblAccID = 0;
        public static String gblConnectionString = String.Empty;
        public static int SequenceID = 0;
        public static int RequiredId = 0;
        public static String v_gblViewFieldName = String.Empty;
        public static String v_gblViewTableName = String.Empty;
        public static String v_gblViewValueMember = String.Empty;
        public static String v_gblSearchString = String.Empty;
        public static bool v_gblRecMode = false;
        public static bool v_isopen = false;
        public static String v_gblProductCode = String.Empty;
        public static String v_gblMode = String.Empty;
        public static String v_gblOperator = String.Empty;
        public static int gblOperatorId = 0;

        public static int gblIntegerValue { get; set; }

        public static String gblOperator { get; set; }

        public static String gblMode { get; set; }

        public static String gblProductCode { get; set; }

        public static String gblReportName { get; set; }

        public static String gblUserName { get; set; }
        public static String gblPassword { get; set; }
        public static String gblDatabaseName { get; set; }
        public static String gblHostName { get; set; }
        public static String gblProgName { get; set; }

        public static int gblAccountID
        {
            get { return v_gblAccID; }
            set { v_gblAccID = value; }
        }

        public static string ViewFieldName
        {
            get { return v_gblViewFieldName; }
            set { v_gblViewFieldName = value; }
        }

        public static string ViewTableName
        {
            get { return v_gblViewFieldName; }
            set { v_gblViewFieldName = value; }
        }

        public static string ViewMember
        {
            get { return v_gblViewValueMember; }
            set { v_gblViewValueMember = value; }
        }

        public static string SearchString
        {
            get { return v_gblSearchString; }
            set { v_gblSearchString = value; }
        }

        public static bool RecMode
        {
            get { return v_gblRecMode; }
            set { v_gblRecMode = value; }
        }

        public static bool IsFormOpen
        {
            get { return v_isopen; }
            set { v_isopen = value; }
        }
        public static int GenerateSeqID(String field, String tablename)
        {
            SequenceID = 0;
            SqlConnection SqlConn = new SqlConnection(gblConnectionString);
            SqlCommand SqlCmd = new SqlCommand("select max(" + field + ") from " + tablename, SqlConn);
            SqlConn.Open();
            SqlCmd.CommandType = CommandType.Text;
            SqlDataReader reader = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        SequenceID = Convert.ToInt32(reader[0].ToString()) + 1;
                    }
                    else
                    {
                        SequenceID = 1;
                    }
                }
            }
            else
            {
                SequenceID = 1;
            }
            SqlConn.Close();
            return SequenceID;
        }

        public static int GetUnitId(String fieldIn, String fieldOut, String tablename, String Condition)
        {
            RequiredId = 0;
            SqlConnection SqlConn = new SqlConnection(gblConnectionString);
            SqlCommand SqlCmd = new SqlCommand("select " + fieldOut + " from " + tablename + " where " + fieldIn + "='" + Condition + "'", SqlConn);
            SqlConn.Open();
            SqlCmd.CommandType = CommandType.Text;
            SqlDataReader reader = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        RequiredId = Convert.ToInt32(reader[0].ToString());
                    }
                }
            }
            SqlConn.Close();
            return RequiredId;
        }

        public static String GetFieldInfo(String fieldIn, String fieldOut, String tablename, String Condition)
        {
            String RequiredString = String.Empty;
            SqlConnection SqlConn = new SqlConnection(gblConnectionString);
            SqlCommand SqlCmd = new SqlCommand("select " + fieldOut + " from " + tablename + " where " + fieldIn + "='" + Condition + "'", SqlConn);
            SqlConn.Open();
            SqlCmd.CommandType = CommandType.Text;
            SqlDataReader reader = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        RequiredString = reader[0].ToString();
                    }
                }
            }
            SqlConn.Close();
            return RequiredString;
        }

        public static void FillComboxBox(ComboBox MyCombo, String strField, String strTable)
        {
            try
            {
                SqlConnection FillConn = new SqlConnection(gblConnectionString);
                SqlCommand SqlCmd = new SqlCommand("select " + strField + " from " + strTable + " order by " + strField, FillConn);
                FillConn.Open();
                SqlDataReader filler = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
                MyCombo.Items.Clear();
                if (filler.HasRows)
                {
                    while (filler.Read())
                    {
                        MyCombo.Items.Add(filler[strField].ToString());
                    }
                }
                else
                {
                    v_gblSearchString = String.Empty;
                }
                filler.Close();
                FillConn.Close();
            }
            catch(Exception Exp)
            {
                MessageBox.Show(Exp.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                v_gblSearchString = String.Empty;
            }
        }

        public static bool CheckRowExist(String FieldName, String TableName, String CheckString)
        {
            bool result = false;
            SqlConnection ChkConn = new SqlConnection(gblConnectionString);
            SqlCommand ChkCmd = new SqlCommand("select * from " + TableName + " where " + FieldName + "='" + CheckString + "'", ChkConn);
            try
            {
                ChkConn.Open();
                SqlDataReader reader = ChkCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                reader.Close();
            }
            catch (Exception ExpErr)
            {
                MessageBox.Show(ExpErr.ToString());
            }
            ChkConn.Close();
            return result;
        }

        public static bool CheckRecrodExist(String CheckRecord)
        {
            bool result = false;
            SqlConnection ChkConn = new SqlConnection(gblConnectionString);
            SqlCommand ChkCmd = new SqlCommand(CheckRecord, ChkConn);
            try
            {
                ChkConn.Open();
                SqlDataReader reader = ChkCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Read())
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                reader.Close();
            }
            catch (Exception ExpErr)
            {
                MessageBox.Show(ExpErr.ToString());
            }
            ChkConn.Close();
            return result;
        }

        private static bool alreadyExist(String _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        public static void validate_textBox(TextBox _text, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (_text.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (_text.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(_text.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (_text.SelectionStart != _text.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    String AfterDotString = _text.Text.Substring(_text.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(_text.Text, ref sepratorChar))
                {
                    int sepratorPosition = _text.Text.IndexOf(sepratorChar);
                    String afterSepratorString = _text.Text.Substring(sepratorPosition + 1);
                    if (_text.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }
        //For Currency Symbol
        public static String FormatCurrency(String currencyCode, decimal amount)
        {
            CultureInfo culture = (from c in CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                                   let r = new RegionInfo(c.LCID)
                                   where r != null
                                   && r.ISOCurrencySymbol.ToUpper() == currencyCode.ToUpper()
                                   select c).FirstOrDefault();
            if (culture == null)
            {
                // fall back to current culture if none is found
                // you could throw an exception here if that's not supposed to happen
                culture = CultureInfo.CurrentCulture;

            }
            culture = (CultureInfo)culture.Clone();
            culture.NumberFormat.CurrencySymbol = currencyCode;
            culture.NumberFormat.CurrencyPositivePattern = culture.NumberFormat.CurrencyPositivePattern == 0 ? 2 : 3;
            var cnp = culture.NumberFormat.CurrencyNegativePattern;
            switch (cnp)
            {
                case 0: cnp = 14; break;
                case 1: cnp = 9; break;
                case 2: cnp = 12; break;
                case 3: cnp = 11; break;
                case 4: cnp = 15; break;
                case 5: cnp = 8; break;
                case 6: cnp = 13; break;
                case 7: cnp = 10; break;
            }
            culture.NumberFormat.CurrencyNegativePattern = cnp;

            return amount.ToString("C" + ((amount % 1) == 0 ? "0" : "2"), culture);
        }

        public static void showWindow(Form OpenWin, Form CloseWin, Form MdiWin)
        {
            CloseWin.Close();
            OpenWin.MdiParent = MdiWin;
            OpenWin.Show();
        }

        public static void showWindow(Form OpenWin, Form MdiWin)
        {
            OpenWin.MdiParent = MdiWin;
            OpenWin.Show();
        }

        public static void DebitEntry(DateTime sDate, int TrId, String TrType, String AccHead, int AccNo, String AccName, String Voucher, String Narration, String DrCr, decimal Debit, Decimal Credit, Decimal Balance, int order, String Fyear)
        {
            if (DrCr == "DR") { Balance += Debit; }
            else
            {
                if (Balance == 0 || Balance < Debit)
                {
                    Balance = Debit - Balance;
                }
                else
                {
                    Balance -= Debit;
                }
            }
            SqlConnection DrConn = new SqlConnection(gblConnectionString);
            SqlCommand DrCmd = new SqlCommand();
            DrCmd.CommandType = CommandType.Text;
            DrCmd.Connection = DrConn;
            String jDrQuery = "Insert into ledgers values ('" +
                            sDate.ToString("yyyy-MM-dd") + "'," +
                            TrId + ",'" +
                            TrType + "','" +
                            AccHead + "'," +
                            AccNo + ",'" +
                            AccName + "','" +
                            Voucher + "','" +
                            Narration + "','" +
                            DrCr + "'," +
                            Debit + "," +
                            Credit + "," +
                            Balance + "," +
                            order + ",'" +
                            Fyear + "')";
            DrCmd.CommandText = jDrQuery;
            DrConn.Open();
            DrCmd.ExecuteNonQuery();
            DrConn.Close();
        }

        public static void CreditEntry(DateTime sDate, int TrId, String TrType, String AccHead, int AccNo, String AccName, String Voucher, String Narration, String DrCr, decimal Debit, Decimal Credit, Decimal Balance, int order, String Fyear)
        {
            if (DrCr == "CR") { Balance += Credit; }
            else
            {
                if (Balance == 0 || Balance < Credit)
                {
                    Balance = Credit - Balance;
                }
                else
                {
                    Balance -= Credit;
                }
            }
            SqlConnection CrConn = new SqlConnection(gblConnectionString);
            SqlCommand CrCmd = new SqlCommand();
            CrCmd.CommandType = CommandType.Text;
            CrCmd.Connection = CrConn;
            String jCrQuery = "Insert into ledgers values ('" +
                            sDate.ToString("yyyy-MM-dd") + "'," +
                            TrId + ",'" +
                            TrType + "','" +
                            AccHead + "'," +
                            AccNo + ",'" +
                            AccName + "','" +
                            Voucher + "','" +
                            Narration + "','" +
                            DrCr + "'," +
                            Debit + "," +
                            Credit + "," +
                            Balance + "," +
                            order + ",'" +
                            Fyear + "')";
            CrCmd.CommandText = jCrQuery;
            CrConn.Open();
            CrCmd.ExecuteNonQuery();
            CrConn.Close();
        }
        public static decimal GetBalance(String sAccName, Decimal iBalance)
        {
            Decimal CloseBalance = 0;
            SqlCommand BalCmd = new SqlCommand();
            BalCmd.CommandType = CommandType.Text;
            BalCmd.CommandText = "Select opn_bal from Accounts where account_name = '" + sAccName + "'";
            SqlConnection BalConn = new SqlConnection();
            BalCmd.Connection = BalConn;
            BalConn.Open();
            SqlDataReader dr = BalCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    CloseBalance = dr.GetDecimal(8);
                }
            }
            BalConn.Close();
            iBalance = CloseBalance;
            return iBalance = 0;
        }
    }
}
