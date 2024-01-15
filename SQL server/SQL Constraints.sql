USE Batch_01_2024

-- SQL Constraints
-- Unique and not null constraints

create table Employee(Empid int unique not null,
                      EmpName varchar(50) not null,
					  EmpDpt varchar(50) not null,
					  Salary varchar(50) not null);

Select*from Employee

truncate table Employee

insert into Employee values (1,'Rutik kale','Account','25000');
insert into Employee values (2,'Arpit kale','Admin','30000');
insert into Employee values (3,'Aashavin Kumar','','27000');

-- Primary key Constraints

create table Voter_list(Voter_id int primary key,
                        Voter_Name varchar(50) not null,
						Voter_Age int not null);

Select*from Voter_list
drop table Voter_list
truncate table Voter_list
delete from Voter_list 
delete from Voter_list where Voter_Age = 21;

insert into Voter_list values(1,'Rutik Kale',21)
insert into Voter_list values(2,'Arpit Kale',19)


-- Check Constraint

create table Voter_list(Voter_id int primary key,
                        Voter_Name varchar(50) not null,
						Voter_Age int not null check(Voter_Age >=18));

Select*from Voter_list
drop table Voter_list
truncate table Voter_list

insert into Voter_list values(1,'Rutik Kale',21)
insert into Voter_list values(2,'Arpit Kale',19)
insert into Voter_list values(3,'Sanket',18)

-- Select Command

create table Voter_list(Voter_id int primary key,
                        Voter_Name varchar(50) not null,
						Voter_Age int not null check(Voter_Age >=18));

Select*from Voter_list
drop table Voter_list
truncate table Voter_list

insert into Voter_list values(1,'Rutik Kale',21)
insert into Voter_list values(2,'Arpit Kale',19)
insert into Voter_list values(3,'Sanket',20)
insert into Voter_list values(4,'Krish',18)
insert into Voter_list values(5,'Banti',25)

Select*from Voter_list;

select voter_Name, Voter_Age from Voter_list ;

select*from Voter_list Where Voter_id=4 or Voter_id = 5;

select voter_Name, Voter_Age from Voter_list  Where Voter_id=4 or Voter_id = 5; 

select voter_Name from Voter_list  Where Voter_id=4 or Voter_id = 5; 


 -- Select for Ascending order
Select*from Voter_list order by voter_Name asc;

Select*from Voter_list order by voter_Name;

 -- Select for Descending order
Select*from Voter_list order by voter_Name desc;
