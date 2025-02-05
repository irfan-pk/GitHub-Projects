using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class StockPosition
    {
        private bool drag;
        private int mousex, mousey, Pos;

        public StockPosition()
        {
            InitializeComponent();
        }

        private void frmStockPosition_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void frmStockPosition_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void frmStockPosition_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
            My.MyProject.Forms.Stock.WindowState = FormWindowState.Normal;
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmStockPosition_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            cmdClose.Left = Width - (cmdClose.Width + 5);
            cmdMin.Left = Width - (cmdMin.Width + cmdClose.Width + 5);
            mdlGeneral.GetConnectionString();
            try
            {
                // Retrieve Records for datagrid view from product table
                ProductDataSet.Clear();
                mdlGeneral.ProductAdapter.Dispose();
                string ProductQuery = "SELECT * FROM PRODUCTS ORDER BY PROD_CD";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.ProductAdapter, ProductQuery, mdlGeneral.Connection);
                mdlGeneral.ProductAdapter.Fill(ProductDataSet, "PRODUCTS");
                var reader2 = mdlGeneral.ProductAdapter.SelectCommand.ExecuteReader();
                if (reader2.HasRows)
                {
                    ProductBindingSource.DataSource = ProductDataSet;
                    ProductBindingSource.DataMember = "PRODUCTS";
                    ProductDataGridView.Refresh();
                }
            }
            catch (Exception EX)
            {
                Interaction.MsgBox(EX.Message, MsgBoxStyle.Information);
            }
            BindingNavigatorSummary_Click(sender, e);

        }

        private void BindingNavigatorFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BindingNavigatorTextBox.Text))
            {
                Interaction.MsgBox("Please give valid product code.", (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.OkOnly), My.MyProject.Application.Info.ProductName);
                return;
            }
            string strCode;
            strCode = BindingNavigatorTextBox.Text.Trim();
            if (Strings.Len(strCode) == 0)
                return;
            Pos = ProductBindingSource.Find("PROD_CD", strCode.Trim());
            if (!(Pos == -1))
            {
                ProductBindingSource.Position = Pos;
            }
        }

        private void BindingNavigatorTextBox_Click(object sender, EventArgs e)
        {
            BindingNavigatorFind_Click(sender, e);
        }

        private void BindingNavigatorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindingNavigatorFind_Click(sender, e);
            }
        }

        private void BindingNavigatorSummary_Click(object sender, EventArgs e)
        {

            if (DataGridView1.Rows.Count > 0)
                DataGridView1.Rows.Clear();

            string Summary_Query = "SELECT SUM(PROD_ONHAND) AS RAW_STOCK, " + "SUM(PROD_PPRICE * PROD_ONHAND) AS TOTAL_AMNT, " + "SUM(PROD_SCH1_ONHAND + PROD_SCH2_ONHAND + PROD_SCH3_ONHAND) AS SCHEME_STOCK, " + "SUM((PROD_SCH1_PRICE * PROD_SCH1_ONHAND) + (PROD_SCH2_PRICE * PROD_SCH2_ONHAND) + (PROD_SCH3_PRICE * PROD_SCH3_ONHAND)) AS SCHEME_AMOUNT, " + "SUM(PROD_PROFIT * (PROD_ONHAND + PROD_SCH1_ONHAND + PROD_SCH2_ONHAND + PROD_SCH3_ONHAND)) AS PROFIT " + "FROM PRODUCTS WHERE PROD_ONHAND >= 0";





            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Summary_Query, mdlGeneral.Connection);
            var SummaryReader = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            // DataGridView1.ColumnCount = 9
            if (SummaryReader.HasRows)
            {
                while (SummaryReader.Read())
                {
                    if (Conversion.Val(SummaryReader["TOTAL_AMNT"].ToString()) > 0d)
                    {
                        int RowIndex = DataGridView1.Rows.Add();
                        var NewRow = DataGridView1.Rows[RowIndex];
                        NewRow.Cells[0].Value = "Stock with Positive Balance";
                        NewRow.Cells[1].Value = SummaryReader["RAW_STOCK"].ToString();
                        NewRow.Cells[2].Value = SummaryReader["TOTAL_AMNT"].ToString();
                        NewRow.Cells[3].Value = SummaryReader["SCHEME_STOCK"].ToString();
                        NewRow.Cells[4].Value = SummaryReader["SCHEME_AMOUNT"].ToString();
                        NewRow.Cells[5].Value = SummaryReader["PROFIT"].ToString();
                    }
                }
                if (SummaryReader is null)
                    SummaryReader.Close();
            }

            string Summary_Query_Neg = "SELECT SUM(PROD_ONHAND) AS RAW_STOCK, " + "SUM(PROD_PPRICE * PROD_ONHAND) AS TOTAL_AMNT, " + "SUM(PROD_SCH1_ONHAND + PROD_SCH2_ONHAND + PROD_SCH3_ONHAND) AS SCHEME_STOCK, " + "SUM((PROD_SCH1_PRICE * PROD_SCH1_ONHAND) + (PROD_SCH2_PRICE * PROD_SCH2_ONHAND) + (PROD_SCH3_PRICE * PROD_SCH3_ONHAND)) AS SCHEME_AMOUNT, " + "SUM(PROD_PROFIT * (PROD_ONHAND + PROD_SCH1_ONHAND + PROD_SCH2_ONHAND + PROD_SCH3_ONHAND)) AS PROFIT " + "FROM PRODUCTS WHERE PROD_ONHAND < 0";





            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Summary_Query_Neg, mdlGeneral.Connection);
            var SummaryReaderNeg = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            // DataGridView1.ColumnCount = 9
            if (SummaryReaderNeg.HasRows)
            {
                while (SummaryReaderNeg.Read())
                {
                    if (Conversion.Val(SummaryReaderNeg["TOTAL_AMNT"].ToString()) < 0d)
                    {
                        int RowIndex = DataGridView1.Rows.Add();
                        var NewRow = DataGridView1.Rows[RowIndex];
                        NewRow.Cells[0].Value = "Stock with Negative Balance";
                        NewRow.Cells[1].Value = SummaryReader["RAW_STOCK"].ToString();
                        NewRow.Cells[2].Value = SummaryReader["TOTAL_AMNT"].ToString();
                        NewRow.Cells[3].Value = SummaryReader["SCHEME_STOCK"].ToString();
                        NewRow.Cells[4].Value = SummaryReader["SCHEME_AMOUNT"].ToString();
                        NewRow.Cells[5].Value = SummaryReader["PROFIT"].ToString();
                    }
                }
                if (SummaryReaderNeg is null)
                    SummaryReaderNeg.Close();
            }

        }

        private void BindingNavigatorSummaryGroup_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count > 0)
                DataGridView1.Rows.Clear();

            string Summary_Query = "SELECT PROD_CATG, " + "SUM(PROD_ONHAND) AS RAW_STOCK, " + "SUM(PROD_PPRICE * PROD_ONHAND) AS TOTAL_AMNT, " + "SUM(PROD_SCH1_ONHAND + PROD_SCH2_ONHAND + PROD_SCH3_ONHAND) AS SCHEME_STOCK, " + "SUM((PROD_SCH1_PRICE * PROD_SCH1_ONHAND) + (PROD_SCH2_PRICE * PROD_SCH2_ONHAND) + (PROD_SCH3_PRICE * PROD_SCH3_ONHAND)) AS SCHEME_AMOUNT, " + "SUM(PROD_PROFIT * (PROD_ONHAND + PROD_SCH1_ONHAND + PROD_SCH2_ONHAND + PROD_SCH3_ONHAND)) AS PROFIT " + "FROM PRODUCTS WHERE PROD_ONHAND >= 0 " + "GROUP BY PROD_CATG";







            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Summary_Query, mdlGeneral.Connection);
            var SummaryReader = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            // DataGridView1.ColumnCount = 9
            if (SummaryReader.HasRows)
            {
                while (SummaryReader.Read())
                {
                    if (Conversion.Val(SummaryReader["TOTAL_AMNT"].ToString()) > 0d)
                    {
                        int RowIndex = DataGridView1.Rows.Add();
                        var NewRow = DataGridView1.Rows[RowIndex];
                        NewRow.Cells[0].Value = SummaryReader["PROD_CATG"].ToString().Trim() + " with +ve Balance";
                        NewRow.Cells[1].Value = SummaryReader["RAW_STOCK"].ToString();
                        NewRow.Cells[2].Value = SummaryReader["TOTAL_AMNT"].ToString();
                        NewRow.Cells[3].Value = SummaryReader["SCHEME_STOCK"].ToString();
                        NewRow.Cells[4].Value = SummaryReader["SCHEME_AMOUNT"].ToString();
                        NewRow.Cells[5].Value = SummaryReader["PROFIT"].ToString();
                    }
                }
                if (SummaryReader is null)
                    SummaryReader.Close();
            }

            string Summary_Query_Neg = "SELECT PROD_CATG, " + "SUM(PROD_ONHAND) AS RAW_STOCK, " + "SUM(PROD_PPRICE * PROD_ONHAND) AS TOTAL_AMNT, " + "SUM(PROD_SCH1_ONHAND + PROD_SCH2_ONHAND + PROD_SCH3_ONHAND) AS SCHEME_STOCK, " + "SUM((PROD_SCH1_PRICE * PROD_SCH1_ONHAND) + (PROD_SCH2_PRICE * PROD_SCH2_ONHAND) + (PROD_SCH3_PRICE * PROD_SCH3_ONHAND)) AS SCHEME_AMOUNT, " + "SUM(PROD_PROFIT * (PROD_ONHAND + PROD_SCH1_ONHAND + PROD_SCH2_ONHAND + PROD_SCH3_ONHAND)) AS PROFIT " + "FROM PRODUCTS WHERE PROD_ONHAND < 0 " + "GROUP BY PROD_CATG";







            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Summary_Query_Neg, mdlGeneral.Connection);
            var SummaryReaderNeg = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            // DataGridView1.ColumnCount = 9
            if (SummaryReaderNeg.HasRows)
            {
                while (SummaryReaderNeg.Read())
                {
                    if (Conversion.Val(SummaryReaderNeg["TOTAL_AMNT"].ToString()) < 0d)
                    {
                        int RowIndex = DataGridView1.Rows.Add();
                        var NewRow = DataGridView1.Rows[RowIndex];
                        NewRow.Cells[0].Value = SummaryReaderNeg["PROD_CATG"].ToString().Trim() + " with -ve Balance";
                        NewRow.Cells[1].Value = SummaryReader["RAW_STOCK"].ToString();
                        NewRow.Cells[2].Value = SummaryReader["TOTAL_AMNT"].ToString();
                        NewRow.Cells[3].Value = SummaryReader["SCHEME_STOCK"].ToString();
                        NewRow.Cells[4].Value = SummaryReader["SCHEME_AMOUNT"].ToString();
                        NewRow.Cells[5].Value = SummaryReader["PROFIT"].ToString();
                    }
                }
                if (SummaryReaderNeg is null)
                    SummaryReaderNeg.Close();
            }
        }

        private void BindingNavigatorTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.ProductCode.ShowDialog(this);
                if (Strings.Len(mdlGeneral.gblItemCode) > 0)
                    BindingNavigatorTextBox.Text = mdlGeneral.gblItemCode.ToUpper();
                else
                    return;
            }
        }
    }
}