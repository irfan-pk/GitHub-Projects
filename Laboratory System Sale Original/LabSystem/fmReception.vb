Imports System.Drawing.Drawing2D
Imports System.Drawing
Public Class frmReception
    
    Private Sub pbPatientFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPatientFile.Click
        frmPatient.Show()
    End Sub

    Private Sub pbPatientFile_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPatientFile.MouseEnter
        pbPatientFile.BorderStyle = BorderStyle.FixedSingle
        lblPatient.Font = New System.Drawing.Font(lblPatient.Font, FontStyle.Bold)
        pbPatientFile.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbPatientFile_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPatientFile.MouseHover
        pbPatientFile.BorderStyle = BorderStyle.FixedSingle
        lblPatient.Font = New System.Drawing.Font(lblPatient.Font, FontStyle.Bold)
        pbPatientFile.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbPatientFile_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPatientFile.MouseLeave
        pbPatientFile.BackColor = Color.Transparent
        lblPatient.Font = New System.Drawing.Font(lblPatient.Font, FontStyle.Regular)
        pbPatientFile.BorderStyle = BorderStyle.None
    End Sub

    Private Sub frmReception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Operator = " & SysOperator

        Dim G As Graphics
        Dim Brush As SolidBrush
        Dim rect As Rectangle

        G = GetGraphicsObject()
        rect = New Rectangle(0, 0, Me.Width - 3, Me.Height - 3)

        Dim lgb As New LinearGradientBrush(rect, Color.AliceBlue, Color.BurlyWood, LinearGradientMode.Vertical)
        G.FillRectangle(lgb, 0, 0, Me.Width - 3, Me.Height - 3)
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        Dim drawFont As Font
        Dim drawString As String = My.Application.Info.ProductName
        Brush = New SolidBrush(Color.FromArgb(255, 0, 0, 255))
        drawFont = New Font("Times New Roman", 32, Drawing.FontStyle.Bold)

        Brush.Color = Color.FromArgb(255, 128, 64, 255)
        G.DrawString(drawString, drawFont, Brush, 18, 20)
        Brush.Color = Color.FromArgb(128, 255, 128, 64)
        G.DrawString(drawString, drawFont, Brush, 21, 23)
        Me.Invalidate()

    End Sub
    Function GetGraphicsObject() As Graphics
        Dim bmp As Bitmap
        bmp = New Bitmap(Me.Width, Me.Height)
        Dim G As Graphics
        Me.BackgroundImage = bmp
        G = Graphics.FromImage(bmp)
        Return G
    End Function

    Private Sub pbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbExit.Click
        Application.Exit()
        Me.Dispose()
        Connection.Dispose()
        SqlDataAdapt.Dispose()
        SqlDataSet.Dispose()
    End Sub

    Private Sub pbStatements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbStatements.Click
        frmDailyStat.Show()
    End Sub

    Private Sub pbStatements_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStatements.MouseEnter
        pbStatements.BorderStyle = BorderStyle.FixedSingle
        lblStatements.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Bold)
        pbStatements.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbStatements_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStatements.MouseHover
        pbStatements.BorderStyle = BorderStyle.FixedSingle
        lblStatements.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Bold)
        pbStatements.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbStatements_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbStatements.MouseLeave
        pbStatements.BorderStyle = BorderStyle.None
        lblStatements.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Regular)
        pbStatements.BackColor = Color.Transparent
    End Sub

    Private Sub pbExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbExit.MouseEnter
        pbExit.BorderStyle = BorderStyle.FixedSingle
        lblExit.Font = New System.Drawing.Font(lblExit.Font, FontStyle.Bold)
        pbExit.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbExit.MouseHover
        pbExit.BorderStyle = BorderStyle.FixedSingle
        lblExit.Font = New System.Drawing.Font(lblExit.Font, FontStyle.Bold)
        pbExit.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbExit.MouseLeave
        pbExit.BorderStyle = BorderStyle.None
        lblExit.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Regular)
        pbExit.BackColor = Color.Transparent
    End Sub

    Private Sub pbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPrint.Click
        frmPrintSlip.Show()
    End Sub

    Private Sub pbPrint_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPrint.MouseEnter
        pbPrint.BorderStyle = BorderStyle.FixedSingle
        lblPrint.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Bold)
        pbPrint.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbPrint_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPrint.MouseHover
        pbPrint.BorderStyle = BorderStyle.FixedSingle
        lblPrint.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Bold)
        pbPrint.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbPrint_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPrint.MouseLeave
        pbPrint.BorderStyle = BorderStyle.None
        lblPrint.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Regular)
        pbPrint.BackColor = Color.Transparent
    End Sub

    Private Sub pbRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRates.Click
        frmRates.Show()
    End Sub

    Private Sub pbRates_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbRates.MouseEnter
        pbRates.BorderStyle = BorderStyle.FixedSingle
        lblRate.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Bold)
        pbRates.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbRates_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbRates.MouseHover
        pbRates.BorderStyle = BorderStyle.FixedSingle
        lblRate.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Bold)
        pbRates.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbRates_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbRates.MouseLeave
        pbRates.BorderStyle = BorderStyle.None
        lblRate.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Regular)
        pbRates.BackColor = Color.Transparent
    End Sub

    Private Sub pbLogon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbLogon.Click
        If LoginStatus = True Then LoginStatus = False
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub pbLogon_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbLogon.MouseEnter
        pbLogon.BorderStyle = BorderStyle.FixedSingle
        lblLog.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Bold)
        pbLogon.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbLogon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbLogon.MouseHover
        pbLogon.BorderStyle = BorderStyle.FixedSingle
        lblLog.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Bold)
        pbLogon.BackColor = Color.AliceBlue
    End Sub

    Private Sub pbLogon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbLogon.MouseLeave
        pbLogon.BorderStyle = BorderStyle.None
        lblLog.Font = New System.Drawing.Font(lblStatements.Font, FontStyle.Regular)
        pbLogon.BackColor = Color.Transparent
    End Sub

    Private Sub lblPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPatient.Click
        pbPatientFile_Click(sender, e)
    End Sub

    Private Sub lblPatient_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPatient.MouseEnter
        'pbPatientFile_MouseEnter(sender, e)
    End Sub

    Private Sub lblPatient_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPatient.MouseHover
        'pbPatientFile_MouseHover(sender, e)
    End Sub

    Private Sub lblPatient_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPatient.MouseLeave
        'pbPatientFile_MouseLeave(sender, e)
    End Sub

    Private Sub lblStatements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatements.Click
        pbStatements_Click(sender, e)
    End Sub

    Private Sub lblStatements_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStatements.MouseEnter
        'pbStatements_MouseEnter(sender, e)
    End Sub

    Private Sub lblStatements_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStatements.MouseHover
        'pbStatements_MouseHover(sender, e)
    End Sub

    Private Sub lblStatements_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStatements.MouseLeave
        'pbStatements_MouseLeave(sender, e)
    End Sub

    Private Sub lblPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrint.Click
        pbPrint_Click(sender, e)
    End Sub

    Private Sub lblPrint_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPrint.MouseEnter
        'pbPrint_MouseEnter(sender, e)
    End Sub

    Private Sub lblPrint_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPrint.MouseHover
        'pbPrint_MouseHover(sender, e)
    End Sub

    Private Sub lblPrint_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPrint.MouseLeave
        'pbPrint_MouseLeave(sender, e)
    End Sub

    Private Sub lblRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRate.Click
        pbRates_Click(sender, e)
    End Sub

    Private Sub lblRate_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRate.MouseEnter
        'pbRates_MouseEnter(sender, e)
    End Sub

    Private Sub lblRate_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRate.MouseHover
        'pbRates_MouseHover(sender, e)
    End Sub

    Private Sub lblRate_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRate.MouseLeave
        'pbRates_MouseLeave(sender, e)
    End Sub

    Private Sub lblLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLog.Click
        pbLogon_Click(sender, e)
    End Sub

    Private Sub lblLog_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLog.MouseEnter
        'pbLogon_MouseEnter(sender, e)
    End Sub

    Private Sub lblLog_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLog.MouseHover
        'pbLogon_MouseHover(sender, e)
    End Sub

    Private Sub lblLog_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLog.MouseLeave
        'pbLogon_MouseLeave(sender, e)
    End Sub

    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        pbExit_Click(sender, e)
    End Sub

    Private Sub lblExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExit.MouseEnter
        'pbExit_MouseEnter(sender, e)
    End Sub

    Private Sub lblExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExit.MouseHover
        pbExit_MouseHover(sender, e)
    End Sub

    Private Sub lblExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExit.MouseLeave
        'pbExit_MouseLeave(sender, e)
    End Sub

End Class