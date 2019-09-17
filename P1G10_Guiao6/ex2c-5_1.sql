--a)
SELECT Pname, Pnumber, Pno, Essn, Ssn FROM project JOIN works_on ON Pnumber=Pno JOIN employee ON Essn=Ssn

--b)
SELECT Fname, Minit, Lname FROM employee JOIN (SELECT Ssn FROM employee WHERE Fname='Carlos' AND Minit='D' AND Lname='Gomes') AS Supervisor ON Super_ssn=Supervisor.Ssn

--c)
SELECT Pname, Pnumber, total FROM project JOIN (SELECT Pno, sum(Hours) AS total FROM works_on GROUP BY Pno) AS hours ON Pnumber=Pno

--d)
SELECT Fname, Minit, Lname, Dno FROM employee JOIN (SELECT Hours, Essn FROM works_on) AS hours ON Hours>20 AND Ssn=Essn JOIN (SELECT Pname FROM project) AS name ON Pname='Aveiro Digital' WHERE Dno='3'

--e)
SELECT Fname FROM employee JOIN (SELECT Pno, Essn FROM works_on) AS workers ON Ssn=Essn WHERE Pno IS NULL

--f)
SELECT Dnumber, Dname, avg(Salary) AS Salary FROM employee JOIN department ON Dno=Dnumber WHERE Sex='F' GROUP BY Dnumber, Dname

--g)
SELECT Fname, Lname FROM employee JOIN (SELECT Essn, count(Relationship) AS rel FROM dependent GROUP BY Essn) AS Relation on Ssn=Essn WHERE rel>2

--h)
SELECT Fname, Lname, Dname, count(Essn) AS dept_mgr FROM employee JOIN department ON Ssn=Mgr_ssn JOIN dependent ON Ssn=Essn GROUP BY Fname, Lname, Dname

--i)
SELECT Fname, Lname, Addr FROM employee JOIN department ON Dno=Dnumber JOIN project ON Plocation='Aveiro' JOIN  dept_location ON Dlocation!='Aveiro'