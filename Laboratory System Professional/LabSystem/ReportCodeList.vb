Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data

Public Class ReportCodeList
    Private Sub ReportCodeList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then gblTestCode = String.Empty : gblTestName = String.Empty : Me.Close()
        If e.KeyCode = Keys.Enter Then
            Try
                Dim CommandText As String = "SELECT * FROM TESTS WHERE TNAME = '" & Trim(cmbTestName.Text) & "'"
                ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "TESTS", Connection)
                Dim Reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
                If Reader.HasRows Then
                    While Reader.Read
                        gblTestCode = Reader.Item("TCODE").ToString.Trim
                        gblTestName = Reader.Item("TNAME").ToString.Trim
                    End While
                End If
                Connection.Close()
            Catch EXCP As Exception
                MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub ReportCodeList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gblTestCode = String.Empty
        gblTestName = String.Empty
        Call GetConnectionString()
        Try
            Dim CommandText As String = String.Empty
            CommandText = "SELECT * FROM TESTS WHERE tcatg != 'URINE' AND tcatg != 'HORMONES' AND tcatg != 'MICROBIOLOGY' AND tcatg != 'CULTURE & SENSITIVITY' and tcatg != 'HISTOPATHOLOGY'"
            ExecuteSqlQuery(SqlDataAdapter, SqlDataSet, CommandText, "TESTS", Connection)
            cmbTestName.DataSource = SqlDataSet
            cmbTestName.DisplayMember = ("TESTS.TNAME").Trim
            Connection.Close()
        Catch EXCP As Exception
            MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

End Class