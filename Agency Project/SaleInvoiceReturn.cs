using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class SaleInvoiceReturn : Form
    {
        GlobalVariableClass ProcedureClass = new GlobalVariableClass();
        SqlConnection gConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        SqlCommand gCmd = new SqlCommand();
        DateTime mDate = DateTime.Today;
        Decimal ConvFactor = 0, ItemPprice = 0, ItemSprice = 0;
        int TaxPercentage = 0, ProductID = 0, SortId = 0, AreaID = 0, CityId = 0, AccID = 0, CompID = 0, SalesManId = 0, TransID = 0, PrimaryUnitId = 0, SecUnitId = 0, DefaultUnitId = 0;
        String ProductCode = String.Empty, ProdBarCode = String.Empty, ProdGroup = String.Empty, ProdCompany = String.Empty, ProdCompUrdu = String.Empty, AccountHead = String.Empty, TranType = String.Empty, AccName = String.Empty, PrimaryUnit = String.Empty, Secondaryunit = String.Empty, DefaultUnit = String.Empty;
        Decimal TotUnits = 0, TotAltUnits = 0, TotFree = 0, TotBasicAmt = 0, TotTaxAmt = 0, TotNetValue = 0, TotGst = 0, TotITax = 0, TotAmount = 0, TotDiscount = 0, PartyBalance = 0;

        private void TbAltUnt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbAltUnt.Text)) { TbAltUnt.Text = "0"; }
        }

        private readonly SaleBookReturn ObjectSaleForm = (SaleBookReturn)Application.OpenForms["SaleBookReturn"];

        private void CbPricePer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TbDisPercnt.Focus();
                int Idx = CbPricePer.SelectedIndex;
                CalculateNetAmount(Idx);
            }
        }

        private void CbPricePer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPricePer.SelectedIndex == 0) { CalculateNetAmount(0); }
            if (CbPricePer.SelectedIndex == 1) { CalculateNetAmount(1); }
            TbDisPercnt.Focus();
        }

        private void TbBasicAmnt_Enter(object sender, EventArgs e)
        {
            int Idx = CbPricePer.SelectedIndex;
            CalculateNetAmount(Idx);
        }

        private void TbDisPercnt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbTaxPercent.Text)) { TbTaxPercent.Text = "0"; }
            TbNetValue.Text = Convert.ToString(Convert.ToDecimal(TbBasicAmnt.Text.Trim()) - Convert.ToDecimal(TbDiscount.Text.Trim()) + Convert.ToDecimal(TbTaxAmt.Text.Trim()));
        }

        private void TbDisPercnt_Enter(object sender, EventArgs e)
        {
            int Idx = CbPricePer.SelectedIndex;
            CalculateNetAmount(Idx);
        }
        private void TbDisPercnt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbTaxPercent.Text)) { TbTaxPercent.Text = "0"; }
            Decimal percent = Convert.ToDecimal(TbDisPercnt.Text) / 100;
            TbDiscount.Text = Convert.ToString(Convert.ToDecimal(TbBasicAmnt.Text) * percent);
            TbDiscount.Text = Decimal.Round(Convert.ToDecimal(TbDiscount.Text)).ToString();
            TbTaxAmt.Text = Decimal.Round(Convert.ToDecimal(TbTaxAmt.Text)).ToString();
            TbNetValue.Text = Convert.ToString(Convert.ToDecimal(TbBasicAmnt.Text.Trim()) - Convert.ToDecimal(TbDiscount.Text.Trim()) + Convert.ToDecimal(TbTaxAmt.Text.Trim()));
        }

        private void TbDisPercnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TbTaxPercent.Focus();
                TbDiscount.Text = Convert.ToString(Convert.ToDecimal(TbDisPercnt.Text) * Convert.ToDecimal(TbBasicAmnt.Text) / 100);
                TbNetValue.Text = Convert.ToString(Convert.ToDecimal(TbBasicAmnt.Text.Trim()) - Convert.ToDecimal(TbDiscount.Text.Trim()) + Convert.ToDecimal(TbTaxAmt.Text.Trim()));
            }
        }

        private void TbDisPercnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
            // only allow digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') { e.Handled = true; return; }
        }

        private void TbNetValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TbDiscount.Text = Decimal.Round(Convert.ToDecimal(TbDiscount.Text)).ToString();
                TbTaxAmt.Text = Decimal.Round(Convert.ToDecimal(TbTaxAmt.Text)).ToString();
                TbNetValue.Text = Convert.ToString(Convert.ToDecimal(TbBasicAmnt.Text.Trim()) - Convert.ToDecimal(TbDiscount.Text.Trim()) + Convert.ToDecimal(TbTaxAmt.Text.Trim()));
                DataGridViewCell FindCell = GetItemExistsInGridView(ProductCode, DgvProduct, 4);
                if (FindCell == null)
                {
                    // Calculate Net Amount
                    TbNetValue.Text = Convert.ToString(Convert.ToDecimal(TbBasicAmnt.Text.Trim()) - Convert.ToDecimal(TbDiscount.Text.Trim()) + Convert.ToDecimal(TbTaxAmt.Text.Trim()));
                    SortId += 1;
                    // Add New Row into DataGrid
                    int nRowIndex = DgvProduct.Rows.Add();
                    DataGridViewRow nRow = DgvProduct.Rows[nRowIndex];
                    nRow.Cells[0].Value = TbDate.Text.Trim();
                    nRow.Cells[1].Value = CbInvoiceNo.Text.Trim();
                    nRow.Cells[2].Value = lblSaleType.Text.Trim();
                    nRow.Cells[3].Value = lblCustID.Text.Trim();
                    nRow.Cells[4].Value = ProductCode;
                    nRow.Cells[5].Value = CbProduct.Text.Trim();
                    nRow.Cells[6].Value = TbProdUrdu.Text.Trim();
                    nRow.Cells[7].Value = ProdGroup;
                    nRow.Cells[8].Value = "Gr"; /* later assign group in urdu */
                    nRow.Cells[9].Value = ProdCompany;
                    nRow.Cells[10].Value = "Co"; /* later assign company name in urdu */
                    nRow.Cells[11].Value = TbPack.Text.Trim();
                    nRow.Cells[12].Value = lblVAT.Text;
                    nRow.Cells[13].Value = lblITax.Text;
                    nRow.Cells[14].Value = lblOther.Text;
                    nRow.Cells[15].Value = lblPrimaryPrice.Text;
                    nRow.Cells[16].Value = lblSecondaryPrice.Text;
                    //For Select Item Price and Qty
                    if (CbPricePer.SelectedIndex == 0) { nRow.Cells[17].Value = lblPrimaryPrice.Text; nRow.Cells[18].Value = lblPrimary.Text; nRow.Cells[19].Value = TbUnit.Text; }
                    if (CbPricePer.SelectedIndex == 1) { nRow.Cells[17].Value = lblSecondaryPrice.Text; nRow.Cells[18].Value = lblSecondary.Text; nRow.Cells[19].Value = TbAltUnt.Text; }
                    // For procedure
                    nRow.Cells[20].Value = TbUnit.Text.Trim();
                    nRow.Cells[21].Value = TbAltUnt.Text.Trim();
                    nRow.Cells[22].Value = "0";
                    nRow.Cells[23].Value = TbDisPercnt.Text.Trim();
                    nRow.Cells[24].Value = TbDiscount.Text.Trim();
                    nRow.Cells[25].Value = TbTaxPercent.Text.Trim();
                    nRow.Cells[26].Value = TbTaxAmt.Text.Trim();
                    nRow.Cells[27].Value = TbNetValue.Text.Trim();
                    nRow.Cells[28].Value = GlobalVariableClass.gblOperatorId;
                    nRow.Cells[29].Value = GlobalVariableClass.gblOperator;
                    nRow.Cells[30].Value = SortId;
                    // get company name in urdu
                    gCmd.CommandType = CommandType.Text;
                    gCmd.CommandText = "select companynameur from companies where companyname = N'" + ProdCompany + "'";
                    gCmd.Connection = gConn;
                    gConn.Open();
                    SqlDataReader rd = gCmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rd.HasRows) { while (rd.Read()) { nRow.Cells[10].Value = rd["companynameur"].ToString(); } }
                    gConn.Close();
                    // get product group in urdu
                    gCmd.CommandText = "select prodgroupnmur from productgroup where prodgroupname = N'" + ProdGroup + "'";
                    gCmd.Connection = gConn;
                    gConn.Open();
                    SqlDataReader grd = gCmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (grd.HasRows) { while (grd.Read()) { nRow.Cells[8].Value = grd["prodgroupnmur"].ToString(); } }
                    gConn.Close();
                    // Calculate subtotals
                    TotUnits += Convert.ToDecimal(TbUnit.Text.Trim());
                    TotAltUnits += Convert.ToDecimal(TbAltUnt.Text.Trim());
                    TotGst += Convert.ToDecimal(TbTaxAmt.Text.ToString());
                    TotITax += Convert.ToDecimal(lblITax.Text.Trim());
                    TotBasicAmt += Convert.ToDecimal(TbBasicAmnt.Text.Trim());
                    TotNetValue += Convert.ToDecimal(TbNetValue.Text.Trim());
                    TotDiscount += Convert.ToDecimal(TbDiscount.Text.Trim());
                    TotTaxAmt += Convert.ToDecimal(TbTaxAmt.Text.ToString()) + TotITax;
                    TotAmount += TotNetValue;
                    // display value in labels
                    lblMainQty.Text = TotUnits.ToString();
                    lblALtQty.Text = TotAltUnits.ToString();
                    lblFree.Text = TotFree.ToString();
                    lblTGST.Text = TotGst.ToString();
                    lblNValue.Text = TotNetValue.ToString();
                    lblBAmt.Text = TotBasicAmt.ToString();
                    lblTITax.Text = TotITax.ToString();
                    lblSubTotal.Text = Convert.ToString(TotNetValue);
                    lblTaxAmnt.Text = Convert.ToString(TotTaxAmt);
                    // Clear Controls for next entry
                    ClearProductControls();
                    CbProduct.Focus();
                    btnSave.Enabled = true;
                    panelGrid.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Item already added in the list.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CbProduct.Focus();
                    return;
                }
                gConn.Close();
            }
        }
        private void ClearProductControls()
        {
            foreach (Control ctrl in this.panelProduct.Controls)
            {
                if (ctrl is TextBox) { (ctrl as TextBox).Text = "0"; }
            }
            lblPriPrice.Text = "B. Price";
            lblSecPrice.Text = "S. Price";
            lblPrimary.Text = "Unit";
            lblSecondary.Text = "Alt. Unit";
            lblVAT.Text = "00";
            lblITax.Text = "00";
            lblOther.Text = "00";
            lblGST.Text = "00";
            lblStock.Text = "00";
            lblPrimaryPrice.Text = "00";
            lblSecondaryPrice.Text = "00";
            TbTaxPercent.Text = "0";
            CbProduct.Text = "";
            TbProdUrdu.Clear();
            TbPack.Clear();
        }

        private void TbAltUnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DgvProduct.DefaultCellStyle.ForeColor = Color.Black;
            ClearProductControls();
            lblSaleType.Text = String.Empty;
            TbPartyUrdu.Clear();
            CbProduct.Text = String.Empty;
            TbProdUrdu.Clear();
            TbPack.Clear();
            panelProduct.Enabled = false;
            if (DgvProduct.Rows.Count > 0)
            {
                DgvProduct.Rows.Clear();
                DgvProduct.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check important data
            //if (String.IsNullOrEmpty(CbSalesMan.Text.Trim()))
            //{ MessageBox.Show(this, "Sales Man should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); CbSalesMan.Focus(); return; }

            // Update Stock in Database
            int Quantity = Convert.ToInt32(lblALtQty.Text.ToString());
            String SaleOrderQuery = String.Empty;
            SqlCommand cmdSaleOrder = new SqlCommand();
            cmdSaleOrder.CommandType = CommandType.Text;

            Decimal CreditAmount = 0;

            CreditAmount = Convert.ToDecimal(lblSubTotal.Text.ToString());

            DateTime OD1 = DateTime.Today;
            DateTime OD2 = DateTime.Today;
            DateTime OD3 = DateTime.Today;
            DateTime OD4 = DateTime.Today;
            DateTime OD5 = DateTime.Today;

            OD1 = DateTime.Today.AddDays(15);
            OD2 = DateTime.Today.AddDays(30);
            OD3 = DateTime.Today.AddDays(45);
            OD4 = DateTime.Today.AddDays(60);
            OD5 = DateTime.Today.AddDays(75);

            DateTime dt = Convert.ToDateTime(TbDate.Text);

            // save sale order
            SaleOrderQuery = "Insert Into SaleReturn (date,saleorderid,saleorderseq,voucherid,transactiontype,accountid,accountname,accountnameur,batchid,batchno,batchcode,mainqty,altqty,loose,free,basicamount,taxamount,netvalue,totalgst,totalitax,discount,subtotal,cramount,ordersalesman,od1,od2,od3,od4,od5) values('" +
                             dt.ToString("yyyy-MM-dd") + "'," +
                             //Convert.ToDecimal(lblInvoice.Text.ToString()) + ",'" +
                             lblSequence.Text.ToString() + "'," +
                             Convert.ToDecimal(lblSequence.Text) + ",'" +
                             lblSaleType.Text.ToString() + "'," +
                             Convert.ToInt32(lblCustID.Text.ToString()) + ",'" +
                             //CbParty.Text.ToString() + "'," +
                             "N'" + TbPartyUrdu.Text.ToString() + "'," +
                             Convert.ToInt32(lblCustID.Text.ToString()) + ",'" +
                             "SI-" + lblSequence.Text.Trim() + "','" +
                             "BC-" + lblCustID.Text + "'," +
                             Convert.ToInt32(lblMainQty.Text.ToString()) + "," +
                             Convert.ToInt32(lblALtQty.Text.ToString()) + "," +
                             "0," +
                             Convert.ToInt32(lblFree.Text.ToString()) + "," +
                             Convert.ToDecimal(lblBAmt.Text.ToString()) + "," +
                             Convert.ToDecimal(lblTaxAmnt.Text.ToString()) + "," +
                             Convert.ToDecimal(lblNValue.Text.ToString()) + "," +
                             Convert.ToDecimal(lblTGST.Text.ToString()) + "," +
                             Convert.ToDecimal(lblTITax.Text.ToString()) + "," +
                             TotDiscount + "," +
                             Convert.ToDecimal(lblSubTotal.Text.ToString()) + "," +
                             CreditAmount + "," +
                             lblSalesMan.Text.ToString() + "','" +
                             OD1.ToString("yyyy-MM-dd") + "','" +
                             OD2.ToString("yyyy-MM-dd") + "','" +
                             OD3.ToString("yyyy-MM-dd") + "','" +
                             OD4.ToString("yyyy-MM-dd") + "','" +
                             OD5.ToString("yyyy-MM-dd") + "'," +
                             GlobalVariableClass.gblOperatorId + ",'" +
                             GlobalVariableClass.gblOperator + "')";
            cmdSaleOrder.CommandText = SaleOrderQuery;
            cmdSaleOrder.Connection = gConn;
            gConn.Open();
            cmdSaleOrder.ExecuteNonQuery();
            cmdSaleOrder.Dispose();
            gConn.Close();

            // save order details
            foreach (DataGridViewRow gRow in this.DgvProduct.Rows)
            {
                SqlCommand cmdOrderDetail = new SqlCommand();
                cmdOrderDetail.CommandType = CommandType.Text;
                String DetailQuery = String.Empty;
                DateTime dtDetail = Convert.ToDateTime(gRow.Cells[0].Value);
                // Move datagrid column values to variables
                Decimal OrderID = Convert.ToDecimal(gRow.Cells[1].Value);
                Decimal CustID = Convert.ToDecimal(gRow.Cells[3].Value);
                Decimal OrdVAT = Convert.ToDecimal(gRow.Cells[12].Value);
                Decimal OrdITax = Convert.ToDecimal(gRow.Cells[13].Value);
                Decimal OrdOther = Convert.ToDecimal(gRow.Cells[14].Value);
                Decimal OrdPrPrice = Convert.ToDecimal(gRow.Cells[15].Value);
                Decimal OrdSecPrice = Convert.ToDecimal(gRow.Cells[16].Value);
                Decimal OrdBPrice = Convert.ToDecimal(gRow.Cells[17].Value);
                Decimal OrdBQty = Convert.ToInt32(gRow.Cells[19].Value);
                Decimal MainQty = Convert.ToDecimal(gRow.Cells[20].Value);
                Decimal AltQty = Convert.ToDecimal(gRow.Cells[21].Value);
                Decimal FreeQty = Convert.ToDecimal(gRow.Cells[22].Value);
                Decimal OrdDiscP = Convert.ToDecimal(gRow.Cells[23].Value);
                Decimal OrdDisc = Convert.ToDecimal(gRow.Cells[24].Value);
                Decimal OrdTaxP = Convert.ToDecimal(gRow.Cells[25].Value);
                Decimal OrdTax = Convert.ToDecimal(gRow.Cells[26].Value);
                Decimal OrdAmount = Convert.ToDecimal(gRow.Cells[27].Value);
                Decimal DrawrID = Convert.ToDecimal(gRow.Cells[28].Value);
                Decimal wSortID = Convert.ToDecimal(gRow.Cells[30].Value);

                // For IDs of concerned Fields
                CompID = GlobalVariableClass.GetUnitId("CompanyName", "CompanyId", "Companies", lblCompany.Text.Trim());
                //SalesManId = GlobalVariableClass.GetUnitId("SalesManName", "SalesManID", "SalesMan", CbSalesMan.Text.ToString());

                // Order Details query
                DetailQuery = "insert into SaleReturnDetail (date,itemorderid,itemsaletype,customerid,itemid,itemname,itemnameur,itemgroup,itemgroupurdu,itemcompany," +
                              "itemcompurdu,itempack,itemvat,itemitax,itemothertax,itemprimaryprice,itemsecondaryprice,itembasicprice,itembasicunit,itembasicqty,itemqty,itemaltqty," +
                              "itemfreeqty,itemdiscpercent,itemdiscamnt,itemtaxpercent,itemtaxamt,itemnetvalue,itempayment,drawerid,drawername,sortitem,account_id,area_id,city_id,salesmanid,companyid) values('" +
                              dtDetail.ToString("yyyy-MM-dd") + "'," +
                              OrderID + ",'" +
                              gRow.Cells[2].Value + "'," +
                              CustID + ",'" +
                              gRow.Cells[4].Value + "','" +
                              gRow.Cells[5].Value + "',N'" +
                              gRow.Cells[6].Value + "','" +
                              gRow.Cells[7].Value + "',N'" +
                              gRow.Cells[8].Value + "','" +
                              gRow.Cells[9].Value + "',N'" +
                              gRow.Cells[10].Value + "','" +
                              gRow.Cells[11].Value + "'," +
                              OrdVAT + "," +
                              OrdITax + "," +
                              OrdOther + "," +
                              OrdPrPrice + "," +
                              OrdSecPrice + "," +
                              OrdBPrice + ",'" +
                              gRow.Cells[18].Value + "'," +
                              OrdBQty + "," +
                              MainQty + "," +
                              AltQty + "," +
                              FreeQty + "," +
                              OrdDiscP + "," +
                              OrdDisc + "," +
                              OrdTaxP + "," +
                              OrdTax + "," +
                              OrdAmount + "," +
                              DrawrID + ",'" +
                              gRow.Cells[29].Value + "'," +
                              wSortID + "," +
                              AccID + "," +
                              AreaID + "," +
                              CityId + "," +
                              SalesManId + "," +
                              CompID + ")";
                cmdOrderDetail.CommandText = DetailQuery;
                cmdOrderDetail.Connection = gConn;
                gConn.Open();
                int i = cmdOrderDetail.ExecuteNonQuery();
                gConn.Close();
                btnSave.Enabled = false;
                ObjectSaleForm.FillMasterGrid();
                MadeJournalEntry();
                SqlCommand SaleBook = new SqlCommand();
                SaleBook.CommandType = CommandType.Text;
                SaleBook.CommandText = "Insert Into SaleBookReturn (date,saleorderid,voucherid,transactiontype,accountid,accountname,accountnameur,mainqty,altqty,loose,free,basicamount,discount,cramount,ordersalesman,remarks) values('" +
                             dt.ToString("yyyy-MM-dd") + "'," +
                             //Convert.ToDecimal(lblInvoice.Text.ToString()) + ",'" +
                             Convert.ToDecimal(lblSequence.Text) + ",'" +
                             lblSaleType.Text.ToString() + "'," +
                             Convert.ToInt32(lblCustID.Text.ToString()) + ",'" +
                             //CbParty.Text.ToString() + "'," +
                             "N'" + TbPartyUrdu.Text.ToString() + "'," +
                             Convert.ToInt32(lblMainQty.Text.ToString()) + "," +
                             Convert.ToInt32(lblALtQty.Text.ToString()) + "," +
                             "0," +
                             Convert.ToInt32(lblFree.Text.ToString()) + "," +
                             Convert.ToDecimal(lblBAmt.Text.ToString()) + "," +
                             TotDiscount + "," +
                             CreditAmount + ",'" +
                             lblSalesMan.Text.ToString() + "','" +
                             "'Sale Return')";
                if (gConn.State == ConnectionState.Open) { gConn.Close(); }
                gConn.Open();
                SaleBook.ExecuteNonQuery();
                gConn.Close();
                if (i > 0) { MessageBox.Show("Sale Return Invoice Generated Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                SaleBook.Dispose();
                cmdOrderDetail.Dispose();
                this.Close();
            }
        }
        private void MadeJournalEntry()
        {
            // setup data for ledger transaction
            int TrSort = 0;
            String FinacialYear = String.Empty;
            DateTime F_Year = DateTime.Today;
            if (F_Year.Month < 7)
            {
                FinacialYear = "FY - " + F_Year.Year;
            }
            DateTime TranDt = Convert.ToDateTime(TbDate.Text);
            TransID = GlobalVariableClass.GenerateSeqID("ledg_tran_id", "ledgers");
            AccID = Convert.ToInt32(lblCustID.Text);
            AccName = lblParty.Text.Trim();
            String VoucherNo = "SI-" + lblSequence.Text.Trim();
            String Narration = String.Empty;
            if (lblSaleType.Text == "CASH") { Narration = "Cash Sale Return."; } else { Narration = "Credit Sale Return."; }

            //For Debit Entry
            decimal CreditAmount = Convert.ToDecimal(lblSubTotal.Text) - Convert.ToDecimal(lblTGST.Text) + TotDiscount;
            getAccountBalance("Sale");
            GlobalVariableClass.DebitEntry(TranDt, TransID, "Return", AccountHead, AccID, AccName, VoucherNo, Narration, TranType, CreditAmount, 0, PartyBalance, TrSort, FinacialYear);
            UpdatePartyBalance("Sale", CreditAmount);

            //For Debit Entry of Sale Discount
            CreditAmount = TotDiscount;
            TrSort += 1;
            getAccountBalance("Sale Discount");
            GlobalVariableClass.CreditEntry(TranDt, TransID, "Discount", AccountHead, AccID, AccName, VoucherNo, Narration, TranType, 0, CreditAmount, PartyBalance, TrSort, FinacialYear);
            UpdatePartyBalance(lblParty.Text, CreditAmount);

            //For Credit Entry
            CreditAmount = Convert.ToDecimal(lblSubTotal.Text);
            TrSort += 1;
            getAccountBalance(lblParty.Text);
            GlobalVariableClass.CreditEntry(TranDt, TransID, "Return", AccountHead, AccID, AccName, VoucherNo, Narration, TranType, 0, CreditAmount, PartyBalance, TrSort, FinacialYear);
            UpdatePartyBalance(lblParty.Text, CreditAmount);
            //If GST charge on items
            if (Convert.ToDecimal(lblTGST.Text) > 0)
            {
                CreditAmount = Convert.ToDecimal(lblTGST.Text) / 2;
                TrSort += 1;
                getAccountBalance("SGST");
                GlobalVariableClass.DebitEntry(TranDt, TransID, "Sale", "Liabilities", 901, "SGST", VoucherNo, "GST Recieved on Sale.", "CR", CreditAmount, 0, PartyBalance, TrSort, FinacialYear);
                UpdatePartyBalance("SGST", CreditAmount);
                TrSort += 1;
                getAccountBalance("CGST");
                GlobalVariableClass.DebitEntry(TranDt, TransID, "Sale", "Liabilities", 902, "CGST", VoucherNo, "GST Recieved on Cash.", "CR", CreditAmount, 0, PartyBalance, TrSort, FinacialYear);
                UpdatePartyBalance("CGST", CreditAmount);
            }
            TrSort = 0;
        }

        private void getAccountBalance(String PartyName)
        {
            SqlCommand SaleCommand = new SqlCommand();
            SaleCommand.CommandType = CommandType.Text;
            SaleCommand.CommandText = "select * from accounts where account_name = '" + PartyName + "'";
            SaleCommand.Connection = gConn;
            gConn.Open();
            SqlDataReader rd = SaleCommand.ExecuteReader(CommandBehavior.CloseConnection);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    AccID = rd.GetInt32(0);
                    AccName = rd.GetString(1);
                    AccountHead = rd.GetString(6);
                    PartyBalance = rd.GetDecimal(8);
                    TranType = rd.GetString(9);
                }
            }
            gConn.Close();
        }

        private void UpdatePartyBalance(String AccName, Decimal Amount)
        {
            SqlCommand updtcmd = new SqlCommand();
            updtcmd.Connection = gConn;
            updtcmd.CommandType = CommandType.Text;
            updtcmd.CommandText = "update accounts set opn_bal = opn_bal + " + Amount + " where account_name = '" + AccName + "'";
            gConn.Open();
            updtcmd.ExecuteNonQuery();
            gConn.Close();
        }
        private void TbAltUnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(TbAltUnt.Text)) { TbAltUnt.Text = "0"; }
                TbBasicAmnt.Focus();
            }
        }
        private void TbAltUnt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbAltUnt.Text)) { TbAltUnt.Text = "0"; }
        }
        private void TbAltUnt_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbAltUnt.Text)) { TbAltUnt.Text = "0"; }
        }
        private void TbUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(TbUnit.Text)) { TbUnit.Text = "0"; }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
        }
        private void TbUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(TbUnit.Text)) { TbUnit.Text = "0"; }
                TbAltUnt.Focus();
            }
        }
        private void TbUnit_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbUnit.Text)) { TbUnit.Text = "0"; }
            TbAltUnt.Text = Convert.ToString(Convert.ToInt32(TbUnit.Text.Trim()) * ConvFactor);
            TbAltUnt.Focus();
        }
        private void TbUnit_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbUnit.Text)) { TbUnit.Text = "0"; }
            TbUnit.SelectAll();
            if (TbAltUnt.Enabled == true) { TbAltUnt.Text = Convert.ToString(Convert.ToInt32(TbUnit.Text.Trim()) * ConvFactor); }
        }

        private void TbUnit_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbUnit.Text)) { TbUnit.Text = "0"; }
            if (TbAltUnt.Enabled == true) { TbAltUnt.Text = Convert.ToString(Convert.ToInt32(TbUnit.Text.Trim()) * ConvFactor); }
        }

        private void CbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbPricePer.Items.Clear();
            SqlCommand prodCommand = new SqlCommand();
            prodCommand.CommandType = CommandType.Text;
            prodCommand.Connection = gConn;
            prodCommand.CommandText = "select * from products where prodname = '" + CbProduct.Text.Trim() + "'";
            gConn.Open();
            SqlDataReader dr = prodCommand.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ProductCode = dr["prodcode"].ToString();
                    ProductID = dr.GetInt32(1);
                    ProdBarCode = dr["prodbarcode"].ToString();
                    ProdGroup = dr["prodgroup"].ToString();
                    TbProdUrdu.Text = dr["prodnameurdu"].ToString();
                    ProdCompany = dr["prodcompany"].ToString();
                    TbPack.Text = dr["prodpack"].ToString();
                    lblVAT.Text = dr["prodvat"].ToString();
                    lblITax.Text = dr["proditax"].ToString();
                    lblOther.Text = dr["prodothertax"].ToString();
                    lblStock.Text = dr["prodstock"].ToString();
                    lblGST.Text = dr["prodtaxrate"].ToString();
                    lblPrimaryPrice.Text = dr["prodbasicprice"].ToString();
                    lblSecondaryPrice.Text = dr["prodsaleprice"].ToString();
                    lblCompany.Text = dr["prodcompany"].ToString();
                    lblGroup.Text = dr["prodgroup"].ToString();
                    // Check for Units
                    PrimaryUnitId = dr.GetInt32(9);
                    PrimaryUnit = dr["prodprimaryunit"].ToString();
                    SecUnitId = dr.GetInt32(11);
                    Secondaryunit = dr["prodsecondaryunit"].ToString();
                    DefaultUnitId = dr.GetInt32(14);
                    DefaultUnit = dr["produnitname"].ToString();
                    ConvFactor = dr.GetInt32(13);

                    if (ConvFactor == 0)
                    {
                        CbPricePer.Items.Clear();
                        CbPricePer.Items.Add(PrimaryUnit);
                        lblPrimary.Text = PrimaryUnit;
                        lblSecondary.Text = PrimaryUnit;
                        TbAltUnt.Enabled = false;
                        lblExp.Text = String.Empty;
                        CbPricePer.SelectedIndex = 0;
                    }
                    else
                    {
                        this.CbPricePer.Items.Clear();
                        this.CbPricePer.Items.Add(dr["prodprimaryunit"].ToString());
                        this.CbPricePer.Items.Add(dr["prodsecondaryunit"].ToString());
                        lblPrimary.Text = PrimaryUnit;
                        lblSecondary.Text = Secondaryunit;
                        lblExp.Text = "1" + " " + dr["prodprimaryunit"].ToString() + " = " + ConvFactor.ToString() + " " + dr["prodsecondaryunit"].ToString();
                    }
                    TaxPercentage = dr.GetInt32(17);
                    ItemPprice = Convert.ToDecimal(lblPrimaryPrice.Text);
                    ItemSprice = Convert.ToDecimal(lblSecondaryPrice.Text);
                    lblGroup.Text = dr["prodgroup"].ToString();
                    lblCompany.Text = dr["prodcompany"].ToString();
                }
                lblExp.Visible = true;
                lbl103.Visible = true;
                CbPricePer.SelectedIndex = DefaultUnitId - 1;
                if (CbPricePer.SelectedIndex == 0) { CalculateNetAmount(0); } else { CalculateNetAmount(1); }
                TbUnit.Focus();
            }
            gConn.Close();
            TbUnit.Focus();
        }

        private void CbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVariableClass.gblIntegerValue = Convert.ToInt32(CbInvoiceNo.Text);
            GetInvoiceDetail();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SaleInvoiceReturn()
        {
            InitializeComponent();
        }

        private void EditSaleInvoice_Load(object sender, EventArgs e)
        {
            TbDate.Text = mDate.ToString("dd/MM/yyyy");
            GlobalVariableClass.FillComboxBox(CbInvoiceNo, "SaleOrderId", "SaleOrder");
        }

        private void GetInvoiceDetail()
        {
            SqlCommand rCommand = new SqlCommand();
            rCommand.CommandType = CommandType.Text;
            rCommand.CommandText = "Select * from SaleOrder where SaleOrderID = " + GlobalVariableClass.gblIntegerValue;
            rCommand.Connection = gConn;
            gConn.Open();
            SqlDataAdapter SaleAdapter = new SqlDataAdapter();
            SqlDataReader reader = rCommand.ExecuteReader();
            if (reader.HasRows)
            {
                GlobalVariableClass.FillComboxBox(CbProduct, "prodname", "products");
                while (reader.Read())
                {
                    DateTime sDate = (DateTime)reader["Date"];
                    lblInvoiceDate.Text = sDate.ToString("dd/MM/yyyy");
                    lblSalesMan.Text = reader.GetDecimal(1).ToString();
                    lblSequence.Text = reader.GetString(2);
                    CbInvoiceNo.Text = reader.GetString(4);
                    lblSaleType.Text = reader.GetString(4);
                    lblParty.Text = reader.GetString(6);
                    TbPartyUrdu.Text = reader.GetString(7);
                    lblSalesMan.Text = reader.GetString(24);
                    CbProduct.Focus();
                }
            }
            gConn.Close();
        }
        private void CalculateNetAmount(int Choice)
        {
            int ItemQty = 0;
            Decimal ItemPrice = 0;
            if (Choice == 0) { ItemQty = Convert.ToInt32(TbUnit.Text.Trim()); }
            if (Choice == 1) { ItemQty = Convert.ToInt32(TbAltUnt.Text.Trim()); }
            ItemPrice = ItemSprice;
            Decimal BasicAmnt = ItemQty * ItemPrice;
            Decimal TaxAmnt = BasicAmnt / 100 * TaxPercentage;
            TbTaxAmt.Text = TaxAmnt.ToString();
            TbTaxPercent.Text = TaxPercentage.ToString();
            TbBasicAmnt.Text = BasicAmnt.ToString();
            BasicAmnt = BasicAmnt - Convert.ToDecimal(TbDiscount.Text.Trim()) + TaxAmnt;
            TbNetValue.Text = BasicAmnt.ToString();
        }
        // To Check if item already in the datagridview
        private DataGridViewCell GetItemExistsInGridView(string searchText, DataGridView dataGridView, int columnIndex)
        {
            DataGridViewCell cellWhereTextIsMet = null;
            // For every row in the grid (obviously)
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // I did not test this case, but cell.Value is an object, and objects can be null
                // So check if the cell is null before using .ToString()
                if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                {
                    // the searchText is equals to the text in this cell.
                    cellWhereTextIsMet = row.Cells[columnIndex];
                    break;
                }
            }
            return cellWhereTextIsMet;
        }
    }
}
