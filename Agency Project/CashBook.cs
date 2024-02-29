using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class CashBook : Form
    {
        SqlConnection cashConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        SqlCommand cashCmd = new SqlCommand();
        Decimal TotDebit=0, TotCredit=0, OpnBalDr=0, OpnBalCr=0, Opening=0, RunClosing=0;
        
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateOpeningBalance();
            DisplayCashBookDetails();
        }

        private void CashBook_Load(object sender, EventArgs e)
        {
            CalculateOpeningBalance();
            DisplayCashBookDetails();
        }

        private void CalculateOpeningBalance()
        {
            try
            {
                TotDebit = 0; TotCredit = 0; OpnBalDr = 0; OpnBalCr = 0; Opening = 0; RunClosing = 0;
                SqlCommand OpnCmd = new SqlCommand();
                OpnCmd.Connection = cashConn;
                OpnCmd.CommandType = CommandType.Text;
                OpnCmd.CommandText = "select ledg_acc_id, sum(ledg_debit) as TotDebit, sum(ledg_credit) as TotCredit from ledgers where ledg_date < CONVERT(DATETIME,'" + 
                                     dateTimePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_acc_id = 1 group by ledg_acc_id";
                if (cashConn.State == ConnectionState.Open) { cashConn.Close(); }
                cashConn.Open();
                SqlDataReader balrdr = OpnCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (balrdr.HasRows)
                {
                    while (balrdr.Read())
                    {
                        OpnBalDr = balrdr.GetDecimal(1);
                        OpnBalCr = balrdr.GetDecimal(2);
                    }
                }
                OpnCmd.Dispose();
                cashConn.Close();
                Opening = OpnBalDr - OpnBalCr;
                lblOpening.Text = Opening.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayCashBookDetails()
        {
            components.Add(this.bindingSourceDr);
            components.Add(this.bindingSourceCr);
            bindingSourceDr.DataSource = null;
            bindingSourceCr.DataSource = null;

            // For Debit Side
            SqlCommand DrData = new SqlCommand();
            DrData.CommandType = CommandType.Text;
            DrData.CommandText = "select ledg_date,ledg_narration,ledg_voucher_no,ledg_debit from ledgers where ledg_date >= CONVERT(DATETIME,'" + 
                                 dateTimePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_acc_id = 1 and ledg_debit > 0";
            DrData.Connection = cashConn;
            SqlDataAdapter DrDa = new SqlDataAdapter();
            DataTable DrDt = new DataTable();
            DrDa.SelectCommand = DrData;
            if(cashConn.State == ConnectionState.Open) { cashConn.Close(); }
            cashConn.Open();
            DrDa.Fill(DrDt);
            bindingSourceDr.DataSource = DrDt;
            DgvDebit.Refresh();
            DrDa.Dispose();
            cashConn.Close();

            // For Credit Side
            SqlCommand CrData = new SqlCommand();
            CrData.CommandType = CommandType.Text;
            CrData.CommandText = "select ledg_date,ledg_narration,ledg_voucher_no,ledg_credit from ledgers where ledg_date >= CONVERT(DATETIME,'" + 
                                 dateTimePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_acc_id = 1 and ledg_credit > 0";
            CrData.Connection = cashConn;
            SqlDataAdapter CrDa = new SqlDataAdapter();
            DataTable CrDt = new DataTable();
            CrDa.SelectCommand = CrData;
            if (cashConn.State == ConnectionState.Open) { cashConn.Close(); }
            cashConn.Open();
            CrDa.Fill(CrDt);
            bindingSourceCr.DataSource = CrDt;
            DgvCredit.Refresh();
            CrDa.Dispose();
            cashConn.Close();

            // For Closing Balance
            if (DgvDebit.Rows.Count > 0)
            {
                foreach (DataGridViewRow gRow in DgvDebit.Rows) { TotDebit += Convert.ToDecimal(gRow.Cells[3].Value.ToString()); }
            }

            if (DgvCredit.Rows.Count > 0)
            {
                foreach (DataGridViewRow gRow in DgvCredit.Rows) { TotCredit += Convert.ToDecimal(gRow.Cells[3].Value.ToString()); }
            }
            lblDebit.Text = TotDebit.ToString();
            lblCredit.Text = TotCredit.ToString();
            RunClosing = TotDebit - TotCredit;
            lblCashInHand.Text = (Opening + RunClosing).ToString();
        }

        public CashBook()
        {
            InitializeComponent();
        }
    }
}
