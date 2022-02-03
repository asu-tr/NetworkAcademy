USE Northwind

GO

--CREATE PROC SendMoney
--@senderid int
--, @receiverid int
--, @amount money
--AS
--SET XACT_ABORT ON
--BEGIN TRY
--  BEGIN TRAN EFT
--    UPDATE Accounts SET Balance -= @amount WHERE ID = @senderid
--    UPDATE Accounts SET Balance += @amount WHERE ID = @receiverid
--  COMMIT TRAN EFT
--END TRY
--BEGIN CATCH
--  ROLLBACK TRAN
--  PRINT 'AN ERROR OCCURED'
--END CATCH

--GO

--SELECT * FROM ACCOUNTS

--EXEC SendMoney 2, 4, 100

--SELECT * FROM ACCOUNTS

---- SELECT @@TRANCOUNT -- OPEN TRANSACTION COUNT


--SELECT CompanyName
--, CASE Country
--  WHEN 'Japan' THEN 'JP'
--  WHEN 'Spain' THEN 'SP'
--  WHEN 'Germany' THEN 'DE'
--  WHEN 'Netherlands' THEN 'NL'
--  ELSE Country
--  END AS [Country Code]
--FROM Suppliers


--DECLARE @name nvarchar(20) = 'Ashley'
--DECLARE @count int = 0

--WHILE @count < LEN(@name)
--BEGIN
--  PRINT @name
--  SET @count += 1
--END


--SELECT COUNT(*) FROM Suppliers

GO

CREATE FUNCTION GetProductName
(@id int)
RETURNS nvarchar(40)
AS
BEGIN
DECLARE @pname nvarchar(40)
SELECT @pname = ProductName FROM Products WHERE ProductID = @id
RETURN @pname
END

GO

SELECT dbo.GetProductName(5)