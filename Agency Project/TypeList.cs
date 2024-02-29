using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WholeSaleApplication
{
    public partial class TypeList : Form
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
                MaxID = GlobalVariableClass.GenerateSeqID("type_id", "types");
                TxtTypeDesc.Text = myTextInfo.ToTitleCase(TxtTypeDesc.Text);
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("type_desc","types",TxtTypeDesc.Text) == true)
                    {
                        MessageBox.Show("Type Description already in the list.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTable();
                        return;
                    }
                    else
                    {
                        DataQuery = "insert into types values (@TypeId,@TypeName,@TypeNmUrdu)";
                    }
                }
                if (Editing == true)
                {
                    DataQuery = "update types set TYPE_DESC = @TypeName, TYPE_DESC_U = @TypeNmUrdu where type_id = @UpdateID";
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

        private void ResetTable()
        {
            try
            {
                dt.Clear();
                LoadAdapter.Dispose();
                SqlConnection RstConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand RstCmd = new SqlCommand("Select * from types order by type_id", RstConn);
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

        public static bool CheckGroupExist(String TypeName)
        {
            SqlConnection ChkConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand ChkCmd = new SqlCommand("select * from types where type_desc = @TypeName", ChkConn);
            ChkConn.Open();
            ChkCmd.CommandType = CommandType.Text;
            ChkCmd.Parameters.AddWithValue("@TypeName", TypeName);
            SqlDataReader reader = ChkCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                    SqlCommand DelCmd = new SqlCommand("delete from types where type_id = " + DeleteID, DelConn);
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

        private void TxtTypeDesc_TextChanged(object sender, EventArgs e)
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
        public TypeList()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            TxtTypeDesc .Clear();
            TxtUrdu.Clear();
        }

        private int GenerateMaxID(string field, string tableName)
        {
            Int32 MaxID = 0;
            SqlConnection ID_Conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand MaxQuery = new SqlCommand("Select max(" + field + ") from " + tableName, ID_Conn);
            ID_Conn.Open();
            MaxQuery.CommandType = CommandType.Text;
            SqlDataReader reader = MaxQuery.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        MaxID = Convert.ToInt32(reader[0].ToString()) + 1;
                    }
                    else
                    {
                        MaxID = 1;
                    }
                }
            }
            ID_Conn.Close();
            return MaxID;
        }
        private void TypeList_Load(object sender, EventArgs e)
        {
            this.components.Add(TypeBindingNavigator);
            this.components.Add(TypeBindingSource);
            SqlConnection Sqlconn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from  types order by type_id", Sqlconn);
            LoadAdapter.SelectCommand = cmd;
            Sqlconn.Open();
            LoadAdapter.Fill(dt);
            TypeBindingSource.DataSource = dt;
            Sqlconn.Close();
            TxtTypeDesc.DataBindings.Add("TEXT", TypeBindingSource , "TYPE_DESC");
            TxtUrdu.DataBindings.Add("TEXT", TypeBindingSource , "TYPE_DESC_U");
            Addition = false;
            Editing = false;
        }
    }
}
