SELECT  * FROM [WideWorldImporters].[Sales].[Orders], [WideWorldImporters].[Application].[People]
WHERE [WideWorldImporters].[Sales].[Orders].OrderID = [WideWorldImporters].[Application].[People].PersonID
AND [WideWorldImporters].[Application].[People].EmailAddress = 'hudsonh@wideworldimporters.com';
