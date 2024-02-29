Imports System.Windows.Forms

Public Class frmCopyRecord

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If gblPrliviges > 1 Then
            MsgBox("You are not authorized, Access Denied.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Exit Sub
        End If
        Dim response = MsgBox("Are You Sure to Transfer Master Data ? this process cannot be undone.", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Transfer Data")
        If response = MsgBoxResult.Yes Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Cursor = Cursors.WaitCursor
            'FOR GENERAL RECORD
            Dim RecordCopyP As String = "SELECT * INTO PATIENT_" & cmbYear.Text.Trim & " FROM PATIENT"
            Call GetConnectionString()
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, RecordCopyP, "PATIENT", Connection)
            Connection.Close()
            Dim RecordCopyR As String = "SELECT * INTO RECEIPT_" & cmbYear.Text.Trim & " FROM RECEIPT"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, RecordCopyR, "RECEIPT", Connection)
            Connection.Close()
            Dim CommandText As String = "DELETE FROM PATIENT"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "PATIENT", Connection)
            Connection.Close()
            Dim CommandString As String = "DELETE FROM RECEIPT"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandString, "RECEIPT", Connection)
            Connection.Close()

            'FOR PCR RECORD
            Dim PCR_Patient As String = "SELECT * INTO PATIENT_PCR_" & cmbYear.Text.Trim & " FROM PATIENT_PCR"
            Call GetConnectionString()
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, PCR_Patient, "PATIENT_PCR", Connection)
            Connection.Close()
            Dim PCR_Receipt As String = "SELECT * INTO RECEIPT_PCR_" & cmbYear.Text.Trim & " FROM RECEIPT_PCR"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, PCR_Receipt, "RECEIPT_PCR", Connection)
            Connection.Close()
            Dim CommandPCRP As String = "DELETE FROM PATIENT_PCR"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandPCRP, "PATIENT_PCR", Connection)
            Connection.Close()
            Dim CommandPCRR As String = "DELETE FROM RECEIPT_PCR"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandPCRR, "RECEIPT_PCR", Connection)
            Connection.Close()

            'FOR SPECIAL TEST RECORD
            Dim ST_Patient As String = "SELECT * INTO PATIENT_ST_" & cmbYear.Text.Trim & " FROM PATIENT_ST"
            Call GetConnectionString()
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, ST_Patient, "PATIENT", Connection)
            Connection.Close()
            Dim ST_Receipt As String = "SELECT * INTO RECEIPT_ST_" & cmbYear.Text.Trim & " FROM RECEIPT_ST"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, ST_Receipt, "RECEIPT", Connection)
            Connection.Close()
            Dim CommandSTP As String = "DELETE FROM PATIENT_ST"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandSTP, "PATIENT_ST", Connection)
            Connection.Close()
            Dim CommandSTR As String = "DELETE FROM RECEIPT_ST"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandSTR, "RECEIPT_ST", Connection)
            Connection.Close()

            'FOR GX PCR RECORD
            Dim GX_Patient As String = "SELECT * INTO PATIENT_GX_" & cmbYear.Text.Trim & " FROM PATIENT_GX"
            Call GetConnectionString()
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, GX_Patient, "PATIENT", Connection)
            Connection.Close()
            Dim GX_Receipt As String = "SELECT * INTO RECEIPT_GX_" & cmbYear.Text.Trim & " FROM RECEIPT_GX"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, GX_Receipt, "RECEIPT", Connection)
            Connection.Close()
            Dim CommandGXP As String = "DELETE FROM PATIENT_GX"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandGXP, "PATIENT_GX", Connection)
            Connection.Close()
            Dim CommandGXR As String = "DELETE FROM RECEIPT_GX"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandGXR, "RECEIPT_GX", Connection)
            Connection.Close()

            Me.Cursor = Cursors.Default
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
