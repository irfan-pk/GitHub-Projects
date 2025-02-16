USE [master]
GO
/****** Object:  Database [POS]    Script Date: 4/9/2020 10:49:07 PM ******/
CREATE DATABASE [POS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POS', FILENAME = N'D:\Databases\POS.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'POS_log', FILENAME = N'D:\Databases\POS_log.ldf' , SIZE = 12288KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [POS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POS] SET ARITHABORT OFF 
GO
ALTER DATABASE [POS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POS] SET RECOVERY FULL 
GO
ALTER DATABASE [POS] SET  MULTI_USER 
GO
ALTER DATABASE [POS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [POS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'POS', N'ON'
GO
ALTER DATABASE [POS] SET QUERY_STORE = OFF
GO
USE [POS]
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[CATEGORY] [varchar](255) NULL,
	[DEPARTMENT] [varchar](255) NULL,
	[SUB_CATEGORY] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[CUSTOMERS_PAYM]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[DEPARTMENTS]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTMENTS](
	[Head_Category] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INFO]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[ITEMS]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEMS](
	[ITEM_CODE] [varchar](50) NULL,
	[ITEM_NAME] [varchar](255) NULL,
	[ITEM_HEAD] [varchar](255) NULL,
	[ITEM_CATG] [varchar](555) NULL,
	[ITEM_SUB_CATG] [varchar](255) NULL,
	[ITEM_PCKG] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITEMTYPES]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEMTYPES](
	[CATEGORY] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[PROD_CODE] [varchar](50) NULL,
	[PROD_BAR_CODE] [varchar](255) NULL,
	[PROD_DESC] [varchar](255) NULL,
	[PROD_HEAD] [varchar](255) NULL,
	[PROD_CATG] [varchar](255) NULL,
	[PROD_SUB_CATG] [varchar](255) NULL,
	[PROD_SUPPLR] [varchar](100) NULL,
	[PROD_PACKING] [varchar](20) NULL,
	[PROD_UNITS] [int] NULL,
	[PROD_QTY_PER_UNIT] [int] NULL,
	[PROD_STOCK] [decimal](8, 0) NULL,
	[PROD_BAL_MIN] [int] NULL,
	[PROD_PURCH_PRICE] [decimal](8, 2) NULL,
	[PROD_WSALE_PRICE] [decimal](8, 2) NULL,
	[PROD_SALE_PRICE] [decimal](8, 2) NULL,
	[PROD_UPD_ON] [date] NULL,
	[PROD_FOR_SALE] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHASE]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PURCHASE](
	[PRCH_TR_ID] [decimal](8, 0) NULL,
	[PRCH_INVOICE] [int] NULL,
	[PRCH_DATE] [date] NULL,
	[PRCH_PROD_CD] [varchar](50) NULL,
	[PRCH_DESC] [varchar](255) NULL,
	[PRCH_SUPPLIER] [varchar](255) NULL,
	[PRCH_HEAD] [varchar](255) NULL,
	[PRCH_CATG] [varchar](255) NULL,
	[PRCH_SUB_CATG] [varchar](255) NULL,
	[PRCH_PACK] [varchar](50) NULL,
	[PRCH_QTY] [int] NULL,
	[PRCH_OLD_QTY] [int] NULL,
	[PRCH_PRICE] [decimal](8, 2) NULL,
	[PRCH_STATUS] [varchar](20) NULL,
	[PRCH_QTY_PER_UNIT] [int] NULL,
	[PRCH_OLD_PRICE] [decimal](8, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_DETAIL]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_DETAIL](
	[DetailID] [nvarchar](18) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [nvarchar](18) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [char](50) NULL,
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
	[ItemDues] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_DETAIL_HOLD]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_DETAIL_HOLD](
	[DetailID] [nvarchar](18) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [nvarchar](18) NULL,
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
	[SubCategory] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_DETAIL_TEMP]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_DETAIL_TEMP](
	[DetailID] [nvarchar](18) NULL,
	[DetailDate] [date] NULL,
	[SaleID] [nvarchar](18) NULL,
	[SaleType] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[CustomerName] [varchar](100) NULL,
	[StockID] [char](50) NULL,
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
	[SubCategory] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_MASTER]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_MASTER](
	[SaleID] [nvarchar](18) NULL,
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
/****** Object:  Table [dbo].[SALE_MASTER_HOLD]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_MASTER_HOLD](
	[SaleID] [nvarchar](18) NULL,
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
/****** Object:  Table [dbo].[SALE_MASTER_TEMP]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_MASTER_TEMP](
	[SaleID] [nvarchar](18) NULL,
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
/****** Object:  Table [dbo].[SUPPLIERS]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPLIERS](
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
/****** Object:  Table [dbo].[SUPPLIERS_JOURNAL]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPLIERS_JOURNAL](
	[Supl_Code] [int] NULL,
	[Supl_Tr_Dt] [date] NULL,
	[Supl_Tr_ID] [decimal](18, 0) NULL,
	[Supl_Name] [varchar](100) NULL,
	[Supl_Desc] [varchar](200) NULL,
	[Supl_Opn_Bal] [decimal](18, 2) NULL,
	[Supl_Debit] [decimal](18, 2) NULL,
	[Supl_Credit] [decimal](18, 2) NULL,
	[Supl_Balance] [decimal](18, 2) NULL,
	[Supl_Upt_dt] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[UserName] [varchar](200) NULL,
	[UserId] [varchar](200) NULL,
	[Password] [varchar](200) NULL,
	[UserRole] [varchar](50) NULL,
	[SecurityLevel] [int] NULL,
	[Active] [bit] NULL,
	[CardNumber] [varchar](15) NULL,
	[CounterID] [varchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERSROLES]    Script Date: 4/9/2020 10:49:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERSROLES](
	[RoleID] [int] NULL,
	[RoleName] [char](50) NULL,
	[Decription] [char](250) NULL,
	[SecurityLevel] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [POS] SET  READ_WRITE 
GO
