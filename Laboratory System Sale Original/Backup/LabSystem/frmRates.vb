Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmRates
    Dim strSql As String = "SELECT * from TESTS ORDER BY TNAME"
    Dim TestReader As SqlDataReader
    Private Sub frmRates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        If gblPrliviges > 2 Then
            MsgBox("You are not authorized, illegal operating.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.Close()
            Exit Sub
        End If
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, strSql, "TESTS", Connection)
        TestReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While TestReader.Read
            txtTestName.Items.Add(StrConv(TestReader.Item("TNAME"), VbStrConv.Uppercase))
        End While
        If Not TestReader Is Nothing Then TestReader.Close()
        SqlDataAdapt.Dispose()
        Connection.Close()

    End Sub

    Private Sub txtTestName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTestName.SelectedIndexChanged
        Call SelectTestName()
    End Sub
    Private Sub SelectTestName()

        Dim RateReader As SqlDataReader
        Try
            Dim CommandText As String = "SELECT * FROM TESTS WHERE TNAME = '" & txtTestName.Text & "'"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "TESTS", Connection)
            RateReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While RateReader.Read
                lblSpecimen.Text = RateReader.Item("TSAMPLE")
                lblReport.Text = RateReader.Item("TREPORT")
                lblRate.Text = RateReader.Item("TRATE")
            End While
            If Not RateReader Is Nothing Then RateReader.Close()
        Catch EXCP As Exception
            MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
        SqlDataAdapt.Dispose()
        Connection.Close()

    End Sub

End Class