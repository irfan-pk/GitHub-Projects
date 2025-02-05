using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class Journal
    {
        private string cmdText, Clos_Balance;
        private int Max_ID, Max_Transaction;
        private DataGridViewCellStyle objCellStyle = new DataGridViewCellStyle();
        private bool Addition, Editing, RollBack;
        private bool drag;
        private int mousex;
        private int mousey;

        public Journal()
        {
            InitializeComponent();
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            cmdMin.Left = Width - (cmdMin.Width + 5);
            mdlGeneral.GetConnectionString();
            Popup_Data();
            mdlGeneral.Connection.Close();
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

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
            My.MyProject.Forms.Wholesalers.WindowState = FormWindowState.Normal;
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Get_New_Record()
        {
            txtDescription.Clear();
            txtDebit.Text = "00";
            txtCredit.Text = "00";
            txtID.Clear();
            txtName.Clear();
            txtID.Focus();
        }

        private void txtDebit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Conversion.Val(txtDebit.Text.Trim()) > 0d)
                    Updt_General_Journal("DEBIT");
            }
        }

        private void txtDebit_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtDebit, txtDebit);
        }

        private void txtCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Conversion.Val(txtDebit.Text.Trim()) > 0d)
                    Updt_General_Journal("CREDIT");
            }
        }

        private void txtCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            mdlGeneral.ValidateNumericKeyPress(sender, e, txtCredit, txtCredit);
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Strings.Len(txtID.Text) > 0)
                    mdlGeneral.gblCP_ID = txtID.Text.Trim();
                string CommandText = "SELECT * FROM SUPPLIERS WHERE SUPL_CODE = N'" + Conversion.Val(mdlGeneral.gblCP_ID) + "'";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CommandText, mdlGeneral.Connection);
                var GetName = mdlGeneral.SqlDataAdapter.SelectCommand.ExecuteReader();
                if (GetName.HasRows)
                {
                    while (GetName.Read())
                        txtName.Text = Conversions.ToString(GetName["SUPL_NAME"]);
                    if (GetName is null)
                        GetName.Close();
                    Popup_Data();
                    txtDescription.Focus();
                }
                else
                {
                    Interaction.MsgBox("Please give valid ID.", MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                }
            }
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                My.MyProject.Forms.SuplCode.ShowDialog(this);
                if (Conversion.Val(mdlGeneral.gblCP_ID) > 0d)
                    txtID.Text = mdlGeneral.gblCP_ID;
                txtID_KeyDown(sender, e);
            }
        }

        private void Popup_Data()
        {
            try
            {
                Max_Transaction = mdlGeneral.GenerateMax_ID("SUPPLIERS_PAYM", "SUPL_TR_ID");
                txtTran.Text = Max_Transaction.ToString().Trim();
                PaymentDataSet.Clear();
                string CommandText = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_CODE = N'" + Conversion.Val(mdlGeneral.gblCP_ID) + "' ORDER BY SUPL_TR_ID";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CommandText, mdlGeneral.Connection);
                mdlGeneral.SqlDataAdapter.Fill(PaymentDataSet, "SUPPLIERS_PAYM");
                PayBindingSource.DataSource = PaymentDataSet;
                PayBindingSource.DataMember = "SUPPLIERS_PAYM";
                objCellStyle.BackColor = Color.WhiteSmoke;
                PaymentDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                Close();
            }
        }

        private void Updt_General_Journal(string PayType)
        {
            // Function to debit/credit payments
            string connString = "Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" + mdlGeneral.ServerPwd + ";Data Source=" + mdlGeneral.ServerName + ";DATABASE=POSR;";
            double Supplier_Code, Opn_Bal, Clo_Bal, Amount;
            Supplier_Code = 0d;
            Opn_Bal = 0d;
            Clo_Bal = 0d;
            Amount = 0d;
            string Get_Supplier = "select * from suppliers where supl_code = N'" + Conversion.Val(txtID.Text.Trim()) + "'";
            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.Suppliers, Get_Supplier, mdlGeneral.Connection);
            var SuppliersReader = mdlGeneral.Suppliers.SelectCommand.ExecuteReader();
            if (SuppliersReader.HasRows)
            {
                while (SuppliersReader.Read())
                {
                    Supplier_Code = Conversions.ToDouble(SuppliersReader["SUPL_CODE"].ToString().Trim());
                    Opn_Bal = Conversion.Val(SuppliersReader["SUPL_BALANCE"].ToString().Trim());
                }
                if (SuppliersReader is null)
                    SuppliersReader.Close();
            }
            // Query for debit or credit entry
            if (PayType.ToUpper().Trim() == "DEBIT")
            {
                Amount = Conversion.Val(txtDebit.Text.Trim());
                Clo_Bal = Opn_Bal - Conversion.Val(txtDebit.Text.Trim());
                cmdText = "INSERT INTO SUPPLIERS_PAYM VALUES ('" + Supplier_Code + "','" + Strings.Format(DateTime.Parse(TranDate.Value.ToString()), "MM/dd/yyyy") + "','" + Conversion.Val(txtTran.Text.Trim()) + "','" + txtName.Text.Trim() + "','" + txtDescription.Text.Trim() + "'," + Opn_Bal + "," + Conversion.Val(txtDebit.Text.Trim()) + ",0," + Clo_Bal + ",'" + Strings.Format(DateTime.Parse(TranDate.Value.ToString()), "MM/dd/yyyy") + "')";
            }
            if (PayType.ToUpper().Trim() == "CREDIT")
            {
                Amount = Conversion.Val(txtCredit.Text.Trim());
                Clo_Bal = Opn_Bal + Conversion.Val(txtCredit.Text.Trim());
                cmdText = "INSERT INTO SUPPLIERS_PAYM VALUES ('" + Supplier_Code + "','" + Strings.Format(DateTime.Parse(TranDate.Value.ToString()), "MM/dd/yyyy") + "','" + Conversion.Val(txtTran.Text.Trim()) + "','" + txtName.Text.Trim().ToUpper() + "','" + Strings.StrConv(txtDescription.Text.Trim(), VbStrConv.ProperCase) + "'," + Opn_Bal + ",0," + Conversion.Val(txtCredit.Text.Trim()) + "," + Clo_Bal + ",'" + Strings.Format(DateTime.Parse(TranDate.Value.ToString()), "MM/dd/yyyy") + "')";
            }
            // For update general journal
            using (var sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    try
                    {
                        sqlCmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message, MsgBoxStyle.Information);
                    }
                }
            }
            // For update supplier closing balance
            Clos_Balance = "UPDATE SUPPLIERS SET SUPL_BALANCE = SUPL_BALANCE - " + Amount + ", SUPL_UPD_DT = N'" + Strings.Format(DateTime.Parse(TranDate.Value.ToString()), "MM/dd/yyyy") + "' " + "WHERE SUPL_CODE = N'" + Conversion.Val(txtID.Text.Trim()) + "'";


            mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, Clos_Balance, mdlGeneral.Connection);
            Popup_Data();
            Get_New_Record();
            mdlGeneral.Connection.Close();
        }

        private void txtCredit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (Conversion.Val(txtCredit.Text.Trim()) > 0d)
                    Updt_General_Journal("CREDIT");
            }
        }

        private void txtDebit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (Conversion.Val(txtDebit.Text.Trim()) > 0d)
                    Updt_General_Journal("DEBIT");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.SuplCode.ShowDialog(this);
            if (Conversion.Val(mdlGeneral.gblCP_ID) > 0d)
                txtID.Text = mdlGeneral.gblCP_ID;
        }
    }
}