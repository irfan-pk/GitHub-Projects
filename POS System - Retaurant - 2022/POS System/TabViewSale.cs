using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class TabViewSale
    {
        private string currentpath = Directory.GetCurrentDirectory();
        private bool FindbyQuery;
        private double Total, Paid, Discount, Credit, Final;
        private string MasterQuery, ChildQuery;
        private SqlDataAdapter DetailsDataAdapter;
        private SqlDataAdapter MasterDataAdapter;
        private string Choice, Cust_ID, Description;

        public TabViewSale()
        {
            InitializeComponent();
        }

        private void frmTabViewSale_Load(object sender, EventArgs e)
        {
            mdlGeneral.GetConnectionString();
            FormBorderStyle = FormBorderStyle.None;
            DotNetBarTabcontrol.SelectTab(0);
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab1);
        }

        private void Popup_SaleData(string TabChoice, BindingSource MasterObject, BindingSource ChildObject, DateTimePicker TabDate)
        {

            if (TabChoice == "CashSale")
            {
                MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit = 0 AND SaleReturn = 0 AND DateCompleted >= N'" + Strings.Format(DateTime.Parse(TabDate.Value.ToString()), "MM/dd/yyyy") + "' ORDER BY SaleID";
                ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit = 0 And SaleReturn = 0 And DateCompleted >= N'" + Strings.Format(DateTime.Parse(TabDate.Value.ToString()), "MM/dd/yyyy") + "' ORDER BY sale_master.SaleID";
                if (FindbyQuery == true)
                {
                    MasterQuery = null;
                    ChildQuery = null;
                    MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit = 0 AND SaleReturn = 0 AND SaleID = " + Conversion.Val(mdlGeneral.gblFind.Trim()) + " ORDER BY SaleID";
                    ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit = 0 And SaleReturn = 0 And SALE_MASTER.SaleID = " + Conversion.Val(mdlGeneral.gblFind.Trim()) + " ORDER BY sale_master.SaleID";
                }
            }

            if (TabChoice == "CreditSale")
            {
                MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit > 0 AND DateCompleted >= N'" + Strings.Format(DateTime.Parse(TabDate.Value.ToString()), "MM/dd/yyyy") + "' ORDER BY SaleID";
                ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit > 0 And DateCompleted >= N'" + Strings.Format(DateTime.Parse(TabDate.Value.ToString()), "MM/dd/yyyy") + "' ORDER BY sale_master.SaleID";
                if (FindbyQuery == true)
                {
                    MasterQuery = null;
                    ChildQuery = null;
                    MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleCredit > 0 AND SaleID = " + Conversion.Val(mdlGeneral.gblFind.Trim()) + " ORDER BY SaleID";
                    ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleCredit > 0 AND SALE_MASTER.SaleID = " + Conversion.Val(mdlGeneral.gblFind.Trim()) + " ORDER BY sale_master.SaleID";
                }
            }

            if (TabChoice == "SaleRecovery")
            {
                MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleRecovery > 0 AND DateRecovery >= N'" + Strings.Format(DateTime.Parse(TabDate.Value.ToString()), "MM/dd/yyyy") + "' ORDER BY SaleID";
                ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleRecovery > 0 And DateRecovery >= N'" + Strings.Format(DateTime.Parse(TabDate.Value.ToString()), "MM/dd/yyyy") + "' ORDER BY sale_master.SaleID";
                if (FindbyQuery == true)
                {
                    MasterQuery = null;
                    ChildQuery = null;
                    MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleRecovery > 0 AND SaleID = " + Conversion.Val(mdlGeneral.gblFind.Trim()) + " ORDER BY SaleID";
                    ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleRecovery > 0 AND SALE_MASTER.SaleID = " + Conversion.Val(mdlGeneral.gblFind.Trim()) + " ORDER BY sale_master.SaleID";
                }
            }

            if (TabChoice == "ReturnSale")
            {
                MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleReturn > 0 AND DateCompleted >= N'" + Strings.Format(DateTime.Parse(TabDate.Value.ToString()), "MM/dd/yyyy") + "' ORDER BY SaleID";
                ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleReturn > 0 And DateCompleted >= N'" + Strings.Format(DateTime.Parse(TabDate.Value.ToString()), "MM/dd/yyyy") + "' ORDER BY sale_master.SaleID";
                if (FindbyQuery == true)
                {
                    MasterQuery = null;
                    ChildQuery = null;
                    MasterQuery = "SELECT * FROM SALE_MASTER WHERE SaleReturn > 0 AND SaleID = " + Conversion.Val(mdlGeneral.gblFind.Trim()) + " ORDER BY SaleID";
                    ChildQuery = "SELECT * FROM SALE_MASTER JOIN sale_detail on SALE_DETAIL.SaleID = SALE_MASTER.SaleID WHERE SaleReturn > 0 AND SALE_MASTER.SaleID = " + Conversion.Val(mdlGeneral.gblFind.Trim()) + " ORDER BY sale_master.SaleID";
                }
            }

            // Clear dataset before refill with data relation
            mdlGeneral.gblRecordDataSet.Clear();
            if (mdlGeneral.gblRelation == true)
                mdlGeneral.gblRecordDataSet.Relations.Remove("MasterDetail");

            // Add data from the sale master table to the DataSet.
            MasterDataAdapter = new SqlDataAdapter(MasterQuery, mdlGeneral.Connection);
            MasterDataAdapter.Fill(mdlGeneral.gblRecordDataSet, "SALE_MASTER");

            // Add data from the sale detail table to the DataSet.
            DetailsDataAdapter = new SqlDataAdapter(ChildQuery, mdlGeneral.Connection);
            DetailsDataAdapter.Fill(mdlGeneral.gblRecordDataSet, "SALE_DETAIL");

            // Establish a relationship between the master and detail tables.
            var Relation = new DataRelation("MasterDetail", mdlGeneral.gblRecordDataSet.Tables["SALE_MASTER"].Columns["SaleID"], mdlGeneral.gblRecordDataSet.Tables["SALE_DETAIL"].Columns["SaleID"]);

            mdlGeneral.gblRecordDataSet.Relations.Add(Relation);
            mdlGeneral.gblRelation = true;

            // Bind the hold master data connector to the hold detail table.
            MasterObject.DataSource = mdlGeneral.gblRecordDataSet;
            MasterObject.DataMember = "SALE_MASTER";

            // Bind the details data connector to the master data connector,
            // using the DataRelation name to filter the information in the 
            // details table based on the current row in the master table. 
            ChildObject.DataSource = MasterBindingSource;
            ChildObject.DataMember = "MasterDetail";
            FindbyQuery = false;
        }

        private void cmdViewTab1_Click(object sender, EventArgs e)
        {
            DotNetBarTabcontrol.SelectTab(0);
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab1);
        }

        private void cmdViewTab2_Click(object sender, EventArgs e)
        {
            DotNetBarTabcontrol.SelectTab(1);
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab2);
        }

        private void DotNetBarTabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selected Tabpage one
            if (DotNetBarTabcontrol.SelectedIndex == 0)
                cmdViewTab1_Click(sender, e);
            // Selected Tabpage two
            if (DotNetBarTabcontrol.SelectedIndex == 1)
                cmdViewTab2_Click(sender, e);
            // Selected Tabpage three
            if (DotNetBarTabcontrol.SelectedIndex == 2)
                cmdViewTab3_Click(sender, e);
            // Selected Tabpage four
            if (DotNetBarTabcontrol.SelectedIndex == 3)
                cmdViewTab4_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdViewTab3_Click(object sender, EventArgs e)
        {
            DotNetBarTabcontrol.SelectTab(2);
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdViewTab4_Click(object sender, EventArgs e)
        {
            DotNetBarTabcontrol.SelectTab(3);
            Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab4);
        }

        private void dgMasterInfo1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // write down amount received procedure for concerned record
        }

        private void cmdFindTab1_Click(object sender, EventArgs e)
        {
            string SaleInvoice = Interaction.InputBox("Enter Sale Invoice # to find", "Find Sale Invoice", "only digit");
            if (string.IsNullOrEmpty(SaleInvoice.Trim()))
                return;
            if (Information.IsNumeric(SaleInvoice.Trim()) & Conversion.Val(SaleInvoice.Trim()) > 0d)
            {
                FindbyQuery = true;
                mdlGeneral.gblFind = SaleInvoice.Trim();
                Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab1);
            }
        }

        private void cmdFindTab2_Click(object sender, EventArgs e)
        {
            string SaleInvoice = Interaction.InputBox("Enter Sale Invoice # to find", "Find Sale Invoice", "only digit");
            if (string.IsNullOrEmpty(SaleInvoice.Trim()))
                return;
            if (Information.IsNumeric(SaleInvoice.Trim()) & Conversion.Val(SaleInvoice.Trim()) > 0d)
            {
                FindbyQuery = true;
                mdlGeneral.gblFind = SaleInvoice.Trim();
                Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab2);
            }
        }

        private void cmdFindTab3_Click(object sender, EventArgs e)
        {
            string SaleInvoice = Interaction.InputBox("Enter Sale Invoice # to find", "Find Sale Invoice", "only digit");
            if (string.IsNullOrEmpty(SaleInvoice.Trim()))
                return;
            if (Information.IsNumeric(SaleInvoice.Trim()) & Conversion.Val(SaleInvoice.Trim()) > 0d)
            {
                FindbyQuery = true;
                mdlGeneral.gblFind = SaleInvoice.Trim();
                Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab3);
            }
        }

        private void cmdFindTab4_Click(object sender, EventArgs e)
        {
            string SaleInvoice = Interaction.InputBox("Enter Sale Invoice # to find", "Find Sale Invoice", "only digit");
            if (string.IsNullOrEmpty(SaleInvoice.Trim()))
                return;
            if (Information.IsNumeric(SaleInvoice.Trim()) & Conversion.Val(SaleInvoice.Trim()) > 0d)
            {
                FindbyQuery = true;
                mdlGeneral.gblFind = SaleInvoice.Trim();
                Popup_SaleData(DotNetBarTabcontrol.SelectedTab.Name, MasterBindingSource, DetailBindingSource, dtDateTab4);
            }
        }

        private void cmdPayment_Click(object sender, EventArgs e)
        {
            // check and get values from datagrid highlighted row
            if (dgMasterInfo1.RowCount > 0)
            {
                if (Conversion.Val(dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[0].Value.ToString()) > 0d)
                {
                    mdlGeneral.gblCP_ID = Conversion.Val(dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[0].Value.ToString()).ToString();
                    mdlGeneral.gblCP = dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[1].Value.ToString();
                    Total = Conversion.Val(dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[3].Value.ToString());
                    Paid = Conversion.Val(dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[4].Value.ToString());
                    Discount = Conversion.Val(dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[5].Value.ToString());
                    Credit = Conversion.Val(dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[6].Value.ToString());
                    Cust_ID = dgChildInfo1.Rows[dgChildInfo1.CurrentRow.Index].Cells[1].Value.ToString();
                    Description = "Payment Received from " + dgChildInfo1.Rows[dgChildInfo1.CurrentRow.Index].Cells[2].Value.ToString();

                    string Detail = dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[0].Value.ToString() + " on " + dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[1].Value.ToString() + " of date " + Strings.Format(DateTime.Parse(dgMasterInfo1.Rows[dgMasterInfo1.CurrentRow.Index].Cells[2].Value.ToString()), "MM/dd/yyyy");
                    string SalePayment = Interaction.InputBox("Enter amount received against selected " + Constants.vbCrLf + "Invoice # " + Detail, "Payment", Credit.ToString());
                    if (string.IsNullOrEmpty(SalePayment.Trim()))
                        return;
                    if (Information.IsNumeric(SalePayment.Trim()) & Conversion.Val(SalePayment.Trim()) > 0d)
                    {
                        if (Conversion.Val(SalePayment.Trim()) > Credit)
                        {
                            mdlGeneral.gblMessage = "Payment Invalid";
                            My.MyProject.Forms.MsgStatus.ShowDialog(this);
                            return;
                        }
                        Discount = Credit - Conversion.Val(SalePayment.Trim());
                        Credit = Total - (Paid + Conversion.Val(SalePayment.Trim())) - Discount;
                        // query to update payment agains sale invoice
                        string UpdateQuery = "UPDATE SALE_MASTER SET SaleStatus = 0, SalePaid = SalePaid + " + Conversion.Val(SalePayment.Trim()) + ", SaleDiscount = SaleDiscount + " + Discount + ", SaleCredit = " + Credit + ", SaleRecovery = " + Conversion.Val(SalePayment.Trim()) + ", DateRecovery = N'" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString()), "MM/dd/yyyy") + "' WHERE SaleID = " + Conversion.Val(mdlGeneral.gblCP_ID.Trim());
                        try
                        {
                            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, UpdateQuery, mdlGeneral.Connection);
                            cmdViewTab2_Click(sender, e);
                        }
                        catch (Exception Msg)
                        {
                            mdlGeneral.gblMessage = Msg.Message;
                            My.MyProject.Forms.MsgStatus.ShowDialog(this);
                        }
                        // To update journal transactions if credit customer info given
                        if (Conversion.Val(Cust_ID.Trim()) > 0d)
                        {
                            if (Discount > 0d)
                            {
                                Description = Description + " & Got discount on payment Rs." + Discount;
                            }
                            Updt_General_Journal(Conversion.Val(SalePayment.Trim()) + Discount, (int)Math.Round(Conversion.Val(Cust_ID.Trim())), DateTime.Now.Date, Description, mdlGeneral.gblCP_ID);
                            if (CheckRecordExists(Conversion.Val(Cust_ID.Trim()).ToString(), "CUSTOMERS", "CUST_CODE") == true)
                            {
                                string Clos_Balance = "UPDATE CUSTOMERS SET " + "CUST_BALANCE = CUST_BALANCE - " + (Conversion.Val(SalePayment.Trim()) + Discount) + ", " + "CUST_UPD_DT = N'" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString()), "MM/dd/yyyy") + "' " + "WHERE CUST_CODE = N'" + Conversion.Val(Cust_ID.Trim()) + "'";


                                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Clos_Balance, mdlGeneral.Connection);
                            }
                        }
                    }
                }
                else
                {
                    mdlGeneral.gblMessage = "There is no selected sale invoice to update.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
            }
        }

        private void Updt_General_Journal(double strPrice, int Cust_Code, DateTime strDate, string strDesc, string strInvoice)
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
            Clo_Bal = Opn_Bal - strPrice;

            cmdText = "INSERT INTO CUSTOMERS_PAYM VALUES ('" + Cust_Code + "','" + Strings.Format(DateTime.Parse(Conversions.ToString(strDate)), "MM/dd/yyyy") + "','" + Trans_ID + "','" + Customer_Name + "','" + strDesc.Trim() + " Invoice # " + strInvoice.Trim() + "'," + Opn_Bal + "," + strPrice + ",0," + Clo_Bal + ",'" + Strings.Format(DateTime.Parse(strDate.ToString()), "MM/dd/yyyy") + "')";

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

        private bool CheckRecordExists(string strFind, string tblName, string strField)
        {
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            string cmdText = "SELECT * FROM " + tblName.Trim() + " WHERE (" + strField.Trim() + " = N'" + strFind.Trim() + "')";
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

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            mdlGeneral.gblReportOption = "STATEMENT";
            mdlGeneral.FromDate = dtFromDate.Value;
            mdlGeneral.ToDate = dtToDate.Value;
            if (rdDaily.Checked == true)
            {
                mdlGeneral.gblReportFilter = "CASH";
                mdlGeneral.gblReportName = currentpath + @"\" + @"Reports\CashSummary.rpt";
            }
            if (rdCredit.Checked == true)
            {
                mdlGeneral.gblReportFilter = "CREDIT";
                mdlGeneral.gblReportName = currentpath + @"\" + @"Reports\CreditSummary.rpt";
            }
            if (rdRecovery.Checked == true)
            {
                mdlGeneral.gblReportFilter = "RECOVERY";
                mdlGeneral.gblReportName = currentpath + @"\" + @"Reports\RecoverySummary.rpt";
            }
            if (rdReturn.Checked == true)
            {
                mdlGeneral.gblReportFilter = "RETURN";
                mdlGeneral.gblReportName = currentpath + @"\" + @"Reports\SaleReturnSummary.rpt";
            }
            My.MyProject.Forms.SummaryReports.MdiParent = My.MyProject.Forms.Main;
            My.MyProject.Forms.SummaryReports.Show();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}