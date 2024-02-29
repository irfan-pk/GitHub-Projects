using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    public partial class CompanyInfo : Form
    {
        String QueryString = String.Empty, EditString = String.Empty;
        SqlConnection gConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        SqlConnection uConn = new SqlConnection(GlobalVariableClass.gblConnectionString);
        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand gCmd = new SqlCommand();
            SqlCommand CompanyInfo = new SqlCommand();
            CompanyInfo.CommandType = CommandType.Text;
            gCmd.CommandType = CommandType.Text;
            gCmd.CommandText = "select * from companyinfo";
            gCmd.Connection = gConn;
            if (gConn.State == ConnectionState.Open ) { gConn.Close(); }
            gConn.Open();
            SqlDataReader dr = gCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                // Update Company Information
                QueryString = "Update CompanyInfo set " +
                              "CompanyName = '" + TbName.Text.Trim() + "'," +
                              "Address = '" + TbAddr1.Text.Trim() + "'," +
                              "Address2 = '" + TbAddr2.Text.Trim() + "'," +
                              "CompanyUrdu = N'" + TbNameUr.Text.Trim() + "'," +
                              "AddressUrdu = N'" + TbAddr1Ur.Text.Trim() + "'," +
                              "AddressUrdu2 = N'" + TbAddr2Ur.Text.Trim() + "'," +
                              "City = '" + TbCity.Text.Trim() + "'," +
                              "ZipCode = '" + TbZip.Text.Trim() + "'," +
                              "Province = '" + TbState.Text.Trim() + "'," +
                              "PinCode = '" + TbPin.Text.Trim() + "'," +
                              "MobileNo = '" + TbMobile.Text.Trim() + "'," +
                              "LandLine = '" + TbLandLine.Text.Trim() + "'," +
                              "Email = '" + TbEmail.Text.Trim() + "'," +
                              "GSTNo = '" + TbGST.Text.Trim() + "'," +
                              "CNIC = '" + TbCNIC.Text.Trim() + "'," +
                              "DealsIn = '" + TbDeals.Text.Trim() + "' " +
                              "Where CompanyName = '" + EditString + "'";
            }
            else
            {
                // Add Company Information
                QueryString = "Insert Into CompanyInfo values ('" +
                              TbName.Text.Trim() + "','" +
                              TbAddr1.Text.Trim() + "','" +
                              TbAddr2.Text.Trim() + "',N'" +
                              TbNameUr.Text.Trim() + "',N'" +
                              TbAddr1Ur.Text.Trim() + "',N'" +
                              TbAddr2Ur.Text.Trim() + "','" +
                              TbCity.Text.Trim() + "','" +
                              TbZip.Text.Trim() + "','" +
                              TbState.Text.Trim() + "','" +
                              TbPin.Text.Trim() + "','" +
                              TbMobile.Text.Trim() + "','" +
                              TbLandLine.Text.Trim() + "','" +
                              TbEmail.Text.Trim() + "','" +
                              TbGST.Text.Trim() + "','" +
                              TbCNIC.Text.Trim() + "','" +
                              TbDeals.Text.Trim() + "')";
            }
            CompanyInfo.CommandType = CommandType.Text;
            CompanyInfo.CommandText = QueryString;
            CompanyInfo.Connection = uConn;
            uConn.Open();
            int i = CompanyInfo.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Product Saved / Updated Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            uConn.Close();
            gConn.Close();
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            SqlCommand getInfo = new SqlCommand();
            getInfo.CommandType = CommandType.Text;
            getInfo.CommandText = "select * from companyinfo";
            getInfo.Connection = gConn;
            gConn.Open();
            SqlDataReader dr = getInfo.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read ())
                {
                    TbName.Text = dr.GetString(0);
                    TbAddr1.Text = dr.GetString(1);
                    TbAddr2.Text = dr.GetString(2);
                    TbNameUr.Text = dr.GetString(3);
                    TbAddr1Ur.Text = dr.GetString(4);
                    TbAddr2Ur.Text = dr.GetString(5);
                    TbCity.Text = dr.GetString(6);
                    TbZip.Text = dr.GetString(7);
                    TbState.Text = dr.GetString(8);
                    TbPin.Text = dr.GetString(9);
                    TbMobile.Text = dr.GetString(10);
                    TbLandLine.Text = dr.GetString(11);
                    TbEmail.Text = dr.GetString(12);
                    TbGST.Text = dr.GetString(13);
                    TbCNIC.Text = dr.GetString(14);
                    TbDeals.Text = dr.GetString(15);
                }
                gConn.Close();
            }
            EditString = TbName.Text.Trim();
        }
    }
}
