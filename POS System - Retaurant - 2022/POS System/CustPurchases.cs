using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class CustPurchases
    {
        public CustPurchases()
        {
            InitializeComponent();
        }

        private void BindingNavigatorClose_Click(object sender, EventArgs e)
        {
            Close();
            My.MyProject.Forms.CustomerMenu.WindowState = FormWindowState.Normal;
        }

        private void BindingNavigatorFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BindingNavigatorTextBox.Text) | Conversion.Val(BindingNavigatorTextBox.Text.Trim()) == 0d)
            {
                mdlGeneral.gblMessage = "Please valid customer ID to Search ?";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
                return;
            }
            Popup_SaleData();
        }

        private void Popup_SaleData()
        {
            CustomerDataSet.Clear();
            string SaleDetail = "SELECT SaleID,CustomerID,CustomerName,StockDesc,SalePack,UnitCost,Qty,Price,(convert(varchar(8),detaildate,112))+RIGHT('0000'+convert(varchar(4),detailID),4) as SequenceID FROM SALE_DETAIL " + "WHERE CustomerID = N'" + Conversion.Val(BindingNavigatorTextBox.Text.Trim()) + "' AND (DetailDate >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "DetailDate <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102)) ORDER BY SALEID";

            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, SaleDetail, mdlGeneral.Connection);
            mdlGeneral.SqlDataAdapter.Fill(CustomerDataSet, "SALE_DETAIL");
            CustomerBindingSource.DataSource = CustomerDataSet;
            CustomerBindingSource.DataMember = "SALE_DETAIL";
        }

        private void BindingNavigatorTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.WaiterCode.ShowDialog(this);
                if (Strings.Len(mdlGeneral.gblCP_ID) > 0)
                    BindingNavigatorTextBox.Text = mdlGeneral.gblCP_ID.ToString().ToUpper();
                else
                    return;
                // Call BindingNavigatorFind_Click(sender, e)
            }
        }

        private void frmCustPurchases_KeyUp(object sender, KeyEventArgs e)
        {
            // If e.KeyCode = Keys.F2 Then
            // frmCustCode.ShowDialog(Me)
            // If Len(gblCP_ID) > 0 Then BindingNavigatorTextBox.Text = gblCP_ID.ToString.ToUpper Else Exit Sub
            // 'Call BindingNavigatorFind_Click(sender, e)
            // End If
        }

        private void frmCustPurchases_Load(object sender, EventArgs e)
        {
            mdlGeneral.gblCP_ID = string.Empty;
            mdlGeneral.GetConnectionString();
            // Call Popup_SaleData()
            FormBorderStyle = FormBorderStyle.None;
        }

        private void BindingNavigatorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindingNavigatorFind_Click(sender, e);
            }
        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            Popup_SaleData();
        }
    }
}