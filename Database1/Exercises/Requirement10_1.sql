--Return the name of the salesperson with the 3rd highest salary.
WITH CTE AS
(
    SELECT Name, Salary, RN = ROW_NUMBER() OVER (ORDER BY Salary DESC)
    FROM dbo.Salesperson
)
SELECT Name
FROM CTE
WHERE RN = 3