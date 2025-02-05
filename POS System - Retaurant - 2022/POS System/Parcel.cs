using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using POS_System.My;
using System.Transactions;
using System.Globalization;

namespace POS_System
{
    /// <summary>
    /// Main Class
    /// </summary>
    public partial class Parcel
    {
        private string ProductID = string.Empty;
        private int ProductQty, FinalQty;
        private bool drag;
        private int mousex;
        private int mousey;
        private string Items, Clos_Balance;
        private double Payment, FinalPayment, TotalQty, Dues;
        public bool SaleMode, ReturnMode, DiscountAllow, SaleReturn, SaleCredit;
        private int SortID, NewQty, LastSaleID, Max_ID, Q1, Q2, Q3, Q4;
        private bool clearDisplay = false;
        public string ItemName, Weight, ItemPrice, ItemCode, ItemPack;
        /// <summary>
        /// 
        /// </summary>
        public Parcel()
        {
            InitializeComponent();
        }

        private void frmSale_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                txtCustomerName.Visible = true;
                txtCustomerName.Clear();
                txtCustomerName.Focus();
            }
            if (e.KeyCode == Keys.F3)
                cmdSuspend_Click(sender, e);
            if (e.KeyCode == Keys.F5)
                cmdPrint_Click(sender, e);
            if (e.KeyCode == Keys.F6)
                cmdReturn_Click(sender, e);
            if (e.KeyCode == Keys.F7)
                cmdDelete_Click(sender, e);
            if (e.KeyCode == Keys.F8)
                txtPaid.Focus();
            if (e.KeyCode == Keys.F9)
                lblHold_DoubleClick(sender, e);
            if (e.KeyCode == Keys.F10)
                cmdSaleReturn_Click(sender, e);
            if (e.KeyCode == Keys.F11)
                cmdNew_Click(sender, e);
            if (e.KeyCode == Keys.F12)
                cmdSave_Click(sender, e);
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            // Delete Previous hold data
            //string DeleteMaster = "DELETE FROM SALE_MASTER_HOLD";
            //mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, DeleteMaster, mdlGeneral.Connection);
            //string DeleteDetail = "DELETE FROM SALE_DETAIL_HOLD";
            //mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, DeleteDetail, mdlGeneral.Connection);
            // To Clone Currency Format
            System.Globalization.CultureInfo newCulture = (System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentUICulture.Clone();
            newCulture.NumberFormat.CurrencySymbol = "Rs. ";
            newCulture.NumberFormat.CurrencyDecimalDigits = 2;
            newCulture.NumberFormat.CurrencyGroupSeparator = string.Empty;
            newCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture;
            lblUserID.Text = mdlGeneral.UserID;
            lblUserName.Text = mdlGeneral.SysOperator;
            lblUserRole.Text = mdlGeneral.UserStatus;
            mdlGeneral.GetConnectionString();
            cmdNew_Click(sender, e);
            txtCode.Focus();
            txtCustomerName.Text = "Cash Customer";
            lblCustID.Text = "00";
        }

        private void cmdViewSale_Click(object sender, EventArgs e)
        {
            string SaleInvoice = Interaction.InputBox("Enter Sale Invoice # to print", "Print Sale Invoice", "only digit");
            if (string.IsNullOrEmpty(SaleInvoice.Trim()))
                return;
            if (Information.IsNumeric(SaleInvoice.Trim()) & Conversion.Val(SaleInvoice.Trim()) > 0d)
            {
                mdlGeneral.gblFind = SaleInvoice.Trim();
                mdlGeneral.gblReportOption = "RECEIPT";
                mdlGeneral.gblReportName = Application.StartupPath + @"\Reports\CashReceipt.rpt";
                mdlGeneral.Print_Slips_Manually();
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            // Write Here to delete all holded entries when quit
            Close();
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.ProductCode.ShowDialog(this);
                if (Strings.Len(mdlGeneral.gblItemCode) > 0)
                    txtCode.Text = mdlGeneral.gblItemCode.ToUpper();
                txtCode.Focus();
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ProductCode.ShowDialog(this);
            if (Strings.Len(mdlGeneral.gblItemCode) > 0)
                txtCode.Text = mdlGeneral.gblItemCode.ToUpper();
            txtCode.Focus();
        }

        private void GroupBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblHold_DoubleClick(sender, e);
        }

