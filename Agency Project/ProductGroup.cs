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
using System.Globalization;

namespace WholeSaleApplication
{
    public partial class ProductGroup : Form
    {
        String DataQuery, GrpName;
        Boolean Addition, Editing;
        SqlDataAdapter LoadAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        Int32 MaxID = 0, EditValue = 0, DeleteID = 0;

        private void BindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Editing = true;
            Addition = false;
            TxtProdGrpName.ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtProdGrpName.Focus();
            TxtProdGrpName.SelectAll();
            BindingNavigatorCloseItem.Text = "&Cancel";
            EditValue = Convert.ToInt32(DgvDisplayGrp.Rows[DgvDisplayGrp.CurrentRow.Index].Cells[0].Value.ToString());
            DgvDisplayGrp.Enabled = false;
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                MaxID = GlobalVariableClass.GenerateSeqID("prodgroupid", "productgroup");
                TxtProdGrpName.Text = myTextInfo.ToTitleCase(TxtProdGrpName.Text);
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("ProdGroupName", "ProductGroup", TxtProdGrpName.Text) == true)
                    {
                        MessageBox.Show("Product Group Name already in the list.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTable();
                        return;
                    }
                    else
                    {
                        DataQuery = @"insert into productgroup values (@ProdGrpId,@ProdGroupName,@ProdGroupNmUrdu)";
                    }

                }
                if (Editing == true)
                {
                    DataQuery = @"update productgroup set ProdGroupName = @ProdGroupName, ProdGroupNmUr = @ProdGroupNmUrdu where prodgroupid = @ProdGrpID";
                }
                SqlConnection SaveDataConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand SaveDataCmd = new SqlCommand(DataQuery, SaveDataConn);
                SaveDataCmd.CommandType = CommandType.Text;
                SaveDataCmd.Parameters.AddWithValue("@ProdGrpId", MaxID);
                SaveDataCmd.Parameters.AddWithValue("@ProdGroupName", myTextInfo.ToTitleCase(TxtProdGrpName.Text));
                SaveDataCmd.Parameters.AddWithValue("@ProdGroupNmUrdu", TxtUrdu.Text);
                if (Editing == true)
                {
                    SaveDataCmd.Parameters.AddWithValue("@ProdGrpID", EditValue);
                }
                SaveDataConn.Open();
                SaveDataCmd.ExecuteNonQuery();
                SaveDataConn.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            ResetTable();
            TxtProdGrpName.ReadOnly = true;
            TxtUrdu.ReadOnly = true;
            BindingNavigatorCloseItem.Text = "&Close";
            BindingNavigatorSaveItem.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Addition = true;
            Editing = false;
            ClearTextBoxes();
            TxtProdGrpName.ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtProdGrpName.Focus();
            BindingNavigatorSaveItem.Enabled = true;
            BindingNavigatorCloseItem.Text = "&Cancel";
        }

        private void ToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteID = Convert.ToInt32(DgvDisplayGrp.Rows[DgvDisplayGrp.CurrentRow.Index].Cells[0].Value.ToString());
            GrpName = DgvDisplayGrp.Rows[DgvDisplayGrp.CurrentRow.Index].Cells[1].Value.ToString();

            DialogResult response = MessageBox.Show("Delete ID (" + DeleteID + " - " + GrpName + ") from the List ? (Yes/No)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                try
                {
                    SqlConnection DelConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                    SqlCommand DelCmd = new SqlCommand("delete from productgroup where prodgroupid = " + DeleteID, DelConn);
                    DelCmd.CommandType = CommandType.Text;
                    DelConn.Open();
                    DelCmd.ExecuteNonQuery();
                    DelConn.Close();
                }
                catch (Exception DelErr)
                {
                    MessageBox.Show(DelErr.Message);
                }
            }
            ResetTable();
        }

        private void TxtProdGrpName_TextChanged(object sender, EventArgs e)
        {
            BindingNavigatorSaveItem.Enabled = true;
        }

        private void TxtUrdu_TextChanged(object sender, EventArgs e)
        {
            BindingNavigatorSaveItem.Enabled = true;
        }

        private void BindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            if (BindingNavigatorCloseItem.Text == "&Cancel")
            {
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
                Addition = false;
                Editing = false;
                ResetTable();
            }
            else
            {
                this.Close();
            }
        }

        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
        public ProductGroup()
        {
            InitializeComponent();
        }

        private void ProductGroup_Load(object sender, EventArgs e)
        {
            this.components.Add(ProdGrpbindingNavigator);
            this.components.Add(ProdGrpbindingSource);
            SqlConnection Sqlconn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from  ProductGroup order by prodgroupid", Sqlconn);
            LoadAdapter.SelectCommand = cmd;
            Sqlconn.Open();
            LoadAdapter.Fill(dt);
            ProdGrpbindingSource.DataSource = dt;
            Sqlconn.Close();
            TxtProdGrpName.DataBindings.Add("TEXT", ProdGrpbindingSource, "ProdGroupName");
            TxtUrdu.DataBindings.Add("TEXT", ProdGrpbindingSource, "ProdGroupNmUr");
            Addition = false;
            Editing = false;
        }
        private void ClearTextBoxes()
        {
            TxtProdGrpName.Clear();
            TxtUrdu.Clear();
        }
        private void ResetTable()
        {
            try
            {
                dt.Clear();
                LoadAdapter.Dispose();
                SqlConnection RstConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand RstCmd = new SqlCommand("Select * from ProductGroup order by prodgroupid", RstConn);
                DataTable RstTbl = new DataTable();
                LoadAdapter.SelectCommand = RstCmd;
                RstConn.Open();
                LoadAdapter.Fill(RstTbl);
                ProdGrpbindingSource.DataSource = RstTbl;
                DgvDisplayGrp.RefreshEdit();
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
                Addition = false;
                Editing = false;
                DgvDisplayGrp.Enabled = true;
                TxtProdGrpName.ReadOnly = true;
                TxtUrdu.ReadOnly = true;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
