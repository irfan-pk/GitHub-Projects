USE [LAB]
GO
/****** Object:  Table [dbo].[VISITOR_TABLE]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VISITOR_TABLE](
	[visitor_name] [char](20) NULL,
	[visitor_contact] [char](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [char](8) NOT NULL,
	[UserName] [char](15) NULL,
	[Password] [char](15) NULL,
	[UserType] [char](15) NULL,
	[UserStatus] [char](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tests](
	[tcode] [char](5) NOT NULL,
	[tname] [char](100) NULL,
	[tcatg] [char](50) NULL,
	[trate] [int] NULL,
	[tsample] [char](15) NULL,
	[treport] [char](50) NULL,
	[trptlvl] [smallint] NULL,
	[tdiscmode] [char](11) NULL,
	[tNewRate] [int] NULL,
	[tOldRate] [int] NULL,
	[tsubcatg] [char](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Temp]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Temp](
	[tcaseno] [decimal](10, 0) NULL,
	[tcode] [char](5) NOT NULL,
	[tname] [char](100) NULL,
	[tcatg] [char](25) NULL,
	[trate] [decimal](18, 0) NULL,
	[tqty] [decimal](10, 0) NULL,
	[tdate] [datetime] NULL,
	[tmode] [char](3) NULL,
	[trptlvl] [char](3) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Statement]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Statement](
	[Cases] [int] NULL,
	[CpName] [char](50) NULL,
	[Gross] [float] NULL,
	[Disc] [float] NULL,
	[CReturn] [float] NULL,
	[Dues] [float] NULL,
	[Compl] [float] NULL,
	[Net] [float] NULL,
	[DueRcv] [float] NULL,
	[OtherCash] [float] NULL,
	[DuesAdjustment] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_WIDAL]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_WIDAL](
	[LABID] [numeric](18, 0) NULL,
	[FILECODE] [char](15) NULL,
	[PARAM] [char](2) NULL,
	[R1] [char](3) NULL,
	[R2] [char](3) NULL,
	[R3] [char](3) NULL,
	[R4] [char](3) NULL,
	[R5] [char](3) NULL,
	[SORT_ID] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_TEMP]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_TEMP](
	[LABNO] [numeric](18, 0) NULL,
	[FILECODE] [char](15) NULL,
	[RPTCODE] [char](10) NULL,
	[TSTCODE] [char](10) NULL,
	[CATEGORY] [char](100) NULL,
	[GROUPBY] [char](50) NULL,
	[TEST] [char](50) NULL,
	[RESULT] [char](10) NULL,
	[UNITS] [char](50) NULL,
	[NORM_VAL] [char](300) NULL,
	[SORT_ORDER] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_RSLT_REMARKS]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_RSLT_REMARKS](
	[LABID] [numeric](18, 0) NULL,
	[RMKS] [char](300) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_RESULT]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_RESULT](
	[LABNO] [numeric](18, 0) NOT NULL,
	[FILECODE] [char](15) NULL,
	[RPTCODE] [char](10) NULL,
	[TSTCODE] [char](10) NULL,
	[CATEGORY] [char](100) NULL,
	[GROUPBY] [char](50) NULL,
	[TEST] [char](50) NULL,
	[RESULT] [char](10) NULL,
	[UNITS] [char](50) NULL,
	[NORM_VAL] [char](300) NULL,
	[SORT_ORDER] [smallint] NULL,
	[RMKCD] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_REMARKS]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_REMARKS](
	[RMKCODE] [char](10) NULL,
	[REMARKS] [char](300) NULL,
	[CATG] [char](5) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_PATIENT_TEMP]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_PATIENT_TEMP](
	[p_num] [numeric](10, 0) NOT NULL,
	[p_name] [char](50) NULL,
	[p_age] [char](15) NULL,
	[p_sex] [char](6) NULL,
	[p_ref_by] [char](50) NULL,
	[p_date_sample] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_PATIENT]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_PATIENT](
	[p_num] [numeric](10, 0) NOT NULL,
	[p_name] [char](50) NULL,
	[p_age] [char](15) NULL,
	[p_sex] [char](6) NULL,
	[p_ref_by] [char](50) NULL,
	[p_date_sample] [datetime] NULL,
	[p_cp_rmk] [char](300) NULL,
	[p_oth_rmk] [char](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_PARAM_TEMP]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_PARAM_TEMP](
	[FILECODE] [char](15) NULL,
	[RPTCODE] [char](15) NULL,
	[TSTCODE] [char](10) NULL,
	[CATEGORY] [char](100) NULL,
	[GROUP_PARM] [char](100) NULL,
	[PARAMETERS] [char](100) NULL,
	[DEF_VAL] [char](30) NULL,
	[UNITS] [char](50) NULL,
	[NORM_VAL] [char](300) NULL,
	[SORT_ORDER] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_PARAM]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_PARAM](
	[FILECODE] [char](15) NULL,
	[RPTCODE] [char](15) NULL,
	[TSTCODE] [char](10) NULL,
	[CATEGORY] [char](100) NULL,
	[GROUP_PARM] [char](100) NULL,
	[PARAMETERS] [char](100) NULL,
	[DEF_VAL] [char](30) NULL,
	[UNITS] [char](50) NULL,
	[NORM_VAL] [char](300) NULL,
	[SORT_ORDER] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RPT_MP]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPT_MP](
	[LABNO] [numeric](18, 0) NOT NULL,
	[MP_RESULT] [char](300) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RECEIPT]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RECEIPT](
	[tcaseno] [decimal](10, 0) NULL,
	[tcode] [char](5) NULL,
	[tname] [char](100) NULL,
	[tcatg] [char](25) NULL,
	[trate] [decimal](18, 0) NULL,
	[tqty] [decimal](10, 0) NULL,
	[tdate] [datetime] NULL,
	[tmode] [char](3) NULL,
	[tdelete] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[p_num] [decimal](10, 0) NOT NULL,
	[p_sno] [int] NULL,
	[p_name] [char](50) NULL,
	[p_age] [char](22) NULL,
	[p_phone] [char](15) NULL,
	[p_sex] [char](6) NULL,
	[p_ref_by] [char](50) NULL,
	[p_cp] [char](50) NULL,
	[p_total] [float] NULL,
	[p_paid] [float] NULL,
	[p_discount] [float] NULL,
	[p_dues] [float] NULL,
	[p_compliment] [float] NULL,
	[p_delete] [float] NULL,
	[p_date_sample] [datetime] NULL,
	[p_time_sample] [datetime] NULL,
	[p_operator] [char](15) NULL,
	[p_rpt_date] [datetime] NULL,
	[p_rpt_time] [datetime] NULL,
	[p_due_rcv] [float] NULL,
	[p_due_rcv_date] [datetime] NULL,
	[p_due_rcv_operator] [char](50) NULL,
	[p_del_ok] [char](13) NULL,
	[p_del_date] [datetime] NULL,
	[p_del_time] [datetime] NULL,
	[p_del_operator] [char](50) NULL,
	[p_slip_num] [decimal](10, 0) NULL,
	[p_disc_by] [char](15) NULL,
	[p_edit_by] [char](15) NULL,
	[p_edit_on] [datetime] NULL,
	[p_edit_opr] [char](15) NULL,
	[p_reason] [char](300) NULL,
	[p_staff_Nm] [char](20) NULL,
	[p_comp_by] [char](20) NULL,
	[p_comp_on] [datetime] NULL,
	[p_delete_on] [datetime] NULL,
	[p_other] [float] NULL,
	[p_del_disc] [float] NULL,
	[p_del_dues] [float] NULL,
	[p_com_disc] [float] NULL,
	[p_com_dues] [float] NULL,
	[p_del_paid] [float] NULL,
	[p_com_paid] [float] NULL,
	[p_bad_debts] [char](1) NULL,
	[p_bad_date] [datetime] NULL,
	[p_aft_disc] [float] NULL,
	[p_aft_date] [datetime] NULL,
	[p_aft_dues] [float] NULL,
	[p_dname] [char](50) NULL,
	[p_aft_gross] [float] NULL,
	[p_aft_paid] [float] NULL,
	[p_pannel] [char](30) NULL,
	[p_posting] [char](1) NULL,
	[p_visitor] [char](20) NULL,
	[p_refer_2] [char](100) NULL,
	[p_don_sex] [char](6) NULL,
	[p_don_age] [char](10) NULL,
	[p_cnic] [char](15) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ledger_Transactions]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ledger_Transactions](
	[Ledg_Date] [date] NULL,
	[Ledg_Tran_Id] [decimal](10, 0) NULL,
	[Ledg_Acc_Id] [decimal](10, 0) NULL,
	[Ledg_Description] [char](50) NULL,
	[Ledg_LP] [char](3) NULL,
	[Ledg_Acc_Type] [char](2) NULL,
	[Ledg_Debit] [float] NULL,
	[Ledg_Credit] [float] NULL,
	[Ledg_Narration] [char](300) NULL,
	[Ledg_Balance] [float] NULL,
	[Ledg_Update] [datetime] NULL,
	[Ledg_Link_Code] [smallint] NULL,
	[Ledg_Link] [char](9) NULL,
	[Ledg_Amount] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_INFO]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_INFO](
	[LAB_NAME] [char](400) NULL,
	[LAB_ADDRESS] [char](400) NULL,
	[LAB_PATHOLOGIST] [char](100) NULL,
	[LAB_TEL1] [char](11) NULL,
	[LAB_TEL2] [char](11) NULL,
	[LAB_MOB1] [char](11) NULL,
	[LAB_MOB2] [char](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INVENTORY]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INVENTORY](
	[INV_CODE] [char](5) NULL,
	[INV_DESCRIPTION] [char](100) NULL,
	[INV_QTY_TYPE] [char](1) NULL,
	[INV_PER_PACK] [char](5) NULL,
	[INV_HAND_Q1] [int] NULL,
	[INV_PPACK_R] [char](7) NULL,
	[INV_HAND_R1] [int] NULL,
	[INV_HAND_R2] [int] NULL,
	[INV_PACK] [char](10) NULL,
	[INV_PCK_PRICE] [float] NULL,
	[INV_PCH_PRICE] [float] NULL,
	[INV_UPD_DT] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INV_TRANSACTIONS]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INV_TRANSACTIONS](
	[TRS_DATE] [date] NULL,
	[TRS_INVOICE] [char](10) NULL,
	[TRS_CODE] [char](10) NULL,
	[TRS_RETAILER] [char](100) NULL,
	[TRS_DESCRIPTION] [char](200) NULL,
	[TRS_QTY_TYPE] [char](1) NULL,
	[TRS_QTY] [int] NULL,
	[TRS_PER_PACK] [char](7) NULL,
	[TRS_PACK] [char](7) NULL,
	[TRS_R1] [int] NULL,
	[TRS_R2] [int] NULL,
	[TRS_PCK_PRICE] [float] NULL,
	[TRS_PCH_PRICE] [float] NULL,
	[TRS_UPD_ON] [date] NULL,
	[TRS_QTY_BF] [int] NULL,
	[TRS_R1_BF] [int] NULL,
	[TRS_R2_BF] [int] NULL,
	[TRS_QTY_ISSU] [int] NULL,
	[TRS_R1_ISSU] [int] NULL,
	[TRS_R2_ISSU] [int] NULL,
	[TRS_STATUS] [char](6) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Income_Statement]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Income_Statement](
	[INC_STAT_NAME] [char](10) NULL,
	[INC_STAT_ACCOUNT] [char](100) NULL,
	[INC_STAT_TYPE] [char](2) NULL,
	[INC_STAT_ACC_ID] [int] NULL,
	[INC_STAT_DEBIT] [float] NULL,
	[INC_STAT_CREDIT] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_Temp]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_Temp](
	[Gen_Date] [datetime] NULL,
	[Gen_Tran_Id] [decimal](10, 0) NULL,
	[Gen_Acc_Id] [decimal](10, 0) NULL,
	[Gen_Description] [char](50) NULL,
	[Gen_LP] [char](3) NULL,
	[Gen_Acc_Type] [char](2) NULL,
	[Gen_Debit] [float] NULL,
	[Gen_Credit] [float] NULL,
	[Gen_Narration] [char](300) NULL,
	[Gen_Sort] [smallint] NULL,
	[Gen_Link_Code] [smallint] NULL,
	[Gen_Link] [char](9) NULL,
	[Gen_Amount] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FORMATS]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FORMATS](
	[SNO] [int] NOT NULL,
	[CATEGORY] [nvarchar](200) NULL,
	[FCODE] [nvarchar](50) NULL,
	[TSNAME] [nvarchar](200) NULL,
	[NORM_RANGE] [nvarchar](200) NULL,
	[TSTATUS] [nvarchar](50) NULL,
	[UNITS] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [nvarchar](15) NOT NULL,
	[LastName] [nvarchar](15) NOT NULL,
	[Title] [nvarchar](10) NULL,
	[CNIC] [nvarchar](13) NULL,
	[HireDate] [nvarchar](10) NULL,
	[Address] [nvarchar](30) NULL,
	[City] [nvarchar](10) NULL,
	[Mobile] [nvarchar](11) NULL,
	[HomePhone] [nvarchar](10) NULL,
	[ReportsTo] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dues_Temp]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dues_Temp](
	[p_num] [decimal](10, 0) NOT NULL,
	[p_cp] [char](50) NULL,
	[p_due_rcv] [float] NULL,
	[p_due_rcv_date] [datetime] NULL,
	[p_due_rcv_operator] [char](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DONOR_TABLE]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DONOR_TABLE](
	[DONOR_ID] [int] NULL,
	[DONOR_NAME] [char](50) NULL,
	[DONOR_AGE] [char](22) NULL,
	[DONOR_GENDER] [char](6) NULL,
	[DONOR_PID] [int] NULL,
	[DONOR_DATE] [date] NULL,
	[DONOR_WT] [char](5) NULL,
	[DONOR_HBS] [char](8) NULL,
	[DONOR_HCV] [char](8) NULL,
	[DONOR_HIV] [char](8) NULL,
	[DONOR_VDRL] [char](8) NULL,
	[DONOR_GROUP] [char](30) NULL,
	[PATIENT_GRP] [char](30) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocList]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocList](
	[Doc_Name] [char](50) NOT NULL,
	[Doc_Phone] [char](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Company]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[CP_ID] [int] NOT NULL,
	[CP_Name] [char](50) NULL,
	[CP_Incharge] [char](50) NULL,
	[CP_Address] [char](150) NULL,
	[CP_City] [char](10) NULL,
	[CP_Tel] [char](15) NULL,
	[CP_Mob] [char](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CollectionPoint]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CollectionPoint](
	[CP_ID] [char](10) NULL,
	[CP_Name] [char](50) NULL,
	[CP_Incharge] [char](50) NULL,
	[CP_Address] [char](150) NULL,
	[CP_City] [char](30) NULL,
	[CP_Per_Ordinary] [int] NULL,
	[CP_Per_Special] [int] NULL,
	[CP_Tel] [char](15) NULL,
	[CP_Mob] [char](11) NULL,
	[CP_Conditional] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 01/06/2019 18:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accounts](
	[Acc_No] [int] NOT NULL,
	[Acc_Name] [char](50) NULL,
	[Acc_Type] [char](2) NULL,
	[Acc_Balance] [float] NULL,
	[Acc_Update] [date] NULL,
	[Acc_Opn_Date] [date] NULL,
	[Acc_Link_Code] [smallint] NULL,
	[Acc_Link] [char](9) NULL,
	[Acc_Credited] [float] NULL,
	[Acc_Debited] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Tests_tNewRate]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Tests] ADD  CONSTRAINT [DF_Tests_tNewRate]  DEFAULT ((0)) FOR [tNewRate]
GO
/****** Object:  Default [DF_Tests_tsubcatg]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Tests] ADD  CONSTRAINT [DF_Tests_tsubcatg]  DEFAULT ('x') FOR [tsubcatg]
GO
/****** Object:  Default [DF_Statement_DuesAdjustment]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Statement] ADD  CONSTRAINT [DF_Statement_DuesAdjustment]  DEFAULT ((0)) FOR [DuesAdjustment]
GO
/****** Object:  Default [DF_Patient_p_name]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_name]  DEFAULT ('x') FOR [p_name]
GO
/****** Object:  Default [DF_Patient_p_age]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_age]  DEFAULT ('x') FOR [p_age]
GO
/****** Object:  Default [DF_Patient_p_phone]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_phone]  DEFAULT ('x') FOR [p_phone]
GO
/****** Object:  Default [DF_Patient_p_sex]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_sex]  DEFAULT ('x') FOR [p_sex]
GO
/****** Object:  Default [DF_Patient_p_ref_by]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_ref_by]  DEFAULT ('x') FOR [p_ref_by]
GO
/****** Object:  Default [DF_Patient_p_cp]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_cp]  DEFAULT ('x') FOR [p_cp]
GO
/****** Object:  Default [DF_Patient_p_total]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_total]  DEFAULT ((0)) FOR [p_total]
GO
/****** Object:  Default [DF_Patient_p_paid]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_paid]  DEFAULT ((0)) FOR [p_paid]
GO
/****** Object:  Default [DF_Patient_p_discount]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_discount]  DEFAULT ((0)) FOR [p_discount]
GO
/****** Object:  Default [DF_Patient_p_dues]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_dues]  DEFAULT ((0)) FOR [p_dues]
GO
/****** Object:  Default [DF_Patient_p_compliment]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_compliment]  DEFAULT ((0)) FOR [p_compliment]
GO
/****** Object:  Default [DF_Patient_p_delete]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_delete]  DEFAULT ((0)) FOR [p_delete]
GO
/****** Object:  Default [DF_Patient_p_date_sample]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_date_sample]  DEFAULT (((1)/(1))/(1999)) FOR [p_date_sample]
GO
/****** Object:  Default [DF_Patient_p_time_sample]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_time_sample]  DEFAULT (((1)/(1))/(1999)) FOR [p_time_sample]
GO
/****** Object:  Default [DF_Patient_p_operator]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_operator]  DEFAULT ('x') FOR [p_operator]
GO
/****** Object:  Default [DF_Patient_p_rpt_date]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_rpt_date]  DEFAULT (((1)/(1))/(1999)) FOR [p_rpt_date]
GO
/****** Object:  Default [DF_Patient_p_rpt_time]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_rpt_time]  DEFAULT (((1)/(1))/(1999)) FOR [p_rpt_time]
GO
/****** Object:  Default [DF_Patient_p_due_rcv]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_due_rcv]  DEFAULT ((0)) FOR [p_due_rcv]
GO
/****** Object:  Default [DF_Patient_p_due_rcv_date]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_due_rcv_date]  DEFAULT (((1)/(1))/(1999)) FOR [p_due_rcv_date]
GO
/****** Object:  Default [DF_Patient_p_due_rcv_operator]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_due_rcv_operator]  DEFAULT ('x') FOR [p_due_rcv_operator]
GO
/****** Object:  Default [DF_Patient_p_del_ok]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_del_ok]  DEFAULT ('x') FOR [p_del_ok]
GO
/****** Object:  Default [DF_Patient_p_del_date]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_del_date]  DEFAULT (((1)/(1))/(1999)) FOR [p_del_date]
GO
/****** Object:  Default [DF_Patient_p_del_time]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_del_time]  DEFAULT (((1)/(1))/(1999)) FOR [p_del_time]
GO
/****** Object:  Default [DF_Patient_p_del_operator]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_del_operator]  DEFAULT ('x') FOR [p_del_operator]
GO
/****** Object:  Default [DF_Patient_p_slip_num]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_slip_num]  DEFAULT ((0)) FOR [p_slip_num]
GO
/****** Object:  Default [DF_Patient_p_disc_by]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_disc_by]  DEFAULT ('x') FOR [p_disc_by]
GO
/****** Object:  Default [DF_Patient_p_edit_by]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_edit_by]  DEFAULT ('x') FOR [p_edit_by]
GO
/****** Object:  Default [DF_Patient_p_edit_on]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_edit_on]  DEFAULT (((1)/(1))/(1999)) FOR [p_edit_on]
GO
/****** Object:  Default [DF_Patient_p_edit_opr]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_edit_opr]  DEFAULT ('x') FOR [p_edit_opr]
GO
/****** Object:  Default [DF_Patient_p_reason]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_reason]  DEFAULT ('x') FOR [p_reason]
GO
/****** Object:  Default [DF_Patient_p_staff_Nm]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_staff_Nm]  DEFAULT ('x') FOR [p_staff_Nm]
GO
/****** Object:  Default [DF_Patient_p_comp_by]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_comp_by]  DEFAULT ('x') FOR [p_comp_by]
GO
/****** Object:  Default [DF_Patient_p_comp_on]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_comp_on]  DEFAULT (((1)/(1))/(1999)) FOR [p_comp_on]
GO
/****** Object:  Default [DF_Patient_p_delete_on]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_delete_on]  DEFAULT (((1)/(1))/(1999)) FOR [p_delete_on]
GO
/****** Object:  Default [DF_Patient_p_other]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_other]  DEFAULT ((0)) FOR [p_other]
GO
/****** Object:  Default [DF_Patient_p_del_disc]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_del_disc]  DEFAULT ((0)) FOR [p_del_disc]
GO
/****** Object:  Default [DF_Patient_p_del_dues]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_del_dues]  DEFAULT ((0)) FOR [p_del_dues]
GO
/****** Object:  Default [DF_Patient_p_com_disc]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_com_disc]  DEFAULT ((0)) FOR [p_com_disc]
GO
/****** Object:  Default [DF_Patient_p_com_dues]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_com_dues]  DEFAULT ((0)) FOR [p_com_dues]
GO
/****** Object:  Default [DF_Patient_p_del_paid]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_del_paid]  DEFAULT ((0)) FOR [p_del_paid]
GO
/****** Object:  Default [DF_Patient_p_com_paid]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_com_paid]  DEFAULT ((0)) FOR [p_com_paid]
GO
/****** Object:  Default [DF_Patient_p_bad_debts]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_bad_debts]  DEFAULT ('F') FOR [p_bad_debts]
GO
/****** Object:  Default [DF_Patient_p_bad_date]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_bad_date]  DEFAULT (((1)/(1))/(1999)) FOR [p_bad_date]
GO
/****** Object:  Default [DF_Patient_p_aft_disc]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_aft_disc]  DEFAULT ((0)) FOR [p_aft_disc]
GO
/****** Object:  Default [DF_Patient_p_aft_date]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_aft_date]  DEFAULT ((0)) FOR [p_aft_date]
GO
/****** Object:  Default [DF_Patient_p_aft_dues]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_aft_dues]  DEFAULT ((0)) FOR [p_aft_dues]
GO
/****** Object:  Default [DF_Patient_p_dname]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_dname]  DEFAULT ('x') FOR [p_dname]
GO
/****** Object:  Default [DF_Patient_p_aft_gross]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_aft_gross]  DEFAULT ((0)) FOR [p_aft_gross]
GO
/****** Object:  Default [DF_Patient_p_aft_paid]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_aft_paid]  DEFAULT ((0)) FOR [p_aft_paid]
GO
/****** Object:  Default [DF_Patient_p_pannel]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_pannel]  DEFAULT ((0)) FOR [p_pannel]
GO
/****** Object:  Default [DF_Patient_p_posting]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_posting]  DEFAULT ('N') FOR [p_posting]
GO
/****** Object:  Default [DF_Patient_p_visitor]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_visitor]  DEFAULT ('x') FOR [p_visitor]
GO
/****** Object:  Default [DF_Patient_p_refer_2]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_refer_2]  DEFAULT ('x') FOR [p_refer_2]
GO
/****** Object:  Default [DF_Patient_p_don_sex]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_don_sex]  DEFAULT ('x') FOR [p_don_sex]
GO
/****** Object:  Default [DF_Patient_p_don_age]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [DF_Patient_p_don_age]  DEFAULT ('x') FOR [p_don_age]
GO
/****** Object:  Default [DF_Ledger_Transactions_Ledg_Balance]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Ledger_Transactions] ADD  CONSTRAINT [DF_Ledger_Transactions_Ledg_Balance]  DEFAULT ((0)) FOR [Ledg_Balance]
GO
/****** Object:  Default [DF_Ledger_Transactions_Ledg_Update]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Ledger_Transactions] ADD  CONSTRAINT [DF_Ledger_Transactions_Ledg_Update]  DEFAULT (((1)/(1))/(2011)) FOR [Ledg_Update]
GO
/****** Object:  Default [DF_Ledger_Transactions_Ledg_Amount]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Ledger_Transactions] ADD  CONSTRAINT [DF_Ledger_Transactions_Ledg_Amount]  DEFAULT ((0.00)) FOR [Ledg_Amount]
GO
/****** Object:  Default [DF_INVENTORY_INV_CODE]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INVENTORY] ADD  CONSTRAINT [DF_INVENTORY_INV_CODE]  DEFAULT ('X') FOR [INV_CODE]
GO
/****** Object:  Default [DF_INVENTORY_INV_DESCRIPTION]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INVENTORY] ADD  CONSTRAINT [DF_INVENTORY_INV_DESCRIPTION]  DEFAULT ('X') FOR [INV_DESCRIPTION]
GO
/****** Object:  Default [DF_INV_TRANSACTIONS_TRS_RETAILER]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INV_TRANSACTIONS] ADD  CONSTRAINT [DF_INV_TRANSACTIONS_TRS_RETAILER]  DEFAULT ('X') FOR [TRS_RETAILER]
GO
/****** Object:  Default [DF_INV_TRANSACTIONS_TRS_QTY]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INV_TRANSACTIONS] ADD  CONSTRAINT [DF_INV_TRANSACTIONS_TRS_QTY]  DEFAULT ((0)) FOR [TRS_QTY]
GO
/****** Object:  Default [DF_INV_TRANSACTIONS_TRS_PER_PACK]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INV_TRANSACTIONS] ADD  CONSTRAINT [DF_INV_TRANSACTIONS_TRS_PER_PACK]  DEFAULT ((0)) FOR [TRS_PER_PACK]
GO
/****** Object:  Default [DF_INV_TRANSACTIONS_TRS_R1]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INV_TRANSACTIONS] ADD  CONSTRAINT [DF_INV_TRANSACTIONS_TRS_R1]  DEFAULT ((0)) FOR [TRS_R1]
GO
/****** Object:  Default [DF_INV_TRANSACTIONS_TRS_R2]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INV_TRANSACTIONS] ADD  CONSTRAINT [DF_INV_TRANSACTIONS_TRS_R2]  DEFAULT ((0)) FOR [TRS_R2]
GO
/****** Object:  Default [DF_INV_TRANSACTIONS_TRS_DEBIT]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INV_TRANSACTIONS] ADD  CONSTRAINT [DF_INV_TRANSACTIONS_TRS_DEBIT]  DEFAULT ((0)) FOR [TRS_PCK_PRICE]
GO
/****** Object:  Default [DF_INV_TRANSACTIONS_TRS_CREDIT]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INV_TRANSACTIONS] ADD  CONSTRAINT [DF_INV_TRANSACTIONS_TRS_CREDIT]  DEFAULT ((0)) FOR [TRS_PCH_PRICE]
GO
/****** Object:  Default [DF_INV_TRANSACTIONS_TRS_STATUS]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[INV_TRANSACTIONS] ADD  CONSTRAINT [DF_INV_TRANSACTIONS_TRS_STATUS]  DEFAULT ('x') FOR [TRS_STATUS]
GO
/****** Object:  Default [DF_Gen_Temp_Gen_Link]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Gen_Temp] ADD  CONSTRAINT [DF_Gen_Temp_Gen_Link]  DEFAULT ('x') FOR [Gen_Link]
GO
/****** Object:  Default [DF_Gen_Temp_Gen_Amount]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Gen_Temp] ADD  CONSTRAINT [DF_Gen_Temp_Gen_Amount]  DEFAULT ((0.00)) FOR [Gen_Amount]
GO
/****** Object:  Default [DF_DONOR_TABLE_DONOR_PID]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[DONOR_TABLE] ADD  CONSTRAINT [DF_DONOR_TABLE_DONOR_PID]  DEFAULT ((0)) FOR [DONOR_PID]
GO
/****** Object:  Default [DF_DONOR_TABLE_DONOR_WT]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[DONOR_TABLE] ADD  CONSTRAINT [DF_DONOR_TABLE_DONOR_WT]  DEFAULT ('00 kg') FOR [DONOR_WT]
GO
/****** Object:  Default [DF_DONOR_TABLE_DONOR_HBS]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[DONOR_TABLE] ADD  CONSTRAINT [DF_DONOR_TABLE_DONOR_HBS]  DEFAULT ('NEGATIVE') FOR [DONOR_HBS]
GO
/****** Object:  Default [DF_DONOR_TABLE_DONOR_HCV]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[DONOR_TABLE] ADD  CONSTRAINT [DF_DONOR_TABLE_DONOR_HCV]  DEFAULT ('NEGATIVE') FOR [DONOR_HCV]
GO
/****** Object:  Default [DF_DONOR_TABLE_DONOR_HIV]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[DONOR_TABLE] ADD  CONSTRAINT [DF_DONOR_TABLE_DONOR_HIV]  DEFAULT ('NEGATIVE') FOR [DONOR_HIV]
GO
/****** Object:  Default [DF_DONOR_TABLE_DONOR_VDRL]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[DONOR_TABLE] ADD  CONSTRAINT [DF_DONOR_TABLE_DONOR_VDRL]  DEFAULT ('NEGATIVE') FOR [DONOR_VDRL]
GO
/****** Object:  Default [DF_CollectionPoint_CP_Conditional]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[CollectionPoint] ADD  CONSTRAINT [DF_CollectionPoint_CP_Conditional]  DEFAULT ((15)) FOR [CP_Conditional]
GO
/****** Object:  Default [DF_Accounts_Acc_Balance]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF_Accounts_Acc_Balance]  DEFAULT ((0)) FOR [Acc_Balance]
GO
/****** Object:  Default [DF_Accounts_Acc_Credited]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF_Accounts_Acc_Credited]  DEFAULT ((0)) FOR [Acc_Credited]
GO
/****** Object:  Default [DF_Accounts_Acc_Debited]    Script Date: 01/06/2019 18:34:46 ******/
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF_Accounts_Acc_Debited]  DEFAULT ((0)) FOR [Acc_Debited]
GO
