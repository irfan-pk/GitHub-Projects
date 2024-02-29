VERSION 5.00
Object = "{00025600-0000-0000-C000-000000000046}#5.2#0"; "Crystl32.OCX"
Object = "{94F7E282-F78A-11D1-9587-0000B43369D3}#1.1#0"; "ARGradient.ocx"
Begin VB.Form frmWidal 
   Appearance      =   0  'Flat
   BackColor       =   &H80000001&
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   5415
   ClientLeft      =   15
   ClientTop       =   15
   ClientWidth     =   11385
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5415
   ScaleWidth      =   11385
   StartUpPosition =   1  'CenterOwner
   Begin VB.ComboBox cmbTest 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Index           =   3
      Left            =   8520
      TabIndex        =   4
      Top             =   4095
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.ComboBox cmbTest 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Index           =   2
      Left            =   8520
      TabIndex        =   3
      Top             =   3615
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.ComboBox cmbTest 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Index           =   1
      Left            =   8520
      TabIndex        =   2
      Top             =   3135
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.ComboBox cmbTest 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Index           =   0
      Left            =   8520
      TabIndex        =   1
      Top             =   2640
      Visible         =   0   'False
      Width           =   1215
   End
   Begin Crystal.CrystalReport crsReport 
      Left            =   10680
      Top             =   3960
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   348160
      WindowTitle     =   "Patient Report"
      WindowControlBox=   -1  'True
      WindowMaxButton =   -1  'True
      WindowMinButton =   -1  'True
      WindowState     =   2
      PrintFileLinesPerPage=   60
      WindowShowPrintBtn=   0   'False
      WindowShowProgressCtls=   0   'False
   End
   Begin ARGradientControl.ARGradient ARGradient3 
      Height          =   375
      Left            =   120
      Top             =   1680
      Width           =   11175
      _ExtentX        =   19711
      _ExtentY        =   661
      Color           =   16777215
      FinColor        =   14737632
      Caption         =   "PATIENT REPORT"
      ShowCaption     =   -1  'True
      ForeColor       =   -2147483630
      Alignment       =   0
      GradientSteps   =   65
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin ARGradientControl.ARGradient ARGradient1 
      Height          =   375
      Left            =   120
      Top             =   120
      Width           =   11175
      _ExtentX        =   19711
      _ExtentY        =   661
      Color           =   16777215
      FinColor        =   14737632
      Caption         =   "PATIENT INFORMATION"
      ShowCaption     =   -1  'True
      ForeColor       =   -2147483630
      Alignment       =   0
      GradientSteps   =   65
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin ARGradientControl.ARGradient ARGradient2 
      Height          =   3255
      Left            =   120
      Top             =   2040
      Width           =   2655
      _ExtentX        =   4683
      _ExtentY        =   5741
      Color           =   16777215
      FinColor        =   14737632
      Orientation     =   2
      Caption         =   "ARGradient2"
      ForeColor       =   -2147483630
      GradientSteps   =   65
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Begin VB.CommandButton cmdClose 
         Caption         =   "&Close"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   9
         Top             =   2760
         Width           =   2415
      End
      Begin VB.CommandButton cmdPrint 
         Caption         =   "&Print Report"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   8
         Top             =   2400
         Width           =   2415
      End
      Begin VB.TextBox txtLabNo 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   0
         Text            =   "54633"
         Top             =   600
         Width           =   2415
      End
      Begin VB.CommandButton cmdView 
         Caption         =   "&View Report"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   7
         Top             =   2040
         Width           =   2415
      End
      Begin VB.CommandButton cmdSave 
         Caption         =   "&Save Report"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   6
         Top             =   1680
         Width           =   2415
      End
      Begin VB.CommandButton cmdNew 
         Caption         =   "&New Report"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   5
         Top             =   1320
         Width           =   2415
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Enter Lab #"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   22
         Top             =   360
         Width           =   1215
      End
   End
   Begin VB.Label lblParameter 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "AB. (PARATYPHOID FEVER S. FLAGELLAR-B)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   345
      Index           =   3
      Left            =   4080
      TabIndex        =   26
      Top             =   4103
      Visible         =   0   'False
      Width           =   4335
   End
   Begin VB.Label lblParameter 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "AH. (PARATYPHOID FEVER S. FLAGELLAR-A)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   345
      Index           =   2
      Left            =   4080
      TabIndex        =   25
      Top             =   3623
      Visible         =   0   'False
      Width           =   4335
   End
   Begin VB.Label lblParameter 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "TH.  (TYPHOID O. FEVER S.F)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   345
      Index           =   1
      Left            =   4080
      TabIndex        =   24
      Top             =   3143
      Visible         =   0   'False
      Width           =   3495
   End
   Begin VB.Label lblParameter 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   "TO.  (TYPHOID O. SALMONELLA - D)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   345
      Index           =   0
      Left            =   4080
      TabIndex        =   23
      Top             =   2648
      Visible         =   0   'False
      Width           =   3495
   End
   Begin VB.Label lblDate 
      BackStyle       =   0  'Transparent
      Caption         =   "x"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FF80&
      Height          =   255
      Left            =   8160
      TabIndex        =   21
      Top             =   1320
      Width           =   1335
   End
   Begin VB.Label Label11 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   " DATE"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   7200
      TabIndex        =   20
      Top             =   1320
      Width           =   855
   End
   Begin VB.Label lblRefer 
      BackStyle       =   0  'Transparent
      Caption         =   "x"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FF80&
      Height          =   255
      Left            =   1800
      TabIndex        =   19
      Top             =   1320
      Width           =   4095
   End
   Begin VB.Label Label9 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   " REFERRED BY"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   240
      TabIndex        =   18
      Top             =   1320
      Width           =   1455
   End
   Begin VB.Label lblSex 
      BackStyle       =   0  'Transparent
      Caption         =   "x"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FF80&
      Height          =   255
      Left            =   8160
      TabIndex        =   17
      Top             =   960
      Width           =   1335
   End
   Begin VB.Label Label7 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   " GENDER"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   7200
      TabIndex        =   16
      Top             =   960
      Width           =   855
   End
   Begin VB.Label lblAge 
      BackStyle       =   0  'Transparent
      Caption         =   "x"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FF80&
      Height          =   255
      Left            =   8160
      TabIndex        =   15
      Top             =   600
      Width           =   1335
   End
   Begin VB.Label Label5 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   " AGE"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   7200
      TabIndex        =   14
      Top             =   600
      Width           =   855
   End
   Begin VB.Label lblName 
      BackColor       =   &H00FFFFFF&
      BackStyle       =   0  'Transparent
      Caption         =   "x"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FF80&
      Height          =   255
      Left            =   1800
      TabIndex        =   13
      Top             =   600
      Width           =   4095
   End
   Begin VB.Label Label3 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   " PATIENT NAME"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   240
      TabIndex        =   12
      Top             =   600
      Width           =   1455
   End
   Begin VB.Label lblLabNo 
      BackStyle       =   0  'Transparent
      Caption         =   "x"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0080FF80&
      Height          =   255
      Left            =   1800
      TabIndex        =   11
      Top             =   960
      Width           =   975
   End
   Begin VB.Label Label1 
      BackColor       =   &H00C0C0C0&
      BackStyle       =   0  'Transparent
      Caption         =   " LAB #"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   240
      TabIndex        =   10
      Top             =   960
      Width           =   1455
   End
