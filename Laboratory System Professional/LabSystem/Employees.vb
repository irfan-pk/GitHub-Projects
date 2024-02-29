Imports System.IO
Imports System.Data.SqlClient

Public Class Employees
    Dim EditString As String = String.Empty
    Dim CheckSheet As String = String.Empty
    Dim addMode As Boolean = False
    Dim editMode As Boolean = False
    Dim SheetExist As Boolean = False
    Dim currentpath As String = Directory.GetCurrentDirectory()

    Private Sub Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Call LoadData()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        EmpTabControl.SelectTab(0)
        addMode = True
        editMode = False
        Panel1.Enabled = True
        cmbTitle.Focus()
        Me.ToolStripCloseButton.Text = "&Cancel"
        Me.BindingNavigatorSave.Enabled = True
        cmbTitle.Focus()
    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If Me.ToolStripCloseButton.Text = "&Cancel" Then
            Me.BindingNavigatorSave.Enabled = False
            Me.ToolStripCloseButton.Text = "&Close"
            Panel1.Enabled = False
            Call RefreshDB()
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click
        If addMode = True And editMode = False Then
            Dim IDSql As String = "Select Max(EmployeeID) AS MAX_ID from EMPLOYEES"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, IDSql, "EMPLOYEES", Connection)
            Dim IDReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader()
            While IDReader.Read
                txtEmpId.Text = Val(Convert.ToString(IDReader.Item("MAX_ID"))) + 1
            End While
            If Not IDReader Is Nothing Then IDReader.Close()
        End If

        '// If changes made in selected record then execute update record query
        If editMode = True And addMode = False Then Call BindingNavigatorQuery("UPDATE EMPLOYEES SET" & _
                                                           " TITLE = '" & StrConv(cmbTitle.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " FIRSTNAME = '" & StrConv(txtFName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " LASTNAME = '" & StrConv(txtLName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " DOB = '" & Format(DateTime.Parse(dtpDOB.Value.ToShortDateString), "MM/dd/yyyy") & "'," & _
                                                           " CNIC = '" & StrConv(txtCNIC.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " GENDER = '" & StrConv(cmbGender.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " MARITAL = '" & StrConv(cmbMarital.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " DEPARTMENT = '" & StrConv(cmbDept.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " POSITION = '" & StrConv(cmbDesignation.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " HIREDATE = '" & Format(DateTime.Parse(dtpDOB.Value.ToShortDateString), "MM/dd/yyyy") & "'," & _
                                                           " SHIFT = '" & StrConv(cmbShift.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " ADDRESS = '" & StrConv(txtAddrs.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " CITY = '" & StrConv(txtCity.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " MOBILE = '" & txtMobile.Text.Trim & "'," & _
                                                           " HOMEPHONE = '" & txtLandLine.Text.Trim & "'," & _
                                                           " EMAIL = '" & StrConv(txtEmail.Text.Trim, VbStrConv.Lowercase) & "'," & _
                                                           " STATUS = '" & StrConv(cmbStatus.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                                           " DOB = '" & Format(DateTime.Parse(dtpEndDate.Value.ToShortDateString), "MM/dd/yyyy") & "'," & _
                                                           " SALARY = " & Val(txtSalary.Text.Trim) & "," & _
                                                           " AREAR = " & Val(txtArear.Text.Trim) & _
                                                           " WHERE EMPLOYEEID = " & Val(EditString))

        '// if entered new values in text boxes then execute add record query
        If addMode = True And editMode = False Then Call BindingNavigatorQuery("INSERT INTO EMPLOYEES VALUES(" & Val(txtEmpId.Text.Trim) & ",'" & _
                                                           StrConv(cmbTitle.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtFName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtLName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           Format(DateTime.Parse(dtpDOB.Value.ToShortDateString), "MM/dd/yyyy") & "','" & _
                                                           StrConv(txtCNIC.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(cmbGender.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(cmbMarital.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(cmbDept.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(cmbDesignation.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           Format(DateTime.Parse(dtpDOB.Value.ToShortDateString), "MM/dd/yyyy") & "','" & _
                                                           StrConv(cmbShift.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtAddrs.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           StrConv(txtCity.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           txtMobile.Text.Trim & "','" & _
                                                           txtLandLine.Text.Trim & "','" & _
                                                           StrConv(txtEmail.Text.Trim, VbStrConv.Lowercase) & "','" & _
                                                           StrConv(cmbStatus.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                                           Format(DateTime.Parse(dtpEndDate.Value.ToShortDateString), "MM/dd/yyyy") & "'," & _
                                                           Val(txtSalary.Text.Trim) & "," & _
                                                           Val(txtArear.Text.Trim) & ")")

        Call RefreshDB()
        BindingNavigatorSave.Enabled = False
        editMode = False
        addMode = False
        ToolStripEditButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Close"
        Panel1.Enabled = False
    End Sub

    Private Sub BindingNavigatorQuery(ByVal Query As String)
        'Try
        Execute_DatabaseTable_Query(SqlDataAdapter, Query, Connection)
        Connection.Close()
        SqlDataAdapter.Dispose()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        'End Try
    End Sub

    Private Sub RefreshDB()
        Try
            Me.EmpDataSet.Clear()
            SqlDataAdapter.Dispose()
            Dim QueryText As String = "SELECT * FROM EMPLOYEES ORDER BY EMPLOYEEID"
            Execute_DatabaseTable_Query(SqlDataAdapter, QueryText, Connection)
            SqlDataAdapter.Fill(Me.EmpDataSet, "EMPLOYEES")
            Me.EmpBindingSource.DataSource = Me.EmpDataSet
            Me.EmpBindingSource.DataMember = "EMPLOYEES"
            Me.dgvEmpList.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub LoadData()
        Try
            Dim FillList As String = "select * from employees order by employeeid"
            Execute_DatabaseTable_Query(SqlDataAdapter, FillList, Connection)
            SqlDataAdapter.Fill(Me.EmpDataSet, "Employees")
            Me.EmpBindingSource.DataSource = Me.EmpDataSet
            Me.EmpBindingSource.DataMember = "employees"
            Me.txtEmpId.DataBindings.Add("TEXT", EmpBindingSource, "EMPLOYEEID")
            Me.cmbTitle.DataBindings.Add("TEXT", EmpBindingSource, "TITLE")
            Me.txtFName.DataBindings.Add("TEXT", EmpBindingSource, "FIRSTNAME")
            Me.txtLName.DataBindings.Add("TEXT", EmpBindingSource, "LASTNAME")
            Me.dtpDOB.DataBindings.Add("TEXT", EmpBindingSource, "DOB")
            Me.txtCNIC.DataBindings.Add("TEXT", EmpBindingSource, "CNIC")
            Me.cmbGender.DataBindings.Add("TEXT", EmpBindingSource, "GENDER")
            Me.cmbMarital.DataBindings.Add("TEXT", EmpBindingSource, "MARITAL")
            Me.cmbDept.DataBindings.Add("TEXT", EmpBindingSource, "DEPARTMENT")
            Me.cmbDesignation.DataBindings.Add("TEXT", EmpBindingSource, "POSITION")
            Me.dtpHire.DataBindings.Add("TEXT", EmpBindingSource, "HIREDATE")
            Me.cmbShift.DataBindings.Add("TEXT", EmpBindingSource, "SHIFT")
            Me.txtAddrs.DataBindings.Add("TEXT", EmpBindingSource, "ADDRESS")
            Me.txtCity.DataBindings.Add("TEXT", EmpBindingSource, "CITY")
            Me.txtMobile.DataBindings.Add("TEXT", EmpBindingSource, "MOBILE")
            Me.txtLandLine.DataBindings.Add("TEXT", EmpBindingSource, "HOMEPHONE")
            Me.txtEmail.DataBindings.Add("TEXT", EmpBindingSource, "EMAIL")
            Me.cmbStatus.DataBindings.Add("TEXT", EmpBindingSource, "STATUS")
            Me.dtpEndDate.DataBindings.Add("TEXT", EmpBindingSource, "LEAVEDATE")
            Me.txtSalary.DataBindings.Add("TEXT", EmpBindingSource, "SALARY")
            Me.txtArear.DataBindings.Add("TEXT", EmpBindingSource, "AREAR")
            dgvEmpList.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub dgvEmpList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvEmpList.KeyDown
        If dgvEmpList.RowCount > 0 Then
            If e.KeyCode = Keys.Enter Then
                gblEmpName = dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(0).Value.ToString & " " & dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(1).Value.ToString
            End If
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If EmpTabControl.SelectedIndex = 1 Then
            If dgvEmpList.RowCount > 0 Then gblEmpName = dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(0).Value.ToString & " " & dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(1).Value.ToString
            gblSalaryAdd = True
            gblSalaryEdit = False
            SalaryForm.ShowDialog()
        End If
        Call ShowRows()
    End Sub

    Private Sub dgvEmpList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpList.CellClick
        If dgvEmpList.RowCount > 0 Then _
        gblEmpName = dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(0).Value.ToString & " " & dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(1).Value.ToString
    End Sub

    Private Sub dgvEmpList_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvEmpList.MouseClick
        If dgvEmpList.RowCount > 0 Then
            gblEmpName = dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(0).Value.ToString & " " & dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(1).Value.ToString
            If EmpTabControl.SelectedIndex = 1 Then
                Call ShowRows()
            End If

            'For get rows of Employee advance
            If EmpTabControl.SelectedIndex = 2 Then
                Call ShowAdvances()
            End If

        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If dgvEmpList.RowCount > 0 Then _
            gblEmpName = dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(0).Value.ToString & " " & dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(1).Value.ToString
        If EmpTabControl.SelectedIndex = 1 Then
            gblSalaryAdd = False
            gblSalaryEdit = True
            SalaryForm.ShowDialog()
        End If
        Call ShowRows()
    End Sub

    Private Sub EmpTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmpTabControl.SelectedIndexChanged
        If dgvEmpList.RowCount > 0 Then
            gblEmpName = dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(0).Value.ToString & " " & dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(1).Value.ToString
            If EmpTabControl.SelectedIndex = 1 Then Call ShowRows()
            If EmpTabControl.SelectedIndex = 2 Then Call ShowAdvances()
            If EmpTabControl.SelectedIndex = 3 Then dgvFinalSalary.Columns("colPayMonth").Visible = False
        End If
    End Sub

    Public Sub ShowRows()
        SalaryDataSet.Clear()
        Dim ShowRows As String = "select * from salary_info where EmployeeName = '" & gblEmpName.Trim & "' order by IncreaseOn desc"
        Execute_DatabaseTable_Query(SqlDataAdapter, ShowRows, Connection)
        SqlDataAdapter.Fill(SalaryDataSet, "salary_info")
        SalaryBindingSource.DataSource = SalaryDataSet
        SalaryBindingSource.DataMember = "salary_info"
        dgvSalary.Refresh()
        dgvEmpList.Refresh()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If dgvSalary.RowCount > 0 Then
            If MsgBox("Are you sure to delete the entry for " & gblEmpName.Trim & " ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
                Dim CommandText As String = "DELETE FROM SALARY_INFO WHERE EMPLOYEENAME = N'" & gblEmpName.Trim & "' AND INCREASEON = '" & Format(DateTime.Parse(dgvSalary.Rows(dgvSalary.CurrentRow.Index).Cells(0).Value.ToString), "MM/dd/yyyy") & "'"
                Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                Me.dgvSalary.Update()
                Call ShowRows()
            Else
                'skip
                Call ShowRows()
            End If
        End If
    End Sub

    Private Sub txtAdvance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdvance.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString.Equals(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) Then e.Handled = True
    End Sub

    Public Sub GetEmployeeInfo(ByVal EmployeeName As String)
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select * from EMPLOYEES where FIRSTNAME = N'" & EmployeeName.Trim & "'")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    If reader.HasRows Then
                        While reader.Read
                            gblEmpID = reader.Item("EmployeeID").ToString
                        End While
                    End If
                End Using
            End Using
            sqlConnection.Close()
        End Using
    End Sub

    Private Sub ShowAdvances()
        Me.AdvDataSet.Clear()
        txtID.Clear()
        txtName.Clear()
        txtAdvance.Clear()
        cmbApprove.ResetText()
        Call GetEmployeeInfo(dgvEmpList.Rows(dgvEmpList.CurrentRow.Index).Cells(0).Value.ToString)
        txtID.Text = gblEmpID
        txtName.Text = gblEmpName
        Dim StringMonth As String = Format(dtpAdvDate.Value, "MM/yyyy")
        Dim gRows As String = "select * from salary_advances where MONTH = '" & StringMonth.Trim & "' order by AdvDate Desc"
        Execute_DatabaseTable_Query(SqlDataAdapter, gRows, Connection)
        SqlDataAdapter.Fill(Me.AdvDataSet, "salary_advances")
        Me.AdvBindingSource.DataSource = Me.AdvDataSet
        Me.AdvBindingSource.DataMember = "salary_advances"
        Me.dgvAdvances.Refresh()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Val(txtAdvance.Text.Trim) > 0 Then
            Dim StringMonth As String = Format(dtpAdvDate.Value, "MM/yyyy")
            Dim SaveAdvQuery As String = "insert into salary_advances values('" & Val(txtID.Text.Trim) & "','" & _
                                         StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                                         StringMonth & "','" & _
                                         Format(DateTime.Parse(dtpAdvDate.Value.ToShortDateString), "MM/dd/yyyy") & "'," & _
                                         Val(txtAdvance.Text.Trim) & ",'" & _
                                         StrConv(cmbApprove.Text.Trim, VbStrConv.ProperCase) & "')"
            Execute_DatabaseTable_Query(SqlDataAdapter, SaveAdvQuery, Connection)
            Call ShowAdvances()
        End If
    End Sub

    Private Sub dtpAdvDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpAdvDate.KeyDown
        If e.KeyCode = Keys.Enter Then txtAdvance.Focus()
    End Sub

    Private Sub dtpAdvDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpAdvDate.ValueChanged
        Call ShowAdvances()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgvAdvances.RowCount > 0 Then
            Dim EmpID As Integer = Val(dgvAdvances.Rows(dgvAdvances.CurrentRow.Index).Cells(0).Value.ToString)
            If MsgBox("Are you sure to delete the entry of " & gblEmpName.Trim & " (" & dgvAdvances.Rows(dgvAdvances.CurrentRow.Index).Cells(3).Value.ToString & ") ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
                Dim CommandText As String = "DELETE FROM SALARY_ADVANCES WHERE EMPLOYEEID = " & EmpID & " AND ADVDATE = '" & Format(DateTime.Parse(dgvAdvances.Rows(dgvAdvances.CurrentRow.Index).Cells(3).Value.ToString), "MM/dd/yyyy") & "'"
                Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
                Me.dgvAdvances.Update()
                Call ShowAdvances()
            Else
                'skip
                Call ShowAdvances()
            End If
        End If
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        CheckSheet = "select * from salary_sheet where salarymonth = N'" & Format(DateTime.Parse(dtpMonth.Value.ToShortDateString), "MMM - yyyy") & "' order by empid"
        ExecuteSqlQuery(PaySqlAdapter, PayDataSet, CheckSheet, "salary_sheet", Connection)
        Dim Reader As SqlDataReader = PaySqlAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                If Reader.Item("STATUS").ToString <> "OPEN" Then
                    MsgBox("Salary Sheet finalized for this month.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                    Exit While
                End If
            End While
            SheetExist = True
        Else
            SheetExist = False
        End If

        If SheetExist = False Then
            Dim diff As Integer = DateDiff(DateInterval.Month, dtpMonth.Value, Now)
            If diff <> 1 Then
                MsgBox("Cannot Get Salary Data, Invalid month.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
                Exit Sub
            End If
            Dim CopyNewRows As String = "insert into salary_sheet(empid,empname,designation,empsalary,emparears,salarymonth,prepareby,status) " & _
                                        "select employeeid,firstname + ' ' + lastname,position,salary,arear,'" & Format(DateTime.Parse(dtpMonth.Value.ToShortDateString), "MMM - yyyy") & "','" & SysOperator.Trim & "','" & "OPEN" & "' from employees"
            Execute_DatabaseTable_Query(PaySqlAdapter, CopyNewRows, Connection)
            Call CalculateAdvances()
        End If
        Reader.Close()
        Call RefreshSheetGrid()
    End Sub

    Private Sub CalculateAdvances()
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim cmdText As String = _
           ("select employeeid, sum(amount) as total_adv from salary_advances where month = N'" & Format(dtpMonth.Value, "MM/yyyy") & "' group by EmployeeID")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    If reader.HasRows Then
                        While reader.Read
                            Call ProcessTransaction("update salary_sheet set empadvance = " & Val(reader.Item("total_adv").ToString) & " where empid = " & Val(reader.Item("employeeid").ToString) & " and salarymonth = N'" & Format(dtpMonth.Value, "MMM - yyyy") & "'")
                        End While
                    End If
                    If reader Is Nothing Then reader.Close()
                End Using
            End Using
            sqlConnection.Close()
        End Using
    End Sub

    Private Sub RefreshSheetGrid()
        PayDataSet.Clear()
        Execute_DatabaseTable_Query(PaySqlAdapter, CheckSheet, Connection)
        PaySqlAdapter.Fill(PayDataSet, "salary_sheet")
        Me.PayBindingSource.DataSource = PayDataSet
        Me.PayBindingSource.DataMember = "salary_sheet"
        With dgvFinalSalary
            For i = 0 To dgvFinalSalary.RowCount - 1
                .Rows(i).Cells(7).Value = Val(.Rows(i).Cells(5).Value.ToString) + Val(.Rows(i).Cells(6).Value.ToString)
                .Rows(i).Cells(9).Value = Val(.Rows(i).Cells(3).Value.ToString) - Val(.Rows(i).Cells(8).Value.ToString)
                .Rows(i).Cells(10).Value = Val(.Rows(i).Cells(7).Value.ToString) - Val(.Rows(i).Cells(8).Value.ToString)
            Next
        End With
        Me.dgvFinalSalary.Refresh()
    End Sub

    Private Sub dgvFinalSalary_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFinalSalary.CellEndEdit
        'Formula to calculate salary and closing balance after deduction
        With dgvFinalSalary
            If .RowCount > 0 Then
                .Rows(.CurrentRow.Index).Cells(9).Value = (Val(.Rows(.CurrentRow.Index).Cells(3).Value.ToString) + Val(.Rows(.CurrentRow.Index).Cells(4).Value.ToString)) - Val(.Rows(.CurrentRow.Index).Cells(8).Value.ToString)
                .Rows(.CurrentRow.Index).Cells(10).Value = Val(.Rows(.CurrentRow.Index).Cells(7).Value.ToString) - Val(.Rows(.CurrentRow.Index).Cells(8).Value.ToString)
            End If
        End With
    End Sub

    Private Sub dgvFinalSalary_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvFinalSalary.EditingControlShowing
        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Me.dgvFinalSalary_KeyPress
    End Sub

    Private Sub dgvFinalSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvFinalSalary.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click
        addMode = False
        editMode = True
        Panel1.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        Me.BindingNavigatorSave.Enabled = True
        cmbTitle.Focus()
    End Sub

    Private Sub btnFinalize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalize.Click
        Dim diff As Integer = DateDiff(DateInterval.Month, dtpMonth.Value, Now)
        If diff <> 1 Then
            MsgBox("Cannot Finalize Salary, Invalid month.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        End If
        If dgvFinalSalary.RowCount > 0 Then
            If MsgBox("Are you sure to finalize the salary of month ( " & Format(DateTime.Parse(dtpMonth.Value.ToShortDateString), "MMM - yyyy") & " ) ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
                'Update salary to their respective employees
                Call Update_Salary()
                Call RefreshDB()
            Else
                'skip
            End If
        End If
    End Sub

    Private Sub Update_Salary()
        With dgvFinalSalary
            For k = 0 To .RowCount - 1
                Dim QueryCommand As String = "update salary_sheet set empbonus = " & Val(.Rows(k).Cells(4).Value.ToString) & "," & _
                                             "emparears = " & Val(.Rows(k).Cells(5).Value.ToString) & "," & _
                                             "empadvance = " & Val(.Rows(k).Cells(6).Value.ToString) & "," & _
                                             "empdeduction = " & Val(.Rows(k).Cells(8).Value.ToString) & "," & _
                                             "empnetsalary = " & Val(.Rows(k).Cells(9).Value.ToString) & "," & _
                                             "empclosbal = " & Val(.Rows(k).Cells(10).Value.ToString) & "," & _
                                             "status = 'FINALIZED' " & _
                                             "where empid = " & Val(.Rows(k).Cells(1).Value.ToString) & " and salarymonth = N'" & Format(dtpMonth.Value, "MMM - yyyy") & "'"
                Call ProcessTransaction(QueryCommand)
                Dim UpdateArrear As String = "update employees set arear = " & Val(.Rows(k).Cells(10).Value.ToString) & " where employeeid = " & Val(.Rows(k).Cells(1).Value.ToString)
                Call ProcessTransaction(UpdateArrear)
            Next
        End With
    End Sub

    Private Sub btnReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReverse.Click
        If gblPrliviges > 1 Then
            MsgBox("You are not authorized. plz contact to administrator.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
        If MsgBox("Are you roll back salary sheet for the month of " & Format(dtpMonth.Value, "MMM - yyyy"), MsgBoxStyle.OkCancel, "Rollback Salary") = MsgBoxResult.Ok Then
            With dgvFinalSalary
                For k = 0 To .RowCount - 1
                    Dim UpdateArrear As String = "update employees set arear = " & Val(.Rows(k).Cells(5).Value.ToString) & " where employeeid = " & Val(.Rows(k).Cells(1).Value.ToString)
                    If Val(.Rows(k).Cells(10).Value.ToString) > 0 And .Rows(k).Cells(10).Value.ToString = "FINALIZED" Then Call ProcessTransaction(UpdateArrear)
                Next
                Call ProcessTransaction("delete from salary_sheet where salarymonth = N'" & Format(dtpMonth.Value, "MMM - yyyy") & "'")
                Call RefreshSheetGrid()
            End With
            Call RefreshDB()
        End If
    End Sub

    Private Sub cmdAdvPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdvPrint.Click
        If EmpTabControl.SelectedIndex = 2 Then
            gblReportName = currentpath & "\" & "Reports\StaffAdvance.rpt"
            gblPayrolMonth = Format(dtpAdvDate.Value, "MM/yyyy")
            gblReportOption = "Advance"
            SalaryReports.Show()
        End If
    End Sub

    Private Sub cmdSalPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalPrint.Click
        If EmpTabControl.SelectedIndex = 3 Then
            gblReportName = currentpath & "\" & "Reports\StaffSalary.rpt"
            gblPayrolMonth = Format(dtpMonth.Value, "MMM - yyyy")
            gblReportOption = "Salary"
            SalaryReports.Show()
        End If
    End Sub
End Class