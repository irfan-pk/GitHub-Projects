USE [POSR]
GO
/****** Object:  Table [dbo].[WAITERS]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WAITERS](
	[WAITER_ID] [int] NULL,
	[WAITER_NAME] [varchar](100) NULL,
	[WAITER_ADDRESS] [varchar](200) NULL,
	[WAITER_CONTACT] [varchar](11) NULL,
	[WAITER_NIC] [varchar](18) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsersRoles]    Script Date: 01/28/2018 00:23:18 ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](200) NULL,
	[Name] [varchar](100) NULL,
	[UserRole] [varchar](50) NULL,
	[SecurityLevel] [int] NULL,
	[Active] [bit] NULL,
	[CardNumber] [varchar](200) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TABLE_MASTER]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TABLE_MASTER](
	[SaleID] [decimal](18, 0) NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](50) NULL,
	[DateCompleted] [date] NULL,
	[SaleType] [varchar](50) NULL,
	[OfflineID] [varchar](100) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[SaleTotal] [decimal](18, 0) NULL,
	[SalePaid] [decimal](18, 0) NULL,
	[SaleDiscount] [decimal](18, 0) NULL,
	[SaleChange] [decimal](18, 0) NULL,
	[SaleStatus] [int] NULL,
	[SaleCredit] [decimal](18, 0) NULL,
	[SaleReturn] [decimal](18, 0) NULL,
	[SaleRecovery] [decimal](18, 0) NULL,
	[DateRecovery] [date] NULL,
	[ServiceChrg] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TABLE_DETAIL]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TABLE_DETAIL](
	[DetailID] [decimal](18, 0) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [decimal](18, 0) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [char](50) NULL,
	[StockDesc] [varchar](100) NULL,
	[SaleTable] [varchar](10) NULL,
	[UnitCost] [float] NULL,
	[Qty] [float] NULL,
	[Price] [float] NULL,
	[TableStatus] [varchar](10) NULL,
	[DrawerID] [int] NULL,
	[TaxPercentage] [float] NULL,
	[PriceInc] [float] NULL,
	[TotalPriceExcl] [float] NULL,
	[TotalPriceInc] [float] NULL,
	[DiscountDetailID] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SUPPLIERS_PAYM]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SUPPLIERS_PAYM](
	[Supl_Code] [int] NULL,
	[Supl_Tr_Dt] [date] NULL,
	[Supl_Tr_ID] [decimal](18, 0) NULL,
	[Supl_Name] [char](50) NULL,
	[Supl_Desc] [char](200) NULL,
	[Supl_Opn_Bal] [decimal](18, 2) NULL,
	[Supl_Debit] [decimal](18, 2) NULL,
	[Supl_Credit] [decimal](18, 2) NULL,
	[Supl_Balance] [decimal](18, 2) NULL,
	[Supl_Upt_dt] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SUPPLIERS]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SUPPLIERS](
	[Supl_Code] [int] NULL,
	[Supl_Name] [char](50) NULL,
	[Supl_Address] [char](150) NULL,
	[Supl_City] [char](10) NULL,
	[Supl_Tel] [char](15) NULL,
	[Supl_Mob] [char](11) NULL,
	[Supl_Balance] [decimal](18, 2) NULL,
	[Supl_Upd_dt] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER_TEMP]    Script Date: 01/28/2018 00:23:18 ******/
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
	[SaleTotal] [decimal](18, 0) NULL,
	[SalePaid] [decimal](18, 0) NULL,
	[SaleDiscount] [decimal](18, 0) NULL,
	[SaleChange] [decimal](18, 0) NULL,
	[SaleStatus] [int] NULL,
	[SaleCredit] [decimal](18, 0) NULL,
	[SaleReturn] [decimal](18, 0) NULL,
	[SaleRecovery] [decimal](18, 0) NULL,
	[DateRecovery] [date] NULL,
	[ServiceChrg] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER_HOLD]    Script Date: 01/28/2018 00:23:18 ******/
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
	[SaleTotal] [decimal](18, 0) NULL,
	[SalePaid] [decimal](18, 0) NULL,
	[SaleDiscount] [int] NULL,
	[SaleChange] [decimal](18, 0) NULL,
	[SaleStatus] [int] NULL,
	[SaleCredit] [decimal](18, 0) NULL,
	[SaleReturn] [decimal](18, 0) NULL,
	[SaleRecovery] [decimal](18, 0) NULL,
	[DateRecovery] [date] NULL,
	[ServiceChrg] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER]    Script Date: 01/28/2018 00:23:18 ******/
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
	[SaleTotal] [decimal](18, 0) NULL,
	[SalePaid] [decimal](18, 0) NULL,
	[SaleDiscount] [decimal](18, 0) NULL,
	[SaleChange] [decimal](18, 0) NULL,
	[SaleStatus] [int] NULL,
	[SaleCredit] [decimal](18, 0) NULL,
	[SaleReturn] [decimal](18, 0) NULL,
	[SaleRecovery] [decimal](18, 0) NULL,
	[DateRecovery] [date] NULL,
	[ServiceChrg] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL_TEMP]    Script Date: 01/28/2018 00:23:18 ******/
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
	[StockID] [char](50) NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[UnitCost] [float] NULL,
	[Qty] [float] NULL,
	[Price] [float] NULL,
	[SaleStatus] [varchar](10) NULL,
	[DrawerID] [int] NULL,
	[TaxPercentage] [float] NULL,
	[PriceInc] [float] NULL,
	[TotalPriceExcl] [float] NULL,
	[TotalPriceInc] [float] NULL,
	[DiscountDetailID] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL_HOLD]    Script Date: 01/28/2018 00:23:18 ******/
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
	[StockID] [char](50) NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[UnitCost] [float] NULL,
	[Qty] [float] NULL,
	[Price] [float] NULL,
	[SaleStatus] [varchar](10) NULL,
	[DrawerID] [int] NULL,
	[TaxPercentage] [float] NULL,
	[PriceInc] [float] NULL,
	[TotalPriceExcl] [float] NULL,
	[TotalPriceInc] [float] NULL,
	[DiscountDetailID] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL]    Script Date: 01/28/2018 00:23:18 ******/
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
	[StockID] [char](50) NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[UnitCost] [float] NULL,
	[Qty] [float] NULL,
	[Price] [float] NULL,
	[SaleStatus] [varchar](10) NULL,
	[DrawerID] [int] NULL,
	[TaxPercentage] [float] NULL,
	[PriceInc] [float] NULL,
	[TotalPriceExcl] [float] NULL,
	[TotalPriceInc] [float] NULL,
	[DiscountDetailID] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PURCHASE]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PURCHASE](
	[PRCH_TR_ID] [decimal](18, 0) NULL,
	[PRCH_CD] [char](50) NULL,
	[PRCH_DESC] [char](200) NULL,
	[PRCH_CATG] [char](50) NULL,
	[PRCH_PACK] [char](10) NULL,
	[PRCH_PRICE] [float] NULL,
	[PRCH_QTY] [int] NULL,
	[PRCH_OLD_QTY] [int] NULL,
	[PRCH_BAL_MIN] [int] NULL,
	[PRCH_SCH1_PRICE] [float] NULL,
	[PRCH_SCH1_ONHAND] [int] NULL,
	[PRCH_SCH2_PRICE] [float] NULL,
	[PRCH_SCH2_ONHAND] [int] NULL,
	[PRCH_SCH3_PRICE] [float] NULL,
	[PRCH_SCH3_ONHAND] [int] NULL,
	[PRCH_VAT] [float] NULL,
	[PRCH_ITAX] [float] NULL,
	[PRCH_EX_DUTY] [float] NULL,
	[PRCH_PROFIT] [float] NULL,
	[PRCH_DISC_MRG] [float] NULL,
	[PRCH_SPRICE] [float] NULL,
	[PRCH_DATE] [date] NULL,
	[PRCH_SUPPLIER] [char](200) NULL,
	[PRCH_STATUS] [char](10) NULL,
	[PRCH_INVOICE] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[PROD_CD] [char](50) NULL,
	[PROD_DESC] [char](200) NULL,
	[PROD_CATG] [char](50) NULL,
	[PROD_PACK] [char](10) NULL,
	[PROD_PPRICE] [float] NULL,
	[PROD_ONHAND] [int] NULL,
	[PROD_BAL_MIN] [int] NULL,
	[PROD_SCH1_PRICE] [float] NULL,
	[PROD_SCH1_ONHAND] [int] NULL,
	[PROD_SCH2_PRICE] [float] NULL,
	[PROD_SCH2_ONHAND] [int] NULL,
	[PROD_SCH3_PRICE] [float] NULL,
	[PROD_SCH3_ONHAND] [int] NULL,
	[PROD_VAT] [float] NULL,
	[PROD_ITAX] [float] NULL,
	[PROD_EX_DUTY] [float] NULL,
	[PROD_PROFIT] [float] NULL,
	[PROD_DISC_MRG] [float] NULL,
	[PROD_SPRICE] [float] NULL,
	[PROD_DATE] [date] NULL,
	[PROD_UPD_ON] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ITEMS]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ITEMS](
	[ITEM_CODE] [char](50) NULL,
	[ITEM_NAME] [char](200) NULL,
	[ITEM_CATG] [char](50) NULL,
	[ITEM_PCKG] [char](10) NULL,
	[ITEM_PRICE] [float] NULL,
	[ITEM_CATG_CD] [char](5) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INFO]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INFO](
	[REG_NAME] [char](400) NULL,
	[REG_ADDRESS] [char](400) NULL,
	[TEL1] [char](11) NULL,
	[TEL2] [char](11) NULL,
	[MOBILE1] [char](11) NULL,
	[MOBILE2] [char](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMERS_PAYM]    Script Date: 01/28/2018 00:23:18 ******/
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
	[Cust_Name] [char](50) NULL,
	[Cust_Desc] [char](200) NULL,
	[Cust_Opn_Bal] [decimal](18, 2) NULL,
	[Cust_Debit] [decimal](18, 2) NULL,
	[Cust_Credit] [decimal](18, 2) NULL,
	[Cust_Balance] [decimal](18, 2) NULL,
	[Cust_Upt_dt] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[Cust_Code] [int] NULL,
	[Cust_Name] [char](50) NULL,
	[Cust_Address] [char](150) NULL,
	[Cust_City] [char](10) NULL,
	[Cust_Tel] [char](15) NULL,
	[Cust_Mob] [char](11) NULL,
	[Cust_Balance] [decimal](18, 2) NULL,
	[Cust_Upd_dt] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUST_PURCHASES]    Script Date: 01/28/2018 00:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUST_PURCHASES](
	[PRCH_TR_ID] [decimal](18, 0) NULL,
	[PRCH_CD] [char](50) NULL,
	[PRCH_DESC] [char](200) NULL,
	[PRCH_CATG] [char](50) NULL,
	[PRCH_PACK] [char](10) NULL,
	[PRCH_PRICE] [float] NULL,
	[PRCH_QTY] [int] NULL,
	[PRCH_OLD_QTY] [int] NULL,
	[PRCH_BAL_MIN] [int] NULL,
	[PRCH_SCH1_PRICE] [float] NULL,
	[PRCH_SCH1_ONHAND] [int] NULL,
	[PRCH_SCH2_PRICE] [float] NULL,
	[PRCH_SCH2_ONHAND] [int] NULL,
	[PRCH_SCH3_PRICE] [float] NULL,
	[PRCH_SCH3_ONHAND] [int] NULL,
	[PRCH_VAT] [float] NULL,
	[PRCH_ITAX] [float] NULL,
	[PRCH_EX_DUTY] [float] NULL,
	[PRCH_PROFIT] [float] NULL,
	[PRCH_DISC_MRG] [float] NULL,
	[PRCH_SPRICE] [float] NULL,
	[PRCH_DATE] [date] NULL,
	[PRCH_SUPPLIER] [char](200) NULL,
	[PRCH_STATUS] [char](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
