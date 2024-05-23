create database Batch_01_2024;
use Batch_01_2024;

--SQL Joints--
/*SQL Joints :- SQL Joints are used to combine two or more table Data in a ResultSet

A- 5 column B-4 Column
1) Inner Join
2) Left Join
3) Right Join
4) Full Outer Join */

create table Employee_Tbl (Emp_id int Unique Not Null,
                           Emp_Name varchar(50) not null,
						   Email varchar(50) not null,
						   Designation varchar(50) not null);

select*from Employee_Tbl;

truncate table Employee_Tbl;
drop table Employee_Tbl;

insert into Employee_Tbl values(11,'Ram','ram123@Gmil.com','Manager');
insert into Employee_Tbl values(22,'Rajesh','Rajesh123@Gmil.com','Assistant Manager');
insert into Employee_Tbl values(33,'Ravi','ravi23@Gmil.com','IT Incharge');
insert into Employee_Tbl values(44,'Lakhan','Lakhan123@Gmil.com','Computer Operator');
insert into Employee_Tbl values(55,'Amin','Amin3@Gmil.com','Office Boy');
insert into Employee_Tbl values(66,'Amar','Amar7@Gmil.com','Sport teacher');

create table Department(Dpt_id int Unique not null,
                        Dpt_Name varchar(50) not null,
						Dpt_Salary varchar(50)not null,
						Emp_id int Unique not null);

insert into Department values(111,'IT consultant','65000',11);
insert into Department values(222,'HR Department','65000',55);
insert into Department values(333,'Admin','65000',44);
insert into Department values(444,'Accounts','65000',33);
insert into Department values(555,'office incharge','65000',22);
insert into Department values(666,'office incharge','65000',77);


select*from Department;

truncate table Department;
drop table Department;

select*from Employee_Tbl;
select*from Department;

--Inner Join--
select * From Employee_Tbl as A 
inner join Department as B on
A.Emp_id = B.Emp_id;

select A.Emp_name , A.Designation,B.Dpt_Name, B.Dpt_Salary from Employee_Tbl as A 
inner join Department as B on A.Emp_id = B.Emp_id;

--left Join--
select * From Employee_Tbl as A 
left join Department as B on
A.Emp_id = B.Emp_id;

select A.Emp_name , A.Designation,B.Dpt_Name, B.Dpt_Salary from Employee_Tbl as A 
left join Department as B on A.Emp_id = B.Emp_id;

--Right Join--
select * From Employee_Tbl as A 
right join Department as B on
A.Emp_id = B.Emp_id;

select A.Emp_name , A.Designation,B.Dpt_Name, B.Dpt_Salary from Employee_Tbl as A 
right join Department as B on A.Emp_id = B.Emp_id;

--Full Outer Join--
select * From Employee_Tbl as A 
full outer join Department as B on
A.Emp_id = B.Emp_id;

select A.Emp_name , A.Designation,B.Dpt_Name, B.Dpt_Salary from Employee_Tbl as A 
full outer join Department as B on A.Emp_id = B.Emp_id;



----Self Join ---------------

create table Employee_Manager(Emp_id int primary key,
                              Emp_Name varchar(50) not null,
							  Manager_id int not null);

select*from Employee_Manager;

insert into Employee_Manager values(1,'Rutik',4);
insert into Employee_Manager values(2,'Arpit',4);
insert into Employee_Manager values(3,'Harshal',5);
insert into Employee_Manager values(4,'Rupesh',6);
insert into Employee_Manager values(5,'Sarthak',1);
insert into Employee_Manager values(6,'Abhishek',1);

select A.Emp_Name as Employee, B.Emp_Name as Manager from Employee_Manager as A 
inner join Employee_Manager as B 
on A.Manager_id= B.Emp_id;