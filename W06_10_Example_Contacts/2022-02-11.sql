--CREATE DATABASE ContactsDB

USE ContactsDB

GO

CREATE TABLE Users(
UserID INT IDENTITY(1,1) PRIMARY KEY
, Username NVARCHAR(20) NOT NULL UNIQUE
, FullName NVARCHAR(20) NOT NULL
, Password NVARCHAR(20) NOT NULL)

CREATE TABLE Contacts(
ContactID INT IDENTITY(1,1) PRIMARY KEY
, ContactName NVARCHAR(30) NOT NULL
, PhoneNumber NVARCHAR(24) NOT NULL
, UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID))

GO

INSERT INTO Users(Username,FullName,Password)
VALUES ('demo','demo','demo')

INSERT INTO Users(Username,FullName,Password)
VALUES ('demo2','demo2','demo2')

INSERT INTO Contacts(ContactName,PhoneNumber,UserID)
VALUES ('demoCon', '+905555555555',1)

GO

CREATE PROC AddUser(
@username nvarchar(20)
, @fullname nvarchar(20)
, @password nvarchar(20))
AS
INSERT INTO Users(Username, FullName, Password)
VALUES (@username, @fullname, @password)

GO

CREATE PROC AddContact(
@userID int
, @contactName nvarchar(30)
, @phone nvarchar(24)
)
AS
INSERT INTO Contacts(ContactName, PhoneNumber, UserID)
VALUES (@contactName, @phone, @userID)

GO

CREATE PROC UpdateContact(
@ContactID int
, @contactName nvarchar(30)
, @phone nvarchar(24)
)
AS
UPDATE Contacts
SET ContactName = @contactName, PhoneNumber = @phone
WHERE ContactID = @ContactID

GO

CREATE PROC DeleteContact(@contacdID int)
AS
DELETE Contacts
WHERE ContactID = @contacdID

GO