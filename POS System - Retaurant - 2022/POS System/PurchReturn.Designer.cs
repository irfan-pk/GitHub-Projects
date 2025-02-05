using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PurchReturn : Form
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
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchReturn));
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            var DataGridViewCellStyle15 = new DataGridViewCellStyle();
            var DataGridViewCellStyle16 = new DataGridViewCellStyle();
            Label1 = new Label();
            ProductDataGridView = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            colPrchDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            ProductBindingSource = new BindingSource(components);
            ProductDataSet = new DataSet();
            DataTable2 = new DataTable();
            cmdMin = new Button();
            cmdMin.Click += new EventHandler(cmdMin_Click);
            ToolTip1 = new ToolTip(components);
            BindingNavigatorSave = new ToolStripButton();
            BindingNavigatorSave.Click += new EventHandler(BindingNavigatorSave_Click);
            BindingNavigatorRefreshItem = new ToolStripButton();
            BindingNavigatorRefreshItem.Click += new EventHandler(BindingNavigatorRefreshItem_Click);
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            PurchaseDataGridView = new DataGridView();
            colTranID = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colProdID = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colSupplier = new DataGridViewTextBoxColumn();
            colPck = new DataGridViewTextBoxColumn();
            colPPrice = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colPrvStock = new DataGridViewTextBoxColumn();
            colSch1 = new DataGridViewTextBoxColumn();
            colPSch1 = new DataGridViewTextBoxColumn();
            colSch2 = new DataGridViewTextBoxColumn();
            colPSch2 = new DataGridViewTextBoxColumn();
            colSch3 = new DataGridViewTextBoxColumn();
            colPSch3 = new DataGridViewTextBoxColumn();
            colRmks = new DataGridViewTextBoxColumn();
            PurchaseBindingSource = new BindingSource(components);
            PurchaseDataSet = new DataSet();
            DataTable1 = new DataTable();
            SplitContainer2 = new SplitContainer();
            cmbCompany = new ComboBox();
            cmbCompany.GotFocus += new EventHandler(cmbCompany_GotFocus);
            cmbCompany.LostFocus += new EventHandler(cmbCompany_LostFocus);
            Label20 = new Label();
            PurchaseBindingNavigator = new BindingNavigator(components);
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            BindingNavigatorSeparator4 = new ToolStripSeparator();
            BindingNavigatorSeparator6 = new ToolStripSeparator();
            BindingNavigatorSaveItem = new ToolStripButton();
            BindingNavigatorSaveItem.Click += new EventHandler(BindingNavigatorSaveItem_Click);
            Label21 = new Label();
            SplitContainer1 = new SplitContainer();
            txtSQty3 = new TextBox();
            txtSQty3.GotFocus += new EventHandler(txtSQty3_GotFocus);
            txtSQty3.KeyPress += new KeyPressEventHandler(txtSQty3_KeyPress);
            txtSQty3.LostFocus += new EventHandler(txtSQty3_LostFocus);
            txtSQty3.TextChanged += new EventHandler(txtSQty3_TextChanged);
            Label13 = new Label();
            txtSch3 = new TextBox();
            Label14 = new Label();
            txtSQty2 = new TextBox();
            txtSQty2.GotFocus += new EventHandler(txtSQty2_GotFocus);
            txtSQty2.KeyDown += new KeyEventHandler(txtSQty2_KeyDown);
            txtSQty2.KeyPress += new KeyPressEventHandler(txtSQty2_KeyPress);
            txtSQty2.LostFocus += new EventHandler(txtSQty2_LostFocus);
            txtSQty2.TextChanged += new EventHandler(txtSQty2_TextChanged);
            Label11 = new Label();
            txtSch2 = new TextBox();
            Label12 = new Label();
            txtSQty1 = new TextBox();
            txtSQty1.GotFocus += new EventHandler(txtSQty1_GotFocus);
            txtSQty1.KeyDown += new KeyEventHandler(txtSQty1_KeyDown);
            txtSQty1.KeyPress += new KeyPressEventHandler(txtSQty1_KeyPress);
            txtSQty1.LostFocus += new EventHandler(txtSQty1_LostFocus);
            txtSQty1.TextChanged += new EventHandler(txtSQty1_TextChanged);
            Label9 = new Label();
            txtSch1 = new TextBox();
            Label10 = new Label();
            txtQty = new TextBox();
            txtQty.GotFocus += new EventHandler(txtQty_GotFocus);
            txtQty.KeyDown += new KeyEventHandler(txtQty_KeyDown);
            txtQty.KeyPress += new KeyPressEventHandler(txtQty_KeyPress);
            txtQty.LostFocus += new EventHandler(txtQty_LostFocus);
            txtQty.TextChanged += new EventHandler(txtQty_TextChanged);
            Label8 = new Label();
            txtPPrice = new TextBox();
            Label6 = new Label();
            txtDesc = new TextBox();
            txtDesc.GotFocus += new EventHandler(txtDesc_GotFocus);
            txtDesc.LostFocus += new EventHandler(txtDesc_LostFocus);
            Label3 = new Label();
            txtCode = new TextBox();
            txtCode.GotFocus += new EventHandler(txtCode_GotFocus);
            txtCode.KeyDown += new KeyEventHandler(txtCode_KeyDown);
            txtCode.KeyUp += new KeyEventHandler(txtCode_KeyUp);
            txtCode.LostFocus += new EventHandler(txtCode_LostFocus);
            Label2 = new Label();
            txtDate = new DateTimePicker();
            txtDate.KeyDown += new KeyEventHandler(txtDate_KeyDown);
            LineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataTable2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataTable1).BeginInit();
            SplitContainer2.Panel1.SuspendLayout();
            SplitContainer2.Panel2.SuspendLayout();
            SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PurchaseBindingNavigator).BeginInit();
            PurchaseBindingNavigator.SuspendLayout();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Red;
            Label1.Location = new Point(6, 4);
            Label1.Name = "Label1";
            Label1.Size = new Size(248, 31);
            Label1.TabIndex = 15;
            Label1.Text = "Purchases Return";
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.AllowUserToOrderColumns = true;
            ProductDataGridView.AllowUserToResizeColumns = false;
            ProductDataGridView.AllowUserToResizeRows = false;
            ProductDataGridView.AutoGenerateColumns = false;
            ProductDataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            ProductDataGridView.BorderStyle = BorderStyle.None;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle9.BackColor = SystemColors.Control;
            DataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn5, colPrchDate, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8, DataGridViewTextBoxColumn10, DataGridViewTextBoxColumn11, DataGridViewTextBoxColumn12, DataGridViewTextBoxColumn13, DataGridViewTextBoxColumn14, DataGridViewTextBoxColumn15, DataGridViewTextBoxColumn16, DataGridViewTextBoxColumn17, DataGridViewTextBoxColumn18, DataGridViewTextBoxColumn19, DataGridViewTextBoxColumn20, DataGridViewTextBoxColumn21, DataGridViewTextBoxColumn22 });
            ProductDataGridView.DataSource = ProductBindingSource;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle10.BackColor = SystemColors.Window;
            DataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            ProductDataGridView.DefaultCellStyle = DataGridViewCellStyle10;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.GridColor = Color.Gray;
            ProductDataGridView.Location = new Point(0, 0);
            ProductDataGridView.MultiSelect = false;
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = SystemColors.Control;
            DataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle11;
            ProductDataGridView.RowHeadersVisible = false;
            DataGridViewCellStyle12.BackColor = Color.FromArgb(64, 64, 64);
            DataGridViewCellStyle12.ForeColor = Color.White;
            DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(192, 0, 0);
            ProductDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle12;
            ProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductDataGridView.Size = new Size(974, 201);
            ProductDataGridView.TabIndex = 20;
            ProductDataGridView.TabStop = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "PROD_CD";
            DataGridViewTextBoxColumn1.HeaderText = "Product Code";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "PROD_DESC";
            DataGridViewTextBoxColumn2.HeaderText = "Description";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "PROD_CATG";
            DataGridViewTextBoxColumn3.HeaderText = "Category";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "PROD_UPD_ON";
            DataGridViewTextBoxColumn5.HeaderText = "Update On";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // colPrchDate
            // 
            colPrchDate.DataPropertyName = "PROD_DATE";
            colPrchDate.HeaderText = "Purchase On";
            colPrchDate.Name = "colPrchDate";
            colPrchDate.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.DataPropertyName = "PROD_PACK";
            DataGridViewTextBoxColumn6.HeaderText = "Packing";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.DataPropertyName = "PROD_PPRICE";
            DataGridViewTextBoxColumn7.HeaderText = "P. Price";
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.DataPropertyName = "PROD_ONHAND";
            DataGridViewTextBoxColumn8.HeaderText = "Stock";
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            DataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn10
            // 
            DataGridViewTextBoxColumn10.DataPropertyName = "PROD_BAL_MIN";
            DataGridViewTextBoxColumn10.HeaderText = "Min Bal.";
            DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            DataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn11
            // 
            DataGridViewTextBoxColumn11.DataPropertyName = "PROD_SCH1_PRICE";
            DataGridViewTextBoxColumn11.HeaderText = "Scheme 1";
            DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            DataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn12
            // 
            DataGridViewTextBoxColumn12.DataPropertyName = "PROD_SCH1_ONHAND";
            DataGridViewTextBoxColumn12.HeaderText = "Sch1 Qty";
            DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            DataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn13
            // 
            DataGridViewTextBoxColumn13.DataPropertyName = "PROD_SCH2_PRICE";
            DataGridViewTextBoxColumn13.HeaderText = "Scheme 2";
            DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            DataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn14
            // 
            DataGridViewTextBoxColumn14.DataPropertyName = "PROD_SCH2_ONHAND";
            DataGridViewTextBoxColumn14.HeaderText = "Sch2 Qty";
            DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            DataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn15
            // 
            DataGridViewTextBoxColumn15.DataPropertyName = "PROD_SCH3_PRICE";
            DataGridViewTextBoxColumn15.HeaderText = "Scheme 3";
            DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            DataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn16
            // 
            DataGridViewTextBoxColumn16.DataPropertyName = "PROD_SCH3_ONHAND";
            DataGridViewTextBoxColumn16.HeaderText = "Sch3 Qty";
            DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            DataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn17
            // 
            DataGridViewTextBoxColumn17.DataPropertyName = "PROD_VAT";
            DataGridViewTextBoxColumn17.HeaderText = "V.A.T";
            DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            DataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn18
            // 
            DataGridViewTextBoxColumn18.DataPropertyName = "PROD_ITAX";
            DataGridViewTextBoxColumn18.HeaderText = "I.Tax";
            DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            DataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn19
            // 
            DataGridViewTextBoxColumn19.DataPropertyName = "PROD_EX_DUTY";
            DataGridViewTextBoxColumn19.HeaderText = "Excise Duty";
            DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            DataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn20
            // 
            DataGridViewTextBoxColumn20.DataPropertyName = "PROD_DISC_MRG";
            DataGridViewTextBoxColumn20.HeaderText = "Discount";
            DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
            DataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn21
            // 
            DataGridViewTextBoxColumn21.DataPropertyName = "PROD_PROFIT";
            DataGridViewTextBoxColumn21.HeaderText = "Profit Margin";
            DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
            DataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn22
            // 
            DataGridViewTextBoxColumn22.DataPropertyName = "PROD_SPRICE";
            DataGridViewTextBoxColumn22.HeaderText = "Sale Price";
            DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
            DataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // ProductBindingSource
            // 
            ProductBindingSource.DataSource = ProductDataSet;
            ProductBindingSource.Position = 0;
            // 
            // ProductDataSet
            // 
            ProductDataSet.DataSetName = "ProductDataSet";
            ProductDataSet.Tables.AddRange(new DataTable[] { DataTable2 });
            // 
            // DataTable2
            // 
            DataTable2.TableName = "PRODUCTS";
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
            cmdMin.Location = new Point(915, 5);
            cmdMin.Name = "cmdMin";
            cmdMin.Size = new Size(29, 34);
            cmdMin.TabIndex = 16;
            cmdMin.TabStop = false;
            cmdMin.Text = "----";
            cmdMin.UseVisualStyleBackColor = false;
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
            // BindingNavigatorSave
            // 
            BindingNavigatorSave.Enabled = false;
            BindingNavigatorSave.Image = (Image)resources.GetObject("BindingNavigatorSave.Image");
            BindingNavigatorSave.ImageTransparentColor = Color.Magenta;
            BindingNavigatorSave.Name = "BindingNavigatorSave";
            BindingNavigatorSave.Size = new Size(81, 22);
            BindingNavigatorSave.Text = "&Save Entry";
            BindingNavigatorSave.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorSave.ToolTipText = "Save Current Changes";
            // 
            // BindingNavigatorRefreshItem
            // 
            BindingNavigatorRefreshItem.Image = (Image)resources.GetObject("BindingNavigatorRefreshItem.Image");
            BindingNavigatorRefreshItem.Name = "BindingNavigatorRefreshItem";
            BindingNavigatorRefreshItem.Size = new Size(66, 22);
            BindingNavigatorRefreshItem.Text = "&Refresh";
            BindingNavigatorRefreshItem.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorRefreshItem.ToolTipText = "Refresh Data";
            // 
            // BindingNavigatorMoveNextItem
            // 
            BindingNavigatorMoveNextItem.BackColor = Color.FromArgb(64, 64, 64);
            BindingNavigatorMoveNextItem.Image = (Image)resources.GetObject("BindingNavigatorMoveNextItem.Image");
            BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMoveNextItem.Size = new Size(51, 22);
            BindingNavigatorMoveNextItem.Text = "&Next";
            BindingNavigatorMoveNextItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // BindingNavigatorMovePreviousItem
            // 
            BindingNavigatorMovePreviousItem.BackColor = Color.FromArgb(64, 64, 64);
            BindingNavigatorMovePreviousItem.Image = (Image)resources.GetObject("BindingNavigatorMovePreviousItem.Image");
            BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMovePreviousItem.Size = new Size(50, 22);
            BindingNavigatorMovePreviousItem.Text = "&Prev";
            BindingNavigatorMovePreviousItem.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorMovePreviousItem.ToolTipText = "Move Previous";
            // 
            // cmdClose
            // 
            cmdClose.BackColor = Color.FromArgb(64, 64, 64);
            cmdClose.BackgroundImageLayout = ImageLayout.Center;
            cmdClose.DialogResult = DialogResult.Cancel;
            cmdClose.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            cmdClose.FlatAppearance.MouseOverBackColor = Color.Gray;
            cmdClose.FlatStyle = FlatStyle.Flat;
            cmdClose.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdClose.ForeColor = Color.FromArgb(224, 224, 224);
            cmdClose.Location = new Point(946, 5);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(31, 34);
            cmdClose.TabIndex = 14;
            cmdClose.TabStop = false;
            cmdClose.Text = "X";
            cmdClose.TextAlign = ContentAlignment.MiddleLeft;
            cmdClose.UseVisualStyleBackColor = false;
            // 
            // PurchaseDataGridView
            // 
            PurchaseDataGridView.AllowUserToAddRows = false;
            PurchaseDataGridView.AllowUserToDeleteRows = false;
            PurchaseDataGridView.AllowUserToOrderColumns = true;
            PurchaseDataGridView.AllowUserToResizeColumns = false;
            PurchaseDataGridView.AllowUserToResizeRows = false;
            PurchaseDataGridView.AutoGenerateColumns = false;
            PurchaseDataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            PurchaseDataGridView.BorderStyle = BorderStyle.None;
            DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle13.BackColor = SystemColors.Control;
            DataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            PurchaseDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13;
            PurchaseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PurchaseDataGridView.Columns.AddRange(new DataGridViewColumn[] { colTranID, colDate, colProdID, colDesc, colSupplier, colPck, colPPrice, colQty, colPrvStock, colSch1, colPSch1, colSch2, colPSch2, colSch3, colPSch3, colRmks });
            PurchaseDataGridView.DataSource = PurchaseBindingSource;
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle14.BackColor = SystemColors.Window;
            DataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            PurchaseDataGridView.DefaultCellStyle = DataGridViewCellStyle14;
            PurchaseDataGridView.Dock = DockStyle.Fill;
            PurchaseDataGridView.GridColor = Color.Gray;
            PurchaseDataGridView.Location = new Point(0, 0);
            PurchaseDataGridView.MultiSelect = false;
            PurchaseDataGridView.Name = "PurchaseDataGridView";
            PurchaseDataGridView.ReadOnly = true;
            DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle15.BackColor = SystemColors.Control;
            DataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            PurchaseDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15;
            PurchaseDataGridView.RowHeadersVisible = false;
            DataGridViewCellStyle16.BackColor = Color.FromArgb(64, 64, 64);
            DataGridViewCellStyle16.ForeColor = Color.White;
            DataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(192, 0, 0);
            PurchaseDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle16;
            PurchaseDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PurchaseDataGridView.Size = new Size(974, 199);
            PurchaseDataGridView.TabIndex = 19;
            // 
            // colTranID
            // 
            colTranID.DataPropertyName = "PRCH_TR_ID";
            colTranID.HeaderText = "Tran #";
            colTranID.Name = "colTranID";
            colTranID.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "PRCH_DATE";
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colProdID
            // 
            colProdID.DataPropertyName = "PRCH_CD";
            colProdID.HeaderText = "Product Code";
            colProdID.Name = "colProdID";
            colProdID.ReadOnly = true;
            // 
            // colDesc
            // 
            colDesc.DataPropertyName = "PRCH_DESC";
            colDesc.HeaderText = "Description";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colSupplier
            // 
            colSupplier.DataPropertyName = "PRCH_SUPPLIER";
            colSupplier.HeaderText = "Supplier";
            colSupplier.Name = "colSupplier";
            colSupplier.ReadOnly = true;
            // 
            // colPck
            // 
            colPck.DataPropertyName = "PRCH_PACK";
            colPck.HeaderText = "Packing";
            colPck.Name = "colPck";
            colPck.ReadOnly = true;
            // 
            // colPPrice
            // 
            colPPrice.DataPropertyName = "PRCH_PRICE";
            colPPrice.HeaderText = "P. Price";
            colPPrice.Name = "colPPrice";
            colPPrice.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.DataPropertyName = "PRCH_QTY";
            colQty.HeaderText = "Stock";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colPrvStock
            // 
            colPrvStock.DataPropertyName = "PRCH_OLD_QTY";
            colPrvStock.HeaderText = "Prev. Stock";
            colPrvStock.Name = "colPrvStock";
            colPrvStock.ReadOnly = true;
            // 
            // colSch1
            // 
            colSch1.DataPropertyName = "PRCH_SCH1_PRICE";
            colSch1.HeaderText = "Scheme 1";
            colSch1.Name = "colSch1";
            colSch1.ReadOnly = true;
            // 
            // colPSch1
            // 
            colPSch1.DataPropertyName = "PRCH_SCH1_ONHAND";
            colPSch1.HeaderText = "Sch1 Qty";
            colPSch1.Name = "colPSch1";
            colPSch1.ReadOnly = true;
            // 
            // colSch2
            // 
            colSch2.DataPropertyName = "PRCH_SCH2_PRICE";
            colSch2.HeaderText = "Scheme 2";
            colSch2.Name = "colSch2";
            colSch2.ReadOnly = true;
            // 
            // colPSch2
            // 
            colPSch2.DataPropertyName = "PRCH_SCH2_ONHAND";
            colPSch2.HeaderText = "Sch2 Qty";
            colPSch2.Name = "colPSch2";
            colPSch2.ReadOnly = true;
            // 
            // colSch3
            // 
            colSch3.DataPropertyName = "PRCH_SCH3_PRICE";
            colSch3.HeaderText = "Scheme 3";
            colSch3.Name = "colSch3";
            colSch3.ReadOnly = true;
            // 
            // colPSch3
            // 
            colPSch3.DataPropertyName = "PRCH_SCH3_ONHAND";
            colPSch3.HeaderText = "Sch3 Qty";
            colPSch3.Name = "colPSch3";
            colPSch3.ReadOnly = true;
            // 
            // colRmks
            // 
            colRmks.DataPropertyName = "PRCH_STATUS";
            colRmks.HeaderText = "REMARKS";
            colRmks.Name = "colRmks";
            colRmks.ReadOnly = true;
            // 
            // PurchaseBindingSource
            // 
            PurchaseBindingSource.DataSource = PurchaseDataSet;
            PurchaseBindingSource.Position = 0;
            // 
            // PurchaseDataSet
            // 
            PurchaseDataSet.DataSetName = "PurchaseDataSet";
            PurchaseDataSet.Tables.AddRange(new DataTable[] { DataTable1 });
            // 
            // DataTable1
            // 
            DataTable1.TableName = "PURCHASE";
            // 
            // SplitContainer2
            // 
            SplitContainer2.Dock = DockStyle.Fill;
            SplitContainer2.Location = new Point(0, 0);
            SplitContainer2.Name = "SplitContainer2";
            SplitContainer2.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer2.Panel1
            // 
            SplitContainer2.Panel1.Controls.Add(PurchaseDataGridView);
            // 
            // SplitContainer2.Panel2
            // 
            SplitContainer2.Panel2.Controls.Add(ProductDataGridView);
            SplitContainer2.Size = new Size(974, 404);
            SplitContainer2.SplitterDistance = 199;
            SplitContainer2.TabIndex = 0;
            // 
            // cmbCompany
            // 
            cmbCompany.AutoCompleteSource = AutoCompleteSource.HistoryList;
            cmbCompany.BackColor = Color.SteelBlue;
            cmbCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompany.FlatStyle = FlatStyle.Flat;
            cmbCompany.ForeColor = Color.White;
            cmbCompany.FormattingEnabled = true;
            cmbCompany.Location = new Point(411, 15);
            cmbCompany.Name = "cmbCompany";
            cmbCompany.Size = new Size(527, 21);
            cmbCompany.Sorted = true;
            cmbCompany.TabIndex = 1;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label20.ForeColor = Color.Yellow;
            Label20.Location = new Point(12, 16);
            Label20.Name = "Label20";
            Label20.Size = new Size(79, 16);
            Label20.TabIndex = 47;
            Label20.Text = "Return Date";
            // 
            // PurchaseBindingNavigator
            // 
            PurchaseBindingNavigator.AddNewItem = null;
            PurchaseBindingNavigator.BindingSource = PurchaseBindingSource;
            PurchaseBindingNavigator.CountItem = null;
            PurchaseBindingNavigator.DeleteItem = null;
            PurchaseBindingNavigator.Dock = DockStyle.None;
            PurchaseBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorMoveNextItem, BindingNavigatorSeparator2, BindingNavigatorRefreshItem, BindingNavigatorSeparator4, BindingNavigatorSave, BindingNavigatorSeparator6, BindingNavigatorSaveItem });
            PurchaseBindingNavigator.Location = new Point(506, 10);
            PurchaseBindingNavigator.MoveFirstItem = null;
            PurchaseBindingNavigator.MoveLastItem = null;
            PurchaseBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            PurchaseBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            PurchaseBindingNavigator.Name = "PurchaseBindingNavigator";
            PurchaseBindingNavigator.PositionItem = null;
            PurchaseBindingNavigator.Size = new Size(392, 25);
            PurchaseBindingNavigator.TabIndex = 17;
            PurchaseBindingNavigator.Text = "BindingNavigator";
            PurchaseBindingNavigator.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorSeparator
            // 
            BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            BindingNavigatorSeparator.Size = new Size(6, 25);
            BindingNavigatorSeparator.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorSeparator2
            // 
            BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            BindingNavigatorSeparator2.Size = new Size(6, 25);
            BindingNavigatorSeparator2.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorSeparator4
            // 
            BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4";
            BindingNavigatorSeparator4.Size = new Size(6, 25);
            BindingNavigatorSeparator4.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorSeparator6
            // 
            BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6";
            BindingNavigatorSeparator6.Size = new Size(6, 25);
            BindingNavigatorSeparator6.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorSaveItem
            // 
            BindingNavigatorSaveItem.Enabled = false;
            BindingNavigatorSaveItem.Image = (Image)resources.GetObject("BindingNavigatorSaveItem.Image");
            BindingNavigatorSaveItem.ImageTransparentColor = Color.Magenta;
            BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            BindingNavigatorSaveItem.Size = new Size(108, 22);
            BindingNavigatorSaveItem.Text = "&Update Returns";
            BindingNavigatorSaveItem.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorSaveItem.ToolTipText = "Update Products Changes";
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label21.ForeColor = Color.Yellow;
            Label21.Location = new Point(339, 19);
            Label21.Name = "Label21";
            Label21.Size = new Size(66, 16);
            Label21.TabIndex = 49;
            Label21.Text = "Company";
            // 
            // SplitContainer1
            // 
            SplitContainer1.Location = new Point(3, 45);
            SplitContainer1.Name = "SplitContainer1";
            SplitContainer1.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            SplitContainer1.Panel1.Controls.Add(cmbCompany);
            SplitContainer1.Panel1.Controls.Add(Label21);
            SplitContainer1.Panel1.Controls.Add(Label20);
            SplitContainer1.Panel1.Controls.Add(txtSQty3);
            SplitContainer1.Panel1.Controls.Add(Label13);
            SplitContainer1.Panel1.Controls.Add(txtSch3);
            SplitContainer1.Panel1.Controls.Add(Label14);
            SplitContainer1.Panel1.Controls.Add(txtSQty2);
            SplitContainer1.Panel1.Controls.Add(Label11);
            SplitContainer1.Panel1.Controls.Add(txtSch2);
            SplitContainer1.Panel1.Controls.Add(Label12);
            SplitContainer1.Panel1.Controls.Add(txtSQty1);
            SplitContainer1.Panel1.Controls.Add(Label9);
            SplitContainer1.Panel1.Controls.Add(txtSch1);
            SplitContainer1.Panel1.Controls.Add(Label10);
            SplitContainer1.Panel1.Controls.Add(txtQty);
            SplitContainer1.Panel1.Controls.Add(Label8);
            SplitContainer1.Panel1.Controls.Add(txtPPrice);
            SplitContainer1.Panel1.Controls.Add(Label6);
            SplitContainer1.Panel1.Controls.Add(txtDesc);
            SplitContainer1.Panel1.Controls.Add(Label3);
            SplitContainer1.Panel1.Controls.Add(txtCode);
            SplitContainer1.Panel1.Controls.Add(Label2);
            SplitContainer1.Panel1.Controls.Add(txtDate);
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(SplitContainer2);
            SplitContainer1.Size = new Size(974, 571);
            SplitContainer1.SplitterDistance = 163;
            SplitContainer1.TabIndex = 18;
            // 
            // txtSQty3
            // 
            txtSQty3.BackColor = Color.SteelBlue;
            txtSQty3.BorderStyle = BorderStyle.FixedSingle;
            txtSQty3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSQty3.ForeColor = Color.White;
            txtSQty3.Location = new Point(571, 122);
            txtSQty3.Name = "txtSQty3";
            txtSQty3.Size = new Size(62, 20);
            txtSQty3.TabIndex = 11;
            txtSQty3.Text = "0";
            txtSQty3.TextAlign = HorizontalAlignment.Center;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label13.ForeColor = Color.Yellow;
            Label13.Location = new Point(504, 124);
            Label13.Name = "Label13";
            Label13.Size = new Size(64, 16);
            Label13.TabIndex = 36;
            Label13.Text = "Sch3. Qty";
            // 
            // txtSch3
            // 
            txtSch3.BackColor = Color.SteelBlue;
            txtSch3.BorderStyle = BorderStyle.FixedSingle;
            txtSch3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSch3.ForeColor = Color.White;
            txtSch3.Location = new Point(412, 122);
            txtSch3.Name = "txtSch3";
            txtSch3.ReadOnly = true;
            txtSch3.Size = new Size(71, 20);
            txtSch3.TabIndex = 10;
            txtSch3.TabStop = false;
            txtSch3.Text = "0";
            txtSch3.TextAlign = HorizontalAlignment.Center;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label14.ForeColor = Color.Yellow;
            Label14.Location = new Point(352, 124);
            Label14.Name = "Label14";
            Label14.Size = new Size(57, 16);
            Label14.TabIndex = 34;
            Label14.Text = "Sch3 Pr.";
            // 
            // txtSQty2
            // 
            txtSQty2.BackColor = Color.SteelBlue;
            txtSQty2.BorderStyle = BorderStyle.FixedSingle;
            txtSQty2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSQty2.ForeColor = Color.White;
            txtSQty2.Location = new Point(877, 85);
            txtSQty2.Name = "txtSQty2";
            txtSQty2.Size = new Size(61, 20);
            txtSQty2.TabIndex = 9;
            txtSQty2.Text = "0";
            txtSQty2.TextAlign = HorizontalAlignment.Center;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label11.ForeColor = Color.Yellow;
            Label11.Location = new Point(807, 87);
            Label11.Name = "Label11";
            Label11.Size = new Size(64, 16);
            Label11.TabIndex = 32;
            Label11.Text = "Sch2. Qty";
            // 
            // txtSch2
            // 
            txtSch2.BackColor = Color.SteelBlue;
            txtSch2.BorderStyle = BorderStyle.FixedSingle;
            txtSch2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSch2.ForeColor = Color.White;
            txtSch2.Location = new Point(716, 85);
            txtSch2.Name = "txtSch2";
            txtSch2.ReadOnly = true;
            txtSch2.Size = new Size(72, 20);
            txtSch2.TabIndex = 8;
            txtSch2.TabStop = false;
            txtSch2.Text = "0";
            txtSch2.TextAlign = HorizontalAlignment.Center;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label12.ForeColor = Color.Yellow;
            Label12.Location = new Point(653, 87);
            Label12.Name = "Label12";
            Label12.Size = new Size(57, 16);
            Label12.TabIndex = 30;
            Label12.Text = "Sch2 Pr.";
            // 
            // txtSQty1
            // 
            txtSQty1.BackColor = Color.SteelBlue;
            txtSQty1.BorderStyle = BorderStyle.FixedSingle;
            txtSQty1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSQty1.ForeColor = Color.White;
            txtSQty1.Location = new Point(571, 85);
            txtSQty1.Name = "txtSQty1";
            txtSQty1.Size = new Size(62, 20);
            txtSQty1.TabIndex = 7;
            txtSQty1.Text = "0";
            txtSQty1.TextAlign = HorizontalAlignment.Center;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.Yellow;
            Label9.Location = new Point(504, 87);
            Label9.Name = "Label9";
            Label9.Size = new Size(64, 16);
            Label9.TabIndex = 28;
            Label9.Text = "Sch1. Qty";
            // 
            // txtSch1
            // 
            txtSch1.BackColor = Color.SteelBlue;
            txtSch1.BorderStyle = BorderStyle.FixedSingle;
            txtSch1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSch1.ForeColor = Color.White;
            txtSch1.Location = new Point(411, 85);
            txtSch1.Name = "txtSch1";
            txtSch1.ReadOnly = true;
            txtSch1.Size = new Size(72, 20);
            txtSch1.TabIndex = 6;
            txtSch1.TabStop = false;
            txtSch1.Text = "0";
            txtSch1.TextAlign = HorizontalAlignment.Center;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label10.ForeColor = Color.Yellow;
            Label10.Location = new Point(352, 87);
            Label10.Name = "Label10";
            Label10.Size = new Size(57, 16);
            Label10.TabIndex = 26;
            Label10.Text = "Sch1 Pr.";
            // 
            // txtQty
            // 
            txtQty.BackColor = Color.SteelBlue;
            txtQty.BorderStyle = BorderStyle.FixedSingle;
            txtQty.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQty.ForeColor = Color.White;
            txtQty.Location = new Point(247, 87);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(53, 20);
            txtQty.TabIndex = 5;
            txtQty.Text = "0";
            txtQty.TextAlign = HorizontalAlignment.Center;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.Yellow;
            Label8.Location = new Point(191, 89);
            Label8.Name = "Label8";
            Label8.Size = new Size(56, 16);
            Label8.TabIndex = 22;
            Label8.Text = "Quantity";
            // 
            // txtPPrice
            // 
            txtPPrice.BackColor = Color.SteelBlue;
            txtPPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPPrice.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPPrice.ForeColor = Color.White;
            txtPPrice.Location = new Point(108, 87);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.ReadOnly = true;
            txtPPrice.Size = new Size(66, 20);
            txtPPrice.TabIndex = 4;
            txtPPrice.TabStop = false;
            txtPPrice.Text = "0";
            txtPPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.Yellow;
            Label6.Location = new Point(49, 89);
            Label6.Name = "Label6";
            Label6.Size = new Size(54, 16);
            Label6.TabIndex = 20;
            Label6.Text = "P. Price";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.SteelBlue;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesc.ForeColor = Color.White;
            txtDesc.Location = new Point(411, 50);
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new Size(527, 20);
            txtDesc.TabIndex = 3;
            txtDesc.TabStop = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Yellow;
            Label3.Location = new Point(329, 52);
            Label3.Name = "Label3";
            Label3.Size = new Size(76, 16);
            Label3.TabIndex = 14;
            Label3.Text = "Description";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.SteelBlue;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.CharacterCasing = CharacterCasing.Upper;
            txtCode.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCode.ForeColor = Color.White;
            txtCode.Location = new Point(108, 50);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(192, 20);
            txtCode.TabIndex = 2;
            txtCode.TextAlign = HorizontalAlignment.Center;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.Yellow;
            Label2.Location = new Point(12, 52);
            Label2.Name = "Label2";
            Label2.Size = new Size(90, 16);
            Label2.TabIndex = 12;
            Label2.Text = "Product Code";
            // 
            // txtDate
            // 
            txtDate.Cursor = Cursors.Hand;
            txtDate.Location = new Point(108, 15);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(191, 20);
            txtDate.TabIndex = 0;
            // 
            // LineShape2
            // 
            LineShape2.BorderColor = Color.Black;
            LineShape2.Name = "LineShape2";
            LineShape2.X1 = 5;
            LineShape2.X2 = 977;
            LineShape2.Y1 = 43;
            LineShape2.Y2 = 43;
            // 
            // LineShape1
            // 
            LineShape1.BorderColor = Color.Gray;
            LineShape1.Name = "LineShape1";
            LineShape1.X1 = 5;
            LineShape1.X2 = 977;
            LineShape1.Y1 = 44;
            LineShape1.Y2 = 44;
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { LineShape1, LineShape2 });
            ShapeContainer1.Size = new Size(982, 621);
            ShapeContainer1.TabIndex = 19;
            ShapeContainer1.TabStop = false;
            // 
            // frmPurchReturn
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(982, 621);
            Controls.Add(Label1);
            Controls.Add(cmdMin);
            Controls.Add(cmdClose);
            Controls.Add(PurchaseBindingNavigator);
            Controls.Add(SplitContainer1);
            Controls.Add(ShapeContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "frmPurchReturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Purchases";
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataTable2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataTable1).EndInit();
            SplitContainer2.Panel1.ResumeLayout(false);
            SplitContainer2.Panel2.ResumeLayout(false);
            SplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PurchaseBindingNavigator).EndInit();
            PurchaseBindingNavigator.ResumeLayout(false);
            PurchaseBindingNavigator.PerformLayout();
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel1.PerformLayout();
            SplitContainer1.Panel2.ResumeLayout(false);
            SplitContainer1.ResumeLayout(false);
            KeyUp += new KeyEventHandler(frmPurchReturn_KeyUp);
            MouseDown += new MouseEventHandler(frmPurchReturn_MouseDown);
            MouseMove += new MouseEventHandler(frmPurchReturn_MouseMove);
            MouseUp += new MouseEventHandler(frmPurchReturn_MouseUp);
            Load += new EventHandler(frmPurchReturn_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal DataGridView ProductDataGridView;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn colPrchDate;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn21;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn22;
        internal BindingSource ProductBindingSource;
        internal DataSet ProductDataSet;
        internal DataTable DataTable2;
        internal Button cmdMin;
        internal ToolTip ToolTip1;
        internal ToolStripButton BindingNavigatorSave;
        internal ToolStripButton BindingNavigatorRefreshItem;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal Button cmdClose;
        internal DataGridView PurchaseDataGridView;
        internal BindingSource PurchaseBindingSource;
        internal DataSet PurchaseDataSet;
        internal DataTable DataTable1;
        internal SplitContainer SplitContainer2;
        internal ComboBox cmbCompany;
        internal Label Label20;
        internal BindingNavigator PurchaseBindingNavigator;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal ToolStripSeparator BindingNavigatorSeparator4;
        internal ToolStripSeparator BindingNavigatorSeparator6;
        internal ToolStripButton BindingNavigatorSaveItem;
        internal Label Label21;
        internal SplitContainer SplitContainer1;
        internal TextBox txtSQty3;
        internal Label Label13;
        internal TextBox txtSch3;
        internal Label Label14;
        internal TextBox txtSQty2;
        internal Label Label11;
        internal TextBox txtSch2;
        internal Label Label12;
        internal TextBox txtSQty1;
        internal Label Label9;
        internal TextBox txtSch1;
        internal Label Label10;
        internal TextBox txtQty;
        internal Label Label8;
        internal TextBox txtPPrice;
        internal Label Label6;
        internal TextBox txtDesc;
        internal Label Label3;
        internal TextBox txtCode;
        internal Label Label2;
        internal DateTimePicker txtDate;
        internal DataGridViewTextBoxColumn colTranID;
        internal DataGridViewTextBoxColumn colDate;
        internal DataGridViewTextBoxColumn colProdID;
        internal DataGridViewTextBoxColumn colDesc;
        internal DataGridViewTextBoxColumn colSupplier;
        internal DataGridViewTextBoxColumn colPck;
        internal DataGridViewTextBoxColumn colPPrice;
        internal DataGridViewTextBoxColumn colQty;
        internal DataGridViewTextBoxColumn colPrvStock;
        internal DataGridViewTextBoxColumn colSch1;
        internal DataGridViewTextBoxColumn colPSch1;
        internal DataGridViewTextBoxColumn colSch2;
        internal DataGridViewTextBoxColumn colPSch2;
        internal DataGridViewTextBoxColumn colSch3;
        internal DataGridViewTextBoxColumn colPSch3;
        internal DataGridViewTextBoxColumn colRmks;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape2;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
    }
}