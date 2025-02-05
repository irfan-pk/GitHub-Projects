using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class LoginInput : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInput));
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new POS_System.WaterMarkTextBox();
            this.txtUserName = new POS_System.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.ForeColor = System.Drawing.Color.White;
            this.cmdLogin.Location = new System.Drawing.Point(284, 127);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(72, 26);
            this.cmdLogin.TabIndex = 4;
            this.cmdLogin.Text = "&Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.White;
            this.cmdExit.Location = new System.Drawing.Point(362, 127);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(72, 26);
            this.cmdExit.TabIndex = 5;
            this.cmdExit.Text = "&Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Copyright
            // 
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Copyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.Location = new System.Drawing.Point(0, 177);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(478, 25);
            this.Copyright.TabIndex = 99;
            this.Copyright.Text = "Copyright";
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(140, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 20);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "User Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(151, 82);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Password";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::POS_System.My.Resources.Resources.Keys_64;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Location = new System.Drawing.Point(31, 27);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(104, 91);
            this.PictureBox1.TabIndex = 7;
            this.PictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(233, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(201, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtPassword.WaterMarkText = "Enter Password";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(233, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 24);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtUserName.WaterMarkText = "Enter Username";
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // LoginInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 202);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Button cmdLogin;
        internal Button cmdExit;
        internal Label Copyright;
        internal WaterMarkTextBox txtUserName;
        internal WaterMarkTextBox txtPassword;
        internal PictureBox PictureBox1;
        internal Label Label1;
        internal Label Label2;
    }
}