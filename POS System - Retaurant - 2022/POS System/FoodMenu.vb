Imports System.Drawing
Imports System.Data.SqlClient

Public Class FoodMenu
    Private inputStatus As Boolean
    Private hasDecimal As Boolean
    Dim ItemName, ItemQty, ItemCode, FirstMenu(100) As String
    Dim clearDisplay As Boolean = False

#Region "Form Events"
    Private Sub frmFoodMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Call AddButtons()
        Dim MyControl As New Button
        Dim MyEvent As New System.EventArgs
        MyControl.Text = FirstMenu(0)
        'Call ClickButton(MyControl, MyEvent)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        gblOrder = False
        Me.Close()
    End Sub
#End Region

#Region "Num Pad Functions"
    Private Sub DigitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num1.Click, Num2.Click, Num3.Click, Num4.Click, Num5.Click, Num6.Click, Num7.Click, Num8.Click, Num9.Click
        If clearDisplay Then
            lblDisplay.Text = String.Empty
            clearDisplay = False
        End If
        lblDisplay.Text = lblDisplay.Text + sender.text
    End Sub


    Private Sub NumFriction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumFriction.Click
        If lblDisplay.Text.IndexOf(".") >= 0 Then
            Exit Sub
        Else
            If Len(lblDisplay.Text) = 0 Then
                lblDisplay.Text = "0."
            Else
                lblDisplay.Text = lblDisplay.Text & "."
            End If
        End If
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Dim str As String
        Dim loc As Integer
        If lblDisplay.Text.Length > 0 Then
            str = lblDisplay.Text.Chars(lblDisplay.Text.Length - 1)
            If str = "." Then
                hasDecimal = False
            End If
            loc = lblDisplay.Text.Length
            lblDisplay.Text = lblDisplay.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        lblDisplay.Text = String.Empty
        hasDecimal = False
    End Sub

    Private Sub Num0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num0.Click
        If Len(lblDisplay.Text) = 0 Or lblDisplay.Text = "0" Then
            Exit Sub
        Else
            lblDisplay.Text = lblDisplay.Text + sender.text
        End If
    End Sub

#End Region

