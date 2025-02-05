using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class Customers
    {
        private bool drag;
        private int mousex;
        private int mousey;
        private string EditString;
        private int Max_ID = 0;
        private DataGridViewCellStyle objCellStyle = new DataGridViewCellStyle();
        private bool Addition, Editing, RollBack;

        public Customers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            mdlGeneral.GetConnectionString();
            LoadDB();
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

        private void LoadDB()
        {

            try
            {
                CompanyDataSet.Clear();
                string CommandText = "SELECT * FROM CUSTOMERS ORDER BY CUST_CODE";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "CUSTOMERS", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(CompanyDataSet, "CUSTOMERS");
                CompanyBindingSource.DataSource = CompanyDataSet;
                CompanyBindingSource.DataMember = "CUSTOMERS";
                txtID.DataBindings.Add("TEXT", CompanyBindingSource, "CUST_CODE");
                txtName.DataBindings.Add("TEXT", CompanyBindingSource, "CUST_NAME");
                txtAddress.DataBindings.Add("TEXT", CompanyBindingSource, "CUST_ADDRESS");
                txtCity.DataBindings.Add("TEXT", CompanyBindingSource, "CUST_CITY");
                txtPhone.DataBindings.Add("TEXT", CompanyBindingSource, "CUST_TEL");
                txtMob.DataBindings.Add("TEXT", CompanyBindingSource, "CUST_MOB");
                txtBalance.DataBindings.Add("TEXT", CompanyBindingSource, "CUST_BALANCE");
                Addition = false;
                Editing = false;
                ToolStripSaveButton.Enabled = false;
                Panel1.Enabled = false;
                objCellStyle.BackColor = Color.WhiteSmoke;
                CompanyDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
            mdlGeneral.Connection.Close();

        }

        private void ToolStripCloseButton_Click(object sender, EventArgs e)
        {
            if (ToolStripCloseButton.Text == "&Close")
            {
                mdlGeneral.Connection.Close();
                CompanyBindingSource.Dispose();
                Close();
                My.MyProject.Forms.CustomerMenu.WindowState = FormWindowState.Normal;
            }
            else
            {
                ToolStripCloseButton.Text = "&Close";
                Addition = false;
                Editing = false;
                ToolStripSaveButton.Enabled = false;
                Panel1.Enabled = false;
                ToolStripEditButton.Enabled = true;
                BindingNavigatorAddNewItem.Enabled = true;
                BindingNavigatorDeleteItem.Enabled = true;
                RefreshDB();
            }
        }

        private void ToolStripSaveButton_Click(object sender, EventArgs e)
        {

            // EditString = string.empty
            if (Addition == true & Editing == false)
            {
                Max_ID = mdlGeneral.GenerateMax_ID("CUSTOMERS", "CUST_CODE");
                if (Max_ID == 1)
                    Max_ID = Max_ID + 100;
                txtID.Text = Max_ID.ToString();
            }
            // // If changes made in selected record then execute update record query
            if (Editing == true & Addition == false)
                BindingNavigatorQuery("UPDATE CUSTOMERS SET" + " CUST_NAME = '" + Strings.StrConv(txtName.Text.Trim(), VbStrConv.ProperCase) + "'," + " CUST_ADDRESS = '" + Strings.StrConv(txtAddress.Text.Trim(), VbStrConv.ProperCase) + "'," + " CUST_CITY = '" + Strings.StrConv(txtCity.Text.Trim(), VbStrConv.ProperCase) + "'," + " CUST_TEL = '" + txtPhone.Text.Trim() + "'," + " CUST_MOB = '" + txtMob.Text.Trim() + "' " + " WHERE CUST_CODE = " + Conversion.Val(EditString));






            // // if entered new values in text boxes then execute add record query
            if (Addition == true & Editing == false)
                BindingNavigatorQuery("INSERT INTO CUSTOMERS VALUES(" + Conversion.Val(txtID.Text.Trim()) + ",'" + Strings.StrConv(txtName.Text.Trim(), VbStrConv.ProperCase) + "','" + Strings.StrConv(txtAddress.Text.Trim(), VbStrConv.ProperCase) + "','" + Strings.StrConv(txtCity.Text.Trim(), VbStrConv.ProperCase) + "','" + txtPhone.Text.Trim() + "','" + txtMob.Text.Trim() + "'," + Conversion.Val(txtBalance.Text) + ",'" + Strings.Format(DateTime.Parse(DateTime.Now.ToString()), "MM/dd/yyyy") + "')");





            RefreshDB();
            ToolStripSaveButton.Enabled = false;
            Panel1.Enabled = false;
            Editing = false;
            Addition = false;
            txtBalance.ReadOnly = true;
            ToolStripEditButton.Enabled = true;
            ToolStripCloseButton.Text = "&Close";

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            Panel1.Enabled = true;
            txtName.Focus();
            Addition = true;
            RollBack = true;
            Editing = false;
            txtBalance.ReadOnly = false;
            txtBalance.Text = "0.00";
            EditString = string.Empty;
            ToolStripSaveButton.Enabled = true;
            ToolStripCloseButton.Text = "&Cancel";

        }

        private void ToolStripEditButton_Click(object sender, EventArgs e)
        {
            Editing = true;
            Addition = false;
            Panel1.Enabled = true;
            ToolStripSaveButton.Enabled = true;
            ToolStripCloseButton.Text = "&Cancel";
            EditString = txtID.Text.Trim();
            txtName.Focus();

        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (Interaction.MsgBox("Are you sure to delete ?" + Strings.Space(2) + "(" + Strings.Trim(txtName.Text.ToUpper()) + ")", (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.OkCancel), "Delete Record") == MsgBoxResult.Ok)
            {
                string CommandText = "DELETE FROM CUSTOMERS WHERE CUST_CODE = " + Conversion.Val(txtID.Text.Trim());
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CommandText, mdlGeneral.Connection);
                CompanyDataGridView.Update();
            }
            else
            {
                // skip
                RefreshDB();
            }

        }
        private void RefreshDB()
        {

            try
            {
                CompanyDataSet.Clear();
                mdlGeneral.SqlDataAdapter.Dispose();
                string QueryText = "SELECT * FROM CUSTOMERS ORDER BY CUST_CODE";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, QueryText, "CUSTOMERS", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(CompanyDataSet, "CUSTOMERS");
                CompanyBindingSource.DataSource = CompanyDataSet;
                CompanyBindingSource.DataMember = "CUSTOMERS";
                CompanyDataGridView.Update();
                CompanyDataGridView.RefreshEdit();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
            mdlGeneral.Connection.Close();

        }

        private void ToolStripCloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void ToolStripCloseButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void ToolStripCloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}