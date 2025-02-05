using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class SysUser
    {
        private int Pos;
        private string EditString;
        private DataGridViewCellStyle objCellStyle = new DataGridViewCellStyle();
        private bool Addition, Editing, RollBack;

        public SysUser()
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
                string CommandText = "SELECT * FROM USERS ORDER BY USERID";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "USERS", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(UserDataSet, "USERS");
                UserbindingSource.DataSource = UserDataSet;
                UserbindingSource.DataMember = "USERS";
                txtUserID.DataBindings.Add("TEXT", UserbindingSource, "USERID");
                txtUserName.DataBindings.Add("TEXT", UserbindingSource, "USERNAME");
                txtName.DataBindings.Add("TEXT", UserbindingSource, "NAME");
                cmbUserType.DataBindings.Add("TEXT", UserbindingSource, "USERROLE");
                txtLevel.DataBindings.Add("TEXT", UserbindingSource, "SECURITYLEVEL");
                txtPwd.DataBindings.Add("TEXT", UserbindingSource, "PASSWORD");
                txtCNIC.DataBindings.Add("TEXT", UserbindingSource, "CARDNUMBER");
                Addition = false;
                Editing = false;
                ToolStripSaveButton.Enabled = false;
                Panel1.Enabled = false;
                objCellStyle.BackColor = Color.WhiteSmoke;
                UsersDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Panel1.Enabled = true;
            Addition = true;
            RollBack = true;
            Editing = false;
            ToolStripSaveButton.Enabled = true;
            ToolStripCloseButton.Text = "&Cancel";
            txtUserName.Focus();
        }

        private void ToolStripEditButton_Click(object sender, EventArgs e)
        {

            EditString = txtUserID.Text.Trim().ToUpper();
            Editing = true;
            Addition = false;
            Panel1.Enabled = true;
            ToolStripSaveButton.Enabled = true;
            ToolStripCloseButton.Text = "&Cancel";
            EditString = txtUserID.Text.Trim();
            txtUserName.Focus();

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
                Panel1.Enabled = false;
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
                string CommandText = "SELECT * FROM USERS ORDER BY USERID";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "USERS", mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(UserDataSet, "USERS");
                UserbindingSource.DataSource = UserDataSet;
                UserbindingSource.DataMember = "USERS";
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
            if (Interaction.MsgBox("Are you sure to delete ('" + txtUserName.Text.Trim().ToUpper() + "') ?", (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.OkCancel), My.MyProject.Application.Info.ProductName) == MsgBoxResult.Ok)
            {
                DeleteQuery = "DELETE FROM USERS WHERE USERNAME = '" + txtUserName.Text.Trim() + "'";
                mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, DeleteQuery, "USERS", mdlGeneral.Connection);
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
            string Edit_Update_Query = string.Empty;
            if (Editing == true & Addition == false)
                Edit_Update_Query = "UPDATE USERS SET USERNAME = '" + txtUserName.Text.Trim().ToLower() + "', PASSWORD = '" + txtPwd.Text.Trim() + "', USERROLE = '" + Strings.StrConv(cmbUserType.Text.Trim(), VbStrConv.ProperCase) + "', SECURITYLEVEL = '" + txtLevel.Text.Trim() + "', NAME = '" + Strings.StrConv(txtName.Text.Trim(), VbStrConv.ProperCase) + "'  WHERE USERID = '" + Conversion.Val(EditString) + "'";
            if (Addition == true & Editing == false)
                Edit_Update_Query = "INSERT INTO USERS VALUES('" + MaxID + "','" + txtUserName.Text.Trim().ToLower() + "','" + txtPwd.Text.Trim() + "','" + Strings.StrConv(txtName.Text.Trim(), VbStrConv.ProperCase) + "','" + Strings.StrConv(cmbUserType.Text.Trim(), VbStrConv.ProperCase) + "','" + Conversion.Val(txtLevel.Text.Trim().ToUpper()) + "',0,'" + txtCNIC.Text.Trim() + "')";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Edit_Update_Query, mdlGeneral.Connection);
            RefreshDB();
            ToolStripSaveButton.Enabled = false;
            Panel1.Enabled = false;
            ToolStripCloseButton.Text = "&Close";
            mdlGeneral.Connection.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateAlphaKeyPress(sender, e, txtName);
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.Handled = false;
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                e.Handled = false;
        }

        private void cmbUserType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) | char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbUserType.Text == "Administrator")
            {
                txtLevel.Text = 1.ToString();
            }
            else if (cmbUserType.Text == "Super User")
            {
                txtLevel.Text = 2.ToString();
            }
            else if (cmbUserType.Text == "User")
            {
                txtLevel.Text = 3.ToString();
            }

        }

    }
}