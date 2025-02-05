using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Reports : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            CrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            SuspendLayout();
            // 
            // CrystalReportViewer
            // 
            CrystalReportViewer.ActiveViewIndex = -1;
            CrystalReportViewer.AutoScroll = true;
            CrystalReportViewer.AutoSize = true;
            CrystalReportViewer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CrystalReportViewer.BorderStyle = BorderStyle.FixedSingle;
            CrystalReportViewer.DisplayGroupTree = false;
            CrystalReportViewer.Dock = DockStyle.Fill;
            CrystalReportViewer.Location = new Point(0, 0);
            CrystalReportViewer.Name = "CrystalReportViewer";
            CrystalReportViewer.SelectionFormula = string.Empty;
            CrystalReportViewer.Size = new Size(770, 493);
            CrystalReportViewer.TabIndex = 0;
            CrystalReportViewer.TabStop = false;
            CrystalReportViewer.ViewTimeSelectionFormula = string.Empty;
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 493);
            Controls.Add(CrystalReportViewer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            FormClosed += new FormClosedEventHandler(frmReports_FormClosed);
            Load += new EventHandler(frmReports_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer;
    }
}