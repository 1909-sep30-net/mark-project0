DROP TABLE IF EXISTS Project0.Project0.ProductsFromOrder; --in case ProductsFromOrder table already exists.

CREATE TABLE Project0.ProductsFromOrder(
	ProductsFromOrder INT PRIMARY KEY IDENTITY, 
	OrderID INT NOT NULL FOREIGN KEY REFERENCES Project0.Orders(OrderId),
	ProductId INT NOT NULL FOREIGN KEY REFERENCES Project0.Products(ProductId),
	Quantity INT NOT NULL DEFAULT 0,
	DateModified DATETIME2 NOT NULL DEFAULT (GETDATE())
);