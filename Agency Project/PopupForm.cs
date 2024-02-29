using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    // This source code taken from Internet @(UI Academy)
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

     public enum enumAction
        {
            wait,
                start,
                close
        }

        public PopupForm.enumAction action;

        public int x, y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enumAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enumAction.wait:
                    timer1.Interval = 8000;
                    action = enumAction.close;
                    break;
                case PopupForm .enumAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = PopupForm.enumAction.wait;
                        }
                    }
                    break;
                case enumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showPopup(String PartyName)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                PopupForm frm = (PopupForm)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            // Code for Display Information
            SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("select * from accounts where account_name = '" + PartyName + "'", conn);
            conn.Open();
            SqlDataReader InfoReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (InfoReader.HasRows)
            {
                while (InfoReader.Read())
                {
                    lblPartyName.Text = InfoReader[1].ToString();
                    lblMobile.Text = InfoReader[21].ToString();
                    lblCNIC.Text = InfoReader[30].ToString();
                }
                InfoReader.Close();
            }
            conn.Close();
            SqlCommand SumCmd = new SqlCommand("select sum(subtotal) as NetTotal from saleorder where accountname = '" + PartyName +"'");
            

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            // Show the form and start timer
            GlobalVariableClass.showWindow(this, MainForm.ActiveForm);
            this.action = enumAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

    }
}
