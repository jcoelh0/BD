-- 1)
DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
SELECT * FROM PRODUCTION.WorkOrder

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
select * from Production.WorkOrder where WorkOrderID=1234

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
SELECT * FROM Production.WorkOrder
WHERE WorkOrderID between 10000 and 10010


DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
SELECT * FROM Production.WorkOrder
WHERE WorkOrderID between 1 and 72591

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
SELECT * FROM Production.WorkOrder
WHERE StartDate = '2007-06-25'

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
CREATE INDEX idxProductID ON Production.WorkOrder(ProductID)
SELECT * FROM Production.WorkOrder WHERE ProductID = 757

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
CREATE INDEX IxProductID ON Production.WorkOrder (ProductID) INCLUDE (StartDate)
SELECT WorkOrderID, StartDate FROM Production.WorkOrder
WHERE ProductID = 757

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
SELECT WorkOrderID, StartDate FROM Production.WorkOrder
WHERE ProductID = 945

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
SELECT WorkOrderID FROM Production.WorkOrder
WHERE ProductID = 945 AND StartDate = '2006-01-04'

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
CREATE INDEX IdxStartDate ON Production.WorkOrder (StartDate)
SELECT WorkOrderID, StartDate FROM Production.WorkOrder
WHERE ProductID = 945 AND StartDate = '2006-01-04'

DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
CREATE INDEX IdxStartDateProductId ON Production.WorkOrder (ProductId, StartDate)
SELECT WorkOrderID, StartDate FROM Production.WorkOrder
WHERE ProductID = 945 AND StartDate = '2006-01-04'

-- 2)
CREATE TABLE mytemp (
	rid BIGINT /*IDENTITY (1, 1)*/ NOT NULL,
	at1 INT NULL,
	at2 INT NULL,
	at3 INT NULL,
	lixo varchar(100) NULL
);

--a)
CREATE CLUSTERED INDEX ixRid on mytemp(rid)

--B)
-- Record the Start Time
DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (rid, at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem*40000) as int), cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'

-- 90948 ms

-- Duration of Insertion Process
SET @end_time = GETDATE();
PRINT 'Milliseconds used: ' + CONVERT(VARCHAR(20), DATEDIFF(MILLISECOND,
		@start_time, @end_time));


SELECT * FROM sys.dm_db_index_physical_stats (DB_ID(), OBJECT_ID('mytemp'), NULL, NULL, 'DETAILED') as S

-- Fragmentação: 98,70%
-- Ocupação: 69,18%

-- c)

DELETE FROM mytemp;

ALTER INDEX ALL on mytemp REBUILD WITH (FILLFACTOR=65)

-- Record the Start Time
DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (rid, at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem*40000) as int), cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'

-- 103002 ms
SELECT * FROM sys.dm_db_index_physical_stats (DB_ID(), OBJECT_ID('mytemp'), NULL, NULL, 'DETAILED') as S

-- Fragmentação: 98,70%
-- Ocupação: 68,77%


DELETE FROM mytemp;

ALTER INDEX ALL on mytemp REBUILD WITH (FILLFACTOR=80)

-- Record the Start Time
DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (rid, at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem*40000) as int), cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'

-- 101002 ms
SELECT * FROM sys.dm_db_index_physical_stats (DB_ID(), OBJECT_ID('mytemp'), NULL, NULL, 'DETAILED') as S

-- Fragmentação: 98,69%
-- Ocupação: 69,92%

DELETE FROM mytemp;

ALTER INDEX ALL on mytemp REBUILD WITH (FILLFACTOR=90)

-- Record the Start Time
DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (rid, at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem*40000) as int), cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'

-- 104732 ms
SELECT * FROM sys.dm_db_index_physical_stats (DB_ID(), OBJECT_ID('mytemp'), NULL, NULL, 'DETAILED') as S

-- Fragmentação: 98,71%
-- Ocupação: 68,77%


-- d)

DROP TABLE mytemp;
CREATE TABLE mytemp (
	rid BIGINT IDENTITY (1, 1) NOT NULL,
	at1 INT NULL,
	at2 INT NULL,
	at3 INT NULL,
	lixo varchar(100) NULL
);

CREATE CLUSTERED INDEX ixRid on mytemp(rid) WITH (FILLFACTOR=65)

DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'


-- Duration of Insertion Process
SET @end_time = GETDATE();
PRINT 'Milliseconds used: ' + CONVERT(VARCHAR(20), DATEDIFF(MILLISECOND,
		@start_time, @end_time));


-- 139518 ms

SELECT * FROM sys.dm_db_index_physical_stats (DB_ID(), OBJECT_ID('mytemp'), NULL, NULL, 'DETAILED') as S

-- Fragmentação: 67,91%
-- Ocupação: 99,61%


ALTER INDEX ALL on mytemp REBUILD WITH (FILLFACTOR=80)

DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'


-- Duration of Insertion Process
SET @end_time = GETDATE();
PRINT 'Milliseconds used: ' + CONVERT(VARCHAR(20), DATEDIFF(MILLISECOND,
		@start_time, @end_time));


-- 115753 ms

SELECT * FROM sys.dm_db_index_physical_stats (DB_ID(), OBJECT_ID('mytemp'), NULL, NULL, 'DETAILED') as S

-- Fragmentação: 90,36%
-- Ocupação: 89,24%


ALTER INDEX ALL on mytemp REBUILD WITH (FILLFACTOR=90)

DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'


-- Duration of Insertion Process
SET @end_time = GETDATE();
PRINT 'Milliseconds used: ' + CONVERT(VARCHAR(20), DATEDIFF(MILLISECOND,
		@start_time, @end_time));


-- 121496 ms

SELECT * FROM sys.dm_db_index_physical_stats (DB_ID(), OBJECT_ID('mytemp'), NULL, NULL, 'DETAILED') as S

-- Fragmentação: 42,10%
-- Ocupação: 93,25%

-- e)

-- Sem índices

DROP INDEX ixRid on mytemp

DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'


-- Duration of Insertion Process
SET @end_time = GETDATE();
PRINT 'Milliseconds used: ' + CONVERT(VARCHAR(20), DATEDIFF(MILLISECOND,
		@start_time, @end_time));


-- 110173 ms

-- Com índices
CREATE INDEX ix1 on mytemp(rid)
CREATE INDEX ix2 on mytemp(at1)
CREATE INDEX ix3 on mytemp(at2)
CREATE INDEX ix4 on mytemp(at3)
CREATE INDEX ix5 on mytemp(lixo)

DELETE FROM mytemp;

DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON

WHILE @val <= @nelem
BEGIN

	DBCC DROPCLEANBUFFERS; -- need to be sysadmin

	INSERT mytemp (at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem) as int),
			cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
			'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	SET @val = @val + 1;
END

PRINT 'Inserted ' + str(@nelem) + ' total records'


-- Duration of Insertion Process
SET @end_time = GETDATE();
PRINT 'Milliseconds used: ' + CONVERT(VARCHAR(20), DATEDIFF(MILLISECOND,
		@start_time, @end_time));


-- 188493 ms
