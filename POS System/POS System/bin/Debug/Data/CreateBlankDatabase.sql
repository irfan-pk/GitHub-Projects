USE [POS]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[UserRoles]    Script Date: 03/28/2017 01:21:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserRoles](
	[RoleID] [int] NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[Description] [varchar](250) NULL,
	[SecurityLevel] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TABLE_MASTER]    Script Date: 03/28/2017 01:21:26 ******/
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
	[SaleTotal] [float] NULL,
	[SalePaid] [float] NULL,
	[SaleDiscount] [float] NULL,
	[SaleChange] [float] NULL,
	[SaleStatus] [int] NULL,
	[SaleCredit] [float] NULL,
	[SaleReturn] [float] NULL,
	[SaleRecovery] [float] NULL,
	[DateRecovery] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TABLE_DETAIL]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[SUPPLIERS_PAYM]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[SUPPLIERS]    Script Date: 03/28/2017 01:21:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SUPPLIERS](
	[Supl_Code] [int] NOT NULL,
	[Supl_Name] [char](50) NULL,
	[Supl_Address] [char](150) NULL,
	[Supl_City] [char](10) NULL,
	[Supl_Tel] [char](15) NULL,
	[Supl_Mob] [char](11) NULL,
	[Supl_Balance] [decimal](18, 2) NULL,
	[Supl_Upd_dt] [date] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Supl_Code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER_TEMP]    Script Date: 03/28/2017 01:21:26 ******/
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
	[SaleTotal] [float] NULL,
	[SalePaid] [float] NULL,
	[SaleDiscount] [float] NULL,
	[SaleChange] [float] NULL,
	[SaleStatus] [int] NULL,
	[SaleCredit] [float] NULL,
	[SaleReturn] [float] NULL,
	[SaleRecovery] [float] NULL,
	[DateRecovery] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER_HOLD]    Script Date: 03/28/2017 01:21:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_MASTER_HOLD](
	[SaleID] [decimal](18, 0) NOT NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](50) NULL,
	[DateCompleted] [date] NULL,
	[SaleType] [varchar](50) NULL,
	[OfflineID] [varchar](100) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[SaleTotal] [float] NULL,
	[SalePaid] [float] NULL,
	[SaleDiscount] [int] NULL,
	[SaleChange] [float] NULL,
	[SaleStatus] [int] NULL,
	[SaleCredit] [float] NULL,
	[SaleReturn] [float] NULL,
	[SaleRecovery] [float] NULL,
	[DateRecovery] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER]    Script Date: 03/28/2017 01:21:26 ******/
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
	[SaleTotal] [float] NULL,
	[SalePaid] [float] NULL,
	[SaleDiscount] [float] NULL,
	[SaleChange] [float] NULL,
	[SaleStatus] [int] NULL,
	[SaleCredit] [float] NULL,
	[SaleReturn] [float] NULL,
	[SaleRecovery] [float] NULL,
	[DateRecovery] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL_TEMP]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[SALE_DETAIL_HOLD]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[SALE_DETAIL]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[PURCHASE]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 03/28/2017 01:21:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[PROD_CD] [char](50) NOT NULL,
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
	[PROD_UPD_ON] [date] NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[PROD_CD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ITEMS]    Script Date: 03/28/2017 01:21:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ITEMS](
	[ITEM_CODE] [char](50) NOT NULL,
	[ITEM_NAME] [char](200) NULL,
	[ITEM_CATG] [char](50) NULL,
	[ITEM_PCKG] [char](10) NULL,
	[ITEM_PRICE] [float] NULL,
	[ITEM_CATG_CD] [char](5) NULL,
 CONSTRAINT [PK_ITEMS] PRIMARY KEY CLUSTERED 
(
	[ITEM_CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INFO]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[CUSTOMERS_PAYM]    Script Date: 03/28/2017 01:21:26 ******/
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
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 03/28/2017 01:21:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[Cust_Code] [int] NOT NULL,
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
/****** Object:  Table [dbo].[CUST_PURCHASES]    Script Date: 03/28/2017 01:21:26 ******/
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
	[PRCH_DATE] [date] NOT NULL,
	[PRCH_SUPPLIER] [char](200) NULL,
	[PRCH_STATUS] [char](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_PURCHASE_PRCH_TR_ID]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[PURCHASE] ADD  CONSTRAINT [DF_PURCHASE_PRCH_TR_ID]  DEFAULT ((0)) FOR [PRCH_TR_ID]
GO
/****** Object:  Default [DF_PURCHASE_PRCH_INVOICE]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[PURCHASE] ADD  CONSTRAINT [DF_PURCHASE_PRCH_INVOICE]  DEFAULT ((0)) FOR [PRCH_INVOICE]
GO
/****** Object:  Default [DF_SALE_MASTER_DrawerID]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_DrawerID]  DEFAULT ((0)) FOR [DrawerID]
GO
/****** Object:  Default [DF_SALE_MASTER_CustomerID]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_CustomerID]  DEFAULT ((0)) FOR [CustomerID]
GO
/****** Object:  Default [DF_SALE_MASTER_CustomerName]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_CustomerName]  DEFAULT ('x') FOR [CustomerName]
GO
/****** Object:  Default [DF_SALE_MASTER_SaleTotal]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_SaleTotal]  DEFAULT ((0)) FOR [SaleTotal]
GO
/****** Object:  Default [DF_SALE_MASTER_SaleDiscount]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_SaleDiscount]  DEFAULT ((0)) FOR [SaleDiscount]
GO
/****** Object:  Default [DF_SALE_MASTER_Change]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_Change]  DEFAULT ((0)) FOR [SaleChange]
GO
/****** Object:  Default [DF_SALE_MASTER_SaleStatus]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_SaleStatus]  DEFAULT ((0)) FOR [SaleStatus]
GO
/****** Object:  Default [DF_SALE_MASTER_SaleCredit]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_SaleCredit]  DEFAULT ((0)) FOR [SaleCredit]
GO
/****** Object:  Default [DF_SALE_MASTER_SaleReturn]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_SaleReturn]  DEFAULT ((0)) FOR [SaleReturn]
GO
/****** Object:  Default [DF_SALE_MASTER_SaleRecovery]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_SaleRecovery]  DEFAULT ((0)) FOR [SaleRecovery]
GO
/****** Object:  Default [DF_SALE_MASTER_DateRecovery]    Script Date: 03/28/2017 01:21:26 ******/
ALTER TABLE [dbo].[SALE_MASTER] ADD  CONSTRAINT [DF_SALE_MASTER_DateRecovery]  DEFAULT ('2017-01-01') FOR [DateRecovery]
GO
