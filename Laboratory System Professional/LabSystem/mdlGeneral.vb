Imports System
Imports System.IO
Imports System.Drawing
Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared
Imports System.Net
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Module mdlGeneral

    Public ConnInfo As New CrystalDecisions.Shared.TableLogOnInfo
    Public crParameterFieldDefinitions As ParameterFieldDefinitions
    Public crParameterFieldDefinition As ParameterFieldDefinition
    Public crParameterValues As New ParameterValues
    Public crParameterDiscreteValue As New ParameterDiscreteValue
    Public OpnCr, OpnDr, Ledg_BF, New_Balance, Final_Cr, Final_Dr As Double
    Public SaveServerSettings, SetQuery, ReportStatus As Boolean
    Public ServerName, ServerID, ServerPwd, ServerDatabase As String
    Public objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public objSubReport As CrystalDecisions.CrystalReports.Engine.SubreportObject
    Public gblTestCode, gblTestName, gblSubCode, gblFind, gblCP, gblCP_ID, gblRefer, gblReportName, gblReportOption, gblCpName, gblBillReport, gblBillRptName, gblStatLink, gblQueryText, gblFileCode, DiscountBy, RptUser, gblAccType, gblInput, gblAccHead, gblAccID, gblAccName, gblCategory, gblBarcodeRpt, gblStoneSize, gblDatabasePath As String
    Public gblDiscount, gblDueAmount, gblLimit As Long
    Public fromDate, toDate As Date
    Public ConnString, SqlConnString, UserStatus, UserName, gblMessage, gblRmkCode, UserPassword, SysOperator, gblPrliviges, gblSection, gblFormName, gblSelectRpt, gblPrnReport, gblRptRmkCode, gblRptRmkDetail, gblTotCases, gblDefaultPrinter, Ledg_Balance, DrCr_Type, fOpen, fClose As String
    Public EntryDataAdapter As New SqlDataAdapter()
    Public EntryDataSet As New DataSet()
    Public myDataSet As New DataSet()
    Public AccDataSet As New DataSet()
    Public AccAdapter As New SqlDataAdapter()
    Public Connection As New SqlConnection()
    Public strTCode, strTname, strCatg, strTrate, strRptLvl, gblRptTstCode, gblRptSubCode, gblRmkCategory, gblTableName, gblReportQuery, gblSelectFormula, gblPayDate As String
    Public intTotal, intPaid, intDues, intOpnCr, intOpnDr, intD_Paid, intD_Dues, intD_Disc, intD_Recv, gblPrevBal, gblPrevDebit, gblPrevCredit As Double
    Public svDataSet As New DataSet()
    Public RcptDataSet As New DataSet()
    Public ReportDataSet As New DataSet()
    Public PwdDataAdapter As New SqlDataAdapter()
    Public SqlDataAdapter As New SqlDataAdapter()
    Public TransDataAdapter As New SqlDataAdapter()
    Public TransDataSet As New DataSet()
    Public LedgerDataAdapter As New SqlDataAdapter()
    Public LedgerDataSet As New DataSet()
    Public SqlDataSet As New DataSet()
    Public LoginStatus As Boolean
    Public FinancialYear, DailyVoucher As String
    Public ReportAdapter As New SqlDataAdapter()
    Public PendingAdapter As New SqlDataAdapter()
    Public SelectAdapter As New SqlDataAdapter()
    Public PatientGroupAdapter As New SqlDataAdapter()
    Public PatientTestAdapter As New SqlDataAdapter()
    Public PaySqlAdapter As New SqlDataAdapter()
    Public Fyear_Date As Date
    Public MyForm As New Form
    Public FirstLogin As Boolean = False
    Public gblGross, gblMicroscope, gblTissue, gblConclusion, gblEmpName, gblSalaryAdd, gblSalaryEdit, gblEmpID, gblPayrolMonth As String
    Public gblPrintLabId, gblPrintFileName, gblPrintReportCode As String

    Public Sub ExecuteSqlQuery(ByVal Obj As SqlDataAdapter, ByVal ObjDataSet As DataSet, ByVal MyQuery As String, ByVal TableName As String, ByVal SqlConn As SqlConnection)
        Call GetConnectionString()
        'Try
        Obj.SelectCommand = New SqlCommand()
        Obj.SelectCommand.Connection = Connection
        Obj.SelectCommand.CommandTimeout = 0
        Obj.SelectCommand.CommandType = CommandType.Text
        If Connection.State = ConnectionState.Open Then Connection.Close()
        ObjDataSet.Clear()
        Connection.Open()
        Obj.SelectCommand.CommandText = MyQuery
        Obj.SelectCommand.CommandType = CommandType.Text
        Obj.Fill(ObjDataSet, TableName.Trim)
        'Catch EX As SqlException
        '    MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try

    End Sub

    Public Sub Execute_DatabaseTable_Query(ByVal Obj As SqlDataAdapter, ByVal UpdateQuery As String, ByVal SqlConn As SqlConnection)

        Call GetConnectionString()
        Try
            Obj.SelectCommand = New SqlCommand()
            Obj.SelectCommand.Connection = Connection
            Obj.SelectCommand.CommandTimeout = 0
            Obj.SelectCommand.CommandType = CommandType.Text
            If Connection.State = ConnectionState.Open Then Connection.Close()
            Obj.SelectCommand.CommandText = UpdateQuery
            Obj.SelectCommand.CommandType = CommandType.Text
            Connection.Open()
            Obj.SelectCommand.ExecuteNonQuery()
        Catch EX As SqlException
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
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                If IsDBNull(Cmd.ExecuteScalar()) Then
                    GenerateMax_ID = 1
                Else
                    GenerateMax_ID = Convert.ToDecimal(Cmd.ExecuteScalar()) + 1
                End If
                Conn.Close()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return GenerateMax_ID
        End Using

    End Function

    Public Function Get_Account_ID(ByVal strAccName As String) As Integer

        Dim AccLnkID_Text As String = "SELECT ACC_HEAD,ACC_TYPE FROM ACCOUNTS WHERE ACC_NAME = '" & strAccName.Trim.ToUpper & "'"
        Execute_DatabaseTable_Query(SqlDataAdapter, AccLnkID_Text, Connection)
        Dim Reader As SqlDataReader
        Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Reader.Read
            gblAccHead = Convert.ToString(Reader.Item("ACC_HEAD"))
            gblAccType = Convert.ToString(Reader.Item("ACC_TYPE"))
        End While
        If Not Reader Is Nothing Then Reader.Close()

        Dim MaxID_Text As String = "SELECT ACC_NO FROM ACCOUNTS WHERE ACC_NAME = '" & strAccName & "'"

        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                Get_Account_ID = Convert.ToDecimal(Cmd.ExecuteScalar())
                Conn.Close()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return Get_Account_ID
        End Using

    End Function

    Public Function Get_P_Account_ID(ByVal strAccName As String) As Integer

        Dim AccLnkID_Text As String = "SELECT P_ACC_HEAD,P_ACC_TYPE FROM PETTY_ACCOUNTS WHERE P_ACC_NAME = '" & strAccName.Trim.ToUpper & "'"
        Execute_DatabaseTable_Query(SqlDataAdapter, AccLnkID_Text, Connection)
        Dim Reader As SqlDataReader
        Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Reader.Read
            gblAccHead = Convert.ToString(Reader.Item("P_ACC_HEAD"))
            gblAccType = Convert.ToString(Reader.Item("P_ACC_TYPE"))
        End While
        If Not Reader Is Nothing Then Reader.Close()

        Dim MaxID_Text As String = "SELECT P_ACC_NO FROM PETTY_ACCOUNTS WHERE P_ACC_NAME = '" & strAccName & "'"

        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(MaxID_Text, Conn)
            Try
                Conn.Open()
                Get_P_Account_ID = Convert.ToDecimal(Cmd.ExecuteScalar())
                Conn.Close()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Return Get_P_Account_ID
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
            ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase

            If gblReportOption.ToUpper = "RECEIPT" Then CommandText = "Select * from PATIENT WHERE p_num = " & Val(gblFind.Trim)

            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "PATIENT", Connection)

            ' Load Report in memory for View
            Try
                objReport.Load(gblReportName.Trim)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try

            'Set logon information to reports for view
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next
            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables("patient"))

            With objReport
                ' IF REPORT BELONGS TO PATIENT/LAB RECEIPT
                If gblReportOption.ToUpper = "RECEIPT" Then
                    .RecordSelectionFormula = "{patient.p_num}=" & Val(gblFind)
                    '' For sent Report directly to Printer
                    PrintDialog.ShowDialog()
                    objReport.PrintToPrinter(1, False, 0, 0)
                    '// For export report in pdf format if required uncommit the line
                    'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\Receipt.pdf")
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
            Dim CountRdr As SqlDataReader
            Dim strCount As String = "SELECT COUNT(P_NUM) AS CNT_EXPR, SUM(P_PAID) AS P_EXPR, SUM(P_DISCOUNT) AS D_EXPR, SUM(P_DUES) AS R_EXPR FROM PATIENT WHERE P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & " 00:00:00',102)"
            Execute_DatabaseTable_Query(SqlDataAdapter, strCount, Connection)
            CountRdr = SqlDataAdapter.SelectCommand.ExecuteReader
            While CountRdr.Read
                gblTotCases = Val(CountRdr.Item("CNT_EXPR").ToString)
            End While
            If Not CountRdr Is Nothing Then CountRdr.Close()
            SqlDataAdapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
        End Try
    End Sub

    Public Sub DisplayMessage(ByVal Msg As String)
        MsgBox(Msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, My.Application.Info.ProductName)
        Exit Sub
    End Sub

    Public Sub GetConnectionString()
        Connection = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
    End Sub

    Public Function CheckDatabaseExists(ByVal server As String, ByVal database As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";")
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
            sqlConnection.Close()
        End Using
        Return bRet
    End Function

    Public Function CheckTableExists(ByVal tblname As String) As Boolean

        Dim conn As New SqlConnection("Data Source=" & ServerName & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";")  'Creates a new connection object
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

    Public Sub Load_MyForm(ByVal MDI_Form As Form, ByVal Child_Form As Form)
        Child_Form.MdiParent = MDI_Form
        Child_Form.Show()
    End Sub

    Public Sub FinalizeReport(ByRef MyGridData As DataGridView, ByVal PatientID As Integer, ByVal PatientName As String)
        Dim CheckRecord As String = String.Empty
        Dim CheckReport As String = String.Empty
        Call GetConnectionString()
        Dim RmkBit As Integer = 0
        If gblRptRmkDetail <> String.Empty Then RmkBit = 1
        MyGridData.EndEdit()
        MyGridData.Rows(0).Cells(0).Selected = True
        gblPrnReport = MyGridData.Rows(0).Cells(4).Value.ToString
        For j = 0 To MyGridData.RowCount - 1
            CheckReport = "select * from rpt_result where LABNO = " & PatientID & " AND PARAMETERS = '" & MyGridData.Rows(j).Cells(0).Value.ToString & "' AND RPTCODE = N'" & MyGridData.Rows(j).Cells(5).Value.ToString & "'"
            Execute_DatabaseTable_Query(SqlDataAdapter, CheckReport, Connection)
            Dim Checker As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Checker.HasRows = True Then
                If MyGridData.Rows(j).Cells(3).Value.ToString.IndexOf("MALARIA") > -1 Then
                    Dim UpdtQuery As String = "UPDATE RPT_RESULT SET RESULT = '" & StrConv(MyGridData.Rows(j).Cells(1).Value.ToString, VbStrConv.Uppercase) & "', NORM_VAL = N'" & MyGridData.Rows(j).Cells(3).Value.ToString & "', PSTATUS = 0, NAME = '" & PatientName & "' " & _
                                              "WHERE LABNO = " & PatientID & " AND PARAMETERS = '" & MyGridData.Rows(j).Cells(0).Value.ToString & "' AND RPTCODE = '" & MyGridData.Rows(j).Cells(5).Value.ToString & "'"
                    ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, UpdtQuery, "RPT_RESULT", Connection)
                Else
                    Dim UpdtQuery As String = "UPDATE RPT_RESULT SET RESULT = '" & StrConv(MyGridData.Rows(j).Cells(1).Value.ToString, VbStrConv.Uppercase) & "', PSTATUS = 0, NAME = '" & PatientName & "' " & _
                                              "WHERE LABNO = " & PatientID & " AND PARAMETERS = '" & MyGridData.Rows(j).Cells(0).Value.ToString & "' AND RPTCODE = '" & MyGridData.Rows(j).Cells(5).Value.ToString & "'"
                    ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, UpdtQuery, "RPT_RESULT", Connection)
                End If
            Else
                Dim UpdtQuery As String = "INSERT INTO RPT_RESULT VALUES('" & PatientID & "','" & _
                                          MyGridData.Rows(j).Cells(0).Value.ToString & "','" & _
                                          StrConv(MyGridData.Rows(j).Cells(1).Value.ToString, VbStrConv.Uppercase) & "','" & _
                                          MyGridData.Rows(j).Cells(2).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(3).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(4).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(5).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(6).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(7).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(8).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(9).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(10).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(11).Value.ToString & "','" & _
                                          MyGridData.Rows(j).Cells(12).Value.ToString & "',0,'" & Format(Now.Date, "MM/dd/yyyy") & "','" & PatientName & "')"
                ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, UpdtQuery, "RPT_RESULT", Connection)
            End If
        Next
        If Len(gblRptRmkDetail) = 0 Then
            Dim DelRemarks As String = "delete from rpt_result_remarks WHERE (LABID = " & PatientID & " AND RPTCODE = '" & MyGridData.Rows(0).Cells(5).Value.ToString & "')"
            Execute_DatabaseTable_Query(ReportAdapter, DelRemarks, Connection)
        End If
        If Len(gblRptRmkDetail) > 0 Then
            CheckRecord = "select * from rpt_result_remarks where (labid = " & PatientID & ") and (rptcode = '" & MyGridData.Rows(0).Cells(5).Value.ToString & "')"
            Execute_DatabaseTable_Query(SqlDataAdapter, CheckRecord, Connection)
            Dim MyReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If MyReader.HasRows = True Then
                Dim AddRemarks As String = "update rpt_result_remarks set LABID = " & PatientID & ", RPTCODE = '" & MyGridData.Rows(0).Cells(5).Value.ToString & "', RMKCD = '" & gblRptRmkCode & "', RMKS = '" & gblRptRmkDetail & "', CATEGORY = '" & gblRmkCategory & "' WHERE (LABID = " & PatientID & " AND RPTCODE = '" & MyGridData.Rows(0).Cells(5).Value.ToString & "')"
                Execute_DatabaseTable_Query(ReportAdapter, AddRemarks, Connection)
            Else
                Dim AddRemarks As String = "insert into rpt_result_remarks values(" & PatientID & ",'" & MyGridData.Rows(0).Cells(5).Value.ToString & "','" & gblRptRmkCode & "','" & gblRptRmkDetail & "','" & MyGridData.Rows(0).Cells(6).Value.ToString & "')"
                Execute_DatabaseTable_Query(ReportAdapter, AddRemarks, Connection)
            End If
        End If
        'For Report Viewer
        Dim CurrentPath As String = Directory.GetCurrentDirectory()
        gblPrintLabId = PatientID
        'gblPrintFileName = CurrentPath & "\Pathology\" & MyGridData.Rows(0).Cells(4).Value.ToString.Trim
        gblPrintFileName = CurrentPath & "\Pathology\" & gblPrnReport
        gblPrintReportCode = MyGridData.Rows(0).Cells(5).Value.ToString
        Connection.Close()
    End Sub

    Public Function CheckReportExist(ByVal PatientID As String, ByVal ReportCode As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from lab_pro.dbo.rpt_result where labno=" & Val(PatientID.Trim) & " and rptcode='" & (ReportCode.Trim) + "'")

        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
            sqlConnection.Close()
        End Using
        Return bRet
    End Function

    Public Function CheckReportType(ByVal PatientID As String, ByVal ReportCode As String, ByVal CriteriaOption As Integer) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = String.Empty
        If CriteriaOption = 1 Then _
            cmdText = ("select * from lab_pro.dbo.receipt where tcaseno=" & Val(PatientID.Trim) & " and tcatg like '%" & (ReportCode.Trim) & "%'")
        If CriteriaOption = 2 Then _
        cmdText = ("select * from lab_pro.dbo.receipt where tcaseno=" & Val(PatientID.Trim) & " and tcode like '%" & (ReportCode.Trim) & "%'")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
            sqlConnection.Close()
        End Using
        Return bRet
    End Function

    Public Function CheckTestParameter(ByVal PatientID As String, ByVal TestCode As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from lab_pro.dbo.receipt where tcaseno=" & Val(PatientID.Trim) & " and tcode = '" & (TestCode.Trim) + "'")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
            sqlConnection.Close()
        End Using
        Return bRet
    End Function

    Public Function NotNull(Of T)(ByVal Value As T, ByVal DefaultValue As T) As T
        If Value Is Nothing OrElse IsDBNull(Value) Then
            Return DefaultValue
        Else
            Return Value
        End If
    End Function

    Public Function CheckRecordExist(ByVal TableName As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = ("select * from " & TableName)
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
            sqlConnection.Close()
        End Using
        Return bRet
    End Function

    Public Sub Print_Reports()
        Call GetConnectionString()
        Try
            Dim CommandText As String = String.Empty
            SqlDataSet.Clear()
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase

            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, gblReportQuery, gblTableName, Connection)

            ' Load Report in memory
            Try
                objReport.Load(gblPrintFileName.Trim)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try

            'Set logon information to reports for view
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next
            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables(gblTableName))
            'Pass the value to crystal report parameter
            With objReport
                crParameterDiscreteValue.Value = gblRptRmkDetail.Trim
                crParameterFieldDefinitions = .DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("Remarks")
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            End With

            'Get Information of Client Printer and set to default
            Dim localPrinter As System.Drawing.Printing.PrintDocument = New PrintDocument()
            objReport.PrintOptions.PrinterName = localPrinter.PrinterSettings.PrinterName

            With objReport
                .RecordSelectionFormula = gblSelectFormula.Trim
                ' For sent Report directly to Printer
                PrintDialog.ShowDialog()
                objReport.PrintToPrinter(1, False, 0, 0)
            End With
            objReport.Refresh()
            objReport.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Public Sub Update_Print_Copies(ByVal TableName As String, ByVal PatientID As String, ByVal RptCode As String)
        Call GetConnectionString()
        Dim Update As String = "update " & TableName & " set PSTATUS = (PSTATUS + 1) where LABNO=" & Val(PatientID.Trim) & " and RPTCODE = '" & RptCode.Trim & "'"
        Execute_DatabaseTable_Query(SqlDataAdapter, Update, Connection)
    End Sub

    Public Sub UpdateReportStatus()
        Call GetConnectionString()
        ReportStatus = False
        Dim SelectTestCategory As String = "SELECT TCASENO, TCATG, TCODE FROM RECEIPT WHERE TDATE = CONVERT(DATETIME,'" & Format(Now, "MM/dd/yyyy") & " 00:00:00',102) and TDELETE = 0 GROUP BY TCASENO,TCATG,TCODE order by TCASENO"
        Execute_DatabaseTable_Query(PatientTestAdapter, SelectTestCategory, Connection)
        Dim SelectReader As SqlDataReader = PatientTestAdapter.SelectCommand.ExecuteReader(CommandBehavior.CloseConnection)
        If SelectReader.HasRows Then
            While SelectReader.Read
                If CheckReport(SelectReader.Item("TCASENO"), SelectReader.Item("TCATG"), SelectReader.Item("TCODE")) = True Then
                    Call FinalizeReportStatus(SelectReader.Item("TCASENO"), SelectReader.Item("TCATG"), SelectReader.Item("TCODE"))
                End If
            End While
        End If
        Connection.Close()
    End Sub

    Public Function CheckReport(ByVal PatientID As Integer, ByVal Category As String, ByVal TestCode As String) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from lab_pro.dbo.rpt_result where labno=" & Val(PatientID) & " and (tstcode in ('" & TestCode.Trim & "') or subcode in ('" & TestCode.Trim & "'))")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
            sqlConnection.Close()
        End Using
        Return bRet
    End Function

    Public Sub FinalizeReportStatus(ByVal PatientID As Integer, ByVal Category As String, ByVal TestCode As String)
        Dim CommandText As String = "update receipt set tdelete = 1 where tcaseno =" & PatientID & " and tcatg = '" & Category.Trim & "' and tcode = '" & TestCode.Trim & "'"
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(CommandText, Conn)
            Try
                Conn.Open()
                Cmd.ExecuteScalar()
                Conn.Close()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End Using
    End Sub

    Public Sub UpdatePatientStatus()
        Call GetConnectionString()
        Dim FinalSelect As String = "SELECT * FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(Now, "MM/dd/yyyy") & " 00:00:00',102)) AND P_STATUS = 'RECEPTION' order by P_NUM"
        Execute_DatabaseTable_Query(PatientGroupAdapter, FinalSelect, Connection)
        Dim GroupReader As SqlDataReader = PatientGroupAdapter.SelectCommand.ExecuteReader
        If GroupReader.HasRows Then
            While GroupReader.Read
                If FinalStatusCheck(GroupReader.Item("p_num")) = False Then
                    Call FinalizePatientStatus(GroupReader.Item("p_num"))
                End If
            End While
        End If
        If GroupReader Is Nothing Then GroupReader.Close()
    End Sub

    Public Function FinalStatusCheck(ByVal PatientID As Integer) As Boolean
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from lab_pro.dbo.receipt where tcaseno = " & Val(PatientID) & " and tdelete = 0")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
            sqlConnection.Close()
        End Using
        Return bRet
    End Function

    Public Sub FinalizePatientStatus(ByVal PatientID As Integer)
        Dim CommandText As String = "update patient set p_status = 'FINALIZED' where P_NUM = " & PatientID
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(CommandText, Conn)
            Try
                Conn.Open()
                Cmd.ExecuteScalar()
                Conn.Close()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End Using
    End Sub

    Public Sub Print_Barcode_Tag()

        Call GetConnectionString()
        Try
            Dim CommandText As String = ""
            SqlDataSet.Clear()
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = ServerDatabase
            If gblReportOption.ToUpper = "RECEIPT" Then CommandText = "Select * from PATIENT WHERE p_num = " & Val(gblFind.Trim)
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "PATIENT", Connection)

            ' Load Report in memory for View
            Try
                objReport.Load(gblBarcodeRpt.Trim)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try

            'Set logon information to reports for view
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next
            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables("patient"))

            With objReport
                ' IF REPORT BELONGS TO PATIENT/LAB RECEIPT
                If gblReportOption.ToUpper = "RECEIPT" Then
                    .RecordSelectionFormula = "{patient.p_num}=" & Val(gblFind)
                    '' For sent Report directly to Printer
                    PrintDialog.ShowDialog()
                    objReport.PrintToPrinter(1, False, 0, 0)
                End If
            End With
            objReport.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Public Sub GetAccountInfo(ByVal AccountID As String)
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from ACCOUNTS where ACC_NO = " & Val(AccountID.Trim))
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    If reader.HasRows Then
                        While reader.Read
                            Ledg_BF = Val(reader.Item("Acc_Balance").ToString)
                            DrCr_Type = reader.Item("Acc_Type").ToString.Trim
                        End While
                    End If
                End Using
            End Using
            sqlConnection.Close()
        End Using
    End Sub

    Public Sub ProcessTransaction(ByVal UpdateQuery As String)
        Dim CommandText As String = UpdateQuery
        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
            Dim Cmd As New SqlCommand(CommandText, Conn)
            Try
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                Cmd.ExecuteNonQuery()
                Conn.Close()
            Catch EX As Exception
                MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End Using
    End Sub

    Public Sub Get_Account_Parameters(ByVal strAccID As Integer)
        Dim AccLnkID_Text As String = "SELECT ACC_HEAD,ACC_TYPE,ACC_NAME FROM ACCOUNTS WHERE ACC_NO = " & strAccID
        Execute_DatabaseTable_Query(SqlDataAdapter, AccLnkID_Text, Connection)
        Dim Reader As SqlDataReader
        Reader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Reader.Read
            gblAccHead = Convert.ToString(Reader.Item("ACC_HEAD"))
            gblAccType = Convert.ToString(Reader.Item("ACC_TYPE"))
            gblAccName = Convert.ToString(Reader.Item("ACC_NAME"))
        End While
        If Not Reader Is Nothing Then Reader.Close()
    End Sub

    Public Sub GetFinancialYear()
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select max(fiscal_year_seq),fiscal_year_period from fiscal_year group by fiscal_year_period")
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    If reader.HasRows Then
                        While reader.Read
                            FinancialYear = reader.Item("FISCAL_YEAR_PERIOD").ToString.Trim
                        End While
                    Else
                        FinancialYear = String.Empty
                    End If
                End Using
            End Using
            sqlConnection.Close()
        End Using
    End Sub

    Public Sub FinalizeLedgersBalances()
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = "select * from accounts order by acc_no"
        Dim UpdBalance As String = String.Empty
        Dim UpdateBal As Double = 0
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    If reader.HasRows Then
                        While reader.Read
                            'SELECTION OF ACCOUNT LEDGER ORDER BY ACC_NO
                            Dim balUpd As String = "SELECT * FROM LEDGERS WHERE (LEDG_ACC_ID = " & reader.Item("acc_no") & ") AND (LEDG_F_YEAR ='" & FinancialYear & "') ORDER BY LEDG_DATE, LEDG_TRAN_ID"
                            Execute_DatabaseTable_Query(SqlDataAdapter, balUpd, Connection)
                            Dim BalUpdater As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                            If BalUpdater.HasRows Then
                                While BalUpdater.Read
                                    'CALCULATE RUNING BALANCE
                                    If BalUpdater.Item("ledg_acc_type").ToString = "DR" Then UpdateBal = UpdateBal + Convert.ToDecimal(BalUpdater.Item("ledg_debit")) - Convert.ToDecimal(BalUpdater.Item("ledg_credit"))
                                    If BalUpdater.Item("ledg_acc_type").ToString = "CR" Then UpdateBal = UpdateBal + Convert.ToDecimal(BalUpdater.Item("ledg_credit")) - Convert.ToDecimal(BalUpdater.Item("ledg_debit"))
                                    'UPDATE DEBIT / CREDIT TRANSACTION
                                    Dim MyQuery As String = "update ledgers set ledg_balance = " & UpdateBal & _
                                                            " where LEDG_DATE = CONVERT(DATETIME,'" & BalUpdater.Item("ledg_date") & " 00:00:00', 102) AND (LEDG_ACC_ID = " & BalUpdater.Item("ledg_acc_id") & ")" & _
                                                            " AND (LEDG_TRAN_ID = " & BalUpdater.Item("ledg_tran_id") & ") AND (LEDG_F_YEAR ='" & FinancialYear & "')"
                                    Call ProcessTransaction(MyQuery)
                                    Final_Dr = Final_Dr + BalUpdater.Item("LEDG_DEBIT")
                                    Final_Cr = Final_Cr + BalUpdater.Item("LEDG_CREDIT")
                                End While
                            End If
                            'UPDATE CLOSING BALANCE ACCOUNT HEADS
                            Dim Final_Balance As String = "UPDATE ACCOUNTS SET ACC_BALANCE = " & UpdateBal & "," & _
                                                                      "ACC_UPDATE = '" & Format(DateTime.Parse(Now.Date.ToShortDateString.ToString), "MM/dd/yyyy") & "', " & _
                                                                      "ACC_DEBIT = " & Final_Dr & "," & _
                                                                      "ACC_CREDIT = " & Final_Cr & " " & _
                                                                      "WHERE ACC_NO = " & reader.Item("ACC_NO")
                            Call ProcessTransaction(Final_Balance)
                            UpdateBal = 0
                            Final_Cr = 0
                            Final_Dr = 0
                        End While
                    End If
                End Using
            End Using
            sqlConnection.Close()
        End Using
    End Sub

End Module
