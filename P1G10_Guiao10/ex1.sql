DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;

use AdventureWorks2012;

select * from Production.WorkOrder

select * from Production.WorkOrder where WorkOrderID=1234

SELECT * FROM Production.WorkOrder
WHERE WorkOrderID between 10000 and 10010
Query2: SELECT * FROM Production.WorkOrder
WHERE WorkOrderID between 1 and 72591

 SELECT * FROM Production.WorkOrder
WHERE StartDate = '2007-06-25'

SELECT * FROM Production.WorkOrder WHERE ProductID = 757


SELECT WorkOrderID, StartDate FROM Production.WorkOrder
 WHERE ProductID = 757

SELECT WorkOrderID, StartDate FROM Production.WorkOrder
 WHERE ProductID = 945

SELECT WorkOrderID FROM Production.WorkOrder
 WHERE ProductID = 945 AND StartDate = '2006-01-04'

SELECT WorkOrderID, StartDate FROM Production.WorkOrder
WHERE ProductID = 945 AND StartDate = '2006-01-04'

SELECT WorkOrderID, StartDate FROM Production.WorkOrder
WHERE ProductID = 945 AND StartDate = '2006-01-04'
