using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class FoodMenuList : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenuList));
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdOrder = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.ItemFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lvOrderList = new System.Windows.Forms.ListView();
            this.ColOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdClear = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.NumFriction = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.ColCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer1.Location = new System.Drawing.Point(12, 12);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.AutoScroll = true;
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Controls.Add(this.GroupFlowPanel);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.AutoScroll = true;
            this.SplitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SplitContainer1.Panel2.Controls.Add(this.Label2);
            this.SplitContainer1.Panel2.Controls.Add(this.cmdRefresh);
            this.SplitContainer1.Panel2.Controls.Add(this.cmdOrder);
            this.SplitContainer1.Panel2.Controls.Add(this.cmdClose);
            this.SplitContainer1.Panel2.Controls.Add(this.ItemFlowPanel);
            this.SplitContainer1.Size = new System.Drawing.Size(760, 642);
            this.SplitContainer1.SplitterDistance = 260;
            this.SplitContainer1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Label1.Location = new System.Drawing.Point(5, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(248, 41);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "MAIN MENU";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupFlowPanel
            // 
            this.GroupFlowPanel.Location = new System.Drawing.Point(5, 56);
            this.GroupFlowPanel.Name = "GroupFlowPanel";
            this.GroupFlowPanel.Size = new System.Drawing.Size(248, 581);
            this.GroupFlowPanel.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.Label2.Location = new System.Drawing.Point(8, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(105, 41);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "ITEMS";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRefresh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefresh.Location = new System.Drawing.Point(195, 10);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(93, 39);
            this.cmdRefresh.TabIndex = 3;
            this.cmdRefresh.Text = "&Refresh";
            this.ToolTip1.SetToolTip(this.cmdRefresh, "Click to refresh the Items");
            this.cmdRefresh.UseVisualStyleBackColor = false;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdOrder
            // 
            this.cmdOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrder.Location = new System.Drawing.Point(294, 10);
            this.cmdOrder.Name = "cmdOrder";
            this.cmdOrder.Size = new System.Drawing.Size(93, 39);
            this.cmdOrder.TabIndex = 2;
            this.cmdOrder.Text = "&Order";
            this.ToolTip1.SetToolTip(this.cmdOrder, "Click to Place the Order List");
            this.cmdOrder.UseVisualStyleBackColor = false;
            this.cmdOrder.Click += new System.EventHandler(this.cmdOrder_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Red;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClose.Location = new System.Drawing.Point(393, 10);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(93, 39);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "&Close";
            this.ToolTip1.SetToolTip(this.cmdClose, "Close without order list");
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // ItemFlowPanel
            // 
            this.ItemFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemFlowPanel.Location = new System.Drawing.Point(8, 56);
            this.ItemFlowPanel.Name = "ItemFlowPanel";
            this.ItemFlowPanel.Size = new System.Drawing.Size(478, 581);
            this.ItemFlowPanel.TabIndex = 0;
            // 
            // lvOrderList
            // 
            this.lvOrderList.AutoArrange = false;
            this.lvOrderList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvOrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColOrder,
            this.ColQty,
            this.ColPack,
            this.ColPrice,
            this.ColCode});
            this.lvOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrderList.FullRowSelect = true;
            this.lvOrderList.GridLines = true;
            this.lvOrderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvOrderList.HideSelection = false;
            this.lvOrderList.Location = new System.Drawing.Point(776, 12);
            this.lvOrderList.MultiSelect = false;
            this.lvOrderList.Name = "lvOrderList";
            this.lvOrderList.Size = new System.Drawing.Size(378, 451);
            this.lvOrderList.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.lvOrderList, "Items Order List");
            this.lvOrderList.UseCompatibleStateImageBehavior = false;
            this.lvOrderList.View = System.Windows.Forms.View.Details;
            this.lvOrderList.DoubleClick += new System.EventHandler(this.lvOrderList_DoubleClick);
            // 
            // ColOrder
            // 
            this.ColOrder.Text = "Item";
            this.ColOrder.Width = 120;
            // 
            // ColQty
            // 
            this.ColQty.Text = "Qty";
            this.ColQty.Width = 80;
            // 
            // ColPrice
            // 
            this.ColPrice.DisplayIndex = 2;
            this.ColPrice.Text = "Code";
            this.ColPrice.Width = 80;
            // 
            // ToolTip1
            // 
            this.ToolTip1.IsBalloon = true;
            this.ToolTip1.ToolTipTitle = "Tip";
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.cmdClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(1013, 469);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(70, 26);
            this.cmdClear.TabIndex = 30;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(862, 469);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(146, 26);
            this.lblDisplay.TabIndex = 29;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.cmdBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdBack.Location = new System.Drawing.Point(1014, 620);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(70, 34);
            this.cmdBack.TabIndex = 28;
            this.cmdBack.Text = "";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // Num0
            // 
            this.Num0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num0.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.Location = new System.Drawing.Point(938, 620);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(70, 34);
            this.Num0.TabIndex = 27;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = false;
            this.Num0.Click += new System.EventHandler(this.DigitClick);
            // 
            // NumFriction
            // 
            this.NumFriction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumFriction.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.NumFriction.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.NumFriction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.NumFriction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.NumFriction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumFriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumFriction.Location = new System.Drawing.Point(862, 620);
            this.NumFriction.Name = "NumFriction";
            this.NumFriction.Size = new System.Drawing.Size(70, 34);
            this.NumFriction.TabIndex = 26;
            this.NumFriction.Text = ".";
            this.NumFriction.UseVisualStyleBackColor = false;
            this.NumFriction.Click += new System.EventHandler(this.NumFriction_Click);
            // 
            // Num9
            // 
            this.Num9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.Location = new System.Drawing.Point(1014, 580);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(70, 34);
            this.Num9.TabIndex = 25;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = false;
            this.Num9.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num8
            // 
            this.Num8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.Location = new System.Drawing.Point(938, 580);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(70, 34);
            this.Num8.TabIndex = 24;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = false;
            this.Num8.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num7
            // 
            this.Num7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.Location = new System.Drawing.Point(862, 580);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(70, 34);
            this.Num7.TabIndex = 23;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = false;
            this.Num7.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(1013, 540);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(70, 34);
            this.Num6.TabIndex = 22;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = false;
            this.Num6.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(938, 540);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(70, 34);
            this.Num5.TabIndex = 21;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = false;
            this.Num5.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(862, 540);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(70, 34);
            this.Num4.TabIndex = 20;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = false;
            this.Num4.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(1013, 500);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(70, 34);
            this.Num3.TabIndex = 19;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = false;
            this.Num3.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(938, 500);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(70, 34);
            this.Num2.TabIndex = 18;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = false;
            this.Num2.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Num1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(862, 500);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(70, 34);
            this.Num1.TabIndex = 17;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = false;
            this.Num1.Click += new System.EventHandler(this.DigitClick);
            // 
            // ColCode
            // 
            this.ColCode.DisplayIndex = 3;
            this.ColCode.Width = 40;
            // 
            // ColPack
            // 
            this.ColPack.DisplayIndex = 4;
            this.ColPack.Width = 40;
            // 
            // FoodMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1165, 666);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.NumFriction);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.lvOrderList);
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FoodMenuList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items Selection Menu";
            this.Load += new System.EventHandler(this.frmFoodMenu_Load);
            this.Click += new System.EventHandler(this.ItemButton);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal SplitContainer SplitContainer1;
        internal ColumnHeader ColQty;
        internal ColumnHeader ColOrder;
        internal FlowLayoutPanel GroupFlowPanel;
        internal FlowLayoutPanel ItemFlowPanel;
        internal ColumnHeader ColPrice;
        internal Label Label1;
        internal Button cmdClose;
        internal Button cmdOrder;
        internal Button cmdRefresh;
        internal Label Label2;
        internal ToolTip ToolTip1;
        public ListView lvOrderList;
        internal Button cmdClear;
        internal Label lblDisplay;
        internal Button cmdBack;
        internal Button Num0;
        internal Button NumFriction;
        internal Button Num9;
        internal Button Num8;
        internal Button Num7;
        internal Button Num6;
        internal Button Num5;
        internal Button Num4;
        internal Button Num3;
        internal Button Num2;
        internal Button Num1;
        private ColumnHeader ColCode;
        private ColumnHeader ColPack;
    }
}