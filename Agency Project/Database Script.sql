USE [POS_ERP]
GO
/****** Object:  Table [dbo].[AccountGroups]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountGroups](
	[AccType_Id] [int] NOT NULL,
	[AccType_Name] [varchar](100) NULL,
	[AccType_Name_U] [nvarchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accounts](
	[Account_ID] [int] NOT NULL,
	[Account_Name] [varchar](255) NULL,
	[Account_Name_U] [nvarchar](255) NULL,
	[Print_Name] [varchar](255) NULL,
	[AccountGroup] [varchar](250) NULL,
	[AccountGroupUr] [nvarchar](100) NULL,
	[AccountHead] [varchar](100) NULL,
	[AccType] [varchar](50) NULL,
	[Opn_Bal] [decimal](18, 2) NULL,
	[Dr_Cr] [varchar](5) NULL,
	[Address1] [varchar](255) NULL,
	[Address2] [varchar](255) NULL,
	[AddressUr1] [nvarchar](255) NULL,
	[AddressUr2] [nvarchar](255) NULL,
	[City_id] [int] NULL,
	[City_Name] [varchar](255) NULL,
	[City_Urdu] [nvarchar](100) NULL,
	[Area_Id] [int] NULL,
	[Area_Name] [varchar](100) NULL,
	[Area_Urdu] [nvarchar](100) NULL,
	[LandLine] [varchar](20) NULL,
	[Mobile] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact_Person] [varchar](255) NULL,
	[Bank_Name] [varchar](255) NULL,
	[Bank_Acc_No] [varchar](255) NULL,
	[Credit_Limit] [decimal](18, 2) NULL,
	[Bill_Limit] [decimal](18, 2) NULL,
	[GST_No] [varchar](100) NULL,
	[NTN_No] [varchar](100) NULL,
	[CNIC] [varchar](15) NULL,
	[Party_Type] [varchar](255) NULL,
	[Party_Type_Ur] [varchar](100) NULL,
	[Cr_Days_Sale] [int] NULL,
	[Cr_Days_Purch] [int] NULL,
	[AccHolder] [varchar](10) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Account_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Area]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Area](
	[Area_Id] [int] NOT NULL,
	[Area_Name] [varchar](100) NULL,
	[Area_Name_U] [nvarchar](100) NULL,
	[Area_Code] [int] NULL,
 CONSTRAINT [PK__Table__3214EC077F60ED59] PRIMARY KEY CLUSTERED 
(
	[Area_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[City]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[City](
	[City_ID] [int] NOT NULL,
	[City_Pin] [int] NULL,
	[City_Name] [varchar](100) NULL,
	[City_Name_U] [nvarchar](100) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[City_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Companies](
	[CompanyID] [int] NOT NULL,
	[CompanyCode] [int] NULL,
	[CompanyName] [varchar](100) NULL,
	[CompanyNameUr] [nvarchar](100) NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CompanyInfo]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CompanyInfo](
	[CompanyName] [varchar](250) NULL,
	[Address] [varchar](250) NULL,
	[Address2] [varchar](250) NULL,
	[CompanyUrdu] [nvarchar](250) NULL,
	[AddressUrdu] [nvarchar](250) NULL,
	[AddressUrdu2] [nvarchar](250) NULL,
	[City] [varchar](250) NULL,
	[ZipCode] [varchar](50) NULL,
	[Province] [varchar](100) NULL,
	[PinCode] [varchar](100) NULL,
	[MobileNo] [varchar](50) NULL,
	[LandLine] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[GSTNo] [varchar](50) NULL,
	[CNIC] [varchar](50) NULL,
	[DealsIn] [varchar](250) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Groups](
	[Group_Id] [int] NOT NULL,
	[Group_Name] [varchar](100) NULL,
	[Group_Name_U] [nvarchar](100) NULL,
 CONSTRAINT [PK__GROUP__3214EC0703317E3D] PRIMARY KEY CLUSTERED 
(
	[Group_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InvoiceBook]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InvoiceBook](
	[Date] [date] NULL,
	[SaleOrderId] [decimal](18, 0) NOT NULL,
	[SaleOrderSeq] [varchar](255) NULL,
	[VoucherID] [decimal](18, 0) NULL,
	[TransactionType] [varchar](50) NULL,
	[AccountID] [int] NULL,
	[AccountName] [varchar](255) NULL,
	[AccountNameUr] [nvarchar](100) NULL,
	[BatchID] [int] NULL,
	[BatchNo] [varchar](255) NULL,
	[BatchCode] [varchar](255) NULL,
	[MainQty] [int] NULL,
	[AltQty] [int] NULL,
	[Loose] [int] NULL,
	[Free] [int] NULL,
	[BasicAmount] [float] NULL,
	[TaxAmount] [float] NULL,
	[NetValue] [float] NULL,
	[TotalGST] [float] NULL,
	[TotalITax] [float] NULL,
	[Discount] [float] NULL,
	[SubTotal] [float] NULL,
	[DrAmount] [float] NULL,
	[CrAmount] [float] NULL,
	[OrderSalesMan] [varchar](100) NULL,
	[Recovery] [float] NULL,
	[RDate] [date] NULL,
	[OD1] [date] NULL,
	[OD2] [date] NULL,
	[OD3] [date] NULL,
	[OD4] [date] NULL,
	[OD5] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ledger_Temp]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ledger_Temp](
	[Ledg_Date] [date] NULL,
	[Ledg_Tran_Id] [decimal](10, 0) NULL,
	[Ledg_Type] [varchar](50) NULL,
	[Ledg_Acc_Head] [varchar](50) NULL,
	[Ledg_Acc_Id] [decimal](10, 0) NULL,
	[Ledg_Sub_Acc] [varchar](50) NULL,
	[Ledg_Voucher_No] [varchar](50) NULL,
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
/****** Object:  Table [dbo].[Ledgers]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ledgers](
	[Ledg_Date] [date] NULL,
	[Ledg_Tran_Id] [decimal](10, 0) NULL,
	[Ledg_Type] [varchar](50) NULL,
	[Ledg_Acc_Head] [varchar](50) NULL,
	[Ledg_Acc_Id] [int] NULL,
	[Ledg_Sub_Acc] [varchar](50) NULL,
	[Ledg_Voucher_No] [varchar](50) NULL,
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
/****** Object:  Table [dbo].[OpenPurchase]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OpenPurchase](
	[ItemSaleOrder] [decimal](18, 0) NULL,
	[ItemID] [varchar](50) NULL,
	[ItemDesc] [varchar](255) NULL,
	[ItemPurchDate] [date] NULL,
	[ItemPurchPrice] [float] NULL,
	[ItemSalePrice] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Date] [date] NULL,
	[ItemOrderId] [decimal](18, 0) NULL,
	[ItemSaleType] [varchar](100) NULL,
	[CustomerID] [int] NULL,
	[ItemID] [varchar](50) NULL,
	[ItemName] [varchar](100) NULL,
	[ItemNameUr] [nvarchar](100) NULL,
	[ItemGroup] [varchar](100) NULL,
	[ItemGroupUrdu] [nvarchar](100) NULL,
	[ItemCompany] [varchar](100) NULL,
	[ItemCompUrdu] [nvarchar](100) NULL,
	[ItemPack] [varchar](10) NULL,
	[ItemVAT] [float] NULL,
	[ItemITax] [float] NULL,
	[ItemOtherTax] [float] NULL,
	[ItemPrimaryPrice] [float] NULL,
	[ItemSecondaryPrice] [float] NULL,
	[ItemBasicPrice] [float] NULL,
	[ItemBasicUnit] [varchar](10) NULL,
	[ItemBasicQty] [int] NULL,
	[ItemQty] [int] NULL,
	[ItemAltQty] [int] NULL,
	[ItemFreeQty] [int] NULL,
	[ItemDiscPercent] [int] NULL,
	[ItemDiscAmnt] [float] NULL,
	[ItemTaxPercent] [int] NULL,
	[ItemTaxAmt] [float] NULL,
	[ItemNetValue] [float] NULL,
	[ItemPayment] [float] NULL,
	[ItemDues] [float] NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](100) NULL,
	[ItemExclPurch] [float] NULL,
	[ItemExclPrice] [float] NULL,
	[SortItem] [int] NULL,
	[Account_Id] [int] NULL,
	[Area_ID] [int] NULL,
	[City_ID] [int] NULL,
	[SalesManID] [int] NULL,
	[CompanyID] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentReceipts]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaymentReceipts](
	[PaymentOrder] [decimal](18, 0) NULL,
	[PaymentDate] [date] NULL,
	[PaymentInvoice] [decimal](18, 0) NULL,
	[InvoiceDate] [date] NULL,
	[PaymentParty] [varchar](100) NULL,
	[TotalPayment] [decimal](18, 2) NULL,
	[PaymentDiscount] [decimal](18, 2) NULL,
	[CashPayment] [decimal](18, 2) NULL,
	[InvoiceBal] [decimal](18, 2) NULL,
	[Remarks] [varchar](250) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductGroup]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductGroup](
	[ProdGroupID] [int] NOT NULL,
	[ProdGroupName] [varchar](100) NULL,
	[ProdGroupNmUr] [nvarchar](100) NULL,
 CONSTRAINT [PK_ProductGroup] PRIMARY KEY CLUSTERED 
(
	[ProdGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProdCode] [varchar](100) NOT NULL,
	[ProductId] [int] NULL,
	[ProdBarCode] [varchar](100) NULL,
	[ProdName] [varchar](255) NULL,
	[ProdShortName] [varchar](255) NULL,
	[ProdNameUrdu] [nvarchar](100) NULL,
	[ProdGroup] [varchar](255) NULL,
	[ProdCompany] [varchar](255) NULL,
	[ProdPack] [varchar](50) NULL,
	[ProdPrimaryId] [int] NULL,
	[ProdPrimaryUnit] [varchar](255) NULL,
	[ProdPrimaryPrice] [float] NULL,
	[ProdSecondaryId] [int] NULL,
	[ProdSecondaryUnit] [varchar](255) NULL,
	[ProdSecondaryPrice] [float] NULL,
	[ProdConvFactor] [int] NULL,
	[ProdUnitId] [int] NULL,
	[ProdUnitName] [varchar](50) NULL,
	[ProdTaxSlab] [varchar](50) NULL,
	[ProdTaxRate] [int] NULL,
	[ProdPurchPrice] [decimal](18, 2) NULL,
	[ProdVAT] [decimal](18, 2) NULL,
	[ProdITax] [decimal](18, 2) NULL,
	[ProdOtherTax] [decimal](18, 2) NULL,
	[ProdBasicPrice] [decimal](18, 2) NULL,
	[ProdSalePrice] [decimal](18, 2) NULL,
	[ProdMRP] [decimal](18, 2) NULL,
	[ProdMinPrice] [decimal](18, 2) NULL,
	[ProdProfit] [decimal](18, 2) NULL,
	[ProdStock] [int] NULL,
	[ProdStockVal] [decimal](18, 2) NULL,
	[ProdPricePercent] [int] NULL,
	[ProdMinLevel] [int] NULL,
	[ProdMaxLevel] [int] NULL,
	[ProdScheme] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProdCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductScheme]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductScheme](
	[ProdSchSeq] [int] NULL,
	[ProdSchID] [varchar](255) NULL,
	[ProdSchPrice] [decimal](18, 2) NULL,
	[ProdSchStartDate] [date] NULL,
	[ProdSchEndDate] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductUnits]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductUnits](
	[ProdUnitSeq] [int] NULL,
	[ProdUnit] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseDetail]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseDetail](
	[Date] [date] NULL,
	[ItemOrderId] [decimal](18, 0) NULL,
	[ItemSaleType] [varchar](100) NULL,
	[CustomerID] [int] NULL,
	[ItemID] [varchar](50) NULL,
	[ItemName] [varchar](100) NULL,
	[ItemNameUr] [nvarchar](100) NULL,
	[ItemGroup] [varchar](100) NULL,
	[ItemGroupUrdu] [nvarchar](100) NULL,
	[ItemCompany] [varchar](100) NULL,
	[ItemCompUrdu] [nvarchar](100) NULL,
	[ItemPack] [varchar](10) NULL,
	[ItemVAT] [float] NULL,
	[ItemITax] [float] NULL,
	[ItemOtherTax] [float] NULL,
	[ItemPrimaryPrice] [float] NULL,
	[ItemSecondaryPrice] [float] NULL,
	[ItemBasicPrice] [float] NULL,
	[ItemBasicUnit] [varchar](10) NULL,
	[ItemBasicQty] [int] NULL,
	[ItemQty] [int] NULL,
	[ItemAltQty] [int] NULL,
	[ItemNetValue] [float] NULL,
	[ItemPayment] [float] NULL,
	[ItemDues] [float] NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](100) NULL,
	[SortItem] [int] NULL,
	[Account_Id] [int] NULL,
	[Area_ID] [int] NULL,
	[City_ID] [int] NULL,
	[SalesManID] [int] NULL,
	[CompanyID] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseOrder](
	[Date] [date] NULL,
	[PurchOrderId] [decimal](18, 0) NOT NULL,
	[PurchOrderSeq] [varchar](255) NULL,
	[OrderType] [varchar](50) NULL,
	[AccountID] [int] NULL,
	[AccountName] [varchar](255) NULL,
	[AccountNameUr] [nvarchar](100) NULL,
	[MainQty] [int] NULL,
	[AltQty] [int] NULL,
	[BasicAmount] [float] NULL,
	[NetValue] [float] NULL,
	[SubTotal] [float] NULL,
	[DrAmount] [float] NULL,
	[CrAmount] [float] NULL,
	[OrderOperator] [varchar](20) NULL,
	[OD1] [date] NULL,
	[OD2] [date] NULL,
	[OD3] [date] NULL,
	[OD4] [date] NULL,
	[OD5] [date] NULL,
 CONSTRAINT [PK_PurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[PurchOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SaleBook]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SaleBook](
	[Date] [date] NULL,
	[SaleOrderId] [decimal](18, 0) NULL,
	[VoucherID] [decimal](18, 0) NULL,
	[TransactionType] [varchar](50) NULL,
	[AccountID] [int] NULL,
	[AccountName] [varchar](255) NULL,
	[AccountNameUr] [nvarchar](100) NULL,
	[MainQty] [int] NULL,
	[AltQty] [int] NULL,
	[Loose] [int] NULL,
	[Free] [int] NULL,
	[BasicAmount] [float] NULL,
	[Discount] [float] NULL,
	[DrAmount] [float] NULL,
	[CrAmount] [float] NULL,
	[OrderSalesMan] [varchar](100) NULL,
	[RecoveryDate] [date] NULL,
	[Remarks] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SaleOrder]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SaleOrder](
	[Date] [date] NULL,
	[SaleOrderId] [decimal](18, 0) NOT NULL,
	[SaleOrderSeq] [varchar](255) NULL,
	[VoucherID] [decimal](18, 0) NULL,
	[TransactionType] [varchar](50) NULL,
	[AccountID] [int] NULL,
	[AccountName] [varchar](255) NULL,
	[AccountNameUr] [nvarchar](100) NULL,
	[BatchID] [int] NULL,
	[BatchNo] [varchar](255) NULL,
	[BatchCode] [varchar](255) NULL,
	[MainQty] [int] NULL,
	[AltQty] [int] NULL,
	[Loose] [int] NULL,
	[Free] [int] NULL,
	[BasicAmount] [float] NULL,
	[TaxAmount] [float] NULL,
	[NetValue] [float] NULL,
	[TotalGST] [float] NULL,
	[TotalITax] [float] NULL,
	[Discount] [float] NULL,
	[SubTotal] [float] NULL,
	[DrAmount] [float] NULL,
	[CrAmount] [float] NULL,
	[OrderSalesMan] [varchar](100) NULL,
	[Recovery] [float] NULL,
	[RDate] [date] NULL,
	[OD1] [date] NULL,
	[OD2] [date] NULL,
	[OD3] [date] NULL,
	[OD4] [date] NULL,
	[OD5] [date] NULL,
	[DrawerID] [int] NULL,
	[Drawer] [varchar](100) NULL,
 CONSTRAINT [PK_SaleOrder] PRIMARY KEY CLUSTERED 
(
	[SaleOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SaleReturn]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SaleReturn](
	[Date] [date] NULL,
	[SaleOrderId] [decimal](18, 0) NOT NULL,
	[SaleOrderSeq] [varchar](255) NULL,
	[VoucherID] [decimal](18, 0) NULL,
	[TransactionType] [varchar](50) NULL,
	[AccountID] [int] NULL,
	[AccountName] [varchar](255) NULL,
	[AccountNameUr] [nvarchar](100) NULL,
	[BatchID] [int] NULL,
	[BatchNo] [varchar](255) NULL,
	[BatchCode] [varchar](255) NULL,
	[MainQty] [int] NULL,
	[AltQty] [int] NULL,
	[Loose] [int] NULL,
	[Free] [int] NULL,
	[BasicAmount] [float] NULL,
	[TaxAmount] [float] NULL,
	[NetValue] [float] NULL,
	[TotalGST] [float] NULL,
	[TotalITax] [float] NULL,
	[Discount] [float] NULL,
	[SubTotal] [float] NULL,
	[DrAmount] [float] NULL,
	[CrAmount] [float] NULL,
	[OrderSalesMan] [varchar](100) NULL,
	[Recovery] [float] NULL,
	[RDate] [date] NULL,
	[OD1] [date] NULL,
	[OD2] [date] NULL,
	[OD3] [date] NULL,
	[OD4] [date] NULL,
	[OD5] [date] NULL,
	[DrawerID] [int] NULL,
	[Drawer] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SaleReturnDetail]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SaleReturnDetail](
	[Date] [date] NULL,
	[ItemOrderId] [decimal](18, 0) NULL,
	[ItemSaleType] [varchar](100) NULL,
	[CustomerID] [int] NULL,
	[ItemID] [varchar](50) NULL,
	[ItemName] [varchar](100) NULL,
	[ItemNameUr] [nvarchar](100) NULL,
	[ItemGroup] [varchar](100) NULL,
	[ItemGroupUrdu] [nvarchar](100) NULL,
	[ItemCompany] [varchar](100) NULL,
	[ItemCompUrdu] [nvarchar](100) NULL,
	[ItemPack] [varchar](10) NULL,
	[ItemVAT] [float] NULL,
	[ItemITax] [float] NULL,
	[ItemOtherTax] [float] NULL,
	[ItemPrimaryPrice] [float] NULL,
	[ItemSecondaryPrice] [float] NULL,
	[ItemBasicPrice] [float] NULL,
	[ItemBasicUnit] [varchar](10) NULL,
	[ItemBasicQty] [int] NULL,
	[ItemQty] [int] NULL,
	[ItemAltQty] [int] NULL,
	[ItemFreeQty] [int] NULL,
	[ItemDiscPercent] [int] NULL,
	[ItemDiscAmnt] [float] NULL,
	[ItemTaxPercent] [int] NULL,
	[ItemTaxAmt] [float] NULL,
	[ItemNetValue] [float] NULL,
	[ItemPayment] [float] NULL,
	[ItemDues] [float] NULL,
	[DrawerID] [int] NULL,
	[DrawerName] [varchar](100) NULL,
	[ItemExclPurch] [float] NULL,
	[ItemExclPrice] [float] NULL,
	[SortItem] [int] NULL,
	[Account_Id] [int] NULL,
	[Area_ID] [int] NULL,
	[City_ID] [int] NULL,
	[SalesManID] [int] NULL,
	[CompanyID] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesMan]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesMan](
	[SalesManID] [int] NOT NULL,
	[SalesManName] [varchar](100) NULL,
	[SalesManNameUr] [nvarchar](100) NULL,
	[SalesManAddress] [varchar](255) NULL,
	[SalesManCNIC] [varchar](255) NULL,
	[SalesManMobile] [varchar](255) NULL,
	[SalesManCompany] [varchar](255) NULL,
 CONSTRAINT [PK_SalesMan] PRIMARY KEY CLUSTERED 
(
	[SalesManID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaxSlab]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaxSlab](
	[SequenceID] [int] NULL,
	[TaxDescription] [varchar](100) NULL,
	[TaxRate] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Types]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Types](
	[Type_ID] [int] NOT NULL,
	[Type_Desc] [varchar](100) NULL,
	[Type_Desc_U] [nvarchar](100) NULL,
 CONSTRAINT [PK_Types] PRIMARY KEY CLUSTERED 
(
	[Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22/03/2021 11:48:28 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserReg] [int] NULL,
	[UserName] [varchar](255) NULL,
	[UserId] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[UserRole] [varchar](255) NULL,
	[SecurityLevel] [int] NULL,
	[Active] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsersRoles]    Script Date: 22/03/2021 11:48:28 pm ******/
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
