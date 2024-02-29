using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using System.IO;

namespace WholeSaleApplication
{
    public partial class LedgerForm : Form
    {
        SqlConnection TabConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        SqlCommand DrLedg = new SqlCommand();
        SqlCommand CrLedg = new SqlCommand();
        Decimal OpenBal = 0, DrBal = 0, CrBal = 0;
        public LedgerForm()
        {
            InitializeComponent();
        }

        private void LedgerForm_Load(object sender, EventArgs e)
        {
            GlobalVariableClass.FillComboxBox(cbAccountName, "account_name", "accounts");
            ShowFinancialData();
        }

        private void ShowFinancialData()
        {
            //For Debit Side
            SqlDataAdapter rightAdapter = new SqlDataAdapter();
            DataTable rightDataTable = new DataTable();
            DrLedg.Connection = TabConn;
            DrLedg.CommandType = CommandType.Text;
            DrLedg.CommandText = "select * from ledgers where ledg_date >= CONVERT(DATETIME,'" + datePickerFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_date <= CONVERT(DATETIME,'" + datePickerTo.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_debit > 0 and ledg_sub_acc = N'" + cbAccountName.Text.Trim() + "'";
            rightAdapter.SelectCommand = DrLedg;
            TabConn.Open();
            rightAdapter.Fill(rightDataTable);
            bindingSourceDr.DataSource = rightDataTable;
            TabConn.Close();

            //For Credit Side
            SqlDataAdapter leftAdapter = new SqlDataAdapter();
            DataTable leftDataTable = new DataTable();
            CrLedg.Connection = TabConn;
            CrLedg.CommandType = CommandType.Text;
            CrLedg.CommandText = "select * from ledgers where ledg_date >= CONVERT(DATETIME,'" + datePickerFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_date <= CONVERT(DATETIME,'" + datePickerTo.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_credit > 0 and ledg_sub_acc = N'" + cbAccountName.Text.Trim() + "'";
            leftAdapter.SelectCommand = CrLedg;
            TabConn.Open();
            leftAdapter.Fill(leftDataTable);
            bindingSourceCr.DataSource = leftDataTable;
            TabConn.Close();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            ShowFinancialData();
            OpeningBalance();
            CalculateTotals();
            OpenBal = 0;
            DrBal = 0;
            CrBal = 0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrialBal_Click(object sender, EventArgs e)
        {
            Decimal TotDebit=0, TotCredit=0;
            SqlCommand TrialBal = new SqlCommand();
            TrialBal.CommandType = CommandType.Text;
            TrialBal.CommandText = "select ledgers.Ledg_Acc_Id,ledgers.Ledg_Sub_Acc,ledgers.Ledg_Acc_Type,sum(ledgers.Ledg_Debit) as Debit, Sum(Ledgers.Ledg_Credit) as Credit from Ledgers " +
                                   "where ledg_date >= CONVERT(DATETIME,'" + dateFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_date <= CONVERT(DATETIME,'" + dateTo.Value.ToString("yyyy-MM-dd") + " 00:00:00',102)" +
                                   "group by Ledgers.Ledg_Acc_Id,Ledgers.Ledg_Sub_Acc,ledgers.Ledg_Acc_Type";
            TrialBal.Connection = TabConn;
            TabConn.Open();
            SqlDataReader dr = TrialBal.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int NewRowIndex = DgvTrialBal.Rows.Add();
                    DataGridViewRow NewRow = DgvTrialBal.Rows[NewRowIndex];
                    NewRow.Cells[0].Value = dr.GetInt32(0);
                    NewRow.Cells[1].Value = dr.GetString(1);

                    if (dr.GetString(2)=="DR")
                    {
                        TotDebit = Convert.ToDecimal(dr.GetDecimal(3)) - Convert.ToDecimal(dr.GetDecimal(4));
                        NewRow.Cells[2].Value = TotDebit;
                        NewRow.Cells[3].Value = 0;
                        DrBal += TotDebit;
                    }
                    else
                    {
                        TotCredit = Convert.ToDecimal(dr.GetDecimal(4)) - Convert.ToDecimal(dr.GetDecimal(3));
                        NewRow.Cells[2].Value = 0;
                        NewRow.Cells[3].Value = TotCredit;
                        CrBal += TotCredit;
                    }
                }
            }
            TabConn.Close();
            if (DrBal > CrBal || DrBal < CrBal)
            {
                lblTrialDr.ForeColor = System.Drawing.Color.Maroon;
                lblTrialCr.ForeColor = System.Drawing.Color.Maroon;
            }
            else
            {
                lblTrialDr.ForeColor = System.Drawing.Color.White;
                lblTrialCr.ForeColor = System.Drawing.Color.White;
            }
            lblTrialDr.Text = GlobalVariableClass.FormatCurrency("Rs.", DrBal);
            lblTrialCr.Text = GlobalVariableClass.FormatCurrency("Rs.", CrBal);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 3)
            {
                // File Selection
                ReportDocument RptDocument = new ReportDocument();
                String Path = Directory.GetCurrentDirectory();
                GlobalVariableClass.gblReportName = Path + "\\Reports\\BalanceSheet.rpt";
                RptDocument.Load(GlobalVariableClass.gblReportName);

                // Add server logon information
                crystalReportBalSheet.ReportSource = null;
                ConnectionInfo ConnInfo = new ConnectionInfo();
                ConnInfo.UserID = "sa";
                ConnInfo.Password = "ishanw";
                ConnInfo.ServerName = "localhost";
                ConnInfo.DatabaseName = "POS_ERP";

                TableLogOnInfo crTableLogoninfo = new TableLogOnInfo();
                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in RptDocument.Database.Tables)
                {
                    crTableLogoninfo = CrTable.LogOnInfo;
                    crTableLogoninfo.ConnectionInfo = ConnInfo;
                    CrTable.ApplyLogOnInfo(crTableLogoninfo);
                }
                crystalReportBalSheet.ReportSource = RptDocument;
            }

