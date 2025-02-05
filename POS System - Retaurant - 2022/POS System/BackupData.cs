using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class BackupData
    {
        private string BackupSet;
        private FileInfo filedate;

        public BackupData()
        {
            InitializeComponent();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {

            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox1.Text = FolderBrowserDialog1.SelectedPath;
                ListView.Items.Clear();

                string targetDirectory = TextBox1.Text;
                string[] fileEntries = Directory.GetFiles(targetDirectory, "*.bak");
                foreach (var fileName in fileEntries)
                {
                    filedate = new FileInfo(fileName);
                    var TestItem = new ListViewItem();
                    TestItem.Text = fileName.ToString();
                    TestItem.SubItems.Add(Strings.Format(filedate.LastWriteTime, "MMMM dd,yyyy (dddd)"));
                    ListView.Items.Add(TestItem);
                }
            }

        }

        private void cmdRestore_Click(object sender, EventArgs e)
        {
            // Procedure for Restore First Blank Database backup with default values
            if (string.IsNullOrEmpty(BackupSet))
            {
                Interaction.MsgBox("Please Select backup file before restore");
                return;
            }

            try
            {
                GroupBox1.Visible = false;
                Timer1.Enabled = true;
                ProgressBar1.Visible = true;
                // Drop the connection to the DB by setting the connection to your session only (single user), any current transaction on the DB => it will be rolledback immediatelly
                string SetDB1 = "ALTER DATABASE POS set SINGLE_USER WITH ROLLBACK IMMEDIATE";
                // Return the connection to the DB to be multi users
                string SetDB2 = "ALTER DATABASE POS SET MULTI_USER";

                string RestoreDatabase = "RESTORE DATABASE POS FROM DISK = '" + BackupSet + "' WITH REPLACE";
                string RstconStr = "Server=" + mdlGeneral.ServerName + ";Database=master;Trusted_Connection=yes";
                var RstobjCon = new SqlConnection(RstconStr);
                var Rstobj = new SqlCommand();
                Rstobj = RstobjCon.CreateCommand();
                // Execute Command
                Rstobj.CommandText = SetDB1;
                Rstobj.Connection.Open();
                Rstobj.ExecuteNonQuery();

                Rstobj.CommandText = RestoreDatabase;
                Rstobj.ExecuteNonQuery();

                Rstobj.CommandText = SetDB2;
                Rstobj.ExecuteNonQuery();

                Rstobj.Connection.Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, My.MyProject.Application.Info.ProductName);
            }

        }

        private void ListView_Click(object sender, EventArgs e)
        {

            int si = ListView.SelectedIndices[0];
            BackupSet = ListView.Items[si].SubItems[0].Text.Trim();

        }

        private void cmdBackup_Click(object sender, EventArgs e)
        {

            SaveFileDialog1.FileName = "POS_" + Strings.Format(DateTime.Parse(DateTime.Now.ToShortDateString().ToString()), "ddmmyyyy");
            SaveFileDialog1.Filter = "Bak files (*.BAK)|*.BAK|All files (*.*)|*.*";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GroupBox1.Visible = false;
                Timer1.Enabled = true;
                ProgressBar1.Visible = true;
                string SaveSet;
                SaveSet = SaveFileDialog1.FileName;
                // Procedure for Restore First Blank Database backup with default values
                try
                {
                    // Drop the connection to the DB by setting the connection to your session only (single user), any current transaction on the DB => it will be rolledback immediatelly
                    string SetDB1 = "ALTER DATABASE POS set SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    // Return the connection to the DB to be multi users
                    string SetDB2 = "ALTER DATABASE POS SET MULTI_USER";

                    string BackupDatabase = "BACKUP DATABASE POS TO DISK = '" + SaveSet + "'";
                    string RstconStr = "Server=" + mdlGeneral.ServerName + ";Database=master;Trusted_Connection=yes";
                    var RstobjCon = new SqlConnection(RstconStr);
                    var Rstobj = new SqlCommand();
                    Rstobj = RstobjCon.CreateCommand();
                    // Execute Command
                    Rstobj.CommandText = SetDB1;
                    Rstobj.Connection.Open();
                    Rstobj.ExecuteNonQuery();

                    Rstobj.CommandText = BackupDatabase;
                    Rstobj.ExecuteNonQuery();

                    Rstobj.CommandText = SetDB2;
                    Rstobj.ExecuteNonQuery();

                    Rstobj.Connection.Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, My.MyProject.Application.Info.ProductName);
                }
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (ProgressBar1.Value == 100)
            {
                Timer1.Enabled = false;
                ProgressBar1.Visible = false;
                GroupBox1.Visible = true;
                Interaction.MsgBox("Successfully Done");
            }
            else
            {
                ProgressBar1.Value = ProgressBar1.Value + 5;
            }
        }

    }
}