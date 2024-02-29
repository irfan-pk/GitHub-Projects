using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            BtnNew.MouseEnter += MouseEnterEvent;
            BtnNew.MouseLeave += MouseLeaveEvent;
            BtnClose.MouseEnter += MouseEnterEvent;
            BtnClose.MouseLeave += MouseLeaveEvent;
            BtnDeleteRec.MouseEnter += MouseEnterEvent;
            BtnDeleteRec.MouseLeave += MouseLeaveEvent;
        }

        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.ForeColor = Color.Black;
        }

        private void MouseEnterEvent(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.ForeColor = Color.White;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            GetProductsList();
        }

        public void GetProductsList()
        {
            this.components.Add(ProductBindingource);
            this.components.Add(ProductDataSet);
            SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("select * from products order by productid", conn);
            SqlDataAdapter GridAdpter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            GridAdpter.SelectCommand = cmd;
            conn.Open();
            GridAdpter.Fill(dt);
            ProductBindingource.DataSource = dt;
            conn.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            GlobalVariableClass.v_gblRecMode = true;
            NewProduct childForm = new NewProduct();
            childForm.MdiParent = this.MdiParent;
            childForm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvpProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvpProductList.RowCount > 0)
            {
                GlobalVariableClass.v_gblRecMode = false;
                NewProduct NewProdForm = new NewProduct();
                NewProdForm.TxtProdCode.Text = this.DgvpProductList.Rows[DgvpProductList.CurrentRow.Index].Cells[0].Value.ToString();
                NewProdForm.Show();
                NewProdForm.MdiParent = this.MdiParent;
                GetProductsList();
            }
        }

        private void BtnDeleteRec_Click(object sender, EventArgs e)
        {
            if (DgvpProductList .Rows.Count > 0)
            {
                DialogResult response = MessageBox.Show("Are you sure to delete product from the list (Yes/No) ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    SqlConnection DelCon = new SqlConnection(GlobalVariableClass.gblConnectionString);
                    SqlCommand DelCmd = new SqlCommand();
                    String StringCmd = "delete from products where prodcode = '" + this.DgvpProductList.Rows[DgvpProductList.CurrentRow.Index].Cells[0].Value.ToString() + "'";
                    DelCmd.CommandType = CommandType.Text;
                    DelCmd.CommandText = StringCmd;
                    DelCmd.Connection = DelCon;
                    DelCon.Open();
                    DelCmd.ExecuteNonQuery();
                    DelCon.Close();
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void NameFilter_TextChanged(object sender, EventArgs e)
        {
            ProductBindingource.Filter = "ProdName like '%" + NameFilter.Text.Trim() + "%'";
        }

        private void NameFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductBindingource.Filter = "ProdName like '%" + NameFilter.Text.Trim() + "%'";
        }

        private void GroupFilter_TextChanged(object sender, EventArgs e)
        {
            ProductBindingource.Filter = "ProdGroup like '%" + GroupFilter.Text.Trim() + "%'";
        }

        private void GroupFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductBindingource.Filter = "ProdGroup like '%" + GroupFilter.Text.Trim() + "%'";
        }

        private void CompanyFilter_TextChanged(object sender, EventArgs e)
        {
            ProductBindingource.Filter = "ProdCompany like %'" + CompanyFilter.Text.Trim() + "%'";
        }

        private void CompanyFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductBindingource.Filter = "ProdCompany like %'" + CompanyFilter.Text.Trim() + "%'";
        }
    }
}
