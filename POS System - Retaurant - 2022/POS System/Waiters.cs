using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class Waiters
    {
        private bool drag;
        private int mousex;
        private int mousey;
        private string EditString;
        private int Max_ID = 0;
        private DataGridViewCellStyle objCellStyle = new DataGridViewCellStyle();
        private bool Addition, Editing, RollBack;

        public Waiters()
        {
            InitializeComponent();
        }

        private void frmCompanies_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            mdlGeneral.GetConnectionString();
            LoadDB();
        }

        private void BindingNavigatorQuery(string Query)
        {
            // Try
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Query, mdlGeneral.Connection);
            mdlGeneral.Connection.Close();
            mdlGeneral.SqlDataAdapter.Dispose();
            // Catch ex As Exception
            // MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            // End Try
        }

        private void LoadDB()
        {

            try
            {
                CompanyDataSet.Clear();
                string CommandText = "SELECT * FROM WAITERS ORDER BY WAITER_ID";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "WAITERS", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(CompanyDataSet, "WAITERS");
                CompanyBindingSource.DataSource = CompanyDataSet;
                CompanyBindingSource.DataMember = "WAITERS";
                txtID.DataBindings.Add("TEXT", CompanyBindingSource, "WAITER_ID");
                txtName.DataBindings.Add("TEXT", CompanyBindingSource, "WAITER_NAME");
                txtAddress.DataBindings.Add("TEXT", CompanyBindingSource, "WAITER_ADDRESS");
                txtPhone.DataBindings.Add("TEXT", CompanyBindingSource, "WAITER_CONTACT");
                txtCNIC.DataBindings.Add("TEXT", CompanyBindingSource, "WAITER_NIC");
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
                //My.MyProject.Forms.Wholesalers.WindowState = FormWindowState.Normal;
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
                Max_ID = mdlGeneral.GenerateMax_ID("WAITERS", "WAITER_ID");
                if (Max_ID == 1)
                    Max_ID = Max_ID + 100;
                txtID.Text = Max_ID.ToString();
            }
            // // If changes made in selected record then execute update record query
            if (Editing == true & Addition == false)
                BindingNavigatorQuery("UPDATE WAITERS SET" + " WAITER_NAME = '" + txtName.Text.Trim().ToUpper() + "'," + " WAITER_ADDRESS = '" + txtAddress.Text.Trim().ToUpper() + "'," + " WAITER_CONTACT = '" + txtPhone.Text.Trim() + "'," + " WAITER_NIC = '" + txtCNIC.Text.Trim() + "' " + " WHERE WAITER_ID = " + Conversion.Val(EditString));





            // // if entered new values in text boxes then execute add record query
            if (Addition == true & Editing == false)
                BindingNavigatorQuery("INSERT INTO WAITERS VALUES(" + Conversion.Val(txtID.Text.Trim()) + ",'" + txtName.Text.Trim().ToUpper() + "','" + txtAddress.Text.Trim().ToUpper() + "','" + txtPhone.Text.Trim() + "','" + txtCNIC.Text.Trim() + "')");




            RefreshDB();
            ToolStripSaveButton.Enabled = false;
            Panel1.Enabled = false;
            Editing = false;
            Addition = false;
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
                string CommandText = "DELETE FROM WAITERS WHERE WAITER_ID = " + Conversion.Val(txtID.Text.Trim());
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
                string QueryText = "SELECT * FROM WAITERS ORDER BY WAITER_ID";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, QueryText, "WAITERS", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(CompanyDataSet, "WAITERS");
                CompanyBindingSource.DataSource = CompanyDataSet;
                CompanyBindingSource.DataMember = "WAITERS";
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