using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Journal : Form
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
            var DataGridViewCellStyle45 = new DataGridViewCellStyle();
            var DataGridViewCellStyle53 = new DataGridViewCellStyle();
            var DataGridViewCellStyle54 = new DataGridViewCellStyle();
            var DataGridViewCellStyle55 = new DataGridViewCellStyle();
            var DataGridViewCellStyle46 = new DataGridViewCellStyle();
            var DataGridViewCellStyle47 = new DataGridViewCellStyle();
            var DataGridViewCellStyle48 = new DataGridViewCellStyle();
            var DataGridViewCellStyle49 = new DataGridViewCellStyle();
            var DataGridViewCellStyle50 = new DataGridViewCellStyle();
            var DataGridViewCellStyle51 = new DataGridViewCellStyle();
            var DataGridViewCellStyle52 = new DataGridViewCellStyle();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            Panel1.MouseMove += new MouseEventHandler(Panel1_MouseMove);
            Panel1.MouseUp += new MouseEventHandler(Panel1_MouseUp);
            cmdMin = new Button();
            cmdMin.Click += new EventHandler(cmdMin_Click);
            Label5 = new Label();
            Panel2 = new Panel();
            Label6 = new Label();
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            Label4 = new Label();
            txtTran = new TextBox();
            TranDate = new DateTimePicker();
            Label2 = new Label();
            txtCredit = new TextBox();
            txtCredit.KeyDown += new KeyEventHandler(txtCredit_KeyDown);
            txtCredit.KeyPress += new KeyPressEventHandler(txtCredit_KeyPress);
            txtCredit.KeyUp += new KeyEventHandler(txtCredit_KeyUp);
            Label3 = new Label();
            txtDescription = new TextBox();
            Label1 = new Label();
            txtID = new TextBox();
            txtID.KeyDown += new KeyEventHandler(txtID_KeyDown);
            txtID.KeyUp += new KeyEventHandler(txtID_KeyUp);
            lblPhone = new Label();
            txtDebit = new TextBox();
            txtDebit.KeyDown += new KeyEventHandler(txtDebit_KeyDown);
            txtDebit.KeyPress += new KeyPressEventHandler(txtDebit_KeyPress);
            txtDebit.KeyUp += new KeyEventHandler(txtDebit_KeyUp);
            lblName = new Label();
            txtName = new TextBox();
            PaymentDataGridView = new DataGridView();
            colTranID = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colOpnBal = new DataGridViewTextBoxColumn();
            colDebit = new DataGridViewTextBoxColumn();
            colCredit = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            PayBindingSource = new BindingSource(components);
            PaymentDataSet = new DataSet();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PayBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(cmdMin);
            Panel1.Controls.Add(Label5);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(942, 49);
            Panel1.TabIndex = 0;
            // 
            // cmdMin
            // 
            cmdMin.BackColor = Color.FromArgb(64, 64, 64);
            cmdMin.BackgroundImageLayout = ImageLayout.Center;
            cmdMin.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            cmdMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            cmdMin.FlatAppearance.MouseOverBackColor = Color.Gray;
            cmdMin.FlatStyle = FlatStyle.Flat;
            cmdMin.Font = new Font("Arial", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdMin.ForeColor = Color.FromArgb(224, 224, 224);
            cmdMin.Location = new Point(908, 7);
            cmdMin.Name = "cmdMin";
            cmdMin.Size = new Size(29, 34);
            cmdMin.TabIndex = 99;
            cmdMin.TabStop = false;
            cmdMin.Text = "----";
            cmdMin.UseVisualStyleBackColor = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.Red;
            Label5.ImageAlign = ContentAlignment.MiddleLeft;
            Label5.Location = new Point(3, 8);
            Label5.Name = "Label5";
            Label5.Size = new Size(374, 31);
            Label5.TabIndex = 5;
            Label5.Text = "Wholesaler General Journal";
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Gray;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(PictureBox1);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(cmdClose);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(txtTran);
            Panel2.Controls.Add(TranDate);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(txtCredit);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(txtDescription);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(txtID);
            Panel2.Controls.Add(lblPhone);
            Panel2.Controls.Add(txtDebit);
            Panel2.Controls.Add(lblName);
            Panel2.Controls.Add(txtName);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 49);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(942, 126);
            Panel2.TabIndex = 13;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.Yellow;
            Label6.Location = new Point(143, 12);
            Label6.Name = "Label6";
            Label6.Size = new Size(105, 13);
            Label6.TabIndex = 38;
            Label6.Text = "Transaction Date";
            // 
            // cmdClose
            // 
            cmdClose.BackColor = SystemColors.Control;
            cmdClose.BackgroundImageLayout = ImageLayout.Center;
            cmdClose.FlatStyle = FlatStyle.Popup;
            cmdClose.Image = My.Resources.Resources._1480382931_Log_Out2;
            cmdClose.Location = new Point(815, 26);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(92, 71);
            cmdClose.TabIndex = 8;
            cmdClose.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.Yellow;
            Label4.Location = new Point(374, 13);
            Label4.Name = "Label4";
            Label4.Size = new Size(86, 13);
            Label4.TabIndex = 37;
            Label4.Text = "Transaction #";
            // 
            // txtTran
            // 
            txtTran.BorderStyle = BorderStyle.FixedSingle;
            txtTran.Location = new Point(377, 30);
            txtTran.Name = "txtTran";
            txtTran.ReadOnly = true;
            txtTran.Size = new Size(115, 20);
            txtTran.TabIndex = 2;
            txtTran.TextAlign = HorizontalAlignment.Center;
            // 
            // TranDate
            // 
            TranDate.Location = new Point(146, 30);
            TranDate.Name = "TranDate";
            TranDate.Size = new Size(215, 20);
            TranDate.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.Yellow;
            Label2.Location = new Point(640, 61);
            Label2.Name = "Label2";
            Label2.Size = new Size(86, 13);
            Label2.TabIndex = 34;
            Label2.Text = "Credit Amount";
            // 
            // txtCredit
            // 
            txtCredit.BorderStyle = BorderStyle.FixedSingle;
            txtCredit.Location = new Point(643, 77);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(125, 20);
            txtCredit.TabIndex = 6;
            txtCredit.Text = "00";
            txtCredit.TextAlign = HorizontalAlignment.Right;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Yellow;
            Label3.Location = new Point(13, 61);
            Label3.Name = "Label3";
            Label3.Size = new Size(71, 13);
            Label3.TabIndex = 33;
            Label3.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(16, 77);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(476, 20);
            txtDescription.TabIndex = 4;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Yellow;
            Label1.Location = new Point(13, 11);
            Label1.Name = "Label1";
            Label1.Size = new Size(87, 13);
            Label1.TabIndex = 29;
            Label1.Text = "Wholesaler ID";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(16, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(85, 20);
            txtID.TabIndex = 0;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Yellow;
            lblPhone.Location = new Point(509, 61);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(83, 13);
            lblPhone.TabIndex = 27;
            lblPhone.Text = "Debit Amount";
            // 
            // txtDebit
            // 
            txtDebit.BorderStyle = BorderStyle.FixedSingle;
            txtDebit.Location = new Point(512, 77);
            txtDebit.Name = "txtDebit";
            txtDebit.Size = new Size(125, 20);
            txtDebit.TabIndex = 5;
            txtDebit.Text = "00";
            txtDebit.TextAlign = HorizontalAlignment.Right;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Yellow;
            lblName.Location = new Point(509, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(106, 13);
            lblName.TabIndex = 25;
            lblName.Text = "Wholesaler Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(512, 30);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(256, 20);
            txtName.TabIndex = 3;
            // 
            // PaymentDataGridView
            // 
            PaymentDataGridView.AllowUserToAddRows = false;
            PaymentDataGridView.AllowUserToDeleteRows = false;
            PaymentDataGridView.AllowUserToResizeColumns = false;
            PaymentDataGridView.AllowUserToResizeRows = false;
            PaymentDataGridView.AutoGenerateColumns = false;
            PaymentDataGridView.BackgroundColor = Color.FromArgb(192, 255, 192);
            PaymentDataGridView.BorderStyle = BorderStyle.Fixed3D;
            PaymentDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            DataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle45.BackColor = SystemColors.Control;
            DataGridViewCellStyle45.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle45.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle45.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle45.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle45.WrapMode = DataGridViewTriState.False;
            PaymentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle45;
            PaymentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDataGridView.Columns.AddRange(new DataGridViewColumn[] { colTranID, colDate, colID, colDesc, colOpnBal, colDebit, colCredit, colBalance });
            PaymentDataGridView.DataSource = PayBindingSource;
            DataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle53.BackColor = Color.FromArgb(192, 255, 192);
            DataGridViewCellStyle53.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle53.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle53.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle53.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle53.WrapMode = DataGridViewTriState.False;
            PaymentDataGridView.DefaultCellStyle = DataGridViewCellStyle53;
            PaymentDataGridView.Dock = DockStyle.Fill;
            PaymentDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            PaymentDataGridView.Location = new Point(0, 175);
            PaymentDataGridView.MultiSelect = false;
            PaymentDataGridView.Name = "PaymentDataGridView";
            PaymentDataGridView.ReadOnly = true;
            DataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle54.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle54.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle54.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle54.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle54.SelectionForeColor = Color.Black;
            DataGridViewCellStyle54.WrapMode = DataGridViewTriState.True;
            PaymentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle54;
            PaymentDataGridView.RowHeadersVisible = false;
            DataGridViewCellStyle55.BackColor = Color.FromArgb(192, 255, 192);
            PaymentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle55;
            PaymentDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            PaymentDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Blue;
            PaymentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PaymentDataGridView.Size = new Size(942, 296);
            PaymentDataGridView.TabIndex = 14;
            PaymentDataGridView.TabStop = false;
            // 
            // colTranID
            // 
            colTranID.DataPropertyName = "SUPL_TR_ID";
            DataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTranID.DefaultCellStyle = DataGridViewCellStyle46;
            colTranID.HeaderText = "Trans #";
            colTranID.Name = "colTranID";
            colTranID.ReadOnly = true;
            colTranID.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTranID.Width = 80;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "SUPL_TR_DT";
            DataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDate.DefaultCellStyle = DataGridViewCellStyle47;
            colDate.HeaderText = "Trans Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            colDate.Width = 80;
            // 
            // colID
            // 
            colID.DataPropertyName = "SUPL_CODE";
            DataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colID.DefaultCellStyle = DataGridViewCellStyle48;
            colID.HeaderText = "Supplier ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.SortMode = DataGridViewColumnSortMode.NotSortable;
            colID.Width = 80;
            // 
            // colDesc
            // 
            colDesc.DataPropertyName = "Supl_DESC";
            colDesc.HeaderText = "Description";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            colDesc.SortMode = DataGridViewColumnSortMode.NotSortable;
            colDesc.Width = 288;
            // 
            // colOpnBal
            // 
            colOpnBal.DataPropertyName = "Supl_opn_bal";
            DataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleRight;
            colOpnBal.DefaultCellStyle = DataGridViewCellStyle49;
            colOpnBal.HeaderText = "Opening B/L";
            colOpnBal.Name = "colOpnBal";
            colOpnBal.ReadOnly = true;
            colOpnBal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colDebit
            // 
            colDebit.DataPropertyName = "Supl_debit";
            DataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDebit.DefaultCellStyle = DataGridViewCellStyle50;
            colDebit.HeaderText = "Debit";
            colDebit.Name = "colDebit";
            colDebit.ReadOnly = true;
            colDebit.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCredit
            // 
            colCredit.DataPropertyName = "Supl_Credit";
            DataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCredit.DefaultCellStyle = DataGridViewCellStyle51;
            colCredit.HeaderText = "Credit";
            colCredit.Name = "colCredit";
            colCredit.ReadOnly = true;
            colCredit.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBalance
            // 
            colBalance.DataPropertyName = "Supl_Balance";
            DataGridViewCellStyle52.Alignment = DataGridViewContentAlignment.MiddleRight;
            colBalance.DefaultCellStyle = DataGridViewCellStyle52;
            colBalance.HeaderText = "Balance";
            colBalance.Name = "colBalance";
            colBalance.ReadOnly = true;
            colBalance.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PayBindingSource
            // 
            PayBindingSource.DataSource = PaymentDataSet;
            PayBindingSource.Position = 0;
            // 
            // PaymentDataSet
            // 
            PaymentDataSet.DataSetName = "PayDataSet";
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = My.Resources.Resources.search18;
            PictureBox1.BackgroundImageLayout = ImageLayout.Center;
            PictureBox1.Location = new Point(103, 30);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(28, 20);
            PictureBox1.TabIndex = 19;
            PictureBox1.TabStop = false;
            // 
            // frmJournal
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 471);
            Controls.Add(PaymentDataGridView);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "frmJournal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "General Journal";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PayBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(frmJournal_Load);
            ResumeLayout(false);

        }
        internal Panel Panel1;
        internal Panel Panel2;
        internal TextBox txtCredit;
        internal Label Label3;
        internal TextBox txtDescription;
        internal Label Label1;
        internal TextBox txtID;
        internal Label lblPhone;
        internal TextBox txtDebit;
        internal Label lblName;
        internal TextBox txtName;
        internal DataGridView PaymentDataGridView;
        internal DataSet PaymentDataSet;
        internal BindingSource PayBindingSource;
        internal Button cmdClose;
        internal Label Label5;
        internal Label Label2;
        internal Label Label6;
        internal Label Label4;
        internal TextBox txtTran;
        internal DateTimePicker TranDate;
        internal Button cmdMin;
        internal DataGridViewTextBoxColumn colTranID;
        internal DataGridViewTextBoxColumn colDate;
        internal DataGridViewTextBoxColumn colID;
        internal DataGridViewTextBoxColumn colDesc;
        internal DataGridViewTextBoxColumn colOpnBal;
        internal DataGridViewTextBoxColumn colDebit;
        internal DataGridViewTextBoxColumn colCredit;
        internal DataGridViewTextBoxColumn colBalance;
        internal PictureBox PictureBox1;
    }
}