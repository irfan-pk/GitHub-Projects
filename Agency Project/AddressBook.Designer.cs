
namespace WindowsFormsApp2
{
    partial class AddressBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressBook));
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAreaList = new System.Windows.Forms.Button();
            this.BtnCities = new System.Windows.Forms.Button();
            this.BtnDeleteRec = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSMS = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvAddressBook = new System.Windows.Forms.DataGridView();
            this.colAccID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddrBindingource = new System.Windows.Forms.BindingSource(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CityFilter = new System.Windows.Forms.TextBox();
            this.AddrFilter = new System.Windows.Forms.TextBox();
            this.GrpFilter = new System.Windows.Forms.TextBox();
            this.NameFilter = new System.Windows.Forms.TextBox();
            this.AddrDataSet = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddressBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddrBindingource)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.BtnClose);
            this.SplitContainer1.Panel1.Controls.Add(this.BtnAreaList);
            this.SplitContainer1.Panel1.Controls.Add(this.BtnCities);
            this.SplitContainer1.Panel1.Controls.Add(this.BtnDeleteRec);
            this.SplitContainer1.Panel1.Controls.Add(this.BtnNew);
            this.SplitContainer1.Panel1.Controls.Add(this.BtnSMS);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Controls.Add(this.PictureBox1);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.DgvAddressBook);
            this.SplitContainer1.Panel2.Controls.Add(this.Panel1);
            this.SplitContainer1.Size = new System.Drawing.Size(1080, 573);
            this.SplitContainer1.SplitterDistance = 103;
            this.SplitContainer1.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.LightGray;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(944, 55);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(126, 37);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAreaList
            // 
            this.BtnAreaList.BackColor = System.Drawing.Color.LightGray;
            this.BtnAreaList.FlatAppearance.BorderSize = 0;
            this.BtnAreaList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAreaList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAreaList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAreaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAreaList.Location = new System.Drawing.Point(944, 12);
            this.BtnAreaList.Name = "BtnAreaList";
            this.BtnAreaList.Size = new System.Drawing.Size(126, 37);
            this.BtnAreaList.TabIndex = 2;
            this.BtnAreaList.Text = "&Area List";
            this.BtnAreaList.UseVisualStyleBackColor = false;
            // 
            // BtnCities
            // 
            this.BtnCities.BackColor = System.Drawing.Color.LightGray;
            this.BtnCities.FlatAppearance.BorderSize = 0;
            this.BtnCities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCities.Location = new System.Drawing.Point(812, 12);
            this.BtnCities.Name = "BtnCities";
            this.BtnCities.Size = new System.Drawing.Size(126, 37);
            this.BtnCities.TabIndex = 2;
            this.BtnCities.Text = "&City List";
            this.BtnCities.UseVisualStyleBackColor = false;
            this.BtnCities.Click += new System.EventHandler(this.BtnCity_Click);
            // 
            // BtnDeleteRec
            // 
            this.BtnDeleteRec.BackColor = System.Drawing.Color.LightGray;
            this.BtnDeleteRec.FlatAppearance.BorderSize = 0;
            this.BtnDeleteRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDeleteRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnDeleteRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteRec.Location = new System.Drawing.Point(812, 55);
            this.BtnDeleteRec.Name = "BtnDeleteRec";
            this.BtnDeleteRec.Size = new System.Drawing.Size(126, 37);
            this.BtnDeleteRec.TabIndex = 2;
            this.BtnDeleteRec.Text = "&Delete";
            this.BtnDeleteRec.UseVisualStyleBackColor = false;
            this.BtnDeleteRec.Click += new System.EventHandler(this.BtnDeleteRec_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.LightGray;
            this.BtnNew.FlatAppearance.BorderSize = 0;
            this.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Location = new System.Drawing.Point(680, 55);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(126, 37);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "&New";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSMS
            // 
            this.BtnSMS.BackColor = System.Drawing.Color.LightGray;
            this.BtnSMS.FlatAppearance.BorderSize = 0;
            this.BtnSMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSMS.Location = new System.Drawing.Point(680, 12);
            this.BtnSMS.Name = "BtnSMS";
            this.BtnSMS.Size = new System.Drawing.Size(126, 37);
            this.BtnSMS.TabIndex = 2;
            this.BtnSMS.Text = "&SMS";
            this.BtnSMS.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(101, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 29);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "BOOK";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(101, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(134, 29);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ADDRESS";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Autocomplete_64;
            this.PictureBox1.Location = new System.Drawing.Point(31, 16);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(64, 64);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // DgvAddressBook
            // 
            this.DgvAddressBook.AllowUserToAddRows = false;
            this.DgvAddressBook.AllowUserToDeleteRows = false;
            this.DgvAddressBook.AllowUserToResizeColumns = false;
            this.DgvAddressBook.AllowUserToResizeRows = false;
            this.DgvAddressBook.AutoGenerateColumns = false;
            this.DgvAddressBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvAddressBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAddressBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAddressBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAddressBook.ColumnHeadersHeight = 40;
            this.DgvAddressBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccID,
            this.colName,
            this.colGroup,
            this.colAddress,
            this.colCity,
            this.colPhone,
            this.colMobile,
            this.colCNIC,
            this.colContact,
            this.colEmail,
            this.colNTN,
            this.colGST});
            this.DgvAddressBook.DataSource = this.AddrBindingource;
            this.DgvAddressBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAddressBook.EnableHeadersVisualStyles = false;
            this.DgvAddressBook.Location = new System.Drawing.Point(0, 31);
            this.DgvAddressBook.MultiSelect = false;
            this.DgvAddressBook.Name = "DgvAddressBook";
            this.DgvAddressBook.ReadOnly = true;
            this.DgvAddressBook.RowHeadersVisible = false;
            this.DgvAddressBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAddressBook.Size = new System.Drawing.Size(1078, 433);
            this.DgvAddressBook.TabIndex = 1;
            this.DgvAddressBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAddBook_CellDoubleClick);
            // 
            // colAccID
            // 
            this.colAccID.DataPropertyName = "account_id";
            this.colAccID.HeaderText = "Acc ID #";
            this.colAccID.Name = "colAccID";
            this.colAccID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "account_name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colGroup
            // 
            this.colGroup.DataPropertyName = "group_name";
            this.colGroup.HeaderText = "Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            this.colGroup.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "address1";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 150;
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "city_name";
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhone.DataPropertyName = "landline";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 76;
            // 
            // colMobile
            // 
            this.colMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMobile.DataPropertyName = "mobile";
            this.colMobile.HeaderText = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            this.colMobile.Width = 79;
            // 
            // colCNIC
            // 
            this.colCNIC.DataPropertyName = "cnic";
            this.colCNIC.HeaderText = "CNIC #";
            this.colCNIC.Name = "colCNIC";
            this.colCNIC.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colContact.DataPropertyName = "contact_person";
            this.colContact.HeaderText = "Contact Person";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            this.colContact.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "Email Address";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 122;
            // 
            // colNTN
            // 
            this.colNTN.DataPropertyName = "ntn_no";
            this.colNTN.HeaderText = "NTN #";
            this.colNTN.Name = "colNTN";
            this.colNTN.ReadOnly = true;
            // 
            // colGST
            // 
            this.colGST.DataPropertyName = "gst_no";
            this.colGST.HeaderText = "GST #";
            this.colGST.Name = "colGST";
            this.colGST.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.CityFilter);
            this.Panel1.Controls.Add(this.AddrFilter);
            this.Panel1.Controls.Add(this.GrpFilter);
            this.Panel1.Controls.Add(this.NameFilter);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1078, 31);
            this.Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::WindowsFormsApp2.Properties.Resources.Filter2HS;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(655, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CityFilter
            // 
            this.CityFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CityFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CityFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityFilter.Location = new System.Drawing.Point(551, 4);
            this.CityFilter.Name = "CityFilter";
            this.CityFilter.Size = new System.Drawing.Size(100, 24);
            this.CityFilter.TabIndex = 6;
            this.CityFilter.TextChanged += new System.EventHandler(this.CityFilter_TextChanged);
            this.CityFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityFilter_KeyPress);
            // 
            // AddrFilter
            // 
            this.AddrFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddrFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddrFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddrFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddrFilter.Location = new System.Drawing.Point(401, 4);
            this.AddrFilter.Name = "AddrFilter";
            this.AddrFilter.Size = new System.Drawing.Size(150, 24);
            this.AddrFilter.TabIndex = 6;
            this.AddrFilter.TextChanged += new System.EventHandler(this.AddrFilter_TextChanged);
            this.AddrFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddrFilter_KeyPress);
            // 
            // GrpFilter
            // 
            this.GrpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GrpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrpFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GrpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpFilter.Location = new System.Drawing.Point(251, 4);
            this.GrpFilter.Name = "GrpFilter";
            this.GrpFilter.Size = new System.Drawing.Size(150, 24);
            this.GrpFilter.TabIndex = 6;
            this.GrpFilter.TextChanged += new System.EventHandler(this.GrpFilter_TextChanged);
            this.GrpFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrpFilter_KeyPress);
            // 
            // NameFilter
            // 
            this.NameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NameFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFilter.Location = new System.Drawing.Point(100, 4);
            this.NameFilter.Name = "NameFilter";
            this.NameFilter.Size = new System.Drawing.Size(151, 24);
            this.NameFilter.TabIndex = 0;
            this.NameFilter.TextChanged += new System.EventHandler(this.NameFilter_TextChanged);
            this.NameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameFilter_KeyPress);
            // 
            // AddrDataSet
            // 
            this.AddrDataSet.DataSetName = "NewDataSet";
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 573);
            this.Controls.Add(this.SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddressBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.AddressBook_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddressBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddrBindingource)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddrDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Button BtnAreaList;
        internal System.Windows.Forms.Button BtnCities;
        internal System.Windows.Forms.Button BtnDeleteRec;
        internal System.Windows.Forms.Button BtnNew;
        internal System.Windows.Forms.Button BtnSMS;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox CityFilter;
        internal System.Windows.Forms.TextBox AddrFilter;
        internal System.Windows.Forms.TextBox GrpFilter;
        internal System.Windows.Forms.TextBox NameFilter;
        private System.Windows.Forms.BindingSource AddrBindingource;
        private System.Data.DataSet AddrDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGST;
        private System.Windows.Forms.DataGridView DgvAddressBook;
    }
}