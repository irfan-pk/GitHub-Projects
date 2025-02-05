using System;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Wholesalers
    {
        private bool drag;
        private int mousex;
        private int mousey;

        public Wholesalers()
        {
            InitializeComponent();
        }

        private void OpenForm(Form Myform)
        {
            WindowState = FormWindowState.Minimized;
            Myform.MdiParent = My.MyProject.Forms.Main;
            Myform.Show();
        }

        private void frmWholesalers_Load(object sender, EventArgs e)
        {
            // Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            LineShape1.X2 = Width - 10;
            LineShape2.X2 = Width - 10;
            cmdClose.Left = Width - (cmdClose.Width + 10);
            cmdMin.Left = Width - (cmdMin.Width + cmdClose.Width + 10);
            Left = 10;
            Top = 10;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmWholesaler_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void frmWholesaler_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void frmWholesaler_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void cmdCompany_Click(object sender, EventArgs e)
        {
            OpenForm(My.MyProject.Forms.Waiters);
        }

        //private void cmdPayments_Click(object sender, EventArgs e)
        //{
        //    OpenForm(My.MyProject.Forms.Journal);
        //}

        private void cmdTransactions_Click(object sender, EventArgs e)
        {
            OpenForm(My.MyProject.Forms.ViewCompanyLedgers);
        }

        private void cmdReports_Click(object sender, EventArgs e)
        {
            OpenForm(My.MyProject.Forms.WholesalerReports);
        }
    }
}