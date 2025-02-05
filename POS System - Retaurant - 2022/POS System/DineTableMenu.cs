using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class DineTableMenu
    {
        private bool inputStatus, BillPaid;
        private bool hasDecimal, hasTable, hasOrder, hasWaiter;
        private string CustName, Status, TableNo;
        private BindingSource MyBindingSource = new BindingSource();
        private bool TableChange, Addition, EditMode;
        private string ItemName, ItemQty, ItemCode, OldTableNo;
        private string[] FirstMenu = new string[101];
        private int SortID;
        private string InsertCustomer, EditCustomer, CustomerID;
        private bool clearDisplay = false;

        public DineTableMenu()
        {
            InitializeComponent();
        }

        #region Forms Event
        private void frmDineTable_Load(object sender, EventArgs e)
        {
            // First time check if any unpaid bill is in pending
            Status = string.Empty;
            mdlGeneral.GetConnectionString();
            TableChange = false;
            hasWaiter = false;
            hasOrder = false;
            BillPaid = false;
            AddButtons();
            CheckTableReservation();
            CheckTableLock();
            cmdSelect.Text = "&Select" + Constants.vbCrLf + "Customer";
            cmdEdit.Text = "&Edit" + Constants.vbCrLf + "Customer";
            cmdNew.Text = "&New" + Constants.vbCrLf + "Customer";
            BackColor = Color.White;
            mdlGeneral.gblReservation = false;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (TableChange == true)
            {
                TabDine.SelectTab(1);
                TableChange = false;
                return;
            }
            Close();
        }

        #endregion

        #region Main Procedures
        private void TableButtonClick(object sender, EventArgs e)

        {
            Button ClickBtn = (Button)sender;
            TableNo = ClickBtn.Text;
            if (TableChange == true)
            {
                string LockCheck = "SELECT * FROM TABLE_DETAIL WHERE SaleTable = N'" + TableNo.Trim() + "' AND TableStatus = N'LOCKED'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, LockCheck, mdlGeneral.Connection);
                var Checker = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
                if (Checker.HasRows)
                {
                    mdlGeneral.gblMessage = OldTableNo.Trim() + " cannot be changed to " + TableNo.Trim() + ". Please select another table.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                string ChangeTable = "Update TABLE_DETAIL SET SaleTable = N'" + TableNo.Trim() + "' , CustomerID = N'" + Conversion.Val(Strings.Mid(TableNo.Trim(), 2, 2)) + "' WHERE SaleID = " + Conversion.Val(mdlGeneral.gblCP_ID.Trim()) + " AND SaleTable = N'" + OldTableNo.Trim() + "'";
                try
                {
                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, ChangeTable, mdlGeneral.Connection);
                    // From MSDN Forum
                    foreach (object Obj in tabReservation.Controls)
                    {
                        if (ReferenceEquals(Obj.GetType(), typeof(Button)))
                        {
                            ((Button)Obj).BackColor = Color.White;
                        }
                    }
                    CustomerID = TableNo.Trim();
                    CheckTableReservation();
                    UpdateMasterTable();
                    TableChange = false;
                }
                catch (Exception ex)
                {
                    mdlGeneral.gblMessage = ex.Message;
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
            }
            mdlGeneral.gblReservation = true;
            TabDine.SelectTab(1);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "New")
            {
                string TableLock = "UPDATE TABLE_DETAIL SET TableStatus = N'Unpaid' WHERE SaleID = N'" + Conversion.Val(OrderNo.Text.Trim()) + "' AND SaleTable = N'" + lblTable.Text.Trim() + "' AND TableStatus != N'LOCKED'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, TableLock, mdlGeneral.Connection);
            }
            if (hasWaiter == true)
            {
                if (string.IsNullOrEmpty(lblWaiter.Text) | lblWaiter.Text == "x")
                    mdlGeneral.gblMessage = "Please add table waiter name.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                return;
            }
            CheckTableReservation();
            CheckTableLock();
            TabDine.SelectTab(0);
        }

        private void cmdSettle_Click(object sender, EventArgs e)
        {
            if (hasOrder == true)
            {
                TabDine.SelectTab(3);
                lblFinalCustomer.Text = lblCustomer.Text;
                lblFinalTable.Text = lblTable.Text;
                lblFinalWaiter.Text = lblWaiter.Text;
                lblFinalSequence.Text = SequenceNo.Text;
                lblFinalStatus.Text = lblStatus.Text;
                lblFinalOrderNo.Text = OrderNo.Text.Trim();
                Popup_FinalDataGrid();
                Get_Total("TABLE_DETAIL");
            }
        }

        private void TabDine_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Procedures for Selected Tabpages
            if (TabDine.SelectedIndex == 1)
            {
                if (mdlGeneral.gblReservation == false)
                {
                    MessageBox.Show("Plz. Reserved table before order.", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mdlGeneral.gblReservation = false;
                    TabDine.SelectTab(0);
                    return;
                }
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, "SELECT DISTINCT DetailID, DetailDate, SaleID, SaleTable, AOptions, TableStatus FROM TABLE_DETAIL WHERE SaleTable = N'" + TableNo.Trim() + "'", mdlGeneral.Connection);
                var CheckTable = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
                if (CheckTable.HasRows)
                {
                    while (CheckTable.Read())
                    {
                        lblStatus.Text = CheckTable["TableStatus"].ToString();
                        SequenceNo.Text = Strings.Format(DateTime.Parse(CheckTable["DetailDate"].ToString()), "MMddyyyy") + Strings.Format(Conversion.Val(CheckTable["DetailID"]), "0000");
                        OrderNo.Text = CheckTable["SaleID"].ToString();
                        lblWaiter.Text = CheckTable["AOptions"].ToString();
                    }
                    if (Label5.Visible == false)
                    {
                        Label5.Visible = true;
                        lblOrgPrice.Visible = true;
                        Label9.Visible = true;
                        lblTaxes.Visible = true;
                    }
                    hasOrder = true;
                }
                else
                {
                    OrderNo.Text = GetMax_ID(OrderNo.Text.Trim()).ToString();
                    SequenceNo.Text = Strings.Format(DateTime.Now.Date, "MMddyyyy") + Strings.Format(Conversion.Val(GetDetail_ID(SequenceNo.Text.Trim())), "0000");
                    lblStatus.Text = "New";
                    lblWaiter.Text = "";
                    SortID = 1;
                    hasOrder = false;
                    Popup_DataGrid();
                    Get_Total("TABLE_DETAIL");
                }
                lblTable.Text = TableNo;
                if (Label5.Visible == false)
                {
                    Label5.Visible = true;
                    lblOrgPrice.Visible = true;
                    Label9.Visible = true;
                    lblTaxes.Visible = true;
                }
                if (lblStatus.Text.Trim() == "LOCKED")
                {
                    cmdChange.Enabled = false;
                    cmdCustomer.Enabled = false;
                    cmdPrint.Enabled = false;
                }
                else
                {
                    cmdChange.Enabled = true;
                    cmdCustomer.Enabled = true;
                    cmdPrint.Enabled = true;
                    cmdWaiter.Enabled = true;
                }
                Popup_DataGrid();
                Get_Total("TABLE_DETAIL");
                var MyControl = new Button();
                var MyEvent = new EventArgs();
                MyControl.Text = FirstMenu[0];
                ClickButton(MyControl, MyEvent);
            }

            if (TabDine.SelectedIndex == 3)
            {
                if (mdlGeneral.gblReservation == false)
                {
                    MessageBox.Show("Plz. Reserved table before order.", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mdlGeneral.gblReservation = false;
                    TabDine.SelectTab(0);
                    return;
                }
            }

            if (TabDine.SelectedIndex == 3)
            {
                cmdClose.Focus();
            }

        }

        private void AddButtons()
        {
            int I = 0;
            string MenuGroupQuery = "Select distinct PROD_CATG from PRODUCTS order by PROD_CATG";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, MenuGroupQuery, mdlGeneral.Connection);
            var GroupReader = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (GroupReader.HasRows)
            {
                while (GroupReader.Read())
                {
                    var MenuGroup = new Button();
                    MenuGroup.Text = GroupReader["PROD_CATG"].ToString().ToUpper().Trim();
                    MenuGroup.Size = new Size(170, 45);
                    MenuGroup.Font = new Font("Tahoma", 10.0f);
                    MenuGroup.Font = new Font(MenuGroup.Font, FontStyle.Bold);
                    MenuGroup.BackColor = Color.DeepSkyBlue;
                    MenuGroup.ForeColor = Color.White;
                    MenuGroup.TextAlign = ContentAlignment.MiddleCenter;
                    MenuGroup.FlatStyle = FlatStyle.Flat;
                    MenuGroup.FlatAppearance.BorderColor = Color.WhiteSmoke;
                    MenuGroup.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
                    MenuGroup.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
                    GroupFlowPanel.Controls.Add(MenuGroup);
                    FirstMenu[I] = MenuGroup.Text.Trim();
                    I += 1;
                    MenuGroup.Click += ClickButton;
                }
            }
        }

        // Result of (Click Button) event, get the text of button
        public void ClickButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // Populate Submenu Items and create menu buttons in flowpanel
            string SubItemsQuery = "SELECT distinct PROD_CATG, PROD_DESC from products where PROD_CATG = N'" + btn.Text.Trim() + "' ORDER BY PROD_DESC";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.TransferAdapter, SubItemsQuery, mdlGeneral.Connection);
            var ItemReader = mdlGeneral.TransferAdapter.SelectCommand.ExecuteReader();
            if (ItemReader.HasRows)
            {
                // To remove all items before add new
                for (int i = ItemFlowPanel.Controls.Count - 1; i >= 0; i -= 1)
                    ItemFlowPanel.Controls.RemoveAt(i);   // Here you actually provide the index!
                while (ItemReader.Read())
                {
                    var MenuItems = new Button();
                    MenuItems.Text = ItemReader["PROD_DESC"].ToString().ToUpper().Trim();
                    MenuItems.Size = new Size(120, 30);
                    MenuItems.Font = new Font("Tahoma", 8.25f);
                    MenuItems.BackColor = Color.DarkGreen;
                    MenuItems.Font = new Font(MenuItems.Font, FontStyle.Bold);
                    MenuItems.ForeColor = Color.White;
                    MenuItems.FlatStyle = FlatStyle.Flat;
                    MenuItems.TextAlign = ContentAlignment.MiddleCenter;
                    MenuItems.FlatAppearance.BorderColor = Color.Silver;
                    MenuItems.FlatAppearance.MouseDownBackColor = Color.Silver;
                    MenuItems.ForeColor = Color.WhiteSmoke;
                    ItemFlowPanel.Controls.Add(MenuItems);
                    MenuItems.Click += ItemButton;
                }
            }

        }

        // Result of (Click Button) event, get the text of button
        public void ItemButton(object sender, EventArgs e)
        {
            Button ItemBtn = (Button)sender;
            // Populate Items and add into order list
            if (string.IsNullOrEmpty(lblDisplay.Text) | lblDisplay.Text == "0" | lblDisplay.Text == "0.")
            {
                ItemQty = 1.ToString();
            }
            else
            {
                ItemQty = Conversion.Val(lblDisplay.Text.Trim()).ToString();
            }
            string TempDetailSale = string.Empty;
            string StockInfo = "select * from products where prod_desc = N'" + ItemBtn.Text.Trim() + "'";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SaleDataAdapter, StockInfo, mdlGeneral.Connection);
            var GetStockInfo = mdlGeneral.SaleDataAdapter.SelectCommand.ExecuteReader();
            if (GetStockInfo.HasRows)
            {
                while (GetStockInfo.Read())
                {
                    if (CheckItemExist(ItemBtn.Text.Trim(), "TABLE_DETAIL", "StockDesc", TableNo) == false)
                    {
                        TempDetailSale = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO TABLE_DETAIL VALUES (" + Conversion.Val(Strings.Mid(SequenceNo.Text.Trim(), 9, 4)) + ",'" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString()), "MM/dd/yyyy") + "'," + Conversion.Val(OrderNo.Text.Trim()) + ",'" + "TABLE" + "'," + Conversion.Val(Strings.Mid(SequenceNo.Text.Trim(), 9, 4)) + ",'" + lblCustomer.Text.Trim() + "','" + GetStockInfo["PROD_CD"].ToString().Trim() + "','" + GetStockInfo["PROD_DESC"].ToString().Trim() + "','" + TableNo.Trim().ToUpper() + "',", GetStockInfo["PROD_SPRICE"]), ","), Conversion.Val(ItemQty.Trim())), ","), Operators.MultiplyObject(GetStockInfo["PROD_SPRICE"], Conversion.Val(ItemQty.Trim()))), ",'"), lblStatus.Text.Trim()), "',"), mdlGeneral.UserID.Trim()), ",0,0,0,0,0,'x',"), SortID), ")"));
                        SortID += 1;
                        hasOrder = true;
                        hasWaiter = true;
                    }
                    else
                    {
                        // To double the quantity of subitem in gridview
                        TempDetailSale = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE TABLE_DETAIL SET QTY = QTY + " + Conversion.Val(ItemQty.Trim()) + ", PRICE = PRICE + ", Operators.MultiplyObject(GetStockInfo["PROD_SPRICE"], Conversion.Val(ItemQty.Trim()))), " WHERE SALEID = N'"), Conversion.Val(OrderNo.Text.Trim())), "' AND StockDesc = N'"), ItemBtn.Text.Trim()), "' AND SaleTable = N'"), lblTable.Text.Trim()), "'"));
                        hasOrder = true;
                        hasWaiter = true;
                    }
                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, TempDetailSale, mdlGeneral.Connection);
                    Popup_DataGrid();
                    Get_Total("TABLE_DETAIL");
                    CustomerID = lblTable.Text.Trim();
                    UpdateMasterTable();
                    lblDisplay.Text = string.Empty;
                }
            }
        }

        private void Popup_DataGrid()
        {
            try
            {
                RecordDataSet.Clear();
                string CommandText = "SELECT * FROM TABLE_DETAIL WHERE SaleTable = N'" + lblTable.Text.Trim() + "' ORDER BY SORTITEM";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "TABLE_DETAIL", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(RecordDataSet, "TABLE_DETAIL");
                SaleBindingSource.DataSource = RecordDataSet;
                SaleBindingSource.DataMember = "TABLE_DETAIL";
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
            mdlGeneral.Connection.Close();
        }

        private void Popup_FinalDataGrid()
        {
            try
            {
                FinalDataSet.Clear();
                string CommandText = "SELECT * FROM TABLE_DETAIL WHERE SaleTable = N'" + lblFinalTable.Text.Trim() + "' ORDER BY SORTITEM";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "TABLE_DETAIL", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(FinalDataSet, "TABLE_DETAIL");
                FinalBindingSource.DataSource = FinalDataSet;
                FinalBindingSource.DataMember = "TABLE_DETAIL";
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
            mdlGeneral.Connection.Close();
        }

        private void Get_Total(string tblName)
        {
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            string cmdText = "SELECT SUM(QTY) AS TOTAL_QTY, SUM(PRICE) AS TOTAL_PRICE FROM " + tblName.Trim() + " WHERE (SALEID = N'" + Conversion.Val(OrderNo.Text.Trim()) + "') AND (TableStatus != N'PAID')";
            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblTaxes.Text = Strings.Format(Conversion.Val(reader["TOTAL_PRICE"].ToString().Trim()) * 0.07d, "0.00");
                            lblFinalCharges.Text = Strings.Format(Conversion.Val(reader["TOTAL_PRICE"].ToString().Trim()) * 0.07d, "0.00");
                            lblOrgPrice.Text = Strings.Format(Conversion.Val(reader["TOTAL_PRICE"].ToString().Trim()) + Conversion.Val(lblTaxes.Text.Trim()), "0.00");
                            lblFinalBill.Text = Strings.Format(Conversion.Val(reader["TOTAL_PRICE"].ToString().Trim()), "0.00");
                            lblDue.Text = Strings.Format(Conversion.Val(lblFinalBill.Text.Trim()) + Conversion.Val(lblFinalDiscount.Text.Trim()) + Conversion.Val(lblFinalCharges.Text), "0.00");
                            lblTotalBill.Text = Strings.Format(Conversion.Val(lblDue.Text.Trim()), "0.00");
                        }
                    }
                }
            }
        }

        public int GetMax_ID(string StringID)
        {
            int GetMax_IDRet = default;

            string MaxID_Text = "SELECT MAX(MaxID) as MaxSerial FROM " + "( " + "SELECT MAX(SALEID) as MaxID " + "FROM SALE_MASTER " + "GROUP BY SALEID " + "UNION ALL " + "SELECT MAX(SALEID) as MaxID " + "FROM SALE_DETAIL_TEMP " + "GROUP BY SaleID " + "UNION ALL " + "SELECT MAX(SALEID) as MaxID " + "FROM TABLE_DETAIL " + "GROUP BY SaleID " + "UNION ALL " + "SELECT MAX(SALEID) as MaxID " + "FROM SALE_DETAIL_HOLD " + "GROUP BY SaleID " + ") as subQuery";
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
                        GetMax_IDRet = (int)Math.Round(Convert.ToDecimal(Cmd.ExecuteScalar()) + 1m);
                    }
                }
                catch (Exception EX)
                {
                    Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
                return GetMax_IDRet;
            }

        }

        public int GetDetail_ID(string StringID)
        {
            int GetDetail_IDRet = default;

            string MaxID_Text = "SELECT MAX(MaxID) as MaxSerial FROM " + "( " + "SELECT MAX(DETAILID) as MaxID " + "FROM SALE_DETAIL " + "GROUP BY DetailID " + "UNION ALL " + "SELECT MAX(DETAILID) as MaxID " + "FROM SALE_DETAIL_TEMP " + "GROUP BY DetailID " + "UNION ALL " + "SELECT MAX(DETAILID) as MaxID " + "FROM TABLE_DETAIL " + "GROUP BY DetailID " + "UNION ALL " + "SELECT MAX(DETAILID) as MaxID " + "FROM SALE_DETAIL_HOLD " + "GROUP BY DetailID " + ") as subQuery";


















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
                        GetDetail_IDRet = (int)Math.Round(Convert.ToDecimal(Cmd.ExecuteScalar()) + 1m);
                    }
                }
                catch (Exception EX)
                {
                    Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
                return GetDetail_IDRet;
            }
        }

        private bool CheckItemExist(string strFind, string tblName, string strField, string TableNum)
        {
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            string cmdText = "SELECT * FROM " + tblName.Trim() + " WHERE (" + strField.Trim() + " = N'" + strFind.Trim() + "') AND (SaleTable = N'" + TableNum.Trim() + "')";
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

        private void CheckTableReservation()
        {
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, "SELECT SaleTable, TableStatus FROM TABLE_DETAIL WHERE TableStatus != N'LOCKED' GROUP BY SaleTable, TableStatus", mdlGeneral.Connection);
            var OnTable = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (OnTable.HasRows)
            {
                while (OnTable.Read())
                {
                    Control argparentControl = tabReservation;
                    ChangeBackgroundColor(ref argparentControl, OnTable["SaleTable"].ToString());
                    tabReservation = (TabPage)argparentControl;
                }
                hasTable = true;
            }
        }

        private void CheckTableLock()
        {
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, "SELECT SaleTable, TableStatus FROM TABLE_DETAIL WHERE TableStatus = N'LOCKED' GROUP BY SaleTable, TableStatus", mdlGeneral.Connection);
            var OnTable = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (OnTable.HasRows)
            {
                while (OnTable.Read())
                {
                    Control argparentControl = tabReservation;
                    CheckTablesPrintBill(ref argparentControl, OnTable["SaleTable"].ToString());
                    tabReservation = (TabPage)argparentControl;
                }
                hasTable = true;
            }
        }

        private void ChangeBackgroundColor(ref Control parentControl, string BtnText)
        {
            // Loop through each control inside the given parent
            foreach (Control ctrl in parentControl.Controls)
            {
                // Recursively update the color of the controls inside this control
                //ChangeBackgroundColor(ref ctrl, BtnText);
                // If the contol is a button change the background color
                if (ctrl is Button)
                {
                    if ((ctrl.Text ?? "") == (BtnText ?? ""))
                        ctrl.BackColor = Color.Goldenrod;
                }
            }
        }

        private void CheckTablesPrintBill(ref Control parentControl, string BtnText)
        {
            // Loop through each control inside the given parent
            foreach (Control control in parentControl.Controls)
            {
                // Recursively update the color of the controls inside this control
                //ChangeBackgroundColor(ref control, BtnText);
                // If the contol is a button change the background color
                if (control is Button)
                {
                    if ((control.Text ?? "") == (BtnText ?? ""))
                    {
                        control.BackColor = Color.Maroon;
                        control.ForeColor = Color.White;
                    }
                }
            }
        }

        private void ResetAllControlsBackColor(Control control)
        {
            // This code taken from MSDN
            // control.BackColor = Color.White
            // control.ForeColor = Color.Black
            // If control.HasChildren Then
            // ' Recursively call this method for each child control.
            // Dim childControl As Control
            // For Each childControl In control.Controls
            // ResetAllControlsBackColor(childControl)
            // Next childControl
            // End If
        }

        private void cmdChange_Click(object sender, EventArgs e)
        {
            TableChange = true;
            OldTableNo = lblTable.Text.Trim();
            mdlGeneral.gblCP_ID = OrderNo.Text.Trim();
            TabDine.SelectTab(0);
        }

        private void cmdCustomer_Click(object sender, EventArgs e)
        {
            TabDine.SelectTab(2);
            search_popup(txtSearch.Text);
        }

        private void SpecialButtons1(object sender, EventArgs e)
        {
            Button ButtonHandle = (Button)sender;
            ButtonHandle.ForeColor = Color.White;
        }

        private void SpecialButtons2(object sender, EventArgs e)
        {
            Button ButtonHandle = (Button)sender;
            ButtonHandle.ForeColor = Color.Black;
        }

        private void cmdVoid_Click(object sender, EventArgs e)
        {
            TableChange = false;
            string VoidOrder = "DELETE FROM TABLE_DETAIL WHERE SaleID = N'" + Conversion.Val(OrderNo.Text.Trim()) + "' AND SaleTable = N'" + lblTable.Text.Trim() + "' AND TableStatus != N'LOCKED'";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, VoidOrder, mdlGeneral.Connection);
            string VoidCustomer = "DELETE FROM TABLE_MASTER WHERE SaleID = N'" + Conversion.Val(OrderNo.Text.Trim()) + "' AND CustomerID = N'" + Conversion.Val(Strings.Mid(lblTable.Text.Trim(), 2, 2)) + "'";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, VoidCustomer, mdlGeneral.Connection);
            lblCustomer.Text = "";
            lblOrgPrice.Text = "0.00";
            lblOrgPrice.Visible = false;
            Label5.Visible = false;
            Label9.Visible = false;
            lblTaxes.Visible = false;
            lblStatus.Text = "";
            lblWaiter.Text = "";
            lblTable.Text = "";
            // From MSDN Forum
            foreach (object Obj in tabReservation.Controls)
            {
                if (ReferenceEquals(Obj.GetType(), typeof(Button)))
                {
                    ((Button)Obj).BackColor = Color.White;
                }
            }
            CheckTableReservation();
            CheckTableLock();
            TabDine.SelectTab(0);
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            if (hasOrder == true)
            {
                string TableLock = "UPDATE TABLE_DETAIL SET TableStatus = N'LOCKED' WHERE SaleID = N'" + Conversion.Val(OrderNo.Text.Trim()) + "' AND SaleTable = N'" + lblTable.Text.Trim() + "' AND TableStatus != N'LOCKED'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, TableLock, mdlGeneral.Connection);
                cmdChange.Enabled = false;
                cmdCustomer.Enabled = false;
                cmdPrint.Enabled = false;
                mdlGeneral.gblFind = OrderNo.Text.Trim();
                mdlGeneral.gblReportOption = "DUE_RECEIPT";
                Control argparentControl = tabReservation;
                CheckTablesPrintBill(ref argparentControl, lblTable.Text.Trim());
                tabReservation = (TabPage)argparentControl;
                mdlGeneral.gblReportName = Application.StartupPath + @"\Reports\CashReceipt.rpt";
                mdlGeneral.Print_Slips_Manually();
                hasOrder = false;
            }
            else
            {
                return;
            }
        }

        private void cmdWaiter_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.WaiterCode.ShowDialog(this);
            if (Strings.Len(mdlGeneral.gblCP) > 0)
            {
                lblWaiter.Text = mdlGeneral.gblCP.Trim().ToUpper();
                hasWaiter = false;
                string WaiterUpdate = "Update TABLE_DETAIL SET AOptions = N'" + lblWaiter.Text.Trim() + "' WHERE SaleTable = N'" + lblTable.Text.Trim() + "'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.TransferAdapter, WaiterUpdate, mdlGeneral.Connection);
            }
        }
        #endregion

        #region Num Pad Functions
        private void DigitClick(object sender, EventArgs e)
        {
            if (clearDisplay)
            {
                lblDisplay.Text = string.Empty;
                clearDisplay = false;
            }
            lblDisplay.Text += (sender as Button).Text;
        }

        private void NumFriction_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.IndexOf(".") >= 0)
            {
                return;
            }
            else if (Strings.Len(lblDisplay.Text) == 0)
            {
                lblDisplay.Text = "0.";
            }
            else
            {
                lblDisplay.Text += ".";
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            string str;
            int loc;
            if (lblDisplay.Text.Length > 0)
            {
                str = Conversions.ToString(lblDisplay.Text[lblDisplay.Text.Length - 1]);
                if (str == ".")
                {
                    hasDecimal = false;
                }
                loc = lblDisplay.Text.Length;
                lblDisplay.Text = lblDisplay.Text.Remove(loc - 1, 1);
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Empty;
            hasDecimal = false;
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            if (Strings.Len(lblDisplay.Text) == 0 | lblDisplay.Text == "0")
            {
                return;
            }
            else
            {
                lblDisplay.Text = Conversions.ToString(lblDisplay.Text);
            }
        }

        private void FinalDigitClick(object sender, EventArgs e)
        {
            if (BillPaid == false)
            {
                if (clearDisplay)
                {
                    txtPaid.Text = string.Empty;
                    clearDisplay = false;
                }
                txtPaid.Text += (sender as Button).Text;
            }
        }

        private void D0_Click(object sender, EventArgs e)
        {
            if (BillPaid == false)
            {
                if (Strings.Len(txtPaid.Text) == 0 | txtPaid.Text == "0")
                {
                    return;
                }
                else
                {
                    txtPaid.Text = Conversions.ToString(txtPaid.Text);
                }
            }
        }

        private void cmdClearDisplay_Click(object sender, EventArgs e)
        {
            if (BillPaid == false)
            {
                txtPaid.Text = string.Empty;
                hasDecimal = false;
            }
        }

        private void cmdBackSapce_Click(object sender, EventArgs e)
        {
            if (BillPaid == false)
            {
                string str;
                int loc;
                if (txtPaid.Text.Length > 0)
                {
                    str = Conversions.ToString(txtPaid.Text[txtPaid.Text.Length - 1]);
                    if (str == ".")
                    {
                        hasDecimal = false;
                    }
                    loc = txtPaid.Text.Length;
                    txtPaid.Text = txtPaid.Text.Remove(loc - 1, 1);
                }
            }
        }
        #endregion

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            TabDine.SelectTab(1);
            ButtonHandle();
            Addition = false;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateAlphaKeyPress(sender, e, txtName);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateAlphaKeyPress(sender, e, txtSearch);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (Strings.Len(txtSearch.Text) > 0)
            {
                search_popup(txtSearch.Text.Trim());
            }
            else
            {

            }
        }

        private void search_popup(string FindString)
        {
            FinalDataSet.Clear();
            string cmdText = "SELECT * FROM CUSTOMERS WHERE CUST_NAME LIKE '%" + txtSearch.Text + "%'";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, cmdText, mdlGeneral.Connection);
            mdlGeneral.SqlDataAdapter.Fill(FinalDataSet, "CUSTOMERS");
            FinalBindingSource.DataSource = FinalDataSet;
            FinalBindingSource.DataMember = "CUSTOMERS";
            FinalBindingSource.Filter = "CUST_NAME LIKE '%" + txtSearch.Text + "%'";
            dgvCustomer.DataSource = FinalBindingSource;
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            if (cmdNew.Text == "&Save")
            {
                if (Addition == true)
                    InsertCustomer = "INSERT INTO CUSTOMERS VALUES (0,'" + Strings.StrConv(txtName.Text.Trim(), VbStrConv.ProperCase) + "','x','x','" + txtPhone.Text.Trim() + "','0','0','2017-01-01'";
                if (EditMode == true)
                    InsertCustomer = "UPDATE CUSTOMERS SET CUST_NAME = N'" + Strings.StrConv(txtName.Text.Trim(), VbStrConv.ProperCase) + "', CUST_TEL = N'" + txtPhone.Text.Trim() + "' WHERE CUST_NAME = N'" + EditCustomer.Trim() + "'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, InsertCustomer, mdlGeneral.Connection);
                ButtonHandle();
                txtSearch.Clear();
                txtSearch.Focus();
                search_popup(txtSearch.Text.Trim());
                dgvCustomer.Refresh();
                return;
            }
            Addition = true;
            Label8.Text = "Name";
            cmdNew.Text = "&Save";
            cmdNew.Enabled = false;
            cmdSelect.Enabled = false;
            cmdEdit.Enabled = false;
            Label10.Visible = true;
            txtName.Visible = true;
            txtPhone.Visible = true;
            txtSearch.Visible = false;
            dgvCustomer.Visible = false;
            cmdDelete.Text = "&Cancel";
            txtName.Clear();
            txtPhone.Clear();
            if (txtName.Visible == true)
                txtName.Focus();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (cmdDelete.Text == "&Cancel")
            {
                ButtonHandle();
                txtSearch.Clear();
                txtSearch.Focus();
                return;
            }
        }

        private void ButtonHandle()
        {
            Label8.Text = "Search";
            cmdNew.Text = "&New" + Constants.vbCrLf + "Customer";
            cmdNew.Enabled = true;
            cmdSelect.Enabled = true;
            cmdEdit.Enabled = true;
            Label10.Visible = false;
            txtName.Visible = false;
            txtPhone.Visible = false;
            txtSearch.Visible = true;
            dgvCustomer.Visible = true;
            cmdDelete.Text = "&Delete";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (Strings.Len(txtName.Text.Trim()) > 0)
                cmdNew.Enabled = true;
            else
                cmdNew.Enabled = false;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumbersOnly(sender, e, txtPhone);
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (mdlGeneral.CheckCellValue(dgvCustomer) == true) // // return false if cells have no values
            {
                Label8.Text = "Name";
                cmdNew.Text = "&Save";
                cmdNew.Enabled = false;
                cmdSelect.Enabled = false;
                cmdEdit.Enabled = false;
                Label10.Visible = true;
                txtName.Visible = true;
                txtPhone.Visible = true;
                txtSearch.Visible = false;
                dgvCustomer.Visible = false;
                EditMode = true;
                cmdDelete.Text = "&Cancel";
                txtName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString().Trim();
                txtPhone.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString().Trim();
                EditCustomer = dgvCustomer.CurrentRow.Cells[1].Value.ToString().Trim();
                if (txtName.Visible == true)
                    txtName.Focus();
            }
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.Visible == true)
            {
                if (dgvCustomer.RowCount > 0)
                {
                    lblCustomer.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString().Trim();
                    TabDine.SelectTab(1);
                    UpdateMasterTable();
                }
            }
        }

        private void cmdCloseBack_Click(object sender, EventArgs e)
        {
            if (BillPaid == true)
            {
                BillPaid = false;
                hasOrder = false;
                hasTable = false;
                TableChange = false;
                TabDine.SelectTab(0);
            }
            else
            {
                TabDine.SelectTab(1);
            }
        }

        private void ButtonMouseOver(object sender, EventArgs e)

        {
            Button ButtonHandle = (Button)sender;
            ButtonHandle.ForeColor = Color.White;
        }

        private void ButtonMouseLeave(object sender, EventArgs e)

        {
            Button ButtonHandle = (Button)sender;
            ButtonHandle.ForeColor = Color.Black;
        }

        private void cmdDiscount_Click(object sender, EventArgs e)
        {
            if (BillPaid == false)
            {
                if (Strings.Len(txtPaid.Text) > 0)
                {
                    if (Conversion.Val(txtPaid.Text.Trim()) > 100d)
                    {
                        mdlGeneral.gblMessage = "Discount cannot be greater than total bill amount.";
                        My.MyProject.Forms.MsgStatus.ShowDialog(this);
                        return;
                    }
                    lblFinalDiscount.Text = Strings.Format(Conversion.Val(lblTotalBill.Text.Trim()) * (Conversion.Val(txtPaid.Text.Trim()) / 100d), "0.00");
                    lblDue.Text = Strings.Format(Conversion.Val(lblFinalBill.Text.Trim()) + Conversion.Val(lblFinalCharges.Text.Trim()) - Conversion.Val(lblFinalDiscount.Text.Trim()), "0.00");
                    lblTotalBill.Text = Strings.Format(Conversion.Val(lblDue.Text.Trim()), "0.00");
                    Label13.Text = Label13.Text.Trim() + " " + txtPaid.Text + "%";
                    txtPaid.Clear();
                }
            }
        }

        private void cmdRefreshBill_Click(object sender, EventArgs e)
        {
            if (BillPaid == false)
            {
                if (lblFinalStatus.Text.Trim() == "Paid")
                {
                    mdlGeneral.gblMessage = "Paid bill cannot be refreshed, plz contact administrator.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                lblFinalDiscount.Text = "0.00";
                Get_Total("TABLE_DETAIL");
                Label13.Text = "Discount :";
            }
        }

        private void UpdateMasterTable()
        {
            if (hasOrder == true | TableChange == true)
            {
                string CustomerInfo = string.Empty;
                if (mdlGeneral.CheckRecordExists(OrderNo.Text.Trim(), "TABLE_MASTER", "SaleID") == false)
                {
                    CustomerInfo = "INSERT INTO TABLE_MASTER VALUES (" + Conversion.Val(OrderNo.Text.Trim()) + "," + Conversion.Val(mdlGeneral.UserID.Trim()) + ",'" + mdlGeneral.UserName.Trim() + "','" + Strings.Format(DateTime.Parse(DateTime.Now.ToString()), "MM/dd/yyyy") + "','" + "TABLE" + "','" + SequenceNo.Text.Trim() + "','" + Conversion.Val(Strings.Mid(CustomerID.Trim(), 2, 2)) + "','" + lblCustomer.Text.Trim() + "'," + Conversion.Val(lblOrgPrice.Text.Trim()) + "," + "0" + "," + "0" + "," + "0" + "," + "0,0,0,0,'" + Strings.Format(DateTime.Parse(DateTime.Now.ToString()), "MM/dd/yyyy") + "'," + Conversion.Val(lblTaxes.Text.Trim()) + ")";
                }
                else
                {
                    CustomerInfo = "UPDATE TABLE_MASTER SET " + "DrawerID = N'" + Conversion.Val(mdlGeneral.UserID.Trim()) + "', " + "DrawerName = N'" + mdlGeneral.UserName.Trim() + "', " + "DateCompleted = N'" + Strings.Format(DateTime.Parse(DateTime.Now.ToString().Trim()), "MM/dd/yyyy") + "', " + "SaleType = N'" + "TABLE" + "', " + "CustomerID = N'" + Conversion.Val(Strings.Mid(CustomerID.Trim(), 2, 2)) + "', " + "CustomerName = N'" + lblCustomer.Text.Trim() + "', " + "SaleTotal = N'" + Conversion.Val(lblOrgPrice.Text.Trim()) + "', " + "SalePaid = N'" + "0" + "', " + "SaleDiscount = N'" + "0" + "', " + "SaleChange = N'" + "0" + "', " + "SaleStatus = 1 " + ", " + "ServiceChrg =  " + Conversion.Val(lblTaxes.Text.Trim()) + " " + "WHERE SaleID = " + Conversion.Val(OrderNo.Text.Trim());
                }
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CustomerInfo, mdlGeneral.Connection);
            }
        }

        private void cmdDiscPaid_Click(object sender, EventArgs e)
        {
            if (BillPaid == false)
            {
                if (Strings.Len(txtPaid.Text) > 0)
                {
                    if (Conversion.Val(txtPaid.Text.Trim()) > Conversion.Val(lblTotalBill.Text.Trim()))
                    {
                        mdlGeneral.gblMessage = "Discount cannot be greater than total bill amount.";
                        My.MyProject.Forms.MsgStatus.ShowDialog(this);
                        return;
                    }
                    lblFinalDiscount.Text = Strings.Format(Conversion.Val(txtPaid.Text.Trim()), "0.00");
                    lblDue.Text = Strings.Format(Conversion.Val(lblFinalBill.Text.Trim()) + Conversion.Val(lblFinalCharges.Text.Trim()) - Conversion.Val(lblFinalDiscount.Text.Trim()), "0.00");
                    lblTotalBill.Text = Strings.Format(Conversion.Val(lblDue.Text.Trim()), "0.00");
                    Label13.Text = Label13.Text.Trim() + " in Amount";
                    txtPaid.Clear();
                }
            }
        }

        private void cmdPaid_Click(object sender, EventArgs e)
        {
            if (BillPaid == false)
            {
                string CustomerInfo = "UPDATE TABLE_MASTER SET " + "DrawerID = N'" + Conversion.Val(mdlGeneral.UserID.Trim()) + "', " + "DrawerName = N'" + mdlGeneral.UserName.Trim() + "', " + "DateCompleted = N'" + Strings.Format(DateTime.Parse(DateTime.Now.ToString().Trim()), "MM/dd/yyyy") + "', " + "SaleType = N'" + "TABLE" + "', " + "CustomerID = N'" + Conversion.Val(Strings.Mid(lblFinalTable.Text.Trim(), 2, 2)) + "', " + "CustomerName = N'" + lblFinalCustomer.Text.Trim() + "', " + "SaleTotal = N'" + Conversion.Val(lblTotalBill.Text.Trim()) + "', " + "SalePaid = N'" + Conversion.Val(txtPaid.Text.Trim()) + "', " + "SaleDiscount = N'" + Conversion.Val(lblFinalDiscount) + "', " + "SaleChange = N'" + Conversion.Val(lblRefund.Text.Trim()) + "', " + "SaleStatus = 0 " + ", " + "ServiceChrg =  " + Conversion.Val(lblFinalCharges.Text.Trim()) + " " + "WHERE SaleID = " + Conversion.Val(lblFinalOrderNo.Text.Trim());
                string PaidBill = "Update TABLE_DETAIL SET TableStatus = N'PAID' , CustomerID = N'" + Conversion.Val(Strings.Mid(lblFinalTable.Text.Trim(), 2, 2)) + "' WHERE SaleID = " + Conversion.Val(lblFinalOrderNo.Text.Trim()) + " AND SaleTable = N'" + lblFinalTable.Text + "'";
                try
                {
                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CustomerInfo, mdlGeneral.Connection);
                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, PaidBill, mdlGeneral.Connection);
                    // From MSDN Forum
                    foreach (object Obj in tabReservation.Controls)
                    {
                        if (ReferenceEquals(Obj.GetType(), typeof(Button)))
                        {
                            ((Button)Obj).BackColor = Color.White;
                        }
                    }
                    CheckTableReservation();
                    CheckTableLock();
                }
                catch (Exception ex)
                {
                    mdlGeneral.gblMessage = ex.Message;
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                BillPaid = true;
            }
        }

        private void txtPaid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Conversion.Val(txtPaid.Text.Trim()) < Conversion.Val(lblTotalBill.Text.Trim()))
                {
                    mdlGeneral.gblMessage = "payment less than total amount.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                if (Conversion.Val(txtPaid.Text.Trim()) > Conversion.Val(lblTotalBill.Text.Trim()))
                {
                    lblRefund.Visible = true;
                    Label17.Visible = true;
                    lblRefund.Text = (Conversion.Val(txtPaid.Text.Trim()) - Conversion.Val(lblTotalBill.Text.Trim())).ToString();
                }
            }
        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtPaid, txtPaid);
        }
    }
}