


--CREATE DATABASE Project0_DB;

--CREATE SCHEMA Project0; --create the schema for the DB

GO
--DELETE FROM Project0.Customers WHERE CustomerFirstName = 'Mark';

--SELECT * FROM Project0.ProductsFromOrder;
--SELECT * FROM Project0.Inventory;
--SELECT * FROM Project0.Orders;
--SELECT * FROM Project0.Customers;
--SELECT * FROM Project0.Locations;
--SELECT * FROM Project0.Products;

DROP TABLE IF EXISTS Project0.ProductsFromOrder;--in case ProductsFromOrder table already exists.
DROP TABLE IF EXISTS Project0.Inventory;		--in case Inventory table already exists.
DROP TABLE IF EXISTS Project0.Orders;			--in case Orders table already exists.
DROP TABLE IF EXISTS Project0.Customers;		--in case Customer table already exists.
DROP TABLE IF EXISTS Project0.Locations;		--in case Locations table already exists.
DROP TABLE IF EXISTS Project0.Products;			--in case Products table already exists.

--create the Customer table 
CREATE TABLE Project0.Customers(
	CustomerId			INT				NOT NULL	PRIMARY KEY	IDENTITY,
	CustomerFirstName	NVARCHAR(255)	NOT NULL,
	CustomerLastName	NVARCHAR(255)	NOT NULL,
	DateModified		DATETIME2		NOT NULL	DEFAULT (GETDATE())
	);

CREATE UNIQUE NONCLUSTERED INDEX CustName ON Project0.Customers (CustomerFirstName,
CustomerLastName);

--create the Locations table 
CREATE TABLE Project0.Locations(
	LocationId		INT				NOT NULL	PRIMARY KEY	IDENTITY,
	LocationName	NVARCHAR(255)	NOT NULL	UNIQUE,
	DateModified	DATETIME2		NOT NULL	DEFAULT (GETDATE())
	);

--create products table
CREATE TABLE Project0.Products(
	ProductId		INT				NOT NULL	PRIMARY KEY	IDENTITY,
	ProductName		NVARCHAR(255)	NOT NULL	UNIQUE,
	ProductPrice	MONEY			DEFAULT 0,
	DateModified	DATETIME2		NOT NULL	DEFAULT (GETDATE())
);

--create inventory table
CREATE TABLE Project0.Inventory(
	InventoryId		INT			NOT NULL	PRIMARY KEY	IDENTITY,
	ProductID		INT			NOT NULL	FOREIGN KEY REFERENCES Project0.Products(ProductId),
	LocationName	NVARCHAR(255)			NOT NULL,
	ProductPrice	MONEY					DEFAULT 0,
	ProductQuantity	INT			NOT NULL	DEFAULT 0,
	DateModified	DATETIME2	NOT NULL	DEFAULT (GETDATE())
);


CREATE TABLE Project0.Orders(
	OrderID INT NOT NULL PRIMARY KEY IDENTITY,
	LocationId INT NOT NULL FOREIGN KEY REFERENCES Project0.Locations(LocationId),
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Project0.Customers(CustomerId),
	DateModified DATETIME2 NOT NULL DEFAULT (GETDATE())
);

CREATE TABLE Project0.ProductsFromOrder(
	ProductsFromOrder INT PRIMARY KEY IDENTITY, 
	OrderID INT NOT NULL FOREIGN KEY REFERENCES Project0.Orders(OrderId),
	ProductId INT NOT NULL FOREIGN KEY REFERENCES Project0.Products(ProductId),
	Quantity INT NOT NULL DEFAULT 0,
	DateModified DATETIME2 NOT NULL DEFAULT (GETDATE())
);

INSERT INTO Project0.Locations (LocationName) VALUES ('Dallas');
INSERT INTO Project0.Locations (LocationName) VALUES ('Fort Worth');
INSERT INTO Project0.Locations (LocationName) VALUES ('New York');
INSERT INTO Project0.Locations (LocationName) VALUES ('Paris');
INSERT INTO Project0.Locations (LocationName) VALUES ('Sao Paulo');

INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Mark','Moore');
INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Arely','Moore');
INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Maya','Moore');
INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Joseph','Smith');
INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Maya','Angelou');

INSERT INTO Project0.Products (ProductName, ProductPrice) VALUES ('apple', 20);
INSERT INTO Project0.Products (ProductName, ProductPrice) VALUES ('banana', 20);
INSERT INTO Project0.Products (ProductName, ProductPrice) VALUES ('avacado', 20);
INSERT INTO Project0.Products (ProductName, ProductPrice) VALUES ('beef pound', 20);
INSERT INTO Project0.Products (ProductName, ProductPrice) VALUES ('meat helmet', 20);
INSERT INTO Project0.Products (ProductName, ProductPrice) VALUES ('dragon fruit', 20);
INSERT INTO Project0.Products (ProductName, ProductPrice) VALUES ('cantaloupe', 20);

INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (1, 1);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (2, 2);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (3, 3);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (4, 4);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (5, 5);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (1, 1);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (2, 1);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (3, 2);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (4, 3);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (5, 4);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (1, 5);
INSERT INTO Project0.Orders (LocationId, CustomerId) VALUES (2, 1);

INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (1,'Dallas',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (2,'Dallas',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (3,'Dallas',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (4,'Dallas',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (5,'Dallas',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (6,'Dallas',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (7,'Dallas',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (1,'Fort Worth',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (2,'Fort Worth',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (3,'Fort Worth',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (4,'Fort Worth',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (5,'Fort Worth',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (6,'Fort Worth',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (7,'Fort Worth',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (1,'New York',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (2,'New York',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (3,'New York',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (4,'New York',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (5,'New York',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (6,'New York',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (7,'New York',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (1,'Paris',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (2,'Paris',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (3,'Paris',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (4,'Paris',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (5,'Paris',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (6,'Paris',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (7,'Paris',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (1,'Sao Paulo',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (2,'Sao Paulo',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (3,'Sao Paulo',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (4,'Sao Paulo',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (5,'Sao Paulo',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (6,'Sao Paulo',20,21);
INSERT INTO Project0.Inventory (ProductID, LocationName, ProductPrice, ProductQuantity) VALUES (7,'Sao Paulo',20,21);

INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (1,1,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (1,2,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (1,3,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (2,2,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (2,3,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (2,4,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (3,4,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (3,5,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (4,6,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (5,7,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (5,1,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (6,2,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (7,3,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (8,4,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (9,5,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (10,6,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (11,7,4);
INSERT INTO Project0.ProductsFromOrder (OrderID, ProductId, Quantity) VALUES (12,4,4);

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

