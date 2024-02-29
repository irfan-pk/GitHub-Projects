using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class JournalRegister : Form
    {
        GlobalVariableClass VariableClass = new GlobalVariableClass();
        SqlConnection accConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        int SortId = 0;
        Decimal Balance = 0, TotalDebit = 0, TotalCredit = 0;
        String AccType = String.Empty, DelTran = String.Empty;
        String FinacialYear = String.Empty;
        
    public JournalRegister()
        {
            InitializeComponent();
            BtnClose.MouseEnter += MouseEnterEvent;
            BtnClose.MouseLeave += MouseLeaveEvent;
            BtnDeleteRec.MouseEnter += MouseEnterEvent;
            BtnDeleteRec.MouseLeave += MouseLeaveEvent;
            BtnSave.MouseEnter += MouseEnterEvent;
            BtnSave.MouseLeave += MouseLeaveEvent;
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
        private void JournalRegister_Load(object sender, EventArgs e)
        {
            this.components.Add(bindingSource);
            showLedgerDetail();
        }

        private void showLedgerDetail()
        {
            bindingSource.DataSource = null;
            decimal TotalDebit = 0, TotalCredit = 0;
            SqlConnection jConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand jCmd = new SqlCommand();
            jCmd.CommandType = CommandType.Text;
            jCmd.CommandText = "select * from ledgers where ledg_date = CONVERT(DATETIME,'" + datePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00',102)";
            jCmd.Connection = jConn;
            jConn.Open();
            SqlDataReader dr = jCmd.ExecuteReader(CommandBehavior.CloseConnection);
            // Get Ledger Rows
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    // Add Fetched Row into DataGrid
                    int nRowIndex = DgvJournal.Rows.Add();
                    DataGridViewRow nRow = DgvJournal.Rows[nRowIndex];
                    nRow.Cells[0].Value = dr.GetDateTime(0).ToString("yyyy-MM-dd");
                    nRow.Cells[1].Value = dr.GetDecimal(1);
                    nRow.Cells[2].Value = dr.GetString(2);
                    nRow.Cells[3].Value = dr.GetString(3);
                    nRow.Cells[4].Value = dr.GetInt32(4);
                    nRow.Cells[5].Value = dr.GetString(5);
                    nRow.Cells[6].Value = dr.GetString(6);
                    nRow.Cells[7].Value = dr.GetString(7);
                    nRow.Cells[8].Value = dr.GetString(8);
                    nRow.Cells[9].Value = dr.GetDecimal(9);
                    nRow.Cells[10].Value = dr.GetDecimal(10);
                    nRow.Cells[11].Value = dr.GetDecimal(11);
                    nRow.Cells[12].Value = dr.GetInt32(12);
                    nRow.Cells[13].Value = dr.GetString(13);
                    TotalDebit += dr.GetDecimal(9);
                    TotalCredit += dr.GetDecimal(10);
                }
                BtnDeleteRec.Enabled = true;
                lblTotalDebit.Text = GlobalVariableClass.FormatCurrency("Rs", TotalDebit);
                lblTotalCredit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalCredit);
                SetNextTrans("Y");
            }
            jConn.Close();
            GlobalVariableClass.FillComboxBox(this.cbAccountName, "account_name", "accounts");
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DgvJournal.Rows.Count > 0)
            {
                for (int i = DgvJournal.Rows.Count - 1; i >= 0; i--)
                {
                    DgvJournal.Rows.RemoveAt(i);
                }
            }
            showLedgerDetail();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MadeJournalGridEntry(String DrCr)
        {
            DataGridViewCell FindCell = GetItemExistsInGridView(cbAccountName.Text, DgvJournal, 5);
            if (FindCell == null)
            {
                SortId += 1;
                DateTime F_Year = DateTime.Today;
                if (F_Year.Month < 7) { FinacialYear = "FY - " + F_Year.Year; }
                
                // Add New Row into DataGrid
                int nRowIndex = DgvJournal.Rows.Add();
                DataGridViewRow nRow = DgvJournal.Rows[nRowIndex];
                nRow.Cells[0].Value = datePicker.Value.ToShortDateString();
                nRow.Cells[1].Value = lblTranId.Text.Trim();
                nRow.Cells[2].Value = "Account";
                nRow.Cells[3].Value = lblAccHead.Text.Trim();
                nRow.Cells[4].Value = tbAccId.Text.Trim();
                nRow.Cells[5].Value = cbAccountName.Text.Trim();
                nRow.Cells[6].Value = tbVoucherNo.Text.Trim();
                nRow.Cells[7].Value = tbNarration.Text.Trim();
                nRow.Cells[8].Value = AccType;
                nRow.Cells[9].Value = tbDebit.Text.Trim();
                nRow.Cells[10].Value = tbCredit.Text.Trim();
                nRow.Cells[11].Value = Balance;
                nRow.Cells[12].Value = SortId;
                nRow.Cells[13].Value = FinacialYear;
                TotalDebit += Convert.ToDecimal(tbDebit.Text.Trim());
                TotalCredit += Convert.ToDecimal(tbCredit.Text.Trim());
                lblTotalDebit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalDebit);
                lblTotalCredit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalCredit);
                BtnSave.Enabled = true;
                BtnDeleteRec.Enabled = true;
            }
            else
            {
                MessageBox.Show("Entry already made in the Journal.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAccId.Focus();
                cbAccountName.Text = String.Empty;
                return;
            }
        }

        // To Check if item already in the datagridview
        private DataGridViewCell GetItemExistsInGridView(string searchText, DataGridView dataGridView, int columnIndex)
        {
            DataGridViewCell cellWhereTextIsMet = null;
            // For every row in the grid (obviously)
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // I did not test this case, but cell.Value is an object, and objects can be null
                // So check if the cell is null before using .ToString()
                if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                {
                    // the searchText is equals to the text in this cell.
                    cellWhereTextIsMet = row.Cells[columnIndex];
                    break;
                }
            }
            return cellWhereTextIsMet;
        }

        private void cbAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand GetAccInfo = new SqlCommand();
            GetAccInfo.CommandType = CommandType.Text;
            GetAccInfo.CommandText = "select * from accounts where account_name = N'" + cbAccountName.Text + "'";
            GetAccInfo.Connection = accConn;
            accConn.Open();
            SqlDataReader dr = GetAccInfo.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    tbAccId.Text = dr.GetInt32(0).ToString();
                    lblAccHead.Text = dr.GetString(6);
                    AccType = dr.GetString(9);
                    Balance = dr.GetDecimal(8);
                    tbVoucherNo.Focus();
                }
            }
            accConn.Close();
        }

        private void tbCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
            MadeJournalGridEntry("CR");
            }
        }

        private void tbDebit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numeric
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TotalDebit == TotalCredit && DgvJournal.Rows.Count > 0)
            {
                foreach (DataGridViewRow sRow in DgvJournal.Rows)
                {
                    if (Convert.ToDecimal(sRow.Cells[9].Value) > 0)
                    {
                        GlobalVariableClass.DebitEntry(DateTime.Parse(sRow.Cells[0].Value.ToString()),
                                                       Convert.ToInt32(sRow.Cells[1].Value),
                                                       sRow.Cells[2].Value.ToString(),
                                                       sRow.Cells[3].Value.ToString(),
                                                       Convert.ToInt32(sRow.Cells[4].Value),
                                                       sRow.Cells[5].Value.ToString(),
                                                       sRow.Cells[6].Value.ToString(),
                                                       sRow.Cells[7].Value.ToString(),
                                                       sRow.Cells[8].Value.ToString(),
                                                       Convert.ToDecimal(sRow.Cells[9].Value),
                                                       Convert.ToDecimal(sRow.Cells[10].Value),
                                                       Convert.ToDecimal(sRow.Cells[11].Value),
                                                       Convert.ToInt32(sRow.Cells[12].Value),
                                                       sRow.Cells[13].Value.ToString());
                    }

                    if (Convert.ToDecimal(sRow.Cells[10].Value) > 0)
                    {
                        GlobalVariableClass.CreditEntry(DateTime.Parse(sRow.Cells[0].Value.ToString()),
                                                       Convert.ToInt32(sRow.Cells[1].Value),
                                                       sRow.Cells[2].Value.ToString(),
                                                       sRow.Cells[3].Value.ToString(),
                                                       Convert.ToInt32(sRow.Cells[4].Value),
                                                       sRow.Cells[5].Value.ToString(),
                                                       sRow.Cells[6].Value.ToString(),
                                                       sRow.Cells[7].Value.ToString(),
                                                       sRow.Cells[8].Value.ToString(),
                                                       Convert.ToDecimal(sRow.Cells[9].Value),
                                                       Convert.ToDecimal(sRow.Cells[10].Value),
                                                       Convert.ToDecimal(sRow.Cells[11].Value),
                                                       Convert.ToInt32(sRow.Cells[12].Value),
                                                       sRow.Cells[13].Value.ToString());
                    }
                }
            }
        }

        private void BtnDeleteRec_Click(object sender, EventArgs e)
        {
            GetRowValues();
            DeleteRows();
            SetNextTrans("Y");
        }

        private void DeleteRows()
        {
            if (DgvJournal.Rows.Count > 0)
            {
                for (int i = DgvJournal.Rows.Count - 1; i >= 0; i--)
                {
                    if (DgvJournal.Rows[i].Cells["Col2"].Value.ToString() == DelTran)
                    { DgvJournal.Rows.RemoveAt(i); }
                }
            }
            DelTran = String.Empty;
            cbAccountName.Focus();
        }

        private void GetRowValues()
        {
            if (DgvJournal.Rows.Count > 0)
            {
                Decimal DrAmount = 0, CrAmount = 0;
                ShowInputDialog(ref DelTran);
                foreach (DataGridViewRow GetRow in DgvJournal.Rows)
                {
                    if (GetRow.Cells[1].Value.ToString() == DelTran)
                    {
                        DrAmount += Convert.ToDecimal(GetRow.Cells[9].Value);
                        CrAmount += Convert.ToDecimal(GetRow.Cells[10].Value);
                    }
                }
                TotalDebit -= DrAmount;
                TotalCredit -= CrAmount;
                lblTotalDebit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalDebit);
                lblTotalCredit.Text = GlobalVariableClass.FormatCurrency("Rs.", TotalCredit);
            }
        }

        private void tbDebit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(tbVoucherNo.Text.Trim()) || String.IsNullOrEmpty(tbNarration.Text.Trim()) || String.IsNullOrEmpty(cbAccountName.Text.Trim()))
                { MessageBox.Show(this, "Fields should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { tbCredit.Text = "0"; MadeJournalGridEntry("DR"); SetNextTrans("DR"); }
            }
        }
        private void tbCredit_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(tbVoucherNo.Text.Trim()) || String.IsNullOrEmpty(tbNarration.Text.Trim()) || String.IsNullOrEmpty(cbAccountName.Text.Trim()))
                { MessageBox.Show(this, "Fields should'nt be blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { tbDebit.Text = "0";  MadeJournalGridEntry("CR"); SetNextTrans("DR"); }
            }
        }
        private void SetNextTrans(String TrType)
        {
            if (TrType == "DR")
            {
                tbDebit.Text = "0";
                lblAccHead.Text = string.Empty;
            }
            if (TrType == "CR")
            {
                tbCredit.Text = "0";
                lblAccHead.Text = string.Empty;
            }
            if (TotalDebit == TotalCredit)
            {
                if (DgvJournal.Rows.Count > 0)
                { lblTranId.Text = DgvJournal.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells["col2"].Value) + 1).ToString(); }
                else { lblTranId.Text = GlobalVariableClass.GenerateSeqID("ledg_tran_id", "ledgers").ToString(); }
                tbDebit.Text = "0";
                tbCredit.Text = "0";
                lblAccHead.Text = String.Empty;
                tbVoucherNo.Text = String.Empty;
                tbNarration.Text = String.Empty;
            }
            cbAccountName.Text = String.Empty;
            cbAccountName.Focus();
            tbAccId.Text = "0";
        }


        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(220, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.ControlBox = false;
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.Text = "Enter Trans # to Delete";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
    }
}
