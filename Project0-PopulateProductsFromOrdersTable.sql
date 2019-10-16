DROP TABLE IF EXISTS Project0.Project0.ProductsFromOrder; --in case ProductsFromOrder table already exists.

CREATE TABLE Project0.ProductsFromOrder(
	ProductsFromOrder INT PRIMARY KEY IDENTITY, 
	OrderID INT NOT NULL FOREIGN KEY REFERENCES Project0.Orders(OrderId),
	ProductId INT NOT NULL FOREIGN KEY REFERENCES Project0.Products(ProductId),
	Quantity INT NOT NULL DEFAULT 0,
	DateModified DATETIME2 NOT NULL DEFAULT (GETDATE())
);

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


