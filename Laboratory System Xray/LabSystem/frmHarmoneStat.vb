Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmHarmoneStat
    Dim Total_Tests As Integer
    Dim Filler As SqlDataReader

    Private Sub frmHarmoneStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Total_Tests = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TestListView.Items.Clear()
        lblCount.Text = "00"
        fromDate = DateTime.Parse(fromDatePicker.Value.ToShortDateString)
        toDate = DateTime.Parse(ToDatePicker.Value.ToShortDateString)

        ' Selecting Test Information by Given Code
        Dim strSql As String = "SELECT COUNT(tname) AS Expr1, tname FROM RECEIPT " & _
                               "WHERE (tcatg = 'HARMONES') AND (tdate >= CONVERT(DATETIME, '" & Format(fromDate, "yyyy-MM-dd") & " 00:00:00', 102)) AND " & _
                               "(tdate <= CONVERT(DATETIME, '" & Format(toDate, "yyyy-MM-dd") & " 00:00:00', 102)) " & _
                               "GROUP BY tname"
        strTname = ""
        strTrate = ""
        ' Get Test Information into Variables
        Dim TestReader As SqlDataReader
        ExecuteSqlQuery(EntryDataAdpt, EntryDataSet, strSql, "RECEIPT", Connection)
        TestReader = EntryDataAdpt.SelectCommand.ExecuteReader
        While TestReader.Read
            Dim TestItem As New ListViewItem  ' initialize here due to add multiple items in list view control
            strTname = Convert.ToString(TestReader.Item("tname")).ToUpper.Trim
            strTrate = Convert.ToString(TestReader.Item("expr1"))
            ' Adding Values into List View Control
            TestListView.BeginUpdate()
            TestItem.Text = strTname.ToUpper.Trim
            TestItem.SubItems.Add(Val(strTrate.Trim), Color.Black, Color.Aqua, Font())
            lblCount.Text = Val(lblCount.Text) + Val(strTrate.Trim)
            TestListView.Items.Add(TestItem)
            TestListView.EndUpdate()
        End While
        If Not TestReader Is Nothing Then TestReader.Close()
        EntryDataAdpt.Dispose()
        Connection.Close()
    End Sub

End Class