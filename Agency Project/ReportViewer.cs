using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class ReportViewer : Form
    {
        TableLogOnInfo ConnInfo = new TableLogOnInfo();
        ReportDocument RptDocument = new ReportDocument();
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            SqlConnection RptConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            // Add server logon information
            crystalReportViewer.ReportSource = null;
            ConnInfo.ConnectionInfo.UserID = "sa";
            ConnInfo.ConnectionInfo.Password = "ishanw";
            ConnInfo.ConnectionInfo.ServerName = "localhost";
            ConnInfo.ConnectionInfo.DatabaseName = "POS_ERP";
            crystalReportViewer.ReportSource = RptDocument;
            RptDocument.Load(GlobalVariableClass.gblReportName);

            // Add database logon information
            for (int i = 0; i <= RptDocument.Database.Tables.Count - 1; i++)
            {
                RptDocument.Database.Tables[i].ApplyLogOnInfo(ConnInfo);
            }
        }
    }
}
