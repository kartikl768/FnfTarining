use fnfTraining;
--Table creation
create table EmpEx(
EmpId int primary key Identity(1,1),
Name nvarchar(50),
salary money,
ManagerId int
);
create table ManEx(
ManagerId int primary key,
MangerName nvarchar(50)
);

--Value Insertion to the table
INSERT INTO ManEx VALUES (1, 'Niranjan');
INSERT INTO ManEx VALUES (2, 'Sudhir');
INSERT INTO ManEx VALUES (3, 'Priya');
INSERT INTO ManEx VALUES (4, 'Anil');
INSERT INTO ManEx VALUES (5, 'Meera');


insert into EmpEx values('Kartik',40000,1);
INSERT INTO EmpEx VALUES ('Asha', 55000, 2);
INSERT INTO EmpEx VALUES ('Ravi', 47000, 1);
INSERT INTO EmpEx VALUES ('Sneha', 62000, 3);
INSERT INTO EmpEx VALUES ('Manoj', 38000, 4);
INSERT INTO EmpEx VALUES ('Divya', 51000, 2);
INSERT INTO EmpEx VALUES ('Arjun', 45000, 5);
INSERT INTO EmpEx VALUES ('Neha', 60000, 3);
INSERT INTO EmpEx VALUES ('Vikram', 43000, 4);
INSERT INTO EmpEx VALUES ('Pooja', 49000, 5);

select * from EmpEx;
select * from ManEx;



--query to print empname and manager name in alphabetical order of emp name
select E.Name AS EmployeeName,
M.MangerName AS ManagerName, M.ManagerId AS ManagerId
from EmpEx E
join ManEx M ON E.ManagerId = M.ManagerId
order by E.Name ASC;
