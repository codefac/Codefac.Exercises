--Return the names of all salespeople that do not have any order with George 
SELECT DISTINCT [Name] 
FROM Salesperson SP
WHERE SP.[SalespersonID] NOT IN
			(SELECT O.[SalespersonID]
			 FROM   Customer C
			 INNER JOIN Orders O
			 ON C.CustomerID = O.CustomerID			 
			 WHERE   C.Name = 'George')

