using System;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Maintenance
    {
        public Maintenance()
        {
            InitializeComponent();
        }
        private void cmdUsers_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.SysUser.MdiParent = (Form)My.MyProject.Forms.Main.Parent;
            My.MyProject.Forms.SysUser.ShowDialog(this);
        }

        private void cmdBackup_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.BackupData.MdiParent = (Form)My.MyProject.Forms.Main.Parent;
            My.MyProject.Forms.BackupData.ShowDialog(this);
        }

        private void cmdUserRole_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Waiters.MdiParent = (Form)My.MyProject.Forms.Main.Parent;
            My.MyProject.Forms.Waiters.ShowDialog(this);
        }
    }
}