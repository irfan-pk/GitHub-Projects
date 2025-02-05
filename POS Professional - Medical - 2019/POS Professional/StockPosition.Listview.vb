Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class StockPosition
    Dim drag As Boolean
    Dim Total As Double
    Dim mousex, mousey, Pos As Integer

    Private Sub frmStockPosition_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmStockPosition_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmStockPosition_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        StockMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmStockPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Try
            'Retrieve Records for datagrid view from product table
            Me.ProductDataSet.Clear()
            ProductAdapter.Dispose()
            Dim ProductQuery As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CODE"
            ExecuteAdapterQuery(ProductAdapter, ProductQuery, Connection)
            ProductAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            Dim reader2 As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
            If reader2.HasRows Then
                ProductBindingSource.DataSource = Me.ProductDataSet
                ProductBindingSource.DataMember = "PRODUCTS"
                While reader2.Read
                    Dim ProductItem As New ListViewItem
                    ProductItem.Text = Convert.ToString(reader2.Item("prod_code"))
                    ProductItem.SubItems.Add(Convert.ToString(reader2.Item("prod_desc")))
                    ProductItem.SubItems.Add(Convert.ToString(reader2.Item("prod_catg")))
                    ProductItem.SubItems.Add(Convert.ToString(reader2.Item("prod_packing")))
                    ProductItem.SubItems.Add(Convert.ToString(Val(reader2.Item("prod_stock")) / Val(reader2.Item("prod_qty_per_unit"))))
                    ProductItem.SubItems.Add(Convert.ToString(reader2.Item("prod_stock")))
                    ProductItem.SubItems.Add(Convert.ToString(reader2.Item("prod_purch_price")))
                    ProductItem.SubItems.Add(Convert.ToString(reader2.Item("prod_sale_price")))
                    ProductItem.SubItems.Add(Convert.ToString(Val(reader2.Item("prod_stock")) * Val(reader2.Item("prod_purch_price"))))
                    ProductItem.SubItems.Add(Convert.ToString(Format(DateTime.Parse(reader2.Item("prod_upd_on")), "MM/dd/yyyy")))
                    StockListView.Items.Add(ProductItem)
                End While
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
        End Try
        'Call BindingNavigatorSummary_Click(sender, e)
    End Sub

    Private Sub BindingNavigatorFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFind.Click
        If BindingNavigatorTextBox.Text = "" Then MsgBox("Please give valid product code.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Application.Info.ProductName) : Exit Sub
        Dim strCode As String
        strCode = BindingNavigatorTextBox.Text.Trim
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.ProductBindingSource.Find("PROD_CODE", strCode.Trim)
        If Not Pos = -1 Then
            Me.ProductBindingSource.Position = Pos
        End If
    End Sub

    Private Sub BindingNavigatorTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorTextBox.Click
        Call BindingNavigatorFind_Click(sender, e)
    End Sub

    Private Sub BindingNavigatorTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BindingNavigatorTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BindingNavigatorFind_Click(sender, e)
        End If
    End Sub

    Private Sub BindingNavigatorSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSummary.Click

        'If DataGridView1.Rows.Count > 0 Then DataGridView1.Rows.Clear()

        'Dim Summary_Query As String = "SELECT SUM(PROD_STOCK) AS RAW_STOCK, " & _
        '                              "SUM(PROD_PURCH_PRICE * PROD_STOCK) AS TOTAL_AMNT " & _
        '                              "FROM PRODUCTS WHERE PROD_STOCK > 0"

        'ExecuteAdapterQuery(SqlDataAdapter, Summary_Query, Connection)
        'Dim SummaryReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        ''DataGridView1.ColumnCount = 9
        'If SummaryReader.HasRows Then
        '    While SummaryReader.Read
        '        If Val(SummaryReader.Item("TOTAL_AMNT").ToString) > 0 Then
        '            Dim RowIndex As Integer = DataGridView1.Rows.Add()
        '            Dim NewRow As DataGridViewRow = DataGridView1.Rows(RowIndex)
        '            NewRow.Cells(0).Value = "Stock with Positive Balance"
        '            NewRow.Cells(1).Value = SummaryReader.Item("RAW_STOCK").ToString
        '            NewRow.Cells(2).Value = SummaryReader.Item("TOTAL_AMNT").ToString
        '        End If
        '    End While
        '    If SummaryReader Is Nothing Then SummaryReader.Close()
        'End If

        'Dim Summary_Query_Neg As String = "SELECT SUM(PROD_STOCK) AS RAW_STOCK, " & _
        '                                  "SUM(PROD_PURCH_PRICE * PROD_STOCK) AS TOTAL_AMNT " & _
        '                                  "FROM PRODUCTS WHERE PROD_STOCK < 0"

        'ExecuteAdapterQuery(SqlDataAdapter, Summary_Query_Neg, Connection)
        'Dim SummaryReaderNeg As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        ''DataGridView1.ColumnCount = 9
        'If SummaryReaderNeg.HasRows Then
        '    While SummaryReaderNeg.Read
        '        If Val(SummaryReaderNeg.Item("TOTAL_AMNT").ToString) < 0 And Not IsDBNull(SummaryReaderNeg.Item("TOTAL_AMNT").ToString) Then
        '            Dim RowIndex As Integer = DataGridView1.Rows.Add()
        '            Dim NewRow As DataGridViewRow = DataGridView1.Rows(RowIndex)
        '            NewRow.Cells(0).Value = "Stock with Negative Balance"
        '            'NewRow.Cells(1).Value = SummaryReader.Item("RAW_STOCK").ToString
        '            'NewRow.Cells(2).Value = SummaryReader.Item("TOTAL_AMNT").ToString
        '        End If
        '    End While
        '    If SummaryReaderNeg Is Nothing Then SummaryReaderNeg.Close()
        'End If

    End Sub

    Private Sub BindingNavigatorSummaryGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSummaryGroup.Click
        'If DataGridView1.Rows.Count > 0 Then DataGridView1.Rows.Clear()

        'Dim Summary_Query As String = "SELECT PROD_CATG, " & _
        '                              "SUM(PROD_STOCK) AS RAW_STOCK, " & _
        '                              "SUM(PROD_PURCH_PRICE * PROD_STOCK) AS TOTAL_AMNT " & _
        '                              "FROM PRODUCTS WHERE PROD_STOCK > 0 " & _
        '                              "GROUP BY PROD_CATG"

        'ExecuteAdapterQuery(SqlDataAdapter, Summary_Query, Connection)
        'Dim SummaryReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        ''DataGridView1.ColumnCount = 9
        'If SummaryReader.HasRows Then
        '    While SummaryReader.Read
        '        If Val(SummaryReader.Item("TOTAL_AMNT").ToString) > 0 Then
        '            Dim RowIndex As Integer = DataGridView1.Rows.Add()
        '            Dim NewRow As DataGridViewRow = DataGridView1.Rows(RowIndex)
        '            NewRow.Cells(0).Value = SummaryReader.Item("PROD_CATG").ToString.Trim & " with +ve Balance"
        '            NewRow.Cells(1).Value = SummaryReader.Item("RAW_STOCK").ToString
        '            NewRow.Cells(2).Value = SummaryReader.Item("TOTAL_AMNT").ToString
        '        End If
        '    End While
        '    If SummaryReader Is Nothing Then SummaryReader.Close()
        'End If

        'Dim Summary_Query_Neg As String = "SELECT PROD_CATG, " & _
        '                                  "SUM(PROD_STOCK) AS RAW_STOCK, " & _
        '                                  "SUM(PROD_PURCH_PRICE * PROD_STOCK) AS TOTAL_AMNT " & _
        '                                  "FROM PRODUCTS WHERE PROD_STOCK < 0 " & _
        '                                  "GROUP BY PROD_CATG"

        'ExecuteAdapterQuery(SqlDataAdapter, Summary_Query_Neg, Connection)
        'Dim SummaryReaderNeg As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        ''DataGridView1.ColumnCount = 9
        'If SummaryReaderNeg.HasRows Then
        '    While SummaryReaderNeg.Read
        '        If Val(SummaryReaderNeg.Item("TOTAL_AMNT").ToString) < 0 Then
        '            Dim RowIndex As Integer = DataGridView1.Rows.Add()
        '            Dim NewRow As DataGridViewRow = DataGridView1.Rows(RowIndex)
        '            NewRow.Cells(0).Value = SummaryReaderNeg.Item("PROD_CATG").ToString.Trim & " with -ve Balance"
        '            NewRow.Cells(1).Value = SummaryReader.Item("RAW_STOCK").ToString
        '            NewRow.Cells(2).Value = SummaryReader.Item("TOTAL_AMNT").ToString
        '        End If
        '    End While
        '    If SummaryReaderNeg Is Nothing Then SummaryReaderNeg.Close()
        'End If
    End Sub
End Class