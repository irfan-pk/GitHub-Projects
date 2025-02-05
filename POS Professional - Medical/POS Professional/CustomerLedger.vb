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

    Private Sub CoustomerLedger_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + 5)
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 40)
        Call GetConnectionString()
        Call Popup_Data("SELECT * FROM LEDGERS WHERE LEDG_ACC_ID = " & Val(txtID.Text.Trim) & " ORDER BY LEDG_DATE, LEDG_TRAN_ID")
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
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Get_New_Record()
        txtID.Clear()
        txtName.Clear()
        txtID.Focus()
    End Sub

    Private Sub txtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtID.Text) > 0 Then gblCP_ID = txtID.Text.Trim
            Dim CommandText As String = "SELECT * FROM ACCOUNTS WHERE ACC_NO = " & Val(gblCP_ID)
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
            Dim GetName As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If GetName.HasRows Then
                While GetName.Read
                    txtName.Text = GetName.Item("ACC_NAME").ToString.Trim
                End While
                If GetName Is Nothing Then GetName.Close()
                Call Popup_Data("SELECT * FROM LEDGERS WHERE LEDG_ACC_ID = N'" & Val(gblCP_ID) & "' ORDER BY LEDG_DATE, LEDG_TRAN_ID")
                txtID.Focus()
            Else
                MsgBox("Please give valid ID.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            End If
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        Call ValidateNumericKeyPress(sender, e, txtID)
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
            Max_Transaction = GenerateMax_ID("LEDGERS", "LEDG_TRAN_ID")
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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Get_New_Record()
        CustomerCode.ShowDialog(Me)
        If Val(gblCP_ID) > 0 Then txtID.Text = gblCP_ID
    End Sub
End Class