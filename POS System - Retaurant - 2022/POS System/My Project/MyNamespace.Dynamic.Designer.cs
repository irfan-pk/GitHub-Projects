using System;
using System.ComponentModel;
using System.Diagnostics;

namespace POS_System.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BackupData m_BackupData;

            public BackupData BackupData
            {
                [DebuggerHidden]
                get
                {
                    m_BackupData = Create__Instance__(m_BackupData);
                    return m_BackupData;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BackupData))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BackupData);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public CreateDB m_CreateDB;

            public CreateDB CreateDB
            {
                [DebuggerHidden]
                get
                {
                    m_CreateDB = Create__Instance__(m_CreateDB);
                    return m_CreateDB;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CreateDB))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CreateDB);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Cust_Journal m_Cust_Journal;

            public Cust_Journal Cust_Journal
            {
                [DebuggerHidden]
                get
                {
                    m_Cust_Journal = Create__Instance__(m_Cust_Journal);
                    return m_Cust_Journal;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Cust_Journal))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Cust_Journal);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public CustomerMenu m_CustomerMenu;

            public CustomerMenu CustomerMenu
            {
                [DebuggerHidden]
                get
                {
                    m_CustomerMenu = Create__Instance__(m_CustomerMenu);
                    return m_CustomerMenu;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CustomerMenu))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CustomerMenu);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public CustomerReports m_CustomerReports;

            public CustomerReports CustomerReports
            {
                [DebuggerHidden]
                get
                {
                    m_CustomerReports = Create__Instance__(m_CustomerReports);
                    return m_CustomerReports;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CustomerReports))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CustomerReports);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Customers m_Customers;

            public Customers Customers
            {
                [DebuggerHidden]
                get
                {
                    m_Customers = Create__Instance__(m_Customers);
                    return m_Customers;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Customers))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Customers);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public CustomerList m_CustomerList;

            public CustomerList CustomerList
            {
                [DebuggerHidden]
                get
                {
                    m_CustomerList = Create__Instance__(m_CustomerList);
                    return m_CustomerList;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CustomerList))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CustomerList);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CustPurchases m_CustPurchases;

            public CustPurchases CustPurchases
            {
                [DebuggerHidden]
                get
                {
                    m_CustPurchases = Create__Instance__(m_CustPurchases);
                    return m_CustPurchases;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CustPurchases))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CustPurchases);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public DineTableMenu m_DineTable;

            public DineTableMenu DineTable
            {
                [DebuggerHidden]
                get
                {
                    m_DineTable = Create__Instance__(m_DineTable);
                    return m_DineTable;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DineTable))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DineTable);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public FoodMenuList m_FoodMenu;

            public FoodMenuList FoodMenu
            {
                [DebuggerHidden]
                get
                {
                    m_FoodMenu = Create__Instance__(m_FoodMenu);
                    return m_FoodMenu;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FoodMenu))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FoodMenu);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public HoldSale m_HoldSale;

            public HoldSale HoldSale
            {
                [DebuggerHidden]
                get
                {
                    m_HoldSale = Create__Instance__(m_HoldSale);
                    return m_HoldSale;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_HoldSale))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_HoldSale);
                }
            }


            //[EditorBrowsable(EditorBrowsableState.Never)]
            //public Journal m_Journal;

            //public Journal Journal
            //{
            //    [DebuggerHidden]
            //    get
            //    {
            //        m_Journal = Create__Instance__(m_Journal);
            //        return m_Journal;
            //    }
            //    [DebuggerHidden]
            //    set
            //    {
            //        if (ReferenceEquals(value, m_Journal))
            //            return;
            //        if (value is not null)
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        Dispose__Instance__(ref m_Journal);
            //    }
            //}


            [EditorBrowsable(EditorBrowsableState.Never)]
            public LoginInput m_LoginInput;

            public LoginInput LoginInput
            {
                [DebuggerHidden]
                get
                {
                    m_LoginInput = Create__Instance__(m_LoginInput);
                    return m_LoginInput;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_LoginInput))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_LoginInput);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Main m_Main;

            public Main Main
            {
                [DebuggerHidden]
                get
                {
                    m_Main = Create__Instance__(m_Main);
                    return m_Main;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Main))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Main);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Maintenance m_Maintenance;

            public Maintenance Maintenance
            {
                [DebuggerHidden]
                get
                {
                    m_Maintenance = Create__Instance__(m_Maintenance);
                    return m_Maintenance;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Maintenance))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Maintenance);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public MsgStatus m_MsgStatus;

            public MsgStatus MsgStatus
            {
                [DebuggerHidden]
                get
                {
                    m_MsgStatus = Create__Instance__(m_MsgStatus);
                    return m_MsgStatus;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MsgStatus))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MsgStatus);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Product m_Product;

            public Product Product
            {
                [DebuggerHidden]
                get
                {
                    m_Product = Create__Instance__(m_Product);
                    return m_Product;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Product))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Product);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public ProductCode m_ProductCode;

            public ProductCode ProductCode
            {
                [DebuggerHidden]
                get
                {
                    m_ProductCode = Create__Instance__(m_ProductCode);
                    return m_ProductCode;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ProductCode))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ProductCode);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Reports m_Reports;

            public Reports Reports
            {
                [DebuggerHidden]
                get
                {
                    m_Reports = Create__Instance__(m_Reports);
                    return m_Reports;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Reports))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Reports);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Parcel m_Parcel;

            public Parcel Parcel
            {
                [DebuggerHidden]
                get
                {
                    m_Parcel = Create__Instance__(m_Parcel);
                    return m_Parcel;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Parcel))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Parcel);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public SaleMenu m_SaleMenu;

            public SaleMenu SaleMenu
            {
                [DebuggerHidden]
                get
                {
                    m_SaleMenu = Create__Instance__(m_SaleMenu);
                    return m_SaleMenu;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SaleMenu))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SaleMenu);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Server m_Server;

            public Server Server
            {
                [DebuggerHidden]
                get
                {
                    m_Server = Create__Instance__(m_Server);
                    return m_Server;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Server))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Server);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public SplashScreen m_SplashScreen;

            public SplashScreen SplashScreen
            {
                [DebuggerHidden]
                get
                {
                    m_SplashScreen = Create__Instance__(m_SplashScreen);
                    return m_SplashScreen;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SplashScreen))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SplashScreen);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Status m_Status;

            public Status Status
            {
                [DebuggerHidden]
                get
                {
                    m_Status = Create__Instance__(m_Status);
                    return m_Status;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Status))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Status);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public SummaryReports m_SummaryReports;

            public SummaryReports SummaryReports
            {
                [DebuggerHidden]
                get
                {
                    m_SummaryReports = Create__Instance__(m_SummaryReports);
                    return m_SummaryReports;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SummaryReports))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SummaryReports);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public SysUser m_SysUser;

            public SysUser SysUser
            {
                [DebuggerHidden]
                get
                {
                    m_SysUser = Create__Instance__(m_SysUser);
                    return m_SysUser;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SysUser))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SysUser);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public TableOrder m_TableOrder;

            public TableOrder TableOrder
            {
                [DebuggerHidden]
                get
                {
                    m_TableOrder = Create__Instance__(m_TableOrder);
                    return m_TableOrder;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TableOrder))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TableOrder);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public TabViewSale m_TabViewSale;

            public TabViewSale TabViewSale
            {
                [DebuggerHidden]
                get
                {
                    m_TabViewSale = Create__Instance__(m_TabViewSale);
                    return m_TabViewSale;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TabViewSale))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TabViewSale);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public ViewPurchases m_ViewPurchases;

            public ViewPurchases ViewPurchases
            {
                [DebuggerHidden]
                get
                {
                    m_ViewPurchases = Create__Instance__(m_ViewPurchases);
                    return m_ViewPurchases;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ViewPurchases))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ViewPurchases);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public WaiterCode m_WaiterCode;

            public WaiterCode WaiterCode
            {
                [DebuggerHidden]
                get
                {
                    m_WaiterCode = Create__Instance__(m_WaiterCode);
                    return m_WaiterCode;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_WaiterCode))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_WaiterCode);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Waiters m_Waiters;

            public Waiters Waiters
            {
                [DebuggerHidden]
                get
                {
                    m_Waiters = Create__Instance__(m_Waiters);
                    return m_Waiters;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Waiters))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Waiters);
                }
            }
        }
    }
}