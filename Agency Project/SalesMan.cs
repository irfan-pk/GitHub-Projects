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
    public partial class SalesMan : Form
    {
        String DataQuery, SalesManName;
        Boolean Addition, Editing;
        SqlDataAdapter LoadAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        Int32 MaxID = 0, EditValue = 0, DeleteID = 0, NewMaxID = 0;
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;

        private void BindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Editing = true;
            Addition = false;
            SetTextBoxesReadOnly(false);
            TxtName.Focus();
            TxtName.SelectAll();
            BindingNavigatorCloseItem.Text = "&Cancel";
            EditValue = Convert.ToInt32(DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[0].Value.ToString());
            DgvDisplayCity.Enabled = false;
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                MaxID = GlobalVariableClass.GenerateSeqID("salesmanid", "salesman");
                if (MaxID == 1)
                {
                    NewMaxID = 101;
                }
                else
                {
                    NewMaxID = MaxID;
                }
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("salesmanname", "salesman", TxtName.Text) == true)
                    {
                        MessageBox.Show("Sales Man already in the list.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTable();
                        return;
                    }
                    else
                    {
                        DataQuery = "insert into salesman values (@Id,@Name,@NameUrdu,@Address,@CNIC,@Mobile,@Company)";
                    }
                }
                if (Editing == true)
                {
                    DataQuery = "update salesman set salesmanname = @Name, salesmannameur = @NameUrdu, salesmanaddress = @Address, salesmancnic = @CNIC, salesmanmobile = @Mobile, salesmancompany = @Company where salesmanid = @UpdateID";
                }
                SqlConnection SaveDataConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand SaveDataCmd = new SqlCommand(DataQuery, SaveDataConn);
                SaveDataCmd.CommandType = CommandType.Text;
                SaveDataCmd.Parameters.AddWithValue("@Id", NewMaxID);
                SaveDataCmd.Parameters.AddWithValue("@Name", TxtName.Text);
                SaveDataCmd.Parameters.AddWithValue("@NameUrdu", TxtUrdu.Text);
                SaveDataCmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                SaveDataCmd.Parameters.AddWithValue("@CNIC", TxtCNIC.Text);
                SaveDataCmd.Parameters.AddWithValue("@Mobile", TxtMobile.Text);
                SaveDataCmd.Parameters.AddWithValue("@Company", TxtCompany.Text);

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
            SetTextBoxesReadOnly(true);
            BindingNavigatorCloseItem.Text = "&Close";
            BindingNavigatorSaveItem.Enabled = false;
        }

        private void ToolStripDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteID = Convert.ToInt32(DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[0].Value.ToString());
            SalesManName = DgvDisplayCity.Rows[DgvDisplayCity.CurrentRow.Index].Cells[1].Value.ToString();

            DialogResult response = MessageBox.Show("Delete ID (" + DeleteID + " - " + CompanyName + ") from the List ? (Yes/No)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                try
                {
                    SqlConnection DelConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                    SqlCommand DelCmd = new SqlCommand("delete from salesman where salesmanid = " + DeleteID, DelConn);
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

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            TxtName.Text = myTextInfo.ToTitleCase(TxtName.Text);
        }

        private void TxtUrdu_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        private void TxtCNIC_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        private void TxtMobile_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        private void TxtCompany_TextChanged(object sender, EventArgs e)
        {
            if (Editing == true)
            {
                BindingNavigatorSaveItem.Enabled = true;
            }
        }

        private void TxtAddress_Leave(object sender, EventArgs e)
        {
            TxtAddress.Text = myTextInfo.ToTitleCase(TxtAddress.Text);
        }

        private void TxtCompany_Leave(object sender, EventArgs e)
        {
            TxtCompany.Text = myTextInfo.ToTitleCase(TxtCompany.Text);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Addition = true;
            Editing = false;
            ClearAllTextBoxes();
            SetTextBoxesReadOnly(false);
            TxtName.Focus();
            BindingNavigatorSaveItem.Enabled = true;
            BindingNavigatorCloseItem.Text = "&Cancel";
        }

        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            if (TxtCompany.ReadOnly == false)
            {
                GlobalVariableClass.v_gblViewFieldName = "CompanyName";
                GlobalVariableClass.v_gblViewTableName = "Companies";
                GlobalVariableClass.v_gblViewValueMember = "CompanyID";
                FieldViewerForm childForm = new FieldViewerForm();
                childForm.ShowDialog();
                if (GlobalVariableClass.v_gblSearchString != string.Empty)
                {
                    this.TxtCompany.Text = GlobalVariableClass.v_gblSearchString;
                    GlobalVariableClass.v_gblSearchString = string.Empty;
                }
            }
        }

        public SalesMan()
        {
            InitializeComponent();
        }

        private void SalesMan_Load(object sender, EventArgs e)
        {
            this.components.Add(EmpBindingNavigator);
            this.components.Add(EmpBindingSource);
            SqlConnection Sqlconn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from  SalesMan order by SalesManID", Sqlconn);
            LoadAdapter.SelectCommand = cmd;
            Sqlconn.Open();
            LoadAdapter.Fill(dt);
            EmpBindingSource.DataSource = dt;
            Sqlconn.Close();
            TxtName.DataBindings.Add("TEXT", EmpBindingSource, "salesmanname");
            TxtUrdu.DataBindings.Add("TEXT", EmpBindingSource, "salesmannameur");
            TxtAddress.DataBindings.Add("TEXT", EmpBindingSource, "salesmanaddress");
            TxtCNIC.DataBindings.Add("TEXT", EmpBindingSource, "salesmancnic");
            TxtMobile.DataBindings.Add("TEXT", EmpBindingSource, "salesmanmobile");
            TxtCompany.DataBindings.Add("TEXT", EmpBindingSource, "salesmancompany");
            Addition = false;
            Editing = false;
        }

        private void SetTextBoxesReadOnly(bool ctrlState)
        {
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).ReadOnly = ctrlState;
                }
                if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).ReadOnly = ctrlState;
                }
            }

        }

        private void ClearAllTextBoxes()
        {
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }
            TxtCNIC.Clear();
        }

        private void ResetTable()
        {
            try
            {
                dt.Clear();
                LoadAdapter.Dispose();
                SqlConnection RstConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand RstCmd = new SqlCommand("Select * from salesman order by salesmanid", RstConn);
                DataTable RstTbl = new DataTable();
                LoadAdapter.SelectCommand = RstCmd;
                RstConn.Open();
                LoadAdapter.Fill(RstTbl);
                EmpBindingSource.DataSource = RstTbl;
                DgvDisplayCity.RefreshEdit();
                BindingNavigatorCloseItem.Text = "&Close";
                BindingNavigatorSaveItem.Enabled = false;
                Addition = false;
                Editing = false;
                DgvDisplayCity.Enabled = true;
                SetTextBoxesReadOnly(true);
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
