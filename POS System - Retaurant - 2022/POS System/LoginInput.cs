using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class LoginInput
    {

        private string currentpath = Directory.GetCurrentDirectory();

        public LoginInput()
        {
            InitializeComponent();
        }


        private void cmdLogin_Click(object sender, EventArgs e)
        {

            mdlGeneral.UserName = txtUserName.Text.Trim();
            mdlGeneral.UserPassword = txtPassword.Text.Trim();
            mdlGeneral.GetConnectionString();
            // for developer only
            if (mdlGeneral.UserName == "admin" & mdlGeneral.UserPassword == "isha1234")
            {
                mdlGeneral.SysOperator = "Admin";
                mdlGeneral.UserStatus = "Administrator";
                mdlGeneral.gblPrliviges = Conversions.ToInteger("1");
                mdlGeneral.UserID = "01";
                mdlGeneral.LoginStatus = true;
                goto Login_Success;
            }

            string LoginQuery = "SELECT * FROM USERS WHERE USERNAME = N'" + mdlGeneral.UserName + "' AND PASSWORD = N'" + mdlGeneral.UserPassword + "'";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, LoginQuery, mdlGeneral.Connection);
            var UsersLogin = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (UsersLogin.HasRows == true)
            {
                while (UsersLogin.Read())
                {
                    mdlGeneral.gblPrliviges = Conversions.ToInteger(UsersLogin["SecurityLevel"]);
                    mdlGeneral.UserStatus = Conversions.ToString(UsersLogin["UserRole"]);
                    mdlGeneral.SysOperator = Strings.StrConv(Conversions.ToString(UsersLogin["Name"]), VbStrConv.ProperCase);
                    mdlGeneral.UserID = Conversions.ToString(UsersLogin["UserID"]);
                    mdlGeneral.LoginStatus = true;
                    goto Login_Success;
                }
            }
            else
            {
                Interaction.MsgBox("Access Denied" + Constants.vbCrLf + "Invalid Passward.", MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                txtPassword.Clear();
                mdlGeneral.Connection.Close();
                txtUserName.Focus();
            }

        Login_Success:
            ;


            if (mdlGeneral.LoginStatus == true)
            {
                My.MyProject.Forms.Main.Show();
                mdlGeneral.Connection.Close();
                Close();
                return;
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    Interaction.MsgBox("UserName is blank.", MsgBoxStyle.Information);
                    return;
                }
                cmdLogin_Click(sender, e);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            mdlGeneral.LoginStatus = false;
            Close();
        }

        private void frmLoginInput_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            Copyright.Text = My.MyProject.Application.Info.Copyright;
            txtUserName.Focus();
        }

    }
}