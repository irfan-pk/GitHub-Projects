using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class SaleInvoice : Form
    {
        GlobalVariableClass ProcedureClass = new GlobalVariableClass();
        SqlConnection gConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        SqlCommand gCmd = new SqlCommand();
        Decimal ConvFactor = 0, ItemPprice = 0, ItemSprice = 0;
        int TaxPercentage = 0, ProductID = 0, SortId = 0, AreaID = 0, CityId = 0, AccID = 0, CompID = 0, SalesManId = 0, TransID = 0, PrimaryUnitId=0,SecUnitId=0,DefaultUnitId=0;
        String ProductCode = String.Empty, ProdBarCode = String.Empty, ProdGroup = String.Empty, ProdCompany = String.Empty, ProdCompUrdu = String.Empty, AccountHead = String.Empty, TranType = String.Empty, AccName = String.Empty, PrimaryUnit=String.Empty,Secondaryunit=String.Empty,DefaultUnit=String.Empty;
        Decimal TotUnits = 0, TotAltUnits = 0, TotFree = 0, TotBasicAmt = 0, TotTaxAmt = 0, TotNetValue = 0, TotGst = 0, TotITax = 0, TotAmount = 0, TotDiscount = 0, PartyBalance = 0;
        private readonly SaleBook ObjectSaleForm = (SaleBook)Application.OpenForms["SaleBook"];

        public SaleInvoice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {
            //if (GlobalVariableClass.v_gblRecMode == true)
            //{
                TbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                GlobalVariableClass.FillComboxBox(CbSalesMan, "SalesManName", "SalesMan");
                lblInvoice.Text = GlobalVariableClass.GenerateSeqID("SaleOrderId", "SaleOrder").ToString();
                lblSequence.Text = DateTime.Now.ToString("yyyyMM") + lblInvoice.Text.ToString();
                DgvProduct.DefaultCellStyle.ForeColor = Color.Black;
            /*lblSequence.Text = DateTime.Now.ToString("yyyyMM") + GenerateSeqID("SELECT MAX(CONVERT(INT, RIGHT(SaleOrderSeq, LEN(SaleOrderSeq)-6))) as MaxID " +
                                   "FROM SaleOrder where LEFT(SaleOrderSeq, 6) = N'" + DateTime.Now.ToString("yyyyMM") + "' " +
                                   "GROUP BY SaleOrderSeq");*/
            CbTerm.Items.Clear();
            CbTerm.Items.Add("Credit");
            CbTerm.Items.Add("Cash");
            //}
        }

        private void CbParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GlobalVariableClass.v_gblRecMode == true) { getPartyInformation(); }
        }

        private void getPartyInformation()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from accounts where account_name ='" + CbParty.Text.Trim() + "'";
            cmd.Connection = gConn;
            gConn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TbPartyUrdu.Text = dr["account_name_u"].ToString();
                    lblCustID.Text = dr["account_id"].ToString();
                    AccountHead = dr["accounthead"].ToString();
                    TranType = dr["Dr_Cr"].ToString();
                    PartyBalance = Convert.ToDecimal(dr["opn_bal"].ToString());
                    AccID = Convert.ToInt32(lblCustID.Text);
                    AreaID = Convert.ToInt32(dr["Area_Id"].ToString());
                    CityId = Convert.ToInt32(dr["City_Id"].ToString());
                    panelProduct.Enabled = true;
                    GlobalVariableClass.FillComboxBox(CbProduct, "ProdName", "Products");
                    CbProduct.Focus();
                }
                dr.Close();
                popupPanel.BringToFront();
                popupPanel.Visible = true;
                ShowPartyCredentials(CbParty.Text);
            }
            cmd.Dispose();
            gConn.Close();
        }

        private void ShowPartyCredentials(String pName)
        {
            // Code for Display Information
            SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("select * from accounts where account_name = '" + pName + "'", conn);
            conn.Open();
            SqlDataReader InfoReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (InfoReader.HasRows)
            {
                while (InfoReader.Read())
                {
                    lblPartyName.Text = InfoReader["account_name"].ToString();
                    lblMobile.Text = InfoReader["mobile"].ToString();
                    lblCNIC.Text = InfoReader["cnic"].ToString();
                    lblCrLimit.Text = InfoReader["bill_limit"].ToString();
                    lblBalance.Text = InfoReader["opn_bal"].ToString();
                }
                InfoReader.Close();
            }
            cmd.Dispose();
            conn.Close();

            //For other information regarding sale invoices
            SqlCommand SumCmd = new SqlCommand("select count(saleorderid) as TotalBills, sum(subtotal) as NetTotal from saleorder where accountname = '" + pName + "'");
            SumCmd.Connection = conn;
            conn.Open();
            SqlDataReader SumRd = SumCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (SumRd.HasRows)
            {
                while (SumRd.Read())
                {
                    lblTotalBills.Text = SumRd["TotalBills"].ToString();
                    lblTotalSale.Text = SumRd["NetTotal"].ToString();
                }
            }
            SumCmd.Dispose();
            conn.Close();
            DateTime dt = Convert.ToDateTime(TbDate.Text);
            SqlCommand MonthSale = new SqlCommand("select count(saleorderid) as TotalBills, sum(subtotal) as NetTotal from saleorder where accountname = '" + pName + "' and month([Date]) = " + dt.Month);
            MonthSale.Connection = conn;
            conn.Open();
            SqlDataReader MBillRd = MonthSale.ExecuteReader(CommandBehavior.CloseConnection);
            if (MBillRd.HasRows)
            {
                while (MBillRd.Read())
                {
                    lblThisLastBill.Text = MBillRd["TotalBills"].ToString();
                    lblThisMonthamnt.Text = MBillRd["NetTotal"].ToString();
                }
            }
            MonthSale.Dispose();
            conn.Close();
            SqlCommand LastSale = new SqlCommand("select saleorderid,subtotal,date,max(date) OVER (PARTITION BY saleorderid) as LastSaleDate from saleorder where accountname = '" + pName + "'");
            LastSale.Connection = conn;
            conn.Open();
            SqlDataReader LastSaleRd = LastSale.ExecuteReader(CommandBehavior.CloseConnection);
            if (LastSaleRd.HasRows)
            {
                while (LastSaleRd.Read())
                {
                    lblLastBill.Text = LastSaleRd["saleorderid"].ToString();
                    lblLastSale.Text = LastSaleRd["subtotal"].ToString();
                }
            }
            LastSale.Dispose();
            conn.Close();
            SqlCommand DueBill = new SqlCommand("select count(saleorderid) as MaxBills, sum(subtotal) as MaxDues from saleorder where accountname = '" + pName + "' and CrAmount > 0");
            DueBill.Connection = conn;
            conn.Open();
            SqlDataReader DueBillRd = DueBill.ExecuteReader(CommandBehavior.CloseConnection);
            if (DueBillRd.HasRows)
            {
                while (DueBillRd.Read())
                {
                    lblDueBills.Text = DueBillRd["MaxBills"].ToString();
                    lblDueAmnt.Text = DueBillRd["MaxDues"].ToString();
                }
            }
            DueBill.Dispose();
            conn.Close();
            DateTime Lastdt = DateTime.Now;
            SqlCommand LastSaleDays = new SqlCommand("select saleorderid,subtotal,date,max(date) OVER (PARTITION BY saleorderid) as LastSaleDate, DateDiff(day,OD1,CONVERT(DATETIME,'" + Lastdt.ToString("yyyy-MM-dd") + " 00:00:00',102)) as DueDays from saleorder where accountname = '" + pName + "'");
            LastSaleDays.Connection = conn;
            conn.Open();
            SqlDataReader LastSaleDayRd = LastSaleDays.ExecuteReader(CommandBehavior.CloseConnection);
            if (LastSaleDayRd.HasRows)
            {
                while (LastSaleDayRd.Read())
                {
                    lblDays.Text = LastSaleDayRd["duedays"].ToString();
                    lblDueDate.Text = LastSaleDayRd["lastsaledate"].ToString();
                }
            }
            LastSaleDays.Dispose();
            conn.Close();
            SqlCommand DueBillData = new SqlCommand("select date,saleorderid,cramount from saleorder where accountname = '" + pName + "' and CrAmount > 0");
            DueBillData.Connection = conn;
            SqlDataAdapter dta = new SqlDataAdapter();
            DataTable dTable = new DataTable();
            dta.SelectCommand = DueBillData;
            conn.Open();
            dta.Fill(dTable);
            this.components.Add(SalebindingSource);
            this.components.Add(InvoicebindingNavigator);
            dgvDuesBills.DataSource = dTable;
            DueBillData.Dispose();
            conn.Close();
        }

        private void CbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblSaleType.Text = CbTerm.Text.ToUpper();
            String QueryString = String.Empty;
            if (CbTerm.SelectedIndex == 1) { QueryString = "Select * from accounts where account_name = '" + CbTerm.Text.Trim() + "'"; }
            if (CbTerm.SelectedIndex == 0) { QueryString = "Select * from accounts where accholder = 'LOCAL'"; }

            gCmd.CommandType = CommandType.Text;
            gCmd.CommandText = QueryString;
            gCmd.Connection = gConn;
            gConn.Open();
            SqlDataReader rd = gCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (rd.HasRows)
            {
                CbParty.Items.Clear();
                while (rd.Read())
                {
                    CbParty.Items.Add(rd["account_name"].ToString());
                }
            }
            rd.Close();
            gConn.Close();
        }

        private void CbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbPricePer.Items.Clear();
            popupPanel.Visible = false;
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
                CbPricePer.SelectedIndex = DefaultUnitId - 1 ;
                if (CbPricePer.SelectedIndex == 0) { CalculateNetAmount(0); } else { CalculateNetAmount(1); }
                TbUnit.Focus();
            }
            gConn.Close();
            TbUnit.Focus();
        }

        private void DgvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult DialogRs = MessageBox.Show("Are you sure to delete.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogRs == DialogResult.Yes)
                {
                    SubtractItemValues();
                    try
                    {
                        int selectedIndex = DgvProduct.CurrentCell.RowIndex;
                        if (selectedIndex > -1)
                        {
                            DgvProduct.Rows.RemoveAt(selectedIndex);
                            DgvProduct.Refresh(); // if needed
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void SubtractItemValues()
        {
            // Code goes here
            if (DgvProduct.SelectedRows.Count  > 0)
            {
                // Calculate subtotals
                TotBasicAmt -= Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[17].Value.ToString()) * (Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[19].Value.ToString()) - Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[22].Value.ToString()));
                TotITax -= Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[13].Value.ToString());
                TotUnits -= Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[20].Value.ToString());
                TotAltUnits -= Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[21].Value.ToString());
                TotFree -= Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[22].Value.ToString());
                TotGst -= Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[26].Value.ToString());
                TotDiscount -= Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[24].Value.ToString());
                TotNetValue -= (Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[27].Value.ToString()) + Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[24].Value.ToString()));
                TotTaxAmt -= (Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[26].Value.ToString()) + Convert.ToDecimal(DgvProduct.SelectedRows[0].Cells[13].Value.ToString()));
                TotAmount -= TotNetValue;
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
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            popupPanel.SendToBack();
            popupPanel.Visible = false;
        }

        private void TbUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(TbUnit.Text)) { TbUnit.Text = "0"; }
                TbAltUnt.Focus();
            }
        }

        private void TbBasicAmnt_Enter(object sender, EventArgs e)
        {
            int Idx = CbPricePer.SelectedIndex;
            CalculateNetAmount(Idx);
        }

        private void TbDisPercnt_Enter(object sender, EventArgs e)
        {
            int Idx = CbPricePer.SelectedIndex;
            CalculateNetAmount(Idx);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            GlobalVariableClass.FillComboxBox(CbSalesMan, "SalesManName", "SalesMan");
            lblInvoice.Text = GlobalVariableClass.GenerateSeqID("SaleOrderId", "SaleOrder").ToString();
            lblSequence.Text = DateTime.Now.ToString("yyyyMM") + lblInvoice.Text.ToString();
            DgvProduct.DefaultCellStyle.ForeColor = Color.Black;
            ClearProductControls();
            lblSaleType.Text = String.Empty;
            TbPartyUrdu.Clear();
            CbTerm.Text = String.Empty;
            CbSalesMan.Text = String.Empty;
            CbParty.Text = "";
            CbProduct.Text = String.Empty;
            TbProdUrdu.Clear();
            TbPack.Clear();
            panelProduct.Enabled = false;
            if(DgvProduct.Rows.Count > 0)
            {
                DgvProduct.Rows.Clear();
                DgvProduct.Refresh();
            }
            CbTerm.Items.Clear();
            CbParty.Items.Clear();
            CbTerm.Items.Add("Credit");
            CbTerm.Items.Add("Cash");
        }

        private void CbTerm_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(CbTerm.Text)) { MessageBox.Show(this, "Field should'nt be blank","Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void TbFree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
        }

        private void TbAltUnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(TbAltUnt.Text)) { TbAltUnt.Text = "0"; }
                TbFree.Focus();
            }
        }

        private void TbAltUnt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbAltUnt.Text)) { TbAltUnt.Text = "0"; }
        }

        private void TbFree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CbPricePer.Focus();
            }
        }

        private void CbParty_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CbTerm.Text.Trim()))
            { MessageBox.Show(this, "Term should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); CbTerm.Focus(); return; }

            if ( String.IsNullOrEmpty(CbSalesMan.Text.Trim()))
            { MessageBox.Show(this, "Sales Man should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); CbSalesMan.Focus(); return; }
        }

        private void CbParty_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CbTerm.Text.Trim()))
            { MessageBox.Show(this, "Term should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); CbTerm.Focus(); return; }

            if (String.IsNullOrEmpty(CbSalesMan.Text.Trim()))
            { MessageBox.Show(this, "Sales Man should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); CbSalesMan.Focus(); return; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check important data
            if (String.IsNullOrEmpty(CbTerm.Text.Trim()))
            { MessageBox.Show(this, "Term should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); CbTerm.Focus(); return; }

            if (String.IsNullOrEmpty (CbSalesMan .Text .Trim()))
            { MessageBox.Show(this,"Sales Man should'nt be blank.","Message",MessageBoxButtons.OK ,MessageBoxIcon.Information); CbSalesMan.Focus(); return; }

            // Update Stock in Database
            //int Quantity = Convert.ToInt32(lblALtQty.Text.ToString());
            String SaleOrderQuery = String.Empty;
            SqlCommand cmdSaleOrder = new SqlCommand();
            cmdSaleOrder.CommandType = CommandType.Text;

            Decimal DebitAmount = 0, CreditAmount = 0;

            if (lblSaleType.Text == "CASH") { DebitAmount = Convert.ToDecimal(lblSubTotal.Text.ToString()); } else { DebitAmount = 0; }
            if (lblSaleType.Text == "CREDIT") { CreditAmount = Convert.ToDecimal(lblSubTotal.Text.ToString()); } else { CreditAmount = 0; }

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
            SaleOrderQuery = "Insert Into SaleOrder (date,saleorderid,saleorderseq,voucherid,transactiontype,accountid,accountname,accountnameur,batchid,batchno,batchcode,mainqty,altqty,loose,free,basicamount,taxamount,netvalue,totalgst,totalitax,discount,subtotal,dramount,cramount,ordersalesman,od1,od2,od3,od4,od5) values('" +
                             dt.ToString("yyyy-MM-dd") + "'," +
                             Convert.ToDecimal(lblInvoice.Text.ToString()) + ",'" +
                             lblSequence.Text.ToString() + "'," +
                             Convert.ToDecimal(lblSequence.Text) + ",'" +
                             lblSaleType.Text.ToString() + "'," +
                             Convert.ToInt32(lblCustID.Text.ToString()) + ",'" +
                             CbParty.Text.ToString() + "'," +
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
                             DebitAmount + "," +
                             CreditAmount + ",'" +
                             CbSalesMan.Text.ToString() + "'," +
                             0 + ",'" +
                             OD1.ToString("yyyy-MM-dd") + "','" +
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
                Decimal OrdPayment = Convert.ToDecimal(gRow.Cells[28].Value);
                Decimal OrdDues = Convert.ToDecimal(gRow.Cells[29].Value);
                Decimal DrawrID = Convert.ToDecimal(gRow.Cells[30].Value);
                Decimal ExclPurch = Convert.ToDecimal(gRow.Cells[32].Value);
                Decimal ExclPrice = Convert.ToDecimal(gRow.Cells[33].Value);
                Decimal wSortID = Convert.ToDecimal(gRow.Cells[34].Value);

                // For IDs of concerned Fields
                CompID = GlobalVariableClass.GetUnitId("CompanyName", "CompanyId", "Companies", lblCompany.Text.Trim());
                SalesManId = GlobalVariableClass.GetUnitId("SalesManName", "SalesManID", "SalesMan", CbSalesMan.Text.ToString());

                // Order Details query
                DetailQuery = "insert into SaleOrderDetail (date,itemorderid,itemsaletype,customerid,itemid,itemname,itemnameur,itemgroup,itemgroupurdu,itemcompany," +
                              "itemcompurdu,itempack,itemvat,itemitax,itemothertax,itemprimaryprice,itemsecondaryprice,itembasicprice,itembasicunit,itembasicqty,itemqty,itemaltqty," +
                              "itemfreeqty,itemdiscpercent,itemdiscamnt,itemtaxpercent,itemtaxamt,itemnetvalue,itempayment,itemdues,drawerid,drawername,itemexclpurch,itemexclprice,sortitem,account_id,area_id,city_id,salesmanid,companyid) values('" +
                              dtDetail .ToString ("yyyy-MM-dd") + "'," +
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
                              OrdVAT  + "," +
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
                              OrdPayment + "," +
                              OrdDues + "," +
                              DrawrID + ",'" +
                              gRow .Cells[31].Value + "'," +
                              ExclPurch + "," +
                              ExclPrice + "," +
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
                SaleBook.CommandText = "Insert Into SaleBook (date,saleorderid,voucherid,transactiontype,accountid,accountname,accountnameur,mainqty,altqty,loose,free,basicamount,discount,dramount,cramount,ordersalesman,recoverydate,remarks) values('" +
                             dt.ToString("yyyy-MM-dd") + "'," +
                             Convert.ToDecimal(lblInvoice.Text.ToString()) + ",'" +
                             Convert.ToDecimal(lblSequence.Text) + ",'" +
                             lblSaleType.Text.ToString() + "'," +
                             Convert.ToInt32(lblCustID.Text.ToString()) + ",'" +
                             CbParty.Text.ToString() + "'," +
                             "N'" + TbPartyUrdu.Text.ToString() + "'," +
                             Convert.ToInt32(lblMainQty.Text.ToString()) + "," +
                             Convert.ToInt32(lblALtQty.Text.ToString()) + "," +
                             "0," +
                             Convert.ToInt32(lblFree.Text.ToString()) + "," +
                             Convert.ToDecimal(lblBAmt.Text.ToString()) + "," +
                             TotDiscount + "," +
                             DebitAmount + "," +
                             CreditAmount + "," +
                             CbSalesMan.Text.ToString() + "','" +
                             "1990-01-01','Dr.')";
                if(gConn.State == ConnectionState.Open) { gConn.Close(); }
                gConn.Open();
                SaleBook.ExecuteNonQuery();
                gConn.Close();
                UpdateSaleStock();
                if (i > 0) { MessageBox.Show("Sale Invoice Generated Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                SaleBook.Dispose();
                cmdOrderDetail.Dispose();
                this.Close();
            }
        }

        private void UpdateSaleStock()
        {
            SqlConnection UpdStk = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand UpdCmd = new SqlCommand();
            UpdCmd.CommandType = CommandType.Text;
            UpdCmd.CommandText = "update products set prodissued = prodissued + " + Convert.ToInt32(lblALtQty.Text.ToString());
            UpdCmd.Connection = UpdStk;
            if (UpdStk .State == ConnectionState.Open) { UpdStk.Close(); }
            UpdStk.Open();
            UpdCmd.ExecuteNonQuery();
            UpdStk.Close();
        }

        private void MadeJournalEntry()
        {
            // setup data for ledger transaction
            int TrSort = 0;
            String FinacialYear = String.Empty;
            DateTime F_Year = DateTime.Today;
            if (F_Year .Month < 7)
            {
                FinacialYear = "FY - " + F_Year.Year;
            }
            DateTime TranDt = Convert.ToDateTime(TbDate.Text);
            TransID = GlobalVariableClass.GenerateSeqID("ledg_tran_id", "ledgers");
            AccID = Convert.ToInt32(lblCustID.Text);
            AccName = CbParty.Text.Trim();
            String VoucherNo = "SI-" + lblSequence.Text.Trim();
            String Narration = String.Empty;
            Decimal DebitAmount = 0, CreditAmount = 0;
            if (lblSaleType.Text == "CASH") { Narration = "Cash Sale."; } else { Narration = "Credit Sale."; }

            //For Debit Entry of Sale
            DebitAmount = Convert.ToDecimal(lblSubTotal.Text);
            CreditAmount = 0;
            getAccountBalance(CbParty.Text);
            GlobalVariableClass.DebitEntry(TranDt, TransID, "Sale", AccountHead, AccID, AccName, VoucherNo, Narration, TranType, DebitAmount, CreditAmount, PartyBalance, TrSort, FinacialYear);
            UpdatePartyBalance(CbParty.Text, DebitAmount);

            //For Debit Entry of Sale Discount
            DebitAmount = TotDiscount;
            CreditAmount = 0;
            TrSort += 1;
            getAccountBalance("Sale Discount");
            GlobalVariableClass.DebitEntry(TranDt, TransID, "Discount", AccountHead, AccID, AccName, VoucherNo, Narration, TranType, DebitAmount, CreditAmount, PartyBalance, TrSort, FinacialYear);
            UpdatePartyBalance("Sale Discount", DebitAmount);

            //For Credit Entry of Sale
            DebitAmount = 0;
            CreditAmount = Convert.ToDecimal(lblSubTotal.Text) - Convert.ToDecimal(lblTGST.Text) + TotDiscount;
            TrSort += 1;
            getAccountBalance("Sale");
            GlobalVariableClass.CreditEntry(TranDt, TransID, "Sale", AccountHead, AccID, AccName, VoucherNo, Narration, TranType, DebitAmount, CreditAmount, PartyBalance, TrSort, FinacialYear);
            UpdatePartyBalance("Sale", CreditAmount);

            //If GST charge on items
            if (Convert.ToDecimal(lblTGST.Text) > 0)
            {
                CreditAmount = Convert.ToDecimal(lblTGST.Text) / 2;
                TrSort += 1;
                getAccountBalance("SGST");
                GlobalVariableClass.CreditEntry(TranDt, TransID, "Sale", "Liabilities", 901, "SGST", VoucherNo, "GST Recieved on Sale.", "CR", 0, CreditAmount, PartyBalance, TrSort, FinacialYear);
                UpdatePartyBalance("SGST", CreditAmount);
                TrSort += 1;
                getAccountBalance("CGST");
                GlobalVariableClass.CreditEntry(TranDt, TransID, "Sale", "Liabilities", 902, "CGST", VoucherNo, "GST Recieved on Cash.", "CR", 0, CreditAmount, PartyBalance, TrSort, FinacialYear);
                UpdatePartyBalance("CGST", CreditAmount);
            }
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

        private void CalculateNetAmount(int Choice)
        {
            int ItemQty = 0;
            Decimal ItemPrice = 0;
            if (String.IsNullOrEmpty(TbFree.Text)) { TbFree.Text = "0"; }
            if (Choice == 0) { ItemQty = Convert.ToInt32(TbUnit.Text.Trim()); }
            if (Choice == 1) { ItemQty = Convert.ToInt32(TbAltUnt.Text.Trim()); }
            ItemPrice = ItemSprice;
            Decimal BasicAmnt = (ItemQty - Convert.ToDecimal(TbFree.Text)) * ItemPrice;
            Decimal TaxAmnt = BasicAmnt / 100 * TaxPercentage;
            TbTaxAmt.Text = TaxAmnt.ToString();
            TbTaxPercent.Text = TaxPercentage.ToString();
            TbBasicAmnt.Text = BasicAmnt.ToString();
            BasicAmnt = BasicAmnt - Convert.ToDecimal(TbDiscount.Text.Trim()) + TaxAmnt;
            TbNetValue.Text = BasicAmnt.ToString();
        }

        private void TbDisPercnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
            // only allow digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') { e.Handled = true; return; }
        }

        private void TbUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(TbUnit.Text)) { TbUnit.Text = "0"; }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
        }

        private void TbDisPercnt_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (TbTaxPercent.Text)) { TbTaxPercent.Text = "0"; }
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

        private void TbTaxPercent_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (TbDisPercnt .Text .Trim())) { TbDisPercnt.Text = "0"; }
        }

        private void TbAltUnt_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbAltUnt.Text)) { TbAltUnt.Text = "0"; }
        }

        private void TbDisPercnt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (TbTaxPercent.Text)) { TbTaxPercent.Text = "0"; }
            Decimal percent = Convert.ToDecimal(TbDisPercnt.Text) / 100;
            TbDiscount.Text = Convert.ToString(Convert.ToDecimal(TbBasicAmnt.Text) * percent);
            TbDiscount.Text = Decimal.Round(Convert.ToDecimal(TbDiscount.Text)).ToString();
            TbTaxAmt.Text = Decimal.Round(Convert.ToDecimal(TbTaxAmt.Text)).ToString();
            TbNetValue.Text = Convert.ToString(Convert.ToDecimal(TbBasicAmnt.Text.Trim()) - Convert.ToDecimal(TbDiscount.Text.Trim()) + Convert.ToDecimal(TbTaxAmt.Text.Trim()));
        }

        private void TbTaxPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter ) { TbNetValue.Focus(); }
        }

        private void TbAltUnt_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TbAltUnt.Text)) { TbAltUnt.Text = "0"; }
        }

        private void CbPricePer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TbDisPercnt.Focus();
                int Idx = CbPricePer.SelectedIndex;
                CalculateNetAmount(Idx);
            }
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

        private void TbAltUnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }
        }

        private void CbPricePer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbPricePer.SelectedIndex == 0) { CalculateNetAmount(0); }
            if (CbPricePer.SelectedIndex == 1) { CalculateNetAmount(1); }
            TbDisPercnt.Focus();
        }

        private void TbNetVale_KeyDown(object sender, KeyEventArgs e)
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
                    nRow.Cells[1].Value = lblInvoice.Text.Trim();
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
                    nRow.Cells[22].Value = TbFree.Text.Trim();
                    nRow.Cells[23].Value = TbDisPercnt.Text.Trim();
                    nRow.Cells[24].Value = TbDiscount.Text.Trim();
                    nRow.Cells[25].Value = TbTaxPercent.Text.Trim();
                    nRow.Cells[26].Value = TbTaxAmt.Text.Trim();
                    nRow.Cells[27].Value = TbNetValue.Text.Trim();
                    if (lblSaleType.Text == "Cash") { nRow.Cells[28].Value = TbNetValue.Text.Trim(); } else { nRow.Cells[28].Value = 0; }
                    if (lblSaleType.Text == "Credit") { nRow.Cells[29].Value = TbNetValue.Text.Trim(); } else { nRow.Cells[29].Value = 0; }
                    nRow.Cells[30].Value = GlobalVariableClass.gblOperatorId;
                    nRow.Cells[31].Value = GlobalVariableClass.gblOperator;
                    nRow.Cells[32].Value = TbExclPurch.Text.Trim();
                    nRow.Cells[33].Value = TbSalePrice.Text.Trim();
                    nRow.Cells[34].Value = SortId;
                    // get company name in urdu
                    gCmd.CommandType = CommandType.Text;
                    gCmd.CommandText = "select companynameur from companies where companyname = N'" + ProdCompany + "'";
                    gCmd.Connection = gConn;
                    gConn.Open();
                    SqlDataReader rd = gCmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rd.HasRows) { while (rd.Read ()) { nRow.Cells[10].Value = rd["companynameur"].ToString(); } }
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
                    TotFree += Convert.ToDecimal(TbFree.Text.Trim());
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
