using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ProductsOld : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsOld));
            Label1 = new Label();
            ProductBindingSource = new BindingSource(components);
            ProductDataSet = new DataSet();
            DataTable2 = new DataTable();
            cmdMin = new Button();
            cmdMin.Click += new EventHandler(cmdMin_Click);
            ToolTip1 = new ToolTip(components);
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            SplitContainer1 = new SplitContainer();
            txtCatg = new ComboBox();
            txtCode = new TextBox();
            txtCode.GotFocus += new EventHandler(txtCode_GotFocus);
            txtCode.KeyPress += new KeyPressEventHandler(txtCode_KeyPress);
            txtCode.LostFocus += new EventHandler(txtCode_LostFocus);
            Label2 = new Label();
            txtPPrice = new TextBox();
            txtPPrice.GotFocus += new EventHandler(txtPPrice_GotFocus);
            txtPPrice.LostFocus += new EventHandler(txtPPrice_LostFocus);
            Label6 = new Label();
            txtSalePrice = new TextBox();
            txtSalePrice.KeyDown += new KeyEventHandler(txtSalePrice_KeyDown);
            txtSalePrice.KeyPress += new KeyPressEventHandler(txtSalePrice_KeyPress);
            txtSalePrice.GotFocus += new EventHandler(txtSalePrice_GotFocus);
            txtSalePrice.LostFocus += new EventHandler(txtSalePrice_LostFocus);
            Label19 = new Label();
            txtMargin = new TextBox();
            txtMargin.GotFocus += new EventHandler(txtMargin_GotFocus);
            txtMargin.KeyPress += new KeyPressEventHandler(txtMargin_KeyPress);
            txtMargin.LostFocus += new EventHandler(txtMargin_LostFocus);
            Label18 = new Label();
            txtPck = new TextBox();
            txtPck.GotFocus += new EventHandler(txtPck_GotFocus);
            txtPck.KeyPress += new KeyPressEventHandler(txtPck_KeyPress);
            txtPck.LostFocus += new EventHandler(txtPck_LostFocus);
            Label5 = new Label();
            Label4 = new Label();
            txtDesc = new TextBox();
            txtDesc.GotFocus += new EventHandler(txtDesc_GotFocus);
            txtDesc.KeyPress += new KeyPressEventHandler(txtDesc_KeyPress);
            txtDesc.LostFocus += new EventHandler(txtDesc_LostFocus);
            Label3 = new Label();
            ProductDataGridView = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            BindingNavigator = new BindingNavigator(components);
            BindingNavigatorAddNewItem = new ToolStripButton();
            BindingNavigatorAddNewItem.Click += new EventHandler(BindingNavigatorAddNewItem_Click);
            BindingNavigatorCountItem = new ToolStripLabel();
            BindingNavigatorDeleteItem = new ToolStripButton();
            BindingNavigatorDeleteItem.Click += new EventHandler(BindingNavigatorDeleteItem_Click);
            BindingNavigatorMoveFirstItem = new ToolStripButton();
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorPositionItem = new ToolStripTextBox();
            BindingNavigatorSeparator1 = new ToolStripSeparator();
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorMoveLastItem = new ToolStripButton();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            BindingNavigatorFindItem = new ToolStripButton();
            BindingNavigatorFindItem.Click += new EventHandler(BindingNavigatorFindItem_Click);
            ToolStripSeparator4 = new ToolStripSeparator();
            ToolStripSeparator1 = new ToolStripSeparator();
            ToolStripSeparator2 = new ToolStripSeparator();
            BindingNavigatorEditItem = new ToolStripButton();
            BindingNavigatorEditItem.Click += new EventHandler(BindingNavigatorEditItem_Click);
            ToolStripSeparator3 = new ToolStripSeparator();
            BindingNavigatorSaveItem = new ToolStripButton();
            BindingNavigatorSaveItem.Click += new EventHandler(BindingNavigatorSaveItem_Click);
            ((System.ComponentModel.ISupportInitialize)ProductBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataTable2).BeginInit();
            SplitContainer1.Panel1.SuspendLayout();
            SplitContainer1.Panel2.SuspendLayout();
            SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingNavigator).BeginInit();
            BindingNavigator.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Red;
            Label1.Location = new Point(6, 4);
            Label1.Name = "Label1";
            Label1.Size = new Size(130, 31);
            Label1.TabIndex = 15;
            Label1.Text = "Products";
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
            cmdClose.TabIndex = 14;
            cmdClose.TabStop = false;
            cmdClose.Text = "X";
            cmdClose.TextAlign = ContentAlignment.MiddleLeft;
            cmdClose.UseVisualStyleBackColor = false;
            // 
            // SplitContainer1
            // 
            SplitContainer1.Location = new Point(3, 44);
            SplitContainer1.Name = "SplitContainer1";
            SplitContainer1.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            SplitContainer1.Panel1.BackColor = Color.Gray;
            SplitContainer1.Panel1.Controls.Add(txtCatg);
            SplitContainer1.Panel1.Controls.Add(txtCode);
            SplitContainer1.Panel1.Controls.Add(Label2);
            SplitContainer1.Panel1.Controls.Add(txtPPrice);
            SplitContainer1.Panel1.Controls.Add(Label6);
            SplitContainer1.Panel1.Controls.Add(txtSalePrice);
            SplitContainer1.Panel1.Controls.Add(Label19);
            SplitContainer1.Panel1.Controls.Add(txtMargin);
            SplitContainer1.Panel1.Controls.Add(Label18);
            SplitContainer1.Panel1.Controls.Add(txtPck);
            SplitContainer1.Panel1.Controls.Add(Label5);
            SplitContainer1.Panel1.Controls.Add(Label4);
            SplitContainer1.Panel1.Controls.Add(txtDesc);
            SplitContainer1.Panel1.Controls.Add(Label3);
            SplitContainer1.Panel1.Enabled = false;
            // 
            // SplitContainer1.Panel2
            // 
            SplitContainer1.Panel2.Controls.Add(ProductDataGridView);
            SplitContainer1.Size = new Size(975, 574);
            SplitContainer1.SplitterDistance = 95;
            SplitContainer1.TabIndex = 18;
            SplitContainer1.TabStop = false;
            // 
            // txtCatg
            // 
            txtCatg.BackColor = Color.SteelBlue;
            txtCatg.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCatg.FlatStyle = FlatStyle.Flat;
            txtCatg.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCatg.ForeColor = Color.White;
            txtCatg.FormattingEnabled = true;
            txtCatg.Items.AddRange(new object[] { "Appetizer", "Beef", "Beverages", "Chicken", "Deserts", "Fast Food", "Fish", "Mutton", "Salads", "Sea Food", "Wraps" });
            txtCatg.Location = new Point(120, 56);
            txtCatg.Name = "txtCatg";
            txtCatg.Size = new Size(190, 23);
            txtCatg.Sorted = true;
            txtCatg.TabIndex = 3;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.SteelBlue;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCode.ForeColor = Color.White;
            txtCode.Location = new Point(120, 20);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(190, 21);
            txtCode.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.Yellow;
            Label2.Location = new Point(45, 22);
            Label2.Name = "Label2";
            Label2.Size = new Size(69, 16);
            Label2.TabIndex = 97;
            Label2.Text = "Item Code";
            // 
            // txtPPrice
            // 
            txtPPrice.BackColor = Color.SteelBlue;
            txtPPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPPrice.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPPrice.ForeColor = Color.White;
            txtPPrice.Location = new Point(548, 56);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(66, 20);
            txtPPrice.TabIndex = 5;
            txtPPrice.Text = "0";
            txtPPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.Yellow;
            Label6.Location = new Point(491, 58);
            Label6.Name = "Label6";
            Label6.Size = new Size(54, 16);
            Label6.TabIndex = 95;
            Label6.Text = "P. Price";
            // 
            // txtSalePrice
            // 
            txtSalePrice.BackColor = Color.SteelBlue;
            txtSalePrice.BorderStyle = BorderStyle.FixedSingle;
            txtSalePrice.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalePrice.ForeColor = Color.White;
            txtSalePrice.Location = new Point(833, 56);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(63, 20);
            txtSalePrice.TabIndex = 7;
            txtSalePrice.Text = "0";
            txtSalePrice.TextAlign = HorizontalAlignment.Center;
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label19.ForeColor = Color.Yellow;
            Label19.Location = new Point(760, 58);
            Label19.Name = "Label19";
            Label19.Size = new Size(70, 16);
            Label19.TabIndex = 90;
            Label19.Text = "Sale Price";
            // 
            // txtMargin
            // 
            txtMargin.BackColor = Color.SteelBlue;
            txtMargin.BorderStyle = BorderStyle.FixedSingle;
            txtMargin.Enabled = false;
            txtMargin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMargin.ForeColor = Color.White;
            txtMargin.Location = new Point(678, 56);
            txtMargin.Name = "txtMargin";
            txtMargin.Size = new Size(72, 20);
            txtMargin.TabIndex = 6;
            txtMargin.Text = "0";
            txtMargin.TextAlign = HorizontalAlignment.Center;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Enabled = false;
            Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label18.ForeColor = Color.Yellow;
            Label18.Location = new Point(627, 58);
            Label18.Name = "Label18";
            Label18.Size = new Size(49, 16);
            Label18.TabIndex = 89;
            Label18.Text = "Margin";
            // 
            // txtPck
            // 
            txtPck.BackColor = Color.SteelBlue;
            txtPck.BorderStyle = BorderStyle.FixedSingle;
            txtPck.CharacterCasing = CharacterCasing.Upper;
            txtPck.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPck.ForeColor = Color.White;
            txtPck.Location = new Point(407, 56);
            txtPck.Name = "txtPck";
            txtPck.Size = new Size(72, 21);
            txtPck.TabIndex = 4;
            txtPck.TextAlign = HorizontalAlignment.Center;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.Yellow;
            Label5.Location = new Point(373, 58);
            Label5.Name = "Label5";
            Label5.Size = new Size(31, 16);
            Label5.TabIndex = 74;
            Label5.Text = "Unit";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.Yellow;
            Label4.Location = new Point(51, 58);
            Label4.Name = "Label4";
            Label4.Size = new Size(63, 16);
            Label4.TabIndex = 71;
            Label4.Text = "Category";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.SteelBlue;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDesc.ForeColor = Color.White;
            txtDesc.Location = new Point(407, 20);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(489, 21);
            txtDesc.TabIndex = 2;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Yellow;
            Label3.Location = new Point(328, 22);
            Label3.Name = "Label3";
            Label3.Size = new Size(76, 16);
            Label3.TabIndex = 67;
            Label3.Text = "Description";
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
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn21, DataGridViewTextBoxColumn22, DataGridViewTextBoxColumn5 });
            ProductDataGridView.DataMember = "PRODUCTS";
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
            ProductDataGridView.Size = new Size(975, 475);
            ProductDataGridView.TabIndex = 11;
            ProductDataGridView.TabStop = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn1.DataPropertyName = "PROD_CD";
            DataGridViewTextBoxColumn1.HeaderText = "Product Code";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn2.DataPropertyName = "PROD_DESC";
            DataGridViewTextBoxColumn2.HeaderText = "Description";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn3.DataPropertyName = "PROD_CATG";
            DataGridViewTextBoxColumn3.HeaderText = "Category";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn6.DataPropertyName = "PROD_PACK";
            DataGridViewTextBoxColumn6.HeaderText = "Packing";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn7.DataPropertyName = "PROD_PPRICE";
            DataGridViewTextBoxColumn7.HeaderText = "P. Price";
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn21
            // 
            DataGridViewTextBoxColumn21.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn21.DataPropertyName = "PROD_PROFIT";
            DataGridViewTextBoxColumn21.HeaderText = "Profit Margin";
            DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
            DataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn22
            // 
            DataGridViewTextBoxColumn22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn22.DataPropertyName = "PROD_SPRICE";
            DataGridViewTextBoxColumn22.HeaderText = "Sale Price";
            DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
            DataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewTextBoxColumn5.DataPropertyName = "PROD_DATE";
            DataGridViewTextBoxColumn5.HeaderText = "Update On";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // BindingNavigator
            // 
            BindingNavigator.AddNewItem = BindingNavigatorAddNewItem;
            BindingNavigator.BindingSource = ProductBindingSource;
            BindingNavigator.CountItem = BindingNavigatorCountItem;
            BindingNavigator.DeleteItem = BindingNavigatorDeleteItem;
            BindingNavigator.Dock = DockStyle.None;
            BindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMoveFirstItem, BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorPositionItem, BindingNavigatorCountItem, BindingNavigatorSeparator1, BindingNavigatorMoveNextItem, BindingNavigatorMoveLastItem, BindingNavigatorSeparator2, BindingNavigatorFindItem, ToolStripSeparator4, BindingNavigatorAddNewItem, ToolStripSeparator1, BindingNavigatorDeleteItem, ToolStripSeparator2, BindingNavigatorEditItem, ToolStripSeparator3, BindingNavigatorSaveItem });
            BindingNavigator.Location = new Point(285, 10);
            BindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem;
            BindingNavigator.MoveLastItem = BindingNavigatorMoveLastItem;
            BindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            BindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            BindingNavigator.Name = "BindingNavigator";
            BindingNavigator.PositionItem = BindingNavigatorPositionItem;
            BindingNavigator.Size = new Size(607, 25);
            BindingNavigator.TabIndex = 19;
            BindingNavigator.Text = "BindingNavigator";
            // 
            // BindingNavigatorAddNewItem
            // 
            BindingNavigatorAddNewItem.Image = My.Resources.Resources.data_add;
            BindingNavigatorAddNewItem.ImageTransparentColor = Color.Magenta;
            BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            BindingNavigatorAddNewItem.Size = new Size(76, 22);
            BindingNavigatorAddNewItem.Text = "&Add New";
            // 
            // BindingNavigatorCountItem
            // 
            BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            BindingNavigatorCountItem.Size = new Size(35, 22);
            BindingNavigatorCountItem.Text = "of {0}";
            BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorDeleteItem
            // 
            BindingNavigatorDeleteItem.Image = (Image)resources.GetObject("BindingNavigatorDeleteItem.Image");
            BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorDeleteItem.Size = new Size(60, 22);
            BindingNavigatorDeleteItem.Text = "&Delete";
            BindingNavigatorDeleteItem.ToolTipText = "Delete product";
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
            // BindingNavigatorSeparator2
            // 
            BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            BindingNavigatorSeparator2.Size = new Size(6, 25);
            // 
            // BindingNavigatorFindItem
            // 
            BindingNavigatorFindItem.Image = My.Resources.Resources.search1;
            BindingNavigatorFindItem.ImageTransparentColor = Color.Magenta;
            BindingNavigatorFindItem.Name = "BindingNavigatorFindItem";
            BindingNavigatorFindItem.Size = new Size(95, 22);
            BindingNavigatorFindItem.Text = "&Find Product";
            BindingNavigatorFindItem.ToolTipText = "Find product by code";
            // 
            // ToolStripSeparator4
            // 
            ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator4.Size = new Size(6, 25);
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 25);
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 25);
            // 
            // BindingNavigatorEditItem
            // 
            BindingNavigatorEditItem.Image = My.Resources.Resources.data_edit;
            BindingNavigatorEditItem.ImageTransparentColor = Color.Magenta;
            BindingNavigatorEditItem.Name = "BindingNavigatorEditItem";
            BindingNavigatorEditItem.Size = new Size(92, 22);
            BindingNavigatorEditItem.Text = "&Edit Product";
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator3.Size = new Size(6, 25);
            // 
            // BindingNavigatorSaveItem
            // 
            BindingNavigatorSaveItem.Image = My.Resources.Resources.saveHS;
            BindingNavigatorSaveItem.ImageTransparentColor = Color.Magenta;
            BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            BindingNavigatorSaveItem.Size = new Size(51, 22);
            BindingNavigatorSaveItem.Text = "&Save";
            BindingNavigatorSaveItem.ToolTipText = "Save product changes";
            // 
            // frmProductsOld
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(982, 621);
            Controls.Add(BindingNavigator);
            Controls.Add(SplitContainer1);
            Controls.Add(Label1);
            Controls.Add(cmdMin);
            Controls.Add(cmdClose);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmProductsOld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)ProductBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataTable2).EndInit();
            SplitContainer1.Panel1.ResumeLayout(false);
            SplitContainer1.Panel1.PerformLayout();
            SplitContainer1.Panel2.ResumeLayout(false);
            SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BindingNavigator).EndInit();
            BindingNavigator.ResumeLayout(false);
            BindingNavigator.PerformLayout();
            MouseDown += new MouseEventHandler(frmProducts_MouseDown);
            MouseMove += new MouseEventHandler(frmProducts_MouseMove);
            MouseUp += new MouseEventHandler(frmProducs_MouseUp);
            Load += new EventHandler(frmProducts_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal BindingSource ProductBindingSource;
        internal DataSet ProductDataSet;
        internal DataTable DataTable2;
        internal Button cmdMin;
        internal ToolTip ToolTip1;
        internal Button cmdClose;
        internal SplitContainer SplitContainer1;
        internal DataGridView ProductDataGridView;
        internal TextBox txtSalePrice;
        internal Label Label19;
        internal TextBox txtMargin;
        internal Label Label18;
        internal TextBox txtPck;
        internal Label Label5;
        internal Label Label4;
        internal TextBox txtDesc;
        internal Label Label3;
        internal TextBox txtPPrice;
        internal Label Label6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn21;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn22;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal BindingNavigator BindingNavigator;
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
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripButton BindingNavigatorEditItem;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripButton BindingNavigatorSaveItem;
        internal ToolStripButton BindingNavigatorFindItem;
        internal ToolStripSeparator ToolStripSeparator4;
        internal TextBox txtCode;
        internal Label Label2;
        internal ComboBox txtCatg;
        internal ToolStripButton BindingNavigatorAddNewItem;
    }
}