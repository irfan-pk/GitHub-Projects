using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp2
{
    public partial class NewProduct : Form
    {
        public delegate void DoEvent(String Proceed);
        public event DoEvent GetProductsList;
        TextInfo myTextInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
        GlobalVariableClass MyClass = new GlobalVariableClass();
        String PreviousProdCd = String.Empty;
        String ProductCode = String.Empty;
        Boolean Addition = false, Editing = false;
        String DataQuery = string.Empty, PackSize = String.Empty;

        public NewProduct()
        {
            InitializeComponent();
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            if (GlobalVariableClass.v_gblRecMode == true)
            {
                BtnEdit.Enabled = false;
            }
            if (GlobalVariableClass.v_gblRecMode == false)
            {
                BtnCreate.Enabled = false;
                GetProductData();
                CheckNullValues();
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
                GlobalVariableClass.gblProductCode = TxtProdCode.Text.ToUpper();
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
            if (BtnBack.Text == "&Refresh")
            {
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
            GlobalVariableClass.v_gblRecMode = false;
            this.Close();
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
                    TxtProdCode.Text = GetInfoReader[0].ToString();
                    TxtBarCode.Text = GetInfoReader[1].ToString();
                    TxtProdName.Text = GetInfoReader[2].ToString();
                    TxtShortName.Text = GetInfoReader[3].ToString();
                    TxtProdNameUrdu.Text = GetInfoReader[4].ToString();
                    TxtProdGroup.Text = GetInfoReader[5].ToString();
                    TxtCompany.Text = GetInfoReader[6].ToString();
                    PackSize = GetInfoReader[7].ToString();
                    TxtPrimaryUnit.Text = GetInfoReader[8].ToString();
                    TxtSecondaryUnit.Text = GetInfoReader[9].ToString();
                    CbPricePer.Text = GetInfoReader[10].ToString();
                    TxtTaxSlab.Text = GetInfoReader[11].ToString();
                    TxtMinLvl.Text = GetInfoReader[24].ToString();
                    TxtMaxLvl.Text = GetInfoReader[25].ToString();
                    CbSchemeStatus.Text = GetInfoReader[26].ToString();

                    // add fetched date row to the datagridview
                    int gRowIndex = DgvPriceCalc.Rows.Add();
                    DataGridViewRow gRowData = DgvPriceCalc.Rows[gRowIndex];
                    gRowData.Cells[0].Value = GetInfoReader[12].ToString();
                    gRowData.Cells[1].Value = GetInfoReader[13].ToString();
                    gRowData.Cells[2].Value = GetInfoReader[14].ToString();
                    gRowData.Cells[3].Value = GetInfoReader[15].ToString();
                    gRowData.Cells[4].Value = GetInfoReader[16].ToString();
                    gRowData.Cells[5].Value = GetInfoReader[17].ToString();
                    gRowData.Cells[6].Value = GetInfoReader[18].ToString();
                    gRowData.Cells[7].Value = GetInfoReader[19].ToString();
                    gRowData.Cells[8].Value = GetInfoReader[20].ToString();
                    gRowData.Cells[9].Value = GetInfoReader[21].ToString();
                    gRowData.Cells[10].Value = GetInfoReader[22].ToString();
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
            DgvPriceCalc.Enabled = true;
            CbPricePer.SelectedIndex = 1;
            CbSchemeStatus.SelectedIndex = 0;
            CbPricePer.Text = "Pcs";
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

                DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[10].Value = Convert.ToDouble(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value.ToString()) *
                                                                                   Convert.ToInt32(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[9].Value.ToString());
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
            String str = DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[9].Value.ToString();
            Decimal colStockVal;
            int.TryParse(str, out colStock);
            colStockVal = colSalePrice * colStock;
            DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[10].Value = colStockVal;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Decimal PurchPrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[0].Value);
            Decimal VAT = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[1].Value);
            Decimal ITAx = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[2].Value);
            Decimal OtherTax = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[3].Value);
            Decimal BasicPrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value);
            Decimal SalePrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[5].Value);
            Decimal MRP = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[6].Value);
            Decimal MinPrice = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[7].Value);
            Decimal Profit = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[8].Value);
            int Stock = Convert.ToInt32(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[9].Value);
            Decimal StockValue = Convert.ToDecimal(DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[10].Value);

            if (String.IsNullOrEmpty(CbPricePer.Text)) { CbPricePer.Text = "Pcs"; }
            if (String.IsNullOrEmpty(CbSchemeStatus.Text)) { CbSchemeStatus.Text = "False"; }

            try
            {
                // Add textboxes values into database
                if (Addition == true)
                {
                    if (GlobalVariableClass.CheckRowExist("ProdCode", "Products", TxtProdCode.Text.ToString()) == false)
                    {
                        DataQuery = "insert into products (ProdCode, ProdBarCode, ProdName, ProdShortName, ProdNameUrdu, ProdGroup, ProdCompany, ProdPack, ProdPrimaryUnit, ProdSecondaryUnit, ProdPricePerPck, ProdTaxSlab," +
                                    "ProdPurchPrice, ProdVAT, ProdITax, ProdOtherTax, ProdBasicPrice, ProdSalePrice, ProdMRP, ProdMinPrice, ProdProfit, ProdStock, ProdStockVal, ProdPricePercent, ProdMinLevel, ProdMaxLevel, ProdScheme) values('" +
                                    TxtProdCode.Text + "'," +
                                    TxtBarCode.Text + ",'" +
                                    TxtProdName.Text + "','" +
                                    TxtShortName.Text + "',N'" +
                                    TxtProdNameUrdu.Text + "','" +
                                    TxtProdGroup.Text + "','" +
                                    TxtCompany.Text + "','" +
                                    "1x" + TxtConvFactor.Text + "','" +
                                    TxtPrimaryUnit.Text + "','" +
                                    TxtSecondaryUnit.Text + "','" +
                                    CbPricePer.Text + "','" +
                                    TxtTaxSlab.Text + "'," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[0].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[1].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[2].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[3].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[5].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[6].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[7].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[8].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[9].Value + "," +
                                    DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[10].Value + "," +
                                    "1," +
                                    TxtMinLvl.Text + "," +
                                    TxtMaxLvl.Text + "," +
                                    "0)";
                    }
                }
                // Edit textboxes values and update into database
                if (Editing == true)
                {

                DataQuery = "update products set ProdCode = @ProdCode," +
                            "ProdbarCode = @BarCode," +
                            "ProdName = @ProdName," +
                            "ProdShortName = @Shortname," +
                            "ProdNameUrdu = @NameUrdu," +
                            "ProdGroup = @ProdGroup," +
                            "ProdCompany = @Company," +
                            "ProdPack = @Pack," +
                            "ProdPrimaryUnit = @PrimaryUnit," +
                            "ProdSecondaryUnit = @SecondaryUnit," +
                            "ProdPricePerPck = @PerPack," +
                            "ProdTaxSlab = @Slab," +
                            "ProdPurchPrice = @PurchPrice," +
                            "ProdVAT = @VAT," +
                            "ProdITAX = @ITax," +
                            "ProdOtherTax = @OtherTax," +
                            "ProdBasicPrice = @BasicPrice," +
                            "ProdSalePrice = @SalePrice," +
                            "ProdMRP = @MRP," +
                            "ProdMinPrice = @MinPrice," +
                            "ProdProfit = @Profit," +
                            "ProdStock = @Stock," +
                            "ProdStockVal = @StockVal," +
                            "ProdPricePercent = @Percent," +
                            "ProdMinLevel = @MinLvl," +
                            "ProdMaxLevel = @MaxLvl," +
                            "ProdScheme = @Scheme where ProdCode = @UpdateCode";
                }

                // Create Sql Parameters to Execute Query
                SqlConnection ProdConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand ProdCmd = new SqlCommand();
                
                ProdConn.Open();
                // Create parameters for hold values
                SqlParameter PrdCode = new SqlParameter("@ProdCode",SqlDbType.VarChar);
                SqlParameter PrdBCode = new SqlParameter("@BarCode", SqlDbType.VarChar);
                SqlParameter PrdName = new SqlParameter("@ProdName", SqlDbType.VarChar);
                SqlParameter PrdSName = new SqlParameter("@Shortname", SqlDbType.VarChar);
                SqlParameter PrdNmUr = new SqlParameter("@NameUrdu", SqlDbType.NVarChar);
                SqlParameter PrdGrp = new SqlParameter("@ProdGroup", SqlDbType.VarChar);
                SqlParameter PrdComp = new SqlParameter("@Company", SqlDbType.VarChar);
                SqlParameter PrdPack = new SqlParameter("@Pack", SqlDbType.VarChar);
                SqlParameter PrdPrUnit = new SqlParameter("@PrimaryUnit", SqlDbType.VarChar);
                SqlParameter PrdSecUnit = new SqlParameter("@SecondaryUnit", SqlDbType.VarChar);
                SqlParameter PrdPerPack = new SqlParameter("@PerPack", SqlDbType.VarChar);
                SqlParameter PrdSlab = new SqlParameter("@Slab", SqlDbType.VarChar);
                SqlParameter PrdPPrice = new SqlParameter("@PurchPrice", SqlDbType.Decimal);
                SqlParameter PrdVAT = new SqlParameter("@VAT", SqlDbType.Decimal);
                SqlParameter PrdITax = new SqlParameter("@ITax", SqlDbType.Decimal);
                SqlParameter PrdOthTax = new SqlParameter("@OtherTax", SqlDbType.Decimal);
                SqlParameter PrdBPrice = new SqlParameter("@BasicPrice", SqlDbType.Decimal);
                SqlParameter PrdSPrice = new SqlParameter("@SalePrice", SqlDbType.Decimal);
                SqlParameter PrdMRP = new SqlParameter("@MRP", SqlDbType.Decimal);
                SqlParameter PrdMinPr = new SqlParameter("@MinPrice", SqlDbType.Decimal);
                SqlParameter PrdProfit = new SqlParameter("@Profit", SqlDbType.Decimal);
                SqlParameter PrdStock = new SqlParameter("@Stock", SqlDbType.Int);
                SqlParameter PrdStckVal = new SqlParameter("@StockVal", SqlDbType.Decimal);
                SqlParameter PrdPercent = new SqlParameter("@Percent", SqlDbType.Int);
                SqlParameter PrdMinLvl = new SqlParameter("@MinLvl", SqlDbType.Int);
                SqlParameter PrdMaxLvl = new SqlParameter("@MaxLvl", SqlDbType.Int);
                SqlParameter PrdScheme = new SqlParameter("@Scheme", SqlDbType.Bit);
                SqlParameter UpdateCode = new SqlParameter("@UpdateCode", SqlDbType.VarChar);

                // Add parameters to sqlcommand
                ProdCmd.Parameters.Add(PrdCode);
                ProdCmd.Parameters.Add(PrdBCode);
                ProdCmd.Parameters.Add(PrdName);
                ProdCmd.Parameters.Add(PrdNmUr);
                ProdCmd.Parameters.Add(PrdSName);
                ProdCmd.Parameters.Add(PrdGrp);
                ProdCmd.Parameters.Add(PrdComp);
                ProdCmd.Parameters.Add(PrdPack);
                ProdCmd.Parameters.Add(PrdPrUnit);
                ProdCmd.Parameters.Add(PrdSecUnit);
                ProdCmd.Parameters.Add(PrdPerPack);
                ProdCmd.Parameters.Add(PrdSlab);
                ProdCmd.Parameters.Add(PrdPPrice);
                ProdCmd.Parameters.Add(PrdVAT);
                ProdCmd.Parameters.Add(PrdITax);
                ProdCmd.Parameters.Add(PrdOthTax);
                ProdCmd.Parameters.Add(PrdBPrice);
                ProdCmd.Parameters.Add(PrdSPrice);
                ProdCmd.Parameters.Add(PrdMRP);
                ProdCmd.Parameters.Add(PrdMinPr);
                ProdCmd.Parameters.Add(PrdProfit);
                ProdCmd.Parameters.Add(PrdStock);
                ProdCmd.Parameters.Add(PrdStckVal);
                ProdCmd.Parameters.Add(PrdPercent);
                ProdCmd.Parameters.Add(PrdMinLvl);
                ProdCmd.Parameters.Add(PrdMaxLvl);
                ProdCmd.Parameters.Add(PrdScheme);
                ProdCmd.Parameters.Add(UpdateCode);

                // assign values to parameters
                PrdCode.Value = TxtProdCode.Text;
                PrdBCode.Value = TxtBarCode.Text;
                PrdName.Value = TxtProdName.Text;
                PrdNmUr.Value = TxtProdNameUrdu.Text;
                PrdSName.Value = TxtShortName.Text;
                PrdGrp.Value = TxtProdGroup.Text;
                PrdComp.Value = TxtCompany.Text;
                PrdPack.Value = "1x" + TxtConvFactor.Text;
                PrdPrUnit.Value = TxtPrimaryUnit.Text;
                PrdSecUnit.Value = TxtSecondaryUnit.Text;
                PrdPerPack.Value = CbPricePer.Text;
                PrdSlab.Value = TxtTaxSlab.Text;
                PrdPPrice.Value = PurchPrice;
                PrdVAT.Value = VAT;
                PrdITax.Value = ITAx;
                PrdOthTax.Value = OtherTax;
                PrdBPrice.Value = BasicPrice;
                PrdSPrice.Value = SalePrice;
                PrdMRP.Value = MRP;
                PrdMinPr.Value = MinPrice;
                PrdProfit.Value = Profit;
                PrdStock.Value = Stock;
                PrdStckVal.Value = StockValue;
                PrdPercent.Value = 0;
                if (String.IsNullOrEmpty(TxtMinLvl.Text)) { PrdMinLvl.Value = 0; } else { PrdMinLvl.Value = Convert.ToInt32(TxtMinLvl.Text); }
                if (String.IsNullOrEmpty(TxtMaxLvl.Text)) { PrdMaxLvl.Value = 0; } else { PrdMaxLvl.Value = Convert.ToInt32(TxtMaxLvl.Text); }
                PrdScheme.Value = CbSchemeStatus.Text;
                UpdateCode.Value = TxtProdCode.Text;
                ProdCmd.Connection = ProdConn;
                ProdCmd.CommandText = DataQuery;

                int i = Convert.ToInt32(ProdCmd.ExecuteNonQuery());
                if (i > 0)
                {
                    MessageBox.Show("Product Saved/Updated Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ProdConn.Close();
                SetTextBoxesReadOnly(true);
                BtnBack_Click(sender, e);
                //this.GetProductsList("Done");
                BtnUpdate.Enabled = false;
                CbPricePer.Enabled = false;
                CbSchemeStatus.Enabled = false;
                DgvPriceCalc.Enabled = false;
                BtnBack_Click(sender, e);
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
            CbPricePer.Enabled = true;
            CbSchemeStatus.Enabled = true;
            DgvPriceCalc.Enabled = true;
        }

        

    }
}

