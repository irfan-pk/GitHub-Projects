using System;
using System.Drawing;
using System.Windows.Forms;

namespace WholeSaleApplication
{
    public partial class MainForm : Form
    {
        readonly GlobalVariableClass FunctionsClass = new GlobalVariableClass();
        public MainForm()
        {
            InitializeComponent();
            // Assign Mouse Over and Leave Event Handler
            BtnAccounts.MouseEnter += control_MouseEnter;
            BtnAccounts.MouseLeave += control_MouseLeave;
            BtnBank.MouseEnter += control_MouseEnter;
            BtnBank.MouseLeave += control_MouseLeave;
            BtnExit.MouseEnter += control_MouseEnter;
            BtnExit.MouseLeave += control_MouseLeave;
            BtnMInvoice.MouseEnter += control_MouseEnter;
            BtnMInvoice.MouseLeave += control_MouseLeave;
            BtnPOS.MouseEnter += control_MouseEnter;
            BtnPOS.MouseLeave += control_MouseLeave;
            BtnPRegister.MouseEnter += control_MouseEnter;
            BtnPRegister.MouseLeave += control_MouseLeave;
            BtnProfit.MouseEnter += control_MouseEnter;
            BtnProfit.MouseLeave += control_MouseLeave;
            BtnPurchase.MouseEnter += control_MouseEnter;
            BtnPurchase.MouseLeave += control_MouseLeave;
            BtnQPay.MouseEnter += control_MouseEnter;
            BtnQPay.MouseLeave += control_MouseLeave;
            BtnQReceipt.MouseEnter += control_MouseEnter;
            BtnQReceipt.MouseLeave += control_MouseLeave;
            BtnSale.MouseEnter += control_MouseEnter;
            BtnSale.MouseLeave += control_MouseLeave;
            BtnSRegister.MouseEnter += control_MouseEnter;
            BtnSRegister.MouseLeave += control_MouseLeave;
            BtnItem.MouseEnter += control_MouseEnter;
            BtnItem.MouseLeave += control_MouseLeave;
            btnLogBook.MouseEnter += control_MouseEnter;
            btnLogBook.MouseLeave += control_MouseLeave;
            btnSaleReturn.MouseEnter += control_MouseEnter;
            btnSaleReturn.MouseLeave += control_MouseLeave;
        }

        private void control_MouseEnter (object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.ForeColor = Color.White;
        }

        private void control_MouseLeave (object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
                control.ForeColor = Color.Black;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                    Application.OpenForms[i].Close();
            }
            Environment.Exit(0);
            Application.Exit();
        }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            AccountBook newMdiChild = new AccountBook();
            GlobalVariableClass.showWindow(newMdiChild, this);

        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            // for menu items by pressing with control key
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control) { BtnAccounts_Click(sender,e); }
            if (e.KeyCode == Keys.I && e.Modifiers == Keys.Control) { BtnItem_Click(sender, e); }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control) { BtnSale_Click(sender, e); }
            if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control) { BtnPurchase_Click(sender, e); }
            if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control) { btnLogBook_Click(sender, e); }
            if (e.KeyCode == Keys.R && e.Modifiers == Keys.Control) { btnSaleReturn_Click(sender, e); }
            // for menu items by function key
            if (e.KeyCode == Keys.F6) { BtnQReceipt_Click(sender, e); }
            if (e.KeyCode == Keys.F2) { SaleInvoiceForm(sender, e); }
            // For quit from application
            if (e.KeyCode == Keys.Q && e.Modifiers == Keys.Control) { Application.Exit(); }
        }

        private void groupListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GrpListForm childForm = new GrpListForm();
                GlobalVariableClass.showWindow(childForm, this);
            }
            catch (Exception Err)
            {
                Err.ToString();
                return;
            }
        }

        private void cityListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityLists childForm = new CityLists();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void areaListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AreaLists childForm = new AreaLists();
                GlobalVariableClass.showWindow(childForm, this);
            }
            catch (Exception Err)
            {
                Err.ToString();
                return;
            }
        }

        private void typesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TypeList childForm = new TypeList();
                GlobalVariableClass.showWindow(childForm, this);
            }
            catch (Exception Err)
            {
                Err.ToString();
                return;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            toolStripStatusLabel2.Text = "Log On";
            toolStripStatusLabel4.Text = GlobalVariableClass.gblOperator;
        }

        private void accTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AccountTypes childForm = new AccountTypes();
                GlobalVariableClass.showWindow(childForm, this);
            }
            catch (Exception Err)
            {
                Err.ToString();
                return;
            }
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            Products childForm = new Products();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void prodGrpStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductGroup childForm = new ProductGroup();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Companies childForm = new Companies();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void salesManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesMan childForm = new SalesMan();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {
            SaleBook childForm = new SaleBook();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void companyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfo childForm = new CompanyInfo();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void generalJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalRegister childForm = new JournalRegister();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void btnLogBook_Click(object sender, EventArgs e)
        {
            LogBook childForm = new LogBook();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void financialAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LedgerForm childForm = new LedgerForm();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseBook childForm = new PurchaseBook();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void BtnQReceipt_Click(object sender, EventArgs e)
        {
            QuickReceipts childForm = new QuickReceipts();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void BtnSRegister_Click(object sender, EventArgs e)
        {
            CashBook childForm = new CashBook();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void SaleInvoiceForm(object sender, EventArgs e)
        {
            GlobalVariableClass.v_isopen = false;
            CheckOpened("SaleBook");
            if (GlobalVariableClass.v_isopen == false)
            {
                SaleBook childForm = new SaleBook();
                SaleInvoice childForm2 = new SaleInvoice();
                GlobalVariableClass.showWindow(childForm, this);
                GlobalVariableClass.showWindow(childForm2, this);
            }
        }

        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            SaleBookReturn childForm = new SaleBookReturn();
            GlobalVariableClass.showWindow(childForm, this);
        }

        private void CheckOpened(string name)  // Reference Stack Overflow
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    GlobalVariableClass.v_isopen = true;
                    frm.Focus();
                    break;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
