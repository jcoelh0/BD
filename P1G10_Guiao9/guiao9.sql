--a)
-- Apagar primeiro as dependencias e depois o funcionario
CREATE PROC delete_func @SSN char(9) AS
BEGIN
	DELETE FROM COMPANY.DEPENDENT WHERE Essn=@SSN;
	DELETE FROM COMPANY.WORKS_ON WHERE Essn=@SSN;
	UPDATE COMPANY.DEPARTMENT SET Mgr_ssn=null WHERE Mgr_ssn=@SSN;
	DELETE FROM COMPANY.EMPLOYEE WHERE Ssn=@SSN;
END

GO

--b)
CREATE PROCEDURE p_gestores (@Ssn char(9) OUTPUT, @Fname varchar(15) OUTPUT, @Lname varchar(15) OUTPUT, @diff int OUTPUT)
AS
BEGIN
	

	SELECT Ssn, Fname, Lname
	FROM COMPANY.EMPLOYEE JOIN COMPANY.DEPARTMENT ON Ssn=Mgr_ssn;
	
	SELECT TOP 1  @Ssn=Ssn, @Fname=Fname, @Lname=Lname, @diff=DATEDIFF(year, Mgr_start_date, CONVERT (date, SYSDATETIME()))
	FROM COMPANY.EMPLOYEE JOIN COMPANY.DEPARTMENT ON Ssn=Mgr_ssn
	ORDER BY Mgr_start_date;

	
END

go

DECLARE @Ssn char(9);
DECLARE @Fname varchar(15);
DECLARE @Lname varchar(15);
DECLARE @diff int;
EXEC p_gestores @Ssn OUTPUT, @Fname OUTPUT, @Lname OUTPUT, @diff OUTPUT;
SELECT @Ssn, @Fname, @Lname, @diff;

go

--c) 

CREATE TRIGGER t_funcDeprtm ON COMPANY.DEPARTMENT AFTER INSERT, UPDATE AS
BEGIN
	DECLARE @Ssn as char(9)
	SELECT @Ssn=Mgr_ssn FROM inserted
	IF EXISTS(SELECT Mgr_ssn FROM COMPANY.DEPARTMENT WHERE Mgr_ssn=@Ssn)
	BEGIN
		ROLLBACK TRAN;
		RAISERROR('Funcionario so pode gerir um departamento', 16, 1);
	END
END

GO

--d)
CREATE TRIGGER t_funcSalary ON COMPANY.EMPLOYEE
INSTEAD OF INSERT, UPDATE
AS
BEGIN
	
	DECLARE @Salary as decimal(10,2);
	DECLARE @ESalary as decimal(10,2) = NULL;
	DECLARE @IsUpdate as int;

	SELECT @Salary=Salary FROM inserted;
	SELECT @IsUpdate=COUNT(*) FROM deleted;


	SELECT @ESalary=Employee.Salary
	FROM inserted JOIN COMPANY.DEPARTMENT ON inserted.Dno=Dnumber
		JOIN COMPANY.EMPLOYEE ON Mgr_ssn=Employee.Ssn
	WHERE Employee.Salary<@Salary;

	if(@IsUpdate = 0)
	BEGIN
		if (@ESalary = NULL)
		BEGIN
			INSERT INTO COMPANY.EMPLOYEE
			SELECT *
			FROM inserted;
		END
	ELSE
		BEGIN
			INSERT INTO COMPANY.EMPLOYEE (Fname, Minit, Lname, Ssn, Bdate, [Address], Sex, Salary, Super_ssn, Dno)
			SELECT Fname, Minit, Lname, Ssn, Bdate, [Address], Sex, @ESalary-1, Super_ssn, Dno
			FROM inserted;
		END
	END
	ELSE
	BEGIN
		if (@ESalary = NULL)
		BEGIN
			UPDATE COMPANY.EMPLOYEE
			SET Fname=inserted.Fname, Minit=inserted.Minit, Lname=inserted.Lname, Ssn=inserted.Ssn, Bdate=inserted.Bdate, [Address]=inserted.[Address], Sex=inserted.Sex, Salary=inserted.Salary, Super_ssn=inserted.Super_ssn, Dno=inserted.Dno
			FROM deleted JOIN inserted ON deleted.Ssn=inserted.Ssn;
		END
		ELSE
		BEGIN
			UPDATE COMPANY.EMPLOYEE
			SET Fname=inserted.Fname, Minit=inserted.Minit, Lname=inserted.Lname, Ssn=inserted.Ssn, Bdate=inserted.Bdate, [Address]=inserted.[Address], Sex=inserted.Sex, Salary=@ESalary-1, Super_ssn=inserted.Super_ssn, Dno=inserted.Dno
			FROM deleted JOIN inserted ON deleted.Ssn=inserted.Ssn;
		END
	END
	
END

go

