using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BackupData : Form
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
            Label1 = new Label();
            cmdRestore = new Button();
            cmdRestore.Click += new EventHandler(cmdRestore_Click);
            cmdBackup = new Button();
            cmdBackup.Click += new EventHandler(cmdBackup_Click);
            FolderBrowserDialog1 = new FolderBrowserDialog();
            TextBox1 = new TextBox();
            cmdBrowse = new Button();
            cmdBrowse.Click += new EventHandler(cmdBrowse_Click);
            GroupBox1 = new GroupBox();
            Label3 = new Label();
            Label2 = new Label();
            ProgressBar1 = new ProgressBar();
            ListView = new ListView();
            ListView.Click += new EventHandler(ListView_Click);
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            SaveFileDialog1 = new SaveFileDialog();
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(6, 4);
            Label1.Name = "Label1";
            Label1.Size = new Size(518, 38);
            Label1.TabIndex = 0;
            Label1.Text = "Please Specify  to which drive you want to Backup / Restore your database";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmdRestore
            // 
            cmdRestore.FlatStyle = FlatStyle.Popup;
            cmdRestore.Location = new Point(499, 271);
            cmdRestore.Name = "cmdRestore";
            cmdRestore.Size = new Size(67, 22);
            cmdRestore.TabIndex = 4;
            cmdRestore.Text = "&Restore";
            cmdRestore.UseVisualStyleBackColor = true;
            // 
            // cmdBackup
            // 
            cmdBackup.FlatStyle = FlatStyle.Popup;
            cmdBackup.Location = new Point(572, 271);
            cmdBackup.Name = "cmdBackup";
            cmdBackup.Size = new Size(67, 22);
            cmdBackup.TabIndex = 5;
            cmdBackup.Text = "&Backup";
            cmdBackup.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.BorderStyle = BorderStyle.FixedSingle;
            TextBox1.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox1.Location = new Point(9, 46);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(557, 21);
            TextBox1.TabIndex = 1;
            TextBox1.Text = @"C:\";
            // 
            // cmdBrowse
            // 
            cmdBrowse.FlatStyle = FlatStyle.Popup;
            cmdBrowse.Location = new Point(572, 45);
            cmdBrowse.Name = "cmdBrowse";
            cmdBrowse.Size = new Size(67, 22);
            cmdBrowse.TabIndex = 2;
            cmdBrowse.Text = "Br&owse";
            cmdBrowse.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Location = new Point(9, 302);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(630, 67);
            GroupBox1.TabIndex = 6;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Note";
            // 
            // Label3
            // 
            Label3.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(21, 39);
            Label3.Name = "Label3";
            Label3.Size = new Size(338, 23);
            Label3.TabIndex = 2;
            Label3.Text = "2. Check data before backing up.";
            // 
            // Label2
            // 
            Label2.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(21, 16);
            Label2.Name = "Label2";
            Label2.Size = new Size(338, 23);
            Label2.TabIndex = 1;
            Label2.Text = "1. Please  make sure no one using the system right now.";
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(9, 297);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(418, 21);
            ProgressBar1.Style = ProgressBarStyle.Continuous;
            ProgressBar1.TabIndex = 7;
            ProgressBar1.Visible = false;
            // 
            // ListView
            // 
            ListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader2 });
            ListView.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListView.FullRowSelect = true;
            ListView.GridLines = true;
            ListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListView.Location = new Point(9, 75);
            ListView.Name = "ListView";
            ListView.Size = new Size(630, 182);
            ListView.Sorting = SortOrder.Ascending;
            ListView.TabIndex = 3;
            ListView.UseCompatibleStateImageBehavior = false;
            ListView.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Back-Up File";
            ColumnHeader1.Width = 433;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "Back-Up File Date";
            ColumnHeader2.Width = 193;
            // 
            // Timer1
            // 
            // 
            // frmBackupData
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(651, 381);
            Controls.Add(ListView);
            Controls.Add(GroupBox1);
            Controls.Add(cmdBrowse);
            Controls.Add(TextBox1);
            Controls.Add(cmdBackup);
            Controls.Add(cmdRestore);
            Controls.Add(Label1);
            Controls.Add(ProgressBar1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmBackupData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL Database Backup / Restore";
            GroupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal Button cmdRestore;
        internal Button cmdBackup;
        internal FolderBrowserDialog FolderBrowserDialog1;
        internal TextBox TextBox1;
        internal Button cmdBrowse;
        internal GroupBox GroupBox1;
        internal ProgressBar ProgressBar1;
        internal Label Label3;
        internal Label Label2;
        internal ListView ListView;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal SaveFileDialog SaveFileDialog1;
        internal Timer Timer1;
    }
}