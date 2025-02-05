using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class StockPosition : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(StockPosition));
            ProductBindingSource = new BindingSource(components);
            ProductDataSet = new DataSet();
            DataTable2 = new DataTable();
            cmdMin = new Button();
            cmdMin.Click += new EventHandler(cmdMin_Click);
            ToolTip1 = new ToolTip(components);
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            Label1 = new Label();
            SplitContainer1 = new SplitContainer();
            ProductDataGridView = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
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
            DataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            BindingNavigatorSeparator4 = new ToolStripSeparator();
            ProductBindingNavigator = new BindingNavigator(components);
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorTextBox = new ToolStripTextBox();
            BindingNavigatorTextBox.Click += new EventHandler(BindingNavigatorTextBox_Click);
            BindingNavigatorTextBox.KeyDown += new KeyEventHandler(BindingNavigatorTextBox_KeyDown);
            BindingNavigatorTextBox.KeyUp += new KeyEventHandler(BindingNavigatorTextBox_KeyUp);
            BindingNavigatorFind = new ToolStripButton();
            BindingNavigatorFind.Click += new EventHandler(BindingNavigatorFind_Click);
            BindingNavigatorSeparator3 = new ToolStripSeparator();
            BindingNavigatorSummary = new ToolStripButton();
            BindingNavigatorSummary.Click += new EventHandler(BindingNavigatorSummary_Click);
            BindingNavigatorSeparator5 = new ToolStripSeparator();
            BindingNavigatorSummaryGroup = new ToolStripButton();
            BindingNavigatorSummaryGroup.Click += new EventHandler(BindingNavigatorSummaryGroup_Click);
            ((System.ComponentModel.ISupportInitialize)ProductBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataTable2).BeginInit();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductBindingNavigator).BeginInit();
            ProductBindingNavigator.SuspendLayout();
            SuspendLayout();
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
            cmdClose.TabIndex = 15;
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
            Label1.Location = new Point(6, 4);
            Label1.Name = "Label1";
            Label1.Size = new Size(201, 31);
            Label1.TabIndex = 14;
            Label1.Text = "Stock Position";
            // 
            // SplitContainer1
            // 
            SplitContainer1.Location = new Point(4, 45);
            SplitContainer1.Name = "SplitContainer1";
            SplitContainer1.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            SplitContainer1.Panel1.Controls.Add(ProductDataGridView);
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(DataGridView1);
            SplitContainer1.Size = new Size(973, 572);
            SplitContainer1.SplitterDistance = 412;
            SplitContainer1.TabIndex = 18;
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
            ProductDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = SystemColors.Control;
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8, DataGridViewTextBoxColumn10, DataGridViewTextBoxColumn11, DataGridViewTextBoxColumn12, DataGridViewTextBoxColumn13, DataGridViewTextBoxColumn14, DataGridViewTextBoxColumn15, DataGridViewTextBoxColumn16, DataGridViewTextBoxColumn17, DataGridViewTextBoxColumn18, DataGridViewTextBoxColumn19, DataGridViewTextBoxColumn20, DataGridViewTextBoxColumn21, DataGridViewTextBoxColumn22 });
            ProductDataGridView.DataSource = ProductBindingSource;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.GridColor = Color.Gray;
            ProductDataGridView.Location = new Point(0, 0);
            ProductDataGridView.MultiSelect = false;
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowHeadersVisible = false;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 0, 0);
            ProductDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2;
            ProductDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductDataGridView.Size = new Size(973, 412);
            ProductDataGridView.TabIndex = 21;
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
            DataGridViewTextBoxColumn5.DataPropertyName = "PROD_DATE";
            DataGridViewTextBoxColumn5.HeaderText = "Update On";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
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
            // DataGridView1
            // 
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.AllowUserToResizeColumns = false;
            DataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            DataGridView1.BorderStyle = BorderStyle.None;
            DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor = SystemColors.Control;
            DataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column7 });
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(0, 0);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersVisible = false;
            DataGridViewCellStyle10.BackColor = Color.FromArgb(64, 64, 64);
            DataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle10.ForeColor = Color.Cyan;
            DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(64, 64, 64);
            DataGridViewCellStyle10.SelectionForeColor = Color.Cyan;
            DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(973, 156);
            DataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column1.DefaultCellStyle = DataGridViewCellStyle4;
            Column1.HeaderText = "Description";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = DataGridViewCellStyle5;
            Column2.HeaderText = "Raw Stock";
            Column2.Name = "Column2";
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column3.DefaultCellStyle = DataGridViewCellStyle6;
            Column3.HeaderText = "Total Amount";
            Column3.Name = "Column3";
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column5.DefaultCellStyle = DataGridViewCellStyle7;
            Column5.HeaderText = "Scheme Stock";
            Column5.Name = "Column5";
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column4.DefaultCellStyle = DataGridViewCellStyle8;
            Column4.HeaderText = "Scheme Amount";
            Column4.Name = "Column4";
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = DataGridViewCellStyle9;
            Column7.HeaderText = "Profit Amount";
            Column7.Name = "Column7";
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // ProductBindingNavigator
            // 
            ProductBindingNavigator.AddNewItem = null;
            ProductBindingNavigator.BindingSource = ProductBindingSource;
            ProductBindingNavigator.CountItem = null;
            ProductBindingNavigator.DeleteItem = null;
            ProductBindingNavigator.Dock = DockStyle.None;
            ProductBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorMoveNextItem, BindingNavigatorSeparator2, BindingNavigatorTextBox, BindingNavigatorSeparator4, BindingNavigatorFind, BindingNavigatorSeparator3, BindingNavigatorSummary, BindingNavigatorSeparator5, BindingNavigatorSummaryGroup });
            ProductBindingNavigator.Location = new Point(238, 10);
            ProductBindingNavigator.MoveFirstItem = null;
            ProductBindingNavigator.MoveLastItem = null;
            ProductBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            ProductBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            ProductBindingNavigator.Name = "ProductBindingNavigator";
            ProductBindingNavigator.PositionItem = null;
            ProductBindingNavigator.Size = new Size(663, 25);
            ProductBindingNavigator.TabIndex = 17;
            ProductBindingNavigator.Text = "BindingNavigator";
            ProductBindingNavigator.TextDirection = ToolStripTextDirection.Vertical90;
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
            // BindingNavigatorTextBox
            // 
            BindingNavigatorTextBox.Name = "BindingNavigatorTextBox";
            BindingNavigatorTextBox.Size = new Size(200, 25);
            BindingNavigatorTextBox.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorFind
            // 
            BindingNavigatorFind.Image = My.Resources.Resources.search1;
            BindingNavigatorFind.ImageTransparentColor = Color.Magenta;
            BindingNavigatorFind.Name = "BindingNavigatorFind";
            BindingNavigatorFind.Size = new Size(95, 22);
            BindingNavigatorFind.Text = "&Find Product";
            BindingNavigatorFind.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorFind.ToolTipText = "Click to Find Product";
            // 
            // BindingNavigatorSeparator3
            // 
            BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3";
            BindingNavigatorSeparator3.Size = new Size(6, 25);
            BindingNavigatorSeparator3.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorSummary
            // 
            BindingNavigatorSummary.Image = (Image)resources.GetObject("BindingNavigatorSummary.Image");
            BindingNavigatorSummary.ImageTransparentColor = Color.Magenta;
            BindingNavigatorSummary.Name = "BindingNavigatorSummary";
            BindingNavigatorSummary.Size = new Size(78, 22);
            BindingNavigatorSummary.Text = "&Summary";
            BindingNavigatorSummary.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // BindingNavigatorSeparator5
            // 
            BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5";
            BindingNavigatorSeparator5.Size = new Size(6, 25);
            BindingNavigatorSeparator5.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorSummaryGroup
            // 
            BindingNavigatorSummaryGroup.Image = My.Resources.Resources.PatientFile2;
            BindingNavigatorSummaryGroup.ImageTransparentColor = Color.Magenta;
            BindingNavigatorSummaryGroup.Name = "BindingNavigatorSummaryGroup";
            BindingNavigatorSummaryGroup.Size = new Size(145, 22);
            BindingNavigatorSummaryGroup.Text = "Su&mmary by Category";
            BindingNavigatorSummaryGroup.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // frmStockPosition
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(982, 621);
            Controls.Add(SplitContainer1);
            Controls.Add(cmdMin);
            Controls.Add(cmdClose);
            Controls.Add(Label1);
            Controls.Add(ProductBindingNavigator);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmStockPosition";
            Opacity = 0.8d;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStockPosition";
            ((System.ComponentModel.ISupportInitialize)ProductBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataTable2).EndInit();
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel2.ResumeLayout(false);
            SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductBindingNavigator).EndInit();
            ProductBindingNavigator.ResumeLayout(false);
            ProductBindingNavigator.PerformLayout();
            MouseDown += new MouseEventHandler(frmStockPosition_MouseDown);
            MouseMove += new MouseEventHandler(frmStockPosition_MouseMove);
            MouseUp += new MouseEventHandler(frmStockPosition_MouseUp);
            Load += new EventHandler(frmStockPosition_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal BindingSource ProductBindingSource;
        internal DataSet ProductDataSet;
        internal DataTable DataTable2;
        internal ToolTip ToolTip1;
        internal Button cmdMin;
        internal Button cmdClose;
        internal Label Label1;
        internal SplitContainer SplitContainer1;
        internal DataGridView ProductDataGridView;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
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
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal ToolStripSeparator BindingNavigatorSeparator4;
        internal BindingNavigator ProductBindingNavigator;
        internal ToolStripTextBox BindingNavigatorTextBox;
        internal ToolStripButton BindingNavigatorFind;
        internal ToolStripButton BindingNavigatorSummary;
        internal ToolStripSeparator BindingNavigatorSeparator3;
        internal DataGridView DataGridView1;
        internal ToolStripSeparator BindingNavigatorSeparator5;
        internal ToolStripButton BindingNavigatorSummaryGroup;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column7;
    }
}