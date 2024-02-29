Imports System
Imports System.IO
Imports System.Drawing
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class frmPatient
    Dim TestItem As New ListViewItem
    Dim FindCode As String = ""
    Dim strCpName As String = ""
    Dim strDiscLvl As String = ""
    Dim CodeCounter As Integer = 0
    Dim intCpDiscount As Integer = 0
    Dim Sub_Addition As Boolean = False
    Dim StartID, StartSno As String
    Dim dateNow As Date = DateTime.Now
    Dim dtResult As Date

    Private Sub frmPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Connection = New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=LAB;NETWORK LIBRARY=DBMSSOCN;Integrated Security=SSPI;")
        Call GetConnectionString()
        Call Record_Count()
        Try

            Dim cpReader As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select CP_ID from CollectionPoint order by CP_ID", "CollectionPoint", Connection)
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
            Panel1.Enabled = False
            strRptLvl = 1
            Call cmdNew_Click(sender, e)
            If gblPrliviges > 2 Then
                txtCompli.Enabled = False
                txtDiscount.Enabled = False
            End If
            Me.cmbTitle.Focus()
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
        Me.Focus()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Not (e.KeyChar = "." Or e.KeyChar = "/" Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmbTitle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call cmbTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbTitle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitle.GotFocus
        cmbTitle.SelectAll()
    End Sub

    Private Sub cmbTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTitle.KeyDown
        If e.KeyCode = Keys.Enter Then cmbTitle_SelectedIndexChanged(sender, e) : txtName.Focus()
    End Sub

    Private Sub cmbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTitle.SelectedIndexChanged
        Select Case cmbTitle.Text
            Case "Mr." : lblSex.Text = "Male"
            Case "B/O" : lblSex.Text = "Male"
            Case "S/O" : lblSex.Text = "Male"
            Case "F/O" : lblSex.Text = "Male"
            Case "Master" : lblSex.Text = "Male"
            Case "Sis/O" : lblSex.Text = "Female"
            Case "Mrs." : lblSex.Text = "Female"
            Case "M/O" : lblSex.Text = "Female"
            Case "Wid/O" : lblSex.Text = "Female"
            Case "W/O" : lblSex.Text = "Female"
            Case "Miss." : lblSex.Text = "Female"
            Case "Ms." : lblSex.Text = "Female"
            Case "Baby" : lblSex.Text = "Female"
            Case "D/O" : lblSex.Text = "Female"
        End Select
    End Sub

    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        txtContact.SelectAll()
    End Sub

    Private Sub txtContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContact.KeyDown
        If e.KeyCode = Keys.Enter Then cmbDTitle.Focus()
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtPanel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPanel.KeyDown
        If e.KeyCode = Keys.Enter Then cmbCP.Focus()
    End Sub

    Private Sub txtSlip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPanel.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtRefer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefer.GotFocus
        txtRefer.SelectAll()
    End Sub

    Private Sub txtRefer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtRefer.Text = "" Then MsgBox("Please Select Referenced Doctor.", MsgBoxStyle.Information, My.Application.Info.ProductName) : txtRefer.Focus() Else txtCode.Focus()
        End If
    End Sub

    Private Sub txtRefer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefer.KeyPress
        If Not (e.KeyChar = "/" Or e.KeyChar = "." Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
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

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        txtCode.SelectAll()
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Escape Then txtDiscount.Focus() : Exit Sub

        If e.KeyCode = Keys.Enter Then

            If txtName.Text = "" Or txtRefer.Text = "" Then _
                                MsgBox("Basic Information Missing.", MsgBoxStyle.Information, My.Application.Info.ProductName) _
                                  : Me.ProcessTabKey(False) : Exit Sub

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
                        strRptLvl = Convert.ToString(TestReader.Item("trptlvl")).Trim
                        strDiscLvl = Convert.ToString(TestReader.Item("tdiscmode")).Trim
                    End While
                    If Not TestReader Is Nothing Then TestReader.Close()
                    EntryDataAdpt.Dispose()

                    If strCatg.Trim = "" Or strTname.Trim = "" Then MsgBox("Invalid Test Code. Please Press F2 to select correct test code.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub

                    ' Getting Discount Mode for collection on lab or outside

                    ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "Select * from CollectionPoint where CP_ID = '" & Trim(cmbCP.Text.ToUpper) & "'", "CollectionPoint", Connection)
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
                    FindCode = strTCode

                    Dim foundItem As ListViewItem
                    If TestListView.Items.Count > 0 Then
                        foundItem = TestListView.FindItemWithText(FindCode, False, 0, True)
                        If (foundItem IsNot Nothing) Then
                            MsgBox("( " & strTname & " ) ALREADY ADDED IN THE LIST", MsgBoxStyle.Information, My.Application.Info.ProductName)
                            Connection.Close()
                            txtCode.Clear()
                            Me.ProcessTabKey(False)
                            txtCode.Focus()
                            Exit Sub
                        End If
                    End If

                    ' Adding Values into Temporary List View ( New Criteria for skiping deletion of other's patients tests records )
                    Dim TestItem As New ListViewItem
                    TestItem.Text = strTCode.Trim.ToUpper
                    TestItem.SubItems.Add(strTname.Trim.ToUpper)
                    TestItem.SubItems.Add(strCatg.Trim.ToUpper)
                    TestItem.SubItems.Add("ADD")
                    TestItem.SubItems.Add(strRptLvl.Trim)
                    TestItem.SubItems.Add(strTrate.Trim)
                    TestListView.Items.Add(TestItem)

                    '// Discount Calculation
                    lblTotal.Text = Val(lblTotal.Text) + Val(strTrate)
                    gblDiscount = Val(strTrate) * intCpDiscount / 100
                    txtDiscount.Text = Val(gblDiscount)
                    lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text) - Val(txtCompli.Text.Trim)


                    Connection.Close()
                    txtCode.Clear()
                    cmdDelete.Enabled = True
                    Sub_Addition = True
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                    EntryDataSet = Nothing
                End Try
                txtCode.Focus()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Me.Close()
            End Try

        End If
        txtCode.Focus()

    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            frmTestCodeList.ShowDialog(Me)
            If Len(gblTestCode) > 0 Then txtCode.Text = gblTestCode.ToUpper
            Me.ProcessTabKey(False)
            txtCode_KeyDown(sender, e)
        End If

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        'REFRESH FIELDS FOR NEW RECORD
        Try
            Call Lock_Unlock_Text(False)
            Me.txtCode.Clear()
            Me.txtName.Clear()
            Me.lblOperator.Text = ""
            Me.txtContact.Text = "00"
            Me.txtPanel.Text = "00"
            Me.txtMth.Text = "00"
            Me.txtDAge.Text = "00"
            Me.txtYrs.Text = "00"
            Me.lblSex.Text = ""
            Me.lblTotal.Text = "00"
            Me.lblDues.Text = "00"
            Me.txtPaid.Text = "00"
            Me.txtDiscount.Text = "00"
            Me.txtCompli.Text = "00"
            Me.txtPaid.Text = "00"
            Me.txtSlip.Text = "00"
            Me.txtCode.Text = ""
            Me.txtRefer.Text = ""
            Me.cmbTitle.Text = "Mr."
            Me.cmbDTitle.Text = "Mr."
            Me.cmbVisitor.Text = ""
            Me.txtYrs.Text = "00"
            Me.txtMth.Text = "00"
            Me.txtDay.Text = "00"
            Me.txtDName.Text = "x"
            Me.lblDSex.Text = "x"

            Dim MaxId As String = ""
            Dim MaxSn As String = ""
            Dim cpReader As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select Max(P_NUM) AS MAX_ID from PATIENT", "PATIENT", Connection)
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
                txtSNo.Text = Val(MaxSn) + 1
            End If
            Me.cmbCP.Text = "Select Referenced Doctor Code"
            txtDate.Text = Format(Now, "dd/MMM/yyyy")
            txtTime.Text = Format(Now, "hh:mm tt")
            txtDelDate.Text = Format(Now, "dd/MMM/yyyy")
            gblDiscount = 0
            intCpDiscount = 0
            strCpName = ""
            Me.cmbTitle.Focus()
            cmdSave.Enabled = False
            cmdDelete.Enabled = False
            cmdDeliver.Enabled = False
            Panel1.Enabled = True
            txtPaid.Enabled = True
            txtDiscount.Enabled = True
            txtCompli.Enabled = True
            txtCode.Enabled = True
            TestListView.Items.Clear()
            cmbTitle.Focus()
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Application.Exit()
        End Try
        cmbTitle.Focus()

    End Sub

    Private Sub txtYrs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYrs.GotFocus
        txtYrs.SelectAll()
    End Sub

    Private Sub txtYrs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYrs.KeyDown
        If e.KeyCode = Keys.Enter Then txtYrs.Text = Format(Val(txtYrs.Text), "00") : txtMth.Focus()
    End Sub

    Private Sub txtYrs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYrs.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtMth_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMth.GotFocus
        txtMth.SelectAll()
    End Sub

    Private Sub txtMth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMth.KeyDown
        If e.KeyCode = Keys.Enter Then txtMth.Text = Format(Val(txtMth.Text), "00") : txtDay.Focus()
    End Sub

    Private Sub txtMth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMth.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim ChkRptLvl As Integer = 0, Return_Response As Integer = 0
        Dim Del_Rpt_Date As Integer = 0

        If txtRefer.Text = "" Then MsgBox("Please Select Referenced Doctor.", MsgBoxStyle.Information, My.Application.Info.ProductName)

        lblDues.Text = Val(lblTotal.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtCompli.Text.Trim)

        If Val(txtRecNo.Text.Trim) = 0 Or (txtRecNo.Text.Trim) = "" Then Exit Sub

        If SysOperator.Trim = "DEMO" Or SysOperator.Trim = "demo" Then
            MsgBox("Your are in learning mode, therefore entry cannot be saved.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName)
            Exit Sub
        End If

        Dim IF_EXIST_RECORD As String = "SELECT COUNT(P_NUM) AS EXPR_1 FROM PATIENT WHERE P_NUM = " & Val(txtRecNo.Text)
        Execute_DatabaseTable_Query(SqlDataAdapt, IF_EXIST_RECORD, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While Reader.Read
            Return_Response = Reader.Item("EXPR_1")
        End While
        If Not Reader Is Nothing Then Reader.Close()
        If Return_Response > 0 Then MsgBox("Record already Exist.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName) : Exit Sub

        Try

            '// Add Test Data into Receipt Table
            Dim iCount As Integer = TestListView.Items.Count
            Dim iLoop As Integer = 0
            Dim CommandText As String
            If iCount > 0 And Sub_Addition = True Then
                Do Until iLoop = iCount
                    CommandText = "INSERT INTO RECEIPT(TCASENO,TCODE,TNAME,TCATG,TRATE,TQTY,TDATE,TMODE) VALUES (" & _
                             Val(txtRecNo.Text) & ",'" & _
                             TestListView.Items(iLoop).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(1).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(2).Text & "'," & _
                             Val(TestListView.Items(iLoop).SubItems(5).Text) & ",1,'" & _
                             Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "','ADD')"
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
            svDataRow.Item("P_NUM") = Val(txtRecNo.Text.Trim)
            svDataRow.Item("P_SNO") = Val(txtSNo.Text.Trim)
            svDataRow.Item("P_NAME") = StrConv(cmbTitle.Text.Trim & Space(1) & txtName.Text.Trim, VbStrConv.ProperCase)
            If txtDName.Text.Trim = "X" Or txtDName.Text.Trim = "x" Then
                svDataRow.Item("P_DNAME") = "X"
            Else
                svDataRow.Item("P_DNAME") = StrConv(cmbDTitle.Text.Trim & Space(1) & txtDName.Text.Trim, VbStrConv.ProperCase)
            End If
            svDataRow.Item("P_AGE") = txtYrs.Text.Trim & Space(1) & "Yrs" & Space(1) & txtMth.Text.Trim & Space(1) & "Mth" & Space(1) & txtDay.Text.Trim & Space(1) & "Day"
            svDataRow.Item("P_SEX") = lblSex.Text.Trim.ToUpper
            If txtDName.Text.Trim = "X" Or txtDName.Text.Trim = "x" Then
                svDataRow.Item("P_DON_SEX") = "X"
            Else
                svDataRow.Item("P_DON_SEX") = lblDSex.Text.Trim.ToUpper
            End If
            svDataRow.Item("P_DON_AGE") = txtDAge.Text.Trim & "" & "Yrs"
            svDataRow.Item("P_PHONE") = Val(txtContact.Text.Trim)
            svDataRow.Item("P_SLIP_NUM") = Val(txtSlip.Text.Trim)
            svDataRow.Item("P_PANNEL") = Val(txtPanel.Text.Trim)
            svDataRow.Item("P_REF_BY") = StrConv(txtRefer.Text.Trim, VbStrConv.ProperCase)
            svDataRow.Item("P_REFER_2") = "x"
            svDataRow.Item("P_CP") = StrConv(cmbCP.Text.Trim, VbStrConv.Uppercase)
            svDataRow.Item("P_TOTAL") = Val(lblTotal.Text.Trim)
            svDataRow.Item("P_PAID") = Val(txtPaid.Text.Trim)
            svDataRow.Item("P_DUES") = Val(lblDues.Text.Trim)
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
            svDataRow.Item("P_DEL_DATE") = Format(DateTime.Parse("01/07/2006"), "MM/dd/yyyy")
            svDataRow.Item("P_DUE_RCV_DATE") = Format(DateTime.Parse("01/07/2006"), "MM/dd/yyyy")
            svDataRow.Item("P_DELETE_ON") = Format(DateTime.Parse("01/07/2006"), "MM/dd/yyyy")
            svDataRow.Item("P_EDIT_ON") = Format(DateTime.Parse("01/07/2006"), "MM/dd/yyyy")
            svDataRow.Item("P_COMP_ON") = Format(DateTime.Parse("01/07/2006"), "MM/dd/yyyy")
            svDataRow.Item("P_DELETE_ON") = Format(DateTime.Parse("01/07/2006"), "MM/dd/yyyy")
            svDataRow.Item("P_BAD_DATE") = Format(DateTime.Parse("01/07/2006"), "MM/dd/yyyy")
            svDataRow.Item("P_AFT_DATE") = Format(DateTime.Parse("01/07/2006"), "MM/dd/yyyy")
            svDataRow.Item("P_DATE_SAMPLE") = Format(DateTime.Parse(txtDate.Text), "MM/dd/yyyy")
            svDataRow.Item("P_TIME_SAMPLE") = Format(DateTime.Parse(txtTime.Text), "hh:mm tt")
            svDataRow.Item("P_RPT_DATE") = Format(DateTime.Parse(txtDelDate.Text), "MM/dd/yyyy")
            If cmbVisitor.Text = "" Then svDataRow.Item("P_VISITOR") = "X" Else svDataRow.Item("P_VISITOR") = StrConv(cmbVisitor.Text.Trim, VbStrConv.Uppercase)

            If Val(txtCompli.Text.Trim) > 0 Then
                svDataRow.Item("P_DEL_OK") = "YES"
                svDataRow.Item("P_DEL_DATE") = Format(DateTime.Parse(Now), "MM/dd/yyyy")
                svDataRow.Item("P_DEL_TIME") = Format(DateTime.Parse(Now), "hh:mm tt")
                svDataRow.Item("P_DEL_OPERATOR") = SysOperator
                svDataRow.Item("P_COMP_BY") = SysOperator
                svDataRow.Item("P_COMP_ON") = Format(DateTime.Parse(Now), "MM/dd/yyyy")
                svDataRow.Item("P_EDIT_BY") = SysOperator
                svDataRow.Item("P_EDIT_ON") = Format(DateTime.Parse(Now), "MM/dd/yyyy")
            End If

            If Val(strRptLvl) > 1 Then
                dtResult = DateAdd(DateInterval.Day, Val(strRptLvl), Now)
            Else
                dtResult = Format(DateTime.Parse(Now), "MM/dd/yyyy")
            End If

            txtDelDate.Text = Format(dtResult, "dd/MMM/yyyy")

            '// ADD THREE HOURS IN REPORT TIME
            txtDelTime.Text = Format(Now.AddHours(2), "hh:mm tt")
            svDataRow.Item("P_RPT_DATE") = Format(DateTime.Parse(txtDelDate.Text), "MM/dd/yyyy")
            svDataRow.Item("P_RPT_TIME") = Format(DateTime.Parse(txtDelTime.Text), "hh:mm tt")
            svDataRow.Item("P_DEL_TIME") = Format(DateTime.Parse(txtDelTime.Text), "hh:mm tt")
            svDataRow.Item("P_OPERATOR") = SysOperator.Trim

            '// SAVE DATA ROW IN THE TABLE
            svDataSet.Tables("PATIENT").Rows.Add(svDataRow)
            SqlDataAdapt.Update(svDataSet, "PATIENT")

            cmdDelete.Enabled = False
            cmdSave.Enabled = False
            Call Record_Count()
            Me.ProcessTabKey(False)
            Call Lock_Unlock_Text(True)
            cmdLSlip.Enabled = True
            cmdPSlip.Enabled = True
            gblDiscount = 0
            intCpDiscount = 0
            strRptLvl = 1
            cmdSave.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        Connection.Close()

    End Sub

    Private Sub cmdDeliver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeliver.Click

        Dim CommandText As String = ""
        Dim strDate As Date = CDate(txtDate.Text)
        Dim strDiff As String = DateDiff(DateInterval.Day, Date.Today, strDate)
        If SysOperator.Trim = "DEMO" Or SysOperator.Trim = "demo" Then Exit Sub
        Try
            Dim DueAmount As Decimal = 0
            If Val(lblDues.Text) > 0 Then
                DueAmount = Val(Microsoft.VisualBasic.InputBox("Please Enter Dues Received Amount", "Dues Received", 0))
                If Len(DueAmount) = 0 Or Val(DueAmount) = 0 Then Exit Sub
                If Val(DueAmount) <> Val(lblDues.Text) Then MsgBox("Received amount is not correct.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
                txtPaid.Text = Val(txtPaid.Text) + Val(DueAmount)
                lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)
                txtDiscount.Text = Val(lblTotal.Text) - Val(txtPaid.Text) - Val(lblDues.Text)


                '// IF DUES RECEIVED AFTER SAMPLE DATE


                If Val(strDiff) <> 0 And DueAmount > 0 Then
                    CommandText = "UPDATE PATIENT SET P_DEL_OK = 'Yes', P_DEL_DATE = '" & _
                                  Format(Now, "MM/dd/yyyy") & "', P_DEL_TIME = '" & Format(Now, "hh:mm tt") & "'," & _
                                  "P_DEL_OPERATOR = '" & SysOperator & "', P_PAID = " & Val(txtPaid.Text) & _
                                  ", P_DUES = 0, P_DUE_RCV = " & DueAmount & ",P_DUE_RCV_DATE = '" & Format(Now, "MM/dd/yyyy") & _
                                  "', P_DUE_RCV_OPERATOR = '" & SysOperator & "' WHERE P_NUM = " & Val(txtRecNo.Text)
                End If
                If Val(strDiff) = 0 And DueAmount > 0 Or Val(strDiff) = 0 Then
                    '// IF DUES RECEIVED WITHIN DATE
                    CommandText = "UPDATE PATIENT SET P_DEL_OK = 'Yes', P_DEL_DATE = '" & _
                                  Format(Now, "MM/dd/yyyy") & "', P_DEL_TIME = '" & Format(Now, "hh:mm tt") & "'," & _
                                  "P_DEL_OPERATOR = '" & SysOperator & "', P_PAID = " & Val(txtPaid.Text) & _
                                  ", P_DUES = 0 WHERE P_NUM = " & Val(txtRecNo.Text)
                End If
                Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
                SqlDataAdapt.Dispose()
                cmdDeliver.Enabled = False
            Else
                '// IF NORMAL REPORT
                CommandText = "UPDATE PATIENT SET P_DEL_OK = 'Yes', P_DEL_DATE = '" & _
                              Format(Now, "MM/dd/yyyy") & "', P_DEL_TIME = '" & Format(Now, "hh:mm tt") & "'," & _
                              "P_DEL_OPERATOR = '" & SysOperator & _
                              "' WHERE P_NUM = " & Val(txtRecNo.Text)
            End If
            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
            SqlDataAdapt.Dispose()
            cmdDeliver.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Connection.Close()
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim DelString As String
        Dim DelAmount As Double
        DelString = Microsoft.VisualBasic.InputBox("Please Test Code to Delete test from List.", "Delete")
        If Len(DelString.ToUpper) = 0 Then Exit Sub

        '// Delete Test Parameter by given Test Code
        Dim foundItem As ListViewItem
        If TestListView.Items.Count > 0 Then
            foundItem = TestListView.FindItemWithText(DelString.Trim.ToUpper, False, 0, True)
            If (foundItem IsNot Nothing) Then
                Dim i As Integer = 0
                i = TestListView.Items.IndexOf(foundItem)
                DelAmount = Val(TestListView.Items(i).SubItems(5).Text)
                lblTotal.Text = Val(lblTotal.Text) - Val(DelAmount)
                lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text)
                TestListView.Items(i).Remove()
                i = 0
            Else
                MsgBox("( " & DelString.Trim & " ) not in the List", MsgBoxStyle.Information, My.Application.Info.ProductName)
                cmdDelete.Focus()
            End If
        End If
        Connection.Close()

    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click

        Try
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
                    RecStatus = objDataRow.Item("P_DEL_OK").ToString.Trim
                    '// IF STATUS IS DELIVERED
                    If RecStatus.Trim = "YES" Or RecStatus.Trim = "Yes" Then
                        MsgBox("Report Delivered on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)
                        '// IF STATUS IS CANCELLED
                    ElseIf RecStatus.Trim = "CANCELLED" Or RecStatus.Trim = "Cancelled" Or RecStatus.Trim = "COMPLIMENTARY" Or RecStatus.Trim = "Complimentary" Then
                        MsgBox("Report " & RecStatus.Trim & " on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)

                    End If
                    '// IF STATUS IS NORMAL
                    Call Lock_Unlock_Text(True)
                    cmdLSlip.Enabled = False
                    cmdDelete.Enabled = False
                    cmdPSlip.Enabled = False
                    cmdDeliver.Enabled = True
                    txtPaid.Enabled = False
                    txtDiscount.Enabled = False
                    txtCompli.Enabled = False
                    txtCode.Enabled = False
                    lblTotal.Text = objDataRow.Item("P_TOTAL")
                    txtPaid.Text = objDataRow.Item("P_PAID")
                    lblDues.Text = objDataRow.Item("P_DUES")
                    txtDiscount.Text = objDataRow.Item("P_DISCOUNT")
                    txtCompli.Text = objDataRow.Item("P_COMPLIMENT")
                    txtRecNo.Text = objDataRow.Item("P_NUM")
                    txtSNo.Text = objDataRow.Item("P_SNO")
                    txtName.Text = objDataRow.Item("P_NAME")
                    txtDName.Text = objDataRow.Item("P_DNAME")
                    txtYrs.Text = Mid(objDataRow.Item("P_AGE"), 1, 2)
                    txtMth.Text = Mid(objDataRow.Item("P_AGE"), 8, 2)
                    txtDay.Text = Mid(objDataRow.Item("P_AGE"), 15, 2)
                    txtContact.Text = objDataRow.Item("P_PHONE").ToString.Trim
                    lblSex.Text = objDataRow.Item("P_SEX")
                    lblDSex.Text = objDataRow.Item("P_DON_SEX")
                    txtDAge.Text = Mid(objDataRow.Item("P_DON_AGE"), 1, 2)
                    txtRefer.Text = objDataRow.Item("P_REF_BY")
                    txtSlip.Text = objDataRow.Item("P_SLIP_NUM").ToString.Trim
                    txtPanel.Text = objDataRow.Item("P_PANNEL").ToString.Trim
                    cmbCP.Text = objDataRow.Item("P_CP").ToString.Trim
                    txtDate.Text = Format(objDataRow.Item("P_DATE_SAMPLE"), "dd/MMM/yyyy")
                    txtTime.Text = Format(objDataRow.Item("P_TIME_SAMPLE"), "hh:mm tt")
                    txtDelDate.Text = Format(objDataRow.Item("P_RPT_DATE"), "dd/MMM/yyyy")
                    txtDelTime.Text = Format(objDataRow.Item("P_RPT_TIME"), "hh:mm tt")
                    lblOperator.Text = objDataRow.Item("P_OPERATOR").ToString.Trim
                    cmbVisitor.Text = objDataRow.Item("P_VISITOR").ToString.Trim

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
                        TestItem.SubItems.Add("")
                        TestItem.SubItems.Add(Convert.ToString(forListView.Item("trate")).ToUpper.Trim)
                        TestListView.Items.Add(TestItem)
                    End While
                    If Not forListView Is Nothing Then forListView.Close()
                    SqlDataAdapt.Dispose()
                    SqlDataSet.Clear()
                Next
                Connection.Close()
            Else
                MsgBox("Please enter Valid Lab ID.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, My.Application.Info.ProductName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub txtPaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtPaid.Text.Trim) > (Val(lblTotal.Text.Trim) - Val(txtDiscount.Text.Trim)) Then
                MsgBox("Paid amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                txtPaid.Focus()
                txtPaid.SelectAll()
                Exit Sub
            End If
            lblDues.Text = Val(lblTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim)
            cmdSave.Enabled = True
            txtCompli.Focus()
        End If
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtDiscount.Text.Trim) > (Val(lblTotal.Text.Trim) - Val(txtPaid.Text.Trim)) Then
                MsgBox("Discount amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                txtDiscount.Focus()
                txtDiscount.SelectAll()
                Exit Sub
            End If
            lblDues.Text = Val(lblTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim)
            txtPaid.Focus()
        End If
    End Sub

    Private Sub txtCompli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCompli.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtCompli.Text.Trim) > Val(lblTotal.Text.Trim) Then
                MsgBox("Complimentary amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                txtCompli.Focus()
                txtCompli.SelectAll()
                Exit Sub
            End If
            lblDues.Text = Val(lblTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            cmdSave.Enabled = True
            cmdSave.Focus()
        End If
    End Sub

    Private Sub cmdPSlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPSlip.Click
        gblFind = txtRecNo.Text.Trim
        If Len(gblFind) > 0 Then
            gblReportOption = "RECEIPT"
            'DiskReport = "PatientSlip"
            gblReportName = ".\" & "Reports\PatientSlip.rpt"
            'gblReportName = Directory.GetCurrentDirectory & "\" & "Reports\PatientSlip.rpt"
            Call Print_Slips_Manually()
        End If
    End Sub

    Private Sub cmdLSlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLSlip.Click
        gblFind = txtRecNo.Text.Trim
        If Len(gblFind) > 0 Then
            gblReportOption = "RECEIPT"
            'DiskReport = "LabSlip"
            gblReportName = ".\" & "Reports\LabSlip.rpt"
            'gblReportName = Directory.GetCurrentDirectory & "\" & "Reports\LabSlip.rpt"
            Call Print_Slips_Manually()
        End If
    End Sub

    Private Sub txtPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaid.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
        If Val(txtPaid.Text) > (Val(lblTotal.Text) - Val(txtDiscount.Text.Trim)) Then
            MsgBox("Paid amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
        If Val(txtDiscount.Text.Trim) > Val((lblTotal.Text) - Val(txtPaid.Text.Trim)) Then
            MsgBox("Discount amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
    End Sub

    Private Sub txtCompli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompli.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
        If Val(txtCompli.Text.Trim) > Val((lblTotal.Text)) Then
            MsgBox("Complimentary amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
    End Sub

    Private Sub txtName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.GotFocus
        txtName.SelectAll()
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then txtName.Text = StrConv(txtName.Text, VbStrConv.ProperCase) : txtYrs.Focus()
    End Sub

    Private Sub txtName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.LostFocus
        txtName.Text = StrConv(txtName.Text, VbStrConv.ProperCase)
    End Sub
    
    Private Sub txtDay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDay.GotFocus
        txtDay.SelectAll()
    End Sub

    Private Sub txtDay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDay.KeyDown
        If e.KeyCode = Keys.Enter Then txtDay.Text = Format(Val(txtDay.Text), "00") : txtContact.Focus()
    End Sub

    Private Sub txtDay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDay.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmbCP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCP.GotFocus
        cmbCP.SelectAll()
    End Sub

    Private Sub cmbCP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCP.KeyDown
        If e.KeyCode = Keys.Enter Then  'Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            intCpDiscount = 0
            Call Get_CpRefer()
            If strCpName = "" Then MsgBox("Please Select Valid Reference.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
            txtRefer.Focus()
        End If
    End Sub

    Private Sub cmbCP_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCP.LostFocus
        intCpDiscount = 0
        Call Get_CpRefer()
    End Sub

    Private Sub txtSlip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSlip.KeyDown
        If e.KeyCode = Keys.Enter Then txtPanel.Focus()
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

    Private Sub Lock_Unlock_Text(ByVal Stat As String)

        txtName.ReadOnly = Stat
        txtMth.ReadOnly = Stat
        txtDay.ReadOnly = Stat
        txtYrs.ReadOnly = Stat
        txtDelDate.ReadOnly = Stat
        txtDelTime.ReadOnly = Stat
        txtContact.ReadOnly = Stat
        txtPanel.ReadOnly = Stat
        txtSlip.ReadOnly = Stat
        txtPaid.ReadOnly = Stat

    End Sub

    Private Sub txtRecNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRecNo.KeyDown
        e.Handled = False
    End Sub

    Private Sub txtRecNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecNo.KeyPress
        e.Handled = False
    End Sub

    Private Sub txtRecNo_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRecNo.MouseDoubleClick
        If gblPrliviges = 1 Then
            StartID = InputBox("Please give Start ID.", My.Application.Info.ProductName, vbOKCancel)
            If Len(StartID) = 0 Or StartID = "" Then Exit Sub
            txtRecNo.Text = StartID
        End If
    End Sub

    Private Sub txtSNo_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSNo.MouseDoubleClick
        If gblPrliviges = 1 Then
            StartSno = InputBox("Please give Start Serial No.", My.Application.Info.ProductName, vbOKCancel)
            If Len(StartSno) = 0 Or StartSno = "" Then Exit Sub
            txtSNo.Text = StartSno
        End If
    End Sub

    Private Sub txtDName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDName.GotFocus
        txtDName.SelectAll()
    End Sub

    Private Sub txtDName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDName.KeyDown
        If e.KeyCode = Keys.Enter Then txtDName.Text = StrConv(txtDName.Text, VbStrConv.ProperCase) : txtDAge.Focus()
    End Sub

    Private Sub txtDName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDName.KeyPress
        If Not (e.KeyChar = "." Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtDName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDName.LostFocus
        txtDName.Text = StrConv(txtDName.Text, VbStrConv.ProperCase)
        txtDAge.Focus()
    End Sub

    Private Sub cmbDTitle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDTitle.GotFocus
        cmbDTitle.SelectAll()
    End Sub

    Private Sub cmbDTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDTitle.KeyDown
        If e.KeyCode = Keys.Enter Then cmbDTitle_SelectedIndexChanged(sender, e) : txtDName.Focus()
    End Sub

    Private Sub cmbDTitle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDTitle.KeyPress
        Call cmbDTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbDTitle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDTitle.LostFocus
        'txtDName.Focus()
    End Sub

    Private Sub cmbDTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDTitle.SelectedIndexChanged
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
    End Sub

    Private Sub txtDAge_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDAge.GotFocus
        txtDAge.SelectAll()
    End Sub

    Private Sub txtDAge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDAge.KeyDown
        If e.KeyCode = Keys.Enter Then txtDay.Text = Format(Val(txtDAge.Text), "00") : txtSlip.Focus()
    End Sub

    Private Sub txtDAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDAge.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

End Class
