using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class WaiterCode : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterCode));
            ListBox1 = new ListBox();
            ListBox1.DrawItem += new DrawItemEventHandler(ListBox1_DrawItem);
            SuspendLayout();
            // 
            // ListBox1
            // 
            ListBox1.BackColor = Color.Gray;
            ListBox1.Dock = DockStyle.Fill;
            ListBox1.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListBox1.ForeColor = Color.White;
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(0, 0);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(415, 394);
            ListBox1.Sorted = true;
            ListBox1.TabIndex = 0;
            // 
            // frmCustCode
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(415, 394);
            ControlBox = false;
            Controls.Add(ListBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "frmCustCode";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Code List";
            KeyDown += new KeyEventHandler(frmCustCode_KeyDown);
            Load += new EventHandler(MainForm_Load);
            ResumeLayout(false);

        }
        internal ListBox ListBox1;
    }
}