Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms

Public Class MainReports
    Private CurrentCulture As System.Globalization.CultureInfo
    Dim SubReportReader As SqlDataReader

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
        Connection.Close()
        Connection.Dispose()
        SqlDataAdapter.Dispose()
        SqlDataSet.Dispose()
        LoginStatus = False
        Application.Exit()
    End Sub

    Private Sub MainReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        LoginStatus = False
        Application.Exit()
    End Sub

    Private Sub MainReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Reports - " + My.Application.Info.ProductName
        Me.ToolStripStatusLabel2.Text = SysOperator.Trim
        Me.ToolStripStatusLabel6.Text = UserStatus.Trim
        If LoginStatus = True Then
            Me.ToolStripStatusLabel4.Text = "Logged On"
        End If
        'Load biochemistry reports as menu items
        Dim GetChemReports As String = "select RPTCODE from RPT_PARAM where CATEGORY = 'BIOCHEMISTRY' group by rptcode order by rptcode"
        Execute_DatabaseTable_Query(SqlDataAdapter, GetChemReports, Connection)
        Dim ChemReportReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If ChemReportReader.HasRows Then
            While ChemReportReader.Read
                Dim SubItems As New ToolStripMenuItem
                SubItems.Text = ChemReportReader.Item("rptcode").ToString.Trim
                BioChemistryMenuItem.DropDownItems.Add(SubItems)
                AddHandler SubItems.Click, AddressOf ChemistrySubitem
            End While
            If ChemReportReader Is Nothing Then ChemReportReader.Close()
        End If
        'Load hormones reports as menu items
        Dim GetHormones As String = "select RPTCODE from RPT_PARAM where CATEGORY = 'HORMONES' group by rptcode order by rptcode"
        Execute_DatabaseTable_Query(SqlDataAdapter, GetHormones, Connection)
        Dim HormonesReportReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If HormonesReportReader.HasRows Then
            While HormonesReportReader.Read
                Dim SubItems As New ToolStripMenuItem
                SubItems.Text = HormonesReportReader.Item("rptcode").ToString.Trim
                HormonesMenuItem.DropDownItems.Add(SubItems)
                AddHandler SubItems.Click, AddressOf HormonesSubitem
            End While
            If HormonesReportReader Is Nothing Then HormonesReportReader.Close()
        End If
        'Load Microscopics reports as menu items
        Dim GetMicroscopic As String = "select RPTCODE from RPT_PARAM where CATEGORY = 'MICROSCOPIC' group by rptcode order by rptcode"
        Execute_DatabaseTable_Query(SqlDataAdapter, GetMicroscopic, Connection)
        Dim MicroscopeReportReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If MicroscopeReportReader.HasRows Then
            While MicroscopeReportReader.Read
                Dim SubItems As New ToolStripMenuItem
                SubItems.Text = MicroscopeReportReader.Item("rptcode").ToString.Trim
                MicroscopeToolStripMenuItem.DropDownItems.Add(SubItems)
                AddHandler SubItems.Click, AddressOf MicroscopeSubitem
            End While
            If MicroscopeReportReader Is Nothing Then MicroscopeReportReader.Close()
        End If

        'Load Histopathology reports as menu items
        Dim GetHistopathology As String = "select RPTCODE from RPT_PARAM where CATEGORY = 'HISTOPATHOLOGY' group by rptcode order by rptcode"
        Execute_DatabaseTable_Query(SqlDataAdapter, GetHistopathology, Connection)
        Dim HistoReportReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If HistoReportReader.HasRows Then
            While HistoReportReader.Read
                Dim SubItems As New ToolStripMenuItem
                SubItems.Text = HistoReportReader.Item("rptcode").ToString.Trim
                HistoMenuItem.DropDownItems.Add(SubItems)
                AddHandler SubItems.Click, AddressOf HistoSubitem
            End While
            If HistoReportReader Is Nothing Then HistoReportReader.Close()
        End If

    End Sub

    Private Sub ChemistrySubitem(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim myReport As ToolStripMenuItem = sender
        gblSelectRpt = myReport.Text.Trim
        Dim MyQuery As String = "select FILECODE,RPTCODE,TSTCODE from rpt_param where RPTCODE = '" & gblSelectRpt.Trim & "' group by FILECODE, RPTCODE, TSTCODE"
        Execute_DatabaseTable_Query(SqlDataAdapter, MyQuery, Connection)
        Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                gblPrnReport = reader.Item("FILECODE").ToString
                gblSelectRpt = reader.Item("RPTCODE").ToString
                gblTestCode = reader.Item("TSTCODE").ToString
            End While
            If reader Is Nothing Then reader.Close()
        End If
        If gblPrnReport = String.Empty Then
            MsgBox("Invalid Report Name", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        End If
        If gblSelectRpt.IndexOf("CHEMISTRY") > -1 Then
            Load_MyForm(Me, BioChemistry)
        Else
            Load_MyForm(Me, BioChemFull)
        End If
    End Sub

    Private Sub HormonesSubitem(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim myReport As ToolStripMenuItem = sender
        gblSelectRpt = myReport.Text.Trim
        Dim MyQuery As String = "select FILECODE,RPTCODE,TSTCODE from rpt_param where RPTCODE = '" & gblSelectRpt.Trim & "' group by FILECODE, RPTCODE, TSTCODE"
        Execute_DatabaseTable_Query(SqlDataAdapter, MyQuery, Connection)
        Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                gblPrnReport = reader.Item("FILECODE").ToString
                gblSelectRpt = reader.Item("RPTCODE").ToString
            End While
            If reader Is Nothing Then reader.Close()
        End If
        If gblPrnReport = String.Empty Then
            MsgBox("Invalid Report Name", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        End If
        Load_MyForm(Me, Hormones)
    End Sub

    Private Sub MicroscopeSubitem(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim myReport As ToolStripMenuItem = sender
        gblSelectRpt = myReport.Text.Trim
        Dim MyQuery As String = "select FILECODE,RPTCODE,TSTCODE from rpt_param where RPTCODE = '" & gblSelectRpt.Trim & "' group by FILECODE, RPTCODE, TSTCODE"
        Execute_DatabaseTable_Query(SqlDataAdapter, MyQuery, Connection)
        Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                gblPrnReport = reader.Item("FILECODE").ToString
                gblSelectRpt = reader.Item("RPTCODE").ToString
            End While
            If reader Is Nothing Then reader.Close()
        End If
        If gblPrnReport = String.Empty Then
            MsgBox("Invalid Report Name", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        End If
        Load_MyForm(Me, Microscopic)
    End Sub

    Private Sub HistoSubitem(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim myReport As ToolStripMenuItem = sender
        gblSelectRpt = myReport.Text.Trim
        Dim MyQuery As String = "select FILECODE,RPTCODE,TSTCODE from rpt_param where RPTCODE = '" & gblSelectRpt.Trim & "' group by FILECODE, RPTCODE, TSTCODE"
        Execute_DatabaseTable_Query(SqlDataAdapter, MyQuery, Connection)
        Dim reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                gblPrnReport = reader.Item("FILECODE").ToString
                gblSelectRpt = reader.Item("RPTCODE").ToString
            End While
            If reader Is Nothing Then reader.Close()
        End If
        If gblPrnReport = String.Empty Then
            MsgBox("Invalid Report Name", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Exit Sub
        End If
        Load_MyForm(Me, UrineDr)
    End Sub

    Private Sub RemarksMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksMenuItem.Click
        Load_MyForm(Me, ReportRemarksList)
    End Sub

    Private Sub PatientNameCorrectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientNameCorrectionMenuItem.Click
        Load_MyForm(Me, NameCorrection)
    End Sub

    Private Sub BiopsyMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiopsyMenuItem.Click
        Load_MyForm(Me, BIOPSY)
    End Sub

    Private Sub CytologyMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CytologyMenuItem.Click
        Load_MyForm(Me, CYTOLOGY)
    End Sub

    Private Sub BloodCpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BloodCpToolStripMenuItem.Click
        Load_MyForm(Me, BloodCp)
    End Sub

    Private Sub UrineDRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UrineDRToolStripMenuItem.Click
        gblSelectRpt = "URINEDR"
        Load_MyForm(Me, UrineDr)
    End Sub

    Private Sub MalariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'gblSelectRpt = MalariaToolStripMenuItem.Text
        Load_MyForm(Me, Microscopic)
    End Sub

    Private Sub UrinePregnancyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UrinePregnancyToolStripMenuItem.Click
        gblSelectRpt = "PREGNANCY"
        Load_MyForm(Me, BioChemFull)
    End Sub

    Private Sub ToolStripMenuItemMisc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gblSelectRpt = "MISCELLANEOUS"
        Load_MyForm(Me, Miscellaneous)
    End Sub

    Private Sub CultureSensitivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CultureSensitivityToolStripMenuItem.Click
        gblSelectRpt = "CULTURE"
        Load_MyForm(Me, Microbiology)
    End Sub

    Private Sub NoGrowthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoGrowthToolStripMenuItem.Click
        gblSelectRpt = "CULTURE"
        Load_MyForm(Me, NoGrowth)
    End Sub

    Private Sub MiscellaneousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscellaneousToolStripMenuItem.Click
        gblSelectRpt = "MISCELLANEOUS"
        Load_MyForm(Me, Miscellaneous)
    End Sub

    Private Sub BoneMarrowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoneMarrowToolStripMenuItem.Click
        Load_MyForm(Me, Bonemarrow)
    End Sub

    Private Sub AboutMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMenuItem.Click
        Load_MyForm(Me, AboutBox)
    End Sub

    Private Sub PrintReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportsToolStripMenuItem.Click
        Load_MyForm(Me, PrintReport)
    End Sub

    Private Sub DonorProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonorProfileToolStripMenuItem.Click
        Load_MyForm(Me, DonorReport)
    End Sub

    Private Sub OpenOldReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenOldReportsToolStripMenuItem.Click
        OpenFileDialog.Filter = "Office Files|*.doc;*.docx"
        If OpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            System.Diagnostics.Process.Start(OpenFileDialog.FileName)
        End If
    End Sub
End Class
