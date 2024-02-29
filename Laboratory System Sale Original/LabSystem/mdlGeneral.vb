Imports System
Imports System.IO
Imports System.Drawing
Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports CrystalDecisions .CrystalReports 
Imports CrystalDecisions.Shared
Imports System.Net
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb

Module mdlGeneral

    Public ConnInfo As New CrystalDecisions.Shared.TableLogOnInfo
    Public crParameterFieldDefinitions As ParameterFieldDefinitions
    Public crParameterFieldDefinition As ParameterFieldDefinition
    Public crParameterValues As New ParameterValues
    Public crParameterDiscreteValue As New ParameterDiscreteValue
    Public SaveServerSettings As Boolean
    Public ServerName, ServerID, ServerPwd, ServerDatabase As String
    Public objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public objSubReport As CrystalDecisions.CrystalReports.Engine.SubreportObject
    Public gblTestCode, gblFind, gblCP, gblCP_ID, gblRefer, gblReportName, gblReportOption, gblCpName, gblBillReport, gblBillRptName, gblStatLink, gblQueryText As String
    Public gblDiscount As Long
    Public fromDate, toDate As Date
    Public ConnString, SqlConnString, UserStatus, UserName, UserPassword, SysOperator, DiscountBy, RptUser, gblAccType As String
    Public EntryDataAdpt As New SqlDataAdapter()
    Public EntryDataSet As New DataSet()
    Public myDataSet As New DataSet()
    Public Connection As New SqlConnection()
    Public strTCode, strTname, strCatg, strTrate, strRptLvl, OldTableYear, OldTablePatient, OldTableReceipt As String
    Public intTotal, intPaid, intDues, intOpnCr, intOpnDr, intD_Paid, intD_Dues, intD_Disc, intD_Recv As Double
    Public svDataSet As New DataSet()
    Public RcptDataSet As New DataSet()
    Public ReportDataSet As New DataSet()
    Public PwdDataAdapt As New SqlDataAdapter()
    Public SqlDataAdapt As New SqlDataAdapter()
    Public TransDataAdapt As New SqlDataAdapter()
    Public TransDataSet As New DataSet()
    Public SqlDataSet As New DataSet()
    Public LoginStatus As Boolean
    Public gblPrliviges, gblAccLink As Integer

    Public Sub ExecuteSqlQuery(ByVal Obj As SqlDataAdapter, ByVal ObjDataSet As DataSet, ByVal MyQuery As String, ByVal TableName As String, ByVal SqlConn As SqlConnection)

        '// OLD CONNECTION STRING ('SqlConn = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=LAB;NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;"))

        Call GetConnectionString()

        Try
            Obj.SelectCommand = New SqlCommand()
            Obj.SelectCommand.Connection = Connection
            If Connection.State = ConnectionState.Open Then Connection.Close()
            ObjDataSet.Clear()
            Connection.Open()
            Obj.SelectCommand.CommandText = MyQuery
            Obj.SelectCommand.CommandType = CommandType.Text
            Obj.Fill(ObjDataSet, TableName.Trim)
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Public Sub Execute_DatabaseTable_Query(ByVal Obj As SqlDataAdapter, ByVal UpdateQuery As String, ByVal SqlConn As SqlConnection)

        Call GetConnectionString()
        Try
            Obj.SelectCommand = New SqlCommand()
            Obj.SelectCommand.Connection = Connection
            If Connection.State = ConnectionState.Open Then Connection.Close()
            Obj.SelectCommand.CommandText = UpdateQuery
            Obj.SelectCommand.CommandType = CommandType.Text
            Connection.Open()
            Obj.SelectCommand.ExecuteNonQuery()
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    <Serializable()> Public Structure SoftwareSettings
        Dim ProgramName As String
        Dim ServerName As String
        Dim ServerUserId As String
        Dim ServerPassword As String
        Dim DataBaseName As String
    End Structure

    Public Sub GetServerFileSettings(ByVal RWOption As String)

        Dim StartApplication As New SoftwareSettings
        Dim BF As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim MS As New System.IO.MemoryStream()

        Dim path As String = Directory.GetCurrentDirectory()

        Try
            If RWOption = "READ" Then
                Dim bytes As Byte() = My.Computer.FileSystem.ReadAllBytes(path & "\" & "syslib.cfg")
                StartApplication = DirectCast(BF.Deserialize(New System.IO.MemoryStream(bytes)), SoftwareSettings)
                ServerDatabase = StrConv(StartApplication.DataBaseName.Trim, VbStrConv.Uppercase)
                ServerName = StrConv(StartApplication.ServerName.Trim, VbStrConv.Uppercase)
                ServerID = StrConv(StartApplication.ServerUserId.Trim, VbStrConv.Lowercase)
                ServerPwd = StrConv(StartApplication.ServerPassword.Trim, VbStrConv.Lowercase)

            End If

            If RWOption = "WRITE" Then
                StartApplication.DataBaseName = ServerDatabase.ToUpper.Trim
                StartApplication.ProgramName = "VISUAL BASIC 2008"
                StartApplication.ServerName = ServerName.Trim.ToUpper
                StartApplication.ServerUserId = ServerID.Trim.ToLower
                StartApplication.ServerPassword = ServerPwd.ToLower.Trim
                BF.Serialize(MS, StartApplication)
                My.Computer.FileSystem.WriteAllBytes(path & "\" & "syslib.cfg", MS.GetBuffer(), False)

            End If
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Public Function GenerateMax_ID(ByVal tblName As String, ByVal strField As String) As Integer

        Dim MaxID_Text As String = "SELECT MAX(" & strField & ") FROM " & tblName

        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=LAB;NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    GenerateMax_ID = 1
                Else
                    GenerateMax_ID = Convert.ToDecimal(Cmd.ExecuteScalar()) + 1
                End If
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return GenerateMax_ID
        End Using

    End Function

    Public Function Get_Account_ID(ByVal strAccName As String) As Integer

        Dim AccLnkID_Text As String = "SELECT ACC_LINK_CODE,ACC_LINK,ACC_TYPE FROM ACCOUNTS WHERE ACC_NAME = '" & strAccName.Trim.ToUpper & "'"
        Execute_DatabaseTable_Query(SqlDataAdapt, AccLnkID_Text, Connection)
        Dim Reader As SqlDataReader
        Reader = SqlDataAdapt.SelectCommand.ExecuteReader
        While Reader.Read
            gblAccLink = Convert.ToInt32(Reader.Item("ACC_LINK_CODE"))
            gblStatLink = Convert.ToString(Reader.Item("ACC_LINK"))
            gblAccType = Convert.ToString(Reader.Item("ACC_TYPE"))
        End While
        If Not Reader Is Nothing Then Reader.Close()

        Dim MaxID_Text As String = "SELECT ACC_NO FROM ACCOUNTS WHERE ACC_NAME = '" & strAccName & "'"

        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=LAB;NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                Get_Account_ID = Convert.ToDecimal(Cmd.ExecuteScalar())
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return Get_Account_ID
        End Using

    End Function

    Public Function IF_EXIST_(ByVal Query As String) As Boolean

        Using ObjConnection As New SqlConnection(SqlConnString)
            Dim IF_EXIST As New SqlCommand(Query, ObjConnection)
            Dim Result As Boolean
            Try
                ObjConnection.Open()
                Result = Convert.IsDBNull(IF_EXIST.ExecuteScalar)
                If Result = False Then
                    IF_EXIST_ = True
                Else
                    IF_EXIST_ = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End Using

    End Function

    Public Sub Print_Slips_Manually()

        Call GetConnectionString()

        Try
            Dim CommandText As String = ""
            SqlDataSet.Clear()

            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "LAB"

            If gblReportOption.ToUpper = "RECEIPT" Then
                CommandText = "Select * from PATIENT WHERE p_num = " & Val(gblFind.Trim)
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT", Connection)
            End If


            If gblReportOption.ToUpper = "OLDRECEIPT" Then
                CommandText = "Select * from " & OldTablePatient & " WHERE p_num = " & Val(gblFind.Trim)
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, OldTablePatient, Connection)
            End If

            If gblReportOption.ToUpper = "PCRRECEIPT" Then
                CommandText = "Select * from PATIENT_PCR WHERE p_num = " & Val(gblFind.Trim)
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT_PCR", Connection)
            End If

            If gblReportOption.ToUpper = "STRECEIPT" Then
                CommandText = "Select * from PATIENT_ST WHERE p_num = " & Val(gblFind.Trim)
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT_ST", Connection)
            End If

            ' Load Report in memory for View
            Try
                objReport.Load(gblReportName.Trim)
                'MsgBox(gblReportName)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try

            'Set logon information to reports for view
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next
            'Set the Datasource for reports
            If gblReportOption.ToUpper = "RECEIPT" Then objReport.SetDataSource(SqlDataSet.Tables("patient"))
            If gblReportOption.ToUpper = "OLDRECEIPT" Then objReport.SetDataSource(SqlDataSet.Tables(OldTablePatient))
            If gblReportOption.ToUpper = "PCRRECEIPT" Then objReport.SetDataSource(SqlDataSet.Tables("patient_pcr"))
            If gblReportOption.ToUpper = "STRECEIPT" Then objReport.SetDataSource(SqlDataSet.Tables("patient_st"))

            With objReport
                ' IF REPORT BELONGS TO PATIENT/LAB RECEIPT
                If gblReportOption.ToUpper = "RECEIPT" Then
                    .RecordSelectionFormula = "{patient.p_num}=" & Val(gblFind)
                    '' For sent Report directly to Printer
                    frmPrintDialog.Cursor = Cursors.WaitCursor
                    frmPrintDialog.Show()
                    objReport.PrintToPrinter(1, False, 0, 0)
                    '// For export report in pdf format if required uncommit the line
                    'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\Receipt.pdf")
                    frmPrintDialog.Cursor = Cursors.Default
                    frmPrintDialog.Close()
                End If
                If gblReportOption.ToUpper = "OLDRECEIPT" Then
                    .RecordSelectionFormula = "{patient.p_num}=" & Val(gblFind)
                    '' For sent Report directly to Printer
                    frmPrintDialog.Cursor = Cursors.WaitCursor
                    frmPrintDialog.Show()
                    objReport.PrintToPrinter(1, False, 0, 0)
                    '// For export report in pdf format if required uncommit the line
                    'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\OLDReceipt.pdf")
                    frmPrintDialog.Cursor = Cursors.Default
                    frmPrintDialog.Close()
                End If

                If gblReportOption.ToUpper = "PCRRECEIPT" Then
                    .RecordSelectionFormula = "{patient_pcr.p_num}=" & Val(gblFind)
                    '' For sent Report directly to Printer
                    frmPrintDialog.Cursor = Cursors.WaitCursor
                    objReport.PrintToPrinter(1, False, 0, 0)
                    '// For export report in pdf format if required uncommit the line
                    'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\PCRPatientSlip.pdf")
                    frmPrintDialog.Cursor = Cursors.Default
                    frmPrintDialog.Close()
                End If

                If gblReportOption.ToUpper = "STRECEIPT" Then
                    .RecordSelectionFormula = "{patient_st.p_num}=" & Val(gblFind)
                    '' For sent Report directly to Printer
                    frmPrintDialog.Cursor = Cursors.WaitCursor
                    objReport.PrintToPrinter(1, False, 0, 0)
                    '// For export report in pdf format if required uncommit the line
                    'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\STPatientSlip.pdf")
                    frmPrintDialog.Cursor = Cursors.Default
                    frmPrintDialog.Close()
                End If

            End With
            objReport.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Public Sub Record_Count()
        Call GetConnectionString()
        Try
            Dim TotCases As Integer
            Dim CountRdr As SqlDataReader
            Dim strCount As String = "SELECT COUNT(P_NUM) AS CNT_EXPR FROM PATIENT WHERE P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & " 00:00:00',102)"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strCount, "PATIENT", Connection)
            CountRdr = SqlDataAdapt.SelectCommand.ExecuteReader
            While CountRdr.Read
                TotCases = Val(CountRdr.Item("CNT_EXPR").ToString)
            End While
            If Not CountRdr Is Nothing Then CountRdr.Close()

            frmMain.ToolStripStatusLabel8.Text = TotCases.ToString
            SqlDataSet.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
        End Try

    End Sub

    Public Sub DisplayMessage(ByVal Msg As String)
        MsgBox(Msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, My.Application.Info.ProductName)
        Exit Sub
    End Sub

    Public Sub GetConnectionString()
        Connection = New SqlConnection("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=LAB;")
    End Sub

    Public Function CheckDatabaseExists(ByVal server As String, ByVal database As String) As Boolean

        Dim connString As String = ("Data Source=" + (server + ";Initial Catalog=master;Integrated Security=True;"))
        'Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";Initial Catalog=master;")

        Dim cmdText As String = _
           ("select * from master.dbo.sysdatabases where name='" + (database + "'"))

        Dim bRet As Boolean = False

        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using

        Return bRet

    End Function

    Public Function CheckTableExists(ByVal tblname As String) As Boolean

        Dim conn As New SqlConnection("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=LAB;")  'Creates a new connection object
        Dim cmd As New SqlCommand()      'Creates a new command object

        Dim exists As Byte = 0           'Creates a byte variable that will store the cmd return value

        cmd.CommandText = "SELECT COUNT(*) " & _
                           "FROM sys.objects " & _
                           "WHERE object_id = OBJECT_ID(N'[dbo].[" & tblname & "]') " & _
                           "AND type in (N'U')"

        Try
            conn.Open()                             'Opens the connection
            cmd.Connection = conn                   'Instructs the cmd object to use conn as its connection when executing
            exists = CByte(cmd.ExecuteScalar())     'Use ExecuteScalar to return a single value, the count, and assign it to the exists variable
            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)             'Catch any SqlException and display it in a MessageBox
        Catch ex As Exception
            MessageBox.Show(ex.Message)             'Catch any ApplicationException and display it in a MessageBox
        End Try

        Return CBool(exists)                               'Convert the exists variable to a boolean to determine whether the button should be enabled.

        'Note that by assigning the exists variable a value of 0 earlier, if there is an error in connecting to the database, the value will
        'remain 0, and the button will be disabled by default.  

    End Function

End Module
