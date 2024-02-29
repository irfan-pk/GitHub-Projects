namespace WholeSaleApplication
{
    partial class ProductGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGroup));
            this.TxtUrdu = new UrduTextBoxDemo.UrduTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtProdGrpName = new System.Windows.Forms.TextBox();
            this.DgvDisplayGrp = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrduName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdGrpbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ProdGrpbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayGrp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGrpbindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGrpbindingNavigator)).BeginInit();
            this.ProdGrpbindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUrdu
            // 
            this.TxtUrdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrdu.Location = new System.Drawing.Point(341, 9);
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
            this.label2.Location = new System.Drawing.Point(284, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "In Urdu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Group";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtUrdu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtProdGrpName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 41);
            this.panel2.TabIndex = 98;
            // 
            // TxtProdGrpName
            // 
            this.TxtProdGrpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProdGrpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProdGrpName.Location = new System.Drawing.Point(110, 9);
            this.TxtProdGrpName.Name = "TxtProdGrpName";
            this.TxtProdGrpName.ReadOnly = true;
            this.TxtProdGrpName.Size = new System.Drawing.Size(159, 22);
            this.TxtProdGrpName.TabIndex = 1;
            this.TxtProdGrpName.TextChanged += new System.EventHandler(this.TxtProdGrpName_TextChanged);
            // 
            // DgvDisplayGrp
            // 
            this.DgvDisplayGrp.AllowUserToAddRows = false;
            this.DgvDisplayGrp.AllowUserToDeleteRows = false;
            this.DgvDisplayGrp.AutoGenerateColumns = false;
            this.DgvDisplayGrp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvDisplayGrp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDisplayGrp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDisplayGrp.ColumnHeadersHeight = 30;
            this.DgvDisplayGrp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colGrpName,
            this.colUrduName});
            this.DgvDisplayGrp.DataSource = this.ProdGrpbindingSource;
            this.DgvDisplayGrp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDisplayGrp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvDisplayGrp.EnableHeadersVisualStyles = false;
            this.DgvDisplayGrp.Location = new System.Drawing.Point(0, 41);
            this.DgvDisplayGrp.MultiSelect = false;
            this.DgvDisplayGrp.Name = "DgvDisplayGrp";
            this.DgvDisplayGrp.ReadOnly = true;
            this.DgvDisplayGrp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDisplayGrp.Size = new System.Drawing.Size(544, 373);
            this.DgvDisplayGrp.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "prodgroupid";
            this.colID.HeaderText = "Group ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colGrpName
            // 
            this.colGrpName.DataPropertyName = "prodgroupname";
            this.colGrpName.HeaderText = "Descpription";
            this.colGrpName.Name = "colGrpName";
            this.colGrpName.ReadOnly = true;
            this.colGrpName.Width = 210;
            // 
            // colUrduName
            // 
            this.colUrduName.DataPropertyName = "prodgroupnmur";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUrduName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUrduName.HeaderText = "In Urdu";
            this.colUrduName.Name = "colUrduName";
            this.colUrduName.ReadOnly = true;
            this.colUrduName.Width = 191;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvDisplayGrp);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 414);
            this.panel1.TabIndex = 101;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // ProdGrpbindingNavigator
            // 
            this.ProdGrpbindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ProdGrpbindingNavigator.BindingSource = this.ProdGrpbindingSource;
            this.ProdGrpbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ProdGrpbindingNavigator.DeleteItem = null;
            this.ProdGrpbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ProdGrpbindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ProdGrpbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ProdGrpbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ProdGrpbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ProdGrpbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ProdGrpbindingNavigator.Name = "ProdGrpbindingNavigator";
            this.ProdGrpbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ProdGrpbindingNavigator.Size = new System.Drawing.Size(544, 25);
            this.ProdGrpbindingNavigator.TabIndex = 100;
            this.ProdGrpbindingNavigator.Text = "bindingNavigator1";
            // 
            // ProductGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProdGrpbindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Group";
            this.Load += new System.EventHandler(this.ProductGroup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisplayGrp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGrpbindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdGrpbindingNavigator)).EndInit();
            this.ProdGrpbindingNavigator.ResumeLayout(false);
            this.ProdGrpbindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UrduTextBoxDemo.UrduTextBox TxtUrdu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtProdGrpName;
        private System.Windows.Forms.DataGridView DgvDisplayGrp;
        private System.Windows.Forms.BindingSource ProdGrpbindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton BindingNavigatorCloseItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolStripDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
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
        private System.Windows.Forms.BindingNavigator ProdGrpbindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrduName;
    }
}