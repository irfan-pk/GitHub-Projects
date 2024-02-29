using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace WholeSaleApplication
{
    public partial class CityLists : Form
    {
        String DataQuery, CityName;
        Boolean Addition, Editing;
        SqlDataAdapter LoadAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        Int32 MaxID = 0, EditValue = 0, DeleteID = 0;
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;

        private void TxtPostalCd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric
            if (!char.IsDigit (e.KeyChar) && !char.IsControl (e.KeyChar ))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void BindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Editing = true;
            Addition = false;
            TxtCityName .ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtPostalCd.ReadOnly = false;
            TxtCityName.Focus();
            TxtCityName.SelectAll();
            BindingNavigatorCloseItem.Text = "&Cancel";
            EditValue = Convert.ToInt32(DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[0].Value.ToString());
            DgvDisplayCity.Enabled = false;
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
                SqlCommand RstCmd = new SqlCommand("Select * from city order by city_id", RstConn);
                DataTable RstTbl = new DataTable();
                LoadAdapter.SelectCommand = RstCmd;
                RstConn.Open();
                LoadAdapter.Fill(RstTbl);
                CityBindingSource .DataSource = RstTbl;
                DgvDisplayCity.RefreshEdit();
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
                Addition = false;
                Editing = false;
                DgvDisplayCity.Enabled = true;
                TxtCityName.ReadOnly = true;
                TxtPostalCd.ReadOnly = true;
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
                MaxID = GlobalVariableClass.GenerateSeqID("city_id", "city");
                TxtCityName.Text = myTextInfo.ToTitleCase(TxtCityName.Text);
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("city_name", "city", TxtCityName.Text) == true)
                    {
                        MessageBox.Show("City Name already in the list.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTable();
                        return;
                    }
                    else
                    {
                        DataQuery = "insert into city values (@CityId,@CityPCode,@CityName,@CityNmUrdu)";
                    }
                }
                    if (Editing == true)
                    {
                        DataQuery = "update city set CITY_NAME = @CityName, CITY_NAME_U = @CityNmUrdu, CITY_PIN = @CityPCode where city_id = @UpdateID";
                    }
                SqlConnection SaveDataConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand SaveDataCmd = new SqlCommand(DataQuery, SaveDataConn);
                    SaveDataCmd.CommandType = CommandType.Text;
                    SaveDataCmd.Parameters.AddWithValue("@CityId", MaxID);
                    SaveDataCmd.Parameters.AddWithValue("@CityPCode", TxtPostalCd.Text);
                    SaveDataCmd.Parameters.AddWithValue("@CityName", myTextInfo.ToTitleCase(TxtCityName.Text));
                    SaveDataCmd.Parameters.AddWithValue("@CityNmUrdu", TxtUrdu.Text);
                    
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
                TxtCityName.ReadOnly = true;
                TxtUrdu.ReadOnly = true;
                TxtPostalCd.ReadOnly = true;
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
        }
        
        private void TxtCityName_TextChanged(object sender, EventArgs e)
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

        private void TxtUrdu_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        private void ToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteID = Convert.ToInt32(DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[0].Value.ToString());
            CityName = DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[1].Value.ToString();

            DialogResult response = MessageBox.Show("Delete ID (" + DeleteID + " - " + CityName + ") from the List ? (Yes/No)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                try
                {
                    SqlConnection DelConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                    SqlCommand DelCmd = new SqlCommand("delete from city where city_id = " + DeleteID, DelConn);
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

        private void CityLists_Load(object sender, EventArgs e)
        {
            this.components.Add(CityBindingSource);
            this.components.Add(CityBindingNavigator);
            SqlConnection Sqlconn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from  city order by city_id", Sqlconn);
            LoadAdapter.SelectCommand = cmd;
            Sqlconn.Open();
            LoadAdapter.Fill(dt);
            CityBindingSource.DataSource = dt;
            Sqlconn.Close();
            TxtCityName.DataBindings.Add("TEXT", CityBindingSource , "city_name");
            TxtUrdu.DataBindings.Add("TEXT", CityBindingSource , "city_name_u");
            TxtPostalCd.DataBindings.Add("TEXT", CityBindingSource, "city_pin");
            Addition = false;
            Editing = false;
        }
        public CityLists()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Addition = true;
            Editing = false;
            ClearTextBoxes();
            TxtCityName .ReadOnly = false;
            TxtUrdu.ReadOnly = false;
            TxtPostalCd.ReadOnly = false;
            TxtCityName .Focus();
            BindingNavigatorSaveItem.Enabled = true;
            BindingNavigatorCloseItem.Text = "&Cancel";
        }
        private void ClearTextBoxes()
        {
            TxtCityName .Clear();
            TxtUrdu.Clear();
            TxtPostalCd.Clear();
        }
    }
}
