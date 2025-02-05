using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Server : Form
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
            GroupBox1 = new GroupBox();
            txtSrvrPwd = new TextBox();
            txtSrvrPwd.KeyDown += new KeyEventHandler(txtSrvrPwd_KeyDown);
            Label3 = new Label();
            txtSrvrUser = new TextBox();
            Label2 = new Label();
            txtSrvrName = new TextBox();
            Label1 = new Label();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(txtSrvrPwd);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(txtSrvrUser);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(txtSrvrName);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Location = new Point(2, -1);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(346, 128);
            GroupBox1.TabIndex = 2;
            GroupBox1.TabStop = false;
            // 
            // txtSrvrPwd
            // 
            txtSrvrPwd.BorderStyle = BorderStyle.FixedSingle;
            txtSrvrPwd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSrvrPwd.Location = new Point(147, 87);
            txtSrvrPwd.Name = "txtSrvrPwd";
            txtSrvrPwd.Size = new Size(185, 22);
            txtSrvrPwd.TabIndex = 2;
            txtSrvrPwd.UseSystemPasswordChar = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(15, 89);
            Label3.Name = "Label3";
            Label3.Size = new Size(126, 16);
            Label3.TabIndex = 10;
            Label3.Text = "Server Password";
            // 
            // txtSrvrUser
            // 
            txtSrvrUser.BorderStyle = BorderStyle.FixedSingle;
            txtSrvrUser.Enabled = false;
            txtSrvrUser.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSrvrUser.Location = new Point(147, 53);
            txtSrvrUser.Name = "txtSrvrUser";
            txtSrvrUser.Size = new Size(185, 22);
            txtSrvrUser.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(15, 55);
            Label2.Name = "Label2";
            Label2.Size = new Size(91, 16);
            Label2.TabIndex = 8;
            Label2.Text = "Server User";
            // 
            // txtSrvrName
            // 
            txtSrvrName.BorderStyle = BorderStyle.FixedSingle;
            txtSrvrName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSrvrName.Location = new Point(147, 19);
            txtSrvrName.Name = "txtSrvrName";
            txtSrvrName.Size = new Size(185, 22);
            txtSrvrName.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(15, 21);
            Label1.Name = "Label1";
            Label1.Size = new Size(99, 16);
            Label1.TabIndex = 6;
            Label1.Text = "Server Name";
            // 
            // frmServer
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 130);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmServer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server Settings";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(frmServer_Load);
            ResumeLayout(false);

        }
        internal GroupBox GroupBox1;
        internal TextBox txtSrvrPwd;
        internal Label Label3;
        internal TextBox txtSrvrUser;
        internal Label Label2;
        internal TextBox txtSrvrName;
        internal Label Label1;
    }
}