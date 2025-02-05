using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class FoodMenu
    {
        private bool inputStatus;
        private bool hasDecimal;
        private string ItemName, ItemQty, ItemCode;
        private string[] FirstMenu = new string[101];
        private bool clearDisplay = false;

        public FoodMenu()
        {
            InitializeComponent();
        }

        #region Form Events
        private void frmFoodMenu_Load(object sender, EventArgs e)
        {
            mdlGeneral.GetConnectionString();
            AddButtons();
            var MyControl = new Button();
            var MyEvent = new EventArgs();
            MyControl.Text = FirstMenu[0];
            // Call ClickButton(MyControl, MyEvent)
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            mdlGeneral.gblOrder = false;
            Close();
        }
        #endregion
        #region Menu Buttons Procedure
        private void AddButtons()
        {
            int I = 0;
            string MenuGroupQuery = "Select distinct PROD_CATG from PRODUCTS order by PROD_CATG";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, MenuGroupQuery, mdlGeneral.Connection);
            var GroupReader = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
            if (GroupReader.HasRows)
            {
                while (GroupReader.Read())
                {
                    var MenuGroup = new Button();
                    MenuGroup.Text = GroupReader["PROD_CATG"].ToString().ToUpper().Trim();
                    MenuGroup.Size = new Size(118, 30);
                    MenuGroup.Font = new Font("Tahoma", 10.0f);
                    MenuGroup.Font = new Font(MenuGroup.Font, FontStyle.Bold);
                    MenuGroup.FlatStyle = FlatStyle.Flat;
                    MenuGroup.TextAlign = ContentAlignment.MiddleCenter;
                    MenuGroup.BackColor = Color.DeepSkyBlue;
                    MenuGroup.ForeColor = Color.White;
                    MenuGroup.FlatAppearance.BorderColor = Color.WhiteSmoke;
                    MenuGroup.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
                    MenuGroup.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
                    FirstMenu[I] = MenuGroup.Text.Trim();
                    I += 1;
                    GroupFlowPanel.Controls.Add(MenuGroup);
                    ToolTip1.SetToolTip(MenuGroup, "Click to get subitems");
                    MenuGroup.Click += ClickButton;
                }
            }
        }

        // Result of (Click Button) event, get the text of button
        public void ClickButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // Populate Submenu Items and create menu buttons in flowpanel
            string SubItemsQuery = "SELECT distinct PROD_CATG, PROD_DESC from products where PROD_CATG = N'" + btn.Text.Trim() + "' ORDER BY PROD_DESC";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.TransferAdapter, SubItemsQuery, mdlGeneral.Connection);
            var ItemReader = mdlGeneral.TransferAdapter.SelectCommand.ExecuteReader();
            if (ItemReader.HasRows)
            {
                // To remove all items before add new
                for (int i = ItemFlowPanel.Controls.Count - 1; i >= 0; i -= 1)
                    ItemFlowPanel.Controls.RemoveAt(i);   // Here you actually provide the index!
                while (ItemReader.Read())
                {
                    var MenuItems = new Button();
                    MenuItems.Text = ItemReader["PROD_DESC"].ToString().ToUpper().Trim();
                    MenuItems.Size = new Size(120, 30);
                    // .AutoSize = True
                    MenuItems.Font = new Font("Tahoma", 8.25f);
                    MenuItems.BackColor = Color.DarkGreen;
                    MenuItems.Font = new Font(MenuItems.Font, FontStyle.Bold);
                    MenuItems.FlatStyle = FlatStyle.Flat;
                    MenuItems.TextAlign = ContentAlignment.MiddleCenter;
                    MenuItems.FlatAppearance.BorderColor = Color.Silver;
                    MenuItems.FlatAppearance.MouseDownBackColor = Color.Silver;
                    MenuItems.ForeColor = Color.WhiteSmoke;
                    ItemFlowPanel.Controls.Add(MenuItems);
                    MenuItems.Click += ItemButton;
                }
            }

        }

        // Result of (Click Button) event, get the text of button
        public void ItemButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ListViewItem xItem;
            // Populate Items and add into order list
            string SubItemsQuery = "SELECT * from products where PROD_DESC = N'" + btn.Text.Trim() + "' ORDER BY PROD_DESC";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.EntryDataAdpter, SubItemsQuery, mdlGeneral.Connection);
            var ItemReader = mdlGeneral.EntryDataAdpter.SelectCommand.ExecuteReader();
            if (ItemReader.HasRows)
            {
                while (ItemReader.Read())
                {
                    if (string.IsNullOrEmpty(lblDisplay.Text) | lblDisplay.Text == "0" | lblDisplay.Text == "0.")
                    {
                        ItemQty = 1.ToString();
                    }
                    else
                    {
                        ItemQty = Conversion.Val(lblDisplay.Text.Trim()).ToString();
                    }
                    ItemName = ItemReader["PROD_DESC"].ToString().Trim();
                    ItemCode = ItemReader["PROD_CD"].ToString().Trim();
                    if (lvOrderList.Items.Count > 0)
                    {
                        xItem = lvOrderList.FindItemWithText(ItemName, false, 0, true);
                        if (xItem is not null)
                        {
                            xItem.SubItems[1].Text = (Conversion.Val(xItem.SubItems[1].Text) + Conversion.Val(ItemQty.Trim())).ToString();
                            break;
                        }
                    }
                    {
                        var withBlock = lvOrderList.Items.Add(ItemReader["PROD_DESC"].ToString());
                        withBlock.SubItems.Add(ItemQty.Trim());
                        withBlock.SubItems.Add(ItemCode.Trim());
                    }
                }
            }
            lblDisplay.Text = string.Empty;
        }

        private void cmdOrder_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.Parcel.Visible == true)
            {
                mdlGeneral.gblOrder = true;
                // Generate Array Order List before leaving the form *// reserved
                mdlGeneral.gblArrayCount = 0;
                for (int I = 0, loopTo = lvOrderList.Items.Count - 1; I <= loopTo; I++)
                {
                    for (int J = 0, loopTo1 = lvOrderList.Items[I].SubItems.Count - 1; J <= loopTo1; J++)
                    {
                        mdlGeneral.gblDataArray[I, J] = lvOrderList.Items[I].Text;
                        mdlGeneral.gblDataArray[I, J] = lvOrderList.Items[I].SubItems[J].Text;
                        // temp = temp & "-" & gblDataArray(I, J) // for display array pattern
                    }
                    mdlGeneral.gblArrayCount += 1;
                }
                Dispose();
            }
            else
            {
                mdlGeneral.gblMessage = "Please use parcel option before settle the order.";
                My.MyProject.Forms.MsgStatus.ShowDialog(this);
            }
        }

        #region Num Pad Functions
        private void DigitClick(object sender, EventArgs e)
        {
            if (clearDisplay)
            {
                lblDisplay.Text = string.Empty;
                clearDisplay = false;
            }
            lblDisplay.Text += (sender as Button).Text;
        }


        private void NumFriction_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.IndexOf(".") >= 0)
            {
                return;
            }
            else if (Strings.Len(lblDisplay.Text) == 0)
            {
                lblDisplay.Text = "0.";
            }
            else
            {
                lblDisplay.Text += ".";
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            string str;
            int loc;
            if (lblDisplay.Text.Length > 0)
            {
                str = Conversions.ToString(lblDisplay.Text[lblDisplay.Text.Length - 1]);
                if (str == ".")
                {
                    hasDecimal = false;
                }
                loc = lblDisplay.Text.Length;
                lblDisplay.Text = lblDisplay.Text.Remove(loc - 1, 1);
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Empty;
            hasDecimal = false;
        }
        #endregion 

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            // Clear all items from listview control
            lvOrderList.Items.Clear();
            // To remove all items from flowlayoutpanel before add new buttons
            for (int i = ItemFlowPanel.Controls.Count - 1; i >= 0; i -= 1)
                ItemFlowPanel.Controls.RemoveAt(i);   // Here you actually provide the index!
            GroupFlowPanel.Refresh();
        }

        private void lvOrderList_DoubleClick(object sender, EventArgs e)
        {
            if (lvOrderList.Items.Count > 0)
            {
                var response = Interaction.MsgBox("Are You Sure to remove Item (" + lvOrderList.SelectedItems[0].Text.ToString().Trim() + ") ?", (MsgBoxStyle)((int)MsgBoxStyle.Critical + (int)MsgBoxStyle.YesNo), "Delete Order");
                if (response == MsgBoxResult.Yes)
                {
                    int i = lvOrderList.Items.IndexOf(lvOrderList.SelectedItems[0]);
                    lvOrderList.Items[i].Remove();
                    i = 0;
                }
            }
        }
        #endregion

    }
}