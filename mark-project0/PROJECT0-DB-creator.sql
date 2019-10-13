
--GO

--CREATE DATABASE Project0_DB;

--CREATE SCHEMA Project0; --create the schema for the DB
GO

DROP TABLE IF EXISTS Project0.Project0.Customers; --in case Customer table already exists.

--create the Customer table 
CREATE TABLE Project0.Customers(
	CustomerId			INT				NOT NULL	PRIMARY KEY	IDENTITY,
	CustomerFirstName	NVARCHAR(255)	NOT NULL,
	CustomerLastName	NVARCHAR(255)	NOT NULL,
	DateModified		DATETIME2		NOT NULL	DEFAULT (GETDATE())
	);

DROP TABLE IF EXISTS Project0.Project0.Locations; --in case Locations table already exists.

--create the Locations table 
CREATE TABLE Project0.Locations(
	LocationId		INT				NOT NULL	PRIMARY KEY	IDENTITY,
	LocationName	NVARCHAR(255)	NOT NULL	UNIQUE,
	DateModified	DATETIME2		NOT NULL	DEFAULT (GETDATE())
	);

DROP TABLE IF EXISTS Project0.Project0.Products; --in case Products table already exists.

--create products table
CREATE TABLE Project0.Products(
	ProductId		INT				NOT NULL	PRIMARY KEY	IDENTITY,
	ProductName		NVARCHAR(255)	NOT NULL	UNIQUE,
	ProductPrice	MONEY			DEFAULT 0,
	DateModified	DATETIME2		NOT NULL	DEFAULT (GETDATE())
);

DROP TABLE IF EXISTS Project0.Project0.Inventory; --in case Inventory table already exists.

--create inventory table
CREATE TABLE Project0.Inventory(
	InventoryId		INT			NOT NULL	PRIMARY KEY	IDENTITY,
	ProductName		NVARCHAR(255)			NOT NULL,
	LocationName	NVARCHAR(255)			NOT NULL,
	ProductPrice	MONEY					DEFAULT 0,
	ProductQuantity	INT			NOT NULL	DEFAULT 0,
	DateModified	DATETIME2	NOT NULL	DEFAULT (GETDATE())
);

DROP TABLE IF EXISTS Project0.Project0.Orders; --in case Orders table already exists.

CREATE TABLE Project0.Orders(
	OrderID INT NOT NULL PRIMARY KEY IDENTITY,
	ProductId INT NOT NULL FOREIGN KEY REFERENCES Project0.Products(ProductId),
	LocationId INT NOT NULL FOREIGN KEY REFERENCES Project0.Locations(LocationId),
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Project0.Customers(CustomerId),
	DateModified DATETIME2 NOT NULL DEFAULT (GETDATE())
);

-- constraints:
--    NOT NULL - column does not accept NULL as a value.
--    NULL     - column explicitly accepts NULL as a value.
--               (NULL will be the default value)
--    PRIMARY KEY - implies NOT NULL and UNIQUE,
--                  and by default sets a CLUSTERED INDEX.
--    UNIQUE   - value must be unique within this column
--    FOREIGN KEY - by default sets a NONCLUSTERED INDEX
--    CHECK    - enforces that some expression is true for every row
--    DEFAULT  - configures a default value for that column
--    IDENTITY - this sets up an auto-incrementing default,
--               AND prevents anyone from inserting their own value

