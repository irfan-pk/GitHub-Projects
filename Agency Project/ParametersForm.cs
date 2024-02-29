using System;
using System.Windows.Forms;

namespace WholeSaleApplication
{
    public partial class ParametersForm : Form
    {
        public ParametersForm()
        {
            InitializeComponent();
        }

        private void ParametersForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = System.Net.Dns.GetHostName().ToUpper();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            GlobalVariableClass.gblHostName = tbHost.Text.ToUpper().Trim();
            GlobalVariableClass.gblDatabaseName = tbDatabase.Text.ToUpper().Trim();
            GlobalVariableClass.gblUserName = tbUser.Text.ToLower().Trim();
            GlobalVariableClass.gblPassword = tbPassword.Text.Trim();
            try
            {
                DatabaseParameters.ReadWriteDatabaseParameters("FW");
            }
            catch
            {
                MessageBox.Show(this, "File write error, contact developer.", "Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
