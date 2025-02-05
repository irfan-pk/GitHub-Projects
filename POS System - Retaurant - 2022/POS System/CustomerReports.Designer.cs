using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CustomerReports : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReports));
            gbRptype = new GroupBox();
            Label1 = new Label();
            DateFrom = new DateTimePicker();
            cmbCustName = new ComboBox();
            rdSelCust = new RadioButton();
            rdSelCust.MouseClick += new MouseEventHandler(rdSelCust_MouseClick);
            rdAllCust = new RadioButton();
            rdAllCust.MouseClick += new MouseEventHandler(rdAllCust_MouseClick);
            cmdPreview = new Button();
            cmdPreview.Click += new EventHandler(cmdPreview_Click);
            cmdClose = new Button();
            cmdClose.Click += new EventHandler(cmdClose_Click);
            GroupBox1 = new GroupBox();
            rdLedger = new RadioButton();
            rdDetail = new RadioButton();
            gbRptype.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbRptype
            // 
            gbRptype.Controls.Add(Label1);
            gbRptype.Controls.Add(DateFrom);
            gbRptype.Controls.Add(cmbCustName);
            gbRptype.Controls.Add(rdSelCust);
            gbRptype.Controls.Add(rdAllCust);
            gbRptype.Location = new Point(12, 44);
            gbRptype.Name = "gbRptype";
            gbRptype.Size = new Size(260, 163);
            gbRptype.TabIndex = 3;
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
            // rdSelCust
            // 
            rdSelCust.AutoSize = true;
            rdSelCust.Location = new Point(18, 56);
            rdSelCust.Name = "rdSelCust";
            rdSelCust.Size = new Size(102, 17);
            rdSelCust.TabIndex = 5;
            rdSelCust.Text = "Select Customer";
            rdSelCust.UseVisualStyleBackColor = true;
            // 
            // rdAllCust
            // 
            rdAllCust.AutoSize = true;
            rdAllCust.Checked = true;
            rdAllCust.Location = new Point(18, 31);
            rdAllCust.Name = "rdAllCust";
            rdAllCust.Size = new Size(88, 17);
            rdAllCust.TabIndex = 4;
            rdAllCust.TabStop = true;
            rdAllCust.Text = "All Customers";
            rdAllCust.UseVisualStyleBackColor = true;
            // 
            // cmdPreview
            // 
            cmdPreview.FlatStyle = FlatStyle.Popup;
            cmdPreview.Location = new Point(114, 222);
            cmdPreview.Name = "cmdPreview";
            cmdPreview.Size = new Size(76, 29);
            cmdPreview.TabIndex = 8;
            cmdPreview.Text = "Preview";
            cmdPreview.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            cmdClose.FlatStyle = FlatStyle.Popup;
            cmdClose.Location = new Point(196, 222);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(76, 29);
            cmdClose.TabIndex = 9;
            cmdClose.Text = "Close";
            cmdClose.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(rdLedger);
            GroupBox1.Controls.Add(rdDetail);
            GroupBox1.Location = new Point(11, 6);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(261, 33);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            // 
            // rdLedger
            // 
            rdLedger.AutoSize = true;
            rdLedger.Location = new Point(141, 11);
            rdLedger.Name = "rdLedger";
            rdLedger.RightToLeft = RightToLeft.No;
            rdLedger.Size = new Size(105, 17);
            rdLedger.TabIndex = 2;
            rdLedger.Text = "Customer Ledger";
            rdLedger.UseVisualStyleBackColor = true;
            // 
            // rdDetail
            // 
            rdDetail.AutoSize = true;
            rdDetail.Checked = true;
            rdDetail.Location = new Point(19, 11);
            rdDetail.Name = "rdDetail";
            rdDetail.RightToLeft = RightToLeft.No;
            rdDetail.Size = new Size(99, 17);
            rdDetail.TabIndex = 1;
            rdDetail.TabStop = true;
            rdDetail.Text = "Customer Detail";
            rdDetail.UseVisualStyleBackColor = true;
            // 
            // frmCustomerReports
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 263);
            Controls.Add(GroupBox1);
            Controls.Add(cmdClose);
            Controls.Add(cmdPreview);
            Controls.Add(gbRptype);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomerReports";
            Opacity = 0.8d;
            Text = "Reports";
            gbRptype.ResumeLayout(false);
            gbRptype.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(frmCustomerReports_Load);
            ResumeLayout(false);

        }
        internal GroupBox gbRptype;
        internal RadioButton rdSelCust;
        internal RadioButton rdAllCust;
        internal ComboBox cmbCustName;
        internal Button cmdPreview;
        internal Button cmdClose;
        internal DateTimePicker DateFrom;
        internal Label Label1;
        internal GroupBox GroupBox1;
        internal RadioButton rdLedger;
        internal RadioButton rdDetail;
    }
}