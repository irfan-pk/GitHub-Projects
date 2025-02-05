using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Product : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtCatg = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtPck = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.UserDataSet = new System.Data.DataSet();
            this.DataTable1 = new System.Data.DataTable();
            this.BindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ToolStripEditButton = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.UserBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.UserbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripFindButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripCloseButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingNavigator)).BeginInit();
            this.UserBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.txtCatg);
            this.Panel1.Controls.Add(this.txtCode);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.txtPPrice);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.txtSalePrice);
            this.Panel1.Controls.Add(this.Label19);
            this.Panel1.Controls.Add(this.txtMargin);
            this.Panel1.Controls.Add(this.Label18);
            this.Panel1.Controls.Add(this.txtPck);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.txtDesc);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 25);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(972, 88);
            this.Panel1.TabIndex = 6;
            // 
            // txtCatg
            // 
            this.txtCatg.BackColor = System.Drawing.Color.White;
            this.txtCatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatg.ForeColor = System.Drawing.Color.Black;
            this.txtCatg.FormattingEnabled = true;
            this.txtCatg.Items.AddRange(new object[] {
            "Appetizers",
            "Break Fast",
            "Chicken",
            "Fast Food",
            "Fish",
            "Mutton",
            "Salads",
            "Sea Food"});
            this.txtCatg.Location = new System.Drawing.Point(135, 50);
            this.txtCatg.Name = "txtCatg";
            this.txtCatg.Size = new System.Drawing.Size(190, 23);
            this.txtCatg.Sorted = true;
            this.txtCatg.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(135, 14);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(99, 21);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Yellow;
            this.Label2.Location = new System.Drawing.Point(60, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 16);
            this.Label2.TabIndex = 111;
            this.Label2.Text = "Item Code";
            // 
            // txtPPrice
            // 
            this.txtPPrice.BackColor = System.Drawing.Color.White;
            this.txtPPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPPrice.Location = new System.Drawing.Point(563, 50);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.ReadOnly = true;
            this.txtPPrice.Size = new System.Drawing.Size(66, 20);
            this.txtPPrice.TabIndex = 4;
            this.txtPPrice.Text = "0";
            this.txtPPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Yellow;
            this.Label6.Location = new System.Drawing.Point(506, 52);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 16);
            this.Label6.TabIndex = 110;
            this.Label6.Text = "P. Price";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BackColor = System.Drawing.Color.White;
            this.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.ForeColor = System.Drawing.Color.Black;
            this.txtSalePrice.Location = new System.Drawing.Point(848, 50);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.ReadOnly = true;
            this.txtSalePrice.Size = new System.Drawing.Size(63, 20);
            this.txtSalePrice.TabIndex = 6;
            this.txtSalePrice.Text = "0";
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalePrice_KeyDown);
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.Color.Yellow;
            this.Label19.Location = new System.Drawing.Point(775, 52);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(69, 16);
            this.Label19.TabIndex = 109;
            this.Label19.Text = "Sale Price";
            // 
            // txtMargin
            // 
            this.txtMargin.BackColor = System.Drawing.Color.White;
            this.txtMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMargin.Enabled = false;
            this.txtMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargin.ForeColor = System.Drawing.Color.Black;
            this.txtMargin.Location = new System.Drawing.Point(693, 50);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.ReadOnly = true;
            this.txtMargin.Size = new System.Drawing.Size(72, 20);
            this.txtMargin.TabIndex = 5;
            this.txtMargin.Text = "0";
            this.txtMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMargin_KeyPress);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Enabled = false;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.Color.Yellow;
            this.Label18.Location = new System.Drawing.Point(642, 52);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(48, 16);
            this.Label18.TabIndex = 108;
            this.Label18.Text = "Margin";
            // 
            // txtPck
            // 
            this.txtPck.BackColor = System.Drawing.Color.White;
            this.txtPck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPck.ForeColor = System.Drawing.Color.Black;
            this.txtPck.Location = new System.Drawing.Point(422, 50);
            this.txtPck.Name = "txtPck";
            this.txtPck.Size = new System.Drawing.Size(72, 21);
            this.txtPck.TabIndex = 3;
            this.txtPck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPck_KeyPress);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Yellow;
            this.Label5.Location = new System.Drawing.Point(388, 52);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(30, 16);
            this.Label5.TabIndex = 107;
            this.Label5.Text = "Unit";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Yellow;
            this.Label4.Location = new System.Drawing.Point(66, 52);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(62, 16);
            this.Label4.TabIndex = 106;
            this.Label4.Text = "Category";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Location = new System.Drawing.Point(422, 14);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(489, 21);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Yellow;
            this.Label3.Location = new System.Drawing.Point(343, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 16);
            this.Label3.TabIndex = 105;
            this.Label3.Text = "Description";
            // 
            // UserDataSet
            // 
            this.UserDataSet.DataSetName = "UserDataSet";
            this.UserDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.DataTable1});
            // 
            // DataTable1
            // 
            this.DataTable1.TableName = "USERS";
            // 
            // BindingNavigatorAddNewItem
            // 
            this.BindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorAddNewItem.Image")));
            this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            this.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorAddNewItem.Size = new System.Drawing.Size(84, 22);
            this.BindingNavigatorAddNewItem.Text = "&Add new";
            this.BindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // ToolStripEditButton
            // 
            this.ToolStripEditButton.Image = global::POS_System.My.Resources.Resources.data_edit2;
            this.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripEditButton.Name = "ToolStripEditButton";
            this.ToolStripEditButton.Size = new System.Drawing.Size(51, 22);
            this.ToolStripEditButton.Text = "&Edit";
            this.ToolStripEditButton.Click += new System.EventHandler(this.ToolStripEditButton_Click);
            // 
            // BindingNavigatorDeleteItem
            // 
            this.BindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorDeleteItem.Image")));
            this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 22);
            this.BindingNavigatorDeleteItem.Text = "&Delete";
            this.BindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // ToolStripSaveButton
            // 
            this.ToolStripSaveButton.Enabled = false;
            this.ToolStripSaveButton.Image = global::POS_System.My.Resources.Resources.saveHS2;
            this.ToolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSaveButton.Name = "ToolStripSaveButton";
            this.ToolStripSaveButton.Size = new System.Drawing.Size(60, 22);
            this.ToolStripSaveButton.Text = "&Save";
            this.ToolStripSaveButton.Click += new System.EventHandler(this.ToolStripSaveButton_Click);
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.BindingNavigatorPositionItem.Text = "1";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(48, 22);
            this.BindingNavigatorCountItem.Text = "of {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // UserBindingNavigator
            // 
            this.UserBindingNavigator.AddNewItem = this.BindingNavigatorAddNewItem;
            this.UserBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.UserBindingNavigator.BindingSource = this.UserbindingSource;
            this.UserBindingNavigator.CountItem = this.BindingNavigatorCountItem;
            this.UserBindingNavigator.DeleteItem = this.BindingNavigatorDeleteItem;
            this.UserBindingNavigator.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.ToolStripFindButton,
            this.ToolStripSeparator6,
            this.BindingNavigatorAddNewItem,
            this.ToolStripSeparator2,
            this.BindingNavigatorDeleteItem,
            this.ToolStripSeparator3,
            this.ToolStripEditButton,
            this.ToolStripSeparator1,
            this.ToolStripSaveButton,
            this.ToolStripSeparator4,
            this.ToolStripCloseButton,
            this.ToolStripSeparator5});
            this.UserBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.UserBindingNavigator.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.UserBindingNavigator.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.UserBindingNavigator.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.UserBindingNavigator.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.UserBindingNavigator.Name = "UserBindingNavigator";
            this.UserBindingNavigator.PositionItem = this.BindingNavigatorPositionItem;
            this.UserBindingNavigator.Size = new System.Drawing.Size(972, 25);
            this.UserBindingNavigator.TabIndex = 4;
            this.UserBindingNavigator.Text = "BindingNavigator1";
            // 
            // UserbindingSource
            // 
            this.UserbindingSource.DataSource = this.UserDataSet;
            this.UserbindingSource.Position = 0;
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripFindButton
            // 
            this.ToolStripFindButton.Image = global::POS_System.My.Resources.Resources.search1;
            this.ToolStripFindButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripFindButton.Name = "ToolStripFindButton";
            this.ToolStripFindButton.Size = new System.Drawing.Size(91, 22);
            this.ToolStripFindButton.Text = "Find Item";
            this.ToolStripFindButton.ToolTipText = "Find Item by code";
            this.ToolStripFindButton.Click += new System.EventHandler(this.ToolStripFindButton_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripCloseButton
            // 
            this.ToolStripCloseButton.Image = global::POS_System.My.Resources.Resources.remove1;
            this.ToolStripCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCloseButton.Name = "ToolStripCloseButton";
            this.ToolStripCloseButton.Size = new System.Drawing.Size(62, 22);
            this.ToolStripCloseButton.Text = "&Close";
            this.ToolStripCloseButton.Click += new System.EventHandler(this.ToolStripCloseButton_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.AllowUserToResizeColumns = false;
            this.UsersDataGridView.AllowUserToResizeRows = false;
            this.UsersDataGridView.AutoGenerateColumns = false;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.DimGray;
            this.UsersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGridView.ColumnHeadersHeight = 28;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.colName,
            this.UserType,
            this.UserStatus,
            this.colNIC,
            this.colSPrice,
            this.colDate});
            this.UsersDataGridView.DataSource = this.UserbindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersDataGridView.EnableHeadersVisualStyles = false;
            this.UsersDataGridView.Location = new System.Drawing.Point(0, 113);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersVisible = false;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(972, 498);
            this.UsersDataGridView.TabIndex = 5;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "PROD_CD";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UserId.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserId.HeaderText = "Item Code";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "prod_desc";
            this.UserName.HeaderText = "Item Desc";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "prod_catg";
            this.colName.HeaderText = "Category";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // UserType
            // 
            this.UserType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserType.DataPropertyName = "prod_pack";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.UserType.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserType.HeaderText = "Unit";
            this.UserType.Name = "UserType";
            this.UserType.ReadOnly = true;
            // 
            // UserStatus
            // 
            this.UserStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserStatus.DataPropertyName = "prod_pprice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.UserStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.UserStatus.HeaderText = "P. Price";
            this.UserStatus.Name = "UserStatus";
            this.UserStatus.ReadOnly = true;
            // 
            // colNIC
            // 
            this.colNIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNIC.DataPropertyName = "prod_profit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colNIC.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNIC.HeaderText = "Margin";
            this.colNIC.Name = "colNIC";
            this.colNIC.ReadOnly = true;
            // 
            // colSPrice
            // 
            this.colSPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSPrice.DataPropertyName = "prod_pprice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSPrice.HeaderText = "Price";
            this.colSPrice.Name = "colSPrice";
            this.colSPrice.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.DataPropertyName = "prod_upd_on";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDate.HeaderText = "Update On";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 611);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.UserBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSysUser_KeyUp);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingNavigator)).EndInit();
            this.UserBindingNavigator.ResumeLayout(false);
            this.UserBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Panel Panel1;
        internal DataSet UserDataSet;
        internal DataTable DataTable1;
        internal ToolStripButton BindingNavigatorAddNewItem;
        internal ToolStripButton ToolStripEditButton;
        internal ToolStripButton BindingNavigatorDeleteItem;
        internal ToolStripButton BindingNavigatorMoveLastItem;
        internal ToolStripButton ToolStripSaveButton;
        internal ToolStripButton BindingNavigatorMoveFirstItem;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal ToolStripTextBox BindingNavigatorPositionItem;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripSeparator BindingNavigatorSeparator1;
        internal ToolStripLabel BindingNavigatorCountItem;
        internal BindingNavigator UserBindingNavigator;
        internal BindingSource UserbindingSource;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripButton ToolStripCloseButton;
        internal ToolStripSeparator ToolStripSeparator5;
        internal DataGridView UsersDataGridView;
        internal ComboBox txtCatg;
        internal TextBox txtCode;
        internal Label Label2;
        internal TextBox txtPPrice;
        internal Label Label6;
        internal TextBox txtSalePrice;
        internal Label Label19;
        internal TextBox txtMargin;
        internal Label Label18;
        internal TextBox txtPck;
        internal Label Label5;
        internal Label Label4;
        internal TextBox txtDesc;
        internal Label Label3;
        internal DataGridViewTextBoxColumn UserId;
        internal DataGridViewTextBoxColumn UserName;
        internal DataGridViewTextBoxColumn colName;
        internal DataGridViewTextBoxColumn UserType;
        internal DataGridViewTextBoxColumn UserStatus;
        internal DataGridViewTextBoxColumn colNIC;
        internal DataGridViewTextBoxColumn colSPrice;
        internal DataGridViewTextBoxColumn colDate;
        internal ToolStripButton ToolStripFindButton;
        internal ToolStripSeparator ToolStripSeparator6;
    }
}