//            "ProdCode = '" + TxtProdCode.Text + "'," +
//            "ProdBarCode = " + TxtBarCode.Text + "," +
//            "ProdName = '" + TxtProdName.Text + "'," +
//            "ProdShortName = '" + TxtShortName.Text + "'," +
//            "ProdNameUrdu = N'" + TxtProdNameUrdu.Text + "'," +
//            "ProdGroup = '" + TxtProdGroup.Text + "'," +
//            "ProdCompany = '" + TxtCompany.Text + "'," +
//            "ProdPack = '1x" + TxtConvFactor.Text + "'," +
//            "ProdPrimaryPckUnit = '" + TxtPrimaryUnit.Text + "'," +
//            "ProdSecondaryPckUnit = '" + TxtSecondaryUnit.Text + "'," +
//            "ProdPricePer = '" + CbPricePer.Text + "'," +
//            "ProdTaxSlab = '" + TxtTaxSlab.Text + "'," +
//            "ProdPurchPrice = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[0].Value + "," +
//            "ProdVAT = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[1].Value + "," +
//            "ProdITax = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[2].Value + "," +
//            "ProdOtherTax = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[3].Value + "," +
//            "ProdBasicPrice = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[4].Value + "," +
//            "ProdSalePrice = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[5].Value + "," +
//            "ProdMRP = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[6].Value + "," +
//            "ProdMinSalePrice = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[7].Value + "," +
//            "ProdProfitMargin = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[8].Value + "," +
//            "ProdStock = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[9].Value + "," +
//            "ProdStockVal = " + DgvPriceCalc.Rows[DgvPriceCalc.CurrentRow.Index].Cells[10].Value + "," +
//            "ProdPricePercent = 1," +
//            "ProdMinLevel = " + TxtMinLvl.Text + "," +
//            "ProdMaxLevel = " + TxtMaxLvl.Text + "," +
//            "ProdScheme = 0 where ProdCode = '" + ProductCode + "'";
