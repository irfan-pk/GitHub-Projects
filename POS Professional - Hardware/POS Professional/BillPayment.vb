Imports System.Data.SqlClient

Public Class BillPayment
    Dim CustomerID As Integer = 0
    Dim strDate As Date

    Private Sub BillPayment_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSaleID.Focus()
    End Sub

    Private Sub BillPayment_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F10 Then Me.Close()
    End Sub

    Private Sub BillPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        txtSaleID.Focus()
        txtSaleID.Text = 0
        txtTotal.Text = 0
        txtDues.Text = 0
        txtDiscount.Text = 0
        txtTotal.Text = 0
        txtPayment.Text = 0
    End Sub

    Private Sub txtSaleID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSaleID.GotFocus
        Call Get_Property_GotFocus(txtSaleID)
    End Sub

    Private Sub txtSaleID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSaleID.KeyDown
        If e.KeyCode = Keys.Enter Then
            ExecuteAdapterQuery(SqlDataAdapter, "select * from sale_master where saleid = '" & txtSaleID.Text.Trim & "' and salecredit > 0", Connection)
            Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows = True Then
                While Reader.Read
                    txtTotal.Text = Val(Reader.Item("salegross").ToString) - Val(Reader.Item("salepaid").ToString)
                    txtDiscount.Text = Reader.Item("salediscount").ToString
                    txtDues.Text = Reader.Item("salecredit").ToString
                    CustomerID = Val(Reader.Item("customerid").ToString)
                    strDate = CDate(Reader.Item("datecompleted").ToString)
                End While
                If Reader Is Nothing Then Reader.Close()
                txtDues.Text = Val(txtTotal.Text) - Val(txtDiscount.Text) - Val(txtPayment.Text)
                txtPayment.Focus()
            Else
                MsgBox("Plz check saleid / dues of customer.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
                txtSaleID.Text = 0
            End If
        End If
    End Sub

    Private Sub txtSaleID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaleID.KeyPress
        Call ValidateAlphaNumOnly(sender, e)
    End Sub

    Private Sub txtSaleID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSaleID.LostFocus
        Call Get_Property_LostFocus(txtSaleID)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtPayment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPayment.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtPayment.Text.Trim) > Val(txtDues.Text.Trim) Then MsgBox("Amount should'nt be greater than dues.", MsgBoxStyle.Critical, My.Application.Info.ProductName) : Exit Sub
            If CustomerID < 1 = True Then _
            If Val(txtPayment.Text.Trim) < Val(txtDues.Text.Trim) Then MsgBox("Partial Payment not allowed for cash customer.", MsgBoxStyle.Critical, My.Application.Info.ProductName) : Exit Sub
            txtDues.Text = Val(txtTotal.Text) - Val(txtDiscount.Text) - Val(txtPayment.Text)
            cmdPaid.Enabled = True
            cmdPaid.Focus()
        End If
    End Sub

    Private Sub txtPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        Call ValidateNumbersOnly(sender, e, txtPayment)
    End Sub

    Private Sub cmdPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaid.Click
        Dim strDiff As String = DateDiff(DateInterval.Day, strDate, Date.Today)
        If strDiff > 0 Then
            Call ProcessTransaction("update sale_master set salepaid = salepaid + " & Val(txtPayment.Text.Trim) & ", salerecovery = " & Val(txtPayment.Text.Trim) & ", " & _
                                    "daterecovery = '" & Format(Date.Parse(Now.Date), "MM/dd/yyyy") & "', salecredit = salecredit - " & Val(txtPayment.Text.Trim) & " where saleid = '" & txtSaleID.Text.Trim & "'")
        Else
            Call ProcessTransaction("update sale_master set salepaid = salepaid + " & Val(txtPayment.Text.Trim) & ", " & _
                                    "salecredit = salecredit - " & Val(txtPayment.Text.Trim) & " where saleid = '" & txtSaleID.Text.Trim & "'")
        End If
        If CustomerID > 0 Then
            If Val(txtDues.Text.Trim) > 0 Then Call Update_Customer_Ledger(Val(txtPayment.Text.Trim), CustomerID.ToString, Format(Date.Parse(Now.Date), "MM/dd/yyyy"), "Invoice # " & txtSaleID.Text.Trim.ToUpper & ", Partial Payment Received.", "CR")
            If Val(txtDues.Text.Trim) = 0 Then Call Update_Customer_Ledger(Val(txtPayment.Text.Trim), CustomerID.ToString, Format(Date.Parse(Now.Date), "MM/dd/yyyy"), "Invoice # " & txtSaleID.Text.Trim.ToUpper & ", Dues Payment Received.", "CR")
        End If
        Me.Close()
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