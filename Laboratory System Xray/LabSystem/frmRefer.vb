Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data

Public Class frmRefer

    Private Sub frmRefer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            gblRefer = ""
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Call Get_CP_ID()
            gblRefer = StrConv(Me.ListBoxRefer.Text.Trim, VbStrConv.ProperCase)
            Me.Close()
        End If

    End Sub

    Private Sub frmRefer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GetConnectionString()
        Try
            Connection.Close()
            Dim CommandText As String = "SELECT * FROM CollectionPoint ORDER BY CP_NAME"
            ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, CommandText, "COLLECTIONPOINT", Connection)
            Me.ListBoxRefer.DataSource = SqlDataSet
            Me.ListBoxRefer.DisplayMember = ("COLLECTIONPOINT.CP_NAME")
            Connection.Close()
        Catch EXCP As Exception
            MsgBox(EXCP.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try

    End Sub

    Private Sub Get_CP_ID()
        ExecuteSqlQuery(SqlDataAdapt, SqlDataSet, "Select * from CollectionPoint where CP_NAME = '" & StrConv(ListBoxRefer.Text.Trim.ToUpper, VbStrConv.ProperCase) & "'", "CollectionPoint", Connection)
        If SqlDataSet.Tables("CollectionPoint").Rows.Count > 0 Then
            Dim DiscReader As SqlDataReader
            DiscReader = SqlDataAdapt.SelectCommand.ExecuteReader
            While DiscReader.Read
                gblCP_ID = Convert.ToString(DiscReader.Item("CP_ID"))
            End While
            If Not DiscReader Is Nothing Then DiscReader.Close()
        End If
    End Sub

End Class