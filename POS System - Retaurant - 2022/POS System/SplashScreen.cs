using System;
using System.IO;

namespace POS_System
{

    public sealed partial class SplashScreen
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        // TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
        // of the Project Designer ("Properties" under the "Project" menu).


        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Set up the dialog text at runtime according to the application's assembly information.  

            // TODO: Customize the application's assembly information in the "Application" pane of the project 
            // properties dialog (under the "Project" menu).

            // Application title
            if (!string.IsNullOrEmpty(My.MyProject.Application.Info.Title))
            {
                ApplicationTitle.Text = My.MyProject.Application.Info.Title;
            }
            else
            {
                // If the application title is missing, use the application name, without the extension
                ApplicationTitle.Text = Path.GetFileNameWithoutExtension(My.MyProject.Application.Info.AssemblyName);
            }

            // Format the version information using the text set into the Version control at design time as the
            // formatting string.  This allows for effective localization if desired.
            // Build and revision information could be included by using the following code and changing the 
            // Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
            // String.Format() in Help for more information.
            // 
            // Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

            Version.Text = string.Format(Version.Text, My.MyProject.Application.Info.Version.Major, My.MyProject.Application.Info.Version.Minor);

            // Copyright info
            Copyright.Text = My.MyProject.Application.Info.Copyright;
            string MyHostName = System.Net.Dns.GetHostName();

            mdlGeneral.GetConnectionString();
            if (File.Exists(@".\" + "poslib.cfg"))
            {
                mdlGeneral.GetServerFileSettings("READ");
            }
            else
            {
                My.MyProject.Forms.Server.Show();
            }

            if (mdlGeneral.CheckDatabaseExists(MyHostName, "POSR") == false)
            {
                My.MyProject.Forms.CreateDB.Show();
            }

            My.MyProject.Forms.LoginInput.Show();
            Close();

        }

    }
}