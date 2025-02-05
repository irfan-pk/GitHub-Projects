using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ViewCompanyLedgers : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCompanyLedgers));
            colID = new DataGridViewTextBoxColumn();
            Label6 = new Label();
            colCredit = new DataGridViewTextBoxColumn();
            colDebit = new DataGridViewTextBoxColumn();
            colOpnBal = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            PaymentDataSet = new DataSet();
            PaymentDataGridView = new DataGridView();
            colTranID = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            PayBindingSource = new BindingSource(components);
            FromDate = new DateTimePicker();
            cmdMin = new Button();
            cmdMin.Click += new EventHandler(cmdMin_Click);
            Panel2 = new Panel();
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            Label1 = new Label();
            ToDate = new DateTimePicker();
            cmdPreview = new Button();
            cmdPreview.Click += new EventHandler(cmdPreview_Click);
            Label5 = new Label();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            Panel1.MouseMove += new MouseEventHandler(Panel1_MouseMove);
            Panel1.MouseUp += new MouseEventHandler(Panel1_MouseUp);
            PayBindingNavigator = new BindingNavigator(components);
            BindingNavigatorMovePreviousItem = new ToolStripButton();
            BindingNavigatorSeparator = new ToolStripSeparator();
            BindingNavigatorMoveNextItem = new ToolStripButton();
            BindingNavigatorSeparator2 = new ToolStripSeparator();
            BindingNavigatorTextBox = new ToolStripTextBox();
            BindingNavigatorTextBox.KeyDown += new KeyEventHandler(BindingNavigatorTextBox_KeyDown);
            BindingNavigatorTextBox.KeyUp += new KeyEventHandler(BindingNavigatorTextBox_KeyUp);
            BindingNavigatorSeparator4 = new ToolStripSeparator();
            BindingNavigatorFind = new ToolStripButton();
            BindingNavigatorFind.Click += new EventHandler(BindingNavigatorFind_Click);
            ((System.ComponentModel.ISupportInitialize)PaymentDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PayBindingSource).BeginInit();
            Panel2.SuspendLayout();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PayBindingNavigator).BeginInit();
            PayBindingNavigator.SuspendLayout();
            SuspendLayout();
            // 
            // colID
            // 
            colID.DataPropertyName = "SUPL_CODE";
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colID.DefaultCellStyle = DataGridViewCellStyle1;
            colID.HeaderText = "Supplier ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.SortMode = DataGridViewColumnSortMode.NotSortable;
            colID.Width = 80;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.Yellow;
            Label6.Location = new Point(6, 15);
            Label6.Name = "Label6";
            Label6.Size = new Size(136, 13);
            Label6.TabIndex = 38;
            Label6.Text = "Transaction Date From";
            // 
            // colCredit
            // 
            colCredit.DataPropertyName = "Supl_Credit";
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCredit.DefaultCellStyle = DataGridViewCellStyle2;
            colCredit.HeaderText = "Credit";
            colCredit.Name = "colCredit";
            colCredit.ReadOnly = true;
            colCredit.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colDebit
            // 
            colDebit.DataPropertyName = "Supl_debit";
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDebit.DefaultCellStyle = DataGridViewCellStyle3;
            colDebit.HeaderText = "Debit";
            colDebit.Name = "colDebit";
            colDebit.ReadOnly = true;
            colDebit.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colOpnBal
            // 
            colOpnBal.DataPropertyName = "Supl_opn_bal";
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            colOpnBal.DefaultCellStyle = DataGridViewCellStyle4;
            colOpnBal.HeaderText = "Opening B/L";
            colOpnBal.Name = "colOpnBal";
            colOpnBal.ReadOnly = true;
            colOpnBal.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // PaymentDataSet
            // 
            PaymentDataSet.DataSetName = "PayDataSet";
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
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle5.BackColor = SystemColors.Control;
            DataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            PaymentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            PaymentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDataGridView.Columns.AddRange(new DataGridViewColumn[] { colTranID, colDate, colID, colDesc, colOpnBal, colDebit, colCredit, colBalance });
            PaymentDataGridView.DataSource = PayBindingSource;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.BackColor = Color.FromArgb(192, 255, 192);
            DataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            PaymentDataGridView.DefaultCellStyle = DataGridViewCellStyle9;
            PaymentDataGridView.Dock = DockStyle.Fill;
            PaymentDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            PaymentDataGridView.Location = new Point(0, 92);
            PaymentDataGridView.MultiSelect = false;
            PaymentDataGridView.Name = "PaymentDataGridView";
            PaymentDataGridView.ReadOnly = true;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle10.BackColor = Color.WhiteSmoke;
            DataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle10.SelectionBackColor = Color.WhiteSmoke;
            DataGridViewCellStyle10.SelectionForeColor = Color.Black;
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            PaymentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle10;
            PaymentDataGridView.RowHeadersVisible = false;
            DataGridViewCellStyle11.BackColor = Color.FromArgb(192, 255, 192);
            PaymentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle11;
            PaymentDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            PaymentDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Blue;
            PaymentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PaymentDataGridView.Size = new Size(942, 379);
            PaymentDataGridView.TabIndex = 17;
            PaymentDataGridView.TabStop = false;
            // 
            // colTranID
            // 
            colTranID.DataPropertyName = "SUPL_TR_ID";
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTranID.DefaultCellStyle = DataGridViewCellStyle6;
            colTranID.HeaderText = "Trans #";
            colTranID.Name = "colTranID";
            colTranID.ReadOnly = true;
            colTranID.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTranID.Width = 80;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "SUPL_TR_DT";
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDate.DefaultCellStyle = DataGridViewCellStyle7;
            colDate.HeaderText = "Trans Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            colDate.Width = 80;
            // 
            // colBalance
            // 
            colBalance.DataPropertyName = "Supl_Balance";
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            colBalance.DefaultCellStyle = DataGridViewCellStyle8;
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
            // FromDate
            // 
            FromDate.Location = new Point(148, 11);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(215, 20);
            FromDate.TabIndex = 1;
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
            // Panel2
            // 
            Panel2.BackColor = Color.Gray;
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(cmdClose);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(ToDate);
            Panel2.Controls.Add(cmdPreview);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(FromDate);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 49);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(942, 43);
            Panel2.TabIndex = 16;
            // 
            // cmdClose
            // 
            cmdClose.BackColor = SystemColors.Control;
            cmdClose.FlatStyle = FlatStyle.Popup;
            cmdClose.Image = My.Resources.Resources.application_remove;
            cmdClose.ImageAlign = ContentAlignment.MiddleLeft;
            cmdClose.Location = new Point(809, 6);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(72, 29);
            cmdClose.TabIndex = 42;
            cmdClose.Text = "&Close";
            cmdClose.TextAlign = ContentAlignment.MiddleRight;
            cmdClose.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Yellow;
            Label1.Location = new Point(367, 15);
            Label1.Name = "Label1";
            Label1.Size = new Size(49, 13);
            Label1.TabIndex = 41;
            Label1.Text = "ToDate";
            // 
            // ToDate
            // 
            ToDate.Location = new Point(419, 11);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(215, 20);
            ToDate.TabIndex = 40;
            // 
            // cmdPreview
            // 
            cmdPreview.BackColor = SystemColors.Control;
            cmdPreview.FlatStyle = FlatStyle.Popup;
            cmdPreview.Image = My.Resources.Resources.Book_openHS;
            cmdPreview.ImageAlign = ContentAlignment.MiddleLeft;
            cmdPreview.Location = new Point(731, 6);
            cmdPreview.Name = "cmdPreview";
            cmdPreview.Size = new Size(72, 29);
            cmdPreview.TabIndex = 39;
            cmdPreview.Text = "&Preview";
            cmdPreview.TextAlign = ContentAlignment.MiddleRight;
            cmdPreview.UseVisualStyleBackColor = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.Red;
            Label5.ImageAlign = ContentAlignment.MiddleLeft;
            Label5.Location = new Point(3, 8);
            Label5.Name = "Label5";
            Label5.Size = new Size(215, 31);
            Label5.TabIndex = 5;
            Label5.Text = "General Ledger";
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(PayBindingNavigator);
            Panel1.Controls.Add(cmdMin);
            Panel1.Controls.Add(Label5);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(942, 49);
            Panel1.TabIndex = 15;
            // 
            // PayBindingNavigator
            // 
            PayBindingNavigator.AddNewItem = null;
            PayBindingNavigator.BackColor = SystemColors.Control;
            PayBindingNavigator.BindingSource = PayBindingSource;
            PayBindingNavigator.CountItem = null;
            PayBindingNavigator.DeleteItem = null;
            PayBindingNavigator.Dock = DockStyle.None;
            PayBindingNavigator.Items.AddRange(new ToolStripItem[] { BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, BindingNavigatorMoveNextItem, BindingNavigatorSeparator2, BindingNavigatorTextBox, BindingNavigatorSeparator4, BindingNavigatorFind });
            PayBindingNavigator.Location = new Point(419, 11);
            PayBindingNavigator.MoveFirstItem = null;
            PayBindingNavigator.MoveLastItem = null;
            PayBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem;
            PayBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem;
            PayBindingNavigator.Name = "PayBindingNavigator";
            PayBindingNavigator.PositionItem = null;
            PayBindingNavigator.Size = new Size(462, 25);
            PayBindingNavigator.TabIndex = 100;
            PayBindingNavigator.Text = "BindingNavigator";
            PayBindingNavigator.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorMovePreviousItem
            // 
            BindingNavigatorMovePreviousItem.BackColor = Color.SkyBlue;
            BindingNavigatorMovePreviousItem.Image = (Image)resources.GetObject("BindingNavigatorMovePreviousItem.Image");
            BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMovePreviousItem.Size = new Size(50, 22);
            BindingNavigatorMovePreviousItem.Text = "&Prev";
            BindingNavigatorMovePreviousItem.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorMovePreviousItem.ToolTipText = "Move Previous";
            // 
            // BindingNavigatorSeparator
            // 
            BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            BindingNavigatorSeparator.Size = new Size(6, 25);
            BindingNavigatorSeparator.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorMoveNextItem
            // 
            BindingNavigatorMoveNextItem.BackColor = Color.SkyBlue;
            BindingNavigatorMoveNextItem.Image = (Image)resources.GetObject("BindingNavigatorMoveNextItem.Image");
            BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            BindingNavigatorMoveNextItem.Size = new Size(51, 22);
            BindingNavigatorMoveNextItem.Text = "&Next";
            BindingNavigatorMoveNextItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // BindingNavigatorSeparator2
            // 
            BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            BindingNavigatorSeparator2.Size = new Size(6, 25);
            BindingNavigatorSeparator2.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorTextBox
            // 
            BindingNavigatorTextBox.Name = "BindingNavigatorTextBox";
            BindingNavigatorTextBox.Size = new Size(200, 25);
            BindingNavigatorTextBox.TextDirection = ToolStripTextDirection.Vertical90;
            BindingNavigatorTextBox.ToolTipText = "Enter Product Code to Find";
            // 
            // BindingNavigatorSeparator4
            // 
            BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4";
            BindingNavigatorSeparator4.Size = new Size(6, 25);
            BindingNavigatorSeparator4.TextDirection = ToolStripTextDirection.Vertical90;
            // 
            // BindingNavigatorFind
            // 
            BindingNavigatorFind.BackColor = Color.SkyBlue;
            BindingNavigatorFind.Image = My.Resources.Resources.search1;
            BindingNavigatorFind.ImageTransparentColor = Color.Magenta;
            BindingNavigatorFind.Name = "BindingNavigatorFind";
            BindingNavigatorFind.Size = new Size(129, 22);
            BindingNavigatorFind.Text = "&View by Wholesaler";
            BindingNavigatorFind.TextDirection = ToolStripTextDirection.Horizontal;
            BindingNavigatorFind.ToolTipText = "Click to Find Product";
            // 
            // frmViewCompanyLedgers
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 471);
            Controls.Add(PaymentDataGridView);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmViewCompanyLedgers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Ledgers";
            ((System.ComponentModel.ISupportInitialize)PaymentDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PayBindingSource).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PayBindingNavigator).EndInit();
            PayBindingNavigator.ResumeLayout(false);
            PayBindingNavigator.PerformLayout();
            Load += new EventHandler(frmViewCompanyLedgers_Load);
            ResumeLayout(false);

        }
        internal DataGridViewTextBoxColumn colID;
        internal Label Label6;
        internal DataGridViewTextBoxColumn colCredit;
        internal DataGridViewTextBoxColumn colDebit;
        internal DataGridViewTextBoxColumn colOpnBal;
        internal DataGridViewTextBoxColumn colDesc;
        internal DataSet PaymentDataSet;
        internal DataGridView PaymentDataGridView;
        internal DataGridViewTextBoxColumn colTranID;
        internal DataGridViewTextBoxColumn colDate;
        internal DataGridViewTextBoxColumn colBalance;
        internal BindingSource PayBindingSource;
        internal DateTimePicker FromDate;
        internal Button cmdMin;
        internal Panel Panel2;
        internal Label Label5;
        internal Panel Panel1;
        internal BindingNavigator PayBindingNavigator;
        internal ToolStripButton BindingNavigatorMovePreviousItem;
        internal ToolStripSeparator BindingNavigatorSeparator;
        internal ToolStripButton BindingNavigatorMoveNextItem;
        internal ToolStripSeparator BindingNavigatorSeparator2;
        internal ToolStripTextBox BindingNavigatorTextBox;
        internal ToolStripSeparator BindingNavigatorSeparator4;
        internal ToolStripButton BindingNavigatorFind;
        internal Button cmdPreview;
        internal Label Label1;
        internal DateTimePicker ToDate;
        internal Button cmdClose;
    }
}