        private void lblHold_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblHold_DoubleClick(sender, e);
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            string RefreshData = "Delete from sale_detail_temp where SaleStatus != N'HOLD'";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, RefreshData, mdlGeneral.Connection);
            string RefreshSaleData = "Delete from sale_master_temp";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, RefreshSaleData, mdlGeneral.Connection);
            lblDate.Text = Strings.Format(DateTime.Now.Date, "MMMM, dd - yyyy");
            txtCode.Clear();
            SortID = 1;
            mdlGeneral.gblDiscount = 0L;
            LastSaleID = 0;
            mdlGeneral.gblDiscount = 0L;
            txtCustomerName.Text = "Cash Customer";
            lblDiscount.Text = 0.ToString();
            lblDiscount.Visible = false;
            lblMode.Text = "Sale";
            lblNum2Word.Text = string.Empty;
            lblCustID.Text = "00";
            lblCustID.Text = string.Empty;
            txtPaid.Text = "00";
            lblRefund.Text = "00";
            lblSaleType.Text = "Cash Sale";
            lblCustomer.Text = "No Customer Selected";
            lblInvoice.Text = GetMax_ID(lblInvoice.Text).ToString();
            lblSequence.Text = Strings.Format(DateTime.Now.Date, "MMddyyyy") + Strings.Format(Convert.ToInt32(GetDetail_ID(lblSequence.Text.Trim())), "0000");
            Popup_DataGrid();
            Get_Total("SALE_DETAIL_TEMP");
            SaleMode = false;
            SaleReturn = true;
            DiscountAllow = false;
            cmdSaleReturn.Enabled = true;
            CountHoldSale();
            txtCode.Focus();
            for (int i = SaleDataGrid.Rows.Count - 1; i >= 0; i -= 1)
            {
                SaleDataGrid.Rows.RemoveAt(i);
            }
        }

        private void cmdReturn_Click(object sender, EventArgs e)
        {
            if (SaleMode == true)
                lblMode.Text = "Return";
            txtCode.Focus();
        }

        private void cmdCustomer_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.WaiterCode.ShowDialog(this);
            if (Strings.Len(mdlGeneral.gblCP_ID) > 0)
            {
                lblCustomer.Text = mdlGeneral.gblCP;
                lblSaleType.Text = "Account Sale";
                lblCustID.Text = mdlGeneral.gblCP_ID;
                lblCustID.Text = mdlGeneral.gblCP;
            }
            txtCode.Focus();
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                if (Strings.Len(txtCustomerName.Text.Trim()) > 0)
                    lblSaleType.Text = "Customer Sale";
                else
                    lblSaleType.Text = "Cash Sale";
                lblCustID.Text = Strings.StrConv(txtCustomerName.Text.Trim(), VbStrConv.ProperCase);
                txtCustomerName.Visible = false;
                txtCode.Focus();
            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateAlphaKeyPress(sender, e, txtCustomerName);
        }

        private void txtCustomerName_LostFocus(object sender, EventArgs e)
        {
            if (Strings.Len(txtCustomerName.Text.Trim()) > 0)
                lblSaleType.Text = "Customer Sale";
            else
            lblSaleType.Text = "Cash Sale";
            txtCode.Focus();
        }

        private void cmdDiscount_Click(object sender, EventArgs e)
        {
            if (SaleMode == true)
            {
                mdlGeneral.gblDiscount = Conversions.ToLong(Interaction.InputBox("Please Enter Allowed Discount.", My.MyProject.Application.Info.ProductName, "only digit"));
                if (string.IsNullOrEmpty(mdlGeneral.gblDiscount.ToString()))
                {
                    mdlGeneral.gblDiscount = 0L;
                    return;
                }
                if (Information.IsNumeric(mdlGeneral.gblDiscount) & Conversion.Val(mdlGeneral.gblDiscount) > 0d)
                {
                    DiscountAllow = true;
                    lblDiscHdr.Visible = true;
                    lblDiscount.Visible = true;
                    if (Conversion.Val(txtPaid.Text) > 0d)
                        txtPaid.Text = (Conversion.Val(lblOrgPrice.Text.Trim()) - mdlGeneral.gblDiscount).ToString();
                    lblDiscount.Text = Strings.Format(mdlGeneral.gblDiscount, "0.00");
                    ValidateDiscount(sender, e);
                }
            }
            else
            {
                mdlGeneral.gblMessage = "There is no item for discount.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
            }
            txtCode.Focus();
        }

        //private void lblQty_Click(object sender, EventArgs e)
        //{
        //    if (lblMode.Text != "Delete")
        //    {
        //        txtQty.Visible = true;
        //        txtQty.Focus();
        //        txtQty.SelectAll();
        //    }
        //}

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (SaleMode == true & lblMode.Text != "Delete")
                lblMode.Text = "Delete";
            txtCode.Focus();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            double price = 0;
            if (e.KeyCode == Keys.Escape)
            {
                txtPaid.Focus();
                return;
            }
            
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtQty.Text) || Conversion.Val(txtQty.Text.Trim()) == 0)
                {
                    MessageBox.Show("Plz. give qty / wieght to place order.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQty.Focus();
                    return;
                }
                using (SqlConnection conn = new SqlConnection("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;"))
                {
                    using var sqlcom = new SqlCommand("SELECT PROD_CD, PROD_DESC, PROD_PACK, PROD_SPRICE from products where PROD_CD = N'" + txtCode.Text.Trim() + "' ORDER BY PROD_DESC", conn);
                    {
                        conn.Open();
                        using var reader = sqlcom.ExecuteReader();
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ItemCode = reader.GetString(0);
                                    ItemName = reader.GetString(1);
                                    ItemPack = reader.GetString(2);
                                    price = (double)reader.GetDouble(3);
                                    ItemPrice = price.ToString();
                                    Weight = txtQty.Text;
                                    Handles_SettleOrder();
                                    CalculateTotals();
                                    SaleMode = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is no Item in stock. / Invalid Code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtCode.Focus();
                                return;
                            }
                        }
                    }
                }

                //string TempDetailSale = string.Empty;
                //string StockInfo = "select * from products where prod_cd = N'" + txtCode.Text.Trim() + "'";
                //mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SaleDataAdapter, StockInfo, mdlGeneral.Connection);
                //var GetStockInfo = mdlGeneral.SaleDataAdapter.SelectCommand.ExecuteReader();
                //if (GetStockInfo.HasRows)
                //{
                //    while (GetStockInfo.Read())
                //    {
                //        if (CheckItemExist("SALE_DETAIL_TEMP") == false)
                //        {
                //            TempDetailSale = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO SALE_DETAIL_TEMP VALUES (" + Conversion.Val(Strings.Mid(lblSequence.Text.Trim(), 9, 4)) + ",'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "'," + Conversion.Val(lblInvoice.Text.Trim()) + ",'" + lblSaleType.Text.Trim() + "'," + Conversion.Val(lblCustID.Text.Trim()) + ",'" + lblCustID.Text.Trim() + "','" + txtCode.Text.Trim() + "','" + GetStockInfo["PROD_DESC"].ToString().Trim() + "','" + "PARCEL" + "',", GetStockInfo["PROD_SPRICE"]), ","), Conversion.Val(txtQty.Text)), ","), Operators.MultiplyObject(GetStockInfo["PROD_SPRICE"], Conversion.Val(txtQty.Text))), ",'ADDED',"), lblUserID.Text.Trim()), ",0,0,0,0,0,'x',"), SortID), ")"));
                //            SaleMode = true;
                //            SortID += 1;
                //        }
                //        else if (SaleMode == true)
                //        {
                //            TempDetailSale = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE SALE_DETAIL_TEMP SET QTY = QTY + " + Conversion.Val(txtQty.Text) + ", PRICE = PRICE + ", Operators.MultiplyObject(GetStockInfo["PROD_SPRICE"], Conversion.Val(txtQty.Text))), " WHERE SALEID = N'"), Conversion.Val(lblInvoice.Text.Trim())), "' AND STOCKID = N'"), txtCode.Text.Trim()), "'"));
                //            if (lblMode.Text == "Delete")
                //                TempDetailSale = "DELETE FROM SALE_DETAIL_TEMP WHERE SALEID = N'" + Conversion.Val(lblInvoice.Text.Trim()) + "' AND STOCKID = N'" + txtCode.Text.Trim() + "'";
                //            if (lblMode.Text == "Return")
                //                TempDetailSale = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE SALE_DETAIL_TEMP SET QTY = QTY - " + Conversion.Val(txtQty.Text) + ", PRICE = PRICE - ", Operators.MultiplyObject(GetStockInfo["PROD_SPRICE"], Conversion.Val(txtQty.Text))), " WHERE SALEID = N'"), Conversion.Val(lblInvoice.Text.Trim())), "' AND STOCKID = N'"), txtCode.Text.Trim()), "'"));
                //        }
                //        mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, TempDetailSale, mdlGeneral.Connection);
                //        txtQty.Text = "1";
                txtQty.Text = "0";
                //        lblMode.Text = "Sale";
                //        Popup_DataGrid();
                //        Get_Total("SALE_DETAIL_TEMP");
                //        lblTotalPrice_Validated(sender, e);
                txtPaid.Enabled = true;
                SaleReturn = false;
                //        txtCode.Clear();
                //        txtCode.Focus();
                //    }
                //}
                //else
                //{
                //    mdlGeneral.gblMessage = "Prodcut not available, Please check Stock.";
                //    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                txtCode.Clear();
                txtCode.Focus();
                //}
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtQty, txtQty);
        }

        private void lblSaleType_MouseClick(object sender, MouseEventArgs e)
        {
            //txtCustomerName.Visible = true;
            //txtCustomerName.Focus();
        }

        private void txtPaid_GotFocus(object sender, EventArgs e)
        {
            txtPaid.Text = (Conversion.Val(lblOrgPrice.Text.Trim()) - mdlGeneral.gblDiscount).ToString();
            txtPaid.SelectAll();
        }

        private void lblTotalPrice_Validating(object sender, CancelEventArgs e)
        {
            decimal currency;

            // Convert the current value to currency, with or without a currency symbol.
            if (!decimal.TryParse(lblTotalPrice.Text, System.Globalization.NumberStyles.Currency, null, out currency))


            {
                // Don't let the user leave the field if the value is invalid.
                {
                    var withBlock = lblTotalPrice;
                    // .HideSelection = False
                    // .SelectAll()
                    MessageBox.Show("Please enter a valid currency amount.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // .HideSelection = True
                }

                e.Cancel = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void lblTotalPrice_Validated(object sender, EventArgs e)
        {
            // Display the value as local currency.
            lblTotalPrice.Text = decimal.Parse(lblTotalPrice.Text).ToString("c");
        }

        private void ValidateDiscount(object sender, EventArgs e)
        {
            if (DiscountAllow == true)
            {
                lblTotalPrice.Text = (Conversion.Val(lblOrgPrice.Text.Trim()) - mdlGeneral.gblDiscount).ToString();
                lblTotalPrice_Validated(sender, e);
            }
        }

        private void txtPaid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Payment = Conversion.Val(lblOrgPrice.Text.Trim()) - mdlGeneral.gblDiscount;
                // If Val(txtPaid.Text.Trim) < Payment Then gblMessage = "Payment Less than Total Price." : frmMsgStatus.ShowDialog(Me) : Exit Sub
                // If Val(txtPaid.Text.Trim) > Payment Then lblRefund.Text = Val(txtPaid.Text.Trim) - Payment
                lblRefund.Text = (Conversion.Val(txtPaid.Text.Trim()) - Payment).ToString();
                // cmdSave.Enabled = True
                cmdSave.Focus();
            }
        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtCode, txtCode);
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            mdlGeneral.gblFind = LastSaleID.ToString();
            mdlGeneral.gblReportOption = "RECEIPT";
            mdlGeneral.gblReportName = Application.StartupPath + @"\Reports\CashReceipt.rpt";
            mdlGeneral.Print_Slips_Manually();
        }

        private void frmSale_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void frmSale_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void frmSale_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        #region Runtime Functions and Event Handlers
        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { txtPaid.Focus(); }
            if (e.KeyCode == Keys.Enter) { txtQty.Focus(); }
        }

        private bool CheckItemExist(string tblName)
        {

            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";

            string cmdText = "SELECT * FROM " + tblName.Trim() + " WHERE (SALEID = N'" + Conversion.Val(lblInvoice.Text.Trim()) + "' AND STOCKID = N'" + txtCode.Text.Trim() + "' AND SALESTATUS != N'HOLD')";

            bool bRet = false;

            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        bRet = reader.HasRows;
                    }
                }
            }
            return bRet;
        }

        private void cmdCustomerList_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CustomerList.ShowDialog(this);
            if (Strings.Len(mdlGeneral.gblCustId) > 0)
            {
                lblCustID.Text = mdlGeneral.gblCustId.ToString();
                txtCustomerName.Text = mdlGeneral.gblCustName;
            }
            txtCode.Focus();
        }

        private void txtCustomerName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.CustomerList.ShowDialog(this);
                if (Strings.Len(mdlGeneral.gblCustId) > 0)
                { 
                    lblCustID.Text = mdlGeneral.gblCustId.ToString();
                    txtCustomerName.Text = mdlGeneral.gblCustName.ToString();
                    }
                txtCode.Focus();
            }
        }

        private void lblCustID_DoubleClick(object sender, EventArgs e)
        {
            My.MyProject.Forms.CustomerList.ShowDialog(this);
            if (Strings.Len(mdlGeneral.gblCustId) > 0)
            {
                txtCustomerName.Text = mdlGeneral.gblCustName.ToUpper();
                lblCustID.Text = mdlGeneral.gblCustId.ToString ();
            }
            txtCode.Focus();
        }

        private void CbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQty.Text = CbQuantity.Text.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Popup_DataGrid()
        {
            try
            {
                RecordDataSet.Clear();
                string CommandText = "SELECT * FROM SALE_DETAIL_TEMP WHERE SaleStatus != N'HOLD' AND SALEID = N'" + Conversion.Val(lblInvoice.Text.Trim()) + "' ORDER BY SORTITEM";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "SALE_DETAIL_TEMP", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(RecordDataSet, "SALE_DETAIL_TEMP");
                SaleBindingSource.DataSource = RecordDataSet;
                SaleBindingSource.DataMember = "SALE_DETAIL_TEMP";
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
            mdlGeneral.Connection.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Get_Total(string tblName)
        {
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            string cmdText = "SELECT SUM(QTY) AS TOTAL_QTY, SUM(PRICE) AS TOTAL_PRICE FROM " + tblName.Trim() + " WHERE (SALEID = N'" + Conversion.Val(lblInvoice.Text.Trim()) + "') AND (SaleStatus != N'HOLD')";
            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblOrgPrice.Text = Strings.Format(Conversion.Val(reader["TOTAL_PRICE"].ToString().Trim()), "0.00");
                            lblTotalPrice.Text = Strings.Format(Conversion.Val(reader["TOTAL_PRICE"].ToString().Trim()), "0.00");
                            lblTax.Text = (Conversion.Val(lblOrgPrice.Text.Trim()) * 0.14).ToString();
                            TotalQty = Conversion.Val(reader["TOTAL_QTY"].ToString());
                            if (Conversion.Val(lblOrgPrice.Text) > 0)
                                lblNum2Word.Text = mdlGeneral.NumToWord((decimal)Convert.ToDouble(lblOrgPrice.Text)) + " Only";
                        }
                    }
                }
            }
        }

        private void cmdSuspend_Click(object sender, EventArgs e)
        {
            if (SaleMode == true)
            {
                string HoldQuery = string.Empty;
                string HoldStatus = "INSERT INTO POS.dbo.SALE_DETAIL_HOLD(DetailID,DetailDate,SaleID,SaleType,CustomerID,CustomerName,StockID,StockDesc,SalePack,UnitCost,Qty,Price,SaleStatus,DrawerID,TaxPercentage,PriceInc,TotalPriceExcl,TotalPriceInc,DiscountDetailID,AOptions,SortItem) " + "SELECT DetailID,DetailDate,SaleID,SaleType,CustomerID,CustomerName,StockID,StockDesc,SalePack,UnitCost,Qty,Price,SaleStatus,DrawerID,TaxPercentage,PriceInc,TotalPriceExcl,TotalPriceInc,DiscountDetailID,AOptions,SortItem FROM POS.dbo.SALE_DETAIL_TEMP " + "WHERE SaleID = N'" + Conversion.Val(lblInvoice.Text.Trim()) + "'";

                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, HoldStatus, mdlGeneral.Connection);

                if (CheckHoldExist("SALE_MASTER_HOLD", lblInvoice.Text.Trim()) == false)
                {

                    HoldQuery = "INSERT INTO SALE_MASTER_HOLD VALUES (" + Conversion.Val(lblInvoice.Text.Trim()) + "," + Conversion.Val(lblUserID.Text.Trim()) + ",'" + lblUserName.Text.Trim() + "','" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "','" + lblSaleType.Text.Trim() + "','" + lblSequence.Text.Trim() + "','" + Conversion.Val(lblCustID.Text.Trim()) + "','" + lblCustID.Text.Trim() + "'," + Conversion.Val(lblOrgPrice.Text.Trim()) + "," + Conversion.Val(txtPaid.Text.Trim()) + "," + Conversion.Val(lblDiscount.Text.Trim()) + "," + Conversion.Val(lblRefund.Text.Trim()) + "," + "1,0,0,0,'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "',0)";
                }
                else
                {
                    HoldQuery = "UPDATE SALE_MASTER_HOLD SET " + "DrawerID = N'" + Conversion.Val(lblUserID.Text.Trim()) + "'," + "DrawerName = N'" + lblUserName.Text.Trim() + "'," + "DateCompleted = N'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "','" + "SaleType = N'" + lblSaleType.Text.Trim() + " '," + "CustomerID = N'" + Conversion.Val(lblCustID.Text.Trim()) + "'," + "CustomerName = N'" + lblCustID.Text.Trim() + "'," + "SaleTotal = N'" + Conversion.Val(lblOrgPrice.Text.Trim()) + "'," + "SalePaid = N'" + Conversion.Val(txtPaid.Text.Trim()) + "'," + "SaleDiscount = N'" + Conversion.Val(lblDiscount.Text.Trim()) + "'," + "SaleChange = N'" + Conversion.Val(lblRefund.Text.Trim()) + "'," + "SaleStatus = 1 " + "WHERE SaleID = " + Conversion.Val(lblInvoice.Text.Trim());

                }

                using (var Conn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
                {
                    var Cmd = new SqlCommand(HoldQuery, Conn);
                    try
                    {
                        Conn.Open();
                        Cmd.ExecuteNonQuery();
                        lblHold.Text = (Conversion.Val(lblHold.Text.Trim()) + 1d).ToString();
                        cmdNew_Click(sender, e);
                    }
                    catch (Exception EX)
                    {
                        Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int GetMax_ID(string StringID)
        {
            int GetMax_IDRet = default;

            string MaxID_Text = "SELECT MAX(MaxID) as MaxSerial FROM " + "( " + "SELECT MAX(SALEID) as MaxID " + "FROM SALE_MASTER " + "GROUP BY SALEID " + "UNION ALL " + "SELECT MAX(SALEID) as MaxID " + "FROM SALE_DETAIL_TEMP " + "GROUP BY SaleID " + "UNION ALL " + "SELECT MAX(SALEID) as MaxID " + "FROM SALE_DETAIL_HOLD " + "GROUP BY SaleID " + ") as subQuery";
            using (var Conn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
            {
                var Cmd = new SqlCommand(MaxID_Text, Conn);
                try
                {
                    Conn.Open();
                    if (Cmd.ExecuteScalar() is DBNull)
                    {
                        GetMax_IDRet = 1;
                    }
                    else
                    {
                        GetMax_IDRet = (int)Math.Round(Convert.ToDecimal(Cmd.ExecuteScalar()) + 1);
                    }
                }
                catch (Exception EX)
                {
                    Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
                return GetMax_IDRet;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StringID"></param>
        /// <returns></returns>
        public int GetDetail_ID(string StringID)
        {
            int GetDetail_IDRet = default;

            string MaxID_Text = "SELECT MAX(MaxID) as MaxSerial FROM " + "( " + "SELECT MAX(DETAILID) as MaxID " + "FROM SALE_DETAIL WHERE DETAILDATE = N'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "' " + "GROUP BY DetailID " + "UNION ALL " + "SELECT MAX(DETAILID) as MaxID " + "FROM SALE_DETAIL_TEMP WHERE DETAILDATE = N'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "' " + "GROUP BY DetailID " + "UNION ALL " + "SELECT MAX(DETAILID) as MaxID " + "FROM SALE_DETAIL_HOLD WHERE DETAILDATE = N'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "' " + "GROUP BY DetailID " + ") as subQuery";
            using (var Conn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
            {
                var Cmd = new SqlCommand(MaxID_Text, Conn);
                try
                {
                    Conn.Open();
                    if (Cmd.ExecuteScalar() is DBNull)
                    {
                        GetDetail_IDRet = 1;
                    }
                    else
                    {
                        GetDetail_IDRet = (int)Math.Round(Convert.ToDecimal(Cmd.ExecuteScalar()) + 1);
                    }
                }
                catch (Exception EX)
                {
                    Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
                return GetDetail_IDRet;
            }

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (SaleMode == true)
            {
                using (TransactionScope trans = new TransactionScope())
                {
                    double diff = 0;
                    diff = (double)Convert.ToDecimal(txtPaid.Text.ToString()) - (double)Convert.ToDecimal(lblTotalPrice.Text.ToString());
                    if (diff < 0)
                    {
                        MessageBox.Show("paid amount less than total payment.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        lblRefund.Text = diff.ToString();
                    }
                    using var Conn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;");
                    {
                        using var sqlcmd = new SqlCommand("INSERT INTO SALE_MASTER VALUES (" + Convert.ToDecimal(lblInvoice.Text.Trim()) + "," + Convert.ToInt32(lblUserID.Text.Trim()) + ",'" + lblUserName.Text.Trim() + "','" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "','" + lblSaleType.Text.Trim() + "','" + lblSequence.Text.Trim() + "','" + Conversion.Val(lblCustID.Text) + "','" + txtCustomerName.Text + "'," + Convert.ToDecimal(lblTotalPrice.Text.Trim()) + "," + Convert.ToDecimal(txtPaid.Text.Trim()) + "," + Convert.ToDecimal(lblDiscount.Text.Trim()) + "," + Convert.ToDecimal(lblRefund.Text.Trim()) + "," + "0,0,0,0,'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "',0)", Conn);
                        {
                            Conn.Open();
                            sqlcmd.CommandTimeout = 0;
                            sqlcmd.CommandType = System.Data.CommandType.Text;
                            sqlcmd.ExecuteNonQuery();
                        }
                    }
                    foreach (DataGridViewRow row in SaleDataGrid.Rows)
                    {
                        using var sqlconn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;");
                        {
                            int i = 0;
                            using var sqlcmd = new SqlCommand("INSERT INTO SALE_DETAIL VALUES (" + Convert.ToDecimal(lblSequence.Text.Trim()) + ",'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "'," + Convert.ToDecimal(lblInvoice.Text.Trim()) + ",'" + lblSaleType.Text.Trim() + "'," + Convert.ToInt32(lblCustID.Text.Trim()) + ",'" + txtCustomerName.Text.Trim() + "','" + row.Cells[4].Value + "','" + row.Cells[0].Value + "','" + row.Cells[5].Value + "'," + row.Cells[1].Value + "," + row.Cells[2].Value + "," + row.Cells[3].Value + ",'ADDED'," + lblUserID.Text.Trim() + ",0,0,0,0,0,'TAKE AWAY'," + i + ")", sqlconn);
                            {
                                sqlcmd.CommandType = System.Data.CommandType.Text;
                                sqlcmd.CommandTimeout = 0;
                                sqlconn.Open();
                                sqlcmd.ExecuteNonQuery();
                                i++;
                            }
                        }
                    }
                    //cmdSave.Enabled = false;
                    SaleReturn = true;
                    //cmdPrint_Click(sender, e);
                    cmdNew_Click(sender, e);
                    trans.Complete();
                }
            }
        }

        private void CountHoldSale()
        {
            string Count = "Select count(distinct SaleID) from SALE_DETAIL_HOLD";
            using (var Conn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
            {
                var Cmd = new SqlCommand(Count, Conn);
                try
                {
                    Conn.Open();
                    if (Cmd.ExecuteScalar() is DBNull)
                    {
                        lblHold.Text = 0.ToString();
                    }
                    else
                    {
                        lblHold.Text = Convert.ToDecimal(Cmd.ExecuteScalar()).ToString();
                    }
                }
                catch (Exception EX)
                {
                    Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
            }
        }

        private void lblHold_DoubleClick(object sender, EventArgs e)
        {
            if (Conversion.Val(lblHold.Text) == 0)
                return;
            mdlGeneral.gblCP_ID = 0.ToString();
            My.MyProject.Forms.HoldSale.ShowDialog(this);
            if (Conversion.Val(mdlGeneral.gblCP_ID.Trim()) == 0)
                return;

            // Shift Hold Sale to Main Window
            string ChangeStatus = "INSERT INTO POS.dbo.SALE_DETAIL_TEMP(DetailID,DetailDate,SaleID,SaleType,CustomerID,CustomerName,StockID,StockDesc,SalePack,UnitCost,Qty,Price,SaleStatus,DrawerID,TaxPercentage,PriceInc,TotalPriceExcl,TotalPriceInc,DiscountDetailID,AOptions,SortItem) " + "SELECT DetailID,DetailDate,SaleID,SaleType,CustomerID,CustomerName,StockID,StockDesc,SalePack,UnitCost,Qty,Price,SaleStatus,DrawerID,TaxPercentage,PriceInc,TotalPriceExcl,TotalPriceInc,DiscountDetailID,AOptions,SortItem FROM POS.dbo.SALE_DETAIL_HOLD " + "WHERE SaleID = N'" + Conversion.Val(mdlGeneral.gblCP_ID) + "'";

            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, ChangeStatus, mdlGeneral.Connection);
            string ReleaseSale = "SELECT * FROM SALE_MASTER_HOLD WHERE SALEID = N'" + Conversion.Val(mdlGeneral.gblCP_ID) + "' ORDER BY SALEID";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.TransferAdapter, ReleaseSale, mdlGeneral.Connection);
            var ReleaseRec = mdlGeneral.TransferAdapter.SelectCommand.ExecuteReader();
            if (ReleaseRec != null)
            {
                while (ReleaseRec.Read())
                {
                    lblInvoice.Text = ReleaseRec["SALEID"].ToString();
                    lblSaleType.Text = ReleaseRec["SALETYPE"].ToString();
                    lblSequence.Text = ReleaseRec["OFFLINEID"].ToString();
                    lblCustID.Text = ReleaseRec["CUSTOMERID"].ToString();
                    lblCustID.Text = ReleaseRec["CUSTOMERNAME"].ToString();
                    lblOrgPrice.Text = ReleaseRec["SALETOTAL"].ToString();
                }
            }
            Popup_DataGrid();
            Get_Total("SALE_DETAIL_TEMP");
            lblTotalPrice_Validated(sender, e);
            txtPaid.Enabled = true;
            SaleMode = true;
            cmdSaleReturn.Enabled = false;
            txtCode.Clear();
            txtCode.Focus();
        }

        private bool CheckHoldExist(string tblName, string strFind)
        {

            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            string cmdText = "SELECT * FROM " + tblName.Trim() + " WHERE (SALEID = N'" + Conversion.Val(strFind) + "')";
            bool bRet = false;
            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        bRet = reader.HasRows;
                    }
                }
            }
            return bRet;
        }

        private void cmdSaleReturn_Click(object sender, EventArgs e)
        {
            string ReturnQuery = string.Empty;
            if (SaleMode == true)
            {
                Get_Total("SALE_DETAIL_TEMP");
                string DetailID = Strings.Mid(lblSequence.Text, 9, 4);
                ReturnQuery = "INSERT INTO SALE_MASTER VALUES (" + Conversion.Val(lblInvoice.Text.Trim()) + "," + Conversion.Val(lblUserID.Text.Trim()) + ",'" + lblUserName.Text.Trim() + "','" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "','" + "Sale Return" + "','" + lblSequence.Text.Trim() + "','" + Conversion.Val(lblCustID.Text.Trim()) + "','" + lblCustID.Text.Trim() + "'," + "0" + "," + "0" + "," + "0" + "," + "0" + "," + "2,0," + Conversion.Val(lblOrgPrice.Text.Trim()) + ",0,'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "',0)";
                using (var Conn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
                {
                    var Cmd = new SqlCommand(ReturnQuery, Conn);
                    // Try
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                    // Catch EX As Exception
                    // MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                    // End Try
                }
                // save detail to sale detail table
                string SaleDetail = "INSERT INTO SALE_DETAIL SELECT * FROM SALE_DETAIL_TEMP WHERE SaleStatus != N'HOLD' and DetailID = N'" + Conversion.Val(DetailID) + "' and SaleID = N'" + Conversion.Val(lblInvoice.Text.Trim()) + "' and DetailDate = N'" + Strings.Format(DateTime.Parse(lblDate.Text.Trim()), "MM/dd/yyyy") + "'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, SaleDetail, mdlGeneral.Connection);
                LastSaleID = (int)Math.Round(Conversion.Val(lblInvoice.Text.Trim()));
                // To give minus sign to retrun product
                string UpdateMinusSign = "update sale_detail set QTY = QTY * -1, PRICE = PRICE * -1 WHERE SaleID = N'" + Conversion.Val(lblInvoice.Text.Trim()) + "'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SaleDataAdapter, UpdateMinusSign, mdlGeneral.Connection);
                // To update journal transactions if credit customer info given // only for pro version
                cmdNew_Click(sender, e);
            }
            else
            {
                mdlGeneral.gblMessage = "Please first add product to return.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
            }
        }

        private void UpdateStockQuantity()
        {
            Items = string.Empty;
            string SelectQty = "SELECT StockID,StockDesc,SUM(QTY) AS StockQty FROM SALE_DETAIL WHERE SaleID = N'" + LastSaleID + "' GROUP BY StockID, StockDesc";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.EntryDataAdpter, SelectQty, mdlGeneral.Connection);
            var Updater = mdlGeneral.EntryDataAdpter.SelectCommand.ExecuteReader();
            if (Updater.HasRows)
            {
                while (Updater.Read())
                {
                    Items = Items.Trim() + Updater["StockDesc"].ToString() + ", ";
                    ProductQty = (int)Math.Round(Conversion.Val(Updater["StockQty"].ToString()));
                    ProductID = Updater["StockID"].ToString();
                    // Get quantity balances with scheme if are available
                    string PrevQuantity = "SELECT PROD_ONHAND, PROD_SCH1_ONHAND, PROD_SCH2_ONHAND, PROD_SCH3_ONHAND FROM PRODUCTS WHERE PROD_CD = N'" + ProductID.Trim() + "'";
                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.ProductAdapter, PrevQuantity, mdlGeneral.Connection);
                    var QtyAdjuster = mdlGeneral.ProductAdapter.SelectCommand.ExecuteReader();
                    if (QtyAdjuster.HasRows == true)
                    {
                        QtyAdjuster.Read();
                        Q4 = (int)Math.Round(Conversion.Val(QtyAdjuster["PROD_SCH3_ONHAND"].ToString()));
                        Q3 = (int)Math.Round(Conversion.Val(QtyAdjuster["PROD_SCH2_ONHAND"].ToString()));
                        Q2 = (int)Math.Round(Conversion.Val(QtyAdjuster["PROD_SCH1_ONHAND"].ToString()));
                        Q1 = (int)Math.Round(Conversion.Val(QtyAdjuster["PROD_ONHAND"].ToString()));
                        // If Scheme3 has value
                        if (ProductQty > 0)
                        {
                            if (Q4 <= ProductQty)
                            {
                                ProductQty = ProductQty - Q4;
                                Q4 = ProductQty;
                                ExecuteUpdateQuery("PROD_SCH3_ONHAND", "0", ProductID);
                            }

                            if (Q4 > ProductQty)
                            {
                                ProductQty = Q4 - ProductQty;
                                Q4 = ProductQty;
                                ExecuteUpdateQuery("PROD_SCH3_ONHAND", ProductQty.ToString(), ProductID);
                            }
                        }
                        // If Scheme2 has value
                        if (ProductQty > 0)
                        {
                            if (Q3 <= ProductQty)
                            {
                                ProductQty = ProductQty - Q3;
                                Q3 = ProductQty;
                                ExecuteUpdateQuery("PROD_SCH2_ONHAND", "0", ProductID);
                            }

                            if (Q3 > ProductQty)
                            {
                                ProductQty = Q3 - ProductQty;
                                Q3 = ProductQty;
                                ExecuteUpdateQuery("PROD_SCH2_ONHAND", ProductQty.ToString(), ProductID);
                            }
                        }
                        // If Scheme1 has value
                        if (ProductQty > 0)
                        {
                            if (Q2 <= ProductQty)
                            {
                                ProductQty = ProductQty - Q2;
                                Q2 = ProductQty;
                                ExecuteUpdateQuery("PROD_SCH1_ONHAND", "0", ProductID);
                            }

                            if (Q2 > ProductQty)
                            {
                                ProductQty = Q2 - ProductQty;
                                Q2 = ProductQty;
                                ExecuteUpdateQuery("PROD_SCH1_ONHAND", ProductQty.ToString(), ProductID);
                            }
                        }

                        // Update main stock
                        if (ProductQty > 0)
                        {
                            ProductQty = Q1 - ProductQty;
                            ExecuteUpdateQuery("PROD_ONHAND", ProductQty.ToString(), ProductID);
                        }
                        QtyAdjuster.Close();
                    }
                }
                if (Updater is null)
                    Updater.Close();
            }

        }

        private void UpdateReturnQuantity()
        {
            Items = string.Empty;
            FinalQty = 0;
            string SelectQty = "SELECT StockID,StockDesc,SUM(QTY) AS StockQty FROM SALE_DETAIL WHERE SaleID = N'" + LastSaleID + "' GROUP BY StockID, StockDesc";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.EntryDataAdpter, SelectQty, mdlGeneral.Connection);
            var Updater = mdlGeneral.EntryDataAdpter.SelectCommand.ExecuteReader();
            if (Updater.HasRows)
            {
                while (Updater.Read())
                {
                    Items = Items.Trim() + Updater["StockDesc"].ToString() + ", ";
                    ProductQty = (int)Math.Round(Conversion.Val(Updater["StockQty"].ToString()));
                    ProductID = Updater["StockID"].ToString();
                    // Get quantity balance for return products
                    string PrevQuantity = "SELECT PROD_ONHAND, PROD_SCH1_ONHAND, PROD_SCH2_ONHAND, PROD_SCH3_ONHAND FROM PRODUCTS WHERE PROD_CD = N'" + ProductID.Trim() + "'";
                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.ProductAdapter, PrevQuantity, mdlGeneral.Connection);
                    var QtyAdjuster = mdlGeneral.ProductAdapter.SelectCommand.ExecuteReader();
                    if (QtyAdjuster.HasRows == true)
                    {
                        QtyAdjuster.Read();
                        Q1 = (int)Math.Round(Conversion.Val(QtyAdjuster["PROD_ONHAND"].ToString()));
                        FinalQty = Q1 + ProductQty;
                        ExecuteUpdateQuery("PROD_ONHAND", FinalQty.ToString(), ProductID);
                        QtyAdjuster.Close();
                    }
                }
                if (Updater is null)
                    Updater.Close();
            }
        }

        private void ExecuteUpdateQuery(string TableField, string FieldQty, string StockID)
        {
            // Passes values to update table fields
            string UpdateQty = "UPDATE PRODUCTS SET " + TableField.Trim() + " = " + Conversion.Val(FieldQty.Trim()) + " WHERE PROD_CD = N'" + StockID.ToString().Trim() + "'";
            using (var Conn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
            {
                var Cmd = new SqlCommand(UpdateQty, Conn);
                try
                {
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception EX)
                {
                    Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
            }
        }

        private void Updt_General_Journal(double strPrice, double Total_Qty, int Cust_Code, string strDate, string strDesc, string strType)
        {
            string cmdText = string.Empty;
            // To made general journal transaction for concerned suppliers while update products
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            double Trans_ID, Opn_Bal, Clo_Bal;
            string Customer_Name = string.Empty;
            Trans_ID = 0d;
            Opn_Bal = 0d;
            Clo_Bal = 0d;

            double Max_Tr = mdlGeneral.GenerateMax_ID("CUSTOMERS_PAYM", "CUST_TR_ID");
            string Get_Supplier = "select * from customers where cust_code = " + Cust_Code;
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.Suppliers, Get_Supplier, mdlGeneral.Connection);
            var SuppliersReader = mdlGeneral.Suppliers.SelectCommand.ExecuteReader();
            if (SuppliersReader.HasRows)
            {
                while (SuppliersReader.Read())
                {
                    Customer_Name = SuppliersReader["CUST_NAME"].ToString().Trim();
                    Opn_Bal = Conversion.Val(SuppliersReader["CUST_BALANCE"].ToString().Trim());
                }
                if (SuppliersReader is null)
                    SuppliersReader.Close();
            }
            else
            {
                Opn_Bal = 0d;
            }

            Trans_ID = mdlGeneral.GenerateMax_ID("CUSTOMERS_PAYM", "CUST_TR_ID");
            if (strType.Trim() == "CR")
                Clo_Bal = Opn_Bal + strPrice;
            else
                Clo_Bal = Opn_Bal - strPrice;

            if (strType.Trim() == "CR")
            {
                cmdText = "INSERT INTO CUSTOMERS_PAYM VALUES ('" + Cust_Code + "','" + Strings.Format(DateTime.Parse(lblDate.Text.ToString()), "MM/dd/yyyy") + "','" + Trans_ID + "','" + Customer_Name + "','" + "Purchases (" + strDesc.Trim() + ") Qty. (" + Total_Qty + ") Invoice # " + lblInvoice.Text.Trim() + "'," + Opn_Bal + "," + Conversion.Val(txtPaid.Text.Trim()) + "," + strPrice + "," + Clo_Bal + ",'" + Strings.Format(DateTime.Parse(strDate.ToString()), "MM/dd/yyyy") + "')";
            }
            else
            {
                cmdText = "INSERT INTO CUSTOMERS_PAYM VALUES ('" + Cust_Code + "','" + Strings.Format(DateTime.Parse(lblDate.Text.ToString()), "MM/dd/yyyy") + "','" + Trans_ID + "','" + Customer_Name + "','" + "Purchases Return (" + strDesc.Trim() + ") Qty. (" + Total_Qty + ") Invoice # " + lblInvoice.Text.Trim() + "'," + Opn_Bal + "," + strPrice + ",0," + Clo_Bal + ",'" + Strings.Format(DateTime.Parse(strDate.ToString()), "MM/dd/yyyy") + "')";
            }

            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    try
                    {
                        sqlCmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message, MsgBoxStyle.Information);
                    }
                }
            }
        }
        #endregion

        #region Settle MenuOrder List
        private void cmdMenu_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FoodMenu.ShowDialog(this);
        }
        /// <summary>
        /// Add Food Menu List to DataGrid
        /// </summary>
        public void Handles_SettleOrder()
        {
            decimal subtotal = Convert.ToDecimal(ItemPrice) * Convert.ToDecimal(Weight);
            string[] row = [ItemName.ToUpper(),ItemPrice,Weight,subtotal.ToString(),ItemCode,ItemPack];
            SaleDataGrid.Rows.Add(row);
        }
        /// <summary>
        /// Get Totals
        /// </summary>
        public void CalculateTotals()
        {
            decimal Total = 0;
            for (int i = 0; i < SaleDataGrid.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(SaleDataGrid.Rows[i].Cells[3].Value.ToString());
            }
            if (lblDiscount.Visible == true)
            {
                Total -= Convert.ToDecimal(lblDiscount.ToString());
            }
            //lblTotalPrice.Text = decimal.Parse(Total.ToString()).ToString("c");
            lblTotalPrice.Text = Total.ToString("N2",CultureInfo.InvariantCulture);
            txtPaid.Text = Total.ToString("N0",CultureInfo.InvariantCulture);
        }
        #endregion
    }
}