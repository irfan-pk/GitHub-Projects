using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class Product
    {
        private int Pos;
        private string EditString;
        private DataGridViewCellStyle objCellStyle = new DataGridViewCellStyle();
        private bool Addition, Editing, RollBack;

        public Product()
        {
            InitializeComponent();
        }

        private void frmSysUser_KeyUp(object sender, KeyEventArgs e)
        {
            // If user pressed the Enter key
            if (e.KeyCode == Keys.Enter & !(e.Alt | e.Control))
            {
                e.SuppressKeyPress = true;
                // Make sure that the active control is a TextBox control
                // Do not use the Enter key as tab when a button has the focus!
                if (ReferenceEquals(ActiveControl.GetType(), typeof(TextBox)) | ReferenceEquals(ActiveControl.GetType(), typeof(ComboBox)) | ReferenceEquals(ActiveControl.GetType(), typeof(DateTimePicker)))

                {
                    // Use Shift + Enter to move backwords through the tab order
                    if (e.Shift)
                    {
                        ProcessTabKey(false);
                    }
                    else
                    {
                        ProcessTabKey(true);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (mdlGeneral.gblPrliviges > 2)
            {
                Interaction.MsgBox("You are not authorized, illegal operating.", MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
                return;
            }
            mdlGeneral.GetConnectionString();
            LoadDB();

        }

        private void LoadDB()
        {
            try
            {
                string CommandText = "SELECT * FROM PRODUCTS ORDER BY PROD_CD";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "PRODUCTS", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(UserDataSet, "PRODUCTS");
                UserbindingSource.DataSource = UserDataSet;
                UserbindingSource.DataMember = "PRODUCTS";
                txtCode.DataBindings.Add("TEXT", UserbindingSource, "PROD_CD");
                txtDesc.DataBindings.Add("TEXT", UserbindingSource, "PROD_DESC");
                txtCatg.DataBindings.Add("TEXT", UserbindingSource, "PROD_CATG");
                txtPPrice.DataBindings.Add("TEXT", UserbindingSource, "PROD_PPRICE");
                txtMargin.DataBindings.Add("TEXT", UserbindingSource, "PROD_PROFIT");
                txtPck.DataBindings.Add("TEXT", UserbindingSource, "PROD_PACK");
                txtSalePrice.DataBindings.Add("TEXT", UserbindingSource, "PROD_SPRICE");
                Addition = false;
                Editing = false;
                ToolStripSaveButton.Enabled = false;
                // Me.Panel1.Enabled = False
                objCellStyle.BackColor = Color.WhiteSmoke;
                UsersDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
        }

        private void ActivateTextBoxes(string Status)
        {
            txtCode.ReadOnly = Conversions.ToBoolean(Status);
            txtDesc.ReadOnly = Conversions.ToBoolean(Status);
            txtPPrice.ReadOnly = Conversions.ToBoolean(Status);
            txtMargin.ReadOnly = Conversions.ToBoolean(Status);
            txtSalePrice.ReadOnly = Conversions.ToBoolean(Status);
            txtMargin.ReadOnly = Conversions.ToBoolean(Status);
        }


        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ActivateTextBoxes("False");
            Addition = true;
            RollBack = true;
            Editing = false;
            ToolStripSaveButton.Enabled = true;
            ToolStripCloseButton.Text = "&Cancel";
            txtCode.Focus();
        }

        private void ToolStripEditButton_Click(object sender, EventArgs e)
        {
            txtCode.Text = txtCode.Text.Trim();
            EditString = txtCode.Text.Trim().ToUpper();
            Editing = true;
            Addition = false;
            ActivateTextBoxes("False");
            ToolStripSaveButton.Enabled = true;
            ToolStripCloseButton.Text = "&Cancel";
            EditString = txtCode.Text.Trim();
            txtCode.Focus();

        }

        private void ToolStripCloseButton_Click(object sender, EventArgs e)
        {
            if (ToolStripCloseButton.Text == "&Close")
            {
                // myConn.Close()
                UserbindingSource.Dispose();
                Close();
            }
            else
            {
                ToolStripCloseButton.Text = "&Close";
                ToolStripSaveButton.Enabled = false;
                ActivateTextBoxes("True");
                RefreshDB();
                Addition = false;
                Editing = false;
            }
        }

        private void RefreshDB()
        {
            try
            {
                UserDataSet.Clear();
                string CommandText = "SELECT * FROM PRODUCTS ORDER BY PROD_CD";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "PRODUCTS", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(UserDataSet, "PRODUCTS");
                UserbindingSource.DataSource = UserDataSet;
                UserbindingSource.DataMember = "PRODUCTS";
                UsersDataGridView.RefreshEdit();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            string DeleteQuery = string.Empty;
            if (ToolStripCloseButton.Text == "&Cancel")
                ToolStripCloseButton.Text = "&Close";
            if (Interaction.MsgBox("Are you sure to delete ('" + txtDesc.Text.Trim().ToUpper() + "') ?", (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.OkCancel), My.MyProject.Application.Info.ProductName) == MsgBoxResult.Ok)
            {
                DeleteQuery = "DELETE FROM PRODUCTS WHERE PROD_CD = '" + txtCode.Text.Trim() + "'";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, DeleteQuery, "PRODUCTS", mdlGeneral.Connection);
            }
            else
            {
                UsersDataGridView.RefreshEdit();
                UserBindingNavigator.Refresh();
                ToolStripCloseButton_Click(sender, e);
                return;
            }
        }

        private void ToolStripSaveButton_Click(object sender, EventArgs e)
        {
            string MaxID = mdlGeneral.GenerateMax_ID("USERS", "USERID").ToString();
            string Add_Edit_Query = string.Empty;
            if (string.IsNullOrEmpty(txtCode.Text) | string.IsNullOrEmpty(txtCatg.Text) | string.IsNullOrEmpty(txtDesc.Text) | string.IsNullOrEmpty(txtPPrice.Text) | string.IsNullOrEmpty(txtSalePrice.Text))
            {
                mdlGeneral.gblMessage = "All Fields are mandatory.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                return;
            }
            // // If changes made in selected record then execute update data into table
            if (Editing == true & Addition == false)
            {
                Add_Edit_Query = "UPDATE PRODUCTS SET " + "PROD_CD = '" + txtCode.Text.Trim() + "', " + "PROD_DESC = '" + txtDesc.Text.Trim() + "', " + "PROD_CATG = '" + txtCatg.Text.Trim() + "', " + "PROD_PPRICE = " + Conversion.Val(txtPPrice.Text.Trim()) + ", " + "PROD_PROFIT = " + Conversion.Val(txtMargin.Text.Trim()) + ", " + "PROD_SPRICE = " + Conversion.Val(txtSalePrice.Text.Trim()) + ", " + "PROD_UPD_ON = '" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString().Trim()), "MM/dd/yyyy") + "' " + "WHERE (PROD_CD = N'" + EditString.Trim() + "')";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Add_Edit_Query, mdlGeneral.Connection);
            }
            // // if entered new values in text boxes then execute add data into table
            if (Addition == true & Editing == false)
            {

                if (Strings.Len(txtCode.Text.Trim()) > 0 & Strings.Len(txtDesc.Text.Trim()) > 0 & Strings.Len(txtPck.Text.Trim()) > 0 & Strings.Len(txtCatg.Text.Trim()) > 0 & Strings.Len(txtPPrice.Text.Trim()) > 0 & Strings.Len(txtSalePrice.Text.Trim()) > 0)
                {
                    Add_Edit_Query = "INSERT INTO PRODUCTS VALUES ('" + txtCode.Text.Trim() + "','" + txtDesc.Text.Trim() + "','" + txtCatg.Text.Trim() + "','" + txtPck.Text.Trim() + "'," + Conversion.Val(txtPPrice.Text.Trim()) + "," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + "0," + Conversion.Val(txtMargin.Text.Trim()) + "," + "0," + Conversion.Val(txtSalePrice.Text.Trim()) + ",'" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString()), "MM/dd/yyyy") + "','" + Strings.Format(DateTime.Parse(DateTime.Now.Date.ToString()), "MM/dd/yyyy") + "')";
                    mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Add_Edit_Query, mdlGeneral.Connection);
                }
                else
                {
                    mdlGeneral.gblMessage = "Please fill all fields for insert new product.";
                    My.MyProject.Forms.MsgStatus.ShowDialog(this);
                }
            }
            RefreshDB();
            ToolStripSaveButton.Enabled = false;
            ActivateTextBoxes("True");
            ToolStripCloseButton.Text = "&Close";
            mdlGeneral.Connection.Close();
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

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateAlphaNumOnly(sender, e);
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

        private void txtMargin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress(sender, e, txtMargin, txtSalePrice);
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

        private void ValidateKeyPress(object sender, KeyPressEventArgs e, TextBox txt, TextBox nexttxt)
        {
            // 48 - 57  = Ascii codes for numbers
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\b')
                e.Handled = false; // allow Backspace
            if (Conversions.ToString(e.KeyChar) == "." & txt.Text.IndexOf(".") == -1)
                e.Handled = false; // allow single decimal point
        }

        private void ToolStripFindButton_Click(object sender, EventArgs e)
        {
            string strCode;
            strCode = Interaction.InputBox("Please Enter Product Code To Find.", "Find");
            if (Strings.Len(strCode) == 0)
                return;
            Pos = UserbindingSource.Find("prod_cd", strCode.Trim());
            if (!(Pos == -1))
            {
                EditString = strCode;
                UserbindingSource.Position = Pos;
            }
        }
    }
}