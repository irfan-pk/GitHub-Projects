using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class LogBook : Form
    {
        public LogBook()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = null;
            decimal TotalDebit = 0, TotalCredit = 0;
            SqlConnection jConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand jCmd = new SqlCommand();
            SqlDataAdapter jdAdapter = new SqlDataAdapter();
            DataTable jdTable = new DataTable();
            jCmd.CommandType = CommandType.Text;
            jCmd.CommandText = "select * from ledgers where ledg_date >= CONVERT(DATETIME,'" + datePickerFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_date <= CONVERT(DATETIME,'" + datePickerTo.Value.ToString("yyyy-MM-dd") + " 00:00:00',102)";
            jCmd.Connection = jConn;
            jdAdapter.SelectCommand = jCmd;
            jConn.Open();
            jdAdapter.Fill(jdTable);
            bindingSource.DataSource = jdTable;
            if (DgvJournal.Rows.Count > 0)
            {
                foreach (DataGridViewRow gRow in DgvJournal.Rows)
                {
                    TotalDebit += Convert.ToDecimal(gRow.Cells[9].Value.ToString());
                    TotalCredit += Convert.ToDecimal(gRow.Cells[10].Value.ToString());
                }
            }
            jConn.Close();
            lblTotalDebit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalDebit).ToString();
            lblTotalCredit.Text = GlobalVariableClass .FormatCurrency ("Rs.", TotalCredit).ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Waiting for Code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