            if (tabControl.SelectedIndex == 2)
            {
                // File Selection
                ReportDocument RptDocument = new ReportDocument();
                String Path = Directory.GetCurrentDirectory();
                GlobalVariableClass.gblReportName = Path + "\\Reports\\IncomeStatementFinal.rpt";
                RptDocument.Load(GlobalVariableClass.gblReportName);

                // Add server logon information
                crystalReportBalSheet.ReportSource = null;
                ConnectionInfo ConnInfo = new ConnectionInfo();
                ConnInfo.UserID = "sa";
                ConnInfo.Password = "ishanw";
                ConnInfo.ServerName = "localhost";
                ConnInfo.DatabaseName = "POS_ERP";

                TableLogOnInfo crTableLogoninfo = new TableLogOnInfo();
                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in RptDocument.Database.Tables)
                {
                    crTableLogoninfo = CrTable.LogOnInfo;
                    crTableLogoninfo.ConnectionInfo = ConnInfo;
                    CrTable.ApplyLogOnInfo(crTableLogoninfo);
                }
                crystalReportIncome.ReportSource = RptDocument;
            }
        }

        private void CalculateTotals()
        {
            Decimal TotalDr = 0, TotalCr = 0, CloseBal = 0;
            String AccType = String.Empty;
            foreach (DataGridViewRow DrRow in DgvJournalDr.Rows) { TotalDr += Convert.ToDecimal(DrRow.Cells[9].Value); AccType = DrRow.Cells[8].Value.ToString(); }
            foreach (DataGridViewRow CrRow in DgvJournalCr.Rows) { TotalCr += Convert.ToDecimal(CrRow.Cells[10].Value); }
            lblTotalDebit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalDr);
            lblTotalCredit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalCr);
            if (AccType == "DR")
            { CloseBal = (OpenBal + TotalDr) - TotalCr; } else { CloseBal = (OpenBal + TotalCr) - TotalDr; }
            if (CloseBal > 0)
            {  ClosingBal.Text = GlobalVariableClass.FormatCurrency("Rs.", CloseBal); }
            else
            {  ClosingBal.Text = GlobalVariableClass.FormatCurrency("Rs.", CloseBal); }
        }
        private void OpeningBalance()
        {
            SqlCommand opnCmd = new SqlCommand();
            opnCmd.CommandType = CommandType.Text;
            opnCmd.CommandText = "select * from ledgers where ledg_date < CONVERT(DATETIME,'" + datePickerFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and ledg_sub_acc = N'" + cbAccountName.Text.Trim() + "'";
            opnCmd.Connection = TabConn;
            TabConn.Open();
            SqlDataReader dr = opnCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DrBal += dr.GetDecimal(9);
                    CrBal += dr.GetDecimal(10);
                }
            }
            if (DrBal > CrBal)
            { OpenBal = DrBal - CrBal; }
            else
            { OpenBal = CrBal - DrBal; }
            lblOpenBal.Text = GlobalVariableClass.FormatCurrency("Rs.", OpenBal);
            TabConn.Close();
        }
    }
}
