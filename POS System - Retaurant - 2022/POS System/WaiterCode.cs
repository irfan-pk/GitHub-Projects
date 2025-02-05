using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class WaiterCode
    {
        public WaiterCode()
        {
            InitializeComponent();
        }
        private void frmCustCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string CommandText = "SELECT * FROM WAITERS WHERE WAITER_NAME = N'" + Strings.Trim(ListBox1.Text.Trim()) + "'";
                    mdlGeneral.ExecuteDatasetQuery(mdlGeneral.ProductCodeAdapter, mdlGeneral.ProductCodeDataset, CommandText, "WAITERS", mdlGeneral.Connection);
                    mdlGeneral.gblCP_ID = mdlGeneral.ProductCodeDataset.Tables["WAITERS"].Rows[0]["WAITER_ID"].ToString().Trim();
                    mdlGeneral.gblCP = mdlGeneral.ProductCodeDataset.Tables["WAITERS"].Rows[0]["WAITER_NAME"].ToString().Trim();
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
            // Query to select customers from table
            string CommandText = "SELECT * FROM WAITERS ORDER BY WAITER_ID";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.ProductCodeAdapter, CommandText, mdlGeneral.Connection);
            var Reader = mdlGeneral.ProductCodeAdapter.SelectCommand.ExecuteReader();
            if (Reader.HasRows == false)
            {
                mdlGeneral.gblMessage = "Please add waiter first in the table.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                Close();
                return;
            }
            // if table has rows
            var dtTest = new DataTable();
            dtTest.Columns.Add("Name", typeof(string));
            dtTest.Columns.Add("ID", typeof(string));
            while (Reader.Read())
                dtTest.Rows.Add(Reader["waiter_id".ToString().Trim()], Reader["waiter_name"].ToString().Trim());
            if (Reader is null)
                Reader.Close();
            // Bind the ComboBox to the DataTable
            ListBox1.DataSource = dtTest;
            ListBox1.DisplayMember = "ID";
            ListBox1.ValueMember = "Name";

            // Enable the owner draw on the ComboBox.
            ListBox1.DrawMode = DrawMode.OwnerDrawFixed;
            // Handle the DrawItem event to draw the items.

        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the default background
            e.DrawBackground();

            // The ComboBox is bound to a DataTable,
            // so the items are DataRowView objects.
            DataRowView drv = (DataRowView)ListBox1.Items[e.Index];

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