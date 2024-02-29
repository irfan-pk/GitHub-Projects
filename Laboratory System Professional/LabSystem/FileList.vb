Imports System.IO

Public Class FileList

    Private Sub FileList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim currentpath As String = Directory.GetCurrentDirectory()
        Dim Di As New DirectoryInfo(currentpath & "\Pathology\")
        Dim files As FileInfo() = Di.GetFiles("*.rpt")
        Dim fi As FileInfo

        lboxFileName.Items.Clear()
        For Each fi In files
            lboxFileName.Items.Add(fi.Name)
        Next

    End Sub

    Private Sub lboxFileCode_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lboxFileName.DoubleClick
        gblFileCode = lboxFileName.SelectedItem.ToString
        Me.Close()
    End Sub

    Private Sub lboxFileCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lboxFileName.KeyDown
        If e.KeyCode = Keys.Enter Then
            gblFileCode = lboxFileName.SelectedItem.ToString
            Me.Close()
        End If
    End Sub
End Class