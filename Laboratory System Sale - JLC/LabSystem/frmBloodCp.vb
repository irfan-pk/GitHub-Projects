Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System

Public Class frmBloodCp
    Dim x As Integer = 13
    Dim y As Integer = 165
    Dim lblParameters() As Label
    Dim lblUnits() As Label
    Dim txtResult() As TextBox


    Private Sub frmBloodCp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call GetConnectionString()

        Dim i As Integer
        ReDim lblParameters(15)
        ReDim txtResult(15)
        ReDim lblUnits(15)
        For i = 0 To 15
            lblParameters(i) = New Label
            lblUnits(i) = New Label
            txtResult(i) = New TextBox
            lblParameters(i).BorderStyle = BorderStyle.Fixed3D
            txtResult(i).BorderStyle = BorderStyle.Fixed3D
            lblParameters(i).BackColor = Color.White
            lblParameters(i).ForeColor = Color.Black
            lblParameters(i).Name = "lblparameter" & i
            lblParameters(i).Text = "PARAMETERS" & i
            lblParameters(i).Width = 300
            lblParameters(i).Height = 24
            txtResult(i).Width = 100
            txtResult(i).Height = 30
            lblParameters(i).TextAlign = ContentAlignment.MiddleLeft
            Me.Controls.Add(lblParameters(i))
            Me.Controls.Add(txtResult(i))
            lblParameters(i).Location = New Point(13, 165 + 24 * i)
            txtResult(i).Location = New Point(600, 165 + 24 * i)
            lblParameters(i).BringToFront()
            txtResult(i).BringToFront()
        Next

        Dim cpReader As SqlDataReader
        ExecuteSqlQuery(SqlDataAdapt, myDataSet, "Select * from RPT_PARAM order by SORT_ORDER", "RPT_PARAM", Connection)
        cpReader = SqlDataAdapt.SelectCommand.ExecuteReader
        While cpReader.Read

        End While

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub
End Class