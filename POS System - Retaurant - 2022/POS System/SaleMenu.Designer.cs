using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SaleMenu : Form
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
            Button1 = new Button();
            cmdCustomer = new Button();
            Button2 = new Button();
            Button3 = new Button();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(64, 64, 64);
            Button1.Cursor = Cursors.Hand;
            Button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Button1.FlatAppearance.MouseOverBackColor = Color.Teal;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.Yellow;
            Button1.Image = My.Resources.Resources.Money_641;
            Button1.Location = new Point(9, 126);
            Button1.Name = "Button1";
            Button1.Size = new Size(111, 110);
            Button1.TabIndex = 17;
            Button1.Text = "&View Sale";
            Button1.TextAlign = ContentAlignment.BottomCenter;
            Button1.UseVisualStyleBackColor = false;
            // 
            // cmdCustomer
            // 
            cmdCustomer.BackColor = Color.FromArgb(64, 64, 64);
            cmdCustomer.Cursor = Cursors.Hand;
            cmdCustomer.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdCustomer.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdCustomer.FlatStyle = FlatStyle.Flat;
            cmdCustomer.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCustomer.ForeColor = Color.Yellow;
            cmdCustomer.Image = My.Resources.Resources._1487123143_ordering;
            cmdCustomer.Location = new Point(9, 12);
            cmdCustomer.Name = "cmdCustomer";
            cmdCustomer.Size = new Size(111, 110);
            cmdCustomer.TabIndex = 16;
            cmdCustomer.Text = "Sa&le Return";
            cmdCustomer.TextAlign = ContentAlignment.BottomCenter;
            cmdCustomer.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(64, 64, 64);
            Button2.Cursor = Cursors.Hand;
            Button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Button2.FlatAppearance.MouseOverBackColor = Color.Teal;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button2.ForeColor = Color.Yellow;
            Button2.Image = My.Resources.Resources.Money_641;
            Button2.Location = new Point(9, 240);
            Button2.Name = "Button2";
            Button2.Size = new Size(111, 110);
            Button2.TabIndex = 18;
            Button2.Text = "&View Sale";
            Button2.TextAlign = ContentAlignment.BottomCenter;
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            Button3.BackColor = Color.FromArgb(64, 64, 64);
            Button3.Cursor = Cursors.Hand;
            Button3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Button3.FlatAppearance.MouseOverBackColor = Color.Teal;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button3.ForeColor = Color.Yellow;
            Button3.Image = My.Resources.Resources.Money_641;
            Button3.Location = new Point(9, 354);
            Button3.Name = "Button3";
            Button3.Size = new Size(111, 110);
            Button3.TabIndex = 19;
            Button3.Text = "&View Sale";
            Button3.TextAlign = ContentAlignment.BottomCenter;
            Button3.UseVisualStyleBackColor = false;
            // 
            // frmSaleMenu
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(140, 485);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(cmdCustomer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSaleMenu";
            StartPosition = FormStartPosition.Manual;
            Text = "Menu";
            Load += new EventHandler(frmSaleMenu_Load);
            ResumeLayout(false);

        }
        internal Button cmdCustomer;
        internal Button Button1;
        internal Button Button2;
        internal Button Button3;
    }
}