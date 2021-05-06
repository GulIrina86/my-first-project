/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[good_id]
      ,[quantity]
      ,[sale_date]
  FROM [MallDB1].[dbo].[GoodsSales]