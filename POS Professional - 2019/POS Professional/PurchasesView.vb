Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class PurchasesView
    Dim drag, EditMode As Boolean
    Dim PPrice As Double
    Dim PurchaseQuery As String
    Dim mousex, mousey, Pos As Integer

    Private Sub frmViewPurchases_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmViewPurchases_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmViewPurchases_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmViewPurchases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 8)
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + cmdClose.Width + 8)
        Call GetConnectionString()
        FromDateTime.Value = DateAdd(DateInterval.Day, -1, Date.Now)
        PurchaseQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                      "PRCH_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND (PRCH_STATUS = 'UPDATED') " & _
                                      "ORDER BY PRCH_TR_ID"
        Call View_Data(PurchaseQuery)
    End Sub

    Private Sub View_Data(ByVal StandardQuery As String)
        Try
            'Retrieve Records for datagrid view from product table
            Me.PurchaseDataSet.Clear()
            PurchaseAdapter.Dispose()
            ExecuteAdapterQuery(PurchaseAdapter, StandardQuery, Connection)
            PurchaseAdapter.Fill(Me.PurchaseDataSet, "PURCHASE")
            Dim Reader As SqlDataReader = PurchaseAdapter.SelectCommand.ExecuteReader
            If Reader.HasRows Then
                Me.PurchaseBindingSource.DataSource = Me.PurchaseDataSet
                Me.PurchaseBindingSource.DataMember = "PURCHASE"
                Me.PurchaseDataGridView.Refresh()
            End If
        Catch EX As Exception
            gblMessage = EX.Message
            MsgStatus.ShowDialog(Me)
        End Try
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        If BindingNavigatorTextBox.Text = "" Then
            PurchaseQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                      "PRCH_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) " & _
                                      "ORDER BY PRCH_TR_ID"
        Else
            PurchaseQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                      "PRCH_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND PRCH_PROD_CD = N'" & BindingNavigatorTextBox.Text.Trim & "' " & _
                                      "ORDER BY PRCH_TR_ID"
        End If
        Call View_Data(PurchaseQuery)
    End Sub

    Private Sub BindingNavigatorFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFind.Click
        If BindingNavigatorTextBox.Text = "" Then MsgBox("Please select valid product code.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName) : Exit Sub
        PurchaseQuery = "SELECT * FROM PURCHASE WHERE PRCH_DATE >= CONVERT(DATETIME,'" & Format(DateTime.Parse(FromDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND " & _
                                      "PRCH_DATE <= CONVERT(DATETIME,'" & Format(DateTime.Parse(ToDateTime.Text.Trim.ToString), "yyyy-MM-dd") & " 00:00:00',102) AND PRCH_PROD_CD = N'" & BindingNavigatorTextBox.Text.Trim & "' " & _
                                      "ORDER BY PRCH_TR_ID"
        Call View_Data(PurchaseQuery)
        'Dim strCode As String
        'strCode = BindingNavigatorTextBox.Text.Trim
        'If Len(strCode) = 0 Then Exit Sub
        'Pos = Me.PurchaseBindingSource.Find("PRCH_PROD_CD", strCode.Trim)
        'If Not Pos = -1 Then
        '    Me.PurchaseBindingSource.Position = Pos
        'End If
    End Sub

    Private Sub BindingNavigatorTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub

    Private Sub BindingNavigatorTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyUp
        If e.KeyCode = Keys.F2 Then
            ProductCode.ShowDialog(Me)
            If Len(gblItemCode) > 0 Then BindingNavigatorTextBox.Text = gblItemCode.ToUpper Else Exit Sub
            Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub
End Class