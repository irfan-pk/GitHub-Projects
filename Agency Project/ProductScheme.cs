using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace WholeSaleApplication
{
    public partial class ProductScheme : Form
    {
        DateTimePicker oDateTimePicker;
        String DelCode = String.Empty;
        public ProductScheme()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClose;
        }

        private void SchemeSchedule_Load(object sender, EventArgs e)
        {
            SqlConnection SchConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
            SqlCommand SchCmd = new SqlCommand("select * from productscheme where prodSchid = '" + GlobalVariableClass.v_gblProductCode + "'", SchConn);
            SchCmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = SchCmd;
            using (SchConn)
            {
                SchConn.Open();
                SqlDataReader reader = SchCmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int gRowIndex = DgvScheme.Rows.Add();
                        DataGridViewRow NewRow = DgvScheme.Rows[gRowIndex];
                        NewRow.Cells[0].Value = reader[0].ToString();
                        NewRow.Cells[1].Value = reader[1].ToString();
                        NewRow.Cells[2].Value = reader[2].ToString();
                        NewRow.Cells[3].Value = reader[3].ToString();
                        NewRow.Cells[4].Value = reader[4].ToString();
                        NewRow.Cells[5].Value = "Delete";
                    }
                }
                else
                {
                    int gRowIndex = DgvScheme.Rows.Add();
                    DataGridViewRow NewRow = DgvScheme.Rows[gRowIndex];
                    NewRow.Cells[0].Value = GlobalVariableClass.GenerateSeqID("ProdSchSeq", "ProductScheme");
                    NewRow.Cells[1].Value = GlobalVariableClass .v_gblProductCode;
                    NewRow.Cells[2].Value = 0.00;
                    NewRow.Cells[3].Value = DateTime.Now.ToString("d");
                    NewRow.Cells[4].Value = DateTime.Now.ToString("d");
                }
            }
            DgvScheme.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            DgvScheme.Rows[DgvScheme.CurrentRow.Index].Cells[2].Selected = true;
            SchConn.Close();
        }

        private void DgvScheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                    try
                    {
                        DelCode = DgvScheme.Rows[DgvScheme.CurrentRow.Index].Cells[1].ToString();
                        SqlConnection delconn = new SqlConnection(GlobalVariableClass.gblConnectionString);
                        SqlCommand delcmd = new SqlCommand("delete from productscheme where prodschid = '" + DelCode + "'", delconn);
                        delcmd.CommandType = CommandType.Text;
                        delconn.Open();
                        delcmd.ExecuteNonQuery();
                        MessageBox.Show("Product scheme deleted succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        delconn.Close();
                    }
                    catch (Exception Err)
                    {
                        MessageBox.Show(Err.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
        }

        private void DgvScheme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                //Initialized a new DateTimePicker Control
                oDateTimePicker = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView 
                DgvScheme.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)
                oDateTimePicker.Format = DateTimePickerFormat.Short;

                // It returns the retangular area that represents the Display area for a cell
                Rectangle oRectangle = DgvScheme.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected
                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible
                oDateTimePicker.Visible = true;
            }
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell
            DgvScheme.CurrentCell.Value = oDateTimePicker.Text.ToString();
        }

        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use 
            oDateTimePicker.Visible = false;
        }

        private void Form1_FormClose(object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            
            // Assume that X has been clicked and act accordingly.
            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure to quit with saving (Yes/No) ?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
            //Close form without save
            case DialogResult.No:
                    e.Cancel = false;
                    break;
            //Close form with save changes
            case DialogResult.Yes:
                    SaveSchemeRecord();
                    e.Cancel = false;
                break;
            default:
                    break;
            }
        }

        private void SaveSchemeRecord()
        {
            try
            {
                foreach (DataGridViewRow gRow in this.DgvScheme.Rows)
                {
                    using (SqlConnection conn = new SqlConnection(GlobalVariableClass.gblConnectionString))
                    {
                        SqlCommand cmd = new SqlCommand();
                        //Check scheme exist or not
                        if (GlobalVariableClass.CheckRecrodExist("select * from ProductScheme where ProdSchSeq = " + gRow.Cells[0].Value) == false)
                        {
                            cmd.CommandText = "Insert into ProductScheme values(@Id,@Code,@Price,@Date1,@Date2)";
                        }
                        else
                        {
                            cmd.CommandText = "Update ProductScheme set ProdSchID = @Code, ProdSchPrice = @Price, ProdSchStartDate = @Date1, ProdSchEndDate = @Date2 where ProdSchSeq = " + gRow.Cells[0].Value;
                        }
                        cmd.Connection = conn;
                        //using (SqlCommand cmd = new SqlCommand("Insert into ProductScheme values(@Id,@Code,@Price,@Date1,@Date2)", conn))
                        //{
                        cmd.Parameters.AddWithValue("@Id", gRow.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@Code", gRow.Cells[1].Value);
                        cmd.Parameters.AddWithValue("@Price", gRow.Cells[2].Value);
                        cmd.Parameters.AddWithValue("@Date1", gRow.Cells[3].Value);
                        cmd.Parameters.AddWithValue("@Date2", gRow.Cells[4].Value);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return;
                        //}
                        //}
                    }
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void DgvScheme_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            DataGridViewElementStates state = e.StateChanged;
            //string msg = String.Format("Row {0}, Column {1}, {2}",
            //    e.Cell.RowIndex, e.Cell.ColumnIndex, e.StateChanged);
            //MessageBox.Show(msg, "Cell State Changed");
        }

        //private void ProductScheme_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //        DialogResult response = MessageBox.Show("Save Data before closing.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (response == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                foreach (DataGridViewRow gRow in DgvScheme.Rows)
        //                {
        //                    using (SqlConnection conn = new SqlConnection (GlobalVariableClass.gblConnectionString))
        //                    {
        //                        using (SqlCommand cmd = new SqlCommand ("Insert into ProductScheme values(@Id,@Code,@Price,@Date1,@Date2",conn))
        //                        {
        //                            cmd.Parameters.AddWithValue("@Id", gRow.Cells[0].Value);
        //                            cmd.Parameters.AddWithValue("@Code", gRow.Cells[1].Value);
        //                            cmd.Parameters.AddWithValue("@Price", gRow.Cells[2].Value);
        //                            cmd.Parameters.AddWithValue("@Date", gRow.Cells[3].Value);
        //                            cmd.Parameters.AddWithValue("@Date2", gRow.Cells[4].Value);
        //                            conn.Open();
        //                            cmd.ExecuteNonQuery();
        //                            conn.Close();
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception Err)
        //            {
        //                MessageBox.Show(Err.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                e.Cancel = false;
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            e.Cancel = false;
        //        }
        //}
    }
}
