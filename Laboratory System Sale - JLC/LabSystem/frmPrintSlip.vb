Imports System.IO
Public Class frmPrintSlip

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click

        Dim currentpath As String = Directory.GetCurrentDirectory()
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

        'For PCR Receipts
        If rdPCRSlip.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "PCRRECEIPT"
                gblReportName = Application.StartupPath & "\Reports\PCRPatientSlip.rpt"
            End If
        End If

        If rdPCRLSlip.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "PCRRECEIPT"
                gblReportName = Application.StartupPath & "\Reports\PCRLabSlip.rpt"
            End If
        End If

        'For Special Record Receipts
        If rdSPCSlip.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "STRECEIPT"
                gblReportName = Application.StartupPath & "\Reports\STPatientSlip.rpt"
            End If
        End If

        If rdSPCLSlip.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "STRECEIPT"
                gblReportName = Application.StartupPath & "\Reports\STLabSlip.rpt"
            End If
        End If

        'For GX PCR Record Receipts
        If rdGXRNo.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "GXRECEIPT"
                gblReportName = Application.StartupPath & "\Reports\GXLabSlip.rpt"
            End If
        End If

        If rdGXPNum.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "GXRECEIPT"
                gblReportName = Application.StartupPath & "\Reports\GXPatientSlip.rpt"
            End If
        End If

        'For National Record Receipts
        If rdNPnum.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "NPRECEIPT"
                gblReportName = Application.StartupPath & "\Reports\NationalPatientSlip.rpt"
            End If
        End If

        If rdNRno.Checked = True Then
            If Len(txtRecNo.Text) > 0 Then
                gblReportOption = "NPRECEIPT"
                gblReportName = Application.StartupPath & "\Reports\NationalLabSlip.rpt"
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

    Private Sub frmPrintSlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class