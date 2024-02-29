Imports System.Data
Imports System.Data.SqlClient
Public Class frmCurrentStat
    Dim Str As String
    Dim SumReader As SqlDataReader

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim QueryText As String = "SELECT Sum(p_total) AS EXPR1, Sum(p_paid) AS EXPR2, Sum(p_discount) AS EXPR3, Sum(p_dues) AS EXPR4" & _
                                      " FROM Patient WHERE P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(DateTime.Parse(myDate.Value.ToShortDateString), "MM/dd/yyyy") & " 00:00:00',102)"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QueryText, "PATIENT", Connection)
            SumReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While SumReader.Read
                txtTotal.Text = Convert.ToString(SumReader.Item("EXPR1"))
                txtDiscount.Text = Convert.ToString(SumReader.Item("EXPR3"))
                txtNet.Text = Convert.ToString(SumReader.Item("EXPR2"))
                txtDues.Text = Convert.ToString(SumReader.Item("EXPR4"))
            End While
            If Not SumReader Is Nothing Then SumReader.Close()
            Connection.Close()
            SqlDataAdapt.Dispose()

            '// To calculate dues for required date
            QueryText = "SELECT Sum(p_due_rcv) AS EXPR1 FROM Patient WHERE P_DUE_RCV_DATE = CONVERT(DATETIME,'" & Format(DateTime.Parse(myDate.Value.ToShortDateString), "MM/dd/yyyy") & " 00:00:00',102)"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, QueryText, "PATIENT", Connection)
            SumReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While SumReader.Read
                txtDueRcv.Text = Convert.ToString(SumReader.Item("EXPR1"))
            End While
            If Not SumReader Is Nothing Then SumReader.Close()
            Connection.Close()
            SqlDataAdapt.Dispose()
            Me.Cursor = Cursors.Default
        Catch EXCP As Exception
            MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub frmCurrentStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
    End Sub
End Class