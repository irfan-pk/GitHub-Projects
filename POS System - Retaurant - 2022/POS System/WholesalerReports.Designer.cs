using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class WholesalerReports : Form
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
            gbRptype = new GroupBox();
            Label1 = new Label();
            DateFrom = new DateTimePicker();
            cmbCustName = new ComboBox();
            rdSelSaler = new RadioButton();
            rdSelSaler.KeyDown += new KeyEventHandler(rdSelSaler_KeyDown);
            rdSelSaler.MouseClick += new MouseEventHandler(rdSelSaler_MouseClick);
            rdAllSaler = new RadioButton();
            rdAllSaler.KeyDown += new KeyEventHandler(rdAllSaler_KeyDown);
            rdAllSaler.MouseClick += new MouseEventHandler(rdAllSaler_MouseClick);
            rdWLedger = new RadioButton();
            GroupBox1 = new GroupBox();
            rdWDetail = new RadioButton();
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            cmdPreview = new Button();
            cmdPreview.Click += new EventHandler(cmdPreview_Click);
            gbRptype.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbRptype
            // 
            gbRptype.Controls.Add(Label1);
            gbRptype.Controls.Add(DateFrom);
            gbRptype.Controls.Add(cmbCustName);
            gbRptype.Controls.Add(rdSelSaler);
            gbRptype.Controls.Add(rdAllSaler);
            gbRptype.Location = new Point(12, 44);
            gbRptype.Name = "gbRptype";
            gbRptype.Size = new Size(260, 163);
            gbRptype.TabIndex = 11;
            gbRptype.TabStop = false;
            gbRptype.Text = "Selec Report for";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(15, 108);
            Label1.Name = "Label1";
            Label1.Size = new Size(30, 13);
            Label1.TabIndex = 5;
            Label1.Text = "From";
            // 
            // DateFrom
            // 
            DateFrom.Location = new Point(18, 126);
            DateFrom.Name = "DateFrom";
            DateFrom.Size = new Size(227, 20);
            DateFrom.TabIndex = 7;
            // 
            // cmbCustName
            // 
            cmbCustName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustName.Enabled = false;
            cmbCustName.FormattingEnabled = true;
            cmbCustName.Location = new Point(18, 79);
            cmbCustName.Name = "cmbCustName";
            cmbCustName.Size = new Size(227, 21);
            cmbCustName.TabIndex = 6;
            // 
            // rdSelSaler
            // 
            rdSelSaler.AutoSize = true;
            rdSelSaler.Location = new Point(18, 56);
            rdSelSaler.Name = "rdSelSaler";
            rdSelSaler.Size = new Size(111, 17);
            rdSelSaler.TabIndex = 5;
            rdSelSaler.Text = "Select Wholesaler";
            rdSelSaler.UseVisualStyleBackColor = true;
            // 
            // rdAllSaler
            // 
            rdAllSaler.AutoSize = true;
            rdAllSaler.Checked = true;
            rdAllSaler.Location = new Point(18, 31);
            rdAllSaler.Name = "rdAllSaler";
            rdAllSaler.Size = new Size(97, 17);
            rdAllSaler.TabIndex = 4;
            rdAllSaler.TabStop = true;
            rdAllSaler.Text = "All Wholesalers";
            rdAllSaler.UseVisualStyleBackColor = true;
            // 
            // rdWLedger
            // 
            rdWLedger.AutoSize = true;
            rdWLedger.Location = new Point(141, 11);
            rdWLedger.Name = "rdWLedger";
            rdWLedger.RightToLeft = RightToLeft.No;
            rdWLedger.Size = new Size(114, 17);
            rdWLedger.TabIndex = 2;
            rdWLedger.Text = "Wholesaler Ledger";
            rdWLedger.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(rdWLedger);
            GroupBox1.Controls.Add(rdWDetail);
            GroupBox1.Location = new Point(11, 6);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(261, 33);
            GroupBox1.TabIndex = 10;
            GroupBox1.TabStop = false;
            // 
            // rdWDetail
            // 
            rdWDetail.AutoSize = true;
            rdWDetail.Checked = true;
            rdWDetail.Location = new Point(19, 11);
            rdWDetail.Name = "rdWDetail";
            rdWDetail.RightToLeft = RightToLeft.No;
            rdWDetail.Size = new Size(102, 17);
            rdWDetail.TabIndex = 1;
            rdWDetail.TabStop = true;
            rdWDetail.Text = "Wholsaler Detail";
            rdWDetail.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            cmdClose.FlatStyle = FlatStyle.Popup;
            cmdClose.Location = new Point(196, 222);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(76, 29);
            cmdClose.TabIndex = 13;
            cmdClose.Text = "Close";
            cmdClose.UseVisualStyleBackColor = true;
            // 
            // cmdPreview
            // 
            cmdPreview.FlatStyle = FlatStyle.Popup;
            cmdPreview.Location = new Point(114, 222);
            cmdPreview.Name = "cmdPreview";
            cmdPreview.Size = new Size(76, 29);
            cmdPreview.TabIndex = 12;
            cmdPreview.Text = "Preview";
            cmdPreview.UseVisualStyleBackColor = true;
            // 
            // frmWholesalerReports
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 263);
            Controls.Add(gbRptype);
            Controls.Add(GroupBox1);
            Controls.Add(cmdClose);
            Controls.Add(cmdPreview);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmWholesalerReports";
            Opacity = 0.8d;
            Text = "Reports";
            gbRptype.ResumeLayout(false);
            gbRptype.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(frmWholsalerReports_Load);
            ResumeLayout(false);

        }
        internal GroupBox gbRptype;
        internal Label Label1;
        internal DateTimePicker DateFrom;
        internal ComboBox cmbCustName;
        internal RadioButton rdSelSaler;
        internal RadioButton rdAllSaler;
        internal RadioButton rdWLedger;
        internal GroupBox GroupBox1;
        internal RadioButton rdWDetail;
        internal Button cmdClose;
        internal Button cmdPreview;
    }
}