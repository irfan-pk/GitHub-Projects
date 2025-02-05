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
        Call GetConnectionString()

        'Opening Balance
        Dim OpnCash As String = "select sum(ledg_debit - ledg_credit) as OpnCash from ledgers where ledg_date < '" & Format(Now.Date, "MM/dd/yyyy") & "' and ledg_acc_id = 1"
        ExecuteAdapterQuery(OpnBalAdapter, OpnCash, Connection)
        Dim OpnReader As SqlDataReader = OpnBalAdapter.SelectCommand.ExecuteReader
        While OpnReader.Read
            wOpnCash += Val(OpnReader.Item("OpnCash"))
            If IsDBNull(OpnReader.Item("OpnCash")) = True Then lblOpeningCash.Text = Decimal.Parse("0").ToString("c") Else lblOpeningCash.Text = Decimal.Parse(OpnReader.Item("OpnCash")).ToString("c")
        End While
        If OpnReader Is Nothing Then OpnReader.Close()

        'Daily Cash
        Dim DailyCash As String = "select sum(salepaid) as DailyCash from sale_master where datecompleted = '" & Format(Now.Date, "MM/dd/yyyy") & "' and status = 'PAID' OR status = 'PARTIAL'"
        ExecuteAdapterQuery(CashCollAdapter, DailyCash, Connection)
        Dim DailyReader As SqlDataReader = CashCollAdapter.SelectCommand.ExecuteReader
        While DailyReader.Read
            wDailyCash += Val(DailyReader.Item("DailyCash"))
            If IsDBNull(DailyReader.Item("DailyCash")) = True Then lblCollection.Text = Decimal.Parse("0").ToString("c") Else lblCollection.Text = Decimal.Parse(DailyReader.Item("DailyCash")).ToString("c")
        End While
        If DailyReader Is Nothing Then DailyReader.Close()

        'Pending Cash
        Dim PendingCash As String = "select sum(salepaid) as PendCash from sale_master where datecompleted = '" & Format(Now.Date, "MM/dd/yyyy") & "' and status = 'BILLED'"
        ExecuteAdapterQuery(PendingAdapter, PendingCash, Connection)
        Dim PendingReader As SqlDataReader = PendingAdapter.SelectCommand.ExecuteReader
        While PendingReader.Read
            wPendCash += Val(PendingReader.Item("PendCash"))
            If IsDBNull(PendingReader.Item("PendCash")) = True Then lblPending.Text = Decimal.Parse("0").ToString("c") Else lblPending.Text = Decimal.Parse(PendingReader.Item("PendCash")).ToString("c")
        End While
        If PendingReader Is Nothing Then PendingReader.Close()

        'Cash Recovery
        Dim RecoveryCash As String = "select sum(salerecovery) as RecoverCash from sale_master where datecompleted = '" & Format(Now.Date, "MM/dd/yyyy") & "' and status = 'PAID'"
        ExecuteAdapterQuery(RecoveryAdapter, RecoveryCash, Connection)
        Dim RecoveryReader As SqlDataReader = RecoveryAdapter.SelectCommand.ExecuteReader
        While RecoveryReader.Read
            wRecovery += Val(RecoveryReader.Item("RecoverCash"))
            If IsDBNull(RecoveryReader.Item("RecoverCash")) = True Then lblRecovery.Text = Decimal.Parse("0").ToString("c") Else lblRecovery.Text = Decimal.Parse(RecoveryReader.Item("RecoverCash")).ToString("c")
        End While
        If RecoveryReader Is Nothing Then RecoveryReader.Close()

        'Cash Credit
        Dim CreditCash As String = "select sum(salecredit) as CreditCash from sale_master where datecompleted = '" & Format(Now.Date, "MM/dd/yyyy") & "' and status = 'BILLED'"
        ExecuteAdapterQuery(CreditAdapter, CreditCash, Connection)
        Dim CreditReader As SqlDataReader = CreditAdapter.SelectCommand.ExecuteReader
        While CreditReader.Read
            wCredit += Val(CreditReader.Item("CreditCash"))
            If IsDBNull(CreditReader.Item("CreditCash")) = True Then lblCredit.Text = Decimal.Parse("0").ToString("c") Else lblCredit.Text = Decimal.Parse(CreditReader.Item("CreditCash")).ToString("c")
        End While
        If CreditReader Is Nothing Then CreditReader.Close()

        'Daily Expenses
        Dim DailyExpense As String = "select sum(ledg_debit - ledg_credit) as DailyExp from ledgers where ledg_date = '" & Format(Now.Date, "MM/dd/yyyy") & "' and ledg_acc_id = 7"
        ExecuteAdapterQuery(ExpenseAdapter, DailyExpense, Connection)
        Dim ExpenseReader As SqlDataReader = ExpenseAdapter.SelectCommand.ExecuteReader
        While ExpenseReader.Read
            wExpenses += Val(ExpenseReader.Item("DailyExp"))
            If IsDBNull(ExpenseReader.Item("DailyExp")) = True Then lblExpense.Text = Decimal.Parse("0").ToString("c") Else lblExpense.Text = Decimal.Parse(ExpenseReader.Item("DailyExp")).ToString("c")
        End While
        If ExpenseReader Is Nothing Then ExpenseReader.Close()

        'Return Cash
        Dim ReturnCash As String = "select sum(salereturn) as ReturnCash from sale_master where DateCompleted = '" & Format(Now.Date, "MM/dd/yyyy") & "' and status = 'PAID'"
        ExecuteAdapterQuery(ReturnAdapter, ReturnCash, Connection)
        Dim ReturnReader As SqlDataReader = ReturnAdapter.SelectCommand.ExecuteReader
        While ReturnReader.Read
            wReturn += Val(ReturnReader.Item("ReturnCash"))
            If IsDBNull(ReturnReader.Item("ReturnCash")) = True Then lblReturn.Text = Decimal.Parse("0").ToString("c") Else lblReturn.Text = Decimal.Parse(ReturnReader.Item("ReturnCash")).ToString("c")
        End While
        If ReturnReader Is Nothing Then ReturnReader.Close()

        wCashInHand = (wOpnCash + wDailyCash + wRecovery) - (wExpenses + wReturn)
        lblCashInHand.Text = Decimal.Parse(wCashInHand).ToString("c")

    End Sub
End Class