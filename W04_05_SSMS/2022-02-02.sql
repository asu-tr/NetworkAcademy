USE Northwind

-- which employee didn't sell which product?
SELECT P.ProductName, E.FirstName
FROM Products P
CROSS JOIN Employees E
EXCEPT
SELECT E.FirstName, P.ProductName
FROM Orders O
LEFT JOIN [Order Details] OD ON O.OrderID = OD.OrderID
LEFT JOIN Products P ON P.ProductID = OD.ProductID
LEFT JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY E.FirstName, P.ProductName

-- which product never supplied by which supplier?
SELECT P.ProductName, S.CompanyName
FROM Products P
CROSS JOIN Suppliers S
EXCEPT
SELECT P.ProductName, S.CompanyName
FROM Products P
LEFT JOIN Suppliers S ON S.SupplierID = P.SupplierID
GROUP BY P.ProductName, S.CompanyName

-- which product never sold to which customer?
SELECT C.CustomerID, P.ProductID
FROM Products P
CROSS JOIN Customers C
EXCEPT
SELECT O.CustomerID, OD.ProductID
FROM Orders O
LEFT JOIN [Order Details] OD ON O.OrderID = OD.OrderID
GROUP BY O.CustomerID, OD.ProductID

-- which employee sold which products which has price more than $1000?
SELECT OD.ProductID, E.FirstName, SUM(OD.UnitPrice*(1-OD.Discount))
FROM [Order Details] OD
LEFT JOIN Orders O ON OD.OrderID = O.OrderID
LEFT JOIN Employees E ON E.EmployeeID = O.EmployeeID
GROUP BY OD.ProductID, E.FirstName
HAVING SUM(OD.UnitPrice*(1-OD.Discount)) > 1000


BEGIN TRAN
SELECT * FROM Products
UPDATE Products SET UnitPrice = 15
SELECT * FROM Products
ROLLBACK TRAN
SELECT * FROM Products


INSERT INTO Products (ProductName, SupplierID)
VALUES ('Another New Product', 2)

DECLARE @id int
SET @id = Scope_Identity()
UPDATE Products SET UnitPrice = 5, UnitsInStock = 10
WHERE ProductID = @id

DECLARE @id int
SET @id = Scope_Identity()
DELETE FROM Products WHERE ProductID = @id



SELECT *
INTO #TEMP1
FROM Products

SELECT * FROM #TEMP1

SELECT * 
INTO ##TEMP2
FROM Categories

SELECT * FROM ##TEMP2

GO

CREATE VIEW ProductReport
AS
SELECT P.ProductName, P.UnitPrice, P.UnitsInStock, C.CategoryName, S.CompanyName
FROM Products P
LEFT JOIN Suppliers S ON S.SupplierID = P.SupplierID
LEFT JOIN Categories C ON C.CategoryID = P.CategoryID

GO

SELECT *  FROM ProductReport

GO

-- which employee sold from which item in total ($)
CREATE VIEW [Employee Total Product Sales]
AS
SELECT O.EmployeeID, OD.ProductID, SUM(OD.UnitPrice*OD.Quantity*(1-OD.Discount)) AS TotalPrice
FROM [Order Details] OD
LEFT JOIN  Orders O ON OD.OrderID = O.OrderID
GROUP BY O.EmployeeID, OD.ProductID

GO

SELECT * FROM [Employee Total Product Sales]

GO


CREATE VIEW [Customer Sales Report]
WITH ENCRYPTION
AS
SELECT C.CompanyName, P.ProductName, SUM(OD.UnitPrice*OD.Quantity*(1-OD.Discount)) AS Total
FROM Customers C
INNER JOIN Orders O ON O.CustomerID = C.CustomerID
INNER JOIN [Order Details] OD ON OD.OrderID = O.OrderID
INNER JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY C.CompanyName, P.ProductName