Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System

Public Class CrossMatch
    Dim TestItem As New ListViewItem
    Dim FindCode, Rmks, strCpName, Current_Operator, strDiscLvl, wDonor_Pid As String
    Dim CodeCounter As Integer = 0
    Dim intCpDiscount As Integer = 0
    Dim Return_Response As Integer = 0
    Dim wTotal As Double
    Dim wTestID, DonorPID, DonorID As Integer
    Dim Sub_Addition As Boolean = False
    Dim RecordMode, Saved, MultipleMode As Boolean
    Dim dateNow As Date = DateTime.Now
    Dim DelString, MaxSn, DonorName, MaxSeq As String
    Dim DelTstList As New List(Of String)
    Dim DelAmount As Double
    Dim dtResult As Date

#Region "KEY DOWN/PRESS EVENTS"

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Not (e.KeyChar = "." Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtdName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDName.KeyPress
        If Not (e.KeyChar = "." Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmbTitle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTitle.KeyPress
        Call cmbTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbdTitle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDTitle.KeyPress
        Call cmbDTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbTitle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitle.GotFocus
        cmbTitle.SelectAll()
    End Sub

    Private Sub cmbDTitle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDTitle.GotFocus
        cmbDTitle.SelectAll()
    End Sub

    Private Sub cmbTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTitle.KeyDown
        If e.KeyCode = Keys.Enter Then cmbTitle_SelectedIndexChanged(sender, e) : txtName.Focus()
    End Sub

    Private Sub cmbDTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDTitle.KeyDown
        If e.KeyCode = Keys.Enter Then cmbTitle_SelectedIndexChanged(sender, e) : txtDName.Focus()
    End Sub

    Private Sub txtRefer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefer.GotFocus
        txtRefer.SelectAll()
    End Sub

    Private Sub txtRefer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtRefer.Text = "" Then MsgBox("Please Select Referenced Doctor.", MsgBoxStyle.Information, My.Application.Info.ProductName) : txtRefer.Focus() Else cmbCollPoint.Focus()
            Call Get_CpRefer()
        End If
    End Sub

    Private Sub txtRefer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefer.KeyPress
        If Not (e.KeyChar = "/" Or e.KeyChar = "." Or Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtRefer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefer.KeyUp
        If e.KeyCode = Keys.F5 Then
            ReferCode.ShowDialog(Me)
            If Len(gblRefer) > 0 Then
                txtRefer.Text = StrConv(gblRefer.Trim, VbStrConv.ProperCase)
                Call Get_CpRefer()
                Exit Sub
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

    Private Sub txtDYrs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDYrs.GotFocus
        txtYrs.SelectAll()
    End Sub

    Private Sub txtYrs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYrs.KeyDown
        If e.KeyCode = Keys.Enter Then txtYrs.Text = Format(Val(txtYrs.Text), "00") : txtMth.Focus()
    End Sub

    Private Sub txtDYrs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDYrs.KeyDown
        If e.KeyCode = Keys.Enter Then txtYrs.Text = Format(Val(txtYrs.Text), "00") : txtCNIC.Focus()
    End Sub

    Private Sub txtYrs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYrs.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtDYrs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDYrs.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtPaid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtPaid.Text.Trim) > (Val(txtTotal.Text.Trim) - Val(txtDiscount.Text.Trim)) Then
                MsgBox("Paid amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                txtPaid.Focus()
                txtPaid.SelectAll()
                Exit Sub
            End If
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim)
            txtDiscount.Focus()
        End If
    End Sub

    Private Sub txtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtDiscount.Text.Trim) > (Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim)) Then
                MsgBox("Discount amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                txtDiscount.Focus()
                txtDiscount.SelectAll()
                Exit Sub
            End If
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim)
            txtCompli.Focus()
        End If
    End Sub

    Private Sub txtCompli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCompli.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtCompli.Text.Trim) > Val(txtTotal.Text.Trim) Then
                MsgBox("Complimentary amount cannot be greater then total amount.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                txtCompli.Focus()
                txtCompli.SelectAll()
                Exit Sub
            End If
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            cmdSave.Enabled = True
            cmdSave.Focus()
        End If
    End Sub

    Private Sub txtPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaid.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtCompli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompli.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then txtName.Text = StrConv(txtName.Text, VbStrConv.ProperCase) : txtYrs.Focus()
    End Sub

    Private Sub txtDName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDName.KeyDown
        If e.KeyCode = Keys.Enter Then txtName.Text = StrConv(txtName.Text, VbStrConv.ProperCase) : txtDYrs.Focus()
    End Sub

    Private Sub txtName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.LostFocus
        txtName.Text = StrConv(txtName.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub txtDName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDName.LostFocus
        txtName.Text = StrConv(txtName.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub cmbDoctors_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then  'Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            intCpDiscount = 0
            Call Get_CpRefer()
            txtRefer.Text = strCpName.Trim
            txtRefer.Focus()
        End If
    End Sub

    Private Sub cmbDoctors_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        intCpDiscount = 0
        Call Get_CpRefer()
    End Sub

    Private Sub cmbDoctors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            If txtCollPoint.Text = "" Then MsgBox("Please Select valid Collection Point.", MsgBoxStyle.Information, My.Application.Info.ProductName) : txtCollPoint.Focus() Else txtCode.Focus()
        End If
    End Sub

    Private Sub txtCNIC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNIC.GotFocus
        txtCNIC.SelectAll()
    End Sub

    Private Sub txtCNIC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNIC.KeyDown
        If e.KeyCode = Keys.Enter Then txtRefer.Focus()
    End Sub

    Private Sub cmbCollPoint_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCollPoint.GotFocus
        cmbCollPoint.SelectAll()
    End Sub

    Private Sub cmbCollPoint_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCollPoint.LostFocus
        intCpDiscount = 0
        Call Get_CpRefer2()
    End Sub

    Private Sub cmbVisitor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbVisitor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTotal.Focus()
        End If
    End Sub

    Private Sub cmbTitle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitle.LostFocus
        Call cmbTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbDTitle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDTitle.LostFocus
        cmbDTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub txtName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.GotFocus
        Call cmbTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub txtDName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDName.GotFocus
        Call cmbDTitle_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub txtDName_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDName.MouseDoubleClick
        txtDName.Clear()
        txtDYrs.Text = "00"
        cmbDTitle.Focus()
        cmdSave.Text = "&Update"
    End Sub

    Private Sub txtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            txtPaid.Focus()
        End If
    End Sub

    Private Sub txtDues_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDues.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtCompli.Text.Trim)
            cmdSave.Focus()
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub cmbCollPoint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCollPoint.KeyDown
        If e.KeyCode = Keys.Enter Then
            intCpDiscount = 0
            Call Get_CpRefer2()
            txtCollPoint.Text = strCpName.Trim
            txtCollPoint.Focus()
        End If
    End Sub

    Private Sub cmbCollPoint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCollPoint.SelectedIndexChanged
        intCpDiscount = 0
        Call Get_CpRefer2()
        If strCpName = "" Then MsgBox("Please Select Valid Reference.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        txtCollPoint.Text = strCpName.Trim
    End Sub

    Private Sub txtContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContact.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCNIC.Focus()
        End If
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
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

    Private Sub txtDay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDay.GotFocus
        txtDay.SelectAll()
    End Sub

    Private Sub txtDay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDay.KeyDown
        If e.KeyCode = Keys.Enter Then txtDay.Text = Format(Val(txtDay.Text), "00") : cmbDTitle.Focus()
    End Sub

    Private Sub txtDay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDay.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

#End Region

    Private Sub CrossMatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        strDiscLvl = ""
        Saved = False
        RecordMode = False
        MultipleMode = False
        wDonor_Pid = 0
        wTestID = 0

        'dateNow = Format(DateTime.Parse(DateTime.Now), "MM/dd/yyyy")
        Call GetConnectionString()
        Try
            Dim cpReader As SqlDataReader
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
            strRptLvl = 1
            Call cmdNew_Click(sender, e)
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        Connection.Close()
        Me.Focus()

    End Sub

    Private Sub cmbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTitle.SelectedIndexChanged
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

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        'REFRESH FIELDS FOR NEW RECORD
        Try
            Me.txtCode.Clear()
            Me.txtName.Clear()
            Me.txtDName.Clear()
            Me.lblSno.Text = String.Empty
            Me.txtRecNo.Text = String.Empty
            Me.lblPSex.Text = ""
            Me.lblDSex.Text = ""
            Me.txtTotal.Text = "00"
            Me.txtDues.Text = "00"
            Me.txtPaid.Text = "00"
            Me.txtDiscount.Text = "00"
            Me.txtCompli.Text = "00"
            Me.txtCode.Clear()
            Me.txtRefer.Text = "SELF"
            Me.txtCollPoint.Text = "LAB"
            Me.cmbTitle.Text = "Mr."
            Me.cmbDTitle.Text = "Mr."
            Me.cmbVisitor.Text = ""
            Me.txtDYrs.Text = "00"
            Me.txtYrs.Text = "00"
            Me.txtDYrs.Text = "00"
            Me.cmbCollPoint.Text = "Select Collection Point"
            Call Donor_Profile("READ")
            Dim MaxId As String = ""
            Dim cpReader As SqlDataReader
            ExecuteSqlQuery(SqlDataAdapter, myDataSet, "Select Max(P_NUM) AS MAX_ID from PATIENT", "CollectionPoint", Connection)
            cpReader = SqlDataAdapter.SelectCommand.ExecuteReader
            While cpReader.Read
                MaxId = Val(cpReader.Item("MAX_ID").ToString) + 1
            End While
            If Not cpReader Is Nothing Then cpReader.Close()

            Dim MaxSerialNo As SqlDataReader
            ExecuteSqlQuery(EntryDataAdapter, myDataSet, "Select Max(P_SNO) AS MAX_SNO from PATIENT WHERE P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & " 00:00:00',102)", "PATIENT", Connection)
            MaxSerialNo = EntryDataAdapter.SelectCommand.ExecuteReader
            While MaxSerialNo.Read
                MaxSn = Val(MaxSerialNo.Item("MAX_SNO").ToString) + 1
            End While
            If Not MaxSerialNo Is Nothing Then MaxSerialNo.Close()

            If SysOperator.Trim = "DEMO" Or SysOperator.Trim = "demo" Then
                txtRecNo.Text = "000000"
            Else
                txtRecNo.Text = MaxId
                lblSno.Text = MaxSn
            End If

            txtDate.Text = Format(Now, "MM/dd/yyyy").ToString
            gblDiscount = 0
            intCpDiscount = 0
            strCpName = ""
            RecordMode = False
            wDonor_Pid = 0
            wTestID = 0
            DonorID = 0
            cmbTitle.Focus()
            TestListView.Items.Clear()
            DonorPID = 0
            DonorName = String.Empty
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try

    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click

        Try
            '// Find or Delivered Reports / Dues Received by operator
            DonorDataGrid.DataSource = Nothing
            Dim RecStatus As String
            gblFind = Microsoft.VisualBasic.InputBox("Please Enter Patient Lab ID # to find.", "Find Record")
            If Len(gblFind) = 0 Then Exit Sub

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
                        '// IF STATUS IS CANCELLED
                    ElseIf RecStatus.Trim = "CANCELLED" Or RecStatus.Trim = "Cancelled" Or RecStatus.Trim = "COMPLIMENTARY" Or RecStatus.Trim = "Complimentary" Then
                        MsgBox("Report " & RecStatus.Trim & " on " & objDataRow.Item("P_DEL_DATE") & vbCrLf _
                                & "by " & objDataRow.Item("P_DEL_OPERATOR"), MsgBoxStyle.Information, My.Application.Info.ProductName)

                    End If
                    '// SHOW PATIENT TESTS PARAMETERS IN LIST VIEW
                    TestListView.Items.Clear()
                    ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "SELECT * FROM RECEIPT WHERE TCASENO = " & Val(gblFind.Trim), "RECEIPT", Connection)
                    Dim forListView As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                    While forListView.Read
                        Dim TestItem As New ListViewItem
                        TestItem.Text = Convert.ToString(forListView.Item("tcode")).ToUpper.Trim
                        TestItem.SubItems.Add(Convert.ToString(forListView.Item("tname")).ToUpper.Trim)
                        TestItem.SubItems.Add(Convert.ToString(forListView.Item("tcatg")).ToUpper.Trim)
                        TestItem.SubItems.Add(CDate(Convert.ToString(forListView.Item("trptdate")).ToUpper.Trim))
                        TestItem.SubItems.Add("1")
                        TestItem.SubItems.Add(Convert.ToString(forListView.Item("trate")).ToUpper.Trim)
                        TestListView.Items.Add(TestItem)
                    End While
                    '// IF STATUS IS NORMAL
                    txtRecNo.Text = objDataRow.Item("P_NUM")
                    If IsDBNull(objDataRow.Item("P_SNO")) = True Then lblSno.Text = "00" Else lblSno.Text = objDataRow.Item("P_SNO")
                    txtName.Text = objDataRow.Item("P_NAME")
                    txtYrs.Text = Mid(objDataRow.Item("P_AGE"), 1, 2)
                    lblPSex.Text = objDataRow.Item("P_SEX")
                    txtCNIC.Text = objDataRow.Item("P_CNIC")
                    txtRefer.Text = objDataRow.Item("P_REF_BY")
                    txtCollPoint.Text = objDataRow.Item("P_CP").ToString.Trim
                    txtTotal.Text = objDataRow.Item("P_TOTAL")
                    txtPaid.Text = objDataRow.Item("P_PAID")
                    txtCompli.Text = objDataRow.Item("P_COMPLIMENT")
                    txtDiscount.Text = Format(Val(objDataRow.Item("P_DISCOUNT")), "00")
                    txtDues.Text = Format(Val(objDataRow.Item("P_DUES")), "00")
                    txtDate.Text = Format(objDataRow.Item("P_DATE_SAMPLE"), "MM/dd/yyyy")
                    cmbVisitor.Text = objDataRow.Item("P_VISITOR").ToString.Trim

                    ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "SELECT MAX(TDELETE) AS MAX_ID FROM RECEIPT WHERE TCASENO = " & Val(gblFind.Trim), "RECEIPT", Connection)
                    Dim Get_Max As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                    While Get_Max.Read
                        If Not Get_Max Is Nothing Then
                            wTestID = 1
                        Else
                            wTestID = Val(Get_Max.Item("MAX_ID")) + 1
                        End If
                    End While
                    If Not Get_Max Is Nothing Then Get_Max.Close()

                    SqlDataAdapter.Dispose()
                    SqlDataSet.Clear()
                Next
                Connection.Close()
                Call Donor_Profile("READ")
                cmdSave.Text = "&Update"
                cmdClose.Text = "&Cancel"
                cmdLSlip.Enabled = True
            Else
                MsgBox("Please enter Valid Lab ID.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, My.Application.Info.ProductName)
            End If
        Catch Msg As SqlException
            MsgBox(Msg, MsgBoxStyle.Information, My.Application.Info.ProductName)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Escape Then cmbVisitor.Focus() : Exit Sub
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
                        strTrate = Convert.ToString(TestReader.Item("trate")).Trim
                        strRptLvl = Convert.ToString(TestReader.Item("trptlvl")).Trim
                        strDiscLvl = Convert.ToString(TestReader.Item("tdiscmode")).Trim
                    End While
                    If Not TestReader Is Nothing Then TestReader.Close()
                    EntryDataAdapter.Dispose()
                    If strCatg.Trim = "" Or strTname.Trim = "" Then MsgBox("Invalid Test Code. Please Press F2 to select correct test code.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
                    'to check that entry is only for cross match
                    If strTname.IndexOf("CROSS") > -1 Or strTname.IndexOf("GROUP") > -1 Then
                        ' Gett Discount Mode for collection on lab or outside
                        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "Select * from CollectionPoint where CP_NAME = '" & Trim(txtCollPoint.Text.ToUpper) & "'", "CollectionPoint", Connection)
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

                        ' Set report date for patient receipt
                        dtResult = Format(Now.Date, "MM/dd/yyyy")
                        ' Adding Values into Temporary List View
                        Dim TestItem As New ListViewItem
                        TestItem.Text = strTCode.Trim.ToUpper
                        TestItem.SubItems.Add(strTname.Trim.ToUpper)
                        TestItem.SubItems.Add(strCatg.Trim.ToUpper)
                        TestItem.SubItems.Add(CDate(dtResult.ToString))
                        TestItem.SubItems.Add(strRptLvl.Trim)
                        TestItem.SubItems.Add(strTrate.Trim)
                        TestListView.Items.Add(TestItem)

                        '// Discount Calculation
                        txtTotal.Text = Val(txtTotal.Text) + Val(strTrate)
                        gblDiscount = Val(strTrate) * intCpDiscount / 100
                        txtDiscount.Text = Val(txtDiscount.Text.Trim) + Val(gblDiscount)
                        txtDues.Text = Val(txtTotal.Text) - Val(txtPaid.Text) - Val(txtDiscount.Text) - Val(txtCompli.Text.Trim)
                        Connection.Close()
                        txtCode.Clear()
                        cmdDelete.Enabled = True
                    Else
                        MsgBox("This is only for cross match's patient.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    End If
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

    Private Sub cmdLSlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLSlip.Click
        gblFind = txtRecNo.Text.Trim
        If DonorPID = 0 Or DonorName = "" Then MsgBox("Plz select donor to print slip", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        If DonorPID > 0 Then
            gblReportName = Directory.GetCurrentDirectory & "\" & "Reports\CrossMatchSlip.rpt"
            Call Print_Manually()
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If cmdClose.Text = "&Cancel" Then
            cmdSave.Text = "&Save"
            cmdClose.Text = "&Close"
            cmdNew_Click(sender, e)
            Connection.Close()
            cmdSave.Enabled = False
            cmdLSlip.Enabled = False
            Me.DonorDataGrid.DataSource = Nothing
            Exit Sub
        End If
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub Donor_Profile(ByVal strChoice As String)
        Dim CommandText As String
        If strChoice = "ADD" Then
            If txtDName.Text = "" Or Len(txtDName.Text) = 0 Then
                'Skip Line
            Else
                MaxSeq = Format(Now, "yyMMdd") + Format(Val(lblSno.Text.Trim), "00") + txtRecNo.Text.Trim
                Dim IF_RECORD_EXIST As String = "SELECT COUNT(DONOR_ID) AS EXPR_1 FROM DONOR_TABLE WHERE DONOR_ID = " & Val(txtRecNo.Text) & " AND DONOR_NAME LIKE '%" & _
                                                StrConv(cmbDTitle.Text.Trim & Space(1) & txtDName.Text.Trim, VbStrConv.ProperCase) & "%'"
                Execute_DatabaseTable_Query(SqlDataAdapter, IF_RECORD_EXIST, Connection)
                Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                While Reader.Read
                    Return_Response = Reader.Item("EXPR_1")
                End While
                If Not Reader Is Nothing Then Reader.Close()
                If Return_Response = 0 Then
                    'Try
                    Execute_DatabaseTable_Query(SqlDataAdapter, "SELECT MAX(DONOR_PID) AS MAX_ID FROM DONOR_TABLE WHERE DONOR_ID = " & Val(txtRecNo.Text.Trim), Connection)
                    Dim Get_Max As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                    While Get_Max.Read
                        wDonor_Pid = Val(Get_Max.Item("MAX_ID").ToString) + 1
                    End While
                    If Not Get_Max Is Nothing Then Get_Max.Close()

                    CommandText = "INSERT INTO DONOR_TABLE VALUES (" & _
                                     Val(txtRecNo.Text) & ",'" & _
                                     StrConv(cmbDTitle.Text.Trim & Space(1) & txtDName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                     txtDYrs.Text.Trim & Space(2) & "Yrs" & "','" & _
                                     lblDSex.Text.Trim & "'," & _
                                     wDonor_Pid & ",'" & _
                                     Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "','x','x','x','x','x','x','x','" & _
                                     txtRefer.Text.Trim & "'," & Val(MaxSeq.Trim) & ",'" & txtCollPoint.Text.Trim & "')"

                    Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                    MultipleMode = True
                    'Catch Msg As Exception
                    '    MsgBox(Msg.Message)
                    'End Try
                End If
            End If
        End If

        SqlDataAdapter.SelectCommand = New SqlCommand()
        SqlDataAdapter.SelectCommand.Connection = Connection
        SqlDataAdapter.SelectCommand.CommandText = "SELECT * FROM DONOR_TABLE WHERE DONOR_ID = " & Val(txtRecNo.Text)
        If Connection.State = ConnectionState.Open Then Connection.Close()
        Connection.Open()
        SqlDataAdapter.SelectCommand.CommandType = CommandType.Text
        DataSet1.Clear()
        SqlDataAdapter.Fill(DataSet1, "DONOR_TABLE")
        Connection.Close()
        DonorDataGrid.DataSource = DataSet1
        DonorDataGrid.DataMember = "DONOR_TABLE"
        Connection.Close()

    End Sub

    Private Sub TestListView_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TestListView.MouseDoubleClick

        Dim si As Integer = TestListView.SelectedIndices(0)
        Dim delAmnt As Double
        delAmnt = Val(TestListView.Items(si).SubItems(5).Text.Trim)
        If MsgBox("Are you sure ot delete " & DelString, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Delete Test") = MsgBoxResult.Yes Then
            wTotal = wTotal - delAmnt
            txtTotal.Text = Val(txtTotal.Text) - delAmnt
            txtPaid.Text = Val(txtPaid.Text) - delAmnt
            If Val(txtDues.Text.Trim) > 0 Then txtDues.Text = Val(txtTotal.Text) - Val(txtDiscount.Text) - Val(txtPaid.Text) - (txtCompli.Text)
            TestListView.Items(si).Remove()
            DonorDataGrid.Refresh()
            TestListView.Refresh()
        End If

    End Sub

    Private Sub DonorDataGrid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DonorDataGrid.CellMouseClick
        If DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(0).Value Is Nothing Then Exit Sub
        DonorID = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(0).Value
        DonorPID = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value
        DonorName = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(2).Value.ToString
    End Sub

    Private Sub DonorDataGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DonorDataGrid.CellMouseDoubleClick

        If DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value Is Nothing Then Exit Sub
        Dim strName As String = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value.ToString
        If MsgBox("Are you sure ot delete " & strName, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Delete Donor") = MsgBoxResult.Yes Then
            Execute_DatabaseTable_Query(SqlDataAdapter, "DELETE FROM DONOR_TABLE WHERE DONOR_ID = " & Val(txtRecNo.Text) & " AND DONOR_NAME LIKE '%" & _
                                        StrConv(strName.Trim, VbStrConv.ProperCase) & "%'", Connection)
            DonorDataGrid.Rows.Remove(DonorDataGrid.CurrentRow)
            txtDName.Clear()
            cmbDTitle.Focus()
            DonorDataGrid.Refresh()
        End If

    End Sub

    Private Sub Print_Manually()
        Dim CommandText As String = String.Empty
        Call GetConnectionString()
        If DonorID = 0 And DonorPID = 0 Then
            MsgBox("Plz Select Donor to print receipt.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
        Try
            SqlDataSet.Clear()
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "LAB_PRO"
            PrintDialog.Cursor = Cursors.WaitCursor
            PrintDialog.ShowDialog()
            CommandText = "Select * from DONOR_TABLE WHERE donor_id = " & DonorID & " and donor_pid = " & DonorPID & " and donor_name = '" & DonorName & "'"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "donor_table", Connection)
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
            objReport.SetDataSource(SqlDataSet.Tables("donor_table"))
            With objReport
                ' Select Donor for print slip
                .RecordSelectionFormula = "{donor_table.donor_pid}=" & DonorPID
                ' For sent Report directly to Printer
                objReport.PrintToPrinter(1, False, 0, 0)
                '// For export report in pdf format if required uncommit the line
                'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\CrossMatchReceipt-" & DonorPID & ".pdf")
                PrintDialog.Cursor = Cursors.Default
                PrintDialog.Close()
            End With
            objReport.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub Get_CpRefer()
        If txtRefer.Text = "SELF" Or txtRefer.Text = "self" Then strCpName = "SELF" : Exit Sub
        ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, "Select * from CollectionPoint where CP_NAME = '" & Trim(txtRefer.Text.ToUpper) & "'", "CollectionPoint", Connection)
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
        Else
            strCpName = "SELF"
        End If

    End Sub

    Private Sub Get_CpRefer2()
        If cmbCollPoint.Text = "Select Collection Point" Or cmbCollPoint.Text = "LAB" Or cmbCollPoint.Text = "lab" Then strCpName = "LAB" : Exit Sub
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
        Else
            strCpName = "LAB"
        End If
    End Sub

    Private Sub Save_Data()
        Dim ChkRptLvl As Integer = 0, Return_Response As Integer = 0
        Dim Del_Rpt_Date As Integer = 0
        If txtRefer.Text = "" And txtCollPoint.Text = "" Then MsgBox("Please Select Reference.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        txtDues.Text = Val(txtTotal.Text.Trim) - Val(txtDiscount.Text.Trim) - Val(txtPaid.Text.Trim) - Val(txtCompli.Text.Trim)
        If Val(txtRecNo.Text.Trim) = 0 Or (txtRecNo.Text.Trim) = "" Then Exit Sub
        If SysOperator.Trim = "DEMO" Or SysOperator.Trim = "demo" Then
            MsgBox("Your are in learning mode, therefore entry cannot be saved.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName)
            Exit Sub
        End If
        Dim IF_EXIST_RECORD As String = "SELECT COUNT(P_NUM) AS EXPR_1 FROM PATIENT WHERE P_NUM = " & Val(txtRecNo.Text)
        Execute_DatabaseTable_Query(SqlDataAdapter, IF_EXIST_RECORD, Connection)
        Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        While Reader.Read
            Return_Response = Reader.Item("EXPR_1")
        End While
        If Not Reader Is Nothing Then Reader.Close()
        If Return_Response > 0 Then MsgBox("Record already Exist.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName) : Exit Sub
        If Val(txtCompli.Text) > 0 Then
            Rmks = Microsoft.VisualBasic.InputBox("Please write reason for Complimentry Case.", "Remarks")
            If Len(Rmks) = 0 Then Exit Sub
        Else
            Rmks = "x"
        End If
        Try
            '// Add Test Data into Receipt Table
            Dim iCount As Integer = TestListView.Items.Count
            Dim iLoop As Integer = 0
            Dim CommandText As String
            If iCount > 0 Then
                Do Until iLoop = iCount
                    Dim str As String = TestListView.Items(iLoop).SubItems(3).Text.ToString
                    CommandText = "INSERT INTO RECEIPT(TCASENO,TCODE,TNAME,TCATG,TRATE,TQTY,TDATE,TMODE,TDELETE,TRPTDATE) VALUES (" & _
                             Val(txtRecNo.Text) & ",'" & _
                             TestListView.Items(iLoop).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(1).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(2).Text & "'," & _
                             Val(TestListView.Items(iLoop).SubItems(5).Text) & ",1,'" & _
                             Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "','ADD',0,'" & Format(CDate(str.ToString), "MM/dd/yyyy") & "')"
                    Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                    CommandText = Nothing
                    iLoop += 1
                Loop
                iCount = 0
            End If
            Sub_Addition = False
            txtRecNo.Text = GenerateMax_ID("patient", "p_num")

            '// ADD NEW RECORD IN THE TABLE
            Dim svSql As String = "Select * from PATIENT WHERE P_NUM = " & Val(txtRecNo.Text)
            SqlDataAdapter = New SqlDataAdapter(svSql, Connection)
            SqlDataAdapter.Fill(svDataSet, "PATIENT")
            Connection.Close()

            Dim svCmdBuilder As New SqlCommandBuilder(SqlDataAdapter)
            Dim svDataRow As DataRow
            Dim strDate As DateTime = DateTime.Now
            SysOperator.Trim()

            svDataRow = svDataSet.Tables("PATIENT").NewRow()
            svDataRow.Item("P_NUM") = Val(txtRecNo.Text.Trim)
            svDataRow.Item("P_SNO") = Val(lblSno.Text.Trim)
            svDataRow.Item("P_NAME") = StrConv(cmbTitle.Text.Trim & Space(1) & txtName.Text.Trim, VbStrConv.ProperCase)
            svDataRow.Item("P_SPC_REFER") = "x"
            svDataRow.Item("P_AGE") = txtYrs.Text.Trim & Space(1) & "Yrs" & Space(1) & txtMth.Text.Trim & Space(1) & "Mth" & Space(1) & txtDay.Text.Trim & Space(1) & "Day"
            svDataRow.Item("P_SEX") = lblPSex.Text.Trim.ToUpper
            svDataRow.Item("P_DON_SEX") = "X"
            svDataRow.Item("P_DON_AGE") = "X"
            svDataRow.Item("P_PHONE") = txtContact.Text.Trim
            svDataRow.Item("P_SLIP_NUM") = 0
            svDataRow.Item("P_PANNEL") = 0
            svDataRow.Item("P_REF_BY") = StrConv(txtRefer.Text.Trim, VbStrConv.ProperCase)
            svDataRow.Item("P_REFER_2") = "x"
            svDataRow.Item("P_CP") = StrConv(txtCollPoint.Text.Trim, VbStrConv.Uppercase)
            svDataRow.Item("P_TOTAL") = Val(txtTotal.Text.Trim)
            svDataRow.Item("P_PAID") = Val(txtPaid.Text.Trim)
            svDataRow.Item("P_DUES") = Val(txtDues.Text.Trim)
            svDataRow.Item("P_DISCOUNT") = Val(txtDiscount.Text.Trim)
            svDataRow.Item("P_COMPLIMENT") = Val(txtCompli.Text.Trim)
            svDataRow.Item("P_CNIC") = txtCNIC.Text.Trim
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
            svDataRow.Item("P_DATE_SAMPLE") = Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy")
            svDataRow.Item("P_TIME_SAMPLE") = Format(Now, "hh:mm tt")
            If cmbVisitor.Text = "" Then svDataRow.Item("P_VISITOR") = "X" Else svDataRow.Item("P_VISITOR") = StrConv(cmbVisitor.Text.Trim, VbStrConv.Uppercase)

            If Val(txtCompli.Text.Trim) > 0 Then
                svDataRow.Item("P_DEL_OK") = "YES"
                svDataRow.Item("P_DEL_DATE") = Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy")
                svDataRow.Item("P_DEL_TIME") = Format(Now, "hh:mm tt")
                svDataRow.Item("P_DEL_OPERATOR") = SysOperator
                svDataRow.Item("P_COMP_BY") = SysOperator
                svDataRow.Item("P_COMP_ON") = Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy")
                svDataRow.Item("P_EDIT_BY") = SysOperator
                svDataRow.Item("P_EDIT_ON") = Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy")
            End If

            svDataRow.Item("P_RPT_DATE") = Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy")
            svDataRow.Item("P_RPT_TIME") = Format(Now, "hh:mm tt")
            svDataRow.Item("P_DEL_TIME") = Format(Now, "hh:mm tt")
            svDataRow.Item("P_OPERATOR") = SysOperator.Trim
            svDataRow.Item("P_REASON") = Rmks.Trim
            svDataRow.Item("P_STATUS") = "RECEPTION"
            svDataRow.Item("P_P_AMOUNT") = 0
            svDataRow.Item("P_SEQUENCE") = Format(Now, "yyMMdd") + Format(Val(lblSno.Text.Trim), "00") + txtRecNo.Text.Trim

            '// SAVE DATA ROW IN THE TABLE
            svDataSet.Tables("PATIENT").Rows.Add(svDataRow)
            SqlDataAdapter.Update(svDataSet, "PATIENT")

            cmdDelete.Enabled = False
            cmdSave.Enabled = False
            Me.ProcessTabKey(False)
            cmdLSlip.Enabled = True
            gblDiscount = 0
            intCpDiscount = 0
            strRptLvl = 1
            cmdSave.Focus()
            Call Donor_Profile("ADD")
        Catch SqlEx As SqlException
            MsgBox(SqlEx.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        Connection.Close()
    End Sub

    Private Sub Update_Data()
        Dim ChkRptLvl As Integer = 0
        Dim myAge = "", mySql As String = ""
        myAge = txtYrs.Text.Trim & Space(1) & "Yrs"

        '// In case of any payment / discount / dues return after post date
        Try
            Rmks = Microsoft.VisualBasic.InputBox("Please write reason for modification.", "Remarks")
            If Len(Rmks) = 0 Then Exit Sub
            '// Execute Qeury to update record in database
            mySql = "UPDATE PATIENT SET P_NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_SPC_REFER = '" & "X" & "'," & _
                    " P_AGE = '" & txtYrs.Text.Trim & Space(1) & "Yrs" & Space(1) & txtMth.Text.Trim & Space(1) & "Mth" & Space(1) & txtDay.Text.Trim & Space(1) & "Day" & "'," & _
                    " P_DATE_SAMPLE = '" & Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                    " P_SEX = '" & lblPSex.Text.Trim & "'," & _
                    " P_CNIC = '" & txtCNIC.Text.Trim & "'," & _
                    " P_REF_BY = '" & StrConv(txtRefer.Text.Trim, VbStrConv.ProperCase) & "'," & _
                    " P_CP = '" & StrConv(txtCollPoint.Text.Trim, VbStrConv.Uppercase) & "'," & _
                    " P_TOTAL = " & Val(txtTotal.Text.Trim) & "," & _
                    " P_PAID = " & Val(txtPaid.Text.Trim) & "," & _
                    " P_DUES = " & Val(txtDues.Text.Trim) & "," & _
                    " P_DISCOUNT = " & Val(txtDiscount.Text.Trim) & "," & _
                    " P_AFT_DATE = '" & Format(Now, "MM/dd/yyyy") & "'," & _
                    " P_RPT_DATE = '" & Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "'," & _
                    " P_DISC_BY = '" & SysOperator.ToUpper.Trim & "'," & _
                    " P_EDIT_ON = '" & Format(Now, "MM/dd/yyyy") & "'," & _
                    " P_EDIT_OPR = '" & SysOperator.ToUpper & "'," & _
                    " P_EDIT_BY = '" & SysOperator.ToUpper.Trim & "'," & _
                    " P_DEL_OK = 'x'," & _
                    " P_DUE_RCV = 0," & _
                    " P_COMPLIMENT = " & Val(txtCompli.Text.Trim) & "," & _
                    " P_P_AMOUNT = " & Val(txtCompli.Text.Trim) & "," & _
                    " P_REASON = '" & StrConv(Rmks.Trim, VbStrConv.Uppercase) & "'," & _
                    " P_SNO = " & Val(lblSno.Text.Trim) & "," & _
                    " P_VISITOR = '" & cmbVisitor.Text.Trim & "'" & _
                    " WHERE P_NUM = " & Val(txtRecNo.Text)

            Execute_DatabaseTable_Query(SqlDataAdapter, mySql, Connection)
            '// Delete Selected Record from Receipt
            Dim CommandText, Str As String
            CommandText = "DELETE FROM RECEIPT WHERE TCASENO = " & Val(txtRecNo.Text)
            Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
            '// Add Test Data into Receipt Table
            Dim iCount As Integer = TestListView.Items.Count
            Dim iLoop As Integer = 0
            If iCount > 0 Then
                Do Until iLoop = iCount
                    Str = TestListView.Items(iLoop).SubItems(3).Text.ToString
                    CommandText = "INSERT INTO RECEIPT(TCASENO,TCODE,TNAME,TCATG,TRATE,TQTY,TDATE,TMODE,TDELETE,TRPTDATE) VALUES (" & _
                             Val(txtRecNo.Text) & ",'" & _
                             TestListView.Items(iLoop).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(1).Text & "','" & _
                             TestListView.Items(iLoop).SubItems(2).Text & "'," & _
                             Val(TestListView.Items(iLoop).SubItems(5).Text) & ",1,'" & _
                             Format(DateTime.Parse(DateTime.Now.ToShortDateString.ToString), "MM/dd/yyyy") & "','EDT',0,'" & Format(DateTime.Parse(CDate(Str)), "MM/dd/yyyy") & "')"
                    Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                    CommandText = String.Empty
                    iLoop += 1
                Loop
                iCount = 0
            End If
            cmdDelete.Enabled = False
            Call Donor_Profile("ADD")
            cmdSave.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        SqlDataAdapter.Dispose()
        Connection.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtDName.Text = String.Empty Or Len(txtDName.Text) > 3 Then
            If cmdSave.Text = "&Save" Then Call Save_Data()
            If cmdSave.Text = "&Update" Then Call Update_Data()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ReferCode.ShowDialog(Me)
        If Len(gblRefer) > 0 Then
            txtRefer.Text = StrConv(gblRefer.Trim, VbStrConv.ProperCase)
            Call Get_CpRefer()
            cmbCollPoint.Focus()
            Exit Sub
        Else
            Exit Sub
        End If
    End Sub
End Class