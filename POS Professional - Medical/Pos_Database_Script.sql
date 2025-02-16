USE [POS_MED]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[UserSequence] [int] NULL,
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
/****** Object:  Table [dbo].[USERROLES]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERROLES](
	[RoleID] [int] NULL,
	[RoleName] [char](50) NULL,
	[Decription] [char](250) NULL,
	[SecurityLevel] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER_TEMP]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_MASTER_TEMP](
	[SaleID] [nvarchar](50) NULL,
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
	[LedgerPost] [tinyint] NULL,
	[Status] [varchar](50) NULL,
	[Refer] [varchar](50) NULL,
	[AreaId] [int] NULL,
	[AreaName] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER_HOLD]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_MASTER_HOLD](
	[SaleID] [nvarchar](50) NULL,
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
	[LedgerPost] [tinyint] NULL,
	[Status] [varchar](50) NULL,
	[Refer] [varchar](50) NULL,
	[AreaId] [int] NULL,
	[AreaName] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_MASTER]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_MASTER](
	[SaleID] [nvarchar](50) NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](50) NULL,
	[DateCompleted] [date] NULL,
	[SaleType] [varchar](50) NULL,
	[OfflineID] [nvarchar](100) NULL,
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
	[LedgerPost] [tinyint] NULL,
	[Status] [varchar](50) NULL,
	[Refer] [varchar](50) NULL,
	[AreaID] [int] NULL,
	[AreaName] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL_TEMP]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_DETAIL_TEMP](
	[DetailID] [nvarchar](50) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [nvarchar](50) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [int] NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[Qty] [float] NULL,
	[Disc1] [float] NULL,
	[Disc2] [float] NULL,
	[UnitCost] [float] NULL,
	[Discount] [float] NULL,
	[Amount] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[DrawerID] [varchar](50) NULL,
	[AreaId] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[Refer] [varchar](100) NULL,
	[ReferId] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL_HOLD]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_DETAIL_HOLD](
	[DetailID] [nvarchar](50) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [nvarchar](50) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [int] NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[Qty] [float] NULL,
	[Disc1] [float] NULL,
	[Disc2] [float] NULL,
	[UnitCost] [float] NULL,
	[Discount] [float] NULL,
	[Amount] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[DrawerID] [varchar](50) NULL,
	[AreaId] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[Refer] [varchar](100) NULL,
	[ReferId] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_DETAIL]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SALE_DETAIL](
	[DetailID] [nvarchar](50) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [nvarchar](50) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [int] NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[Qty] [float] NULL,
	[Disc1] [float] NULL,
	[Disc2] [float] NULL,
	[UnitCost] [float] NULL,
	[Discount] [float] NULL,
	[Amount] [float] NULL,
	[SaleStatus] [varchar](50) NULL,
	[DrawerName] [varchar](50) NULL,
	[AreaId] [int] NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[Refer] [varchar](100) NULL,
	[ReferId] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RATES_HISTORY]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RATES_HISTORY](
	[ITEM_SEQ] [int] NULL,
	[ITEM_ID] [int] NULL,
	[DATE] [date] NULL,
	[ITEM_P_PRICE] [float] NULL,
	[ITEM_WS_PRICE] [float] NULL,
	[ITEM_S_RICE] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHASE_MASTER]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PURCHASE_MASTER](
	[PrchID] [decimal](18, 0) NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](50) NULL,
	[DateCompleted] [date] NULL,
	[PrchType] [varchar](50) NULL,
	[OfflineID] [nvarchar](100) NULL,
	[SupplrID] [int] NULL,
	[SupplrName] [varchar](100) NULL,
	[PrchGross] [float] NULL,
	[PrchDiscount] [float] NULL,
	[PrchTotal] [float] NULL,
	[PrchPaid] [float] NULL,
	[PrchCredit] [float] NULL,
	[PrchReturn] [float] NULL,
	[PrchReturnDate] [date] NULL,
	[LedgerPost] [tinyint] NULL,
	[Status] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PURCHASE_DETAIL]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PURCHASE_DETAIL](
	[DetailID] [nvarchar](100) NULL,
	[DetailDate] [date] NULL,
	[PrchID] [decimal](18, 0) NULL,
	[PrchType] [varchar](50) NULL,
	[SupplrID] [int] NULL,
	[SupplrName] [varchar](100) NULL,
	[StockID] [int] NULL,
	[StockDesc] [varchar](100) NULL,
	[SalePack] [varchar](10) NULL,
	[Qty] [float] NULL,
	[Disc1] [float] NULL,
	[UnitCost] [float] NULL,
	[Amount] [float] NULL,
	[PrchStatus] [varchar](50) NULL,
	[DrawerID] [varchar](50) NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[PROD_REG_DATE] [date] NULL,
	[PROD_CODE] [int] NULL,
	[PROD_DESC] [varchar](255) NULL,
	[PROD_COMP_ID] [int] NULL,
	[PROD_COMPANY] [varchar](250) NULL,
	[PROD_PACKING] [varchar](20) NULL,
	[PROD_PACK_CONVERSION] [int] NULL,
	[PROD_STOCK] [int] NULL,
	[PROD_BAL_MIN] [int] NULL,
	[PROD_PURCH_PRICE] [decimal](8, 2) NULL,
	[PROD_WSALE_PRICE] [decimal](8, 2) NULL,
	[PROD_SALE_PRICE] [decimal](8, 2) NULL,
	[PROD_SALE_TAX] [float] NULL,
	[PROD_DISC_ALLOW] [int] NULL,
	[PROD_FOR_SALE] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LEDGERS]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LEDGERS](
	[Ledg_Date] [date] NULL,
	[Ledg_Tran_Id] [decimal](10, 0) NULL,
	[Ledg_Acc_Id] [int] NULL,
	[Ledg_Voucher_No] [varchar](50) NULL,
	[Ledg_Acc_Head] [varchar](50) NULL,
	[Ledg_Sub_Acc] [varchar](50) NULL,
	[Ledg_Narration] [varchar](300) NULL,
	[Ledg_Tran_Type] [varchar](9) NULL,
	[Ledg_Debit] [decimal](18, 2) NULL,
	[Ledg_Credit] [decimal](18, 2) NULL,
	[Ledg_Balance] [decimal](18, 2) NULL,
	[Ledg_Sort] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INFO]    Script Date: 08/24/2021 00:58:03 ******/
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
/****** Object:  Table [dbo].[COMPANY]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COMPANY](
	[CompanyCode] [int] NULL,
	[CompanyName] [varchar](100) NULL,
	[CompanyAreaCode] [int] NULL,
	[CompanyArea] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COLLECTIONPOINT]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COLLECTIONPOINT](
	[CP_ID] [int] NULL,
	[CP_Name] [varchar](50) NULL,
	[CP_Address] [varchar](150) NULL,
	[CP_City] [varchar](30) NULL,
	[CP_Tel] [varchar](15) NULL,
	[CP_Mob] [varchar](11) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CITY]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CITY](
	[City_ID] [int] NOT NULL,
	[City_Pin] [int] NULL,
	[City_Name] [varchar](100) NULL,
	[City_SName] [varchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AREA]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AREA](
	[Area_Id] [int] NOT NULL,
	[Area_Name] [varchar](100) NULL,
	[Area_City] [int] NULL,
	[Area_SName] [varchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ACCOUNTS]    Script Date: 08/24/2021 00:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ACCOUNTS](
	[Acc_No] [int] NOT NULL,
	[Acc_Head] [varchar](30) NULL,
	[Acc_Reg_Type] [varchar](50) NULL,
	[Acc_Name] [varchar](50) NULL,
	[Acc_Type] [varchar](2) NULL,
	[Acc_Debit] [decimal](18, 2) NULL,
	[Acc_Credit] [decimal](18, 2) NULL,
	[Acc_Balance] [decimal](18, 2) NULL,
	[Acc_Reg_On] [date] NULL,
	[Acc_Address] [varchar](200) NULL,
	[Acc_Area] [varchar](100) NULL,
	[Acc_BankName] [varchar](100) NULL,
	[Acc_BankAccNo] [varchar](50) NULL,
	[Acc_Phone] [varchar](50) NULL,
	[Acc_Mobile] [varchar](13) NULL,
	[Acc_CrDays] [int] NULL,
	[Acc_CrLimit] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
