
namespace WholeSaleApplication
{
    partial class CityLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityLists));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.CityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvDisplayCity = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrduNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtUrdu = new UrduTextBoxDemo.UrduTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPostalCd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingNavigator)).BeginInit();
            this.CityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayCity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.CityBindingNavigator.Size = new System.Drawing.Size(544, 25);
            this.CityBindingNavigator.TabIndex = 1;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvDisplayCity);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 422);
            this.panel1.TabIndex = 100;
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
            this.DgvDisplayCity.Size = new System.Drawing.Size(544, 350);
            this.DgvDisplayCity.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "city_id";
            this.colID.HeaderText = "City ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 65;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "city_name";
            this.colName.HeaderText = "City Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 170;
            // 
            // colUrduNm
            // 
            this.colUrduNm.DataPropertyName = "city_name_u";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUrduNm.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUrduNm.HeaderText = "In Urdu";
            this.colUrduNm.Name = "colUrduNm";
            this.colUrduNm.ReadOnly = true;
            this.colUrduNm.Width = 165;
            // 
            // colPin
            // 
            this.colPin.DataPropertyName = "city_pin";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPin.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPin.HeaderText = "Postal Code";
            this.colPin.Name = "colPin";
            this.colPin.ReadOnly = true;
            this.colPin.Width = 101;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtUrdu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtPostalCd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtCityName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 72);
            this.panel2.TabIndex = 98;
            // 
            // TxtUrdu
            // 
            this.TxtUrdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrdu.Font = new System.Drawing.Font("Al_Mushaf", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrdu.Location = new System.Drawing.Point(343, 9);
            this.TxtUrdu.Name = "TxtUrdu";
            this.TxtUrdu.ReadOnly = true;
            this.TxtUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUrdu.Size = new System.Drawing.Size(178, 30);
            this.TxtUrdu.TabIndex = 2;
            this.TxtUrdu.TextChanged += new System.EventHandler(this.TxtUrdu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "In Urdu";
            // 
            // TxtPostalCd
            // 
            this.TxtPostalCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPostalCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPostalCd.Location = new System.Drawing.Point(103, 37);
            this.TxtPostalCd.Name = "TxtPostalCd";
            this.TxtPostalCd.ReadOnly = true;
            this.TxtPostalCd.Size = new System.Drawing.Size(159, 22);
            this.TxtPostalCd.TabIndex = 3;
            this.TxtPostalCd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPostalCd.TextChanged += new System.EventHandler(this.TxtPostalCd_TextChanged);
            this.TxtPostalCd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPostalCd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Postal Code";
            // 
            // TxtCityName
            // 
            this.TxtCityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCityName.Location = new System.Drawing.Point(103, 9);
            this.TxtCityName.Name = "TxtCityName";
            this.TxtCityName.ReadOnly = true;
            this.TxtCityName.Size = new System.Drawing.Size(159, 22);
            this.TxtCityName.TabIndex = 1;
            this.TxtCityName.TextChanged += new System.EventHandler(this.TxtCityName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name";
            // 
            // CityLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CityBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CityLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cities List";
            this.Load += new System.EventHandler(this.CityLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingNavigator)).EndInit();
            this.CityBindingNavigator.ResumeLayout(false);
            this.CityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayCity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator CityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BindingNavigatorCloseItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvDisplayCity;
        private System.Windows.Forms.Panel panel2;
        private UrduTextBoxDemo.UrduTextBox TxtUrdu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPostalCd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource CityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrduNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPin;
    }
}