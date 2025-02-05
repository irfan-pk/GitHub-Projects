using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class Purchases
    {
        private int Max_ID, Supplr_ID;
        private bool drag, newrec, updatable, editmode, DataFinalize, GridEdit;
        private double OldPPrie, OldSalePrice, OldQuantity, OldSchR1, OldSchR2, OldSchR3, OldSchQ1, OldSchQ2, OldSchQ3, NewPPrice, NewQuantity, NewSchR1, NewSchR2, NewSchR3, NewSchQ1, NewSchQ2, NewSchQ3;
        private int mousex, mousey;

        public Purchases()
        {
            InitializeComponent();
        }

        #region Forms and TextBoxes Events

        private void frmPurchases_KeyDown(object sender, KeyEventArgs e)
        {

            bool bHandled = false;
            switch (e.Modifiers)
            {
                case Keys.Control:
                    {
                        if (e.KeyCode == Keys.S)
                        {
                            e.Handled = true;
                            // Write down saving Procedure
                            SaveCurrentChanges();
                        }

                        break;
                    }
            }

        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbCompany.Focus();
        }

        private void frmPurchases_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void frmPurchases_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void frmPurchases_MouseUp(object sender, MouseEventArgs e)
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

        private void txtCode_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtCode);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Alpha Numeric input allowed only
            // 97 - 122 = Ascii codes for simple letters
            // 65 - 90  = Ascii codes for capital letters
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) > 64 & Strings.Asc(e.KeyChar) < 91 | Strings.Asc(e.KeyChar) > 96 & Strings.Asc(e.KeyChar) < 123 | Strings.Asc(e.KeyChar) > 47 & Strings.Asc(e.KeyChar) < 58) // Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 46
            {
            }
            // Go Through
            else
            {
                e.KeyChar = default;
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

        private void txtDesc_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtDesc);
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Alpha Numeric input allowed only
            // 97 - 122 = Ascii codes for simple letters
            // 65 - 90  = Ascii codes for capital letters
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) > 64 & Strings.Asc(e.KeyChar) < 91 | Strings.Asc(e.KeyChar) > 96 & Strings.Asc(e.KeyChar) < 123 | Strings.Asc(e.KeyChar) > 47 & Strings.Asc(e.KeyChar) < 58 | Strings.Asc(e.KeyChar) == 8 | Strings.Asc(e.KeyChar) == 32 | Strings.Asc(e.KeyChar) == 46)
            {
            }
            // Go Through
            // uncommit following routine when need only First Letter capitalized of text
            // If e.KeyChar <> ChrW(Keys.Back) Then
            // If txtDesc.Text = "" Then
            // e.KeyChar = UCase(e.KeyChar)
            // End If
            // End If
            else
            {
                e.KeyChar = default;
            }
        }

        private void txtDesc_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtDesc);
            txtDesc.Text = Strings.StrConv(txtDesc.Text.Trim(), VbStrConv.ProperCase);

        }

        private void txtMargin_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtMargin);
        }

        private void txtMargin_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtMargin, txtSalePrice);
        }

        private void txtMargin_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtMargin);
        }

        private void txtEDuty_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtEDuty);
        }

        private void txtEDuty_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtEDuty, txtMargin);
        }

        private void txtEDuty_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtEDuty);
        }

        private void txtITax_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtITax);
        }

        private void txtITax_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtITax, txtEDuty);
        }

        private void txtITax_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtITax);
        }

        private void txtMin_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtMin);
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtMin_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtMin);
        }

        private void txtPck_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtPck);
        }

        private void txtPck_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Alpha input allowed only
            // 97 - 122 = Ascii codes for simple letters
            // 65 - 90  = Ascii codes for capital letters
            if (Strings.Asc(e.KeyChar) > 64 & Strings.Asc(e.KeyChar) < 91 | Strings.Asc(e.KeyChar) > 96 & Strings.Asc(e.KeyChar) < 123)
            {
            }
            // Go Through
            else
            {
                e.KeyChar = default;
            }
        }

        private void txtPck_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtPck);
        }

        private void txtPPrice_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtPPrice);
        }

        private void txtPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtPPrice, txtQty);
        }

        private void txtPPrice_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtPPrice);
        }

        private void txtQty_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtQty);
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMargin.Focus();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtQty_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtQty);
        }

        private void txtSalePrice_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSalePrice);
            txtSalePrice.Text = (Conversion.Val(txtPPrice.Text) + Conversion.Val(txtVAT.Text.Trim()) + Conversion.Val(txtITax.Text.Trim()) + Conversion.Val(txtEDuty.Text.Trim()) + Conversion.Val(txtMargin.Text.Trim())).ToString();
        }

        private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Conversion.Val(txtPPrice.Text) < 1d)
                {
                    mdlGeneral.gblMessage = "Purchase Price invalid ?";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                txtMargin.Text = (Conversion.Val(txtSalePrice.Text) - Conversion.Val(txtPPrice.Text) - Conversion.Val(txtVAT.Text.Trim()) - Conversion.Val(txtITax.Text.Trim()) - Conversion.Val(txtEDuty.Text.Trim())).ToString();
                txtSalePrice.Text = (Conversion.Val(txtPPrice.Text) + Conversion.Val(txtVAT.Text.Trim()) + Conversion.Val(txtITax.Text.Trim()) + Conversion.Val(txtEDuty.Text.Trim()) + Conversion.Val(txtMargin.Text.Trim())).ToString();
                txtDiscount.Text = (Conversion.Val(txtSalePrice.Text) * 0.01d).ToString();
                txtDiscount.Focus();
                BindingNavigatorSave.Enabled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtSalePrice_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSalePrice);
            if (Conversion.Val(txtSalePrice.Text) < 1d)
            {
                mdlGeneral.gblMessage = "Purchase Price invalid ?";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                txtSalePrice.Text = 0.ToString();
                return;
            }
            txtMargin.Text = (Conversion.Val(txtSalePrice.Text) - Conversion.Val(txtPPrice.Text) - Conversion.Val(txtVAT.Text.Trim()) - Conversion.Val(txtITax.Text.Trim()) - Conversion.Val(txtEDuty.Text.Trim())).ToString();
            txtSalePrice.Text = (Conversion.Val(txtPPrice.Text) + Conversion.Val(txtVAT.Text.Trim()) + Conversion.Val(txtITax.Text.Trim()) + Conversion.Val(txtEDuty.Text.Trim()) + Conversion.Val(txtMargin.Text.Trim())).ToString();
            txtDiscount.Text = (Conversion.Val(txtSalePrice.Text) * 0.01d).ToString();
            txtDiscount.Focus();
            BindingNavigatorSave.Enabled = true;
        }

        private void txtSch1_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSch1);
        }

        private void txtSch1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtSch1_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSch1);
        }

        private void txtSch2_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSch2);
        }

        private void txtSch2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtSch2_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSch2);
        }

        private void txtSQty1_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSQty1);
        }

        private void txtSQty1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtSQty1_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSQty1);
        }

        private void txtSQty3_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSQty3);
        }

        private void txtSQty3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtSQty3_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSQty3);
        }

        private void txtVAT_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtVAT);
        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtVAT, txtITax);
        }

        private void txtVAT_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtVAT);
        }

        private void txtSch3_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSch3);
        }

        private void txtSch3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtSch3_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSch3);
        }

        private void txtSQty2_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSQty2);
        }

        private void txtSQty2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtSQty2_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSQty2);
        }

        private void cmbCatg_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(cmbCatg);
        }

        private void cmbCatg_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Alpha input allowed only
            // 97 - 122 = Ascii codes for simple letters
            // 65 - 90  = Ascii codes for capital letters
            if (Strings.Asc(e.KeyChar) > 64 & Strings.Asc(e.KeyChar) < 91 | Strings.Asc(e.KeyChar) > 96 & Strings.Asc(e.KeyChar) < 123)
            {
            }
            // Go Through
            else
            {
                e.KeyChar = default;
            }
        }

        private void cmbCatg_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(cmbCatg);
        }

        private void cmbCompany_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(cmbCompany);
            RefreshGridView();
        }

        private void cmbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCode.Focus();
        }

        private void cmbCompany_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(cmbCompany);
        }

        private void txtDiscount_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtDiscount);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        private void txtDiscount_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtDiscount);
        }

        private void BindingNavigatorSave_Click(object sender, EventArgs e)
        {
            if (Conversion.Val(txtSalePrice.Text) > 0d)
                SaveCurrentChanges();
        }

        private void Get_Text_Values()
        {

            if (PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[0].Value.ToString().Trim() is null)
            {
                mdlGeneral.gblMessage = "There is no product to edit.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                return;
            }
            // EDIT PROCEDURE WHILE UPDATE PURCHASES
            if (PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[23].Value.ToString().Trim() == "ADDED")
            {
                txtCode.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                mdlGeneral.gblFind = txtCode.Text.Trim();
                txtDesc.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[2].Value.ToString().Trim();
                cmbCatg.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[3].Value.ToString();
                cmbCompany.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[4].Value.ToString().Trim();
                txtDate.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[5].Value.ToString();
                txtPck.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[6].Value.ToString();
                txtPPrice.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[7].Value.ToString();
                txtQty.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[8].Value.ToString();
                txtMin.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[10].Value.ToString();
                txtSch1.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[11].Value.ToString();
                txtSQty1.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[12].Value.ToString();
                txtSch2.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[13].Value.ToString();
                txtSQty2.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[14].Value.ToString();
                txtSch3.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[15].Value.ToString();
                txtSQty3.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[16].Value.ToString();
                txtVAT.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[17].Value.ToString();
                txtITax.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[18].Value.ToString();
                txtEDuty.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[19].Value.ToString();
                txtDiscount.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[20].Value.ToString();
                txtMargin.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[21].Value.ToString();
                txtSalePrice.Text = PurchaseDataGridView.Rows[PurchaseDataGridView.CurrentRow.Index].Cells[22].Value.ToString();
                editmode = true;
                txtCode.ReadOnly = true;
                txtDesc.ReadOnly = true;
                Lock_TextBoxes("False");
                txtQty.Focus();
            }
            else
            {
                // gblMessage = "Changes cannot be made, product updated."
                // frmStatus.ShowDialog(Me)
                editmode = false;
            }
        }

        #endregion

        #region Form Coding Area

        private void frmPurchases_Load(object sender, EventArgs e)
        {

            mdlGeneral.GetConnectionString();
            newrec = false;
            updatable = false;
            FormBorderStyle = FormBorderStyle.None;
            // Popup the Company Data Combo
            SqlDataReader Popup_Reader;
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, "SELECT DISTINCT SUPL_CODE, SUPL_NAME FROM SUPPLIERS ORDER BY SUPL_NAME", mdlGeneral.Connection);
            Popup_Reader = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (Popup_Reader.HasRows)
            {
                while (Popup_Reader.Read())
                    cmbCompany.Items.Add(Popup_Reader["SUPL_CODE"].ToString().Trim() + " - " + Popup_Reader["SUPL_NAME"].ToString().Trim());
            }
            else
            {
                // Go through
            }
            // Retrieve Records for datagrid view from purchase table
            RefreshGridView();
            DataFinalize = false;

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
                        cmbCatg.Text = DataCheck["PROD_CATG"].ToString().Trim();
                        txtPck.Text = DataCheck["PROD_PACK"].ToString().Trim();
                        OldQuantity = Conversion.Val(DataCheck["PROD_ONHAND"].ToString().Trim());
                        txtPPrice.Text = DataCheck["PROD_PPRICE"].ToString().Trim();
                        OldPPrie = Conversion.Val(DataCheck["PROD_PPRICE"].ToString().Trim());
                        txtMin.Text = DataCheck["PROD_BAL_MIN"].ToString().Trim();
                        txtSch1.Text = DataCheck["PROD_SCH1_PRICE"].ToString().Trim();
                        OldSchR1 = Conversion.Val(DataCheck["PROD_SCH1_PRICE"].ToString().Trim());
                        txtSQty1.Text = DataCheck["PROD_SCH1_ONHAND"].ToString().Trim();
                        OldSchQ1 = Conversion.Val(DataCheck["PROD_SCH1_ONHAND"].ToString().Trim());
                        txtSch2.Text = DataCheck["PROD_SCH2_PRICE"].ToString().Trim();
                        OldSchR2 = Conversion.Val(DataCheck["PROD_SCH2_PRICE"].ToString().Trim());
                        txtSQty2.Text = DataCheck["PROD_SCH2_ONHAND"].ToString().Trim();
                        OldSchQ2 = Conversion.Val(DataCheck["PROD_SCH2_ONHAND"].ToString().Trim());
                        txtSch3.Text = DataCheck["PROD_SCH3_PRICE"].ToString().Trim();
                        OldSchR3 = Conversion.Val(DataCheck["PROD_SCH3_PRICE"].ToString().Trim());
                        txtSQty3.Text = DataCheck["PROD_SCH3_ONHAND"].ToString().Trim();
                        OldSchQ3 = Conversion.Val(DataCheck["PROD_SCH3_ONHAND"].ToString().Trim());
                        txtVAT.Text = DataCheck["PROD_VAT"].ToString().Trim();
                        txtITax.Text = DataCheck["PROD_ITAX"].ToString().Trim();
                        txtEDuty.Text = DataCheck["PROD_EX_DUTY"].ToString().Trim();
                        txtMargin.Text = DataCheck["PROD_PROFIT"].ToString().Trim();
                        txtSalePrice.Text = DataCheck["PROD_SPRICE"].ToString().Trim();
                        OldSalePrice = Conversion.Val(DataCheck["PROD_SPRICE"].ToString().Trim());
                    }
                    if (DataCheck is null)
                        DataCheck.Close();
                    updatable = true;
                    newrec = false;
                    if (Conversion.Val(txtSch1.Text) > 0d)
                    {
                        txtSch1.ReadOnly = true;
                        txtSQty1.ReadOnly = true;
                    }
                    if (Conversion.Val(txtSch2.Text) > 0d)
                    {
                        txtSch2.ReadOnly = true;
                        txtSQty2.ReadOnly = true;
                    }
                    if (Conversion.Val(txtSch3.Text) > 0d)
                    {
                        txtSch3.ReadOnly = true;
                        txtSQty3.ReadOnly = true;
                    }
                    txtPPrice.Focus();
                    return;
                }
                if (DataCheck is null)
                    DataCheck.Close();

                // Second if not found any product in firt step then go to add new stock mode
                SqlDataReader GetNewItem;
                string FindItem = "SELECT * FROM POS.dbo.ITEMS WHERE ITEM_CODE = N'" + txtCode.Text.ToString().Trim() + "'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, FindItem, mdlGeneral.Connection);
                GetNewItem = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
                if (GetNewItem.HasRows)
                {
                    RefreshTextBoxes();
                    while (GetNewItem.Read())
                    {
                        txtDesc.Text = GetNewItem["ITEM_NAME"].ToString().Trim();
                        cmbCatg.Text = GetNewItem["ITEM_CATG"].ToString().Trim();
                        txtPck.Text = GetNewItem["ITEM_PCKG"].ToString().Trim();
                        // txtPPrice.Text = GetNewItem.Item("ITEM_PRICE").ToString.Trim
                    }
                    if (GetNewItem is null)
                        GetNewItem.Close();
                    OldQuantity = 0d;
                    OldPPrie = 0d;
                    OldSalePrice = 0d;
                    OldSchQ1 = 0d;
                    OldSchQ2 = 0d;
                    OldSchQ3 = 0d;
                    OldSchR1 = 0d;
                    OldSchR2 = 0d;
                    OldSchR3 = 0d;
                    txtSch1.Enabled = true;
                    txtSQty1.Enabled = true;
                    txtSch2.Enabled = true;
                    txtSQty2.Enabled = true;
                    txtSch3.Enabled = true;
                    txtSQty3.Enabled = true;
                    Lock_TextBoxes("False");
                    txtVAT.Focus();
                    newrec = true;
                    updatable = false;
                }

            }
        }

        private void RefreshTextBoxes()
        {

            // REFRESH FIELDS FOR NEW RECORD
            // Me.txtCode.Clear()
            txtPck.Text = "PCS";
            txtDesc.Clear();
            cmbCatg.Text = string.Empty;
            txtPPrice.Text = "0";
            txtSch1.Text = "0";
            txtSQty1.Text = "0";
            txtSch2.Text = "0";
            txtSQty2.Text = "0";
            txtSch3.Text = "0";
            txtSQty3.Text = "0";
            txtMin.Text = "1";
            txtQty.Text = "0";
            txtITax.Text = "0";
            txtVAT.Text = "0";
            txtEDuty.Text = "0";
            txtSalePrice.Text = "0";
            txtMargin.Text = "0";
            txtDiscount.Text = "0";

        }

        private void Lock_TextBoxes(string Stat)
        {

            txtMin.ReadOnly = Conversions.ToBoolean(Stat);
            txtPck.ReadOnly = Conversions.ToBoolean(Stat);
            txtVAT.ReadOnly = Conversions.ToBoolean(Stat);
            txtITax.ReadOnly = Conversions.ToBoolean(Stat);
            txtEDuty.ReadOnly = Conversions.ToBoolean(Stat);
            txtMargin.ReadOnly = Conversions.ToBoolean(Stat);
            txtSalePrice.ReadOnly = Conversions.ToBoolean(Stat);
            txtDiscount.ReadOnly = Conversions.ToBoolean(Stat);

        }

        private void RefreshGridView()
        {
            try
            {
                // Retrieve Records for datagrid view from purchase table
                PurchaseDataSet.Clear();
                mdlGeneral.PurchaseAdapter.Dispose();
                // Dim PurchasesQuery As String = "SELECT * FROM PURCHASE WHERE PRCH_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(txtDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)"
                string PurchasesQuery = "SELECT * FROM PURCHASE WHERE (PRCH_STATUS = N'ADDED')";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.PurchaseAdapter, PurchasesQuery, mdlGeneral.Connection);
                mdlGeneral.PurchaseAdapter.Fill(PurchaseDataSet, "PURCHASE");
                var reader1 = mdlGeneral.PurchaseAdapter.SelectCommand.ExecuteReader();
                if (reader1.HasRows)
                {
                    BindingNavigatorSaveItem.Enabled = true;
                    BindingNavigatorRefreshItem.Enabled = true;
                    PurchaseBindingSource.DataSource = PurchaseDataSet;
                    PurchaseBindingSource.DataMember = "PURCHASE";
                    PurchaseDataGridView.Refresh();
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

        private void SaveCurrentChanges()
        {
            if (CheckRecordExists(Strings.Mid(cmbCompany.Text.Trim(), 1, 4), "SUPPLIERS", "SUPL_CODE") == true)
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

                if (newrec == false)
                {
                    if (OldSchR1 != Conversion.Val(txtSch1.Text))
                        NewSchR1 = Conversion.Val(txtSch1.Text);
                    else
                        NewSchR1 = 0d;
                    if (OldSchR2 != Conversion.Val(txtSch2.Text))
                        NewSchR2 = Conversion.Val(txtSch2.Text);
                    else
                        NewSchR2 = 0d;
                    if (OldSchR3 != Conversion.Val(txtSch3.Text))
                        NewSchR3 = Conversion.Val(txtSch3.Text);
                    else
                        NewSchR3 = 0d;
                    if (OldSchQ1 != Conversion.Val(txtSQty1.Text))
                        NewSchQ1 = Conversion.Val(txtSQty1.Text) + OldSchQ1;
                    else
                        NewSchQ1 = 0d;
                    if (OldSchQ2 != Conversion.Val(txtSQty2.Text))
                        NewSchQ2 = Conversion.Val(txtSQty2.Text) + OldSchQ2;
                    else
                        NewSchQ2 = 0d;
                    if (OldSchQ3 != Conversion.Val(txtSQty3.Text))
                        NewSchQ3 = Conversion.Val(txtSQty3.Text) + OldSchQ3;
                    else
                        NewSchQ3 = 0d;
                }
                // If Val(txtQty.Text.Trim) = 0 Then NewPPrice = 0 : NewQuantity = 0
                else
                {
                    NewSchR1 = Conversion.Val(txtSch1.Text);
                    NewSchR2 = Conversion.Val(txtSch2.Text);
                    NewSchR3 = Conversion.Val(txtSch3.Text);
                    NewSchQ1 = Conversion.Val(txtSQty1.Text);
                    NewSchQ2 = Conversion.Val(txtSQty2.Text);
                    NewSchQ3 = Conversion.Val(txtSQty3.Text);
                }

                string CheckQuery = "SELECT * FROM PURCHASE WHERE PRCH_CD = N'" + txtCode.Text.Trim() + "' AND PRCH_SUPPLIER = N'" + cmbCompany.Text.Trim() + "' AND PRCH_DATE = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102)";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CheckQuery, mdlGeneral.Connection);
                var Finder = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
                if (Finder.HasRows)
                {
                    Lock_TextBoxes("True");
                    if (editmode == true)
                    {
                        txtSalePrice.Text = (Conversion.Val(txtPPrice.Text) + Conversion.Val(txtVAT.Text.Trim()) + Conversion.Val(txtITax.Text.Trim()) + Conversion.Val(txtEDuty.Text.Trim()) + Conversion.Val(txtMargin.Text.Trim())).ToString();
                        txtMargin.Text = (Conversion.Val(txtSalePrice.Text) - Conversion.Val(txtPPrice.Text) - Conversion.Val(txtVAT.Text.Trim()) - Conversion.Val(txtITax.Text.Trim()) - Conversion.Val(txtEDuty.Text.Trim())).ToString();
                        txtDiscount.Text = (Conversion.Val(txtSalePrice.Text) * 0.01d).ToString();
                        string InsertRecord = "UPDATE PURCHASE SET " + "PRCH_CATG = '" + cmbCatg.Text.Trim() + "', " + "PRCH_PACK = '" + txtPck.Text.Trim() + "', " + "PRCH_PRICE = " + Conversion.Val(txtPPrice.Text.Trim()) + ", " + "PRCH_QTY = " + Conversion.Val(txtQty.Text.Trim()) + ", " + "PRCH_BAL_MIN = " + Conversion.Val(txtMin.Text.Trim()) + ", " + "PRCH_SCH1_PRICE = " + NewSchR1 + ", " + "PRCH_SCH1_ONHAND = " + NewSchQ1 + ", " + "PRCH_SCH2_PRICE = " + NewSchR2 + ", " + "PRCH_SCH2_ONHAND = " + NewSchQ2 + ", " + "PRCH_SCH3_PRICE = " + NewSchR3 + ", " + "PRCH_SCH3_ONHAND = " + NewSchQ3 + ", " + "PRCH_VAT = " + Conversion.Val(txtVAT.Text.Trim()) + ", " + "PRCH_ITAX = " + Conversion.Val(txtITax.Text.Trim()) + ", " + "PRCH_EX_DUTY = " + Conversion.Val(txtEDuty.Text.Trim()) + ", " + "PRCH_PROFIT = " + Conversion.Val(txtMargin.Text.Trim()) + ", " + "PRCH_DISC_MRG = " + Conversion.Val(txtMargin.Text.Trim()) * 0.01d + ", " + "PRCH_SPRICE = " + Conversion.Val(txtSalePrice.Text.Trim()) + ", " + "PRCH_DATE = '" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString().Trim()), "MM/dd/yyyy") + "', " + "PRCH_SUPPLIER = '" + cmbCompany.Text.Trim() + "', PRCH_STATUS ='ADDED' " + "WHERE (PRCH_CD = N'" + mdlGeneral.gblFind + "' AND PRCH_STATUS = N'ADDED' AND PRCH_DATE = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102))";



















                        mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, InsertRecord, mdlGeneral.Connection);
                        editmode = false;
                        RefreshGridView();
                        RefreshTextBoxes();
                        txtCode.Clear();
                        editmode = false;
                        txtCode.ReadOnly = false;
                        txtDesc.ReadOnly = false;
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
                    Lock_TextBoxes("False");
                    txtSalePrice.Text = (Conversion.Val(txtPPrice.Text) + Conversion.Val(txtVAT.Text.Trim()) + Conversion.Val(txtITax.Text.Trim()) + Conversion.Val(txtEDuty.Text.Trim()) + Conversion.Val(txtMargin.Text.Trim())).ToString();
                    txtMargin.Text = (Conversion.Val(txtSalePrice.Text) - Conversion.Val(txtPPrice.Text) - Conversion.Val(txtVAT.Text.Trim()) - Conversion.Val(txtITax.Text.Trim()) - Conversion.Val(txtEDuty.Text.Trim())).ToString();
                    txtDiscount.Text = (Conversion.Val(txtSalePrice.Text) * 0.01d).ToString();
                    string InsertRecord = "INSERT INTO PURCHASE (PRCH_TR_ID,PRCH_CD,PRCH_DESC,PRCH_CATG,PRCH_PACK,PRCH_PRICE,PRCH_QTY,PRCH_OLD_QTY,PRCH_BAL_MIN,PRCH_SCH1_PRICE,PRCH_SCH1_ONHAND,PRCH_SCH2_PRICE,PRCH_SCH2_ONHAND,PRCH_SCH3_PRICE,PRCH_SCH3_ONHAND,PRCH_VAT,PRCH_ITAX,PRCH_EX_DUTY,PRCH_PROFIT,PRCH_DISC_MRG,PRCH_SPRICE,PRCH_DATE,PRCH_SUPPLIER,PRCH_STATUS) " + "VALUES (" + Max_Tr_ID + ",'" + txtCode.Text.Trim() + "','" + txtDesc.Text.Trim() + "','" + cmbCatg.Text.Trim() + "','" + txtPck.Text.Trim() + "'," + Conversion.Val(txtPPrice.Text.Trim()) + "," + Conversion.Val(txtQty.Text.Trim()) + "," + OldQuantity + "," + Conversion.Val(txtMin.Text.Trim()) + "," + NewSchR1 + "," + NewSchQ1 + "," + NewSchR2 + "," + NewSchQ2 + "," + NewSchR3 + "," + NewSchQ3 + "," + Conversion.Val(txtVAT.Text.Trim()) + "," + Conversion.Val(txtITax.Text.Trim()) + "," + Conversion.Val(txtEDuty.Text.Trim()) + "," + Conversion.Val(txtMargin.Text.Trim()) + "," + Conversion.Val(txtDiscount.Text) + "," + Conversion.Val(txtSalePrice.Text.Trim()) + ",'" + Strings.Format(DateTime.Parse(txtDate.Text.Trim().ToString().Trim()), "MM/dd/yyyy") + "','" + cmbCompany.Text.Trim() + "','ADDED')";






















                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, InsertRecord, mdlGeneral.Connection);
                    BindingNavigatorSaveItem.Enabled = true;
                    BindingNavigatorRefreshItem.Enabled = true;
                    RefreshTextBoxes();
                    RefreshGridView();
                    txtCode.Clear();
                    txtCode.Focus();
                }
            }
            else
            {
                mdlGeneral.gblMessage = "Please select valid wholesaler.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
            }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // If CheckRecordExists(Mid(cmbCompany.Text.Trim, 1, 4), "SUPPLIERS", "SUPL_CODE") = True Then
            string UpdtRecQuery = string.Empty;
            string Clos_Balance = string.Empty;
            Max_ID = 0;

            // Final Routine to update the products from purchases by date
            string TransferQuery = "SELECT * FROM PURCHASE WHERE PRCH_STATUS = N'ADDED' ORDER BY PRCH_TR_ID";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.TransferAdapter, TransferQuery, mdlGeneral.Connection);
            var TransferReader = mdlGeneral.TransferAdapter.SelectCommand.ExecuteReader();

            if (TransferReader.HasRows)
            {
                while (TransferReader.Read())
                {
                    if (ValidateDelete(TransferReader["PRCH_CD"].ToString(), TransferReader["PRCH_DATE"].ToString()) == false)
                    {
                        UpdtRecQuery = string.Empty;
                        if (CheckRecordExists(TransferReader["PRCH_CD"].ToString(), "PRODUCTS", "PROD_CD") == false)
                        {
                            // ADD NEW RECORD INTO PRODUCT TABLE
                            UpdtRecQuery = "INSERT INTO PRODUCTS VALUES ('" + TransferReader["PRCH_CD"].ToString() + "','" + TransferReader["PRCH_DESC"].ToString().Trim() + "','" + TransferReader["PRCH_CATG"].ToString().Trim() + "','" + TransferReader["PRCH_PACK"].ToString().Trim() + "'," + Conversion.Val(TransferReader["PRCH_PRICE"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_QTY"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_BAL_MIN"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_SCH1_PRICE"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_SCH1_ONHAND"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_SCH2_PRICE"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_SCH2_ONHAND"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_SCH3_PRICE"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_SCH3_ONHAND"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_VAT"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_ITAX"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_EX_DUTY"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_PROFIT"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_DISC_MRG"].ToString()) + "," + Conversion.Val(TransferReader["PRCH_SPRICE"].ToString()) + ",'" + Strings.Format(DateTime.Parse(TransferReader["PRCH_DATE"].ToString()), "MM/dd/yyyy") + "','" + Strings.Format(DateTime.Parse(txtDate.Text.ToString().Trim()), "MM/dd/yyyy") + "')";





















                            // ADD ITEM INFORMATION INTO ITEM TABLE
                            AddNewItem(TransferReader["PRCH_CD"].ToString(), TransferReader["PRCH_DESC"].ToString(), TransferReader["PRCH_CATG"].ToString(), TransferReader["PRCH_PACK"].ToString(), TransferReader["PRCH_PRICE"].ToString());



                        }
                        else
                        {
                            // UPDATE RECORD INTO PRODUCT TABLE
                            UpdtRecQuery = "UPDATE PRODUCTS SET " + "PROD_PPRICE = " + Conversion.Val(TransferReader["PRCH_PRICE"].ToString()) + ", " + "PROD_ONHAND = PROD_ONHAND + " + Conversion.Val(TransferReader["PRCH_QTY"].ToString()) + ", " + "PROD_SCH1_PRICE = PROD_SCH1_PRICE + " + Conversion.Val(TransferReader["PRCH_SCH1_PRICE"].ToString()) + ", " + "PROD_SCH1_ONHAND = PROD_SCH1_ONHAND + " + Conversion.Val(TransferReader["PRCH_SCH1_ONHAND"].ToString()) + ", " + "PROD_SCH2_PRICE = PROD_SCH2_PRICE + " + Conversion.Val(TransferReader["PRCH_SCH2_PRICE"].ToString()) + ", " + "PROD_SCH2_ONHAND = PROD_SCH2_ONHAND + " + Conversion.Val(TransferReader["PRCH_SCH2_ONHAND"].ToString()) + ", " + "PROD_SCH3_PRICE = PROD_SCH3_PRICE + " + Conversion.Val(TransferReader["PRCH_SCH3_PRICE"].ToString()) + ", " + "PROD_SCH3_ONHAND = PROD_SCH3_ONHAND + " + Conversion.Val(TransferReader["PRCH_SCH3_ONHAND"].ToString()) + ", " + "PROD_DATE = '" + Strings.Format(DateTime.Parse(TransferReader["PRCH_DATE"].ToString()), "MM/dd/yyyy") + "', " + "PROD_UPD_ON = '" + Strings.Format(DateTime.Parse(txtDate.Text.ToString().Trim()), "MM/dd/yyyy") + "' " + "WHERE (PROD_CD = N'" + TransferReader["PRCH_CD"].ToString() + "')";










                        }
                        mdlGeneral.ExecuteAdapterQuery(mdlGeneral.TransferAdapter, UpdtRecQuery, mdlGeneral.Connection);

                        // To update suppliers balances
                        Max_ID = mdlGeneral.GenerateMax_ID("SUPPLIERS", "SUPL_CODE");
                        if (Max_ID == 1)
                            Max_ID = Max_ID + 1000;

                        double Total_Amount = Conversion.Val(TransferReader["PRCH_PRICE"].ToString()) * Conversion.Val(TransferReader["PRCH_QTY"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH1_PRICE"].ToString()) * Conversion.Val(TransferReader["PRCH_SCH1_ONHAND"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH2_PRICE"].ToString()) * Conversion.Val(TransferReader["PRCH_SCH2_ONHAND"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH3_PRICE"].ToString()) * Conversion.Val(TransferReader["PRCH_SCH3_ONHAND"].ToString());




                        double Total_Quantity = Conversion.Val(TransferReader["PRCH_QTY"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH1_ONHAND"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH2_ONHAND"].ToString()) + Conversion.Val(TransferReader["PRCH_SCH3_ONHAND"].ToString());



                        // To update journal transactions
                        if (Total_Amount > 0d)
                        {
                            // MsgBox(Mid(TransferReader.Item("PRCH_SUPPLIER").ToString, 8, 42))
                            // Dim SupplierName As String = Mid(TransferReader.Item("PRCH_SUPPLIER").ToString, 8, 42)
                            Supplr_ID = Supplier_ID(Strings.Mid(TransferReader["PRCH_SUPPLIER"].ToString(), 8, 42));

                            Updt_General_Journal(Total_Amount, Total_Quantity, Supplr_ID, TransferReader["PRCH_DATE"].ToString(), TransferReader["PRCH_DESC"].ToString());
                            if (CheckRecordExists(Strings.Mid(TransferReader["PRCH_SUPPLIER"].ToString(), 1, 4), "SUPPLIERS", "SUPL_CODE") == true)
                            {
                                // TEMPORARILY SKIP
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
            // gblMessage = "Please select valid wholesaler for purchases."
            // frmMsgStatus.ShowDialog(Me)
            // End If
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

        private void AddNewItem(string strCode, string strName, string strCatg, string strPack, string strPrice)
        {
            // Function to add item if does not exist in item table.
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            if (CheckRecordExists(strCode.ToString(), "ITEMS", "ITEM_CODE") == false)
            {
                string cmdText = "INSERT INTO ITEMS VALUES ('" + strCode.Trim() + "','" + strName.Trim() + "','" + strCatg.Trim() + "','" + strPack.Trim() + "'," + Conversion.Val(strPrice) + ")";

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

        private void Updt_General_Journal(double strPrice, double Total_Qty, int strSupplierID, string strDate, string strDesc)
        {
            // To made general journal transaction for concerned suppliers while update products
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            double Trans_ID, Opn_Bal, Clo_Bal;
            string Supplier_Name = string.Empty;
            Trans_ID = 0d;
            Opn_Bal = 0d;
            Clo_Bal = 0d;

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
            Clo_Bal = Opn_Bal + strPrice;

            string cmdText = "INSERT INTO SUPPLIERS_PAYM VALUES ('" + strSupplierID + "','" + Strings.Format(DateTime.Parse(txtDate.Text.ToString()), "MM/dd/yyyy") + "','" + Trans_ID + "','" + Supplier_Name.ToString().Trim() + "','" + "Purchases (" + strDesc.Trim() + ") Qty. (" + Total_Qty + ")'," + Opn_Bal + ",0," + strPrice + "," + Clo_Bal + ",'" + Strings.Format(DateTime.Parse(strDate.ToString()), "MM/dd/yyyy") + "')";

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

        private void UpdateProduct(string strFind, string strField, string strFieldData)
        {
            // Procedure to update status of purchases to avoid duplication
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            string cmdText = "UPDATE products SET " + strField + " = " + strFieldData + " WHERE (PROD_CD = N'" + strFind.Trim() + "'";

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

        #endregion

        private void txtDate_GotFocus(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void txtDate_LostFocus(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void BindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            RefreshTextBoxes();
            txtCode.Clear();
            editmode = false;
            txtCode.ReadOnly = false;
            txtDesc.ReadOnly = false;
            txtCode.Focus();
        }

        private void frmPurchases_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Get_Text_Values();
                editmode = true;
            }
            if (e.KeyCode == Keys.F8)
                PurchaseDataGridView_KeyUp(sender, e);
        }

        private void PurchaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingNavigatorRefreshItem_Click(sender, e);
        }

        private void PurchaseDataGridView_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F8)
            {
                // Move values from datagrid to variables for deletion
                string DeleteID = PurchaseDataGridView.CurrentRow.Cells[0].Value.ToString();
                string DeleteString = PurchaseDataGridView.CurrentRow.Cells[1].Value.ToString();
                string DeleteDate = PurchaseDataGridView.CurrentRow.Cells[5].Value.ToString();

                if (PurchaseDataGridView.CurrentRow.Cells[0].Value is null)
                    return;
                // Validate deletion if true then show the message on screen.
                if (ValidateDelete(DeleteString, DeleteDate) == false)
                {
                    string mResult = ((int)Interaction.MsgBox("Are you sure ot delete " + DeleteString, (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.YesNo), "Delete Entry")).ToString();
                    if (Conversions.ToDouble(mResult) == (double)MsgBoxResult.Yes)
                    {
                        mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, "DELETE FROM PURCHASE WHERE PRCH_TR_ID = N'" + DeleteID + "' AND PRCH_STATUS != N'UPDATED' AND PRCH_CD = N'" + DeleteString.Trim() + "' AND PRCH_DATE = CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(DeleteDate), "yyyy-MM-dd") + " 00:00:00',102)", mdlGeneral.Connection);
                        BindingNavigatorRefreshItem_Click(sender, e);
                        RefreshGridView();
                    }
                }
                else
                {
                    mdlGeneral.gblMessage = "Product updated, Changes cannot be made now, you must be use purchase return option.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
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

    }
}