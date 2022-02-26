/*
SELECT top(50) e.EmployeeID, e.FirstName, LastName, d.Name as DeprmentName
	from Employees e
	join Departments d on e.DepartmentID = d.DepartmentID
	where d.name = 'Sales'
	order by EmployeeID

select e.FirstName, LastName, e.HireDate ,d.Name as DepName 
	from Employees as e
	JOIN Departments d ON e.DepartmentID = d.DepartmentID
	where HireDate > '1999-01-01'
		and d.Name in ('Sales', 'Finance')
	order by HireDate

select e.EmployeeID, e.FirstName + ' ' + e.LastName as EmployeeName,
	m.FirstName + ' ' + m.LastName as ManagerName,
	d.Name as DepartmentName
	from Employees AS e
	JOIN Employees AS m ON e.ManagerID = m.EmployeeID
	join Departments As d on e.DepartmentID = d.DepartmentID
	order by e.EmployeeID

select FirstName, LastName, Name 
	from EmployeesProjects ep
	join Employees e on ep.EmployeeID = e.EmployeeID
	join Projects p on ep.ProjectID=p.ProjectID

*/

SELECT (SELECT COUNT(JOBTITLE) FROM Employees) - (SELECT COUNT(DISTINCT JobTitle) FROM Employees)

SELECT * FROM Employees GROUP BY JobTitle

SELECT TOP (1) LEN(FirstName) AS LENGHT
	,FirstName
	FROM Employees AS E 
	ORDER BY LENGHT DESC, FirstName

SELECT DISTINCT FirstName FROM Employees
WHERE RIGHT(FirstName, 1) NOT IN ('A', 'E', 'I', 'O', 'U')
OR LEFT(FirstName, 1) NOT IN ('A', 'E', 'I', 'O', 'U')
