USE School

--CREATE TABLE Parents(
--ID INT IDENTITY(1,1) PRIMARY KEY
--, FirstName NVARCHAR(50) NOT NULL
--, LastName NVARCHAR(50) NOT NULL)


--CREATE TABLE Students(
--ID int IDENTITY(1,1) PRIMARY KEY
--, TCNo int UNIQUE NOT NULL
--, FirstName NVARCHAR(50) NOT NULL
--, LastName NVARCHAR(50) NOT NULL
--, ParentID INT FOREIGN KEY REFERENCES Parents(ID))

--INSERT INTO Parents
--VALUES ('FN', 'LN')

--INSERT INTO Students (TCNo, FirstName, LastName)
--VALUES (1234, 'FN2', 'LN2')

--INSERT INTO Students
--VALUES (1222, 'FN3', 'LN3', 1)

--INSERT INTO Students
--VALUES (1223, 'First', 'Last', 1)

--INSERT INTO Students (TCNo, FirstName, LastName)
--VALUES (124321, 'FIRST', 'LAST')

SELECT LEN(TCNo) FROM Students

SELECT UPPER(SUBSTRING(LastName,1,1)) + LOWER(SUBSTRING(LastName,2,LEN(LastName)))
FROM Students

SELECT LEFT(FirstName, 3), RIGHT(FirstName, 3)
FROM Students

SELECT
CONCAT(FirstName, SPACE(1), LastName)
, FirstName + ' ' + LastName
FROM Students

DELETE Students
WHERE ID = 3

-- DELETE   - DATA DELETED ID CONTINUE
-- TRUNCATE - DATA DELETED ID RESET
-- DROP     - TABLE DELETED