Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmDashBoard

    Private Sub Cash_Count()
        Call GetConnectionString()
        Try
            Dim CountRdr, DuesRdr As SqlDataReader
            Dim strCount As String = "SELECT COUNT(P_NUM) AS CNT_EXPR, SUM(P_PAID) AS P_EXPR, SUM(P_DISCOUNT) AS D_EXPR, SUM(P_DUES) AS R_EXPR FROM PATIENT WHERE P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & " 00:00:00',102)"
            Execute_DatabaseTable_Query(SqlDataAdapter, strCount, Connection)
            CountRdr = SqlDataAdapter.SelectCommand.ExecuteReader
            While CountRdr.Read
                intD_Paid = Val(CountRdr.Item("P_EXPR").ToString)
                intD_Disc = Val(CountRdr.Item("D_EXPR").ToString)
                intD_Dues = Val(CountRdr.Item("R_EXPR").ToString)
            End While
            If Not CountRdr Is Nothing Then CountRdr.Close()
            SqlDataAdapter.Dispose()

            Dim QueryText As String = "SELECT SUM(P_DUE_RCV) AS DR_EXPR,P_DUE_RCV_DATE from PATIENT GROUP BY p_due_rcv_date " & _
                                      "HAVING (p_due_rcv_date = CONVERT(DATETIME,'" & Format(DateTime.Parse(Date.Now.ToShortDateString), "MM/dd/yyyy") & " 00:00:00', 102))"

            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "PATIENT", Connection)
            DuesRdr = SqlDataAdapter.SelectCommand.ExecuteReader
            While DuesRdr.Read
                intD_Recv = Val(DuesRdr.Item("DR_EXPR").ToString)
            End While
            If Not DuesRdr Is Nothing Then DuesRdr.Close()

            Me.lblPaid.Text = intD_Paid.ToString
            Me.lblDiscount.Text = intD_Disc.ToString
            Me.lblDues.Text = intD_Dues.ToString
            Me.lblDuesRcv.Text = intD_Recv.ToString
            Me.lblTotal.Text = "Rs. " & intD_Paid + intD_Recv

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub frmDashBoard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Left = Me.Width - (frmMain.Width + 50)
        Me.Top = Me.Height - (frmMain.Height + 125)
        'Timer1.Interval = 1 * 1000
        'Timer1.Enabled = True
        'Call Cash_Count()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Call Record_Count()
        'Call Cash_Count()
    End Sub
End Class
