use Northwind;

--10.3-a)
--i. 
CREATE UNIQUE CLUSTERED INDEX IxSSN ON Employee(Ssn);
--ii. 
CREATE CLUSTERED INDEX IxEmployeeName ON Employee(FName, LName);
--iii. 
CREATE INDEX IxDno ON Employee(Dno);
CREATE UNIQUE CLUSTERED INDEX IxDnumber ON Department(Dnumber);
--iv. 
CREATE INDEX IxPno ON Works_On(Pno);
CREATE UNIQUE CLUSTERED INDEX IxPnumber ON Project(Pnumber);
--v. 
CREATE CLUSTERED INDEX IxEssn ON Dependent(Essn);
--vi.
CREATE CLUSTERED INDEX IxDnum On Project(Dnum);
