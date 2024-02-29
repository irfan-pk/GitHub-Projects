using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class SaleBookReturn : Form
    {
        int SaleRowId = 0;
        public SaleBookReturn()
        {
            InitializeComponent();
            btnReturn.MouseEnter += MouseEnterEvent;
            btnReturn.MouseLeave += MouseLeaveEvent;
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
        private void SaleBookReturn_Load(object sender, EventArgs e)
        {
            FillMasterGrid();
        }
        public void FillMasterGrid()
        {
            try
            {
                Decimal TotalCredit = 0;
                this.components.Add(SaleBindingource);
                this.components.Add(DetailBindingSource);
                this.components.Add(SaleDataSet);
                SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from SaleReturn where date >= CONVERT(DATETIME,'" + dtpFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) and date <= CONVERT(DATETIME,'" + dtpTo.Value.ToString("yyyy-MM-dd") + " 00:00:00',102) order by saleorderid", conn);
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
                        TotalCredit += Convert.ToDecimal(gRow.Cells[6].Value.ToString());
                    }
                }
                conn.Close();
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
            SqlCommand cmd = new SqlCommand("Select * from SaleReturnDetail where ItemOrderId = " + SaleOrdreID + " order by itemorderid", conn);
            SqlDataAdapter GridAdpter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            GridAdpter.SelectCommand = cmd;
            conn.Open();
            GridAdpter.Fill(dt);
            DetailBindingSource.DataSource = dt;
            DgvOrderDetail.Refresh();
            conn.Close();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            FillMasterGrid();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            FillMasterGrid();
        }

        private void DgvSaleMaster_SelectionChanged(object sender, EventArgs e)
        {
            FillMasterGrid();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SaleInvoiceReturn childform = new SaleInvoiceReturn();
            childform.MdiParent = this.MdiParent;
            childform.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
