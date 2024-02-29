namespace WholeSaleApplication
{
    partial class Companies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Companies));
            this.TxtUrdu = new UrduTextBoxDemo.UrduTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtCompanyCode = new SeaRisenLib2.Controls.NumericTextBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.DgvDisplayCity = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrduNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.CompanyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingNavigator)).BeginInit();
            this.CompanyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUrdu
            // 
            this.TxtUrdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrdu.Location = new System.Drawing.Point(343, 9);
            this.TxtUrdu.Name = "TxtUrdu";
            this.TxtUrdu.ReadOnly = true;
            this.TxtUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUrdu.Size = new System.Drawing.Size(178, 22);
            this.TxtUrdu.TabIndex = 2;
            this.TxtUrdu.TextChanged += new System.EventHandler(this.TxtUrdu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "In Urdu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtCompanyCode);
            this.panel2.Controls.Add(this.TxtCompanyName);
            this.panel2.Controls.Add(this.TxtUrdu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 72);
            this.panel2.TabIndex = 98;
            // 
            // TxtCompanyCode
            // 
            this.TxtCompanyCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyCode.DecimalNumbers = 0;
            this.TxtCompanyCode.DecimalText = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtCompanyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompanyCode.ForeColor = System.Drawing.Color.Black;
            this.TxtCompanyCode.Format = "^(\\-?)(\\d*)$";
            this.TxtCompanyCode.HasNegatives = false;
            this.TxtCompanyCode.Location = new System.Drawing.Point(77, 40);
            this.TxtCompanyCode.Name = "TxtCompanyCode";
            this.TxtCompanyCode.ReadOnly = true;
            this.TxtCompanyCode.Size = new System.Drawing.Size(146, 22);
            this.TxtCompanyCode.TabIndex = 3;
            this.TxtCompanyCode.Text = "0";
            this.TxtCompanyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCompanyCode.TextChanged += new System.EventHandler(this.TxtCompanyCode_TextChanged);
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompanyName.Location = new System.Drawing.Point(77, 9);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.ReadOnly = true;
            this.TxtCompanyName.Size = new System.Drawing.Size(185, 22);
            this.TxtCompanyName.TabIndex = 1;
            this.TxtCompanyName.TextChanged += new System.EventHandler(this.TxtCompanyName_TextChanged);
            // 
            // DgvDisplayCity
            // 
            this.DgvDisplayCity.AllowUserToAddRows = false;
            this.DgvDisplayCity.AllowUserToDeleteRows = false;
            this.DgvDisplayCity.AutoGenerateColumns = false;
            this.DgvDisplayCity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvDisplayCity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDisplayCity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDisplayCity.ColumnHeadersHeight = 30;
            this.DgvDisplayCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colUrduNm,
            this.colPin});
            this.DgvDisplayCity.DataSource = this.CompanyBindingSource;
            this.DgvDisplayCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDisplayCity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvDisplayCity.EnableHeadersVisualStyles = false;
            this.DgvDisplayCity.Location = new System.Drawing.Point(0, 72);
            this.DgvDisplayCity.MultiSelect = false;
            this.DgvDisplayCity.Name = "DgvDisplayCity";
            this.DgvDisplayCity.ReadOnly = true;
            this.DgvDisplayCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDisplayCity.Size = new System.Drawing.Size(544, 350);
            this.DgvDisplayCity.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "companyid";
            this.colID.HeaderText = "Seq #";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 65;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "companyname";
            this.colName.HeaderText = "Company Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 170;
            // 
            // colUrduNm
            // 
            this.colUrduNm.DataPropertyName = "companynameur";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUrduNm.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUrduNm.HeaderText = "In Urdu";
            this.colUrduNm.Name = "colUrduNm";
            this.colUrduNm.ReadOnly = true;
            this.colUrduNm.Width = 165;
            // 
            // colPin
            // 
            this.colPin.DataPropertyName = "companycode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPin.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPin.HeaderText = "Comp. Code";
            this.colPin.Name = "colPin";
            this.colPin.ReadOnly = true;
            this.colPin.Width = 101;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvDisplayCity);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 422);
            this.panel1.TabIndex = 102;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // CompanyBindingNavigator
            // 
            this.CompanyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.CompanyBindingNavigator.BindingSource = this.CompanyBindingSource;
            this.CompanyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.CompanyBindingNavigator.DeleteItem = null;
            this.CompanyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.BindingNavigatorEditItem,
            this.toolStripSeparator3,
            this.BindingNavigatorSaveItem,
            this.toolStripSeparator4,
            this.ToolStripDeleteButton,
            this.toolStripSeparator2,
            this.BindingNavigatorCloseItem});
            this.CompanyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.CompanyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.CompanyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.CompanyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.CompanyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.CompanyBindingNavigator.Name = "CompanyBindingNavigator";
            this.CompanyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.CompanyBindingNavigator.Size = new System.Drawing.Size(544, 25);
            this.CompanyBindingNavigator.TabIndex = 101;
            this.CompanyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(79, 22);
            this.bindingNavigatorAddNewItem.Text = "&Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // BindingNavigatorEditItem
            // 
            this.BindingNavigatorEditItem.Image = global::WholeSaleApplication.Properties.Resources.edit_pencil1;
            this.BindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BindingNavigatorEditItem.Name = "BindingNavigatorEditItem";
            this.BindingNavigatorEditItem.Size = new System.Drawing.Size(50, 22);
            this.BindingNavigatorEditItem.Text = "&Edit";
            this.BindingNavigatorEditItem.Click += new System.EventHandler(this.BindingNavigatorEditItem_Click);
            // 
            // BindingNavigatorSaveItem
            // 
            this.BindingNavigatorSaveItem.Enabled = false;
            this.BindingNavigatorSaveItem.Image = global::WholeSaleApplication.Properties.Resources.saveHS;
            this.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            this.BindingNavigatorSaveItem.Size = new System.Drawing.Size(55, 22);
            this.BindingNavigatorSaveItem.Text = "&Save";
            this.BindingNavigatorSaveItem.Click += new System.EventHandler(this.BindingNavigatorSaveItem_Click);
            // 
            // ToolStripDeleteButton
            // 
            this.ToolStripDeleteButton.Image = global::WholeSaleApplication.Properties.Resources.application_remove;
            this.ToolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDeleteButton.Name = "ToolStripDeleteButton";
            this.ToolStripDeleteButton.Size = new System.Drawing.Size(65, 22);
            this.ToolStripDeleteButton.Text = "&Delete";
            this.ToolStripDeleteButton.Click += new System.EventHandler(this.ToolStripDeleteButton_Click);
            // 
            // BindingNavigatorCloseItem
            // 
            this.BindingNavigatorCloseItem.Image = global::WholeSaleApplication.Properties.Resources.Turn_off;
            this.BindingNavigatorCloseItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BindingNavigatorCloseItem.Name = "BindingNavigatorCloseItem";
            this.BindingNavigatorCloseItem.Size = new System.Drawing.Size(60, 22);
            this.BindingNavigatorCloseItem.Text = "&Close";
            this.BindingNavigatorCloseItem.Click += new System.EventHandler(this.BindingNavigatorCloseItem_Click);
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CompanyBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Companies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.Companies_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingNavigator)).EndInit();
            this.CompanyBindingNavigator.ResumeLayout(false);
            this.CompanyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UrduTextBoxDemo.UrduTextBox TxtUrdu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.DataGridView DgvDisplayCity;
        private System.Windows.Forms.BindingSource CompanyBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton BindingNavigatorCloseItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator CompanyBindingNavigator;
        private SeaRisenLib2.Controls.NumericTextBox TxtCompanyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrduNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPin;
    }
}