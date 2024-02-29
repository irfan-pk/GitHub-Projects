Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmDocList
    Dim EditString As String
    Dim Pos As Integer
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim Addition, Editing, RollBack As Boolean
    Private Sub frmDocList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.DocBindingSource.Dispose()
        Connection.Close()
    End Sub

    Private Sub frmDocList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Call LoadDB()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        txtName.Enabled = True
        txtPhone.Enabled = True
        txtName.Focus()
        Addition = True
        RollBack = True
        Editing = False
        Me.BindingNavigatorSave.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

        Dim DeleteQuery As String = ""
        MsgBox("Are you sure to delete ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, My.Application.Info.ProductName)
        If MsgBoxResult.Ok Then DeleteQuery = "DELETE FROM DOCLIST WHERE DOC_NAME = '" & txtName.Text.ToUpper & "'"
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, DeleteQuery, "DOCLIST", Connection)

    End Sub

    Private Sub BindingNavigatorQuery(ByVal Query As String)
        'Try
        'Dim objAdapter As New OleDb.OleDbDataAdapter()
        'Dim objDataSet As New DataSet()
        'Dim objConnection As New OleDb.OleDbConnection(ConnString)

        'objAdapter.SelectCommand = New OleDb.OleDbCommand()
        'objAdapter.SelectCommand.Connection = myConn
        'objAdapter.SelectCommand.CommandText = Query

        'objConnection.Open()
        'objAdapter.SelectCommand.CommandType = CommandType.Text
        'objAdapter.SelectCommand.ExecuteNonQuery()
        'objConnection.Close()
        'objConnection.Dispose()
        'objAdapter.Dispose()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click
        Editing = True
        Addition = False
        txtName.Enabled = True
        txtPhone.Enabled = True
        BindingNavigatorSave.Enabled = True
        Me.ToolStripCloseButton.Text = "&Cancel"
        EditString = txtName.Text.Trim
        txtName.Focus()
    End Sub

    Private Sub BindingNavigatorSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSave.Click

        Dim Edit_Update_Query As String = ""
        If Editing = True And Addition = False Then Edit_Update_Query = "UPDATE DOCLIST SET DOC_NAME = '" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "', DOC_PHONE = '" & txtPhone.Text.Trim & "' WHERE DOC_NAME = '" & EditString & "'"
        If Addition = True And Editing = False Then Edit_Update_Query = "INSERT INTO DOCLIST VALUES('" & StrConv(txtName.Text.Trim, VbStrConv.ProperCase) & "','" & txtPhone.Text.Trim & "')"
        Execute_DatabaseTable_Query(SqlDataAdapt, Edit_Update_Query, Connection)
        Call RefreshDB()
        BindingNavigatorSave.Enabled = False
        Me.ToolStripCloseButton.Text = "&Close"
        SqlDataAdapt.Dispose()
        Connection.Close()

    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If ToolStripCloseButton.Text = "&Close" Then
            Connection.Close()
            Me.Close()
        Else
            ToolStripCloseButton.Text = "&Close"
            Addition = False
            Editing = False
            BindingNavigatorSave.Enabled = False
            txtName.Enabled = False
            txtPhone.Enabled = False
            Call RefreshDB()
        End If
    End Sub
    Private Sub LoadDB()
        Try
            Dim LoadQuery As String = "SELECT * FROM DOCLIST ORDER BY DOC_NAME"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, LoadQuery, "DOCLIST", Connection)
            SqlDataAdapt.Fill(Me.DocDataSet, "DOCLIST")
            Me.DocBindingSource.DataSource = Me.DocDataSet
            Me.DocBindingSource.DataMember = "DOCLIST"
            Me.txtName.DataBindings.Add("TEXT", DocBindingSource, "DOC_NAME")
            Me.txtPhone.DataBindings.Add("TEXT", DocBindingSource, "DOC_PHONE")
            Addition = False
            Editing = False
            BindingNavigatorSave.Enabled = False
            txtName.Enabled = False
            txtPhone.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            DocDataGridView.AlternatingRowsDefaultCellStyle = objCellStyle
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub
    Private Sub RefreshDB()
        Try
            Me.DocDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM DOCLIST ORDER BY DOC_NAME"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "DOCLIST", Connection)
            SqlDataAdapt.Fill(Me.DocDataSet, "DOCLIST")
            Me.DocBindingSource.DataSource = Me.DocDataSet
            Me.DocBindingSource.DataMember = "DOCLIST"
            Me.DocDataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
    End Sub

    Private Sub DocDataGridView_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DocDataGridView.RowPostPaint
        ' Calculate the bounds of the row.
        Dim rowBounds As New Rectangle(Me.DocDataGridView.RowHeadersWidth, _
            e.RowBounds.Top, Me.DocDataGridView.Columns.GetColumnsWidth( _
            DataGridViewElementStates.Visible) - _
            Me.DocDataGridView.HorizontalScrollingOffset + 1, e.RowBounds.Height)

        Dim forebrush As SolidBrush = Nothing
        Try
            ' Determine the foreground color.
            If (e.State And DataGridViewElementStates.Selected) = _
                DataGridViewElementStates.Selected Then

                forebrush = New SolidBrush(e.InheritedRowStyle.SelectionForeColor)
            Else
                forebrush = New SolidBrush(e.InheritedRowStyle.ForeColor)
            End If

            ' Get the content that spans multiple columns.
            'Dim recipe As Object = _
            'Me.TstDataGrid.Rows.SharedRow(e.RowIndex).Cells(2).Value

            'If (recipe IsNot Nothing) Then
            '    Dim text As String = recipe.ToString()

            ' Calculate the bounds for the content that spans multiple 
            ' columns, adjusting for the horizontal scrolling position 
            ' and the current row height, and displaying only whole
            ' lines of text.
            Dim textArea As Rectangle = rowBounds
            textArea.X -= Me.DocDataGridView.HorizontalScrollingOffset
            textArea.Width += Me.DocDataGridView.HorizontalScrollingOffset
            textArea.Y += rowBounds.Height - e.InheritedRowStyle.Padding.Bottom
            textArea.Height -= rowBounds.Height - e.InheritedRowStyle.Padding.Bottom
            textArea.Height = (textArea.Height \ e.InheritedRowStyle.Font.Height) * _
                e.InheritedRowStyle.Font.Height

            ' Calculate the portion of the text area that needs painting.
            Dim clip As RectangleF = textArea
            clip.Width -= Me.DocDataGridView.RowHeadersWidth + 1 - clip.X
            clip.X = Me.DocDataGridView.RowHeadersWidth + 1
            Dim oldClip As RectangleF = e.Graphics.ClipBounds
            e.Graphics.SetClip(clip)

            ' Draw the content that spans multiple columns.
            e.Graphics.DrawString(Text, e.InheritedRowStyle.Font, forebrush, _
                textArea)

            e.Graphics.SetClip(oldClip)
            'End If
        Finally
            forebrush.Dispose()
        End Try

        If Me.DocDataGridView.CurrentCellAddress.Y = e.RowIndex Then
            ' Paint the focus rectangle.
            e.DrawFocus(rowBounds, True)
        End If
    End Sub

    Private Sub DocDataGridView_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DocDataGridView.RowPrePaint
        ' Do not automatically paint the focus rectangle.
        e.PaintParts = e.PaintParts And Not DataGridViewPaintParts.Focus

        ' Determine whether the cell should be painted with the 
        ' custom selection background.
        If (e.State And DataGridViewElementStates.Selected) = _
            DataGridViewElementStates.Selected Then

            ' Calculate the bounds of the row.
            Dim rowBounds As New Rectangle( _
                Me.DocDataGridView.RowHeadersWidth, e.RowBounds.Top, _
                Me.DocDataGridView.Columns.GetColumnsWidth( _
                DataGridViewElementStates.Visible) - _
                Me.DocDataGridView.HorizontalScrollingOffset + 1, _
                e.RowBounds.Height)

            ' Paint the custom selection background.
            Dim backbrush As New  _
                System.Drawing.Drawing2D.LinearGradientBrush(rowBounds, _
                Color.LightCyan, _
                Color.Gainsboro, _
                System.Drawing.Drawing2D.LinearGradientMode.Vertical)
            Try
                e.Graphics.FillRectangle(backbrush, rowBounds)
            Finally
                backbrush.Dispose()
            End Try
        End If
    End Sub
End Class