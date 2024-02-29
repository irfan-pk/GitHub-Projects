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
    public partial class AccountTypes : Form
    {
        String DataQuery, TypeDesc;
        Boolean Addition, Editing;
        SqlDataAdapter LoadAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        Int32 MaxID = 0, EditValue = 0, DeleteID = 0;
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;

        private void BindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Editing = true;
            Addition = false;
            TxtTypeDesc.ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtTypeDesc.Focus();
            TxtTypeDesc.SelectAll();
            BindingNavigatorCloseItem.Text = "&Cancel";
            EditValue = Convert.ToInt32(DgvDisplayGrp.Rows[DgvDisplayGrp.CurrentRow.Index].Cells[0].Value.ToString());
            DgvDisplayGrp.Enabled = false;
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                MaxID = GlobalVariableClass.GenerateSeqID("acctype_id", "AccountGroups");
                TxtTypeDesc.Text = myTextInfo.ToTitleCase(TxtTypeDesc.Text);
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("acctype_name", "AccountGroups", TxtTypeDesc.Text) == true)
                    {
                        MessageBox.Show("Type Description already in the list.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTable();
                        return;
                    }
                    else
                    {
                        DataQuery = "insert into AccountGroups values (@TypeId,@TypeName,@TypeNmUrdu)";
                    }
                }
                if (Editing == true)
                {
                    DataQuery = "update AccountGroups set acctype_name = @TypeName, acctype_name_u = @TypeNmUrdu where acctype_id = @UpdateID";
                }
                SqlConnection SaveDataConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand SaveDataCmd = new SqlCommand(DataQuery, SaveDataConn);
                SaveDataCmd.CommandType = CommandType.Text;

                SaveDataCmd.Parameters.AddWithValue("@TypeId", MaxID);
                SaveDataCmd.Parameters.AddWithValue("@TypeName", myTextInfo.ToTitleCase(TxtTypeDesc.Text));
                SaveDataCmd.Parameters.AddWithValue("@TypeNmUrdu", TxtUrdu.Text);
                if (Editing == true)
                {
                    SaveDataCmd.Parameters.AddWithValue("@UpdateID", EditValue);
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
            TxtTypeDesc.ReadOnly = true;
            TxtUrdu.ReadOnly = true;
            BindingNavigatorCloseItem.Text = "&Close";
            BindingNavigatorSaveItem.Enabled = false;
        }

        private void ToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteID = Convert.ToInt32(DgvDisplayGrp.Rows[DgvDisplayGrp.CurrentRow.Index].Cells[0].Value.ToString());
            TypeDesc = DgvDisplayGrp.Rows[DgvDisplayGrp.CurrentRow.Index].Cells[1].Value.ToString();

            DialogResult response = MessageBox.Show("Delete ID (" + DeleteID + " - " + TypeDesc + ") from the List ? (Yes/No)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                try
                {
                    SqlConnection DelConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                    SqlCommand DelCmd = new SqlCommand("delete from AccountGroups where acctype_id = " + DeleteID, DelConn);
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Addition = true;
            Editing = false;
            ClearTextBoxes();
            TxtTypeDesc.ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtTypeDesc.Focus();
            BindingNavigatorSaveItem.Enabled = true;
            BindingNavigatorCloseItem.Text = "&Cancel";
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

        public AccountTypes()
        {
            InitializeComponent();
        }

        private void AccountTypes_Load(object sender, EventArgs e)
        {
            this.components.Add(TypeBindingNavigator);
            this.components.Add(TypeBindingSource);
            SqlConnection Sqlconn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from  AccountGroups order by acctype_id", Sqlconn);
            LoadAdapter.SelectCommand = cmd;
            Sqlconn.Open();
            LoadAdapter.Fill(dt);
            TypeBindingSource.DataSource = dt;
            Sqlconn.Close();
            TxtTypeDesc.DataBindings.Add("TEXT", TypeBindingSource, "AccType_Name");
            TxtUrdu.DataBindings.Add("TEXT", TypeBindingSource, "AccType_Name_U");
            Addition = false;
            Editing = false;
        }
        private void ClearTextBoxes()
        {
            TxtTypeDesc.Clear();
            TxtUrdu.Clear();
        }

        private void ResetTable()
        {
            try
            {
                dt.Clear();
                LoadAdapter.Dispose();
                SqlConnection RstConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand RstCmd = new SqlCommand("Select * from AccountGroups order by acctype_id", RstConn);
                DataTable RstTbl = new DataTable();
                LoadAdapter.SelectCommand = RstCmd;
                RstConn.Open();
                LoadAdapter.Fill(RstTbl);
                TypeBindingSource.DataSource = RstTbl;
                DgvDisplayGrp.RefreshEdit();
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
                Addition = false;
                Editing = false;
                DgvDisplayGrp.Enabled = true;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
