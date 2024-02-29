using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WholeSaleApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            tbPassword.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            tbUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            tbUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            tbPassword.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            tbUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String Path = Directory.GetCurrentDirectory();
            if(File.Exists(Path + "\\DotNetLib.dll"))
            {
                // ReadSettingFile
                DatabaseParameters.ReadWriteDatabaseParameters("FR");
                GlobalVariableClass.gblConnectionString = @"Data Source = " + GlobalVariableClass.gblHostName + "; " +
                                                           "Initial Catalog = " + GlobalVariableClass.gblDatabaseName +"; " + 
                                                           "User ID = " + GlobalVariableClass.gblUserName + "; " + 
                                                           "Password = " + GlobalVariableClass.gblPassword + "; " + 
                                                           "Database = " + GlobalVariableClass.gblDatabaseName + ";";
            }
            else
            {
                // WriteSettingFile
                ParametersForm fileObj = new ParametersForm();
                fileObj.ShowDialog();
            }

            SqlConnection LoginConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand UserAuth = new SqlCommand();
            UserAuth.CommandType = CommandType.Text;
            UserAuth.CommandText = "select * from users";
            UserAuth.Connection = LoginConn;
            LoginConn.Open();
            SqlDataReader dr = UserAuth.ExecuteReader(CommandBehavior.CloseConnection);
            if(dr.Read())
                {
                if(tbUsername.Text.Equals(dr["userid"].ToString()) && tbPassword.Text.Equals(dr["password"].ToString()))
                {
                    GlobalVariableClass.gblOperatorId = dr.GetInt32(0);
                    GlobalVariableClass.gblOperator = dr.GetString(1);
                    this.Hide();
                    MainForm objForm = new MainForm();
                    objForm.Show();
                }
                else
                {
                    MessageBox.Show(this, "Invalid credentials / Database Error, Check parameters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoginConn.Close();
        }
    }
}
