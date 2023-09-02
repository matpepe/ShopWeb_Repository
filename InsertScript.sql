/*--#########################--

Author: Matko Popović

-Skripta za ProductKategorije 
-Povezivanje Admina sa Rolom
-reset identity 
--#########################--*/


USE ModelWeb2

BEGIN TRAN

DECLARE @AdminID AS NVARCHAR(MAX)
SET @AdminID = 
(
	SELECT TOP 1 Id FROM dbo.AspNetUsers 
	WHERE UserName = 'Admin@gmail.uk'
)

DECLARE @RoleAdminID AS NVARCHAR(MAX)
SET @RoleAdminID = 
(
	SELECT TOP 1 Id FROM dbo.[Role]
	WHERE [Name] = 'Admin'
)

DECLARE @i AS INT
SELECT @i=max(Id) 
	FROM dbo.ProductCategory

SELECT @AdminID AS 'ADMIN_id', @RoleAdminID AS 'Role_Id'
--SELECT * FROM dbo.UserRoles
--SELECT * FROM dbo.ProductCategory


DBCC CHECKIDENT ('dbo.ProductCategory', RESEED, @i)

TRUNCATE TABLE dbo.ProductCategory
TRUNCATE TABLE dbo.UserRoles


IF NOT EXISTS (SELECT 1 FROM dbo.UserRoles)
	INSERT INTO dbo.UserRoles(UserId, RoleId)
	VALUES (@AdminID, @RoleAdminID)

IF NOT EXISTS (SELECT 1 FROM dbo.ProductCategory)
INSERT INTO dbo.ProductCategory(ProductId,CategoryId)
VALUES (1, 4),
	   (2, 5),
	   (3, 3),
	   (5, 2), 
	   (6, 3),
	   (7, 1),
	   (8, 4),
	   (9, 1),
	   (10, 5)

IF NOT EXISTS (SELECT 1 FROM dbo.ProductCategory)
DBCC CHECKIDENT ('dbo.ProductCategory', RESEED, 0)
IF NOT EXISTS (SELECT 1 FROM dbo.Category)
DBCC CHECKIDENT ('dbo.Category', RESEED, 0)
IF NOT EXISTS (SELECT 1 FROM dbo.Product)
DBCC CHECKIDENT ('dbo.Product', RESEED, 0)
IF NOT EXISTS (SELECT 1 FROM dbo.Role)
DBCC CHECKIDENT ('dbo.Role', RESEED, 0)

UPDATE dbo.AspNetUsers SET EmailConfirmed = 1 
WHERE Id = @AdminID

GO

SELECT 'AFTER INSERT:' AS 'Info', * FROM dbo.UserRoles
SELECT 'AFTER INSERT:' AS 'Info', * FROM dbo.ProductCategory
SELECT * FROM dbo.AspNetUsers
SELECT * FROM INFORMATION_SCHEMA.TABLES

ROLLBACK TRAN



--#########################--
/*
SELECT * FROM dbo.Product
SELECT * FROM dbo.Category
--SELECT * FROM dbo.ProductCategory
--SELECT * FROM dbo.AspNetUsers
--SELECT * FROM dbo.Role
--SELECT * FROM dbo.UserRoles
--SELECT * FROM dbo.UserRoles
--SELECT * FROM INFORMATION_SCHEMA.TABLES
*/
--#########################--
