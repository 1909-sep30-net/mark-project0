
DROP TABLE IF EXISTS Project0.Project0.Orders; --in case Orders table already exists.

CREATE TABLE Project0.Orders(
	OrderID INT NOT NULL PRIMARY KEY IDENTITY,
	LocationId INT NOT NULL FOREIGN KEY REFERENCES Project0.Locations(LocationId),
	CustomerId INT NOT NULL FOREIGN KEY REFERENCES Project0.Customers(CustomerId),
	DateModified DATETIME2 NOT NULL DEFAULT (GETDATE())
);



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

SELECT * FROM Project0.Orders;