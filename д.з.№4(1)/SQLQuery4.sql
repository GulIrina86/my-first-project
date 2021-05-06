

SELECT * FROM [WideWorldImporters].[Sales].[Orders]
INNER JOIN [WideWorldImporters].[Application].[People] 
ON [WideWorldImporters].[Sales].[Orders].OrderID = [WideWorldImporters].[Application].[People].PersonID
AND [WideWorldImporters].[Application].[People].EmailAddress = 'hudsonh@wideworldimporters.com';

