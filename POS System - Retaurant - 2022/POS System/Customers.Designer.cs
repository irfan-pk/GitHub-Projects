using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Customers : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            Label2 = new Label();
            txtBalance = new TextBox();
            Label6 = new Label();
            Panel1 = new Panel();
            txtMob = new TextBox();
            Label4 = new Label();
            txtCity = new TextBox();
            Label3 = new Label();
            txtAddress = new TextBox();
            Label1 = new Label();
            txtID = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorCountItem = new ToolStripLabel();
            BindingNavigatorPositionItem = new ToolStripTextBox();
            BindingNavigatorSeparator1 = new ToolStripSeparator();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            CompanyBindingNavigator = new BindingNavigator(components);
            BindingNavigatorAddNewItem = new ToolStripButton();
            BindingNavigatorAddNewItem.Click += new EventHandler(BindingNavigatorAddNewItem_Click);
            CompanyBindingSource = new BindingSource(components);
            CompanyDataSet = new DataSet();
            BindingNavigatorDeleteItem = new ToolStripButton();
            BindingNavigatorDeleteItem.Click += new EventHandler(BindingNavigatorDeleteItem_Click);
            BindingNavigatorMoveFirstItem = new ToolStripButton();
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorMoveLastItem = new ToolStripButton();
            ToolStripEditButton = new ToolStripButton();
            ToolStripEditButton.Click += new EventHandler(ToolStripEditButton_Click);
            ToolStripSaveButton = new ToolStripButton();
            ToolStripSaveButton.Click += new EventHandler(ToolStripSaveButton_Click);
            ToolStripCloseButton = new ToolStripButton();
            ToolStripCloseButton.Click += new EventHandler(ToolStripCloseButton_Click);
            ToolStripCloseButton.MouseDown += new MouseEventHandler(ToolStripCloseButton_MouseDown);
            ToolStripCloseButton.MouseMove += new MouseEventHandler(ToolStripCloseButton_MouseMove);
            ToolStripCloseButton.MouseUp += new MouseEventHandler(ToolStripCloseButton_MouseUp);
            CompanyDataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            CP_NAME = new DataGridViewTextBoxColumn();
            Cp_Incharge = new DataGridViewTextBoxColumn();
            colCity = new DataGridViewTextBoxColumn();
            Cp_Tel = new DataGridViewTextBoxColumn();
            Cp_Mob = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colUpdate = new DataGridViewTextBoxColumn();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CompanyBindingNavigator).BeginInit();
            CompanyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CompanyBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompanyDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompanyDataGridView).BeginInit();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.Yellow;
            Label2.Location = new Point(684, 61);
            Label2.Name = "Label2";
            Label2.Size = new Size(53, 13);
            Label2.TabIndex = 41;
            Label2.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.BorderStyle = BorderStyle.FixedSingle;
            txtBalance.Location = new Point(687, 77);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(182, 20);
            txtBalance.TabIndex = 8;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.Yellow;
            Label6.Location = new Point(684, 20);
            Label6.Name = "Label6";
            Label6.Size = new Size(56, 13);
            Label6.TabIndex = 39;
            Label6.Text = "Mobile #";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Gray;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(txtBalance);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(txtMob);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(txtCity);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(txtAddress);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(txtID);
            Panel1.Controls.Add(lblPhone);
            Panel1.Controls.Add(txtPhone);
            Panel1.Controls.Add(lblName);
            Panel1.Controls.Add(txtName);
            Panel1.Dock = DockStyle.Bottom;
            Panel1.Location = new Point(0, 345);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(942, 126);
            Panel1.TabIndex = 43;
            // 
            // txtMob
            // 
            txtMob.BorderStyle = BorderStyle.FixedSingle;
            txtMob.Location = new Point(687, 36);
            txtMob.Name = "txtMob";
            txtMob.Size = new Size(182, 20);
            txtMob.TabIndex = 5;
            txtMob.Text = "00";
            txtMob.TextAlign = HorizontalAlignment.Center;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.Yellow;
            Label4.Location = new Point(505, 61);
            Label4.Name = "Label4";
            Label4.Size = new Size(37, 13);
            Label4.TabIndex = 35;
            Label4.Text = "State";
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Location = new Point(508, 77);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(173, 20);
            txtCity.TabIndex = 7;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Yellow;
            Label3.Location = new Point(69, 61);
            Label3.Name = "Label3";
            Label3.Size = new Size(52, 13);
            Label3.TabIndex = 33;
            Label3.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(72, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(426, 20);
            txtAddress.TabIndex = 6;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Yellow;
            Label1.Location = new Point(67, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(76, 13);
            Label1.TabIndex = 29;
            Label1.Text = "Customer ID";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Enabled = false;
            txtID.Location = new Point(70, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(115, 20);
            txtID.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Yellow;
            lblPhone.Location = new Point(505, 20);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(79, 13);
            lblPhone.TabIndex = 27;
            lblPhone.Text = "Telephone #";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(508, 36);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(173, 20);
            txtPhone.TabIndex = 4;
            txtPhone.Text = "00";
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Yellow;
            lblName.Location = new Point(193, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 13);
            lblName.TabIndex = 25;
            lblName.Text = "Customer Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(196, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(302, 20);
            txtName.TabIndex = 2;
            // 
            // BindingNavigatorSeparator
            // 
            BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            BindingNavigatorSeparator.Size = new Size(6, 25);
            // 
            // BindingNavigatorCountItem
            // 
            BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            BindingNavigatorCountItem.Size = new Size(35, 22);
            BindingNavigatorCountItem.Text = "of {0}";
            BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorPositionItem
            // 
            BindingNavigatorPositionItem.AccessibleName = "Position";
            BindingNavigatorPositionItem.AutoSize = false;
            BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            BindingNavigatorPositionItem.Size = new Size(50, 21);
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
            // CompanyBindingNavigator
            // 
            CompanyBindingNavigator.AddNewItem = BindingNavigatorAddNewItem;
            CompanyBindingNavigator.BackColor = Color.LightSeaGreen;
            CompanyBindingNavigator.BindingSource = CompanyBindingSource;
            CompanyBindingNavigator.CountItem = BindingNavigatorCountItem;
            CompanyBindingNavigator.DeleteItem = BindingNavigatorDeleteItem;
            CompanyBindingNavigator.GripStyle = ToolStripGripStyle.Hidden;
            CompanyBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMoveFirstItem, BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorPositionItem, BindingNavigatorCountItem, BindingNavigatorSeparator1, BindingNavigatorMoveNextItem, BindingNavigatorMoveLastItem, BindingNavigatorSeparator2, BindingNavigatorAddNewItem, ToolStripEditButton, BindingNavigatorDeleteItem, ToolStripSaveButton, ToolStripCloseButton });
            CompanyBindingNavigator.Location = new Point(0, 0);
            CompanyBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem;
            CompanyBindingNavigator.MoveLastItem = BindingNavigatorMoveLastItem;
            CompanyBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            CompanyBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            CompanyBindingNavigator.Name = "CompanyBindingNavigator";
            CompanyBindingNavigator.PositionItem = BindingNavigatorPositionItem;
            CompanyBindingNavigator.Size = new Size(942, 25);
            CompanyBindingNavigator.TabIndex = 44;
            CompanyBindingNavigator.Text = "BindingNavigator1";
            // 
            // BindingNavigatorAddNewItem
            // 
            BindingNavigatorAddNewItem.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BindingNavigatorAddNewItem.ForeColor = Color.Yellow;
            BindingNavigatorAddNewItem.Image = (Image)resources.GetObject("BindingNavigatorAddNewItem.Image");
            BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorAddNewItem.Size = new Size(82, 22);
            BindingNavigatorAddNewItem.Text = "&Add New";
            // 
            // CompanyBindingSource
            // 
            CompanyBindingSource.DataSource = CompanyDataSet;
            CompanyBindingSource.Position = 0;
            // 
            // CompanyDataSet
            // 
            CompanyDataSet.DataSetName = "CompanyDataSet";
            // 
            // BindingNavigatorDeleteItem
            // 
            BindingNavigatorDeleteItem.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BindingNavigatorDeleteItem.ForeColor = Color.Yellow;
            BindingNavigatorDeleteItem.Image = (Image)resources.GetObject("BindingNavigatorDeleteItem.Image");
            BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorDeleteItem.Size = new Size(65, 22);
            BindingNavigatorDeleteItem.Text = "&Delete";
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
            // ToolStripEditButton
            // 
            ToolStripEditButton.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripEditButton.ForeColor = Color.Yellow;
            ToolStripEditButton.Image = My.Resources.Resources._1487899053_Edit_Male_User;
            ToolStripEditButton.ImageTransparentColor = Color.Magenta;
            ToolStripEditButton.Name = "ToolStripEditButton";
            ToolStripEditButton.Size = new Size(50, 22);
            ToolStripEditButton.Text = "&Edit";
            // 
            // ToolStripSaveButton
            // 
            ToolStripSaveButton.Enabled = false;
            ToolStripSaveButton.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripSaveButton.ForeColor = Color.Yellow;
            ToolStripSaveButton.Image = My.Resources.Resources.saveHS;
            ToolStripSaveButton.ImageTransparentColor = Color.Magenta;
            ToolStripSaveButton.Name = "ToolStripSaveButton";
            ToolStripSaveButton.Size = new Size(55, 22);
            ToolStripSaveButton.Text = "&Save";
            // 
            // ToolStripCloseButton
            // 
            ToolStripCloseButton.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripCloseButton.ForeColor = Color.Yellow;
            ToolStripCloseButton.Image = My.Resources.Resources._1480383006_xfce_system_exit2;
            ToolStripCloseButton.ImageTransparentColor = Color.Magenta;
            ToolStripCloseButton.Name = "ToolStripCloseButton";
            ToolStripCloseButton.Size = new Size(60, 22);
            ToolStripCloseButton.Text = "&Close";
            // 
            // CompanyDataGridView
            // 
            CompanyDataGridView.AllowUserToAddRows = false;
            CompanyDataGridView.AllowUserToDeleteRows = false;
            CompanyDataGridView.AutoGenerateColumns = false;
            CompanyDataGridView.BackgroundColor = Color.FromArgb(192, 255, 192);
            CompanyDataGridView.BorderStyle = BorderStyle.Fixed3D;
            CompanyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompanyDataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, CP_NAME, Cp_Incharge, colCity, Cp_Tel, Cp_Mob, colAddress, colUpdate });
            CompanyDataGridView.DataSource = CompanyBindingSource;
            CompanyDataGridView.Dock = DockStyle.Fill;
            CompanyDataGridView.Location = new Point(0, 25);
            CompanyDataGridView.MultiSelect = false;
            CompanyDataGridView.Name = "CompanyDataGridView";
            CompanyDataGridView.ReadOnly = true;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CompanyDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1;
            CompanyDataGridView.RowHeadersVisible = false;
            CompanyDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            CompanyDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Blue;
            CompanyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CompanyDataGridView.Size = new Size(942, 446);
            CompanyDataGridView.TabIndex = 42;
            CompanyDataGridView.TabStop = false;
            // 
            // colID
            // 
            colID.DataPropertyName = "CUST_CODE";
            colID.HeaderText = "Supplier ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // CP_NAME
            // 
            CP_NAME.DataPropertyName = "CUST_Name";
            CP_NAME.HeaderText = "Customer Name";
            CP_NAME.Name = "CP_NAME";
            CP_NAME.ReadOnly = true;
            CP_NAME.Width = 300;
            // 
            // Cp_Incharge
            // 
            Cp_Incharge.DataPropertyName = "Cust_Address";
            Cp_Incharge.HeaderText = "Address";
            Cp_Incharge.Name = "Cp_Incharge";
            Cp_Incharge.ReadOnly = true;
            Cp_Incharge.Width = 200;
            // 
            // colCity
            // 
            colCity.DataPropertyName = "Cust_CITY";
            colCity.HeaderText = "City";
            colCity.Name = "colCity";
            colCity.ReadOnly = true;
            // 
            // Cp_Tel
            // 
            Cp_Tel.DataPropertyName = "Cust_Tel";
            Cp_Tel.HeaderText = "Telephone";
            Cp_Tel.Name = "Cp_Tel";
            Cp_Tel.ReadOnly = true;
            // 
            // Cp_Mob
            // 
            Cp_Mob.DataPropertyName = "Cust_Mob";
            Cp_Mob.HeaderText = "Mobile";
            Cp_Mob.Name = "Cp_Mob";
            Cp_Mob.ReadOnly = true;
            Cp_Mob.Width = 146;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Cust_Balance";
            colAddress.HeaderText = "Balance";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colUpdate
            // 
            colUpdate.DataPropertyName = "Cust_upd_dt";
            colUpdate.HeaderText = "Update On";
            colUpdate.Name = "colUpdate";
            colUpdate.ReadOnly = true;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 471);
            Controls.Add(Panel1);
            Controls.Add(CompanyDataGridView);
            Controls.Add(CompanyBindingNavigator);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomers";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CompanyBindingNavigator).EndInit();
            CompanyBindingNavigator.ResumeLayout(false);
            CompanyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CompanyBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompanyDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompanyDataGridView).EndInit();
            Load += new EventHandler(frmCustomers_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label2;
        internal TextBox txtBalance;
        internal Label Label6;
        internal Panel Panel1;
        internal TextBox txtMob;
        internal Label Label4;
        internal TextBox txtCity;
        internal Label Label3;
        internal TextBox txtAddress;
        internal Label Label1;
        internal TextBox txtID;
        internal Label lblPhone;
        internal TextBox txtPhone;
        internal Label lblName;
        internal TextBox txtName;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripLabel BindingNavigatorCountItem;
        internal ToolStripTextBox BindingNavigatorPositionItem;
        internal ToolStripButton BindingNavigatorMoveLastItem;
        internal ToolStripSeparator BindingNavigatorSeparator1;
        internal ToolStripButton ToolStripEditButton;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripButton ToolStripSaveButton;
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal ToolStripButton BindingNavigatorMoveFirstItem;
        internal ToolStripButton BindingNavigatorAddNewItem;
        internal BindingNavigator CompanyBindingNavigator;
        internal BindingSource CompanyBindingSource;
        internal DataSet CompanyDataSet;
        internal ToolStripButton BindingNavigatorDeleteItem;
        internal ToolStripButton ToolStripCloseButton;
        internal DataGridView CompanyDataGridView;
        internal DataGridViewTextBoxColumn colID;
        internal DataGridViewTextBoxColumn CP_NAME;
        internal DataGridViewTextBoxColumn Cp_Incharge;
        internal DataGridViewTextBoxColumn colCity;
        internal DataGridViewTextBoxColumn Cp_Tel;
        internal DataGridViewTextBoxColumn Cp_Mob;
        internal DataGridViewTextBoxColumn colAddress;
        internal DataGridViewTextBoxColumn colUpdate;
    }
}