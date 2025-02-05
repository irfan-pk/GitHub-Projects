using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace POS_System
{

    public partial class SummaryReports
    {
        private string TableName;

        public SummaryReports()
        {
            InitializeComponent();
        }

        private void frmSummaryReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            mdlGeneral.Connection.Close();
            mdlGeneral.objReport.Close();
            mdlGeneral.SqlDataSet.Clear();
            CrystalReportViewer.ReportSource = null;
            WindowState = FormWindowState.Normal;
        }

        private void frmSummaryReports_Load(object sender, EventArgs e)
        {
            MdiParent = My.MyProject.Forms.Main;
            mdlGeneral.GetConnectionString();
            CrystalReportViewer.ReportSource = null;
            // Try
            mdlGeneral.SqlDataSet.Clear();
            // Set Connection Information for view the report
            mdlGeneral.ConnInfo.ConnectionInfo.UserID = mdlGeneral.ServerID;
            mdlGeneral.ConnInfo.ConnectionInfo.Password = mdlGeneral.ServerPwd;
            mdlGeneral.ConnInfo.ConnectionInfo.ServerName = mdlGeneral.ServerName;
            mdlGeneral.ConnInfo.ConnectionInfo.DatabaseName = "POSR";
            // Call to shift cash recovery records to temp table
            if (mdlGeneral.gblReportOption.ToUpper() == "STATEMENT")
                ShiftRec_for_SubReport();

            string CommandText = string.Empty;
            // Filter sql database queries to view required report
            if (mdlGeneral.gblReportFilter == "CASH")
                CommandText = "Select * from SALE_MASTER WHERE DateCompleted >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) AND DateCompleted <= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.ToDate, "yyyy-MM-dd") + " 00:00:00',102)"; // AND (SaleTotal > 0) AND (SalePaid > 0) OR (SaleReturn > 0)"

            if (mdlGeneral.gblReportFilter == "CREDIT")
                CommandText = "Select * from SALE_MASTER WHERE DateCompleted >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) AND DateCompleted <= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.ToDate, "yyyy-MM-dd") + " 00:00:00',102) AND (SaleTotal > 0)"; // AND (SaleCredit > 0)"

            if (mdlGeneral.gblReportFilter == "RECOVERY")
                CommandText = "Select * from SALE_MASTER WHERE DateRecovery >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) AND DateRecovery <= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.ToDate, "yyyy-MM-dd") + " 00:00:00',102) AND (SaleTotal > 0) AND (SaleRecovery > 0)";

            if (mdlGeneral.gblReportFilter == "RETURN")
                CommandText = "Select * from SALE_MASTER WHERE DateCompleted >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) AND DateCompleted <= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.ToDate, "yyyy-MM-dd") + " 00:00:00',102) AND (SaleReturn > 0)";

            mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, "SALE_MASTER", mdlGeneral.Connection);

            // Set report source
            CrystalReportViewer.ReportSource = mdlGeneral.objReport;
            // Load Report in memory for View
            try
            {
                mdlGeneral.objReport.Load(mdlGeneral.gblReportName.Trim());
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
                return;
            }
            // Set server and logon information to reports for preview
            for (int intCounter = 0, loopTo = mdlGeneral.objReport.Database.Tables.Count - 1; intCounter <= loopTo; intCounter++)
                mdlGeneral.objReport.Database.Tables[intCounter].ApplyLogOnInfo(mdlGeneral.ConnInfo);

            // Set the Datasource for reports
            mdlGeneral.objReport.SetDataSource(mdlGeneral.SqlDataSet.Tables["SALE_MASTER"]);

            {
                ref var withBlock = ref mdlGeneral.objReport;
                if (mdlGeneral.gblReportOption == "STATEMENT")
                {

                    mdlGeneral.crParameterDiscreteValue.Value = Strings.Format(DateTime.Parse(Conversions.ToString(mdlGeneral.FromDate)), "dd/MM/yyyy");
                    mdlGeneral.crParameterFieldDefinitions = withBlock.DataDefinition.ParameterFields;
                    mdlGeneral.crParameterFieldDefinition = mdlGeneral.crParameterFieldDefinitions["OnDate"];
                    mdlGeneral.crParameterValues = mdlGeneral.crParameterFieldDefinition.CurrentValues;
                    mdlGeneral.crParameterValues.Add(mdlGeneral.crParameterDiscreteValue);
                    mdlGeneral.crParameterFieldDefinition.ApplyCurrentValues(mdlGeneral.crParameterValues);

                    mdlGeneral.crParameterDiscreteValue.Value = Strings.Format(DateTime.Parse(Conversions.ToString(mdlGeneral.ToDate)), "dd/MM/yyyy");
                    mdlGeneral.crParameterFieldDefinitions = withBlock.DataDefinition.ParameterFields;
                    mdlGeneral.crParameterFieldDefinition = mdlGeneral.crParameterFieldDefinitions["ToDate"];
                    mdlGeneral.crParameterValues = mdlGeneral.crParameterFieldDefinition.CurrentValues;
                    mdlGeneral.crParameterValues.Add(mdlGeneral.crParameterDiscreteValue);
                    mdlGeneral.crParameterFieldDefinition.ApplyCurrentValues(mdlGeneral.crParameterValues);
                }
            }

            CrystalReportViewer.ShowCloseButton = false;
            CrystalReportViewer.ShowGroupTreeButton = false;
            WindowState = FormWindowState.Maximized;

            // Catch ex As Exception
            // MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            // End Try

        }

        private void ShiftRec_for_SubReport()
        {
            try
            {
                string CommandText = "DELETE FROM SALE_MASTER_TEMP";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CommandText, mdlGeneral.Connection);
                mdlGeneral.Connection.Close();
                CommandText = "INSERT INTO SALE_MASTER_TEMP SELECT * FROM SALE_MASTER WHERE SALE_MASTER.DateRecovery >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) AND SALE_MASTER.DateRecovery <= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.ToDate, "yyyy-MM-dd") + " 00:00:00',102) AND (SaleRecovery > 0)";
                mdlGeneral.ExecuteAdapterQuery(mdlGeneral.SqlDataAdapter, CommandText, mdlGeneral.Connection);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, My.MyProject.Application.Info.ProductName);
            }
        }

    }
}