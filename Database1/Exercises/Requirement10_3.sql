/* Return the total Amount of orders for each month, ordered by year, then month (both in descending order)  */

SELECT Year(O.OrderDate) as [Year], Month(O.OrderDate) as [Month], Sum(O.CostOfUnit*O.NumberOfUnits) as [TotalAmount]
FROM Orders O
GROUP BY Year(O.OrderDate), Month(O.OrderDate)
ORDER BY Year(O.OrderDate) DESC, Month(O.OrderDate) DESC


