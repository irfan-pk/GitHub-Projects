Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Public Class frmTestCodeList

    Private Sub frmTestCodeList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.Enter Then
            Try
                Dim CommandText As String = "SELECT * FROM TESTS WHERE TNAME = '" & Trim(cmbTestName.Text) & "'"
                ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "TESTS", Connection)
                gblTestCode = SqlDataSet.Tables("TESTS").Rows(0).Item("TCODE").ToString.Trim
                Connection.Close()
            Catch EXCP As Exception
                MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub frmTestCodeList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call GetConnectionString()
        Try
            Dim CommandText As String = "SELECT * FROM TESTS ORDER BY TNAME"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "TESTS", Connection)
            cmbTestName.DataSource = SqlDataSet
            cmbTestName.DisplayMember = ("TESTS.TNAME")
            Connection.Close()
        Catch EXCP As Exception
            MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub
End Class