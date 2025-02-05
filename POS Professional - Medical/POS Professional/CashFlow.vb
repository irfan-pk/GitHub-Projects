Imports System.Data.SqlClient

Public Class CashFlow

    Dim OpnBalAdapter As New SqlDataAdapter()
    Dim CashCollAdapter As New SqlDataAdapter()
    Dim PendingAdapter As New SqlDataAdapter()
    Dim RecoveryAdapter As New SqlDataAdapter()
    Dim CreditAdapter As New SqlDataAdapter()
    Dim ExpenseAdapter As New SqlDataAdapter()
    Dim ReturnAdapter As New SqlDataAdapter()
    Dim SummaryDataSet As New DataSet()
    Dim wOpnCash, wDailyCash, wPendCash, wRecovery, wCredit, wExpenses, wReturn, wCashInHand As Double

    Private Sub CashFlow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim newCulture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CurrentUICulture.Clone()
        newCulture.NumberFormat.CurrencySymbol = "Rs. "
        newCulture.NumberFormat.CurrencyDecimalDigits = 2
        newCulture.NumberFormat.CurrencyGroupSeparator = String.Empty
        newCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = newCulture
        System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture
        GetConnectionString()
        CashFlowSummary()
    End Sub

    Private Sub CashFlowSummary()
        'Opening Balance
        Dim OpnCash As String = "select sum(salepaid) as OpnCash from sale_master where datecompleted < '" & Format(Now.Date, "yyyy-MM-dd") & "' and (status = 'PAID' or status = 'PARTIAL')"
        ExecuteAdapterQuery(OpnBalAdapter, OpnCash, Connection)
        Dim OpnReader As SqlDataReader = OpnBalAdapter.SelectCommand.ExecuteReader
        If OpnReader.HasRows Then
            While OpnReader.Read
                If IsDBNull(OpnReader.Item("OpnCash")) = True Then wOpnCash += 0 : lblOpeningCash.Text = Decimal.Parse("0").ToString("c") Else wOpnCash += Val(OpnReader.Item("OpnCash")) : lblOpeningCash.Text = Decimal.Parse(OpnReader.Item("OpnCash")).ToString("c")
            End While
        End If
        If OpnReader Is Nothing Then OpnReader.Close()

        'Daily Cash
        Dim DailyCash As String = "select sum(salepaid) as DailyCash from sale_master where datecompleted = '" & Format(Now.Date, "yyyy-MM-dd") & "' and (status = 'PAID')"
        ExecuteAdapterQuery(CashCollAdapter, DailyCash, Connection)
        Dim DailyReader As SqlDataReader = CashCollAdapter.SelectCommand.ExecuteReader
        If DailyReader.HasRows Then
            While DailyReader.Read
                If IsDBNull(DailyReader.Item("DailyCash")) = True Then wDailyCash += 0 : lblCollection.Text = Decimal.Parse("0").ToString("c") Else wDailyCash += Val(DailyReader.Item("DailyCash")) : lblCollection.Text = Decimal.Parse(DailyReader.Item("DailyCash")).ToString("c")
            End While
        End If
        If DailyReader Is Nothing Then DailyReader.Close()

        'Pending Cash
        Dim PendingCash As String = "select sum(salepaid) as PendCash from sale_master where status = 'BILLED' or status = 'PARTIAL'"
        ExecuteAdapterQuery(PendingAdapter, PendingCash, Connection)
        Dim PendingReader As SqlDataReader = PendingAdapter.SelectCommand.ExecuteReader
        If PendingReader.HasRows Then
            While PendingReader.Read
                If IsDBNull(PendingReader.Item("PendCash")) = True Then wPendCash += 0 : lblPending.Text = Decimal.Parse("0").ToString("c") Else wPendCash += Val(PendingReader.Item("PendCash")) : lblPending.Text = Decimal.Parse(PendingReader.Item("PendCash")).ToString("c")
            End While
        End If
        If PendingReader Is Nothing Then PendingReader.Close()

        'Cash Recovery
        Dim RecoveryCash As String = "select sum(salerecovery) as RecoverCash from sale_master where datecompleted = '" & Format(Now.Date, "yyyy-MM-dd") & "' and status = 'PAID'"
        ExecuteAdapterQuery(RecoveryAdapter, RecoveryCash, Connection)
        Dim RecoveryReader As SqlDataReader = RecoveryAdapter.SelectCommand.ExecuteReader
        If RecoveryReader.HasRows Then
            While RecoveryReader.Read
                If IsDBNull(RecoveryReader.Item("RecoverCash")) = True Then wRecovery += 0 : lblRecovery.Text = Decimal.Parse("0").ToString("c") Else wRecovery += Val(RecoveryReader.Item("RecoverCash")) : lblRecovery.Text = Decimal.Parse(RecoveryReader.Item("RecoverCash")).ToString("c")
            End While
        End If
        If RecoveryReader Is Nothing Then RecoveryReader.Close()

        'Cash Credit
        Dim CreditCash As String = "select sum(salecredit) as CreditCash from sale_master where datecompleted = '" & Format(Now.Date, "yyyy-MM-dd") & "' and salecredit > 0"
        ExecuteAdapterQuery(CreditAdapter, CreditCash, Connection)
        Dim CreditReader As SqlDataReader = CreditAdapter.SelectCommand.ExecuteReader
        If CreditReader.HasRows Then
            While CreditReader.Read
                If IsDBNull(CreditReader.Item("CreditCash")) = True Then wCredit += 0 : lblCredit.Text = Decimal.Parse("0").ToString("c") Else wCredit += Val(CreditReader.Item("CreditCash")) : lblCredit.Text = Decimal.Parse(CreditReader.Item("CreditCash")).ToString("c")
            End While
        End If
        If CreditReader Is Nothing Then CreditReader.Close()

        'Daily Expenses
        Dim DailyExpense As String = "select sum(ledg_debit - ledg_credit) as DailyExp from ledgers where ledg_date = '" & Format(Now.Date, "yyyy-MM-dd") & "' and ledg_acc_id = 7"
        ExecuteAdapterQuery(ExpenseAdapter, DailyExpense, Connection)
        Dim ExpenseReader As SqlDataReader = ExpenseAdapter.SelectCommand.ExecuteReader
        If ExpenseReader.HasRows Then
            While ExpenseReader.Read
                If IsDBNull(ExpenseReader.Item("DailyExp")) = True Then wExpenses += 0 : lblExpense.Text = Decimal.Parse("0").ToString("c") Else wExpenses += Val(ExpenseReader.Item("DailyExp")) : lblExpense.Text = Decimal.Parse(ExpenseReader.Item("DailyExp")).ToString("c")
            End While
        End If
        If ExpenseReader Is Nothing Then ExpenseReader.Close()

        'Return Cash
        Dim ReturnCash As String = "select sum(salereturn) as ReturnCash from sale_master where DateCompleted = '" & Format(Now.Date, "yyyy-MM-dd") & "' and status = 'PAID'"
        ExecuteAdapterQuery(ReturnAdapter, ReturnCash, Connection)
        Dim ReturnReader As SqlDataReader = ReturnAdapter.SelectCommand.ExecuteReader
        If ReturnReader.HasRows Then
            While ReturnReader.Read
                If IsDBNull(ReturnReader.Item("ReturnCash")) = True Then wReturn += 0 : lblReturn.Text = Decimal.Parse("0").ToString("c") Else wReturn += Val(ReturnReader.Item("ReturnCash")) : lblReturn.Text = Decimal.Parse(ReturnReader.Item("ReturnCash")).ToString("c")
            End While
        End If
        If ReturnReader Is Nothing Then ReturnReader.Close()
        'Display Total
        wCashInHand = (wOpnCash + wDailyCash + wRecovery) - (wExpenses + wReturn)
        lblCashInHand.Text = Decimal.Parse(wCashInHand).ToString("c")
    End Sub
End Class