/*--#########################--

Author: Matko Popović

1.Pokrenuti App
2.Run Script t-sql script
3.(Default Admin User) AdminLogin: 
	-username: Admin@gmail.uk
	-password: password

-- Skripta za ProductKategorije 
-- Povezivanje Admina sa Rolom
-- Categ->Prod 
-- reset identity 

--#########################--*/


USE ShopWebDb_MP

--BEGIN TRAN

DECLARE @AdminID AS NVARCHAR(MAX)
DECLARE @RoleAdminID AS NVARCHAR(MAX)

DECLARE @i AS INT
SELECT @i=max(Id) 
	FROM dbo.ProductCategory

SET @AdminID = 
(
	SELECT TOP 1 Id FROM dbo.AspNetUsers 
	WHERE UserName = 'Admin@gmail.uk'
)

SET @RoleAdminID = 
(
	SELECT TOP 1 Id FROM dbo.[Role]
	WHERE [Name] = 'Admin'
)

SELECT @AdminID AS 'ADMIN_id', @RoleAdminID AS 'Role_Id'
--SELECT * FROM dbo.UserRoles
--SELECT * FROM dbo.ProductCategory

DBCC CHECKIDENT ('dbo.ProductCategory', RESEED, @i)

TRUNCATE TABLE dbo.ProductCategory
TRUNCATE TABLE dbo.UserRoles

IF NOT EXISTS 
(SELECT 1 FROM dbo.UserRoles)
	INSERT INTO dbo.UserRoles(UserId, RoleId)
	VALUES (@AdminID, @RoleAdminID)

IF NOT EXISTS 
(SELECT 1 FROM dbo.ProductCategory)
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

UPDATE 
	dbo.Product 
SET 
	UserId = A.Id 
	FROM dbo.AspNetUsers AS A 
	WHERE 
		A.UserName = 'Admin@gmail.uk' -- defaultni Admin kreira Proizvode

GO

SELECT 'AFTER INSERT:' AS 'Info', * FROM dbo.UserRoles
SELECT 'AFTER INSERT:' AS 'Info', * FROM dbo.ProductCategory
SELECT * FROM dbo.AspNetUsers
SELECT * FROM INFORMATION_SCHEMA.TABLES
SELECT * FROM dbo.Product

--ROLLBACK TRAN



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
