using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POS_System
{

    public partial class Reports
    {
        private string TableName;

        public Reports()
        {
            InitializeComponent();
        }
        private void frmReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            mdlGeneral.Connection.Close();
            mdlGeneral.objReport.Close();
            mdlGeneral.SqlDataSet.Clear();
            CrystalReportViewer.ReportSource = null;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            MdiParent = My.MyProject.Forms.Main;
            mdlGeneral.GetConnectionString();
            CrystalReportViewer.ReportSource = null;
            // Try
            mdlGeneral.SqlDataSet.Clear();
            // Set Connection Information for PREVIEW the report
            mdlGeneral.ConnInfo.ConnectionInfo.UserID = mdlGeneral.ServerID;
            mdlGeneral.ConnInfo.ConnectionInfo.Password = mdlGeneral.ServerPwd;
            mdlGeneral.ConnInfo.ConnectionInfo.ServerName = mdlGeneral.ServerName;
            mdlGeneral.ConnInfo.ConnectionInfo.DatabaseName = "POSR";

            string CommandText = string.Empty;

            if (mdlGeneral.gblReportOption.ToUpper() == "DETAIL")
            {
                TableName = "CUSTOMERS";
                if (mdlGeneral.RptUser.ToUpper() == "ALL")
                    CommandText = "SELECT * FROM CUSTOMERS  ORDER BY CUST_CODE";
                if (mdlGeneral.RptUser.ToUpper() != "ALL")
                    CommandText = "SELECT * FROM CUSTOMERS WHERE CUST_CODE = " + Conversion.Val(mdlGeneral.RptUser.Trim()) + "ORDER BY CUST_CODE";
            }

            if (mdlGeneral.gblReportOption.ToUpper() == "LEDGER")
            {
                TableName = "CUSTOMERS_PAYM";
                if (mdlGeneral.RptUser.ToUpper() == "ALL")
                    CommandText = "SELECT * FROM CUSTOMERS_PAYM WHERE CUST_TR_DT >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) ORDER BY CUST_CODE";
                if (mdlGeneral.RptUser.ToUpper() != "ALL")
                    CommandText = "SELECT * FROM CUSTOMERS WHERE CUST_CODE = " + Conversion.Val(mdlGeneral.RptUser.Trim()) + " AND CUST_TR_DT >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) ORDER BY CUST_CODE";
            }

            if (mdlGeneral.gblReportOption.ToUpper() == "WDETAIL")
            {
                TableName = "SUPPLIERS";
                if (mdlGeneral.RptUser.ToUpper() == "ALL")
                    CommandText = "SELECT * FROM SUPPLIERS  ORDER BY SUPL_CODE";
                if (mdlGeneral.RptUser.ToUpper() != "ALL")
                    CommandText = "SELECT * FROM SUPPLIERS WHERE SUPL_CODE = " + Conversion.Val(mdlGeneral.RptUser.Trim()) + "ORDER BY SUPL_CODE";
            }

            if (mdlGeneral.gblReportOption.ToUpper() == "WLEDGER")
            {
                TableName = "SUPPLIERS_PAYM";
                if (mdlGeneral.RptUser.ToUpper() == "ALL")
                    CommandText = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) ORDER BY SUPL_CODE";
                if (mdlGeneral.RptUser.ToUpper() != "ALL")
                    CommandText = "SELECT * FROM SUPPLIERS WHERE SUPL_CODE = " + Conversion.Val(mdlGeneral.RptUser.Trim()) + " AND SUPL_TR_DT >= CONVERT(DATETIME,'" + Strings.Format(mdlGeneral.FromDate, "yyyy-MM-dd") + " 00:00:00',102) ORDER BY SUPL_CODE";
            }

            mdlGeneral.ExecuteDatasetQuery(mdlGeneral.SqlDataAdapter, mdlGeneral.SqlDataSet, CommandText, TableName, mdlGeneral.Connection);

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
            mdlGeneral.objReport.SetDataSource(mdlGeneral.SqlDataSet.Tables[TableName]);

            // With objReport
            // If gblReportOption = "SUMMARY" Or gblReportOption = "WHTSUMRY" Then

            // Dim FromPeriod, ToPeriod As String
            // ToPeriod = toDate
            // If (Month(fromDate) < 7) Then
            // FromPeriod = "01-07-" & Year(fromDate) - 1
            // Else
            // FromPeriod = "01-07-" & Year(fromDate)
            // End If

            // crParameterDiscreteValue.Value = Format(DateTime.Parse(FromPeriod.ToString), "MM-dd-yyyy")
            // 'crParameterDiscreteValue.Value = FromPeriod
            // crParameterFieldDefinitions = .DataDefinition.ParameterFields
            // crParameterFieldDefinition = crParameterFieldDefinitions.Item("FromDate")
            // crParameterValues = crParameterFieldDefinition.CurrentValues
            // crParameterValues.Add(crParameterDiscreteValue)
            // crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            // crParameterDiscreteValue.Value = Format(DateTime.Parse(ToPeriod.ToString), "MM-dd-yyyy")
            // 'crParameterDiscreteValue.Value = ToPeriod
            // crParameterFieldDefinitions = .DataDefinition.ParameterFields
            // crParameterFieldDefinition = crParameterFieldDefinitions.Item("ToDate")
            // crParameterValues = crParameterFieldDefinition.CurrentValues
            // crParameterValues.Add(crParameterDiscreteValue)
            // crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            // If gblEndTranDt.Trim = "" Then gblEndTranDt = "01/01/1999"

            // crParameterDiscreteValue.Value = Format(DateTime.Parse(gblEndTranDt.ToString), "dd-MMM-yyyy")
            // 'crParameterDiscreteValue.Value = ToPeriod
            // crParameterFieldDefinitions = .DataDefinition.ParameterFields
            // crParameterFieldDefinition = crParameterFieldDefinitions.Item("LastDate")
            // crParameterValues = crParameterFieldDefinition.CurrentValues
            // crParameterValues.Add(crParameterDiscreteValue)
            // crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            // End If

            // End With

            CrystalReportViewer.ShowCloseButton = true;
            CrystalReportViewer.ShowGroupTreeButton = false;
            WindowState = FormWindowState.Maximized;

            // Catch ex As Exception
            // MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            // End Try

        }

    }
}