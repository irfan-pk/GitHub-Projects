Imports System.IO
Public Class frmPrintSlip

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click

        Dim currentpath As String = Directory.GetCurrentDirectory()

        If txtRecNo.Text = "" Or txtRecNo.Text = "0" Then
            MsgBox("Please give valid ID", MsgBoxStyle.Information, My.Application.Info)
        End If

        'For Current Record Receipts
        If rdPSlip.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "RECEIPT"
                gblReportName = Application.StartupPath & "\Reports\PatientSlip.rpt"
            End If
        End If

        If rdLSlip.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "RECEIPT"
                gblReportName = Application.StartupPath & "\Reports\LabSlip.rpt"
            End If
        End If

        If rdEnvelope.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "RECEIPT"
                gblReportName = Application.StartupPath & "\Reports\Envelope.rpt"
            End If
        End If

        gblFind = txtRecNo.Text.Trim
        Call Print_Slips_Manually()

    End Sub

    Private Sub txtRecNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRecNo.KeyDown
        If e.KeyCode = Keys.Enter Then rdPSlip.Focus()
    End Sub

    Private Sub txtRecNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecNo.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

End Class