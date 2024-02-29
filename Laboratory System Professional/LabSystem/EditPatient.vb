Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class EditPatient
    Dim strCpName As String = ""
    Dim strDiscLvl As String = ""
    Dim intCpDiscount As Integer = 0
    Dim StrDelete(19) As String
    Dim DelTstList As New List(Of String)
    Dim j As Integer = 0
    Dim isChanged As Boolean
    Dim EX_P_TOT, EX_P_PAY, EX_P_DISC, EX_P_DUE, TOTAL_WITHIN, DISC_WITHIN, PAID_WITHIN, DUES_WITHIN As Double
    Dim Rmks, StartSno, FindCode, strRptDate As String
    Dim TransPostStatus As Boolean = False
    Dim Sub_Addition As Boolean = False
    Dim dateNow As Date = DateTime.Now
    Dim dtResult As Date

#Region "KEY EVENTS"

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Not (e.KeyChar = "." Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmbTitle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTitle.KeyPress
        Call cmbTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbTitle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitle.GotFocus
        cmbTitle.SelectAll()
    End Sub

    Private Sub cmbTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTitle.KeyDown
        If e.KeyCode = Keys.Enter Then cmbTitle_SelectedIndexChanged(sender, e) : txtName.Focus()
    End Sub

    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        txtContact.SelectAll()
    End Sub

    Private Sub txtContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContact.KeyDown
        If e.KeyCode = Keys.Enter Then txtCNIC.Focus()
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtPanel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPanel.KeyDown
        If e.KeyCode = Keys.Enter Then cmbDoctors.Focus()
    End Sub

    Private Sub txtSlip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSlip.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtRefer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefer.GotFocus
        txtRefer.SelectAll()
    End Sub

    Private Sub txtRefer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtRefer.Text = "" Then MsgBox("Please Select Referenced Doctor.", MsgBoxStyle.Information, My.Application.Info.ProductName) : txtRefer.Focus() Else cmbCollPoint.Focus()
        End If
    End Sub

    Private Sub txtRefer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefer.KeyPress
        If Not (e.KeyChar = "/" Or e.KeyChar = "." Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtRefer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyUp
        If e.KeyCode = Keys.F5 Then
            ReferCode.ShowDialog(Me)
            If Len(gblRefer) > 0 Then
                cmbDoctors.Text = gblRefer
                txtRefer.Text = StrConv(gblRefer.Trim, VbStrConv.ProperCase)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        txtCode.SelectAll()
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            TestCodeList.ShowDialog(Me)
            If Len(gblTestCode) > 0 Then txtCode.Text = gblTestCode.ToUpper
            Me.ProcessTabKey(False)
            txtCode_KeyDown(sender, e)
        End If
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

    Private Sub txtPaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim)
            cmdSave.Enabled = True
            txtCompli.Focus()
        End If
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim)
            txtPaid.Focus()
        End If
    End Sub

    Private Sub txtCompli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCompli.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            txtPAmount.Focus()
        End If
    End Sub

    Private Sub txtPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaid.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtCompli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompli.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
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

    Private Sub cmbDoctors_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDoctors.GotFocus
        cmbDoctors.SelectAll()
    End Sub

    Private Sub cmbDoctors_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDoctors.KeyDown
        If e.KeyCode = Keys.Enter Then  'Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            intCpDiscount = 0
            Call Get_CpRefer()
            txtRefer.Text = strCpName
            txtRefer.Focus()
        End If
    End Sub

    Private Sub cmbDoctors_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDoctors.LostFocus
        intCpDiscount = 0
        Call Get_CpRefer()
    End Sub

    Private Sub txtSlip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSlip.KeyDown
        If e.KeyCode = Keys.Enter Then txtPanel.Focus()
    End Sub

    Private Sub cmbDoctors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDoctors.SelectedIndexChanged
        intCpDiscount = 0
        Call Get_CpRefer()
        If strCpName.Trim = "" Then MsgBox("Please Select Valid Reference.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        txtRefer.Text = StrConv(strCpName.Trim, VbStrConv.ProperCase)
    End Sub

    Private Sub txtRecNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRecNo.KeyDown
        e.Handled = False
    End Sub

    Private Sub txtRecNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecNo.KeyPress
        e.Handled = False
    End Sub

    Private Sub txtCollPoint_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCollPoint.GotFocus
        txtCollPoint.SelectAll()
    End Sub

    Private Sub txtCollPoint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCollPoint.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCollPoint.Text = "" Then MsgBox("Please Select Referenced Doctor.", MsgBoxStyle.Information, My.Application.Info.ProductName) : txtRefer.Focus() Else txtHospital.Focus()
        End If
    End Sub

    Private Sub txtCNIC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNIC.GotFocus
        txtCNIC.SelectAll()
    End Sub

    Private Sub txtCNIC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNIC.KeyDown
        If e.KeyCode = Keys.Enter Then txtSlip.Focus()
    End Sub

    Private Sub txtPAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave.Enabled = True
            cmdSave.Focus()
        End If

    End Sub

    Private Sub txtPAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPAmount.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmbCollPoint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCollPoint.KeyDown
        If e.KeyCode = Keys.Enter Then  'Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            intCpDiscount = 0
            Call Get_CpRefer2()
            txtCollPoint.Text = strCpName
            txtCollPoint.Focus()
        End If
    End Sub

    Private Sub cmbCollPoint_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCollPoint.GotFocus
        cmbCollPoint.SelectAll()
    End Sub

    Private Sub cmbCollPoint_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCollPoint.LostFocus
        intCpDiscount = 0
        Call Get_CpRefer2()
    End Sub

    Private Sub cmbCollPoint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCollPoint.SelectedIndexChanged
        intCpDiscount = 0
        Call Get_CpRefer2()
        If strCpName = "" Then MsgBox("Please Select Valid Reference.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        txtCollPoint.Text = strCpName.Trim
    End Sub

    Private Sub txtSRefer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSRefer.GotFocus
        txtHospital.SelectAll()
    End Sub

    Private Sub txtSRefer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSRefer.KeyDown
        If e.KeyCode = Keys.Enter Then txtCode.Focus()
    End Sub

    Private Sub txtHospital_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHospital.GotFocus
        txtHospital.SelectAll()
    End Sub

    Private Sub txtHospital_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHospital.KeyDown
        If e.KeyCode = Keys.Enter Then txtSRefer.Focus()
    End Sub

    Private Sub txtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then lblDues.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)
    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
        isChanged = True
    End Sub
#End Region

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, illegal operation.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If

        Call GetConnectionString()
        Call Lock_Unlock_Text(True)

        Try
            Dim cpReader As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapter, myDataSet, "Select CP_ID, CP_NAME from CollectionPoint order by CP_ID", "CollectionPoint", Connection)
            cpReader = SqlDataAdapter.SelectCommand.ExecuteReader
            While cpReader.Read
                If Mid(cpReader.Item("CP_NAME"), 1, 2) <> "CP" And Mid(cpReader.Item("CP_NAME"), 1, 2) <> "Cp" Then _
                Me.cmbDoctors.Items.Add(cpReader.Item("CP_NAME"))
            End While
            If Not cpReader Is Nothing Then cpReader.Close()
            Dim cpReader2 As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapter, myDataSet, "Select CP_ID, CP_NAME from CollectionPoint WHERE CP_NAME LIKE '%CP%' order by CP_ID", "CollectionPoint", Connection)
            cpReader2 = SqlDataAdapter.SelectCommand.ExecuteReader
            While cpReader2.Read
                Me.cmbCollPoint.Items.Add(cpReader2.Item("CP_NAME"))
            End While
            If Not cpReader2 Is Nothing Then cpReader2.Close()
            ExecuteSqlQuery(SqlDataAdapter, myDataSet, "Select visitor_name from visitor_table order by visitor_name", "visitor_table", Connection)
            cpReader = SqlDataAdapter.SelectCommand.ExecuteReader
            While cpReader.Read
                Me.cmbVisitor.Items.Add(cpReader.Item("VISITOR_NAME"))
            End While
            If Not cpReader Is Nothing Then cpReader.Close()
            Call Lock_Unlock_Text(True)

        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
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
            Case "Miss" : lblSex.Text = "Female"
            Case "Ms." : lblSex.Text = "Female"
            Case "Baby" : lblSex.Text = "Female"
            Case "D/O" : lblSex.Text = "Female"
                isChanged = True
        End Select
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Escape Then txtDiscount.Focus() : Exit Sub
        If e.KeyCode = Keys.Enter Then

            If txtName.Text = "" Or txtRefer.Text = "" Then _
                                MsgBox("Basic Information Missing.", MsgBoxStyle.Information, My.Application.Info.ProductName) _
                                  : Me.ProcessTabKey(False) : Exit Sub
            Try
                ' Check if txtCode Blank or Null
                If Len(txtCode.Text) = 0 Then MsgBox("PLEASER ENTER TEST CODE.", MsgBoxStyle.Information, My.Application.Info.ProductName) : txtCode.Focus() : Exit Sub

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
                    ExecuteSqlQuery(EntryDataAdapter, EntryDataSet, strSql, "TESTS", Connection)
                    TestReader = EntryDataAdapter.SelectCommand.ExecuteReader
                    While TestReader.Read
                        strTCode = Convert.ToString(TestReader.Item("tcode")).ToUpper.Trim
                        strTname = Convert.ToString(TestReader.Item("tname")).ToUpper.Trim
                        strCatg = Convert.ToString(TestReader.Item("tcatg")).ToUpper.Trim
                        strTrate = Convert.ToString(TestReader.Item("trate"))
                        strRptLvl = Convert.ToString(TestReader.Item("trptlvl")).Trim
                        strDiscLvl = Convert.ToString(TestReader.Item("tdiscmode")).Trim
                    End While
                    If Not TestReader Is Nothing Then TestReader.Close()
                    EntryDataAdapter.Dispose()

                    If strCatg.Trim = "" Or strTname.Trim = "" Then MsgBox("Invalid Test Code. Please Press F2 to select correct test code.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
                    ' Getting Discount Mode for collection on lab or outside
                    ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "Select * from CollectionPoint where CP_ID = '" & Trim(cmbDoctors.Text.ToUpper) & "'", "CollectionPoint", Connection)
                    If SqlDataSet.Tables("CollectionPoint").Rows.Count > 0 Then
                        Dim DiscReader As SqlDataReader
                        DiscReader = SqlDataAdapter.SelectCommand.ExecuteReader
                        While DiscReader.Read
                            strCpName = Convert.ToString(DiscReader.Item("CP_NAME"))
                            intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_ORDINARY"))
                            If strDiscLvl.ToUpper = "SPECIAL" Then intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_SPECIAL"))
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
                    ' Set report date for patient receipt
                    If Val(strRptLvl) > 1 Then
                        dtResult = Format(DateAdd(DateInterval.Day, Val(strRptLvl.Trim), Now.Date), "MM/dd/yyyy")
                    Else
                        dtResult = Format(Now.Date, "MM/dd/yyyy")
                    End If
                    ' Adding Values into Temporary List View ( New Criteria for skiping deletion of other's patients tests records )
                    Dim TestItem As New ListViewItem
                    TestItem.Text = strTCode.Trim.ToUpper
                    TestItem.SubItems.Add(strTname.Trim.ToUpper)
                    TestItem.SubItems.Add(strCatg.Trim.ToUpper)
                    TestItem.SubItems.Add(CDate(dtResult.ToString))
                    TestItem.SubItems.Add("EDT")
                    TestItem.SubItems.Add(strTrate.Trim)
                    TestListView.Items.Add(TestItem)
                    '// Discount Calculation
                    txtTotal.Text = Val(txtTotal.Text) + Val(strTrate)
                    gblDiscount = Val(strTrate) * intCpDiscount / 100
                    txtDiscount.Text = Val(txtDiscount.Text.Trim) + Val(gblDiscount)
                    lblDues.Text = Val(lblDues.Text.Trim) + Val(strTrate)
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

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim ChkRptLvl As Integer = 0
        Dim myAge = "", mySql As String = ""
        myAge = txtYrs.Text.Trim & Space(1) & "Yrs" & Space(1) & txtMth.Text.Trim & Space(1) & "Mth" & Space(1) & txtDay.Text & Space(1) & "Day"

        '// In case of any payment / discount / dues return after post date
        If TransPostStatus = True Then
            If Val(TOTAL_WITHIN) > Val(txtTotal.Text) Then EX_P_TOT = Val(txtTotal.Text) - EX_P_TOT Else EX_P_PAY = EX_P_TOT - Val(txtTotal.Text)
            If Val(DISC_WITHIN) > Val(txtDiscount.Text) Then EX_P_DISC = Val(txtDiscount.Text) - EX_P_DISC Else EX_P_DISC = EX_P_DISC - Val(txtDiscount.Text)
            If Val(PAID_WITHIN) > Val(txtPaid.Text) Then EX_P_PAY = Val(txtPaid.Text) - EX_P_PAY Else EX_P_PAY = EX_P_PAY - Val(txtPaid.Text)
            If Val(DUES_WITHIN) > Val(lblDues.Text) Then EX_P_DUE = Val(lblDues.Text) - EX_P_DUE Else EX_P_DUE = EX_P_DUE - Val(lblDues.Text)
        End If

        If isChanged = True Then
            'Try
            Rmks = Microsoft.VisualBasic.InputBox("Please write reason for modification.", "Remarks")
            If Len(Rmks) = 0 Then Exit Sub
            '// Execute Qeury to update record in database
            mySql = "UPDATE PATIENT SET P_NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_AGE = '" & myAge & "'," & _
                    " P_DATE_SAMPLE = '" & Format(DateTime.Parse(txtDate.Text), "MM/dd/yyyy") & "'," & _
                    " P_SEX = '" & lblSex.Text.Trim & "'," & _
                    " P_PHONE = '" & txtContact.Text.Trim & "'," & _
                    " P_SLIP_NUM = " & Val(txtSlip.Text.Trim) & "," & _
                    " P_PANNEL = " & Val(txtPanel.Text.Trim) & "," & _
                    " P_CNIC = '" & txtCNIC.Text.Trim & "'," & _
                    " P_REF_BY = '" & StrConv(txtRefer.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_REFER_2 = '" & StrConv(txtHospital.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_SPC_REFER = '" & StrConv(txtSRefer.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_CP = '" & StrConv(txtCollPoint.Text.Trim, VbStrConv.Uppercase) & "'," & _
                    " P_TOTAL = " & Val(txtTotal.Text.Trim) & "," & _
                    " P_PAID = " & Val(txtPaid.Text.Trim) & "," & _
                    " P_DUES = " & Val(lblDues.Text.Trim) & "," & _
                    " P_DISCOUNT = " & Val(txtDiscount.Text.Trim) & "," & _
                    " P_AFT_GROSS = " & EX_P_TOT & "," & _
                    " P_AFT_PAID = " & EX_P_PAY & "," & _
                    " P_AFT_DISC = " & EX_P_DISC & "," & _
                    " P_AFT_DUES = " & EX_P_DUE & "," & _
                    " P_AFT_DATE = '" & Format(Now, "MM/dd/yyyy") & "'," & _
                    " P_RPT_DATE = '" & Format(Now, "MM/dd/yyyy") & "'," & _
                    " P_DISC_BY = '" & SysOperator.ToUpper.Trim & "'," & _
                    " P_EDIT_ON = '" & Format(Now, "MM/dd/yyyy") & "'," & _
                    " P_EDIT_OPR = '" & SysOperator.ToUpper & "'," & _
                    " P_EDIT_BY = '" & SysOperator.ToUpper.Trim & "'," & _
                    " P_DEL_OK = 'x'," & _
                    " P_DUE_RCV = 0," & _
                    " P_COMPLIMENT = " & Val(txtCompli.Text.Trim) & "," & _
                    " P_P_AMOUNT = " & Val(txtPAmount.Text.Trim) & "," & _
                    " P_REASON = '" & StrConv(Rmks.Trim, VbStrConv.Uppercase) & "'," & _
                    " P_SNO = " & Val(txtSNo.Text.Trim) & "," & _
                    " P_VISITOR = '" & cmbVisitor.Text.Trim & "'" & _
                    " WHERE P_NUM = " & Val(txtRecNo.Text)

            Execute_DatabaseTable_Query(SqlDataAdapter, mySql, Connection)
            'Array has contents
            '// Delete Selected Record from Receipt
            Dim CommandText, Str As String
            If DelTstList.Count > 0 Then
                For Each Str In DelTstList
                    CommandText = "DELETE FROM RECEIPT WHERE TCODE = '" & Str.Trim & "' AND TCASENO = " & Val(txtRecNo.Text)
                    Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                Next
            End If
            '// Add Test Data into Receipt Table
            Dim iCount As Integer = TestListView.Items.Count
            Dim iLoop As Integer = 0
            If iCount > 0 And Sub_Addition = True Then
                Do Until iLoop = iCount
                    If CheckTestParameter(txtRecNo.Text.Trim, TestListView.Items(iLoop).Text) = False Then
                        Str = TestListView.Items(iLoop).SubItems(3).Text.ToString
                        CommandText = "INSERT INTO RECEIPT(TCASENO,TCODE,TNAME,TCATG,TRATE,TQTY,TDATE,TMODE,TDELETE,TRPTDATE) VALUES (" & _
                                 Val(txtRecNo.Text) & ",'" & _
                                 TestListView.Items(iLoop).Text & "','" & _
                                 TestListView.Items(iLoop).SubItems(1).Text & "','" & _
                                 TestListView.Items(iLoop).SubItems(2).Text & "'," & _
                                 Val(TestListView.Items(iLoop).SubItems(5).Text) & ",1,'" & _
                                 Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "','EDT',0,'" & Format(CDate(Str.ToString), "MM/dd/yyyy") & "')"
                        Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                        CommandText = String.Empty
                    End If
                    iLoop += 1
                Loop
                iCount = 0
            End If
            Sub_Addition = False
            cmdDelete.Enabled = False
            cmdCancel.Enabled = False
            cmdComp.Enabled = False
            Call Lock_Unlock_Text(True)
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            'End Try
        End If
        SqlDataAdapter.Dispose()
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
                txtTotal.Text = Val(txtTotal.Text) - Val(DelAmount)
                lblDues.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text.Trim)
                txtPaid.Text = Val(txtPaid.Text) - DelAmount
                TestListView.Items(i).Remove()
                i = 0
                DelTstList.Add(DelString)
                j += 1
            Else
                MsgBox("( " & DelString.Trim & " ) not in the List", MsgBoxStyle.Information, My.Application.Info.ProductName)
                cmdDelete.Focus()
            End If
        End If
        Connection.Close()
        SqlDataAdapter.Dispose()
        Call Lock_Unlock_Text(False)
    End Sub

    Private Sub ShowGridData(ByVal SQLStatment As String, ByVal tblName As String, ByVal strSearch As String)

        Dim objCellStyle As New DataGridViewCellStyle()
        Try
            SqlDataAdapter.SelectCommand = New SqlCommand()
            SqlDataAdapter.SelectCommand.Connection = Connection
            If Len(strSearch) > 0 Then
                SqlDataAdapter.SelectCommand.CommandText = SQLStatment & " WHERE TCASENO = " & Val(strSearch.Trim)
            Else
                SqlDataAdapter.SelectCommand.CommandText = SQLStatment
            End If
            If Connection.State = ConnectionState.Open Then Connection.Close()
            Connection.Open()
            SqlDataAdapter.SelectCommand.CommandType = CommandType.Text
            GridDataSet.Clear()
            SqlDataAdapter.Fill(GridDataSet, tblName.Trim)
            Connection.Close()
            objCellStyle.BackColor = Color.WhiteSmoke
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        Connection.Close()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Try
            '// Find and delivered Report Status / dues Received by operator
            Dim RecStatus As String
            gblFind = Microsoft.VisualBasic.InputBox("Please Enter Patient Lab ID # to find.", "Find Record")
            If Len(gblFind) = 0 Then Exit Sub
            Me.TestListView.Items.Clear()
            PAID_WITHIN = 0
            DISC_WITHIN = 0
            DUES_WITHIN = 0
            PAID_WITHIN = 0
            intCpDiscount = 0
            gblDiscount = 0

            Dim strSql As String = "Select * from PATIENT WHERE P_NUM = " & Val(gblFind.Trim)
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, strSql, "PATIENT", Connection)

            Dim objDataTable As New Data.DataTable("PATIENT")
            Dim objDataRow As DataRow

            SqlDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                For Each objDataRow In objDataTable.Rows
                    RecStatus = objDataRow.Item("P_DEL_OK").ToString
                    '// IF STATUS IS DELIVERED
                    If RecStatus.Trim = "YES" Or RecStatus.Trim = "Yes" Then
                        MsgBox("Report Delivered on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)
                        txtStatus.Text = "NORMAL"
                        '// IF STATUS IS CANCELLED
                    ElseIf RecStatus.Trim = "CANCELLED" Or RecStatus.Trim = "Cancelled" Or RecStatus.Trim = "COMPLIMENTARY" Or RecStatus.Trim = "Complimentary" Then
                        MsgBox("Report " & RecStatus.Trim & " on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)
                        txtStatus.Text = RecStatus.ToUpper
                    End If
                    '// IF STATUS IS NORMAL
                    Panel1.Enabled = True
                    Call Lock_Unlock_Text(False)
                    'ratePanel.Enabled = True
                    cmdDelete.Enabled = True
                    cmdComp.Enabled = True
                    cmdCancel.Enabled = True
                    txtPaid.Enabled = True
                    txtRecNo.Text = objDataRow.Item("P_NUM")
                    lblSequence.Text = objDataRow.Item("P_SEQUENCE")
                    txtSNo.Text = objDataRow.Item("P_SNO")
                    txtName.Text = objDataRow.Item("P_NAME")
                    If objDataRow.IsNull("P_PANNEL") = True Then txtPanel.Text = 0 Else txtPanel.Text = objDataRow.Item("P_PANNEL")
                    txtYrs.Text = Mid(objDataRow.Item("P_AGE"), 1, 2)
                    txtMth.Text = Mid(objDataRow.Item("P_AGE"), 8, 2)
                    txtDay.Text = Mid(objDataRow.Item("P_AGE"), 15, 2)
                    txtContact.Text = objDataRow.Item("P_PHONE")
                    lblSex.Text = objDataRow.Item("P_SEX")
                    txtRefer.Text = objDataRow.Item("P_REF_BY")
                    cmbDoctors.Text = txtRefer.Text.Trim
                    txtSlip.Text = objDataRow.Item("P_SLIP_NUM")
                    txtPanel.Text = objDataRow.Item("P_PANNEL")
                    txtCollPoint.Text = objDataRow.Item("P_CP")
                    cmbCollPoint.Text = txtCollPoint.Text.Trim
                    txtHospital.Text = objDataRow.Item("P_REFER_2")
                    txtSRefer.Text = objDataRow.Item("P_SPC_REFER")
                    txtTotal.Text = objDataRow.Item("P_TOTAL")
                    txtPaid.Text = objDataRow.Item("P_PAID")
                    lblDues.Text = objDataRow.Item("P_DUES")
                    txtCompli.Text = objDataRow.Item("P_COMPLIMENT")
                    txtDiscount.Text = objDataRow("P_DISCOUNT")
                    txtPAmount.Text = objDataRow("P_P_AMOUNT")
                    TOTAL_WITHIN = objDataRow.Item("P_TOTAL")
                    PAID_WITHIN = objDataRow.Item("P_PAID")
                    DISC_WITHIN = objDataRow.Item("P_DISCOUNT")
                    DUES_WITHIN = objDataRow.Item("P_DUES")
                    txtDate.Text = objDataRow.Item("P_DATE_SAMPLE")
                    txtTime.Text = Format(objDataRow.Item("P_TIME_SAMPLE"), "hh:mm tt")
                    lblOper.Text = objDataRow.Item("P_OPERATOR").ToString.Trim
                    cmbVisitor.Text = objDataRow.Item("P_VISITOR").ToString.Trim
                    If objDataRow.IsNull("P_POSTING") = False Then
                        If objDataRow.Item("P_POSTING") = "P" Then TransPostStatus = True Else TransPostStatus = False
                    End If
                    Dim TestReader As SqlDataReader
                    ExecuteSqlQuery(EntryDataAdapter, EntryDataSet, "select * from receipt where tcaseno = " & Val(gblFind.Trim), "RECEIPT", Connection)
                    TestReader = EntryDataAdapter.SelectCommand.ExecuteReader
                    While TestReader.Read
                        strTCode = Convert.ToString(TestReader.Item("tcode")).ToUpper.Trim
                        strTname = Convert.ToString(TestReader.Item("tname")).ToUpper.Trim
                        strCatg = Convert.ToString(TestReader.Item("tcatg")).ToUpper.Trim
                        strTrate = Convert.ToString(TestReader.Item("trate")).ToString.Trim
                        strRptLvl = Convert.ToString(TestReader.Item("tmode")).ToString.Trim
                        strRptDate = CDate(Convert.ToString(TestReader.Item("trptdate")).ToString.Trim).ToString("MM/dd/yyyy")
                        Dim TestItem As New ListViewItem
                        TestItem.Text = strTCode.Trim.ToUpper
                        TestItem.SubItems.Add(strTname.Trim.ToUpper)
                        TestItem.SubItems.Add(strCatg.Trim.ToUpper)
                        TestItem.SubItems.Add(strRptDate.ToString)
                        TestItem.SubItems.Add(strRptLvl.ToString)
                        TestItem.SubItems.Add(strTrate.Trim)
                        TestListView.Items.Add(TestItem)
                        txtTotal.Focus()
                    End While
                    If Not TestReader Is Nothing Then TestReader.Close()
                    EntryDataAdapter.Dispose()
                Next
                Connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub Lock_Unlock_Text(ByVal Stat As String)

        txtName.ReadOnly = Stat
        txtMth.ReadOnly = Stat
        txtDay.ReadOnly = Stat
        txtYrs.ReadOnly = Stat
        txtDate.ReadOnly = Stat
        txtTime.ReadOnly = Stat
        txtContact.ReadOnly = Stat
        txtPanel.ReadOnly = Stat
        txtHospital.ReadOnly = Stat
        txtSlip.ReadOnly = Stat
        txtPaid.ReadOnly = Stat
        txtDiscount.ReadOnly = Stat
        txtTotal.ReadOnly = Stat

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Dim SqlString = "", Reason As String = ""
        If txtStatus.Text.ToUpper = "CANCELLED" Or txtStatus.Text.ToUpper = "COMPLIMENTARY" Then MsgBox("Patient Record already " & txtStatus.Text.Trim, MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Reason = Microsoft.VisualBasic.InputBox("Please write remarks for modification.", "Remarks")
        If Len(Reason) = 0 Then Exit Sub
        Rmks = "Cancelled"
        Dim strDate As Date = CDate(txtDate.Text)
        Dim strDiff As String = DateDiff(DateInterval.Day, Date.Today, strDate)
      
        SqlString = "UPDATE PATIENT SET p_delete = 0, p_total = 0, p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Cancelled', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                        " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_delete_on = p_date_sample, p_edit_opr = '" & SysOperator.Trim & "'," & _
                                        " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason = '" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        'End If

        Execute_DatabaseTable_Query(SqlDataAdapter, SqlString, Connection)
        txtStatus.Text = Rmks.Trim.ToUpper
        '// Delete Selected Record
        Dim CommandText As String = "DELETE FROM RECEIPT WHERE TCASENO = " & Val(txtRecNo.Text)
        SqlDataAdapter.Dispose()
        SqlDataSet.Clear()
        Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
        Connection.Close()
    End Sub

    Private Sub cmdComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComp.Click

        Dim SqlString = "", Reason As String = ""
        If txtStatus.Text.ToUpper = "COMPLIMENTARY" Or txtStatus.Text.ToUpper = "CANCELLED" Then MsgBox("Patient Record already " & txtStatus.Text.Trim, MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Reason = Microsoft.VisualBasic.InputBox("Please write remarks for modification.", "Remarks")
        If Len(Reason) = 0 Then Exit Sub
        Rmks = "Complimentary"
        Dim strDate As Date = CDate(txtDate.Text)
        Dim strDiff As String = DateDiff(DateInterval.Day, Date.Today, strDate)
        If Val(strDiff) <> 0 And Val(txtTotal.Text) > 0 Then
            SqlString = "UPDATE PATIENT SET p_compliment = " & Val(txtTotal.Text) & ", p_com_paid = " & Val(txtPaid.Text) & ", p_com_dues = " & Val(lblDues.Text) & ", p_com_disc = " & Val(txtDiscount.Text) & "," & _
                                            " p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Complimentary', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_comp_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_comp_by = '" & SysOperator.Trim & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason ='" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        If Val(strDiff) = 0 And Val(txtTotal.Text) > 0 Or Val(strDiff) = 0 Then
            SqlString = "UPDATE PATIENT SET p_compliment = " & Val(txtTotal.Text) & ", p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Complimentary', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_comp_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_comp_by = '" & SysOperator.Trim & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason = '" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        Execute_DatabaseTable_Query(SqlDataAdapter, SqlString, Connection)
        txtStatus.Text = Rmks.Trim.ToUpper
        Connection.Close()
    End Sub

    Private Sub txtSNo_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSNo.MouseDoubleClick
        If gblPrliviges = 1 Then
            StartSno = Microsoft.VisualBasic.InputBox("Please give Start Serial No.", My.Application.Info.ProductName, vbOKCancel)
            If Len(StartSno) = 0 Or StartSno = "" Then Exit Sub
            txtSNo.Text = StartSno
        End If
    End Sub

    Private Sub Get_CpRefer()
        If cmbDoctors.Text = "Select Referenced Doctor" Or cmbDoctors.Text = "SELF" Or cmbDoctors.Text = "self" Then strCpName = "SELF" : Exit Sub
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "Select * from CollectionPoint where CP_NAME = '" & Trim(cmbDoctors.Text.ToUpper) & "'", "CollectionPoint", Connection)
        If SqlDataSet.Tables("CollectionPoint").Rows.Count > 0 Then
            Dim DiscReader As SqlDataReader
            DiscReader = SqlDataAdapter.SelectCommand.ExecuteReader
            While DiscReader.Read
                strCpName = Convert.ToString(DiscReader.Item("CP_NAME"))
                If IsDBNull(DiscReader.Item("CP_ORDINARY")) = True Then intCpDiscount = 0 Else intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_ORDINARY"))
                If strDiscLvl.ToUpper = "SPECIAL" Then
                    If IsDBNull(DiscReader.Item("CP_SPECIAL")) = True Then intCpDiscount = 0 Else intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_SPECIAL"))
                End If
            End While
            If Not DiscReader Is Nothing Then DiscReader.Close()
        End If

    End Sub

    Private Sub Get_CpRefer2()
        If cmbCollPoint.Text = "Select Referenced Collection Point" Or cmbCollPoint.Text = "LAB" Or cmbCollPoint.Text = "lab" Then strCpName = "LAB" : Exit Sub
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "Select * from CollectionPoint where CP_NAME = '" & Trim(cmbCollPoint.Text.Trim) & "'", "CollectionPoint", Connection)
        If SqlDataSet.Tables("CollectionPoint").Rows.Count > 0 Then
            Dim DiscReader As SqlDataReader
            DiscReader = SqlDataAdapter.SelectCommand.ExecuteReader
            While DiscReader.Read
                strCpName = Convert.ToString(DiscReader.Item("CP_NAME"))
                If IsDBNull(DiscReader.Item("CP_ORDINARY")) = True Then intCpDiscount = 0 Else intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_ORDINARY"))
                If strDiscLvl.ToUpper = "SPECIAL" Then
                    If IsDBNull(DiscReader.Item("CP_SPECIAL")) = True Then intCpDiscount = 0 Else intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_SPECIAL"))
                End If
            End While
            If Not DiscReader Is Nothing Then DiscReader.Close()
        End If
    End Sub

    Private Sub cmdPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaid.Click
        PayDate.ShowDialog()
        If IsDBNull(gblPayDate) Or gblPayDate = String.Empty Then Exit Sub
        Dim CommandText As String = String.Empty
        Try
            If Val(lblDues.Text) > 0 Then
                If Len(gblDueAmount) = 0 Or Val(gblDueAmount) = 0 Then Exit Sub
                If Val(gblDueAmount) <> Val(lblDues.Text) Then MsgBox("Received amount is not correct.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
                txtPaid.Text = Val(txtPaid.Text) + Val(gblDueAmount)
                lblDues.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)
                txtDiscount.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(lblDues.Text)
                If gblDueAmount > 0 Then
                    CommandText = "UPDATE PATIENT SET P_DEL_OK = 'Yes', P_DEL_DATE = '" & _
                                  Format(CDate(gblPayDate), "MM/dd/yyyy") & "', P_DEL_TIME = '" & Format(Now, "hh:mm tt") & "'," & _
                                  "P_DEL_OPERATOR = '" & SysOperator & "', P_PAID = " & Val(txtPaid.Text) & _
                                  ", P_DUES = 0, P_DUE_RCV = " & gblDueAmount & ",P_DUE_RCV_DATE = '" & Format(CDate(gblPayDate), "MM/dd/yyyy") & _
                                  "', P_DUE_RCV_OPERATOR = '" & SysOperator & "' WHERE P_NUM = " & Val(txtRecNo.Text)
                End If
                Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                SqlDataAdapter.Dispose()
                MsgBox("Payment Successfully Paid.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Connection.Close()
            Me.Close()
        End Try
        Connection.Close()
    End Sub
End Class