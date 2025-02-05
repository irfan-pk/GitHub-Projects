Imports System
Imports System.Web
Imports System.Net

Public Class CustomerMenu
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub OpenForm(ByVal Myform As Form)
        Me.WindowState = FormWindowState.Minimized
        Myform.MdiParent = Main
        Myform.Show()
    End Sub

    Private Sub frmCustomermenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Me.LineShape1.X2 = Me.Width - 5
        'Me.LineShape2.X2 = Me.Width - 5
        Me.Left = 10
        Me.Top = 10
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmCustomerMenu_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frmCustomerMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub frmCustomerMenu_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub cmdCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call OpenForm(Customers)
    End Sub

    Private Sub cmdPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayments.Click
        Call OpenForm(CoustomerLedger)
    End Sub

    Private Sub cmdTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTransactions.Click
        Call OpenForm(CustomerPurchases)
    End Sub

    Private Sub cmdReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReports.Click
        Call OpenForm(CustomerReports)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call OpenForm(AdjustPayment)
    End Sub

    Private Sub btnMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim SmsWebBrowser As New WebBrowser
            Dim baseurl As String = "https://sendpk.com/api/sms.php?username=923337005505&password=isha@4321&sender=Alert&mobile=923337005505&message=TestSMS"
            SmsWebBrowser.Navigate(baseurl)
            'Dim Request As HttpWebRequest = HttpWebRequest.Create(baseurl)
            'Request.Proxy = Nothing
            'Request.UserAgent = My.Application.Info.ProductName

            'Dim response As HttpWebRespose = Request.GetResponse
            'Dim ResponseStream As System.IO.Stream = response.GetResponseStream

            'Dim StreamReader As New System.IO.StreamReader(ResponseStream)
            'Dim Data As String = StreamReader.ReadToEnd
            'StreamReader.Close()

            'MsgBox(Data)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class