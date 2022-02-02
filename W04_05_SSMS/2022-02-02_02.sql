USE Northwind

GO

CREATE PROC ShowProducts
AS
SELECT * FROM Products

EXEC ShowProducts


GO


CREATE PROCEDURE AddProduct
@pName nvarchar(50),
@price money,
@stock smallint
AS
INSERT Products (ProductName, UnitPrice, UnitsInStock)
VALUES (@pName, @price, @stock)

EXEC AddProduct 'Banana', 15, 20


GO


CREATE PROC AddProductWithControl
@pName nvarchar(50),
@price money,
@stock smallint
AS
DECLARE @trimmedname nvarchar(50)
SET @trimmedname = LTRIM(RTRIM(@pName))
IF(EXISTS(SELECT * FROM Products WHERE ProductName = @trimmedname))
BEGIN
	PRINT 'THIS PRODUCT ALREADY EXISTS'
END
ELSE
BEGIN
	INSERT Products (ProductName, UnitPrice, UnitsInStock)
	VALUES (@trimmedname, @price, @stock)
END

EXEC AddProductWithControl 'Banana', 15, 20


GO


CREATE PROC DeleteProductByName
@pName nvarchar(50)
AS
IF(EXISTS(SELECT * FROM Products WHERE ProductName = @pName))
BEGIN
	DELETE FROM Products WHERE ProductName = @pName
END
ELSE
BEGIN
	PRINT 'THIS PRODUCT DOES NOT EXIST'
END

EXEC DeleteProductByName 'Banana'


GO


CREATE PROCEDURE Add10Stock
@id int
AS
UPDATE Products
SET UnitsInStock = UnitsInStock + 10
WHERE ProductID = @id

EXEC Add10Stock 1