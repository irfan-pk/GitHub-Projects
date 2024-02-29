ALTER PROCEDURE [dbo].[BalanceSheet] 
	
AS
BEGIN
--Assets

SELECT T.Acc_Head[Type] ,A.Acc_Name[Account], 
       CASE
          WHEN T.Acc_Head = 'ASSETS' Then SUM(ISNULL(A.Acc_Debit,0))-SUM(ISNULL(A.Acc_Credit,0))
          ELSE SUM(ISNULL(A.Acc_Credit,0))-SUM(ISNULL(A.Acc_Debit,0))
       END[AMT]
FROM Accounts[J]
LEFT OUTER JOIN Accounts[A] ON J.Acc_No = A.Acc_No
LEFT OUTER JOIN Accounts[T] ON A.Acc_Name = T.Acc_Name
WHERE T.Acc_Head IN('ASSETS', 'LIABILITIES','EQUITY')
GROUP BY T.Acc_Head, A.Acc_Name  

--Equity
UNION ALL

SELECT 'EQUITY'[Type], 'Retained Earnings'[Account],
       SUM(CASE WHEN T.Acc_Head = 'ASSETS' THEN ISNULL(A.Acc_Debit,0) - ISNULL(A.Acc_Credit,0)
           ELSE ISNULL(A.Acc_Credit,0) - ISNULL(A.Acc_Debit,0) 
		   END)[AMT] 
FROM Accounts[J]
LEFT OUTER JOIN Accounts[A] ON J.Acc_No = A.Acc_No
LEFT OUTER JOIN Accounts[T] ON A.Acc_Name = T.Acc_Name
WHERE T.Acc_Head IN('REVENUE', 'EXPENSES')
      
--Liability and Equity

UNION ALL
SELECT 'LIABILITIES AND EQUITY' Type, 'Total Liabilities and Equity' Account,
       SUM(CASE WHEN T.Acc_Head = 'ASSETS' THEN ISNULL(A.Acc_Debit,0) - ISNULL(A.Acc_Credit,0)
            ELSE ISNULL(A.Acc_Credit,0) - ISNULL(A.Acc_Debit,0) 
		   END)[AMT]
FROM Accounts[J]
LEFT OUTER JOIN Accounts[A] ON J.Acc_No = A.Acc_No
LEFT OUTER JOIN Accounts[T] ON A.Acc_Name = T.Acc_Name
WHERE T.Acc_Head IN('LIABILITIES', 'EXPENSES', 'REVENUE','EQUITY')

END