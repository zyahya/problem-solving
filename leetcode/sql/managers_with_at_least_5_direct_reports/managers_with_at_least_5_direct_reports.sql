SELECT
	m.name
FROM Employee AS m
INNER JOIN Employee AS e
	ON m.id = e.managerId
GROUP BY m.name, m.id
HAVING COUNT(m.id) >= 5;
