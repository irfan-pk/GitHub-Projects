using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Maintenance : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            cmdBackup = new Button();
            cmdBackup.Click += new EventHandler(cmdBackup_Click);
            cmdWaiters = new Button();
            cmdWaiters.Click += new EventHandler(cmdUserRole_Click);
            cmdUsers = new Button();
            cmdUsers.Click += new EventHandler(cmdUsers_Click);
            SuspendLayout();
            // 
            // cmdBackup
            // 
            cmdBackup.BackColor = Color.FromArgb(64, 64, 64);
            cmdBackup.Cursor = Cursors.Hand;
            cmdBackup.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdBackup.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdBackup.FlatStyle = FlatStyle.Flat;
            cmdBackup.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdBackup.ForeColor = Color.Yellow;
            cmdBackup.Image = My.Resources.Resources.Misc_New_Database_icon;
            cmdBackup.Location = new Point(298, 14);
            cmdBackup.Name = "cmdBackup";
            cmdBackup.Size = new Size(111, 110);
            cmdBackup.TabIndex = 3;
            cmdBackup.Text = "&Backup";
            cmdBackup.TextAlign = ContentAlignment.BottomCenter;
            cmdBackup.UseVisualStyleBackColor = false;
            // 
            // cmdWaiters
            // 
            cmdWaiters.BackColor = Color.FromArgb(64, 64, 64);
            cmdWaiters.Cursor = Cursors.Hand;
            cmdWaiters.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdWaiters.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdWaiters.FlatStyle = FlatStyle.Flat;
            cmdWaiters.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdWaiters.ForeColor = Color.Yellow;
            cmdWaiters.Image = My.Resources.Resources.User_Files_icon;
            cmdWaiters.Location = new Point(158, 14);
            cmdWaiters.Name = "cmdWaiters";
            cmdWaiters.Size = new Size(111, 110);
            cmdWaiters.TabIndex = 2;
            cmdWaiters.Text = "&Waiters";
            cmdWaiters.TextAlign = ContentAlignment.BottomCenter;
            cmdWaiters.UseVisualStyleBackColor = false;
            // 
            // cmdUsers
            // 
            cmdUsers.BackColor = Color.FromArgb(64, 64, 64);
            cmdUsers.Cursor = Cursors.Hand;
            cmdUsers.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdUsers.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdUsers.FlatStyle = FlatStyle.Flat;
            cmdUsers.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdUsers.ForeColor = Color.Yellow;
            cmdUsers.Image = My.Resources.Resources.Admin_icon;
            cmdUsers.Location = new Point(16, 14);
            cmdUsers.Name = "cmdUsers";
            cmdUsers.Size = new Size(111, 110);
            cmdUsers.TabIndex = 1;
            cmdUsers.Text = "&Users";
            cmdUsers.TextAlign = ContentAlignment.BottomCenter;
            cmdUsers.UseVisualStyleBackColor = false;
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(427, 146);
            Controls.Add(cmdWaiters);
            Controls.Add(cmdBackup);
            Controls.Add(cmdUsers);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Maintenance";
            Text = "Maintenance";
            ResumeLayout(false);

        }
        internal Button cmdUsers;
        internal Button cmdWaiters;
        internal Button cmdBackup;
    }
}