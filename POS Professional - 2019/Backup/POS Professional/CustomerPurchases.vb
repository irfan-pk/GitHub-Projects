Imports System.Data.SqlClient

Public Class CustomerPurchases

    Private Sub BindingNavigatorClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorClose.Click
        Me.Close()
        CustomerMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BindingNavigatorFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFind.Click
        If BindingNavigatorTextBox.Text = "" Or Val(BindingNavigatorTextBox.Text.Trim) = 0 Then gblMessage = "Please valid customer ID to Search ?" : MsgStatus.ShowDialog(Me) : Exit Sub
        Popup_SaleData()
    End Sub

    Private Sub Popup_SaleData()
        Me.CustomerDataSet.Clear()
        Dim SaleDetail As String = String.Empty
        If BindingNavigatorTextBox.Text.Trim = String.Empty Then
            SaleDetail = "SELECT * FROM SALE_DETAIL " & _
                                       "WHERE (DetailDate >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                       "DetailDate <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)) AND CustomerId > 0 ORDER BY SALEID"
        Else
            SaleDetail = "SELECT * FROM SALE_DETAIL " & _
                                   "WHERE CustomerID = N'" & Val(BindingNavigatorTextBox.Text.Trim) & "' AND (DetailDate >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                   "DetailDate <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102)) AND CustomerId > 0 ORDER BY SALEID"
        End If
        ExecuteAdapterQuery(SqlDataAdapter, SaleDetail, Connection)
        SqlDataAdapter.Fill(Me.CustomerDataSet, "SALE_DETAIL")
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet
        Me.CustomerBindingSource.DataMember = "SALE_DETAIL"
    End Sub

    Private Sub BindingNavigatorTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyUp
        If e.KeyCode = Keys.F2 Then
            CustomerCode.ShowDialog(Me)
            If Len(gblCP_ID) > 0 Then BindingNavigatorTextBox.Text = gblCP_ID.ToString.ToUpper Else Exit Sub
        End If
    End Sub

    Private Sub CustomerPurchases_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CustomerMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CustPurchases_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gblCP_ID = ""
        Call GetConnectionString()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub BindingNavigatorTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        Popup_SaleData()
    End Sub
End Class