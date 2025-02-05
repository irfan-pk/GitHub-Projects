using System;
using System.Net;
using System.Windows.Forms;

namespace POS_System
{

    public partial class Server
    {
        public Server()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {

            mdlGeneral.ServerName = Dns.GetHostName();
            mdlGeneral.ServerID = "sa";
            mdlGeneral.ServerDatabase = "POSR";
            txtSrvrName.Text = mdlGeneral.ServerName.ToString().ToUpper();
            txtSrvrUser.Text = mdlGeneral.ServerID.ToString().ToLower();
            TopMost = true;

        }

        private void txtSrvrPwd_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                mdlGeneral.ServerPwd = txtSrvrPwd.Text.Trim().ToLower();
                mdlGeneral.ServerName = txtSrvrName.Text.ToUpper().Trim();
                mdlGeneral.GetServerFileSettings("WRITE");
                mdlGeneral.SaveServerSettings = true;
                Close();
            }
        }

    }
}