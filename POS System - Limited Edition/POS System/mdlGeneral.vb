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
    Public Title, Address, Contact As String
    Public ConnInfo As New CrystalDecisions.Shared.TableLogOnInfo
    Public crParameterFieldDefinitions As ParameterFieldDefinitions
    Public crParameterFieldDefinition As ParameterFieldDefinition
    Public crParameterValues As New ParameterValues
    Public crParameterDiscreteValue As New ParameterDiscreteValue
    Public SaveServerSettings, LoginStatus, gblRelation As Boolean
    Public ServerName, ServerID, ServerPwd, ServerDatabase, gblItemCode, gblFind, gblSaleType, gblCP, gblCP_ID, gblReportName, gblReportOption, gblReportFilter, gblBillReport, gblBillRptName, gblMessage, gblQueryText, strTCode, strTname, strCatg, strTrate, strRptLvl As String
    Public objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public objSubReport As CrystalDecisions.CrystalReports.Engine.SubreportObject
    Public gblDiscount As Long
    Public FromDate, ToDate As Date
    Public ConnString, SqlConnString, UserStatus, UserName, UserPassword, UserID, SysOperator, DiscountBy, RptUser, gblAccType, gblInput As String
    Public EntryDataAdpter, ProductCodeAdapter As New SqlDataAdapter()
    Public EntryDataSet, ProductCodeDataset As New DataSet()
    Public myDataSet As New DataSet()
    Public Connection As New SqlConnection()
    Public intTotal, intPaid, intDues, intOpnCr, intOpnDr, intD_Paid, intD_Dues, intD_Disc, intD_Recv As Double
    Public svDataSet As New DataSet()
    Public ReportDataSet As New DataSet()
    Public PwdDataAdapter, PurchaseAdapter, ProductAdapter, Suppliers, Gen_Tran_Adapter, SaleDataAdapter As New SqlDataAdapter()
    Public SqlDataAdapter As New SqlDataAdapter()
    Public TransferAdapter As New SqlDataAdapter()
    Public TransferDataSet, Gen_Tran_DataSet, SuppliersDataSet, SaleDataSet As New DataSet()
    Public SqlDataSet, gblRecordDataSet As New DataSet()
    Public gblPrliviges, gblAccLink As Integer

    Public Sub ExecuteDatasetQuery(ByVal Obj As SqlDataAdapter, ByVal ObjDataSet As DataSet, ByVal MyQuery As String, ByVal TableName As String, ByVal SqlConn As SqlConnection)

        Call GetConnectionString()
        Obj.SelectCommand = New SqlCommand()
        Obj.SelectCommand.Connection = Connection
        If Connection.State = ConnectionState.Open Then Connection.Close()
        ObjDataSet.Clear()
        Connection.Open()
        Obj.SelectCommand.CommandText = MyQuery
        Obj.SelectCommand.CommandType = CommandType.Text
        Obj.Fill(ObjDataSet, TableName.Trim)

    End Sub

    Public Sub ExecuteAdapterQuery(ByVal Obj As SqlDataAdapter, ByVal UpdateQuery As String, ByVal SqlConn As SqlConnection)

        Call GetConnectionString()
        Obj.SelectCommand = New SqlCommand()
        Obj.SelectCommand.Connection = Connection
        If Connection.State = ConnectionState.Open Then Connection.Close()
        Obj.SelectCommand.CommandText = UpdateQuery
        Obj.SelectCommand.CommandType = CommandType.Text
        Connection.Open()
        Obj.SelectCommand.ExecuteNonQuery()
       
    End Sub

    <Serializable()> Public Structure SoftwareSettings
        Dim ProgramName As String
        Dim ServerName As String
        Dim ServerUserId As String
        Dim ServerPassword As String
        Dim DataBaseName As String
    End Structure

    Public Sub Get_Property_GotFocus(ByVal MyObject As Object)
        MyObject.BackColor = Color.LightGray
        MyObject.ForeColor = Color.Black
    End Sub

    Public Sub Get_Property_LostFocus(ByVal MyObject As Object)
        MyObject.BackColor = Color.SteelBlue
        MyObject.ForeColor = Color.White
    End Sub

    Public Sub GetServerFileSettings(ByVal RWOption As String)

        Dim StartApplication As New SoftwareSettings
        Dim BF As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim MS As New System.IO.MemoryStream()

        Dim path As String = Directory.GetCurrentDirectory()

        Try
            If RWOption = "READ" Then
                Dim bytes As Byte() = My.Computer.FileSystem.ReadAllBytes(path & "\" & "poslib.cfg")
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
                My.Computer.FileSystem.WriteAllBytes(path & "\" & "poslib.cfg", MS.GetBuffer(), False)

            End If
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Public Function GenerateMax_ID(ByVal tblName As String, ByVal strField As String) As Integer

        Dim MaxID_Text As String = "SELECT MAX(" & strField & ") FROM " & tblName

        Using Conn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
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

    Public Sub Print_Slips_Manually()

        Call GetConnectionString()
        Dim CommandText As String = ""
        SqlDataSet.Clear()

        ConnInfo.ConnectionInfo.UserID = ServerID
        ConnInfo.ConnectionInfo.Password = ServerPwd
        ConnInfo.ConnectionInfo.ServerName = ServerName
        ConnInfo.ConnectionInfo.DatabaseName = "POS"

        Dim GetTitle As String = "Select * from info"
        ExecuteAdapterQuery(SqlDataAdapter, GetTitle, Connection)
        Dim GetData As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GetData.HasRows Then
            While GetData.Read
                Title = GetData.Item("REG_NAME").ToString
                Address = GetData.Item("REG_ADDRESS").ToString
                Contact = GetData.Item("TEL1").ToString
            End While
        End If

        If gblReportOption.ToUpper = "RECEIPT" Then CommandText = "Select * from SALE_MASTER WHERE SaleID = " & Val(gblFind.Trim)

        ExecuteDatasetQuery(SqlDataAdapter, SqlDataSet, CommandText, "SALE_MASTER", Connection)

        ' Load Report in memory for View
        Try
            objReport.Load(gblReportName.Trim)
            MsgBox(gblReportName)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End Try

        'Set logon information to reports for view
        For intCounter = 0 To objReport.Database.Tables.Count - 1
            objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
        Next
        'Set the Datasource for reports
        objReport.SetDataSource(SqlDataSet.Tables("sale_master"))

        With objReport
            crParameterDiscreteValue.Value = Title.Trim
            crParameterFieldDefinitions = .DataDefinition.ParameterFields
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("CompanyTitle")
            crParameterValues = crParameterFieldDefinition.CurrentValues
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            crParameterDiscreteValue.Value = Address.Trim
            crParameterFieldDefinitions = .DataDefinition.ParameterFields
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("Address")
            crParameterValues = crParameterFieldDefinition.CurrentValues
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            crParameterDiscreteValue.Value = Contact.Trim
            crParameterFieldDefinitions = .DataDefinition.ParameterFields
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("Telphone")
            crParameterValues = crParameterFieldDefinition.CurrentValues
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            ' IF REPORT BELONGS TO RECEIPT
            If gblReportOption.ToUpper = "RECEIPT" Then
                .RecordSelectionFormula = "{sale_master.saleid}=" & Val(gblFind)
                '' For sent Report directly to Printer
                objReport.PrintToPrinter(1, False, 0, 0)
                '// For export report in pdf format if required uncommit the line
                'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\CashReceipt-" & gblFind.Trim & ".pdf")
                
            End If
        End With
        objReport.Close()

    End Sub

    Public Sub DisplayMessage(ByVal Msg As String)
        MsgBox(Msg, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, My.Application.Info.ProductName)
        Exit Sub
    End Sub

    Public Sub GetConnectionString()
        Connection = New SqlConnection("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POS;")
    End Sub

    Public Function CheckDatabaseExists(ByVal server As String, ByVal database As String) As Boolean

        Dim connString As String = ("Data Source=" + (server + ";Initial Catalog=master;Integrated Security=True;"))
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

    End Function

    Public Sub ValidateNumericKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal txt As TextBox, ByVal nexttxt As TextBox)
        '48 - 57  = Ascii codes for numbers
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
        'If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
        'If e.KeyChar = Chr(13) Then nexttxt.Focus() 'Enter key moves to next control
        'If e.KeyChar = Chr(13) Then GetNextControl(nexttxt, True).Focus() 'Enter key moves to next control
    End Sub

    Public Sub ValidateNumbersOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal txt As TextBox)
        '48 - 57  = Ascii codes for numbers
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    End Sub

    Public Sub ValidateAlphaNumOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Or (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or Asc(e.KeyChar) = 8 Then 'Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 46
            ' Go Through
        Else
            e.KeyChar = Nothing
        End If
        'Dim KeyAscii As Short = Asc(e.KeyChar)
        'Select Case KeyAscii
        '    Case System.Windows.Forms.Keys.Back  '<--- this is for  backspace
        '    Case 13
        '        e.Handled = True
        '        SendKeys.Send("{TAB}")   '<---- use to tab to next textbox or control
        '        KeyAscii = 0
        '    Case Is <= 32
        '        ' KeyAscii = 0
        '    Case 48 To 57     '<--- this is for numbers
        '        Exit Sub
        '    Case 65 To 90     '<--- this is for Uppercase Alpha
        '        Exit Sub
        '    Case 97 To 122     '<--- this is for Lowercase Alpha
        '        Exit Sub
        '    Case Else
        '        e.Handled = True
        'End Select
    End Sub

    Function strReplicate(ByVal str As String, ByVal intD As Integer) As String
        'This fucntion padded "0" after the number to evaluate hundred, thousand and on....
        'using this function you can replicate any Charactor with given string.
        Dim i As Integer
        strReplicate = ""
        For i = 1 To intD
            strReplicate = strReplicate + str
        Next
        Return strReplicate
    End Function

    Function AmtInWord(ByVal Num As Decimal) As String
        'I have created this function for converting amount in indian rupees (INR). 
        'You can manipulate as you wish like decimal setting, Doller (any currency) Prefix.
        Dim strNum As String
        Dim strNumDec As String
        Dim StrWord As String
        strNum = Num

        If InStr(1, strNum, ".") <> 0 Then
            strNumDec = Mid(strNum, InStr(1, strNum, ".") + 1)

            If Len(strNumDec) = 1 Then
                strNumDec = strNumDec + "0"
            End If
            If Len(strNumDec) > 2 Then
                strNumDec = Mid(strNumDec, 1, 2)
            End If

            strNum = Mid(strNum, 1, InStr(1, strNum, ".") - 1)
            StrWord = IIf(CDbl(strNum) = 1, "Rupee ", "Rupees ") + NumToWord(CDbl(strNum)) + IIf(CDbl(strNumDec) > 0, " and Paise" + cWord3(CDbl(strNumDec)), "")
        Else
            StrWord = IIf(CDbl(strNum) = 1, "Rupee ", "Rupees ") + NumToWord(CDbl(strNum))
        End If
        AmtInWord = StrWord & " Only"
        Return AmtInWord
    End Function

    Function NumToWord(ByVal Num As Decimal) As String
        'I divided this function in two part.
        '1. Three or less digit number.
        '2. more than three digit number.
        Dim strNum As String
        Dim StrWord As String
        strNum = Num

        If Len(strNum) <= 3 Then
            StrWord = cWord3(CDbl(strNum))
        Else
            StrWord = cWordG3(CDbl(Mid(strNum, 1, Len(strNum) - 3))) + " " + cWord3(CDbl(Mid(strNum, Len(strNum) - 2)))
        End If
        NumToWord = StrWord
    End Function

    Function cWordG3(ByVal Num As Decimal) As String
        '2. more than three digit number.
        Dim strNum As String = ""
        Dim StrWord As String = ""
        Dim readNum As String = ""
        strNum = Num
        If Len(strNum) Mod 2 <> 0 Then
            readNum = CDbl(Mid(strNum, 1, 1))
            If readNum <> "0" Then
                StrWord = retWord(readNum)
                readNum = CDbl("1" + strReplicate("0", Len(strNum) - 1) + "000")
                StrWord = StrWord + " " + retWord(readNum)
            End If
            strNum = Mid(strNum, 2)
        End If
        While Not Len(strNum) = 0
            readNum = CDbl(Mid(strNum, 1, 2))
            If readNum <> "0" Then
                StrWord = StrWord + " " + cWord3(readNum)
                readNum = CDbl("1" + strReplicate("0", Len(strNum) - 2) + "000")
                StrWord = StrWord + " " + retWord(readNum)
            End If
            strNum = Mid(strNum, 3)
        End While
        cWordG3 = StrWord
        Return cWordG3
    End Function

    Function cWord3(ByVal Num As Decimal) As String
        '1. Three or less digit number.
        Dim strNum As String = ""
        Dim StrWord As String = ""
        Dim readNum As String = ""
        If Num < 0 Then Num = Num * -1
        strNum = Num

        If Len(strNum) = 3 Then
            readNum = CDbl(Mid(strNum, 1, 1))
            StrWord = retWord(readNum) + " Hundred"
            strNum = Mid(strNum, 2, Len(strNum))
        End If

        If Len(strNum) <= 2 Then
            If CDbl(strNum) >= 0 And CDbl(strNum) <= 20 Then
                StrWord = StrWord + " " + retWord(CDbl(strNum))
            Else
                StrWord = StrWord + " " + retWord(CDbl(Mid(strNum, 1, 1) + "0")) + " " + retWord(CDbl(Mid(strNum, 2, 1)))
            End If
        End If

        strNum = CStr(Num)
        cWord3 = StrWord
        Return cWord3
    End Function

    Function retWord(ByVal Num As Decimal) As String
        'This two dimensional array store the primary word convertion of number.
        retWord = ""
        Dim ArrWordList(,) As Object = {{0, ""}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, _
                                        {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}, _
                                        {10, "Ten"}, {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"}, _
                                        {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"}, _
                                        {20, "Twenty"}, {30, "Thirty"}, {40, "Forty"}, {50, "Fifty"}, {60, "Sixty"}, _
                                        {70, "Seventy"}, {80, "Eighty"}, {90, "Ninety"}, {100, "Hundred"}, {1000, "Thousand"}, _
                                        {100000, "Lakh"}, {10000000, "Crore"}}

        Dim i As Integer
        For i = 0 To UBound(ArrWordList)
            If Num = ArrWordList(i, 0) Then
                retWord = ArrWordList(i, 1)
                Exit For
            End If
        Next
        Return retWord
    End Function

    Public Sub ValidateAlphaKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal txt As TextBox)
        If Not Char.IsLetter(e.KeyChar) Then e.Handled = True 'allow letters
        If e.KeyChar = Chr(8) Or e.KeyChar = Chr(32) Then e.Handled = False 'allow Backspace and space
    End Sub

    Public Function CheckCellValue(ByVal DataGrid As DataGridView) As Boolean
        Dim FirstValue As Boolean = False
        Dim cell As DataGridViewCell
        For Each cell In DataGrid.SelectedCells
            If Not FirstValue Then
                CheckCellValue = True
            Else
                CheckCellValue = False
            End If
        Next
        Return CheckCellValue
    End Function

End Module
