/* Create a new roll­up table BigOrders(where columns are CustomerID, TotalOrderValue), and insert into that table customers whose total Amount across all orders is greater than 1000  */
If(OBJECT_ID('tempdb..#BigOrders') Is Not Null)
Begin
    Drop Table #BigOrders
End

CREATE TABLE #BigOrders
(
	CustomerID INT NOT NULL,
    TotalOrderValue MONEY NOT NULL
)

INSERT INTO #BigOrders(CustomerID, TotalOrderValue) 
(SELECT O.[CustomerID], Sum(O.CostOfUnit*O.NumberOfUnits)
FROM Orders O
GROUP BY O.[CustomerID]
HAVING Sum(O.CostOfUnit*O.NumberOfUnits) > 1000);


SELECT * FROM #BigOrders


