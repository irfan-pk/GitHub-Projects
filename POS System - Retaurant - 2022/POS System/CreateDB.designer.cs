using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace POS_System
{
    public partial class CreateDB : Form
    {

        public CreateDB() : base()
        {

            // This call is required by the Windows Form Designer.
            InitializeComponent();
            Load += Form1_Load;

            // Add any initialization after the InitializeComponent() call

        }

        // Form overrides dispose to clean up the component list.
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
        [DebuggerNonUserCode()]
        private void InitializeComponent()
        {
            _lblStep2 = new Label();
            _btnCreateTable = new Button();
            _btnCreateTable.Click += new EventHandler(btnCreateTable_Click);
            _lblArrow1 = new Label();
            _lblStep1 = new Label();
            _btnCreateDB = new Button();
            _btnCreateDB.Click += new EventHandler(btnCreateDB_Click);
            _Label1 = new Label();
            _MenuStrip1 = new MenuStrip();
            _fileToolStripMenuItem = new ToolStripMenuItem();
            _exitToolStripMenuItem = new ToolStripMenuItem();
            _exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);
            _MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStep2
            // 
            _lblStep2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            _lblStep2.ImeMode = ImeMode.NoControl;
            _lblStep2.Location = new Point(179, 81);
            _lblStep2.Margin = new Padding(0, 3, 2, 3);
            _lblStep2.Name = "_lblStep2";
            _lblStep2.Size = new Size(16, 23);
            _lblStep2.TabIndex = 43;
            _lblStep2.Text = "2.";
            // 
            // btnCreateTable
            // 
            _btnCreateTable.BackColor = SystemColors.InactiveCaptionText;
            _btnCreateTable.ForeColor = Color.White;
            _btnCreateTable.ImeMode = ImeMode.NoControl;
            _btnCreateTable.Location = new Point(199, 73);
            _btnCreateTable.Margin = new Padding(2, 3, 3, 3);
            _btnCreateTable.Name = "_btnCreateTable";
            _btnCreateTable.Size = new Size(104, 23);
            _btnCreateTable.TabIndex = 42;
            _btnCreateTable.Text = "Create &Table";
            _btnCreateTable.UseVisualStyleBackColor = false;
            // 
            // lblArrow1
            // 
            _lblArrow1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            _lblArrow1.ImeMode = ImeMode.NoControl;
            _lblArrow1.Location = new Point(147, 77);
            _lblArrow1.Margin = new Padding(3, 3, 1, 3);
            _lblArrow1.Name = "_lblArrow1";
            _lblArrow1.Size = new Size(31, 23);
            _lblArrow1.TabIndex = 41;
            _lblArrow1.Text = ">>";
            // 
            // lblStep1
            // 
            _lblStep1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            _lblStep1.ImeMode = ImeMode.NoControl;
            _lblStep1.Location = new Point(16, 80);
            _lblStep1.Name = "_lblStep1";
            _lblStep1.Size = new Size(16, 23);
            _lblStep1.TabIndex = 40;
            _lblStep1.Text = "1.";
            // 
            // btnCreateDB
            // 
            _btnCreateDB.BackColor = SystemColors.InactiveCaptionText;
            _btnCreateDB.ForeColor = Color.White;
            _btnCreateDB.ImeMode = ImeMode.NoControl;
            _btnCreateDB.Location = new Point(36, 73);
            _btnCreateDB.Name = "_btnCreateDB";
            _btnCreateDB.Size = new Size(104, 23);
            _btnCreateDB.TabIndex = 39;
            _btnCreateDB.Text = "Create &Database";
            _btnCreateDB.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            _Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold);
            _Label1.ForeColor = SystemColors.Desktop;
            _Label1.ImeMode = ImeMode.NoControl;
            _Label1.Location = new Point(12, 41);
            _Label1.Name = "_Label1";
            _Label1.Size = new Size(291, 23);
            _Label1.TabIndex = 38;
            _Label1.Text = "Database Initializing Wait .....";
            // 
            // MenuStrip1
            // 
            _MenuStrip1.Items.AddRange(new ToolStripItem[] { _fileToolStripMenuItem });
            _MenuStrip1.Location = new Point(0, 0);
            _MenuStrip1.Name = "_MenuStrip1";
            _MenuStrip1.Size = new Size(330, 24);
            _MenuStrip1.TabIndex = 58;
            _MenuStrip1.Text = "MenuStrip1";
            _MenuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            _fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _exitToolStripMenuItem });
            _fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            _fileToolStripMenuItem.Size = new Size(37, 20);
            _fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            _exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            _exitToolStripMenuItem.Size = new Size(92, 22);
            _exitToolStripMenuItem.Text = "E&xit";
            // 
            // frmCreateDB
            // 
            AutoSize = true;
            ClientSize = new Size(330, 132);
            Controls.Add(_MenuStrip1);
            Controls.Add(_lblStep2);
            Controls.Add(_btnCreateTable);
            Controls.Add(_lblArrow1);
            Controls.Add(_lblStep1);
            Controls.Add(_btnCreateDB);
            Controls.Add(_Label1);
            Name = "frmCreateDB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Initializing...";
            _MenuStrip1.ResumeLayout(false);
            _MenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal static CreateDB GetInstance
        {
            get
            {
                if (m_DefaultInstance is null || m_DefaultInstance.IsDisposed)
                {
                    lock (m_SyncObject)
                    {
                        if (m_DefaultInstance is null || m_DefaultInstance.IsDisposed)
                        {
                            m_DefaultInstance = new CreateDB();
                        }
                    }
                }
                return m_DefaultInstance;
            }
        }

        private static CreateDB m_DefaultInstance;
        private static object m_SyncObject = new object();
        private Label _lblStep2;

        internal virtual Label lblStep2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblStep2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblStep2 = value;
            }
        }
        private Button _btnCreateTable;

        internal virtual Button btnCreateTable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCreateTable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCreateTable != null)
                {
                    _btnCreateTable.Click -= btnCreateTable_Click;
                }

                _btnCreateTable = value;
                if (_btnCreateTable != null)
                {
                    _btnCreateTable.Click += btnCreateTable_Click;
                }
            }
        }
        private Label _lblArrow1;

        internal virtual Label lblArrow1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblArrow1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblArrow1 = value;
            }
        }
        private Label _lblStep1;

        internal virtual Label lblStep1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblStep1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblStep1 = value;
            }
        }
        private Button _btnCreateDB;

        internal virtual Button btnCreateDB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCreateDB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCreateDB != null)
                {
                    _btnCreateDB.Click -= btnCreateDB_Click;
                }

                _btnCreateDB = value;
                if (_btnCreateDB != null)
                {
                    _btnCreateDB.Click += btnCreateDB_Click;
                }
            }
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
        private MenuStrip _MenuStrip1;

        internal virtual MenuStrip MenuStrip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MenuStrip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _MenuStrip1 = value;
            }
        }
        private ToolStripMenuItem _fileToolStripMenuItem;

        internal virtual ToolStripMenuItem fileToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _fileToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _fileToolStripMenuItem = value;
            }
        }
        private ToolStripMenuItem _exitToolStripMenuItem;

        internal virtual ToolStripMenuItem exitToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _exitToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_exitToolStripMenuItem != null)
                {
                    _exitToolStripMenuItem.Click -= exitToolStripMenuItem_Click;
                }

                _exitToolStripMenuItem = value;
                if (_exitToolStripMenuItem != null)
                {
                    _exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
                }
            }
        }

    }
}