
namespace WholeSaleApplication
{
    partial class NewAccount
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
            System.Windows.Forms.ToolTip FormToolTip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.BtnAddGrp = new System.Windows.Forms.Button();
            this.CbAccHead = new System.Windows.Forms.ComboBox();
            this.CmbDrCr = new System.Windows.Forms.ComboBox();
            this.TxtOpnBalance = new System.Windows.Forms.TextBox();
            this.TxtPrintName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtAccName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAddr1Eng = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAddr2Eng = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtMobile = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtContactPerson = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtBnkName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtBankAcc = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtGstNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtNTNNo = new System.Windows.Forms.TextBox();
            this.TxtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TxtCrLimit = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtBilLimit = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TxtCrDaysSale = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.TxtCrDaysPrch = new System.Windows.Forms.TextBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.TxtPostalCode = new System.Windows.Forms.TextBox();
            this.TxtCityName = new System.Windows.Forms.TextBox();
            this.TxtAccType = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.TxtGroup = new System.Windows.Forms.TextBox();
            this.TxtAreaName = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAccType = new System.Windows.Forms.Button();
            this.BtnViewArea = new System.Windows.Forms.Button();
            this.BtnAddArea = new System.Windows.Forms.Button();
            this.BtnViewGroup = new System.Windows.Forms.Button();
            this.NewAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label29 = new System.Windows.Forms.Label();
            this.TxtAreaUrdu = new UrduTextBoxDemo.UrduTextBox();
            this.TxtAddr2Urdu = new UrduTextBoxDemo.UrduTextBox();
            this.TxtAddr1Urdu = new UrduTextBoxDemo.UrduTextBox();
            this.TxtCityUrdu = new UrduTextBoxDemo.UrduTextBox();
            this.TxtAccNameUrdu = new UrduTextBoxDemo.UrduTextBox();
            FormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewAccBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FormToolTip
            // 
            FormToolTip.IsBalloon = true;
            FormToolTip.ToolTipTitle = "Tip";
            // 
            // BtnAddGrp
            // 
            this.BtnAddGrp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddGrp.Image = global::WholeSaleApplication.Properties.Resources.folder_add1;
            this.BtnAddGrp.Location = new System.Drawing.Point(316, 121);
            this.BtnAddGrp.Name = "BtnAddGrp";
            this.BtnAddGrp.Size = new System.Drawing.Size(30, 24);
            this.BtnAddGrp.TabIndex = 99;
            this.BtnAddGrp.TabStop = false;
            FormToolTip.SetToolTip(this.BtnAddGrp, "Add more Group in the List");
            this.BtnAddGrp.UseVisualStyleBackColor = true;
            this.BtnAddGrp.Click += new System.EventHandler(this.BtnAddGrp_Click);
            // 
            // CbAccHead
            // 
            this.CbAccHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAccHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbAccHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAccHead.FormattingEnabled = true;
            this.CbAccHead.Items.AddRange(new object[] {
            "Assets",
            "Equity",
            "Expenses",
            "Income Summary",
            "Liabilities",
            "Revenue"});
            this.CbAccHead.Location = new System.Drawing.Point(448, 123);
            this.CbAccHead.Name = "CbAccHead";
            this.CbAccHead.Size = new System.Drawing.Size(198, 24);
            this.CbAccHead.Sorted = true;
            this.CbAccHead.TabIndex = 4;
            FormToolTip.SetToolTip(this.CbAccHead, "Select Account Head by scroll down");
            // 
            // CmbDrCr
            // 
            this.CmbDrCr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CmbDrCr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbDrCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDrCr.FormattingEnabled = true;
            this.CmbDrCr.Items.AddRange(new object[] {
            "CR",
            "DR"});
            this.CmbDrCr.Location = new System.Drawing.Point(570, 152);
            this.CmbDrCr.Name = "CmbDrCr";
            this.CmbDrCr.Size = new System.Drawing.Size(77, 24);
            this.CmbDrCr.Sorted = true;
            this.CmbDrCr.TabIndex = 7;
            // 
            // TxtOpnBalance
            // 
            this.TxtOpnBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOpnBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtOpnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOpnBalance.Location = new System.Drawing.Point(353, 154);
            this.TxtOpnBalance.Name = "TxtOpnBalance";
            this.TxtOpnBalance.ReadOnly = true;
            this.TxtOpnBalance.Size = new System.Drawing.Size(142, 22);
            this.TxtOpnBalance.TabIndex = 6;
            this.TxtOpnBalance.Text = "0";
            this.TxtOpnBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtOpnBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOpnBalance_KeyPress);
            // 
            // TxtPrintName
            // 
            this.TxtPrintName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrintName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrintName.Location = new System.Drawing.Point(113, 94);
            this.TxtPrintName.Name = "TxtPrintName";
            this.TxtPrintName.ReadOnly = true;
            this.TxtPrintName.Size = new System.Drawing.Size(215, 22);
            this.TxtPrintName.TabIndex = 1;
            this.TxtPrintName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrintName_KeyPress);
            this.TxtPrintName.Leave += new System.EventHandler(this.TxtPrintName_Leave);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(62, 126);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(46, 15);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Group";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(514, 157);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 15);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Dr. / Cr.";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(323, 157);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(28, 15);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "B/L";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(29, 98);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 15);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Print Name";
            // 
            // TxtAccName
            // 
            this.TxtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccName.Location = new System.Drawing.Point(113, 65);
            this.TxtAccName.Name = "TxtAccName";
            this.TxtAccName.ReadOnly = true;
            this.TxtAccName.Size = new System.Drawing.Size(286, 22);
            this.TxtAccName.TabIndex = 0;
            this.TxtAccName.Leave += new System.EventHandler(this.TxtAccName_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(9, 68);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 15);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Account Name";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.label6);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(936, 48);
            this.Panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Account Information";
            // 
            // lblAccountID
            // 
            this.lblAccountID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAccountID.Location = new System.Drawing.Point(498, 65);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(148, 22);
            this.lblAccountID.TabIndex = 2;
            this.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(409, 67);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 16);
            this.label27.TabIndex = 1;
            this.label27.Text = "Accound ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "In Urdu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Address - 1";
            // 
            // TxtAddr1Eng
            // 
            this.TxtAddr1Eng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddr1Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddr1Eng.Location = new System.Drawing.Point(113, 182);
            this.TxtAddr1Eng.Name = "TxtAddr1Eng";
            this.TxtAddr1Eng.ReadOnly = true;
            this.TxtAddr1Eng.Size = new System.Drawing.Size(533, 22);
            this.TxtAddr1Eng.TabIndex = 8;
            this.TxtAddr1Eng.Leave += new System.EventHandler(this.TxtAddr1Eng_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address - 2";
            // 
            // TxtAddr2Eng
            // 
            this.TxtAddr2Eng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddr2Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddr2Eng.Location = new System.Drawing.Point(113, 238);
            this.TxtAddr2Eng.Name = "TxtAddr2Eng";
            this.TxtAddr2Eng.ReadOnly = true;
            this.TxtAddr2Eng.Size = new System.Drawing.Size(533, 22);
            this.TxtAddr2Eng.TabIndex = 10;
            this.TxtAddr2Eng.Leave += new System.EventHandler(this.TxtAddr2Eng_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(321, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "City";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Area";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(510, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "P. Code";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Phone #";
            // 
            // TxtPhone
            // 
            this.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(113, 348);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.ReadOnly = true;
            this.TxtPhone.Size = new System.Drawing.Size(167, 22);
            this.TxtPhone.TabIndex = 17;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(286, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Mobile #";
            // 
            // TxtMobile
            // 
            this.TxtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMobile.Location = new System.Drawing.Point(353, 348);
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.ReadOnly = true;
            this.TxtMobile.Size = new System.Drawing.Size(293, 22);
            this.TxtMobile.TabIndex = 18;
            this.TxtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMobile_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(64, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(113, 376);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(533, 22);
            this.TxtEmail.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 408);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Contact Person";
            // 
            // TxtContactPerson
            // 
            this.TxtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContactPerson.Location = new System.Drawing.Point(113, 404);
            this.TxtContactPerson.Name = "TxtContactPerson";
            this.TxtContactPerson.ReadOnly = true;
            this.TxtContactPerson.Size = new System.Drawing.Size(533, 22);
            this.TxtContactPerson.TabIndex = 20;
            this.TxtContactPerson.Leave += new System.EventHandler(this.TxtContactPerson_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(27, 436);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Bank Name";
            // 
            // TxtBnkName
            // 
            this.TxtBnkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBnkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBnkName.Location = new System.Drawing.Point(113, 432);
            this.TxtBnkName.Name = "TxtBnkName";
            this.TxtBnkName.ReadOnly = true;
            this.TxtBnkName.Size = new System.Drawing.Size(244, 22);
            this.TxtBnkName.TabIndex = 21;
            this.TxtBnkName.Leave += new System.EventHandler(this.TxtBnkName_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(367, 436);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "Bank A/c #";
            // 
            // TxtBankAcc
            // 
            this.TxtBankAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBankAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBankAcc.Location = new System.Drawing.Point(445, 432);
            this.TxtBankAcc.Name = "TxtBankAcc";
            this.TxtBankAcc.ReadOnly = true;
            this.TxtBankAcc.Size = new System.Drawing.Size(202, 22);
            this.TxtBankAcc.TabIndex = 22;
            this.TxtBankAcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBankAcc_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(729, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 15);
            this.label19.TabIndex = 9;
            this.label19.Text = "GST #";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtGstNo
            // 
            this.TxtGstNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtGstNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGstNo.Location = new System.Drawing.Point(777, 182);
            this.TxtGstNo.Name = "TxtGstNo";
            this.TxtGstNo.ReadOnly = true;
            this.TxtGstNo.Size = new System.Drawing.Size(147, 22);
            this.TxtGstNo.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(728, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "NTN #";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNTNNo
            // 
            this.TxtNTNNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNTNNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNTNNo.Location = new System.Drawing.Point(777, 210);
            this.TxtNTNNo.Name = "TxtNTNNo";
            this.TxtNTNNo.ReadOnly = true;
            this.TxtNTNNo.Size = new System.Drawing.Size(147, 22);
            this.TxtNTNNo.TabIndex = 26;
            // 
            // TxtCNIC
            // 
            this.TxtCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCNIC.Location = new System.Drawing.Point(777, 238);
            this.TxtCNIC.Mask = "00000-0000000-0";
            this.TxtCNIC.Name = "TxtCNIC";
            this.TxtCNIC.ReadOnly = true;
            this.TxtCNIC.Size = new System.Drawing.Size(147, 22);
            this.TxtCNIC.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(724, 242);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 15);
            this.label21.TabIndex = 9;
            this.label21.Text = "CNIC #";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(702, 269);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 15);
            this.label22.TabIndex = 9;
            this.label22.Text = "Party Type";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(27, 464);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 15);
            this.label23.TabIndex = 9;
            this.label23.Text = "Credit Limit";
            // 
            // TxtCrLimit
            // 
            this.TxtCrLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCrLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCrLimit.Location = new System.Drawing.Point(113, 460);
            this.TxtCrLimit.Name = "TxtCrLimit";
            this.TxtCrLimit.ReadOnly = true;
            this.TxtCrLimit.Size = new System.Drawing.Size(244, 22);
            this.TxtCrLimit.TabIndex = 23;
            this.TxtCrLimit.Text = "0";
            this.TxtCrLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCrLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCrLimit_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(377, 464);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 15);
            this.label24.TabIndex = 9;
            this.label24.Text = "Bill Limit";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBilLimit
            // 
            this.TxtBilLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBilLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBilLimit.Location = new System.Drawing.Point(445, 460);
            this.TxtBilLimit.Name = "TxtBilLimit";
            this.TxtBilLimit.ReadOnly = true;
            this.TxtBilLimit.Size = new System.Drawing.Size(202, 22);
            this.TxtBilLimit.TabIndex = 24;
            this.TxtBilLimit.Text = "0";
            this.TxtBilLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBilLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBilLimit_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(682, 297);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 15);
            this.label25.TabIndex = 9;
            this.label25.Text = "Cr. Days Sale";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCrDaysSale
            // 
            this.TxtCrDaysSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCrDaysSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCrDaysSale.Location = new System.Drawing.Point(777, 293);
            this.TxtCrDaysSale.Name = "TxtCrDaysSale";
            this.TxtCrDaysSale.ReadOnly = true;
            this.TxtCrDaysSale.Size = new System.Drawing.Size(147, 22);
            this.TxtCrDaysSale.TabIndex = 29;
            this.TxtCrDaysSale.Text = "0";
            this.TxtCrDaysSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCrDaysSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCrDaysSale_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(670, 325);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 15);
            this.label26.TabIndex = 9;
            this.label26.Text = "Cr. Days Purch.";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCrDaysPrch
            // 
            this.TxtCrDaysPrch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCrDaysPrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCrDaysPrch.Location = new System.Drawing.Point(777, 321);
            this.TxtCrDaysPrch.Name = "TxtCrDaysPrch";
            this.TxtCrDaysPrch.ReadOnly = true;
            this.TxtCrDaysPrch.Size = new System.Drawing.Size(147, 22);
            this.TxtCrDaysPrch.TabIndex = 30;
            this.TxtCrDaysPrch.Text = "0";
            this.TxtCrDaysPrch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCrDaysPrch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCrDaysPrch_KeyPress);
            // 
            // CmbType
            // 
            this.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(777, 265);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(147, 23);
            this.CmbType.Sorted = true;
            this.CmbType.TabIndex = 28;
            // 
            // TxtPostalCode
            // 
            this.TxtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPostalCode.Location = new System.Drawing.Point(569, 293);
            this.TxtPostalCode.Name = "TxtPostalCode";
            this.TxtPostalCode.ReadOnly = true;
            this.TxtPostalCode.Size = new System.Drawing.Size(77, 22);
            this.TxtPostalCode.TabIndex = 14;
            this.TxtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtCityName
            // 
            this.TxtCityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCityName.Location = new System.Drawing.Point(353, 293);
            this.TxtCityName.Name = "TxtCityName";
            this.TxtCityName.ReadOnly = true;
            this.TxtCityName.Size = new System.Drawing.Size(142, 22);
            this.TxtCityName.TabIndex = 13;
            // 
            // TxtAccType
            // 
            this.TxtAccType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccType.Location = new System.Drawing.Point(113, 153);
            this.TxtAccType.Name = "TxtAccType";
            this.TxtAccType.ReadOnly = true;
            this.TxtAccType.Size = new System.Drawing.Size(163, 22);
            this.TxtAccType.TabIndex = 5;
            this.TxtAccType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAccType_KeyUp);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(44, 156);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 15);
            this.label28.TabIndex = 9;
            this.label28.Text = "A/c. Type";
            // 
            // TxtGroup
            // 
            this.TxtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGroup.Location = new System.Drawing.Point(113, 123);
            this.TxtGroup.Name = "TxtGroup";
            this.TxtGroup.ReadOnly = true;
            this.TxtGroup.Size = new System.Drawing.Size(163, 22);
            this.TxtGroup.TabIndex = 3;
            this.TxtGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrintName_KeyPress);
            this.TxtGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtGroup_KeyUp);
            this.TxtGroup.Leave += new System.EventHandler(this.TxtPrintName_Leave);
            // 
            // TxtAreaName
            // 
            this.TxtAreaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAreaName.Location = new System.Drawing.Point(113, 293);
            this.TxtAreaName.Name = "TxtAreaName";
            this.TxtAreaName.ReadOnly = true;
            this.TxtAreaName.Size = new System.Drawing.Size(134, 22);
            this.TxtAreaName.TabIndex = 12;
            this.TxtAreaName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAreaName_KeyUp);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Image = global::WholeSaleApplication.Properties.Resources.Back;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(808, 443);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(116, 39);
            this.BtnBack.TabIndex = 34;
            this.BtnBack.Text = "&Back";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Image = global::WholeSaleApplication.Properties.Resources.Update;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(686, 443);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(116, 39);
            this.BtnUpdate.TabIndex = 33;
            this.BtnUpdate.Text = "&Update";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Image = global::WholeSaleApplication.Properties.Resources.Comment;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(808, 398);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(116, 39);
            this.BtnEdit.TabIndex = 32;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Image = global::WholeSaleApplication.Properties.Resources.Create;
            this.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreate.Location = new System.Drawing.Point(686, 398);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(116, 39);
            this.BtnCreate.TabIndex = 31;
            this.BtnCreate.Text = "&Create";
            this.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WholeSaleApplication.Properties.Resources.Administrator_64;
            this.pictureBox1.Location = new System.Drawing.Point(838, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAccType
            // 
            this.BtnAccType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAccType.Image = global::WholeSaleApplication.Properties.Resources.search1;
            this.BtnAccType.Location = new System.Drawing.Point(281, 152);
            this.BtnAccType.Name = "BtnAccType";
            this.BtnAccType.Size = new System.Drawing.Size(30, 24);
            this.BtnAccType.TabIndex = 4;
            this.BtnAccType.TabStop = false;
            this.BtnAccType.UseVisualStyleBackColor = true;
            this.BtnAccType.Click += new System.EventHandler(this.BtnAccType_Click);
            // 
            // BtnViewArea
            // 
            this.BtnViewArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnViewArea.Image = global::WholeSaleApplication.Properties.Resources.search1;
            this.BtnViewArea.Location = new System.Drawing.Point(252, 292);
            this.BtnViewArea.Name = "BtnViewArea";
            this.BtnViewArea.Size = new System.Drawing.Size(30, 24);
            this.BtnViewArea.TabIndex = 4;
            this.BtnViewArea.TabStop = false;
            this.BtnViewArea.UseVisualStyleBackColor = true;
            this.BtnViewArea.Click += new System.EventHandler(this.BtnViewArea_Click);
            // 
            // BtnAddArea
            // 
            this.BtnAddArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddArea.Image = global::WholeSaleApplication.Properties.Resources.folder_add1;
            this.BtnAddArea.Location = new System.Drawing.Point(286, 292);
            this.BtnAddArea.Name = "BtnAddArea";
            this.BtnAddArea.Size = new System.Drawing.Size(30, 24);
            this.BtnAddArea.TabIndex = 99;
            this.BtnAddArea.TabStop = false;
            this.BtnAddArea.UseVisualStyleBackColor = true;
            this.BtnAddArea.Click += new System.EventHandler(this.BtnAddArea_Click);
            // 
            // BtnViewGroup
            // 
            this.BtnViewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnViewGroup.Image = global::WholeSaleApplication.Properties.Resources.search1;
            this.BtnViewGroup.Location = new System.Drawing.Point(281, 121);
            this.BtnViewGroup.Name = "BtnViewGroup";
            this.BtnViewGroup.Size = new System.Drawing.Size(30, 24);
            this.BtnViewGroup.TabIndex = 4;
            this.BtnViewGroup.TabStop = false;
            this.BtnViewGroup.UseVisualStyleBackColor = true;
            this.BtnViewGroup.Click += new System.EventHandler(this.BtnViewGroup_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(350, 127);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 15);
            this.label29.TabIndex = 101;
            this.label29.Text = "Account Head";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAreaUrdu
            // 
            this.TxtAreaUrdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAreaUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAreaUrdu.Location = new System.Drawing.Point(353, 321);
            this.TxtAreaUrdu.Name = "TxtAreaUrdu";
            this.TxtAreaUrdu.ReadOnly = true;
            this.TxtAreaUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtAreaUrdu.Size = new System.Drawing.Size(293, 22);
            this.TxtAreaUrdu.TabIndex = 16;
            // 
            // TxtAddr2Urdu
            // 
            this.TxtAddr2Urdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddr2Urdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddr2Urdu.Location = new System.Drawing.Point(113, 265);
            this.TxtAddr2Urdu.Name = "TxtAddr2Urdu";
            this.TxtAddr2Urdu.ReadOnly = true;
            this.TxtAddr2Urdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtAddr2Urdu.Size = new System.Drawing.Size(533, 22);
            this.TxtAddr2Urdu.TabIndex = 11;
            // 
            // TxtAddr1Urdu
            // 
            this.TxtAddr1Urdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddr1Urdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddr1Urdu.Location = new System.Drawing.Point(113, 210);
            this.TxtAddr1Urdu.Name = "TxtAddr1Urdu";
            this.TxtAddr1Urdu.ReadOnly = true;
            this.TxtAddr1Urdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtAddr1Urdu.Size = new System.Drawing.Size(533, 22);
            this.TxtAddr1Urdu.TabIndex = 9;
            // 
            // TxtCityUrdu
            // 
            this.TxtCityUrdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCityUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCityUrdu.Location = new System.Drawing.Point(113, 321);
            this.TxtCityUrdu.Name = "TxtCityUrdu";
            this.TxtCityUrdu.ReadOnly = true;
            this.TxtCityUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCityUrdu.Size = new System.Drawing.Size(233, 22);
            this.TxtCityUrdu.TabIndex = 15;
            // 
            // TxtAccNameUrdu
            // 
            this.TxtAccNameUrdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccNameUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccNameUrdu.Location = new System.Drawing.Point(404, 94);
            this.TxtAccNameUrdu.Name = "TxtAccNameUrdu";
            this.TxtAccNameUrdu.ReadOnly = true;
            this.TxtAccNameUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtAccNameUrdu.Size = new System.Drawing.Size(242, 22);
            this.TxtAccNameUrdu.TabIndex = 2;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 496);
            this.Controls.Add(this.CbAccHead);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.TxtAccType);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.TxtAreaUrdu);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.TxtAddr2Urdu);
            this.Controls.Add(this.TxtAddr1Urdu);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtCityUrdu);
            this.Controls.Add(this.TxtAccNameUrdu);
            this.Controls.Add(this.TxtCNIC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAccType);
            this.Controls.Add(this.BtnViewArea);
            this.Controls.Add(this.BtnAddArea);
            this.Controls.Add(this.BtnViewGroup);
            this.Controls.Add(this.BtnAddGrp);
            this.Controls.Add(this.CmbDrCr);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.TxtOpnBalance);
            this.Controls.Add(this.TxtMobile);
            this.Controls.Add(this.TxtCityName);
            this.Controls.Add(this.TxtPostalCode);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtBilLimit);
            this.Controls.Add(this.TxtCrLimit);
            this.Controls.Add(this.TxtCrDaysPrch);
            this.Controls.Add(this.TxtCrDaysSale);
            this.Controls.Add(this.TxtNTNNo);
            this.Controls.Add(this.TxtGstNo);
            this.Controls.Add(this.TxtBankAcc);
            this.Controls.Add(this.TxtBnkName);
            this.Controls.Add(this.TxtAreaName);
            this.Controls.Add(this.TxtGroup);
            this.Controls.Add(this.TxtPrintName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtContactPerson);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtAddr2Eng);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtAddr1Eng);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtAccName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewAccBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnAddGrp;
        internal System.Windows.Forms.ComboBox CmbDrCr;
        internal System.Windows.Forms.TextBox TxtOpnBalance;
        internal System.Windows.Forms.TextBox TxtPrintName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtAccName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label6;
        //private UrduTextBoxDemo.UrduTextBox urduTextBox1;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox TxtAddr1Eng;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox TxtAddr2Eng;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        //private UrduTextBoxDemo.UrduTextBox urduTextBox2;
        //private UrduTextBoxDemo.UrduTextBox urduTextBox3;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox TxtPhone;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox TxtMobile;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox TxtEmail;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox TxtContactPerson;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox TxtBnkName;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox TxtBankAcc;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox TxtGstNo;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox TxtNTNNo;
        private System.Windows.Forms.MaskedTextBox TxtCNIC;
        internal System.Windows.Forms.Label label21;
        private UrduTextBoxDemo.UrduTextBox TxtAccNameUrdu;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.TextBox TxtCrLimit;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.TextBox TxtBilLimit;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.TextBox TxtCrDaysSale;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.TextBox TxtCrDaysPrch;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private UrduTextBoxDemo.UrduTextBox TxtCityUrdu;
        private System.Windows.Forms.Label label27;
        private UrduTextBoxDemo.UrduTextBox TxtAddr1Urdu;
        private UrduTextBoxDemo.UrduTextBox TxtAddr2Urdu;
        private UrduTextBoxDemo.UrduTextBox TxtAreaUrdu;
        internal System.Windows.Forms.TextBox TxtPostalCode;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.BindingSource NewAccBindingSource;
        internal System.Windows.Forms.TextBox TxtCityName;
        internal System.Windows.Forms.Button BtnAccType;
        internal System.Windows.Forms.Label label28;
        internal System.Windows.Forms.TextBox TxtGroup;
        internal System.Windows.Forms.Button BtnViewGroup;
        internal System.Windows.Forms.TextBox TxtAreaName;
        internal System.Windows.Forms.Button BtnAddArea;
        internal System.Windows.Forms.Button BtnViewArea;
        private System.Windows.Forms.TextBox TxtAccType;
        private System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.Label lblAccountID;
        internal System.Windows.Forms.ComboBox CbAccHead;
        internal System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox CmbType;
    }
}