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

namespace WholeSaleApplication
{
    public partial class PurchaseReturn : Form
    {
        GlobalVariableClass ProcedureClass = new GlobalVariableClass();
        SqlConnection gConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        SqlCommand gCmd = new SqlCommand();
        DateTime mDate = DateTime.Today;
        Decimal ConvFactor = 0, ItemPprice = 0, ItemSprice = 0;
        int TaxPercentage = 0, ProductID = 0, SortId = 0, AreaID = 0, CityId = 0, AccID = 0, CompID = 0, SalesManId = 0, TransID = 0, PrimaryUnitId = 0, SecUnitId = 0, DefaultUnitId = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private readonly PurchaseBook ObjectPurchForm = (PurchaseBook)Application.OpenForms["PurchaseBook"];

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check important data
            if (String.IsNullOrEmpty(CbPOrder.Text.Trim()))
            { MessageBox.Show(this, "Purchase Order should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); CbPOrder.Focus(); return; }

            // Update Stock in Database
            int Quantity = Convert.ToInt32(lblALtQty.Text.ToString());
            String SaleOrderQuery = String.Empty;
            SqlCommand cmdSaleOrder = new SqlCommand();
            cmdSaleOrder.CommandType = CommandType.Text;

            Decimal DebitAmount = 0, CreditAmount = 0;

            if (lblOrderType.Text == "CASH") { DebitAmount = Convert.ToDecimal(lblNValue.Text.ToString()); Rmks = "P.O Cash"; } else { DebitAmount = 0; }
            if (lblOrderType.Text == "CREDIT") { CreditAmount = Convert.ToDecimal(lblNValue.Text.ToString()); Rmks = "P.O Credit"; } else { CreditAmount = 0; }

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
            SaleOrderQuery = "Insert Into PurchaseOrder (date,purchorderid,purchorderseq,ordertype,accountid,accountname,accountnameur,mainqty,altqty,basicamount,netvalue,subtotal,dramount,cramount,orderoperator,od1,od2,od3,od4,od5) values('" +
                             dt.ToString("yyyy-MM-dd") + "'," +
                             Convert.ToDecimal(lblOrder.Text.ToString()) + ",'" +
                             lblSequence.Text.ToString() + "','" +
                             lblOrderType.Text.ToString() + "'," +
                             Convert.ToInt32(lblCustID.Text.ToString()) + ",'" +
                             CbParty.Text.ToString() + "'," +
                             "N'" + TbPartyUrdu.Text.ToString() + "'," +
                             Convert.ToInt32(lblMainQty.Text.ToString()) + "," +
                             Convert.ToInt32(lblALtQty.Text.ToString()) + "," +
                             Convert.ToDecimal(lblBAmt.Text.ToString()) + "," +
                             Convert.ToDecimal(lblNValue.Text.ToString()) + "," +
                             Convert.ToDecimal(lblNValue.Text.ToString()) + "," +
                             DebitAmount + "," +
                             CreditAmount + ",'" +
                             GlobalVariableClass.gblOperator + "','" +
                             OD1.ToString("yyyy-MM-dd") + "','" +
                             OD2.ToString("yyyy-MM-dd") + "','" +
                             OD3.ToString("yyyy-MM-dd") + "','" +
                             OD4.ToString("yyyy-MM-dd") + "','" +
                             OD5.ToString("yyyy-MM-dd") + "','" +
                             Rmks + "')";
            cmdSaleOrder.CommandText = SaleOrderQuery;
            cmdSaleOrder.Connection = gConn;
            gConn.Open();
            cmdSaleOrder.ExecuteNonQuery();
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
                Decimal OrdAmount = Convert.ToDecimal(gRow.Cells[22].Value);
                Decimal OrdPayment = Convert.ToDecimal(gRow.Cells[23].Value);
                Decimal OrdDues = Convert.ToDecimal(gRow.Cells[24].Value);
                Decimal DrawrID = Convert.ToDecimal(gRow.Cells[25].Value);
                Decimal wSortID = Convert.ToDecimal(gRow.Cells[26].Value);

                // For IDs of concerned Fields
                CompID = GlobalVariableClass.GetUnitId("CompanyName", "CompanyId", "Companies", lblCompany.Text.Trim());

                // Order Details query
                DetailQuery = "insert into purchasedetail (date,itemorderid,itemsaletype,customerid,itemid,itemname,itemnameur,itemgroup,itemgroupurdu,itemcompany," +
                              "itemcompurdu,itempack,itemvat,itemitax,itemothertax,itemprimaryprice,itemsecondaryprice,itembasicprice,itembasicunit,itembasicqty,itemqty,itemaltqty," +
                              "itemnetvalue,itempayment,itemdues,drawerid,drawername,sortitem,account_id,area_id,city_id,salesmanid,companyid) values('" +
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
                              OrdAmount + "," +
                              OrdPayment + "," +
                              OrdDues + "," +
                              DrawrID + ",'" +
                              gRow.Cells[26].Value + "'," +
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
                ObjectPurchForm.FillMasterGrid();
                UpdatePurchaseStock();
                //if (lblOrderType.Text == "CASH") { MadeJournalEntry(); }
                if (i > 0) { MessageBox.Show("Purchase Order Generated Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                this.Close();
            }
        }

        private void UpdatePurchaseStock()
        {
            SqlConnection UpdStk = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand UpdCmd = new SqlCommand();
            UpdCmd.CommandType = CommandType.Text;
            UpdCmd.CommandText = "update products set prodpurchase = prodpurchase + " + Convert.ToInt32(lblALtQty.Text.ToString());
            UpdCmd.Connection = UpdStk;
            if (UpdStk.State == ConnectionState.Open) { UpdStk.Close(); }
            UpdStk.Open();
            UpdCmd.ExecuteNonQuery();
            UpdStk.Close();
        }

        String ProductCode = String.Empty, ProdBarCode = String.Empty, ProdGroup = String.Empty, ProdCompany = String.Empty, ProdCompUrdu = String.Empty, AccountHead = String.Empty, TranType = String.Empty, AccName = String.Empty, PrimaryUnit = String.Empty, Secondaryunit = String.Empty, DefaultUnit = String.Empty, Rmks = String.Empty;
        Decimal TotUnits = 0, TotAltUnits = 0, TotFree = 0, TotBasicAmt = 0, TotTaxAmt = 0, TotNetValue = 0, TotGst = 0, TotITax = 0, TotAmount = 0, TotDiscount = 0, PartyBalance = 0;
        public PurchaseReturn()
        {
            InitializeComponent();
        }

        private void PurchaseReturn_Load(object sender, EventArgs e)
        {
            TbDate.Text = mDate.ToString("dd/MM/yyyy");
            GlobalVariableClass.FillComboxBox(CbPOrder, "Purchorderid", "PurchaseOrder");
        }
    }
}
