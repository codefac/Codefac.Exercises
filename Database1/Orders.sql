CREATE TABLE [dbo].[Orders]
(
	[OrderID] INT NOT NULL PRIMARY KEY, 
    [OrderDate] DATE NOT NULL, 
    [CustomerID] INT NULL, 
    [SalespersonID] INT NULL, 
    [NumberOfUnits] INT NOT NULL, 
    [CostOfUnit] MONEY NOT NULL, 
    CONSTRAINT [FK_Orders_Salesperson_SalespersonId] FOREIGN KEY ([SalespersonID]) REFERENCES [Salesperson]([SalespersonID]) ON DELETE SET NULL,
    CONSTRAINT [FK_Orders_Customer_CustomerId] FOREIGN KEY ([CustomerID]) REFERENCES [Customer]([CustomerID]) ON DELETE SET NULL

)
