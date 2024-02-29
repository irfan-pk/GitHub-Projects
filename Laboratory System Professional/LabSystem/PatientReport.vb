Imports System.IO
Imports System.Data.SqlClient

Public Class PatientReport
    Private inputStatus As Boolean
    Private hasDecimal As Boolean
    Dim ItemName, ItemQty, ItemCode, FirstMenu(100) As String
    Dim clearDisplay As Boolean = False

#Region "Report Labels Procedure"
    Private Sub AddReportLabels()
        Dim I As Integer = 0
        Dim ReportGroupQuery As String = "Select distinct tname from RECEIPT where tcaseno = " & Val(txtPatientID.Text.Trim) & " order by tname"
        Execute_DatabaseTable_Query(SqlDataAdapter, ReportGroupQuery, Connection)
        Dim GroupReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GroupReader.HasRows Then
            While GroupReader.Read
                Dim LabelGroup As New Label
                With LabelGroup
                    .Text = GroupReader.Item("tname").ToString.ToUpper.Trim
                    .Size = New System.Drawing.Size(233, 30)
                    .Font = New Font("Tahoma", 10.0)
                    '.Font = New Font(.Font, FontStyle.Bold)
                    .FlatStyle = FlatStyle.Flat
                    .TextAlign = ContentAlignment.MiddleLeft
                    '.BackColor = Color.DeepSkyBlue
                    .ForeColor = Color.Black
                    FirstMenu(I) = .Text.Trim
                    I += 1
                    ReportFlowLayout.Controls.Add(LabelGroup)
                    'AddHandler MenuGroup.Click, AddressOf ClickButton
                End With
            End While
        End If
    End Sub

    ' Result of (Click Button) event, get the text of button
    Public Sub ClickButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim btn As Button = sender
        'Populate Submenu Items and create menu buttons in flowpanel
        'Dim SubItemsQuery As String = "SELECT distinct PROD_CATG, PROD_DESC from products where PROD_CATG = N'" & btn.Text.Trim & "' ORDER BY PROD_DESC"
        'ExecuteAdapterQuery(TransferAdapter, SubItemsQuery, Connection)
        'Dim ItemReader As SqlDataReader = TransferAdapter.SelectCommand.ExecuteReader
        'If ItemReader.HasRows Then
        '    'To remove all items before add new
        '    For i = Me.ItemFlowPanel.Controls.Count - 1 To 0 Step -1
        '        Me.ItemFlowPanel.Controls.RemoveAt(i)   'Here you actually provide the index!
        '    Next
        '    While ItemReader.Read
        '        Dim MenuItems As New Button
        '        With MenuItems
        '            .Text = ItemReader.Item("PROD_DESC").ToString.ToUpper.Trim
        '            .Size = New System.Drawing.Size(120, 30)
        '            '.AutoSize = True
        '            .Font = New Font("Tahoma", 8.25)
        '            .BackColor = Color.DarkGreen
        '            .Font = New Font(.Font, FontStyle.Bold)
        '            .FlatStyle = FlatStyle.Flat
        '            .TextAlign = ContentAlignment.MiddleCenter
        '            .FlatAppearance.BorderColor = Color.Silver
        '            .FlatAppearance.MouseDownBackColor = Color.Silver
        '            .ForeColor = Color.WhiteSmoke
        '            ItemFlowPanel.Controls.Add(MenuItems)
        '            AddHandler MenuItems.Click, AddressOf ItemButton
        '        End With
        '    End While
        'End If

    End Sub

    '' Result of (Click Button) event, get the text of button
    'Public Sub ItemButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
    '    Dim btn As Button = sender
    '    Dim xItem As ListViewItem
    '    'Populate Items and add into order list
    '    Dim SubItemsQuery As String = "SELECT * from products where PROD_DESC = N'" & btn.Text.Trim & "' ORDER BY PROD_DESC"
    '    ExecuteAdapterQuery(EntryDataAdpter, SubItemsQuery, Connection)
    '    Dim ItemReader As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
    '    If ItemReader.HasRows Then
    '        While ItemReader.Read
    '            If lblDisplay.Text = "" Or lblDisplay.Text = "0" Or lblDisplay.Text = "0." Then
    '                ItemQty = 1
    '            Else
    '                ItemQty = Val(lblDisplay.Text.Trim)
    '            End If
    '            ItemName = ItemReader.Item("PROD_DESC").ToString.Trim
    '            ItemCode = ItemReader.Item("PROD_CD").ToString.Trim
    '            If lvOrderList.Items.Count > 0 Then
    '                xItem = lvOrderList.FindItemWithText(ItemName, False, 0, True)
    '                If xItem IsNot Nothing Then xItem.SubItems(1).Text = Val(xItem.SubItems(1).Text) + Val(ItemQty.Trim) : Exit While
    '            End If
    '            With lvOrderList.Items.Add(ItemReader.Item("PROD_DESC").ToString)
    '                .SubItems.Add(ItemQty.Trim)
    '                .SubItems.Add(ItemCode.Trim)
    '            End With
    '        End While
    '    End If
    '    lblDisplay.Text = String.Empty
    'End Sub

    'Private Sub cmdOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrder.Click
    '    If Sale.Visible = True Then
    '        gblOrder = True
    '        'Generate Array Order List before leaving the form *// reserved
    '        gblArrayCount = 0
    '        For I = 0 To lvOrderList.Items.Count - 1
    '            For J = 0 To lvOrderList.Items(I).SubItems.Count - 1
    '                gblDataArray(I, J) = lvOrderList.Items(I).Text
    '                gblDataArray(I, J) = lvOrderList.Items(I).SubItems.Item(J).Text
    '                'temp = temp & "-" & gblDataArray(I, J) // for display array pattern
    '            Next J
    '            gblArrayCount += 1
    '        Next I
    '        Me.Dispose()
    '    Else
    '        gblMessage = "Please load parcel form before settle the order."
    '        MsgStatus.ShowDialog(Me)
    '    End If
    'End Sub

    'Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
    '    'Clear all items from listview control
    '    lvOrderList.Items.Clear()
    '    'To remove all items from flowlayoutpanel before add new buttons
    '    For i = Me.ItemFlowPanel.Controls.Count - 1 To 0 Step -1
    '        Me.ItemFlowPanel.Controls.RemoveAt(i)   'Here you actually provide the index!
    '    Next
    '    GroupFlowPanel.Refresh()
    'End Sub

    'Private Sub lvOrderList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvOrderList.DoubleClick
    '    If lvOrderList.Items.Count > 0 Then
    '        Dim response = MsgBox("Are You Sure to remove Item (" & lvOrderList.SelectedItems(0).Text.ToString.Trim & ") ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Delete Order")
    '        If response = MsgBoxResult.Yes Then
    '            Dim i As Integer = lvOrderList.Items.IndexOf(lvOrderList.SelectedItems(0))
    '            lvOrderList.Items(i).Remove()
    '            i = 0
    '        End If
    '    End If
    'End Sub
