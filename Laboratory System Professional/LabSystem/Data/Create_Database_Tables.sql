USE [LAB_PRO]
GO
/****** Object:  Table [dbo].[Visitor_Table]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Visitor_Table](
	[visitor_name] [varchar](20) NULL,
	[visitor_contact] [varchar](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [varchar](20) NOT NULL,
	[UserName] [varchar](20) NULL,
	[Password] [varchar](15) NULL,
	[UserType] [varchar](15) NULL,
	[UserStatus] [varchar](2) NULL,
	[UserSection] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tests](
	[tcode] [varchar](10) NOT NULL,
	[tname] [varchar](100) NULL,
	[tcatg] [varchar](50) NULL,
	[trate] [int] NULL,
	[tsample] [varchar](25) NULL,
	[treport] [varchar](50) NULL,
	[trptlvl] [smallint] NULL,
	[tdiscmode] [varchar](11) NULL,
	[tNewRate] [int] NULL,
	[tOldRate] [int] NULL,
	[tsubcatg] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Temp]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Temp](
	[tcaseno] [decimal](10, 0) NULL,
	[tcode] [varchar](5) NOT NULL,
	[tname] [varchar](100) NULL,
	[tcatg] [varchar](25) NULL,
	[trate] [decimal](18, 0) NULL,
	[tqty] [decimal](10, 0) NULL,
	[tdate] [datetime] NULL,
	[tmode] [varchar](3) NULL,
	[trptlvl] [varchar](3) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_Printers]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[System_Printers](
	[PRINTER_NAME] [varchar](100) NULL,
	[PRINTER_TYPE] [varchar](50) NULL,
	[PRINT_FOR] [varchar](50) NULL,
	[INSTALL_LOC] [varchar](50) NULL,
	[DEFAULT_COPIES] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [nvarchar](128) NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Statement]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Statement](
	[Cases] [int] NULL,
	[CpName] [varchar](50) NULL,
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
/****** Object:  Table [dbo].[Salary_Sheet]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salary_Sheet](
	[EmpID] [int] NULL,
	[EmpName] [varchar](20) NULL,
	[Designation] [varchar](30) NULL,
	[EmpSalary] [float] NULL,
	[EmpBonus] [float] NULL,
	[EmpArears] [float] NULL,
	[EmpAdvance] [float] NULL,
	[EmpDeduction] [float] NULL,
	[EmpNetSalary] [float] NULL,
	[EmpClosBal] [float] NULL,
	[SalaryMonth] [varchar](10) NULL,
	[PrepareBy] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salary_Info]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salary_Info](
	[EmployeeName] [varchar](15) NULL,
	[IncreaseOn] [date] NULL,
	[Position] [varchar](30) NULL,
	[Type] [varchar](10) NULL,
	[Note] [varchar](200) NULL,
	[Rate] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salary_Advances]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salary_Advances](
	[EmployeeID] [int] NULL,
	[Name] [varchar](30) NULL,
	[Month] [varchar](7) NULL,
	[AdvDate] [date] NULL,
	[Amount] [float] NULL,
	[ApprovedBy] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rpt_Result_Remarks]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rpt_Result_Remarks](
	[LABID] [numeric](18, 0) NULL,
	[RPTCODE] [varchar](20) NULL,
	[RMKCD] [varchar](10) NULL,
	[RMKS] [varchar](300) NULL,
	[CATEGORY] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rpt_Result]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rpt_Result](
	[LABNO] [numeric](18, 0) NOT NULL,
	[PARAMETERS] [varchar](100) NULL,
	[RESULT] [varchar](50) NULL,
	[UNITS] [varchar](50) NULL,
	[NORM_VAL] [varchar](300) NULL,
	[FILECODE] [varchar](30) NULL,
	[RPTCODE] [varchar](30) NULL,
	[CATEGORY] [varchar](100) NULL,
	[GROUP_PARAM] [varchar](50) NULL,
	[TSTCODE] [varchar](10) NULL,
	[SUBCODE] [varchar](10) NULL,
	[SORT_ORDER] [int] NULL,
	[FORMNAME] [varchar](20) NULL,
	[TYPE] [varchar](10) NULL,
	[PSTATUS] [smallint] NULL,
	[RPT_DATE] [date] NULL,
	[NAME] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rpt_Remarks]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rpt_Remarks](
	[RMKCODE] [varchar](10) NULL,
	[DESCRIPTION] [varchar](300) NULL,
	[CATEGORY] [varchar](20) NULL,
	[TESTNAME] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rpt_Param]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rpt_Param](
	[FILECODE] [varchar](40) NULL,
	[RPTCODE] [varchar](40) NULL,
	[CATEGORY] [varchar](100) NULL,
	[GROUP_PARM] [varchar](100) NULL,
	[TSTCODE] [varchar](15) NULL,
	[SUBCODE] [varchar](15) NULL,
	[PARAMETERS] [varchar](100) NULL,
	[DEF_VAL] [varchar](300) NULL,
	[UNITS] [varchar](50) NULL,
	[NORM_VAL] [varchar](300) NULL,
	[SORT_ORDER] [int] NULL,
	[FORMNAME] [varchar](20) NULL,
	[TYPE] [varchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rpt_NoGrowth]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rpt_NoGrowth](
	[LABNO] [numeric](18, 0) NOT NULL,
	[SOURCE] [varchar](50) NULL,
	[RESULT] [varchar](300) NULL,
	[FILECODE] [varchar](30) NULL,
	[RPTCODE] [varchar](30) NULL,
	[CATEGORY] [varchar](100) NULL,
	[TSTCODE] [varchar](10) NULL,
	[FORMNAME] [varchar](20) NULL,
	[RPT_DATE] [date] NULL,
	[PSTATUS] [smallint] NULL,
	[NAME] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rpt_Culture]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rpt_Culture](
	[LABNO] [numeric](18, 0) NOT NULL,
	[SOURCE] [varchar](50) NULL,
	[ORGANISM] [varchar](50) NULL,
	[VIACOUNT] [decimal](18, 0) NULL,
	[PARAMETERS] [varchar](100) NULL,
	[RESULT] [varchar](2) NULL,
	[FILECODE] [varchar](30) NULL,
	[RPTCODE] [varchar](30) NULL,
	[CATEGORY] [varchar](20) NULL,
	[GROUP_PARAM] [varchar](50) NULL,
	[TSTCODE] [varchar](10) NULL,
	[SORT_ORDER] [int] NULL,
	[FORMNAME] [varchar](20) NULL,
	[TYPE] [varchar](10) NULL,
	[GCODE] [varchar](1) NULL,
	[RPT_DATE] [date] NULL,
	[PSTATUS] [smallint] NULL,
	[NAME] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rpt_Biopsy]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rpt_Biopsy](
	[LABNO] [decimal](18, 0) NULL,
	[BIOPSY_ID] [varchar](10) NULL,
	[BIOPSY_HISTORY] [varchar](max) NULL,
	[BIOPSY_GROSS] [ntext] NULL,
	[BIOPSY_MICROSCOPE] [ntext] NULL,
	[BIOPSY_TISSUE] [varchar](max) NULL,
	[BIOPSY_CONCLUSION] [ntext] NULL,
	[RPT_DATE] [date] NULL,
	[RPTCODE] [varchar](30) NULL,
	[FILECODE] [varchar](20) NULL,
	[PSTATUS] [smallint] NULL,
	[NAME] [varchar](100) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Receipt](
	[tcaseno] [decimal](10, 0) NULL,
	[tcode] [varchar](10) NULL,
	[tname] [varchar](100) NULL,
	[tcatg] [varchar](25) NULL,
	[trate] [decimal](18, 0) NULL,
	[tqty] [decimal](10, 0) NULL,
	[tdate] [date] NULL,
	[tmode] [varchar](10) NULL,
	[tdelete] [int] NULL,
	[trptdate] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Petty_Temp]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Petty_Temp](
	[P_Date] [date] NULL,
	[P_Tran_Id] [decimal](10, 0) NULL,
	[P_Acc_Id] [decimal](10, 0) NULL,
	[P_Voucher_No] [varchar](20) NULL,
	[P_Acc_Head] [varchar](20) NULL,
	[P_Sub_Acc] [varchar](30) NULL,
	[P_Narration] [varchar](300) NULL,
	[P_Acc_Type] [varchar](2) NULL,
	[P_Opn_Bal] [float] NULL,
	[P_Debit] [float] NULL,
	[P_Credit] [float] NULL,
	[P_Clo_Bal] [float] NULL,
	[P_Sort] [int] NULL,
	[P_F_Year] [varchar](10) NULL,
	[P_Status] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Petty_Ledgers]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Petty_Ledgers](
	[Ledg_Date] [date] NULL,
	[Ledg_Tran_Id] [decimal](10, 0) NULL,
	[Ledg_Acc_Id] [decimal](10, 0) NULL,
	[Ledg_Voucher_No] [varchar](20) NULL,
	[Ledg_Acc_Head] [varchar](20) NULL,
	[Ledg_Sub_Acc] [varchar](30) NULL,
	[Ledg_Narration] [varchar](300) NULL,
	[Ledg_Acc_Type] [varchar](2) NULL,
	[Ledg_Debit] [decimal](18, 2) NULL,
	[Ledg_Credit] [decimal](18, 2) NULL,
	[Ledg_Balance] [decimal](18, 2) NULL,
	[Ledg_Sort] [int] NULL,
	[Ledg_F_Year] [varchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Petty_Journal]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Petty_Journal](
	[P_Tran_Date] [date] NULL,
	[P_Tran_Id] [decimal](10, 0) NULL,
	[P_Acc_Id] [decimal](10, 0) NULL,
	[P_Voucher_No] [varchar](20) NULL,
	[P_Acc_Head] [varchar](20) NULL,
	[P_Sub_Acc] [varchar](30) NULL,
	[P_Narration] [varchar](300) NULL,
	[P_Acc_Type] [varchar](2) NULL,
	[P_Opn_Bal] [float] NULL,
	[P_Debit] [float] NULL,
	[P_Credit] [float] NULL,
	[P_Clo_Bal] [float] NULL,
	[P_Sort] [int] NULL,
	[P_F_Year] [varchar](10) NULL,
	[P_Status] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Petty_Accounts]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Petty_Accounts](
	[P_Acc_No] [int] NOT NULL,
	[P_Acc_Head] [varchar](30) NULL,
	[P_Acc_Opn_Date] [date] NULL,
	[P_Acc_Name] [varchar](50) NULL,
	[P_Acc_Type] [varchar](2) NULL,
	[P_Acc_Balance] [decimal](18, 2) NULL,
	[P_Acc_Update] [date] NULL,
	[P_Acc_Debit] [decimal](18, 2) NULL,
	[P_Acc_Credit] [decimal](18, 2) NULL,
	[P_Acc_Limit] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[p_num] [decimal](10, 0) NOT NULL,
	[p_sno] [int] NULL,
	[p_name] [varchar](50) NULL,
	[p_age] [varchar](22) NULL,
	[p_phone] [varchar](15) NULL,
	[p_sex] [varchar](6) NULL,
	[p_ref_by] [varchar](50) NULL,
	[p_cp] [varchar](50) NULL,
	[p_total] [float] NULL,
	[p_paid] [float] NULL,
	[p_discount] [float] NULL,
	[p_dues] [float] NULL,
	[p_compliment] [float] NULL,
	[p_delete] [float] NULL,
	[p_date_sample] [datetime] NULL,
	[p_time_sample] [datetime] NULL,
	[p_operator] [varchar](15) NULL,
	[p_rpt_date] [datetime] NULL,
	[p_rpt_time] [datetime] NULL,
	[p_due_rcv] [float] NULL,
	[p_due_rcv_date] [datetime] NULL,
	[p_due_rcv_operator] [varchar](50) NULL,
	[p_del_ok] [varchar](13) NULL,
	[p_del_date] [datetime] NULL,
	[p_del_time] [datetime] NULL,
	[p_del_operator] [varchar](50) NULL,
	[p_slip_num] [decimal](10, 0) NULL,
	[p_disc_by] [varchar](15) NULL,
	[p_edit_by] [varchar](15) NULL,
	[p_edit_on] [datetime] NULL,
	[p_edit_opr] [varchar](15) NULL,
	[p_reason] [varchar](300) NULL,
	[p_staff_Nm] [varchar](20) NULL,
	[p_comp_by] [varchar](20) NULL,
	[p_comp_on] [datetime] NULL,
	[p_delete_on] [datetime] NULL,
	[p_other] [float] NULL,
	[p_del_disc] [float] NULL,
	[p_del_dues] [float] NULL,
	[p_com_disc] [float] NULL,
	[p_com_dues] [float] NULL,
	[p_del_paid] [float] NULL,
	[p_com_paid] [float] NULL,
	[p_bad_debts] [varchar](1) NULL,
	[p_bad_date] [datetime] NULL,
	[p_aft_disc] [float] NULL,
	[p_aft_date] [datetime] NULL,
	[p_aft_dues] [float] NULL,
	[p_spc_refer] [varchar](50) NULL,
	[p_aft_gross] [float] NULL,
	[p_aft_paid] [float] NULL,
	[p_pannel] [varchar](30) NULL,
	[p_posting] [varchar](1) NULL,
	[p_visitor] [varchar](20) NULL,
	[p_refer_2] [varchar](100) NULL,
	[p_don_sex] [varchar](6) NULL,
	[p_don_age] [varchar](10) NULL,
	[p_cnic] [varchar](15) NULL,
	[p_status] [varchar](20) NULL,
	[p_p_amount] [float] NULL,
	[p_sequence] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ledgers]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ledgers](
	[Ledg_Date] [date] NULL,
	[Ledg_Tran_Id] [decimal](10, 0) NULL,
	[Ledg_Acc_Id] [decimal](10, 0) NULL,
	[Ledg_Voucher_No] [varchar](50) NULL,
	[Ledg_Acc_Head] [varchar](50) NULL,
	[Ledg_Sub_Acc] [varchar](50) NULL,
	[Ledg_Narration] [varchar](300) NULL,
	[Ledg_Acc_Type] [varchar](9) NULL,
	[Ledg_Debit] [decimal](18, 2) NULL,
	[Ledg_Credit] [decimal](18, 2) NULL,
	[Ledg_Balance] [decimal](18, 2) NULL,
	[Ledg_Sort] [int] NULL,
	[Ledg_F_Year] [varchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lab_Info]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lab_Info](
	[LAB_NAME] [varchar](400) NULL,
	[LAB_ADDRESS] [varchar](400) NULL,
	[LAB_PATHOLOGIST] [varchar](100) NULL,
	[LAB_TEL1] [varchar](11) NULL,
	[LAB_TEL2] [varchar](11) NULL,
	[LAB_MOB1] [varchar](11) NULL,
	[LAB_MOB2] [varchar](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventory](
	[INV_CODE] [varchar](5) NULL,
	[INV_DESCRIPTION] [varchar](100) NULL,
	[INV_QTY_TYPE] [varchar](1) NULL,
	[INV_PER_PACK] [varchar](5) NULL,
	[INV_HAND_Q1] [int] NULL,
	[INV_PPACK_R] [varchar](7) NULL,
	[INV_HAND_R1] [int] NULL,
	[INV_HAND_R2] [int] NULL,
	[INV_PACK] [varchar](10) NULL,
	[INV_PCK_PRICE] [float] NULL,
	[INV_PCH_PRICE] [float] NULL,
	[INV_UPD_DT] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inv_Transactions]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inv_Transactions](
	[TRS_DATE] [date] NULL,
	[TRS_INVOICE] [varchar](10) NULL,
	[TRS_CODE] [varchar](10) NULL,
	[TRS_RETAILER] [varchar](100) NULL,
	[TRS_DESCRIPTION] [varchar](200) NULL,
	[TRS_QTY_TYPE] [varchar](1) NULL,
	[TRS_QTY] [int] NULL,
	[TRS_PER_PACK] [varchar](7) NULL,
	[TRS_PACK] [varchar](7) NULL,
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
	[TRS_STATUS] [varchar](6) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Income_Statement]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Income_Statement](
	[INC_STAT_NAME] [varchar](10) NULL,
	[INC_STAT_ACCOUNT] [varchar](100) NULL,
	[INC_STAT_TYPE] [varchar](2) NULL,
	[INC_STAT_ACC_ID] [int] NULL,
	[INC_STAT_DEBIT] [float] NULL,
	[INC_STAT_CREDIT] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[General_Journal]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[General_Journal](
	[Gen_Date] [date] NULL,
	[Gen_Tran_Id] [decimal](10, 0) NULL,
	[Gen_Acc_Id] [decimal](10, 0) NULL,
	[Gen_Voucher_No] [varchar](50) NULL,
	[Gen_Acc_Head] [varchar](50) NULL,
	[Gen_Sub_Acc] [varchar](50) NULL,
	[Gen_Narration] [varchar](300) NULL,
	[Gen_LP] [varchar](9) NULL,
	[Gen_Acc_Type] [varchar](2) NULL,
	[Gen_Debit] [float] NULL,
	[Gen_Credit] [float] NULL,
	[Gen_Sort] [int] NULL,
	[Gen_F_Year] [varchar](10) NULL,
	[Gen_Status] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_Temp]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gen_Temp](
	[Gen_Date] [date] NULL,
	[Gen_Tran_Id] [decimal](10, 0) NULL,
	[Gen_Acc_Id] [decimal](10, 0) NULL,
	[Gen_Voucher_No] [varchar](50) NULL,
	[Gen_Acc_Head] [varchar](50) NULL,
	[Gen_Sub_Acc] [varchar](50) NULL,
	[Gen_Narration] [varchar](300) NULL,
	[Gen_LP] [varchar](9) NULL,
	[Gen_Acc_Type] [varchar](2) NULL,
	[Gen_Debit] [float] NULL,
	[Gen_Credit] [float] NULL,
	[Gen_Sort] [int] NULL,
	[Gen_F_Year] [varchar](10) NULL,
	[Gen_Status] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NULL,
	[Title] [varchar](10) NULL,
	[FirstName] [varchar](15) NULL,
	[LastName] [varchar](15) NULL,
	[Dob] [date] NULL,
	[CNIC] [varchar](15) NULL,
	[Gender] [varchar](10) NULL,
	[Marital] [varchar](20) NULL,
	[Department] [varchar](20) NULL,
	[Position] [varchar](50) NULL,
	[HireDate] [date] NULL,
	[Shift] [varchar](10) NULL,
	[Address] [varchar](30) NULL,
	[City] [varchar](10) NULL,
	[Mobile] [varchar](11) NULL,
	[HomePhone] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[Status] [varchar](10) NULL,
	[LeaveDate] [date] NULL,
	[Salary] [float] NULL,
	[Arear] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dues_Temp]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dues_Temp](
	[p_num] [decimal](10, 0) NOT NULL,
	[p_cp] [varchar](50) NULL,
	[p_due_rcv] [float] NULL,
	[p_due_rcv_date] [datetime] NULL,
	[p_due_rcv_operator] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Donor_Table]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Donor_Table](
	[DONOR_ID] [int] NULL,
	[DONOR_NAME] [varchar](50) NULL,
	[DONOR_AGE] [varchar](22) NULL,
	[DONOR_GENDER] [varchar](6) NULL,
	[DONOR_PID] [int] NULL,
	[DONOR_DATE] [date] NULL,
	[DONOR_WT] [varchar](5) NULL,
	[DONOR_HBS] [varchar](8) NULL,
	[DONOR_HCV] [varchar](8) NULL,
	[DONOR_HIV] [varchar](8) NULL,
	[DONOR_VDRL] [varchar](8) NULL,
	[DONOR_GROUP] [varchar](30) NULL,
	[PATIENT_GRP] [varchar](30) NULL,
	[DONOR_REFER] [varchar](50) NULL,
	[DONOR_SEQ] [decimal](18, 0) NULL,
	[DONOR_CP] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocList]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocList](
	[Doc_Name] [varchar](50) NOT NULL,
	[Doc_Phone] [varchar](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Company]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[CP_ID] [int] NOT NULL,
	[CP_Name] [varchar](50) NULL,
	[CP_Incharge] [varchar](50) NULL,
	[CP_Address] [varchar](150) NULL,
	[CP_City] [varchar](10) NULL,
	[CP_Tel] [varchar](15) NULL,
	[CP_Mob] [varchar](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CollectionPoint]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CollectionPoint](
	[CP_ID] [varchar](10) NULL,
	[CP_Name] [varchar](50) NULL,
	[CP_Incharge] [varchar](50) NULL,
	[CP_Address] [varchar](150) NULL,
	[CP_City] [varchar](30) NULL,
	[CP_Ordinary] [int] NULL,
	[CP_Special] [int] NULL,
	[CP_Conditional] [int] NULL,
	[CP_Tel] [varchar](15) NULL,
	[CP_Mob] [varchar](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 10/13/2019 00:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accounts](
	[Acc_No] [int] NOT NULL,
	[Acc_Head] [varchar](30) NULL,
	[Acc_Opn_Date] [date] NULL,
	[Acc_Name] [varchar](50) NULL,
	[Acc_Type] [varchar](2) NULL,
	[Acc_Balance] [decimal](18, 2) NULL,
	[Acc_Update] [date] NULL,
	[Acc_Debit] [decimal](18, 2) NULL,
	[Acc_Credit] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
