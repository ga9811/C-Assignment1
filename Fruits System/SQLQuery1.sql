CREATE TABLE Fruits (

  ProductName NVARCHAR(50),
  ProductID INT PRIMARY KEY,
  Amount DECIMAL(10,2),
  Price DECIMAL(10,2)
);
INSERT INTO Fruits (ProductName, ProductID, Amount, Price)
VALUES ('Apple', 124567, 23, 2.10);

INSERT INTO Fruits (ProductName, ProductID, Amount, Price)
VALUES ('Orange', 345678, 20, 2.49);

INSERT INTO Fruits (ProductName, ProductID, Amount, Price)
VALUES ('Raspberry', 125678, 25, 2.35);

INSERT INTO Fruits (ProductName, ProductID, Amount, Price)
VALUES ('Blueberry', 456732, 29, 1.45);

INSERT INTO Fruits (ProductName, ProductID, Amount, Price)
VALUES ('Cauliflower', 238901, 24, 2.22);