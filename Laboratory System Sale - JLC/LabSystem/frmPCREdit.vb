Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class frmPCREdit
    Dim strCpName As String = ""
    Dim strDiscLvl As String = ""
    Dim intCpDiscount As Integer = 0
    Dim objAlternatingCellStyle As New DataGridViewCellStyle()
    Dim isChanged As Boolean
    Dim EX_P_TOT, EX_P_PAY, EX_P_DISC, EX_P_DUE, TOTAL_WITHIN, DISC_WITHIN, PAID_WITHIN, DUES_WITHIN As Double
    Dim Rmks, StartSno As String
    Dim TransPostStatus As Boolean = False
    Dim dateNow As Date = DateTime.Now
    Dim dtResult As Date

    Private Sub frmPCREdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If gblPrliviges > 2 Then
        '    MsgBox("You are not authorized, illegal operating.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        '    Me.Close()
        '    Exit Sub
        'End If

        Call GetConnectionString()
        Call Lock_Unlock_Text(True)

        Try
            Dim cpReader As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select CP_ID from CollectionPoint order by CP_ID", "CollectionPoint", Connection)
            cpReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While cpReader.Read
                Me.cmbCP.Items.Add(cpReader.Item("CP_ID"))
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

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim chk As String
        chk = e.KeyChar
        If Not (Char.IsLetter(chk) Or Char.IsControl(chk) Or Char.IsWhiteSpace(chk) Or Char.IsPunctuation(chk)) Then e.Handled = True
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
            Case "Miss" : lblSex.Text = "Female"
            Case "Ms." : lblSex.Text = "Female"
            Case "Baby" : lblSex.Text = "Female"
            Case "D/O" : lblSex.Text = "Female"
                isChanged = True
        End Select
    End Sub

    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        Me.txtContact.SelectAll()
    End Sub

    Private Sub txtContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContact.KeyDown
        If e.KeyCode = Keys.Enter Then txtSlip.Focus()
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
        Me.txtRefer.SelectAll()
    End Sub

    Private Sub txtRefer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtRefer.Text = "" Then txtRefer.Text = "SELF"
            txtCode.Focus()
        End If
    End Sub

    Private Sub txtRefer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefer.KeyPress
        If Not (Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtRefer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyUp
        If e.KeyCode = Keys.F5 Then
            frmRefer.ShowDialog(Me)
            cmbCP.Text = gblCP_ID
            If Len(gblRefer) > 0 Then txtRefer.Text = StrConv(gblRefer.Trim, VbStrConv.ProperCase)
        End If
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Escape Then txtPaid.Focus() : Exit Sub

        If e.KeyCode = Keys.Enter Then

            ' Check if txtCode Blank or Null
            If Len(txtCode.Text) = 0 Then MsgBox("PLEASER ENTER TEST CODE.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Me.ProcessTabKey(False) : Exit Sub

            ' Check if Test already in the receipt table
            Dim CommandText As String = "SELECT * FROM RECEIPT_PCR where tcode = '" & txtCode.Text.Trim & "' AND TCASENO = " & Val(txtRecNo.Text.Trim)
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "RECEIPT_PCR", Connection)
            SqlDataAdapt.Fill(SqlDataSet, "RECEIPT_PCR")
            If SqlDataSet.Tables("RECEIPT_PCR").Rows.Count > 0 Then
                MsgBox("TEST ALREADY IN THE LIST", MsgBoxStyle.Information, My.Application.Info.ProductName)
                SqlDataAdapt.Dispose()
                Connection.Close()
                txtCode.Clear()
                txtCode.Focus()
                Exit Sub
            End If

            intCpDiscount = 0
            Call Get_CpRefer()
            ' Assign Objects For Selecting Record by Given Code
            Dim strSql As String = "Select * from TESTS WHERE TCODE = '" & txtCode.Text.Trim & "'"
            Dim objDataTable As New Data.DataTable("TESTS")
            Dim objCellStyle As New DataGridViewCellStyle()
            Dim objDataRow As DataRow

            strTCode = ""
            strTname = ""
            strCatg = ""
            strTrate = ""
            strRptLvl = ""

            Try
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "TESTS", Connection)
                SqlDataAdapt.Fill(objDataTable)
                If objDataTable.Rows.Count > 0 Then
                    For Each objDataRow In objDataTable.Rows
                        strTCode = objDataRow.Item("tcode")
                        strTname = objDataRow.Item("tname")
                        strCatg = objDataRow.Item("tcatg")
                        strTrate = objDataRow.Item("trate")
                        strRptLvl = objDataRow.Item("trptlvl")
                        strDiscLvl = objDataRow.Item("tdiscmode")
                    Next
                    Connection.Close()
                    SqlDataAdapt.Dispose()
                    SqlDataSet.Clear()
                    If strCatg.Trim = "" Or strTname.Trim = "" Then MsgBox("Invalid Test Code. Please Press F2 to select correct test code.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub

                    ' Getting Discount Mode if Collection from outside of Lab

                    ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "Select * from CollectionPoint where CP_ID = '" & Trim(cmbCP.Text.ToUpper) & "'", "CollectionPoint", Connection)
                    If SqlDataSet.Tables("CollectionPoint").Rows.Count > 0 Then
                        Dim DiscReader As SqlDataReader
                        DiscReader = SqlDataAdapt.SelectCommand.ExecuteReader
                        While DiscReader.Read
                            strCpName = Convert.ToString(DiscReader.Item("CP_NAME"))
                            intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_PER_ORDINARY"))
                            If strDiscLvl.ToUpper.Trim = "SPECIAL" Then intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_PER_SPECIAL"))
                            If strDiscLvl.ToUpper = "CONDITIONAL" Then intCpDiscount = Convert.ToDecimal(DiscReader.Item("CP_CONDITIONAL"))
                            If strDiscLvl.ToUpper = "LIMITED" Then intCpDiscount = 0
                        End While
                        If Not DiscReader Is Nothing Then DiscReader.Close()
                    End If


                    Dim EditCommandText As String = "INSERT INTO RECEIPT_PCR VALUES (" & _
                                                    Val(txtRecNo.Text) & ",'" & _
                                                    strTCode & "','" & _
                                                    strTname & "','" & _
                                                    strCatg & "'," & _
                                                    Val(strTrate) & ",1,'" & _
                                                    Format(DateTime.Parse(txtDate.Text.ToString), "MM/dd/yyyy") & "','EDT',0)"

                    Call Get_CpRefer()
                    Execute_DatabaseTable_Query(SqlDataAdapt, EditCommandText, Connection)
                    lblTotal.Text = Val(lblTotal.Text.Trim) + Val(strTrate)
                    gblDiscount = Val(strTrate) * intCpDiscount / 100
                    txtDiscount.Text = gblDiscount
                    lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text) - gblDiscount
                    lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)
                    Connection.Close()
                    SqlDataAdapt.Dispose()
                    Call ShowGridData("SELECT * FROM RECEIPT_PCR", "RECEIPT_PCR", txtRecNo.Text)
                    txtCode.Clear()
                    cmdSave.Enabled = True
                    cmdDelete.Enabled = True

                Else
                    MsgBox("INVALID CODE PLEASE ENTER CORRECT CODE", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    Me.ProcessTabKey(False)
                    Exit Sub
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                EntryDataSet = Nothing
            End Try
            objCellStyle.BackColor = Color.WhiteSmoke
            TstDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
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

    Private Sub txtYrs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYrs.GotFocus
        Me.txtYrs.SelectAll()
    End Sub

    Private Sub txtYrs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYrs.KeyDown
        If e.KeyCode = Keys.Enter Then txtMth.Focus()
    End Sub

    Private Sub txtYrs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYrs.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Or (Char.IsControl(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtMth_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMth.GotFocus
        Me.txtMth.SelectAll()
    End Sub

    Private Sub txtMth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMth.KeyDown
        If e.KeyCode = Keys.Enter Then txtDay.Focus()
    End Sub

    Private Sub txtMth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMth.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Or (Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim ChkRptLvl As Integer = 0
        Dim myAge = "", mySql As String = ""

        myAge = txtYrs.Text.Trim & Space(1) & "Yrs" & Space(1) & txtMth.Text.Trim & Space(1) & "Mth" & Space(1) & txtDay.Text & Space(1) & "Day"

        '// In case of any payment / discount / dues return after post date
        If TransPostStatus = True Then
            If Val(TOTAL_WITHIN) > Val(lblTotal.Text) Then EX_P_TOT = Val(lblTotal.Text) - EX_P_TOT Else EX_P_PAY = EX_P_TOT - Val(lblTotal.Text)
            If Val(DISC_WITHIN) > Val(txtDiscount.Text) Then EX_P_DISC = Val(txtDiscount.Text) - EX_P_DISC Else EX_P_DISC = EX_P_DISC - Val(txtDiscount.Text)
            If Val(PAID_WITHIN) > Val(txtPaid.Text) Then EX_P_PAY = Val(txtPaid.Text) - EX_P_PAY Else EX_P_PAY = EX_P_PAY - Val(txtPaid.Text)
            If Val(DUES_WITHIN) > Val(lblDues.Text) Then EX_P_DUE = Val(lblDues.Text) - EX_P_DUE Else EX_P_DUE = EX_P_DUE - Val(lblDues.Text)
        End If

        If isChanged = True Then
            Try
                Rmks = InputBox("Please write reason for modification.", "Remarks")
                If Len(Rmks) = 0 Then Exit Sub

                '// Execute Qeury to update record in database
                mySql = "UPDATE PATIENT_PCR SET P_NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                        " P_AGE = '" & myAge & "'," & _
                        " P_DATE_SAMPLE = '" & Format(DateTime.Parse(txtDate.Text), "MM/dd/yyyy") & "'," & _
                        " P_SEX = '" & lblSex.Text.Trim & "'," & _
                        " P_PHONE = '" & txtContact.Text.Trim & "'," & _
                        " P_SLIP_NUM = " & Val(txtSlip.Text.Trim) & "," & _
                        " P_PANNEL = " & Val(txtPanel.Text.Trim) & "," & _
                        " P_REF_BY = '" & StrConv(txtRefer.Text.Trim, VbStrConv.ProperCase) & "'," & _
                        " P_CP = '" & StrConv(cmbCP.Text.Trim, VbStrConv.Uppercase) & "'," & _
                        " P_TOTAL = " & Val(lblTotal.Text.Trim) & "," & _
                        " P_PAID = " & Val(txtPaid.Text.Trim) & "," & _
                        " P_DUES = " & Val(lblDues.Text.Trim) & "," & _
                        " P_DISCOUNT = " & Val(txtDiscount.Text.Trim) & "," & _
                        " P_AFT_GROSS = " & EX_P_TOT & "," & _
                        " P_AFT_PAID = " & EX_P_PAY & "," & _
                        " P_AFT_DISC = " & EX_P_DISC & "," & _
                        " P_AFT_DUES = " & EX_P_DUE & "," & _
                        " P_AFT_DATE = '" & Format(Now, "MM/dd/yyyy") & "'," & _
                        " P_RPT_DATE = '" & Format(DateTime.Parse(txtDelDate.Text), "MM/dd/yyyy") & "'," & _
                        " P_DISC_BY = '" & SysOperator.ToUpper.Trim & "'," & _
                        " P_EDIT_ON = '" & Format(Now, "MM/dd/yyyy") & "'," & _
                        " P_EDIT_OPR = '" & SysOperator.ToUpper & "'," & _
                        " P_EDIT_BY = '" & SysOperator.ToUpper.Trim & "'," & _
                        " P_DEL_OK = 'x'," & _
                        " P_DUE_RCV = 0," & _
                        " P_COMPLIMENT = " & Val(txtCompli.Text.Trim) & "," & _
                        " P_REASON = '" & StrConv(Rmks.Trim, VbStrConv.Uppercase) & "'" & _
                        " WHERE P_NUM = " & Val(txtRecNo.Text)

                Execute_DatabaseTable_Query(SqlDataAdapt, mySql, Connection)
                cmdDelete.Enabled = False
                cmdCancel.Enabled = False
                cmdComp.Enabled = False
                Call Lock_Unlock_Text(True)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
        End If
        SqlDataAdapt.Dispose()
        Connection.Close()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim DelString As String
        Dim DelAmount As Double
        DelString = Microsoft.VisualBasic.InputBox("Please Test Code to Delete test from List.", "Delete")
        If Len(DelString.ToUpper) = 0 Then Exit Sub

        '// Select Deleted Test Rate
        Dim strSql As String = "Select * from RECEIPT_PCR WHERE TCODE = '" & DelString.Trim & "' AND TCASENO = " & Val(txtRecNo.Text)
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "RECEIPT_PCR", Connection)
        Dim DelReader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader
        Try
            While DelReader.Read
                DelAmount = Convert.ToDecimal(DelReader.Item("trate"))
            End While
            If Not DelReader Is Nothing Then DelReader.Close()
            lblTotal.Text = Val(lblTotal.Text) - Val(DelAmount)
            lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text)

            '// Delete Selected Record from RECEIPT_PCR
            Dim CommandText As String = "DELETE FROM RECEIPT_PCR WHERE TCODE = '" & DelString.Trim & "' AND TCASENO = " & Val(txtRecNo.Text)
            SqlDataAdapt.Dispose()
            SqlDataSet.Clear()
            Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        ' Refresh Data Grid
        Call ShowGridData("SELECT * FROM RECEIPT_PCR", "RECEIPT_PCR", txtRecNo.Text.Trim)
        Connection.Close()
        SqlDataAdapt.Dispose()

    End Sub

    Private Sub ShowGridData(ByVal SQLStatment As String, ByVal tblName As String, ByVal strSearch As String)

        Dim objCellStyle As New DataGridViewCellStyle()
        Try
            SqlDataAdapt.SelectCommand = New SqlCommand()
            SqlDataAdapt.SelectCommand.Connection = Connection
            If Len(strSearch) > 0 Then
                SqlDataAdapt.SelectCommand.CommandText = SQLStatment & " WHERE TCASENO = " & Val(strSearch.Trim)
            Else
                SqlDataAdapt.SelectCommand.CommandText = SQLStatment
            End If
            If Connection.State = ConnectionState.Open Then Connection.Close()
            Connection.Open()
            SqlDataAdapt.SelectCommand.CommandType = CommandType.Text
            GridDataSet.Clear()
            SqlDataAdapt.Fill(GridDataSet, tblName.Trim)
            Connection.Close()
            objCellStyle.BackColor = Color.WhiteSmoke
            TstDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
            TstDataGrid.DataSource = GridDataSet
            TstDataGrid.DataMember = tblName.Trim
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

            PAID_WITHIN = 0
            DISC_WITHIN = 0
            DUES_WITHIN = 0
            PAID_WITHIN = 0
            intCpDiscount = 0
            gblDiscount = 0

            Dim strSql As String = "Select * from PATIENT_PCR WHERE P_NUM = " & Val(gblFind.Trim)
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "PATIENT_PCR", Connection)

            Dim objDataTable As New Data.DataTable("PATIENT_PCR")
            Dim objDataRow As DataRow

            SqlDataAdapt.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                For Each objDataRow In objDataTable.Rows
                    RecStatus = objDataRow.Item("P_DEL_OK").ToString
                    '// IF STATUS IS DELIVERED
                    If RecStatus.Trim = "YES" Or RecStatus.Trim = "Yes" Or RecStatus.Trim = "" Or RecStatus.Trim = "X" Then
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
                    txtName.Text = objDataRow.Item("P_NAME")
                    If objDataRow.IsNull("P_PANNEL") = True Then txtPanel.Text = 0 Else txtPanel.Text = objDataRow.Item("P_PANNEL")
                    txtYrs.Text = Mid(objDataRow.Item("P_AGE"), 1, 2)
                    txtMth.Text = Mid(objDataRow.Item("P_AGE"), 8, 2)
                    txtDay.Text = Mid(objDataRow.Item("P_AGE"), 15, 2)
                    txtContact.Text = objDataRow.Item("P_PHONE")
                    lblSex.Text = objDataRow.Item("P_SEX")
                    txtRefer.Text = objDataRow.Item("P_REF_BY")
                    txtSlip.Text = objDataRow.Item("P_SLIP_NUM")
                    txtPanel.Text = objDataRow.Item("P_PANNEL")
                    cmbCP.Text = objDataRow.Item("P_CP")
                    lblTotal.Text = objDataRow.Item("P_TOTAL")
                    txtPaid.Text = objDataRow.Item("P_PAID")
                    lblDues.Text = objDataRow.Item("P_DUES")
                    txtCompli.Text = objDataRow.Item("P_COMPLIMENT")
                    txtDiscount.Text = objDataRow("P_DISCOUNT")
                    TOTAL_WITHIN = objDataRow.Item("P_TOTAL")
                    PAID_WITHIN = objDataRow.Item("P_PAID")
                    DISC_WITHIN = objDataRow.Item("P_DISCOUNT")
                    DUES_WITHIN = objDataRow.Item("P_DUES")
                    txtDate.Text = objDataRow.Item("P_DATE_SAMPLE")
                    txtTime.Text = Format(objDataRow.Item("P_TIME_SAMPLE"), "hh:mm tt")
                    txtDelDate.Text = objDataRow.Item("P_RPT_DATE")
                    txtDelTime.Text = Format(objDataRow.Item("P_RPT_TIME"), "hh:mm tt")
                    lblOper.Text = objDataRow.Item("P_OPERATOR").ToString.Trim
                    lblvisitor.Text = objDataRow.Item("P_VISITOR").ToString.Trim
                    If objDataRow.IsNull("P_POSTING") = False Then
                        If objDataRow.Item("P_POSTING") = "P" Then TransPostStatus = True Else TransPostStatus = False
                    End If
                    Call ShowGridData("SELECT * FROM RECEIPT_PCR", "RECEIPT_PCR", txtRecNo.Text.Trim)
                    txtDiscount.Focus()
                Next
                Connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub txtPaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then lblDues.Text = Val(lblTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text) : cmdSave.Enabled = True : cmdSave.Focus()
    End Sub

    Private Sub txtPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaid.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.GotFocus
        txtName.SelectAll()
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then txtName.Text = StrConv(txtName.Text, VbStrConv.ProperCase) : txtSlip.Focus()
    End Sub

    Private Sub txtDName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then txtYrs.Focus()
    End Sub

    Private Sub txtDName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim chk As String
        chk = e.KeyChar
        If Not (Char.IsLetter(chk) Or Char.IsControl(chk) Or Char.IsWhiteSpace(chk) Or Char.IsPunctuation(chk)) Then e.Handled = True
    End Sub

    Private Sub txtDay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDay.GotFocus
        Me.txtDay.SelectAll()
    End Sub

    Private Sub txtDay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDay.KeyDown
        If e.KeyCode = Keys.Enter Then txtContact.Focus()
    End Sub

    Private Sub cmbCP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCP.GotFocus
        Me.cmbCP.SelectAll()
    End Sub

    Private Sub cmbCP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCP.KeyDown
        If e.KeyCode = Keys.Enter Then txtRefer.Focus()
    End Sub

    Private Sub txtSlip_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSlip.GotFocus
        txtSlip.SelectAll()
    End Sub

    Private Sub txtSlip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSlip.KeyDown
        If e.KeyCode = Keys.Enter Then txtPanel.Focus()
    End Sub

    Private Sub txtDiscount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.GotFocus
        txtDiscount.SelectAll()
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtDiscount.Text) > (Val(lblTotal.Text) - Val(txtPaid.Text)) Then txtDiscount.Focus() : Exit Sub
            If Val(txtDiscount.Text) > DISC_WITHIN Then EX_P_DISC = Val(txtDiscount.Text) - Val(DISC_WITHIN)
            If Val(txtDiscount.Text) < DISC_WITHIN Then EX_P_DISC = Val(DISC_WITHIN) - Val(txtDiscount.Text)
            lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)
            lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)
            txtPaid.Focus()
        End If
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        isChanged = True
    End Sub

    Private Sub txtDName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        isChanged = True
    End Sub

    Private Sub cmbDTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        isChanged = True
    End Sub

    Private Sub cmbCP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCP.SelectedIndexChanged
        isChanged = True
        intCpDiscount = 0
        Call Get_CpRefer()
        If strCpName = "" Then MsgBox("Please Select Valid Reference.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        txtRefer.Text = StrConv(strCpName.Trim, VbStrConv.ProperCase)
    End Sub

    Private Sub txtRefer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefer.TextChanged
        isChanged = True
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        isChanged = True
    End Sub

    Private Sub txtPaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaid.TextChanged
        isChanged = True
    End Sub

    Private Sub lblTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lblTotal.KeyDown
        If e.KeyCode = Keys.Enter Then lblDues.Text = Val(lblTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text)
    End Sub

    Private Sub lblTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.TextChanged
        isChanged = True
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
        txtDate.ReadOnly = Stat
        txtTime.ReadOnly = Stat
        txtDelDate.ReadOnly = Stat
        txtDelTime.ReadOnly = Stat
        txtContact.ReadOnly = Stat
        txtPanel.ReadOnly = Stat
        txtRefer.ReadOnly = Stat
        txtSlip.ReadOnly = Stat
        txtPaid.ReadOnly = Stat
        txtDiscount.ReadOnly = Stat
        lblTotal.ReadOnly = Stat

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Dim SqlString = "", Reason As String = ""
        If txtStatus.Text.ToUpper = "CANCELLED" Or txtStatus.Text.ToUpper = "COMPLIMENTARY" Then MsgBox("Patient Record already " & txtStatus.Text.Trim, MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Reason = InputBox("Please write remarks for modification.", "Remarks")
        If Len(Reason) = 0 Then Exit Sub
        Rmks = "Cancelled"
        Dim strDate As Date = CDate(txtDate.Text)
        Dim strDiff As String = DateDiff(DateInterval.Day, Date.Today, strDate)
        If Val(strDiff) <> 0 And Val(lblTotal.Text) > 0 Then
            SqlString = "UPDATE PATIENT_PCR SET p_delete = " & Val(lblTotal.Text) & ", p_del_paid = " & Val(txtPaid.Text) & ", p_del_dues = " & Val(lblDues.Text) & ", p_del_disc = " & Val(txtDiscount.Text) & "," & _
                                            " p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Cancelled', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_delete_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason ='" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        If Val(strDiff) = 0 And Val(lblTotal.Text) > 0 Or Val(strDiff) = 0 Then
            SqlString = "UPDATE PATIENT_PCR SET p_delete = 0, p_total = 0, p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Cancelled', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_delete_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason = '" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        Execute_DatabaseTable_Query(SqlDataAdapt, SqlString, Connection)
        txtStatus.Text = Rmks.Trim.ToUpper
        '// Delete Selected Record
        Dim CommandText As String = "DELETE FROM RECEIPT_PCR WHERE TCASENO = " & Val(txtRecNo.Text)
        SqlDataAdapt.Dispose()
        SqlDataSet.Clear()
        Execute_DatabaseTable_Query(SqlDataAdapt, CommandText, Connection)
        Connection.Close()
    End Sub

    Private Sub cmdComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComp.Click

        Dim SqlString = "", Reason As String = ""
        If txtStatus.Text.ToUpper = "COMPLIMENTARY" Or txtStatus.Text.ToUpper = "CANCELLED" Then MsgBox("Patient Record already " & txtStatus.Text.Trim, MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        Reason = InputBox("Please write remarks for modification.", "Remarks")
        If Len(Reason) = 0 Then Exit Sub
        Rmks = "Complimentary"
        Dim strDate As Date = CDate(txtDate.Text)
        Dim strDiff As String = DateDiff(DateInterval.Day, Date.Today, strDate)
        If Val(strDiff) <> 0 And Val(lblTotal.Text) > 0 Then
            SqlString = "UPDATE PATIENT_PCR SET p_compliment = " & Val(lblTotal.Text) & ", p_com_paid = " & Val(txtPaid.Text) & ", p_com_dues = " & Val(lblDues.Text) & ", p_com_disc = " & Val(txtDiscount.Text) & "," & _
                                            " p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Complimentary', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_comp_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_comp_by = '" & SysOperator.Trim & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason ='" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        If Val(strDiff) = 0 And Val(lblTotal.Text) > 0 Or Val(strDiff) = 0 Then
            SqlString = "UPDATE PATIENT_PCR SET p_compliment = " & Val(lblTotal.Text) & ", p_paid = 0, p_dues = 0, p_discount = 0, p_other = 0, p_del_ok = 'Complimentary', p_del_operator = '" & SysOperator.Trim & "', p_del_date = '" & Format(Now(), "MM/dd/yyyy") & "'," & _
                                            " p_del_time = '" & Format(Now(), "hh:mm tt") & "', p_comp_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_comp_by = '" & SysOperator.Trim & "', p_edit_opr = '" & SysOperator.Trim & "'," & _
                                            " p_edit_on = '" & Format(Now(), "MM/dd/yyyy") & "', p_reason = '" & StrConv(Reason.Trim, VbStrConv.ProperCase) & "' WHERE p_num = " & Val(txtRecNo.Text)
        End If

        Execute_DatabaseTable_Query(SqlDataAdapt, SqlString, Connection)
        txtStatus.Text = Rmks.Trim.ToUpper
        Connection.Close()
    End Sub

End Class