Imports System.Data.SqlClient

Public Class WholeSalerPayments
    Dim drag, EditMode As Boolean
    Dim PPrice As Double
    Dim LedgerQuery As String
    Dim mousex, mousey, Pos As Integer

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub ViewCompanyLedgers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + 5)
        Call GetConnectionString()
        FromDate.Value = DateAdd(DateInterval.Day, -1, Date.Now)
        LedgerQuery = "SELECT * FROM SUPPLIERS_JOURNAL WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                      "SUPL_TR_DT <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) " & _
                                      "ORDER BY SUPL_TR_ID"
        Call View_Ledgers(LedgerQuery)
    End Sub

    Private Sub View_Ledgers(ByVal StandardQuery As String)
        Try
            'Retrieve Records for datagrid view from product table
            Me.PaymentDataSet.Clear()
            PurchaseAdapter.Dispose()
            ExecuteAdapterQuery(PurchaseAdapter, StandardQuery, Connection)
            PurchaseAdapter.Fill(Me.PaymentDataSet, "SUPPLIERS_JOURNAL")
            Dim Reader As SqlDataReader = PurchaseAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                Me.PayBindingSource.DataSource = Me.PaymentDataSet
                Me.PayBindingSource.DataMember = "SUPPLIERS_JOURNAL"
                Me.PaymentDataGridView.Refresh()
            End If
        Catch EX As Exception
            gblMessage = EX.Message
            MsgStatus.ShowDialog(Me)
        End Try
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        If BindingNavigatorTextBox.Text = "" Then
            LedgerQuery = "SELECT * FROM SUPPLIERS_JOURNAL WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                      "SUPL_TR_DT <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) " & _
                                      "ORDER BY SUPL_TR_ID"
        Else
            LedgerQuery = "SELECT * FROM SUPPLIERS_JOURNAL WHERE SUPL_TR_DT >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                      "SUPL_TR_DT <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDate.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND SUPL_CODE = N'" & BindingNavigatorTextBox.Text.Trim & "' " & _
                                      "ORDER BY SUPL_TR_ID"
        End If
        Call View_Ledgers(LedgerQuery)
    End Sub

    Private Sub BindingNavigatorFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFind.Click
        WholesalerCodes.ShowDialog(Me)
        If Len(gblCP_ID) > 0 Then BindingNavigatorTextBox.Text = gblCP_ID.ToUpper Else gblCP_ID = 0
    End Sub

    Private Sub BindingNavigatorTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyUp
        If e.KeyCode = Keys.F2 Then
            WholesalerCodes.ShowDialog(Me)
            If Len(gblCP_ID) > 0 Then BindingNavigatorTextBox.Text = gblCP_ID.ToUpper Else gblCP_ID = 0
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        WholesalersMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class