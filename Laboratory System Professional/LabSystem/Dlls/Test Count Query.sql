/****** Script for SelectTopNRows command from SSMS  ******/
SELECT tname[Test Name],COUNT(tname)[Quantity]
  FROM [LAB_PRO].[dbo].[Receipt]
  where Receipt .tdate >= '2019-08-01' and Receipt .tdate <= '2019-08-31'
  group by tname