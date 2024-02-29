Imports System
Imports System.IO
Imports System.Data.SqlClient

Public Class AccountStatment
    '** DATABASE FIELDS **'
    '// INC_STAT_NAME
    '// INC_STAT_ACCOUNT
    '// INC_STAT_ACC_TYPE
    '// INC_STAT_ACC_ID
    '// INC_STAT_DEBIT
    '// INC_STAT_CREDIT
    Dim Acc_ID As Integer
    Dim Stat_Group, New_Query_Text As String
    Dim CrAmount, DrAmount, NewDr_Value, NewCr_Value As Double

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Connection.Close()
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click

        Dim currentpath As String = Directory.GetCurrentDirectory()

        If rdTrialBalance.Checked = True Then
            gblReportOption = "TRIALBALANCE"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\TRIALBALANCE.rpt"
        End If

        If rdGeneral.Checked = True Then
            gblReportOption = "GENERAL"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\GeneralJournal.rpt"
        End If

        If rdQtrStatement.Checked = True Then
            gblReportOption = "QTRSTAT"
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\QuarterIncomeStatement.rpt"
        End If

        If rdIncStatPrd.Checked = True Then
            gblReportOption = "EXPREVENUE"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\PettyCashRegister.rpt"
        End If

        If rdBalSheet.Checked = True Then
            gblReportOption = "BALANCESHEET"
            'fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            'toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\BALANCESHEET.rpt"
            'MsgBox("This Feature is not available.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If

        If rdIncStatYr.Checked = True Then
            gblReportOption = "INCOME STATEMENT"
            'fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            'toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\INCOMESTATEMENTFINAL.rpt"
        End If

        If rdAdjTrialBal.Checked = True Then
            gblReportOption = "ADJTBALANCE"
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\TRIALBALANCEFINAL.rpt"
        End If

        AccountReports.MdiParent = MainForm
        AccountReports.Show()

    End Sub

    Private Sub frmAccStatment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
    End Sub

End Class