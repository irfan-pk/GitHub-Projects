Imports System.IO
Imports System.Data.SqlClient

Public Class ReportsList
    Dim FirstMenu(100) As String

    Private Sub frmPathologyReports_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        Call AddButtons()
    End Sub

    Private Sub PathologyReporsList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PathologyReporsList.DoubleClick

        Dim i As Integer = PathologyReporsList.Items.IndexOf(PathologyReporsList.SelectedItems(0))
        Dim SelectFreportForm As String = "select FILECODE,FORMNAME from RPT_PARAM where RPTCODE = N'" & PathologyReporsList.Items(i).Text.Trim & "' group by FILECODE, FORMNAME"
        Execute_DatabaseTable_Query(SqlDataAdapter, SelectFreportForm, Connection)
        Dim GetReportName As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GetReportName.HasRows Then
            While GetReportName.Read
                gblSelectRpt = GetReportName.Item("FILECODE").ToString.Trim
                gblFormName = GetReportName.Item("FORMNAME").ToString.Trim
            End While
        End If

    End Sub

#Region "Group Buttons Procedure"
    Private Sub AddButtons()
        Dim I As Integer = 0
        Dim ButtonGroupQuery As String = "Select distinct CATEGORY from RPT_PARAM group by CATEGORY"
        Execute_DatabaseTable_Query(SqlDataAdapter, ButtonGroupQuery, Connection)
        Dim GroupReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GroupReader.HasRows Then
            While GroupReader.Read
                Dim GroupButton As New Button
                With GroupButton
                    .Text = GroupReader.Item("CATEGORY").ToString.ToUpper.Trim
                    .Size = New System.Drawing.Size(180, 30)
                    .Font = New Font("Tahoma", 10.0)
                    .Font = New Font(.Font, FontStyle.Bold)
                    .FlatStyle = FlatStyle.Flat
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BackColor = Color.DeepSkyBlue
                    .ForeColor = Color.White
                    .FlatAppearance.BorderColor = Color.WhiteSmoke
                    FirstMenu(I) = .Text.Trim
                    I += 1
                    FlowLayoutPanel.Controls.Add(GroupButton)
                    Me.ToolTip1.SetToolTip(GroupButton, "Click to get (" & GroupButton.Text & ") Reports")
                    AddHandler GroupButton.Click, AddressOf ClickButton
                End With
            End While
        End If
    End Sub

    ' Result of (Click Button) event, get the text of button
    Public Sub ClickButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim btn As Button = sender
        Dim ReportFiles As String = "select RPTCODE from RPT_PARAM where CATEGORY = N'" & btn.Text.Trim & "' group by RPTCODE"
        Execute_DatabaseTable_Query(SqlDataAdapter, ReportFiles, Connection)
        Dim RptFilesReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If RptFilesReader.HasRows Then
            'To remove all items before add new
            PathologyReporsList.Items.Clear()
            While RptFilesReader.Read
                Me.PathologyReporsList.Items.Add(RptFilesReader.Item("RPTCODE"), 0)
            End While
        End If

    End Sub
#End Region

End Class