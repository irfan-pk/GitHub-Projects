Imports System.Data.SqlClient

Public Class FiscalPeriodSelect

    Private Sub FiscalPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        cbFiscalClose.Items.Clear()
        cbFiscalStart.Items.Clear()
        cbFiscalClose.Text = String.Empty
        cbFiscalStart.Text = String.Empty
        Execute_DatabaseTable_Query(SqlDataAdapter, "select fiscal_year_period from fiscal_year where fiscal_year_status = 'OPENED' order by fiscal_year_seq", Connection)
        Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                cbFiscalClose.Items.Add(reader.Item("fiscal_year_period").ToString)
                cbFiscalStart.Items.Add(reader.Item("fiscal_year_period").ToString)
            End While
        End If
        fOpen = String.Empty
        fClose = String.Empty
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        fOpen = String.Empty
        fClose = String.Empty
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        fOpen = cbFiscalStart.Text.Trim
        fClose = cbFiscalClose.Text.Trim
        Me.Close()
    End Sub
End Class