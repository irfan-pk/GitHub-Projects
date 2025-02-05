using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_System
{

    public partial class HoldSale
    {
        private string FindID;

        public HoldSale()
        {
            InitializeComponent();
        }

        private void frmHoldSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.Enter)
            {
                mdlGeneral.gblCP_ID = dgHoldInfo.Rows[dgHoldInfo.CurrentRow.Index].Cells[0].Value.ToString();
                mdlGeneral.gblCP = dgHoldInfo.Rows[dgHoldInfo.CurrentRow.Index].Cells[1].Value.ToString();
                mdlGeneral.Connection.Close();
                // MsgBox(gblCP_ID & " " & gblCP)
                HoldDataSet.Clear();
                RecordDataSet.Clear();
                Close();
                return;
            }
        }

        private void frmHoldSale_Load(object sender, EventArgs e)
        {
            mdlGeneral.GetConnectionString();
            Popup_SaleData();
        }

        private void Popup_SaleData()
        {
            HoldDataSet.Clear();
            if (mdlGeneral.gblRelation == true)
                HoldDataSet.Relations.Remove("HoldMasterDetail");
            // Add data from the sale master table to the DataSet.
            var MasterDataAdapter = new SqlDataAdapter("select * from SALE_MASTER_HOLD", mdlGeneral.Connection);
            MasterDataAdapter.Fill(HoldDataSet, "SALE_MASTER_HOLD");

            // Add data from the sale detail table to the DataSet.
            var DetailsDataAdapter = new SqlDataAdapter("select * from SALE_DETAIL_HOLD", mdlGeneral.Connection);
            DetailsDataAdapter.Fill(HoldDataSet, "SALE_DETAIL_HOLD");

            // Establish a relationship between the master and detail tables.
            var Relation = new DataRelation("HoldMasterDetail", HoldDataSet.Tables["SALE_MASTER_HOLD"].Columns["SaleID"], HoldDataSet.Tables["SALE_DETAIL_HOLD"].Columns["SaleID"]);

            HoldDataSet.Relations.Add(Relation);
            mdlGeneral.gblRelation = true;
            // Bind the hold master data connector to the hold detail table.
            HoldBindingSource.DataSource = HoldDataSet;
            HoldBindingSource.DataMember = "SALE_MASTER_HOLD";

            // Bind the details data connector to the master data connector,
            // using the DataRelation name to filter the information in the 
            // details table based on the current row in the master table. 
            SaleBindingSource.DataSource = HoldBindingSource;
            SaleBindingSource.DataMember = "HoldMasterDetail";
        }
    }
}