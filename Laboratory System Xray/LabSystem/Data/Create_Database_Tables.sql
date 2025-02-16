USE [XLAB]
GO
/****** Object:  Table [dbo].[VISITOR_TABLE]    Script Date: 03/10/2016 21:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VISITOR_TABLE](
	[visitor_name] [char](20) NULL,
	[contact_no] [char](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03/10/2016 21:14:00 ******/
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
/****** Object:  Table [dbo].[Tests]    Script Date: 03/10/2016 21:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tests](
	[tcode] [char](5) NOT NULL,
	[tname] [char](100) NULL,
	[tcatg] [char](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Temp]    Script Date: 03/10/2016 21:14:00 ******/
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
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 03/10/2016 21:14:00 ******/
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
/****** Object:  Table [dbo].[Statement]    Script Date: 03/10/2016 21:14:00 ******/
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
/****** Object:  Table [dbo].[RECEIPT]    Script Date: 03/10/2016 21:14:00 ******/
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
	[tqtydesc] [char](100) NULL,
	[tqty] [int] NULL,
	[trptlvl] [int] NULL,
	[trate] [int] NULL,
	[tdate] [date] NULL,
	[tmode] [char](3) NULL,
	[tgrphdr] [char](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 03/10/2016 21:14:00 ******/
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
	[p_pannel] [float] NULL,
	[p_posting] [char](1) NULL,
	[p_visitor] [char](20) NULL,
	[p_refer_2] [char](100) NULL,
	[p_don_sex] [char](6) NULL,
	[p_don_age] [char](10) NULL,
	[p_grp_hdr] [char](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ledger_Transactions]    Script Date: 03/10/2016 21:14:00 ******/
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
/****** Object:  Table [dbo].[LAB_TESTS]    Script Date: 03/10/2016 21:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_TESTS](
	[tcode] [char](5) NULL,
	[tname] [char](100) NULL,
	[tcatg] [char](50) NULL,
	[trate] [int] NULL,
	[tsample] [char](15) NULL,
	[treport] [char](50) NULL,
	[trptlvl] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LAB_RECEIPT]    Script Date: 03/10/2016 21:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LAB_RECEIPT](
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
/****** Object:  Table [dbo].[LAB_INFO]    Script Date: 03/10/2016 21:14:00 ******/
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
/****** Object:  Table [dbo].[INVENTORY]    Script Date: 03/10/2016 21:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INVENTORY](
	[INV_CODE] [char](5) NULL,
	[INV_DESCRIPTION] [char](100) NULL,
	[INV_IN_HAND] [int] NULL,
	[INV_PCK_PRICE] [float] NULL,
	[INV_UPD_DT] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INV_TRANS]    Script Date: 03/10/2016 21:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INV_TRANS](
	[TRS_DATE] [date] NULL,
	[TRS_INVOICE] [char](10) NULL,
	[TRS_CODE] [char](5) NULL,
	[TRS_DESCRIPTION] [char](200) NULL,
	[TRS_RETAILER] [char](100) NULL,
	[TRS_QTY_RCV] [int] NULL,
	[TRS_QTY_ISSU] [int] NULL,
	[TRS_QTY_BF] [int] NULL,
	[TRS_QTY_UPD] [int] NULL,
	[TRS_STATUS] [char](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gen_Temp]    Script Date: 03/10/2016 21:14:00 ******/
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
/****** Object:  Table [dbo].[Dues_Temp]    Script Date: 03/10/2016 21:14:00 ******/
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
	[p_due_rcv_operator] [char](50) NULL,
	[p_due_grp_hdr] [char](5) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CollectionPoint]    Script Date: 03/10/2016 21:14:00 ******/
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
	[CP_Tel] [char](15) NULL,
	[CP_Mob] [char](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BACKUP_TABLE]    Script Date: 03/10/2016 21:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BACKUP_TABLE](
	[BCK_DATE] [date] NOT NULL,
	[BCK_PLAN] [char](30) NOT NULL,
	[BCK_NAME] [char](30) NOT NULL,
	[BCK_STATUS] [char](8) NOT NULL,
	[BCK_PATH] [char](100) NOT NULL,
	[BCK_SCHEDULE] [char](6) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 03/10/2016 21:14:00 ******/
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
