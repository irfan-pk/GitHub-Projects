using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustPurchases : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CustPurchases));
            SaleDataGrid = new DataGridView();
            CustomerBindingSource = new BindingSource(components);
            CustomerDataSet = new DataSet();
            DataTable2 = new DataTable();
            CustomerBindingNavigator = new BindingNavigator(components);
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            BindingNavigatorTextBox = new ToolStripTextBox();
            BindingNavigatorTextBox.KeyUp += new KeyEventHandler(BindingNavigatorTextBox_KeyUp);
            BindingNavigatorTextBox.KeyDown += new KeyEventHandler(BindingNavigatorTextBox_KeyDown);
            BindingNavigatorSeparator4 = new ToolStripSeparator();
            BindingNavigatorFind = new ToolStripButton();
            BindingNavigatorFind.Click += new EventHandler(BindingNavigatorFind_Click);
            BindingNavigatorSeparator3 = new ToolStripSeparator();
            BindingNavigatorClose = new ToolStripButton();
            BindingNavigatorClose.Click += new EventHandler(BindingNavigatorClose_Click);
            BindingNavigatorSeparator5 = new ToolStripSeparator();
            ToolTip1 = new ToolTip(components);
            Panel2 = new Panel();
            cmdPreview = new Button();
            cmdPreview.Click += new EventHandler(cmdPreview_Click);
            Label3 = new Label();
            ToDateTime = new DateTimePicker();
            FromDateTime = new DateTimePicker();
            Label2 = new Label();
            colSaleID = new DataGridViewTextBoxColumn();
            colCustID = new DataGridViewTextBoxColumn();
            colSequence = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colPack = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colSubTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)SaleDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataTable2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerBindingNavigator).BeginInit();
            CustomerBindingNavigator.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SaleDataGrid
            // 
            SaleDataGrid.AllowUserToAddRows = false;
            SaleDataGrid.AllowUserToDeleteRows = false;
            SaleDataGrid.AutoGenerateColumns = false;
            SaleDataGrid.BackgroundColor = Color.Gray;
            SaleDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            SaleDataGrid.ColumnHeadersHeight = 22;
            SaleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            SaleDataGrid.Columns.AddRange(new DataGridViewColumn[] { colSaleID, colCustID, colSequence, colName, colDescription, colPack, colPrice, colQuantity, colSubTotal });
            SaleDataGrid.DataSource = CustomerBindingSource;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.Gray;
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.Yellow;
            DataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle1.SelectionForeColor = Color.Yellow;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            SaleDataGrid.DefaultCellStyle = DataGridViewCellStyle1;
            SaleDataGrid.Dock = DockStyle.Fill;
            SaleDataGrid.Location = new Point(0, 67);
            SaleDataGrid.Name = "SaleDataGrid";
            SaleDataGrid.ReadOnly = true;
            SaleDataGrid.RowHeadersVisible = false;
            SaleDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SaleDataGrid.Size = new Size(937, 529);
            SaleDataGrid.TabIndex = 3;
            SaleDataGrid.TabStop = false;
            // 
            // CustomerBindingSource
            // 
            CustomerBindingSource.DataSource = CustomerDataSet;
            CustomerBindingSource.Position = 0;
            // 
            // CustomerDataSet
            // 
            CustomerDataSet.DataSetName = "CustomerDataSet";
            CustomerDataSet.Tables.AddRange(new DataTable[] { DataTable2 });
            // 
            // DataTable2
            // 
            DataTable2.TableName = "PRODUCTS";
            // 
            // CustomerBindingNavigator
            // 
            CustomerBindingNavigator.AddNewItem = null;
            CustomerBindingNavigator.BackgroundImageLayout = ImageLayout.Center;
            CustomerBindingNavigator.BindingSource = CustomerBindingSource;
            CustomerBindingNavigator.CountItem = null;
            CustomerBindingNavigator.DeleteItem = null;
            CustomerBindingNavigator.GripStyle = ToolStripGripStyle.Hidden;
            CustomerBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorMoveNextItem, BindingNavigatorSeparator2, BindingNavigatorTextBox, BindingNavigatorSeparator4, BindingNavigatorFind, BindingNavigatorSeparator3, BindingNavigatorClose, BindingNavigatorSeparator5 });
            CustomerBindingNavigator.Location = new Point(0, 0);
            CustomerBindingNavigator.MoveFirstItem = null;
            CustomerBindingNavigator.MoveLastItem = null;
            CustomerBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            CustomerBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            CustomerBindingNavigator.Name = "CustomerBindingNavigator";
            CustomerBindingNavigator.PositionItem = null;
            CustomerBindingNavigator.Size = new Size(937, 25);
            CustomerBindingNavigator.TabIndex = 23;
            CustomerBindingNavigator.Text = "BindingNavigator";
            CustomerBindingNavigator.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorMovePreviousItem
            // 
            BindingNavigatorMovePreviousItem.BackColor = SystemColors.Control;
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
            BindingNavigatorMoveNextItem.BackColor = SystemColors.Control;
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
            BindingNavigatorTextBox.ToolTipText = "Enter Product Code to Find or Press F2 to get list";
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
            BindingNavigatorFind.Size = new Size(134, 22);
            BindingNavigatorFind.Text = "&Find Customer Sales";
            BindingNavigatorFind.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorFind.ToolTipText = "Click to Find Customer Sale";
            // 
            // BindingNavigatorSeparator3
            // 
            BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3";
            BindingNavigatorSeparator3.Size = new Size(6, 25);
            BindingNavigatorSeparator3.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorClose
            // 
            BindingNavigatorClose.Image = My.Resources.Resources.remove2;
            BindingNavigatorClose.ImageTransparentColor = Color.Magenta;
            BindingNavigatorClose.Name = "BindingNavigatorClose";
            BindingNavigatorClose.Size = new Size(56, 22);
            BindingNavigatorClose.Text = "&Close";
            BindingNavigatorClose.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorClose.ToolTipText = "Quit from window";
            // 
            // BindingNavigatorSeparator5
            // 
            BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5";
            BindingNavigatorSeparator5.Size = new Size(6, 25);
            BindingNavigatorSeparator5.TextDirection = ToolStripTextDirection.Vertical90;
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
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 25);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(937, 42);
            Panel2.TabIndex = 29;
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
            Label3.Location = new Point(286, 13);
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
            // colSaleID
            // 
            colSaleID.DataPropertyName = "SaleID";
            colSaleID.HeaderText = "Invoice #";
            colSaleID.Name = "colSaleID";
            colSaleID.ReadOnly = true;
            colSaleID.Width = 75;
            // 
            // colCustID
            // 
            colCustID.DataPropertyName = "CustomerID";
            colCustID.HeaderText = "Customer ID";
            colCustID.Name = "colCustID";
            colCustID.ReadOnly = true;
            colCustID.Width = 75;
            // 
            // colSequence
            // 
            colSequence.DataPropertyName = "SequenceID";
            colSequence.HeaderText = "Sequence #";
            colSequence.Name = "colSequence";
            colSequence.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "CustomerName";
            colName.HeaderText = "Customer Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 140;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "STOCKDESC";
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Width = 185;
            // 
            // colPack
            // 
            colPack.DataPropertyName = "SalePack";
            colPack.HeaderText = "Pack";
            colPack.Name = "colPack";
            colPack.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "UnitCost";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "QTY";
            colQuantity.HeaderText = "Qty";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 50;
            // 
            // colSubTotal
            // 
            colSubTotal.DataPropertyName = "PRICE";
            colSubTotal.HeaderText = "Sub Total";
            colSubTotal.Name = "colSubTotal";
            colSubTotal.ReadOnly = true;
            // 
            // frmCustPurchases
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 596);
            Controls.Add(SaleDataGrid);
            Controls.Add(Panel2);
            Controls.Add(CustomerBindingNavigator);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            Name = "frmCustPurchases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Customer Purchases";
            ((System.ComponentModel.ISupportInitialize)SaleDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataTable2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerBindingNavigator).EndInit();
            CustomerBindingNavigator.ResumeLayout(false);
            CustomerBindingNavigator.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            KeyUp += new KeyEventHandler(frmCustPurchases_KeyUp);
            Load += new EventHandler(frmCustPurchases_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal DataGridView SaleDataGrid;
        internal BindingNavigator CustomerBindingNavigator;
        internal BindingSource CustomerBindingSource;
        internal DataSet CustomerDataSet;
        internal DataTable DataTable2;
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal ToolStripTextBox BindingNavigatorTextBox;
        internal ToolStripSeparator BindingNavigatorSeparator4;
        internal ToolStripButton BindingNavigatorFind;
        internal ToolStripSeparator BindingNavigatorSeparator3;
        internal ToolStripButton BindingNavigatorClose;
        internal ToolStripSeparator BindingNavigatorSeparator5;
        internal ToolTip ToolTip1;
        internal Panel Panel2;
        internal Button cmdPreview;
        internal Label Label3;
        internal DateTimePicker ToDateTime;
        internal DateTimePicker FromDateTime;
        internal Label Label2;
        internal DataGridViewTextBoxColumn colSaleID;
        internal DataGridViewTextBoxColumn colCustID;
        internal DataGridViewTextBoxColumn colSequence;
        internal DataGridViewTextBoxColumn colName;
        internal DataGridViewTextBoxColumn colDescription;
        internal DataGridViewTextBoxColumn colPack;
        internal DataGridViewTextBoxColumn colPrice;
        internal DataGridViewTextBoxColumn colQuantity;
        internal DataGridViewTextBoxColumn colSubTotal;
    }
}