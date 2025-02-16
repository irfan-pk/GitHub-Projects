USE [POS_HW]
GO
/****** Object:  Table [dbo].[VENDORS_JOURNAL]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENDORS_JOURNAL](
	[Supl_Code] [int] NULL,
	[Supl_Tr_Dt] [date] NULL,
	[Supl_Tr_ID] [decimal](18, 0) NULL,
	[Supl_Name] [varchar](50) NULL,
	[Supl_Desc] [varchar](200) NULL,
	[Supl_Opn_Bal] [decimal](18, 2) NULL,
	[Supl_Debit] [decimal](18, 2) NULL,
	[Supl_Credit] [decimal](18, 2) NULL,
	[Supl_Balance] [decimal](18, 2) NULL,
	[Supl_Upt_dt] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENDORS]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENDORS](
	[Supl_Code] [int] NULL,
	[Supl_Name] [varchar](50) NULL,
	[Supl_Address] [varchar](150) NULL,
	[Supl_City] [varchar](50) NULL,
	[Supl_Tel] [varchar](15) NULL,
	[Supl_Mob] [varchar](11) NULL,
	[Supl_Balance] [decimal](18, 2) NULL,
	[Supl_Upd_dt] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsersRoles]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsersRoles](
	[RoleID] [int] NULL,
	[RoleName] [char](50) NULL,
	[Decription] [char](250) NULL,
	[SecurityLevel] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [varchar](255) NULL,
	[UserId] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[UserRole] [varchar](255) NULL,
	[SecurityLevel] [int] NULL,
	[Active] [bit] NULL,
	[CardNumber] [varchar](15) NULL,
	[CounterID] [varchar](5) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TYPES]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TYPES](
	[CATEGORY] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER_TEMP]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_MASTER_TEMP](
	[SaleID] [decimal](18, 0) NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](50) NULL,
	[DateCompleted] [date] NULL,
	[SaleType] [varchar](50) NULL,
	[OfflineID] [varchar](100) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[SaleGross] [float] NULL,
	[SaleDiscount] [float] NULL,
	[SaleTotal] [float] NULL,
	[SalePaid] [float] NULL,
	[SaleChange] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[SaleCredit] [float] NULL,
	[SaleReturn] [float] NULL,
	[SaleRecovery] [float] NULL,
	[DateRecovery] [date] NULL,
	[LedgerPost] [tinyint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER_HOLD]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_MASTER_HOLD](
	[SaleID] [decimal](18, 0) NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](50) NULL,
	[DateCompleted] [date] NULL,
	[SaleType] [varchar](50) NULL,
	[OfflineID] [varchar](100) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[SaleGross] [float] NULL,
	[SaleDiscount] [int] NULL,
	[SaleTotal] [float] NULL,
	[SalePaid] [float] NULL,
	[SaleChange] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[SaleCredit] [float] NULL,
	[SaleReturn] [float] NULL,
	[SaleRecovery] [float] NULL,
	[DateRecovery] [date] NULL,
	[LedgerPost] [tinyint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_MASTER](
	[SaleID] [decimal](18, 0) NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](50) NULL,
	[DateCompleted] [date] NULL,
	[SaleType] [varchar](50) NULL,
	[OfflineID] [varchar](100) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[SaleGross] [float] NULL,
	[SaleDiscount] [float] NULL,
	[SaleTotal] [float] NULL,
	[SalePaid] [float] NULL,
	[SaleChange] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[SaleCredit] [float] NULL,
	[SaleReturn] [float] NULL,
	[SaleRecovery] [float] NULL,
	[DateRecovery] [date] NULL,
	[LedgerPost] [tinyint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL_TEMP]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_DETAIL_TEMP](
	[DetailID] [decimal](18, 0) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [decimal](18, 0) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [varchar](50) NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[UnitCost] [float] NULL,
	[Qty] [float] NULL,
	[Price] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[DrawerID] [int] NULL,
	[TaxPercentage] [float] NULL,
	[PriceInc] [float] NULL,
	[HeadCategory] [varchar](255) NULL,
	[Category] [varchar](255) NULL,
	[DiscountDetailID] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[SubCategory] [varchar](255) NULL,
	[ItemSize] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL_HOLD]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_DETAIL_HOLD](
	[DetailID] [decimal](18, 0) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [decimal](18, 0) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [varchar](50) NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[UnitCost] [float] NULL,
	[Qty] [float] NULL,
	[Price] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[DrawerID] [int] NULL,
	[TaxPercentage] [float] NULL,
	[PriceInc] [float] NULL,
	[HeadCategory] [varchar](255) NULL,
	[Category] [varchar](255) NULL,
	[DiscountDetailID] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[SubCategory] [varchar](255) NULL,
	[ItemSize] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_DETAIL](
	[DetailID] [decimal](18, 0) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [decimal](18, 0) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [varchar](50) NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[UnitCost] [float] NULL,
	[Qty] [float] NULL,
	[Price] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[DrawerID] [int] NULL,
	[TaxPercentage] [float] NULL,
	[PriceInc] [float] NULL,
	[HeadCategory] [varchar](255) NULL,
	[Category] [varchar](255) NULL,
	[DiscountDetailID] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[SubCategory] [varchar](255) NULL,
	[ItemDues] [float] NULL,
	[ItemSize] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PURCHASE]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PURCHASE](
	[PRCH_TR_ID] [decimal](8, 0) NULL,
	[PRCH_INVOICE] [int] NULL,
	[PRCH_DATE] [date] NULL,
	[PRCH_PROD_CD] [varchar](50) NULL,
	[PRCH_DESC] [varchar](255) NULL,
	[PRCH_SUPPLIER] [varchar](255) NULL,
	[PRCH_HEAD] [varchar](255) NULL,
	[PRCH_CATG] [varchar](100) NULL,
	[PRCH_PACK] [varchar](50) NULL,
	[PRCH_QTY] [int] NULL,
	[PRCH_OLD_QTY] [int] NULL,
	[PRCH_PRICE] [decimal](8, 2) NULL,
	[PRCH_STATUS] [varchar](20) NULL,
	[PRCH_QTY_PER_UNIT] [int] NULL,
	[PRCH_OLD_PRICE] [decimal](8, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[PROD_CODE] [varchar](50) NOT NULL,
	[PROD_DESC] [varchar](255) NULL,
	[PROD_HEAD] [varchar](255) NULL,
	[PROD_CATG] [varchar](255) NULL,
	[PROD_BRAND] [varchar](255) NULL,
	[PROD_SIZE] [varchar](100) NULL,
	[PROD_PACKING] [varchar](50) NULL,
	[PROD_QTY_PER_UNIT] [int] NULL,
	[PROD_IN_HAND] [int] NULL,
	[PROD_BAL_MIN] [int] NULL,
	[PROD_PURCH_PRICE] [decimal](8, 2) NULL,
	[PROD_WSALE_PRICE] [decimal](8, 2) NULL,
	[PROD_RETAIL_PRICE] [decimal](8, 2) NULL,
	[PROD_UPD_ON] [date] NULL,
	[PROD_WARNING] [bit] NULL,
 CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED 
(
	[PROD_CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INFO]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INFO](
	[REG_NAME] [varchar](400) NULL,
	[REG_ADDRESS] [varchar](400) NULL,
	[TEL1] [varchar](11) NULL,
	[TEL2] [varchar](11) NULL,
	[MOBILE1] [varchar](11) NULL,
	[MOBILE2] [varchar](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HEADS]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HEADS](
	[HEAD_NAME] [varchar](255) NULL,
	[HEAD_ID] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMERS_PAYM]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMERS_PAYM](
	[Cust_Code] [int] NULL,
	[Cust_Tr_Dt] [date] NULL,
	[Cust_Tr_ID] [decimal](18, 0) NULL,
	[Cust_Name] [varchar](50) NULL,
	[Cust_Desc] [varchar](200) NULL,
	[Cust_Opn_Bal] [decimal](18, 2) NULL,
	[Cust_Debit] [decimal](18, 2) NULL,
	[Cust_Credit] [decimal](18, 2) NULL,
	[Cust_Balance] [decimal](18, 2) NULL,
	[Cust_Upt_dt] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[Cust_Code] [int] NULL,
	[Cust_Name] [varchar](50) NULL,
	[Cust_Address] [varchar](150) NULL,
	[Cust_City] [varchar](20) NULL,
	[Cust_Tel] [varchar](15) NULL,
	[Cust_Mob] [varchar](11) NULL,
	[Cust_Balance] [decimal](18, 2) NULL,
	[Cust_Upd_dt] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 10/19/2020 00:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[CATEGORY_ID] [int] NULL,
	[HEAD] [varchar](255) NULL,
	[CATEGORY] [varchar](255) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
