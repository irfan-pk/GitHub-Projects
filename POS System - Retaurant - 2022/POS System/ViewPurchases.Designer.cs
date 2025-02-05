using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ViewPurchases : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPurchases));
            LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            LineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            Label1 = new Label();
            cmdMin = new Button();
            cmdMin.Click += new EventHandler(cmdMin_Click);
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            Panel1 = new Panel();
            PurchaseDataGridView = new DataGridView();
            colTranID = new DataGridViewTextBoxColumn();
            colProdID = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colCatg = new DataGridViewTextBoxColumn();
            colSupplier = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colPck = new DataGridViewTextBoxColumn();
            colPPrice = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colPrvStock = new DataGridViewTextBoxColumn();
            colMin = new DataGridViewTextBoxColumn();
            colSch1 = new DataGridViewTextBoxColumn();
            colPSch1 = new DataGridViewTextBoxColumn();
            colSch2 = new DataGridViewTextBoxColumn();
            colPSch2 = new DataGridViewTextBoxColumn();
            colSch3 = new DataGridViewTextBoxColumn();
            colPSch3 = new DataGridViewTextBoxColumn();
            colVAT = new DataGridViewTextBoxColumn();
            colITax = new DataGridViewTextBoxColumn();
            colExcise = new DataGridViewTextBoxColumn();
            colMargn = new DataGridViewTextBoxColumn();
            colProfit = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colRmks = new DataGridViewTextBoxColumn();
            PurchaseBindingSource = new BindingSource(components);
            PurchaseDataSet = new DataSet();
            DataTable1 = new DataTable();
            ToolTip1 = new ToolTip(components);
            Panel2 = new Panel();
            cmdPreview = new Button();
            cmdPreview.Click += new EventHandler(cmdPreview_Click);
            Label3 = new Label();
            ToDateTime = new DateTimePicker();
            FromDateTime = new DateTimePicker();
            Label2 = new Label();
            PurchaseBindingNavigator = new BindingNavigator(components);
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            BindingNavigatorTextBox = new ToolStripTextBox();
            BindingNavigatorTextBox.KeyDown += new KeyEventHandler(BindingNavigatorTextBox_KeyDown);
            BindingNavigatorTextBox.KeyUp += new KeyEventHandler(BindingNavigatorTextBox_KeyUp);
            BindingNavigatorSeparator4 = new ToolStripSeparator();
            BindingNavigatorFind = new ToolStripButton();
            BindingNavigatorFind.Click += new EventHandler(BindingNavigatorFind_Click);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataTable1).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PurchaseBindingNavigator).BeginInit();
            PurchaseBindingNavigator.SuspendLayout();
            SuspendLayout();
            // 
            // LineShape1
            // 
            LineShape1.BorderColor = Color.Gray;
            LineShape1.Name = "LineShape1";
            LineShape1.X1 = 5;
            LineShape1.X2 = 977;
            LineShape1.Y1 = 48;
            LineShape1.Y2 = 48;
            // 
            // LineShape2
            // 
            LineShape2.BorderColor = Color.Black;
            LineShape2.Name = "LineShape2";
            LineShape2.X1 = 5;
            LineShape2.X2 = 977;
            LineShape2.Y1 = 47;
            LineShape2.Y2 = 47;
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { LineShape2, LineShape1 });
            ShapeContainer1.Size = new Size(982, 621);
            ShapeContainer1.TabIndex = 0;
            ShapeContainer1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Red;
            Label1.Location = new Point(3, 6);
            Label1.Name = "Label1";
            Label1.Size = new Size(270, 31);
            Label1.TabIndex = 19;
            Label1.Text = "Purchases Register";
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
            cmdMin.Location = new Point(912, 7);
            cmdMin.Name = "cmdMin";
            cmdMin.Size = new Size(29, 34);
            cmdMin.TabIndex = 20;
            cmdMin.TabStop = false;
            cmdMin.Text = "----";
            cmdMin.UseVisualStyleBackColor = false;
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
            cmdClose.Location = new Point(943, 7);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(31, 34);
            cmdClose.TabIndex = 18;
            cmdClose.TabStop = false;
            cmdClose.Text = "X";
            cmdClose.TextAlign = ContentAlignment.MiddleLeft;
            cmdClose.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(PurchaseDataGridView);
            Panel1.Dock = DockStyle.Bottom;
            Panel1.Location = new Point(0, 106);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(982, 515);
            Panel1.TabIndex = 22;
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
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = SystemColors.Control;
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PurchaseDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            PurchaseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PurchaseDataGridView.Columns.AddRange(new DataGridViewColumn[] { colTranID, colProdID, colDesc, colCatg, colSupplier, colDate, colPck, colPPrice, colQty, colPrvStock, colMin, colSch1, colPSch1, colSch2, colPSch2, colSch3, colPSch3, colVAT, colITax, colExcise, colMargn, colProfit, colPrice, colRmks });
            PurchaseDataGridView.DataSource = PurchaseBindingSource;
            PurchaseDataGridView.Dock = DockStyle.Fill;
            PurchaseDataGridView.GridColor = Color.Gray;
            PurchaseDataGridView.Location = new Point(0, 0);
            PurchaseDataGridView.MultiSelect = false;
            PurchaseDataGridView.Name = "PurchaseDataGridView";
            PurchaseDataGridView.ReadOnly = true;
            PurchaseDataGridView.RowHeadersVisible = false;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 0, 0);
            PurchaseDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2;
            PurchaseDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PurchaseDataGridView.Size = new Size(982, 515);
            PurchaseDataGridView.TabIndex = 24;
            // 
            // colTranID
            // 
            colTranID.DataPropertyName = "PRCH_TR_ID";
            colTranID.HeaderText = "Tran #";
            colTranID.Name = "colTranID";
            colTranID.ReadOnly = true;
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
            // colCatg
            // 
            colCatg.DataPropertyName = "PRCH_CATG";
            colCatg.HeaderText = "Category";
            colCatg.Name = "colCatg";
            colCatg.ReadOnly = true;
            // 
            // colSupplier
            // 
            colSupplier.DataPropertyName = "PRCH_SUPPLIER";
            colSupplier.HeaderText = "Supplier";
            colSupplier.Name = "colSupplier";
            colSupplier.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "PRCH_DATE";
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
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
            // colMin
            // 
            colMin.DataPropertyName = "PRCH_BAL_MIN";
            colMin.HeaderText = "Min Bal.";
            colMin.Name = "colMin";
            colMin.ReadOnly = true;
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
            // colVAT
            // 
            colVAT.DataPropertyName = "PRCH_VAT";
            colVAT.HeaderText = "V.A.T";
            colVAT.Name = "colVAT";
            colVAT.ReadOnly = true;
            // 
            // colITax
            // 
            colITax.DataPropertyName = "PRCH_ITAX";
            colITax.HeaderText = "I.Tax";
            colITax.Name = "colITax";
            colITax.ReadOnly = true;
            // 
            // colExcise
            // 
            colExcise.DataPropertyName = "PRCH_EX_DUTY";
            colExcise.HeaderText = "Excise Duty";
            colExcise.Name = "colExcise";
            colExcise.ReadOnly = true;
            // 
            // colMargn
            // 
            colMargn.DataPropertyName = "PRCH_DISC_MRG";
            colMargn.HeaderText = "Discount";
            colMargn.Name = "colMargn";
            colMargn.ReadOnly = true;
            // 
            // colProfit
            // 
            colProfit.DataPropertyName = "PRCH_PROFIT";
            colProfit.HeaderText = "Profit Margin";
            colProfit.Name = "colProfit";
            colProfit.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "PRCH_SPRICE";
            colPrice.HeaderText = "Sale Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
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
            // ToolTip1
            // 
            ToolTip1.AutomaticDelay = 1000;
            ToolTip1.AutoPopDelay = 10000;
            ToolTip1.ForeColor = Color.FromArgb(192, 0, 0);
            ToolTip1.InitialDelay = 500;
            ToolTip1.IsBalloon = true;
            ToolTip1.ReshowDelay = 100;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Silver;
            Panel2.BorderStyle = BorderStyle.Fixed3D;
            Panel2.Controls.Add(cmdPreview);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(ToDateTime);
            Panel2.Controls.Add(FromDateTime);
            Panel2.Controls.Add(Label2);
            Panel2.Location = new Point(2, 52);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(976, 42);
            Panel2.TabIndex = 28;
            // 
            // cmdPreview
            // 
            cmdPreview.FlatStyle = FlatStyle.Popup;
            cmdPreview.Image = My.Resources.Resources.Book_openHS;
            cmdPreview.ImageAlign = ContentAlignment.MiddleLeft;
            cmdPreview.Location = new Point(530, 4);
            cmdPreview.Name = "cmdPreview";
            cmdPreview.Size = new Size(72, 29);
            cmdPreview.TabIndex = 31;
            cmdPreview.Text = "&Preview";
            cmdPreview.TextAlign = ContentAlignment.MiddleRight;
            cmdPreview.TextImageRelation = TextImageRelation.ImageBeforeText;
            cmdPreview.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(292, 13);
            Label3.Name = "Label3";
            Label3.Size = new Size(22, 13);
            Label3.TabIndex = 30;
            Label3.Text = "To";
            // 
            // ToDateTime
            // 
            ToDateTime.Location = new Point(317, 9);
            ToDateTime.Name = "ToDateTime";
            ToDateTime.Size = new Size(204, 20);
            ToDateTime.TabIndex = 1;
            // 
            // FromDateTime
            // 
            FromDateTime.Location = new Point(74, 9);
            FromDateTime.Name = "FromDateTime";
            FromDateTime.Size = new Size(204, 20);
            FromDateTime.TabIndex = 0;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(6, 13);
            Label2.Name = "Label2";
            Label2.Size = new Size(65, 13);
            Label2.TabIndex = 0;
            Label2.Text = "View From";
            // 
            // PurchaseBindingNavigator
            // 
            PurchaseBindingNavigator.AddNewItem = null;
            PurchaseBindingNavigator.BindingSource = PurchaseBindingSource;
            PurchaseBindingNavigator.CountItem = null;
            PurchaseBindingNavigator.DeleteItem = null;
            PurchaseBindingNavigator.Dock = DockStyle.None;
            PurchaseBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorMoveNextItem, BindingNavigatorSeparator2, BindingNavigatorTextBox, BindingNavigatorSeparator4, BindingNavigatorFind });
            PurchaseBindingNavigator.Location = new Point(444, 12);
            PurchaseBindingNavigator.MoveFirstItem = null;
            PurchaseBindingNavigator.MoveLastItem = null;
            PurchaseBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            PurchaseBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            PurchaseBindingNavigator.Name = "PurchaseBindingNavigator";
            PurchaseBindingNavigator.PositionItem = null;
            PurchaseBindingNavigator.Size = new Size(446, 25);
            PurchaseBindingNavigator.TabIndex = 31;
            PurchaseBindingNavigator.Text = "BindingNavigator";
            PurchaseBindingNavigator.TextDirection = ToolStripTextDirection.Vertical90;
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
            // BindingNavigatorSeparator
            // 
            BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            BindingNavigatorSeparator.Size = new Size(6, 25);
            BindingNavigatorSeparator.TextDirection = ToolStripTextDirection.Vertical90;
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
            // BindingNavigatorSeparator2
            // 
            BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            BindingNavigatorSeparator2.Size = new Size(6, 25);
            BindingNavigatorSeparator2.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorTextBox
            // 
            BindingNavigatorTextBox.Name = "BindingNavigatorTextBox";
            BindingNavigatorTextBox.Size = new Size(200, 25);
            BindingNavigatorTextBox.TextDirection = ToolStripTextDirection.Vertical90;
            BindingNavigatorTextBox.ToolTipText = "Enter Product Code to Find";
            // 
            // BindingNavigatorSeparator4
            // 
            BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4";
            BindingNavigatorSeparator4.Size = new Size(6, 25);
            BindingNavigatorSeparator4.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorFind
            // 
            BindingNavigatorFind.Image = My.Resources.Resources.search1;
            BindingNavigatorFind.ImageTransparentColor = Color.Magenta;
            BindingNavigatorFind.Name = "BindingNavigatorFind";
            BindingNavigatorFind.Size = new Size(113, 22);
            BindingNavigatorFind.Text = "&View by Product";
            BindingNavigatorFind.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorFind.ToolTipText = "Click to Find Product";
            // 
            // frmViewPurchases
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(982, 621);
            Controls.Add(PurchaseBindingNavigator);
            Controls.Add(Panel1);
            Controls.Add(Label1);
            Controls.Add(cmdMin);
            Controls.Add(cmdClose);
            Controls.Add(Panel2);
            Controls.Add(ShapeContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmViewPurchases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Purchases";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PurchaseDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataTable1).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PurchaseBindingNavigator).EndInit();
            PurchaseBindingNavigator.ResumeLayout(false);
            PurchaseBindingNavigator.PerformLayout();
            MouseDown += new MouseEventHandler(frmViewPurchases_MouseDown);
            MouseMove += new MouseEventHandler(frmViewPurchases_MouseMove);
            MouseUp += new MouseEventHandler(frmViewPurchases_MouseUp);
            Load += new EventHandler(frmViewPurchases_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape2;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Label Label1;
        internal Button cmdMin;
        internal Button cmdClose;
        internal Panel Panel1;
        internal DataGridView PurchaseDataGridView;
        internal DataGridViewTextBoxColumn colTranID;
        internal DataGridViewTextBoxColumn colProdID;
        internal DataGridViewTextBoxColumn colDesc;
        internal DataGridViewTextBoxColumn colCatg;
        internal DataGridViewTextBoxColumn colSupplier;
        internal DataGridViewTextBoxColumn colDate;
        internal DataGridViewTextBoxColumn colPck;
        internal DataGridViewTextBoxColumn colPPrice;
        internal DataGridViewTextBoxColumn colQty;
        internal DataGridViewTextBoxColumn colPrvStock;
        internal DataGridViewTextBoxColumn colMin;
        internal DataGridViewTextBoxColumn colSch1;
        internal DataGridViewTextBoxColumn colPSch1;
        internal DataGridViewTextBoxColumn colSch2;
        internal DataGridViewTextBoxColumn colPSch2;
        internal DataGridViewTextBoxColumn colSch3;
        internal DataGridViewTextBoxColumn colPSch3;
        internal DataGridViewTextBoxColumn colVAT;
        internal DataGridViewTextBoxColumn colITax;
        internal DataGridViewTextBoxColumn colExcise;
        internal DataGridViewTextBoxColumn colMargn;
        internal DataGridViewTextBoxColumn colProfit;
        internal DataGridViewTextBoxColumn colPrice;
        internal DataGridViewTextBoxColumn colRmks;
        internal BindingSource PurchaseBindingSource;
        internal DataSet PurchaseDataSet;
        internal DataTable DataTable1;
        internal ToolTip ToolTip1;
        internal Panel Panel2;
        internal Label Label3;
        internal DateTimePicker ToDateTime;
        internal DateTimePicker FromDateTime;
        internal Label Label2;
        internal BindingNavigator PurchaseBindingNavigator;
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal ToolStripTextBox BindingNavigatorTextBox;
        internal ToolStripSeparator BindingNavigatorSeparator4;
        internal ToolStripButton BindingNavigatorFind;
        internal Button cmdPreview;
    }
}