Imports System
Imports System.IO
Imports System.Data.SqlClient

Public Class frmAccStatment
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
            gblReportOption = "TRIAL BALANCE"
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\TRIALBALANCE.rpt"
        End If

        If rdIncStatPrd.Checked = True Then
            gblReportOption = "EXPREVENUE"
            fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
            toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
            gblReportName = currentpath & "\" & "Reports\INCOME_EXPENSE.rpt"
        End If

        If rdIncStatYr.Checked = True Then
            Dim IncomeStatText As String = "SELECT Ledg_Acc_Id AS ID_EXPR, Ledg_Description AS ACC_NM_EXPR, SUM(Ledg_Debit) AS DR_EXPR, SUM(Ledg_Credit) AS CR_EXPR, Ledg_Link AS LINK_EXPR FROM Ledger_Transactions " & _
                                           "GROUP BY Ledg_Acc_Id, Ledg_Description, Ledg_Link " & _
                                           "HAVING (Ledg_Link = 'EXPENSES') OR (Ledg_Link = 'REVENUE') " & _
                                           "ORDER BY Ledg_Link DESC"
            Try
                Execute_DatabaseTable_Query(SqlDataAdapt, IncomeStatText, Connection)
                Dim Income_Stat_Reader As SqlDataReader = SqlDataAdapt.SelectCommand.ExecuteReader

                While Income_Stat_Reader.Read
                    Acc_ID = Get_Account_ID(Income_Stat_Reader.Item("ACC_NM_EXPR").ToString)
                    Stat_Group = Income_Stat_Reader.Item("LINK_EXPR")
                    DrAmount = Convert.ToInt32(Income_Stat_Reader.Item("DR_EXPR"))
                    CrAmount = Convert.ToInt32(Income_Stat_Reader.Item("CR_EXPR"))

                    If DrAmount > CrAmount Then
                        NewDr_Value = DrAmount - CrAmount
                        NewCr_Value = 0
                    End If
                    If CrAmount > DrAmount Then
                        NewCr_Value = CrAmount - DrAmount
                        NewDr_Value = 0
                    End If
                    New_Query_Text = ""
                    New_Query_Text = "INSERT INTO INCOME_STATEMENT VALUES('" & gblStatLink & "','" & _
                                     StrConv(Income_Stat_Reader.Item("ACC_NM_EXPR"), VbStrConv.Uppercase) & "','" & _
                                     gblAccType.ToString.ToUpper & "'," & Acc_ID & "," & _
                                     NewDr_Value & "," & _
                                     NewCr_Value & ")"
                    Execute_DatabaseTable_Query(SqlDataAdapt, New_Query_Text, Connection)
                End While
                If Not Income_Stat_Reader Is Nothing Then Income_Stat_Reader.Close()
                gblReportOption = "INCOME STATEMENT"
                fromDate = DateTime.Parse(fromDatePick.Value.ToShortDateString)
                toDate = DateTime.Parse(toDatePick.Value.ToShortDateString)
                gblReportName = currentpath & "\" & "Reports\INCOMESTATEMENT.rpt"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            
        End If
        frmAccReports.MdiParent = frmMain
        frmAccReports.Show()

    End Sub

    Private Sub frmAccStatment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
    End Sub

End Class