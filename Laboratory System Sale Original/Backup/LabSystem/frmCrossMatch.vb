Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System

Public Class frmCrossMatch
    Dim TestItem As New ListViewItem
    Dim FindCode, Rmks, strCpName, Current_Operator, strDiscLvl, wDonor_Pid As String
    Dim CodeCounter As Integer = 0
    Dim intCpDiscount As Integer = 0
    Dim Return_Response As Integer = 0
    Dim wTotal As Double
    Dim wTestID As Integer
    Dim Sub_Addition As Boolean = False
    Dim Mode, Saved, MultipleMode As Boolean
    Dim dateNow As Date = DateTime.Now
    Dim DelString, MaxSn As String
    Dim DelAmount As Double
    Dim dtResult As Date

    Private Sub frmCrossMatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        strDiscLvl = ""
        Saved = False
        Mode = False
        MultipleMode = False
        wDonor_Pid = 0
        wTestID = 0

        dateNow = Format(DateTime.Parse(DateTime.Now), "MM/dd/yyyy")
        Call GetConnectionString()
        Try
            Dim cpReader As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select cp_id from CollectionPoint order by cp_id", "CollectionPoint", Connection)
            cpReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While cpReader.Read
                Me.cmbCP.Items.Add(cpReader.Item("CP_ID"))
            End While
            If Not cpReader Is Nothing Then cpReader.Close()
            ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select visitor_name from visitor_table order by visitor_name", "visitor_table", Connection)
            cpReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While cpReader.Read
                Me.cmbVisitor.Items.Add(cpReader.Item("VISITOR_NAME"))
            End While
            If Not cpReader Is Nothing Then cpReader.Close()
            strRptLvl = 1
            Call cmdNew_Click(sender, e)
            If gblPrliviges > 2 Then
                txtCompli.Enabled = False
                txtDiscount.Enabled = False
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        Connection.Close()
        Me.Focus()

    End Sub

    Private Sub cmbTitle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitle.LostFocus
        If Mode = False Then Call cmbTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTitle.SelectedIndexChanged
        If Mode = False Then
            Select Case cmbTitle.Text
                Case "Mr." : lblPSex.Text = "Male"
                Case "B/O" : lblPSex.Text = "Male"
                Case "S/O" : lblPSex.Text = "Male"
                Case "F/O" : lblPSex.Text = "Male"
                Case "Master" : lblPSex.Text = "Male"
                Case "Sis/O" : lblPSex.Text = "Female"
                Case "Mrs." : lblPSex.Text = "Female"
                Case "M/O" : lblPSex.Text = "Female"
                Case "Wid/O" : lblPSex.Text = "Female"
                Case "W/O" : lblPSex.Text = "Female"
                Case "Miss." : lblPSex.Text = "Female"
                Case "Ms." : lblPSex.Text = "Female"
                Case "Baby" : lblPSex.Text = "Female"
                Case "D/O" : lblPSex.Text = "Female"
            End Select
        End If
    End Sub

    Private Sub cmbDTitle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDTitle.LostFocus
        If Mode = False Then Call cmbDTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbDTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDTitle.SelectedIndexChanged
        If Mode = False Then
            Select Case cmbDTitle.Text
                Case "Mr." : lblDSex.Text = "Male"
                Case "B/O" : lblDSex.Text = "Male"
                Case "S/O" : lblDSex.Text = "Male"
                Case "F/O" : lblDSex.Text = "Male"
                Case "Master" : lblDSex.Text = "Male"
                Case "Sis/O" : lblDSex.Text = "Female"
                Case "Mrs." : lblDSex.Text = "Female"
                Case "M/O" : lblDSex.Text = "Female"
                Case "Wid/O" : lblDSex.Text = "Female"
                Case "W/O" : lblDSex.Text = "Female"
                Case "Miss." : lblDSex.Text = "Female"
                Case "Ms." : lblDSex.Text = "Female"
                Case "Baby" : lblDSex.Text = "Female"
                Case "D/O" : lblDSex.Text = "Female"
            End Select
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        'REFRESH FIELDS FOR NEW RECORD
        Try
            Me.txtCode.Clear()
            Me.txtName.Clear()
            Me.txtDName.Clear()
            Me.lblPSex.Text = ""
            Me.lblDSex.Text = ""
            Me.txtTotal.Text = "00"
            Me.txtDues.Text = "00"
            Me.txtPaid.Text = "00"
            Me.txtDiscount.Text = "00"
            Me.txtCompli.Text = "00"
            Me.txtCode.Clear()
            Me.txtRefer.Clear()
            Me.cmbTitle.Text = "Mr."
            Me.cmbDTitle.Text = "Mr."
            Me.cmbVisitor.Text = ""
            Me.txtYrs.Clear()
            Me.txtMth.Clear()
            Me.txtDay.Clear()
            Me.txtDYrs.Clear()
            Me.txtMth.Text = "00"
            Me.txtYrs.Text = "00"
            Me.txtDay.Text = "00"
            Me.txtDYrs.Text = "00"
            Me.cmbCP.Text = "Select Reference Code"

            Dim MaxId As String = ""
            Dim cpReader As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select Max(P_NUM) AS MAX_ID from PATIENT", "CollectionPoint", Connection)
            cpReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While cpReader.Read
                MaxId = cpReader.Item("MAX_ID").ToString
            End While
            If Not cpReader Is Nothing Then cpReader.Close()

            Dim MaxSerialNo As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select Max(P_SNO) AS MAX_ID from PATIENT WHERE P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & " 00:00:00',102)", "PATIENT", Connection)
            MaxSerialNo = SqlDataAdapt.SelectCommand.ExecuteReader
            While MaxSerialNo.Read
                MaxSn = MaxSerialNo.Item("MAX_ID").ToString
            End While
            If Not MaxSerialNo Is Nothing Then MaxSerialNo.Close()

            If SysOperator.Trim = "DEMO" Or SysOperator.Trim = "demo" Then
                txtRecNo.Text = "000000"
            Else
                txtRecNo.Text = Val(MaxId) + 1
                lblSno.Text = Val(MaxSn) + 1
            End If

            txtDate.Text = Format(Now, "MM/dd/yyyy")
            gblDiscount = 0
            intCpDiscount = 0
            strCpName = ""
            Mode = False
            wDonor_Pid = 0
            wTestID = 0
            cmbTitle.Focus()
            cmbTitle.Focus()
            TestListView.Items.Clear()
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If txtRefer.Text.Trim = "" Then MsgBox("Please Select Referenced Doctor.", MsgBoxStyle.Information, My.Application.Info.ProductName)

        txtDues.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)

        If SysOperator.Trim = "DEMO" Or SysOperator.Trim = "demo" Then Exit Sub

        If Mode = True Then

            'Try
            Dim CommandText As String = ""
            Dim CheckCommand As String = ""
            Dim strDate As Date = CDate(txtDate.Text)
            Dim strDiff As String = DateDiff(DateInterval.Day, Date.Today, strDate)
            'If Val(strDiff) <> 0 Then MsgBox("Correction cannot be made.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub

            'Rmks = InputBox("Please write reason for modification.", "Remarks")
            'If Len(Rmks) = 0 Then Exit Sub

            '// Add Test Data into Receipt Table
            Dim iCount As Integer = TestListView.Items.Count
            Dim iLoop As Integer = 0

            Do Until iLoop = iCount
                wTestID += 1
                CheckCommand = "SELECT COUNT(TCASENO) AS EXPR_1 FROM RECEIPT WHERE TCASENO = " & Val(txtRecNo.Text.Trim) & _
                              " AND TCODE = '" & TestListView.Items(iLoop).Text & "' AND TDELETE =" & Val(TestListView.Items(iLoop).SubItems(6).Text)
                Execute_DatabaseTable_Query(SqlDataAdapt, CheckCommand, Connection)
                Dim Reader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
                While Reader.Read
                    Return_Response = Reader.Item("EXPR_1")
                End While
                If Not Reader Is Nothing Then Reader.Close()

                If Return_Response = 0 Then
                    CommandText = "INSERT INTO RECEIPT(TCASENO,TCODE,TNAME,TCATG,TRATE,TQTY,TDATE,TMODE,TDELETE) VALUES (" & _
                             Val(txtRecNo.Text) & ",'" & _
                             TestListView.Items(iLoop).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(1).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(2).Text & "'," & _
                             Val(TestListView.Items(iLoop).SubItems(5).Text) & ",1,'" & _
                             Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "','ADD'," & wTestID & ")"
                    Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                    CommandText = Nothing
                    txtTotal.Text = Val(txtTotal.Text) + Val(TestListView.Items(iLoop).SubItems(5).Text)
                    txtDiscount.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(txtDues.Text)
                    txtDues.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text) - Val(txtCompli.Text)

                    If Val(strRptLvl) < Val(TestListView.Items(iLoop).SubItems(4).Text) Then
                        strRptLvl = TestListView.Items(iLoop).SubItems(4).Text
                    End If
                End If
                iLoop += 1
            Loop
            iCount = 0

            '// IF CORRECTION MADE WITHIN DATE
            CommandText = "UPDATE PATIENT SET P_DEL_OK = 'Yes', P_DEL_DATE = '" & _
                          Format(Now, "MM/dd/yyyy") & "', P_DEL_TIME = '" & Format(Now, "hh:mm tt") & "', " & _
                          "P_NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "', " & _
                          "P_DNAME = 'x', " & _
                          "P_AGE = '" & txtYrs.Text.Trim & Space(1) & "Yrs" & Space(1) & txtMth.Text.Trim & Space(1) & "Mth" & Space(1) & txtDay.Text.Trim & Space(1) & "Day" & "', " & _
                          "P_DON_AGE = 'x', " & _
                          "P_REF_BY = '" & StrConv(txtRefer.Text.Trim, VbStrConv.ProperCase) & "', " & _
                          "P_DEL_OPERATOR = '" & SysOperator & "', P_PAID = " & Val(txtPaid.Text.Trim) & ", " & _
                          "P_TOTAL = " & Val(txtTotal.Text.Trim) & ", P_DISCOUNT = " & Val(txtDiscount.Text.Trim) & ", " & _
                          "P_DUES = " & Val(txtDues.Text.Trim) & " WHERE P_NUM = " & Val(txtRecNo.Text)

            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
            SqlDataAdapt.Dispose()

            Call Donor_Profile("ADD")

            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            'End Try
            Connection.Close()

        End If
        If Mode = False Then
            Dim IF_RECORD_EXIST As String = "SELECT COUNT(P_NUM) AS EXPR_1 FROM PATIENT WHERE P_NUM = " & Val(txtRecNo.Text)
            Execute_DatabaseTable_Query(SqlDataAdapt, IF_RECORD_EXIST, Connection)
            Dim Reader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While Reader.Read
                Return_Response = Reader.Item("EXPR_1")
            End While
            If Not Reader Is Nothing Then Reader.Close()
            If Return_Response > 0 Then MsgBox("Record already Exist.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName) : Exit Sub

            'Try
            '// Add Test Data into Receipt Table
            Dim iCount As Integer = TestListView.Items.Count
            Dim iLoop As Integer = 0
            Dim CommandText As String
            If iCount > 0 And Sub_Addition = True Then
                Do Until iLoop = iCount
                    wTestID += 1
                    CommandText = "INSERT INTO RECEIPT(TCASENO,TCODE,TNAME,TCATG,TRATE,TQTY,TDATE,TMODE,TDELETE) VALUES (" & _
                             Val(txtRecNo.Text) & ",'" & _
                             TestListView.Items(iLoop).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(1).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(2).Text & "'," & _
                             Val(TestListView.Items(iLoop).SubItems(5).Text) & ",1,'" & _
                             Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "','ADD'," & wTestID & ")"
                    Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                    CommandText = Nothing
                    If Val(strRptLvl) < Val(TestListView.Items(iLoop).SubItems(4).Text) Then
                        strRptLvl = TestListView.Items(iLoop).SubItems(4).Text
                    End If
                    iLoop += 1
                Loop
                iCount = 0
            End If
            Sub_Addition = False

            '// ADD NEW RECORD IN THE TABLE
            Dim svSql As String = "Select * from PATIENT WHERE P_NUM = " & Val(txtRecNo.Text)
            SqlDataAdapt = New SqlDataAdapter(svSql, Connection)
            SqlDataAdapt.Fill(svDataSet, "PATIENT")
            Connection.Close()

            Dim svCmdBuilder As New SqlCommandBuilder(SqlDataAdapt)
            Dim svDataRow As DataRow
            Dim strDate As DateTime = DateTime.Now
            SysOperator.Trim()

            '// ASSIGN FIELD DATA VALUES FOR NEW RECORD
            svDataRow = svDataSet.Tables("PATIENT").NewRow()
            svDataRow.Item("P_NUM") = Val(txtRecNo.Text)
            svDataRow.Item("P_SNO") = Val(lblSno.Text)
            svDataRow.Item("P_NAME") = StrConv(cmbTitle.Text.Trim & Space(1) & txtName.Text.Trim, VbStrConv.ProperCase)
            svDataRow.Item("P_DNAME") = "x"
            svDataRow.Item("P_AGE") = txtYrs.Text.Trim & Space(1) & "Yrs" & Space(1) & txtMth.Text.Trim & Space(1) & "Mth" & Space(1) & txtDay.Text.Trim & Space(1) & "Day"
            svDataRow.Item("P_SEX") = lblPSex.Text.Trim
            svDataRow.Item("P_DON_SEX") = "x"
            svDataRow.Item("P_PHONE") = 0
            svDataRow.Item("P_SLIP_NUM") = 0
            svDataRow.Item("P_PANNEL") = 0
            svDataRow.Item("P_DON_AGE") = "x"
            svDataRow.Item("P_REF_BY") = StrConv(txtRefer.Text.Trim, VbStrConv.ProperCase)
            svDataRow.Item("P_CP") = StrConv(cmbCP.Text.Trim, VbStrConv.Uppercase)
            svDataRow.Item("P_TOTAL") = Val(txtTotal.Text.Trim)
            svDataRow.Item("P_PAID") = Val(txtPaid.Text.Trim)
            svDataRow.Item("P_DUES") = Val(txtDues.Text.Trim)
            svDataRow.Item("P_DISCOUNT") = Val(txtDiscount.Text.Trim)
            svDataRow.Item("P_COMPLIMENT") = Val(txtCompli.Text.Trim)
            svDataRow.Item("P_DELETE") = 0
            svDataRow.Item("P_DEL_DISC") = 0
            svDataRow.Item("P_DEL_DUES") = 0
            svDataRow.Item("P_DEL_PAID") = 0
            svDataRow.Item("P_COM_DUES") = 0
            svDataRow.Item("P_COM_DISC") = 0
            svDataRow.Item("P_COM_PAID") = 0
            svDataRow.Item("P_AFT_PAID") = 0
            svDataRow.Item("P_AFT_GROSS") = 0
            svDataRow.Item("P_AFT_DUES") = 0
            svDataRow.Item("P_AFT_DISC") = 0
            svDataRow.Item("P_BAD_DEBTS") = 0
            svDataRow.Item("P_OTHER") = 0
            svDataRow.Item("P_DUE_RCV") = 0
            svDataRow.Item("P_EDIT_BY") = "X"
            svDataRow.Item("P_COMP_BY") = "X"
            svDataRow.Item("P_DISC_BY") = "X"
            svDataRow.Item("P_DEL_OK") = "X"
            svDataRow.Item("P_STAFF_NM") = "X"
            svDataRow.Item("P_REASON") = "X"
            svDataRow.Item("P_POSTING") = "N"
            svDataRow.Item("P_DUE_RCV_OPERATOR") = "X"
            svDataRow.Item("P_EDIT_OPR") = "X"
            svDataRow.Item("P_DEL_OPERATOR") = "X"
            svDataRow.Item("P_DEL_DATE") = Format(DateTime.Parse("01/07/2006"), "M/d/yyyy")
            svDataRow.Item("P_DUE_RCV_DATE") = Format(DateTime.Parse("01/07/2006"), "M/d/yyyy")
            svDataRow.Item("P_DELETE_ON") = Format(DateTime.Parse("01/07/2006"), "M/d/yyyy")
            svDataRow.Item("P_EDIT_ON") = Format(DateTime.Parse("01/07/2006"), "M/d/yyyy")
            svDataRow.Item("P_COMP_ON") = Format(DateTime.Parse("01/07/2006"), "M/d/yyyy")
            svDataRow.Item("P_DELETE_ON") = Format(DateTime.Parse("01/07/2006"), "M/d/yyyy")
            svDataRow.Item("P_BAD_DATE") = Format(DateTime.Parse("01/07/2006"), "M/d/yyyy")
            svDataRow.Item("P_AFT_DATE") = Format(DateTime.Parse("01/07/2006"), "M/d/yyyy")
            svDataRow.Item("P_DATE_SAMPLE") = Format(DateTime.Parse(Now), "M/d/yyyy")
            svDataRow.Item("P_TIME_SAMPLE") = Format(DateTime.Parse(Now), "hh:mm tt")
            svDataRow.Item("P_RPT_DATE") = Format(DateTime.Parse(Now), "M/d/yyyy")
            If cmbVisitor.Text = "" Then svDataRow.Item("P_VISITOR") = "X" Else svDataRow.Item("P_VISITOR") = StrConv(cmbVisitor.Text.Trim, VbStrConv.Uppercase)
            svDataRow.Item("P_RPT_DATE") = Format(DateTime.Parse(Now), "M/d/yyyy")
            svDataRow.Item("P_RPT_TIME") = Format(DateTime.Parse(Now), "hh:mm tt")
            svDataRow.Item("P_DEL_TIME") = Format(DateTime.Parse(Now), "hh:mm tt")
            svDataRow.Item("P_OPERATOR") = SysOperator.Trim

            If Val(txtCompli.Text.Trim) > 0 Then
                svDataRow.Item("P_DEL_OK") = "YES"
                svDataRow.Item("P_DEL_DATE") = Format(DateTime.Parse(Now), "M/d/yyyy")
                svDataRow.Item("P_DEL_TIME") = Format(DateTime.Parse(Now), "hh:mm tt")
                svDataRow.Item("P_DEL_OPERATOR") = SysOperator
                svDataRow.Item("P_COMP_BY") = SysOperator
                svDataRow.Item("P_COMP_ON") = Format(DateTime.Parse(Now), "M/d/yyyy")
                svDataRow.Item("P_EDIT_BY") = SysOperator
                svDataRow.Item("P_EDIT_ON") = Format(DateTime.Parse(Now), "M/d/yyyy")
            End If

            '// SAVE DATA ROW IN THE TABLE
            svDataSet.Tables("PATIENT").Rows.Add(svDataRow)
            SqlDataAdapt.Update(svDataSet, "PATIENT")
            Call Donor_Profile("ADD")
            Call Record_Count()
            Me.ProcessTabKey(False)
            gblDiscount = 0
            intCpDiscount = 0
            If cmdSave.Text = "&Update" Then cmdSave.Text = "&Save Record"
            cmdSave.Focus()
            Mode = True
            Saved = True
            MultipleMode = True
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            'End Try
            Connection.Close()
            Exit Sub
        End If

    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click

        'Try
        '// Find or Delivered Reports / Dues Received by operator
        Dim RecStatus As String
        gblFind = Microsoft.VisualBasic.InputBox("Please Enter Patient Lab ID # to find.", "Find Record")
        If Len(gblFind) = 0 Then Exit Sub

        Dim strSql As String = "Select * from PATIENT WHERE P_NUM = " & Val(gblFind.Trim)
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "PATIENT", Connection)

        Dim objDataTable As New Data.DataTable("PATIENT")
        Dim objDataRow As DataRow

        SqlDataAdapt.Fill(objDataTable)
        If objDataTable.Rows.Count > 0 Then
            For Each objDataRow In objDataTable.Rows
                RecStatus = objDataRow.Item("P_DEL_OK").ToString
                '// IF STATUS IS DELIVERED
                If RecStatus.Trim = "YES" Or RecStatus.Trim = "Yes" Then
                    MsgBox("Report Delivered on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                            & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)
                    '// IF STATUS IS CANCELLED
                ElseIf RecStatus.Trim = "CANCELLED" Or RecStatus.Trim = "Cancelled" Or RecStatus.Trim = "COMPLIMENTARY" Or RecStatus.Trim = "Complimentary" Then
                    MsgBox("Report " & RecStatus.Trim & " on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                            & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)

                End If

                '// SHOW PATIENT TESTS PARAMETERS IN LIST VIEW
                TestListView.Items.Clear()
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "SELECT * FROM RECEIPT WHERE TCASENO = " & Val(gblFind.Trim), "RECEIPT", Connection)
                Dim forListView As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
                While forListView.Read
                    Dim TestItem As New ListViewItem
                    TestItem.Text = Convert.ToString(forListView.Item("tcode")).ToUpper.Trim
                    TestItem.SubItems.Add(Convert.ToString(forListView.Item("tname")).ToUpper.Trim)
                    TestItem.SubItems.Add(Convert.ToString(forListView.Item("tcatg")).ToUpper.Trim)
                    TestItem.SubItems.Add(Convert.ToString(forListView.Item("tmode")).ToUpper.Trim)
                    TestItem.SubItems.Add(Convert.ToString(forListView.Item("tqty")).ToUpper.Trim)
                    TestItem.SubItems.Add(Convert.ToString(forListView.Item("trate")).ToUpper.Trim)
                    TestItem.SubItems.Add(Convert.ToString(forListView.Item("tdelete")).ToUpper.Trim)
                    TestListView.Items.Add(TestItem)
                End While

                '// IF STATUS IS NORMAL
                txtRecNo.Text = objDataRow.Item("P_NUM")
                If IsDBNull(objDataRow.Item("P_SNO")) = True Then lblSno.Text = "00" Else lblSno.Text = objDataRow.Item("P_SNO")
                txtName.Text = objDataRow.Item("P_NAME")
                txtYrs.Text = Mid(objDataRow.Item("P_AGE"), 1, 2)
                txtMth.Text = Mid(objDataRow.Item("P_AGE"), 8, 2)
                txtDay.Text = Mid(objDataRow.Item("P_AGE"), 15, 2)
                lblPSex.Text = objDataRow.Item("P_SEX")
                txtRefer.Text = objDataRow.Item("P_REF_BY")
                cmbCP.Text = objDataRow.Item("P_CP").ToString.Trim
                txtTotal.Text = objDataRow.Item("P_TOTAL")
                txtPaid.Text = objDataRow.Item("P_PAID")
                txtCompli.Text = objDataRow.Item("P_COMPLIMENT")
                txtDiscount.Text = Format(Val(objDataRow.Item("P_DISCOUNT")), "00")
                txtDues.Text = Format(Val(objDataRow.Item("P_DUES")), "00")
                txtDate.Text = Format(objDataRow.Item("P_DATE_SAMPLE"), "MM/dd/yyyy")
                cmbVisitor.Text = objDataRow.Item("P_VISITOR").ToString.Trim

                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "SELECT MAX(TDELETE) AS MAX_ID FROM RECEIPT WHERE TCASENO = " & Val(gblFind.Trim), "RECEIPT", Connection)
                Dim Get_Max As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
                While Get_Max.Read
                    If Not Get_Max Is Nothing Then
                        wTestID = 1
                    Else
                        wTestID = Val(Get_Max.Item("MAX_ID")) + 1
                    End If
                End While
        If Not Get_Max Is Nothing Then Get_Max.Close()

        Mode = True
        Sub_Addition = True
        SqlDataAdapt.Dispose()
        SqlDataSet.Clear()
            Next
        Connection.Close()
        Call Donor_Profile("READ")
        cmdSave.Text = "&Update"
        cmdClose.Text = "&Cancel"
        Else
        MsgBox("Please enter Valid Lab ID.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Escape Then txtPaid.Focus() : Exit Sub

        If e.KeyCode = Keys.Enter Then
            Try
                ' Check if txtCode Blank or Null
                If Len(txtCode.Text) = 0 Then MsgBox("PLEASER ENTER TEST CODE.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Me.ProcessTabKey(False) : Exit Sub
                intCpDiscount = 0
                strCpName = ""
                ' Selecting Test Information by Given Code
                Dim strSql As String = "Select * from TESTS WHERE TCODE = '" & txtCode.Text.Trim & "'"

                Dim objDataTable As New Data.DataTable("TESTS")

                strTCode = ""
                strTname = ""
                strCatg = ""
                strTrate = ""

                ' Get Test Information & transferred into Variables
                Try
                    Dim TestReader As SqlDataReader
                    ExecuteSqlQuery(EntryDataAdpt, EntryDataSet, strSql, "TESTS", Connection)
                    TestReader = EntryDataAdpt.SelectCommand.ExecuteReader
                    While TestReader.Read
                        strTCode = Convert.ToString(TestReader.Item("tcode")).ToUpper.Trim
                        strTname = Convert.ToString(TestReader.Item("tname")).ToUpper.Trim
                        strCatg = Convert.ToString(TestReader.Item("tcatg")).ToUpper.Trim
                        strTrate = Convert.ToString(TestReader.Item("trate"))
                        strRptLvl = Convert.ToString(TestReader.Item("trptlvl"))
                        strDiscLvl = Convert.ToString(TestReader.Item("tdiscmode"))
                    End While
                    If Not TestReader Is Nothing Then TestReader.Close()
                    EntryDataAdpt.Dispose()

                    If strCatg.Trim = "" Or strTname.Trim = "" Then MsgBox("Invalid Test Code. Please Press F2 to select correct test code.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub

                    wTotal = wTotal + Val(strTrate)

                    ' Getting Discount Mode if Collection from outside / inside of Lab

                    ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "Select * from CollectionPoint where cp_id = '" & Trim(cmbCP.Text.ToUpper) & "'", "CollectionPoint", Connection)
                    If SqlDataSet.Tables("CollectionPoint").Rows.Count > 0 Then
                        Dim DiscReader As SqlDataReader
                        DiscReader = SqlDataAdapt.SelectCommand.ExecuteReader
                        While DiscReader.Read
                            strCpName = Convert.ToString(DiscReader.Item("CP_NAME"))
                            intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_PER_ORDINARY"))
                            If strDiscLvl.ToUpper = "SPECIAL" Then intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_PER_SPECIAL"))
                            If strDiscLvl.ToUpper = "CONDITIONAL" Then intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_CONDITIONAL"))
                            If strDiscLvl.ToUpper = "LIMITED" Then intCpDiscount = 0
                        End While
                        If Not DiscReader Is Nothing Then DiscReader.Close()
                    End If


                    ' For Check Duplicate Test Parameter
                    'FindCode = strTCode

                    'Dim foundItem As ListViewItem
                    'If TestListView.Items.Count > 0 Then
                    '    foundItem = TestListView.FindItemWithText(FindCode, False, 0, True)
                    '    If (foundItem IsNot Nothing) Then
                    '        MsgBox("( " & strTname & " ) ALREADY ADDED IN THE LIST", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    '        Connection.Close()
                    '        txtCode.Clear()
                    '        Me.ProcessTabKey(False)
                    '        txtCode.Focus()
                    '        Exit Sub
                    '    End If
                    'End If

                    ' Adding Values into Temporary List View ( New Criteria for skiping deletion of other's patients tests records )
                    Dim TestItem As New ListViewItem
                    TestItem.Text = strTCode.Trim.ToUpper
                    TestItem.SubItems.Add(strTname.Trim.ToUpper)
                    TestItem.SubItems.Add(strCatg.Trim.ToUpper)
                    If Mode = False Then
                        TestItem.SubItems.Add("ADD")
                    Else
                        TestItem.SubItems.Add("EDT")
                    End If
                    TestItem.SubItems.Add(strRptLvl.Trim)
                    TestItem.SubItems.Add(strTrate.Trim)
                    TestItem.SubItems.Add(wTestID)
                    TestListView.Items.Add(TestItem)

                    txtTotal.Text = Val(txtTotal.Text.Trim) + wTotal
                    gblDiscount = Val(txtTotal.Text) * intCpDiscount / 100
                    txtDiscount.Text = Val(txtDiscount.Text.Trim) + Val(gblDiscount)
                    txtDues.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)

                    Connection.Close()
                    txtCode.Clear()
                    Sub_Addition = True
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                    EntryDataSet = Nothing
                End Try
                txtCode.Focus()
                'End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Me.Close()
            End Try

        End If
        txtCode.Focus()
    End Sub

    Private Sub cmdLSlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLSlip.Click

        gblFind = txtRecNo.Text.Trim
        'Dim CrossMatchSlip As String = "Selec * from Donor_Table where DONOR_ID = " & gblFind
        If Len(gblFind) > 0 Then
            gblReportOption = "RECEIPT"
            'DiskReport = "CrossMatchForm"
            gblReportName = Directory.GetCurrentDirectory & "\" & "Reports\CrossMatchForm.rpt"
            Call Print_Manually()
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If cmdClose.Text = "&Cancel" Then
            cmdSave.Text = "&Save Record"
            cmdClose.Text = "&Close"
            cmdNew_Click(sender, e)
            Connection.Close()
            Exit Sub
        End If
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub txtName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.GotFocus
        Call cmbTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtDName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDName.GotFocus
        Call cmbDTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub txtDName_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDName.MouseDoubleClick
        txtDName.Clear()
        txtDYrs.Text = "00"
        cmbDTitle.Focus()
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            frmTestCodeList.ShowDialog(Me)
            If Len(gblTestCode) > 0 Then txtCode.Text = gblTestCode.ToUpper
            Me.ProcessTabKey(False)
            txtCode_KeyDown(sender, e)
        End If
    End Sub

    Private Sub txtRefer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyUp
        If e.KeyCode = Keys.F5 Then
            frmRefer.ShowDialog(Me)
            If Len(gblRefer) > 0 Then
                cmbCP.Text = gblCP_ID
                txtRefer.Text = StrConv(gblRefer.Trim, VbStrConv.ProperCase)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtPaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtPaid.Text.Trim) > Val(txtTotal.Text.Trim) Then
                MsgBox("Paid amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End If
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            txtDiscount.Focus()
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtDiscount.Text.Trim) > (Val(txtTotal.Text.Trim) + Val(txtPaid.Text.Trim)) Then
                MsgBox("Discount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End If
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            txtCompli.Focus()
        End If
    End Sub

    Private Sub txtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            txtPaid.Focus()
        End If
    End Sub

    Private Sub txtCompli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCompli.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            cmdSave.Focus()
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub txtDues_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDues.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            cmdSave.Focus()
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub Donor_Profile(ByVal strChoice As String)
        Dim CommandText As String
        If strChoice = "ADD" Then
            If txtDName.Text = "" Or Len(txtDName.Text) = 0 Then
                'Skip Line
            Else
                Dim IF_RECORD_EXIST As String = "SELECT COUNT(DONOR_ID) AS EXPR_1 FROM DONOR_TABLE WHERE DONOR_ID = " & Val(txtRecNo.Text) & " AND DONOR_NAME LIKE '%" & _
                                                StrConv(cmbDTitle.Text.Trim & Space(1) & txtDName.Text.Trim, VbStrConv.ProperCase) & "%'"
                Execute_DatabaseTable_Query(SqlDataAdapt, IF_RECORD_EXIST, Connection)
                Dim Reader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
                While Reader.Read
                    Return_Response = Reader.Item("EXPR_1")
                End While
                If Not Reader Is Nothing Then Reader.Close()
                If Return_Response = 0 Then
                    'Try
                    Execute_DatabaseTable_Query(SqlDataAdapt, "SELECT MAX(DONOR_PID) AS MAX_ID FROM DONOR_TABLE WHERE DONOR_ID = " & Val(txtRecNo.Text.Trim), Connection)
                    Dim Get_Max As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
                    While Get_Max.Read
                        wDonor_Pid = Get_Max.Item("MAX_ID").ToString
                    End While
                    If Not Get_Max Is Nothing Then Get_Max.Close()
                    wDonor_Pid = Val(wDonor_Pid) + 1

                    CommandText = "INSERT INTO DONOR_TABLE(DONOR_ID,DONOR_NAME,DONOR_AGE,DONOR_GENDER,DONOR_PID,DONOR_DATE) VALUES (" & _
                                     Val(txtRecNo.Text) & ",'" & _
                                     StrConv(cmbDTitle.Text.Trim & Space(1) & txtDName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                     txtDYrs.Text.Trim & Space(2) & "Yrs" & "','" & _
                                     lblDSex.Text.Trim & "'," & _
                                     wDonor_Pid & ",'" & _
                                     Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "')"

                    Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                    MultipleMode = True
                    'Catch Msg As Exception
                    '    MsgBox(Msg.Message)
                    'End Try
                End If
            End If
        End If
        Dim objCellStyle As New DataGridViewCellStyle()
        'Try
        SqlDataAdapt.SelectCommand = New SqlCommand()
        SqlDataAdapt.SelectCommand.Connection = Connection
        SqlDataAdapt.SelectCommand.CommandText = "SELECT * FROM DONOR_TABLE WHERE DONOR_ID = " & Val(txtRecNo.Text)
        If Connection.State = ConnectionState.Open Then Connection.Close()
        Connection.Open()
        SqlDataAdapt.SelectCommand.CommandType = CommandType.Text
        DataSet1.Clear()
        SqlDataAdapt.Fill(DataSet1, "DONOR_TABLE")
        Connection.Close()
        objCellStyle.BackColor = Color.WhiteSmoke
        DonorDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
        DonorDataGrid.DataSource = DataSet1
        DonorDataGrid.DataMember = "DONOR_TABLE"

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try
        Connection.Close()

    End Sub

    Private Sub TestListView_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TestListView.MouseDoubleClick

        Dim si As Integer = TestListView.SelectedIndices(0)
        Dim delAmnt As Double

        FindCode = TestListView.Items(si).SubItems(0).Text.Trim
        delAmnt = Val(TestListView.Items(si).SubItems(5).Text.Trim)
        DelString = TestListView.Items(si).SubItems(0).Text.Trim
        wTestID = TestListView.Items(si).SubItems(6).Text.Trim

        If MsgBox("Are you sure ot delete " & DelString, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Delete Test") = MsgBoxResult.Yes Then

            wTotal = wTotal - delAmnt
            txtTotal.Text = Val(txtTotal.Text) - delAmnt
            txtDues.Text = Val(txtTotal.Text) - Val(txtDiscount.Text) - Val(txtPaid.Text) - (txtCompli.Text)
            TestListView.Items(si).Remove()
            If Mode = True Then
                '// Delete Selected Record from Receipt
                Dim CommandText As String = "DELETE FROM RECEIPT WHERE TCODE = '" & DelString.Trim & "' AND TCASENO = " & Val(txtRecNo.Text) & " AND TDELETE = " & wTestID
                SqlDataAdapt.Dispose()
                SqlDataSet.Clear()
                Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                Call cmdSave_Click(sender, e)
            End If
            DonorDataGrid.Refresh()
            TestListView.Refresh()
        End If

    End Sub

    Private Sub DonorDataGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DonorDataGrid.CellMouseDoubleClick

        If DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value Is Nothing Then Exit Sub
        Dim strName As String = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value.ToString
        If MsgBox("Are you sure ot delete " & strName, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Delete Donor") = MsgBoxResult.Yes Then
            Execute_DatabaseTable_Query(SqlDataAdapt, "DELETE FROM DONOR_TABLE WHERE DONOR_ID = " & Val(txtRecNo.Text) & " AND DONOR_NAME LIKE '%" & _
                                        StrConv(strName.Trim, VbStrConv.ProperCase) & "%'", Connection)
            DonorDataGrid.Rows.Remove(DonorDataGrid.CurrentRow)
            txtDName.Clear()
            cmbDTitle.Focus()
            DonorDataGrid.Refresh()
        End If

    End Sub

    Private Sub cmbCP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCP.SelectedIndexChanged
        intCpDiscount = 0
        Call Get_CpRefer()
        If strCpName = "" Then MsgBox("Please Select Valid Reference.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        txtRefer.Text = StrConv(strCpName.Trim, VbStrConv.ProperCase)
    End Sub

    Private Sub Get_CpRefer()

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "Select * from CollectionPoint where CP_ID = '" & Trim(cmbCP.Text.ToUpper) & "'", "CollectionPoint", Connection)
        If SqlDataSet.Tables("CollectionPoint").Rows.Count > 0 Then
            Dim DiscReader As SqlDataReader
            DiscReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While DiscReader.Read
                strCpName = Convert.ToString(DiscReader.Item("CP_NAME"))
                intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_PER_ORDINARY"))
                If strDiscLvl.ToUpper = "SPECIAL" Then intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_PER_SPECIAL"))
            End While
            If Not DiscReader Is Nothing Then DiscReader.Close()
        End If

    End Sub

    Private Sub Print_Manually()

        Call GetConnectionString()

        'Try
        Dim CommandText As String = ""
        SqlDataSet.Clear()

        ConnInfo.ConnectionInfo.UserID = ServerID
        ConnInfo.ConnectionInfo.Password = ServerPwd
        ConnInfo.ConnectionInfo.ServerName = ServerName
        ConnInfo.ConnectionInfo.DatabaseName = "LAB"

        If gblReportOption.ToUpper = "RECEIPT" Then CommandText = "Select * from PATIENT WHERE p_num = " & Val(gblFind.Trim)

        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT", Connection)

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
        objReport.SetDataSource(SqlDataSet.Tables("patient"))

        With objReport
            ' IF REPORT BELONGS TO CROSS MATCH RECEIPT
            If gblReportOption.ToUpper = "RECEIPT" Then
                .RecordSelectionFormula = "{patient.p_num}=" & Val(gblFind)
                '' For sent Report directly to Printer
                'frmPrintDialog.Cursor = Cursors.WaitCursor
                'frmPrintDialog.Show()
                objReport.PrintToPrinter(1, False, 0, 0)
                '// For export report in pdf format if required uncommit the line
                'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\Receipt.pdf")
                frmPrintDialog.Cursor = Cursors.Default
                frmPrintDialog.Close()
            End If
        End With
        objReport.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try

    End Sub

End Class