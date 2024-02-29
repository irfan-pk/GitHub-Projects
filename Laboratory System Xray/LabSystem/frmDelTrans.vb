Public Class frmDelTrans

    Private Sub frmDelTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTransDate.Value = DateAdd(DateInterval.Day, -1, Date.Now)
    End Sub

    Private Sub txtFromTrans_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFromTrans.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtToTrans_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtToTrans.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        gblQueryText = ""
        Me.Close()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Val(txtFromTrans.Text.Trim) > Val(txtToTrans.Text.Trim) Then MsgBox("Invalid Transaction Range.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub
        gblQueryText = "DELETE FROM LEDGER_TRANSACTIONS WHERE LEDG_TRAN_ID >= " & Val(txtFromTrans.Text.Trim) & " AND LEDG_TRAN_ID <= " & Val(txtToTrans.Text.Trim) & " AND LEDG_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(dtpTransDate.Value.ToShortDateString.ToString), "yyyy-MM-dd") & " 00:00:00', 102)"
    End Sub
End Class