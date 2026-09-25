SELECT I.unique_id, E.name
FROM Employees AS E
FULL JOIN EmployeeUNI AS I
ON E.id = I.id;
