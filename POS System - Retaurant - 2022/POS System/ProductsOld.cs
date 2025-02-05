using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class ProductsOld
    {
        private bool drag, EditMode, AddMode;
        private string EditString;
        private double PPrice;
        private int mousex, mousey, Pos;

        public ProductsOld()
        {
            InitializeComponent();
        }

        private void frmProducts_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void frmProducts_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void frmProducs_MouseUp(object sender, MouseEventArgs e)
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

        private void frmProducts_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            cmdClose.Left = Width - (cmdClose.Width + 5);
            cmdMin.Left = Width - (cmdMin.Width + cmdClose.Width + 5);
            mdlGeneral.GetConnectionString();
            Load_Data();
            // For Refresh Menu Bar when no data in gridview
            BindingNavigatorEditItem_Click(sender, e);
            BindingNavigatorEditItem_Click(sender, e);
        }

        private void Load_Data()
        {
            try
            {
                // Retrieve Records for datagrid view from product table
                ProductDataSet.Clear();
                // ProductAdapter.Dispose()
                string ProductQuery = "SELECT * FROM PRODUCTS ORDER BY PROD_CD";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.ProductAdapter, ProductQuery, mdlGeneral.Connection);
                mdlGeneral.ProductAdapter.Fill(ProductDataSet, "PRODUCTS");
                ProductBindingSource.DataSource = ProductDataSet;
                var reader2 = mdlGeneral.ProductAdapter.SelectCommand.ExecuteReader();
                if (reader2.HasRows)
                {
                    ProductBindingSource.DataSource = ProductDataSet;
                    ProductBindingSource.DataMember = "PRODUCTS";
                    ProductDataGridView.Refresh();
                    txtCode.DataBindings.Add("TEXT", ProductBindingSource, "PROD_CD");
                    txtDesc.DataBindings.Add("TEXT", ProductBindingSource, "PROD_DESC");
                    txtCatg.DataBindings.Add("TEXT", ProductBindingSource, "PROD_CATG");
                    txtPck.DataBindings.Add("TEXT", ProductBindingSource, "PROD_PACK");
                    txtMargin.DataBindings.Add("TEXT", ProductBindingSource, "PROD_PROFIT");
                    txtSalePrice.DataBindings.Add("TEXT", ProductBindingSource, "PROD_SPRICE");
                    txtPPrice.DataBindings.Add("TEXT", ProductBindingSource, "PROD_PPRICE");
                }
            }
            // BindingNavigatorSaveItem.Enabled = False
            catch (Exception EX)
            {
                Interaction.MsgBox(EX.Message, MsgBoxStyle.Information);
            }
        }

        private void Enable_Disable_Controls(string State)
        {
            BindingNavigatorMoveNextItem.Enabled = Conversions.ToBoolean(State);
            BindingNavigatorMovePreviousItem.Enabled = Conversions.ToBoolean(State);
            ProductDataGridView.Enabled = Conversions.ToBoolean(State);
            BindingNavigatorDeleteItem.Visible = Conversions.ToBoolean(State);
            // BindingNavigatorAddNewItem.Visible = State
            ToolStripSeparator2.Visible = Conversions.ToBoolean(State);
            ToolStripSeparator3.Visible = Conversions.ToBoolean(State);
        }

        private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Conversion.Val(txtSalePrice.Text) < 1d)
                {
                    mdlGeneral.gblMessage = "Product Sale Price invalid ?";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                    return;
                }
                txtMargin.Text = (Conversion.Val(txtSalePrice.Text) - Conversion.Val(txtPPrice.Text)).ToString();
                txtSalePrice.Text = (Conversion.Val(txtPPrice.Text) + Conversion.Val(txtMargin.Text.Trim())).ToString();
            }
        }

        private void txtCode_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtCode);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numeric input allowed only
            // 48 - 57  = Ascii codes for numbers
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                    e.Handled = true;
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

        private void txtSalePrice_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtSalePrice);
            txtSalePrice.Text = (Conversion.Val(txtPPrice.Text) + Conversion.Val(txtMargin.Text.Trim())).ToString();
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
            ValidateKeyPress(sender, e, txtMargin, txtSalePrice);
        }

        private void txtMargin_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtMargin);
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

        private void txtCatg_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtCatg);
        }

        private void txtCatg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCatg_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtCatg);
        }

        private void ValidateKeyPress(object sender, KeyPressEventArgs e, TextBox txt, TextBox nexttxt)
        {
            // 48 - 57  = Ascii codes for numbers
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\b')
                e.Handled = false; // allow Backspace
            if (Conversions.ToString(e.KeyChar) == "." & txt.Text.IndexOf(".") == -1)
                e.Handled = false; // allow single decimal point
                                   // If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
                                   // If e.KeyChar = Chr(13) Then nexttxt.Focus() 'Enter key moves to next control
                                   // If e.KeyChar = Chr(13) Then GetNextControl(nexttxt, True).Focus() 'Enter key moves to next control
        }

        private void BindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            if (BindingNavigatorEditItem.Text == "&Cancel")
            {
                Enable_Disable_Controls("True");
                BindingNavigatorEditItem.Text = "&Edit Product";
                EditMode = false;
                AddMode = false;
                SplitContainer1.Panel1.Enabled = false;
                BindingNavigatorSaveItem.Enabled = false;
                RefreshDB();
                return;
            }
            EditMode = true;
            AddMode = false;
            EditString = txtCode.Text.Trim();
            txtDesc.Text = txtDesc.Text.Trim();
            SplitContainer1.Panel1.Enabled = true;
            BindingNavigatorSaveItem.Enabled = true;
            Enable_Disable_Controls("False");
            BindingNavigatorEditItem.Text = "&Cancel";
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            EditMode = false;
            AddMode = true;
            EditString = 0.ToString();
            txtDesc.Text = txtDesc.Text.Trim();
            SplitContainer1.Panel1.Enabled = true;
            BindingNavigatorSaveItem.Enabled = true;
            Enable_Disable_Controls("False");
            BindingNavigatorEditItem.Text = "&Cancel";
            txtCode.Focus();
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("Are you sure to delete product ?" + Strings.Space(2) + "(" + Strings.Trim(txtCode.Text.ToUpper()) + ")", (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.OkCancel), "Delete Record");
            if (Conversions.ToBoolean(MsgBoxResult.Ok))
            {
                string CommandText = "DELETE FROM PRODUCTS WHERE PROD_CD = '" + txtCode.Text.ToUpper().Trim() + "'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CommandText, mdlGeneral.Connection);
            }
            if (BindingNavigatorEditItem.Text == "&Cancel")
                BindingNavigatorEditItem.Text = "&Edit Product";
            ProductDataGridView.Refresh();
            BindingNavigator.Refresh();
            // Call RefreshDB()
        }

        private void RefreshDB()
        {
            try
            {
                ProductDataSet.Clear();
                ProductBindingSource.EndEdit();
                mdlGeneral.ProductAdapter.Dispose();
                ProductDataGridView.Refresh();
                string QueryText = "SELECT * FROM PRODUCTS ORDER BY PROD_CD";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.ProductAdapter, mdlGeneral.SqlDataSet, QueryText, "PRODUCTS", mdlGeneral.Connection);
                mdlGeneral.ProductAdapter.Fill(ProductDataSet, "PRODUCTS");
                ProductBindingSource.DataSource = ProductDataSet;
                ProductBindingSource.DataMember = "PRODUCTS";
                ProductDataGridView.RefreshEdit();
                ProductDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
            mdlGeneral.Connection.Close();
        }

        private void BindingNavigatorFindItem_Click(object sender, EventArgs e)
        {
            string strCode;
            strCode = Interaction.InputBox("Please Enter Product Code To Find.", "Find");
            if (Strings.Len(strCode) == 0)
                return;
            Pos = ProductBindingSource.Find("prod_cd", strCode.Trim());
            if (!(Pos == -1))
            {
                EditString = strCode;
                ProductBindingSource.Position = Pos;
            }
        }

        private void txtCode_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtCode);
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text) | string.IsNullOrEmpty(txtCatg.Text) | string.IsNullOrEmpty(txtDesc.Text) | string.IsNullOrEmpty(txtPPrice.Text) | string.IsNullOrEmpty(txtSalePrice.Text))
            {
                mdlGeneral.gblMessage = "All Fields are mandatory.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                return;
            }
            txtMargin.Text = (Conversion.Val(txtSalePrice.Text.Trim()) - Conversion.Val(txtPPrice.Text.Trim())).ToString();
            // // If changes made in selected record then execute update data into table
            if (EditMode == true & AddMode == false)
                BindingNavigatorQuery("UPDATE PRODUCTS SET " + "PROD_CD = '" + txtCode.Text.Trim() + "', " + "PROD_DESC = '" + txtDesc.Text.Trim() + "', " + "PROD_CATG = '" + txtCatg.Text.Trim() + "', " + "PROD_PPRICE = " + Conversion.Val(txtPPrice.Text.Trim()) + ", " + "PROD_PROFIT = " + Conversion.Val(txtMargin.Text.Trim()) + ", " + "PROD_SPRICE = " + Conversion.Val(txtSalePrice.Text.Trim()) + ", " + "PROD_UPD_ON = '" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString().Trim()), "MM/dd/yyyy") + "' " + "WHERE (PROD_CD = N'" + EditString.Trim() + "')");








            // // if entered new values in text boxes then execute add data into table
            if (AddMode == true & EditMode == false)
            {
                if (Strings.Len(txtCode.Text.Trim()) > 0 & Strings.Len(txtDesc.Text.Trim()) > 0 & Strings.Len(txtPck.Text.Trim()) > 0 & Strings.Len(txtCatg.Text.Trim()) > 0 & Strings.Len(txtPPrice.Text.Trim()) > 0 & Strings.Len(txtMargin.Text.Trim()) > 0 & Strings.Len(txtSalePrice.Text.Trim()) > 0)





                {

                    BindingNavigatorQuery("INSERT INTO PRODUCTS VALUES ('" + txtCode.Text.Trim() + "','" + txtDesc.Text.Trim() + "','" + txtCatg.Text.Trim() + "','" + txtPck.Text.Trim() + "'," + Conversion.Val(txtPPrice.Text.Trim()) + "," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + Conversion.Val(txtMargin.Text.Trim()) + "," + "0," + Conversion.Val(txtSalePrice.Text.Trim()) + ",'" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString()), "MM/dd/yyyy") + "','" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString()), "MM/dd/yyyy") + "')");




















                }
                else
                {
                    mdlGeneral.gblMessage = "Please fill all fields for insert new product.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                }
            }
            Enable_Disable_Controls("True");
            RefreshDB();
            SplitContainer1.Panel1.Enabled = false;
            if (EditMode == true)
            {
                ProductBindingSource.ResetBindings(true);
                Pos = ProductBindingSource.Find("PROD_CD", EditString.Trim());
                if (!(Pos == -1))
                {
                    ProductBindingSource.Position = Pos;
                }
            }
            EditMode = false;
            AddMode = false;
            BindingNavigatorEditItem.Enabled = true;
            BindingNavigatorEditItem.Text = "&Edit Product";
        }

        private void BindingNavigatorQuery(string Query)
        {
            try
            {
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Query, mdlGeneral.Connection);
                mdlGeneral.Connection.Close();
                mdlGeneral.SqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
            }
        }

        private void txtPPrice_GotFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_GotFocus(txtPPrice);
        }

        private void txtPPrice_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtPPrice);
        }

        private void txtSalePrice_LostFocus(object sender, EventArgs e)
        {
            mdlGeneral.Get_Property_LostFocus(txtSalePrice);
        }

    }
}