#End Region

    Private Sub txtPatientID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter And txtPatientID.Text <> "" Then
            txtPatientID.ReadOnly = True
            Call AddReportLabels()
            Call Patient_Data()
        End If
    End Sub

    Private Sub frmPatientReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetConnectionString()
        Dim MyControl As New Button
        Dim MyEvent As New System.EventArgs
        MyControl.Text = FirstMenu(0)
        Dim currentpath As String = Directory.GetCurrentDirectory()
        Dim Di As New DirectoryInfo(currentpath & "\Pathology\")
        Dim files As FileInfo() = Di.GetFiles("*.rpt")
        Dim fi As FileInfo

        ReportsListView.Items.Clear()
        For Each fi In files
            ReportsListView.Items.Add(fi.Name, 0)
        Next
    End Sub

    Private Sub Patient_Data()
        Dim patient_info As String = "select * from patient where p_num = " & Val(txtPatientID.Text.Trim)
        Execute_DatabaseTable_Query(SqlDataAdapter, patient_info, Connection)
        Dim patinet_reader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If patinet_reader.HasRows Then
            While patinet_reader.Read
                txtName.Text = patinet_reader.Item("p_name").ToString
                txtAge.Text = patinet_reader.Item("p_age").ToString
                txtGender.Text = patinet_reader.Item("p_sex").ToString
                txtConsultant.Text = patinet_reader.Item("p_ref_by").ToString
                txtHospital.Text = patinet_reader.Item("p_refer_2").ToString
                txtDate.Text = Format(Now, "dd/MMM/yyyy")
            End While
            If patinet_reader Is Nothing Then patinet_reader.Close()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReportsListView.Clear()
        Me.Close()
    End Sub

End Class