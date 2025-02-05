using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class WholesalerReports
    {

        private string currentpath = Directory.GetCurrentDirectory();

        public WholesalerReports()
        {
            InitializeComponent();
        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {

            if (rdAllSaler.Checked == true)
            {
                mdlGeneral.RptUser = "ALL";
            }
            if (rdSelSaler.Checked == true)
            {
                if (string.IsNullOrEmpty(cmbCustName.Text))
                {
                    mdlGeneral.gblMessage = "Invalid wholesaler selection.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                mdlGeneral.RptUser = Strings.Mid(cmbCustName.Text.Trim(), 1, 4);
            }
            mdlGeneral.FromDate = DateFrom.Value;
            if (rdWDetail.Checked == true)
            {
                mdlGeneral.gblReportOption = "WDETAIL";
                mdlGeneral.gblReportName = currentpath + @"\" + @"Reports\WholesalerDetail.rpt";
            }
            if (rdWLedger.Checked == true)
            {
                mdlGeneral.gblReportOption = "WLEDGER";
                mdlGeneral.gblReportName = currentpath + @"\" + @"Reports\WholesalerLedger.rpt";
            }
            My.MyProject.Forms.Reports.MdiParent = My.MyProject.Forms.Main;
            My.MyProject.Forms.Reports.Show();

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            mdlGeneral.SqlDataSet.Clear();
            Close();
        }

        private void frmWholsalerReports_Load(object sender, EventArgs e)
        {
            mdlGeneral.GetConnectionString();
            rdAllSaler.Checked = true;
            rdWDetail.Checked = true;
            string FillCombo = "SELECT * FROM SUPPLIERS ORDER BY SUPL_CODE";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, FillCombo, mdlGeneral.Connection);
            var Reader = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                    cmbCustName.Items.Add(Reader["SUPL_CODE"].ToString() + "-" + Reader["SUPL_NAME"].ToString());
            }
        }

        private void rdSelSaler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rdSelSaler.Checked == true)
                {
                    cmbCustName.Enabled = true;
                }
                else
                {
                    cmbCustName.Enabled = false;
                }
            }
        }

        private void rdSelSaler_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdSelSaler.Checked == true)
            {
                cmbCustName.Enabled = true;
            }
            else
            {
                cmbCustName.Enabled = false;
            }
        }

        private void rdAllSaler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rdAllSaler.Checked == true)
                {
                    cmbCustName.Enabled = false;
                }
                else
                {
                    cmbCustName.Enabled = true;
                }
            }
        }

        private void rdAllSaler_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdAllSaler.Checked == true)
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