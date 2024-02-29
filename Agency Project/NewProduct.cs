using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Drawing;

namespace WholeSaleApplication
{
    public partial class NewProduct : Form
    {
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
        GlobalVariableClass MyClass = new GlobalVariableClass();
        String PreviousProdCd = String.Empty;
        String ProductCode = String.Empty;
        Boolean Addition = false, Editing = false;
        String DataQuery = string.Empty, PackSize = String.Empty, PrimaryUnitName = String.Empty, SecUnitName = String.Empty, DefaultUnitName = String.Empty;
        int PrimaryUnitId = 0, SecUnitId = 0, DefaultUnitId = 0, ConvFactor = 0; 
        Products ObjForm = (Products)Application.OpenForms["Products"];

        public NewProduct()
        {
            InitializeComponent();
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            GlobalVariableClass.FillComboxBox(CbPrimaryUnit, "ProdUnit", "ProductUnits");
            GlobalVariableClass.FillComboxBox(CbSecondaryUnit, "ProdUnit", "ProductUnits");

            if (GlobalVariableClass.v_gblRecMode == true)
            {
                BtnEdit.Enabled = false;
                CbSchemeStatus.Text = "False";
                CbPricePer.Enabled = true;
                CbSchemeStatus.Enabled = true;
                lblProdId.Text = Convert.ToString(GlobalVariableClass.GenerateSeqID("ProductId", "Products"));
            }
            if (GlobalVariableClass.v_gblRecMode == false)
            {
                BtnCreate.Enabled = false;
                GetProductData();
                CheckNullValues();
                CheckPriceUnit();
            }
        }

