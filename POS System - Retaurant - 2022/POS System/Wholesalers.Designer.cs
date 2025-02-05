using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Wholesalers : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Wholesalers));
            LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            LineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            cmdMin = new Button();
            cmdMin.Click += new EventHandler(cmdMin_Click);
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            Label1 = new Label();
            cmdReports = new Button();
            cmdReports.Click += new EventHandler(cmdReports_Click);
            cmdPayments = new Button();
            cmdPayments.Click += new EventHandler(cmdPayments_Click);
            cmdCompany = new Button();
            cmdCompany.Click += new EventHandler(cmdCompany_Click);
            cmdTransactions = new Button();
            cmdTransactions.Click += new EventHandler(cmdTransactions_Click);
            SuspendLayout();
            // 
            // LineShape1
            // 
            LineShape1.BorderColor = Color.Gray;
            LineShape1.Name = "LineShape1";
            LineShape1.X1 = 6;
            LineShape1.X2 = 567;
            LineShape1.Y1 = 44;
            LineShape1.Y2 = 44;
            // 
            // LineShape2
            // 
            LineShape2.BorderColor = Color.Black;
            LineShape2.Name = "LineShape2";
            LineShape2.X1 = 6;
            LineShape2.X2 = 567;
            LineShape2.Y1 = 43;
            LineShape2.Y2 = 43;
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { LineShape2, LineShape1 });
            ShapeContainer1.Size = new Size(584, 194);
            ShapeContainer1.TabIndex = 0;
            ShapeContainer1.TabStop = false;
            // 
            // cmdMin
            // 
            cmdMin.BackColor = Color.FromArgb(64, 64, 64);
            cmdMin.BackgroundImageLayout = ImageLayout.Center;
            cmdMin.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            cmdMin.FlatAppearance.MouseOverBackColor = Color.Gray;
            cmdMin.FlatStyle = FlatStyle.Flat;
            cmdMin.Font = new Font("Arial", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdMin.ForeColor = Color.FromArgb(224, 224, 224);
            cmdMin.Location = new Point(327, 4);
            cmdMin.Name = "cmdMin";
            cmdMin.Size = new Size(29, 34);
            cmdMin.TabIndex = 6;
            cmdMin.TabStop = false;
            cmdMin.Text = "----";
            cmdMin.UseVisualStyleBackColor = false;
            // 
            // cmdClose
            // 
            cmdClose.BackColor = Color.FromArgb(64, 64, 64);
            cmdClose.BackgroundImageLayout = ImageLayout.Center;
            cmdClose.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            cmdClose.FlatAppearance.MouseOverBackColor = Color.Gray;
            cmdClose.FlatStyle = FlatStyle.Flat;
            cmdClose.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdClose.ForeColor = Color.FromArgb(224, 224, 224);
            cmdClose.Location = new Point(358, 4);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(29, 34);
            cmdClose.TabIndex = 5;
            cmdClose.TabStop = false;
            cmdClose.Text = "X";
            cmdClose.TextAlign = ContentAlignment.MiddleLeft;
            cmdClose.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Red;
            Label1.ImageAlign = ContentAlignment.MiddleLeft;
            Label1.Location = new Point(-1, 7);
            Label1.Name = "Label1";
            Label1.Size = new Size(158, 31);
            Label1.TabIndex = 4;
            Label1.Text = "Wholsalers";
            // 
            // cmdReports
            // 
            cmdReports.BackColor = Color.FromArgb(64, 64, 64);
            cmdReports.Cursor = Cursors.Hand;
            cmdReports.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdReports.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdReports.FlatStyle = FlatStyle.Flat;
            cmdReports.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdReports.ForeColor = Color.Yellow;
            cmdReports.Image = My.Resources.Resources._1487123143_ordering1;
            cmdReports.Location = new Point(443, 55);
            cmdReports.Name = "cmdReports";
            cmdReports.Size = new Size(111, 110);
            cmdReports.TabIndex = 7;
            cmdReports.Text = "Re&ports";
            cmdReports.TextAlign = ContentAlignment.BottomCenter;
            cmdReports.UseVisualStyleBackColor = false;
            // 
            // cmdPayments
            // 
            cmdPayments.BackColor = Color.FromArgb(64, 64, 64);
            cmdPayments.Cursor = Cursors.Hand;
            cmdPayments.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdPayments.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdPayments.FlatStyle = FlatStyle.Flat;
            cmdPayments.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdPayments.ForeColor = Color.Yellow;
            cmdPayments.Image = (Image)resources.GetObject("cmdPayments.Image");
            cmdPayments.Location = new Point(161, 55);
            cmdPayments.Name = "cmdPayments";
            cmdPayments.Size = new Size(111, 110);
            cmdPayments.TabIndex = 1;
            cmdPayments.Text = "&Payments";
            cmdPayments.TextAlign = ContentAlignment.BottomCenter;
            cmdPayments.UseVisualStyleBackColor = false;
            // 
            // cmdCompany
            // 
            cmdCompany.BackColor = Color.FromArgb(64, 64, 64);
            cmdCompany.Cursor = Cursors.Hand;
            cmdCompany.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdCompany.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdCompany.FlatStyle = FlatStyle.Flat;
            cmdCompany.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCompany.ForeColor = Color.Yellow;
            cmdCompany.Image = My.Resources.Resources.Business_Man_Blue_64;
            cmdCompany.Location = new Point(19, 55);
            cmdCompany.Name = "cmdCompany";
            cmdCompany.Size = new Size(111, 110);
            cmdCompany.TabIndex = 0;
            cmdCompany.Text = "&Add Suppliers";
            cmdCompany.TextAlign = ContentAlignment.BottomCenter;
            cmdCompany.UseVisualStyleBackColor = false;
            // 
            // cmdTransactions
            // 
            cmdTransactions.BackColor = Color.FromArgb(64, 64, 64);
            cmdTransactions.Cursor = Cursors.Hand;
            cmdTransactions.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdTransactions.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdTransactions.FlatStyle = FlatStyle.Flat;
            cmdTransactions.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdTransactions.ForeColor = Color.Yellow;
            cmdTransactions.Image = My.Resources.Resources._1487123129_Sales_by_Payment_Method_rep;
            cmdTransactions.Location = new Point(301, 55);
            cmdTransactions.Name = "cmdTransactions";
            cmdTransactions.Size = new Size(111, 110);
            cmdTransactions.TabIndex = 2;
            cmdTransactions.Text = "&Transactions";
            cmdTransactions.TextAlign = ContentAlignment.BottomCenter;
            cmdTransactions.UseVisualStyleBackColor = false;
            // 
            // frmWholesalers
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(584, 194);
            Controls.Add(cmdReports);
            Controls.Add(cmdPayments);
            Controls.Add(cmdCompany);
            Controls.Add(cmdTransactions);
            Controls.Add(cmdMin);
            Controls.Add(cmdClose);
            Controls.Add(Label1);
            Controls.Add(ShapeContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmWholesalers";
            Text = "Wholesalers Menu";
            Load += new EventHandler(frmWholesalers_Load);
            MouseDown += new MouseEventHandler(frmWholesaler_MouseDown);
            MouseMove += new MouseEventHandler(frmWholesaler_MouseMove);
            MouseUp += new MouseEventHandler(frmWholesaler_MouseUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape2;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Button cmdMin;
        internal Button cmdClose;
        internal Label Label1;
        internal Button cmdPayments;
        internal Button cmdCompany;
        internal Button cmdTransactions;
        internal Button cmdReports;
    }
}