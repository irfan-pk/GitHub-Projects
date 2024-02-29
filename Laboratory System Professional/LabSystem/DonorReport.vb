Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared

Public Class DonorReport
    Dim EditString, EditString2, DonorName As String
    Dim objCellStyle As New DataGridViewCellStyle()
    Dim wTestID, DonorPID, DonorID As Integer
    Dim Binded As Boolean = False
    Dim CurrentPath As String = Directory.GetCurrentDirectory()

    Private Sub frmDonorProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Binded = False
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
            Me.DonorDataSet.Clear()
            Dim CommandText As String = "SELECT * FROM DONOR_TABLE WHERE DONOR_ID = " & Val(TextBoxFind.Text.Trim) & " ORDER BY DONOR_ID, DONOR_PID"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "DONOR_TABLE", Connection)
            SqlDataAdapter.Fill(Me.DonorDataSet, "DONOR_TABLE")
            Me.DonorBindingSource.DataSource = Me.DonorDataSet
            Me.DonorBindingSource.DataMember = "DONOR_TABLE"
            Me.txtWeight.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_WT")
            Me.cmbPGroup.DataBindings.Add("TEXT", DonorBindingSource, "PATIENT_GRP")
            Me.cmbDGroup.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_GROUP")
            Me.cmbHBS.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_HBS")
            Me.cmbHCV.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_HCV")
            Me.cmbHIV.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_HIV")
            Me.cmbVDRL.DataBindings.Add("TEXT", DonorBindingSource, "DONOR_VDRL")
            ToolStripSaveButton.Enabled = False
            objCellStyle.BackColor = Color.WhiteSmoke
            DonorDataGrid.AlternatingRowsDefaultCellStyle = objCellStyle
            Binded = True
            Me.ToolStripSaveButton.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub ToolStripCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripCloseButton.Click
        If ToolStripCloseButton.Text = "&Close" Then
            Connection.Close()
            Me.Close()
        Else
            ToolStripCloseButton.Text = "&Close"
            ToolStripSaveButton.Enabled = False
            ToolStripEditButton.Enabled = True
            Call RefreshDB()
        End If
    End Sub

    Private Sub ToolStripSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSaveButton.Click

        EditString = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value.ToString.Trim
        EditString2 = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(3).Value.ToString.Trim

        '// If changes made in selected record then execute update record query
        Call BindingNavigatorQuery("UPDATE DONOR_TABLE SET" & _
                                   " DONOR_WT = '" & StrConv(txtWeight.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                   " PATIENT_GRP = '" & StrConv(cmbPGroup.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                   " DONOR_GROUP = '" & StrConv(cmbDGroup.Text.Trim, VbStrConv.ProperCase) & "'," & _
                                   " DONOR_HBS = '" & StrConv(cmbHBS.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                   " DONOR_HCV = '" & StrConv(cmbHCV.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                   " DONOR_HIV = '" & StrConv(cmbHIV.Text.Trim, VbStrConv.Uppercase) & "'," & _
                                   " DONOR_VDRL = '" & StrConv(cmbVDRL.Text.Trim, VbStrConv.Uppercase) & "'" & _
                                   " WHERE (DONOR_ID = " & Val(EditString) & ") AND (DONOR_NAME LIKE '%" & EditString2 & "%')")

        Call RefreshDB()
        EditString = String.Empty
        EditString2 = String.Empty
        Me.ToolStripSaveButton.Enabled = False
        Me.ToolStripEditButton.Enabled = True
        Me.ToolStripButtonPrint.Enabled = True
        Me.ToolStripCloseButton.Text = "&Close"

    End Sub

    Private Sub ToolStripEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripEditButton.Click

        ToolStripSaveButton.Enabled = True
        ToolStripCloseButton.Text = "&Cancel"
        EditString = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value.ToString.Trim
        EditString2 = DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(3).Value.ToString.Trim
        txtWeight.Focus()

    End Sub

    Private Sub RefreshDB()
        Try
            Me.DonorDataSet.Clear()
            SqlDataAdapter.Dispose()
            Dim QueryText As String = "SELECT * FROM DONOR_TABLE WHERE DONOR_ID = " & Val(TextBoxFind.Text.Trim) & " ORDER BY DONOR_ID, DONOR_PID"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, QueryText, "DONOR_TABLE", Connection)
            SqlDataAdapter.Fill(Me.DonorDataSet, "DONOR_TABLE")
            Me.DonorBindingSource.DataSource = Me.DonorDataSet
            Me.DonorBindingSource.DataMember = "DONOR_TABLE"
            Me.DonorDataGrid.Update()
            Me.DonorDataGrid.RefreshEdit()
            Me.ToolStripSaveButton.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
        End Try
        Connection.Close()

    End Sub

    Private Sub TextBoxFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Binded = False Then
                Call LoadDB()
            Else
                Call RefreshDB()
            End If
        End If
    End Sub

    Private Sub TextBoxFind_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxFind.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonPrint.Click
        Dim CommandText As String = String.Empty
        Call GetConnectionString()
        If DonorID = 0 And DonorPID = 0 Then
            MsgBox("Plz Select Donor to print report.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
        Try
            SqlDataSet.Clear()
            ConnInfo.ConnectionInfo.UserID = ServerID
            ConnInfo.ConnectionInfo.Password = ServerPwd
            ConnInfo.ConnectionInfo.ServerName = ServerName
            ConnInfo.ConnectionInfo.DatabaseName = "LAB_PRO"
            PrintDialog.Cursor = Cursors.WaitCursor
            PrintDialog.ShowDialog()
            CommandText = "SELECT * FROM donor_table where donor_id = " & DonorID & " and donor_pid = " & DonorPID
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "donor_table", Connection)
            ' Load Report in memory for View
            Try
                gblReportName = CurrentPath & "\Pathology\Donor Profile.rpt"
                objReport.Load(gblReportName.Trim)
            Catch Error1 As Exception
                MsgBox(Error1.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Exit Sub
            End Try
            'Set logon information to reports for view
            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConnInfo)
            Next
            'Set the Datasource for reports
            objReport.SetDataSource(SqlDataSet.Tables("donor_table"))
            'Set Client Printer as Default Printer
            'Try
            '    For Each printer As String In Printing.PrinterSettings.InstalledPrinters
            '        If printer.IndexOf("HP-CLIENT") > -1 Then _
            '            gblDefaultPrinter = printer
            '    Next printer
            '    objReport.PrintOptions.PrinterName = gblDefaultPrinter
            'Catch ex As Exception
            'End Try
            With objReport
                ' Select Donor for print slip
                .RecordSelectionFormula = "{donor_table.donor_id}=" & DonorID & " and {donor_table.donor_pid}=" & DonorPID
                ' For sent Report directly to Printer
                objReport.PrintToPrinter(1, False, 0, 0)
                '// For export report in pdf format if required uncommit the line
                'objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "d:\DonorReport.pdf")
                PrintDialog.Cursor = Cursors.Default
                PrintDialog.Close()
            End With
            objReport.Close()
            Me.ToolStripButtonPrint.Enabled = False
        Catch Excp As Exception
            MsgBox(Excp.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub DonorDataGrid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DonorDataGrid.CellMouseClick
        If Me.DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(0).Value Is Nothing Then Exit Sub
        DonorID = Val(Me.DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(1).Value.ToString)
        DonorPID = Val(Me.DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(2).Value.ToString)
        DonorName = Me.DonorDataGrid.Rows(DonorDataGrid.CurrentRow.Index).Cells(3).Value.ToString.Trim
        Me.ToolStripSaveButton.Enabled = True
        Me.ToolStripButtonPrint.Enabled = True
    End Sub
End Class