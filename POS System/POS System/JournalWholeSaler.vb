Imports System.Data.SqlClient

Public Class JournalWholeSaler
    Dim cmdText, Clos_Balance As String
    Dim Max_ID, Max_Transaction As Integer
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub frmJournal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + 5)
        Call GetConnectionString()
        Call Popup_Data()
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
        Wholesalers.WindowState = FormWindowState.Normal
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
            If Val(txtDebit.Text.Trim) > 0 Then Call Updt_General_Journal("DEBIT")
        End If
    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtDebit, txtDebit)
    End Sub

    Private Sub txtCredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtDebit.Text.Trim) > 0 Then Call Updt_General_Journal("CREDIT")
        End If
    End Sub

    Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtCredit, txtCredit)
    End Sub

    Private Sub txtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtID.Text) > 0 Then gblCP_ID = txtID.Text.Trim
            Dim CommandText As String = "SELECT * FROM SUPPLIERS WHERE SUPL_CODE = N'" & Val(gblCP_ID) & "'"
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            Dim GetName As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GetName.HasRows Then
                While GetName.Read
                    txtName.Text = GetName.Item("SUPL_NAME")
                End While
                If GetName Is Nothing Then GetName.Close()
                Call Popup_Data()
                txtDescription.Focus()
            Else
                MsgBox("Please give valid ID.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            End If
        End If
    End Sub

    Private Sub txtID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyUp
        If e.KeyCode = Keys.F2 Then
            SuplCode.ShowDialog(Me)
            If Val(gblCP_ID) > 0 Then txtID.Text = gblCP_ID
            Call txtID_KeyDown(sender, e)
        End If
    End Sub

    Private Sub Popup_Data()
        Try
            Max_Transaction = GenerateMax_ID("SUPPLIERS_PAYM", "SUPL_TR_ID")
            txtTran.Text = Max_Transaction.ToString.Trim
            Me.PaymentDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM SUPPLIERS_PAYM WHERE SUPL_CODE = N'" & Val(gblCP_ID) & "' ORDER BY SUPL_TR_ID"
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            SqlDataAdapter.Fill(Me.PaymentDataSet, "SUPPLIERS_PAYM")
            Me.PayBindingSource.DataSource = Me.PaymentDataSet
            Me.PayBindingSource.DataMember = "SUPPLIERS_PAYM"
            objCellStyle.BackColor = Color.WhiteSmoke
            PaymentDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub Updt_General_Journal(ByVal PayType As String)
        'Function to debit/credit payments
        Dim connString As String = ("Data Source=SQLNCLI10;Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Password=" & ServerPwd & ";Data Source=" & ServerName & ";DATABASE=POS;")
        Dim Supplier_Code, Opn_Bal, Clo_Bal, Amount As Double
        Supplier_Code = 0
        Opn_Bal = 0
        Clo_Bal = 0
        Amount = 0
        Dim Get_Supplier As String = "select * from suppliers where supl_code = N'" & Val(txtID.Text.Trim) & "'"
        ExecuteAdapterQuery(Suppliers, Get_Supplier, Connection)
        Dim SuppliersReader As SqlDataReader = Suppliers.SelectCommand.ExecuteReader
        If SuppliersReader.HasRows Then
            While SuppliersReader.Read
                Supplier_Code = SuppliersReader.Item("SUPL_CODE").ToString.Trim
                Opn_Bal = Val(SuppliersReader.Item("SUPL_BALANCE").ToString.Trim)
            End While
            If SuppliersReader Is Nothing Then SuppliersReader.Close()
        End If
        'Query for debit or credit entry
        If PayType.ToUpper.Trim = "DEBIT" Then
            Amount = Val(txtDebit.Text.Trim)
            Clo_Bal = Opn_Bal - Val(txtDebit.Text.Trim)
            cmdText = ("INSERT INTO SUPPLIERS_PAYM VALUES ('" & Supplier_Code & "','" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "','" & Val(txtTran.Text.Trim) & "','" & txtName.Text.Trim & "','" & txtDescription.Text.Trim & "'," & Opn_Bal & "," & Val(txtDebit.Text.Trim) & ",0," & Clo_Bal & ",'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "')")
        End If
        If PayType.ToUpper.Trim = "CREDIT" Then
            Amount = Val(txtCredit.Text.Trim)
            Clo_Bal = Opn_Bal + Val(txtCredit.Text.Trim)
            cmdText = ("INSERT INTO SUPPLIERS_PAYM VALUES ('" & Supplier_Code & "','" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "','" & Val(txtTran.Text.Trim) & "','" & txtName.Text.Trim.ToUpper & "','" & StrConv(txtDescription.Text.Trim, VbStrConv.ProperCase) & "'," & Opn_Bal & ",0," & Val(txtCredit.Text.Trim) & "," & Clo_Bal & ",'" & Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "')")
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
        'For update supplier closing balance
        Clos_Balance = "UPDATE SUPPLIERS SET SUPL_BALANCE = SUPL_BALANCE - " & _
                                                        Amount & ", SUPL_UPD_DT = N'" & _
                                                        Format(Date.Parse(TranDate.Value.ToString), "MM/dd/yyyy") & "' " & _
                                                        "WHERE SUPL_CODE = N'" & Val(txtID.Text.Trim) & "'"
        ExecuteAdapterQuery(SqlDataAdapter, Clos_Balance, Connection)
        Call Popup_Data()
        Call Get_New_Record()
        Connection.Close()
    End Sub

    Private Sub txtCredit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCredit.KeyUp
        If e.KeyCode = Keys.F10 Then
            If Val(txtCredit.Text.Trim) > 0 Then Call Updt_General_Journal("CREDIT")
        End If
    End Sub

    Private Sub txtDebit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDebit.KeyUp
        If e.KeyCode = Keys.F9 Then
            If Val(txtDebit.Text.Trim) > 0 Then Call Updt_General_Journal("DEBIT")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        SuplCode.ShowDialog(Me)
        If Val(gblCP_ID) > 0 Then txtID.Text = gblCP_ID
    End Sub
End Class