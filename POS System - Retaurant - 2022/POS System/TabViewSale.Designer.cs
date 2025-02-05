using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class TabViewSale : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabViewSale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecordDataSet = new System.Data.DataSet();
            this.MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmdFindTab1 = new System.Windows.Forms.Button();
            this.cmdViewTab1 = new System.Windows.Forms.Button();
            this.dtDateTab1 = new System.Windows.Forms.DateTimePicker();
            this.cmdPayment = new System.Windows.Forms.Button();
            this.cmdFindTab2 = new System.Windows.Forms.Button();
            this.cmdViewTab2 = new System.Windows.Forms.Button();
            this.dtDateTab2 = new System.Windows.Forms.DateTimePicker();
            this.cmdFindTab3 = new System.Windows.Forms.Button();
            this.cmdViewTab3 = new System.Windows.Forms.Button();
            this.dtDateTab3 = new System.Windows.Forms.DateTimePicker();
            this.cmdFindTab4 = new System.Windows.Forms.Button();
            this.cmdViewTab4 = new System.Windows.Forms.Button();
            this.dtDateTab4 = new System.Windows.Forms.DateTimePicker();
            this.DotNetBarTabcontrol = new POS_System.DotNetBarTabcontrol();
            this.CashSale = new System.Windows.Forms.TabPage();
            this.Button2 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dgMasterInfo = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgChildInfo = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditSale = new System.Windows.Forms.TabPage();
            this.Button1 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.dgMasterInfo1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgChildInfo1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleRecovery = new System.Windows.Forms.TabPage();
            this.Button3 = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dgMasterInfo2 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgChildInfo2 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnSale = new System.Windows.Forms.TabPage();
            this.Button4 = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.dgMasterInfo3 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgChildInfo3 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabReport = new System.Windows.Forms.TabPage();
            this.cmdClose = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmdPreview = new System.Windows.Forms.Button();
            this.gbSelectReport = new System.Windows.Forms.GroupBox();
            this.rdReturn = new System.Windows.Forms.RadioButton();
            this.rdRecovery = new System.Windows.Forms.RadioButton();
            this.rdCredit = new System.Windows.Forms.RadioButton();
            this.rdDaily = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterBindingSource)).BeginInit();
            this.DotNetBarTabcontrol.SuspendLayout();
            this.CashSale.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo)).BeginInit();
            this.CreditSale.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo1)).BeginInit();
            this.SaleRecovery.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo2)).BeginInit();
            this.ReturnSale.SuspendLayout();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterInfo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo3)).BeginInit();
            this.TabReport.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.gbSelectReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "1480381704_column_chart.png");
            this.ImageList1.Images.SetKeyName(1, "Purse_64.png");
            this.ImageList1.Images.SetKeyName(2, "Money-64x64.png");
            this.ImageList1.Images.SetKeyName(3, "Medical-invoice-information-64.png");
            this.ImageList1.Images.SetKeyName(4, "Analysis-64.png");
            this.ImageList1.Images.SetKeyName(5, "PKR_Rs_1000_3.jpg");
            // 
            // DetailBindingSource
            // 
            this.DetailBindingSource.DataSource = this.RecordDataSet;
            this.DetailBindingSource.Position = 0;
            // 
            // RecordDataSet
            // 
            this.RecordDataSet.DataSetName = "RecordDataSet";
            // 
            // MasterBindingSource
            // 
            this.MasterBindingSource.DataSource = this.RecordDataSet;
            this.MasterBindingSource.Position = 0;
            // 
            // MyToolTip
            // 
            this.MyToolTip.IsBalloon = true;
            this.MyToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MyToolTip.ToolTipTitle = "Tip";
            // 
            // cmdFindTab1
            // 
            this.cmdFindTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdFindTab1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFindTab1.Image = global::POS_System.My.Resources.Resources.search15;
            this.cmdFindTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFindTab1.Location = new System.Drawing.Point(445, 5);
            this.cmdFindTab1.Name = "cmdFindTab1";
            this.cmdFindTab1.Size = new System.Drawing.Size(57, 26);
            this.cmdFindTab1.TabIndex = 4;
            this.cmdFindTab1.Text = "&Find";
            this.cmdFindTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdFindTab1, "Find sale invoice");
            this.cmdFindTab1.UseVisualStyleBackColor = true;
            this.cmdFindTab1.Click += new System.EventHandler(this.cmdFindTab1_Click);
            // 
            // cmdViewTab1
            // 
            this.cmdViewTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdViewTab1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdViewTab1.Image = global::POS_System.My.Resources.Resources.search16;
            this.cmdViewTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdViewTab1.Location = new System.Drawing.Point(751, 5);
            this.cmdViewTab1.Name = "cmdViewTab1";
            this.cmdViewTab1.Size = new System.Drawing.Size(61, 26);
            this.cmdViewTab1.TabIndex = 2;
            this.cmdViewTab1.Text = "&View";
            this.cmdViewTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdViewTab1, "Select date and view all sales invoices");
            this.cmdViewTab1.UseVisualStyleBackColor = true;
            this.cmdViewTab1.Click += new System.EventHandler(this.cmdViewTab1_Click);
            // 
            // dtDateTab1
            // 
            this.dtDateTab1.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtDateTab1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateTab1.Location = new System.Drawing.Point(507, 7);
            this.dtDateTab1.Name = "dtDateTab1";
            this.dtDateTab1.Size = new System.Drawing.Size(238, 23);
            this.dtDateTab1.TabIndex = 1;
            this.MyToolTip.SetToolTip(this.dtDateTab1, "Select date for view");
            // 
            // cmdPayment
            // 
            this.cmdPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPayment.Image = global::POS_System.My.Resources.Resources.PKR_Rs_1000_32;
            this.cmdPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPayment.Location = new System.Drawing.Point(337, 5);
            this.cmdPayment.Name = "cmdPayment";
            this.cmdPayment.Size = new System.Drawing.Size(103, 26);
            this.cmdPayment.TabIndex = 6;
            this.cmdPayment.Text = "&Payment";
            this.cmdPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdPayment, "Click to received payment");
            this.cmdPayment.UseVisualStyleBackColor = true;
            this.cmdPayment.Click += new System.EventHandler(this.cmdPayment_Click);
            // 
            // cmdFindTab2
            // 
            this.cmdFindTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdFindTab2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFindTab2.Image = global::POS_System.My.Resources.Resources.search15;
            this.cmdFindTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFindTab2.Location = new System.Drawing.Point(445, 5);
            this.cmdFindTab2.Name = "cmdFindTab2";
            this.cmdFindTab2.Size = new System.Drawing.Size(57, 26);
            this.cmdFindTab2.TabIndex = 5;
            this.cmdFindTab2.Text = "&Find";
            this.cmdFindTab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdFindTab2, "Find credit sale invoice");
            this.cmdFindTab2.UseVisualStyleBackColor = true;
            this.cmdFindTab2.Click += new System.EventHandler(this.cmdFindTab2_Click);
            // 
            // cmdViewTab2
            // 
            this.cmdViewTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdViewTab2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdViewTab2.Image = global::POS_System.My.Resources.Resources.search17;
            this.cmdViewTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdViewTab2.Location = new System.Drawing.Point(751, 5);
            this.cmdViewTab2.Name = "cmdViewTab2";
            this.cmdViewTab2.Size = new System.Drawing.Size(61, 26);
            this.cmdViewTab2.TabIndex = 1;
            this.cmdViewTab2.Text = "&View";
            this.cmdViewTab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdViewTab2, "Select date and view all sales invoices");
            this.cmdViewTab2.UseVisualStyleBackColor = true;
            this.cmdViewTab2.Click += new System.EventHandler(this.cmdViewTab2_Click);
            // 
            // dtDateTab2
            // 
            this.dtDateTab2.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtDateTab2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateTab2.Location = new System.Drawing.Point(507, 7);
            this.dtDateTab2.Name = "dtDateTab2";
            this.dtDateTab2.Size = new System.Drawing.Size(238, 23);
            this.dtDateTab2.TabIndex = 0;
            this.MyToolTip.SetToolTip(this.dtDateTab2, "Select date for view");
            // 
            // cmdFindTab3
            // 
            this.cmdFindTab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdFindTab3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFindTab3.Image = global::POS_System.My.Resources.Resources.search15;
            this.cmdFindTab3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFindTab3.Location = new System.Drawing.Point(445, 5);
            this.cmdFindTab3.Name = "cmdFindTab3";
            this.cmdFindTab3.Size = new System.Drawing.Size(57, 26);
            this.cmdFindTab3.TabIndex = 7;
            this.cmdFindTab3.Text = "&Find";
            this.cmdFindTab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdFindTab3, "Find recovery sale invoice");
            this.cmdFindTab3.UseVisualStyleBackColor = true;
            this.cmdFindTab3.Click += new System.EventHandler(this.cmdFindTab3_Click);
            // 
            // cmdViewTab3
            // 
            this.cmdViewTab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdViewTab3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdViewTab3.Image = global::POS_System.My.Resources.Resources.search18;
            this.cmdViewTab3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdViewTab3.Location = new System.Drawing.Point(751, 5);
            this.cmdViewTab3.Name = "cmdViewTab3";
            this.cmdViewTab3.Size = new System.Drawing.Size(61, 26);
            this.cmdViewTab3.TabIndex = 5;
            this.cmdViewTab3.Text = "&View";
            this.cmdViewTab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdViewTab3, "Select date and view all recovery sales invoices");
            this.cmdViewTab3.UseVisualStyleBackColor = true;
            this.cmdViewTab3.Click += new System.EventHandler(this.cmdViewTab3_Click);
            // 
            // dtDateTab3
            // 
            this.dtDateTab3.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtDateTab3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateTab3.Location = new System.Drawing.Point(507, 7);
            this.dtDateTab3.Name = "dtDateTab3";
            this.dtDateTab3.Size = new System.Drawing.Size(238, 23);
            this.dtDateTab3.TabIndex = 3;
            this.MyToolTip.SetToolTip(this.dtDateTab3, "Select date for view");
            // 
            // cmdFindTab4
            // 
            this.cmdFindTab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdFindTab4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFindTab4.Image = global::POS_System.My.Resources.Resources.search15;
            this.cmdFindTab4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdFindTab4.Location = new System.Drawing.Point(445, 5);
            this.cmdFindTab4.Name = "cmdFindTab4";
            this.cmdFindTab4.Size = new System.Drawing.Size(57, 26);
            this.cmdFindTab4.TabIndex = 8;
            this.cmdFindTab4.Text = "&Find";
            this.cmdFindTab4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdFindTab4, "Find return sale invoice");
            this.cmdFindTab4.UseVisualStyleBackColor = true;
            this.cmdFindTab4.Click += new System.EventHandler(this.cmdFindTab4_Click);
            // 
            // cmdViewTab4
            // 
            this.cmdViewTab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdViewTab4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdViewTab4.Image = global::POS_System.My.Resources.Resources.search19;
            this.cmdViewTab4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdViewTab4.Location = new System.Drawing.Point(751, 5);
            this.cmdViewTab4.Name = "cmdViewTab4";
            this.cmdViewTab4.Size = new System.Drawing.Size(61, 26);
            this.cmdViewTab4.TabIndex = 5;
            this.cmdViewTab4.Text = "&View";
            this.cmdViewTab4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyToolTip.SetToolTip(this.cmdViewTab4, "Select date and view all return sales invoices");
            this.cmdViewTab4.UseVisualStyleBackColor = true;
            this.cmdViewTab4.Click += new System.EventHandler(this.cmdViewTab4_Click);
            // 
            // dtDateTab4
            // 
            this.dtDateTab4.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtDateTab4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateTab4.Location = new System.Drawing.Point(507, 7);
            this.dtDateTab4.Name = "dtDateTab4";
            this.dtDateTab4.Size = new System.Drawing.Size(238, 23);
            this.dtDateTab4.TabIndex = 3;
            this.MyToolTip.SetToolTip(this.dtDateTab4, "Select date for view");
            // 
            // DotNetBarTabcontrol
            // 
            this.DotNetBarTabcontrol.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.DotNetBarTabcontrol.Controls.Add(this.CashSale);
            this.DotNetBarTabcontrol.Controls.Add(this.CreditSale);
            this.DotNetBarTabcontrol.Controls.Add(this.SaleRecovery);
            this.DotNetBarTabcontrol.Controls.Add(this.ReturnSale);
            this.DotNetBarTabcontrol.Controls.Add(this.TabReport);
            this.DotNetBarTabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotNetBarTabcontrol.ImageList = this.ImageList1;
            this.DotNetBarTabcontrol.ItemSize = new System.Drawing.Size(44, 136);
            this.DotNetBarTabcontrol.Location = new System.Drawing.Point(0, 0);
            this.DotNetBarTabcontrol.Multiline = true;
            this.DotNetBarTabcontrol.Name = "DotNetBarTabcontrol";
            this.DotNetBarTabcontrol.SelectedIndex = 0;
            this.DotNetBarTabcontrol.Size = new System.Drawing.Size(1019, 648);
            this.DotNetBarTabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.DotNetBarTabcontrol.TabIndex = 0;
            this.DotNetBarTabcontrol.SelectedIndexChanged += new System.EventHandler(this.DotNetBarTabcontrol_SelectedIndexChanged);
            // 
            // CashSale
            // 
            this.CashSale.BackColor = System.Drawing.Color.White;
            this.CashSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CashSale.Controls.Add(this.cmdFindTab1);
            this.CashSale.Controls.Add(this.Button2);
            this.CashSale.Controls.Add(this.cmdViewTab1);
            this.CashSale.Controls.Add(this.dtDateTab1);
            this.CashSale.Controls.Add(this.Panel1);
            this.CashSale.ImageIndex = 0;
            this.CashSale.Location = new System.Drawing.Point(140, 4);
            this.CashSale.Name = "CashSale";
            this.CashSale.Padding = new System.Windows.Forms.Padding(3);
            this.CashSale.Size = new System.Drawing.Size(875, 640);
            this.CashSale.TabIndex = 0;
            this.CashSale.Text = "Cash Sale";
            // 
            // Button2
            // 
            this.Button2.BackgroundImage = global::POS_System.My.Resources.Resources.remove4;
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Location = new System.Drawing.Point(817, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(39, 26);
            this.Button2.TabIndex = 3;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.dgMasterInfo);
            this.Panel1.Controls.Add(this.dgChildInfo);
            this.Panel1.Location = new System.Drawing.Point(6, 36);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(850, 585);
            this.Panel1.TabIndex = 0;
            // 
            // dgMasterInfo
            // 
            this.dgMasterInfo.AllowUserToAddRows = false;
            this.dgMasterInfo.AllowUserToDeleteRows = false;
            this.dgMasterInfo.AutoGenerateColumns = false;
            this.dgMasterInfo.BackgroundColor = System.Drawing.Color.Gray;
            this.dgMasterInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgMasterInfo.ColumnHeadersHeight = 22;
            this.dgMasterInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMasterInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn1,
            this.colCustID,
            this.colDate,
            this.colTotal,
            this.colPaid,
            this.colDiscount,
            this.colUser});
            this.dgMasterInfo.DataSource = this.MasterBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMasterInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgMasterInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMasterInfo.Location = new System.Drawing.Point(0, 0);
            this.dgMasterInfo.Name = "dgMasterInfo";
            this.dgMasterInfo.ReadOnly = true;
            this.dgMasterInfo.RowHeadersVisible = false;
            this.dgMasterInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMasterInfo.Size = new System.Drawing.Size(850, 381);
            this.dgMasterInfo.TabIndex = 3;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn4.DataPropertyName = "SaleID";
            this.DataGridViewTextBoxColumn4.HeaderText = "Invoice #";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn1.DataPropertyName = "SaleType";
            this.DataGridViewTextBoxColumn1.HeaderText = "Description";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colCustID
            // 
            this.colCustID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustID.DataPropertyName = "CustomerID";
            this.colCustID.HeaderText = "Cust. ID";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "DateCompleted";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "SaleTotal";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 88;
            // 
            // colPaid
            // 
            this.colPaid.DataPropertyName = "SalePaid";
            this.colPaid.HeaderText = "Payment";
            this.colPaid.Name = "colPaid";
            this.colPaid.ReadOnly = true;
            this.colPaid.Width = 87;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "SaleDiscount";
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            this.colDiscount.Width = 85;
            // 
            // colUser
            // 
            this.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUser.DataPropertyName = "DrawerName";
            this.colUser.HeaderText = "User Name";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // dgChildInfo
            // 
            this.dgChildInfo.AllowUserToAddRows = false;
            this.dgChildInfo.AllowUserToDeleteRows = false;
            this.dgChildInfo.AutoGenerateColumns = false;
            this.dgChildInfo.BackgroundColor = System.Drawing.Color.Gray;
            this.dgChildInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgChildInfo.ColumnHeadersHeight = 22;
            this.dgChildInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgChildInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn10,
            this.DataGridViewTextBoxColumn17,
            this.DataGridViewTextBoxColumn19,
            this.DataGridViewTextBoxColumn20,
            this.DataGridViewTextBoxColumn21,
            this.DataGridViewTextBoxColumn22});
            this.dgChildInfo.DataSource = this.DetailBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChildInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgChildInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgChildInfo.Location = new System.Drawing.Point(0, 381);
            this.dgChildInfo.Name = "dgChildInfo";
            this.dgChildInfo.ReadOnly = true;
            this.dgChildInfo.RowHeadersVisible = false;
            this.dgChildInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChildInfo.Size = new System.Drawing.Size(850, 204);
            this.dgChildInfo.TabIndex = 4;
            this.dgChildInfo.TabStop = false;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn10.DataPropertyName = "SaleID";
            this.DataGridViewTextBoxColumn10.HeaderText = "Invoice #";
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn17
            // 
            this.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn17.DataPropertyName = "CustomerName";
            this.DataGridViewTextBoxColumn17.HeaderText = "Customer";
            this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            this.DataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn19
            // 
            this.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn19.DataPropertyName = "STOCKDESC";
            this.DataGridViewTextBoxColumn19.HeaderText = "Description";
            this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            this.DataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn20
            // 
            this.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn20.DataPropertyName = "UnitCost";
            this.DataGridViewTextBoxColumn20.HeaderText = "Price";
            this.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
            this.DataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn21
            // 
            this.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn21.DataPropertyName = "QTY";
            this.DataGridViewTextBoxColumn21.HeaderText = "Qty";
            this.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
            this.DataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn22
            // 
            this.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn22.DataPropertyName = "PRICE";
            this.DataGridViewTextBoxColumn22.HeaderText = "Sub Total";
            this.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
            this.DataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // CreditSale
            // 
            this.CreditSale.BackColor = System.Drawing.Color.White;
            this.CreditSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreditSale.Controls.Add(this.cmdPayment);
            this.CreditSale.Controls.Add(this.cmdFindTab2);
            this.CreditSale.Controls.Add(this.Button1);
            this.CreditSale.Controls.Add(this.cmdViewTab2);
            this.CreditSale.Controls.Add(this.dtDateTab2);
            this.CreditSale.Controls.Add(this.Panel2);
            this.CreditSale.ImageIndex = 3;
            this.CreditSale.Location = new System.Drawing.Point(140, 4);
            this.CreditSale.Name = "CreditSale";
            this.CreditSale.Padding = new System.Windows.Forms.Padding(3);
            this.CreditSale.Size = new System.Drawing.Size(875, 640);
            this.CreditSale.TabIndex = 1;
            this.CreditSale.Text = "Credit Sale";
            // 
            // Button1
            // 
            this.Button1.BackgroundImage = global::POS_System.My.Resources.Resources.remove4;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Location = new System.Drawing.Point(817, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(39, 26);
            this.Button1.TabIndex = 2;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.dgMasterInfo1);
            this.Panel2.Controls.Add(this.dgChildInfo1);
            this.Panel2.Location = new System.Drawing.Point(6, 36);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(850, 585);
            this.Panel2.TabIndex = 1;
            // 
            // dgMasterInfo1
            // 
            this.dgMasterInfo1.AllowUserToAddRows = false;
            this.dgMasterInfo1.AllowUserToDeleteRows = false;
            this.dgMasterInfo1.AutoGenerateColumns = false;
            this.dgMasterInfo1.BackgroundColor = System.Drawing.Color.Gray;
            this.dgMasterInfo1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgMasterInfo1.ColumnHeadersHeight = 22;
            this.dgMasterInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMasterInfo1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9,
            this.colCredit,
            this.DataGridViewTextBoxColumn11});
            this.dgMasterInfo1.DataSource = this.MasterBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMasterInfo1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgMasterInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMasterInfo1.Location = new System.Drawing.Point(0, 0);
            this.dgMasterInfo1.Name = "dgMasterInfo1";
            this.dgMasterInfo1.ReadOnly = true;
            this.dgMasterInfo1.RowHeadersVisible = false;
            this.dgMasterInfo1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMasterInfo1.Size = new System.Drawing.Size(850, 381);
            this.dgMasterInfo1.TabIndex = 2;
            this.dgMasterInfo1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMasterInfo1_CellContentClick);
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn2.DataPropertyName = "SaleID";
            this.DataGridViewTextBoxColumn2.HeaderText = "Invoice #";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn3.DataPropertyName = "SaleType";
            this.DataGridViewTextBoxColumn3.HeaderText = "Description";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.DataPropertyName = "DateCompleted";
            this.DataGridViewTextBoxColumn6.HeaderText = "Date";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.DataPropertyName = "SaleTotal";
            this.DataGridViewTextBoxColumn7.HeaderText = "Total";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            this.DataGridViewTextBoxColumn7.Width = 88;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.DataPropertyName = "SalePaid";
            this.DataGridViewTextBoxColumn8.HeaderText = "Payment";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly = true;
            this.DataGridViewTextBoxColumn8.Width = 87;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.DataPropertyName = "SaleDiscount";
            this.DataGridViewTextBoxColumn9.HeaderText = "Discount";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.ReadOnly = true;
            this.DataGridViewTextBoxColumn9.Width = 85;
            // 
            // colCredit
            // 
            this.colCredit.DataPropertyName = "SaleCredit";
            this.colCredit.HeaderText = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn11.DataPropertyName = "DrawerName";
            this.DataGridViewTextBoxColumn11.HeaderText = "User Name";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dgChildInfo1
            // 
            this.dgChildInfo1.AllowUserToAddRows = false;
            this.dgChildInfo1.AllowUserToDeleteRows = false;
            this.dgChildInfo1.AutoGenerateColumns = false;
            this.dgChildInfo1.BackgroundColor = System.Drawing.Color.Gray;
            this.dgChildInfo1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgChildInfo1.ColumnHeadersHeight = 22;
            this.dgChildInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgChildInfo1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn12,
            this.colCustomerID,
            this.DataGridViewTextBoxColumn13,
            this.DataGridViewTextBoxColumn14,
            this.DataGridViewTextBoxColumn15,
            this.DataGridViewTextBoxColumn16,
            this.DataGridViewTextBoxColumn18});
            this.dgChildInfo1.DataSource = this.DetailBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChildInfo1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgChildInfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgChildInfo1.Location = new System.Drawing.Point(0, 381);
            this.dgChildInfo1.Name = "dgChildInfo1";
            this.dgChildInfo1.ReadOnly = true;
            this.dgChildInfo1.RowHeadersVisible = false;
            this.dgChildInfo1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChildInfo1.Size = new System.Drawing.Size(850, 204);
            this.dgChildInfo1.TabIndex = 3;
            this.dgChildInfo1.TabStop = false;
            // 
            // DataGridViewTextBoxColumn12
            // 
            this.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn12.DataPropertyName = "SaleID";
            this.DataGridViewTextBoxColumn12.HeaderText = "Invoice #";
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // colCustomerID
            // 
            this.colCustomerID.DataPropertyName = "CustomerID";
            this.colCustomerID.HeaderText = "Customer ID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn13.DataPropertyName = "CustomerName";
            this.DataGridViewTextBoxColumn13.HeaderText = "Customer";
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn14.DataPropertyName = "STOCKDESC";
            this.DataGridViewTextBoxColumn14.HeaderText = "Description";
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn15.DataPropertyName = "UnitCost";
            this.DataGridViewTextBoxColumn15.HeaderText = "Price";
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn16
            // 
            this.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn16.DataPropertyName = "QTY";
            this.DataGridViewTextBoxColumn16.HeaderText = "Qty";
            this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            this.DataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn18
            // 
            this.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn18.DataPropertyName = "PRICE";
            this.DataGridViewTextBoxColumn18.HeaderText = "Sub Total";
            this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            this.DataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // SaleRecovery
            // 
            this.SaleRecovery.BackColor = System.Drawing.Color.White;
            this.SaleRecovery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaleRecovery.Controls.Add(this.cmdFindTab3);
            this.SaleRecovery.Controls.Add(this.Button3);
            this.SaleRecovery.Controls.Add(this.cmdViewTab3);
            this.SaleRecovery.Controls.Add(this.dtDateTab3);
            this.SaleRecovery.Controls.Add(this.Panel3);
            this.SaleRecovery.ImageIndex = 2;
            this.SaleRecovery.Location = new System.Drawing.Point(140, 4);
            this.SaleRecovery.Name = "SaleRecovery";
            this.SaleRecovery.Padding = new System.Windows.Forms.Padding(3);
            this.SaleRecovery.Size = new System.Drawing.Size(875, 640);
            this.SaleRecovery.TabIndex = 3;
            this.SaleRecovery.Text = "Sale Recovery";
            // 
            // Button3
            // 
            this.Button3.BackgroundImage = global::POS_System.My.Resources.Resources.remove4;
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Location = new System.Drawing.Point(817, 5);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(39, 26);
            this.Button3.TabIndex = 6;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.dgMasterInfo2);
            this.Panel3.Controls.Add(this.dgChildInfo2);
            this.Panel3.Location = new System.Drawing.Point(6, 36);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(850, 585);
            this.Panel3.TabIndex = 4;
            // 
            // dgMasterInfo2
            // 
            this.dgMasterInfo2.AllowUserToAddRows = false;
            this.dgMasterInfo2.AllowUserToDeleteRows = false;
            this.dgMasterInfo2.AutoGenerateColumns = false;
            this.dgMasterInfo2.BackgroundColor = System.Drawing.Color.Gray;
            this.dgMasterInfo2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgMasterInfo2.ColumnHeadersHeight = 22;
            this.dgMasterInfo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMasterInfo2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn23,
            this.DataGridViewTextBoxColumn25,
            this.DataGridViewTextBoxColumn26,
            this.DataGridViewTextBoxColumn27,
            this.colRecovery,
            this.DataGridViewTextBoxColumn24,
            this.DataGridViewTextBoxColumn29});
            this.dgMasterInfo2.DataSource = this.MasterBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMasterInfo2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgMasterInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMasterInfo2.Location = new System.Drawing.Point(0, 0);
            this.dgMasterInfo2.Name = "dgMasterInfo2";
            this.dgMasterInfo2.ReadOnly = true;
            this.dgMasterInfo2.RowHeadersVisible = false;
            this.dgMasterInfo2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMasterInfo2.Size = new System.Drawing.Size(850, 381);
            this.dgMasterInfo2.TabIndex = 2;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn5.DataPropertyName = "SaleID";
            this.DataGridViewTextBoxColumn5.HeaderText = "Invoice #";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn23
            // 
            this.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn23.DataPropertyName = "SaleType";
            this.DataGridViewTextBoxColumn23.HeaderText = "Description";
            this.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23";
            this.DataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn25
            // 
            this.DataGridViewTextBoxColumn25.DataPropertyName = "SaleTotal";
            this.DataGridViewTextBoxColumn25.HeaderText = "Total";
            this.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25";
            this.DataGridViewTextBoxColumn25.ReadOnly = true;
            this.DataGridViewTextBoxColumn25.Width = 88;
            // 
            // DataGridViewTextBoxColumn26
            // 
            this.DataGridViewTextBoxColumn26.DataPropertyName = "SalePaid";
            this.DataGridViewTextBoxColumn26.HeaderText = "Payment";
            this.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26";
            this.DataGridViewTextBoxColumn26.ReadOnly = true;
            this.DataGridViewTextBoxColumn26.Width = 87;
            // 
            // DataGridViewTextBoxColumn27
            // 
            this.DataGridViewTextBoxColumn27.DataPropertyName = "SaleDiscount";
            this.DataGridViewTextBoxColumn27.HeaderText = "Discount";
            this.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27";
            this.DataGridViewTextBoxColumn27.ReadOnly = true;
            this.DataGridViewTextBoxColumn27.Width = 85;
            // 
            // colRecovery
            // 
            this.colRecovery.DataPropertyName = "SaleRecovery";
            this.colRecovery.HeaderText = "Recovery";
            this.colRecovery.Name = "colRecovery";
            this.colRecovery.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn24
            // 
            this.DataGridViewTextBoxColumn24.DataPropertyName = "DateRecovery";
            this.DataGridViewTextBoxColumn24.HeaderText = "Date";
            this.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24";
            this.DataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn29
            // 
            this.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn29.DataPropertyName = "DrawerName";
            this.DataGridViewTextBoxColumn29.HeaderText = "User Name";
            this.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29";
            this.DataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dgChildInfo2
            // 
            this.dgChildInfo2.AllowUserToAddRows = false;
            this.dgChildInfo2.AllowUserToDeleteRows = false;
            this.dgChildInfo2.AutoGenerateColumns = false;
            this.dgChildInfo2.BackgroundColor = System.Drawing.Color.Gray;
            this.dgChildInfo2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgChildInfo2.ColumnHeadersHeight = 22;
            this.dgChildInfo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgChildInfo2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn30,
            this.DataGridViewTextBoxColumn31,
            this.DataGridViewTextBoxColumn32,
            this.DataGridViewTextBoxColumn33,
            this.DataGridViewTextBoxColumn34,
            this.DataGridViewTextBoxColumn35});
            this.dgChildInfo2.DataSource = this.DetailBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChildInfo2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgChildInfo2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgChildInfo2.Location = new System.Drawing.Point(0, 381);
            this.dgChildInfo2.Name = "dgChildInfo2";
            this.dgChildInfo2.ReadOnly = true;
            this.dgChildInfo2.RowHeadersVisible = false;
            this.dgChildInfo2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChildInfo2.Size = new System.Drawing.Size(850, 204);
            this.dgChildInfo2.TabIndex = 3;
            this.dgChildInfo2.TabStop = false;
            // 
            // DataGridViewTextBoxColumn30
            // 
            this.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn30.DataPropertyName = "SaleID";
            this.DataGridViewTextBoxColumn30.HeaderText = "Invoice #";
            this.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30";
            this.DataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn31
            // 
            this.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn31.DataPropertyName = "CustomerName";
            this.DataGridViewTextBoxColumn31.HeaderText = "Customer";
            this.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31";
            this.DataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn32
            // 
            this.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn32.DataPropertyName = "STOCKDESC";
            this.DataGridViewTextBoxColumn32.HeaderText = "Description";
            this.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32";
            this.DataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn33
            // 
            this.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn33.DataPropertyName = "UnitCost";
            this.DataGridViewTextBoxColumn33.HeaderText = "Price";
            this.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33";
            this.DataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn34
            // 
            this.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn34.DataPropertyName = "QTY";
            this.DataGridViewTextBoxColumn34.HeaderText = "Qty";
            this.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34";
            this.DataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn35
            // 
            this.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn35.DataPropertyName = "PRICE";
            this.DataGridViewTextBoxColumn35.HeaderText = "Sub Total";
            this.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35";
            this.DataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // ReturnSale
            // 
            this.ReturnSale.BackColor = System.Drawing.Color.White;
            this.ReturnSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReturnSale.Controls.Add(this.cmdFindTab4);
            this.ReturnSale.Controls.Add(this.Button4);
            this.ReturnSale.Controls.Add(this.cmdViewTab4);
            this.ReturnSale.Controls.Add(this.dtDateTab4);
            this.ReturnSale.Controls.Add(this.Panel4);
            this.ReturnSale.ImageIndex = 4;
            this.ReturnSale.Location = new System.Drawing.Point(140, 4);
            this.ReturnSale.Name = "ReturnSale";
            this.ReturnSale.Padding = new System.Windows.Forms.Padding(3);
            this.ReturnSale.Size = new System.Drawing.Size(875, 640);
            this.ReturnSale.TabIndex = 4;
            this.ReturnSale.Text = "Sales Return";
            // 
            // Button4
            // 
            this.Button4.BackgroundImage = global::POS_System.My.Resources.Resources.remove4;
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button4.Location = new System.Drawing.Point(817, 5);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(39, 26);
            this.Button4.TabIndex = 6;
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.dgMasterInfo3);
            this.Panel4.Controls.Add(this.dgChildInfo3);
            this.Panel4.Location = new System.Drawing.Point(6, 36);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(850, 585);
            this.Panel4.TabIndex = 4;
            // 
            // dgMasterInfo3
            // 
            this.dgMasterInfo3.AllowUserToAddRows = false;
            this.dgMasterInfo3.AllowUserToDeleteRows = false;
            this.dgMasterInfo3.AutoGenerateColumns = false;
            this.dgMasterInfo3.BackgroundColor = System.Drawing.Color.Gray;
            this.dgMasterInfo3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgMasterInfo3.ColumnHeadersHeight = 22;
            this.dgMasterInfo3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMasterInfo3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn36,
            this.DataGridViewTextBoxColumn37,
            this.DataGridViewTextBoxColumn38,
            this.DataGridViewTextBoxColumn39,
            this.DataGridViewTextBoxColumn40,
            this.DataGridViewTextBoxColumn41,
            this.colReturn,
            this.DataGridViewTextBoxColumn43});
            this.dgMasterInfo3.DataSource = this.MasterBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMasterInfo3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgMasterInfo3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMasterInfo3.Location = new System.Drawing.Point(0, 0);
            this.dgMasterInfo3.Name = "dgMasterInfo3";
            this.dgMasterInfo3.ReadOnly = true;
            this.dgMasterInfo3.RowHeadersVisible = false;
            this.dgMasterInfo3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMasterInfo3.Size = new System.Drawing.Size(850, 381);
            this.dgMasterInfo3.TabIndex = 2;
            // 
            // DataGridViewTextBoxColumn36
            // 
            this.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn36.DataPropertyName = "SaleID";
            this.DataGridViewTextBoxColumn36.HeaderText = "Invoice #";
            this.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36";
            this.DataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn37
            // 
            this.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn37.DataPropertyName = "SaleType";
            this.DataGridViewTextBoxColumn37.HeaderText = "Description";
            this.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37";
            this.DataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn38
            // 
            this.DataGridViewTextBoxColumn38.DataPropertyName = "DateCompleted";
            this.DataGridViewTextBoxColumn38.HeaderText = "Date";
            this.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38";
            this.DataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn39
            // 
            this.DataGridViewTextBoxColumn39.DataPropertyName = "SaleTotal";
            this.DataGridViewTextBoxColumn39.HeaderText = "Total";
            this.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39";
            this.DataGridViewTextBoxColumn39.ReadOnly = true;
            this.DataGridViewTextBoxColumn39.Width = 88;
            // 
            // DataGridViewTextBoxColumn40
            // 
            this.DataGridViewTextBoxColumn40.DataPropertyName = "SalePaid";
            this.DataGridViewTextBoxColumn40.HeaderText = "Payment";
            this.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40";
            this.DataGridViewTextBoxColumn40.ReadOnly = true;
            this.DataGridViewTextBoxColumn40.Width = 87;
            // 
            // DataGridViewTextBoxColumn41
            // 
            this.DataGridViewTextBoxColumn41.DataPropertyName = "SaleDiscount";
            this.DataGridViewTextBoxColumn41.HeaderText = "Discount";
            this.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41";
            this.DataGridViewTextBoxColumn41.ReadOnly = true;
            this.DataGridViewTextBoxColumn41.Width = 85;
            // 
            // colReturn
            // 
            this.colReturn.DataPropertyName = "SaleReturn";
            this.colReturn.HeaderText = "Sale Return";
            this.colReturn.Name = "colReturn";
            this.colReturn.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn43
            // 
            this.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn43.DataPropertyName = "DrawerName";
            this.DataGridViewTextBoxColumn43.HeaderText = "User Name";
            this.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43";
            this.DataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dgChildInfo3
            // 
            this.dgChildInfo3.AllowUserToAddRows = false;
            this.dgChildInfo3.AllowUserToDeleteRows = false;
            this.dgChildInfo3.AutoGenerateColumns = false;
            this.dgChildInfo3.BackgroundColor = System.Drawing.Color.Gray;
            this.dgChildInfo3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgChildInfo3.ColumnHeadersHeight = 22;
            this.dgChildInfo3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgChildInfo3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn44,
            this.DataGridViewTextBoxColumn45,
            this.DataGridViewTextBoxColumn46,
            this.DataGridViewTextBoxColumn47,
            this.DataGridViewTextBoxColumn48,
            this.DataGridViewTextBoxColumn49});
            this.dgChildInfo3.DataSource = this.DetailBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChildInfo3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgChildInfo3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgChildInfo3.Location = new System.Drawing.Point(0, 381);
            this.dgChildInfo3.Name = "dgChildInfo3";
            this.dgChildInfo3.ReadOnly = true;
            this.dgChildInfo3.RowHeadersVisible = false;
            this.dgChildInfo3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChildInfo3.Size = new System.Drawing.Size(850, 204);
            this.dgChildInfo3.TabIndex = 3;
            this.dgChildInfo3.TabStop = false;
            // 
            // DataGridViewTextBoxColumn44
            // 
            this.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn44.DataPropertyName = "SaleID";
            this.DataGridViewTextBoxColumn44.HeaderText = "Invoice #";
            this.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44";
            this.DataGridViewTextBoxColumn44.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn45
            // 
            this.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn45.DataPropertyName = "CustomerName";
            this.DataGridViewTextBoxColumn45.HeaderText = "Customer";
            this.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45";
            this.DataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn46
            // 
            this.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn46.DataPropertyName = "STOCKDESC";
            this.DataGridViewTextBoxColumn46.HeaderText = "Description";
            this.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46";
            this.DataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn47
            // 
            this.DataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn47.DataPropertyName = "UnitCost";
            this.DataGridViewTextBoxColumn47.HeaderText = "Price";
            this.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47";
            this.DataGridViewTextBoxColumn47.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn48
            // 
            this.DataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn48.DataPropertyName = "QTY";
            this.DataGridViewTextBoxColumn48.HeaderText = "Qty";
            this.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48";
            this.DataGridViewTextBoxColumn48.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn49
            // 
            this.DataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn49.DataPropertyName = "PRICE";
            this.DataGridViewTextBoxColumn49.HeaderText = "Sub Total";
            this.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49";
            this.DataGridViewTextBoxColumn49.ReadOnly = true;
            // 
            // TabReport
            // 
            this.TabReport.BackColor = System.Drawing.Color.White;
            this.TabReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabReport.Controls.Add(this.cmdClose);
            this.TabReport.Controls.Add(this.GroupBox1);
            this.TabReport.Controls.Add(this.cmdPreview);
            this.TabReport.Controls.Add(this.gbSelectReport);
            this.TabReport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabReport.ImageIndex = 3;
            this.TabReport.Location = new System.Drawing.Point(140, 4);
            this.TabReport.Name = "TabReport";
            this.TabReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabReport.Size = new System.Drawing.Size(875, 640);
            this.TabReport.TabIndex = 5;
            this.TabReport.Text = "Daily Reports";
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Image = global::POS_System.My.Resources.Resources.remove5;
            this.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClose.Location = new System.Drawing.Point(657, 348);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(92, 28);
            this.cmdClose.TabIndex = 8;
            this.cmdClose.Text = "Close";
            this.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.dtToDate);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.dtFromDate);
            this.GroupBox1.Location = new System.Drawing.Point(123, 216);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(626, 94);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select Date Range";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(327, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(25, 19);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "To";
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Location = new System.Drawing.Point(355, 44);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(246, 23);
            this.dtToDate.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(23, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 19);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "From";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFromDate.Location = new System.Drawing.Point(73, 44);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(246, 23);
            this.dtFromDate.TabIndex = 6;
            // 
            // cmdPreview
            // 
            this.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPreview.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPreview.Image = global::POS_System.My.Resources.Resources.PrintHS;
            this.cmdPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPreview.Location = new System.Drawing.Point(559, 348);
            this.cmdPreview.Name = "cmdPreview";
            this.cmdPreview.Size = new System.Drawing.Size(92, 28);
            this.cmdPreview.TabIndex = 6;
            this.cmdPreview.Text = "Preview";
            this.cmdPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPreview.UseVisualStyleBackColor = true;
            this.cmdPreview.Click += new System.EventHandler(this.cmdPreview_Click);
            // 
            // gbSelectReport
            // 
            this.gbSelectReport.BackColor = System.Drawing.Color.White;
            this.gbSelectReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbSelectReport.Controls.Add(this.rdReturn);
            this.gbSelectReport.Controls.Add(this.rdRecovery);
            this.gbSelectReport.Controls.Add(this.rdCredit);
            this.gbSelectReport.Controls.Add(this.rdDaily);
            this.gbSelectReport.Location = new System.Drawing.Point(123, 75);
            this.gbSelectReport.Name = "gbSelectReport";
            this.gbSelectReport.Size = new System.Drawing.Size(626, 135);
            this.gbSelectReport.TabIndex = 0;
            this.gbSelectReport.TabStop = false;
            this.gbSelectReport.Text = "Select Report";
            // 
            // rdReturn
            // 
            this.rdReturn.AutoSize = true;
            this.rdReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReturn.Location = new System.Drawing.Point(394, 84);
            this.rdReturn.Name = "rdReturn";
            this.rdReturn.Size = new System.Drawing.Size(109, 23);
            this.rdReturn.TabIndex = 4;
            this.rdReturn.TabStop = true;
            this.rdReturn.Text = "Cash Return";
            this.rdReturn.UseVisualStyleBackColor = true;
            // 
            // rdRecovery
            // 
            this.rdRecovery.AutoSize = true;
            this.rdRecovery.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRecovery.Location = new System.Drawing.Point(88, 84);
            this.rdRecovery.Name = "rdRecovery";
            this.rdRecovery.Size = new System.Drawing.Size(125, 23);
            this.rdRecovery.TabIndex = 3;
            this.rdRecovery.TabStop = true;
            this.rdRecovery.Text = "Cash Recovery";
            this.rdRecovery.UseVisualStyleBackColor = true;
            // 
            // rdCredit
            // 
            this.rdCredit.AutoSize = true;
            this.rdCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCredit.Location = new System.Drawing.Point(394, 40);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(120, 23);
            this.rdCredit.TabIndex = 2;
            this.rdCredit.TabStop = true;
            this.rdCredit.Text = "Cash Credited";
            this.rdCredit.UseVisualStyleBackColor = true;
            // 
            // rdDaily
            // 
            this.rdDaily.AutoSize = true;
            this.rdDaily.Checked = true;
            this.rdDaily.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDaily.Location = new System.Drawing.Point(88, 40);
            this.rdDaily.Name = "rdDaily";
            this.rdDaily.Size = new System.Drawing.Size(129, 23);
            this.rdDaily.TabIndex = 1;
            this.rdDaily.TabStop = true;
            this.rdDaily.Text = "Cash Collection";
            this.rdDaily.UseVisualStyleBackColor = true;
            // 
            // TabViewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 648);
            this.Controls.Add(this.DotNetBarTabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TabViewSale";
            this.Text = "View Sale";
            this.Load += new System.EventHandler(this.frmTabViewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterBindingSource)).EndInit();
            this.DotNetBarTabcontrol.ResumeLayout(false);
            this.CashSale.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo)).EndInit();
            this.CreditSale.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo1)).EndInit();
            this.SaleRecovery.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo2)).EndInit();
            this.ReturnSale.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMasterInfo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo3)).EndInit();
            this.TabReport.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.gbSelectReport.ResumeLayout(false);
            this.gbSelectReport.PerformLayout();
            this.ResumeLayout(false);

        }
        internal DotNetBarTabcontrol DotNetBarTabcontrol;
        internal TabPage CashSale;
        internal TabPage CreditSale;
        internal Panel Panel1;
        internal DataGridView dgMasterInfo;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn colCustID;
        internal DataGridViewTextBoxColumn colDate;
        internal DataGridViewTextBoxColumn colTotal;
        internal DataGridViewTextBoxColumn colPaid;
        internal DataGridViewTextBoxColumn colDiscount;
        internal DataGridViewTextBoxColumn colUser;
        internal DataGridView dgChildInfo;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn21;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn22;
        internal DateTimePicker dtDateTab1;
        internal Button cmdViewTab1;
        internal Button cmdViewTab2;
        internal DateTimePicker dtDateTab2;
        internal Panel Panel2;
        internal DataGridView dgMasterInfo1;
        internal DataGridView dgChildInfo1;
        internal TabPage SaleRecovery;
        internal ImageList ImageList1;
        internal BindingSource DetailBindingSource;
        internal DataSet RecordDataSet;
        internal BindingSource MasterBindingSource;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        internal DataGridViewTextBoxColumn colCredit;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        internal Button Button1;
        internal Button Button2;
        internal TabPage ReturnSale;
        internal Button Button3;
        internal Button cmdViewTab3;
        internal DateTimePicker dtDateTab3;
        internal Panel Panel3;
        internal DataGridView dgMasterInfo2;
        internal DataGridView dgChildInfo2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn30;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn31;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn32;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn33;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn34;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn35;
        internal Button Button4;
        internal Button cmdViewTab4;
        internal DateTimePicker dtDateTab4;
        internal Panel Panel4;
        internal DataGridView dgMasterInfo3;
        internal DataGridView dgChildInfo3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn44;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn45;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn46;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn47;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn48;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn49;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn36;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn37;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn38;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn39;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn40;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn41;
        internal DataGridViewTextBoxColumn colReturn;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn43;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn23;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn25;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn26;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn27;
        internal DataGridViewTextBoxColumn colRecovery;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn24;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn29;
        internal Button cmdFindTab1;
        internal ToolTip MyToolTip;
        internal Button cmdFindTab2;
        internal Button cmdFindTab3;
        internal Button cmdFindTab4;
        internal Button cmdPayment;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        internal DataGridViewTextBoxColumn colCustomerID;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
        internal TabPage TabReport;
        internal GroupBox gbSelectReport;
        internal RadioButton rdDaily;
        internal RadioButton rdReturn;
        internal RadioButton rdRecovery;
        internal RadioButton rdCredit;
        internal Button cmdPreview;
        internal GroupBox GroupBox1;
        internal DateTimePicker dtFromDate;
        internal Label Label2;
        internal DateTimePicker dtToDate;
        internal Label Label1;
        internal Button cmdClose;
    }
}