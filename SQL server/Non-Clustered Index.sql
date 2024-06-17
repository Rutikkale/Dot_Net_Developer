use Batch_01_2024;

create table FullTimeEmployees(Id int Primary key,
                               Name varchar(50),
							   Gender varchar(10),
							   Designation varchar(50),
							   Salary int);

insert into FullTimeEmployees values (1,'Yasir','Male','Manager',25000);	
insert into FullTimeEmployees values (2,'Radha','Female','Assistance',20000);							   
insert into FullTimeEmployees values (3,'Sanket','Male','Accountant',35000);
insert into FullTimeEmployees values (4,'Yash','Female','Operator',15000);							   
insert into FullTimeEmployees values (5,'Rutik','Male','Director',45000);		

select*from FullTimeEmployees;

create index IX_FTE_Salary
on FullTimeEmployees (Salary asc);

sp_helpIndex FullTimeEmployees;

select*from FullTimeEmployees where Salary>10000 and Salary<22000;

create NonClustered index IX_FTE_Name_Salary
on FullTimeEmployees (Name asc, Salary asc);

drop index FullTimeEmployees.[IX_FTE_Name_Salary];

create NonClustered index IX_FTE_Name
on FullTimeEmployees (Name asc);

create NonClustered index IX_FTE_Gender
on FullTimeEmployees (Gender asc);


