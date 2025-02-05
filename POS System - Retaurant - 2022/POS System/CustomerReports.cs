using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class CustomerReports
    {
        private string currentpath = Directory.GetCurrentDirectory();

        public CustomerReports()
        {
            InitializeComponent();
        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {

            if (rdAllCust.Checked == true)
            {
                mdlGeneral.RptUser = "ALL";
            }
            if (rdSelCust.Checked == true)
            {
                if (string.IsNullOrEmpty(cmbCustName.Text))
                {
                    mdlGeneral.gblMessage = "Invalid customer selection.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                mdlGeneral.RptUser = Strings.Mid(cmbCustName.Text.Trim(), 1, 4);
            }
            mdlGeneral.FromDate = DateFrom.Value;
            if (rdDetail.Checked == true)
            {
                mdlGeneral.gblReportOption = "DETAIL";
                mdlGeneral.gblReportName = currentpath + @"\" + @"Reports\CustomerDetail.rpt";
            }
            if (rdLedger.Checked == true)
            {
                mdlGeneral.gblReportOption = "LEDGER";
                mdlGeneral.gblReportName = currentpath + @"\" + @"Reports\CustomerLedger.rpt";
            }
            My.MyProject.Forms.Reports.MdiParent = My.MyProject.Forms.Main;
            My.MyProject.Forms.Reports.Show();

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            mdlGeneral.SqlDataSet.Clear();
            Close();
        }

        private void frmCustomerReports_Load(object sender, EventArgs e)
        {
            mdlGeneral.GetConnectionString();
            rdAllCust.Checked = true;
            rdDetail.Checked = true;
            string FillCombo = "SELECT * FROM CUSTOMERS ORDER BY CUST_CODE";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, FillCombo, mdlGeneral.Connection);
            var Reader = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                    cmbCustName.Items.Add(Reader["CUST_CODE"].ToString() + "-" + Reader["CUST_NAME"].ToString());
            }
        }

        private void rdSelCust_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdSelCust.Checked == true)
            {
                cmbCustName.Enabled = true;
            }
            else
            {
                cmbCustName.Enabled = false;
            }
        }

        private void rdAllCust_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdAllCust.Checked == true)
            {
                cmbCustName.Enabled = false;
            }
            else
            {
                cmbCustName.Enabled = true;
            }
        }
    }
}