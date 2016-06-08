/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DELETE FROM Orders;
DELETE FROM Salesperson;
DELETE FROM Customer;


INSERT INTO Salesperson(SalespersonID, Name, Age, Salary)
	VALUES 
		(1, 'Alice',61,140000),
		(2, 'Bob',34,44000),
		(6, 'Chris',34,40000),
		(8, 'Derek',41,52000),
		(11, 'Emmet',57,115000),
		(16, 'Fred',48,38000);

INSERT INTO Customer(CustomerID,Name) 
	VALUES 
	(4,'George'),
	(6,'Harry'),
	(7,'Ingrid'),
	(11,'Jerry');

SET DATEFORMAT dmy;

INSERT INTO ORDERS (OrderID, OrderDate, CustomerID, SalespersonID,NumberOfUnits, CostOfUnit) 
	VALUES 
		(3, '17/01/2013',4,2,4,400),
		(6, '07/02/2013',4,1,1,600),
		(10, '04/03/2013',7,6,2,300),
		(17, '15/03/2013',6,1,5,300),
		(25, '19/04/2013',11,11,7,300),
		(34, '22/04/2013',11,11,100,26),
		(57, '12/07/2013',7,11,14,11);

