Imports System.Data.SqlClient

Public Class AdjustPayment
    Dim CustomerID As Integer = 0
    Dim strDate As Date
    Dim PartialPayment As Boolean = False
    Dim wAmount, PayAmount As Double
    Dim AdjustPaymentAdapter As New SqlDataAdapter

    Private Sub BillPayment_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCustomerID.Focus()
    End Sub

    Private Sub BillPayment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F10 Then Me.Close()
    End Sub

    Private Sub BillPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        txtCustomerID.Focus()
        txtCustomerID.Text = 0
        txtPayment.Text = 0
        lblAdjAmount.Text = 0
    End Sub

    Private Sub txtCustomerID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerID.GotFocus
        txtCustomerID.SelectAll()
    End Sub

    Private Sub txtCustomerID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomerID.KeyDown
        If e.KeyCode = Keys.Enter Then
            ExecuteAdapterQuery(SqlDataAdapter, "select * from customers where cust_code = '" & txtCustomerID.Text.Trim & "'", Connection)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows = True Then
                While Reader.Read
                    CustomerID = Val(Reader.Item("cust_code").ToString)
                    lblName.Text = Reader.Item("cust_name").ToString
                    txtPayment.Enabled = True
                End While
                If Reader Is Nothing Then Reader.Close()
                lblAdjAmount.Text = 0
                txtPayment.Clear()
                txtPayment.Focus()
            Else
                MsgBox("Invalid ID, Plz check customer.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
                txtCustomerID.Text = 0
            End If
        End If
    End Sub

    Private Sub txtCustomerID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerID.KeyPress
        Call ValidateNumbersOnly(sender, e, txtCustomerID)
    End Sub

    Private Sub txtCustomerID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerID.LostFocus
        'Code
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtPayment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPayment.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtPayment.Text.Trim) > 0 Then
                cmdPaid.Enabled = True
                cmdPaid.Focus()
            End If
        End If
    End Sub

    Private Sub txtPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        Call ValidateNumbersOnly(sender, e, txtPayment)
    End Sub

    Private Sub cmdPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaid.Click
        Dim dr As DialogResult = MessageBox.Show("Execute Payment Adjustmet Process ( Yes / No )", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.Yes Then
            txtPayment.Enabled = False
            wAmount = Val(txtPayment.Text.Trim)
            ExecuteAdapterQuery(AdjustPaymentAdapter, "select * from sale_master where customerid = " & Val(txtCustomerID.Text.Trim) & " and SaleCredit > 0 order by SaleCredit", Connection)
            Dim Reader As SqlDataReader = AdjustPaymentAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                Me.Cursor = Cursors.WaitCursor
                While Reader.Read
                    If wAmount > Val(Reader.Item("salecredit").ToString) Then PayAmount = Val(Reader.Item("salecredit").ToString) : PartialPayment = False
                    If wAmount < Val(Reader.Item("salecredit").ToString) Then PayAmount = wAmount : PartialPayment = True
                    'Make Adjustment of given Customer
                    If PayAmount > 0 Then
                        Dim DuesDate As Date = Date.Parse(Reader.Item("DateCompleted").ToString)
                        Dim strDiff As String = DateDiff(DateInterval.Day, DuesDate, Date.Today)
                        If strDiff > 0 Then
                            Call ProcessTransaction("update sale_master set salepaid = salepaid + " & PayAmount & ", salerecovery = " & PayAmount & ", " & _
                                                    "daterecovery = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "', salecredit = salecredit - " & PayAmount & " where saleid = N'" & Reader.Item("saleid").ToString.ToUpper & "'")
                        Else
                            Call ProcessTransaction("update sale_master set salepaid = salepaid + " & PayAmount & ", " & _
                                                    "salecredit = salecredit - " & PayAmount & " where saleid = N'" & Reader.Item("saleid").ToString.ToUpper & "'")
                        End If
                        If PartialPayment = False Then Call Update_Customer_Ledger(PayAmount, CustomerID.ToString, Format(Date.Parse(Now.Date), "MM/dd/yyyy"), "Invoice # " & Reader.Item("saleid").ToString.ToUpper & ", Dues Payment Received.", "CR")
                        If PartialPayment = True Then Call Update_Customer_Ledger(Val(txtPayment.Text.Trim), CustomerID.ToString, Format(Date.Parse(Now.Date), "MM/dd/yyyy"), "Invoice # " & Reader.Item("saleid").ToString.ToUpper & ", Partial Payment Received.", "CR")
                    End If
                    wAmount = wAmount - PayAmount
                    txtPayment.Text = Val(txtPayment.Text) - PayAmount
                    lblAdjAmount.Text = Val(lblAdjAmount.Text) + PayAmount
                End While
                If wAmount > 0 Then
                    Call Update_Customer_Ledger(Val(txtPayment.Text.Trim), CustomerID.ToString, Format(Date.Parse(Now.Date), "MM/dd/yyyy"), "Adavance Payment Adjusted.", "CR")
                    txtPayment.Text = Val(txtPayment.Text) - PayAmount
                    lblAdjAmount.Text = Val(lblAdjAmount.Text) + PayAmount
                End If
                If Not Reader Is Nothing Then Reader.Close()
                Me.Cursor = Cursors.Default
            End If
        End If
        If CustomerID > 0 Then
            'If Val(txtDues.Text.Trim) > 0 Then Call Update_General_Journal(Val(txtPayment.Text.Trim), CustomerID.ToString, Format(Date.Parse(Now.Date), "MM/dd/yyyy"), "Invoice # " & txtCustomerID.Text.Trim.ToUpper & ", Partial Payment Received.", "CR")
            'If Val(txtDues.Text.Trim) = 0 Then Call Update_General_Journal(Val(txtPayment.Text.Trim), CustomerID.ToString, Format(Date.Parse(Now.Date), "MM/dd/yyyy"), "Invoice # " & txtCustomerID.Text.Trim.ToUpper & ", Dues Payment Received.", "CR")
        End If
        cmdPaid.Enabled = False
        txtCustomerID.Focus()
    End Sub

    Private Sub cmdPaid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPaid.GotFocus
        cmdPaid.BackColor = Color.FromArgb(192, 192, 255)
    End Sub

    Private Sub cmdPaid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPaid.LostFocus
        cmdPaid.BackColor = Color.Gray
    End Sub

    Private Sub cmdClose_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.GotFocus
        cmdClose.BackColor = Color.FromArgb(192, 192, 255)
    End Sub

    Private Sub cmdClose_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.LostFocus
        cmdClose.BackColor = Color.Gray
    End Sub
End Class