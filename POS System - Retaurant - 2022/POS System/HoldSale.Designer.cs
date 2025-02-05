using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class HoldSale : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(HoldSale));
            SaleDataGrid = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colSubTotal = new DataGridViewTextBoxColumn();
            SaleBindingSource = new BindingSource(components);
            RecordDataSet = new DataSet();
            dgHoldInfo = new DataGridView();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            HoldBindingSource = new BindingSource(components);
            HoldDataSet = new DataSet();
            HoldBindingNavigator = new BindingNavigator(components);
            BindingNavigatorCountItem = new ToolStripLabel();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorPositionItem = new ToolStripTextBox();
            BindingNavigatorSeparator1 = new ToolStripSeparator();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            BindingNavigatorAddNewItem = new ToolStripButton();
            BindingNavigatorDeleteItem = new ToolStripButton();
            BindingNavigatorMoveFirstItem = new ToolStripButton();
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorMoveLastItem = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)SaleDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SaleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecordDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgHoldInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HoldBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HoldDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HoldBindingNavigator).BeginInit();
            HoldBindingNavigator.SuspendLayout();
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
            SaleDataGrid.Columns.AddRange(new DataGridViewColumn[] { colID, colDescription, colPrice, colQuantity, colSubTotal });
            SaleDataGrid.DataSource = SaleBindingSource;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.Gray;
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.Yellow;
            DataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            DataGridViewCellStyle1.SelectionForeColor = Color.Yellow;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            SaleDataGrid.DefaultCellStyle = DataGridViewCellStyle1;
            SaleDataGrid.Dock = DockStyle.Bottom;
            SaleDataGrid.Location = new Point(0, 139);
            SaleDataGrid.Name = "SaleDataGrid";
            SaleDataGrid.ReadOnly = true;
            SaleDataGrid.RowHeadersVisible = false;
            SaleDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SaleDataGrid.Size = new Size(550, 274);
            SaleDataGrid.TabIndex = 2;
            SaleDataGrid.TabStop = false;
            // 
            // colID
            // 
            colID.DataPropertyName = "SaleID";
            colID.HeaderText = "Invoice #";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "STOCKDESC";
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Width = 247;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "UnitCost";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 75;
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
            colSubTotal.Width = 75;
            // 
            // SaleBindingSource
            // 
            SaleBindingSource.DataSource = RecordDataSet;
            SaleBindingSource.Position = 0;
            // 
            // RecordDataSet
            // 
            RecordDataSet.DataSetName = "RecordDataSet";
            // 
            // dgHoldInfo
            // 
            dgHoldInfo.AllowUserToAddRows = false;
            dgHoldInfo.AllowUserToDeleteRows = false;
            dgHoldInfo.AutoGenerateColumns = false;
            dgHoldInfo.BackgroundColor = Color.Gray;
            dgHoldInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgHoldInfo.ColumnHeadersHeight = 22;
            dgHoldInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgHoldInfo.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn1 });
            dgHoldInfo.DataSource = HoldBindingSource;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.Gray;
            DataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            DataGridViewCellStyle2.SelectionForeColor = Color.White;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgHoldInfo.DefaultCellStyle = DataGridViewCellStyle2;
            dgHoldInfo.Dock = DockStyle.Fill;
            dgHoldInfo.Location = new Point(0, 0);
            dgHoldInfo.Name = "dgHoldInfo";
            dgHoldInfo.ReadOnly = true;
            dgHoldInfo.RowHeadersVisible = false;
            dgHoldInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgHoldInfo.Size = new Size(550, 139);
            dgHoldInfo.TabIndex = 1;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "SaleID";
            DataGridViewTextBoxColumn4.HeaderText = "Invoice #";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            DataGridViewTextBoxColumn4.Width = 183;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "SaleType";
            DataGridViewTextBoxColumn1.HeaderText = "Description";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Width = 365;
            // 
            // HoldBindingSource
            // 
            HoldBindingSource.DataSource = HoldDataSet;
            HoldBindingSource.Position = 0;
            // 
            // HoldDataSet
            // 
            HoldDataSet.DataSetName = "HoldDataSet";
            // 
            // HoldBindingNavigator
            // 
            HoldBindingNavigator.AddNewItem = BindingNavigatorAddNewItem;
            HoldBindingNavigator.BindingSource = HoldBindingSource;
            HoldBindingNavigator.CountItem = BindingNavigatorCountItem;
            HoldBindingNavigator.DeleteItem = BindingNavigatorDeleteItem;
            HoldBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMoveFirstItem, BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorPositionItem, BindingNavigatorCountItem, BindingNavigatorSeparator1, BindingNavigatorMoveNextItem, BindingNavigatorMoveLastItem, BindingNavigatorSeparator2, BindingNavigatorAddNewItem, BindingNavigatorDeleteItem });
            HoldBindingNavigator.Location = new Point(0, 0);
            HoldBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem;
            HoldBindingNavigator.MoveLastItem = BindingNavigatorMoveLastItem;
            HoldBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            HoldBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            HoldBindingNavigator.Name = "HoldBindingNavigator";
            HoldBindingNavigator.PositionItem = BindingNavigatorPositionItem;
            HoldBindingNavigator.Size = new Size(550, 25);
            HoldBindingNavigator.TabIndex = 2;
            HoldBindingNavigator.Text = "BindingNavigator";
            HoldBindingNavigator.Visible = false;
            // 
            // BindingNavigatorCountItem
            // 
            BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            BindingNavigatorCountItem.Size = new Size(35, 22);
            BindingNavigatorCountItem.Text = "of {0}";
            BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorSeparator
            // 
            BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            BindingNavigatorSeparator.Size = new Size(6, 25);
            // 
            // BindingNavigatorPositionItem
            // 
            BindingNavigatorPositionItem.AccessibleName = "Position";
            BindingNavigatorPositionItem.AutoSize = false;
            BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            BindingNavigatorPositionItem.Size = new Size(50, 23);
            BindingNavigatorPositionItem.Text = "1";
            BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            BindingNavigatorSeparator1.Size = new Size(6, 25);
            // 
            // BindingNavigatorSeparator2
            // 
            BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            BindingNavigatorSeparator2.Size = new Size(6, 25);
            // 
            // BindingNavigatorAddNewItem
            // 
            BindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorAddNewItem.Image = (Image)resources.GetObject("BindingNavigatorAddNewItem.Image");
            BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorAddNewItem.Size = new Size(23, 22);
            BindingNavigatorAddNewItem.Text = "Add new";
            // 
            // BindingNavigatorDeleteItem
            // 
            BindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorDeleteItem.Image = (Image)resources.GetObject("BindingNavigatorDeleteItem.Image");
            BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorDeleteItem.Size = new Size(23, 22);
            BindingNavigatorDeleteItem.Text = "Delete";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            BindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorMoveFirstItem.Image = (Image)resources.GetObject("BindingNavigatorMoveFirstItem.Image");
            BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMoveFirstItem.Size = new Size(23, 22);
            BindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            BindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorMovePreviousItem.Image = (Image)resources.GetObject("BindingNavigatorMovePreviousItem.Image");
            BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMovePreviousItem.Size = new Size(23, 22);
            BindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // BindingNavigatorMoveNextItem
            // 
            BindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorMoveNextItem.Image = (Image)resources.GetObject("BindingNavigatorMoveNextItem.Image");
            BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMoveNextItem.Size = new Size(23, 22);
            BindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // BindingNavigatorMoveLastItem
            // 
            BindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BindingNavigatorMoveLastItem.Image = (Image)resources.GetObject("BindingNavigatorMoveLastItem.Image");
            BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMoveLastItem.Size = new Size(23, 22);
            BindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // frmHoldSale
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 413);
            ControlBox = false;
            Controls.Add(dgHoldInfo);
            Controls.Add(SaleDataGrid);
            Controls.Add(HoldBindingNavigator);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "frmHoldSale";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Holded Sale";
            ((System.ComponentModel.ISupportInitialize)SaleDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)SaleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecordDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgHoldInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)HoldBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HoldDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)HoldBindingNavigator).EndInit();
            HoldBindingNavigator.ResumeLayout(false);
            HoldBindingNavigator.PerformLayout();
            KeyDown += new KeyEventHandler(frmHoldSale_KeyDown);
            Load += new EventHandler(frmHoldSale_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal DataGridView SaleDataGrid;
        internal BindingSource SaleBindingSource;
        internal DataSet RecordDataSet;
        internal DataGridView dgHoldInfo;
        internal BindingSource HoldBindingSource;
        internal DataSet HoldDataSet;
        internal BindingNavigator HoldBindingNavigator;
        internal ToolStripButton BindingNavigatorAddNewItem;
        internal ToolStripLabel BindingNavigatorCountItem;
        internal ToolStripButton BindingNavigatorDeleteItem;
        internal ToolStripButton BindingNavigatorMoveFirstItem;
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripTextBox BindingNavigatorPositionItem;
        internal ToolStripSeparator BindingNavigatorSeparator1;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripButton BindingNavigatorMoveLastItem;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn colID;
        internal DataGridViewTextBoxColumn colDescription;
        internal DataGridViewTextBoxColumn colPrice;
        internal DataGridViewTextBoxColumn colQuantity;
        internal DataGridViewTextBoxColumn colSubTotal;
    }
}