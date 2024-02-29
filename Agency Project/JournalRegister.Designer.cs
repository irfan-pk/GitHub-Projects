
namespace WholeSaleApplication
{
    partial class JournalRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalRegister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.tbDebit = new System.Windows.Forms.TextBox();
            this.tbNarration = new System.Windows.Forms.TextBox();
            this.tbVoucherNo = new System.Windows.Forms.TextBox();
            this.cbAccountName = new System.Windows.Forms.ComboBox();
            this.tbAccId = new SeaRisenLib2.Controls.NumericTextBox();
            this.lblAccHead = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTranId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDeleteRec = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalCredit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalDebit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvJournal = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCredit);
            this.panel1.Controls.Add(this.tbDebit);
            this.panel1.Controls.Add(this.tbNarration);
            this.panel1.Controls.Add(this.tbVoucherNo);
            this.panel1.Controls.Add(this.cbAccountName);
            this.panel1.Controls.Add(this.tbAccId);
            this.panel1.Controls.Add(this.lblAccHead);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblTranId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 144);
            this.panel1.TabIndex = 0;
            // 
            // tbCredit
            // 
            this.tbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCredit.Location = new System.Drawing.Point(821, 92);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.Size = new System.Drawing.Size(149, 24);
            this.tbCredit.TabIndex = 6;
            this.tbCredit.Text = "0";
            this.tbCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCredit_KeyDown_1);
            this.tbCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCredit_KeyPress);
            // 
            // tbDebit
            // 
            this.tbDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDebit.Location = new System.Drawing.Point(621, 92);
            this.tbDebit.Name = "tbDebit";
            this.tbDebit.Size = new System.Drawing.Size(149, 24);
            this.tbDebit.TabIndex = 5;
            this.tbDebit.Text = "0";
            this.tbDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDebit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDebit_KeyDown);
            this.tbDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDebit_KeyPress);
            // 
            // tbNarration
            // 
            this.tbNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNarration.Location = new System.Drawing.Point(90, 93);
            this.tbNarration.Name = "tbNarration";
            this.tbNarration.Size = new System.Drawing.Size(410, 24);
            this.tbNarration.TabIndex = 4;
            // 
            // tbVoucherNo
            // 
            this.tbVoucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVoucherNo.Location = new System.Drawing.Point(621, 55);
            this.tbVoucherNo.Name = "tbVoucherNo";
            this.tbVoucherNo.Size = new System.Drawing.Size(349, 24);
            this.tbVoucherNo.TabIndex = 3;
            // 
            // cbAccountName
            // 
            this.cbAccountName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountName.FormattingEnabled = true;
            this.cbAccountName.Location = new System.Drawing.Point(218, 55);
            this.cbAccountName.Name = "cbAccountName";
            this.cbAccountName.Size = new System.Drawing.Size(282, 24);
            this.cbAccountName.TabIndex = 2;
            this.cbAccountName.SelectedIndexChanged += new System.EventHandler(this.cbAccountName_SelectedIndexChanged);
            // 
            // tbAccId
            // 
            this.tbAccId.DecimalNumbers = 2;
            this.tbAccId.DecimalText = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbAccId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccId.ForeColor = System.Drawing.Color.Black;
            this.tbAccId.Format = "^(\\-?)(\\d*)(\\.?)(\\d?)(\\d?)$";
            this.tbAccId.HasNegatives = true;
            this.tbAccId.Location = new System.Drawing.Point(90, 55);
            this.tbAccId.Name = "tbAccId";
            this.tbAccId.Size = new System.Drawing.Size(122, 24);
            this.tbAccId.TabIndex = 1;
            this.tbAccId.Text = "0";
            this.tbAccId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccHead
            // 
            this.lblAccHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccHead.Location = new System.Drawing.Point(759, 19);
            this.lblAccHead.Name = "lblAccHead";
            this.lblAccHead.Size = new System.Drawing.Size(212, 22);
            this.lblAccHead.TabIndex = 1;
            this.lblAccHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Narration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(776, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Credit";
            // 
            // lblTranId
            // 
            this.lblTranId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTranId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranId.Location = new System.Drawing.Point(621, 19);
            this.lblTranId.Name = "lblTranId";
            this.lblTranId.Size = new System.Drawing.Size(129, 22);
            this.lblTranId.TabIndex = 1;
            this.lblTranId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Debit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(537, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Document #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trans. #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(90, 19);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(229, 22);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnDeleteRec);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 76);
            this.panel2.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.LightGray;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Image = global::WholeSaleApplication.Properties.Resources.Alert;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(278, 19);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(126, 37);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "&Close";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDeleteRec
            // 
            this.BtnDeleteRec.BackColor = System.Drawing.Color.LightGray;
            this.BtnDeleteRec.Enabled = false;
            this.BtnDeleteRec.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDeleteRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnDeleteRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteRec.Image = global::WholeSaleApplication.Properties.Resources.Delete;
            this.BtnDeleteRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteRec.Location = new System.Drawing.Point(146, 19);
            this.BtnDeleteRec.Name = "BtnDeleteRec";
            this.BtnDeleteRec.Size = new System.Drawing.Size(126, 37);
            this.BtnDeleteRec.TabIndex = 9;
            this.BtnDeleteRec.Text = "&Delete";
            this.BtnDeleteRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteRec.UseVisualStyleBackColor = false;
            this.BtnDeleteRec.Click += new System.EventHandler(this.BtnDeleteRec_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.LightGray;
            this.BtnSave.Enabled = false;
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::WholeSaleApplication.Properties.Resources.Add;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(14, 19);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 37);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "&Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.lblTotalCredit);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(821, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 71);
            this.panel4.TabIndex = 133;
            // 
            // lblTotalCredit
            // 
            this.lblTotalCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredit.ForeColor = System.Drawing.Color.White;
            this.lblTotalCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalCredit.Location = new System.Drawing.Point(0, 26);
            this.lblTotalCredit.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCredit.Name = "lblTotalCredit";
            this.lblTotalCredit.Size = new System.Drawing.Size(160, 45);
            this.lblTotalCredit.TabIndex = 130;
            this.lblTotalCredit.Text = "0";
            this.lblTotalCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 26);
            this.label10.TabIndex = 101;
            this.label10.Text = "Total Credit";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.lblTotalDebit);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(659, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 71);
            this.panel5.TabIndex = 132;
            // 
            // lblTotalDebit
            // 
            this.lblTotalDebit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebit.ForeColor = System.Drawing.Color.White;
            this.lblTotalDebit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalDebit.Location = new System.Drawing.Point(0, 26);
            this.lblTotalDebit.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalDebit.Name = "lblTotalDebit";
            this.lblTotalDebit.Size = new System.Drawing.Size(160, 45);
            this.lblTotalDebit.TabIndex = 130;
            this.lblTotalDebit.Text = "0";
            this.lblTotalDebit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 26);
            this.label14.TabIndex = 101;
            this.label14.Text = "Total Debit";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvJournal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 391);
            this.panel3.TabIndex = 2;
            // 
            // DgvJournal
            // 
            this.DgvJournal.AllowUserToAddRows = false;
            this.DgvJournal.AllowUserToResizeColumns = false;
            this.DgvJournal.AllowUserToResizeRows = false;
            this.DgvJournal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvJournal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvJournal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvJournal.ColumnHeadersHeight = 32;
            this.DgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Column3,
            this.Column2,
            this.Col4,
            this.Column1,
            this.Col5,
            this.Col3,
            this.Column5,
            this.Col6,
            this.Col7,
            this.Column6,
            this.Column4,
            this.Column7});
            this.DgvJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvJournal.EnableHeadersVisualStyles = false;
            this.DgvJournal.Location = new System.Drawing.Point(0, 0);
            this.DgvJournal.MultiSelect = false;
            this.DgvJournal.Name = "DgvJournal";
            this.DgvJournal.ReadOnly = true;
            this.DgvJournal.RowHeadersVisible = false;
            this.DgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvJournal.Size = new System.Drawing.Size(984, 391);
            this.DgvJournal.TabIndex = 99;
            this.DgvJournal.TabStop = false;
            // 
            // Col1
            // 
            this.Col1.DataPropertyName = "LEDG_DATE";
            this.Col1.HeaderText = "Date";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Width = 90;
            // 
            // Col2
            // 
            this.Col2.DataPropertyName = "LEDG_TRAN_ID";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.Col2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col2.HeaderText = "Trans #";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LedgType";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Acc Head";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Col4
            // 
            this.Col4.DataPropertyName = "LEDG_ACC_ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Col4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col4.HeaderText = "Acc ID";
            this.Col4.MaxInputLength = 20;
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            this.Col4.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ledg_sub_acc";
            this.Column1.HeaderText = "Account Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 143;
            // 
            // Col5
            // 
            this.Col5.DataPropertyName = "LEDG_VOUCHER_NO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Col5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col5.HeaderText = "Doc #";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.DataPropertyName = "ledg_narration";
            this.Col3.HeaderText = "Narration";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Width = 280;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ledgacctype";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Col6
            // 
            this.Col6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col6.DataPropertyName = "ledg_debit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.Col6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col6.HeaderText = "Debit";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col7.DataPropertyName = "ledg_credit";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.Col7.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col7.HeaderText = "Credit";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ledgbal";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ledgsort";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ledgfyear";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // JournalRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JournalRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Register";
            this.Load += new System.EventHandler(this.JournalRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTranId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccHead;
        private SeaRisenLib2.Controls.NumericTextBox tbAccId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAccountName;
        private System.Windows.Forms.TextBox tbVoucherNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNarration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.DataGridView DgvJournal;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Label lblTotalCredit;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Label lblTotalDebit;
        protected System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.TextBox tbCredit;
        private System.Windows.Forms.TextBox tbDebit;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDeleteRec;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}