using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace WholeSaleApplication
{
    public partial class AreaLists : Form
    {
        String DataQuery, AreaName;
        Boolean Addition, Editing;
        SqlDataAdapter LoadAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
        GlobalVariableClass MyProcedureClass = new GlobalVariableClass();

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Addition = true;
            Editing = false;
            ClearTextBoxes();
            TxtAreaName.ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtAreaName.Focus();
            BindingNavigatorSaveItem.Enabled = true;
            BindingNavigatorCloseItem.Text = "&Cancel";
        }

        private void BindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Editing = true;
            Addition = false;
            TxtAreaName.ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtAreaName.Focus();
            TxtAreaName.SelectAll();
            BindingNavigatorCloseItem.Text = "&Cancel";
            EditValue = Convert.ToInt32(DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[0].Value.ToString());
            DgvDisplayCity.Enabled = false;
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
                {
                MaxID = GlobalVariableClass.GenerateSeqID("area_id", "area");
                TxtAreaName.Text = myTextInfo.ToTitleCase(TxtAreaName.Text);
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("Area_Name", "Area", TxtAreaName.Text) == true)
                    {
                        MessageBox.Show("Area Name already in the list.","Message",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                        ResetTable();
                        return;
                    }
                    else
                    {
                        DataQuery = "insert into area values (@AreaId,@AreaName,@AreaNmUrdu,@AreaCode)";
                    }
                }
                if (Editing == true)
                {
                    DataQuery = "update area set AREA_NAME = @AreaName, AREA_NAME_U = @AreaNmUrdu, AREA_CODE = @AreaCode where area_id = @UpdateID";
                }
                SqlConnection SaveDataConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand SaveDataCmd = new SqlCommand(DataQuery, SaveDataConn);
                SaveDataCmd.CommandType = CommandType.Text;
                SaveDataCmd.Parameters.AddWithValue("@AreaId", MaxID);
                SaveDataCmd.Parameters.AddWithValue("@AreaName", myTextInfo.ToTitleCase(TxtAreaName.Text));
                SaveDataCmd.Parameters.AddWithValue("@AreaNmUrdu", TxtUrdu.Text);
                SaveDataCmd.Parameters.AddWithValue("@AreaCode", TxtACode.Text);
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
            TxtAreaName.ReadOnly = true;
            TxtUrdu.ReadOnly = true;
            BindingNavigatorCloseItem.Text = "&Close";
            BindingNavigatorSaveItem.Enabled = false;
        }

        Int32 MaxID = 0, EditValue = 0, DeleteID = 0;

        private void ToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteID = Convert.ToInt32(DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[0].Value.ToString());
            AreaName = DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[1].Value.ToString();

            DialogResult response = MessageBox.Show("Delete ID (" + DeleteID + " - " + AreaName + ") from the List ? (Yes/No)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                try
                {
                    SqlConnection DelConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                    SqlCommand DelCmd = new SqlCommand("delete from area where area_id = " + DeleteID, DelConn);
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

        private void AreaLists_Load(object sender, EventArgs e)
        {
            this.components.Add(CityBindingNavigator);
            this.components.Add(CityBindingSource);
            SqlConnection Sqlconn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from  area order by area_id", Sqlconn);
            LoadAdapter.SelectCommand = cmd;
            Sqlconn.Open();
            LoadAdapter.Fill(dt);
            CityBindingSource .DataSource = dt;
            Sqlconn.Close();
            TxtAreaName.DataBindings.Add("TEXT", CityBindingSource , "AREA_NAME");
            TxtUrdu.DataBindings.Add("TEXT", CityBindingSource , "AREA_NAME_U");
            TxtACode.DataBindings.Add("TEXT", CityBindingSource, "AREA_CODE");
            Addition = false;
            Editing = false;
            GlobalVariableClass.FillComboxBox(CmbCityName, "City_Name", "City");
        }

        private void TxtAreaName_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
                
            }
        }

        private void TxtAreaName_Leave(object sender, EventArgs e)
        {
            TxtAreaName.Text = myTextInfo.ToTitleCase(TxtAreaName.Text);
        }

        private void TxtUrdu_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
                
            }
        }

        private void TxtPostalCd_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        public AreaLists()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            TxtAreaName.Clear();
            TxtUrdu.Clear();
            TxtACode.Clear();
        }
        private void ResetTable()
        {
            try
            {
                dt.Clear();
                LoadAdapter.Dispose();
                SqlConnection RstConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand RstCmd = new SqlCommand("Select * from area order by area_id", RstConn);
                DataTable RstTbl = new DataTable();
                LoadAdapter.SelectCommand = RstCmd;
                RstConn.Open();
                LoadAdapter.Fill(RstTbl);
                CityBindingSource.DataSource = RstTbl;
                DgvDisplayCity.RefreshEdit();
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
                Addition = false;
                Editing = false;
                DgvDisplayCity.Enabled = true;
                TxtAreaName.ReadOnly = true;
                TxtUrdu.ReadOnly = true;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
