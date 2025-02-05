using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Stock : Form
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
            components = new System.ComponentModel.Container();
            cmdMin = new Button();
            cmdMin.Click += new EventHandler(cmdMin_Click);
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            Label1 = new Label();
            LineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ToolTip1 = new ToolTip(components);
            cmdViewPrch = new Button();
            cmdViewPrch.Click += new EventHandler(cmdViewPrch_Click);
            cmdProd = new Button();
            cmdProd.Click += new EventHandler(cmdProd_Click);
            cmdReturn = new Button();
            cmdReturn.Click += new EventHandler(cmdReturn_Click);
            cmdQty = new Button();
            cmdQty.Click += new EventHandler(cmdQty_Click);
            cmdPurchase = new Button();
            cmdPurchase.Click += new EventHandler(cmdPurchase_Click);
            SuspendLayout();
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
            cmdMin.Location = new Point(511, 4);
            cmdMin.Name = "cmdMin";
            cmdMin.Size = new Size(29, 34);
            cmdMin.TabIndex = 3;
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
            cmdClose.Location = new Point(542, 4);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(31, 34);
            cmdClose.TabIndex = 2;
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
            Label1.Location = new Point(4, 7);
            Label1.Name = "Label1";
            Label1.Size = new Size(167, 31);
            Label1.TabIndex = 0;
            Label1.Text = "Stock Menu";
            // 
            // LineShape2
            // 
            LineShape2.BorderColor = Color.Black;
            LineShape2.Name = "LineShape2";
            LineShape2.X1 = 9;
            LineShape2.X2 = 570;
            LineShape2.Y1 = 43;
            LineShape2.Y2 = 43;
            // 
            // LineShape1
            // 
            LineShape1.BorderColor = Color.Gray;
            LineShape1.Name = "LineShape1";
            LineShape1.X1 = 9;
            LineShape1.X2 = 570;
            LineShape1.Y1 = 44;
            LineShape1.Y2 = 44;
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { LineShape1, LineShape2 });
            ShapeContainer1.Size = new Size(583, 336);
            ShapeContainer1.TabIndex = 4;
            ShapeContainer1.TabStop = false;
            // 
            // ToolTip1
            // 
            ToolTip1.AutomaticDelay = 1000;
            ToolTip1.AutoPopDelay = 10000;
            ToolTip1.ForeColor = Color.FromArgb(192, 0, 0);
            ToolTip1.InitialDelay = 500;
            ToolTip1.IsBalloon = true;
            ToolTip1.ReshowDelay = 100;
            // 
            // cmdViewPrch
            // 
            cmdViewPrch.BackColor = Color.FromArgb(64, 64, 64);
            cmdViewPrch.Cursor = Cursors.Hand;
            cmdViewPrch.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdViewPrch.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdViewPrch.FlatStyle = FlatStyle.Flat;
            cmdViewPrch.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdViewPrch.ForeColor = Color.Yellow;
            cmdViewPrch.Image = My.Resources.Resources.Billboard_64;
            cmdViewPrch.ImageAlign = ContentAlignment.TopCenter;
            cmdViewPrch.Location = new Point(24, 195);
            cmdViewPrch.Name = "cmdViewPrch";
            cmdViewPrch.Size = new Size(111, 110);
            cmdViewPrch.TabIndex = 4;
            cmdViewPrch.Text = "&View Purchases";
            cmdViewPrch.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(cmdViewPrch, "View Purchases from Supplier");
            cmdViewPrch.UseVisualStyleBackColor = false;
            // 
            // cmdProd
            // 
            cmdProd.BackColor = Color.FromArgb(64, 64, 64);
            cmdProd.Cursor = Cursors.Hand;
            cmdProd.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdProd.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdProd.FlatStyle = FlatStyle.Flat;
            cmdProd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdProd.ForeColor = Color.Yellow;
            cmdProd.Image = My.Resources.Resources._1480381800_palet02;
            cmdProd.Location = new Point(166, 61);
            cmdProd.Name = "cmdProd";
            cmdProd.Size = new Size(111, 110);
            cmdProd.TabIndex = 1;
            cmdProd.Text = "&Pro&ducts";
            cmdProd.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(cmdProd, "Update Product Data");
            cmdProd.UseVisualStyleBackColor = false;
            // 
            // cmdReturn
            // 
            cmdReturn.BackColor = Color.FromArgb(64, 64, 64);
            cmdReturn.Cursor = Cursors.Hand;
            cmdReturn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdReturn.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdReturn.FlatStyle = FlatStyle.Flat;
            cmdReturn.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdReturn.ForeColor = Color.Yellow;
            cmdReturn.Image = My.Resources.Resources.basket_icon;
            cmdReturn.Location = new Point(448, 61);
            cmdReturn.Name = "cmdReturn";
            cmdReturn.Size = new Size(111, 110);
            cmdReturn.TabIndex = 3;
            cmdReturn.Text = "Stock &Return";
            cmdReturn.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(cmdReturn, "Purchases Return to Supplier");
            cmdReturn.UseVisualStyleBackColor = false;
            // 
            // cmdQty
            // 
            cmdQty.BackColor = Color.FromArgb(64, 64, 64);
            cmdQty.Cursor = Cursors.Hand;
            cmdQty.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdQty.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdQty.FlatStyle = FlatStyle.Flat;
            cmdQty.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdQty.ForeColor = Color.Yellow;
            cmdQty.Image = My.Resources.Resources._1480380353_self21;
            cmdQty.Location = new Point(24, 61);
            cmdQty.Name = "cmdQty";
            cmdQty.Size = new Size(111, 110);
            cmdQty.TabIndex = 0;
            cmdQty.Text = "&Stock Position";
            cmdQty.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(cmdQty, "Check Current Stock Position");
            cmdQty.UseVisualStyleBackColor = false;
            // 
            // cmdPurchase
            // 
            cmdPurchase.BackColor = Color.FromArgb(64, 64, 64);
            cmdPurchase.Cursor = Cursors.Hand;
            cmdPurchase.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdPurchase.FlatAppearance.MouseOverBackColor = Color.Teal;
            cmdPurchase.FlatStyle = FlatStyle.Flat;
            cmdPurchase.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdPurchase.ForeColor = Color.Yellow;
            cmdPurchase.Image = My.Resources.Resources.shopping_cart_full_icon;
            cmdPurchase.Location = new Point(306, 61);
            cmdPurchase.Name = "cmdPurchase";
            cmdPurchase.Size = new Size(111, 110);
            cmdPurchase.TabIndex = 2;
            cmdPurchase.Text = "&Purchases";
            cmdPurchase.TextAlign = ContentAlignment.BottomCenter;
            ToolTip1.SetToolTip(cmdPurchase, "Purchases from Supplier");
            cmdPurchase.UseVisualStyleBackColor = false;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(583, 336);
            Controls.Add(cmdViewPrch);
            Controls.Add(cmdProd);
            Controls.Add(cmdReturn);
            Controls.Add(cmdQty);
            Controls.Add(cmdPurchase);
            Controls.Add(cmdMin);
            Controls.Add(cmdClose);
            Controls.Add(Label1);
            Controls.Add(ShapeContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmStock";
            Text = "Stock";
            Load += new EventHandler(frmStock_Load);
            MouseDown += new MouseEventHandler(frmStock_MouseDown);
            MouseMove += new MouseEventHandler(frmStock_MouseMove);
            MouseUp += new MouseEventHandler(frmStock_MouseUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button cmdMin;
        internal Button cmdClose;
        internal Label Label1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape2;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Button cmdPurchase;
        internal Button cmdQty;
        internal Button cmdReturn;
        internal ToolTip ToolTip1;
        internal Button cmdProd;
        internal Button cmdViewPrch;
    }
}