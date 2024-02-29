using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class QuickReceipts : Form
    {
        SqlConnection qConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        DateTime InvoiceDate = DateTime.Now;
        int AccountID = 0, TranID = 0;
        Decimal pBalance = 0, InvBalance = 0;
        String AccHead = String.Empty, DrCr = String.Empty, AccName = String.Empty;
        SqlConnection rConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        public QuickReceipts()
        {
            InitializeComponent();
        }

        private void QuickReceipts_Load(object sender, EventArgs e)
        {
            this.components.Add(bindingSourceReceipt);
            GlobalVariableClass.FillComboxBox(CbSalesMan,"SalesManName", "SalesMan");
            GetPaymentData();
        }

        private void GetPaymentData()
        {
            bindingSourceReceipt.DataSource = null;
            SqlCommand lCmd = new SqlCommand();
            lCmd.Connection = rConn;
            lCmd.CommandType = CommandType.Text;
            SqlDataAdapter dta = new SqlDataAdapter();
            DataTable dt = new DataTable();
            lCmd.CommandText = "select * from paymentreceipts where paymentdate = CONVERT(DATETIME,'" + dateTimePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00',102)";
            dta.SelectCommand = lCmd;
            rConn.Open();
            dta.Fill(dt);
            bindingSourceReceipt.DataSource = dt;
            DgvQuickReceipt.Refresh();
            rConn.Close();
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            SqlCommand calcCmd = new SqlCommand();
            calcCmd.Connection = rConn;
            calcCmd.CommandType = CommandType.Text;
            calcCmd.CommandText = "select ISNULL(sum(TotalPayment),0) as Total, ISNULL(sum(PaymentDiscount),0) as Disc, ISNULL(sum(cashpayment),0) as Cash from paymentreceipts where paymentdate = CONVERT(DATETIME,'" + dateTimePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00',102)";
            if(rConn.State == ConnectionState.Open)
            { rConn.Close(); }
            rConn.Open();
            SqlDataReader cdr = calcCmd.ExecuteReader(CommandBehavior.CloseConnection);
            Decimal Amount = 0;
            Decimal Discount = 0;
            Decimal Cash = 0;
            if(cdr.HasRows)
            {
                while(cdr.Read())
                {
                    Amount = cdr.GetDecimal(0);
                    Discount = cdr.GetDecimal(1);
                    Cash = cdr.GetDecimal(2);
                }
            }
            rConn.Close();
            TbTotalAmnt.Text = GlobalVariableClass.FormatCurrency("Rs.", Amount);
            TbTotDisc.Text = GlobalVariableClass.FormatCurrency("Rs.", Discount);
            TbTotCash.Text = GlobalVariableClass.FormatCurrency("Rs.", Cash);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //// Taken from MSDN Forum
            bool existsdata = true;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    if (txt == null || txt.Text == string.Empty)
                    {
                        existsdata = true;
                        c.Focus();
                        break;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox cbx = (ComboBox)c;

                    if (cbx == null || cbx.SelectedText == string.Empty || cbx.Items.Count <= 0)
                    {
                        existsdata = true;
                        c.Focus();
                        break;
                    }
                }
            }

            if (existsdata)
            {
                ////Inserted info to database
                int sortseq = 0;
                String FinacialYear = String.Empty;
                DateTime F_Year = DateTime.Today;
                if (F_Year.Month < 7) { FinacialYear = "FY - " + F_Year.Year; }
                TranID = GlobalVariableClass.GenerateSeqID("ledg_tran_id", "ledgers");
                SqlCommand sCmd = new SqlCommand();
                sCmd.CommandType = CommandType.Text;
                sCmd.CommandText = "insert into paymentreceipts values (" +
                                   GlobalVariableClass.GenerateSeqID("paymentorder", "paymentreceipts") + ",'" +
                                   dateTimePicker.Value.ToString("yyyy-MM-dd") + "'," +
                                   Convert.ToDecimal(CbReceipt.Text.ToString()) + ",'" +
                                   InvoiceDate.ToString("yyyy-MM-dd") + "','" +
                                   TbPartyName.Text + "'," + 
                                   Convert.ToDecimal(TbTotAmnt.Text.ToString()) + "," +
                                   Convert.ToDecimal(TbDiscount.Text.ToString()) + "," +
                                   Convert.ToDecimal(TbCashAmnt.Text.ToString()) + "," +
                                   InvBalance + ",'" +
                                   TbRemarks.Text.ToString() + "')";
                sCmd.Connection = qConn;
                qConn.Open();
                sCmd.ExecuteNonQuery();
                qConn.Close();

                // For Cash Debit
                GetAccountDetails("Cash");
                GlobalVariableClass.DebitEntry(dateTimePicker.Value,
                                               TranID,
                                               "Payment",
                                               AccHead,
                                               AccountID,
                                               AccName,
                                               "SI - " + CbReceipt.Text,
                                               TbRemarks.Text,
                                               DrCr,
                                               Convert.ToDecimal(TbCashAmnt.Text),
                                               0,
                                               pBalance,
                                               sortseq + 1,
                                               FinacialYear
                                               );
                UpdatePartyBalance(AccName,Convert.ToDecimal(TbCashAmnt.Text));
                // For Party Credit
                GetAccountDetails(TbPartyName.Text);
                GlobalVariableClass.CreditEntry(dateTimePicker.Value,
                                               TranID,
                                               "Payment",
                                               AccHead,
                                               AccountID,
                                               AccName,
                                               "SI - " + CbReceipt.Text,
                                               TbRemarks.Text,
                                               DrCr,
                                               0,
                                               Convert.ToDecimal(TbCashAmnt.Text),
                                               pBalance,
                                               sortseq + 1,
                                               FinacialYear
                                               );
                UpdatePartyBalance(AccName, Convert.ToDecimal(TbCashAmnt.Text) * -1);
                sortseq = 0;

                // For payment into salebook
                SqlCommand SaleBook = new SqlCommand();
                SaleBook.CommandType = CommandType.Text;
                SaleBook.CommandText = "INSERT INTO SaleBook(Date, SaleOrderId, VoucherID, TransactionType, AccountID, AccountName, AccountNameUr, MainQty, AltQty, Loose, Free, BasicAmount, Discount, DrAmount, CrAmount, OrderSalesMan, RecoveryDate, Remarks) " +
                                       "SELECT Date, SaleOrderId, VoucherID, TransactionType, AccountID, AccountName, AccountNameUr, MainQty, AltQty, Loose, Free, BasicAmount, Discount, 0, " + Convert.ToDecimal(TbCashAmnt.Text) + ", OrderSalesMan, '" + dateTimePicker.Value.ToString("yyyy-MM-dd") + "', 'Cr.' FROM SaleBook WHERE SaleOrderId = " + Convert.ToDecimal(CbReceipt.Text);
                SaleBook.Connection = qConn;
                if(qConn.State == ConnectionState.Open) { qConn.Close(); }
                qConn.Open();
                SaleBook.ExecuteNonQuery();
                qConn.Close();
                SaleBook.Dispose();
                sCmd.Dispose();
                GetPaymentData();
                ClearControls();
                BtnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show(this, "All fields must be filled.", "Fields Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetPaymentData();
        }

        private void GetInvoiceData()
        {
            if (!String.IsNullOrEmpty(CbReceipt.Text))
            {
                SqlCommand gInvCmd = new SqlCommand();
                gInvCmd.CommandType = CommandType.Text;
                gInvCmd.CommandText = "select date, accountname, cramount from saleorder where saleorderid = " + Convert.ToDecimal(CbReceipt.Text.ToString());
                gInvCmd.Connection = rConn;
                if(rConn.State == ConnectionState.Open) { rConn.Close(); }
                rConn.Open();
                SqlDataReader idr = gInvCmd.ExecuteReader();
                if (idr.HasRows)
                {
                    while (idr.Read())
                    {
                        InvoiceDate = idr.GetDateTime(0);
                        TbPartyName.Text = idr.GetString(1);
                        TbTotAmnt.Text = Convert.ToString(idr["cramount"].ToString());
                    }
                    TbDiscount.Focus();
                }
                rConn.Close();
            }
        }
        private void TbTotAmnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TbCashAmnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if(Convert.ToDecimal(TbCashAmnt.Text) > 0)
            { InvBalance = Convert.ToDecimal(TbTotAmnt.Text) - Convert.ToDecimal(TbDiscount.Text) - Convert.ToDecimal(TbCashAmnt.Text); }
        }

        private void TbReceipt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbSalesMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand dInvoices = new SqlCommand();
            dInvoices.CommandType = CommandType.Text;
            dInvoices.Connection = qConn;
            dInvoices.CommandText = "select saleorderid from saleorder where cramount > 0 and ordersalesman = '" + CbSalesMan.Text + "'";
            qConn.Open();
            SqlDataReader dr = dInvoices.ExecuteReader(CommandBehavior.CloseConnection);
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    CbReceipt.Items.Add(dr.GetDecimal(0));
                }
            }
            qConn.Close();
        }

        private void CbReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInvoiceData();
            TbRemarks.Text = "Recovery from Customer via " + CbMode.Text;
        }

        private void TbPartyName_TextChanged(object sender, EventArgs e)
        {
            TbRemarks.Text = "Recovery from Customer via " + CbMode.Text;
            GetAccountDetails(TbPartyName.Text);
        }

        private void GetAccountDetails(string text)
        {
            SqlCommand SearchAcc = new SqlCommand();
            SearchAcc.CommandType = CommandType.Text;
            SearchAcc.CommandText = "select account_id,account_name,opn_bal,accounthead,Dr_Cr from accounts where account_name = '" + text + "'";
            SearchAcc.Connection = qConn;
            if (qConn.State == ConnectionState.Open) { qConn.Close(); }
            qConn.Open();
            SqlDataReader dr = SearchAcc.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    AccountID = dr.GetInt32(0);
                    AccName = dr.GetString(1);
                    lblBalance.Text = dr.GetDecimal(2).ToString();
                    pBalance = dr.GetDecimal(2);
                    AccHead = dr.GetString(3);
                    DrCr = dr.GetString(4);
                }
            }
            qConn.Close();
        }

        private void TbDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            TbCashAmnt.Text = Convert.ToString(Convert.ToDecimal(TbTotAmnt.Text.ToString()) - Convert.ToDecimal(TbDiscount.Text.ToString())); 
        }

        private void TbCashAmnt_Leave(object sender, EventArgs e)
        {
            TbDiscount.Text = Convert.ToString(Convert.ToDecimal(TbTotAmnt.Text.ToString()) - Convert.ToDecimal(TbCashAmnt.Text.ToString()));
            BtnSave.Enabled = true;
        }

        private void ClearControls()
        {
            CbMode.Text = "";
            CbSalesMan.Text = "";
            CbReceipt.Text = "";
            TbRemarks.Text = "";
            TbPartyName.Text = "";
            lblBalance.Text = "0.00";
            TbTotAmnt.Text = "0.00";
            TbDiscount.Text = "0.00";
            TbCashAmnt.Text = "0.00";
            CbMode.Focus();
        }

        private void TbPartyName_Leave(object sender, EventArgs e)
        {
            TbRemarks.Text = "Recovery from Customer via " + CbMode.Text;
            GetAccountDetails(TbPartyName.Text);
        }

        private void TbRemarks_TextChanged(object sender, EventArgs e)
        {
            //BtnSave.Enabled = true;
        }

        private void TbCashAmnt_TextChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
        }

        private void UpdatePartyBalance(String AccName, Decimal Amount)
        {
            SqlCommand updtcmd = new SqlCommand();
            updtcmd.Connection = rConn;
            updtcmd.CommandType = CommandType.Text;
            updtcmd.CommandText = "update accounts set opn_bal = opn_bal + " + Amount + " where account_name = '" + AccName + "'";
            rConn.Open();
            updtcmd.ExecuteNonQuery();
            rConn.Close();
        }
    }
}