End
Attribute VB_Name = "frmWidal"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim I, J, SRT As Integer
Dim RptCheck, RptCode, TstParam(3) As String
Dim NewRecord, Addition As Boolean
Public AdoPntTemp As New ADODB.Recordset
Public PatientRpt As New ADODB.Recordset
Public AdoRptName As New ADODB.Recordset
Public AdoPatient As New ADODB.Recordset

Private Sub cmdClose_Click()
    If CmdClose.Caption = "&Cancel" Then _
        CmdClose.Caption = "&Close": _
        Call EmptyTemp: _
        Exit Sub
    MakeTopmost frmWidal, False
    Unload Me
End Sub

Private Sub CmdNew_Click()
    CmdClose.Caption = "&Cancel"
    Call cmdClose_Click
    txtLabNo.Enabled = True
    txtLabNo.SetFocus
End Sub

Private Sub cmdPrint_Click()
    If NewRecord = True Then PatientReport cmdPrint.Caption Else MsgBox "Please Save Patient Report before Preview", vbInformation, "Report"
End Sub

Private Sub cmdSave_Click()

    Set AdoPatient = New ADODB.Recordset
    Set PatientRpt = New ADODB.Recordset
    Set AdoPntTemp = New ADODB.Recordset

    Check_Object AdoPatient
    With AdoPatient
    .Source = "SELECT * FROM RPT_WIDAL WHERE LABID = " & Val(Trim(lblLabNo.Caption)) & " AND FILECODE = '" & Trim(RptCode) & "' ORDER BY SORT_ID"
    .Open , RptConn, adOpenKeyset, adLockOptimistic
    If .EOF = False Then MsgBox "REPORT ALREADY PRINTED BY USER.", vbInformation, "Report": Exit Sub
        If AdoPatient.RecordCount > 0 Then AdoPatient.MoveFirst
        J = 0
        Do While J < 4
            .AddNew
            .Fields(0) = Val(lblLabNo.Caption)
            .Fields(1) = Trim(RptCode)
            .Fields(2) = Trim(TstParam(J))
            If Trim(cmbTest(J).Text) = "1/20" Then _
                    .Fields(3) = "+VE"
                                        
            If Trim(cmbTest(J).Text) = "1/40" Then _
                    .Fields(3) = "+VE": _
                    .Fields(4) = "+VE"
                    
            If Trim(cmbTest(J).Text) = "1/80" Then _
                    .Fields(3) = "+VE": _
                    .Fields(4) = "+VE": _
                    .Fields(5) = "+VE"
                    
            If Trim(cmbTest(J).Text) = "1/160" Then _
                    .Fields(3) = "+VE": _
                    .Fields(4) = "+VE": _
                    .Fields(5) = "+VE": _
                    .Fields(6) = "+VE"
                    
            If Trim(cmbTest(J).Text) = "1/320" Then _
                    .Fields(3) = "+VE": _
                    .Fields(4) = "+VE": _
                    .Fields(5) = "+VE": _
                    .Fields(6) = "+VE": _
                    .Fields(7) = "+VE"
                    
            .Fields(8) = J
            J = J + 1
            .Update
        Loop
        NewRecord = True
    End With
    
    ' SHIFT PATIENT INFORMATION FROM TEMP TABLE IF EXIST THEN SKIP
    Check_Object AdoPntTemp
    AdoPntTemp.Open "SELECT * FROM RPT_PATIENT_TEMP WHERE P_NUM = " & Val(Trim(lblLabNo.Caption)), RptConn, adOpenKeyset, adLockOptimistic
    
    Check_Object AdoPatient
    With AdoPatient
    .Source = "SELECT * FROM RPT_PATIENT WHERE P_NUM = " & Val(Trim(lblLabNo.Caption))
    .Open , RptConn, adOpenKeyset, adLockOptimistic
    If .EOF = False Then
        ' Skip
    Else
        PatientRpt.MoveFirst
        .AddNew
        .Fields(0) = Val(AdoPntTemp.Fields(0))
        .Fields(1) = Trim(AdoPntTemp.Fields(1))
        .Fields(2) = Trim(AdoPntTemp.Fields(2))
        .Fields(3) = Trim(AdoPntTemp.Fields(3))
        .Fields(4) = Trim(AdoPntTemp.Fields(4))
        .Fields(5) = Format$(AdoPntTemp.Fields(5), "DD/MM/YYYY")
        .Update
    End If
    End With
    cmdClose_Click
