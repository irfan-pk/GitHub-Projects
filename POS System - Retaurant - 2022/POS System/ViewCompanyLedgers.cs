using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class ViewCompanyLedgers
    {
        private bool drag, EditMode;
        private double PPrice;
        private string LedgerQuery;
        private int mousex, mousey, Pos;

        public ViewCompanyLedgers()
        {
            InitializeComponent();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void frmViewCompanyLedgers_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            cmdMin.Left = Width - (cmdMin.Width + 5);
            mdlGeneral.GetConnectionString();
            FromDate.Value = DateAndTime.DateAdd(DateInterval.Day, -1, DateTime.Now);
            LedgerQuery = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "SUPL_TR_DT <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) " + "ORDER BY SUPL_TR_ID";

            View_Ledgers(LedgerQuery);
        }

        private void View_Ledgers(string StandardQuery)
        {
            try
            {
                // Retrieve Records for datagrid view from product table
                PaymentDataSet.Clear();
                mdlGeneral.PurchaseAdapter.Dispose();
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.PurchaseAdapter, StandardQuery, mdlGeneral.Connection);
                mdlGeneral.PurchaseAdapter.Fill(PaymentDataSet, "SUPPLIERS_PAYM");
                var Reader = mdlGeneral.PurchaseAdapter.SelectCommand.ExecuteReader();
                if (Reader.HasRows)
                {
                    PayBindingSource.DataSource = PaymentDataSet;
                    PayBindingSource.DataMember = "SUPPLIERS_PAYM";
                    PaymentDataGridView.Refresh();
                }
            }
            catch (Exception EX)
            {
                mdlGeneral.gblMessage = EX.Message;
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
            }
        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BindingNavigatorTextBox.Text))
            {
                LedgerQuery = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "SUPL_TR_DT <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) " + "ORDER BY SUPL_TR_ID";

            }
            else
            {
                LedgerQuery = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "SUPL_TR_DT <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND PRCH_CD = N'" + BindingNavigatorTextBox.Text.Trim() + "' " + "ORDER BY SUPL_TR_ID";

            }
            View_Ledgers(LedgerQuery);
        }

        private void BindingNavigatorFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BindingNavigatorTextBox.Text))
            {
                Interaction.MsgBox("Please select valid Wholesaler code.", (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.OkOnly), My.MyProject.Application.Info.ProductName);
                return;
            }
            LedgerQuery = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "SUPL_TR_DT <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDate.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND PRCH_CD = N'" + BindingNavigatorTextBox.Text.Trim() + "' " + "ORDER BY SUPL_TR_ID";

            View_Ledgers(LedgerQuery);
        }

        private void BindingNavigatorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindingNavigatorFind_Click(sender, e);
            }
        }

        private void BindingNavigatorTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.SuplCode.ShowDialog(this);
                if (Strings.Len(mdlGeneral.gblItemCode) > 0)
                    BindingNavigatorTextBox.Text = mdlGeneral.gblItemCode.ToUpper();
                else
                    return;
                BindingNavigatorFind_Click(sender, e);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
            My.MyProject.Forms.Wholesalers.WindowState = FormWindowState.Normal;
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}