
namespace WholeSaleApplication
{
    partial class SaleBookReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleBookReturn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Col10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCredit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Col18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DgvSaleMaster = new System.Windows.Forms.DataGridView();
            this.DgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SaleDataSet = new System.Data.DataSet();
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleBindingource = new System.Windows.Forms.BindingSource(this.components);
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingource)).BeginInit();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "itemcompany";
            this.Column1.HeaderText = "Company";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 117;
            // 
            // Col9
            // 
            this.Col9.DataPropertyName = "itemqty";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Col9.DefaultCellStyle = dataGridViewCellStyle1;
            this.Col9.HeaderText = "M. Qty.";
            this.Col9.Name = "Col9";
            this.Col9.ReadOnly = true;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(239, 34);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(219, 21);
            this.dtpTo.TabIndex = 6;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(14, 34);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(219, 21);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date From";
            // 
            // Col10
            // 
            this.Col10.DataPropertyName = "itemaltqty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Col10.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col10.HeaderText = "Alt. Qty";
            this.Col10.Name = "Col10";
            this.Col10.ReadOnly = true;
            // 
            // Col15
            // 
            this.Col15.DataPropertyName = "itembasicprice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Col15.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col15.HeaderText = "Basic Price";
            this.Col15.Name = "Col15";
            this.Col15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "itempack";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn8.HeaderText = "Pack";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Col17
            // 
            this.Col17.DataPropertyName = "itemdiscamnt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Col17.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col17.HeaderText = "Disc.";
            this.Col17.Name = "Col17";
            this.Col17.ReadOnly = true;
            // 
            // Col19
            // 
            this.Col19.DataPropertyName = "itemtaxamt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Col19.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col19.HeaderText = "Tax Amnt.";
            this.Col19.Name = "Col19";
            this.Col19.ReadOnly = true;
            // 
            // Col20
            // 
            this.Col20.DataPropertyName = "itemnetvalue";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.Col20.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col20.HeaderText = "Sub Total";
            this.Col20.Name = "Col20";
            this.Col20.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblCredit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(883, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 71);
            this.panel1.TabIndex = 131;
            // 
            // lblCredit
            // 
            this.lblCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.ForeColor = System.Drawing.Color.White;
            this.lblCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCredit.Location = new System.Drawing.Point(0, 26);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(0);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(229, 45);
            this.lblCredit.TabIndex = 130;
            this.lblCredit.Text = "0";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 26);
            this.label4.TabIndex = 101;
            this.label4.Text = "Sale Return Amnt.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Col18
            // 
            this.Col18.DataPropertyName = "itemtaxpercent";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Col18.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col18.HeaderText = "Tax (%)";
            this.Col18.Name = "Col18";
            this.Col18.ReadOnly = true;
            this.Col18.Width = 95;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // DgvSaleMaster
            // 
            this.DgvSaleMaster.AllowUserToAddRows = false;
            this.DgvSaleMaster.AllowUserToDeleteRows = false;
            this.DgvSaleMaster.AllowUserToResizeColumns = false;
            this.DgvSaleMaster.AllowUserToResizeRows = false;
            this.DgvSaleMaster.AutoGenerateColumns = false;
            this.DgvSaleMaster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvSaleMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSaleMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSaleMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvSaleMaster.ColumnHeadersHeight = 40;
            this.DgvSaleMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col8,
            this.Col7});
            this.DgvSaleMaster.DataSource = this.SaleBindingource;
            this.DgvSaleMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvSaleMaster.EnableHeadersVisualStyles = false;
            this.DgvSaleMaster.Location = new System.Drawing.Point(0, 0);
            this.DgvSaleMaster.MultiSelect = false;
            this.DgvSaleMaster.Name = "DgvSaleMaster";
            this.DgvSaleMaster.ReadOnly = true;
            this.DgvSaleMaster.RowHeadersVisible = false;
            this.DgvSaleMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSaleMaster.Size = new System.Drawing.Size(1114, 378);
            this.DgvSaleMaster.TabIndex = 100;
            this.DgvSaleMaster.TabStop = false;
            this.toolTip1.SetToolTip(this.DgvSaleMaster, "Double Click to Edit Invoice");
            this.DgvSaleMaster.SelectionChanged += new System.EventHandler(this.DgvSaleMaster_SelectionChanged);
            // 
            // DgvOrderDetail
            // 
            this.DgvOrderDetail.AllowUserToAddRows = false;
            this.DgvOrderDetail.AllowUserToDeleteRows = false;
            this.DgvOrderDetail.AutoGenerateColumns = false;
            this.DgvOrderDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvOrderDetail.ColumnHeadersHeight = 35;
            this.DgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.dataGridViewTextBoxColumn8,
            this.Col9,
            this.Col10,
            this.Col15,
            this.Col17,
            this.Col18,
            this.Col19,
            this.Col20});
            this.DgvOrderDetail.DataSource = this.DetailBindingSource;
            this.DgvOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvOrderDetail.EnableHeadersVisualStyles = false;
            this.DgvOrderDetail.Location = new System.Drawing.Point(0, 456);
            this.DgvOrderDetail.Name = "DgvOrderDetail";
            this.DgvOrderDetail.ReadOnly = true;
            this.DgvOrderDetail.RowHeadersVisible = false;
            this.DgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrderDetail.Size = new System.Drawing.Size(1114, 142);
            this.DgvOrderDetail.TabIndex = 133;
            this.DgvOrderDetail.TabStop = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "itemname";
            this.dataGridViewTextBoxColumn5.HeaderText = "Item Desc.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.dtpTo);
            this.SplitContainer1.Panel1.Controls.Add(this.dtpFrom);
            this.SplitContainer1.Panel1.Controls.Add(this.label2);
            this.SplitContainer1.Panel1.Controls.Add(this.label1);
            this.SplitContainer1.Panel1.Controls.Add(this.BtnClose);
            this.SplitContainer1.Panel1.Controls.Add(this.btnReturn);
            this.SplitContainer1.Panel1.Controls.Add(this.BtnPrint);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.DgvOrderDetail);
            this.SplitContainer1.Panel2.Controls.Add(this.panel1);
            this.SplitContainer1.Panel2.Controls.Add(this.DgvSaleMaster);
            this.SplitContainer1.Size = new System.Drawing.Size(1116, 681);
            this.SplitContainer1.SplitterDistance = 77;
            this.SplitContainer1.TabIndex = 99;
            this.SplitContainer1.TabStop = false;
            // 
            // SaleDataSet
            // 
            this.SaleDataSet.DataSetName = "NewDataSet";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.LightGray;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(971, 19);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(126, 37);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "&Close";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnClose, "Back to Main Window");
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightGray;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = global::WholeSaleApplication.Properties.Resources.Redo;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(709, 19);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(126, 37);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "&Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.LightGray;
            this.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Location = new System.Drawing.Point(840, 19);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(126, 37);
            this.BtnPrint.TabIndex = 3;
            this.BtnPrint.Text = "&Print";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BtnPrint, "Print Selected Invoice");
            this.BtnPrint.UseVisualStyleBackColor = false;
            // 
            // Col1
            // 
            this.Col1.DataPropertyName = "date";
            this.Col1.HeaderText = "Date";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.DataPropertyName = "saleorderid";
            this.Col2.HeaderText = "Sale Order";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Width = 120;
            // 
            // Col3
            // 
            this.Col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col3.DataPropertyName = "accountname";
            this.Col3.HeaderText = "Party";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            // 
            // Col4
            // 
            this.Col4.DataPropertyName = "transactiontype";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col4.DefaultCellStyle = dataGridViewCellStyle10;
            this.Col4.HeaderText = "Sale Type";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            this.Col4.Width = 121;
            // 
            // Col5
            // 
            this.Col5.DataPropertyName = "discount";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0.00";
            this.Col5.DefaultCellStyle = dataGridViewCellStyle11;
            this.Col5.HeaderText = "Discount";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col8
            // 
            this.Col8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col8.DataPropertyName = "ordersalesman";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col8.DefaultCellStyle = dataGridViewCellStyle12;
            this.Col8.HeaderText = "Sales Man";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.DataPropertyName = "cramount";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0.00";
            this.Col7.DefaultCellStyle = dataGridViewCellStyle13;
            this.Col7.HeaderText = "Credit";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            this.Col7.Width = 121;
            // 
            // SaleBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 681);
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaleBookReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Return";
            this.Load += new System.EventHandler(this.SaleBookReturn_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetail)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col9;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col15;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col20;
        private System.Windows.Forms.BindingSource DetailBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col18;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView DgvSaleMaster;
        private System.Windows.Forms.BindingSource SaleBindingource;
        private System.Windows.Forms.DataGridView DgvOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Data.DataSet SaleDataSet;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
    }
}