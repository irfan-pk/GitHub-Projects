using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace POS_System
{
    public partial class MsgStatus : Form
    {

        [DebuggerNonUserCode()]
        public MsgStatus() : base()
        {

            // This call is required by the Windows Form Designer.
            InitializeComponent();
            KeyDown += MsgStatus_KeyDown;
            Load += frmStatus_Load;

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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgStatus));
            _Label1 = new Label();
            _Timer1 = new Timer(components);
            _Timer1.Tick += new EventHandler(Timer1_Tick);
            _PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            _Label1.ForeColor = Color.Yellow;
            _Label1.Location = new Point(40, 11);
            _Label1.Name = "_Label1";
            _Label1.Size = new Size(353, 59);
            _Label1.TabIndex = 0;
            _Label1.Text = "Label1";
            // 
            // Timer1
            // 
            _Timer1.Enabled = true;
            _Timer1.Interval = 2000;
            // 
            // PictureBox1
            // 
            _PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            _PictureBox1.BackgroundImageLayout = ImageLayout.Center;
            _PictureBox1.Location = new Point(12, 9);
            _PictureBox1.Name = "_PictureBox1";
            _PictureBox1.Size = new Size(26, 26);
            _PictureBox1.TabIndex = 1;
            _PictureBox1.TabStop = false;
            // 
            // MsgStatus
            // 
            BackColor = Color.Black;
            ClientSize = new Size(407, 83);
            Controls.Add(_PictureBox1);
            Controls.Add(_Label1);
            Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.LightGreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MsgStatus";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Status";
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).EndInit();
            ResumeLayout(false);

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
        private Timer _Timer1;

        internal virtual Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Tick -= Timer1_Tick;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Tick += Timer1_Tick;
                }
            }
        }
        private PictureBox _PictureBox1;

        internal virtual PictureBox PictureBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _PictureBox1 = value;
            }
        }
    }
}