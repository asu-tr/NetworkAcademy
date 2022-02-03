USE Northwind

GO

--CREATE PROCEDURE AddEmployee
--@name nvarchar(10)
--, @surname nvarchar(20)
--, @dateofbirth datetime
--, @address nvarchar(60)
--AS
--INSERT INTO Employees(FirstName,LastName,BirthDate,Address)
--VALUES (@name, @surname, @dateofbirth, @address)

GO

--ALTER PROCEDURE AddEmployee
--@name nvarchar(10)
--, @surname nvarchar(20)
--, @dateofbirth datetime
--, @address nvarchar(60)
--AS
--IF NOT EXISTS (SELECT * FROM Employees WHERE @name = FirstName)
--BEGIN
--INSERT INTO Employees(FirstName,LastName,BirthDate,Address)
--VALUES (@name, @surname, @dateofbirth, @address)
--END


GO


--CREATE PROC AddCategory
--@catname nvarchar(15)
--AS
--DECLARE @catid int
--IF NOT EXISTS (SELECT * FROM Categories WHERE @catname = CategoryName)
--BEGIN
--INSERT INTO Categories(CategoryName)
--VALUES (@catname)
--SET @catid = SCOPE_IDENTITY()
--END
--ELSE
--BEGIN
--SET @catid = (SELECT CategoryID FROM Categories WHERE CategoryName = @catname)
--END
--RETURN @catid

--EXEC AddCategory 'Clothes'


GO


--CREATE PROCEDURE AddProductWithCat
--@productname nvarchar(40)
--, @catname nvarchar(15)
--AS
--DECLARE @id int
--EXEC @id = AddCategory @catname
--INSERT Products (ProductName, CategoryID)
--VALUES (@productname, @id)

--EXEC AddProductWithCat 'Apple', 'Fruit'


GO


--CREATE PROC SellProduct
--@pid int
--, @price money
--, @qnt smallint
--, @disc real
--AS
--DECLARE @orderid int
--INSERT INTO Orders
--DEFAULT VALUES
--SET @orderid = SCOPE_IDENTITY()
--INSERT INTO [Order Details]
--VALUES (@orderid, @pid, @price, @qnt, @disc)
--UPDATE Products SET UnitsInStock -= @qnt WHERE ProductID = @pid

--EXEC SellProduct 4, 5, 3, 0