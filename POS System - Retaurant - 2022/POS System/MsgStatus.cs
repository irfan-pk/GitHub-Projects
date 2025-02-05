using System;
using System.Windows.Forms;

namespace POS_System
{

    public partial class MsgStatus
    {

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void MsgStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            Label1.Text = mdlGeneral.gblMessage;
        }

    }
}