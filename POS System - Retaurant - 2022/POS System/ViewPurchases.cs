using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class ViewPurchases
    {
        private bool drag, EditMode;
        private double PPrice;
        private string PurchaseQuery;
        private int mousex, mousey, Pos;

        public ViewPurchases()
        {
            InitializeComponent();
        }

        private void frmViewPurchases_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void frmViewPurchases_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void frmViewPurchases_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
            //My.MyProject.Forms.Stock.WindowState = FormWindowState.Normal;
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmViewPurchases_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            cmdClose.Left = Width - (cmdClose.Width + 5);
            cmdMin.Left = Width - (cmdMin.Width + cmdClose.Width + 5);
            mdlGeneral.GetConnectionString();
            FromDateTime.Value = DateAndTime.DateAdd(DateInterval.Day, -1, DateTime.Now);
            PurchaseQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "PRCH_DATE <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) " + "ORDER BY PRCH_TR_ID";

            View_Data(PurchaseQuery);
        }

        private void View_Data(string StandardQuery)
        {
            try
            {
                // Retrieve Records for datagrid view from product table
                PurchaseDataSet.Clear();
                mdlGeneral.PurchaseAdapter.Dispose();
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.PurchaseAdapter, StandardQuery, mdlGeneral.Connection);
                mdlGeneral.PurchaseAdapter.Fill(PurchaseDataSet, "PURCHASE");
                var Reader = mdlGeneral.PurchaseAdapter.SelectCommand.ExecuteReader();
                if (Reader.HasRows)
                {
                    PurchaseBindingSource.DataSource = PurchaseDataSet;
                    PurchaseBindingSource.DataMember = "PURCHASE";
                    PurchaseDataGridView.Refresh();
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
                PurchaseQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "PRCH_DATE <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) " + "ORDER BY PRCH_TR_ID";

            }
            else
            {
                PurchaseQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "PRCH_DATE <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND PRCH_CD = N'" + BindingNavigatorTextBox.Text.Trim() + "' " + "ORDER BY PRCH_TR_ID";

            }
            View_Data(PurchaseQuery);
        }

        private void BindingNavigatorFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BindingNavigatorTextBox.Text))
            {
                Interaction.MsgBox("Please select valid product code.", (MsgBoxStyle)((int)MsgBoxStyle.Information + (int)MsgBoxStyle.OkOnly), My.MyProject.Application.Info.ProductName);
                return;
            }
            PurchaseQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE >= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(FromDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND " + "PRCH_DATE <= CONVERT(DATETIME,'" + Strings.Format(DateTime.Parse(ToDateTime.Text.Trim().ToString()), "yyyy-MM-dd") + " 00:00:00',102) AND PRCH_CD = N'" + BindingNavigatorTextBox.Text.Trim() + "' " + "ORDER BY PRCH_TR_ID";

            View_Data(PurchaseQuery);
            // Dim strCode As String
            // strCode = BindingNavigatorTextBox.Text.Trim
            // If Len(strCode) = 0 Then Exit Sub
            // Pos = Me.PurchaseBindingSource.Find("PRCH_CD", strCode.Trim)
            // If Not Pos = -1 Then
            // Me.PurchaseBindingSource.Position = Pos
            // End If
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
                My.MyProject.Forms.ProductCode.ShowDialog(this);
                if (Strings.Len(mdlGeneral.gblItemCode) > 0)
                    BindingNavigatorTextBox.Text = mdlGeneral.gblItemCode.ToUpper();
                else
                    return;
                BindingNavigatorFind_Click(sender, e);
            }
        }
    }
}