using System.Windows.Forms;

namespace POS_System
{
    // Copyright (c) Microsoft Corporation. All rights reserved.
    public partial class Status
    {

        public void Show(string Message)
        {
            Label1.Text = Message;
            Show();
            Application.DoEvents();
        }

    }
}