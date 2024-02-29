Imports System.Data.SqlClient

Public Class PatientDashboard
    Dim TotalAdapter As New SqlDataAdapter
    Dim CompleteAdapter As New SqlDataAdapter
    Dim WeeklyAdapter As New SqlDataAdapter
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200

    Enum Rseverv
        Disable = 0
        Enable = 1
    End Enum

    Enum Position
        rmClose = 6
    End Enum

    Structure xPont
        Dim x, y As Int64
    End Structure

    Private Const MF_POSITION As Int32 = &H400
    Declare Function RemoveMenu Lib "user32" (ByVal menu As Int32, ByVal pos As Int32, ByVal u As Int32) As Int32
    Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Int32, ByVal rseve As Int32) As Int32
    Declare Function WindowFromPoint Lib "user32" (ByVal x As Int64, ByVal y As Int64)


    Private Sub QueryTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryTimer.Tick
        QueryTimer.Stop()
        QueryTimer.Start()
        Me.DataSet.Clear()
        dgvP_Statistics.ClearSelection()
        Dim SelectPatient As String = "SELECT * FROM PATIENT WHERE (P_DATE_SAMPLE >= CONVERT(DATETIME,'" & Format(Now, "MM/dd/yyyy") & " 00:00:00',102)) order by P_NUM"
        Execute_DatabaseTable_Query(SqlDataAdapter, SelectPatient, Connection)
        SqlDataAdapter.Fill(Me.DataSet, "PATIENT")
        Me.BindingSource.DataSource = Me.DataSet
        Me.BindingSource.DataMember = "PATIENT"
        For i = 0 To dgvP_Statistics.Rows.Count - 1
            If dgvP_Statistics.Rows(i).Cells(2).Value = "FINALIZED" Then
                dgvP_Statistics.Rows(i).DefaultCellStyle.BackColor = Color.SeaGreen
            End If
        Next
        dgvP_Statistics.ClearSelection()
        Call Record_Count()
        lblTotal.Text = gblTotCases.Trim
        Me.WeeklyDataSet.Clear()
        Dim PendingLastWeek As String = "SELECT * FROM patient WHERE p_date_sample >= DATEADD(day, -7, GetDate()) order by p_date_sample"
        Execute_DatabaseTable_Query(WeeklyAdapter, PendingLastWeek, Connection)
        WeeklyAdapter.Fill(Me.WeeklyDataSet, "PATIENT")
        Me.WeeklyBindingSource.DataSource = WeeklyDataSet
        Me.WeeklyBindingSource.DataMember = "PATIENT"
        Me.dgvPendingRpt.Refresh()
        Dim CompleteCases As String = "SELECT COUNT(P_NUM) as EXPR1 FROM PATIENT WHERE (P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(Now, "MM/dd/yyyy") & " 00:00:00',102)) and (P_STATUS = 'FINALIZED')"
        Execute_DatabaseTable_Query(CompleteAdapter, CompleteCases, Connection)
        Dim Reader As SqlDataReader = CompleteAdapter.SelectCommand.ExecuteReader
        If Reader.HasRows Then
            While Reader.Read
                lblComplete.Text = Reader.Item("EXPR1")
            End While
        End If
        Dim PendingCases As String = "SELECT COUNT(P_NUM) as EXPR1 FROM PATIENT WHERE (P_DATE_SAMPLE = CONVERT(DATETIME,'" & Format(Now, "MM/dd/yyyy") & " 00:00:00',102)) and (P_STATUS <> 'FINALIZED')"
        Execute_DatabaseTable_Query(PendingAdapter, PendingCases, Connection)
        Dim P_Reader As SqlDataReader = PendingAdapter.SelectCommand.ExecuteReader
        If P_Reader.HasRows Then
            While P_Reader.Read
                lblPending.Text = P_Reader.Item("EXPR1")
            End While
        End If
        Connection.Close()
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        QueryTimer.Interval = 54000
        QueryTimer.Start()
        UpdateProcessTimer.Interval = 54000
        UpdateProcessTimer.Start()
    End Sub

    Private Sub UpdateProcessTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateProcessTimer.Tick
        UpdateProcessTimer.Stop()
        UpdateProcessTimer.Start()
    End Sub

    Private Sub dgvP_Statistics_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvP_Statistics.CellFormatting
        If dgvP_Statistics.RowCount > 0 Then
            If dgvP_Statistics.Columns(e.ColumnIndex).Name = "colStatus" Then
                If e.Value IsNot Nothing Then
                    Select Case e.Value.ToString.ToLower
                        Case "RECEPTION"
                            With e.CellStyle
                                .BackColor = Color.IndianRed
                            End With

                        Case "FINALIZED"
                            e.CellStyle.BackColor = Color.SeaGreen
                    End Select
                End If
            End If
        End If
    End Sub
End Class