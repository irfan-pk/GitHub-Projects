using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class PurchReturn
    {
        private int Max_ID, Supplr_ID;
        private bool drag, newrec, updatable, editmode, DataFinalize, GridEdit;
        private double OldPPrie, OldSalePrice, OldQuantity, OldSchR1, OldSchR2, OldSchR3, OldSchQ1, OldSchQ2, OldSchQ3, NewPPrice, NewQuantity, NewSchR1, NewSchR2, NewSchR3, NewSchQ1, NewSchQ2, NewSchQ3;
        private int mousex, mousey;

        public PurchReturn()
        {
            InitializeComponent();
        }

        private void frmPurchReturn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                BindingNavigatorSave_Click(sender, e);

            if (e.KeyCode == Keys.F3)
                Get_Text_Values();

            if (e.KeyCode == Keys.F8)
                Delete_DataRow();
        }

        private void frmPurchReturn_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void frmPurchReturn_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void frmPurchReturn_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
            My.MyProject.Forms.Stock.WindowState = FormWindowState.Normal;
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmPurchReturn_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            cmdClose.Left = Width - (cmdClose.Width + 5);
            cmdMin.Left = Width - (cmdMin.Width + cmdClose.Width + 5);
            mdlGeneral.GetConnectionString();

            FormBorderStyle = FormBorderStyle.None;
            // Popup the Company Data Combo
            SqlDataReader Popup_Reader;
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, "SELECT DISTINCT SUPL_CODE, SUPL_NAME FROM SUPPLIERS ORDER BY SUPL_NAME", mdlGeneral.Connection);
            Popup_Reader = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (Popup_Reader.HasRows)
            {
                while (Popup_Reader.Read())
                    cmbCompany.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Popup_Reader["SUPL_NAME"], " - "), Popup_Reader["SUPL_NAME"]));
            }
            else
            {
                // Go through
            }
            // Retrieve Records for datagrid view from purchase table
            RefreshGridView();
            editmode = false;
        }

        private void RefreshGridView()
        {
            try
            {
                // Retrieve Records for datagrid view from purchase table
                PurchaseDataSet.Clear();
                mdlGeneral.PurchaseAdapter.Dispose();
                // Dim PurchasesQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
                string PurchasesQuery = "SELECT * FROM PURCHASE WHERE (PRCH_STATUS = N'RETURN')";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.PurchaseAdapter, PurchasesQuery, mdlGeneral.Connection);
                mdlGeneral.PurchaseAdapter.Fill(PurchaseDataSet, "PURCHASE");
                var reader1 = mdlGeneral.PurchaseAdapter.SelectCommand.ExecuteReader();
                if (reader1.HasRows)
                {
                    BindingNavigatorRefreshItem.Enabled = true;
                    PurchaseBindingSource.DataSource = PurchaseDataSet;
                    PurchaseBindingSource.DataMember = "PURCHASE";
                    PurchaseDataGridView.Refresh();
                    BindingNavigatorSaveItem.Enabled = true;
                }
                // Retrieve Records for datagrid view from product table
                ProductDataSet.Clear();
                mdlGeneral.ProductAdapter.Dispose();
                string ProductQuery = "SELECT * FROM PRODUCTS WHERE PROD_UPD_ON = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102)";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.ProductAdapter, ProductQuery, mdlGeneral.Connection);
                mdlGeneral.ProductAdapter.Fill(ProductDataSet, "PRODUCTS");
                var reader2 = mdlGeneral.ProductAdapter.SelectCommand.ExecuteReader();
                if (reader2.HasRows)
                {
                    ProductBindingSource.DataSource = ProductDataSet;
                    ProductBindingSource.DataMember = "PRODUCTS";
                    ProductDataGridView.Refresh();
                }
            }
            catch (Exception EX)
            {
                Interaction.MsgBox(EX.Message, MsgBoxStyle.Information);
            }

        }

        private void txtQty_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtQty);
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSQty1.Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtQty, txtSQty1);
        }

        private void txtQty_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtQty);
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            updatable = true;
            BindingNavigatorSave.Enabled = true;
        }

        private void txtSQty1_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSQty1);
        }

        private void txtSQty1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSQty2.Focus();
        }

        private void txtSQty1_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtSQty1, txtSQty2);
        }

        private void txtSQty1_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSQty1);
        }

        private void txtSQty1_TextChanged(object sender, EventArgs e)
        {
            updatable = true;
            BindingNavigatorSave.Enabled = true;
        }

        private void txtSQty2_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSQty2);
        }

        private void txtSQty2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSQty3.Focus();
        }

        private void txtSQty2_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtSQty2, txtSQty3);
        }

        private void txtSQty2_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSQty2);
        }

        private void txtSQty2_TextChanged(object sender, EventArgs e)
        {
            updatable = true;
            BindingNavigatorSave.Enabled = true;
        }

        private void txtSQty3_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSQty3);
        }

        private void txtSQty3_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtSQty3, txtSQty3);
        }

        private void txtSQty3_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSQty3);
        }

        private void txtSQty3_TextChanged(object sender, EventArgs e)
        {
            updatable = true;
            BindingNavigatorSave.Enabled = true;
        }

        private void BindingNavigatorSave_Click(object sender, EventArgs e)
        {
            if (CheckRecordExists(Strings.Mid(cmbCompany.Text.Trim(), 1, 4), "SUPPLIERS", "SUPL_CODE") == true)
            {
                // To skip if no quantity given by user
                if (Conversion.Val(txtQty.Text.Trim()) == 0d & Conversion.Val(txtQty.Text.Trim()) == 0d & Conversion.Val(txtQty.Text.Trim()) == 0d & Conversion.Val(txtQty.Text.Trim()) == 0d)


                {
                    mdlGeneral.gblMessage = "There is no quantity to return purchases. please give quantity to return.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                // If quantity given then next step
                if (updatable == true)
                {
                    decimal Max_Tr_ID = 0m;

                    // Check if already in Purchases Table
                    if (string.IsNullOrEmpty(txtCode.Text) | string.IsNullOrEmpty(txtDesc.Text))
                    {
                        mdlGeneral.gblMessage = "Please give valid product code.";
                        My.MyProject.Forms.MsgStatus.ShowDialog(this);
                        return;
                    }

                    Max_Tr_ID = mdlGeneral.GenerateMax_ID("PURCHASE", "PRCH_TR_ID");

                    if (Conversion.Val(txtQty.Text) > 0d)
                    {
                        NewQuantity = Conversion.Val(txtQty.Text) * -1;
                        NewPPrice = Conversion.Val(txtPPrice.Text.Trim());
                    }
                    else
                    {
                        NewPPrice = 0d;
                        NewQuantity = 0d;
                    }
                    if (Conversion.Val(txtSQty1.Text) > 0d)
                    {
                        NewSchQ1 = Conversion.Val(txtSQty1.Text) * -1;
                        NewSchR1 = Conversion.Val(txtSch1.Text);
                    }
                    else
                    {
                        NewSchR1 = 0d;
                        NewSchQ1 = 0d;
                    }
                    if (Conversion.Val(txtSQty2.Text) > 0d)
                    {
                        NewSchQ2 = Conversion.Val(txtSQty2.Text) * -1;
                        NewSchR2 = Conversion.Val(txtSch2.Text);
                    }
                    else
                    {
                        NewSchR2 = 0d;
                        NewSchQ2 = 0d;
                    }
                    if (Conversion.Val(txtSQty3.Text) > 0d)
                    {
                        NewSchQ3 = Conversion.Val(txtSQty3.Text) * -1;
                        NewSchR3 = Conversion.Val(txtSch3.Text);
                    }
                    else
                    {
                        NewSchR3 = 0d;
                        NewSchQ3 = 0d;
                    }

                    string CheckQuery = "SELECT * FROM PURCHASE WHERE PRCH_CD = N'" + txtCode.Text.Trim() + "' AND PRCH_SUPPLIER = N'" + cmbCompany.Text.Trim() + "' AND PRCH_DATE = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102)";
                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CheckQuery, mdlGeneral.Connection);
                    var Finder = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
                    if (Finder.HasRows)
                    {
                        if (editmode == true)
                        {
                            string InsertRecord = "UPDATE PURCHASE SET " + "PRCH_PRICE = " + NewPPrice + ", " + "PRCH_QTY = " + NewQuantity + ", " + "PRCH_SCH1_PRICE = " + NewSchR1 + ", " + "PRCH_SCH1_ONHAND = " + NewSchQ1 + ", " + "PRCH_SCH2_PRICE = " + NewSchR2 + ", " + "PRCH_SCH2_ONHAND = " + NewSchQ2 + ", " + "PRCH_SCH3_PRICE = " + NewSchR3 + ", " + "PRCH_SCH3_ONHAND = " + NewSchQ3 + ", " + "PRCH_DATE = '" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString().Trim()), "MM/dd/yyyy") + "', " + "PRCH_SUPPLIER = '" + cmbCompany.Text.Trim() + "', PRCH_STATUS ='RETURN' " + "WHERE (PRCH_CD = N'" + mdlGeneral.gblFind + "' AND PRCH_STATUS = N'ADDED' AND PRCH_DATE = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102))";










                            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, InsertRecord, mdlGeneral.Connection);
                            editmode = false;
                            RefreshGridView();
                            txtCode.Clear();
                            txtCode.Focus();
                            editmode = false;
                        }
                        else
                        {
                            // Message Box
                            mdlGeneral.gblMessage = "Item already enlisted in the queue.";
                            My.MyProject.Forms.MsgStatus.ShowDialog(this);
                        }
                    }
                    else
                    {
                        string InsertRecord = "INSERT INTO PURCHASE (PRCH_TR_ID,PRCH_CD,PRCH_DESC,PRCH_CATG,PRCH_PACK,PRCH_PRICE,PRCH_QTY,PRCH_OLD_QTY,PRCH_BAL_MIN,PRCH_SCH1_PRICE,PRCH_SCH1_ONHAND,PRCH_SCH2_PRICE,PRCH_SCH2_ONHAND,PRCH_SCH3_PRICE,PRCH_SCH3_ONHAND,PRCH_VAT,PRCH_ITAX,PRCH_EX_DUTY,PRCH_PROFIT,PRCH_DISC_MRG,PRCH_SPRICE,PRCH_DATE,PRCH_SUPPLIER,PRCH_STATUS) " + "VALUES (" + Max_Tr_ID + ",'" + txtCode.Text.Trim() + "','" + txtDesc.Text.Trim() + "','" + "x','" + "x'," + NewPPrice + "," + NewQuantity + "," + OldQuantity + "," + "0," + NewSchR1 + "," + NewSchQ1 + "," + NewSchR2 + "," + NewSchQ2 + "," + NewSchR3 + "," + NewSchQ3 + "," + "0," + "0," + "0," + "0," + "0," + "0,'" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString().Trim()), "MM/dd/yyyy") + "','" + cmbCompany.Text.Trim() + "','RETURN')";






















                        mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, InsertRecord, mdlGeneral.Connection);
                        BindingNavigatorSaveItem.Enabled = true;
                        BindingNavigatorRefreshItem.Enabled = true;
                        RefreshGridView();
                        RefreshTextBoxes();
                        txtCode.Clear();
                        txtCode.Focus();
                    }
                }
            }
            else
            {
                mdlGeneral.gblMessage = "Please select valid wholesaler.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
            }
        }

        private void txtCode_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtCode);
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // First Check Item in Product Table and get information
                SqlDataReader DataCheck;
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, "SELECT * FROM PRODUCTS WHERE PROD_CD = N'" + txtCode.Text.ToString().ToString().Trim() + "'", mdlGeneral.Connection);
                DataCheck = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
                if (DataCheck.HasRows)
                {
                    while (DataCheck.Read())
                    {
                        txtDesc.Text = DataCheck["PROD_DESC"].ToString().Trim();
                        txtPPrice.Text = DataCheck["PROD_PPRICE"].ToString().Trim();
                        txtSch1.Text = DataCheck["PROD_SCH1_PRICE"].ToString().Trim();
                        txtSch2.Text = DataCheck["PROD_SCH2_PRICE"].ToString().Trim();
                        txtSch3.Text = DataCheck["PROD_SCH3_PRICE"].ToString().Trim();
                        OldQuantity = Conversion.Val(DataCheck["PROD_ONHAND"].ToString().Trim());
                        OldSchQ1 = Conversion.Val(DataCheck["PROD_SCH1_ONHAND"].ToString().Trim());
                        OldSchQ2 = Conversion.Val(DataCheck["PROD_SCH2_ONHAND"].ToString().Trim());
                        OldSchQ3 = Conversion.Val(DataCheck["PROD_SCH3_ONHAND"].ToString().Trim());
                    }
                    if (DataCheck is null)
                        DataCheck.Close();
                    txtQty.Focus();
                }
                else
                {
                    mdlGeneral.gblMessage = "Invalid Product code ? Please use valid code.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                }
            }
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.ProductCode.ShowDialog(this);
                if (Strings.Len(mdlGeneral.gblItemCode) > 0)
                    txtCode.Text = mdlGeneral.gblItemCode.ToUpper();
                txtCode_KeyDown(sender, e);
            }
        }

        private void txtCode_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtCode);
        }

        private void cmbCompany_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(cmbCompany);
        }

        private void cmbCompany_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(cmbCompany);
        }

        private void txtDesc_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtDesc);
        }

        private void txtDesc_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtDesc);
        }

        private void BindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            RefreshTextBoxes();
            txtCode.Clear();
            editmode = false;
            txtCode.ReadOnly = false;
            txtCode.Focus();
        }

        private void RefreshTextBoxes()
        {
            // REFRESH FIELDS FOR NEW RECORD
            txtDesc.Clear();
            txtPPrice.Text = "0";
            txtSch1.Text = "0";
            txtSQty1.Text = "0";
            txtSch2.Text = "0";
            txtSQty2.Text = "0";
            txtSch3.Text = "0";
            txtSQty3.Text = "0";
            txtQty.Text = "0";
        }

        private void Get_Text_Values()
        {

            // EDIT PROCEDURE WHILE UPDATE PURCHASES
            if (PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[0].Value.ToString().Trim() is null)
            {
                mdlGeneral.gblMessage = "There is no product to delete.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                return;
            }
            if (PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[15].Value.ToString().Trim() == "RETURN")
            {
                txtCode.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[2].Value.ToString().Trim();
                mdlGeneral.gblFind = txtCode.Text.Trim();
                txtDesc.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[3].Value.ToString().Trim();
                cmbCompany.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[4].Value.ToString().Trim();
                txtDate.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[1].Value.ToString();
                txtPPrice.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[6].Value.ToString();
                txtQty.Text = (Conversions.ToDouble(PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[7].Value.ToString()) * -1).ToString();
                txtSch1.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[9].Value.ToString();
                txtSQty1.Text = (Conversions.ToDouble(PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[10].Value.ToString()) * -1).ToString();
                txtSch2.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[11].Value.ToString();
                txtSQty2.Text = (Conversions.ToDouble(PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[12].Value.ToString()) * -1).ToString();
                txtSch3.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[13].Value.ToString();
                txtSQty3.Text = (Conversions.ToDouble(PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[14].Value.ToString()) * -1).ToString();
                editmode = true;
                txtCode.ReadOnly = true;
                txtQty.Focus();
            }
            else
            {
                // gblMessage = "Changes cannot be made, product updated."
                // frmStatus.ShowDialog(Me)
                editmode = false;
            }
        }

        private void Delete_DataRow()
        {
            // Move values from datagrid to variables for deletion
            if (editmode == false)
            {
                string DeleteID = PurchaseDataGridView.CurrentRow.Cells[0].Value.ToString();
                string DeleteString = PurchaseDataGridView.CurrentRow.Cells[2].Value.ToString();
                string DeleteDate = PurchaseDataGridView.CurrentRow.Cells[1].Value.ToString();

                if (PurchaseDataGridView.CurrentRow.Cells[0].Value is null)
                    return;
                // Validate deletion if true then show the message on screen.
                if (ValidateDelete(DeleteString, DeleteDate) == false)
                {
                    string mResult = ((int)Interaction.MsgBox("Are you sure ot delete " + DeleteString, (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.YesNo), "Delete Entry")).ToString();
                    if (Conversions.ToDouble(mResult) == (double)MsgBoxResult.Yes)
                    {
                        mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, "DELETE FROM PURCHASE WHERE PRCH_TR_ID = N'" + DeleteID + "' AND PRCH_STATUS != N'UPDATED' AND PRCH_CD = N'" + DeleteString.Trim() + "' AND PRCH_DATE = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(DeleteDate), "yyyy-MM-dd") + " 00:00:00',102)", mdlGeneral.Connection);
                        RefreshTextBoxes();
                        RefreshGridView();
                        txtCode.Clear();
                        txtCode.Focus();
                    }
                }
                else
                {
                    mdlGeneral.gblMessage = "Product updated, Changes cannot be made now, you must be use purchase return option.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                }
            }
            else
            {
                mdlGeneral.gblMessage = "You are in edit mode. click refresh to disable.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
            }

        }

        private bool ValidateDelete(string strFind, string strDate)
        {
            // Function to check status of purchases transactions
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            string cmdText = "SELECT * FROM PURCHASE WHERE (PRCH_CD = N'" + strFind.Trim() + "' AND PRCH_STATUS = N'UPDATED' AND PRCH_DATE = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(strDate.Trim()), "yyyy-MM-dd") + " 00:00:00',102))";

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

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // If CheckRecordExists(Mid(cmbCompany.Text.Trim, 1, 4), "SUPPLIERS", "SUPL_CODE") = True Then
            string UpdtRecQuery = string.Empty;
            string Clos_Balance = string.Empty;
            Max_ID = 0;

            // Final Routine to update the products from purchases by date
            string TransferQuery = "SELECT * FROM PURCHASE WHERE PRCH_STATUS = N'RETURN' ORDER BY PRCH_TR_ID";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.TransferAdapter, TransferQuery, mdlGeneral.Connection);
            var TransferReader = mdlGeneral.TransferAdapter.SelectCommand.ExecuteReader();

            if (TransferReader.HasRows)
            {
                while (TransferReader.Read())
                {
                    if (ValidateDelete(TransferReader["PRCH_CD"].ToString(), TransferReader["PRCH_DATE"].ToString()) == false)
                    {
                        UpdtRecQuery = string.Empty;
                        if (CheckRecordExists(TransferReader["PRCH_CD"].ToString(), "PRODUCTS", "PROD_CD") == true)
                        {
                            // UPDATE RECORD INTO PRODUCT TABLE
                            UpdtRecQuery = "UPDATE PRODUCTS SET " + "PROD_ONHAND = PROD_ONHAND + " + Conversion.Val(TransferReader["PRCH_QTY"].ToString()) + ", " + "PROD_SCH1_PRICE = PROD_SCH1_PRICE + " + Conversion.Val(TransferReader["PRCH_SCH1_PRICE"].ToString()) + ", " + "PROD_SCH1_ONHAND = PROD_SCH1_ONHAND + " + Conversion.Val(TransferReader["PRCH_SCH1_ONHAND"].ToString()) + ", " + "PROD_SCH2_PRICE = PROD_SCH2_PRICE + " + Conversion.Val(TransferReader["PRCH_SCH2_PRICE"].ToString()) + ", " + "PROD_SCH2_ONHAND = PROD_SCH2_ONHAND + " + Conversion.Val(TransferReader["PRCH_SCH2_ONHAND"].ToString()) + ", " + "PROD_SCH3_PRICE = PROD_SCH3_PRICE + " + Conversion.Val(TransferReader["PRCH_SCH3_PRICE"].ToString()) + ", " + "PROD_SCH3_ONHAND = PROD_SCH3_ONHAND + " + Conversion.Val(TransferReader["PRCH_SCH3_ONHAND"].ToString()) + ", " + "PROD_DATE = '" + Strings.Format(DateTime.Parse(TransferReader["PRCH_DATE"].ToString()), "MM/dd/yyyy") + "', " + "PROD_UPD_ON = '" + Strings.Format(DateTime.Parse(txtDate.Text.ToString().Trim()), "MM/dd/yyyy") + "' " + "WHERE (PROD_CD = N'" + TransferReader["PRCH_CD"].ToString() + "')";









                        }
                        mdlGeneral.ExecuteAdapterQuery(mdlGeneral.TransferAdapter, UpdtRecQuery, mdlGeneral.Connection);

                        // To update suppliers balances
                        Max_ID = mdlGeneral.GenerateMax_ID("SUPPLIERS", "SUPL_CODE");
                        if (Max_ID == 1)
                            Max_ID = Max_ID + 1000;

                        double Total_Amount = Conversion.Val(TransferReader["PRCH_PRICE"].ToString()) * Conversion.Val(TransferReader["PRCH_QTY"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH1_PRICE"].ToString()) * Conversion.Val(TransferReader["PRCH_SCH1_ONHAND"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH2_PRICE"].ToString()) * Conversion.Val(TransferReader["PRCH_SCH2_ONHAND"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH3_PRICE"].ToString()) * Conversion.Val(TransferReader["PRCH_SCH3_ONHAND"].ToString());



                        double Total_Quantity = Conversion.Val(TransferReader["PRCH_QTY"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH1_ONHAND"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH2_ONHAND"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH3_ONHAND"].ToString());



                        // To update journal transactions
                        if (Total_Amount < 0d)
                        {
                            Supplr_ID = Supplier_ID(Strings.Mid(TransferReader["PRCH_SUPPLIER"].ToString(), 8, 42));
                            Updt_General_Journal(Total_Amount, Total_Quantity, Supplr_ID, TransferReader["PRCH_DATE"].ToString(), TransferReader["PRCH_DESC"].ToString());
                            if (CheckRecordExists(Strings.Mid(TransferReader["PRCH_SUPPLIER"].ToString(), 1, 4), "SUPPLIERS", "SUPL_CODE") == true)
                            {
                                // Clos_Balance = "INSERT INTO SUPPLIERS VALUES (" & _
                                // Max_ID & ",'" & _
                                // TransferReader.Item("PRCH_SUPPLIER").ToString.Trim & "','" & _
                                // "x','" & _
                                // "x','" & _
                                // "x','" & _
                                // "x'," & _
                                // Total_Amount & ",'" & _
                                // Format(Date.Parse(TransferReader.Item("PRCH_DATE").ToString), "MM/dd/yyyy") & "')"
                                // Else
                                Clos_Balance = "UPDATE SUPPLIERS SET " + "SUPL_BALANCE = SUPL_BALANCE + " + Total_Amount + ", SUPL_UPD_DT = N'" + Strings.Format(DateTime.Parse(TransferReader["PRCH_DATE"].ToString()), "MM/dd/yyyy") + "' " + "WHERE SUPL_CODE = N'" + Supplr_ID + "'";



                            }
                            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Clos_Balance, mdlGeneral.Connection);
                        }
                        // To upddate status of purchases to avoid duplication
                        ValidatePurchases(TransferReader["PRCH_CD"].ToString(), TransferReader["PRCH_DATE"].ToString());
                        Total_Amount = (double)default;
                    }
                    else
                    {
                        // Skip Check
                    }
                }
                if (TransferReader is null)
                    TransferReader.Close();
                BindingNavigatorSaveItem.Enabled = false;
                DataFinalize = true;
            }
            GridEdit = false;
            RefreshGridView();
            // Else
            // gblMessage = "Please select valid wholesaler for purchase return."
            // frmMsgStatus.ShowDialog(Me)
            // End If
        }

        private void ValidatePurchases(string strFind, string strDate)
        {
            // Procedure to update status of purchases to avoid duplication
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            string cmdText = "UPDATE PURCHASE SET PRCH_STATUS = N'UPDATED' WHERE (PRCH_CD = N'" + strFind.Trim() + "' AND PRCH_DATE = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(strDate.Trim()), "yyyy-MM-dd") + " 00:00:00',102))";

            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {

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

        private void Updt_General_Journal(double TotalAmount, double Total_Qty, int strSupplierID, string strDate, string strDesc)
        {
            // Function to add item if does not exist in item table.
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            double Trans_ID, Opn_Bal, Clo_Bal;
            string Supplier_Name = string.Empty;
            Trans_ID = 0d;
            Opn_Bal = 0d;
            Clo_Bal = 0d;
            // To made general journal transaction for concerned suppliers while update products
            double Max_Tr = mdlGeneral.GenerateMax_ID("SUPPLIERS_PAYM", "SUPL_TR_ID");

            string Get_Supplier = "select * from suppliers where supl_code = " + strSupplierID;
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.Suppliers, Get_Supplier, mdlGeneral.Connection);
            var SuppliersReader = mdlGeneral.Suppliers.SelectCommand.ExecuteReader();
            if (SuppliersReader.HasRows)
            {
                while (SuppliersReader.Read())
                {
                    Supplier_Name = SuppliersReader["SUPL_NAME"].ToString().Trim();
                    Opn_Bal = Conversion.Val(SuppliersReader["SUPL_BALANCE"].ToString().Trim());
                }
                if (SuppliersReader is null)
                    SuppliersReader.Close();
            }
            else
            {
                Opn_Bal = 0d;
            }

            Trans_ID = mdlGeneral.GenerateMax_ID("SUPPLIERS_PAYM", "SUPL_TR_ID");
            TotalAmount = TotalAmount * -1;
            Clo_Bal = Opn_Bal - TotalAmount;

            // If CheckRecordExists(strCode.ToString, "ITEMS", "ITEM_CODE") = False Then
            string cmdText = "INSERT INTO SUPPLIERS_PAYM VALUES ('" + strSupplierID + "','" + Strings.Format(DateTime.Parse(txtDate.Text.ToString()), "MM/dd/yyyy") + "','" + Trans_ID + "','" + Supplier_Name + "','" + "Purchases (" + strDesc.Trim() + ") returns (" + Total_Qty + ")'," + Opn_Bal + "," + TotalAmount + ",0," + Clo_Bal + ",'" + Strings.Format(DateTime.Parse(strDate.ToString()), "MM/dd/yyyy") + "')";

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

        public int Supplier_ID(string strName)
        {
            int Supplier_IDRet = default;
            string ID_Text = "SELECT SUPL_CODE FROM SUPPLIERS WHERE SUPL_NAME = N'" + strName.Trim() + "'";
            using (var Conn = new SqlConnection("Data Source=" + mdlGeneral.ServerName + ";Initial Catalog=" + mdlGeneral.ServerDatabase + ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))
            {
                var Cmd = new SqlCommand(ID_Text, Conn);
                try
                {
                    Conn.Open();
                    if (Cmd.ExecuteScalar() is DBNull)
                    {
                        Supplier_IDRet = 0;
                    }
                    else
                    {
                        Supplier_IDRet = (int)Math.Round(Convert.ToDecimal(Cmd.ExecuteScalar()));
                    }
                }
                catch (Exception EX)
                {
                    Interaction.MsgBox(EX.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
                return Supplier_IDRet;
            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbCompany.Focus();
        }

    }
}