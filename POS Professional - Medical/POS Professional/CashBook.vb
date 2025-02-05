Imports System.Data.SqlClient

Public Class CashBook

    Dim OpnBalAdapter As New SqlDataAdapter()
    Dim DrDataSet As New DataSet()
    Dim CrDataSet As New DataSet()
    Dim DrBinding As New BindingSource()
    Dim CrBinding As New BindingSource()
    Dim DrCrAdapter As New SqlDataAdapter()
    Dim TransAdapterDr As New SqlDataAdapter()
    Dim TransAdapterCr As New SqlDataAdapter()
    Dim wOpnCash, wDebit, wCredit, wFinalCash As Double

    Private Sub CashBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim newCulture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CurrentUICulture.Clone()
        newCulture.NumberFormat.CurrencySymbol = "Rs. "
        newCulture.NumberFormat.CurrencyDecimalDigits = 2
        newCulture.NumberFormat.CurrencyGroupSeparator = String.Empty
        newCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = newCulture
        System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture
        Call GetConnectionString()
        Call GetTransactions()
    End Sub

    Private Sub GetTransactions()

        wOpnCash = 0
        wDebit = 0
        wCredit = 0
        wFinalCash = 0

        DrDataSet.Clear()

        'Opening Balance
        Dim OpnCash As String = "select sum(ledg_debit - ledg_credit) as OpnCash from ledgers where ledg_date < '" & Format(dateTimePicker.Value, "MM/dd/yyyy") & "' and ledg_acc_id = 1"
        ExecuteAdapterQuery(OpnBalAdapter, OpnCash, Connection)
        Dim OpnReader As SqlDataReader = OpnBalAdapter.SelectCommand.ExecuteReader
        While OpnReader.Read
            If IsDBNull(OpnReader.Item("OpnCash")) = False Then wOpnCash += Val(OpnReader.Item("OpnCash")) Else wOpnCash += 0
            lblOpening.Text = Decimal.Parse(wOpnCash).ToString("c")
        End While
        If OpnReader Is Nothing Then OpnReader.Close()

        Dim DrTransactions As String = "select ledg_date,ledg_voucher_no,ledg_narration,ledg_debit from ledgers where ledg_date >= '" & Format(dateTimePicker.Value, "MM/dd/yyyy") & "' and ledg_acc_id = 1 and ledg_debit > 0"
        ExecuteAdapterQuery(TransAdapterDr, DrTransactions, Connection)
        TransAdapterDr.Fill(DrDataSet, "ledgers")
        DrBinding.DataSource = DrDataSet
        DrBinding.DataMember = "ledgers"
        DgvDebit.DataSource = DrBinding
        DgvDebit.Refresh()

        Dim CrTransactions As String = "select ledg_date,ledg_voucher_no,ledg_narration,ledg_credit from ledgers where ledg_date >= '" & Format(dateTimePicker.Value, "MM/dd/yyyy") & "' and ledg_acc_id = 1 and ledg_credit > 0"
        ExecuteAdapterQuery(TransAdapterCr, CrTransactions, Connection)
        TransAdapterCr.Fill(CrDataSet, "ledgers")
        CrBinding.DataSource = CrDataSet
        CrBinding.DataMember = "ledgers"
        DgvCredit.DataSource = CrBinding
        DgvCredit.Refresh()

        Dim DrCr As String = "select sum(ledg_debit) as Dr, sum(ledg_credit) as Cr from ledgers where ledg_date >= '" & Format(dateTimePicker.Value, "MM/dd/yyyy") & "' and ledg_acc_id = 1"
        ExecuteAdapterQuery(DrCrAdapter, DrCr, Connection)
        Dim DrCrReader As SqlDataReader = DrCrAdapter.SelectCommand.ExecuteReader
        While DrCrReader.Read
            If IsDBNull(DrCrReader.Item("Dr")) = False Then wDebit += Val(DrCrReader.Item("Dr")) Else wDebit += 0
            If IsDBNull(DrCrReader.Item("Cr")) = False Then wCredit += Val(DrCrReader.Item("Cr")) Else wCredit += 0
            lblDebit.Text = Decimal.Parse(wDebit).ToString("c")
            lblCredit.Text = Decimal.Parse(wCredit).ToString("c")
        End While

        wFinalCash = wOpnCash + wDebit - wCredit
        lblCashInHand.Text = Decimal.Parse(wFinalCash).ToString("c")

    End Sub

    Private Sub dateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateTimePicker.ValueChanged
        Call GetTransactions()
    End Sub
End Class