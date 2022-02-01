use AdventureWorks2017

--SELECT Color, SUM(ListPrice) FROM Production.Product WHERE ProductID IN (SELECT DISTINCT ProductID FROM Sales.SalesOrderDetail) GROUP BY Color

--SELECT p.FirstName, e.BirthDate FROM Person.Person P INNER JOIN HumanResources.Employee E
--ON P.BusinessEntityID = E.BusinessEntityID WHERE P.PersonType = 'EM'

--SELECT * FROM Person.Person P LEFT JOIN HumanResources.Employee AS E ON P.BusinessEntityID = e.BusinessEntityID

--SELECT P.Color, SUM(S.UnitPrice) FROM Production.Product P 
--LEFT JOIN
--Sales.SalesOrderDetail S ON P.ProductID = S.ProductID GROUP BY Color

--SELECT BusinessEntityID, FirstName, LastName
--, (SELECT BirthDate from HumanResources.Employee WHERE BusinessEntityID = Person.BusinessEntityID) as BD
--FROM Person.Person 


--SELECT [Cat. Name], [Sub. Name] FROM
--(
--SELECT P.ProductID, P.Name, Color, C.Name AS [Cat. Name], S.Name AS [Sub. Name], P.ListPrice
--FROM Production.Product P
--LEFT JOIN Production.ProductSubcategory AS S ON P.ProductSubcategoryID = S.ProductSubcategoryID
--LEFT JOIN Production.ProductCategory AS C ON S.ProductCategoryID = C.ProductCategoryID
--) newtable
--GROUP BY [Cat. Name], [Sub. Name] HAVING [Sub. Name] IS NOT NULL