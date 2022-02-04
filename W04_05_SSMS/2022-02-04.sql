USE Northwind

GO

CREATE FUNCTION GetProduct
(@id int)
RETURNS TABLE
AS
RETURN (SELECT * FROM Products WHERE ProductID = @id)

GO

SELECT * FROM dbo.GetProduct(5)


GO


CREATE FUNCTION Emp
()
RETURNS @emptable TABLE
(id int
, fname nvarchar(20)
, lname nvarchar(20))
AS
BEGIN
  INSERT INTO @emptable
  VALUES(1, 'Mary', 'Will')
RETURN
END

GO

SELECT * FROM dbo.Emp()


GO


CREATE FUNCTION CalcTax (@price money)
RETURNS MONEY
AS
BEGIN
  DECLARE @tax MONEY
  SET @tax = @price * 0.18
  RETURN @tax
END

GO

SELECT dbo.CalcTax(UnitPrice) as Tax, * FROM Products


GO


CREATE FUNCTION CalcTax2 (@price money)
RETURNS MONEY
AS
BEGIN
  RETURN @price * 1.18
END

GO

SELECT dbo.CalcTax2(UnitPrice) AS [Price with Tax], * FROM Products


GO


CREATE FUNCTION FinalPriceWithTax
(@price MONEY, @amount int, @disc float)
RETURNS MONEY
AS
BEGIN
  DECLARE @totalwithtax MONEY
  SET @totalwithtax = @price * 1.18
  SET @totalwithtax *= @amount*(1-@disc)
  RETURN @totalwithtax
END

GO

SELECT dbo.FinalPriceWithTax(UnitPrice, Quantity, Discount) AS FinalPrice, * FROM [Order Details]


GO


CREATE FUNCTION ShowProductsByCatID
(@id int)
RETURNS TABLE
AS
RETURN (SELECT * FROM Products WHERE CategoryID = @id)

GO

SELECT * FROM dbo.ShowProductsByCatID(2)


GO


CREATE FUNCTION ReportsTo
(@id int)
RETURNS NVARCHAR(20)
AS
BEGIN
  DECLARE @reportstoid int
  SET @reportstoid = (SELECT ReportsTo FROM Employees WHERE EmployeeID = @id)
RETURN (SELECT FirstName FROM Employees WHERE EmployeeID = @reportstoid)
END

GO

SELECT dbo.ReportsTo(6)


GO


CREATE TRIGGER AddNewEmployeeTrigger
ON Employees
AFTER INSERT
AS
BEGIN
  SELECT FirstName FROM inserted
END

GO

INSERT INTO Employees (FirstName, LastName)
VALUES ('Dora', 'Ichi')


GO


CREATE TRIGGER UpdateEmployeeTrigger
ON Employees
AFTER UPDATE
AS
BEGIN
  PRINT 'Employee updated'
END

UPDATE Employees
SET FirstName = 'Jane' WHERE FirstName = 'Janet'


GO


CREATE TRIGGER DeleteProduct
ON Products
AFTER DELETE
AS
BEGIN
  SELECT * FROM deleted
END

DELETE FROM Products WHERE ProductName = 'Apple'


GO


CREATE TRIGGER ProductUpdateTrigger
ON Products
AFTER UPDATE
AS
BEGIN
  SELECT * FROM deleted
  SELECT * FROM inserted
END

UPDATE Products
SET ProductName = 'Banana' WHERE ProductName = 'Bananna'


GO


CREATE TRIGGER DeleteProductTrigger
ON Products
INSTEAD OF DELETE
AS
UPDATE Products
SET Discontinued = 1
WHERE ProductID = (SELECT ProductID FROM deleted)

DELETE FROM Products WHERE ProductName = 'New Product'


GO


CREATE TRIGGER AddOrderDetailTrigger
ON [Order Details]
AFTER INSERT
AS
BEGIN
  DECLARE @amount smallint
  SET @amount = (SELECT Quantity FROM inserted)
  DECLARE @id int
  SET @id = (SELECT ProductID FROM inserted)
  UPDATE Products	
  SET UnitsInStock -= @amount WHERE ProductID = @id
END

EXEC SellProduct 1, 15, 2, 0