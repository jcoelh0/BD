CREATE SCHEMA COMPANY
go

CREATE TABLE COMPANY.EMPLOYEE(
	Fname		VARCHAR(15)	NOT NULL,
	Minit		CHAR,
	Lname		VARCHAR(15) NOT NULL,
	Ssn			CHAR(9),
	Bdate		DATE,
	Addr		VARCHAR(30),
	Sex			CHAR,
	Salary		DECIMAL(10,2),
	Super_Ssn	CHAR(9),
	Dno			INT	NOT NULL,
	PRIMARY KEY (Ssn),
	FOREIGN KEY (Super_Ssn) REFERENCES COMPANY.EMPLOYEE(Ssn)
);

CREATE TABLE COMPANY.DEPARTMENT(
	Dname			VARCHAR(15)	NOT NULL,
	Dnumber			INT NOT NULL,
	Mgr_ssn			CHAR(9) NOT NULL,
	Mgr_start_date	DATE,
	PRIMARY KEY (Dnumber),
	UNIQUE(Dname),
	FOREIGN KEY (Mgr_ssn) REFERENCES COMPANY.EMPLOYEE(Ssn)
);

CREATE TABLE COMPANY.DEPT_LOCATIONS(
	Dnumber			INT NOT NULL,
	Dlocation		VARCHAR(15) NOT NULL,
	PRIMARY KEY (Dnumber, Dlocation),
	FOREIGN KEY (Dnumber) REFERENCES COMPANY.DEPARTMENT(Dnumber)
);

CREATE TABLE COMPANY.PROJECT(
	Pname			VARCHAR(15)	NOT NULL,
	Pnumber			INT NOT NULL,
	Plocation		VARCHAR(15),
	Dnum			INT	NOT NULL,
	PRIMARY KEY (Pnumber),
	UNIQUE(Pname),
	FOREIGN KEY (Dnum) REFERENCES COMPANY.DEPARTMENT(Dnumber)
);

CREATE TABLE COMPANY.WORKS_ON(
	Essn	CHAR(9)	NOT NULL,
	Pno		INT		NOT NULL,
	Hours	DECIMAL(3,1)	NOT NULL,
	PRIMARY KEY (Essn, Pno),
	FOREIGN KEY (Essn) REFERENCES COMPANY.EMPLOYEE(Ssn),
	FOREIGN KEY (Pno) REFERENCES COMPANY.PROJECT(Pnumber)
);

CREATE TABLE COMPANY.DEPENDENT(
	Essn			CHAR(9) NOT NULL,
	Dependent_name	VARCHAR(15) NOT NULL,
	Sex				CHAR,
	Bdate			DATE,
	Relationship	VARCHAR(8),
	PRIMARY KEY (Essn, Dependent_name),
	FOREIGN KEY (Essn) REFERENCES COMPANY.EMPLOYEE(Ssn)
);

ALTER TABLE COMPANY.EMPLOYEE
	ADD CONSTRAINT EMPDEPTFK FOREIGN KEY (Dno) REFERENCES COMPANY.DEPARTMENT(Dnumber);