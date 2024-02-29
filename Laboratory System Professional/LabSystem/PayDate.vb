Public Class PayDate

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        gblPayDate = Format(DateTime.Parse(dtpPayDate.Value.ToShortDateString), "MM/dd/yyyy")
        gblDueAmount = Val(txtDueAmount.Text.Trim)
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        gblPayDate = String.Empty
        Me.Close()
    End Sub

    Private Sub PayDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gblPayDate = String.Empty
        gblDueAmount = 0
        txtDueAmount.Clear()
        dtpPayDate.Value = Now
    End Sub
End Class