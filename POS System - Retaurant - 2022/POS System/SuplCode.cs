using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class SuplCode
    {
        public SuplCode()
        {
            InitializeComponent();
        }

        private void frmSuplCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string CommandText = "SELECT * FROM SUPPLIERS WHERE SUPL_NAME = N'" + Strings.Trim(comboBox1.Text.Trim()) + "'";
                    mdlGeneral.ExecuteDatasetQuery(mdlGeneral.ProductCodeAdapter, mdlGeneral.ProductCodeDataset, CommandText, "SUPPLIERS", mdlGeneral.Connection);
                    mdlGeneral.gblCP_ID = mdlGeneral.ProductCodeDataset.Tables["SUPPLIERS"].Rows[0]["SUPL_CODE"].ToString().Trim();
                    mdlGeneral.Connection.Close();
                }
                // Me.Close()
                catch (Exception EXCP)
                {
                    Interaction.MsgBox(EXCP.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
                Close();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            mdlGeneral.GetConnectionString();
            string CommandText = "SELECT * FROM SUPPLIERS ORDER BY SUPL_CODE";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.ProductCodeAdapter, CommandText, mdlGeneral.Connection);
            var Reader = mdlGeneral.ProductCodeAdapter.SelectCommand.ExecuteReader();
            if (Reader.HasRows == false)
            {
                mdlGeneral.gblMessage = "Please add customer first in the table.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                Close();
                return;
            }
            var dtTest = new DataTable();
            dtTest.Columns.Add("Name", typeof(string));
            dtTest.Columns.Add("ID", typeof(string));
            while (Reader.Read())
                dtTest.Rows.Add(Reader["supl_code".ToString().Trim()], Reader["supl_name"].ToString().Trim());
            if (Reader is null)
                Reader.Close();
            // Bind the ComboBox to the DataTable

            comboBox1.DataSource = dtTest;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "Name";

            // Enable the owner draw on the ComboBox.
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            // Handle the DrawItem event to draw the items.
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the default background
            e.DrawBackground();

            // The ComboBox is bound to a DataTable,
            // so the items are DataRowView objects.
            DataRowView drv = (DataRowView)comboBox1.Items[e.Index];

            // Retrieve the value of each column.
            string id = drv["ID"].ToString();
            string name = drv["Name"].ToString();

            // Get the bounds for the first column
            var r1 = e.Bounds;
            r1.Width = (int)Math.Round(r1.Width / 2d);

            // Draw the text on the first column
            using (var sb = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(id, e.Font, sb, r1);
            }

            // Draw a line to isolate the columns 
            using (var p = new Pen(Color.Black))
            {
                e.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom);
            }

            // Get the bounds for the second column
            var r2 = e.Bounds;
            r2.X = (int)Math.Round(e.Bounds.Width / 2d);
            r2.Width = (int)Math.Round(r2.Width / 2d);

            // Draw the text on the second column
            using (var sb = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(name, e.Font, sb, r2);
            }
        }
    }
}