End Sub

Private Sub cmdView_Click()
    If NewRecord = True Then PatientReport cmdView.Caption Else MsgBox "Please Save Patient Report before Preview", vbInformation, "Report"
End Sub

Private Sub Form_Load()

    Set PatientRpt = New ADODB.Recordset
    If RptConn.State = 1 Then RptConn.Close
    RptConn.ConnectionString = RptProvider
    RptConn.Open
    Call EmptyTemp
    frmWidal.BackColor = &H80000001
    NewRecord = False
    RptCode = "WIDAL"
    TstParam(0) = "TO"
    TstParam(1) = "TH"
    TstParam(2) = "AH"
    TstParam(3) = "BH"
    SetTrans Me.hwnd, 210
    
End Sub

Private Sub txtLabNo_KeyPress(KeyAscii As Integer)

If KeyAscii = 13 Then
    Set AdoPatient = New ADODB.Recordset
    Set AdoPntTemp = New ADODB.Recordset
    With AdoPatient
        .Source = "SELECT * FROM PATIENT WHERE P_NUM = " & Val(txtLabNo.Text)
        .Open , UserConn, adOpenKeyset, adLockOptimistic
        Check_Object AdoPntTemp
        AdoPntTemp.Source = "SELECT * FROM RPT_PATIENT_TEMP"
        AdoPntTemp.Open , RptConn, adOpenKeyset, adLockOptimistic
        If .EOF = False Then
            CmdClose.Caption = "&Cancel"
            For I = 0 To 3
                FillComboBox cmbTest(I)
            Next I
            For I = 0 To 3
                lblParameter(I).Visible = True
                cmbTest(I).Visible = True
            Next I
            lblName.Caption = Trim(.Fields("P_NAME"))
            lblAge.Caption = .Fields("P_AGE")
            lblSex.Caption = Trim(.Fields("P_SEX"))
            lblLabNo.Caption = Val(.Fields("P_NUM"))
            lblDate.Caption = Format$(.Fields("P_DATE_SAMPLE"), "DD/MM/YYYY")
            lblRefer.Caption = Trim(.Fields("P_REF_BY"))
            ' RECORD SHIFT TO TEMPORARY DATABASE
            AdoPntTemp.AddNew
            AdoPntTemp.Fields(0) = Val(.Fields("P_NUM"))
            AdoPntTemp.Fields(1) = Trim(.Fields("P_NAME"))
            AdoPntTemp.Fields(2) = .Fields("P_AGE")
            AdoPntTemp.Fields(3) = Trim(.Fields("P_SEX"))
            AdoPntTemp.Fields(4) = Trim(.Fields("P_REF_BY"))
            AdoPntTemp.Fields(5) = Format$(.Fields("P_DATE_SAMPLE"), "DD/MM/YYYY")
            AdoPntTemp.Update
            txtLabNo.Enabled = False
            Exit Sub
        Else
            MsgBox "INVALID LAB NUMBER, PLEASE GIVE CORRECT LAB NUMBER.", vbInformation, "Error"
        End If
    End With
