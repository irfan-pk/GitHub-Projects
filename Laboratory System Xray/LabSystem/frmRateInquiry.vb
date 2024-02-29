Imports System.Data.SqlClient

Public Class frmRateInquiry

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        
        If e.KeyCode = Keys.Enter Then
            Try
                ' Check if txtCode Blank or Null
                If Len(txtCode.Text) = 0 Then MsgBox("PLEASER ENTER TEST CODE.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Me.ProcessTabKey(False) : Exit Sub

                ' Selecting Test Information by Given Code
                Dim strSql As String = "Select * from TESTS WHERE TCODE = '" & txtCode.Text.Trim & "'"
                strTname = ""
                strTrate = ""
                Dim increement As Integer = 0
                ' Get Test Information into Variables
                Try
                    Dim RateItem As New ListViewItem
                    Dim TestReader As SqlDataReader
                    ExecuteSqlQuery(EntryDataAdpt, EntryDataSet, strSql, "TESTS", Connection)
                    TestReader = EntryDataAdpt.SelectCommand.ExecuteReader
                    While TestReader.Read
                        strTname = Convert.ToString(TestReader.Item("tname")).ToUpper.Trim
                        strTrate = Convert.ToString(TestReader.Item("trate"))
                    End While
                    If Not TestReader Is Nothing Then TestReader.Close()
                    EntryDataAdpt.Dispose()
                    If strTname.Trim = "" Then MsgBox("Invalid Test Code. Please Press F2 to select correct test code.", MsgBoxStyle.Information, My.Application.Info.ProductName) : Exit Sub

                    ' Adding Values into List View Control
                    RateItem.Text = strTname.ToUpper.Trim
                    RateItem.SubItems.Add(Val(strTrate.Trim))
                    lblRate.Text = Val(lblRate.Text) + Val(strTrate.Trim)
                    RateListView.Items.Add(RateItem)
                    Connection.Close()
                    txtCode.Clear()

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                    EntryDataSet = Nothing
                End Try
                txtCode.Focus()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
                Me.Close()
            End Try

        End If
        txtCode.Focus()
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyCode = Keys.F2 Then
            gblTestCode = ""
            frmTestCodeList.ShowDialog(Me)
            If Len(gblTestCode) > 0 Then txtCode.Text = gblTestCode.ToUpper
            Me.ProcessTabKey(False)
            txtCode_KeyDown(sender, e)
        End If
    End Sub

    Private Sub frmRateInquiry_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F2 Then
            gblTestCode = ""
            frmTestCodeList.ShowDialog(Me)
            If Len(gblTestCode) > 0 Then txtCode.Text = gblTestCode.ToUpper
            Me.ProcessTabKey(False)
            txtCode_KeyDown(sender, e)
        End If
    End Sub

    Private Sub frmRateInquiry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RateListView.Items.Clear()
        lblRate.Text = "00"
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub
End Class