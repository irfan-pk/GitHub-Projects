using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WholeSaleApplication

{
    public partial class GrpListForm : Form
    {
        String DataQuery, GrpName;
        Boolean Addition, Editing;
        SqlDataAdapter LoadAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        Int32 MaxID = 0, EditValue = 0, DeleteID = 0;
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
        private bool loadError;

        public GrpListForm()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            TxtGrpName.Clear();
            TxtUrdu.Clear();
        }

        private void GrpListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.components.Add(GrpbindingSource);
                this.components.Add(GrpbindingNavigator);
                SqlConnection Sqlconn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from  groups order by group_id", Sqlconn);
                LoadAdapter.SelectCommand = cmd;
                Sqlconn.Open();
                LoadAdapter.Fill(dt);
                GrpbindingSource.DataSource = dt;
                Sqlconn.Close();
                TxtGrpName.DataBindings.Add("TEXT", GrpbindingSource, "GROUP_NAME");
                TxtUrdu.DataBindings.Add("TEXT", GrpbindingSource, "GROUP_NAME_U");
                Addition = false;
                Editing = false;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadError = true;
            }
            finally
            {
                if (loadError == true)
                {
                    BindingNavigatorCloseItem_Click(sender, e);
                }
            }
        }
        
        private void BindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Editing = true;
            Addition = false;
            TxtGrpName.ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtGrpName.Focus();
            TxtGrpName.SelectAll();
            BindingNavigatorCloseItem.Text = "&Cancel";
            EditValue = Convert.ToInt32(DgvDisplayGrp.Rows[DgvDisplayGrp.CurrentRow.Index].Cells[0].Value.ToString());
            DgvDisplayGrp.Enabled = false;
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

        private void ResetTable()
        {
            try
            {
                dt.Clear();
                LoadAdapter.Dispose();
                SqlConnection RstConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand RstCmd = new SqlCommand("Select * from groups order by group_id", RstConn);
                DataTable RstTbl = new DataTable();
                LoadAdapter.SelectCommand = RstCmd;
                RstConn.Open();
                LoadAdapter.Fill(RstTbl);
                GrpbindingSource.DataSource = RstTbl;
                DgvDisplayGrp.RefreshEdit();
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
                Addition = false;
                Editing = false;
                DgvDisplayGrp.Enabled = true;
                TxtGrpName.ReadOnly = true;
                TxtUrdu.ReadOnly = true;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           try
                {    
                MaxID = GlobalVariableClass.GenerateSeqID("group_id", "groups");
                TxtGrpName.Text = myTextInfo.ToTitleCase(TxtGrpName.Text);
                if (Addition == true)
                    {
                    if (GlobalVariableClass.CheckRowExist("GROUP_NAME", "GROUPS", TxtGrpName.Text) == true)
                    {
                        MessageBox.Show("Group Name already in the list.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTable();
                        return;
                    }
                    else
                    {
                        DataQuery = @"insert into groups values (@GroupId,@GroupName,@GroupNmUrdu)";
                    }
                    
                }
                    if (Editing == true)
                    {
                        DataQuery = @"update groups set GROUP_NAME = @GroupName, GROUP_NAME_U = @GroupNmUrdu where group_id = @UpdateID";
                    }
                SqlConnection SaveDataConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand SaveDataCmd = new SqlCommand(DataQuery, SaveDataConn);
                    SaveDataCmd.CommandType = CommandType.Text;
                    SaveDataCmd.Parameters.AddWithValue("@GroupId", MaxID);
                    SaveDataCmd.Parameters.AddWithValue("@GroupName", myTextInfo.ToTitleCase(TxtGrpName.Text));
                    SaveDataCmd.Parameters.AddWithValue("@GroupNmUrdu", TxtUrdu.Text);
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
                TxtGrpName.ReadOnly = true;
                TxtUrdu.ReadOnly = true;
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
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
                    SqlCommand DelCmd = new SqlCommand("delete from groups where group_id = " + DeleteID, DelConn);
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

        private void TxtGrpName_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        private void TxtUrdu_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Addition = true;
            Editing = false;
            ClearTextBoxes();
            TxtGrpName.ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtGrpName.Focus();
            BindingNavigatorSaveItem.Enabled = true;
            BindingNavigatorCloseItem.Text = "&Cancel";
        }
    }
    class MyTroublesomeClass
    {
        public MyTroublesomeClass()
        {
            throw new ApplicationException();
        }
    }
}
