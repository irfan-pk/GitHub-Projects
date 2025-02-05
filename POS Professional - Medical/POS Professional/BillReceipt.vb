Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class BillReceipt

    Dim TableName As String
    Dim Company, Address, Phone As String
    Dim InfoAdapter As New SqlDataAdapter()

    Private Sub BillReceipt_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Connection.Close()
        objReport.Close()
        SqlDataSet.Clear()
        CrystalReport.ReportSource = Nothing
    End Sub

    Private Sub BillReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Main
        Call GetConnectionString()
        CrystalReport.ReportSource = Nothing
        Try
            SqlDataSet.Clear()
            'Set Connection Information for PREVIEW the report
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase

            Dim CommandText As String = String.Empty
            TableName = "SALE_MASTER"
            CommandText = "SELECT * FROM SALE_MASTER where saleId = N'" & gblFind.Trim & "'"
            ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, TableName, Connection)

            Dim InfoQuery As String = "select * from info"
            ExecuteAdapterQuery(InfoAdapter, InfoQuery, Connection)
            Dim InfoReader As SqlDataReader = InfoAdapter.SelectCommand.ExecuteReader
            While InfoReader.Read
                Company = InfoReader.Item("reg_name").ToString
                Address = InfoReader.Item("reg_address").ToString
                Phone = InfoReader.Item("tel1").ToString
            End While

            ' Load Report in memory for View
            Try
                objReport.Load(gblReportName.Trim)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try
            'Set server and logon information to reports for preview
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next

            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables(TableName))

            'Set report source
            CrystalReport.ReportSource = objReport

            'Put values to Reports Parameter
            With objReport
                crParameterDiscreteValue.Value = Company.ToUpper.ToString
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("CompanyTitle")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                crParameterDiscreteValue.Value = Address.ToUpper.ToString
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("Address")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                crParameterDiscreteValue.Value = Phone.ToUpper.ToString
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("TelPhone")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            End With

            CrystalReport.ShowCloseButton = True
            CrystalReport.ShowGroupTreeButton = False
            Me.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub
End Class