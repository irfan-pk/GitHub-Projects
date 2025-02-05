Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ProductsOld
    Dim drag, EditMode, AddMode As Boolean
    Dim EditString As String
    Dim PPrice As Double
    Dim mousex, mousey, Pos As Integer

    Private Sub frmProducts_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmProducts_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmProducs_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
        Stock.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.cmdClose.Left = Me.Width - (cmdClose.Width + 5)
        Me.cmdMin.Left = Me.Width - (cmdMin.Width + cmdClose.Width + 5)
        Call GetConnectionString()
        Call Load_Data()
        'For Refresh Menu Bar when no data in gridview
        Call BindingNavigatorEditItem_Click(sender, e)
        Call BindingNavigatorEditItem_Click(sender, e)
    End Sub

    Private Sub Load_Data()
        Try
            'Retrieve Records for datagrid view from product table
            Me.ProductDataSet.Clear()
            'ProductAdapter.Dispose()
            Dim ProductQuery As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CD"
            ExecuteAdapterQuery(ProductAdapter, ProductQuery, Connection)
            ProductAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            ProductBindingSource.DataSource = Me.ProductDataSet
            Dim reader2 As SqlDataReader = ProductAdapter.SelectCommand.ExecuteReader
            If reader2.HasRows Then
                ProductBindingSource.DataSource = Me.ProductDataSet
                ProductBindingSource.DataMember = "PRODUCTS"
                ProductDataGridView.Refresh()
                txtCode.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_CD")
                txtDesc.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_DESC")
                txtCatg.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_CATG")
                txtPck.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_PACK")
                txtMargin.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_PROFIT")
                txtSalePrice.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_SPRICE")
                txtPPrice.DataBindings.Add("TEXT", Me.ProductBindingSource, "PROD_PPRICE")
            End If
            'BindingNavigatorSaveItem.Enabled = False
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Enable_Disable_Controls(ByVal State As String)
        BindingNavigatorMoveNextItem.Enabled = State
        BindingNavigatorMovePreviousItem.Enabled = State
        ProductDataGridView.Enabled = State
        BindingNavigatorDeleteItem.Visible = State
        'BindingNavigatorAddNewItem.Visible = State
        ToolStripSeparator2.Visible = State
        ToolStripSeparator3.Visible = State
    End Sub

    Private Sub txtSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalePrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtSalePrice.Text) < 1 Then gblMessage = "Product Sale Price invalid ?" : MsgStatus.ShowDialog(Me) : Exit Sub
            txtMargin.Text = Val(txtSalePrice.Text) - Val(txtPPrice.Text)
            txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtMargin.Text.Trim)
        End If
    End Sub

    Private Sub txtCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.GotFocus
        Call Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSalePrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalePrice.KeyPress
        ' Numeric input allowed only
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then e.Handled = True
        End If
    End Sub

    Private Sub txtSalePrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.GotFocus
        Call Get_Property_GotFocus(txtSalePrice)
        txtSalePrice.Text = Val(txtPPrice.Text) + Val(txtMargin.Text.Trim)
    End Sub

    Private Sub txtDesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.GotFocus
        Call Get_Property_GotFocus(txtDesc)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        ' Alpha Numeric input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Or (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 46 Then
            ' Go Through
            ' uncommit following routine when need only First Letter capitalized of text
            'If e.KeyChar <> ChrW(Keys.Back) Then
            '    If txtDesc.Text = "" Then
            '        e.KeyChar = UCase(e.KeyChar)
            '    End If
            'End If
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtDesc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.LostFocus
        Call Get_Property_LostFocus(txtDesc)
        txtDesc.Text = StrConv(txtDesc.Text.Trim, VbStrConv.ProperCase)

    End Sub

    Private Sub txtMargin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargin.GotFocus
        Call Get_Property_GotFocus(txtMargin)
    End Sub

    Private Sub txtMargin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMargin.KeyPress
        Call ValidateKeyPress(sender, e, txtMargin, txtSalePrice)
    End Sub

    Private Sub txtMargin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargin.LostFocus
        Call Get_Property_LostFocus(txtMargin)
    End Sub

    Private Sub txtPck_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPck.GotFocus
        Call Get_Property_GotFocus(txtPck)
    End Sub

    Private Sub txtPck_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPck.KeyPress
        ' Alpha input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
            ' Go Through
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtPck_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPck.LostFocus
        Call Get_Property_LostFocus(txtPck)
    End Sub

    Private Sub txtCatg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Call Get_Property_GotFocus(txtCatg)
    End Sub

    Private Sub txtCatg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Alpha input allowed only
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        If (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
            ' Go Through
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCatg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Call Get_Property_LostFocus(txtCatg)
    End Sub

    Private Sub ValidateKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal txt As TextBox, ByVal nexttxt As TextBox)
        '48 - 57  = Ascii codes for numbers
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
        'If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
        'If e.KeyChar = Chr(13) Then nexttxt.Focus() 'Enter key moves to next control
        'If e.KeyChar = Chr(13) Then GetNextControl(nexttxt, True).Focus() 'Enter key moves to next control
    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click
        If BindingNavigatorEditItem.Text = "&Cancel" Then
            Call Enable_Disable_Controls("True")
            BindingNavigatorEditItem.Text = "&Edit Product"
            EditMode = False
            AddMode = False
            SplitContainer1.Panel1.Enabled = False
            BindingNavigatorSaveItem.Enabled = False
            Call RefreshDB()
            Exit Sub
        End If
        EditMode = True
        AddMode = False
        EditString = txtCode.Text.Trim
        txtDesc.Text = txtDesc.Text.Trim
        SplitContainer1.Panel1.Enabled = True
        BindingNavigatorSaveItem.Enabled = True
        Call Enable_Disable_Controls("False")
        BindingNavigatorEditItem.Text = "&Cancel"
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        EditMode = False
        AddMode = True
        EditString = 0
        txtDesc.Text = txtDesc.Text.Trim
        SplitContainer1.Panel1.Enabled = True
        BindingNavigatorSaveItem.Enabled = True
        Call Enable_Disable_Controls("False")
        BindingNavigatorEditItem.Text = "&Cancel"
        txtCode.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        MsgBox("Are you sure to delete product ?" & Space(2) & "(" & Trim(txtCode.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record")
        If MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM PRODUCTS WHERE PROD_CD = '" & txtCode.Text.ToUpper.Trim & "'"
            ExecuteAdapterQuery(SqlDataAdapter, CommandText, Connection)
        End If
        If Me.BindingNavigatorEditItem.Text = "&Cancel" Then Me.BindingNavigatorEditItem.Text = "&Edit Product"
        ProductDataGridView.Refresh()
        BindingNavigator.Refresh()
        'Call RefreshDB()
    End Sub

    Private Sub RefreshDB()
        Try
            Me.ProductDataSet.Clear()
            Me.ProductBindingSource.EndEdit()
            ProductAdapter.Dispose()
            Me.ProductDataGridView.Refresh()
            Dim QueryText As String = "SELECT * FROM PRODUCTS ORDER BY PROD_CD"
            ExecuteDatasetQuery(ProductAdapter, SqlDataSet, QueryText, "PRODUCTS", Connection)
            ProductAdapter.Fill(Me.ProductDataSet, "PRODUCTS")
            Me.ProductBindingSource.DataSource = Me.ProductDataSet
            Me.ProductBindingSource.DataMember = "PRODUCTS"
            Me.ProductDataGridView.RefreshEdit()
            Me.ProductDataGridView.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub BindingNavigatorFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorFindItem.Click
        Dim strCode As String
        strCode = Microsoft.VisualBasic.InputBox("Please Enter Product Code To Find.", "Find")
        If Len(strCode) = 0 Then Exit Sub
        Pos = Me.ProductBindingSource.Find("prod_cd", strCode.Trim)
        If Not Pos = -1 Then
            EditString = strCode
            Me.ProductBindingSource.Position = Pos
        End If
    End Sub

    Private Sub txtCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.LostFocus
        Call Get_Property_GotFocus(txtCode)
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        If txtCode.Text = "" Or txtCatg.Text = "" Or txtDesc.Text = "" Or txtPPrice.Text = "" Or txtSalePrice.Text = "" Then gblMessage = "All Fields are mandatory." : MsgStatus.ShowDialog(Me) : Exit Sub
        txtMargin.Text = Val(txtSalePrice.Text.Trim) - Val(txtPPrice.Text.Trim)
        '// If changes made in selected record then execute update data into table
        If EditMode = True And AddMode = False Then Call BindingNavigatorQuery("UPDATE PRODUCTS SET " & _
                                                                               "PROD_CD = '" & txtCode.Text.Trim & "', " & _
                                                                               "PROD_DESC = '" & txtDesc.Text.Trim & "', " & _
                                                                               "PROD_CATG = '" & txtCatg.Text.Trim & "', " & _
                                                                               "PROD_PPRICE = " & Val(txtPPrice.Text.Trim) & ", " & _
                                                                               "PROD_PROFIT = " & Val(txtMargin.Text.Trim) & ", " & _
                                                                               "PROD_SPRICE = " & Val(txtSalePrice.Text.Trim) & ", " & _
                                                                               "PROD_UPD_ON = '" & Format(Date.Parse(Now.Date.ToString.Trim), "MM/dd/yyyy") & "' " & _
                                                                               "WHERE (PROD_CD = N'" & EditString.Trim & "')")

        '// if entered new values in text boxes then execute add data into table
        If AddMode = True And EditMode = False Then
            If Len(txtCode.Text.Trim) > 0 And _
               Len(txtDesc.Text.Trim) > 0 And _
               Len(txtPck.Text.Trim) > 0 And _
               Len(txtCatg.Text.Trim) > 0 And _
               Len(txtPPrice.Text.Trim) > 0 And _
               Len(txtMargin.Text.Trim) > 0 And _
               Len(txtSalePrice.Text.Trim) > 0 Then

                Call BindingNavigatorQuery("INSERT INTO PRODUCTS VALUES ('" & _
                                                                                       txtCode.Text.Trim & "','" & _
                                                                                       txtDesc.Text.Trim & "','" & _
                                                                                       txtCatg.Text.Trim & "','" & _
                                                                                       txtPck.Text.Trim & "'," & _
                                                                                       Val(txtPPrice.Text.Trim) & "," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       "0," & _
                                                                                       Val(txtMargin.Text.Trim) & "," & _
                                                                                       "0," & _
                                                                                       Val(txtSalePrice.Text.Trim) & ",'" & _
                                                                                       Format(Date.Parse(Now.Date.ToString), "MM/dd/yyyy") & "','" & _
                                                                                       Format(Date.Parse(Now.Date.ToString), "MM/dd/yyyy") & "')")
            Else
                gblMessage = "Please fill all fields for insert new product."
                MsgStatus.ShowDialog(Me)
            End If
        End If
        Call Enable_Disable_Controls("True")
        Call RefreshDB()
        SplitContainer1.Panel1.Enabled = False
        If EditMode = True Then
            ProductBindingSource.ResetBindings(True)
            Pos = Me.ProductBindingSource.Find("PROD_CD", EditString.Trim)
            If Not Pos = -1 Then
                Me.ProductBindingSource.Position = Pos
            End If
        End If
        EditMode = False
        AddMode = False
        Me.BindingNavigatorEditItem.Enabled = True
        Me.BindingNavigatorEditItem.Text = "&Edit Product"
    End Sub

    Private Sub BindingNavigatorQuery(ByVal Query As String)
        Try
            ExecuteAdapterQuery(SqlDataAdapter, Query, Connection)
            Connection.Close()
            SqlDataAdapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub txtPPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPPrice.GotFocus
        Call Get_Property_GotFocus(txtPPrice)
    End Sub

    Private Sub txtPPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPPrice.LostFocus
        Call Get_Property_LostFocus(txtPPrice)
    End Sub

    Private Sub txtSalePrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalePrice.LostFocus
        Call Get_Property_LostFocus(txtSalePrice)
    End Sub

End Class