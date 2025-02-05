using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomerMenu : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            this.cmdMin = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.LineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cmdReports = new System.Windows.Forms.Button();
            this.cmdPayments = new System.Windows.Forms.Button();
            this.cmdCustomer = new System.Windows.Forms.Button();
            this.cmdTransactions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdMin
            // 
            this.cmdMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cmdMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMin.Location = new System.Drawing.Point(510, 3);
            this.cmdMin.Name = "cmdMin";
            this.cmdMin.Size = new System.Drawing.Size(29, 34);
            this.cmdMin.TabIndex = 14;
            this.cmdMin.TabStop = false;
            this.cmdMin.Text = "----";
            this.cmdMin.UseVisualStyleBackColor = false;
            this.cmdMin.Click += new System.EventHandler(this.cmdMin_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClose.Location = new System.Drawing.Point(545, 4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(29, 34);
            this.cmdClose.TabIndex = 13;
            this.cmdClose.TabStop = false;
            this.cmdClose.Text = "X";
            this.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label1.Location = new System.Drawing.Point(-1, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(210, 31);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Customer Data";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LineShape1,
            this.LineShape2});
            this.ShapeContainer1.Size = new System.Drawing.Size(577, 194);
            this.ShapeContainer1.TabIndex = 18;
            this.ShapeContainer1.TabStop = false;
            // 
            // LineShape1
            // 
            this.LineShape1.BorderColor = System.Drawing.Color.Gray;
            this.LineShape1.Name = "LineShape1";
            this.LineShape1.X1 = 0;
            this.LineShape1.X2 = 570;
            this.LineShape1.Y1 = 44;
            this.LineShape1.Y2 = 44;
            // 
            // LineShape2
            // 
            this.LineShape2.BorderColor = System.Drawing.Color.Black;
            this.LineShape2.Name = "LineShape2";
            this.LineShape2.X1 = 0;
            this.LineShape2.X2 = 561;
            this.LineShape2.Y1 = 43;
            this.LineShape2.Y2 = 43;
            // 
            // cmdReports
            // 
            this.cmdReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.cmdReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReports.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReports.ForeColor = System.Drawing.Color.Yellow;
            this.cmdReports.Image = global::POS_System.My.Resources.Resources._1487123143_ordering1;
            this.cmdReports.Location = new System.Drawing.Point(439, 55);
            this.cmdReports.Name = "cmdReports";
            this.cmdReports.Size = new System.Drawing.Size(111, 110);
            this.cmdReports.TabIndex = 19;
            this.cmdReports.Text = "Re&ports";
            this.cmdReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdReports.UseVisualStyleBackColor = false;
            this.cmdReports.Click += new System.EventHandler(this.cmdReports_Click);
            // 
            // cmdPayments
            // 
            this.cmdPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.cmdPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPayments.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPayments.ForeColor = System.Drawing.Color.Yellow;
            this.cmdPayments.Image = ((System.Drawing.Image)(resources.GetObject("cmdPayments.Image")));
            this.cmdPayments.Location = new System.Drawing.Point(161, 55);
            this.cmdPayments.Name = "cmdPayments";
            this.cmdPayments.Size = new System.Drawing.Size(111, 110);
            this.cmdPayments.TabIndex = 1;
            this.cmdPayments.Text = "&Payments";
            this.cmdPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdPayments.UseVisualStyleBackColor = false;
            this.cmdPayments.Click += new System.EventHandler(this.cmdPayments_Click);
            // 
            // cmdCustomer
            // 
            this.cmdCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCustomer.ForeColor = System.Drawing.Color.Yellow;
            this.cmdCustomer.Image = global::POS_System.My.Resources.Resources._1487899031_Add_Male_User;
            this.cmdCustomer.Location = new System.Drawing.Point(19, 55);
            this.cmdCustomer.Name = "cmdCustomer";
            this.cmdCustomer.Size = new System.Drawing.Size(111, 110);
            this.cmdCustomer.TabIndex = 0;
            this.cmdCustomer.Text = "&Add Customer";
            this.cmdCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCustomer.UseVisualStyleBackColor = false;
            this.cmdCustomer.Click += new System.EventHandler(this.cmdCustomer_Click);
            // 
            // cmdTransactions
            // 
            this.cmdTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.cmdTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTransactions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTransactions.ForeColor = System.Drawing.Color.Yellow;
            this.cmdTransactions.Image = global::POS_System.My.Resources.Resources.basket_full_icon1;
            this.cmdTransactions.Location = new System.Drawing.Point(301, 55);
            this.cmdTransactions.Name = "cmdTransactions";
            this.cmdTransactions.Size = new System.Drawing.Size(111, 110);
            this.cmdTransactions.TabIndex = 2;
            this.cmdTransactions.Text = "P&urchases";
            this.cmdTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdTransactions.UseVisualStyleBackColor = false;
            this.cmdTransactions.Click += new System.EventHandler(this.cmdTransactions_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(577, 194);
            this.Controls.Add(this.cmdReports);
            this.Controls.Add(this.cmdPayments);
            this.Controls.Add(this.cmdCustomer);
            this.Controls.Add(this.cmdTransactions);
            this.Controls.Add(this.cmdMin);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ShapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CustomerMenu";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomermenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCustomerMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCustomerMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmCustomerMenu_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Button cmdPayments;
        internal Button cmdCustomer;
        internal Button cmdTransactions;
        internal Button cmdMin;
        internal Button cmdClose;
        internal Label Label1;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape2;
        internal Button cmdReports;
    }
}