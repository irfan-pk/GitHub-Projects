using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace WholeSaleApplication
{
    public partial class NewAccount : Form
    { 
        String ConnString = string.Empty;
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
        GlobalVariableClass MyClass = new GlobalVariableClass();
        int MaxID = 0;
        int PreviousAccID = 0;
        int CityCode = 0;
        int GroupID = 0; 
        int AreaID=0;
        Boolean Addition=false, Editing = false;
        String DataQuery = string.Empty;
        private readonly AccountBook Obj = (AccountBook)Application.OpenForms["AccountBook"];

        public NewAccount()
        {
            InitializeComponent();
        }
        private void BtnAddGrp_Click(object sender, EventArgs e)
        {
            if (TxtGroup.ReadOnly == false)
            {
                GrpListForm childForm = new GrpListForm();
                childForm.MdiParent = this.MdiParent;
                childForm.Show();
            }
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            GlobalVariableClass.FillComboxBox(this.CmbType, "type_desc", "types");
            if (GlobalVariableClass.v_gblRecMode == true)
            {
                lblAccountID.Text = 0.ToString();
                BtnEdit.Enabled = false;
            }
            if (GlobalVariableClass .v_gblRecMode == false)
            {
                BtnCreate.Enabled = false;
                GetAccountData();
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            BtnUpdate.Enabled = true;
            SetTextBoxesReadOnly(false);
            ClearAllTextBoxes();
            Addition = true;
            Editing = false;
            GlobalVariableClass.v_gblAccID = Convert.ToInt32(lblAccountID.Text.ToString());
            PreviousAccID = Convert.ToInt32(lblAccountID.Text.ToString());
            TxtOpnBalance.Text = 0.ToString();
            TxtCrLimit.Text = 0.ToString();
            TxtBilLimit.Text = 0.ToString();
            TxtCrDaysSale.Text = 0.ToString();
            TxtCrDaysPrch.Text = 0.ToString();
            BtnBack.Text = "&Refresh";
        }

        private void SetTextBoxesReadOnly(bool ctrlState)
        {
            foreach (Control ctrl in this.Controls)
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
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }
            MaxID  = GlobalVariableClass.GenerateSeqID("account_id", "accounts");
            if (MaxID == 1)
            {
                lblAccountID.Text = "1001";
            }
            else
            {
                lblAccountID.Text = MaxID.ToString();
            }
            TxtCNIC.Clear();
            TxtAccName.Focus();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (BtnBack .Text == "&Back")
            {
                GlobalVariableClass.v_gblRecMode = false;
                this.Close();
            }

            if (BtnBack.Text == "&Refresh")
            {
                SetTextBoxesReadOnly(true);
                GetAccountData();
                BtnBack.Text = "&Back";
                GlobalVariableClass.v_gblRecMode = false;
                BtnUpdate.Enabled = false;
                return;
            }
        }

        private void GetAccountData()
        {
                SqlConnection NewConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand NewCmd = new SqlCommand("select * from accounts where account_id = " + Convert.ToInt32 (lblAccountID.Text.ToString()), NewConn);
                NewCmd.CommandType = CommandType.Text;
                NewConn.Open();
                SqlDataReader GetInfoReader = NewCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (GetInfoReader.HasRows)
                {
                    while (GetInfoReader.Read())
                    {
                        lblAccountID.Text = GetInfoReader["account_id"].ToString();
                        TxtAccName.Text = GetInfoReader["account_name"].ToString();
                        TxtAccNameUrdu.Text = GetInfoReader["account_name_u"].ToString();
                        TxtPrintName.Text = GetInfoReader["print_name"].ToString();
                        TxtGroup.Text = GetInfoReader["accountgroup"].ToString();
                        CbAccHead.Text = GetInfoReader["accounthead"].ToString();
                        TxtAccType.Text = GetInfoReader["acctype"].ToString();
                        TxtOpnBalance.Text = GetInfoReader["opn_bal"].ToString();
                        CmbDrCr.Text = GetInfoReader["dr_cr"].ToString();
                        TxtAddr1Eng.Text = GetInfoReader["address1"].ToString();
                        TxtAddr2Eng.Text = GetInfoReader["address2"].ToString();
                        TxtAddr1Urdu.Text = GetInfoReader["addressur1"].ToString();
                        TxtAddr2Urdu.Text = GetInfoReader["addressur2"].ToString();
                        CityCode = GetInfoReader.GetInt32(14);
                        TxtCityName.Text = GetInfoReader["city_name"].ToString();
                        TxtCityUrdu.Text = GetInfoReader["city_urdu"].ToString();
                        AreaID = GetInfoReader.GetInt32(17);
                        TxtAreaName.Text = GetInfoReader["area_name"].ToString();
                        TxtAreaUrdu.Text = GetInfoReader["area_urdu"].ToString();
                        TxtPhone.Text = GetInfoReader["landline"].ToString();
                        TxtMobile.Text = GetInfoReader["mobile"].ToString();
                        TxtEmail.Text = GetInfoReader["email"].ToString();
                        TxtContactPerson.Text = GetInfoReader["contact_person"].ToString();
                        TxtBnkName.Text = GetInfoReader["bank_name"].ToString();
                        TxtBankAcc.Text = GetInfoReader["bank_acc_no"].ToString();
                        TxtCrLimit.Text = GetInfoReader["credit_limit"].ToString();
                        TxtBilLimit.Text = GetInfoReader["bill_limit"].ToString();
                        TxtGstNo.Text = GetInfoReader["gst_no"].ToString();
                        TxtNTNNo.Text = GetInfoReader["ntn_no"].ToString();
                        TxtCNIC.Text = GetInfoReader["cnic"].ToString();
                        CmbType.Text = GetInfoReader["party_type"].ToString();
                        TxtCrDaysSale.Text = GetInfoReader["cr_days_sale"].ToString();
                        TxtCrDaysPrch.Text = GetInfoReader["cr_days_purch"].ToString();
                    }
                }
                NewConn.Close();
                GetInfoReader.Close();
            return;
        }

        private void TxtOpnBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtAccName_Leave(object sender, EventArgs e)
        {
            TxtAccName.Text = myTextInfo.ToTitleCase(TxtAccName.Text);
        }

        private void TxtPrintName_Leave(object sender, EventArgs e)
        {
            TxtPrintName.Text = myTextInfo.ToTitleCase(TxtPrintName.Text);
        }

        private void TxtAddr1Eng_Leave(object sender, EventArgs e)
        {
            TxtAddr1Eng.Text = myTextInfo.ToTitleCase(TxtAddr1Eng.Text);
        }

        private void TxtAddr2Eng_Leave(object sender, EventArgs e)
        {
            TxtAddr2Eng.Text = myTextInfo.ToTitleCase(TxtAddr2Eng.Text);
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == ',' || char.IsNumber(e.KeyChar))
            {

                // These characters may pass
                e.Handled = false;
            }
            else
            {
                // Everything that is not a letter, nor a backspace nor a space will be blocked
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && (TxtMobile.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtPrintName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && !char.IsWhiteSpace (e.KeyChar))
            {
                e.Handled = true;
            }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtBankAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCrLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtBilLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtCrDaysSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCrDaysPrch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnViewGroup_Click(object sender, EventArgs e)
        {
            if (TxtGroup.ReadOnly == false)
            {
                GlobalVariableClass.v_gblViewFieldName = "group_name";
                GlobalVariableClass.v_gblViewTableName = "groups";
                GlobalVariableClass.v_gblViewValueMember = "group_id";
                FieldViewerForm childForm = new FieldViewerForm();
                childForm.ShowDialog();
                if (GlobalVariableClass.v_gblSearchString != string.Empty)
                {
                    this.TxtGroup.Text = GlobalVariableClass.v_gblSearchString;
                    this.TxtAccType.Focus();
                }
            }
        }

        private void TxtGroup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtnViewGroup_Click(sender, e);
            }
        }

        private void BtnViewArea_Click(object sender, EventArgs e)
        {
            if (TxtAreaName.ReadOnly == false)
            {
                // use global variables
                GlobalVariableClass.v_gblViewFieldName = "area_name";
                GlobalVariableClass.v_gblViewTableName = "area";
                GlobalVariableClass.v_gblViewValueMember = "area_id";
                FieldViewerForm childForm = new FieldViewerForm();
                childForm.ShowDialog();
                if (GlobalVariableClass.v_gblSearchString != string.Empty)
                {
                    // set area name from combo box selection from dialogue form
                    this.TxtAreaName.Text = GlobalVariableClass.v_gblSearchString;
                    SqlConnection AreaConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                    SqlCommand AreaCmd = new SqlCommand("select * from area where area_name = '" + TxtAreaName.Text.ToString() + "'", AreaConn);
                    AreaCmd.CommandType = CommandType.Text;
                    AreaConn.Open();
                    SqlDataReader AreaReader = AreaCmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (AreaReader .HasRows )
                    {
                        // To get Area Info with city code
                        while (AreaReader.Read())
                        {
                            AreaID = Convert.ToInt32(AreaReader[0].ToString());
                            TxtAreaName.Text = AreaReader[1].ToString();
                            TxtAreaUrdu.Text = AreaReader[2].ToString();
                            CityCode = Convert.ToInt32(AreaReader[3].ToString());
                        }
                        AreaReader.Close();
                        // To get City Info
                        SqlConnection CityConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                        SqlCommand CityCmd = new SqlCommand("select * from city where city_id = " + CityCode, CityConn);
                        CityCmd.CommandType = CommandType.Text;
                        CityConn.Open();
                        SqlDataReader CityReader = CityCmd.ExecuteReader(CommandBehavior.CloseConnection);
                        if (CityReader.HasRows )
                        {
                            while(CityReader .Read ())
                            {
                                TxtPostalCode.Text = CityReader[1].ToString();
                                TxtCityName.Text = CityReader[2].ToString();
                                TxtCityUrdu.Text = CityReader[3].ToString();
                            }
                            CityReader.Close();
                        }
                        CityConn.Close();
                        AreaConn.Close();
                        this.TxtPhone.Focus();
                    }
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
             try
            {
                // Add textboxes values into database
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("account_id", "accounts", lblAccountID.Text.ToString()) == false)
                    {
                        DataQuery = "insert into accounts values (" +
                                    "@AccID,   @AccName,  @AccNmUr, @PrintNm, @AccountGrp, @AccGrpUr, @AccountHead, @AccType, @OpnBal," +
                                    "@DrCr,    @Addr1E,   @Addr2E,  @Addr1Ur, @Addr2Ur,    @CityID,   @CityNm,      @CityNmU," +
                                    "@AreaID,  @AreaNm,   @AreaNmU, @Phone,   @Mobile,     @Email,    @CPerson,     @BankNm,  @BankAcc," +
                                    "@CrLimit, @BilLimit, @GST,     @NTN,     @CNIC,       @PType,    @PTypeUr,     @CrDSale, @CrDPurch, @AccHolder)";
                    }
                }
                // Edit textboxes values and update into database
                if (Editing == true)
                {
                    DataQuery = "update accounts set " +
                                    "account_name = @AccName, account_name_u = @AccNmUr, print_name = @PrintNm, AccountGroup = @AccountGrp, AccountGroupUr = @AccGrpUr, AccountHead = @AccountHead, acctype = @AccType, opn_bal = @OpnBal," +
                                    "dr_cr = @DrCr, address1 = @Addr1E, address2 = @Addr2E, addressur1 = @Addr1Ur, addressur2 = @Addr2Ur, city_ID = @CityID, city_name = @CityNm, city_urdu = @CityNmU," +
                                    "area_id = @AreaID, area_name = @AreaNm, area_urdu = @AreaNmU, landline = @Phone, mobile = @Mobile, email = @Email, contact_person = @CPerson, bank_name = @BankNm, bank_acc_no = @BankAcc," +
                                    "credit_limit = @CrLimit, bill_limit = @BilLimit, gst_no = @GST, ntn_no = @NTN, cnic = @CNIC, party_type = @PType, party_type_ur = @PTypeUr, cr_days_sale = @CrDSale, cr_days_purch = @CrDPurch " +
                                    "where account_id = @UpdateID";
                }
                // Create Sql Parameters to Execute Query
                SqlConnection AccConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand AccCmd = new SqlCommand(DataQuery, AccConn);
            String PartyTypeUr = String.Empty;
            String AccGrpUr = GlobalVariableClass.GetFieldInfo("Group_Name", "Group_Name_U", "Groups", TxtGroup.Text);
            if (CmbType .Text == String.Empty )
            {
                PartyTypeUr = String.Empty;
            }
            else
            {
                PartyTypeUr = GlobalVariableClass.GetFieldInfo("Type_Desc", "Type_Desc_U", "Types", CmbType.Text);
            }
                AccCmd.CommandType = CommandType.Text;
                AccCmd.Parameters.Add(new SqlParameter("@AccID", Convert.ToInt32(lblAccountID.Text.ToString())));
                AccCmd.Parameters.Add(new SqlParameter("@AccName", TxtAccName.Text));
                AccCmd.Parameters.Add(new SqlParameter("@AccNmUr", TxtAccNameUrdu.Text));
                AccCmd.Parameters.Add(new SqlParameter("@PrintNm", TxtPrintName.Text));
                AccCmd.Parameters.Add(new SqlParameter("@AccountGrp", TxtGroup.Text));
                AccCmd.Parameters.Add(new SqlParameter("@AccGrpUr", AccGrpUr));
                AccCmd.Parameters.Add(new SqlParameter("@AccountHead", CbAccHead.Text));
                AccCmd.Parameters.Add(new SqlParameter("@AccType", TxtAccType.Text));
                AccCmd.Parameters.Add(new SqlParameter("@OpnBal", Convert.ToDecimal(TxtOpnBalance.Text.ToString())));
                AccCmd.Parameters.Add(new SqlParameter("@DrCr", CmbDrCr.Text));
                AccCmd.Parameters.Add(new SqlParameter("@Addr1E", TxtAddr1Eng.Text));
                AccCmd.Parameters.Add(new SqlParameter("@Addr2E", TxtAddr2Eng.Text));
                AccCmd.Parameters.Add(new SqlParameter("@Addr1Ur", TxtAddr1Urdu.Text));
                AccCmd.Parameters.Add(new SqlParameter("@Addr2Ur", TxtAddr2Urdu.Text));
                AccCmd.Parameters.Add(new SqlParameter("@CityID", CityCode));
                AccCmd.Parameters.Add(new SqlParameter("@CityNm", TxtCityName.Text));
                AccCmd.Parameters.Add(new SqlParameter("@CityNmU", TxtCityUrdu.Text));
                AccCmd.Parameters.Add(new SqlParameter("@AreaID", AreaID));
                AccCmd.Parameters.Add(new SqlParameter("@AreaNm", TxtAreaName.Text));
                AccCmd.Parameters.Add(new SqlParameter("@AreaNmU", TxtAreaUrdu.Text));
                AccCmd.Parameters.Add(new SqlParameter("@Phone", TxtPhone.Text));
                AccCmd.Parameters.Add(new SqlParameter("@Mobile", TxtMobile.Text));
                AccCmd.Parameters.Add(new SqlParameter("@Email", TxtEmail.Text));
                AccCmd.Parameters.Add(new SqlParameter("@CPerson", TxtContactPerson.Text));
                AccCmd.Parameters.Add(new SqlParameter("@BankNm", TxtBnkName.Text));
                AccCmd.Parameters.Add(new SqlParameter("@BankAcc", TxtBankAcc.Text));
                AccCmd.Parameters.Add(new SqlParameter("@CrLimit", Convert.ToDecimal(TxtCrLimit.Text.ToString())));
                AccCmd.Parameters.Add(new SqlParameter("@BilLimit", Convert.ToDecimal(TxtBilLimit.Text.ToString())));
                AccCmd.Parameters.Add(new SqlParameter("@GST", TxtGstNo.Text));
                AccCmd.Parameters.Add(new SqlParameter("@NTN", TxtNTNNo.Text));
                AccCmd.Parameters.Add(new SqlParameter("@CNIC", TxtCNIC.Text));
                AccCmd.Parameters.Add(new SqlParameter("@PType", CmbType.Text));
                AccCmd.Parameters.Add(new SqlParameter("@PTypeUr", PartyTypeUr));
                AccCmd.Parameters.Add(new SqlParameter("@CrDSale", Convert.ToInt32(TxtCrDaysSale.Text.ToString())));
                AccCmd.Parameters.Add(new SqlParameter("@CrDPurch", Convert.ToInt32(TxtCrDaysPrch.Text.ToString())));
                AccCmd.Parameters.Add(new SqlParameter("@AccHolder", "LOCAL"));
                if (Editing == true)
                {
                    AccCmd.Parameters.Add(new SqlParameter("@UpdateID", Convert.ToInt32(lblAccountID.Text.ToString())));
                }
                //AccCmd.Parameters.Add(new SqlParameter("@result", SqlDbType.Int)).Direction = System.Data.ParameterDirection.Output;
                AccConn.Open();
                int i = Convert.ToInt32 (AccCmd.ExecuteNonQuery());
                    //i = Convert.ToInt16(AccCmd.Parameters["@result"].Value);
                if (i > 0)
                    {
                        MessageBox.Show("Record saved Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                AccConn.Close();
                // update datagrid on main
                Obj.GetAddressBook();
                SetTextBoxesReadOnly(true);
                BtnBack_Click(sender, e);
                BtnUpdate.Enabled = false;
                return;
            }
            catch (Exception ExErr)
            {
                MessageBox.Show(ExErr.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnAddArea_Click(object sender, EventArgs e)
        {
            if (TxtAreaName.ReadOnly == false)
            {
                AreaLists childForm = new AreaLists();
                childForm.Show();
                childForm.MdiParent = this.MdiParent;
            }
        }

        private void TxtAccType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtnAccType_Click(sender, e);
            }
        }

        private void BtnAccType_Click(object sender, EventArgs e)
        {
            if (TxtAccType.ReadOnly == false)
            {
                GlobalVariableClass.v_gblViewFieldName = "acctype_name";
                GlobalVariableClass.v_gblViewTableName = "AccountGroups";
                GlobalVariableClass.v_gblViewValueMember = "acctye_id";
                FieldViewerForm  childForm = new FieldViewerForm();
                childForm.ShowDialog();
                if (GlobalVariableClass.v_gblSearchString != string.Empty)
                {
                    this.TxtAccType.Text = GlobalVariableClass.v_gblSearchString;
                    this.TxtOpnBalance.Focus();
                }
            }
        }

        private void TxtAreaName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtnViewArea_Click(sender, e);
            }
        }

        private void TxtContactPerson_Leave(object sender, EventArgs e)
        {
            TxtContactPerson.Text = myTextInfo.ToTitleCase(TxtContactPerson.Text);
        }

        private void TxtBnkName_Leave(object sender, EventArgs e)
        {
            TxtBnkName.Text = myTextInfo.ToTitleCase(TxtBnkName.Text);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnUpdate.Enabled = true;
            SetTextBoxesReadOnly(false);
            Addition = false;
            Editing = true;
            TxtAccName.Focus();
            BtnBack.Text = "&Refresh"; 
            GlobalVariableClass.v_gblAccID = Convert.ToInt32(lblAccountID.Text.ToString());
            PreviousAccID = Convert.ToInt32(lblAccountID.Text.ToString());
        }
    }
}
