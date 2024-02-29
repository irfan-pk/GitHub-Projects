using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace WholeSaleApplication
{
    public partial class FieldViewerForm : Form
    {
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
        public FieldViewerForm()
        {
            InitializeComponent();
        }

        private void FieldViewerForm_Load(object sender, EventArgs e)
        {
            this.Text = "List of " + myTextInfo.ToUpper(GlobalVariableClass.v_gblViewTableName);
            try
            {
                SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                conn.Open();
                String cmd = "select * from " + GlobalVariableClass.v_gblViewTableName + " order by " + GlobalVariableClass.ViewFieldName;
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbViewData.DataSource = dt;
                cbViewData.DisplayMember = GlobalVariableClass.v_gblViewFieldName;
            }
            catch (SqlException Err)
            {
                MessageBox.Show(Err.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FieldViewerForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape )
            {
                this.Close();
            }
        }

        private void FieldViewerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GlobalVariableClass.v_gblSearchString = cbViewData.Text.ToString();
                this.Close();
            }
        }

        private void cbViewData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GlobalVariableClass.v_gblSearchString = cbViewData.Text.ToString();
        }
    }
}
