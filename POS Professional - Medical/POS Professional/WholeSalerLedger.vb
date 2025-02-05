Imports System.Data.SqlClient

Public Class WholeSalerLedger
    Dim cmdText, Clos_Balance As String
    Dim Max_ID, Max_Transaction As Integer
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub WholeSalerLedger_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        WholesalersMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub WholeSalerLedger_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + 5)
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 40)
        Call GetConnectionString()
        Call Popup_Data("SELECT * FROM LEDGERS WHERE LEDG_DATE = N'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY LEDG_TRAN_ID")
        Connection.Close()
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
        WholesalersMenu.WindowState = FormWindowState.Normal
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
                If Val(txtDebit.Text.Trim) > 0 Then Call Updt_General_Journal("DEBIT")
            Else
                MessageBox.Show("Please Select valid wholesaler.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtDebit)
    End Sub

    Private Sub txtCredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtID.Text.Trim <> String.Empty Or Val(txtID.Text.Trim) <> 0 Then
                If Val(txtCredit.Text.Trim) > 0 Then Call Updt_General_Journal("CREDIT")
            Else
                MessageBox.Show("Please Select valid wholesaler.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtCredit)
    End Sub

    Private Sub txtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtID.Text) > 0 Then gblCP_ID = txtID.Text.Trim
            Dim CommandText As String = "SELECT * FROM ACCOUNTS WHERE ACC_NO = N'" & Val(gblCP_ID) & "'"
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            Dim GetName As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GetName.HasRows Then
                While GetName.Read
                    txtName.Text = GetName.Item("ACC_NAME")
                    'txtAddress.Text = GetName.Item("supl_address").ToString.Trim & Space(1) & GetName.Item("supl_city").ToString.Trim
                End While
                If GetName Is Nothing Then GetName.Close()
                Call Popup_Data("SELECT * FROM LEDGERS WHERE LEDG_ACC_ID = N'" & Val(gblCP_ID) & "' ORDER BY LEDG_TRAN_ID")
                txtVoucher.Focus()
            Else
                MsgBox("Please give valid ID.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            End If
        End If
    End Sub

    Private Sub txtID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyUp
        If e.KeyCode = Keys.F2 Then
            Get_New_Record()
            WholesalerCodes.ShowDialog(Me)
            If Val(gblCP_ID) > 0 Then txtID.Text = gblCP_ID
            Call txtID_KeyDown(sender, e)
        End If
    End Sub

    Private Sub Popup_Data(ByVal StrQuery As String)
        Try
            Max_Transaction = GenerateMax_ID("LEDGERS", "LEDG_TRAN_ID")
            txtTran.Text = Max_Transaction.ToString.Trim
            Me.PaymentDataSet.Clear()
            Dim CommandText As String = StrQuery
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            SqlDataAdapter.Fill(Me.PaymentDataSet, "LEDGERS")
            Me.PayBindingSource.DataSource = Me.PaymentDataSet
            Me.PayBindingSource.DataMember = "LEDGERS"
            objCellStyle.BackColor = Color.WhiteSmoke
            PaymentDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub Updt_General_Journal(ByVal PayType As String)
        'Function to debit/credit payments
        Dim connString As String = ("Data Source=" & ServerName & ";Initial Catalog=" & ServerDatabase & ";NETWORK LIBRARY=DBMSSOCN;User ID=" & ServerID & ";Password=" & ServerPwd & ";DATABASE=" & ServerDatabase & ";")
        Dim Supplier_Code, Opn_Bal, Clo_Bal, Amount As Double
        Supplier_Code = 0
        Opn_Bal = 0
        Clo_Bal = 0
        Amount = 0
        Dim Get_Supplier As String = "select * from ACCOUNTS where acc_no = N'" & Val(txtID.Text.Trim) & "'"
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Supplier_Code = SuppliersReader.Item("acc_no").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("ACC_BALANCE").ToString.Trim)
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        End If
        cmdText = String.Empty
        'Query for debit or credit entry
        If PayType.ToUpper.Trim = "DEBIT" Then
            Amount = Val(txtDebit.Text.Trim)
            Clo_Bal = Opn_Bal - Val(txtDebit.Text.Trim)
            cmdText = ("INSERT INTO ledgers VALUES ('" & Supplier_Code & "','" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "','" & Val(txtTran.Text.Trim) & "','" & txtName.Text.Trim & "','" & "Doc # " & txtVoucher.Text.ToUpper & Space(1) & txtDescription.Text.Trim.ToUpper & "'," & Opn_Bal & "," & Val(txtDebit.Text.Trim) & ",0," & Clo_Bal & ",'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "')")
            'For update supplier closing balance
            Clos_Balance = "UPDATE ledgers SET ledg_BALANCE = LEDG_BALANCE - " & _
                                                            Amount & ", SUPL_UPD_DT = N'" & _
                                                            Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' " & _
                                                            "WHERE SUPL_CODE = N'" & Val(txtID.Text.Trim) & "'"
        End If
        If PayType.ToUpper.Trim = "CREDIT" Then
            Amount = Val(txtCredit.Text.Trim)
            Clo_Bal = Opn_Bal + Val(txtCredit.Text.Trim)
            cmdText = ("INSERT INTO SUPPLIERS_JOURNAL VALUES ('" & Supplier_Code & "','" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "','" & Val(txtTran.Text.Trim) & "','" & txtName.Text.Trim.ToUpper & "','" & "Doc # " & txtVoucher.Text.Trim.ToUpper & Space(1) & txtDescription.Text.ToUpper & "'," & Opn_Bal & ",0," & Val(txtCredit.Text.Trim) & "," & Clo_Bal & ",'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "')")
            'For update supplier closing balance
            Clos_Balance = "UPDATE SUPPLIERS SET SUPL_BALANCE = SUPL_BALANCE + " & _
                                                            Amount & ", SUPL_UPD_DT = N'" & _
                                                            Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' " & _
                                                            "WHERE SUPL_CODE = N'" & Val(txtID.Text.Trim) & "'"
        End If
        'For update general journal
        ProcessTransaction(cmdText.Trim)
        ExecuteAdapterQuery(SqlDataAdapter, Clos_Balance, Connection)
        Call Popup_Data("SELECT * FROM ledgers WHERE ledg_acc_id = N'" & Val(txtID.Text.Trim) & "' ORDER BY ledg_TRan_ID")
        txtCredit.Text = 0
        txtDebit.Text = 0
        txtVoucher.Clear()
        txtDescription.Clear()
        txtVoucher.Focus()
        Connection.Close()
    End Sub

    Private Sub txtCredit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCredit.KeyUp
        If e.KeyCode = Keys.F10 Then
            If txtID.Text.Trim <> String.Empty Or Val(txtID.Text.Trim) <> 0 Then
                If Val(txtCredit.Text.Trim) > 0 Then Call Updt_General_Journal("CREDIT")
            Else
                MessageBox.Show("Please Select valid wholesaler.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtDebit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDebit.KeyUp
        If e.KeyCode = Keys.F9 Then
            If txtID.Text.Trim <> String.Empty Or Val(txtID.Text.Trim) <> 0 Then
                If Val(txtDebit.Text.Trim) > 0 Then Call Updt_General_Journal("DEBIT")
            Else
                MessageBox.Show("Please Select valid wholesaler.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WholesalerCodes.ShowDialog(Me)
        Get_New_Record()
        If Val(gblCP_ID) > 0 Then txtID.Text = gblCP_ID
    End Sub

    Private Sub TranDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TranDate.ValueChanged
        Call Popup_Data("SELECT * FROM LEDGERS WHERE LEDG_DATE = N'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' ORDER BY LEDG_TRAN_ID")
    End Sub
End Class