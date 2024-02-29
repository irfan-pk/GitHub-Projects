Imports System.Data.SqlClient

Public Class SystemPrinter

    Dim EditString As String
    Dim Addition, Editing, RollBack As Boolean

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        SplitContainer1.Panel2.Enabled = True
        cmbPrinterName.Focus()
        Addition = True
        Editing = False
        EditString = ""
        ToolStripSaveButton.Enabled = True
        ToolStripCloseButton.Text = "&Cancel"
    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click
        Editing = True
        Addition = False
        SplitContainer1.Panel2.Enabled = True
        ToolStripSaveButton.Enabled = True
        ToolStripCloseButton.Text = "&Cancel"
        EditString = cmbPrinterName.Text.Trim
        cmbPrinterName.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Are you sure to delete ?" & Space(2) & "(" & Trim(cmbPrinterName.Text.ToUpper) & ")", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Record") = MsgBoxResult.Ok Then
            Dim CommandText As String = "DELETE FROM SYSTEM_PRINTERS WHERE PRINTER_NAME = '" & cmbPrinterName.Text.Trim & "'"
            Execute_DatabaseTable_Query(SqlDataAdapter, CommandText, Connection)
            Me.DataGridView.Update()
        Else
            'skip
            Call RefreshDB()
        End If
    End Sub

    Private Sub RefreshDB()
        Try
            Me.DataSet.Clear()
            SqlDataAdapter.Dispose()
            Dim QueryText As String = "SELECT * FROM SYSTEM_PRINTERS ORDER BY PRINTER_NAME"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "SYSTEM_PRINTERS", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "SYSTEM_PRINTERS")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "SYSTEM_PRINTERS"
            Me.DataGridView.Update()
            Me.DataGridView.RefreshEdit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub ToolStripSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSaveButton.Click
        '// If changes made in selected record then execute update record query
        If Editing = True And Addition = False Then Call BindingNavigatorQuery("update system_printers set printer_name = '" & cmbPrinterName.Text.Trim & "', " & _
                                             "printer_type = '" & cmbPrinterType.Text.Trim & "', " & _
                                             "print_for = '" & cmbPrinterPaper.Text.Trim & "', " & _
                                             "install_loc = '" & cmbPrinterSection.Text.Trim & "',1)")

        '// if entered new values in text boxes then execute add record query
        If Addition = True And Editing = False Then Call BindingNavigatorQuery("INSERT INTO SYSTEM_PRINTERS VALUES('" & cmbPrinterName.Text.Trim & "','" & _
                                             cmbPrinterType.Text.Trim & "','" & cmbPrinterPaper.Text.Trim & "','" & cmbPrinterSection.Text.Trim & "',1)")

        Call RefreshDB()
        ToolStripSaveButton.Enabled = False
        SplitContainer1.Panel2.Enabled = False
        Editing = False
        Addition = False
        ToolStripEditButton.Enabled = True
        Me.ToolStripCloseButton.Text = "&Close"
    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If ToolStripCloseButton.Text = "&Close" Then
            Connection.Close()
            Me.BindingSource.Dispose()
            Me.Close()
        Else
            ToolStripCloseButton.Text = "&Close"
            Addition = False
            Editing = False
            ToolStripSaveButton.Enabled = False
            SplitContainer1.Panel2.Enabled = False
            ToolStripEditButton.Enabled = True
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
            Call RefreshDB()
        End If
    End Sub

    Private Sub BindingNavigatorQuery(ByVal Query As String)
        Try
            Execute_DatabaseTable_Query(SqlDataAdapter, Query, Connection)
            Connection.Close()
            SqlDataAdapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub LoadDB()
        Try
            Me.DataSet.Clear()
            Dim CommandText As String = "SELECT * FROM SYSTEM_PRINTERS ORDER BY PRINTER_NAME"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "SYSTEM_PRINTERS", Connection)
            SqlDataAdapter.Fill(Me.DataSet, "SYSTEM_PRINTERS")
            Me.BindingSource.DataSource = Me.DataSet
            Me.BindingSource.DataMember = "SYSTEM_PRINTERS"
            Me.cmbPrinterName.DataBindings.Add("TEXT", BindingSource, "PRINTER_NAME")
            Me.cmbPrinterPaper.DataBindings.Add("TEXT", BindingSource, "PRINT_FOR")
            Me.cmbPrinterSection.DataBindings.Add("TEXT", BindingSource, "INSTALL_LOC")
            Me.cmbPrinterType.DataBindings.Add("TEXT", BindingSource, "PRINTER_TYPE")
            Addition = False
            Editing = False
            ToolStripSaveButton.Enabled = False
            SplitContainer1.Panel2.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub SystemPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbPrinterName.Items.Clear()
            For Each printer As String In Printing.PrinterSettings.InstalledPrinters
                cmbPrinterName.Items.Add(printer)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        Call GetConnectionString()
        Call LoadDB()
    End Sub
End Class