/*Task 1
Create a table in SQL Server with 10 000 000 log entries (date + text). 
Search in the table by date range. Check the speed (without caching).
*/
USE master
GO

CREATE DATABASE PerformanceDB
GO

USE PerformanceDB
GO

CREATE TABLE Logs(
  LogId int IDENTITY,
  LogText nvarchar(100) NOT NULL,
  LogDate datetime,
  CONSTRAINT [PK_Logs] PRIMARY KEY (LogId)
)

USE PerformanceDb
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[up_FillLogs]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].[up_FillLogs]
GO

CREATE PROCEDURE up_FillLogs
@LogsCount int
AS

DECLARE @RowsCount int
SET @RowsCount = @LogsCount

WHILE @RowsCount > 0
BEGIN
	DECLARE @Text nvarchar(100) = 
	'Text ' + CONVERT(nvarchar(100), @RowsCount) + ': ' +
    CONVERT(nvarchar(100), newid())
	
	DECLARE @Date datetime = 
	DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0)
	
	INSERT INTO Logs(LogText, LogDate) Values(@Text, @Date)
	SET @RowsCount = @RowsCount - 1
END

EXEC up_FillLogs 10000

WHILE (SELECT COUNT(*) FROM Logs) < 100000
BEGIN
  INSERT INTO Logs(LogText, LogDate)
  SELECT LogText, LogDate FROM Logs
END

SELECT LogDate FROM Logs
WHERE LogDate BETWEEN '1963-01-01' AND '2063-01-01'

/*Task 2
Add an index to speed up the search by date. Test the search speed (after cleaning the cache).
*/
CREATE INDEX IDX_Logs_LogDate ON Logs(LogDate)

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

/*Task 3
Add a full text index for the text column. 
Try to search with and without the full-text index and compare the speed.
*/
CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT COUNT(*) FROM Logs
WHERE LogText LIKE 'Text 9993%'

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT COUNT(*) FROM Logs
WHERE LogText LIKE '%123%'

CREATE FULLTEXT CATALOG LogsFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Logs(LogText)
KEY INDEX PK_Logs
ON LogsFullTextCatalog
WITH CHANGE_TRACKING AUTO

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT LogText FROM Logs
WHERE CONTAINS(LogText, 'Text')