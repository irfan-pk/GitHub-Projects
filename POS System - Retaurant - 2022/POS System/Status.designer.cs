using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Status : Form
    {

        [DebuggerNonUserCode()]
        public Status() : base()
        {

            // This call is required by the Windows Form Designer.
            InitializeComponent();

        }

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is not null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            _Label1 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.Location = new Point(66, 32);
            _Label1.Name = "_Label1";
            _Label1.Size = new Size(39, 13);
            _Label1.TabIndex = 0;
            _Label1.Text = "Label1";
            // 
            // Status
            // 
            ClientSize = new Size(292, 83);
            Controls.Add(_Label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Status";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label _Label1;

        internal virtual Label Label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Label1 = value;
            }
        }
    }
}