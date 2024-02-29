using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class SaleBook : Form
    {
        //lblCash.Text = string.Format("{0:C2}",TotalCash);
        //lblCredit.Text = string.Format("{0:C2}", TotalCredit);
        //string.Format(new CultureInfo("en-US"), "{0:c}", 112.236677); //$112.24
        //string.Format(new CultureInfo("de-DE"), "{0:c}", 112.236677); //112,24 €
        //string.Format(new CultureInfo("ur-PK"), "{0:c}", 112.236677); //Rs.112.24
        int SaleRowId = 0;

        public SaleBook()
        {
            InitializeComponent();
            BtnNew.MouseEnter += MouseEnterEvent;
            BtnNew.MouseLeave += MouseLeaveEvent;
            BtnPrint.MouseEnter += MouseEnterEvent;
            BtnPrint.MouseLeave += MouseLeaveEvent;
            BtnClose.MouseEnter += MouseEnterEvent;
            BtnClose.MouseLeave += MouseLeaveEvent;
        }

        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.ForeColor = Color.Black;
        }

        private void MouseEnterEvent(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.ForeColor = Color.White;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            GlobalVariableClass.v_gblRecMode = true;
            SaleInvoice childForm = new SaleInvoice();
            childForm.MdiParent = this.MdiParent;
            childForm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaleBook_Load(object sender, EventArgs e)
        {
            FillMasterGrid();
        }

        public void FillMasterGrid()
        {
            try
            {
                Decimal TotalCash = 0, TotalCredit = 0;
                this.components.Add(SaleBindingource);
                this.components.Add(DetailBindingSource);
                this.components.Add(SaleDataSet);
                SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from SaleOrder where date >= CONVERT(DATETIME,'" + dtpFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and date <= CONVERT(DATETIME,'" + dtpTo.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) order by saleorderid", conn);
                SqlDataAdapter GridAdpter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                GridAdpter.SelectCommand = cmd;
                conn.Open();
                GridAdpter.Fill(dt);
                SaleBindingource.DataSource = dt;
                if (DgvSaleMaster.Rows.Count > 0)
                {
                    foreach (DataGridViewRow gRow in DgvSaleMaster.Rows)
                    {
                        TotalCash += Convert.ToDecimal(gRow.Cells[5].Value.ToString());
                        TotalCredit += Convert.ToDecimal(gRow.Cells[6].Value.ToString());
                    }
                }
                conn.Close();
                lblCash.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalCash);
                lblCredit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalCredit);
                if (DgvSaleMaster.Rows.Count > 0) { SaleRowId = Convert.ToInt32(DgvSaleMaster.Rows[DgvSaleMaster.CurrentRow.Index].Cells[1].Value); } else { SaleRowId = 0; }
                DisplayDetailOrder(SaleRowId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayDetailOrder(int SaleOrdreID)
        {
            DetailBindingSource.DataSource = null;
            SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from SaleOrderDetail where ItemOrderId = " + SaleOrdreID + " order by itemorderid", conn);
            SqlDataAdapter GridAdpter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            GridAdpter.SelectCommand = cmd;
            conn.Open();
            GridAdpter.Fill(dt);
            DetailBindingSource .DataSource = dt;
            DgvOrderDetail.Refresh();
            conn.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // Print Bills Procedure
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            //DgvSaleMaster.Rows.Clear();
            FillMasterGrid();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            //DgvSaleMaster.Rows.Clear();
            FillMasterGrid();
        }

        private void DgvSaleMaster_SelectionChanged(object sender, EventArgs e)
        {
            int SaleID = Convert.ToInt32(this.DgvSaleMaster.Rows[DgvSaleMaster.CurrentRow.Index].Cells[1].Value);
            DisplayDetailOrder(SaleID);
        }
    }
}
