using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); 
            mdlGeneral.GetConnectionString();
            string CommandText = "SELECT CUST_NAME FROM CUSTOMERS ORDER BY CUST_NAME";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.ProductCodeAdapter, CommandText, mdlGeneral.Connection);
            var Reader = mdlGeneral.ProductCodeAdapter.SelectCommand.ExecuteReader();
            if (Reader.HasRows == false)
            {
                mdlGeneral.gblMessage = "Please add customer first in the table.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                Close();
                return;
            }
            while (Reader.Read())
                comboBox1.Items.Add(Reader["cust_name"].ToString().Trim());
            if (Reader is null)
                Reader.Close();
        }

        private void CustomerList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string CommandText = "SELECT * FROM CUSTOMERS WHERE CUST_NAME = '" + Strings.Trim(comboBox1.Text.Trim()) + "'";
                    mdlGeneral.ExecuteDatasetQuery(mdlGeneral.ProductCodeAdapter, mdlGeneral.ProductCodeDataset, CommandText, "CUSTOMERS", mdlGeneral.Connection);
                    mdlGeneral.gblCustId = Convert.ToInt32( mdlGeneral.ProductCodeDataset.Tables["CUSTOMERS"].Rows[0]["CUST_CODE"].ToString().Trim());
                    mdlGeneral.gblCustName  = mdlGeneral.ProductCodeDataset.Tables["CUSTOMERS"].Rows[0]["CUST_NAME"].ToString().Trim();
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
    }
}
