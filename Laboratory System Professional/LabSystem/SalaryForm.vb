Public Class SalaryForm

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        gblSalaryAdd = False
        gblSalaryEdit = False
        Me.Close()
    End Sub

    Private Sub SalaryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Text = gblEmpName.Trim
        If gblSalaryEdit = True And gblSalaryAdd = False Then
            dtpDate.Text = Payroll.dgvSalary.Rows(Payroll.dgvSalary.CurrentRow.Index).Cells(0).Value.ToString
            cmbPosition.Text = Payroll.dgvSalary.Rows(Payroll.dgvSalary.CurrentRow.Index).Cells(1).Value.ToString
            txtRemarks.Text = Payroll.dgvSalary.Rows(Payroll.dgvSalary.CurrentRow.Index).Cells(2).Value.ToString
            txtSalary.Text = Payroll.dgvSalary.Rows(Payroll.dgvSalary.CurrentRow.Index).Cells(3).Value.ToString
            cmbType.Text = Payroll.dgvSalary.Rows(Payroll.dgvSalary.CurrentRow.Index).Cells(4).Value.ToString
        Else
            txtRemarks.Clear()
            txtSalary.Clear()
            cmbPosition.Text = String.Empty
            cmbType.Text = String.Empty
            dtpDate.Value = Now
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim SalaryQuery As String = String.Empty

        If gblSalaryAdd = True Then
            SalaryQuery = "insert into salary_info values('" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','" & _
                          Format(DateTime.Parse(dtpDate.Value.ToShortDateString), "MM/dd/yyyy") & "','" & _
                          StrConv(cmbPosition.Text.Trim, VbStrConv.ProperCase) & "','" & _
                          StrConv(cmbType.Text.Trim, VbStrConv.ProperCase) & "','" & _
                          StrConv(txtRemarks.Text.Trim, VbStrConv.ProperCase) & "','" & _
                          Val(txtSalary.Text.Trim) & "')"
        End If

        If gblSalaryEdit = True Then
            SalaryQuery = "update salary_info set EmployeeName = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "'," & _
                          " IncreaseOn = '" & Format(DateTime.Parse(dtpDate.Value.ToShortDateString), "MM/dd/yyyy") & "'," & _
                          " Position = '" & StrConv(cmbPosition.Text.Trim, VbStrConv.ProperCase) & "'," & _
                          " Type = '" & StrConv(cmbType.Text.Trim, VbStrConv.ProperCase) & "'," & _
                          " Note = '" & StrConv(txtRemarks.Text.Trim, VbStrConv.ProperCase) & "'," & _
                          " Rate = " & Val(txtSalary.Text.Trim)
        End If

        Execute_DatabaseTable_Query(SqlDataAdapter, SalaryQuery, Connection)
        gblSalaryAdd = False
        gblSalaryEdit = False
        Me.Close()

    End Sub

    Private Sub txtSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalary.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar.ToString.Equals(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) Then e.Handled = True
    End Sub
End Class