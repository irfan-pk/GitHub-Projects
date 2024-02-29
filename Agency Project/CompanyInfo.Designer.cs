
namespace WholeSaleApplication
{
    partial class CompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbCNIC = new System.Windows.Forms.MaskedTextBox();
            this.TbLandLine = new SeaRisenLib2.Controls.NumericTextBox();
            this.TbMobile = new SeaRisenLib2.Controls.NumericTextBox();
            this.TbPin = new SeaRisenLib2.Controls.NumericTextBox();
            this.TbZip = new SeaRisenLib2.Controls.NumericTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbAddr2Ur = new UrduTextBoxDemo.UrduTextBox();
            this.TbAddr1Ur = new UrduTextBoxDemo.UrduTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TbNameUr = new UrduTextBoxDemo.UrduTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbGST = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TbDeals = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TbAddr2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbAddr1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbCNIC);
            this.groupBox1.Controls.Add(this.TbLandLine);
            this.groupBox1.Controls.Add(this.TbMobile);
            this.groupBox1.Controls.Add(this.TbPin);
            this.groupBox1.Controls.Add(this.TbZip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbAddr2Ur);
            this.groupBox1.Controls.Add(this.TbAddr1Ur);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TbNameUr);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TbState);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TbCity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbGST);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TbDeals);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TbEmail);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TbAddr2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbAddr1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TbCNIC
            // 
            this.TbCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCNIC.Location = new System.Drawing.Point(553, 144);
            this.TbCNIC.Mask = "00000-0000000-0";
            this.TbCNIC.Name = "TbCNIC";
            this.TbCNIC.Size = new System.Drawing.Size(149, 26);
            this.TbCNIC.TabIndex = 14;
            // 
            // TbLandLine
            // 
            this.TbLandLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbLandLine.DecimalNumbers = 2;
            this.TbLandLine.DecimalText = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TbLandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLandLine.ForeColor = System.Drawing.Color.Black;
            this.TbLandLine.Format = "^(\\-?)(\\d*)(\\.?)(\\d?)(\\d?)$";
            this.TbLandLine.HasNegatives = true;
            this.TbLandLine.Location = new System.Drawing.Point(120, 208);
            this.TbLandLine.Name = "TbLandLine";
            this.TbLandLine.Size = new System.Drawing.Size(345, 26);
            this.TbLandLine.TabIndex = 11;
            this.TbLandLine.Text = "0";
            // 
            // TbMobile
            // 
            this.TbMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMobile.DecimalNumbers = 2;
            this.TbMobile.DecimalText = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TbMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMobile.ForeColor = System.Drawing.Color.Black;
            this.TbMobile.Format = "^(\\-?)(\\d*)(\\.?)(\\d?)(\\d?)$";
            this.TbMobile.HasNegatives = true;
            this.TbMobile.Location = new System.Drawing.Point(120, 176);
            this.TbMobile.Name = "TbMobile";
            this.TbMobile.Size = new System.Drawing.Size(345, 26);
            this.TbMobile.TabIndex = 10;
            this.TbMobile.Text = "0";
            // 
            // TbPin
            // 
            this.TbPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPin.DecimalNumbers = 2;
            this.TbPin.DecimalText = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPin.ForeColor = System.Drawing.Color.Black;
            this.TbPin.Format = "^(\\-?)(\\d*)(\\.?)(\\d?)(\\d?)$";
            this.TbPin.HasNegatives = true;
            this.TbPin.Location = new System.Drawing.Point(343, 144);
            this.TbPin.Name = "TbPin";
            this.TbPin.Size = new System.Drawing.Size(122, 26);
            this.TbPin.TabIndex = 9;
            this.TbPin.Text = "0";
            // 
            // TbZip
            // 
            this.TbZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbZip.DecimalNumbers = 2;
            this.TbZip.DecimalText = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TbZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbZip.ForeColor = System.Drawing.Color.Black;
            this.TbZip.Format = "^(\\-?)(\\d*)(\\.?)(\\d?)(\\d?)$";
            this.TbZip.HasNegatives = true;
            this.TbZip.Location = new System.Drawing.Point(343, 112);
            this.TbZip.Name = "TbZip";
            this.TbZip.Size = new System.Drawing.Size(122, 26);
            this.TbZip.TabIndex = 7;
            this.TbZip.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "In Urdu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "In Urdu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "In Urdu";
            // 
            // TbAddr2Ur
            // 
            this.TbAddr2Ur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAddr2Ur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAddr2Ur.Location = new System.Drawing.Point(552, 80);
            this.TbAddr2Ur.Name = "TbAddr2Ur";
            this.TbAddr2Ur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbAddr2Ur.Size = new System.Drawing.Size(254, 26);
            this.TbAddr2Ur.TabIndex = 5;
            // 
            // TbAddr1Ur
            // 
            this.TbAddr1Ur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAddr1Ur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAddr1Ur.Location = new System.Drawing.Point(552, 48);
            this.TbAddr1Ur.Name = "TbAddr1Ur";
            this.TbAddr1Ur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbAddr1Ur.Size = new System.Drawing.Size(254, 26);
            this.TbAddr1Ur.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Land Line";
            // 
            // TbNameUr
            // 
            this.TbNameUr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNameUr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNameUr.Location = new System.Drawing.Point(552, 16);
            this.TbNameUr.Name = "TbNameUr";
            this.TbNameUr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbNameUr.Size = new System.Drawing.Size(254, 26);
            this.TbNameUr.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mobile";
            // 
            // TbState
            // 
            this.TbState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbState.Location = new System.Drawing.Point(120, 144);
            this.TbState.Name = "TbState";
            this.TbState.Size = new System.Drawing.Size(143, 26);
            this.TbState.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(298, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Code";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(497, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "CNIC #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "State / Province";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Zip Code";
            // 
            // TbCity
            // 
            this.TbCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCity.Location = new System.Drawing.Point(120, 112);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(143, 26);
            this.TbCity.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "City";
            // 
            // TbGST
            // 
            this.TbGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbGST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbGST.Location = new System.Drawing.Point(552, 112);
            this.TbGST.Name = "TbGST";
            this.TbGST.Size = new System.Drawing.Size(254, 26);
            this.TbGST.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(491, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "G.S.T. #";
            // 
            // TbDeals
            // 
            this.TbDeals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDeals.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbDeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDeals.Location = new System.Drawing.Point(552, 176);
            this.TbDeals.Name = "TbDeals";
            this.TbDeals.Size = new System.Drawing.Size(254, 26);
            this.TbDeals.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(489, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Deals In";
            // 
            // TbEmail
            // 
            this.TbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.Location = new System.Drawing.Point(119, 240);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(346, 26);
            this.TbEmail.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Email";
            // 
            // TbAddr2
            // 
            this.TbAddr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAddr2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbAddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAddr2.Location = new System.Drawing.Point(120, 80);
            this.TbAddr2.Name = "TbAddr2";
            this.TbAddr2.Size = new System.Drawing.Size(346, 26);
            this.TbAddr2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address 2";
            // 
            // TbAddr1
            // 
            this.TbAddr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAddr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbAddr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAddr1.Location = new System.Drawing.Point(120, 48);
            this.TbAddr1.Name = "TbAddr1";
            this.TbAddr1.Size = new System.Drawing.Size(346, 26);
            this.TbAddr1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // TbName
            // 
            this.TbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbName.Location = new System.Drawing.Point(120, 17);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(346, 26);
            this.TbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Company Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(7, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WholeSaleApplication.Properties.Resources.Turn_off;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(684, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 51);
            this.button2.TabIndex = 14;
            this.button2.Text = "&Close";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WholeSaleApplication.Properties.Resources.Save;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(552, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Save";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompanyInfo";
            this.Text = "Company Information";
            this.Load += new System.EventHandler(this.CompanyInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TbCNIC;
        private SeaRisenLib2.Controls.NumericTextBox TbLandLine;
        private SeaRisenLib2.Controls.NumericTextBox TbMobile;
        private SeaRisenLib2.Controls.NumericTextBox TbPin;
        private SeaRisenLib2.Controls.NumericTextBox TbZip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private UrduTextBoxDemo.UrduTextBox TbAddr2Ur;
        private UrduTextBoxDemo.UrduTextBox TbAddr1Ur;
        private System.Windows.Forms.Label label12;
        private UrduTextBoxDemo.UrduTextBox TbNameUr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbGST;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbDeals;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TbAddr2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbAddr1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}