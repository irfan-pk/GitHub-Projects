using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ProductCode : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCode));
            comboBox1 = new ComboBox();
            comboBox1.DrawItem += new DrawItemEventHandler(comboBox1_DrawItem);
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(64, 64, 64);
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(533, 524);
            comboBox1.TabIndex = 2;
            // 
            // frmProductCode
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(533, 524);
            ControlBox = false;
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "frmProductCode";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Code List";
            KeyDown += new KeyEventHandler(frmProductCode_KeyDown);
            Load += new EventHandler(MainForm_Load);
            ResumeLayout(false);

        }
        private ComboBox comboBox1;

    }
}