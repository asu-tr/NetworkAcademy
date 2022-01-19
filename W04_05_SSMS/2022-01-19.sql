use AdventureWorks2017

SELECT AddressLine1 Adres FROM PERSON.Address

SELECT AddressLine1 +' '+AddressLine2 AS [Long Address] FROM Person.Address

SELECT TOP 5 PERCENT * FROM Person.Person WHERE FirstName LIKE '%A' ORDER BY BusinessEntityID DESC

SELECT TOP 10 * FROM Production.Product WHERE SafetyStockLevel != 500 AND ListPrice > 100

SELECT * FROM Person.Person WHERE FirstName LIKE '%W%' OR FirstName LIKE '__K%'

SELECT * FROM Production.Product WHERE ProductNumber NOT IN ('AR-5381','BA-8327')

SELECT Color, SUM(SafetyStockLevel) FROM Production.Product WHERE Color IS NOT NULL GROUP BY Color HAVING Color != 'Black'

SELECT DISTINCT Color FROM Production.Product /*WHERE ProductNumber LIKE '%1%'*/

SELECT * FROM Production.Product WHERE ProductID IN (SELECT DISTINCT ProductID FROM Sales.SalesOrderDetail)