End If
KeyAscii = DigitOnly(KeyAscii)

End Sub
Private Sub EmptyTemp()
    
    Check_Object AdoPntTemp
    PatientRpt.Open "DELETE FROM RPT_PATIENT_TEMP", RptConn, adOpenKeyset, adLockOptimistic

End Sub

Private Sub PatientReport(Choice As String)
    With crsReport
        .Connect = "uid=irfan; pwd=afrsim; dsn=;"
        .ReportFileName = App.Path & "\Reports\WIDAL.rpt"
        .SelectionFormula = "{RPT_RESULT.LABNO} = " & Val(Trim(lblLabNo.Caption)) & " AND {RPT_RESULT.FILECODE} = '" & Trim(RptCode) & "'"
        If Choice = "&View Report" Then .Destination = crptToWindow: .WindowState = crptMaximized
        If Choice = "&Print Report" Then .Destination = crptToPrinter
        .Action = 1
    End With
End Sub

Function FillComboBox(cmbObj As Control)
    cmbObj.AddItem "0/00"
    cmbObj.AddItem "1/20"
    cmbObj.AddItem "1/40"
    cmbObj.AddItem "1/80"
    cmbObj.AddItem "1/160"
    cmbObj.AddItem "1/320"
End Function

Private Sub ControlToRoundedRectangle(aControl As Variant)
'    Dim L As Long
'    L = CreateRoundRectRgn(2, 2, aControl.width / Screen.TwipsPerPixelX, aControl.height / Screen.TwipsPerPixelY, 14, 14)
'    SetWindowRgn aControl.hwnd, L, True
End Sub