SELECT * FROM COMPANY.EMPLOYEE;
INSERT INTO COMPANY.EMPLOYEE VALUES ('Diogo', 'A', 'F', 123456789, GETDATE(), 'RUA DE ARVORE', 'M', 50000, NULL, 2);
DELETE FROM COMPANY.EMPLOYEE WHERE Ssn=123456789

go


--e)
CREATE FUNCTION COMPANY.funcProj (@Ssn char(9)) RETURNS Table AS
	RETURN(SELECT Pname, Plocation FROM COMPANY.EMPLOYEE JOIN COMPANY.WORKS_ON ON Ssn=Essn JOIN COMPANY.PROJECT ON Pno=Pnumber	WHERE Ssn=@Ssn);

GO

-- f) 
CREATE FUNCTION COMPANY.f_bestAvgSalary(@dno int) RETURNS TABLE
as

	RETURN(
		SELECT Ssn
		FROM COMPANY.EMPLOYEE
		WHERE DNO=@Dno AND Salary>(
			SELECT AVG(Salary)
			FROM COMPANY.EMPLOYEE
			WHERE Dno=@Dno
		));

go

SELECT * FROM COMPANY.EMPLOYEE
SELECT * FROM COMPANY.f_bestAvgSalary(3)

go

--g)
CREATE FUNCTION COMPANY.employeeDeptHighAverage(@dno int) RETURNS @table Table (pname varchar(15), pnumber int, plocation varchar(15), dnum int, budget decimal(10,2), totalbudget decimal(10,2)) AS
BEGIN
	DECLARE @pname as varchar(15), @pnumber as int, @plocation as varchar(15), @dnum as int, @budget as decimal(10,2), @totalbudget as decimal(10,2);
	DECLARE CRS CURSOR FAST_FORWARD
	FOR SELECT Pname, Pnumber, Plocation, Dnumber, SUM(Salary*[Hours]/40) FROM COMPANY.DEPARTMENT 
		JOIN COMPANY.PROJECT ON Dnumber=Dnum
		JOIN COMPANY.WORKS_ON ON Pnumber=Pno
		JOIN COMPANY.EMPLOYEE ON Essn=Ssn
	WHERE Dnumber=@dno GROUP BY Pname, Pnumber, Plocation, Dnumber;

	OPEN CRS;
	
	FETCH CRS INTO @pname, @pnumber, @plocation, @dnum, @budget;
	SELECT @totalbudget = 0;

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @totalbudget += @budget;
		INSERT INTO @table VALUES (@pname, @pnumber, @plocation, @dnum, @budget, @totalbudget)
		FETCH CRS INTO @pname, @pnumber, @plocation, @dnum, @budget;
	END

	CLOSE CRS;
	DEALLOCATE CRS;

	RETURN;
END

GO

--h)
-- A vantagem de usar um trigger "instead of" é podermos eliminar todas as dependências do departamento antes de o eliminar efetivamente
CREATE TRIGGER COMPANY.t_DeleteDepartment ON COMPANY.DEPARTMENT
INSTEAD OF DELETE
AS
BEGIN

	IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
		WHERE TABLE_SCHEMA = 'COMPANY' AND TABLE_NAME = 'DEPARTMENT_DELETED'))
		BEGIN
			CREATE TABLE COMPANY.DEPARTMENT_DELETED (Dname varchar(15) NOT NULL, Dnumber int PRIMARY KEY, Mgr_ssn char(9), Mgr_start_date date);
		END

	DELETE FROM COMPANY.PROJECT WHERE Dnum in (SELECT Dnumber FROM deleted);
	UPDATE COMPANY.EMPLOYEE SET Dno=NULL WHERE DNO IN (SELECT Dnumber FROM deleted);
	INSERT INTO COMPANY.DEPARTMENT_DELETED SELECT * FROM DELETED;
	DELETE FROM COMPANY.DEPARTMENT WHERE Dnumber IN (SELECT Dnumber FROM deleted);

END

go

SELECT * FROM COMPANY.DEPARTMENT;
DELETE FROM COMPANY.DEPARTMENT WHERE Dnumber=5;

go

--i)
/*
	Um Stored Procedure é uma batch armazenada com um nome, que tem como vantagem não ser necessário recompilar
	o código sempre que o procedimento é invocado. Os procedimentos são guardados em cache na primeira vez
	que são executados, sendo que posteriormente não é necessário aceder à memória.

	Os Stored Procedures podem ter argumentos de entrada e podem retornar valores escalares.

	As UDF's possuem os mesmos benefícios dos store procedures. São igualmente compilados e otimizados, e podem aceitar argumentos de entrada.
	As UDF's obrigatoriamente retornam sempre um valor, que pode ser escalar ou uma tabela.

	Ao contrario das UDF's, os stored procedures podem alterar o estado da base de dados com insert's, update's e delete's.
	Store Procedures também suportam o uso de blocos try... catch, enquanto que as UDF's também não suportam.

	No caso de ser necessário alterar tabelas da base de dados, o mais adequado seria usar um procedure.
	Se fosse necessário retornar uma tabela, o mais adequado seria usar UDF's.

*/

