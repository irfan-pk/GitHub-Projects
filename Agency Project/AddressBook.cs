using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class AddressBook : Form
    {
        int DeleteID = 0;
        GlobalVariableClass MyVarClass = new GlobalVariableClass();
        public AddressBook()
        {
            InitializeComponent();
            //Assign Mouse Over and Leave Event Handler
            BtnClose.MouseEnter += MouseEnterEvent;
            BtnClose.MouseLeave += MouseLeaveEvent;
            BtnAreaList.MouseEnter += MouseEnterEvent;
            BtnAreaList.MouseLeave += MouseLeaveEvent;
            BtnCities.MouseEnter += MouseEnterEvent;
            BtnCities.MouseLeave += MouseLeaveEvent;
            BtnNew.MouseEnter += MouseEnterEvent;
            BtnNew.MouseLeave += MouseLeaveEvent;
            BtnSMS.MouseEnter += MouseEnterEvent;
            BtnSMS.MouseLeave += MouseLeaveEvent;
            BtnDeleteRec.MouseEnter += MouseEnterEvent;
            BtnDeleteRec.MouseLeave += MouseLeaveEvent;
            
        }

        private void MouseEnterEvent(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.ForeColor = Color.White;
        }

        private void MouseLeaveEvent (object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.ForeColor = Color.Black;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            GlobalVariableClass.v_gblRecMode = true;
            NewAccount newMdiChild = new NewAccount();
            newMdiChild.MdiParent = this.MdiParent;
            newMdiChild.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            GetAddressBook();
        }

        public void GetAddressBook()
        {
            this.components.Add(AddrBindingource);
            this.components.Add(AddrDataSet);
            SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Accounts order by account_id",conn);
            SqlDataAdapter GridAdpter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            GridAdpter.SelectCommand = cmd;
            conn.Open();
            GridAdpter.Fill(dt);
            AddrBindingource.DataSource = dt;
            conn.Close();
        }

        private void NameFilter_TextChanged(object sender, EventArgs e)
        {
            AddrBindingource.Filter = "Account_Name Like '%" + NameFilter.Text + "%'";
        }

        private void NameFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddrBindingource.Filter = "Account_Name Like '%" + NameFilter.Text + "%'";
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            CityLists ctyList = new CityLists();
            ctyList.MdiParent = this.MdiParent;
            ctyList.Show();
        }

        private void BtnCity_Click(object sender, EventArgs e)
        {
            CityLists ctyList = new CityLists();
            ctyList.MdiParent = this.MdiParent;
            ctyList.Show();
        }

        private void DgvAddBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvAddressBook.RowCount > 0)
            {
                NewAccount NewAccForm = new NewAccount();
                NewAccForm.lblAccountID.Text = this.DgvAddressBook.Rows[DgvAddressBook.CurrentRow.Index].Cells[0].Value.ToString();
                NewAccForm.Show();
                NewAccForm.MdiParent = this.MdiParent;
            }
        }

        private void BtnDeleteRec_Click(object sender, EventArgs e)
        {
            DeleteID = Convert.ToInt32(DgvAddressBook.Rows[DgvAddressBook.CurrentRow.Index].Cells[0].Value.ToString());
            DialogResult response = MessageBox.Show("Are you sure to delete (" + DeleteID + ") from database.","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                try
                {
                    SqlConnection DelConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                    SqlCommand DelCommand = new SqlCommand("delete from accounts where account_id = " + DeleteID, DelConn);
                    DelCommand.CommandType = CommandType.Text;
                    DelConn.Open();
                    DelCommand.ExecuteNonQuery();
                    GetAddressBook();
                    MessageBox.Show("Record deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DelConn.Close();
                }
                catch (Exception QueryErr)
                {
                    MessageBox.Show(QueryErr.ToString(),"Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
            }
            else
            {
                DgvAddressBook.Refresh();
            }
        }

        private void GrpFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddrBindingource.Filter = "group_name like '%" + GrpFilter .Text + "%'";
        }

        private void GrpFilter_TextChanged(object sender, EventArgs e)
        {
            AddrBindingource.Filter = "group_name like '%" + GrpFilter.Text + "%'";
        }

        private void AddrFilter_TextChanged(object sender, EventArgs e)
        {
            AddrBindingource.Filter = "address1 like '%" + AddrFilter.Text + "%'";
        }

        private void AddrFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddrBindingource.Filter = "address1 like '%" + AddrFilter.Text + "%'";
        }

        private void CityFilter_TextChanged(object sender, EventArgs e)
        {
            AddrBindingource.Filter = "city_name like '%" + CityFilter.Text + "%'";
        }

        private void CityFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddrBindingource.Filter = "city_name like '%" + CityFilter.Text + "%'";
        }
    }
}
