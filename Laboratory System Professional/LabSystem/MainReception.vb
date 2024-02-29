Imports System.IO
Imports System.Windows.Forms

Public Class MainReception
    Const HOUR_IN_MS_INTERVAL = 90000
    Private CurrentCulture As System.Globalization.CultureInfo

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Connection.Dispose()
        SqlDataAdapter.Dispose()
        SqlDataSet.Dispose()
        'Setting culture back to its original settings      
        System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCulture
        LoginStatus = False
        If UserStatus = "OPERATOR" Then
            Connection.Close()
            Application.Exit()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub MainReception_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        LoginStatus = False
        Application.Exit()
    End Sub

    Private Sub MainReception_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
    End Sub

    Private Sub frmMainReception_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateTimer.Stop()
        UpdateTimer.Start()
        'To change the culture of system date
        Dim tmpCurrentCulture As System.Globalization.CultureInfo
        tmpCurrentCulture = New System.Globalization.CultureInfo("en-US")

        'Culture is set back to its original value when form closes 
        CurrentCulture = System.Threading.Thread.CurrentThread.CurrentCulture

        tmpCurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = tmpCurrentCulture
        Me.Text = "Reception - " + My.Application.Info.ProductName
        Me.ToolStripStatusLabel2.Text = SysOperator.Trim
        Me.ToolStripStatusLabel6.Text = UserStatus.Trim
        Dim minutesTillNextHour = 60 - Now.Minute 'minutes until next whole hour
        Timer1.Interval = minutesTillNextHour * 60000 'set interval to that number of minutes
        Call Record_Count()
        If LoginStatus = True Then
            Me.ToolStripStatusLabel4.Text = "Logged On"
            Me.ToolStripStatusLabel8.Text = gblTotCases
        End If
    End Sub

    Private Sub NewPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewPatientToolStripMenuItem.Click
        Call Load_MyForm(Me, Patient)
    End Sub

    Private Sub CrossMatchEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrossMatchEntryToolStripMenuItem.Click
        Call Load_MyForm(Me, CrossMatch)
    End Sub

    Private Sub DonorProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonorProfileToolStripMenuItem.Click
        Call Load_MyForm(Me, DonorProfile)
    End Sub

    Private Sub PatientNameCorrectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientNameCorrectionToolStripMenuItem.Click
        Call Load_MyForm(Me, NameCorrection)
    End Sub

    Private Sub ManagePhilebotomistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagePhilebotomistToolStripMenuItem.Click
        Call Load_MyForm(Me, Visitors)
    End Sub

    Private Sub PrintPatientSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPatientSlipToolStripMenuItem.Click
        Call Load_MyForm(Me, PrintSlip)
    End Sub

    Private Sub PrintRateListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintRateListToolStripMenuItem.Click
        Call Load_MyForm(Me, PrintRateList)
    End Sub

    Private Sub RateInquiryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateInquiryToolStripMenuItem.Click
        Call Load_MyForm(Me, RateInquiry)
    End Sub

    Private Sub RateListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateListToolStripMenuItem.Click
        Call Load_MyForm(Me, TestsRates)
    End Sub

    Private Sub DailyCashSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCashSummaryToolStripMenuItem.Click
        Call Load_MyForm(Me, DailyStat)
    End Sub

    Private Sub ViewDailyCasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDailyCasesToolStripMenuItem.Click
        Call Load_MyForm(Me, DailyCases)
    End Sub

    Private Sub CpCasesSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CpCasesSummaryToolStripMenuItem.Click
        Call Load_MyForm(Me, DocCases)
    End Sub

    Private Sub AddReferenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddReferenceToolStripMenuItem.Click
        Load_MyForm(Me, DocList)
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardToolStripMenuItem.Click
        Load_MyForm(Me, CasesDashboard)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Interval = HOUR_IN_MS_INTERVAL
        Timer1.Start()
        Call Record_Count()
        ToolStripStatusLabel8.Text = gblTotCases
    End Sub

    Private Sub PrintDuplicateReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDuplicateReportToolStripMenuItem.Click
        Load_MyForm(Me, PrintReport)
    End Sub

    Private Sub UpdateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateTimer.Tick
        UpdateTimer.Stop()
        UpdateTimer.Interval = 54000
        UpdateTimer.Start()
        Call UpdateReportStatus()
        Connection.Close()
        Call UpdatePatientStatus()
    End Sub
End Class
