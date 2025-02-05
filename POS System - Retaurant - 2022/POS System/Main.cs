using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace POS_System
{

    public partial class Main
    {
        public Main()
        {
            InitializeComponent();
        }
        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ur-PK", true);
            FormBorderStyle = FormBorderStyle.None;
            Label1.Left = Width - (Label1.Width + 15);
            Label4.Left = Width - (Label4.Width + 15);
            LineShape1.X1 = Width - 232;
            LineShape2.X1 = Width - 232;
            LineShape1.X2 = Width - 10;
            LineShape2.X2 = Width - 10;
            cmdClose.Left = Width - (cmdClose.Width + 10);
            cmdMin.Left = Width - (cmdMin.Width + cmdClose.Width + 10);
            mdlGeneral.gblRelation = false;
        }

        private void cmdProduct_Click(object sender, EventArgs e)
        {
            ShowForm(My.MyProject.Forms.CustomerMenu);
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowForm(Form ChildForm)
        {
            ChildForm.MdiParent = this;
            ChildForm.Show();
        }

        private void cmdSale_Click(object sender, EventArgs e)
        {
            ShowForm(My.MyProject.Forms.Parcel);
        }

        private void cmdSystem_Click(object sender, EventArgs e)
        {
            ShowForm(My.MyProject.Forms.Maintenance);
        }

        private void cmdViewSale_Click(object sender, EventArgs e)
        {
            ShowForm(My.MyProject.Forms.TabViewSale);
        }

        private void cmdDining_Click(object sender, EventArgs e)
        {
            ShowForm(My.MyProject.Forms.DineTable);
        }

        private void cmdFoodItems_Click(object sender, EventArgs e)
        {
            ShowForm(My.MyProject.Forms.Product);
        }
    }
}