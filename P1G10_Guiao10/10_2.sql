/*CREATE TABLE mytemp (
	rid BIGINT /*IDENTITY (1, 1)*/ NOT NULL,
	at1 INT NULL,
	at2 INT NULL,
	at3 INT NULL,
	lixo varchar(100) NULL
);

--a)
CREATE CLUSTERED INDEX Index_rid on mytemp(rid);


--c)
--alter INDEX Index_rid ON mytemp rebuild with (fillfactor = 65)
--Inserted      50000 total records
--Milliseconds used: 14384

--alter INDEX Index_rid ON mytemp rebuild with (fillfactor = 80)
--Inserted      50000 total records
--Milliseconds used: 16090

--alter INDEX Index_rid ON mytemp rebuild with (fillfactor = 90)
--Inserted      50000 total records
--Milliseconds used: 14307

--d)
drop table mytemp;
CREATE TABLE mytemp (
	rid BIGINT IDENTITY (1, 1) NOT NULL,
	at1 INT NULL,
	at2 INT NULL,
	at3 INT NULL,
	lixo varchar(100) NULL
);
Inserted      50000 total records
Milliseconds used: 18043

--e)
CREATE INDEX at1_rid ON mytemp(at1);
CREATE INDEX at2_rid ON mytemp(at2);
CREATE INDEX at3_rid ON mytemp(at3);
CREATE INDEX lixo_rid ON mytemp(lixo);
Inserted      50000 total records
Milliseconds used: 21440

drop index at1_rid on mytemp;
drop index at2_rid on mytemp;
drop index at3_rid on mytemp;
drop index lixo_rid on mytemp;
Inserted      50000 total records
Milliseconds used: 18577

Sem indexes é necessário menos tempo para adicionar o mesmo numero de records*/



-- Record the Start Time
DECLARE @start_time DATETIME, @end_time DATETIME;
SET @start_time = GETDATE();
PRINT @start_time

-- Generate random records
DECLARE @val as int = 1;
DECLARE @nelem as int = 50000;

SET nocount ON WHILE @val <= @nelem
BEGIN
	--DBCC DROPCLEANBUFFERS; -- need to be sysadmin
	SET IDENTITY_INSERT mytemp ON
	INSERT mytemp (rid, at1, at2, at3, lixo)
	SELECT cast((RAND()*@nelem*40000) as int), cast((RAND()*@nelem) as int),
	cast((RAND()*@nelem) as int), cast((RAND()*@nelem) as int),
	'lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo...lixo';
	
	SET @val = @val + 1;
	SET IDENTITY_INSERT mytemp OFF
END

PRINT 'Inserted ' + str(@nelem) + ' total records'

-- Duration of Insertion Process
SET @end_time = GETDATE();
PRINT 'Milliseconds used: ' + CONVERT(VARCHAR(20), DATEDIFF(MILLISECOND, @start_time, @end_time));

--b)
--Inserted      50000 total records
--Milliseconds used: 16804
--Page fullness = 68.41%
--Total fragmentation = 99.24%