#Region "Menu Buttons Procedure"
    Private Sub AddButtons()
        Dim I As Integer = 0
        Dim MenuGroupQuery As String = "Select distinct PROD_CATG from PRODUCTS order by PROD_CATG"
        ExecuteAdapterQuery(SqlDataAdapter, MenuGroupQuery, Connection)
        Dim GroupReader As SqlDataReader = SqlDataAdapter.SelectCommand.ExecuteReader
        If GroupReader.HasRows Then
            While GroupReader.Read
                Dim MenuGroup As New Button
                With MenuGroup
                    .Text = GroupReader.Item("PROD_CATG").ToString.ToUpper.Trim
                    .Size = New System.Drawing.Size(118, 30)
                    .Font = New Font("Tahoma", 10.0)
                    .Font = New Font(.Font, FontStyle.Bold)
                    .FlatStyle = FlatStyle.Flat
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BackColor = Color.DeepSkyBlue
                    .ForeColor = Color.White
                    .FlatAppearance.BorderColor = Color.WhiteSmoke
                    .FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue
                    .FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue
                    FirstMenu(I) = .Text.Trim
                    I += 1
                    GroupFlowPanel.Controls.Add(MenuGroup)
                    Me.ToolTip1.SetToolTip(MenuGroup, "Click to get subitems")
                    AddHandler MenuGroup.Click, AddressOf ClickButton
                End With
            End While
        End If
    End Sub

    ' Result of (Click Button) event, get the text of button
    Public Sub ClickButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim btn As Button = sender
        'Populate Submenu Items and create menu buttons in flowpanel
        Dim SubItemsQuery As String = "SELECT distinct PROD_CATG, PROD_DESC from products where PROD_CATG = N'" & btn.Text.Trim & "' ORDER BY PROD_DESC"
        ExecuteAdapterQuery(TransferAdapter, SubItemsQuery, Connection)
        Dim ItemReader As SqlDataReader = TransferAdapter.SelectCommand.ExecuteReader
        If ItemReader.HasRows Then
            'To remove all items before add new
            For i = Me.ItemFlowPanel.Controls.Count - 1 To 0 Step -1
                Me.ItemFlowPanel.Controls.RemoveAt(i)   'Here you actually provide the index!
            Next
            While ItemReader.Read
                Dim MenuItems As New Button
                With MenuItems
                    .Text = ItemReader.Item("PROD_DESC").ToString.ToUpper.Trim
                    .Size = New System.Drawing.Size(120, 30)
                    '.AutoSize = True
                    .Font = New Font("Tahoma", 8.25)
                    .BackColor = Color.DarkGreen
                    .Font = New Font(.Font, FontStyle.Bold)
                    .FlatStyle = FlatStyle.Flat
                    .TextAlign = ContentAlignment.MiddleCenter
                    .FlatAppearance.BorderColor = Color.Silver
                    .FlatAppearance.MouseDownBackColor = Color.Silver
                    .ForeColor = Color.WhiteSmoke
                    ItemFlowPanel.Controls.Add(MenuItems)
                    AddHandler MenuItems.Click, AddressOf ItemButton
                End With
            End While
        End If

    End Sub

    ' Result of (Click Button) event, get the text of button
    Public Sub ItemButton(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim btn As Button = sender
        Dim xItem As ListViewItem
        'Populate Items and add into order list
        Dim SubItemsQuery As String = "SELECT * from products where PROD_DESC = N'" & btn.Text.Trim & "' ORDER BY PROD_DESC"
        ExecuteAdapterQuery(EntryDataAdpter, SubItemsQuery, Connection)
        Dim ItemReader As SqlDataReader = EntryDataAdpter.SelectCommand.ExecuteReader
        If ItemReader.HasRows Then
            While ItemReader.Read
                If lblDisplay.Text = "" Or lblDisplay.Text = "0" Or lblDisplay.Text = "0." Then
                    ItemQty = 1
                Else
                    ItemQty = Val(lblDisplay.Text.Trim)
                End If
                ItemName = ItemReader.Item("PROD_DESC").ToString.Trim
                ItemCode = ItemReader.Item("PROD_CD").ToString.Trim
                If lvOrderList.Items.Count > 0 Then
                    xItem = lvOrderList.FindItemWithText(ItemName, False, 0, True)
                    If xItem IsNot Nothing Then xItem.SubItems(1).Text = Val(xItem.SubItems(1).Text) + Val(ItemQty.Trim) : Exit While
                End If
                With lvOrderList.Items.Add(ItemReader.Item("PROD_DESC").ToString)
                    .SubItems.Add(ItemQty.Trim)
                    .SubItems.Add(ItemCode.Trim)
                End With
            End While
        End If
        lblDisplay.Text = String.Empty
    End Sub

    Private Sub cmdOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrder.Click
        If Sale.Visible = True Then
            gblOrder = True
            'Generate Array Order List before leaving the form *// reserved
            gblArrayCount = 0
            For I = 0 To lvOrderList.Items.Count - 1
                For J = 0 To lvOrderList.Items(I).SubItems.Count - 1
                    gblDataArray(I, J) = lvOrderList.Items(I).Text
                    gblDataArray(I, J) = lvOrderList.Items(I).SubItems.Item(J).Text
                    'temp = temp & "-" & gblDataArray(I, J) // for display array pattern
                Next J
                gblArrayCount += 1
            Next I
            Me.Dispose()
        Else
            gblMessage = "Please use parcel option before settle the order."
            MsgStatus.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        'Clear all items from listview control
        lvOrderList.Items.Clear()
        'To remove all items from flowlayoutpanel before add new buttons
        For i = Me.ItemFlowPanel.Controls.Count - 1 To 0 Step -1
            Me.ItemFlowPanel.Controls.RemoveAt(i)   'Here you actually provide the index!
        Next
        GroupFlowPanel.Refresh()
    End Sub

    Private Sub lvOrderList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvOrderList.DoubleClick
        If lvOrderList.Items.Count > 0 Then
            Dim response = MsgBox("Are You Sure to remove Item (" & lvOrderList.SelectedItems(0).Text.ToString.Trim & ") ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Delete Order")
            If response = MsgBoxResult.Yes Then
                Dim i As Integer = lvOrderList.Items.IndexOf(lvOrderList.SelectedItems(0))
                lvOrderList.Items(i).Remove()
                i = 0
            End If
        End If
    End Sub
#End Region

End Class