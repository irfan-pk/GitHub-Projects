
namespace WholeSaleApplication
{
    partial class AreaLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaLists));
            this.TxtUrdu = new UrduTextBoxDemo.UrduTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtACode = new System.Windows.Forms.TextBox();
            this.CmbCityName = new System.Windows.Forms.ComboBox();
            this.TxtAreaName = new System.Windows.Forms.TextBox();
            this.DgvDisplayCity = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrduNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.CityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingNavigator)).BeginInit();
            this.CityBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUrdu
            // 
            this.TxtUrdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrdu.Location = new System.Drawing.Point(383, 9);
            this.TxtUrdu.Name = "TxtUrdu";
            this.TxtUrdu.ReadOnly = true;
            this.TxtUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUrdu.Size = new System.Drawing.Size(138, 22);
            this.TxtUrdu.TabIndex = 2;
            this.TxtUrdu.TextChanged += new System.EventHandler(this.TxtUrdu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "In Urdu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Area City";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtACode);
            this.panel2.Controls.Add(this.CmbCityName);
            this.panel2.Controls.Add(this.TxtUrdu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtAreaName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 72);
            this.panel2.TabIndex = 98;
            // 
            // TxtACode
            // 
            this.TxtACode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtACode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtACode.Location = new System.Drawing.Point(259, 37);
            this.TxtACode.Name = "TxtACode";
            this.TxtACode.ReadOnly = true;
            this.TxtACode.Size = new System.Drawing.Size(63, 22);
            this.TxtACode.TabIndex = 4;
            // 
            // CmbCityName
            // 
            this.CmbCityName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCityName.FormattingEnabled = true;
            this.CmbCityName.Location = new System.Drawing.Point(96, 36);
            this.CmbCityName.Name = "CmbCityName";
            this.CmbCityName.Size = new System.Drawing.Size(155, 24);
            this.CmbCityName.TabIndex = 3;
            // 
            // TxtAreaName
            // 
            this.TxtAreaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAreaName.Location = new System.Drawing.Point(96, 9);
            this.TxtAreaName.Name = "TxtAreaName";
            this.TxtAreaName.ReadOnly = true;
            this.TxtAreaName.Size = new System.Drawing.Size(226, 22);
            this.TxtAreaName.TabIndex = 1;
            this.TxtAreaName.TextChanged += new System.EventHandler(this.TxtAreaName_TextChanged);
            this.TxtAreaName.Leave += new System.EventHandler(this.TxtAreaName_Leave);
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
            this.DgvDisplayCity.DataSource = this.CityBindingSource;
            this.DgvDisplayCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDisplayCity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvDisplayCity.EnableHeadersVisualStyles = false;
            this.DgvDisplayCity.Location = new System.Drawing.Point(0, 72);
            this.DgvDisplayCity.MultiSelect = false;
            this.DgvDisplayCity.Name = "DgvDisplayCity";
            this.DgvDisplayCity.ReadOnly = true;
            this.DgvDisplayCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDisplayCity.Size = new System.Drawing.Size(561, 353);
            this.DgvDisplayCity.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "area_id";
            this.colID.HeaderText = "Area ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 75;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "area_name";
            this.colName.HeaderText = "Area Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 165;
            // 
            // colUrduNm
            // 
            this.colUrduNm.DataPropertyName = "area_name_u";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUrduNm.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUrduNm.HeaderText = "In Urdu";
            this.colUrduNm.Name = "colUrduNm";
            this.colUrduNm.ReadOnly = true;
            this.colUrduNm.Width = 150;
            // 
            // colPin
            // 
            this.colPin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPin.DataPropertyName = "area_code";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPin.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPin.HeaderText = "Area Code";
            this.colPin.Name = "colPin";
            this.colPin.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvDisplayCity);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 425);
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
            // CityBindingNavigator
            // 
            this.CityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.CityBindingNavigator.BindingSource = this.CityBindingSource;
            this.CityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.CityBindingNavigator.DeleteItem = null;
            this.CityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.CityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.CityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.CityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.CityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.CityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.CityBindingNavigator.Name = "CityBindingNavigator";
            this.CityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.CityBindingNavigator.Size = new System.Drawing.Size(561, 25);
            this.CityBindingNavigator.TabIndex = 101;
            this.CityBindingNavigator.Text = "bindingNavigator1";
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
            // AreaLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CityBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AreaLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Lists";
            this.Load += new System.EventHandler(this.AreaLists_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingNavigator)).EndInit();
            this.CityBindingNavigator.ResumeLayout(false);
            this.CityBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UrduTextBoxDemo.UrduTextBox TxtUrdu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtAreaName;
        private System.Windows.Forms.DataGridView DgvDisplayCity;
        private System.Windows.Forms.BindingSource CityBindingSource;
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
        private System.Windows.Forms.BindingNavigator CityBindingNavigator;
        private System.Windows.Forms.ComboBox CmbCityName;
        private System.Windows.Forms.TextBox TxtACode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrduNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPin;
    }
}