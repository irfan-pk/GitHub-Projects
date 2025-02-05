Imports System.Data.SqlClient

Public Class CoustomerLedger
    Dim cmdText, Clos_Balance As String
    Dim Max_ID, Max_Transaction As Integer
    Dim InvoiceAdapter As New SqlDataAdapter
    Dim InvoiceDataSet As New DataSet()
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub CoustomerLedger_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CustomerMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CoustomerLedger_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + 5)
        Me.btnUpdate.Left = Me.Width - (btnUpdate.Width + cmdClose.Width + 45)
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 40)
        Call GetConnectionString()
        Call Popup_Data("SELECT * FROM CUSTOMERS_PAYM WHERE CUST_UPT_DT = N'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY CUST_TR_ID")
        Connection.Close()
        txtID.Focus()
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        CustomerMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Get_New_Record()
        txtDescription.Clear()
        txtDebit.Text = "00"
        txtCredit.Text = "00"
        txtID.Clear()
        txtName.Clear()
        txtID.Focus()
    End Sub

    Private Sub txtDebit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDebit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtID.Text.Trim <> String.Empty Or Val(txtID.Text.Trim) <> 0 Then
                If Val(txtDebit.Text.Trim) > 0 Then Call Updt_General_Journal("DEBIT", txtDescription.Text.Trim)
            Else
                MessageBox.Show("Please Select valid customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtDebit, txtDebit)
    End Sub

    Private Sub txtCredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtID.Text.Trim <> String.Empty Or Val(txtID.Text.Trim) <> 0 Then
                If Val(txtCredit.Text.Trim) > 0 Then Call Updt_General_Journal("CREDIT", txtDescription.Text.Trim)
            Else
                MessageBox.Show("Please Select valid customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtCredit, txtCredit)
    End Sub

    Private Sub txtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtID.Text) > 0 Then gblCP_ID = txtID.Text.Trim
            Dim CommandText As String = "SELECT * FROM CUSTOMERS WHERE CUST_CODE = N'" & Val(gblCP_ID) & "'"
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            Dim GetName As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GetName.HasRows Then
                While GetName.Read
                    txtName.Text = GetName.Item("CUST_NAME").ToString.Trim
                    txtAddress.Text = GetName.Item("CUST_ADDRESS").ToString.Trim & Space(1) & GetName.Item("CUST_CITY").ToString.Trim
                End While
                If GetName Is Nothing Then GetName.Close()
                Call Popup_Data("SELECT * FROM CUSTOMERS_PAYM WHERE CUST_CODE = N'" & Val(gblCP_ID) & "' ORDER BY CUST_TR_ID")
                txtVoucher.Focus()
            Else
                MsgBox("Please give valid ID.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            End If
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtID, txtID)
    End Sub

    Private Sub txtID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyUp
        If e.KeyCode = Keys.F2 Then
            Get_New_Record()
            CustomerCode.ShowDialog(Me)
            If Val(gblCP_ID) > 0 Then txtID.Text = gblCP_ID
            txtID_KeyDown(sender, e)
        End If
    End Sub

    Private Sub Popup_Data(ByVal StrQuery As String)
        Try
            Max_Transaction = GenerateMax_ID("CUSTOMERS_PAYM", "CUST_TR_ID")
            txtTran.Text = Max_Transaction.ToString.Trim
            Me.PaymentDataSet.Clear()
            Dim CommandText As String = StrQuery
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            SqlDataAdapter.Fill(Me.PaymentDataSet, "CUSTOMERS_PAYM")
            Me.PayBindingSource.DataSource = Me.PaymentDataSet
            Me.PayBindingSource.DataMember = "CUSTOMERS_PAYM"
            objCellStyle.BackColor = Color.WhiteSmoke
            PaymentDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub Updt_General_Journal(ByVal PayType As String, ByVal LedgDescription As String)
        'Function to debit/credit payments
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim Supplier_Code, Opn_Bal, Clo_Bal, Amount As Double
        Supplier_Code = 0
        Opn_Bal = 0
        Clo_Bal = 0
        Amount = 0
        Dim Get_Supplier As String = "select * from customers where cust_code = N'" & Val(txtID.Text.Trim) & "'"
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Supplier_Code = SuppliersReader.Item("CUST_CODE").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("CUST_BALANCE").ToString.Trim)
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        End If
        'Query for debit or credit entry
        If PayType.ToUpper.Trim = "DEBIT" Then
            Amount = Val(txtDebit.Text.Trim)
            Clo_Bal = Opn_Bal + Val(txtDebit.Text.Trim)
            cmdText = ("INSERT INTO CUSTOMERS_PAYM VALUES ('" & Supplier_Code & "','" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "','" & Val(txtTran.Text.Trim) & "','" & txtName.Text.Trim & "','" & "Doc # " & txtVoucher.Text.Trim & Space(1) & LedgDescription.ToUpper & "'," & Opn_Bal & "," & Val(txtDebit.Text.Trim) & ",0," & Clo_Bal & ",'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "')")
            'For update supplier closing balance
            Clos_Balance = "UPDATE CUSTOMERS SET CUST_BALANCE = CUST_BALANCE + " & _
                                                            Amount & ", CUST_UPD_DT = N'" & _
                                                            Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' " & _
                                                            "WHERE CUST_CODE = N'" & Val(txtID.Text.Trim) & "'"
        End If
        If PayType.ToUpper.Trim = "CREDIT" Then
            Amount = Val(txtCredit.Text.Trim)
            Clo_Bal = Opn_Bal - Val(txtCredit.Text.Trim)
            cmdText = ("INSERT INTO CUSTOMERS_PAYM VALUES ('" & Supplier_Code & "','" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "','" & Val(txtTran.Text.Trim) & "','" & txtName.Text.Trim.ToUpper & "','" & "Doc # " & txtVoucher.Text.Trim & Space(1) & LedgDescription.ToUpper & "'," & Opn_Bal & ",0," & Val(txtCredit.Text.Trim) & "," & Clo_Bal & ",'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "')")
            'For update supplier closing balance
            Clos_Balance = "UPDATE CUSTOMERS SET CUST_BALANCE = CUST_BALANCE - " & _
                                                            Amount & ", CUST_UPD_DT = N'" & _
                                                            Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' " & _
                                                            "WHERE CUST_CODE = N'" & Val(txtID.Text.Trim) & "'"
        End If
        'For update general journal
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Try
                    sqlCmd.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                End Try
            End Using
        End Using
        ExecuteAdapterQuery(SqlDataAdapter, Clos_Balance, Connection)
        Call Popup_Data("SELECT * FROM CUSTOMERS_PAYM WHERE CUST_CODE = N'" & Val(txtID.Text.Trim) & "' ORDER BY CUST_TR_ID")
        txtCredit.Text = 0
        txtDebit.Text = 0
        txtDescription.Clear()
        txtVoucher.Clear()
        txtVoucher.Focus()
        Connection.Close()
    End Sub

    Private Sub txtCredit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCredit.KeyUp
        If e.KeyCode = Keys.F10 Then
            If txtID.Text.Trim <> String.Empty Or Val(txtID.Text.Trim) <> 0 Then
                If Val(txtCredit.Text.Trim) > 0 Then Call Updt_General_Journal("CREDIT", txtDescription.Text.Trim)
            Else
                MessageBox.Show("Please Select valid customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtDebit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDebit.KeyUp
        If e.KeyCode = Keys.F9 Then
            If txtID.Text.Trim <> String.Empty Or Val(txtID.Text.Trim) <> 0 Then
                If Val(txtDebit.Text.Trim) > 0 Then Call Updt_General_Journal("DEBIT", txtDescription.Text.Trim)
            Else
                MessageBox.Show("Please Select valid customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Get_New_Record()
        CustomerCode.ShowDialog(Me)
        If Val(gblCP_ID) > 0 Then txtID.Text = gblCP_ID
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim GetCreditInvoices As String = "select * from sale_master where customerid > 0 and salecredit > 0 and ledgerpost = 0 order by LEFT(SALEID,3), CONVERT(INT, RIGHT(SALEID, LEN(SALEID)-3)),datecompleted,customerid"
        ExecuteAdapterQuery(InvoiceAdapter, GetCreditInvoices, Connection)
        Dim InvoiceReader As SqlDataReader = InvoiceAdapter.SelectCommand.ExecuteReader
        If InvoiceReader.HasRows Then
            Dim statusForm As New Status()
            statusForm.Show("Retrieving Credit Invoices.")
            While InvoiceReader.Read
                Call Update_Customer_Ledger(Val(InvoiceReader.Item("salecredit").ToString), Val(InvoiceReader.Item("customerid").ToString), Format(Date.Parse(Now.Date), "MM/dd/yyyy"), "Credited with Invoice # " & InvoiceReader.Item("saleid").ToString, "DR")
                Call ProcessTransaction("update sale_master set ledgerpost = 1 where saleid = N'" & InvoiceReader.Item("saleid").ToString & "'")
            End While
            If InvoiceReader Is Nothing Then InvoiceReader.Close()
            statusForm.Close()
            Call Popup_Data("SELECT * FROM CUSTOMERS_PAYM WHERE CUST_UPT_DT = N'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY CUST_TR_ID")
        End If
    End Sub

    Private Sub TranDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranDate.ValueChanged
        Call Popup_Data("SELECT * FROM CUSTOMERS_PAYM WHERE CUST_UPT_DT = N'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY CUST_TR_ID")
    End Sub
End Class