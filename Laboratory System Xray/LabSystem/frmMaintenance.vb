Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class frmMaintenance

    Private Sub frmMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim G As Graphics
        Dim rect As Rectangle
        G = GetGraphicsObject()
        rect = New Rectangle(0, 0, Me.Width - 3, Me.Height - 3)

        Dim lgb As New LinearGradientBrush(rect, Color.AliceBlue, Color.BurlyWood, LinearGradientMode.Vertical)
        G.FillRectangle(lgb, 0, 0, Me.Width - 3, Me.Height - 3)
    End Sub
    Function GetGraphicsObject() As Graphics
        Dim bmp As Bitmap
        bmp = New Bitmap(Me.Width, Me.Height)
        Dim G As Graphics
        Me.BackgroundImage = bmp
        G = Graphics.FromImage(bmp)
        Return G
    End Function
End Class