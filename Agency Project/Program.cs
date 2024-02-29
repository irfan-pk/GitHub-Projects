using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WholeSaleApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool loadError = false; 
            SqlConnection MainConnection = new SqlConnection("Server=(local);DataBase=;Integrated Security=SSPI");
            try
            {
                MainConnection.Open();
                loadError = false;
                MainConnection.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.ToString(), "To run this, you must have SQL installed.  For instructions on installing SQL, view the documentation file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadError = true;
            }
            if (loadError == false)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
