using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Main : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cmdFoodItems = new System.Windows.Forms.Button();
            this.cmdDining = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.cmdViewSale = new System.Windows.Forms.Button();
            this.cmdSystem = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdSale = new System.Windows.Forms.Button();
            this.cmdMin = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.LineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ToolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.cmdFoodItems);
            this.Panel1.Controls.Add(this.cmdDining);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.cmdViewSale);
            this.Panel1.Controls.Add(this.cmdSystem);
            this.Panel1.Controls.Add(this.cmdClose);
            this.Panel1.Controls.Add(this.cmdExit);
            this.Panel1.Controls.Add(this.cmdSale);
            this.Panel1.Controls.Add(this.cmdMin);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.ShapeContainer1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1274, 111);
            this.Panel1.TabIndex = 1;
            // 
            // cmdFoodItems
            // 
            this.cmdFoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdFoodItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdFoodItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdFoodItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdFoodItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cmdFoodItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFoodItems.ForeColor = System.Drawing.Color.Yellow;
            this.cmdFoodItems.Image = global::POS_System.My.Resources.Resources.diet_64px;
            this.cmdFoodItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdFoodItems.Location = new System.Drawing.Point(323, 9);
            this.cmdFoodItems.Name = "cmdFoodItems";
            this.cmdFoodItems.Size = new System.Drawing.Size(99, 93);
            this.cmdFoodItems.TabIndex = 21;
            this.cmdFoodItems.TabStop = false;
            this.cmdFoodItems.Text = "&Food Items";
            this.cmdFoodItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdFoodItems.UseVisualStyleBackColor = false;
            this.cmdFoodItems.Click += new System.EventHandler(this.cmdFoodItems_Click);
            // 
            // cmdDining
            // 
            this.cmdDining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdDining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdDining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDining.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdDining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cmdDining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDining.ForeColor = System.Drawing.Color.Yellow;
            this.cmdDining.Image = global::POS_System.My.Resources.Resources.Breakfast_icon;
            this.cmdDining.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdDining.Location = new System.Drawing.Point(115, 10);
            this.cmdDining.Name = "cmdDining";
            this.cmdDining.Size = new System.Drawing.Size(99, 93);
            this.cmdDining.TabIndex = 20;
            this.cmdDining.TabStop = false;
            this.cmdDining.Text = "&Dining";
            this.cmdDining.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdDining.UseVisualStyleBackColor = false;
            this.cmdDining.Click += new System.EventHandler(this.cmdDining_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label4.Location = new System.Drawing.Point(1200, 80);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 16);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Limited";
            // 
            // cmdViewSale
            // 
            this.cmdViewSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdViewSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdViewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdViewSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdViewSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cmdViewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdViewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewSale.ForeColor = System.Drawing.Color.Yellow;
            this.cmdViewSale.Image = global::POS_System.My.Resources.Resources.Money_Bag_642;
            this.cmdViewSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdViewSale.Location = new System.Drawing.Point(218, 10);
            this.cmdViewSale.Name = "cmdViewSale";
            this.cmdViewSale.Size = new System.Drawing.Size(99, 93);
            this.cmdViewSale.TabIndex = 1;
            this.cmdViewSale.TabStop = false;
            this.cmdViewSale.Text = "V&iew Sale";
            this.cmdViewSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdViewSale.UseVisualStyleBackColor = false;
            this.cmdViewSale.Click += new System.EventHandler(this.cmdViewSale_Click);
            // 
            // cmdSystem
            // 
            this.cmdSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cmdSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSystem.ForeColor = System.Drawing.Color.Yellow;
            this.cmdSystem.Image = global::POS_System.My.Resources.Resources.system_maintenance_15367;
            this.cmdSystem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSystem.Location = new System.Drawing.Point(427, 9);
            this.cmdSystem.Name = "cmdSystem";
            this.cmdSystem.Size = new System.Drawing.Size(99, 93);
            this.cmdSystem.TabIndex = 5;
            this.cmdSystem.TabStop = false;
            this.cmdSystem.Text = "&System";
            this.cmdSystem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSystem.UseVisualStyleBackColor = false;
            this.cmdSystem.Click += new System.EventHandler(this.cmdSystem_Click);
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
            this.cmdClose.Location = new System.Drawing.Point(1237, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(31, 34);
            this.cmdClose.TabIndex = 17;
            this.cmdClose.TabStop = false;
            this.cmdClose.Text = "X";
            this.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.Yellow;
            this.cmdExit.Image = global::POS_System.My.Resources.Resources._1480381921_exit;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdExit.Location = new System.Drawing.Point(531, 9);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(99, 93);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.TabStop = false;
            this.cmdExit.Text = "&Quit";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSale
            // 
            this.cmdSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cmdSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSale.ForeColor = System.Drawing.Color.Yellow;
            this.cmdSale.Image = global::POS_System.My.Resources.Resources.fish_chips_64px;
            this.cmdSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSale.Location = new System.Drawing.Point(12, 10);
            this.cmdSale.Name = "cmdSale";
            this.cmdSale.Size = new System.Drawing.Size(99, 93);
            this.cmdSale.TabIndex = 0;
            this.cmdSale.TabStop = false;
            this.cmdSale.Text = "&Take Away";
            this.cmdSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSale.UseVisualStyleBackColor = false;
            this.cmdSale.Click += new System.EventHandler(this.cmdSale_Click);
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
            this.cmdMin.Location = new System.Drawing.Point(1204, 6);
            this.cmdMin.Name = "cmdMin";
            this.cmdMin.Size = new System.Drawing.Size(29, 34);
            this.cmdMin.TabIndex = 17;
            this.cmdMin.TabStop = false;
            this.cmdMin.Text = "----";
            this.cmdMin.UseVisualStyleBackColor = false;
            this.cmdMin.Click += new System.EventHandler(this.cmdMin_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Lime;
            this.Label1.Location = new System.Drawing.Point(1040, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(226, 31);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Restaurant POS";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LineShape1,
            this.LineShape2});
            this.ShapeContainer1.Size = new System.Drawing.Size(1270, 107);
            this.ShapeContainer1.TabIndex = 18;
            this.ShapeContainer1.TabStop = false;
            // 
            // LineShape1
            // 
            this.LineShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.LineShape1.Name = "LineShape1";
            this.LineShape1.X1 = 1048;
            this.LineShape1.X2 = 1270;
            this.LineShape1.Y1 = 45;
            this.LineShape1.Y2 = 45;
            // 
            // LineShape2
            // 
            this.LineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.LineShape2.Name = "LineShape2";
            this.LineShape2.X1 = 1050;
            this.LineShape2.X2 = 1269;
            this.LineShape2.Y1 = 44;
            this.LineShape2.Y2 = 44;
            // 
            // ToolTip2
            // 
            this.ToolTip2.AutomaticDelay = 1000;
            this.ToolTip2.AutoPopDelay = 10000;
            this.ToolTip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ToolTip2.InitialDelay = 500;
            this.ToolTip2.IsBalloon = true;
            this.ToolTip2.ReshowDelay = 100;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 627);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1274, 52);
            this.Panel2.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Label3.Location = new System.Drawing.Point(5, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(126, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "irfansafdar60@gmail.com";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Label2.Location = new System.Drawing.Point(2, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(213, 20);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Last Hope Micro Systems";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::POS_System.My.Resources.Resources.restaurant_449952;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 679);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "POS System Pro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        internal Panel Panel1;
        internal Button cmdMin;
        internal Label Label1;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape2;
        internal Button cmdSale;
        internal Button cmdExit;
        internal Button cmdClose;
        internal ToolTip ToolTip2;
        internal Panel Panel2;
        internal Label Label3;
        internal Label Label2;
        internal Button cmdSystem;
        internal Button cmdViewSale;
        internal Label Label4;
        internal Button cmdDining;
        internal Button cmdFoodItems;
    }
}