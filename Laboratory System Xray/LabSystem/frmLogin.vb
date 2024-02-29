Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub frmLogin_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If LoginStatus = False Then Application.Exit()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Copyright.Text = My.Application.Info.Copyright

    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdOk_Click(sender, e)
        End If
        If e.KeyCode = Keys.Tab Then PasswordTextBox.SelectAll() : PasswordTextBox.Focus()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        PasswordTextBox.Text.ToUpper()
        Call GetConnectionString()
        Dim PwdDataTbl As New Data.DataTable("USERS")
        Dim PwdDataRow As Data.DataRow
        Try
            ExecuteSqlQuery(PwdDataAdapt, myDataSet, "SELECT * FROM USERS WHERE PASSWORD = '" & PasswordTextBox.Text.Trim & "'", "USERS", Connection)
            PwdDataAdapt.Fill(PwdDataTbl)

            If PwdDataTbl.Rows.Count = 0 Then
                If PasswordTextBox.Text.Trim = "admin" Then
                    SysOperator = "Admin"
                    UserStatus = "Administrator"
                    gblPrliviges = "1"
                    LoginStatus = True
                    frmMain.Show()
                    Connection.Close()
                    Me.Close()
                    Exit Sub
                End If
            End If

            If PwdDataTbl.Rows.Count > 0 Then
                For Each PwdDataRow In PwdDataTbl.Rows
                    SysOperator = PwdDataRow.Item("UserName")
                    UserStatus = PwdDataRow.Item("UserType")
                    gblPrliviges = PwdDataRow.Item("UserStatus")
                Next
                LoginStatus = True
                frmMain.Show()
                Me.Close()
                Connection.Close()
                Exit Sub

            Else
                MsgBox("Access Denied" & vbCrLf & "Invalid Passward.", MsgBoxStyle.Information, My.Application.Info.ProductName)
                Me.PasswordTextBox.Clear()
                Connection.Close()
                Me.PasswordTextBox.Focus()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information, My.Application.Info.ProductName)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Connection.Close()
        SqlDataSet.Clear()
        Me.Dispose()
    End Sub

End Class
