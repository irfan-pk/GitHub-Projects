USE [master]
GO
/****** Object:  Database [POS_MED]    Script Date: 7/17/2021 3:39:11 PM ******/
CREATE DATABASE [POS_MED] ON  PRIMARY 
( NAME = N'POS_MED', FILENAME = N'D:\Databases\POS_MED.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'POS_MED_log', FILENAME = N'D:\Databases\POS_MED_log.ldf' , SIZE = 6272KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [POS_MED] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POS_MED].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POS_MED] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POS_MED] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POS_MED] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POS_MED] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POS_MED] SET ARITHABORT OFF 
GO
ALTER DATABASE [POS_MED] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POS_MED] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POS_MED] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POS_MED] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POS_MED] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POS_MED] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POS_MED] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POS_MED] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POS_MED] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POS_MED] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POS_MED] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POS_MED] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POS_MED] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POS_MED] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POS_MED] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POS_MED] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POS_MED] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POS_MED] SET RECOVERY FULL 
GO
ALTER DATABASE [POS_MED] SET  MULTI_USER 
GO
ALTER DATABASE [POS_MED] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POS_MED] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'POS_MED', N'ON'
GO
USE [POS_MED]
GO
/****** Object:  Table [dbo].[ACCOUNTS]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[AREA]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AREA](
	[Area_Id] [int] NOT NULL,
	[Area_Name] [varchar](100) NULL,
	[Area_City] [int] NULL,
	[Area_SName] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 7/17/2021 3:39:11 PM ******/
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
/****** Object:  Table [dbo].[CITY]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CITY](
	[City_ID] [int] NOT NULL,
	[City_Pin] [int] NULL,
	[City_Name] [varchar](100) NULL,
	[City_SName] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COLLECTIONPOINT]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[COMPANY]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPANY](
	[CompanyCode] [int] NULL,
	[CompanyName] [varchar](100) NULL,
	[CompanyAreaCode] [int] NULL,
	[CompanyArea] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 7/17/2021 3:39:11 PM ******/
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
/****** Object:  Table [dbo].[DEPARTMENTS]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTMENTS](
	[Head_Category] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INFO]    Script Date: 7/17/2021 3:39:11 PM ******/
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
/****** Object:  Table [dbo].[ITEMTYPES]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEMTYPES](
	[CATEGORY] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LEDGERS]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LEDGERS](
	[Ledg_Date] [date] NULL,
	[Ledg_Tran_Id] [decimal](10, 0) NULL,
	[Ledg_Acc_Id] [int] NULL,
	[Ledg_Voucher_No] [varchar](50) NULL,
	[Ledg_Acc_Head] [varchar](50) NULL,
	[Ledg_Sub_Acc] [varchar](50) NULL,
	[Ledg_Narration] [varchar](300) NULL,
	[Ledg_Acc_Type] [varchar](9) NULL,
	[Ledg_Debit] [decimal](18, 2) NULL,
	[Ledg_Credit] [decimal](18, 2) NULL,
	[Ledg_Balance] [decimal](18, 2) NULL,
	[Ledg_Sort] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[PROD_CODE] [int] NULL,
	[PROD_BAR_CODE] [varchar](255) NULL,
	[PROD_DESC] [varchar](255) NULL,
	[PROD_SUPPLR_ID] [int] NULL,
	[PROD_SUPPLR] [varchar](100) NULL,
	[PROD_PACKING] [varchar](20) NULL,
	[PROD_UNITS] [float] NULL,
	[PROD_QTY_PER_UNIT] [int] NULL,
	[PROD_STOCK] [int] NULL,
	[PROD_BAL_MIN] [int] NULL,
	[PROD_PURCH_PRICE] [decimal](8, 2) NULL,
	[PROD_WSALE_PRICE] [decimal](8, 2) NULL,
	[PROD_SALE_PRICE] [decimal](8, 2) NULL,
	[PROD_UPD_ON] [date] NULL,
	[PROD_FOR_SALE] [bit] NULL,
	[PROD_DISC_ALLOW] [int] NULL,
	[PROD_SALE_TAX] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHASE_DETAIL]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PURCHASE_DETAIL](
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
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHASE_MASTER]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PURCHASE_MASTER](
	[PrchID] [nvarchar](50) NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](50) NULL,
	[DateCompleted] [date] NULL,
	[PrchType] [varchar](50) NULL,
	[OfflineID] [varchar](100) NULL,
	[SupplrID] [int] NULL,
	[SupplrName] [varchar](100) NULL,
	[PrchGross] [float] NULL,
	[PrchDiscount] [float] NULL,
	[PrchTotal] [float] NULL,
	[PrchPaid] [float] NULL,
	[LedgerPost] [tinyint] NULL,
	[Status] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RATES_HISTORY]    Script Date: 7/17/2021 3:39:11 PM ******/
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
/****** Object:  Table [dbo].[SALE_DETAIL]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[DrawerID] [varchar](50) NULL,
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[Refer] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_DETAIL_HOLD]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[Refer] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_DETAIL_TEMP]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[AOptions] [varchar](200) NULL,
	[SortItem] [int] NULL,
	[Refer] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_MASTER]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_MASTER](
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
	[Refer] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_MASTER_HOLD]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[Refer] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_MASTER_TEMP]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[Refer] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUPPLIERS]    Script Date: 7/17/2021 3:39:11 PM ******/
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
/****** Object:  Table [dbo].[USERROLES]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERROLES](
	[RoleID] [int] NULL,
	[RoleName] [char](50) NULL,
	[Decription] [char](250) NULL,
	[SecurityLevel] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 7/17/2021 3:39:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
USE [master]
GO
ALTER DATABASE [POS_MED] SET  READ_WRITE 
GO
