using System;
using System.Windows.Forms;

namespace POS_System
{
    public partial class SaleMenu
    {
        public SaleMenu()
        {
            InitializeComponent();
        }
        private void frmSaleMenu_Load(object sender, EventArgs e)
        {
            Left = 10;
            Top = 10;
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}