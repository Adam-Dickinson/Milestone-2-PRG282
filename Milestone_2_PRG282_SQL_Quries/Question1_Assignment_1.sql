SELECT Title,FirstName,LastName,
CASE
	WHEN PersonType = 'EM' THEN 'Employee'
	WHEN PersonType = 'SC' THEN 'Store Contact'
	WHEN PersonType = 'IN' THEN 'Individual Customer'
	WHEN PersonType = 'SP' THEN 'Sales Person'
	WHEN PersonType = 'VC' THEN 'Vendor Contact'
	WHEN PersonType = 'GC' THEN 'General Contact'
	ELSE ''
	END AS Description
FROM Person.Person