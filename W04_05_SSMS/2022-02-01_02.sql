USE Northwind

SELECT P.ProductName, P.UnitPrice, C.CategoryName
FROM Products P
LEFT JOIN Categories C
ON P.CategoryID = C.CategoryID

SELECT SUM(UnitsInStock) FROM Products

SELECT AVG(UnitPrice) FROM Products

SELECT MAX(UnitsInStock), MIN(UnitsInStock)
FROM Products

SELECT CategoryName, SUM(UnitsInStock)
FROM Products P
LEFT JOIN Categories C
ON P.CategoryID = C.CategoryID
GROUP BY CategoryName

SELECT CompanyName, SUM(UnitsInStock)
FROM Products P
RIGHT JOIN Suppliers S
ON P.SupplierID = S.SupplierID
GROUP BY CompanyName

SELECT CompanyName, SUM(UnitsInStock*UnitPrice)
FROM Products P
RIGHT JOIN Suppliers S
ON P.SupplierID = S.SupplierID
GROUP BY CompanyName

-- how many orders an employee assigned with a customer ?
SELECT E.FirstName, O.CustomerID, COUNT(O.OrderID)
FROM Orders O
INNER JOIN Employees E
ON E.EmployeeID = O.EmployeeID
GROUP BY E.FirstName, O.CustomerID

-- how many times a customer used a shipper?
SELECT CustomerID, ShipVia, COUNT(*)
FROM Orders
GROUP BY CustomerID, ShipVia
ORDER BY CustomerID

-- how many dollars worth of a product sold?
SELECT ProductID, SUM(UnitPrice*Quantity*(1-Discount))
FROM [Order Details]
GROUP BY ProductID

-- how many dollars worth of a product sold and which employee sold?
SELECT O.EmployeeID, OD.ProductID, SUM(UnitPrice*Quantity*(1-Discount))
FROM [Order Details] OD
LEFT JOIN Orders O
ON  OD.OrderID = O.OrderID
GROUP BY OD.ProductID, O.EmployeeID
ORDER BY OD.ProductID

-- how many sales of products from a category an employee made
SELECT O.EmployeeID, P.CategoryID, COUNT(*) AS SaleCount
FROM [Order Details] OD
LEFT JOIN Orders O ON OD.OrderID = O.OrderID
LEFT JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY O.EmployeeID, P.CategoryID
ORDER BY O.EmployeeID

SELECT ProductID
, (SELECT CategoryName FROM Categories WHERE Categories.CategoryID = Products.CategoryID) AS CategoryName
, ProductName
, (SELECT CompanyName FROM Suppliers WHERE Suppliers.SupplierID = Products.SupplierID) AS SupplierName
FROM Products
ORDER BY CategoryName

SELECT City FROM Employees
UNION
SELECT City FROM Suppliers

SELECT City FROM Employees
INTERSECT
SELECT City FROM Suppliers

SELECT DISTINCT City FROM Employees
EXCEPT
SELECT DISTINCT City FROM Suppliers