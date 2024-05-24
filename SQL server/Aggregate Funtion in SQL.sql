USE Batch_01_2024

create table EmployeeDetails(Empid int unique not null,
                      EmpName varchar(50) not null,
					  EmpDpt varchar(50) not null,
					  Salary int not null);

Select*from EmployeeDetails

truncate table EmployeeDetails

insert into EmployeeDetails values (1,'Rutik kale','Account',25000);
insert into EmployeeDetails values (2,'Arpit kale','Admin','30000');
insert into EmployeeDetails  values (3,'Aashavin Kumar','Placement','27000');
insert into EmployeeDetails values (4,'Sakshi','web developer','25000');
insert into EmployeeDetails values (5,'Kirti ','tester','22000');
insert into EmployeeDetails  values (6,'Surabhi','sport','15000');

/*Aggregate funtion:
                    Sql server aggregate funtion perform a calculation on set of values and return a single value
					1) sum
					2) max
					3) min
					4) avg
					5) count
					*/

Select sum(Salary) as Total_Salary from EmployeeDetails;

Select Max(Salary) as Maxmam_Salary from EmployeeDetails;

Select Min(Salary) as Minimam_Salary from EmployeeDetails;

Select Avg(Salary) as Average_Salary from EmployeeDetails;

Select count(Salary) as count_Salary from EmployeeDetails;