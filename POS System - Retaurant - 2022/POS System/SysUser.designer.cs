using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SysUser : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SysUser));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            UserDataSet = new DataSet();
            DataTable1 = new DataTable();
            UserBindingNavigator = new BindingNavigator(components);
            UserbindingSource = new BindingSource(components);
            BindingNavigatorCountItem = new ToolStripLabel();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorPositionItem = new ToolStripTextBox();
            BindingNavigatorSeparator1 = new ToolStripSeparator();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            ToolStripSeparator1 = new ToolStripSeparator();
            UsersDataGridView = new DataGridView();
            Panel1 = new Panel();
            Label7 = new Label();
            txtCNIC = new MaskedTextBox();
            txtName = new TextBox();
            txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
            Label6 = new Label();
            txtLevel = new TextBox();
            cmbUserType = new ComboBox();
            cmbUserType.KeyPress += new KeyPressEventHandler(cmbUserType_KeyPress);
            cmbUserType.SelectedIndexChanged += new EventHandler(cmbUserType_SelectedIndexChanged);
            Label5 = new Label();
            txtPwd = new TextBox();
            txtPwd.KeyPress += new KeyPressEventHandler(txtPwd_KeyPress);
            Label4 = new Label();
            Label3 = new Label();
            txtUserName = new TextBox();
            txtUserName.KeyPress += new KeyPressEventHandler(txtUserName_KeyPress);
            Label2 = new Label();
            txtUserID = new TextBox();
            Label1 = new Label();
            BindingNavigatorAddNewItem = new ToolStripButton();
            BindingNavigatorAddNewItem.Click += new EventHandler(BindingNavigatorAddNewItem_Click);
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
            ToolStripSeparator2 = new ToolStripSeparator();
            ToolStripSeparator3 = new ToolStripSeparator();
            ToolStripSeparator4 = new ToolStripSeparator();
            ToolStripSeparator5 = new ToolStripSeparator();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            UserType = new DataGridViewTextBoxColumn();
            UserStatus = new DataGridViewTextBoxColumn();
            colNIC = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)UserDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataTable1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserBindingNavigator).BeginInit();
            UserBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserbindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UserDataSet
            // 
            UserDataSet.DataSetName = "UserDataSet";
            UserDataSet.Tables.AddRange(new DataTable[] { DataTable1 });
            // 
            // DataTable1
            // 
            DataTable1.TableName = "USERS";
            // 
            // UserBindingNavigator
            // 
            UserBindingNavigator.AddNewItem = BindingNavigatorAddNewItem;
            UserBindingNavigator.BackColor = Color.PaleGreen;
            UserBindingNavigator.BindingSource = UserbindingSource;
            UserBindingNavigator.CountItem = BindingNavigatorCountItem;
            UserBindingNavigator.DeleteItem = BindingNavigatorDeleteItem;
            UserBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMoveFirstItem, BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorPositionItem, BindingNavigatorCountItem, BindingNavigatorSeparator1, BindingNavigatorMoveNextItem, BindingNavigatorMoveLastItem, BindingNavigatorSeparator2, BindingNavigatorAddNewItem, ToolStripSeparator2, BindingNavigatorDeleteItem, ToolStripSeparator3, ToolStripEditButton, ToolStripSeparator1, ToolStripSaveButton, ToolStripSeparator4, ToolStripCloseButton, ToolStripSeparator5 });
            UserBindingNavigator.Location = new Point(0, 0);
            UserBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem;
            UserBindingNavigator.MoveLastItem = BindingNavigatorMoveLastItem;
            UserBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            UserBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            UserBindingNavigator.Name = "UserBindingNavigator";
            UserBindingNavigator.PositionItem = BindingNavigatorPositionItem;
            UserBindingNavigator.Size = new Size(724, 25);
            UserBindingNavigator.TabIndex = 0;
            UserBindingNavigator.Text = "BindingNavigator1";
            // 
            // UserbindingSource
            // 
            UserbindingSource.DataSource = UserDataSet;
            UserbindingSource.Position = 0;
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
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 25);
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.AllowUserToAddRows = false;
            UsersDataGridView.AutoGenerateColumns = false;
            UsersDataGridView.BackgroundColor = Color.OldLace;
            UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserId, UserName, colName, UserType, UserStatus, colNIC });
            UsersDataGridView.DataSource = UserbindingSource;
            UsersDataGridView.Location = new Point(0, 28);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.ReadOnly = true;
            UsersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersDataGridView.Size = new Size(723, 346);
            UsersDataGridView.TabIndex = 1;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.DimGray;
            Panel1.BorderStyle = BorderStyle.Fixed3D;
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(txtCNIC);
            Panel1.Controls.Add(txtName);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(txtLevel);
            Panel1.Controls.Add(cmbUserType);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(txtPwd);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(txtUserName);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(txtUserID);
            Panel1.Controls.Add(Label1);
            Panel1.Enabled = false;
            Panel1.Location = new Point(0, 378);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(723, 67);
            Panel1.TabIndex = 3;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(416, 39);
            Label7.Name = "Label7";
            Label7.Size = new Size(36, 13);
            Label7.TabIndex = 13;
            Label7.Text = "CNIC";
            Label7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCNIC
            // 
            txtCNIC.Location = new Point(462, 36);
            txtCNIC.Mask = "00000-0000000-0";
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(94, 20);
            txtCNIC.TabIndex = 5;
            txtCNIC.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(461, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 20);
            txtName.TabIndex = 2;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(416, 13);
            Label6.Name = "Label6";
            Label6.Size = new Size(39, 13);
            Label6.TabIndex = 11;
            Label6.Text = "Name";
            Label6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtLevel
            // 
            txtLevel.BorderStyle = BorderStyle.FixedSingle;
            txtLevel.Enabled = false;
            txtLevel.Location = new Point(663, 36);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(51, 20);
            txtLevel.TabIndex = 6;
            txtLevel.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbUserType
            // 
            cmbUserType.FlatStyle = FlatStyle.Popup;
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "Administrator", "Super User", "User" });
            cmbUserType.Location = new Point(80, 36);
            cmbUserType.MaxDropDownItems = 4;
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(131, 21);
            cmbUserType.TabIndex = 2;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(583, 39);
            Label5.Name = "Label5";
            Label5.Size = new Size(74, 13);
            Label5.TabIndex = 8;
            Label5.Text = "Security Lvl";
            // 
            // txtPwd
            // 
            txtPwd.BorderStyle = BorderStyle.FixedSingle;
            txtPwd.Location = new Point(304, 35);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(95, 20);
            txtPwd.TabIndex = 4;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(241, 39);
            Label4.Name = "Label4";
            Label4.Size = new Size(61, 13);
            Label4.TabIndex = 6;
            Label4.Text = "Password";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(8, 39);
            Label3.Name = "Label3";
            Label3.Size = new Size(65, 13);
            Label3.TabIndex = 4;
            Label3.Text = "User Type";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(231, 9);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(168, 20);
            txtUserName.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(156, 13);
            Label2.Name = "Label2";
            Label2.Size = new Size(69, 13);
            Label2.TabIndex = 2;
            Label2.Text = "User Name";
            Label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtUserID
            // 
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(80, 9);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(70, 20);
            txtUserID.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(8, 13);
            Label1.Name = "Label1";
            Label1.Size = new Size(50, 13);
            Label1.TabIndex = 0;
            Label1.Text = "User ID";
            // 
            // BindingNavigatorAddNewItem
            // 
            BindingNavigatorAddNewItem.Image = (Image)resources.GetObject("BindingNavigatorAddNewItem.Image");
            BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorAddNewItem.Size = new Size(74, 22);
            BindingNavigatorAddNewItem.Text = "&Add new";
            // 
            // BindingNavigatorDeleteItem
            // 
            BindingNavigatorDeleteItem.Image = (Image)resources.GetObject("BindingNavigatorDeleteItem.Image");
            BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorDeleteItem.Size = new Size(60, 22);
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
            ToolStripEditButton.Image = My.Resources.Resources.data_edit2;
            ToolStripEditButton.ImageTransparentColor = Color.Magenta;
            ToolStripEditButton.Name = "ToolStripEditButton";
            ToolStripEditButton.Size = new Size(47, 22);
            ToolStripEditButton.Text = "&Edit";
            // 
            // ToolStripSaveButton
            // 
            ToolStripSaveButton.Enabled = false;
            ToolStripSaveButton.Image = My.Resources.Resources.saveHS2;
            ToolStripSaveButton.ImageTransparentColor = Color.Magenta;
            ToolStripSaveButton.Name = "ToolStripSaveButton";
            ToolStripSaveButton.Size = new Size(51, 22);
            ToolStripSaveButton.Text = "&Save";
            // 
            // ToolStripCloseButton
            // 
            ToolStripCloseButton.Image = My.Resources.Resources.remove1;
            ToolStripCloseButton.ImageTransparentColor = Color.Magenta;
            ToolStripCloseButton.Name = "ToolStripCloseButton";
            ToolStripCloseButton.Size = new Size(56, 22);
            ToolStripCloseButton.Text = "&Close";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 25);
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator3.Size = new Size(6, 25);
            // 
            // ToolStripSeparator4
            // 
            ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator4.Size = new Size(6, 25);
            // 
            // ToolStripSeparator5
            // 
            ToolStripSeparator5.Name = "ToolStripSeparator5";
            ToolStripSeparator5.Size = new Size(6, 25);
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserId.DefaultCellStyle = DataGridViewCellStyle1;
            UserId.HeaderText = "User Id";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "User Name";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // UserType
            // 
            UserType.DataPropertyName = "UserRole";
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserType.DefaultCellStyle = DataGridViewCellStyle2;
            UserType.HeaderText = "User Type";
            UserType.Name = "UserType";
            UserType.ReadOnly = true;
            UserType.Width = 120;
            // 
            // UserStatus
            // 
            UserStatus.DataPropertyName = "Active";
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UserStatus.DefaultCellStyle = DataGridViewCellStyle3;
            UserStatus.HeaderText = "Active";
            UserStatus.Name = "UserStatus";
            UserStatus.ReadOnly = true;
            UserStatus.Width = 110;
            // 
            // colNIC
            // 
            colNIC.DataPropertyName = "CardNumber";
            colNIC.HeaderText = "CNIC #";
            colNIC.Name = "colNIC";
            colNIC.ReadOnly = true;
            // 
            // frmSysUser
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 443);
            Controls.Add(Panel1);
            Controls.Add(UsersDataGridView);
            Controls.Add(UserBindingNavigator);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(730, 472);
            MinimumSize = new Size(730, 472);
            Name = "frmSysUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit System User";
            ((System.ComponentModel.ISupportInitialize)UserDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataTable1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserBindingNavigator).EndInit();
            UserBindingNavigator.ResumeLayout(false);
            UserBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserbindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            KeyUp += new KeyEventHandler(frmSysUser_KeyUp);
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal DataSet UserDataSet;
        internal BindingNavigator UserBindingNavigator;
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
        internal BindingSource UserbindingSource;
        internal DataGridView UsersDataGridView;
        internal DataTable DataTable1;
        internal Panel Panel1;
        internal Label Label5;
        internal TextBox txtPwd;
        internal Label Label4;
        internal Label Label3;
        internal TextBox txtUserName;
        internal Label Label2;
        internal TextBox txtUserID;
        internal Label Label1;
        internal ToolStripButton ToolStripEditButton;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripButton ToolStripSaveButton;
        internal ToolStripButton ToolStripCloseButton;
        internal ComboBox cmbUserType;
        internal TextBox txtLevel;
        internal TextBox txtName;
        internal Label Label6;
        internal Label Label7;
        internal MaskedTextBox txtCNIC;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripSeparator ToolStripSeparator5;
        internal DataGridViewTextBoxColumn UserId;
        internal DataGridViewTextBoxColumn UserName;
        internal DataGridViewTextBoxColumn colName;
        internal DataGridViewTextBoxColumn UserType;
        internal DataGridViewTextBoxColumn UserStatus;
        internal DataGridViewTextBoxColumn colNIC;
    }
}