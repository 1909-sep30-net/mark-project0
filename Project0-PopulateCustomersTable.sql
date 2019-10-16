DROP TABLE IF EXISTS Project0.Project0.Customers; --in case Customer table already exists.

--create the Customer table 
CREATE TABLE Project0.Customers(
	CustomerId			INT				NOT NULL	PRIMARY KEY	IDENTITY,
	CustomerFirstName	NVARCHAR(255)	NOT NULL,
	CustomerLastName	NVARCHAR(255)	NOT NULL,
	DateModified		DATETIME2		NOT NULL	DEFAULT (GETDATE())
	);

CREATE UNIQUE NONCLUSTERED INDEX CustName ON Project0.Customers (CustomerFirstName,
CustomerLastName);

INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Mark','Moore');
INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Arely','Moore');
INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Maya','Moore');
INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Joseph','Smith');
INSERT INTO Project0.Customers (CustomerFirstName, CustomerLastName) VALUES ('Maya','Angelou');


DELETE FROM Project0.Customers
WHERE CustomerFirstName = 'Mark' and CustomerLastName = 'Moore';

--SELECT * FROM Project0.Inventory;
--SELECT * FROM Project0.Products;
--SELECT * FROM Project0.Locations;
--SELECT * FROM Project0.Customers;
--SELECT * FROM Project0.ProductsFromOrder;
--SELECT * FROM Project0.Orders;