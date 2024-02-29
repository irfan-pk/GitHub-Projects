VERSION 5.00
Begin VB.Form frmSplash 
   Appearance      =   0  'Flat
   AutoRedraw      =   -1  'True
   BackColor       =   &H80000005&
   BorderStyle     =   0  'None
   ClientHeight    =   3570
   ClientLeft      =   210
   ClientTop       =   1365
   ClientWidth     =   7200
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   FillStyle       =   0  'Solid
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   MouseIcon       =   "frmSplash.frx":000C
   MousePointer    =   11  'Hourglass
   Picture         =   "frmSplash.frx":0316
   ScaleHeight     =   3570
   ScaleWidth      =   7200
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   360
      Top             =   2880
   End
   Begin VB.Label lblVersion 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Version 1.0"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00E0E0E0&
      Height          =   180
      Left            =   5550
      TabIndex        =   1
      Top             =   3120
      Width           =   1170
   End
   Begin VB.Label lblCompany 
      BackStyle       =   0  'Transparent
      Caption         =   "Advance Micro Systems"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   255
      Left            =   3720
      TabIndex        =   0
      Top             =   2880
      Width           =   3015
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Trans As Integer
Dim LTime
Dim Cntr, i, j As Long

Private Sub Form_Load()
    frmSplash.Show
    frmSplash.Enabled = False
    Trans = 0
'    SetTrans Me.hwnd, Trans
    Screen.MousePointer = vbHourglass
End Sub

Private Sub Timer1_Timer()
    
    For Cntr = 1 To 255 Step 2
        Trans = Trans + 1
'        SetTrans Me.hwnd, Trans
    Next Cntr
    ConProvider = "Provider=MSDASQL.1;Password=afrsim;Persist Security Info=True;User ID=irfan;Extended Properties='DSN=ALD;UID=irfan;PWD=afrsim;APP=Visual Basic;WSID=DATABASE;DATABASE=ALD;Network=DBMSSOCN';"
    AccProvider = "Provider=MSDASQL.1;Password=afrsim;Persist Security Info=True;User ID=irfan;Extended Properties='DSN=ALD;UID=irfan;PWD=afrsim;APP=Visual Basic;WSID=DATABASE;DATABASE=ACCOUNTS;Network=DBMSSOCN';"
    RptProvider = "Provider=MSDASQL.1;Password=afrsim;Persist Security Info=True;User ID=irfan;Extended Properties='DSN=ALD;UID=irfan;PWD=afrsim;APP=Visual Basic;WSID=DATABASE;DATABASE=REPORTS;Network=DBMSSOCN';"

    Call AccConnection
    Call SqlConnection
    Screen.MousePointer = vbDefault
    
'    For i = 1 To 100
'        For j = 1 To 50
'            Next j
'    Next i
    
    For Cntr = 1 To 255 Step 2
        Trans = Trans - 1
'        SetTrans Me.hwnd, Trans
    Next Cntr
    frmSplash.Enabled = True
    Unload Me
    Load frmMain: frmMain.Show
End Sub