        private void CheckPriceUnit()
        {
            SqlConnection MyCon = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand ChkPriceUnt = new SqlCommand();
            ChkPriceUnt.CommandType = CommandType.Text;
            ChkPriceUnt.CommandText = "Select prodsecondaryid,prodsecondaryunit,produnitid,produnitname from products where prodcode = '" + TxtProdCode.Text.Trim() + "'";
            ChkPriceUnt.Connection = MyCon;
            if (MyCon.State == ConnectionState.Open) { MyCon.Close(); }
            MyCon.Open();
            SqlDataReader dr = ChkPriceUnt.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SecUnitId = dr.GetInt32(0);
                    SecUnitName = dr.GetString(1);
                    DefaultUnitId = dr.GetInt32(2);
                    DefaultUnitName = dr.GetString(3);
                }
            }
            if (SecUnitId == 0 || DefaultUnitId == 0)
            {
                panel3.Height = 76;
                btnExtend.Image = Properties.Resources.ok_24px;
            }
            else
            {
                panel3.Height = 168;
                btnExtend.Image = Properties.Resources.checked_24px;
            }
        }

        private void CheckNullValues()
        {
            foreach (DataGridViewRow row in DgvPriceCalc.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (string.IsNullOrEmpty(cell.Value as string))
                    {
                        cell.Value = 0;
                    }
                    else
                    {
                        //Skip to next
                    }
                }
            }
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

            foreach (Control pCtrl in panel2.Controls)
            {
                if (pCtrl is TextBox)
                {
                    (pCtrl as TextBox).ReadOnly = ctrlState;
                }
            }
            foreach (Control pCtrl in panel3.Controls)
            {
                if (pCtrl is TextBox)
                {
                    (pCtrl as TextBox).ReadOnly = ctrlState;
                }
            }
            foreach (Control pCtrl in panel4.Controls)
            {
                if (pCtrl is TextBox)
                {
                    (pCtrl as TextBox).ReadOnly = ctrlState;
                }
            }
        }

        private void SetTextBoxesClear()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
                if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Clear();
                }
            }

            foreach (Control pCtrl in panel2.Controls)
            {
                if (pCtrl is TextBox)
                {
                    (pCtrl as TextBox).Clear();
                }
            }
            foreach (Control pCtrl in panel3.Controls)
            {
                if (pCtrl is TextBox)
                {
                    (pCtrl as TextBox).Clear();
                }
            }
            foreach (Control pCtrl in panel4.Controls)
            {
                if (pCtrl is TextBox)
                {
                    (pCtrl as TextBox).Clear();
                }
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox;
            if (e.Control is TextBox)
            {
                textBox = e.Control as TextBox;
                textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            }
            DgvPriceCalc.Columns[0].DefaultCellStyle.Format = "N2";
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numeric
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

        private void BtnAddScheme_Click(object sender, EventArgs e)
        {
            if (CbSchemeStatus.Text == "True")
            {
                GlobalVariableClass.v_gblProductCode = TxtProdCode.Text.ToUpper();
                ProductScheme childForm = new ProductScheme();
                childForm.Show();
                childForm.MdiParent = this.MdiParent;
            }
        }

        private void BtnEditScheme_Click(object sender, EventArgs e)
        {
            GlobalVariableClass.gblMode = "EDIT";
            GlobalVariableClass.gblProductCode = TxtProdCode.Text;
            BtnAddScheme_Click(sender, e);
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
                CheckPriceUnit();
                foreach (DataGridViewRow row in this.DgvPriceCalc.Rows)
                {
                    DgvPriceCalc.Rows.RemoveAt(row.Index);
                }
                SetTextBoxesReadOnly(true);
                GetProductData();
                BtnBack.Text = "&Back";
                GlobalVariableClass.v_gblRecMode = false;
                BtnUpdate.Enabled = false;
                CbPricePer.Enabled = true;
                CbSchemeStatus.Enabled = true;
                DgvPriceCalc.Enabled = true;
                return;
            }
        }

        private void GetProductData()
        {
            SqlConnection NewConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand NewCmd = new SqlCommand("select * from products where prodcode = '" + TxtProdCode.Text + "'", NewConn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = NewCmd;
            NewCmd.CommandType = CommandType.Text;
            NewConn.Open();
            da.Fill(dt);
            SqlDataReader GetInfoReader = NewCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (GetInfoReader.HasRows)
            {
                while (GetInfoReader.Read())
                {
                    TxtProdCode.Text = GetInfoReader["prodcode"].ToString();
                    lblProdId.Text = GetInfoReader["productid"].ToString();
                    TxtBarCode.Text = GetInfoReader["prodbarcode"].ToString();
                    TxtProdName.Text = GetInfoReader["prodname"].ToString();
                    TxtShortName.Text = GetInfoReader["prodshortname"].ToString();
                    TxtProdNameUrdu.Text = GetInfoReader["prodnameurdu"].ToString();
                    TxtProdGroup.Text = GetInfoReader["prodgroup"].ToString();
                    TxtCompany.Text = GetInfoReader["prodcompany"].ToString();
                    TxtPack.Text = GetInfoReader["prodpack"].ToString();
                    CbPrimaryUnit.Text = GetInfoReader["prodprimaryunit"].ToString();
                    CbSecondaryUnit.Text = GetInfoReader["prodsecondaryunit"].ToString();
                    TxtConvFactor.Text = GetInfoReader["prodconvfactor"].ToString();
                    CbPricePer.Text = GetInfoReader["produnitname"].ToString();
                    TxtTaxSlab.Text = GetInfoReader["prodtaxslab"].ToString();
                    // add fetched data row to the datagridview
                    int gRowIndex = DgvPriceCalc.Rows.Add();
                    DataGridViewRow gRowData = DgvPriceCalc.Rows[gRowIndex];
                    gRowData.Cells[0].Value = GetInfoReader["prodpurchprice"].ToString();
                    gRowData.Cells[1].Value = GetInfoReader["prodvat"].ToString();
                    gRowData.Cells[2].Value = GetInfoReader["proditax"].ToString();
                    gRowData.Cells[3].Value = GetInfoReader["prodothertax"].ToString();
                    gRowData.Cells[4].Value = GetInfoReader["prodbasicprice"].ToString();
                    gRowData.Cells[5].Value = GetInfoReader["prodsaleprice"].ToString();
                    gRowData.Cells[6].Value = GetInfoReader["prodmrp"].ToString();
                    gRowData.Cells[7].Value = GetInfoReader["prodminprice"].ToString();
                    gRowData.Cells[8].Value = GetInfoReader["prodprofit"].ToString();
                    gRowData.Cells[9].Value = GetInfoReader["prodstock"].ToString();
                    gRowData.Cells[10].Value = GetInfoReader["prodstockval"].ToString();
                    TxtMinLvl.Text = GetInfoReader["prodminlevel"].ToString();
                    TxtMaxLvl.Text = GetInfoReader["prodmaxlevel"].ToString();
                    CbSchemeStatus.Text = GetInfoReader["prodscheme"].ToString();
                }
            }
            NewConn.Close();
            GetInfoReader.Close();
            return;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SetTextBoxesReadOnly(false);
            SetTextBoxesClear();
            TxtProdCode.Focus();
            BtnUpdate.Enabled = true;
            BtnBack.Text = "&Refresh";
            TxtConvFactor.Text = "0";
            TxtMaxLvl.Text = "0";
            TxtMinLvl.Text = "0";
            TxtBarCode.Text = "0";
            Addition = true;
            Editing = false;
            CbPricePer.Enabled = true;
            CbSchemeStatus.Enabled = true;
            CbPrimaryUnit.Enabled = true;
            CbSecondaryUnit.Enabled = true;
            CbSchemeStatus.Text = "False";
            int gRowIndex = DgvPriceCalc.Rows.Add();
            DataGridViewRow gRowData = DgvPriceCalc.Rows[gRowIndex];
            gRowData.Cells[0].Value = 0.00;
            gRowData.Cells[1].Value = 0.00;
            gRowData.Cells[2].Value = 0.00;
            gRowData.Cells[3].Value = 0.00;
            gRowData.Cells[4].Value = 0.00;
            gRowData.Cells[5].Value = 0.00;
            gRowData.Cells[6].Value = 0.00;
            gRowData.Cells[7].Value = 0.00;
            gRowData.Cells[8].Value = 0.00;
            gRowData.Cells[9].Value = 0;
            gRowData.Cells[10].Value = 0.00;
        }

        private void DgvPriceCalc_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumberColumn_KeyPress);
            e.Control.KeyPress -= new KeyPressEventHandler(DecimalColumn_KeyPress);
            if (DgvPriceCalc.CurrentCell.ColumnIndex == 9) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(NumberColumn_KeyPress);
                }
            }
            else
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(DecimalColumn_KeyPress);
                }
            }
        }

        private void DecimalColumn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NumberColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DgvPriceCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value = Convert.ToDouble(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[0].Value.ToString()) +
                                                                                  Convert.ToDouble(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[1].Value.ToString()) +
                                                                                  Convert.ToDouble(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[2].Value.ToString()) +
                                                                                  Convert.ToDouble(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[3].Value.ToString());

                Decimal colSalePrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value);
                int colStock;
                Decimal valMargin;
                String str = DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[9].Value.ToString();
                valMargin = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[5].Value) - Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value);
                Decimal colStockVal;
                int.TryParse(str, out colStock);
                colStockVal = colSalePrice * colStock;
                DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[10].Value = colStockVal;
                DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[8].Value = valMargin;
            }
        }

        private void DgvPriceCalc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[0].Value.ToString()) +
                                                                                  Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[1].Value.ToString()) +
                                                                                  Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[2].Value.ToString()) +
                                                                                  Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[3].Value.ToString());

            Decimal colSalePrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value);
            int colStock;
            Decimal valMargin;
            String str = DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[9].Value.ToString();
            valMargin = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[5].Value) - Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value);
            Decimal colStockVal;
            int.TryParse(str, out colStock);
            colStockVal = colSalePrice * colStock;
            DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[10].Value = colStockVal;
            DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[8].Value = valMargin;
        }

        private void BtnTaxSlab_Click(object sender, EventArgs e)
        {
            if (TxtTaxSlab.ReadOnly == false)
            {
                GlobalVariableClass.v_gblViewFieldName = "TAXDESCRIPTION";
                GlobalVariableClass.v_gblViewTableName = "TAXSLAB";
                GlobalVariableClass.v_gblViewValueMember = "SEQUENCEID";
                FieldViewerForm childForm = new FieldViewerForm();
                childForm.ShowDialog();
                if (GlobalVariableClass.v_gblSearchString != string.Empty)
                {
                    this.TxtTaxSlab.Text = GlobalVariableClass.v_gblSearchString;
                    this.TxtTaxSlab.Focus();
                    GlobalVariableClass.v_gblSearchString = string.Empty;
                }
            }
        }

        private void BtnViewProdGroup_Click(object sender, EventArgs e)
        {
            if (TxtProdGroup.ReadOnly == false)
            {
                GlobalVariableClass.v_gblViewFieldName = "ProdGroupName";
                GlobalVariableClass.v_gblViewTableName = "ProductGroup";
                GlobalVariableClass.v_gblViewValueMember = "ProdGroupID";
                FieldViewerForm childForm = new FieldViewerForm();
                childForm.ShowDialog();
                if (GlobalVariableClass.v_gblSearchString != string.Empty)
                {
                    this.TxtProdGroup.Text = GlobalVariableClass.v_gblSearchString;
                    this.TxtProdGroup.Focus();
                    GlobalVariableClass.v_gblSearchString = string.Empty;
                }
            }
        }

        private void BtnCompany_Click(object sender, EventArgs e)
        {
            if (TxtCompany.ReadOnly == false)
            {
                GlobalVariableClass.v_gblViewFieldName = "CompanyName";
                GlobalVariableClass.v_gblViewTableName = "Companies";
                GlobalVariableClass.v_gblViewValueMember = "CompanyCode";
                FieldViewerForm childForm = new FieldViewerForm();
                childForm.ShowDialog();
                if (GlobalVariableClass.v_gblSearchString != string.Empty)
                {
                    this.TxtCompany.Text = GlobalVariableClass.v_gblSearchString;
                    this.TxtCompany.Focus();
                    GlobalVariableClass.v_gblSearchString = string.Empty;
                }
            }
        }

        private void BtnAddTaxSlab_Click(object sender, EventArgs e)
        {
            // wait for code
        }

        private void BtnAddProdGrp_Click(object sender, EventArgs e)
        {
            ProductGroup childForm = new ProductGroup();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void BtnProductUnit_Click(object sender, EventArgs e)
        {
            if (TxtTaxSlab.ReadOnly == false)
            {
                GlobalVariableClass.v_gblViewFieldName = "ProdUnit";
                GlobalVariableClass.v_gblViewTableName = "ProductUnits";
                GlobalVariableClass.v_gblViewValueMember = "ProdUnitSeq";
                FieldViewerForm childForm = new FieldViewerForm();
                childForm.ShowDialog();
            }
        }

        private void CbPricePer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbPricePer.Text == CbPrimaryUnit.Text) { DefaultUnitId = 1; } else { DefaultUnitId = 2; }
        }

        private void BtnAddSecondaryUnit_Click(object sender, EventArgs e)
        {
            // wait for code
        }

        private void CbPrimaryUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CbPricePer.Items.Clear();
            //CbPricePer.Items.Add(CbPrimaryUnit.SelectedItem);
            //CbPricePer.Items.Add(CbSecondaryUnit.SelectedItem);
        }

        private void CbPrimaryUnit_Leave(object sender, EventArgs e)
        {
            if (panel3.Height > 76)
            {
                CbPricePer.Items.Clear();
                if (!string.IsNullOrEmpty(CbPrimaryUnit.Text)) { CbPricePer.Items.Add(CbPrimaryUnit.SelectedItem); }
                if (!string.IsNullOrEmpty(CbSecondaryUnit.Text)) { CbPricePer.Items.Add(CbSecondaryUnit.SelectedItem); }
            }
        }

        private void CbSchemeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgvPriceCalc.Enabled = true;
        }

        private void CbSchemeStatus_Leave(object sender, EventArgs e)
        {
            DgvPriceCalc.Enabled = true;
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            if (CbPrimaryUnit.Enabled  == true)
            {
                if (panel3.Height == 76)
                {
                    btnExtend.Image = Properties.Resources.checked_24px;
                    btnExtend.FlatAppearance.BorderColor = Color.Black;
                    panel3.Height = 168;
                }
                else
                {
                    btnExtend.Image = Properties.Resources.ok_24px;
                    btnExtend.FlatAppearance.BorderColor = Color.Gray;
                    panel3.Height = 76;
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(panel3.Height == 76)
            {
                PrimaryUnitId = 1;
                PrimaryUnitName = CbPrimaryUnit.Text;
                SecUnitId = 0;
                SecUnitName = String.Empty;
                DefaultUnitId = 1;
                DefaultUnitName = CbPrimaryUnit.Text;
                ConvFactor = 0;
            }

            if(panel3.Height == 168)
            {
                PrimaryUnitId = 1;
                PrimaryUnitName = CbPrimaryUnit.Text;
                SecUnitId = 2;
                SecUnitName = CbSecondaryUnit.Text;
                if (CbPricePer.Text == CbPrimaryUnit.Text) { DefaultUnitId = 1; } else { DefaultUnitId = 2; }
                DefaultUnitName = CbPricePer.Text;
                ConvFactor = Convert.ToInt32(TxtConvFactor.Text);
            }

            Decimal PurchPrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[0].Value);
            Decimal VAT = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[1].Value);
            Decimal ITax = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[2].Value);
            Decimal OtherTax = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[3].Value);
            Decimal BasicPrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value);
            Decimal SalePrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[5].Value);
            Decimal MRP = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[6].Value);
            Decimal MinPrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[7].Value);
            Decimal Profit = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[8].Value);
            int Stock = Convert.ToInt32(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[9].Value);
            Decimal StockValue = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[10].Value);

            Decimal MinLevel = 0;
            Decimal MaxLevel = 0;

            if (String.IsNullOrEmpty(CbSchemeStatus.Text)) { CbSchemeStatus.Text = "False"; }
            if (String.IsNullOrEmpty (TxtMinLvl.Text)) { MinLevel = 0; } else { MinLevel = Convert.ToInt32(TxtMinLvl.Text); }
            if (String.IsNullOrEmpty(TxtMaxLvl.Text)) { MaxLevel = 0; } else { MaxLevel = Convert.ToInt32(TxtMaxLvl.Text); }

            //int primaryUnitId = GlobalVariableClass.GetUnitId("ProdUnit", "ProdUnitSeq", "ProductUnits", CbPrimaryUnit.Text.Trim());

            if(panel3.Height == 168 && Convert.ToInt32(TxtConvFactor.Text) == 0)
            {
                MessageBox.Show(this, "Conversion Factor required with alternate units.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Add textboxes values into database
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("ProdCode", "Products", TxtProdCode.Text.ToString()) == false)
                    {
                        DataQuery = "insert into products (ProdCode, ProductId, ProdBarCode, ProdName, ProdShortName, ProdNameUrdu, ProdGroup, ProdCompany, ProdPack, ProdPrimaryId, ProdPrimaryUnit, ProdSecondaryId, ProdSecondaryUnit, ProdConvFactor, ProdUnitId, ProdUnitName, ProdTaxSlab," +
                                    "ProdPurchPrice, ProdVAT, ProdITax, ProdOtherTax, ProdBasicPrice, ProdSalePrice, ProdMRP, ProdMinPrice, ProdProfit, ProdStock, ProdStockVal, ProdPricePercent, ProdMinLevel, ProdMaxLevel, ProdScheme) values('" +
                                    TxtProdCode.Text + "'," +
                                    Convert.ToInt32(lblProdId.Text) + "," +
                                    TxtBarCode.Text + ",'" +
                                    TxtProdName.Text + "','" +
                                    TxtShortName.Text + "',N'" +
                                    TxtProdNameUrdu.Text + "','" +
                                    TxtProdGroup.Text + "','" +
                                    TxtCompany.Text + "','" +
                                    TxtPack.Text + "'," +
                                    PrimaryUnitId + ",'" +
                                    PrimaryUnitName + "'," +
                                    SecUnitId + ",'" +
                                    SecUnitName + "'," +
                                    TxtConvFactor.Text + "," +
                                    DefaultUnitId + ",'" +
                                    DefaultUnitName + "','" +
                                    TxtTaxSlab.Text + "'," +
                                    PurchPrice + "," +
                                    VAT + "," +
                                    ITax + "," +
                                    OtherTax + "," +
                                    BasicPrice + "," +
                                    SalePrice + "," +
                                    MRP + "," +
                                    MinPrice + "," +
                                    Profit + "," +
                                    Stock + "," +
                                    StockValue + "," +
                                    "1," +
                                    MinLevel + "," +
                                    MaxLevel + ",'" +
                                    CbSchemeStatus.Text + "," +
                                    "0,0,0)";
                    }
                }
                // Edit textboxes values and update into database
                if (Editing == true)
                    {
                        DataQuery = "update products set " +
                                    "ProdCode = '" + TxtProdCode.Text + "'," +
                                    "ProdBarCode = " + TxtBarCode.Text + "," +
                                    "ProdName = '" + TxtProdName.Text + "'," +
                                    "ProdShortName = '" + TxtShortName.Text + "'," +
                                    "ProdNameUrdu = N'" + TxtProdNameUrdu.Text + "'," +
                                    "ProdGroup = '" + TxtProdGroup.Text + "'," +
                                    "ProdCompany = '" + TxtCompany.Text + "'," +
                                    "ProdPack = '1x" + TxtConvFactor.Text + "'," +
                                    "ProdPrimaryID = " + PrimaryUnitId + "," +
                                    "ProdPrimaryUnit = '" + PrimaryUnitName + "'," +
                                    "ProdSecondaryId = " + SecUnitId + "," +
                                    "ProdSecondaryUnit = '" + SecUnitName + "'," +
                                    "ProdConvFactor = " + TxtConvFactor.Text + "," +
                                    "ProdUnitId = " + DefaultUnitId + "," +
                                    "ProdUnitName = '" + DefaultUnitName + "'," +
                                    "ProdTaxSlab = '" + TxtTaxSlab.Text + "'," +
                                    "ProdPurchPrice = " + PurchPrice + "," +
                                    "ProdVAT = " + VAT + "," +
                                    "ProdITax = " + ITax + "," +
                                    "ProdOtherTax = " + OtherTax + "," +
                                    "ProdBasicPrice = " + BasicPrice + "," +
                                    "ProdSalePrice = " + SalePrice + "," +
                                    "ProdMRP = " + MRP + "," +
                                    "ProdMinPrice = " + SalePrice + "," +
                                    "ProdProfit = " + Profit + "," +
                                    "ProdStock = " + Stock + "," +
                                    "ProdStockVal = " + StockValue + "," +
                                    "ProdPricePercent = 1," +
                                    "ProdMinLevel = " + MinLevel + "," +
                                    "ProdMaxLevel = " + MaxLevel + "," +
                                    "ProdScheme = '" + CbSchemeStatus.Text + "' " +
                                    "where ProdCode = '" + TxtProdCode.Text + "'";
                    }

                // Create Sql Parameters to Execute Query
                SqlConnection ProdConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand ProdCmd = new SqlCommand(DataQuery ,ProdConn);
                ProdConn.Open();
                int i = Convert.ToInt32(ProdCmd.ExecuteNonQuery());
                if (i > 0)
                {
                    MessageBox.Show("Product Saved/Updated Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ProdConn.Close();
                SetTextBoxesReadOnly(true);
                BtnBack_Click(sender, e);
                // update datagrid view on main
                ObjForm.GetProductsList();
                BtnUpdate.Enabled = false;
                CbPrimaryUnit.Enabled = false;
                CbSecondaryUnit.Enabled = false;
                CbPricePer.Enabled = false;
                CbSchemeStatus.Enabled = false;
                DgvPriceCalc.Enabled = false;
                return;
            }
            catch (Exception ExErr)
            {
                MessageBox.Show(ExErr.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
}

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnUpdate.Enabled = true;
            SetTextBoxesReadOnly(false);
            Addition = false;
            Editing = true;
            TxtProdCode.Focus();
            BtnBack.Text = "&Refresh";
            PreviousProdCd = TxtProdCode.Text.ToString();
            ProductCode = TxtProdCode.Text;
            CbPrimaryUnit.Enabled = true;
            CbSecondaryUnit.Enabled = true;
            CbPricePer.Enabled = true;
            CbSchemeStatus.Enabled = true;
            DgvPriceCalc.Enabled = true;
        }
    }
}
