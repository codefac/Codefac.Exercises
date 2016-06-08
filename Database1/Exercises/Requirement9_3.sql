--Return the names of salespeople that have 2 or more orders. 
SELECT SP.[Name]
FROM Salesperson SP
INNER JOIN Orders O
ON SP.SalespersonID = O.SalespersonID
GROUP BY SP.[Name], SP.SalespersonID
HAVING COUNT( O.SalespersonID ) > 1

