--Return the names of all salespeople that have an order with George

SELECT DISTINCT [Name] 
FROM Salesperson SP
INNER JOIN Orders O
ON SP.SalespersonID = O.SalespersonID
WHERE O.CustomerID IN
			(SELECT [CustomerID] 
			 FROM   Customer C
			WHERE   C.Name = 'George')

