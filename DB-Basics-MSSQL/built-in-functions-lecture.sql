
select format (CAST('2010-01-01' as datetime2), 'MMMM', 'bg-BG')
select format (convert(datetime2, '2010-01-01'), 'MMMM', 'bg-BG')
select format (GETDATE(), 'MMMM', 'bg-BG')

SELECT * FROM
(
	SELECT TOP (500) [EmployeeID]
      ,[FirstName]
      ,[LastName]
	  ,LEFT([JobTitle], 26) + REPLICATE('*', LEN(JobTitle) - 6) as [Job Title]
      ,[DepartmentID]
      ,[ManagerID]
      ,[Salary]
	  ,ROW_NUMBER() OVER(ORDER BY Salary DESC) AS RownNum
	  ,RANK() OVER(ORDER BY Salary DESC) AS Rank
	  ,DENSE_RANK() OVER(ORDER BY Salary DESC) AS DRank
	  ,NTILE(2) OVER(ORDER BY Salary DESC) AS GroupNo
	  ,MIN(Salary) OVER(ORDER BY Salary DESC) AS [SalarySum]
  FROM [Softuni].[dbo].[Employees]
  where JobTitle like '[^EF]%anag_[A-Z]%' escape '%'
  ORDER BY DepartmentID desc
) as tempResults
  WHERE GroupNo=1
  
  select CHARINDEX('cheap', 'I sell cheap cars. My cars are cheap', 8)

  select stuff('I sell Â‚ÚËÌË cars. My cars are cheap', 32, 6, N'≈¬“»Õ»     !!!!')



  select SQRT(PI()), POWER(PI(), 3), ROUND(132464564.1284, -5), FLOOR(5.9999), CEILING(4.1), round(1.5001, 0)
	,RAND()

DECLARE @text NVARCHAR(100)
SET @text = 'This is line 1.' + CHAR(13) + 'This is line 2.'
SELECT @text

select datepart(QUARTER, CAST('2020-11-01' as datetime))

*/

SELECT [Name]
      ,[Description]
      ,[StartDate]
      ,[EndDate]
	  ,DATEPART(quarter, StartDate)
	  ,DATEDIFF(second, '1976-12-20', GETDATE())
	  ,DATEAdd(year, 5, StartDate)
	  ,FORMAT(StartDate, 'yyyy MMMM dd (dddd)', 'bg-BG')
	  ,ROW_NUMBER() OVER(ORDER by EndDate DESC)
  FROM [Softuni].[dbo].[Projects]
  order by StartDate
  offset 11 rows
  fetch next 10 rows only


select DATEDIFF(YEAR, '1976-12-20', GETDATE())
select DATEDIFF(hour, '1976-12-20', '2020-08-27')
select DATENAME(weekday, '2006-11-16')

select CAST('2020-01-01' AS datetime2)

select coalesce(null, 5, null, 6, 7, 8)

select Name as Game, 
	--Start,
	CASE
		WHEN DATEPART(hour, Start) < 12 THEN 'Morning'
		WHEN DATEPART(hour, Start) < 18 THEN 'Afternoon'
		ELSE 'Evening'
	END as [Part of the day],
	--Duration,
	CASE
		WHEN Duration <= 3 THEN 'Extra Short'
		WHEN Duration <= 6 THEN 'Short'
		WHEN Duration is null THEN 'Extra Long'
		ELSE 'Long'
	END as [Duration]
from Games
order by Game, Duration

select ProductName,
	OrderDate,
	DATEADD (DAY, 3, OrderDate) as [Pay Due], 
	DATEADD (MONTH, 1, OrderDate) as [Deliver Due]
from orders


