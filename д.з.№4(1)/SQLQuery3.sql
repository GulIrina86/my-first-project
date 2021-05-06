

SELECT * FROM [WideWorldImporters].[Sales].[Orders]
INNER JOIN [WideWorldImporters].[Application].[People] ON [WideWorldImporters].[Sales].[Orders].OrderID = [WideWorldImporters].[Application].[People].PersonID;

SELECT * FROM [WideWorldImporters].[Application].[People] WHERE EmailAddress = 'hudsonh@wideworldimporters.com'
